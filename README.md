# Dofusdude.Api - the C# library for the dofusdude

# A project for you - the developer.
The all-in-one toolbelt for your next Ankama related project.

## Client SDKs
- [Javascript](https://github.com/dofusdude/dofusdude-js) `npm i dofusdude-js - -save`
- [Typescript](https://github.com/dofusdude/dofusdude-ts) `npm i dofusdude-ts - -save`
- [Go](https://github.com/dofusdude/dodugo) `go get -u github.com/dofusdude/dodugo`
- [Python](https://github.com/dofusdude/dofusdude-py) `pip install dofusdude`
- [PHP](https://github.com/dofusdude/dofusdude-php)
- [Java](https://github.com/dofusdude/dofusdude-java) Maven with GitHub packages setup

Everything, including this site, is generated out of the [Docs Repo](https://github.com/dofusdude/api-docs). Consider it the Single Source of Truth. If there is a problem with the SDKs, create an issue there.

Your favorite language is missing? Please let me know!

# Main Features
- 🥷 **Seamless Auto-Update** load data in the background when a new Dofus version is released and serving it within 10 minutes with atomic data source switching. No downtime and no effects for the user, just always up-to-date.

- ⚡ **Blazingly Fast** all data in-memory, aggressive caching over short time spans, HTTP/2 multiplexing, written in Go, optimized for low latency, hosted on bare metal in 🇩🇪.

- 📨 **Discord Integration** Ankama related RSS and Almanax feeds to post to Discord servers with advanced features like filters or mentions. Use the endpoints as a dev or the official [Web Client](https://discord.dofusdude.com) as a user.

- 🩸 **Dofus 2 Beta** from stable to bleeding edge by replacing /dofus2 with /dofus2beta.

- 🗣️ **Multilingual** supporting _en_, _fr_, _es_, _pt_ including the dropped languages from the Dofus website _de_ and _it_.

- 🧠 **Search by Relevance** allowing typos in name and description, handled by language specific text analysis and indexing.

- 🕵️ **Complete** actual data from the game including items invisible to the encyclopedia like quest items.

- 🖼️ **HD Images** rendering game assets to high-res images with up to 800x800 px.

... and much more on the Roadmap on my [Discord](https://discord.gg/3EtHskZD8h).


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.9.4
- SDK version: 0.9.4
- Generator version: 7.10.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://discord.gg/3EtHskZD8h](https://discord.gg/3EtHskZD8h)

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Dofusdude.Api.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dofusdude.Api.Api;
using Dofusdude.Api.Client;
using Dofusdude.Api.Model;

namespace Example
{
    public class Example
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
                AlmanaxEntry result = apiInstance.GetAlmanaxDate(language, date);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AlmanaxApi.GetAlmanaxDate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.dofusdu.de*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AlmanaxApi* | [**GetAlmanaxDate**](docs/AlmanaxApi.md#getalmanaxdate) | **GET** /dofus2/{language}/almanax/{date} | Single Almanax Date
*AlmanaxApi* | [**GetAlmanaxRange**](docs/AlmanaxApi.md#getalmanaxrange) | **GET** /dofus2/{language}/almanax | Almanax Range
*ConsumablesApi* | [**GetAllItemsConsumablesList**](docs/ConsumablesApi.md#getallitemsconsumableslist) | **GET** /{game}/{language}/items/consumables/all | List All Consumables
*ConsumablesApi* | [**GetItemsConsumablesList**](docs/ConsumablesApi.md#getitemsconsumableslist) | **GET** /{game}/{language}/items/consumables | List Consumables
*ConsumablesApi* | [**GetItemsConsumablesSearch**](docs/ConsumablesApi.md#getitemsconsumablessearch) | **GET** /{game}/{language}/items/consumables/search | Search Consumables
*ConsumablesApi* | [**GetItemsConsumablesSingle**](docs/ConsumablesApi.md#getitemsconsumablessingle) | **GET** /{game}/{language}/items/consumables/{ankama_id} | Single Consumables
*CosmeticsApi* | [**GetAllCosmeticsList**](docs/CosmeticsApi.md#getallcosmeticslist) | **GET** /{game}/{language}/items/cosmetics/all | List All Cosmetics
*CosmeticsApi* | [**GetCosmeticsList**](docs/CosmeticsApi.md#getcosmeticslist) | **GET** /{game}/{language}/items/cosmetics | List Cosmetics
*CosmeticsApi* | [**GetCosmeticsSearch**](docs/CosmeticsApi.md#getcosmeticssearch) | **GET** /{game}/{language}/items/cosmetics/search | Search Cosmetics
*CosmeticsApi* | [**GetCosmeticsSingle**](docs/CosmeticsApi.md#getcosmeticssingle) | **GET** /{game}/{language}/items/cosmetics/{ankama_id} | Single Cosmetics
*EquipmentApi* | [**GetAllItemsEquipmentList**](docs/EquipmentApi.md#getallitemsequipmentlist) | **GET** /{game}/{language}/items/equipment/all | List All Equipment
*EquipmentApi* | [**GetItemsEquipmentList**](docs/EquipmentApi.md#getitemsequipmentlist) | **GET** /{game}/{language}/items/equipment | List Equipment
*EquipmentApi* | [**GetItemsEquipmentSearch**](docs/EquipmentApi.md#getitemsequipmentsearch) | **GET** /{game}/{language}/items/equipment/search | Search Equipment
*EquipmentApi* | [**GetItemsEquipmentSingle**](docs/EquipmentApi.md#getitemsequipmentsingle) | **GET** /{game}/{language}/items/equipment/{ankama_id} | Single Equipment
*GameApi* | [**GetGameSearch**](docs/GameApi.md#getgamesearch) | **GET** /{game}/{language}/search | Game Search
*GameApi* | [**GetItemsAllSearch**](docs/GameApi.md#getitemsallsearch) | **GET** /{game}/{language}/items/search | Search All Items
*MetaApi* | [**GetGameSearchTypes**](docs/MetaApi.md#getgamesearchtypes) | **GET** /dofus2/meta/search/types | Available Game Search Types
*MetaApi* | [**GetItemTypes**](docs/MetaApi.md#getitemtypes) | **GET** /dofus2/meta/items/types | Available Item Types
*MetaApi* | [**GetMetaAlmanaxBonuses**](docs/MetaApi.md#getmetaalmanaxbonuses) | **GET** /dofus2/meta/{language}/almanax/bonuses | Available Almanax Bonuses
*MetaApi* | [**GetMetaAlmanaxBonusesSearch**](docs/MetaApi.md#getmetaalmanaxbonusessearch) | **GET** /dofus2/meta/{language}/almanax/bonuses/search | Search Available Almanax Bonuses
*MetaApi* | [**GetMetaElements**](docs/MetaApi.md#getmetaelements) | **GET** /dofus2/meta/elements | Effects and Condition Elements
*MetaApi* | [**GetMetaVersion**](docs/MetaApi.md#getmetaversion) | **GET** /dofus2/meta/version | Game Version
*MountsApi* | [**GetAllMountsList**](docs/MountsApi.md#getallmountslist) | **GET** /{game}/{language}/mounts/all | List All Mounts
*MountsApi* | [**GetMountsList**](docs/MountsApi.md#getmountslist) | **GET** /{game}/{language}/mounts | List Mounts
*MountsApi* | [**GetMountsSearch**](docs/MountsApi.md#getmountssearch) | **GET** /{game}/{language}/mounts/search | Search Mounts
*MountsApi* | [**GetMountsSingle**](docs/MountsApi.md#getmountssingle) | **GET** /{game}/{language}/mounts/{ankama_id} | Single Mounts
*QuestItemsApi* | [**GetAllItemsQuestList**](docs/QuestItemsApi.md#getallitemsquestlist) | **GET** /{game}/{language}/items/quest/all | List All Quest Items
*QuestItemsApi* | [**GetItemQuestSingle**](docs/QuestItemsApi.md#getitemquestsingle) | **GET** /{game}/{language}/items/quest/{ankama_id} | Single Quest Items
*QuestItemsApi* | [**GetItemsQuestList**](docs/QuestItemsApi.md#getitemsquestlist) | **GET** /{game}/{language}/items/quest | List Quest Items
*QuestItemsApi* | [**GetItemsQuestSearch**](docs/QuestItemsApi.md#getitemsquestsearch) | **GET** /{game}/{language}/items/quest/search | Search Quest Items
*ResourcesApi* | [**GetAllItemsResourcesList**](docs/ResourcesApi.md#getallitemsresourceslist) | **GET** /{game}/{language}/items/resources/all | List All Resources
*ResourcesApi* | [**GetItemsResourceSearch**](docs/ResourcesApi.md#getitemsresourcesearch) | **GET** /{game}/{language}/items/resources/search | Search Resources
*ResourcesApi* | [**GetItemsResourcesList**](docs/ResourcesApi.md#getitemsresourceslist) | **GET** /{game}/{language}/items/resources | List Resources
*ResourcesApi* | [**GetItemsResourcesSingle**](docs/ResourcesApi.md#getitemsresourcessingle) | **GET** /{game}/{language}/items/resources/{ankama_id} | Single Resources
*SetsApi* | [**GetAllSetsList**](docs/SetsApi.md#getallsetslist) | **GET** /{game}/{language}/sets/all | List All Sets
*SetsApi* | [**GetSetsList**](docs/SetsApi.md#getsetslist) | **GET** /{game}/{language}/sets | List Sets
*SetsApi* | [**GetSetsSearch**](docs/SetsApi.md#getsetssearch) | **GET** /{game}/{language}/sets/search | Search Sets
*SetsApi* | [**GetSetsSingle**](docs/SetsApi.md#getsetssingle) | **GET** /{game}/{language}/sets/{ankama_id} | Single Sets
*WebhooksApi* | [**DeleteWebhooksAlmanaxId**](docs/WebhooksApi.md#deletewebhooksalmanaxid) | **DELETE** /webhooks/almanax/{id} | Unregister Almanax Hook
*WebhooksApi* | [**DeleteWebhooksRssId**](docs/WebhooksApi.md#deletewebhooksrssid) | **DELETE** /webhooks/rss/{id} | Unregister RSS Hook
*WebhooksApi* | [**DeleteWebhooksTwitterId**](docs/WebhooksApi.md#deletewebhookstwitterid) | **DELETE** /webhooks/twitter/{id} | Unregister Twitter Hook
*WebhooksApi* | [**GetMetaWebhooksAlmanax**](docs/WebhooksApi.md#getmetawebhooksalmanax) | **GET** /meta/webhooks/almanax | Get Almanax Hook Metainfo
*WebhooksApi* | [**GetMetaWebhooksRss**](docs/WebhooksApi.md#getmetawebhooksrss) | **GET** /meta/webhooks/rss | Get RSS Hook Metainfo
*WebhooksApi* | [**GetMetaWebhooksTwitter**](docs/WebhooksApi.md#getmetawebhookstwitter) | **GET** /meta/webhooks/twitter | Get Twitter Hook Metainfo
*WebhooksApi* | [**GetWebhooksAlmanaxId**](docs/WebhooksApi.md#getwebhooksalmanaxid) | **GET** /webhooks/almanax/{id} | Get Almanax Hook
*WebhooksApi* | [**GetWebhooksRssId**](docs/WebhooksApi.md#getwebhooksrssid) | **GET** /webhooks/rss/{id} | Get RSS Hook
*WebhooksApi* | [**GetWebhooksTwitterId**](docs/WebhooksApi.md#getwebhookstwitterid) | **GET** /webhooks/twitter/{id} | Get Twitter Hook
*WebhooksApi* | [**PostWebhooksAlmanax**](docs/WebhooksApi.md#postwebhooksalmanax) | **POST** /webhooks/almanax | Register Almanax Hook
*WebhooksApi* | [**PostWebhooksRss**](docs/WebhooksApi.md#postwebhooksrss) | **POST** /webhooks/rss | Register RSS Hook
*WebhooksApi* | [**PostWebhooksTwitter**](docs/WebhooksApi.md#postwebhookstwitter) | **POST** /webhooks/twitter | Register Twitter Hook
*WebhooksApi* | [**PutWebhooksAlmanaxId**](docs/WebhooksApi.md#putwebhooksalmanaxid) | **PUT** /webhooks/almanax/{id} | Update Almanax Hook
*WebhooksApi* | [**PutWebhooksRssId**](docs/WebhooksApi.md#putwebhooksrssid) | **PUT** /webhooks/rss/{id} | Update RSS Hook
*WebhooksApi* | [**PutWebhooksTwitterId**](docs/WebhooksApi.md#putwebhookstwitterid) | **PUT** /webhooks/twitter/{id} | Update Twitter Hook


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AlmanaxEntry](docs/AlmanaxEntry.md)
 - [Model.AlmanaxEntryBonus](docs/AlmanaxEntryBonus.md)
 - [Model.AlmanaxEntryTribute](docs/AlmanaxEntryTribute.md)
 - [Model.AlmanaxEntryTributeItem](docs/AlmanaxEntryTributeItem.md)
 - [Model.AlmanaxWebhook](docs/AlmanaxWebhook.md)
 - [Model.AlmanaxWebhookDailySettings](docs/AlmanaxWebhookDailySettings.md)
 - [Model.ConditionEntry](docs/ConditionEntry.md)
 - [Model.ConditionTreeLeaf](docs/ConditionTreeLeaf.md)
 - [Model.ConditionTreeNode](docs/ConditionTreeNode.md)
 - [Model.ConditionTreeRelation](docs/ConditionTreeRelation.md)
 - [Model.CreateAlmanaxWebhook](docs/CreateAlmanaxWebhook.md)
 - [Model.CreateAlmanaxWebhookDailySettings](docs/CreateAlmanaxWebhookDailySettings.md)
 - [Model.CreateAlmanaxWebhookMentionsValueInner](docs/CreateAlmanaxWebhookMentionsValueInner.md)
 - [Model.CreateRSSWebhook](docs/CreateRSSWebhook.md)
 - [Model.CreateTwitterWebhook](docs/CreateTwitterWebhook.md)
 - [Model.EffectsEntry](docs/EffectsEntry.md)
 - [Model.Equipment](docs/Equipment.md)
 - [Model.EquipmentSet](docs/EquipmentSet.md)
 - [Model.GetGameSearch200ResponseInner](docs/GetGameSearch200ResponseInner.md)
 - [Model.GetMetaAlmanaxBonuses200ResponseInner](docs/GetMetaAlmanaxBonuses200ResponseInner.md)
 - [Model.GetMetaVersion200Response](docs/GetMetaVersion200Response.md)
 - [Model.GetMetaWebhooksTwitter200Response](docs/GetMetaWebhooksTwitter200Response.md)
 - [Model.ImageUrls](docs/ImageUrls.md)
 - [Model.ItemListEntry](docs/ItemListEntry.md)
 - [Model.ItemListEntryParentSet](docs/ItemListEntryParentSet.md)
 - [Model.ItemListEntryRange](docs/ItemListEntryRange.md)
 - [Model.ItemsListEntryTyped](docs/ItemsListEntryTyped.md)
 - [Model.ItemsListEntryTypedType](docs/ItemsListEntryTypedType.md)
 - [Model.ItemsListPaged](docs/ItemsListPaged.md)
 - [Model.LinksPaged](docs/LinksPaged.md)
 - [Model.Mount](docs/Mount.md)
 - [Model.MountListEntry](docs/MountListEntry.md)
 - [Model.MountsListPaged](docs/MountsListPaged.md)
 - [Model.PutAlmanaxWebhook](docs/PutAlmanaxWebhook.md)
 - [Model.PutRSSWebhook](docs/PutRSSWebhook.md)
 - [Model.PutTwitterWebhook](docs/PutTwitterWebhook.md)
 - [Model.RecipeEntry](docs/RecipeEntry.md)
 - [Model.Resource](docs/Resource.md)
 - [Model.ResourceType](docs/ResourceType.md)
 - [Model.RssWebhook](docs/RssWebhook.md)
 - [Model.SetEffectsEntry](docs/SetEffectsEntry.md)
 - [Model.SetEffectsEntryType](docs/SetEffectsEntryType.md)
 - [Model.SetListEntry](docs/SetListEntry.md)
 - [Model.SetsListPaged](docs/SetsListPaged.md)
 - [Model.TwitterWebhook](docs/TwitterWebhook.md)
 - [Model.Weapon](docs/Weapon.md)
 - [Model.WeaponRange](docs/WeaponRange.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

