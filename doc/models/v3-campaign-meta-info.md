
# V3 Campaign Meta Info

Campaign and campaign details.

## Structure

`V3CampaignMetaInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier. |
| `Id` | `string` | Required | Campaign identifier. |
| `CampaignName` | `string` | Optional | Campaign name. |
| `FirmwareName` | `string` | Optional | Firmware name. |
| `FirmwareFrom` | `string` | Optional | Old firmware version. |
| `FirmwareTo` | `string` | Optional | New software version. |
| `Protocol` | [`CampaignMetaInfoProtocolEnum?`](../../doc/models/campaign-meta-info-protocol-enum.md) | Optional | Firmware protocol. Valid values include: LWM2M, OMD-DM.<br>**Default**: `CampaignMetaInfoProtocolEnum.LWM2M` |
| `Make` | `string` | Required | Device make. |
| `Model` | `string` | Required | Device model. |
| `StartDate` | `DateTime` | Required | Campaign start date. |
| `EndDate` | `DateTime` | Required | Campaign end date. |
| `CampaignTimeWindowList` | [`List<V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `Status` | `string` | Required | Firmware upgrade status. |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "campaignName": "FOTA_Verizon_Upgrade",
  "firmwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "firmwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "firmwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "make": "Verizon",
  "model": "Model-A",
  "status": "CampaignEnded",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "campaignTimeWindowList": [
    {
      "startTime": 20,
      "endTime": 21
    }
  ],
  "protocol": "LWM2M"
}
```

