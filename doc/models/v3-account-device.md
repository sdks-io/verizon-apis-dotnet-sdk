
# V3 Account Device

Device information.

## Structure

`V3AccountDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device identifier. |
| `Mdn` | `string` | Required | MDN. |
| `Model` | `string` | Required | Device model. |
| `Make` | `string` | Required | Device make. |
| `Firmware` | `string` | Required | Device firmware version. |
| `FotaEligible` | `bool` | Required | Value=true if the device software can be upgraded over the air using the Software Management Services API. |
| `Status` | `string` | Required | Device status. |
| `LicenseAssigned` | `bool` | Required | License assigned device. |
| `Protocol` | `string` | Required | Firmware protocol. Valid values include: LWM2M, OMADM, HTTP or NONE. |
| `SoftwareList` | [`List<Models.V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Required | List of sofware. |
| `FileList` | [`List<Models.V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Optional | List of files. |
| `CreateTime` | `string` | Optional | The date and time of when the device is created. |
| `UpgradeTime` | `string` | Optional | The date and time of when the device firmware or software is updated. |
| `UpdateTime` | `string` | Optional | The date and time of when the device is updated. |
| `RefreshTime` | `string` | Optional | The date and time of when the device is refreshed. |

## Example (as JSON)

```json
{
  "deviceId": "15-digit device ID",
  "mdn": "10-digit MDN",
  "model": "BG96",
  "make": "QUECTEL",
  "firmware": "BG96MAR04A04M1G",
  "fotaEligible": false,
  "status": "Active",
  "licenseAssigned": true,
  "protocol": "LWM2M",
  "softwareList": [
    {
      "name": "VZ_MDM_IOT",
      "version": "0.14",
      "upgradeTime": "2012-04-23T18:25:43.511Z"
    }
  ],
  "fileList": [
    {
      "name": "VZ_MDM_IOT",
      "version": "0.14",
      "upgradeTime": "2012-04-23T18:25:43.511Z"
    }
  ],
  "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC"
}
```

