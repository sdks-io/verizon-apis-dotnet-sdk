# Service Metadata

```csharp
ServiceMetadataController serviceMetadataController = client.ServiceMetadataController;
```

## Class Name

`ServiceMetadataController`

## Methods

* [Create Service Tag](../../doc/controllers/service-metadata.md#create-service-tag)
* [Create Service Category](../../doc/controllers/service-metadata.md#create-service-category)


# Create Service Tag

Create a new Tag within user's organization.

```csharp
CreateServiceTagAsync(
    string accountName,
    List<Models.Tag> body,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `body` | [`List<Models.Tag>`](../../doc/models/tag.md) | Body, Required | **Constraints**: *Maximum Items*: `10000` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<List<Models.Tag>>>`](../../doc/models/tag.md)

## Example Usage

```csharp
string accountName = "test_account1";
List<Models.Tag> body = new List<Models.Tag>
{
    new Tag
    {
        Key = "vnsp.mec.verizon.com/servicetype",
        Description = "My service.",
        MValue = "My service",
    },
};

string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<List<Tag>> result = await serviceMetadataController.CreateServiceTagAsync(accountName, body, correlationId);
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
    "key": "vnsp.mec.verizon.com/servicetype",
    "value": "My service",
    "description": "My service."
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 415 | Unsupported media type. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Create Service Category

Create a new category within user's organization.

```csharp
CreateServiceCategoryAsync(
    string accountName,
    List<Models.Category> body,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `body` | [`List<Models.Category>`](../../doc/models/category.md) | Body, Required | **Constraints**: *Maximum Items*: `10000` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<List<Models.Category>>>`](../../doc/models/category.md)

## Example Usage

```csharp
string accountName = "test_account1";
List<Models.Category> body = new List<Models.Category>
{
    new Category
    {
        CategoryName = "MongodbSensor",
        CategoryDescription = "Mongo db Sensor",
    },
};

string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<List<Category>> result = await serviceMetadataController.CreateServiceCategoryAsync(accountName, body, correlationId);
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
    "categoryDescription": "Mongo db Sensor",
    "categoryName": "MongodbSensor",
    "createdBy": "acme-user",
    "createdDate": "2022-08-12T14:44:20.000Z",
    "id": "52da880c-f9d2-4ce5-a24a-edd50d3f2918",
    "lastModifiedDate": "2022-08-12T14:44:20.000Z",
    "updatedBy": "acme-user"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |

