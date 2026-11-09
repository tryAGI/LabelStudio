install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://raw.githubusercontent.com/HumanSignal/label-studio-client-generator/master/fern/openapi/openapi.yaml

# Convert apiKey auth to http/bearer for AutoSDK compatibility
# Label Studio uses "Token <key>" prefix — we'll handle that in PrepareRequest
yq -i '
  .components.securitySchemes.Token = {
    "type": "http",
    "scheme": "bearer"
  } |
  .security = [{"Token": []}]
' openapi.yaml

# The API omits `username` on the embedded user object, while the spec marks it required - so
# anything carrying `created_by` (29 schemas, project create and get among them) failed to
# deserialize a successful response. Found by probing a live instance, not by reading the spec:
# the field has no default, so the required-with-default audit could not have flagged it.
#
# The same create response sends every computed counter as null - the project has no tasks yet -
# while LseProjectCreate types them as plain integers; the sibling LseProject schema already marks
# `num_tasks_with_annotations` nullable, so this applies that to the whole family rather than
# chasing one field per failed run. `id` is excluded: it is the one read-only integer the create
# response really does carry.
yq -i '.components.schemas.UserSimple.required |= map(select(. != "username"))' openapi.yaml
yq -i '(.components.schemas.LseProjectCreate.properties[] | select(.readOnly == true and .type == "integer")) |= (.nullable = true)' openapi.yaml
# `id` is the one read-only integer the create response really does carry.
yq -i 'del(.components.schemas.LseProjectCreate.properties.id.nullable)' openapi.yaml

# yq -i exits 0 even when its expression fails to parse, so verify the effect rather than the exit
# code - a silent no-op here puts the deserialization bugs straight back.
if yq -e '.components.schemas.UserSimple.required | contains(["username"])' openapi.yaml >/dev/null 2>&1 ||
   ! yq -e '.components.schemas.LseProjectCreate.properties.task_number.nullable' openapi.yaml >/dev/null 2>&1; then
  echo "error: the response-shape patches did not apply to openapi.yaml." >&2
  exit 1
fi

autosdk generate openapi.yaml \
  --namespace LabelStudio \
  --clientClassName LabelStudioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
