
# Subscription

Subscription resource definition.

## Structure

`Subscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Configurationfailures` | `int?` | Optional | The number of streaming failures due to faulty configuration. |
| `Createdon` | `string` | Optional | The number of streaming failures due to faulty configuration. |
| `Delegateid` | `string` | Optional | Not currently used. |
| `Description` | `string` | Optional | Description of the subscription. |
| `Disabled` | `bool?` | Optional | Whether the subscription is currently sending data. |
| `Email` | `string` | Optional | The address to which any error reports should be delivered. |
| `Filter` | `string` | Optional | Filter for events. |
| `Id` | `string` | Optional | ThingSpace unique ID for the subscription that was created. |
| `Kind` | `string` | Optional | Identifies the resource kind. |
| `Laststreamingstatus` | `string` | Optional | Possible values: success or fail. |
| `Laststreamingtime` | `string` | Optional | The date and time that the last stream send was attempted. |
| `Lastupdated` | `string` | Optional | The date the resource was last updated. |
| `Name` | `string` | Optional | Name of the subscription. |
| `Networkfailures` | `int?` | Optional | The number of failures due to network problems. |
| `Streamfailures` | `int?` | Optional | - |
| `Streamkind` | `string` | Optional | The event type that will be sent in the data stream. |
| `Targetid` | `string` | Optional | Target to be used for dispatching events. |
| `Targettype` | `string` | Optional | - |
| `Version` | `string` | Optional | Version of the underlying schema resource. |
| `Versionid` | `string` | Optional | The version of the resource. |

## Example (as JSON)

```json
{
  "configurationfailures": 0,
  "createdon": "2018-12-21T05:05:02.134Z",
  "delegateid": "00000000-0000-0000-0000-000000000000",
  "id": "d8c145dd-6948-67ec-ed9b-6a298806bb4a",
  "kind": "ts.subscription",
  "laststreamingstatus": "",
  "laststreamingtime": "0001-01-01T00:00:00Z",
  "lastupdated": "2018-12-21T05:22:12.178Z",
  "networkfailures": 0,
  "streamfailures": 0,
  "streamkind": "ts.event",
  "targetid": "4e211a0e-e39d-6c32-e15b-d6f07f9e2ec8",
  "version": "1.0",
  "versionid": "5ed6063f-04e0-11e9-8279-02420a5e1b0b",
  "description": "description4",
  "disabled": false
}
```

