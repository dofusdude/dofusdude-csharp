# Dofusdude.Api.Api.GameDataApi

All URIs are relative to *https://beta.api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllAreas**](GameDataApi.md#getallareas) | **GET** /{game}/v1/{language}/areas/all | Get all areas |
| [**GetAllClasses**](GameDataApi.md#getallclasses) | **GET** /{game}/v1/{language}/classes/all | Get all classes |
| [**GetAllMonsters**](GameDataApi.md#getallmonsters) | **GET** /{game}/v1/{language}/monsters/all | Get all monsters |
| [**GetAllSpells**](GameDataApi.md#getallspells) | **GET** /{game}/v1/{language}/spells/all | Get all spells |
| [**GetAllSubareas**](GameDataApi.md#getallsubareas) | **GET** /{game}/v1/{language}/subareas/all | Get all subareas |
| [**GetAllSuperAreas**](GameDataApi.md#getallsuperareas) | **GET** /{game}/v1/{language}/super-areas/all | Get all super-areas |
| [**GetAreaById**](GameDataApi.md#getareabyid) | **GET** /{game}/v1/{language}/areas/{ankama_id} | Get one area |
| [**GetAreas**](GameDataApi.md#getareas) | **GET** /{game}/v1/{language}/areas | List areas |
| [**GetClassById**](GameDataApi.md#getclassbyid) | **GET** /{game}/v1/{language}/classes/{ankama_id} | Get one class |
| [**GetClasses**](GameDataApi.md#getclasses) | **GET** /{game}/v1/{language}/classes | List classes |
| [**GetMonsterById**](GameDataApi.md#getmonsterbyid) | **GET** /{game}/v1/{language}/monsters/{ankama_id} | Get one monster |
| [**GetMonsters**](GameDataApi.md#getmonsters) | **GET** /{game}/v1/{language}/monsters | List monsters |
| [**GetSpellById**](GameDataApi.md#getspellbyid) | **GET** /{game}/v1/{language}/spells/{ankama_id} | Get one spell |
| [**GetSpells**](GameDataApi.md#getspells) | **GET** /{game}/v1/{language}/spells | List spells |
| [**GetSubareaById**](GameDataApi.md#getsubareabyid) | **GET** /{game}/v1/{language}/subareas/{ankama_id} | Get one subarea |
| [**GetSubareas**](GameDataApi.md#getsubareas) | **GET** /{game}/v1/{language}/subareas | List subareas |
| [**GetSuperAreaById**](GameDataApi.md#getsuperareabyid) | **GET** /{game}/v1/{language}/super-areas/{ankama_id} | Get one super-area |
| [**GetSuperAreas**](GameDataApi.md#getsuperareas) | **GET** /{game}/v1/{language}/super-areas | List super-areas |
| [**SearchAreas**](GameDataApi.md#searchareas) | **GET** /{game}/v1/{language}/areas/search | Search areas |
| [**SearchClasses**](GameDataApi.md#searchclasses) | **GET** /{game}/v1/{language}/classes/search | Search classes |
| [**SearchMonsters**](GameDataApi.md#searchmonsters) | **GET** /{game}/v1/{language}/monsters/search | Search monsters |
| [**SearchSpells**](GameDataApi.md#searchspells) | **GET** /{game}/v1/{language}/spells/search | Search spells |
| [**SearchSubareas**](GameDataApi.md#searchsubareas) | **GET** /{game}/v1/{language}/subareas/search | Search subareas |
| [**SearchSuperAreas**](GameDataApi.md#searchsuperareas) | **GET** /{game}/v1/{language}/super-areas/search | Search super-areas |

<a id="getallareas"></a>
# **GetAllAreas**
> MappedEntityCollection GetAllAreas (string game, string language)

Get all areas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized area document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallclasses"></a>
# **GetAllClasses**
> MappedEntityCollection GetAllClasses (string game, string language)

Get all classes


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized class document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallmonsters"></a>
# **GetAllMonsters**
> MappedEntityCollection GetAllMonsters (string game, string language, string include = null)

Get all monsters


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **include** | **string** | Optional spell expansion for monster responses. Leave include unset to return spell URLs. Use &#x60;spells.grade&#x60; to embed the assigned spell grade. Use &#x60;spells&#x60; to embed every available grade of each assigned spell. | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized monster document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallspells"></a>
# **GetAllSpells**
> MappedEntityCollection GetAllSpells (string game, string language)

Get all spells


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized spell document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallsubareas"></a>
# **GetAllSubareas**
> MappedEntityCollection GetAllSubareas (string game, string language)

Get all subareas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized subarea document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallsuperareas"></a>
# **GetAllSuperAreas**
> MappedEntityCollection GetAllSuperAreas (string game, string language)

Get all super-areas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized super-area document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getareabyid"></a>
# **GetAreaById**
> WorldArea GetAreaById (string game, string language, int ankamaId)

Get one area


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**WorldArea**](WorldArea.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized area document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getareas"></a>
# **GetAreas**
> MappedEntityCollection GetAreas (string game, string language, int pageNumber = null, int pageSize = null, string fieldsAreas = null)

List areas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsAreas** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated areas. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclassbyid"></a>
# **GetClassById**
> Class GetClassById (string game, string language, int ankamaId)

Get one class


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**Class**](Class.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized class document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclasses"></a>
# **GetClasses**
> MappedEntityCollection GetClasses (string game, string language, int pageNumber = null, int pageSize = null, string fieldsClasses = null)

List classes


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsClasses** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated classes. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmonsterbyid"></a>
# **GetMonsterById**
> Monster GetMonsterById (string game, string language, int ankamaId, string include = null)

Get one monster


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |
| **include** | **string** | Optional spell expansion for monster responses. Leave include unset to return spell URLs. Use &#x60;spells.grade&#x60; to embed the assigned spell grade. Use &#x60;spells&#x60; to embed every available grade of each assigned spell. | [optional]  |

### Return type

[**Monster**](Monster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized monster document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmonsters"></a>
# **GetMonsters**
> MappedEntityCollection GetMonsters (string game, string language, int pageNumber = null, int pageSize = null, string fieldsMonsters = null, string include = null)

List monsters


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsMonsters** | **string** |  | [optional]  |
| **include** | **string** | Optional spell expansion for monster responses. Leave include unset to return spell URLs. Use &#x60;spells.grade&#x60; to embed the assigned spell grade. Use &#x60;spells&#x60; to embed every available grade of each assigned spell. | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated monsters. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getspellbyid"></a>
# **GetSpellById**
> Spell GetSpellById (string game, string language, int ankamaId, int grade = null)

Get one spell


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |
| **grade** | **int** | Return only the requested mapped spell grade in &#x60;levels&#x60;. | [optional]  |

### Return type

[**Spell**](Spell.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized spell document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getspells"></a>
# **GetSpells**
> MappedEntityCollection GetSpells (string game, string language, int pageNumber = null, int pageSize = null, string fieldsSpells = null)

List spells


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsSpells** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated spells. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubareabyid"></a>
# **GetSubareaById**
> WorldArea GetSubareaById (string game, string language, int ankamaId)

Get one subarea


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**WorldArea**](WorldArea.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized subarea document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubareas"></a>
# **GetSubareas**
> MappedEntityCollection GetSubareas (string game, string language, int pageNumber = null, int pageSize = null, string fieldsSubareas = null)

List subareas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsSubareas** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated subareas. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsuperareabyid"></a>
# **GetSuperAreaById**
> WorldArea GetSuperAreaById (string game, string language, int ankamaId)

Get one super-area


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**WorldArea**](WorldArea.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized super-area document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsuperareas"></a>
# **GetSuperAreas**
> MappedEntityCollection GetSuperAreas (string game, string language, int pageNumber = null, int pageSize = null, string fieldsSuperAreas = null)

List super-areas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsSuperAreas** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated super-areas. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchareas"></a>
# **SearchAreas**
> List&lt;MappedEntityListEntry&gt; SearchAreas (string game, string language, string query, int limit = null)

Search areas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchclasses"></a>
# **SearchClasses**
> List&lt;MappedEntityListEntry&gt; SearchClasses (string game, string language, string query, int limit = null)

Search classes


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchmonsters"></a>
# **SearchMonsters**
> List&lt;MappedEntityListEntry&gt; SearchMonsters (string game, string language, string query, int limit = null)

Search monsters


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchspells"></a>
# **SearchSpells**
> List&lt;MappedEntityListEntry&gt; SearchSpells (string game, string language, string query, int limit = null)

Search spells


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchsubareas"></a>
# **SearchSubareas**
> List&lt;MappedEntityListEntry&gt; SearchSubareas (string game, string language, string query, int limit = null)

Search subareas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchsuperareas"></a>
# **SearchSuperAreas**
> List&lt;MappedEntityListEntry&gt; SearchSuperAreas (string game, string language, string query, int limit = null)

Search super-areas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

