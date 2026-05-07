
# Item

## Structure

`Item`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Itis` | `int` | Required | The ITIS Code that describes the alert/danger/hazard. All ITS standards use the same types here to explain the type of the alert/danger/hazard involved.<br><br>The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard. This is a set of over 1000 items which are used to encode common events and list items in ITS.<br><br>**Constraints**: `>= 0`, `<= 65535` |

## Example (as JSON)

```json
{
  "itis": 124
}
```

