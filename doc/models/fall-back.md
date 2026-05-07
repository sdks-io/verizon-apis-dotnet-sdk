
# Fall Back

## Structure

`FallBack`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Devices` | [`List<List<FallBackDevices>>`](../../doc/models/containers/fall-back-devices.md) | Optional | This is 2d List of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` |
| `AccountName` | `string` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |

## Example (as JSON)

```json
{
  "devices": [
    [
      [
        {
          "kind": "kind6",
          "id": "id8"
        },
        {
          "kind": "kind6",
          "id": "id8"
        }
      ],
      [
        {
          "kind": "kind6",
          "id": "id8"
        },
        {
          "kind": "kind6",
          "id": "id8"
        },
        {
          "kind": "kind6",
          "id": "id8"
        }
      ]
    ],
    [
      [
        {
          "kind": "kind6",
          "id": "id8"
        },
        {
          "kind": "kind6",
          "id": "id8"
        }
      ],
      [
        {
          "kind": "kind6",
          "id": "id8"
        },
        {
          "kind": "kind6",
          "id": "id8"
        },
        {
          "kind": "kind6",
          "id": "id8"
        }
      ]
    ]
  ],
  "accountName": "accountName4"
}
```

