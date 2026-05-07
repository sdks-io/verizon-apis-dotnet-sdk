
# User Smart Alert

## Structure

`UserSmartAlert`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountclientid` | `string` | Optional | Not used in this release, future functionality |
| `Billingaccountid` | `string` | Optional | The billing account ID. This is the same value as the Account ID |
| `Category` | `string` | Optional | The type of alert and will be either `telemetry` or `infrastructure` |
| `Condition` | `int?` | Optional | The condition or threshold for an alert |
| `Createdon` | `DateTime` | Required | Timestamp of the record |
| `Description` | `string` | Optional | a short description |
| `Deviceid` | `string` | Optional | This is a UUID value of the device created when the device is onboarded |
| `Foreignid` | `string` | Optional | UUID of the ECPD account the user belongs to |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Isacknowledged` | `bool?` | Optional | A flag that indicates if the alarm has been acknowledged |
| `Iscleared` | `bool?` | Optional | A flag that indicates if the alarm has been cleared |
| `Isdisabled` | `bool?` | Optional | A flag that indicates if the alarm has been disabled |
| `Lastupdated` | `DateTime` | Required | Timestamp of the record |
| `Name` | `string` | Optional | User defined name of the record |
| `Ruleid` | `string` | Optional | The UUID of a rule for alerts |
| `Severity` | `string` | Optional | The threshold value to trigger an alert and will be Critical, Major or Minor |
| `State` | `string` | Optional | The current status of the device or transaction and will be `success` or `failed` |
| `Template` | `string` | Optional | template of the rule which triggered a given alert |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "billingaccountid": "0000123456-00001",
  "category": "telemetry",
  "condition": 2592000,
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "deviceid": "The UUID of the device",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "isacknowledged": true,
  "iscleared": true,
  "isdisabled": false,
  "lastupdated": "10/02/2023 15:46:34",
  "name": "name of the record",
  "ruleid": "The UUID of a rule",
  "severity": "minor",
  "state": "success",
  "template": "The template ID",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

