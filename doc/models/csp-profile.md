
# CSP Profile

The user can create cloud credentials used for deploying workloads to the CSP environment.

## Structure

`CSPProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | System generated unique identifier to identify the CSP Profile uniquely.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Usage` | `long?` | Optional | Usage tells how many services are using the CSP Profile. Only CSP Profile with 0 usage count be allowed to delete.<br>**Constraints**: `>= 0`, `<= 1024` |
| `CspProfileName` | `string` | Required | Name of the cloud credential to uniquely identify the CSP.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `CustomerID` | `string` | Optional | Unique identification of the organization creating the CSP Profile.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `ProjectName` | `string` | Optional | Project name where service artifacts needs to be stored.<br>**Constraints**: *Maximum Length*: `63`, *Pattern*: `^[a-z0-9-.]+$` |
| `Type` | [`Models.CSPProfileTypeEnum?`](../../doc/models/csp-profile-type-enum.md) | Optional | Type of CSP profile.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `AwsCspProfile` | [`Models.AwsCspProfile`](../../doc/models/aws-csp-profile.md) | Optional | Information related to manage resources in AWS infrastructure. |
| `AzureCspProfile` | [`Models.AzureCspProfile`](../../doc/models/azure-csp-profile.md) | Optional | Information related to manage resources in Azure infrastructure. |
| `DefaultLocation` | [`Models.DefaultLocation`](../../doc/models/default-location.md) | Optional | Default location where service needs to be deployed. |
| `VerificationTimeStamp` | `DateTime?` | Optional | Auto-derived Time of creation. Part of response only. |
| `State` | `string` | Optional | State of the CSP profile.<br>**Constraints**: *Maximum Length*: `20`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `IsValidated` | `bool?` | Optional | True if CSP is validated using provided credential, false otherwise.<br>**Default**: `false` |
| `CreatedDate` | `DateTime?` | Optional | Auto-derived Time of creation. Part of response only. |
| `LastModifiedDate` | `DateTime?` | Optional | Last modified time. Part of response only. |
| `CreatedBy` | `string` | Optional | User who created the dropDown. Part of response only.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `LastModifiedBy` | `string` | Optional | User who last modified the dropDown. Part of response only.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |

## Example (as JSON)

```json
{
  "awsCspProfile": {
    "accessKey": "XXXXX",
    "credType": "ACCESS_KEY",
    "secretKey": "XXXXX"
  },
  "cspProfileName": "dev-api-csp-profile-mdp",
  "projectName": "vz-cve",
  "type": "AWS",
  "id": "id0",
  "usage": 38,
  "customerID": "customerID8"
}
```

