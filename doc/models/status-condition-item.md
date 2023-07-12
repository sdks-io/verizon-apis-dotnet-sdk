
# Status Condition Item

## Structure

`StatusConditionItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `LastHeartbeatTime` | `DateTime?` | Optional | - |
| `LastTransitionTime` | `DateTime?` | Optional | - |
| `Reason` | `string` | Optional | - |
| `Message` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "lastHeartbeatTime": "08/19/2022 13:07:42",
  "lastTransitionTime": "08/19/2022 13:07:42",
  "type": "type0",
  "status": "status8",
  "reason": "reason4"
}
```

