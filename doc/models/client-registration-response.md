
# Client Registration Response

Response for /clients/registration. It provides a generated device ID and the certificates needed to connect the ETX Message Exchange.

## Structure

`ClientRegistrationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceID` | `Guid` | Required | The generated ID (UUID v4) for the device. It can be used as:<br><br>- the MQTT Client ID when connecting to the Message Exchange system<br>- a parameter when asking for the connection endpoint<br>- a parameter when finishing the device registration<br>- a parameter when unregistering the device |
| `Certificate` | [`Certificate`](../../doc/models/certificate.md) | Required | Structure for the credentials required to connect to the ETX MQTT Message Exchange. |

## Example (as JSON)

```json
{
  "DeviceID": "a4fcd16a-343d-4527-8203-2f46e3e4ff4b",
  "Certificate": {
    "cert.pem": "\"-----BEGIN CERTIFICATE-----\nMIIDrjCCApagAwIBAgICEAEwDQYJKoZIhvcNAQELBQAwUjELMAkGA1UEBhMCQVUx\n...\nuuA1Zog3aBOeeEzp9SEJBMTJRYPXbK4e8Xer+7m98OL/3g==\n-----END CERTIFICATE-----\"\n",
    "key.pem": "\"-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDa1lF7DWudshQ5\n...\nJbjD2hacWGzpKzTfn5Mt1frE\n-----END PRIVATE KEY-----\"\n",
    "ca.pem": "\"-----BEGIN CERTIFICATE-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDa1lF7DWudshQ5\n...\nJbjD2hacWGzpKzTfn5Mt1frE\n-----END CERTIFICATE-----\"\n",
    "ExpirationTime": "07/21/2017 17:32:28"
  }
}
```

