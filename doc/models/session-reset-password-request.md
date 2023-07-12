
# Session Reset Password Request

Request to a new, randomly generated password for the current username.

## Structure

`SessionResetPasswordRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OldPassword` | `string` | Optional | The current password for the username. |

## Example (as JSON)

```json
{
  "oldPassword": "grflbk"
}
```

