
# Provisioning History

The provisioning history of a specified device during a specified time period.

## Structure

`ProvisioningHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OccurredAt` | `string` | Optional | The date and time when the provisioning event occured. |
| `Status` | `string` | Optional | The success or failure of the provisioning event. |
| `EventBy` | `string` | Optional | The user who performed the provisioning event. |
| `EventType` | `string` | Optional | The provisioning action:Activate,Suspend,Restore,Deactivate,Device Move. |
| `Mdn` | `string` | Optional | The MDN assigned to the device after the provisioning event. |
| `Msisdn` | `string` | Optional | The MSISDN assigned to the device after the provisioning event. |
| `ServicePlan` | `string` | Optional | The service plan of the device after the provisioning event occurred. |
| `ExtendedAttributes` | [`List<Models.CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the event, as Key and Value pairs. |

## Example (as JSON)

```json
{
  "occurredAt": "2015-12-17T13:56:13-05:00",
  "status": "Success",
  "eventBy": "Harry Potter",
  "eventType": "Activation Confirmed",
  "servicePlan": "Tablet5GB",
  "mdn": "",
  "msisdn": "15086303371",
  "extendedAttributes": []
}
```

