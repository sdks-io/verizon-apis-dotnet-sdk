
# Certificate

Structure for the credentials required to connect to the ETX MQTT Message Exchange.

## Structure

`Certificate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CertPem` | `string` | Required | The string containing the certificate<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `4096`, *Pattern*: ``^[a-zA-Z0-9~\+\-!@#$%^&*()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `KeyPem` | `string` | Required | The string containing the private key<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `4096`, *Pattern*: ``^[a-zA-Z0-9~\+\-!@#$%^&*()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `CaPem` | `string` | Required | The string containing the CA certificate<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `4096`, *Pattern*: ``^[a-zA-Z0-9~\+\-!@#$%^&*()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `ExpirationTime` | `DateTime` | Required | The string describing the expiration timestamp of the certificate |

## Example (as JSON)

```json
{
  "cert.pem": "\"-----BEGIN CERTIFICATE-----\nMIIDrjCCApagAwIBAgICEAEwDQYJKoZIhvcNAQELBQAwUjELMAkGA1UEBhMCQVUx\n...\nuuA1Zog3aBOeeEzp9SEJBMTJRYPXbK4e8Xer+7m98OL/3g==\n-----END CERTIFICATE-----\"\n",
  "key.pem": "\"-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDa1lF7DWudshQ5\n...\nJbjD2hacWGzpKzTfn5Mt1frE\n-----END PRIVATE KEY-----\"\n",
  "ca.pem": "\"-----BEGIN CERTIFICATE-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDa1lF7DWudshQ5\n...\nJbjD2hacWGzpKzTfn5Mt1frE\n-----END CERTIFICATE-----\"\n",
  "ExpirationTime": "07/21/2017 17:32:28"
}
```

