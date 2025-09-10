class <Module>
{
}

namespace GoogleMobileAds
{
    namespace Api
    {
        enum AdPosition
        {
            Top = 0,
            Bottom = 1,
            TopLeft = 2,
            TopRight = 3,
            BottomLeft = 4,
            BottomRight = 5,
            Center = 6,
        }

        class AdRequest
        {
            static string TestDeviceSimulator = "SIMULATOR";
            static /*0x0*/ string <Version>k__BackingField;
            /*0x10*/ System.Collections.Generic.HashSet<string> <Keywords>k__BackingField;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> <Extras>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> <MediationExtras>k__BackingField;

            static /*0x139c444*/ AdRequest();
            static /*0x139c6b8*/ string get_Version();
            static /*0x139c710*/ void set_Version(string value);
            static /*0x139c79c*/ string BuildVersionString(string nativePluginVersion);
            /*0x139c5cc*/ AdRequest(GoogleMobileAds.Api.AdRequest.Builder builder);
            /*0x139c76c*/ System.Collections.Generic.HashSet<string> get_Keywords();
            /*0x139c774*/ void set_Keywords(System.Collections.Generic.HashSet<string> value);
            /*0x139c77c*/ System.Collections.Generic.Dictionary<string, string> get_Extras();
            /*0x139c784*/ void set_Extras(System.Collections.Generic.Dictionary<string, string> value);
            /*0x139c78c*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> get_MediationExtras();
            /*0x139c794*/ void set_MediationExtras(System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> value);

            class Builder
            {
                /*0x10*/ System.Collections.Generic.HashSet<string> <Keywords>k__BackingField;
                /*0x18*/ System.Collections.Generic.Dictionary<string, string> <Extras>k__BackingField;
                /*0x20*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> <MediationExtras>k__BackingField;

                /*0x139c8d4*/ Builder();
                /*0x139c9dc*/ System.Collections.Generic.HashSet<string> get_Keywords();
                /*0x139c9e4*/ void set_Keywords(System.Collections.Generic.HashSet<string> value);
                /*0x139c9ec*/ System.Collections.Generic.Dictionary<string, string> get_Extras();
                /*0x139c9f4*/ void set_Extras(System.Collections.Generic.Dictionary<string, string> value);
                /*0x139c9fc*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> get_MediationExtras();
                /*0x139ca04*/ void set_MediationExtras(System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> value);
                /*0x139ca0c*/ GoogleMobileAds.Api.AdRequest.Builder AddKeyword(string keyword);
                /*0x139ca6c*/ GoogleMobileAds.Api.AdRequest Build();
                /*0x139cacc*/ GoogleMobileAds.Api.AdRequest.Builder AddMediationExtras(GoogleMobileAds.Api.Mediation.MediationExtras extras);
                /*0x139cb74*/ GoogleMobileAds.Api.AdRequest.Builder AddExtra(string key, string value);
            }
        }

        enum Orientation
        {
            Current = 0,
            Landscape = 1,
            Portrait = 2,
        }

        class AdSize
        {
            static /*0x0*/ GoogleMobileAds.Api.AdSize Banner;
            static /*0x8*/ GoogleMobileAds.Api.AdSize MediumRectangle;
            static /*0x10*/ GoogleMobileAds.Api.AdSize IABBanner;
            static /*0x18*/ GoogleMobileAds.Api.AdSize Leaderboard;
            static /*0x20*/ GoogleMobileAds.Api.AdSize SmartBanner;
            static /*0x28*/ int FullWidth;
            /*0x10*/ GoogleMobileAds.Api.AdSize.Type type;
            /*0x14*/ GoogleMobileAds.Api.Orientation orientation;
            /*0x18*/ int width;
            /*0x1c*/ int height;

            static /*0x139cf90*/ AdSize();
            static /*0x139cc50*/ GoogleMobileAds.Api.AdSize CreateAnchoredAdaptiveAdSize(int width, GoogleMobileAds.Api.Orientation orientation);
            static /*0x139ccc8*/ GoogleMobileAds.Api.AdSize GetLandscapeAnchoredAdaptiveBannerAdSizeWithWidth(int width);
            static /*0x139cd20*/ GoogleMobileAds.Api.AdSize GetPortraitAnchoredAdaptiveBannerAdSizeWithWidth(int width);
            static /*0x139cd78*/ GoogleMobileAds.Api.AdSize GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(int width);
            static /*0x139ced8*/ bool op_Equality(GoogleMobileAds.Api.AdSize a, GoogleMobileAds.Api.AdSize b);
            static /*0x139cef4*/ bool op_Inequality(GoogleMobileAds.Api.AdSize a, GoogleMobileAds.Api.AdSize b);
            /*0x139cbe4*/ AdSize(int width, int height);
            /*0x139cc14*/ AdSize(int width, int height, GoogleMobileAds.Api.AdSize.Type type);
            /*0x139cdd0*/ int get_Width();
            /*0x139cdd8*/ int get_Height();
            /*0x139cde0*/ GoogleMobileAds.Api.AdSize.Type get_AdType();
            /*0x139cde8*/ GoogleMobileAds.Api.Orientation get_Orientation();
            /*0x139cdf0*/ bool Equals(object obj);
            /*0x139cf24*/ int GetHashCode();

            enum Type
            {
                Standard = 0,
                SmartBanner = 1,
                AnchoredAdaptive = 2,
            }
        }

        class AdValue
        {
            /*0x10*/ GoogleMobileAds.Api.AdValue.PrecisionType <Precision>k__BackingField;
            /*0x18*/ long <Value>k__BackingField;
            /*0x20*/ string <CurrencyCode>k__BackingField;

            /*0x139d0bc*/ AdValue();
            /*0x139d0c4*/ GoogleMobileAds.Api.AdValue.PrecisionType get_Precision();
            /*0x139d0cc*/ void set_Precision(GoogleMobileAds.Api.AdValue.PrecisionType value);
            /*0x139d0d4*/ long get_Value();
            /*0x139d0dc*/ void set_Value(long value);
            /*0x139d0e4*/ string get_CurrencyCode();
            /*0x139d0ec*/ void set_CurrencyCode(string value);

            enum PrecisionType
            {
                Unknown = 0,
                Estimated = 1,
                PublisherProvided = 2,
                Precise = 3,
            }
        }

        class AdValueEventArgs : System.EventArgs
        {
            /*0x10*/ GoogleMobileAds.Api.AdValue <AdValue>k__BackingField;

            /*0x139d0f4*/ AdValueEventArgs();
            /*0x139d14c*/ GoogleMobileAds.Api.AdValue get_AdValue();
            /*0x139d154*/ void set_AdValue(GoogleMobileAds.Api.AdValue value);
        }

        class AdapterStatus
        {
            /*0x10*/ GoogleMobileAds.Api.AdapterState <InitializationState>k__BackingField;
            /*0x18*/ string <Description>k__BackingField;
            /*0x20*/ int <Latency>k__BackingField;

            /*0x139d15c*/ AdapterStatus(GoogleMobileAds.Api.AdapterState state, string description, int latency);
            /*0x139d19c*/ GoogleMobileAds.Api.AdapterState get_InitializationState();
            /*0x139d1a4*/ void set_InitializationState(GoogleMobileAds.Api.AdapterState value);
            /*0x139d1ac*/ string get_Description();
            /*0x139d1b4*/ void set_Description(string value);
            /*0x139d1bc*/ int get_Latency();
            /*0x139d1c4*/ void set_Latency(int value);
        }

        enum AdapterState
        {
            NotReady = 0,
            Ready = 1,
        }

        enum Gender
        {
            Unknown = 0,
            Male = 1,
            Female = 2,
        }

        class MaxAdContentRating
        {
            /*0x10*/ string <Value>k__BackingField;

            static /*0x139d204*/ GoogleMobileAds.Api.MaxAdContentRating get_G();
            static /*0x139d27c*/ GoogleMobileAds.Api.MaxAdContentRating get_MA();
            static /*0x139d2f4*/ GoogleMobileAds.Api.MaxAdContentRating get_PG();
            static /*0x139d36c*/ GoogleMobileAds.Api.MaxAdContentRating get_T();
            static /*0x139d3e4*/ GoogleMobileAds.Api.MaxAdContentRating get_Unspecified();
            static /*0x139d464*/ GoogleMobileAds.Api.MaxAdContentRating ToMaxAdContentRating(string value);
            /*0x139d1cc*/ MaxAdContentRating(string value);
            /*0x139d1f4*/ string get_Value();
            /*0x139d1fc*/ void set_Value(string value);
        }

        class RequestConfiguration
        {
            /*0x10*/ GoogleMobileAds.Api.MaxAdContentRating <MaxAdContentRating>k__BackingField;
            /*0x18*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> <TagForChildDirectedTreatment>k__BackingField;
            /*0x20*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> <TagForUnderAgeOfConsent>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<string> <TestDeviceIds>k__BackingField;
            /*0x30*/ System.Nullable<bool> <SameAppKeyEnabled>k__BackingField;

            /*0x139d4c8*/ RequestConfiguration(GoogleMobileAds.Api.RequestConfiguration.Builder builder);
            /*0x139d51c*/ GoogleMobileAds.Api.MaxAdContentRating get_MaxAdContentRating();
            /*0x139d524*/ void set_MaxAdContentRating(GoogleMobileAds.Api.MaxAdContentRating value);
            /*0x139d52c*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> get_TagForChildDirectedTreatment();
            /*0x139d534*/ void set_TagForChildDirectedTreatment(System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> value);
            /*0x139d53c*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> get_TagForUnderAgeOfConsent();
            /*0x139d544*/ void set_TagForUnderAgeOfConsent(System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> value);
            /*0x139d54c*/ System.Collections.Generic.List<string> get_TestDeviceIds();
            /*0x139d554*/ void set_TestDeviceIds(System.Collections.Generic.List<string> value);
            /*0x139d55c*/ System.Nullable<bool> get_SameAppKeyEnabled();
            /*0x139d564*/ void set_SameAppKeyEnabled(System.Nullable<bool> value);
            /*0x139d56c*/ GoogleMobileAds.Api.RequestConfiguration.Builder ToBuilder();

            class Builder
            {
                /*0x10*/ GoogleMobileAds.Api.MaxAdContentRating <MaxAdContentRating>k__BackingField;
                /*0x18*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> <TagForChildDirectedTreatment>k__BackingField;
                /*0x20*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> <TagForUnderAgeOfConsent>k__BackingField;
                /*0x28*/ System.Collections.Generic.List<string> <TestDeviceIds>k__BackingField;
                /*0x30*/ System.Nullable<bool> <SameAppKeyEnabled>k__BackingField;

                /*0x139d63c*/ Builder();
                /*0x139d754*/ GoogleMobileAds.Api.MaxAdContentRating get_MaxAdContentRating();
                /*0x139d75c*/ void set_MaxAdContentRating(GoogleMobileAds.Api.MaxAdContentRating value);
                /*0x139d764*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> get_TagForChildDirectedTreatment();
                /*0x139d76c*/ void set_TagForChildDirectedTreatment(System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> value);
                /*0x139d774*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> get_TagForUnderAgeOfConsent();
                /*0x139d77c*/ void set_TagForUnderAgeOfConsent(System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> value);
                /*0x139d784*/ System.Collections.Generic.List<string> get_TestDeviceIds();
                /*0x139d78c*/ void set_TestDeviceIds(System.Collections.Generic.List<string> value);
                /*0x139d794*/ System.Nullable<bool> get_SameAppKeyEnabled();
                /*0x139d79c*/ void set_SameAppKeyEnabled(System.Nullable<bool> value);
                /*0x139d6c8*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetMaxAdContentRating(GoogleMobileAds.Api.MaxAdContentRating maxAdContentRating);
                /*0x139d6d0*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetTagForChildDirectedTreatment(System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> tagForChildDirectedTreatment);
                /*0x139d6d8*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetTagForUnderAgeOfConsent(System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> tagForUnderAgeOfConsent);
                /*0x139d6e0*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetTestDeviceIds(System.Collections.Generic.List<string> testDeviceIds);
                /*0x139d6e8*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetSameAppKeyEnabled(bool enabled);
                /*0x139d7a4*/ GoogleMobileAds.Api.RequestConfiguration build();
            }
        }

        class Reward : System.EventArgs
        {
            /*0x10*/ string <Type>k__BackingField;
            /*0x18*/ double <Amount>k__BackingField;

            /*0x139d804*/ Reward();
            /*0x139d85c*/ string get_Type();
            /*0x139d864*/ void set_Type(string value);
            /*0x139d86c*/ double get_Amount();
            /*0x139d874*/ void set_Amount(double value);
        }

        class ServerSideVerificationOptions
        {
            /*0x10*/ string <UserId>k__BackingField;
            /*0x18*/ string <CustomData>k__BackingField;

            /*0x139d87c*/ ServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions.Builder builder);
            /*0x139d8b0*/ string get_UserId();
            /*0x139d8b8*/ void set_UserId(string value);
            /*0x139d8c0*/ string get_CustomData();
            /*0x139d8c8*/ void set_CustomData(string value);

            class Builder
            {
                /*0x10*/ string <UserId>k__BackingField;
                /*0x18*/ string <CustomData>k__BackingField;

                /*0x139d8d0*/ Builder();
                /*0x139d8d8*/ string get_UserId();
                /*0x139d8e0*/ void set_UserId(string value);
                /*0x139d8e8*/ string get_CustomData();
                /*0x139d8f0*/ void set_CustomData(string value);
                /*0x139d8f8*/ GoogleMobileAds.Api.ServerSideVerificationOptions.Builder SetUserId(string userId);
                /*0x139d900*/ GoogleMobileAds.Api.ServerSideVerificationOptions.Builder SetCustomData(string customData);
                /*0x139d908*/ GoogleMobileAds.Api.ServerSideVerificationOptions Build();
            }
        }

        enum TagForChildDirectedTreatment
        {
            Unspecified = -1,
            False = 0,
            True = 1,
        }

        enum TagForUnderAgeOfConsent
        {
            Unspecified = -1,
            False = 0,
            True = 1,
        }

        namespace Mediation
        {
            class MediationExtras
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, string> <Extras>k__BackingField;

                /*0x139d968*/ MediationExtras();
                /*0x139d9e8*/ System.Collections.Generic.Dictionary<string, string> get_Extras();
                /*0x139d9f0*/ void set_Extras(System.Collections.Generic.Dictionary<string, string> value);
                string get_AndroidMediationExtraBuilderClassName();
                string get_IOSMediationExtraBuilderClassName();
            }
        }
    }
}
