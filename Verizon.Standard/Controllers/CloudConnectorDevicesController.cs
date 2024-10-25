// <copyright file="CloudConnectorDevicesController.cs" company="APIMatic">
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
using Verizon.Standard.Http.Client;
using Verizon.Standard.Http.Response;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Controllers
{
    /// <summary>
    /// CloudConnectorDevicesController.
    /// </summary>
    public class CloudConnectorDevicesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudConnectorDevicesController"/> class.
        /// </summary>
        internal CloudConnectorDevicesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Change configuration values on a device, such as setting how often a device records and reports sensor readings.
        /// </summary>
        /// <param name="body">Required parameter: The request body changes configuration values on a device..</param>
        /// <returns>Returns the ApiResponse of Models.ChangeConfigurationResponse response from the API call.</returns>
        public ApiResponse<Models.ChangeConfigurationResponse> UpdateDevicesConfigurationValue(
                Models.ChangeConfigurationRequest body)
            => CoreHelper.RunTask(UpdateDevicesConfigurationValueAsync(body));

        /// <summary>
        /// Change configuration values on a device, such as setting how often a device records and reports sensor readings.
        /// </summary>
        /// <param name="body">Required parameter: The request body changes configuration values on a device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangeConfigurationResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangeConfigurationResponse>> UpdateDevicesConfigurationValueAsync(
                Models.ChangeConfigurationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangeConfigurationResponse>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/configuration/actions/set")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Find devices by property values. Returns an array of all matching device resources.
        /// </summary>
        /// <param name="body">Required parameter: The request body specifies fields and values to match..</param>
        /// <returns>Returns the ApiResponse of Models.FindDeviceByPropertyResponseList response from the API call.</returns>
        public ApiResponse<Models.FindDeviceByPropertyResponseList> FindDeviceByPropertyValues(
                Models.QuerySubscriptionRequest body)
            => CoreHelper.RunTask(FindDeviceByPropertyValuesAsync(body));

        /// <summary>
        /// Find devices by property values. Returns an array of all matching device resources.
        /// </summary>
        /// <param name="body">Required parameter: The request body specifies fields and values to match..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FindDeviceByPropertyResponseList response from the API call.</returns>
        public async Task<ApiResponse<Models.FindDeviceByPropertyResponseList>> FindDeviceByPropertyValuesAsync(
                Models.QuerySubscriptionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FindDeviceByPropertyResponseList>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/actions/query")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Search for devices by property values. Returns an array of all matching device resources.
        /// </summary>
        /// <param name="body">Required parameter: The request body specifies fields and values to match..</param>
        /// <returns>Returns the ApiResponse of Models.SearchDeviceByPropertyResponseList response from the API call.</returns>
        public ApiResponse<Models.SearchDeviceByPropertyResponseList> SearchDevicesResourcesByPropertyValues(
                Models.QuerySubscriptionRequest body)
            => CoreHelper.RunTask(SearchDevicesResourcesByPropertyValuesAsync(body));

        /// <summary>
        /// Search for devices by property values. Returns an array of all matching device resources.
        /// </summary>
        /// <param name="body">Required parameter: The request body specifies fields and values to match..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SearchDeviceByPropertyResponseList response from the API call.</returns>
        public async Task<ApiResponse<Models.SearchDeviceByPropertyResponseList>> SearchDevicesResourcesByPropertyValuesAsync(
                Models.QuerySubscriptionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchDeviceByPropertyResponseList>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/actions/search")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Search device event history to find events that match criteria.Sensor readings, configuration changes, and other device data are all stored as events.
        /// </summary>
        /// <param name="body">Required parameter: The device identifier and fields to match in the search..</param>
        /// <returns>Returns the ApiResponse of Models.SearchDeviceEventHistoryResponseList response from the API call.</returns>
        public ApiResponse<Models.SearchDeviceEventHistoryResponseList> SearchDeviceEventHistory(
                Models.SearchDeviceEventHistoryRequest body)
            => CoreHelper.RunTask(SearchDeviceEventHistoryAsync(body));

        /// <summary>
        /// Search device event history to find events that match criteria.Sensor readings, configuration changes, and other device data are all stored as events.
        /// </summary>
        /// <param name="body">Required parameter: The device identifier and fields to match in the search..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SearchDeviceEventHistoryResponseList response from the API call.</returns>
        public async Task<ApiResponse<Models.SearchDeviceEventHistoryResponseList>> SearchDeviceEventHistoryAsync(
                Models.SearchDeviceEventHistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchDeviceEventHistoryResponseList>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/fields/actions/history/search")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns the readings of a specified sensor, with the most recent reading first. Sensor readings are stored as events; this request an array of events.
        /// </summary>
        /// <param name="fieldname">Required parameter: The name of the sensor..</param>
        /// <param name="body">Required parameter: The device identifier and fields to match in the search..</param>
        /// <returns>Returns the ApiResponse of Models.SearchSensorHistoryResponseList response from the API call.</returns>
        public ApiResponse<Models.SearchSensorHistoryResponseList> SearchSensorReadings(
                string fieldname,
                Models.SearchSensorHistoryRequest body)
            => CoreHelper.RunTask(SearchSensorReadingsAsync(fieldname, body));

        /// <summary>
        /// Returns the readings of a specified sensor, with the most recent reading first. Sensor readings are stored as events; this request an array of events.
        /// </summary>
        /// <param name="fieldname">Required parameter: The name of the sensor..</param>
        /// <param name="body">Required parameter: The device identifier and fields to match in the search..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SearchSensorHistoryResponseList response from the API call.</returns>
        public async Task<ApiResponse<Models.SearchSensorHistoryResponseList>> SearchSensorReadingsAsync(
                string fieldname,
                Models.SearchSensorHistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchSensorHistoryResponseList>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/fields/{fieldname}/actions/history")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("fieldname", fieldname))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Remove a device from a ThingSpace account.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the device to delete..</param>
        public void DeleteDeviceFromAccount(
                Models.RemoveDeviceRequest body)
            => CoreHelper.RunVoidTask(DeleteDeviceFromAccountAsync(body));

        /// <summary>
        /// Remove a device from a ThingSpace account.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the device to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteDeviceFromAccountAsync(
                Models.RemoveDeviceRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/actions/delete")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}