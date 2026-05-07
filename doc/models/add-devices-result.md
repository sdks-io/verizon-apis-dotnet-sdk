
# Add Devices Result

Contains the device identifiers and a success or failure response for each device in the request.

## Structure

`AddDevicesResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceIds` | [`List<DeviceId>`](../../doc/models/device-id.md) | Optional | Identifiers for the device. |
| `Response` | `string` | Optional | The status message for the current device. This will be Success or Failed |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "20-digit ICCID",
      "kind": "iccid"
    }
  ],
  "response": "Success"
}
```

