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

            /*0x2b318d8*/ AdErrorClientEventArgs();
            /*0x2b3193c*/ GoogleMobileAds.Common.IAdErrorClient get_AdErrorClient();
            /*0x2b31944*/ void set_AdErrorClient(GoogleMobileAds.Common.IAdErrorClient value);
        }

        class AdInspectorErrorClientEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Common.IAdInspectorErrorClient <AdErrorClient>k__BackingField;

            /*0x2b3194c*/ AdInspectorErrorClientEventArgs();
            /*0x2b319b0*/ void set_AdErrorClient(GoogleMobileAds.Common.IAdInspectorErrorClient value);
        }

        class AppStateEventClient : UnityEngine.MonoBehaviour, GoogleMobileAds.Common.IAppStateEventClient
        {
            static /*0x0*/ GoogleMobileAds.Common.AppStateEventClient instance;
            static /*0x8*/ System.Action<GoogleMobileAds.Common.AppState> <>f__am$cache0;
            /*0x18*/ System.Action<GoogleMobileAds.Common.AppState> AppStateChanged;

            static /*0x2b31a94*/ GoogleMobileAds.Common.AppStateEventClient get_Instance();
            static /*0x2b31d74*/ void <AppStateChanged>m__0(GoogleMobileAds.Common.AppState );
            /*0x2b319b8*/ AppStateEventClient();
            /*0x2b31bcc*/ void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x2b31c6c*/ void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x2b31d0c*/ void OnApplicationPause(bool isPaused);
        }

        interface IAdErrorClient
        {
        }

        interface IAdInspectorErrorClient : GoogleMobileAds.Common.IAdErrorClient
        {
        }

        interface IAppOpenAdClient
        {
        }

        enum AppState
        {
            Background = 0,
            Foreground = 1,
        }

        interface IAppStateEventClient
        {
        }

        interface IBannerClient
        {
        }
    }

    interface IClientFactory
    {
        GoogleMobileAds.Common.IRewardedAdClient BuildRewardedAdClient();
        GoogleMobileAds.Common.IMobileAdsClient MobileAdsInstance();
    }

    namespace Common
    {
        interface IInitializationStatusClient
        {
            System.Collections.Generic.Dictionary<string, GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap();
        }

        interface IInterstitialClient
        {
        }

        interface ILoadAdErrorClient : GoogleMobileAds.Common.IAdErrorClient
        {
        }

        interface IMobileAdsClient
        {
            void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction);
            void SetRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
        }

        interface IResponseInfoClient
        {
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
            void Show();
            void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            void DestroyRewardedAd();
        }

        interface IRewardedInterstitialAdClient
        {
        }

        class LoadAdErrorClientEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Common.ILoadAdErrorClient <LoadAdErrorClient>k__BackingField;

            /*0x2b31d78*/ LoadAdErrorClientEventArgs();
            /*0x2b31ddc*/ GoogleMobileAds.Common.ILoadAdErrorClient get_LoadAdErrorClient();
            /*0x2b31de4*/ void set_LoadAdErrorClient(GoogleMobileAds.Common.ILoadAdErrorClient value);
        }

        class MobileAdsEventExecutor : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ GoogleMobileAds.Common.MobileAdsEventExecutor instance;
            static /*0x8*/ System.Collections.Generic.List<System.Action> adEventsQueue;
            static /*0x10*/ bool adEventsQueueEmpty;

            static /*0x2b325a8*/ MobileAdsEventExecutor();
            static /*0x2b31df4*/ void Initialize();
            static /*0x2b31f30*/ bool IsActive();
            static /*0x2b32048*/ void ExecuteInUpdate(System.Action action);
            static /*0x2b32170*/ void InvokeInUpdate(UnityEngine.Events.UnityEvent eventParam);
            /*0x2b31dec*/ MobileAdsEventExecutor();
            /*0x2b31fd0*/ void Awake();
            /*0x2b32250*/ void Update();
            /*0x2b32544*/ void OnDisable();

            class <InvokeInUpdate>c__AnonStorey0
            {
                /*0x10*/ UnityEngine.Events.UnityEvent eventParam;

                /*0x2b32248*/ <InvokeInUpdate>c__AnonStorey0();
                /*0x2b32650*/ void <>m__0();
            }
        }

        enum ResponseInfoClientType
        {
            AdLoaded = 1,
            AdError = 2,
        }
    }
}
