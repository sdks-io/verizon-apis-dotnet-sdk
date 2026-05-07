
# Data Trigger

## Structure

`DataTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountLevel` | [`AccountLevelObject`](../../doc/models/account-level-object.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountLevel": {
    "filterCriteria": {
      "separateOrCombined": "separateOrCombined4",
      "accountNames": {
        "accountNameList": [
          "accountNameList7",
          "accountNameList8",
          "accountNameList9"
        ]
      }
    },
    "condition": "Individual",
    "action": "suspend"
  }
}
```

