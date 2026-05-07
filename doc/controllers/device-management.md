# Device Management

```csharp
DeviceManagementController deviceManagementController = client.DeviceManagementController;
```

## Class Name

`DeviceManagementController`

## Methods

* [Activate Service for Devices](../../doc/controllers/device-management.md#activate-service-for-devices)
* [Add Devices](../../doc/controllers/device-management.md#add-devices)
* [Update Devices Contact Information](../../doc/controllers/device-management.md#update-devices-contact-information)
* [Update Devices Custom Fields](../../doc/controllers/device-management.md#update-devices-custom-fields)
* [Deactivate Service for Devices](../../doc/controllers/device-management.md#deactivate-service-for-devices)
* [Delete Deactivated Devices](../../doc/controllers/device-management.md#delete-deactivated-devices)
* [List Devices Information](../../doc/controllers/device-management.md#list-devices-information)
* [List Devices with Imei Iccid Mismatch](../../doc/controllers/device-management.md#list-devices-with-imei-iccid-mismatch)
* [Move Devices within Accounts of Profile](../../doc/controllers/device-management.md#move-devices-within-accounts-of-profile)
* [Update Devices State](../../doc/controllers/device-management.md#update-devices-state)
* [Change Devices Service Plan](../../doc/controllers/device-management.md#change-devices-service-plan)
* [Suspend Service for Devices](../../doc/controllers/device-management.md#suspend-service-for-devices)
* [Restore Service for Suspended Devices](../../doc/controllers/device-management.md#restore-service-for-suspended-devices)
* [Check Devices Availability for Activation](../../doc/controllers/device-management.md#check-devices-availability-for-activation)
* [Retrieve Device Connection History](../../doc/controllers/device-management.md#retrieve-device-connection-history)
* [Update Devices Cost Center Code](../../doc/controllers/device-management.md#update-devices-cost-center-code)
* [Get Device Extended Diagnostic Information](../../doc/controllers/device-management.md#get-device-extended-diagnostic-information)
* [List Devices Provisioning History](../../doc/controllers/device-management.md#list-devices-provisioning-history)
* [List Current Devices PRL Version](../../doc/controllers/device-management.md#list-current-devices-prl-version)
* [Get Device Service Suspension Status](../../doc/controllers/device-management.md#get-device-service-suspension-status)
* [List Devices Usage History](../../doc/controllers/device-management.md#list-devices-usage-history)
* [Retrieve Aggregate Device Usage History](../../doc/controllers/device-management.md#retrieve-aggregate-device-usage-history)
* [Update Device Id](../../doc/controllers/device-management.md#update-device-id)
* [Device Upload](../../doc/controllers/device-management.md#device-upload)
* [Billed Usage Info](../../doc/controllers/device-management.md#billed-usage-info)
* [Usage Segmentation Label Association](../../doc/controllers/device-management.md#usage-segmentation-label-association)
* [Usage Segmentation Label Deletion](../../doc/controllers/device-management.md#usage-segmentation-label-deletion)
* [Upload Activate Device](../../doc/controllers/device-management.md#upload-activate-device)
* [Device Upload Status](../../doc/controllers/device-management.md#device-upload-status)


# Activate Service for Devices

If the devices do not already exist in the account, this API resource adds them before activation.

```csharp
ActivateServiceForDevicesAsync(
    Models.CarrierActivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CarrierActivateRequest`](../../doc/models/carrier-activate-request.md) | Body, Required | Request for activating a service on devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
CarrierActivateRequest body = new CarrierActivateRequest
{
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
            Ipaddress = "1.2.3.456",
        },
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
            Ipaddress = "1.2.3.456",
        },
    },
    ServicePlan = "the service plan name",
    MdnZipCode = "98801",
    AccountName = "0868924207-00001",
    CustomFields = new List<CustomFields>
    {
        new CustomFields
        {
            Key = "CustomField2",
            MValue = "SuperVend",
        },
    },
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
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.ActivateServiceForDevicesAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Add Devices

Use this API if you want to manage some device settings before you are ready to activate service for the devices.

```csharp
AddDevicesAsync(
    Models.AddDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AddDevicesRequest`](../../doc/models/add-devices-request.md) | Body, Required | Devices to add. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.AddDevicesResult>](../../doc/models/add-devices-result.md).

## Example Usage

```csharp
AddDevicesRequest body = new AddDevicesRequest
{
    State = "Pre-active",
    DevicesToAdd = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "15-digit IMEI",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
            },
        },
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "15-digit IMEI",
                    Kind = "imei",
                },
                new DeviceId
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
            },
        },
    },
    AccountName = "0000123456-00001",
    CustomFields = new List<CustomFields>
    {
        new CustomFields
        {
            Key = "CustomField2",
            MValue = "SuperVend",
        },
    },
    GroupName = "West Region",
};

try
{
    ApiResponse<List<AddDevicesResult>> result = await deviceManagementController.AddDevicesAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
[
  {
    "deviceIds": [
      {
        "id": "20-digit ICCID",
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


# Update Devices Contact Information

Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.

```csharp
UpdateDevicesContactInformationAsync(
    Models.ContactInfoUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ContactInfoUpdateRequest`](../../doc/models/contact-info-update-request.md) | Body, Required | Request to update contact information for devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
ContactInfoUpdateRequest body = new ContactInfoUpdateRequest
{
    PrimaryPlaceOfUse = new PlaceOfUse
    {
        Address = new Address
        {
            AddressLine1 = "9868 Scranton Rd",
            City = "San Diego",
            State = "CA",
            Zip = "92121",
            Country = "USA",
            AddressLine2 = "Suite A",
            Zip4 = "0001",
            Phone = "1234567890",
            PhoneType = "H",
            EmailAddress = "zaffod@theinternet.com",
        },
        CustomerName = new CustomerName
        {
            FirstName = "Zaffod",
            LastName = "Beeblebrox",
            Title = "President",
            MiddleName = "P",
            Suffix = "I",
        },
    },
    AccountName = "0000123456-00001",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UpdateDevicesContactInformationAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`CustomFieldsUpdateRequest`](../../doc/models/custom-fields-update-request.md) | Body, Required | Request to update custom field of devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
CustomFieldsUpdateRequest body = new CustomFieldsUpdateRequest
{
    CustomFieldsToUpdate = new List<CustomFields>
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
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`CarrierDeactivateRequest`](../../doc/models/carrier-deactivate-request.md) | Body, Required | Request to deactivate service for one or more devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
CarrierDeactivateRequest body = new CarrierDeactivateRequest
{
    AccountName = "0000123456-00001",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
            },
        },
    },
    ReasonCode = "FF",
    EtfWaiver = true,
    DeleteAfterDeactivation = true,
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.DeactivateServiceForDevicesAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`DeleteDevicesRequest`](../../doc/models/delete-devices-request.md) | Body, Required | Devices to delete. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DeleteDevicesResult>](../../doc/models/delete-devices-result.md).

## Example Usage

```csharp
DeleteDevicesRequest body = new DeleteDevicesRequest
{
    DevicesToDelete = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
            DeviceIds = new List<DeviceId>
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
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`AccountDeviceListRequest`](../../doc/models/account-device-list-request.md) | Body, Required | Device information query. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AccountDeviceListResult](../../doc/models/account-device-list-result.md).

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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# List Devices with Imei Iccid Mismatch

Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.

```csharp
ListDevicesWithImeiIccidMismatchAsync(
    Models.DeviceMismatchListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceMismatchListRequest`](../../doc/models/device-mismatch-list-request.md) | Body, Required | Request to list devices with mismatched IMEIs and ICCIDs. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceMismatchListResult](../../doc/models/device-mismatch-list-result.md).

## Example Usage

```csharp
DeviceMismatchListRequest body = new DeviceMismatchListRequest
{
    Filter = new DateFilter
    {
        Earliest = "2020-05-01T15:00:00-08:00Z",
        Latest = "2020-07-30T15:00:00-08:00Z",
    },
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
    AccountName = "0342077109-00001",
};

try
{
    ApiResponse<DeviceMismatchListResult> result = await deviceManagementController.ListDevicesWithImeiIccidMismatchAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Move Devices within Accounts of Profile

Move active devices from one billing account to another within a customer profile.

```csharp
MoveDevicesWithinAccountsOfProfileAsync(
    Models.MoveDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`MoveDeviceRequest`](../../doc/models/move-device-request.md) | Body, Required | Request to move devices between accounts. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
MoveDeviceRequest body = new MoveDeviceRequest
{
    AccountName = "0212345678-00001",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Update Devices State

Changes the provisioning state of one or more devices to a specified customer-defined service and state.

```csharp
UpdateDevicesStateAsync(
    Models.GoToStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GoToStateRequest`](../../doc/models/go-to-state-request.md) | Body, Required | Request to change device state to one defined by the user. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
GoToStateRequest body = new GoToStateRequest
{
    ServiceName = "My Service",
    StateName = "My State",
    ServicePlan = "87641",
    MdnZipCode = "94203",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`ServicePlanUpdateRequest`](../../doc/models/service-plan-update-request.md) | Body, Required | Request to change device service plan. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
ServicePlanUpdateRequest body = new ServicePlanUpdateRequest
{
    ServicePlan = "Tablet5GB",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "A100003685E561",
                    Kind = "meid",
                },
            },
        },
    },
    CarrierIpPoolName = "IPPool",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.ChangeDevicesServicePlanAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Suspend Service for Devices

Suspends service for one or more devices.

```csharp
SuspendServiceForDevicesAsync(
    Models.CarrierActionsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CarrierActionsRequest`](../../doc/models/carrier-actions-request.md) | Body, Required | Request to suspend service for one or more devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
CarrierActionsRequest body = new CarrierActionsRequest
{
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Restore Service for Suspended Devices

Restores service to one or more suspended devices.

```csharp
RestoreServiceForSuspendedDevicesAsync(
    Models.CarrierActionsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CarrierActionsRequest`](../../doc/models/carrier-actions-request.md) | Body, Required | Request to restore services of one or more suspended devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
CarrierActionsRequest body = new CarrierActionsRequest
{
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Check Devices Availability for Activation

Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.

```csharp
CheckDevicesAvailabilityForActivationAsync(
    Models.DeviceActivationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceActivationRequest`](../../doc/models/device-activation-request.md) | Body, Required | Request to check if devices can be activated or not. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
DeviceActivationRequest body = new DeviceActivationRequest
{
    AccountName = "0212345678-00001",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`DeviceConnectionListRequest`](../../doc/models/device-connection-list-request.md) | Body, Required | Query to retrieve device connection history. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ConnectionHistoryResult](../../doc/models/connection-history-result.md).

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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Update Devices Cost Center Code

Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.

```csharp
UpdateDevicesCostCenterCodeAsync(
    Models.DeviceCostCenterRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceCostCenterRequest`](../../doc/models/device-cost-center-request.md) | Body, Required | Request to update cost center code value for one or more devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
DeviceCostCenterRequest body = new DeviceCostCenterRequest
{
    CostCenter = "cc12345",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Get Device Extended Diagnostic Information

Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.

```csharp
GetDeviceExtendedDiagnosticInformationAsync(
    Models.DeviceExtendedDiagnosticsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceExtendedDiagnosticsRequest`](../../doc/models/device-extended-diagnostics-request.md) | Body, Required | Request to query extended diagnostics information for a device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceExtendedDiagnosticsResult](../../doc/models/device-extended-diagnostics-result.md).

## Example Usage

```csharp
DeviceExtendedDiagnosticsRequest body = new DeviceExtendedDiagnosticsRequest
{
    AccountName = "0000123456-00001",
    DeviceList = new List<DeviceId>
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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "deviceList": [
    {
      "id": "15-digit IMEI",
      "kind": "imei"
    }
  ],
  "categories": [
    {
      "categoryName": "DeviceIdentifier",
      "extendedAttributes": [
        {
          "key": "ICCID",
          "value": "20-digit ICCID"
        },
        {
          "key": "IMEI",
          "value": "15-digit IMEI"
        },
        {
          "key": "IMSI",
          "value": "15-digit IMSI"
        },
        {
          "key": "MDN",
          "value": "10-digit phone number"
        },
        {
          "key": "MIN",
          "value": "10-digit phone number"
        },
        {
          "key": "MSISDN",
          "value": "1+ 10-digit phone number"
        }
      ]
    },
    {
      "categoryName": "DeviceAttributes",
      "extendedAttributes": [
        {
          "key": "AccountName",
          "value": "0000123456-00001"
        },
        {
          "key": "GroupName",
          "value": "Default: 0000123456-00001"
        },
        {
          "key": "DeviceSku",
          "value": "VZW080000100112"
        },
        {
          "key": "CustomFields1",
          "value": "5G SA FWA site"
        },
        {
          "key": "ServicePlanType",
          "value": "Public Dynamic"
        },
        {
          "key": "FeatureCodes",
          "value": "84777,86112"
        },
        {
          "key": "FeatureNames",
          "value": "84777,86112"
        },
        {
          "key": "FeatureTypes",
          "value": "4G PUBLIC DYNAM IP DSS STREAM,5G IPV/IPV6 IP"
        },
        {
          "key": "BundleSku",
          "value": "TSS-IOT-INTELLIGENCE-CUSTOM"
        },
        {
          "key": "RatePlanCode",
          "value": "5GBI100MBPS"
        },
        {
          "key": "DeviceMake",
          "value": "ODI"
        },
        {
          "key": "DeviceModel",
          "value": "DIGI - EX50-WXS6-GLB"
        },
        {
          "key": "ModemGeneration",
          "value": "5G"
        },
        {
          "key": "4GDeviceDetectionDate",
          "value": "2024-09-25T22:18:07Z"
        },
        {
          "key": "Services",
          "value": "null"
        },
        {
          "key": "ModemType",
          "value": "5GE"
        },
        {
          "key": "DiagnosticsEligibility",
          "value": "StreamEligible"
        },
        {
          "key": "DiagnosticsSKUName",
          "value": "TSS-IOT-INTLG-CUSTOM-DIAG-LWM2M"
        },
        {
          "key": "AvailableNetworks",
          "value": "6"
        },
        {
          "key": "ModemCategory",
          "value": "IoT Module"
        }
      ]
    },
    {
      "categoryName": "Provisioning",
      "extendedAttributes": [
        {
          "key": "LastActivationBy",
          "value": "Verizon, User"
        },
        {
          "key": "LastActivationDate",
          "value": "2024-09-25T00:10:24Z"
        },
        {
          "key": "CreatedAt",
          "value": "2024-09-24T20:56:12Z"
        },
        {
          "key": "DeviceState",
          "value": "active"
        },
        {
          "key": "LastDeactivationDate",
          "value": "2024-09-25T00:05:21Z"
        }
      ]
    },
    {
      "categoryName": "Connectivity",
      "extendedAttributes": [
        {
          "key": "Connected",
          "value": "true"
        },
        {
          "key": "LastConnectionDate",
          "value": "2025-03-14T13:12:01.000Z"
        },
        {
          "key": "IPAddress",
          "value": "10.0.0.0"
        },
        {
          "key": "LastDisconnectDate",
          "value": "2025-03-14T08:34:43.000Z"
        },
        {
          "key": "RoamingStatus",
          "value": "false"
        },
        {
          "key": "RomaingLastModifiedDate",
          "value": "2025-03-14T13:12:01.000Z"
        },
        {
          "key": "RequiredAPN",
          "value": "The Access point name"
        }
      ]
    },
    {
      "categoryName": "Billing",
      "extendedAttributes": [
        {
          "key": "BillingCycleStartDate",
          "value": "2024-09-25T12:00:00Z"
        },
        {
          "key": "BillingCycleEndDate",
          "value": "2024-09-25T12:00:00Z"
        },
        {
          "key": "DefaultRatePlan",
          "value": "0"
        }
      ]
    },
    {
      "categoryName": "Usage",
      "extendedAttributes": [
        {
          "key": "CurrentRatedUsageRecordDate",
          "value": "2024-09-25T00:00:00Z"
        },
        {
          "key": "CurrentBillCycleDataRatedUsage",
          "value": "0"
        },
        {
          "key": "CurrentBillCycleRatedSMSUsage",
          "value": "0"
        },
        {
          "key": "PromoSmsUsage",
          "value": "0"
        },
        {
          "key": "PromoSmsUsagePercent",
          "value": "0"
        },
        {
          "key": "PromoDataUsage",
          "value": "0"
        },
        {
          "key": "PromoDataUsagePercent",
          "value": "0"
        },
        {
          "key": "AaaPromoDataUsage",
          "value": "0"
        },
        {
          "key": "RtrPromoDataUsage",
          "value": "0"
        },
        {
          "key": "InternationalRoamingUsage",
          "value": "0"
        }
      ]
    },
    {
      "categoryName": "Location",
      "extendedAttributes": [
        {
          "key": "LocationSkuName",
          "value": "TSS-IOT-INTLG-CUSTOM-LOC-COARSE"
        },
        {
          "key": "LastLocationUpdate",
          "value": "2024-06-17T16:23:14Z"
        },
        {
          "key": "Latitude",
          "value": "33.122153"
        },
        {
          "key": "Longitude",
          "value": "-96.641825"
        },
        {
          "key": "LastLocationAttemptDate",
          "value": "2024-09-25T16:23:14Z"
        },
        {
          "key": "LastLocationStatus",
          "value": "122"
        }
      ]
    },
    {
      "categoryName": "FOTA",
      "extendedAttributes": [
        {
          "key": "FotaCurrentFirmwareVersion",
          "value": "SWIX55C_03.09.11.00"
        },
        {
          "key": "FotaSku",
          "value": "TSS-IOT-INTLG-CUSTOM-SWMT"
        },
        {
          "key": "FotaMake",
          "value": "Sierra Wireless"
        },
        {
          "key": "FotaModel",
          "value": "EM9191"
        },
        {
          "key": "FotaProtocol",
          "value": "LWM2M"
        }
      ]
    },
    {
      "categoryName": "PrimaryPlaceOfUse",
      "extendedAttributes": [
        {
          "key": "CustomerFirstName",
          "value": "first name"
        },
        {
          "key": "CustomerLastName",
          "value": "last name"
        },
        {
          "key": "CustomerAddressLine1",
          "value": "street number and name"
        },
        {
          "key": "CustomerAddressCity",
          "value": "PLANO"
        },
        {
          "key": "CustomerAddressState",
          "value": "TX"
        },
        {
          "key": "CustomerAddressZipCode",
          "value": "75075"
        },
        {
          "key": "CustomerCountry",
          "value": "USA"
        },
        {
          "key": "CustomerPpuLatitude",
          "value": "latitude in decimal degrees"
        },
        {
          "key": "CustomerPpuLongitude",
          "value": "longitude in decimal degrees"
        }
      ]
    },
    {
      "categoryName": "SIMSECURE"
    },
    {
      "categoryName": "RTR",
      "extendedAttributes": [
        {
          "key": "RTRUnRatedDataUsage",
          "value": "0"
        }
      ]
    },
    {
      "categoryName": "PMEC",
      "extendedAttributes": [
        {
          "key": "IsPmec",
          "value": "false"
        }
      ]
    },
    {
      "categoryName": "RfAttributes",
      "extendedAttributes": [
        {
          "key": "CellID",
          "value": "cellular ID"
        },
        {
          "key": "CellIDUpdatedDate",
          "value": "2024-09-25T21:35:50Z"
        },
        {
          "key": "CellIDStreamStatus",
          "value": "ObserveInprogress"
        },
        {
          "key": "CellIDIntervalInSeconds",
          "value": "15"
        },
        {
          "key": "CellIDDurationInSeconds",
          "value": "900"
        },
        {
          "key": "NetworkBearer",
          "value": "6"
        },
        {
          "key": "NetworkBearerUpdateDate",
          "value": "2024-09-25T21:35:50Z"
        },
        {
          "key": "NetworkBearerStreamStatus",
          "value": "ObserveInprogress"
        },
        {
          "key": "NetworkBearerIntervalInSeconds",
          "value": "15"
        },
        {
          "key": "NetworkBearerDurationInSeconds",
          "value": "900"
        },
        {
          "key": "RadioSignalStrength",
          "value": "-59"
        },
        {
          "key": "RadioSignalStrengthUpdatedDate",
          "value": "2024-09-25T21:35:50Z"
        },
        {
          "key": "RadioSignalStrengthStreamStatus",
          "value": "ObserveDurationExpired"
        },
        {
          "key": "RadioSignalStrengthIntervalInSeconds",
          "value": "15"
        },
        {
          "key": "RadioSignalStrengthDurationInSeconds",
          "value": "3600"
        },
        {
          "key": "LinkQuality",
          "value": "-11"
        },
        {
          "key": "LinkQualityUpdatedDate",
          "value": "2024-09-25T21:35:50Z"
        },
        {
          "key": "LinkQualityStreamStatus",
          "value": "ObserveInprogress"
        },
        {
          "key": "LinkQualityIntervalInSeconds",
          "value": "15"
        },
        {
          "key": "LinkQualityDurationInSeconds",
          "value": "3600"
        }
      ]
    },
    {
      "categoryName": "Battery",
      "extendedAttributes": [
        {
          "key": "BatteryLevel",
          "value": "0"
        }
      ]
    },
    {
      "categoryName": "Restart",
      "extendedAttributes": [
        {
          "key": "DeviceRebootStatus",
          "value": "REBOOT_QUEUED"
        },
        {
          "key": "DeviceRebootStatusDate",
          "value": "2024-05-07T14:21:59Z"
        },
        {
          "key": "DeviceRebootStatusErrorCode",
          "value": "DEVICE_UNREACHABLE"
        },
        {
          "key": "DeviceRebootStatusErrorDescription",
          "value": "Device not reachable, request will send to device once it become available"
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


# List Devices Provisioning History

Returns the provisioning history of a specified device during a specified time period.

```csharp
ListDevicesProvisioningHistoryAsync(
    Models.DeviceProvisioningHistoryListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProvisioningHistoryListRequest`](../../doc/models/device-provisioning-history-list-request.md) | Body, Required | Query to obtain device provisioning history. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DeviceProvisioningHistoryListResult>](../../doc/models/device-provisioning-history-list-result.md).

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
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# List Current Devices PRL Version

4G and GSM devices do not have a PRL.

```csharp
ListCurrentDevicesPRLVersionAsync(
    Models.DevicePrlListRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DevicePrlListRequest`](../../doc/models/device-prl-list-request.md) | Body, Required | Request to query device PRL. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
DevicePrlListRequest body = new DevicePrlListRequest
{
    DeviceIds = new List<DeviceId>
    {
        new DeviceId
        {
            Id = "A10085E5003861",
            Kind = "meid",
        },
        new DeviceId
        {
            Id = "A10085E5003186",
            Kind = "meid",
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.ListCurrentDevicesPRLVersionAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Get Device Service Suspension Status

Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.

```csharp
GetDeviceServiceSuspensionStatusAsync(
    Models.DeviceSuspensionStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceSuspensionStatusRequest`](../../doc/models/device-suspension-status-request.md) | Body, Required | Request to obtain service suspenstion status for a device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
DeviceSuspensionStatusRequest body = new DeviceSuspensionStatusRequest
{
    DeviceIds = new List<DeviceId>
    {
        new DeviceId
        {
            Id = "A10085E5003861",
            Kind = "meid",
        },
        new DeviceId
        {
            Id = "A10085E5003186",
            Kind = "meid",
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.GetDeviceServiceSuspensionStatusAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`DeviceUsageListRequest`](../../doc/models/device-usage-list-request.md) | Body, Required | Request to obtain usage history for a specific device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceUsageListResult](../../doc/models/device-usage-list-result.md).

## Example Usage

```csharp
DeviceUsageListRequest body = new DeviceUsageListRequest
{
    Earliest = "2018-03-20T00:00:01Z",
    Latest = "2020-12-31T00:00:01Z",
    DeviceId = new DeviceId
    {
        Id = "50684915885088839315521399821675",
        Kind = "eid",
    },
};

try
{
    ApiResponse<DeviceUsageListResult> result = await deviceManagementController.ListDevicesUsageHistoryAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`DeviceAggregateUsageListRequest`](../../doc/models/device-aggregate-usage-list-request.md) | Body, Required | A request to retrieve aggregated device usage history information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
DeviceAggregateUsageListRequest body = new DeviceAggregateUsageListRequest
{
    StartTime = "2021-08-01T00:00:00-06:00",
    EndTime = "2021-08-30T00:00:00-06:00",
    DeviceIds = new List<DeviceId>
    {
        new DeviceId
        {
            Id = "84258000000891490087",
            Kind = "ICCID",
        },
    },
    AccountName = "9992330389-00001",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.RetrieveAggregateDeviceUsageHistoryAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `body` | [`ChangeDeviceIdRequest`](../../doc/models/change-device-id-request.md) | Body, Required | Request to update device id. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
string serviceType = "serviceType6";
ChangeDeviceIdRequest body = new ChangeDeviceIdRequest
{
    DeviceIds = new List<DeviceId>
    {
        new DeviceId
        {
            Id = "42590078891480000008",
            Kind = "iccid",
        },
    },
    Change4gOption = "ChangeICCID",
    DeviceIdsTo = new List<DeviceId>
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
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UpdateDeviceIdAsync(
        serviceType,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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

Upload a device record

```csharp
DeviceUploadAsync(
    Models.DeviceUploadRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceUploadRequest`](../../doc/models/device-upload-request.md) | Body, Required | Device Upload Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```csharp
DeviceUploadRequest body = new DeviceUploadRequest
{
    AccountName = "1223334444-00001",
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "15-digit IMEI",
                    Kind = "IMEI",
                },
            },
        },
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "15-digit IMEI",
                    Kind = "IMEI",
                },
            },
        },
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "15-digit IMEI",
                    Kind = "IMEI",
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
    Console.WriteLine(e.Message);
    if (e is RestErrorResponseException)
    {
       // TODO: Handle RestErrorResponseException exception here
    }
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
| `body` | [`BilledusageListRequest`](../../doc/models/billedusage-list-request.md) | Body, Required | Request to list devices with mismatched IMEIs and ICCIDs. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
BilledusageListRequest body = new BilledusageListRequest
{
    AccountName = "0342077109-00001",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.BilledUsageInfoAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Usage Segmentation Label Association

Allows you to associate your own usage segmentation label with a device.

```csharp
UsageSegmentationLabelAssociationAsync(
    Models.AssociateLabelRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AssociateLabelRequest`](../../doc/models/associate-label-request.md) | Body, Required | Request to associate a label to a device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
AssociateLabelRequest body = new AssociateLabelRequest
{
    AccountName = "1223334444-00001",
    Labels = new AccountLabels
    {
        Devices = new List<DeviceList>
        {
            new DeviceList
            {
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UsageSegmentationLabelAssociationAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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
| `labelList` | [`LabelsList`](../../doc/models/labels-list.md) | Query, Required | A list of the Label IDs to remove from the exclusion list. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
LabelsList labelList = new LabelsList
{
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UsageSegmentationLabelDeletionAsync(
        accountName,
        labelList
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Upload Activate Device

Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.

```csharp
UploadActivateDeviceAsync(
    Models.UploadsActivatesDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UploadsActivatesDeviceRequest`](../../doc/models/uploads-activates-device-request.md) | Body, Required | Request to Upload and Activate device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

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
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
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
    },
    CarrierIpPoolName = "",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.UploadActivateDeviceAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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


# Device Upload Status

Checks the status of an activation order and lists where the order is in the provisioning process.

```csharp
DeviceUploadStatusAsync(
    Models.CheckOrderStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CheckOrderStatusRequest`](../../doc/models/check-order-status-request.md) | Body, Required | The request body identifies the device and reporting period that you want included in the report. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
CheckOrderStatusRequest body = new CheckOrderStatusRequest
{
    AccountName = "4Gpublicaccount ",
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "20112019672551234613",
                    Kind = "iccid",
                },
            },
        },
    },
    OrderRequestId = " f55fea16-3664-4a32-ae9d-c0cbe3eedf1d ",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceManagementController.DeviceUploadStatusAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ConnectivityManagementResultException)
    {
       // TODO: Handle ConnectivityManagementResultException exception here
    }
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

