
# Aggregate Session Report

Session and usage details for up to 10 devices.

## Structure

`AggregateSessionReport`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Optional | A unique string (UUID) that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have a txid. |
| `Usage` | [`List<AggregateUsageItem>`](../../doc/models/aggregate-usage-item.md) | Optional | Contains usage per device.<br><br>**Constraints**: *Unique Items Required* |
| `Errors` | [`List<AggregateUsageError>`](../../doc/models/aggregate-usage-error.md) | Optional | An object containing any errors reported by the device.<br><br>**Constraints**: *Unique Items Required* |

## Example (as JSON)

```json
{
  "txid": "60c07fff-eeee-ffff-gggg-75e6a7c238f6",
  "usage": [
    {
      "imei": "15-digit IMEI",
      "numberOfSessions": 1,
      "bytesTransferred": 2057
    }
  ],
  "errors": [
    {
      "imei": "imei6",
      "errorMessage": "errorMessage8",
      "errorResponse": {
        "errorCode": "INVALID_PARAMETER",
        "errorMessage": "errorMessage4",
        "httpStatusCode": "423 LOCKED",
        "detailErrorMessage": "detailErrorMessage6"
      }
    }
  ]
}
```

