
# Getting Started with Verizon ThingSpace Quality of Service API endpoints

## Introduction

These are the endpoints to subscribe to and end the subscription for Verizon's ThingSpace Quality of Service API. These endpoints use Service Capability Exposure Function or SCEF, and rely on callbacks for asynchronous requests. **Note:** This example is in YAML and will need to be converted to JSON to use as a spec file.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package VerizonApisSDK --version 1.6.0
```

You can also view the package at:
https://www.nuget.org/packages/VerizonApisSDK/1.6.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `VZM2MToken2` | `string` | The VZ-M2M session token from [Getting Started](/content/thingspace-portal/documentation/apis/connectivity-management/get-started.html) |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ThingspaceOauthCredentials` | [`ThingspaceOauthCredentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| `VzM2mSessionTokenCredentials` | [`VzM2mSessionTokenCredentials`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

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

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** |
| Staging | - |

## Authorization

This API uses the following authentication schemes.

* [`thingspace_oauth (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/auth/oauth-2-client-credentials-grant.md)
* [`vz-m2m-session_token (Custom Header Signature)`](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/auth/custom-header-signature.md)

## List of APIs

* [Thing Space Qualityof Service API Actions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/controllers/thing-space-qualityof-service-api-actions.md)
* [Exclusions](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/controllers/exclusions.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/verizon-apis-dotnet-sdk/tree/1.6.0/doc/api-exception.md)

