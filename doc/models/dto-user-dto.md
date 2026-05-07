
# Dto User DTO

## Structure

`DtoUserDTO`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Optional | Contact email for the group |
| `Firstname` | `string` | Optional | The first name in the user record |
| `Lastname` | `string` | Optional | The last name in the user record |
| `Mdn` | `string` | Optional | The Mobile Directory Number |
| `Customdata` | `object` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |

## Example (as JSON)

```json
{
  "email": "email@domain.com",
  "firstname": "First name",
  "lastname": "Last name or Surname",
  "mdn": "908-555-1234",
  "customdata": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

