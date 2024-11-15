
# Account Consent Create

## Structure

`AccountConsentCreate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | `object` | Optional | An array of device identifiers |
| `AccountName` | `string` | Optional | The numeric name of the account, including leading zeros. |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "deviceList": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ]
}
```

