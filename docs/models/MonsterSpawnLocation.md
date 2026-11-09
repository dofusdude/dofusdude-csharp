# Dofusdude.Api.Model.MonsterSpawnLocation
Known spawn subarea with its parent area, super-area and map membership. Does not assert a spawn on each listed map and does not include spawn probabilities.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subarea** | [**CombatReference**](CombatReference.md) |  | 
**Area** | [**CombatReference**](CombatReference.md) |  | 
**SuperArea** | [**CombatReference**](CombatReference.md) |  | 
**SubareaMaps** | [**List&lt;MonsterSpawnLocationSubareaMapsInner&gt;**](MonsterSpawnLocationSubareaMapsInner.md) | Maps belonging to the referenced subarea. Map membership alone is not proof that the monster spawns on a particular map. | 
**Preferred** | **bool** | Whether the source marks this as a preferred subarea. A preference flag, not a spawn percentage or guarantee of presence. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

