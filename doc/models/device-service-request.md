
# Device Service Request

Device information.

## Structure

`DeviceServiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Imei` | `string` | Required | International Mobile Equipment Identifier. The unique ID of a device.<br>**Constraints**: *Pattern*: `^[0-9]{15}$` |
| `BullseyeEnable` | `bool` | Required | Set to Enable (true) or Disable (false). |

## Example (as JSON)

```json
{
  "imei": "354658090356210",
  "BullseyeEnable": true
}
```

