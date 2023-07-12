
# Firmware Upgrade Change Request

List of devices to add or remove.

## Structure

`FirmwareUpgradeChangeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Models.FirmwareTypeListEnum`](../../doc/models/firmware-type-list-enum.md) | Required | Possible values are `append` or `remove` |
| `DeviceList` | `List<string>` | Required | The IMEIs of the devices. |

## Example (as JSON)

```json
{
  "type": "append",
  "deviceList": [
    "15-digit IMEI",
    "15-digit IMEI"
  ]
}
```

