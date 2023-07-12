
# Device Firmware Upgrade

Firmware upgrades information.

## Structure

`DeviceFirmwareUpgrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device identifier. |
| `CampaignId` | `string` | Required | Campaign identifier. |
| `AccountName` | `string` | Required | Account identifier. |
| `FirmwareName` | `string` | Optional | Firmware name. |
| `FirmwareFrom` | `string` | Optional | Old firmware version. |
| `FirmwareTo` | `string` | Optional | New firmware version. |
| `StartDate` | `DateTime` | Required | Firmware upgrade start date. |
| `Status` | `string` | Required | Firmware upgrade status. |
| `Reason` | `string` | Required | Software upgrade result reason. |
| `ReportUpdatedTime` | `string` | Optional | Report updated time. |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "campaignId": "252d7ffc-7e35-11ec-931d-76f56843c393",
  "accountName": "0000123456-00001",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10657_SR1.2.0.0-10512",
  "firmwareFrom": "SR1.2.0.0-10657",
  "firmwareTo": "SR1.2.0.0-10512",
  "startDate": "2022-01-25",
  "reportUpdatedTime": "2022-01-26 03:45:01.608 +0000 UTC",
  "status": "UpgradeSuccess",
  "reason": "Upgrade completed successfully"
}
```

