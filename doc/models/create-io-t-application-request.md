
# Create Io T Application Request

The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.

## Structure

`CreateIoTApplicationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AppName` | `string` | Optional | A user defined name for the application being deployed in Azure IoT Central. |
| `BillingAccountID` | `string` | Optional | The ThingSpace ID of the authenticating billing account |
| `ClientID` | `string` | Optional | The Azure ClientID of the associated Azure target account |
| `ClientSecret` | `string` | Optional | The Azure Client Secret of the associated Azure target account |
| `EmailIDs` | `string` | Optional | The “email IDs” to be added to/sent to with this API. |
| `Resourcegroup` | `string` | Optional | The Azure Resource group of the associated Azure target account |
| `SampleIOTcApp` | `string` | Optional | This is the reference Azure IoT Central application developed by Verizon. |
| `SubscriptionID` | `string` | Optional | The Azure Subscription ID of the associated Azure target account |
| `TenantID` | `string` | Optional | The Azure Tenant ID of the associated Azure target account |

## Example (as JSON)

```json
{
  "appName": "newarmapp1",
  "billingAccountID": "0000123456-00001",
  "clientID": "UUID",
  "clientSecret": "client secret",
  "emailIDs": "email@domain.com",
  "resourcegroup": "Myresourcegroup",
  "sampleIOTcApp": "app ID",
  "subscriptionID": "subscription ID",
  "tenantID": "tenant ID"
}
```

