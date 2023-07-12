// <copyright file="DeviceManagementController.cs" company="APIMatic">
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
    /// DeviceManagementController.
    /// </summary>
    public class DeviceManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementController"/> class.
        /// </summary>
        internal DeviceManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// If the devices do not already exist in the account, this API resource adds them before activation.
        /// </summary>
        /// <param name="body">Required parameter: Request for activating a service on devices..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> ActivateServiceForDevices(
                Models.CarrierActivateRequest body)
            => CoreHelper.RunTask(ActivateServiceForDevicesAsync(body));

        /// <summary>
        /// If the devices do not already exist in the account, this API resource adds them before activation.
        /// </summary>
        /// <param name="body">Required parameter: Request for activating a service on devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> ActivateServiceForDevicesAsync(
                Models.CarrierActivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/activate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Use this API if you want to manage some device settings before you are ready to activate service for the devices.
        /// </summary>
        /// <param name="body">Required parameter: Devices to add..</param>
        /// <returns>Returns the ApiResponse of List<Models.AddDevicesResult> response from the API call.</returns>
        public ApiResponse<List<Models.AddDevicesResult>> AddDevices(
                Models.AddDevicesRequest body)
            => CoreHelper.RunTask(AddDevicesAsync(body));

        /// <summary>
        /// Use this API if you want to manage some device settings before you are ready to activate service for the devices.
        /// </summary>
        /// <param name="body">Required parameter: Devices to add..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.AddDevicesResult> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.AddDevicesResult>>> AddDevicesAsync(
                Models.AddDevicesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.AddDevicesResult>>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/add")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.AddDevicesResult>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.
        /// </summary>
        /// <param name="body">Required parameter: Request to update contact information for devices..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UpdateDevicesContactInformation(
                Models.ContactInfoUpdateRequest body)
            => CoreHelper.RunTask(UpdateDevicesContactInformationAsync(body));

        /// <summary>
        /// Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.
        /// </summary>
        /// <param name="body">Required parameter: Request to update contact information for devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UpdateDevicesContactInformationAsync(
                Models.ContactInfoUpdateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/devices/actions/contactinfo")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Sends a CarrierService callback message for each device in the request when the custom fields have been changed, or if there was a problem and the change could not be completed.
        /// </summary>
        /// <param name="body">Required parameter: Request to update custom field of devices..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UpdateDevicesCustomFields(
                Models.CustomFieldsUpdateRequest body)
            => CoreHelper.RunTask(UpdateDevicesCustomFieldsAsync(body));

        /// <summary>
        /// Sends a CarrierService callback message for each device in the request when the custom fields have been changed, or if there was a problem and the change could not be completed.
        /// </summary>
        /// <param name="body">Required parameter: Request to update custom field of devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UpdateDevicesCustomFieldsAsync(
                Models.CustomFieldsUpdateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/devices/actions/customFields")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Deactivating service for a device may result in an early termination fee (ETF) being charged to the account, depending on the terms of the contract with Verizon. If your contract allows ETF waivers and if you want to use one for a particular deactivation, set the etfWaiver value to True.
        /// </summary>
        /// <param name="body">Required parameter: Request to deactivate service for one or more devices..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> DeactivateServiceForDevices(
                Models.CarrierDeactivateRequest body)
            => CoreHelper.RunTask(DeactivateServiceForDevicesAsync(body));

        /// <summary>
        /// Deactivating service for a device may result in an early termination fee (ETF) being charged to the account, depending on the terms of the contract with Verizon. If your contract allows ETF waivers and if you want to use one for a particular deactivation, set the etfWaiver value to True.
        /// </summary>
        /// <param name="body">Required parameter: Request to deactivate service for one or more devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> DeactivateServiceForDevicesAsync(
                Models.CarrierDeactivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/deactivate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Use this API to remove unneeded devices from an account.
        /// </summary>
        /// <param name="body">Required parameter: Devices to delete..</param>
        /// <returns>Returns the ApiResponse of List<Models.DeleteDevicesResult> response from the API call.</returns>
        public ApiResponse<List<Models.DeleteDevicesResult>> DeleteDeactivatedDevices(
                Models.DeleteDevicesRequest body)
            => CoreHelper.RunTask(DeleteDeactivatedDevicesAsync(body));

        /// <summary>
        /// Use this API to remove unneeded devices from an account.
        /// </summary>
        /// <param name="body">Required parameter: Devices to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.DeleteDevicesResult> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeleteDevicesResult>>> DeleteDeactivatedDevicesAsync(
                Models.DeleteDevicesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeleteDevicesResult>>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.DeleteDevicesResult>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns information about a single device or information about all devices that match the given parameters. Returned information includes device provisioning state, service plan, MDN, MIN, and IP address.
        /// </summary>
        /// <param name="body">Required parameter: Device information query..</param>
        /// <returns>Returns the ApiResponse of Models.AccountDeviceListResult response from the API call.</returns>
        public ApiResponse<Models.AccountDeviceListResult> ListDevicesInformation(
                Models.AccountDeviceListRequest body)
            => CoreHelper.RunTask(ListDevicesInformationAsync(body));

        /// <summary>
        /// Returns information about a single device or information about all devices that match the given parameters. Returned information includes device provisioning state, service plan, MDN, MIN, and IP address.
        /// </summary>
        /// <param name="body">Required parameter: Device information query..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AccountDeviceListResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AccountDeviceListResult>> ListDevicesInformationAsync(
                Models.AccountDeviceListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountDeviceListResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/list")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.AccountDeviceListResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.
        /// </summary>
        /// <param name="body">Required parameter: Request to list devices with mismatched IMEIs and ICCIDs..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceMismatchListResult response from the API call.</returns>
        public ApiResponse<Models.DeviceMismatchListResult> ListDevicesWithImeiIccidMismatch(
                Models.DeviceMismatchListRequest body)
            => CoreHelper.RunTask(ListDevicesWithImeiIccidMismatchAsync(body));

        /// <summary>
        /// Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.
        /// </summary>
        /// <param name="body">Required parameter: Request to list devices with mismatched IMEIs and ICCIDs..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceMismatchListResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceMismatchListResult>> ListDevicesWithImeiIccidMismatchAsync(
                Models.DeviceMismatchListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceMismatchListResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/list/imeiiccidmismatch")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceMismatchListResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Move active devices from one billing account to another within a customer profile.
        /// </summary>
        /// <param name="body">Required parameter: Request to move devices between accounts..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> MoveDevicesWithinAccountsOfProfile(
                Models.MoveDeviceRequest body)
            => CoreHelper.RunTask(MoveDevicesWithinAccountsOfProfileAsync(body));

        /// <summary>
        /// Move active devices from one billing account to another within a customer profile.
        /// </summary>
        /// <param name="body">Required parameter: Request to move devices between accounts..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> MoveDevicesWithinAccountsOfProfileAsync(
                Models.MoveDeviceRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/devices/actions/move")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Changes the provisioning state of one or more devices to a specified customer-defined service and state.
        /// </summary>
        /// <param name="body">Required parameter: Request to change device state to one defined by the user..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UpdateDevicesState(
                Models.GoToStateRequest body)
            => CoreHelper.RunTask(UpdateDevicesStateAsync(body));

        /// <summary>
        /// Changes the provisioning state of one or more devices to a specified customer-defined service and state.
        /// </summary>
        /// <param name="body">Required parameter: Request to change device state to one defined by the user..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UpdateDevicesStateAsync(
                Models.GoToStateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/devices/actions/gotostate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Changes the service plan for one or more devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to change device service plan..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> ChangeDevicesServicePlan(
                Models.ServicePlanUpdateRequest body)
            => CoreHelper.RunTask(ChangeDevicesServicePlanAsync(body));

        /// <summary>
        /// Changes the service plan for one or more devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to change device service plan..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> ChangeDevicesServicePlanAsync(
                Models.ServicePlanUpdateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/devices/actions/plan")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Suspends service for one or more devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to suspend service for one or more devices..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> SuspendServiceForDevices(
                Models.CarrierActionsRequest body)
            => CoreHelper.RunTask(SuspendServiceForDevicesAsync(body));

        /// <summary>
        /// Suspends service for one or more devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to suspend service for one or more devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> SuspendServiceForDevicesAsync(
                Models.CarrierActionsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/suspend")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Restores service to one or more suspended devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to restore services of one or more suspended devices..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> RestoreServiceForSuspendedDevices(
                Models.CarrierActionsRequest body)
            => CoreHelper.RunTask(RestoreServiceForSuspendedDevicesAsync(body));

        /// <summary>
        /// Restores service to one or more suspended devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to restore services of one or more suspended devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> RestoreServiceForSuspendedDevicesAsync(
                Models.CarrierActionsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/restore")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.
        /// </summary>
        /// <param name="body">Required parameter: Request to check if devices can be activated or not..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> CheckDevicesAvailabilityForActivation(
                Models.DeviceActivationRequest body)
            => CoreHelper.RunTask(CheckDevicesAvailabilityForActivationAsync(body));

        /// <summary>
        /// Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.
        /// </summary>
        /// <param name="body">Required parameter: Request to check if devices can be activated or not..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> CheckDevicesAvailabilityForActivationAsync(
                Models.DeviceActivationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/availability/actions/list")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Each response includes a maximum of 500 records. To obtain more records, you can call the API multiple times, adjusting the earliest value each time to start where the previous request finished.
        /// </summary>
        /// <param name="body">Required parameter: Query to retrieve device connection history..</param>
        /// <returns>Returns the ApiResponse of Models.ConnectionHistoryResult response from the API call.</returns>
        public ApiResponse<Models.ConnectionHistoryResult> RetrieveDeviceConnectionHistory(
                Models.DeviceConnectionListRequest body)
            => CoreHelper.RunTask(RetrieveDeviceConnectionHistoryAsync(body));

        /// <summary>
        /// Each response includes a maximum of 500 records. To obtain more records, you can call the API multiple times, adjusting the earliest value each time to start where the previous request finished.
        /// </summary>
        /// <param name="body">Required parameter: Query to retrieve device connection history..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConnectionHistoryResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ConnectionHistoryResult>> RetrieveDeviceConnectionHistoryAsync(
                Models.DeviceConnectionListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConnectionHistoryResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/connections/actions/listHistory")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ConnectionHistoryResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to update cost center code value for one or more devices..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UpdateDevicesCostCenterCode(
                Models.DeviceCostCenterRequest body)
            => CoreHelper.RunTask(UpdateDevicesCostCenterCodeAsync(body));

        /// <summary>
        /// Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to update cost center code value for one or more devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UpdateDevicesCostCenterCodeAsync(
                Models.DeviceCostCenterRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/devices/costCenter")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.
        /// </summary>
        /// <param name="body">Required parameter: Request to query extended diagnostics information for a device..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceExtendedDiagnosticsResult response from the API call.</returns>
        public ApiResponse<Models.DeviceExtendedDiagnosticsResult> GetDeviceExtendedDiagnosticInformation(
                Models.DeviceExtendedDiagnosticsRequest body)
            => CoreHelper.RunTask(GetDeviceExtendedDiagnosticInformationAsync(body));

        /// <summary>
        /// Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.
        /// </summary>
        /// <param name="body">Required parameter: Request to query extended diagnostics information for a device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceExtendedDiagnosticsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceExtendedDiagnosticsResult>> GetDeviceExtendedDiagnosticInformationAsync(
                Models.DeviceExtendedDiagnosticsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceExtendedDiagnosticsResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/extendeddiagnostics/actions/list")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceExtendedDiagnosticsResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns the provisioning history of a specified device during a specified time period.
        /// </summary>
        /// <param name="body">Required parameter: Query to obtain device provisioning history..</param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceProvisioningHistoryListResult> response from the API call.</returns>
        public ApiResponse<List<Models.DeviceProvisioningHistoryListResult>> ListDevicesProvisioningHistory(
                Models.DeviceProvisioningHistoryListRequest body)
            => CoreHelper.RunTask(ListDevicesProvisioningHistoryAsync(body));

        /// <summary>
        /// Returns the provisioning history of a specified device during a specified time period.
        /// </summary>
        /// <param name="body">Required parameter: Query to obtain device provisioning history..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceProvisioningHistoryListResult> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceProvisioningHistoryListResult>>> ListDevicesProvisioningHistoryAsync(
                Models.DeviceProvisioningHistoryListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceProvisioningHistoryListResult>>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/history/actions/list")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.DeviceProvisioningHistoryListResult>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// 4G and GSM devices do not have a PRL.
        /// </summary>
        /// <param name="body">Required parameter: Request to query device PRL..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> ListCurrentDevicesPRLVersion(
                Models.DevicePrlListRequest body)
            => CoreHelper.RunTask(ListCurrentDevicesPRLVersionAsync(body));

        /// <summary>
        /// 4G and GSM devices do not have a PRL.
        /// </summary>
        /// <param name="body">Required parameter: Request to query device PRL..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> ListCurrentDevicesPRLVersionAsync(
                Models.DevicePrlListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/prl/actions/list")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain service suspenstion status for a device..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> GetDeviceServiceSuspensionStatus(
                Models.DeviceSuspensionStatusRequest body)
            => CoreHelper.RunTask(GetDeviceServiceSuspensionStatusAsync(body));

        /// <summary>
        /// Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain service suspenstion status for a device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> GetDeviceServiceSuspensionStatusAsync(
                Models.DeviceSuspensionStatusRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/suspension/status")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns the network data usage history of a device during a specified time period.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain usage history for a specific device..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceUsageListResult response from the API call.</returns>
        public ApiResponse<Models.DeviceUsageListResult> ListDevicesUsageHistory(
                Models.DeviceUsageListRequest body)
            => CoreHelper.RunTask(ListDevicesUsageHistoryAsync(body));

        /// <summary>
        /// Returns the network data usage history of a device during a specified time period.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain usage history for a specific device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceUsageListResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceUsageListResult>> ListDevicesUsageHistoryAsync(
                Models.DeviceUsageListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceUsageListResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/usage/actions/list")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceUsageListResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// The information is returned in a callback response, so you must register a URL for DeviceUsage callback messages using the POST /callbacks API.
        /// </summary>
        /// <param name="body">Required parameter: A request to retrieve aggregated device usage history information..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> RetrieveAggregateDeviceUsageHistory(
                Models.DeviceAggregateUsageListRequest body)
            => CoreHelper.RunTask(RetrieveAggregateDeviceUsageHistoryAsync(body));

        /// <summary>
        /// The information is returned in a callback response, so you must register a URL for DeviceUsage callback messages using the POST /callbacks API.
        /// </summary>
        /// <param name="body">Required parameter: A request to retrieve aggregated device usage history information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> RetrieveAggregateDeviceUsageHistoryAsync(
                Models.DeviceAggregateUsageListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/usage/actions/list/aggregate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.
        /// </summary>
        /// <param name="serviceType">Required parameter: Identifier type..</param>
        /// <param name="body">Required parameter: Request to update device id..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UpdateDeviceId(
                string serviceType,
                Models.ChangeDeviceIdRequest body)
            => CoreHelper.RunTask(UpdateDeviceIdAsync(serviceType, body));

        /// <summary>
        /// Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.
        /// </summary>
        /// <param name="serviceType">Required parameter: Identifier type..</param>
        /// <param name="body">Required parameter: Request to update device id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UpdateDeviceIdAsync(
                string serviceType,
                Models.ChangeDeviceIdRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/devices/{serviceType}/actions/deviceId")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("serviceType", serviceType))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```DeviceUploadService```.
        /// </summary>
        /// <param name="body">Required parameter: Device Upload Query.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> DeviceUpload(
                Models.DeviceUploadRequest body)
            => CoreHelper.RunTask(DeviceUploadAsync(body));

        /// <summary>
        /// This corresponds to the M2M-MC SOAP interface, ```DeviceUploadService```.
        /// </summary>
        /// <param name="body">Required parameter: Device Upload Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> DeviceUploadAsync(
                Models.DeviceUploadRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/upload")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.RequestResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets billed usage for for either multiple devices or an entire billing account.
        /// </summary>
        /// <param name="body">Required parameter: Request to list devices with mismatched IMEIs and ICCIDs..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> BilledUsageInfo(
                Models.BilledusageListRequest body)
            => CoreHelper.RunTask(BilledUsageInfoAsync(body));

        /// <summary>
        /// Gets billed usage for for either multiple devices or an entire billing account.
        /// </summary>
        /// <param name="body">Required parameter: Request to list devices with mismatched IMEIs and ICCIDs..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> BilledUsageInfoAsync(
                Models.BilledusageListRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/usage/actions/billedusage/list")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Allows you to associate your own usage segmentation label with a device.
        /// </summary>
        /// <param name="body">Required parameter: Request to associate a label to a device..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UsageSegmentationLabelAssociation(
                Models.AssociateLabelRequest body)
            => CoreHelper.RunTask(UsageSegmentationLabelAssociationAsync(body));

        /// <summary>
        /// Allows you to associate your own usage segmentation label with a device.
        /// </summary>
        /// <param name="body">Required parameter: Request to associate a label to a device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UsageSegmentationLabelAssociationAsync(
                Models.AssociateLabelRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/usagesegmentationlabels")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Allow customers to remove the associated label from a device.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="labelList">Required parameter: A list of the Label IDs to remove from the exclusion list..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UsageSegmentationLabelDeletion(
                string accountName,
                Models.LabelsList labelList)
            => CoreHelper.RunTask(UsageSegmentationLabelDeletionAsync(accountName, labelList));

        /// <summary>
        /// Allow customers to remove the associated label from a device.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="labelList">Required parameter: A list of the Label IDs to remove from the exclusion list..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UsageSegmentationLabelDeletionAsync(
                string accountName,
                Models.LabelsList labelList,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/devices/actions/usagesegmentationlabels")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("LabelList", labelList))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.
        /// </summary>
        /// <param name="body">Required parameter: Request to Uploads and activates device..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> ActivationOrderStatus(
                Models.UploadsActivatesDeviceRequest body)
            => CoreHelper.RunTask(ActivationOrderStatusAsync(body));

        /// <summary>
        /// Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.
        /// </summary>
        /// <param name="body">Required parameter: Request to Uploads and activates device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> ActivationOrderStatusAsync(
                Models.UploadsActivatesDeviceRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/actions/uploadactivate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Checks the status of an activation order and lists where the order is in the provisioning process.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the device and reporting period that you want included in the report..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> UploadDeviceIdentifier(
                Models.CheckOrderStatusRequest body)
            => CoreHelper.RunTask(UploadDeviceIdentifierAsync(body));

        /// <summary>
        /// Checks the status of an activation order and lists where the order is in the provisioning process.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the device and reporting period that you want included in the report..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> UploadDeviceIdentifierAsync(
                Models.CheckOrderStatusRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/requests/status")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}