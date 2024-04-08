# Device Location Callbacks

```csharp
DeviceLocationCallbacksController deviceLocationCallbacksController = client.DeviceLocationCallbacksController;
```

## Class Name

`DeviceLocationCallbacksController`

## Methods

* [List Registered Callbacks](../../doc/controllers/device-location-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/device-location-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/device-location-callbacks.md#deregister-callback)


# List Registered Callbacks

Returns a list of all registered callback URLs for the account.

```csharp
ListRegisteredCallbacksAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account number. |

## Response Type

[`Task<ApiResponse<List<Models.DeviceLocationCallback>>>`](../../doc/models/device-location-callback.md)

## Example Usage

```csharp
string account = "0252012345-00001";
try
{
    ApiResponse<List<DeviceLocationCallback>> result = await deviceLocationCallbacksController.ListRegisteredCallbacksAsync(account);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
[
  {
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/Location.asmx"
  },
  {
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/DeviceLocation.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Register Callback

Provide a URL to receive messages from a ThingSpace callback service.

```csharp
RegisterCallbackAsync(
    string account,
    Models.DeviceLocationCallback body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account number. |
| `body` | [`DeviceLocationCallback`](../../doc/models/device-location-callback.md) | Body, Required | Request to register a callback. |

## Response Type

[`Task<ApiResponse<Models.CallbackRegistrationResult>>`](../../doc/models/callback-registration-result.md)

## Example Usage

```csharp
string account = "0252012345-00001";
DeviceLocationCallback body = new DeviceLocationCallback
{
    Name = CallbackServiceNameEnum.Location,
    Url = "http://10.120.102.183:50559/CallbackListener/LocationServiceMessages.asmx",
};

try
{
    ApiResponse<CallbackRegistrationResult> result = await deviceLocationCallbacksController.RegisterCallbackAsync(
        account,
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
  "account": "0212312345-00001",
  "name": "Location"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Deregister Callback

Deregister a URL to stop receiving callback messages.

```csharp
DeregisterCallbackAsync(
    string account,
    Models.CallbackServiceNameEnum service)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account number. |
| `service` | [`CallbackServiceNameEnum`](../../doc/models/callback-service-name-enum.md) | Template, Required | Callback service name. |

## Response Type

[`Task<ApiResponse<Models.DeviceLocationSuccessResult>>`](../../doc/models/device-location-success-result.md)

## Example Usage

```csharp
string account = "0252012345-00001";
CallbackServiceNameEnum service = CallbackServiceNameEnum.Location;
try
{
    ApiResponse<DeviceLocationSuccessResult> result = await deviceLocationCallbacksController.DeregisterCallbackAsync(
        account,
        service
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

