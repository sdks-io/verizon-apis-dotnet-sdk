
# Edge Service Repository

## Structure

`EdgeServiceRepository`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `Description` | `string` | Optional | **Constraints**: *Maximum Length*: `250`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-\s]{1,250}$` |
| `Revision` | [`Models.Revision`](../../doc/models/revision.md) | Optional | - |
| `VendorInformation` | [`Models.VendorInformation`](../../doc/models/vendor-information.md) | Optional | - |
| `Type` | [`Models.RepositoryResTypeEnum`](../../doc/models/repository-res-type-enum.md) | Required | **Constraints**: *Maximum Length*: `20` |
| `Tag` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `Endpoint` | `string` | Required | **Constraints**: *Maximum Length*: `50`, *Pattern*: `([a-z0-9-]+\:\/+)([^\/\s]+)([a-z0-9\-@\^=%&;\/~\+]*)[\?]?([^ \#\r\n]*)#?([^ \#\r\n]*)` |
| `Reacheability` | [`Models.ReacheabilityEnum`](../../doc/models/reacheability-enum.md) | Required | - |
| `CACertificate` | `string` | Optional | Required if your repository uses a private certificate authencation.Please provide ur CA certificat in PEM format. |
| `Agents` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `100` |
| `SslDisabled` | `bool?` | Optional | - |
| `CredentialsType` | [`Models.CredentialsTypeEnum?`](../../doc/models/credentials-type-enum.md) | Optional | - |
| `Credentials` | [`Models.Credential`](../../doc/models/credential.md) | Optional | - |
| `SshKey` | `string` | Optional | SSH Private Key in PEM format. |

## Example (as JSON)

```json
{
  "endpoint": "https://charts.bitnami.com/bitnami",
  "name": "example-repo",
  "reacheability": "Internet",
  "type": "Git",
  "description": "description0",
  "revision": {
    "version": "version2",
    "additionalParams": [
      {
        "key": "key3",
        "value": "value5"
      },
      {
        "key": "key4",
        "value": "value6"
      }
    ]
  },
  "vendorInformation": {
    "id": "id0",
    "name": "name0",
    "primaryEmail": "primaryEmail8",
    "secondaryEmail": "secondaryEmail6",
    "contactNumber": "contactNumber4"
  },
  "tag": "tag6",
  "CACertificate": "CACertificate8"
}
```

