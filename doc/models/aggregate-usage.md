
# Aggregate Usage

## Structure

`AggregateUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`GIODeviceId`](../../doc/models/gio-device-id.md) | Optional | - |
| `AccountName` | `string` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Earliest` | `string` | Optional | The start date of the time period queried as "$datetime"<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Latest` | `string` | Optional | The end date of the time period being queried as "$datetime"<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Example (as JSON)

```json
{
  "deviceId": {
    "kind": "kind8",
    "id": "id0"
  },
  "accountName": "accountName6",
  "earliest": "earliest2",
  "latest": "latest6"
}
```

