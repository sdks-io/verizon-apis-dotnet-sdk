# Software Management Subscriptions V2

```csharp
SoftwareManagementSubscriptionsV2Controller softwareManagementSubscriptionsV2Controller = client.SoftwareManagementSubscriptionsV2Controller;
```

## Class Name

`SoftwareManagementSubscriptionsV2Controller`


# Get Account Subscription Status

This endpoint retrieves a FOTA subscription by account.

```csharp
GetAccountSubscriptionStatusAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<Models.FotaV2Subscription>>`](../../doc/models/fota-v2-subscription.md)

## Example Usage

```csharp
string account = "0000123456-00001";
try
{
    ApiResponse<FotaV2Subscription> result = await softwareManagementSubscriptionsV2Controller.GetAccountSubscriptionStatusAsync(account);
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
  "accountName": "00000000000-123345",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 500,
  "licenseUsedCount": 400,
  "updateTime": "2020-09-17T21:11:32.170Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

