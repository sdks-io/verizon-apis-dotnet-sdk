# CSP Profiles

```csharp
CSPProfilesController cSPProfilesController = client.CSPProfilesController;
```

## Class Name

`CSPProfilesController`

## Methods

* [Create Cloud Credential](../../doc/controllers/csp-profiles.md#create-cloud-credential)
* [Remove Cloud Credential](../../doc/controllers/csp-profiles.md#remove-cloud-credential)
* [Fetch Cloud Credential Details](../../doc/controllers/csp-profiles.md#fetch-cloud-credential-details)


# Create Cloud Credential

Create a new cloud credential within user's organization.

```csharp
CreateCloudCredentialAsync(
    string accountName,
    Models.CSPProfile body,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `body` | [`Models.CSPProfile`](../../doc/models/csp-profile.md) | Body, Required | - |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.CSPProfile>>`](../../doc/models/csp-profile.md)

## Example Usage

```csharp
string accountName = "test_account1";
CSPProfile body = new CSPProfile
{
    CspProfileName = "dev-api-csp-profile-mdp",
    ProjectName = "vz-cve",
    Type = CSPProfileTypeEnum.AWS,
    AwsCspProfile = new AwsCspProfile
    {
        CredType = AwsCspProfileCredTypeEnum.ACCESSKEY,
        AccessKey = "XXXXX",
        SecretKey = "XXXXX",
    },
};

string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<CSPProfile> result = await cSPProfilesController.CreateCloudCredentialAsync(accountName, body, correlationId);
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
  "awsCspProfile": {
    "accessKey": "XXXXX",
    "credType": "ACCESS_KEY",
    "secretKey": "XXXXX"
  },
  "createdBy": "acme-user",
  "createdDate": "2022-08-03T13:59:51.000Z",
  "cspProfileName": "dev-api-csp-profile-mdp",
  "customerID": "acme",
  "id": "72e35c51-098e-4388-9055-2967bbd9be48",
  "lastModifiedBy": "acme-user",
  "lastModifiedDate": "2022-08-03T13:59:51.000Z",
  "projectName": "vz-cve",
  "type": "AWS"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 403 | Forbidden. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 429 | Too many requests. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| Default | Forbidden. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Remove Cloud Credential

Remove a cloud credential from user's organization.

```csharp
RemoveCloudCredentialAsync(
    string accountName,
    string id,
    string correlationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `id` | `string` | Template, Required | CSP Profile Id. |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |

## Response Type

[`Task<ApiResponse<Models.EdgeServiceOnboardingDeleteResult>>`](../../doc/models/edge-service-onboarding-delete-result.md)

## Example Usage

```csharp
string accountName = "test_account1";
string id = "72e35c51-098e-4388-9055-2967bbd9be48";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
try
{
    ApiResponse<EdgeServiceOnboardingDeleteResult> result = await cSPProfilesController.RemoveCloudCredentialAsync(accountName, id, correlationId);
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
  "message": "Csp Profile deleted Successfully",
  "subStatus": "Csp Profile Delete - success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not Found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |


# Fetch Cloud Credential Details

Fetch available cloud credentials within user's organization.

```csharp
FetchCloudCredentialDetailsAsync(
    string accountName,
    string correlationId = null,
    string q = null,
    long? limit = null,
    long? offSet = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Header, Required | User account name.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `correlationId` | `string` | Header, Optional | **Constraints**: *Maximum Length*: `50`, *Pattern*: `^[a-zA-Z0-9-]+$` |
| `q` | `string` | Query, Optional | Use the coloumn (:) character to separate multiple query params eg type=AWS:awsCspProfile.credType=ACCESS_KEY,ROLE_ARN:state=UNVERIFIED,VERIFIED.<br>**Constraints**: *Maximum Length*: `2048`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]'!\/,+\-=_:.&*%\s]+$` |
| `limit` | `long?` | Query, Optional | Number of items to return.<br>**Constraints**: `>= 0`, `<= 1024` |
| `offSet` | `long?` | Query, Optional | Id of the last respose value in the previous list.<br>**Constraints**: `>= 0`, `<= 1024` |

## Response Type

[`Task<ApiResponse<Models.CSPProfileData>>`](../../doc/models/csp-profile-data.md)

## Example Usage

```csharp
string accountName = "test_account1";
string correlationId = "9958f2f8-c4e3-46e0-8982-356de6515ae9";
string q = "cspProfileName=dev-api-csp-profile-mdp";
long? limit = 256L;
long? offSet = 255L;
try
{
    ApiResponse<CSPProfileData> result = await cSPProfilesController.FetchCloudCredentialDetailsAsync(accountName, correlationId, q, limit, offSet);
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
  "count": 1,
  "cspProfileList": [
    {
      "awsCspProfile": {
        "accessKey": "XXXXX",
        "credType": "ACCESS_KEY",
        "secretKey": "XXXXX"
      },
      "createdBy": "acme-user",
      "createdDate": "2022-08-03T13:59:51.000Z",
      "cspProfileName": "dev-api-csp-profile-mdp",
      "customerID": "acme",
      "id": "72e35c51-098e-4388-9055-2967bbd9be48",
      "lastModifiedBy": "acme-user",
      "lastModifiedDate": "2022-08-03T13:59:51.000Z",
      "projectName": "vz-cve",
      "type": "AWS"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 403 | Forbidden. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 404 | Not found. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 429 | Too many requests. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| 500 | Internal Server Error. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |
| Default | Forbidden. | [`EdgeServiceOnboardingResultErrorException`](../../doc/models/edge-service-onboarding-result-error-exception.md) |

