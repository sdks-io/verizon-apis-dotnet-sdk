
# V2 Time Window

Allowed start and end time windows.

## Structure

`V2TimeWindow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartTime` | `int` | Required | Start hour in range [0..23], current hour >= startTime. |
| `EndTime` | `int` | Required | End hour in range [1..24], current hour < endTime. |

## Example (as JSON)

```json
{
  "startTime": 20,
  "endTime": 21
}
```

