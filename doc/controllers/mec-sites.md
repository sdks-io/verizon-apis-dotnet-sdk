# MEC Sites

```csharp
MECSitesController mECSitesController = client.MECSitesController;
```

## Class Name

`MECSitesController`

## Methods

* [List MEC Site Locations](../../doc/controllers/mec-sites.md#list-mec-site-locations)
* [List ERN Cluster Namespaces](../../doc/controllers/mec-sites.md#list-ern-cluster-namespaces)


# List MEC Site Locations

Supports fetching MEC locations so the user can view the city.

```csharp
ListMECSiteLocationsAsync(
    string accountName = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Optional | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]` |

## Response Type

[`Task<ApiResponse<Models.MECSiteLocationsResult>>`](../../doc/models/mec-site-locations-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
try
{
    ApiResponse<MECSiteLocationsResult> result = await mECSitesController.ListMECSiteLocationsAsync(accountName);
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
| 400 | Error Response. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |


# List ERN Cluster Namespaces

Retrieve all clusters for the customer.

```csharp
ListERNClusterNamespacesAsync(
    string userId,
    string role,
    string customerId,
    string requestId,
    string eRN = null,
    string name = null,
    string offset = null,
    string limit = null,
    string correlationId = null,
    Models.ClusterStateEnum? clusterState = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `role` | `string` | Header, Required | **Constraints**: *Maximum Length*: `500` |
| `customerId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `requestId` | `string` | Header, Required | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `eRN` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `name` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `offset` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `limit` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `clusterState` | [`Models.ClusterStateEnum?`](../../doc/models/cluster-state-enum.md) | Query, Optional | **Constraints**: *Maximum Length*: `32` |

## Response Type

[`Task<ApiResponse<Models.ClustersNamespaces>>`](../../doc/models/clusters-namespaces.md)

## Example Usage

```csharp
string userId = "userId0";
string role = "role6";
string customerId = "customerId6";
string requestId = "requestId2";
try
{
    ApiResponse<ClustersNamespaces> result = await mECSitesController.ListERNClusterNamespacesAsync(userId, role, customerId, requestId, null, null, null, null, null, null);
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
| 404 | Not found. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |
| Default | Unexpected error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |

