# Diagnostics History

```csharp
DiagnosticsHistoryController diagnosticsHistoryController = client.DiagnosticsHistoryController;
```

## Class Name

`DiagnosticsHistoryController`


# Get Diagnostics History

This endpoint allows the user to get the history data.

```csharp
GetDiagnosticsHistoryAsync(
    Models.HistorySearchRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.HistorySearchRequest`](../../doc/models/history-search-request.md) | Body, Required | History data information. |

## Response Type

[`Task<ApiResponse<List<Models.History>>>`](../../doc/models/history.md)

## Example Usage

```csharp
HistorySearchRequest body = new HistorySearchRequest
{
    Filter = new HistorySearchFilter
    {
        AccountName = "0000123456-00001",
        Device = new Device
        {
            Id = "15-digit IMEI",
            Kind = "IMEI",
        },
        Attributes = new HistorySearchFilterAttributes
        {
            Name = AttributeIdentifierEnum.LINKQUALITY,
        },
    },
};

try
{
    ApiResponse<List<History>> result = await diagnosticsHistoryController.GetDiagnosticsHistoryAsync(body);
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
    "accountName": "0000123456-00001",
    "attributes": {
      "createdOn": "2022-02-10T16:02:21.406Z",
      "name": "LINK_QUALITY",
      "value": "47"
    },
    "device": {
      "id": "15-digit IMEI",
      "kind": "IMEI"
    }
  },
  {
    "accountName": "0000123456-00001",
    "attributes": {
      "createdOn": "2022-02-10T16:02:05.316Z",
      "name": "LINK_QUALITY",
      "value": "47"
    },
    "device": {
      "id": "15-digit IMEI",
      "kind": "IMEI"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

