class <Module>
{
}

namespace Glu
{
    namespace Plugins
    {
        namespace GluAnalytics
        {
            class GluAnalyticsFactory
            {
                static /*0x30264d4*/ Glu.Plugins.GluAnalytics.IGluAnalytics CreateGluAnalyticsAndroid(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
                /*0x30269e8*/ GluAnalyticsFactory();
                /*0x30262b8*/ Glu.Plugins.GluAnalytics.IGluAnalytics CreateGluAnalytics(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
            }

            interface IGluAnalytics : System.IDisposable
            {
                void LogEvent(string name, string st1, string st2, string st3, System.Nullable<long> val, System.Nullable<long> level, System.Collections.Generic.IDictionary<string, object> data);
                void LogInAppPurchaseInUsd(decimal price, string sku, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                /*0x1f30ebc*/ void SetUserIdentifier(string userId);
                /*0x1f30214*/ string GetAnalyticsDeviceIdentifier();
                /*0x1f30214*/ Glu.Plugins.GluAnalytics.GeoLocation GetGeoLocation();
                /*0x1f30f2c*/ void PerfSampleStart(string placement, Glu.Plugins.GluAnalytics.PerfType type, System.Collections.Generic.IDictionary<string, object> extraData);
                /*0x1f30ff0*/ void PerfSampleEnd(string placement, System.Collections.Generic.IDictionary<string, object> extraData);
                /*0x1f30ebc*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
                /*0x1f30214*/ System.Collections.Generic.IDictionary<string, object> GetCustomProperties();
            }

            class GeoLocation
            {
                /*0x10*/ string IPAddress;
                /*0x18*/ string CountryCode;

                /*0x30269f0*/ GeoLocation(string ipAddress, string countryCode);
                /*0x3026a34*/ string ToString();
            }

            enum PerfType
            {
                TIME = 1,
                MEM = 2,
                FPS = 4,
                ALL = 7,
            }

            enum PerfAction
            {
                PAUSE = 0,
                RESUME = 1,
                DROP = 2,
            }

            struct PerfMeasure
            {
                /*0x10*/ double lastFPS;
                /*0x18*/ double averageFPS;
                /*0x20*/ double minFPS;
                /*0x28*/ double maxFPS;
                /*0x30*/ double time;
                /*0x38*/ double startMem;
                /*0x40*/ double maxMem;
                /*0x48*/ double currentMem;

                /*0x3026b14*/ void Reset();
                /*0x3026b24*/ void Init(double iLastFPS, double iAverageFPS, double iMinFPS, double iMaxFPS, double iTime, double iStartMem, double iMaxMem, double iCurrentMem);
            }

            namespace Utils
            {
                class JniUtil
                {
                    static /*0x3026b38*/ void CallInLocalFrame(System.Action action);
                    static /*0x1ffc854*/ T CallInLocalFrame<T>(System.Func<T> func);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Action action;

                        /*0x3026c1c*/ <>c__DisplayClass0_0();
                        /*0x3026c24*/ object <CallInLocalFrame>b__0();
                    }
                }
            }

            namespace Implementation
            {
                class AndroidGluAnalytics : UnityEngine.MonoBehaviour, Glu.Plugins.GluAnalytics.IGluAnalytics, System.IDisposable
                {
                    /*0x20*/ UnityEngine.AndroidJavaClass util;
                    /*0x28*/ UnityEngine.AndroidJavaObject client;

                    static /*0x3028d3c*/ long ValueOrMin(System.Nullable<long> v);
                    /*0x3028ef4*/ AndroidGluAnalytics();
                    /*0x3026550*/ void Initialize(string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
                    /*0x3026f54*/ void Dispose();
                    /*0x3026fac*/ void LogEvent(string name, string st1, string st2, string st3, System.Nullable<long> val, System.Nullable<long> level, System.Collections.Generic.IDictionary<string, object> data);
                    /*0x302710c*/ void LogInAppPurchaseInUsd(decimal price, string sku, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x3027290*/ void LogTutorialStepCompleted(string stepName, System.Nullable<long> stepNumber, string tutorialId, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x30273c0*/ void LogMissionStarted(string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x3027514*/ void LogMissionFailed(string failureReason, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x3027680*/ void LogMissionCompleted(string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x30277d4*/ void LogCurrencySink(long amount, string currencyName, string item, string itemCategory, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302797c*/ void LogCurrencySource(long amount, string currencyName, string source, string sourceType, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x3027b24*/ void LogAdvertisementOpportunity(string placement, string rewardItem, long rewardAmount, bool missed, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x3027c48*/ void SetUserIdentifier(string userId);
                    /*0x3027d18*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
                    /*0x3027df0*/ System.Collections.Generic.IDictionary<string, object> GetCustomProperties();
                    /*0x30280b8*/ string GetAnalyticsDeviceIdentifier();
                    /*0x30281a4*/ string GetAnalyticsApplicationName();
                    /*0x3028290*/ string GetAnalyticsEnvironment();
                    /*0x302837c*/ string GetRevenueIdentifier();
                    /*0x3028468*/ string GetSessionIdentifier();
                    /*0x3028554*/ Glu.Plugins.GluAnalytics.GeoLocation GetGeoLocation();
                    /*0x30286e8*/ void PerfSampleStart(string placement, Glu.Plugins.GluAnalytics.PerfType type, System.Collections.Generic.IDictionary<string, object> extraData);
                    /*0x30287e4*/ void PerfSampleEnd(string placement, System.Collections.Generic.IDictionary<string, object> extraData);
                    /*0x30288d8*/ Glu.Plugins.GluAnalytics.PerfMeasure PerfGetValues();
                    /*0x3028bb8*/ bool PerfSampleAction(string placement, Glu.Plugins.GluAnalytics.PerfAction action);
                    /*0x3028de8*/ void OnDestroy();
                    /*0x3026c58*/ string ReplaceApplicationNameAndMarketplace(string jsonConfig);

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ long amount;
                        /*0x20*/ string currencyName;
                        /*0x28*/ string item;
                        /*0x30*/ string itemCategory;
                        /*0x38*/ string missionId;
                        /*0x40*/ string missionType;
                        /*0x48*/ string missionTier;
                        /*0x50*/ System.Nullable<long> hcBalance;
                        /*0x60*/ System.Nullable<long> scBalance;
                        /*0x70*/ System.Nullable<long> secondsInGame;
                        /*0x80*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x3027974*/ <>c__DisplayClass10_0();
                        /*0x3028efc*/ void <LogCurrencySink>b__0();
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ long amount;
                        /*0x20*/ string currencyName;
                        /*0x28*/ string source;
                        /*0x30*/ string sourceType;
                        /*0x38*/ string missionId;
                        /*0x40*/ string missionType;
                        /*0x48*/ string missionTier;
                        /*0x50*/ System.Nullable<long> hcBalance;
                        /*0x60*/ System.Nullable<long> scBalance;
                        /*0x70*/ System.Nullable<long> secondsInGame;
                        /*0x80*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x3027b1c*/ <>c__DisplayClass11_0();
                        /*0x302934c*/ void <LogCurrencySource>b__0();
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string placement;
                        /*0x20*/ string rewardItem;
                        /*0x28*/ long rewardAmount;
                        /*0x30*/ bool missed;
                        /*0x38*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x3027c40*/ <>c__DisplayClass12_0();
                        /*0x3029790*/ void <LogAdvertisementOpportunity>b__0();
                    }

                    class <>c__DisplayClass14_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ System.Collections.Generic.IDictionary<string, object> properties;

                        /*0x3027de8*/ <>c__DisplayClass14_0();
                        /*0x30299f8*/ void <SetCustomProperties>b__0();
                    }

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string placement;
                        /*0x20*/ Glu.Plugins.GluAnalytics.PerfType type;
                        /*0x28*/ System.Collections.Generic.IDictionary<string, object> extraData;

                        /*0x30287dc*/ <>c__DisplayClass22_0();
                        /*0x3029b44*/ void <PerfSampleStart>b__0();
                    }

                    class <>c__DisplayClass23_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string placement;
                        /*0x20*/ System.Collections.Generic.IDictionary<string, object> extraData;

                        /*0x30288d0*/ <>c__DisplayClass23_0();
                        /*0x3029d28*/ void <PerfSampleEnd>b__0();
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ string jsonConfig;
                        /*0x18*/ System.Collections.Generic.IDictionary<string, object> runtimeConfig;
                        /*0x20*/ UnityEngine.AndroidJavaObject factory;

                        /*0x3026c50*/ <>c__DisplayClass2_0();
                        /*0x3029eac*/ UnityEngine.AndroidJavaObject <Initialize>b__0();
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string name;
                        /*0x20*/ string st1;
                        /*0x28*/ string st2;
                        /*0x30*/ string st3;
                        /*0x38*/ System.Nullable<long> val;
                        /*0x48*/ System.Nullable<long> level;
                        /*0x58*/ System.Collections.Generic.IDictionary<string, object> data;

                        /*0x3027104*/ <>c__DisplayClass4_0();
                        /*0x302a014*/ void <LogEvent>b__0();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ decimal price;
                        /*0x28*/ string sku;
                        /*0x30*/ string missionId;
                        /*0x38*/ string missionType;
                        /*0x40*/ string missionTier;
                        /*0x48*/ System.Nullable<long> hcBalance;
                        /*0x58*/ System.Nullable<long> scBalance;
                        /*0x68*/ System.Nullable<long> secondsInGame;
                        /*0x78*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x3027288*/ <>c__DisplayClass5_0();
                        /*0x302a3dc*/ void <LogInAppPurchaseInUsd>b__0();
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string stepName;
                        /*0x20*/ System.Nullable<long> stepNumber;
                        /*0x30*/ string tutorialId;
                        /*0x38*/ System.Nullable<long> secondsInGame;
                        /*0x48*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x30273b8*/ <>c__DisplayClass6_0();
                        /*0x302a7cc*/ void <LogTutorialStepCompleted>b__0();
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string missionId;
                        /*0x20*/ string missionType;
                        /*0x28*/ string missionTier;
                        /*0x30*/ System.Nullable<long> hcBalance;
                        /*0x40*/ System.Nullable<long> scBalance;
                        /*0x50*/ System.Nullable<long> secondsInGame;
                        /*0x60*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x302750c*/ <>c__DisplayClass7_0();
                        /*0x302aa58*/ void <LogMissionStarted>b__0();
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string failureReason;
                        /*0x20*/ string missionId;
                        /*0x28*/ string missionType;
                        /*0x30*/ string missionTier;
                        /*0x38*/ System.Nullable<long> hcBalance;
                        /*0x48*/ System.Nullable<long> scBalance;
                        /*0x58*/ System.Nullable<long> secondsInGame;
                        /*0x68*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x3027678*/ <>c__DisplayClass8_0();
                        /*0x302ad7c*/ void <LogMissionFailed>b__0();
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ Glu.Plugins.GluAnalytics.Implementation.AndroidGluAnalytics <>4__this;
                        /*0x18*/ string missionId;
                        /*0x20*/ string missionType;
                        /*0x28*/ string missionTier;
                        /*0x30*/ System.Nullable<long> hcBalance;
                        /*0x40*/ System.Nullable<long> scBalance;
                        /*0x50*/ System.Nullable<long> secondsInGame;
                        /*0x60*/ System.Collections.Generic.IDictionary<string, object> userData;

                        /*0x30277cc*/ <>c__DisplayClass9_0();
                        /*0x302b0e4*/ void <LogMissionCompleted>b__0();
                    }
                }

                class DummyGluAnalytics : UnityEngine.MonoBehaviour, Glu.Plugins.GluAnalytics.IGluAnalytics, System.IDisposable
                {
                    /*0x302b4a4*/ DummyGluAnalytics();
                    /*0x302b408*/ void Initialize();
                    /*0x302b40c*/ void Dispose();
                    /*0x302b410*/ void LogEvent(string name, string st1, string st2, string st3, System.Nullable<long> val, System.Nullable<long> level, System.Collections.Generic.IDictionary<string, object> data);
                    /*0x302b414*/ void LogInAppPurchaseInUsd(decimal price, string sku, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b418*/ void LogTutorialStepCompleted(string stepName, System.Nullable<long> stepNumber, string tutorialId, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b41c*/ void LogMissionStarted(string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b420*/ void LogMissionFailed(string failureReason, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b424*/ void LogMissionCompleted(string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b428*/ void LogCurrencySink(long amount, string currencyName, string item, string itemCategory, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b42c*/ void LogCurrencySource(long amount, string currencyName, string source, string sourceType, string missionId, string missionType, string missionTier, System.Nullable<long> hcBalance, System.Nullable<long> scBalance, System.Nullable<long> secondsInGame, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b430*/ void LogAdvertisementLoaded(string placement, string network, bool success, string adType, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b434*/ void LogAdvertisementShown(string placement, string network, string adType, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b438*/ void LogAdvertisementClicked(string placement, string network, string adType, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b43c*/ void LogAdvertisementDismissed(string placement, string network, string adType, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b440*/ void LogAdvertisementOpportunity(string placement, string rewardItem, long rewardAmount, bool missed, System.Collections.Generic.IDictionary<string, object> userData);
                    /*0x302b444*/ void SetUserIdentifier(string userId);
                    /*0x302b448*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
                    /*0x302b44c*/ System.Collections.Generic.IDictionary<string, object> GetCustomProperties();
                    /*0x302b454*/ string GetAnalyticsDeviceIdentifier();
                    /*0x302b45c*/ string GetAnalyticsApplicationName();
                    /*0x302b464*/ string GetAnalyticsEnvironment();
                    /*0x302b46c*/ string GetRevenueIdentifier();
                    /*0x302b474*/ string GetSessionIdentifier();
                    /*0x302b47c*/ Glu.Plugins.GluAnalytics.GeoLocation GetGeoLocation();
                    /*0x302b484*/ void PerfSampleStart(string placement, Glu.Plugins.GluAnalytics.PerfType type, System.Collections.Generic.IDictionary<string, object> extraData);
                    /*0x302b488*/ void PerfSampleEnd(string placement, System.Collections.Generic.IDictionary<string, object> extraData);
                    /*0x302b48c*/ Glu.Plugins.GluAnalytics.PerfMeasure PerfGetValues();
                    /*0x302b49c*/ bool PerfSampleAction(string placement, Glu.Plugins.GluAnalytics.PerfAction action);
                }

                class MarshallingUtil
                {
                    static /*0x3029340*/ string JsonArg(object val);
                    static /*0x3026ab8*/ string GeoLocationToString(Glu.Plugins.GluAnalytics.GeoLocation location);

                    class SerializableGeoLocation
                    {
                        /*0x10*/ string ipAddress;
                        /*0x18*/ string countryCode;

                        /*0x302b51c*/ SerializableGeoLocation(Glu.Plugins.GluAnalytics.GeoLocation location);
                    }
                }

                interface ISerializableJsonObject
                {
                    /*0x1f30ebc*/ void WriteObject(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json);
                }

                interface ISerializableJson
                {
                    /*0x1f30ff0*/ void Write(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, string key);
                }

                class JsonStringer
                {
                    static /*0x0*/ System.Collections.Generic.IDictionary<char, string> EscapedCharacters;
                    /*0x10*/ System.Text.StringBuilder sb;
                    /*0x18*/ bool hasElements;

                    static /*0x302c13c*/ JsonStringer();
                    static /*0x302bf48*/ System.Collections.Generic.IDictionary<char, string> CreateEscapedCharacters();
                    /*0x302b564*/ JsonStringer();
                    /*0x302b5d0*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer EndArray();
                    /*0x302b634*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer EndObject();
                    /*0x302b668*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyNull(string key);
                    /*0x302b788*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyArray(string key);
                    /*0x302b7e4*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyObject(string key);
                    /*0x302b804*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyValue(string key, bool val);
                    /*0x302b89c*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyValue(string key, long val);
                    /*0x302b944*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyValue(string key, ulong val);
                    /*0x302b9ec*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyValue(string key, double val);
                    /*0x302baf0*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyValue(string key, decimal val);
                    /*0x302bbfc*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyValue(string key, string val);
                    /*0x302bf2c*/ string ToString();
                    /*0x302b7a8*/ void DoBeginScope(char scope, string key);
                    /*0x302b604*/ void DoEndScope(char scopeBegin, char scopeEnd);
                    /*0x302bc44*/ void DoAppendString(string val);
                    /*0x302b6d8*/ void PreCommon(string key, bool newHasElements);
                }

                class JsonUtil
                {
                    static /*0x302b4ac*/ string ToJson(object val);
                    static /*0x302c194*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer Value(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, object val);
                    static /*0x302c1a0*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer KeyValue(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, string key, object val);
                    static /*0x302d498*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer OptionalKeyValue(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, string key, object val);
                    static /*0x302caf0*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer DoKeyValue(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, string key, System.Exception e);
                    static /*0x302cc04*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer DoKeyValue(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, string key, System.Collections.IList val);
                    static /*0x1f3299c*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer DoKeyValue<T>(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, string key, System.Collections.Generic.IDictionary<string, T> val);
                    static /*0x302ced4*/ Glu.Plugins.GluAnalytics.Implementation.JsonStringer DoKeyValue(Glu.Plugins.GluAnalytics.Implementation.JsonStringer json, string key, System.Collections.IDictionary val);
                }
            }
        }
    }
}
