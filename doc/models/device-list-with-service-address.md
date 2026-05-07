
# Device List with Service Address

## Structure

`DeviceListWithServiceAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`List<M5gBideviceId1>`](../../doc/models/m5-g-bidevice-id-1.md) | Optional | - |
| `PrimaryPlaceofuse` | [`M5gBiaddressAndcustomerinfo`](../../doc/models/m5-g-biaddress-andcustomerinfo.md) | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": [
    {
      "id": "id0",
      "kind": "kind8"
    }
  ],
  "primaryPlaceofuse": {
    "primaryPlaceofuse": {
      "address": {
        "addressLine1": "addressLine18",
        "city": "city6",
        "state": "state2",
        "zip": "zip0",
        "zip+4": "zip+48"
      },
      "customerName": {
        "firstName": "firstName4",
        "lastName": "lastName4",
        "middleName": "middleName8",
        "title": "title4",
        "suffex": "suffex4"
      }
    }
  }
}
```

