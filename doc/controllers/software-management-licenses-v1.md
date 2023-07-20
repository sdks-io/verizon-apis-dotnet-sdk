# Software Management Licenses V1

```csharp
SoftwareManagementLicensesV1Controller softwareManagementLicensesV1Controller = client.SoftwareManagementLicensesV1Controller;
```

## Class Name

`SoftwareManagementLicensesV1Controller`

## Methods

* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v1.md#remove-licenses-from-devices)
* [Delete List of Licenses to Remove](../../doc/controllers/software-management-licenses-v1.md#delete-list-of-licenses-to-remove)
* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v1.md#assign-licenses-to-devices)
* [Create List of Licenses to Remove](../../doc/controllers/software-management-licenses-v1.md#create-list-of-licenses-to-remove)
* [List Licenses to Remove](../../doc/controllers/software-management-licenses-v1.md#list-licenses-to-remove)


# Remove Licenses From Devices

**This endpoint is deprecated.**

Remove unused licenses from device.

```csharp
RemoveLicensesFromDevicesAsync(
    string account,
    Models.V1LicensesAssignedRemovedRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`Models.V1LicensesAssignedRemovedRequest`](../../doc/models/v1-licenses-assigned-removed-request.md) | Body, Required | IMEIs of the devices to remove licenses from. |

## Response Type

[`Task<ApiResponse<Models.V1LicensesAssignedRemovedResult>>`](../../doc/models/v1-licenses-assigned-removed-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
V1LicensesAssignedRemovedRequest body = new V1LicensesAssignedRemovedRequest
{
    DeviceList = new List<string>
    {
        "900000000000001",
        "900000000000998",
        "900000000000999",
    },
};

try
{
    ApiResponse<V1LicensesAssignedRemovedResult> result = await softwareManagementLicensesV1Controller.RemoveLicensesFromDevicesAsync(account, body);
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
  "accountName": "0242078689-00001",
  "licCount": 9000,
  "licUsedCount": 998,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "status": "LicenseRemoveSuccess",
      "Reason": "Success"
    },
    {
      "deviceId": "900000000000998",
      "status": "LicenseRemoveSuccess",
      "Reason": "Success"
    },
    {
      "deviceId": "900000000000999",
      "status": "LicenseRemoveFailed",
      "Reason": "No license attached to device"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Delete List of Licenses to Remove

**This endpoint is deprecated.**

Deletes the entire list of cancellation candidate devices.

```csharp
DeleteListOfLicensesToRemoveAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |

## Response Type

[`Task<ApiResponse<Models.FotaV1SuccessResult>>`](../../doc/models/fota-v1-success-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
try
{
    ApiResponse<FotaV1SuccessResult> result = await softwareManagementLicensesV1Controller.DeleteListOfLicensesToRemoveAsync(account);
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
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Assign Licenses to Devices

**This endpoint is deprecated.**

Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.

```csharp
AssignLicensesToDevicesAsync(
    string account,
    Models.V1LicensesAssignedRemovedRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`Models.V1LicensesAssignedRemovedRequest`](../../doc/models/v1-licenses-assigned-removed-request.md) | Body, Required | IMEIs of the devices to assign licenses to. |

## Response Type

[`Task<ApiResponse<Models.V1LicensesAssignedRemovedResult>>`](../../doc/models/v1-licenses-assigned-removed-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
V1LicensesAssignedRemovedRequest body = new V1LicensesAssignedRemovedRequest
{
    DeviceList = new List<string>
    {
        "990003425730535",
        "990000473475989",
    },
};

try
{
    ApiResponse<V1LicensesAssignedRemovedResult> result = await softwareManagementLicensesV1Controller.AssignLicensesToDevicesAsync(account, body);
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
  "accountName": "0242078689-00001",
  "licCount": 9000,
  "licUsedCount": 1000,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "status": "LicenseAssignSuccess",
      "Reason": "Success"
    },
    {
      "deviceId": "900000000000999",
      "status": "LicenseAssignSuccess",
      "Reason": "Success"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Create List of Licenses to Remove

**This endpoint is deprecated.**

Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

```csharp
CreateListOfLicensesToRemoveAsync(
    string account,
    Models.V1ListOfLicensesToRemoveRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`Models.V1ListOfLicensesToRemoveRequest`](../../doc/models/v1-list-of-licenses-to-remove-request.md) | Body, Required | Cancellation candidate device list. |

## Response Type

[`Task<ApiResponse<Models.V1ListOfLicensesToRemoveResult>>`](../../doc/models/v1-list-of-licenses-to-remove-result.md)

## Example Usage

```csharp
string account = "0242078689-00001";
V1ListOfLicensesToRemoveRequest body = new V1ListOfLicensesToRemoveRequest
{
    DeviceList = new List<string>
    {
        "990003425730535",
        "990000473475989",
    },
    Type = "append",
};

try
{
    ApiResponse<V1ListOfLicensesToRemoveResult> result = await softwareManagementLicensesV1Controller.CreateListOfLicensesToRemoveAsync(account, body);
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
  "count": 2,
  "deviceList": [
    "900000000000001",
    "900000000000999"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# List Licenses to Remove

**This endpoint is deprecated.**

Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

```csharp
ListLicensesToRemoveAsync(
    string account,
    string startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `string` | Template, Required | The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc. |

## Response Type

[`Task<ApiResponse<Models.V1ListOfLicensesToRemove>>`](../../doc/models/v1-list-of-licenses-to-remove.md)

## Example Usage

```csharp
string account = "0242078689-00001";
string startIndex = "startIndex4";
try
{
    ApiResponse<V1ListOfLicensesToRemove> result = await softwareManagementLicensesV1Controller.ListLicensesToRemoveAsync(account, startIndex);
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
  "count": 6,
  "hasMoreData": false,
  "updateTime": "2018-03-22T12:06:06.000Z",
  "deviceList": [
    "990003425730535",
    "990000473475989",
    "990005733420535",
    "990000347475989",
    "990007303425535",
    "990007590473489"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |

