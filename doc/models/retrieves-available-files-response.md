
# Retrieves Available Files Response

## Structure

`RetrievesAvailableFilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FileName` | `string` | Optional | ThingSpace-generated name of the file. You will use this name when listing or scheduling campaigns for the file. |
| `FileVersion` | `string` | Optional | Version of the file. |
| `ReleaseNote` | `string` | Optional | Software release note. |
| `Make` | `string` | Optional | The software-applicable device make. |
| `Model` | `string` | Optional | The software-applicable device model. |
| `LocalTargetPath` | `string` | Optional | Local target path on the device. |
| `DistributionType` | `string` | Optional | Valid values |
| `DevicePlatformId` | `string` | Optional | The platform (Android, iOS, etc.,) that the software can be applied to. |

## Example (as JSON)

```json
{
  "fileName": "configfile-Verizon_VZW1_hello-world.txt",
  "fileVersion": "1.0",
  "releaseNote": "Hello world initial file",
  "make": "Verizon",
  "model": "VZW1",
  "localTargetPath": "/VZWFOTA/hello-world.txt",
  "distributionType": "HTTP",
  "devicePlatformId": "IoT"
}
```

