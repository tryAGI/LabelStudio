using System.Text.Json;
using Microsoft.Extensions.AI;

namespace LabelStudio;

/// <summary>
/// Extensions for using LabelStudioClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class LabelStudioToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists labeling projects.
    /// </summary>
    /// <param name="client">The Label Studio client.</param>
    /// <param name="pageSize">Number of projects per page (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListProjectsTool(
        this LabelStudioClient client,
        int pageSize = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (int? page, string? search, CancellationToken cancellationToken) =>
            {
                var response = await client.Projects2.ListAsync(
                    page: page ?? 1,
                    pageSize: pageSize,
                    search: search,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    count = response.Count,
                    projects = response.Results.Select(p => new
                    {
                        id = p.Id,
                        title = p.Title,
                        description = p.Description,
                        task_number = p.TaskNumber,
                        num_tasks_with_annotations = p.NumTasksWithAnnotations,
                        created_at = p.CreatedAt,
                    }),
                });
            },
            name: "ListLabelingProjects",
            description: "Lists Label Studio labeling projects with their IDs, titles, descriptions, and task counts. Supports pagination and search by title.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details of a specific project.
    /// </summary>
    /// <param name="client">The Label Studio client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetProjectTool(this LabelStudioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (int projectId, CancellationToken cancellationToken) =>
            {
                var response = await client.Projects2.GetAsync(
                    id: projectId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = response.Id,
                    title = response.Title,
                    description = response.Description,
                    label_config = response.LabelConfig,
                    task_number = response.TaskNumber,
                    num_tasks_with_annotations = response.NumTasksWithAnnotations,
                    created_at = response.CreatedAt,
                });
            },
            name: "GetLabelingProject",
            description: "Gets detailed information about a specific Label Studio labeling project by ID, including its label configuration, task counts, and timestamps.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists tasks in a project.
    /// </summary>
    /// <param name="client">The Label Studio client.</param>
    /// <param name="pageSize">Number of tasks per page (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListTasksTool(
        this LabelStudioClient client,
        int pageSize = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (int projectId, int? page, CancellationToken cancellationToken) =>
            {
                var response = await client.Tasks2.List2Async(
                    project: projectId,
                    page: page ?? 1,
                    pageSize: pageSize,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total = response.Total,
                    total_annotations = response.TotalAnnotations,
                    total_predictions = response.TotalPredictions,
                    tasks = response.Tasks.Select(t =>
                    {
                        var task = t.Lse;
                        return task == null ? null : new
                        {
                            id = task.Id,
                            data = task.Data,
                            is_labeled = task.IsLabeled,
                            total_annotations = task.TotalAnnotations,
                            total_predictions = task.TotalPredictions,
                            created_at = task.CreatedAt,
                        };
                    }).Where(t => t != null),
                });
            },
            name: "ListLabelingTasks",
            description: "Lists tasks in a Label Studio project with their IDs, data, labeling status, and annotation/prediction counts. Supports pagination.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates an annotation on a task.
    /// </summary>
    /// <param name="client">The Label Studio client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsCreateAnnotationTool(this LabelStudioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (int taskId, string resultJson, CancellationToken cancellationToken) =>
            {
                var result = JsonSerializer.Deserialize<List<object>>(resultJson);

                var response = await client.Annotations2.CreateAsync(
                    id: taskId,
                    result: result,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = response.Id,
                    task = response.Task,
                    created_at = response.CreatedAt,
                    updated_at = response.UpdatedAt,
                    completed_by = response.CompletedBy,
                });
            },
            name: "CreateAnnotation",
            description: "Creates an annotation on a Label Studio task. The resultJson parameter should be a JSON array of annotation results following the Label Studio annotation format.");
    }
}
