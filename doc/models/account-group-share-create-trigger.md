
# Account Group Share Create Trigger

## Structure

`AccountGroupShareCreateTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `AccountName` | `string` | Optional | The numeric name of the account and must include leading zeroes |
| `TriggerCategory` | [`TriggerCategoryEnum?`](../../doc/models/trigger-category-enum.md) | Optional | The type of trigger being created or modified |
| `PricePlanTrigger` | [`AccountGroupShareObject`](../../doc/models/account-group-share-object.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |

## Example (as JSON)

```json
{
  "triggerName": "name of the trigger",
  "accountName": "0000123456-00001",
  "triggerCategory": "PricePlanDataUsage",
  "pricePlanTrigger": {
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
    }
  },
  "notification": {
    "notificationType": "notificationType8",
    "callback": false,
    "emailNotification": false,
    "notificationGroupName": "notificationGroupName6",
    "notificationFrequencyFactor": 22
  }
}
```

