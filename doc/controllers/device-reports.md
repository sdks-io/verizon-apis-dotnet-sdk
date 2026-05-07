# Device Reports

```csharp
DeviceReportsController deviceReportsController = client.DeviceReportsController;
```

## Class Name

`DeviceReportsController`

## Methods

* [Calculate Aggregated Report Synchronous](../../doc/controllers/device-reports.md#calculate-aggregated-report-synchronous)
* [Calculate Aggregated Report Asynchronous](../../doc/controllers/device-reports.md#calculate-aggregated-report-asynchronous)
* [Get Sessions Report](../../doc/controllers/device-reports.md#get-sessions-report)


# Calculate Aggregated Report Synchronous

Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).

```csharp
CalculateAggregatedReportSynchronousAsync(
    Models.AggregateSessionReportRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AggregateSessionReportRequest`](../../doc/models/aggregate-session-report-request.md) | Body, Required | Aggregated report request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AggregateSessionReport](../../doc/models/aggregate-session-report.md).

## Example Usage

```csharp
AggregateSessionReportRequest body = new AggregateSessionReportRequest
{
    AccountNumber = "0000123456-00001",
    Imei = new List<string>
    {
        "15-digit IMEI",
    },
    StartDate = "2022-12-09T22:01:06.217Z",
    EndDate = "2022-12-09T22:01:08.734Z",
    DeviceGroup = "string",
    DataPlan = "string",
    NoSessionFlag = false,
};

try
{
    ApiResponse<AggregateSessionReport> result = await deviceReportsController.CalculateAggregatedReportSynchronousAsync(body);
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


# Calculate Aggregated Report Asynchronous

Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).

```csharp
CalculateAggregatedReportAsynchronousAsync(
    Models.AggregateSessionReportRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AggregateSessionReportRequest`](../../doc/models/aggregate-session-report-request.md) | Body, Required | Aggregated session report request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AggregatedReportCallbackResult](../../doc/models/aggregated-report-callback-result.md).

## Example Usage

```csharp
AggregateSessionReportRequest body = new AggregateSessionReportRequest
{
    AccountNumber = "0000123456-00001",
    Imei = new List<string>
    {
        "15-digit IMEI",
    },
    StartDate = "2022-12-09T22:01:06.217Z",
    EndDate = "2022-12-09T22:01:08.734Z",
    DeviceGroup = "string",
    DataPlan = "string",
    NoSessionFlag = false,
};

try
{
    ApiResponse<AggregatedReportCallbackResult> result = await deviceReportsController.CalculateAggregatedReportAsynchronousAsync(body);
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
  "txid": "60c07fff-eeee-ffff-gggg-75e6a7c238f6",
  "status": "QUEUED"
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


# Get Sessions Report

Detailed report of session duration and number of bytes transferred per day.

```csharp
GetSessionsReportAsync(
    Models.SessionReportRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SessionReportRequest`](../../doc/models/session-report-request.md) | Body, Required | Request for sessions report. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SessionReport](../../doc/models/session-report.md).

## Example Usage

```csharp
SessionReportRequest body = new SessionReportRequest
{
    AccountNumber = "0000123456-00001",
    Imei = "15-digit IMEI",
    StartDate = "2022-12-09T22:01:06.217Z",
    EndDate = "2022-12-09T22:01:08.734Z",
    DurationLow = 0,
    DurationHigh = 0,
};

try
{
    ApiResponse<SessionReport> result = await deviceReportsController.GetSessionsReportAsync(body);
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
  "id": "The 10-digit ID of the device",
  "txid": "60c07fff-eeee-ffff-gggg-75e6a7c238f6",
  "sessions": [
    {
      "startTime": "Start date of session. ISO 8601 format.",
      "endTime": "End date of session. ISO 8601 format.",
      "numBytes": 0
    }
  ]
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

