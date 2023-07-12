
# Device Firmware Version

Device and firmware information.

## Structure

`DeviceFirmwareVersion`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Optional | - |
| `Reason` | `string` | Optional | - |
| `DeviceId` | `string` | Required | Device IMEI. |
| `FirmwareVersion` | `string` | Required | Device Firmware Version. |
| `FirmwareVersionUpdateTime` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "status": "FirmwareVersionUpdateSuccess",
  "firmwareVersion": "SR1.2.0.0-10657",
  "reason": "reason4",
  "firmwareVersionUpdateTime": "2016-03-13T12:52:32.123Z"
}
```

