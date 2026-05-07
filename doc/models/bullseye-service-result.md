
# Bullseye Service Result

Status of Hyper Precise Location on the device.

## Structure

`BullseyeServiceResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | The numeric ID of the account and must include leading zeroes. This value is indentical to `accountName`. |
| `DeviceList` | [`List<DeviceServiceInformation>`](../../doc/models/device-service-information.md) | Optional | List of devices. |
| `ResponseType` | [`ApiResponseCode`](../../doc/models/api-response-code.md) | Optional | ResponseCode and/or a message indicating success or failure of the request. |

## Example (as JSON)

```json
{
  "accountNumber": "0000123456-00001",
  "deviceList": [
    {
      "responseType": {
        "responseCode": "INTERNAL_ERROR",
        "message": "message8"
      },
      "imei": "imei4",
      "BullseyeEnable": {
        "BullseyeEnable": false
      }
    }
  ],
  "responseType": {
    "responseCode": "INTERNAL_ERROR",
    "message": "message8"
  }
}
```

