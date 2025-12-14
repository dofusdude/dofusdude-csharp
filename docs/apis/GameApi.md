# Dofusdude.Api.Api.GameApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGameSearch**](GameApi.md#getgamesearch) | **GET** /{game}/v1/{language}/search | Game Search |
| [**GetItemsAllSearch**](GameApi.md#getitemsallsearch) | **GET** /{game}/v1/{language}/items/search | Search All Items |

<a id="getgamesearch"></a>
# **GetGameSearch**
> List&lt;GameSearch&gt; GetGameSearch (string language, string game, string query, List<string> filterSearchIndex = null, int limit = null, List<string> fieldsItem = null, List<string> filterTypeNameId = null)

Game Search

Search in all names and descriptions of all supported types in the game. For the list of supported types see the endpoint /dofus3/meta/search/types.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **query** | **string** | search query |  |
| **filterSearchIndex** | [**List&lt;string&gt;**](string.md) | only results with all specific type | [optional]  |
| **limit** | **int** | maximum number of returned results | [optional] [default to 8] |
| **fieldsItem** | [**List&lt;string&gt;**](string.md) | adds fields from the item search to the list entries if the hit is an item. Multiple comma separated values allowed. | [optional]  |
| **filterTypeNameId** | [**List&lt;string&gt;**](string.md) | multi-filter results with the english item type name, including \&quot;mount\&quot; and \&quot;set\&quot; from filter[search_index]. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

### Return type

[**List&lt;GameSearch&gt;**](GameSearch.md)

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

<a id="getitemsallsearch"></a>
# **GetItemsAllSearch**
> List&lt;ListItemGeneral&gt; GetItemsAllSearch (string language, string game, string query, int filterMinLevel = null, int filterMaxLevel = null, int limit = null, List<string> filterTypeNameId = null)

Search All Items

Search in all names and descriptions of Dofus items (including all subtypes) with a query.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **query** | **string** | case sensitive search query |  |
| **filterMinLevel** | **int** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int** | only results which level is equal or below this value | [optional]  |
| **limit** | **int** | maximum number of returned results | [optional] [default to 8] |
| **filterTypeNameId** | [**List&lt;string&gt;**](string.md) | multi-filter results with the english type name. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

### Return type

[**List&lt;ListItemGeneral&gt;**](ListItemGeneral.md)

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

