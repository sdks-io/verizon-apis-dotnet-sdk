# Global Reporting

```csharp
GlobalReportingController globalReportingController = client.GlobalReportingController;
```

## Class Name

`GlobalReportingController`

## Methods

* [Deviceprovhistory Using POST](../../doc/controllers/global-reporting.md#deviceprovhistory-using-post)
* [Retrieve Global List](../../doc/controllers/global-reporting.md#retrieve-global-list)


# Deviceprovhistory Using POST

Retrieve the provisioning history of a specific device or devices.

```csharp
DeviceprovhistoryUsingPOSTAsync(
    Models.ESIMProvhistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ESIMProvhistoryRequest`](../../doc/models/esim-provhistory-request.md) | Body, Required | Device Provisioning History |

## Response Type

[`Task<ApiResponse<Models.ESIMRequestResponse>>`](../../doc/models/esim-request-response.md)

## Example Usage

```csharp
ESIMProvhistoryRequest body = new ESIMProvhistoryRequest
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
    ApiResponse<ESIMRequestResponse> result = await globalReportingController.DeviceprovhistoryUsingPOSTAsync(body);
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


# Retrieve Global List

Retrieve a list of all devices associated with an account.

```csharp
RetrieveGlobalListAsync(
    Models.ESIMGlobalDeviceList body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ESIMGlobalDeviceList`](../../doc/models/esim-global-device-list.md) | Body, Required | Device List |

## Response Type

[`Task<ApiResponse<Models.ESIMRequestResponse>>`](../../doc/models/esim-request-response.md)

## Example Usage

```csharp
ESIMGlobalDeviceList body = new ESIMGlobalDeviceList
{
    AccountName = "0000123456-00001",
    CarrierNameFilter = "VerizonWireless",
};

try
{
    ApiResponse<ESIMRequestResponse> result = await globalReportingController.RetrieveGlobalListAsync(body);
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
| 400 | Bad request | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`ESIMRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |

