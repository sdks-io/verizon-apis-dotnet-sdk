
# Managed Accounts Get All Response

## Structure

`ManagedAccountsGetAllResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account Name |
| `ManagedAccAddedList` | [`List<Models.ManagedAccAddedList>`](../../doc/models/managed-acc-added-list.md) | Optional | - |
| `ManagedAccProvisionedList` | [`List<Models.ManagedAccProvisionedList>`](../../doc/models/managed-acc-provisioned-list.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0212312345-00001",
  "ManagedAccAddedList": [
    {
      "id": "id3",
      "txid": "txid9"
    },
    {
      "id": "id4",
      "txid": "txid8"
    },
    {
      "id": "id5",
      "txid": "txid7"
    }
  ],
  "managedAccProvisionedList": [
    {
      "id": "id1",
      "txid": "txid1"
    },
    {
      "id": "id2",
      "txid": "txid0"
    },
    {
      "id": "id3",
      "txid": "txid9"
    }
  ]
}
```

