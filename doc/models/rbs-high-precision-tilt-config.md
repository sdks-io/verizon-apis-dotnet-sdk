
# Rbs High Precision Tilt Config

## Structure

`RbsHighPrecisionTiltConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mode` | [`ModeEnum?`](../../doc/models/mode-enum.md) | Optional | the reporting mode of the tilt sensor |
| `PeriodicReporting` | [`PeriodicReporting`](../../doc/models/periodic-reporting.md) | Optional | The units and values of the time interval for the sensor to send a report |
| `HoldTime` | `int?` | Optional | The time the threshold condition exists, in milliseconds, to recognize an event |
| `AngleAway` | `int?` | Optional | the threshold value, from verticle, to recognize an event |
| `AngleToward` | `int?` | Optional | the threshold value, moving towards  verticle, to recognize an event |
| `Tscore` | [`Tscore`](../../doc/models/tscore.md) | Optional | - |

## Example (as JSON)

```json
{
  "hold-time": 5000,
  "angle-away": 5,
  "angle-toward": 5,
  "mode": "reportOnChange",
  "periodic-reporting": {
    "unit": "minutes",
    "hours": 250,
    "minutes": 232
  }
}
```

