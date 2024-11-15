// <copyright file="ExclusionsController.cs" company="APIMatic">
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
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Exceptions;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Http.Client;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Utilities;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Controllers
{
    /// <summary>
    /// ExclusionsController.
    /// </summary>
    public class ExclusionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionsController"/> class.
        /// </summary>
        internal ExclusionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a consent record to use location services as an asynchronous request.
        /// </summary>
        /// <param name="body">Optional parameter: Account details to create a consent record..</param>
        /// <returns>Returns the Models.ConsentTransactionID response from the API call.</returns>
        public Models.ConsentTransactionID DevicesLocationGiveConsentAsync(
                Models.AccountConsentCreate body = null)
            => CoreHelper.RunTask(DevicesLocationGiveConsentAsyncAsync(body));

        /// <summary>
        /// Create a consent record to use location services as an asynchronous request.
        /// </summary>
        /// <param name="body">Optional parameter: Account details to create a consent record..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ConsentTransactionID response from the API call.</returns>
        public async Task<Models.ConsentTransactionID> DevicesLocationGiveConsentAsyncAsync(
                Models.AccountConsentCreate body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConsentTransactionID>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devicelocations/action/consents")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("vz-m2m-session_token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}