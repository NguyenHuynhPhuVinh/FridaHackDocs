class <Module>
{
}

struct NimbleBridge_GroupsGroupRoleArray
{
    /*0x10*/ int size;
    /*0x18*/ nint roles;
}

struct NimbleBridge_GroupsGroupDetails
{
    /*0x10*/ long creator;
    /*0x18*/ long dateCreated;
    /*0x20*/ long size;
    /*0x28*/ long maxSize;
    /*0x30*/ long lastAccessDate;
    /*0x38*/ string groupTypeId;
    /*0x40*/ System.Collections.Generic.Dictionary<string, string> attributes;
    /*0x48*/ NimbleBridge_GroupsGroupRole[] roles;
    /*0x50*/ bool hasOverridenJoinOptions;
    /*0x51*/ bool isFreeJoin;
    /*0x52*/ bool canInviteToJoin;
    /*0x53*/ bool isPasswordProtected;
    /*0x54*/ bool canUserRequestMembership;
    /*0x58*/ string shortName;
    /*0x60*/ string inviteURLKey;
    /*0x68*/ int totalSearchFriendsCount;
    /*0x70*/ string[] searchFriendsList;
    /*0x78*/ SimpleJSON.JSONNode computedGroupRules;
    /*0x80*/ bool isComputed;
    /*0x88*/ string[] linkedComputedGroups;
    /*0x90*/ long newMaxSize;
}

struct NimbleBridge_GroupsGroupDetailsImpl
{
    /*0x10*/ long creator;
    /*0x18*/ long dateCreated;
    /*0x20*/ long size;
    /*0x28*/ long maxSize;
    /*0x30*/ long lastAccessDate;
    /*0x38*/ string groupTypeId;
    /*0x40*/ NimbleBridge_Map attributes;
    /*0x58*/ NimbleBridge_GroupsGroupRoleArray rolesArray;
    /*0x68*/ bool hasOverriddenJoinOptions;
    /*0x69*/ bool isFreeJoin;
    /*0x6a*/ bool canInviteToJoin;
    /*0x6b*/ bool isPasswordProtected;
    /*0x6c*/ bool canUserRequestMembership;
    /*0x70*/ string shortName;
    /*0x78*/ string inviteURLKey;
    /*0x80*/ int totalSearchFriendsCount;
    /*0x88*/ nint searchFriendsList;
    /*0x90*/ nint computedGroupRules;
    /*0x98*/ bool isComputed;
    /*0xa0*/ nint linkedComputedGroups;
    /*0xa8*/ long newMaxSize;

    /*0x2bc1cf4*/ NimbleBridge_GroupsGroupDetails ToGroupDetails(MarshalUtility.MarshalType marshalType);
}

class NimbleBridge_GroupsDetailedGroup : NimbleBridge_GroupsGroup
{
    static /*0x2bc209c*/ NimbleBridge_GroupsGroupDetailsImpl NimbleBridge_DetailedGroup_getDetails(NimbleBridge_GroupsDetailedGroup wrapper);
    /*0x2bc21a0*/ NimbleBridge_GroupsDetailedGroup(nint handle);
    /*0x2bc2200*/ NimbleBridge_GroupsGroupDetails GetDetails();
}

class GenericCallback : System.MulticastDelegate
{
    /*0x2bc2258*/ GenericCallback(object object, nint method);
    /*0x2bc2360*/ void Invoke(NimbleBridge_Error error);
}

class GroupDetailsCallback : System.MulticastDelegate
{
    /*0x2bc2374*/ GroupDetailsCallback(object object, nint method);
    /*0x2bc2480*/ void Invoke(NimbleBridge_GroupsDetailedGroup group, NimbleBridge_Error error);
}

class GroupUserCallback : System.MulticastDelegate
{
    /*0x2bc2494*/ GroupUserCallback(object object, nint method);
    /*0x2bc25a0*/ void Invoke(NimbleBridge_GroupsGroup group, string userId, NimbleBridge_Error error);
}

class GroupUserListCallback : System.MulticastDelegate
{
    /*0x2bc25b4*/ GroupUserListCallback(object object, nint method);
    /*0x2bc26c0*/ void Invoke(NimbleBridge_GroupsGroup group, int startIndex, int count, NimbleBridge_GroupsGroupUser[] users, NimbleBridge_Error error);
}

class GroupDetailsUserListCallback : System.MulticastDelegate
{
    /*0x2bc26d4*/ GroupDetailsUserListCallback(object object, nint method);
    /*0x2bc27e0*/ void Invoke(NimbleBridge_GroupsDetailedGroup group, int startIndex, int count, NimbleBridge_GroupsGroupUser[] users, NimbleBridge_Error error);
}

class NimbleBridge_GroupsGroup : System.Runtime.InteropServices.SafeHandle
{
    static /*0x2bc32bc*/ NimbleBridge_GroupsGroupUser unmanagedUserToManagedUser(UnmanagedGroupsGroupUser cintUser);
    static /*0x2bc27f4*/ void OnGenericCallback(nint errorPtr, nint callbackDataPtr);
    static /*0x2bc2968*/ void OnGroupDetailsCallback(nint groupPtr, nint errorPtr, nint callbackDataPtr);
    static /*0x2bc2b2c*/ void OnGroupUserCallback(nint groupPtr, string userId, nint errorPtr, nint callbackDataPtr);
    static /*0x2bc2d04*/ void OnGroupUserListCallback(nint groupPtr, int startIndex, int count, UnmanagedGroupsGroupUserArray userArray, nint errorPtr, nint callbackDataPtr);
    static /*0x2bc2fe0*/ void OnGroupDetailsUserListCallback(nint groupPtr, int startIndex, int count, UnmanagedGroupsGroupUserArray userArray, nint errorPtr, nint callbackDataPtr);
    static /*0x2bc33cc*/ void NimbleBridge_GroupsGroup_Dispose(nint wrapper);
    static /*0x2bc3448*/ string NimbleBridge_Group_getGroupId(NimbleBridge_GroupsGroup wrapper);
    static /*0x2bc351c*/ string NimbleBridge_Group_getGroupName(NimbleBridge_GroupsGroup wrapper);
    static /*0x2bc35f0*/ string NimbleBridge_Group_getRole(NimbleBridge_GroupsGroup wrapper);
    static /*0x2bc36c4*/ void NimbleBridge_Group_fetchDetails(NimbleBridge_GroupsGroup wrapper, NimbleBridge_GroupsGroup.BridgeGroupDetailsCallback callback, nint callbackData);
    static /*0x2bc37a4*/ void NimbleBridge_Group_fetchMembersWithDetails(NimbleBridge_GroupsGroup wrapper, int startIndex, int count, NimbleBridge_GroupsGroup.BridgeGroupUserListCallback callback, nint callbackData);
    static /*0x2bc389c*/ void NimbleBridge_Group_removeUser(NimbleBridge_GroupsGroup wrapper, string userId, NimbleBridge_GroupsGroup.BridgeGroupUserCallback callback, nint callbackData);
    static /*0x2bc39a0*/ void NimbleBridge_Group_fetchJoinRequests(NimbleBridge_GroupsGroup wrapper, int startIndex, int count, NimbleBridge_GroupsGroup.BridgeGroupUserListCallback callback, nint callbackData);
    static /*0x2bc3a98*/ void NimbleBridge_Group_approveJoinRequest(NimbleBridge_GroupsGroup wrapper, string userId, NimbleBridge_GroupsGroup.BridgeGroupUserCallback callback, nint callbackData);
    static /*0x2bc3b9c*/ void NimbleBridge_Group_denyJoinRequest(NimbleBridge_GroupsGroup wrapper, string userId, NimbleBridge_GroupsGroup.BridgeGroupUserCallback callback, nint callbackData);
    static /*0x2bc3ca0*/ void NimbleBridge_Group_updateUserRole(NimbleBridge_GroupsGroup Wrapper, string userId, string role, bool allowDemotion, NimbleBridge_GroupsGroup.BridgeGenericCallback callback, nint callbackData);
    /*0x2bc21d0*/ NimbleBridge_GroupsGroup(nint handle);
    /*0x2bc3dd0*/ bool get_IsInvalid();
    /*0x2bc3de0*/ bool ReleaseHandle();
    /*0x2bc3df8*/ string GetGroupId();
    /*0x2bc3dfc*/ string GetGroupName();
    /*0x2bc3e00*/ string GetRole();
    /*0x2bc3e04*/ void FetchDetails(GroupDetailsCallback callback);
    /*0x2bc3f4c*/ void FetchMembersWithDetails(int startIndex, int count, GroupDetailsUserListCallback callback);
    /*0x2bc40ac*/ void RemoveUser(string userId, GroupUserCallback callback);
    /*0x2bc41fc*/ void FetchJoinRequests(int startIndex, int count, GroupUserListCallback callback);
    /*0x2bc42bc*/ void ApproveJoinRequest(string userId, GroupUserCallback callback);
    /*0x2bc436c*/ void DenyJoinRequest(string userId, GroupUserCallback callback);
    /*0x2bc441c*/ void UpdateUserRole(string userId, string role, bool allowDemotion, GenericCallback callback);

    class BridgeGenericCallback : System.MulticastDelegate
    {
        /*0x2bc44e4*/ BridgeGenericCallback(object object, nint method);
        /*0x2bc4584*/ void Invoke(nint errorPtr, nint callbackDataPtr);
    }

    class BridgeGroupDetailsCallback : System.MulticastDelegate
    {
        /*0x2bc3eac*/ BridgeGroupDetailsCallback(object object, nint method);
        /*0x2bc4598*/ void Invoke(nint groupPtr, nint errorPtr, nint callbackDataPtr);
    }

    class BridgeGroupUserCallback : System.MulticastDelegate
    {
        /*0x2bc415c*/ BridgeGroupUserCallback(object object, nint method);
        /*0x2bc45ac*/ void Invoke(nint groupPtr, string userId, nint errorPtr, nint callbackDataPtr);
    }

    class BridgeGroupUserListCallback : System.MulticastDelegate
    {
        /*0x2bc400c*/ BridgeGroupUserListCallback(object object, nint method);
        /*0x2bc45c0*/ void Invoke(nint groupPtr, int startIndex, int count, UnmanagedGroupsGroupUserArray users, nint errorPtr, nint callbackDataPtr);
    }

    class <>c__DisplayClass10_0
    {
        /*0x10*/ GenericCallback callback;
        /*0x18*/ NimbleBridge_Error error;

        /*0x2bc33a4*/ <>c__DisplayClass10_0();
        /*0x2bc45d8*/ void <OnGenericCallback>b__0();
    }

    class <>c__DisplayClass11_0
    {
        /*0x10*/ GroupDetailsCallback callback;
        /*0x18*/ NimbleBridge_GroupsDetailedGroup group;
        /*0x20*/ NimbleBridge_Error error;

        /*0x2bc33ac*/ <>c__DisplayClass11_0();
        /*0x2bc45fc*/ void <OnGroupDetailsCallback>b__0();
    }

    class <>c__DisplayClass13_0
    {
        /*0x10*/ GroupUserCallback callback;
        /*0x18*/ NimbleBridge_GroupsGroup group;
        /*0x20*/ string userId;
        /*0x28*/ NimbleBridge_Error error;

        /*0x2bc33b4*/ <>c__DisplayClass13_0();
        /*0x2bc4624*/ void <OnGroupUserCallback>b__0();
    }

    class <>c__DisplayClass16_0
    {
        /*0x10*/ GroupUserListCallback callback;
        /*0x18*/ NimbleBridge_GroupsGroup group;
        /*0x20*/ int startIndex;
        /*0x24*/ int count;
        /*0x28*/ NimbleBridge_GroupsGroupUser[] users;
        /*0x30*/ NimbleBridge_Error error;

        /*0x2bc33bc*/ <>c__DisplayClass16_0();
        /*0x2bc4650*/ void <OnGroupUserListCallback>b__0();
    }

    class <>c__DisplayClass17_0
    {
        /*0x10*/ GroupDetailsUserListCallback callback;
        /*0x18*/ NimbleBridge_GroupsDetailedGroup group;
        /*0x20*/ int startIndex;
        /*0x24*/ int count;
        /*0x28*/ NimbleBridge_GroupsGroupUser[] users;
        /*0x30*/ NimbleBridge_Error error;

        /*0x2bc33c4*/ <>c__DisplayClass17_0();
        /*0x2bc4680*/ void <OnGroupDetailsUserListCallback>b__0();
    }
}

struct NimbleBridge_GroupJoinOptions
{
    /*0x10*/ bool isFreeJoin;
    /*0x11*/ bool canInviteToJoin;
    /*0x12*/ bool isPasswordProtected;
    /*0x13*/ bool canUserRequestMembership;
}

struct NimbleBridge_GroupRecommendationsRequest
{
    /*0x10*/ string groupTypeId;
    /*0x18*/ string mode;
    /*0x20*/ string orderBy;
    /*0x28*/ string orderDir;
    /*0x30*/ string recommendationModel;
    /*0x38*/ SimpleJSON.JSONNode attributes;
    /*0x40*/ float minScore;
}

struct NimbleBridge_NativeGroupRecommendationsRequest
{
    /*0x10*/ string groupTypeId;
    /*0x18*/ string mode;
    /*0x20*/ string orderBy;
    /*0x28*/ string orderDir;
    /*0x30*/ string recommendationModel;
    /*0x38*/ string attributes;
    /*0x40*/ float minScore;
}

struct NimbleBridge_GroupsGroupRole
{
    /*0x10*/ string maxICanBan;
    /*0x18*/ string maxICanKick;
    /*0x20*/ string maxICanPromote;
    /*0x28*/ string maxICanDemote;
    /*0x30*/ string name;
    /*0x38*/ string[] activities;
    /*0x40*/ bool obsoleted;
}

struct NimbleBridge_GroupsGroupRoleImpl
{
    /*0x10*/ string maxICanBan;
    /*0x18*/ string maxICanKick;
    /*0x20*/ string maxICanPromote;
    /*0x28*/ string maxICanDemote;
    /*0x30*/ string name;
    /*0x38*/ nint activities;
    /*0x40*/ bool obsoleted;

    /*0x2bc1fc8*/ NimbleBridge_GroupsGroupRole ToRole(MarshalUtility.MarshalType marshalType);
}

class NimbleBridge_GroupSearchRequest
{
    /*0x10*/ NimbleBridge_GroupSearchRequest.SearchMode mode;
    /*0x14*/ NimbleBridge_GroupSearchRequest.SearchCondition searchCondition;
    /*0x18*/ string typeId;
    /*0x20*/ string partialName;
    /*0x28*/ bool excludeFull;
    /*0x29*/ bool includeReasons;
    /*0x30*/ string sortByAttributeName;
    /*0x38*/ bool sortAscending;
    /*0x40*/ NimbleBridge_GroupSearchRequest.AttributeFilters attributeFilters;
    /*0x48*/ bool hasMinMemberCount;
    /*0x4c*/ uint minMemberCount;
    /*0x50*/ bool hasMaxMemberCount;
    /*0x54*/ uint maxMemberCount;

    /*0x2bc46b0*/ NimbleBridge_GroupSearchRequest();

    enum SearchMode
    {
        SHOW_ALL = 0,
        FREE_TO_JOIN_ONLY = 1,
        INTERACTABLE = 2,
    }

    enum SearchCondition
    {
        AND = 0,
        OR = 1,
    }

    class AttributeFilters
    {
        /*0x10*/ System.Collections.Generic.List<string> queryParamValues;

        /*0x2bc4718*/ AttributeFilters();
        /*0x2bc47a0*/ bool AddFilter(string attributeName, string value);
        /*0x2bc488c*/ System.Collections.Generic.List<string> get_QueryParamValues();
    }
}

class GroupListCallback : System.MulticastDelegate
{
    /*0x2bc4894*/ GroupListCallback(object object, nint method);
    /*0x2bc4934*/ void Invoke(int startIndex, int count, NimbleBridge_GroupsGroup[] groups, NimbleBridge_Error error);
}

class DetailedGroupListCallback : System.MulticastDelegate
{
    /*0x2bc4948*/ DetailedGroupListCallback(object object, nint method);
    /*0x2bc49e8*/ void Invoke(int startIndex, int count, NimbleBridge_GroupsDetailedGroup[] groups, NimbleBridge_Error error);
}

class GroupRecommendationsCallback : System.MulticastDelegate
{
    /*0x2bc49fc*/ GroupRecommendationsCallback(object object, nint method);
    /*0x2bc4b08*/ void Invoke(SimpleJSON.JSONNode data, NimbleBridge_Error error);
}

class NimbleBridge_GroupService
{
    static /*0x2bc4b1c*/ void OnGroupListCallback(int startIndex, int count, nint groupsArray, nint errorPtr, nint callbackDataPtr);
    static /*0x2bc4d94*/ void OnDetailedGroupListCallback(int startIndex, int count, nint groupsArray, nint errorPtr, nint callbackDataPtr);
    static /*0x2bc500c*/ void OnGroupRecommendationsCallback(string data, nint errorPtr, nint callbackDataPtr);
    static /*0x2bc51c0*/ void NimbleBridge_GroupService_fetchUserGroups(nint typeIds, int startIndex, int count, NimbleBridge_GroupService.BridgeGroupListCallback callback, nint callbackData);
    static /*0x2bc5274*/ void NimbleBridge_GroupService_searchGroup(NimbleBridge_GroupService.NativeGroupSearchRequest searchRequest, int startIndex, int count, NimbleBridge_GroupService.BridgeDetailedGroupListCallback callback, nint callbackData);
    static /*0x2bc5374*/ void NimbleBridge_GroupService_fetchGroupRecommendations(NimbleBridge_NativeGroupRecommendationsRequest request, NimbleBridge_GroupService.BridgeGroupRecommendationsCallback callback, nint callbackData);
    static /*0x2bc5454*/ NimbleBridge_GroupService GetComponent();
    /*0x2bc544c*/ NimbleBridge_GroupService();
    /*0x2bc54a8*/ void FetchUserGroups(string typeId, int startIndex, int count, GroupListCallback callback);
    /*0x2bc5548*/ void FetchUserGroups(string[] typeIds, int startIndex, int count, GroupListCallback callback);
    /*0x2bc56b8*/ void SearchGroup(NimbleBridge_GroupSearchRequest request, int startIndex, int count, DetailedGroupListCallback callback);
    /*0x2bc58c8*/ void FetchGroupRecommendations(NimbleBridge_GroupRecommendationsRequest request, GroupRecommendationsCallback callback);

    class BridgeGroupListCallback : System.MulticastDelegate
    {
        /*0x2bc5618*/ BridgeGroupListCallback(object object, nint method);
        /*0x2bc5ad4*/ void Invoke(int startIndex, int count, nint groupsArray, nint errorPtr, nint callbackDataPtr);
    }

    class BridgeDetailedGroupListCallback : System.MulticastDelegate
    {
        /*0x2bc5828*/ BridgeDetailedGroupListCallback(object object, nint method);
        /*0x2bc5ae8*/ void Invoke(int startIndex, int count, nint groupsArray, nint errorPtr, nint callbackDataPtr);
    }

    class BridgeGroupRecommendationsCallback : System.MulticastDelegate
    {
        /*0x2bc5a20*/ BridgeGroupRecommendationsCallback(object object, nint method);
        /*0x2bc5afc*/ void Invoke(string data, nint errorPtr, nint callbackDataPtr);
    }

    struct NativeGroupSearchRequest
    {
        /*0x10*/ int mode;
        /*0x14*/ int searchCondition;
        /*0x18*/ string typeId;
        /*0x20*/ string name;
        /*0x28*/ bool includeReasons;
        /*0x29*/ bool excludeFull;
        /*0x30*/ string sortByAttributeName;
        /*0x38*/ bool sortAscending;
        /*0x40*/ nint attributeFilters;
        /*0x48*/ bool hasMinMemberCount;
        /*0x4c*/ uint minMemberCount;
        /*0x50*/ bool hasMaxMemberCount;
        /*0x54*/ uint maxMemberCount;
    }

    class <>c
    {
        static /*0x0*/ NimbleBridge_GroupService.<> <>9;
        static /*0x8*/ System.Func<nint, NimbleBridge_GroupsGroup> <>9__8_0;
        static /*0x10*/ System.Func<nint, NimbleBridge_GroupsDetailedGroup> <>9__9_0;

        static /*0x2bc5b10*/ <>c();
        /*0x2bc5b78*/ <>c();
        /*0x2bc5b80*/ NimbleBridge_GroupsGroup <OnGroupListCallback>b__8_0(nint groupPtr);
        /*0x2bc5be4*/ NimbleBridge_GroupsDetailedGroup <OnDetailedGroupListCallback>b__9_0(nint groupPtr);
    }

    class <>c__DisplayClass13_0
    {
        /*0x10*/ GroupRecommendationsCallback callback;
        /*0x18*/ SimpleJSON.JSONNode jsonData;
        /*0x20*/ NimbleBridge_Error error;

        /*0x2bc51b8*/ <>c__DisplayClass13_0();
        /*0x2bc5c48*/ void <OnGroupRecommendationsCallback>b__0();
    }

    class <>c__DisplayClass8_0
    {
        /*0x10*/ GroupListCallback callback;
        /*0x18*/ int startIndex;
        /*0x1c*/ int count;
        /*0x20*/ NimbleBridge_GroupsGroup[] groups;
        /*0x28*/ NimbleBridge_Error error;

        /*0x2bc51a8*/ <>c__DisplayClass8_0();
        /*0x2bc5c70*/ void <OnGroupListCallback>b__1();
    }

    class <>c__DisplayClass9_0
    {
        /*0x10*/ DetailedGroupListCallback callback;
        /*0x18*/ int startIndex;
        /*0x1c*/ int count;
        /*0x20*/ NimbleBridge_GroupsDetailedGroup[] groups;
        /*0x28*/ NimbleBridge_Error error;

        /*0x2bc51b0*/ <>c__DisplayClass9_0();
        /*0x2bc5c9c*/ void <OnDetailedGroupListCallback>b__1();
    }
}

struct NimbleBridge_GroupsGroupUser : System.IEquatable<NimbleBridge_GroupsGroupUser>
{
    /*0x10*/ string userId;
    /*0x18*/ string invitedBy;
    /*0x20*/ string nucleusId;
    /*0x28*/ long timestamp;
    /*0x30*/ string role;
    /*0x38*/ SimpleJSON.JSONNode memberAttributes;

    /*0x2bc5cc8*/ bool Equals(NimbleBridge_GroupsGroupUser other);
}

struct UnmanagedGroupsGroupUser
{
    /*0x10*/ string userId;
    /*0x18*/ string invitedBy;
    /*0x20*/ string nucleusId;
    /*0x28*/ long timestamp;
    /*0x30*/ string role;
    /*0x38*/ nint memberAttributes;
}

struct UnmanagedGroupsGroupUserArray
{
    /*0x10*/ int size;
    /*0x18*/ nint users;
}

class NimbleBridge_MessagingChannel
{
}
