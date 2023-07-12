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
| `devices` | `string` | Query, Required | Devices list format: [{"id":"{imei1}","kind":"imei"},{"id":"{imei2}","kind":"imei"}]. |

## Response Type

[`Task<ApiResponse<List<Models.DiagnosticObservationSetting>>>`](../../doc/models/diagnostic-observation-setting.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
string devices = "[{\"id\":\"864508030026238\",\"kind\":\"IMEI\"},{\"id\":\"864508030026238\",\"kind\":\"IMEI\"}]";
try
{
    ApiResponse<List<DiagnosticObservationSetting>> result = await diagnosticsSettingsController.ListDiagnosticsSettingsAsync(accountName, devices);
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

