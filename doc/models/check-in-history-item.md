
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
  "clientType": "clientType6",
  "result": "result8",
  "failureType": "failureType8",
  "timeCompleted": "10/22/2020 19:35:07"
}
```

