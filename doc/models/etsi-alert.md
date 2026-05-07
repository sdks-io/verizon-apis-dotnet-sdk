
# Etsi Alert

## Structure

`EtsiAlert`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Header` | [`Header`](../../doc/models/header.md) | Required | The header of the DENM PDU. |
| `Denm` | [`DenmPayload`](../../doc/models/denm-payload.md) | Required | The payload of the DENM PDU. |

## Example (as JSON)

```json
{
  "header": {
    "protocolVersion": 2,
    "messageId": 1,
    "stationId": 12345
  },
  "denm": {
    "management": {
      "actionId": {
        "originatingStationId": 28,
        "sequenceNumber": 42
      },
      "detectionTime": 123456789,
      "referenceTime": 123456789,
      "eventPosition": {
        "latitude": 198,
        "longitude": 234,
        "positionConfidenceEllipse": {
          "semiMajorConfidence": 16,
          "semiMinorConfidence": 114,
          "semiMajorOrientation": 100
        },
        "altitude": {
          "altitudeValue": 236,
          "altitudeConfidence": "alt-000-01"
        }
      },
      "stationType": 148,
      "awarenessDistance": "lessThan50m"
    },
    "situation": {
      "informationQuality": 7,
      "eventType": {
        "ccAndScc": {
          "trafficCondition1": 0
        }
      }
    }
  }
}
```

