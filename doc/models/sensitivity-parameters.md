
# Sensitivity Parameters

Details for sensitivity parameters.

## Structure

`SensitivityParameters`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AbnormalMaxValue` | `double?` | Optional | The maximum value of the threshold in the units being measured. |
| `EnableAbnormal` | `bool?` | Optional | If abnormal values are being monitored.<br />true - Monitor for abnormal values<br />false - Do not monitor for abnormal values. |
| `EnableVeryAbnormal` | `bool?` | Optional | If very abnormal values are being monitored.<br />true - Monitor for very abnormal values<br />false - Do not monitor for very abnormal values. |
| `VeryAbnormalMaxValue` | `double?` | Optional | The maximum value of the threshold in the units being measured. |

## Example (as JSON)

```json
{
  "abnormalMaxValue": 1.1,
  "enableAbnormal": true,
  "enableVeryAbnormal": true,
  "veryAbnormalMaxValue": 0.55
}
```

