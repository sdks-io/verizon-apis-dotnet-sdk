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

```csharp
DeviceReachabilityAsync(
    Models.NotificationReportRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`NotificationReportRequest`](../../doc/models/notification-report-request.md) | Body, Required | Create Reachability Report Request |

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
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "89148000004292933820",
                    Kind = "iccid",
                },
                new DeviceId
                {
                    Id = "89148000003164287919",
                    Kind = "iccid",
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

```csharp
StopDeviceReachabilityAsync(
    Models.StopMonitorRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`StopMonitorRequest`](../../doc/models/stop-monitor-request.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
StopMonitorRequest body = new StopMonitorRequest
{
    AccountName = "0242123520-00001",
    MonitorIds = new List<string>
    {
        "35596ca6-bab4-4333-a914-42b4fc2da54c",
    },
};

try
{
    ApiResponse<RequestResponse> result = await deviceMonitoringController.StopDeviceReachabilityAsync(body);
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

