
# Api Response Code

ResponseCode and/or a message indicating success or failure of the request.

## Structure

`ApiResponseCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResponseCode` | [`ResponseCodeEnum`](../../doc/models/response-code-enum.md) | Required | Possible response codes. |
| `Message` | `string` | Required | More details about the responseCode received. |

## Example (as JSON)

```json
{
  "responseCode": "INVALID_ACCESS",
  "message": "message4"
}
```

