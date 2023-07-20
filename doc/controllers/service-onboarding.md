# Service Onboarding

```csharp
ServiceOnboardingController serviceOnboardingController = client.ServiceOnboardingController;
```

## Class Name

`ServiceOnboardingController`

## Methods

* [List Services](../../doc/controllers/service-onboarding.md#list-services)
* [Register Service](../../doc/controllers/service-onboarding.md#register-service)
* [Upload Service Workload File](../../doc/controllers/service-onboarding.md#upload-service-workload-file)
* [List Service Details](../../doc/controllers/service-onboarding.md#list-service-details)
* [Start Service Claim Sand Box Testing](../../doc/controllers/service-onboarding.md#start-service-claim-sand-box-testing)
* [Remove Service](../../doc/controllers/service-onboarding.md#remove-service)
* [Stop Service Testing](../../doc/controllers/service-onboarding.md#stop-service-testing)
* [Mark Service as Ready for Public Use](../../doc/controllers/service-onboarding.md#mark-service-as-ready-for-public-use)
* [Start Service Onboarding](../../doc/controllers/service-onboarding.md#start-service-onboarding)
* [Get Service Job Status](../../doc/controllers/service-onboarding.md#get-service-job-status)
* [Start Service Publishing](../../doc/controllers/service-onboarding.md#start-service-publishing)


# List Services

Fetch all organizational services in the platform.

```csharp
ListServicesAsync(
    string accountName,
    string correlationId = null,
    string name = null,
    string q = null,
    long? limit = null,
    long? offSet = null,
    string sortKey = "createdDate",
    Models.SortDirectionEnum? sortDir = null,
    bool? detailsFlag = true)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |
| `name` | `string` | Query, Optional | Name of the service whose information needs to be fetched.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `q` | `string` | Query, Optional | Use the comma (:) character to separate multiple values eg type=myService:workloads.packageType=Helm,YAML:state=DRAFTED,VALIDATION_COMPLETED.<br>**Constraints**: *Maximum Length*: `2048`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!\/,+\-=_:.&*%\s]+$` |
| `limit` | `long?` | Query, Optional | Number of items to return.<br>**Constraints**: `>= 0`, `<= 1024` |
| `offSet` | `long?` | Query, Optional | Id of the last respose value in the previous list.<br>**Constraints**: `>= 0`, `<= 1024` |
| `sortKey` | `string` | Query, Optional | Sorts the response by an attribute. Default is createdDate.<br>**Default**: `"createdDate"`<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `sortDir` | [`Models.SortDirectionEnum?`](../../doc/models/sort-direction-enum.md) | Query, Optional | Sorts the response. Use asc for ascending or desc for descending order. The default is desc.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `detailsFlag` | `bool?` | Query, Optional | Default as true. If it is true, then it will return all details.<br>**Default**: `true` |

## Response Type

[`Task<ApiResponse<Models.Services>>`](../../doc/models/services.md)

## Example Usage

```csharp
string accountName = "test_account1";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
string name = "dev-api-test-service-mdp-1";
string q = "type=myService:workloads.packageType=Helm,YAML:state=DRAFTED,VALIDATION_COMPLETED";
long? limit = 256L;
long? offSet = 255L;
string sortKey = "createdDate";
Models.SortDirectionEnum? sortDir = SortDirectionEnum.DESC;
bool? detailsFlag = true;
try
{
    ApiResponse<Services> result = await serviceOnboardingController.ListServicesAsync(accountName, correlationId, name, q, limit, offSet, sortKey, sortDir, detailsFlag);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "totalRecords": 1,
  "serviceResList": [
    {
      "boundaries": [],
      "categories": [
        "MongodbSensor"
      ],
      "compatibility": [
        {
          "csp": "AWS_WL"
        }
      ],
      "createdBy": "acme-user",
      "createdDate": "2022-08-03T13:31:52.000Z",
      "error": {},
      "errorResponse": {},
      "id": "b32321d2-4ee3-458b-a70b-e956525d46c9",
      "lastModifiedBy": "acme-user",
      "lastModifiedDate": "2022-08-03T13:31:52.000Z",
      "name": "dev-api-test-service-mdp-1",
      "state": "DRAFT",
      "status": "DRAFT_INPROGRESS",
      "tags": [
        {
          "key": "vnsp.mec.verizon.com/servicetype",
          "value": "My service"
        }
      ],
      "type": "MY_SERVICE",
      "version": "1.0.0",
      "workloads": [
        {
          "createdBy": "acme-user",
          "createdDate": "2022-08-03T13:31:52.000Z",
          "description": "MEC SD Workload.",
          "files": [],
          "helmHelmrepo": {
            "helmChartName": "mongodb",
            "helmChartVersion": "12.1.10"
          },
          "id": "cf5e0af0-0dfc-4b6b-be95-08fc28e5f4ad",
          "lastModifiedDte": "0001-01-01T00:00:00.000Z",
          "name": "dev-api-demo-repo",
          "packageType": "HELM",
          "repositoryType": "HELM",
          "updatedBy": "acme-user",
          "uploadType": "PULL_FROM_REPO"
        }
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not Found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Register Service

Create a new service within user's organization.

```csharp
RegisterServiceAsync(
    string accountName,
    Models.Service body,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `body` | [`Models.Service`](../../doc/models/service.md) | Body, Required | - |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.Service>>`](../../doc/models/service.md)

## Example Usage

```csharp
string accountName = "test_account1";
Service body = new Service
{
    Name = "dev-api-test-service-mdp-1",
    Version = "1.0.0",
    Tags = new List<Models.ServiceTag>
    {
        new ServiceTag
        {
            Key = "vnsp.mec.verizon.com/servicetype",
            MValue = "My service",
        },
    },
    Categories = new List<string>
    {
        "MongodbSensor",
    },
    Compatibility = new List<Models.Compatibility>
    {
        new Compatibility
        {
            Csp = CSPCompatibilityEnum.AWSWL,
        },
    },
    Type = ServiceTypeEnum.MYSERVICE,
    Workloads = new List<Models.Workload>
    {
        new Workload
        {
            Name = "dev-api-demo-repo",
            Description = "MEC SD Workload.",
            PackageType = ServiceDependencyPackageTypeEnum.HELM,
            UploadType = UploadTypeEnum.PULLFROMREPO,
            RepositoryType = WorkloadRepositoryTypeEnum.HELM,
            HelmHelmrepo = new ServiceOnboardingHelmHelmrepo
            {
                HelmChartName = "mongodb",
                HelmChartVersion = "12.1.10",
            },
        },
    },
};

string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<Service> result = await serviceOnboardingController.RegisterServiceAsync(accountName, body, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

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
  "createdBy": "acme-user",
  "createdDate": "2022-08-03T13:31:52.000Z",
  "error": {},
  "errorResponse": {},
  "id": "b32321d2-4ee3-458b-a70b-e956525d46c9",
  "lastModifiedBy": "acme-user",
  "lastModifiedDate": "2022-08-03T13:31:52.000Z",
  "name": "dev-api-test-service-mdp-1",
  "tags": [
    {
      "key": "services.mec.verizon.com/servicetype",
      "value": "My service"
    }
  ],
  "type": "MY_SERVICE",
  "version": "1.0.0",
  "workloads": [
    {
      "createdBy": "acme-user",
      "createdDate": "2022-08-03T13:31:52.000Z",
      "description": "MEC SD Workload.",
      "helmHelmrepo": {
        "helmChartName": "mongodb",
        "helmChartVersion": "12.1.10"
      },
      "id": "cf5e0af0-0dfc-4b6b-be95-08fc28e5f4ad",
      "lastModifiedDte": "2022-08-03T13:31:52.000Z",
      "name": "dev-api-demo-repo",
      "packageType": "HELM",
      "repositoryType": "HELM",
      "updatedBy": "acme-user",
      "uploadType": "PULL_FROM_REPO"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 403 | Forbidden. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 415 | Unsupported media type. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 429 | Too many requests. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Upload Service Workload File

Upload workload payload/package in the MEC platform.

```csharp
UploadServiceWorkloadFileAsync(
    string accountName,
    string serviceName,
    string version,
    Models.CategoryTypeEnum categoryType,
    string categoryName,
    FileStreamInfo payload,
    string correlationId = null,
    string categoryVersion = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceName` | `string` | Template, Required | Service name to which the file is going to be associated.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `version` | `string` | Template, Required | Version of the service being used.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[0-9\.]+$` |
| `categoryType` | [`Models.CategoryTypeEnum`](../../doc/models/category-type-enum.md) | Query, Required | Type of the file being uploaded.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `categoryName` | `string` | Query, Required | `workloadName` used in the service while creation.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9-_.]+$` |
| `payload` | `FileStreamInfo` | Form, Required | Payload/file which is to be uploaded should be provided in formData. |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |
| `categoryVersion` | `string` | Query, Optional | It is mandatory for only service file, not mandatory for workload and workflow file.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[0-9\.]+$` |

## Response Type

[`Task<ApiResponse<Models.ServiceFile>>`](../../doc/models/service-file.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceName = "doccheck";
string version = "1.0.0";
Models.CategoryTypeEnum categoryType = CategoryTypeEnum.GENERALVALIDATION;
string categoryName = "gst-server-workload";
FileStreamInfo payload = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
string categoryVersion = "1.0.0";
try
{
    ApiResponse<ServiceFile> result = await serviceOnboardingController.UploadServiceWorkloadFileAsync(accountName, serviceName, version, categoryType, categoryName, payload, correlationId, categoryVersion);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "id": "uuid",
  "serviceName": "gst-server",
  "serviceVersion": "1.0.0",
  "file": "values.yaml",
  "categoryName": "gst-server-workload",
  "categoryVersion": "1.0.0",
  "categoryType": "WORKLOAD_VALUES",
  "validationStatus": "Validation Success",
  "createdDate": "2006-01-02T15:04:05Z",
  "lastModifiedDate": "2006-01-02T15:04:05Z",
  "createdBy": "User",
  "updatedBy": "User"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# List Service Details

Fetch a service details within user's organization using service name and version.

```csharp
ListServiceDetailsAsync(
    string accountName,
    string serviceName,
    string version,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceName` | `string` | Template, Required | Name of the service whose information needs to be fetched.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `version` | `string` | Template, Required | Version of service whose information needs to be fetched.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[0-9\.]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.Service>>`](../../doc/models/service.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceName = "dev-api-test-service-mdp-1";
string version = "1.0.0";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<Service> result = await serviceOnboardingController.ListServiceDetailsAsync(accountName, serviceName, version, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

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
  "createdBy": "acme-user",
  "createdDate": "2022-08-03T13:31:52.000Z",
  "error": {},
  "errorResponse": {},
  "id": "b32321d2-4ee3-458b-a70b-e956525d46c9",
  "lastModifiedBy": "acme-user",
  "lastModifiedDate": "2022-08-03T13:31:52.000Z",
  "name": "dev-api-test-service-mdp-1",
  "tags": [
    {
      "key": "services.mec.verizon.com/servicetype",
      "value": "My service"
    }
  ],
  "type": "MY_SERVICE",
  "version": "1.0.0",
  "workloads": [
    {
      "createdBy": "acme-user",
      "createdDate": "2022-08-03T13:31:52.000Z",
      "description": "MEC SD Workload.",
      "helmHelmrepo": {
        "helmChartName": "mongodb",
        "helmChartVersion": "12.1.10"
      },
      "id": "cf5e0af0-0dfc-4b6b-be95-08fc28e5f4ad",
      "lastModifiedDte": "2022-08-03T13:31:52.000Z",
      "name": "dev-api-demo-repo",
      "packageType": "HELM",
      "repositoryType": "HELM",
      "updatedBy": "acme-user",
      "uploadType": "PULL_FROM_REPO"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not Found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| Default | Unexpected error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Start Service Claim Sand Box Testing

Initiate testing of a service in sandbox environment per claim based on service's compatibility(s).

```csharp
StartServiceClaimSandBoxTestingAsync(
    string accountName,
    string serviceId,
    string claimId,
    Models.ClusterInfoDetails body,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceId` | `string` | Template, Required | An id of the service created e.g. UUID.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `claimId` | `string` | Template, Required | Id of the claim created e.g. UUID.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `body` | [`Models.ClusterInfoDetails`](../../doc/models/cluster-info-details.md) | Body, Required | - |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.ServiceManagementResult>>`](../../doc/models/service-management-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceId = "b32321d2-4ee3-458b-a70b-e956525d46c9";
string claimId = "58296746-57ee-44f8-8107-399b61d58356";
ClusterInfoDetails body = new ClusterInfoDetails
{
    ClusterName = "ctc-1",
    MNamespace = "default",
};

string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<ServiceManagementResult> result = await serviceOnboardingController.StartServiceClaimSandBoxTestingAsync(accountName, serviceId, claimId, body, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "jobId": "0c6e8560-e154-40f9-961e-28da3698436d",
  "status": "Inprogress",
  "state": "DRAFT"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| Default | Unexpected error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Remove Service

Remove a service from user's organization.

```csharp
RemoveServiceAsync(
    string accountName,
    string serviceName,
    string version,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceName` | `string` | Template, Required | Name of the service which is about to be deleted.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `version` | `string` | Template, Required | Version of the service which is about to be deleted.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[0-9\.]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.EdgeServiceOnboardingDeleteResult>>`](../../doc/models/edge-service-onboarding-delete-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceName = "dev-api-test-service-mdp-1";
string version = "1.0.0";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<EdgeServiceOnboardingDeleteResult> result = await serviceOnboardingController.RemoveServiceAsync(accountName, serviceName, version, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "message": "service deleted succesfully",
  "subStatus": "service delete - success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Stop Service Testing

Start service certification process. On successful completion of this process, service's status will change to certified.

```csharp
StopServiceTestingAsync(
    string accountName,
    string serviceName,
    string version,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceName` | `string` | Template, Required | Name of the service e.g. any sub string of serviceName.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `version` | `string` | Template, Required | Version of service which is to be certified.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[0-9\.]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.ServiceManagementResult>>`](../../doc/models/service-management-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceName = "dev-api-test-service-mdp-1";
string version = "1.0.0";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<ServiceManagementResult> result = await serviceOnboardingController.StopServiceTestingAsync(accountName, serviceName, version, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "jobId": "0c6e8560-e154-40f9-961e-28da3698436d",
  "status": "Inprogress",
  "state": "DRAFT"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| Default | Unexpected error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Mark Service as Ready for Public Use

Start the process to change a service's status to "Ready to Use". On success, service's status will be changed to "Ready to Use". Only a ready to use service can be deployed in production environment.

```csharp
MarkServiceAsReadyForPublicUseAsync(
    string accountName,
    string serviceName,
    string version,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceName` | `string` | Template, Required | Name of the service e.g. any sub string of serviceName.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `version` | `string` | Template, Required | Version of the service which is already certified and is ready for public use.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[0-9\.]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.ServiceManagementResult>>`](../../doc/models/service-management-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceName = "dev-api-test-service-mdp-1";
string version = "1.0.0";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<ServiceManagementResult> result = await serviceOnboardingController.MarkServiceAsReadyForPublicUseAsync(accountName, serviceName, version, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "jobId": "0c6e8560-e154-40f9-961e-28da3698436d",
  "status": "Inprogress",
  "state": "DRAFT"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| Default | Unexpected error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Start Service Onboarding

Start service onboarding process to kick off service artifact validation and making the service ready for sandbox testing. On successful completion of this process system will generate claims for each selected cloud provider using which user can start sandbox testing.

```csharp
StartServiceOnboardingAsync(
    string accountName,
    string serviceName,
    string version,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceName` | `string` | Template, Required | Name of the service which is to be onboarded.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `version` | `string` | Template, Required | Version of service which is to be onboarded.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9\.]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.ServiceManagementResult>>`](../../doc/models/service-management-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceName = "dev-api-test-service-mdp-1";
string version = "1.0.0";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<ServiceManagementResult> result = await serviceOnboardingController.StartServiceOnboardingAsync(accountName, serviceName, version, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "jobId": "0c6e8560-e154-40f9-961e-28da3698436d",
  "status": "Inprogress",
  "state": "DRAFT"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 403 | Forbidden. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 415 | Unsupported media type. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 429 | Too many requests. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Get Service Job Status

Check current status of job for a service using job ID.

```csharp
GetServiceJobStatusAsync(
    string accountName,
    string jobId,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `jobId` | `string` | Template, Required | Auto-generated Id of the job.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9_-]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.CurrentStatus>>`](../../doc/models/current-status.md)

## Example Usage

```csharp
string accountName = "test_account1";
string jobId = "0c6e8560-e154-40f9-961e-28da3698436d";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<CurrentStatus> result = await serviceOnboardingController.GetServiceJobStatusAsync(accountName, jobId, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "STARTED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Start Service Publishing

Start publishing a service. On successful completion, service's status can be marked as Publish.

```csharp
StartServicePublishingAsync(
    string accountName,
    string serviceName,
    string version,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `serviceName` | `string` | Template, Required | Name of the service e.g. any sub string of serviceName.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `version` | `string` | Template, Required | Version of service which is to be published.<br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[0-9\.]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.ServiceManagementResult>>`](../../doc/models/service-management-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string serviceName = "dev-api-test-service-mdp-1";
string version = "1.0.0";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<ServiceManagementResult> result = await serviceOnboardingController.StartServicePublishingAsync(accountName, serviceName, version, correlationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "jobId": "0c6e8560-e154-40f9-961e-28da3698436d",
  "status": "Inprogress",
  "state": "DRAFT"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| Default | Unexpected error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |

