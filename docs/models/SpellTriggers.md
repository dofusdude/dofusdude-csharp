# Dofusdude.Api.Model.SpellTriggers
Determines when an effect activates. Events are not additional effects to apply unconditionally. Use logic with the resolved event names and descriptions instead of parsing raw tokens.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Raw** | **string** | Original trigger tokens retained for lossless debugging. | 
**Events** | [**List&lt;SpellTrigger&gt;**](SpellTrigger.md) |  | 
**Logic** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

