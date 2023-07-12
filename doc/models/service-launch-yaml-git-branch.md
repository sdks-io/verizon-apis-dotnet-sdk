
# Service Launch Yaml Git Branch

## Structure

`ServiceLaunchYamlGitBranch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BranchName` | `string` | Optional | - |
| `ValuesYamlPaths` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "valuesYamlPaths": [
    "/home/helmchart"
  ],
  "branchName": "branchName2"
}
```

