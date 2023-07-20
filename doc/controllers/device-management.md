# Device Management

```csharp
DeviceManagementController deviceManagementController = client.DeviceManagementController;
```

## Class Name

`DeviceManagementController`

## Methods

* [Add Devices](../../doc/controllers/device-management.md#add-devices)
* [Restore Service for Suspended Devices](../../doc/controllers/device-management.md#restore-service-for-suspended-devices)
* [Update Devices Cost Center Code](../../doc/controllers/device-management.md#update-devices-cost-center-code)
* [List Devices Provisioning History](../../doc/controllers/device-management.md#list-devices-provisioning-history)
* [Get Device Service Suspension Status](../../doc/controllers/device-management.md#get-device-service-suspension-status)
* [List Devices Usage History](../../doc/controllers/device-management.md#list-devices-usage-history)
* [Retrieve Aggregate Device Usage History](../../doc/controllers/device-management.md#retrieve-aggregate-device-usage-history)
* [Update Devices Contact Information](../../doc/controllers/device-management.md#update-devices-contact-information)
* [Update Devices Custom Fields](../../doc/controllers/device-management.md#update-devices-custom-fields)
* [List Devices With Imei Iccid Mismatch](../../doc/controllers/device-management.md#list-devices-with-imei-iccid-mismatch)
* [Update Devices State](../../doc/controllers/device-management.md#update-devices-state)
* [Change Devices Service Plan](../../doc/controllers/device-management.md#change-devices-service-plan)
* [Check Devices Availability for Activation](../../doc/controllers/device-management.md#check-devices-availability-for-activation)
* [Retrieve Device Connection History](../../doc/controllers/device-management.md#retrieve-device-connection-history)
* [Get Device Extended Diagnostic Information](../../doc/controllers/device-management.md#get-device-extended-diagnostic-information)
* [Usage Segmentation Label Association](../../doc/controllers/device-management.md#usage-segmentation-label-association)
* [Activation Order Status](../../doc/controllers/device-management.md#activation-order-status)
* [Activate Service for Devices](../../doc/controllers/device-management.md#activate-service-for-devices)
* [Deactivate Service for Devices](../../doc/controllers/device-management.md#deactivate-service-for-devices)
* [List Current Devices PRL Version](../../doc/controllers/device-management.md#list-current-devices-prl-version)
* [Update Device Id](../../doc/controllers/device-management.md#update-device-id)
* [Device Upload](../../doc/controllers/device-management.md#device-upload)
* [Billed Usage Info](../../doc/controllers/device-management.md#billed-usage-info)
* [Delete Deactivated Devices](../../doc/controllers/device-management.md#delete-deactivated-devices)
* [List Devices Information](../../doc/controllers/device-management.md#list-devices-information)
* [Move Devices Within Accounts of Profile](../../doc/controllers/device-management.md#move-devices-within-accounts-of-profile)
* [Suspend Service for Devices](../../doc/controllers/device-management.md#suspend-service-for-devices)
* [Usage Segmentation Label Deletion](../../doc/controllers/device-management.md#usage-segmentation-label-deletion)
* [Upload Device Identifier](../../doc/controllers/device-management.md#upload-device-identifier)


# Add Devices

Use this API if you want to manage some device settings before you are ready to activate service for the devices.

```csharp
AddDevicesAsync(
    Models.AddDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.AddDevicesRequest`](../../doc/models/add-devices-request.md) | Body, Required | Devices to add. |

## Response Type

[`Task<ApiResponse<List<Models.AddDevicesResult>>>`](../../doc/models/add-devices-result.md)

## Example Usage

```csharp
AddDevicesRequest body = new AddDevicesRequest
{
    AccountName = "0868924207-00001",
    CustomFields = new List<Models.CustomFields>
    {
        new CustomFields
        {
            Key = "CustomField2",
            MValue = "SuperVend",
        },
    },
    DevicesToAdd = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "990013907835573",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "89141390780800784259",
                    Kind = "iccid",
                },
            },
        },
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "990013907884259",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "89141390780800735573",
                    Kind = "iccid",
                },
            },
        },
    },
    GroupName = "West Region",
    State = "preactive",
};

try
{
    ApiResponse<List<AddDevicesResult>> result = await deviceManagementController.AddDevicesAsync(body);
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
    "deviceIds": [
      {
        "id": "89148000000800784259",
        "kind": "iccid"
      }
    ],
    "response": "Success"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Restore Service for Suspended Devices

Restores service to one or more suspended devices.

```csharp
RestoreServiceForSuspendedDevicesAsync(
    Models.CarrierActionsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CarrierActionsRequest`](../../doc/models/carrier-actions-request.md) | Body, Required | Request to restore services of one or more suspended devices. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
CarrierActionsRequest body = new CarrierActionsRequest
{
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "89148000000800139708",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.RestoreServiceForSuspendedDevicesAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Update Devices Cost Center Code

Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.

```csharp
UpdateDevicesCostCenterCodeAsync(
    Models.DeviceCostCenterRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceCostCenterRequest`](../../doc/models/device-cost-center-request.md) | Body, Required | Request to update cost center code value for one or more devices. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
DeviceCostCenterRequest body = new DeviceCostCenterRequest
{
    CostCenter = "cc12345",
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "89148000000800139708",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UpdateDevicesCostCenterCodeAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Devices Provisioning History

Returns the provisioning history of a specified device during a specified time period.

```csharp
ListDevicesProvisioningHistoryAsync(
    Models.DeviceProvisioningHistoryListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceProvisioningHistoryListRequest`](../../doc/models/device-provisioning-history-list-request.md) | Body, Required | Query to obtain device provisioning history. |

## Response Type

[`Task<ApiResponse<List<Models.DeviceProvisioningHistoryListResult>>>`](../../doc/models/device-provisioning-history-list-result.md)

## Example Usage

```csharp
DeviceProvisioningHistoryListRequest body = new DeviceProvisioningHistoryListRequest
{
    DeviceId = new DeviceId
    {
        Id = "89141390780800784259",
        Kind = "iccid",
    },
    Earliest = "2015-09-16T00:00:01Z",
    Latest = "2015-09-18T00:00:01Z",
};

try
{
    ApiResponse<List<DeviceProvisioningHistoryListResult>> result = await deviceManagementController.ListDevicesProvisioningHistoryAsync(body);
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
    "provisioningHistory": [
      {
        "occurredAt": "2015-12-17T13:56:13-05:00",
        "status": "Success",
        "eventBy": "Harry Potter",
        "eventType": "Activation Confirmed",
        "servicePlan": "Tablet5GB",
        "mdn": "",
        "msisdn": "15086303371",
        "extendedAttributes": []
      }
    ],
    "hasMoreData": false
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Get Device Service Suspension Status

Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.

```csharp
GetDeviceServiceSuspensionStatusAsync(
    Models.DeviceSuspensionStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceSuspensionStatusRequest`](../../doc/models/device-suspension-status-request.md) | Body, Required | Request to obtain service suspenstion status for a device. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
DeviceSuspensionStatusRequest body = new DeviceSuspensionStatusRequest
{
    Filter = new DeviceFilterWithoutAccount
    {
        GroupName = "suspended devices",
    },
    AccountName = "1223334444-00001",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.GetDeviceServiceSuspensionStatusAsync(body);
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
  "requestId": "904dcdc6-a590-45e4-ac76-403306f6d883"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Devices Usage History

Returns the network data usage history of a device during a specified time period.

```csharp
ListDevicesUsageHistoryAsync(
    Models.DeviceUsageListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceUsageListRequest`](../../doc/models/device-usage-list-request.md) | Body, Required | Request to obtain usage history for a specific device. |

## Response Type

[`Task<ApiResponse<Models.DeviceUsageListResult>>`](../../doc/models/device-usage-list-result.md)

## Example Usage

```csharp
DeviceUsageListRequest body = new DeviceUsageListRequest
{
    Earliest = "2018-03-20T00:00:01Z",
    Latest = "2020-12-31T00:00:01Z",
};

try
{
    ApiResponse<DeviceUsageListResult> result = await deviceManagementController.ListDevicesUsageHistoryAsync(body);
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
  "hasMoreData": false,
  "usageHistory": [
    {
      "bytesUsed": 4096,
      "extendedAttributes": [
        {
          "key": "MoSms",
          "value": "0"
        }
      ],
      "smsUsed": 0,
      "source": "Raw Usage",
      "timestamp": "2020-12-01T00:00:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Retrieve Aggregate Device Usage History

The information is returned in a callback response, so you must register a URL for DeviceUsage callback messages using the POST /callbacks API.

```csharp
RetrieveAggregateDeviceUsageHistoryAsync(
    Models.DeviceAggregateUsageListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceAggregateUsageListRequest`](../../doc/models/device-aggregate-usage-list-request.md) | Body, Required | A request to retrieve aggregated device usage history information. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
DeviceAggregateUsageListRequest body = new DeviceAggregateUsageListRequest
{
    DeviceIds = new List<Models.DeviceId>
    {
        new DeviceId
        {
            Id = "84258000000891490087",
            Kind = "ICCID",
        },
    },
    AccountName = "9992330389-00001",
    StartTime = "2021-08-01T06:00:00+00:00",
    EndTime = "2021-08-30T06:00:00+00:00",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.RetrieveAggregateDeviceUsageHistoryAsync(body);
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
  "requestId": "1631e200-7398-4609-b1f8-398341229176"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Update Devices Contact Information

Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.

```csharp
UpdateDevicesContactInformationAsync(
    Models.ContactInfoUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ContactInfoUpdateRequest`](../../doc/models/contact-info-update-request.md) | Body, Required | Request to update contact information for devices. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
ContactInfoUpdateRequest body = new ContactInfoUpdateRequest
{
    AccountName = "0212345678-00001",
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "19110173057",
                    Kind = "ESN",
                },
                new DeviceId
                {
                    Id = "19110173057",
                    Kind = "ESN",
                },
            },
        },
    },
    PrimaryPlaceOfUse = ApiHelper.JsonDeserialize<object>("{\"address\":{\"addressLine1\":\"9868 Scranton Rd\",\"addressLine2\":\"Suite A\",\"city\":\"San Diego\",\"state\":\"CA\",\"country\":\"USA\",\"zip\":\"92121\",\"zip4\":\"0001\",\"phone\":\"1234567890\",\"phoneType\":\"H\",\"emailAddress\":\"zaffod@theinternet.com\"},\"customerName\":{\"firstName\":\"Zaffod\",\"lastName\":\"Beeblebrox\",\"middleName\":\"P\",\"title\":\"President\",\"suffix\":\"I\"}}"),
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UpdateDevicesContactInformationAsync(body);
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
  "requestId": "24da9f9a-d110-4a54-86b4-93fb76aab83c"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Update Devices Custom Fields

Sends a CarrierService callback message for each device in the request when the custom fields have been changed, or if there was a problem and the change could not be completed.

```csharp
UpdateDevicesCustomFieldsAsync(
    Models.CustomFieldsUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CustomFieldsUpdateRequest`](../../doc/models/custom-fields-update-request.md) | Body, Required | Request to update custom field of devices. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
CustomFieldsUpdateRequest body = new CustomFieldsUpdateRequest
{
    CustomFieldsToUpdate = new List<Models.CustomFields>
    {
        new CustomFields
        {
            Key = "CustomField1",
            MValue = "West Region",
        },
        new CustomFields
        {
            Key = "CustomField2",
            MValue = "Distribution",
        },
    },
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "89148000000800139708",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UpdateDevicesCustomFieldsAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Devices With Imei Iccid Mismatch

Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.

```csharp
ListDevicesWithImeiIccidMismatchAsync(
    Models.DeviceMismatchListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceMismatchListRequest`](../../doc/models/device-mismatch-list-request.md) | Body, Required | Request to list devices with mismatched IMEIs and ICCIDs. |

## Response Type

[`Task<ApiResponse<Models.DeviceMismatchListResult>>`](../../doc/models/device-mismatch-list-result.md)

## Example Usage

```csharp
DeviceMismatchListRequest body = new DeviceMismatchListRequest
{
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "8914800000080078",
                    Kind = "ICCID",
                },
                new DeviceId
                {
                    Id = "5096300587",
                    Kind = "MDN",
                },
            },
        },
    },
    Filter = new DateFilter
    {
        Earliest = "2020-05-01T15:00:00-08:00Z",
        Latest = "2020-07-30T15:00:00-08:00Z",
    },
    AccountName = "0342077109-00001",
};

try
{
    ApiResponse<DeviceMismatchListResult> result = await deviceManagementController.ListDevicesWithImeiIccidMismatchAsync(body);
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
  "devices": [
    {
      "accountName": "0212398765-00001",
      "mdn": "5096300587",
      "activationDate": "2011-01-21T10:55:27-08:00",
      "iccid": "89148000000800784259",
      "preImei": "990003420535573",
      "postImei": "987603420573553",
      "simOtaDate": "2017-12-01T16:00:00-08:00"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Update Devices State

Changes the provisioning state of one or more devices to a specified customer-defined service and state.

```csharp
UpdateDevicesStateAsync(
    Models.GoToStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.GoToStateRequest`](../../doc/models/go-to-state-request.md) | Body, Required | Request to change device state to one defined by the user. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
GoToStateRequest body = new GoToStateRequest
{
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "990013907835573",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "89141390780800784259",
                    Kind = "iccid",
                },
            },
        },
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "990013907884259",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "89141390780800735573",
                    Kind = "iccid",
                },
            },
        },
    },
    ServiceName = "My Service",
    StateName = "My State",
    ServicePlan = "87641",
    MdnZipCode = "94203",
    PublicIpRestriction = "unrestricted",
    GroupName = "4G West",
    PrimaryPlaceOfUse = new PlaceOfUse
    {
        Address = new Address
        {
            AddressLine1 = "1600 Pennsylvania Ave NW",
            City = "Washington",
            State = "DC",
            Zip = "20500",
            Country = "USA",
        },
        CustomerName = new CustomerName
        {
            FirstName = "Zaffod",
            LastName = "Beeblebrox",
            Title = "President",
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UpdateDevicesStateAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Change Devices Service Plan

Changes the service plan for one or more devices.

```csharp
ChangeDevicesServicePlanAsync(
    Models.ServicePlanUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ServicePlanUpdateRequest`](../../doc/models/service-plan-update-request.md) | Body, Required | Request to change device service plan. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
ServicePlanUpdateRequest body = new ServicePlanUpdateRequest
{
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "A100003685E561",
                    Kind = "meid",
                },
            },
        },
    },
    ServicePlan = "new_service_plan_code",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.ChangeDevicesServicePlanAsync(body);
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
  "requestId": "c8de7c1d-59b9-4cf3-b969-db76cb2ce509"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Check Devices Availability for Activation

Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.

```csharp
CheckDevicesAvailabilityForActivationAsync(
    Models.DeviceActivationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceActivationRequest`](../../doc/models/device-activation-request.md) | Body, Required | Request to check if devices can be activated or not. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
DeviceActivationRequest body = new DeviceActivationRequest
{
    AccountName = "0212345678-00001",
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "A100008385E561",
                    Kind = "meid",
                },
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.CheckDevicesAvailabilityForActivationAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Retrieve Device Connection History

Each response includes a maximum of 500 records. To obtain more records, you can call the API multiple times, adjusting the earliest value each time to start where the previous request finished.

```csharp
RetrieveDeviceConnectionHistoryAsync(
    Models.DeviceConnectionListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceConnectionListRequest`](../../doc/models/device-connection-list-request.md) | Body, Required | Query to retrieve device connection history. |

## Response Type

[`Task<ApiResponse<Models.ConnectionHistoryResult>>`](../../doc/models/connection-history-result.md)

## Example Usage

```csharp
DeviceConnectionListRequest body = new DeviceConnectionListRequest
{
    DeviceId = new DeviceId
    {
        Id = "89141390780800784259",
        Kind = "iccid",
    },
    Earliest = "2015-09-16T00:00:01Z",
    Latest = "2010-09-18T00:00:01Z",
};

try
{
    ApiResponse<ConnectionHistoryResult> result = await deviceManagementController.RetrieveDeviceConnectionHistoryAsync(body);
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
  "connectionHistory": [
    {
      "connectionEventAttributes": [
        {
          "key": "BytesUsed",
          "value": "0"
        },
        {
          "key": "Event",
          "value": "Start"
        }
      ],
      "extendedAttributes": [],
      "occurredAt": "2015-12-17T14:12:36-05:00"
    },
    {
      "connectionEventAttributes": [
        {
          "key": "BytesUsed",
          "value": "419863234"
        },
        {
          "key": "Event",
          "value": "Stop"
        },
        {
          "key": "Msisdn",
          "value": "15086303371"
        }
      ],
      "extendedAttributes": [],
      "occurredAt": "2015-12-19T01:20:00-05:00"
    }
  ],
  "hasMoreData": false
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Get Device Extended Diagnostic Information

Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.

```csharp
GetDeviceExtendedDiagnosticInformationAsync(
    Models.DeviceExtendedDiagnosticsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceExtendedDiagnosticsRequest`](../../doc/models/device-extended-diagnostics-request.md) | Body, Required | Request to query extended diagnostics information for a device. |

## Response Type

[`Task<ApiResponse<Models.DeviceExtendedDiagnosticsResult>>`](../../doc/models/device-extended-diagnostics-result.md)

## Example Usage

```csharp
DeviceExtendedDiagnosticsRequest body = new DeviceExtendedDiagnosticsRequest
{
    AccountName = "1223334444-00001",
    DeviceList = new List<Models.DeviceId>
    {
        new DeviceId
        {
            Id = "10-digit MDN",
            Kind = "mdn",
        },
    },
};

try
{
    ApiResponse<DeviceExtendedDiagnosticsResult> result = await deviceManagementController.GetDeviceExtendedDiagnosticInformationAsync(body);
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
  "categories": [
    {
      "categoryName": "Connectivity",
      "extendedAttributes": [
        {
          "key": "Connected",
          "value": "false"
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


# Usage Segmentation Label Association

Allows you to associate your own usage segmentation label with a device.

```csharp
UsageSegmentationLabelAssociationAsync(
    Models.AssociateLabelRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.AssociateLabelRequest`](../../doc/models/associate-label-request.md) | Body, Required | Request to associate a label to a device. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
AssociateLabelRequest body = new AssociateLabelRequest
{
    AccountName = "1223334444-00001",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UsageSegmentationLabelAssociationAsync(body);
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
  "requestId": "ec682a8b-e288-4806-934d-24e7a59ed889"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Activation Order Status

Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.

```csharp
ActivationOrderStatusAsync(
    Models.UploadsActivatesDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.UploadsActivatesDeviceRequest`](../../doc/models/uploads-activates-device-request.md) | Body, Required | Request to Uploads and activates device. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
UploadsActivatesDeviceRequest body = new UploadsActivatesDeviceRequest
{
    AccountName = "1223334444-00001",
    EmailAddress = "bob@mycompany.com",
    DeviceSku = "VZW123456",
    UploadType = "IMEI ICCID Pair",
    ServicePlan = "15MBShr",
    MdnZipCode = "92222",
    Devices = new List<Models.DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<Models.DeviceId1>
            {
                new DeviceId1
                {
                    Id = "990013907835573",
                    Kind = KindEnum.Imei,
                },
                new DeviceId1
                {
                    Id = "89141390780800784259",
                    Kind = KindEnum.Iccid,
                },
            },
        },
    },
    CarrierIpPoolName = "",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.ActivationOrderStatusAsync(body);
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
  "requestId": "ec682a8b-e288-4806-934d-24e7a59ed889"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Activate Service for Devices

If the devices do not already exist in the account, this API resource adds them before activation.

```csharp
ActivateServiceForDevicesAsync(
    Models.CarrierActivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CarrierActivateRequest`](../../doc/models/carrier-activate-request.md) | Body, Required | Request for activating a service on devices. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
CarrierActivateRequest body = new CarrierActivateRequest
{
    AccountName = "0868924207-00001",
    CustomFields = new List<Models.CustomFields>
    {
        new CustomFields
        {
            Key = "CustomField2",
            MValue = "SuperVend",
        },
    },
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "990013907835573",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "89141390780800784259",
                    Kind = "iccid",
                },
            },
        },
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "990013907884259",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "89141390780800735573",
                    Kind = "iccid",
                },
            },
        },
    },
    GroupName = "4G West",
    MdnZipCode = "98801",
    PrimaryPlaceOfUse = new PlaceOfUse
    {
        Address = new Address
        {
            AddressLine1 = "1600 Pennsylvania Ave NW",
            City = "Washington",
            State = "DC",
            Zip = "20500",
            Country = "USA",
        },
        CustomerName = new CustomerName
        {
            FirstName = "Zaffod",
            LastName = "Beeblebrox",
            Title = "President",
        },
    },
    ServicePlan = "m2m_4G",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.ActivateServiceForDevicesAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Deactivate Service for Devices

Deactivating service for a device may result in an early termination fee (ETF) being charged to the account, depending on the terms of the contract with Verizon. If your contract allows ETF waivers and if you want to use one for a particular deactivation, set the etfWaiver value to True.

```csharp
DeactivateServiceForDevicesAsync(
    Models.CarrierDeactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CarrierDeactivateRequest`](../../doc/models/carrier-deactivate-request.md) | Body, Required | Request to deactivate service for one or more devices. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
CarrierDeactivateRequest body = new CarrierDeactivateRequest
{
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
            },
        },
    },
    EtfWaiver = true,
    ReasonCode = "FF",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.DeactivateServiceForDevicesAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Current Devices PRL Version

4G and GSM devices do not have a PRL.

```csharp
ListCurrentDevicesPRLVersionAsync(
    Models.DevicePrlListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DevicePrlListRequest`](../../doc/models/device-prl-list-request.md) | Body, Required | Request to query device PRL. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
DevicePrlListRequest body = new DevicePrlListRequest
{
    AccountName = "101234-0001",
    GroupName = "West Region",
    ServicePlan = "3G 2MB",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.ListCurrentDevicesPRLVersionAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Update Device Id

Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.

```csharp
UpdateDeviceIdAsync(
    string serviceType,
    Models.ChangeDeviceIdRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceType` | `string` | Template, Required | Identifier type. |
| `body` | [`Models.ChangeDeviceIdRequest`](../../doc/models/change-device-id-request.md) | Body, Required | Request to update device id. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
string serviceType = "serviceType6";
ChangeDeviceIdRequest body = new ChangeDeviceIdRequest
{
    Change4gOption = "ChangeICCID",
    DeviceIds = new List<Models.DeviceId>
    {
        new DeviceId
        {
            Id = "42590078891480000008",
            Kind = "iccid",
        },
    },
    DeviceIdsTo = new List<Models.DeviceId>
    {
        new DeviceId
        {
            Id = "89148000000842590078",
            Kind = "iccid",
        },
    },
    ServicePlan = "4G 2GB",
    ZipCode = "98802",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UpdateDeviceIdAsync(serviceType, body);
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
  "requestId": "a28892ea-6503-4aa7-bfa2-4cd45d42f61b"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Device Upload

This corresponds to the M2M-MC SOAP interface, `DeviceUploadService`.

```csharp
DeviceUploadAsync(
    Models.DeviceUploadRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeviceUploadRequest`](../../doc/models/device-upload-request.md) | Body, Required | Device Upload Query |

## Response Type

[`Task<ApiResponse<Models.RequestResponse>>`](../../doc/models/request-response.md)

## Example Usage

```csharp
DeviceUploadRequest body = new DeviceUploadRequest
{
    AccountName = "1223334444-00001",
    Devices = new List<Models.DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<Models.DeviceId1>
            {
                new DeviceId1
                {
                    Id = "15-digit IMEI",
                    Kind = KindEnum.Imei,
                },
            },
        },
        new DeviceList
        {
            DeviceIds = new List<Models.DeviceId1>
            {
                new DeviceId1
                {
                    Id = "15-digit IMEI",
                    Kind = KindEnum.Imei,
                },
            },
        },
    },
    EmailAddress = "bob@mycompany.com",
    DeviceSku = "VZW123456",
    UploadType = "IMEI",
};

try
{
    ApiResponse<RequestResponse> result = await deviceManagementController.DeviceUploadAsync(body);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Billed Usage Info

Gets billed usage for for either multiple devices or an entire billing account.

```csharp
BilledUsageInfoAsync(
    Models.BilledusageListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.BilledusageListRequest`](../../doc/models/billedusage-list-request.md) | Body, Required | Request to list devices with mismatched IMEIs and ICCIDs. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
BilledusageListRequest body = new BilledusageListRequest
{
    AccountName = "0342077109-00001",
    Devices = new List<Models.DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<Models.DeviceId1>
            {
                new DeviceId1
                {
                    Id = "8914800000080078",
                    Kind = KindEnum.Iccid,
                },
                new DeviceId1
                {
                    Id = "5096300587",
                    Kind = KindEnum.Eid,
                },
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.BilledUsageInfoAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Delete Deactivated Devices

Use this API to remove unneeded devices from an account.

```csharp
DeleteDeactivatedDevicesAsync(
    Models.DeleteDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeleteDevicesRequest`](../../doc/models/delete-devices-request.md) | Body, Required | Devices to delete. |

## Response Type

[`Task<ApiResponse<List<Models.DeleteDevicesResult>>>`](../../doc/models/delete-devices-result.md)

## Example Usage

```csharp
DeleteDevicesRequest body = new DeleteDevicesRequest
{
    DevicesToDelete = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "09005470263",
                    Kind = "esn",
                },
            },
        },
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "85000022411113460014",
                    Kind = "iccid",
                },
            },
        },
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "85000022412313460016",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<List<DeleteDevicesResult>> result = await deviceManagementController.DeleteDeactivatedDevicesAsync(body);
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
    "deviceIds": {
      "id": "09005470263",
      "kind": "esn"
    },
    "status": "Success"
  },
  {
    "deviceIds": {
      "id": "85000022411113460014",
      "kind": "iccid"
    },
    "status": "Success"
  },
  {
    "deviceIds": [
      {
        "id": "85000022412313460016",
        "kind": "iccid"
      },
      {
        "id": "09005470263",
        "kind": "esn"
      }
    ],
    "status": "Failed",
    "message": "The device is not in deactive state."
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Devices Information

Returns information about a single device or information about all devices that match the given parameters. Returned information includes device provisioning state, service plan, MDN, MIN, and IP address.

```csharp
ListDevicesInformationAsync(
    Models.AccountDeviceListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.AccountDeviceListRequest`](../../doc/models/account-device-list-request.md) | Body, Required | Device information query. |

## Response Type

[`Task<ApiResponse<Models.AccountDeviceListResult>>`](../../doc/models/account-device-list-result.md)

## Example Usage

```csharp
AccountDeviceListRequest body = new AccountDeviceListRequest
{
    DeviceId = new DeviceId
    {
        Id = "20-digit ICCID",
        Kind = "iccid",
    },
};

try
{
    ApiResponse<AccountDeviceListResult> result = await deviceManagementController.ListDevicesInformationAsync(body);
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
  "hasMoreData": false,
  "devices": [
    {
      "accountName": "0000123456-00001",
      "billingCycleEndDate": "2020-05-09T20:00:00-04:00",
      "carrierInformations": [
        {
          "carrierName": "Verizon Wireless",
          "servicePlan": "m2m4G",
          "state": "active"
        }
      ],
      "connected": false,
      "createdAt": "2019-08-07T10:42:15-04:00",
      "deviceIds": [
        {
          "id": "10-digit MDN",
          "kind": "mdn"
        },
        {
          "id": "15-digit IMEI",
          "kind": "imei"
        }
      ],
      "groupNames": [
        "southwest"
      ],
      "ipAddress": "0.0.0.0",
      "lastActivationBy": "Joe Q Public",
      "lastActivationDate": "2019-08-07T10:42:34-04:00",
      "lastConnectionDate": "2020-03-12T04:23:37-04:00"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Move Devices Within Accounts of Profile

Move active devices from one billing account to another within a customer profile.

```csharp
MoveDevicesWithinAccountsOfProfileAsync(
    Models.MoveDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.MoveDeviceRequest`](../../doc/models/move-device-request.md) | Body, Required | Request to move devices between accounts. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
MoveDeviceRequest body = new MoveDeviceRequest
{
    AccountName = "0212345678-00001",
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "19110173057",
                    Kind = "ESN",
                },
            },
        },
    },
    ServicePlan = "M2M5GB",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.MoveDevicesWithinAccountsOfProfileAsync(body);
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
  "requestId": "ec682a8b-e288-4806-934d-24e7a59ed889"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Suspend Service for Devices

Suspends service for one or more devices.

```csharp
SuspendServiceForDevicesAsync(
    Models.CarrierActionsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CarrierActionsRequest`](../../doc/models/carrier-actions-request.md) | Body, Required | Request to suspend service for one or more devices. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
CarrierActionsRequest body = new CarrierActionsRequest
{
    Devices = new List<Models.AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<Models.DeviceId>
            {
                new DeviceId
                {
                    Id = "89148000000800139708",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.SuspendServiceForDevicesAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Usage Segmentation Label Deletion

Allow customers to remove the associated label from a device.

```csharp
UsageSegmentationLabelDeletionAsync(
    string accountName,
    Models.LabelsList labelList)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | The numeric name of the account. |
| `labelList` | [`Models.LabelsList`](../../doc/models/labels-list.md) | Query, Required | A list of the Label IDs to remove from the exclusion list. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
LabelsList labelList = new LabelsList
{
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UsageSegmentationLabelDeletionAsync(accountName, labelList);
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
  "requestId": "ec682a8b-e288-4806-934d-24e7a59ed889"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Upload Device Identifier

Checks the status of an activation order and lists where the order is in the provisioning process.

```csharp
UploadDeviceIdentifierAsync(
    Models.CheckOrderStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CheckOrderStatusRequest`](../../doc/models/check-order-status-request.md) | Body, Required | The request body identifies the device and reporting period that you want included in the report. |

## Response Type

[`Task<ApiResponse<Models.DeviceManagementResult>>`](../../doc/models/device-management-result.md)

## Example Usage

```csharp
CheckOrderStatusRequest body = new CheckOrderStatusRequest
{
    AccountName = "4Gpublicaccount ",
    Devices = new List<Models.DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<Models.DeviceId1>
            {
                new DeviceId1
                {
                    Id = "20112019672551234613",
                    Kind = KindEnum.Iccid,
                },
            },
        },
    },
    OrderRequestId = " f55fea16-3664-4a32-ae9d-c0cbe3eedf1d ",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UploadDeviceIdentifierAsync(body);
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

