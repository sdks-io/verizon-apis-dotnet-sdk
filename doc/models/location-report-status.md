
# Location Report Status

Status of the report.

## Structure

`LocationReportStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Optional | The transaction ID of the report. |
| `Status` | [`ReportStatusEnum?`](../../doc/models/report-status-enum.md) | Optional | Status of the report. |

## Example (as JSON)

```json
{
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "QUEUED"
}
```

