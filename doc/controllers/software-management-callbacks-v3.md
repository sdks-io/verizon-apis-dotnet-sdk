# Software Management Callbacks V3

```csharp
SoftwareManagementCallbacksV3Controller softwareManagementCallbacksV3Controller = client.SoftwareManagementCallbacksV3Controller;
```

## Class Name

`SoftwareManagementCallbacksV3Controller`

## Methods

* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v3.md#list-registered-callbacks)
* [Update Callback](../../doc/controllers/software-management-callbacks-v3.md#update-callback)
* [Register Callback](../../doc/controllers/software-management-callbacks-v3.md#register-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v3.md#deregister-callback)


# List Registered Callbacks

This endpoint allows user to get the registered callback information.

```csharp
ListRegisteredCallbacksAsync(
    string acc)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<Models.FotaV3CallbackSummary>>`](../../doc/models/fota-v3-callback-summary.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
try
{
    ApiResponse<FotaV3CallbackSummary> result = await softwareManagementCallbacksV3Controller.ListRegisteredCallbacksAsync(acc);
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Update Callback

This endpoint allows the user to update the HTTPS callback address.

```csharp
UpdateCallbackAsync(
    string acc,
    Models.FotaV3CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`FotaV3CallbackRegistrationRequest`](../../doc/models/fota-v3-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

[`Task<ApiResponse<Models.FotaV3CallbackRegistrationResult>>`](../../doc/models/fota-v3-callback-registration-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
FotaV3CallbackRegistrationRequest body = new FotaV3CallbackRegistrationRequest
{
    Url = "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx",
};

try
{
    ApiResponse<FotaV3CallbackRegistrationResult> result = await softwareManagementCallbacksV3Controller.UpdateCallbackAsync(
        acc,
        body
    );
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Register Callback

This endpoint allows the user to create the HTTPS callback address.

```csharp
RegisterCallbackAsync(
    string acc,
    Models.FotaV3CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`FotaV3CallbackRegistrationRequest`](../../doc/models/fota-v3-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

[`Task<ApiResponse<Models.FotaV3CallbackRegistrationResult>>`](../../doc/models/fota-v3-callback-registration-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
FotaV3CallbackRegistrationRequest body = new FotaV3CallbackRegistrationRequest
{
    Url = "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx",
};

try
{
    ApiResponse<FotaV3CallbackRegistrationResult> result = await softwareManagementCallbacksV3Controller.RegisterCallbackAsync(
        acc,
        body
    );
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Deregister Callback

This endpoint allows user to delete a previously registered callback URL.

```csharp
DeregisterCallbackAsync(
    string acc)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<Models.FotaV3SuccessResult>>`](../../doc/models/fota-v3-success-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
try
{
    ApiResponse<FotaV3SuccessResult> result = await softwareManagementCallbacksV3Controller.DeregisterCallbackAsync(acc);
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

