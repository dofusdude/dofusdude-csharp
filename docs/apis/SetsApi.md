# Dofusdude.Api.Api.SetsApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllSetsList**](SetsApi.md#getallsetslist) | **GET** /{game}/v1/{language}/sets/all | List All Sets |
| [**GetSetsList**](SetsApi.md#getsetslist) | **GET** /{game}/v1/{language}/sets | List Sets |
| [**GetSetsSearch**](SetsApi.md#getsetssearch) | **GET** /{game}/v1/{language}/sets/search | Search Sets |
| [**GetSetsSingle**](SetsApi.md#getsetssingle) | **GET** /{game}/v1/{language}/sets/{ankama_id} | Single Sets |

<a id="getallsetslist"></a>
# **GetAllSetsList**
> ListEquipmentSets GetAllSetsList (string language, string game, string sortLevel = null, int filterMinHighestEquipmentLevel = null, int filterMaxHighestEquipmentLevel = null, string acceptEncoding = null, bool filterContainsCosmeticsOnly = null, bool filterContainsCosmetics = null)

List All Sets

Retrieve all sets with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinHighestEquipmentLevel** | **int** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **acceptEncoding** | **string** | optional compression for saving bandwidth | [optional]  |
| **filterContainsCosmeticsOnly** | **bool** | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. | [optional]  |
| **filterContainsCosmetics** | **bool** | filter sets based on if they got cosmetic items in it. | [optional]  |

### Return type

[**ListEquipmentSets**](ListEquipmentSets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsetslist"></a>
# **GetSetsList**
> ListEquipmentSets GetSetsList (string language, string game, string sortLevel = null, int filterMinHighestEquipmentLevel = null, int filterMaxHighestEquipmentLevel = null, int pageSize = null, int pageNumber = null, List<string> fieldsSet = null, bool filterContainsCosmeticsOnly = null, bool filterContainsCosmetics = null)

List Sets

Retrieve a list of sets.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinHighestEquipmentLevel** | **int** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **pageSize** | **int** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsSet** | [**List&lt;string&gt;**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |
| **filterContainsCosmeticsOnly** | **bool** | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. | [optional]  |
| **filterContainsCosmetics** | **bool** | filter sets based on if they got cosmetic items in it. | [optional]  |

### Return type

[**ListEquipmentSets**](ListEquipmentSets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsetssearch"></a>
# **GetSetsSearch**
> List&lt;ListEquipmentSet&gt; GetSetsSearch (string language, string game, string query, int filterMinHighestEquipmentLevel = null, int filterMaxHighestEquipmentLevel = null, int limit = null, bool filterContainsCosmeticsOnly = null, bool filterContainsCosmetics = null)

Search Sets

Search in all names and descriptions of sets with a query.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **query** | **string** | case sensitive search query |  |
| **filterMinHighestEquipmentLevel** | **int** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **limit** | **int** | maximum number of returned results | [optional] [default to 8] |
| **filterContainsCosmeticsOnly** | **bool** | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. | [optional]  |
| **filterContainsCosmetics** | **bool** | filter sets based on if they got any cosmetic items in it | [optional]  |

### Return type

[**List&lt;ListEquipmentSet&gt;**](ListEquipmentSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsetssingle"></a>
# **GetSetsSingle**
> EquipmentSet GetSetsSingle (string language, int ankamaId, string game)

Single Sets

Retrieve a specific set with id.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **ankamaId** | **int** | identifier |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

### Return type

[**EquipmentSet**](EquipmentSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

