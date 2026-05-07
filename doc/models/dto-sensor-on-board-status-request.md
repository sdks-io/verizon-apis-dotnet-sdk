
# Dto Sensor on Board Status Request

## Structure

`DtoSensorOnBoardStatusRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountname` | `string` | Optional | The numeric account name, which must include leading zeros |
| `Gatewayidentifier` | [`Gatewayidentifier`](../../doc/models/gatewayidentifier.md) | Optional | - |
| `Onboarding` | [`Onboarding`](../../doc/models/onboarding.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "gatewayidentifier": {
    "deviceid": "deviceid0"
  },
  "onboarding": {
    "sensoridentifier": "sensoridentifier4"
  }
}
```

