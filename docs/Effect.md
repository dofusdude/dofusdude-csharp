# Dofusdude.Api.Model.Effect

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IntMinimum** | **int** | minimum int value, can be a single if ignore_int_max and no ignore_int_min | [optional] 
**IntMaximum** | **int** | maximum int value, if not ignore_int_max and not ignore_int_min, the effect has a range value | [optional] 
**Type** | [**EffectType**](EffectType.md) |  | [optional] 
**IgnoreIntMin** | **bool** | ignore the int min field because the actual value is a string. For readability the templated field is the only important field in this case.  | [optional] 
**IgnoreIntMax** | **bool** | ignore the int max field, if ignore_int_min is true, int min is a single value | [optional] 
**Formatted** | **string** | all fields from above encoded in a single string | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

