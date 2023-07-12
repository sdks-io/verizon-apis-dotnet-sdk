# Software Management Reports V2

```csharp
SoftwareManagementReportsV2Controller softwareManagementReportsV2Controller = client.SoftwareManagementReportsV2Controller;
```

## Class Name

`SoftwareManagementReportsV2Controller`

## Methods

* [List Available Software](../../doc/controllers/software-management-reports-v2.md#list-available-software)
* [List Account Devices](../../doc/controllers/software-management-reports-v2.md#list-account-devices)
* [Get Device Firmware Upgrade History](../../doc/controllers/software-management-reports-v2.md#get-device-firmware-upgrade-history)
* [Get Campaign History by Status](../../doc/controllers/software-management-reports-v2.md#get-campaign-history-by-status)
* [Get Campaign Device Status](../../doc/controllers/software-management-reports-v2.md#get-campaign-device-status)


# List Available Software

This endpoint allows user to list a certain type of software of an account.

```csharp
ListAvailableSoftwareAsync(
    string account,
    string distributionType = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `distributionType` | `string` | Query, Optional | Filter distributionType to get specific type of software. Value is LWM2M, OMD-DM or HTTP. |

## Response Type

[`Task<ApiResponse<List<Models.SoftwarePackage>>>`](../../doc/models/software-package.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string distributionType = "HTTP";
try
{
    ApiResponse<List<SoftwarePackage>> result = await softwareManagementReportsV2Controller.ListAvailableSoftwareAsync(account, distributionType);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
[
  {
    "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
    "launchDate": "2020-08-31",
    "releaseNote": "",
    "model": "Model-A",
    "make": "Verizon",
    "distributionType": "HTTP",
    "devicePlatformId": "IoT"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# List Account Devices

The device endpoint gets devices information of an account.

```csharp
ListAccountDevicesAsync(
    string account,
    string lastSeenDeviceId = null,
    string distributionType = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `string` | Query, Optional | Last seen device identifier. |
| `distributionType` | `string` | Query, Optional | Filter distributionType to get specific type of devices. Values is LWM2M, OMD-DM or HTTP. |

## Response Type

[`Task<ApiResponse<Models.V2AccountDeviceList>>`](../../doc/models/v2-account-device-list.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string lastSeenDeviceId = "15-digit IMEI";
string distributionType = "HTTP";
try
{
    ApiResponse<V2AccountDeviceList> result = await softwareManagementReportsV2Controller.ListAccountDevicesAsync(account, lastSeenDeviceId, distributionType);
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
  "hasMoreData": true,
  "lastSeenDeviceId": "15-digit IMEI",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z"
        }
      ],
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z"
        }
      ],
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z"
        }
      ],
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Device Firmware Upgrade History

The endpoint allows user to get software upgrade history of a device based on device IMEI.

```csharp
GetDeviceFirmwareUpgradeHistoryAsync(
    string account,
    string deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

[`Task<ApiResponse<List<Models.DeviceSoftwareUpgrade>>>`](../../doc/models/device-software-upgrade.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string deviceId = "990013907835573";
try
{
    ApiResponse<List<DeviceSoftwareUpgrade>> result = await softwareManagementReportsV2Controller.GetDeviceFirmwareUpgradeHistoryAsync(account, deviceId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
[
  {
    "deviceId": "990013907835573",
    "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
    "accountName": "0402196254-00001",
    "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
    "startDate": "2018-03-05",
    "status": "UpgradeSuccess",
    "reason": "success"
  },
  {
    "deviceId": "990013907835573",
    "id": "50d5d639-aaca-3ca7-7713-958ac83b84ae",
    "accountName": "0402196254-00001",
    "softwareName": "VerizonSoftwareVersion-01",
    "startDate": "2018-02-20",
    "status": "UpgradeSuccess",
    "reason": "success"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Campaign History by Status

The report endpoint allows user to get campaign history of an account for specified status.

```csharp
GetCampaignHistoryByStatusAsync(
    string account,
    string campaignStatus,
    string lastSeenCampaignId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignStatus` | `string` | Query, Required | Status of the campaign. |
| `lastSeenCampaignId` | `string` | Query, Optional | Last seen campaign Id. |

## Response Type

[`Task<ApiResponse<Models.V2CampaignHistory>>`](../../doc/models/v2-campaign-history.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string campaignStatus = "campaignStatus6";
string lastSeenCampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
try
{
    ApiResponse<V2CampaignHistory> result = await softwareManagementReportsV2Controller.GetCampaignHistoryByStatusAsync(account, campaignStatus, lastSeenCampaignId);
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
  "hasMoreData": true,
  "lastSeenCampaignId": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "campaignList": [
    {
      "accountName": "0402196254-00001",
      "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
      "campaignName": "FOTA_Verizon_Upgrade",
      "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
      "distributionType": "HTTP",
      "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
      "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
      "make": "Verizon",
      "model": "Model-A",
      "startDate": "2020-08-21",
      "endDate": "2020-08-22",
      "downloadAfterDate": "2020-08-21",
      "downloadTimeWindowList": [
        {
          "startTime": 20,
          "endTime": 21
        }
      ],
      "installAfterDate": "2020-08-21",
      "installTimeWindowList": [
        {
          "startTime": 22,
          "endTime": 23
        }
      ],
      "status": "CampaignEnded"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Campaign Device Status

The report endpoint allows user to get the full list of device of a campaign.

```csharp
GetCampaignDeviceStatusAsync(
    string account,
    string campaignId,
    string lastSeenDeviceId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Campaign identifier. |
| `lastSeenDeviceId` | `string` | Query, Optional | Last seen device identifier. |

## Response Type

[`Task<ApiResponse<Models.V2CampaignDevice>>`](../../doc/models/v2-campaign-device.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
string lastSeenDeviceId = "15-digit IMEI";
try
{
    ApiResponse<V2CampaignDevice> result = await softwareManagementReportsV2Controller.GetCampaignDeviceStatusAsync(account, campaignId, lastSeenDeviceId);
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
  "totalDevice": 1148,
  "hasMoreData": true,
  "lastSeenDeviceId": "15-digit IMEI",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded"
    },
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded"
    },
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

