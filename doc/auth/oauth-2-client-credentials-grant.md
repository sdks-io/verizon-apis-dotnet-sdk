
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for thingspace_oauth.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| OAuthClientId | `string` | OAuth 2 Client ID | `OauthClientId` | `OauthClientId` |
| OAuthClientSecret | `string` | OAuth 2 Client Secret | `OauthClientSecret` | `OauthClientSecret` |
| OAuthToken | `Models.OauthToken` | Object for storing information about the OAuth token | `OauthToken` | `OauthToken` |
| OAuthScopes | `List<Models.OauthScopeThingspaceOauthEnum>` | List of scopes that apply to the OAuth token | `OauthScopes` | `OauthScopes` |
| OAuthClockSkew | `TimeSpan?` | Clock skew time in seconds applied while checking the OAuth Token expiry. | `OAuthClockSkew` | `OAuthClockSkew` |
| OAuthTokenProvider | `Func<ThingspaceOauthManager, OauthToken, Task<OauthToken>>` | Registers a callback for oAuth Token Provider used for automatic token fetching/refreshing. | `OAuthTokenProvider` | `OAuthTokenProvider` |
| OAuthOnTokenUpdate | `Action<OauthToken>` | Registers a callback for token update event. | `OAuthOnTokenUpdate` | `OAuthOnTokenUpdate` |



**Note:** Auth credentials can be set using `ThingspaceOauthCredentials` in the client builder and accessed through `ThingspaceOauthCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* autentication, are called.

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauthCredentials(
        new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OauthScopes(
            new List<OauthScopeThingspaceOauthEnum>
            {
                OauthScopeThingspaceOauthEnum.Discoveryread,
                OauthScopeThingspaceOauthEnum.Serviceprofileread,
            })
        .Build())
    .Build();
```



Your application can also manually provide an OAuthToken using the setter `oauthToken` in `ThingspaceOauthModel` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

You must have initialized the client with scopes for which you need permission to access.

### Scopes

Scopes enable your application to only request access to the resources it needs while enabling users to control the amount of access they grant to your application. Available scopes are defined in the [`OauthScopeThingspaceOauthEnum`](../../doc/models/oauth-scope-thingspace-oauth-enum.md) enumeration.

| Scope Name | Description |
|  --- | --- |
| `DISCOVERYREAD` | Grant read-only access to discovery data |
| `SERVICEPROFILEREAD` | Grant read-only access to service profile data |
| `SERVICEPROFILEWRITE` | Grant write access to service profile data |
| `SERVICEREGISTRYREAD` | Grant read-only access to Service registry data |
| `SERVICEREGISTRYWRITE` | Grant write access to Service registry data |
| `TS.MEC.FULLACCESS` | Full access for /serviceprofiles and /serviceendpoints. |
| `TS.MEC.LIMITACCESS` | Limited access. Will not allow use of /serviceprofiles and /serviceendpoints but will allow discovery. |
| `TS.APPLICATION.RO` |  |
| `EDGEDISCOVERYREAD` | Read access to the discovery service |
| `EDGESERVICEPROFILEREAD` | Read access to the service profile service |
| `EDGESERVICEPROFILEWRITE` | Write access to the service profile service |
| `EDGESERVICEREGISTRYREAD` | Read access to the service registry service |
| `EDGESERVICEREGISTRYWRITE` | Write access to the service registry service |
| `READ` | read access |
| `WRITE` | read/write access |

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauthCredentials(
        new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OauthScopes(
            new List<OauthScopeThingspaceOauthEnum>
            {
                OauthScopeThingspaceOauthEnum.Discoveryread,
                OauthScopeThingspaceOauthEnum.Serviceprofileread,
            })
        .oauthOnTokenUpdate(token -> 
        {
            // It will be triggered whenever the token gets updated
            SaveTokenToDatabase(token);
        })
        .Build())
    .Build();
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `oauthTokenProvider` in `ThingspaceOauthModel` builder along with the other auth parameters before creating the client:

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauthCredentials(
        new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OauthScopes(
            new List<OauthScopeThingspaceOauthEnum>
            {
                OauthScopeThingspaceOauthEnum.Discoveryread,
                OauthScopeThingspaceOauthEnum.Serviceprofileread,
            })
        .oauthTokenProvider(async (token, credentialsManager) =>
        {
            // Add the callback handler to provide a new OAuth token
            // It will be triggered whenever the lastOAuthToken is undefined or expired
            return LoadTokenFromDatabase() ?? await FetchTokenAsync()
        })
        .Build())
    .Build();
```


