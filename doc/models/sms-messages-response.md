
# Sms Messages Response

## Structure

`SmsMessagesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Messages` | [`List<SmsMessagesResponseMessages>`](../../doc/models/containers/sms-messages-response-messages.md) | Optional | This is List of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `5` |
| `HasMoreData` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "hasMoreData": false,
  "messages": [
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        }
      ],
      "message": "message4",
      "timestamp": "2016-03-13T12:52:32.123Z"
    },
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        }
      ],
      "message": "message4",
      "timestamp": "2016-03-13T12:52:32.123Z"
    }
  ]
}
```

