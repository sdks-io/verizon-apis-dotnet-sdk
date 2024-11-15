
# Get Device List With Profiles Request

## Structure

`GetDeviceListWithProfilesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `ProvisioningStatusFilter` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `ProfileStatusFilter` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `CarrierNameFilter` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `DeviceFilter` | [`List<GIODeviceId>`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `50` |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "provisioningStatusFilter": "ACTIVE",
  "profileStatusFilter": "UNKNOWN",
  "carrierNameFilter": "carrierNameFilter2",
  "deviceFilter": [
    {
      "kind": "kind2",
      "id": "id4"
    }
  ]
}
```

