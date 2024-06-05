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
                    { Server.Thingspace, "https://thingspace.verizon.com/api" },
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
                    { Server.QualityOfService, "https://thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
            {
                Environment.MockServerForLimitedAvailabilitySeeQuickStart, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://mock.thingspace.verizon.com/api/mec/eds" },
                    { Server.Thingspace, "https://mock.thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://mock.thingspace.verizon.com/api/ts/v1" },
                    { Server.M2m, "https://mock.thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://mock.thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://mock.thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://mock.thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://mock.thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://mock.thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://mock.thingspace.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://mock.thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://mock.thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://mock.thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://mock.thingspace.verizon.com/api/mec/services" },
                    { Server.QualityOfService, "https://mock.thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
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
        private readonly Lazy<DeviceDiagnosticsController> deviceDiagnostics;
        private readonly Lazy<DeviceProfileManagementController> deviceProfileManagement;
        private readonly Lazy<DeviceMonitoringController> deviceMonitoring;
        private readonly Lazy<EUICCDeviceProfileManagementController> eUICCDeviceProfileManagement;
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
        private readonly Lazy<AnomalyTriggersV2Controller> anomalyTriggersV2;
        private readonly Lazy<WirelessNetworkPerformanceController> wirelessNetworkPerformance;
        private readonly Lazy<FixedWirelessQualificationController> fixedWirelessQualification;
        private readonly Lazy<ManagingESIMProfilesController> managingESIMProfiles;
        private readonly Lazy<DeviceSMSMessagingController> deviceSMSMessaging;
        private readonly Lazy<DeviceActionsController> deviceActions;
        private readonly Lazy<ThingSpaceQualityOfServiceAPIActionsController> thingSpaceQualityOfServiceAPIActions;
        private readonly Lazy<MECController> mEC;
        private readonly Lazy<PromotionPeriodInformationController> promotionPeriodInformation;
        private readonly Lazy<RetrieveTheTriggersController> retrieveTheTriggers;
        private readonly Lazy<UpdateTriggersController> updateTriggers;
        private readonly Lazy<SIMActionsController> sIMActions;
        private readonly Lazy<GlobalReportingController> globalReporting;
        private readonly Lazy<MV2TriggersController> mV2Triggers;
        private readonly Lazy<OauthAuthorizationController> oauthAuthorization;

        private VerizonClient(
            Environment environment,
            ThingspaceOauthModel thingspaceOauthModel,
            VZM2mTokenModel vZM2mTokenModel,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.HttpClientConfiguration = httpClientConfiguration;
            ThingspaceOauthModel = thingspaceOauthModel;
            var thingspaceOauthManager = new ThingspaceOauthManager(thingspaceOauthModel);
            thingspaceOauthManager.ApplyGlobalConfiguration(() => OauthAuthorizationController);
            VZM2mTokenModel = vZM2mTokenModel;
            var vZM2mTokenManager = new VZM2mTokenManager(vZM2mTokenModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"thingspace_oauth", thingspaceOauthManager},
                    {"VZ-M2M-Token", vZM2mTokenManager},
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.EdgeDiscovery)
                .UserAgent(userAgent)
                .Build();

            ThingspaceOauthCredentials = thingspaceOauthManager;
            VZM2mTokenCredentials = vZM2mTokenManager;

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
            this.deviceDiagnostics = new Lazy<DeviceDiagnosticsController>(
                () => new DeviceDiagnosticsController(globalConfiguration));
            this.deviceProfileManagement = new Lazy<DeviceProfileManagementController>(
                () => new DeviceProfileManagementController(globalConfiguration));
            this.deviceMonitoring = new Lazy<DeviceMonitoringController>(
                () => new DeviceMonitoringController(globalConfiguration));
            this.eUICCDeviceProfileManagement = new Lazy<EUICCDeviceProfileManagementController>(
                () => new EUICCDeviceProfileManagementController(globalConfiguration));
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
            this.anomalyTriggersV2 = new Lazy<AnomalyTriggersV2Controller>(
                () => new AnomalyTriggersV2Controller(globalConfiguration));
            this.wirelessNetworkPerformance = new Lazy<WirelessNetworkPerformanceController>(
                () => new WirelessNetworkPerformanceController(globalConfiguration));
            this.fixedWirelessQualification = new Lazy<FixedWirelessQualificationController>(
                () => new FixedWirelessQualificationController(globalConfiguration));
            this.managingESIMProfiles = new Lazy<ManagingESIMProfilesController>(
                () => new ManagingESIMProfilesController(globalConfiguration));
            this.deviceSMSMessaging = new Lazy<DeviceSMSMessagingController>(
                () => new DeviceSMSMessagingController(globalConfiguration));
            this.deviceActions = new Lazy<DeviceActionsController>(
                () => new DeviceActionsController(globalConfiguration));
            this.thingSpaceQualityOfServiceAPIActions = new Lazy<ThingSpaceQualityOfServiceAPIActionsController>(
                () => new ThingSpaceQualityOfServiceAPIActionsController(globalConfiguration));
            this.mEC = new Lazy<MECController>(
                () => new MECController(globalConfiguration));
            this.promotionPeriodInformation = new Lazy<PromotionPeriodInformationController>(
                () => new PromotionPeriodInformationController(globalConfiguration));
            this.retrieveTheTriggers = new Lazy<RetrieveTheTriggersController>(
                () => new RetrieveTheTriggersController(globalConfiguration));
            this.updateTriggers = new Lazy<UpdateTriggersController>(
                () => new UpdateTriggersController(globalConfiguration));
            this.sIMActions = new Lazy<SIMActionsController>(
                () => new SIMActionsController(globalConfiguration));
            this.globalReporting = new Lazy<GlobalReportingController>(
                () => new GlobalReportingController(globalConfiguration));
            this.mV2Triggers = new Lazy<MV2TriggersController>(
                () => new MV2TriggersController(globalConfiguration));
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
        /// Gets DeviceDiagnosticsController controller.
        /// </summary>
        public DeviceDiagnosticsController DeviceDiagnosticsController => this.deviceDiagnostics.Value;

        /// <summary>
        /// Gets DeviceProfileManagementController controller.
        /// </summary>
        public DeviceProfileManagementController DeviceProfileManagementController => this.deviceProfileManagement.Value;

        /// <summary>
        /// Gets DeviceMonitoringController controller.
        /// </summary>
        public DeviceMonitoringController DeviceMonitoringController => this.deviceMonitoring.Value;

        /// <summary>
        /// Gets EUICCDeviceProfileManagementController controller.
        /// </summary>
        public EUICCDeviceProfileManagementController EUICCDeviceProfileManagementController => this.eUICCDeviceProfileManagement.Value;

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
        /// Gets AnomalyTriggersV2Controller controller.
        /// </summary>
        public AnomalyTriggersV2Controller AnomalyTriggersV2Controller => this.anomalyTriggersV2.Value;

        /// <summary>
        /// Gets WirelessNetworkPerformanceController controller.
        /// </summary>
        public WirelessNetworkPerformanceController WirelessNetworkPerformanceController => this.wirelessNetworkPerformance.Value;

        /// <summary>
        /// Gets FixedWirelessQualificationController controller.
        /// </summary>
        public FixedWirelessQualificationController FixedWirelessQualificationController => this.fixedWirelessQualification.Value;

        /// <summary>
        /// Gets ManagingESIMProfilesController controller.
        /// </summary>
        public ManagingESIMProfilesController ManagingESIMProfilesController => this.managingESIMProfiles.Value;

        /// <summary>
        /// Gets DeviceSMSMessagingController controller.
        /// </summary>
        public DeviceSMSMessagingController DeviceSMSMessagingController => this.deviceSMSMessaging.Value;

        /// <summary>
        /// Gets DeviceActionsController controller.
        /// </summary>
        public DeviceActionsController DeviceActionsController => this.deviceActions.Value;

        /// <summary>
        /// Gets ThingSpaceQualityOfServiceAPIActionsController controller.
        /// </summary>
        public ThingSpaceQualityOfServiceAPIActionsController ThingSpaceQualityOfServiceAPIActionsController => this.thingSpaceQualityOfServiceAPIActions.Value;

        /// <summary>
        /// Gets MECController controller.
        /// </summary>
        public MECController MECController => this.mEC.Value;

        /// <summary>
        /// Gets PromotionPeriodInformationController controller.
        /// </summary>
        public PromotionPeriodInformationController PromotionPeriodInformationController => this.promotionPeriodInformation.Value;

        /// <summary>
        /// Gets RetrieveTheTriggersController controller.
        /// </summary>
        public RetrieveTheTriggersController RetrieveTheTriggersController => this.retrieveTheTriggers.Value;

        /// <summary>
        /// Gets UpdateTriggersController controller.
        /// </summary>
        public UpdateTriggersController UpdateTriggersController => this.updateTriggers.Value;

        /// <summary>
        /// Gets SIMActionsController controller.
        /// </summary>
        public SIMActionsController SIMActionsController => this.sIMActions.Value;

        /// <summary>
        /// Gets GlobalReportingController controller.
        /// </summary>
        public GlobalReportingController GlobalReportingController => this.globalReporting.Value;

        /// <summary>
        /// Gets MV2TriggersController controller.
        /// </summary>
        public MV2TriggersController MV2TriggersController => this.mV2Triggers.Value;

        /// <summary>
        /// Gets OauthAuthorizationController controller.
        /// </summary>
        public OauthAuthorizationController OauthAuthorizationController => this.oauthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }


        /// <summary>
        /// Gets the credentials to use with ThingspaceOauth.
        /// </summary>
        public IThingspaceOauthCredentials ThingspaceOauthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with ThingspaceOauth.
        /// </summary>
        public ThingspaceOauthModel ThingspaceOauthModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with VZM2MToken.
        /// </summary>
        public IVZM2mTokenCredentials VZM2mTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with VZM2MToken.
        /// </summary>
        public VZM2mTokenModel VZM2mTokenModel { get; private set; }

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
                .Environment(this.Environment)
                .HttpClientConfig(config => config.Build());

            if (ThingspaceOauthModel != null)
            {
                builder.ThingspaceOauthCredentials(ThingspaceOauthModel.ToBuilder().Build());
            }

            if (VZM2mTokenModel != null)
            {
                builder.VZM2mTokenCredentials(VZM2mTokenModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
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

            string environment = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_ENVIRONMENT");
            string oauthClientId = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_ID");
            string oauthClientSecret = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_SECRET");
            string vZM2mToken = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_VZ_M2M_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (oauthClientId != null && oauthClientSecret != null)
            {
                builder.ThingspaceOauthCredentials(new ThingspaceOauthModel
                .Builder(oauthClientId, oauthClientSecret)
                .Build());
            }

            if (vZM2mToken != null)
            {
                builder.VZM2mTokenCredentials(new VZM2mTokenModel
                .Builder(vZM2mToken)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = Verizon.Standard.Environment.Production;
            private ThingspaceOauthModel thingspaceOauthModel = new ThingspaceOauthModel();
            private VZM2mTokenModel vZM2mTokenModel = new VZM2mTokenModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

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
            /// Sets credentials for VZM2MToken.
            /// </summary>
            /// <param name="vZM2mTokenModel">VZM2mTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder VZM2mTokenCredentials(VZM2mTokenModel vZM2mTokenModel)
            {
                if (vZM2mTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(vZM2mTokenModel));
                }

                this.vZM2mTokenModel = vZM2mTokenModel;
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
                if (thingspaceOauthModel.OauthClientId == null || thingspaceOauthModel.OauthClientSecret == null)
                {
                    thingspaceOauthModel = null;
                }
                if (vZM2mTokenModel.VZM2mToken == null)
                {
                    vZM2mTokenModel = null;
                }
                return new VerizonClient(
                    environment,
                    thingspaceOauthModel,
                    vZM2mTokenModel,
                    httpClientConfig.Build());
            }
        }
    }
}
