
# Resource Rule

## Structure

`ResourceRule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountclientid` | `string` | Optional | Not used in this release, future functionality |
| `Billingaccountid` | `string` | Optional | The billing account ID. This is the same value as the Account ID |
| `Createdon` | `DateTime` | Required | Timestamp of the record |
| `Description` | `string` | Optional | a short description |
| `Deviceid` | `string` | Optional | This is a UUID value of the device created when the device is onboarded |
| `Disabled` | `bool?` | Optional | - |
| `Foreignid` | `string` | Required | UUID of the ECPD account the user belongs to |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Lastupdated` | `DateTime` | Required | Timestamp of the record |
| `Name` | `string` | Optional | User defined name of the record |
| `Rulechain` | `object` | Required | - |
| `Rulesyntax` | `string` | Optional | The syntax of the rule and supports camel and json style syntaxes |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "billingaccountid": "0000123456-00001",
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "deviceid": "The UUID of the device",
  "disabled": false,
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "name of the record",
  "rulechain": {
    "key1": "val1",
    "key2": "val2"
  },
  "rulesyntax": "The rule syntax",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

