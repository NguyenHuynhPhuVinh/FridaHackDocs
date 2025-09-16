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

        static /*0x81c626c*/ void RemoteSettingsUpdated(bool wasLastUpdatedFromServer);
        static /*0x81c62d0*/ void RemoteSettingsBeforeFetchFromServer();
        static /*0x81c6334*/ void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response);

        class UpdatedEventHandler : System.MulticastDelegate
        {
            /*0x81c63bc*/ UpdatedEventHandler(object object, nint method);
            /*0x81c6458*/ void Invoke();
        }
    }

    class RemoteConfigSettings
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<bool> Updated;

        static /*0x81c646c*/ void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, bool wasLastUpdatedFromServer);
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

            static /*0x81c64a0*/ void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            static /*0x81c653c*/ void CallIdentityTokenChanged(string token);

            class SessionStateChanged : System.MulticastDelegate
            {
                /*0x81c65a8*/ SessionStateChanged(object object, nint method);
                /*0x81c6648*/ void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            }

            class IdentityTokenChanged : System.MulticastDelegate
            {
                /*0x81c6660*/ IdentityTokenChanged(object object, nint method);
                /*0x81c6710*/ void Invoke(string token);
            }
        }

        class CustomEventData : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81c6758*/ nint Internal_Create(UnityEngine.Analytics.CustomEventData ced, string name);
            static /*0x81c69e0*/ void Internal_Destroy(nint ptr);
            static /*0x81c6ab0*/ nint Internal_Create_Injected(UnityEngine.Analytics.CustomEventData ced, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x81c6d64*/ bool AddString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81c6f68*/ bool AddInt32_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, int value);
            static /*0x81c716c*/ bool AddUInt32_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, uint value);
            static /*0x81c7370*/ bool AddInt64_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, long value);
            static /*0x81c7574*/ bool AddUInt64_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, ulong value);
            static /*0x81c7778*/ bool AddBool_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, bool value);
            static /*0x81c797c*/ bool AddDouble_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, double value);
            /*0x81c6724*/ CustomEventData(string name);
            /*0x81c68d0*/ void Finalize();
            /*0x81c6994*/ void Destroy();
            /*0x81c6a1c*/ void Dispose();
            /*0x81c6af4*/ bool AddString(string key, string value);
            /*0x81c6db8*/ bool AddInt32(string key, int value);
            /*0x81c6fbc*/ bool AddUInt32(string key, uint value);
            /*0x81c71c0*/ bool AddInt64(string key, long value);
            /*0x81c73c4*/ bool AddUInt64(string key, ulong value);
            /*0x81c75c8*/ bool AddBool(string key, bool value);
            /*0x81c77cc*/ bool AddDouble(string key, double value);
            /*0x81c79d0*/ bool AddDictionary(System.Collections.Generic.IDictionary<string, object> eventData);

            class BindingsMarshaller
            {
                static /*0x81c85fc*/ nint ConvertToNative(UnityEngine.Analytics.CustomEventData customEventData);
            }
        }

        class Analytics
        {
            static /*0x81c8614*/ bool IsInitialized();
            static /*0x81c863c*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x81c8aa8*/ UnityEngine.Analytics.AnalyticsResult SendCustomEventName(string customEventName);
            static /*0x81c8c54*/ UnityEngine.Analytics.AnalyticsResult SendCustomEvent(UnityEngine.Analytics.CustomEventData eventData);
            static /*0x81c8cd8*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            static /*0x81c8ce0*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x81c8e88*/ UnityEngine.Analytics.AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<string, object> eventData);
            static /*0x81c8a2c*/ UnityEngine.Analytics.AnalyticsResult Transaction_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper productId, double amount, ref UnityEngine.Bindings.ManagedSpanWrapper currency, ref UnityEngine.Bindings.ManagedSpanWrapper receiptPurchaseData, ref UnityEngine.Bindings.ManagedSpanWrapper signature, bool usingIAPService);
            static /*0x81c8c18*/ UnityEngine.Analytics.AnalyticsResult SendCustomEventName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper customEventName);
            static /*0x81c8c9c*/ UnityEngine.Analytics.AnalyticsResult SendCustomEvent_Injected(nint eventData);
        }
    }
}
