
# Event Position

## Structure

`EventPosition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Latitude` | `int` | Required | Latitude of the event location in microdegrees (900000001 shall be used when unavailable).<br><br>**Constraints**: `>= -900000000`, `<= 900000001` |
| `Longitude` | `int` | Required | Longitude of the event location in microdegrees (1800000001 shall be used when unavailable).<br><br>**Constraints**: `>= -1800000000`, `<= 1800000001` |
| `PositionConfidenceEllipse` | [`PosConfidenceEllipse`](../../doc/models/pos-confidence-ellipse.md) | Required | - |
| `Altitude` | [`Altitude`](../../doc/models/altitude.md) | Required | - |

## Example (as JSON)

```json
{
  "latitude": 54,
  "longitude": 238,
  "positionConfidenceEllipse": {
    "semiMajorConfidence": 16,
    "semiMinorConfidence": 114,
    "semiMajorOrientation": 100
  },
  "altitude": {
    "altitudeValue": 236,
    "altitudeConfidence": "alt-000-01"
  }
}
```

