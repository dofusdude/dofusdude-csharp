# Dofusdude.Api.Model.Class
A playable class with its characteristics, appearance and class spell assignments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | 
**Name** | **string** |  | 
**Looks** | [**ClassLooks**](ClassLooks.md) |  | 
**Spells** | [**List&lt;Spell&gt;**](Spell.md) | Fully mapped class spells, including levels, effects, targeting, and zones. | 
**Description** | **string** |  | [optional] 
**GameplayDescription** | **string** |  | [optional] 
**Complexity** | **int** |  | [optional] 
**SortIndex** | **int** |  | [optional] 
**CreatureBonesId** | **int** |  | [optional] 
**Roles** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 
**CharacteristicCosts** | **Dictionary&lt;string, List&lt;ClassCharacteristicCostsValueInner&gt;&gt;** | Characteristic point-cost tiers keyed by characteristic name. | [optional] 
**ImageUrls** | [**Images**](Images.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

