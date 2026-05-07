
# Account Group Share Filter Criteria

## Structure

`AccountGroupShareFilterCriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`AccountGroupShareFilter`](../../doc/models/account-group-share-filter.md) | Optional | - |
| `Condition` | [`AccountGroupShareCondition`](../../doc/models/account-group-share-condition.md) | Optional | - |
| `Action` | [`AccountGroupShareAction`](../../doc/models/account-group-share-action.md) | Optional | - |

## Example (as JSON)

```json
{
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
```

