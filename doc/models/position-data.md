
# Position Data

Position data.

## Structure

`PositionData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `string` | Optional | Time location obtained. |
| `Utcoffset` | `string` | Optional | UTC offset of time. |
| `X` | `string` | Optional | X coordinate of location. |
| `Y` | `string` | Optional | Y coordinate of location. |
| `Radius` | `string` | Optional | Radius of the location in meters. |
| `Qos` | `bool?` | Optional | Whether requested accurary is met or not. |

## Example (as JSON)

```json
{
  "qos": false,
  "radius": "5571",
  "time": "20170520004421",
  "x": "33.45324",
  "y": "-84.59621",
  "utcoffset": "utcoffset0"
}
```

