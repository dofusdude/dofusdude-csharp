# Dofusdude.Api.Api.CosmeticsApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllCosmeticsList**](CosmeticsApi.md#getallcosmeticslist) | **GET** /{game}/v1/{language}/items/cosmetics/all | List All Cosmetics |
| [**GetCosmeticsList**](CosmeticsApi.md#getcosmeticslist) | **GET** /{game}/v1/{language}/items/cosmetics | List Cosmetics |
| [**GetCosmeticsSearch**](CosmeticsApi.md#getcosmeticssearch) | **GET** /{game}/v1/{language}/items/cosmetics/search | Search Cosmetics |
| [**GetCosmeticsSingle**](CosmeticsApi.md#getcosmeticssingle) | **GET** /{game}/v1/{language}/items/cosmetics/{ankama_id} | Single Cosmetics |

<a id="getallcosmeticslist"></a>
# **GetAllCosmeticsList**
> ListItems GetAllCosmeticsList (string language, string game, string sortLevel = null, int filterMinLevel = null, int filterMaxLevel = null, string acceptEncoding = null, List<string> filterTypeNameId = null)

List All Cosmetics

Retrieve all cosmetic items with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinLevel** | **int** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int** | only results which level is equal or below this value | [optional]  |
| **acceptEncoding** | **string** | optional compression for saving bandwidth | [optional]  |
| **filterTypeNameId** | [**List&lt;string&gt;**](string.md) | multi-filter results with the english type name. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

### Return type

[**ListItems**](ListItems.md)

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

<a id="getcosmeticslist"></a>
# **GetCosmeticsList**
> ListItems GetCosmeticsList (string language, string game, string sortLevel = null, int filterMinLevel = null, int filterMaxLevel = null, int pageSize = null, int pageNumber = null, List<string> fieldsItem = null, List<string> filterTypeNameId = null)

List Cosmetics

Retrieve a list of cosmetic items.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinLevel** | **int** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int** | only results which level is equal or below this value | [optional]  |
| **pageSize** | **int** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsItem** | [**List&lt;string&gt;**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |
| **filterTypeNameId** | [**List&lt;string&gt;**](string.md) | multi-filter results with the english type name. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

### Return type

[**ListItems**](ListItems.md)

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

<a id="getcosmeticssearch"></a>
# **GetCosmeticsSearch**
> List&lt;ListItem&gt; GetCosmeticsSearch (string language, string game, string query, int filterMinLevel = null, int filterMaxLevel = null, int limit = null, List<string> filterTypeNameId = null)

Search Cosmetics

Search in all names and descriptions of cosmetic items with a query.


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

[**List&lt;ListItem&gt;**](ListItem.md)

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

<a id="getcosmeticssingle"></a>
# **GetCosmeticsSingle**
> Equipment GetCosmeticsSingle (string language, int ankamaId, string game)

Single Cosmetics

Retrieve a specific cosmetic item with id.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **ankamaId** | **int** | identifier |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

### Return type

[**Equipment**](Equipment.md)

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

