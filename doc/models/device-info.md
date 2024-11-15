
# Device Info

The devices that you want to locate. The array cannot contain more than 20 devices.

## Structure

`DeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Device identifier. |
| `Kind` | `string` | Required | Device identifier kind. |
| `Mdn` | `string` | Required | Device MDN. |

## Example (as JSON)

```json
{
  "id": "980003420535573",
  "kind": "imei",
  "mdn": "7892345678"
}
```

