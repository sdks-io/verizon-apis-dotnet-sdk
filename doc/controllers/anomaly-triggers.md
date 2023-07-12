# Anomaly Triggers

```csharp
AnomalyTriggersController anomalyTriggersController = client.AnomalyTriggersController;
```

## Class Name

`AnomalyTriggersController`

## Methods

* [Create Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#create-anomaly-detection-trigger)
* [Update Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#update-anomaly-detection-trigger)
* [List Anomaly Detection Trigger Settings](../../doc/controllers/anomaly-triggers.md#list-anomaly-detection-trigger-settings)


# Create Anomaly Detection Trigger

Creates the trigger to identify an anomaly.

```csharp
CreateAnomalyDetectionTriggerAsync(
    List<Models.CreateTriggerRequestOptions> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<Models.CreateTriggerRequestOptions>`](../../doc/models/create-trigger-request-options.md) | Body, Required | Request to create an anomaly trigger. |

## Response Type

[`Task<ApiResponse<Models.AnomalyDetectionTrigger>>`](../../doc/models/anomaly-detection-trigger.md)

## Example Usage

```csharp
List<Models.CreateTriggerRequestOptions> body = new List<Models.CreateTriggerRequestOptions>
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
        Notification = new Notification
        {
            NotificationType = "DailySummary",
            Callback = true,
            EmailNotification = false,
            NotificationGroupName = "Anomaly Test API",
            NotificationFrequencyFactor = 3,
            NotificationFrequencyInterval = "Hourly",
            ExternalEmailRecipients = "placeholder@verizon.com",
            SmsNotification = true,
            SmsNumbers = new List<Models.SMSNumber>
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
    ApiResponse<AnomalyDetectionTrigger> result = await anomalyTriggersController.CreateAnomalyDetectionTriggerAsync(body);
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


# Update Anomaly Detection Trigger

Updates an existing trigger using the account name.

```csharp
UpdateAnomalyDetectionTriggerAsync(
    List<Models.UpdateTriggerRequestOptions> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<Models.UpdateTriggerRequestOptions>`](../../doc/models/update-trigger-request-options.md) | Body, Required | Request to update existing trigger. |

## Response Type

[`Task<ApiResponse<Models.IntelligenceSuccessResult>>`](../../doc/models/intelligence-success-result.md)

## Example Usage

```csharp
List<Models.UpdateTriggerRequestOptions> body = new List<Models.UpdateTriggerRequestOptions>
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
        Notification = new Notification
        {
            NotificationType = "DailySummary",
            Callback = true,
            EmailNotification = false,
            NotificationGroupName = "Anomaly Test API",
            NotificationFrequencyFactor = 3,
            NotificationFrequencyInterval = "Hourly",
            ExternalEmailRecipients = "placeholder@verizon.com",
            SmsNotification = true,
            SmsNumbers = new List<Models.SMSNumber>
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
    ApiResponse<IntelligenceSuccessResult> result = await anomalyTriggersController.UpdateAnomalyDetectionTriggerAsync(body);
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


# List Anomaly Detection Trigger Settings

Retrieves the values for a specific trigger ID.

```csharp
ListAnomalyDetectionTriggerSettingsAsync(
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
    ApiResponse<AnomalyTriggerResult> result = await anomalyTriggersController.ListAnomalyDetectionTriggerSettingsAsync(triggerId);
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

