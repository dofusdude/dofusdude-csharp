# Dofusdude.Api.Api.SetsApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllSetsList**](SetsApi.md#getallsetslist) | **GET** /{game}/v1/{language}/sets/all | List All Sets |
| [**GetSetsList**](SetsApi.md#getsetslist) | **GET** /{game}/v1/{language}/sets | List Sets |
| [**GetSetsSearch**](SetsApi.md#getsetssearch) | **GET** /{game}/v1/{language}/sets/search | Search Sets |
| [**GetSetsSingle**](SetsApi.md#getsetssingle) | **GET** /{game}/v1/{language}/sets/{ankama_id} | Single Sets |

<a id="getallsetslist"></a>
# **GetAllSetsList**
> ListEquipmentSets GetAllSetsList (string language, string game, string? sortLevel = null, int? filterMinHighestEquipmentLevel = null, int? filterMaxHighestEquipmentLevel = null, string? acceptEncoding = null, bool? filterContainsCosmeticsOnly = null, bool? filterContainsCosmetics = null)

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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinHighestEquipmentLevel = 190;  // int? | only results where the equipment with the highest level is above or equal to this value (optional) 
            var filterMaxHighestEquipmentLevel = 200;  // int? | only results where the equipment with the highest level is below or equal to this value (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 
            var filterContainsCosmeticsOnly = true;  // bool? | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. (optional) 
            var filterContainsCosmetics = true;  // bool? | filter sets based on if they got cosmetic items in it. (optional) 

            try
            {
                // List All Sets
                ListEquipmentSets result = apiInstance.GetAllSetsList(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, acceptEncoding, filterContainsCosmeticsOnly, filterContainsCosmetics);
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
    ApiResponse<ListEquipmentSets> response = apiInstance.GetAllSetsListWithHttpInfo(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, acceptEncoding, filterContainsCosmeticsOnly, filterContainsCosmetics);
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
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string?** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **acceptEncoding** | **string?** | optional compression for saving bandwidth | [optional]  |
| **filterContainsCosmeticsOnly** | **bool?** | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. | [optional]  |
| **filterContainsCosmetics** | **bool?** | filter sets based on if they got cosmetic items in it. | [optional]  |

### Return type

[**ListEquipmentSets**](ListEquipmentSets.md)

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

<a id="getsetslist"></a>
# **GetSetsList**
> ListEquipmentSets GetSetsList (string language, string game, string? sortLevel = null, int? filterMinHighestEquipmentLevel = null, int? filterMaxHighestEquipmentLevel = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsSet = null, bool? filterContainsCosmeticsOnly = null, bool? filterContainsCosmetics = null)

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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var sortLevel = asc;  // string? | sort the resulting list by level, default unsorted (optional) 
            var filterMinHighestEquipmentLevel = 190;  // int? | only results where the equipment with the highest level is above or equal to this value (optional) 
            var filterMaxHighestEquipmentLevel = 200;  // int? | only results where the equipment with the highest level is below or equal to this value (optional) 
            var pageSize = 20;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsSet = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 
            var filterContainsCosmeticsOnly = true;  // bool? | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. (optional) 
            var filterContainsCosmetics = true;  // bool? | filter sets based on if they got cosmetic items in it. (optional) 

            try
            {
                // List Sets
                ListEquipmentSets result = apiInstance.GetSetsList(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, pageSize, pageNumber, fieldsSet, filterContainsCosmeticsOnly, filterContainsCosmetics);
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
    ApiResponse<ListEquipmentSets> response = apiInstance.GetSetsListWithHttpInfo(language, game, sortLevel, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, pageSize, pageNumber, fieldsSet, filterContainsCosmeticsOnly, filterContainsCosmetics);
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
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **sortLevel** | **string?** | sort the resulting list by level, default unsorted | [optional]  |
| **filterMinHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **pageSize** | **int?** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int?** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsSet** | [**List&lt;string&gt;?**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |
| **filterContainsCosmeticsOnly** | **bool?** | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. | [optional]  |
| **filterContainsCosmetics** | **bool?** | filter sets based on if they got cosmetic items in it. | [optional]  |

### Return type

[**ListEquipmentSets**](ListEquipmentSets.md)

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

<a id="getsetssearch"></a>
# **GetSetsSearch**
> List&lt;ListEquipmentSet&gt; GetSetsSearch (string language, string game, string query, int? filterMinHighestEquipmentLevel = null, int? filterMaxHighestEquipmentLevel = null, int? limit = null, bool? filterIsCosmetic = null)

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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'
            var query = Des;  // string | case sensitive search query
            var filterMinHighestEquipmentLevel = 195;  // int? | only results where the equipment with the highest level is above or equal to this value (optional) 
            var filterMaxHighestEquipmentLevel = 200;  // int? | only results where the equipment with the highest level is below or equal to this value (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)
            var filterIsCosmetic = true;  // bool? | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. (optional) 

            try
            {
                // Search Sets
                List<ListEquipmentSet> result = apiInstance.GetSetsSearch(language, game, query, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, limit, filterIsCosmetic);
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
    ApiResponse<List<ListEquipmentSet>> response = apiInstance.GetSetsSearchWithHttpInfo(language, game, query, filterMinHighestEquipmentLevel, filterMaxHighestEquipmentLevel, limit, filterIsCosmetic);
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
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |
| **query** | **string** | case sensitive search query |  |
| **filterMinHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is above or equal to this value | [optional]  |
| **filterMaxHighestEquipmentLevel** | **int?** | only results where the equipment with the highest level is below or equal to this value | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |
| **filterIsCosmetic** | **bool?** | filter sets based on if they only got cosmetic items in it. If true, the item ids are for the cosmetic endpoints instead of equipment. | [optional]  |

### Return type

[**List&lt;ListEquipmentSet&gt;**](ListEquipmentSet.md)

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
            var game = dofus3beta;  // string | game main 'dofus3' or beta channel 'dofus3beta'

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
| **game** | **string** | game main &#39;dofus3&#39; or beta channel &#39;dofus3beta&#39; |  |

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
| **200** |  |  -  |
| **400** |  |  -  |
| **404** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

