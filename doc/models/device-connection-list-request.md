
# Device Connection List Request

Request to list of network connection events for a device during a specified time period.

## Structure

`DeviceConnectionListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`Models.DeviceId`](../../doc/models/device-id.md) | Optional | An identifier for a single device. |
| `Earliest` | `string` | Optional | The earliest date and time for which you want connection events. |
| `Latest` | `string` | Optional | The last date and time for which you want connection events. |

## Example (as JSON)

```json
{
  "deviceId": {
    "id": "89141390780800784259",
    "kind": "iccid"
  },
  "earliest": "2015-09-16T00:00:01Z",
  "latest": "2010-09-18T00:00:01Z"
}
```

