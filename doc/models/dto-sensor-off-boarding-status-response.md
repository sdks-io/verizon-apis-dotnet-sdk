
# Dto Sensor Off Boarding Status Response

## Structure

`DtoSensorOffBoardingStatusResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Events` | [`List<DtoSensorBoardingEvent>`](../../doc/models/dto-sensor-boarding-event.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `Isstillregistered` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "isstillregistered": true,
  "events": [
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "errmsg": "errmsg2",
      "fields": null,
      "state": "state6",
      "transactionid": "transactionid8"
    },
    {
      "createdon": "2016-03-13T12:52:32.123Z",
      "errmsg": "errmsg2",
      "fields": null,
      "state": "state6",
      "transactionid": "transactionid8"
    }
  ]
}
```

