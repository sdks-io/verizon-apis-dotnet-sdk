
# Workload

Workload attribute of a service.

## Structure

`Workload`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The auto-generated Id of the workload.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Name` | `string` | Required | Name of the workload needs to be deployed.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Description` | `string` | Optional | A brief workload description.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s]+$` |
| `PackageType` | [`Models.ServiceDependencyPackageTypeEnum?`](../../doc/models/service-dependency-package-type-enum.md) | Optional | Deployment package type.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `UploadType` | [`Models.UploadTypeEnum?`](../../doc/models/upload-type-enum.md) | Optional | Allowed values are: GIT files (PULL_FROM_REPO), MANUAL_UPLOAD.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `RepositoryType` | [`Models.WorkloadRepositoryTypeEnum?`](../../doc/models/workload-repository-type-enum.md) | Optional | Repository types allowed: GIT/HELM.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `RepositoryId` | `string` | Optional | In case of 'Pull files from my repository', The user can provide the existing repositoryID.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Repository` | [`Models.Repository`](../../doc/models/repository.md) | Optional | Users can create a repository to maintain service artifacts. Repository would be either a Git or HELM repository. |
| `Files` | `List<string>` | Optional | Files which are being generated.<br>**Constraints**: *Maximum Items*: `10000`, *Maximum Length*: `10000`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]!,+\-=_:.&*%\s]+$` |
| `RevisionType` | [`Models.WorkloadRevisionTypeEnum?`](../../doc/models/workload-revision-type-enum.md) | Optional | Revision type can be a BRANCH or TAG.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `HelmGitBranch` | [`Models.ServiceOnboardingHelmGitBranch`](../../doc/models/service-onboarding-helm-git-branch.md) | Optional | - |
| `HelmGitTag` | [`Models.ServiceOnboardingHelmGitTag`](../../doc/models/service-onboarding-helm-git-tag.md) | Optional | - |
| `HelmYamlGitTag` | [`Models.ServiceOnboardingHelmYamlGitTag`](../../doc/models/service-onboarding-helm-yaml-git-tag.md) | Optional | - |
| `HelmHelmrepo` | [`Models.ServiceOnboardingHelmHelmrepo`](../../doc/models/service-onboarding-helm-helmrepo.md) | Optional | - |
| `YamlGitBranch` | [`Models.ServiceOnboardingYamlGitBranch`](../../doc/models/service-onboarding-yaml-git-branch.md) | Optional | - |
| `TerraformGitBranch` | [`Models.ServiceOnboardingTerraformGitBranch`](../../doc/models/service-onboarding-terraform-git-branch.md) | Optional | - |
| `TerraformGitTag` | [`Models.ServiceOnboardingTerraformGitTag`](../../doc/models/service-onboarding-terraform-git-tag.md) | Optional | - |
| `CreatedDate` | `DateTime?` | Optional | The date on which the workload is created. |
| `LastModifiedDte` | `DateTime?` | Optional | The date when the created workload was last modified. |
| `CreatedBy` | `string` | Optional | Identity of the user who created the workload.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s]+$` |
| `UpdatedBy` | `string` | Optional | Identity of the user who updated the workload.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s]+$` |

## Example (as JSON)

```json
{
  "description": "MEC SD Workload.",
  "packageType": "HELM",
  "helmHelmrepo": {
    "helmChartName": "mongodb",
    "helmChartVersion": "12.1.10"
  },
  "name": "dev-api-demo-repo",
  "repositoryType": "HELM",
  "uploadType": "PULL_FROM_REPO",
  "id": "id0"
}
```

