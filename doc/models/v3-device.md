
# V3 Device

Device information.

## Structure

`V3Device`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `RequestStatus` | `string` | Optional | Success or failure. |
| `ResultReason` | `string` | Optional | - |
| `Mdn` | `string` | Optional | MDN. |
| `Model` | `string` | Optional | Device model. |
| `Make` | `string` | Optional | Device make. |
| `Firmware` | `string` | Optional | Device firmware version. |
| `FotaEligible` | `bool?` | Optional | Value=true if the device software can be upgraded over the air using the Software Management Services API. |
| `Status` | `string` | Optional | Device status. |
| `LicenseAssigned` | `bool?` | Optional | License assigned device. |
| `Protocol` | `string` | Optional | Firmware protocol. Valid values include: LWM2M, OMADM, HTTP or NONE. |
| `SoftwareList` | [`List<Models.V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Optional | List of sofware.<br>**Constraints**: *Maximum Items*: `1000` |
| `FileList` | [`List<Models.V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Optional | List of files.<br>**Constraints**: *Maximum Items*: `1000` |
| `CreateTime` | `string` | Optional | The date and time of when the device is created. |
| `StatusTime` | `string` | Optional | The date and time of when the device firmware or software is updated. |
| `UpdateTime` | `string` | Optional | The date and time of when the device is updated. |
| `RefreshTime` | `string` | Optional | The date and time of when the device is refreshed. |
| `LastConnectionTime` | `DateTime?` | Optional | The date and time of when the device reachability is checked. |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "mdn": "10-digit MDN",
  "model": "GM01Q",
  "make": "SEQUANS COMMUNICATIONS",
  "firmware": "SR1.2.0.0-10657",
  "fotaEligible": true,
  "licenseAssigned": true,
  "status": "Active",
  "protocol": "LWM2M",
  "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "statusTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "lastConnectionTime": "2012-04-23T18:25:43.511Z",
  "requestStatus": "requestStatus0",
  "resultReason": "resultReason0"
}
```

