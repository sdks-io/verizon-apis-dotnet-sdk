
# Dto Health Score Summary

The values measured are for sensors and gateways

## Structure

`DtoHealthScoreSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Overallsummary` | [`List<DtoHealthScoreMetric>`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "overallsummary": [
    {
      "metrictype": "metrictype0",
      "metricvalue": "metricvalue6"
    }
  ]
}
```

