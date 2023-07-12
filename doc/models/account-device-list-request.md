
# Account Device List Request

Request for listing account devices.

## Structure

`AccountDeviceListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The billing account for which a list of devices is returned. If you don't specify an accountName, the list includes all devices to which you have access. |
| `DeviceId` | [`Models.DeviceId`](../../doc/models/device-id.md) | Optional | An identifier for a single device. |
| `Filter` | [`Models.AccountDeviceListFilter`](../../doc/models/account-device-list-filter.md) | Optional | Filter for a list of devices. |
| `CurrentState` | `string` | Optional | The name of a device state, to only include devices in that state. |
| `CustomFields` | [`List<Models.CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `Earliest` | `string` | Optional | Only include devices that were added after this date and time. |
| `GroupName` | `string` | Optional | Only include devices that are in this device group. |
| `Latest` | `string` | Optional | Only include devices that were added before this date and time. |
| `ServicePlan` | `string` | Optional | Only include devices that have this service plan. |

## Example (as JSON)

```json
{
  "accountName": "0786890242-00001",
  "filter": {
    "deviceIdentifierFilters": [
      {
        "kind": "iccid",
        "contains": "4259",
        "startswith": "startswith0",
        "endswith": "endswith2"
      }
    ]
  },
  "deviceId": {
    "id": "id0",
    "kind": "kind8"
  },
  "currentState": "currentState6",
  "customFields": [
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key1",
      "value": "value3"
    },
    {
      "key": "key2",
      "value": "value4"
    }
  ]
}
```

