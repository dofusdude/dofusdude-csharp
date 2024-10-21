/*
 * dofusdude
 *
 * # A project for you - the developer. The all-in-one toolbelt for your next Ankama related project.  ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [PHP](https://github.com/dofusdude/dofusdude-php) - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Discord Integration** Ankama related RSS and Almanax feeds to post to Discord servers with advanced features like filters or mentions. Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 2 Beta** from stable to bleeding edge by replacing /dofus2 with /dofus2beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_ including the dropped languages from the Dofus website _de_ and _it_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Complete** actual data from the game including items invisible to the encyclopedia like quest items.  - 🖼️ **HD Images** rendering game assets to high-res images with up to 800x800 px.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 0.9.4
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
    ///  Class for testing EffectsEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EffectsEntryTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EffectsEntry
        //private EffectsEntry instance;

        public EffectsEntryTests()
        {
            // TODO uncomment below to create an instance of EffectsEntry
            //instance = new EffectsEntry();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EffectsEntry
        /// </summary>
        [Fact]
        public void EffectsEntryInstanceTest()
        {
            // TODO uncomment below to test "IsType" EffectsEntry
            //Assert.IsType<EffectsEntry>(instance);
        }

        /// <summary>
        /// Test the property 'IntMinimum'
        /// </summary>
        [Fact]
        public void IntMinimumTest()
        {
            // TODO unit test for the property 'IntMinimum'
        }

        /// <summary>
        /// Test the property 'IntMaximum'
        /// </summary>
        [Fact]
        public void IntMaximumTest()
        {
            // TODO unit test for the property 'IntMaximum'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'IgnoreIntMin'
        /// </summary>
        [Fact]
        public void IgnoreIntMinTest()
        {
            // TODO unit test for the property 'IgnoreIntMin'
        }

        /// <summary>
        /// Test the property 'IgnoreIntMax'
        /// </summary>
        [Fact]
        public void IgnoreIntMaxTest()
        {
            // TODO unit test for the property 'IgnoreIntMax'
        }

        /// <summary>
        /// Test the property 'Formatted'
        /// </summary>
        [Fact]
        public void FormattedTest()
        {
            // TODO unit test for the property 'Formatted'
        }
    }
}
