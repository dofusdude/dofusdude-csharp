# Dofusdude.Api.Model.CreateAlmanaxWebhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BonusWhitelist** | **List&lt;string&gt;** | from all available bonuses (ids) from /dofus2/meta/{language}/almanax/bonuses | [optional] 
**BonusBlacklist** | **List&lt;string&gt;** | from all available bonuses (ids) from /dofus2/meta/{language}/almanax/bonuses | [optional] 
**Subscriptions** | **List&lt;string&gt;** | Get the available subscriptions with /meta/webhooks/almanax | 
**Format** | **string** |  | 
**Callback** | **string** | Discord Webhook URL | 
**DailySettings** | [**CreateAlmanaxWebhookDailySettings**](CreateAlmanaxWebhookDailySettings.md) |  | [optional] 
**IsoDate** | **bool?** | If false, it will use common local time formats and weekday translations. If true, the format is YYYY-MM-DD. | [optional] [default to false]
**Mentions** | **Dictionary&lt;string, List&lt;CreateAlmanaxWebhookMentionsValueInner&gt;&gt;** | Almanax bonus ids mapped to array of mentions. | [optional] 
**Intervals** | **List&lt;CreateAlmanaxWebhook.IntervalsEnum&gt;** | - Daily posts each day, filtering with Black/Whitelist and mentions are applied daily. - Weekly posts the next 7 days (excluding the posting day) once per week at the specified time. With only weekly selected, of all mentions, only prior notices will come through daily. The 7 day preview gets filtered by the Black/Whitelist. - Monthly posts a preview of the next month from first to last date. The post will be on the last day of a month (ignoring day of the week) at the specified time. Mentions and filtering works like weekly. The biggest difference between daily and the other two is that daily always posts the current day while monthly and weekly only show future days. You can always combine the intervals by selecting multiple intervals for one hook or create multiple hooks for the same channel with different settings to get every highly specific combination you want. | 
**WeeklyWeekday** | **string** | When to post the weekly preview at the specified time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

