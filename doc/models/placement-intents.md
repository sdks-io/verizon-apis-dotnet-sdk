
# Placement Intents

## Structure

`PlacementIntents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IsPlacementAtLaunchEnabled` | `bool?` | Optional | **Default**: `false` |
| `GroupId` | `string` | Optional | **Constraints**: *Maximum Length*: `500`, *Pattern*: `^(.*)$` |
| `IntentChain` | [`List<Models.IntentChainItem>`](../../doc/models/intent-chain-item.md) | Optional | - |

## Example (as JSON)

```json
{
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
  ],
  "isPlacementAtLaunchEnabled": false,
  "groupId": "groupId2"
}
```

