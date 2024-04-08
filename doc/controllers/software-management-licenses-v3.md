# Software Management Licenses V3

```csharp
SoftwareManagementLicensesV3Controller softwareManagementLicensesV3Controller = client.SoftwareManagementLicensesV3Controller;
```

## Class Name

`SoftwareManagementLicensesV3Controller`

## Methods

* [Get Account Licenses Status](../../doc/controllers/software-management-licenses-v3.md#get-account-licenses-status)
* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v3.md#assign-licenses-to-devices)
* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v3.md#remove-licenses-from-devices)


# Get Account Licenses Status

The endpoint allows user to list license usage.

```csharp
GetAccountLicensesStatusAsync(
    string acc,
    string lastSeenDeviceId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `string` | Query, Optional | Last seen device identifier. |

## Response Type

[`Task<ApiResponse<Models.V3LicenseSummary>>`](../../doc/models/v3-license-summary.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
string lastSeenDeviceId = "0";
try
{
    ApiResponse<V3LicenseSummary> result = await softwareManagementLicensesV3Controller.GetAccountLicensesStatusAsync(
        acc,
        lastSeenDeviceId
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
  "accountName": "0000123456-00001",
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": "1000",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Assign Licenses to Devices

This endpoint allows user to assign licenses to a list of devices.

```csharp
AssignLicensesToDevicesAsync(
    string acc,
    Models.V3LicenseIMEI body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`V3LicenseIMEI`](../../doc/models/v3-license-imei.md) | Body, Required | License assignment. |

## Response Type

[`Task<ApiResponse<Models.V3LicenseAssignedRemovedResult>>`](../../doc/models/v3-license-assigned-removed-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
V3LicenseIMEI body = new V3LicenseIMEI
{
    DeviceList = new List<string>
    {
        "15-digit IMEI",
        "15-digit IMEI",
    },
};

try
{
    ApiResponse<V3LicenseAssignedRemovedResult> result = await softwareManagementLicensesV3Controller.AssignLicensesToDevicesAsync(
        acc,
        body
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
  "accountName": "0000123456-00001",
  "licUsedCount": 2,
  "licCount": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradePending",
      "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
      "updatedTime": "2022-08-05T21:05:27.129Z",
      "recentAttemptTime": "2022-10-05T21:05:01.19Z",
      "nextAttemptTime": "2022-10-06T18:35:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Remove Licenses From Devices

This endpoint allows user to remove licenses from a list of devices.

```csharp
RemoveLicensesFromDevicesAsync(
    string acc,
    Models.V3LicenseIMEI body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`V3LicenseIMEI`](../../doc/models/v3-license-imei.md) | Body, Required | License removal. |

## Response Type

[`Task<ApiResponse<Models.V3LicenseAssignedRemovedResult>>`](../../doc/models/v3-license-assigned-removed-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
V3LicenseIMEI body = new V3LicenseIMEI
{
    DeviceList = new List<string>
    {
        "15-digit IMEI",
        "15-digit IMEI",
        "15-digit IMEI",
    },
};

try
{
    ApiResponse<V3LicenseAssignedRemovedResult> result = await softwareManagementLicensesV3Controller.RemoveLicensesFromDevicesAsync(
        acc,
        body
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
  "accountName": "0000123456-00001",
  "licUsedCount": 998,
  "licCount": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradePending",
      "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
      "updatedTime": "2022-08-05T21:05:27.129Z",
      "recentAttemptTime": "2022-10-05T21:05:01.19Z",
      "nextAttemptTime": "2022-10-06T18:35:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

