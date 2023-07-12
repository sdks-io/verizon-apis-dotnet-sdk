// <copyright file="DeviceReportsController.cs" company="APIMatic">
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
    /// DeviceReportsController.
    /// </summary>
    public class DeviceReportsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceReportsController"/> class.
        /// </summary>
        internal DeviceReportsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).
        /// </summary>
        /// <param name="body">Required parameter: Aggregated report request..</param>
        /// <returns>Returns the ApiResponse of Models.AggregateSessionReport response from the API call.</returns>
        public ApiResponse<Models.AggregateSessionReport> CalculateAggregatedReportSynchronous(
                Models.AggregateSessionReportRequest body)
            => CoreHelper.RunTask(CalculateAggregatedReportSynchronousAsync(body));

        /// <summary>
        /// Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).
        /// </summary>
        /// <param name="body">Required parameter: Aggregated report request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AggregateSessionReport response from the API call.</returns>
        public async Task<ApiResponse<Models.AggregateSessionReport>> CalculateAggregatedReportSynchronousAsync(
                Models.AggregateSessionReportRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AggregateSessionReport>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/report/aggregate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.AggregateSessionReport>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).
        /// </summary>
        /// <param name="body">Required parameter: Aggregated session report request..</param>
        /// <returns>Returns the ApiResponse of Models.AggregatedReportCallbackResult response from the API call.</returns>
        public ApiResponse<Models.AggregatedReportCallbackResult> CalculateAggregatedReportAsynchronous(
                Models.AggregateSessionReportRequest body)
            => CoreHelper.RunTask(CalculateAggregatedReportAsynchronousAsync(body));

        /// <summary>
        /// Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).
        /// </summary>
        /// <param name="body">Required parameter: Aggregated session report request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AggregatedReportCallbackResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AggregatedReportCallbackResult>> CalculateAggregatedReportAsynchronousAsync(
                Models.AggregateSessionReportRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AggregatedReportCallbackResult>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/report/async/aggregate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.AggregatedReportCallbackResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Detailed report of session duration and number of bytes transferred per day.
        /// </summary>
        /// <param name="body">Required parameter: Request for sessions report..</param>
        /// <returns>Returns the ApiResponse of Models.SessionReport response from the API call.</returns>
        public ApiResponse<Models.SessionReport> GetSessionsReport(
                Models.SessionReportRequest body)
            => CoreHelper.RunTask(GetSessionsReportAsync(body));

        /// <summary>
        /// Detailed report of session duration and number of bytes transferred per day.
        /// </summary>
        /// <param name="body">Required parameter: Request for sessions report..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SessionReport response from the API call.</returns>
        public async Task<ApiResponse<Models.SessionReport>> GetSessionsReportAsync(
                Models.SessionReportRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SessionReport>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/report/sessions")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.SessionReport>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}