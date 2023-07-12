
# Service Plan Update Request

Request to update service plan.

## Structure

`ServicePlanUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The name of a billing account. |
| `CurrentServicePlan` | `string` | Optional | The name of a service plan, if you want to only include devices that have that service plan. |
| `CustomFields` | [`List<Models.CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `Devices` | [`List<Models.AccountDeviceList>`](../../doc/models/account-device-list.md) | Optional | A list of the devices that you want to change, specified by device identifier. |
| `GroupName` | `string` | Optional | The name of a device group, if you want to restore service for all devices in that group. |
| `ServicePlan` | `string` | Optional | The service plan code that you want to assign to all specified devices. |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "id": "A100003685E561",
          "kind": "meid"
        }
      ]
    }
  ],
  "servicePlan": "new_service_plan_code",
  "accountName": "accountName4",
  "currentServicePlan": "currentServicePlan6",
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
  ],
  "groupName": "groupName0"
}
```

