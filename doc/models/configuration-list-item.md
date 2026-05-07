
# Configuration List Item

The ConfigurationList's item that contains the configuration identifier, name, description and the active flag.

## Structure

`ConfigurationListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The generated ID (UUID v4) for the configuration. It has to be used when asking for changing any of the configuration parameters.<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `Name` | `string` | Optional | Name of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `Description` | `string` | Optional | Description of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `IsActive` | `bool` | Required | - |

## Example (as JSON)

```json
{
  "id": "a4fcd16a-343d-4527-8203-2f46e3e4ff4b",
  "isActive": false,
  "name": "name0",
  "description": "description0"
}
```

