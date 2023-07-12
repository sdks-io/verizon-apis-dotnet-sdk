# Device Monitoring

```csharp
DeviceMonitoringController deviceMonitoringController = client.DeviceMonitoringController;
```

## Class Name

`DeviceMonitoringController`

## Methods

* [Device Reachability](../../doc/controllers/device-monitoring.md#device-reachability)
* [Stop Device Reachability](../../doc/controllers/device-monitoring.md#stop-device-reachability)


# Device Reachability

Register for notification reports based on the request type.

```csharp
DeviceReachabilityAsync(
    Models.NotificationReportRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.NotificationReportRequest`](../../doc/models/notification-report-request.md) | Body, Required | Create Reachability Report Request |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
NotificationReportRequest body = new NotificationReportRequest
{
    AccountName = "0242072320-00001",
    RequestType = "REACHABLE_FOR_DATA",
    Devices = new List<Models.DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<Models.DeviceId1>
            {
                new DeviceId1
                {
                    Id = "89148000004292933820",
                    Kind = KindEnum.Iccid,
                },
                new DeviceId1
                {
                    Id = "89148000003164287919",
                    Kind = KindEnum.Iccid,
                },
            },
        },
    },
    MonitorExpirationTime = "2019-12-02T15:00:00-08:00Z",
};

try
{
    ApiResponse<RequestResponse> result = await deviceMonitoringController.DeviceReachabilityAsync(body);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Stop Device Reachability

Stop Device Reachability monitors.

```csharp
StopDeviceReachabilityAsync(
    string accountName,
    List<string> monitorIds)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | The numeric name of the account. |
| `monitorIds` | `List<string>` | Query, Required | The array contains the monitorIDs (UUID) for which the monitor is to be deleted. |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
string accountName = "0242123520-00001";
List<string> monitorIds = new List<string>
{
    "35596ca6-bab4-4333-a914-42b4fc2da54c",
    "35596ca6-bab4-4333-a914-42b4fc2da54b",
};

try
{
    ApiResponse<RequestResponse> result = await deviceMonitoringController.StopDeviceReachabilityAsync(accountName, monitorIds);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

