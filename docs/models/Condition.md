# Dofusdude.Api.Model.Condition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operator** | **string** | Comparison to apply to the interpreted requirement value. | [optional] 
**IntValue** | **int** |  | [optional] 
**Element** | [**TranslatedId**](TranslatedId.md) |  | [optional] 
**Kind** | **string** | Interpreted requirement category, such as profession_level or item_received_age. Use this with the operator, values and references rather than decoding original condition tokens. | [optional] 
**Unit** | **string** | Unit associated with the requirement value when the interpreted condition supplies one. | [optional] 
**Quantity** | **int** |  | [optional] 
**StringValue** | **string** |  | [optional] 
**ValueLabel** | **string** |  | [optional] 
**Reference** | [**CombatReference**](CombatReference.md) |  | [optional] 
**SecondaryReference** | [**CombatReference**](CombatReference.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

