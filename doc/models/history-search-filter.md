
# History Search Filter

The selected device and attributes for which a request should retrieve data.

## Structure

`HistorySearchFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account name identifier. |
| `Device` | [`Models.Device`](../../doc/models/device.md) | Required | Identifies a particular IoT device. |
| `Attributes` | [`Models.HistorySearchFilterAttributes`](../../doc/models/history-search-filter-attributes.md) | Optional | Streaming RF parameters for which you want to retrieve history data. |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "device": {
    "id": "15-digit IMEI",
    "kind": "IMEI"
  },
  "attributes": {
    "name": "LINK_QUALITY"
  }
}
```

