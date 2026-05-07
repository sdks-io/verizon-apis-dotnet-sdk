
# Bullseye Service Request

Account number and list of devices.

## Structure

`BullseyeServiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | [`List<DeviceServiceRequest>`](../../doc/models/device-service-request.md) | Required | A list of devices. |
| `AccountNumber` | `string` | Required | The numeric ID of the account and must include leading zeroes. This value is indentical to `accountName`. |

## Example (as JSON)

```json
{
  "deviceList": [
    {
      "imei": "15-digit IMEI",
      "BullseyeEnable": {
        "BullseyeEnable": true
      }
    }
  ],
  "accountNumber": "0000123456-00001"
}
```

