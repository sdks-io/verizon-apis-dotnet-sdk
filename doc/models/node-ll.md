
# Node LL

The NodeLL data frame presents a structure to hold data for a signal node point in a lane. Each selected node has a complete lat-long representation.

## Structure

`NodeLL`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Delta` | [`NodeOffsetPointLL`](../../doc/models/node-offset-point-ll.md) | Required | The NodeOffsetPointLL data frame presents a structure to hold 64 bits sized data frames for a single node geometry path. Nodes are described in terms of latitude and longitude. |

## Example (as JSON)

```json
{
  "delta": {
    "node-LatLon": {
      "lon": 40,
      "lat": 10
    }
  }
}
```

