
# M5 G Biactivate Request

## Structure

`M5gBiactivateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `ServicePlan` | `string` | Optional | - |
| `DeviceListWithServiceAddress` | [`List<M5gBiactivateRequestDeviceListWithServiceAddress>`](../../doc/models/containers/m5-g-biactivate-request-device-list-with-service-address.md) | Optional | This is List of a container for any-of cases. |
| `SkuNumber` | `string` | Optional | - |
| `PublicIpRestriction` | `string` | Optional | - |
| `CarrierName` | `string` | Optional | - |
| `MdnZipCode` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "servicePlan": "service plan name",
  "skuNumber": "VZW Stock Keeping Unit number",
  "publicIpRestriction": "Unrestricted",
  "carrierName": "Verizon Wireless",
  "mdnZipCode": "5-digit zip code",
  "deviceListWithServiceAddress": [
    {
      "deviceId": [
        {
          "id": "id0",
          "kind": "kind8"
        }
      ]
    },
    {
      "deviceId": [
        {
          "id": "id0",
          "kind": "kind8"
        }
      ]
    }
  ]
}
```

