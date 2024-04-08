# Update Triggers

```csharp
UpdateTriggersController updateTriggersController = client.UpdateTriggersController;
```

## Class Name

`UpdateTriggersController`


# Update All Available Triggers

Updates the promotional triggers for pseudo-MDN.

```csharp
UpdateAllAvailableTriggersAsync(
    Models.RequestTrigger body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`RequestTrigger`](../../doc/models/request-trigger.md) | Body, Optional | Update the triggers |

## Response Type

[`Task<ApiResponse<Models.Success>>`](../../doc/models/success.md)

## Example Usage

```csharp
RequestTrigger body = new RequestTrigger
{
    TriggerId = "2874DEC7-26CF-4797-9C6A-B5A2AC72D526",
    TriggerName = "PromoAlerts_0000000000-00001_23456789",
    AccountName = "0000123456-000001",
    OrganizationName = "Optional group name",
    TriggerCategory = "PromoAlerts",
};

try
{
    ApiResponse<Success> result = await updateTriggersController.UpdateAllAvailableTriggersAsync(body);
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
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |

