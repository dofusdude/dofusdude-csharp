/*
 * dofusdude
 *
 * # A project for you - the developer. The all-in-one toolbelt for your next Ankama related project.  ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [PHP](https://github.com/dofusdude/dofusdude-php) - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Discord Integration** Ankama related RSS and Almanax feeds to post to Discord servers with advanced features like filters or mentions. Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 2 Beta** from stable to bleeding edge by replacing /dofus2 with /dofus2beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_ including the dropped languages from the Dofus website _de_ and _it_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Complete** actual data from the game including items invisible to the encyclopedia like quest items.  - 🖼️ **HD Images** rendering game assets to high-res images with up to 800x800 px.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 0.9.4
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
    ///  Class for testing CosmeticsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CosmeticsApiTests : IDisposable
    {
        private CosmeticsApi instance;

        public CosmeticsApiTests()
        {
            instance = new CosmeticsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CosmeticsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CosmeticsApi
            //Assert.IsType<CosmeticsApi>(instance);
        }

        /// <summary>
        /// Test GetAllCosmeticsList
        /// </summary>
        [Fact]
        public void GetAllCosmeticsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string game = null;
            //string? sortLevel = null;
            //string? filterTypeName = null;
            //int? filterMinLevel = null;
            //int? filterMaxLevel = null;
            //string? acceptEncoding = null;
            //List<string>? filterTypeEnum = null;
            //var response = instance.GetAllCosmeticsList(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeEnum);
            //Assert.IsType<ItemsListPaged>(response);
        }

        /// <summary>
        /// Test GetCosmeticsList
        /// </summary>
        [Fact]
        public void GetCosmeticsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string game = null;
            //string? sortLevel = null;
            //string? filterTypeName = null;
            //int? filterMinLevel = null;
            //int? filterMaxLevel = null;
            //int? pageSize = null;
            //int? pageNumber = null;
            //List<string>? fieldsItem = null;
            //List<string>? filterTypeEnum = null;
            //var response = instance.GetCosmeticsList(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeEnum);
            //Assert.IsType<ItemsListPaged>(response);
        }

        /// <summary>
        /// Test GetCosmeticsSearch
        /// </summary>
        [Fact]
        public void GetCosmeticsSearchTest()
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
            //var response = instance.GetCosmeticsSearch(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit, filterTypeEnum);
            //Assert.IsType<List<ItemListEntry>>(response);
        }

        /// <summary>
        /// Test GetCosmeticsSingle
        /// </summary>
        [Fact]
        public void GetCosmeticsSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //int ankamaId = null;
            //string game = null;
            //var response = instance.GetCosmeticsSingle(language, ankamaId, game);
            //Assert.IsType<Equipment>(response);
        }
    }
}
