
# Aggregate Session Report Request

Request for getting an aggregated session report.

## Structure

`AggregateSessionReportRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Required | The unique identifier for the account. |
| `StartDate` | `string` | Optional | Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants. |
| `EndDate` | `string` | Optional | End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants. |
| `Imei` | `List<string>` | Required | Devices for which return usage info. Could be 0, 1 or more. In case of 0 will return all devices belonging to customer (except of filtered by other parameters). |
| `DeviceGroup` | `string` | Optional | User defined group name the devices are a member of. |
| `DeviceLabel` | `string` | Optional | Optional filter parameter. |
| `DataPlan` | `string` | Optional | The data plan the devices beign queried belong to. |
| `NoSessionFlag` | `string` | Optional | Optional filter parameter which return only devices with no sessions. |

## Example (as JSON)

```json
{
  "accountNumber": "0844021539-00001",
  "startDate": "2022-12-09T22:01:06.217Z",
  "endDate": "2022-12-09T22:01:08.734Z",
  "imei": [
    "709312034493372"
  ],
  "deviceGroup": "deviceGroup4",
  "dataPlan": "dataPlan2",
  "noSessionFlag": "false",
  "deviceLabel": "deviceLabel4"
}
```

