
# Node Configuration

## Structure

`NodeConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the nodeGroup. |
| `IsWavelengthZone` | `bool?` | Optional | **Default**: `false` |
| `IsManagedNodeGroup` | `bool?` | Optional | **Default**: `false` |
| `IsSpotInstanceNeeded` | `bool?` | Optional | **Default**: `false` |
| `EndPointAccessType` | [`Models.EndPointAccessTypeEnum?`](../../doc/models/end-point-access-type-enum.md) | Optional | **Default**: `EndPointAccessTypeEnum.private` |
| `InstanceType` | `string` | Optional | **Default**: `"m5.xlarge"` |
| `Nodes` | `int?` | Optional | **Default**: `2`<br>**Constraints**: `>= 0`, `<= 1024` |
| `NodesMin` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `NodesMax` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `NodeVolumeType` | `string` | Optional | - |
| `SubnetCidrBlock` | `string` | Optional | - |
| `NodeAmiFamily` | `string` | Optional | **Default**: `"AmazonLinux2"` |
| `NodeVolumeSize` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `KeyName` | `string` | Optional | - |
| `MaxPodPerNode` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `UseVolumeEncryption` | `bool?` | Optional | **Default**: `true` |
| `NodePrivateNetworking` | `bool?` | Optional | **Default**: `false` |
| `InstanceProfileArn` | `string` | Optional | - |
| `InstanceRoleArn` | `string` | Optional | - |
| `InstanceRolePermissionBoundary` | `string` | Optional | - |
| `SecurityGroupIds` | [`List<Models.IdList>`](../../doc/models/id-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `AvailabilityZoneIds` | [`List<Models.IdList>`](../../doc/models/id-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `Labels` | [`Models.NodeConfigurationLabel`](../../doc/models/node-configuration-label.md) | Optional | - |
| `Tags` | [`Models.NodeConfigurationTag`](../../doc/models/node-configuration-tag.md) | Optional | - |
| `AutoCreateServiceRoles` | `bool?` | Optional | **Default**: `true` |
| `EnableFullAccessToEcr` | `bool?` | Optional | - |
| `EnableAsgAccess` | `bool?` | Optional | - |
| `EnableDnsAccess` | `bool?` | Optional | - |
| `EnableAppMeshAccess` | `bool?` | Optional | - |
| `EnableAlbAccess` | `bool?` | Optional | - |
| `EnableEfsAccess` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "autoCreateServiceRoles": true,
  "enableAlbAccess": true,
  "enableAppMeshAccess": true,
  "enableAsgAccess": true,
  "enableDnsAccess": true,
  "enableEfsAccess": true,
  "enableFullAccessToEcr": true,
  "endPointAccessType": "private",
  "instanceType": "m5.xlarge",
  "isManagedNodeGroup": false,
  "isSpotInstanceNeeded": false,
  "isWavelengthZone": false,
  "labels": {},
  "name": "ng-22",
  "nodeAmiFamily": "AmazonLinux2",
  "nodePrivateNetworking": false,
  "nodeVolumeSize": 80,
  "nodeVolumeType": "gp3",
  "nodes": 2,
  "nodesMax": 2,
  "nodesMin": 2,
  "tags": {},
  "useVolumeEncryption": true
}
```

