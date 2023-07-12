
# Region Item

## Structure

`RegionItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Region` | `string` | Optional | Region name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `Zones` | [`List<Models.ZoneItem>`](../../doc/models/zone-item.md) | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "region": "us-west-2",
  "zones": [
    {
      "zone": "us-west-2-wl1-den-wlz-1"
    }
  ]
}
```

