
# Usage History

## Structure

`UsageHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BytesUsed` | `int?` | Optional | - |
| `Serviceplan` | `string` | Optional | - |
| `SmsUsed` | `int?` | Optional | - |
| `MoSMS` | `int?` | Optional | - |
| `MtSMS` | `int?` | Optional | - |
| `Source` | `string` | Optional | - |
| `EventDateTime` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "bytesUsed": 3072,
  "serviceplan": "The serviceplan name",
  "source": "Raw Usage",
  "eventDateTime": "08/15/2021 00:00:00",
  "smsUsed": 250,
  "moSMS": 100,
  "mtSMS": 92
}
```

