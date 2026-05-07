# Device Service Management

```csharp
DeviceServiceManagementController deviceServiceManagementController = client.DeviceServiceManagementController;
```

## Class Name

`DeviceServiceManagementController`

## Methods

* [Get Device Hyper Precise Status](../../doc/controllers/device-service-management.md#get-device-hyper-precise-status)
* [Update Device Hyper Precise Status](../../doc/controllers/device-service-management.md#update-device-hyper-precise-status)


# Get Device Hyper Precise Status

Gets the list of a status for hyper-precise location devices.

```csharp
GetDeviceHyperPreciseStatusAsync(
    string imei,
    string accountNumber)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imei` | `string` | Query, Required | The International Mobile Equipment Identifier of the device. |
| `accountNumber` | `string` | Query, Required | The numeric name of the account and must include leading zeroes. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.BullseyeServiceResult](../../doc/models/bullseye-service-result.md).

## Example Usage

```csharp
string imei = "15-digit IMEI";
string accountNumber = "0000123456-00001";
try
{
    ApiResponse<BullseyeServiceResult> result = await deviceServiceManagementController.GetDeviceHyperPreciseStatusAsync(
        imei,
        accountNumber
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is HyperPreciseLocationResultException)
    {
       // TODO: Handle HyperPreciseLocationResultException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |


# Update Device Hyper Precise Status

Enable/disable hyper-precise service for a device.

```csharp
UpdateDeviceHyperPreciseStatusAsync(
    Models.BullseyeServiceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`BullseyeServiceRequest`](../../doc/models/bullseye-service-request.md) | Body, Required | List of devices and hyper-precise required statuses. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.BullseyeServiceResult](../../doc/models/bullseye-service-result.md).

## Example Usage

```csharp
BullseyeServiceRequest body = new BullseyeServiceRequest
{
    DeviceList = new List<DeviceServiceRequest>
    {
        new DeviceServiceRequest
        {
            Imei = "15-digit IMEI",
            BullseyeEnable = new HplBullseyeEnable
            {
                BullseyeEnable = true,
            },
        },
    },
    AccountNumber = "0000123456-00001",
};

try
{
    ApiResponse<BullseyeServiceResult> result = await deviceServiceManagementController.UpdateDeviceHyperPreciseStatusAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is HyperPreciseLocationResultException)
    {
       // TODO: Handle HyperPreciseLocationResultException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |

