
# V2 Triggers Request

## Structure

`V2TriggersRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `EcpdId` | `string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`TriggerCategoryEnum?`](../../doc/models/trigger-category-enum.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`DataTrigger4`](../../doc/models/data-trigger-4.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `NotificationType` | `string` | Optional | - |
| `Callback` | `bool?` | Optional | - |
| `EmailNotification` | `bool?` | Optional | - |
| `NotificationGroupName` | `string` | Optional | - |
| `NotificationFrequencyFactor` | `int?` | Optional | - |
| `NotificationFrequencyInterval` | `string` | Optional | - |
| `ExternalEmailRecipients` | `string` | Optional | - |
| `SmsNotification` | `bool?` | Optional | - |
| `SmsNumbers` | [`List<V2TriggersRequestSmsNumbers>`](../../doc/models/containers/v2-triggers-request-sms-numbers.md) | Optional | This is List of a container for any-of cases. |
| `Reminder` | `bool?` | Optional | - |
| `Severity` | `string` | Optional | - |
| `Active` | [`ActiveEnum?`](../../doc/models/active-enum.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `FilterCriteria` | [`AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - |
| `Condition` | [`V2TriggersRequestCondition`](../../doc/models/containers/v2-triggers-request-condition.md) | Optional | This is a container for any-of cases. |
| `Action` | [`AccountLevelActionEnum?`](../../doc/models/account-level-action-enum.md) | Optional | The action taken when trigger conditions are met |
| `AccountName` | `string` | Optional | The numeric name of the account and must include leading zeroes |
| `PricePlanTrigger` | [`PricePlanTrigger1`](../../doc/models/price-plan-trigger-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "notificationType": "PerEvent",
  "callback": true,
  "emailNotification": false,
  "notificationGroupName": "Notification Group Name (User defined)",
  "notificationFrequencyFactor": 3,
  "notificationFrequencyInterval": "Daily",
  "externalEmailRecipients": "Email addresses",
  "smsNotification": true,
  "reminder": true,
  "severity": "Notify",
  "active": "true",
  "action": "notify",
  "accountName": "0000123456-00001",
  "triggerCategory": "DeviceGroupUsage",
  "dataTrigger": {
    "accountLevel": {
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
      "condition": "Individual",
      "action": "suspend"
    },
    "deviceGroup": {
      "filterCriteria": {
        "deviceGroupName": "deviceGroupName4",
        "IndividualOrCombined": "IndividualOrCombined4",
        "accountName": "accountName0"
      }
    },
    "conditionType": "Aging",
    "comparitor": "eq",
    "threshold": 222
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

