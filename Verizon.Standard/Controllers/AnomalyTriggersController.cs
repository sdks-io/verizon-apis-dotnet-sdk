// <copyright file="AnomalyTriggersController.cs" company="APIMatic">
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
    /// AnomalyTriggersController.
    /// </summary>
    public class AnomalyTriggersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggersController"/> class.
        /// </summary>
        internal AnomalyTriggersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
        /// </summary>
        /// <returns>Returns the ApiResponse of List&lt;Models.GetTriggerResponseList&gt; response from the API call.</returns>
        public ApiResponse<List<Models.GetTriggerResponseList>> ListAnomalyDetectionTriggers()
            => CoreHelper.RunTask(ListAnomalyDetectionTriggersAsync());

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.GetTriggerResponseList&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.GetTriggerResponseList>>> ListAnomalyDetectionTriggersAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.GetTriggerResponseList>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```UpdateTriggerRequest```.
        /// </summary>
        /// <param name="body">Required parameter: Update Trigger Request.</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public ApiResponse<Models.AnomalyDetectionTrigger> UpdateAnomalyDetectionTrigger(
                Models.UpdateTriggerRequest body)
            => CoreHelper.RunTask(UpdateAnomalyDetectionTriggerAsync(body));

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```UpdateTriggerRequest```.
        /// </summary>
        /// <param name="body">Required parameter: Update Trigger Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyDetectionTrigger>> UpdateAnomalyDetectionTriggerAsync(
                Models.UpdateTriggerRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyDetectionTrigger>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```CreateTrigger```.
        /// </summary>
        /// <param name="body">Required parameter: Create Trigger Request.</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public ApiResponse<Models.AnomalyDetectionTrigger> CreateAnomalyDetectionTrigger(
                Models.CreateTriggerRequest body)
            => CoreHelper.RunTask(CreateAnomalyDetectionTriggerAsync(body));

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```CreateTrigger```.
        /// </summary>
        /// <param name="body">Required parameter: Create Trigger Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyDetectionTrigger>> CreateAnomalyDetectionTriggerAsync(
                Models.CreateTriggerRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyDetectionTrigger>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
        /// </summary>
        /// <param name="triggerId">Required parameter: trigger ID.</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.GetTriggerResponseList&gt; response from the API call.</returns>
        public ApiResponse<List<Models.GetTriggerResponseList>> ListAnomalyDetectionTriggerSettings(
                string triggerId)
            => CoreHelper.RunTask(ListAnomalyDetectionTriggerSettingsAsync(triggerId));

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
        /// </summary>
        /// <param name="triggerId">Required parameter: trigger ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.GetTriggerResponseList&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.GetTriggerResponseList>>> ListAnomalyDetectionTriggerSettingsAsync(
                string triggerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.GetTriggerResponseList>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/triggers/{triggerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("triggerId", triggerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new IntelligenceResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a specific trigger ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The trigger ID to be deleted.</param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public ApiResponse<Models.AnomalyDetectionTrigger> DeleteAnomalyDetectionTrigger(
                string triggerId)
            => CoreHelper.RunTask(DeleteAnomalyDetectionTriggerAsync(triggerId));

        /// <summary>
        /// Deletes a specific trigger ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The trigger ID to be deleted.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AnomalyDetectionTrigger response from the API call.</returns>
        public async Task<ApiResponse<Models.AnomalyDetectionTrigger>> DeleteAnomalyDetectionTriggerAsync(
                string triggerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnomalyDetectionTrigger>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/m2m/v1/triggers/{triggerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("triggerId", triggerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new IntelligenceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}