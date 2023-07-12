# Service Instances

```csharp
ServiceInstancesController serviceInstancesController = client.ServiceInstancesController;
```

## Class Name

`ServiceInstancesController`

## Methods

* [Retrieve Service Instance](../../doc/controllers/service-instances.md#retrieve-service-instance)
* [List Services Instances](../../doc/controllers/service-instances.md#list-services-instances)


# Retrieve Service Instance

Retrieve information of a service instance.

```csharp
RetrieveServiceInstanceAsync(
    string serviceInstanceId,
    string accountName,
    bool? cluster = false)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceInstanceId` | `string` | Template, Required | Unique Id of the service instance.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `cluster` | `bool?` | Query, Optional | **Default**: `false` |

## Response Type

[`Task<ApiResponse<Models.ServiceInstancesResultSetItem>>`](../../doc/models/service-instances-result-set-item.md)

## Example Usage

```csharp
string serviceInstanceId = "e0abe65f-b294-4673-a60c-d31f26ca7a8c";
string accountName = "test_account1";
bool? cluster = false;
try
{
    ApiResponse<ServiceInstancesResultSetItem> result = await serviceInstancesController.RetrieveServiceInstanceAsync(serviceInstanceId, accountName, cluster);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 403 | Forbidden. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 404 | Not found. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 415 | Unsupported media type. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 429 | Too many requests. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| Default | Unexpected error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |


# List Services Instances

Retrieve all instances for all services.

```csharp
ListServicesInstancesAsync(
    string accountName,
    string offset = null,
    string state = null,
    string limit = null,
    string searchbyname = null,
    List<string> listofstate = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `offset` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `state` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `limit` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64` |
| `searchbyname` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `listofstate` | `List<string>` | Query, Optional | **Constraints**: *Maximum Items*: `100`, *Maximum Length*: `128`, *Pattern*: `^(.*)$` |

## Response Type

[`Task<ApiResponse<Models.ServiceInstancesResult>>`](../../doc/models/service-instances-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string state = "NOT_READY";
string searchbyname = "PQAService-Demo-08182022";
try
{
    ApiResponse<ServiceInstancesResult> result = await serviceInstancesController.ListServicesInstancesAsync(accountName, null, state, null, searchbyname, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 403 | Forbidden. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 404 | Not found. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 415 | Unsupported media type. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 429 | Too many requests. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| Default | Unexpected error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |

