# Server Logging

```csharp
ServerLoggingController serverLoggingController = client.ServerLoggingController;
```

## Class Name

`ServerLoggingController`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```csharp
GetDeviceCheckInHistoryAsync(
    string account,
    string deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

[`Task<ApiResponse<List<Models.CheckInHistoryItem>>>`](../../doc/models/check-in-history-item.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string deviceId = "990013907835573";
try
{
    ApiResponse<List<CheckInHistoryItem>> result = await serverLoggingController.GetDeviceCheckInHistoryAsync(
        account,
        deviceId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

