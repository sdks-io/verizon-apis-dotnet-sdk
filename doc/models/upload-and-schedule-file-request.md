
# Upload and Schedule File Request

## Structure

`UploadAndScheduleFileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CampaignName` | `string` | Optional | The campaign name. |
| `FileName` | `string` | Optional | The name of the file you are upgrading to. |
| `FileVersion` | `string` | Optional | The version of the file you are upgrading to. |
| `DistributionType` | `string` | Optional | Valid values |
| `StartDate` | `string` | Optional | Campaign start date. |
| `EndDate` | `string` | Optional | Campaign end date. |
| `DownloadAfterDate` | `string` | Optional | Specifies the starting date the client should download the package. If null, client downloads as soon as possible. |
| `DownloadTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed download time windows. |
| `InstallAfterDate` | `string` | Optional | The date after which you install the package. If null, install as soon as possible. |
| `InstallTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed install time windows. |
| `DeviceList` | `List<string>` | Optional | Device IMEI list. |

## Example (as JSON)

```json
{
  "campaignName": "FOTA_Verizon_Upgrade",
  "fileName": "configfile-Verizon_VZW1_hello-world.txt",
  "fileVersion": "1.0",
  "distributionType": "HTTP",
  "startDate": "2021-02-08",
  "endDate": "2021-02-08",
  "downloadAfterDate": "2021-02-08"
}
```

