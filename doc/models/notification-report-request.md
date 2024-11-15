
# Notification Report Request

## Structure

`NotificationReportRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `RequestType` | `string` | Required | - |
| `Devices` | [`List<DeviceList>`](../../doc/models/device-list.md) | Required | - |
| `MonitorExpirationTime` | `string` | Required | - |

## Example (as JSON)

```json
{
  "accountName": "0242072320-00001",
  "requestType": "REACHABLE_FOR_DATA",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8"
        }
      ]
    }
  ],
  "monitorExpirationTime": "2019-12-02T15:00:00-08:00Z"
}
```

