# Dofusdude.Api.Api.GameApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGameSearch**](GameApi.md#getgamesearch) | **GET** /{game}/{language}/search | Game Search |
| [**GetItemsAllSearch**](GameApi.md#getitemsallsearch) | **GET** /{game}/{language}/items/search | Search All Items |

<a id="getgamesearch"></a>
# **GetGameSearch**
> List&lt;GetGameSearch200ResponseInner&gt; GetGameSearch (string language, string game, string query, List<string>? filterType = null, int? limit = null, List<string>? fieldsItem = null)

Game Search

Search in all names and descriptions of all supported types in the game. For the list of supported types see the endpoint /dofus2/meta/search/types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetGameSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new GameApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus2;  // string | 
            var query = paztek;  // string | search query
            var filterType = new List<string>?(); // List<string>? | only results with all specific type (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)
            var fieldsItem = new List<string>?(); // List<string>? | adds fields from the item search to the list entries if the hit is a item. Multiple comma separated values allowed. (optional) 

            try
            {
                // Game Search
                List<GetGameSearch200ResponseInner> result = apiInstance.GetGameSearch(language, game, query, filterType, limit, fieldsItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetGameSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGameSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Game Search
    ApiResponse<List<GetGameSearch200ResponseInner>> response = apiInstance.GetGameSearchWithHttpInfo(language, game, query, filterType, limit, fieldsItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameApi.GetGameSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** |  |  |
| **query** | **string** | search query |  |
| **filterType** | [**List&lt;string&gt;?**](string.md) | only results with all specific type | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |
| **fieldsItem** | [**List&lt;string&gt;?**](string.md) | adds fields from the item search to the list entries if the hit is a item. Multiple comma separated values allowed. | [optional]  |

### Return type

[**List&lt;GetGameSearch200ResponseInner&gt;**](GetGameSearch200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Game Search Result |  -  |
| **400** | Bad Request  Possibilities: - empty or no query - filter[type] does not exist  |  -  |
| **404** | Not Found  Possibilities: - no hits for query |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitemsallsearch"></a>
# **GetItemsAllSearch**
> List&lt;ItemsListEntryTyped&gt; GetItemsAllSearch (string language, string game, string query, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? limit = null)

Search All Items

Search in all names and descriptions of Dofus items (including all subtypes) with a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsAllSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new GameApi(config);
            var language = fr;  // string | a valid language code
            var game = dofus2;  // string | 
            var query = atcham;  // string | case sensitive search query
            var filterTypeName = Bottes;  // string? | only results with the translated type name across all item_subtypes (optional) 
            var filterMinLevel = 190;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 200;  // int? | only results which level is equal or below this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)

            try
            {
                // Search All Items
                List<ItemsListEntryTyped> result = apiInstance.GetItemsAllSearch(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetItemsAllSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsAllSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search All Items
    ApiResponse<List<ItemsListEntryTyped>> response = apiInstance.GetItemsAllSearchWithHttpInfo(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameApi.GetItemsAllSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** |  |  |
| **query** | **string** | case sensitive search query |  |
| **filterTypeName** | **string?** | only results with the translated type name across all item_subtypes | [optional]  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |

### Return type

[**List&lt;ItemsListEntryTyped&gt;**](ItemsListEntryTyped.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Items Found |  -  |
| **400** | Bad Request  Possibilities: - empty or no query  |  -  |
| **404** | Not Found  Possibilities: - no hits for query |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

