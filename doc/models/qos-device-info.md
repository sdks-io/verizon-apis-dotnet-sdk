
# Qos Device Info

## Structure

`QosDeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`QosDeviceId`](../../doc/models/qos-device-id.md) | Required | - |
| `DeviceIPv6Addr` | `string` | Optional | - |
| `FlowInfo` | [`List<FlowInfo>`](../../doc/models/flow-info.md) | Required | - |

## Example (as JSON)

```json
{
  "deviceId": {
    "id": "10-digit phone number",
    "kind": "mdn"
  },
  "deviceIPv6Addr": "IPv6 address",
  "flowInfo": [
    {
      "flowServer": "[IPv6 address]:port",
      "flowDevice": "[IPv6 address]:port",
      "flowDirection": "UPLINK",
      "flowProtocol": "UDP",
      "qciOption": "Premium"
    }
  ]
}
```

