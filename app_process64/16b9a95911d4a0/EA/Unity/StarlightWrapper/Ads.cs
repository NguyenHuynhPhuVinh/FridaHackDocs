class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace Ads
            {
                class Ads : EA.Unity.StarlightWrapper.Wrapper<EA.Unity.StarlightWrapper.Ads.Data.AdsInitData, EA.Unity.StarlightWrapper.Ads.Ads, Csdk.GluAds.IAdvertising, EA.Unity.StarlightWrapper.ConfigData>, EA.Unity.StarlightWrapper.Ads.IAds, EA.Unity.StarlightWrapper.IWrapper<Csdk.GluAds.IAdvertising>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x48*/ EA.Unity.StarlightWrapper.Ads.RuntimeStateData runtimeStateData;
                    /*0x50*/ EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler gluAdsCallbackHandler;
                    /*0x58*/ EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler gluAdsLoadHandler;
                    /*0x60*/ EA.Unity.StarlightWrapper.Ads.GluAdsShowHandler gluAdsShowHandler;
                    /*0x68*/ EA.Unity.StarlightWrapper.Ads.Data.AdsData adsData;
                    /*0x70*/ bool requiresInitializeRetry;
                    /*0x74*/ int lastSuppressionStateChangedFrame;
                    /*0x78*/ UnityEngine.Coroutine autoUpdateSuppressionStateCoroutine;
                    /*0x80*/ System.Collections.Generic.Dictionary<string, object> adsTrackedData;
                    /*0x88*/ EA.Unity.StarlightWrapper.Ads.Suppression suppression;
                    /*0x90*/ EA.Unity.StarlightWrapper.Analytics.IAnalytics analytics;
                    /*0x98*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices centralServices;
                    /*0xa0*/ System.Action OnSuppressionStateChanged;

                    /*0x2be8d40*/ Ads();
                    /*0x2be63cc*/ uint get_LastAdWatchedTime();
                    /*0x2be6428*/ Csdk.Revenue.RevSDKComponent get_StarlightComponentType();
                    /*0x2be6430*/ EA.Unity.StarlightWrapper.Ads.Suppression get_Suppression();
                    /*0x2be6480*/ bool get_IsShowingAd();
                    /*0x2be64b0*/ void add_CanShowAdChecks(System.Predicate<string> value);
                    /*0x2be6574*/ void remove_CanShowAdChecks(System.Predicate<string> value);
                    /*0x2be6638*/ void add_CanLoadAdChecks(System.Predicate<string> value);
                    /*0x2be66fc*/ void remove_CanLoadAdChecks(System.Predicate<string> value);
                    /*0x2be67c0*/ void add_CanPreLoadAdChecks(System.Func<bool> value);
                    /*0x2be6884*/ void remove_CanPreLoadAdChecks(System.Func<bool> value);
                    /*0x2be6948*/ void add_OnShowAdFailed(System.Action<string> value);
                    /*0x2be6a0c*/ void remove_OnShowAdFailed(System.Action<string> value);
                    /*0x2be6ad0*/ void add_OnAdOpened(System.Action<string> value);
                    /*0x2be6b94*/ void remove_OnAdOpened(System.Action<string> value);
                    /*0x2be6c58*/ void add_OnAdClosed(System.Action<string> value);
                    /*0x2be6d1c*/ void remove_OnAdClosed(System.Action<string> value);
                    /*0x2be6de0*/ void add_OnSuppressionStateChanged(System.Action value);
                    /*0x2be6e7c*/ void remove_OnSuppressionStateChanged(System.Action value);
                    /*0x2be6f18*/ int get_TotalAdsWatched();
                    /*0x2be6f74*/ void SetAdsData(EA.Unity.StarlightWrapper.Ads.Data.AdsData adsData);
                    /*0x2be7344*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition GetAdDefinition(string adId);
                    /*0x2be73c8*/ void LoadInterstitialAd(string adId, System.Action<bool> onAdLoaded, float customTimeout);
                    /*0x2be76cc*/ void ShowAd(string adId, System.Action<bool> onAdShown, string customRewardData, float customTimeout);
                    /*0x2be7b34*/ void DisableBannerAd();
                    /*0x2be7c8c*/ void AddSuppressionStateUpdater(System.Func<System.Collections.Generic.Dictionary<string, object>> updater);
                    /*0x2be7ca0*/ bool CanShowAd(string adId);
                    /*0x2be7cc8*/ EA.Unity.StarlightWrapper.Ads.Data.AdStates GetAdState(string adId);
                    /*0x2be7f80*/ void SetData(EA.Unity.StarlightWrapper.ConfigData data, EA.Unity.StarlightWrapper.Ads.Data.AdsInitData initData);
                    /*0x2be7ff4*/ void InitializeInternal(Csdk.GluAds.IAdvertising advertising, System.Action onComplete);
                    /*0x2be88e8*/ void DoDispose(Csdk.GluAds.IAdvertising advertising);
                    /*0x2be8b4c*/ void SetupInterdependencies(System.Collections.Generic.Dictionary<Csdk.Revenue.RevSDKComponent, EA.Unity.StarlightWrapper.IWrapperBase> wrappers);
                    /*0x2be70b0*/ void InitSuppression();
                    /*0x2be8c78*/ void UpdateSuppressionState();
                    /*0x2be887c*/ System.Collections.IEnumerator AutoUpdateSuppressionStateCoroutine();
                    /*0x2be8ea4*/ System.Collections.Generic.Dictionary<string, object> <InitSuppression>g__GetAdsTrackedData|61_0();

                    class <AutoUpdateSuppressionStateCoroutine>d__63 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ EA.Unity.StarlightWrapper.Ads.Ads <>4__this;

                        /*0x2be8d18*/ <AutoUpdateSuppressionStateCoroutine>d__63(int <>1__state);
                        /*0x2be8fd8*/ void System.IDisposable.Dispose();
                        /*0x2be8fdc*/ bool MoveNext();
                        /*0x2be90b4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x2be90bc*/ void System.Collections.IEnumerator.Reset();
                        /*0x2be90f4*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                interface IAds : EA.Unity.StarlightWrapper.IWrapper<Csdk.GluAds.IAdvertising>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x1f30214*/ EA.Unity.StarlightWrapper.Ads.Suppression get_Suppression();
                    /*0x1f2fe14*/ bool get_IsShowingAd();
                    /*0x1f30ebc*/ void add_OnShowAdFailed(System.Action<string> value);
                    /*0x1f30ebc*/ void remove_OnShowAdFailed(System.Action<string> value);
                    /*0x1f30ebc*/ void add_OnAdOpened(System.Action<string> value);
                    /*0x1f30ebc*/ void remove_OnAdOpened(System.Action<string> value);
                    /*0x1f30ebc*/ void add_OnAdClosed(System.Action<string> value);
                    /*0x1f30ebc*/ void remove_OnAdClosed(System.Action<string> value);
                    /*0x1f30ebc*/ void add_OnSuppressionStateChanged(System.Action value);
                    /*0x1f30ebc*/ void remove_OnSuppressionStateChanged(System.Action value);
                    /*0x1f30ebc*/ void SetAdsData(EA.Unity.StarlightWrapper.Ads.Data.AdsData adsData);
                    /*0x1f302cc*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition GetAdDefinition(string adId);
                    void LoadInterstitialAd(string adId, System.Action<bool> onAdLoaded, float customTimeout);
                    void ShowAd(string adId, System.Action<bool> onAdShown, string customRewardData, float customTimeout);
                    /*0x1f30ebc*/ void AddSuppressionStateUpdater(System.Func<System.Collections.Generic.Dictionary<string, object>> updater);
                    /*0x1f2fec8*/ bool CanShowAd(string adId);
                    /*0x1f3008c*/ EA.Unity.StarlightWrapper.Ads.Data.AdStates GetAdState(string adId);
                }

                class Constants
                {
                    static /*0x2be90fc*/ string GetAdTypeStringFromEnum(EA.Unity.StarlightWrapper.Ads.Data.AdTypes adTypes);
                }

                class GluAdsCallbackHandler
                {
                    /*0x10*/ Csdk.GluAds.IAdvertising gluAds;
                    /*0x18*/ EA.Unity.StarlightWrapper.Ads.RuntimeStateData runtimeStateData;
                    /*0x20*/ EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler gluAdsLoadHandler;
                    /*0x28*/ EA.Unity.StarlightWrapper.Ads.GluAdsShowHandler gluAdsShowHandler;
                    /*0x30*/ EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler.GluAdsCallbackLogger placementErrorLogger;
                    /*0x38*/ UnityEngine.ILogger logger;

                    /*0x2be85ac*/ GluAdsCallbackHandler(Csdk.GluAds.IAdvertising gluAds, EA.Unity.StarlightWrapper.Ads.RuntimeStateData runtimeStateData, EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler gluAdsLoadHandler, EA.Unity.StarlightWrapper.Ads.GluAdsShowHandler gluAdsShowHandler, EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors ignoredErrors, UnityEngine.ILogger logger);
                    /*0x2be898c*/ void CleanUp();
                    /*0x2be92a4*/ void OnPlacementReceived(Csdk.GluAds.PlacementEvent placementEvent);
                    /*0x2be9d20*/ void OnRewardReceived(Csdk.GluAds.Reward rewardReceived);
                    /*0x2be99dc*/ void HandleInterstitialEvent(Csdk.GluAds.PlacementEvent placementEvent, bool success);
                    /*0x2be9b78*/ void HandleOfferWallEvent(Csdk.GluAds.PlacementEvent placementEvent, bool success);
                    /*0x2be9c48*/ void HandleBannerEvent(Csdk.GluAds.PlacementEvent placementEvent, bool success);
                    /*0x2be9dec*/ void <HandleInterstitialEvent>g__HandleLoadStarted|16_0(ref EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler.<> );
                    /*0x2be9e14*/ void <HandleInterstitialEvent>g__HandleLoadFinished|16_1(ref EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler.<> );
                    /*0x2be9e78*/ void <HandleInterstitialEvent>g__HandleShowStarted|16_2(ref EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler.<> );
                    /*0x2be9ec0*/ void <HandleInterstitialEvent>g__HandleShowFinished|16_3(ref EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler.<> );
                    /*0x2be9f10*/ void <HandleInterstitialEvent>g__HandleExpired|16_4(ref EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler.<> );

                    class GluAdsCallbackLogger
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors ignoredErrors;
                        /*0x18*/ UnityEngine.ILogger logger;
                        /*0x20*/ System.Collections.Generic.Queue<string> recentIgnoredErrors;

                        /*0x2be91ec*/ GluAdsCallbackLogger(UnityEngine.ILogger logger, EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors ignoredErrors);
                        /*0x2be97b4*/ bool HandlePlacementEventError(Csdk.GluAds.PlacementEvent placementEvent);
                        /*0x2beac50*/ void LogPlacementEventWarning(string tag, string message, Csdk.GluAds.PlacementEvent placementEvent);
                        /*0x2be96e0*/ void LogPlacementEventError(string tag, string message, Csdk.GluAds.PlacementEvent placementEvent);
                        /*0x2bead24*/ string GetPlacementEventMessageString(string message, Csdk.GluAds.PlacementEvent placementEvent);
                        /*0x2beb1d0*/ string GetExtraDataString(Csdk.GluAds.PlacementEvent placementEvent);
                    }

                    struct <>c__DisplayClass16_0
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.Ads.GluAdsCallbackHandler <>4__this;
                        /*0x18*/ Csdk.GluAds.PlacementEvent placementEvent;
                        /*0x20*/ bool success;
                    }
                }

                class GluAdsLoadHandler
                {
                    /*0x10*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices <CentralServices>k__BackingField;
                    /*0x18*/ Csdk.GluAds.IAdvertising gluAds;
                    /*0x20*/ EA.Unity.StarlightWrapper.Ads.RuntimeStateData runtimeStateData;
                    /*0x28*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler.LoadRequest> adLoadRequests;
                    /*0x30*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<int, bool>> isAdLoadedAtFrame;
                    /*0x38*/ UnityEngine.Coroutine adLoadTimeoutCoroutine;
                    /*0x40*/ UnityEngine.Coroutine preloadCoroutine;
                    /*0x48*/ bool adLoadTimeoutEnabled;
                    /*0x4c*/ float adLoadTimeout;
                    /*0x50*/ UnityEngine.ILogger logger;
                    /*0x58*/ System.Action OnLoadAdsFinished;

                    /*0x2be839c*/ GluAdsLoadHandler(Csdk.GluAds.IAdvertising gluAds, EA.Unity.StarlightWrapper.Ads.RuntimeStateData runtimeStateData, bool adLoadTimeoutEnabled, float adLoadTimeout, UnityEngine.ILogger logger);
                    /*0x2beb610*/ bool get_CanPreLoadAds();
                    /*0x2beb738*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices get_CentralServices();
                    /*0x2beb740*/ void set_CentralServices(EA.Unity.StarlightWrapper.CentralServices.ICentralServices value);
                    /*0x2beb748*/ void add_OnLoadAdsFinished(System.Action value);
                    /*0x2beb7e4*/ void remove_OnLoadAdsFinished(System.Action value);
                    /*0x2beb880*/ void PreLoadAllAds(System.Action<bool> onInterstitialsLoaded, System.Action<bool> onRewardedInterstitialsLoaded, float customTimeout);
                    /*0x2be747c*/ void LoadInterstitialAd(string adId, System.Action<bool> onAdLoaded, float customTimeout);
                    /*0x2beba34*/ void LoadInterstitialAds(EA.Unity.StarlightWrapper.Ads.Data.AdTypes adType, System.Action<bool> onAdsLoaded, float customTimeout);
                    /*0x2be8804*/ void StartPreLoadCoroutine();
                    /*0x2be7de4*/ bool IsAdLoading(string adId);
                    /*0x2be7e74*/ bool IsAdLoaded(string adId);
                    /*0x2bea49c*/ void FinishLoadAd(string placementName, bool success);
                    /*0x2be8b34*/ void CleanUp();
                    /*0x2bebccc*/ System.Collections.IEnumerator CheckForAdPreLoadCoroutine();
                    /*0x2beba94*/ void LoadAdPlacements(System.Action<bool> onAdsLoaded, float customTimeout, EA.Unity.StarlightWrapper.Ads.Data.AdDefinition[] adPlacements);
                    /*0x2bec1c0*/ void GluAdsLoad(EA.Unity.StarlightWrapper.Ads.Data.AdTypes advertisementTypes, string placement, float customTimeout);
                    /*0x2bebd38*/ bool IsAdLoadedCached(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adDefinition, System.Collections.Generic.IDictionary<string, object> extra);
                    /*0x2bebfdc*/ void RemoveAdFromLoadingQueue(string placementName, bool success);
                    /*0x2bec5c0*/ System.Collections.IEnumerator AdLoadTimeout(string placement, float customTimeout);
                    /*0x2bec2f8*/ void StopPreloadCoroutine();
                    /*0x2bebf60*/ void StopAdLoadTimeoutCoroutine();
                    /*0x2bec39c*/ System.ValueTuple<bool, EA.Unity.StarlightWrapper.Ads.Data.AdDefinition> <LoadAdPlacements>g__TryLoad|31_0(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adPlacement, ref EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler.<> );

                    class LoadRequest
                    {
                        /*0x10*/ System.Action<bool> <Callback>k__BackingField;
                        /*0x18*/ System.Collections.Generic.HashSet<string> <LoadingAdPlacements>k__BackingField;
                        /*0x20*/ bool <LoadSuccess>k__BackingField;

                        /*0x2bec570*/ LoadRequest(System.Action<bool> callback, System.Collections.Generic.HashSet<string> loadingAdPlacements);
                        /*0x2bec69c*/ System.Action<bool> get_Callback();
                        /*0x2bec6a4*/ System.Collections.Generic.HashSet<string> get_LoadingAdPlacements();
                        /*0x2bec6ac*/ bool get_LoadSuccess();
                        /*0x2bec6b4*/ void set_LoadSuccess(bool value);
                        /*0x2bec658*/ void FailAdLoad();
                    }

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ bool doneInterstitials;
                        /*0x11*/ bool doneRewarded;
                        /*0x18*/ EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler <>4__this;
                        /*0x20*/ System.Action<bool> onInterstitialsLoaded;
                        /*0x28*/ System.Action<bool> onRewardedInterstitialsLoaded;

                        /*0x2beba2c*/ <>c__DisplayClass22_0();
                        /*0x2bec6bc*/ void <PreLoadAllAds>g__CheckLoadDone|0();
                        /*0x2bec73c*/ void <PreLoadAllAds>b__1(bool success);
                        /*0x2bec788*/ void <PreLoadAllAds>b__2(bool success);
                    }

                    struct <>c__DisplayClass31_0
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler <>4__this;
                        /*0x18*/ float customTimeout;
                    }

                    class <AdLoadTimeout>d__35 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ float customTimeout;
                        /*0x28*/ EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler <>4__this;
                        /*0x30*/ string placement;

                        /*0x2bec660*/ <AdLoadTimeout>d__35(int <>1__state);
                        /*0x2bec7d4*/ void System.IDisposable.Dispose();
                        /*0x2bec7d8*/ bool MoveNext();
                        /*0x2bec8d0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x2bec8d8*/ void System.Collections.IEnumerator.Reset();
                        /*0x2bec910*/ object System.Collections.IEnumerator.get_Current();
                    }

                    class <CheckForAdPreLoadCoroutine>d__30 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler <>4__this;

                        /*0x2bec374*/ <CheckForAdPreLoadCoroutine>d__30(int <>1__state);
                        /*0x2bec918*/ void System.IDisposable.Dispose();
                        /*0x2bec91c*/ bool MoveNext();
                        /*0x2becac0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x2becac8*/ void System.Collections.IEnumerator.Reset();
                        /*0x2becb00*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class GluAdsShowHandler
                {
                    /*0x10*/ Csdk.GluAds.IAdvertising gluAds;
                    /*0x18*/ EA.Unity.StarlightWrapper.Ads.RuntimeStateData runtimeStateData;
                    /*0x20*/ EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler gluAdsLoadHandler;
                    /*0x28*/ System.Action onUpdateSuppressionState;
                    /*0x30*/ EA.Unity.StarlightWrapper.Ads.Suppression suppression;
                    /*0x38*/ bool manualBase64RewardData;
                    /*0x39*/ bool adShowTimeoutEnabled;
                    /*0x3c*/ float adShowTimeout;
                    /*0x40*/ UnityEngine.ILogger logger;
                    /*0x48*/ System.Action<bool> onShowAdFinished;
                    /*0x50*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition suspendedBannerAd;
                    /*0x58*/ UnityEngine.Coroutine showAdTimeout;
                    /*0x60*/ EA.Unity.StarlightWrapper.Analytics.IAnalytics <Analytics>k__BackingField;

                    /*0x2be84e0*/ GluAdsShowHandler(Csdk.GluAds.IAdvertising gluAds, EA.Unity.StarlightWrapper.Ads.RuntimeStateData runtimeStateData, EA.Unity.StarlightWrapper.Ads.GluAdsLoadHandler gluAdsLoadHandler, System.Action onUpdateSuppressionState, EA.Unity.StarlightWrapper.Ads.Suppression suppression, bool manualBase64RewardData, bool adShowTimeoutEnabled, float adShowTimeout, UnityEngine.ILogger logger);
                    /*0x2becb08*/ EA.Unity.StarlightWrapper.Analytics.IAnalytics get_Analytics();
                    /*0x2becb10*/ void set_Analytics(EA.Unity.StarlightWrapper.Analytics.IAnalytics value);
                    /*0x2be7ee4*/ bool IsAdAvailable(string adId);
                    /*0x2be77a0*/ void ShowAd(string adId, string customRewardData, System.Action<bool> callback, float customTimeout);
                    /*0x2be7b9c*/ void DisableBannerAd();
                    /*0x2be9f28*/ void FinishShowAd(string placement, bool success);
                    /*0x2becb34*/ bool CheckCanShowAd(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adToShow, string customRewardData, float customTimeout, System.Action<bool> callback);
                    /*0x2becd10*/ bool CheckAdLoaded(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adToShow, string customRewardData, float customTimeout, System.Action<bool> callback);
                    /*0x2bed0e8*/ void ShowBannerAd(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adToShow, System.Action<bool> callback);
                    /*0x2becfa0*/ void GluAdsShow(EA.Unity.StarlightWrapper.Ads.Data.AdTypes advertisementTypes, string placement, float customTimeout, System.Collections.Generic.IDictionary<string, object> extra);
                    /*0x2bed2c4*/ System.Collections.IEnumerator ShowAdTimeout(string placement, float customTimeout);

                    class <>c__DisplayClass18_0
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.Ads.GluAdsShowHandler <>4__this;
                        /*0x18*/ string adId;
                        /*0x20*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adToShow;
                        /*0x28*/ System.Action<bool> callback;

                        /*0x2becb2c*/ <>c__DisplayClass18_0();
                        /*0x2bed384*/ void <ShowAd>b__0(bool success);
                        /*0x2beceac*/ void <ShowAd>g__PrepareToShowAd|1();
                    }

                    class <>c__DisplayClass21_0
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.Ads.GluAdsShowHandler <>4__this;
                        /*0x18*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adToShow;
                        /*0x20*/ string customRewardData;
                        /*0x28*/ System.Action<bool> callback;
                        /*0x30*/ float customTimeout;

                        /*0x2bed2b4*/ <>c__DisplayClass21_0();
                        /*0x2bed3e4*/ void <CheckCanShowAd>b__0();
                    }

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ EA.Unity.StarlightWrapper.Ads.GluAdsShowHandler <>4__this;
                        /*0x18*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adToShow;
                        /*0x20*/ string customRewardData;
                        /*0x28*/ System.Action<bool> callback;
                        /*0x30*/ float customTimeout;

                        /*0x2bed2bc*/ <>c__DisplayClass22_0();
                        /*0x2bed414*/ void <CheckAdLoaded>b__0(bool <p0>);
                    }

                    class <ShowAdTimeout>d__25 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ EA.Unity.StarlightWrapper.Ads.GluAdsShowHandler <>4__this;
                        /*0x28*/ float customTimeout;
                        /*0x30*/ string placement;

                        /*0x2bed35c*/ <ShowAdTimeout>d__25(int <>1__state);
                        /*0x2bed49c*/ void System.IDisposable.Dispose();
                        /*0x2bed4a0*/ bool MoveNext();
                        /*0x2bed618*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x2bed620*/ void System.Collections.IEnumerator.Reset();
                        /*0x2bed658*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class RuntimeStateData
                {
                    /*0x10*/ EA.Unity.StarlightWrapper.Ads.Data.AdsData <Data>k__BackingField;
                    /*0x18*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<EA.Unity.StarlightWrapper.Ads.Data.AdTypes, float>> LoadingAds;
                    /*0x20*/ int <ConsecutiveFailedAdLoads>k__BackingField;
                    /*0x24*/ uint <TimeOfLastPreLoad>k__BackingField;
                    /*0x28*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition <ShowingAd>k__BackingField;
                    /*0x30*/ bool <AdTimeoutShowStarted>k__BackingField;
                    /*0x38*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition <CurrentActiveBanner>k__BackingField;
                    /*0x40*/ System.Predicate<string> CanShowAdChecks;
                    /*0x48*/ System.Predicate<string> CanLoadAdChecks;
                    /*0x50*/ System.Func<bool> CanPreLoadAdChecks;
                    /*0x58*/ System.Action<string> OnShowAdFailed;
                    /*0x60*/ System.Action<string> OnAdOpened;
                    /*0x68*/ System.Action<string> OnAdClosed;

                    /*0x2be8e1c*/ RuntimeStateData();
                    /*0x2bed660*/ EA.Unity.StarlightWrapper.Ads.Data.AdsData get_Data();
                    /*0x2bed668*/ void set_Data(EA.Unity.StarlightWrapper.Ads.Data.AdsData value);
                    /*0x2bed670*/ int get_ConsecutiveFailedAdLoads();
                    /*0x2bed678*/ void set_ConsecutiveFailedAdLoads(int value);
                    /*0x2bed680*/ uint get_TimeOfLastPreLoad();
                    /*0x2bed688*/ void set_TimeOfLastPreLoad(uint value);
                    /*0x2bed690*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition get_ShowingAd();
                    /*0x2bed698*/ void set_ShowingAd(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition value);
                    /*0x2be64a0*/ bool get_IsShowingAd();
                    /*0x2bed6a0*/ bool get_AdTimeoutShowStarted();
                    /*0x2bed6a8*/ void set_AdTimeoutShowStarted(bool value);
                    /*0x2bed6b0*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition get_CurrentActiveBanner();
                    /*0x2bed6b8*/ void set_CurrentActiveBanner(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition value);
                    /*0x2be63e0*/ uint get_LastAdWatchedTime();
                    /*0x2bed1f0*/ void set_LastAdWatchedTime(uint value);
                    /*0x2be6f2c*/ int get_TotalAdsWatched();
                    /*0x2bed244*/ void set_TotalAdsWatched(int value);
                    /*0x2be70a8*/ void SetAdsData(EA.Unity.StarlightWrapper.Ads.Data.AdsData adsData);
                    /*0x2be64c4*/ void add_CanShowAdChecks(System.Predicate<string> value);
                    /*0x2be6588*/ void remove_CanShowAdChecks(System.Predicate<string> value);
                    /*0x2be664c*/ void add_CanLoadAdChecks(System.Predicate<string> value);
                    /*0x2be6710*/ void remove_CanLoadAdChecks(System.Predicate<string> value);
                    /*0x2be67d4*/ void add_CanPreLoadAdChecks(System.Func<bool> value);
                    /*0x2be6898*/ void remove_CanPreLoadAdChecks(System.Func<bool> value);
                    /*0x2be695c*/ void add_OnShowAdFailed(System.Action<string> value);
                    /*0x2be6a20*/ void remove_OnShowAdFailed(System.Action<string> value);
                    /*0x2be6ae4*/ void add_OnAdOpened(System.Action<string> value);
                    /*0x2be6ba8*/ void remove_OnAdOpened(System.Action<string> value);
                    /*0x2be6c6c*/ void add_OnAdClosed(System.Action<string> value);
                    /*0x2be6d30*/ void remove_OnAdClosed(System.Action<string> value);
                    /*0x2becb18*/ bool CanShowAd(string adId);
                    /*0x2bec688*/ bool CanLoadAd(string adId);
                    /*0x2beb72c*/ bool CanPreLoadAds();
                    /*0x2bed3c8*/ void ShowAdFailed(string adId);
                    /*0x2be9d04*/ void AdOpened(string adId);
                    /*0x2bed298*/ void AdClosed(string adId);
                }

                namespace Data
                {
                    class AdsInitData : EA.Unity.StarlightWrapper.WrapperInitData<EA.Unity.StarlightWrapper.Ads.Ads, Csdk.GluAds.IAdvertising>
                    {
                        /*0x28*/ EA.Unity.StarlightWrapper.Ads.Data.AdsData <AdsData>k__BackingField;
                        /*0x30*/ EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors <IgnoredErrors>k__BackingField;
                        /*0x38*/ System.Collections.Generic.List<System.Func<System.Collections.Generic.Dictionary<string, object>>> <SuppressionStateUpdaters>k__BackingField;
                        /*0x40*/ System.Predicate<string> <CanShowAdChecks>k__BackingField;
                        /*0x48*/ System.Predicate<string> <CanLoadAdChecks>k__BackingField;
                        /*0x50*/ System.Func<bool> <CanPreLoadAdChecks>k__BackingField;
                        /*0x58*/ System.Action<string> <OnShowAdFailed>k__BackingField;
                        /*0x60*/ System.Action<string> <OnAdOpened>k__BackingField;
                        /*0x68*/ System.Action<string> <OnAdClosed>k__BackingField;
                        /*0x70*/ System.Action <OnSuppressionStateChanged>k__BackingField;
                        /*0x78*/ bool <AdLoadTimeoutEnabled>k__BackingField;
                        /*0x7c*/ float <AdLoadTimeout>k__BackingField;
                        /*0x80*/ bool <AdShowTimeoutEnabled>k__BackingField;
                        /*0x84*/ float <AdShowTimeout>k__BackingField;
                        /*0x88*/ bool <ManualBase64RewardData>k__BackingField;
                        /*0x8c*/ float <AutoUpdateSuppressionStateInterval>k__BackingField;

                        /*0x2bed780*/ AdsInitData();
                        /*0x2bed6c0*/ EA.Unity.StarlightWrapper.Ads.Data.AdsData get_AdsData();
                        /*0x2bed6c8*/ void set_AdsData(EA.Unity.StarlightWrapper.Ads.Data.AdsData value);
                        /*0x2bed6d0*/ EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors get_IgnoredErrors();
                        /*0x2bed6d8*/ void set_IgnoredErrors(EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors value);
                        /*0x2bed6e0*/ System.Collections.Generic.List<System.Func<System.Collections.Generic.Dictionary<string, object>>> get_SuppressionStateUpdaters();
                        /*0x2bed6e8*/ System.Predicate<string> get_CanShowAdChecks();
                        /*0x2bed6f0*/ void set_CanShowAdChecks(System.Predicate<string> value);
                        /*0x2bed6f8*/ System.Predicate<string> get_CanLoadAdChecks();
                        /*0x2bed700*/ void set_CanLoadAdChecks(System.Predicate<string> value);
                        /*0x2bed708*/ System.Func<bool> get_CanPreLoadAdChecks();
                        /*0x2bed710*/ System.Action<string> get_OnShowAdFailed();
                        /*0x2bed718*/ System.Action<string> get_OnAdOpened();
                        /*0x2bed720*/ System.Action<string> get_OnAdClosed();
                        /*0x2bed728*/ System.Action get_OnSuppressionStateChanged();
                        /*0x2bed730*/ bool get_AdLoadTimeoutEnabled();
                        /*0x2bed738*/ void set_AdLoadTimeoutEnabled(bool value);
                        /*0x2bed740*/ float get_AdLoadTimeout();
                        /*0x2bed748*/ void set_AdLoadTimeout(float value);
                        /*0x2bed750*/ bool get_AdShowTimeoutEnabled();
                        /*0x2bed758*/ void set_AdShowTimeoutEnabled(bool value);
                        /*0x2bed760*/ float get_AdShowTimeout();
                        /*0x2bed768*/ void set_AdShowTimeout(float value);
                        /*0x2bed770*/ bool get_ManualBase64RewardData();
                        /*0x2bed778*/ float get_AutoUpdateSuppressionStateInterval();
                    }
                }
            }
        }
    }
}
