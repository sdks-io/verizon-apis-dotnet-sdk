
# Data Trigger Request

## Structure

`DataTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Comparator` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Threshold` | `int?` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `ThresholdUnit` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Example (as JSON)

```json
{
  "comparator": "comparator0",
  "threshold": 22,
  "thresholdUnit": "thresholdUnit8"
}
```

