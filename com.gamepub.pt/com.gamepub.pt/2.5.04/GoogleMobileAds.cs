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

            /*0x2b22c6c*/ AdError(GoogleMobileAds.Common.IAdErrorClient client);
            /*0x2b22c98*/ string ToString();
        }

        class AdErrorEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Api.AdError <AdError>k__BackingField;
            /*0x18*/ string <Message>k__BackingField;

            /*0x2b22cb8*/ AdErrorEventArgs();
            /*0x2b22d1c*/ void set_AdError(GoogleMobileAds.Api.AdError value);
        }

        class AdFailedToLoadEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Api.LoadAdError <LoadAdError>k__BackingField;

            /*0x2b22d24*/ AdFailedToLoadEventArgs();
            /*0x2b22d88*/ void set_LoadAdError(GoogleMobileAds.Api.LoadAdError value);
        }

        class InitializationStatus
        {
            /*0x10*/ GoogleMobileAds.Common.IInitializationStatusClient client;

            /*0x2b22d90*/ InitializationStatus(GoogleMobileAds.Common.IInitializationStatusClient client);
            /*0x2b22dbc*/ System.Collections.Generic.Dictionary<string, GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap();
        }

        class LoadAdError : GoogleMobileAds.Api.AdError
        {
            /*0x18*/ GoogleMobileAds.Common.ILoadAdErrorClient client;

            /*0x2b22e68*/ LoadAdError(GoogleMobileAds.Common.ILoadAdErrorClient client);
            /*0x2b22e94*/ string ToString();
        }

        class MobileAds
        {
            static /*0x0*/ GoogleMobileAds.IClientFactory clientFactory;
            static /*0x8*/ GoogleMobileAds.Api.MobileAds instance;
            /*0x10*/ GoogleMobileAds.Common.IMobileAdsClient client;

            static /*0x2b22f90*/ GoogleMobileAds.Api.MobileAds get_Instance();
            static /*0x2b23014*/ void Initialize(System.Action<GoogleMobileAds.Api.InitializationStatus> initCompleteAction);
            static /*0x2b23198*/ void SetRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration);
            static /*0x2b23254*/ GoogleMobileAds.IClientFactory GetClientFactory();
            static /*0x2b22ee0*/ GoogleMobileAds.Common.IMobileAdsClient GetMobileAdsClient();
            /*0x2b22eb4*/ MobileAds();

            class <Initialize>c__AnonStorey0
            {
                /*0x10*/ System.Action<GoogleMobileAds.Api.InitializationStatus> initCompleteAction;

                /*0x2b23190*/ <Initialize>c__AnonStorey0();
                /*0x2b24a2c*/ void <>m__0(GoogleMobileAds.Common.IInitializationStatusClient initStatusClient);
            }
        }

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

            /*0x2b233c8*/ RewardedAd(string adUnitId);
            /*0x2b23b8c*/ void add_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2b23c2c*/ void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value);
            /*0x2b23ccc*/ void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x2b23d6c*/ void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> value);
            /*0x2b23e0c*/ void add_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x2b23eac*/ void remove_OnAdClosed(System.EventHandler<System.EventArgs> value);
            /*0x2b23f4c*/ void add_OnAdFailedToShow(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x2b23fec*/ void remove_OnAdFailedToShow(System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs> value);
            /*0x2b2408c*/ void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x2b2412c*/ void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value);
            /*0x2b241cc*/ void LoadAd(GoogleMobileAds.Api.AdRequest request);
            /*0x2b24294*/ bool IsLoaded();
            /*0x2b2429c*/ void Show();
            /*0x2b24350*/ void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions);
            /*0x2b24410*/ void Destroy();
            /*0x2b244c0*/ void <RewardedAd>m__0(object sender, System.EventArgs args);
            /*0x2b2453c*/ void <RewardedAd>m__1(object sender, GoogleMobileAds.Common.LoadAdErrorClientEventArgs args);
            /*0x2b24620*/ void <RewardedAd>m__2(object sender, GoogleMobileAds.Common.AdErrorClientEventArgs args);
            /*0x2b24704*/ void <RewardedAd>m__3(object sender, System.EventArgs args);
            /*0x2b24778*/ void <RewardedAd>m__4(object sender, System.EventArgs args);
            /*0x2b247ec*/ void <RewardedAd>m__5(object sender, GoogleMobileAds.Common.AdErrorClientEventArgs args);
            /*0x2b248d0*/ void <RewardedAd>m__6(object sender, System.EventArgs args);
            /*0x2b24944*/ void <RewardedAd>m__7(object sender, GoogleMobileAds.Api.Reward args);
            /*0x2b249b8*/ void <RewardedAd>m__8(object sender, GoogleMobileAds.Api.AdValueEventArgs args);
        }
    }
}
