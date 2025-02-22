/*
 * dofusdude
 *
 * # Open Ankama Developer Community The all-in-one toolbelt for your next Ankama related project.  ## Versions - [Dofus 2](https://docs.dofusdu.de/dofus2/) - [Dofus 3](https://docs.dofusdu.de/dofus3/)   - v1 [latest] (you are here)   ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Almanax Discord Integration** Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 3 Beta** from stable to bleeding edge by replacing /dofus3 with /dofus3beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_, _de_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Official Sources** generated from actual data from the game.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 1.0.0
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
    ///  Class for testing MetaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MetaApiTests : IDisposable
    {
        private MetaApi instance;

        public MetaApiTests()
        {
            instance = new MetaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MetaApi
            //Assert.IsType<MetaApi>(instance);
        }

        /// <summary>
        /// Test GetGameSearchTypes
        /// </summary>
        [Fact]
        public void GetGameSearchTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string game = null;
            //var response = instance.GetGameSearchTypes(game);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetItemTypes
        /// </summary>
        [Fact]
        public void GetItemTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string game = null;
            //var response = instance.GetItemTypes(game);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetMetaAlmanaxBonuses
        /// </summary>
        [Fact]
        public void GetMetaAlmanaxBonusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //var response = instance.GetMetaAlmanaxBonuses(language);
            //Assert.IsType<List<GetMetaAlmanaxBonuses200ResponseInner>>(response);
        }

        /// <summary>
        /// Test GetMetaAlmanaxBonusesSearch
        /// </summary>
        [Fact]
        public void GetMetaAlmanaxBonusesSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string query = null;
            //int? limit = null;
            //var response = instance.GetMetaAlmanaxBonusesSearch(language, query, limit);
            //Assert.IsType<List<GetMetaAlmanaxBonuses200ResponseInner>>(response);
        }

        /// <summary>
        /// Test GetMetaElements
        /// </summary>
        [Fact]
        public void GetMetaElementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string game = null;
            //var response = instance.GetMetaElements(game);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetMetaVersion
        /// </summary>
        [Fact]
        public void GetMetaVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string game = null;
            //var response = instance.GetMetaVersion(game);
            //Assert.IsType<ModelVersion>(response);
        }
    }
}
