
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `VZM2mToken` | `string` | M2M Session Token |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `OauthClientId` | `string` | OAuth 2 Client ID |
| `OauthClientSecret` | `string` | OAuth 2 Client Secret |
| `OauthToken` | `Models.OauthToken` | Object for storing information about the OAuth token |
| `OauthScopes` | `List<Models.OauthScopeEnum>` |  |

The API client can be initialized as follows:

```csharp
Verizon.Standard.VerizonClient client = new Verizon.Standard.VerizonClient.Builder()
    .OauthScopes(new List<OauthScopeEnum>() { OauthScopeEnum.Discoveryread, OauthScopeEnum.Serviceprofileread })
    .ClientCredentialsAuth("OAuthClientId", "OAuthClientSecret")
    .VZM2MToken("VZ-M2M-Token")
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
| DeviceProfileManagementController | Gets DeviceProfileManagementController controller. |
| DeviceMonitoringController | Gets DeviceMonitoringController controller. |
| UICCDeviceProfileManagementController | Gets UICCDeviceProfileManagementController controller. |
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
| MECSitesController | Gets MECSitesController controller. |
| ServiceLaunchProfilesController | Gets ServiceLaunchProfilesController controller. |
| ServiceLaunchRequestsController | Gets ServiceLaunchRequestsController controller. |
| ServiceInstancesController | Gets ServiceInstancesController controller. |
| ServiceInstanceOperationsController | Gets ServiceInstanceOperationsController controller. |
| ServiceOnboardingController | Gets ServiceOnboardingController controller. |
| ServiceMetadataController | Gets ServiceMetadataController controller. |
| RepositoriesController | Gets RepositoriesController controller. |
| CSPProfilesController | Gets CSPProfilesController controller. |
| ServiceClaimsController | Gets ServiceClaimsController controller. |
| OauthAuthorizationController | Gets OauthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| Auth | Gets the AuthManager. | `AuthManager` |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| VZM2mToken | M2M Session Token | `string` |
| Environment | Current API environment. | `Environment` |

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
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `VZM2mToken(string vZM2mToken)` | M2M Session Token | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |

