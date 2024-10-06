/*
 * dofusdude
 *
 * # A project for you - the developer. The all-in-one toolbelt for your next Ankama related project.  ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [PHP](https://github.com/dofusdude/dofusdude-php) - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Discord Integration** Ankama related RSS and Almanax feeds to post to Discord servers with advanced features like filters or mentions. Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 2 Beta** from stable to bleeding edge by replacing /dofus2 with /dofus2beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_ including the dropped languages from the Dofus website _de_ and _it_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Complete** actual data from the game including items invisible to the encyclopedia like quest items.  - 🖼️ **HD Images** rendering game assets to high-res images with up to 800x800 px.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 0.9.1
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
    /// CreateAlmanaxWebhookDailySettings
    /// </summary>
    [DataContract(Name = "CreateAlmanaxWebhook_daily_settings")]
    public partial class CreateAlmanaxWebhookDailySettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlmanaxWebhookDailySettings" /> class.
        /// </summary>
        /// <param name="timezone">Timezone of your community to determine midnight. (default to &quot;Europe/Paris&quot;).</param>
        /// <param name="midnightOffset">Hours added to midnight at the selected timezone. 8 &#x3D; 8:00 in the morning. (default to 0).</param>
        public CreateAlmanaxWebhookDailySettings(string timezone = @"Europe/Paris", int? midnightOffset = 0)
        {
            // use default value if no "timezone" provided
            this.Timezone = timezone ?? @"Europe/Paris";
            // use default value if no "midnightOffset" provided
            this.MidnightOffset = midnightOffset ?? 0;
        }

        /// <summary>
        /// Timezone of your community to determine midnight.
        /// </summary>
        /// <value>Timezone of your community to determine midnight.</value>
        /*
        <example>Europe/Paris</example>
        */
        [DataMember(Name = "timezone", EmitDefaultValue = true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Hours added to midnight at the selected timezone. 8 &#x3D; 8:00 in the morning.
        /// </summary>
        /// <value>Hours added to midnight at the selected timezone. 8 &#x3D; 8:00 in the morning.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "midnight_offset", EmitDefaultValue = true)]
        public int? MidnightOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAlmanaxWebhookDailySettings {\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  MidnightOffset: ").Append(MidnightOffset).Append("\n");
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
            // MidnightOffset (int?) maximum
            if (this.MidnightOffset > (int?)23)
            {
                yield return new ValidationResult("Invalid value for MidnightOffset, must be a value less than or equal to 23.", new [] { "MidnightOffset" });
            }

            // MidnightOffset (int?) minimum
            if (this.MidnightOffset < (int?)0)
            {
                yield return new ValidationResult("Invalid value for MidnightOffset, must be a value greater than or equal to 0.", new [] { "MidnightOffset" });
            }

            yield break;
        }
    }

}
