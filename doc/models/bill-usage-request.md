
# Bill Usage Request

Bill usage request.

## Structure

`BillUsageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account identifier. |
| `StartDate` | `string` | Optional | Start date to search for billable usage, mm-dd-yyyy. |
| `EndDate` | `string` | Optional | End date to search for billable usage, mm-dd-yyyy. |
| `UsageForAllAccounts` | `bool?` | Optional | Request usage for single or multiple accounts. |

## Example (as JSON)

```json
{
  "accountName": "1234567890-00001",
  "startDate": "04-01-2018",
  "endDate": "04-30-2018",
  "usageForAllAccounts": true
}
```

