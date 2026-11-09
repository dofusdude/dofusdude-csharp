# Dofusdude.Api.Model.EffectZone
Combat-cell area for this effect or activation context, not a geographic world area. Shape, size and inner size describe geometry. Actual affected cells can depend on position, direction and fight state. Each spell effect can have a different zone.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Shape** | [**ZoneShape**](ZoneShape.md) |  | 
**CellIds** | **List&lt;int&gt;** | Explicit cells for a custom-cell shape. An empty array is normal for geometric shapes such as circles and does not mean the zone affects no cells. | 
**Raw** | **string** | Original compact zone encoding when the source provides one. | [optional] 
**Size** | **int** | Effective outer size of the area. A point has size 0. Whole-map and custom-cell shapes omit it. | [optional] 
**MinSize** | **int** | Effective inner size for hollow or minimum-size shapes. Omitted when the shape has no inner boundary. | [optional] 
**DamageDecreaseStepPercent** | **int** |  | [optional] 
**MaxDamageDecreaseApplyCount** | **int** |  | [optional] 
**ForcedDirection** | **int** |  | [optional] 
**IncludeCarried** | **bool** |  | [optional] 
**StopAtTarget** | **bool** |  | [optional] 
**OnlyAffectInSightLine** | **bool** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

