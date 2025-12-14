# Dofusdude.Api.Api.MetaApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGameSearchTypes**](MetaApi.md#getgamesearchtypes) | **GET** /{game}/v1/meta/search/types | Available Game Search Types |
| [**GetItemTypes**](MetaApi.md#getitemtypes) | **GET** /{game}/v1/meta/items/types | Available Item Types |
| [**GetMetaAlmanaxBonuses**](MetaApi.md#getmetaalmanaxbonuses) | **GET** /dofus3/v1/meta/{language}/almanax/bonuses | Available Almanax Bonuses |
| [**GetMetaAlmanaxBonusesSearch**](MetaApi.md#getmetaalmanaxbonusessearch) | **GET** /dofus3/v1/meta/{language}/almanax/bonuses/search | Search Available Almanax Bonuses |
| [**GetMetaElements**](MetaApi.md#getmetaelements) | **GET** /{game}/v1/meta/elements | Effects and Condition Elements |
| [**GetMetaVersion**](MetaApi.md#getmetaversion) | **GET** /{game}/v1/meta/version | Game Version |

<a id="getgamesearchtypes"></a>
# **GetGameSearchTypes**
> List&lt;string&gt; GetGameSearchTypes (string game)

Available Game Search Types

Get all types for /{game}/v1/{lang}/search available for filtering. All names are english for comparing them inside applications. Order is fixed so you can compare indices instead of strings.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getitemtypes"></a>
# **GetItemTypes**
> List&lt;string&gt; GetItemTypes (string game)

Available Item Types

Get all types of all items. Primarily used for filtering more detailed types in listings or search endpoints. All names are english for comparing them inside applications. Ordering is not guaranteed to persist with game updates.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmetaalmanaxbonuses"></a>
# **GetMetaAlmanaxBonuses**
> List&lt;GetMetaAlmanaxBonuses200ResponseInner&gt; GetMetaAlmanaxBonuses (string language)

Available Almanax Bonuses

Get all the available bonuses and their id for filtering them in the range endpoint.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |

### Return type

[**List&lt;GetMetaAlmanaxBonuses200ResponseInner&gt;**](GetMetaAlmanaxBonuses200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmetaalmanaxbonusessearch"></a>
# **GetMetaAlmanaxBonusesSearch**
> List&lt;GetMetaAlmanaxBonuses200ResponseInner&gt; GetMetaAlmanaxBonusesSearch (string language, string query, int limit = null)

Search Available Almanax Bonuses

Search all the available bonuses and their id for filtering them in the range endpoint.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **query** | **string** | case sensitive search query |  |
| **limit** | **int** | maximum number of returned results | [optional]  |

### Return type

[**List&lt;GetMetaAlmanaxBonuses200ResponseInner&gt;**](GetMetaAlmanaxBonuses200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmetaelements"></a>
# **GetMetaElements**
> List&lt;string&gt; GetMetaElements (string game)

Effects and Condition Elements

Get the mappings for all specific elements that are linked in the dataset. All names are english. Translations are not needed because of a global unique id which is the index inside the array. Future elements will get a higher id.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmetaversion"></a>
# **GetMetaVersion**
> ModelVersion GetMetaVersion (string game)

Game Version

The current game version of the hosted data.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

### Return type

[**ModelVersion**](ModelVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

