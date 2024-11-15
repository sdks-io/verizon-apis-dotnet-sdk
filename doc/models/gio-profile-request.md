
# GIO Profile Request

## Structure

`GIOProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Devices` | [`List<GIODeviceList>`](../../doc/models/gio-device-list.md) | Required | **Constraints**: *Maximum Items*: `100` |
| `AccountName` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9\-]{3,32}$` |
| `MdnZipCode` | `string` | Optional | **Constraints**: *Minimum Length*: `5`, *Maximum Length*: `5`, *Pattern*: `^[0-9]{5,5}$` |
| `ServicePlan` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        }
      ]
    }
  ],
  "accountName": "0000123456-00001",
  "mdnZipCode": "12345",
  "servicePlan": "service plan name"
}
```

