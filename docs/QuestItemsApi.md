# Dofusdude.Api.Api.QuestItemsApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllItemsQuestList**](QuestItemsApi.md#getallitemsquestlist) | **GET** /{game}/v1/{language}/items/quest/all | List All Quest Items |
| [**GetItemQuestSingle**](QuestItemsApi.md#getitemquestsingle) | **GET** /{game}/v1/{language}/items/quest/{ankama_id} | Single Quest Items |
| [**GetItemsQuestList**](QuestItemsApi.md#getitemsquestlist) | **GET** /{game}/v1/{language}/items/quest | List Quest Items |
| [**GetItemsQuestSearch**](QuestItemsApi.md#getitemsquestsearch) | **GET** /{game}/v1/{language}/items/quest/search | Search Quest Items |

<a id="getallitemsquestlist"></a>
# **GetAllItemsQuestList**
> ListItems GetAllItemsQuestList (string language, string game, string? sortLevel = null, int? filterMinLevel = null, int? filterMaxLevel = null, string? acceptEncoding = null, List<string>? filterTypeNameId = null)

List All Quest Items

Retrieve all quest items with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAllItemsQuestListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new QuestItemsApi(config);
            var language = fr;  // string | a valid language code
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = desc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 1;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 50;  // int? | only results which level is equal or below this value (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List All Quest Items
                ListItems result = apiInstance.GetAllItemsQuestList(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestItemsApi.GetAllItemsQuestList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllItemsQuestListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List All Quest Items
    ApiResponse<ListItems> response = apiInstance.GetAllItemsQuestListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuestItemsApi.GetAllItemsQuestListWithHttpInfo: " + e.Message);
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

<a id="getitemquestsingle"></a>
# **GetItemQuestSingle**
> Resource GetItemQuestSingle (string language, int ankamaId, string game)

Single Quest Items

Retrieve a specific quest item with id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemQuestSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new QuestItemsApi(config);
            var language = "en";  // string | a valid language code
            var ankamaId = 25256;  // int | identifier
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'

            try
            {
                // Single Quest Items
                Resource result = apiInstance.GetItemQuestSingle(language, ankamaId, game);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestItemsApi.GetItemQuestSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemQuestSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single Quest Items
    ApiResponse<Resource> response = apiInstance.GetItemQuestSingleWithHttpInfo(language, ankamaId, game);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuestItemsApi.GetItemQuestSingleWithHttpInfo: " + e.Message);
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

[**Resource**](Resource.md)

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

<a id="getitemsquestlist"></a>
# **GetItemsQuestList**
> ListItems GetItemsQuestList (string language, string game, string? sortLevel = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsItem = null, List<string>? filterTypeNameId = null)

List Quest Items

Retrieve a list of quest items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsQuestListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new QuestItemsApi(config);
            var language = fr;  // string | a valid language code
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = desc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 1;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 50;  // int? | only results which level is equal or below this value (optional) 
            var pageSize = 5;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsItem = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List Quest Items
                ListItems result = apiInstance.GetItemsQuestList(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestItemsApi.GetItemsQuestList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsQuestListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Quest Items
    ApiResponse<ListItems> response = apiInstance.GetItemsQuestListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuestItemsApi.GetItemsQuestListWithHttpInfo: " + e.Message);
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

<a id="getitemsquestsearch"></a>
# **GetItemsQuestSearch**
> List&lt;ListItem&gt; GetItemsQuestSearch (string language, string game, string query, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? limit = null, List<string>? filterTypeEnum = null)

Search Quest Items

Search in all names and descriptions of quest items with a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsQuestSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new QuestItemsApi(config);
            var language = es;  // string | a valid language code
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var query = Ficha;  // string | case sensitive search query
            var filterTypeName = Justicieros;  // string? | only results with the translated type name (optional) 
            var filterMinLevel = 60;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 70;  // int? | only results which level is equal or below this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)
            var filterTypeEnum = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // Search Quest Items
                List<ListItem> result = apiInstance.GetItemsQuestSearch(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit, filterTypeEnum);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuestItemsApi.GetItemsQuestSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsQuestSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Quest Items
    ApiResponse<List<ListItem>> response = apiInstance.GetItemsQuestSearchWithHttpInfo(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit, filterTypeEnum);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuestItemsApi.GetItemsQuestSearchWithHttpInfo: " + e.Message);
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
| **filterTypeName** | **string?** | only results with the translated type name | [optional]  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |
| **filterTypeEnum** | [**List&lt;string&gt;?**](string.md) | multi-filter results with the english type name. Add with \&quot;wood\&quot; or \&quot;+wood\&quot; and exclude with \&quot;-wood\&quot;. | [optional]  |

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
| **200** | Quest Items Found |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

