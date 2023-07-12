# Devices Location Subscriptions

```csharp
DevicesLocationSubscriptionsController devicesLocationSubscriptionsController = client.DevicesLocationSubscriptionsController;
```

## Class Name

`DevicesLocationSubscriptionsController`

## Methods

* [Get Location Service Subscription Status](../../doc/controllers/devices-location-subscriptions.md#get-location-service-subscription-status)
* [Get Location Service Usage](../../doc/controllers/devices-location-subscriptions.md#get-location-service-usage)


# Get Location Service Subscription Status

This subscriptions endpoint retrieves an account's current location subscription status.

```csharp
GetLocationServiceSubscriptionStatusAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |

## Response Type

[`Task<ApiResponse<Models.DeviceLocationSubscription>>`](../../doc/models/device-location-subscription.md)

## Example Usage

```csharp
string account = "0000123456-00001";
try
{
    ApiResponse<DeviceLocationSubscription> result = await devicesLocationSubscriptionsController.GetLocationServiceSubscriptionStatusAsync(account);
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
  "accountName": "2024009649-00001",
  "locType": "TS-LOC-COARSE-CellID-5K",
  "maxAllowance": "5000",
  "purchaseTime": "2017-05-10 06:25:25.171 +0000 UTC"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Get Location Service Usage

This endpoint allows user to search for billable usage for accounts based on the provided date range.

```csharp
GetLocationServiceUsageAsync(
    Models.BillUsageRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.BillUsageRequest`](../../doc/models/bill-usage-request.md) | Body, Required | Request to obtain billable usage for accounts. |

## Response Type

`Task<ApiResponse<object>>`

## Example Usage

```csharp
BillUsageRequest body = new BillUsageRequest
{
    AccountName = "1234567890-00001",
    StartDate = "04-01-2018",
    EndDate = "04-30-2018",
    UsageForAllAccounts = true,
};

try
{
    ApiResponse<object> result = await devicesLocationSubscriptionsController.GetLocationServiceUsageAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response

```
{
  "accountName": "1223334444-00001",
  "usageForAllAcounts": false,
  "skuName": "TS-LOC-COARSE-CellID-Aggr",
  "transactionsAllowed": "5000",
  "totalTransactionCount": "350",
  "PrimaryAccount": {
    "accountName": "1223334444-00001",
    "transactionsCount": "125"
  },
  "ManagedAccounts": []
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

