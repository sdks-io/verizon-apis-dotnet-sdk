
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](../README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| ThingspaceOauthCredentials | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| VZM2mTokenCredentials | [`VZM2mTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| SessionTokenCredentials | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |
| ThingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

## Code-Based Initialization

```csharp
using Verizon.Standard;
using Verizon.Standard.Authentication;

namespace ConsoleApp;

VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauthCredentials(
        new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .VZM2mTokenCredentials(
        new VZM2mTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .Build())
    .SessionTokenCredentials(
        new SessionTokenModel.Builder(
            "SessionToken"
        )
        .Build())
    .ThingspaceOauth1Credentials(
        new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(Verizon.Standard.Environment.Production)
    .Build();
```

## Configuration-Based Initialization

```csharp
using Verizon.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = VerizonClient
    .FromConfiguration(configuration.GetSection("Verizon"));
```

See the [Configuration-Based Initialization](../doc/configuration-based-initialization.md) section for details.

## VerizonClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| AccountServiceController | Gets AccountServiceController controller. |
| IntelligenceServiceController | Gets IntelligenceServiceController controller. |
| DeviceManagementController | Gets DeviceManagementController controller. |
| AccountsController | Gets AccountsController controller. |
| DeviceGroupsController | Gets DeviceGroupsController controller. |
| SMSController | Gets SMSController controller. |
| SessionManagementController | Gets SessionManagementController controller. |
| ConnectivityCallbacksController | Gets ConnectivityCallbacksController controller. |
| AccountRequestsController | Gets AccountRequestsController controller. |
| ServicePlansController | Gets ServicePlansController controller. |
| DeviceDiagnosticsController | Gets DeviceDiagnosticsController controller. |
| DeviceMonitoringController | Gets DeviceMonitoringController controller. |
| DeviceProfileManagementController | Gets DeviceProfileManagementController controller. |
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
| DiagnosticsSubscriptionsController | Gets DiagnosticsSubscriptionsController controller. |
| DiagnosticsObservationsController | Gets DiagnosticsObservationsController controller. |
| DiagnosticsHistoryController | Gets DiagnosticsHistoryController controller. |
| DiagnosticsSettingsController | Gets DiagnosticsSettingsController controller. |
| DiagnosticsCallbacksController | Gets DiagnosticsCallbacksController controller. |
| DiagnosticsFactoryResetController | Gets DiagnosticsFactoryResetController controller. |
| TargetsController | Gets TargetsController controller. |
| CloudConnectorSubscriptionsController | Gets CloudConnectorSubscriptionsController controller. |
| CloudConnectorDevicesController | Gets CloudConnectorDevicesController controller. |
| HPLDeviceManagementController | Gets HPLDeviceManagementController controller. |
| DeviceServiceManagementController | Gets DeviceServiceManagementController controller. |
| DeviceReportsController | Gets DeviceReportsController controller. |
| HyperPreciseLocationCallbacksController | Gets HyperPreciseLocationCallbacksController controller. |
| DeviceCredentialManagementController | Gets DeviceCredentialManagementController controller. |
| AnomalySettingsController | Gets AnomalySettingsController controller. |
| AnomalyTriggersController | Gets AnomalyTriggersController controller. |
| AnomalyTriggersV2Controller | Gets AnomalyTriggersV2Controller controller. |
| WirelessNetworkPerformanceController | Gets WirelessNetworkPerformanceController controller. |
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
| DeviceRoleController | Gets DeviceRoleController controller. |
| MapDataManagerController | Gets MapDataManagerController controller. |
| RetrieveRatePlanListController | Gets RetrieveRatePlanListController controller. |
| CreatePricePlanTriggersController | Gets CreatePricePlanTriggersController controller. |
| UpdatePricePlanTriggersController | Gets UpdatePricePlanTriggersController controller. |
| M5gBIDeviceActionsController | Gets M5gBIDeviceActionsController controller. |
| SensorInsightsSensorsController | Gets SensorInsightsSensorsController controller. |
| SensorInsightsDevicesController | Gets SensorInsightsDevicesController controller. |
| SensorInsightsGatewaysController | Gets SensorInsightsGatewaysController controller. |
| SensorInsightsSmartAlertsController | Gets SensorInsightsSmartAlertsController controller. |
| SensorInsightsRulesController | Gets SensorInsightsRulesController controller. |
| SensorInsightsHealthScoreController | Gets SensorInsightsHealthScoreController controller. |
| SensorInsightsNotificationGroupsController | Gets SensorInsightsNotificationGroupsController controller. |
| SensorInsightsUsersController | Gets SensorInsightsUsersController controller. |
| SensorInsightsDeviceProfileController | Gets SensorInsightsDeviceProfileController controller. |
| SensorInsightsSmartAlertMetricsController | Gets SensorInsightsSmartAlertMetricsController controller. |
| APIController | Gets APIController controller. |
| OauthAuthorizationController | Gets OauthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| ThingspaceOauthCredentials | Gets the credentials to use with ThingspaceOauth. | [`IThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) |
| VZM2mTokenCredentials | Gets the credentials to use with VZM2MToken. | [`IVZM2mTokenCredentials`](auth/custom-header-signature.md) |
| SessionTokenCredentials | Gets the credentials to use with SessionToken. | [`ISessionTokenCredentials`](auth/custom-header-signature-1.md) |
| ThingspaceOauth1Credentials | Gets the credentials to use with ThingspaceOauth1. | [`IThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Thingspace)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the VerizonClient using the values provided for the builder. | `Builder` |

## VerizonClient Builder Class

Class to build instances of VerizonClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `ThingspaceOauthCredentials(Action<ThingspaceOauthModel.Builder> action)` | Sets credentials for ThingspaceOauth. | `Builder` |
| `VZM2mTokenCredentials(Action<VZM2mTokenModel.Builder> action)` | Sets credentials for VZM2MToken. | `Builder` |
| `SessionTokenCredentials(Action<SessionTokenModel.Builder> action)` | Sets credentials for SessionToken. | `Builder` |
| `ThingspaceOauth1Credentials(Action<ThingspaceOauth1Model.Builder> action)` | Sets credentials for ThingspaceOauth1. | `Builder` |

