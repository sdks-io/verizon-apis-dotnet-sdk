
# Item 3

## Structure

`Item3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Text` | `string` | Required | Text phrase provides very short sections of text interspersed between the ITIS codes to create phrases. In general, this is used for expressing proper nouns, such as street names reflecting local expressions that do not appear in the ITIS tables.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |

## Example (as JSON)

```json
{
  "text": "text4"
}
```

