# LabelStudio

[![Nuget package](https://img.shields.io/nuget/vpre/LabelStudio)](https://www.nuget.org/packages/LabelStudio/)
[![dotnet](https://github.com/tryAGI/LabelStudio/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/LabelStudio/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/LabelStudio)](https://github.com/tryAGI/LabelStudio/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Label Studio OpenAPI specification](https://raw.githubusercontent.com/HumanSignal/label-studio-client-generator/master/fern/openapi/openapi.yaml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- MEAI (Microsoft.Extensions.AI) `AIFunction` tools for use with any `IChatClient`

### Usage
```csharp
using LabelStudio;

// Label Studio uses Token-based auth
using var client = new LabelStudioClient(apiKey);

// List projects
var projects = await client.Projects2.ListAsync();

// Get project details
var project = await client.Projects2.GetAsync(id: 1);

// List tasks in a project
var tasks = await client.Tasks2.List2Async(project: 1);

// Create an annotation
var annotation = await client.Annotations2.CreateAsync(
    id: 1, // task ID
    result: new List<object>());
```

### MEAI Tools
```csharp
using LabelStudio;
using Microsoft.Extensions.AI;

using var client = new LabelStudioClient(apiKey);

// Create AIFunction tools for use with any IChatClient
var tools = new AITool[]
{
    client.AsListProjectsTool(),
    client.AsGetProjectTool(),
    client.AsListTasksTool(),
    client.AsCreateAnnotationTool(),
};
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/LabelStudio/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/LabelStudio/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
