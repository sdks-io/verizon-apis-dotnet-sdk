
# Resource User

## Structure

`ResourceUser`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountclientid` | `string` | Optional | Not used in this release, future functionality |
| `Ackterms` | `bool?` | Optional | Indicates if terms are agreed to (true) or not |
| `Acktermson` | `DateTime?` | Optional | - |
| `Billingaccountid` | `string` | Optional | The billing account ID. This is the same value as the Account ID |
| `Createdon` | `DateTime` | Required | Timestamp of the record |
| `Credentialsid` | `string` | Optional | User credentials. The only valid value is an email address |
| `Credentialstype` | `string` | Required | The type of credential represented by the ID. The only valid value is `email` |
| `Customdata` | `object` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |
| `Description` | `string` | Optional | a short description |
| `Displayname` | `string` | Optional | the user name value to display |
| `Email` | `string` | Optional | Contact email for the group |
| `Firstname` | `string` | Optional | The first name in the user record |
| `Foreignid` | `string` | Required | UUID of the ECPD account the user belongs to |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Lastname` | `string` | Optional | The last name in the user record |
| `Lastupdated` | `DateTime` | Required | Timestamp of the record |
| `Mdn` | `string` | Optional | The Mobile Directory Number |
| `Middlename` | `string` | Optional | optional field for middle name or initial |
| `Name` | `string` | Optional | User defined name of the record |
| `Secondarybillingaccountids` | `List<string>` | Optional | Virtual field; will not be used in this implementation<br><br>**Constraints**: *Maximum Items*: `100` |
| `State` | `string` | Optional | The current status of the device or transaction and will be `success` or `failed` |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "ackterms": true,
  "billingaccountid": "0000123456-00001",
  "createdon": "10/02/2023 15:46:34",
  "credentialsid": "email@domain.com",
  "credentialstype": "email",
  "description": "a short description",
  "displayname": "User name",
  "email": "email@domain.com",
  "firstname": "First name",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastname": "Last name or Surname",
  "lastupdated": "10/02/2023 15:46:34",
  "mdn": "908-555-1234",
  "middlename": "Middle name or initial",
  "name": "name of the record",
  "state": "success",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "acktermson": "2016-03-13T12:52:32.123Z"
}
```

