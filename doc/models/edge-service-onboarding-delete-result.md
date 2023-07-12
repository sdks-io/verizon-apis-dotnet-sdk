
# Edge Service Onboarding Delete Result

Response to delete a service.

## Structure

`EdgeServiceOnboardingDeleteResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Optional | Message confirms if the action was success or failure.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]!,+\-=_:.&*%\s]+$` |
| `Status` | `string` | Optional | Will provide the current status of the action.<br>**Constraints**: *Maximum Length*: `15`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]!,+\-=_:.&*%\s]+$` |
| `SubStatus` | `string` | Optional | Displays the proper response with status.<br>**Constraints**: *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9?$@#()\[\]!,+\-=_:.&*%\s]+$` |

## Example (as JSON)

```json
{
  "message": "service deleted succesfully",
  "status": "success",
  "subStatus": "service delete - success"
}
```

