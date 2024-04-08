# Devices Locations

```csharp
DevicesLocationsController devicesLocationsController = client.DevicesLocationsController;
```

## Class Name

`DevicesLocationsController`

## Methods

* [List Devices Locations Synchronous](../../doc/controllers/devices-locations.md#list-devices-locations-synchronous)
* [List Devices Locations Asynchronous](../../doc/controllers/devices-locations.md#list-devices-locations-asynchronous)
* [Cancel Device Location Request](../../doc/controllers/devices-locations.md#cancel-device-location-request)
* [Create Location Report](../../doc/controllers/devices-locations.md#create-location-report)
* [Retrieve Location Report](../../doc/controllers/devices-locations.md#retrieve-location-report)
* [Get Location Report Status](../../doc/controllers/devices-locations.md#get-location-report-status)
* [Cancel Queued Location Report Generation](../../doc/controllers/devices-locations.md#cancel-queued-location-report-generation)


# List Devices Locations Synchronous

This locations endpoint retrieves the locations for a list of devices.

```csharp
ListDevicesLocationsSynchronousAsync(
    Models.LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request to obtain location of devices. |

## Response Type

[`Task<ApiResponse<List<Models.Location>>>`](../../doc/models/location.md)

## Example Usage

```csharp
LocationRequest body = new LocationRequest
{
    AccountName = "1234567890-00001",
    DeviceList = new List<Models.DeviceInfo>
    {
        new DeviceInfo
        {
            Id = "980003420535573",
            Kind = "imei",
            Mdn = "7892345678",
        },
        new DeviceInfo
        {
            Id = "375535024300089",
            Kind = "imei",
            Mdn = "7897654321",
        },
        new DeviceInfo
        {
            Id = "A100003861E585",
            Kind = "meid",
            Mdn = "7897650914",
        },
    },
    AccuracyMode = AccuracyModeEnum.Enum0,
    CacheMode = CacheModeEnum.Enum1,
};

try
{
    ApiResponse<List<Location>> result = await devicesLocationsController.ListDevicesLocationsSynchronousAsync(body);
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
    "msid": "7892345678",
    "pd": {
      "time": "20170520004421",
      "x": "33.45324",
      "y": "-84.59621",
      "radius": "5571",
      "qos": false
    },
    "error": {}
  },
  {
    "msid": "8583239709",
    "pd": {
      "time": "20170525214342",
      "x": "38.8408694",
      "y": "-105.0422583",
      "radius": "3866",
      "qos": false
    },
    "error": {}
  },
  {
    "msid": "7897654321",
    "pd": {},
    "error": {
      "time": "20170525214342",
      "type": "POSITION METHOD FAILURE",
      "info": "Exception code=ABSENT SUBSCRIBER"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Devices Locations Asynchronous

Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.

```csharp
ListDevicesLocationsAsynchronousAsync(
    Models.LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | An asynchronous request to obtain locations of devices. |

## Response Type

[`Task<ApiResponse<Models.SynchronousLocationRequestResult>>`](../../doc/models/synchronous-location-request-result.md)

## Example Usage

```csharp
LocationRequest body = new LocationRequest
{
    AccountName = "2234434445-32333",
    DeviceList = new List<Models.DeviceInfo>
    {
        new DeviceInfo
        {
            Id = "354677790348290",
            Kind = "imei",
            Mdn = "5557337468",
        },
    },
    AccuracyMode = AccuracyModeEnum.Enum0,
    CacheMode = CacheModeEnum.Enum2,
};

try
{
    ApiResponse<SynchronousLocationRequestResult> result = await devicesLocationsController.ListDevicesLocationsAsynchronousAsync(body);
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
  "txid": "4be7c858-0ef9-4b15-a0c1-95061456d835",
  "status": "QUEUED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Cancel Device Location Request

Cancel a queued or unfinished device location request.

```csharp
CancelDeviceLocationRequestAsync(
    string accountName,
    string txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | Transaction ID of the request to cancel, from the synchronous response to the original request. |

## Response Type

[`Task<ApiResponse<Models.TransactionID>>`](../../doc/models/transaction-id.md)

## Example Usage

```csharp
string accountName = "1234567890-00001";
string txid = "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33";
try
{
    ApiResponse<TransactionID> result = await devicesLocationsController.CancelDeviceLocationRequestAsync(
        accountName,
        txid
    );
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
  "txid": "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Create Location Report

Request an asynchronous device location report.

```csharp
CreateLocationReportAsync(
    Models.LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request for device location report. |

## Response Type

[`Task<ApiResponse<Models.AsynchronousLocationRequestResult>>`](../../doc/models/asynchronous-location-request-result.md)

## Example Usage

```csharp
LocationRequest body = new LocationRequest
{
    AccountName = "1234567890-00001",
    DeviceList = new List<Models.DeviceInfo>
    {
        new DeviceInfo
        {
            Id = "980003420535573",
            Kind = "imei",
            Mdn = "7892345678",
        },
        new DeviceInfo
        {
            Id = "375535024300089",
            Kind = "imei",
            Mdn = "7897654321",
        },
        new DeviceInfo
        {
            Id = "A100003861E585",
            Kind = "meid",
            Mdn = "7897650914",
        },
    },
    AccuracyMode = AccuracyModeEnum.Enum0,
    CacheMode = CacheModeEnum.Enum1,
};

try
{
    ApiResponse<AsynchronousLocationRequestResult> result = await devicesLocationsController.CreateLocationReportAsync(body);
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
  "txid": "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33",
  "status": "QUEUED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Retrieve Location Report

Download a completed asynchronous device location report.

```csharp
RetrieveLocationReportAsync(
    string account,
    string txid,
    int startindex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | Transaction ID from POST /locationreports response. |
| `startindex` | `int` | Template, Required | Zero-based number of the first record to return. |

## Response Type

[`Task<ApiResponse<Models.LocationReport>>`](../../doc/models/location-report.md)

## Example Usage

```csharp
string account = "0252012345-00001";
string txid = "2017-12-11Te8b47da2-3a45-46cf-9903-61815e1e97e9";
int startindex = 0;
try
{
    ApiResponse<LocationReport> result = await devicesLocationsController.RetrieveLocationReportAsync(
        account,
        txid,
        startindex
    );
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
  "startIndex": "0",
  "txid": "2017-12-11Te8b47da2-3a45-46cf-9903-61815e1e97e9",
  "totalCount": 3,
  "hasMoreData": false,
  "devLocationList": [
    {
      "error": {},
      "msid": "7892345678",
      "pd": {
        "qos": false,
        "radius": "5571",
        "time": "20170520004421",
        "x": "33.45324",
        "y": "-84.59621"
      }
    },
    {
      "error": {},
      "msid": "8583239709",
      "pd": {
        "qos": false,
        "radius": "3866",
        "time": "20170525214342",
        "x": "38.8408694",
        "y": "-105.0422583"
      }
    },
    {
      "error": {
        "time": "20170525214342",
        "type": "POSITION METHOD FAILURE",
        "info": "Exception code=ABSENT SUBSCRIBER"
      },
      "msid": "7897654321",
      "pd": {}
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Get Location Report Status

Returns the current status of a requested device location report.

```csharp
GetLocationReportStatusAsync(
    string account,
    string txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | Transaction ID of the report. |

## Response Type

[`Task<ApiResponse<Models.LocationReportStatus>>`](../../doc/models/location-report-status.md)

## Example Usage

```csharp
string account = "0252012345-00001";
string txid = "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33";
try
{
    ApiResponse<LocationReportStatus> result = await devicesLocationsController.GetLocationReportStatusAsync(
        account,
        txid
    );
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
  "txid": "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33",
  "status": "INPROGRESS"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Cancel Queued Location Report Generation

Cancel a queued device location report.

```csharp
CancelQueuedLocationReportGenerationAsync(
    string account,
    string txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | Transaction ID of the report to cancel. |

## Response Type

[`Task<ApiResponse<Models.TransactionID>>`](../../doc/models/transaction-id.md)

## Example Usage

```csharp
string account = "0252012345-00001";
string txid = "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33";
try
{
    ApiResponse<TransactionID> result = await devicesLocationsController.CancelQueuedLocationReportGenerationAsync(
        account,
        txid
    );
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
  "txid": "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

