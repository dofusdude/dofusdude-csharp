# Dofusdude.Api.Api.AlmanaxApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAlmanaxDate**](AlmanaxApi.md#getalmanaxdate) | **GET** /dofus3/v1/{language}/almanax/{date} | Single Almanax Date |
| [**GetAlmanaxRange**](AlmanaxApi.md#getalmanaxrange) | **GET** /dofus3/v1/{language}/almanax | Almanax Range |

<a id="getalmanaxdate"></a>
# **GetAlmanaxDate**
> Almanax GetAlmanaxDate (string language, DateOnly date)

Single Almanax Date

Get a single date. There are not more details in the returned object than the normal range endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAlmanaxDateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new AlmanaxApi(config);
            var language = fr;  // string | code
            var date = Tue Jul 14 00:00:00 UTC 2020;  // DateOnly | yyyy-mm-dd

            try
            {
                // Single Almanax Date
                Almanax result = apiInstance.GetAlmanaxDate(language, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlmanaxApi.GetAlmanaxDate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAlmanaxDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single Almanax Date
    ApiResponse<Almanax> response = apiInstance.GetAlmanaxDateWithHttpInfo(language, date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlmanaxApi.GetAlmanaxDateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | code |  |
| **date** | **DateOnly** | yyyy-mm-dd |  |

### Return type

[**Almanax**](Almanax.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalmanaxrange"></a>
# **GetAlmanaxRange**
> List&lt;Almanax&gt; GetAlmanaxRange (string language, string? filterBonusType = null, DateOnly? rangeFrom = null, DateOnly? rangeTo = null, int? rangeSize = null, string? timezone = null)

Almanax Range

Get a range of dates, defaults to today + 6 following days but can specified by the query parameters.   filter[bonus_type] can be used seperately and does not have an effect on the other parameters.  range[from] changes the start date, everything else defaults to 6 following dates from this start date.  range[to] when used without anything else, it will use today as start date and this parameter as end. All ranges are inclusive.  range[from] + range[to] = inclusive range over the specified dates, should never be farther apart than 35 days.  range[from|to] + range[size] no need to specify the date, just following days with [from] (0 is today) or go backwards in time with only [to] and [size].  Not all combinations are listed but this should give you an idea how to they could work.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetAlmanaxRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new AlmanaxApi(config);
            var language = fr;  // string | code
            var filterBonusType = experience-points;  // string? | ids from meta/{language}/almanax/bonuses (optional) 
            var rangeFrom = Thu Sep 15 00:00:00 UTC 2016;  // DateOnly? | yyyy-mm-dd (optional) 
            var rangeTo = Wed Sep 28 00:00:00 UTC 2016;  // DateOnly? | yyyy-mm-dd (optional) 
            var rangeSize = -1;  // int? | size of the returned range (optional) 
            var timezone = Europe/Paris;  // string? | determine what the current time is. If you live in Brazil, \"today\" will be hours apart from Paris. Use your timezone to get results relative to your location. (optional)  (default to "Europe/Paris")

            try
            {
                // Almanax Range
                List<Almanax> result = apiInstance.GetAlmanaxRange(language, filterBonusType, rangeFrom, rangeTo, rangeSize, timezone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlmanaxApi.GetAlmanaxRange: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAlmanaxRangeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Almanax Range
    ApiResponse<List<Almanax>> response = apiInstance.GetAlmanaxRangeWithHttpInfo(language, filterBonusType, rangeFrom, rangeTo, rangeSize, timezone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlmanaxApi.GetAlmanaxRangeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string** | code |  |
| **filterBonusType** | **string?** | ids from meta/{language}/almanax/bonuses | [optional]  |
| **rangeFrom** | **DateOnly?** | yyyy-mm-dd | [optional]  |
| **rangeTo** | **DateOnly?** | yyyy-mm-dd | [optional]  |
| **rangeSize** | **int?** | size of the returned range | [optional]  |
| **timezone** | **string?** | determine what the current time is. If you live in Brazil, \&quot;today\&quot; will be hours apart from Paris. Use your timezone to get results relative to your location. | [optional] [default to &quot;Europe/Paris&quot;] |

### Return type

[**List&lt;Almanax&gt;**](Almanax.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

