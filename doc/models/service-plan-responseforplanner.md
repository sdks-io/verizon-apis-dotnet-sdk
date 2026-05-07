
# Service Plan Responseforplanner

## Structure

`ServicePlanResponseforplanner`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarrierServicePlanCode` | `string` | Optional | The name of the service plan code |
| `Code` | `string` | Optional | The actiavtion code value. |
| `ExtendedAttributes` | [`List<KvPairforplanner>`](../../doc/models/kv-pairforplanner.md) | Optional | key/value pairs assigned by the user for filtering.<br><br>**Constraints**: *Maximum Items*: `5` |
| `Name` | `string` | Optional | The carrier name of the active profile. |
| `SizeKb` | `int?` | Optional | size in Kilobytes of the service plan |

## Example (as JSON)

```json
{
  "carrierServicePlanCode": "carrierServicePlanCode0",
  "code": "code0",
  "extendedAttributes": [
    {
      "key": "key8",
      "value": "value0"
    },
    {
      "key": "key8",
      "value": "value0"
    },
    {
      "key": "key8",
      "value": "value0"
    }
  ],
  "name": "name2",
  "sizeKb": 12
}
```

