
# Target

Target resource definition.

## Structure

`Target`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | `string` | Optional | The endpoint for data streams. |
| `Addressscheme` | `string` | Optional | The transport format. |
| `Billingaccountid` | `string` | Optional | The billing account ID. |
| `Createdon` | `string` | Optional | The date the resource was created. |
| `Externalid` | `string` | Optional | Security identification string. |
| `Id` | `string` | Optional | ThingSpace unique ID for the target that was created. |
| `Kind` | `string` | Optional | Identifies the resource kind. Targets are ts.target. |
| `Lastupdated` | `string` | Optional | The date the resource was last updated. |
| `Name` | `string` | Optional | Name of the target. |
| `Region` | `string` | Optional | AWS region value. |
| `Version` | `string` | Optional | Version of the underlying schema resource. |
| `Versionid` | `string` | Optional | The version of the resource. |
| `Description` | `string` | Optional | Description of the target. |

## Example (as JSON)

```json
{
  "address": "arn:aws:iam::252156542789:role/ThingSpace",
  "addressscheme": "streamawsiot",
  "createdon": "2019-01-24T19:06:43.577Z",
  "externalid": "lJZnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
  "id": "cea170cc-a58f-6531-fc4b-fae1ceb1a6c8",
  "kind": "ts.target",
  "lastupdated": "2019-01-24T19:32:31.841Z",
  "name": "AWS Target",
  "region": "us-east-1",
  "version": "1.0",
  "versionid": "caf85ff7-200e-11e9-a85b-02420a621e0a",
  "billingaccountid": "billingaccountid4"
}
```

