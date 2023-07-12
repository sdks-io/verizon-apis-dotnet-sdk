
# Service File

Response to get file of a service.

## Structure

`ServiceFile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | System generated unique UUID.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `ServiceName` | `string` | Optional | Service name to which the file is going to be associated.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `ServiceVersion` | `string` | Optional | Version of the service being used.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[0-9\.]+$` |
| `File` | `string` | Optional | File which is to be uploaded should be provided in formData.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9.\-_]+$` |
| `CategoryName` | `string` | Optional | Name of the workload being used in the service.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `CategoryVersion` | `string` | Optional | Version of the workload being used in the service.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9.\-_]+$` |
| `CategoryType` | `string` | Optional | Type of the workload being used in the service eg: use WORKLOAD_TGZ to upload the workload file in tgz format.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `ValidationStatus` | `string` | Optional | Gives the success and failure response for the validation.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9-_ .]+$` |
| `CreatedDate` | `DateTime?` | Optional | System captured creation date and time when tag is created. |
| `LastModifiedDate` | `DateTime?` | Optional | System captured date and time when the tag was last modified. |
| `CreatedBy` | `string` | Optional | User information who created the tag.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `UpdatedBy` | `string` | Optional | Last user information who made changes to tag.<br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |

## Example (as JSON)

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

