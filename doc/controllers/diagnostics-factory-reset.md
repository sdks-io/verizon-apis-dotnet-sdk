# Diagnostics Factory Reset

```csharp
DiagnosticsFactoryResetController diagnosticsFactoryResetController = client.DiagnosticsFactoryResetController;
```

## Class Name

`DiagnosticsFactoryResetController`


# Decives Restart

Performs a device reboot or a factory reset on the modem portion of the device.

```csharp
DecivesRestartAsync(
    Models.DeviceResetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceResetRequest`](../../doc/models/device-reset-request.md) | Body, Required | A request to perform a device reboot. |

## Response Type

[`Task<ApiResponse<Models.DiagnosticsObservationResult>>`](../../doc/models/diagnostics-observation-result.md)

## Example Usage

```csharp
DeviceResetRequest body = new DeviceResetRequest
{
    AccountName = "0642233522-00003",
    Action = "reboot",
    Devices = new List<Device>
    {
        new Device
        {
            Id = "355154080648401",
            Kind = "IMEI",
        },
    },
};

try
{
    ApiResponse<DiagnosticsObservationResult> result = await diagnosticsFactoryResetController.DecivesRestartAsync(body);
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
  "createdOn": "2019-02-03T06:48:07",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "FACTORY_RESET_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

