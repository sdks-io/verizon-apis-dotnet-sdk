
# V2 List of Licenses to Remove Request

License cancellation candidate devices.

## Structure

`V2ListOfLicensesToRemoveRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | List creation option. |
| `Count` | `int?` | Optional | The number of devices. |
| `DeviceList` | `List<string>` | Required | Device IMEI list. |

## Example (as JSON)

```json
{
  "type": "append",
  "count": 2,
  "deviceList": [
    "990003425730535",
    "990000473475989"
  ]
}
```

