
# Node L Lm D64 B

A 64-bit node type with lat-long values expressed in standard SAE 1/10th of a microdegree.

## Structure

`NodeLLmD64b`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Lon` | `int` | Required | The geographic longitude of an object, expressed in 1/10th integer microdegrees, as a 32-bit value, and with reference to the horizontal datum then in use. The value 1800000001 shall be used when unavailable.<br><br>**Constraints**: `>= -1799999999`, `<= 1800000001` |
| `Lat` | `int` | Required | The geographic latitude of an object, expressed in 1/10th integer microdegrees, as a 31 bit value, and with reference to the horizontal datum then in use. The value 900000001 shall be used when unavailable.<br><br>**Constraints**: `>= -900000000`, `<= 900000001` |

## Example (as JSON)

```json
{
  "lon": 66,
  "lat": 116
}
```

