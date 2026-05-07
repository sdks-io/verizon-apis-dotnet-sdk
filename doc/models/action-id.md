
# Action Id

## Structure

`ActionId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OriginatingStationId` | `int` | Required | Unique ID for originating station. |
| `SequenceNumber` | `int` | Required | Counter used to differenciate multiple DENMs from same station. |

## Example (as JSON)

```json
{
  "originatingStationId": 80,
  "sequenceNumber": 150
}
```

