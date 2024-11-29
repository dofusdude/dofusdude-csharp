# Dofusdude.Api.Model.Weapon

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | [**TranslatedId**](TranslatedId.md) |  | [optional] 
**IsWeapon** | **bool** | always true when the item is a weapon. Many fields are now available. Always check for this flag first when getting single equipment items. | [optional] 
**Level** | **int** |  | [optional] 
**Pods** | **int** |  | [optional] 
**ImageUrls** | [**Images**](Images.md) |  | [optional] 
**Effects** | [**List&lt;Effect&gt;**](Effect.md) |  | [optional] 
**Conditions** | [**ConditionNode**](ConditionNode.md) |  | [optional] 
**CriticalHitProbability** | **int** |  | [optional] 
**CriticalHitBonus** | **int** |  | [optional] 
**MaxCastPerTurn** | **int** |  | [optional] 
**ApCost** | **int** |  | [optional] 
**Range** | [**Range**](Range.md) |  | [optional] 
**Recipe** | [**List&lt;Recipe&gt;**](Recipe.md) |  | [optional] 
**ParentSet** | [**TranslatedId**](TranslatedId.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

