# Device Actions

```csharp
DeviceActionsController deviceActionsController = client.DeviceActionsController;
```

## Class Name

`DeviceActionsController`

## Methods

* [Retrieve the Global Device List](../../doc/controllers/device-actions.md#retrieve-the-global-device-list)
* [Retrieve Device Provisioning History](../../doc/controllers/device-actions.md#retrieve-device-provisioning-history)
* [Get Asynchronous Request Status](../../doc/controllers/device-actions.md#get-asynchronous-request-status)


# Retrieve the Global Device List

Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.

```csharp
RetrieveTheGlobalDeviceListAsync(
    Models.GetDeviceListWithProfilesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceListWithProfilesRequest`](../../doc/models/get-device-list-with-profiles-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
GetDeviceListWithProfilesRequest body = new GetDeviceListWithProfilesRequest
{
    AccountName = "0000123456-00001",
    ProvisioningStatusFilter = "ACTIVE",
    ProfileStatusFilter = "UNKNOWN",
};

try
{
    ApiResponse<GIORequestResponse> result = await deviceActionsController.RetrieveTheGlobalDeviceListAsync(body);
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


# Retrieve Device Provisioning History

Retreive the provisioning history of a specific device or devices.

```csharp
RetrieveDeviceProvisioningHistoryAsync(
    Models.ProvhistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProvhistoryRequest`](../../doc/models/provhistory-request.md) | Body, Required | Device Provisioning History |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
ProvhistoryRequest body = new ProvhistoryRequest
{
    AccountName = "0000123456-00001",
    Earliest = DateTime.ParseExact("10/15/2021 04:49:35", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Latest = DateTime.ParseExact("10/15/2021 04:49:49", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};

try
{
    ApiResponse<GIORequestResponse> result = await deviceActionsController.RetrieveDeviceProvisioningHistoryAsync(body);
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


# Get Asynchronous Request Status

Get the status of an asynchronous request made with the Device Actions.

```csharp
GetAsynchronousRequestStatusAsync(
    string accountName,
    string requestID)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | - |
| `requestID` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.StatusResponse>>`](../../doc/models/status-response.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
string requestID = "d1f08526-5443-4054-9a29-4456490ea9f8";
try
{
    ApiResponse<StatusResponse> result = await deviceActionsController.GetAsynchronousRequestStatusAsync(
        accountName,
        requestID
    );
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

