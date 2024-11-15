# Device Profile Management

```csharp
DeviceProfileManagementController deviceProfileManagementController = client.DeviceProfileManagementController;
```

## Class Name

`DeviceProfileManagementController`

## Methods

* [Activate Device Through Profile](../../doc/controllers/device-profile-management.md#activate-device-through-profile)
* [Profile to Activate Device](../../doc/controllers/device-profile-management.md#profile-to-activate-device)
* [Profile to Deactivate Device](../../doc/controllers/device-profile-management.md#profile-to-deactivate-device)
* [Profile to Set Fallback Attribute](../../doc/controllers/device-profile-management.md#profile-to-set-fallback-attribute)


# Activate Device Through Profile

Uses the profile to bring the device under management.

```csharp
ActivateDeviceThroughProfileAsync(
    Models.ActivateDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ActivateDeviceProfileRequest`](../../doc/models/activate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
ActivateDeviceProfileRequest body = new ActivateDeviceProfileRequest
{
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "32-digit EID",
                    Kind = "eid",
                },
                new DeviceId
                {
                    Id = "15-digit IMEI",
                    Kind = "imei",
                },
            },
        },
    },
    AccountName = "0000123456-00001",
    ServicePlan = "The service plan name",
    MdnZipCode = "five digit zip code",
};

try
{
    ApiResponse<RequestResponse> result = await deviceProfileManagementController.ActivateDeviceThroughProfileAsync(body);
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Activate Device

Uses the profile to activate the device.

```csharp
ProfileToActivateDeviceAsync(
    Models.ProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest`](../../doc/models/profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
ProfileRequest body = new ProfileRequest
{
    AccountName = "0000123456-00001",
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
        },
    },
    CarrierName = "the name of the mobile service provider",
    ServicePlan = "The service plan name",
    MdnZipCode = "five digit zip code",
};

try
{
    ApiResponse<RequestResponse> result = await deviceProfileManagementController.ProfileToActivateDeviceAsync(body);
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Deactivate Device

Uses the profile to deactivate the device.

```csharp
ProfileToDeactivateDeviceAsync(
    Models.DeactivateDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeactivateDeviceProfileRequest`](../../doc/models/deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
DeactivateDeviceProfileRequest body = new DeactivateDeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ReasonCode = "a short code for the reason action was taken",
    CarrierName = "the name of the mobile service provider",
    EtfWaiver = true,
    CheckFallbackProfile = false,
};

try
{
    ApiResponse<RequestResponse> result = await deviceProfileManagementController.ProfileToDeactivateDeviceAsync(body);
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Set Fallback Attribute

Allows the profile to set the fallback attribute to the device.

```csharp
ProfileToSetFallbackAttributeAsync(
    Models.SetFallbackAttributeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SetFallbackAttributeRequest`](../../doc/models/set-fallback-attribute-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
SetFallbackAttributeRequest body = new SetFallbackAttributeRequest
{
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
        },
    },
    AccountName = "0000123456-00001",
    CarrierName = "the name of the mobile service provider",
};

try
{
    ApiResponse<RequestResponse> result = await deviceProfileManagementController.ProfileToSetFallbackAttributeAsync(body);
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

