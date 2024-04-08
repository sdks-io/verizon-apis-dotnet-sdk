# Retrievethe Triggers

```csharp
RetrievetheTriggersController retrievetheTriggersController = client.RetrievetheTriggersController;
```

## Class Name

`RetrievetheTriggersController`

## Methods

* [Get All Available Triggers](../../doc/controllers/retrievethe-triggers.md#get-all-available-triggers)
* [Get All Triggers by Account Name](../../doc/controllers/retrievethe-triggers.md#get-all-triggers-by-account-name)
* [Get All Triggers by Trigger Category](../../doc/controllers/retrievethe-triggers.md#get-all-triggers-by-trigger-category)
* [Get Triggers by Id](../../doc/controllers/retrievethe-triggers.md#get-triggers-by-id)


# Get All Available Triggers

Retrieves all of the available triggers for pseudo-MDN.

```csharp
GetAllAvailableTriggersAsync()
```

## Response Type

[`Task<ApiResponse<Models.TriggerValueResponse>>`](../../doc/models/trigger-value-response.md)

## Example Usage

```csharp
try
{
    ApiResponse<TriggerValueResponse> result = await retrieveTheTriggersController.GetAllAvailableTriggersAsync();
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
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |


# Get All Triggers by Account Name

Retrieve the triggers associated with an account name.

```csharp
GetAllTriggersByAccountNameAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The account name |

## Response Type

[`Task<ApiResponse<Models.TriggerValueResponse>>`](../../doc/models/trigger-value-response.md)

## Example Usage

```csharp
string accountName = "0000123456-000001";
try
{
    ApiResponse<TriggerValueResponse> result = await retrieveTheTriggersController.GetAllTriggersByAccountNameAsync(accountName);
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
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |


# Get All Triggers by Trigger Category

Retrieves all of the triggers for the specified account associated with the PromoAlert category

```csharp
GetAllTriggersByTriggerCategoryAsync()
```

## Response Type

[`Task<ApiResponse<Models.TriggerValueResponse2>>`](../../doc/models/trigger-value-response-2.md)

## Example Usage

```csharp
try
{
    ApiResponse<TriggerValueResponse2> result = await retrieveTheTriggersController.GetAllTriggersByTriggerCategoryAsync();
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
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |


# Get Triggers by Id

Retrives a specific trigger by its ID.

```csharp
GetTriggersByIdAsync(
    string triggerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | The ID of a specific trigger |

## Response Type

[`Task<ApiResponse<Models.TriggerValueResponse2>>`](../../doc/models/trigger-value-response-2.md)

## Example Usage

```csharp
string triggerId = "2874DEC7-26CF-4797-9C6A-B5A2AC72D526";
try
{
    ApiResponse<TriggerValueResponse2> result = await retrieveTheTriggersController.GetTriggersByIdAsync(triggerId);
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
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |

