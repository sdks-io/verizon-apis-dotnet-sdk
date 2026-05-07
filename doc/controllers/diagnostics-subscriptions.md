# Diagnostics Subscriptions

```csharp
DiagnosticsSubscriptionsController diagnosticsSubscriptionsController = client.DiagnosticsSubscriptionsController;
```

## Class Name

`DiagnosticsSubscriptionsController`


# Get Diagnostics Subscription

This endpoint retrieves a diagnostics subscription by account.

```csharp
GetDiagnosticsSubscriptionAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DiagnosticsSubscription](../../doc/models/diagnostics-subscription.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
try
{
    ApiResponse<DiagnosticsSubscription> result = await diagnosticsSubscriptionsController.GetDiagnosticsSubscriptionAsync(accountName);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is DeviceDiagnosticsResultException)
    {
       // TODO: Handle DeviceDiagnosticsResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "TestQAAccount",
  "skuName": "TS-BUNDLE-KTO-DIAGNOSTIC-MRC",
  "totalAllowed": 100,
  "totalUsed": 50,
  "createdOn": "2019-08-29T00:47:59.240Z",
  "lastUpdated": "2019-08-29T00:47:59.240Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

