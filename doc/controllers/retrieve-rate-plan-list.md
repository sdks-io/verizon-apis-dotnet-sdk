# Retrieve Rate Plan List

```csharp
RetrieveRatePlanListController retrieveRatePlanListController = client.RetrieveRatePlanListController;
```

## Class Name

`RetrieveRatePlanListController`


# Get Rate Plan List

Retrieves the rate plans and rate plan details for a profile ID.

```csharp
GetRatePlanListAsync(
    string ecpdId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ecpdId` | `string` | Template, Required | The Enterprise Customer Profile Database ID. This is the same as the accountName value |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Rateplan](../../doc/models/rateplan.md).

## Example Usage

```csharp
string ecpdId = "0000123456-00001";
try
{
    ApiResponse<Rateplan> result = await retrieveRatePlanListController.GetRatePlanListAsync(ecpdId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RuleRestErrorResponseException)
    {
       // TODO: Handle RuleRestErrorResponseException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "ratePlanGroup": [
    {
      "ratePlanGroupDescription": "AGS Description_73",
      "ratePlanType": "AccountShareGroup",
      "ratePlan": [
        {
          "description": "PlanDescription 2",
          "sizeKb": "1048576",
          "carrierRatePlanCode": "Service plan code value",
          "zeroDollarBilling": false,
          "promotionOffered": false,
          "promotionDays": -2147483648,
          "ratePlanType": "accountShare",
          "account": [
            {
              "accountName": "0000123456-00001",
              "mtasAccountNumber": "0000123456-00001"
            },
            {
              "accountName": "0000123456-00001",
              "mtasAccountNumber": "0000123456-00001"
            }
          ]
        }
      ]
    },
    {
      "description": "PlanDescription 2",
      "sizeKb": "1048576",
      "carrierRatePlanCode": "Service plan code value",
      "zeroDollarBilling": false,
      "promotionOffered": false,
      "promotionDays": -2147483648,
      "ratePlanType": "accountShare",
      "account": [
        {
          "accountName": "0000123456-00001",
          "mtasAccountNumber": "0000123456-00001"
        },
        {
          "accountName": "0000123456-00001",
          "mtasAccountNumber": "0000123456-00001"
        }
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`RuleRestErrorResponseException`](../../doc/models/rule-rest-error-response-exception.md) |

