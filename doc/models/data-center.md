
# Data Center

## Structure

`DataCenter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PackageType` | [`Models.DataCenterPackageTypeEnum?`](../../doc/models/data-center-package-type-enum.md) | Optional | Packages are optimized for various operating environments. Prepackaged images are available in OVA and QCOW formats. |
| `Distribution` | [`Models.DataCenterDistributionEnum?`](../../doc/models/data-center-distribution-enum.md) | Optional | Supported Kubernetes distribution for the selected cloud provider. |
| `Location` | `string` | Optional | Indicate geo-location of cluster if you wish to use location based policies. |
| `K8sVersion` | [`Models.K8sVersionEnum?`](../../doc/models/k8-s-version-enum.md) | Optional | Version of K8s platform.<br>**Default**: `K8sVersionEnum.Enum_118` |
| `OperatingSystem` | `string` | Optional | Operating System for the master and worker nodes. |
| `Tags` | [`List<Models.EdgeServiceLaunchParams>`](../../doc/models/edge-service-launch-params.md) | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "packageType": "Linux",
  "distribution": "Upstream Kubernetes",
  "k8sVersion": "1.18",
  "tags": [
    {
      "key": "key",
      "value": "value"
    }
  ],
  "location": "location4",
  "operatingSystem": "operatingSystem4"
}
```

