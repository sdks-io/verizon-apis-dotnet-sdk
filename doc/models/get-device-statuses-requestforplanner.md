
# Get Device Statuses Requestforplanner

## Structure

`GetDeviceStatusesRequestforplanner`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | The numeric name of the account, including leading zeros. |
| `RequestId` | `string` | Optional | The unique ID of a request. This is a UUID value. |
| `Devices` | [`List<DeviceListforplanner>`](../../doc/models/device-listforplanner.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountNumber": "0000123456-00001",
  "requestId": "d24cc6e4-eeee-ffff-gggg-0ffbb091c076",
  "devices": [
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        }
      ],
      "privateNetworkApns": [
        {
          "apnName": "apnName2",
          "addressAssignmentMethod": "addressAssignmentMethod8",
          "ipAddress": "ipAddress4"
        },
        {
          "apnName": "apnName2",
          "addressAssignmentMethod": "addressAssignmentMethod8",
          "ipAddress": "ipAddress4"
        }
      ],
      "ipAddress": "ipAddress4",
      "activationCode": "activationCode2"
    },
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        }
      ],
      "privateNetworkApns": [
        {
          "apnName": "apnName2",
          "addressAssignmentMethod": "addressAssignmentMethod8",
          "ipAddress": "ipAddress4"
        },
        {
          "apnName": "apnName2",
          "addressAssignmentMethod": "addressAssignmentMethod8",
          "ipAddress": "ipAddress4"
        }
      ],
      "ipAddress": "ipAddress4",
      "activationCode": "activationCode2"
    }
  ]
}
```

