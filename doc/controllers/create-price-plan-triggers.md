# Create Price Plan Triggers

```csharp
CreatePricePlanTriggersController createPricePlanTriggersController = client.CreatePricePlanTriggersController;
```

## Class Name

`CreatePricePlanTriggersController`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```csharp
CreateTriggerRulesAsync(
    CreateTriggerRulesBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateTriggerRulesBody`](../../doc/models/containers/create-trigger-rules-body.md) | Body, Required | This is a container for any-of cases. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```csharp
CreateTriggerRulesBody body = CreateTriggerRulesBody.FromAccountLevelObject(
    new AccountLevelObject
    {
    }
);

try
{
    ApiResponse<TriggerResponse> result = await createPricePlanTriggersController.CreateTriggerRulesAsync(body);
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

