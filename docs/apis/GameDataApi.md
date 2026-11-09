# Dofusdude.Api.Api.GameDataApi

All URIs are relative to *https://beta.api.dofusdu.de*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllAreas**](GameDataApi.md#getallareas) | **GET** /{game}/v1/{language}/areas/all | Get all areas |
| [**GetAllClasses**](GameDataApi.md#getallclasses) | **GET** /{game}/v1/{language}/classes/all | Get all classes |
| [**GetAllMonsters**](GameDataApi.md#getallmonsters) | **GET** /{game}/v1/{language}/monsters/all | Get all monsters |
| [**GetAllSpells**](GameDataApi.md#getallspells) | **GET** /{game}/v1/{language}/spells/all | Get all spells |
| [**GetAllSubareas**](GameDataApi.md#getallsubareas) | **GET** /{game}/v1/{language}/subareas/all | Get all subareas |
| [**GetAllSuperAreas**](GameDataApi.md#getallsuperareas) | **GET** /{game}/v1/{language}/super-areas/all | Get all super-areas |
| [**GetAreaById**](GameDataApi.md#getareabyid) | **GET** /{game}/v1/{language}/areas/{ankama_id} | Get one area |
| [**GetAreas**](GameDataApi.md#getareas) | **GET** /{game}/v1/{language}/areas | List areas |
| [**GetClassById**](GameDataApi.md#getclassbyid) | **GET** /{game}/v1/{language}/classes/{ankama_id} | Get one class |
| [**GetClasses**](GameDataApi.md#getclasses) | **GET** /{game}/v1/{language}/classes | List classes |
| [**GetMonsterById**](GameDataApi.md#getmonsterbyid) | **GET** /{game}/v1/{language}/monsters/{ankama_id} | Get one monster |
| [**GetMonsters**](GameDataApi.md#getmonsters) | **GET** /{game}/v1/{language}/monsters | List monsters |
| [**GetSpellById**](GameDataApi.md#getspellbyid) | **GET** /{game}/v1/{language}/spells/{ankama_id} | Get one spell |
| [**GetSpells**](GameDataApi.md#getspells) | **GET** /{game}/v1/{language}/spells | List spells |
| [**GetSubareaById**](GameDataApi.md#getsubareabyid) | **GET** /{game}/v1/{language}/subareas/{ankama_id} | Get one subarea |
| [**GetSubareas**](GameDataApi.md#getsubareas) | **GET** /{game}/v1/{language}/subareas | List subareas |
| [**GetSuperAreaById**](GameDataApi.md#getsuperareabyid) | **GET** /{game}/v1/{language}/super-areas/{ankama_id} | Get one super-area |
| [**GetSuperAreas**](GameDataApi.md#getsuperareas) | **GET** /{game}/v1/{language}/super-areas | List super-areas |
| [**SearchAreas**](GameDataApi.md#searchareas) | **GET** /{game}/v1/{language}/areas/search | Search areas |
| [**SearchClasses**](GameDataApi.md#searchclasses) | **GET** /{game}/v1/{language}/classes/search | Search classes |
| [**SearchMonsters**](GameDataApi.md#searchmonsters) | **GET** /{game}/v1/{language}/monsters/search | Search monsters |
| [**SearchSpells**](GameDataApi.md#searchspells) | **GET** /{game}/v1/{language}/spells/search | Search spells |
| [**SearchSubareas**](GameDataApi.md#searchsubareas) | **GET** /{game}/v1/{language}/subareas/search | Search subareas |
| [**SearchSuperAreas**](GameDataApi.md#searchsuperareas) | **GET** /{game}/v1/{language}/super-areas/search | Search super-areas |

<a id="getallareas"></a>
# **GetAllAreas**
> MappedEntityCollection GetAllAreas (string game, string language)

Get all areas

Returns every complete geographic area record, including its super-area reference and child subareas, without pagination. These relationships describe geography rather than combat effect zones.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized area document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallclasses"></a>
# **GetAllClasses**
> MappedEntityCollection GetAllClasses (string game, string language)

Get all classes

Returns full playable-class definitions without pagination, including their assigned spells and each spell's available grades. Classes do not have monster grades. For smaller responses use the paginated classes endpoint or request one class by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized class document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallmonsters"></a>
# **GetAllMonsters**
> MappedEntityCollection GetAllMonsters (string game, string language, string include = null)

Get all monsters

Returns complete monster definitions without pagination. Grades group each variant's statistics and spell assignments. Drop percentages are indexed by monster grade. Known spawn subareas are not live population or per-map spawn probabilities. Spell expansion is optional. This bulk response can be large, so prefer pagination when possible.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **include** | **string** | Optional spell expansion for monster responses. Leave include unset to return spell URLs. Use &#x60;spells.grade&#x60; to embed the assigned spell grade. Use &#x60;spells&#x60; to embed every available grade of each assigned spell. | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized monster document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallspells"></a>
# **GetAllSpells**
> MappedEntityCollection GetAllSpells (string game, string language)

Get all spells

Returns complete spell definitions and all available grades without pagination. Each grade has its own costs, casting rules, normal effects and critical effects. Bulk responses can be large. Prefer pagination for interactive or incremental use.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized spell document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallsubareas"></a>
# **GetAllSubareas**
> MappedEntityCollection GetAllSubareas (string game, string language)

Get all subareas

Returns complete subareas, map membership and monster references without pagination. Maps belong to the subarea but are not guaranteed spawn locations for every associated monster. Prefer pagination for smaller responses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized subarea document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallsuperareas"></a>
# **GetAllSuperAreas**
> MappedEntityCollection GetAllSuperAreas (string game, string language)

Get all super-areas

Returns every complete super-area record and its child area references without pagination. A super-area groups geographic areas and supplies a world-map context. It is not a spell effect zone.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Every complete localized super-area document. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getareabyid"></a>
# **GetAreaById**
> WorldArea GetAreaById (string game, string language, int ankamaId)

Get one area

Returns an area's parent super-area and child subarea references. References contain an ID and localized name, not a complete nested record. Use the corresponding resource endpoint to load details. Matching numeric IDs in different resource types do not establish a relationship.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**WorldArea**](WorldArea.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized area document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getareas"></a>
# **GetAreas**
> MappedEntityCollection GetAreas (string game, string language, int pageNumber = null, int pageSize = null, string fieldsAreas = null)

List areas

Lists geographic area summaries. An area belongs to a super-area and groups subareas. Request fields[areas]=all or an area detail record for those relationships. Use QUERY rather than GET for structured JSON filtering and sorting.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsAreas** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated areas. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclassbyid"></a>
# **GetClassById**
> Class GetClassById (string game, string language, int ankamaId)

Get one class

Returns a playable class, also called a breed in the client data. Its spells array contains full spell definitions. Each spell has its own levels array of spell grades. The class itself does not have grades, and a spell grade is not a character level.  Characteristic cost tiers describe point costs. Appearance bone and skin IDs are asset-renderer inputs, not image URLs. Use image_urls for ready-to-display artwork. IDs identify records independently of their translated names. Assigned spells can also be requested from the spells endpoint without loading the class again.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**Class**](Class.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized class document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclasses"></a>
# **GetClasses**
> MappedEntityCollection GetClasses (string game, string language, int pageNumber = null, int pageSize = null, string fieldsClasses = null)

List classes

Lists playable classes, also called breeds in the client data. Results are compact summaries by default. Request fields[classes]=all for class characteristics, appearance and full assigned spell definitions. Spell grades belong to each spell, not to the class. Use the detail endpoint for one full class. Existing GET pagination and field parameters remain unchanged. Use QUERY for structured JSON filtering.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsClasses** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated classes. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmonsterbyid"></a>
# **GetMonsterById**
> Monster GetMonsterById (string game, string language, int ankamaId, string include = null)

Get one monster

Returns a monster definition. race is its family and race.super_race is the broader monster grouping. Neither is a playable class. Each entry in grades is one monster variant with a grade number, a separate combat level, statistics and assigned spells. Select by explicit grade values, not array positions or a fixed assumed grade count.  Spell assignments belong to the enclosing monster grade. Their grade values identify spell variants and need not equal the monster grade. Default assignments contain URLs that already select the assigned spell grade. Follow them unchanged. include=spells.grade embeds just the assigned variant in each spell's levels array. include=spells embeds every available spell grade instead. These are optional expansions of an independently addressable resource.  Match drops[].rates_percent[].grade to the monster grade, not the spell grade. Percentages are base drop rates before player-specific modifiers. global_drops provides ranges instead of that grade-rate table. Client condition trees preserve and/or grouping but exclude server-only predicates. A missing tree does not guarantee eligibility, even when has_conditions is true.  spawn_locations identifies known spawn subareas and their geographic parents. subarea_maps lists subarea membership, not guaranteed spawn maps. preferred is a source preference flag, not a probability. The endpoint does not report live presence or per-map spawn percentages.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |
| **include** | **string** | Optional spell expansion for monster responses. Leave include unset to return spell URLs. Use &#x60;spells.grade&#x60; to embed the assigned spell grade. Use &#x60;spells&#x60; to embed every available grade of each assigned spell. | [optional]  |

### Return type

[**Monster**](Monster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized monster document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmonsters"></a>
# **GetMonsters**
> MappedEntityCollection GetMonsters (string game, string language, int pageNumber = null, int pageSize = null, string fieldsMonsters = null, string include = null)

List monsters

Lists monster summaries. Request fields[monsters]=all or the monster detail endpoint for variants, statistics, drop rates and known spawn subareas. A monster grade is a variant with its own combat level, not that level itself. Optional include values expand spell assignments. GET retains its existing pagination, field and include parameters. Use QUERY for structured filtering and sorting.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsMonsters** | **string** |  | [optional]  |
| **include** | **string** | Optional spell expansion for monster responses. Leave include unset to return spell URLs. Use &#x60;spells.grade&#x60; to embed the assigned spell grade. Use &#x60;spells&#x60; to embed every available grade of each assigned spell. | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated monsters. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getspellbyid"></a>
# **GetSpellById**
> Spell GetSpellById (string game, string language, int ankamaId, int grade = null)

Get one spell

Returns a spell and its available grades in levels. A grade is a variant with its own action-point cost, range, casting limits and effects. Select by levels[].grade, not array position. levels[].ankama_id is the separate spell-level record ID. min_player_level records a player-level requirement and is not a grade number.  Pass grade to return only that variant inside the same spell object. An unavailable grade returns 404. For example, /spells/10198?grade=1 selects spell grade 1. This does not imply that monster grade 1 is the only monster variant using it.  Keep normal effects and critical_effects separate. Each effect has its own combat-cell zone, target_mask and triggers. These describe where, who and when it affects. Preview and script zones do not replace effect zones. Use resolved names and descriptions instead of decoding raw tokens. Templated text is localized display text, not a formula to parse. This endpoint supplies definitions, not a full fight simulation or final damage calculation.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |
| **grade** | **int** | Select the spell variant identified by its explicit grade number, not its spell-level record ID or a player level. Returns the spell object with only that grade in levels. An unavailable grade returns 404. | [optional]  |

### Return type

[**Spell**](Spell.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized spell document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getspells"></a>
# **GetSpells**
> MappedEntityCollection GetSpells (string game, string language, int pageNumber = null, int pageSize = null, string fieldsSpells = null)

List spells

Lists independent spell records as compact summaries. Request fields[spells]=all for their grades and effects, or use the spell detail endpoint for one spell. The levels field contains spell variants called grades, not player levels. Existing GET pagination and field parameters remain unchanged. Structured filters and sorting belong to QUERY and do not trim grades from matching spell records.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsSpells** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated spells. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubareabyid"></a>
# **GetSubareaById**
> WorldArea GetSubareaById (string game, string language, int ankamaId)

Get one subarea

Returns one geographic subarea with its parent area and super-area, maps and monster references. Its level is a geographic difficulty indicator, not a monster grade or the combat level of every associated monster.  A map's ankama_id identifies the map. Interpret position_x and position_y with world_map_id because coordinates alone are not globally unique. Map membership does not prove that a monster spawns on every map or is currently present. Monster references can be followed through the monster endpoint for grade-specific statistics, base drop rates and known spawn subareas. This endpoint does not provide spawn percentages.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**WorldArea**](WorldArea.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized subarea document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubareas"></a>
# **GetSubareas**
> MappedEntityCollection GetSubareas (string game, string language, int pageNumber = null, int pageSize = null, string fieldsSubareas = null)

List subareas

Lists subarea summaries. A subarea belongs to an area and super-area and contains maps. Request fields[subareas]=all or a detail record for map membership and monster associations. Associations are not live monster presence or per-map spawn probabilities.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsSubareas** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated subareas. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsuperareabyid"></a>
# **GetSuperAreaById**
> WorldArea GetSuperAreaById (string game, string language, int ankamaId)

Get one super-area

Returns one broad geographic region with its child areas and world_map_id. Follow child area IDs to the areas endpoint to continue toward subareas and maps. World geography is independent of spell and weapon combat-cell geometry.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **ankamaId** | **int** |  |  |

### Return type

[**WorldArea**](WorldArea.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Complete localized super-area document. |  -  |
| **404** | Entity not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsuperareas"></a>
# **GetSuperAreas**
> MappedEntityCollection GetSuperAreas (string game, string language, int pageNumber = null, int pageSize = null, string fieldsSuperAreas = null)

List super-areas

Lists summaries of the broadest geographic regions. The hierarchy is super-area to area to subarea to map. These world areas are unrelated to combat-cell effect zones. Request fields[super_areas]=all or a detail record for child area references and world-map context.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **pageNumber** | **int** |  | [optional] [default to 1] |
| **pageSize** | **int** |  | [optional] [default to 20] |
| **fieldsSuperAreas** | **string** |  | [optional]  |

### Return type

[**MappedEntityCollection**](MappedEntityCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated super-areas. |  -  |
| **400** | Invalid pagination or field selection. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchareas"></a>
# **SearchAreas**
> List&lt;MappedEntityListEntry&gt; SearchAreas (string game, string language, string query, int limit = null)

Search areas

Searches localized geographic area names by relevance and returns compact summaries. Use the detail endpoint to obtain the parent super-area and child subareas.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchclasses"></a>
# **SearchClasses**
> List&lt;MappedEntityListEntry&gt; SearchClasses (string game, string language, string query, int limit = null)

Search classes

Searches localized class names by relevance and returns compact summaries. Search is distinct from structured filtering. Use a returned ankama_id with the class detail endpoint for characteristics, appearance and assigned spell definitions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchmonsters"></a>
# **SearchMonsters**
> List&lt;MappedEntityListEntry&gt; SearchMonsters (string game, string language, string query, int limit = null)

Search monsters

Searches localized monster names by relevance and returns summaries. Each result identifies a monster definition, not one combat-level variant. Use the detail endpoint for grades, taxonomy, drops and known spawn subareas.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchspells"></a>
# **SearchSpells**
> List&lt;MappedEntityListEntry&gt; SearchSpells (string game, string language, string query, int limit = null)

Search spells

Searches localized spell names by relevance and returns compact summaries. The result ID identifies the spell, not a grade. Request the detail endpoint for available grades, or pass grade to that detail endpoint to select one variant.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchsubareas"></a>
# **SearchSubareas**
> List&lt;MappedEntityListEntry&gt; SearchSubareas (string game, string language, string query, int limit = null)

Search subareas

Searches localized subarea names by relevance and returns summaries. Use the detail endpoint for parent areas, map positions and monster associations. Search results do not indicate live monster populations.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchsuperareas"></a>
# **SearchSuperAreas**
> List&lt;MappedEntityListEntry&gt; SearchSuperAreas (string game, string language, string query, int limit = null)

Search super-areas

Searches localized super-area names by relevance. Results are geographic-region summaries. Use a returned ID with the detail endpoint for child areas and world-map context.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **game** | **string** |  |  |
| **language** | **string** |  |  |
| **query** | **string** |  |  |
| **limit** | **int** |  | [optional] [default to 8] |

### Return type

[**List&lt;MappedEntityListEntry&gt;**](MappedEntityListEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matching localized summaries. |  -  |
| **404** | No matching entities. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

