
# Service Onboarding Yaml Git Branch

## Structure

`ServiceOnboardingYamlGitBranch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BranchName` | `string` | Required | The user can provide branchName for the Helm chart.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s\/]+$` |
| `ValuesYamlPaths` | `List<string>` | Optional | The user can provide an array of values. YAML files paths.<br>**Constraints**: *Maximum Items*: `10000`, *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s\/]+$` |

## Example (as JSON)

```json
{
  "branchName": "mec_yaml_git",
  "valuesYamlPaths": [
    "/home/helmchart"
  ]
}
```

