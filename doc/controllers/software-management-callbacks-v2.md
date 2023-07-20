# Software Management Callbacks V2

```csharp
SoftwareManagementCallbacksV2Controller softwareManagementCallbacksV2Controller = client.SoftwareManagementCallbacksV2Controller;
```

## Class Name

`SoftwareManagementCallbacksV2Controller`

## Methods

* [Register Callback](../../doc/controllers/software-management-callbacks-v2.md#register-callback)
* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v2.md#list-registered-callbacks)
* [Update Callback](../../doc/controllers/software-management-callbacks-v2.md#update-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v2.md#deregister-callback)


# Register Callback

This endpoint allows user to create the HTTPS callback address.

```csharp
RegisterCallbackAsync(
    string account,
    Models.FotaV2CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.FotaV2CallbackRegistrationRequest`](../../doc/models/fota-v2-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

[`Task<ApiResponse<Models.FotaV2CallbackRegistrationResult>>`](../../doc/models/fota-v2-callback-registration-result.md)

## Example Usage

```csharp
string account = "0000123456-00001";
FotaV2CallbackRegistrationRequest body = new FotaV2CallbackRegistrationRequest
{
    Url = "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
};

try
{
    ApiResponse<FotaV2CallbackRegistrationResult> result = await softwareManagementCallbacksV2Controller.RegisterCallbackAsync(account, body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "url": "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# List Registered Callbacks

This endpoint allows user to get the registered callback information.

```csharp
ListRegisteredCallbacksAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<Models.CallbackSummary>>`](../../doc/models/callback-summary.md)

## Example Usage

```csharp
string account = "0000123456-00001";
try
{
    ApiResponse<CallbackSummary> result = await softwareManagementCallbacksV2Controller.ListRegisteredCallbacksAsync(account);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "url": "http://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Callback

This endpoint allows user to update the HTTPS callback address.

```csharp
UpdateCallbackAsync(
    string account,
    Models.FotaV2CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.FotaV2CallbackRegistrationRequest`](../../doc/models/fota-v2-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

[`Task<ApiResponse<Models.FotaV2CallbackRegistrationResult>>`](../../doc/models/fota-v2-callback-registration-result.md)

## Example Usage

```csharp
string account = "0000123456-00001";
FotaV2CallbackRegistrationRequest body = new FotaV2CallbackRegistrationRequest
{
    Url = "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx",
};

try
{
    ApiResponse<FotaV2CallbackRegistrationResult> result = await softwareManagementCallbacksV2Controller.UpdateCallbackAsync(account, body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "url": "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Deregister Callback

This endpoint allows user to delete a previously registered callback URL.

```csharp
DeregisterCallbackAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<Models.FotaV2SuccessResult>>`](../../doc/models/fota-v2-success-result.md)

## Example Usage

```csharp
string account = "0000123456-00001";
try
{
    ApiResponse<FotaV2SuccessResult> result = await softwareManagementCallbacksV2Controller.DeregisterCallbackAsync(account);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

