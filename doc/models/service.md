
# Service

A customer service on 5G MEC platform using 5G MEC portal.

## Structure

`Service`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | System generated unique UUID.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Name` | `string` | Required | Name of the service needs to be deployed.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Description` | `string` | Optional | Description of the service needs to be deployed.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `(^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s*]+$)\|(^\s*$)` |
| `Version` | `string` | Required | Version of the service needs to be deployed.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[0-9\.]+$` |
| `Metadata` | [`List<Models.ServiceOnboardingAdditionalParams>`](../../doc/models/service-onboarding-additional-params.md) | Optional | Properties are metadata attributes.<br>**Constraints**: *Maximum Items*: `2048` |
| `Tags` | [`List<Models.ServiceTag>`](../../doc/models/service-tag.md) | Optional | List of service tags.<br>**Constraints**: *Maximum Items*: `2048` |
| `Categories` | `List<string>` | Optional | Can be any name just to define it under a category.<br>**Constraints**: *Maximum Items*: `10000`, *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!,+\-=_:.&*%\s]+$` |
| `IsFavourite` | `bool?` | Optional | Boolean value to set/unset the service as favorite. |
| `IsDeleted` | `bool?` | Optional | Boolean to support soft delete of a version of a service. |
| `Compatibility` | [`List<Models.Compatibility>`](../../doc/models/compatibility.md) | Optional | Compatibility would have the attribute CSP which is Cloud service provider e.g. AWS_PUBLIC_CLOUD, AWS_WL, AWS_OUTPOST, AZURE_EDGE, AZURE_PUBLIC_CLOUD.<br>**Constraints**: *Maximum Items*: `2048` |
| `Resource` | [`Models.ServiceResource`](../../doc/models/service-resource.md) | Optional | Resource of the service. |
| `CreatedDate` | `DateTime?` | Optional | Auto-derived time of creation. Part of response only. |
| `LastModifiedDate` | `DateTime?` | Optional | Last modified time. Part of response only. |
| `CreatedBy` | `string` | Optional | User who created the service. Part of response only.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `LastModifiedBy` | `string` | Optional | User who last modified the service. Part of response only.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `Error` | [`Models.ServiceError`](../../doc/models/service-error.md) | Optional | Errors related to service. |
| `ErrorResponse` | [`Models.EdgeServiceOnboardingResult`](../../doc/models/edge-service-onboarding-result.md) | Optional | Error response attribute of a service. |
| `State` | [`Models.ServiceStateEnum?`](../../doc/models/service-state-enum.md) | Optional | Can have any value as - DRAFT, DESIGN, TESTING, PUBLISH, CERTIFY, READY_TO_USE, DEPRECATE, DELETED.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `Status` | [`Models.ServiceStatusEnum?`](../../doc/models/service-status-enum.md) | Optional | Can have any value as - DRAFT_INPROGRESS, DRAFT_COMPLETE, DESIGN_INPROGRESS, DESIGN_FAILED, DESIGN_COMPLETED, VALIDATION_INPROGRESS,  VALIDATION_FAILED, VALIDATION_COMPLETED, TESTING_INPROGRESS, TESTING_FAILED, TESTING_COMPLETED, READY_TO_USE_INPROGRESS, READY_TO_USE_FAILED, READY_TO_USE_COMPLETED, READY_TO_PRIVATE_USE_INPROGRESS, READY_TO_PRIVATE_USE_FAILED, READY_TO_PRIVATE_USE_COMPLETED,  PUBLISH_INPROGRESS,  PUBLISH_FAILED,  PUBLISH_COMPLETED,  CERTIFY_INPROGRESS,  CERTIFY_FAILED, CERTIFY_COMPLETED, DEPRECATE_INPROGRESS,  DEPRECATE_FAILED, DEPRECATE_COMPLETED, MARKDELETE_INPROGRESS, MARKDELETE_FAILED, MARKDELETE_COMPLETED. |
| `Type` | [`Models.ServiceTypeEnum?`](../../doc/models/service-type-enum.md) | Optional | Service Type e.g. Installation, Operations, Custom.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `ServiceHandlerId` | [`Models.ServiceHandlerId`](../../doc/models/service-handler-id.md) | Optional | Auto-generated Id of serviceHandlerId created. |
| `ObservabilityTemplate` | [`Models.ObservabilityTemplate`](../../doc/models/observability-template.md) | Optional | Attribute of service. |
| `ServiceSwaggerSpecId` | [`Models.ServiceSwaggerSpecId`](../../doc/models/service-swagger-spec-id.md) | Optional | Auto-generated Id of service handler Swagger specification file uploaded. |
| `Workflows` | [`List<Models.Workflow>`](../../doc/models/workflow.md) | Optional | **Constraints**: *Maximum Items*: `8192` |
| `Workloads` | [`List<Models.Workload>`](../../doc/models/workload.md) | Optional | **Constraints**: *Maximum Items*: `2048` |
| `Dependencies` | [`List<Models.ServiceDependency>`](../../doc/models/service-dependency.md) | Optional | Dependencies of the service.<br>**Constraints**: *Maximum Items*: `2048` |
| `Boundaries` | [`List<Models.Boundary>`](../../doc/models/boundary.md) | Optional | Boundaries would have attributes csp, region and zoneId.<br>**Constraints**: *Maximum Items*: `10000` |

## Example (as JSON)

```json
{
  "categories": [
    "MongodbSensor"
  ],
  "compatibility": [
    {
      "csp": "AWS_WL"
    }
  ],
  "workloads": [
    {
      "description": "MEC SD Workload.",
      "packageType": "HELM",
      "helmHelmrepo": {
        "helmChartName": "mongodb",
        "helmChartVersion": "12.1.10"
      },
      "name": "dev-api-demo-repo",
      "repositoryType": "HELM",
      "uploadType": "PULL_FROM_REPO"
    }
  ],
  "name": "dev-api-test-service-mdp-1",
  "version": "1.0.0",
  "tags": [
    {
      "key": "vnsp.mec.verizon.com/servicetype",
      "value": "My service"
    }
  ],
  "type": "MY_SERVICE",
  "id": "id0",
  "description": "description0",
  "metadata": [
    {
      "key": "key3",
      "value": "value5"
    },
    {
      "key": "key4",
      "value": "value6"
    },
    {
      "key": "key5",
      "value": "value7"
    }
  ]
}
```

