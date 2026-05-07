
# Dto Remove Users from Notification Group Request

## Structure

`DtoRemoveUsersFromNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountname` | `string` | Optional | The numeric account name, which must include leading zeros |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Userids` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "id": "id0",
  "userids": [
    "userids2",
    "userids3",
    "userids4"
  ]
}
```

