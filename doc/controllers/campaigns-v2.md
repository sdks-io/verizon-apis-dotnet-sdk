# Campaigns V2

```csharp
CampaignsV2Controller campaignsV2Controller = client.CampaignsV2Controller;
```

## Class Name

`CampaignsV2Controller`

## Methods

* [Get Campaign Information](../../doc/controllers/campaigns-v2.md#get-campaign-information)
* [Update Campaign Dates](../../doc/controllers/campaigns-v2.md#update-campaign-dates)
* [Schedule File Upgrade](../../doc/controllers/campaigns-v2.md#schedule-file-upgrade)
* [Update Campaign Firmware Devices](../../doc/controllers/campaigns-v2.md#update-campaign-firmware-devices)
* [Schedule Campaign Firmware Upgrade](../../doc/controllers/campaigns-v2.md#schedule-campaign-firmware-upgrade)
* [Cancel Campaign](../../doc/controllers/campaigns-v2.md#cancel-campaign)
* [Schedule SW Upgrade Http Devices](../../doc/controllers/campaigns-v2.md#schedule-sw-upgrade-http-devices)


# Get Campaign Information

This endpoint allows user to get information of a software upgrade.

```csharp
GetCampaignInformationAsync(
    string account,
    string campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Software upgrade identifier. |

## Response Type

[`Task<ApiResponse<Models.CampaignSoftware>>`](../../doc/models/campaign-software.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
try
{
    ApiResponse<CampaignSoftware> result = await campaignsV2Controller.GetCampaignInformationAsync(account, campaignId);
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
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
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Campaign Dates

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

```csharp
UpdateCampaignDatesAsync(
    string account,
    string campaignId,
    Models.V2ChangeCampaignDatesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Software upgrade information. |
| `body` | [`Models.V2ChangeCampaignDatesRequest`](../../doc/models/v2-change-campaign-dates-request.md) | Body, Required | New dates and time windows. |

## Response Type

[`Task<ApiResponse<Models.CampaignSoftware>>`](../../doc/models/campaign-software.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
V2ChangeCampaignDatesRequest body = new V2ChangeCampaignDatesRequest
{
    StartDate = DateTime.Parse("2020-08-21"),
    EndDate = DateTime.Parse("2020-08-22"),
    DownloadAfterDate = DateTime.Parse("2020-08-21"),
    DownloadTimeWindowList = new List<Models.V2TimeWindow>
    {
        new V2TimeWindow
        {
            StartTime = 3,
            EndTime = 4,
        },
    },
    InstallAfterDate = DateTime.Parse("2020-08-21"),
    InstallTimeWindowList = new List<Models.V2TimeWindow>
    {
        new V2TimeWindow
        {
            StartTime = 5,
            EndTime = 6,
        },
    },
};

try
{
    ApiResponse<CampaignSoftware> result = await campaignsV2Controller.UpdateCampaignDatesAsync(account, campaignId, body);
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": 3,
      "endTime": 4
    },
    {
      "startTime": 5,
      "endTime": 6
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": 5,
      "endTime": 6
    },
    {
      "startTime": 6,
      "endTime": 7
    }
  ],
  "status": "RequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Schedule File Upgrade

You can upload configuration files and schedule them in a campaign to devices.

```csharp
ScheduleFileUpgradeAsync(
    string acc,
    Models.UploadAndScheduleFileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.UploadAndScheduleFileRequest`](../../doc/models/upload-and-schedule-file-request.md) | Body, Required | Device logging information. |

## Response Type

[`Task<ApiResponse<Models.UploadAndScheduleFileResponse>>`](../../doc/models/upload-and-schedule-file-response.md)

## Example Usage

```csharp
string acc = "0402196254-00001";
UploadAndScheduleFileRequest body = new UploadAndScheduleFileRequest
{
    CampaignName = "FOTA_Verizon_Upgrade",
    FileName = "configfile-Verizon_VZW1_hello-world.txt",
    FileVersion = "1.0",
    DistributionType = "HTTP",
    StartDate = "2021-02-08",
    EndDate = "2021-02-08",
    DownloadAfterDate = "2021-02-08",
};

try
{
    ApiResponse<UploadAndScheduleFileResponse> result = await campaignsV2Controller.ScheduleFileUpgradeAsync(acc, body);
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
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Campaign Firmware Devices

This endpoint allows user to Add or Remove devices to an existing software upgrade.

```csharp
UpdateCampaignFirmwareDevicesAsync(
    string account,
    string campaignId,
    Models.V2AddOrRemoveDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Software upgrade information. |
| `body` | [`Models.V2AddOrRemoveDeviceRequest`](../../doc/models/v2-add-or-remove-device-request.md) | Body, Required | Request to add or remove device to existing software upgrade information. |

## Response Type

[`Task<ApiResponse<Models.V2AddOrRemoveDeviceResult>>`](../../doc/models/v2-add-or-remove-device-result.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
V2AddOrRemoveDeviceRequest body = new V2AddOrRemoveDeviceRequest
{
    Type = "remove",
    DeviceList = new List<string>
    {
        "990013907884259",
        "990013907835573",
        "990013907833575",
    },
};

try
{
    ApiResponse<V2AddOrRemoveDeviceResult> result = await campaignsV2Controller.UpdateCampaignFirmwareDevicesAsync(account, campaignId, body);
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
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Schedule Campaign Firmware Upgrade

This endpoint allows user to schedule a software upgrade.

```csharp
ScheduleCampaignFirmwareUpgradeAsync(
    string account,
    Models.CampaignSoftwareUpgrade body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.CampaignSoftwareUpgrade`](../../doc/models/campaign-software-upgrade.md) | Body, Required | Software upgrade information. |

## Response Type

[`Task<ApiResponse<Models.CampaignSoftware>>`](../../doc/models/campaign-software.md)

## Example Usage

```csharp
string account = "0000123456-00001";
CampaignSoftwareUpgrade body = new CampaignSoftwareUpgrade
{
    SoftwareName = "FOTA_Verizon_Model-A_02To03_HF",
    SoftwareFrom = "FOTA_Verizon_Model-A_00To01_HF",
    SoftwareTo = "FOTA_Verizon_Model-A_02To03_HF",
    DistributionType = "HTTP",
    StartDate = DateTime.Parse("2020-08-21"),
    EndDate = DateTime.Parse("2020-08-22"),
    DeviceList = new List<string>
    {
        "990013907835573",
        "990013907884259",
    },
    CampaignName = "FOTA_Verizon_Upgrade",
    DownloadAfterDate = DateTime.Parse("2020-08-21"),
    DownloadTimeWindowList = new List<Models.V2TimeWindow>
    {
        new V2TimeWindow
        {
            StartTime = 20,
            EndTime = 21,
        },
    },
    InstallAfterDate = DateTime.Parse("2020-08-21"),
    InstallTimeWindowList = new List<Models.V2TimeWindow>
    {
        new V2TimeWindow
        {
            StartTime = 22,
            EndTime = 23,
        },
    },
};

try
{
    ApiResponse<CampaignSoftware> result = await campaignsV2Controller.ScheduleCampaignFirmwareUpgradeAsync(account, body);
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
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
  "status": "CampaignRequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Cancel Campaign

This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.

```csharp
CancelCampaignAsync(
    string account,
    string campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Unique identifier of campaign. |

## Response Type

[`Task<ApiResponse<Models.FotaV2SuccessResult>>`](../../doc/models/fota-v2-success-result.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
try
{
    ApiResponse<FotaV2SuccessResult> result = await campaignsV2Controller.CancelCampaignAsync(account, campaignId);
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


# Schedule SW Upgrade Http Devices

Campaign time windows for downloading and installing software are available as long as the device OEM supports this.

```csharp
ScheduleSWUpgradeHttpDevicesAsync(
    string acc,
    Models.SchedulesSoftwareUpgradeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.SchedulesSoftwareUpgradeRequest`](../../doc/models/schedules-software-upgrade-request.md) | Body, Required | Device logging information. |

## Response Type

[`Task<ApiResponse<Models.UploadAndScheduleFileResponse>>`](../../doc/models/upload-and-schedule-file-response.md)

## Example Usage

```csharp
string acc = "0402196254-00001";
SchedulesSoftwareUpgradeRequest body = new SchedulesSoftwareUpgradeRequest
{
    CampaignName = "FOTA_Verizon_Upgrade",
    SoftwareName = "FOTA_Verizon_Model-A_02To03_HF",
    SoftwareFrom = "FOTA_Verizon_Model-A_00To01_HF",
    SoftwareTo = "FOTA_Verizon_Model-A_02To03_HF",
    DistributionType = "HTTP",
    StartDate = "2020-08-21",
    EndDate = "2020-08-22",
    DownloadAfterDate = "2020-08-21",
    DownloadTimeWindowList = new List<Models.DownloadTimeWindow>
    {
        new DownloadTimeWindow
        {
            StartTime = "20",
            EndTime = "21",
        },
    },
    InstallAfterDate = "2020-08-21",
    InstallTimeWindowList = new List<Models.DownloadTimeWindow>
    {
        new DownloadTimeWindow
        {
            StartTime = "22",
            EndTime = "23",
        },
    },
    DeviceList = new List<string>
    {
        "990013907835573",
        "990013907884259",
    },
};

try
{
    ApiResponse<UploadAndScheduleFileResponse> result = await campaignsV2Controller.ScheduleSWUpgradeHttpDevicesAsync(acc, body);
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": "20",
      "endTime": "21"
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": "22",
      "endTime": "23"
    }
  ],
  "status": "CampaignRequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

