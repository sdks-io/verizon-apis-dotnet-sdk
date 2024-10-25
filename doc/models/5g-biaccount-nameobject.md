
# 5g Biaccount Nameobject

## Structure

`M5gBiaccountNameobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `BillingCycleEndDate` | `string` | Optional | - |
| `CarrierInformation` | [`List<M5gBiCarrierInformation>`](../../doc/models/5g-bi-carrier-information.md) | Optional | - |
| `Connected` | `bool?` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `CustomFields` | [`List<M5gBikeyValue1>`](../../doc/models/5g-bikey-value-1.md) | Optional | - |
| `DeviceIds` | [`List<M5gBideviceId1>`](../../doc/models/5g-bidevice-id-1.md) | Optional | - |
| `ExtendedAttributes` | [`List<M5gBikeyValue1>`](../../doc/models/5g-bikey-value-1.md) | Optional | - |
| `GroupNames` | [`List<GroupName>`](../../doc/models/group-name.md) | Optional | - |
| `Ipaddress` | `string` | Optional | - |
| `LastActivationBy` | `string` | Optional | - |
| `LastActivationDate` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "billingCycleEndDate": "11/10/2022 00:00:00",
  "connected": false,
  "createdAt": "10/20/2022 18:23:41",
  "ipAddress": "0.0.0.0",
  "lastActivationBy": "User Name",
  "lastActivationDate": "2022-11-02 T21:36:18Z",
  "carrierInformation": [
    {
      "carrierName": "carrierName4"
    },
    {
      "carrierName": "carrierName4"
    },
    {
      "carrierName": "carrierName4"
    }
  ]
}
```

