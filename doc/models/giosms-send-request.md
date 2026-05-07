
# GIOSMS Send Request

## Structure

`GIOSMSSendRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `CustomFields` | [`List<KvPair>`](../../doc/models/kv-pair.md) | Optional | **Constraints**: *Maximum Items*: `5` |
| `DataEncoding` | `string` | Optional | - |
| `GroupName` | `string` | Optional | - |
| `ServicePlan` | `string` | Optional | - |
| `TimeToLive` | `string` | Optional | A period of time the message remains valid or an end date for the message. This value would be less than the 5 day default. |
| `DeviceIds` | [`List<GIODeviceId>`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `SmsMessage` | `string` | Required | - |

## Example (as JSON)

```json
{
  "smsMessage": "A text message",
  "accountName": "accountName2",
  "customFields": [
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key0",
      "value": "value2"
    }
  ],
  "dataEncoding": "dataEncoding0",
  "groupName": "groupName2",
  "servicePlan": "servicePlan2"
}
```

