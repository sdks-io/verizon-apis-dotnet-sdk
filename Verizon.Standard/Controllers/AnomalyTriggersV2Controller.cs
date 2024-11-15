// <copyright file="AnomalyTriggersV2Controller.cs" company="APIMatic">
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
    /// AnomalyTriggersV2Controller.
    /// </summary>
    public class AnomalyTriggersV2Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggersV2Controller"/> class.
        /// </summary>
        internal AnomalyTriggersV2Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates the trigger to identify an anomaly.
        /// </summary>
        /// <param name="body">Required parameter: Request to create an anomaly trigger..</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public ApiResponse<Models.AnomalyDetectionTrigger> CreateAnomalyDetectionTriggerV2(
                List<Models.CreateTriggerRequestOptions> body)
            => CoreHelper.RunTask(CreateAnomalyDetectionTriggerV2Async(body));

        /// <summary>
        /// Creates the trigger to identify an anomaly.
        /// </summary>
        /// <param name="body">Required parameter: Request to create an anomaly trigger..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyDetectionTrigger>> CreateAnomalyDetectionTriggerV2Async(
                List<Models.CreateTriggerRequestOptions> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyDetectionTrigger>()
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
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an existing trigger using the account name.
        /// </summary>
        /// <param name="body">Required parameter: Request to update existing trigger..</param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public ApiResponse<Models.IntelligenceSuccessResult> UpdateAnomalyDetectionTriggerV2(
                List<Models.UpdateTriggerRequestOptions> body)
            => CoreHelper.RunTask(UpdateAnomalyDetectionTriggerV2Async(body));

        /// <summary>
        /// Updates an existing trigger using the account name.
        /// </summary>
        /// <param name="body">Required parameter: Request to update existing trigger..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.IntelligenceSuccessResult>> UpdateAnomalyDetectionTriggerV2Async(
                List<Models.UpdateTriggerRequestOptions> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IntelligenceSuccessResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v2/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the values for a specific trigger ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The trigger ID of a specific trigger..</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyTriggerResult response from the API call.</returns>
        public ApiResponse<Models.AnomalyTriggerResult> ListAnomalyDetectionTriggerSettingsV2(
                string triggerId)
            => CoreHelper.RunTask(ListAnomalyDetectionTriggerSettingsV2Async(triggerId));

        /// <summary>
        /// Retrieves the values for a specific trigger ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The trigger ID of a specific trigger..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyTriggerResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyTriggerResult>> ListAnomalyDetectionTriggerSettingsV2Async(
                string triggerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyTriggerResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v2/triggers/{triggerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("triggerId", triggerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}