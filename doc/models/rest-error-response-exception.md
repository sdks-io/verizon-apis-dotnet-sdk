
# Rest Error Response Exception

## Structure

`RestErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Optional | **Constraints**: *Maximum Length*: `3`, *Pattern*: `^[0-9]{3}$` |
| `ErrorMessage` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "400",
  "errorMessage": "a description of the error"
}
```

