
# SMS Event History Request

## Structure

`SMSEventHistoryRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`GIODeviceId`](../../doc/models/gio-device-id.md) | Required | - |
| `Earliest` | `DateTime?` | Optional | - |
| `Latest` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": {
    "kind": "eid",
    "id": "12345678901234567890123456789012"
  },
  "earliest": "2016-03-13T12:52:32.123Z",
  "latest": "2016-03-13T12:52:32.123Z"
}
```

