# Software Management Subscriptions V3

```csharp
SoftwareManagementSubscriptionsV3Controller softwareManagementSubscriptionsV3Controller = client.SoftwareManagementSubscriptionsV3Controller;
```

## Class Name

`SoftwareManagementSubscriptionsV3Controller`


# Get Account Subscription Status

This endpoint retrieves a FOTA subscription by account.

```csharp
GetAccountSubscriptionStatusAsync(
    string acc)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<Models.FotaV3Subscription>>`](../../doc/models/fota-v3-subscription.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
try
{
    ApiResponse<FotaV3Subscription> result = await softwareManagementSubscriptionsV3Controller.GetAccountSubscriptionStatusAsync(acc);
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
  "accountName": "0000123456-000001",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 500,
  "licenseUsedCount": 400,
  "updateTime": "2020-09-17T21:11:32.170Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

