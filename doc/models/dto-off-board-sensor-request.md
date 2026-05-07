
# Dto Off Board Sensor Request

## Structure

`DtoOffBoardSensorRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountname` | `string` | Optional | The numeric account name, which must include leading zeros |
| `Configuration` | [`Sensorinsightsconfig`](../../doc/models/sensorinsightsconfig.md) | Optional | The configuration of the remove request |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "configuration": {
    "removesensor": {
      "deveui": "deveui6"
    }
  }
}
```

