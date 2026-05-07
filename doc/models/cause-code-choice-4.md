
# Cause Code Choice 4

## Structure

`CauseCodeChoice4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WrongWayDriving14` | `int` | Required | The value shall be set to:<br><br>- 0 `unavailable`    - in case further detailed information on wrong way driving event is unavailable,<br>- 1 `wrongLane`      - in case vehicle is driving on a lane for which it has no authorization to use,<br>- 2 `wrongDirection` - in case vehicle is driving in a direction that it is not allowed,<br>- 3-255              - reserved for future usage.<br><br>**Constraints**: `>= 0`, `<= 255` |

## Example (as JSON)

```json
{
  "wrongWayDriving14": 58
}
```

