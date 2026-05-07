# Device Credential Management

```csharp
DeviceCredentialManagementController deviceCredentialManagementController = client.DeviceCredentialManagementController;
```

## Class Name

`DeviceCredentialManagementController`

## Methods

* [Retrieve Credentials](../../doc/controllers/device-credential-management.md#retrieve-credentials)
* [Generate Credentials](../../doc/controllers/device-credential-management.md#generate-credentials)
* [Reset Credentials](../../doc/controllers/device-credential-management.md#reset-credentials)
* [Drop Credentials](../../doc/controllers/device-credential-management.md#drop-credentials)


# Retrieve Credentials

```csharp
RetrieveCredentialsAsync(
    Models.CredentialsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CredentialsRequest`](../../doc/models/credentials-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RetrieveResponse](../../doc/models/retrieve-response.md).

## Example Usage

```csharp
CredentialsRequest body = new CredentialsRequest
{
    ECPD = "3161585",
    AccountNumber = "0844021539-00001",
    Items = new List<DeviceCredentialRequestItem>
    {
        new DeviceCredentialRequestItem
        {
            Imei = "221000008775573",
        },
    },
};

try
{
    ApiResponse<RetrieveResponse> result = await deviceCredentialManagementController.RetrieveCredentialsAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorResponseException)
    {
       // TODO: Handle ErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request / Verification Failure | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |
| 401 | Unauthorized | `ApiException` |


# Generate Credentials

```csharp
GenerateCredentialsAsync(
    Models.CredentialsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CredentialsRequest`](../../doc/models/credentials-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GenerateResponse](../../doc/models/generate-response.md).

## Example Usage

```csharp
CredentialsRequest body = new CredentialsRequest
{
    ECPD = "3161585",
    AccountNumber = "0844021539-00001",
    Items = new List<DeviceCredentialRequestItem>
    {
        new DeviceCredentialRequestItem
        {
            Imei = "221000008775573",
        },
    },
};

try
{
    ApiResponse<GenerateResponse> result = await deviceCredentialManagementController.GenerateCredentialsAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorResponseException)
    {
       // TODO: Handle ErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |


# Reset Credentials

```csharp
ResetCredentialsAsync(
    Models.CredentialsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CredentialsRequest`](../../doc/models/credentials-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GenerateResponse](../../doc/models/generate-response.md).

## Example Usage

```csharp
CredentialsRequest body = new CredentialsRequest
{
    ECPD = "3161585",
    AccountNumber = "0844021539-00001",
    Items = new List<DeviceCredentialRequestItem>
    {
        new DeviceCredentialRequestItem
        {
            Imei = "221000008775573",
        },
    },
};

try
{
    ApiResponse<GenerateResponse> result = await deviceCredentialManagementController.ResetCredentialsAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorResponseException)
    {
       // TODO: Handle ErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |


# Drop Credentials

```csharp
DropCredentialsAsync(
    Models.CredentialsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CredentialsRequest`](../../doc/models/credentials-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DropResponse](../../doc/models/drop-response.md).

## Example Usage

```csharp
CredentialsRequest body = new CredentialsRequest
{
    ECPD = "3161585",
    AccountNumber = "0844021539-00001",
    Items = new List<DeviceCredentialRequestItem>
    {
        new DeviceCredentialRequestItem
        {
            Imei = "221000008775573",
        },
    },
};

try
{
    ApiResponse<DropResponse> result = await deviceCredentialManagementController.DropCredentialsAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorResponseException)
    {
       // TODO: Handle ErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorResponseException`](../../doc/models/error-response-exception.md) |

