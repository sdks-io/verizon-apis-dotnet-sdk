
# Device Listforplanner

## Structure

`DeviceListforplanner`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceIds` | [`List<DeviceIdforplanner>`](../../doc/models/device-idforplanner.md) | Optional | - |
| `PrivateNetworkApns` | [`List<PrivateNetworkApns>`](../../doc/models/private-network-apns.md) | Optional | - |
| `Ipaddress` | `string` | Optional | A IPv4 address |
| `ActivationCode` | `string` | Optional | The activation code value. |

## Example (as JSON)

```json
{
  "ipAddress": "10.10.10.01",
  "deviceIds": [
    {
      "kind": "kind8",
      "id": "id0"
    },
    {
      "kind": "kind8",
      "id": "id0"
    }
  ],
  "privateNetworkApns": [
    {
      "apnName": "apnName2",
      "addressAssignmentMethod": "addressAssignmentMethod8",
      "ipAddress": "ipAddress4"
    }
  ],
  "activationCode": "activationCode0"
}
```

