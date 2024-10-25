
# Carrier Service Plan

## Structure

`CarrierServicePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The name of the service plan<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `Code` | `string` | Optional | The inventory name or system name of the service plan<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `SizeKb` | `string` | Optional | The ammount of space the service plan will occupy on the Subscriber Information Module (SIM)<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `CarrierServicePlanCode` | `string` | Optional | The billing record ID. This can be numeric, alpha or alphanumeric.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |

## Example (as JSON)

```json
{
  "name": "name6",
  "code": "code4",
  "sizeKb": "sizeKb6",
  "carrierServicePlanCode": "carrierServicePlanCode4"
}
```

