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
    /// ItemListEntry
    /// </summary>
    [DataContract(Name = "Item-List-Entry")]
    public partial class ItemListEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemListEntry" /> class.
        /// </summary>
        /// <param name="ankamaId">ankamaId.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="level">level.</param>
        /// <param name="imageUrls">imageUrls.</param>
        /// <param name="recipe">recipe.</param>
        /// <param name="description">description.</param>
        /// <param name="conditions">conditions.</param>
        /// <param name="conditionTree">conditionTree.</param>
        /// <param name="effects">effects.</param>
        /// <param name="isWeapon">isWeapon.</param>
        /// <param name="pods">pods.</param>
        /// <param name="parentSet">parentSet.</param>
        /// <param name="criticalHitProbability">criticalHitProbability.</param>
        /// <param name="criticalHitBonus">criticalHitBonus.</param>
        /// <param name="isTwoHanded">isTwoHanded.</param>
        /// <param name="maxCastPerTurn">maxCastPerTurn.</param>
        /// <param name="apCost">apCost.</param>
        /// <param name="range">range.</param>
        public ItemListEntry(int ankamaId = default(int), string name = default(string), ItemsListEntryTypedType type = default(ItemsListEntryTypedType), int level = default(int), ImageUrls imageUrls = default(ImageUrls), List<RecipeEntry> recipe = default(List<RecipeEntry>), string description = default(string), List<ConditionEntry> conditions = default(List<ConditionEntry>), ConditionTreeNode conditionTree = default(ConditionTreeNode), List<EffectsEntry> effects = default(List<EffectsEntry>), bool? isWeapon = default(bool?), int? pods = default(int?), ItemListEntryParentSet parentSet = default(ItemListEntryParentSet), int? criticalHitProbability = default(int?), int? criticalHitBonus = default(int?), bool? isTwoHanded = default(bool?), int? maxCastPerTurn = default(int?), int? apCost = default(int?), ItemListEntryRange range = default(ItemListEntryRange))
        {
            this.AnkamaId = ankamaId;
            this.Name = name;
            this.Type = type;
            this.Level = level;
            this.ImageUrls = imageUrls;
            this.Recipe = recipe;
            this.Description = description;
            this.Conditions = conditions;
            this.ConditionTree = conditionTree;
            this.Effects = effects;
            this.IsWeapon = isWeapon;
            this.Pods = pods;
            this.ParentSet = parentSet;
            this.CriticalHitProbability = criticalHitProbability;
            this.CriticalHitBonus = criticalHitBonus;
            this.IsTwoHanded = isTwoHanded;
            this.MaxCastPerTurn = maxCastPerTurn;
            this.ApCost = apCost;
            this.Range = range;
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
        public ItemsListEntryTypedType Type { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrls
        /// </summary>
        [DataMember(Name = "image_urls", EmitDefaultValue = false)]
        public ImageUrls ImageUrls { get; set; }

        /// <summary>
        /// Gets or Sets Recipe
        /// </summary>
        [DataMember(Name = "recipe", EmitDefaultValue = true)]
        public List<RecipeEntry> Recipe { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", EmitDefaultValue = true)]
        [Obsolete]
        public List<ConditionEntry> Conditions { get; set; }

        /// <summary>
        /// Gets or Sets ConditionTree
        /// </summary>
        [DataMember(Name = "condition_tree", EmitDefaultValue = false)]
        public ConditionTreeNode ConditionTree { get; set; }

        /// <summary>
        /// Gets or Sets Effects
        /// </summary>
        [DataMember(Name = "effects", EmitDefaultValue = true)]
        public List<EffectsEntry> Effects { get; set; }

        /// <summary>
        /// Gets or Sets IsWeapon
        /// </summary>
        [DataMember(Name = "is_weapon", EmitDefaultValue = true)]
        public bool? IsWeapon { get; set; }

        /// <summary>
        /// Gets or Sets Pods
        /// </summary>
        [DataMember(Name = "pods", EmitDefaultValue = true)]
        public int? Pods { get; set; }

        /// <summary>
        /// Gets or Sets ParentSet
        /// </summary>
        [DataMember(Name = "parent_set", EmitDefaultValue = true)]
        public ItemListEntryParentSet ParentSet { get; set; }

        /// <summary>
        /// Gets or Sets CriticalHitProbability
        /// </summary>
        [DataMember(Name = "critical_hit_probability", EmitDefaultValue = true)]
        public int? CriticalHitProbability { get; set; }

        /// <summary>
        /// Gets or Sets CriticalHitBonus
        /// </summary>
        [DataMember(Name = "critical_hit_bonus", EmitDefaultValue = true)]
        public int? CriticalHitBonus { get; set; }

        /// <summary>
        /// Gets or Sets IsTwoHanded
        /// </summary>
        [DataMember(Name = "is_two_handed", EmitDefaultValue = true)]
        public bool? IsTwoHanded { get; set; }

        /// <summary>
        /// Gets or Sets MaxCastPerTurn
        /// </summary>
        [DataMember(Name = "max_cast_per_turn", EmitDefaultValue = true)]
        public int? MaxCastPerTurn { get; set; }

        /// <summary>
        /// Gets or Sets ApCost
        /// </summary>
        [DataMember(Name = "ap_cost", EmitDefaultValue = true)]
        public int? ApCost { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name = "range", EmitDefaultValue = true)]
        public ItemListEntryRange Range { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemListEntry {\n");
            sb.Append("  AnkamaId: ").Append(AnkamaId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  ImageUrls: ").Append(ImageUrls).Append("\n");
            sb.Append("  Recipe: ").Append(Recipe).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  ConditionTree: ").Append(ConditionTree).Append("\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
            sb.Append("  IsWeapon: ").Append(IsWeapon).Append("\n");
            sb.Append("  Pods: ").Append(Pods).Append("\n");
            sb.Append("  ParentSet: ").Append(ParentSet).Append("\n");
            sb.Append("  CriticalHitProbability: ").Append(CriticalHitProbability).Append("\n");
            sb.Append("  CriticalHitBonus: ").Append(CriticalHitBonus).Append("\n");
            sb.Append("  IsTwoHanded: ").Append(IsTwoHanded).Append("\n");
            sb.Append("  MaxCastPerTurn: ").Append(MaxCastPerTurn).Append("\n");
            sb.Append("  ApCost: ").Append(ApCost).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            yield break;
        }
    }

}