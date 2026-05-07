
# Get Account Information Responseforplanner

## Structure

`GetAccountInformationResponseforplanner`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `AccountNumber` | `string` | Optional | The numeric name of the account, including leading zeros. |
| `Carriers` | `List<string>` | Optional | The list of carrier names with profiles.<br><br>**Constraints**: *Maximum Items*: `5` |
| `Features` | `List<string>` | Optional | a list of features associated with the resident profiles.<br><br>**Constraints**: *Maximum Items*: `50` |
| `IpPools` | [`List<IPPoolforplanner>`](../../doc/models/ip-poolforplanner.md) | Optional | **Constraints**: *Maximum Items*: `50` |
| `IsProvisioningAllowed` | `bool?` | Optional | A flag indicating if provisioning is allowed (true) or provisioning is locked (false). |
| `OrganizationName` | `string` | Optional | The user assigned organization name. |
| `ServicePlans` | [`List<ServicePlanResponseforplanner>`](../../doc/models/service-plan-responseforplanner.md) | Optional | A list of service plans associated with the resident profiles.<br><br>**Constraints**: *Maximum Items*: `10` |

## Example (as JSON)

```json
{
  "accountNumber": "0000123456-00001",
  "accountName": "accountName6",
  "carriers": [
    "carriers2",
    "carriers1"
  ],
  "features": [
    "features3",
    "features4"
  ],
  "ipPools": [
    {
      "isDefaultPool": false,
      "poolName": "poolName2",
      "poolType": "poolType6"
    },
    {
      "isDefaultPool": false,
      "poolName": "poolName2",
      "poolType": "poolType6"
    },
    {
      "isDefaultPool": false,
      "poolName": "poolName2",
      "poolType": "poolType6"
    }
  ]
}
```

