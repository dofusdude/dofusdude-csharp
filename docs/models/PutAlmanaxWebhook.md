# Dofusdude.Api.Model.PutAlmanaxWebhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BonusWhitelist** | **List&lt;string&gt;** | from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing. | [optional] 
**BonusBlacklist** | **List&lt;string&gt;** | from all available bonuses (ids) from /dofus3/meta/{language}/almanax/bonuses. Delete old entries with empty array []. Just null changes nothing. | [optional] 
**Subscriptions** | **List&lt;string&gt;** | Get the available subscriptions with /meta/webhooks/almanax | [optional] 
**DailySettings** | [**CreateAlmanaxWebhookDailySettings**](CreateAlmanaxWebhookDailySettings.md) |  | [optional] 
**IsoDate** | **bool** | If false, it will use common local time formats and weekday translations. If true, the format is YYYY-MM-DD. | [optional] [default to false]
**Mentions** | **Dictionary&lt;string, List&lt;CreateAlmanaxWebhookMentionsValueInner&gt;&gt;** | Almanax bonus ids mapped to array of mentions. | [optional] 
**Intervals** | **List&lt;PutAlmanaxWebhook.IntervalsEnum&gt;** |  | [optional] 
**WeeklyWeekday** | **string** | When to post the weekly preview at the specified time. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

