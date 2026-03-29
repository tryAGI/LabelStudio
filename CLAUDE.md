# CLAUDE.md — LabelStudio SDK

## Overview

Auto-generated C# SDK for [Label Studio](https://labelstud.io/) — open-source data labeling and annotation platform for ML with 30k+ GitHub stars. Supports projects, tasks, annotations, ML backends, webhooks, and storage integrations (S3, GCS, Azure, Redis).
OpenAPI spec from the official [HumanSignal/label-studio-client-generator](https://github.com/HumanSignal/label-studio-client-generator) Fern definition.

## Build & Test

```bash
dotnet build LabelStudio.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Token-based auth (`Authorization: Token <api_key>`):

```csharp
var client = new LabelStudioClient(apiKey); // LABEL_STUDIO_API_KEY env var
```

The SDK converts Bearer auth to Label Studio's `Token` scheme via a `PrepareRequest` hook.

## Key Files

- `src/libs/LabelStudio/openapi.yaml` — OpenAPI spec (downloaded from HumanSignal/label-studio-client-generator)
- `src/libs/LabelStudio/generate.sh` — Downloads spec, converts apiKey auth to http/bearer, runs autosdk
- `src/libs/LabelStudio/Generated/` — **Never edit** — auto-generated code (~2695 files)
- `src/libs/LabelStudio/Extensions/LabelStudioClient.Auth.cs` — PrepareRequest hook: `Bearer → Token`
- `src/libs/LabelStudio/Extensions/LabelStudioClient.Tools.cs` — MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` — Test helper with token auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

Label Studio uses `apiKey` auth in the spec with `Token ` prefix. The `generate.sh` converts it to `http/bearer` for AutoSDK, and `PrepareRequest` rewrites `Bearer → Token` at runtime.

## Sub-client Pattern

The API is organized into sub-clients:
- `client.Projects2.ListAsync(...)` — List labeling projects
- `client.Projects2.GetAsync(...)` — Get project details
- `client.Projects2.CreateAsync(...)` — Create a project
- `client.Tasks2.List2Async(...)` — List tasks in a project
- `client.Tasks2.GetAsync(...)` — Get task details
- `client.Annotations.CreateAsync(...)` — Create an annotation
- `client.Annotations.ListAsync(...)` — List annotations for a task
- `client.Ml.ListAsync(...)` — List ML backends
- `client.Webhooks.ListAsync(...)` — List webhooks
- `client.StorageS3.*` / `client.StorageGcs.*` / `client.StorageAzure.*` — Cloud storage
- `client.Organizations.*` — Organization management
- `client.Users.*` — User management
- `client.Export.*` — Data export
- `client.Import.*` — Data import
- `client.Views.*` — Data manager views

## MEAI

`AIFunction` tools for use with any `IChatClient`:
- `AsListProjectsTool()` — List labeling projects with search/pagination
- `AsGetProjectTool()` — Get project details by ID
- `AsListTasksTool()` — List tasks in a project
- `AsCreateAnnotationTool()` — Create an annotation on a task

## Base URL

Default base URL is `http://localhost:8000` (Label Studio is typically self-hosted). Set `LABEL_STUDIO_BASE_URL` env var or pass a custom `baseUri` to the constructor for different deployments.
