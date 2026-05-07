
# Account Level Update Trigger

## Structure

`AccountLevelUpdateTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `string` | Optional | The system assigned UUID of the trigger |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `EcpdId` | `string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`TriggerCategoryEnum?`](../../doc/models/trigger-category-enum.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`DataTrigger1`](../../doc/models/data-trigger-1.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "triggerCategory": "DeviceGroupUsage",
  "dataTrigger": {
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
    "condition": "UsageAllowance",
    "action": "notify",
    "conditionType": "Aging",
    "comparitor": "eq"
  }
}
```

