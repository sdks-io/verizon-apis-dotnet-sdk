
# Asynchronous Location Request Result

## Structure

`AsynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Optional | The transaction ID of the report. |
| `Status` | [`ReportStatusEnum?`](../../doc/models/report-status-enum.md) | Optional | Status of the report. |
| `EstimatedDuration` | `string` | Optional | Estimated number of minutes required to complete the report. |

## Example (as JSON)

```json
{
  "txid": "2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9",
  "status": "COMPLETED",
  "estimatedDuration": "estimatedDuration2"
}
```

