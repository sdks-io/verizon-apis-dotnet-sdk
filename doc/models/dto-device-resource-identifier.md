
# Dto Device Resource Identifier

Device identifiers, one or more are required

## Structure

`DtoDeviceResourceIdentifier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Deveui` | `string` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer |
| `Deviceid` | `string` | Optional | This is a UUID value of the device created when the device is onboarded |
| `Esn` | `int?` | Optional | The Electronic Serial Number (ESN) of the device |
| `Iccid` | `string` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) |
| `Imei` | `int?` | Optional | The 15-digit International Mobile Equipment ID |
| `Imsi` | `int?` | Optional | The 64-bit International Mobile Subscriber Identity |
| `Mac` | `string` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX |
| `Manufacturer` | `string` | Optional | The manufacturer of the device |
| `Meid` | `string` | Optional | The 56-bit Mobile Equipment ID |
| `Msisdn` | `string` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number |
| `NodeUuid` | `string` | Optional | The UUID of the node the device is associated with |
| `Qrcode` | `string` | Optional | The numeric value of the Quick Response (QR) code |
| `Serial` | `string` | Optional | The device's serial number |

## Example (as JSON)

```json
{
  "deveui": "The unique EUI64 address of the device",
  "deviceid": "The UUID of the device",
  "iccid": "The 20-digit ICCID",
  "mac": "The Media Access Control (MAC) address",
  "manufacturer": "REOLINK",
  "meid": "The 56-bit Mobile Equipment ID",
  "msisdn": "The Mobile Station International Subscriber Directory Number",
  "node_uuid": "The UUID of the node",
  "qrcode": "The Quick Response (QR) code",
  "serial": "The device's serial number",
  "esn": 122,
  "imei": 34
}
```

