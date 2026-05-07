
# Dto Get Network Health Score Response

The values measured are for the network

## Structure

`DtoGetNetworkHealthScoreResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Networksummary` | [`List<DtoHealthScoreMetric>`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `Overallsummary` | [`List<DtoHealthScoreMetric>`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "networksummary": [
    {
      "metrictype": "networkscore",
      "metricvalue": "95"
    }
  ],
  "overallsummary": [
    {
      "metrictype": "metrictype0",
      "metricvalue": "metricvalue6"
    }
  ]
}
```

