class <Module>
{
}

namespace Unity
{
    namespace Notifications
    {
        namespace Android
        {
            enum NotificationStyle
            {
                None = 0,
                BigPictureStyle = 1,
                BigTextStyle = 2,
            }

            enum GroupAlertBehaviours
            {
                GroupAlertAll = 0,
                GroupAlertSummary = 1,
                GroupAlertChildren = 2,
            }

            struct BigPictureStyle
            {
                /*0x10*/ string <LargeIcon>k__BackingField;
                /*0x18*/ string <Picture>k__BackingField;
                /*0x20*/ string <ContentTitle>k__BackingField;
                /*0x28*/ string <ContentDescription>k__BackingField;
                /*0x30*/ string <SummaryText>k__BackingField;
                /*0x38*/ bool <ShowWhenCollapsed>k__BackingField;

                /*0x7afa134*/ void set_LargeIcon(string value);
                /*0x7afa13c*/ void set_Picture(string value);
                /*0x7afa144*/ void set_ContentTitle(string value);
                /*0x7afa14c*/ void set_ContentDescription(string value);
                /*0x7afa154*/ void set_SummaryText(string value);
                /*0x7afa15c*/ void set_ShowWhenCollapsed(bool value);
            }

            struct AndroidNotification
            {
                /*0x10*/ string <Title>k__BackingField;
                /*0x18*/ string <Text>k__BackingField;
                /*0x20*/ string <SmallIcon>k__BackingField;
                /*0x28*/ System.DateTime <FireTime>k__BackingField;
                /*0x30*/ string <LargeIcon>k__BackingField;
                /*0x38*/ Unity.Notifications.Android.NotificationStyle <Style>k__BackingField;
                /*0x3c*/ int <Number>k__BackingField;
                /*0x40*/ bool <ShouldAutoCancel>k__BackingField;
                /*0x41*/ bool <UsesStopwatch>k__BackingField;
                /*0x48*/ string <Group>k__BackingField;
                /*0x50*/ bool <GroupSummary>k__BackingField;
                /*0x54*/ Unity.Notifications.Android.GroupAlertBehaviours <GroupAlertBehaviour>k__BackingField;
                /*0x58*/ string <SortKey>k__BackingField;
                /*0x60*/ string <IntentData>k__BackingField;
                /*0x68*/ bool <ShowTimestamp>k__BackingField;
                /*0x69*/ bool <ShowCustomTimestamp>k__BackingField;
                /*0x6c*/ UnityEngine.Color m_Color;
                /*0x80*/ System.TimeSpan m_RepeatInterval;
                /*0x88*/ System.DateTime m_CustomTimestamp;
                /*0x90*/ bool m_SilentInForeground;
                /*0x98*/ System.Nullable<Unity.Notifications.Android.BigPictureStyle> m_BigPictureStyle;

                /*0x7afa168*/ void set_Title(string value);
                /*0x7afa170*/ void set_Text(string value);
                /*0x7afa178*/ void set_SmallIcon(string value);
                /*0x7afa180*/ void set_FireTime(System.DateTime value);
                /*0x7afa188*/ void set_RepeatInterval(System.Nullable<System.TimeSpan> value);
                /*0x7afa260*/ void set_LargeIcon(string value);
                /*0x7afa268*/ Unity.Notifications.Android.NotificationStyle get_Style();
                /*0x7afa270*/ void set_Style(Unity.Notifications.Android.NotificationStyle value);
                /*0x7afa278*/ void set_Color(System.Nullable<UnityEngine.Color> value);
                /*0x7afa2f8*/ void set_Number(int value);
                /*0x7afa300*/ void set_ShouldAutoCancel(bool value);
                /*0x7afa30c*/ void set_UsesStopwatch(bool value);
                /*0x7afa318*/ void set_Group(string value);
                /*0x7afa320*/ void set_GroupSummary(bool value);
                /*0x7afa32c*/ void set_GroupAlertBehaviour(Unity.Notifications.Android.GroupAlertBehaviours value);
                /*0x7afa334*/ void set_SortKey(string value);
                /*0x7afa33c*/ void set_IntentData(string value);
                /*0x7afa344*/ void set_ShowTimestamp(bool value);
                /*0x7afa350*/ void set_CustomTimestamp(System.DateTime value);
                /*0x7afa360*/ void set_ShowInForeground(bool value);
                /*0x7afa370*/ void set_BigPicture(System.Nullable<Unity.Notifications.Android.BigPictureStyle> value);
                /*0x7afa3fc*/ void set_ShowCustomTimestamp(bool value);
            }

            class NotificationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x7afa408*/ NotificationCallback();
                /*0x7afa478*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] args);
                /*0x7afa524*/ void onSentNotification(UnityEngine.AndroidJavaObject notification);
            }

            struct NotificationManagerJni
            {
                /*0x10*/ UnityEngine.AndroidJavaClass klass;
                /*0x18*/ UnityEngine.AndroidJavaObject self;
                /*0x20*/ UnityEngine.AndroidJavaObject KEY_FIRE_TIME;
                /*0x28*/ UnityEngine.AndroidJavaObject KEY_ID;
                /*0x30*/ UnityEngine.AndroidJavaObject KEY_INTENT_DATA;
                /*0x38*/ UnityEngine.AndroidJavaObject KEY_LARGE_ICON;
                /*0x40*/ UnityEngine.AndroidJavaObject KEY_REPEAT_INTERVAL;
                /*0x48*/ UnityEngine.AndroidJavaObject KEY_NOTIFICATION;
                /*0x50*/ UnityEngine.AndroidJavaObject KEY_SMALL_ICON;
                /*0x58*/ UnityEngine.AndroidJavaObject KEY_SHOW_IN_FOREGROUND;
                /*0x60*/ UnityEngine.AndroidJavaObject KEY_BIG_PICTURE;
                /*0x68*/ string KEY_BIG_LARGE_ICON;
                /*0x70*/ string KEY_BIG_CONTENT_TITLE;
                /*0x78*/ string KEY_BIG_SUMMARY_TEXT;
                /*0x80*/ string KEY_BIG_CONTENT_DESCRIPTION;
                /*0x88*/ string KEY_BIG_SHOW_WHEN_COLLAPSED;
                /*0x90*/ nint getNotificationFromIntent;
                /*0x98*/ nint setNotificationIcon;
                /*0xa0*/ nint setNotificationColor;
                /*0xa8*/ nint getNotificationColor;
                /*0xb0*/ nint setNotificationUsesChronometer;
                /*0xb8*/ nint setNotificationGroupAlertBehavior;
                /*0xc0*/ nint getNotificationGroupAlertBehavior;
                /*0xc8*/ nint getNotificationChannelId;
                /*0xd0*/ nint scheduleNotification;
                /*0xd8*/ nint createNotificationBuilder;

                /*0x7afa6c8*/ NotificationManagerJni(UnityEngine.AndroidJavaClass clazz, UnityEngine.AndroidJavaObject obj);
                /*0x7afaa68*/ void CollectMethods(UnityEngine.AndroidJavaClass clazz);
                /*0x7afae68*/ System.Nullable<UnityEngine.Color> GetNotificationColor(UnityEngine.AndroidJavaObject notification);
                /*0x7afb17c*/ int GetNotificationGroupAlertBehavior(UnityEngine.AndroidJavaObject notification);
                /*0x7afb250*/ string GetNotificationChannelId(UnityEngine.AndroidJavaObject notification);
                /*0x7afb324*/ void RegisterNotificationChannel(Unity.Notifications.Android.AndroidNotificationChannel channel);
            }

            struct NotificationJni
            {
                /*0x10*/ UnityEngine.AndroidJavaObject EXTRA_TITLE;
                /*0x18*/ UnityEngine.AndroidJavaObject EXTRA_TEXT;
                /*0x20*/ UnityEngine.AndroidJavaObject EXTRA_SHOW_CHRONOMETER;
                /*0x28*/ UnityEngine.AndroidJavaObject EXTRA_BIG_TEXT;
                /*0x30*/ UnityEngine.AndroidJavaObject EXTRA_SHOW_WHEN;
                /*0x38*/ int FLAG_AUTO_CANCEL;
                /*0x3c*/ int FLAG_GROUP_SUMMARY;
                /*0x40*/ nint getGroup;
                /*0x48*/ nint getSortKey;
                /*0x50*/ nint extras;
                /*0x58*/ nint flags;
                /*0x60*/ nint number;
                /*0x68*/ nint when;

                /*0x7afb6b4*/ void CollectJni();
                /*0x7afb874*/ void CollectConstants(UnityEngine.AndroidJavaClass clazz);
                /*0x7afba48*/ void CollectMethods(UnityEngine.AndroidJavaClass clazz);
                /*0x7afbaf4*/ void CollectFields(UnityEngine.AndroidJavaClass clazz);
                /*0x7afbd74*/ UnityEngine.AndroidJavaObject Extras(UnityEngine.AndroidJavaObject notification);
                /*0x7afbdcc*/ int Flags(UnityEngine.AndroidJavaObject notification);
                /*0x7afbe24*/ int Number(UnityEngine.AndroidJavaObject notification);
                /*0x7afbe7c*/ string GetGroup(UnityEngine.AndroidJavaObject notification);
                /*0x7afbf44*/ string GetSortKey(UnityEngine.AndroidJavaObject notification);
                /*0x7afc00c*/ long When(UnityEngine.AndroidJavaObject notification);
            }

            struct NotificationBuilderJni
            {
                /*0x10*/ nint getExtras;
                /*0x18*/ nint setContentTitle;
                /*0x20*/ nint setContentText;
                /*0x28*/ nint setAutoCancel;
                /*0x30*/ nint setNumber;
                /*0x38*/ nint setStyle;
                /*0x40*/ nint setWhen;
                /*0x48*/ nint setGroup;
                /*0x50*/ nint setGroupSummary;
                /*0x58*/ nint setSortKey;
                /*0x60*/ nint setShowWhen;

                /*0x7afc064*/ void CollectJni();
            }

            struct BundleJni
            {
                /*0x10*/ nint containsKey;
                /*0x18*/ nint getBoolean;
                /*0x20*/ nint getInt;
                /*0x28*/ nint getLong;
                /*0x30*/ nint getString;
                /*0x38*/ nint putBoolean;
                /*0x40*/ nint putInt;
                /*0x48*/ nint putLong;
                /*0x50*/ nint putString;

                /*0x7afc498*/ void CollectJni();
                /*0x7afc894*/ bool ContainsKey(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key);
                /*0x7afc968*/ bool GetBoolean(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, bool defaultValue);
                /*0x7afcaa4*/ bool GetBoolean(UnityEngine.AndroidJavaObject bundle, string key, bool defaultValue);
                /*0x7afcbe0*/ int GetInt(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, int defaultValue);
                /*0x7afcd14*/ long GetLong(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, long defaultValue);
                /*0x7afce48*/ string GetString(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key);
                /*0x7afcf1c*/ string GetString(UnityEngine.AndroidJavaObject bundle, string key);
            }

            struct JniApi
            {
                /*0x10*/ Unity.Notifications.Android.NotificationManagerJni NotificationManager;
                /*0xe0*/ Unity.Notifications.Android.NotificationJni Notification;
                /*0x140*/ Unity.Notifications.Android.NotificationBuilderJni NotificationBuilder;
                /*0x198*/ Unity.Notifications.Android.BundleJni Bundle;

                static /*0x7afbc30*/ nint FindField(UnityEngine.AndroidJavaClass clazz, string name, string signature, bool isStatic);
                static /*0x7afad24*/ nint FindMethod(UnityEngine.AndroidJavaClass clazz, string name, string signature, bool isStatic);
                /*0x7afcff0*/ JniApi(UnityEngine.AndroidJavaClass notificationManagerClass, UnityEngine.AndroidJavaObject notificationManager);
            }

            class AndroidNotificationCenter
            {
                static /*0x0*/ int API_NOTIFICATIONS_CAN_BE_BLOCKED;
                static /*0x4*/ int API_POST_NOTIFICATIONS_PERMISSION_REQUIRED;
                static /*0x8*/ string PERMISSION_POST_NOTIFICATIONS;
                static /*0x10*/ string SETTING_POST_NOTIFICATIONS_PERMISSION;
                static /*0x18*/ Unity.Notifications.Android.AndroidNotificationCenter.NotificationReceivedCallback OnNotificationReceived;
                static /*0x20*/ UnityEngine.AndroidJavaObject s_CurrentActivity;
                static /*0x28*/ Unity.Notifications.Android.JniApi s_Jni;
                static /*0x1f8*/ int s_DeviceApiLevel;
                static /*0x1fc*/ int s_TargetApiLevel;
                static /*0x200*/ bool s_Initialized;

                static /*0x7afe3d0*/ AndroidNotificationCenter();
                static /*0x7afd0ac*/ bool Initialize();
                static /*0x7afd7f0*/ void RegisterNotificationChannel(Unity.Notifications.Android.AndroidNotificationChannel channel);
                static /*0x7afd96c*/ Unity.Notifications.Android.AndroidNotificationIntentData GetNotificationData(UnityEngine.AndroidJavaObject notificationObj);
                static /*0x7afe354*/ void ReceivedNotificationCallback(UnityEngine.AndroidJavaObject notification);

                class NotificationReceivedCallback : System.MulticastDelegate
                {
                    /*0x7afe500*/ NotificationReceivedCallback(object object, nint method);
                    /*0x7afe608*/ void Invoke(Unity.Notifications.Android.AndroidNotificationIntentData data);
                }

                class <>c
                {
                    static /*0x0*/ Unity.Notifications.Android.AndroidNotificationCenter.<> <>9;

                    static /*0x7afe61c*/ <>c();
                    /*0x7afe684*/ <>c();
                    /*0x7afe68c*/ void <.cctor>b__55_0(Unity.Notifications.Android.AndroidNotificationIntentData <p0>);
                }
            }

            enum Importance
            {
                None = 0,
                Low = 2,
                Default = 3,
                High = 4,
            }

            enum LockScreenVisibility
            {
                Secret = -1,
                Private = 0,
                Public = 1,
            }

            struct AndroidNotificationChannel
            {
                /*0x10*/ string <Id>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;
                /*0x20*/ string <Description>k__BackingField;
                /*0x28*/ string <Group>k__BackingField;
                /*0x30*/ Unity.Notifications.Android.Importance <Importance>k__BackingField;
                /*0x34*/ bool <CanBypassDnd>k__BackingField;
                /*0x35*/ bool <CanShowBadge>k__BackingField;
                /*0x36*/ bool <EnableLights>k__BackingField;
                /*0x37*/ bool <EnableVibration>k__BackingField;
                /*0x38*/ long[] <VibrationPattern>k__BackingField;
                /*0x40*/ Unity.Notifications.Android.LockScreenVisibility <LockScreenVisibility>k__BackingField;

                /*0x7afe690*/ string get_Id();
                /*0x7afe698*/ void set_Id(string value);
                /*0x7afe6a0*/ string get_Name();
                /*0x7afe6a8*/ void set_Name(string value);
                /*0x7afe6b0*/ string get_Description();
                /*0x7afe6b8*/ void set_Description(string value);
                /*0x7afe6c0*/ string get_Group();
                /*0x7afe6c8*/ Unity.Notifications.Android.Importance get_Importance();
                /*0x7afe6d0*/ void set_Importance(Unity.Notifications.Android.Importance value);
                /*0x7afe6d8*/ bool get_CanBypassDnd();
                /*0x7afe6e0*/ bool get_CanShowBadge();
                /*0x7afe6e8*/ void set_CanShowBadge(bool value);
                /*0x7afe6f4*/ bool get_EnableLights();
                /*0x7afe6fc*/ bool get_EnableVibration();
                /*0x7afe704*/ long[] get_VibrationPattern();
                /*0x7afe70c*/ Unity.Notifications.Android.LockScreenVisibility get_LockScreenVisibility();
            }

            class AndroidNotificationExtensions
            {
                static /*0x7afe23c*/ Unity.Notifications.Android.GroupAlertBehaviours ToGroupAlertBehaviours(int groupAlertBehaviour);
                static /*0x7afb134*/ UnityEngine.Color ToColor(int color);
                static /*0x7afe190*/ System.DateTime ToDatetime(long dateTime);
                static /*0x7afa208*/ System.TimeSpan ToTimeSpan(long timeSpan);
            }

            class AndroidNotificationIntentData
            {
                /*0x10*/ int <Id>k__BackingField;
                /*0x18*/ string <Channel>k__BackingField;
                /*0x20*/ Unity.Notifications.Android.AndroidNotification <Notification>k__BackingField;
                /*0xe0*/ UnityEngine.AndroidJavaObject <NativeNotification>k__BackingField;

                /*0x7afe2f0*/ AndroidNotificationIntentData(int id, string channelId, Unity.Notifications.Android.AndroidNotification notification);
                /*0x7afe714*/ void set_NativeNotification(UnityEngine.AndroidJavaObject value);
            }

            class AndroidReceivedNotificationMainThreadDispatcher : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ Unity.Notifications.Android.AndroidReceivedNotificationMainThreadDispatcher instance;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> m_ReceivedNotificationQueue;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> m_ReceivedNotificationList;

                static /*0x7afe71c*/ Unity.Notifications.Android.AndroidReceivedNotificationMainThreadDispatcher GetInstance();
                /*0x7afebf4*/ AndroidReceivedNotificationMainThreadDispatcher();
                /*0x7afa57c*/ void EnqueueReceivedNotification(UnityEngine.AndroidJavaObject notification);
                /*0x7afe764*/ void Update();
                /*0x7afeabc*/ void Awake();
                /*0x7afeba0*/ void OnDestroy();
            }
        }
    }
}
