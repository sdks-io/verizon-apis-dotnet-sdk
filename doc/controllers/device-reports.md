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

[`Task<ApiResponse<Models.AggregateSessionReport>>`](../../doc/models/aggregate-session-report.md)

## Example Usage

```csharp
AggregateSessionReportRequest body = new AggregateSessionReportRequest
{
    AccountNumber = "0844021539-00001",
    Imei = new List<string>
    {
        "709312034493372",
    },
    StartDate = "2022-12-09T22:01:06.217Z",
    EndDate = "2022-12-09T22:01:08.734Z",
    NoSessionFlag = "false",
};

try
{
    ApiResponse<AggregateSessionReport> result = await deviceReportsController.CalculateAggregatedReportSynchronousAsync(body);
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
  "txid": null,
  "usage": [
    {
      "imei": "709312034493372",
      "numberOfSessions": 1,
      "bytesTransferred": 2057
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

[`Task<ApiResponse<Models.AggregatedReportCallbackResult>>`](../../doc/models/aggregated-report-callback-result.md)

## Example Usage

```csharp
AggregateSessionReportRequest body = new AggregateSessionReportRequest
{
    AccountNumber = "0844021539-00001",
    Imei = new List<string>
    {
        "709312034493372",
    },
    StartDate = "2022-12-09T22:01:06.217Z",
    EndDate = "2022-12-09T22:01:08.734Z",
    NoSessionFlag = "false",
};

try
{
    ApiResponse<AggregatedReportCallbackResult> result = await deviceReportsController.CalculateAggregatedReportAsynchronousAsync(body);
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
  "txid": "60c07fff-470b-4d6d-afcc-75e6a7c238f6",
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

[`Task<ApiResponse<Models.SessionReport>>`](../../doc/models/session-report.md)

## Example Usage

```csharp
SessionReportRequest body = new SessionReportRequest
{
    AccountNumber = "0844021539-00001",
    Imei = "709312034493372",
    StartDate = "2022-12-09T22:01:06.217Z",
    EndDate = "2022-12-09T22:01:08.734Z",
};

try
{
    ApiResponse<SessionReport> result = await deviceReportsController.GetSessionsReportAsync(body);
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
  "id": "709312034493372",
  "txid": "60c07fff-470b-4d6d-afcc-75e6a7c238f6"
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

