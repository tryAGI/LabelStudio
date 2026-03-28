# Microsoft.Extensions.AI Integration

Label Studio SDK provides `AIFunction` tools that can be used with any `IChatClient` from the Microsoft.Extensions.AI ecosystem.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsListProjectsTool()` | Lists labeling projects with search and pagination |
| `AsGetProjectTool()` | Gets detailed project info by ID |
| `AsListTasksTool()` | Lists tasks in a project with pagination |
| `AsCreateAnnotationTool()` | Creates an annotation on a task |

## Usage

```csharp
using LabelStudio;
using Microsoft.Extensions.AI;

using var labelStudio = new LabelStudioClient(apiKey);

// Create tools
var tools = new AITool[]
{
    labelStudio.AsListProjectsTool(),
    labelStudio.AsGetProjectTool(),
    labelStudio.AsListTasksTool(),
    labelStudio.AsCreateAnnotationTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "List all my labeling projects",
    new ChatOptions { Tools = tools });
```

## Tool Details

### ListLabelingProjects

Lists Label Studio labeling projects with their IDs, titles, descriptions, and task counts.

**Parameters:**
- `page` (int?, optional) — Page number (default: 1)
- `search` (string?, optional) — Search by title

### GetLabelingProject

Gets detailed information about a specific project including its label configuration.

**Parameters:**
- `projectId` (int, required) — The project ID

### ListLabelingTasks

Lists tasks in a project with their data, labeling status, and counts.

**Parameters:**
- `projectId` (int, required) — The project ID
- `page` (int?, optional) — Page number (default: 1)

### CreateAnnotation

Creates an annotation on a task using Label Studio's annotation format.

**Parameters:**
- `taskId` (int, required) — The task ID
- `resultJson` (string, required) — JSON array of annotation results
