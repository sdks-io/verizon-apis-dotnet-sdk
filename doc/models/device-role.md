
# Device Role

The access rule (DeviceRole object) defines the topics the application or device can publish or subscribe to. It also defines how many parallel subscriptions one device or application can have and how fast it can publish messages.

## Structure

`DeviceRole`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The unique name of the access rule.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1000`, *Pattern*: `^[a-zA-Z0-9_$\{\}:.-]+$` |
| `SubscribeLimit` | `int?` | Optional | The maximum number of subscriptions that one application or device can make.<br><br>**Default**: `50`<br><br>**Constraints**: `>= 0`, `<= 2147483647` |
| `PublishRateLimit` | `int?` | Optional | The maximum rate that one application or device can publish messages per seconds.<br><br>**Default**: `15`<br><br>**Constraints**: `>= 0`, `<= 2147483647` |
| `Publish` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1000`, *Unique Items Required*, *Minimum Length*: `1`, *Maximum Length*: `1000`, *Pattern*: `^[a-zA-Z0-9_$\{\}*\/^\|.-]+$` |
| `Subscribe` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1000`, *Unique Items Required*, *Minimum Length*: `1`, *Maximum Length*: `1000`, *Pattern*: `^[a-zA-Z0-9_$\{\}*\/^\|.-]+$` |

## Example (as JSON)

```json
{
  "name": "ts.device.mqtt.imp:Software.Application.TestVendor",
  "subscribeLimit": 50,
  "publishRateLimit": 15,
  "publish": [
    "vzimp/1/GeoRelevance/Vehicle/Bus/TestVendor/j2735_gr/BSM"
  ],
  "subscribe": [
    "vzimp/1/GeoRelevance/Vehicle/Bus/TestVendor/j2735_gr/MAP/*"
  ]
}
```

