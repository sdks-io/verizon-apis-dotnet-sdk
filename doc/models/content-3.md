
# Content 3

## Structure

`Content3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SpeedLimit` | [`List<TextPhraseOrITIS2>`](../../doc/models/containers/text-phrase-or-itis-2.md) | Required | A data frame to allow sequences of ITIS codes, short text strings, and numerical values to be expressed in the normal ITIS vocabulary method and pattern. Note that the allowed text strings are more limited than the normal ITIS format in order to conserve bandwidth.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `16` |

## Example (as JSON)

```json
{
  "speedLimit": [
    {
      "item": {
        "itis": 10
      }
    },
    {
      "item": {
        "itis": 10
      }
    },
    {
      "item": {
        "itis": 10
      }
    }
  ]
}
```

