class <Module>
{
}

namespace GoogleMobileAds
{
    namespace Common
    {
        class AdErrorClientEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Common.IAdErrorClient <AdErrorClient>k__BackingField;

            /*0x1891ff0*/ AdErrorClientEventArgs();
            /*0x1892048*/ GoogleMobileAds.Common.IAdErrorClient get_AdErrorClient();
            /*0x1892050*/ void set_AdErrorClient(GoogleMobileAds.Common.IAdErrorClient value);
        }

        class AdInspectorErrorClientEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Common.IAdInspectorErrorClient <AdErrorClient>k__BackingField;

            /*0x1892058*/ AdInspectorErrorClientEventArgs();
            /*0x18920b0*/ GoogleMobileAds.Common.IAdInspectorErrorClient get_AdErrorClient();
            /*0x18920b8*/ void set_AdErrorClient(GoogleMobileAds.Common.IAdInspectorErrorClient value);
        }

        class AppOpenAdAdDummyClient : GoogleMobileAds.Common.IAppOpenAdClient
        {
            /*0x10*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x18*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x20*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x28*/ System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x30*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            /*0x18920c0*/ AppOpenAdAdDummyClient();
            /*0x1892194*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1892244*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x18922f4*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x18923a4*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x1892454*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1892504*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x18925b4*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x1892664*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x1892714*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x18927c4*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1892874*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1892924*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x18929d4*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1892a84*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1892b34*/ void CreateAppOpenAd();
            /*0x1892bf8*/ void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request, UnityEngine.ScreenOrientation orientation);
            /*0x1892cbc*/ void Show();
            /*0x1892d80*/ void DestroyAppOpenAd();
            /*0x1892e44*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
        }

        class AppStateEventClient : UnityEngine.MonoBehaviour, GoogleMobileAds.Common.IAppStateEventClient
        {
            static /*0x0*/ GoogleMobileAds.Common.AppStateEventClient instance;
            static /*0x8*/ System.Action<GoogleMobileAds.Common.AppState> <>f__am$cache0;
            /*0x18*/ System.Action<GoogleMobileAds.Common.AppState> AppStateChanged;

            static /*0x1892fcc*/ GoogleMobileAds.Common.AppStateEventClient get_Instance();
            static /*0x189327c*/ void <AppStateChanged>m__0(GoogleMobileAds.Common.AppState );
            /*0x1892f10*/ AppStateEventClient();
            /*0x18930f0*/ void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x18931a0*/ void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x1893250*/ void OnApplicationPause(bool isPaused);
        }

        interface IAdErrorClient
        {
            int GetCode();
            string GetDomain();
            string GetMessage();
            GoogleMobileAds.Common.IAdErrorClient GetCause();
        }

        interface IAdInspectorErrorClient : GoogleMobileAds.Common.IAdErrorClient
        {
        }

        interface IAppOpenAdClient
        {
            void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void CreateAppOpenAd();
            void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request, UnityEngine.ScreenOrientation orientation);
            void Show();
            GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            void DestroyAppOpenAd();
        }

        enum AppState
        {
            Background = 0,
            Foreground = 1,
        }

        interface IAppStateEventClient
        {
            void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
        }

        interface IBannerClient
        {
            void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void add_OnAdOpening(System.EventHandler<System.EventArgs> value);
            void remove_OnAdOpening(System.EventHandler<System.EventArgs> value);
            void add_OnAdClosed(System.EventHandler<System.EventArgs> value);
            void remove_OnAdClosed(System.EventHandler<System.EventArgs> value);
            void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, GoogleMobileAds.Api.AdPosition position);
            void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, int x, int y);
            void LoadAd(GoogleMobileAds.Api.AdRequest request);
            void ShowBannerView();
            void HideBannerView();
            void DestroyBannerView();
            float GetHeightInPixels();
            float GetWidthInPixels();
            void SetPosition(GoogleMobileAds.Api.AdPosition adPosition);
            void SetPosition(int x, int y);
            GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
        }
    }

    interface IClientFactory
    {
        GoogleMobileAds.Common.IAppStateEventClient BuildAppStateEventClient();
        GoogleMobileAds.Common.IAppOpenAdClient BuildAppOpenAdClient();
        GoogleMobileAds.Common.IBannerClient BuildBannerClient();
        GoogleMobileAds.Common.IInterstitialClient BuildInterstitialClient();
        GoogleMobileAds.Common.IRewardedAdClient BuildRewardedAdClient();
        GoogleMobileAds.Common.IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient();
        GoogleMobileAds.Common.IMobileAdsClient MobileAdsInstance();
    }

    namespace Common
    {
        interface IInitializationStatusClient
        {
            GoogleMobileAds.Api.AdapterStatus getAdapterStatusForClassName(string className);
            System.Collections.Generic.Dictionary<string, GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap();
        }

        interface IInterstitialClient
        {
            void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void CreateInterstitialAd();
            void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request);
            void Show();
            GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            void DestroyInterstitial();
        }

        interface ILoadAdErrorClient : GoogleMobileAds.Common.IAdErrorClient
        {
            GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
        }

        interface IMobileAdsClient
        {
            void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction);
            void DisableMediationInitialization();
            void SetApplicationVolume(float volume);
            void SetApplicationMuted(bool muted);
            void SetiOSAppPauseOnBackground(bool pause);
            float GetDeviceScale();
            int GetDeviceSafeWidth();
            void SetRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
            GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration();
            void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction);
        }

        interface IResponseInfoClient
        {
            string GetMediationAdapterClassName();
            string GetResponseId();
        }

        interface IRewardedAdClient
        {
            void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void CreateRewardedAd();
            void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request);
            GoogleMobileAds.Api.Reward GetRewardItem();
            void Show();
            void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            void DestroyRewardedAd();
        }

        interface IRewardedInterstitialAdClient
        {
            void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            void CreateRewardedInterstitialAd();
            void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request);
            GoogleMobileAds.Api.Reward GetRewardItem();
            void Show();
            void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            void DestroyRewardedInterstitialAd();
        }

        class LoadAdErrorClientEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Common.ILoadAdErrorClient <LoadAdErrorClient>k__BackingField;

            /*0x1893280*/ LoadAdErrorClientEventArgs();
            /*0x18932d8*/ GoogleMobileAds.Common.ILoadAdErrorClient get_LoadAdErrorClient();
            /*0x18932e0*/ void set_LoadAdErrorClient(GoogleMobileAds.Common.ILoadAdErrorClient value);
        }

        class MobileAdsEventExecutor : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ GoogleMobileAds.Common.MobileAdsEventExecutor instance;
            static /*0x8*/ System.Collections.Generic.List<System.Action> adEventsQueue;
            static /*0x10*/ bool adEventsQueueEmpty;

            static /*0x1893ab0*/ MobileAdsEventExecutor();
            static /*0x18932f0*/ void Initialize();
            static /*0x1893418*/ bool IsActive();
            static /*0x1893510*/ void ExecuteInUpdate(System.Action action);
            static /*0x1893694*/ void InvokeInUpdate(UnityEngine.Events.UnityEvent eventParam);
            /*0x18932e8*/ MobileAdsEventExecutor();
            /*0x18934a4*/ void Awake();
            /*0x189376c*/ void Update();
            /*0x1893a58*/ void OnDisable();

            class <InvokeInUpdate>c__AnonStorey0
            {
                /*0x10*/ UnityEngine.Events.UnityEvent eventParam;

                /*0x1893764*/ <InvokeInUpdate>c__AnonStorey0();
                /*0x1893b5c*/ void <>m__0();
            }
        }

        enum ResponseInfoClientType
        {
            AdLoaded = 1,
            AdError = 2,
        }

        class RewardedAdDummyClient : GoogleMobileAds.Common.IRewardedAdClient
        {
            /*0x10*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x18*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x20*/ System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward;
            /*0x28*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x48*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            /*0x1893b78*/ RewardedAdDummyClient();
            /*0x1893c4c*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1893cfc*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1893dac*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x1893e5c*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x1893f0c*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x1893fbc*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x189406c*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x189411c*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x18941cc*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x189427c*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x189432c*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x18943dc*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x189448c*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x189453c*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x18945ec*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x189469c*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x189474c*/ void CreateRewardedAd();
            /*0x1894810*/ void LoadAd(string adUnitId, GoogleMobileAds.Api.AdRequest request);
            /*0x1894930*/ void Show();
            /*0x18949f4*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x1894ac0*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x1894b84*/ void DestroyRewardedAd();
            /*0x1894c48*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
        }

        class RewardedInterstitialAdDummyClient : GoogleMobileAds.Common.IRewardedInterstitialAdClient
        {
            /*0x10*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x18*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x20*/ System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward;
            /*0x28*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x48*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            /*0x1894d14*/ RewardedInterstitialAdDummyClient();
            /*0x1894de8*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1894e98*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1894f48*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x1894ff8*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x18950a8*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x1895158*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x1895208*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x18952b8*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1895368*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x1895418*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x18954c8*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1895578*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1895628*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x18956d8*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1895788*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1895838*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x18958e8*/ void CreateRewardedInterstitialAd();
            /*0x18959ac*/ void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request);
            /*0x1895a70*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x1895b3c*/ void Show();
            /*0x1895c00*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x1895cc4*/ void DestroyRewardedInterstitialAd();
            /*0x1895d88*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
        }

        class Utils
        {
            static /*0x1895e5c*/ void CheckInitialization();
            static /*0x1895f04*/ UnityEngine.Texture2D GetTexture2DFromByteArray(byte[] img);
            /*0x1895e54*/ Utils();
        }
    }
}
