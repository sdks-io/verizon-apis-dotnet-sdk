
# Altitude Confidence Enum

Absolute accuracy of a reported altitude value.
The value shall be set to:

- 0  - `alt-000-01`   - if the confidence value is equal to or less than 0,01 metre,
- 1  - `alt-000-02`   - if the confidence value is equal to or less than 0,02 metre and greater than 0,01 metre,
- 2  - `alt-000-05`   - if the confidence value is equal to or less than 0,05 metre and greater than 0,02 metre,
- 3  - `alt-000-10`   - if the confidence value is equal to or less than 0,1 metre and greater than 0,05 metre,
- 4  - `alt-000-20`   - if the confidence value is equal to or less than 0,2 metre and greater than 0,1 metre,
- 5  - `alt-000-50`   - if the confidence value is equal to or less than 0,5 metre and greater than 0,2 metre,
- 6  - `alt-001-00`   - if the confidence value is equal to or less than 1 metre and greater than 0,5 metre,
- 7  - `alt-002-00`   - if the confidence value is equal to or less than 2 metres and greater than 1 metre,
- 8  - `alt-005-00`   - if the confidence value is equal to or less than 5 metres and greater than 2 metres,
- 9  - `alt-010-00`   - if the confidence value is equal to or less than 10 metres and greater than 5 metres,
- 10 - `alt-020-00`   - if the confidence value is equal to or less than 20 metres and greater than 10 metres,
- 11 - `alt-050-00`   - if the confidence value is equal to or less than 50 metres and greater than 20 metres,
- 12 - `alt-100-00`   - if the confidence value is equal to or less than 100 metres and greater than 50 metres,
- 13 - `alt-200-00`   - if the confidence value is equal to or less than 200 metres and greater than 100 metres,
- 14 - `outOfRange`   - if the confidence value is out of range, i.e. greater than 200 metres,
- 15 - `unavailable`  - if the confidence value is unavailable.

## Enumeration

`AltitudeConfidenceEnum`

## Fields

| Name |
|  --- |
| `Alt00001` |
| `Alt00002` |
| `Alt00005` |
| `Alt00010` |
| `Alt00020` |
| `Alt00050` |
| `Alt00100` |
| `Alt00200` |
| `Alt00500` |
| `Alt01000` |
| `Alt02000` |
| `Alt05000` |
| `Alt10000` |
| `Alt20000` |
| `OutOfRange` |
| `Unavailable` |

