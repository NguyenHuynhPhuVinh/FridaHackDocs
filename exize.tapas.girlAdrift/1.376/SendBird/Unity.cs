class <Module>
{
}

class SafeDictionary<TKey, TValue>
{
    /*0x0*/ object _Padlock;
    /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> _Dictionary;

    SafeDictionary();
    TValue get_Item(TKey key);
    void set_Item(TKey key, TValue value);
    int get_Count();
    System.Collections.Generic.Dictionary.KeyCollection<TKey, TValue> get_Keys();
    System.Collections.Generic.Dictionary.ValueCollection<TKey, TValue> get_Values();
    bool TryGetValue(TKey key, ref TValue value);
    void TryRemove(TKey key, ref TValue value);
    System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GetEnumerator();
    bool ContainsKey(TKey key);
    void Clear();
}

namespace SendBird
{
    class GroupChannelMemberListQuery
    {
        static /*0x0*/ object syncLock;
        static /*0x8*/ string ORDER_MEMBER_NICKNAME_ALPHABETICAL;
        static /*0x10*/ string MEMBER_STATE_ALL;
        static /*0x18*/ string MEMBER_STATE_INVITED_ONLY;
        static /*0x20*/ string MEMBER_STATE_INVITED_BY_FRIEND_ONLY;
        static /*0x28*/ string MEMBER_STATE_INVITED_BY_NON_FRIEND_ONLY;
        static /*0x30*/ string MEMBER_STATE_JOINED_ONLY;
        /*0x10*/ SendBird.GroupChannel mGroupChannel;
        /*0x18*/ string mToken;
        /*0x20*/ int mLimit;
        /*0x24*/ bool mHasNext;
        /*0x25*/ bool mLoading;
        /*0x28*/ string mOrder;
        /*0x30*/ SendBird.GroupChannelMemberListQuery.OperatorFilter mOperatorFilter;
        /*0x34*/ SendBird.GroupChannelMemberListQuery.MutedMemberFilter mMutedMemberFilter;
        /*0x38*/ string mMemberState;
        /*0x40*/ string mNicknameStartsWith;

        static /*0x11094dc*/ GroupChannelMemberListQuery();
        /*0x1108ebc*/ GroupChannelMemberListQuery(SendBird.GroupChannel groupChannel);
        /*0x1108f6c*/ void SetOperatorFilter(SendBird.GroupChannelMemberListQuery.OperatorFilter operatorFilter);
        /*0x1108f74*/ void SetMutedMemberFilter(SendBird.GroupChannelMemberListQuery.MutedMemberFilter mutedMemberFilter);
        /*0x1108f7c*/ void SetMemberStateFilter(SendBird.GroupChannelMemberListQuery.MemberStateFilter memberStateFilter);
        /*0x110906c*/ void SetNicknameStartsWithFilter(string nickname);
        /*0x1109074*/ void SetLimit(int limit);
        /*0x110907c*/ bool HasNext();
        /*0x1109084*/ bool IsLoading();
        /*0x1109100*/ void SetLoading(bool tf);
        /*0x1109180*/ void Next(SendBird.GroupChannelMemberListQuery.GroupChannelMemberListQueryResultHandler handler);

        enum OperatorFilter
        {
            ALL = 0,
            OPERATOR = 1,
            NONOPERATOR = 2,
        }

        enum MutedMemberFilter
        {
            ALL = 0,
            MUTED = 1,
            UNMUTED = 2,
        }

        enum MemberStateFilter
        {
            ALL = 0,
            INVITED = 1,
            INVITED_BY_FRIEND = 2,
            INVITED_BY_NON_FRIEND = 3,
            JOINED = 4,
        }

        class GroupChannelMemberListQueryResultHandler : System.MulticastDelegate
        {
            /*0x110961c*/ GroupChannelMemberListQueryResultHandler(object object, nint method);
            /*0x110974c*/ void Invoke(System.Collections.Generic.List<SendBird.Member> queryResult, SendBird.SendBirdException e);
            /*0x1109760*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.List<SendBird.Member> queryResult, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1109788*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass29_0
        {
            /*0x10*/ SendBird.GroupChannelMemberListQuery.GroupChannelMemberListQueryResultHandler handler;
            /*0x18*/ SendBird.GroupChannelMemberListQuery <>4__this;

            /*0x11094d4*/ <>c__DisplayClass29_0();
            /*0x1109794*/ void <Next>b__0();
            /*0x1109820*/ void <Next>b__1();
            /*0x11098e4*/ void <Next>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass29_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.Member> users;
            /*0x20*/ SendBird.GroupChannelMemberListQuery.<> CS$<>8__locals1;

            /*0x1109c48*/ <>c__DisplayClass29_1();
            /*0x1109e64*/ void <Next>b__3();
            /*0x1109e98*/ void <Next>b__4();
        }
    }

    class Sender : SendBird.User
    {
        /*0x39*/ bool mIsBlockedByMe;

        static /*0x110a020*/ SendBird.Sender toSender(SendBird.User user);
        /*0x1109ecc*/ Sender(SendBird.SBJson.JsonElement el);
        /*0x1109fa4*/ SendBird.SBJson.JsonElement toJson();
        /*0x110a098*/ bool get_IsBlockedByMe();
        /*0x110a0a0*/ string toString();
    }

    class Member : SendBird.User
    {
        /*0x40*/ string value;
        /*0x48*/ SendBird.Member.MemberState mState;
        /*0x4c*/ SendBird.Member.Role role;
        /*0x50*/ bool mIsBlockingMe;
        /*0x51*/ bool mIsBlockedByMe;

        static /*0x110a144*/ SendBird.Member.Role fromValue(string value);
        /*0x1109c50*/ Member(SendBird.SBJson.JsonElement el);
        /*0x110a134*/ void SetRole(string value);
        /*0x110a13c*/ string GetValue();
        /*0x110a2b8*/ SendBird.Member.MemberState get_GetMemberState();
        /*0x110a2c0*/ void SetState(SendBird.Member.MemberState state);
        /*0x110a2c8*/ SendBird.Member.Role GetRole();
        /*0x110a2d0*/ void SetRole(SendBird.Member.Role role);

        enum MemberState
        {
            NONE = 0,
            INVITED = 1,
            JOINED = 2,
        }

        enum Role
        {
            NONE = 0,
            OPERATOR = 1,
        }

        enum MutedState
        {
            UNMUTED = 0,
            MUTED = 1,
        }
    }

    class AdminMessage : SendBird.BaseMessage
    {
        /*0x48*/ string mMessage;
        /*0x50*/ string mData;
        /*0x58*/ string mCustomType;
        /*0x60*/ bool mIsSilent;

        static /*0x110a2d8*/ SendBird.SBJson.JsonElement Build(long msgId, SendBird.BaseChannel channel, string message, string data, string customType, long createdAt);
        /*0x110a4fc*/ AdminMessage(SendBird.SBJson.JsonElement el);
        /*0x110a998*/ string get_Message();
        /*0x110a9a0*/ string get_Data();
        /*0x110a9a8*/ string get_CustomType();
        /*0x110a9b0*/ bool get_Silent();
        /*0x110a9b8*/ SendBird.Sender GetSender();
    }

    class BaseChannel
    {
        static string CHANNEL_TYPE_OPEN = "open";
        static string CHANNEL_TYPE_GROUP = "group";
        /*0x10*/ string mUrl;
        /*0x18*/ string mName;
        /*0x20*/ string mCoverUrl;
        /*0x28*/ long mCreatedAt;
        /*0x30*/ string mData;
        /*0x38*/ string mCustomType;
        /*0x40*/ bool mDirty;

        /*0x110a9c0*/ BaseChannel(SendBird.SBJson.JsonElement el);
        /*0x110a9f4*/ void Update(SendBird.SBJson.JsonElement el);
        /*0x110ac3c*/ string get_Data();
        /*0x110ac44*/ string get_CustomType();
        /*0x110ac4c*/ string get_Url();
        /*0x110ac54*/ long get_CreatedAt();
        /*0x110ac5c*/ string get_Name();
        /*0x110ac64*/ string get_CoverUrl();
        /*0x110ac6c*/ void SetDirty(bool dirty);
        /*0x110ac78*/ bool IsDirty();
        /*0x110ac80*/ bool IsOpenChannel();
        /*0x110acf8*/ bool IsGroupChannel();
        /*0x110ad70*/ SendBird.PreviousMessageListQuery CreatePreviousMessageListQuery();
        /*0x110add4*/ SendBird.MessageListQuery CreateMessageListQuery();
        /*0x110ae38*/ SendBird.FileMessage SendFileMessageWithURL(string fileUrl, string name, string type, int size, string data, SendBird.BaseChannel.SendFileMessageHandler handler);
        /*0x110ae58*/ SendBird.FileMessage SendFileMessageWithURL(string fileUrl, string name, string type, int size, string data, string customType, SendBird.BaseChannel.SendFileMessageHandler handler);
        /*0x110b844*/ SendBird.FileMessage SendFileMessage(SendBird.SBFile file, string name, string type, int size, string data, SendBird.BaseChannel.SendFileMessageHandler handler);
        /*0x110b864*/ SendBird.FileMessage SendFileMessage(SendBird.SBFile file, string name, string type, int size, string data, string customType, SendBird.BaseChannel.SendFileMessageHandler handler);
        /*0x110bbc4*/ SendBird.UserMessage SendUserMessage(string message, SendBird.BaseChannel.SendUserMessageHandler handler);
        /*0x110bee4*/ SendBird.UserMessage SendUserMessage(string message, string data, SendBird.BaseChannel.SendUserMessageHandler handler);
        /*0x110bef4*/ SendBird.UserMessage SendUserMessage(string message, string data, string customType, SendBird.BaseChannel.SendUserMessageHandler handler);
        /*0x110bbd8*/ SendBird.UserMessage SendUserMessage(string message, string data, string customType, System.Collections.Generic.List<string> targetLangs, SendBird.BaseChannel.SendUserMessageHandler handler);
        /*0x110bf08*/ void CreateMetaCounters(System.Collections.Generic.Dictionary<string, int> metaCounterMap, SendBird.BaseChannel.MetaCounterHandler handler);
        /*0x110c10c*/ void UpdateMetaCounters(System.Collections.Generic.Dictionary<string, int> metaCounterMap, SendBird.BaseChannel.MetaCounterHandler handler);
        /*0x110c318*/ void IncreaseMetaCounters(System.Collections.Generic.Dictionary<string, int> metaCounterMap, SendBird.BaseChannel.MetaCounterHandler handler);
        /*0x110c524*/ void DecreaseMetaCounters(System.Collections.Generic.Dictionary<string, int> metaCounterMap, SendBird.BaseChannel.MetaCounterHandler handler);
        /*0x110c730*/ void GetMetaCounters(System.Collections.Generic.List<string> keys, SendBird.BaseChannel.MetaCounterHandler handler);
        /*0x110c934*/ void GetAllMetaCounters(SendBird.BaseChannel.MetaCounterHandler handler);
        /*0x110ca84*/ void DeleteMetaCounter(string key, SendBird.BaseChannel.DeleteMetaCounterHandler handler);
        /*0x110cc88*/ void DeleteAllMetaCounters(SendBird.BaseChannel.DeleteMetaCounterHandler handler);
        /*0x110cdd8*/ void CreateMetaData(System.Collections.Generic.Dictionary<string, string> metaDataMap, SendBird.BaseChannel.MetaDataHandler handler);
        /*0x110cfdc*/ void UpdateMetaData(System.Collections.Generic.Dictionary<string, string> metaDataMap, SendBird.BaseChannel.MetaDataHandler handler);
        /*0x110d1e4*/ void GetMetaData(System.Collections.Generic.List<string> keys, SendBird.BaseChannel.MetaDataHandler handler);
        /*0x110d3e8*/ void GetAllMetaData(SendBird.BaseChannel.MetaDataHandler handler);
        /*0x110d538*/ void DeleteMetaData(string key, SendBird.BaseChannel.DeleteMetaDataHandler handler);
        /*0x110d73c*/ void DeleteAllMetaData(SendBird.BaseChannel.DeleteMetaDataHandler handler);
        /*0x110d88c*/ void DeleteMessage(SendBird.BaseMessage message, SendBird.BaseChannel.DeleteMessageHandler handler);
        /*0x110da94*/ void UpdateUserMessage(long messageId, string message, string data, string customType, SendBird.BaseChannel.UpdateMessageHandler handler);
        /*0x110daa0*/ void UpdateUserMessage(long messageId, string message, string data, string customType, SendBird.BaseMessage.MentionType mentionType, SendBird.BaseChannel.UpdateMessageHandler handler);
        /*0x110dce4*/ void Report(SendBird.BaseChannel.ReportCategory reportCategory, string reportDescription, SendBird.BaseChannel.ReportHandler handler);
        /*0x110de14*/ void ReportUser(SendBird.User offendingUser, SendBird.BaseChannel.ReportCategory reportCategory, string reportDescription, SendBird.BaseChannel.ReportUserHandler handler);
        /*0x110e004*/ void ReportMessage(SendBird.BaseMessage message, SendBird.BaseChannel.ReportCategory reportCategory, string reportDescription, SendBird.BaseChannel.ReportMessageHandler handler);

        enum ChannelType
        {
            OPEN = 0,
            GROUP = 1,
        }

        class MetaCounterHandler : System.MulticastDelegate
        {
            /*0x110e24c*/ MetaCounterHandler(object object, nint method);
            /*0x110e37c*/ void Invoke(System.Collections.Generic.Dictionary<string, int> metaCounterMap, SendBird.SendBirdException e);
            /*0x110e390*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.Dictionary<string, int> metaCounterMap, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110e3b8*/ void EndInvoke(System.IAsyncResult result);
        }

        class DeleteMetaCounterHandler : System.MulticastDelegate
        {
            /*0x110e3c4*/ DeleteMetaCounterHandler(object object, nint method);
            /*0x110e4f0*/ void Invoke(SendBird.SendBirdException e);
            /*0x110e504*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110e524*/ void EndInvoke(System.IAsyncResult result);
        }

        class MetaDataHandler : System.MulticastDelegate
        {
            /*0x110e530*/ MetaDataHandler(object object, nint method);
            /*0x110e660*/ void Invoke(System.Collections.Generic.Dictionary<string, string> metaDataMap, SendBird.SendBirdException e);
            /*0x110e674*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.Dictionary<string, string> metaDataMap, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110e69c*/ void EndInvoke(System.IAsyncResult result);
        }

        class DeleteMetaDataHandler : System.MulticastDelegate
        {
            /*0x110e6a8*/ DeleteMetaDataHandler(object object, nint method);
            /*0x110e7d4*/ void Invoke(SendBird.SendBirdException e);
            /*0x110e7e8*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110e808*/ void EndInvoke(System.IAsyncResult result);
        }

        class SendUserMessageHandler : System.MulticastDelegate
        {
            /*0x110e814*/ SendUserMessageHandler(object object, nint method);
            /*0x110e944*/ void Invoke(SendBird.UserMessage message, SendBird.SendBirdException e);
            /*0x110e958*/ System.IAsyncResult BeginInvoke(SendBird.UserMessage message, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110e980*/ void EndInvoke(System.IAsyncResult result);
        }

        class SendFileMessageHandler : System.MulticastDelegate
        {
            /*0x110e98c*/ SendFileMessageHandler(object object, nint method);
            /*0x110eabc*/ void Invoke(SendBird.FileMessage message, SendBird.SendBirdException e);
            /*0x110ead0*/ System.IAsyncResult BeginInvoke(SendBird.FileMessage message, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110eaf8*/ void EndInvoke(System.IAsyncResult result);
        }

        class DeleteMessageHandler : System.MulticastDelegate
        {
            /*0x110eb04*/ DeleteMessageHandler(object object, nint method);
            /*0x110ec30*/ void Invoke(SendBird.SendBirdException e);
            /*0x110ec44*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110ec64*/ void EndInvoke(System.IAsyncResult result);
        }

        class UpdateMessageHandler : System.MulticastDelegate
        {
            /*0x110ec70*/ UpdateMessageHandler(object object, nint method);
            /*0x110eda0*/ void Invoke(SendBird.UserMessage message, SendBird.SendBirdException e);
            /*0x110edb4*/ System.IAsyncResult BeginInvoke(SendBird.UserMessage message, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110eddc*/ void EndInvoke(System.IAsyncResult result);
        }

        class ReportHandler : System.MulticastDelegate
        {
            /*0x110ede8*/ ReportHandler(object object, nint method);
            /*0x110ef14*/ void Invoke(SendBird.SendBirdException e);
            /*0x110ef28*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110ef48*/ void EndInvoke(System.IAsyncResult result);
        }

        class ReportUserHandler : System.MulticastDelegate
        {
            /*0x110ef54*/ ReportUserHandler(object object, nint method);
            /*0x110f080*/ void Invoke(SendBird.SendBirdException e);
            /*0x110f094*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110f0b4*/ void EndInvoke(System.IAsyncResult result);
        }

        class ReportMessageHandler : System.MulticastDelegate
        {
            /*0x110f0c0*/ ReportMessageHandler(object object, nint method);
            /*0x110f1ec*/ void Invoke(SendBird.SendBirdException e);
            /*0x110f200*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x110f220*/ void EndInvoke(System.IAsyncResult result);
        }

        enum ReportCategory
        {
            SUSPICIOUS = 0,
            HARASSING = 1,
            SPAM = 2,
            INAPPROPRIATE = 3,
        }

        class <>c__DisplayClass31_0
        {
            /*0x10*/ SendBird.BaseChannel.SendFileMessageHandler handler;

            /*0x110b170*/ <>c__DisplayClass31_0();
            /*0x110f22c*/ void <SendFileMessageWithURL>b__0();
            /*0x110f2fc*/ void <SendFileMessageWithURL>b__1();
            /*0x110f3cc*/ void <SendFileMessageWithURL>b__2(SendBird.Command acked, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass31_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.Command acked;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x110f4b4*/ <>c__DisplayClass31_1();
            /*0x110f4bc*/ void <SendFileMessageWithURL>b__3();
        }

        class <>c__DisplayClass33_0
        {
            /*0x10*/ SendBird.BaseChannel.SendFileMessageHandler handler;
            /*0x18*/ string reqId;
            /*0x20*/ SendBird.BaseChannel <>4__this;
            /*0x28*/ string name;
            /*0x30*/ string type;
            /*0x38*/ int size;
            /*0x40*/ string data;
            /*0x48*/ string customType;
            /*0x50*/ SendBird.Command.SendCommandHandler <>9__4;

            /*0x110bbbc*/ <>c__DisplayClass33_0();
            /*0x110f58c*/ void <SendFileMessage>b__0();
            /*0x110f65c*/ void <SendFileMessage>b__1();
            /*0x110f72c*/ void <SendFileMessage>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x110f9cc*/ void <SendFileMessage>b__4(SendBird.Command acked, SendBird.SendBirdException e1);
        }

        class <>c__DisplayClass33_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x110f9c4*/ <>c__DisplayClass33_1();
            /*0x110fabc*/ void <SendFileMessage>b__3();
        }

        class <>c__DisplayClass33_2
        {
            /*0x10*/ SendBird.SendBirdException e1;
            /*0x18*/ SendBird.Command acked;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals2;

            /*0x110fab4*/ <>c__DisplayClass33_2();
            /*0x110faf8*/ void <SendFileMessage>b__5();
        }

        class <>c__DisplayClass37_0
        {
            /*0x10*/ SendBird.BaseChannel.SendUserMessageHandler handler;

            /*0x110bf00*/ <>c__DisplayClass37_0();
            /*0x110fbc8*/ void <SendUserMessage>b__0();
            /*0x110fc98*/ void <SendUserMessage>b__1(SendBird.Command acked, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass37_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.Command acked;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x110fd80*/ <>c__DisplayClass37_1();
            /*0x110fd88*/ void <SendUserMessage>b__2();
        }

        class <>c__DisplayClass38_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaCounterHandler handler;

            /*0x110c104*/ <>c__DisplayClass38_0();
            /*0x110fe5c*/ void <CreateMetaCounters>b__0();
            /*0x110ff2c*/ void <CreateMetaCounters>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass38_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, int> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x111040c*/ <>c__DisplayClass38_1();
            /*0x1110414*/ void <CreateMetaCounters>b__2();
            /*0x1110450*/ void <CreateMetaCounters>b__3();
        }

        class <>c__DisplayClass39_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaCounterHandler handler;

            /*0x110c310*/ <>c__DisplayClass39_0();
            /*0x111048c*/ void <UpdateMetaCounters>b__0();
            /*0x111055c*/ void <UpdateMetaCounters>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass39_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, int> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1110a3c*/ <>c__DisplayClass39_1();
            /*0x1110a44*/ void <UpdateMetaCounters>b__2();
            /*0x1110a80*/ void <UpdateMetaCounters>b__3();
        }

        class <>c__DisplayClass40_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaCounterHandler handler;

            /*0x110c51c*/ <>c__DisplayClass40_0();
            /*0x1110abc*/ void <IncreaseMetaCounters>b__0();
            /*0x1110b8c*/ void <IncreaseMetaCounters>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass40_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, int> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x111106c*/ <>c__DisplayClass40_1();
            /*0x1111074*/ void <IncreaseMetaCounters>b__2();
            /*0x11110b0*/ void <IncreaseMetaCounters>b__3();
        }

        class <>c__DisplayClass41_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaCounterHandler handler;

            /*0x110c728*/ <>c__DisplayClass41_0();
            /*0x11110ec*/ void <DecreaseMetaCounters>b__0();
            /*0x11111bc*/ void <DecreaseMetaCounters>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass41_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, int> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x111169c*/ <>c__DisplayClass41_1();
            /*0x11116a4*/ void <DecreaseMetaCounters>b__2();
            /*0x11116e0*/ void <DecreaseMetaCounters>b__3();
        }

        class <>c__DisplayClass42_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaCounterHandler handler;

            /*0x110c92c*/ <>c__DisplayClass42_0();
            /*0x111171c*/ void <GetMetaCounters>b__0();
            /*0x11117ec*/ void <GetMetaCounters>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass42_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, int> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1111ccc*/ <>c__DisplayClass42_1();
            /*0x1111cd4*/ void <GetMetaCounters>b__2();
            /*0x1111d10*/ void <GetMetaCounters>b__3();
        }

        class <>c__DisplayClass43_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaCounterHandler handler;

            /*0x110ca7c*/ <>c__DisplayClass43_0();
            /*0x1111d4c*/ void <GetAllMetaCounters>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass43_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, int> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x111222c*/ <>c__DisplayClass43_1();
            /*0x1112234*/ void <GetAllMetaCounters>b__1();
            /*0x1112270*/ void <GetAllMetaCounters>b__2();
        }

        class <>c__DisplayClass44_0
        {
            /*0x10*/ SendBird.BaseChannel.DeleteMetaCounterHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x110cc80*/ <>c__DisplayClass44_0();
            /*0x11122ac*/ void <DeleteMetaCounter>b__0();
            /*0x1112378*/ void <DeleteMetaCounter>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1112868*/ void <DeleteMetaCounter>b__3();
        }

        class <>c__DisplayClass44_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1112860*/ <>c__DisplayClass44_1();
            /*0x1112888*/ void <DeleteMetaCounter>b__2();
        }

        class <>c__DisplayClass45_0
        {
            /*0x10*/ SendBird.BaseChannel.DeleteMetaCounterHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x110cdd0*/ <>c__DisplayClass45_0();
            /*0x11128c0*/ void <DeleteAllMetaCounters>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1112db0*/ void <DeleteAllMetaCounters>b__2();
        }

        class <>c__DisplayClass45_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1112da8*/ <>c__DisplayClass45_1();
            /*0x1112dd0*/ void <DeleteAllMetaCounters>b__1();
        }

        class <>c__DisplayClass46_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaDataHandler handler;

            /*0x110cfd4*/ <>c__DisplayClass46_0();
            /*0x1112e08*/ void <CreateMetaData>b__0();
            /*0x1112ed8*/ void <CreateMetaData>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass46_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x11133b8*/ <>c__DisplayClass46_1();
            /*0x11133c0*/ void <CreateMetaData>b__2();
            /*0x11133fc*/ void <CreateMetaData>b__3();
        }

        class <>c__DisplayClass47_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaDataHandler handler;

            /*0x110d1dc*/ <>c__DisplayClass47_0();
            /*0x1113438*/ void <UpdateMetaData>b__0();
            /*0x1113508*/ void <UpdateMetaData>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass47_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x11139e8*/ <>c__DisplayClass47_1();
            /*0x11139f0*/ void <UpdateMetaData>b__2();
            /*0x1113a2c*/ void <UpdateMetaData>b__3();
        }

        class <>c__DisplayClass48_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaDataHandler handler;

            /*0x110d3e0*/ <>c__DisplayClass48_0();
            /*0x1113a68*/ void <GetMetaData>b__0();
            /*0x1113b38*/ void <GetMetaData>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass48_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1114018*/ <>c__DisplayClass48_1();
            /*0x1114020*/ void <GetMetaData>b__2();
            /*0x111405c*/ void <GetMetaData>b__3();
        }

        class <>c__DisplayClass49_0
        {
            /*0x10*/ SendBird.BaseChannel.MetaDataHandler handler;

            /*0x110d530*/ <>c__DisplayClass49_0();
            /*0x1114098*/ void <GetAllMetaData>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass49_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> result;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1114578*/ <>c__DisplayClass49_1();
            /*0x1114580*/ void <GetAllMetaData>b__1();
            /*0x11145bc*/ void <GetAllMetaData>b__2();
        }

        class <>c__DisplayClass50_0
        {
            /*0x10*/ SendBird.BaseChannel.DeleteMetaDataHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x110d734*/ <>c__DisplayClass50_0();
            /*0x11145f8*/ void <DeleteMetaData>b__0();
            /*0x11146c4*/ void <DeleteMetaData>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1114bb4*/ void <DeleteMetaData>b__3();
        }

        class <>c__DisplayClass50_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1114bac*/ <>c__DisplayClass50_1();
            /*0x1114bd4*/ void <DeleteMetaData>b__2();
        }

        class <>c__DisplayClass51_0
        {
            /*0x10*/ SendBird.BaseChannel.DeleteMetaDataHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x110d884*/ <>c__DisplayClass51_0();
            /*0x1114c0c*/ void <DeleteAllMetaData>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x11150fc*/ void <DeleteAllMetaData>b__2();
        }

        class <>c__DisplayClass51_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x11150f4*/ <>c__DisplayClass51_1();
            /*0x111511c*/ void <DeleteAllMetaData>b__1();
        }

        class <>c__DisplayClass52_0
        {
            /*0x10*/ SendBird.BaseChannel.DeleteMessageHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x110da8c*/ <>c__DisplayClass52_0();
            /*0x1115154*/ void <DeleteMessage>b__0();
            /*0x1115220*/ void <DeleteMessage>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1115380*/ void <DeleteMessage>b__3();
        }

        class <>c__DisplayClass52_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1115378*/ <>c__DisplayClass52_1();
            /*0x11153a0*/ void <DeleteMessage>b__2();
        }

        class <>c__DisplayClass54_0
        {
            /*0x10*/ SendBird.BaseChannel.UpdateMessageHandler handler;

            /*0x110dcdc*/ <>c__DisplayClass54_0();
            /*0x11153d8*/ void <UpdateUserMessage>b__0();
            /*0x11154a8*/ void <UpdateUserMessage>b__1(SendBird.Command acked, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass54_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.Command acked;
            /*0x20*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1115590*/ <>c__DisplayClass54_1();
            /*0x1115598*/ void <UpdateUserMessage>b__2();
        }

        class <>c__DisplayClass55_0
        {
            /*0x10*/ SendBird.BaseChannel.ReportHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x110de0c*/ <>c__DisplayClass55_0();
            /*0x11156f0*/ void <Report>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1115850*/ void <Report>b__2();
        }

        class <>c__DisplayClass55_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1115848*/ <>c__DisplayClass55_1();
            /*0x1115878*/ void <Report>b__1();
        }

        class <>c__DisplayClass56_0
        {
            /*0x10*/ SendBird.BaseChannel.ReportUserHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x110dffc*/ <>c__DisplayClass56_0();
            /*0x11158a8*/ void <ReportUser>b__0();
            /*0x1115968*/ void <ReportUser>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1115ac8*/ void <ReportUser>b__3();
        }

        class <>c__DisplayClass56_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1115ac0*/ <>c__DisplayClass56_1();
            /*0x1115af0*/ void <ReportUser>b__2();
        }

        class <>c__DisplayClass57_0
        {
            /*0x10*/ SendBird.BaseChannel.ReportMessageHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x110e244*/ <>c__DisplayClass57_0();
            /*0x1115b20*/ void <ReportMessage>b__0();
            /*0x1115be0*/ void <ReportMessage>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1115d40*/ void <ReportMessage>b__3();
        }

        class <>c__DisplayClass57_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.BaseChannel.<> CS$<>8__locals1;

            /*0x1115d38*/ <>c__DisplayClass57_1();
            /*0x1115d68*/ void <ReportMessage>b__2();
        }
    }

    class SendingStatus
    {
        static /*0x0*/ SendBird.SendingStatus NONE;
        static /*0x8*/ SendBird.SendingStatus PENDING;
        static /*0x10*/ SendBird.SendingStatus FAILED;
        static /*0x18*/ SendBird.SendingStatus SUCCEEDED;
        static /*0x20*/ SendBird.SendingStatus CANCELED;
        static /*0x28*/ System.Collections.Generic.List<SendBird.SendingStatus> valueList;
        static /*0x30*/ int nextOrdinal;
        /*0x10*/ SendBird.SendingStatus.InnerEnum innerEnumValue;
        /*0x18*/ string nameValue;
        /*0x20*/ int ordinalValue;
        /*0x28*/ string value;

        static /*0x1115d98*/ SendingStatus();
        static /*0x111625c*/ SendBird.SendingStatus fromValue(string value);
        static /*0x1116334*/ SendBird.SendingStatus[] values();
        static /*0x11163c4*/ SendBird.SendingStatus valueOf(string name);
        /*0x11161c0*/ SendingStatus(string name, SendBird.SendingStatus.InnerEnum innerEnum, string value);
        /*0x11163ac*/ string get_Value();
        /*0x11163b4*/ int ordinal();
        /*0x11163bc*/ string ToString();

        enum InnerEnum
        {
            NONE = 0,
            PENDING = 1,
            FAILED = 2,
            SUCCEEDED = 3,
            CANCELED = 4,
        }
    }

    class BaseMessage
    {
        /*0x10*/ long mMessageId;
        /*0x18*/ string mChannelUrl;
        /*0x20*/ string mChannelType;
        /*0x28*/ long mCreatedAt;
        /*0x30*/ string mUserId;
        /*0x38*/ long mUpdatedAt;
        /*0x40*/ SendBird.SendingStatus sendingStatus;

        static /*0x1116598*/ SendBird.BaseMessage Build(SendBird.SBJson.JsonElement el, SendBird.BaseChannel channel);
        /*0x110a6c8*/ BaseMessage(SendBird.SBJson.JsonElement el);
        string get_Message();
        SendBird.Sender GetSender();
        /*0x11172e8*/ void SetSendingStatus(SendBird.SendingStatus sendingStatus);
        /*0x11172f0*/ SendBird.SendingStatus GetSendingStatus();
        /*0x11172f8*/ string get_UserId();
        /*0x1117300*/ long get_MessageId();
        /*0x1117308*/ long get_CreatedAt();
        /*0x1117310*/ long get_UpdatedAt();
        /*0x1117318*/ string get_ChannelUrl();
        /*0x1117320*/ bool IsOpenChannel();
        /*0x1117374*/ bool IsGroupChannel();

        enum MentionType
        {
            USERS = 0,
            CHANNEL = 1,
        }
    }

    class ChannelEvent
    {
        static int CATEGORY_NONE = 0;
        static int CATEGORY_CHANNEL_ENTER = 10102;
        static int CATEGORY_CHANNEL_EXIT = 10103;
        static int CATEGORY_USER_CHANNEL_MUTE = 10201;
        static int CATEGORY_USER_CHANNEL_UNMUTE = 10200;
        static int CATEGORY_USER_CHANNEL_BAN = 10601;
        static int CATEGORY_USER_CHANNEL_UNBAN = 10600;
        static int CATEGORY_CHANNEL_FREEZE = 10701;
        static int CATEGORY_CHANNEL_UNFREEZE = 10700;
        static int CATEGORY_TYPING_START = 10900;
        static int CATEGORY_TYPING_END = 10901;
        static int CATEGORY_CHANNEL_JOIN = 10000;
        static int CATEGORY_CHANNEL_LEAVE = 10001;
        static int CATEGORY_CHANNEL_INVITE = 10020;
        static int CATEGORY_CHANNEL_DECLINE_INVITE = 10022;
        static int CATEGORY_CHANNEL_PROP_CHANGED = 11000;
        static int CATEGORY_CHANNEL_DELETED = 12000;
        static int CATEGORY_CHANNEL_HIDDEN = 13000;
        static int CATEGORY_CHANNEL_UNHIDDEN = 13001;
        /*0x10*/ SendBird.SBJson.JsonObject obj;
        /*0x18*/ int category;
        /*0x20*/ System.Collections.Generic.Dictionary<string, SendBird.SBJson.JsonElement> data;
        /*0x28*/ string channelUrl;
        /*0x30*/ string channelType;
        /*0x38*/ long ts;

        /*0x11173c8*/ ChannelEvent(SendBird.SBJson.JsonElement el);
        /*0x111796c*/ SendBird.SBJson.JsonElement get_Data();
        /*0x11179fc*/ string GetDataAsString(string key);
        /*0x1117aec*/ int GetDataAsInt(string key);
        /*0x1117bdc*/ long GetDataAsLong(string key);
        /*0x1117ccc*/ bool GetDataAsBoolean(string key);
        /*0x1117dc0*/ int get_Category();
        /*0x1117dc8*/ string get_ChannelUrl();
        /*0x1117dd0*/ long GetTs();
        /*0x1117dd8*/ bool IsGroupChannel();
        /*0x1117e2c*/ bool IsOpenChannel();
    }

    class FileMessage : SendBird.BaseMessage
    {
        /*0x48*/ SendBird.Sender mSender;
        /*0x50*/ string mUrl;
        /*0x58*/ string mName;
        /*0x60*/ int mSize;
        /*0x68*/ string mType;
        /*0x70*/ string mData;
        /*0x78*/ string mReqId;
        /*0x80*/ string mCustomType;

        static /*0x110b178*/ SendBird.SBJson.JsonElement Build(string requestId, long msgId, SendBird.User user, SendBird.BaseChannel channel, string url, string name, string type, int size, string data, string customType, long createdAt);
        /*0x110b538*/ FileMessage(SendBird.SBJson.JsonElement el);
        /*0x1117e80*/ string get_RequestId();
        /*0x1117e88*/ SendBird.User get_Sender();
        /*0x1117e90*/ string get_Url();
        /*0x1117e98*/ string get_Name();
        /*0x1117ea0*/ int get_Size();
        /*0x1117ea8*/ string get_Type();
        /*0x1117eb0*/ string get_Data();
        /*0x1117eb8*/ string get_CustomType();
        /*0x1117ec0*/ string get_Message();
        /*0x1117f00*/ SendBird.Sender GetSender();
    }

    class GroupChannel : SendBird.BaseChannel
    {
        static /*0x0*/ object syncLock;
        static /*0x8*/ SafeDictionary<string, SendBird.GroupChannel> sCachedChannels;
        static /*0x10*/ long sMarkAsReadAllLastSentAt;
        /*0x48*/ SafeDictionary<string, long> mCachedTypingStatus;
        /*0x50*/ SafeDictionary<string, long> mCachedReadReceiptStatus;
        /*0x58*/ SafeDictionary<string, long> mCachedDeliveryReceipt;
        /*0x60*/ bool mIsSuper;
        /*0x61*/ bool mIsPublic;
        /*0x62*/ bool mIsDistinct;
        /*0x64*/ SendBird.GroupChannel.CountPreference mMyCountPreference;
        /*0x68*/ bool mIsHidden;
        /*0x6c*/ SendBird.GroupChannel.HiddenState mHiddenState;
        /*0x70*/ int mUnreadMessageCount;
        /*0x78*/ System.Collections.Generic.List<SendBird.Member> mMembers;
        /*0x80*/ System.Collections.Generic.Dictionary<string, SendBird.Member> mMemberMap;
        /*0x88*/ SendBird.BaseMessage mLastMessage;
        /*0x90*/ int mMemberCount;
        /*0x94*/ int mJoinedMemberCount;
        /*0x98*/ long mInvitedAt;
        /*0xa0*/ long mStartTypingLastSentAt;
        /*0xa8*/ long mEndTypingLastSentAt;
        /*0xb0*/ SendBird.Member.MemberState mMyMemberState;
        /*0xb8*/ long mMemberCountUpdatedAt;

        static /*0x1121038*/ GroupChannel();
        static /*0x1118028*/ void ClearCache();
        static /*0x1118148*/ void RemoveChannelFromCache(string channelUrl);
        static /*0x1118598*/ SendBird.GroupChannelListQuery CreateMyGroupChannelListQuery();
        static /*0x1118650*/ void CreateChannel(SendBird.GroupChannelParams param, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x1118850*/ void LocalCreateChannel(System.Collections.Generic.List<string> userIds, System.Collections.Generic.List<string> operatorUserIds, bool isSuper, bool isPublic, bool isEphemeral, bool isDistinct, bool isDiscoverable, string channelUrl, string name, object coverUrlOrImage, string data, string customType, string accessCode, bool strict, bool isBroadcast, int messageSurvivalSeconds, object handler);
        static /*0x1118b9c*/ void CreateChannel(System.Collections.Generic.List<SendBird.User> users, bool isDistinct, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x1119748*/ void CreateChannel(System.Collections.Generic.List<SendBird.User> users, bool isDistinct, string name, object coverUrlOrImage, string data, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x11199b0*/ void CreateChannel(System.Collections.Generic.List<SendBird.User> users, bool isDistinct, string name, object coverUrlOrImage, string data, string customType, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x1119c1c*/ void CreateChannel(System.Collections.Generic.List<SendBird.User> users, bool isDistinct, string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<SendBird.User> operators, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x1119fd4*/ void CreateChannelWithUserIds(System.Collections.Generic.List<string> userIds, bool isDistinct, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x111a064*/ void CreateChannelWithUserIds(System.Collections.Generic.List<string> userIds, bool isDistinct, string channelUrl, string name, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x111a104*/ void CreateChannelWithUserIds(System.Collections.Generic.List<string> userIds, bool isDistinct, string name, object coverUrlOrImage, string data, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x111a1b0*/ void CreateChannelWithUserIds(System.Collections.Generic.List<string> userIds, bool isDistinct, string name, object coverUrlOrImage, string data, string customType, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x1118de8*/ void CreateChannelWithUserIds(System.Collections.Generic.List<string> userIds, bool isDistinct, string channelUrl, string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<string> operatorIds, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x111a268*/ void CreateChannelWithUserIds(System.Collections.Generic.List<string> userIds, bool isDistinct, string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<string> operatorIds, SendBird.GroupChannel.GroupChannelCreateHandler handler);
        static /*0x1118490*/ void GetChannelWithoutCache(string channelUrl, SendBird.GroupChannel.GroupChannelGetHandler handler);
        static /*0x111a32c*/ void GetChannel(string channelUrl, SendBird.GroupChannel.GroupChannelGetHandler handler);
        static /*0x111a5b8*/ void GetTotalUnreadMessageCount(SendBird.GroupChannel.GroupChannelTotalUnreadMessageCountHandler handler);
        static /*0x111a790*/ SendBird.GroupChannel Upsert(SendBird.SBJson.JsonElement el);
        static /*0x111ab24*/ SendBird.GroupChannel Upsert(SendBird.SBJson.JsonElement el, bool dirty);
        static /*0x111dc10*/ void SetInvitionPreference(bool autoAccept, SendBird.GroupChannel.GroupChannelSetInvitationPreferenceHandler handler);
        static /*0x111dd14*/ void GetInvitionPreference(SendBird.GroupChannel.GroupChannelGetInvitationPreferenceHandler handler);
        static /*0x111e1d8*/ void MarkAsReadAll(SendBird.GroupChannel.GroupChannelMarkAsReadHandler handler);
        /*0x111aa50*/ GroupChannel(SendBird.SBJson.JsonElement el);
        /*0x1118278*/ void Refresh(SendBird.GroupChannel.GroupChannelRefreshHandler handler);
        /*0x111ae9c*/ void Update(SendBird.SBJson.JsonElement el);
        /*0x111aec4*/ void Parse(SendBird.SBJson.JsonElement el);
        /*0x111c0f4*/ SendBird.BaseMessage get_LastMessage();
        /*0x111c0fc*/ long GetCreatedAt();
        /*0x111c104*/ void SetLastMessage(SendBird.BaseMessage lastMessage);
        /*0x111c184*/ bool SetLastMessageByCreatedAt(SendBird.BaseMessage lastMessage);
        /*0x111c2b0*/ int get_UnreadMessageCount();
        /*0x111c2b8*/ void SetUnreadMessageCount(int count);
        /*0x111c338*/ SendBird.GroupChannel.CountPreference getMyCountPreference();
        /*0x111c340*/ bool isMyUnreadMessageCountEnabled();
        /*0x111c350*/ bool isMyUnreadMentionCountEnabled();
        /*0x111c360*/ System.Collections.Generic.List<SendBird.Member> get_Members();
        /*0x111c368*/ int get_MemberCount();
        /*0x111c370*/ SendBird.GroupChannelMemberListQuery CreateMemberListQuery();
        /*0x111c3d0*/ bool IsDistinct();
        /*0x111c3d8*/ void UpdateChannel(string name, object coverUrlOrImage, string data, SendBird.GroupChannel.GroupChannelUpdateHandler handler);
        /*0x111c6f4*/ void UpdateChannel(bool isDistinct, string name, object coverUrlOrImage, string data, SendBird.GroupChannel.GroupChannelUpdateHandler handler);
        /*0x111c71c*/ void UpdateChannel(bool isDistinct, string name, object coverUrlOrImage, string data, string customType, SendBird.GroupChannel.GroupChannelUpdateHandler handler);
        /*0x111c740*/ void DeleteChannel(string channelUrl, SendBird.GroupChannel.GroupChannelLeaveHandler handler);
        /*0x111c410*/ void UpdateChannel(bool isDistinct, string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<string> operatorIds, SendBird.GroupChannel.GroupChannelUpdateHandler handler);
        /*0x111c84c*/ void Invite(SendBird.User user, SendBird.GroupChannel.GroupChannelInviteHandler handler);
        /*0x111cf00*/ void Invite(System.Collections.Generic.List<SendBird.User> users, SendBird.GroupChannel.GroupChannelInviteHandler handler);
        /*0x111d1d0*/ void InviteWithUserId(string userId, SendBird.GroupChannel.GroupChannelInviteHandler handler);
        /*0x111ca18*/ void InviteWithUserIds(System.Collections.Generic.List<string> userIds, SendBird.GroupChannel.GroupChannelInviteHandler handler);
        /*0x111d3a4*/ void AcceptInvitation(SendBird.GroupChannel.GroupChannelInviteHandler handler);
        /*0x111d3b4*/ void AcceptInvitation(string accessCode, string userId, SendBird.GroupChannel.GroupChannelInviteHandler handler);
        /*0x111d4d4*/ void DeclineInvitation(SendBird.GroupChannel.GroupChannelInviteHandler handler);
        /*0x111d5dc*/ void Join(SendBird.GroupChannel.GroupChannelJoinHandler handler);
        /*0x111d5e8*/ void Join(string accessCode, SendBird.GroupChannel.GroupChannelJoinHandler handler);
        /*0x111d700*/ void Hide(SendBird.GroupChannel.GroupChannelHideHandler handler);
        /*0x111d710*/ void Hide(bool hidePreviousMessages, SendBird.GroupChannel.GroupChannelHideHandler handler);
        /*0x111d720*/ void Hide(bool hidePreviousMessages, bool allowAutoUnhide, SendBird.GroupChannel.GroupChannelHideHandler handler);
        /*0x111d924*/ void UnHide(SendBird.GroupChannel.GroupChannelUnhideHandler handler);
        /*0x111da2c*/ void Leave(SendBird.GroupChannel.GroupChannelLeaveHandler handler);
        /*0x111de08*/ void SetPushPreference(bool pushOn, SendBird.GroupChannel.GroupChannelSetPushPreferenceHandler handler);
        /*0x111dffc*/ void GetPushPreference(SendBird.GroupChannel.GroupChannelGetPushPreferenceHandler handler);
        /*0x111e494*/ void SendMarkAsRead(SendBird.GroupChannel.GroupChannelMarkAsReadHandler handler);
        /*0x111e670*/ void MarkAsRead();
        /*0x111e678*/ long GetLastSeenAtBy(SendBird.User user);
        /*0x111e68c*/ long GetLastSeenAtByWithUserId(string userId);
        /*0x111e720*/ System.Collections.Generic.List<SendBird.User> GetReadMembers(SendBird.BaseMessage message);
        /*0x111eae0*/ System.Collections.Generic.List<SendBird.User> GetUnreadMembers(SendBird.BaseMessage message);
        /*0x111eea0*/ System.Collections.Generic.Dictionary<string, SendBird.ReadStatus> GetReadStatus();
        /*0x111f160*/ int GetReadReceipt(SendBird.BaseMessage message);
        /*0x111bdfc*/ void UpdateReadReceipt(string userId, long timestamp);
        /*0x111bf68*/ void UpdateDeliveryReceipt(string userId, long timestamp);
        /*0x111f46c*/ void StartTyping();
        /*0x111f590*/ void EndTyping();
        /*0x111f6b4*/ bool InvalidateTypingStatus();
        /*0x111f96c*/ void UpdateTypingStatus(SendBird.User user, bool start);
        /*0x111fb1c*/ bool IsTyping();
        /*0x111fb78*/ System.Collections.Generic.List<SendBird.Member> get_TypingMembers();
        /*0x111fde4*/ void BanUser(SendBird.User user, string description, int seconds, SendBird.GroupChannel.GroupChannelBanHandler handler);
        /*0x111ff1c*/ void BanUserWithUserId(string userId, string description, int seconds, SendBird.GroupChannel.GroupChannelBanHandler handler);
        /*0x11200e4*/ void UnbanUser(SendBird.User user, SendBird.GroupChannel.GroupChannelUnbanHandler handler);
        /*0x11201fc*/ void UnbanUserWithUserId(string userId, SendBird.GroupChannel.GroupChannelUnbanHandler handler);
        /*0x11203a4*/ SendBird.Member.MemberState get_MyMemberState();
        /*0x11203ac*/ void SetMyMemberState(SendBird.Member.MemberState myMemberState);
        /*0x11203b4*/ long GetInvitedAt();
        /*0x11203bc*/ void SetInvitedAt(long invitedAt);
        /*0x11203c4*/ bool IsSuper();
        /*0x11203cc*/ bool IsPublic();
        /*0x11203d4*/ bool get_IsHidden();
        /*0x11203dc*/ void SetIsHidden(bool isHidden);
        /*0x11203e8*/ SendBird.GroupChannel.HiddenState get_GetHiddenState();
        /*0x111c0cc*/ void SetHiddenState(SendBird.GroupChannel.HiddenState hiddenState);
        /*0x11203f0*/ SendBird.UserListQuery CreateBannedUserListQuery();
        /*0x1120458*/ void AddMember(SendBird.Member user);
        /*0x1120630*/ void RemoveMember(SendBird.User user);
        /*0x11207d0*/ void UpdateJoinedMemberCount();
        /*0x112092c*/ int GetMemberCount();
        /*0x1120934*/ int get_JoinedMemberCount();
        /*0x112093c*/ void SetMemberCount(SendBird.SBJson.JsonElement data, long ts);
        /*0x1120a80*/ void MuteUserWithUserId(string userId, SendBird.GroupChannel.GroupChannelMuteHandler handler);
        /*0x1120a90*/ void LocalMuteUserWithUserId(string userId, string description, int seconds, SendBird.GroupChannel.GroupChannelMuteHandler handler);
        /*0x1120c58*/ void UnmuteUserWithUserId(string userId, SendBird.GroupChannel.GroupChannelUnmuteHandler handler);
        /*0x1120e00*/ void MuteUser(SendBird.User user, SendBird.GroupChannel.GroupChannelMuteHandler handler);
        /*0x1120f20*/ void UnmuteUser(SendBird.User user, SendBird.GroupChannel.GroupChannelUnmuteHandler handler);

        enum CountPreference
        {
            ALL = 0,
            UNREAD_MESSAGE_COUNT_ONLY = 1,
            UNREAD_MENTION_COUNT_ONLY = 2,
            OFF = 3,
        }

        enum HiddenState
        {
            UNHIDDEN = 0,
            HIDDEN_ALLOW_AUTO_UNHIDE = 1,
            HIDDEN_PREVENT_AUTO_UNHIDE = 2,
        }

        class GroupChannelRefreshHandler : System.MulticastDelegate
        {
            /*0x11210fc*/ GroupChannelRefreshHandler(object object, nint method);
            /*0x1121228*/ void Invoke(SendBird.SendBirdException e);
            /*0x112123c*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x112125c*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelCreateHandler : System.MulticastDelegate
        {
            /*0x1121268*/ GroupChannelCreateHandler(object object, nint method);
            /*0x1121398*/ void Invoke(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x11213ac*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x11213d4*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelUpdateHandler : System.MulticastDelegate
        {
            /*0x11213e0*/ GroupChannelUpdateHandler(object object, nint method);
            /*0x1121510*/ void Invoke(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1121524*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x112154c*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelHideHandler : System.MulticastDelegate
        {
            /*0x1121558*/ GroupChannelHideHandler(object object, nint method);
            /*0x1121684*/ void Invoke(SendBird.SendBirdException e);
            /*0x1121698*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x11216b8*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelJoinHandler : System.MulticastDelegate
        {
            /*0x11216c4*/ GroupChannelJoinHandler(object object, nint method);
            /*0x11217f0*/ void Invoke(SendBird.SendBirdException e);
            /*0x1121804*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1121824*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelInviteHandler : System.MulticastDelegate
        {
            /*0x1121830*/ GroupChannelInviteHandler(object object, nint method);
            /*0x112195c*/ void Invoke(SendBird.SendBirdException e);
            /*0x1121970*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1121990*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelLeaveHandler : System.MulticastDelegate
        {
            /*0x112199c*/ GroupChannelLeaveHandler(object object, nint method);
            /*0x1121ac8*/ void Invoke(SendBird.SendBirdException e);
            /*0x1121adc*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1121afc*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelMarkAsReadHandler : System.MulticastDelegate
        {
            /*0x1121b08*/ GroupChannelMarkAsReadHandler(object object, nint method);
            /*0x1121c34*/ void Invoke(SendBird.SendBirdException e);
            /*0x1121c48*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1121c68*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelGetHandler : System.MulticastDelegate
        {
            /*0x1118360*/ GroupChannelGetHandler(object object, nint method);
            /*0x1121c74*/ void Invoke(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1121c88*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1121cb0*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelTotalUnreadMessageCountHandler : System.MulticastDelegate
        {
            /*0x1121cbc*/ GroupChannelTotalUnreadMessageCountHandler(object object, nint method);
            /*0x1121d80*/ void Invoke(int unreadMessageCount, SendBird.SendBirdException e);
            /*0x1121d94*/ System.IAsyncResult BeginInvoke(int unreadMessageCount, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1121e24*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelSetPushPreferenceHandler : System.MulticastDelegate
        {
            /*0x1121e30*/ GroupChannelSetPushPreferenceHandler(object object, nint method);
            /*0x1121f5c*/ void Invoke(SendBird.SendBirdException e);
            /*0x1121f70*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1121f90*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelGetPushPreferenceHandler : System.MulticastDelegate
        {
            /*0x1121f9c*/ GroupChannelGetPushPreferenceHandler(object object, nint method);
            /*0x1122060*/ void Invoke(bool isPushOn, SendBird.SendBirdException e);
            /*0x1122078*/ System.IAsyncResult BeginInvoke(bool isPushOn, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x112210c*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelBanHandler : System.MulticastDelegate
        {
            /*0x1122118*/ GroupChannelBanHandler(object object, nint method);
            /*0x1122244*/ void Invoke(SendBird.SendBirdException e);
            /*0x1122258*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1122278*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelUnbanHandler : System.MulticastDelegate
        {
            /*0x1122284*/ GroupChannelUnbanHandler(object object, nint method);
            /*0x11223b0*/ void Invoke(SendBird.SendBirdException e);
            /*0x11223c4*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x11223e4*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelSetInvitationPreferenceHandler : System.MulticastDelegate
        {
            /*0x11223f0*/ GroupChannelSetInvitationPreferenceHandler(object object, nint method);
            /*0x112251c*/ void Invoke(SendBird.SendBirdException e);
            /*0x1122530*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1122550*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelGetInvitationPreferenceHandler : System.MulticastDelegate
        {
            /*0x112255c*/ GroupChannelGetInvitationPreferenceHandler(object object, nint method);
            /*0x1122620*/ void Invoke(bool autoAccept, SendBird.SendBirdException e);
            /*0x1122638*/ System.IAsyncResult BeginInvoke(bool autoAccept, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x11226cc*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelMuteHandler : System.MulticastDelegate
        {
            /*0x11226d8*/ GroupChannelMuteHandler(object object, nint method);
            /*0x1122804*/ void Invoke(SendBird.SendBirdException e);
            /*0x1122818*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1122838*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelUnmuteHandler : System.MulticastDelegate
        {
            /*0x1122844*/ GroupChannelUnmuteHandler(object object, nint method);
            /*0x1122970*/ void Invoke(SendBird.SendBirdException e);
            /*0x1122984*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x11229a4*/ void EndInvoke(System.IAsyncResult result);
        }

        class GroupChannelUnhideHandler : System.MulticastDelegate
        {
            /*0x11229b0*/ GroupChannelUnhideHandler(object object, nint method);
            /*0x1122adc*/ void Invoke(SendBird.SendBirdException e);
            /*0x1122af0*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1122b10*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass26_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelRefreshHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x1118358*/ <>c__DisplayClass26_0();
            /*0x1122b1c*/ void <Refresh>b__0(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1122c7c*/ void <Refresh>b__2();
        }

        class <>c__DisplayClass26_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1122c74*/ <>c__DisplayClass26_1();
            /*0x1122c9c*/ void <Refresh>b__1();
        }

        class <>c__DisplayClass28_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelCreateHandler handler;

            /*0x1118848*/ <>c__DisplayClass28_0();
            /*0x1122cd4*/ void <CreateChannel>b__0();
        }

        class <>c__DisplayClass29_0
        {
            /*0x10*/ object handler;

            /*0x1118b94*/ <>c__DisplayClass29_0();
            /*0x1122d98*/ void <LocalCreateChannel>b__0();
            /*0x1122e90*/ void <LocalCreateChannel>b__1();
            /*0x1122f88*/ void <LocalCreateChannel>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass29_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel channel;
            /*0x20*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1123174*/ <>c__DisplayClass29_1();
            /*0x112317c*/ void <LocalCreateChannel>b__3();
            /*0x11231fc*/ void <LocalCreateChannel>b__4();
        }

        class <>c__DisplayClass38_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelCreateHandler handler;

            /*0x111a260*/ <>c__DisplayClass38_0();
            /*0x112327c*/ void <CreateChannelWithUserIds>b__0();
            /*0x1123340*/ void <CreateChannelWithUserIds>b__1();
            /*0x1123404*/ void <CreateChannelWithUserIds>b__2();
            /*0x11234c8*/ void <CreateChannelWithUserIds>b__3(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass38_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel channel;
            /*0x20*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1123638*/ <>c__DisplayClass38_1();
            /*0x1123640*/ void <CreateChannelWithUserIds>b__4();
            /*0x1123674*/ void <CreateChannelWithUserIds>b__5();
        }

        class <>c__DisplayClass40_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelGetHandler handler;
            /*0x18*/ string channelUrl;

            /*0x111a324*/ <>c__DisplayClass40_0();
            /*0x11236a8*/ void <GetChannelWithoutCache>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass41_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelGetHandler handler;

            /*0x111a5a8*/ <>c__DisplayClass41_0();
            /*0x11237ac*/ void <GetChannel>b__0();
            /*0x1123870*/ void <GetChannel>b__1(SendBird.GroupChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass41_1
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x111a5b0*/ <>c__DisplayClass41_1();
            /*0x1123978*/ void <GetChannel>b__2();
        }

        class <>c__DisplayClass41_2
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdException e;
            /*0x20*/ SendBird.GroupChannel.<> CS$<>8__locals2;

            /*0x1123970*/ <>c__DisplayClass41_2();
            /*0x11239ac*/ void <GetChannel>b__3();
        }

        class <>c__DisplayClass42_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelTotalUnreadMessageCountHandler handler;

            /*0x111a788*/ <>c__DisplayClass42_0();
            /*0x11239dc*/ void <GetTotalUnreadMessageCount>b__0();
            /*0x1123aa0*/ void <GetTotalUnreadMessageCount>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass42_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ int unreadCount;
            /*0x20*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1123c34*/ <>c__DisplayClass42_1();
            /*0x1123c3c*/ void <GetTotalUnreadMessageCount>b__2();
            /*0x1123c70*/ void <GetTotalUnreadMessageCount>b__3();
        }

        class <>c__DisplayClass68_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelLeaveHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x111c83c*/ <>c__DisplayClass68_0();
            /*0x1123ca4*/ void <DeleteChannel>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1123e44*/ void <DeleteChannel>b__2();
        }

        class <>c__DisplayClass68_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1123e3c*/ <>c__DisplayClass68_1();
            /*0x1123e6c*/ void <DeleteChannel>b__1();
        }

        class <>c__DisplayClass69_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelUpdateHandler handler;

            /*0x111c844*/ <>c__DisplayClass69_0();
            /*0x1123e9c*/ void <UpdateChannel>b__0();
            /*0x1123f60*/ void <UpdateChannel>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass69_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel channel;
            /*0x20*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x11240d0*/ <>c__DisplayClass69_1();
            /*0x11240d8*/ void <UpdateChannel>b__2();
            /*0x112410c*/ void <UpdateChannel>b__3();
        }

        class <>c__DisplayClass70_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelInviteHandler handler;

            /*0x111ca10*/ <>c__DisplayClass70_0();
            /*0x1124140*/ void <Invite>b__0();
        }

        class <>c__DisplayClass71_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelInviteHandler handler;

            /*0x111d1c8*/ <>c__DisplayClass71_0();
            /*0x1124200*/ void <Invite>b__0();
        }

        class <>c__DisplayClass72_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelInviteHandler handler;

            /*0x111d394*/ <>c__DisplayClass72_0();
            /*0x11242c0*/ void <InviteWithUserId>b__0();
        }

        class <>c__DisplayClass73_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelInviteHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x111d39c*/ <>c__DisplayClass73_0();
            /*0x1124380*/ void <InviteWithUserIds>b__0();
            /*0x1124440*/ void <InviteWithUserIds>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x11245e0*/ void <InviteWithUserIds>b__3();
        }

        class <>c__DisplayClass73_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x11245d8*/ <>c__DisplayClass73_1();
            /*0x1124608*/ void <InviteWithUserIds>b__2();
        }

        class <>c__DisplayClass75_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelInviteHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x111d4cc*/ <>c__DisplayClass75_0();
            /*0x1124638*/ void <AcceptInvitation>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1124798*/ void <AcceptInvitation>b__2();
        }

        class <>c__DisplayClass75_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1124790*/ <>c__DisplayClass75_1();
            /*0x11247c0*/ void <AcceptInvitation>b__1();
        }

        class <>c__DisplayClass76_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelInviteHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x111d5d4*/ <>c__DisplayClass76_0();
            /*0x11247f0*/ void <DeclineInvitation>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1124950*/ void <DeclineInvitation>b__2();
        }

        class <>c__DisplayClass76_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1124948*/ <>c__DisplayClass76_1();
            /*0x1124978*/ void <DeclineInvitation>b__1();
        }

        class <>c__DisplayClass78_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelJoinHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x111d6f8*/ <>c__DisplayClass78_0();
            /*0x11249a8*/ void <Join>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1124b4c*/ void <Join>b__2();
        }

        class <>c__DisplayClass78_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1124b44*/ <>c__DisplayClass78_1();
            /*0x1124b74*/ void <Join>b__1();
        }

        class <>c__DisplayClass81_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelHideHandler handler;
            /*0x18*/ bool allowAutoUnhide;
            /*0x20*/ SendBird.GroupChannel <>4__this;
            /*0x28*/ bool hidePreviousMessages;
            /*0x30*/ SendBird.MyAction <>9__3;

            /*0x111d91c*/ <>c__DisplayClass81_0();
            /*0x1124ba4*/ void <Hide>b__0();
            /*0x1124c64*/ void <Hide>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1124df8*/ void <Hide>b__3();
        }

        class <>c__DisplayClass81_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1124df0*/ <>c__DisplayClass81_1();
            /*0x1124e20*/ void <Hide>b__2();
        }

        class <>c__DisplayClass82_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelUnhideHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x111da24*/ <>c__DisplayClass82_0();
            /*0x1124e50*/ void <UnHide>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1124fb0*/ void <UnHide>b__2();
        }

        class <>c__DisplayClass82_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1124fa8*/ <>c__DisplayClass82_1();
            /*0x1124fd8*/ void <UnHide>b__1();
        }

        class <>c__DisplayClass83_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelLeaveHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x111dc08*/ <>c__DisplayClass83_0();
            /*0x1125008*/ void <Leave>b__0();
            /*0x11250c8*/ void <Leave>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1125228*/ void <Leave>b__3();
        }

        class <>c__DisplayClass83_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x1125220*/ <>c__DisplayClass83_1();
            /*0x1125250*/ void <Leave>b__2();
        }

        class <>c__DisplayClass84_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelSetInvitationPreferenceHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x111dd0c*/ <>c__DisplayClass84_0();
            /*0x1125280*/ void <SetInvitionPreference>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x11253d8*/ void <SetInvitionPreference>b__2();
        }

        class <>c__DisplayClass84_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150c864*/ <>c__DisplayClass84_1();
            /*0x150c86c*/ void <SetInvitionPreference>b__1();
        }

        class <>c__DisplayClass85_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelGetInvitationPreferenceHandler handler;

            /*0x150c89c*/ <>c__DisplayClass85_0();
            /*0x150c8a4*/ void <GetInvitionPreference>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass85_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ bool autoAccept;
            /*0x20*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150ca38*/ <>c__DisplayClass85_1();
            /*0x150cadc*/ void <GetInvitionPreference>b__1();
            /*0x150cb10*/ void <GetInvitionPreference>b__2();
        }

        class <>c__DisplayClass86_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelSetPushPreferenceHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x150cb44*/ <>c__DisplayClass86_0();
            /*0x150cb4c*/ void <SetPushPreference>b__0();
            /*0x150cc0c*/ void <SetPushPreference>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x150cd68*/ void <SetPushPreference>b__3();
        }

        class <>c__DisplayClass86_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150cd60*/ <>c__DisplayClass86_1();
            /*0x150cd90*/ void <SetPushPreference>b__2();
        }

        class <>c__DisplayClass87_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelGetPushPreferenceHandler handler;

            /*0x150cdc0*/ <>c__DisplayClass87_0();
            /*0x150cdc8*/ void <GetPushPreference>b__0();
            /*0x150ce8c*/ void <GetPushPreference>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass87_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ bool isPushOn;
            /*0x20*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150d020*/ <>c__DisplayClass87_1();
            /*0x150d028*/ void <GetPushPreference>b__2();
            /*0x150d05c*/ void <GetPushPreference>b__3();
        }

        class <>c__DisplayClass88_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelMarkAsReadHandler handler;
            /*0x18*/ SendBird.MyAction <>9__4;

            /*0x150d090*/ <>c__DisplayClass88_0();
            /*0x150d098*/ void <MarkAsReadAll>b__0();
            /*0x150d158*/ void <MarkAsReadAll>b__1();
            /*0x150d218*/ void <MarkAsReadAll>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x150d4f0*/ void <MarkAsReadAll>b__4();
        }

        class <>c__DisplayClass88_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150d4e8*/ <>c__DisplayClass88_1();
            /*0x150d518*/ void <MarkAsReadAll>b__3();
        }

        class <>c__DisplayClass89_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelMarkAsReadHandler handler;
            /*0x18*/ SendBird.GroupChannel <>4__this;
            /*0x20*/ SendBird.MyAction <>9__3;
            /*0x28*/ SendBird.MyAction <>9__4;

            /*0x150d548*/ <>c__DisplayClass89_0();
            /*0x150d550*/ void <SendMarkAsRead>b__0();
            /*0x150d610*/ void <SendMarkAsRead>b__1(SendBird.Command acked, SendBird.SendBirdException e);
            /*0x150d7e8*/ void <SendMarkAsRead>b__3();
            /*0x150da84*/ void <SendMarkAsRead>b__4();
        }

        class <>c__DisplayClass89_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150d7e0*/ <>c__DisplayClass89_1();
            /*0x150daac*/ void <SendMarkAsRead>b__2();
        }

        class <>c__DisplayClass106_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelBanHandler handler;

            /*0x150dadc*/ <>c__DisplayClass106_0();
            /*0x150dae4*/ void <BanUser>b__0();
        }

        class <>c__DisplayClass107_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelBanHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x150dba4*/ <>c__DisplayClass107_0();
            /*0x150dbac*/ void <BanUserWithUserId>b__0();
            /*0x150dc6c*/ void <BanUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException exception);
            /*0x150ddc8*/ void <BanUserWithUserId>b__3();
        }

        class <>c__DisplayClass107_1
        {
            /*0x10*/ SendBird.SendBirdException exception;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150ddc0*/ <>c__DisplayClass107_1();
            /*0x150ddf0*/ void <BanUserWithUserId>b__2();
        }

        class <>c__DisplayClass108_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelUnbanHandler handler;

            /*0x150de20*/ <>c__DisplayClass108_0();
            /*0x150de28*/ void <UnbanUser>b__0();
        }

        class <>c__DisplayClass109_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelUnbanHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x150dee8*/ <>c__DisplayClass109_0();
            /*0x150def0*/ void <UnbanUserWithUserId>b__0();
            /*0x150dfb0*/ void <UnbanUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException exception);
            /*0x150e10c*/ void <UnbanUserWithUserId>b__3();
        }

        class <>c__DisplayClass109_1
        {
            /*0x10*/ SendBird.SendBirdException exception;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150e104*/ <>c__DisplayClass109_1();
            /*0x150e134*/ void <UnbanUserWithUserId>b__2();
        }

        class <>c__DisplayClass133_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelMuteHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x150e164*/ <>c__DisplayClass133_0();
            /*0x150e16c*/ void <LocalMuteUserWithUserId>b__0();
            /*0x150e22c*/ void <LocalMuteUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x150e388*/ void <LocalMuteUserWithUserId>b__3();
        }

        class <>c__DisplayClass133_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150e380*/ <>c__DisplayClass133_1();
            /*0x150e3b0*/ void <LocalMuteUserWithUserId>b__2();
        }

        class <>c__DisplayClass134_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelUnmuteHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x150e3e0*/ <>c__DisplayClass134_0();
            /*0x150e3e8*/ void <UnmuteUserWithUserId>b__0();
            /*0x150e4a8*/ void <UnmuteUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x150e604*/ void <UnmuteUserWithUserId>b__3();
        }

        class <>c__DisplayClass134_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.GroupChannel.<> CS$<>8__locals1;

            /*0x150e5fc*/ <>c__DisplayClass134_1();
            /*0x150e62c*/ void <UnmuteUserWithUserId>b__2();
        }

        class <>c__DisplayClass135_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelMuteHandler handler;

            /*0x150e65c*/ <>c__DisplayClass135_0();
            /*0x150e664*/ void <MuteUser>b__0();
        }

        class <>c__DisplayClass136_0
        {
            /*0x10*/ SendBird.GroupChannel.GroupChannelUnmuteHandler handler;

            /*0x150e68c*/ <>c__DisplayClass136_0();
            /*0x150e694*/ void <UnmuteUser>b__0();
        }
    }

    class GroupChannelListQuery
    {
        static /*0x0*/ object syncLock;
        static /*0x8*/ string ORDER_LATEST_LAST_MESSAGE;
        static /*0x10*/ string ORDER_CHRONOLOGICAL;
        static /*0x18*/ string ORDER_CHANNEL_NAME_ALPHABETICAL;
        static /*0x20*/ string ORDER_METADATA_VALUE_ALPHABETICAL;
        static /*0x28*/ string MEMBER_STATE_ALL;
        static /*0x30*/ string MEMBER_STATE_INVITED_ONLY;
        static /*0x38*/ string MEMBER_STATE_INVITED_BY_FRIEND_ONLY;
        static /*0x40*/ string MEMBER_STATE_INVITED_BY_NON_FRIEND_ONLY;
        static /*0x48*/ string MEMBER_STATE_JOINED_ONLY;
        /*0x10*/ SendBird.User mUser;
        /*0x18*/ string mToken;
        /*0x20*/ bool mHasNext;
        /*0x24*/ int mLimit;
        /*0x28*/ bool mLoading;
        /*0x29*/ bool mIncludeEmpty;
        /*0x30*/ string mOrder;
        /*0x38*/ SendBird.GroupChannelListQuery.FilterMode mFilterMode;
        /*0x3c*/ SendBird.GroupChannelListQuery.QueryType mQueryType;
        /*0x40*/ System.Collections.Generic.List<string> mFilter;
        /*0x48*/ System.Collections.Generic.List<string> mCustomTypesFilter;
        /*0x50*/ string mMemberState;
        /*0x58*/ SendBird.GroupChannelListQuery.HiddenChannelFilter mHiddenChannelFilter;

        static /*0x150fc78*/ GroupChannelListQuery();
        /*0x150e6bc*/ GroupChannelListQuery(SendBird.User user);
        /*0x150e770*/ GroupChannelListQuery(SendBird.SBJson.JsonElement el);
        /*0x150f0b0*/ int get_Limit();
        /*0x150f0b8*/ void set_Limit(int value);
        /*0x150f0c0*/ bool get_IncludeEmpty();
        /*0x150f0c8*/ void set_IncludeEmpty(bool value);
        /*0x150f0d4*/ void SetIncludeEmpty(bool includeEmpty);
        /*0x150f0e0*/ void SetLimit(int limit);
        /*0x150f0e8*/ void set_Order(SendBird.GroupChannelListQuery.ChannelListOrder value);
        /*0x150f164*/ SendBird.GroupChannelListQuery.ChannelListOrder get_Order();
        /*0x150f1d8*/ void SetOrder(SendBird.GroupChannelListQuery.ChannelListOrder order);
        /*0x150f29c*/ void SetNicknameContainsFilter(string nickname);
        /*0x150f3ac*/ void SetUserIdsIncludeFilter(System.Collections.Generic.List<string> userIds, SendBird.GroupChannelListQuery.QueryType queryType);
        /*0x150f470*/ void SetUserIdsExactFilter(System.Collections.Generic.List<string> userIds);
        /*0x150f530*/ void SetCustomTypesFilter(System.Collections.Generic.List<string> customTypesFilter);
        /*0x150f5e8*/ bool HasNext();
        /*0x150f5f0*/ bool IsLoading();
        /*0x150f66c*/ void SetLoading(bool tf);
        /*0x150f6ec*/ void Next(SendBird.GroupChannelListQuery.GroupChannelListQueryResultHandler handler);
        /*0x150fa4c*/ SendBird.GroupChannelListQuery.MemberStateFilter GetMemberStateFilter();
        /*0x150fb80*/ void SetMemberStateFilter(SendBird.GroupChannelListQuery.MemberStateFilter memberStateFilter);
        /*0x150fc70*/ void SetHiddenChannelFilter(SendBird.GroupChannelListQuery.HiddenChannelFilter hiddenChannelFilter);

        enum ChannelListOrder
        {
            CHRONOLOGICAL = 0,
            LATEST_LAST_MESSAGE = 1,
            CHANNEL_NAME_ALPHABETICAL = 2,
            METADATA_VALUE_ALPHABETICAL = 3,
        }

        enum QueryType
        {
            AND = 0,
            OR = 1,
        }

        enum FilterMode
        {
            ALL = 0,
            MEMBERS_EXACTLY_IN = 1,
            MEMBERS_NICKNAME_CONTAINS = 2,
            MEMBERS_INCLUDE_IN = 3,
        }

        enum MemberStateFilter
        {
            ALL = 0,
            INVITED = 1,
            INVITED_BY_FRIEND = 2,
            INVITED_BY_NON_FRIEND = 3,
            JOINED = 4,
        }

        enum HiddenChannelFilter
        {
            UNHIDDEN = 0,
            HIDDEN = 1,
            HIDDEN_ALLOW_AUTO_UNHIDE = 2,
            HIDDEN_PREVENT_AUTO_UNHIDE = 3,
        }

        class GroupChannelListQueryResultHandler : System.MulticastDelegate
        {
            /*0x150fe14*/ GroupChannelListQueryResultHandler(object object, nint method);
            /*0x150ff44*/ void Invoke(System.Collections.Generic.List<SendBird.GroupChannel> queryResult, SendBird.SendBirdException e);
            /*0x150ff58*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.List<SendBird.GroupChannel> queryResult, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x150ff80*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass49_0
        {
            /*0x10*/ SendBird.GroupChannelListQuery.GroupChannelListQueryResultHandler handler;
            /*0x18*/ SendBird.GroupChannelListQuery <>4__this;

            /*0x150fa44*/ <>c__DisplayClass49_0();
            /*0x150ff8c*/ void <Next>b__0();
            /*0x1510018*/ void <Next>b__1();
            /*0x15100dc*/ void <Next>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass49_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.GroupChannel> channels;
            /*0x20*/ SendBird.GroupChannelListQuery.<> CS$<>8__locals1;

            /*0x1510444*/ <>c__DisplayClass49_1();
            /*0x151044c*/ void <Next>b__3();
            /*0x1510480*/ void <Next>b__4();
        }
    }

    class MessageListQuery
    {
        static /*0x0*/ object syncLock;
        /*0x10*/ bool mLoading;
        /*0x18*/ SendBird.BaseChannel mChannel;

        static /*0x1510f24*/ MessageListQuery();
        /*0x15104b4*/ MessageListQuery(SendBird.BaseChannel channel);
        /*0x15104dc*/ bool IsLoading();
        /*0x1510558*/ void SetLoading(bool tf);
        /*0x15105d8*/ void Next(long messageTimestamp, int limit, bool reverse, SendBird.MessageListQuery.MessageListQueryResult handler);
        /*0x15108ec*/ void Prev(long messageTimestamp, int limit, bool reverse, SendBird.MessageListQuery.MessageListQueryResult handler);
        /*0x1510c00*/ void Load(long messageTimestamp, int prevLimit, int nextLimit, bool reverse, SendBird.MessageListQuery.MessageListQueryResult handler);

        class MessageListQueryResult : System.MulticastDelegate
        {
            /*0x1510f9c*/ MessageListQueryResult(object object, nint method);
            /*0x15110cc*/ void Invoke(System.Collections.Generic.List<SendBird.BaseMessage> queryResult, SendBird.SendBirdException e);
            /*0x15110e0*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.List<SendBird.BaseMessage> queryResult, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1511108*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ SendBird.MessageListQuery.MessageListQueryResult handler;
            /*0x18*/ SendBird.MessageListQuery <>4__this;

            /*0x15108e4*/ <>c__DisplayClass6_0();
            /*0x1511114*/ void <Next>b__0();
            /*0x15111d8*/ void <Next>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass6_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.BaseMessage> messages;
            /*0x20*/ SendBird.MessageListQuery.<> CS$<>8__locals1;

            /*0x1511498*/ <>c__DisplayClass6_1();
            /*0x15114a0*/ void <Next>b__2();
            /*0x15114d4*/ void <Next>b__3();
        }

        class <>c__DisplayClass7_0
        {
            /*0x10*/ SendBird.MessageListQuery.MessageListQueryResult handler;
            /*0x18*/ SendBird.MessageListQuery <>4__this;

            /*0x1510bf8*/ <>c__DisplayClass7_0();
            /*0x1511504*/ void <Prev>b__0();
            /*0x15115c8*/ void <Prev>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass7_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.BaseMessage> messages;
            /*0x20*/ SendBird.MessageListQuery.<> CS$<>8__locals1;

            /*0x1511888*/ <>c__DisplayClass7_1();
            /*0x1511890*/ void <Prev>b__2();
            /*0x15118c4*/ void <Prev>b__3();
        }

        class <>c__DisplayClass8_0
        {
            /*0x10*/ SendBird.MessageListQuery.MessageListQueryResult handler;
            /*0x18*/ SendBird.MessageListQuery <>4__this;

            /*0x1510f1c*/ <>c__DisplayClass8_0();
            /*0x15118f8*/ void <Load>b__0();
            /*0x15119bc*/ void <Load>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass8_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.BaseMessage> messages;
            /*0x20*/ SendBird.MessageListQuery.<> CS$<>8__locals1;

            /*0x1511c7c*/ <>c__DisplayClass8_1();
            /*0x1511c84*/ void <Load>b__2();
            /*0x1511cb8*/ void <Load>b__3();
        }
    }

    class OpenChannel : SendBird.BaseChannel
    {
        static /*0x0*/ object syncLock;
        static /*0x8*/ SafeDictionary<string, SendBird.OpenChannel> sCachedChannels;
        static /*0x10*/ SafeDictionary<string, SendBird.OpenChannel> sEnteredChannels;
        /*0x44*/ int mParticipantCount;
        /*0x48*/ System.Collections.Generic.List<SendBird.User> mOperators;

        static /*0x1514fd4*/ OpenChannel();
        static /*0x1511cec*/ void ClearCache();
        static /*0x1511e0c*/ void ClearEnteredChannels();
        static /*0x1511f2c*/ void RemoveChannelFromCache(string channelUrl);
        static /*0x151205c*/ System.Collections.Generic.Dictionary.ValueCollection<string, SendBird.OpenChannel> GetEnteredChannels();
        static /*0x15123ec*/ SendBird.OpenChannel Upsert(SendBird.SBJson.JsonElement el);
        static /*0x1512964*/ SendBird.OpenChannelListQuery CreateOpenChannelListQuery();
        static /*0x1512a1c*/ void CreateChannel(SendBird.OpenChannel.OpenChannelCreateHandler handler);
        static /*0x1512d6c*/ void CreateChannel(string name, object coverUrlOrImage, string data, SendBird.OpenChannel.OpenChannelCreateHandler handler);
        static /*0x1512df0*/ void CreateChannel(string name, object coverUrlOrImage, string data, System.Collections.Generic.List<SendBird.User> operatorUsers, SendBird.OpenChannel.OpenChannelCreateHandler handler);
        static /*0x1513040*/ void CreateChannel(string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<SendBird.User> operatorUsers, SendBird.OpenChannel.OpenChannelCreateHandler handler);
        static /*0x151329c*/ void CreateChannelWithOperatorUserIds(string name, object coverUrlOrImage, string data, System.Collections.Generic.List<string> operatorUserIds, SendBird.OpenChannel.OpenChannelCreateHandler handler);
        static /*0x1512a84*/ void CreateChannelWithOperatorUserIds(string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<string> operatorUserIds, SendBird.OpenChannel.OpenChannelCreateHandler handler);
        static /*0x15122ec*/ void GetChannelWithoutCache(string channelUrl, SendBird.OpenChannel.OpenChannelGetHandler handler);
        static /*0x1513334*/ void GetChannel(string channelUrl, SendBird.OpenChannel.OpenChannelGetHandler handler);
        /*0x15126b0*/ OpenChannel(SendBird.SBJson.JsonElement el);
        /*0x15120d4*/ void Refresh(SendBird.OpenChannel.OpenChannelRefreshHandler handler);
        /*0x15126b8*/ void Update(SendBird.SBJson.JsonElement el);
        /*0x15126e4*/ void Parse(SendBird.SBJson.JsonElement el);
        /*0x151294c*/ int get_ParticipantCount();
        /*0x1512954*/ void SetParticipantCount(int count);
        /*0x151295c*/ System.Collections.Generic.List<SendBird.User> get_Operators();
        /*0x15135c4*/ void UpdateChannel(string name, object coverUrlOrImage, string data, SendBird.OpenChannel.OpenChannelUpdateHandler handler);
        /*0x15135e4*/ void UpdateChannel(string name, object coverUrlOrImage, string data, System.Collections.Generic.List<SendBird.User> operatorUsers, SendBird.OpenChannel.OpenChannelUpdateHandler handler);
        /*0x1513820*/ void UpdateChannel(string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<SendBird.User> operatorUsers, SendBird.OpenChannel.OpenChannelUpdateHandler handler);
        /*0x15135d4*/ void UpdateChannelWithOperatorUserIds(string name, object coverUrlOrImage, string data, System.Collections.Generic.List<string> operatorUserIds, SendBird.OpenChannel.OpenChannelUpdateHandler handler);
        /*0x1513a60*/ void UpdateChannelWithOperatorUserIds(string name, object coverUrlOrImage, string data, string customType, System.Collections.Generic.List<string> operatorUserIds, SendBird.OpenChannel.OpenChannelUpdateHandler handler);
        /*0x1513d38*/ void Enter(SendBird.OpenChannel.OpenChannelEnterHandler handler);
        /*0x1514094*/ void Exit(SendBird.OpenChannel.OpenChannelExitHandler handler);
        /*0x15141cc*/ SendBird.UserListQuery CreateParticipantListQuery();
        /*0x1514234*/ SendBird.UserListQuery CreateMutedUserListQuery();
        /*0x151429c*/ SendBird.UserListQuery CreateBannedUserListQuery();
        /*0x1514304*/ void BanUser(SendBird.User user, int seconds, SendBird.OpenChannel.OpenChannelBanHandler handler);
        /*0x1514438*/ void BanUserWithUserId(string userId, int seconds, SendBird.OpenChannel.OpenChannelBanHandler handler);
        /*0x1514600*/ void UnbanUser(SendBird.User user, SendBird.OpenChannel.OpenChannelUnbanHandler handler);
        /*0x151471c*/ void UnbanUserWithUserId(string userId, SendBird.OpenChannel.OpenChannelUnbanHandler handler);
        /*0x15148c8*/ void MuteUser(SendBird.User user, SendBird.OpenChannel.OpenChannelMuteHandler handler);
        /*0x15149e4*/ void MuteUserWithUserId(string userId, SendBird.OpenChannel.OpenChannelMuteHandler handler);
        /*0x1514b8c*/ void UnmuteUser(SendBird.User user, SendBird.OpenChannel.OpenChannelUnmuteHandler handler);
        /*0x1514ca8*/ void UnmuteUserWithUserId(string userId, SendBird.OpenChannel.OpenChannelUnmuteHandler handler);
        /*0x1514e50*/ bool IsOperator(SendBird.User user);
        /*0x1514e64*/ bool IsOperatorWithUserId(string userId);

        class OpenChannelUpdateHandler : System.MulticastDelegate
        {
            /*0x15150c4*/ OpenChannelUpdateHandler(object object, nint method);
            /*0x15151f4*/ void Invoke(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1515208*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1515230*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelRefreshHandler : System.MulticastDelegate
        {
            /*0x151523c*/ OpenChannelRefreshHandler(object object, nint method);
            /*0x1515368*/ void Invoke(SendBird.SendBirdException e);
            /*0x151537c*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x151539c*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelEnterHandler : System.MulticastDelegate
        {
            /*0x15153a8*/ OpenChannelEnterHandler(object object, nint method);
            /*0x15154d4*/ void Invoke(SendBird.SendBirdException e);
            /*0x15154e8*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1515508*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelExitHandler : System.MulticastDelegate
        {
            /*0x1515514*/ OpenChannelExitHandler(object object, nint method);
            /*0x1515640*/ void Invoke(SendBird.SendBirdException e);
            /*0x1515654*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1515674*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelGetHandler : System.MulticastDelegate
        {
            /*0x15121bc*/ OpenChannelGetHandler(object object, nint method);
            /*0x1515680*/ void Invoke(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1515694*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x15156bc*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelCreateHandler : System.MulticastDelegate
        {
            /*0x15156c8*/ OpenChannelCreateHandler(object object, nint method);
            /*0x15157f8*/ void Invoke(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x151580c*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1515834*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelBanHandler : System.MulticastDelegate
        {
            /*0x1515840*/ OpenChannelBanHandler(object object, nint method);
            /*0x151596c*/ void Invoke(SendBird.SendBirdException e);
            /*0x1515980*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x15159a0*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelUnbanHandler : System.MulticastDelegate
        {
            /*0x15159ac*/ OpenChannelUnbanHandler(object object, nint method);
            /*0x1515ad8*/ void Invoke(SendBird.SendBirdException e);
            /*0x1515aec*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1515b0c*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelMuteHandler : System.MulticastDelegate
        {
            /*0x1515b18*/ OpenChannelMuteHandler(object object, nint method);
            /*0x1515c44*/ void Invoke(SendBird.SendBirdException e);
            /*0x1515c58*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1515c78*/ void EndInvoke(System.IAsyncResult result);
        }

        class OpenChannelUnmuteHandler : System.MulticastDelegate
        {
            /*0x1515c84*/ OpenChannelUnmuteHandler(object object, nint method);
            /*0x1515db0*/ void Invoke(SendBird.SendBirdException e);
            /*0x1515dc4*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1515de4*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelRefreshHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x15121b4*/ <>c__DisplayClass9_0();
            /*0x1515df0*/ void <Refresh>b__0(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1515f4c*/ void <Refresh>b__2();
        }

        class <>c__DisplayClass9_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x1515f44*/ <>c__DisplayClass9_1();
            /*0x1515f74*/ void <Refresh>b__1();
        }

        class <>c__DisplayClass25_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelCreateHandler handler;

            /*0x1513324*/ <>c__DisplayClass25_0();
            /*0x1515fa4*/ void <CreateChannelWithOperatorUserIds>b__0();
            /*0x1516068*/ void <CreateChannelWithOperatorUserIds>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass25_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel channel;
            /*0x20*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x15161d4*/ <>c__DisplayClass25_1();
            /*0x15161dc*/ void <CreateChannelWithOperatorUserIds>b__2();
            /*0x1516210*/ void <CreateChannelWithOperatorUserIds>b__3();
        }

        class <>c__DisplayClass26_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelGetHandler handler;
            /*0x18*/ string channelUrl;

            /*0x151332c*/ <>c__DisplayClass26_0();
            /*0x1516244*/ void <GetChannelWithoutCache>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass27_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelGetHandler handler;

            /*0x15135b4*/ <>c__DisplayClass27_0();
            /*0x1516344*/ void <GetChannel>b__0();
            /*0x1516408*/ void <GetChannel>b__1(SendBird.OpenChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass27_1
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x15135bc*/ <>c__DisplayClass27_1();
            /*0x151650c*/ void <GetChannel>b__2();
        }

        class <>c__DisplayClass27_2
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.SendBirdException e;
            /*0x20*/ SendBird.OpenChannel.<> CS$<>8__locals2;

            /*0x1516504*/ <>c__DisplayClass27_2();
            /*0x1516540*/ void <GetChannel>b__3();
        }

        class <>c__DisplayClass32_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelUpdateHandler handler;

            /*0x1513d30*/ <>c__DisplayClass32_0();
            /*0x1516570*/ void <UpdateChannelWithOperatorUserIds>b__0();
            /*0x1516634*/ void <UpdateChannelWithOperatorUserIds>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass32_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel channel;
            /*0x20*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x15167a0*/ <>c__DisplayClass32_1();
            /*0x15167a8*/ void <UpdateChannelWithOperatorUserIds>b__2();
            /*0x15167dc*/ void <UpdateChannelWithOperatorUserIds>b__3();
        }

        class <>c__DisplayClass33_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelEnterHandler handler;
            /*0x18*/ SendBird.OpenChannel <>4__this;
            /*0x20*/ SendBird.MyAction <>9__2;

            /*0x1513e68*/ <>c__DisplayClass33_0();
            /*0x1516810*/ void <Enter>b__0(SendBird.Command acked, SendBird.SendBirdException e);
            /*0x1516a5c*/ void <Enter>b__2();
        }

        class <>c__DisplayClass33_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x1516a54*/ <>c__DisplayClass33_1();
            /*0x1516a84*/ void <Enter>b__1();
        }

        class <>c__DisplayClass34_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelExitHandler handler;
            /*0x18*/ SendBird.OpenChannel <>4__this;
            /*0x20*/ SendBird.MyAction <>9__2;

            /*0x15141c4*/ <>c__DisplayClass34_0();
            /*0x1516ab4*/ void <Exit>b__0(SendBird.Command acked, SendBird.SendBirdException e);
            /*0x1516cf8*/ void <Exit>b__2();
        }

        class <>c__DisplayClass34_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x1516cf0*/ <>c__DisplayClass34_1();
            /*0x1516d20*/ void <Exit>b__1();
        }

        class <>c__DisplayClass40_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelBanHandler handler;

            /*0x1514430*/ <>c__DisplayClass40_0();
            /*0x1516d50*/ void <BanUser>b__0();
        }

        class <>c__DisplayClass41_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelBanHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x15145f8*/ <>c__DisplayClass41_0();
            /*0x1516e10*/ void <BanUserWithUserId>b__0();
            /*0x1516ed0*/ void <BanUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x151702c*/ void <BanUserWithUserId>b__3();
        }

        class <>c__DisplayClass41_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x1517024*/ <>c__DisplayClass41_1();
            /*0x1517054*/ void <BanUserWithUserId>b__2();
        }

        class <>c__DisplayClass42_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelUnbanHandler handler;

            /*0x1514714*/ <>c__DisplayClass42_0();
            /*0x1517084*/ void <UnbanUser>b__0();
        }

        class <>c__DisplayClass43_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelUnbanHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x15148c0*/ <>c__DisplayClass43_0();
            /*0x1517144*/ void <UnbanUserWithUserId>b__0();
            /*0x1517204*/ void <UnbanUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1517360*/ void <UnbanUserWithUserId>b__3();
        }

        class <>c__DisplayClass43_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x1517358*/ <>c__DisplayClass43_1();
            /*0x1517388*/ void <UnbanUserWithUserId>b__2();
        }

        class <>c__DisplayClass44_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelMuteHandler handler;

            /*0x15149dc*/ <>c__DisplayClass44_0();
            /*0x15173b8*/ void <MuteUser>b__0();
        }

        class <>c__DisplayClass45_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelMuteHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x1514b84*/ <>c__DisplayClass45_0();
            /*0x1517478*/ void <MuteUserWithUserId>b__0();
            /*0x1517538*/ void <MuteUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1517694*/ void <MuteUserWithUserId>b__3();
        }

        class <>c__DisplayClass45_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x151768c*/ <>c__DisplayClass45_1();
            /*0x15176bc*/ void <MuteUserWithUserId>b__2();
        }

        class <>c__DisplayClass46_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelUnmuteHandler handler;

            /*0x1514ca0*/ <>c__DisplayClass46_0();
            /*0x15176ec*/ void <UnmuteUser>b__0();
        }

        class <>c__DisplayClass47_0
        {
            /*0x10*/ SendBird.OpenChannel.OpenChannelUnmuteHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x1514e48*/ <>c__DisplayClass47_0();
            /*0x15177ac*/ void <UnmuteUserWithUserId>b__0();
            /*0x151786c*/ void <UnmuteUserWithUserId>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15179c8*/ void <UnmuteUserWithUserId>b__3();
        }

        class <>c__DisplayClass47_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.OpenChannel.<> CS$<>8__locals1;

            /*0x15179c0*/ <>c__DisplayClass47_1();
            /*0x15179f0*/ void <UnmuteUserWithUserId>b__2();
        }
    }

    class OpenChannelListQuery
    {
        static /*0x0*/ object syncLock;
        /*0x10*/ string mToken;
        /*0x18*/ bool mHasNext;
        /*0x1c*/ int mLimit;
        /*0x20*/ string mNameKeyword;
        /*0x28*/ string mUrlKeyword;
        /*0x30*/ bool mLoading;

        static /*0x1517e68*/ OpenChannelListQuery();
        /*0x15129bc*/ OpenChannelListQuery();
        /*0x1517a20*/ void set_Limit(int value);
        /*0x1517a28*/ int get_Limit();
        /*0x1517a30*/ void set_NameKeyword(string value);
        /*0x1517a38*/ string get_NameKeyword();
        /*0x1517a40*/ void set_UrlKeyword(string value);
        /*0x1517a48*/ string get_UrlKeyword();
        /*0x1517a50*/ bool HasNext();
        /*0x1517a58*/ bool IsLoading();
        /*0x1517ad4*/ void SetLoading(bool tf);
        /*0x1517b54*/ void Next(SendBird.OpenChannelListQuery.OpenChannelListQueryResultHandler handler);

        class OpenChannelListQueryResultHandler : System.MulticastDelegate
        {
            /*0x1517ee0*/ OpenChannelListQueryResultHandler(object object, nint method);
            /*0x1518010*/ void Invoke(System.Collections.Generic.List<SendBird.OpenChannel> queryResult, SendBird.SendBirdException e);
            /*0x1518024*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.List<SendBird.OpenChannel> queryResult, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x151804c*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ SendBird.OpenChannelListQuery.OpenChannelListQueryResultHandler handler;
            /*0x18*/ SendBird.OpenChannelListQuery <>4__this;

            /*0x1517e60*/ <>c__DisplayClass20_0();
            /*0x1518058*/ void <Next>b__0();
            /*0x15180e4*/ void <Next>b__1();
            /*0x15181a8*/ void <Next>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass20_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.OpenChannel> channels;
            /*0x20*/ SendBird.OpenChannelListQuery.<> CS$<>8__locals1;

            /*0x1518508*/ <>c__DisplayClass20_1();
            /*0x1518510*/ void <Next>b__3();
            /*0x1518544*/ void <Next>b__4();
        }
    }

    class PreviousMessageListQuery
    {
        static /*0x0*/ object syncLock;
        /*0x10*/ bool mLoading;
        /*0x18*/ SendBird.BaseChannel mChannel;
        /*0x20*/ long mMessageTimestamp;
        /*0x28*/ bool mHasMore;
        /*0x2c*/ int mLimit;
        /*0x30*/ bool mReverse;

        static /*0x15189ec*/ PreviousMessageListQuery();
        /*0x1518578*/ PreviousMessageListQuery(SendBird.BaseChannel channel);
        /*0x15185b8*/ bool HasMore();
        /*0x15185c0*/ bool IsLoading();
        /*0x151863c*/ void SetLoading(bool tf);
        /*0x15186bc*/ void Load(SendBird.PreviousMessageListQuery.MessageListQueryResult handler);
        /*0x15186d0*/ void Load(int limit, bool reverse, SendBird.PreviousMessageListQuery.MessageListQueryResult handler);

        class MessageListQueryResult : System.MulticastDelegate
        {
            /*0x1518a64*/ MessageListQueryResult(object object, nint method);
            /*0x1518b94*/ void Invoke(System.Collections.Generic.List<SendBird.BaseMessage> queryResult, SendBird.SendBirdException e);
            /*0x1518ba8*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.List<SendBird.BaseMessage> queryResult, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1518bd0*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ SendBird.PreviousMessageListQuery.MessageListQueryResult handler;
            /*0x18*/ SendBird.PreviousMessageListQuery <>4__this;

            /*0x15189e4*/ <>c__DisplayClass12_0();
            /*0x1518bdc*/ void <Load>b__0();
            /*0x1518ca0*/ void <Load>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass12_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.BaseMessage> messages;
            /*0x20*/ SendBird.PreviousMessageListQuery.<> CS$<>8__locals1;

            /*0x1518fb8*/ <>c__DisplayClass12_1();
            /*0x1518fc0*/ void <Load>b__2();
            /*0x1518ff4*/ void <Load>b__3();
        }
    }

    class ReadStatus
    {
        /*0x10*/ SendBird.User mReader;
        /*0x18*/ long mTimestamp;
        /*0x20*/ string mChannelUrl;
        /*0x28*/ string mChannelType;

        /*0x1519028*/ ReadStatus(SendBird.SBJson.JsonElement el);
        /*0x1519200*/ ReadStatus(SendBird.User user, long timestamp);
        /*0x151922c*/ long get_Timestamp();
        /*0x1519234*/ SendBird.User get_Reader();
        /*0x151923c*/ string get_ChannelUrl();
        /*0x1519244*/ string get_ChannelType();
    }

    class SendBirdClient
    {
        static /*0x0*/ string VERSION;
        static /*0x8*/ int CMD_ACK_TIMEOUT;
        static /*0xc*/ bool DEBUG_HOST;
        static /*0x10*/ string DEBUG_WS_HOST;
        static /*0x18*/ string DEBUG_API_HOST;
        static /*0x20*/ SendBird.SendBirdClient.LogDelegate Log;
        static /*0x28*/ SendBird.SendBirdClient sInstance;
        static /*0x30*/ int LOGGER_NONE;
        static /*0x34*/ int LOGGER_INFO;
        /*0x10*/ string mAppId;
        /*0x18*/ string mPushToken;
        /*0x20*/ SendBird.WSClient mWSClient;
        /*0x28*/ SendBird.User mCurrentUser;
        /*0x30*/ int mReconnectDelay;
        /*0x34*/ int mReconnectCount;
        /*0x38*/ SendBird.CountDownTimer mReconnectTimer;
        /*0x40*/ SendBird.CountDownTimer mLoginTimer;
        /*0x48*/ SendBird.CountDownTimer mGlobalTimer;
        /*0x50*/ SendBird.SendBirdException mLoginException;
        /*0x58*/ int tickCount;
        /*0x60*/ SafeDictionary<string, System.Collections.Generic.Dictionary<string, object>> mAckStateMap;
        /*0x68*/ SafeDictionary<string, SendBird.SendBirdClient.ChannelHandler> mChannelHandlers;
        /*0x70*/ SafeDictionary<string, SendBird.SendBirdClient.ConnectionHandler> mConnectionHandlers;
        /*0x78*/ int MaxUnreadCountOnSuperGroup;

        static /*0x151f1c8*/ SendBirdClient();
        static /*0x151924c*/ string get_OSVersion();
        static /*0x1519270*/ string get_SDKVersion();
        static /*0x15192c8*/ string get_ApplicationId();
        static /*0x1519324*/ int get_LoggerLevel();
        static /*0x151937c*/ void set_LoggerLevel(int value);
        static /*0x15196dc*/ int getMaxUnreadMessageCountOnSuperGroup();
        static /*0x150d99c*/ SendBird.SendBirdClient get_Instance();
        static /*0x1519738*/ bool IsInitialized();
        static /*0x150ca40*/ void RunOnUIThread(SendBird.MyAction action);
        static /*0x15199bc*/ SendBird.User get_CurrentUser();
        static /*0x151a1a8*/ void SetupUnityDispatcher(UnityEngine.GameObject go);
        static /*0x151a270*/ System.Collections.IEnumerator get_StartUnityDispatcher();
        static /*0x151a304*/ bool Init(string appId);
        static /*0x1519890*/ SendBird.SendBirdClient.ConnectionState GetConnectionState();
        static /*0x151a8a4*/ void Connect(string userId, SendBird.SendBirdClient.ConnectHandler handler);
        static /*0x151a90c*/ void Connect(string userId, string accessToken, SendBird.SendBirdClient.ConnectHandler handler);
        static /*0x151adec*/ bool Reconnect();
        static /*0x151b430*/ void AddChannelHandler(string identifier, SendBird.SendBirdClient.ChannelHandler handler);
        static /*0x151b4d4*/ SendBird.SendBirdClient.ChannelHandler RemoveChannelHandler(string identifier);
        static /*0x151b578*/ void AddConnectionHandler(string identifier, SendBird.SendBirdClient.ConnectionHandler handler);
        static /*0x151b61c*/ SendBird.SendBirdClient.ConnectionHandler RemoveConnectionHandler(string identifier);
        static /*0x151aec8*/ void ReconnectWS(string userId, bool callStart);
        static /*0x151ab04*/ void ConnectWS(string userId, string accessToken, SendBird.SendBirdClient.ConnectHandler handler);
        static /*0x151b6c8*/ void Disconnect(SendBird.SendBirdClient.DisconnectHandler handler);
        static /*0x151a41c*/ void Disconnect(bool logout, SendBird.SendBirdClient.DisconnectHandler handler);
        static /*0x151b720*/ SendBird.UserListQuery CreateUserListQuery();
        static /*0x151b780*/ SendBird.UserListQuery CreateUserListQuery(SendBird.UserListQuery.QueryType queryType);
        static /*0x151b7e4*/ SendBird.UserListQuery CreateUserListQuery(System.Collections.Generic.List<string> userIds);
        static /*0x151b84c*/ SendBird.UserListQuery CreateBlockedUserListQuery();
        static /*0x151b8ac*/ void UpdateCurrentUserInfoWithProfileImage(string nickname, SendBird.SBFile profileImage, SendBird.SendBirdClient.UserInfoUpdateHandler handler);
        static /*0x151ba90*/ void UpdateCurrentUserInfo(string nickname, string profileUrl, SendBird.SendBirdClient.UserInfoUpdateHandler handler);
        static /*0x151bc74*/ string GetPendingPushToken();
        static /*0x151bcd0*/ void RegisterAPNSPushTokenForCurrentUser(string apnsRegToken, SendBird.SendBirdClient.RegisterPushTokenWithStatusHandler handler);
        static /*0x151bee8*/ void UnregisterAPNSPushTokenForCurrentUser(string apnsRegToken, SendBird.SendBirdClient.UnregisterPushTokenHandler handler);
        static /*0x151c0e8*/ void RegisterFCMPushTokenForCurrentUser(string fcmRegToken, SendBird.SendBirdClient.RegisterPushTokenWithStatusHandler handler);
        static /*0x151c300*/ void UnregisterFCMPushTokenForCurrentUser(string fcmRegToken, SendBird.SendBirdClient.UnregisterPushTokenHandler handler);
        static /*0x151c500*/ void UnregisterPushTokenAllForCurrentUser(SendBird.SendBirdClient.UnregisterPushTokenHandler handler);
        static /*0x151c6c4*/ void SetDoNotDisturb(bool doNotDisturbOn, int startHour, int startMin, int endHour, int endMin, string timezone, SendBird.SendBirdClient.SetDoNotDisturbHandler handler);
        static /*0x151c930*/ void GetDoNotDisturb(SendBird.SendBirdClient.GetDoNotDisturbHandler handler);
        static /*0x151caf4*/ void BlockUser(SendBird.User userToBlock, SendBird.SendBirdClient.UserBlockHandler handler);
        static /*0x151cc14*/ void BlockUserWithUserId(string userIdToBlock, SendBird.SendBirdClient.UserBlockHandler handler);
        static /*0x151ce14*/ void UnblockUser(SendBird.User blockedUser, SendBird.SendBirdClient.UserUnblockHandler handler);
        static /*0x151cf34*/ void UnblockUserWithUserId(string blockedUserId, SendBird.SendBirdClient.UserUnblockHandler handler);
        static /*0x151efd8*/ void SetChannelInvitationPreference(bool autoAccept, SendBird.SendBirdClient.SetChannelInvitationPreferenceHandler handler);
        static /*0x151f0d4*/ void GetChannelInvitationPreference(SendBird.SendBirdClient.GetChannelInvitationPreferenceHandler handler);
        /*0x15193d8*/ SendBirdClient(string appId);
        /*0x1519660*/ void SetAppId(string appId, bool resetHosts);
        /*0x1519798*/ bool SetApplicationId(string appId);
        /*0x1513e70*/ void SendCommand(SendBird.Command cmd, SendBird.Command.SendCommandHandler handler);
        /*0x1519e3c*/ void StartGlobalTimer();
        /*0x151d134*/ void MessageReceived(string message);
        /*0x151e87c*/ void ProcessChannelEvent(SendBird.Command cmd);
        /*0x1519a20*/ void StartAckTimer(SendBird.Command command, SendBird.Command.SendCommandHandler handler);
        /*0x151e80c*/ System.Collections.Generic.Dictionary<string, object> GetAckInfo(string requestId);
        /*0x151f4ac*/ void <StartGlobalTimer>b__46_4(int timeout, int elapsed);

        enum ConnectionState
        {
            CONNECTING = 0,
            OPEN = 1,
            CLOSING = 2,
            CLOSED = 3,
        }

        class LogDelegate : System.MulticastDelegate
        {
            /*0x151f77c*/ LogDelegate(object object, nint method);
            /*0x151f850*/ void Invoke(string message);
            /*0x151f864*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
            /*0x151f884*/ void EndInvoke(System.IAsyncResult result);
        }

        class ConnectHandler : System.MulticastDelegate
        {
            /*0x151f890*/ ConnectHandler(object object, nint method);
            /*0x151f9c0*/ void Invoke(SendBird.User user, SendBird.SendBirdException e);
            /*0x151f9d4*/ System.IAsyncResult BeginInvoke(SendBird.User user, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x151f9fc*/ void EndInvoke(System.IAsyncResult result);
        }

        class ChannelHandler
        {
            /*0x10*/ SendBird.SendBirdClient.ChannelHandler.OnMessageReceivedDelegate OnMessageReceived;
            /*0x18*/ SendBird.SendBirdClient.ChannelHandler.OnMessageUpdatedDelegate OnMessageUpdated;
            /*0x20*/ SendBird.SendBirdClient.ChannelHandler.OnDeliveryReceiptUpdatedDelegate OnDeliveryReceiptUpdated;
            /*0x28*/ SendBird.SendBirdClient.ChannelHandler.OnMessageDeletedDelegate OnMessageDeleted;
            /*0x30*/ SendBird.SendBirdClient.ChannelHandler.OnChannelChangedDelegate OnChannelChanged;
            /*0x38*/ SendBird.SendBirdClient.ChannelHandler.OnChannelDeletedDelegate OnChannelDeleted;
            /*0x40*/ SendBird.SendBirdClient.ChannelHandler.OnReadReceiptUpdatedDelegate OnReadReceiptUpdated;
            /*0x48*/ SendBird.SendBirdClient.ChannelHandler.OnTypingStatusUpdatedDelegate OnTypingStatusUpdated;
            /*0x50*/ SendBird.SendBirdClient.ChannelHandler.OnUserJoinedDelegate OnUserJoined;
            /*0x58*/ SendBird.SendBirdClient.ChannelHandler.OnUserReceivedInvitationDelegate OnUserReceivedInvitation;
            /*0x60*/ SendBird.SendBirdClient.ChannelHandler.OnUserDeclinedInvitationDelegate OnUserDeclinedInvitation;
            /*0x68*/ SendBird.SendBirdClient.ChannelHandler.OnUserLeftDelegate OnUserLeft;
            /*0x70*/ SendBird.SendBirdClient.ChannelHandler.OnUserEnteredDelegate OnUserEntered;
            /*0x78*/ SendBird.SendBirdClient.ChannelHandler.OnUserExitedDelegate OnUserExited;
            /*0x80*/ SendBird.SendBirdClient.ChannelHandler.OnUserMutedDelegate OnUserMuted;
            /*0x88*/ SendBird.SendBirdClient.ChannelHandler.OnUserUnmutedDelegate OnUserUnmuted;
            /*0x90*/ SendBird.SendBirdClient.ChannelHandler.OnUserBannedDelegate OnUserBanned;
            /*0x98*/ SendBird.SendBirdClient.ChannelHandler.OnUserUnbannedDelegate OnUserUnbanned;
            /*0xa0*/ SendBird.SendBirdClient.ChannelHandler.OnChannelFrozenDelegate OnChannelFrozen;
            /*0xa8*/ SendBird.SendBirdClient.ChannelHandler.OnChannelUnfrozenDelegate OnChannelUnfrozen;
            /*0xb0*/ SendBird.SendBirdClient.ChannelHandler.OnChannelHiddenDelegate OnChannelHidden;

            /*0x151fa08*/ ChannelHandler();

            class OnMessageReceivedDelegate : System.MulticastDelegate
            {
                /*0x152058c*/ OnMessageReceivedDelegate(object object, nint method);
                /*0x1521e08*/ void Invoke(SendBird.BaseChannel channel, SendBird.BaseMessage message);
                /*0x1521e1c*/ System.IAsyncResult BeginInvoke(SendBird.BaseChannel channel, SendBird.BaseMessage message, System.AsyncCallback callback, object object);
                /*0x1521e44*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnMessageUpdatedDelegate : System.MulticastDelegate
            {
                /*0x15206bc*/ OnMessageUpdatedDelegate(object object, nint method);
                /*0x1521e50*/ void Invoke(SendBird.BaseChannel channel, SendBird.BaseMessage message);
                /*0x1521e64*/ System.IAsyncResult BeginInvoke(SendBird.BaseChannel channel, SendBird.BaseMessage message, System.AsyncCallback callback, object object);
                /*0x1521e8c*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnDeliveryReceiptUpdatedDelegate : System.MulticastDelegate
            {
                /*0x15207ec*/ OnDeliveryReceiptUpdatedDelegate(object object, nint method);
                /*0x1521e98*/ void Invoke(SendBird.GroupChannel channel);
                /*0x1521eac*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, System.AsyncCallback callback, object object);
                /*0x1521ecc*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnMessageDeletedDelegate : System.MulticastDelegate
            {
                /*0x1520918*/ OnMessageDeletedDelegate(object object, nint method);
                /*0x1521ed8*/ void Invoke(SendBird.BaseChannel channel, long msgId);
                /*0x1521eec*/ System.IAsyncResult BeginInvoke(SendBird.BaseChannel channel, long msgId, System.AsyncCallback callback, object object);
                /*0x1521f7c*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnChannelChangedDelegate : System.MulticastDelegate
            {
                /*0x1520a48*/ OnChannelChangedDelegate(object object, nint method);
                /*0x1521f88*/ void Invoke(SendBird.BaseChannel channel);
                /*0x1521f9c*/ System.IAsyncResult BeginInvoke(SendBird.BaseChannel channel, System.AsyncCallback callback, object object);
                /*0x1521fbc*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnChannelDeletedDelegate : System.MulticastDelegate
            {
                /*0x1520b74*/ OnChannelDeletedDelegate(object object, nint method);
                /*0x1521fc8*/ void Invoke(string channelUrl, SendBird.BaseChannel.ChannelType channelType);
                /*0x1521fdc*/ System.IAsyncResult BeginInvoke(string channelUrl, SendBird.BaseChannel.ChannelType channelType, System.AsyncCallback callback, object object);
                /*0x1522070*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnReadReceiptUpdatedDelegate : System.MulticastDelegate
            {
                /*0x1520c4c*/ OnReadReceiptUpdatedDelegate(object object, nint method);
                /*0x152207c*/ void Invoke(SendBird.GroupChannel channel);
                /*0x1522090*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, System.AsyncCallback callback, object object);
                /*0x15220b0*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnTypingStatusUpdatedDelegate : System.MulticastDelegate
            {
                /*0x1520d78*/ OnTypingStatusUpdatedDelegate(object object, nint method);
                /*0x15220bc*/ void Invoke(SendBird.GroupChannel channel);
                /*0x15220d0*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, System.AsyncCallback callback, object object);
                /*0x15220f0*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserJoinedDelegate : System.MulticastDelegate
            {
                /*0x1520ea4*/ OnUserJoinedDelegate(object object, nint method);
                /*0x15220fc*/ void Invoke(SendBird.GroupChannel channel, SendBird.User user);
                /*0x1522110*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x1522138*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserReceivedInvitationDelegate : System.MulticastDelegate
            {
                /*0x1520fd4*/ OnUserReceivedInvitationDelegate(object object, nint method);
                /*0x1522144*/ void Invoke(SendBird.GroupChannel channel, SendBird.User inviter, System.Collections.Generic.List<SendBird.User> invitees);
                /*0x1522158*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, SendBird.User inviter, System.Collections.Generic.List<SendBird.User> invitees, System.AsyncCallback callback, object object);
                /*0x1522184*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserDeclinedInvitationDelegate : System.MulticastDelegate
            {
                /*0x1521104*/ OnUserDeclinedInvitationDelegate(object object, nint method);
                /*0x1522190*/ void Invoke(SendBird.GroupChannel channel, SendBird.User inviter, SendBird.User invitee);
                /*0x15221a4*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, SendBird.User inviter, SendBird.User invitee, System.AsyncCallback callback, object object);
                /*0x15221d0*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserLeftDelegate : System.MulticastDelegate
            {
                /*0x1521234*/ OnUserLeftDelegate(object object, nint method);
                /*0x15221dc*/ void Invoke(SendBird.GroupChannel channel, SendBird.User user);
                /*0x15221f0*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x1522218*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserEnteredDelegate : System.MulticastDelegate
            {
                /*0x1521364*/ OnUserEnteredDelegate(object object, nint method);
                /*0x1522224*/ void Invoke(SendBird.OpenChannel channel, SendBird.User user);
                /*0x1522238*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x1522260*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserExitedDelegate : System.MulticastDelegate
            {
                /*0x1521494*/ OnUserExitedDelegate(object object, nint method);
                /*0x152226c*/ void Invoke(SendBird.OpenChannel channel, SendBird.User user);
                /*0x1522280*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x15222a8*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserMutedDelegate : System.MulticastDelegate
            {
                /*0x15215c4*/ OnUserMutedDelegate(object object, nint method);
                /*0x15222b4*/ void Invoke(SendBird.OpenChannel channel, SendBird.User user);
                /*0x15222c8*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x15222f0*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserUnmutedDelegate : System.MulticastDelegate
            {
                /*0x15216f4*/ OnUserUnmutedDelegate(object object, nint method);
                /*0x15222fc*/ void Invoke(SendBird.OpenChannel channel, SendBird.User user);
                /*0x1522310*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x1522338*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserBannedDelegate : System.MulticastDelegate
            {
                /*0x1521824*/ OnUserBannedDelegate(object object, nint method);
                /*0x1522344*/ void Invoke(SendBird.BaseChannel channel, SendBird.User user);
                /*0x1522358*/ System.IAsyncResult BeginInvoke(SendBird.BaseChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x1522380*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnUserUnbannedDelegate : System.MulticastDelegate
            {
                /*0x1521954*/ OnUserUnbannedDelegate(object object, nint method);
                /*0x152238c*/ void Invoke(SendBird.BaseChannel channel, SendBird.User user);
                /*0x15223a0*/ System.IAsyncResult BeginInvoke(SendBird.BaseChannel channel, SendBird.User user, System.AsyncCallback callback, object object);
                /*0x15223c8*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnChannelFrozenDelegate : System.MulticastDelegate
            {
                /*0x1521a84*/ OnChannelFrozenDelegate(object object, nint method);
                /*0x15223d4*/ void Invoke(SendBird.OpenChannel channel);
                /*0x15223e8*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, System.AsyncCallback callback, object object);
                /*0x1522408*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnChannelUnfrozenDelegate : System.MulticastDelegate
            {
                /*0x1521bb0*/ OnChannelUnfrozenDelegate(object object, nint method);
                /*0x1522414*/ void Invoke(SendBird.OpenChannel channel);
                /*0x1522428*/ System.IAsyncResult BeginInvoke(SendBird.OpenChannel channel, System.AsyncCallback callback, object object);
                /*0x1522448*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnChannelHiddenDelegate : System.MulticastDelegate
            {
                /*0x1521cdc*/ OnChannelHiddenDelegate(object object, nint method);
                /*0x1522454*/ void Invoke(SendBird.GroupChannel channel);
                /*0x1522468*/ System.IAsyncResult BeginInvoke(SendBird.GroupChannel channel, System.AsyncCallback callback, object object);
                /*0x1522488*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ SendBird.SendBirdClient.ChannelHandler.<> <>9;
                static /*0x8*/ SendBird.SendBirdClient.ChannelHandler.OnMessageReceivedDelegate <>9__42_0;
                static /*0x10*/ SendBird.SendBirdClient.ChannelHandler.OnMessageUpdatedDelegate <>9__42_1;
                static /*0x18*/ SendBird.SendBirdClient.ChannelHandler.OnDeliveryReceiptUpdatedDelegate <>9__42_2;
                static /*0x20*/ SendBird.SendBirdClient.ChannelHandler.OnMessageDeletedDelegate <>9__42_3;
                static /*0x28*/ SendBird.SendBirdClient.ChannelHandler.OnChannelChangedDelegate <>9__42_4;
                static /*0x30*/ SendBird.SendBirdClient.ChannelHandler.OnChannelDeletedDelegate <>9__42_5;
                static /*0x38*/ SendBird.SendBirdClient.ChannelHandler.OnReadReceiptUpdatedDelegate <>9__42_6;
                static /*0x40*/ SendBird.SendBirdClient.ChannelHandler.OnTypingStatusUpdatedDelegate <>9__42_7;
                static /*0x48*/ SendBird.SendBirdClient.ChannelHandler.OnUserJoinedDelegate <>9__42_8;
                static /*0x50*/ SendBird.SendBirdClient.ChannelHandler.OnUserReceivedInvitationDelegate <>9__42_9;
                static /*0x58*/ SendBird.SendBirdClient.ChannelHandler.OnUserDeclinedInvitationDelegate <>9__42_10;
                static /*0x60*/ SendBird.SendBirdClient.ChannelHandler.OnUserLeftDelegate <>9__42_11;
                static /*0x68*/ SendBird.SendBirdClient.ChannelHandler.OnUserEnteredDelegate <>9__42_12;
                static /*0x70*/ SendBird.SendBirdClient.ChannelHandler.OnUserExitedDelegate <>9__42_13;
                static /*0x78*/ SendBird.SendBirdClient.ChannelHandler.OnUserMutedDelegate <>9__42_14;
                static /*0x80*/ SendBird.SendBirdClient.ChannelHandler.OnUserUnmutedDelegate <>9__42_15;
                static /*0x88*/ SendBird.SendBirdClient.ChannelHandler.OnUserBannedDelegate <>9__42_16;
                static /*0x90*/ SendBird.SendBirdClient.ChannelHandler.OnUserUnbannedDelegate <>9__42_17;
                static /*0x98*/ SendBird.SendBirdClient.ChannelHandler.OnChannelFrozenDelegate <>9__42_18;
                static /*0xa0*/ SendBird.SendBirdClient.ChannelHandler.OnChannelUnfrozenDelegate <>9__42_19;
                static /*0xa8*/ SendBird.SendBirdClient.ChannelHandler.OnChannelHiddenDelegate <>9__42_20;

                static /*0x1522494*/ <>c();
                /*0x15224f8*/ <>c();
                /*0x1522500*/ void <.ctor>b__42_0(SendBird.BaseChannel <p0>, SendBird.BaseMessage <p1>);
                /*0x1522504*/ void <.ctor>b__42_1(SendBird.BaseChannel <p0>, SendBird.BaseMessage <p1>);
                /*0x1522508*/ void <.ctor>b__42_2(SendBird.GroupChannel <p0>);
                /*0x152250c*/ void <.ctor>b__42_3(SendBird.BaseChannel <p0>, long <p1>);
                /*0x1522510*/ void <.ctor>b__42_4(SendBird.BaseChannel <p0>);
                /*0x1522514*/ void <.ctor>b__42_5(string <p0>, SendBird.BaseChannel.ChannelType <p1>);
                /*0x1522518*/ void <.ctor>b__42_6(SendBird.GroupChannel <p0>);
                /*0x152251c*/ void <.ctor>b__42_7(SendBird.GroupChannel <p0>);
                /*0x1522520*/ void <.ctor>b__42_8(SendBird.GroupChannel <p0>, SendBird.User <p1>);
                /*0x1522524*/ void <.ctor>b__42_9(SendBird.GroupChannel <p0>, SendBird.User <p1>, System.Collections.Generic.List<SendBird.User> <p2>);
                /*0x1522528*/ void <.ctor>b__42_10(SendBird.GroupChannel <p0>, SendBird.User <p1>, SendBird.User <p2>);
                /*0x152252c*/ void <.ctor>b__42_11(SendBird.GroupChannel <p0>, SendBird.User <p1>);
                /*0x1522530*/ void <.ctor>b__42_12(SendBird.OpenChannel <p0>, SendBird.User <p1>);
                /*0x1522534*/ void <.ctor>b__42_13(SendBird.OpenChannel <p0>, SendBird.User <p1>);
                /*0x1522538*/ void <.ctor>b__42_14(SendBird.OpenChannel <p0>, SendBird.User <p1>);
                /*0x152253c*/ void <.ctor>b__42_15(SendBird.OpenChannel <p0>, SendBird.User <p1>);
                /*0x1522540*/ void <.ctor>b__42_16(SendBird.BaseChannel <p0>, SendBird.User <p1>);
                /*0x1522544*/ void <.ctor>b__42_17(SendBird.BaseChannel <p0>, SendBird.User <p1>);
                /*0x1522548*/ void <.ctor>b__42_18(SendBird.OpenChannel <p0>);
                /*0x152254c*/ void <.ctor>b__42_19(SendBird.OpenChannel <p0>);
                /*0x1522550*/ void <.ctor>b__42_20(SendBird.GroupChannel <p0>);
            }
        }

        class ConnectionHandler
        {
            /*0x10*/ SendBird.SendBirdClient.ConnectionHandler.OnReconnectStartedDelegate OnReconnectStarted;
            /*0x18*/ SendBird.SendBirdClient.ConnectionHandler.OnReconnectSucceededDelegate OnReconnectSucceeded;
            /*0x20*/ SendBird.SendBirdClient.ConnectionHandler.OnReconnectFailedDelegate OnReconnectFailed;

            /*0x1522554*/ ConnectionHandler();

            class OnReconnectStartedDelegate : System.MulticastDelegate
            {
                /*0x1522748*/ OnReconnectStartedDelegate(object object, nint method);
                /*0x152297c*/ void Invoke();
                /*0x1522990*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x15229b0*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnReconnectSucceededDelegate : System.MulticastDelegate
            {
                /*0x1522804*/ OnReconnectSucceededDelegate(object object, nint method);
                /*0x15229bc*/ void Invoke();
                /*0x15229d0*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x15229f0*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnReconnectFailedDelegate : System.MulticastDelegate
            {
                /*0x15228c0*/ OnReconnectFailedDelegate(object object, nint method);
                /*0x15229fc*/ void Invoke();
                /*0x1522a10*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x1522a30*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ SendBird.SendBirdClient.ConnectionHandler.<> <>9;
                static /*0x8*/ SendBird.SendBirdClient.ConnectionHandler.OnReconnectStartedDelegate <>9__6_0;
                static /*0x10*/ SendBird.SendBirdClient.ConnectionHandler.OnReconnectSucceededDelegate <>9__6_1;
                static /*0x18*/ SendBird.SendBirdClient.ConnectionHandler.OnReconnectFailedDelegate <>9__6_2;

                static /*0x1522a3c*/ <>c();
                /*0x1522aa0*/ <>c();
                /*0x1522aa8*/ void <.ctor>b__6_0();
                /*0x1522aac*/ void <.ctor>b__6_1();
                /*0x1522ab0*/ void <.ctor>b__6_2();
            }
        }

        class DisconnectHandler : System.MulticastDelegate
        {
            /*0x1522ab4*/ DisconnectHandler(object object, nint method);
            /*0x1522b70*/ void Invoke();
            /*0x1522b84*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x1522ba4*/ void EndInvoke(System.IAsyncResult result);
        }

        enum PushTokenRegistrationStatus
        {
            SUCCESS = 0,
            PENDING = 1,
            ERROR = 2,
        }

        class RegisterPushTokenWithStatusHandler : System.MulticastDelegate
        {
            /*0x1522bb0*/ RegisterPushTokenWithStatusHandler(object object, nint method);
            /*0x1522c74*/ void Invoke(SendBird.SendBirdClient.PushTokenRegistrationStatus status, SendBird.SendBirdException e);
            /*0x1522c88*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdClient.PushTokenRegistrationStatus status, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1522d18*/ void EndInvoke(System.IAsyncResult result);
        }

        class UnregisterPushTokenHandler : System.MulticastDelegate
        {
            /*0x1522d24*/ UnregisterPushTokenHandler(object object, nint method);
            /*0x1522e50*/ void Invoke(SendBird.SendBirdException e);
            /*0x1522e64*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1522e84*/ void EndInvoke(System.IAsyncResult result);
        }

        class SetDoNotDisturbHandler : System.MulticastDelegate
        {
            /*0x1522e90*/ SetDoNotDisturbHandler(object object, nint method);
            /*0x1522fbc*/ void Invoke(SendBird.SendBirdException e);
            /*0x1522fd0*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1522ff0*/ void EndInvoke(System.IAsyncResult result);
        }

        class GetDoNotDisturbHandler : System.MulticastDelegate
        {
            /*0x1522ffc*/ GetDoNotDisturbHandler(object object, nint method);
            /*0x15230c0*/ void Invoke(bool isDoNotDisturbOn, int startHour, int startMin, int endHour, int endMin, string timezone, SendBird.SendBirdException e);
            /*0x15230dc*/ System.IAsyncResult BeginInvoke(bool isDoNotDisturbOn, int startHour, int startMin, int endHour, int endMin, string timezone, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x15231ec*/ void EndInvoke(System.IAsyncResult result);
        }

        class UserInfoUpdateHandler : System.MulticastDelegate
        {
            /*0x15231f8*/ UserInfoUpdateHandler(object object, nint method);
            /*0x1523324*/ void Invoke(SendBird.SendBirdException e);
            /*0x1523338*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1523358*/ void EndInvoke(System.IAsyncResult result);
        }

        class UserBlockHandler : System.MulticastDelegate
        {
            /*0x1523364*/ UserBlockHandler(object object, nint method);
            /*0x1523494*/ void Invoke(SendBird.User blockedUser, SendBird.SendBirdException e);
            /*0x15234a8*/ System.IAsyncResult BeginInvoke(SendBird.User blockedUser, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x15234d0*/ void EndInvoke(System.IAsyncResult result);
        }

        class UserUnblockHandler : System.MulticastDelegate
        {
            /*0x15234dc*/ UserUnblockHandler(object object, nint method);
            /*0x1523608*/ void Invoke(SendBird.SendBirdException e);
            /*0x152361c*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x152363c*/ void EndInvoke(System.IAsyncResult result);
        }

        class SetChannelInvitationPreferenceHandler : System.MulticastDelegate
        {
            /*0x1523648*/ SetChannelInvitationPreferenceHandler(object object, nint method);
            /*0x1523774*/ void Invoke(SendBird.SendBirdException e);
            /*0x1523788*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x15237a8*/ void EndInvoke(System.IAsyncResult result);
        }

        class GetChannelInvitationPreferenceHandler : System.MulticastDelegate
        {
            /*0x15237b4*/ GetChannelInvitationPreferenceHandler(object object, nint method);
            /*0x1523878*/ void Invoke(bool autoAccept, SendBird.SendBirdException e);
            /*0x1523890*/ System.IAsyncResult BeginInvoke(bool autoAccept, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1523924*/ void EndInvoke(System.IAsyncResult result);
        }

        class LoginHandler : System.MulticastDelegate
        {
            /*0x1523930*/ LoginHandler(object object, nint method);
            /*0x1523a5c*/ void Invoke(SendBird.SendBirdException e);
            /*0x1523a70*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1523a90*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c
        {
            static /*0x0*/ SendBird.SendBirdClient.<> <>9;
            static /*0x8*/ System.Net.Security.RemoteCertificateValidationCallback <>9__35_0;
            static /*0x10*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate <>9__46_0;
            static /*0x18*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStopDelegate <>9__46_1;
            static /*0x20*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnCancelDelegate <>9__46_2;
            static /*0x28*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTimeoutDelegate <>9__46_3;
            static /*0x30*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate <>9__62_1;
            static /*0x38*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate <>9__62_12;
            static /*0x40*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate <>9__62_16;
            static /*0x48*/ SendBird.WSClient.WSClientHandler.OnCloseDelegate <>9__62_9;
            static /*0x50*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate <>9__62_5;
            static /*0x58*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate <>9__63_5;
            static /*0x60*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate <>9__63_9;
            static /*0x68*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate <>9__95_0;
            static /*0x70*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate <>9__95_4;

            static /*0x1523a9c*/ <>c();
            /*0x1523b00*/ <>c();
            /*0x1523b08*/ bool <.ctor>b__35_0(object o, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors);
            /*0x1523bb4*/ void <StartGlobalTimer>b__46_0();
            /*0x1523bb8*/ void <StartGlobalTimer>b__46_1();
            /*0x1523bbc*/ void <StartGlobalTimer>b__46_2();
            /*0x1523bc0*/ void <StartGlobalTimer>b__46_3();
            /*0x1523bc4*/ void <ReconnectWS>b__62_1();
            /*0x1523c2c*/ void <ReconnectWS>b__62_12();
            /*0x1523c30*/ void <ReconnectWS>b__62_16(int timeout, int elapsed);
            /*0x1523c34*/ void <ReconnectWS>b__62_9();
            /*0x1523c9c*/ void <ReconnectWS>b__62_5(int timeout, int elapsed);
            /*0x1523d50*/ void <ConnectWS>b__63_5();
            /*0x1523db8*/ void <ConnectWS>b__63_9(int timeout, int elapsed);
            /*0x1523e20*/ void <StartAckTimer>b__95_0();
            /*0x1523e24*/ void <StartAckTimer>b__95_4(int timeout, int elapsed);
        }

        class <>c__DisplayClass45_0
        {
            /*0x10*/ SendBird.SendBirdClient <>4__this;
            /*0x18*/ SendBird.Command cmd;
            /*0x20*/ SendBird.Command.SendCommandHandler handler;

            /*0x1519a18*/ <>c__DisplayClass45_0();
            /*0x1523e28*/ void <SendCommand>b__0(SendBird.SendBirdException e);
            /*0x1523fec*/ void <SendCommand>b__1(SendBird.SendBirdException e);
        }

        class <>c__DisplayClass46_0
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient <>4__this;

            /*0x151f774*/ <>c__DisplayClass46_0();
            /*0x1524030*/ void <StartGlobalTimer>b__5();
        }

        class <>c__DisplayClass54_0
        {
            /*0x10*/ SendBird.SendBirdClient.ConnectHandler handler;

            /*0x151aafc*/ <>c__DisplayClass54_0();
            /*0x15241c0*/ void <Connect>b__0();
        }

        class <>c__DisplayClass62_0
        {
            /*0x10*/ SendBird.SendBirdClient I;
            /*0x18*/ string userId;
            /*0x20*/ SendBird.WSClient.WSClientHandler.OnReadyDelegate <>9__7;
            /*0x28*/ SendBird.MyAction <>9__17;
            /*0x30*/ SendBird.MyAction <>9__18;
            /*0x38*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnCancelDelegate <>9__14;
            /*0x40*/ SendBird.WSClient.WSClientHandler.OnOpenDelegate <>9__8;
            /*0x48*/ SendBird.WSClient.WSClientHandler.OnMessageDelegate <>9__10;
            /*0x50*/ SendBird.WSClient.WSClientHandler.OnErrorDelegate <>9__11;

            /*0x151b6c0*/ <>c__DisplayClass62_0();
            /*0x1524284*/ void <ReconnectWS>b__0();
            /*0x1524410*/ void <ReconnectWS>b__2();
            /*0x152448c*/ void <ReconnectWS>b__3();
            /*0x1524508*/ void <ReconnectWS>b__4();
            /*0x1524854*/ void <ReconnectWS>b__7();
            /*0x15248dc*/ void <ReconnectWS>b__8();
            /*0x1524c98*/ void <ReconnectWS>b__17();
            /*0x1524e58*/ void <ReconnectWS>b__18();
            /*0x1524fe4*/ void <ReconnectWS>b__14();
            /*0x1525064*/ void <ReconnectWS>b__10(string message);
            /*0x1525108*/ void <ReconnectWS>b__11(SendBird.SendBirdException e);
            /*0x15251d4*/ void <ReconnectWS>b__6();
        }

        class <>c__DisplayClass62_1
        {
            /*0x10*/ bool timedout;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x1524c90*/ <>c__DisplayClass62_1();
            /*0x1525360*/ void <ReconnectWS>b__13();
            /*0x1525a8c*/ void <ReconnectWS>b__15();
        }

        class <>c__DisplayClass62_2
        {
            /*0x10*/ bool errorOnEnter;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals2;

            /*0x1525a84*/ <>c__DisplayClass62_2();
            /*0x1525b04*/ void <ReconnectWS>b__19();
        }

        class <>c__DisplayClass62_3
        {
            /*0x10*/ SendBird.CountdownLatch latch;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals3;
            /*0x20*/ SendBird.OpenChannel.OpenChannelEnterHandler <>9__20;

            /*0x15fc154*/ <>c__DisplayClass62_3();
            /*0x15fc15c*/ void <ReconnectWS>b__20(SendBird.SendBirdException e);
        }

        class <>c__DisplayClass63_0
        {
            /*0x10*/ SendBird.SendBirdClient I;
            /*0x18*/ bool isOpened;
            /*0x20*/ SendBird.SendBirdClient.ConnectHandler handler;
            /*0x28*/ string userId;
            /*0x30*/ SendBird.MyAction <>9__10;
            /*0x38*/ SendBird.MyAction <>9__11;
            /*0x40*/ SendBird.MyAction <>9__12;
            /*0x48*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnCancelDelegate <>9__7;
            /*0x50*/ SendBird.MyAction <>9__13;

            /*0x15fc1e0*/ <>c__DisplayClass63_0();
            /*0x15fc1e8*/ void <ConnectWS>b__0();
            /*0x15fc270*/ void <ConnectWS>b__1();
            /*0x15fc644*/ void <ConnectWS>b__10();
            /*0x15fc778*/ void <ConnectWS>b__11();
            /*0x15fc830*/ void <ConnectWS>b__12();
            /*0x15fc864*/ void <ConnectWS>b__7();
            /*0x15fc8e4*/ void <ConnectWS>b__2();
            /*0x15fc9f4*/ void <ConnectWS>b__13();
            /*0x15fcab4*/ void <ConnectWS>b__3(string message);
            /*0x15fcb5c*/ void <ConnectWS>b__4(SendBird.SendBirdException e);
        }

        class <>c__DisplayClass63_1
        {
            /*0x10*/ bool timedout;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fc63c*/ <>c__DisplayClass63_1();
            /*0x15fcd14*/ void <ConnectWS>b__6();
            /*0x15fcfdc*/ void <ConnectWS>b__8();
        }

        class <>c__DisplayClass63_2
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals2;

            /*0x15fcd0c*/ <>c__DisplayClass63_2();
            /*0x15fd054*/ void <ConnectWS>b__14();
        }

        class <>c__DisplayClass66_0
        {
            /*0x10*/ SendBird.SendBirdClient.DisconnectHandler handler;

            /*0x15fd088*/ <>c__DisplayClass66_0();
            /*0x15fd090*/ void <Disconnect>b__0();
        }

        class <>c__DisplayClass71_0
        {
            /*0x10*/ SendBird.SendBirdClient.UserInfoUpdateHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x15fd0b4*/ <>c__DisplayClass71_0();
            /*0x15fd0bc*/ void <UpdateCurrentUserInfoWithProfileImage>b__0();
            /*0x15fd178*/ void <UpdateCurrentUserInfoWithProfileImage>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fd3cc*/ void <UpdateCurrentUserInfoWithProfileImage>b__3();
        }

        class <>c__DisplayClass71_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fd3c4*/ <>c__DisplayClass71_1();
            /*0x15fd3f4*/ void <UpdateCurrentUserInfoWithProfileImage>b__2();
        }

        class <>c__DisplayClass72_0
        {
            /*0x10*/ SendBird.SendBirdClient.UserInfoUpdateHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x15fd42c*/ <>c__DisplayClass72_0();
            /*0x15fd434*/ void <UpdateCurrentUserInfo>b__0();
            /*0x15fd4f0*/ void <UpdateCurrentUserInfo>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fd74c*/ void <UpdateCurrentUserInfo>b__3();
        }

        class <>c__DisplayClass72_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fd744*/ <>c__DisplayClass72_1();
            /*0x15fd774*/ void <UpdateCurrentUserInfo>b__2();
        }

        class <>c__DisplayClass74_0
        {
            /*0x10*/ SendBird.SendBirdClient.RegisterPushTokenWithStatusHandler handler;
            /*0x18*/ SendBird.MyAction <>9__4;

            /*0x15fd7a4*/ <>c__DisplayClass74_0();
            /*0x15fd7ac*/ void <RegisterAPNSPushTokenForCurrentUser>b__0();
            /*0x15fd86c*/ void <RegisterAPNSPushTokenForCurrentUser>b__1();
            /*0x15fd898*/ void <RegisterAPNSPushTokenForCurrentUser>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fda18*/ void <RegisterAPNSPushTokenForCurrentUser>b__4();
        }

        class <>c__DisplayClass74_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fda10*/ <>c__DisplayClass74_1();
            /*0x15fda44*/ void <RegisterAPNSPushTokenForCurrentUser>b__3();
        }

        class <>c__DisplayClass75_0
        {
            /*0x10*/ SendBird.SendBirdClient.UnregisterPushTokenHandler handler;
            /*0x18*/ SendBird.MyAction <>9__4;

            /*0x15fda78*/ <>c__DisplayClass75_0();
            /*0x15fda80*/ void <UnregisterAPNSPushTokenForCurrentUser>b__0();
            /*0x15fdb3c*/ void <UnregisterAPNSPushTokenForCurrentUser>b__1();
            /*0x15fdbf8*/ void <UnregisterAPNSPushTokenForCurrentUser>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fdd58*/ void <UnregisterAPNSPushTokenForCurrentUser>b__4();
        }

        class <>c__DisplayClass75_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fdd50*/ <>c__DisplayClass75_1();
            /*0x15fdd80*/ void <UnregisterAPNSPushTokenForCurrentUser>b__3();
        }

        class <>c__DisplayClass76_0
        {
            /*0x10*/ SendBird.SendBirdClient.RegisterPushTokenWithStatusHandler handler;
            /*0x18*/ SendBird.MyAction <>9__4;

            /*0x15fddb0*/ <>c__DisplayClass76_0();
            /*0x15fddb8*/ void <RegisterFCMPushTokenForCurrentUser>b__0();
            /*0x15fde78*/ void <RegisterFCMPushTokenForCurrentUser>b__1();
            /*0x15fdea4*/ void <RegisterFCMPushTokenForCurrentUser>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fe024*/ void <RegisterFCMPushTokenForCurrentUser>b__4();
        }

        class <>c__DisplayClass76_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fe01c*/ <>c__DisplayClass76_1();
            /*0x15fe050*/ void <RegisterFCMPushTokenForCurrentUser>b__3();
        }

        class <>c__DisplayClass77_0
        {
            /*0x10*/ SendBird.SendBirdClient.UnregisterPushTokenHandler handler;
            /*0x18*/ SendBird.MyAction <>9__4;

            /*0x15fe084*/ <>c__DisplayClass77_0();
            /*0x15fe08c*/ void <UnregisterFCMPushTokenForCurrentUser>b__0();
            /*0x15fe148*/ void <UnregisterFCMPushTokenForCurrentUser>b__1();
            /*0x15fe204*/ void <UnregisterFCMPushTokenForCurrentUser>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fe364*/ void <UnregisterFCMPushTokenForCurrentUser>b__4();
        }

        class <>c__DisplayClass77_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fe35c*/ <>c__DisplayClass77_1();
            /*0x15fe38c*/ void <UnregisterFCMPushTokenForCurrentUser>b__3();
        }

        class <>c__DisplayClass78_0
        {
            /*0x10*/ SendBird.SendBirdClient.UnregisterPushTokenHandler handler;
            /*0x18*/ SendBird.MyAction <>9__3;

            /*0x15fe3bc*/ <>c__DisplayClass78_0();
            /*0x15fe3c4*/ void <UnregisterPushTokenAllForCurrentUser>b__0();
            /*0x15fe480*/ void <UnregisterPushTokenAllForCurrentUser>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fe5e0*/ void <UnregisterPushTokenAllForCurrentUser>b__3();
        }

        class <>c__DisplayClass78_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fe5d8*/ <>c__DisplayClass78_1();
            /*0x15fe608*/ void <UnregisterPushTokenAllForCurrentUser>b__2();
        }

        class <>c__DisplayClass79_0
        {
            /*0x10*/ SendBird.SendBirdClient.SetDoNotDisturbHandler handler;
            /*0x18*/ SendBird.MyAction <>9__4;

            /*0x15fe638*/ <>c__DisplayClass79_0();
            /*0x15fe640*/ void <SetDoNotDisturb>b__0();
            /*0x15fe6fc*/ void <SetDoNotDisturb>b__1();
            /*0x15fe7b8*/ void <SetDoNotDisturb>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15fe918*/ void <SetDoNotDisturb>b__4();
        }

        class <>c__DisplayClass79_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fe910*/ <>c__DisplayClass79_1();
            /*0x15fe940*/ void <SetDoNotDisturb>b__3();
        }

        class <>c__DisplayClass80_0
        {
            /*0x10*/ SendBird.SendBirdClient.GetDoNotDisturbHandler handler;

            /*0x15fe970*/ <>c__DisplayClass80_0();
            /*0x15fe978*/ void <GetDoNotDisturb>b__0();
            /*0x15fea5c*/ void <GetDoNotDisturb>b__1(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass80_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ bool isDisturbOn;
            /*0x1c*/ int startHour;
            /*0x20*/ int startMin;
            /*0x24*/ int endHour;
            /*0x28*/ int endMin;
            /*0x30*/ string timezone;
            /*0x38*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15fed24*/ <>c__DisplayClass80_1();
            /*0x15fed2c*/ void <GetDoNotDisturb>b__2();
            /*0x15fed84*/ void <GetDoNotDisturb>b__3();
        }

        class <>c__DisplayClass81_0
        {
            /*0x10*/ SendBird.SendBirdClient.UserBlockHandler handler;

            /*0x15fedd4*/ <>c__DisplayClass81_0();
            /*0x15feddc*/ void <BlockUser>b__0();
        }

        class <>c__DisplayClass82_0
        {
            /*0x10*/ SendBird.SendBirdClient.UserBlockHandler handler;

            /*0x15fee9c*/ <>c__DisplayClass82_0();
            /*0x15feea4*/ void <BlockUserWithUserId>b__0();
            /*0x15fef64*/ void <BlockUserWithUserId>b__1();
            /*0x15ff024*/ void <BlockUserWithUserId>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass82_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SBJson.JsonElement response;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15ff160*/ <>c__DisplayClass82_1();
            /*0x15ff168*/ void <BlockUserWithUserId>b__3();
            /*0x15ff19c*/ void <BlockUserWithUserId>b__4();
        }

        class <>c__DisplayClass83_0
        {
            /*0x10*/ SendBird.SendBirdClient.UserUnblockHandler handler;

            /*0x15ff5a8*/ <>c__DisplayClass83_0();
            /*0x15ff5b0*/ void <UnblockUser>b__0();
        }

        class <>c__DisplayClass84_0
        {
            /*0x10*/ SendBird.SendBirdClient.UserUnblockHandler handler;
            /*0x18*/ SendBird.MyAction <>9__4;

            /*0x15ff66c*/ <>c__DisplayClass84_0();
            /*0x15ff674*/ void <UnblockUserWithUserId>b__0();
            /*0x15ff730*/ void <UnblockUserWithUserId>b__1();
            /*0x15ff7ec*/ void <UnblockUserWithUserId>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x15ff94c*/ void <UnblockUserWithUserId>b__4();
        }

        class <>c__DisplayClass84_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15ff944*/ <>c__DisplayClass84_1();
            /*0x15ff974*/ void <UnblockUserWithUserId>b__3();
        }

        class <>c__DisplayClass93_0
        {
            /*0x10*/ SendBird.BaseMessage updatedMsg;
            /*0x18*/ SendBird.BaseMessage msg;
            /*0x20*/ SendBird.SendBirdClient <>4__this;

            /*0x15ff9a4*/ <>c__DisplayClass93_0();
            /*0x15ff9ac*/ void <MessageReceived>b__0(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x15ffaec*/ void <MessageReceived>b__1(SendBird.GroupChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass93_1
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x15ffae4*/ <>c__DisplayClass93_1();
            /*0x15ffc40*/ void <MessageReceived>b__2();
        }

        class <>c__DisplayClass93_2
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals2;

            /*0x15ffc38*/ <>c__DisplayClass93_2();
            /*0x15ffdec*/ void <MessageReceived>b__3();
        }

        class <>c__DisplayClass93_3
        {
            /*0x10*/ SendBird.BaseMessage msg;
            /*0x18*/ SendBird.SendBirdClient <>4__this;

            /*0x15fff84*/ <>c__DisplayClass93_3();
            /*0x15fff8c*/ void <MessageReceived>b__4(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x160025c*/ void <MessageReceived>b__5(SendBird.OpenChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass93_4
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ bool channelChanged;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals3;

            /*0x1600254*/ <>c__DisplayClass93_4();
            /*0x160039c*/ void <MessageReceived>b__6();
        }

        class <>c__DisplayClass93_5
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals4;

            /*0x1600394*/ <>c__DisplayClass93_5();
            /*0x1600590*/ void <MessageReceived>b__7();
        }

        class <>c__DisplayClass93_6
        {
            /*0x10*/ SendBird.ReadStatus rst;
            /*0x18*/ SendBird.SendBirdClient <>4__this;

            /*0x160073c*/ <>c__DisplayClass93_6();
            /*0x1600744*/ void <MessageReceived>b__8(SendBird.GroupChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass93_7
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ bool callChannelChanged;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals5;

            /*0x160092c*/ <>c__DisplayClass93_7();
            /*0x1600934*/ void <MessageReceived>b__9();
        }

        class <>c__DisplayClass93_8
        {
            /*0x10*/ bool hasChannelCached;
            /*0x18*/ SendBird.SBJson.JsonObject obj;
            /*0x20*/ SendBird.SendBirdClient <>4__this;

            /*0x1600b14*/ <>c__DisplayClass93_8();
            /*0x1600b1c*/ void <MessageReceived>b__10(SendBird.GroupChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass93_9
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals6;

            /*0x160113c*/ <>c__DisplayClass93_9();
            /*0x1601144*/ void <MessageReceived>b__11();
        }

        class <>c__DisplayClass93_10
        {
            /*0x10*/ SendBird.BaseMessage updatedMsg;
            /*0x18*/ SendBird.SendBirdClient <>4__this;

            /*0x16012dc*/ <>c__DisplayClass93_10();
            /*0x16012e4*/ void <MessageReceived>b__12(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1601424*/ void <MessageReceived>b__13(SendBird.OpenChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass93_11
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals7;

            /*0x160141c*/ <>c__DisplayClass93_11();
            /*0x1601564*/ void <MessageReceived>b__14();
        }

        class <>c__DisplayClass93_12
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals8;

            /*0x160155c*/ <>c__DisplayClass93_12();
            /*0x1601710*/ void <MessageReceived>b__15();
        }

        class <>c__DisplayClass93_13
        {
            /*0x10*/ long msgId;
            /*0x18*/ SendBird.SendBirdClient <>4__this;

            /*0x16018bc*/ <>c__DisplayClass93_13();
            /*0x16018c4*/ void <MessageReceived>b__16(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1601a04*/ void <MessageReceived>b__17(SendBird.GroupChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass93_14
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals9;

            /*0x16019fc*/ <>c__DisplayClass93_14();
            /*0x1601b44*/ void <MessageReceived>b__18();
        }

        class <>c__DisplayClass93_15
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals10;

            /*0x1601b3c*/ <>c__DisplayClass93_15();
            /*0x1601cf0*/ void <MessageReceived>b__19();
        }

        class <>c__DisplayClass94_0
        {
            /*0x10*/ SendBird.Command cmd;
            /*0x18*/ SendBird.ChannelEvent evt;
            /*0x20*/ SendBird.SendBirdClient <>4__this;

            /*0x1601e9c*/ <>c__DisplayClass94_0();
            /*0x1601ea4*/ void <ProcessChannelEvent>b__0(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1602880*/ void <ProcessChannelEvent>b__1(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1602d70*/ void <ProcessChannelEvent>b__2(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1603494*/ void <ProcessChannelEvent>b__3(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x16036ac*/ void <ProcessChannelEvent>b__4(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1603920*/ void <ProcessChannelEvent>b__5(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1603b14*/ void <ProcessChannelEvent>b__6(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1603d08*/ void <ProcessChannelEvent>b__7(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1604024*/ void <ProcessChannelEvent>b__8(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x16041cc*/ void <ProcessChannelEvent>b__9(SendBird.OpenChannel channel, SendBird.SendBirdException e);
            /*0x1604374*/ void <ProcessChannelEvent>b__10(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x160451c*/ void <ProcessChannelEvent>b__13(SendBird.GroupChannel channel, SendBird.SendBirdException e);
            /*0x1604768*/ void <ProcessChannelEvent>b__14(SendBird.GroupChannel channel, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass94_1
        {
            /*0x10*/ string channelUrl;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x16048bc*/ <>c__DisplayClass94_1();
            /*0x16048c4*/ void <ProcessChannelEvent>b__11();
            /*0x1604a60*/ void <ProcessChannelEvent>b__12();
        }

        class <>c__DisplayClass94_2
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.User inviter;
            /*0x20*/ System.Collections.Generic.List<SendBird.User> invitees;
            /*0x28*/ SendBird.SendBirdClient.<> CS$<>8__locals2;

            /*0x1602878*/ <>c__DisplayClass94_2();
            /*0x1604bfc*/ void <ProcessChannelEvent>b__15();
        }

        class <>c__DisplayClass94_3
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.User inviter;
            /*0x20*/ SendBird.Member invitee;
            /*0x28*/ SendBird.SendBirdClient.<> CS$<>8__locals3;

            /*0x1602d68*/ <>c__DisplayClass94_3();
            /*0x1604e4c*/ void <ProcessChannelEvent>b__16();
        }

        class <>c__DisplayClass94_4
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.Member user;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals4;
            /*0x28*/ SendBird.MyAction <>9__17;

            /*0x160348c*/ <>c__DisplayClass94_4();
            /*0x1604fe8*/ void <ProcessChannelEvent>b__17();
            /*0x1605180*/ void <ProcessChannelEvent>b__18();
        }

        class <>c__DisplayClass94_5
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals5;

            /*0x16036a4*/ <>c__DisplayClass94_5();
            /*0x1605318*/ void <ProcessChannelEvent>b__19();
        }

        class <>c__DisplayClass94_6
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.User user;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals6;

            /*0x1603918*/ <>c__DisplayClass94_6();
            /*0x16054b0*/ void <ProcessChannelEvent>b__20();
        }

        class <>c__DisplayClass94_7
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.User user;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals7;

            /*0x1603b0c*/ <>c__DisplayClass94_7();
            /*0x16056c8*/ void <ProcessChannelEvent>b__21();
        }

        class <>c__DisplayClass94_8
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.User user;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals8;

            /*0x1603d00*/ <>c__DisplayClass94_8();
            /*0x16058e0*/ void <ProcessChannelEvent>b__22();
        }

        class <>c__DisplayClass94_9
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.User user;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals9;

            /*0x160401c*/ <>c__DisplayClass94_9();
            /*0x1605af8*/ void <ProcessChannelEvent>b__23();
        }

        class <>c__DisplayClass94_10
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals10;

            /*0x16041c4*/ <>c__DisplayClass94_10();
            /*0x1605d10*/ void <ProcessChannelEvent>b__24();
        }

        class <>c__DisplayClass94_11
        {
            /*0x10*/ SendBird.OpenChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals11;

            /*0x160436c*/ <>c__DisplayClass94_11();
            /*0x1605f28*/ void <ProcessChannelEvent>b__25();
        }

        class <>c__DisplayClass94_12
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals12;

            /*0x1604514*/ <>c__DisplayClass94_12();
            /*0x16060c0*/ void <ProcessChannelEvent>b__26();
        }

        class <>c__DisplayClass94_13
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals13;

            /*0x1604760*/ <>c__DisplayClass94_13();
            /*0x1606258*/ void <ProcessChannelEvent>b__27();
        }

        class <>c__DisplayClass94_14
        {
            /*0x10*/ SendBird.GroupChannel channel;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals14;

            /*0x16048b4*/ <>c__DisplayClass94_14();
            /*0x16063f0*/ void <ProcessChannelEvent>b__28();
        }

        class <>c__DisplayClass95_0
        {
            /*0x10*/ SendBird.SendBirdClient <>4__this;
            /*0x18*/ string reqId;
            /*0x20*/ SendBird.Command.SendCommandHandler handler;

            /*0x1606588*/ <>c__DisplayClass95_0();
            /*0x1606590*/ void <StartAckTimer>b__1();
            /*0x16065f8*/ void <StartAckTimer>b__2();
            /*0x1606660*/ void <StartAckTimer>b__3();
        }

        class <>c__DisplayClass97_0
        {
            /*0x10*/ SendBird.SendBirdClient.SetChannelInvitationPreferenceHandler handler;
            /*0x18*/ SendBird.MyAction <>9__2;

            /*0x1606720*/ <>c__DisplayClass97_0();
            /*0x1606728*/ void <SetChannelInvitationPreference>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1606888*/ void <SetChannelInvitationPreference>b__2();
        }

        class <>c__DisplayClass97_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x1606880*/ <>c__DisplayClass97_1();
            /*0x16068b0*/ void <SetChannelInvitationPreference>b__1();
        }

        class <>c__DisplayClass98_0
        {
            /*0x10*/ SendBird.SendBirdClient.GetChannelInvitationPreferenceHandler handler;

            /*0x16068e0*/ <>c__DisplayClass98_0();
            /*0x16068e8*/ void <GetChannelInvitationPreference>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass98_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ bool autoAccept;
            /*0x20*/ SendBird.SendBirdClient.<> CS$<>8__locals1;

            /*0x1606a80*/ <>c__DisplayClass98_1();
            /*0x1606a88*/ void <GetChannelInvitationPreference>b__1();
            /*0x1606abc*/ void <GetChannelInvitationPreference>b__2();
        }
    }

    class SendBirdError
    {
        static /*0x0*/ int ERR_INVALID_PARAMETER_VALUE_STRING;
        static /*0x4*/ int ERR_INVALID_PARAMETER_VALUE_NUMBER;
        static /*0x8*/ int ERR_INVALID_PARAMETER_VALUE_LIST;
        static /*0xc*/ int ERR_INVALID_PARAMETER_VALUE_JSON;
        static /*0x10*/ int ERR_INVALID_PARAMETER_VALUE_BOOLEAN;
        static /*0x14*/ int ERR_INVALID_PARAMETER_VALUE_REQUIRED;
        static /*0x18*/ int ERR_INVALID_PARAMETER_VALUE_POSITIVE;
        static /*0x1c*/ int ERR_INVALID_PARAMETER_VALUE_NEGATIVE;
        static /*0x20*/ int ERR_NON_AUTHORIZED;
        static /*0x24*/ int ERR_TOKEN_EXPIRED;
        static /*0x28*/ int ERR_INVALID_CHANNEL_URL;
        static /*0x2c*/ int ERR_INVALID_PARAMETER_VALUE;
        static /*0x30*/ int ERR_UNUSABLE_CHARACTER_INCLUDED;
        static /*0x34*/ int ERR_NOT_FOUND_IN_DATABASE;
        static /*0x38*/ int ERR_DUPLICATED_DATA;
        static /*0x3c*/ int ERR_INVALID_JSON_BODY;
        static /*0x40*/ int ERR_API_TOKEN_NOT_VALID;
        static /*0x44*/ int ERR_APP_ID_NOT_VALID;
        static /*0x48*/ int ERR_ACCESS_TOKEN_EMPTY;
        static /*0x4c*/ int ERR_ACCESS_TOKEN_NOT_VALID;
        static /*0x50*/ int ERR_USER_NOT_EXIST;
        static /*0x54*/ int ERR_USER_DEACTIVATED;
        static /*0x58*/ int ERR_USER_CREATION_FAILED;
        static /*0x5c*/ int ERR_INTERNAL_SERVER_ERROR;
        static /*0x60*/ int ERR_INVALID_INITIALIZATION;
        static /*0x64*/ int ERR_CONNECTION_REQUIRED;
        static /*0x68*/ int ERR_INVALID_PARAMETER;
        static /*0x6c*/ int ERR_NETWORK;
        static /*0x70*/ int ERR_NETWORK_ROUTING_ERROR;
        static /*0x74*/ int ERR_MALFORMED_DATA;
        static /*0x78*/ int ERR_MALFORMED_ERROR_DATA;
        static /*0x7c*/ int ERR_WRONG_CHANNEL_TYPE;
        static /*0x80*/ int ERR_MARK_AS_READ_RATE_LIMIT_EXCEEDED;
        static /*0x84*/ int ERR_QUERY_IN_PROGRESS;
        static /*0x88*/ int ERR_ACK_TIMEOUT;
        static /*0x8c*/ int ERR_LOGIN_TIMEOUT;
        static /*0x90*/ int ERR_WEBSOCKET_CONNECTION_CLOSED;
        static /*0x94*/ int ERR_WEBSOCKET_CONNECTION_FAILED;
        static /*0x98*/ int ERR_REQUEST_FAILED;
        static /*0x9c*/ int ERR_INVALID_AUTHORITY;

        static /*0x1606af8*/ SendBirdError();
        /*0x1606af0*/ SendBirdError();
    }

    class SendBirdException : System.Exception
    {
        /*0x8c*/ int code;

        /*0x1606bb0*/ SendBirdException(string message);
        /*0x15fc704*/ SendBirdException(string message, int code);
        /*0x1606ba0*/ int get_Code();
        /*0x1606ba8*/ void set_Code(int value);
    }

    class User
    {
        /*0x10*/ string mNickname;
        /*0x18*/ string mProfileUrl;
        /*0x20*/ string mUserId;
        /*0x28*/ SendBird.User.UserConnectionStatus mConnectionStatus;
        /*0x30*/ long mLastSeenAt;
        /*0x38*/ bool mIsActive;

        static /*0x1606c20*/ SendBird.SBJson.JsonElement Build(string userId, string nickname, string profileUrl, bool isOnline, long lastSeenAt);
        /*0x15ff220*/ User(SendBird.SBJson.JsonElement el);
        /*0x1606d78*/ SendBird.SBJson.JsonElement toJson();
        /*0x1606eb4*/ string toString();
        /*0x1607248*/ string get_UserId();
        /*0x1607250*/ string get_Nickname();
        /*0x1607258*/ string get_ProfileUrl();
        /*0x1607260*/ SendBird.User.UserConnectionStatus get_ConnectionStatus();
        /*0x1607268*/ long get_LastSeenAt();
        /*0x1607270*/ void SetUserId(string userId);
        /*0x1607278*/ void SetNickname(string nickname);
        /*0x1607280*/ void SetProfileUrl(string profileUrl);
        /*0x1607288*/ void UpdatePropertiesByUser(SendBird.User destUser);

        enum UserConnectionStatus
        {
            NON_AVAILABLE = 0,
            ONLINE = 1,
            OFFLINE = 2,
        }
    }

    class UserListQuery
    {
        static /*0x0*/ object syncLock;
        /*0x10*/ SendBird.UserListQuery.QueryType mQueryType;
        /*0x18*/ SendBird.BaseChannel mChannel;
        /*0x20*/ string mJsonArrayName;
        /*0x28*/ string mToken;
        /*0x30*/ int mLimit;
        /*0x38*/ System.Collections.Generic.List<string> mUserIds;
        /*0x40*/ bool mHasNext;
        /*0x41*/ bool mLoading;
        /*0x48*/ SendBird.APIClient.APIClientHandler mApiClientHandler;

        static /*0x16086ac*/ UserListQuery();
        /*0x16072ec*/ UserListQuery(SendBird.UserListQuery.QueryType queryType);
        /*0x16073e4*/ UserListQuery(SendBird.UserListQuery.QueryType queryType, SendBird.BaseChannel channel);
        /*0x1607408*/ UserListQuery(SendBird.UserListQuery.QueryType queryType, System.Collections.Generic.List<string> userIds);
        /*0x16074a0*/ void set_Limit(int value);
        /*0x16074a8*/ int get_Limit();
        /*0x16074b0*/ bool HasNext();
        /*0x16074b8*/ bool IsLoading();
        /*0x1607534*/ void SetLoading(bool tf);
        /*0x16075b4*/ void Next(SendBird.UserListQuery.UserListQueryResultHandler handler);

        enum QueryType
        {
            ALL_USER = 0,
            FILTERED_USER = 1,
            BLOCKED_USER = 2,
            PARTICIPANT = 3,
            MUTED_USER = 4,
            BANNED_USER = 5,
        }

        class UserListQueryResultHandler : System.MulticastDelegate
        {
            /*0x1608724*/ UserListQueryResultHandler(object object, nint method);
            /*0x1608854*/ void Invoke(System.Collections.Generic.List<SendBird.User> queryResult, SendBird.SendBirdException e);
            /*0x1608868*/ System.IAsyncResult BeginInvoke(System.Collections.Generic.List<SendBird.User> queryResult, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x1608890*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ SendBird.UserListQuery.UserListQueryResultHandler handler;
            /*0x18*/ SendBird.UserListQuery <>4__this;

            /*0x1607b54*/ <>c__DisplayClass20_0();
            /*0x160889c*/ void <Next>b__0();
            /*0x1608928*/ void <Next>b__1();
            /*0x16089e8*/ void <Next>b__2(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1608dbc*/ void <Next>b__5();
        }

        class <>c__DisplayClass20_1
        {
            /*0x10*/ SendBird.SendBirdException e;
            /*0x18*/ System.Collections.Generic.List<SendBird.User> users;
            /*0x20*/ SendBird.UserListQuery.<> CS$<>8__locals1;

            /*0x1608db4*/ <>c__DisplayClass20_1();
            /*0x1608e7c*/ void <Next>b__3();
            /*0x1608eb0*/ void <Next>b__4();
        }
    }

    class UserMessage : SendBird.BaseMessage
    {
        /*0x48*/ string mMessage;
        /*0x50*/ string mData;
        /*0x58*/ SendBird.Sender mSender;
        /*0x60*/ string mReqId;
        /*0x68*/ string mCustomType;
        /*0x70*/ System.Collections.Generic.Dictionary<string, string> mTranslations;

        static /*0x1608ee4*/ SendBird.SBJson.JsonElement Build(string requestId, SendBird.SendingStatus sendingStatus, long msgId, SendBird.User user, SendBird.BaseChannel channel, string message, string data, string customType, System.Collections.Generic.Dictionary<string, string> translations, long createdAt);
        /*0x16093f4*/ UserMessage(SendBird.SBJson.JsonElement el);
        /*0x1609858*/ string get_Message();
        /*0x1609860*/ string get_Data();
        /*0x1609868*/ SendBird.User get_Sender();
        /*0x1609870*/ string get_RequestId();
        /*0x1609878*/ string get_CustomType();
        /*0x1609880*/ System.Collections.Generic.Dictionary<string, string> get_Translations();
        /*0x1609888*/ SendBird.Sender GetSender();
    }

    class APIClient
    {
        static int UPDATE_META_COUNTER_MODE_SET = 0;
        static int UPDATE_META_COUNTER_MODE_INC = 1;
        static int UPDATE_META_COUNTER_MODE_DEC = 2;
        static /*0x0*/ string API_ROUTING_URL;
        static /*0x8*/ string API_USERS;
        static /*0x10*/ string API_USERS_USERID_LOGIN;
        static /*0x18*/ string API_USERS_USERID;
        static /*0x20*/ string API_USERS_USERID_UNREADCOUNT;
        static /*0x28*/ string API_USERS_USERID_MARKASREADALL;
        static /*0x30*/ string API_USERS_USERID_PUSH_GCM_TOKEN;
        static /*0x38*/ string API_USERS_USERID_PUSH_GCM;
        static /*0x40*/ string API_USERS_USERID_PUSH_APNS_TOKEN;
        static /*0x48*/ string API_USERS_USERID_PUSH_APNS;
        static /*0x50*/ string API_USERS_USERID_PUSH;
        static /*0x58*/ string API_USERS_USERID_PUSHPREFERENCE_CHANNELURL;
        static /*0x60*/ string API_USERS_USERID_PUSHPREFERENCE;
        static /*0x68*/ string API_USERS_USERID_BLOCK;
        static /*0x70*/ string API_USERS_USERID_BLOCK_TARGETID;
        static /*0x78*/ string API_OPENCHANNELS;
        static /*0x80*/ string API_OPENCHANNELS_CHANNELURL;
        static /*0x88*/ string API_OPENCHANNELS_CHANNELURL_MESSAGES;
        static /*0x90*/ string API_OPENCHANNELS_CHANNELURL_MESSAGES_MESSAGEID;
        static /*0x98*/ string API_OPENCHANNELS_CHANNELURL_PARTICIPANTS;
        static /*0xa0*/ string API_OPENCHANNELS_CHANNELURL_METADATA;
        static /*0xa8*/ string API_OPENCHANNELS_CHANNELURL_METADATA_KEY;
        static /*0xb0*/ string API_OPENCHANNELS_CHANNELURL_METACOUNTER;
        static /*0xb8*/ string API_OPENCHANNELS_CHANNELURL_METACOUNTER_KEY;
        static /*0xc0*/ string API_OPENCHANNELS_CHANNELURL_BAN;
        static /*0xc8*/ string API_OPENCHANNELS_CHANNELURL_BAN_USERID;
        static /*0xd0*/ string API_OPENCHANNELS_CHANNELURL_MUTE;
        static /*0xd8*/ string API_OPENCHANNELS_CHANNELURL_MUTE_USERID;
        static /*0xe0*/ string API_GROUPCHANNELS_CHANNELURL_MUTE_USERID;
        static /*0xe8*/ string API_GROUPCHANNELS;
        static /*0xf0*/ string API_GROUPCHANNELS_CHANNELURL;
        static /*0xf8*/ string API_REPORT_USERS_OFFENDINGUSERID;
        static /*0x100*/ string API_USERS_USERID_MYGROUPCHANNELS;
        static /*0x108*/ string API_GROUPCHANNELS_CHANNELURL_INVITE;
        static /*0x110*/ string API_GROUPCHANNELS_CHANNELURL_JOIN;
        static /*0x118*/ string API_USERS_USERID_CHANNELINVITATIONPREFERENCE;
        static /*0x120*/ string API_GROUPCHANNELS_CHANNELURL_ACCEPT;
        static /*0x128*/ string API_GROUPCHANNELS_CHANNELURL_DECLINE;
        static /*0x130*/ string API_GROUPCHANNELS_CHANNELURL_HIDE;
        static /*0x138*/ string API_GROUPCHANNELS_CHANNELURL_LEAVE;
        static /*0x140*/ string API_GROUPCHANNELS_CHANNELURL_MESSAGES;
        static /*0x148*/ string API_GROUPCHANNELS_CHANNELURL_MESSAGES_MARKASREAD;
        static /*0x150*/ string API_GROUPCHANNELS_CHANNELURL_MESSAGES_MESSAGEID;
        static /*0x158*/ string API_GROUPCHANNELS_CHANNELURL_MEMBERS;
        static /*0x160*/ string API_GROUPCHANNELS_CHANNELURL_METADATA;
        static /*0x168*/ string API_GROUPCHANNELS_CHANNELURL_METADATA_KEY;
        static /*0x170*/ string API_GROUPCHANNELS_CHANNELURL_METACOUNTER;
        static /*0x178*/ string API_GROUPCHANNELS_CHANNELURL_METACOUNTER_KEY;
        static /*0x180*/ string API_GROUPCHANNELS_CHANNELURL_BAN;
        static /*0x188*/ string API_GROUPCHANNELS_CHANNELURL_BAN_USERID;
        static /*0x190*/ string API_GROUPCHANNELS_CHANNELURL_MUTE;
        static /*0x198*/ string API_STORAGE_FILE;
        static /*0x1a0*/ string API_STORAGE_PROFILEIMAGE;
        static /*0x1a8*/ string API_REPORT_OPENCHANNELS_CHANNELURL;
        static /*0x1b0*/ string API_REPORT_GROUPCHANNELS_CHANNELURL;
        static /*0x1b8*/ string API_REPORT_OPENCHANNELS_CHANNELURL_MESSAGES_MESSAGEID;
        static /*0x1c0*/ string API_REPORT_GROUPCHANNELS_CHANNELURL_MESSAGES_MESSAGEID;
        static /*0x1c8*/ string MIME_JSON;
        static /*0x1d0*/ string MIME_MULTIPART_FORM_BOUNDARY;
        static /*0x1d8*/ string MIME_MULTIPART_FORM_DATA;
        static /*0x1e0*/ string formdataTemplate;
        static /*0x1e8*/ string headerTemplate;
        static /*0x1f0*/ byte[] boundarybytes;
        static /*0x1f8*/ byte[] trailerbytes;
        static /*0x200*/ SendBird.APIClient sInstance;
        /*0x10*/ string mSessionKey;
        /*0x18*/ string mAPIHost;
        /*0x20*/ string mWSHost;
        /*0x28*/ long mRoutingUpdatedAt;

        static /*0x1609abc*/ APIClient();
        static /*0x1607b5c*/ SendBird.APIClient get_Instance();
        static /*0x16099ac*/ void Init();
        static /*0x160ac84*/ void ResetHosts();
        static /*0x160a4cc*/ System.Net.HttpWebRequest CreateHttpRequest(string uri, string method, string contentType, int contentLength, string sessionKey);
        static /*0x160c2c0*/ SendBird.SBJson.JsonElement ProcessResponse(string response);
        static /*0x160a990*/ void NewCall(System.Net.HttpWebRequest request, SendBird.APIClient.APIClientHandler handler, byte[] requestData);
        static /*0x160c73c*/ void RespCallback(System.IAsyncResult ar);
        static /*0x160cc50*/ void ReqCallback(System.IAsyncResult ar);
        static /*0x160cfb8*/ void ReadCallBack(System.IAsyncResult ar);
        /*0x1609a6c*/ APIClient();
        /*0x160ad4c*/ void RequestGET(string url, SendBird.APIClient.APIClientHandler handler);
        /*0x160ad58*/ void RequestGET(string url, System.Collections.Generic.Dictionary<string, string> map, SendBird.APIClient.APIClientHandler handler);
        /*0x160b4c0*/ void RequestPOST(string url, SendBird.SBJson.JsonElement form, SendBird.APIClient.APIClientHandler handler);
        /*0x160b590*/ void RequestPOST(string url, System.Collections.Generic.Dictionary<string, string> form, string fileFieldName, SendBird.SBFile file, SendBird.APIClient.APIClientHandler handler);
        /*0x160b674*/ void RequestPUT(string url, SendBird.SBJson.JsonElement form, SendBird.APIClient.APIClientHandler handler);
        /*0x160b744*/ void RequestPUT(string url, System.Collections.Generic.Dictionary<string, string> form, string fileFieldName, SendBird.SBFile file, SendBird.APIClient.APIClientHandler handler);
        /*0x160b828*/ void RequestDELETE(string url, SendBird.APIClient.APIClientHandler handler);
        /*0x160b8ec*/ void RequestDELETE(string url, SendBird.SBJson.JsonElement form, SendBird.APIClient.APIClientHandler handler);
        /*0x160b9bc*/ void RequestFILE(string url, SendBird.SBJson.JsonElement form, string path, SendBird.APIClient.APIClientHandler handler);
        /*0x160ba94*/ void HttpUploadFile(System.IO.Stream rs, SendBird.SBJson.JsonElement form, string path);
        /*0x160be28*/ void HttpUploadMultiPart(System.IO.Stream rs, System.Collections.Generic.Dictionary<string, string> form, string path, string fileFieldName, string filename);
        /*0x160ae28*/ void CheckRouting(SendBird.APIClient.CheckRoutingHandler handler);
        /*0x160d454*/ SendBird.SBJson.JsonObject DefaultForm();
        /*0x160d4b0*/ void SetChannelInvitationPreference(bool autoAccept, SendBird.APIClient.APIClientHandler handler);
        /*0x160d5a8*/ void GetChannelInvitationPreference(SendBird.APIClient.APIClientHandler handler);
        /*0x160d668*/ void GroupChannelInvite(string channelUrl, System.Collections.Generic.List<string> userIds, SendBird.APIClient.APIClientHandler handler);
        /*0x160d8f8*/ void GroupChannelAcceptInvitation(string channelUrl, string accessCode, SendBird.APIClient.APIClientHandler handler);
        /*0x160d904*/ void GroupChannelAcceptInvitation(string channelUrl, string accessCode, string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x160da90*/ void GroupChannelJoin(string channelUrl, string accessCode, SendBird.APIClient.APIClientHandler handler);
        /*0x160dc10*/ void GroupChannelDeclineInvitation(string channelUrl, string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x160dd24*/ void GroupChannelDeclineInvitation(string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x160de60*/ void GroupChannelHide(string channelUrl, bool hidePreviousMessages, bool allowAutoUnhide, SendBird.APIClient.APIClientHandler handler);
        /*0x160dff8*/ void GroupChannelLeave(string channelUrl, string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x160e0fc*/ void GroupChannelMarkAsRead(string channelUrl, string userId, long ts, SendBird.APIClient.APIClientHandler handler);
        /*0x160e22c*/ void GroupChannelMarkAsReadAll(string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x160e2f4*/ void MessageList(bool isOpenChannel, string channelUrl, long messageTimestamp, int prevLimit, int nextLimit, bool include, bool reverse, SendBird.APIClient.APIClientHandler handler);
        /*0x160e5a4*/ void Login(string userId, string accessToken, SendBird.APIClient.APIClientHandler handler);
        /*0x160e780*/ void UpdateUserInfo(string userId, string nickname, string profileUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x160e8bc*/ void UpdateUserInfo(string userId, string nickname, SendBird.SBFile profileFile, SendBird.APIClient.APIClientHandler handler);
        /*0x160ea40*/ void GetGroupChannel(string channelUrl, bool member, bool readReceipt, SendBird.APIClient.APIClientHandler handler);
        /*0x160ec34*/ void GetOpenChannel(string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x160ecf4*/ void CreateGroupChannel(System.Collections.Generic.List<string> userIds, System.Collections.Generic.List<string> operatorIds, bool isSuper, bool isPublic, bool isEphemeral, bool isDistinct, bool isDiscoverable, string channelUrl, string name, string coverUrl, string data, string customType, string accessCode, bool strict, bool isBroadcast, int messageSurvivalSeconds, SendBird.APIClient.APIClientHandler handler);
        /*0x160f320*/ void CreateGroupChannel(System.Collections.Generic.List<string> userIds, bool isDistinct, string channelUrl, string name, string coverUrl, string data, string customType, System.Collections.Generic.List<string> operatorIds, SendBird.APIClient.APIClientHandler handler);
        /*0x160f834*/ void CreateGroupChannel(System.Collections.Generic.List<string> userIds, bool isDistinct, string name, SendBird.SBFile coverFile, string data, string customType, System.Collections.Generic.List<string> operatorIds, SendBird.APIClient.APIClientHandler handler);
        /*0x160fdec*/ void UpdateGroupChannel(string channelUrl, bool isDistinct, string name, string coverUrl, string data, string customType, System.Collections.Generic.List<string> operatorIds, SendBird.APIClient.APIClientHandler handler);
        /*0x1610174*/ void UpdateGroupChannel(string channelUrl, bool isDistinct, string name, SendBird.SBFile coverFile, string data, string customType, System.Collections.Generic.List<string> operatorIds, SendBird.APIClient.APIClientHandler handler);
        /*0x16105d0*/ void CreateOpenChannel(string name, string coverUrl, string data, string customType, System.Collections.Generic.List<string> operatorUserIds, SendBird.APIClient.APIClientHandler handler);
        /*0x16108f8*/ void CreateOpenChannel(string name, SendBird.SBFile coverFile, string data, string customType, System.Collections.Generic.List<string> operatorUserIds, SendBird.APIClient.APIClientHandler handler);
        /*0x1610cd4*/ void UpdateOpenChannel(string channelUrl, string name, string coverUrl, string data, string customType, System.Collections.Generic.List<string> operatorUserIds, SendBird.APIClient.APIClientHandler handler);
        /*0x1611048*/ void UpdateOpenChannel(string channelUrl, string name, SendBird.SBFile coverFile, string data, string customType, System.Collections.Generic.List<string> operatorUserIds, SendBird.APIClient.APIClientHandler handler);
        /*0x1611458*/ void DeleteChannel(string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x1611514*/ void CreateMetaCounters(bool isOpenChannel, string channelUrl, System.Collections.Generic.Dictionary<string, int> metaCounterMap, SendBird.APIClient.APIClientHandler handler);
        /*0x161178c*/ void UpdateMetaCounters(bool isOpenChannel, string channelUrl, System.Collections.Generic.Dictionary<string, int> metaCounterMap, bool upsert, int mode, SendBird.APIClient.APIClientHandler handler);
        /*0x1611a9c*/ void GetAllMetaCounters(bool isOpenChannel, string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x1611b3c*/ void GetMetaCounters(bool isOpenChannel, string channelUrl, System.Collections.Generic.List<string> keys, SendBird.APIClient.APIClientHandler handler);
        /*0x1611e68*/ void DeleteMetaCounter(bool isOpenChannel, string channelUrl, string key, SendBird.APIClient.APIClientHandler handler);
        /*0x1611f54*/ void DeleteAllMetaCounters(bool isOpenChannel, string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x1612028*/ void CreateMetaData(bool isOpenChannel, string channelUrl, System.Collections.Generic.Dictionary<string, string> metaDataMap, SendBird.APIClient.APIClientHandler handler);
        /*0x161229c*/ void UpdateMetaData(bool isOpenChannel, string channelUrl, System.Collections.Generic.Dictionary<string, string> metaDataMap, bool upsert, SendBird.APIClient.APIClientHandler handler);
        /*0x1612544*/ void GetAllMetaData(bool isOpenChannel, string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x16125e4*/ void GetMetaData(bool isOpenChannel, string channelUrl, System.Collections.Generic.List<string> keys, SendBird.APIClient.APIClientHandler handler);
        /*0x1612910*/ void DeleteMetaData(bool isOpenChannel, string channelUrl, string key, SendBird.APIClient.APIClientHandler handler);
        /*0x16129fc*/ void DeleteAllMetaData(bool isOpenChannel, string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x1607c44*/ void LoadUserList(string token, int limit, System.Collections.Generic.List<string> userIds, SendBird.APIClient.APIClientHandler handler);
        /*0x1607fcc*/ void LoadBlockedUserList(string blockerUserId, string token, int limit, SendBird.APIClient.APIClientHandler handler);
        /*0x1612ad0*/ void LoadOpenChannelList(string token, int limit, string nameKeyword, string urlKeyword, SendBird.APIClient.APIClientHandler handler);
        /*0x1612cf0*/ void UploadFile(string path, SendBird.APIClient.APIClientHandler handler);
        /*0x1612d78*/ void UploadProfileImage(string path, SendBird.APIClient.APIClientHandler handler);
        /*0x1612e00*/ void LoadUserGroupChannelList(string token, int limit, bool includeEmpty, string order, SendBird.GroupChannelListQuery.FilterMode mode, System.Collections.Generic.List<string> filter, SendBird.GroupChannelListQuery.QueryType queryType, System.Collections.Generic.List<string> customTypesFilter, SendBird.APIClient.APIClientHandler handler);
        /*0x1612e28*/ void LoadUserGroupChannelList(string token, int limit, bool includeEmpty, string order, SendBird.GroupChannelListQuery.FilterMode mode, System.Collections.Generic.List<string> filter, SendBird.GroupChannelListQuery.QueryType queryType, System.Collections.Generic.List<string> customTypesFilter, string memberState, SendBird.APIClient.APIClientHandler handler);
        /*0x161357c*/ void LoadUserGroupChannelList(string token, int limit, bool includeEmpty, string order, SendBird.GroupChannelListQuery.FilterMode mode, System.Collections.Generic.List<string> filter, SendBird.GroupChannelListQuery.QueryType queryType, System.Collections.Generic.List<string> customTypesFilter, string memberState, SendBird.GroupChannelListQuery.HiddenChannelFilter hiddenChannelFilter, SendBird.APIClient.APIClientHandler handler);
        /*0x1608170*/ void LoadOpenChannelParticipantList(string channelUrl, string token, int limit, SendBird.APIClient.APIClientHandler handler);
        /*0x1613d44*/ void LoadOpenChannelMutedList(string channelUrl, string token, int limit, SendBird.APIClient.APIClientHandler handler);
        /*0x1608314*/ void LoadMutedUserList(bool isOpenChannel, string channelUrl, string token, int limit, SendBird.APIClient.APIClientHandler handler);
        /*0x1613ee8*/ void LoadOpenChannelBanList(string channelUrl, string token, int limit, SendBird.APIClient.APIClientHandler handler);
        /*0x16084e0*/ void LoadBannedUserList(bool isOpenChannel, string channelUrl, string token, int limit, SendBird.APIClient.APIClientHandler handler);
        /*0x161408c*/ void RegisterFCMPushToken(string userId, string gcmRegToken, SendBird.APIClient.APIClientHandler handler);
        /*0x1614190*/ void UnregisterFCMPushToken(string userId, string gcmRegToken, SendBird.APIClient.APIClientHandler handler);
        /*0x161426c*/ void RegisterAPNSPushToken(string userId, string apnsRegToken, SendBird.APIClient.APIClientHandler handler);
        /*0x1614370*/ void UnregisterAPNSPushToken(string userId, string apnsRegToken, SendBird.APIClient.APIClientHandler handler);
        /*0x161444c*/ void UnregisterPushTokenAll(string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x1614508*/ void BlockUser(string blockerUserId, string blockeeUserId, SendBird.APIClient.APIClientHandler handler);
        /*0x161460c*/ void UnblockUser(string blockerUserId, string blockeeUserId, SendBird.APIClient.APIClientHandler handler);
        /*0x16146e8*/ void BanUser(bool isOpenChannel, string channelUrl, string userId, string description, int seconds, SendBird.APIClient.APIClientHandler handler);
        /*0x1614860*/ void UnbanUser(bool isOpenChannel, string channelUrl, string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x161494c*/ void MuteUser(string channelUrl, string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x1614a50*/ void MuteUser(bool isOpenChannel, string channelUrl, string userId, string description, int seconds, SendBird.APIClient.APIClientHandler handler);
        /*0x1614bec*/ void UnmuteUser(string channelUrl, string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x1614cc8*/ void GetTotalUnreadMessageCount(string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x1614d88*/ void SetDoNotDisturb(string userId, bool enable, int startHour, int startMin, int endHour, int endMin, string timezone, SendBird.APIClient.APIClientHandler handler);
        /*0x1614f7c*/ void GetDoNotDisturb(string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x161503c*/ void SetPushPreference(string userId, string channelUrl, bool value, SendBird.APIClient.APIClientHandler handler);
        /*0x1615158*/ void GetPushPreference(string userId, string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x1615238*/ void DeleteMessage(bool isOpenChannel, string channelUrl, long messageId, SendBird.APIClient.APIClientHandler handler);
        /*0x1615328*/ void UpdateMessage(bool isOpenChannel, string channelUrl, long messageId, string message, string data, string customType, SendBird.BaseMessage.MentionType mentionType, System.Collections.Generic.List<string> mentionedUserIds, SendBird.APIClient.APIClientHandler handler);
        /*0x1615724*/ void SetSessionKey(string sessionKey);
        /*0x1615730*/ string GetSessionKey();
        /*0x1615738*/ void LoadGroupChannelMemberList(string channelUrl, string token, int limit, SendBird.GroupChannelMemberListQuery.OperatorFilter operatorFilter, SendBird.GroupChannelMemberListQuery.MutedMemberFilter mutedMemberFilter, string order, string memberState, string nicknameStartsWith, SendBird.APIClient.APIClientHandler handler);
        /*0x1615abc*/ void UnMuteUser(bool isOpenChannel, string channelUrl, string userId, SendBird.APIClient.APIClientHandler handler);
        /*0x1615bb0*/ void GroupChannelUnHide(string channelUrl, SendBird.APIClient.APIClientHandler handler);
        /*0x1615ce0*/ void ReportChannel(bool isOpenChannel, string channelUrl, SendBird.BaseChannel.ReportCategory reportCategory, string reportDescription, SendBird.APIClient.APIClientHandler handler);
        /*0x1615f1c*/ void ReportUser(bool isOpenChannel, string channelUrl, string offendingUserId, SendBird.BaseChannel.ReportCategory reportCategory, string reportDescription, SendBird.APIClient.APIClientHandler handler);
        /*0x1616180*/ void ReportMessage(bool isOpenChannel, string channelUrl, string offendingUserId, long messageId, SendBird.BaseChannel.ReportCategory reportCategory, string reportDescription, SendBird.APIClient.APIClientHandler handler);

        class FileRequestState
        {
            static int BUFFER_SIZE = 8192;
            /*0x10*/ System.Net.WebRequest Request;
            /*0x18*/ SendBird.APIClient.APIClientHandler Handler;

            /*0x1616414*/ FileRequestState();
        }

        class APIClientHandler : System.MulticastDelegate
        {
            /*0x1616430*/ APIClientHandler(object object, nint method);
            /*0x1616560*/ void Invoke(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
            /*0x1616574*/ System.IAsyncResult BeginInvoke(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x161659c*/ void EndInvoke(System.IAsyncResult result);
        }

        class RequestState
        {
            static int BUFFER_SIZE = 8192;
            /*0x10*/ System.Net.WebRequest Request;
            /*0x18*/ SendBird.APIClient.APIClientHandler Handler;
            /*0x20*/ byte[] BufferRead;
            /*0x28*/ byte[] RequestData;
            /*0x30*/ System.IO.Stream RequestStream;
            /*0x38*/ System.IO.Stream ResponseStream;
            /*0x40*/ System.Collections.Generic.List<byte> ResponseData;

            /*0x16165a8*/ RequestState();
        }

        class CheckRoutingHandler : System.MulticastDelegate
        {
            /*0x1616664*/ CheckRoutingHandler(object object, nint method);
            /*0x161673c*/ void Invoke(string apiHost, string wsHost, SendBird.SendBirdException e);
            /*0x1616750*/ System.IAsyncResult BeginInvoke(string apiHost, string wsHost, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x161677c*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass77_0
        {
            /*0x10*/ SendBird.APIClient.APIClientHandler handler;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> map;
            /*0x20*/ string url;
            /*0x28*/ SendBird.APIClient <>4__this;

            /*0x1616788*/ <>c__DisplayClass77_0();
            /*0x1616790*/ void <RequestGET>b__0(string mAPIHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass78_0
        {
            /*0x10*/ SendBird.APIClient.APIClientHandler handler;
            /*0x18*/ SendBird.SBJson.JsonElement form;
            /*0x20*/ SendBird.APIClient <>4__this;
            /*0x28*/ string url;

            /*0x1616d34*/ <>c__DisplayClass78_0();
            /*0x1616d3c*/ void <RequestPOST>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass79_0
        {
            /*0x10*/ SendBird.APIClient.APIClientHandler handler;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> form;
            /*0x20*/ string fileFieldName;
            /*0x28*/ SendBird.SBFile file;
            /*0x30*/ SendBird.APIClient <>4__this;
            /*0x38*/ string url;

            /*0x16170f8*/ <>c__DisplayClass79_0();
            /*0x1617100*/ void <RequestPOST>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass79_1
        {
            /*0x10*/ System.Net.HttpWebRequest request;
            /*0x18*/ SendBird.APIClient.<> CS$<>8__locals1;

            /*0x1617578*/ <>c__DisplayClass79_1();
            /*0x16175dc*/ void <RequestPOST>b__1(System.IAsyncResult ar);
        }

        class <>c__DisplayClass79_2
        {
            /*0x10*/ SendBird.APIClient.FileRequestState frs;

            /*0x1617abc*/ <>c__DisplayClass79_2();
            /*0x1617ac4*/ void <RequestPOST>b__2(System.IAsyncResult a);
        }

        class <>c__DisplayClass80_0
        {
            /*0x10*/ SendBird.APIClient.APIClientHandler handler;
            /*0x18*/ SendBird.SBJson.JsonElement form;
            /*0x20*/ SendBird.APIClient <>4__this;
            /*0x28*/ string url;

            /*0x1618160*/ <>c__DisplayClass80_0();
            /*0x1618168*/ void <RequestPUT>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass81_0
        {
            /*0x10*/ SendBird.APIClient.APIClientHandler handler;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> form;
            /*0x20*/ string fileFieldName;
            /*0x28*/ SendBird.SBFile file;
            /*0x30*/ SendBird.APIClient <>4__this;
            /*0x38*/ string url;

            /*0x1618438*/ <>c__DisplayClass81_0();
            /*0x1618440*/ void <RequestPUT>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass81_1
        {
            /*0x10*/ System.Net.HttpWebRequest request;
            /*0x18*/ SendBird.APIClient.<> CS$<>8__locals1;

            /*0x16188b8*/ <>c__DisplayClass81_1();
            /*0x16188c0*/ void <RequestPUT>b__1(System.IAsyncResult ar);
        }

        class <>c__DisplayClass81_2
        {
            /*0x10*/ SendBird.APIClient.FileRequestState frs;

            /*0x1618da0*/ <>c__DisplayClass81_2();
            /*0x1618da8*/ void <RequestPUT>b__2(System.IAsyncResult a);
        }

        class <>c__DisplayClass82_0
        {
            /*0x10*/ SendBird.APIClient <>4__this;
            /*0x18*/ string url;
            /*0x20*/ SendBird.APIClient.APIClientHandler handler;

            /*0x161953c*/ <>c__DisplayClass82_0();
            /*0x1619544*/ void <RequestDELETE>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass83_0
        {
            /*0x10*/ SendBird.APIClient <>4__this;
            /*0x18*/ string url;
            /*0x20*/ SendBird.APIClient.APIClientHandler handler;
            /*0x28*/ SendBird.SBJson.JsonElement form;

            /*0x16197fc*/ <>c__DisplayClass83_0();
            /*0x1619804*/ void <RequestDELETE>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass85_0
        {
            /*0x10*/ SendBird.APIClient.APIClientHandler handler;
            /*0x18*/ string path;
            /*0x20*/ SendBird.SBJson.JsonElement form;
            /*0x28*/ SendBird.APIClient <>4__this;
            /*0x30*/ string url;

            /*0x1619b50*/ <>c__DisplayClass85_0();
            /*0x1619b58*/ void <RequestFILE>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass85_1
        {
            /*0x10*/ System.Net.HttpWebRequest request;
            /*0x18*/ SendBird.APIClient.<> CS$<>8__locals1;

            /*0x1619ed8*/ <>c__DisplayClass85_1();
            /*0x1619ee0*/ void <RequestFILE>b__1(System.IAsyncResult ar);
        }

        class <>c__DisplayClass85_2
        {
            /*0x10*/ SendBird.APIClient.FileRequestState frs;

            /*0x161a388*/ <>c__DisplayClass85_2();
            /*0x161a390*/ void <RequestFILE>b__2(System.IAsyncResult a);
        }

        class <>c__DisplayClass111_0
        {
            /*0x10*/ SendBird.APIClient.APIClientHandler handler;
            /*0x18*/ SendBird.APIClient <>4__this;

            /*0x161aa4c*/ <>c__DisplayClass111_0();
            /*0x161aa54*/ void <Login>b__0(SendBird.SBJson.JsonElement response, SendBird.SendBirdException e);
        }
    }

    class Command
    {
        static /*0x0*/ long requestIdSeed;
        /*0x10*/ string command;
        /*0x18*/ string payload;
        /*0x20*/ string requestId;

        static /*0x161c7a0*/ Command();
        static /*0x161ab5c*/ string generateRequestId();
        static /*0x161b1a0*/ SendBird.Command bUpdateMessage(string channelUrl, long messageId, string message, string data, string customType, SendBird.BaseMessage.MentionType mentionType, System.Collections.Generic.List<string> mentionedUserIds);
        static /*0x161b914*/ SendBird.Command BMessage(string channelUrl, string message, string data, string customType, System.Collections.Generic.List<string> mentionedUserIds, System.Collections.Generic.List<string> targetLangs);
        static /*0x161bddc*/ SendBird.Command BTypeStart(string channelUrl, long time);
        static /*0x161bedc*/ SendBird.Command BTypeEnd(string channelUrl, long time);
        static /*0x161bfdc*/ SendBird.Command BRead(string channelUrl);
        static /*0x161c0ac*/ SendBird.Command BMsgAck(string channelUrl, long msgId);
        static /*0x161c1ac*/ SendBird.Command BFile(string requestId, string channelUrl, string url, string name, string type, int size, string data, string customType);
        static /*0x161c424*/ SendBird.Command BPing();
        static /*0x161c5dc*/ SendBird.Command BEnter(string channelUrl);
        static /*0x161c6ac*/ SendBird.Command BExit(string channelUrl);
        /*0x161abc0*/ Command(string data);
        /*0x161ade8*/ Command(string command, SendBird.SBJson.JsonElement payload);
        /*0x161adf0*/ Command(string command, SendBird.SBJson.JsonElement payload, string reqId);
        /*0x161af9c*/ bool IsAckRequired();
        /*0x161ad44*/ bool IsRequestIdCommand();
        /*0x161b0dc*/ string get_RequestId();
        /*0x161b0e4*/ string Encode();
        /*0x161b130*/ void Decode(string command);
        /*0x161b18c*/ string get_CMD();
        /*0x161b194*/ string get_Payload();
        /*0x161adb4*/ SendBird.SBJson.JsonElement AsJsonElement();
        /*0x161c77c*/ bool HasRequestId();

        class SendCommandHandler : System.MulticastDelegate
        {
            /*0x161c810*/ SendCommandHandler(object object, nint method);
            /*0x161c940*/ void Invoke(SendBird.Command acked, SendBird.SendBirdException e);
            /*0x161c954*/ System.IAsyncResult BeginInvoke(SendBird.Command acked, SendBird.SendBirdException e, System.AsyncCallback callback, object object);
            /*0x161c97c*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class CountDownTimer
    {
        /*0x10*/ SendBird.CountDownTimer._CountDownTimer mTimer;
        /*0x18*/ int mTimeout;
        /*0x1c*/ int mTick;
        /*0x20*/ bool mLoop;
        /*0x28*/ SendBird.CountDownTimer.CountDownTimerEventHandler mHandler;

        /*0x161c988*/ CountDownTimer(int timeout);
        /*0x161c9b8*/ CountDownTimer(int timeout, int tick);
        /*0x161c9e8*/ CountDownTimer(int timeout, int tick, bool loop);
        /*0x161ca24*/ void SetEventHandler(SendBird.CountDownTimer.CountDownTimerEventHandler handler);
        /*0x161ca2c*/ void Start();
        /*0x161cad4*/ void Stop();
        /*0x161cc18*/ void Cancel();

        class CountDownTimerEventHandler
        {
            /*0x10*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate OnStart;
            /*0x18*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStopDelegate OnStop;
            /*0x20*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnCancelDelegate OnCancel;
            /*0x28*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTimeoutDelegate OnTimeout;
            /*0x30*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate OnTick;

            /*0x161cc58*/ CountDownTimerEventHandler(SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate onStart, SendBird.CountDownTimer.CountDownTimerEventHandler.OnStopDelegate onStop, SendBird.CountDownTimer.CountDownTimerEventHandler.OnCancelDelegate onCancel, SendBird.CountDownTimer.CountDownTimerEventHandler.OnTimeoutDelegate onTimeout, SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate onTick);

            class OnStartDelegate : System.MulticastDelegate
            {
                /*0x161cca8*/ OnStartDelegate(object object, nint method);
                /*0x161cd64*/ void Invoke();
                /*0x161cd78*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x161cd98*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnStopDelegate : System.MulticastDelegate
            {
                /*0x161cda4*/ OnStopDelegate(object object, nint method);
                /*0x161ce60*/ void Invoke();
                /*0x161ce74*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x161ce94*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnCancelDelegate : System.MulticastDelegate
            {
                /*0x161cea0*/ OnCancelDelegate(object object, nint method);
                /*0x161cf5c*/ void Invoke();
                /*0x161cf70*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x161cf90*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnTimeoutDelegate : System.MulticastDelegate
            {
                /*0x161cf9c*/ OnTimeoutDelegate(object object, nint method);
                /*0x161d058*/ void Invoke();
                /*0x161d06c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x161d08c*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnTickDelegate : System.MulticastDelegate
            {
                /*0x161d098*/ OnTickDelegate(object object, nint method);
                /*0x161d15c*/ void Invoke(int timeout, int elapsed);
                /*0x161d170*/ System.IAsyncResult BeginInvoke(int timeout, int elapsed, System.AsyncCallback callback, object object);
                /*0x161d208*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class _CountDownTimer
        {
            /*0x10*/ bool mLoop;
            /*0x14*/ int mTimeout;
            /*0x18*/ int mTick;
            /*0x20*/ System.Threading.Thread mTimer;
            /*0x28*/ SendBird.CountDownTimer.CountDownTimerEventHandler mHandler;
            /*0x30*/ bool mCanceled;
            /*0x31*/ bool mStartCalled;
            /*0x32*/ bool mStopFlag;

            /*0x161d214*/ _CountDownTimer(int timeout);
            /*0x161d248*/ _CountDownTimer(int timeout, int tick);
            /*0x161caf8*/ _CountDownTimer(int timeout, int tick, bool loop);
            /*0x161d27c*/ void SetEventHandler(SendBird.CountDownTimer.CountDownTimerEventHandler handler);
            /*0x161cb38*/ void Start();
            /*0x161d284*/ void Run();
            /*0x161cc00*/ void Stop();
            /*0x161cc3c*/ void Cancel();
        }
    }

    class CountdownLatch
    {
        /*0x10*/ int m_remain;
        /*0x18*/ System.Threading.EventWaitHandle m_event;

        /*0x161d588*/ CountdownLatch(int count);
        /*0x161d608*/ void Countdown();
        /*0x161d640*/ void Await();
    }

    class Dispatcher
    {
        static /*0x0*/ SendBird.Dispatcher <Instance>k__BackingField;
        /*0x10*/ System.Collections.IEnumerator <DispatcherCoroutine>k__BackingField;
        /*0x18*/ System.Threading.ReaderWriterLock dispatchQueueLock;
        /*0x20*/ System.Collections.Generic.Queue<SendBird.MyAction> dispatchQueue;
        /*0x28*/ UnityEngine.GameObject <GameObject>k__BackingField;

        static /*0x161d660*/ Dispatcher();
        static /*0x161d7ac*/ SendBird.Dispatcher get_Instance();
        static /*0x161d804*/ void set_Instance(SendBird.Dispatcher value);
        /*0x161d6f0*/ Dispatcher();
        /*0x161d860*/ System.Collections.IEnumerator get_DispatcherCoroutine();
        /*0x161d868*/ void set_DispatcherCoroutine(System.Collections.IEnumerator value);
        /*0x161d870*/ UnityEngine.GameObject get_GameObject();
        /*0x161d878*/ void set_GameObject(UnityEngine.GameObject value);
        /*0x161d8e8*/ void Post(SendBird.MyAction action);
        /*0x161d880*/ System.Collections.IEnumerator CreateDispatcherCoroutine();

        class <CreateDispatcherCoroutine>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ SendBird.Dispatcher <>4__this;

            /*0x161da04*/ <CreateDispatcherCoroutine>d__17(int <>1__state);
            /*0x161da2c*/ void System.IDisposable.Dispose();
            /*0x161da30*/ bool MoveNext();
            /*0x161de54*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x161de5c*/ void System.Collections.IEnumerator.Reset();
            /*0x161de9c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class Logger
    {
        static /*0x0*/ int NONE;
        static /*0x4*/ int INFO;
        static /*0x8*/ int DEBUG;
        static /*0xc*/ int sLevel;

        static /*0x161e0b4*/ Logger();
        static /*0x161dea4*/ void I(string message);
        static /*0x161dd78*/ void E(System.Exception e);
        static /*0x161e008*/ void E(string message);
        static /*0x161700c*/ void D(string message);
        static /*0x1619464*/ void D(System.Exception e);
        static /*0x161df48*/ void Write(string message);
        /*0x161e0ac*/ Logger();
    }

    class MyAction : System.MulticastDelegate
    {
        /*0x161e104*/ MyAction(object object, nint method);
        /*0x161e1c0*/ void Invoke();
        /*0x161e1d4*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
        /*0x161e1f4*/ void EndInvoke(System.IAsyncResult result);
    }

    class Utils
    {
        static /*0x0*/ System.DateTime Jan1st1970;

        static /*0x161e260*/ Utils();
        static /*0x161c518*/ long CurrentTimeMillis();
        static /*0x161e200*/ string UrlEncodeUTF8(string s);
        static /*0x1616ae4*/ string UrlEncodeUTF8(System.Collections.Generic.Dictionary<string, string> map);
        /*0x161e258*/ Utils();
    }

    class WSClient
    {
        static /*0x0*/ string WS_ROUTING_URL;
        static /*0x8*/ object syncLock;
        /*0x10*/ SendBird.WSClient.WSClientHandler mHandler;
        /*0x18*/ System.Text.StringBuilder mRecvBuffer;
        /*0x20*/ SendBird.CountDownTimer mWatchdog;
        /*0x28*/ SendBird.CountDownTimer mPinger;
        /*0x30*/ long mLastActiveMillis;
        /*0x38*/ bool mExplicitDisconnect;
        /*0x40*/ WebSocketSharp.WebSocket mWebsocket;
        /*0x48*/ bool mIsDisconnected;

        static /*0x161f364*/ WSClient();
        /*0x161e2e4*/ WSClient();
        /*0x161e2dc*/ void SetEventHandler(SendBird.WSClient.WSClientHandler handler);
        /*0x161e85c*/ void InitWebSocket(string userId, string accessToken);
        /*0x161e968*/ void Active();
        /*0x161ea2c*/ void Connect();
        /*0x161ee10*/ void Disconnect();
        /*0x161f034*/ SendBird.SendBirdClient.ConnectionState GetConnectionState();
        /*0x161ee1c*/ void Quit();
        /*0x161f060*/ void Send(SendBird.Command command, SendBird.WSClient.WSClientSendHandler handler);
        /*0x161f408*/ void <.ctor>b__11_3();
        /*0x161f520*/ void <.ctor>b__11_5();
        /*0x161f5b8*/ void <.ctor>b__11_6();
        /*0x161f650*/ void <.ctor>b__11_8();
        /*0x161f720*/ void <Connect>b__14_0(object sender, System.EventArgs e);
        /*0x161f7b8*/ void <Connect>b__14_1(object sender, WebSocketSharp.ErrorEventArgs e);
        /*0x161f8fc*/ void <Connect>b__14_2(object sender, WebSocketSharp.MessageEventArgs e);
        /*0x161fb98*/ void <Connect>b__14_3(object sender, WebSocketSharp.CloseEventArgs e);

        class WSClientHandler
        {
            /*0x10*/ SendBird.WSClient.WSClientHandler.OnReadyDelegate OnReady;
            /*0x18*/ SendBird.WSClient.WSClientHandler.OnOpenDelegate OnOpen;
            /*0x20*/ SendBird.WSClient.WSClientHandler.OnCloseDelegate OnClose;
            /*0x28*/ SendBird.WSClient.WSClientHandler.OnMessageDelegate OnMessage;
            /*0x30*/ SendBird.WSClient.WSClientHandler.OnErrorDelegate OnError;

            /*0x161fd24*/ WSClientHandler(SendBird.WSClient.WSClientHandler.OnReadyDelegate onReady, SendBird.WSClient.WSClientHandler.OnOpenDelegate onOpen, SendBird.WSClient.WSClientHandler.OnCloseDelegate onClose, SendBird.WSClient.WSClientHandler.OnMessageDelegate onMessage, SendBird.WSClient.WSClientHandler.OnErrorDelegate onError);

            class OnReadyDelegate : System.MulticastDelegate
            {
                /*0x161fd74*/ OnReadyDelegate(object object, nint method);
                /*0x161fe30*/ void Invoke();
                /*0x161fe44*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x161fe64*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnOpenDelegate : System.MulticastDelegate
            {
                /*0x161fe70*/ OnOpenDelegate(object object, nint method);
                /*0x161ff2c*/ void Invoke();
                /*0x161ff40*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x161ff60*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnCloseDelegate : System.MulticastDelegate
            {
                /*0x161ff6c*/ OnCloseDelegate(object object, nint method);
                /*0x1620028*/ void Invoke();
                /*0x162003c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x162005c*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnMessageDelegate : System.MulticastDelegate
            {
                /*0x1620068*/ OnMessageDelegate(object object, nint method);
                /*0x162013c*/ void Invoke(string message);
                /*0x1620150*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                /*0x1620170*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnErrorDelegate : System.MulticastDelegate
            {
                /*0x162017c*/ OnErrorDelegate(object object, nint method);
                /*0x16202a8*/ void Invoke(SendBird.SendBirdException e);
                /*0x16202bc*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
                /*0x16202dc*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class WSClientSendHandler
        {
            /*0x10*/ SendBird.WSClient.WSClientSendHandler.OnResultDelegate OnResult;

            /*0x16202e8*/ WSClientSendHandler(SendBird.WSClient.WSClientSendHandler.OnResultDelegate onResult);

            class OnResultDelegate : System.MulticastDelegate
            {
                /*0x1620310*/ OnResultDelegate(object object, nint method);
                /*0x162043c*/ void Invoke(SendBird.SendBirdException e);
                /*0x1620450*/ System.IAsyncResult BeginInvoke(SendBird.SendBirdException e, System.AsyncCallback callback, object object);
                /*0x1620470*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class <>c
        {
            static /*0x0*/ SendBird.WSClient.<> <>9;
            static /*0x8*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStartDelegate <>9__11_0;
            static /*0x10*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnStopDelegate <>9__11_1;
            static /*0x18*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnCancelDelegate <>9__11_2;
            static /*0x20*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate <>9__11_4;
            static /*0x28*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnCancelDelegate <>9__11_7;
            static /*0x30*/ SendBird.CountDownTimer.CountDownTimerEventHandler.OnTickDelegate <>9__11_9;
            static /*0x38*/ System.Net.Security.RemoteCertificateValidationCallback <>9__12_1;

            static /*0x162047c*/ <>c();
            /*0x16204e0*/ <>c();
            /*0x16204e8*/ void <.ctor>b__11_0();
            /*0x162054c*/ void <.ctor>b__11_1();
            /*0x16205b0*/ void <.ctor>b__11_2();
            /*0x1620614*/ void <.ctor>b__11_4(int timeout, int elapsed);
            /*0x1620618*/ void <.ctor>b__11_7();
            /*0x162067c*/ void <.ctor>b__11_9(int timeout, int elapsed);
            /*0x1620680*/ bool <InitWebSocket>b__12_1(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ SendBird.WSClient <>4__this;
            /*0x18*/ string userId;
            /*0x20*/ string accessToken;

            /*0x161e960*/ <>c__DisplayClass12_0();
            /*0x162072c*/ void <InitWebSocket>b__0(string apiHost, string wsHost, SendBird.SendBirdException e);
        }

        class <>c__DisplayClass18_0
        {
            /*0x10*/ SendBird.WSClient.WSClientSendHandler handler;

            /*0x161f35c*/ <>c__DisplayClass18_0();
            /*0x1620da8*/ void <Send>b__0(bool completed);
        }
    }

    class SBFile
    {
        /*0x10*/ string mPath;

        /*0x1620ea4*/ SBFile(string path);
        /*0x1620ecc*/ string get_Path();
        /*0x1617580*/ string get_FileName();
        /*0x1620ed4*/ long get_Length();
    }

    class GroupChannelParams
    {
        /*0x10*/ System.Collections.Generic.List<string> mUserIds;
        /*0x18*/ System.Collections.Generic.List<string> mOperatorUserIds;
        /*0x20*/ bool mIsSuper;
        /*0x21*/ bool mIsPublic;
        /*0x22*/ bool mIsEphemeral;
        /*0x23*/ bool mIsDistinct;
        /*0x24*/ bool mIsDiscoverable;
        /*0x28*/ string mChannelUrl;
        /*0x30*/ string mName;
        /*0x38*/ object mCoverUrlOrImage;
        /*0x40*/ string mData;
        /*0x48*/ string mCustomType;
        /*0x50*/ string mAccessCode;
        /*0x58*/ bool mStrict;
        /*0x59*/ bool isBroadcast;
        /*0x5c*/ int messageSurvivalSeconds;

        /*0x1620f40*/ GroupChannelParams();
        /*0x1620fc0*/ SendBird.GroupChannelParams AddUser(SendBird.User user);
        /*0x162107c*/ SendBird.GroupChannelParams AddUsers(System.Collections.Generic.List<SendBird.User> users);
        /*0x162125c*/ SendBird.GroupChannelParams AddUserId(string userId);
        /*0x1621314*/ SendBird.GroupChannelParams AddUserIds(System.Collections.Generic.List<string> userIds);
        /*0x16214dc*/ SendBird.GroupChannelParams SetSuper(bool isSuper);
        /*0x16214e8*/ SendBird.GroupChannelParams SetPublic(bool isPublic);
        /*0x16214f4*/ SendBird.GroupChannelParams SetEphemeral(bool isEphemeral);
        /*0x1621500*/ SendBird.GroupChannelParams SetDistinct(bool isDistinct);
        /*0x162150c*/ SendBird.GroupChannelParams SetDiscoverable(bool isDiscoverable);
        /*0x1621518*/ SendBird.GroupChannelParams SetChannelUrl(string channelUrl);
        /*0x1621520*/ SendBird.GroupChannelParams SetName(string name);
        /*0x1621528*/ SendBird.GroupChannelParams SetCoverUrl(string coverImageUrl);
        /*0x1621530*/ SendBird.GroupChannelParams SetData(string data);
        /*0x1621538*/ SendBird.GroupChannelParams SetCustomType(string customType);
        /*0x1621540*/ SendBird.GroupChannelParams SetOperators(System.Collections.Generic.List<SendBird.User> operators);
        /*0x16217a0*/ SendBird.GroupChannelParams SetOperatorUserIds(System.Collections.Generic.List<string> operatorUserIds);
        /*0x16219e8*/ SendBird.GroupChannelParams SetAccessCode(string accessCode);
        /*0x16219f0*/ SendBird.GroupChannelParams SetStrict(bool strict);
        /*0x16219fc*/ SendBird.GroupChannelParams SetBroadcast(bool broadcast);
        /*0x1621a08*/ SendBird.GroupChannelParams SetMessageSurvivalSeconds(int messageSurvivalSeconds);
    }

    namespace SBJson
    {
        enum JSONBinaryTag
        {
            Null = 0,
            Array = 1,
            Class = 2,
            Value = 3,
            IntValue = 4,
            LongValue = 5,
            DoubleValue = 6,
            BoolValue = 7,
            FloatValue = 8,
        }

        class JsonElement
        {
            /*0x10*/ SendBird.SBJson.JSONBinaryTag <Tag>k__BackingField;

            static /*0x161b898*/ SendBird.SBJson.JsonElement op_Implicit(string s);
            static /*0x16222ac*/ string op_Implicit(SendBird.SBJson.JsonElement d);
            static /*0x16222cc*/ SendBird.SBJson.JsonElement op_Implicit(int v);
            static /*0x162237c*/ SendBird.SBJson.JsonElement op_Implicit(bool v);
            static /*0x162242c*/ SendBird.SBJson.JsonElement op_Implicit(float v);
            static /*0x16224e4*/ SendBird.SBJson.JsonElement op_Implicit(double v);
            static /*0x16222c0*/ bool op_Equality(SendBird.SBJson.JsonElement a, object b);
            static /*0x161adbc*/ bool op_Inequality(SendBird.SBJson.JsonElement a, object b);
            static /*0x16225b0*/ string Escape(string aText);
            static /*0x162277c*/ SendBird.SBJson.JsonPrimitive Numberize(string token);
            static /*0x1622920*/ void AddElement(SendBird.SBJson.JsonElement ctx, string token, string tokenName, bool tokenIsString);
            static /*0x1622adc*/ SendBird.SBJson.JsonElement Parse(string aJSON);
            /*0x16232a0*/ JsonElement();
            /*0x1621a10*/ void Add(string aKey, SendBird.SBJson.JsonElement aItem);
            /*0x1621a14*/ SendBird.SBJson.JsonElement get_Item(int aIndex);
            /*0x1621a1c*/ void set_Item(int aIndex, SendBird.SBJson.JsonElement value);
            /*0x1621a20*/ SendBird.SBJson.JsonElement get_Item(string aKey);
            /*0x1621a28*/ void set_Item(string aKey, SendBird.SBJson.JsonElement value);
            /*0x1621a2c*/ string get_Value();
            /*0x1621a6c*/ void set_Value(string value);
            /*0x1621a70*/ int get_Count();
            /*0x1621a78*/ void Add(SendBird.SBJson.JsonElement aItem);
            /*0x1621ad8*/ SendBird.SBJson.JsonElement Remove(string aKey);
            /*0x1621ae0*/ bool isJsonObject();
            /*0x1621b58*/ bool isJsonArray();
            /*0x1621bd0*/ bool isJsonPrimitive();
            /*0x1621c48*/ SendBird.SBJson.JsonElement Remove(int aIndex);
            /*0x1621c50*/ SendBird.SBJson.JsonElement Remove(SendBird.SBJson.JsonElement aNode);
            /*0x1621c58*/ System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement> get_Children();
            /*0x1621cf8*/ System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement> get_DeepChildren();
            /*0x1621da0*/ string ToString();
            string ToJSON();
            /*0x1621de0*/ SendBird.SBJson.JSONBinaryTag get_Tag();
            /*0x1621de8*/ void set_Tag(SendBird.SBJson.JSONBinaryTag value);
            /*0x1621df0*/ int getAsInt();
            /*0x1621e00*/ SendBird.SBJson.JsonObject getAsJsonObject();
            /*0x1621e10*/ SendBird.SBJson.JsonArray getAsJsonArray();
            /*0x1621e20*/ string getAsstring();
            /*0x1621e2c*/ bool getAsBoolean();
            /*0x1621e3c*/ long getAsLong();
            /*0x1621e4c*/ int get_AsInt();
            /*0x1621e80*/ void set_AsInt(int value);
            /*0x1621ed4*/ long get_AsLong();
            /*0x1621f08*/ void set_AsLong(long value);
            /*0x1621f5c*/ float get_AsFloat();
            /*0x1621f94*/ void set_AsFloat(float value);
            /*0x1621fe8*/ double get_AsDouble();
            /*0x1622020*/ void set_AsDouble(double value);
            /*0x1622074*/ bool get_AsBool();
            /*0x162212c*/ void set_AsBool(bool value);
            /*0x16221bc*/ SendBird.SBJson.JsonArray get_AsArray();
            /*0x1622234*/ SendBird.SBJson.JsonObject get_AsObject();
            /*0x162259c*/ bool Equals(object obj);
            /*0x16225a8*/ int GetHashCode();

            class <get_Children>d__20 : System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ SendBird.SBJson.JsonElement <>2__current;
                /*0x20*/ int <>l__initialThreadId;

                /*0x1621cb4*/ <get_Children>d__20(int <>1__state);
                /*0x16232a8*/ void System.IDisposable.Dispose();
                /*0x16232ac*/ bool MoveNext();
                /*0x16232c4*/ SendBird.SBJson.JsonElement System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>.get_Current();
                /*0x16232cc*/ void System.Collections.IEnumerator.Reset();
                /*0x162330c*/ object System.Collections.IEnumerator.get_Current();
                /*0x1623314*/ System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement> System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>.GetEnumerator();
                /*0x16233a8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <get_DeepChildren>d__22 : System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ SendBird.SBJson.JsonElement <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ SendBird.SBJson.JsonElement <>4__this;
                /*0x30*/ System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement> <>7__wrap1;
                /*0x38*/ System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement> <>7__wrap2;

                /*0x1621d5c*/ <get_DeepChildren>d__22(int <>1__state);
                /*0x16233ac*/ void System.IDisposable.Dispose();
                /*0x1623464*/ bool MoveNext();
                /*0x1623948*/ void <>m__Finally1();
                /*0x1623898*/ void <>m__Finally2();
                /*0x16239f8*/ SendBird.SBJson.JsonElement System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>.get_Current();
                /*0x1623a00*/ void System.Collections.IEnumerator.Reset();
                /*0x1623a40*/ object System.Collections.IEnumerator.get_Current();
                /*0x1623a48*/ System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement> System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>.GetEnumerator();
                /*0x1623ae8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class JsonArray : SendBird.SBJson.JsonElement, System.Collections.IEnumerable
        {
            /*0x18*/ System.Collections.Generic.List<SendBird.SBJson.JsonElement> m_List;

            /*0x161b7c0*/ JsonArray();
            /*0x1623aec*/ SendBird.SBJson.JsonElement get_Item(int aIndex);
            /*0x1623c14*/ void set_Item(int aIndex, SendBird.SBJson.JsonElement value);
            /*0x1623d1c*/ SendBird.SBJson.JsonElement get_Item(string aKey);
            /*0x1623d6c*/ void set_Item(string aKey, SendBird.SBJson.JsonElement value);
            /*0x161b878*/ void add(SendBird.SBJson.JsonPrimitive value);
            /*0x1623dbc*/ SendBird.SBJson.JsonElement get(int index);
            /*0x1623dc8*/ int get_Count();
            /*0x1623e10*/ void Add(string aKey, SendBird.SBJson.JsonElement aItem);
            /*0x1623eb8*/ SendBird.SBJson.JsonElement Remove(int aIndex);
            /*0x1623f6c*/ SendBird.SBJson.JsonElement Remove(SendBird.SBJson.JsonElement aNode);
            /*0x1623fcc*/ System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement> get_Children();
            /*0x1624074*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1624104*/ string ToJSON();

            class <get_Children>d__15 : System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ SendBird.SBJson.JsonElement <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ SendBird.SBJson.JsonArray <>4__this;
                /*0x30*/ System.Collections.Generic.List.Enumerator<SendBird.SBJson.JsonElement> <>7__wrap1;

                /*0x1624030*/ <get_Children>d__15(int <>1__state);
                /*0x1624320*/ void System.IDisposable.Dispose();
                /*0x162433c*/ bool MoveNext();
                /*0x16244d0*/ void <>m__Finally1();
                /*0x1624520*/ SendBird.SBJson.JsonElement System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>.get_Current();
                /*0x1624528*/ void System.Collections.IEnumerator.Reset();
                /*0x1624568*/ object System.Collections.IEnumerator.get_Current();
                /*0x1624570*/ System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement> System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>.GetEnumerator();
                /*0x1624610*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetEnumerator>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ SendBird.SBJson.JsonArray <>4__this;
                /*0x28*/ System.Collections.Generic.List.Enumerator<SendBird.SBJson.JsonElement> <>7__wrap1;

                /*0x16240dc*/ <GetEnumerator>d__16(int <>1__state);
                /*0x1624614*/ void System.IDisposable.Dispose();
                /*0x1624630*/ bool MoveNext();
                /*0x16247c4*/ void <>m__Finally1();
                /*0x1624814*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x162481c*/ void System.Collections.IEnumerator.Reset();
                /*0x162485c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class JsonObject : SendBird.SBJson.JsonElement, System.Collections.IEnumerable
        {
            /*0x18*/ System.Collections.Generic.Dictionary<string, SendBird.SBJson.JsonElement> m_Dict;

            /*0x161b6ac*/ JsonObject();
            /*0x1624864*/ SendBird.SBJson.JsonElement get_Item(string aKey);
            /*0x16248f8*/ void set_Item(string aKey, SendBird.SBJson.JsonElement value);
            /*0x16249c4*/ SendBird.SBJson.JsonElement get_Item(int aIndex);
            /*0x1624a14*/ void set_Item(int aIndex, SendBird.SBJson.JsonElement value);
            /*0x1624a64*/ System.Collections.Generic.Dictionary.KeyCollection<string, SendBird.SBJson.JsonElement> get_Keys();
            /*0x161adc8*/ bool has(string key);
            /*0x161ab50*/ SendBird.SBJson.JsonElement get(string key);
            /*0x161b88c*/ void add(string key, SendBird.SBJson.JsonElement value);
            /*0x161c38c*/ void addProperty(string key, int value);
            /*0x161b728*/ void addProperty(string key, long value);
            /*0x1624aec*/ void addProperty(string key, float value);
            /*0x1624b8c*/ void addProperty(string key, double value);
            /*0x1624c2c*/ void addProperty(string key, bool value);
            /*0x161aed8*/ void addProperty(string key, string value);
            /*0x1624cc4*/ int get_Count();
            /*0x1624d14*/ void Add(string aKey, SendBird.SBJson.JsonElement aItem);
            /*0x1624e28*/ SendBird.SBJson.JsonElement Remove(string aKey);
            /*0x1624eec*/ SendBird.SBJson.JsonElement Remove(int aIndex);
            /*0x1624f3c*/ SendBird.SBJson.JsonElement Remove(SendBird.SBJson.JsonElement aNode);
            /*0x162518c*/ System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement> get_Children();
            /*0x1625234*/ System.Collections.IEnumerator GetEnumerator();
            /*0x16252c4*/ string ToJSON();

            class <get_Children>d__25 : System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ SendBird.SBJson.JsonElement <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ SendBird.SBJson.JsonObject <>4__this;
                /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, SendBird.SBJson.JsonElement> <>7__wrap1;

                /*0x16251f0*/ <get_Children>d__25(int <>1__state);
                /*0x1625568*/ void System.IDisposable.Dispose();
                /*0x1625584*/ bool MoveNext();
                /*0x162572c*/ void <>m__Finally1();
                /*0x162577c*/ SendBird.SBJson.JsonElement System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement>.get_Current();
                /*0x1625784*/ void System.Collections.IEnumerator.Reset();
                /*0x16257c4*/ object System.Collections.IEnumerator.get_Current();
                /*0x16257cc*/ System.Collections.Generic.IEnumerator<SendBird.SBJson.JsonElement> System.Collections.Generic.IEnumerable<SendBird.SBJson.JsonElement>.GetEnumerator();
                /*0x162586c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetEnumerator>d__26 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ SendBird.SBJson.JsonObject <>4__this;
                /*0x28*/ System.Collections.Generic.Dictionary.Enumerator<string, SendBird.SBJson.JsonElement> <>7__wrap1;

                /*0x162529c*/ <GetEnumerator>d__26(int <>1__state);
                /*0x1625870*/ void System.IDisposable.Dispose();
                /*0x162588c*/ bool MoveNext();
                /*0x1625a60*/ void <>m__Finally1();
                /*0x1625ab0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x1625ab8*/ void System.Collections.IEnumerator.Reset();
                /*0x1625af8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class JsonPrimitive : SendBird.SBJson.JsonElement
        {
            /*0x18*/ string m_Data;

            /*0x161b83c*/ JsonPrimitive(string aData);
            /*0x16224ac*/ JsonPrimitive(float aData);
            /*0x1622564*/ JsonPrimitive(double aData);
            /*0x16223f4*/ JsonPrimitive(bool aData);
            /*0x1622344*/ JsonPrimitive(int aData);
            /*0x1624ab4*/ JsonPrimitive(long aData);
            /*0x1625b00*/ string get_Value();
            /*0x1625b08*/ void set_Value(string value);
            /*0x1625b20*/ string ToString();
            /*0x1625b78*/ string ToJSON();
        }

        class JsonParser
        {
            static /*0x161b19c*/ SendBird.SBJson.JsonElement Parse(string aJSON);
        }
    }
}
