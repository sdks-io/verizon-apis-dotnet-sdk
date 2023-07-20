# Anomaly Settings

```csharp
AnomalySettingsController anomalySettingsController = client.AnomalySettingsController;
```

## Class Name

`AnomalySettingsController`

## Methods

* [Activate Anomaly Detection](../../doc/controllers/anomaly-settings.md#activate-anomaly-detection)
* [Reset Anomaly Detection Parameters](../../doc/controllers/anomaly-settings.md#reset-anomaly-detection-parameters)
* [List Anomaly Detection Settings](../../doc/controllers/anomaly-settings.md#list-anomaly-detection-settings)


# Activate Anomaly Detection

Uses the subscribed account ID to activate anomaly detection and set threshold values.

```csharp
ActivateAnomalyDetectionAsync(
    Models.AnomalyDetectionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.AnomalyDetectionRequest`](../../doc/models/anomaly-detection-request.md) | Body, Required | Request to activate anomaly detection. |

## Response Type

[`Task<ApiResponse<Models.IntelligenceSuccessResult>>`](../../doc/models/intelligence-success-result.md)

## Example Usage

```csharp
AnomalyDetectionRequest body = new AnomalyDetectionRequest
{
    AccountName = "0000123456-00001",
    RequestType = "anomaly",
    SensitivityParameter = new SensitivityParameters
    {
        AbnormalMaxValue = 1.1,
        EnableAbnormal = true,
        EnableVeryAbnormal = true,
        VeryAbnormalMaxValue = 0.55,
    },
};

try
{
    ApiResponse<IntelligenceSuccessResult> result = await anomalySettingsController.ActivateAnomalyDetectionAsync(body);
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
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Reset Anomaly Detection Parameters

Resets the thresholds to zero.

```csharp
ResetAnomalyDetectionParametersAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The name of the subscribed account. |

## Response Type

[`Task<ApiResponse<Models.IntelligenceSuccessResult>>`](../../doc/models/intelligence-success-result.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
try
{
    ApiResponse<IntelligenceSuccessResult> result = await anomalySettingsController.ResetAnomalyDetectionParametersAsync(accountName);
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
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# List Anomaly Detection Settings

Retrieves the current anomaly detection settings for an account.

```csharp
ListAnomalyDetectionSettingsAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The name of the subscribed account. |

## Response Type

[`Task<ApiResponse<Models.AnomalyDetectionSettings>>`](../../doc/models/anomaly-detection-settings.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
try
{
    ApiResponse<AnomalyDetectionSettings> result = await anomalySettingsController.ListAnomalyDetectionSettingsAsync(accountName);
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
  "accountName": "Success",
  "sensitivityParameter": {
    "abnormalMaxValue": 1.1,
    "enableAbnormal": true,
    "enableVeryAbnormal": true,
    "veryAbnormalMaxValue": 0.55
  },
  "status": "Active"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |

