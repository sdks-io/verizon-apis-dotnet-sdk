
# Etx Feature

## Structure

`EtxFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type1Enum`](../../doc/models/type-1-enum.md) | Required | - |
| `Geometry` | [`Geometry`](../../doc/models/containers/geometry.md) | Required | - |
| `Properties` | `object` | Required | - |

## Example (as JSON)

```json
{
  "type": "Feature",
  "geometry": {
    "type": "LineString",
    "coordinates": [
      [
        51.53,
        51.54
      ],
      [
        51.53,
        51.54
      ]
    ]
  },
  "properties": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

