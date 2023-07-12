# Diagnostics Observations

```csharp
DiagnosticsObservationsController diagnosticsObservationsController = client.DiagnosticsObservationsController;
```

## Class Name

`DiagnosticsObservationsController`

## Methods

* [Start Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#start-diagnostics-observation)
* [Stop Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#stop-diagnostics-observation)


# Start Diagnostics Observation

This endpoint allows the user to start or change observe diagnostics.

```csharp
StartDiagnosticsObservationAsync(
    Models.ObservationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ObservationRequest`](../../doc/models/observation-request.md) | Body, Required | Request for device observation information. |

## Response Type

[`Task<ApiResponse<Models.DiagnosticsObservationResult>>`](../../doc/models/diagnostics-observation-result.md)

## Example Usage

```csharp
ObservationRequest body = new ObservationRequest
{
    AccountName = "TestQAAccount",
    Devices = new List<Models.Device>
    {
        new Device
        {
            Id = "864508030026238",
            Kind = "IMEI",
        },
    },
    Attributes = new List<Models.ObservationRequestAttribute>
    {
        new ObservationRequestAttribute
        {
            Name = AttributeIdentifierEnum.RADIOSIGNALSTRENGTH,
        },
        new ObservationRequestAttribute
        {
            Name = AttributeIdentifierEnum.LINKQUALITY,
        },
        new ObservationRequestAttribute
        {
            Name = AttributeIdentifierEnum.NETWORKBEARER,
        },
        new ObservationRequestAttribute
        {
            Name = AttributeIdentifierEnum.CELLID,
        },
    },
    Frequency = new NumericalData
    {
        MValue = 15,
        Unit = NumericalDataUnitEnum.SECOND,
    },
    Duration = new NumericalData
    {
        MValue = 15,
        Unit = NumericalDataUnitEnum.SECOND,
    },
};

try
{
    ApiResponse<DiagnosticsObservationResult> result = await diagnosticsObservationsController.StartDiagnosticsObservationAsync(body);
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
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |


# Stop Diagnostics Observation

This endpoint allows the user to stop or reset observe diagnostics.

```csharp
StopDiagnosticsObservationAsync(
    string transactionId,
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionId` | `string` | Query, Required | The ID value associated with the transaction. |
| `accountName` | `string` | Query, Required | The numeric account name. |

## Response Type

[`Task<ApiResponse<Models.DiagnosticsObservationResult>>`](../../doc/models/diagnostics-observation-result.md)

## Example Usage

```csharp
string transactionId = "5f4bd2ff-5d7f-444d-af17-3f6a80bb2a94";
string accountName = "0000123456-00001";
try
{
    ApiResponse<DiagnosticsObservationResult> result = await diagnosticsObservationsController.StopDiagnosticsObservationAsync(transactionId, accountName);
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
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

