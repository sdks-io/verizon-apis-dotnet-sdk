
# Get Wireless Coverage Request FWA

Get wireless coverage FWA.

## Structure

`GetWirelessCoverageRequestFWA`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account name.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` |
| `RequestType` | `string` | Required | Type of request.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{3,12}$` |
| `LocationType` | `string` | Required | Type of location detail.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{3,12}$` |
| `Locations` | [`Locations`](../../doc/models/locations.md) | Required | Location details. |
| `NetworkTypesList` | [`List<NetworkType>`](../../doc/models/network-type.md) | Required | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "requestType": "FWA",
  "locationType": "ADDRESS",
  "locations": {
    "addressList": [
      {
        "addressLine1": "addressLine10",
        "addressLine2": "addressLine28",
        "city": "city8",
        "state": "state4",
        "country": "country2"
      }
    ]
  },
  "networkTypesList": [
    {
      "networkType": "LTE"
    }
  ]
}
```

