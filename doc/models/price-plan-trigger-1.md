
# Price Plan Trigger 1

## Structure

`PricePlanTrigger1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountGroupShare` | [`AccountGroupShareIndividual1`](../../doc/models/account-group-share-individual-1.md) | Optional | - |
| `AccountShare` | [`AccountShareFilterCriteria`](../../doc/models/account-share-filter-criteria.md) | Optional | - |
| `Condition` | [`PricePlanTrigger1Condition`](../../doc/models/containers/price-plan-trigger-1-condition.md) | Optional | This is a container for any-of cases. |
| `ChangePlan` | `bool?` | Optional | a flag to set if the trigger changes service plans, true, or not, false |
| `ChangePlanDetails` | [`ChangePlanDetails`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to |
| `PayAsYouGo` | [`PayAsYouGoFilterCriteria`](../../doc/models/pay-as-you-go-filter-criteria.md) | Optional | - |
| `Action` | [`Actionobject`](../../doc/models/actionobject.md) | Optional | - |
| `StandAlone` | [`FiltercriteriaObjectCall`](../../doc/models/filtercriteria-object-call.md) | Optional | - |

## Example (as JSON)

```json
{
  "changePlan": true,
  "accountGroupShare": {
    "accountGroupShareIndividual": {
      "filterCriteria": {
        "ratePlanGroupId": 202
      },
      "condition": {
        "action": "notify"
      },
      "action": {
        "notify": {
          "alertType": "alertType8",
          "threshold": [
            {
              "carrierCode": "carrierCode4",
              "percentage": {
                "percentage50": false,
                "percentage75": false,
                "percentage90": false,
                "percentage100": false
              }
            },
            {
              "carrierCode": "carrierCode4",
              "percentage": {
                "percentage50": false,
                "percentage75": false,
                "percentage90": false,
                "percentage100": false
              }
            },
            {
              "carrierCode": "carrierCode4",
              "percentage": {
                "percentage50": false,
                "percentage75": false,
                "percentage90": false,
                "percentage100": false
              }
            }
          ]
        }
      }
    }
  },
  "accountShare": {
    "filterCriteria": {
      "carrierServicePlanCode": "carrierServicePlanCode4",
      "accountNameList": [
        "accountNameList7",
        "accountNameList8"
      ]
    }
  },
  "condition": "Aging",
  "changePlanDetails": {
    "toCarrierServicePlanCode": "toCarrierServicePlanCode2"
  }
}
```

