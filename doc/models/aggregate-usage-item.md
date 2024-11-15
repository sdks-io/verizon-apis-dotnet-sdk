
# Aggregate Usage Item

Contains usage information per device.

## Structure

`AggregateUsageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Imei` | `string` | Optional | International Mobile Equipment Identifier. This is the ID of the device reporting usage. |
| `NumberOfSessions` | `int?` | Optional | Number of sessions established by the device reporting usage. |
| `BytesTransferred` | `int?` | Optional | The amount of data transferred by the device reporting usage, measured in Bytes. |

## Example (as JSON)

```json
{
  "imei": "709312034493372",
  "numberOfSessions": 1,
  "bytesTransferred": 2057
}
```

