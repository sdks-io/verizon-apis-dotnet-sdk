
# V2 Licenses Assigned Removed Result

License assignment or removal confirmation.

## Structure

`V2LicensesAssignedRemovedResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account name. |
| `LicTotalCount` | `int` | Required | Total license count. |
| `LicUsedCount` | `int` | Required | Assigned license count. |
| `DeviceList` | [`List<V2DeviceStatus>`](../../doc/models/v2-device-status.md) | Required | List of devices with id in IMEI. |

## Example (as JSON)

```json
{
  "accountName": "0242078689-00001",
  "licTotalCount": 1000,
  "licUsedCount": 502,
  "deviceList": [
    {
      "deviceId": "990003425730524",
      "status": "Success",
      "resultReason": "Success"
    },
    {
      "deviceId": "990000473475967",
      "status": "Failure",
      "resultReason": "Device does not exist."
    }
  ]
}
```

