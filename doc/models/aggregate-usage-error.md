
# Aggregate Usage Error

Error reported by a device.

## Structure

`AggregateUsageError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Imei` | `string` | Optional | The International Mobile Equipment Identifier of the device. |
| `ErrorMessage` | `string` | Optional | A general error message. |
| `ErrorResponse` | [`IErrorMessage`](../../doc/models/i-error-message.md) | Optional | Error message. |

## Example (as JSON)

```json
{
  "imei": "15-digit IMEI",
  "errorMessage": "errorMessage4",
  "errorResponse": {
    "errorCode": "INVALID_PARAMETER",
    "errorMessage": "errorMessage4",
    "httpStatusCode": "423 LOCKED",
    "detailErrorMessage": "detailErrorMessage6"
  }
}
```

