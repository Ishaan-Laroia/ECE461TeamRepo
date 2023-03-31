/* 
 * ECE 461 - Fall 2021 - Project 2
 *
 * API for ECE 461/Fall 2021/Project 2: A Trustworthy Module Registry
 *
 * OpenAPI spec version: 3.0.2
 * Contact: davisjam@purdue.edu
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        /// <summary>
        /// Test CreateAuthToken
        /// </summary>
        [Test]
        public void CreateAuthTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthenticationRequest body = null;
            //var response = instance.CreateAuthToken(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test PackageByNameDelete
        /// </summary>
        [Test]
        public void PackageByNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string xAuthorization = null;
            //instance.PackageByNameDelete(name, xAuthorization);
            
        }
        /// <summary>
        /// Test PackageByNameGet
        /// </summary>
        [Test]
        public void PackageByNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string xAuthorization = null;
            //var response = instance.PackageByNameGet(name, xAuthorization);
            //Assert.IsInstanceOf<List<PackageHistoryEntry>> (response, "response is List<PackageHistoryEntry>");
        }
        /// <summary>
        /// Test PackageCreate
        /// </summary>
        [Test]
        public void PackageCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Package body = null;
            //string xAuthorization = null;
            //var response = instance.PackageCreate(body, xAuthorization);
            //Assert.IsInstanceOf<PackageMetadata> (response, "response is PackageMetadata");
        }
        /// <summary>
        /// Test PackageDelete
        /// </summary>
        [Test]
        public void PackageDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string xAuthorization = null;
            //instance.PackageDelete(id, xAuthorization);
            
        }
        /// <summary>
        /// Test PackageRate
        /// </summary>
        [Test]
        public void PackageRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string xAuthorization = null;
            //var response = instance.PackageRate(id, xAuthorization);
            //Assert.IsInstanceOf<PackageRating> (response, "response is PackageRating");
        }
        /// <summary>
        /// Test PackageRetrieve
        /// </summary>
        [Test]
        public void PackageRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string xAuthorization = null;
            //var response = instance.PackageRetrieve(id, xAuthorization);
            //Assert.IsInstanceOf<Package> (response, "response is Package");
        }
        /// <summary>
        /// Test PackageUpdate
        /// </summary>
        [Test]
        public void PackageUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Package body = null;
            //string id = null;
            //string xAuthorization = null;
            //instance.PackageUpdate(body, id, xAuthorization);
            
        }
        /// <summary>
        /// Test PackagesList
        /// </summary>
        [Test]
        public void PackagesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<PackageQuery> body = null;
            //string xAuthorization = null;
            //string offset = null;
            //var response = instance.PackagesList(body, xAuthorization, offset);
            //Assert.IsInstanceOf<List<PackageMetadata>> (response, "response is List<PackageMetadata>");
        }
        /// <summary>
        /// Test RegistryReset
        /// </summary>
        [Test]
        public void RegistryResetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAuthorization = null;
            //instance.RegistryReset(xAuthorization);
            
        }
    }

}