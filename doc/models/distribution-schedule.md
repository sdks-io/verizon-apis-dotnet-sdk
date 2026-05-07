
# Distribution Schedule

The distribution schedule parameters for broadcast messages.

## Structure

`DistributionSchedule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RepeatPeriod` | `int` | Required | The period (in seconds) that the message needs to be repeatedly send out.<br><br>**Constraints**: `>= 5`, `<= 3600` |
| `Duration` | `int` | Required | The amount of time (in minutes) while the messages needs to be sent out.<br><br>**Constraints**: `>= 1`, `<= 32000` |
| `StartTime` | `DateTime?` | Optional | The time (in UTC) when the message transmission should be started. |

## Example (as JSON)

```json
{
  "repeatPeriod": 70,
  "duration": 68,
  "startTime": "07/21/2042 17:32:28"
}
```

