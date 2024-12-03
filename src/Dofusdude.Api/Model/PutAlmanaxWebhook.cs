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
    /// PutAlmanaxWebhook
    /// </summary>
    [DataContract(Name = "PutAlmanaxWebhook")]
    public partial class PutAlmanaxWebhook : IValidatableObject
    {
        /// <summary>
        /// Defines Intervals
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalsEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3
        }

        /// <summary>
        /// When to post the weekly preview at the specified time.
        /// </summary>
        /// <value>When to post the weekly preview at the specified time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WeeklyWeekdayEnum
        {
            /// <summary>
            /// Enum Sunday for value: sunday
            /// </summary>
            [EnumMember(Value = "sunday")]
            Sunday = 1,

            /// <summary>
            /// Enum Monday for value: monday
            /// </summary>
            [EnumMember(Value = "monday")]
            Monday = 2,

            /// <summary>
            /// Enum Tuesday for value: tuesday
            /// </summary>
            [EnumMember(Value = "tuesday")]
            Tuesday = 3,

            /// <summary>
            /// Enum Wednesday for value: wednesday
            /// </summary>
            [EnumMember(Value = "wednesday")]
            Wednesday = 4,

            /// <summary>
            /// Enum Thursday for value: thursday
            /// </summary>
            [EnumMember(Value = "thursday")]
            Thursday = 5,

            /// <summary>
            /// Enum Friday for value: friday
            /// </summary>
            [EnumMember(Value = "friday")]
            Friday = 6,

            /// <summary>
            /// Enum Saturday for value: saturday
            /// </summary>
            [EnumMember(Value = "saturday")]
            Saturday = 7
        }


        /// <summary>
        /// When to post the weekly preview at the specified time.
        /// </summary>
        /// <value>When to post the weekly preview at the specified time.</value>
        /*
        <example>sunday</example>
        */
        [DataMember(Name = "weekly_weekday", EmitDefaultValue = true)]
        public WeeklyWeekdayEnum? WeeklyWeekday { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutAlmanaxWebhook" /> class.
        /// </summary>
        /// <param name="bonusWhitelist">from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing..</param>
        /// <param name="bonusBlacklist">from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing..</param>
        /// <param name="subscriptions">Get the available subscriptions with /meta/webhooks/almanax.</param>
        /// <param name="dailySettings">dailySettings.</param>
        /// <param name="isoDate">If false, it will use common local time formats and weekday translations. If true, the format is YYYY-MM-DD. (default to false).</param>
        /// <param name="mentions">Almanax bonus ids mapped to array of mentions..</param>
        /// <param name="intervals">intervals.</param>
        /// <param name="weeklyWeekday">When to post the weekly preview at the specified time..</param>
        public PutAlmanaxWebhook(List<string> bonusWhitelist = default(List<string>), List<string> bonusBlacklist = default(List<string>), List<string> subscriptions = default(List<string>), CreateAlmanaxWebhookDailySettings dailySettings = default(CreateAlmanaxWebhookDailySettings), bool? isoDate = false, Dictionary<string, List<CreateAlmanaxWebhookMentionsValueInner>> mentions = default(Dictionary<string, List<CreateAlmanaxWebhookMentionsValueInner>>), List<IntervalsEnum> intervals = default(List<IntervalsEnum>), WeeklyWeekdayEnum? weeklyWeekday = default(WeeklyWeekdayEnum?))
        {
            this.BonusWhitelist = bonusWhitelist;
            this.BonusBlacklist = bonusBlacklist;
            this.Subscriptions = subscriptions;
            this.DailySettings = dailySettings;
            // use default value if no "isoDate" provided
            this.IsoDate = isoDate ?? false;
            this.Mentions = mentions;
            this.Intervals = intervals;
            this.WeeklyWeekday = weeklyWeekday;
        }

        /// <summary>
        /// from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing.
        /// </summary>
        /// <value>from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing.</value>
        [DataMember(Name = "bonus_whitelist", EmitDefaultValue = true)]
        public List<string> BonusWhitelist { get; set; }

        /// <summary>
        /// from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing.
        /// </summary>
        /// <value>from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing.</value>
        [DataMember(Name = "bonus_blacklist", EmitDefaultValue = true)]
        public List<string> BonusBlacklist { get; set; }

        /// <summary>
        /// Get the available subscriptions with /meta/webhooks/almanax
        /// </summary>
        /// <value>Get the available subscriptions with /meta/webhooks/almanax</value>
        [DataMember(Name = "subscriptions", EmitDefaultValue = true)]
        public List<string> Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets DailySettings
        /// </summary>
        [DataMember(Name = "daily_settings", EmitDefaultValue = true)]
        public CreateAlmanaxWebhookDailySettings DailySettings { get; set; }

        /// <summary>
        /// If false, it will use common local time formats and weekday translations. If true, the format is YYYY-MM-DD.
        /// </summary>
        /// <value>If false, it will use common local time formats and weekday translations. If true, the format is YYYY-MM-DD.</value>
        [DataMember(Name = "iso_date", EmitDefaultValue = true)]
        public bool? IsoDate { get; set; }

        /// <summary>
        /// Almanax bonus ids mapped to array of mentions.
        /// </summary>
        /// <value>Almanax bonus ids mapped to array of mentions.</value>
        /*
        <example>{&quot;kolossium-experience&quot;:[{&quot;discord_id&quot;:1234,&quot;is_role&quot;:true,&quot;ping_days_before&quot;:null}]}</example>
        */
        [DataMember(Name = "mentions", EmitDefaultValue = false)]
        public Dictionary<string, List<CreateAlmanaxWebhookMentionsValueInner>> Mentions { get; set; }

        /// <summary>
        /// Gets or Sets Intervals
        /// </summary>
        /*
        <example>[&quot;daily&quot;]</example>
        */
        [DataMember(Name = "intervals", EmitDefaultValue = true)]
        public List<PutAlmanaxWebhook.IntervalsEnum> Intervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutAlmanaxWebhook {\n");
            sb.Append("  BonusWhitelist: ").Append(BonusWhitelist).Append("\n");
            sb.Append("  BonusBlacklist: ").Append(BonusBlacklist).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  DailySettings: ").Append(DailySettings).Append("\n");
            sb.Append("  IsoDate: ").Append(IsoDate).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            sb.Append("  WeeklyWeekday: ").Append(WeeklyWeekday).Append("\n");
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
