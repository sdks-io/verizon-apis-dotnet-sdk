
# Position Error

Position error.

## Structure

`PositionError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `string` | Optional | Time location obtained. |
| `Utcoffset` | `string` | Optional | UTC offset of time. |
| `Type` | `string` | Optional | Error type returned from location server. |
| `Info` | `string` | Optional | Additional information about the error. |

## Example (as JSON)

```json
{
  "time": "20170525214342",
  "type": "POSITION METHOD FAILURE",
  "info": "Exception code=ABSENT SUBSCRIBER",
  "utcoffset": "utcoffset0"
}
```

