
# Data Trigger 1

## Structure

`DataTrigger1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - |
| `Condition` | [`DataTrigger1Condition`](../../doc/models/containers/data-trigger-1-condition.md) | Optional | This is a container for any-of cases. |
| `Action` | [`AccountLevelActionEnum?`](../../doc/models/account-level-action-enum.md) | Optional | The action taken when trigger conditions are met |
| `ConditionType` | [`ConditionTypeEnum?`](../../doc/models/condition-type-enum.md) | Optional | The condition type being monitored |
| `Comparitor` | [`ComparitorEnum?`](../../doc/models/comparitor-enum.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To |
| `Threshold` | `int?` | Optional | The threshold value the trigger monitors for |
| `ThresholdUnit` | [`ThresholdUnitEnum?`](../../doc/models/threshold-unit-enum.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `CycleType` | [`RulesCycleTypeEnum?`](../../doc/models/rules-cycle-type-enum.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly |
| `AllowanceThreshold` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - |

## Example (as JSON)

```json
{
  "action": "notify",
  "conditionType": "Aging",
  "comparitor": "gt",
  "threshold": 100,
  "thresholdUnit": "KB",
  "cycleType": "Daily",
  "filterCriteria": {
    "separateOrCombined": "separateOrCombined4",
    "accountNames": {
      "accountNameList": [
        "accountNameList7",
        "accountNameList8",
        "accountNameList9"
      ]
    }
  },
  "condition": "Aging"
}
```

