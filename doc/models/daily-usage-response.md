
# Daily Usage Response

## Structure

`DailyUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HasMoreData` | `bool?` | Optional | A flag set to indicate if there is more than one page of data returned by the query (true) or if only one page of data returned (false) |
| `DeviceId` | [`GIODeviceId`](../../doc/models/gio-device-id.md) | Optional | - |
| `UsageHistory` | [`List<DailyUsageHistory>`](../../doc/models/daily-usage-history.md) | Optional | - |

## Example (as JSON)

```json
{
  "hasMoreData": false,
  "deviceId": {
    "kind": "kind8",
    "id": "id0"
  },
  "usageHistory": [
    {
      "bytesUsed": "bytesUsed2",
      "extendedAttributes": [
        {
          "key": "key8",
          "value": "value0"
        },
        {
          "key": "key8",
          "value": "value0"
        },
        {
          "key": "key8",
          "value": "value0"
        }
      ],
      "servicePlan": "servicePlan0",
      "smsUsed": "smsUsed6",
      "source": "source4"
    },
    {
      "bytesUsed": "bytesUsed2",
      "extendedAttributes": [
        {
          "key": "key8",
          "value": "value0"
        },
        {
          "key": "key8",
          "value": "value0"
        },
        {
          "key": "key8",
          "value": "value0"
        }
      ],
      "servicePlan": "servicePlan0",
      "smsUsed": "smsUsed6",
      "source": "source4"
    }
  ]
}
```

