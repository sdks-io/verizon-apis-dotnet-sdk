
# Promo Alert

## Structure

`PromoAlert`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`List<ReadySimServicePlan>`](../../doc/models/ready-sim-service-plan.md) | Optional | - |
| `Condition` | [`List<Keyschunk2>`](../../doc/models/keyschunk-2.md) | Optional | - |
| `EnablePromoExp` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "enablePromoExp": true,
  "filterCriteria": [
    {
      "servicePlan": "servicePlan4"
    },
    {
      "servicePlan": "servicePlan4"
    }
  ],
  "condition": [
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false
    },
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false
    },
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false
    }
  ]
}
```

