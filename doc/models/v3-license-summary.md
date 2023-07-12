
# V3 License Summary

Information for FOTA licenses assigned to devices.

## Structure

`V3LicenseSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier. |
| `TotalLicenses` | `int?` | Optional | Total FOTA license count. |
| `AssignedLicenses` | `int` | Required | Assigned FOTA license count. |
| `HasMoreData` | `bool` | Required | True if there are more devices to retrieve. |
| `LastSeenDeviceId` | `string` | Optional | Last seen device identifier. |
| `MaxPageSize` | `int` | Required | Maximum page size. |
| `DeviceList` | [`List<Models.V3LicenseDevice>`](../../doc/models/v3-license-device.md) | Optional | Device IMEI list. |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "totalLicenses": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": "1000",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    }
  ]
}
```

