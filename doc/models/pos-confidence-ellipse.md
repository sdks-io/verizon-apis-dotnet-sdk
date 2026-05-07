
# Pos Confidence Ellipse

## Structure

`PosConfidenceEllipse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SemiMajorConfidence` | `int` | Required | **Constraints**: `>= 0`, `<= 4095` |
| `SemiMinorConfidence` | `int` | Required | **Constraints**: `>= 0`, `<= 4095` |
| `SemiMajorOrientation` | `int` | Required | **Constraints**: `>= 0`, `<= 3601` |

## Example (as JSON)

```json
{
  "semiMajorConfidence": 194,
  "semiMinorConfidence": 192,
  "semiMajorOrientation": 22
}
```

