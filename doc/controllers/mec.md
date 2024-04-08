# MEC

```csharp
MECController mECController = client.MECController;
```

## Class Name

`MECController`

## Methods

* [KPI List](../../doc/controllers/mec.md#kpi-list)
* [Get Profile List](../../doc/controllers/mec.md#get-profile-list)
* [Change Pmec Device State-Activate](../../doc/controllers/mec.md#change-pmec-device-state-activate)
* [Change Pmec Device State-Bulk Deactivate](../../doc/controllers/mec.md#change-pmec-device-state-bulk-deactivate)
* [Change Pmec Device Profile](../../doc/controllers/mec.md#change-pmec-device-profile)
* [Change Pmec Device I Paddress Bulk](../../doc/controllers/mec.md#change-pmec-device-i-paddress-bulk)
* [Get MEC Performance Consent](../../doc/controllers/mec.md#get-mec-performance-consent)


# KPI List

```csharp
KPIListAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

[`Task<ApiResponse<Models.KPIInfoList>>`](../../doc/models/kpi-info-list.md)

## Example Usage

```csharp
string aname = "0342351414-00001";
try
{
    ApiResponse<KPIInfoList> result = await mECController.KPIListAsync(aname);
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
  "KpiInfoList": [
    {
      "name": "DOWNLINK_THROUGHPUT",
      "value": "23.2",
      "nodeName": "132924_ENB_VZ_EULESS_OLTE_RD-01",
      "nodeType": "BASEBAND",
      "description": "Downlink throughput (4G)",
      "unit": "Mbps",
      "category": "Network Performance Radio",
      "timeOfLastUpdate": "2022-12-07T08:39:59.228Z"
    }
  ]
}
```


# Get Profile List

```csharp
GetProfileListAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

[`Task<ApiResponse<Models.MECProfileList>>`](../../doc/models/mec-profile-list.md)

## Example Usage

```csharp
string aname = "0342351414-00001";
try
{
    ApiResponse<MECProfileList> result = await mECController.GetProfileListAsync(aname);
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
  "profiles": [
    {
      "profileId": "HSS-EsmProfile_Enterprise",
      "profileName": "HSS EsmProfile Enterprise"
    }
  ]
}
```


# Change Pmec Device State-Activate

```csharp
ChangePmecDeviceStateActivateAsync(
    Models.ChangePmecDeviceStateActivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePmecDeviceStateActivateRequest`](../../doc/models/change-pmec-device-state-activate-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangeMecDeviceStateResponse>>`](../../doc/models/change-mec-device-state-response.md)

## Example Usage

```csharp
ChangePmecDeviceStateActivateRequest body = new ChangePmecDeviceStateActivateRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<Models.MECDeviceList>
    {
        new MECDeviceList
        {
            DeviceIds = new List<Models.MECDeviceId>
            {
                new MECDeviceId
                {
                    Id = "99948099913024600001",
                    Kind = "iccid",
                },
            },
        },
    },
    Activate = new Activate
    {
        Profile = "HSS EsmProfile Enterprise 5G",
    },
};

try
{
    ApiResponse<ChangeMecDeviceStateResponse> result = await mECController.ChangePmecDeviceStateActivateAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change Pmec Device State-Bulk Deactivate

```csharp
ChangePmecDeviceStateBulkDeactivateAsync(
    Models.ChangePmecDeviceStateBulkDeactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePmecDeviceStateBulkDeactivateRequest`](../../doc/models/change-pmec-device-state-bulk-deactivate-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangeMecDeviceStateResponse>>`](../../doc/models/change-mec-device-state-response.md)

## Example Usage

```csharp
ChangePmecDeviceStateBulkDeactivateRequest body = new ChangePmecDeviceStateBulkDeactivateRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<Models.MECDeviceList>
    {
        new MECDeviceList
        {
            DeviceIds = new List<Models.MECDeviceId>
            {
                new MECDeviceId
                {
                    Id = "99948099913031600000",
                    Kind = "iccid",
                },
            },
        },
        new MECDeviceList
        {
            DeviceIds = new List<Models.MECDeviceId>
            {
                new MECDeviceId
                {
                    Id = "99948099913031700000",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<ChangeMecDeviceStateResponse> result = await mECController.ChangePmecDeviceStateBulkDeactivateAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change Pmec Device Profile

```csharp
ChangePmecDeviceProfileAsync(
    Models.ChangePmecDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePmecDeviceProfileRequest`](../../doc/models/change-pmec-device-profile-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangeMecDeviceProfileResponse>>`](../../doc/models/change-mec-device-profile-response.md)

## Example Usage

```csharp
ChangePmecDeviceProfileRequest body = new ChangePmecDeviceProfileRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<Models.MECDeviceList>
    {
        new MECDeviceList
        {
            DeviceIds = new List<Models.MECDeviceId>
            {
                new MECDeviceId
                {
                    Id = "99948099913024600000",
                    Kind = "iccid",
                },
            },
        },
    },
    NewProfile = "HSS EsmProfile Enterprise 5G internet",
};

try
{
    ApiResponse<ChangeMecDeviceProfileResponse> result = await mECController.ChangePmecDeviceProfileAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change Pmec Device I Paddress Bulk

```csharp
ChangePmecDeviceIPaddressBulkAsync(
    Models.ChangePmecDeviceStateBulkDeactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePmecDeviceStateBulkDeactivateRequest`](../../doc/models/change-pmec-device-state-bulk-deactivate-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangeMecDeviceIPAddressResponse>>`](../../doc/models/change-mec-device-ip-address-response.md)

## Example Usage

```csharp
ChangePmecDeviceStateBulkDeactivateRequest body = new ChangePmecDeviceStateBulkDeactivateRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<Models.MECDeviceList>
    {
        new MECDeviceList
        {
            DeviceIds = new List<Models.MECDeviceId>
            {
                new MECDeviceId
                {
                    Id = "99948099913031600000",
                    Kind = "iccid",
                },
            },
        },
        new MECDeviceList
        {
            DeviceIds = new List<Models.MECDeviceId>
            {
                new MECDeviceId
                {
                    Id = "99948099913031700000",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<ChangeMecDeviceIPAddressResponse> result = await mECController.ChangePmecDeviceIPaddressBulkAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Get MEC Performance Consent

```csharp
GetMECPerformanceConsentAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

[`Task<ApiResponse<Models.GetMECPerformanceConsentResponse>>`](../../doc/models/get-mec-performance-consent-response.md)

## Example Usage

```csharp
string aname = "1533445500-00088";
try
{
    ApiResponse<GetMECPerformanceConsentResponse> result = await mECController.GetMECPerformanceConsentAsync(aname);
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
  "consent": "false"
}
```

