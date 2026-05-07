
# Account Group Share Individual 1

## Structure

`AccountGroupShareIndividual1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountGroupShareIndividual` | [`AccountGroupShareFilterCriteria`](../../doc/models/account-group-share-filter-criteria.md) | Optional | - |

## Example (as JSON)

```json
{
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
```

