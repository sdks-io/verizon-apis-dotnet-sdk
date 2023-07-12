
# Services Profile Registration

## Structure

`ServicesProfileRegistration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Id of the service profile. |
| `Name` | `string` | Optional | Name for a service profile.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `ServiceName` | `string` | Optional | Service being deployed.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `ServiceVersion` | `string` | Optional | Service version being deployed.<br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `CurrentVersion` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `Version` | `string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[\w\d_\.\#\$\%\|^\&\*\@\!\-]{1,64}$` |
| `State` | [`Models.ServicesProfileRegistrationStateEnum?`](../../doc/models/services-profile-registration-state-enum.md) | Optional | - |
| `CustomerID` | `string` | Optional | Id of particular customer.<br>**Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `CreatedBy` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `CreatedAt` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `LastUpdatedBy` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `LastUpdatedAt` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `LinkedServiceInstances` | [`List<Models.LinkedServiceInstance>`](../../doc/models/linked-service-instance.md) | Optional | - |
| `AccessIntents` | [`Models.AccessIntents`](../../doc/models/access-intents.md) | Optional | - |
| `PlacementIntents` | [`Models.PlacementIntents`](../../doc/models/placement-intents.md) | Optional | - |
| `DeploymentLocations` | [`List<Models.DeploymentLocation>`](../../doc/models/deployment-location.md) | Optional | - |

## Example (as JSON)

```json
{
  "accessIntents": {},
  "createdAt": "2022-08-03T03:43:17.504Z",
  "createdBy": "acme-user",
  "customerID": "acme",
  "deploymentLocations": [],
  "id": "6789409c-12c3-4fc9-b64f-71d1611c4f09",
  "lastUpdatedAt": "2022-08-03T03:43:17.504Z",
  "linkedServiceInstances": [],
  "name": "mongo-pmec-profile-mdp7",
  "placementIntents": {
    "intentChain": [
      {
        "input": {
          "deploymentLocations": [
            {
              "csp": "AWS_WL",
              "region": "US_WEST_2",
              "zoneId": [
                "us-west-2-wl1-den-wlz-1"
              ]
            }
          ]
        },
        "name": "Compliance"
      }
    ]
  },
  "serviceName": "mongodb-customer-prerun",
  "serviceVersion": "1.0.0",
  "state": "DRAFT",
  "version": "1.0.0",
  "currentVersion": "currentVersion0"
}
```

