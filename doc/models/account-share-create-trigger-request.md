
# Account Share Create Trigger Request

## Structure

`AccountShareCreateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `EcpdId` | `string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`TriggerCategoryEnum?`](../../doc/models/trigger-category-enum.md) | Optional | The type of trigger being created or modified |
| `PricePlanTrigger` | [`AccountSharePricePlanTrigger`](../../doc/models/account-share-price-plan-trigger.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `Active` | [`ActiveEnum?`](../../doc/models/active-enum.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

## Example (as JSON)

```json
{
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "active": "true",
  "triggerCategory": "DeviceGroupUsage",
  "pricePlanTrigger": {
    "accountShare": {
      "filterCriteria": {
        "carrierServicePlanCode": "carrierServicePlanCode4",
        "accountNameList": [
          "accountNameList7",
          "accountNameList8"
        ]
      }
    },
    "condition": "Aging",
    "changePlan": false,
    "changePlanDetails": {
      "toCarrierServicePlanCode": "toCarrierServicePlanCode2"
    }
  },
  "notification": {
    "notificationType": "notificationType8",
    "callback": false,
    "emailNotification": false,
    "notificationGroupName": "notificationGroupName6",
    "notificationFrequencyFactor": 22
  }
}
```

