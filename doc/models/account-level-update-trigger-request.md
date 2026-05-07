
# Account Level Update Trigger Request

## Structure

`AccountLevelUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `string` | Optional | The system assigned UUID of the trigger |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `EcpdId` | `string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`TriggerCategoryEnum?`](../../doc/models/trigger-category-enum.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`DataTrigger1`](../../doc/models/data-trigger-1.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `NotificationType` | `string` | Optional | - |
| `Callback` | `bool?` | Optional | - |
| `EmailNotification` | `bool?` | Optional | - |
| `NotificationGroupName` | `string` | Optional | - |
| `NotificationFrequencyFactor` | `int?` | Optional | - |
| `NotificationFrequencyInterval` | `string` | Optional | - |
| `ExternalEmailRecipients` | `string` | Optional | - |
| `SmsNotification` | `bool?` | Optional | - |
| `SmsNumbers` | [`List<AccountLevelUpdateTriggerRequestSmsNumbers>`](../../doc/models/containers/account-level-update-trigger-request-sms-numbers.md) | Optional | This is List of a container for any-of cases. |
| `Reminder` | `bool?` | Optional | - |
| `Severity` | `string` | Optional | - |
| `Active` | [`ActiveEnum?`](../../doc/models/active-enum.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
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

