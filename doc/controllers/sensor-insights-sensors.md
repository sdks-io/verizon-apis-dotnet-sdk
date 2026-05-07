# Sensor Insights Sensors

```csharp
SensorInsightsSensorsController sensorInsightsSensorsController = client.SensorInsightsSensorsController;
```

## Class Name

`SensorInsightsSensorsController`

## Methods

* [Sensor Insights List Sensor Devices Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-list-sensor-devices-request)
* [Sensor Insights on Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-on-board-sensor-request)
* [Sensor Insights Sensor on Board Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-on-board-status-request)
* [Sensor Insights Off Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-off-board-sensor-request)
* [Sensor Insights Sensor Off Boarding Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-off-boarding-status-request)


# Sensor Insights List Sensor Devices Request

```csharp
SensorInsightsListSensorDevicesRequestAsync(
    Models.DtoListSensorDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSensorDevicesRequest`](../../doc/models/dto-list-sensor-devices-request.md) | Body, Required | List details of the sensors |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.ResourceDevice>](../../doc/models/resource-device.md).

## Example Usage

```csharp
DtoListSensorDevicesRequest body = new DtoListSensorDevicesRequest
{
    Accountname = "0000123456-00001",
    Filter = new DtoFilter
    {
        Expand = "device detail(s)",
        Limitnumber = 100,
        Nopagination = true,
        Page = "The number of pages",
        Pagenumber = 1,
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
    ApiResponse<List<ResourceDevice>> result = await sensorInsightsSensorsController.SensorInsightsListSensorDevicesRequestAsync(body);
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


# Sensor Insights on Board Sensor Request

```csharp
SensorInsightsOnBoardSensorRequestAsync(
    Models.DtoOnBoardSensorRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOnBoardSensorRequest`](../../doc/models/dto-on-board-sensor-request.md) | Body, Required | Onboarding a sensor |

## Response Type

`Task`

## Example Usage

```csharp
DtoOnBoardSensorRequest body = new DtoOnBoardSensorRequest
{
    Accountname = "0000123456-00001",
    Payload = new Payload
    {
        Addsensor = new ResourceOnBoardSensor
        {
            Deveui = "The unique EUI64 address of the device",
            Appeui = "global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame",
            Appkey = "Encryption key used for messages during every over the air activation",
            MClass = "A",
            Kind = "ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US",
            Description = "used to identify water leaks",
            Name = "Water Leak sensor",
            Customdata = new Dictionary<string, object>
            {
                ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
    },
};

try
{
    await sensorInsightsSensorsController.SensorInsightsOnBoardSensorRequestAsync(body);
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Sensor on Board Status Request

```csharp
SensorInsightsSensorOnBoardStatusRequestAsync(
    Models.DtoSensorOnBoardStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOnBoardStatusRequest`](../../doc/models/dto-sensor-on-board-status-request.md) | Body, Required | Get the sensor's onboarding status |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoSensorOnBoardingStatusResponse](../../doc/models/dto-sensor-on-boarding-status-response.md).

## Example Usage

```csharp
DtoSensorOnBoardStatusRequest body = new DtoSensorOnBoardStatusRequest
{
    Accountname = "0000123456-00001",
    Gatewayidentifier = new Gatewayidentifier
    {
        Deviceid = "00000000-0000-0000-0000-000000000255",
    },
    Onboarding = new Onboarding
    {
    },
};

try
{
    ApiResponse<DtoSensorOnBoardingStatusResponse> result = await sensorInsightsSensorsController.SensorInsightsSensorOnBoardStatusRequestAsync(body);
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


# Sensor Insights Off Board Sensor Request

```csharp
SensorInsightsOffBoardSensorRequestAsync(
    Models.DtoOffBoardSensorRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOffBoardSensorRequest`](../../doc/models/dto-off-board-sensor-request.md) | Body, Required | Offboard a sensor |

## Response Type

`Task`

## Example Usage

```csharp
DtoOffBoardSensorRequest body = new DtoOffBoardSensorRequest
{
    Accountname = "0000123456-00001",
    Configuration = new Sensorinsightsconfig
    {
        Removesensor = new DtoOffBoardSensor
        {
            Deveui = "The unique EUI64 address of the device",
        },
    },
};

try
{
    await sensorInsightsSensorsController.SensorInsightsOffBoardSensorRequestAsync(body);
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
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |


# Sensor Insights Sensor Off Boarding Status Request

```csharp
SensorInsightsSensorOffBoardingStatusRequestAsync(
    Models.DtoSensorOffBoardStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOffBoardStatusRequest`](../../doc/models/dto-sensor-off-board-status-request.md) | Body, Required | Get a sensor's offboarding status |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoSensorOffBoardingStatusResponse](../../doc/models/dto-sensor-off-boarding-status-response.md).

## Example Usage

```csharp
DtoSensorOffBoardStatusRequest body = new DtoSensorOffBoardStatusRequest
{
    Accountname = "0000123456-00001",
    Gatewayidentifier = new Gatewayidentifier
    {
        Deviceid = "UUID of the Gateway device",
    },
    Offboarding = new Offboarding
    {
    },
};

try
{
    ApiResponse<DtoSensorOffBoardingStatusResponse> result = await sensorInsightsSensorsController.SensorInsightsSensorOffBoardingStatusRequestAsync(body);
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

