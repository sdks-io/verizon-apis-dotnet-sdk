
# Getting Started with Verizon

## Introduction

"The Connection Planner is a service that provides devices windows to connect to their backend APIs. The service validates device access permissions and processes valid devices asynchronously. For each batch, it retrieves device connectivity windows from the RAN KPI Data Application, and sends callbacks back to customers via UWS-Callback for both successful and failed device requests."

Best Practices for Callbacks: [https://thingspace.verizon.com/documentation/apis/connectivity-management/working-with-verizon/about-callback-services/best-practices.html](https://thingspace.verizon.com/documentation/apis/connectivity-management/working-with-verizon/about-callback-services/best-practices.html)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.VerizonApisSDK --version 2.0.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.VerizonApisSDK/2.0.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| ThingspaceOauthCredentials | [`ThingspaceOauthCredentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| VZM2mTokenCredentials | [`VZM2mTokenCredentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| SessionTokenCredentials | [`SessionTokenCredentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |
| ThingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

### Code-Based Initialization

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

### Configuration-Based Initialization

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

See the [Configuration-Based Initialization](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** |
| Staging | - |
| Dev | - |
| Qa | - |
| MockServerForLimitedAvailabilitySeeQuickStart | - |

## Authorization

This API uses the following authentication schemes.

* [`thingspace_oauth (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/oauth-2-client-credentials-grant.md)
* [`VZ-M2M-Token (Custom Header Signature)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/custom-header-signature.md)
* [`sessionToken (Custom Header Signature)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/custom-header-signature-1.md)
* [`thingspace_oauth1 (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/auth/oauth-2-client-credentials-grant-1.md)

## List of APIs

* [Account Service Controller](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/account-service-controller.md)
* [Intelligence Service Controller](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/intelligence-service-controller.md)
* [Device Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-management.md)
* [Device Groups](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-groups.md)
* [Session Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/session-management.md)
* [Connectivity Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/connectivity-callbacks.md)
* [Account Requests](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/account-requests.md)
* [Service Plans](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/service-plans.md)
* [Device Diagnostics](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-diagnostics.md)
* [Device Monitoring](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-monitoring.md)
* [Device Profile Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-profile-management.md)
* [E UICC Device Profile Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/e-uicc-device-profile-management.md)
* [Devices Locations](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/devices-locations.md)
* [Devices Location Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/devices-location-subscriptions.md)
* [Device Location Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-location-callbacks.md)
* [Usage Trigger Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/usage-trigger-management.md)
* [Software Management Subscriptions V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-subscriptions-v1.md)
* [Software Management Licenses V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-licenses-v1.md)
* [Firmware V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/firmware-v1.md)
* [Software Management Callbacks V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-callbacks-v1.md)
* [Software Management Reports V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-reports-v1.md)
* [Software Management Subscriptions V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-subscriptions-v2.md)
* [Software Management Licenses V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-licenses-v2.md)
* [Campaigns V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/campaigns-v2.md)
* [Software Management Callbacks V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-callbacks-v2.md)
* [Software Management Reports V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-reports-v2.md)
* [Client Logging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/client-logging.md)
* [Server Logging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/server-logging.md)
* [Configuration Files](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/configuration-files.md)
* [Software Management Subscriptions V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-subscriptions-v3.md)
* [Software Management Licenses V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-licenses-v3.md)
* [Campaigns V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/campaigns-v3.md)
* [Software Management Reports V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-reports-v3.md)
* [Firmware V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/firmware-v3.md)
* [Account Devices](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/account-devices.md)
* [Software Management Callbacks V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/software-management-callbacks-v3.md)
* [SIM Securefor Io T Licenses](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sim-securefor-io-t-licenses.md)
* [Account Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/account-subscriptions.md)
* [Diagnostics Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/diagnostics-subscriptions.md)
* [Diagnostics Observations](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/diagnostics-observations.md)
* [Diagnostics History](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/diagnostics-history.md)
* [Diagnostics Settings](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/diagnostics-settings.md)
* [Diagnostics Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/diagnostics-callbacks.md)
* [Diagnostics Factory Reset](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/diagnostics-factory-reset.md)
* [Cloud Connector Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/cloud-connector-subscriptions.md)
* [Cloud Connector Devices](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/cloud-connector-devices.md)
* [HPL Device Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/hpl-device-management.md)
* [Device Service Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-service-management.md)
* [Device Reports](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-reports.md)
* [Hyper Precise Location Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/hyper-precise-location-callbacks.md)
* [Device Credential Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-credential-management.md)
* [Anomaly Settings](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/anomaly-settings.md)
* [Anomaly Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/anomaly-triggers.md)
* [Anomaly Triggers V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/anomaly-triggers-v2.md)
* [Wireless Network Performance](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/wireless-network-performance.md)
* [Managinge SIM Profiles](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/managinge-sim-profiles.md)
* [Device SMS Messaging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-sms-messaging.md)
* [Device Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-actions.md)
* [Thing Space Qualityof Service API Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/thing-space-qualityof-service-api-actions.md)
* [Promotion Period Information](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/promotion-period-information.md)
* [Retrievethe Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/retrievethe-triggers.md)
* [Update Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/update-triggers.md)
* [SIM Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sim-actions.md)
* [Global Reporting](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/global-reporting.md)
* [Map Data Manager](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/map-data-manager.md)
* [Retrieve Rate Plan List](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/retrieve-rate-plan-list.md)
* [Create Price Plan Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/create-price-plan-triggers.md)
* [Update Price Plan Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/update-price-plan-triggers.md)
* [5G BI Device Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/5g-bi-device-actions.md)
* [Sensor Insights Sensors](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-sensors.md)
* [Sensor Insights Devices](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-devices.md)
* [Sensor Insights Gateways](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-gateways.md)
* [Sensor Insights Smart Alerts](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-smart-alerts.md)
* [Sensor Insights Rules](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-rules.md)
* [Sensor Insights Health Score](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-health-score.md)
* [Sensor Insights Notification Groups](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-notification-groups.md)
* [Sensor Insights Users](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-users.md)
* [Sensor Insights Device Profile](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-device-profile.md)
* [Sensor Insights Smart Alert Metrics](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sensor-insights-smart-alert-metrics.md)
* [API](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/api.md)
* [Accounts](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/accounts.md)
* [SMS](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/sms.md)
* [Exclusions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/exclusions.md)
* [Billing](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/billing.md)
* [Targets](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/targets.md)
* [PWN](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/pwn.md)
* [Device-Role-Controller](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/controllers/device-role-controller.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/api-exception.md)
* [ApiResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/api-response.md)
* [ApiHelper](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/2.0.0/doc/unix-date-time-converter.md)

