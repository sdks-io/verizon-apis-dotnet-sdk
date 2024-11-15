# Exclusions

Excluding or including devices (by consent) for location service

```csharp
ExclusionsController exclusionsController = client.ExclusionsController;
```

## Class Name

`ExclusionsController`


# Devices Location Give Consent Async

Create a consent record to use location services as an asynchronous request.

```csharp
DevicesLocationGiveConsentAsyncAsync(
    Models.AccountConsentCreate body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AccountConsentCreate`](../../doc/models/account-consent-create.md) | Body, Optional | Account details to create a consent record. |

## Response Type

[`Task<Models.ConsentTransactionID>`](../../doc/models/consent-transaction-id.md)

## Example Usage

```csharp
try
{
    ConsentTransactionID result = await exclusionsController.DevicesLocationGiveConsentAsyncAsync();
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
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

