
# Usage Trigger Add Request

## Structure

`UsageTriggerAddRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | Usage trigger name |
| `AccountName` | `string` | Required | Account name |
| `ServiceName` | [`ServiceNameEnum`](../../doc/models/service-name-enum.md) | Required | Service name<br>**Default**: `ServiceNameEnum.Location` |
| `ThresholdValue` | `string` | Required | The percent of subscribed usage required to activate the trigger, such as 90 or 100. |
| `AllowExcess` | `bool?` | Optional | Allow additional requests after thresholdValue is reached. (currently not functional) |
| `SendSmsNotification` | `bool?` | Optional | Send SMS (text) alerts when the thresholdValue is reached. |
| `SmsPhoneNumbers` | `string` | Optional | Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc. |
| `SendEmailNotification` | `bool?` | Optional | Send email alerts when the thresholdValue is reached. |
| `EmailAddresses` | `string` | Optional | Comma-separated list of email addresses to send alerts to. |

## Example (as JSON)

```json
{
  "triggerName": "95% usage alert",
  "accountName": "0212312345-00001",
  "serviceName": "Location",
  "thresholdValue": "95",
  "smsPhoneNumbers": "5551231234",
  "emailAddresses": "you@theinternet.com",
  "allowExcess": false,
  "sendSmsNotification": false,
  "sendEmailNotification": false
}
```

