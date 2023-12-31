
# Service Onboarding Helm Git Tag

## Structure

`ServiceOnboardingHelmGitTag`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TagName` | `string` | Required | The user can provide tagName for the Helm chart.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s\/]+$` |
| `HelmChartPath` | `string` | Required | The user can provide the path to the Helm chart.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s\/]+$` |
| `ValuesYamlPaths` | `List<string>` | Optional | The user can provide an array of values.YAML files paths.<br>**Constraints**: *Maximum Items*: `10000`, *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s\/]+$` |

## Example (as JSON)

```json
{
  "tagName": "mec_vz_helm_git",
  "helmChartPath": "/home/helmchart",
  "valuesYamlPaths": [
    "/home/helmchart"
  ]
}
```

