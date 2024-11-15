
# Notification

## Structure

`Notification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NotificationType` | `string` | Optional | - |
| `Callback` | `bool?` | Optional | - |
| `EmailNotification` | `bool?` | Optional | - |
| `NotificationGroupName` | `string` | Optional | - |
| `NotificationFrequencyFactor` | `int?` | Optional | - |
| `NotificationFrequencyInterval` | `string` | Optional | - |
| `ExternalEmailRecipients` | `string` | Optional | - |
| `SmsNotification` | `bool?` | Optional | - |
| `SmsNumbers` | [`List<SmsNumbers>`](../../doc/models/sms-numbers.md) | Optional | - |
| `Reminder` | `bool?` | Optional | - |
| `Severity` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "notificationType": "notificationType2",
  "callback": false,
  "emailNotification": false,
  "notificationGroupName": "notificationGroupName2",
  "notificationFrequencyFactor": 214
}
```

