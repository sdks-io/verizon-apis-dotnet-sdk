
# Multi Polygon

A MultiPolygon is a type of geometry that represents a collection of Polygon geometries.

## Structure

`MultiPolygon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type5Enum`](../../doc/models/type-5-enum.md) | Required | - |
| `Coordinates` | `List<List<List<List<double>>>>` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, `>= -180`, `<= 180` |

## Example (as JSON)

```json
{
  "type": "MultiPolygon",
  "coordinates": [
    [
      [
        [
          46.55
        ]
      ]
    ]
  ]
}
```

