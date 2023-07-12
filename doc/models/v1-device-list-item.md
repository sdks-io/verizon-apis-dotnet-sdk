
# V1 Device List Item

A JSON object for each device that was included in the request, showing the device IMEI, the status of the addition or removal, and additional information about the status.

## Structure

`V1DeviceListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Optional | Device IMEI. |
| `Status` | `string` | Optional | Whether the device was successfully added or removed from the campaign. |
| `Reason` | `string` | Optional | Additional details about the status. |

## Example (as JSON)

```json
{
  "deviceId": "900000000000001",
  "status": "LicenseAssignSuccess",
  "Reason": "Success"
}
```

