# Dofusdude.Api.Model.MonsterGrade
One variant of this monster, combining combat level, statistics and spell assignments. Match grade-specific drop rates using its grade value. Do not use it to infer a spell grade.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Grade** | **int** | Number identifying this variant within the monster. Not the combat level, array position or grade of an assigned spell. | 
**Level** | **int** | Combat level of this monster variant. Distinct from its grade number. | 
**Spells** | [**List&lt;MonsterGradeSpellsInner&gt;**](MonsterGradeSpellsInner.md) | Spells assigned to this exact monster grade. | 
**LifePoints** | **int** |  | [optional] 
**ActionPoints** | **int** |  | [optional] 
**MovementPoints** | **int** |  | [optional] 
**GradeXp** | **int** |  | [optional] 
**NeutralResistance** | **int** |  | [optional] 
**EarthResistance** | **int** |  | [optional] 
**FireResistance** | **int** |  | [optional] 
**WaterResistance** | **int** |  | [optional] 
**AirResistance** | **int** |  | [optional] 
**PaDodge** | **int** |  | [optional] 
**PmDodge** | **int** |  | [optional] 
**DamageBonus** | **int** |  | [optional] 
**PercentDamageBonus** | **int** |  | [optional] 
**CriticalHitBonus** | **int** |  | [optional] 
**InitiativeBonus** | **int** |  | [optional] 
**TackleBonus** | **int** |  | [optional] 
**TackleEvade** | **int** |  | [optional] 
**MaxSummon** | **int** |  | [optional] 
**BonusCharacteristics** | **Dictionary&lt;string, int&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

