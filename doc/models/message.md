
# Message

## Structure

`Message`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IsPrivate` | `bool` | Required | Defines whether the message is private or public.<br>Private messages are published under the Vendor ID defined in the configuration and only visible to devices of selected vendors.<br>Public messages are published under the Public vendor and are visible to all the users. |
| `RoadUserType` | [`List<RoadUserTypesEnum>`](../../doc/models/road-user-types-enum.md) | Required | Type of the Road User.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `TriggerConditions` | [`List<TriggerConditionEnum>`](../../doc/models/trigger-condition-enum.md) | Required | Trigger conditions that define on which road user action the message will be sent. If multiple Trigger Conditions are defined any of them will trigger the message.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `3` |
| `Limits` | [`List<Limits>`](../../doc/models/containers/limits.md) | Optional | List of limitations. These limitations can be used for making the trigger condition more precise by defining speed and motion direction requirements to be met before the messages are sent out.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `DistributionType` | [`List<DistributionTypesEnum>`](../../doc/models/distribution-types-enum.md) | Optional | Type of the distribution.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` |
| `DistributionSchedule` | [`DistributionSchedule`](../../doc/models/distribution-schedule.md) | Optional | The distribution schedule parameters for broadcast messages. |
| `Generic` | [`Generic`](../../doc/models/generic.md) | Required | Custom message which is defined by the user and can support "any" message type or format.<br><br>**Note:** ETX prefers the j2735 or the j2735_gr encoding and only vendor specific message types are allowed to be published in different message formats. |

## Example (as JSON)

```json
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
```

