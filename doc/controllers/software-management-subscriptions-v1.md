# Software Management Subscriptions V1

```csharp
SoftwareManagementSubscriptionsV1Controller softwareManagementSubscriptionsV1Controller = client.SoftwareManagementSubscriptionsV1Controller;
```

## Class Name

`SoftwareManagementSubscriptionsV1Controller`

## Methods

* [Get Account Subscription Status](../../doc/controllers/software-management-subscriptions-v1.md#get-account-subscription-status)
* [Get Account License Status](../../doc/controllers/software-management-subscriptions-v1.md#get-account-license-status)


# Get Account Subscription Status

This subscriptions endpoint retrieves an account's current Software Management Service subscription status.

```csharp
GetAccountSubscriptionStatusAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |

## Response Type

[`Task<ApiResponse<Models.V1AccountSubscription>>`](../../doc/models/v1-account-subscription.md)

## Example Usage

```csharp
string account = "0402196254-00001";
try
{
    ApiResponse<V1AccountSubscription> result = await softwareManagementSubscriptionsV1Controller.GetAccountSubscriptionStatusAsync(account);
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
  "accountName": "0402196254-00001",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 9000,
  "licenseUsedCount": 1000,
  "updateTime": "2018-03-02T16:03:06.000Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Get Account License Status

Returns information about an account's Software Management Services licenses and a list of licensed devices.

```csharp
GetAccountLicenseStatusAsync(
    string account,
    string startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `string` | Template, Required | The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc. |

## Response Type

[`Task<ApiResponse<Models.AccountLicenseInfo>>`](../../doc/models/account-license-info.md)

## Example Usage

```csharp
string account = "0402196254-00001";
string startIndex = "0";
try
{
    ApiResponse<AccountLicenseInfo> result = await softwareManagementSubscriptionsV1Controller.GetAccountLicenseStatusAsync(
        account,
        startIndex
    );
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
  "accountName": "0402196254-00001",
  "totalLicenses": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": 1000,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000473475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000347475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990007303425535",
      "assignmentTime": "2016-11-29T15:03:36.000Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |

