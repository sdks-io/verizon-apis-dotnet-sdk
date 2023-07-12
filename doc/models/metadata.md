
# Metadata

## Structure

`Metadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `ModifiedAt` | `string` | Optional | - |
| `Labels` | [`Models.MetadataLabel`](../../doc/models/metadata-label.md) | Optional | - |
| `Annotations` | [`Models.MetadataAnnotation`](../../doc/models/metadata-annotation.md) | Optional | - |
| `OrganizationID` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `PartnerID` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `ProjectID` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `Id` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "displayName": "displayName2",
  "createdAt": "createdAt6",
  "modifiedAt": "modifiedAt6",
  "labels": {
    "alpha.rafay.io/cluster-name": "alpha.rafay.io/cluster-name4",
    "alpha.rafay.io/instance-id": "alpha.rafay.io/instance-id6",
    "alpha.rafay.io/nodegroup-name": "alpha.rafay.io/nodegroup-name2",
    "beta.kubernetes.io/arch": "beta.kubernetes.io/arch6",
    "beta.kubernetes.io/instance-type": "beta.kubernetes.io/instance-type6"
  }
}
```

