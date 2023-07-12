# Exclusions

Exclude devices from location services.

```csharp
ExclusionsController exclusionsController = client.ExclusionsController;
```

## Class Name

`ExclusionsController`

## Methods

* [Exclude Devices](../../doc/controllers/exclusions.md#exclude-devices)
* [Remove Devices From Exclusion List](../../doc/controllers/exclusions.md#remove-devices-from-exclusion-list)
* [List Excluded Devices](../../doc/controllers/exclusions.md#list-excluded-devices)


# Exclude Devices

This consents endpoint sets a new exclusion list.

```csharp
ExcludeDevicesAsync(
    Models.ConsentRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ConsentRequest`](../../doc/models/consent-request.md) | Body, Required | Request to update account consent exclusion list. |

## Response Type

[`Task<ApiResponse<Models.DeviceLocationSuccessResult>>`](../../doc/models/device-location-success-result.md)

## Example Usage

```csharp
ConsentRequest body = new ConsentRequest
{
    AccountName = "1234567890-00001",
    AllDevice = false,
    Type = "replace",
    Exclusion = new List<string>
    {
        "980003420535573",
        "375535024300089",
        "A100003861E585",
    },
};

try
{
    ApiResponse<DeviceLocationSuccessResult> result = await exclusionsController.ExcludeDevicesAsync(body);
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
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Remove Devices From Exclusion List

Removes devices from the exclusion list so that they can be located with Device Location Services requests.

```csharp
RemoveDevicesFromExclusionListAsync(
    string accountName,
    string deviceList)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | The numeric name of the account. |
| `deviceList` | `string` | Query, Required | A list of the device IDs to remove from the exclusion list. |

## Response Type

[`Task<ApiResponse<Models.DeviceLocationSuccessResult>>`](../../doc/models/device-location-success-result.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
string deviceList = "IMEI";
try
{
    ApiResponse<DeviceLocationSuccessResult> result = await exclusionsController.RemoveDevicesFromExclusionListAsync(accountName, deviceList);
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Excluded Devices

This consents endpoint retrieves a list of excluded devices in an account.

```csharp
ListExcludedDevicesAsync(
    string account,
    string startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `string` | Template, Required | Zero-based number of the first record to return. |

## Response Type

[`Task<ApiResponse<Models.DevicesConsentResult>>`](../../doc/models/devices-consent-result.md)

## Example Usage

```csharp
string account = "0252012345-00001";
string startIndex = "0";
try
{
    ApiResponse<DevicesConsentResult> result = await exclusionsController.ListExcludedDevicesAsync(account, startIndex);
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
  "allDevice": false,
  "hasMoreData": false,
  "totalCount": 4,
  "updateTime": "2018-05-18 19:20:50.076 +0000 UTC",
  "exclusion": [
    "990003420535375",
    "420535399000375",
    "A100003861E585",
    "205353759900034"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

