﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Data.Tables;
using NUnit.Framework;

namespace Azure.Tables.Tests
{
    public class TableConnectionStringTests
    {
        private const string AccountName = "accountName";
        private const string SasToken = "sv=2019-12-12&ss=t&srt=s&sp=rwdlacu&se=2020-08-28T23:45:30Z&st=2020-08-26T15:45:30Z&spr=https&sig=mySig";
        private const string Secret = "Kg==";
        private readonly TableSharedKeyCredential _expectedCred = new TableSharedKeyCredential(AccountName, Secret);
        private readonly TableSharedKeyCredential _expectedDevStoraageCred = new TableSharedKeyCredential(TableConstants.ConnectionStrings.DevStoreAccountName, TableConstants.ConnectionStrings.DevStoreAccountKey);

        /// <summary>
        /// Validates the functionality of the TableConnectionString.
        /// </summary>
        [Test]
        public void ParsesDevStorage()
        {
            var connString = $"UseDevelopmentStorage=true";

            Assert.That(TableConnectionString.TryParse(connString, out TableConnectionString tcs), "Parsing should have been successful");
            Assert.That(tcs.Credentials, Is.Not.Null);
            Assert.That(GetCredString(tcs.Credentials), Is.EqualTo(GetExpectedHash(_expectedDevStoraageCred)), "The Credentials should have matched.");
            Assert.That(tcs.TableStorageUri.PrimaryUri, Is.EqualTo(new Uri($"http://{TableConstants.ConnectionStrings.Localhost}:{TableConstants.ConnectionStrings.TableEndpointPortNumber}/{TableConstants.ConnectionStrings.DevStoreAccountName}")), "The PrimaryUri should have matched.");
        }

        public static IEnumerable<object[]> ValidStorageConnStrings()
        {
            yield return new object[] { $"DefaultEndpointsProtocol=https;AccountName={AccountName};AccountKey={Secret};EndpointSuffix=core.windows.net" };
            yield return new object[] { $"AccountName={AccountName};AccountKey={Secret};EndpointSuffix=core.windows.net" };
        }

        /// <summary>
        /// Validates the functionality of the TableConnectionString.
        /// </summary>
        [Test]
        [TestCaseSource(nameof(ValidStorageConnStrings))]
        public void ParsesStorage(string connString)
        {
            Assert.That(TableConnectionString.TryParse(connString, out TableConnectionString tcs), "Parsing should have been successful");
            Assert.That(tcs.Credentials, Is.Not.Null);
            Assert.That(GetCredString(tcs.Credentials), Is.EqualTo(GetExpectedHash(_expectedCred)), "The Credentials should have matched.");
            Assert.That(tcs.TableStorageUri.PrimaryUri, Is.EqualTo(new Uri($"https://{AccountName}.table.core.windows.net/")), "The PrimaryUri should have matched.");
        }

        public static IEnumerable<object[]> ValidCosmosConnStrings()
        {
            yield return new object[] { $"DefaultEndpointsProtocol=https;AccountName={AccountName};AccountKey={Secret};TableEndpoint=https://{AccountName}.table.cosmos.azure.com:443/;" };
            yield return new object[] { $"AccountName={AccountName};AccountKey={Secret};TableEndpoint=https://{AccountName}.table.cosmos.azure.com:443/;" };
        }

        /// <summary>
        /// Validates the functionality of the TableConnectionString.
        /// </summary>
        [Test]
        [TestCaseSource(nameof(ValidCosmosConnStrings))]
        public void ParsesCosmos(string connString)
        {
            Assert.That(TableConnectionString.TryParse(connString, out TableConnectionString tcs), "Parsing should have been successful");
            Assert.That(tcs.Credentials, Is.Not.Null);
            Assert.That(GetCredString(tcs.Credentials), Is.EqualTo(GetExpectedHash(_expectedCred)), "The Credentials should have matched.");
            Assert.That(tcs.TableStorageUri.PrimaryUri, Is.EqualTo(new Uri($"https://{AccountName}.table.cosmos.azure.com:443/")), "The PrimaryUri should have matched.");
        }

        /// <summary>
        /// Validates the functionality of the TableConnectionString.
        /// </summary>
        [Test]
        public void ParsesSaS()
        {
            var connString = $"BlobEndpoint=https://{AccountName}.blob.core.windows.net/;QueueEndpoint=https://{AccountName}.queue.core.windows.net/;FileEndpoint=https://{AccountName}.file.core.windows.net/;TableEndpoint=https://{AccountName}.table.core.windows.net/;SharedAccessSignature={SasToken}";

            Assert.That(TableConnectionString.TryParse(connString, out TableConnectionString tcs), "Parsing should have been successful");
            Assert.That(tcs.Credentials, Is.Not.Null);
            Assert.That(GetCredString(tcs.Credentials), Is.EqualTo(SasToken), "The Credentials should have matched.");
            Assert.That(tcs.TableStorageUri.PrimaryUri, Is.EqualTo(new Uri($"https://{AccountName}.table.core.windows.net/?{SasToken}")), "The PrimaryUri should have matched.");
        }

        public static IEnumerable<object[]> InvalidConnStrings()
        {
            yield return new object[] { "UseDevelopmentStorage=false" };
            yield return new object[] { $"BlobEndpoint=https://{AccountName}.blob.core.windows.net/;QueueEndpoint=https://{AccountName}.queue.core.windows.net/;FileEndpoint=https://{AccountName}.file.core.windows.net/;TableEndpoint=https://{AccountName}.table.core.windows.net/" };
            yield return new object[] { $"DefaultEndpointsProtocol=https;AccountName={AccountName};AccountKey={Secret}" };
            yield return new object[] { $"DefaultEndpointsProtocol=https;AccountName={AccountName};EndpointSuffix=core.windows.net" };
            yield return new object[] { $"DefaultEndpointsProtocol=https;AccountKey={Secret};EndpointSuffix=core.windows.net" };
        }

        /// <summary>
        /// Validates the functionality of the TableConnectionString.
        /// </summary>
        [Test]
        [TestCaseSource(nameof(InvalidConnStrings))]
        public void ParseFailsWithInvalidConnString(string connString)
        {
            Assert.That(TableConnectionString.TryParse(connString, out TableConnectionString tcs), Is.False, "Parsing should not have been successful");
        }

        private string GetExpectedHash(TableSharedKeyCredential cred) => cred.ComputeHMACSHA256("message");

        private string GetCredString(object credential) => credential switch
        {
            TableSharedKeyCredential cred => GetExpectedHash(cred),
            string sas => sas,
            _ => null
        };
    }
}
