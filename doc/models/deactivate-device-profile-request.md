
# Deactivate Device Profile Request

## Structure

`DeactivateDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `ReasonCode` | `string` | Required | - |
| `Devices` | [`List<DeactivateDeviceList>`](../../doc/models/deactivate-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `CarrierName` | `string` | Optional | - |
| `EtfWaiver` | `bool?` | Optional | **Default**: `true` |
| `CheckFallbackProfile` | `bool?` | Optional | **Default**: `false` |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "reasonCode": "a short code for the reason action was taken",
  "carrierName": "the name of the mobile service provider",
  "etfWaiver": true,
  "checkFallbackProfile": false,
  "devices": [
    {
      "ids": [
        {
          "id": "id2",
          "kind": "kind0"
        },
        {
          "id": "id2",
          "kind": "kind0"
        },
        {
          "id": "id2",
          "kind": "kind0"
        }
      ]
    },
    {
      "ids": [
        {
          "id": "id2",
          "kind": "kind0"
        },
        {
          "id": "id2",
          "kind": "kind0"
        },
        {
          "id": "id2",
          "kind": "kind0"
        }
      ]
    },
    {
      "ids": [
        {
          "id": "id2",
          "kind": "kind0"
        },
        {
          "id": "id2",
          "kind": "kind0"
        },
        {
          "id": "id2",
          "kind": "kind0"
        }
      ]
    }
  ]
}
```

