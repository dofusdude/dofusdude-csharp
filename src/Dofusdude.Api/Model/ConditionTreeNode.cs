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
using System.Reflection;

namespace Dofusdude.Api.Model
{
    /// <summary>
    /// ConditionTreeNode
    /// </summary>
    [JsonConverter(typeof(ConditionTreeNodeJsonConverter))]
    [DataContract(Name = "Condition-Tree-Node")]
    public partial class ConditionTreeNode : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionTreeNode" /> class
        /// with the <see cref="ConditionTreeRelation" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ConditionTreeRelation.</param>
        public ConditionTreeNode(ConditionTreeRelation actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionTreeNode" /> class
        /// with the <see cref="ConditionTreeLeaf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ConditionTreeLeaf.</param>
        public ConditionTreeNode(ConditionTreeLeaf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(ConditionTreeLeaf) || value is ConditionTreeLeaf)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ConditionTreeRelation) || value is ConditionTreeRelation)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ConditionTreeLeaf, ConditionTreeRelation");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ConditionTreeRelation`. If the actual instance is not `ConditionTreeRelation`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ConditionTreeRelation</returns>
        public ConditionTreeRelation GetConditionTreeRelation()
        {
            return (ConditionTreeRelation)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ConditionTreeLeaf`. If the actual instance is not `ConditionTreeLeaf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ConditionTreeLeaf</returns>
        public ConditionTreeLeaf GetConditionTreeLeaf()
        {
            return (ConditionTreeLeaf)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionTreeNode {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, ConditionTreeNode.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ConditionTreeNode
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ConditionTreeNode</returns>
        public static ConditionTreeNode FromJson(string jsonString)
        {
            ConditionTreeNode newConditionTreeNode = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newConditionTreeNode;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ConditionTreeLeaf).GetProperty("AdditionalProperties") == null)
                {
                    newConditionTreeNode = new ConditionTreeNode(JsonConvert.DeserializeObject<ConditionTreeLeaf>(jsonString, ConditionTreeNode.SerializerSettings));
                }
                else
                {
                    newConditionTreeNode = new ConditionTreeNode(JsonConvert.DeserializeObject<ConditionTreeLeaf>(jsonString, ConditionTreeNode.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ConditionTreeLeaf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ConditionTreeLeaf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ConditionTreeRelation).GetProperty("AdditionalProperties") == null)
                {
                    newConditionTreeNode = new ConditionTreeNode(JsonConvert.DeserializeObject<ConditionTreeRelation>(jsonString, ConditionTreeNode.SerializerSettings));
                }
                else
                {
                    newConditionTreeNode = new ConditionTreeNode(JsonConvert.DeserializeObject<ConditionTreeRelation>(jsonString, ConditionTreeNode.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ConditionTreeRelation");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ConditionTreeRelation: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newConditionTreeNode;
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

    /// <summary>
    /// Custom JSON converter for ConditionTreeNode
    /// </summary>
    public class ConditionTreeNodeJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ConditionTreeNode).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return ConditionTreeNode.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ConditionTreeNode.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
