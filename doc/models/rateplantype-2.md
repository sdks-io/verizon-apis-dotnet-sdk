
# Rateplantype 2

## Structure

`Rateplantype2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `SizeKb` | `string` | Optional | - |
| `CarrierRatePlanCode` | `string` | Optional | - |
| `ZeroDollarBilling` | `bool?` | Optional | - |
| `PromotionOffered` | `bool?` | Optional | - |
| `PromotionDays` | `int?` | Optional | - |
| `RatePlanType` | `string` | Optional | - |
| `Account` | [`List<Accountid>`](../../doc/models/accountid.md) | Optional | Account information |

## Example (as JSON)

```json
{
  "description": "PlanDescription 2",
  "sizeKb": "1048576",
  "carrierRatePlanCode": "Service plan code value",
  "zeroDollarBilling": false,
  "promotionOffered": false,
  "promotionDays": -2147483648
}
```

