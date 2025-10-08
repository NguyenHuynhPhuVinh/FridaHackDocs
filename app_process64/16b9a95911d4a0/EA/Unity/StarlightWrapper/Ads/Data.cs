class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x2bed7e8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x2bed8dc*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace Ads
            {
                class Suppression
                {
                    /*0x10*/ EA.Unity.StarlightWrapper.Ads.Data.SuppressionData <SuppressionData>k__BackingField;
                    /*0x18*/ System.Collections.Generic.Dictionary<string, object> suppressionState;
                    /*0x20*/ System.Collections.Generic.HashSet<System.Func<System.Collections.Generic.Dictionary<string, object>>> suppressionStateUpdaters;
                    /*0x28*/ System.Collections.Generic.Dictionary<string, object> updatedStateDict;
                    /*0x30*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices <CentralServices>k__BackingField;

                    /*0x2bee5bc*/ Suppression(EA.Unity.StarlightWrapper.Ads.Data.SuppressionData suppressionData);
                    /*0x2bed8e4*/ EA.Unity.StarlightWrapper.Ads.Data.SuppressionData get_SuppressionData();
                    /*0x2bed8ec*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices get_CentralServices();
                    /*0x2bed8f4*/ void set_CentralServices(EA.Unity.StarlightWrapper.CentralServices.ICentralServices value);
                    /*0x2bed8fc*/ System.Collections.Generic.IReadOnlyDictionary<string, object> get_SuppressionState();
                    /*0x2bed904*/ bool IsAdSuppressed(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adDefinition);
                    /*0x2bed9d8*/ System.Collections.Generic.IReadOnlyList<string> GetSuppressedKeys(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adDefinition);
                    /*0x2bee6b0*/ void AddSuppressionStateUpdater(System.Func<System.Collections.Generic.Dictionary<string, object>> updater);
                    /*0x2bee740*/ void RemoveSuppressionStateUpdater(System.Func<System.Collections.Generic.Dictionary<string, object>> updater);
                    /*0x2bee7d0*/ bool UpdateSuppressionState();
                    /*0x2bedd30*/ System.Collections.Generic.IReadOnlyList<EA.Unity.StarlightWrapper.Ads.Data.SuppressionRule> GetSuppressionRulesForAd(EA.Unity.StarlightWrapper.Ads.Data.AdDefinition adDefinition, bool checkAdType);
                    /*0x2bee1ac*/ bool DoesSuppressionRulePass(EA.Unity.StarlightWrapper.Ads.Data.SuppressionRule rule);
                }

                namespace Data
                {
                    class AdDefinition
                    {
                        static string REWARD_KEY_REWARD = "reward";
                        static string REWARD_KEY_AMOUNT = "amount";
                        static string REWARD_KEY_CUSTOM_DATA = "customData";
                        /*0x10*/ string adId;
                        /*0x18*/ bool isEnabled;
                        /*0x1c*/ EA.Unity.StarlightWrapper.Ads.Data.AdTypes adType;
                        /*0x20*/ EA.Unity.StarlightWrapper.Ads.Data.BannerPositions bannerPosition;
                        /*0x28*/ string rewardType;
                        /*0x30*/ int rewardAmount;
                        /*0x38*/ string customRewardData;
                        /*0x40*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.SuppressionRule> suppressionRules;

                        /*0x2befb88*/ AdDefinition();
                        /*0x2befc1c*/ AdDefinition(string adId, bool isEnabled, EA.Unity.StarlightWrapper.Ads.Data.AdTypes adType, EA.Unity.StarlightWrapper.Ads.Data.BannerPositions bannerPosition, string rewardType, int rewardAmount, string customRewardData, System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.SuppressionRule> suppressionRules);
                        /*0x2bef840*/ bool get_IsEnabled();
                        /*0x2bef848*/ string get_AdId();
                        /*0x2bef850*/ EA.Unity.StarlightWrapper.Ads.Data.AdTypes get_AdType();
                        /*0x2bef858*/ EA.Unity.StarlightWrapper.Ads.Data.BannerPositions get_BannerPosition();
                        /*0x2bef874*/ string get_BannerPositionName();
                        /*0x2bef8ec*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.SuppressionRule> get_SuppressionRules();
                        /*0x2bef8f4*/ string get_RewardType();
                        /*0x2bef910*/ int get_RewardAmount();
                        /*0x2bef92c*/ string get_CustomRewardData();
                        /*0x2bef96c*/ System.Collections.Generic.Dictionary<string, object> GetRewardDataDictionary(string extraRewardData, bool base64ExtraDataString);
                    }

                    class AdsData
                    {
                        /*0x10*/ bool automaticallyPreLoadAds;
                        /*0x18*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.AdDefinition> adDefinitionList;
                        /*0x20*/ EA.Unity.StarlightWrapper.Ads.Data.SuppressionData suppressionData;
                        /*0x28*/ System.Collections.Generic.Dictionary<string, EA.Unity.StarlightWrapper.Ads.Data.AdDefinition> adDefinitionDict;

                        /*0x2befd3c*/ AdsData();
                        /*0x2befee4*/ AdsData(System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.AdDefinition> adDefinitionList, EA.Unity.StarlightWrapper.Ads.Data.SuppressionData suppressionData, bool automaticallyPreLoadAds);
                        /*0x2befff8*/ System.Collections.Generic.Dictionary<string, EA.Unity.StarlightWrapper.Ads.Data.AdDefinition> get_AdDefinitions();
                        /*0x2bf0150*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition GetAdDefinition(string adId);
                        /*0x2bf01c0*/ EA.Unity.StarlightWrapper.Ads.Data.AdDefinition[] GetAdsOfType(EA.Unity.StarlightWrapper.Ads.Data.AdTypes types);
                        /*0x2bf0314*/ EA.Unity.StarlightWrapper.Ads.Data.SuppressionData get_SuppressionData();
                        /*0x2bf031c*/ bool get_AutomaticallyPreLoadAds();
                    }

                    class AdsDataContainer : UnityEngine.ScriptableObject
                    {
                        /*0x18*/ EA.Unity.StarlightWrapper.Ads.Data.AdsData adsData;

                        /*0x2bf032c*/ AdsDataContainer();
                        /*0x2bf0324*/ EA.Unity.StarlightWrapper.Ads.Data.AdsData get_AdsData();
                    }

                    enum AdTypes
                    {
                        Interstitial = 1,
                        RewardedInterstitial = 2,
                        OfferWall = 4,
                        Banner = 8,
                    }

                    enum AdStates
                    {
                        NotAvailable = 0,
                        ReadyToLoad = 1,
                        Loading = 2,
                        LoadedButCantShow = 3,
                        ReadyToShow = 4,
                        Showing = 5,
                    }

                    enum BannerPositions
                    {
                        None = 0,
                        Top = 1,
                        Bottom = 2,
                        Center = 3,
                    }

                    enum SuppressionRuleOperators
                    {
                        GreaterThanOrEqualTo = 0,
                        LessThan = 1,
                        MultipleOf = 2,
                        NotMultipleOf = 3,
                        StringMatch = 4,
                        NotStringMatch = 5,
                    }

                    class GlobalSuppressionRule : EA.Unity.StarlightWrapper.Ads.Data.SuppressionRule
                    {
                        /*0x3c*/ EA.Unity.StarlightWrapper.Ads.Data.AdTypes selectedAdTypes;

                        /*0x2bf039c*/ GlobalSuppressionRule();
                        /*0x2bf0438*/ GlobalSuppressionRule(bool isEnabled, string ruleId, string trackedAttribute, int targetInt, EA.Unity.StarlightWrapper.Ads.Data.SuppressionRuleOperators suppressionRuleOperator, EA.Unity.StarlightWrapper.Ads.Data.AdTypes selectedAdTypes);
                        /*0x2bf054c*/ GlobalSuppressionRule(bool isEnabled, string ruleId, string trackedAttribute, System.Collections.Generic.List<string> targetStringList, EA.Unity.StarlightWrapper.Ads.Data.SuppressionRuleOperators suppressionRuleOperator, EA.Unity.StarlightWrapper.Ads.Data.AdTypes selectedAdTypes);
                        /*0x2bf0394*/ EA.Unity.StarlightWrapper.Ads.Data.AdTypes get_SelectedAdTypes();
                        /*0x2bef7f0*/ bool IsEnabledForAdType(EA.Unity.StarlightWrapper.Ads.Data.AdTypes adType);

                        class EnumFlags : UnityEngine.PropertyAttribute
                        {
                            /*0x2bf0670*/ EnumFlags();
                        }
                    }

                    class IgnoredErrors
                    {
                        /*0x10*/ System.Collections.Generic.List<string> allowedErrors;
                        /*0x18*/ System.Collections.Generic.List<string> nonErrors;
                        /*0x20*/ System.Collections.Generic.HashSet<string> allowedErrorsSet;
                        /*0x28*/ System.Collections.Generic.HashSet<string> nonErrorsSet;

                        /*0x2bf0678*/ IgnoredErrors();
                        /*0x2bf122c*/ IgnoredErrors(System.Collections.Generic.IEnumerable<string> allowedErrors, System.Collections.Generic.IEnumerable<string> nonErrors);
                        /*0x2bf1e50*/ System.Collections.Generic.HashSet<string> get_AllowedErrors();
                        /*0x2bf1ee8*/ System.Collections.Generic.HashSet<string> get_NonErrors();
                    }

                    class SuppressionData
                    {
                        /*0x10*/ System.Collections.Generic.HashSet<string> crossPromoTrackingKeysSet;
                        /*0x18*/ bool isEnabled;
                        /*0x19*/ bool suppressAllAds;
                        /*0x20*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.GlobalSuppressionRule> rules;
                        /*0x28*/ System.Collections.Generic.List<string> crossPromoTrackingKeys;

                        /*0x2befe00*/ SuppressionData();
                        /*0x2bf1f98*/ SuppressionData(System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.GlobalSuppressionRule> rules, bool isEnabled, bool suppressAllAds, System.Collections.Generic.List<string> crossPromoTrackingKeys);
                        /*0x2bf1f80*/ bool get_IsEnabled();
                        /*0x2bf1f88*/ bool get_SuppressAllAds();
                        /*0x2bf1f90*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.Ads.Data.GlobalSuppressionRule> get_Rules();
                        /*0x2bef5c4*/ System.Collections.Generic.HashSet<string> get_CrossPromoTrackingKeys();
                    }

                    class SuppressionRule
                    {
                        /*0x10*/ string ruleId;
                        /*0x18*/ bool isEnabled;
                        /*0x20*/ string trackedAttribute;
                        /*0x28*/ int targetInt;
                        /*0x30*/ System.Collections.Generic.List<string> targetStringList;
                        /*0x38*/ EA.Unity.StarlightWrapper.Ads.Data.SuppressionRuleOperators suppressionRuleOperator;

                        /*0x2bf03a8*/ SuppressionRule();
                        /*0x2bf0464*/ SuppressionRule(bool isEnabled, string ruleId, string trackedAttribute, int targetInt, EA.Unity.StarlightWrapper.Ads.Data.SuppressionRuleOperators suppressionRuleOperator);
                        /*0x2bf0578*/ SuppressionRule(bool isEnabled, string ruleId, string trackedAttribute, System.Collections.Generic.List<string> targetStringList, EA.Unity.StarlightWrapper.Ads.Data.SuppressionRuleOperators suppressionRuleOperator);
                        /*0x2bf20d4*/ bool get_IsEnabled();
                        /*0x2bf20dc*/ string get_RuleId();
                        /*0x2bf20e4*/ string get_TrackedAttribute();
                        /*0x2bef800*/ object get_CompareTarget();
                        /*0x2bf20ec*/ EA.Unity.StarlightWrapper.Ads.Data.SuppressionRuleOperators get_SuppressionRuleOperator();
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> AA2EBD7EF0F63E72D27EBE9770DD5CBCD6A4B8E5F509CB9066339BC349089CA5;
    static /*0x35e*/ <PrivateImplementationDetails> B7C8CD5A87A75325547BE729F925D9F62E58D4ECAADAF57775D3040E05AB51D9;

    struct __StaticArrayInitTypeSize=496
    {
    }

    struct __StaticArrayInitTypeSize=862
    {
    }
}
