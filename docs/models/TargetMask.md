# Dofusdude.Api.Model.TargetMask
Determines who an effect may affect. Combine the resolved selectors and conditions using logic. This is distinct from the zone geometry and from the event that triggers the effect.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Raw** | **string** | Original game mask retained for lossless debugging. | 
**Selectors** | [**List&lt;TargetSelector&gt;**](TargetSelector.md) |  | 
**Logic** | **string** |  | [optional] 
**Conditions** | [**List&lt;CombatCondition&gt;**](CombatCondition.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

