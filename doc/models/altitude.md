
# Altitude

## Structure

`Altitude`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AltitudeValue` | `int?` | Optional | Altitude in a WGS84 co-ordinate system (set to 800001 when unavailable).<br>The value shall be set to:<br><br>- `-100000` if the altitude is equal to or less than -1000 m,<br>- `n` (`n > -100000` and `n < 800000`) if the altitude is equal to or less than n  x 0,01 metre and greater than (n-1) x 0,01 metre,<br>- `800000` if the altitude  greater than 7999,99 m,<br>- `800001` if the information is not available.<br><br>**Constraints**: `>= -100000`, `<= 800001` |
| `AltitudeConfidence` | [`AltitudeConfidenceEnum?`](../../doc/models/altitude-confidence-enum.md) | Optional | Absolute accuracy of a reported altitude value.<br>The value shall be set to:<br><br>- 0  - `alt-000-01`   - if the confidence value is equal to or less than 0,01 metre,<br>- 1  - `alt-000-02`   - if the confidence value is equal to or less than 0,02 metre and greater than 0,01 metre,<br>- 2  - `alt-000-05`   - if the confidence value is equal to or less than 0,05 metre and greater than 0,02 metre,<br>- 3  - `alt-000-10`   - if the confidence value is equal to or less than 0,1 metre and greater than 0,05 metre,<br>- 4  - `alt-000-20`   - if the confidence value is equal to or less than 0,2 metre and greater than 0,1 metre,<br>- 5  - `alt-000-50`   - if the confidence value is equal to or less than 0,5 metre and greater than 0,2 metre,<br>- 6  - `alt-001-00`   - if the confidence value is equal to or less than 1 metre and greater than 0,5 metre,<br>- 7  - `alt-002-00`   - if the confidence value is equal to or less than 2 metres and greater than 1 metre,<br>- 8  - `alt-005-00`   - if the confidence value is equal to or less than 5 metres and greater than 2 metres,<br>- 9  - `alt-010-00`   - if the confidence value is equal to or less than 10 metres and greater than 5 metres,<br>- 10 - `alt-020-00`   - if the confidence value is equal to or less than 20 metres and greater than 10 metres,<br>- 11 - `alt-050-00`   - if the confidence value is equal to or less than 50 metres and greater than 20 metres,<br>- 12 - `alt-100-00`   - if the confidence value is equal to or less than 100 metres and greater than 50 metres,<br>- 13 - `alt-200-00`   - if the confidence value is equal to or less than 200 metres and greater than 100 metres,<br>- 14 - `outOfRange`   - if the confidence value is out of range, i.e. greater than 200 metres,<br>- 15 - `unavailable`  - if the confidence value is unavailable. |

## Example (as JSON)

```json
{
  "altitudeValue": 254,
  "altitudeConfidence": "alt-020-00"
}
```

