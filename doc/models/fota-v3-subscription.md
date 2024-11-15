
# Fota V3 Subscription

Information for licenses applied to devices.

## Structure

`FotaV3Subscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account identifier in "##########-#####". |
| `PurchaseType` | `string` | Optional | Subscription models used by the account. |
| `LicenseCount` | `int?` | Optional | Number of monthly licenses in an MRC subscription. |
| `LicenseUsedCount` | `int?` | Optional | Number of licenses currently assigned to devices. |
| `UpdateTime` | `string` | Optional | The date and time of when the subscription was last updated. |

## Example (as JSON)

```json
{
  "accountName": "0000123456-000001",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 500,
  "licenseUsedCount": 400,
  "updateTime": "2020-09-17T21:11:32.170Z"
}
```

