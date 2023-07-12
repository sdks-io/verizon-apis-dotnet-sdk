
# Aws Csp Profile

Information related to manage resources in AWS infrastructure.

## Structure

`AwsCspProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CredType` | [`Models.AwsCspProfileCredTypeEnum?`](../../doc/models/aws-csp-profile-cred-type-enum.md) | Optional | Credential type of AWS CSP profile.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `AccessKey` | `string` | Optional | AWS Access Key.<br>**Constraints**: *Maximum Length*: `128`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!\/,+\-=_:.&*%\s]+$` |
| `SecretKey` | `string` | Optional | AWS Secret Key.<br>**Constraints**: *Maximum Length*: `128`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!\/,+\-=_:.&*%\s]+$` |
| `RoleARN` | `string` | Optional | CSP AWS Role ARN.<br>**Constraints**: *Maximum Length*: `256`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!\/,+\-=_:.&*%\s]+$` |
| `AccountId` | `string` | Optional | AWS account ID.<br>**Constraints**: *Maximum Length*: `12`, *Pattern*: `^[0-9]+$` |
| `ExternalId` | `string` | Optional | AWS external ID.<br>**Constraints**: *Maximum Length*: `128`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!\/,+\-=_:.&*%\s]+$` |

## Example (as JSON)

```json
{
  "accessKey": "XXXXX",
  "credType": "ACCESS_KEY",
  "secretKey": "XXXXX",
  "roleARN": "roleARN8",
  "accountId": "accountId0"
}
```

