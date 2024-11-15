
# Device Suspension Status Request

Request to return service suspension information about one or more devices.

## Structure

`DeviceSuspensionStatusRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceIds` | [`List<DeviceId>`](../../doc/models/device-id.md) | Optional | The devices that you want to include in the request, specified by device identifier. You only need to provide one identifier per device. |
| `Filter` | [`DeviceFilterWithoutAccount`](../../doc/models/device-filter-without-account.md) | Optional | Filter for devices without account. |
| `AccountName` | `string` | Optional | The name of a billing account. |

## Example (as JSON)

```json
{
  "filter": {
    "groupName": "suspended devices",
    "servicePlan": "servicePlan6",
    "customFields": [
      {
        "key": "key0",
        "value": "value2"
      },
      {
        "key": "key0",
        "value": "value2"
      },
      {
        "key": "key0",
        "value": "value2"
      }
    ]
  },
  "accountName": "1223334444-00001",
  "deviceIds": [
    {
      "id": "id0",
      "kind": "kind8"
    },
    {
      "id": "id0",
      "kind": "kind8"
    }
  ]
}
```

