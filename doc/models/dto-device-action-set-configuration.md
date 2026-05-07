
# Dto Device Action Set Configuration

## Structure

`DtoDeviceActionSetConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceConfig` | [`DtoDeviceConfig`](../../doc/models/dto-device-config.md) | Optional | - |

## Example (as JSON)

```json
{
  "deviceConfig": {
    "ble": {
      "dataMode": 216,
      "manufacturerId": 180,
      "maxNumScan": 126,
      "minSigStr": 60,
      "monitorPeriod": 88
    }
  }
}
```

