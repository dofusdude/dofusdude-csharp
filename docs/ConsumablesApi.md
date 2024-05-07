# Dofusdude.Api.Api.ConsumablesApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllItemsConsumablesList**](ConsumablesApi.md#getallitemsconsumableslist) | **GET** /{game}/{language}/items/consumables/all | List All Consumables |
| [**GetItemsConsumablesList**](ConsumablesApi.md#getitemsconsumableslist) | **GET** /{game}/{language}/items/consumables | List Consumables |
| [**GetItemsConsumablesSearch**](ConsumablesApi.md#getitemsconsumablessearch) | **GET** /{game}/{language}/items/consumables/search | Search Consumables |
| [**GetItemsConsumablesSingle**](ConsumablesApi.md#getitemsconsumablessingle) | **GET** /{game}/{language}/items/consumables/{ankama_id} | Single Consumables |

<a id="getallitemsconsumableslist"></a>
# **GetAllItemsConsumablesList**
> ItemsListPaged GetAllItemsConsumablesList (string language, string game, string? sortLevel = null, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, string? acceptEncoding = null)

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
            var game = dofus2;  // string | 
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterTypeName = Chest;  // string? | only results with the translated type name (optional) 
            var filterMinLevel = 150;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 180;  // int? | only results which level is equal or below this value (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 

            try
            {
                // List All Consumables
                ItemsListPaged result = apiInstance.GetAllItemsConsumablesList(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, acceptEncoding);
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
    ApiResponse<ItemsListPaged> response = apiInstance.GetAllItemsConsumablesListWithHttpInfo(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, acceptEncoding);
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
| **game** | **string** |  |  |
| **sortLevel** | **string?** | sort the resulting list by level, default unsorted | [optional]  |
| **filterTypeName** | **string?** | only results with the translated type name | [optional]  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **acceptEncoding** | **string?** | optional compression for saving bandwidth | [optional]  |

### Return type

[**ItemsListPaged**](ItemsListPaged.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumables Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitemsconsumableslist"></a>
# **GetItemsConsumablesList**
> ItemsListPaged GetItemsConsumablesList (string language, string game, string? sortLevel = null, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsItem = null)

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
            var game = dofus2;  // string | 
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterTypeName = Chest;  // string? | only results with the translated type name (optional) 
            var filterMinLevel = 150;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 180;  // int? | only results which level is equal or below this value (optional) 
            var pageSize = 2;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsItem = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 

            try
            {
                // List Consumables
                ItemsListPaged result = apiInstance.GetItemsConsumablesList(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem);
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
    ApiResponse<ItemsListPaged> response = apiInstance.GetItemsConsumablesListWithHttpInfo(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem);
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
| **game** | **string** |  |  |
| **sortLevel** | **string?** | sort the resulting list by level, default unsorted | [optional]  |
| **filterTypeName** | **string?** | only results with the translated type name | [optional]  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **pageSize** | **int?** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int?** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsItem** | [**List&lt;string&gt;?**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |

### Return type

[**ItemsListPaged**](ItemsListPaged.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumables Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitemsconsumablessearch"></a>
# **GetItemsConsumablesSearch**
> List&lt;ItemListEntry&gt; GetItemsConsumablesSearch (string language, string game, string query, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? limit = null)

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
            var game = dofus2;  // string | 
            var query = Wholewrite;  // string | case sensitive search query
            var filterTypeName = Bread;  // string? | only results with the translated type name (optional) 
            var filterMinLevel = 1;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 200;  // int? | only results which level is equal or below this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)

            try
            {
                // Search Consumables
                List<ItemListEntry> result = apiInstance.GetItemsConsumablesSearch(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit);
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
    ApiResponse<List<ItemListEntry>> response = apiInstance.GetItemsConsumablesSearchWithHttpInfo(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit);
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
| **game** | **string** |  |  |
| **query** | **string** | case sensitive search query |  |
| **filterTypeName** | **string?** | only results with the translated type name | [optional]  |
| **filterMinLevel** | **int?** | only results which level is equal or above this value | [optional]  |
| **filterMaxLevel** | **int?** | only results which level is equal or below this value | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |

### Return type

[**List&lt;ItemListEntry&gt;**](ItemListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consumables Found |  -  |
| **400** | Bad Request  Possibilities: - empty or no query  |  -  |
| **404** | Not Found  Possibilities: - no hits for query |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var game = dofus2;  // string | 

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
| **game** | **string** |  |  |

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
| **200** | Consumable Found |  -  |
| **400** | Bad Request  Possibilities: - invalid ankama id format  |  -  |
| **404** | Not Found  Possibilities: - nothing found for this ankama_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

