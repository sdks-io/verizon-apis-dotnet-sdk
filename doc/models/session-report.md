
# Session Report

Session report for a device.

## Structure

`SessionReport`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The 10-digit ID of the device. |
| `Txid` | `string` | Required | A unique string (UUID) that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have a txid. |
| `Sessions` | [`List<DailyUsageItem>`](../../doc/models/daily-usage-item.md) | Optional | An object containing the start and end time of the session with the amount of data transferred. |

## Example (as JSON)

```json
{
  "id": "id4",
  "txid": "60c07fff-eeee-ffff-gggg-75e6a7c238f6",
  "sessions": [
    {
      "startTime": "startTime4",
      "endTime": "endTime8",
      "numBytes": 106
    },
    {
      "startTime": "startTime4",
      "endTime": "endTime8",
      "numBytes": 106
    }
  ]
}
```

