
# MEC Performance Query Result

Result of the query for obtaining MEC performance metrics.

## Structure

`MECPerformanceQueryResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the parameter. |
| `Data` | `List<string>` | Optional | Parameter values. |

## Example (as JSON)

```json
{
  "name": "NetworkAvailability",
  "data": [
    "100",
    "percent",
    "high"
  ]
}
```

