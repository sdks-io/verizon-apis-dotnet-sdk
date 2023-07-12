// <copyright file="VerizonClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using Verizon.Standard.Authentication;
    using Verizon.Standard.Controllers;
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class VerizonClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://5gedge.verizon.com/api/mec/eds" },
                    { Server.OauthServer, "https://thingspace.verizon.com/api/ts/v1" },
                    { Server.M2m, "https://thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://5gedge.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://5gedge.verizon.com/api/mec/services" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly ClientCredentialsAuthManager clientCredentialsAuthManager;
        private readonly Lazy<M5gEdgePlatformsController> m5gEdgePlatforms;
        private readonly Lazy<ServiceEndpointsController> serviceEndpoints;
        private readonly Lazy<ServiceProfilesController> serviceProfiles;
        private readonly Lazy<DeviceManagementController> deviceManagement;
        private readonly Lazy<AccountsController> accounts;
        private readonly Lazy<DeviceGroupsController> deviceGroups;
        private readonly Lazy<SMSController> sMS;
        private readonly Lazy<SessionManagementController> sessionManagement;
        private readonly Lazy<ConnectivityCallbacksController> connectivityCallbacks;
        private readonly Lazy<AccountRequestsController> accountRequests;
        private readonly Lazy<ServicePlansController> servicePlans;
        private readonly Lazy<DeviceProfileManagementController> deviceProfileManagement;
        private readonly Lazy<DeviceMonitoringController> deviceMonitoring;
        private readonly Lazy<UICCDeviceProfileManagementController> uICCDeviceProfileManagement;
        private readonly Lazy<DevicesLocationsController> devicesLocations;
        private readonly Lazy<ExclusionsController> exclusions;
        private readonly Lazy<DevicesLocationSubscriptionsController> devicesLocationSubscriptions;
        private readonly Lazy<DeviceLocationCallbacksController> deviceLocationCallbacks;
        private readonly Lazy<UsageTriggerManagementController> usageTriggerManagement;
        private readonly Lazy<BillingController> billing;
        private readonly Lazy<SoftwareManagementSubscriptionsV1Controller> softwareManagementSubscriptionsV1;
        private readonly Lazy<SoftwareManagementLicensesV1Controller> softwareManagementLicensesV1;
        private readonly Lazy<FirmwareV1Controller> firmwareV1;
        private readonly Lazy<SoftwareManagementCallbacksV1Controller> softwareManagementCallbacksV1;
        private readonly Lazy<SoftwareManagementReportsV1Controller> softwareManagementReportsV1;
        private readonly Lazy<SoftwareManagementSubscriptionsV2Controller> softwareManagementSubscriptionsV2;
        private readonly Lazy<SoftwareManagementLicensesV2Controller> softwareManagementLicensesV2;
        private readonly Lazy<CampaignsV2Controller> campaignsV2;
        private readonly Lazy<SoftwareManagementCallbacksV2Controller> softwareManagementCallbacksV2;
        private readonly Lazy<SoftwareManagementReportsV2Controller> softwareManagementReportsV2;
        private readonly Lazy<ClientLoggingController> clientLogging;
        private readonly Lazy<ServerLoggingController> serverLogging;
        private readonly Lazy<ConfigurationFilesController> configurationFiles;
        private readonly Lazy<SoftwareManagementSubscriptionsV3Controller> softwareManagementSubscriptionsV3;
        private readonly Lazy<SoftwareManagementLicensesV3Controller> softwareManagementLicensesV3;
        private readonly Lazy<CampaignsV3Controller> campaignsV3;
        private readonly Lazy<SoftwareManagementReportsV3Controller> softwareManagementReportsV3;
        private readonly Lazy<FirmwareV3Controller> firmwareV3;
        private readonly Lazy<AccountDevicesController> accountDevices;
        private readonly Lazy<SoftwareManagementCallbacksV3Controller> softwareManagementCallbacksV3;
        private readonly Lazy<SIMSecureForIoTLicensesController> sIMSecureForIoTLicenses;
        private readonly Lazy<AccountSubscriptionsController> accountSubscriptions;
        private readonly Lazy<PerformanceMetricsController> performanceMetrics;
        private readonly Lazy<DiagnosticsSubscriptionsController> diagnosticsSubscriptions;
        private readonly Lazy<DiagnosticsObservationsController> diagnosticsObservations;
        private readonly Lazy<DiagnosticsHistoryController> diagnosticsHistory;
        private readonly Lazy<DiagnosticsSettingsController> diagnosticsSettings;
        private readonly Lazy<DiagnosticsCallbacksController> diagnosticsCallbacks;
        private readonly Lazy<DiagnosticsFactoryResetController> diagnosticsFactoryReset;
        private readonly Lazy<TargetsController> targets;
        private readonly Lazy<CloudConnectorSubscriptionsController> cloudConnectorSubscriptions;
        private readonly Lazy<CloudConnectorDevicesController> cloudConnectorDevices;
        private readonly Lazy<DeviceServiceManagementController> deviceServiceManagement;
        private readonly Lazy<DeviceReportsController> deviceReports;
        private readonly Lazy<HyperPreciseLocationCallbacksController> hyperPreciseLocationCallbacks;
        private readonly Lazy<AnomalySettingsController> anomalySettings;
        private readonly Lazy<AnomalyTriggersController> anomalyTriggers;
        private readonly Lazy<MECSitesController> mECSites;
        private readonly Lazy<ServiceLaunchProfilesController> serviceLaunchProfiles;
        private readonly Lazy<ServiceLaunchRequestsController> serviceLaunchRequests;
        private readonly Lazy<ServiceInstancesController> serviceInstances;
        private readonly Lazy<ServiceInstanceOperationsController> serviceInstanceOperations;
        private readonly Lazy<ServiceOnboardingController> serviceOnboarding;
        private readonly Lazy<ServiceMetadataController> serviceMetadata;
        private readonly Lazy<RepositoriesController> repositories;
        private readonly Lazy<CSPProfilesController> cSPProfiles;
        private readonly Lazy<ServiceClaimsController> serviceClaims;
        private readonly Lazy<OauthAuthorizationController> oauthAuthorization;

        private VerizonClient(
            string vZM2mToken,
            Environment environment,
            string oauthClientId,
            string oauthClientSecret,
            Models.OauthToken oauthToken,
            List<Models.OauthScopeEnum> oauthScopes,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.VZM2mToken = vZM2mToken;
            this.Environment = environment;
            this.HttpClientConfiguration = httpClientConfiguration;
            clientCredentialsAuthManager = new ClientCredentialsAuthManager(oauthClientId, oauthClientSecret, oauthToken, oauthScopes);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", clientCredentialsAuthManager}
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.EdgeDiscovery)
                .Parameters(globalParameter => globalParameter
                    .Header(headerParameter => headerParameter.Setup("VZ-M2M-Token", this.VZM2mToken))
)
                .UserAgent(userAgent)
                .Build();
            clientCredentialsAuthManager.ApplyGlobalConfiguration(globalConfiguration);

            this.m5gEdgePlatforms = new Lazy<M5gEdgePlatformsController>(
                () => new M5gEdgePlatformsController(globalConfiguration));
            this.serviceEndpoints = new Lazy<ServiceEndpointsController>(
                () => new ServiceEndpointsController(globalConfiguration));
            this.serviceProfiles = new Lazy<ServiceProfilesController>(
                () => new ServiceProfilesController(globalConfiguration));
            this.deviceManagement = new Lazy<DeviceManagementController>(
                () => new DeviceManagementController(globalConfiguration));
            this.accounts = new Lazy<AccountsController>(
                () => new AccountsController(globalConfiguration));
            this.deviceGroups = new Lazy<DeviceGroupsController>(
                () => new DeviceGroupsController(globalConfiguration));
            this.sMS = new Lazy<SMSController>(
                () => new SMSController(globalConfiguration));
            this.sessionManagement = new Lazy<SessionManagementController>(
                () => new SessionManagementController(globalConfiguration));
            this.connectivityCallbacks = new Lazy<ConnectivityCallbacksController>(
                () => new ConnectivityCallbacksController(globalConfiguration));
            this.accountRequests = new Lazy<AccountRequestsController>(
                () => new AccountRequestsController(globalConfiguration));
            this.servicePlans = new Lazy<ServicePlansController>(
                () => new ServicePlansController(globalConfiguration));
            this.deviceProfileManagement = new Lazy<DeviceProfileManagementController>(
                () => new DeviceProfileManagementController(globalConfiguration));
            this.deviceMonitoring = new Lazy<DeviceMonitoringController>(
                () => new DeviceMonitoringController(globalConfiguration));
            this.uICCDeviceProfileManagement = new Lazy<UICCDeviceProfileManagementController>(
                () => new UICCDeviceProfileManagementController(globalConfiguration));
            this.devicesLocations = new Lazy<DevicesLocationsController>(
                () => new DevicesLocationsController(globalConfiguration));
            this.exclusions = new Lazy<ExclusionsController>(
                () => new ExclusionsController(globalConfiguration));
            this.devicesLocationSubscriptions = new Lazy<DevicesLocationSubscriptionsController>(
                () => new DevicesLocationSubscriptionsController(globalConfiguration));
            this.deviceLocationCallbacks = new Lazy<DeviceLocationCallbacksController>(
                () => new DeviceLocationCallbacksController(globalConfiguration));
            this.usageTriggerManagement = new Lazy<UsageTriggerManagementController>(
                () => new UsageTriggerManagementController(globalConfiguration));
            this.billing = new Lazy<BillingController>(
                () => new BillingController(globalConfiguration));
            this.softwareManagementSubscriptionsV1 = new Lazy<SoftwareManagementSubscriptionsV1Controller>(
                () => new SoftwareManagementSubscriptionsV1Controller(globalConfiguration));
            this.softwareManagementLicensesV1 = new Lazy<SoftwareManagementLicensesV1Controller>(
                () => new SoftwareManagementLicensesV1Controller(globalConfiguration));
            this.firmwareV1 = new Lazy<FirmwareV1Controller>(
                () => new FirmwareV1Controller(globalConfiguration));
            this.softwareManagementCallbacksV1 = new Lazy<SoftwareManagementCallbacksV1Controller>(
                () => new SoftwareManagementCallbacksV1Controller(globalConfiguration));
            this.softwareManagementReportsV1 = new Lazy<SoftwareManagementReportsV1Controller>(
                () => new SoftwareManagementReportsV1Controller(globalConfiguration));
            this.softwareManagementSubscriptionsV2 = new Lazy<SoftwareManagementSubscriptionsV2Controller>(
                () => new SoftwareManagementSubscriptionsV2Controller(globalConfiguration));
            this.softwareManagementLicensesV2 = new Lazy<SoftwareManagementLicensesV2Controller>(
                () => new SoftwareManagementLicensesV2Controller(globalConfiguration));
            this.campaignsV2 = new Lazy<CampaignsV2Controller>(
                () => new CampaignsV2Controller(globalConfiguration));
            this.softwareManagementCallbacksV2 = new Lazy<SoftwareManagementCallbacksV2Controller>(
                () => new SoftwareManagementCallbacksV2Controller(globalConfiguration));
            this.softwareManagementReportsV2 = new Lazy<SoftwareManagementReportsV2Controller>(
                () => new SoftwareManagementReportsV2Controller(globalConfiguration));
            this.clientLogging = new Lazy<ClientLoggingController>(
                () => new ClientLoggingController(globalConfiguration));
            this.serverLogging = new Lazy<ServerLoggingController>(
                () => new ServerLoggingController(globalConfiguration));
            this.configurationFiles = new Lazy<ConfigurationFilesController>(
                () => new ConfigurationFilesController(globalConfiguration));
            this.softwareManagementSubscriptionsV3 = new Lazy<SoftwareManagementSubscriptionsV3Controller>(
                () => new SoftwareManagementSubscriptionsV3Controller(globalConfiguration));
            this.softwareManagementLicensesV3 = new Lazy<SoftwareManagementLicensesV3Controller>(
                () => new SoftwareManagementLicensesV3Controller(globalConfiguration));
            this.campaignsV3 = new Lazy<CampaignsV3Controller>(
                () => new CampaignsV3Controller(globalConfiguration));
            this.softwareManagementReportsV3 = new Lazy<SoftwareManagementReportsV3Controller>(
                () => new SoftwareManagementReportsV3Controller(globalConfiguration));
            this.firmwareV3 = new Lazy<FirmwareV3Controller>(
                () => new FirmwareV3Controller(globalConfiguration));
            this.accountDevices = new Lazy<AccountDevicesController>(
                () => new AccountDevicesController(globalConfiguration));
            this.softwareManagementCallbacksV3 = new Lazy<SoftwareManagementCallbacksV3Controller>(
                () => new SoftwareManagementCallbacksV3Controller(globalConfiguration));
            this.sIMSecureForIoTLicenses = new Lazy<SIMSecureForIoTLicensesController>(
                () => new SIMSecureForIoTLicensesController(globalConfiguration));
            this.accountSubscriptions = new Lazy<AccountSubscriptionsController>(
                () => new AccountSubscriptionsController(globalConfiguration));
            this.performanceMetrics = new Lazy<PerformanceMetricsController>(
                () => new PerformanceMetricsController(globalConfiguration));
            this.diagnosticsSubscriptions = new Lazy<DiagnosticsSubscriptionsController>(
                () => new DiagnosticsSubscriptionsController(globalConfiguration));
            this.diagnosticsObservations = new Lazy<DiagnosticsObservationsController>(
                () => new DiagnosticsObservationsController(globalConfiguration));
            this.diagnosticsHistory = new Lazy<DiagnosticsHistoryController>(
                () => new DiagnosticsHistoryController(globalConfiguration));
            this.diagnosticsSettings = new Lazy<DiagnosticsSettingsController>(
                () => new DiagnosticsSettingsController(globalConfiguration));
            this.diagnosticsCallbacks = new Lazy<DiagnosticsCallbacksController>(
                () => new DiagnosticsCallbacksController(globalConfiguration));
            this.diagnosticsFactoryReset = new Lazy<DiagnosticsFactoryResetController>(
                () => new DiagnosticsFactoryResetController(globalConfiguration));
            this.targets = new Lazy<TargetsController>(
                () => new TargetsController(globalConfiguration));
            this.cloudConnectorSubscriptions = new Lazy<CloudConnectorSubscriptionsController>(
                () => new CloudConnectorSubscriptionsController(globalConfiguration));
            this.cloudConnectorDevices = new Lazy<CloudConnectorDevicesController>(
                () => new CloudConnectorDevicesController(globalConfiguration));
            this.deviceServiceManagement = new Lazy<DeviceServiceManagementController>(
                () => new DeviceServiceManagementController(globalConfiguration));
            this.deviceReports = new Lazy<DeviceReportsController>(
                () => new DeviceReportsController(globalConfiguration));
            this.hyperPreciseLocationCallbacks = new Lazy<HyperPreciseLocationCallbacksController>(
                () => new HyperPreciseLocationCallbacksController(globalConfiguration));
            this.anomalySettings = new Lazy<AnomalySettingsController>(
                () => new AnomalySettingsController(globalConfiguration));
            this.anomalyTriggers = new Lazy<AnomalyTriggersController>(
                () => new AnomalyTriggersController(globalConfiguration));
            this.mECSites = new Lazy<MECSitesController>(
                () => new MECSitesController(globalConfiguration));
            this.serviceLaunchProfiles = new Lazy<ServiceLaunchProfilesController>(
                () => new ServiceLaunchProfilesController(globalConfiguration));
            this.serviceLaunchRequests = new Lazy<ServiceLaunchRequestsController>(
                () => new ServiceLaunchRequestsController(globalConfiguration));
            this.serviceInstances = new Lazy<ServiceInstancesController>(
                () => new ServiceInstancesController(globalConfiguration));
            this.serviceInstanceOperations = new Lazy<ServiceInstanceOperationsController>(
                () => new ServiceInstanceOperationsController(globalConfiguration));
            this.serviceOnboarding = new Lazy<ServiceOnboardingController>(
                () => new ServiceOnboardingController(globalConfiguration));
            this.serviceMetadata = new Lazy<ServiceMetadataController>(
                () => new ServiceMetadataController(globalConfiguration));
            this.repositories = new Lazy<RepositoriesController>(
                () => new RepositoriesController(globalConfiguration));
            this.cSPProfiles = new Lazy<CSPProfilesController>(
                () => new CSPProfilesController(globalConfiguration));
            this.serviceClaims = new Lazy<ServiceClaimsController>(
                () => new ServiceClaimsController(globalConfiguration));
            this.oauthAuthorization = new Lazy<OauthAuthorizationController>(
                () => new OauthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets M5gEdgePlatformsController controller.
        /// </summary>
        public M5gEdgePlatformsController M5gEdgePlatformsController => this.m5gEdgePlatforms.Value;

        /// <summary>
        /// Gets ServiceEndpointsController controller.
        /// </summary>
        public ServiceEndpointsController ServiceEndpointsController => this.serviceEndpoints.Value;

        /// <summary>
        /// Gets ServiceProfilesController controller.
        /// </summary>
        public ServiceProfilesController ServiceProfilesController => this.serviceProfiles.Value;

        /// <summary>
        /// Gets DeviceManagementController controller.
        /// </summary>
        public DeviceManagementController DeviceManagementController => this.deviceManagement.Value;

        /// <summary>
        /// Gets AccountsController controller.
        /// </summary>
        public AccountsController AccountsController => this.accounts.Value;

        /// <summary>
        /// Gets DeviceGroupsController controller.
        /// </summary>
        public DeviceGroupsController DeviceGroupsController => this.deviceGroups.Value;

        /// <summary>
        /// Gets SMSController controller.
        /// </summary>
        public SMSController SMSController => this.sMS.Value;

        /// <summary>
        /// Gets SessionManagementController controller.
        /// </summary>
        public SessionManagementController SessionManagementController => this.sessionManagement.Value;

        /// <summary>
        /// Gets ConnectivityCallbacksController controller.
        /// </summary>
        public ConnectivityCallbacksController ConnectivityCallbacksController => this.connectivityCallbacks.Value;

        /// <summary>
        /// Gets AccountRequestsController controller.
        /// </summary>
        public AccountRequestsController AccountRequestsController => this.accountRequests.Value;

        /// <summary>
        /// Gets ServicePlansController controller.
        /// </summary>
        public ServicePlansController ServicePlansController => this.servicePlans.Value;

        /// <summary>
        /// Gets DeviceProfileManagementController controller.
        /// </summary>
        public DeviceProfileManagementController DeviceProfileManagementController => this.deviceProfileManagement.Value;

        /// <summary>
        /// Gets DeviceMonitoringController controller.
        /// </summary>
        public DeviceMonitoringController DeviceMonitoringController => this.deviceMonitoring.Value;

        /// <summary>
        /// Gets UICCDeviceProfileManagementController controller.
        /// </summary>
        public UICCDeviceProfileManagementController UICCDeviceProfileManagementController => this.uICCDeviceProfileManagement.Value;

        /// <summary>
        /// Gets DevicesLocationsController controller.
        /// </summary>
        public DevicesLocationsController DevicesLocationsController => this.devicesLocations.Value;

        /// <summary>
        /// Gets ExclusionsController controller.
        /// </summary>
        public ExclusionsController ExclusionsController => this.exclusions.Value;

        /// <summary>
        /// Gets DevicesLocationSubscriptionsController controller.
        /// </summary>
        public DevicesLocationSubscriptionsController DevicesLocationSubscriptionsController => this.devicesLocationSubscriptions.Value;

        /// <summary>
        /// Gets DeviceLocationCallbacksController controller.
        /// </summary>
        public DeviceLocationCallbacksController DeviceLocationCallbacksController => this.deviceLocationCallbacks.Value;

        /// <summary>
        /// Gets UsageTriggerManagementController controller.
        /// </summary>
        public UsageTriggerManagementController UsageTriggerManagementController => this.usageTriggerManagement.Value;

        /// <summary>
        /// Gets BillingController controller.
        /// </summary>
        public BillingController BillingController => this.billing.Value;

        /// <summary>
        /// Gets SoftwareManagementSubscriptionsV1Controller controller.
        /// </summary>
        public SoftwareManagementSubscriptionsV1Controller SoftwareManagementSubscriptionsV1Controller => this.softwareManagementSubscriptionsV1.Value;

        /// <summary>
        /// Gets SoftwareManagementLicensesV1Controller controller.
        /// </summary>
        public SoftwareManagementLicensesV1Controller SoftwareManagementLicensesV1Controller => this.softwareManagementLicensesV1.Value;

        /// <summary>
        /// Gets FirmwareV1Controller controller.
        /// </summary>
        public FirmwareV1Controller FirmwareV1Controller => this.firmwareV1.Value;

        /// <summary>
        /// Gets SoftwareManagementCallbacksV1Controller controller.
        /// </summary>
        public SoftwareManagementCallbacksV1Controller SoftwareManagementCallbacksV1Controller => this.softwareManagementCallbacksV1.Value;

        /// <summary>
        /// Gets SoftwareManagementReportsV1Controller controller.
        /// </summary>
        public SoftwareManagementReportsV1Controller SoftwareManagementReportsV1Controller => this.softwareManagementReportsV1.Value;

        /// <summary>
        /// Gets SoftwareManagementSubscriptionsV2Controller controller.
        /// </summary>
        public SoftwareManagementSubscriptionsV2Controller SoftwareManagementSubscriptionsV2Controller => this.softwareManagementSubscriptionsV2.Value;

        /// <summary>
        /// Gets SoftwareManagementLicensesV2Controller controller.
        /// </summary>
        public SoftwareManagementLicensesV2Controller SoftwareManagementLicensesV2Controller => this.softwareManagementLicensesV2.Value;

        /// <summary>
        /// Gets CampaignsV2Controller controller.
        /// </summary>
        public CampaignsV2Controller CampaignsV2Controller => this.campaignsV2.Value;

        /// <summary>
        /// Gets SoftwareManagementCallbacksV2Controller controller.
        /// </summary>
        public SoftwareManagementCallbacksV2Controller SoftwareManagementCallbacksV2Controller => this.softwareManagementCallbacksV2.Value;

        /// <summary>
        /// Gets SoftwareManagementReportsV2Controller controller.
        /// </summary>
        public SoftwareManagementReportsV2Controller SoftwareManagementReportsV2Controller => this.softwareManagementReportsV2.Value;

        /// <summary>
        /// Gets ClientLoggingController controller.
        /// </summary>
        public ClientLoggingController ClientLoggingController => this.clientLogging.Value;

        /// <summary>
        /// Gets ServerLoggingController controller.
        /// </summary>
        public ServerLoggingController ServerLoggingController => this.serverLogging.Value;

        /// <summary>
        /// Gets ConfigurationFilesController controller.
        /// </summary>
        public ConfigurationFilesController ConfigurationFilesController => this.configurationFiles.Value;

        /// <summary>
        /// Gets SoftwareManagementSubscriptionsV3Controller controller.
        /// </summary>
        public SoftwareManagementSubscriptionsV3Controller SoftwareManagementSubscriptionsV3Controller => this.softwareManagementSubscriptionsV3.Value;

        /// <summary>
        /// Gets SoftwareManagementLicensesV3Controller controller.
        /// </summary>
        public SoftwareManagementLicensesV3Controller SoftwareManagementLicensesV3Controller => this.softwareManagementLicensesV3.Value;

        /// <summary>
        /// Gets CampaignsV3Controller controller.
        /// </summary>
        public CampaignsV3Controller CampaignsV3Controller => this.campaignsV3.Value;

        /// <summary>
        /// Gets SoftwareManagementReportsV3Controller controller.
        /// </summary>
        public SoftwareManagementReportsV3Controller SoftwareManagementReportsV3Controller => this.softwareManagementReportsV3.Value;

        /// <summary>
        /// Gets FirmwareV3Controller controller.
        /// </summary>
        public FirmwareV3Controller FirmwareV3Controller => this.firmwareV3.Value;

        /// <summary>
        /// Gets AccountDevicesController controller.
        /// </summary>
        public AccountDevicesController AccountDevicesController => this.accountDevices.Value;

        /// <summary>
        /// Gets SoftwareManagementCallbacksV3Controller controller.
        /// </summary>
        public SoftwareManagementCallbacksV3Controller SoftwareManagementCallbacksV3Controller => this.softwareManagementCallbacksV3.Value;

        /// <summary>
        /// Gets SIMSecureForIoTLicensesController controller.
        /// </summary>
        public SIMSecureForIoTLicensesController SIMSecureForIoTLicensesController => this.sIMSecureForIoTLicenses.Value;

        /// <summary>
        /// Gets AccountSubscriptionsController controller.
        /// </summary>
        public AccountSubscriptionsController AccountSubscriptionsController => this.accountSubscriptions.Value;

        /// <summary>
        /// Gets PerformanceMetricsController controller.
        /// </summary>
        public PerformanceMetricsController PerformanceMetricsController => this.performanceMetrics.Value;

        /// <summary>
        /// Gets DiagnosticsSubscriptionsController controller.
        /// </summary>
        public DiagnosticsSubscriptionsController DiagnosticsSubscriptionsController => this.diagnosticsSubscriptions.Value;

        /// <summary>
        /// Gets DiagnosticsObservationsController controller.
        /// </summary>
        public DiagnosticsObservationsController DiagnosticsObservationsController => this.diagnosticsObservations.Value;

        /// <summary>
        /// Gets DiagnosticsHistoryController controller.
        /// </summary>
        public DiagnosticsHistoryController DiagnosticsHistoryController => this.diagnosticsHistory.Value;

        /// <summary>
        /// Gets DiagnosticsSettingsController controller.
        /// </summary>
        public DiagnosticsSettingsController DiagnosticsSettingsController => this.diagnosticsSettings.Value;

        /// <summary>
        /// Gets DiagnosticsCallbacksController controller.
        /// </summary>
        public DiagnosticsCallbacksController DiagnosticsCallbacksController => this.diagnosticsCallbacks.Value;

        /// <summary>
        /// Gets DiagnosticsFactoryResetController controller.
        /// </summary>
        public DiagnosticsFactoryResetController DiagnosticsFactoryResetController => this.diagnosticsFactoryReset.Value;

        /// <summary>
        /// Gets TargetsController controller.
        /// </summary>
        public TargetsController TargetsController => this.targets.Value;

        /// <summary>
        /// Gets CloudConnectorSubscriptionsController controller.
        /// </summary>
        public CloudConnectorSubscriptionsController CloudConnectorSubscriptionsController => this.cloudConnectorSubscriptions.Value;

        /// <summary>
        /// Gets CloudConnectorDevicesController controller.
        /// </summary>
        public CloudConnectorDevicesController CloudConnectorDevicesController => this.cloudConnectorDevices.Value;

        /// <summary>
        /// Gets DeviceServiceManagementController controller.
        /// </summary>
        public DeviceServiceManagementController DeviceServiceManagementController => this.deviceServiceManagement.Value;

        /// <summary>
        /// Gets DeviceReportsController controller.
        /// </summary>
        public DeviceReportsController DeviceReportsController => this.deviceReports.Value;

        /// <summary>
        /// Gets HyperPreciseLocationCallbacksController controller.
        /// </summary>
        public HyperPreciseLocationCallbacksController HyperPreciseLocationCallbacksController => this.hyperPreciseLocationCallbacks.Value;

        /// <summary>
        /// Gets AnomalySettingsController controller.
        /// </summary>
        public AnomalySettingsController AnomalySettingsController => this.anomalySettings.Value;

        /// <summary>
        /// Gets AnomalyTriggersController controller.
        /// </summary>
        public AnomalyTriggersController AnomalyTriggersController => this.anomalyTriggers.Value;

        /// <summary>
        /// Gets MECSitesController controller.
        /// </summary>
        public MECSitesController MECSitesController => this.mECSites.Value;

        /// <summary>
        /// Gets ServiceLaunchProfilesController controller.
        /// </summary>
        public ServiceLaunchProfilesController ServiceLaunchProfilesController => this.serviceLaunchProfiles.Value;

        /// <summary>
        /// Gets ServiceLaunchRequestsController controller.
        /// </summary>
        public ServiceLaunchRequestsController ServiceLaunchRequestsController => this.serviceLaunchRequests.Value;

        /// <summary>
        /// Gets ServiceInstancesController controller.
        /// </summary>
        public ServiceInstancesController ServiceInstancesController => this.serviceInstances.Value;

        /// <summary>
        /// Gets ServiceInstanceOperationsController controller.
        /// </summary>
        public ServiceInstanceOperationsController ServiceInstanceOperationsController => this.serviceInstanceOperations.Value;

        /// <summary>
        /// Gets ServiceOnboardingController controller.
        /// </summary>
        public ServiceOnboardingController ServiceOnboardingController => this.serviceOnboarding.Value;

        /// <summary>
        /// Gets ServiceMetadataController controller.
        /// </summary>
        public ServiceMetadataController ServiceMetadataController => this.serviceMetadata.Value;

        /// <summary>
        /// Gets RepositoriesController controller.
        /// </summary>
        public RepositoriesController RepositoriesController => this.repositories.Value;

        /// <summary>
        /// Gets CSPProfilesController controller.
        /// </summary>
        public CSPProfilesController CSPProfilesController => this.cSPProfiles.Value;

        /// <summary>
        /// Gets ServiceClaimsController controller.
        /// </summary>
        public ServiceClaimsController ServiceClaimsController => this.serviceClaims.Value;

        /// <summary>
        /// Gets OauthAuthorizationController controller.
        /// </summary>
        public OauthAuthorizationController OauthAuthorizationController => this.oauthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets VZM2mToken.
        /// M2M Session Token.
        /// </summary>
        public string VZM2mToken { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }


        /// <summary>
        /// Gets the credentials to use with ClientCredentialsAuth.
        /// </summary>
        public IClientCredentialsAuth ClientCredentialsAuth => this.clientCredentialsAuthManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:EDGE DISCOVERY.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.EdgeDiscovery)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the VerizonClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .VZM2mToken(this.VZM2mToken)
                .Environment(this.Environment)
                .OauthToken(clientCredentialsAuthManager.OauthToken)
                .OauthScopes(clientCredentialsAuthManager.OauthScopes)
                .ClientCredentialsAuth(clientCredentialsAuthManager.OauthClientId, clientCredentialsAuthManager.OauthClientSecret)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"VZM2mToken = {this.VZM2mToken}, " +
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> VerizonClient.</returns>
        internal static VerizonClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string vZM2mToken = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_VZ_M2M_TOKEN");
            string environment = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_ENVIRONMENT");
            string oauthClientId = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_ID");
            string oauthClientSecret = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_SECRET");

            if (vZM2mToken != null)
            {
                builder.VZM2mToken(vZM2mToken);
            }

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (oauthClientId != null && oauthClientSecret != null)
            {
                builder.ClientCredentialsAuth(oauthClientId, oauthClientSecret);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string vZM2mToken = String.Empty;
            private Environment environment = Verizon.Standard.Environment.Production;
            private string oauthClientId = "";
            private string oauthClientSecret = "";
            private Models.OauthToken oauthToken = null;
            private List<Models.OauthScopeEnum> oauthScopes = null;
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for ClientCredentialsAuth.
            /// </summary>
            /// <param name="oauthClientId">OauthClientId.</param>
            /// <param name="oauthClientSecret">OauthClientSecret.</param>
            /// <returns>Builder.</returns>
            public Builder ClientCredentialsAuth(string oauthClientId, string oauthClientSecret)
            {
                this.oauthClientId = oauthClientId ?? throw new ArgumentNullException(nameof(oauthClientId));
                this.oauthClientSecret = oauthClientSecret ?? throw new ArgumentNullException(nameof(oauthClientSecret));
                return this;
            }

            /// <summary>
            /// Sets OAuthToken.
            /// </summary>
            /// <param name="oauthToken">OauthToken.</param>
            /// <returns>Builder.</returns>
            public Builder OauthToken(Models.OauthToken oauthToken)
            {
                this.oauthToken = oauthToken;
                return this;
            }

            /// <summary>
            /// Sets OAuthScopes.
            /// </summary>
            /// <param name="oauthScopes">OauthScopes.</param>
            /// <returns>Builder.</returns>
            public Builder OauthScopes(List<Models.OauthScopeEnum> oauthScopes)
            {
                this.oauthScopes = oauthScopes;
                return this;
            }

            /// <summary>
            /// Sets VZM2mToken.
            /// </summary>
            /// <param name="vZM2mToken"> VZM2mToken. </param>
            /// <returns> Builder. </returns>
            public Builder VZM2mToken(string vZM2mToken)
            {
                this.vZM2mToken = vZM2mToken ?? throw new ArgumentNullException(nameof(vZM2mToken));
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
            /// Creates an object of the VerizonClient using the values provided for the builder.
            /// </summary>
            /// <returns>VerizonClient.</returns>
            public VerizonClient Build()
            {

                return new VerizonClient(
                    vZM2mToken,
                    environment,
                    oauthClientId,
                    oauthClientSecret,
                    oauthToken,
                    oauthScopes,
                    httpClientConfig.Build());
            }
        }
    }
}
