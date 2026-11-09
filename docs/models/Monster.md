# Dofusdude.Api.Model.Monster
A monster with its grades, family, spawn locations and drops. Spell expansion is optional.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnkamaId** | **int** |  | 
**Name** | **string** |  | 
**Race** | [**MonsterRace**](MonsterRace.md) |  | 
**Grades** | [**List&lt;MonsterGrade&gt;**](MonsterGrade.md) | Variants of this monster. Each has its own combat level, statistics and assigned spells. The monster grade number is not a spell grade number or combat level. | 
**SpawnLocations** | [**List&lt;MonsterSpawnLocation&gt;**](MonsterSpawnLocation.md) | Known spawn subareas and their geographic parents. This is not live population data or a per-map spawn probability. Maps listed within a subarea are not guaranteed individual spawn points. | 
**Drops** | [**List&lt;MonsterDrop&gt;**](MonsterDrop.md) |  | 
**ImageUrls** | [**Images**](Images.md) |  | [optional] 
**GlobalDrops** | [**List&lt;MonsterGlobalDrop&gt;**](MonsterGlobalDrop.md) |  | [optional] 
**Appearance** | [**ClassAppearance**](ClassAppearance.md) |  | [optional] 
**IsBounty** | **bool** |  | [optional] 
**CorrespondingMiniBoss** | [**CombatReference**](CombatReference.md) |  | [optional] 
**SummonCost** | **int** |  | [optional] 
**SpeedAdjust** | **int** |  | [optional] 
**ScaleGradeReference** | **int** |  | [optional] 
**Achievements** | [**List&lt;CombatReference&gt;**](CombatReference.md) |  | [optional] 
**Souls** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 
**CharacteristicRatios** | **List&lt;List&lt;double&gt;&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

