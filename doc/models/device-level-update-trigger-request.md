
# Device Level Update Trigger Request

## Structure

`DeviceLevelUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `string` | Optional | The system assigned UUID of the trigger |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `EcpdId` | `string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`TriggerCategoryEnum?`](../../doc/models/trigger-category-enum.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`DataTrigger2`](../../doc/models/data-trigger-2.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `Active` | [`ActiveEnum?`](../../doc/models/active-enum.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "active": "true",
  "triggerCategory": "PricePlanDataUsage",
  "dataTrigger": {
    "deviceGroup": {
      "filterCriteria": {
        "deviceGroupName": "deviceGroupName4",
        "IndividualOrCombined": "IndividualOrCombined4",
        "accountName": "accountName0"
      }
    },
    "conditionType": "Aging",
    "comparitor": "eq",
    "threshold": 222,
    "thresholdUnit": "MB"
  }
}
```

