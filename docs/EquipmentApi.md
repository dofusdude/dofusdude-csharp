# Dofusdude.Api.Api.EquipmentApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllItemsEquipmentList**](EquipmentApi.md#getallitemsequipmentlist) | **GET** /{game}/v1/{language}/items/equipment/all | List All Equipment |
| [**GetItemsEquipmentList**](EquipmentApi.md#getitemsequipmentlist) | **GET** /{game}/v1/{language}/items/equipment | List Equipment |
| [**GetItemsEquipmentSearch**](EquipmentApi.md#getitemsequipmentsearch) | **GET** /{game}/v1/{language}/items/equipment/search | Search Equipment |
| [**GetItemsEquipmentSingle**](EquipmentApi.md#getitemsequipmentsingle) | **GET** /{game}/v1/{language}/items/equipment/{ankama_id} | Single Equipment |

<a id="getallitemsequipmentlist"></a>
# **GetAllItemsEquipmentList**
> ListItems GetAllItemsEquipmentList (string language, string game, string? sortLevel = null, int? filterMinLevel = null, int? filterMaxLevel = null, string? acceptEncoding = null, List<string>? filterTypeNameId = null)

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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = desc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 10;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 60;  // int? | only results which level is equal or below this value (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List All Equipment
                ListItems result = apiInstance.GetAllItemsEquipmentList(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
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
    ApiResponse<ListItems> response = apiInstance.GetAllItemsEquipmentListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, acceptEncoding, filterTypeNameId);
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

<a id="getitemsequipmentlist"></a>
# **GetItemsEquipmentList**
> ListItems GetItemsEquipmentList (string language, string game, string? sortLevel = null, int? filterMinLevel = null, int? filterMaxLevel = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsItem = null, List<string>? filterTypeNameId = null)

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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = desc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinLevel = 10;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 60;  // int? | only results which level is equal or below this value (optional) 
            var pageSize = 5;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsItem = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // List Equipment
                ListItems result = apiInstance.GetItemsEquipmentList(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
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
    ApiResponse<ListItems> response = apiInstance.GetItemsEquipmentListWithHttpInfo(language, game, sortLevel, filterMinLevel, filterMaxLevel, pageSize, pageNumber, fieldsItem, filterTypeNameId);
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

<a id="getitemsequipmentsearch"></a>
# **GetItemsEquipmentSearch**
> List&lt;ListItem&gt; GetItemsEquipmentSearch (string language, string game, string query, int? filterMinLevel = null, int? filterMaxLevel = null, int? limit = null, List<string>? filterTypeNameId = null)

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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var query = nidas;  // string | case sensitive search query
            var filterMinLevel = 150;  // int? | only results which level is equal or above this value (optional) 
            var filterMaxLevel = 200;  // int? | only results which level is equal or below this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)
            var filterTypeNameId = new List<string>?(); // List<string>? | multi-filter results with the english type name. Add with \"wood\" or \"+wood\" and exclude with \"-wood\". (optional) 

            try
            {
                // Search Equipment
                List<ListItem> result = apiInstance.GetItemsEquipmentSearch(language, game, query, filterMinLevel, filterMaxLevel, limit, filterTypeNameId);
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
    ApiResponse<List<ListItem>> response = apiInstance.GetItemsEquipmentSearchWithHttpInfo(language, game, query, filterMinLevel, filterMaxLevel, limit, filterTypeNameId);
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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'

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
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

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
| **200** |  |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

