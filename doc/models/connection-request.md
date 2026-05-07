
# Connection Request

Request for /clients/connection. It requires the device ID acquired in the registration request call; the geolocation of the device at the time of the request; and the network type (Verizon or non-Verizon). The system uses this information to determine with MQTT endpoint the device should use to connect the ETX Message Exchange.

## Structure

`ConnectionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceID` | `Guid` | Required | The generated ID (UUID v4) for the device. It can be used as:<br><br>- the MQTT Client ID when connecting to the Message Exchange system<br>- a parameter when asking for the connection endpoint<br>- a parameter when finishing the device registration<br>- a parameter when unregistering the device |
| `Geolocation` | [`Geolocation`](../../doc/models/geolocation.md) | Required | Geolocation of the device at the time of the connection request in GPS coordinates. |
| `NetworkType` | [`NetworkTypeEnum`](../../doc/models/network-type-enum.md) | Required | The type of the device's network connection at the time of the request. If the device is on the Verizon cellular network it should use the "VZ" value otherwise the "non-VZ" value.<br><br>Devices on the Verizon network can directly access the ETX Message Exchange on the MEC (Mobile Edge Compute server) |

## Example (as JSON)

```json
{
  "DeviceID": "976c4bad-03d3-4dcb-9688-ee57db7890e4",
  "Geolocation": {
    "Latitude": 42.36,
    "Longitude": -71.06
  },
  "NetworkType": "non-VZ"
}
```

