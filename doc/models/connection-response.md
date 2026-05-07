
# Connection Response

response for /clients/connection

## Structure

`ConnectionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MqttURL` | `string` | Required | The full MQTT URL including protocol, host, and port.<br><br>**Constraints**: *Maximum Length*: `1024`, *Pattern*: `^mqtt:\/\/[a-zA-Z0-9\.\-_:]+(:[0-9]+)?(\/[^\s]*)?$` |
| `Host` | `string` | Optional | The hostname of the MQTT broker to connect to.<br><br>**Constraints**: *Maximum Length*: `1024`, *Pattern*: `^[a-zA-Z0-9\.\-_]+$` |
| `Port` | `int?` | Optional | The port number of the MQTT broker.<br><br>**Constraints**: `>= 1`, `<= 65535` |

## Example (as JSON)

```json
{
  "MqttURL": "mqtt://imp-nyc-1.prod-us-east-1.thingspace.verizon.com:8883",
  "Host": "imp-nyc-1.prod-us-east-1.thingspace.verizon.com",
  "Port": 8883
}
```

