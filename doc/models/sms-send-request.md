
# SMS Send Request

Request to send SMS.

## Structure

`SMSSendRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The name of a billing account. |
| `CustomFields` | [`List<Models.CustomFields>`](../../doc/models/custom-fields.md) | Optional | The names and values of custom fields, if you want to only include devices that have matching custom fields. |
| `DataEncoding` | `string` | Optional | The SMS message encoding, which can be 7-bit (default), 8-bit-ASCII, 8-bit-UTF-8, 8-bit-DATA. |
| `DeviceIds` | [`List<Models.DeviceId>`](../../doc/models/device-id.md) | Optional | The devices that you want to send the message to, specified by device identifier. |
| `GroupName` | `string` | Optional | The name of a device group, if you want to send the SMS message to all devices in the device group. |
| `ServicePlan` | `string` | Optional | The name of a service plan, if you want to only include devices that have that service plan. |
| `SmsMessage` | `string` | Optional | The contents of the SMS message. The SMS message is limited to 160 characters in 7-bit format, or 140 characters in 8-bit format. |

## Example (as JSON)

```json
{
  "smsMessage": "The rain in Spain stays mainly in the plain.",
  "accountName": "accountName4",
  "customFields": [
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key1",
      "value": "value3"
    },
    {
      "key": "key2",
      "value": "value4"
    }
  ],
  "dataEncoding": "dataEncoding8",
  "deviceIds": [
    {
      "id": "id0",
      "kind": "kind8"
    },
    {
      "id": "id1",
      "kind": "kind9"
    },
    {
      "id": "id2",
      "kind": "kind0"
    }
  ],
  "groupName": "groupName0"
}
```

