# Dofusdude.Api.Model.EffectZone

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Shape** | [**ZoneShape**](ZoneShape.md) |  | 
**CellIds** | **List&lt;int&gt;** |  | 
**Raw** | **string** | Original compact zone encoding when the source provides one. | [optional] 
**Size** | **int** | Effective outer size of the area. A point has size 0; whole-map and custom-cell shapes omit it. | [optional] 
**MinSize** | **int** | Effective inner size for hollow or minimum-size shapes. Omitted when the shape has no inner boundary. | [optional] 
**DamageDecreaseStepPercent** | **int** |  | [optional] 
**MaxDamageDecreaseApplyCount** | **int** |  | [optional] 
**ForcedDirection** | **int** |  | [optional] 
**IncludeCarried** | **bool** |  | [optional] 
**StopAtTarget** | **bool** |  | [optional] 
**OnlyAffectInSightLine** | **bool** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

