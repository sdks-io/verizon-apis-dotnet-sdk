
# Advance Configuration

## Structure

`AdvanceConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceRoleArn` | `string` | Optional | - |
| `ServiceRolePermissionBoundary` | `string` | Optional | - |
| `EnableProxy` | `bool?` | Optional | **Default**: `false` |
| `HttpProxy` | `string` | Optional | - |
| `HttpsProxy` | `string` | Optional | - |
| `NoProxy` | `string` | Optional | - |
| `ProxyRootCA` | `string` | Optional | - |
| `EnableTlsTraffic` | `bool?` | Optional | **Default**: `false` |
| `EnableAutoApprove` | `bool?` | Optional | **Default**: `false` |
| `EnableMultiMaster` | `bool?` | Optional | **Default**: `false` |
| `EnableDedicatedMaster` | `bool?` | Optional | **Default**: `false` |

## Example (as JSON)

```json
{
  "enableProxy": false,
  "enableTlsTraffic": false,
  "enableAutoApprove": false,
  "enableMultiMaster": false,
  "enableDedicatedMaster": false,
  "serviceRoleArn": "serviceRoleArn4",
  "serviceRolePermissionBoundary": "serviceRolePermissionBoundary2",
  "httpProxy": "httpProxy8",
  "httpsProxy": "httpsProxy8"
}
```

