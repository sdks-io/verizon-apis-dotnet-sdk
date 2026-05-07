
# Connection Response V3

response for api/v3/clients/connection

## Structure

`ConnectionResponseV3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MqttURLs` | `List<string>` | Required | Array of full MQTT URLs including protocol, host, and port for each available MEC.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `20`, *Maximum Length*: `1024`, *Pattern*: `^(http?mqtt)://[^\s/$.?#].[^\s]*$` |
| `Hosts` | `List<string>` | Optional | Array of hostnames corresponding to each MQTT URL.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `20`, *Maximum Length*: `1024`, *Pattern*: `^[a-zA-Z0-9\.\-_]+$` |
| `Ports` | `List<int>` | Optional | Array of port numbers corresponding to each MQTT URL.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `20`, `>= 1`, `<= 65535` |

## Example (as JSON)

```json
{
  "MqttURLs": [
    "MqttURLs4",
    "MqttURLs5",
    "MqttURLs6"
  ],
  "Hosts": [
    "imp-nyc-1.prod-us-east-1.thingspace.verizon.com"
  ],
  "Ports": [
    8883
  ]
}
```

