
# Cluster Infra

## Structure

`ClusterInfra`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `ModifiedAt` | `string` | Optional | - |
| `OrganizationId` | `string` | Optional | - |
| `PartnerId` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `City` | `string` | Optional | - |
| `Latitude` | `string` | Optional | - |
| `Longitude` | `string` | Optional | - |
| `ClusterId` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `Cert` | `string` | Optional | - |
| `Passphrase` | `string` | Optional | - |
| `Id` | `string` | Optional | - |
| `Cname` | `string` | Optional | - |
| `Arecord` | `string` | Optional | - |
| `BaseRatio` | `double?` | Optional | - |
| `HaEnabled` | `bool?` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `UpgradeStatus` | `string` | Optional | - |
| `ProviderId` | `string` | Optional | - |
| `AutoCreate` | `bool?` | Optional | - |
| `AutoApproveNodes` | `bool?` | Optional | - |
| `ProvisionId` | `string` | Optional | - |
| `IsMonitorEnabled` | `bool?` | Optional | - |
| `Health` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `HealthStatusModifiedAt` | `string` | Optional | - |
| `Manufacturer` | `string` | Optional | - |
| `ClusterType` | `string` | Optional | - |
| `ClusterBlueprint` | `string` | Optional | - |
| `GimageUsed` | `string` | Optional | - |
| `Reason` | `string` | Optional | - |
| `IsMasterDedicated` | `bool?` | Optional | - |
| `ProjectId` | `string` | Optional | - |
| `ProvisionOs` | `string` | Optional | - |
| `DefaultStorageClass` | `string` | Optional | - |
| `StorageClassMap` | [`Models.StorageClassMap`](../../doc/models/storage-class-map.md) | Optional | - |
| `CniProvider` | `string` | Optional | - |
| `ProvisionK8s` | `string` | Optional | - |
| `EtcdVersion` | `string` | Optional | - |
| `ConsulVersion` | `string` | Optional | - |
| `ClusterBlueprintVersion` | `string` | Optional | - |
| `UpgradeProtection` | `bool?` | Optional | - |
| `Provision` | [`Models.ClusterInfraProvision`](../../doc/models/cluster-infra-provision.md) | Optional | - |
| `Metro` | [`Models.Metro`](../../doc/models/metro.md) | Optional | - |
| `Nodes` | [`List<Models.Node>`](../../doc/models/node.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `ClusterProviderParams` | [`Models.ClusterProviderParams`](../../doc/models/cluster-provider-params.md) | Optional | - |
| `Nodegroups` | [`List<Models.NodeGroupItem>`](../../doc/models/node-group-item.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `ClusterVersionInfo` | [`Models.ClusterVersionInfo`](../../doc/models/cluster-version-info.md) | Optional | - |
| `Projects` | [`List<Models.ProjectItem>`](../../doc/models/project-item.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `Cluster` | [`Models.Cluster`](../../doc/models/cluster.md) | Optional | - |

## Example (as JSON)

```json
{
  "ha_enabled": true,
  "auto_create": true,
  "auto_approve_nodes": true,
  "is_monitor_enabled": true,
  "is_master_dedicated": false,
  "upgrade_protection": true,
  "name": "name0",
  "created_at": "created_at2",
  "modified_at": "modified_at6",
  "organization_id": "organization_id0",
  "partner_id": "partner_id2"
}
```

