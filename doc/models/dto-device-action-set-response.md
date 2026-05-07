
# Dto Device Action Set Response

## Structure

`DtoDeviceActionSetResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Actionresult` | [`List<ActionResultwithDeviceConfig>`](../../doc/models/action-resultwith-device-config.md) | Optional | - |

## Example (as JSON)

```json
{
  "actionresult": [
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "description": "description8",
      "deviceid": "deviceid8",
      "errmsg": "errmsg0",
      "fields": {
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
    },
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "description": "description8",
      "deviceid": "deviceid8",
      "errmsg": "errmsg0",
      "fields": {
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
    }
  ]
}
```

