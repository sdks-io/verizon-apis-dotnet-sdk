
# Road Sign ID

It provide a precise location of one or more roadside signs.

## Structure

`RoadSignID`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Position` | [`Position`](../../doc/models/position.md) | Required | It provides a precise location in the WGS-84 coordinate system, from which short offsets may be used to create additional data using a flat earth projection centered on this location. |
| `ViewAngle` | `string` | Required | OctetStrings are described as hexadecimal strings, where each octet is represented by two hexadecimal characters.<br><br>**Constraints**: *Pattern*: `^[0-9A-Fa-f]{4}$` |

## Example (as JSON)

```json
{
  "position": {
    "lat": 14,
    "long": 172
  },
  "viewAngle": "1101"
}
```

