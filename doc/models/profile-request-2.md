
# Profile Request 2

## Structure

`ProfileRequest2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Devices` | [`List<Models.DeviceList2>`](../../doc/models/device-list-2.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `AccountName` | `string` | Optional | - |
| `CarrierName` | `string` | Optional | - |
| `ReasonCode` | `string` | Optional | - |
| `EtfWaiver` | `bool?` | Optional | **Default**: `true` |
| `CheckFallbackProfile` | `bool?` | Optional | **Default**: `false` |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "carrierName": "the name of the mobile service provider",
  "reasonCode": "a short code for the reason action was taken",
  "etfWaiver": true,
  "checkFallbackProfile": false,
  "devices": [
    {
      "ids": [
        {
          "id": "id7",
          "kind": "iccid"
        },
        {
          "id": "id8",
          "kind": "imei"
        }
      ]
    },
    {
      "ids": [
        {
          "id": "id8",
          "kind": "imei"
        },
        {
          "id": "id9",
          "kind": "eid"
        },
        {
          "id": "id0",
          "kind": "esn"
        }
      ]
    }
  ]
}
```

