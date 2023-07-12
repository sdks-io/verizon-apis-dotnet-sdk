
# Edge Service Workload

## Structure

`EdgeServiceWorkload`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Name` | `string` | Required | Name of the workload needs to be deployed.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Description` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s]+$` |
| `PackageType` | [`Models.PackageTypeEnum?`](../../doc/models/package-type-enum.md) | Optional | Deployment package type.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `UploadType` | [`Models.WorkloadUploadTypeEnum?`](../../doc/models/workload-upload-type-enum.md) | Optional | **Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `RepositoryType` | [`Models.RepositoryTypeEnum?`](../../doc/models/repository-type-enum.md) | Optional | **Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `RepositoryId` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Repository` | [`Models.EdgeServiceRepository`](../../doc/models/edge-service-repository.md) | Optional | - |
| `Files` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `10000` |
| `RevisionType` | [`Models.RevisionTypeEnum?`](../../doc/models/revision-type-enum.md) | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `HelmGitBranch` | [`Models.ServiceLaunchHelmGitBranch`](../../doc/models/service-launch-helm-git-branch.md) | Optional | - |
| `HelmGitTag` | [`Models.ServiceLaunchHelmGitTag`](../../doc/models/service-launch-helm-git-tag.md) | Optional | - |
| `HelmYamlGitTag` | [`Models.ServiceLaunchHelmYamlGitTag`](../../doc/models/service-launch-helm-yaml-git-tag.md) | Optional | - |
| `HelmRepo` | [`Models.ServiceLaunchHelmRepo`](../../doc/models/service-launch-helm-repo.md) | Optional | - |
| `YamlGitBranch` | [`Models.ServiceLaunchYamlGitBranch`](../../doc/models/service-launch-yaml-git-branch.md) | Optional | - |
| `TerraformGitBranch` | [`Models.ServiceLaunchTerraformGitBranch`](../../doc/models/service-launch-terraform-git-branch.md) | Optional | - |
| `TerraformGitTag` | [`Models.ServiceLaunchTerraformGitTag`](../../doc/models/service-launch-terraform-git-tag.md) | Optional | - |
| `CreatedDate` | `DateTime?` | Optional | - |
| `LastModifiedDte` | `DateTime?` | Optional | - |
| `CreatedBy` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s]+$` |
| `UpdatedBy` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s]+$` |

## Example (as JSON)

```json
{
  "name": "MECSDWorkload",
  "id": "id0",
  "description": "description0",
  "packageType": "YAML",
  "uploadType": "PULL_FROM_REPO",
  "repositoryType": "GIT"
}
```

