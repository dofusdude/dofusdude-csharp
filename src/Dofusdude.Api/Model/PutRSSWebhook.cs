/*
 * dofusdude
 *
 * # Open Ankama Developer Community The all-in-one toolbelt for your next Ankama related project.  ## Versions - [Dofus 2](https://docs.dofusdu.de/dofus2/) - [Dofus 3](https://docs.dofusdu.de/dofus3/)   - v1 [latest] (you are here)   ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Almanax Discord Integration** Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 3 Beta** from stable to bleeding edge by replacing /dofus3 with /dofus3beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_, _de_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Official Sources** generated from actual data from the game.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 1.0.0-rc.9
 * Contact: stelzo@steado.de
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dofusdude.Api.Client.OpenAPIDateConverter;

namespace Dofusdude.Api.Model
{
    /// <summary>
    /// PutRSSWebhook
    /// </summary>
    [DataContract(Name = "PutRSSWebhook")]
    public partial class PutRSSWebhook : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutRSSWebhook" /> class.
        /// </summary>
        /// <param name="whitelist">whitelist.</param>
        /// <param name="blacklist">blacklist.</param>
        /// <param name="subscriptions">Get the available subscriptions with /meta/webhooks/rss.</param>
        /// <param name="previewLength">previewLength.</param>
        public PutRSSWebhook(List<string> whitelist = default(List<string>), List<string> blacklist = default(List<string>), List<string> subscriptions = default(List<string>), int? previewLength = default(int?))
        {
            this.Whitelist = whitelist;
            this.Blacklist = blacklist;
            this.Subscriptions = subscriptions;
            this.PreviewLength = previewLength;
        }

        /// <summary>
        /// Gets or Sets Whitelist
        /// </summary>
        [DataMember(Name = "whitelist", EmitDefaultValue = true)]
        public List<string> Whitelist { get; set; }

        /// <summary>
        /// Gets or Sets Blacklist
        /// </summary>
        [DataMember(Name = "blacklist", EmitDefaultValue = true)]
        public List<string> Blacklist { get; set; }

        /// <summary>
        /// Get the available subscriptions with /meta/webhooks/rss
        /// </summary>
        /// <value>Get the available subscriptions with /meta/webhooks/rss</value>
        [DataMember(Name = "subscriptions", EmitDefaultValue = true)]
        public List<string> Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets PreviewLength
        /// </summary>
        /*
        <example>2000</example>
        */
        [DataMember(Name = "preview_length", EmitDefaultValue = true)]
        public int? PreviewLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutRSSWebhook {\n");
            sb.Append("  Whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("  Blacklist: ").Append(Blacklist).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  PreviewLength: ").Append(PreviewLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PreviewLength (int?) maximum
            if (this.PreviewLength > (int?)4000)
            {
                yield return new ValidationResult("Invalid value for PreviewLength, must be a value less than or equal to 4000.", new [] { "PreviewLength" });
            }

            // PreviewLength (int?) minimum
            if (this.PreviewLength < (int?)0)
            {
                yield return new ValidationResult("Invalid value for PreviewLength, must be a value greater than or equal to 0.", new [] { "PreviewLength" });
            }

            yield break;
        }
    }

}
