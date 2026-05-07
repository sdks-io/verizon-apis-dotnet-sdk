# Intelligence Service Controller

```csharp
IntelligenceServiceController intelligenceServiceController = client.IntelligenceServiceController;
```

## Class Name

`IntelligenceServiceController`

## Methods

* [Set Connection Planner](../../doc/controllers/intelligence-service-controller.md#set-connection-planner)
* [Status Connection Planner](../../doc/controllers/intelligence-service-controller.md#status-connection-planner)


# Set Connection Planner

Retrieves available device windows for Connection Planner.

```csharp
SetConnectionPlannerAsync(
    Models.GetDevicesWindowsRequestforplanner body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDevicesWindowsRequestforplanner`](../../doc/models/get-devices-windows-requestforplanner.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AsynchronousRequestResultforplanner](../../doc/models/asynchronous-request-resultforplanner.md).

## Example Usage

```csharp
GetDevicesWindowsRequestforplanner body = new GetDevicesWindowsRequestforplanner
{
    AccountNumber = "0000123456-00001",
    Filter = "All or Best or Worst",
    Devices = new List<DeviceListforplanner>
    {
        new DeviceListforplanner
        {
            DeviceIds = new List<DeviceIdforplanner>
            {
                new DeviceIdforplanner
                {
                    Kind = "imei",
                    Id = "15-digit IMEI value",
                },
            },
        },
    },
};

try
{
    ApiResponse<AsynchronousRequestResultforplanner> result = await intelligenceServiceController.SetConnectionPlannerAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestErrorResponseforplannerException)
    {
       // TODO: Handle RestErrorResponseforplannerException exception here
    }
    if (e is AuthRestErrorResponseforplannerException)
    {
       // TODO: Handle AuthRestErrorResponseforplannerException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d24cc6e4-eeee-ffff-gggg-0ffbb091c076"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 401 | Unauthorized | [`AuthRestErrorResponseforplannerException`](../../doc/models/auth-rest-error-responseforplanner-exception.md) |
| 403 | Forbidden | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 404 | Not Found / Does not exist | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 406 | Format / Request Unacceptable | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 429 | Too many requests | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| Default | Error response | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |


# Status Connection Planner

Retrieves the device status for the Connection Planner service.

```csharp
StatusConnectionPlannerAsync(
    Models.GetDeviceStatusesRequestforplanner body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceStatusesRequestforplanner`](../../doc/models/get-device-statuses-requestforplanner.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GetDeviceStatusesResponseforplanner](../../doc/models/get-device-statuses-responseforplanner.md).

## Example Usage

```csharp
GetDeviceStatusesRequestforplanner body = new GetDeviceStatusesRequestforplanner
{
    AccountNumber = "0000123456-00001",
    RequestId = "d24cc6e4-eeee-ffff-gggg-0ffbb091c076",
};

try
{
    ApiResponse<GetDeviceStatusesResponseforplanner> result = await intelligenceServiceController.StatusConnectionPlannerAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestErrorResponseforplannerException)
    {
       // TODO: Handle RestErrorResponseforplannerException exception here
    }
    if (e is AuthRestErrorResponseforplannerException)
    {
       // TODO: Handle AuthRestErrorResponseforplannerException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "accountNumber": "0000123456-00001",
  "requestId": "d24cc6e4-eeee-ffff-gggg-0ffbb091c076",
  "deviceStatusList": [
    {
      "deviceIds": [
        {
          "kind": "Imei",
          "id": "15-digit IMEI"
        }
      ],
      "status": "SUCCESS",
      "reason": "reason for the status"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 401 | Unauthorized | [`AuthRestErrorResponseforplannerException`](../../doc/models/auth-rest-error-responseforplanner-exception.md) |
| 403 | Forbidden | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 404 | Not Found / Does not exist | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 406 | Format / Request Unacceptable | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 429 | Too many requests | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| Default | Error response | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |

