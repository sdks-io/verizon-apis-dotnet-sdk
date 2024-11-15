
# Promo Alert Trigger Request

## Structure

`PromoAlertTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DataPercentage50` | `bool?` | Optional | - |
| `DataPercentage75` | `bool?` | Optional | - |
| `DataPercentage90` | `bool?` | Optional | - |
| `NoOfDaysB4PromoExp` | `int?` | Optional | **Constraints**: `>= 0`, `<= 180` |
| `SmsPercentage50` | `bool?` | Optional | - |
| `SmsPercentage75` | `bool?` | Optional | - |
| `SmsPercentage90` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "dataPercentage50": false,
  "dataPercentage75": false,
  "dataPercentage90": false,
  "noOfDaysB4PromoExp": 166,
  "smsPercentage50": false
}
```

