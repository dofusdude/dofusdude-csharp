# Dofusdude.Api.Model.WorldArea
Geographic data from a super-area, area or subarea endpoint. The hierarchy is super-area to area to subarea to map. Field availability depends on the selected geographic resource. Unrelated to combat-cell effect zones.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | 
**Name** | **string** |  | 
**WorldMapId** | **int** | World-map context supplied on super-area records. | [optional] 
**Areas** | [**List&lt;CombatReference&gt;**](CombatReference.md) | Child area references supplied on super-area records. | [optional] 
**Level** | **int** | Suggested geographic difficulty level supplied on subarea records. Not a monster grade or the level of every monster there. | [optional] 
**DungeonId** | **int** | Dungeon association when supplied by the subarea data. | [optional] 
**Maps** | [**List&lt;WorldMapReference&gt;**](WorldMapReference.md) | Map membership supplied on subarea records. Does not imply a spawn on every map. | [optional] 
**SuperArea** | [**CombatReference**](CombatReference.md) |  | [optional] 
**Area** | [**CombatReference**](CombatReference.md) |  | [optional] 
**Subareas** | [**List&lt;CombatReference&gt;**](CombatReference.md) |  | [optional] 
**Monsters** | [**List&lt;CombatReference&gt;**](CombatReference.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

