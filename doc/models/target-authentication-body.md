
# Target Authentication Body

## Structure

`TargetAuthenticationBody`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GrantType` | `string` | Optional | Authentication grant type. |
| `RefreshToken` | `string` | Optional | Refresh token. |
| `Scope` | `string` | Optional | Authentication scopes. |
| `Headers` | [`Models.TargetAuthenticationBodyHeaders`](../../doc/models/target-authentication-body-headers.md) | Optional | Authentication headers. |
| `Host` | [`Models.TargetAuthenticationBodyHost`](../../doc/models/target-authentication-body-host.md) | Optional | Host information. |

## Example (as JSON)

```json
{
  "grant_type": "refresh_token",
  "refresh_token": "qfeqVjZTYzMmUtZWMzZqfq4ZDUtNzFhZWVkYTlmMjk1",
  "headers": {
    "Authorization": "Basic RGFrqewfq2xpZW50QXBwVjI6YzM5YjqfqmI2LWI2MWQtNDRlZTQ5MmM1YTRk",
    "Content-Type": "application/x-www-form-urlencoded"
  },
  "host": {
    "hostandpath": "https:// myhost.com:1825"
  },
  "scope": "scope2"
}
```

