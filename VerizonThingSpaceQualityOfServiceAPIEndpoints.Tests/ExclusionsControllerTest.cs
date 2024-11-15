// <copyright file="ExclusionsControllerTest.cs" company="APIMatic">
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
    /// ExclusionsControllerTest.
    /// </summary>
    [TestFixture]
    public class ExclusionsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ExclusionsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ExclusionsController;
        }

        /// <summary>
        /// Create a consent record to use location services as an asynchronous request..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDevicesLocationGiveConsentAsync()
        {
            // Parameters for the API call
            Standard.Models.AccountConsentCreate body = null;

            // Perform API call
            Standard.Models.ConsentTransactionID result = null;
            try
            {
                result = await this.controller.DevicesLocationGiveConsentAsyncAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

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