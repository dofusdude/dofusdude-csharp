# Dofusdude.Api.Api.SetsApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllSetsList**](SetsApi.md#getallsetslist) | **GET** /{game}/{language}/sets/all | List All Sets |
| [**GetSetsList**](SetsApi.md#getsetslist) | **GET** /{game}/{language}/sets | List Sets |
| [**GetSetsSearch**](SetsApi.md#getsetssearch) | **GET** /{game}/{language}/sets/search | Search Sets |
| [**GetSetsSingle**](SetsApi.md#getsetssingle) | **GET** /{game}/{language}/sets/{ankama_id} | Single Sets |

<a id="getallsetslist"></a>
# **GetAllSetsList**
> SetsListPaged GetAllSetsList (string language, string game, string? sortLevel = null, int? filterMinHighestEquipmentLevel = null, int? filterMaxHighestEquipmentLevel = null, string? acceptEncoding = null)

List All Sets

Retrieve all sets with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAllSetsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new SetsApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus2;  // string | 
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinHighestEquipmentLevel = 190;  // int? | only results where the equipment with the highest level is above or equal to this value (optional) 
            var filterMaxHighestEquipmentLevel = 200;  // int? | only results where the equipment with the highest level is below or equal to this value (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 

            try
            {
                // List All Sets
                SetsListPaged result = apiInstance.GetAllSetsList(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetsApi.GetAllSetsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllSetsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List All Sets
    ApiResponse<SetsListPaged> response = apiInstance.GetAllSetsListWithHttpInfo(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, acceptEncoding);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetsApi.GetAllSetsListWithHttpInfo: " + e.Message);
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
| **filterMinHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **acceptEncoding** | **string?** | optional compression for saving bandwidth | [optional]  |

### Return type

[**SetsListPaged**](SetsListPaged.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Set Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsetslist"></a>
# **GetSetsList**
> SetsListPaged GetSetsList (string language, string game, string? sortLevel = null, int? filterMinHighestEquipmentLevel = null, int? filterMaxHighestEquipmentLevel = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsSet = null)

List Sets

Retrieve a list of sets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetSetsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new SetsApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus2;  // string | 
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinHighestEquipmentLevel = 190;  // int? | only results where the equipment with the highest level is above or equal to this value (optional) 
            var filterMaxHighestEquipmentLevel = 200;  // int? | only results where the equipment with the highest level is below or equal to this value (optional) 
            var pageSize = 20;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsSet = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 

            try
            {
                // List Sets
                SetsListPaged result = apiInstance.GetSetsList(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, pageSize, pageNumber, fieldsSet);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetsApi.GetSetsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSetsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Sets
    ApiResponse<SetsListPaged> response = apiInstance.GetSetsListWithHttpInfo(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, pageSize, pageNumber, fieldsSet);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetsApi.GetSetsListWithHttpInfo: " + e.Message);
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
| **filterMinHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **pageSize** | **int?** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int?** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsSet** | [**List&lt;string&gt;?**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |

### Return type

[**SetsListPaged**](SetsListPaged.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Set Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsetssearch"></a>
# **GetSetsSearch**
> List&lt;SetListEntry&gt; GetSetsSearch (string language, string game, string query, int? filterMinHighestEquipmentLevel = null, int? filterMaxHighestEquipmentLevel = null, int? limit = null)

Search Sets

Search in all names and descriptions of sets with a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetSetsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new SetsApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus2;  // string | 
            var query = Des;  // string | case sensitive search query
            var filterMinHighestEquipmentLevel = 195;  // int? | only results where the equipment with the highest level is above or equal to this value (optional) 
            var filterMaxHighestEquipmentLevel = 200;  // int? | only results where the equipment with the highest level is below or equal to this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)

            try
            {
                // Search Sets
                List<SetListEntry> result = apiInstance.GetSetsSearch(language, game, query, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetsApi.GetSetsSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSetsSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Sets
    ApiResponse<List<SetListEntry>> response = apiInstance.GetSetsSearchWithHttpInfo(language, game, query, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetsApi.GetSetsSearchWithHttpInfo: " + e.Message);
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
| **filterMinHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |

### Return type

[**List&lt;SetListEntry&gt;**](SetListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sets Found |  -  |
| **400** | Bad Request  Possibilities: - empty or no query  |  -  |
| **404** | Not Found  Possibilities: - no hits for query |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsetssingle"></a>
# **GetSetsSingle**
> EquipmentSet GetSetsSingle (string language, int ankamaId, string game)

Single Sets

Retrieve a specific set with id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetSetsSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new SetsApi(config);
            var language = "en";  // string | a valid language code
            var ankamaId = 499;  // int | identifier
            var game = dofus2;  // string | 

            try
            {
                // Single Sets
                EquipmentSet result = apiInstance.GetSetsSingle(language, ankamaId, game);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetsApi.GetSetsSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSetsSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single Sets
    ApiResponse<EquipmentSet> response = apiInstance.GetSetsSingleWithHttpInfo(language, ankamaId, game);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetsApi.GetSetsSingleWithHttpInfo: " + e.Message);
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

[**EquipmentSet**](EquipmentSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Set Found |  -  |
| **400** | Bad Request  Possibilities: - invalid ankama id format  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

