#nullable enable

namespace LabelStudio
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Create export storage<br/>
        /// Create a new S3 export storage connection to store annotations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.S3ExportStorage> CreateAsync(

            global::LabelStudio.S3ExportStorageWriteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create export storage<br/>
        /// Create a new S3 export storage connection to store annotations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.S3ExportStorage>> CreateAsResponseAsync(

            global::LabelStudio.S3ExportStorageWriteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create export storage<br/>
        /// Create a new S3 export storage connection to store annotations.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// AWS_ACCESS_KEY_ID
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS_SECRET_ACCESS_KEY
        /// </param>
        /// <param name="awsSessionToken">
        /// AWS_SESSION_TOKEN
        /// </param>
        /// <param name="awsSseKmsKeyId">
        /// AWS SSE KMS Key ID
        /// </param>
        /// <param name="bucket">
        /// S3 bucket name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="prefix">
        /// S3 bucket prefix
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects
        /// </param>
        /// <param name="regionName">
        /// AWS Region
        /// </param>
        /// <param name="s3Endpoint">
        /// S3 Endpoint
        /// </param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.S3ExportStorage> CreateAsync(
            int project,
            string? awsAccessKeyId = default,
            string? awsSecretAccessKey = default,
            string? awsSessionToken = default,
            string? awsSseKmsKeyId = default,
            string? bucket = default,
            bool? canDeleteObjects = default,
            string? description = default,
            string? prefix = default,
            string? regexFilter = default,
            string? regionName = default,
            string? s3Endpoint = default,
            bool? synchronizable = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}