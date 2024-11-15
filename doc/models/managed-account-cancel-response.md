
# Managed Account Cancel Response

## Structure

`ManagedAccountCancelResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Required | Transaction identifier |
| `AccountName` | `string` | Required | Managed account identifier |
| `PaccountName` | `string` | Required | Primary account identifier |
| `ServiceName` | [`ServiceNameEnum`](../../doc/models/service-name-enum.md) | Required | Service name<br>**Default**: `ServiceNameEnum.Location` |
| `Status` | `string` | Required | Deactivate/cancel status, Success or Fail |
| `Reason` | `string` | Required | Detailed reason |

## Example (as JSON)

```json
{
  "txid": "4fbff332-eeee-ffff-gggg-7e3bdc90bd28",
  "accountName": "1223334444-00001",
  "paccountName": "1223334444-00001",
  "serviceName": "Location",
  "status": "Success",
  "reason": "Success"
}
```

