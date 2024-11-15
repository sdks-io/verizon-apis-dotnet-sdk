# PWN

```csharp
PWNController pWNController = client.PWNController;
```

## Class Name

`PWNController`

## Methods

* [KPI List](../../doc/controllers/pwn.md#kpi-list)
* [Get Profile List](../../doc/controllers/pwn.md#get-profile-list)
* [Change PWN Device State-Activate](../../doc/controllers/pwn.md#change-pwn-device-state-activate)
* [Change PWN Device State-Deactivate](../../doc/controllers/pwn.md#change-pwn-device-state-deactivate)
* [Change PWN Device Profile](../../doc/controllers/pwn.md#change-pwn-device-profile)
* [Change PWN Device IPaddress](../../doc/controllers/pwn.md#change-pwn-device-ipaddress)
* [Get PWN Performance Consent](../../doc/controllers/pwn.md#get-pwn-performance-consent)


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
    ApiResponse<KPIInfoList> result = await pWNController.KPIListAsync(aname);
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

[`Task<ApiResponse<Models.PWNProfileList>>`](../../doc/models/pwn-profile-list.md)

## Example Usage

```csharp
string aname = "0342351414-00001";
try
{
    ApiResponse<PWNProfileList> result = await pWNController.GetProfileListAsync(aname);
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


# Change PWN Device State-Activate

```csharp
ChangePWNDeviceStateActivateAsync(
    Models.ChangePWNDeviceStateActivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePWNDeviceStateActivateRequest`](../../doc/models/change-pwn-device-state-activate-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangePWNDeviceStateResponse>>`](../../doc/models/change-pwn-device-state-response.md)

## Example Usage

```csharp
ChangePWNDeviceStateActivateRequest body = new ChangePWNDeviceStateActivateRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<PWNDeviceList>
    {
        new PWNDeviceList
        {
            DeviceIds = new List<PWNDeviceId>
            {
                new PWNDeviceId
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
    ApiResponse<ChangePWNDeviceStateResponse> result = await pWNController.ChangePWNDeviceStateActivateAsync(body);
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


# Change PWN Device State-Deactivate

```csharp
ChangePWNDeviceStateDeactivateAsync(
    Models.ChangePWNDeviceStateDeactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePWNDeviceStateDeactivateRequest`](../../doc/models/change-pwn-device-state-deactivate-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangePWNDeviceStateResponse>>`](../../doc/models/change-pwn-device-state-response.md)

## Example Usage

```csharp
ChangePWNDeviceStateDeactivateRequest body = new ChangePWNDeviceStateDeactivateRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<PWNDeviceList>
    {
        new PWNDeviceList
        {
            DeviceIds = new List<PWNDeviceId>
            {
                new PWNDeviceId
                {
                    Id = "99948099913031600000",
                    Kind = "iccid",
                },
            },
        },
        new PWNDeviceList
        {
            DeviceIds = new List<PWNDeviceId>
            {
                new PWNDeviceId
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
    ApiResponse<ChangePWNDeviceStateResponse> result = await pWNController.ChangePWNDeviceStateDeactivateAsync(body);
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


# Change PWN Device Profile

```csharp
ChangePWNDeviceProfileAsync(
    Models.ChangePWNDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePWNDeviceProfileRequest`](../../doc/models/change-pwn-device-profile-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangePWNDeviceProfileResponse>>`](../../doc/models/change-pwn-device-profile-response.md)

## Example Usage

```csharp
ChangePWNDeviceProfileRequest body = new ChangePWNDeviceProfileRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<PWNDeviceList>
    {
        new PWNDeviceList
        {
            DeviceIds = new List<PWNDeviceId>
            {
                new PWNDeviceId
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
    ApiResponse<ChangePWNDeviceProfileResponse> result = await pWNController.ChangePWNDeviceProfileAsync(body);
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


# Change PWN Device IPaddress

```csharp
ChangePWNDeviceIpaddressAsync(
    Models.ChangePWNDeviceIpaddressRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePWNDeviceIpaddressRequest`](../../doc/models/change-pwn-device-ipaddress-request.md) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.ChangePWNDeviceIpaddressResponse>>`](../../doc/models/change-pwn-device-ipaddress-response.md)

## Example Usage

```csharp
ChangePWNDeviceIpaddressRequest body = new ChangePWNDeviceIpaddressRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<DeviceListIP>
    {
        new DeviceListIP
        {
            DeviceIds = new List<PWNDeviceId>
            {
                new PWNDeviceId
                {
                    Id = "99948099913024600000",
                    Kind = "iccid",
                },
            },
            Ipaddress = "10.3.4.5",
        },
        new DeviceListIP
        {
            DeviceIds = new List<PWNDeviceId>
            {
                new PWNDeviceId
                {
                    Id = "999480500019111000001",
                    Kind = "iccid",
                },
            },
            Ipaddress = "10.4.5.7",
        },
    },
};

try
{
    ApiResponse<ChangePWNDeviceIpaddressResponse> result = await pWNController.ChangePWNDeviceIpaddressAsync(body);
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


# Get PWN Performance Consent

```csharp
GetPWNPerformanceConsentAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

[`Task<ApiResponse<Models.GetPWNPerformanceConsentResponse>>`](../../doc/models/get-pwn-performance-consent-response.md)

## Example Usage

```csharp
string aname = "1533445500-00088";
try
{
    ApiResponse<GetPWNPerformanceConsentResponse> result = await pWNController.GetPWNPerformanceConsentAsync(aname);
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

