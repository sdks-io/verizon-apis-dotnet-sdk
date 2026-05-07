
# Get Device Statuses Responseforplanner

## Structure

`GetDeviceStatusesResponseforplanner`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | The numeric name of the account, including leading zeros. |
| `RequestId` | `string` | Optional | - |
| `DeviceStatusList` | [`List<DeviceStatusItemforplanner>`](../../doc/models/device-status-itemforplanner.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountNumber": "0000123456-00001",
  "requestId": "requestId4",
  "deviceStatusList": [
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        }
      ],
      "status": "status6",
      "reason": "reason2"
    }
  ]
}
```

