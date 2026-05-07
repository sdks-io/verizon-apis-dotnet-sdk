
# Node Offset Point LL

The NodeOffsetPointLL data frame presents a structure to hold 64 bits sized data frames for a single node geometry path. Nodes are described in terms of latitude and longitude.

## Structure

`NodeOffsetPointLL`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NodeLatLon` | [`NodeLLmD64b`](../../doc/models/node-l-lm-d64-b.md) | Required | A 64-bit node type with lat-long values expressed in standard SAE 1/10th of a microdegree. |

## Example (as JSON)

```json
{
  "node-LatLon": {
    "lon": 40,
    "lat": 10
  }
}
```

