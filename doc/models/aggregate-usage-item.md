
# Aggregate Usage Item

Contains usage information per device.

## Structure

`AggregateUsageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Imei` | `string` | Optional | The International Mobile Equipment Identifier of the device. |
| `NumberOfSessions` | `int?` | Optional | Number of sessions established by the device reporting usage. |
| `BytesTransferred` | `int?` | Optional | The amount of data transferred by the device reporting usage, measured in Bytes. |

## Example (as JSON)

```json
{
  "imei": "15-digit IMEI",
  "numberOfSessions": 1,
  "bytesTransferred": 2057
}
```

