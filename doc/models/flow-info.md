
# Flow Info

## Structure

`FlowInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FlowServer` | `string` | Optional | The IPv6 IP address and port used to connect to the server |
| `FlowDevice` | `string` | Optional | The IPv6 IP address and port used by the device |
| `FlowDirection` | `string` | Optional | The direction the data is flowing. UPLINK if from the device, DOWNLINK is to the device |
| `FlowProtocol` | `string` | Optional | The data protocol used for the connection |
| `QciOption` | `string` | Optional | The QoS level of the connection. This will be Standard or Premium |

## Example (as JSON)

```json
{
  "flowServer": "[IPv6 address]:port",
  "flowDevice": "[IPv6 address]:port",
  "flowDirection": "UPLINK",
  "flowProtocol": "UDP",
  "qciOption": "Premium"
}
```

