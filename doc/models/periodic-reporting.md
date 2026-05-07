
# Periodic Reporting

The units and values of the time interval for the sensor to send a report

## Structure

`PeriodicReporting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Unit` | [`UnitEnum?`](../../doc/models/unit-enum.md) | Optional | - |
| `Hours` | `int?` | Optional | whole numbers from 0 to 24 |
| `Minutes` | `int?` | Optional | whole numbers from 0 to 59 |

## Example (as JSON)

```json
{
  "hours": 0,
  "minutes": 12,
  "unit": "minutes"
}
```

