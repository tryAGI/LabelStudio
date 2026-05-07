#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LabelStudio
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// Create a project<br/>
        /// Create a project for a specific organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseProjectCreate> CreateAsync(

            global::LabelStudio.LseProjectCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project<br/>
        /// Create a project for a specific organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LseProjectCreate>> CreateAsResponseAsync(

            global::LabelStudio.LseProjectCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project<br/>
        /// Create a project for a specific organization.
        /// </summary>
        /// <param name="annotatorEvaluationEnabled">
        /// Enable annotator evaluation for the project
        /// </param>
        /// <param name="color"></param>
        /// <param name="controlWeights">
        /// Dict of weights for each control tag in metric calculation. Keys are control tag names from the labeling config. At least one tag must have a non-zero overall weight.
        /// </param>
        /// <param name="createdBy">
        /// Project owner
        /// </param>
        /// <param name="customInterfaceCode"></param>
        /// <param name="customInterfaceCompiled"></param>
        /// <param name="customInterfaceParams"></param>
        /// <param name="description">
        /// Project Description
        /// </param>
        /// <param name="enableEmptyAnnotation">
        /// Allow annotators to submit empty annotations
        /// </param>
        /// <param name="evaluatePredictionsAutomatically">
        /// Retrieve and display predictions when loading a task
        /// </param>
        /// <param name="expertInstruction">
        /// Labeling instructions in HTML format
        /// </param>
        /// <param name="inputSchema"></param>
        /// <param name="isDraft">
        /// Whether or not the project is in the middle of being created
        /// </param>
        /// <param name="isPublished">
        /// Whether or not the project is published to annotators
        /// </param>
        /// <param name="labelConfig">
        /// Label config in XML format. See more about it in documentation
        /// </param>
        /// <param name="maximumAnnotations">
        /// Maximum number of annotations for one task. If the number of annotations per task is equal or greater to this value, the task is completed (is_labeled=True)
        /// </param>
        /// <param name="minAnnotationsToStartTraining">
        /// Minimum number of completed tasks after which model training is started
        /// </param>
        /// <param name="modelVersion">
        /// Machine learning model version
        /// </param>
        /// <param name="organization"></param>
        /// <param name="outputSchema"></param>
        /// <param name="overlapCohortPercentage"></param>
        /// <param name="pinnedAt">
        /// Pinned date and time
        /// </param>
        /// <param name="revealPreannotationsInteractively">
        /// Reveal pre-annotations interactively
        /// </param>
        /// <param name="sampling"></param>
        /// <param name="showAnnotationHistory">
        /// Show annotation history to annotator
        /// </param>
        /// <param name="showCollabPredictions">
        /// If set, the annotator can view model predictions
        /// </param>
        /// <param name="showInstruction">
        /// Show instructions to the annotator before they start
        /// </param>
        /// <param name="showOverlapFirst"></param>
        /// <param name="showSkipButton">
        /// Show a skip button in interface and allow annotators to skip the task
        /// </param>
        /// <param name="skipQueue"></param>
        /// <param name="sourceInterfaceId"></param>
        /// <param name="sourceInterfaceVersion">
        /// Stable version ID of the saved interface used to create this project.
        /// </param>
        /// <param name="taskDataLogin">
        /// Task data credentials: login
        /// </param>
        /// <param name="taskDataPassword">
        /// Task data credentials: password
        /// </param>
        /// <param name="title">
        /// Project Title
        /// </param>
        /// <param name="useCustomInterface">
        /// Default Value: false
        /// </param>
        /// <param name="workspace">
        /// In Workspace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseProjectCreate> CreateAsync(
            bool? annotatorEvaluationEnabled = default,
            string? color = default,
            global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeightRequest>? controlWeights = default,
            global::LabelStudio.UserSimpleRequest? createdBy = default,
            string? customInterfaceCode = default,
            string? customInterfaceCompiled = default,
            object? customInterfaceParams = default,
            string? description = default,
            bool? enableEmptyAnnotation = default,
            bool? evaluatePredictionsAutomatically = default,
            string? expertInstruction = default,
            object? inputSchema = default,
            bool? isDraft = default,
            bool? isPublished = default,
            string? labelConfig = default,
            int? maximumAnnotations = default,
            int? minAnnotationsToStartTraining = default,
            string? modelVersion = default,
            int? organization = default,
            object? outputSchema = default,
            int? overlapCohortPercentage = default,
            global::System.DateTime? pinnedAt = default,
            bool? revealPreannotationsInteractively = default,
            global::LabelStudio.SamplingDe5Enum? sampling = default,
            bool? showAnnotationHistory = default,
            bool? showCollabPredictions = default,
            bool? showInstruction = default,
            bool? showOverlapFirst = default,
            bool? showSkipButton = default,
            global::LabelStudio.SkipQueueEnum? skipQueue = default,
            int? sourceInterfaceId = default,
            int? sourceInterfaceVersion = default,
            string? taskDataLogin = default,
            string? taskDataPassword = default,
            string? title = default,
            bool? useCustomInterface = default,
            int? workspace = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}