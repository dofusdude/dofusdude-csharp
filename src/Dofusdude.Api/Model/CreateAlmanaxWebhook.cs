/*
 * dofusdude
 *
 * # Open Ankama Developer Community The all-in-one toolbelt for your next Ankama related project.  ## Versions - [Dofus 2](https://docs.dofusdu.de/dofus2/) - [Dofus 3](https://docs.dofusdu.de/dofus3/)   - v1 [latest] (you are here)   ## Client SDKs - [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save` - [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save` - [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo` - [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude` - [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup  Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.  Your favorite language is missing? Please let me know!  # Main Features - 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.  - ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.  - 📨 **Almanax Discord Integration** Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.  - 🩸 **Dofus 3 Beta** from stable to bleeding edge by replacing /dofus3 with /dofus3beta.  - 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_, _de_.  - 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.  - 🕵️ **Official Sources** generated from actual data from the game.  ... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h). 
 *
 * The version of the OpenAPI document: 1.0.0-rc.5
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
    /// CreateAlmanaxWebhook
    /// </summary>
    [DataContract(Name = "CreateAlmanaxWebhook")]
    public partial class CreateAlmanaxWebhook : IValidatableObject
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
        /// Initializes a new instance of the <see cref="CreateAlmanaxWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAlmanaxWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlmanaxWebhook" /> class.
        /// </summary>
        /// <param name="bonusWhitelist">from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses.</param>
        /// <param name="bonusBlacklist">from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses.</param>
        /// <param name="subscriptions">Get the available subscriptions with /meta/webhooks/almanax (required).</param>
        /// <param name="format">format (required).</param>
        /// <param name="callback">Discord Webhook URL (required).</param>
        /// <param name="dailySettings">dailySettings.</param>
        /// <param name="isoDate">If false, it will use common local time formats and weekday translations. If true, the format is YYYY-MM-DD. (default to false).</param>
        /// <param name="mentions">Almanax bonus ids mapped to array of mentions..</param>
        /// <param name="intervals">- Daily posts each day, filtering with Black/Whitelist and mentions are applied daily. - Weekly posts the next 7 days (excluding the posting day) once per week at the specified time. With only weekly selected, of all mentions, only prior notices will come through daily. The 7 day preview gets filtered by the Black/Whitelist. - Monthly posts a preview of the next month from first to last date. The post will be on the last day of a month (ignoring day of the week) at the specified time. Mentions and filtering works like weekly. The biggest difference between daily and the other two is that daily always posts the current day while monthly and weekly only show future days. You can always combine the intervals by selecting multiple intervals for one hook or create multiple hooks for the same channel with different settings to get every highly specific combination you want. (required).</param>
        /// <param name="weeklyWeekday">When to post the weekly preview at the specified time..</param>
        public CreateAlmanaxWebhook(List<string> bonusWhitelist = default(List<string>), List<string> bonusBlacklist = default(List<string>), List<string> subscriptions = default(List<string>), FormatEnum format = default(FormatEnum), string callback = default(string), CreateAlmanaxWebhookDailySettings dailySettings = default(CreateAlmanaxWebhookDailySettings), bool? isoDate = false, Dictionary<string, List<CreateAlmanaxWebhookMentionsValueInner>> mentions = default(Dictionary<string, List<CreateAlmanaxWebhookMentionsValueInner>>), List<IntervalsEnum> intervals = default(List<IntervalsEnum>), WeeklyWeekdayEnum? weeklyWeekday = default(WeeklyWeekdayEnum?))
        {
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new ArgumentNullException("subscriptions is a required property for CreateAlmanaxWebhook and cannot be null");
            }
            this.Subscriptions = subscriptions;
            this.Format = format;
            // to ensure "callback" is required (not null)
            if (callback == null)
            {
                throw new ArgumentNullException("callback is a required property for CreateAlmanaxWebhook and cannot be null");
            }
            this.Callback = callback;
            // to ensure "intervals" is required (not null)
            if (intervals == null)
            {
                throw new ArgumentNullException("intervals is a required property for CreateAlmanaxWebhook and cannot be null");
            }
            this.Intervals = intervals;
            this.BonusWhitelist = bonusWhitelist;
            this.BonusBlacklist = bonusBlacklist;
            this.DailySettings = dailySettings;
            // use default value if no "isoDate" provided
            this.IsoDate = isoDate ?? false;
            this.Mentions = mentions;
            this.WeeklyWeekday = weeklyWeekday;
        }

        /// <summary>
        /// from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses
        /// </summary>
        /// <value>from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses</value>
        [DataMember(Name = "bonus_whitelist", EmitDefaultValue = true)]
        public List<string> BonusWhitelist { get; set; }

        /// <summary>
        /// from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses
        /// </summary>
        /// <value>from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses</value>
        [DataMember(Name = "bonus_blacklist", EmitDefaultValue = true)]
        public List<string> BonusBlacklist { get; set; }

        /// <summary>
        /// Get the available subscriptions with /meta/webhooks/almanax
        /// </summary>
        /// <value>Get the available subscriptions with /meta/webhooks/almanax</value>
        [DataMember(Name = "subscriptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Subscriptions { get; set; }

        /// <summary>
        /// Discord Webhook URL
        /// </summary>
        /// <value>Discord Webhook URL</value>
        /*
        <example>https://discord.com/api/webhooks/XYZ</example>
        */
        [DataMember(Name = "callback", IsRequired = true, EmitDefaultValue = true)]
        public string Callback { get; set; }

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
        [DataMember(Name = "mentions", EmitDefaultValue = true)]
        public Dictionary<string, List<CreateAlmanaxWebhookMentionsValueInner>> Mentions { get; set; }

        /// <summary>
        /// - Daily posts each day, filtering with Black/Whitelist and mentions are applied daily. - Weekly posts the next 7 days (excluding the posting day) once per week at the specified time. With only weekly selected, of all mentions, only prior notices will come through daily. The 7 day preview gets filtered by the Black/Whitelist. - Monthly posts a preview of the next month from first to last date. The post will be on the last day of a month (ignoring day of the week) at the specified time. Mentions and filtering works like weekly. The biggest difference between daily and the other two is that daily always posts the current day while monthly and weekly only show future days. You can always combine the intervals by selecting multiple intervals for one hook or create multiple hooks for the same channel with different settings to get every highly specific combination you want.
        /// </summary>
        /// <value>- Daily posts each day, filtering with Black/Whitelist and mentions are applied daily. - Weekly posts the next 7 days (excluding the posting day) once per week at the specified time. With only weekly selected, of all mentions, only prior notices will come through daily. The 7 day preview gets filtered by the Black/Whitelist. - Monthly posts a preview of the next month from first to last date. The post will be on the last day of a month (ignoring day of the week) at the specified time. Mentions and filtering works like weekly. The biggest difference between daily and the other two is that daily always posts the current day while monthly and weekly only show future days. You can always combine the intervals by selecting multiple intervals for one hook or create multiple hooks for the same channel with different settings to get every highly specific combination you want.</value>
        /*
        <example>[&quot;daily&quot;]</example>
        */
        [DataMember(Name = "intervals", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateAlmanaxWebhook.IntervalsEnum> Intervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAlmanaxWebhook {\n");
            sb.Append("  BonusWhitelist: ").Append(BonusWhitelist).Append("\n");
            sb.Append("  BonusBlacklist: ").Append(BonusBlacklist).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
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
