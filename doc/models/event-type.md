
# Event Type

The type of event including direct and sub cause.

## Structure

`EventType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CcAndScc` | [`CauseCodeChoice6`](../../doc/models/containers/cause-code-choice-6.md) | Optional | The main cause of a detected event. Each entry is of a different type and represents the sub cause code. |

## Example (as JSON)

```json
{
  "ccAndScc": {
    "trafficCondition1": 0
  }
}
```

