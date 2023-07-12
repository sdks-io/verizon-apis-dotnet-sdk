
# Usage Trigger Response

## Structure

`UsageTriggerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `string` | Required | Unique usage triggerId |
| `TriggerName` | `string` | Required | Usage trigger name |
| `AccountName` | `string` | Required | Account name |
| `ServiceName` | [`Models.ServiceNameEnum`](../../doc/models/service-name-enum.md) | Required | Service name<br>**Default**: `ServiceNameEnum.Location` |
| `ThresholdValue` | `string` | Required | Percent of subscription at which trigger will send an alert |
| `AllowExcess` | `bool` | Required | allowExcess determines whether to restrict usage after exceeds limits |
| `SendSmsNotification` | `bool` | Required | Send SMS (text) alerts when the thresholdValue is reached. |
| `SmsPhoneNumbers` | `string` | Required | comma seperated value of list of Phone numbers for SMS notifications |
| `SendEmailNotification` | `bool` | Required | Send email alerts when the thresholdValue is reached. |
| `EmailAddresses` | `string` | Required | comma seperated value of list of Email addresses for Email notifications |
| `CreateDate` | `string` | Required | UTC Date when the usage trigger was created |
| `UpdateDate` | `string` | Required | UTC Date when the usage trigger was last updated |

## Example (as JSON)

```json
{
  "triggerId": "3bb4777e-5292-4de7-97df-f578df4a2dbe",
  "triggerName": "95% usage alert",
  "accountName": "0212312345-00001",
  "serviceName": "Location",
  "thresholdValue": "95",
  "allowExcess": false,
  "sendSmsNotification": false,
  "smsPhoneNumbers": "5551231234",
  "sendEmailNotification": false,
  "emailAddresses": "me@theinternet.com, you@theinternet.com",
  "createDate": "2018-08-31",
  "updateDate": "2018-09-03"
}
```

