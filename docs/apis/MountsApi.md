# Dofusdude.Api.Api.MountsApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllMountsList**](MountsApi.md#getallmountslist) | **GET** /{game}/v1/{language}/mounts/all | List All Mounts |
| [**GetMountsList**](MountsApi.md#getmountslist) | **GET** /{game}/v1/{language}/mounts | List Mounts |
| [**GetMountsSearch**](MountsApi.md#getmountssearch) | **GET** /{game}/v1/{language}/mounts/search | Search Mounts |
| [**GetMountsSingle**](MountsApi.md#getmountssingle) | **GET** /{game}/v1/{language}/mounts/{ankama_id} | Single Mounts |

<a id="getallmountslist"></a>
# **GetAllMountsList**
> ListMounts GetAllMountsList (string language, string game, string filterFamilyName = null, string acceptEncoding = null, int filterFamilyId = null)

List All Mounts

Retrieve all mounts with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **filterFamilyName** | **string** | only results with the translated family name | [optional]  |
| **acceptEncoding** | **string** | optional compression for saving bandwidth | [optional]  |
| **filterFamilyId** | **int** | only results with the unique family id | [optional]  |

### Return type

[**ListMounts**](ListMounts.md)

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

<a id="getmountslist"></a>
# **GetMountsList**
> ListMounts GetMountsList (string language, string game, string filterFamilyName = null, int pageSize = null, int pageNumber = null, List<string> fieldsMount = null, int filterFamilyId = null)

List Mounts

Retrieve a list of mounts.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **filterFamilyName** | **string** | only results with the translated family name | [optional]  |
| **pageSize** | **int** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsMount** | [**List&lt;string&gt;**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |
| **filterFamilyId** | **int** | only results with the unique family id | [optional]  |

### Return type

[**ListMounts**](ListMounts.md)

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

<a id="getmountssearch"></a>
# **GetMountsSearch**
> List&lt;Mount&gt; GetMountsSearch (string language, string game, string query, string filterFamilyName = null, int limit = null, int filterFamilyId = null)

Search Mounts

Search in all names and descriptions of mounts with a query.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **query** | **string** | case sensitive search query |  |
| **filterFamilyName** | **string** | only results with the translated family name | [optional]  |
| **limit** | **int** | maximum number of returned results | [optional] [default to 8] |
| **filterFamilyId** | **int** | only results with the unique family id | [optional]  |

### Return type

[**List&lt;Mount&gt;**](Mount.md)

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

<a id="getmountssingle"></a>
# **GetMountsSingle**
> Mount GetMountsSingle (string language, int ankamaId, string game)

Single Mounts

Retrieve a specific mount with id.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **ankamaId** | **int** | identifier |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

### Return type

[**Mount**](Mount.md)

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

