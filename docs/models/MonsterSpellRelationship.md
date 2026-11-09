# Dofusdude.Api.Model.MonsterSpellRelationship
Compact spell assignment inside one monster grade. The assignment's grade identifies the spell variant, not the enclosing monster variant. Follow url unchanged to retrieve it or use an include option to embed it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | 
**Name** | **string** |  | 
**Grade** | **int** | Grade of the assigned spell. It does not need to equal the enclosing MonsterGrade.grade. | 
**Url** | **string** | URL for the assigned spell grade. Includes the &#x60;grade&#x60; query parameter. | 
**ImageUrls** | [**Images**](Images.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

