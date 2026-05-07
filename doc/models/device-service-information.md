
# Device Service Information

Device service information.

## Structure

`DeviceServiceInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResponseType` | [`ApiResponseCode`](../../doc/models/api-response-code.md) | Optional | ResponseCode and/or a message indicating success or failure of the request. |
| `Imei` | `string` | Required | The International Mobile Equipment Identifier of the device. |
| `BullseyeEnable` | [`HplBullseyeEnable`](../../doc/models/hpl-bullseye-enable.md) | Required | A flag that shows if Hyper Precise is enabled (true) or disabled (false). |

## Example (as JSON)

```json
{
  "imei": "15-digit IMEI",
  "BullseyeEnable": {
    "BullseyeEnable": true
  },
  "responseType": {
    "responseCode": "INTERNAL_ERROR",
    "message": "message8"
  }
}
```

