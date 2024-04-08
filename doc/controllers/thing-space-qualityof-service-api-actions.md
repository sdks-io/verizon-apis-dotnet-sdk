# Thing Space Qualityof Service API Actions

```csharp
ThingSpaceQualityofServiceAPIActionsController thingSpaceQualityofServiceAPIActionsController = client.ThingSpaceQualityofServiceAPIActionsController;
```

## Class Name

`ThingSpaceQualityofServiceAPIActionsController`

## Methods

* [Create a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#create-a-thing-space-quality-of-service-api-subscription)
* [Stop a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#stop-a-thing-space-quality-of-service-api-subscription)


# Create a Thing Space Quality of Service API Subscription

Creates a QoS elevation subscription ID and activates the subscription.

```csharp
CreateAThingSpaceQualityOfServiceAPISubscriptionAsync(
    Models.SubscribeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SubscribeRequest`](../../doc/models/subscribe-request.md) | Body, Required | The request details to create a ThingSpace Quality of Service API subscription. |

## Response Type

[`Task<ApiResponse<Models.M201success>>`](../../doc/models/m201-success.md)

## Example Usage

```csharp
SubscribeRequest body = new SubscribeRequest
{
    AccountName = "0000123456-00001",
    DeviceInfo = new List<Models.QosDeviceInfo>
    {
        new QosDeviceInfo
        {
            DeviceId = new QosDeviceId
            {
                Id = "10-digit phone number",
                Kind = "mdn",
            },
            FlowInfo = new List<Models.FlowInfo>
            {
                new FlowInfo
                {
                    FlowServer = "[IPv6 address]:port",
                    FlowDevice = "[IPv6 address]:port",
                    FlowDirection = "UPLINK",
                    FlowProtocol = "UDP",
                    QciOption = "Premium",
                },
            },
            DeviceIPv6Addr = "IPv6 address",
        },
    },
};

try
{
    ApiResponse<M201success> result = await thingSpaceQualityOfServiceAPIActionsController.CreateAThingSpaceQualityOfServiceAPISubscriptionAsync(body);
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
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |


# Stop a Thing Space Quality of Service API Subscription

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

```csharp
StopAThingSpaceQualityOfServiceAPISubscriptionAsync(
    string accountName,
    string qosSubscriptionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | - |
| `qosSubscriptionId` | `string` | Query, Required | - |

## Response Type

[`Task<ApiResponse<Models.M201success>>`](../../doc/models/m201-success.md)

## Example Usage

```csharp
string accountName = "0000123456-00001";
string qosSubscriptionId = "QoS subscription ID";
try
{
    ApiResponse<M201success> result = await thingSpaceQualityOfServiceAPIActionsController.StopAThingSpaceQualityOfServiceAPISubscriptionAsync(
        accountName,
        qosSubscriptionId
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
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |

