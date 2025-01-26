/*
 * dofusdude
 *
 * # Open Ankama Developer Community The all-in-one toolbelt for your next Ankama related project.  ## Versions - [Dofus 2](https://docs.dofusdu.de/dofus2/) - [Dofus 3](https://docs.dofusdu.de/dofus3/)   - v1 [latest] (you are here)   ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Almanax Discord Integration** Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 3 Beta** from stable to bleeding edge by replacing /dofus3 with /dofus3beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_, _de_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Official Sources** generated from actual data from the game.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 1.0.0-rc.10
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
    ///  Class for testing GameApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GameApiTests : IDisposable
    {
        private GameApi instance;

        public GameApiTests()
        {
            instance = new GameApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GameApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GameApi
            //Assert.IsType<GameApi>(instance);
        }

        /// <summary>
        /// Test GetGameSearch
        /// </summary>
        [Fact]
        public void GetGameSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string game = null;
            //string query = null;
            //List<string>? filterSearchIndex = null;
            //int? limit = null;
            //List<string>? fieldsItem = null;
            //List<string>? filterTypeNameId = null;
            //var response = instance.GetGameSearch(language, game, query, filterSearchIndex, limit, fieldsItem, filterTypeNameId);
            //Assert.IsType<List<GameSearch>>(response);
        }

        /// <summary>
        /// Test GetItemsAllSearch
        /// </summary>
        [Fact]
        public void GetItemsAllSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string game = null;
            //string query = null;
            //int? filterMinLevel = null;
            //int? filterMaxLevel = null;
            //int? limit = null;
            //List<string>? filterTypeNameId = null;
            //var response = instance.GetItemsAllSearch(language, game, query, filterMinLevel, filterMaxLevel, limit, filterTypeNameId);
            //Assert.IsType<List<ListItemGeneral>>(response);
        }
    }
}
