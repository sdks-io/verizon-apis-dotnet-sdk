
# Oauth Token

OAuth 2 Authorization endpoint response

## Structure

`OauthToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessToken` | `string` | Required | Access token |
| `TokenType` | `string` | Required | Type of access token |
| `ExpiresIn` | `long?` | Optional | Time in seconds before the access token expires |
| `Scope` | `string` | Optional | List of scopes granted<br>This is a space-delimited list of strings. |
| `Expiry` | `long?` | Optional | Time of token expiry as unix timestamp (UTC) |
| `RefreshToken` | `string` | Optional | Refresh token<br>Used to get a new access token when it expires. |

## Example (as JSON)

```json
{
  "access_token": "access_token8",
  "token_type": "token_type2",
  "expires_in": 226,
  "scope": "scope2",
  "expiry": 192,
  "refresh_token": "refresh_token0"
}
```

