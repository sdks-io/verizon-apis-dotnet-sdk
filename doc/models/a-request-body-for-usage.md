
# A Request Body for Usage

## Structure

`ARequestBodyForUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`List<ReadySimDeviceId>`](../../doc/models/ready-sim-device-id.md) | Optional | - |
| `StartTime` | `DateTime?` | Optional | - |
| `EndTime` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "startTime": "08/15/2021 00:00:00",
  "endTime": "08/16/2021 00:00:00",
  "deviceId": [
    {
      "kind": "kind8",
      "id": "id0"
    },
    {
      "kind": "kind8",
      "id": "id0"
    },
    {
      "kind": "kind8",
      "id": "id0"
    }
  ]
}
```

