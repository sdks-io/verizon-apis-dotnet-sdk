
# Custom Header Signature



Documentation for accessing and setting credentials for vz-m2m-session_token.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| VZ-M2M-Token | `string` | The VZ-M2M session token from [Getting Started](/content/thingspace-portal/documentation/apis/connectivity-management/get-started.html) | `VZM2MToken` | `VZM2MToken` |



**Note:** Auth credentials can be set using `VzM2mSessionTokenCredentials` in the client builder and accessed through `VzM2mSessionTokenCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
VerizonThingSpaceQualityOfServiceAPIEndpointsClient client = new VerizonThingSpaceQualityOfServiceAPIEndpointsClient.Builder()
    .VzM2mSessionTokenCredentials(
        new VzM2mSessionTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .Build())
    .Build();
```


