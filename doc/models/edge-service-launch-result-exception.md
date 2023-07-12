
# Edge Service Launch Result Exception

## Structure

`EdgeServiceLaunchResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Z]{2,5}_[0-9]{3}_[0-9]{3}$` |
| `Message` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-\s]{1,64}$` |
| `RemedyMessage` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-\s]{1,64}$` |

## Example (as JSON)

```json
{
  "code": "WFDM_500_002",
  "message": "Internal server error",
  "remedyMessage": "Contact Support Team."
}
```

