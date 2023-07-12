# Account Requests

```csharp
AccountRequestsController accountRequestsController = client.AccountRequestsController;
```

## Class Name

`AccountRequestsController`


# Get Current Asynchronous Request Status

Returns the current status of an asynchronous request that was made for a single device.

```csharp
GetCurrentAsynchronousRequestStatusAsync(
    string aname,
    string requestId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `requestId` | `string` | Template, Required | UUID from synchronous response. |

## Response Type

[`Task<ApiResponse<Models.AsynchronousRequestResult>>`](../../doc/models/asynchronous-request-result.md)

## Example Usage

```csharp
string aname = "0252012345-00001";
string requestId = "86c83330-4bf5-4235-9c4e-a83f93aeae4c";
try
{
    ApiResponse<AsynchronousRequestResult> result = await accountRequestsController.GetCurrentAsynchronousRequestStatusAsync(aname, requestId);
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
  "requestId": "86c83330-4bf5-4235-9c4e-a83f93aeae4c",
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

