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
    /// Mention
    /// </summary>
    [DataContract(Name = "CreateAlmanaxWebhook_mentions_value_inner")]
    public partial class CreateAlmanaxWebhookMentionsValueInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlmanaxWebhookMentionsValueInner" /> class.
        /// </summary>
        /// <param name="discordId">User or role ID directly from Discord. Activate developer mode and right click a user or role to get them..</param>
        /// <param name="isRole">Whether an ID describes a role (true) or user (false). This is needed for formatting the mention command so Discord understands it..</param>
        /// <param name="pingDaysBefore">Get a mention days before the bonus comes up. It will post on the specified time. Also works when the interval is not daily..</param>
        public CreateAlmanaxWebhookMentionsValueInner(int discordId = default(int), bool isRole = default(bool), int? pingDaysBefore = default(int?))
        {
            this.DiscordId = discordId;
            this.IsRole = isRole;
            this.PingDaysBefore = pingDaysBefore;
        }

        /// <summary>
        /// User or role ID directly from Discord. Activate developer mode and right click a user or role to get them.
        /// </summary>
        /// <value>User or role ID directly from Discord. Activate developer mode and right click a user or role to get them.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "discord_id", EmitDefaultValue = false)]
        public int DiscordId { get; set; }

        /// <summary>
        /// Whether an ID describes a role (true) or user (false). This is needed for formatting the mention command so Discord understands it.
        /// </summary>
        /// <value>Whether an ID describes a role (true) or user (false). This is needed for formatting the mention command so Discord understands it.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "is_role", EmitDefaultValue = true)]
        public bool IsRole { get; set; }

        /// <summary>
        /// Get a mention days before the bonus comes up. It will post on the specified time. Also works when the interval is not daily.
        /// </summary>
        /// <value>Get a mention days before the bonus comes up. It will post on the specified time. Also works when the interval is not daily.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "ping_days_before", EmitDefaultValue = true)]
        public int? PingDaysBefore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAlmanaxWebhookMentionsValueInner {\n");
            sb.Append("  DiscordId: ").Append(DiscordId).Append("\n");
            sb.Append("  IsRole: ").Append(IsRole).Append("\n");
            sb.Append("  PingDaysBefore: ").Append(PingDaysBefore).Append("\n");
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
            // PingDaysBefore (int?) maximum
            if (this.PingDaysBefore > (int?)31)
            {
                yield return new ValidationResult("Invalid value for PingDaysBefore, must be a value less than or equal to 31.", new [] { "PingDaysBefore" });
            }

            // PingDaysBefore (int?) minimum
            if (this.PingDaysBefore < (int?)1)
            {
                yield return new ValidationResult("Invalid value for PingDaysBefore, must be a value greater than or equal to 1.", new [] { "PingDaysBefore" });
            }

            yield break;
        }
    }

}
