# Device-Role-Controller

```csharp
DeviceRoleController deviceRoleController = client.DeviceRoleController;
```

## Class Name

`DeviceRoleController`


# Get ACL Rules by Vendor Id

This API allows the user to get the access control rules defined for them.

```csharp
GetACLRulesByVendorIdAsync(
    string vendorID)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorID` | `string` | Query, Required | The user's Vendor ID<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DeviceRole>](../../doc/models/device-role.md).

## Example Usage

```csharp
string vendorID = "TestVendor";
try
{
    ApiResponse<List<DeviceRole>> result = await deviceRoleController.GetACLRulesByVendorIdAsync(vendorID);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 401 | Unauthorized | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 406 | Not Acceptable | `ApiException` |
| 429 | Too many requests | `ApiException` |
| Default | unexpected error | `ApiException` |

