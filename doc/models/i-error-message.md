
# I Error Message

Error message.

## Structure

`IErrorMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | [`ErrorResponseCodeEnum?`](../../doc/models/error-response-code-enum.md) | Optional | Error Code. |
| `ErrorMessage` | `string` | Optional | Details and additional information about the error code. |
| `HttpStatusCode` | [`HttpStatusCodeEnum?`](../../doc/models/http-status-code-enum.md) | Optional | HTML error code and description. |
| `DetailErrorMessage` | `string` | Optional | More detail and information about the HTML error code. |

## Example (as JSON)

```json
{
  "errorCode": "UNAUTHORIZED",
  "httpStatusCode": "200 OK",
  "errorMessage": "errorMessage4",
  "detailErrorMessage": "detailErrorMessage6"
}
```

