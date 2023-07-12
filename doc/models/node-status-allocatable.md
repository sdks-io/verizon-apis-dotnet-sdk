
# Node Status Allocatable

## Structure

`NodeStatusAllocatable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CpuCount` | `int?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `EphemeralStorageKB` | `long?` | Optional | **Constraints**: `>= 0`, `<= 1024` |
| `MemoryKB` | `long?` | Optional | **Constraints**: `>= 0`, `<= 1024` |

## Example (as JSON)

```json
{
  "cpuCount": 140,
  "ephemeralStorageKB": 28,
  "memoryKB": 242
}
```

