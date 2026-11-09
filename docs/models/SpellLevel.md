# Dofusdude.Api.Model.SpellLevel
One grade of a spell. The levels array contains these spell variants, not player levels. Grade numbers are local to the containing spell and are independent of monster grades.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** | ID of the spell-level definition. Different from the parent spell ID and from the grade number. Used by explicit spell-level references such as script spell_level_ids. | [optional] 
**Grade** | **int** | Number identifying this variant within its spell. Select by this value, not by the array position. Used by the spell detail endpoint&#39;s grade parameter. | [optional] 
**ApCost** | **int** | Action points required to cast this spell grade. | [optional] 
**CriticalHitProbability** | **int** | Base critical-hit percentage recorded for this spell grade, before fighter-specific modifiers. | [optional] 
**MinPlayerLevel** | **int** | Player-level requirement recorded for this spell grade. This is not its grade number or a monster combat level. | [optional] 
**MinRange** | **int** | Minimum casting range in combat cells. | [optional] 
**MaxRange** | **int** | Maximum casting range in combat cells as defined by this grade. | [optional] 
**MaxCastPerTurn** | **int** | Per-caster cast limit within a turn as recorded by the source. | [optional] 
**MaxCastPerTarget** | **int** |  | [optional] 
**MaxGlobalCastPerTurn** | **int** |  | [optional] 
**MaxGlobalCastPerTarget** | **int** |  | [optional] 
**MinCastInterval** | **int** | Minimum interval between casts, measured in fight turns. | [optional] 
**InitialCooldown** | **int** | Initial wait before casting, measured in fight turns. | [optional] 
**GlobalCooldown** | **int** |  | [optional] 
**IgnorePrisonGlyph** | **bool** |  | [optional] 
**SpellBreed** | **int** |  | [optional] 
**StatesCriterion** | [**EligibilityNode**](EligibilityNode.md) | Available client-side state requirements for this spell grade. Null does not assert that the server imposes no restriction. | [optional] 
**PreviewZones** | [**List&lt;SpellPreviewZone&gt;**](SpellPreviewZone.md) | Client preview and activation geometry for this grade. Use each effect&#39;s zone for its actual effect-area definition. | [optional] 
**Effects** | [**List&lt;SpellEffect&gt;**](SpellEffect.md) | Normal-cast effects for this grade. Each entry has independent targeting and area geometry. | [optional] 
**CriticalEffects** | [**List&lt;SpellEffect&gt;**](SpellEffect.md) | Critical-cast effects for this grade. Keep separate from normal effects rather than applying both arrays to every cast. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

