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

