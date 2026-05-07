
# Hpl Add Devices Request

Request to add the devices.

## Structure

`HplAddDevicesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `string` | Optional | The initial service state for the devices. The only valid state is "Preactive." |
| `DevicesToAdd` | [`List<HplAccountDeviceList>`](../../doc/models/hpl-account-device-list.md) | Optional | The devices that you want to add. |
| `AccountName` | `string` | Optional | The numeric name of the account and must include leading zeroes. |
| `CustomFields` | [`List<HplCustomFields>`](../../doc/models/hpl-custom-fields.md) | Optional | The names and values for any custom fields that you want set for the devices as they are added to the account. |
| `GroupName` | `string` | Optional | The name of a device group to add the devices to. They are added to the default device group if you don't include this parameter. |
| `SkuNumber` | `string` | Optional | The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM. |
| `SmsrOid` | `string` | Optional | The Subscription Manager Secure Router Object ID, used for remote SIM provisioning. SMSR securely routes the download and management of eSIM profiles. |
| `NumberOfVirtualImei` | `int?` | Optional | numberOfVirtualImei. |
| `UploadType` | `string` | Optional | uploadType. |

## Example (as JSON)

```json
{
  "state": "preactive",
  "devicesToAdd": [
    {
      "deviceIds": [
        {
          "kind": "imei",
          "id": "15-digit IMEI"
        },
        {
          "kind": "iccid",
          "id": "20-digit ICCID"
        }
      ]
    },
    {
      "deviceIds": [
        {
          "kind": "imei",
          "id": "15-digit IMEI"
        },
        {
          "kind": "iccid",
          "id": "20-digit ICCID"
        }
      ]
    }
  ],
  "accountName": "0000123456-00001",
  "customFields": [
    {
      "key": "CustomField2",
      "value": "SuperVend"
    }
  ],
  "groupName": "West Region",
  "numberOfVirtualImei": 1
}
```

