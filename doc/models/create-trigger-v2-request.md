
# Create Trigger V2 Request

Create Trigger Request

## Structure

`CreateTriggerV2Request`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | - |
| `EcpdId` | `string` | Optional | - |
| `DeviceGroupName` | `string` | Optional | - |
| `TriggerCategory` | `string` | Optional | - |
| `PricePlanTrigger` | [`PricePlanTrigger`](../../doc/models/price-plan-trigger.md) | Optional | - |
| `Notification` | [`Notification`](../../doc/models/notification.md) | Optional | - |
| `Active` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "triggerName": "triggerName4",
  "ecpdId": "ecpdId0",
  "deviceGroupName": "deviceGroupName4",
  "triggerCategory": "triggerCategory8",
  "pricePlanTrigger": {
    "accountGroupShare": {
      "accountGroupShareIndividual": {
        "filterCriteria": {
          "ratePlanGroupId": 202
        },
        "condition": {
          "action": "action6"
        },
        "action": {
          "changePlan": {
            "triggerDate": "triggerDate6",
            "sharePlan": [
              {
                "fromCarrierCode": "fromCarrierCode6",
                "toCarrierCode": "toCarrierCode8",
                "criteriaPercentage": 170
              },
              {
                "fromCarrierCode": "fromCarrierCode6",
                "toCarrierCode": "toCarrierCode8",
                "criteriaPercentage": 170
              },
              {
                "fromCarrierCode": "fromCarrierCode6",
                "toCarrierCode": "toCarrierCode8",
                "criteriaPercentage": 170
              }
            ]
          }
        }
      }
    }
  }
}
```

