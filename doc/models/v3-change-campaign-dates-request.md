
# V3 Change Campaign Dates Request

Campaign dates and time windows.

## Structure

`V3ChangeCampaignDatesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `DateTime` | Required | Campaign start date. |
| `EndDate` | `DateTime` | Required | Campaign end date. |
| `CampaignTimeWindowList` | [`List<V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |

## Example (as JSON)

```json
{
  "startDate": "2022-02-23",
  "endDate": "2022-02-24",
  "campaignTimeWindowList": [
    {
      "startTime": 14,
      "endTime": 18
    }
  ]
}
```

