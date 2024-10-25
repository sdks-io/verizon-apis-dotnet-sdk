// <copyright file="UpdateTriggersController.cs" company="APIMatic">
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
    /// UpdateTriggersController.
    /// </summary>
    public class UpdateTriggersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggersController"/> class.
        /// </summary>
        internal UpdateTriggersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Updates the promotional triggers for pseudo-MDN.
        /// </summary>
        /// <param name="body">Optional parameter: Update the triggers.</param>
        /// <returns>Returns the ApiResponse of Models.Success response from the API call.</returns>
        public ApiResponse<Models.Success> UpdateAllAvailableTriggers(
                Models.RequestTrigger body = null)
            => CoreHelper.RunTask(UpdateAllAvailableTriggersAsync(body));

        /// <summary>
        /// Updates the promotional triggers for pseudo-MDN.
        /// </summary>
        /// <param name="body">Optional parameter: Update the triggers.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Success response from the API call.</returns>
        public async Task<ApiResponse<Models.Success>> UpdateAllAvailableTriggersAsync(
                Models.RequestTrigger body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Success>()
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
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ReadySimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}