
# Custom Fields Update Request

Request to assign or change custom field values for one or more devices.

## Structure

`CustomFieldsUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The name of a billing account.This parameter is only required if the UWS account used for the current API session has access to multiple billing accounts.An account name is usually numeric, and must include any leading zeros. |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `CustomFieldsToUpdate` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | The names and new values of any custom fields that you want to change. |
| `Devices` | [`List<AccountDeviceList>`](../../doc/models/account-device-list.md) | Optional | The devices that you want to change. |
| `GroupName` | `string` | Optional | The name of a device group, if you want to only include devices in that group. |
| `ServicePlan` | `string` | Optional | The name of a service plan, if you want to only include devices that have that service plan. |

## Example (as JSON)

```json
{
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
  "customFieldsToUpdate": [
    {
      "key": "CustomField1",
      "value": "West Region"
    },
    {
      "key": "CustomField2",
      "value": "Distribution"
    }
  ],
  "accountName": "accountName4",
  "customFields": [
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key0",
      "value": "value2"
    }
  ],
  "groupName": "groupName0"
}
```

