/*
 * dofusdude
 *
 * # A project for you - the developer. The all-in-one toolbelt for your next Ankama related project.  ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [PHP](https://github.com/dofusdude/dofusdude-php) - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Discord Integration** Ankama related RSS and Almanax feeds to post to Discord servers with advanced features like filters or mentions. Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 2 Beta** from stable to bleeding edge by replacing /dofus2 with /dofus2beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_ including the dropped languages from the Dofus website _de_ and _it_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Complete** actual data from the game including items invisible to the encyclopedia like quest items.  - 🖼️ **HD Images** rendering game assets to high-res images with up to 800x800 px.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 0.9.0
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
    /// CreateTwitterWebhook
    /// </summary>
    [DataContract(Name = "CreateTwitterWebhook")]
    public partial class CreateTwitterWebhook : IValidatableObject
    {
        /// <summary>
        /// Defines Format
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum Discord for value: discord
            /// </summary>
            [EnumMember(Value = "discord")]
            Discord = 1
        }


        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwitterWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTwitterWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwitterWebhook" /> class.
        /// </summary>
        /// <param name="whitelist">whitelist.</param>
        /// <param name="blacklist">blacklist.</param>
        /// <param name="subscriptions">Get the available subscriptions with /meta/webhooks/twitter (required).</param>
        /// <param name="format">format (required).</param>
        /// <param name="previewLength">previewLength.</param>
        /// <param name="callback">Discord Webhook URL (required).</param>
        public CreateTwitterWebhook(List<string> whitelist = default(List<string>), List<string> blacklist = default(List<string>), List<string> subscriptions = default(List<string>), FormatEnum format = default(FormatEnum), int? previewLength = default(int?), string callback = default(string))
        {
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new ArgumentNullException("subscriptions is a required property for CreateTwitterWebhook and cannot be null");
            }
            this.Subscriptions = subscriptions;
            this.Format = format;
            // to ensure "callback" is required (not null)
            if (callback == null)
            {
                throw new ArgumentNullException("callback is a required property for CreateTwitterWebhook and cannot be null");
            }
            this.Callback = callback;
            this.Whitelist = whitelist;
            this.Blacklist = blacklist;
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
        /// Get the available subscriptions with /meta/webhooks/twitter
        /// </summary>
        /// <value>Get the available subscriptions with /meta/webhooks/twitter</value>
        [DataMember(Name = "subscriptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets PreviewLength
        /// </summary>
        /// <example>280</example>
        [DataMember(Name = "preview_length", EmitDefaultValue = true)]
        public int? PreviewLength { get; set; }

        /// <summary>
        /// Discord Webhook URL
        /// </summary>
        /// <value>Discord Webhook URL</value>
        /// <example>https://discord.com/api/webhooks/XYZ</example>
        [DataMember(Name = "callback", IsRequired = true, EmitDefaultValue = true)]
        public string Callback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTwitterWebhook {\n");
            sb.Append("  Whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("  Blacklist: ").Append(Blacklist).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  PreviewLength: ").Append(PreviewLength).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PreviewLength (int?) maximum
            if (this.PreviewLength > (int?)280)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PreviewLength, must be a value less than or equal to 280.", new [] { "PreviewLength" });
            }

            // PreviewLength (int?) minimum
            if (this.PreviewLength < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PreviewLength, must be a value greater than or equal to 0.", new [] { "PreviewLength" });
            }

            yield break;
        }
    }

}