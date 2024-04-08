# Managinge SIM Profiles

```csharp
ManagingeSIMProfilesController managingeSIMProfilesController = client.ManagingeSIMProfilesController;
```

## Class Name

`ManagingeSIMProfilesController`

## Methods

* [Activate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#activate-a-device-profile)
* [Enable a Device Profile](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile)
* [Deactivate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#deactivate-a-device-profile)
* [Enable a Device Profile for Download](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile-for-download)
* [Download a Device Profile](../../doc/controllers/managinge-sim-profiles.md#download-a-device-profile)
* [Delete a Device Profile](../../doc/controllers/managinge-sim-profiles.md#delete-a-device-profile)


# Activate a Device Profile

Activate a device with either a lead or local profile.

```csharp
ActivateADeviceProfileAsync(
    Models.GIOProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GIOProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
GIOProfileRequest body = new GIOProfileRequest
{
    Devices = new List<Models.GIODeviceList>
    {
        new GIODeviceList
        {
        },
    },
    AccountName = "0000123456-00001",
    MdnZipCode = "12345",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GIORequestResponse> result = await managingESIMProfilesController.ActivateADeviceProfileAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile

Enable a device lead or local profile.

```csharp
EnableADeviceProfileAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GIORequestResponse> result = await managingESIMProfilesController.EnableADeviceProfileAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Deactivate a Device Profile

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

```csharp
DeactivateADeviceProfileAsync(
    Models.GIODeactivateDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GIODeactivateDeviceProfileRequest`](../../doc/models/gio-deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
GIODeactivateDeviceProfileRequest body = new GIODeactivateDeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
    EtfWaiver = false,
    ReasonCode = "FF",
};

try
{
    ApiResponse<GIORequestResponse> result = await managingESIMProfilesController.DeactivateADeviceProfileAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile for Download

Enable the Global IoT Orchestration device profile for download.

```csharp
EnableADeviceProfileForDownloadAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GIORequestResponse> result = await managingESIMProfilesController.EnableADeviceProfileForDownloadAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Download a Device Profile

Download a Global IoT Orchestration device profile.

```csharp
DownloadADeviceProfileAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GIORequestResponse> result = await managingESIMProfilesController.DownloadADeviceProfileAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Delete a Device Profile

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

```csharp
DeleteADeviceProfileAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GIORequestResponse> result = await managingESIMProfilesController.DeleteADeviceProfileAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

