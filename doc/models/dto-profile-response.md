
# Dto Profile Response

## Structure

`DtoProfileResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Kind` | `string` | Optional | the user defined profile kind |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Createdon` | `DateTime?` | Optional | Timestamp of the record |
| `Lastupdated` | `DateTime?` | Optional | Timestamp of the record |
| `Name` | `string` | Optional | user defined profile name |
| `Foreignid` | `string` | Optional | UUID of the ECPD account the user belongs to |
| `Billingaccountid` | `string` | Optional | The billing account ID. This is the same value as the Account ID |
| `Modelid` | `string` | Optional | device model id |
| `Configuration` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "id": "cb4169ec-eeee-ffff-gggg-d2951060421a",
  "kind": "the kind of profile being created",
  "version": "1.0",
  "versionid": "15bd78a1-eeee-ffff-gggg-86daa842009b",
  "createdon": "10/02/2023 15:46:34",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "Demo Entry sensor 1730928792",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "billingaccountid": "0000123456-00001",
  "modelid": "00000000-0000-0000-0000-000000000019",
  "configuration": {
    "randomInt": 21,
    "resportingInterval": 24
  }
}
```

