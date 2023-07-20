# Service Instance Operations

```csharp
ServiceInstanceOperationsController serviceInstanceOperationsController = client.ServiceInstanceOperationsController;
```

## Class Name

`ServiceInstanceOperationsController`

## Methods

* [Service Suspend](../../doc/controllers/service-instance-operations.md#service-suspend)
* [Service Remove](../../doc/controllers/service-instance-operations.md#service-remove)
* [Service Resume](../../doc/controllers/service-instance-operations.md#service-resume)
* [Service Upgrade](../../doc/controllers/service-instance-operations.md#service-upgrade)


# Service Suspend

Suspend a service Instance

```csharp
ServiceSuspendAsync(
    string serviceInstanceId,
    string userId,
    string requestId,
    Models.UserRoleEnum userRole,
    string customerId,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceInstanceId` | `string` | Template, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `requestId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userRole` | [`Models.UserRoleEnum`](../../doc/models/user-role-enum.md) | Header, Required | **Constraints**: *Maximum Length*: `500` |
| `customerId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |

## Response Type

[`Task<ApiResponse<Models.ServiceResumeResult>>`](../../doc/models/service-resume-result.md)

## Example Usage

```csharp
string serviceInstanceId = "serviceInstanceId2";
string userId = "userId0";
string requestId = "requestId2";
Models.UserRoleEnum userRole = UserRoleEnum.ORGADMIN;
string customerId = "customerId6";
try
{
    ApiResponse<ServiceResumeResult> result = await serviceInstanceOperationsController.ServiceSuspendAsync(serviceInstanceId, userId, requestId, userRole, customerId, null);
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


# Service Remove

remove a service Instance

```csharp
ServiceRemoveAsync(
    string serviceInstanceId,
    string userId,
    string requestId,
    Models.UserRoleEnum userRole,
    string customerId,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceInstanceId` | `string` | Template, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `requestId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userRole` | [`Models.UserRoleEnum`](../../doc/models/user-role-enum.md) | Header, Required | **Constraints**: *Maximum Length*: `500` |
| `customerId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |

## Response Type

[`Task<ApiResponse<Models.ServiceResumeResult>>`](../../doc/models/service-resume-result.md)

## Example Usage

```csharp
string serviceInstanceId = "serviceInstanceId2";
string userId = "userId0";
string requestId = "requestId2";
Models.UserRoleEnum userRole = UserRoleEnum.ORGADMIN;
string customerId = "customerId6";
try
{
    ApiResponse<ServiceResumeResult> result = await serviceInstanceOperationsController.ServiceRemoveAsync(serviceInstanceId, userId, requestId, userRole, customerId, null);
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


# Service Resume

Resumes a suspended Service Instance

```csharp
ServiceResumeAsync(
    string serviceInstanceId,
    string userId,
    string requestId,
    Models.UserRoleEnum userRole,
    string customerId,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceInstanceId` | `string` | Template, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `requestId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userRole` | [`Models.UserRoleEnum`](../../doc/models/user-role-enum.md) | Header, Required | **Constraints**: *Maximum Length*: `500` |
| `customerId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |

## Response Type

[`Task<ApiResponse<Models.ServiceResumeResult>>`](../../doc/models/service-resume-result.md)

## Example Usage

```csharp
string serviceInstanceId = "serviceInstanceId2";
string userId = "userId0";
string requestId = "requestId2";
Models.UserRoleEnum userRole = UserRoleEnum.ORGADMIN;
string customerId = "customerId6";
try
{
    ApiResponse<ServiceResumeResult> result = await serviceInstanceOperationsController.ServiceResumeAsync(serviceInstanceId, userId, requestId, userRole, customerId, null);
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


# Service Upgrade

upgrade a service Instance

```csharp
ServiceUpgradeAsync(
    string serviceInstanceId,
    string userId,
    string requestId,
    Models.UserRoleEnum userRole,
    string customerId,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceInstanceId` | `string` | Template, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `requestId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `userRole` | [`Models.UserRoleEnum`](../../doc/models/user-role-enum.md) | Header, Required | **Constraints**: *Maximum Length*: `500` |
| `customerId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |

## Response Type

[`Task<ApiResponse<Models.ServiceResumeResult>>`](../../doc/models/service-resume-result.md)

## Example Usage

```csharp
string serviceInstanceId = "serviceInstanceId2";
string userId = "userId0";
string requestId = "requestId2";
Models.UserRoleEnum userRole = UserRoleEnum.ORGADMIN;
string customerId = "customerId6";
try
{
    ApiResponse<ServiceResumeResult> result = await serviceInstanceOperationsController.ServiceUpgradeAsync(serviceInstanceId, userId, requestId, userRole, customerId, null);
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

