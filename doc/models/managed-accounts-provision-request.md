
# Managed Accounts Provision Request

## Structure

`ManagedAccountsProvisionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Managed account identifier |
| `PaccountName` | `string` | Required | Primary Account identifier |
| `ServiceName` | [`Models.ServiceNameEnum`](../../doc/models/service-name-enum.md) | Required | Service name<br>**Default**: `ServiceNameEnum.Location` |
| `Type` | `string` | Required | SKU name |
| `Txid` | `string` | Required | Transaction identifier returned by add request |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "paccountName": "1223334444-00001",
  "serviceName": "Location",
  "type": "TS-LOC-COARSE-CellID-5K",
  "txid": "d4fbff33-ece4-9f02-42ef-2c90bd287e3b"
}
```

