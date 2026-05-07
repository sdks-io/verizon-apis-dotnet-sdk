
# Dto List Sensor Devices Request

## Structure

`DtoListSensorDevicesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountname` | `string` | Optional | The numeric account name, which must include leading zeros |
| `Filter` | [`DtoFilter`](../../doc/models/dto-filter.md) | Optional | - |
| `Resourceidentifier` | [`DtoDeviceResourceIdentifier`](../../doc/models/dto-device-resource-identifier.md) | Optional | Device identifiers, one or more are required |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "filter": {
    "$expand": "$expand0",
    "$limitnumber": 100,
    "$nopagination": false,
    "$page": "$page0",
    "$pagenumber": 64
  },
  "resourceidentifier": {
    "deveui": "deveui2",
    "deviceid": "deviceid6",
    "esn": 86,
    "iccid": "iccid0",
    "imei": 2
  }
}
```

