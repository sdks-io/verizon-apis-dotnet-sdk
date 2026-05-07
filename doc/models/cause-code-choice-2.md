
# Cause Code Choice 2

## Structure

`CauseCodeChoice2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Roadworks3` | `int` | Required | The value shall be set to:<br><br>- 0 `unavailable`                 - in case further detailed information on roadworks is unavailable,<br>- 1 `majorRoadworks`              - in case a major roadworks is ongoing,<br>- 2 `roadMarkingWork`             - in case a road marking work is ongoing,<br>- 3 `slowMovingRoadMaintenance`   - in case slow moving road maintenance work is ongoing,<br>- 4 `shortTermStationaryRoadworks`- in case a short term stationary roadwork is ongoing,<br>- 5 `streetCleaning`              - in case a vehicle street cleaning work is ongoing,<br>- 6 `winterService`               - in case winter service work is ongoing,<br>- 7 `setupPhase`                  - in case the work zone is being setup,<br>- 8 `remodellingPhase`            - in case the work zone is being changed,<br>- 9 `dismantlingPhase`            - in case the work zone is being dismantled after finished work.<br>- 10-255                          - are reserved for future usage.<br><br>**Constraints**: `>= 0`, `<= 255` |

## Example (as JSON)

```json
{
  "roadworks3": 166
}
```

