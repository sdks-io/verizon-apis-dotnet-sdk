
# Node Status

## Structure

`NodeStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `string` | Optional | - |
| `Conditions` | [`List<Models.StatusConditionItem>`](../../doc/models/status-condition-item.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `NodeInfo` | [`Models.NodeStatusInfo`](../../doc/models/node-status-info.md) | Optional | - |
| `Capacity` | [`Models.NodeStatusCapacity`](../../doc/models/node-status-capacity.md) | Optional | - |
| `Allocatable` | [`Models.NodeStatusAllocatable`](../../doc/models/node-status-allocatable.md) | Optional | - |
| `Allocated` | [`Models.NodeStatusAllocated`](../../doc/models/node-status-allocated.md) | Optional | - |
| `Ips` | [`List<Models.IP>`](../../doc/models/ip.md) | Optional | **Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "state": "state4",
  "conditions": [
    {
      "type": "type9",
      "status": "status7",
      "lastHeartbeatTime": "2016-03-13T12:52:32.123Z",
      "lastTransitionTime": "2016-03-13T12:52:32.123Z",
      "reason": "reason3"
    },
    {
      "type": "type8",
      "status": "status6",
      "lastHeartbeatTime": "2016-03-13T12:52:32.123Z",
      "lastTransitionTime": "2016-03-13T12:52:32.123Z",
      "reason": "reason2"
    },
    {
      "type": "type7",
      "status": "status5",
      "lastHeartbeatTime": "2016-03-13T12:52:32.123Z",
      "lastTransitionTime": "2016-03-13T12:52:32.123Z",
      "reason": "reason1"
    }
  ],
  "nodeInfo": {
    "machineID": "machineID0",
    "systemUUID": "systemUUID0",
    "bootID": "bootID8",
    "kernelVersion": "kernelVersion2",
    "osImage": "osImage0"
  },
  "capacity": {
    "cpuCount": 150,
    "ephemeralStorageKB": 18,
    "memoryKB": 252
  },
  "allocatable": {
    "cpuCount": 126,
    "ephemeralStorageKB": 42,
    "memoryKB": 228
  }
}
```

