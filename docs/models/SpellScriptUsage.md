# Dofusdude.Api.Model.SpellScriptUsage
Resolved client-side spell script binding, including target selection and areas.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | [optional] 
**ScriptId** | **int** |  | [optional] 
**Order** | **int** |  | [optional] 
**Random** | **int** |  | [optional] 
**RandomGroup** | **int** |  | [optional] 
**SequenceGroup** | **int** |  | [optional] 
**ActivationMask** | [**TargetMask**](TargetMask.md) |  | [optional] 
**CasterMask** | [**TargetMask**](TargetMask.md) |  | [optional] 
**TargetMask** | [**TargetMask**](TargetMask.md) |  | [optional] 
**ActivationZone** | [**EffectZone**](EffectZone.md) |  | [optional] 
**TargetZone** | [**EffectZone**](EffectZone.md) |  | [optional] 
**Condition** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**TargetsAffectedConcurrently** | **bool** |  | [optional] 
**TargetTreatedAsCaster** | **bool** |  | [optional] 
**SpellLevelIds** | **List&lt;int&gt;** | Spell-level definition IDs to which this script binding applies. Match SpellLevel.ankama_id, not Spell.ankama_id or SpellLevel.grade. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

