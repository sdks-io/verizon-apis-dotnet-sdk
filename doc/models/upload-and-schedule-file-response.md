
# Upload and Schedule File Response

## Structure

`UploadAndScheduleFileResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Updgrade identifier. |
| `AccountName` | `string` | Optional | Account identifer. |
| `CampaignName` | `string` | Optional | The campaign name. |
| `SoftwareName` | `string` | Optional | Software name. |
| `SoftwareFrom` | `string` | Optional | Old software name. |
| `SoftwareTo` | `string` | Optional | New software name. |
| `FileName` | `string` | Optional | The name of the file you are upgrading to. |
| `FileVersion` | `string` | Optional | The version of the file you are upgrading to. |
| `DistributionType` | `string` | Optional | Valid values |
| `Make` | `string` | Optional | Applicable make. |
| `Model` | `string` | Optional | Applicable model. |
| `StartDate` | `string` | Optional | Campaign start date. |
| `EndDate` | `string` | Optional | Campaign end date. |
| `DownloadAfterDate` | `string` | Optional | Specifies the starting date the client should download the package. If null, client downloads as soon as possible. |
| `DownloadTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed download time windows. |
| `InstallAfterDate` | `string` | Optional | The date after which you install the package. If null, install as soon as possible. |
| `InstallTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed install time windows. |
| `DeviceList` | `List<string>` | Optional | Device IMEI list. |
| `Status` | `string` | Optional | Software update status. |

## Example (as JSON)

```json
{
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0242078689-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "fileName": "configfile-Verizon_VZW1_hello-world.txt",
  "fileVersion": "1.0",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "startDate": "2021-02-08",
  "endDate": "2021-02-08",
  "downloadAfterDate": "2021-02-08",
  "status": "pending"
}
```

