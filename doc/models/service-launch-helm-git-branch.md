
# Service Launch Helm Git Branch

## Structure

`ServiceLaunchHelmGitBranch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BranchName` | `string` | Optional | - |
| `HelmChartPath` | `string` | Optional | - |
| `ValuesYamlPaths` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "branchName": "mec_vz_helm_git",
  "helmChartPath": "/home/helmchart",
  "valuesYamlPaths": [
    "/home/helmchart"
  ]
}
```

