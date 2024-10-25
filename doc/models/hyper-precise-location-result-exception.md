
# Hyper Precise Location Result Exception

Error response.

## Structure

`HyperPreciseLocationResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResponseCode` | [`ErrorResponseCodeEnum?`](../../doc/models/error-response-code-enum.md) | Optional | Error Code. |
| `Message` | `string` | Optional | Error message. |
| `Fault` | [`HyperPreciseLocationFault`](../../doc/models/hyper-precise-location-fault.md) | Optional | Fault occurred while responding. |

## Example (as JSON)

```json
{
  "responseCode": "INVALID_ACCESS",
  "fault": {
    "code": "900906",
    "message": "No matching resource found in the API for the given request",
    "description": "Access failure for API. Check the API documentation and add a proper REST resource path to the invocation URL."
  },
  "message": "message4"
}
```

