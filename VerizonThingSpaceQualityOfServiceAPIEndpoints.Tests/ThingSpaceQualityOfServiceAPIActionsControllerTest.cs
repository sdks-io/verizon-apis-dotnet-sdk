// <copyright file="ThingSpaceQualityOfServiceAPIActionsControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Controllers;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Exceptions;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Http.Client;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Http.Response;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Utilities;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Tests
{
    /// <summary>
    /// ThingSpaceQualityOfServiceAPIActionsControllerTest.
    /// </summary>
    [TestFixture]
    public class ThingSpaceQualityOfServiceAPIActionsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ThingSpaceQualityOfServiceAPIActionsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ThingSpaceQualityOfServiceAPIActionsController;
        }

        /// <summary>
        /// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestStopAThingSpaceQualityOfServiceAPISubscription()
        {
            // Parameters for the API call
            string accountName = "0000123456-00001";
            string qosSubscriptionId = "QoS subscription ID";

            // Perform API call
            Standard.Models.M201success result = null;
            try
            {
                result = await this.controller.StopAThingSpaceQualityOfServiceAPISubscriptionAsync(accountName, qosSubscriptionId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }
    }
}