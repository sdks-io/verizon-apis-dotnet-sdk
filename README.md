
# Getting Started with Verizon

## Introduction

The Verizon Edge Discovery Service API can direct your application clients to connect to the optimal service endpoints for your Multi-access Edge Computing (MEC) applications for every session. The Edge Discovery Service takes into account the current location of a device, its IP anchor location, current network traffic and other factors to determine which 5G Edge platform a device should connect to.

Verizon Terms of Service: [https://www.verizon.com/business/5g-edge-portal/legal.html](https://www.verizon.com/business/5g-edge-portal/legal.html)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.VerizonApisSDK --version 1.7.2
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.VerizonApisSDK/1.7.2

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ThingspaceOauthCredentials` | [`ThingspaceOauthCredentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| `VZM2mTokenCredentials` | [`VZM2mTokenCredentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

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

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** |
| Mock server for limited availability, see quick start | - |

## Authorization

This API uses the following authentication schemes.

* [`thingspace_oauth (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/auth/oauth-2-client-credentials-grant.md)
* [`VZ-M2M-Token (Custom Header Signature)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/auth/custom-header-signature.md)

## List of APIs

* [5G Edge Platforms](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/5g-edge-platforms.md)
* [Service Endpoints](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/service-endpoints.md)
* [Service Profiles](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/service-profiles.md)
* [Device Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-management.md)
* [Device Groups](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-groups.md)
* [Session Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/session-management.md)
* [Connectivity Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/connectivity-callbacks.md)
* [Account Requests](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/account-requests.md)
* [Service Plans](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/service-plans.md)
* [Device Diagnostics](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-diagnostics.md)
* [Device Profile Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-profile-management.md)
* [Device Monitoring](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-monitoring.md)
* [E UICC Device Profile Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/e-uicc-device-profile-management.md)
* [Devices Locations](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/devices-locations.md)
* [Devices Location Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/devices-location-subscriptions.md)
* [Device Location Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-location-callbacks.md)
* [Usage Trigger Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/usage-trigger-management.md)
* [Software Management Subscriptions V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-subscriptions-v1.md)
* [Software Management Licenses V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-licenses-v1.md)
* [Firmware V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/firmware-v1.md)
* [Software Management Callbacks V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-callbacks-v1.md)
* [Software Management Reports V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-reports-v1.md)
* [Software Management Subscriptions V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-subscriptions-v2.md)
* [Software Management Licenses V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-licenses-v2.md)
* [Campaigns V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/campaigns-v2.md)
* [Software Management Callbacks V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-callbacks-v2.md)
* [Software Management Reports V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-reports-v2.md)
* [Client Logging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/client-logging.md)
* [Server Logging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/server-logging.md)
* [Configuration Files](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/configuration-files.md)
* [Software Management Subscriptions V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-subscriptions-v3.md)
* [Software Management Licenses V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-licenses-v3.md)
* [Campaigns V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/campaigns-v3.md)
* [Software Management Reports V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-reports-v3.md)
* [Firmware V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/firmware-v3.md)
* [Account Devices](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/account-devices.md)
* [Software Management Callbacks V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/software-management-callbacks-v3.md)
* [SIM Securefor Io T Licenses](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/sim-securefor-io-t-licenses.md)
* [Account Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/account-subscriptions.md)
* [Performance Metrics](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/performance-metrics.md)
* [Diagnostics Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/diagnostics-subscriptions.md)
* [Diagnostics Observations](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/diagnostics-observations.md)
* [Diagnostics History](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/diagnostics-history.md)
* [Diagnostics Settings](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/diagnostics-settings.md)
* [Diagnostics Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/diagnostics-callbacks.md)
* [Diagnostics Factory Reset](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/diagnostics-factory-reset.md)
* [Cloud Connector Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/cloud-connector-subscriptions.md)
* [Cloud Connector Devices](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/cloud-connector-devices.md)
* [Device Service Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-service-management.md)
* [Device Reports](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-reports.md)
* [Hyper Precise Location Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/hyper-precise-location-callbacks.md)
* [Anomaly Settings](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/anomaly-settings.md)
* [Anomaly Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/anomaly-triggers.md)
* [Anomaly Triggers V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/anomaly-triggers-v2.md)
* [Wireless Network Performance](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/wireless-network-performance.md)
* [Fixed Wireless Qualification](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/fixed-wireless-qualification.md)
* [Managinge SIM Profiles](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/managinge-sim-profiles.md)
* [Device SMS Messaging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-sms-messaging.md)
* [Device Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/device-actions.md)
* [Thing Space Qualityof Service API Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/thing-space-qualityof-service-api-actions.md)
* [Promotion Period Information](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/promotion-period-information.md)
* [Retrievethe Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/retrievethe-triggers.md)
* [Update Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/update-triggers.md)
* [SIM Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/sim-actions.md)
* [Global Reporting](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/global-reporting.md)
* [5G BI Device Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/5g-bi-device-actions.md)
* [Accounts](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/accounts.md)
* [SMS](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/sms.md)
* [Exclusions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/exclusions.md)
* [Billing](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/billing.md)
* [Targets](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/targets.md)
* [PWN](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/pwn.md)
* [V2 Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/controllers/v2-triggers.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/http-client-configuration-builder.md)
* [ApiException](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.7.2/doc/api-exception.md)

