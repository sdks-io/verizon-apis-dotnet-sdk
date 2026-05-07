# Hyper Precise Location Callbacks

```csharp
HyperPreciseLocationCallbacksController hyperPreciseLocationCallbacksController = client.HyperPreciseLocationCallbacksController;
```

## Class Name

`HyperPreciseLocationCallbacksController`

## Methods

* [List Registered Callbacks](../../doc/controllers/hyper-precise-location-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/hyper-precise-location-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/hyper-precise-location-callbacks.md#deregister-callback)


# List Registered Callbacks

Find registered callback listener for account by account number.

```csharp
ListRegisteredCallbacksAsync(
    string accountNumber)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountNumber` | `string` | Query, Required | The numeric ID of the account and must include leading zeroes. This value is indentical to `accountName`. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.CallbackCreated>](../../doc/models/callback-created.md).

## Example Usage

```csharp
string accountNumber = "0000123456-00001";
try
{
    ApiResponse<List<CallbackCreated>> result = await hyperPreciseLocationCallbacksController.ListRegisteredCallbacksAsync(accountNumber);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is HyperPreciseLocationResultException)
    {
       // TODO: Handle HyperPreciseLocationResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
[
  {
    "accountName": "0000123456-00001",
    "name": "BullseyeReporting",
    "url": "https://tsustgtests.mocklab.io/notifications/bullseye"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |


# Register Callback

Registers a URL at which an account receives asynchronous responses and other messages from a ThingSpace Platform callback service. The messages are REST messages. You are responsible for creating and running a listening process on your server at that URL to receive and parse the messages.

```csharp
RegisterCallbackAsync(
    string accountNumber,
    Models.HyperPreciseLocationCallback body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountNumber` | `string` | Query, Required | A unique identifier for an account. |
| `body` | [`HyperPreciseLocationCallback`](../../doc/models/hyper-precise-location-callback.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CallbackRegistered](../../doc/models/callback-registered.md).

## Example Usage

```csharp
string accountNumber = "0000123456-00001";
HyperPreciseLocationCallback body = new HyperPreciseLocationCallback
{
    Name = "BullseyeReporting",
    Url = "https://tsustgtests.mocklab.io/notifications/bullseye",
};

try
{
    ApiResponse<CallbackRegistered> result = await hyperPreciseLocationCallbacksController.RegisterCallbackAsync(
        accountNumber,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is HyperPreciseLocationResultException)
    {
       // TODO: Handle HyperPreciseLocationResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "name": "BullseyeReporting"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |


# Deregister Callback

Stops ThingSpace from sending callback messages for the specified account and listener name.

```csharp
DeregisterCallbackAsync(
    string accountNumber,
    string service)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountNumber` | `string` | Query, Required | The numeric ID of the account and must include leading zeroes. This value is indentical to `accountName`. |
| `service` | `string` | Query, Required | The name of the callback service that will be deleted. |

## Response Type

`Task`

## Example Usage

```csharp
string accountNumber = "0000123456-00001";
string service = "BullseyeReporting";
try
{
    await hyperPreciseLocationCallbacksController.DeregisterCallbackAsync(
        accountNumber,
        service
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is HyperPreciseLocationResultException)
    {
       // TODO: Handle HyperPreciseLocationResultException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |

