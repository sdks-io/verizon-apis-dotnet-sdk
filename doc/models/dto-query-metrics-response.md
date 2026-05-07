
# Dto Query Metrics Response

## Structure

`DtoQueryMetricsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Critical` | `int?` | Optional | The number of critical alerts in the queried time period |
| `Major` | `int?` | Optional | The number of major alerts in the queried time period |
| `Minor` | `int?` | Optional | The number of minor alerts in the queried time period |
| `Noalert` | `int?` | Optional | The number of sensor reports containing no  alerts in the queried time period |
| `Total` | `int?` | Optional | The total number of alerts in the queried time period |
| `Deltacritical` | `int?` | Optional | The change in the number of critical alerts in the queried time period |
| `Deltamajor` | `int?` | Optional | The change in the number of major alerts in the queried time period |
| `Deltaminor` | `int?` | Optional | The change in the number of minor alerts in the queried time period |
| `Deltanoalert` | `int?` | Optional | The change in the number of sensor reports containing no alerts in the queried time period |

## Example (as JSON)

```json
{
  "critical": 0,
  "major": 0,
  "minor": 0,
  "noalert": 1,
  "total": 1,
  "deltacritical": -3,
  "deltamajor": -1,
  "deltaminor": 0,
  "deltanoalert": -15
}
```

