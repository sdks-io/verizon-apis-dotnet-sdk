# Diagnostics Settings

```csharp
DiagnosticsSettingsController diagnosticsSettingsController = client.DiagnosticsSettingsController;
```

## Class Name

`DiagnosticsSettingsController`


# List Diagnostics Settings

This endpoint retrieves diagnostics settings synchronously.

```csharp
ListDiagnosticsSettingsAsync(
    string accountName,
    string devices)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |
| `devices` | `string` | Query, Required | Devices list formatted as "id, kind" |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DiagnosticObservationSetting>](../../doc/models/diagnostic-observation-setting.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
string devices = "864508030026238,IMEI";
try
{
    ApiResponse<List<DiagnosticObservationSetting>> result = await diagnosticsSettingsController.ListDiagnosticsSettingsAsync(
        accountName,
        devices
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is DeviceDiagnosticsResultException)
    {
       // TODO: Handle DeviceDiagnosticsResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
[
  {
    "accountName": "string",
    "device": {
      "id": "864508030026238",
      "kind": "IMEI"
    },
    "attributes": [
      {
        "name": "MANUFACTURER",
        "value": "string",
        "createdOn": "2019-09-07T23:08:03.532Z",
        "isObservable": true,
        "isObserving": true,
        "frequency": {
          "value": 5,
          "unit": "SECOND"
        }
      }
    ]
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

