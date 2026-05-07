
# Dto Overwrite Rule Request

## Structure

`DtoOverwriteRuleRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountname` | `string` | Optional | The numeric account name, which must include leading zeros |
| `Resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |
| `Rule` | [`ResourceRule`](../../doc/models/resource-rule.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "resourceidentifier": {
    "id": "id4"
  },
  "rule": {
    "accountclientid": "accountclientid4",
    "billingaccountid": "billingaccountid6",
    "createdon": "2016-03-13T12:52:32.123Z",
    "description": "description0",
    "deviceid": "deviceid0",
    "disabled": false,
    "foreignid": "foreignid8",
    "lastupdated": "2016-03-13T12:52:32.123Z",
    "rulechain": {
      "key1": "val1",
      "key2": "val2"
    },
    "versionid": "versionid2"
  }
}
```

