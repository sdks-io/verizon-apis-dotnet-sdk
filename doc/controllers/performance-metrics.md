# Performance Metrics

```csharp
PerformanceMetricsController performanceMetricsController = client.PerformanceMetricsController;
```

## Class Name

`PerformanceMetricsController`


# Query MEC Performance Metrics

Query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.

```csharp
QueryMECPerformanceMetricsAsync(
    Models.QueryMECPerformanceMetricsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`QueryMECPerformanceMetricsRequest`](../../doc/models/query-mec-performance-metrics-request.md) | Body, Optional | - |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

[`Task<ApiResponse<Models.MECPerformanceMetrics>>`](../../doc/models/mec-performance-metrics.md)

## Example Usage

```csharp
QueryMECPerformanceMetricsRequest body = new QueryMECPerformanceMetricsRequest
{
    IMEI = "440246108109673",
    MSISDN = "10691876598",
};

try
{
    ApiResponse<MECPerformanceMetrics> result = await performanceMetricsController.QueryMECPerformanceMetricsAsync(body);
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
  "QueryStatus": "Success",
  "Start": "1/28/2021 12:00:00",
  "End": "1/28/2021 12:15:00",
  "QueryResult": [
    {
      "name": "NetworkAvailability",
      "data": [
        "100",
        "percent",
        "high"
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 401 | Unauthorized request. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 403 | Request forbidden. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 404 | Resource Not Found. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 405 | Method Not Allowed. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 503 | Service Unavailable. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |

