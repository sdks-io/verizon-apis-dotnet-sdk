// <copyright file="GlobalReportingController.cs" company="APIMatic">
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
    using Verizon.Standard.Exceptions;
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Http.Response;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// GlobalReportingController.
    /// </summary>
    public class GlobalReportingController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalReportingController"/> class.
        /// </summary>
        internal GlobalReportingController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retreive the provisioning history of a specific device or devices.
        /// </summary>
        /// <param name="body">Required parameter: Device Provisioning History.</param>
        /// <returns>Returns the ApiResponse of Models.ESIMRequestResponse response from the API call.</returns>
        public ApiResponse<Models.ESIMRequestResponse> DeviceprovhistoryUsingPOST(
                Models.ESIMProvhistoryRequest body)
            => CoreHelper.RunTask(DeviceprovhistoryUsingPOSTAsync(body));

        /// <summary>
        /// Retreive the provisioning history of a specific device or devices.
        /// </summary>
        /// <param name="body">Required parameter: Device Provisioning History.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ESIMRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ESIMRequestResponse>> DeviceprovhistoryUsingPOSTAsync(
                Models.ESIMProvhistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ESIMRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v2/devices/history/actions/list")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get the status of a request made with the Device Actions.
        /// </summary>
        /// <param name="accountname">Required parameter: Example: .</param>
        /// <param name="requestID">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ESIMStatusResponse response from the API call.</returns>
        public ApiResponse<Models.ESIMStatusResponse> RequeststatususingGET(
                string accountname,
                string requestID)
            => CoreHelper.RunTask(RequeststatususingGETAsync(accountname, requestID));

        /// <summary>
        /// Get the status of a request made with the Device Actions.
        /// </summary>
        /// <param name="accountname">Required parameter: Example: .</param>
        /// <param name="requestID">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ESIMStatusResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ESIMStatusResponse>> RequeststatususingGETAsync(
                string accountname,
                string requestID,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ESIMStatusResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v2/accounts/{accountname}/requests/{requestID}/status")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountname", accountname))
                      .Template(_template => _template.Setup("requestID", requestID))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ESIMRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}