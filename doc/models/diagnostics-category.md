
# Diagnostics Category

Various types of information about the device, grouped into categories. Each category object contains the category name and a list of Extended Attribute objects as key-value pairs.

## Structure

`DiagnosticsCategory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CategoryName` | `string` | Optional | The name of the category. |
| `ExtendedAttributes` | [`List<Models.CustomFields>`](../../doc/models/custom-fields.md) | Optional | A list of Extended Attribute objects as key-value pairs. |

## Example (as JSON)

```json
{
  "categoryName": "Connectivity",
  "extendedAttributes": [
    {
      "key": "Connected",
      "value": "false"
    }
  ]
}
```

