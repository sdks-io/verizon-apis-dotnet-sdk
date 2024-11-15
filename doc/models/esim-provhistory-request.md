
# ESIM Provhistory Request

## Structure

`ESIMProvhistoryRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `DeviceFilter` | [`List<DeviceId2>`](../../doc/models/device-id-2.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `Earliest` | `DateTime?` | Optional | - |
| `Latest` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "earliest": "10/15/2021 04:49:35",
  "latest": "10/15/2021 04:49:49",
  "deviceFilter": [
    {
      "id": "id4",
      "kind": "kind2"
    },
    {
      "id": "id4",
      "kind": "kind2"
    },
    {
      "id": "id4",
      "kind": "kind2"
    }
  ]
}
```

