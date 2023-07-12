# Service Launch Profiles

```csharp
ServiceLaunchProfilesController serviceLaunchProfilesController = client.ServiceLaunchProfilesController;
```

## Class Name

`ServiceLaunchProfilesController`

## Methods

* [Create Service Profile](../../doc/controllers/service-launch-profiles.md#create-service-profile)
* [Update Service Profile](../../doc/controllers/service-launch-profiles.md#update-service-profile)
* [Submit Service Profile](../../doc/controllers/service-launch-profiles.md#submit-service-profile)


# Create Service Profile

Creates a service profile that describes the resource requirements of a service.

```csharp
CreateServiceProfileAsync(
    string accountName,
    Models.CreateServiceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]` |
| `body` | [`Models.CreateServiceProfileRequest`](../../doc/models/create-service-profile-request.md) | Body, Required | Request for creation of a service profile. |

## Response Type

[`Task<ApiResponse<Models.ServicesProfileRegistration>>`](../../doc/models/services-profile-registration.md)

## Example Usage

```csharp
string accountName = "test_account1";
CreateServiceProfileRequest body = new CreateServiceProfileRequest
{
    Name = "mongo-pmec-profile-mdp7",
    ServiceName = "mongodb-customer-prerun",
    ServiceVersion = "1.0.0",
};

try
{
    ApiResponse<ServicesProfileRegistration> result = await serviceLaunchProfilesController.CreateServiceProfileAsync(accountName, body);
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
| Default | HTTP 500 Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |


# Update Service Profile

Update the definition of a service profile.

```csharp
UpdateServiceProfileAsync(
    string id,
    Models.CreateServiceProfileRequest body,
    string accountName = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Unique ID of the service profile.<br>**Constraints**: *Maximum Length*: `36`, *Pattern*: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$` |
| `body` | [`Models.CreateServiceProfileRequest`](../../doc/models/create-service-profile-request.md) | Body, Required | Request with new information for updating the service profile. |
| `accountName` | `string` | Header, Optional | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]` |

## Response Type

`Task<ApiResponse<string>>`

## Example Usage

```csharp
string id = "eda2cb4e-50ef-4ae8-b304-7d2f0f7a21c1";
CreateServiceProfileRequest body = new CreateServiceProfileRequest
{
    Name = "mongo-pmec-profile-mdp7",
    ServiceName = "mongodb-customer-prerun",
    ServiceVersion = "1.0.0",
};

string accountName = "test_account1";
try
{
    ApiResponse<string> result = await serviceLaunchProfilesController.UpdateServiceProfileAsync(id, body, accountName);
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
| Default | HTTP 500 Internal Server Error. | [`EdgeServiceLaunchResultException`](../../doc/models/edge-service-launch-result-exception.md) |


# Submit Service Profile

Helps register a service profile.

```csharp
SubmitServiceProfileAsync(
    string id,
    Models.ServicesProfileRegistration body,
    string accountName = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Unique service profile ID.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]` |
| `body` | [`Models.ServicesProfileRegistration`](../../doc/models/services-profile-registration.md) | Body, Required | Request for registration of a service profile. |
| `accountName` | `string` | Header, Optional | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]` |

## Response Type

[`Task<ApiResponse<Models.ServicesProfileRegistrationResult>>`](../../doc/models/services-profile-registration-result.md)

## Example Usage

```csharp
string id = "eda2cb4e-50ef-4ae8-b304-7d2f0f7a21c1";
ServicesProfileRegistration body = new ServicesProfileRegistration
{
    Id = new Guid("6789409c-12c3-4fc9-b64f-71d1611c4f09"),
    Name = "mongo-pmec-profile-mdp7",
    ServiceName = "mongodb-customer-prerun",
    ServiceVersion = "1.0.0",
    Version = "1.0.0",
    State = ServicesProfileRegistrationStateEnum.DRAFT,
    CustomerID = "acme",
    CreatedBy = "acme-user",
    CreatedAt = "2022-08-03T03:43:17.504Z",
    LastUpdatedAt = "2022-08-03T03:43:17.504Z",
    LinkedServiceInstances = new List<Models.LinkedServiceInstance>
    {

    },
    AccessIntents = new AccessIntents
    {
    },
    PlacementIntents = new PlacementIntents
    {
        IntentChain = new List<Models.IntentChainItem>
        {
            new IntentChainItem
            {
                Name = "Compliance",
                Input = ApiHelper.JsonDeserialize<object>("{\"deploymentLocations\":[{\"csp\":\"AWS_WL\",\"region\":\"US_WEST_2\",\"zoneId\":[\"us-west-2-wl1-den-wlz-1\"]}]}"),
            },
        },
    },
    DeploymentLocations = new List<Models.DeploymentLocation>
    {

    },
};

string accountName = "test_account1";
try
{
    ApiResponse<ServicesProfileRegistrationResult> result = await serviceLaunchProfilesController.SubmitServiceProfileAsync(id, body, accountName);
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

