
# Cluster Provisioning

## Structure

`ClusterProvisioning`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Provider` | [`Models.ClusterProviderEnum?`](../../doc/models/cluster-provider-enum.md) | Optional | Cloud provider. |
| `AccessKey` | [`Models.AccessKey`](../../doc/models/access-key.md) | Optional | - |
| `Role` | [`Models.Role`](../../doc/models/role.md) | Optional | Role of the user calling API. |

## Example (as JSON)

```json
{
  "provider": "AWS",
  "accessKey": {
    "accessId": "accessId6",
    "secretKey": "secretKey6",
    "sessionToken": "sessionToken8"
  },
  "role": {
    "accountId": "accountId6",
    "externalId": "externalId2",
    "roleARN": "roleARN8"
  }
}
```

