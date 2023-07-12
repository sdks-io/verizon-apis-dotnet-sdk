
# Create Service Profile Request

## Structure

`CreateServiceProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name for a service profile.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `ServiceName` | `string` | Optional | Service being deployed.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `ServiceVersion` | `string` | Optional | Service version being deployed.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `CustomerID` | `string` | Optional | Id of particular customer.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `LinkedServiceInstances` | [`List<Models.LinkedServiceInstance>`](../../doc/models/linked-service-instance.md) | Optional | - |
| `AccessIntents` | [`Models.AccessIntents`](../../doc/models/access-intents.md) | Optional | - |
| `PlacementIntents` | [`Models.PlacementIntents`](../../doc/models/placement-intents.md) | Optional | - |
| `DeploymentLocations` | [`List<Models.DeploymentLocation>`](../../doc/models/deployment-location.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": "mongo-pmec-profile-mdp7",
  "serviceName": "mongodb-customer-prerun",
  "serviceVersion": "1.0.0",
  "customerID": "customerID8",
  "linkedServiceInstances": [
    {
      "id": "00000a3b-0000-0000-0000-000000000000"
    },
    {
      "id": "00000a3c-0000-0000-0000-000000000000"
    }
  ]
}
```

