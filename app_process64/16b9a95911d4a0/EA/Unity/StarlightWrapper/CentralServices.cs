class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace CentralServices
            {
                class AccountOperationRequester
                {
                    /*0x10*/ EA.Unity.StarlightWrapper.CentralServices.IAccountOperationHandler handler;

                    /*0x2bf5c98*/ AccountOperationRequester(EA.Unity.StarlightWrapper.CentralServices.IAccountOperationHandler handler);
                }

                class DefaultAccountOperationHandler : EA.Unity.StarlightWrapper.CentralServices.IAccountOperationHandler
                {
                    /*0x2bf5cc8*/ DefaultAccountOperationHandler();
                }

                class DeviceAccountOperationRequester : EA.Unity.StarlightWrapper.CentralServices.AccountOperationRequester
                {
                    /*0x18*/ Csdk.GluCentralServices.IGluCentralServices centralServices;

                    /*0x2bf5cd0*/ DeviceAccountOperationRequester(EA.Unity.StarlightWrapper.CentralServices.IAccountOperationHandler handler, Csdk.GluCentralServices.IGluCentralServices centralServices);
                }

                interface IAccountOperationHandler
                {
                }

                class CentralServices : EA.Unity.StarlightWrapper.Wrapper<EA.Unity.StarlightWrapper.CentralServices.CentralServicesInitData, EA.Unity.StarlightWrapper.CentralServices.CentralServices, Csdk.GluCentralServices.IGluCentralServices, EA.Unity.StarlightWrapper.ConfigData>, EA.Unity.StarlightWrapper.CentralServices.ICentralServices, EA.Unity.StarlightWrapper.IWrapper<Csdk.GluCentralServices.IGluCentralServices>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x48*/ EA.Unity.StarlightWrapper.CentralServices.AccountOperationRequester accountOperationRequester;
                    /*0x50*/ EA.Unity.StarlightWrapper.CentralServices.JsonResourceGetter resourceGetter;
                    /*0x58*/ EA.Unity.StarlightWrapper.CentralServices.IAccountOperationHandler accountOperationHandler;
                    /*0x60*/ bool isShowingConsentPopup;
                    /*0x68*/ System.Action OnConsentFlowDone;
                    /*0x70*/ System.Action OnAgeGateFailed;
                    /*0x78*/ Csdk.GluCentralServices.ConsentUpdateResult <ConsentUpdateResult>k__BackingField;

                    /*0x2bf6f1c*/ CentralServices();
                    /*0x2bf5d14*/ void add_OnConsentFlowDone(System.Action value);
                    /*0x2bf5db0*/ void remove_OnConsentFlowDone(System.Action value);
                    /*0x2bf5e4c*/ void add_OnAgeGateFailed(System.Action value);
                    /*0x2bf5ee8*/ void remove_OnAgeGateFailed(System.Action value);
                    /*0x2bf5f84*/ Csdk.Revenue.RevSDKComponent get_StarlightComponentType();
                    /*0x2bf5f8c*/ Csdk.GluCentralServices.ConsentUpdateResult get_ConsentUpdateResult();
                    /*0x2bf5f94*/ void set_ConsentUpdateResult(Csdk.GluCentralServices.ConsentUpdateResult value);
                    /*0x2bf5f9c*/ bool get_HasCompletedConsentFlow();
                    /*0x2bf5fac*/ bool get_IsSettingsUIInteractable();
                    /*0x2bf611c*/ bool get_IsInternalTargetedAdsUIInteractable();
                    /*0x2bf628c*/ string get_IdentityPin();
                    /*0x2bf6394*/ void ShowConsentFlowPopup(EA.Unity.StarlightWrapper.CentralServices.ConsentPopupTypes consentPopupType);
                    /*0x2bf65ac*/ void SetProfileValue(string key, object value);
                    /*0x2bf6748*/ void SetConsentFormOverrides(System.Collections.Generic.Dictionary<string, string> themes);
                    /*0x2bf68c8*/ void InitializeInternal(Csdk.GluCentralServices.IGluCentralServices centralServices, System.Action onComplete);
                    /*0x2bf6c48*/ void DoDispose(Csdk.GluCentralServices.IGluCentralServices centralServices);
                    /*0x2bf642c*/ void ShowConsentFlowPopupInternal(Csdk.GluCentralServices.IGluCentralServices centralServices, EA.Unity.StarlightWrapper.CentralServices.ConsentPopupTypes consentPopupType);
                    /*0x2bf6e1c*/ void ConsentUpdateCallback(Csdk.GluCentralServices.ConsentUpdateResult consentUpdateResult);
                }

                class CentralServicesInitData : EA.Unity.StarlightWrapper.WrapperInitData<EA.Unity.StarlightWrapper.CentralServices.CentralServices, Csdk.GluCentralServices.IGluCentralServices>
                {
                    /*0x28*/ EA.Unity.StarlightWrapper.StarlightWrapperInitData <StarlightWrapperInitData>k__BackingField;
                    /*0x30*/ EA.Unity.StarlightWrapper.CentralServices.IAccountOperationHandler <AccountOperationHandler>k__BackingField;
                    /*0x38*/ System.Action <OnConsentFlowDone>k__BackingField;
                    /*0x40*/ System.Action <OnAgeGateFailed>k__BackingField;

                    /*0x2bf6f64*/ CentralServicesInitData(EA.Unity.StarlightWrapper.StarlightWrapperInitData starlightWrapperInitData);
                    /*0x2bf7030*/ EA.Unity.StarlightWrapper.StarlightWrapperInitData get_StarlightWrapperInitData();
                    /*0x2bf7038*/ EA.Unity.StarlightWrapper.CentralServices.IAccountOperationHandler get_AccountOperationHandler();
                    /*0x2bf7040*/ System.Action get_OnConsentFlowDone();
                    /*0x2bf7048*/ System.Action get_OnAgeGateFailed();
                }

                enum ConsentPopupTypes
                {
                    Launch = 0,
                    Settings = 1,
                }

                interface ICentralServices : EA.Unity.StarlightWrapper.IWrapper<Csdk.GluCentralServices.IGluCentralServices>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x1f30ebc*/ void add_OnConsentFlowDone(System.Action value);
                    /*0x1f30ebc*/ void remove_OnConsentFlowDone(System.Action value);
                    /*0x1f30214*/ Csdk.GluCentralServices.ConsentUpdateResult get_ConsentUpdateResult();
                    /*0x1f2fe14*/ bool get_HasCompletedConsentFlow();
                    /*0x1f2fe14*/ bool get_IsSettingsUIInteractable();
                    /*0x1f2fe14*/ bool get_IsInternalTargetedAdsUIInteractable();
                    /*0x1f30214*/ string get_IdentityPin();
                    /*0x1f30b78*/ void ShowConsentFlowPopup(EA.Unity.StarlightWrapper.CentralServices.ConsentPopupTypes consentPopupType);
                    /*0x1f30ff0*/ void SetProfileValue(string key, object value);
                    /*0x1f30ebc*/ void SetConsentFormOverrides(System.Collections.Generic.Dictionary<string, string> themes);
                }

                interface IResourceGetter
                {
                }

                class JsonResourceGetter : EA.Unity.StarlightWrapper.CentralServices.IResourceGetter
                {
                    /*0x10*/ EA.Unity.StarlightWrapper.CentralServices.IResourceGetter resourceGetter;

                    /*0x2bf6c18*/ JsonResourceGetter(EA.Unity.StarlightWrapper.CentralServices.IResourceGetter resourceGetter);
                }

                class PenguinResourceGetter : EA.Unity.StarlightWrapper.CentralServices.IResourceGetter
                {
                    /*0x10*/ Csdk.GluCentralServices.IGluCentralServices centralServices;

                    /*0x2bf6be8*/ PenguinResourceGetter(Csdk.GluCentralServices.IGluCentralServices centralServices);
                }
            }
        }
    }
}
