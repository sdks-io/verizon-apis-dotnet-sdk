
# Retrieve Response Item

## Structure

`RetrieveResponseItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Imei` | `string` | Optional | - |
| `Username` | `string` | Optional | Present if credentials exist |
| `Failure` | `string` | Optional | Present if retrieval failed |

## Example (as JSON)

```json
{
  "imei": "100096454851324",
  "username": "290sk9vmybmxi1kmx1kxo8w13u",
  "failure": "No active username"
}
```

