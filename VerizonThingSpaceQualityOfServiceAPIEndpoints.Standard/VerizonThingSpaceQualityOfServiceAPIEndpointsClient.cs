// <copyright file="VerizonThingSpaceQualityOfServiceAPIEndpointsClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Authentication;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Controllers;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Http.Client;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Utilities;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class VerizonThingSpaceQualityOfServiceAPIEndpointsClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.OAuthServer, "https://thingspace.verizon.com/api/ts/v1" },
                    { Server.Thingspace, "https://thingspace.verizon.com/api" },
                }
            },
            {
                Environment.Staging, new Dictionary<Enum, string>
                {
                    { Server.OAuthServer, "https://staging.thingspace.verizon.com/api/ts/v1" },
                    { Server.Thingspace, "https://staging.thingspace.verizon.com/api" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<ThingSpaceQualityOfServiceAPIActionsController> thingSpaceQualityOfServiceAPIActions;
        private readonly Lazy<ExclusionsController> exclusions;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private VerizonThingSpaceQualityOfServiceAPIEndpointsClient(
            string vZM2MToken2,
            Environment environment,
            ThingspaceOauthModel thingspaceOauthModel,
            VzM2mSessionTokenModel vzM2mSessionTokenModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.VZM2MToken2 = vZM2MToken2;
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            ThingspaceOauthModel = thingspaceOauthModel;
            var thingspaceOauthManager = new ThingspaceOauthManager(thingspaceOauthModel);
            thingspaceOauthManager.ApplyGlobalConfiguration(() => OAuthAuthorizationController);
            VzM2mSessionTokenModel = vzM2mSessionTokenModel;
            var vzM2mSessionTokenManager = new VzM2mSessionTokenManager(vzM2mSessionTokenModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"thingspace_oauth", thingspaceOauthManager},
                    {"vz-m2m-session_token", vzM2mSessionTokenManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Thingspace)
                .Parameters(globalParameter => globalParameter
                    .Header(headerParameter => headerParameter.Setup("VZ-M2M-Token", this.VZM2MToken2))
)
                .UserAgent(userAgent)
                .Build();

            ThingspaceOauthCredentials = thingspaceOauthManager;
            VzM2mSessionTokenCredentials = vzM2mSessionTokenManager;

            this.thingSpaceQualityOfServiceAPIActions = new Lazy<ThingSpaceQualityOfServiceAPIActionsController>(
                () => new ThingSpaceQualityOfServiceAPIActionsController(globalConfiguration));
            this.exclusions = new Lazy<ExclusionsController>(
                () => new ExclusionsController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets ThingSpaceQualityOfServiceAPIActionsController controller.
        /// </summary>
        public ThingSpaceQualityOfServiceAPIActionsController ThingSpaceQualityOfServiceAPIActionsController => this.thingSpaceQualityOfServiceAPIActions.Value;

        /// <summary>
        /// Gets ExclusionsController controller.
        /// </summary>
        public ExclusionsController ExclusionsController => this.exclusions.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets VZM2MToken2.
        /// The VZ-M2M session token from [Getting Started](/content/thingspace-portal/documentation/apis/connectivity-management/get-started.html).
        /// </summary>
        public string VZM2MToken2 { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with ThingspaceOauth.
        /// </summary>
        public IThingspaceOauthCredentials ThingspaceOauthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with ThingspaceOauth.
        /// </summary>
        public ThingspaceOauthModel ThingspaceOauthModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with VzM2mSessionToken.
        /// </summary>
        public IVzM2mSessionTokenCredentials VzM2mSessionTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with VzM2mSessionToken.
        /// </summary>
        public VzM2mSessionTokenModel VzM2mSessionTokenModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:THINGSPACE.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Thingspace)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the VerizonThingSpaceQualityOfServiceAPIEndpointsClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .VZM2MToken2(this.VZM2MToken2)
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .HttpClientConfig(config => config.Build());

            if (ThingspaceOauthModel != null)
            {
                builder.ThingspaceOauthCredentials(ThingspaceOauthModel.ToBuilder().Build());
            }

            if (VzM2mSessionTokenModel != null)
            {
                builder.VzM2mSessionTokenCredentials(VzM2mSessionTokenModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"VZM2MToken2 = {this.VZM2MToken2}, " +
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> VerizonThingSpaceQualityOfServiceAPIEndpointsClient.</returns>
        internal static VerizonThingSpaceQualityOfServiceAPIEndpointsClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string vZM2MToken2 = System.Environment.GetEnvironmentVariable("VERIZON_THING_SPACE_QUALITY_OF_SERVICE_API_ENDPOINTS_STANDARD_VZM_2_M_TOKEN_2");
            string environment = System.Environment.GetEnvironmentVariable("VERIZON_THING_SPACE_QUALITY_OF_SERVICE_API_ENDPOINTS_STANDARD_ENVIRONMENT");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("VERIZON_THING_SPACE_QUALITY_OF_SERVICE_API_ENDPOINTS_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("VERIZON_THING_SPACE_QUALITY_OF_SERVICE_API_ENDPOINTS_STANDARD_O_AUTH_CLIENT_SECRET");
            string vZM2MToken = System.Environment.GetEnvironmentVariable("VERIZON_THING_SPACE_QUALITY_OF_SERVICE_API_ENDPOINTS_STANDARD_V_ZM_2_M_TOKEN");

            if (vZM2MToken2 != null)
            {
                builder.VZM2MToken2(vZM2MToken2);
            }

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.ThingspaceOauthCredentials(new ThingspaceOauthModel
                .Builder(oAuthClientId, oAuthClientSecret)
                .Build());
            }

            if (vZM2MToken != null)
            {
                builder.VzM2mSessionTokenCredentials(new VzM2mSessionTokenModel
                .Builder(vZM2MToken)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string vZM2MToken2 = String.Empty;
            private Environment environment = VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Environment.Production;
            private ThingspaceOauthModel thingspaceOauthModel = new ThingspaceOauthModel();
            private VzM2mSessionTokenModel vzM2mSessionTokenModel = new VzM2mSessionTokenModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

            /// <summary>
            /// Sets credentials for ThingspaceOauth.
            /// </summary>
            /// <param name="thingspaceOauthModel">ThingspaceOauthModel.</param>
            /// <returns>Builder.</returns>
            public Builder ThingspaceOauthCredentials(ThingspaceOauthModel thingspaceOauthModel)
            {
                if (thingspaceOauthModel is null)
                {
                    throw new ArgumentNullException(nameof(thingspaceOauthModel));
                }

                this.thingspaceOauthModel = thingspaceOauthModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for VzM2mSessionToken.
            /// </summary>
            /// <param name="vzM2mSessionTokenModel">VzM2mSessionTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder VzM2mSessionTokenCredentials(VzM2mSessionTokenModel vzM2mSessionTokenModel)
            {
                if (vzM2mSessionTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(vzM2mSessionTokenModel));
                }

                this.vzM2mSessionTokenModel = vzM2mSessionTokenModel;
                return this;
            }

            /// <summary>
            /// Sets VZM2MToken2.
            /// </summary>
            /// <param name="vZM2MToken2"> VZM2MToken2. </param>
            /// <returns> Builder. </returns>
            public Builder VZM2MToken2(string vZM2MToken2)
            {
                this.vZM2MToken2 = vZM2MToken2 ?? throw new ArgumentNullException(nameof(vZM2MToken2));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the VerizonThingSpaceQualityOfServiceAPIEndpointsClient using the values provided for the builder.
            /// </summary>
            /// <returns>VerizonThingSpaceQualityOfServiceAPIEndpointsClient.</returns>
            public VerizonThingSpaceQualityOfServiceAPIEndpointsClient Build()
            {
                if (thingspaceOauthModel.OAuthClientId == null || thingspaceOauthModel.OAuthClientSecret == null)
                {
                    thingspaceOauthModel = null;
                }
                if (vzM2mSessionTokenModel.VZM2MToken == null)
                {
                    vzM2mSessionTokenModel = null;
                }
                return new VerizonThingSpaceQualityOfServiceAPIEndpointsClient(
                    vZM2MToken2,
                    environment,
                    thingspaceOauthModel,
                    vzM2mSessionTokenModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}
