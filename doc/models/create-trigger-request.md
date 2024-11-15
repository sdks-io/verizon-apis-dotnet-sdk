
# Create Trigger Request

## Structure

`CreateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `AnomalyTriggerRequest` | [`AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. |
| `DataTriggerRequest` | [`DataTriggerRequest`](../../doc/models/data-trigger-request.md) | Optional | - |
| `GroupName` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `SessionTriggerRequest` | [`SessionTriggerRequest`](../../doc/models/session-trigger-request.md) | Optional | - |
| `SmsTriggerRequest` | [`SMSTriggerRequest`](../../doc/models/sms-trigger-request.md) | Optional | - |
| `TriggerCategory` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `TriggerCycle` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

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
  "accountName": "accountName6",
  "dataTriggerRequest": {
    "comparator": "comparator2",
    "threshold": 242,
    "thresholdUnit": "thresholdUnit6"
  },
  "groupName": "groupName2",
  "name": "name2"
}
```

