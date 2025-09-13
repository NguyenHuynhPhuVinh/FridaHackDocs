class <Module>
{
}

namespace GoogleMobileAds
{
    namespace Android
    {
        class AdErrorClient : GoogleMobileAds.Common.IAdErrorClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject error;

            /*0x2a4d138*/ AdErrorClient(UnityEngine.AndroidJavaObject error);
            /*0x2a4d164*/ int GetCode();
            /*0x2a4d1f8*/ string GetDomain();
            /*0x2a4d28c*/ string GetMessage();
            /*0x2a4d320*/ GoogleMobileAds.Common.IAdErrorClient GetCause();
            /*0x2a4d3f0*/ string ToString();
        }

        class AdInspectorErrorClient : GoogleMobileAds.Android.AdErrorClient, GoogleMobileAds.Common.IAdInspectorErrorClient, GoogleMobileAds.Common.IAdErrorClient
        {
            /*0x2a4d484*/ AdInspectorErrorClient(UnityEngine.AndroidJavaObject error);
        }

        class AdInspectorListener : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction;

            /*0x2a4d4b0*/ AdInspectorListener(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction);
            /*0x2a4d540*/ void onAdInspectorClosed(UnityEngine.AndroidJavaObject error);
        }

        class AppOpenAdClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IAppOpenAdClient
        {
            /*0x20*/ UnityEngine.AndroidJavaObject androidAppOpenAd;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x40*/ System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x48*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x50*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x58*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            /*0x2a4d620*/ AppOpenAdClient();
            /*0x2a4d804*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a4d8a4*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a4d944*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a4d9e4*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a4da84*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a4db24*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a4dbc4*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a4dc64*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a4dd04*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a4dda4*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a4de44*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a4dee4*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a4df84*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a4e024*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a4e0c4*/ void CreateAppOpenAd();
            /*0x2a4e0c8*/ void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request, UnityEngine.ScreenOrientation orientation);
            /*0x2a4f11c*/ void Show();
            /*0x2a4f19c*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x2a4f2ac*/ void DestroyAppOpenAd();
            /*0x2a4f32c*/ void onAppOpenAdLoaded();
            /*0x2a4f3d4*/ void onAppOpenAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x2a4f4dc*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x2a4f5b8*/ void onAdShowedFullScreenContent();
            /*0x2a4f660*/ void onAdDismissedFullScreenContent();
            /*0x2a4f708*/ void onAdImpression();
            /*0x2a4f7b0*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class AppStateEventClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IAppStateEventClient
        {
            /*0x20*/ System.Action<GoogleMobileAds.Common.AppState> appStateChanged;
            /*0x28*/ UnityEngine.AndroidJavaObject appStateEventNotifer;

            /*0x2a4f8a8*/ AppStateEventClient();
            /*0x2a4fa8c*/ void add_appStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x2a4fb2c*/ void remove_appStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x2a4fbcc*/ void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x2a4fc80*/ void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x2a4fd30*/ void onAppStateChanged(bool isBackground);
        }

        class BannerClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IBannerClient
        {
            /*0x20*/ UnityEngine.AndroidJavaObject bannerView;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdOpening;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdClosed;
            /*0x48*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;

            /*0x2a4fda4*/ BannerClient();
            /*0x2a4ff88*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a50028*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a500c8*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a50168*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a50208*/ void add_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x2a502a8*/ void remove_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x2a50348*/ void add_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x2a503e8*/ void remove_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x2a50488*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a50528*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a505c8*/ void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, GoogleMobileAds.Api.AdPosition position);
            /*0x2a50c30*/ void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, int x, int y);
            /*0x2a50de0*/ void LoadAd(GoogleMobileAds.Api.AdRequest request);
            /*0x2a50ec0*/ void ShowBannerView();
            /*0x2a50f40*/ void HideBannerView();
            /*0x2a50fc0*/ void DestroyBannerView();
            /*0x2a51040*/ float GetHeightInPixels();
            /*0x2a510d4*/ float GetWidthInPixels();
            /*0x2a51168*/ void SetPosition(GoogleMobileAds.Api.AdPosition adPosition);
            /*0x2a51264*/ void SetPosition(int x, int y);
            /*0x2a513a8*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x2a51408*/ void onAdLoaded();
            /*0x2a514b0*/ void onAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x2a5158c*/ void onAdOpened();
            /*0x2a51634*/ void onAdClosed();
            /*0x2a516dc*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class DisplayMetrics
        {
            /*0x10*/ float <Density>k__BackingField;
            /*0x14*/ int <HeightPixels>k__BackingField;
            /*0x18*/ int <WidthPixels>k__BackingField;

            /*0x2a517d4*/ DisplayMetrics();
            /*0x2a52064*/ float get_Density();
            /*0x2a5206c*/ void set_Density(float value);
            /*0x2a52074*/ int get_HeightPixels();
            /*0x2a5207c*/ void set_HeightPixels(int value);
            /*0x2a52084*/ int get_WidthPixels();
            /*0x2a5208c*/ void set_WidthPixels(int value);
        }
    }

    class GoogleMobileAdsClientFactory : GoogleMobileAds.IClientFactory
    {
        /*0x2a52094*/ GoogleMobileAdsClientFactory();
        /*0x2a5209c*/ GoogleMobileAds.Common.IAppStateEventClient BuildAppStateEventClient();
        /*0x2a521a0*/ GoogleMobileAds.Common.IAppOpenAdClient BuildAppOpenAdClient();
        /*0x2a522a4*/ GoogleMobileAds.Common.IBannerClient BuildBannerClient();
        /*0x2a523a8*/ GoogleMobileAds.Common.IInterstitialClient BuildInterstitialClient();
        /*0x2a52690*/ GoogleMobileAds.Common.IRewardedAdClient BuildRewardedAdClient();
        /*0x2a52978*/ GoogleMobileAds.Common.IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient();
        /*0x2a52c60*/ GoogleMobileAds.Common.IMobileAdsClient MobileAdsInstance();
    }

    namespace Android
    {
        class InitializationStatusClient : GoogleMobileAds.Common.IInitializationStatusClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject status;
            /*0x18*/ UnityEngine.AndroidJavaObject statusMap;

            /*0x2a52dac*/ InitializationStatusClient(UnityEngine.AndroidJavaObject status);
            /*0x2a52e60*/ GoogleMobileAds.Api.AdapterStatus getAdapterStatusForClassName(string className);
            /*0x2a53170*/ System.Collections.Generic.Dictionary<string, GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap();
            /*0x2a53284*/ string[] getKeys();
        }

        class InterstitialClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IInterstitialClient
        {
            /*0x20*/ UnityEngine.AndroidJavaObject androidInterstitialAd;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x48*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x50*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;
            /*0x58*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;

            /*0x2a524ac*/ InterstitialClient();
            /*0x2a53558*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a535f8*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a53698*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a53738*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a537d8*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a53878*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a53918*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a539b8*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a53a58*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a53af8*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a53b98*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a53c38*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a53cd8*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a53d78*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a53e18*/ void CreateInterstitialAd();
            /*0x2a53e1c*/ void LoadAd(string adUnitId, GoogleMobileAds.Api.AdRequest request);
            /*0x2a53f28*/ void Show();
            /*0x2a53fa8*/ void DestroyInterstitial();
            /*0x2a54028*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x2a54088*/ void onInterstitialAdLoaded();
            /*0x2a54130*/ void onInterstitialAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x2a5420c*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x2a542e8*/ void onAdShowedFullScreenContent();
            /*0x2a54390*/ void onAdDismissedFullScreenContent();
            /*0x2a54438*/ void onAdImpression();
            /*0x2a544e0*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class LoadAdErrorClient : GoogleMobileAds.Common.ILoadAdErrorClient, GoogleMobileAds.Common.IAdErrorClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject loadAdError;

            /*0x2a4f4b0*/ LoadAdErrorClient(UnityEngine.AndroidJavaObject loadAdError);
            /*0x2a545d8*/ int GetCode();
            /*0x2a5466c*/ string GetDomain();
            /*0x2a54700*/ string GetMessage();
            /*0x2a54794*/ GoogleMobileAds.Common.IAdErrorClient GetCause();
            /*0x2a54864*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x2a548c4*/ string ToString();
        }

        class MobileAdsClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IMobileAdsClient
        {
            static /*0x0*/ GoogleMobileAds.Android.MobileAdsClient instance;
            /*0x20*/ System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction;

            static /*0x2a55eb8*/ MobileAdsClient();
            static /*0x2a549d4*/ GoogleMobileAds.Android.MobileAdsClient get_Instance();
            /*0x2a54958*/ MobileAdsClient();
            /*0x2a54a38*/ void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction);
            /*0x2a54bdc*/ void SetApplicationVolume(float volume);
            /*0x2a54d20*/ void DisableMediationInitialization();
            /*0x2a54e94*/ void SetApplicationMuted(bool muted);
            /*0x2a54fc8*/ void SetRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
            /*0x2a556f4*/ GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration();
            /*0x2a55a30*/ void SetiOSAppPauseOnBackground(bool pause);
            /*0x2a55a34*/ void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed);
            /*0x2a55bfc*/ float GetDeviceScale();
            /*0x2a55d8c*/ int GetDeviceSafeWidth();
            /*0x2a55e14*/ void onInitializationComplete(UnityEngine.AndroidJavaObject initStatus);
        }

        class RequestConfigurationClient
        {
            static /*0x2a550e0*/ UnityEngine.AndroidJavaObject BuildRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
            static /*0x2a557c4*/ GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration(UnityEngine.AndroidJavaObject androidRequestConfiguration);
            /*0x2a55f14*/ RequestConfigurationClient();
        }

        class ResponseInfoClient : GoogleMobileAds.Common.IResponseInfoClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject androidResponseInfo;

            /*0x2a4f1fc*/ ResponseInfoClient(GoogleMobileAds.Common.ResponseInfoClientType type, UnityEngine.AndroidJavaObject androidJavaObject);
            /*0x2a56358*/ string GetMediationAdapterClassName();
            /*0x2a563f4*/ string GetResponseId();
            /*0x2a56490*/ string ToString();
        }

        class RewardedAdClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IRewardedAdClient
        {
            /*0x20*/ UnityEngine.AndroidJavaObject androidRewardedAd;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward;
            /*0x40*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x48*/ System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x50*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x58*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x60*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            /*0x2a52794*/ RewardedAdClient();
            /*0x2a56524*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a565c4*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a56664*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a56704*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a567a4*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x2a56844*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x2a568e4*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a56984*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a56a24*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a56ac4*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a56b64*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a56c04*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a56ca4*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a56d44*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a56de4*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a56e84*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a56f24*/ void CreateRewardedAd();
            /*0x2a56f28*/ void LoadAd(string adUnitId, GoogleMobileAds.Api.AdRequest request);
            /*0x2a57034*/ void Show();
            /*0x2a570b4*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x2a5736c*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x2a574f0*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x2a57550*/ void DestroyRewardedAd();
            /*0x2a575d0*/ void onRewardedAdLoaded();
            /*0x2a57678*/ void onRewardedAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x2a57754*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x2a57830*/ void onAdShowedFullScreenContent();
            /*0x2a578d8*/ void onAdDismissedFullScreenContent();
            /*0x2a57980*/ void onAdImpression();
            /*0x2a57a28*/ void onUserEarnedReward(string type, float amount);
            /*0x2a57af0*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class RewardedInterstitialAdClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IRewardedInterstitialAdClient
        {
            /*0x20*/ UnityEngine.AndroidJavaObject androidRewardedInterstitialAd;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward;
            /*0x40*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;
            /*0x48*/ System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;
            /*0x50*/ System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent;
            /*0x58*/ System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent;
            /*0x60*/ System.EventHandler<System.EventArgs> OnAdDidRecordImpression;

            /*0x2a52a7c*/ RewardedInterstitialAdClient();
            /*0x2a57be8*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a57c88*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2a57d28*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a57dc8*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x2a57e68*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x2a57f08*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x2a57fa8*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a58048*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x2a580e8*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a58188*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x2a58228*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a582c8*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a58368*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a58408*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x2a584a8*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a58548*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x2a585e8*/ void CreateRewardedInterstitialAd();
            /*0x2a585ec*/ void LoadAd(string adUnitId, GoogleMobileAds.Api.AdRequest request);
            /*0x2a586f8*/ void Show();
            /*0x2a58778*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x2a588fc*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x2a589d8*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x2a58a38*/ void DestroyRewardedInterstitialAd();
            /*0x2a58ab8*/ void onRewardedInterstitialAdLoaded();
            /*0x2a58b60*/ void onRewardedInterstitialAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x2a58c3c*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x2a58d18*/ void onAdShowedFullScreenContent();
            /*0x2a58dc0*/ void onAdDismissedFullScreenContent();
            /*0x2a58e68*/ void onAdImpression();
            /*0x2a58f10*/ void onUserEarnedReward(string type, float amount);
            /*0x2a58fd8*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class Utils
        {
            static string AdMobAdapterClassName = "com.google.ads.mediation.admob.AdMobAdapter";
            static string AdListenerClassName = "com.google.android.gms.ads.AdListener";
            static string AdRequestClassName = "com.google.android.gms.ads.AdRequest";
            static string AdRequestBuilderClassName = "com.google.android.gms.ads.AdRequest$Builder";
            static string AdSizeClassName = "com.google.android.gms.ads.AdSize";
            static string AppOpenAdClassName = "com.google.android.gms.ads.appopen.AppOpenAd";
            static string PlayStorePurchaseListenerClassName = "com.google.android.gms.ads.purchase.PlayStorePurchaseListener";
            static string MobileAdsClassName = "com.google.android.gms.ads.MobileAds";
            static string RequestConfigurationClassName = "com.google.android.gms.ads.RequestConfiguration";
            static string RequestConfigurationBuilderClassName = "com.google.android.gms.ads.RequestConfiguration$Builder";
            static string ServerSideVerificationOptionsClassName = "com.google.android.gms.ads.rewarded.ServerSideVerificationOptions";
            static string ServerSideVerificationOptionsBuilderClassName = "com.google.android.gms.ads.rewarded.ServerSideVerificationOptions$Builder";
            static string UnityAdSizeClassName = "com.google.unity.ads.UnityAdSize";
            static string BannerViewClassName = "com.google.unity.ads.Banner";
            static string InterstitialClassName = "com.google.unity.ads.Interstitial";
            static string RewardBasedVideoClassName = "com.google.unity.ads.RewardBasedVideo";
            static string UnityRewardedAdClassName = "com.google.unity.ads.UnityRewardedAd";
            static string UnityAdListenerClassName = "com.google.unity.ads.UnityAdListener";
            static string UnityAppStateEventNotifierClassName = "com.google.unity.ads.UnityAppStateEventNotifier";
            static string UnityAppStateEventCallbackClassName = "com.google.unity.ads.UnityAppStateEventCallback";
            static string UnityRewardedAdCallbackClassName = "com.google.unity.ads.UnityRewardedAdCallback";
            static string UnityInterstitialAdCallbackClassName = "com.google.unity.ads.UnityInterstitialAdCallback";
            static string UnityFullScreenContentCallbackClassName = "com.google.unity.ads.UnityFullScreenContentCallback";
            static string UnityAdapterStatusEnumName = "com.google.android.gms.ads.initialization.AdapterStatus$State";
            static string UnityAppOpenAdClassName = "com.google.unity.ads.UnityAppOpenAd";
            static string UnityAppOpenAdCallbackClassName = "com.google.unity.ads.UnityAppOpenAdCallback";
            static string OnInitializationCompleteListenerClassName = "com.google.android.gms.ads.initialization.OnInitializationCompleteListener";
            static string UnityAdLoaderListenerClassName = "com.google.unity.ads.UnityAdLoaderListener";
            static string UnityAdInspectorClassName = "com.google.unity.ads.UnityAdInspector";
            static string UnityAdInspectorListenerClassname = "com.google.unity.ads.UnityAdInspectorListener";
            static string UnityPaidEventListenerClassName = "com.google.unity.ads.UnityPaidEventListener";
            static string UnityRewardedInterstitialAdClassName = "com.google.unity.ads.UnityRewardedInterstitialAd";
            static string UnityRewardedInterstitialAdCallbackClassName = "com.google.unity.ads.UnityRewardedInterstitialAdCallback";
            static string PluginUtilsClassName = "com.google.unity.ads.PluginUtils";
            static string UnityActivityClassName = "com.unity3d.player.UnityPlayer";
            static string BundleClassName = "android.os.Bundle";
            static string DateClassName = "java.util.Date";
            static string DisplayMetricsClassName = "android.util.DisplayMetrics";

            static /*0x2a50730*/ UnityEngine.AndroidJavaObject GetAdSizeJavaObject(GoogleMobileAds.Api.AdSize adSize);
            static /*0x2a4f044*/ int GetAppOpenAdOrientation(UnityEngine.ScreenOrientation orientation);
            static /*0x2a55d90*/ int GetScreenWidth();
            static /*0x2a4e240*/ UnityEngine.AndroidJavaObject GetAdRequestJavaObject(GoogleMobileAds.Api.AdRequest request, string nativePluginVersion);
            static /*0x2a55f1c*/ UnityEngine.AndroidJavaObject GetJavaListObject(System.Collections.Generic.List<string> csTypeList);
            static /*0x2a5615c*/ System.Collections.Generic.List<string> GetCsTypeList(UnityEngine.AndroidJavaObject javaTypeList);
            static /*0x2a57190*/ UnityEngine.AndroidJavaObject GetServerSideVerificationOptionsJavaObject(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x2a590d0*/ Utils();
        }
    }
}
