
# Message 3

## Structure

`Message3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IsPrivate` | `bool` | Required | Defines whether the message is private or public.<br>Private messages are published under the Vendor ID defined in the configuration and only visible to devices of selected vendors.<br>Public messages are published under the Public vendor and are visible to all the users. |
| `RoadUserType` | [`List<RoadUserTypesEnum>`](../../doc/models/road-user-types-enum.md) | Required | Type of the Road User.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `TriggerConditions` | [`List<TriggerConditionEnum>`](../../doc/models/trigger-condition-enum.md) | Required | Trigger conditions that define on which road user action the message will be sent. If multiple Trigger Conditions are defined any of them will trigger the message.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `3` |
| `Limits` | [`List<Limits>`](../../doc/models/containers/limits.md) | Optional | List of limitations. These limitations can be used for making the trigger condition more precise by defining speed and motion direction requirements to be met before the messages are sent out.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `DistributionType` | [`List<DistributionTypesEnum>`](../../doc/models/distribution-types-enum.md) | Optional | Type of the distribution.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `DistributionSchedule` | [`DistributionSchedule`](../../doc/models/distribution-schedule.md) | Optional | The distribution schedule parameters for broadcast messages. |
| `EtsiAlert` | [`EtsiAlert`](../../doc/models/etsi-alert.md) | Required | - |

## Example (as JSON)

```json
{
  "isPrivate": false,
  "roadUserType": [
    "VulnerableRoadUser",
    "Vehicle"
  ],
  "triggerConditions": [
    "leave",
    "inside"
  ],
  "etsiAlert": {
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
  },
  "limits": [
    {
      "speed": {
        "min": 64.76,
        "max": 138.18
      }
    },
    {
      "speed": {
        "min": 64.76,
        "max": 138.18
      }
    }
  ],
  "distributionType": [
    "Broadcast"
  ],
  "distributionSchedule": {
    "repeatPeriod": 90,
    "duration": 88,
    "startTime": "2016-03-13T12:52:32.123Z"
  }
}
```

