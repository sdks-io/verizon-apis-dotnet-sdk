
# Consent Transaction ID

The transaction ID of the request that you want to cancel, from the POST /devicelocations synchronus response.

## Structure

`ConsentTransactionID`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionId` | `string` | Optional | - |
| `Status` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "transactionId": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "QUEUED"
}
```
