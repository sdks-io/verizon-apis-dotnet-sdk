
# Dto Notification Group Response Entity

## Structure

`DtoNotificationGroupResponseEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Createdon` | `DateTime?` | Optional | Timestamp of the record |
| `Description` | `string` | Optional | a short description |
| `Foreignid` | `string` | Optional | UUID of the ECPD account the user belongs to |
| `Groupemail` | `string` | Optional | Contact email for the group |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Lastupdated` | `DateTime?` | Optional | Timestamp of the record |
| `Name` | `string` | Optional | User defined name of the record |
| `Users` | [`List<DtoUserDTO>`](../../doc/models/dto-user-dto.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Optional | The UUID of the resource version |

## Example (as JSON)

```json
{
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "groupemail": "email@domain.com",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "name of the record",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "id": "id8"
}
```

