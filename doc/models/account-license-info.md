
# Account License Info

Account license information.

## Structure

`AccountLicenseInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account identifier in "##########-#####". |
| `TotalLicenses` | `int?` | Optional | Number of monthly licenses in an MRC subscription. |
| `AssignedLicenses` | `int?` | Optional | Number of licenses currently assigned to devices. |
| `HasMoreData` | `bool?` | Optional | True if there are more devices to retrieve. |
| `LastSeenDeviceId` | `int?` | Optional | If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false. |
| `DeviceList` | [`List<AccountLicenseDeviceListItem>`](../../doc/models/account-license-device-list-item.md) | Optional | The list of devices that have licenses assigned, including the date and time of when each license was assigned. |

## Example (as JSON)

```json
{
  "accountName": "0402196254-00001",
  "totalLicenses": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": 1000,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000473475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000347475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990007303425535",
      "assignmentTime": "2016-11-29T16:03:42.000Z"
    }
  ]
}
```

