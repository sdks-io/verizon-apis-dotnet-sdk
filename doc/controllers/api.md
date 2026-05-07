# API

```csharp
APIController aPIController = client.APIController;
```

## Class Name

`APIController`

## Methods

* [Get Configuration List](../../doc/controllers/api.md#get-configuration-list)
* [Get Configuration](../../doc/controllers/api.md#get-configuration)
* [Create Configuration](../../doc/controllers/api.md#create-configuration)
* [Update Configuration](../../doc/controllers/api.md#update-configuration)
* [Delete Configuration](../../doc/controllers/api.md#delete-configuration)
* [Register ETX Device](../../doc/controllers/api.md#register-etx-device)
* [Renew ETX Device](../../doc/controllers/api.md#renew-etx-device)
* [Unregister ETX Device](../../doc/controllers/api.md#unregister-etx-device)
* [Get ETX Device Certificate](../../doc/controllers/api.md#get-etx-device-certificate)
* [Retrieve MQTTURL](../../doc/controllers/api.md#retrieve-mqtturl)
* [Retrieve MQTTURL Multi MEC](../../doc/controllers/api.md#retrieve-mqtturl-multi-mec)


# Get Configuration List

This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
GetConfigurationListAsync(
    string vendorID)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorID` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.ConfigurationListItem>](../../doc/models/configuration-list-item.md).

## Example Usage

```csharp
string vendorID = "VerizonETX";
try
{
    ApiResponse<List<ConfigurationListItem>> result = await aPIController.GetConfigurationListAsync(vendorID);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EtxResponseErrorException)
    {
       // TODO: Handle EtxResponseErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 404 | Configuration not found | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too many requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | unexpected error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Get Configuration

This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
GetConfigurationAsync(
    string id,
    string vendorID)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `vendorID` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GeoFenceConfigurationResponse](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```csharp
string id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713";
string vendorID = "VerizonETX";
try
{
    ApiResponse<GeoFenceConfigurationResponse> result = await aPIController.GetConfigurationAsync(
        id,
        vendorID
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EtxResponseErrorException)
    {
       // TODO: Handle EtxResponseErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 404 | Configuration not found | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too many requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | unexpected error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Create Configuration

This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
CreateConfigurationAsync(
    string vendorID,
    Models.GeoFenceConfigurationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorID` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`GeoFenceConfigurationRequest`](../../doc/models/geo-fence-configuration-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GeoFenceConfigurationResponse](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```csharp
string vendorID = "VerizonETX";
GeoFenceConfigurationRequest body = new GeoFenceConfigurationRequest
{
    GeoFence = new EtxGeoFence
    {
        Type = TypeEnum.FeatureCollection,
        Features = new List<EtxFeature>
        {
            new EtxFeature
            {
                Type = Type1Enum.Feature,
                Geometry = Geometry.FromLineString(
                    new LineString
                    {
                        Type = Type2Enum.LineString,
                        Coordinates = new List<List<double>>
                        {
                            new List<double>
                            {
                                51.53,
                                51.54,
                            },
                            new List<double>
                            {
                                51.53,
                                51.54,
                            },
                        },
                    }
                ),
                Properties = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
    },
    Messages = new List<Message4>
    {
        Message4.FromMessage(
            new Message
            {
                IsPrivate = false,
                RoadUserType = new List<RoadUserTypesEnum>
                {
                    RoadUserTypesEnum.VulnerableRoadUser,
                },
                TriggerConditions = new List<TriggerConditionEnum>
                {
                    TriggerConditionEnum.Crossing,
                },
                Generic = new Generic
                {
                    MessageType = "messageType4",
                    MessageFormat = "messageFormat6",
                    Payload = "payload0",
                },
            }
        ),
    },
    IsActive = false,
    MessageStandard = MessageStandardEnum.Sae,
};

try
{
    ApiResponse<GeoFenceConfigurationResponse> result = await aPIController.CreateConfigurationAsync(
        vendorID,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EtxResponseErrorException)
    {
       // TODO: Handle EtxResponseErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 403 | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too many requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | unexpected error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Update Configuration

This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
UpdateConfigurationAsync(
    string vendorID,
    string id,
    Models.GeoFenceConfigurationUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorID` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `body` | [`GeoFenceConfigurationUpdateRequest`](../../doc/models/geo-fence-configuration-update-request.md) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string vendorID = "VerizonETX";
string id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713";
GeoFenceConfigurationUpdateRequest body = new GeoFenceConfigurationUpdateRequest
{
    MessageStandard = MessageStandardEnum.Sae,
};

try
{
    await aPIController.UpdateConfigurationAsync(
        vendorID,
        id,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EtxResponseErrorException)
    {
       // TODO: Handle EtxResponseErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 403 | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 404 | Configuration not found | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too many requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | unexpected error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Delete Configuration

This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
DeleteConfigurationAsync(
    string vendorID,
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorID` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |

## Response Type

`Task`

## Example Usage

```csharp
string vendorID = "VerizonETX";
string id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713";
try
{
    await aPIController.DeleteConfigurationAsync(
        vendorID,
        id
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is EtxResponseErrorException)
    {
       // TODO: Handle EtxResponseErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too many requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | unexpected error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Register ETX Device

With this API call the user (client) registers its device or software service to the ETX system. Therefore, when a connection is initiated from the device or software service to the ETX system along with the credential provided by this registration call, then the connection will be authorized.

- The user can register multiple devices or software services, which can all be used at the same time.
- There rules set in the system that limit the type and subtype of the clients that are allowed to be registered under the VendorID. The rules are created based ont he agreement between the Vendor and Verizon.
- The user will only be able to register a limited number of devices or software services under the same VendorID. This registration limit is specified by the agreement between the Vendor and Verizon.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
RegisterETXDeviceAsync(
    Models.ClientRegistrationRequestV2 body,
    Guid? xTransactionId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ClientRegistrationRequestV2`](../../doc/models/client-registration-request-v2.md) | Body, Required | - |
| `xTransactionId` | `Guid?` | Header, Optional | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ClientRegistrationResponse](../../doc/models/client-registration-response.md).

## Example Usage

```csharp
ClientRegistrationRequestV2 body = new ClientRegistrationRequestV2
{
    ClientType = EtxClientTypeEnum.TrafficLightController,
    ClientSubtype = ClientSubtypeEnum.Scooter,
    VendorID = "VerizonETX",
    DeviceID = new Guid("a4fcd16a-343d-4527-8203-2f46e3e4ff4b"),
    IMEI = "12-345678-901234-5",
    ICCID = "89345678901234567890",
    IMSI = "123456789012345",
};

Guid? xTransactionId = new Guid("123e4567-e89b-12d3-a456-426614174000");
try
{
    ApiResponse<ClientRegistrationResponse> result = await aPIController.RegisterETXDeviceAsync(
        body,
        xTransactionId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ETXRespondingErrorException)
    {
       // TODO: Handle ETXRespondingErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 401 | Unauthorized Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 403 | Forbidden Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 429 | Too Many Requests | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 503 | Internal Server Error | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| Default | Forbidden | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |


# Renew ETX Device

With this API call the user (client) can:

- renew the certificate of a device or software service in the ETX system if the original certificate has expired. If the client's certificate expired or going to expire within 30 days and new certificate will be issued. If the certificate expires more than 30 days, the current certificate will be returned to the client.
- complete its device or software service registration to the ETX system if the original registration request was not successful because of a pending certificate generation. Whenever the user receives a "client registration is pending" response (HTTP 202) from POST /clients/registration call. The client should initiate this PUT API call to finish the registration process and get the required certificate.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
RenewETXDeviceAsync(
    Guid etxDeviceID,
    string etxVendorID,
    Guid? xTransactionId = null,
    object body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `etxDeviceID` | `Guid` | Header, Required | - |
| `etxVendorID` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `xTransactionId` | `Guid?` | Header, Optional | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |
| `body` | `object` | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ClientRegistrationResponse](../../doc/models/client-registration-response.md).

## Example Usage

```csharp
Guid etxDeviceID = new Guid("a4fcd16a-343d-4527-8203-2f46e3e4ff4b");
string etxVendorID = "VerizonETX";
Guid? xTransactionId = new Guid("123e4567-e89b-12d3-a456-426614174000");
try
{
    ApiResponse<ClientRegistrationResponse> result = await aPIController.RenewETXDeviceAsync(
        etxDeviceID,
        etxVendorID,
        xTransactionId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ETXRespondingErrorException)
    {
       // TODO: Handle ETXRespondingErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 401 | Unauthorized Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 403 | Forbidden Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 429 | Too Many Requests | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 503 | Internal Server Error | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| Default | Forbidden | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |


# Unregister ETX Device

With this API call the user (client) can unregister its devices and software services from the ETX system. The unregistered devices and services will no longer be able to use the ETX Message Exchange.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
UnregisterETXDeviceAsync(
    string etxVendorID,
    List<Guid> deviceIDs,
    Guid? xTransactionId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `etxVendorID` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `deviceIDs` | `List<Guid>` | Query, Required | The list of device IDs and software service IDs to be unregistered<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `100` |
| `xTransactionId` | `Guid?` | Header, Optional | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |

## Response Type

`Task`

## Example Usage

```csharp
string etxVendorID = "VerizonETX";
List<Guid> deviceIDs = new List<Guid>
{
    new Guid("0000225a-0000-0000-0000-000000000000"),
};

Guid? xTransactionId = new Guid("123e4567-e89b-12d3-a456-426614174000");
try
{
    await aPIController.UnregisterETXDeviceAsync(
        etxVendorID,
        deviceIDs,
        xTransactionId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ETXRespondingErrorException)
    {
       // TODO: Handle ETXRespondingErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 401 | Unauthorized Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 403 | Forbidden Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 429 | Too Many Requests | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 503 | Internal Server Error | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| Default | Forbidden | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |


# Get ETX Device Certificate

With this API call the user can check the certificate of the device. At least one of the DeviceID, IMEI, ICCID or IMSI is required to make the call.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
GetETXDeviceCertificateAsync(
    Models.EtxID etxID,
    Guid? xTransactionId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `etxID` | [`EtxID`](../../doc/models/etx-id.md) | Query, Required | One of the following IDs is required- DeviceID, IMEI, ICCID, IMSI. If more than one ID is provided, the API will return the certificate for the first ID found. The IDs are evaluated in the following order: DeviceID, IMEI, ICCID, IMSI. If the first provided ID is not found, the API will return an error. |
| `xTransactionId` | `Guid?` | Header, Optional | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ClientPersistenceResponse](../../doc/models/client-persistence-response.md).

## Example Usage

```csharp
EtxID etxID = new EtxID
{
    DeviceID = new Guid("a4fcd16a-343d-4527-8203-2f46e3e4ff4b"),
    IMEI = "12-345678-901234-5",
    ICCID = "89345678901234567890",
    IMSI = "123456789012345",
};

Guid? xTransactionId = new Guid("123e4567-e89b-12d3-a456-426614174000");
try
{
    ApiResponse<ClientPersistenceResponse> result = await aPIController.GetETXDeviceCertificateAsync(
        etxID,
        xTransactionId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ETXRespondingErrorException)
    {
       // TODO: Handle ETXRespondingErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 401 | Unauthorized | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 403 | Forbidden Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 404 | Not Found | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 429 | Too Many Requests | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 500 | Internal server Error | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| Default | Forbidden | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |


# Retrieve MQTTURL

With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
RetrieveMQTTURLAsync(
    string etxVendorID,
    Models.ConnectionRequest body,
    Guid? xTransactionId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `etxVendorID` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`ConnectionRequest`](../../doc/models/connection-request.md) | Body, Required | - |
| `xTransactionId` | `Guid?` | Header, Optional | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ConnectionResponse](../../doc/models/connection-response.md).

## Example Usage

```csharp
string etxVendorID = "VerizonETX";
ConnectionRequest body = new ConnectionRequest
{
    DeviceID = new Guid("976c4bad-03d3-4dcb-9688-ee57db7890e4"),
    Geolocation = new Geolocation
    {
        Latitude = 42.36,
        Longitude = -71.06,
    },
    NetworkType = NetworkTypeEnum.NonVZ,
};

Guid? xTransactionId = new Guid("123e4567-e89b-12d3-a456-426614174000");
try
{
    ApiResponse<ConnectionResponse> result = await aPIController.RetrieveMQTTURLAsync(
        etxVendorID,
        body,
        xTransactionId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ETXRespondingErrorException)
    {
       // TODO: Handle ETXRespondingErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 401 | Unauthorized | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 403 | Forbidden Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 429 | Too Many Requests | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 503 | Internal server Error | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| Default | Forbidden | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |


# Retrieve MQTTURL Multi MEC

With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.

If there are multiple MECs that serve the location of the client all options are provided in the response, and the client is free to choose which MEC they want to connect.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```csharp
RetrieveMQTTURLMultiMECAsync(
    string etxVendorID,
    Models.ConnectionRequest body,
    Guid? xTransactionId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `etxVendorID` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`ConnectionRequest`](../../doc/models/connection-request.md) | Body, Required | - |
| `xTransactionId` | `Guid?` | Header, Optional | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ConnectionResponseV3](../../doc/models/connection-response-v3.md).

## Example Usage

```csharp
string etxVendorID = "VerizonETX";
ConnectionRequest body = new ConnectionRequest
{
    DeviceID = new Guid("976c4bad-03d3-4dcb-9688-ee57db7890e4"),
    Geolocation = new Geolocation
    {
        Latitude = 42.36,
        Longitude = -71.06,
    },
    NetworkType = NetworkTypeEnum.NonVZ,
};

Guid? xTransactionId = new Guid("123e4567-e89b-12d3-a456-426614174000");
try
{
    ApiResponse<ConnectionResponseV3> result = await aPIController.RetrieveMQTTURLMultiMECAsync(
        etxVendorID,
        body,
        xTransactionId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ETXRespondingErrorException)
    {
       // TODO: Handle ETXRespondingErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 401 | Unauthorized | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 403 | Forbidden Request | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 429 | Too Many Requests | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| 503 | Internal server Error | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |
| Default | Forbidden | [`ETXRespondingErrorException`](../../doc/models/etx-responding-error-exception.md) |

