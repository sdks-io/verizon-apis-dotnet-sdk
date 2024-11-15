# Anomaly Triggers V2

```csharp
AnomalyTriggersV2Controller anomalyTriggersV2Controller = client.AnomalyTriggersV2Controller;
```

## Class Name

`AnomalyTriggersV2Controller`

## Methods

* [Create Anomaly Detection Trigger V2](../../doc/controllers/anomaly-triggers-v2.md#create-anomaly-detection-trigger-v2)
* [Update Anomaly Detection Trigger V2](../../doc/controllers/anomaly-triggers-v2.md#update-anomaly-detection-trigger-v2)
* [List Anomaly Detection Trigger Settings V2](../../doc/controllers/anomaly-triggers-v2.md#list-anomaly-detection-trigger-settings-v2)


# Create Anomaly Detection Trigger V2

Creates the trigger to identify an anomaly.

```csharp
CreateAnomalyDetectionTriggerV2Async(
    List<Models.CreateTriggerRequestOptions> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<CreateTriggerRequestOptions>`](../../doc/models/create-trigger-request-options.md) | Body, Required | Request to create an anomaly trigger. |

## Response Type

[`Task<ApiResponse<Models.AnomalyDetectionTrigger>>`](../../doc/models/anomaly-detection-trigger.md)

## Example Usage

```csharp
List<CreateTriggerRequestOptions> body = new List<CreateTriggerRequestOptions>
{
    new CreateTriggerRequestOptions
    {
        Name = "Anomaly Daily Usage REST Test-Patch 1",
        TriggerCategory = "UsageAnomaly",
        AccountName = "0000123456-00001",
        AnomalyTriggerRequest = new AnomalyTriggerRequest
        {
            AccountNames = "0000123456-00001",
            IncludeAbnormal = true,
            IncludeVeryAbnormal = true,
            IncludeUnderExpectedUsage = true,
            IncludeOverExpectedUsage = true,
        },
        Notification = new TriggerNotification
        {
            NotificationType = "DailySummary",
            Callback = true,
            EmailNotification = false,
            NotificationGroupName = "Anomaly Test API",
            NotificationFrequencyFactor = 3,
            NotificationFrequencyInterval = "Hourly",
            ExternalEmailRecipients = "placeholder@verizon.com",
            SmsNotification = true,
            SmsNumbers = new List<SMSNumber>
            {
                new SMSNumber
                {
                    Carrier = "US Cellular",
                    Number = "9299280711",
                },
            },
            Reminder = true,
            Severity = "Critical",
        },
    },
};

try
{
    ApiResponse<AnomalyDetectionTrigger> result = await anomalyTriggersV2Controller.CreateAnomalyDetectionTriggerV2Async(body);
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
  "triggerId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Update Anomaly Detection Trigger V2

Updates an existing trigger using the account name.

```csharp
UpdateAnomalyDetectionTriggerV2Async(
    List<Models.UpdateTriggerRequestOptions> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<UpdateTriggerRequestOptions>`](../../doc/models/update-trigger-request-options.md) | Body, Required | Request to update existing trigger. |

## Response Type

[`Task<ApiResponse<Models.IntelligenceSuccessResult>>`](../../doc/models/intelligence-success-result.md)

## Example Usage

```csharp
List<UpdateTriggerRequestOptions> body = new List<UpdateTriggerRequestOptions>
{
    new UpdateTriggerRequestOptions
    {
        TriggerId = "595f5c44-c31c-4552-8670-020a1545a84d",
        TriggerName = "Anomaly Daily Usage REST Test-Patch Update 4",
        TriggerCategory = "UsageAnomaly",
        AccountName = "0000123456-00001",
        AnomalyTriggerRequest = new AnomalyTriggerRequest
        {
            AccountNames = "0000123456-00001",
            IncludeAbnormal = true,
            IncludeVeryAbnormal = true,
            IncludeUnderExpectedUsage = false,
            IncludeOverExpectedUsage = true,
        },
        Notification = new TriggerNotification
        {
            NotificationType = "DailySummary",
            Callback = true,
            EmailNotification = false,
            NotificationGroupName = "Anomaly Test API",
            NotificationFrequencyFactor = 3,
            NotificationFrequencyInterval = "Hourly",
            ExternalEmailRecipients = "placeholder@verizon.com",
            SmsNotification = true,
            SmsNumbers = new List<SMSNumber>
            {
                new SMSNumber
                {
                    Carrier = "US Cellular",
                    Number = "9299280711",
                },
            },
            Reminder = true,
            Severity = "Critical",
        },
    },
};

try
{
    ApiResponse<IntelligenceSuccessResult> result = await anomalyTriggersV2Controller.UpdateAnomalyDetectionTriggerV2Async(body);
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


# List Anomaly Detection Trigger Settings V2

Retrieves the values for a specific trigger ID.

```csharp
ListAnomalyDetectionTriggerSettingsV2Async(
    string triggerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | The trigger ID of a specific trigger. |

## Response Type

[`Task<ApiResponse<Models.AnomalyTriggerResult>>`](../../doc/models/anomaly-trigger-result.md)

## Example Usage

```csharp
string triggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035";
try
{
    ApiResponse<AnomalyTriggerResult> result = await anomalyTriggersV2Controller.ListAnomalyDetectionTriggerSettingsV2Async(triggerId);
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
  "triggers": [
    {
      "triggerId": "BE1B5958-3E11-41DB-9ABD-B1B7618C0035",
      "triggerName": "Anomaly Daily Usage REST Test-1",
      "organizationName": "AnamolyDetectionRTRTest",
      "triggerCategory": "UsageAnomaly",
      "triggerAttributes": [
        {
          "key": "DataPercentage50",
          "value": false
        }
      ],
      "createdAt": "2021-10-21T23:57:03.397.0000Z",
      "modifiedAt": "2021-10-21T23:57:03.397.0000Z",
      "notification": {
        "notificationType": "DailySummary",
        "callback": true,
        "emailNotification": true,
        "notificationGroupName": "Anomaly Test API",
        "notificationFrequencyFactor": -2147483648,
        "externalEmailRecipients": "placeholder@verizon.com",
        "smsNotification": true,
        "smsNumbers": [
          {
            "carrier": "US Cellular",
            "number": "9299280711"
          }
        ],
        "reminder": false,
        "severity": "Critical"
      }
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |

