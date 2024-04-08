# Device Groups

```csharp
DeviceGroupsController deviceGroupsController = client.DeviceGroupsController;
```

## Class Name

`DeviceGroupsController`

## Methods

* [Create Device Group](../../doc/controllers/device-groups.md#create-device-group)
* [List Device Groups](../../doc/controllers/device-groups.md#list-device-groups)
* [Get Device Group Information](../../doc/controllers/device-groups.md#get-device-group-information)
* [Update Device Group](../../doc/controllers/device-groups.md#update-device-group)
* [Delete Device Group](../../doc/controllers/device-groups.md#delete-device-group)


# Create Device Group

Create a new device group and optionally add devices to the group. Device groups can make it easier to manage similar devices and to get reports on their usage.

```csharp
CreateDeviceGroupAsync(
    Models.CreateDeviceGroupRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateDeviceGroupRequest`](../../doc/models/create-device-group-request.md) | Body, Required | A request to create a new device group. |

## Response Type

[`Task<ApiResponse<Models.ConnectivityManagementSuccessResult>>`](../../doc/models/connectivity-management-success-result.md)

## Example Usage

```csharp
CreateDeviceGroupRequest body = new CreateDeviceGroupRequest
{
    AccountName = "0000123456-00001",
    GroupDescription = "descriptive string",
    GroupName = "group name",
    DevicesToAdd = new List<Models.DeviceId>
    {
        new DeviceId
        {
            Id = "15-digit IMEI",
            Kind = "imei",
        },
    },
};

try
{
    ApiResponse<ConnectivityManagementSuccessResult> result = await deviceGroupsController.CreateDeviceGroupAsync(body);
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
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Device Groups

Returns a list of all device groups in a specified account.

```csharp
ListDeviceGroupsAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

[`Task<ApiResponse<List<Models.DeviceGroup>>>`](../../doc/models/device-group.md)

## Example Usage

```csharp
string aname = "0252012345-00001";
try
{
    ApiResponse<List<DeviceGroup>> result = await deviceGroupsController.ListDeviceGroupsAsync(aname);
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
    "name": "Unassigned Devices",
    "description": "All devices that are not in another device group.",
    "isDefaultGroup": true,
    "extendedAttributes": []
  },
  {
    "name": "West Coast Devices",
    "description": "",
    "isDefaultGroup": false,
    "extendedAttributes": []
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Get Device Group Information

When HTTP status is 202, a URL will be returned in the Location header of the form /groups/{aname}/name/{gname}/?next={token}. This URL can be used to request the next set of groups.

```csharp
GetDeviceGroupInformationAsync(
    string aname,
    string gname,
    long? next = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `gname` | `string` | Template, Required | Group name. |
| `next` | `long?` | Query, Optional | Continue the previous query from the pageUrl pagetoken. |

## Response Type

[`Task<ApiResponse<Models.DeviceGroupDevicesData>>`](../../doc/models/device-group-devices-data.md)

## Example Usage

```csharp
string aname = "0252012345-00001";
string gname = "gname2";
try
{
    ApiResponse<DeviceGroupDevicesData> result = await deviceGroupsController.GetDeviceGroupInformationAsync(
        aname,
        gname
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
  "name": "Nebraska Trucks",
  "description": "All service trucks in Nebraska.",
  "hasMoreData": false,
  "devices": [
    {
      "deviceIds": [
        {
          "id": "12345",
          "kind": "meid"
        },
        {
          "id": "54321",
          "kind": "mdn"
        }
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Update Device Group

Make changes to a device group, including changing the name and description, and adding or removing devices.

```csharp
UpdateDeviceGroupAsync(
    string aname,
    string gname,
    Models.DeviceGroupUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `gname` | `string` | Template, Required | Group name. |
| `body` | [`DeviceGroupUpdateRequest`](../../doc/models/device-group-update-request.md) | Body, Required | Request to update device group. |

## Response Type

[`Task<ApiResponse<Models.ConnectivityManagementSuccessResult>>`](../../doc/models/connectivity-management-success-result.md)

## Example Usage

```csharp
string aname = "0252012345-00001";
string gname = "gname2";
DeviceGroupUpdateRequest body = new DeviceGroupUpdateRequest
{
    DevicesToAdd = new List<Models.DeviceId>
    {
        new DeviceId
        {
            Id = "990003420535537",
            Kind = "imei",
        },
    },
    NewGroupDescription = "All western region tank level monitors.",
    NewGroupName = "Western region tanks",
};

try
{
    ApiResponse<ConnectivityManagementSuccessResult> result = await deviceGroupsController.UpdateDeviceGroupAsync(
        aname,
        gname,
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Delete Device Group

Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.

```csharp
DeleteDeviceGroupAsync(
    string aname,
    string gname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `gname` | `string` | Template, Required | Group name. |

## Response Type

[`Task<ApiResponse<Models.ConnectivityManagementSuccessResult>>`](../../doc/models/connectivity-management-success-result.md)

## Example Usage

```csharp
string aname = "0252012345-00001";
string gname = "gname2";
try
{
    ApiResponse<ConnectivityManagementSuccessResult> result = await deviceGroupsController.DeleteDeviceGroupAsync(
        aname,
        gname
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
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

