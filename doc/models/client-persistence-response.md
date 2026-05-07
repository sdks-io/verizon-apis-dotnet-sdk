
# Client Persistence Response

Response for /v2/clients/registration. It provides a generated device ID and the certificates needed to connect the ETX Message Exchange.

## Structure

`ClientPersistenceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceID` | `Guid?` | Optional | The generated ID (UUID v4) for the device. It can be used as:<br><br>- the MQTT Client ID when connecting to the Message Exchange system<br>- a parameter when asking for the connection endpoint<br>- a parameter when finishing the device registration<br>- a parameter when unregistering the device |
| `Certificate` | [`Certificate`](../../doc/models/certificate.md) | Optional | Structure for the credentials required to connect to the ETX MQTT Message Exchange. |
| `ClientType` | [`EtxClientTypeEnum?`](../../doc/models/etx-client-type-enum.md) | Optional | The type of the client that is to be registered. This is one of the major traffic participant groups considered in V2X communication. The system uses this value to define which topics the client will be able to publish and subscribe to.<br><br>Values:<br><br>- **Vehicle** - Vehicle with an enclosure around the passengers. (Subtypes: Motorcycle, PassengerCar, Truck, Bus, EmergencyVehicle, SchoolBus, MaintenanceVehicle)<br>- **VulnerableRoadUser** - Traffic participants without a protecting enclosure. (Subtypes: Bicycle, Pedestrian, Scooter)<br>- **TrafficLightController** - A Traffic light controller system. (Subtypes: NA)<br>- **InfrastructureSensor** - Sensors that are deployed in the infrastructure. (Subtypes: RoadSideUnit, Camera, Lidar, Radar, InductiveLoop, MagneticSensor)<br>- **OnboardSensor** - Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar, Radar)<br>- **Software** - A software system or application. (Subtypes: Platform, Application, NA) |
| `ClientSubtype` | [`ClientSubtypeEnum?`](../../doc/models/client-subtype-enum.md) | Optional | The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type. |
| `VendorID` | `string` | Optional | The ID the vendor wants its devices to be registered under.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Example (as JSON)

```json
{
  "DeviceID": "a4fcd16a-343d-4527-8203-2f46e3e4ff4b",
  "VendorID": "VerizonETX",
  "Certificate": {
    "cert.pem": "cert.pem8",
    "key.pem": "key.pem8",
    "ca.pem": "ca.pem6",
    "ExpirationTime": "2016-03-13T12:52:32.123Z"
  },
  "ClientType": "TrafficLightController",
  "ClientSubtype": "Bicycle"
}
```

