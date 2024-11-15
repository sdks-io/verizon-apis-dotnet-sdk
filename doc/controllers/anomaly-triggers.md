# Anomaly Triggers

```csharp
AnomalyTriggersController anomalyTriggersController = client.AnomalyTriggersController;
```

## Class Name

`AnomalyTriggersController`

## Methods

* [List Anomaly Detection Triggers](../../doc/controllers/anomaly-triggers.md#list-anomaly-detection-triggers)
* [Update Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#update-anomaly-detection-trigger)
* [Create Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#create-anomaly-detection-trigger)
* [List Anomaly Detection Trigger Settings](../../doc/controllers/anomaly-triggers.md#list-anomaly-detection-trigger-settings)
* [Delete Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#delete-anomaly-detection-trigger)


# List Anomaly Detection Triggers

This corresponds to the M2M-MC SOAP interface, `GetTriggers`.

```csharp
ListAnomalyDetectionTriggersAsync()
```

## Response Type

[`Task<ApiResponse<List<Models.GetTriggerResponseList>>>`](../../doc/models/get-trigger-response-list.md)

## Example Usage

```csharp
try
{
    ApiResponse<List<GetTriggerResponseList>> result = await anomalyTriggersController.ListAnomalyDetectionTriggersAsync();
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
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Update Anomaly Detection Trigger

This corresponds to the M2M-MC SOAP interface, `UpdateTriggerRequest`.

```csharp
UpdateAnomalyDetectionTriggerAsync(
    Models.UpdateTriggerRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UpdateTriggerRequest`](../../doc/models/update-trigger-request.md) | Body, Required | Update Trigger Request |

## Response Type

[`Task<ApiResponse<Models.AnomalyDetectionTrigger>>`](../../doc/models/anomaly-detection-trigger.md)

## Example Usage

```csharp
UpdateTriggerRequest body = new UpdateTriggerRequest
{
    AnomalyTriggerRequest = new AnomalyTriggerRequest
    {
        AccountNames = "0000123456-00001",
        IncludeAbnormal = true,
        IncludeVeryAbnormal = true,
        IncludeUnderExpectedUsage = true,
        IncludeOverExpectedUsage = true,
    },
};

try
{
    ApiResponse<AnomalyDetectionTrigger> result = await anomalyTriggersController.UpdateAnomalyDetectionTriggerAsync(body);
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
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Create Anomaly Detection Trigger

This corresponds to the M2M-MC SOAP interface, `CreateTrigger`.

```csharp
CreateAnomalyDetectionTriggerAsync(
    Models.CreateTriggerRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateTriggerRequest`](../../doc/models/create-trigger-request.md) | Body, Required | Create Trigger Request |

## Response Type

[`Task<ApiResponse<Models.AnomalyDetectionTrigger>>`](../../doc/models/anomaly-detection-trigger.md)

## Example Usage

```csharp
CreateTriggerRequest body = new CreateTriggerRequest
{
    AnomalyTriggerRequest = new AnomalyTriggerRequest
    {
        AccountNames = "0000123456-00001",
        IncludeAbnormal = true,
        IncludeVeryAbnormal = true,
        IncludeUnderExpectedUsage = true,
        IncludeOverExpectedUsage = true,
    },
};

try
{
    ApiResponse<AnomalyDetectionTrigger> result = await anomalyTriggersController.CreateAnomalyDetectionTriggerAsync(body);
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
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# List Anomaly Detection Trigger Settings

This corresponds to the M2M-MC SOAP interface, `GetTriggers`.

```csharp
ListAnomalyDetectionTriggerSettingsAsync(
    string triggerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | trigger ID |

## Response Type

[`Task<ApiResponse<List<Models.GetTriggerResponseList>>>`](../../doc/models/get-trigger-response-list.md)

## Example Usage

```csharp
string triggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035";
try
{
    ApiResponse<List<GetTriggerResponseList>> result = await anomalyTriggersController.ListAnomalyDetectionTriggerSettingsAsync(triggerId);
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
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Delete Anomaly Detection Trigger

Deletes a specific trigger ID

```csharp
DeleteAnomalyDetectionTriggerAsync(
    string triggerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | The trigger ID to be deleted |

## Response Type

[`Task<ApiResponse<Models.AnomalyDetectionTrigger>>`](../../doc/models/anomaly-detection-trigger.md)

## Example Usage

```csharp
string triggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035";
try
{
    ApiResponse<AnomalyDetectionTrigger> result = await anomalyTriggersController.DeleteAnomalyDetectionTriggerAsync(triggerId);
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
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |

