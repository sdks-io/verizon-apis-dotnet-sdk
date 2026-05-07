# Sensor Insights Devices

```csharp
SensorInsightsDevicesController sensorInsightsDevicesController = client.SensorInsightsDevicesController;
```

## Class Name

`SensorInsightsDevicesController`

## Methods

* [Sensor Insights List Devices Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-devices-request)
* [Sensor Insights Patch Device Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-patch-device-request)
* [Sensor Insights Last Reported Time Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-last-reported-time-request)
* [Sensor Insights Device Action Set Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-device-action-set-request)
* [Sensor Insights List Device Experience History Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-device-experience-history-request)
* [Sensor Insights List Network Experience History Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-network-experience-history-request)


# Sensor Insights List Devices Request

```csharp
SensorInsightsListDevicesRequestAsync(
    Models.DtoListDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | List all device details on an account |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DtoExpandedDeviceResponse>](../../doc/models/dto-expanded-device-response.md).

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
    ApiResponse<List<DtoExpandedDeviceResponse>> result = await sensorInsightsDevicesController.SensorInsightsListDevicesRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 404 | Not Found | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Patch Device Request

```csharp
SensorInsightsPatchDeviceRequestAsync(
    Models.DtoPatchDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoPatchDeviceRequest`](../../doc/models/dto-patch-device-request.md) | Body, Required | Partially update a device's details |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ResourceDevice](../../doc/models/resource-device.md).

## Example Usage

```csharp
DtoPatchDeviceRequest body = new DtoPatchDeviceRequest
{
    Accountname = "0000123456-00001",
    Device = new ResourceDevice
    {
        Createdon = DateTime.ParseExact("2023-10-02T15:46:34.562Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Foreignid = "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
        Lastupdated = DateTime.ParseExact("2023-10-02T15:46:34.562Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        State = "success",
        Versionid = "337bd2e8-eeee-ffff-gggg-5207992fd395",
        Accountclientid = "null",
        Billingaccountid = "0000123456-00001",
        Chipset = "The chipset used by the device",
        Customdata = new Dictionary<string, object>
        {
            ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        Description = "The number of days to retaing the event data",
        Esn = 223372036854775800,
        Fields = new DtoFields
        {
            AdditionalProp1 = "string",
            AdditionalProp2 = "string",
            AdditionalProp3 = "string",
        },
        Hardwareversion = "1.0",
        Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
        Id = "33e21f61-a44a-44c9-b7a0-a63f5d19bd4f",
        Imei = 223372036854775,
        Imsi = 223372036854775800,
        Licenses = new List<string>
        {
            "licenses assigned to the device",
        },
        Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
        Manufacturer = "REOLINK",
        Meid = "The 56-bit Mobile Equipment ID",
        Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
        Name = "User defined name of the record",
        Parentdeviceid = "BLE device ID",
        Productmodel = "Model name of the device",
        Providerid = "Verizon Wireless",
        Qrcode = "The Quick Response (QR) code",
        Refid = "P3730-1422323050860",
        Refidtype = "The type of value represented by `refid`",
        Serial = "The device's serial number",
        Services = new List<string>
        {
            "configuration",
        },
        Sku = "The Stock Keeping Unit (SKU) number",
        Softwareversion = "the current device software version",
        Version = "1.0",
        Eventretention = 90,
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
    ApiResponse<ResourceDevice> result = await sensorInsightsDevicesController.SensorInsightsPatchDeviceRequestAsync(body);
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


# Sensor Insights Last Reported Time Request

```csharp
SensorInsightsLastReportedTimeRequestAsync(
    Models.DtoLastReportedTimeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoLastReportedTimeRequest`](../../doc/models/dto-last-reported-time-request.md) | Body, Required | Get the last reported information for a device |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoLastReportedTimeResponse](../../doc/models/dto-last-reported-time-response.md).

## Example Usage

```csharp
DtoLastReportedTimeRequest body = new DtoLastReportedTimeRequest
{
    Accountname = "0000123456-00001",
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
    ApiResponse<DtoLastReportedTimeResponse> result = await sensorInsightsDevicesController.SensorInsightsLastReportedTimeRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights Device Action Set Request

```csharp
SensorInsightsDeviceActionSetRequestAsync(
    SensorInsightsDeviceActionSetRequestBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SensorInsightsDeviceActionSetRequestBody`](../../doc/models/containers/sensor-insights-device-action-set-request-body.md) | Body, Required | This is a container for any-of cases. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoDeviceActionSetResponse](../../doc/models/dto-device-action-set-response.md).

## Example Usage

```csharp
SensorInsightsDeviceActionSetRequestBody body = SensorInsightsDeviceActionSetRequestBody.FromDtoDeviceActionSetRequest(
    new DtoDeviceActionSetRequest
    {
        Accountname = "0000123456-00001",
        Configuration = new DtoDeviceActionSetConfiguration
        {
            DeviceConfig = new DtoDeviceConfig
            {
                Ble = new SensorInsightsBLE
                {
                    DataMode = 1,
                    ManufacturerId = 13200,
                    MaxNumScan = 100,
                    MinSigStr = -115,
                    MonitorPeriod = 300,
                    MoreManufId = new List<object>
                    {
                        ApiHelper.JsonDeserialize<object>("{}"),
                    },
                    OpMode = 1,
                    ReportOffset = 0,
                    ReportPeriod = 300,
                    ReportType = 2,
                    ScanDuration = 20,
                },
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
    }
);

try
{
    ApiResponse<DtoDeviceActionSetResponse> result = await sensorInsightsDevicesController.SensorInsightsDeviceActionSetRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights List Device Experience History Request

```csharp
SensorInsightsListDeviceExperienceHistoryRequestAsync(
    Models.DtoListDeviceExperienceHistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDeviceExperienceHistoryRequest`](../../doc/models/dto-list-device-experience-history-request.md) | Body, Required | List the device experience |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.UserDeviceExperienceHistory>](../../doc/models/user-device-experience-history.md).

## Example Usage

```csharp
DtoListDeviceExperienceHistoryRequest body = new DtoListDeviceExperienceHistoryRequest
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
};

try
{
    ApiResponse<List<UserDeviceExperienceHistory>> result = await sensorInsightsDevicesController.SensorInsightsListDeviceExperienceHistoryRequestAsync(body);
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


# Sensor Insights List Network Experience History Request

```csharp
SensorInsightsListNetworkExperienceHistoryRequestAsync(
    Models.DtoListNetworkExperienceHistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListNetworkExperienceHistoryRequest`](../../doc/models/dto-list-network-experience-history-request.md) | Body, Required | List the network experience |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.UserNetworkExperienceHistory>](../../doc/models/user-network-experience-history.md).

## Example Usage

```csharp
DtoListNetworkExperienceHistoryRequest body = new DtoListNetworkExperienceHistoryRequest
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
};

try
{
    ApiResponse<List<UserNetworkExperienceHistory>> result = await sensorInsightsDevicesController.SensorInsightsListNetworkExperienceHistoryRequestAsync(body);
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

