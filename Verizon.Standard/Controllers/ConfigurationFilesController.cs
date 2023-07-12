// <copyright file="ConfigurationFilesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;
    using Verizon.Standard;
    using Verizon.Standard.Authentication;
    using Verizon.Standard.Exceptions;
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Http.Response;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ConfigurationFilesController.
    /// </summary>
    public class ConfigurationFilesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationFilesController"/> class.
        /// </summary>
        internal ConfigurationFilesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// You can retrieve a list of configuration or supplementary of files for an account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="distributionType">Required parameter: Filter the distributionType to only retrieve files for a specific distribution type..</param>
        /// <returns>Returns the ApiResponse of Models.RetrievesAvailableFilesResponseList response from the API call.</returns>
        public ApiResponse<Models.RetrievesAvailableFilesResponseList> GetListOfFiles(
                string acc,
                string distributionType)
            => CoreHelper.RunTask(GetListOfFilesAsync(acc, distributionType));

        /// <summary>
        /// You can retrieve a list of configuration or supplementary of files for an account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="distributionType">Required parameter: Filter the distributionType to only retrieve files for a specific distribution type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RetrievesAvailableFilesResponseList response from the API call.</returns>
        public async Task<ApiResponse<Models.RetrievesAvailableFilesResponseList>> GetListOfFilesAsync(
                string acc,
                string distributionType,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RetrievesAvailableFilesResponseList>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/{acc}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Query(_query => _query.Setup("distributionType", distributionType))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.RetrievesAvailableFilesResponseList>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="fileupload">Optional parameter: The file to upload..</param>
        /// <param name="fileVersion">Optional parameter: Version of the file..</param>
        /// <param name="make">Optional parameter: The software-applicable device make..</param>
        /// <param name="model">Optional parameter: The software-applicable device model..</param>
        /// <param name="localTargetPath">Optional parameter: Local target path on the device..</param>
        /// <returns>Returns the ApiResponse of Models.UploadConfigurationFilesResponse response from the API call.</returns>
        public ApiResponse<Models.UploadConfigurationFilesResponse> UploadConfigFile(
                string acc,
                FileStreamInfo fileupload = null,
                string fileVersion = null,
                string make = null,
                string model = null,
                string localTargetPath = null)
            => CoreHelper.RunTask(UploadConfigFileAsync(acc, fileupload, fileVersion, make, model, localTargetPath));

        /// <summary>
        /// Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="fileupload">Optional parameter: The file to upload..</param>
        /// <param name="fileVersion">Optional parameter: Version of the file..</param>
        /// <param name="make">Optional parameter: The software-applicable device make..</param>
        /// <param name="model">Optional parameter: The software-applicable device model..</param>
        /// <param name="localTargetPath">Optional parameter: Local target path on the device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UploadConfigurationFilesResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.UploadConfigurationFilesResponse>> UploadConfigFileAsync(
                string acc,
                FileStreamInfo fileupload = null,
                string fileVersion = null,
                string make = null,
                string model = null,
                string localTargetPath = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UploadConfigurationFilesResponse>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/files/{acc}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Form(_form => _form.Setup("fileupload", fileupload))
                      .Form(_form => _form.Setup("fileVersion", fileVersion))
                      .Form(_form => _form.Setup("make", make))
                      .Form(_form => _form.Setup("model", model))
                      .Form(_form => _form.Setup("localTargetPath", localTargetPath))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.UploadConfigurationFilesResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}