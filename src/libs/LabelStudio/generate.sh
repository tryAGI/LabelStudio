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

autosdk generate openapi.yaml \
  --namespace LabelStudio \
  --clientClassName LabelStudioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
