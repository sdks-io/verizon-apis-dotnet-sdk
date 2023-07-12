# Client Logging

```csharp
ClientLoggingController clientLoggingController = client.ClientLoggingController;
```

## Class Name

`ClientLoggingController`

## Methods

* [List Devices With Logging Enabled](../../doc/controllers/client-logging.md#list-devices-with-logging-enabled)
* [Enable Logging for Devices](../../doc/controllers/client-logging.md#enable-logging-for-devices)
* [Disable Logging for Devices](../../doc/controllers/client-logging.md#disable-logging-for-devices)
* [Enable Device Logging](../../doc/controllers/client-logging.md#enable-device-logging)
* [Disable Device Logging](../../doc/controllers/client-logging.md#disable-device-logging)
* [List Device Logs](../../doc/controllers/client-logging.md#list-device-logs)


# List Devices With Logging Enabled

Returns an array of all devices in the specified account for which logging is enabled.

```csharp
ListDevicesWithLoggingEnabledAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

[`Task<ApiResponse<List<Models.DeviceLoggingStatus>>>`](../../doc/models/device-logging-status.md)

## Example Usage

```csharp
string account = "0000123456-00001";
try
{
    ApiResponse<List<DeviceLoggingStatus>> result = await clientLoggingController.ListDevicesWithLoggingEnabledAsync(account);
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
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "991124018926684",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "992234129057795",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "998891785613351",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-23"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Enable Logging for Devices

Each customer may have a maximum of 20 devices enabled for logging.

```csharp
EnableLoggingForDevicesAsync(
    string account,
    Models.DeviceLoggingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`Models.DeviceLoggingRequest`](../../doc/models/device-logging-request.md) | Body, Required | Device logging information. |

## Response Type

[`Task<ApiResponse<List<Models.DeviceLoggingStatus>>>`](../../doc/models/device-logging-status.md)

## Example Usage

```csharp
string account = "0000123456-00001";
DeviceLoggingRequest body = new DeviceLoggingRequest
{
    DeviceIds = new List<string>
    {
        "990013907835573",
        "991124018926684",
        "992234129057795",
        "998891785613351",
        "990013907835573",
    },
};

try
{
    ApiResponse<List<DeviceLoggingStatus>> result = await clientLoggingController.EnableLoggingForDevicesAsync(account, body);
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
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "991124018926684",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "992234129057795",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "998891785613351",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-23"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Disable Logging for Devices

Turn logging off for a list of devices.

```csharp
DisableLoggingForDevicesAsync(
    string account,
    string deviceIds)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceIds` | `string` | Query, Required | The list of device IDs. |

## Response Type

`Task`

## Example Usage

```csharp
string account = "0000123456-00001";
string deviceIds = "990013907835573";
try
{
    await clientLoggingController.DisableLoggingForDevicesAsync(account, deviceIds);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Enable Device Logging

Enables logging for a specific device.

```csharp
EnableDeviceLoggingAsync(
    string account,
    string deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

[`Task<ApiResponse<Models.DeviceLoggingStatus>>`](../../doc/models/device-logging-status.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string deviceId = "990013907835573";
try
{
    ApiResponse<DeviceLoggingStatus> result = await clientLoggingController.EnableDeviceLoggingAsync(account, deviceId);
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
  "deviceId": "990013907835573",
  "expiryDate": "2020-10-19"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Disable Device Logging

Disables logging for a specific device.

```csharp
DisableDeviceLoggingAsync(
    string account,
    string deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

`Task`

## Example Usage

```csharp
string account = "0000123456-00001";
string deviceId = "990013907835573";
try
{
    await clientLoggingController.DisableDeviceLoggingAsync(account, deviceId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# List Device Logs

Gets logs for a specific device.

```csharp
ListDeviceLogsAsync(
    string account,
    string deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

[`Task<ApiResponse<List<Models.DeviceLog>>>`](../../doc/models/device-log.md)

## Example Usage

```csharp
string account = "0000123456-00001";
string deviceId = "990013907835573";
try
{
    ApiResponse<List<DeviceLog>> result = await clientLoggingController.ListDeviceLogsAsync(account, deviceId);
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
    "deviceId": "990013907835573",
    "logTime": "2020-10-22T19:29:50.901Z",
    "logType": "string",
    "eventLog": "string",
    "binaryLogFileBase64": "string",
    "binaryLogFilename": "string"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

