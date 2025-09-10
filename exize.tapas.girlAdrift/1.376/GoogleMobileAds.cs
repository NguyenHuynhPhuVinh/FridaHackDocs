class <Module>
{
}

namespace GoogleMobileAds
{
    namespace Api
    {
        class AdError
        {
            /*0x10*/ GoogleMobileAds.Common.IAdErrorClient client;

            /*0x1844d34*/ AdError(GoogleMobileAds.Common.IAdErrorClient client);
            /*0x1844d5c*/ int GetCode();
            /*0x1844dfc*/ string GetDomain();
            /*0x1844ea0*/ string GetMessage();
            /*0x1844f44*/ GoogleMobileAds.Api.AdError GetCause();
            /*0x1845028*/ string ToString();
        }

        class AdErrorEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Api.AdError <AdError>k__BackingField;
            /*0x18*/ string <Message>k__BackingField;

            /*0x1845048*/ AdErrorEventArgs();
            /*0x18450a0*/ GoogleMobileAds.Api.AdError get_AdError();
            /*0x18450a8*/ void set_AdError(GoogleMobileAds.Api.AdError value);
            /*0x18450b0*/ string get_Message();
            /*0x18450b8*/ void set_Message(string value);
        }

        class AdFailedToLoadEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Api.LoadAdError <LoadAdError>k__BackingField;

            /*0x18450c0*/ AdFailedToLoadEventArgs();
            /*0x1845118*/ GoogleMobileAds.Api.LoadAdError get_LoadAdError();
            /*0x1845120*/ void set_LoadAdError(GoogleMobileAds.Api.LoadAdError value);
        }

        class AdInspectorError : GoogleMobileAds.Api.AdError
        {
            /*0x1845128*/ AdInspectorError(GoogleMobileAds.Common.IAdInspectorErrorClient client);
            /*0x1845150*/ GoogleMobileAds.Api.AdInspectorError.AdInspectorErrorCode GetCode();

            enum AdInspectorErrorCode
            {
                ERROR_CODE_INTERNAL_ERROR = 0,
                ERROR_CODE_FAILED_TO_LOAD = 1,
                ERROR_CODE_NOT_IN_TEST_MODE = 2,
                ERROR_CODE_ALREADY_OPEN = 3,
            }
        }

        class AppOpenAd
        {
            static /*0x0*/ System.Collections.Generic.HashSet<GoogleMobileAds.Common.IAppOpenAdClient> loadingClients;
            /*0x10*/ GoogleMobileAds.Common.IAppOpenAdClient client;
            /*0x18*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x20*/ System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x30*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            static /*0x184635c*/ AppOpenAd();
            static /*0x1845bd4*/ void LoadAd(string adUnitID, UnityEngine.ScreenOrientation orientation, GoogleMobileAds.Api.AdRequest request, System.Action<GoogleMobileAds.Api.AppOpenAd, GoogleMobileAds.Api.AdFailedToLoadEventArgs> adLoadCallback);
            /*0x1845154*/ AppOpenAd(GoogleMobileAds.Common.IAppOpenAdClient client);
            /*0x18454f4*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x18455a4*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1845654*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x1845704*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x18457b4*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1845864*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1845914*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x18459c4*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1845a74*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1845b24*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1846100*/ void Show();
            /*0x18461ac*/ void Destroy();
            /*0x1846250*/ ResponseInfo GetResponseInfo();
            /*0x18463e8*/ void <AppOpenAd>m__0(object sender, GoogleMobileAds.Common.AdErrorClientEventArgs args);
            /*0x18464bc*/ void <AppOpenAd>m__1(object sender, System.EventArgs args);
            /*0x18464dc*/ void <AppOpenAd>m__2(object sender, System.EventArgs args);
            /*0x18464fc*/ void <AppOpenAd>m__3(object sender, System.EventArgs args);
            /*0x184651c*/ void <AppOpenAd>m__4(object sender, GoogleMobileAds.Api.AdValueEventArgs args);

            class <LoadAd>c__AnonStorey0
            {
                /*0x10*/ System.Action<GoogleMobileAds.Api.AppOpenAd, GoogleMobileAds.Api.AdFailedToLoadEventArgs> adLoadCallback;
                /*0x18*/ GoogleMobileAds.Common.IAppOpenAdClient client;

                /*0x1845f6c*/ <LoadAd>c__AnonStorey0();
                /*0x184653c*/ void <>m__0(object sender, System.EventArgs args);
                /*0x1846610*/ void <>m__1(object sender, GoogleMobileAds.Common.LoadAdErrorClientEventArgs args);
            }
        }

        class AppStateEventNotifier
        {
            static /*0x0*/ GoogleMobileAds.Common.IAppStateEventClient client;

            static /*0x1846760*/ AppStateEventNotifier();
            static /*0x184682c*/ void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            static /*0x18468fc*/ void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x1846824*/ AppStateEventNotifier();
        }

        class BannerView
        {
            /*0x10*/ GoogleMobileAds.Common.IBannerClient client;
            /*0x18*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x20*/ System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> OnAdFailedToLoad;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdOpening;
            /*0x30*/ System.EventHandler<System.EventArgs> OnAdClosed;
            /*0x38*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;

            /*0x18469d0*/ BannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, GoogleMobileAds.Api.AdPosition position);
            /*0x1846ebc*/ BannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, int x, int y);
            /*0x1847024*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x18470d4*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1847184*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x1847234*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x18472e4*/ void add_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x1847394*/ void remove_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x1847444*/ void add_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x18474f4*/ void remove_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x18475a4*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1847654*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1847704*/ void LoadAd(GoogleMobileAds.Api.AdRequest request);
            /*0x18477b0*/ void Hide();
            /*0x1847854*/ void Show();
            /*0x18478f8*/ void Destroy();
            /*0x184799c*/ float GetHeightInPixels();
            /*0x1847a40*/ float GetWidthInPixels();
            /*0x1847ae4*/ void SetPosition(GoogleMobileAds.Api.AdPosition adPosition);
            /*0x1847b90*/ void SetPosition(int x, int y);
            /*0x1846b28*/ void ConfigureBannerEvents();
            /*0x1847c4c*/ ResponseInfo GetResponseInfo();
            /*0x1847d30*/ void <ConfigureBannerEvents>m__0(object sender, System.EventArgs args);
            /*0x1847d50*/ void <ConfigureBannerEvents>m__1(object sender, GoogleMobileAds.Common.LoadAdErrorClientEventArgs args);
            /*0x1847e24*/ void <ConfigureBannerEvents>m__2(object sender, System.EventArgs args);
            /*0x1847e44*/ void <ConfigureBannerEvents>m__3(object sender, System.EventArgs args);
            /*0x1847e64*/ void <ConfigureBannerEvents>m__4(object sender, GoogleMobileAds.Api.AdValueEventArgs args);
        }

        class InitializationStatus
        {
            /*0x10*/ GoogleMobileAds.Common.IInitializationStatusClient client;

            /*0x1847e84*/ InitializationStatus(GoogleMobileAds.Common.IInitializationStatusClient client);
            /*0x1847eac*/ GoogleMobileAds.Api.AdapterStatus getAdapterStatusForClassName(string className);
            /*0x1847f54*/ System.Collections.Generic.Dictionary<string, GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap();
        }

        class InterstitialAd
        {
            /*0x10*/ GoogleMobileAds.Common.IInterstitialClient client;
            /*0x18*/ string adUnitId;
            /*0x20*/ bool isLoaded;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdOpening;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdClosed;
            /*0x48*/ System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> OnAdFailedToShow;
            /*0x50*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;
            /*0x58*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;

            /*0x1847ff8*/ InterstitialAd(string adUnitId);
            /*0x18485d0*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1848680*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1848730*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x18487e0*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x1848890*/ void add_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x1848940*/ void remove_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x18489f0*/ void add_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x1848aa0*/ void remove_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x1848b50*/ void add_OnAdFailedToShow(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x1848c00*/ void remove_OnAdFailedToShow(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x1848cb0*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1848d60*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1848e10*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1848ec0*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1848f70*/ void LoadAd(GoogleMobileAds.Api.AdRequest request);
            /*0x1849024*/ bool IsLoaded();
            /*0x184902c*/ void Show();
            /*0x18490d4*/ void Destroy();
            /*0x1849178*/ ResponseInfo GetResponseInfo();
            /*0x184925c*/ void <InterstitialAd>m__0(object sender, System.EventArgs args);
            /*0x1849284*/ void <InterstitialAd>m__1(object sender, GoogleMobileAds.Common.LoadAdErrorClientEventArgs args);
            /*0x1849358*/ void <InterstitialAd>m__2(object sender, System.EventArgs args);
            /*0x1849378*/ void <InterstitialAd>m__3(object sender, System.EventArgs args);
            /*0x1849398*/ void <InterstitialAd>m__4(object sender, GoogleMobileAds.Common.AdErrorClientEventArgs args);
            /*0x184946c*/ void <InterstitialAd>m__5(object sender, System.EventArgs args);
            /*0x184948c*/ void <InterstitialAd>m__6(object sender, GoogleMobileAds.Api.AdValueEventArgs args);
        }

        class LoadAdError : GoogleMobileAds.Api.AdError
        {
            /*0x18*/ GoogleMobileAds.Common.ILoadAdErrorClient client;

            /*0x1846738*/ LoadAdError(GoogleMobileAds.Common.ILoadAdErrorClient client);
            /*0x18494ac*/ ResponseInfo GetResponseInfo();
            /*0x184958c*/ string ToString();
        }

        class MobileAds
        {
            static /*0x0*/ GoogleMobileAds.IClientFactory clientFactory;
            static /*0x8*/ GoogleMobileAds.Api.MobileAds instance;
            /*0x10*/ GoogleMobileAds.Common.IMobileAdsClient client;

            static /*0x1849668*/ GoogleMobileAds.Api.MobileAds get_Instance();
            static /*0x18496e8*/ void Initialize(System.Action<GoogleMobileAds.Api.InitializationStatus> initCompleteAction);
            static /*0x1849840*/ void DisableMediationInitialization();
            static /*0x18498e0*/ void SetApplicationMuted(bool muted);
            static /*0x1849990*/ void SetRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
            static /*0x1849a40*/ GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration();
            static /*0x1849ae0*/ void SetApplicationVolume(float volume);
            static /*0x1849b90*/ void SetiOSAppPauseOnBackground(bool pause);
            static /*0x1849c40*/ void OpenAdInspector(System.Action<GoogleMobileAds.Api.AdInspectorError> adInspectorClosedAction);
            static /*0x1845f74*/ GoogleMobileAds.IClientFactory GetClientFactory();
            static /*0x18495cc*/ GoogleMobileAds.Common.IMobileAdsClient GetMobileAdsClient();
            /*0x18495ac*/ MobileAds();

            class Utils
            {
                static /*0x1849d70*/ float GetDeviceScale();
                static /*0x1849e10*/ int GetDeviceSafeWidth();
            }

            class <Initialize>c__AnonStorey0
            {
                /*0x10*/ System.Action<GoogleMobileAds.Api.InitializationStatus> initCompleteAction;

                /*0x1849838*/ <Initialize>c__AnonStorey0();
                /*0x1849eb0*/ void <>m__0(GoogleMobileAds.Common.IInitializationStatusClient initStatusClient);
            }

            class <OpenAdInspector>c__AnonStorey1
            {
                /*0x10*/ System.Action<GoogleMobileAds.Api.AdInspectorError> adInspectorClosedAction;

                /*0x1849d68*/ <OpenAdInspector>c__AnonStorey1();
                /*0x1849f38*/ void <>m__0(GoogleMobileAds.Common.AdInspectorErrorClientEventArgs args);
            }
        }
    }
}

class ResponseInfo
{
    /*0x10*/ GoogleMobileAds.Common.IResponseInfoClient client;

    /*0x1846334*/ ResponseInfo(GoogleMobileAds.Common.IResponseInfoClient client);
    /*0x1849fd8*/ string GetMediationAdapterClassName();
    /*0x184a078*/ string GetResponseId();
    /*0x184a11c*/ string ToString();
}

namespace GoogleMobileAds
{
    namespace Api
    {
        class RewardedAd
        {
            /*0x10*/ GoogleMobileAds.Common.IRewardedAdClient client;
            /*0x18*/ string adUnitId;
            /*0x20*/ bool isLoaded;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdOpening;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdClosed;
            /*0x48*/ System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> OnAdFailedToShow;
            /*0x50*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;
            /*0x58*/ System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward;
            /*0x60*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;

            /*0x184a13c*/ RewardedAd(string adUnitId);
            /*0x184a860*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x184a910*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x184a9c0*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x184aa70*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x184ab20*/ void add_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x184abd0*/ void remove_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x184ac80*/ void add_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x184ad30*/ void remove_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x184ade0*/ void add_OnAdFailedToShow(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x184ae90*/ void remove_OnAdFailedToShow(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x184af40*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x184aff0*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x184b0a0*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x184b150*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x184b200*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x184b2b0*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x184b360*/ void LoadAd(GoogleMobileAds.Api.AdRequest request);
            /*0x184b414*/ bool IsLoaded();
            /*0x184b41c*/ void Show();
            /*0x184b4c4*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x184b570*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x184b62c*/ void Destroy();
            /*0x184b6d0*/ ResponseInfo GetResponseInfo();
            /*0x184b7b4*/ void <RewardedAd>m__0(object sender, System.EventArgs args);
            /*0x184b7dc*/ void <RewardedAd>m__1(object sender, GoogleMobileAds.Common.LoadAdErrorClientEventArgs args);
            /*0x184b8b0*/ void <RewardedAd>m__2(object sender, GoogleMobileAds.Common.AdErrorClientEventArgs args);
            /*0x184b984*/ void <RewardedAd>m__3(object sender, System.EventArgs args);
            /*0x184b9a4*/ void <RewardedAd>m__4(object sender, System.EventArgs args);
            /*0x184b9c4*/ void <RewardedAd>m__5(object sender, GoogleMobileAds.Common.AdErrorClientEventArgs args);
            /*0x184ba98*/ void <RewardedAd>m__6(object sender, System.EventArgs args);
            /*0x184bab8*/ void <RewardedAd>m__7(object sender, GoogleMobileAds.Api.Reward args);
            /*0x184bad8*/ void <RewardedAd>m__8(object sender, GoogleMobileAds.Api.AdValueEventArgs args);
        }

        class RewardedInterstitialAd
        {
            static /*0x0*/ System.Collections.Generic.HashSet<GoogleMobileAds.Common.IRewardedInterstitialAdClient> loadingClients;
            /*0x10*/ GoogleMobileAds.Common.IRewardedInterstitialAdClient rewardedInterstitialAdClient;
            /*0x18*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x20*/ System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x30*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            static /*0x184cd88*/ RewardedInterstitialAd();
            static /*0x184c578*/ void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request, System.Action<GoogleMobileAds.Api.RewardedInterstitialAd, GoogleMobileAds.Api.AdFailedToLoadEventArgs> adLoadCallback);
            /*0x184baf8*/ RewardedInterstitialAd(GoogleMobileAds.Common.IRewardedInterstitialAdClient client);
            /*0x184be98*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x184bf48*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x184bff8*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x184c0a8*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x184c158*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x184c208*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x184c2b8*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x184c368*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x184c418*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x184c4c8*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x184c908*/ void Show(System.Action<GoogleMobileAds.Api.Reward> userEarnedRewardCallback);
            /*0x184cab0*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x184cb5c*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x184cc00*/ void Destroy();
            /*0x184cca4*/ ResponseInfo GetResponseInfo();
            /*0x184ce14*/ void <RewardedInterstitialAd>m__0(object sender, GoogleMobileAds.Common.AdErrorClientEventArgs args);
            /*0x184cee8*/ void <RewardedInterstitialAd>m__1(object sender, System.EventArgs args);
            /*0x184cf08*/ void <RewardedInterstitialAd>m__2(object sender, System.EventArgs args);
            /*0x184cf28*/ void <RewardedInterstitialAd>m__3(object sender, System.EventArgs args);
            /*0x184cf48*/ void <RewardedInterstitialAd>m__4(object sender, GoogleMobileAds.Api.AdValueEventArgs args);

            class <LoadAd>c__AnonStorey0
            {
                /*0x10*/ System.Action<GoogleMobileAds.Api.RewardedInterstitialAd, GoogleMobileAds.Api.AdFailedToLoadEventArgs> adLoadCallback;
                /*0x18*/ GoogleMobileAds.Common.IRewardedInterstitialAdClient client;

                /*0x184c900*/ <LoadAd>c__AnonStorey0();
                /*0x184cf68*/ void <>m__0(object sender, System.EventArgs args);
                /*0x184d03c*/ void <>m__1(object sender, GoogleMobileAds.Common.LoadAdErrorClientEventArgs args);
            }

            class <Show>c__AnonStorey1
            {
                /*0x10*/ System.Action<GoogleMobileAds.Api.Reward> userEarnedRewardCallback;

                /*0x184caa8*/ <Show>c__AnonStorey1();
                /*0x184d164*/ void <>m__0(object sender, GoogleMobileAds.Api.Reward args);
            }
        }
    }
}
