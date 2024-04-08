
# Managed Accounts Provision Response

## Structure

`ManagedAccountsProvisionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Optional | Transaction identifier |
| `AccountName` | `string` | Optional | Account identifier |
| `PaccountName` | `string` | Optional | Primary Account identifier |
| `ServiceName` | [`ServiceNameEnum?`](../../doc/models/service-name-enum.md) | Optional | Service name<br>**Default**: `ServiceNameEnum.Location` |
| `Status` | `string` | Optional | Provision status. Success or Fail |
| `Reason` | `string` | Optional | Detailed reason |

## Example (as JSON)

```json
{
  "txid": "4fbff332-ece4-42ef-9f02-7e3bdc90bd28",
  "accountName": "1223334444-00001",
  "paccountName": "1223334444-00001",
  "serviceName": "Location",
  "status": "Success",
  "reason": "Success"
}
```

