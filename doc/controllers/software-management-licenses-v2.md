# Software Management Licenses V2

```csharp
SoftwareManagementLicensesV2Controller softwareManagementLicensesV2Controller = client.SoftwareManagementLicensesV2Controller;
```

## Class Name

`SoftwareManagementLicensesV2Controller`

## Methods

* [Get Account License Status](../../doc/controllers/software-management-licenses-v2.md#get-account-license-status)
* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v2.md#assign-licenses-to-devices)
* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v2.md#remove-licenses-from-devices)
* [List Licenses to Remove](../../doc/controllers/software-management-licenses-v2.md#list-licenses-to-remove)
* [Create List of Licenses to Remove](../../doc/controllers/software-management-licenses-v2.md#create-list-of-licenses-to-remove)
* [Delete List of Licenses to Remove](../../doc/controllers/software-management-licenses-v2.md#delete-list-of-licenses-to-remove)


# Get Account License Status

The endpoint allows user to list license usage.

```csharp
GetAccountLicenseStatusAsync(
    string account,
    string lastSeenDeviceId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `string` | Query, Optional | Last seen device identifier. |

## Response Type

[`Task<ApiResponse<Models.V2LicenseSummary>>`](../../doc/models/v2-license-summary.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string lastSeenDeviceId = "15-digit IMEI";
try
{
    ApiResponse<V2LicenseSummary> result = await softwareManagementLicensesV2Controller.GetAccountLicenseStatusAsync(account, lastSeenDeviceId);
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
  "totalLicense": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": "1000",
  "maxPageSize": 10,
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
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Assign Licenses to Devices

**This endpoint is deprecated.**

This endpoint allows user to assign licenses to a list of devices.

```csharp
AssignLicensesToDevicesAsync(
    string account,
    Models.V2LicenseIMEI body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.V2LicenseIMEI`](../../doc/models/v2-license-imei.md) | Body, Required | License assignment. |

## Response Type

[`Task<ApiResponse<Models.V2LicensesAssignedRemovedResult>>`](../../doc/models/v2-licenses-assigned-removed-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
V2LicenseIMEI body = new V2LicenseIMEI
{
    DeviceList = new List<string>
    {
        "990003425730524",
        "990000473475967",
    },
};

try
{
    ApiResponse<V2LicensesAssignedRemovedResult> result = await softwareManagementLicensesV2Controller.AssignLicensesToDevicesAsync(account, body);
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
  "accountName": "0242078689-00001",
  "licTotalCount": 1000,
  "licUsedCount": 502,
  "deviceList": [
    {
      "deviceId": "990003425730524",
      "status": "Success",
      "resultReason": "Success"
    },
    {
      "deviceId": "990000473475967",
      "status": "Failure",
      "resultReason": "Device does not exist."
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Remove Licenses From Devices

**This endpoint is deprecated.**

This endpoint allows user to remove licenses from a list of devices.

```csharp
RemoveLicensesFromDevicesAsync(
    string account,
    Models.V2LicenseIMEI body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.V2LicenseIMEI`](../../doc/models/v2-license-imei.md) | Body, Required | License removal. |

## Response Type

[`Task<ApiResponse<Models.V2LicensesAssignedRemovedResult>>`](../../doc/models/v2-licenses-assigned-removed-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
V2LicenseIMEI body = new V2LicenseIMEI
{
    DeviceList = new List<string>
    {
        "990003425730535",
        "990000473475989",
        "900000000000999",
    },
};

try
{
    ApiResponse<V2LicensesAssignedRemovedResult> result = await softwareManagementLicensesV2Controller.RemoveLicensesFromDevicesAsync(account, body);
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
  "accountName": "0242078689-00001",
  "licTotalCount": 1000,
  "licUsedCount": 998,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "status": "Success",
      "resultReason": "Success"
    },
    {
      "deviceId": "990000473475989",
      "status": "Success",
      "resultReason": "Success"
    },
    {
      "deviceId": "900000000000999",
      "status": "Failure",
      "resultReason": "No license attached to device"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# List Licenses to Remove

**This endpoint is deprecated.**

The license cancel endpoint allows user to list registered license cancellation candidate devices.

```csharp
ListLicensesToRemoveAsync(
    string account,
    string startIndex = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `startIndex` | `string` | Query, Optional | Start index to retrieve. |

## Response Type

[`Task<ApiResponse<Models.V2ListOfLicensesToRemove>>`](../../doc/models/v2-list-of-licenses-to-remove.md)

## Example Usage

```csharp
string account = "0242078689-00001";
try
{
    ApiResponse<V2ListOfLicensesToRemove> result = await softwareManagementLicensesV2Controller.ListLicensesToRemoveAsync(account, null);
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
  "count": 6,
  "hasMoreData": false,
  "updateTime": "2018-03-22 00:06:00.069 +0000 UTC",
  "deviceList": [
    "990003425730535",
    "990000473475989",
    "990005733420535",
    "990000347475989",
    "990007303425535",
    "990007590473489"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Create List of Licenses to Remove

**This endpoint is deprecated.**

The license cancel endpoint allows user to create a list of license cancellation candidate devices.

```csharp
CreateListOfLicensesToRemoveAsync(
    string account,
    Models.V2ListOfLicensesToRemoveRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.V2ListOfLicensesToRemoveRequest`](../../doc/models/v2-list-of-licenses-to-remove-request.md) | Body, Required | List of licensess to remove. |

## Response Type

[`Task<ApiResponse<Models.V2ListOfLicensesToRemoveResult>>`](../../doc/models/v2-list-of-licenses-to-remove-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
V2ListOfLicensesToRemoveRequest body = new V2ListOfLicensesToRemoveRequest
{
    DeviceList = new List<string>
    {
        "990003425730535",
        "990000473475989",
    },
    Type = "append",
    Count = 2,
};

try
{
    ApiResponse<V2ListOfLicensesToRemoveResult> result = await softwareManagementLicensesV2Controller.CreateListOfLicensesToRemoveAsync(account, body);
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
  "count": 2,
  "deviceList": [
    "990003425730535",
    "990000473475989"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Delete List of Licenses to Remove

**This endpoint is deprecated.**

This endpoint allows user to delete a created cancel candidate device list.

```csharp
DeleteListOfLicensesToRemoveAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<Models.FotaV2SuccessResult>>`](../../doc/models/fota-v2-success-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
try
{
    ApiResponse<FotaV2SuccessResult> result = await softwareManagementLicensesV2Controller.DeleteListOfLicensesToRemoveAsync(account);
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
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

