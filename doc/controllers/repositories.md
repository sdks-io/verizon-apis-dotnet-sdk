# Repositories

```csharp
RepositoriesController repositoriesController = client.RepositoriesController;
```

## Class Name

`RepositoriesController`

## Methods

* [Delete Repository](../../doc/controllers/repositories.md#delete-repository)
* [List Repositories](../../doc/controllers/repositories.md#list-repositories)
* [Create Repository](../../doc/controllers/repositories.md#create-repository)


# Delete Repository

Delete the repository.

```csharp
DeleteRepositoryAsync(
    string accountName,
    string repositoryName,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `repositoryName` | `string` | Template, Required | Name of the repository which is about to be deleted.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9-]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.EdgeServiceOnboardingDeleteResult>>`](../../doc/models/edge-service-onboarding-delete-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string repositoryName = "dev-api-demo-repo-mdp";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<EdgeServiceOnboardingDeleteResult> result = await repositoriesController.DeleteRepositoryAsync(accountName, repositoryName, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "message": "service deleted succesfully",
  "status": "success",
  "subStatus": "service delete - success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# List Repositories

Get all repositories in the platform.

```csharp
ListRepositoriesAsync(
    string accountName,
    string correlationId = null,
    string type = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |
| `type` | `string` | Query, Optional | Repository type.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<List<Models.Repository>>>`](../../doc/models/repository.md)

## Example Usage

```csharp
string accountName = "test_account1";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
string type = "GIT";
try
{
    ApiResponse<List<Repository>> result = await repositoriesController.ListRepositoriesAsync(accountName, correlationId, type);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
[
  {
    "name": "myRepo"
  },
  {
    "name": "anotherRepo"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Create Repository

Create a repository within user's organziation.

```csharp
CreateRepositoryAsync(
    string accountName,
    Models.Repository body,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `body` | [`Models.Repository`](../../doc/models/repository.md) | Body, Required | - |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.Repository>>`](../../doc/models/repository.md)

## Example Usage

```csharp
string accountName = "test_account1";
Repository body = new Repository
{
    Name = "myRepo",
    Description = "My organization repository.",
    Type = EdgeServiceRepositoryTypeEnum.Git,
    Tag = "myTag",
    Endpoint = "https://charts.bitnami.com/bitnami",
};

string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<Repository> result = await repositoriesController.CreateRepositoryAsync(accountName, body, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "createdBy": "dev-api-user",
  "createdDate": "2022-08-25T11:38:06.000Z",
  "endpoint": "https://charts.bitnami.com/bitnami",
  "id": "60d0a7f0-1811-43fd-be4a-b47e5fe2c755",
  "lastModifiedDate": "2022-08-25T11:38:06.000Z",
  "name": "dev-api-demo-repo-1",
  "type": "Helm",
  "updatedBy": "dev-api-user"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |

