
# Resource Event

## Structure

`ResourceEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountclientid` | `string` | Optional | Not used in this release, future functionality |
| `Callbackurl` | `string` | Optional | The URL of the callback listener |
| `Createdon` | `DateTime` | Required | Timestamp of the record |
| `Description` | `string` | Optional | a short description |
| `Deviceid` | `string` | Optional | This is a UUID value of the device created when the device is onboarded |
| `Errmsg` | `string` | Optional | Error message |
| `Fieldid` | `string` | Required | - |
| `Fields` | [`DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search |
| `Fieldvalue` | `List<int>` | Optional | **Constraints**: *Maximum Items*: `100`, `>= 0`, `<= 100` |
| `Foreignid` | `string` | Required | UUID of the ECPD account the user belongs to |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Lastupdated` | `DateTime` | Required | Timestamp of the record |
| `Modelid` | `string` | Optional | The model ID of the device |
| `Name` | `string` | Optional | User defined name of the record |
| `Sensordataaggregation` | `bool?` | Optional | A flag to indicate if sensor data is to be aggregated (true) or not |
| `State` | `string` | Required | The current status of the device or transaction and will be `success` or `failed` |
| `Transactionid` | `string` | Optional | The system-generated UUID of the transaction |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "callbackurl": "The URL of the callback listener",
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "deviceid": "The UUID of the device",
  "errmsg": "provider_service_error",
  "fieldid": "The field ID",
  "fields": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "modelid": "The model ID of the device",
  "name": "name of the record",
  "sensordataaggregation": true,
  "state": "success",
  "transactionid": "afbcc00d-eeee-ffff-gggg-38b4333fcf06",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

