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
    /// ListItemGeneral
    /// </summary>
    [DataContract(Name = "ListItemGeneral")]
    public partial class ListItemGeneral : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemGeneral" /> class.
        /// </summary>
        /// <param name="ankamaId">ankamaId.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="itemSubtype">itemSubtype.</param>
        /// <param name="level">level.</param>
        /// <param name="imageUrls">imageUrls.</param>
        public ListItemGeneral(int ankamaId = default(int), string name = default(string), TranslatedId type = default(TranslatedId), ItemSubtype itemSubtype = default(ItemSubtype), int level = default(int), Images imageUrls = default(Images))
        {
            this.AnkamaId = ankamaId;
            this.Name = name;
            this.Type = type;
            this.ItemSubtype = itemSubtype;
            this.Level = level;
            this.ImageUrls = imageUrls;
        }

        /// <summary>
        /// Gets or Sets AnkamaId
        /// </summary>
        [DataMember(Name = "ankama_id", EmitDefaultValue = false)]
        public int AnkamaId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TranslatedId Type { get; set; }

        /// <summary>
        /// Gets or Sets ItemSubtype
        /// </summary>
        [DataMember(Name = "item_subtype", EmitDefaultValue = false)]
        public ItemSubtype ItemSubtype { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrls
        /// </summary>
        [DataMember(Name = "image_urls", EmitDefaultValue = false)]
        public Images ImageUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListItemGeneral {\n");
            sb.Append("  AnkamaId: ").Append(AnkamaId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ItemSubtype: ").Append(ItemSubtype).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  ImageUrls: ").Append(ImageUrls).Append("\n");
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
            yield break;
        }
    }

}
