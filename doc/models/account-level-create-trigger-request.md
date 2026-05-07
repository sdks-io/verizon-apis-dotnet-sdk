
# Account Level Create Trigger Request

## Structure

`AccountLevelCreateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `EcpdId` | `string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`TriggerCategoryEnum?`](../../doc/models/trigger-category-enum.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`DataTrigger`](../../doc/models/data-trigger.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `NotificationType` | `string` | Optional | - |
| `Callback` | `bool?` | Optional | - |
| `EmailNotification` | `bool?` | Optional | - |
| `NotificationGroupName` | `string` | Optional | - |
| `NotificationFrequencyFactor` | `int?` | Optional | - |
| `NotificationFrequencyInterval` | `string` | Optional | - |
| `ExternalEmailRecipients` | `string` | Optional | - |
| `SmsNotification` | `bool?` | Optional | - |
| `SmsNumbers` | [`List<AccountLevelCreateTriggerRequestSmsNumbers>`](../../doc/models/containers/account-level-create-trigger-request-sms-numbers.md) | Optional | This is List of a container for any-of cases. |
| `Reminder` | `bool?` | Optional | - |
| `Severity` | `string` | Optional | - |
| `Active` | [`ActiveEnum?`](../../doc/models/active-enum.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

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
  "triggerCategory": "AccountUsage",
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

