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

        static /*0x2b21c8c*/ void RemoteSettingsUpdated(bool wasLastUpdatedFromServer);
        static /*0x2b21ef4*/ void RemoteSettingsBeforeFetchFromServer();
        static /*0x2b21f54*/ void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response);

        class UpdatedEventHandler : System.MulticastDelegate
        {
            /*0x2b221e4*/ UpdatedEventHandler(object object, nint method);
            /*0x2b21ce8*/ void Invoke();
            /*0x2b22244*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2b22270*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class RemoteConfigSettings
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<bool> Updated;

        static /*0x2b21c14*/ void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, bool wasLastUpdatedFromServer);
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
        class ContinuousEvent
        {
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

            static /*0x2b21100*/ void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            static /*0x2b21448*/ void CallIdentityTokenChanged(string token);

            class SessionStateChanged : System.MulticastDelegate
            {
                /*0x2b2207c*/ SessionStateChanged(object object, nint method);
                /*0x2b21194*/ void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
                /*0x2b220dc*/ System.IAsyncResult BeginInvoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged, System.AsyncCallback callback, object object);
                /*0x2b221d8*/ void EndInvoke(System.IAsyncResult result);
            }

            class IdentityTokenChanged : System.MulticastDelegate
            {
                /*0x2b21fec*/ IdentityTokenChanged(object object, nint method);
                /*0x2b214ac*/ void Invoke(string token);
                /*0x2b2204c*/ System.IAsyncResult BeginInvoke(string token, System.AsyncCallback callback, object object);
                /*0x2b22070*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class Analytics
        {
            static /*0x2b1faf0*/ bool IsInitialized();
            static /*0x2b1fb24*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x2b1fba4*/ UnityEngine.Analytics.AnalyticsResult SendCustomEventName(string customEventName);
            static /*0x2b1fbe4*/ UnityEngine.Analytics.AnalyticsResult SendCustomEvent(UnityEngine.Analytics.CustomEventData eventData);
            static /*0x2b1fc24*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            static /*0x2b1fc2c*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x2b1fe20*/ UnityEngine.Analytics.AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<string, object> eventData);
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

        class CustomEventData : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x2b21824*/ nint Internal_Create(UnityEngine.Analytics.CustomEventData ced, string name);
            static /*0x2b21964*/ void Internal_Destroy(nint ptr);
            /*0x2b1ffd8*/ CustomEventData(string name);
            /*0x2b21874*/ void Finalize();
            /*0x2b218dc*/ void Destroy();
            /*0x2b21094*/ void Dispose();
            /*0x2b219a4*/ bool AddString(string key, string value);
            /*0x2b219fc*/ bool AddInt32(string key, int value);
            /*0x2b21a54*/ bool AddUInt32(string key, uint value);
            /*0x2b21aac*/ bool AddInt64(string key, long value);
            /*0x2b21b04*/ bool AddUInt64(string key, ulong value);
            /*0x2b21b5c*/ bool AddBool(string key, bool value);
            /*0x2b21bb4*/ bool AddDouble(string key, double value);
            /*0x2b20038*/ bool AddDictionary(System.Collections.Generic.IDictionary<string, object> eventData);
        }
    }
}
