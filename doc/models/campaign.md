
# Campaign

Firmware upgrade information.

## Structure

`Campaign`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Upgrade identifier. |
| `AccountName` | `string` | Required | Account identifier. |
| `CampaignName` | `string` | Optional | Campaign name. |
| `FirmwareName` | `string` | Optional | Name of firmware. |
| `FirmwareFrom` | `string` | Optional | Old firmware version. |
| `FirmwareTo` | `string` | Optional | New firmware version. |
| `Protocol` | `string` | Required | The protocol of the firmware distribution. Default: LWM2M.<br>**Default**: `"LWM2M"` |
| `Make` | `string` | Required | Applicable make. |
| `Model` | `string` | Required | Applicable model. |
| `StartDate` | `DateTime` | Required | Campaign start date. |
| `EndDate` | `DateTime` | Required | Campaign end date. |
| `CampaignTimeWindowList` | [`List<Models.V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `Status` | `string` | Required | Firmware upgrade status. |

## Example (as JSON)

```json
{
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0642233522-00001",
  "campaignName": "Smart FOTA - test 4",
  "protocol": "LWM2M",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignPreScheduled",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "campaignTimeWindowList": [
    {
      "startTime": 18,
      "endTime": 22
    }
  ]
}
```

