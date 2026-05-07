
# Credentials Request

## Structure

`CredentialsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ECPD` | `string` | Required | Enterprise Customer Profile ID |
| `AccountNumber` | `string` | Required | Billing Account Number |
| `Items` | [`List<DeviceCredentialRequestItem>`](../../doc/models/device-credential-request-item.md) | Required | List of devices (1-50 items)<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `50` |

## Example (as JSON)

```json
{
  "ECPD": "3161585",
  "accountNumber": "0844021539-00001",
  "items": [
    {
      "imei": "221000008775573"
    }
  ]
}
```

