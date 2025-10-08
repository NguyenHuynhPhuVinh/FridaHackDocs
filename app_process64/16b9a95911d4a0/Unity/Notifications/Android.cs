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

                /*0x3acb214*/ string get_LargeIcon();
                /*0x3acb21c*/ void set_LargeIcon(string value);
                /*0x3acb224*/ string get_Picture();
                /*0x3acb22c*/ void set_Picture(string value);
                /*0x3acb234*/ string get_ContentTitle();
                /*0x3acb23c*/ void set_ContentTitle(string value);
                /*0x3acb244*/ string get_ContentDescription();
                /*0x3acb24c*/ void set_ContentDescription(string value);
                /*0x3acb254*/ string get_SummaryText();
                /*0x3acb25c*/ void set_SummaryText(string value);
                /*0x3acb264*/ bool get_ShowWhenCollapsed();
                /*0x3acb26c*/ void set_ShowWhenCollapsed(bool value);
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

                /*0x3acb274*/ string get_Title();
                /*0x3acb27c*/ void set_Title(string value);
                /*0x3acb284*/ string get_Text();
                /*0x3acb28c*/ void set_Text(string value);
                /*0x3acb294*/ string get_SmallIcon();
                /*0x3acb29c*/ void set_SmallIcon(string value);
                /*0x3acb2a4*/ System.DateTime get_FireTime();
                /*0x3acb2ac*/ void set_FireTime(System.DateTime value);
                /*0x3acb2b4*/ System.Nullable<System.TimeSpan> get_RepeatInterval();
                /*0x3acb31c*/ void set_RepeatInterval(System.Nullable<System.TimeSpan> value);
                /*0x3acb42c*/ string get_LargeIcon();
                /*0x3acb434*/ void set_LargeIcon(string value);
                /*0x3acb43c*/ Unity.Notifications.Android.NotificationStyle get_Style();
                /*0x3acb444*/ void set_Style(Unity.Notifications.Android.NotificationStyle value);
                /*0x3acb44c*/ System.Nullable<UnityEngine.Color> get_Color();
                /*0x3acb4c0*/ void set_Color(System.Nullable<UnityEngine.Color> value);
                /*0x3acb57c*/ int get_Number();
                /*0x3acb584*/ void set_Number(int value);
                /*0x3acb58c*/ bool get_ShouldAutoCancel();
                /*0x3acb594*/ void set_ShouldAutoCancel(bool value);
                /*0x3acb59c*/ bool get_UsesStopwatch();
                /*0x3acb5a4*/ void set_UsesStopwatch(bool value);
                /*0x3acb5ac*/ string get_Group();
                /*0x3acb5b4*/ void set_Group(string value);
                /*0x3acb5bc*/ bool get_GroupSummary();
                /*0x3acb5c4*/ void set_GroupSummary(bool value);
                /*0x3acb5cc*/ Unity.Notifications.Android.GroupAlertBehaviours get_GroupAlertBehaviour();
                /*0x3acb5d4*/ void set_GroupAlertBehaviour(Unity.Notifications.Android.GroupAlertBehaviours value);
                /*0x3acb5dc*/ string get_SortKey();
                /*0x3acb5e4*/ void set_SortKey(string value);
                /*0x3acb5ec*/ string get_IntentData();
                /*0x3acb5f4*/ void set_IntentData(string value);
                /*0x3acb5fc*/ bool get_ShowTimestamp();
                /*0x3acb604*/ void set_ShowTimestamp(bool value);
                /*0x3acb60c*/ System.DateTime get_CustomTimestamp();
                /*0x3acb614*/ void set_CustomTimestamp(System.DateTime value);
                /*0x3acb624*/ bool get_ShowInForeground();
                /*0x3acb634*/ void set_ShowInForeground(bool value);
                /*0x3acb640*/ System.Nullable<Unity.Notifications.Android.BigPictureStyle> get_BigPicture();
                /*0x3acb660*/ void set_BigPicture(System.Nullable<Unity.Notifications.Android.BigPictureStyle> value);
                /*0x3acb760*/ bool get_ShowCustomTimestamp();
                /*0x3acb768*/ void set_ShowCustomTimestamp(bool value);
            }

            class NotificationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x3acb770*/ NotificationCallback();
                /*0x3acb7e0*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] args);
                /*0x3acb88c*/ void onSentNotification(UnityEngine.AndroidJavaObject notification);
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

                /*0x3acb9e4*/ NotificationManagerJni(UnityEngine.AndroidJavaClass clazz, UnityEngine.AndroidJavaObject obj);
                /*0x3acbdc8*/ void CollectMethods(UnityEngine.AndroidJavaClass clazz);
                /*0x3acc1a8*/ UnityEngine.AndroidJavaObject GetNotificationFromIntent(UnityEngine.AndroidJavaObject intent);
                /*0x3acc288*/ void SetNotificationIcon(UnityEngine.AndroidJavaObject builder, UnityEngine.AndroidJavaObject keyName, string icon);
                /*0x3acc3c0*/ void SetNotificationColor(UnityEngine.AndroidJavaObject builder, int color);
                /*0x3acc4e0*/ System.Nullable<UnityEngine.Color> GetNotificationColor(UnityEngine.AndroidJavaObject notification);
                /*0x3acc7b4*/ void SetNotificationUsesChronometer(UnityEngine.AndroidJavaObject builder, bool usesStopwatch);
                /*0x3acc8d8*/ void SetNotificationGroupAlertBehavior(UnityEngine.AndroidJavaObject builder, int groupAlertBehaviour);
                /*0x3acc9f8*/ int GetNotificationGroupAlertBehavior(UnityEngine.AndroidJavaObject notification);
                /*0x3accad8*/ string GetNotificationChannelId(UnityEngine.AndroidJavaObject notification);
                /*0x3accbb8*/ void RegisterNotificationChannel(Unity.Notifications.Android.AndroidNotificationChannel channel);
                /*0x3accf48*/ UnityEngine.AndroidJavaObject[] GetNotificationChannels();
                /*0x3acd034*/ int ScheduleNotification(UnityEngine.AndroidJavaObject notificationBuilder, bool customized);
                /*0x3acd174*/ void CancelPendingNotification(int id);
                /*0x3acd264*/ void CancelDisplayedNotification(int id);
                /*0x3acd354*/ void CancelAllPendingNotificationIntents();
                /*0x3acd418*/ void CancelAllNotifications();
                /*0x3acd4dc*/ void ShowNotificationSettings(string channelId);
                /*0x3acd5ac*/ UnityEngine.AndroidJavaObject CreateNotificationBuilder(string channelId);
                /*0x3acd68c*/ void SetupBigPictureStyle(UnityEngine.AndroidJavaObject builder, Unity.Notifications.Android.BigPictureStyle bigPicture);
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

                /*0x3acd8d8*/ void CollectJni();
                /*0x3acda58*/ void CollectConstants(UnityEngine.AndroidJavaClass clazz);
                /*0x3acdc50*/ void CollectMethods(UnityEngine.AndroidJavaClass clazz);
                /*0x3acdcfc*/ void CollectFields(UnityEngine.AndroidJavaClass clazz);
                /*0x3acdf5c*/ UnityEngine.AndroidJavaObject Extras(UnityEngine.AndroidJavaObject notification);
                /*0x3acdfc8*/ int Flags(UnityEngine.AndroidJavaObject notification);
                /*0x3ace034*/ int Number(UnityEngine.AndroidJavaObject notification);
                /*0x3ace0a0*/ string GetGroup(UnityEngine.AndroidJavaObject notification);
                /*0x3ace17c*/ string GetSortKey(UnityEngine.AndroidJavaObject notification);
                /*0x3ace258*/ long When(UnityEngine.AndroidJavaObject notification);
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

                /*0x3ace2c4*/ void CollectJni();
                /*0x3ace6e0*/ UnityEngine.AndroidJavaObject GetExtras(UnityEngine.AndroidJavaObject builder);
                /*0x3ace7bc*/ void SetContentTitle(UnityEngine.AndroidJavaObject builder, string title);
                /*0x3ace8b0*/ void SetContentText(UnityEngine.AndroidJavaObject builder, string text);
                /*0x3ace9a4*/ void SetAutoCancel(UnityEngine.AndroidJavaObject builder, bool shouldAutoCancel);
                /*0x3aceab8*/ void SetNumber(UnityEngine.AndroidJavaObject builder, int number);
                /*0x3acebc8*/ void SetStyle(UnityEngine.AndroidJavaObject builder, UnityEngine.AndroidJavaObject style);
                /*0x3acecbc*/ void SetWhen(UnityEngine.AndroidJavaObject builder, long timestamp);
                /*0x3acedcc*/ void SetGroup(UnityEngine.AndroidJavaObject builder, string group);
                /*0x3aceec0*/ void SetGroupSummary(UnityEngine.AndroidJavaObject builder, bool groupSummary);
                /*0x3acefd4*/ void SetSortKey(UnityEngine.AndroidJavaObject builder, string sortKey);
                /*0x3acf0c8*/ void SetShowWhen(UnityEngine.AndroidJavaObject builder, bool showTimestamp);
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

                /*0x3acf1dc*/ void CollectJni();
                /*0x3acf5b8*/ bool ContainsKey(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key);
                /*0x3acf6a0*/ bool GetBoolean(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, bool defaultValue);
                /*0x3acf7e0*/ bool GetBoolean(UnityEngine.AndroidJavaObject bundle, string key, bool defaultValue);
                /*0x3acf920*/ int GetInt(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, int defaultValue);
                /*0x3acfa5c*/ long GetLong(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, long defaultValue);
                /*0x3acfb9c*/ string GetString(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key);
                /*0x3acfc84*/ string GetString(UnityEngine.AndroidJavaObject bundle, string key);
                /*0x3acfd6c*/ void PutBoolean(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, bool value);
                /*0x3acfe90*/ void PutInt(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, int value);
                /*0x3acffb0*/ void PutLong(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, long value);
                /*0x3ad00d0*/ void PutString(UnityEngine.AndroidJavaObject bundle, UnityEngine.AndroidJavaObject key, string value);
            }

            struct JniApi
            {
                /*0x10*/ Unity.Notifications.Android.NotificationManagerJni NotificationManager;
                /*0xe0*/ Unity.Notifications.Android.NotificationJni Notification;
                /*0x140*/ Unity.Notifications.Android.NotificationBuilderJni NotificationBuilder;
                /*0x198*/ Unity.Notifications.Android.BundleJni Bundle;

                static /*0x3acde38*/ nint FindField(UnityEngine.AndroidJavaClass clazz, string name, string signature, bool isStatic);
                static /*0x3acc084*/ nint FindMethod(UnityEngine.AndroidJavaClass clazz, string name, string signature, bool isStatic);
                /*0x3ad01d0*/ JniApi(UnityEngine.AndroidJavaClass notificationManagerClass, UnityEngine.AndroidJavaObject notificationManager);
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

                static /*0x3ad2e70*/ AndroidNotificationCenter();
                static /*0x3ad028c*/ bool Initialize();
                static /*0x3ad0938*/ void RegisterNotificationChannel(Unity.Notifications.Android.AndroidNotificationChannel channel);
                static /*0x3ad0ab4*/ Unity.Notifications.Android.AndroidNotificationChannel GetNotificationChannel(string channelId);
                static /*0x3ad0bfc*/ Unity.Notifications.Android.AndroidNotificationChannel[] GetNotificationChannels();
                static /*0x3ad1198*/ void SendNotificationWithExplicitID(Unity.Notifications.Android.AndroidNotification notification, string channelId, int id);
                static /*0x3ad1420*/ int ScheduleNotification(UnityEngine.AndroidJavaObject notificationBuilder, bool customized);
                static /*0x3ad1490*/ void CancelScheduledNotification(int id);
                static /*0x3ad1514*/ void CancelDisplayedNotification(int id);
                static /*0x3ad1598*/ void CancelAllScheduledNotifications();
                static /*0x3ad1614*/ void CancelAllDisplayedNotifications();
                static /*0x3ad1690*/ Unity.Notifications.Android.AndroidNotificationIntentData GetLastNotificationIntent();
                static /*0x3ad1fcc*/ void OpenNotificationSettings(string channelId);
                static /*0x3ad133c*/ UnityEngine.AndroidJavaObject CreateNotificationBuilder(int id, Unity.Notifications.Android.AndroidNotification notification, string channelId);
                static /*0x3ad2050*/ void CreateNotificationBuilder(Unity.Notifications.Android.AndroidNotification notification, string channelId, ref UnityEngine.AndroidJavaObject notificationBuilder, ref UnityEngine.AndroidJavaObject extras);
                static /*0x3ad17f4*/ Unity.Notifications.Android.AndroidNotificationIntentData GetNotificationData(UnityEngine.AndroidJavaObject notificationObj);
                static /*0x3ad2df4*/ void ReceivedNotificationCallback(UnityEngine.AndroidJavaObject notification);

                class NotificationReceivedCallback : System.MulticastDelegate
                {
                    /*0x3ad2fa0*/ NotificationReceivedCallback(object object, nint method);
                    /*0x3ad30a8*/ void Invoke(Unity.Notifications.Android.AndroidNotificationIntentData data);
                }

                class <>c
                {
                    static /*0x0*/ Unity.Notifications.Android.AndroidNotificationCenter.<> <>9;

                    static /*0x3ad30bc*/ <>c();
                    /*0x3ad3124*/ <>c();
                    /*0x3ad312c*/ void <.cctor>b__55_0(Unity.Notifications.Android.AndroidNotificationIntentData <p0>);
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ string channelId;

                    /*0x3ad0bf4*/ <>c__DisplayClass31_0();
                    /*0x3ad3130*/ bool <GetNotificationChannel>b__0(Unity.Notifications.Android.AndroidNotificationChannel channel);
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

                /*0x3ad3144*/ string get_Id();
                /*0x3ad314c*/ void set_Id(string value);
                /*0x3ad3154*/ string get_Name();
                /*0x3ad315c*/ void set_Name(string value);
                /*0x3ad3164*/ string get_Description();
                /*0x3ad316c*/ void set_Description(string value);
                /*0x3ad3174*/ string get_Group();
                /*0x3ad317c*/ void set_Group(string value);
                /*0x3ad3184*/ Unity.Notifications.Android.Importance get_Importance();
                /*0x3ad318c*/ void set_Importance(Unity.Notifications.Android.Importance value);
                /*0x3ad3194*/ bool get_CanBypassDnd();
                /*0x3ad319c*/ void set_CanBypassDnd(bool value);
                /*0x3ad31a4*/ bool get_CanShowBadge();
                /*0x3ad31ac*/ void set_CanShowBadge(bool value);
                /*0x3ad31b4*/ bool get_EnableLights();
                /*0x3ad31bc*/ void set_EnableLights(bool value);
                /*0x3ad31c4*/ bool get_EnableVibration();
                /*0x3ad31cc*/ void set_EnableVibration(bool value);
                /*0x3ad31d4*/ long[] get_VibrationPattern();
                /*0x3ad31dc*/ void set_VibrationPattern(long[] value);
                /*0x3ad31e4*/ Unity.Notifications.Android.LockScreenVisibility get_LockScreenVisibility();
                /*0x3ad31ec*/ void set_LockScreenVisibility(Unity.Notifications.Android.LockScreenVisibility value);
            }

            class AndroidNotificationExtensions
            {
                static /*0x3ad102c*/ Unity.Notifications.Android.Importance ToImportance(int importance);
                static /*0x3ad10e4*/ Unity.Notifications.Android.LockScreenVisibility ToLockScreenVisibility(int lockscreenVisibility);
                static /*0x3ad2ce0*/ Unity.Notifications.Android.GroupAlertBehaviours ToGroupAlertBehaviours(int groupAlertBehaviour);
                static /*0x3acc778*/ UnityEngine.Color ToColor(int color);
                static /*0x3ad2a78*/ int ToInt(System.Nullable<UnityEngine.Color> color);
                static /*0x3ad2950*/ long ToLong(System.DateTime dateTime);
                static /*0x3ad2c34*/ System.DateTime ToDatetime(long dateTime);
                static /*0x3ad2b40*/ long ToLong(System.Nullable<System.TimeSpan> timeSpan);
                static /*0x3acb3d4*/ System.TimeSpan ToTimeSpan(long timeSpan);
            }

            class AndroidNotificationIntentData
            {
                /*0x10*/ int <Id>k__BackingField;
                /*0x18*/ string <Channel>k__BackingField;
                /*0x20*/ Unity.Notifications.Android.AndroidNotification <Notification>k__BackingField;
                /*0xe0*/ UnityEngine.AndroidJavaObject <NativeNotification>k__BackingField;

                /*0x3ad2d94*/ AndroidNotificationIntentData(int id, string channelId, Unity.Notifications.Android.AndroidNotification notification);
                /*0x3ad31f4*/ int get_Id();
                /*0x3ad31fc*/ Unity.Notifications.Android.AndroidNotification get_Notification();
                /*0x3ad320c*/ void set_NativeNotification(UnityEngine.AndroidJavaObject value);
            }

            class AndroidReceivedNotificationMainThreadDispatcher : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ Unity.Notifications.Android.AndroidReceivedNotificationMainThreadDispatcher instance;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> m_ReceivedNotificationQueue;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> m_ReceivedNotificationList;

                static /*0x3ad3214*/ Unity.Notifications.Android.AndroidReceivedNotificationMainThreadDispatcher GetInstance();
                /*0x3ad37a8*/ AndroidReceivedNotificationMainThreadDispatcher();
                /*0x3acb8e4*/ void EnqueueReceivedNotification(UnityEngine.AndroidJavaObject notification);
                /*0x3ad325c*/ void Update();
                /*0x3ad3670*/ void Awake();
                /*0x3ad3754*/ void OnDestroy();
            }
        }
    }
}
