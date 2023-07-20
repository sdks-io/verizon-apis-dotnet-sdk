
# Getting Started with Verizon

## Introduction

The Verizon Edge Discovery Service API can direct your application clients to connect to the optimal service endpoints for your Multi-access Edge Computing (MEC) applications for every session. The Edge Discovery Service takes into account the current location of a device, its IP anchor location, current network traffic and other factors to determine which 5G Edge platform a device should connect to.

Verizon Terms of Service: [https://www.verizon.com/business/5g-edge-portal/legal.html](https://www.verizon.com/business/5g-edge-portal/legal.html)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.VerizonApisSDK --version 1.0.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.VerizonApisSDK/1.0.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/client.md)

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

## Authorization

This API uses `OAuth 2 Client Credentials Grant`.

## Client Credentials Grant

Your application must obtain user authorization before it can execute an endpoint call in case this SDK chooses to use *OAuth 2.0 Client Credentials Grant*. This authorization includes the following steps

The `FetchToken()` method will exchange the OAuth client credentials for an *access token*. The access token is an object containing information for authorizing client requests and refreshing the token itself.

You must have initialized the client with [scopes]($h/__authorize/Scopes) for which you need permission to access.

```csharp
var authManager = client.ClientCredentialsAuth;

try
{
    OAuthToken token = authManager.FetchToken();
    // re-instantiate the client with OAuth token
    client = client.ToBuilder().OAuthToken(token).Build();
}
catch (ApiException e)
{
    // TODO Handle exception
}
```

The client can now make authorized endpoint calls.

### Scopes

Scopes enable your application to only request access to the resources it needs while enabling users to control the amount of access they grant to your application. Available scopes are defined in the `OauthScopeEnum` enumeration.

| Scope Name | Description |
|  --- | --- |
| `DISCOVERYREAD` | Grant read-only access to discovery data |
| `SERVICEPROFILEREAD` | Grant read-only access to service profile data |
| `SERVICEPROFILEWRITE` | Grant write access to service profile data |
| `SERVICEREGISTRYREAD` | Grant read-only access to Service registry data |
| `SERVICEREGISTRYWRITE` | Grant write access to Service registry data |
| `TS.MEC.FULLACCESS` | Full access for /serviceprofiles and /serviceendpoints. |
| `TS.MEC.LIMITACCESS` | Limited access. Will not allow use of /serviceprofiles and /serviceendpoints but will allow discovery. |
| `TS.APPLICATION.RO` |  |
| `EDGEDISCOVERYREAD` |  |
| `EDGESERVICEPROFILEREAD` |  |
| `EDGESERVICEPROFILEWRITE` |  |
| `EDGESERVICEREGISTRYREAD` |  |
| `EDGESERVICEREGISTRYWRITE` |  |
| `READ` | read access |
| `WRITE` | read/write access |

### Storing an access token for reuse

It is recommended that you store the access token for reuse.

```csharp
// store token
SaveTokenToDatabase(client.ClientCredentialsAuth.OAuthToken);
```

### Creating a client from a stored token

To authorize a client from a stored access token, just set the access token in Configuration along with the other configuration parameters before creating the client:

```csharp
// load token later
OAuthToken token = LoadTokenFromDatabase();

// Provide token along with other configuration properties while instantiating the client
VerizonClient client = client.ToBuilder().OAuthToken(token).Build();
```

### Complete example

```csharp
using Verizon.Standard;
using Verizon.Standard.Models;
using Verizon.Standard.Exceptions;
using Verizon.Standard.Authentication;
using System.Collections.Generic;
namespace OAuthTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Verizon.Standard.VerizonClient client = new Verizon.Standard.VerizonClient.Builder()
                .OauthScopes(new List<OauthScopeEnum>() { OauthScopeEnum.Discoveryread, OauthScopeEnum.Serviceprofileread })
                .ClientCredentialsAuth("OAuthClientId", "OAuthClientSecret")
                .VZM2MToken("VZ-M2M-Token")
                .Environment(Verizon.Standard.Environment.Production)
                .Build();
            try
            {
                OAuthToken token = LoadTokenFromDatabase();

                // Set the token if it is not set before
                if (token == null)
                {
                    var authManager = client.ClientCredentialsAuth;
                    token = authManager.FetchToken();
                }

                SaveTokenToDatabase(token);
                client = client.ToBuilder().OAuthToken(token).Build();
            }
            catch (OAuthProviderException e)
            {
                // TODO Handle exception
            }
        }

        //function for storing token to database
        static void SaveTokenToDatabase(OAuthToken token)
        {
            //Save token here
        }

        //function for loading token from database
        static OAuthToken LoadTokenFromDatabase()
        {
            OAuthToken token = null;
            //token = Get token here
            return token;
        }
    }
}

// the client is now authorized and you can use controllers to make endpoint calls
```

## List of APIs

* [5G Edge Platforms](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/5g-edge-platforms.md)
* [Service Endpoints](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-endpoints.md)
* [Service Profiles](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-profiles.md)
* [Device Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/device-management.md)
* [Device Groups](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/device-groups.md)
* [Session Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/session-management.md)
* [Connectivity Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/connectivity-callbacks.md)
* [Account Requests](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/account-requests.md)
* [Service Plans](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-plans.md)
* [Device Profile Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/device-profile-management.md)
* [Device Monitoring](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/device-monitoring.md)
* [UICC Device Profile Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/uicc-device-profile-management.md)
* [Devices Locations](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/devices-locations.md)
* [Devices Location Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/devices-location-subscriptions.md)
* [Device Location Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/device-location-callbacks.md)
* [Usage Trigger Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/usage-trigger-management.md)
* [Software Management Subscriptions V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-subscriptions-v1.md)
* [Software Management Licenses V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-licenses-v1.md)
* [Firmware V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/firmware-v1.md)
* [Software Management Callbacks V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-callbacks-v1.md)
* [Software Management Reports V1](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-reports-v1.md)
* [Software Management Subscriptions V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-subscriptions-v2.md)
* [Software Management Licenses V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-licenses-v2.md)
* [Campaigns V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/campaigns-v2.md)
* [Software Management Callbacks V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-callbacks-v2.md)
* [Software Management Reports V2](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-reports-v2.md)
* [Client Logging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/client-logging.md)
* [Server Logging](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/server-logging.md)
* [Configuration Files](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/configuration-files.md)
* [Software Management Subscriptions V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-subscriptions-v3.md)
* [Software Management Licenses V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-licenses-v3.md)
* [Campaigns V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/campaigns-v3.md)
* [Software Management Reports V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-reports-v3.md)
* [Firmware V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/firmware-v3.md)
* [Account Devices](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/account-devices.md)
* [Software Management Callbacks V3](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/software-management-callbacks-v3.md)
* [SIM Securefor Io T Licenses](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/sim-securefor-io-t-licenses.md)
* [Account Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/account-subscriptions.md)
* [Performance Metrics](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/performance-metrics.md)
* [Diagnostics Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/diagnostics-subscriptions.md)
* [Diagnostics Observations](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/diagnostics-observations.md)
* [Diagnostics History](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/diagnostics-history.md)
* [Diagnostics Settings](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/diagnostics-settings.md)
* [Diagnostics Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/diagnostics-callbacks.md)
* [Diagnostics Factory Reset](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/diagnostics-factory-reset.md)
* [Cloud Connector Subscriptions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/cloud-connector-subscriptions.md)
* [Cloud Connector Devices](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/cloud-connector-devices.md)
* [Device Service Management](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/device-service-management.md)
* [Device Reports](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/device-reports.md)
* [Hyper Precise Location Callbacks](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/hyper-precise-location-callbacks.md)
* [Anomaly Settings](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/anomaly-settings.md)
* [Anomaly Triggers](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/anomaly-triggers.md)
* [MEC Sites](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/mec-sites.md)
* [Service Launch Profiles](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-launch-profiles.md)
* [Service Launch Requests](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-launch-requests.md)
* [Service Instances](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-instances.md)
* [Service Instance Operations](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-instance-operations.md)
* [Service Onboarding](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-onboarding.md)
* [Service Metadata](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-metadata.md)
* [CSP Profiles](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/csp-profiles.md)
* [Service Claims](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/service-claims.md)
* [OAuth Authorization](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/oauth-authorization.md)
* [Accounts](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/accounts.md)
* [SMS](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/sms.md)
* [Exclusions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/exclusions.md)
* [Billing](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/billing.md)
* [Targets](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/targets.md)
* [Repositories](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/controllers/repositories.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.0.0/doc/api-exception.md)

