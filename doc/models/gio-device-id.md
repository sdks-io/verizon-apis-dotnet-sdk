
# GIO Device Id

## Structure

`GIODeviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `6`, *Pattern*: `^[A-Za-z]{3,6}$` |
| `Id` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |

## Example (as JSON)

```json
{
  "kind": "eid",
  "id": "12345678901234567890123456789012"
}
```

