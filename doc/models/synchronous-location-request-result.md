
# Synchronous Location Request Result

## Structure

`SynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Required | The transaction ID of the report. |
| `Status` | [`ReportStatusEnum`](../../doc/models/report-status-enum.md) | Required | Status of the report. |

## Example (as JSON)

```json
{
  "txid": "4be7c858-eeee-ffff-gggg-95061456d835",
  "status": "QUEUED"
}
```

