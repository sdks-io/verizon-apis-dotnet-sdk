
# V2 Campaign Meta Info

Campaign and campaign details.

## Structure

`V2CampaignMetaInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier. |
| `Id` | `string` | Required | Campaign identifier. |
| `CampaignName` | `string` | Optional | Campaign name. |
| `SoftwareName` | `string` | Required | Software name. |
| `DistributionType` | `string` | Required | LWM2M, OMD-DM or HTTP. |
| `SoftwareFrom` | `string` | Required | Old software name. |
| `SoftwareTo` | `string` | Required | New software name. |
| `Make` | `string` | Required | Applicable make. |
| `Model` | `string` | Required | Applicable model. |
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
```

