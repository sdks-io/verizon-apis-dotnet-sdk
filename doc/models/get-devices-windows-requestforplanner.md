
# Get Devices Windows Requestforplanner

## Structure

`GetDevicesWindowsRequestforplanner`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | The numeric name of the account, including leading zeros. |
| `Filter` | `string` | Optional | what windows to filter for: All - all 24 windows in a day, Best - top 3 windows by RAN KPI, Worst - lowest 3 windows by RAN KPI |
| `Devices` | [`List<DeviceListforplanner>`](../../doc/models/device-listforplanner.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountNumber": "0000123456-00001",
  "filter": "filter4",
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

