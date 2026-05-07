
# Cause Code Choice 3

## Structure

`CauseCodeChoice3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Impassability5` | `int` | Required | The value shall be set to:<br><br>- 0 `unavailable`              - in case further detailed information about the unmanaged road blockage is unavailable,<br>- 1 `flooding          `       - in case the road is affected by flooding,<br>- 2 `dangerOfAvalanches`       - in case the road is at risk of being affected or blocked by avalanches,<br>- 3 `blastingOfAvalanches`     - in case there is an active blasting of avalanches on or near the road,<br>- 4 `landslips`                - in case the road is affected by landslips,<br>- 5 `chemicalSpillage`         - in case the road is affected by chemical spillage,<br>- 6 `winterClosure`            - in case the road is impassable due to a winter closure.<br>- 7 `sinkhole`                 - in case the road is impassable due to large holes in the road surface.<br>- 8 `earthquakeDamage`         - in case the road is obstructed or partially obstructed because of damage caused by an earthquake.<br>- 9 `fallenTrees`              - in case the road is obstructed or partially obstructed by one or more fallen trees.<br>- 10 `rockfalls`               - in case the road is obstructed or partially obstructed due to fallen rocks.<br>- 11 `sewerOverflow`           - in case the road is obstructed or partially obstructed by overflows from one or more sewers.<br>- 12 `stormDamage`             - in case the road is obstructed or partially obstructed by debris caused by strong winds.<br>- 13 `subsidence`              - in case the road surface has sunken or collapsed in places.<br>- 14 `burstPipe`               - in case the road surface has sunken or collapsed in places due to burst pipes.<br>- 15 `burstWaterMain`          - in case the road is obstructed due to local flooding and/or subsidence.<br>- 16 `fallenPowerCables`       - in case the road is obstructed or partly obstructed by one or more fallen power cables.<br>- 17 `snowDrifts`              - in case the road is obstructed or partially obstructed by snow drifting in progress or patches of deep snow due to earlier drifting.<br>- 15-255                       - are reserved for future usage.<br><br>**Constraints**: `>= 0`, `<= 255` |

## Example (as JSON)

```json
{
  "impassability5": 218
}
```

