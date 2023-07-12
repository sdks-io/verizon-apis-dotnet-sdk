
# Resource Base

Resource Base of the service.

## Structure

`ResourceBase`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Unit` | `string` | Optional | Resource unit ex :MB.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]!,+\-=_:.&*%\s]+$` |
| `MValue` | `long?` | Optional | Resource value e.g. 200MB.<br>**Constraints**: `>= 0`, `<= 1024` |
| `Max` | `long?` | Optional | Resource max value e.g. 400MB.<br>**Constraints**: `>= 0`, `<= 1024` |
| `Min` | `long?` | Optional | Resource min value e.g. 10MB.<br>**Constraints**: `>= 0`, `<= 1024` |

## Example (as JSON)

```json
{
  "unit": "MB",
  "value": 200,
  "max": 400,
  "min": 10
}
```

