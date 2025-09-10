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

            /*0x1297d74*/ AdErrorClient(UnityEngine.AndroidJavaObject error);
            /*0x1297d9c*/ int GetCode();
            /*0x1297e2c*/ string GetDomain();
            /*0x1297ebc*/ string GetMessage();
            /*0x1297f4c*/ GoogleMobileAds.Common.IAdErrorClient GetCause();
            /*0x129801c*/ string ToString();
        }

        class AdInspectorErrorClient : GoogleMobileAds.Android.AdErrorClient, GoogleMobileAds.Common.IAdInspectorErrorClient, GoogleMobileAds.Common.IAdErrorClient
        {
            /*0x12980ac*/ AdInspectorErrorClient(UnityEngine.AndroidJavaObject error);
        }

        class AdInspectorListener : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction;

            /*0x12980d4*/ AdInspectorListener(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction);
            /*0x1298158*/ void onAdInspectorClosed(UnityEngine.AndroidJavaObject error);
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

            /*0x129822c*/ AppOpenAdClient();
            /*0x1298400*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x12984b0*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x1298560*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x1298610*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x12986c0*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1298770*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x1298820*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x12988d0*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x1298980*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1298a30*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1298ae0*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1298b90*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x1298c40*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1298cf0*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x1298da0*/ void CreateAppOpenAd();
            /*0x1298da4*/ void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request, UnityEngine.ScreenOrientation orientation);
            /*0x1299d9c*/ void Show();
            /*0x1299e18*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x1299f28*/ void DestroyAppOpenAd();
            /*0x1299fa4*/ void onAppOpenAdLoaded();
            /*0x129a024*/ void onAppOpenAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x129a11c*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x129a1ec*/ void onAdShowedFullScreenContent();
            /*0x129a26c*/ void onAdDismissedFullScreenContent();
            /*0x129a2ec*/ void onAdImpression();
            /*0x129a36c*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class AppStateEventClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IAppStateEventClient
        {
            /*0x20*/ System.Action<GoogleMobileAds.Common.AppState> appStateChanged;
            /*0x28*/ UnityEngine.AndroidJavaObject appStateEventNotifer;

            /*0x129a454*/ AppStateEventClient();
            /*0x129a628*/ void add_appStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x129a6d8*/ void remove_appStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x129a788*/ void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x129a82c*/ void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value);
            /*0x129a8cc*/ void onAppStateChanged(bool isBackground);
        }

        class BannerClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IBannerClient
        {
            /*0x20*/ UnityEngine.AndroidJavaObject bannerView;
            /*0x28*/ System.EventHandler<System.EventArgs> OnAdLoaded;
            /*0x30*/ System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad;
            /*0x38*/ System.EventHandler<System.EventArgs> OnAdOpening;
            /*0x40*/ System.EventHandler<System.EventArgs> OnAdClosed;
            /*0x48*/ System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> OnPaidEvent;

            /*0x129a8f0*/ BannerClient();
            /*0x129aac4*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x129ab74*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x129ac24*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x129acd4*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x129ad84*/ void add_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x129ae34*/ void remove_OnAdOpening(System.EventHandler<System.EventArgs> value);
            /*0x129aee4*/ void add_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x129af94*/ void remove_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x129b044*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x129b0f4*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x129b1a4*/ void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, GoogleMobileAds.Api.AdPosition position);
            /*0x129b7cc*/ void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, int x, int y);
            /*0x129b970*/ void LoadAd(GoogleMobileAds.Api.AdRequest request);
            /*0x129ba44*/ void ShowBannerView();
            /*0x129bac0*/ void HideBannerView();
            /*0x129bb3c*/ void DestroyBannerView();
            /*0x129bbb8*/ float GetHeightInPixels();
            /*0x129bc48*/ float GetWidthInPixels();
            /*0x129bcd8*/ void SetPosition(GoogleMobileAds.Api.AdPosition adPosition);
            /*0x129bdd0*/ void SetPosition(int x, int y);
            /*0x129bf08*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x129bf6c*/ void onAdLoaded();
            /*0x129bfec*/ void onAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x129c0bc*/ void onAdOpened();
            /*0x129c13c*/ void onAdClosed();
            /*0x129c1bc*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class DisplayMetrics
        {
            /*0x10*/ float <Density>k__BackingField;
            /*0x14*/ int <HeightPixels>k__BackingField;
            /*0x18*/ int <WidthPixels>k__BackingField;

            /*0x129c2a4*/ DisplayMetrics();
            /*0x129cc44*/ float get_Density();
            /*0x129cc4c*/ void set_Density(float value);
            /*0x129cc54*/ int get_HeightPixels();
            /*0x129cc5c*/ void set_HeightPixels(int value);
            /*0x129cc64*/ int get_WidthPixels();
            /*0x129cc6c*/ void set_WidthPixels(int value);
        }
    }

    class GoogleMobileAdsClientFactory : GoogleMobileAds.IClientFactory
    {
        /*0x129cc74*/ GoogleMobileAdsClientFactory();
        /*0x129cc7c*/ GoogleMobileAds.Common.IAppStateEventClient BuildAppStateEventClient();
        /*0x129cd84*/ GoogleMobileAds.Common.IAppOpenAdClient BuildAppOpenAdClient();
        /*0x129ce8c*/ GoogleMobileAds.Common.IBannerClient BuildBannerClient();
        /*0x129cf94*/ GoogleMobileAds.Common.IInterstitialClient BuildInterstitialClient();
        /*0x129d270*/ GoogleMobileAds.Common.IRewardedAdClient BuildRewardedAdClient();
        /*0x129d54c*/ GoogleMobileAds.Common.IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient();
        /*0x129d828*/ GoogleMobileAds.Common.IMobileAdsClient MobileAdsInstance();
    }

    namespace Android
    {
        class InitializationStatusClient : GoogleMobileAds.Common.IInitializationStatusClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject status;
            /*0x18*/ UnityEngine.AndroidJavaObject statusMap;

            /*0x129d960*/ InitializationStatusClient(UnityEngine.AndroidJavaObject status);
            /*0x129da10*/ GoogleMobileAds.Api.AdapterStatus getAdapterStatusForClassName(string className);
            /*0x129dd20*/ System.Collections.Generic.Dictionary<string, GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap();
            /*0x129de20*/ string[] getKeys();
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

            /*0x129d09c*/ InterstitialClient();
            /*0x129e0e8*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x129e198*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x129e248*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x129e2f8*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x129e3a8*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x129e458*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x129e508*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x129e5b8*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x129e668*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x129e718*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x129e7c8*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x129e878*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x129e928*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x129e9d8*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x129ea88*/ void CreateInterstitialAd();
            /*0x129ea8c*/ void LoadAd(string adUnitId, GoogleMobileAds.Api.AdRequest request);
            /*0x129eb8c*/ void Show();
            /*0x129ec08*/ void DestroyInterstitial();
            /*0x129ec84*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x129ece8*/ void onInterstitialAdLoaded();
            /*0x129ed68*/ void onInterstitialAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x129ee38*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x129ef08*/ void onAdShowedFullScreenContent();
            /*0x129ef88*/ void onAdDismissedFullScreenContent();
            /*0x129f008*/ void onAdImpression();
            /*0x129f088*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
        }

        class LoadAdErrorClient : GoogleMobileAds.Common.ILoadAdErrorClient, GoogleMobileAds.Common.IAdErrorClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject loadAdError;

            /*0x129a0f4*/ LoadAdErrorClient(UnityEngine.AndroidJavaObject loadAdError);
            /*0x129f170*/ int GetCode();
            /*0x129f200*/ string GetDomain();
            /*0x129f290*/ string GetMessage();
            /*0x129f320*/ GoogleMobileAds.Common.IAdErrorClient GetCause();
            /*0x129f3f0*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x129f454*/ string ToString();
        }

        class MobileAdsClient : UnityEngine.AndroidJavaProxy, GoogleMobileAds.Common.IMobileAdsClient
        {
            static /*0x0*/ GoogleMobileAds.Android.MobileAdsClient instance;
            /*0x20*/ System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction;

            static /*0x12a0960*/ MobileAdsClient();
            static /*0x129f554*/ GoogleMobileAds.Android.MobileAdsClient get_Instance();
            /*0x129f4e4*/ MobileAdsClient();
            /*0x129f5ac*/ void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction);
            /*0x129f744*/ void SetApplicationVolume(float volume);
            /*0x129f86c*/ void DisableMediationInitialization();
            /*0x129f9d4*/ void SetApplicationMuted(bool muted);
            /*0x129fb00*/ void SetRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
            /*0x12a01bc*/ GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration();
            /*0x12a0508*/ void SetiOSAppPauseOnBackground(bool pause);
            /*0x12a050c*/ void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed);
            /*0x12a06c8*/ float GetDeviceScale();
            /*0x12a0854*/ int GetDeviceSafeWidth();
            /*0x12a08d4*/ void onInitializationComplete(UnityEngine.AndroidJavaObject initStatus);
        }

        class RequestConfigurationClient
        {
            static /*0x129fc04*/ UnityEngine.AndroidJavaObject BuildRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
            static /*0x12a0290*/ GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration(UnityEngine.AndroidJavaObject androidRequestConfiguration);
            /*0x12a09c0*/ RequestConfigurationClient();
        }

        class ResponseInfoClient : GoogleMobileAds.Common.IResponseInfoClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject androidResponseInfo;

            /*0x1299e7c*/ ResponseInfoClient(GoogleMobileAds.Common.ResponseInfoClientType type, UnityEngine.AndroidJavaObject androidJavaObject);
            /*0x12a0e50*/ string GetMediationAdapterClassName();
            /*0x12a0eec*/ string GetResponseId();
            /*0x12a0f88*/ string ToString();
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

            /*0x129d378*/ RewardedAdClient();
            /*0x12a1018*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x12a10c8*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x12a1178*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x12a1228*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x12a12d8*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x12a1388*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x12a1438*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x12a14e8*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x12a1598*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x12a1648*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x12a16f8*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a17a8*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a1858*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a1908*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a19b8*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x12a1a68*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x12a1b18*/ void CreateRewardedAd();
            /*0x12a1b1c*/ void LoadAd(string adUnitId, GoogleMobileAds.Api.AdRequest request);
            /*0x12a1c1c*/ void Show();
            /*0x12a1c98*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x12a1f38*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x12a20c0*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x12a2124*/ void DestroyRewardedAd();
            /*0x12a21a0*/ void onRewardedAdLoaded();
            /*0x12a2220*/ void onRewardedAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x12a22f0*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x12a23c0*/ void onAdShowedFullScreenContent();
            /*0x12a2440*/ void onAdDismissedFullScreenContent();
            /*0x12a24c0*/ void onAdImpression();
            /*0x12a2540*/ void onUserEarnedReward(string type, float amount);
            /*0x12a25ec*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
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

            /*0x129d654*/ RewardedInterstitialAdClient();
            /*0x12a26d4*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x12a2784*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x12a2834*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x12a28e4*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value);
            /*0x12a2994*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x12a2a44*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x12a2af4*/ void add_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x12a2ba4*/ void remove_OnPaidEvent(System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs> value);
            /*0x12a2c54*/ void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x12a2d04*/ void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value);
            /*0x12a2db4*/ void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a2e64*/ void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a2f14*/ void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a2fc4*/ void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value);
            /*0x12a3074*/ void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x12a3124*/ void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value);
            /*0x12a31d4*/ void CreateRewardedInterstitialAd();
            /*0x12a31d8*/ void LoadAd(string adUnitId, GoogleMobileAds.Api.AdRequest request);
            /*0x12a32d8*/ void Show();
            /*0x12a3354*/ GoogleMobileAds.Api.Reward GetRewardItem();
            /*0x12a34dc*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x12a35ac*/ GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient();
            /*0x12a3610*/ void DestroyRewardedInterstitialAd();
            /*0x12a368c*/ void onRewardedInterstitialAdLoaded();
            /*0x12a370c*/ void onRewardedInterstitialAdFailedToLoad(UnityEngine.AndroidJavaObject error);
            /*0x12a37dc*/ void onAdFailedToShowFullScreenContent(UnityEngine.AndroidJavaObject error);
            /*0x12a38ac*/ void onAdShowedFullScreenContent();
            /*0x12a392c*/ void onAdDismissedFullScreenContent();
            /*0x12a39ac*/ void onAdImpression();
            /*0x12a3a2c*/ void onUserEarnedReward(string type, float amount);
            /*0x12a3ad8*/ void onPaidEvent(int precision, long valueInMicros, string currencyCode);
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

            static /*0x129b300*/ UnityEngine.AndroidJavaObject GetAdSizeJavaObject(GoogleMobileAds.Api.AdSize adSize);
            static /*0x1299cc4*/ int GetAppOpenAdOrientation(UnityEngine.ScreenOrientation orientation);
            static /*0x12a0858*/ int GetScreenWidth();
            static /*0x1298f10*/ UnityEngine.AndroidJavaObject GetAdRequestJavaObject(GoogleMobileAds.Api.AdRequest request, string nativePluginVersion);
            static /*0x12a09c8*/ UnityEngine.AndroidJavaObject GetJavaListObject(System.Collections.Generic.List<string> csTypeList);
            static /*0x12a0c20*/ System.Collections.Generic.List<string> GetCsTypeList(UnityEngine.AndroidJavaObject javaTypeList);
            static /*0x12a1d68*/ UnityEngine.AndroidJavaObject GetServerSideVerificationOptionsJavaObject(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x12a3bc0*/ Utils();
        }
    }
}
