
# Action Resultwith Device Config

## Structure

`ActionResultwithDeviceConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Createdon` | `DateTime?` | Optional | Timestamp of the record |
| `Description` | `string` | Optional | - |
| `Deviceid` | `string` | Optional | This is a UUID value of the device created when the device is onboarded |
| `Errmsg` | `string` | Optional | Error message |
| `Fields` | [`DtoDeviceActionSetConfiguration`](../../doc/models/dto-device-action-set-configuration.md) | Optional | - |
| `Foreignid` | `string` | Optional | UUID of the ECPD account the user belongs to |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Lastupdated` | `DateTime?` | Optional | Timestamp of the record |
| `State` | `string` | Optional | The current status of the device or transaction and will be `success` or `failed` |
| `Transactionid` | `string` | Optional | The system-generated UUID of the transaction |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Optional | The UUID of the resource version |

## Example (as JSON)

```json
{
  "createdon": "10/02/2023 15:46:34",
  "deviceid": "The UUID of the device",
  "errmsg": "provider_service_error",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "state": "success",
  "transactionid": "afbcc00d-eeee-ffff-gggg-38b4333fcf06",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "description": "description8",
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
```

