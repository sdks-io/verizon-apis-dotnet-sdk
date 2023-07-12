# OAuth Authorization

```csharp
OauthAuthorizationController oauthAuthorizationController = client.OauthAuthorizationController;
```

## Class Name

`OauthAuthorizationController`


# Request Token

Create a new OAuth 2 token.

:information_source: **Note** This endpoint does not require authentication.

```csharp
RequestTokenAsync(
    string authorization,
    string scope = null,
    Dictionary<string, object> fieldParameters = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Authorization header in Basic auth format |
| `scope` | `string` | Form, Optional | Requested scopes as a space-delimited list. |
| `fieldParameters` | `Dictionary<string, object>` | Optional | Pass additional field parameters. |

## Response Type

[`Task<ApiResponse<Models.OauthToken>>`](../../doc/models/oauth-token.md)

## Example Usage

```csharp
string authorization = "Authorization8";
Dictionary<string, object> fieldParameters = new Dictionary<string, object>
{
    ["key0"] = ApiHelper.JsonDeserialize<object>("\"additionalFieldParams9\""),
};

try
{
    ApiResponse<OauthToken> result = await oauthAuthorizationController.RequestTokenAsync(authorization, null, fieldParameters);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | OAuth 2 provider returned an error. | [`OauthProviderException`](../../doc/models/oauth-provider-exception.md) |
| 401 | OAuth 2 provider says client authentication failed. | [`OauthProviderException`](../../doc/models/oauth-provider-exception.md) |

