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
    /// EffectsEntry
    /// </summary>
    [DataContract(Name = "Effects-Entry")]
    public partial class EffectsEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsEntry" /> class.
        /// </summary>
        /// <param name="intMinimum">minimum int value, can be a single if ignore_int_max and no ignore_int_min.</param>
        /// <param name="intMaximum">maximum int value, if not ignore_int_max and not ignore_int_min, the effect has a range value.</param>
        /// <param name="type">type.</param>
        /// <param name="ignoreIntMin">ignore the int min field because the actual value is a string. For readability the templated field is the only important field in this case. .</param>
        /// <param name="ignoreIntMax">ignore the int max field, if ignore_int_min is true, int min is a single value.</param>
        /// <param name="formatted">all fields from above encoded in a single string.</param>
        public EffectsEntry(int intMinimum = default(int), int intMaximum = default(int), SetEffectsEntryType type = default(SetEffectsEntryType), bool ignoreIntMin = default(bool), bool ignoreIntMax = default(bool), string formatted = default(string))
        {
            this.IntMinimum = intMinimum;
            this.IntMaximum = intMaximum;
            this.Type = type;
            this.IgnoreIntMin = ignoreIntMin;
            this.IgnoreIntMax = ignoreIntMax;
            this.Formatted = formatted;
        }

        /// <summary>
        /// minimum int value, can be a single if ignore_int_max and no ignore_int_min
        /// </summary>
        /// <value>minimum int value, can be a single if ignore_int_max and no ignore_int_min</value>
        [DataMember(Name = "int_minimum", EmitDefaultValue = false)]
        public int IntMinimum { get; set; }

        /// <summary>
        /// maximum int value, if not ignore_int_max and not ignore_int_min, the effect has a range value
        /// </summary>
        /// <value>maximum int value, if not ignore_int_max and not ignore_int_min, the effect has a range value</value>
        [DataMember(Name = "int_maximum", EmitDefaultValue = false)]
        public int IntMaximum { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public SetEffectsEntryType Type { get; set; }

        /// <summary>
        /// ignore the int min field because the actual value is a string. For readability the templated field is the only important field in this case. 
        /// </summary>
        /// <value>ignore the int min field because the actual value is a string. For readability the templated field is the only important field in this case. </value>
        [DataMember(Name = "ignore_int_min", EmitDefaultValue = true)]
        public bool IgnoreIntMin { get; set; }

        /// <summary>
        /// ignore the int max field, if ignore_int_min is true, int min is a single value
        /// </summary>
        /// <value>ignore the int max field, if ignore_int_min is true, int min is a single value</value>
        [DataMember(Name = "ignore_int_max", EmitDefaultValue = true)]
        public bool IgnoreIntMax { get; set; }

        /// <summary>
        /// all fields from above encoded in a single string
        /// </summary>
        /// <value>all fields from above encoded in a single string</value>
        [DataMember(Name = "formatted", EmitDefaultValue = false)]
        public string Formatted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EffectsEntry {\n");
            sb.Append("  IntMinimum: ").Append(IntMinimum).Append("\n");
            sb.Append("  IntMaximum: ").Append(IntMaximum).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IgnoreIntMin: ").Append(IgnoreIntMin).Append("\n");
            sb.Append("  IgnoreIntMax: ").Append(IgnoreIntMax).Append("\n");
            sb.Append("  Formatted: ").Append(Formatted).Append("\n");
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
