
# Create Target Request

Details of the target that you want to create.

## Structure

`CreateTargetRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountidentifier` | [`Models.AccountIdentifier`](../../doc/models/account-identifier.md) | Optional | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. |
| `Billingaccountid` | `string` | Optional | The ID of the authenticating billing account. |
| `Kind` | `string` | Optional | Identifies the resource kind. Targets are ts.target. |
| `Address` | `string` | Optional | The endpoint for notifications or data streams. The format depends on the selected `addressscheme`.<br />`streamrest` requires a `host:port` value <br />`streamawsiot` requres a valid ARN. |
| `Addressscheme` | `string` | Optional | The transport format. Valid values are: <br />streamawsiot - streamed data to an AWS account <br />streamrest - streamed REST data to a defined endpoint. |
| `Fields` | [`Models.CreateTargetRequestFields`](../../doc/models/create-target-request-fields.md) | Optional | - |
| `Description` | `string` | Optional | Descriptive information about the target. |
| `Externalid` | `string` | Optional | Security identification string created by a POST /targets/actions/newextid request. |
| `Name` | `string` | Optional | Name of the target. |
| `Region` | `string` | Optional | AWS region value. |
| `Key1` | `string` | Optional | OAuth 2.0 bearer token. |
| `Oauth` | [`Models.TargetAuthentication`](../../doc/models/target-authentication.md) | Optional | OAuth 2 token and refresh token for TS to stream events to Target. |

## Example (as JSON)

```json
{
  "accountidentifier": {
    "billingaccountid": "0000000000-00001"
  },
  "billingaccountid": "0000000000-00001",
  "kind": "ts.target",
  "address": "https://your_IoT_Central_Application.azureiotcentral.com",
  "addressscheme": "streamazureiot",
  "fields": {
    "httpheaders": {
      "Authorization": "SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410"
    },
    "devicetypes": [
      "cHeAssetTracker",
      "cHeAssetTrackerV2",
      "tgAssetTracker",
      "tgAssetTrackerV2"
    ]
  }
}
```

