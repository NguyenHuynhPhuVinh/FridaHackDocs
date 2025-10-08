class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace CustomerSupport
            {
                class CustomerSupport : EA.Unity.StarlightWrapper.Wrapper<EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupportInitData, EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupport, Csdk.GluCustomerSupport.ICustomerSupport, EA.Unity.StarlightWrapper.CustomerSupport.Data.CustomerSupportConfigData>, EA.Unity.StarlightWrapper.CustomerSupport.ICustomerSupport, EA.Unity.StarlightWrapper.IWrapper<Csdk.GluCustomerSupport.ICustomerSupport>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x48*/ System.Collections.Generic.Dictionary<string, object> emptyOptions;
                    /*0x50*/ Csdk.GluCustomerSupport.QueryNotificationCountEvent disabledQueryNotificationEvent;
                    /*0x58*/ System.Func<EA.Unity.StarlightWrapper.CustomerSupport.Data.HelpshiftMetadata> getHelpShiftMetadata;
                    /*0x60*/ bool <LoggedIn>k__BackingField;
                    /*0x68*/ System.Action<System.Action> PreShowHelpshiftCallback;

                    /*0x2bfa7c0*/ CustomerSupport();
                    /*0x2bf918c*/ bool get_LoggedIn();
                    /*0x2bf9194*/ void set_LoggedIn(bool value);
                    /*0x2bf919c*/ Csdk.Revenue.RevSDKComponent get_StarlightComponentType();
                    /*0x2bf91a4*/ void add_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
                    /*0x2bf92a8*/ void remove_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
                    /*0x2bf93b0*/ void add_SessionStartedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> value);
                    /*0x2bf94b8*/ void remove_SessionStartedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> value);
                    /*0x2bf95c0*/ void add_SessionEndedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> value);
                    /*0x2bf96c8*/ void remove_SessionEndedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> value);
                    /*0x2bf97d0*/ void add_PreShowHelpshiftCallback(System.Action<System.Action> value);
                    /*0x2bf9880*/ void remove_PreShowHelpshiftCallback(System.Action<System.Action> value);
                    /*0x2bf9930*/ void Login(string userId);
                    /*0x2bf9a14*/ void Login(Csdk.GluCustomerSupport.UserInfo info);
                    /*0x2bf9c10*/ void Logout();
                    /*0x2bf9d60*/ void QueryNotificationCount();
                    /*0x2bf9e5c*/ void ShowFaqs(System.Collections.Generic.Dictionary<string, object> options);
                    /*0x2bfa1e0*/ void ShowConversation(System.Collections.Generic.Dictionary<string, object> options);
                    /*0x2bfa3cc*/ void Close();
                    /*0x2bfa4c8*/ void InitializeInternal(Csdk.GluCustomerSupport.ICustomerSupport customerSupport, System.Action onComplete);
                    /*0x2bfa640*/ void DoDispose(Csdk.GluCustomerSupport.ICustomerSupport customerSupport);
                    /*0x2bfa664*/ void UpdateRuntimeConfigInternal(System.Collections.Generic.Dictionary<string, object> runtimeConfig);
                    /*0x2bf9c04*/ void LoginComplete();
                    /*0x2bf9d08*/ void EnsureLoggedIn();
                    /*0x2bfa048*/ void EnsureOptionsDictionaryNotNull(ref System.Collections.Generic.Dictionary<string, object> options);
                    /*0x2bfa068*/ void SetMetadata();

                    class <>c__DisplayClass27_0
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupport <>4__this;
                        /*0x18*/ System.Collections.Generic.Dictionary<string, object> options;

                        /*0x2bfa040*/ <>c__DisplayClass27_0();
                        /*0x2bfa8ec*/ void <ShowFaqs>b__0();
                    }

                    class <>c__DisplayClass30_0
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupport <>4__this;
                        /*0x18*/ System.Collections.Generic.Dictionary<string, object> options;

                        /*0x2bfa3c4*/ <>c__DisplayClass30_0();
                        /*0x2bfa9bc*/ void <ShowConversation>b__0();
                    }
                }

                class CustomerSupportInitData : EA.Unity.StarlightWrapper.WrapperInitData<EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupport, Csdk.GluCustomerSupport.ICustomerSupport>
                {
                    /*0x28*/ System.Func<EA.Unity.StarlightWrapper.CustomerSupport.Data.HelpshiftMetadata> getHelpshiftMetadata;
                    /*0x30*/ Csdk.GluCustomerSupport.UserInfo <LoginUserInfo>k__BackingField;
                    /*0x38*/ string <LoginUserId>k__BackingField;
                    /*0x40*/ System.Action<System.Action> <PreShowHelpshiftCallback>k__BackingField;
                    /*0x48*/ System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> <QueryNotificationCountEventReceived>k__BackingField;
                    /*0x50*/ System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> <SessionStartedEventReceived>k__BackingField;
                    /*0x58*/ System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> <SessionEndedEventReceived>k__BackingField;
                    /*0x60*/ string <LanguageCodeOverride>k__BackingField;

                    /*0x2bfaa8c*/ CustomerSupportInitData(System.Func<EA.Unity.StarlightWrapper.CustomerSupport.Data.HelpshiftMetadata> getHelpshiftMetadata);
                    /*0x2bfab84*/ Csdk.GluCustomerSupport.UserInfo get_LoginUserInfo();
                    /*0x2bfab8c*/ string get_LoginUserId();
                    /*0x2bfab94*/ System.Action<System.Action> get_PreShowHelpshiftCallback();
                    /*0x2bfab9c*/ void set_PreShowHelpshiftCallback(System.Action<System.Action> value);
                    /*0x2bfaba4*/ System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> get_QueryNotificationCountEventReceived();
                    /*0x2bfabac*/ System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> get_SessionStartedEventReceived();
                    /*0x2bfabb4*/ System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> get_SessionEndedEventReceived();
                    /*0x2bfabbc*/ System.Func<EA.Unity.StarlightWrapper.CustomerSupport.Data.HelpshiftMetadata> get_GetHelpshiftMetadata();
                    /*0x2bfaaec*/ void set_GetHelpshiftMetadata(System.Func<EA.Unity.StarlightWrapper.CustomerSupport.Data.HelpshiftMetadata> value);
                    /*0x2bfabc4*/ string get_LanguageCodeOverride();
                }

                interface ICustomerSupport : EA.Unity.StarlightWrapper.IWrapper<Csdk.GluCustomerSupport.ICustomerSupport>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x1f30ebc*/ void add_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
                    /*0x1f30ebc*/ void remove_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
                    /*0x1f30ebc*/ void Login(string userId);
                    /*0x1f309e4*/ void QueryNotificationCount();
                    /*0x1f30ebc*/ void ShowFaqs(System.Collections.Generic.Dictionary<string, object> options);
                    /*0x1f30ebc*/ void ShowConversation(System.Collections.Generic.Dictionary<string, object> options);
                }
            }
        }
    }
}
