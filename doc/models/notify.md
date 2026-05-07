
# Notify

## Structure

`Notify`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AlertType` | `string` | Optional | - |
| `Threshold` | [`List<NotifyThreshold>`](../../doc/models/containers/notify-threshold.md) | Optional | This is List of a container for any-of cases. |

## Example (as JSON)

```json
{
  "alertType": "individualpriceplan",
  "threshold": [
    {
      "carrierCode": "carrierCode4",
      "percentage": {
        "percentage50": false,
        "percentage75": false,
        "percentage90": false,
        "percentage100": false
      }
    },
    {
      "carrierCode": "carrierCode4",
      "percentage": {
        "percentage50": false,
        "percentage75": false,
        "percentage90": false,
        "percentage100": false
      }
    },
    {
      "carrierCode": "carrierCode4",
      "percentage": {
        "percentage50": false,
        "percentage75": false,
        "percentage90": false,
        "percentage100": false
      }
    }
  ]
}
```

