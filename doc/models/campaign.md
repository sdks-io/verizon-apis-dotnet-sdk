
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
| `CampaignTimeWindowList` | [`List<V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `Status` | `string` | Required | Firmware upgrade status. |
| `AutoAssignLicenseFlag` | `bool` | Required | Any device included in the device list which does not have a license will automatically be assigned a FOTA license, assuming there are enough FOTA licenses available, when set to true. |
| `AutoAddDevicesFlag` | `bool` | Required | Beyond the devices included on the device list, any other device(s) which matches the eligibility criteria (same make, model, current firmware, protocol, billing account) will automatically be added to the campaign list during the life of the campaign when set to true. |

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
  ],
  "autoAssignLicenseFlag": false,
  "autoAddDevicesFlag": false
}
```

