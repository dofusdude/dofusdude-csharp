# Dofusdude.Api.Model.EligibilityNode
Client-side conditions using the v1 condition-node structure. Confirmed server-owned predicates are excluded during mapping. This is not the complete server eligibility formula, and the API does not dynamically remove fields based on interpretation status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsOperand** | **bool** |  | [optional] 
**Relation** | **string** |  | [optional] 
**Children** | [**List&lt;EligibilityNode&gt;**](EligibilityNode.md) |  | [optional] 
**Condition** | [**EligibilityNodeCondition**](EligibilityNodeCondition.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

