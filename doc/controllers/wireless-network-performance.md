# Wireless Network Performance

```csharp
WirelessNetworkPerformanceController wirelessNetworkPerformanceController = client.WirelessNetworkPerformanceController;
```

## Class Name

`WirelessNetworkPerformanceController`

## Methods

* [Near Real Time Network Conditions](../../doc/controllers/wireless-network-performance.md#near-real-time-network-conditions)
* [Domestic 4 G and 5G Nationwide Network Coverage](../../doc/controllers/wireless-network-performance.md#domestic-4-g-and-5g-nationwide-network-coverage)
* [Site Proximity](../../doc/controllers/wireless-network-performance.md#site-proximity)
* [Device Experience 30 Days History](../../doc/controllers/wireless-network-performance.md#device-experience-30-days-history)
* [Device Experience Bulk Latest](../../doc/controllers/wireless-network-performance.md#device-experience-bulk-latest)


# Near Real Time Network Conditions

WNP Query for current network condition.

```csharp
NearRealTimeNetworkConditionsAsync(
    Models.GetNetworkConditionsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for current network health. |

## Response Type

[`Task<ApiResponse<Models.WNPRequestResponse>>`](../../doc/models/wnp-request-response.md)

## Example Usage

```csharp
GetNetworkConditionsRequest body = new GetNetworkConditionsRequest
{
    AccountName = "0000123456-00001",
    LocationType = "LONGLAT",
    Coordinates = new Coordinates
    {
        Latitude = "-33.84819",
        Longitude = "151.22049",
    },
};

try
{
    ApiResponse<WNPRequestResponse> result = await wirelessNetworkPerformanceController.NearRealTimeNetworkConditionsAsync(body);
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
| Default | Error response | [`WNPRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Domestic 4 G and 5G Nationwide Network Coverage

Run a report to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS and 5GNW.

```csharp
Domestic4GAnd5gNationwideNetworkCoverageAsync(
    Models.GetWirelessCoverageRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetWirelessCoverageRequest`](../../doc/models/get-wireless-coverage-request.md) | Body, Required | Request for network coverage details. |

## Response Type

[`Task<ApiResponse<Models.WNPRequestResponse>>`](../../doc/models/wnp-request-response.md)

## Example Usage

```csharp
GetWirelessCoverageRequest body = new GetWirelessCoverageRequest
{
    AccountName = "0000123456-00001",
    RequestType = "NW",
    LocationType = "LONGLAT",
    Locations = new Locationscoord
    {
        CoordinatesList = new List<Models.Coordinates>
        {
            new Coordinates
            {
                Latitude = "-33.84819",
                Longitude = "151.22049",
            },
        },
    },
    NetworkTypesList = new List<Models.NetworkType>
    {
        new NetworkType
        {
            NetworkTypeProp = "LTE",
        },
    },
};

try
{
    ApiResponse<WNPRequestResponse> result = await wirelessNetworkPerformanceController.Domestic4GAnd5gNationwideNetworkCoverageAsync(body);
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
| Default | Error response | [`WNPRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Site Proximity

Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.

```csharp
SiteProximityAsync(
    Models.GetNetworkConditionsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for cell site proximity. |

## Response Type

[`Task<ApiResponse<Models.WNPRequestResponse>>`](../../doc/models/wnp-request-response.md)

## Example Usage

```csharp
GetNetworkConditionsRequest body = new GetNetworkConditionsRequest
{
    AccountName = "0000123456-00001",
    LocationType = "LONGLAT",
    Coordinates = new Coordinates
    {
        Latitude = "-33.84819",
        Longitude = "151.22049",
    },
};

try
{
    ApiResponse<WNPRequestResponse> result = await wirelessNetworkPerformanceController.SiteProximityAsync(body);
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
| Default | Error response | [`WNPRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience 30 Days History

A report of a specific device's service scores over a 30 day period.

```csharp
DeviceExperience30daysHistoryAsync(
    Models.GetDeviceExperienceScoreHistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreHistoryRequest`](../../doc/models/get-device-experience-score-history-request.md) | Body, Required | Request for a device's 30 day experience. |

## Response Type

[`Task<ApiResponse<Models.WNPRequestResponse>>`](../../doc/models/wnp-request-response.md)

## Example Usage

```csharp
GetDeviceExperienceScoreHistoryRequest body = new GetDeviceExperienceScoreHistoryRequest
{
    AccountName = "0000123456-00001",
    DeviceId = new DeviceIdentifier
    {
        Kind = "iccid",
        Id = "01234567899876543210",
        Mdn = "0123456789",
    },
};

try
{
    ApiResponse<WNPRequestResponse> result = await wirelessNetworkPerformanceController.DeviceExperience30daysHistoryAsync(body);
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
| Default | Error response | [`WNPRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience Bulk Latest

Run a report to view the latest device experience score for specific devices.

```csharp
DeviceExperienceBulkLatestAsync(
    Models.GetDeviceExperienceScoreBulkRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreBulkRequest`](../../doc/models/get-device-experience-score-bulk-request.md) | Body, Required | Request for bulk latest history details. |

## Response Type

[`Task<ApiResponse<Models.WNPRequestResponse>>`](../../doc/models/wnp-request-response.md)

## Example Usage

```csharp
GetDeviceExperienceScoreBulkRequest body = new GetDeviceExperienceScoreBulkRequest
{
    AccountName = "0000123456-00001",
    DeviceList = new List<Models.DeviceIdentifier>
    {
        new DeviceIdentifier
        {
            Kind = "iccid",
            Id = "01234567899876543210",
            Mdn = "0123456789",
        },
    },
};

try
{
    ApiResponse<WNPRequestResponse> result = await wirelessNetworkPerformanceController.DeviceExperienceBulkLatestAsync(body);
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
| Default | Error response | [`WNPRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |

