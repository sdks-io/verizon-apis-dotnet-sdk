
# Management

This represent the management container describing the meta information about the event, such as the detection time, the event's location, the source of the event, and the notification distance.

## Structure

`Management`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ActionId` | [`ActionId`](../../doc/models/action-id.md) | Required | - |
| `DetectionTime` | `long` | Required | Timestamp in milliseconds since start of 2004 when event was first generated<br><br>**Constraints**: `>= 0`, `<= 4398046511103` |
| `ReferenceTime` | `long` | Required | Timestamp in milliseconds since start of 2004 when the DENM message was generated.<br><br>**Constraints**: `>= 0`, `<= 4398046511103` |
| `EventPosition` | [`EventPosition`](../../doc/models/event-position.md) | Required | - |
| `AwarenessDistance` | [`AwarenessDistanceEnum?`](../../doc/models/awareness-distance-enum.md) | Optional | Specifies how far the event is relevant to. |
| `StationType` | `int` | Required | The type of ITS station that generated the DENM. The value shall be set to:<br><br>- 0 `unknown`          - information about the ITS-S context is not provided,<br>- 1 `pedestrian`       - ITS-S carried by human being not using a mechanical device for their trip (VRU profile 1),<br>- 2 `cyclist`          - ITS-S mounted on non-motorized unicycles, bicycles , tricycles, quadracycles (VRU profile 2),<br>- 3 `moped`            - ITS-S mounted on light motor vehicles with less than four wheels as defined in UNECE/TRANS/WP.29/78/Rev.4 [16]<br>  class L1, L2 (VRU Profile 3),<br>- 4 `motorcycles`      - ITS-S mounted on motor vehicles with less than four wheels as defined in UNECE/TRANS/WP.29/78/Rev.4 [16]<br>  class L3, L4, L5, L6, L7 (VRU Profile 3),<br>- 5 `passengerCar`     - ITS-S mounted on small passenger vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class M1,<br>- 6 `bus`              - ITS-S mounted on large passenger vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class M2, M3,<br>- 7 `lightTruck`       - ITS-S mounted on light Goods Vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class N1,<br>- 8 `heavyTruck`       - ITS-S mounted on Heavy Goods Vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class N2 and N3,<br>- 9 `trailer`          - ITS-S mounted on an unpowered vehicle that is intended to be towed by a powered vehicle as defined in<br>  UNECE/TRANS/WP.29/78/Rev.4 [16] class O,<br>- 10 `specialVehicles` - ITS-S mounted on vehicles which have special purposes other than the above (e.g. moving road works vehicle),<br>- 11 `tram`            - ITS-S mounted on a vehicle which runs on tracks along public streets,<br>- 12 `lightVruVehicle` - ITS-S carried by a human being traveling on light vehicle , incl. possible use of roller skates or skateboards (VRU profile 2),<br>- 13 `animal`          - ITS-S carried by an animal presenting a safety risk to other road users e.g. domesticated dog in a city or horse (VRU Profile 4),<br>- 14                   - reserved for future usage,<br>- 15 `roadSideUnit`    - ITS-S mounted on an infrastructure typically positioned outside of the drivable roadway (e.g. on a gantry, on a pole,<br>  on a stationary road works trailer); the infrastructure is static during the entire operation period of the ITS-S (e.g. no stop and go activity),<br>- 16-255               - are reserved for future usage.<br><br>**Constraints**: `>= 0`, `<= 255` |

## Example (as JSON)

```json
{
  "actionId": {
    "originatingStationId": 28,
    "sequenceNumber": 42
  },
  "detectionTime": 123456789,
  "referenceTime": 123456789,
  "eventPosition": {
    "latitude": 198,
    "longitude": 234,
    "positionConfidenceEllipse": {
      "semiMajorConfidence": 16,
      "semiMinorConfidence": 114,
      "semiMajorOrientation": 100
    },
    "altitude": {
      "altitudeValue": 236,
      "altitudeConfidence": "alt-000-01"
    }
  },
  "stationType": 58,
  "awarenessDistance": "lessThan200m"
}
```

