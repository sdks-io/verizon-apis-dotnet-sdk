# HPL Device Management

```csharp
HPLDeviceManagementController hPLDeviceManagementController = client.HPLDeviceManagementController;
```

## Class Name

`HPLDeviceManagementController`


# Add Devices Hyper Precise

Use this API if you want to manage some device settings before you are ready to activate service for the devices.

```csharp
AddDevicesHyperPreciseAsync(
    Models.HplAddDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`HplAddDevicesRequest`](../../doc/models/hpl-add-devices-request.md) | Body, Required | Devices to add to the account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.HplAddDevicesRequest>](../../doc/models/hpl-add-devices-request.md).

## Example Usage

```csharp
HplAddDevicesRequest body = new HplAddDevicesRequest
{
    State = "preactive",
    DevicesToAdd = new List<HplAccountDeviceList>
    {
        new HplAccountDeviceList
        {
            DeviceIds = new List<HplDeviceId>
            {
                new HplDeviceId
                {
                    Kind = "imei",
                    Id = "15-digit IMEI",
                },
                new HplDeviceId
                {
                    Kind = "iccid",
                    Id = "20-digit ICCID",
                },
            },
        },
        new HplAccountDeviceList
        {
            DeviceIds = new List<HplDeviceId>
            {
                new HplDeviceId
                {
                    Kind = "imei",
                    Id = "15-digit IMEI",
                },
                new HplDeviceId
                {
                    Kind = "iccid",
                    Id = "20-digit ICCID",
                },
            },
        },
    },
    AccountName = "0000123456-00001",
    CustomFields = new List<HplCustomFields>
    {
        new HplCustomFields
        {
            Key = "CustomField2",
            MValue = "SuperVend",
        },
    },
    GroupName = "West Region",
};

try
{
    ApiResponse<List<HplAddDevicesRequest>> result = await hPLDeviceManagementController.AddDevicesHyperPreciseAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is HyperPreciseLocationResultException)
    {
       // TODO: Handle HyperPreciseLocationResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
[
  {
    "deviceIds": [
      {
        "id": "20-digit ICCID",
        "kind": "iccid"
      }
    ],
    "response": "Success"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Not Found / Does not exist | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 405 | Method Not Allowed | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 406 | Format / Request Unacceptable | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 429 | Too many requests | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| Default | Error response | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |

