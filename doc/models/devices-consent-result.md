
# Devices Consent Result

## Structure

`DevicesConsentResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account identifier in "##########-#####". |
| `AllDevice` | `bool?` | Optional | Exclude all devices or not? |
| `HasMoreData` | `bool?` | Optional | Are there more devices to retrieve or not? |
| `TotalCount` | `int?` | Optional | Total number of excluded devices in the account. |
| `UpdateTime` | `string` | Optional | Last update time. |
| `Exclusion` | `List<string>` | Optional | Device ID list. |

## Example (as JSON)

```json
{
  "accountName": "2024009649-00001",
  "allDevice": false,
  "hasMoreData": false,
  "totalCount": 4,
  "updateTime": "2018-05-18 19:20:50.076 +0000 UTC",
  "exclusion": [
    "990003420535375",
    "420535399000375",
    "A100003861E585",
    "205353759900034"
  ]
}
```

