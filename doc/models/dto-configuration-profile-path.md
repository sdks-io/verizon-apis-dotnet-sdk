
# Dto Configuration Profile Path

## Structure

`DtoConfigurationProfilePath`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The numeric account name, which must include leading zeros |
| `Resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |
| `Profile` | [`DtoProfile`](../../doc/models/dto-profile.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "resourceidentifier": {
    "id": "id4"
  },
  "profile": {
    "kind": "kind8",
    "version": "version6",
    "modelid": "modelid4",
    "name": "name0",
    "configuration": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

