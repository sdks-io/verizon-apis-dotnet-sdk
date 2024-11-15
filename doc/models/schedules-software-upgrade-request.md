
# Schedules Software Upgrade Request

## Structure

`SchedulesSoftwareUpgradeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CampaignName` | `string` | Optional | The campaign name. |
| `SoftwareName` | `string` | Optional | Software name. |
| `SoftwareFrom` | `string` | Optional | Old software name. |
| `SoftwareTo` | `string` | Optional | New software name. |
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
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "startDate": "2021-02-08",
  "endDate": "2021-02-08",
  "downloadAfterDate": "2021-02-08"
}
```

