// <copyright file="AnomalySettingsController.cs" company="APIMatic">
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
    /// AnomalySettingsController.
    /// </summary>
    public class AnomalySettingsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalySettingsController"/> class.
        /// </summary>
        internal AnomalySettingsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Uses the subscribed account ID to activate anomaly detection and set threshold values.
        /// </summary>
        /// <param name="body">Required parameter: Request to activate anomaly detection..</param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public ApiResponse<Models.IntelligenceSuccessResult> ActivateAnomalyDetection(
                Models.AnomalyDetectionRequest body)
            => CoreHelper.RunTask(ActivateAnomalyDetectionAsync(body));

        /// <summary>
        /// Uses the subscribed account ID to activate anomaly detection and set threshold values.
        /// </summary>
        /// <param name="body">Required parameter: Request to activate anomaly detection..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.IntelligenceSuccessResult>> ActivateAnomalyDetectionAsync(
                Models.AnomalyDetectionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IntelligenceSuccessResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/anomaly/settings")
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
        /// Retrieves the current anomaly detection settings for an account.
        /// </summary>
        /// <param name="accountName">Required parameter: The name of the subscribed account..</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionSettings response from the API call.</returns>
        public ApiResponse<Models.AnomalyDetectionSettings> ListAnomalyDetectionSettings(
                string accountName)
            => CoreHelper.RunTask(ListAnomalyDetectionSettingsAsync(accountName));

        /// <summary>
        /// Retrieves the current anomaly detection settings for an account.
        /// </summary>
        /// <param name="accountName">Required parameter: The name of the subscribed account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionSettings response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyDetectionSettings>> ListAnomalyDetectionSettingsAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyDetectionSettings>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/intelligence/{accountName}/anomaly/settings")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Resets the thresholds to zero.
        /// </summary>
        /// <param name="accountName">Required parameter: The name of the subscribed account..</param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public ApiResponse<Models.IntelligenceSuccessResult> ResetAnomalyDetectionParameters(
                string accountName)
            => CoreHelper.RunTask(ResetAnomalyDetectionParametersAsync(accountName));

        /// <summary>
        /// Resets the thresholds to zero.
        /// </summary>
        /// <param name="accountName">Required parameter: The name of the subscribed account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.IntelligenceSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.IntelligenceSuccessResult>> ResetAnomalyDetectionParametersAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IntelligenceSuccessResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/intelligence/{accountName}/anomaly/settings/reset")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("An error occurred.", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}