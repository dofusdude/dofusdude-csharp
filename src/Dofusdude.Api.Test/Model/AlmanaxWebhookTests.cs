/*
 * dofusdude
 *
 * # A project for you - the developer. The all-in-one toolbelt for your next Ankama related project.  ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [PHP](https://github.com/dofusdude/dofusdude-php) - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Discord Integration** Ankama related RSS and Almanax feeds to post to Discord servers with advanced features like filters or mentions. Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 2 Beta** from stable to bleeding edge by replacing /dofus2 with /dofus2beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_ including the dropped languages from the Dofus website _de_ and _it_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Complete** actual data from the game including items invisible to the encyclopedia like quest items.  - 🖼️ **HD Images** rendering game assets to high-res images with up to 800x800 px.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 0.9.3
 * Contact: stelzo@steado.de
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Dofusdude.Api.Model;
using Dofusdude.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Dofusdude.Api.Test.Model
{
    /// <summary>
    ///  Class for testing AlmanaxWebhook
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AlmanaxWebhookTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AlmanaxWebhook
        //private AlmanaxWebhook instance;

        public AlmanaxWebhookTests()
        {
            // TODO uncomment below to create an instance of AlmanaxWebhook
            //instance = new AlmanaxWebhook();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AlmanaxWebhook
        /// </summary>
        [Fact]
        public void AlmanaxWebhookInstanceTest()
        {
            // TODO uncomment below to test "IsType" AlmanaxWebhook
            //Assert.IsType<AlmanaxWebhook>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'DailySettings'
        /// </summary>
        [Fact]
        public void DailySettingsTest()
        {
            // TODO unit test for the property 'DailySettings'
        }

        /// <summary>
        /// Test the property 'BonusWhitelist'
        /// </summary>
        [Fact]
        public void BonusWhitelistTest()
        {
            // TODO unit test for the property 'BonusWhitelist'
        }

        /// <summary>
        /// Test the property 'BonusBlacklist'
        /// </summary>
        [Fact]
        public void BonusBlacklistTest()
        {
            // TODO unit test for the property 'BonusBlacklist'
        }

        /// <summary>
        /// Test the property 'Subscriptions'
        /// </summary>
        [Fact]
        public void SubscriptionsTest()
        {
            // TODO unit test for the property 'Subscriptions'
        }

        /// <summary>
        /// Test the property 'IsoDate'
        /// </summary>
        [Fact]
        public void IsoDateTest()
        {
            // TODO unit test for the property 'IsoDate'
        }

        /// <summary>
        /// Test the property 'Mentions'
        /// </summary>
        [Fact]
        public void MentionsTest()
        {
            // TODO unit test for the property 'Mentions'
        }

        /// <summary>
        /// Test the property 'Intervals'
        /// </summary>
        [Fact]
        public void IntervalsTest()
        {
            // TODO unit test for the property 'Intervals'
        }

        /// <summary>
        /// Test the property 'WeeklyWeekday'
        /// </summary>
        [Fact]
        public void WeeklyWeekdayTest()
        {
            // TODO unit test for the property 'WeeklyWeekday'
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }

        /// <summary>
        /// Test the property 'LastFiredAt'
        /// </summary>
        [Fact]
        public void LastFiredAtTest()
        {
            // TODO unit test for the property 'LastFiredAt'
        }

        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
    }
}
