# Dofusdude.Api.Model.Images
All images except icon are rendered in the background which can take some time (up to hours if all data is completely generated from scratch). Because of this, they can be null if they are not yet rendered.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Icon** | **string** | 64x64 px, always available | [optional] 
**Sd** | **string** | around 2x the resolution of icon | [optional] 
**Hq** | **string** | around 2x the resolution of sd | [optional] 
**Hd** | **string** | around 2x the resolution of hd | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

