
# Device Service Request

Device information.

## Structure

`DeviceServiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Imei` | `string` | Required | The International Mobile Equipment Identifier of the device. |
| `BullseyeEnable` | [`HplBullseyeEnable`](../../doc/models/hpl-bullseye-enable.md) | Required | A flag that shows if Hyper Precise is enabled (true) or disabled (false). |

## Example (as JSON)

```json
{
  "imei": "15-digit IMEI",
  "BullseyeEnable": {
    "BullseyeEnable": true
  }
}
```

