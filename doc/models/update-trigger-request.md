
# Update Trigger Request

## Structure

`UpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Active` | `bool?` | Optional | - |
| `AnomalyTriggerRequest` | [`AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. |
| `CycleType` | [`CycleTypeEnum?`](../../doc/models/cycle-type-enum.md) | Optional | - |
| `DataTriggerRequest` | [`DataTriggerRequest`](../../doc/models/data-trigger-request.md) | Optional | - |
| `GroupName` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `PromoAlertTriggerRequest` | [`PromoAlertTriggerRequest`](../../doc/models/promo-alert-trigger-request.md) | Optional | - |
| `SessionTriggerRequest` | [`SessionTriggerRequest`](../../doc/models/session-trigger-request.md) | Optional | - |
| `SmsTriggerRequest` | [`SMSTriggerRequest`](../../doc/models/sms-trigger-request.md) | Optional | - |
| `TriggerCategory` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `TriggerId` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `TriggerName` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Example (as JSON)

```json
{
  "anomalyTriggerRequest": {
    "accountNames": "0000123456-00001",
    "includeAbnormal": true,
    "includeVeryAbnormal": true,
    "includeUnderExpectedUsage": true,
    "includeOverExpectedUsage": true
  },
  "accountName": "accountName0",
  "active": false,
  "cycleType": "cycleone",
  "dataTriggerRequest": {
    "comparator": "comparator2",
    "threshold": 242,
    "thresholdUnit": "thresholdUnit6"
  }
}
```

