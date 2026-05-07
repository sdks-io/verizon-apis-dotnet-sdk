# Sensor Insights Gateways

```csharp
SensorInsightsGatewaysController sensorInsightsGatewaysController = client.SensorInsightsGatewaysController;
```

## Class Name

`SensorInsightsGatewaysController`


# Sensor Insights List Gateway Devices Request

```csharp
SensorInsightsListGatewayDevicesRequestAsync(
    Models.DtoListDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | Get gateway information |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.ResourceDevice>](../../doc/models/resource-device.md).

## Example Usage

```csharp
DtoListDevicesRequest body = new DtoListDevicesRequest
{
    Accountname = "0000123456-00001",
    Filter = new DtoFilter
    {
        Expand = "device detail(s)",
        Limitnumber = 100,
        Nopagination = true,
        Page = "The number of pages",
        Pagenumber = 100,
        Projection = new List<string>
        {
            "specific device fields requested",
        },
        Selection = new Dictionary<string, object>
        {
            ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Resourceidentifier = new DtoDeviceResourceIdentifier
    {
        Deveui = "The unique EUI64 address of the device",
        Deviceid = "The UUID of the device",
        Esn = 223372036854775800,
        Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
        Imei = 223372036854775,
        Imsi = 223372036854775800,
        Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
        Manufacturer = "REOLINK",
        Meid = "The 56-bit Mobile Equipment ID",
        Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
        NodeUuid = "The UUID of the node the device is associated with",
        Qrcode = "The Quick Response (QR) code",
        Serial = "The device's serial number",
    },
};

try
{
    ApiResponse<List<ResourceDevice>> result = await sensorInsightsGatewaysController.SensorInsightsListGatewayDevicesRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
    if (e is M500ManagementErrorException)
    {
       // TODO: Handle M500ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

