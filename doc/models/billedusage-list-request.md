
# Billedusage List Request

Information required to associate a usage segmentation label with a device to retrieve billing.

## Structure

`BilledusageListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `Labels` | [`LabelsList`](../../doc/models/labels-list.md) | Optional | - |
| `DeviceIds` | [`List<DeviceList>`](../../doc/models/device-list.md) | Optional | - |
| `BillingCycle` | [`BillingCycle`](../../doc/models/billing-cycle.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "9231221278-99990",
  "labels": {
    "deviceIds": [
      {
        "name": "name0",
        "value": "value2"
      }
    ]
  },
  "deviceIds": [
    {
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
    },
    {
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
  ],
  "billingCycle": {
    "year": "year6",
    "month": "month4"
  }
}
```

