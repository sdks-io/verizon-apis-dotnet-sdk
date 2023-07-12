
# Uploads Activates Device Request

The request body identifies the devices to upload.

## Structure

`UploadsActivatesDeviceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The name of a billing account. An account name is usually numeric, and must include any leading zeros. |
| `EmailAddress` | `string` | Required | The email address that the report should be sent to when the upload is complete. |
| `DeviceSku` | `string` | Required | The stock keeping unit that identifies the type of devices in the upload and activation. |
| `UploadType` | `string` | Required | The format of the device identifiers in the upload and activation. |
| `ServicePlan` | `string` | Required | The service plan code that you want to assign to all specified devices. |
| `CarrierIpPoolName` | `string` | Optional | The pool from which your device IP addresses is derived. |
| `MdnZipCode` | `string` | Required | The Zip code of the location where the line of service is primarily used, or a Zip code that you have been told to use with these devices. |
| `Devices` | [`List<Models.DeviceList>`](../../doc/models/device-list.md) | Required | The devices to upload, specified by device IDs in a format matching uploadType. |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "emailAddress": "bob@mycompany.com",
  "deviceSku": "VZW123456",
  "uploadType": "IMEI ICCID Pair",
  "servicePlan": "15MBShr",
  "carrierIpPoolName": "The carrier pool name",
  "mdnZipCode": "92222",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id6",
          "kind": "imei"
        },
        {
          "id": "id7",
          "kind": "eid"
        },
        {
          "id": "id8",
          "kind": "esn"
        }
      ]
    }
  ]
}
```

