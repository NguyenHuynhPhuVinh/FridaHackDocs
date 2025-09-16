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

        static /*0x81dd69c*/ void RemoteSettingsUpdated(bool wasLastUpdatedFromServer);
        static /*0x81dd700*/ void RemoteSettingsBeforeFetchFromServer();
        static /*0x81dd764*/ void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response);

        class UpdatedEventHandler : System.MulticastDelegate
        {
            /*0x81dd7ec*/ UpdatedEventHandler(object object, nint method);
            /*0x81dd888*/ void Invoke();
        }
    }

    class RemoteConfigSettings
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<bool> Updated;

        static /*0x81dd89c*/ void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, bool wasLastUpdatedFromServer);
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

            static /*0x81dd8d0*/ void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            static /*0x81dd96c*/ void CallIdentityTokenChanged(string token);

            class SessionStateChanged : System.MulticastDelegate
            {
                /*0x81dd9d8*/ SessionStateChanged(object object, nint method);
                /*0x81dda78*/ void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            }

            class IdentityTokenChanged : System.MulticastDelegate
            {
                /*0x81dda90*/ IdentityTokenChanged(object object, nint method);
                /*0x81ddb40*/ void Invoke(string token);
            }
        }

        class CustomEventData : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81ddb88*/ nint Internal_Create(UnityEngine.Analytics.CustomEventData ced, string name);
            static /*0x81dde10*/ void Internal_Destroy(nint ptr);
            static /*0x81ddee0*/ nint Internal_Create_Injected(UnityEngine.Analytics.CustomEventData ced, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x81de194*/ bool AddString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81de398*/ bool AddInt32_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, int value);
            static /*0x81de59c*/ bool AddUInt32_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, uint value);
            static /*0x81de7a0*/ bool AddInt64_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, long value);
            static /*0x81de9a4*/ bool AddUInt64_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, ulong value);
            static /*0x81deba8*/ bool AddBool_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, bool value);
            static /*0x81dedac*/ bool AddDouble_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper key, double value);
            /*0x81ddb54*/ CustomEventData(string name);
            /*0x81ddd00*/ void Finalize();
            /*0x81dddc4*/ void Destroy();
            /*0x81dde4c*/ void Dispose();
            /*0x81ddf24*/ bool AddString(string key, string value);
            /*0x81de1e8*/ bool AddInt32(string key, int value);
            /*0x81de3ec*/ bool AddUInt32(string key, uint value);
            /*0x81de5f0*/ bool AddInt64(string key, long value);
            /*0x81de7f4*/ bool AddUInt64(string key, ulong value);
            /*0x81de9f8*/ bool AddBool(string key, bool value);
            /*0x81debfc*/ bool AddDouble(string key, double value);
            /*0x81dee00*/ bool AddDictionary(System.Collections.Generic.IDictionary<string, object> eventData);

            class BindingsMarshaller
            {
                static /*0x81dfa2c*/ nint ConvertToNative(UnityEngine.Analytics.CustomEventData customEventData);
            }
        }

        class Analytics
        {
            static /*0x81dfa44*/ bool IsInitialized();
            static /*0x81dfa6c*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x81dfed8*/ UnityEngine.Analytics.AnalyticsResult SendCustomEventName(string customEventName);
            static /*0x81e0084*/ UnityEngine.Analytics.AnalyticsResult SendCustomEvent(UnityEngine.Analytics.CustomEventData eventData);
            static /*0x81e0108*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            static /*0x81e0110*/ UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);
            static /*0x81e02b8*/ UnityEngine.Analytics.AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<string, object> eventData);
            static /*0x81dfe5c*/ UnityEngine.Analytics.AnalyticsResult Transaction_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper productId, double amount, ref UnityEngine.Bindings.ManagedSpanWrapper currency, ref UnityEngine.Bindings.ManagedSpanWrapper receiptPurchaseData, ref UnityEngine.Bindings.ManagedSpanWrapper signature, bool usingIAPService);
            static /*0x81e0048*/ UnityEngine.Analytics.AnalyticsResult SendCustomEventName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper customEventName);
            static /*0x81e00cc*/ UnityEngine.Analytics.AnalyticsResult SendCustomEvent_Injected(nint eventData);
        }
    }
}
