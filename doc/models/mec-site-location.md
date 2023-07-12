
# MEC Site Location

## Structure

`MECSiteLocation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ern` | `string` | Optional | Edge Resource Number.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `City` | `string` | Optional | **Constraints**: *Maximum Length*: `15`, *Pattern*: `^[A-Za-z]{1,15}$` |
| `Latitude` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `Longitude` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `Csp` | `string` | Optional | Cloud Service Provider.<br>**Constraints**: *Maximum Length*: `64` |

## Example (as JSON)

```json
{
  "city": "Atlanta",
  "csp": "AWS_WL",
  "ern": "us-east-1-wl1-atl-wlz-1",
  "latitude": "33.75056710067694",
  "longitude": "-84.38593033921234"
}
```

