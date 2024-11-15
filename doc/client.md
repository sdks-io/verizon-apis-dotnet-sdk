
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ThingspaceOauthCredentials` | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| `VZM2mTokenCredentials` | [`VZM2mTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauthCredentials(
        new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OauthScopes(
            new List<OauthScopeThingspaceOauthEnum>
            {
                OauthScopeThingspaceOauthEnum.Discoveryread,
                OauthScopeThingspaceOauthEnum.Serviceprofileread,
            })
        .Build())
    .VZM2mTokenCredentials(
        new VZM2mTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .Build())
    .Environment(Verizon.Standard.Environment.Production)
    .Build();
```

API calls return an `ApiResponse` object that includes the following fields:

| Field | Description |
|  --- | --- |
| `StatusCode` | Status code of the HTTP response |
| `Headers` | Headers of the HTTP response as a Hash |
| `Data` | The deserialized body of the HTTP response as a String |

## VerizonClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| M5gEdgePlatformsController | Gets M5gEdgePlatformsController controller. |
| ServiceEndpointsController | Gets ServiceEndpointsController controller. |
| ServiceProfilesController | Gets ServiceProfilesController controller. |
| DeviceManagementController | Gets DeviceManagementController controller. |
| AccountsController | Gets AccountsController controller. |
| DeviceGroupsController | Gets DeviceGroupsController controller. |
| SMSController | Gets SMSController controller. |
| SessionManagementController | Gets SessionManagementController controller. |
| ConnectivityCallbacksController | Gets ConnectivityCallbacksController controller. |
| AccountRequestsController | Gets AccountRequestsController controller. |
| ServicePlansController | Gets ServicePlansController controller. |
| DeviceDiagnosticsController | Gets DeviceDiagnosticsController controller. |
| DeviceProfileManagementController | Gets DeviceProfileManagementController controller. |
| DeviceMonitoringController | Gets DeviceMonitoringController controller. |
| EUICCDeviceProfileManagementController | Gets EUICCDeviceProfileManagementController controller. |
| DevicesLocationsController | Gets DevicesLocationsController controller. |
| ExclusionsController | Gets ExclusionsController controller. |
| DevicesLocationSubscriptionsController | Gets DevicesLocationSubscriptionsController controller. |
| DeviceLocationCallbacksController | Gets DeviceLocationCallbacksController controller. |
| UsageTriggerManagementController | Gets UsageTriggerManagementController controller. |
| BillingController | Gets BillingController controller. |
| SoftwareManagementSubscriptionsV1Controller | Gets SoftwareManagementSubscriptionsV1Controller controller. |
| SoftwareManagementLicensesV1Controller | Gets SoftwareManagementLicensesV1Controller controller. |
| FirmwareV1Controller | Gets FirmwareV1Controller controller. |
| SoftwareManagementCallbacksV1Controller | Gets SoftwareManagementCallbacksV1Controller controller. |
| SoftwareManagementReportsV1Controller | Gets SoftwareManagementReportsV1Controller controller. |
| SoftwareManagementSubscriptionsV2Controller | Gets SoftwareManagementSubscriptionsV2Controller controller. |
| SoftwareManagementLicensesV2Controller | Gets SoftwareManagementLicensesV2Controller controller. |
| CampaignsV2Controller | Gets CampaignsV2Controller controller. |
| SoftwareManagementCallbacksV2Controller | Gets SoftwareManagementCallbacksV2Controller controller. |
| SoftwareManagementReportsV2Controller | Gets SoftwareManagementReportsV2Controller controller. |
| ClientLoggingController | Gets ClientLoggingController controller. |
| ServerLoggingController | Gets ServerLoggingController controller. |
| ConfigurationFilesController | Gets ConfigurationFilesController controller. |
| SoftwareManagementSubscriptionsV3Controller | Gets SoftwareManagementSubscriptionsV3Controller controller. |
| SoftwareManagementLicensesV3Controller | Gets SoftwareManagementLicensesV3Controller controller. |
| CampaignsV3Controller | Gets CampaignsV3Controller controller. |
| SoftwareManagementReportsV3Controller | Gets SoftwareManagementReportsV3Controller controller. |
| FirmwareV3Controller | Gets FirmwareV3Controller controller. |
| AccountDevicesController | Gets AccountDevicesController controller. |
| SoftwareManagementCallbacksV3Controller | Gets SoftwareManagementCallbacksV3Controller controller. |
| SIMSecureForIoTLicensesController | Gets SIMSecureForIoTLicensesController controller. |
| AccountSubscriptionsController | Gets AccountSubscriptionsController controller. |
| PerformanceMetricsController | Gets PerformanceMetricsController controller. |
| DiagnosticsSubscriptionsController | Gets DiagnosticsSubscriptionsController controller. |
| DiagnosticsObservationsController | Gets DiagnosticsObservationsController controller. |
| DiagnosticsHistoryController | Gets DiagnosticsHistoryController controller. |
| DiagnosticsSettingsController | Gets DiagnosticsSettingsController controller. |
| DiagnosticsCallbacksController | Gets DiagnosticsCallbacksController controller. |
| DiagnosticsFactoryResetController | Gets DiagnosticsFactoryResetController controller. |
| TargetsController | Gets TargetsController controller. |
| CloudConnectorSubscriptionsController | Gets CloudConnectorSubscriptionsController controller. |
| CloudConnectorDevicesController | Gets CloudConnectorDevicesController controller. |
| DeviceServiceManagementController | Gets DeviceServiceManagementController controller. |
| DeviceReportsController | Gets DeviceReportsController controller. |
| HyperPreciseLocationCallbacksController | Gets HyperPreciseLocationCallbacksController controller. |
| AnomalySettingsController | Gets AnomalySettingsController controller. |
| AnomalyTriggersController | Gets AnomalyTriggersController controller. |
| AnomalyTriggersV2Controller | Gets AnomalyTriggersV2Controller controller. |
| WirelessNetworkPerformanceController | Gets WirelessNetworkPerformanceController controller. |
| FixedWirelessQualificationController | Gets FixedWirelessQualificationController controller. |
| ManagingESIMProfilesController | Gets ManagingESIMProfilesController controller. |
| DeviceSMSMessagingController | Gets DeviceSMSMessagingController controller. |
| DeviceActionsController | Gets DeviceActionsController controller. |
| ThingSpaceQualityOfServiceAPIActionsController | Gets ThingSpaceQualityOfServiceAPIActionsController controller. |
| PWNController | Gets PWNController controller. |
| PromotionPeriodInformationController | Gets PromotionPeriodInformationController controller. |
| RetrieveTheTriggersController | Gets RetrieveTheTriggersController controller. |
| UpdateTriggersController | Gets UpdateTriggersController controller. |
| SIMActionsController | Gets SIMActionsController controller. |
| GlobalReportingController | Gets GlobalReportingController controller. |
| MV2TriggersController | Gets MV2TriggersController controller. |
| M5gBIDeviceActionsController | Gets M5gBIDeviceActionsController controller. |
| OauthAuthorizationController | Gets OauthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| ThingspaceOauthCredentials | Gets the credentials to use with ThingspaceOauth. | [`IThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) |
| VZM2mTokenCredentials | Gets the credentials to use with VZM2MToken. | [`IVZM2mTokenCredentials`](auth/custom-header-signature.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.EdgeDiscovery)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the VerizonClient using the values provided for the builder. | `Builder` |

## VerizonClient Builder Class

Class to build instances of VerizonClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `ThingspaceOauthCredentials(Action<ThingspaceOauthModel.Builder> action)` | Sets credentials for ThingspaceOauth. | `Builder` |
| `VZM2mTokenCredentials(Action<VZM2mTokenModel.Builder> action)` | Sets credentials for VZM2MToken. | `Builder` |

