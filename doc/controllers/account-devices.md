# Account Devices

```csharp
AccountDevicesController accountDevicesController = client.AccountDevicesController;
```

## Class Name

`AccountDevicesController`

## Methods

* [Get Account Device Information](../../doc/controllers/account-devices.md#get-account-device-information)
* [List Account Devices Information](../../doc/controllers/account-devices.md#list-account-devices-information)


# Get Account Device Information

Retrieve account device information such as reported firmware on the devices.

```csharp
GetAccountDeviceInformationAsync(
    string acc,
    string lastSeenDeviceId = null,
    Models.DevicesProtocolEnum? protocol = Models.DevicesProtocolEnum.LWM2m)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `string` | Query, Optional | Last seen device identifier. |
| `protocol` | [`DevicesProtocolEnum?`](../../doc/models/devices-protocol-enum.md) | Query, Optional | Filter to retrieve a specific protocol type used.<br>**Default**: `DevicesProtocolEnum.LWM2M` |

## Response Type

[`Task<ApiResponse<Models.V3AccountDeviceList>>`](../../doc/models/v3-account-device-list.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
string lastSeenDeviceId = "0";
DevicesProtocolEnum? protocol = DevicesProtocolEnum.LWM2m;
try
{
    ApiResponse<V3AccountDeviceList> result = await accountDevicesController.GetAccountDeviceInformationAsync(
        acc,
        lastSeenDeviceId,
        protocol
    );
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# List Account Devices Information

Retrieve device information for a list of devices on an account.

```csharp
ListAccountDevicesInformationAsync(
    string acc,
    Models.DeviceIMEI body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`DeviceIMEI`](../../doc/models/device-imei.md) | Body, Required | Request device list information. |

## Response Type

[`Task<ApiResponse<Models.DeviceListResult>>`](../../doc/models/device-list-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
DeviceIMEI body = new DeviceIMEI
{
    DeviceList = new List<string>
    {
        "15-digit IMEI",
    },
};

try
{
    ApiResponse<DeviceListResult> result = await accountDevicesController.ListAccountDevicesInformationAsync(
        acc,
        body
    );
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
  "accountName": "0000123456-00001",
  "deviceCount": 1,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "GM01Q",
      "make": "SEQUANS COMMUNICATIONS",
      "firmware": "SR1.2.0.0-10657",
      "fotaEligible": true,
      "licenseAssigned": true,
      "status": "Active",
      "protocol": "LWM2M",
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "statusTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "lastConnectionTime": "2012-04-23T18:25:43.511Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

