
# Billable Usage Report

Bill usage report.

## Structure

`BillableUsageReport`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account identifier. |
| `UsageForAllAccounts` | `bool?` | Optional | The usage is for a single or multiple accounts. |
| `SkuName` | `string` | Optional | SKU Name of the service subscription. |
| `TransactionsAllowed` | `string` | Optional | The number of location requests included with the subscription type. |
| `TotalTransactionCount` | `string` | Optional | The total number of billable device location requests during the reporting period from all included accounts. |
| `PrimaryAccount` | [`ServiceUsage`](../../doc/models/service-usage.md) | Optional | - |
| `ManagedAccounts` | [`List<ServiceUsage>`](../../doc/models/service-usage.md) | Optional | Zero or more managed accounts. |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "usageForAllAccounts": false,
  "skuName": "TS-LOC-COARSE-CellID-Aggr",
  "transactionsAllowed": "5000",
  "totalTransactionCount": "350",
  "PrimaryAccount": {
    "accountName": "1223334444-00001",
    "transactionsCount": "125"
  },
  "ManagedAccounts": []
}
```

