# Dofusdude.Api.Model.MonsterDrop
A possible item drop with base rates indexed by monster grade. Final player-specific chances also depend on conditions and game modifiers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Item** | [**CombatReference**](CombatReference.md) |  | 
**RatesPercent** | [**List&lt;MonsterDropRatesPercentInner&gt;**](MonsterDropRatesPercentInner.md) | Base drop percentages indexed by MonsterGrade.grade, not spell grade or array position. A value of 5 means 5 percent, not 0.05 percent. These are not spawn percentages. | 
**HasConditions** | **bool** | The source reports restrictions. Can be true without a complete client-side condition tree because server-only predicates are not exposed. | 
**DropId** | **int** |  | [optional] 
**Count** | **int** |  | [optional] 
**Condition** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**HiddenIfInvalidConditions** | **bool** |  | [optional] 
**DisableDropModifier** | **bool** |  | [optional] 
**SpecificCoefficients** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

