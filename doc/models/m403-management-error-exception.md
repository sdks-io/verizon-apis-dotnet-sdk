
# M403 Management Error Exception

## Structure

`M403ManagementErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Optional | - |
| `ErrorDescription` | `string` | Optional | **Constraints**: *Maximum Length*: `1000` |
| `Cause` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "error": "Error name or code",
  "error_description": "A longer error description.",
  "cause": "A cause for the error"
}
```

