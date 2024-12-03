/*
 * dofusdude
 *
 * # Open Ankama Developer Community The all-in-one toolbelt for your next Ankama related project.  ## Versions - [Dofus 2](https://docs.dofusdu.de/dofus2/) - [Dofus 3](https://docs.dofusdu.de/dofus3/)   - v1 [latest] (you are here)   ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Almanax Discord Integration** Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 3 Beta** from stable to bleeding edge by replacing /dofus3 with /dofus3beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_, _de_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Official Sources** generated from actual data from the game.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 1.0.0-rc.8
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
    /// ListEquipmentSet
    /// </summary>
    [DataContract(Name = "ListEquipmentSet")]
    public partial class ListEquipmentSet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListEquipmentSet" /> class.
        /// </summary>
        /// <param name="ankamaId">ankamaId.</param>
        /// <param name="name">name.</param>
        /// <param name="items">amount.</param>
        /// <param name="level">level.</param>
        /// <param name="effects">effects.</param>
        /// <param name="equipmentIds">equipmentIds.</param>
        /// <param name="containsCosmetics">containsCosmetics.</param>
        /// <param name="containsCosmeticsOnly">containsCosmeticsOnly.</param>
        public ListEquipmentSet(int ankamaId = default(int), string name = default(string), int items = default(int), int level = default(int), Dictionary<string, List<Effect>> effects = default(Dictionary<string, List<Effect>>), List<int> equipmentIds = default(List<int>), bool containsCosmetics = default(bool), bool containsCosmeticsOnly = default(bool))
        {
            this.AnkamaId = ankamaId;
            this.Name = name;
            this.Items = items;
            this.Level = level;
            this.Effects = effects;
            this.EquipmentIds = equipmentIds;
            this.ContainsCosmetics = containsCosmetics;
            this.ContainsCosmeticsOnly = containsCosmeticsOnly;
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
        /// amount
        /// </summary>
        /// <value>amount</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public int Items { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets Effects
        /// </summary>
        [DataMember(Name = "effects", EmitDefaultValue = false)]
        public Dictionary<string, List<Effect>> Effects { get; set; }

        /// <summary>
        /// Gets or Sets EquipmentIds
        /// </summary>
        [DataMember(Name = "equipment_ids", EmitDefaultValue = true)]
        public List<int> EquipmentIds { get; set; }

        /// <summary>
        /// Gets or Sets ContainsCosmetics
        /// </summary>
        [DataMember(Name = "contains_cosmetics", EmitDefaultValue = true)]
        public bool ContainsCosmetics { get; set; }

        /// <summary>
        /// Gets or Sets ContainsCosmeticsOnly
        /// </summary>
        [DataMember(Name = "contains_cosmetics_only", EmitDefaultValue = true)]
        public bool ContainsCosmeticsOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListEquipmentSet {\n");
            sb.Append("  AnkamaId: ").Append(AnkamaId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
            sb.Append("  EquipmentIds: ").Append(EquipmentIds).Append("\n");
            sb.Append("  ContainsCosmetics: ").Append(ContainsCosmetics).Append("\n");
            sb.Append("  ContainsCosmeticsOnly: ").Append(ContainsCosmeticsOnly).Append("\n");
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
