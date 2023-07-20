# Configuration Files

```csharp
ConfigurationFilesController configurationFilesController = client.ConfigurationFilesController;
```

## Class Name

`ConfigurationFilesController`

## Methods

* [Upload Config File](../../doc/controllers/configuration-files.md#upload-config-file)
* [Get List of Files](../../doc/controllers/configuration-files.md#get-list-of-files)


# Upload Config File

Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.

```csharp
UploadConfigFileAsync(
    string acc,
    FileStreamInfo fileupload = null,
    string fileVersion = null,
    string make = null,
    string model = null,
    string localTargetPath = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `fileupload` | `FileStreamInfo` | Form, Optional | The file to upload. |
| `fileVersion` | `string` | Form, Optional | Version of the file. |
| `make` | `string` | Form, Optional | The software-applicable device make. |
| `model` | `string` | Form, Optional | The software-applicable device model. |
| `localTargetPath` | `string` | Form, Optional | Local target path on the device. |

## Response Type

[`Task<ApiResponse<Models.UploadConfigurationFilesResponse>>`](../../doc/models/upload-configuration-files-response.md)

## Example Usage

```csharp
string acc = "0402196254-00001";
string fileVersion = "1.0";
string make = "Verizon";
string model = "VZW1";
string localTargetPath = "/VZWFOTA/hello-world.txt";
try
{
    ApiResponse<UploadConfigurationFilesResponse> result = await configurationFilesController.UploadConfigFileAsync(acc, null, fileVersion, make, model, localTargetPath);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get List of Files

You can retrieve a list of configuration or supplementary of files for an account.

```csharp
GetListOfFilesAsync(
    string acc,
    string distributionType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `distributionType` | `string` | Query, Required | Filter the distributionType to only retrieve files for a specific distribution type. |

## Response Type

[`Task<ApiResponse<Models.RetrievesAvailableFilesResponseList>>`](../../doc/models/retrieves-available-files-response-list.md)

## Example Usage

```csharp
string acc = "0402196254-00001";
string distributionType = "HTTP";
try
{
    ApiResponse<RetrievesAvailableFilesResponseList> result = await configurationFilesController.GetListOfFilesAsync(acc, distributionType);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

