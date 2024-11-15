
# Security Result Exception

Error response.

## Structure

`SecurityResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[0-9]{3,3}$` |
| `ErrorMessage` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `ErrorUrl` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^https://[A-Za-z0-9].[A-Za-z]{3,64}$` |

## Example (as JSON)

```json
{
  "errorCode": "errorCode8",
  "errorMessage": "errorMessage0",
  "errorUrl": "errorUrl8"
}
```

