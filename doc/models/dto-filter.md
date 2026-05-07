
# Dto Filter

## Structure

`DtoFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Expand` | `string` | Optional | Use to provide device details for alerts specific to a device |
| `Limitnumber` | `int?` | Optional | Limit the number of results returned<br><br>**Constraints**: `>= 0`, `<= 100` |
| `Nopagination` | `bool?` | Optional | A flag set to show if pagination requested (false) or not (true) |
| `Page` | `string` | Optional | - |
| `Pagenumber` | `int?` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `Projection` | `List<string>` | Optional | Limits the fields of the device that the user is interested in rather than all of the fields<br><br>**Constraints**: *Maximum Items*: `100` |
| `Selection` | `object` | Optional | Filters results based on user defined criteria |

## Example (as JSON)

```json
{
  "$expand": "device detail(s)",
  "$nopagination": true,
  "$page": "The number of pages",
  "$limitnumber": 76,
  "$pagenumber": 12
}
```

