# Dofusdude.Api.Api.ConsumablesApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllItemsConsumablesList**](ConsumablesApi.md#getallitemsconsumableslist) | **GET** /{game}/v1/{language}/items/consumables/all | List All Consumables |
| [**GetItemsConsumablesList**](ConsumablesApi.md#getitemsconsumableslist) | **GET** /{game}/v1/{language}/items/consumables | List Consumables |
| [**GetItemsConsumablesSearch**](ConsumablesApi.md#getitemsconsumablessearch) | **GET** /{game}/v1/{language}/items/consumables/search | Search Consumables |
| [**GetItemsConsumablesSingle**](ConsumablesApi.md#getitemsconsumablessingle) | **GET** /{game}/v1/{language}/items/consumables/{ankama_id} | Single Consumables |

<a id="getallitemsconsumableslist"></a>
# **GetAllItemsConsumablesList**
> ListItems GetAllItemsConsumablesList (string language, string game, string sortLevel = null, int filterMinLevel = null, int filterMaxLevel = null, string acceptEncoding = null, List<string> filterTypeNameId = null)

List All Consumables

Retrieve all consumable items with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAllItemsConsumablesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new ConsumablesApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus3;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = asc;  // string | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 150;  // int | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 180;  // int | only results which level is equal or below this value (optional) 
            var acceptEncoding = "gzip";  // string | optional compression for saving bandwidth (optional) 
            var filterTypeNameId = new List<string>(); // List<string> | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List All Consumables
                ListItems result = apiInstance.GetAllItemsConsumablesList(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsumablesApi.GetAllItemsConsumablesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllItemsConsumablesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List All Consumables
    ApiResponse<ListItems> response = apiInstance.GetAllItemsConsumablesListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsumablesApi.GetAllItemsConsumablesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

<a id="getitemsconsumableslist"></a>
# **GetItemsConsumablesList**
> ListItems GetItemsConsumablesList (string language, string game, string sortLevel = null, int filterMinLevel = null, int filterMaxLevel = null, int pageSize = null, int pageNumber = null, List<string> fieldsItem = null, List<string> filterTypeNameId = null)

List Consumables

Retrieve a list of consumable items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsConsumablesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new ConsumablesApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus3;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = asc;  // string | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 150;  // int | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 180;  // int | only results which level is equal or below this value (optional) 
            var pageSize = 2;  // int | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsItem = new List<string>(); // List<string> | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 
            var filterTypeNameId = new List<string>(); // List<string> | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List Consumables
                ListItems result = apiInstance.GetItemsConsumablesList(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsumablesApi.GetItemsConsumablesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsConsumablesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Consumables
    ApiResponse<ListItems> response = apiInstance.GetItemsConsumablesListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsumablesApi.GetItemsConsumablesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

<a id="getitemsconsumablessearch"></a>
# **GetItemsConsumablesSearch**
> List&lt;ListItem&gt; GetItemsConsumablesSearch (string language, string game, string query, int filterMinLevel = null, int filterMaxLevel = null, int limit = null, List<string> filterTypeNameId = null)

Search Consumables

Search in all names and descriptions of consumable items with a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsConsumablesSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new ConsumablesApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus3;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var query = Wholewrite;  // string | case sensitive search query
            var filterMinLevel = 1;  // int | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 200;  // int | only results which level is equal or below this value (optional) 
            var limit = 8;  // int | maximum number of returned results (optional)  (default to 8)
            var filterTypeNameId = new List<string>(); // List<string> | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // Search Consumables
                List<ListItem> result = apiInstance.GetItemsConsumablesSearch(language, game, query, filterMinLevel, filterMaxLevel, limit, filterTypeNameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsumablesApi.GetItemsConsumablesSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsConsumablesSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Consumables
    ApiResponse<List<ListItem>> response = apiInstance.GetItemsConsumablesSearchWithHttpInfo(language, game, query, filterMinLevel, filterMaxLevel, limit, filterTypeNameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsumablesApi.GetItemsConsumablesSearchWithHttpInfo: " + e.Message);
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
| **200** | Consumables Found |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getitemsconsumablessingle"></a>
# **GetItemsConsumablesSingle**
> Resource GetItemsConsumablesSingle (string language, int ankamaId, string game)

Single Consumables

Retrieve a specific consumable item with id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsConsumablesSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new ConsumablesApi(config);
            var language = "en";  // string | a valid language code
            var ankamaId = 17206;  // int | identifier
            var game = dofus3;  // string | game main 'dofus3' or beta channel 'dofus3beta'

            try
            {
                // Single Consumables
                Resource result = apiInstance.GetItemsConsumablesSingle(language, ankamaId, game);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsumablesApi.GetItemsConsumablesSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsConsumablesSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single Consumables
    ApiResponse<Resource> response = apiInstance.GetItemsConsumablesSingleWithHttpInfo(language, ankamaId, game);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsumablesApi.GetItemsConsumablesSingleWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

