// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.FormRecognizer
{
    /// <summary> The Service service client. </summary>
    internal partial class ServiceClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ServiceClient for mocking. </summary>
        protected ServiceClient()
        {
        }
        /// <summary> Initializes a new instance of ServiceClient. </summary>
        internal ServiceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Create and train a custom model. The request must include a source parameter that is either an externally accessible Azure storage blob container Uri (preferably a Shared Access Signature Uri) or valid path to a data folder in a locally mounted drive. When local paths are specified, they must follow the Linux/Unix path format and be an absolute path rooted to the input mount configuration setting value e.g., if &apos;{Mounts:Input}&apos; configuration setting value is &apos;/input&apos; then a valid source path would be &apos;/input/contosodataset&apos;. All data to be trained is expected to be under the source folder or sub folders under it. Models are trained using documents that are of the following content type - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos;, &apos;image/tiff&apos;. Other type of content is ignored. </summary>
        /// <param name="trainRequest"> Training request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> TrainCustomModelAsyncAsync(TrainRequest_internal trainRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.TrainCustomModelAsync");
            scope.Start();
            try
            {
                return (await RestClient.TrainCustomModelAsyncAsync(trainRequest, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create and train a custom model. The request must include a source parameter that is either an externally accessible Azure storage blob container Uri (preferably a Shared Access Signature Uri) or valid path to a data folder in a locally mounted drive. When local paths are specified, they must follow the Linux/Unix path format and be an absolute path rooted to the input mount configuration setting value e.g., if &apos;{Mounts:Input}&apos; configuration setting value is &apos;/input&apos; then a valid source path would be &apos;/input/contosodataset&apos;. All data to be trained is expected to be under the source folder or sub folders under it. Models are trained using documents that are of the following content type - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos;, &apos;image/tiff&apos;. Other type of content is ignored. </summary>
        /// <param name="trainRequest"> Training request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response TrainCustomModelAsync(TrainRequest_internal trainRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.TrainCustomModelAsync");
            scope.Start();
            try
            {
                return RestClient.TrainCustomModelAsync(trainRequest, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get detailed information about a custom model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeKeys"> Include list of extracted keys in model information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Model_internal>> GetCustomModelAsync(Guid modelId, bool? includeKeys = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetCustomModel");
            scope.Start();
            try
            {
                return await RestClient.GetCustomModelAsync(modelId, includeKeys, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get detailed information about a custom model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeKeys"> Include list of extracted keys in model information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model_internal> GetCustomModel(Guid modelId, bool? includeKeys = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetCustomModel");
            scope.Start();
            try
            {
                return RestClient.GetCustomModel(modelId, includeKeys, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Mark model for deletion. Model artifacts will be permanently removed within a predetermined period. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteCustomModelAsync(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.DeleteCustomModel");
            scope.Start();
            try
            {
                return await RestClient.DeleteCustomModelAsync(modelId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Mark model for deletion. Model artifacts will be permanently removed within a predetermined period. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteCustomModel(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.DeleteCustomModel");
            scope.Start();
            try
            {
                return RestClient.DeleteCustomModel(modelId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeWithCustomModelAsync(Guid modelId, ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeWithCustomModel");
            scope.Start();
            try
            {
                return (await RestClient.AnalyzeWithCustomModelAsync(modelId, contentType, fileStream, includeTextDetails, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeWithCustomModel(Guid modelId, ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeWithCustomModel");
            scope.Start();
            try
            {
                return RestClient.AnalyzeWithCustomModel(modelId, contentType, fileStream, includeTextDetails, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeWithCustomModelAsync(Guid modelId, bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeWithCustomModel");
            scope.Start();
            try
            {
                return (await RestClient.AnalyzeWithCustomModelAsync(modelId, includeTextDetails, fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract key-value pairs, tables, and semantic values from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeWithCustomModel(Guid modelId, bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeWithCustomModel");
            scope.Start();
            try
            {
                return RestClient.AnalyzeWithCustomModel(modelId, includeTextDetails, fileStream, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Obtain current status and the result of the analyze form operation. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalyzeOperationResult_internal>> GetAnalyzeFormResultAsync(Guid modelId, Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetAnalyzeFormResult");
            scope.Start();
            try
            {
                return await RestClient.GetAnalyzeFormResultAsync(modelId, resultId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Obtain current status and the result of the analyze form operation. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalyzeOperationResult_internal> GetAnalyzeFormResult(Guid modelId, Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetAnalyzeFormResult");
            scope.Start();
            try
            {
                return RestClient.GetAnalyzeFormResult(modelId, resultId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeReceiptAsyncAsync(ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeReceiptAsync");
            scope.Start();
            try
            {
                return (await RestClient.AnalyzeReceiptAsyncAsync(contentType, fileStream, includeTextDetails, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeReceiptAsync(ContentType contentType, Stream fileStream, bool? includeTextDetails = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeReceiptAsync");
            scope.Start();
            try
            {
                return RestClient.AnalyzeReceiptAsync(contentType, fileStream, includeTextDetails, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeReceiptAsyncAsync(bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeReceiptAsync");
            scope.Start();
            try
            {
                return (await RestClient.AnalyzeReceiptAsyncAsync(includeTextDetails, fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract field text and semantic values from a given receipt document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="includeTextDetails"> Include text lines and element references in the result. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeReceiptAsync(bool? includeTextDetails = null, SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeReceiptAsync");
            scope.Start();
            try
            {
                return RestClient.AnalyzeReceiptAsync(includeTextDetails, fileStream, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Track the progress and obtain the result of the analyze receipt operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalyzeOperationResult_internal>> GetAnalyzeReceiptResultAsync(Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetAnalyzeReceiptResult");
            scope.Start();
            try
            {
                return await RestClient.GetAnalyzeReceiptResultAsync(resultId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Track the progress and obtain the result of the analyze receipt operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalyzeOperationResult_internal> GetAnalyzeReceiptResult(Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetAnalyzeReceiptResult");
            scope.Start();
            try
            {
                return RestClient.GetAnalyzeReceiptResult(resultId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeLayoutAsyncAsync(ContentType contentType, Stream fileStream, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeLayoutAsync");
            scope.Start();
            try
            {
                return (await RestClient.AnalyzeLayoutAsyncAsync(contentType, fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeLayoutAsync(ContentType contentType, Stream fileStream, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeLayoutAsync");
            scope.Start();
            try
            {
                return RestClient.AnalyzeLayoutAsync(contentType, fileStream, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeLayoutAsyncAsync(SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeLayoutAsync");
            scope.Start();
            try
            {
                return (await RestClient.AnalyzeLayoutAsyncAsync(fileStream, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extract text and layout information from a given document. The input document must be of one of the supported content types - &apos;application/pdf&apos;, &apos;image/jpeg&apos;, &apos;image/png&apos; or &apos;image/tiff&apos;. Alternatively, use &apos;application/json&apos; type to specify the location (Uri or local path) of the document to be analyzed. </summary>
        /// <param name="fileStream"> .json, .pdf, .jpg, .png or .tiff type file stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeLayoutAsync(SourcePath_internal fileStream = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeLayoutAsync");
            scope.Start();
            try
            {
                return RestClient.AnalyzeLayoutAsync(fileStream, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Track the progress and obtain the result of the analyze layout operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalyzeOperationResult_internal>> GetAnalyzeLayoutResultAsync(Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetAnalyzeLayoutResult");
            scope.Start();
            try
            {
                return await RestClient.GetAnalyzeLayoutResultAsync(resultId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Track the progress and obtain the result of the analyze layout operation. </summary>
        /// <param name="resultId"> Analyze operation result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalyzeOperationResult_internal> GetAnalyzeLayoutResult(Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetAnalyzeLayoutResult");
            scope.Start();
            try
            {
                return RestClient.GetAnalyzeLayoutResult(resultId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get information about all custom models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Models_internal>> GetCustomModelsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetCustomModels");
            scope.Start();
            try
            {
                return await RestClient.GetCustomModelsAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get information about all custom models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Models_internal> GetCustomModels(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.GetCustomModels");
            scope.Start();
            try
            {
                return RestClient.GetCustomModels(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get information about all custom models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ModelInfo_internal> ListCustomModelsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ModelInfo_internal>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceClient.ListCustomModels");
                scope.Start();
                try
                {
                    var response = await RestClient.ListCustomModelsAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ModelInfo_internal>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceClient.ListCustomModels");
                scope.Start();
                try
                {
                    var response = await RestClient.ListCustomModelsNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get information about all custom models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ModelInfo_internal> ListCustomModels(CancellationToken cancellationToken = default)
        {
            Page<ModelInfo_internal> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceClient.ListCustomModels");
                scope.Start();
                try
                {
                    var response = RestClient.ListCustomModels(cancellationToken);
                    return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ModelInfo_internal> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceClient.ListCustomModels");
                scope.Start();
                try
                {
                    var response = RestClient.ListCustomModelsNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.ModelList, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}