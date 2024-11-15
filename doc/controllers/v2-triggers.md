# V2 Triggers

Helps to create and manage promo alert triggers

```csharp
MV2TriggersController mV2TriggersController = client.MV2TriggersController;
```

## Class Name

`MV2TriggersController`

## Methods

* [Create Trigger](../../doc/controllers/v2-triggers.md#create-trigger)
* [Update Trigger](../../doc/controllers/v2-triggers.md#update-trigger)


# Create Trigger

This creates an individual change plan for account group share.

```csharp
CreateTriggerAsync(
    Models.CreateTriggerV2Request body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateTriggerV2Request`](../../doc/models/create-trigger-v2-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.TriggerV2Response>>`](../../doc/models/trigger-v2-response.md)

## Example Usage

```csharp
CreateTriggerV2Request body = new CreateTriggerV2Request
{
};

try
{
    ApiResponse<TriggerV2Response> result = await mV2TriggersController.CreateTriggerAsync(body);
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
| 400 | Error Response | [`RulesEngineRestErrorResponseException`](../../doc/models/rules-engine-rest-error-response-exception.md) |


# Update Trigger

This updates an individual change plan for account group share.

```csharp
UpdateTriggerAsync(
    string vZM2mToken,
    Models.UpdateTriggerV2Request body,
    string xRequestID = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vZM2mToken` | `string` | Header, Required | M2M-MC Session Token |
| `body` | [`UpdateTriggerV2Request`](../../doc/models/update-trigger-v2-request.md) | Body, Required | - |
| `xRequestID` | `string` | Header, Optional | Transaction Id |

## Response Type

[`Task<ApiResponse<Models.TriggerV2Response>>`](../../doc/models/trigger-v2-response.md)

## Example Usage

```csharp
string vZM2mToken = "VZ-M2M-Token2";
UpdateTriggerV2Request body = new UpdateTriggerV2Request
{
};

try
{
    ApiResponse<TriggerV2Response> result = await mV2TriggersController.UpdateTriggerAsync(
        vZM2mToken,
        body
    );
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
| 400 | Error Response | [`RulesEngineRestErrorResponseException`](../../doc/models/rules-engine-rest-error-response-exception.md) |

