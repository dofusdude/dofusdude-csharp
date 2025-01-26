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
    /// TwitterWebhook
    /// </summary>
    [DataContract(Name = "TwitterWebhook")]
    public partial class TwitterWebhook : IValidatableObject
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
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterWebhook" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="whitelist">whitelist.</param>
        /// <param name="blacklist">blacklist.</param>
        /// <param name="subscriptions">subscriptions.</param>
        /// <param name="format">format.</param>
        /// <param name="previewLength">previewLength.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="lastFiredAt">lastFiredAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public TwitterWebhook(Guid id = default(Guid), List<string> whitelist = default(List<string>), List<string> blacklist = default(List<string>), List<string> subscriptions = default(List<string>), FormatEnum? format = default(FormatEnum?), int previewLength = default(int), DateTime createdAt = default(DateTime), DateTime? lastFiredAt = default(DateTime?), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            this.Whitelist = whitelist;
            this.Blacklist = blacklist;
            this.Subscriptions = subscriptions;
            this.Format = format;
            this.PreviewLength = previewLength;
            this.CreatedAt = createdAt;
            this.LastFiredAt = lastFiredAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

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
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscriptions", EmitDefaultValue = false)]
        public List<string> Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets PreviewLength
        /// </summary>
        /*
        <example>280</example>
        */
        [DataMember(Name = "preview_length", EmitDefaultValue = false)]
        public int PreviewLength { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /*
        <example>2022-10-25T15:32:37.406281+02:00</example>
        */
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastFiredAt
        /// </summary>
        /*
        <example>2022-10-25T15:35:37.103240+02:00</example>
        */
        [DataMember(Name = "last_fired_at", EmitDefaultValue = true)]
        public DateTime? LastFiredAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /*
        <example>2022-10-25T15:32:37.406281+02:00</example>
        */
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwitterWebhook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("  Blacklist: ").Append(Blacklist).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  PreviewLength: ").Append(PreviewLength).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastFiredAt: ").Append(LastFiredAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            // PreviewLength (int) maximum
            if (this.PreviewLength > (int)280)
            {
                yield return new ValidationResult("Invalid value for PreviewLength, must be a value less than or equal to 280.", new [] { "PreviewLength" });
            }

            // PreviewLength (int) minimum
            if (this.PreviewLength < (int)0)
            {
                yield return new ValidationResult("Invalid value for PreviewLength, must be a value greater than or equal to 0.", new [] { "PreviewLength" });
            }

            yield break;
        }
    }

}
