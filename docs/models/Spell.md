# Dofusdude.Api.Model.Spell
A spell with its available grades, effects and casting rules.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | 
**Name** | **string** |  | 
**Levels** | [**List&lt;SpellLevel&gt;**](SpellLevel.md) | Available spell grades. Despite the field name, entries are not player levels. A grade-filtered detail response contains only the requested entry while retaining the parent spell object. | 
**Description** | **string** |  | [optional] 
**IconId** | **int** |  | [optional] 
**AdminName** | **string** |  | [optional] 
**Order** | **int** |  | [optional] 
**ImageUrls** | [**Images**](Images.md) |  | [optional] 
**Type** | [**SpellType**](SpellType.md) |  | [optional] 
**BasePreviewZone** | [**EffectZone**](EffectZone.md) |  | [optional] 
**Classes** | [**List&lt;CombatReference&gt;**](CombatReference.md) | Reverse references to playable classes associated with this spell. These are compact references, not complete class documents. | [optional] 
**Monsters** | [**List&lt;CombatReference&gt;**](CombatReference.md) | Reverse references to monsters associated with this spell. Use a monster&#39;s grade-specific assignments to determine which spell grade it uses. | [optional] 
**Scripts** | [**List&lt;SpellScriptUsage&gt;**](SpellScriptUsage.md) |  | [optional] 
**CriticalScripts** | [**List&lt;SpellScriptUsage&gt;**](SpellScriptUsage.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

