
# Locations 1

## Structure

`Locations1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CoordinatesList` | [`List<Coordinates>`](../../doc/models/coordinates.md) | Optional | - |
| `AddressList` | [`List<AddressItem>`](../../doc/models/address-item.md) | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "coordinatesList": [
    {
      "latitude": "latitude6",
      "longitude": "longitude4"
    },
    {
      "latitude": "latitude6",
      "longitude": "longitude4"
    },
    {
      "latitude": "latitude6",
      "longitude": "longitude4"
    }
  ],
  "addressList": [
    {
      "addressLine1": "addressLine10",
      "addressLine2": "addressLine28",
      "city": "city8",
      "state": "state4",
      "country": "country2"
    },
    {
      "addressLine1": "addressLine10",
      "addressLine2": "addressLine28",
      "city": "city8",
      "state": "state4",
      "country": "country2"
    }
  ]
}
```

