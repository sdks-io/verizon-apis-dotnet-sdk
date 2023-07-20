# Billing

```csharp
BillingController billingController = client.BillingController;
```

## Class Name

`BillingController`

## Methods

* [List Managed Account](../../doc/controllers/billing.md#list-managed-account)
* [Managed Account Action](../../doc/controllers/billing.md#managed-account-action)
* [Cancel Managed Account Action](../../doc/controllers/billing.md#cancel-managed-account-action)
* [Add Account](../../doc/controllers/billing.md#add-account)


# List Managed Account

This endpoint allows user to retrieve the list of all accounts managed by a primary account.

```csharp
ListManagedAccountAsync(
    string accountName,
    string serviceName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Primary account identifier |
| `serviceName` | `string` | Template, Required | Service name |

## Response Type

[`Task<ApiResponse<Models.ManagedAccountsGetAllResponse>>`](../../doc/models/managed-accounts-get-all-response.md)

## Example Usage

```csharp
string accountName = "1223334444-00001";
string serviceName = "serviceName8";
try
{
    ApiResponse<ManagedAccountsGetAllResponse> result = await billingController.ListManagedAccountAsync(accountName, serviceName);
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
  "accountName": "2024009649-00001",
  "ManagedAccAddedList": [
    {
      "id": "1223334444-00001",
      "txid": "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33"
    },
    {
      "id": "2334445555-00001",
      "txid": "d4fbff33-ece4-9f02-42ef-2c90bd287e3b"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Managed Account Action

Activates a managed billing service relationship between a managed account and the primary account.

```csharp
ManagedAccountActionAsync(
    Models.ManagedAccountsProvisionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ManagedAccountsProvisionRequest`](../../doc/models/managed-accounts-provision-request.md) | Body, Required | Service name and list of accounts to add |

## Response Type

[`Task<ApiResponse<Models.ManagedAccountsProvisionResponse>>`](../../doc/models/managed-accounts-provision-response.md)

## Example Usage

```csharp
ManagedAccountsProvisionRequest body = new ManagedAccountsProvisionRequest
{
    AccountName = "1223334444-00001",
    PaccountName = "1234567890-00001",
    ServiceName = ServiceNameEnum.Location,
    Type = "TS-LOC-COARSE-CellID-5K",
    Txid = "d4fbff33-ece4-9f02-42ef-2c90bd287e3b",
};

try
{
    ApiResponse<ManagedAccountsProvisionResponse> result = await billingController.ManagedAccountActionAsync(body);
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
  "txid": "4fbff332-ece4-42ef-9f02-7e3bdc90bd28",
  "accountName": "1223334444-00001",
  "paccountName": "1234567890-00001",
  "serviceName": "Location",
  "status": "Success",
  "reason": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Cancel Managed Account Action

Deactivates a managed billing service relationship between a managed account and the primary account.

```csharp
CancelManagedAccountActionAsync(
    Models.ManagedAccountCancelRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ManagedAccountCancelRequest`](../../doc/models/managed-account-cancel-request.md) | Body, Required | Service name and list of accounts to add |

## Response Type

[`Task<ApiResponse<Models.ManagedAccountCancelResponse>>`](../../doc/models/managed-account-cancel-response.md)

## Example Usage

```csharp
ManagedAccountCancelRequest body = new ManagedAccountCancelRequest
{
    AccountName = "1223334444-00001",
    PaccountName = "1234567890-00001",
    ServiceName = ServiceNameEnum.Location,
    Type = "TS-LOC-COARSE-CellID-5K",
    Txid = "d4fbff33-ece4-9f02-42ef-2c90bd287e3b",
};

try
{
    ApiResponse<ManagedAccountCancelResponse> result = await billingController.CancelManagedAccountActionAsync(body);
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
  "txid": "4fbff332-ece4-42ef-9f02-7e3bdc90bd28",
  "accountName": "1223334444-00001",
  "paccountName": "1234567890-00001",
  "serviceName": "Location",
  "status": "Success",
  "reason": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Add Account

This endpoint allows user to add managed accounts to a primary account.

```csharp
AddAccountAsync(
    Models.ManagedAccountsAddRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ManagedAccountsAddRequest`](../../doc/models/managed-accounts-add-request.md) | Body, Required | Service name and list of accounts to add |

## Response Type

[`Task<ApiResponse<Models.ManagedAccountsAddResponse>>`](../../doc/models/managed-accounts-add-response.md)

## Example Usage

```csharp
ManagedAccountsAddRequest body = new ManagedAccountsAddRequest
{
    AccountName = "1234567890-00001",
    ServiceName = ServiceNameEnum.Location,
    Type = "TS-LOC-COARSE-CellID-Aggr",
    ManagedAccList = new List<string>
    {
        "1223334444-00001",
        "2334445555-00001",
        "3445556666-00001",
    },
};

try
{
    ApiResponse<ManagedAccountsAddResponse> result = await billingController.AddAccountAsync(body);
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
  "txid": "2c90bd28-ece4-42ef-9f02-7e3bd4fbff33",
  "statusList": [
    {
      "id": "1223334444-00001",
      "status": "Success",
      "reason": "Success"
    },
    {
      "id": "2334445555-00001",
      "status": "Success",
      "reason": "Success"
    },
    {
      "id": "3445556666-00001",
      "status": "Success",
      "reason": "Success"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

