# 5G BI Device Actions

```csharp
M5gBIDeviceActionsController m5gBIDeviceActionsController = client.M5gBIDeviceActionsController;
```

## Class Name

`M5gBIDeviceActionsController`

## Methods

* [Business Internetlist Device Information](../../doc/controllers/5g-bi-device-actions.md#business-internetlist-device-information)
* [Business Internetactivate Using POST](../../doc/controllers/5g-bi-device-actions.md#business-internetactivate-using-post)
* [Business Internet Serviceplanchange](../../doc/controllers/5g-bi-device-actions.md#business-internet-serviceplanchange)


# Business Internetlist Device Information

Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.

```csharp
BusinessInternetlistDeviceInformationAsync(
    Models.M5gBideviceId body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5gBideviceId`](../../doc/models/5g-bidevice-id.md) | Body, Required | Device Profile Query |

## Response Type

[`Task<ApiResponse<Models.M5gBideviceDetailsresponse>>`](../../doc/models/5g-bidevice-detailsresponse.md)

## Example Usage

```csharp
M5gBideviceId body = new M5gBideviceId
{
    DeviceId = new M5gBideviceId1
    {
        Id = "20-digit ICCID",
        Kind = "iccid",
    },
};

try
{
    ApiResponse<M5gBideviceDetailsresponse> result = await m5gBIDeviceActionsController.BusinessInternetlistDeviceInformationAsync(body);
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
| Default | Error response | [`M5gBiRestErrorResponseException`](../../doc/models/5g-bi-rest-error-response-exception.md) |


# Business Internetactivate Using POST

Uses the device's ICCID and IMEI to activate service.

```csharp
BusinessInternetactivateUsingPOSTAsync(
    Models.M5gBiactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5gBiactivateRequest`](../../doc/models/5g-biactivate-request.md) | Body, Required | Activate 5G BI service. Defining <code>publicIpRestriction</code> as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  <code>publicIpRestriction</code> undefined to activate as Public Dynamic. Removing <code>publicIpRestriction</code> from the request will activate as Mobile Private Network (MPN). |

## Response Type

[`Task<ApiResponse<Models.M5gBiRequestResponse>>`](../../doc/models/5g-bi-request-response.md)

## Example Usage

```csharp
M5gBiactivateRequest body = new M5gBiactivateRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
    DeviceListWithServiceAddress = new List<DeviceListWithServiceAddress1>
    {
        new DeviceListWithServiceAddress1
        {
            DeviceId = new List<M5gBideviceId1>
            {
                new M5gBideviceId1
                {
                    Id = "15-digit IMEI",
                    Kind = "imei",
                },
                new M5gBideviceId1
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
            },
        },
        new DeviceListWithServiceAddress1
        {
            PrimaryPlaceofuse = new M5gBiprimaryPlaceofuse
            {
                Address = new M5gBiAddress
                {
                    AddressLine1 = "street number and name",
                    City = "city of address",
                    State = "2-letter state ID (conforms to ISO 3166-2)",
                    Zip = "5-digit ZIP code",
                    Zip4 = "the +4 digits used for ZIP codes",
                    Phone = "a 10-digit phone number",
                    PhoneType = "W",
                },
                CustomerName = new M5gBiCustomerName
                {
                    FirstName = "First name",
                    LastName = "Surname or Last Name",
                    MiddleName = "middle name or initial",
                    Title = "Mr. or Ms.",
                    Suffex = "Dr or Esq",
                },
            },
        },
    },
    PublicIpRestriction = "Unrestricted",
    CarrierName = "Verizon Wireless",
    MdnZipCode = "the 5-digit ZIP code of the Mobile Directory Number (MDN)",
};

try
{
    ApiResponse<M5gBiRequestResponse> result = await m5gBIDeviceActionsController.BusinessInternetactivateUsingPOSTAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`M5gBiRestErrorResponseException`](../../doc/models/5g-bi-rest-error-response-exception.md) |


# Business Internet Serviceplanchange

Change a device's service plan to use 5G BI.

```csharp
BusinessInternetServiceplanchangeAsync(
    Models.M5gBichangeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5gBichangeRequest`](../../doc/models/5g-bichange-request.md) | Body, Required | This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended. |

## Response Type

[`Task<ApiResponse<Models.M5gBiRequestResponse>>`](../../doc/models/5g-bi-request-response.md)

## Example Usage

```csharp
M5gBichangeRequest body = new M5gBichangeRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "5G BI service plan name being changed to",
    DeviceListWithServiceAddress = new List<DeviceListWithServiceAddress>
    {
        new DeviceListWithServiceAddress
        {
            DeviceId = new List<M5gBideviceId1>
            {
                new M5gBideviceId1
                {
                    Id = "15-digit IMEI",
                    Kind = "imei",
                },
            },
        },
        new DeviceListWithServiceAddress
        {
            PrimaryPlaceofuse = new M5gBiaddressAndcustomerinfo
            {
            },
        },
    },
    CurrentServicePlan = "Name of the plan being changed from",
};

try
{
    ApiResponse<M5gBiRequestResponse> result = await m5gBIDeviceActionsController.BusinessInternetServiceplanchangeAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`M5gBiRestErrorResponseException`](../../doc/models/5g-bi-rest-error-response-exception.md) |

