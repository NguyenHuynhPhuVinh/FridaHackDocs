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

                /*0x7ae2d04*/ void set_LargeIcon(string value);
                /*0x7ae2d0c*/ void set_Picture(string value);
                /*0x7ae2d14*/ void set_ContentTitle(string value);
                /*0x7ae2d1c*/ void set_ContentDescription(string value);
                /*0x7ae2d24*/ void set_SummaryText(string value);
                /*0x7ae2d2c*/ void set_ShowWhenCollapsed(bool value);
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

                /*0x7ae2d38*/ void set_Title(string value);
                /*0x7ae2d40*/ void set_Text(string value);
                /*0x7ae2d48*/ void set_SmallIcon(string value);
                /*0x7ae2d50*/ void set_FireTime(System.DateTime value);
                /*0x7ae2d58*/ void set_RepeatInterval(System.Nullable<System.TimeSpan> value);
                /*0x7ae2e30*/ void set_LargeIcon(string value);
                /*0x7ae2e38*/ Unity.Notifications.Android.NotificationStyle get_Style();
                /*0x7ae2e40*/ void set_Style(Unity.Notifications.Android.NotificationStyle value);
                /*0x7ae2e48*/ void set_Color(System.Nullable<UnityEngine.Color> value);
                /*0x7ae2ec8*/ void set_Number(int value);
                /*0x7ae2ed0*/ void set_ShouldAutoCancel(bool value);
                /*0x7ae2edc*/ void set_UsesStopwatch(bool value);
                /*0x7ae2ee8*/ void set_Group(string value);
                /*0x7ae2ef0*/ void set_GroupSummary(bool value);
                /*0x7ae2efc*/ void set_GroupAlertBehaviour(Unity.Notifications.Android.GroupAlertBehaviours value);
                /*0x7ae2f04*/ void set_SortKey(string value);
                /*0x7ae2f0c*/ void set_IntentData(string value);
                /*0x7ae2f14*/ void set_ShowTimestamp(bool value);
                /*0x7ae2f20*/ void set_CustomTimestamp(System.DateTime value);
                /*0x7ae2f30*/ void set_ShowInForeground(bool value);
                /*0x7ae2f40*/ void set_BigPicture(System.Nullable<Unity.Notifications.Android.BigPictureStyle> value);
                /*0x7ae2fcc*/ void set_ShowCustomTimestamp(bool value);
            }

            class NotificationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x7ae2fd8*/ NotificationCallback();
                /*0x7ae3048*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] args);
                /*0x7ae30f4*/ void onSentNotification(UnityEngine.AndroidJavaObject notification);
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

                /*0x7ae3298*/ NotificationManagerJni(UnityEngine.AndroidJavaClass clazz, UnityEngine.AndroidJavaObject obj);
                /*0x7ae3638*/ void CollectMethods(UnityEngine.AndroidJavaClass clazz);
                /*0x7ae3a38*/ System.Nullable<UnityEngine.Color> GetNotificationColor(UnityEngine.AndroidJavaObject notification);
                /*0x7ae3d4c*/ int GetNotificationGroupAlertBehavior(UnityEngine.AndroidJavaObject notification);
                /*0x7ae3e20*/ string GetNotificationChannelId(UnityEngine.AndroidJavaObject notification);
                /*0x7ae3ef4*/ void RegisterNotificationChannel(Unity.Notifications.Android.AndroidNotificationChannel channel);
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

                /*0x7ae4284*/ void CollectJni();
                /*0x7ae4444*/ void CollectConstants(UnityEngine.AndroidJavaClass clazz);
                /*0x7ae4618*/ void CollectMethods(UnityEngine.AndroidJavaClass clazz);
                /*0x7ae46c4*/ void CollectFields(UnityEngine.AndroidJavaClass clazz);
                /*0x7ae4944*/ UnityEngine.AndroidJavaObject Extras(UnityEngine.AndroidJavaObject notification);
                /*0x7ae499c*/ int Flags(UnityEngine.AndroidJavaObject notification);
                /*0x7ae49f4*/ int Number(UnityEngine.AndroidJavaObject notification);
                /*0x7ae4a4c*/ string GetGroup(UnityEngine.AndroidJavaObject notification);
                /*0x7ae4b14*/ string GetSortKey(UnityEngine.AndroidJavaObject notification);
                /*0x7ae4bdc*/ long When(UnityEngine.AndroidJavaObject notification);
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

                /*0x7ae4c34*/ void CollectJni();
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

                /*0x7ae5068*/ void CollectJni();
                /*0x7ae5464*/ bool ContainsKey(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key);
                /*0x7ae5538*/ bool GetBoolean(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, bool defaultValue);
                /*0x7ae5674*/ bool GetBoolean(UnityEngine.AndroidJavaObject bundle, string key, bool defaultValue);
                /*0x7ae57b0*/ int GetInt(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, int defaultValue);
                /*0x7ae58e4*/ long GetLong(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, long defaultValue);
                /*0x7ae5a18*/ string GetString(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key);
                /*0x7ae5aec*/ string GetString(UnityEngine.AndroidJavaObject bundle, string key);
            }

            struct JniApi
            {
                /*0x10*/ Unity.Notifications.Android.NotificationManagerJni NotificationManager;
                /*0xe0*/ Unity.Notifications.Android.NotificationJni Notification;
                /*0x140*/ Unity.Notifications.Android.NotificationBuilderJni NotificationBuilder;
                /*0x198*/ Unity.Notifications.Android.BundleJni Bundle;

                static /*0x7ae4800*/ nint FindField(UnityEngine.AndroidJavaClass clazz, string name, string signature, bool isStatic);
                static /*0x7ae38f4*/ nint FindMethod(UnityEngine.AndroidJavaClass clazz, string name, string signature, bool isStatic);
                /*0x7ae5bc0*/ JniApi(UnityEngine.AndroidJavaClass notificationManagerClass, UnityEngine.AndroidJavaObject notificationManager);
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

                static /*0x7ae6fa0*/ AndroidNotificationCenter();
                static /*0x7ae5c7c*/ bool Initialize();
                static /*0x7ae63c0*/ void RegisterNotificationChannel(Unity.Notifications.Android.AndroidNotificationChannel channel);
                static /*0x7ae653c*/ Unity.Notifications.Android.AndroidNotificationIntentData GetNotificationData(UnityEngine.AndroidJavaObject notificationObj);
                static /*0x7ae6f24*/ void ReceivedNotificationCallback(UnityEngine.AndroidJavaObject notification);

                class NotificationReceivedCallback : System.MulticastDelegate
                {
                    /*0x7ae70d0*/ NotificationReceivedCallback(object object, nint method);
                    /*0x7ae71d8*/ void Invoke(Unity.Notifications.Android.AndroidNotificationIntentData data);
                }

                class <>c
                {
                    static /*0x0*/ Unity.Notifications.Android.AndroidNotificationCenter.<> <>9;

                    static /*0x7ae71ec*/ <>c();
                    /*0x7ae7254*/ <>c();
                    /*0x7ae725c*/ void <.cctor>b__55_0(Unity.Notifications.Android.AndroidNotificationIntentData <p0>);
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

                /*0x7ae7260*/ string get_Id();
                /*0x7ae7268*/ void set_Id(string value);
                /*0x7ae7270*/ string get_Name();
                /*0x7ae7278*/ void set_Name(string value);
                /*0x7ae7280*/ string get_Description();
                /*0x7ae7288*/ void set_Description(string value);
                /*0x7ae7290*/ string get_Group();
                /*0x7ae7298*/ Unity.Notifications.Android.Importance get_Importance();
                /*0x7ae72a0*/ void set_Importance(Unity.Notifications.Android.Importance value);
                /*0x7ae72a8*/ bool get_CanBypassDnd();
                /*0x7ae72b0*/ bool get_CanShowBadge();
                /*0x7ae72b8*/ void set_CanShowBadge(bool value);
                /*0x7ae72c4*/ bool get_EnableLights();
                /*0x7ae72cc*/ bool get_EnableVibration();
                /*0x7ae72d4*/ long[] get_VibrationPattern();
                /*0x7ae72dc*/ Unity.Notifications.Android.LockScreenVisibility get_LockScreenVisibility();
            }

            class AndroidNotificationExtensions
            {
                static /*0x7ae6e0c*/ Unity.Notifications.Android.GroupAlertBehaviours ToGroupAlertBehaviours(int groupAlertBehaviour);
                static /*0x7ae3d04*/ UnityEngine.Color ToColor(int color);
                static /*0x7ae6d60*/ System.DateTime ToDatetime(long dateTime);
                static /*0x7ae2dd8*/ System.TimeSpan ToTimeSpan(long timeSpan);
            }

            class AndroidNotificationIntentData
            {
                /*0x10*/ int <Id>k__BackingField;
                /*0x18*/ string <Channel>k__BackingField;
                /*0x20*/ Unity.Notifications.Android.AndroidNotification <Notification>k__BackingField;
                /*0xe0*/ UnityEngine.AndroidJavaObject <NativeNotification>k__BackingField;

                /*0x7ae6ec0*/ AndroidNotificationIntentData(int id, string channelId, Unity.Notifications.Android.AndroidNotification notification);
                /*0x7ae72e4*/ void set_NativeNotification(UnityEngine.AndroidJavaObject value);
            }

            class AndroidReceivedNotificationMainThreadDispatcher : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ Unity.Notifications.Android.AndroidReceivedNotificationMainThreadDispatcher instance;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> m_ReceivedNotificationQueue;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> m_ReceivedNotificationList;

                static /*0x7ae72ec*/ Unity.Notifications.Android.AndroidReceivedNotificationMainThreadDispatcher GetInstance();
                /*0x7ae77c4*/ AndroidReceivedNotificationMainThreadDispatcher();
                /*0x7ae314c*/ void EnqueueReceivedNotification(UnityEngine.AndroidJavaObject notification);
                /*0x7ae7334*/ void Update();
                /*0x7ae768c*/ void Awake();
                /*0x7ae7770*/ void OnDestroy();
            }
        }
    }
}
