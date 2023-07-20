# Device Profile Management

```csharp
DeviceProfileManagementController deviceProfileManagementController = client.DeviceProfileManagementController;
```

## Class Name

`DeviceProfileManagementController`

## Methods

* [Profile to Set Fallback Attribute](../../doc/controllers/device-profile-management.md#profile-to-set-fallback-attribute)
* [Activate Device Through Profile](../../doc/controllers/device-profile-management.md#activate-device-through-profile)
* [Profile to Activate Device](../../doc/controllers/device-profile-management.md#profile-to-activate-device)
* [Profile to Deactivate Device](../../doc/controllers/device-profile-management.md#profile-to-deactivate-device)


# Profile to Set Fallback Attribute

Allows the profile to set the fallback attribute to the device.

```csharp
ProfileToSetFallbackAttributeAsync(
    Models.SetFallbackAttributeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.SetFallbackAttributeRequest`](../../doc/models/set-fallback-attribute-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
SetFallbackAttributeRequest body = new SetFallbackAttributeRequest
{
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


# Activate Device Through Profile

Uses the profile to bring the device under management.

```csharp
ActivateDeviceThroughProfileAsync(
    Models.ActivateDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ActivateDeviceProfileRequest`](../../doc/models/activate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
ActivateDeviceProfileRequest body = new ActivateDeviceProfileRequest
{
    Devices = new List<Models.DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<Models.DeviceId1>
            {
                new DeviceId1
                {
                    Id = "32-digit EID",
                    Kind = KindEnum.Eid,
                },
                new DeviceId1
                {
                    Id = "15-digit IMEI",
                    Kind = KindEnum.Imei,
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
| `body` | [`Models.ProfileRequest`](../../doc/models/profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
ProfileRequest body = new ProfileRequest
{
    CarrierName = "the name of the mobile service provider",
    AccountName = "0000123456-00001",
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
    Models.ProfileRequest2 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ProfileRequest2`](../../doc/models/profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
ProfileRequest2 body = new ProfileRequest2
{
    AccountName = "0000123456-00001",
    CarrierName = "the name of the mobile service provider",
    ReasonCode = "a short code for the reason action was taken",
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

