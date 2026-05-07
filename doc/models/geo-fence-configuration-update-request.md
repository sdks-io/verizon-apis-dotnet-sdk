
# Geo Fence Configuration Update Request

Request for /api/v1/application/configurations/geofence PUT endpoint. It requires at least one of vendorId, name, description, geofence, messages and isActive fields to be populated.

## Structure

`GeoFenceConfigurationUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `Description` | `string` | Optional | Description of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `GeoFence` | [`EtxGeoFence`](../../doc/models/etx-geo-fence.md) | Optional | The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration. |
| `MessageStandard` | [`MessageStandardEnum?`](../../doc/models/message-standard-enum.md) | Optional | Select which V2X messaging standard will be used for the message generation. The following options are supported:<br><br>- "etsi": The message will be generated using the ETSI (European) standard (e.g. DENM).<br>- "sae": The message will be generated using the SAE J2735 (North American) standard (e.g. RSA, TIM).<br>- if not sent while POST, defaults to "sae"<br>- mandatory to send "etsi" standard here, if ETSI messages are being sent in config<br><br>**Default**: `MessageStandardEnum.sae` |
| `Messages` | [`List<Message4>`](../../doc/models/containers/message-4.md) | Optional | List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `IsActive` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "messageStandard": "sae",
  "name": "name4",
  "description": "description4",
  "geoFence": {
    "type": "FeatureCollection",
    "features": [
      {
        "type": "Feature",
        "geometry": {
          "type": "LineString",
          "coordinates": [
            [
              51.53,
              51.54
            ],
            [
              51.53,
              51.54
            ]
          ]
        },
        "properties": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ]
  },
  "messages": [
    {
      "isPrivate": false,
      "roadUserType": [
        "VulnerableRoadUser"
      ],
      "triggerConditions": [
        "crossing"
      ],
      "limits": [
        {
          "speed": {
            "min": 64.76,
            "max": 138.18
          }
        }
      ],
      "distributionType": [
        "Broadcast",
        "Targeted"
      ],
      "distributionSchedule": {
        "repeatPeriod": 90,
        "duration": 88,
        "startTime": "2016-03-13T12:52:32.123Z"
      },
      "generic": {
        "messageType": "messageType4",
        "messageFormat": "messageFormat6",
        "payload": "payload0"
      }
    }
  ]
}
```

