
# Device Cost Center Request

Request to retrieve cost center value of a device.

## Structure

`DeviceCostCenterRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The name of a billing account. |
| `CostCenter` | `string` | Optional | The new cost center code. Valid values are any string of up to 36 alphanumeric characters, space, dash, exclamation point, and pound sign. |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `Devices` | [`List<AccountDeviceList>`](../../doc/models/account-device-list.md) | Optional | A list of the devices that you want to change, specified by device identifier. Do not include accountName, groupName, customFields, or servicePlan if you use this parameter. |
| `GroupName` | `string` | Optional | The name of a device group, if you want to only include devices in that group. |
| `PrimaryPlaceOfUse` | `object` | Optional | The customer name and the address of the device's primary place of use. These values are applied to all devices in the request.The Primary Place of Use location may affect taxation or have other legal implications. You may want to speak with legal and/or financial advisers before entering values for these fields. |
| `RemoveCostCenter` | `bool?` | Optional | Set to true to remove the cost center code value. This flag takes precedence over a new costCenter value. If this flag is true and costCenter has a value, the cost center code is removed. Do not include this parameter, or set it to false to change the costCenter value. |
| `ServicePlan` | `string` | Optional | The name of a service plan, if you want to only include devices that have that service plan. |

## Example (as JSON)

```json
{
  "costCenter": "cc12345",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "89148000000800139708",
          "kind": "iccid"
        }
      ],
      "ipAddress": "ipAddress4"
    }
  ],
  "accountName": "accountName6",
  "customFields": [
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key0",
      "value": "value2"
    }
  ],
  "groupName": "groupName8"
}
```

