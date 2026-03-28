dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/HumanSignal/label-studio-client-generator/master/fern/openapi/openapi.yaml

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
