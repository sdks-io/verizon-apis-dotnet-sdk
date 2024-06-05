
# Custom Header Signature



Documentation for accessing and setting credentials for VZ-M2M-Token.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| VZ-M2M-Token | `string` | M2M Session Token ([How to generate an M2M session token?]($e/Session%20Management/StartConnectivityManagementSession)) | `VZM2mToken` | `VZM2mToken` |



**Note:** Auth credentials can be set using `VZM2mTokenCredentials` in the client builder and accessed through `VZM2mTokenCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
Verizon.Standard.VerizonClient client = new Verizon.Standard.VerizonClient.Builder()
    .VZM2mTokenCredentials(
        new VZM2MTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .Build())
    .Build();
```


