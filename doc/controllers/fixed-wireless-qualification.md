# Fixed Wireless Qualification

```csharp
FixedWirelessQualificationController fixedWirelessQualificationController = client.FixedWirelessQualificationController;
```

## Class Name

`FixedWirelessQualificationController`


# Domestic 4 G and 5G Fixed Wireless Qualification

Use this query for Fixed Wireless Qualification of an address. Network types include: LTE, C-BAND and MMWAVE.

```csharp
Domestic4GAnd5gFixedWirelessQualificationAsync(
    Models.GetWirelessCoverageRequestFWA body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetWirelessCoverageRequestFWA`](../../doc/models/get-wireless-coverage-request-fwa.md) | Body, Required | Request for network coverage details. |

## Response Type

[`Task<ApiResponse<Models.WNPRequestResponse>>`](../../doc/models/wnp-request-response.md)

## Example Usage

```csharp
GetWirelessCoverageRequestFWA body = new GetWirelessCoverageRequestFWA
{
    AccountName = "0000123456-00001",
    RequestType = "FWA",
    LocationType = "ADDRESS",
    Locations = new Locations
    {
        AddressList = new List<Models.AddressItem>
        {
            new AddressItem
            {
                AddressLine1 = "street address",
                City = "city",
                State = "LA",
                Country = "USA",
                Zip = "00000",
            },
        },
    },
    NetworkTypesList = new List<Models.NetworkType>
    {
        new NetworkType
        {
            NetworkTypeProp = "LTE",
        },
    },
};

try
{
    ApiResponse<WNPRequestResponse> result = await fixedWirelessQualificationController.Domestic4GAnd5gFixedWirelessQualificationAsync(body);
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
| Default | Error response | [`WNPRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |

