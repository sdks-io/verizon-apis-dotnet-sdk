
# Check in History Item

Check-in history for a device.

## Structure

`CheckInHistoryItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `ClientType` | `string` | Required | Type of client. |
| `Result` | `string` | Required | - |
| `FailureType` | `string` | Required | - |
| `TimeCompleted` | `DateTime` | Required | - |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "clientType": "clientType2",
  "result": "result6",
  "failureType": "failureType6",
  "timeCompleted": "10/22/2020 19:35:07"
}
```

