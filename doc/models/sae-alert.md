
# Sae Alert

## Structure

`SaeAlert`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MsgCnt` | `int?` | Optional | It is used to provide a sequence number within a stream of messages with the same DSRCmsgID (here RoadSideAlert) and from the same sender.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0`, `<= 127` |
| `TypeEvent` | `int` | Required | The ITIS Code that describes the alert/danger/hazard. All ITS standards use the same types here to explain the type of the alert/danger/hazard involved.<br><br>The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard. This is a set of over 1000 items which are used to encode common events and list items in ITS.<br><br>**Constraints**: `>= 0`, `<= 65535` |
| `Description` | `List<int>` | Optional | ITIS code set entries to further describe the event, give advice, or any other ITIS codes related to the event/danger/hazard.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `8`, `>= 0`, `<= 65535` |

## Example (as JSON)

```json
{
  "msgCnt": 0,
  "typeEvent": 68,
  "description": [
    229,
    228
  ]
}
```

