
# GPU

GPU resources of a service profile.

## Structure

`GPU`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MinCoreClockMHz` | `int?` | Optional | Minimum Core Clock value in megahertz.<br>**Constraints**: `>= 1`, `<= 10000` |
| `MinMemoryClockMHz` | `int?` | Optional | Minimum Memory Clock value in megahertz.<br>**Constraints**: `>= 1`, `<= 100000` |
| `MinBandwidthGBs` | `int?` | Optional | Minimum GPU bandwidth in GB/s.<br>**Constraints**: `>= 1`, `<= 1000` |
| `MinTFLOPS` | `int?` | Optional | Minimum Floating Point Operations Per Second in Teraflops.<br>**Constraints**: `>= 1`, `<= 100` |

## Example (as JSON)

```json
{
  "minCoreClockMHz": 1,
  "minMemoryClockMHz": 35740,
  "minBandwidthGBs": 588,
  "minTFLOPS": 33
}
```

