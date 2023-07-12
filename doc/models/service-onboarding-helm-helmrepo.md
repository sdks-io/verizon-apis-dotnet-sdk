
# Service Onboarding Helm Helmrepo

## Structure

`ServiceOnboardingHelmHelmrepo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HelmChartName` | `string` | Required | The user can provide the Helm chart name.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s\/]+$` |
| `HelmChartVersion` | `string` | Required | The user can provide the Helm chart version.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s\/]+$` |

## Example (as JSON)

```json
{
  "helmChartName": "mec_helm_chart",
  "helmChartVersion": "1.0.0"
}
```

