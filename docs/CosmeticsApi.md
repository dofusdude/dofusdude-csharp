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
> ListItems GetAllCosmeticsList (string language, string game, string? sortLevel = null, int? filterMinLevel = null, int? filterMaxLevel = null, string? acceptEncoding = null, List<string>? filterTypeNameId = null)

List All Cosmetics

Retrieve all cosmetic items with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAllCosmeticsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new CosmeticsApi(config);
            var language = fr;  // string | a valid language code
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 1;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 5;  // int? | only results which level is equal or below this value (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List All Cosmetics
                ListItems result = apiInstance.GetAllCosmeticsList(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmeticsApi.GetAllCosmeticsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllCosmeticsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List All Cosmetics
    ApiResponse<ListItems> response = apiInstance.GetAllCosmeticsListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmeticsApi.GetAllCosmeticsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string?** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **acceptEncoding** | **string?** | optional compression for saving bandwidth | [optional]  |
| **filterTypeNameId** | [**List&lt;string&gt;?**](string.md) | multi-filter results with the english type name. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcosmeticslist"></a>
# **GetCosmeticsList**
> ListItems GetCosmeticsList (string language, string game, string? sortLevel = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsItem = null, List<string>? filterTypeNameId = null)

List Cosmetics

Retrieve a list of cosmetic items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetCosmeticsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new CosmeticsApi(config);
            var language = fr;  // string | a valid language code
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 1;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 5;  // int? | only results which level is equal or below this value (optional) 
            var pageSize = 5;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsItem = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List Cosmetics
                ListItems result = apiInstance.GetCosmeticsList(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmeticsApi.GetCosmeticsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCosmeticsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Cosmetics
    ApiResponse<ListItems> response = apiInstance.GetCosmeticsListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmeticsApi.GetCosmeticsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string?** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **pageSize** | **int?** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int?** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsItem** | [**List&lt;string&gt;?**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |
| **filterTypeNameId** | [**List&lt;string&gt;?**](string.md) | multi-filter results with the english type name. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcosmeticssearch"></a>
# **GetCosmeticsSearch**
> List&lt;ListItem&gt; GetCosmeticsSearch (string language, string game, string query, int? filterMinLevel = null, int? filterMaxLevel = null, int? limit = null, List<string>? filterTypeNameId = null)

Search Cosmetics

Search in all names and descriptions of cosmetic items with a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetCosmeticsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new CosmeticsApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var query = nedora;  // string | case sensitive search query
            var filterMinLevel = 1;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 2;  // int? | only results which level is equal or below this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // Search Cosmetics
                List<ListItem> result = apiInstance.GetCosmeticsSearch(language, game, query, filterMinLevel, filterMaxLevel, limit, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmeticsApi.GetCosmeticsSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCosmeticsSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Cosmetics
    ApiResponse<List<ListItem>> response = apiInstance.GetCosmeticsSearchWithHttpInfo(language, game, query, filterMinLevel, filterMaxLevel, limit, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmeticsApi.GetCosmeticsSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **query** | **string** | case sensitive search query |  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |
| **filterTypeNameId** | [**List&lt;string&gt;?**](string.md) | multi-filter results with the english type name. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcosmeticssingle"></a>
# **GetCosmeticsSingle**
> Equipment GetCosmeticsSingle (string language, int ankamaId, string game)

Single Cosmetics

Retrieve a specific cosmetic item with id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetCosmeticsSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new CosmeticsApi(config);
            var language = "en";  // string | a valid language code
            var ankamaId = 24132;  // int | identifier
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'

            try
            {
                // Single Cosmetics
                Equipment result = apiInstance.GetCosmeticsSingle(language, ankamaId, game);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmeticsApi.GetCosmeticsSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCosmeticsSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single Cosmetics
    ApiResponse<Equipment> response = apiInstance.GetCosmeticsSingleWithHttpInfo(language, ankamaId, game);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmeticsApi.GetCosmeticsSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

