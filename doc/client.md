
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `VZM2MToken2` | `string` | The VZ-M2M session token from [Getting Started](/content/thingspace-portal/documentation/apis/connectivity-management/get-started.html) |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ThingspaceOauthCredentials` | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| `VzM2mSessionTokenCredentials` | [`VzM2mSessionTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
VerizonThingSpaceQualityOfServiceAPIEndpointsClient client = new VerizonThingSpaceQualityOfServiceAPIEndpointsClient.Builder()
    .ThingspaceOauthCredentials(
        new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .VzM2mSessionTokenCredentials(
        new VzM2mSessionTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .Build())
    .VZM2MToken2("VZ-M2M-Token")
    .Environment(VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Environment.Production)
    .Build();
```

## Verizon ThingSpace Quality of Service API endpointsClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| ThingSpaceQualityOfServiceAPIActionsController | Gets ThingSpaceQualityOfServiceAPIActionsController controller. |
| ExclusionsController | Gets ExclusionsController controller. |
| OAuthAuthorizationController | Gets OAuthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| VZM2MToken2 | The VZ-M2M session token from [Getting Started](/content/thingspace-portal/documentation/apis/connectivity-management/get-started.html) | `string` |
| Environment | Current API environment. | `Environment` |
| ThingspaceOauthCredentials | Gets the credentials to use with ThingspaceOauth. | [`IThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) |
| VzM2mSessionTokenCredentials | Gets the credentials to use with VzM2mSessionToken. | [`IVzM2mSessionTokenCredentials`](auth/custom-header-signature.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Thingspace)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Verizon ThingSpace Quality of Service API endpointsClient using the values provided for the builder. | `Builder` |

## Verizon ThingSpace Quality of Service API endpointsClient Builder Class

Class to build instances of Verizon ThingSpace Quality of Service API endpointsClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `VZM2MToken2(string vZM2MToken2)` | The VZ-M2M session token from [Getting Started](/content/thingspace-portal/documentation/apis/connectivity-management/get-started.html) | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `ThingspaceOauthCredentials(Action<ThingspaceOauthModel.Builder> action)` | Sets credentials for ThingspaceOauth. | `Builder` |
| `VzM2mSessionTokenCredentials(Action<VzM2mSessionTokenModel.Builder> action)` | Sets credentials for VzM2mSessionToken. | `Builder` |

