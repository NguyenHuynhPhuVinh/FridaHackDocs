class <Module>
{
}

namespace UnityEngine
{
    class RemoteSettings
    {
        static /*0x0*/ UnityEngine.RemoteSettings.UpdatedEventHandler Updated;
        static /*0x8*/ System.Action BeforeFetchFromServer;
        static /*0x10*/ System.Action<bool, bool, int> Completed;

        static /*0x9187ac*/ void RemoteSettingsUpdated(bool wasLastUpdatedFromServer);
        static /*0x918810*/ void RemoteSettingsBeforeFetchFromServer();
        static /*0x918874*/ void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response);

        class UpdatedEventHandler : System.MulticastDelegate
        {
            /*0x9188fc*/ UpdatedEventHandler(object object, nint method);
            /*0x9189b8*/ void Invoke();
        }
    }

    class RemoteConfigSettings
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<bool> Updated;

        static /*0x9189cc*/ void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, bool wasLastUpdatedFromServer);
    }

    class RemoteConfigSettingsHelper
    {
        enum Tag
        {
            kUnknown = 0,
            kIntVal = 1,
            kInt64Val = 2,
            kUInt64Val = 3,
            kDoubleVal = 4,
            kBoolVal = 5,
            kStringVal = 6,
            kArrayVal = 7,
            kMixedArrayVal = 8,
            kMapVal = 9,
            kMaxTags = 10,
        }
    }

    namespace Analytics
    {
        class Analytics
        {
            static /*0x918a00*/ bool IsInitialized();
            static /*0x918a28*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x918aa4*/ UnityEngine.Analytics.AnalyticsResult SendCustomEventName(string customEventName);
            static /*0x918ae0*/ UnityEngine.Analytics.AnalyticsResult SendCustomEvent(UnityEngine.Analytics.CustomEventData eventData);
            static /*0x918b1c*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            static /*0x918b24*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x918d04*/ UnityEngine.Analytics.AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<string, object> eventData);
        }

        enum AnalyticsResult
        {
            Ok = 0,
            NotInitialized = 1,
            AnalyticsDisabled = 2,
            TooManyItems = 3,
            SizeLimitReached = 4,
            TooManyRequests = 5,
            InvalidData = 6,
            UnsupportedPlatform = 7,
        }

        enum AnalyticsSessionState
        {
            kSessionStopped = 0,
            kSessionStarted = 1,
            kSessionPaused = 2,
            kSessionResumed = 3,
        }

        class AnalyticsSessionInfo
        {
            static /*0x0*/ UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged sessionStateChanged;
            static /*0x8*/ UnityEngine.Analytics.AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged;

            static /*0x919f20*/ void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            static /*0x919fbc*/ void CallIdentityTokenChanged(string token);

            class SessionStateChanged : System.MulticastDelegate
            {
                /*0x91a028*/ SessionStateChanged(object object, nint method);
                /*0x91a0ec*/ void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            }

            class IdentityTokenChanged : System.MulticastDelegate
            {
                /*0x91a104*/ IdentityTokenChanged(object object, nint method);
                /*0x91a1d8*/ void Invoke(string token);
            }
        }

        class ContinuousEvent
        {
        }

        class CustomEventData : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x91a1ec*/ nint Internal_Create(UnityEngine.Analytics.CustomEventData ced, string name);
            static /*0x91a364*/ void Internal_Destroy(nint ptr);
            /*0x918ed0*/ CustomEventData(string name);
            /*0x91a230*/ void Finalize();
            /*0x91a2c4*/ void Destroy();
            /*0x91a3a0*/ void Dispose();
            /*0x91a400*/ bool AddString(string key, string value);
            /*0x91a454*/ bool AddInt32(string key, int value);
            /*0x91a4a8*/ bool AddUInt32(string key, uint value);
            /*0x91a4fc*/ bool AddInt64(string key, long value);
            /*0x91a550*/ bool AddUInt64(string key, ulong value);
            /*0x91a5a4*/ bool AddBool(string key, bool value);
            /*0x91a5f8*/ bool AddDouble(string key, double value);
            /*0x918f24*/ bool AddDictionary(System.Collections.Generic.IDictionary<string, object> eventData);
        }
    }
}
