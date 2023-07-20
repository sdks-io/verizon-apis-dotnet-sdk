// <copyright file="AnomalyTriggersController.cs" company="APIMatic">
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
    /// AnomalyTriggersController.
    /// </summary>
    public class AnomalyTriggersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggersController"/> class.
        /// </summary>
        internal AnomalyTriggersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Updates an existing trigger using the account name.
        /// </summary>
        /// <param name="body">Required parameter: Request to update existing trigger..</param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public ApiResponse<Models.IntelligenceSuccessResult> UpdateAnomalyDetectionTrigger(
                List<Models.UpdateTriggerRequestOptions> body)
            => CoreHelper.RunTask(UpdateAnomalyDetectionTriggerAsync(body));

        /// <summary>
        /// Updates an existing trigger using the account name.
        /// </summary>
        /// <param name="body">Required parameter: Request to update existing trigger..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.IntelligenceSuccessResult>> UpdateAnomalyDetectionTriggerAsync(
                List<Models.UpdateTriggerRequestOptions> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IntelligenceSuccessResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v2/triggers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.IntelligenceSuccessResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieves the values for a specific trigger ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The trigger ID of a specific trigger..</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyTriggerResult response from the API call.</returns>
        public ApiResponse<Models.AnomalyTriggerResult> ListAnomalyDetectionTriggerSettings(
                string triggerId)
            => CoreHelper.RunTask(ListAnomalyDetectionTriggerSettingsAsync(triggerId));

        /// <summary>
        /// Retrieves the values for a specific trigger ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The trigger ID of a specific trigger..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyTriggerResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyTriggerResult>> ListAnomalyDetectionTriggerSettingsAsync(
                string triggerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyTriggerResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/triggers/{triggerId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("triggerId", triggerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.AnomalyTriggerResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Creates the trigger to identify an anomaly.
        /// </summary>
        /// <param name="body">Required parameter: Request to create an anomaly trigger..</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public ApiResponse<Models.AnomalyDetectionTrigger> CreateAnomalyDetectionTrigger(
                List<Models.CreateTriggerRequestOptions> body)
            => CoreHelper.RunTask(CreateAnomalyDetectionTriggerAsync(body));

        /// <summary>
        /// Creates the trigger to identify an anomaly.
        /// </summary>
        /// <param name="body">Required parameter: Request to create an anomaly trigger..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyDetectionTrigger>> CreateAnomalyDetectionTriggerAsync(
                List<Models.CreateTriggerRequestOptions> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyDetectionTrigger>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/triggers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.AnomalyDetectionTrigger>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}