
# Search Device by Property Response

The device identifier and fields to match in the search.

## Structure

`SearchDeviceByPropertyResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Billingaccountid` | `string` | Optional | Billing account ID of the resource. |
| `Createdon` | `string` | Optional | The date the resource was created. |
| `Eventretention` | `string` | Optional | - |
| `Fields` | [`Fields1`](../../doc/models/fields-1.md) | Optional | - |
| `Iccid` | `string` | Optional | Cellular SIM card identifier. |
| `Id` | `string` | Optional | ThingSpace unique ID for the device that was added. |
| `Imei` | `string` | Optional | 4G hardware device identifier. |
| `Kind` | `string` | Optional | Identifies the resource kind. |
| `Lastupdated` | `string` | Optional | The date the resource was last updated. |
| `Providerid` | `string` | Optional | The device’s service provider. |
| `Refid` | `string` | Optional | The value of the refidtype identifier. |
| `Refidtype` | `string` | Optional | The device identifier type used to refer to this device. |
| `State` | `string` | Optional | Service state of the device. |
| `Version` | `string` | Optional | Version of the underlying schema resource. |
| `Versionid` | `string` | Optional | The version of the resource. |

## Example (as JSON)

```json
{
  "billingaccountid": "1223334444-00001",
  "createdon": "12/19/2018 06:45:41",
  "eventretention": "90",
  "iccid": "20332350053095597842",
  "id": "64612cb3-3685-6dad-fd2b-ea1adeb5a269",
  "imei": "320778042285497",
  "kind": "ts.device",
  "lastupdated": "12/19/2018 06:45:41",
  "providerid": "8a314f07-849e-6568-e3c1-8381c1f61bfc",
  "refid": "20332350053095597842",
  "refidtype": "iccid",
  "state": "registered",
  "version": "1.0",
  "versionid": "b3cdaddb-0359-11e9-aba2-02420a4e1b0a",
  "fields": {
    "item": {
      "acceleration": {
        "x": "x6",
        "y": "y4",
        "z": "z6"
      },
      "battery": "battery0",
      "humidity": "humidity4",
      "light": "light6",
      "pressure": "pressure2"
    }
  }
}
```

