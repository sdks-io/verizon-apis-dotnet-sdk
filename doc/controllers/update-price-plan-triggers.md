# Update Price Plan Triggers

```csharp
UpdatePricePlanTriggersController updatePricePlanTriggersController = client.UpdatePricePlanTriggersController;
```

## Class Name

`UpdatePricePlanTriggersController`


# Update Trigger Rules

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```csharp
UpdateTriggerRulesAsync(
    UpdateTriggerRulesBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UpdateTriggerRulesBody`](../../doc/models/containers/update-trigger-rules-body.md) | Body, Required | This is a container for any-of cases. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```csharp
UpdateTriggerRulesBody body = UpdateTriggerRulesBody.FromAccountLevelUpdateTriggerRequest(
    new AccountLevelUpdateTriggerRequest
    {
        TriggerId = "b9cc1da6-ffff-eeee-gggg-7eba8859ab5e",
        TriggerName = "name of the trigger",
        EcpdId = "Verizon profile ID",
        TriggerCategory = TriggerCategoryEnum.AccountUsage,
        DataTrigger = new DataTrigger1
        {
            ConditionType = ConditionTypeEnum.Aging,
        },
        Notification = new Notificationarray
        {
            NotificationType = "PerEvent",
            Callback = true,
            EmailNotification = false,
            NotificationGroupName = "NotificationGroupName",
            NotificationFrequencyFactor = 3,
            NotificationFrequencyInterval = "Daily",
            ExternalEmailRecipients = "ExternalEmailRecipients",
            SmsNotification = true,
            SmsNumbers = new List<NotificationarraySmsNumbers>
            {
                NotificationarraySmsNumbers.FromCellphonenumber(
                    new Cellphonenumber
                    {
                        Number = "10-digit mobile number",
                        Carrier = "mobile service provider",
                    }
                ),
                NotificationarraySmsNumbers.FromCellphonenumber(
                    new Cellphonenumber
                    {
                        Number = "10-digit mobile number",
                        Carrier = "mobile service provider",
                    }
                ),
            },
            Reminder = true,
            Severity = "Notice",
        },
        Active = ActiveEnum.True,
    }
);

try
{
    ApiResponse<TriggerResponse> result = await updatePricePlanTriggersController.UpdateTriggerRulesAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RuleRestErrorResponseException)
    {
       // TODO: Handle RuleRestErrorResponseException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`RuleRestErrorResponseException`](../../doc/models/rule-rest-error-response-exception.md) |

