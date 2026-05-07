
# Price Plan Trigger 2

## Structure

`PricePlanTrigger2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountShare` | [`AccountShareFilterCriteria`](../../doc/models/account-share-filter-criteria.md) | Optional | - |
| `Condition` | [`PricePlanTrigger2Condition`](../../doc/models/containers/price-plan-trigger-2-condition.md) | Optional | This is a container for any-of cases. |
| `ChangePlan` | `bool?` | Optional | a flag to set if the trigger changes service plans, true, or not, false |
| `ChangePlanDetails` | [`ChangePlanDetails`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to |
| `PayAsYouGo` | [`PayAsYouGoFilterCriteria`](../../doc/models/pay-as-you-go-filter-criteria.md) | Optional | - |
| `Action` | [`Actionobject`](../../doc/models/actionobject.md) | Optional | - |
| `StandAlone` | [`FiltercriteriaObjectCall`](../../doc/models/filtercriteria-object-call.md) | Optional | - |

## Example (as JSON)

```json
{
  "changePlan": true,
  "accountShare": {
    "filterCriteria": {
      "carrierServicePlanCode": "carrierServicePlanCode4",
      "accountNameList": [
        "accountNameList7",
        "accountNameList8"
      ]
    }
  },
  "condition": "UsageAllowance",
  "changePlanDetails": {
    "toCarrierServicePlanCode": "toCarrierServicePlanCode2"
  },
  "payAsYouGo": {
    "filterCriteria": {
      "carrierServicePlanCode": "carrierServicePlanCode4",
      "accountNameList": [
        "accountNameList7",
        "accountNameList8"
      ]
    }
  }
}
```

