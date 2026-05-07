
# Geographical Path

The data frame is used to support the cross-cutting need in many V2X messages to describe arbitrary spatial areas (polygons, boundary lines, and other basic shapes) required by various message types in a small message size.

## Structure

`GeographicalPath`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | [`GeographicalPathDescription`](../../doc/models/geographical-path-description.md) | Optional | This data frame can describe a complex path of arbitrary size using node offset method (LL offsets). |
| `Direction` | `string` | Optional | **Constraints**: *Pattern*: `^[0-9A-Fa-f]{4}$` |

## Example (as JSON)

```json
{
  "description": {
    "path": {
      "offset": {
        "ll": {
          "nodes": [
            {
              "delta": {
                "node-LatLon": {
                  "lon": 40,
                  "lat": 10
                }
              }
            },
            {
              "delta": {
                "node-LatLon": {
                  "lon": 40,
                  "lat": 10
                }
              }
            }
          ]
        }
      }
    }
  },
  "direction": "direction8"
}
```

