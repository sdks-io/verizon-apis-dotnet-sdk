
# Position

It provides a precise location in the WGS-84 coordinate system, from which short offsets may be used to create additional data using a flat earth projection centered on this location.

## Structure

`Position`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Lat` | `int` | Required | The geographic latitude of an object, expressed in 1/10th integer microdegrees, as a 31 bit value, and with reference to the horizontal datum then in use. The value 900000001 shall be used when unavailable.<br><br>**Constraints**: `>= -900000000`, `<= 900000001` |
| `MLong` | `int` | Required | The geographic longitude of an object, expressed in 1/10th integer microdegrees, as a 32-bit value, and with reference to the horizontal datum then in use. The value 1800000001 shall be used when unavailable.<br><br>**Constraints**: `>= -1799999999`, `<= 1800000001` |

## Example (as JSON)

```json
{
  "lat": 220,
  "long": 122
}
```

