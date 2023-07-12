
# Device Group

Returns a list of all device groups in a specified account.

## Structure

`DeviceGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | The description of the device group. |
| `ExtendedAttributes` | [`List<Models.CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the device group, as Key and Value pairs. |
| `IsDefaultGroup` | `bool?` | Optional | Identifies the default device group. |
| `Name` | `string` | Optional | The name of the device group. |

## Example (as JSON)

```json
{
  "name": "Unassigned Devices",
  "description": "All devices that are not in another device group.",
  "isDefaultGroup": true,
  "extendedAttributes": []
}
```

