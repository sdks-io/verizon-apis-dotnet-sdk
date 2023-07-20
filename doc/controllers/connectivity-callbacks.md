# Connectivity Callbacks

```csharp
ConnectivityCallbacksController connectivityCallbacksController = client.ConnectivityCallbacksController;
```

## Class Name

`ConnectivityCallbacksController`

## Methods

* [Deregister Callback](../../doc/controllers/connectivity-callbacks.md#deregister-callback)
* [List Registered Callbacks](../../doc/controllers/connectivity-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/connectivity-callbacks.md#register-callback)


# Deregister Callback

Stops ThingSpace from sending callback messages for the specified account and service.

```csharp
DeregisterCallbackAsync(
    string aname,
    string sname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `sname` | `string` | Template, Required | Service name. |

## Response Type

[`Task<ApiResponse<Models.CallbackActionResult>>`](../../doc/models/callback-action-result.md)

## Example Usage

```csharp
string aname = "1223334444-00001";
string sname = "CarrierService";
try
{
    ApiResponse<CallbackActionResult> result = await connectivityCallbacksController.DeregisterCallbackAsync(aname, sname);
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
  "accountName": "1223334444-00001",
  "serviceName": "CarrierService"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Registered Callbacks

Returns the name and endpoint URL of the callback listening services registered for a given account.

```csharp
ListRegisteredCallbacksAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

[`Task<ApiResponse<List<Models.ConnectivityManagementCallback>>>`](../../doc/models/connectivity-management-callback.md)

## Example Usage

```csharp
string aname = "0252012345-00001";
try
{
    ApiResponse<List<ConnectivityManagementCallback>> result = await connectivityCallbacksController.ListRegisteredCallbacksAsync(aname);
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
    "accountName": "0252012345-00001",
    "serviceName": "CarrierService",
    "url": "http://10.120.102.147:50569/CallbackListener/Carrier.asmx"
  },
  {
    "accountName": "0252012345-00001",
    "password": "drowssap",
    "serviceName": "DeviceUsage",
    "url": "http://10.120.102.147:50569/CallbackListener/Usage.asmx",
    "username": "zaffod"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Register Callback

You are responsible for creating and running a listening process on your server at that URL.

```csharp
RegisterCallbackAsync(
    string aname,
    Models.RegisterCallbackRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `body` | [`Models.RegisterCallbackRequest`](../../doc/models/register-callback-request.md) | Body, Required | Request to register a callback. |

## Response Type

[`Task<ApiResponse<Models.CallbackActionResult>>`](../../doc/models/callback-action-result.md)

## Example Usage

```csharp
string aname = "TestAccount-2";
RegisterCallbackRequest body = new RegisterCallbackRequest
{
    Name = "CarrierService",
    Url = "http://10.120.102.183:50559/CallbackListener/CarrierServiceMessages.asmx",
};

try
{
    ApiResponse<CallbackActionResult> result = await connectivityCallbacksController.RegisterCallbackAsync(aname, body);
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
  "accountName": "122333444-00002",
  "serviceName": "CarrierService"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

