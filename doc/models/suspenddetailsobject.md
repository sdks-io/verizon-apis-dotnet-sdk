
# Suspenddetailsobject

## Structure

`Suspenddetailsobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuspendFromAccounts` | `List<string>` | Optional | - |
| `SuspendDuration` | `int?` | Optional | - |
| `SuspendOption` | `string` | Optional | - |
| `Threshold` | `int?` | Optional | The threshold value the trigger monitors for |
| `ThresholdUnit` | [`ThresholdUnitEnum?`](../../doc/models/threshold-unit-enum.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |

## Example (as JSON)

```json
{
  "suspendDuration": 90,
  "suspendOption": "withBilling",
  "threshold": 100,
  "thresholdUnit": "KB",
  "suspendFromAccounts": [
    "suspendFromAccounts7",
    "suspendFromAccounts8",
    "suspendFromAccounts9"
  ]
}
```

