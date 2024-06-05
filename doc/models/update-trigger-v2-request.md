
# Update Trigger V2 Request

Update Trigger Request

## Structure

`UpdateTriggerV2Request`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `string` | Optional | - |
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
  "triggerId": "triggerId4",
  "triggerName": "triggerName6",
  "ecpdId": "ecpdId0",
  "deviceGroupName": "deviceGroupName4",
  "triggerCategory": "triggerCategory8"
}
```

