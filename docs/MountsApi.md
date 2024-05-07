# Dofusdude.Api.Api.MountsApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllMountsList**](MountsApi.md#getallmountslist) | **GET** /{game}/{language}/mounts/all | List All Mounts |
| [**GetMountsList**](MountsApi.md#getmountslist) | **GET** /{game}/{language}/mounts | List Mounts |
| [**GetMountsSearch**](MountsApi.md#getmountssearch) | **GET** /{game}/{language}/mounts/search | Search Mounts |
| [**GetMountsSingle**](MountsApi.md#getmountssingle) | **GET** /{game}/{language}/mounts/{ankama_id} | Single Mounts |

<a id="getallmountslist"></a>
# **GetAllMountsList**
> MountsListPaged GetAllMountsList (string language, string game, string? filterFamilyName = null, string? acceptEncoding = null)

List All Mounts

Retrieve all mounts with one request. This endpoint is just an alias for the a list with disabled pagination (page[size]=-1) and all fields[type] set.  If you want everything unfiltered, delete the other query parameters.  Be careful with testing or (god forbid) using /all in your browser, the returned json is huge and will slow down the browser!  Tip: set the HTTP Header 'Accept-Encoding: gzip' for saving bandwidth. You will need to uncompress it on your end. Example with cURL: ``` curl -sH 'Accept-Encoding: gzip' <api-endpoint> | gunzip - ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAllMountsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new MountsApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus2;  // string | 
            var filterFamilyName = Dragoturkey;  // string? | only results with the translated family name (optional) 
            var acceptEncoding = "gzip";  // string? | optional compression for saving bandwidth (optional) 

            try
            {
                // List All Mounts
                MountsListPaged result = apiInstance.GetAllMountsList(language, game, filterFamilyName, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MountsApi.GetAllMountsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllMountsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List All Mounts
    ApiResponse<MountsListPaged> response = apiInstance.GetAllMountsListWithHttpInfo(language, game, filterFamilyName, acceptEncoding);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MountsApi.GetAllMountsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** |  |  |
| **filterFamilyName** | **string?** | only results with the translated family name | [optional]  |
| **acceptEncoding** | **string?** | optional compression for saving bandwidth | [optional]  |

### Return type

[**MountsListPaged**](MountsListPaged.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mounts Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmountslist"></a>
# **GetMountsList**
> MountsListPaged GetMountsList (string language, string game, string? filterFamilyName = null, int? pageSize = null, int? pageNumber = null, List<string>? fieldsMount = null)

List Mounts

Retrieve a list of mounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetMountsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new MountsApi(config);
            var language = "en";  // string | a valid language code
            var game = dofus2;  // string | 
            var filterFamilyName = Dragoturkey;  // string? | only results with the translated family name (optional) 
            var pageSize = 10;  // int? | size of the results from the list. -1 disables pagination and gets all in one response. (optional) 
            var pageNumber = 1;  // int? | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. (optional) 
            var fieldsMount = new List<string>?(); // List<string>? | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. (optional) 

            try
            {
                // List Mounts
                MountsListPaged result = apiInstance.GetMountsList(language, game, filterFamilyName, pageSize, pageNumber, fieldsMount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MountsApi.GetMountsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMountsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Mounts
    ApiResponse<MountsListPaged> response = apiInstance.GetMountsListWithHttpInfo(language, game, filterFamilyName, pageSize, pageNumber, fieldsMount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MountsApi.GetMountsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | a valid language code |  |
| **game** | **string** |  |  |
| **filterFamilyName** | **string?** | only results with the translated family name | [optional]  |
| **pageSize** | **int?** | size of the results from the list. -1 disables pagination and gets all in one response. | [optional]  |
| **pageNumber** | **int?** | page number based on the current page[size]. So you could get page 1 with 8 entrys and page 2 would have entries 8 to 16. | [optional]  |
| **fieldsMount** | [**List&lt;string&gt;?**](string.md) | adds fields from their detail endpoint to the item list entries. Multiple comma separated values allowed. | [optional]  |

### Return type

[**MountsListPaged**](MountsListPaged.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mounts Found |  -  |
| **400** | Bad Request  |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmountssearch"></a>
# **GetMountsSearch**
> List&lt;MountListEntry&gt; GetMountsSearch (string language, string game, string query, string? filterFamilyName = null, int? limit = null)

Search Mounts

Search in all names and descriptions of mounts with a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetMountsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new MountsApi(config);
            var language = fr;  // string | a valid language code
            var game = dofus2;  // string | 
            var query = Dorée;  // string | case sensitive search query
            var filterFamilyName = Dragodinde;  // string? | only results with the translated family name (optional) 
            var limit = 8;  // int? | maximum number of returned results (optional)  (default to 8)

            try
            {
                // Search Mounts
                List<MountListEntry> result = apiInstance.GetMountsSearch(language, game, query, filterFamilyName, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MountsApi.GetMountsSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMountsSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Mounts
    ApiResponse<List<MountListEntry>> response = apiInstance.GetMountsSearchWithHttpInfo(language, game, query, filterFamilyName, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MountsApi.GetMountsSearchWithHttpInfo: " + e.Message);
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
| **filterFamilyName** | **string?** | only results with the translated family name | [optional]  |
| **limit** | **int?** | maximum number of returned results | [optional] [default to 8] |

### Return type

[**List&lt;MountListEntry&gt;**](MountListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mounts Found |  -  |
| **400** | Bad Request  Possibilities: - empty or no query  |  -  |
| **404** | Not Found  Possibilities: - no hits for query |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmountssingle"></a>
# **GetMountsSingle**
> Mount GetMountsSingle (string language, int ankamaId, string game)

Single Mounts

Retrieve a specific mount with id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetMountsSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new MountsApi(config);
            var language = "en";  // string | a valid language code
            var ankamaId = 180;  // int | identifier
            var game = dofus2;  // string | 

            try
            {
                // Single Mounts
                Mount result = apiInstance.GetMountsSingle(language, ankamaId, game);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MountsApi.GetMountsSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMountsSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single Mounts
    ApiResponse<Mount> response = apiInstance.GetMountsSingleWithHttpInfo(language, ankamaId, game);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MountsApi.GetMountsSingleWithHttpInfo: " + e.Message);
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

[**Mount**](Mount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mount Found |  -  |
| **400** | Bad Request  Possibilities: - invalid ankama id format  |  -  |
| **404** | Not Found  Possibilities: - nothing found for this ankama_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

