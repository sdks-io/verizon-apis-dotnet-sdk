
# Header

The header of the DENM PDU.

## Structure

`Header`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProtocolVersion` | [`ProtocolVersionEnum`](../../doc/models/protocol-version-enum.md) | Required | The protocol version of the DENM. |
| `MessageId` | [`MessageIdEnum`](../../doc/models/message-id-enum.md) | Required | The type of ITIS message (typically 1 for DENM). |
| `StationId` | `int` | Required | The station identifier of the ITS-S. |

## Example (as JSON)

```json
{
  "protocolVersion": 2,
  "messageId": 1,
  "stationId": 12345
}
```

