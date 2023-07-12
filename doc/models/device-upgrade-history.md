
# Device Upgrade History

Firmware upgrade information.

## Structure

`DeviceUpgradeHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Optional | Device IMEI. |
| `Id` | `string` | Optional | The unique identifier for the upgrade. |
| `AccountName` | `string` | Optional | The name (number) of the billing account that the device belongs to. |
| `FirmwareFrom` | `string` | Optional | The firmware version that was on the device before the upgrade. |
| `FirmwareTo` | `string` | Optional | The name of the firmware version that was on the device after the upgrade. |
| `StartDate` | `string` | Optional | The date of the upgrade. |
| `UpgradeStartTime` | `string` | Optional | The date and time that the upgrade actually started for this device. |
| `Status` | `string` | Optional | The status of the upgrade for this device. |
| `Reason` | `string` | Optional | More information about the status. |

## Example (as JSON)

```json
{
  "deviceId": "900000000000001",
  "id": "f574fbb8-b291-4cc7-bf22-4e3f27977558",
  "accountName": "0242078689-00001",
  "firmwareFrom": "VerizonFirmwareVersion-02",
  "firmwareTo": "VerizonFirmwareVersion-03",
  "startDate": "2018-03-05",
  "upgradeStartTime": "2018-03-05T19:07:21Z",
  "status": "UpgradeSuccess",
  "reason": "success"
}
```

