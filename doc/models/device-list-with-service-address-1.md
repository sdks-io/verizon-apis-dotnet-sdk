
# Device List with Service Address 1

## Structure

`DeviceListWithServiceAddress1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`List<DeviceListWithServiceAddress1DeviceId>`](../../doc/models/containers/device-list-with-service-address-1-device-id.md) | Optional | This is List of a container for any-of cases. |
| `PrimaryPlaceofuse` | [`M5gBiprimaryPlaceofuse`](../../doc/models/m5-g-biprimary-placeofuse.md) | Optional | - |

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
```

