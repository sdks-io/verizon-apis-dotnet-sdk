
# Notification Report Status Request

## Structure

`NotificationReportStatusRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The name of a billing account. |
| `Device` | [`DeviceId`](../../doc/models/device-id.md) | Required | An identifier for a single device. |
| `RequestType` | `string` | Required | The type of request. |
| `RequestExpirationTime` | `string` | Optional | The time at which the request expires. |

## Example (as JSON)

```json
{
  "accountName": "0868924207-00001",
  "device": {
    "kind": "imei",
    "id": "990013907835573"
  },
  "requestType": "requestType8",
  "requestExpirationTime": "requestExpirationTime6"
}
```

