
# V3 Device Status

Device status.

## Structure

`V3DeviceStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `Status` | `string` | Required | Success or failure. |
| `ResultReason` | `string` | Optional | Result reason. |
| `UpdatedTime` | `DateTime?` | Optional | Updated Time. |
| `RecentAttemptTime` | `DateTime?` | Optional | The most recent attempt time. |
| `NextAttemptTime` | `DateTime?` | Optional | Next attempt time. |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "status": "UpgradePending",
  "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
  "updatedTime": "2022-08-05T21:05:27.129Z",
  "recentAttemptTime": "2022-10-05T21:05:01.19Z",
  "nextAttemptTime": "2022-10-06T18:35:00Z"
}
```

