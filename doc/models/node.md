
# Node

## Structure

`Node`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `ModifiedAt` | `string` | Optional | - |
| `NodeId` | `string` | Optional | - |
| `PrivateIp` | `string` | Optional | - |
| `NumCores` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `TotalMemory` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `ClusterId` | `string` | Optional | - |
| `Roles` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `100` |
| `Id` | `string` | Optional | - |
| `Approved` | `bool?` | Optional | - |
| `Status` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "num_cores": 8,
  "total_memory": 512,
  "approved": true,
  "name": "name0",
  "created_at": "created_at2",
  "modified_at": "modified_at6",
  "node_id": "node_id2",
  "private_ip": "private_ip0"
}
```

