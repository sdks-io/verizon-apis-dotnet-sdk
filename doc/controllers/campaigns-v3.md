# Campaigns V3

```csharp
CampaignsV3Controller campaignsV3Controller = client.CampaignsV3Controller;
```

## Class Name

`CampaignsV3Controller`

## Methods

* [Schedule Campaign Firmware Upgrade](../../doc/controllers/campaigns-v3.md#schedule-campaign-firmware-upgrade)
* [Update Campaign Firmware Devices](../../doc/controllers/campaigns-v3.md#update-campaign-firmware-devices)
* [Update Campaign Dates](../../doc/controllers/campaigns-v3.md#update-campaign-dates)
* [Get Campaign Information](../../doc/controllers/campaigns-v3.md#get-campaign-information)
* [Cancel Campaign](../../doc/controllers/campaigns-v3.md#cancel-campaign)


# Schedule Campaign Firmware Upgrade

This endpoint allows a user to schedule a firmware upgrade for a list of devices.

```csharp
ScheduleCampaignFirmwareUpgradeAsync(
    string acc,
    Models.CampaignFirmwareUpgrade body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`CampaignFirmwareUpgrade`](../../doc/models/campaign-firmware-upgrade.md) | Body, Required | Firmware upgrade information. |

## Response Type

[`Task<ApiResponse<Models.FirmwareCampaign>>`](../../doc/models/firmware-campaign.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
CampaignFirmwareUpgrade body = new CampaignFirmwareUpgrade
{
    FirmwareName = "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
    FirmwareFrom = "SR1.2.0.0-10512",
    FirmwareTo = "SR1.2.0.0-10657",
    Protocol = "LWM2M",
    StartDate = DateTime.Parse("2021-09-29"),
    EndDate = DateTime.Parse("2021-10-01"),
    DeviceList = new List<string>
    {
        "15-digit IMEI",
    },
    CampaignName = "Smart FOTA - test 4",
    CampaignTimeWindowList = new List<Models.V3TimeWindow>
    {
        new V3TimeWindow
        {
            StartTime = 18,
            EndTime = 22,
        },
    },
};

try
{
    ApiResponse<FirmwareCampaign> result = await campaignsV3Controller.ScheduleCampaignFirmwareUpgradeAsync(
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
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0000123456-00001",
  "campaignName": "Smart FOTA - test 4",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "protocol": "LWM2M",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignRequestPending",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "campaignTimeWindowList": [
    {
      "startTime": 18,
      "endTime": 22
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Update Campaign Firmware Devices

This endpoint allows user to Add or Remove devices to an existing campaign.

```csharp
UpdateCampaignFirmwareDevicesAsync(
    string acc,
    string campaignId,
    Models.V3AddOrRemoveDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Unique identifier of a campaign. |
| `body` | [`V3AddOrRemoveDeviceRequest`](../../doc/models/v3-add-or-remove-device-request.md) | Body, Required | Add or remove device to existing upgrade information. |

## Response Type

[`Task<ApiResponse<Models.V3AddOrRemoveDeviceResult>>`](../../doc/models/v3-add-or-remove-device-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
string campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";
V3AddOrRemoveDeviceRequest body = new V3AddOrRemoveDeviceRequest
{
    Type = "remove",
    DeviceList = new List<string>
    {
        "15-digit IMEI",
    },
};

try
{
    ApiResponse<V3AddOrRemoveDeviceResult> result = await campaignsV3Controller.UpdateCampaignFirmwareDevicesAsync(
        acc,
        campaignId,
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
  "campaignId": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "AddDeviceSucceed",
      "Reason": "Device added Successfully"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Update Campaign Dates

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

```csharp
UpdateCampaignDatesAsync(
    string acc,
    string campaignId,
    Models.V3ChangeCampaignDatesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Firmware upgrade information. |
| `body` | [`V3ChangeCampaignDatesRequest`](../../doc/models/v3-change-campaign-dates-request.md) | Body, Required | New dates and time windows. |

## Response Type

[`Task<ApiResponse<Models.FirmwareCampaign>>`](../../doc/models/firmware-campaign.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
string campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";
V3ChangeCampaignDatesRequest body = new V3ChangeCampaignDatesRequest
{
    StartDate = DateTime.Parse("2022-02-23"),
    EndDate = DateTime.Parse("2022-02-24"),
    CampaignTimeWindowList = new List<Models.V3TimeWindow>
    {
        new V3TimeWindow
        {
            StartTime = 14,
            EndTime = 18,
        },
    },
};

try
{
    ApiResponse<FirmwareCampaign> result = await campaignsV3Controller.UpdateCampaignDatesAsync(
        acc,
        campaignId,
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
  "id": "4e03b882-936a-11ec-931f-76f56843c393",
  "accountName": "0000123456-00001",
  "campaignName": "modify-campaign-test-1",
  "firmwareName": "NordicSemiconductorASA_nRF9160_ee58ac77-f1fd-4960-8dc4-4d32e118a6d4_4325d595-7b69-4474-ba39-9c177930aac3",
  "protocol": "LWM2M",
  "firmwareFrom": "ee58ac77-f1fd-4960-8dc4-4d32e118a6d4",
  "firmwareTo": "4325d595-7b69-4474-ba39-9c177930aac3",
  "make": "Nordic Semiconductor ASA",
  "model": "nRF9160",
  "status": "CampaignRequestQueued",
  "startDate": "2022-02-23",
  "endDate": "2022-02-24",
  "campaignTimeWindowList": [
    {
      "startTime": 14,
      "endTime": 18
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Get Campaign Information

This endpoint allows the user to retrieve campaign level information for a specified campaign.

```csharp
GetCampaignInformationAsync(
    string acc,
    string campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Firmware upgrade identifier. |

## Response Type

[`Task<ApiResponse<Models.Campaign>>`](../../doc/models/campaign.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
string campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";
try
{
    ApiResponse<Campaign> result = await campaignsV3Controller.GetCampaignInformationAsync(
        acc,
        campaignId
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
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0642233522-00001",
  "campaignName": "Smart FOTA - test 4",
  "protocol": "LWM2M",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignPreScheduled",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "campaignTimeWindowList": [
    {
      "startTime": 18,
      "endTime": 22
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Cancel Campaign

This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.

```csharp
CancelCampaignAsync(
    string acc,
    string campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Firmware upgrade information. |

## Response Type

[`Task<ApiResponse<Models.FotaV3SuccessResult>>`](../../doc/models/fota-v3-success-result.md)

## Example Usage

```csharp
string acc = "0000123456-00001";
string campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";
try
{
    ApiResponse<FotaV3SuccessResult> result = await campaignsV3Controller.CancelCampaignAsync(
        acc,
        campaignId
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

