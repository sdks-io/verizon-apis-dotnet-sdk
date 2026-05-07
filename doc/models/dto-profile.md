
# Dto Profile

## Structure

`DtoProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Optional | profile kind |
| `Version` | `string` | Optional | The resource version |
| `Modelid` | `string` | Optional | device model id |
| `Name` | `string` | Optional | profile name |
| `Configuration` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "kind": "the kind of profile being created",
  "version": "1.0",
  "modelid": "00000000-0000-0000-0000-000000000019",
  "name": "Demo Entry sensor 1730928792",
  "configuration": {
    "randomInt": 21,
    "resportingInterval": 24
  }
}
```

