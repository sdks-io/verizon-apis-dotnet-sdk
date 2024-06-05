// <copyright file="SIMActionsController.cs" company="APIMatic">
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
    /// SIMActionsController.
    /// </summary>
    public class SIMActionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIMActionsController"/> class.
        /// </summary>
        internal SIMActionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Uses the profile to activate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.ESIMRequestResponse response from the API call.</returns>
        public ApiResponse<Models.ESIMRequestResponse> SetactivateUsingPOST(
                Models.ESIMProfileRequest body)
            => CoreHelper.RunTask(SetactivateUsingPOSTAsync(body));

        /// <summary>
        /// Uses the profile to activate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ESIMRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ESIMRequestResponse>> SetactivateUsingPOSTAsync(
                Models.ESIMProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ESIMRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/activate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
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
        /// Uses the profile to deactivate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.ESIMRequestResponse response from the API call.</returns>
        public ApiResponse<Models.ESIMRequestResponse> SetdeactivateUsingPOST(
                Models.ProfileRequest2 body)
            => CoreHelper.RunTask(SetdeactivateUsingPOSTAsync(body));

        /// <summary>
        /// Uses the profile to deactivate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ESIMRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ESIMRequestResponse>> SetdeactivateUsingPOSTAsync(
                Models.ProfileRequest2 body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ESIMRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/deactivate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
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
    }
}