
# Resource Device

## Structure

`ResourceDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountclientid` | `string` | Optional | Not used in this release, future functionality |
| `Billingaccountid` | `string` | Optional | The billing account ID. This is the same value as the Account ID |
| `Chipset` | `string` | Optional | The Identifier of chipset used by the device |
| `Createdon` | `DateTime` | Required | Timestamp of the record |
| `Customdata` | `object` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |
| `Description` | `string` | Optional | a short description |
| `Esn` | `int?` | Optional | The Electronic Serial Number (ESN) of the device |
| `Fields` | [`DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search |
| `Foreignid` | `string` | Required | UUID of the ECPD account the user belongs to |
| `Hardwareversion` | `string` | Optional | The manufacturer's hardware version of the device |
| `Iccid` | `string` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) |
| `Id` | `string` | Optional | UUID of the user record, assigned at creation |
| `Imei` | `int?` | Optional | The 15-digit International Mobile Equipment ID |
| `Imsi` | `int?` | Optional | The 64-bit International Mobile Subscriber Identity |
| `Lastupdated` | `DateTime` | Required | Timestamp of the record |
| `Licenses` | `List<string>` | Optional | licenses assigned to the device<br><br>**Constraints**: *Maximum Items*: `100` |
| `Mac` | `string` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX |
| `Manufacturer` | `string` | Optional | The manufacturer of the device |
| `Meid` | `string` | Optional | The 56-bit Mobile Equipment ID |
| `Msisdn` | `string` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number |
| `Name` | `string` | Optional | User defined name of the record |
| `Parentdeviceid` | `string` | Optional | this field is applicable for BLE sensors. This represents the value of parent gateway device |
| `Productmodel` | `string` | Optional | The device model name |
| `Providerid` | `string` | Optional | The id of the provider who is responible for talking to the device |
| `Qrcode` | `string` | Optional | The numeric value of the Quick Response (QR) code |
| `Refid` | `string` | Optional | The device reference ID |
| `Refidtype` | `string` | Optional | The type of value represented by `refid` |
| `Serial` | `string` | Optional | The device's serial number |
| `Services` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `100` |
| `Sku` | `string` | Optional | The Stock Keeping Unit (SKU) number of the device |
| `Softwareversion` | `string` | Optional | the current device software version |
| `State` | `string` | Required | The current status of the device or transaction and will be `success` or `failed` |
| `Version` | `string` | Optional | The resource version |
| `Versionid` | `string` | Required | The UUID of the resource version |
| `Eventretention` | `int?` | Optional | Data retention period |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "billingaccountid": "0000123456-00001",
  "chipset": "The chipset used by the device",
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "fields": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "hardwareversion": "1.0",
  "iccid": "The 20-digit ICCID",
  "lastupdated": "10/02/2023 15:46:34",
  "mac": "The Media Access Control (MAC) address",
  "manufacturer": "REOLINK",
  "meid": "The 56-bit Mobile Equipment ID",
  "msisdn": "The Mobile Station International Subscriber Directory Number",
  "name": "name of the record",
  "parentdeviceid": "a gateway UUID",
  "productmodel": "Model name of the device",
  "providerid": "Verizon Wireless",
  "qrcode": "The Quick Response (QR) code",
  "refid": "P3730-1422323050860",
  "refidtype": "The type of value represented by `refid`",
  "serial": "The device's serial number",
  "sku": "The Stock Keeping Unit (SKU) number",
  "softwareversion": "the current device software version",
  "state": "success",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "eventretention": 90,
  "customdata": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    },
    "key1": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

