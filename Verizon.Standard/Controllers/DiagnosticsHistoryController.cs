// <copyright file="DiagnosticsHistoryController.cs" company="APIMatic">
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
    /// DiagnosticsHistoryController.
    /// </summary>
    public class DiagnosticsHistoryController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsHistoryController"/> class.
        /// </summary>
        internal DiagnosticsHistoryController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows the user to get the history data.
        /// </summary>
        /// <param name="body">Required parameter: History data information..</param>
        /// <returns>Returns the ApiResponse of List<Models.History> response from the API call.</returns>
        public ApiResponse<List<Models.History>> GetDiagnosticsHistory(
                Models.HistorySearchRequest body)
            => CoreHelper.RunTask(GetDiagnosticsHistoryAsync(body));

        /// <summary>
        /// This endpoint allows the user to get the history data.
        /// </summary>
        /// <param name="body">Required parameter: History data information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.History> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.History>>> GetDiagnosticsHistoryAsync(
                Models.HistorySearchRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.History>>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/history/actions/$search")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.History>>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}