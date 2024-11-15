# 5G Edge Platforms

```csharp
M5gEdgePlatformsController m5gEdgePlatformsController = client.M5gEdgePlatformsController;
```

## Class Name

`M5gEdgePlatformsController`

## Methods

* [List MEC Platforms](../../doc/controllers/5g-edge-platforms.md#list-mec-platforms)
* [List Regions](../../doc/controllers/5g-edge-platforms.md#list-regions)


# List MEC Platforms

Returns a list of optimal MEC Platforms where you can register your deployed application. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - region plus Service Profile ID and subscriber density (density is optional but recommended), region plus UEIdentity(Including UEIdentity Type) or Service Profile ID plus UEIdentity(Including UEIdentity Type).

```csharp
ListMECPlatformsAsync(
    string region = null,
    string serviceProfileId = null,
    int? subscriberDensity = null,
    Models.UserEquipmentIdentityTypeEnum? uEIdentityType = null,
    string uEIdentity = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `region` | `string` | Query, Optional | MEC region name. Current valid values are US_WEST_2 and US_EAST_1. |
| `serviceProfileId` | `string` | Query, Optional | Unique identifier of the service profile.<br>**Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |
| `subscriberDensity` | `int?` | Query, Optional | Minimum number of 4G/5G subscribers per square kilometer.<br>**Constraints**: `>= 1`, `<= 100` |
| `uEIdentityType` | [`UserEquipmentIdentityTypeEnum?`](../../doc/models/user-equipment-identity-type-enum.md) | Query, Optional | Type of User Equipment identifier used in `UEIdentity`. |
| `uEIdentity` | `string` | Query, Optional | The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

[`Task<ApiResponse<Models.ListMECPlatformsResult>>`](../../doc/models/list-mec-platforms-result.md)

## Example Usage

```csharp
string region = "US_WEST_2";
UserEquipmentIdentityTypeEnum? uEIdentityType = UserEquipmentIdentityTypeEnum.Ipaddress;
string uEIdentity = "2600:1010:b1d0:0000:0000:0000:0000:0012";
try
{
    ApiResponse<ListMECPlatformsResult> result = await m5gEdgePlatformsController.ListMECPlatformsAsync(
        region,
        null,
        null,
        uEIdentityType,
        uEIdentity
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "MECPlatforms": [
    {
      "ern": "5x4VBwmfZbzSL3",
      "zone": "e5oV52kMGjDLhnJSsLJZL",
      "region": "US_WEST_2",
      "status": "unknown"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# List Regions

List the geographical regions available, based on the user's bearer token. **Note:** Country code, Metropolitan area, Area and Zone are future functionality and will currently return a "null" value.

```csharp
ListRegionsAsync()
```

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

[`Task<ApiResponse<Models.ListRegionsResult>>`](../../doc/models/list-regions-result.md)

## Example Usage

```csharp
try
{
    ApiResponse<ListRegionsResult> result = await m5gEdgePlatformsController.ListRegionsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "regions": [
    {
      "regionId": "consectetur",
      "name": "US_EAST_1",
      "countryCode": "nr",
      "metro": "e1D",
      "area": "IdUESF"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |

