# Dofusdude.Api.Api.EquipmentApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllItemsEquipmentList**](EquipmentApi.md#getallitemsequipmentlist) | **GET** /{game}/{language}/items/equipment/all | List All Equipment |
| [**GetItemsEquipmentList**](EquipmentApi.md#getitemsequipmentlist) | **GET** /{game}/{language}/items/equipment | List Equipment |
| [**GetItemsEquipmentSearch**](EquipmentApi.md#getitemsequipmentsearch) | **GET** /{game}/{language}/items/equipment/search | Search Equipment |
| [**GetItemsEquipmentSingle**](EquipmentApi.md#getitemsequipmentsingle) | **GET** /{game}/{language}/items/equipment/{ankama_id} | Single Equipment |

<a id="getallitemsequipmentlist"></a>
# **GetAllItemsEquipmentList**
> ItemsListPaged GetAllItemsEquipmentList (string language, string game, string? sortLevel = null, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, string? acceptEncoding = null)

List All Equipment

Retrieve all equipment items with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAllItemsEquipmentListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new EquipmentApi(config);
            var language = en;  // string | a valid language code
            var game = dofus2;  // string | 
            var sortLevel = desc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterTypeName = Sword;  // string? | only results with the translated type name (optional) 
            var filterMinLevel = 10;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 60;  // int? | only results which level is equal or below this value (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 

            try
            {
                // List All Equipment
                ItemsListPaged result = apiInstance.GetAllItemsEquipmentList(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EquipmentApi.GetAllItemsEquipmentList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllItemsEquipmentListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List All Equipment
    ApiResponse<ItemsListPaged> response = apiInstance.GetAllItemsEquipmentListWithHttpInfo(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, acceptEncoding);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EquipmentApi.GetAllItemsEquipmentListWithHttpInfo: " + e.Message);
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
| **200** | Equipment Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitemsequipmentlist"></a>
# **GetItemsEquipmentList**
> ItemsListPaged GetItemsEquipmentList (string language, string game, string? sortLevel = null, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsItem = null)

List Equipment

Retrieve a list of equipment items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsEquipmentListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new EquipmentApi(config);
            var language = en;  // string | a valid language code
            var game = dofus2;  // string | 
            var sortLevel = desc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterTypeName = Sword;  // string? | only results with the translated type name (optional) 
            var filterMinLevel = 10;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 60;  // int? | only results which level is equal or below this value (optional) 
            var pageSize = 5;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsItem = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 

            try
            {
                // List Equipment
                ItemsListPaged result = apiInstance.GetItemsEquipmentList(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EquipmentApi.GetItemsEquipmentList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsEquipmentListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Equipment
    ApiResponse<ItemsListPaged> response = apiInstance.GetItemsEquipmentListWithHttpInfo(language, game, sortLevel, filterTypeName, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EquipmentApi.GetItemsEquipmentListWithHttpInfo: " + e.Message);
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
| **200** | Equipment Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitemsequipmentsearch"></a>
# **GetItemsEquipmentSearch**
> List&lt;ItemListEntry&gt; GetItemsEquipmentSearch (string language, string game, string query, string? filterTypeName = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? limit = null)

Search Equipment

Search in all names and descriptions of equipment items with a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsEquipmentSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new EquipmentApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus2;  // string | 
            var query = nidas;  // string | case sensitive search query
            var filterTypeName = boots;  // string? | only results with the translated type name (optional) 
            var filterMinLevel = 150;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 200;  // int? | only results which level is equal or below this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)

            try
            {
                // Search Equipment
                List<ItemListEntry> result = apiInstance.GetItemsEquipmentSearch(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EquipmentApi.GetItemsEquipmentSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsEquipmentSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Equipment
    ApiResponse<List<ItemListEntry>> response = apiInstance.GetItemsEquipmentSearchWithHttpInfo(language, game, query, filterTypeName, filterMinLevel, filterMaxLevel, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EquipmentApi.GetItemsEquipmentSearchWithHttpInfo: " + e.Message);
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
| **200** | Equipment Found |  -  |
| **400** | Bad Request  Possibilities: - empty or no query  |  -  |
| **404** | Not Found  Possibilities: - no hits for query |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitemsequipmentsingle"></a>
# **GetItemsEquipmentSingle**
> Weapon GetItemsEquipmentSingle (string language, int ankamaId, string game)

Single Equipment

Retrieve a specific equipment item with id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetItemsEquipmentSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new EquipmentApi(config);
            var language = "en";  // string | a valid language code
            var ankamaId = 26009;  // int | identifier
            var game = dofus2;  // string | 

            try
            {
                // Single Equipment
                Weapon result = apiInstance.GetItemsEquipmentSingle(language, ankamaId, game);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EquipmentApi.GetItemsEquipmentSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsEquipmentSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single Equipment
    ApiResponse<Weapon> response = apiInstance.GetItemsEquipmentSingleWithHttpInfo(language, ankamaId, game);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EquipmentApi.GetItemsEquipmentSingleWithHttpInfo: " + e.Message);
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

[**Weapon**](Weapon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Equipment Found |  -  |
| **400** | Bad Request  Possibilities: - invalid ankama id format  |  -  |
| **404** | Not Found  Possibilities: - nothing found for this ankama_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

