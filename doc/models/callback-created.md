
# Callback Created

## Structure

`CallbackCreated`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The numeric name of the account and must include leading zeroes. |
| `Name` | `string` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. |
| `Url` | `string` | Optional | The address of the callback listening service where the ThingSpace Platform will send callback messages for the service type. |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "name": "BullseyeReporting",
  "url": "https://tsustgtests.mocklab.io/notifications/bullseye"
}
```

