# Device SMS Messaging

```csharp
DeviceSMSMessagingController deviceSMSMessagingController = client.DeviceSMSMessagingController;
```

## Class Name

`DeviceSMSMessagingController`

## Methods

* [Send an Sms Message](../../doc/controllers/device-sms-messaging.md#send-an-sms-message)
* [Get Sms Messages](../../doc/controllers/device-sms-messaging.md#get-sms-messages)
* [Start Sms Message Delivery](../../doc/controllers/device-sms-messaging.md#start-sms-message-delivery)
* [List Sms Message History](../../doc/controllers/device-sms-messaging.md#list-sms-message-history)


# Send an Sms Message

Sends an SMS message to one device. Messages are queued on the M2M MC Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

```csharp
SendAnSmsMessageAsync(
    Models.GIOSMSSendRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GIOSMSSendRequest`](../../doc/models/giosms-send-request.md) | Body, Required | SMS message to an indiividual device. |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
GIOSMSSendRequest body = new GIOSMSSendRequest
{
    DeviceIds = new List<Models.GIODeviceId>
    {
        new GIODeviceId
        {
            Kind = "eid",
            Id = "12345678901234567890123456789012",
        },
    },
    SmsMessage = "A text message",
};

try
{
    ApiResponse<GIORequestResponse> result = await deviceSMSMessagingController.SendAnSmsMessageAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Get Sms Messages

Retrieves queued SMS messages sent by all M2M MC devices associated with an account.

```csharp
GetSmsMessagesAsync(
    string accountName,
    string next = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name |
| `next` | `string` | Query, Optional | Continue the previous query from the pageUrl in Location Header |

## Response Type

[`Task<ApiResponse<Models.SmsMessagesResponse>>`](../../doc/models/sms-messages-response.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
string next = "TheURLForTheNextQuery";
try
{
    ApiResponse<SmsMessagesResponse> result = await deviceSMSMessagingController.GetSmsMessagesAsync(
        accountName,
        next
    );
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Start Sms Message Delivery

Starts delivery of SMS messages for the specified account.

```csharp
StartSmsMessageDeliveryAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name |

## Response Type

[`Task<ApiResponse<Models.SuccessResponse>>`](../../doc/models/success-response.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
try
{
    ApiResponse<SuccessResponse> result = await deviceSMSMessagingController.StartSmsMessageDeliveryAsync(accountName);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# List Sms Message History

Returns a list of sms history for a given device during a specified time frame.

```csharp
ListSmsMessageHistoryAsync(
    Models.SMSEventHistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SMSEventHistoryRequest`](../../doc/models/sms-event-history-request.md) | Body, Required | Device Query |

## Response Type

[`Task<ApiResponse<Models.GIORequestResponse>>`](../../doc/models/gio-request-response.md)

## Example Usage

```csharp
SMSEventHistoryRequest body = new SMSEventHistoryRequest
{
    DeviceId = new GIODeviceId
    {
        Kind = "eid",
        Id = "12345678901234567890123456789012",
    },
};

try
{
    ApiResponse<GIORequestResponse> result = await deviceSMSMessagingController.ListSmsMessageHistoryAsync(body);
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
| Default | Error response | [`GIORestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

