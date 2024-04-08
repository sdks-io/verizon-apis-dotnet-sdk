// <copyright file="ServicePlansController.cs" company="APIMatic">
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
    /// ServicePlansController.
    /// </summary>
    public class ServicePlansController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlansController"/> class.
        /// </summary>
        internal ServicePlansController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of List<Models.ServicePlan> response from the API call.</returns>
        public ApiResponse<List<Models.ServicePlan>> ListAccountServicePlans(
                string aname)
            => CoreHelper.RunTask(ListAccountServicePlansAsync(aname));

        /// <summary>
        /// Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.ServicePlan> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ServicePlan>>> ListAccountServicePlansAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ServicePlan>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/plans/{aname}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}