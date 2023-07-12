
# Attribute Setting

Describes an attribute being observed and the frequency with which the attribute is being observed.

## Structure

`AttributeSetting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`Models.AttributeIdentifierEnum?`](../../doc/models/attribute-identifier-enum.md) | Optional | Attribute identifier. |
| `MValue` | `string` | Optional | Attribute value. |
| `CreatedOn` | `DateTime?` | Optional | Date and time request was created. |
| `IsObservable` | `bool?` | Optional | Is the attribute observable? |
| `IsObserving` | `bool?` | Optional | Is the attribute being observed? |
| `Frequency` | [`Models.NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |

## Example (as JSON)

```json
{
  "name": "MANUFACTURER",
  "value": "string",
  "createdOn": "2019-09-07T23:08:03.532Z",
  "isObservable": true,
  "isObserving": true,
  "frequency": {
    "value": 5,
    "unit": "SECOND"
  }
}
```

