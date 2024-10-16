/*
 * dofusdude
 *
 * # A project for you - the developer. The all-in-one toolbelt for your next Ankama related project.  ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [PHP](https://github.com/dofusdude/dofusdude-php) - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Discord Integration** Ankama related RSS and Almanax feeds to post to Discord servers with advanced features like filters or mentions. Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 2 Beta** from stable to bleeding edge by replacing /dofus2 with /dofus2beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_ including the dropped languages from the Dofus website _de_ and _it_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Complete** actual data from the game including items invisible to the encyclopedia like quest items.  - 🖼️ **HD Images** rendering game assets to high-res images with up to 800x800 px.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 0.9.3
 * Contact: stelzo@steado.de
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Dofusdude.Api.Client;
using Dofusdude.Api.Api;
// uncomment below to import models
//using Dofusdude.Api.Model;

namespace Dofusdude.Api.Test.Api
{
    /// <summary>
    ///  Class for testing WebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhooksApiTests : IDisposable
    {
        private WebhooksApi instance;

        public WebhooksApiTests()
        {
            instance = new WebhooksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhooksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhooksApi
            //Assert.IsType<WebhooksApi>(instance);
        }

        /// <summary>
        /// Test DeleteWebhooksAlmanaxId
        /// </summary>
        [Fact]
        public void DeleteWebhooksAlmanaxIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteWebhooksAlmanaxId(id);
        }

        /// <summary>
        /// Test DeleteWebhooksRssId
        /// </summary>
        [Fact]
        public void DeleteWebhooksRssIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteWebhooksRssId(id);
        }

        /// <summary>
        /// Test DeleteWebhooksTwitterId
        /// </summary>
        [Fact]
        public void DeleteWebhooksTwitterIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteWebhooksTwitterId(id);
        }

        /// <summary>
        /// Test GetMetaWebhooksAlmanax
        /// </summary>
        [Fact]
        public void GetMetaWebhooksAlmanaxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMetaWebhooksAlmanax();
            //Assert.IsType<GetMetaWebhooksTwitter200Response>(response);
        }

        /// <summary>
        /// Test GetMetaWebhooksRss
        /// </summary>
        [Fact]
        public void GetMetaWebhooksRssTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMetaWebhooksRss();
            //Assert.IsType<GetMetaWebhooksTwitter200Response>(response);
        }

        /// <summary>
        /// Test GetMetaWebhooksTwitter
        /// </summary>
        [Fact]
        public void GetMetaWebhooksTwitterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMetaWebhooksTwitter();
            //Assert.IsType<GetMetaWebhooksTwitter200Response>(response);
        }

        /// <summary>
        /// Test GetWebhooksAlmanaxId
        /// </summary>
        [Fact]
        public void GetWebhooksAlmanaxIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetWebhooksAlmanaxId(id);
            //Assert.IsType<AlmanaxWebhook>(response);
        }

        /// <summary>
        /// Test GetWebhooksRssId
        /// </summary>
        [Fact]
        public void GetWebhooksRssIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetWebhooksRssId(id);
            //Assert.IsType<RssWebhook>(response);
        }

        /// <summary>
        /// Test GetWebhooksTwitterId
        /// </summary>
        [Fact]
        public void GetWebhooksTwitterIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetWebhooksTwitterId(id);
            //Assert.IsType<TwitterWebhook>(response);
        }

        /// <summary>
        /// Test PostWebhooksAlmanax
        /// </summary>
        [Fact]
        public void PostWebhooksAlmanaxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateAlmanaxWebhook? createAlmanaxWebhook = null;
            //instance.PostWebhooksAlmanax(createAlmanaxWebhook);
        }

        /// <summary>
        /// Test PostWebhooksRss
        /// </summary>
        [Fact]
        public void PostWebhooksRssTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateRSSWebhook? createRSSWebhook = null;
            //instance.PostWebhooksRss(createRSSWebhook);
        }

        /// <summary>
        /// Test PostWebhooksTwitter
        /// </summary>
        [Fact]
        public void PostWebhooksTwitterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTwitterWebhook? createTwitterWebhook = null;
            //instance.PostWebhooksTwitter(createTwitterWebhook);
        }

        /// <summary>
        /// Test PutWebhooksAlmanaxId
        /// </summary>
        [Fact]
        public void PutWebhooksAlmanaxIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PutAlmanaxWebhook? putAlmanaxWebhook = null;
            //var response = instance.PutWebhooksAlmanaxId(id, putAlmanaxWebhook);
            //Assert.IsType<AlmanaxWebhook>(response);
        }

        /// <summary>
        /// Test PutWebhooksRssId
        /// </summary>
        [Fact]
        public void PutWebhooksRssIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PutRSSWebhook? putRSSWebhook = null;
            //var response = instance.PutWebhooksRssId(id, putRSSWebhook);
            //Assert.IsType<RssWebhook>(response);
        }

        /// <summary>
        /// Test PutWebhooksTwitterId
        /// </summary>
        [Fact]
        public void PutWebhooksTwitterIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PutTwitterWebhook? putTwitterWebhook = null;
            //var response = instance.PutWebhooksTwitterId(id, putTwitterWebhook);
            //Assert.IsType<TwitterWebhook>(response);
        }
    }
}
