
# Dto Device Config

## Structure

`DtoDeviceConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ble` | [`SensorInsightsBLE`](../../doc/models/sensor-insights-ble.md) | Optional | Property objects for Bluetooth Low-Energy (BLE) devices |

## Example (as JSON)

```json
{
  "ble": {
    "dataMode": 216,
    "manufacturerId": 180,
    "maxNumScan": 126,
    "minSigStr": 60,
    "monitorPeriod": 88
  }
}
```

