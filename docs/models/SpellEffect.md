# Dofusdude.Api.Model.SpellEffect
One normal or critical effect of a particular spell grade. Its zone defines where it applies, target_mask defines eligible targets and triggers defines activation events. Templated text is for display, not a formula to parse.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Localized effect category, such as Air damage. This is not a spell ID or a structured game reference. | [optional] 
**Min** | **int** |  | [optional] 
**Max** | **int** |  | [optional] 
**Duration** | **int** | Effect duration in fight turns as represented by the source. Not a real-time duration in seconds. | [optional] 
**Delay** | **int** | Delay before the effect in fight turns as represented by the source. | [optional] 
**Random** | **decimal** | Source random-selection value. Do not interpret it as a percentage without the effect&#39;s selection rules. | [optional] 
**Group** | **int** |  | [optional] 
**Dispellable** | **int** |  | [optional] 
**EffectUid** | **int** | Stable identifier of this concrete effect instance. | [optional] 
**TargetId** | **int** |  | [optional] 
**TriggeredDuration** | **int** |  | [optional] 
**DisplayZero** | **bool** |  | [optional] 
**Modifier** | **int** |  | [optional] 
**Zone** | [**EffectZone**](EffectZone.md) |  | [optional] 
**TargetMask** | [**TargetMask**](TargetMask.md) |  | [optional] 
**Triggers** | [**SpellTriggers**](SpellTriggers.md) |  | [optional] 
**Templated** | **string** | Localized effect text suitable for display. Numeric effect properties remain available separately. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

