
# Cause Code Choice

## Structure

`CauseCodeChoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TrafficCondition1` | `int` | Required | The value shall be set to:<br><br>- 0 `unavailable`                  - in case further detailed information on the traffic condition is unavailable,<br>- 1 `increasedVolumeOfTraffic`     - in case the type of traffic condition is increased traffic volume,<br>- 2 `trafficJamSlowlyIncreasing`   - in case the type of traffic condition is a traffic jam which volume is increasing slowly,<br>- 3 `trafficJamIncreasing`         - in case the type of traffic condition is a traffic jam which volume is increasing,<br>- 4 `trafficJamStronglyIncreasing` - in case the type of traffic condition is a traffic jam which volume is strongly increasing,<br>- 5 `trafficJam`         `         - in case the type of traffic condition is a traffic jam and no further detailed information about its volume is available,<br>- 6 `trafficJamSlightlyDecreasing` - in case the type of traffic condition is a traffic jam which volume is decreasing slowly,<br>- 7 `trafficJamDecreasing`         - in case the type of traffic condition is a traffic jam which volume is decreasing,<br>- 8 `trafficJamStronglyDecreasing` - in case the type of traffic condition is a traffic jam which volume is decreasing rapidly,<br>- 9 `trafficJamStable`             - in case the traffic condition is a traffic jam with stable volume,<br>- 10-255: reserved for future usage.<br><br>**Constraints**: `>= 0`, `<= 255` |

## Example (as JSON)

```json
{
  "trafficCondition1": 0
}
```

