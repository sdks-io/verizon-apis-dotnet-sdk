// <copyright file="FixedWirelessQualificationController.cs" company="APIMatic">
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
    /// FixedWirelessQualificationController.
    /// </summary>
    public class FixedWirelessQualificationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWirelessQualificationController"/> class.
        /// </summary>
        internal FixedWirelessQualificationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Use this query for Fixed Wireless Qualification of an address. Network types include: LTE, C-BAND and MMWAVE.
        /// </summary>
        /// <param name="body">Required parameter: Request for network coverage details..</param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WNPRequestResponse> Domestic4GAnd5gFixedWirelessQualification(
                Models.GetWirelessCoverageRequestFWA body)
            => CoreHelper.RunTask(Domestic4GAnd5gFixedWirelessQualificationAsync(body));

        /// <summary>
        /// Use this query for Fixed Wireless Qualification of an address. Network types include: LTE, C-BAND and MMWAVE.
        /// </summary>
        /// <param name="body">Required parameter: Request for network coverage details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WNPRequestResponse>> Domestic4GAnd5gFixedWirelessQualificationAsync(
                Models.GetWirelessCoverageRequestFWA body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WNPRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/intelligence/wireless-coverage")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WNPRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}