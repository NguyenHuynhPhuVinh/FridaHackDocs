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
            static /*0x0*/ string <Version>k__BackingField;
            /*0x10*/ System.Collections.Generic.HashSet<string> <Keywords>k__BackingField;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> <Extras>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> <MediationExtras>k__BackingField;

            static /*0x2b14d84*/ AdRequest();
            static /*0x2b15008*/ void set_Version(string value);
            /*0x2b14f20*/ AdRequest(GoogleMobileAds.Api.AdRequest.Builder builder);
            /*0x2b15070*/ System.Collections.Generic.HashSet<string> get_Keywords();
            /*0x2b15078*/ void set_Keywords(System.Collections.Generic.HashSet<string> value);
            /*0x2b15080*/ System.Collections.Generic.Dictionary<string, string> get_Extras();
            /*0x2b15088*/ void set_Extras(System.Collections.Generic.Dictionary<string, string> value);
            /*0x2b15090*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> get_MediationExtras();
            /*0x2b15098*/ void set_MediationExtras(System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> value);

            class Builder
            {
                /*0x10*/ System.Collections.Generic.HashSet<string> <Keywords>k__BackingField;
                /*0x18*/ System.Collections.Generic.Dictionary<string, string> <Extras>k__BackingField;
                /*0x20*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> <MediationExtras>k__BackingField;

                /*0x2b156d4*/ Builder();
                /*0x2b157d0*/ System.Collections.Generic.HashSet<string> get_Keywords();
                /*0x2b157d8*/ void set_Keywords(System.Collections.Generic.HashSet<string> value);
                /*0x2b157e0*/ System.Collections.Generic.Dictionary<string, string> get_Extras();
                /*0x2b157e8*/ void set_Extras(System.Collections.Generic.Dictionary<string, string> value);
                /*0x2b157f0*/ System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> get_MediationExtras();
                /*0x2b157f8*/ void set_MediationExtras(System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> value);
                /*0x2b15800*/ GoogleMobileAds.Api.AdRequest Build();
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

            static /*0x2b152a8*/ AdSize();
            /*0x2b150a0*/ AdSize(int width, int height);
            /*0x2b150dc*/ AdSize(int width, int height, GoogleMobileAds.Api.AdSize.Type type);
            /*0x2b1511c*/ int get_Width();
            /*0x2b15124*/ int get_Height();
            /*0x2b1512c*/ GoogleMobileAds.Api.AdSize.Type get_AdType();
            /*0x2b15134*/ GoogleMobileAds.Api.Orientation get_Orientation();
            /*0x2b1513c*/ bool Equals(object obj);
            /*0x2b15230*/ int GetHashCode();

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

            /*0x2b153c4*/ AdValue();
            /*0x2b153cc*/ void set_Precision(GoogleMobileAds.Api.AdValue.PrecisionType value);
            /*0x2b153d4*/ void set_Value(long value);
            /*0x2b153dc*/ void set_CurrencyCode(string value);

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

            /*0x2b153e4*/ AdValueEventArgs();
            /*0x2b15448*/ void set_AdValue(GoogleMobileAds.Api.AdValue value);
        }

        class AdapterStatus
        {
            /*0x10*/ GoogleMobileAds.Api.AdapterState <InitializationState>k__BackingField;
            /*0x18*/ string <Description>k__BackingField;
            /*0x20*/ int <Latency>k__BackingField;

            /*0x2b15450*/ AdapterStatus(GoogleMobileAds.Api.AdapterState state, string description, int latency);
            /*0x2b15494*/ GoogleMobileAds.Api.AdapterState get_InitializationState();
            /*0x2b1549c*/ void set_InitializationState(GoogleMobileAds.Api.AdapterState value);
            /*0x2b154a4*/ void set_Description(string value);
            /*0x2b154ac*/ void set_Latency(int value);
        }

        enum AdapterState
        {
            NotReady = 0,
            Ready = 1,
        }

        class MaxAdContentRating
        {
            /*0x10*/ string <Value>k__BackingField;

            static /*0x2b154f0*/ GoogleMobileAds.Api.MaxAdContentRating ToMaxAdContentRating(string value);
            /*0x2b154b4*/ MaxAdContentRating(string value);
            /*0x2b154e0*/ string get_Value();
            /*0x2b154e8*/ void set_Value(string value);
        }

        class RequestConfiguration
        {
            /*0x10*/ GoogleMobileAds.Api.MaxAdContentRating <MaxAdContentRating>k__BackingField;
            /*0x18*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> <TagForChildDirectedTreatment>k__BackingField;
            /*0x20*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> <TagForUnderAgeOfConsent>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<string> <TestDeviceIds>k__BackingField;
            /*0x30*/ System.Nullable<bool> <SameAppKeyEnabled>k__BackingField;

            /*0x2b15558*/ RequestConfiguration(GoogleMobileAds.Api.RequestConfiguration.Builder builder);
            /*0x2b155b0*/ GoogleMobileAds.Api.MaxAdContentRating get_MaxAdContentRating();
            /*0x2b155b8*/ void set_MaxAdContentRating(GoogleMobileAds.Api.MaxAdContentRating value);
            /*0x2b155c0*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> get_TagForChildDirectedTreatment();
            /*0x2b155c8*/ void set_TagForChildDirectedTreatment(System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> value);
            /*0x2b155d0*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> get_TagForUnderAgeOfConsent();
            /*0x2b155d8*/ void set_TagForUnderAgeOfConsent(System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> value);
            /*0x2b155e0*/ System.Collections.Generic.List<string> get_TestDeviceIds();
            /*0x2b155e8*/ void set_TestDeviceIds(System.Collections.Generic.List<string> value);
            /*0x2b155f0*/ System.Nullable<bool> get_SameAppKeyEnabled();
            /*0x2b155f8*/ void set_SameAppKeyEnabled(System.Nullable<bool> value);

            class Builder
            {
                /*0x10*/ GoogleMobileAds.Api.MaxAdContentRating <MaxAdContentRating>k__BackingField;
                /*0x18*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> <TagForChildDirectedTreatment>k__BackingField;
                /*0x20*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> <TagForUnderAgeOfConsent>k__BackingField;
                /*0x28*/ System.Collections.Generic.List<string> <TestDeviceIds>k__BackingField;
                /*0x30*/ System.Nullable<bool> <SameAppKeyEnabled>k__BackingField;

                /*0x2b1585c*/ Builder();
                /*0x2b158e4*/ GoogleMobileAds.Api.MaxAdContentRating get_MaxAdContentRating();
                /*0x2b158ec*/ void set_MaxAdContentRating(GoogleMobileAds.Api.MaxAdContentRating value);
                /*0x2b158f4*/ System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> get_TagForChildDirectedTreatment();
                /*0x2b158fc*/ void set_TagForChildDirectedTreatment(System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> value);
                /*0x2b15904*/ System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> get_TagForUnderAgeOfConsent();
                /*0x2b1590c*/ void set_TagForUnderAgeOfConsent(System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> value);
                /*0x2b15914*/ System.Collections.Generic.List<string> get_TestDeviceIds();
                /*0x2b1591c*/ void set_TestDeviceIds(System.Collections.Generic.List<string> value);
                /*0x2b15924*/ System.Nullable<bool> get_SameAppKeyEnabled();
                /*0x2b1592c*/ void set_SameAppKeyEnabled(System.Nullable<bool> value);
                /*0x2b15934*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetMaxAdContentRating(GoogleMobileAds.Api.MaxAdContentRating maxAdContentRating);
                /*0x2b1593c*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetTagForChildDirectedTreatment(System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> tagForChildDirectedTreatment);
                /*0x2b15944*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetTagForUnderAgeOfConsent(System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> tagForUnderAgeOfConsent);
                /*0x2b1594c*/ GoogleMobileAds.Api.RequestConfiguration.Builder SetTestDeviceIds(System.Collections.Generic.List<string> testDeviceIds);
                /*0x2b15954*/ GoogleMobileAds.Api.RequestConfiguration build();
            }
        }

        class Reward : System.EventArgs
        {
            /*0x10*/ string <Type>k__BackingField;
            /*0x18*/ double <Amount>k__BackingField;

            /*0x2b15600*/ Reward();
            /*0x2b15664*/ void set_Type(string value);
            /*0x2b1566c*/ void set_Amount(double value);
        }

        class ServerSideVerificationOptions
        {
            /*0x10*/ string <UserId>k__BackingField;
            /*0x18*/ string <CustomData>k__BackingField;

            /*0x2b15674*/ ServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions.Builder builder);
            /*0x2b156b4*/ string get_UserId();
            /*0x2b156bc*/ void set_UserId(string value);
            /*0x2b156c4*/ string get_CustomData();
            /*0x2b156cc*/ void set_CustomData(string value);

            class Builder
            {
                /*0x10*/ string <UserId>k__BackingField;
                /*0x18*/ string <CustomData>k__BackingField;

                /*0x2b159b0*/ Builder();
                /*0x2b159b8*/ string get_UserId();
                /*0x2b159c0*/ string get_CustomData();
                /*0x2b159c8*/ void set_CustomData(string value);
                /*0x2b159d0*/ GoogleMobileAds.Api.ServerSideVerificationOptions.Builder SetCustomData(string customData);
                /*0x2b159d8*/ GoogleMobileAds.Api.ServerSideVerificationOptions Build();
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

                /*0x2b15550*/ System.Collections.Generic.Dictionary<string, string> get_Extras();
                string get_AndroidMediationExtraBuilderClassName();
            }
        }
    }
}
