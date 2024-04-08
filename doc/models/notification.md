
# Notification

The notification details of the trigger.

## Structure

`Notification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NotificationType` | `string` | Optional | The type of notification, i.e. 'DailySummary'. |
| `Callback` | `bool?` | Optional | Whether or not the notification should be sent via callback.<br />true<br />false. |
| `EmailNotification` | `bool?` | Optional | Whether or not the notification should be sent via e-mail.<br />true<br />false. |
| `NotificationGroupName` | `string` | Optional | Name for the notification group. |
| `NotificationFrequencyFactor` | `int?` | Optional | Frequency factor for notification. |
| `NotificationFrequencyInterval` | `string` | Optional | Frequency interval for notification. |
| `ExternalEmailRecipients` | `string` | Optional | E-mail address(es) where the notification should be delivered. |
| `SmsNotification` | `bool?` | Optional | SMS notification. |
| `SmsNumbers` | [`List<SMSNumber>`](../../doc/models/sms-number.md) | Optional | List of SMS numbers.<br>**Constraints**: *Maximum Items*: `10` |
| `Reminder` | `bool?` | Optional | - |
| `Severity` | `string` | Optional | Severity level associated with the notification. Examples would be:<br />Major<br />Minor<br />Critical<br />NotApplicable. |

## Example (as JSON)

```json
{
  "notificationType": "DailySummary",
  "callback": true,
  "emailNotification": false,
  "notificationGroupName": "Anomaly Test API",
  "notificationFrequencyFactor": 3,
  "notificationFrequencyInterval": "Hourly",
  "externalEmailRecipients": "placeholder@verizon.com",
  "smsNotification": true,
  "smsNumbers": [
    {
      "carrier": "US Cellular",
      "number": "9299280711"
    }
  ],
  "reminder": true,
  "severity": "Critical"
}
```

