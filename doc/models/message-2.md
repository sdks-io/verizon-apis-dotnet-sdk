
# Message 2

## Structure

`Message2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IsPrivate` | `bool` | Required | Defines whether the message is private or public.<br>Private messages are published under the Vendor ID defined in the configuration and only visible to devices of selected vendors.<br>Public messages are published under the Public vendor and are visible to all the users. |
| `RoadUserType` | [`List<RoadUserTypesEnum>`](../../doc/models/road-user-types-enum.md) | Required | Type of the Road User.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `TriggerConditions` | [`List<TriggerConditionEnum>`](../../doc/models/trigger-condition-enum.md) | Required | Trigger conditions that define on which road user action the message will be sent. If multiple Trigger Conditions are defined any of them will trigger the message.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `3` |
| `Limits` | [`List<Limits>`](../../doc/models/containers/limits.md) | Optional | List of limitations. These limitations can be used for making the trigger condition more precise by defining speed and motion direction requirements to be met before the messages are sent out.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `DistributionType` | [`List<DistributionTypesEnum>`](../../doc/models/distribution-types-enum.md) | Optional | Type of the distribution.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `DistributionSchedule` | [`DistributionSchedule`](../../doc/models/distribution-schedule.md) | Optional | The distribution schedule parameters for broadcast messages. |
| `SaeInfo` | [`SaeInfo`](../../doc/models/sae-info.md) | Required | - |

## Example (as JSON)

```json
{
  "isPrivate": false,
  "roadUserType": [
    "VulnerableRoadUser",
    "Vehicle"
  ],
  "triggerConditions": [
    "crossing",
    "enter",
    "leave"
  ],
  "saeInfo": {
    "msgCnt": 0,
    "timeStamp": 5,
    "packetID": "B343B343B343B343A5",
    "urlB": "http://example.com",
    "dataFrames": [
      {
        "doNotUse1": 0,
        "frameType": "unknown",
        "msgId": {
          "furtherInfoID": "1101"
        },
        "startTime": 186,
        "durationTime": 44,
        "priority": 7,
        "doNotUse2": 0,
        "regions": [
          {
            "description": {
              "path": {
                "offset": {
                  "ll": {
                    "nodes": [
                      {
                        "delta": {
                          "node-LatLon": {
                            "lon": 40,
                            "lat": 10
                          }
                        }
                      },
                      {
                        "delta": {
                          "node-LatLon": {
                            "lon": 40,
                            "lat": 10
                          }
                        }
                      }
                    ]
                  }
                }
              }
            },
            "direction": "direction6"
          }
        ],
        "doNotUse3": 0,
        "doNotUse4": 0,
        "content": {
          "advisory": [
            {
              "item": {
                "itis": 10
              }
            },
            {
              "item": {
                "itis": 10
              }
            },
            {
              "item": {
                "itis": 10
              }
            }
          ]
        },
        "startYear": 12
      }
    ]
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
    },
    {
      "speed": {
        "min": 64.76,
        "max": 138.18
      }
    }
  ],
  "distributionType": [
    "Broadcast",
    "Targeted",
    "Broadcast"
  ],
  "distributionSchedule": {
    "repeatPeriod": 90,
    "duration": 88,
    "startTime": "2016-03-13T12:52:32.123Z"
  }
}
```

