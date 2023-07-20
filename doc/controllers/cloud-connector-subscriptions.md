# Cloud Connector Subscriptions

```csharp
CloudConnectorSubscriptionsController cloudConnectorSubscriptionsController = client.CloudConnectorSubscriptionsController;
```

## Class Name

`CloudConnectorSubscriptionsController`

## Methods

* [Query Subscription](../../doc/controllers/cloud-connector-subscriptions.md#query-subscription)
* [Delete Subscription](../../doc/controllers/cloud-connector-subscriptions.md#delete-subscription)
* [Create Subscription](../../doc/controllers/cloud-connector-subscriptions.md#create-subscription)


# Query Subscription

Search for subscriptions by property values. Returns an array of all matching subscription resources.

```csharp
QuerySubscriptionAsync(
    Models.QuerySubscriptionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.QuerySubscriptionRequest`](../../doc/models/query-subscription-request.md) | Body, Required | The request body specifies fields and values to match. |

## Response Type

[`Task<ApiResponse<List<Models.Subscription>>>`](../../doc/models/subscription.md)

## Example Usage

```csharp
QuerySubscriptionRequest body = new QuerySubscriptionRequest
{
    Accountidentifier = new AccountIdentifier
    {
        Billingaccountid = "1223334444-00001",
    },
    Resourceidentifier = new ResourceIdentifier
    {
        Id = "dd1682d3-2d80-cefc-f3ee-25154800beff",
    },
};

try
{
    ApiResponse<List<Subscription>> result = await cloudConnectorSubscriptionsController.QuerySubscriptionAsync(body);
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
    "configurationfailures": 0,
    "createdon": "2019-02-13T23:13:24.689Z",
    "delegateid": "00000000-0000-0000-0000-000000000000",
    "disabled": false,
    "email": "me@mycompany.com",
    "id": "98015aed-e984-62be-f049-1d895d2d1812",
    "kind": "ts.subscription",
    "laststreamingstatus": "success",
    "laststreamingtime": "2019-02-20T18:20:45.865Z",
    "lastupdated": "2019-02-13T23:13:24.689Z",
    "networkfailures": 0,
    "streamfailures": 0,
    "streamkind": "ts.event",
    "targetid": "4e112cb3-da1d-6ece-f2c6-bb8700b20b09",
    "targettype": "Amazon Web Services",
    "version": "1.0",
    "versionid": "f68b8862-2fe4-11e9-85fd-02420a4c170d"
  }
]
```


# Delete Subscription

Remove a subscription from a ThingSpace account.

```csharp
DeleteSubscriptionAsync(
    Models.DeleteSubscriptionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeleteSubscriptionRequest`](../../doc/models/delete-subscription-request.md) | Body, Required | The request body identifies the subscription to delete. |

## Response Type

`Task`

## Example Usage

```csharp
DeleteSubscriptionRequest body = new DeleteSubscriptionRequest
{
    Accountidentifier = new AccountIdentifier
    {
        Billingaccountid = "1223334444-00001",
    },
    Resourceidentifier = new ResourceIdentifier
    {
        Id = "f8b112df-739c-6236-f059-106c67bafd99",
    },
};

try
{
    await cloudConnectorSubscriptionsController.DeleteSubscriptionAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Subscription

Create a subscription to define a streaming channel that sends data from devices in the account to an endpoint defined in a target resource.

```csharp
CreateSubscriptionAsync(
    Models.CreateSubscriptionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CreateSubscriptionRequest`](../../doc/models/create-subscription-request.md) | Body, Required | The request body provides the details of the subscription that you want to create. |

## Response Type

[`Task<ApiResponse<Models.Subscription>>`](../../doc/models/subscription.md)

## Example Usage

```csharp
CreateSubscriptionRequest body = new CreateSubscriptionRequest
{
    Accountidentifier = new AccountIdentifier
    {
        Billingaccountid = "1223334444-00001",
    },
    Email = "me@mycompany.com",
    Billingaccountid = "1223334444-00001",
    Streamkind = "ts.event",
    Targetid = "{target ID}",
    Name = "Account subscription 1",
    Allowaggregation = false,
};

try
{
    ApiResponse<Subscription> result = await cloudConnectorSubscriptionsController.CreateSubscriptionAsync(body);
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
  "configurationfailures": 0,
  "createdon": "2018-12-21T05:05:02.134Z",
  "delegateid": "00000000-0000-0000-0000-000000000000",
  "id": "d8c145dd-6948-67ec-ed9b-6a298806bb4a",
  "kind": "ts.subscription",
  "laststreamingstatus": "",
  "laststreamingtime": "0001-01-01T00:00:00Z",
  "lastupdated": "2018-12-21T05:22:12.178Z",
  "networkfailures": 0,
  "streamfailures": 0,
  "streamkind": "ts.event",
  "targetid": "4e211a0e-e39d-6c32-e15b-d6f07f9e2ec8",
  "version": "1.0",
  "versionid": "5ed6063f-04e0-11e9-8279-02420a5e1b0b"
}
```

