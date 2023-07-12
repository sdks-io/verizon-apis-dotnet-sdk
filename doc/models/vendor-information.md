
# Vendor Information

## Structure

`VendorInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | ID of the vendor.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `Name` | `string` | Required | Name of the vendor.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `PrimaryEmail` | `string` | Optional | Primary email of the vendor.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `SecondaryEmail` | `string` | Optional | Secondary email of the vendor.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `ContactNumber` | `string` | Optional | Contact number of the vendor.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |

## Example (as JSON)

```json
{
  "id": "acme",
  "name": "acme",
  "primaryEmail": "primaryEmail2",
  "secondaryEmail": "secondaryEmail6",
  "contactNumber": "contactNumber4"
}
```

