# Sensor Insights Notification Groups

```csharp
SensorInsightsNotificationGroupsController sensorInsightsNotificationGroupsController = client.SensorInsightsNotificationGroupsController;
```

## Class Name

`SensorInsightsNotificationGroupsController`

## Methods

* [Sensor Insights List Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-list-notification-group-request)
* [Sensor Insights Update Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-update-notification-group-request)
* [Sensor Insights Create Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-create-notification-group-request)
* [Sensor Insights Delete Notification Group](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-delete-notification-group)
* [Sensor Insights Add Users to Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-add-users-to-notification-group-request)
* [Sensor Insights Remove Users from Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-remove-users-from-notification-group-request)


# Sensor Insights List Notification Group Request

```csharp
SensorInsightsListNotificationGroupRequestAsync(
    Models.DtoListNotificationGroupRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListNotificationGroupRequest`](../../doc/models/dto-list-notification-group-request.md) | Body, Required | Retrieve a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DtoNotificationGroupResponseEntity>](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```csharp
DtoListNotificationGroupRequest body = new DtoListNotificationGroupRequest
{
    Accountname = "0000123456-00001",
    Filter = new DtoFilter
    {
        Expand = "device detail(s)",
        Limitnumber = 100,
        Nopagination = true,
        Page = "The number of pages",
        Pagenumber = 100,
        Projection = new List<string>
        {
            "specific device fields requested",
        },
        Selection = new Dictionary<string, object>
        {
            ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
};

try
{
    ApiResponse<List<DtoNotificationGroupResponseEntity>> result = await sensorInsightsNotificationGroupsController.SensorInsightsListNotificationGroupRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
    if (e is M500ManagementErrorException)
    {
       // TODO: Handle M500ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Update Notification Group Request

```csharp
SensorInsightsUpdateNotificationGroupRequestAsync(
    Models.DtoUpdateNotificationGroupRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoUpdateNotificationGroupRequest`](../../doc/models/dto-update-notification-group-request.md) | Body, Required | Partially update a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoNotificationGroupResponseEntity](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```csharp
DtoUpdateNotificationGroupRequest body = new DtoUpdateNotificationGroupRequest
{
    MGroup = new DtoNotificationGroupRequestEntity
    {
        Description = "a short description",
        Groupemail = "email@domain.com",
        Name = "User defined name of the record",
    },
    Accountname = "0000123456-00001",
    Id = "7b0b9c53-eeee-ffff-gggg-bde5e44f4b12",
    Userids = new List<string>
    {
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
};

try
{
    ApiResponse<DtoNotificationGroupResponseEntity> result = await sensorInsightsNotificationGroupsController.SensorInsightsUpdateNotificationGroupRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
    if (e is M500ManagementErrorException)
    {
       // TODO: Handle M500ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Create Notification Group Request

```csharp
SensorInsightsCreateNotificationGroupRequestAsync(
    Models.DtoCreateNotificationGroupRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoCreateNotificationGroupRequest`](../../doc/models/dto-create-notification-group-request.md) | Body, Required | Create a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoNotificationGroupResponseEntity](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```csharp
DtoCreateNotificationGroupRequest body = new DtoCreateNotificationGroupRequest
{
    MGroup = new DtoNotificationGroupRequestEntity
    {
        Description = "a short description",
        Groupemail = "email@domain.com",
        Name = "User defined name of the record",
    },
    Accountname = "0000123456-00001",
    Userids = new List<string>
    {
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
};

try
{
    ApiResponse<DtoNotificationGroupResponseEntity> result = await sensorInsightsNotificationGroupsController.SensorInsightsCreateNotificationGroupRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M500ManagementErrorException)
    {
       // TODO: Handle M500ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Delete Notification Group

```csharp
SensorInsightsDeleteNotificationGroupAsync(
    Models.DtoDeleteNotificationGroupRequest payload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `payload` | [`DtoDeleteNotificationGroupRequest`](../../doc/models/dto-delete-notification-group-request.md) | Query, Required | Payload for the delete request. |

## Response Type

`Task`

## Example Usage

```csharp
DtoDeleteNotificationGroupRequest payload = new DtoDeleteNotificationGroupRequest
{
    Accountname = "0000123456-00001",
    Force = true,
    Id = "6737ca22-eeee-ffff-gggg-84c09f2ede8e",
};

try
{
    await sensorInsightsNotificationGroupsController.SensorInsightsDeleteNotificationGroupAsync(payload);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights Add Users to Notification Group Request

```csharp
SensorInsightsAddUsersToNotificationGroupRequestAsync(
    Models.DtoAddUsersToNotificationGroupRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoAddUsersToNotificationGroupRequest`](../../doc/models/dto-add-users-to-notification-group-request.md) | Body, Required | Add users to a notification group |

## Response Type

`Task`

## Example Usage

```csharp
DtoAddUsersToNotificationGroupRequest body = new DtoAddUsersToNotificationGroupRequest
{
    Accountname = "0000123456-00001",
    Id = "45f1a56e-eeee-ffff-gggg-68cb994feb5f",
    Userids = new List<string>
    {
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
};

try
{
    await sensorInsightsNotificationGroupsController.SensorInsightsAddUsersToNotificationGroupRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
    if (e is M500ManagementErrorException)
    {
       // TODO: Handle M500ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Remove Users from Notification Group Request

```csharp
SensorInsightsRemoveUsersFromNotificationGroupRequestAsync(
    Models.DtoRemoveUsersFromNotificationGroupRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoRemoveUsersFromNotificationGroupRequest`](../../doc/models/dto-remove-users-from-notification-group-request.md) | Body, Required | Remove users from a notification group |

## Response Type

`Task`

## Example Usage

```csharp
DtoRemoveUsersFromNotificationGroupRequest body = new DtoRemoveUsersFromNotificationGroupRequest
{
    Accountname = "0000123456-00001",
    Id = "111538a8-eeee-ffff-gggg-3b72804403e8",
    Userids = new List<string>
    {
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
};

try
{
    await sensorInsightsNotificationGroupsController.SensorInsightsRemoveUsersFromNotificationGroupRequestAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is M400ManagementErrorException)
    {
       // TODO: Handle M400ManagementErrorException exception here
    }
    if (e is ManagementErrorException)
    {
       // TODO: Handle ManagementErrorException exception here
    }
    if (e is M403ManagementErrorException)
    {
       // TODO: Handle M403ManagementErrorException exception here
    }
    if (e is M404ManagementErrorException)
    {
       // TODO: Handle M404ManagementErrorException exception here
    }
    if (e is M500ManagementErrorException)
    {
       // TODO: Handle M500ManagementErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

