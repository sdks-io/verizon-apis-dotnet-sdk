
# Cause Code Choice 5

## Structure

`CauseCodeChoice5`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EmergencyVehicleApproaching95` | `int` | Required | The value shall be set to:<br><br>- 0 `unavailable`                   - in case further detailed information on the emergency vehicle approaching event is unavailable,<br>- 1 `emergencyVehicleApproaching`   - in case an operating emergency vehicle is approaching,<br>- 2 `prioritizedVehicleApproaching` - in case a prioritized vehicle is approaching,<br>- 3-255                             - reserved for future usage.<br><br>**Constraints**: `>= 0`, `<= 255` |

## Example (as JSON)

```json
{
  "emergencyVehicleApproaching95": 82
}
```

