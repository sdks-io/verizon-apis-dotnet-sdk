
# Profile Request

## Structure

`ProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `Devices` | [`List<DeviceList>`](../../doc/models/device-list.md) | Required | **Constraints**: *Maximum Items*: `100` |
| `CarrierName` | `string` | Optional | - |
| `ServicePlan` | `string` | Optional | - |
| `MdnZipCode` | `string` | Optional | - |
| `PrimaryPlaceOfUse` | [`List<ProfileRequestPrimaryPlaceOfUse>`](../../doc/models/containers/profile-request-primary-place-of-use.md) | Optional | This is List of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `25` |
| `SmsrOid` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `46`, *Pattern*: `^[0-9.]{3,46}$` |
| `CarrierIpPoolName` | `string` | Optional | The name of the pool of IP addresses assigned to the profile. |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8"
        }
      ]
    }
  ],
  "carrierName": "the name of the mobile service provider",
  "servicePlan": "The service plan name",
  "mdnZipCode": "five digit zip code",
  "primaryPlaceOfUse": [
    {
      "customerName": [
        {
          "title": "title4",
          "firstName": "firstName4",
          "middleName": "middleName8",
          "lastName": "lastName4",
          "suffix": "suffix0"
        },
        {
          "title": "title4",
          "firstName": "firstName4",
          "middleName": "middleName8",
          "lastName": "lastName4",
          "suffix": "suffix0"
        }
      ]
    },
    {
      "customerName": [
        {
          "title": "title4",
          "firstName": "firstName4",
          "middleName": "middleName8",
          "lastName": "lastName4",
          "suffix": "suffix0"
        },
        {
          "title": "title4",
          "firstName": "firstName4",
          "middleName": "middleName8",
          "lastName": "lastName4",
          "suffix": "suffix0"
        }
      ]
    }
  ],
  "smsrOid": "smsrOid6"
}
```

