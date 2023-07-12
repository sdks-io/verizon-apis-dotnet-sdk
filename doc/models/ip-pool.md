
# IP Pool

IP pool that is available to the account.

## Structure

`IPPool`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PoolName` | `string` | Optional | The name of the IP pool. |
| `PoolType` | `string` | Optional | The type of IP pool, such as “Static IP” or “Dynamic IP.” |
| `IsDefaultPool` | `bool?` | Optional | True if this is the default IP pool for the account. |

## Example (as JSON)

```json
{
  "poolName": "ACMESTATIC001",
  "poolType": "Static IP",
  "isDefaultPool": true
}
```

