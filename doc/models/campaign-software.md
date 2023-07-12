
# Campaign Software

Software upgrade information.

## Structure

`CampaignSoftware`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Upgrade identifier. |
| `AccountName` | `string` | Required | Account identifier. |
| `CampaignName` | `string` | Optional | Campaign name. |
| `SoftwareName` | `string` | Required | Software name. |
| `DistributionType` | `string` | Required | LWM2M, OMD-DM or HTTP. |
| `Make` | `string` | Required | Applicable make. |
| `Model` | `string` | Required | Applicable model. |
| `SoftwareFrom` | `string` | Required | Old software name. |
| `SoftwareTo` | `string` | Required | New software name. |
| `StartDate` | `DateTime` | Required | Campaign start date. |
| `EndDate` | `DateTime` | Required | Campaign end date. |
| `DownloadAfterDate` | `DateTime?` | Optional | Specifies starting date client should download package. If null, client will download as soon as possible. |
| `DownloadTimeWindowList` | [`List<Models.V2TimeWindow>`](../../doc/models/v2-time-window.md) | Optional | List of allowed download time windows. |
| `InstallAfterDate` | `DateTime?` | Optional | Client will install package after date. If null, client will install as soon as possible. |
| `InstallTimeWindowList` | [`List<Models.V2TimeWindow>`](../../doc/models/v2-time-window.md) | Optional | List of allowed install time windows. |
| `Status` | `string` | Required | Software upgrade status. |

## Example (as JSON)

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

