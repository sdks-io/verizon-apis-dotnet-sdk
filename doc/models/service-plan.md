
# Service Plan

Details of the service plan.

## Structure

`ServicePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarrierServicePlanCode` | `string` | Optional | The code that is used by the carrier for the service plan. |
| `Code` | `string` | Optional | The code of the service plan, which may not be the same as the name. |
| `ExtendedAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the service plan, as Key and Value pairs. |
| `Name` | `string` | Optional | The name of the service plan. |
| `SizeKb` | `long?` | Optional | The size of the service plan in kilobytes. |

## Example (as JSON)

```json
{
  "name": "2MSHR5GB",
  "code": "M2MSHR5GB",
  "sizeKb": 0,
  "carrierServicePlanCode": "84638",
  "extendedAttributes": [
    {
      "key": "key8",
      "value": "value0"
    }
  ]
}
```

