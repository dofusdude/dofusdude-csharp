/*
 * dofusdude
 *
 * # Open Ankama Developer Community The all-in-one toolbelt for your next Ankama related project.  ## Versions - [Dofus 2](https://docs.dofusdu.de/dofus2/) - [Dofus 3](https://docs.dofusdu.de/dofus3/)   - v1 [latest] (you are here)   ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Almanax Discord Integration** Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 3 Beta** from stable to bleeding edge by replacing /dofus3 with /dofus3beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_, _de_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Official Sources** generated from actual data from the game.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 1.0.0-rc.3
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
    ///  Class for testing QuestItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class QuestItemsApiTests : IDisposable
    {
        private QuestItemsApi instance;

        public QuestItemsApiTests()
        {
            instance = new QuestItemsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QuestItemsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' QuestItemsApi
            //Assert.IsType<QuestItemsApi>(instance);
        }

        /// <summary>
        /// Test GetAllItemsQuestList
        /// </summary>
        [Fact]
        public void GetAllItemsQuestListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string game = null;
            //string? sortLevel = null;
            //int? filterMinLevel = null;
            //int? filterMaxLevel = null;
            //string? acceptEncoding = null;
            //List<string>? filterTypeNameId = null;
            //var response = instance.GetAllItemsQuestList(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
            //Assert.IsType<ListItems>(response);
        }

        /// <summary>
        /// Test GetItemQuestSingle
        /// </summary>
        [Fact]
        public void GetItemQuestSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //int ankamaId = null;
            //string game = null;
            //var response = instance.GetItemQuestSingle(language, ankamaId, game);
            //Assert.IsType<Resource>(response);
        }

        /// <summary>
        /// Test GetItemsQuestList
        /// </summary>
        [Fact]
        public void GetItemsQuestListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string game = null;
            //string? sortLevel = null;
            //int? filterMinLevel = null;
            //int? filterMaxLevel = null;
            //int? pageSize = null;
            //int? pageNumber = null;
            //List<string>? fieldsItem = null;
            //List<string>? filterTypeNameId = null;
            //var response = instance.GetItemsQuestList(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
            //Assert.IsType<ListItems>(response);
        }

        /// <summary>
        /// Test GetItemsQuestSearch
        /// </summary>
        [Fact]
        public void GetItemsQuestSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string game = null;
            //string query = null;
            //string? filterTypeName = null;
            //int? filterMinLevel = null;
            //int? filterMaxLevel = null;
            //int? limit = null;
            //List<string>? filterTypeEnum = null;
            //var response = instance.GetItemsQuestSearch(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit, filterTypeEnum);
            //Assert.IsType<List<ListItem>>(response);
        }
    }
}
