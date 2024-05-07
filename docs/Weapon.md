# Dofusdude.Api.Model.Weapon

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | [**ItemsListEntryTypedType**](ItemsListEntryTypedType.md) |  | [optional] 
**IsWeapon** | **bool** | always true when the item is a weapon. Many fields are now available. Always check for this flag first when getting single equipment items. | [optional] 
**Level** | **int** |  | [optional] 
**Pods** | **int** |  | [optional] 
**ImageUrls** | [**ImageUrls**](ImageUrls.md) |  | [optional] 
**Effects** | [**List&lt;EffectsEntry&gt;**](EffectsEntry.md) |  | [optional] 
**Conditions** | [**List&lt;ConditionEntry&gt;**](ConditionEntry.md) |  | [optional] 
**ConditionTree** | [**ConditionTreeNode**](ConditionTreeNode.md) |  | [optional] 
**CriticalHitProbability** | **int** |  | [optional] 
**CriticalHitBonus** | **int** |  | [optional] 
**IsTwoHanded** | **bool** |  | [optional] 
**MaxCastPerTurn** | **int** |  | [optional] 
**ApCost** | **int** |  | [optional] 
**Range** | [**WeaponRange**](WeaponRange.md) |  | [optional] 
**Recipe** | [**List&lt;RecipeEntry&gt;**](RecipeEntry.md) |  | [optional] 
**ParentSet** | [**ItemListEntryParentSet**](ItemListEntryParentSet.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

