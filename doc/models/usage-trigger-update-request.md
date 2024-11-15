
# Usage Trigger Update Request

## Structure

`UsageTriggerUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | Usage trigger name |
| `AccountName` | `string` | Required | Account name |
| `ThresholdValue` | `string` | Optional | The percent of subscribed usage required to activate the trigger, such as 90 or 100. |
| `SmsPhoneNumbers` | `string` | Optional | Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc. |
| `EmailAddresses` | `string` | Optional | Comma-separated list of email addresses to send alerts to. |

## Example (as JSON)

```json
{
  "triggerName": "95% usage alert",
  "accountName": "0212312345-00001",
  "thresholdValue": "95",
  "smsPhoneNumbers": "5551231234",
  "emailAddresses": "me@theinternet.com, you@theinternet.com"
}
```

