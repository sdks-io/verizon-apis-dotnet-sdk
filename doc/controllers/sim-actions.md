# SIM Actions

```csharp
SIMActionsController sIMActionsController = client.SIMActionsController;
```

## Class Name

`SIMActionsController`

## Methods

* [Newactivatecode](../../doc/controllers/sim-actions.md#newactivatecode)
* [Setactivate Using POST](../../doc/controllers/sim-actions.md#setactivate-using-post)
* [Setdeactivate Using POST](../../doc/controllers/sim-actions.md#setdeactivate-using-post)


# Newactivatecode

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

```csharp
NewactivatecodeAsync(
    Models.ESIMProfileRequest2 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ESIMProfileRequest2`](../../doc/models/esim-profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.ESIMRequestResponse>>`](../../doc/models/esim-request-response.md)

## Example Usage

```csharp
ESIMProfileRequest2 body = new ESIMProfileRequest2
{
    Devices = new List<ESIMDeviceList>
    {
        new ESIMDeviceList
        {
            DeviceIds = new List<DeviceId2>
            {
                new DeviceId2
                {
                    Id = "15-digit IMEI",
                    Kind = "imei",
                },
                new DeviceId2
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
            },
        },
    },
    AccountName = "0000123456-00001",
    ServicePlan = "the service plan name",
    MdnZipCode = "five digit zip code",
};

try
{
    ApiResponse<ESIMRequestResponse> result = await sIMActionsController.NewactivatecodeAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setactivate Using POST

Uses the profile to activate the SIM.

```csharp
SetactivateUsingPOSTAsync(
    Models.ESIMProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ESIMProfileRequest`](../../doc/models/esim-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.ESIMRequestResponse>>`](../../doc/models/esim-request-response.md)

## Example Usage

```csharp
ESIMProfileRequest body = new ESIMProfileRequest
{
    Devices = new List<ESIMDeviceList>
    {
        new ESIMDeviceList
        {
            DeviceIds = new List<DeviceId2>
            {
                new DeviceId2
                {
                    Id = "32-digit EID",
                    Kind = "eid",
                },
                new DeviceId2
                {
                    Id = "15-digit IMEI",
                    Kind = "imei",
                },
                new DeviceId2
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid (ICCID is only used for reactivation)",
                },
            },
        },
    },
    CarrierName = "Verizon Wireless",
    AccountName = "0000123456-00001",
    ServicePlan = "the service plan name",
    MdnZipCode = "five digit zip code",
};

try
{
    ApiResponse<ESIMRequestResponse> result = await sIMActionsController.SetactivateUsingPOSTAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setdeactivate Using POST

Uses the profile to deactivate the SIM.

```csharp
SetdeactivateUsingPOSTAsync(
    Models.ProfileRequest2 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest2`](../../doc/models/profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.ESIMRequestResponse>>`](../../doc/models/esim-request-response.md)

## Example Usage

```csharp
ProfileRequest2 body = new ProfileRequest2
{
    AccountName = "0000123456-00001",
    CarrierName = "Verizon Wireless",
    ReasonCode = "FF",
    EtfWaiver = true,
    CheckFallbackProfile = false,
};

try
{
    ApiResponse<ESIMRequestResponse> result = await sIMActionsController.SetdeactivateUsingPOSTAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |

