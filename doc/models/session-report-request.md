
# Session Report Request

Request for obtaining a session report.

## Structure

`SessionReportRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Required | The numeric ID of the account and must include leading zeroes. This value is indentical to `accountName`. |
| `Imei` | `string` | Required | The International Mobile Equipment Identifier of the device. |
| `StartDate` | `string` | Optional | Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants. |
| `EndDate` | `string` | Optional | End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants. |
| `DurationLow` | `int?` | Optional | Optional filter — minimum session duration |
| `DurationHigh` | `int?` | Optional | Optional filter — maximum session duration |

## Example (as JSON)

```json
{
  "accountNumber": "0000123456-00001",
  "startDate": "2022-12-09T22:01:06.217Z",
  "endDate": "2022-12-09T22:01:08.734Z",
  "imei": "15-digit IMEI",
  "durationLow": 0,
  "durationHigh": 0
}
```

