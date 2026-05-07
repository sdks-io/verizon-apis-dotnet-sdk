
# Etx Geo Fence

The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration.

## Structure

`EtxGeoFence`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`TypeEnum`](../../doc/models/type-enum.md) | Required | - |
| `Features` | [`List<EtxFeature>`](../../doc/models/etx-feature.md) | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `1` |

## Example (as JSON)

```json
{
  "type": "FeatureCollection",
  "features": [
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
  ]
}
```

