# SMS

Exchange Short Message Service (SMS) messages with devices.

```csharp
SMSController sMSController = client.SMSController;
```

## Class Name

`SMSController`

## Methods

* [Send SMS to Device](../../doc/controllers/sms.md#send-sms-to-device)
* [List Devices SMS Messages](../../doc/controllers/sms.md#list-devices-sms-messages)
* [Start Queued SMS Delivery](../../doc/controllers/sms.md#start-queued-sms-delivery)


# Send SMS to Device

The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

```csharp
SendSMSToDeviceAsync(
    Models.SMSSendRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SMSSendRequest`](../../doc/models/sms-send-request.md) | Body, Required | Request to send SMS. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
SMSSendRequest body = new SMSSendRequest
{
    AccountName = "0000123456-00001",
    SmsMessage = "the body or text of the message itself",
    CustomFields = new List<CustomFields>
    {
        new CustomFields
        {
            Key = "CustomField1",
            MValue = "value of the field",
        },
    },
    DataEncoding = "optional 7 or 8-bit encoding",
    DeviceIds = new List<DeviceId>
    {
        new DeviceId
        {
            Id = "20-digit ICCID",
            Kind = "iccid",
        },
    },
    TimeToLive = "a000000010000000R",
};

try
{
    ApiResponse<DeviceManagementResult> result = await sMSController.SendSMSToDeviceAsync(body);
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


# List Devices SMS Messages

When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.

```csharp
ListDevicesSMSMessagesAsync(
    string aname,
    long? next = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `next` | `long?` | Query, Optional | Continue the previous query from the URL in Location Header. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SMSMessagesQueryResult](../../doc/models/sms-messages-query-result.md).

## Example Usage

```csharp
string aname = "0252012345-00001";
try
{
    ApiResponse<SMSMessagesQueryResult> result = await sMSController.ListDevicesSMSMessagesAsync(aname);
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
  "messages": [
    {
      "deviceIds": [
        {
          "id": "09623489171",
          "kind": "esn"
        }
      ],
      "message": "testmessage1",
      "timestamp": "2016-01-01T12:29:49-08:00"
    },
    {
      "deviceIds": [
        {
          "id": "09623489171",
          "kind": "esn"
        }
      ],
      "message": "testmessage2",
      "timestamp": "2016-01-01T12:31:02-08:00"
    }
  ],
  "hasMoreData": false
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Start Queued SMS Delivery

Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.

```csharp
StartQueuedSMSDeliveryAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ConnectivityManagementSuccessResult](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```csharp
string aname = "0252012345-00001";
try
{
    ApiResponse<ConnectivityManagementSuccessResult> result = await sMSController.StartQueuedSMSDeliveryAsync(aname);
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

