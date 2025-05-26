# Dofusdude.Api.Api.WebhooksApi

All URIs are relative to *https://api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteWebhooksAlmanaxId**](WebhooksApi.md#deletewebhooksalmanaxid) | **DELETE** /webhooks/almanax/{id} | Unregister Almanax Hook |
| [**DeleteWebhooksRssId**](WebhooksApi.md#deletewebhooksrssid) | **DELETE** /webhooks/rss/{id} | Unregister RSS Hook |
| [**DeleteWebhooksTwitterId**](WebhooksApi.md#deletewebhookstwitterid) | **DELETE** /webhooks/twitter/{id} | Unregister Twitter Hook |
| [**GetMetaWebhooksAlmanax**](WebhooksApi.md#getmetawebhooksalmanax) | **GET** /meta/webhooks/almanax | Get Almanax Hook Metainfo |
| [**GetMetaWebhooksRss**](WebhooksApi.md#getmetawebhooksrss) | **GET** /meta/webhooks/rss | Get RSS Hook Metainfo |
| [**GetMetaWebhooksTwitter**](WebhooksApi.md#getmetawebhookstwitter) | **GET** /meta/webhooks/twitter | Get Twitter Hook Metainfo |
| [**GetWebhooksAlmanaxId**](WebhooksApi.md#getwebhooksalmanaxid) | **GET** /webhooks/almanax/{id} | Get Almanax Hook |
| [**GetWebhooksRssId**](WebhooksApi.md#getwebhooksrssid) | **GET** /webhooks/rss/{id} | Get RSS Hook |
| [**GetWebhooksTwitterId**](WebhooksApi.md#getwebhookstwitterid) | **GET** /webhooks/twitter/{id} | Get Twitter Hook |
| [**PostWebhooksAlmanax**](WebhooksApi.md#postwebhooksalmanax) | **POST** /webhooks/almanax | Register Almanax Hook |
| [**PostWebhooksRss**](WebhooksApi.md#postwebhooksrss) | **POST** /webhooks/rss | Register RSS Hook |
| [**PostWebhooksTwitter**](WebhooksApi.md#postwebhookstwitter) | **POST** /webhooks/twitter | Register Twitter Hook |
| [**PutWebhooksAlmanaxId**](WebhooksApi.md#putwebhooksalmanaxid) | **PUT** /webhooks/almanax/{id} | Update Almanax Hook |
| [**PutWebhooksRssId**](WebhooksApi.md#putwebhooksrssid) | **PUT** /webhooks/rss/{id} | Update RSS Hook |
| [**PutWebhooksTwitterId**](WebhooksApi.md#putwebhookstwitterid) | **PUT** /webhooks/twitter/{id} | Update Twitter Hook |

<a id="deletewebhooksalmanaxid"></a>
# **DeleteWebhooksAlmanaxId**
> void DeleteWebhooksAlmanaxId (string id)

Unregister Almanax Hook

Delete a Webhook from the service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class DeleteWebhooksAlmanaxIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook

            try
            {
                // Unregister Almanax Hook
                apiInstance.DeleteWebhooksAlmanaxId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksAlmanaxId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhooksAlmanaxIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unregister Almanax Hook
    apiInstance.DeleteWebhooksAlmanaxIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksAlmanaxIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletewebhooksrssid"></a>
# **DeleteWebhooksRssId**
> void DeleteWebhooksRssId (string id)

Unregister RSS Hook

Delete a Webhook from the service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class DeleteWebhooksRssIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook

            try
            {
                // Unregister RSS Hook
                apiInstance.DeleteWebhooksRssId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksRssId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhooksRssIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unregister RSS Hook
    apiInstance.DeleteWebhooksRssIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksRssIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletewebhookstwitterid"></a>
# **DeleteWebhooksTwitterId**
> void DeleteWebhooksTwitterId (string id)

Unregister Twitter Hook

Delete a Webhook from the service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class DeleteWebhooksTwitterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook

            try
            {
                // Unregister Twitter Hook
                apiInstance.DeleteWebhooksTwitterId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksTwitterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhooksTwitterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unregister Twitter Hook
    apiInstance.DeleteWebhooksTwitterIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksTwitterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmetawebhooksalmanax"></a>
# **GetMetaWebhooksAlmanax**
> GetMetaWebhooksTwitter200Response GetMetaWebhooksAlmanax ()

Get Almanax Hook Metainfo

Get a list of all available subscriptions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetMetaWebhooksAlmanaxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);

            try
            {
                // Get Almanax Hook Metainfo
                GetMetaWebhooksTwitter200Response result = apiInstance.GetMetaWebhooksAlmanax();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetMetaWebhooksAlmanax: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetaWebhooksAlmanaxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Almanax Hook Metainfo
    ApiResponse<GetMetaWebhooksTwitter200Response> response = apiInstance.GetMetaWebhooksAlmanaxWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetMetaWebhooksAlmanaxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetMetaWebhooksTwitter200Response**](GetMetaWebhooksTwitter200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmetawebhooksrss"></a>
# **GetMetaWebhooksRss**
> GetMetaWebhooksTwitter200Response GetMetaWebhooksRss ()

Get RSS Hook Metainfo

Get a list of all available subscriptions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetMetaWebhooksRssExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);

            try
            {
                // Get RSS Hook Metainfo
                GetMetaWebhooksTwitter200Response result = apiInstance.GetMetaWebhooksRss();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetMetaWebhooksRss: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetaWebhooksRssWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get RSS Hook Metainfo
    ApiResponse<GetMetaWebhooksTwitter200Response> response = apiInstance.GetMetaWebhooksRssWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetMetaWebhooksRssWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetMetaWebhooksTwitter200Response**](GetMetaWebhooksTwitter200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmetawebhookstwitter"></a>
# **GetMetaWebhooksTwitter**
> GetMetaWebhooksTwitter200Response GetMetaWebhooksTwitter ()

Get Twitter Hook Metainfo

Get a list of all available subscriptions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetMetaWebhooksTwitterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);

            try
            {
                // Get Twitter Hook Metainfo
                GetMetaWebhooksTwitter200Response result = apiInstance.GetMetaWebhooksTwitter();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetMetaWebhooksTwitter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetaWebhooksTwitterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Twitter Hook Metainfo
    ApiResponse<GetMetaWebhooksTwitter200Response> response = apiInstance.GetMetaWebhooksTwitterWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetMetaWebhooksTwitterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetMetaWebhooksTwitter200Response**](GetMetaWebhooksTwitter200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhooksalmanaxid"></a>
# **GetWebhooksAlmanaxId**
> AlmanaxWebhook GetWebhooksAlmanaxId (string id)

Get Almanax Hook

Retrieve details about an existing Almanax Webhook with a given uuid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetWebhooksAlmanaxIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook

            try
            {
                // Get Almanax Hook
                AlmanaxWebhook result = apiInstance.GetWebhooksAlmanaxId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooksAlmanaxId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksAlmanaxIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Almanax Hook
    ApiResponse<AlmanaxWebhook> response = apiInstance.GetWebhooksAlmanaxIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetWebhooksAlmanaxIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |

### Return type

[**AlmanaxWebhook**](AlmanaxWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhooksrssid"></a>
# **GetWebhooksRssId**
> RssWebhook GetWebhooksRssId (string id)

Get RSS Hook

Retrieve details about an existing RSS Webhook with a given uuid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetWebhooksRssIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook

            try
            {
                // Get RSS Hook
                RssWebhook result = apiInstance.GetWebhooksRssId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooksRssId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksRssIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get RSS Hook
    ApiResponse<RssWebhook> response = apiInstance.GetWebhooksRssIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetWebhooksRssIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |

### Return type

[**RssWebhook**](RssWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhookstwitterid"></a>
# **GetWebhooksTwitterId**
> TwitterWebhook GetWebhooksTwitterId (string id)

Get Twitter Hook

Retrieve details about an existing Twitter Webhook with a given uuid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class GetWebhooksTwitterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook

            try
            {
                // Get Twitter Hook
                TwitterWebhook result = apiInstance.GetWebhooksTwitterId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooksTwitterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksTwitterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Twitter Hook
    ApiResponse<TwitterWebhook> response = apiInstance.GetWebhooksTwitterIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetWebhooksTwitterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |

### Return type

[**TwitterWebhook**](TwitterWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postwebhooksalmanax"></a>
# **PostWebhooksAlmanax**
> void PostWebhooksAlmanax (CreateAlmanaxWebhook createAlmanaxWebhook = null)

Register Almanax Hook

Register a new Webhook to post Almanax updates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class PostWebhooksAlmanaxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var createAlmanaxWebhook = new CreateAlmanaxWebhook(); // CreateAlmanaxWebhook |  (optional) 

            try
            {
                // Register Almanax Hook
                apiInstance.PostWebhooksAlmanax(createAlmanaxWebhook);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PostWebhooksAlmanax: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWebhooksAlmanaxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register Almanax Hook
    apiInstance.PostWebhooksAlmanaxWithHttpInfo(createAlmanaxWebhook);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PostWebhooksAlmanaxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAlmanaxWebhook** | [**CreateAlmanaxWebhook**](CreateAlmanaxWebhook.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postwebhooksrss"></a>
# **PostWebhooksRss**
> void PostWebhooksRss (CreateRSSWebhook createRSSWebhook = null)

Register RSS Hook

Register a new Webhook to post RSS news as soon as they are posted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class PostWebhooksRssExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var createRSSWebhook = new CreateRSSWebhook(); // CreateRSSWebhook |  (optional) 

            try
            {
                // Register RSS Hook
                apiInstance.PostWebhooksRss(createRSSWebhook);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PostWebhooksRss: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWebhooksRssWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register RSS Hook
    apiInstance.PostWebhooksRssWithHttpInfo(createRSSWebhook);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PostWebhooksRssWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRSSWebhook** | [**CreateRSSWebhook**](CreateRSSWebhook.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postwebhookstwitter"></a>
# **PostWebhooksTwitter**
> void PostWebhooksTwitter (CreateTwitterWebhook createTwitterWebhook = null)

Register Twitter Hook

Register a new Webhook to post Twitter updates as soon as they are posted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class PostWebhooksTwitterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var createTwitterWebhook = new CreateTwitterWebhook(); // CreateTwitterWebhook |  (optional) 

            try
            {
                // Register Twitter Hook
                apiInstance.PostWebhooksTwitter(createTwitterWebhook);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PostWebhooksTwitter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWebhooksTwitterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register Twitter Hook
    apiInstance.PostWebhooksTwitterWithHttpInfo(createTwitterWebhook);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PostWebhooksTwitterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTwitterWebhook** | [**CreateTwitterWebhook**](CreateTwitterWebhook.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putwebhooksalmanaxid"></a>
# **PutWebhooksAlmanaxId**
> AlmanaxWebhook PutWebhooksAlmanaxId (string id, PutAlmanaxWebhook putAlmanaxWebhook = null)

Update Almanax Hook

Update the details of an Almanax Webhook. All fields are optional and arrays will be overwritten, so always put all selected items of an array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class PutWebhooksAlmanaxIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook
            var putAlmanaxWebhook = new PutAlmanaxWebhook(); // PutAlmanaxWebhook |  (optional) 

            try
            {
                // Update Almanax Hook
                AlmanaxWebhook result = apiInstance.PutWebhooksAlmanaxId(id, putAlmanaxWebhook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PutWebhooksAlmanaxId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWebhooksAlmanaxIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Almanax Hook
    ApiResponse<AlmanaxWebhook> response = apiInstance.PutWebhooksAlmanaxIdWithHttpInfo(id, putAlmanaxWebhook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PutWebhooksAlmanaxIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |
| **putAlmanaxWebhook** | [**PutAlmanaxWebhook**](PutAlmanaxWebhook.md) |  | [optional]  |

### Return type

[**AlmanaxWebhook**](AlmanaxWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putwebhooksrssid"></a>
# **PutWebhooksRssId**
> RssWebhook PutWebhooksRssId (string id, PutRSSWebhook putRSSWebhook = null)

Update RSS Hook

Update the details of a RSS Webhook. All fields are optional and arrays will be overwritten, so always put all selected items of an array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class PutWebhooksRssIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook
            var putRSSWebhook = new PutRSSWebhook(); // PutRSSWebhook |  (optional) 

            try
            {
                // Update RSS Hook
                RssWebhook result = apiInstance.PutWebhooksRssId(id, putRSSWebhook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PutWebhooksRssId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWebhooksRssIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update RSS Hook
    ApiResponse<RssWebhook> response = apiInstance.PutWebhooksRssIdWithHttpInfo(id, putRSSWebhook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PutWebhooksRssIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |
| **putRSSWebhook** | [**PutRSSWebhook**](PutRSSWebhook.md) |  | [optional]  |

### Return type

[**RssWebhook**](RssWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putwebhookstwitterid"></a>
# **PutWebhooksTwitterId**
> TwitterWebhook PutWebhooksTwitterId (string id, PutTwitterWebhook putTwitterWebhook = null)

Update Twitter Hook

Update the details of a Twitter Webhook. All fields are optional and arrays will be overwritten, so always put all selected items of an array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class PutWebhooksTwitterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dofusdu.de";
            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // string | the ID returned from the API when creating the webhook
            var putTwitterWebhook = new PutTwitterWebhook(); // PutTwitterWebhook |  (optional) 

            try
            {
                // Update Twitter Hook
                TwitterWebhook result = apiInstance.PutWebhooksTwitterId(id, putTwitterWebhook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.PutWebhooksTwitterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWebhooksTwitterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Twitter Hook
    ApiResponse<TwitterWebhook> response = apiInstance.PutWebhooksTwitterIdWithHttpInfo(id, putTwitterWebhook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.PutWebhooksTwitterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the ID returned from the API when creating the webhook |  |
| **putTwitterWebhook** | [**PutTwitterWebhook**](PutTwitterWebhook.md) |  | [optional]  |

### Return type

[**TwitterWebhook**](TwitterWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

