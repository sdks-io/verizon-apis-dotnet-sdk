
# Cluster Configuration

## Structure

`ClusterConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tags` | [`Models.EdgeServiceLaunchParams`](../../doc/models/edge-service-launch-params.md) | Optional | - |
| `EndPointAccessType` | [`Models.ClusterConfigEndpointAccessTypeEnum?`](../../doc/models/cluster-config-endpoint-access-type-enum.md) | Optional | **Default**: `ClusterConfigEndpointAccessTypeEnum.privateAccess` |
| `AutoCreateNetworkInfra` | `bool?` | Optional | **Default**: `true` |
| `InfraIPv4range` | `string` | Optional | **Default**: `"192.168.0.0/16"` |
| `NetworkNatMode` | [`Models.NetworkNatModeEnum?`](../../doc/models/network-nat-mode-enum.md) | Optional | **Default**: `NetworkNatModeEnum.single` |
| `AvailabilityZones` | [`List<Models.IdList>`](../../doc/models/id-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `PrivateNetworkInfraIds` | [`List<Models.IdList>`](../../doc/models/id-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `PublicNetworkInfraIds` | [`List<Models.IdList>`](../../doc/models/id-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "autoCreateNetworkInfra": true,
  "networkNatMode": "single",
  "tags": {
    "key": "key0",
    "value": "value2"
  },
  "endPointAccessType": "privatePublicAccess",
  "infraIPv4range": "infraIPv4range0"
}
```

