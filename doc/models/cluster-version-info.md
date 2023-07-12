
# Cluster Version Info

## Structure

`ClusterVersionInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClusterId` | `string` | Optional | - |
| `KubeVersion` | `string` | Optional | - |
| `OrganizationId` | `string` | Optional | - |
| `PartnerId` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `ModifiedAt` | `string` | Optional | - |
| `Id` | `string` | Optional | - |
| `BehindLatestBy` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |

## Example (as JSON)

```json
{
  "cluster_id": "cluster_id4",
  "kube_version": "kube_version4",
  "organization_id": "organization_id0",
  "partner_id": "partner_id2",
  "created_at": "created_at2"
}
```

