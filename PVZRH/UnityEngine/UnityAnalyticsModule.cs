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

        static /*0x1869700*/ void RemoteSettingsUpdated(bool wasLastUpdatedFromServer);
        static /*0x1869630*/ void RemoteSettingsBeforeFetchFromServer();
        static /*0x1869680*/ void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response);

        class UpdatedEventHandler : System.MulticastDelegate
        {
            /*0xe25c50*/ UpdatedEventHandler(object object, nint method);
            /*0x9dbe20*/ void Invoke();
        }
    }

    class RemoteConfigSettings
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<bool> Updated;

        static /*0x1869600*/ void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, bool wasLastUpdatedFromServer);
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

            static /*0x1869570*/ void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            static /*0x1869510*/ void CallIdentityTokenChanged(string token);

            class SessionStateChanged : System.MulticastDelegate
            {
                /*0x1869770*/ SessionStateChanged(object object, nint method);
                /*0x1869750*/ void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);
            }

            class IdentityTokenChanged : System.MulticastDelegate
            {
                /*0xf0a420*/ IdentityTokenChanged(object object, nint method);
                /*0x720980*/ void Invoke(string token);
            }
        }
    }
}
