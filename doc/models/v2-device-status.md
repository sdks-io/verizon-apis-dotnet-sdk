
# V2 Device Status

Device with id in IMEI.

## Structure

`V2DeviceStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `Status` | `string` | Required | Success or failure. |
| `ResultReason` | `string` | Optional | Result reason. |

## Example (as JSON)

```json
{
  "deviceId": "990000473475967",
  "status": "Failure",
  "resultReason": "Device does not exist."
}
```

