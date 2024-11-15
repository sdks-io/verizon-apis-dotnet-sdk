// <copyright file="MV2TriggersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace Verizon.Standard.Controllers
{
    /// <summary>
    /// MV2TriggersController.
    /// </summary>
    public class MV2TriggersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MV2TriggersController"/> class.
        /// </summary>
        internal MV2TriggersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This creates an individual change plan for account group share.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.TriggerV2Response response from the API call.</returns>
        public ApiResponse<Models.TriggerV2Response> CreateTrigger(
                Models.CreateTriggerV2Request body)
            => CoreHelper.RunTask(CreateTriggerAsync(body));

        /// <summary>
        /// This creates an individual change plan for account group share.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerV2Response response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerV2Response>> CreateTriggerAsync(
                Models.CreateTriggerV2Request body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerV2Response>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v2/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RulesEngineRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This updates an individual change plan for account group share.
        /// </summary>
        /// <param name="vZM2mToken">Required parameter: M2M-MC Session Token.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="xRequestID">Optional parameter: Transaction Id.</param>
        /// <returns>Returns the ApiResponse of Models.TriggerV2Response response from the API call.</returns>
        public ApiResponse<Models.TriggerV2Response> UpdateTrigger(
                string vZM2mToken,
                Models.UpdateTriggerV2Request body,
                string xRequestID = null)
            => CoreHelper.RunTask(UpdateTriggerAsync(vZM2mToken, body, xRequestID));

        /// <summary>
        /// This updates an individual change plan for account group share.
        /// </summary>
        /// <param name="vZM2mToken">Required parameter: M2M-MC Session Token.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="xRequestID">Optional parameter: Transaction Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerV2Response response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerV2Response>> UpdateTriggerAsync(
                string vZM2mToken,
                Models.UpdateTriggerV2Request body,
                string xRequestID = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerV2Response>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v2/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("VZ-M2M-Token", vZM2mToken))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("X-Request-ID", xRequestID))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RulesEngineRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}