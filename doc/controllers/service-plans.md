# Service Plans

```csharp
ServicePlansController servicePlansController = client.ServicePlansController;
```

## Class Name

`ServicePlansController`


# List Account Service Plans

Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.

```csharp
ListAccountServicePlansAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.ServicePlan>](../../doc/models/service-plan.md).

## Example Usage

```csharp
string aname = "0252012345-00001";
try
{
    ApiResponse<List<ServicePlan>> result = await servicePlansController.ListAccountServicePlansAsync(aname);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
[
  {
    "name": "2MSHR5GB",
    "code": "M2MSHR5GB",
    "sizeKb": 0,
    "carrierServicePlanCode": "84638"
  },
  {
    "name": "TNTL200TALK",
    "code": "NTL200TALK",
    "sizeKb": 0,
    "carrierServicePlanCode": "74644"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

