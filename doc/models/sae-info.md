
# Sae Info

## Structure

`SaeInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MsgCnt` | `int?` | Optional | It is used to provide a sequence number within a stream of messages with the same DSRCmsgID (here RoadSideAlert) and from the same sender.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0`, `<= 127` |
| `TimeStamp` | `int?` | Optional | The number of elapsed minutes of the current year in the time system being used (typically UTC time).<br>-- the value 527040 shall be used for invalid<br><br>**Constraints**: `>= 0`, `<= 527040` |
| `PacketID` | `string` | Optional | Provides a relatively unique value which can be used to connect to (link to) other supporting messages in other formats.<br><br>The value is described as a 18-character hexadecimal string.<br><br>**Constraints**: *Pattern*: `^[0-9A-Fa-f]{18}$` |
| `UrlB` | `string` | Optional | A valid internet style URI/URL in the form of a text string which will form the base of a compound string which, when<br>combined with the URL-short data element, will link to the designated resource.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `45` |
| `DataFrames` | [`List<DataFrame>`](../../doc/models/data-frame.md) | Required | List of data frames.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `8` |

## Example (as JSON)

```json
{
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
}
```

