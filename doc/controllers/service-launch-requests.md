# Service Launch Requests

```csharp
ServiceLaunchRequestsController serviceLaunchRequestsController = client.ServiceLaunchRequestsController;
```

## Class Name

`ServiceLaunchRequestsController`

## Methods

* [Get Service Launch Request](../../doc/controllers/service-launch-requests.md#get-service-launch-request)
* [Create Service Launch Request](../../doc/controllers/service-launch-requests.md#create-service-launch-request)
* [Submit Service Launch Request](../../doc/controllers/service-launch-requests.md#submit-service-launch-request)


# Get Service Launch Request

Get information related to a service launch request.

```csharp
GetServiceLaunchRequestAsync(
    string accountName,
    string userName,
    Guid? id = null,
    string correlationId = null,
    string name = null,
    long? offset = null,
    long? limit = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `userName` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `id` | `Guid?` | Query, Optional | Service launch request Id. |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `name` | `string` | Query, Optional | Service request name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `offset` | `long?` | Query, Optional | **Constraints**: `>= 0`, `<= 1024` |
| `limit` | `long?` | Query, Optional | **Constraints**: `>= 0`, `<= 1024` |

## Response Type

[`Task<ApiResponse<Models.ServiceLaunchRequestsResult>>`](../../doc/models/service-launch-requests-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string userName = "acme-user";
Guid? id = new Guid("eda2cb4e-50ef-4ae8-b304-7d2f0f7a21c1");
string correlationId = "eda2cb4e-50ef-4ae8-b304-7d2f0f7a21c1";
string name = "MdpTest3";
long? offset = 15L;
long? limit = 16L;
try
{
    ApiResponse<ServiceLaunchRequestsResult> result = await serviceLaunchRequestsController.GetServiceLaunchRequestAsync(accountName, userName, id, correlationId, name, offset, limit);
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


# Create Service Launch Request

Create a request for launching a service.

```csharp
CreateServiceLaunchRequestAsync(
    string accountName,
    string userName,
    string correlationId = null,
    Models.CreateServiceLaunchRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `userName` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `body` | [`Models.CreateServiceLaunchRequest`](../../doc/models/create-service-launch-request.md) | Body, Optional | Request for launching a service. |

## Response Type

[`Task<ApiResponse<Models.ServiceLaunchRequestResult>>`](../../doc/models/service-launch-request-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string userName = "acme-user";
string correlationId = "eda2cb4e-50ef-4ae8-b304-7d2f0f7a21c1";
CreateServiceLaunchRequest body = new CreateServiceLaunchRequest
{
    Name = "MdpTest3",
    CspProfileId = "6789409c-12c3-4fc9-b64f-71d1611c4f09",
    ServiceProfileId = "6789409c-12c3-4fc9-b64f-71d1611c4f09",
    ServiceName = "mongodbdemo0710",
    ServiceVersion = "2.5.6",
};

try
{
    ApiResponse<ServiceLaunchRequestResult> result = await serviceLaunchRequestsController.CreateServiceLaunchRequestAsync(accountName, userName, correlationId, body);
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
| 400 | HTTP 400 Bad Request. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 404 | HTTP 404 Not found. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |


# Submit Service Launch Request

This endpoint allows the user to submit a service request that describes the resource requirements of a service. This API submit an object of the service request and moves it to STATE from “DRAFT”  to “INSTANTIATED” and triggers the launch flow.

```csharp
SubmitServiceLaunchRequestAsync(
    Guid id,
    string accountName,
    string userName,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | A unique Id assigned to the request by system calling API. |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]` |
| `userName` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |

## Response Type

[`Task<ApiResponse<Models.ServiceLaunchRequestResult>>`](../../doc/models/service-launch-request-result.md)

## Example Usage

```csharp
Guid id = new Guid("eda2cb4e-50ef-4ae8-b304-7d2f0f7a21c1");
string accountName = "test_account1";
string userName = "acme-user";
string correlationId = "eda2cb4e-50ef-4ae8-b304-7d2f0f7a21c1";
try
{
    ApiResponse<ServiceLaunchRequestResult> result = await serviceLaunchRequestsController.SubmitServiceLaunchRequestAsync(id, accountName, userName, correlationId);
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
| 400 | HTTP 400 Bad Request. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 412 | Precondition Failed. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |

