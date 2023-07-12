
# MEC Performance Metrics

Response to query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.

## Structure

`MECPerformanceMetrics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QueryStatus` | `string` | Optional | Success or Failed. |
| `Start` | `string` | Optional | Timestamp of the query's start, format:mm/dd/yyyy,hr:min:sec. |
| `End` | `string` | Optional | Timestamp of the query's end , format:mm/dd/yyyy, hr:min:sec. |
| `QueryResult` | [`List<Models.MECPerformanceQueryResult>`](../../doc/models/mec-performance-query-result.md) | Optional | MEC performance query result. |

## Example (as JSON)

```json
{
  "QueryStatus": "Success",
  "Start": "1/28/2021 12:00:00",
  "End": "1/28/2021 12:15:00",
  "QueryResult": [
    {
      "name": "NetworkAvailability",
      "data": [
        "100",
        "percent",
        "high"
      ]
    }
  ]
}
```

