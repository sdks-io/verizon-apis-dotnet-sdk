
# Change Plan

## Structure

`ChangePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerDate` | `string` | Optional | - |
| `SharePlan` | [`List<SharePlan>`](../../doc/models/share-plan.md) | Optional | - |

## Example (as JSON)

```json
{
  "triggerDate": "triggerDate4",
  "sharePlan": [
    {
      "fromCarrierCode": "fromCarrierCode6",
      "toCarrierCode": "toCarrierCode8",
      "criteriaPercentage": 170
    }
  ]
}
```

