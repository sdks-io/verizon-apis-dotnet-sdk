
# Trigger Attributes Options

## Structure

`TriggerAttributesOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Optional | If present, the NotificationGroupName will be listed here. |
| `MValue` | `bool?` | Optional | DataPercentage50<br />True - Trigger on Data percentage is over 50% used<br />False - Do not trigger when over 50% used. |

## Example (as JSON)

```json
{
  "key": "DataPercentage50",
  "value": false
}
```

