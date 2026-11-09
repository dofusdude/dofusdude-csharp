# Dofusdude.Api.Model.MonsterGlobalDrop
A separate global-drop entry with a base percentage range. It is not the per-monster-grade rates table and does not by itself define a final player-specific drop chance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Item** | [**CombatReference**](CombatReference.md) |  | 
**MinPercent** | **double** |  | 
**MaxPercent** | **double** |  | 
**HasConditions** | **bool** |  | [optional] 
**Condition** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**AlterationId** | **int** |  | [optional] 
**DisableDropModifier** | **bool** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

