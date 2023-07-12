# Targets

```csharp
TargetsController targetsController = client.TargetsController;
```

## Class Name

`TargetsController`

## Methods

* [Query Target](../../doc/controllers/targets.md#query-target)
* [Delete Target](../../doc/controllers/targets.md#delete-target)
* [Create Target](../../doc/controllers/targets.md#create-target)
* [Generate Target External ID](../../doc/controllers/targets.md#generate-target-external-id)
* [Create Azure Central Io T Application](../../doc/controllers/targets.md#create-azure-central-io-t-application)


# Query Target

Search for targets by property values. Returns an array of all matching target resources.

```csharp
QueryTargetAsync(
    Models.QueryTargetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.QueryTargetRequest`](../../doc/models/query-target-request.md) | Body, Required | Search for targets by property values. |

## Response Type

[`Task<ApiResponse<List<Models.Target>>>`](../../doc/models/target.md)

## Example Usage

```csharp
QueryTargetRequest body = new QueryTargetRequest
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
    ApiResponse<List<Target>> result = await targetsController.QueryTargetAsync(body);
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
    "address": "https://myhost.com:1825",
    "addressscheme": "streamrest",
    "createdon": "2018-12-22T03:59:18.563Z",
    "id": "cee10900-f54e-6eef-e455-bd7f15c4be32",
    "kind": "ts.target",
    "lastupdated": "2018-12-22T03:59:18.563Z",
    "name": "host:port target",
    "version": "1.0",
    "versionid": "f4be7c2b-059d-11e9-bec6-02420a4e1b0a"
  },
  {
    "address": "arn:aws:iam::252156542789:role/ThingSpace",
    "addressscheme": "streamawsiot",
    "createdon": "2019-01-24T19:06:43.577Z",
    "externalid": "lJZnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
    "id": "cea170cc-a58f-6531-fc4b-fae1ceb1a6c8",
    "kind": "ts.target",
    "lastupdated": "2019-01-24T19:32:31.841Z",
    "name": "AWS Target",
    "region": "us-east-1",
    "version": "1.0",
    "versionid": "caf85ff7-200e-11e9-a85b-02420a621e0a"
  }
]
```


# Delete Target

Remove a target from a ThingSpace account.

```csharp
DeleteTargetAsync(
    Models.DeleteTargetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeleteTargetRequest`](../../doc/models/delete-target-request.md) | Body, Required | The request body identifies the target to delete. |

## Response Type

`Task`

## Example Usage

```csharp
DeleteTargetRequest body = new DeleteTargetRequest
{
    Accountidentifier = new AccountIdentifier
    {
        Billingaccountid = "0000000000-00001",
    },
    Resourceidentifier = new ResourceIdentifier
    {
        Id = "2e61a17d-8fd1-6816-e995-e4c2528bf535",
    },
};

try
{
    await targetsController.DeleteTargetAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Target

Define a target to receive data streams, alerts, or callbacks. After creating the target resource, use its ID in a subscription to set up a data stream.

```csharp
CreateTargetAsync(
    Models.CreateTargetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CreateTargetRequest`](../../doc/models/create-target-request.md) | Body, Required | The request body provides the details of the target that you want to create. |

## Response Type

[`Task<ApiResponse<Models.Target>>`](../../doc/models/target.md)

## Example Usage

```csharp
CreateTargetRequest body = new CreateTargetRequest
{
    Accountidentifier = new AccountIdentifier
    {
        Billingaccountid = "0000000000-00001",
    },
    Billingaccountid = "0000000000-00001",
    Kind = "ts.target",
    Address = "https://your_IoT_Central_Application.azureiotcentral.com",
    Addressscheme = "streamazureiot",
    Fields = new CreateTargetRequestFields
    {
        Httpheaders = new FieldsHttpHeaders
        {
            Authorization = "SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410",
        },
        Devicetypes = new List<string>
        {
            "cHeAssetTracker",
            "cHeAssetTrackerV2",
            "tgAssetTracker",
            "tgAssetTrackerV2",
        },
    },
};

try
{
    ApiResponse<Target> result = await targetsController.CreateTargetAsync(body);
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
  "address": "arn:aws:iam::252156542978:role/ThingSpace",
  "addressscheme": "streamawsiot",
  "billingaccountid": "1223334444-00001",
  "createdon": "2018-12-21T04:37:42.651Z",
  "externalid": "lJZnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
  "id": "0e411230-c3eb-64dc-f5f4-1020364aa81f",
  "kind": "ts.target",
  "lastupdated": "2018-12-21T04:37:42.651Z",
  "name": "AWS Target",
  "region": "us-east-1",
  "version": "1.0",
  "versionid": "27aca5a4-04da-11e9-bff3-02420a5e1b0b"
}
```


# Generate Target External ID

Create a unique string that ThingSpace will pass to AWS for increased security.

:information_source: **Note** This endpoint does not require authentication.

```csharp
GenerateTargetExternalIDAsync(
    Models.GenerateExternalIDRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.GenerateExternalIDRequest`](../../doc/models/generate-external-id-request.md) | Body, Required | The request body only contains the authenticating account. |

## Response Type

[`Task<ApiResponse<Models.GenerateExternalIDResult>>`](../../doc/models/generate-external-id-result.md)

## Example Usage

```csharp
GenerateExternalIDRequest body = new GenerateExternalIDRequest
{
    Accountidentifier = new AccountIdentifier
    {
        Billingaccountid = "0000000000-00001",
    },
};

try
{
    ApiResponse<GenerateExternalIDResult> result = await targetsController.GenerateTargetExternalIDAsync(body);
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
  "externalid": "ZlJnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH=="
}
```


# Create Azure Central Io T Application

Deploy a new Azure IoT Central application based on the Verizon ARM template within the specified Azure Active Directory account.

```csharp
CreateAzureCentralIoTApplicationAsync(
    string billingaccountID,
    Models.CreateIoTApplicationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `billingaccountID` | `string` | Header, Required | TThe ThingSpace ID of the authenticating billing account. |
| `body` | [`Models.CreateIoTApplicationRequest`](../../doc/models/create-io-t-application-request.md) | Body, Required | The request body must include the UUID of the subscription that you want to update plus any properties that you want to change. |

## Response Type

[`Task<ApiResponse<Models.CreateIoTApplicationResponse>>`](../../doc/models/create-io-t-application-response.md)

## Example Usage

```csharp
string billingaccountID = "BillingaccountID2";
CreateIoTApplicationRequest body = new CreateIoTApplicationRequest
{
    AppName = "newarmapp1",
    BillingAccountID = "0000123456-00001",
    ClientID = "UUID",
    ClientSecret = "client secret",
    EmailIDs = "email@domain.com",
    Resourcegroup = "Myresourcegroup",
    SampleIOTcApp = "{app ID}",
    SubscriptionID = "{subscription ID}",
    TenantID = "{tenant ID}",
};

try
{
    ApiResponse<CreateIoTApplicationResponse> result = await targetsController.CreateAzureCentralIoTApplicationAsync(billingaccountID, body);
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
  "appName": "newarmapp1",
  "sharedSecret": "SharedAccessSignaturesr={client secret}",
  "url": "https://newarmapp1.azureiotcentral.com"
}
```

