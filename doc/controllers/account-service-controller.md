# Account Service Controller

```csharp
AccountServiceController accountServiceController = client.AccountServiceController;
```

## Class Name

`AccountServiceController`


# Get Account Information Using GET

Returns aaccount information associated with a specified account.

```csharp
GetAccountInformationUsingGETAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The account's numeric name, including leading zeroes. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GetAccountInformationResponseforplanner](../../doc/models/get-account-information-responseforplanner.md).

## Example Usage

```csharp
string accountName = "0000123456-00002";
try
{
    ApiResponse<GetAccountInformationResponseforplanner> result = await accountServiceController.GetAccountInformationUsingGETAsync(accountName);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestErrorResponseforplannerException)
    {
       // TODO: Handle RestErrorResponseforplannerException exception here
    }
    if (e is AuthRestErrorResponseforplannerException)
    {
       // TODO: Handle AuthRestErrorResponseforplannerException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "string",
  "accountNumber": "0000123456-00001",
  "carriers": [
    "carrier name(s)"
  ],
  "features": [
    "feature names"
  ],
  "ipPools": [
    {
      "isDefaultPool": true,
      "poolName": "name of the pool",
      "poolType": "type of pool"
    }
  ],
  "isProvisioningAllowed": true,
  "organizationName": "Org Name",
  "servicePlans": [
    {
      "carrierServicePlanCode": "name of the service plan code",
      "code": "the activation code",
      "extendedAttributes": [
        {
          "key": "key name",
          "value": "key value"
        }
      ],
      "name": "name of the active profile carrier",
      "sizeKb": 1000
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 401 | Unauthorized | [`AuthRestErrorResponseforplannerException`](../../doc/models/auth-rest-error-responseforplanner-exception.md) |
| 403 | Forbidden | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 404 | Not Found / Does not exist | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 406 | Format / Request Unacceptable | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| 429 | Too many requests | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |
| Default | Error response | [`RestErrorResponseforplannerException`](../../doc/models/rest-error-responseforplanner-exception.md) |

