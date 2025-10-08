class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3635198*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x363528c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace PvzN3xtBattleGen
{
    class BattleGeneratorConstants
    {
        static int DefaultNumRows = 5;
    }

    class BattleGeneratorFactory
    {
        static /*0x3635294*/ PvzN3xtBattleGen.IBattleGenerator CreateBattleGenerator(Yeti.Data.WaveDatabase waveDatabase, Yeti.Data.CombatDatabase combatDatabase);
    }

    enum BattleGenLogCategory
    {
        None = 0,
        BattleGeneration = 2,
        Data = 4,
        All = 2147483647,
    }

    class BattleGenLog
    {
        static string LogName = "BattleGenLog";
        static /*0x0*/ PopCap.Logging.ILogger _log;

        static /*0x3636130*/ BattleGenLog();
        static /*0x3635440*/ PopCap.Logging.ILogger get_Logger();
        static /*0x3635498*/ void SetLevel(PopCap.Logging.LogLevel logLevel);
        static /*0x363556c*/ void SetCategories(PvzN3xtBattleGen.BattleGenLogCategory battleGenCategories);
        static /*0x3635640*/ void Debug(PvzN3xtBattleGen.BattleGenLogCategory category, string message);
        static /*0x3635750*/ void Debug(PvzN3xtBattleGen.BattleGenLogCategory category, string message, object context);
        static /*0x3635870*/ void Info(PvzN3xtBattleGen.BattleGenLogCategory category, string message);
        static /*0x3635980*/ void Info(PvzN3xtBattleGen.BattleGenLogCategory category, string message, object context);
        static /*0x3635aa0*/ void Warn(PvzN3xtBattleGen.BattleGenLogCategory category, string message);
        static /*0x3635bb0*/ void Warn(PvzN3xtBattleGen.BattleGenLogCategory category, string message, object context);
        static /*0x3635cd0*/ void Error(PvzN3xtBattleGen.BattleGenLogCategory category, string message);
        static /*0x3635de0*/ void Error(PvzN3xtBattleGen.BattleGenLogCategory category, string message, object context);
        static /*0x3635f00*/ void Exception(PvzN3xtBattleGen.BattleGenLogCategory category, System.Exception exception);
        static /*0x3636010*/ void Exception(PvzN3xtBattleGen.BattleGenLogCategory category, System.Exception exception, object context);
    }

    class DynamicDropDistributorFactory
    {
        static /*0x3636438*/ PvzN3xtBattleGen.IDynamicDropDistributor CreateInstance(Yeti.Data.CombatDatabase combatDatabase);
    }

    class DynamicSpawnTemplateStaticDataProvider
    {
        /*0x10*/ System.Collections.Generic.Dictionary<int, Yeti.Data.DynamicWaveSpawnTemplateGroupDefinition> _templateGroupMap;
        /*0x18*/ System.Collections.Generic.HashSet<int> _allTemplateIds;
        /*0x20*/ YetiSimCoreLib.Core.ObjectPool<System.Collections.Generic.HashSet<int>> _hashSetPool;

        /*0x3636584*/ DynamicSpawnTemplateStaticDataProvider(Yeti.Data.WaveDatabase waveDatabase);
        /*0x3636c4c*/ System.Collections.Generic.HashSet<int> GetAllTemplatesInGroup(int templateGroupId);
        /*0x3636cd4*/ void AddAllTemplatesInGroup(System.Collections.Generic.HashSet<int> set, int templateGroupId);
        /*0x3636d68*/ System.Collections.Generic.HashSet<int> GetAllTemplatesInGroupRecursive(int templateGroupId);
        /*0x3636e14*/ System.Collections.Generic.HashSet<int> GetFilteredList(Yeti.Data.DynamicWaveSpawnTemplateGroupType type, Google.Protobuf.Collections.RepeatedField<int> templateIds, Google.Protobuf.Collections.RepeatedField<int> subgroupIds, System.Collections.Generic.HashSet<int> currentList);
    }

    class DynamicWaveV2DefinitionProvider
    {
        /*0x10*/ Yeti.Data.DynamicWaveConfig _dynamicWaveConfig;
        /*0x18*/ System.Collections.Generic.Dictionary<int, Yeti.Data.DynamicWaveUnitConfig> _unitConfigById;
        /*0x20*/ System.Collections.Generic.Dictionary<int, Yeti.Data.DynamicWaveFormationConfig> _formationById;
        /*0x28*/ System.Collections.Generic.IList<Yeti.Data.DynamicWaveFormationConfig> <Formations>k__BackingField;

        /*0x3637430*/ DynamicWaveV2DefinitionProvider(Yeti.Data.WaveDatabase waveDatabase);
        /*0x3637538*/ DynamicWaveV2DefinitionProvider(Yeti.Data.GameSimDefinition simDefinition);
        /*0x3637bac*/ DynamicWaveV2DefinitionProvider();
        /*0x3637390*/ int get_NumZombiePositions();
        /*0x36373a8*/ float get_ZombiePositionDistributionFactor();
        /*0x36373c0*/ float get_HugeWaveZombiePositionDistributionFactor();
        /*0x36373d8*/ int get_GoodSolutionThresholdPercent();
        /*0x36373f0*/ int get_FlagZombieUnitId();
        /*0x3637408*/ int get_FlagZombieSpawnOffsetMs();
        /*0x3637420*/ System.Collections.Generic.IList<Yeti.Data.DynamicWaveFormationConfig> get_Formations();
        /*0x3637428*/ void set_Formations(System.Collections.Generic.IList<Yeti.Data.DynamicWaveFormationConfig> value);
        /*0x363751c*/ void Initialize(Yeti.Data.WaveDatabase waveDatabase);
        /*0x3637630*/ void Initialize(Yeti.Data.DynamicWaveConfig dynamicWaveConfig, System.Collections.Generic.IList<Yeti.Data.DynamicWaveUnitConfig> dynamicWaveUnits, System.Collections.Generic.IList<Yeti.Data.DynamicWaveFormationConfig> dynamicWaveFormations);
        /*0x3637c88*/ Yeti.Data.DynamicWaveUnitConfig GetUnitConfig(int unitId);
        /*0x3637cf8*/ bool TryGetUnitConfig(int unitId, ref Yeti.Data.DynamicWaveUnitConfig unitConfig);
        /*0x3637d6c*/ int GetZombiePower(int unitId);
        /*0x3637e30*/ int GetPlantPower(int unitId, int waveStartTimeInMs, int waveDurationInMs);
        /*0x3638328*/ int GetFeaturedSpawnWeight(int unitId);
        /*0x3638498*/ int GetSpawnWeight(int unitId);
        /*0x36385c4*/ bool TryGetWaveTierConfig(int par, int levelDifficultyTier, int waveDifficultyTier, ref PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
        /*0x3638fec*/ float Lerp(float a, float b, float t);
        /*0x36389e8*/ bool TryGetWaveDifficultyTierConfig(Yeti.Data.SkillRatingTierConfig skillRatingConfig, int levelDifficultyTier, int waveDifficultyTier, ref Yeti.Data.WaveDifficultyTierConfig config);
        /*0x3639080*/ bool CanSpawnAtWave(int unitId, int dynamicWaveNumber);
        /*0x3639478*/ bool CanSpawnForUnitTierLimits(int unitId, int unitTierLimit);
        /*0x36393ec*/ bool IsWaveNumberValid(int dynamicWaveNumber, Yeti.Data.DynamicWaveUnitSpawnRule.Types.WaveNumberRestrictionSpawnRule ruleData);
        /*0x3639528*/ bool TryGetSpawnCountLimitRule(int unitId, ref Yeti.Data.DynamicWaveUnitSpawnRule.Types.SpawnCountLimitSpawnRule spawnCountLimitRule);
        /*0x36398c0*/ Yeti.Data.DynamicWaveFormationConfig GetFormation(int difficultyModifierId);
    }

    interface IBattleGenerator
    {
        /*0x1f302cc*/ PvzN3xtBattleGen.BattleGeneratorResults GenerateStage(Yeti.Data.BattleElementaryDefinition battleDef);
        /*0x1f30394*/ PvzN3xtBattleGen.BattleGeneratorResults GenerateStage(Yeti.Data.BattleElementaryDefinition battleDef, PvzN3xtBattleGen.BattleGeneratorParameters parameters);
    }

    class BattleGeneratorParameters
    {
        /*0x10*/ int TargetDifficulty;
        /*0x18*/ long Seed;
        /*0x20*/ int PlayerAbilityRating;
        /*0x24*/ int WavesDelayMs;
        /*0x28*/ int TimeBetweenWavesExtensionMs;
        /*0x2c*/ int WaveDurationExtensionMs;

        /*0x3639930*/ BattleGeneratorParameters(int difficulty, long seed, int playerAbilityRating, int wavesDelayMs, int timeBetweenWavesExtensionMs, int waveDurationExtensionMs);
    }

    class BattleGeneratorResults
    {
        /*0x10*/ Yeti.Data.BattleGeneratedStage <StageData>k__BackingField;
        /*0x18*/ PvzN3xtBattleGen.BattleGeneratorReport <Report>k__BackingField;

        /*0x36399a8*/ BattleGeneratorResults();
        /*0x3639988*/ Yeti.Data.BattleGeneratedStage get_StageData();
        /*0x3639990*/ void set_StageData(Yeti.Data.BattleGeneratedStage value);
        /*0x3639998*/ PvzN3xtBattleGen.BattleGeneratorReport get_Report();
        /*0x36399a0*/ void set_Report(PvzN3xtBattleGen.BattleGeneratorReport value);
    }

    class BattleGeneratorReport
    {
        /*0x10*/ System.Collections.Generic.List<PvzN3xtBattleGen.DynamicWaveGeneratorReport> <DynamicWaveReports>k__BackingField;

        /*0x36399c0*/ BattleGeneratorReport();
        /*0x36399b0*/ System.Collections.Generic.List<PvzN3xtBattleGen.DynamicWaveGeneratorReport> get_DynamicWaveReports();
        /*0x36399b8*/ void set_DynamicWaveReports(System.Collections.Generic.List<PvzN3xtBattleGen.DynamicWaveGeneratorReport> value);
    }

    class DynamicWaveGeneratorReport
    {
        /*0x10*/ int <StartTimeInMs>k__BackingField;
        /*0x14*/ int <TargetDurationInMs>k__BackingField;
        /*0x18*/ int <OutputDurationInMs>k__BackingField;
        /*0x1c*/ int <TargetDifficulty>k__BackingField;
        /*0x20*/ int <OutputDifficulty>k__BackingField;
        /*0x28*/ System.Collections.Generic.List<int> <TemplateIds>k__BackingField;
        /*0x30*/ System.Collections.Generic.HashSet<PvzN3xtBattleGen.DynamicWaveErrorType> UniqueErrors;

        /*0x3639aa8*/ DynamicWaveGeneratorReport();
        /*0x3639a48*/ int get_StartTimeInMs();
        /*0x3639a50*/ void set_StartTimeInMs(int value);
        /*0x3639a58*/ int get_TargetDurationInMs();
        /*0x3639a60*/ void set_TargetDurationInMs(int value);
        /*0x3639a68*/ int get_OutputDurationInMs();
        /*0x3639a70*/ void set_OutputDurationInMs(int value);
        /*0x3639a78*/ int get_TargetDifficulty();
        /*0x3639a80*/ void set_TargetDifficulty(int value);
        /*0x3639a88*/ int get_OutputDifficulty();
        /*0x3639a90*/ void set_OutputDifficulty(int value);
        /*0x3639a98*/ System.Collections.Generic.List<int> get_TemplateIds();
        /*0x3639aa0*/ void set_TemplateIds(System.Collections.Generic.List<int> value);
    }

    enum DynamicWaveErrorType
    {
        None = 0,
        WaveNumberRestrictionFailedDueToFeaturedZombies = 1,
        PerLevelLimitFailedDueToFeaturedZombies = 2,
        PerWaveLimitFailedDueToFeaturedZombies = 3,
        FeaturedZombiesFailedToSpawnDueToUnitTierLimit = 4,
        ExceededMaxZombieLimitForWave = 5,
        FailedMinZombieLimitForWave = 6,
        ExceededZombiePowerDueToUnbreakableFormations = 7,
    }

    interface IDynamicDropDistributor
    {
        /*0x1f30ff0*/ void DistributeDropsIntoStage(Yeti.Data.BattleGeneratedStage stageToModify, PvzN3xtBattleGen.DynamicDropDistributorParameters parameters);
    }

    class DynamicDropDistributorParameters
    {
        /*0x10*/ Yeti.Data.BattleElementaryDefinition <BattleDef>k__BackingField;
        /*0x18*/ System.Nullable<int> <MaybeCascadeUnitId>k__BackingField;
        /*0x20*/ System.Collections.Generic.IReadOnlyList<Yeti.Data.DropDistribution> <ExternalDistributions>k__BackingField;

        /*0x3639b9c*/ DynamicDropDistributorParameters(Yeti.Data.BattleElementaryDefinition battleDef, System.Nullable<int> maybeCascadeUnitId, System.Collections.Generic.IReadOnlyList<Yeti.Data.DropDistribution> externalDistributions);
        /*0x3639b84*/ Yeti.Data.BattleElementaryDefinition get_BattleDef();
        /*0x3639b8c*/ System.Nullable<int> get_MaybeCascadeUnitId();
        /*0x3639b94*/ System.Collections.Generic.IReadOnlyList<Yeti.Data.DropDistribution> get_ExternalDistributions();
    }

    class SpawnCountMap
    {
        /*0x10*/ System.Collections.Generic.Dictionary<int, int> _dictionary;
        /*0x18*/ int _totalCount;

        /*0x363a12c*/ SpawnCountMap();
        /*0x3639bf0*/ void Increment(int unitId, int delta);
        /*0x3639d0c*/ int GetSpawnCount(int unitId);
        /*0x3639d88*/ int GetAllSpawnCount();
        /*0x3639d90*/ void Clear();
        /*0x3639de8*/ System.Collections.Generic.List<int> GetKeysWithPositiveCount();
    }

    class SpawnDelayCalculator
    {
        static /*0x363a1b4*/ int Calculate(Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDef, int numPositions, int positionIndex, float factor);
        static /*0x363a208*/ int Calculate(int durationInMs, int positionIndex, int numZombiePositions, float factor);
    }

    namespace Interface
    {
        class DynamicWaveGeneratorResults
        {
            /*0x10*/ System.Collections.Generic.List<Yeti.Data.BattleGeneratedWave> <WaveData>k__BackingField;
            /*0x18*/ PvzN3xtBattleGen.DynamicWaveGeneratorReport <Report>k__BackingField;

            /*0x363a33c*/ DynamicWaveGeneratorResults();
            /*0x363a31c*/ System.Collections.Generic.List<Yeti.Data.BattleGeneratedWave> get_WaveData();
            /*0x363a324*/ void set_WaveData(System.Collections.Generic.List<Yeti.Data.BattleGeneratedWave> value);
            /*0x363a32c*/ PvzN3xtBattleGen.DynamicWaveGeneratorReport get_Report();
            /*0x363a334*/ void set_Report(PvzN3xtBattleGen.DynamicWaveGeneratorReport value);
        }

        struct InterpolatedWaveDifficultyTierConfig
        {
            /*0x10*/ float TotalZombiePowerPerSecond;
            /*0x14*/ float MinNumberOfZombiesPerSecond;
            /*0x18*/ float MaxNumberOfZombiesPerSecond;
            /*0x1c*/ int UnitTierLimit;
            /*0x20*/ int NumberOfActiveLanes;

            /*0x363a344*/ int GetTotalZombiePower(int durationMs);
            /*0x363a3cc*/ int GetMinNumberOfZombies(int durationMs);
            /*0x363a3d8*/ int GetMaxNumberOfZombies(int durationMs);
        }

        class WaveDifficultyTierConfigUtils
        {
            static /*0x363a350*/ int MultiplyByDurationClamped(float value, int durationMs);
            static /*0x363822c*/ int MultiplyByDuration(float value, int durationMs);
        }
    }

    namespace Core
    {
        class BattleGenerator : PvzN3xtBattleGen.IBattleGenerator
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, Yeti.Data.SpawnTemplateDefinition> _spawnTemplatesById;
            /*0x18*/ PvzN3xtBattleGen.Core.DynamicWaveGenerator _dynamicWaveGenerator;
            /*0x20*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2 _dynamicWaveGeneratorV2;
            /*0x28*/ PvzN3xtBattleGen.Core.DynamicDifficultyV3WaveModifier _dynamicDifficultyV3WaveModifier;

            static /*0x363a3e4*/ System.Collections.Generic.Dictionary<int, Yeti.Data.SpawnTemplateDefinition> CreateSpawnTemplatesById(Yeti.Data.WaveDatabase waveDatabase);
            static /*0x363c044*/ Yeti.Data.BattleGeneratedWave CreateStallWave(Yeti.Data.WaveElementaryDefinition waveElementaryDefinition);
            static /*0x363ddd8*/ Yeti.Data.BattleGeneratedSpawnData ToBattleGeneratedSpawnData(Yeti.Data.WaveElementaryDefinition.Types.WaveUnitSpawnDefinition unitSpawn);
            static /*0x363dee8*/ Yeti.Data.BattleGeneratedSpawnData ToBattleGeneratedSpawnData(Yeti.Data.WaveElementaryDefinition.Types.WaveUnitSpawnDefinition unitSpawn, Yeti.Data.SpawnTemplateUnitDefinition templateSpawn);
            /*0x36352fc*/ BattleGenerator(Yeti.Data.WaveDatabase waveDatabase, Yeti.Data.CombatDatabase combatDatabase);
            /*0x363b080*/ PvzN3xtBattleGen.BattleGeneratorResults GenerateStage(Yeti.Data.BattleElementaryDefinition battleDef);
            /*0x363b0f8*/ PvzN3xtBattleGen.BattleGeneratorResults GenerateStage(Yeti.Data.BattleElementaryDefinition battleDef, PvzN3xtBattleGen.BattleGeneratorParameters parameters);
            /*0x363bf10*/ Yeti.Data.BattleGeneratedWave CreateStandardWave(Yeti.Data.WaveElementaryDefinition waveElementaryDefinition, System.Collections.Generic.HashSet<int> uniqueZombies);
            /*0x363d604*/ Yeti.Data.BattleGeneratedSpawnGroup CreateSpawnGroup(Yeti.Data.WaveElementaryDefinition waveElementaryDefinition, System.Collections.Generic.HashSet<int> uniqueZombies);
        }

        class DynamicDifficultyV3WaveModifier
        {
            /*0x363b078*/ DynamicDifficultyV3WaveModifier();
            /*0x363ceec*/ void ModifyWaveStartTimes(Yeti.Data.BattleGeneratedStage battleGeneratedStage, PvzN3xtBattleGen.BattleGeneratorParameters parameters);
            /*0x363d28c*/ int CalculateCascadeStartTime(Yeti.Data.BattleGeneratedStage battleGeneratedStage, Yeti.Data.BattleElementaryDefinition battleDef);
        }

        class DynamicDropDistributor : PvzN3xtBattleGen.IDynamicDropDistributor
        {
            /*0x10*/ YetiSimCoreCommon.Utils.CombatDefinitionProvider _combatDefinitionProvider;
            /*0x18*/ Yeti.Data.DynamicDropsConfig _dropsConfig;
            /*0x20*/ Yeti.Data.CascadeDatabase _cascadeDatabase;
            /*0x28*/ YetiSimCoreLib.Game.MtRandom _random;

            static /*0x363e3d0*/ System.Collections.Generic.List<Yeti.Data.BattleGeneratedSpawnData> GetPlayerFacingZombies(Yeti.Data.BattleGeneratedStage stage, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            static /*0x363ee70*/ void DistributeDropsForDistribution(Yeti.Data.DropDistribution distribution, System.Collections.Generic.IList<Yeti.Data.BattleGeneratedSpawnData> spawns, YetiSimCoreLib.Game.IRandomProvider random, System.Action<int, Yeti.Data.DynamicDropDefinition> assignDrop);
            static /*0x3640220*/ bool TryDrawFrom(System.Collections.Generic.IList<int> entries, YetiSimCoreLib.Game.IRandomProvider random, ref int entry);
            static /*0x364049c*/ Yeti.Data.UnitDropTableDefinition GetExistingDropTable(Yeti.Data.BattleGeneratedSpawnData spawn, System.Collections.Generic.IReadOnlyList<Yeti.Data.UnitDropTableDefinition> tables);
            static /*0x3640770*/ PvzN3xtBattleGen.Core.DynamicDropDistributor.DropTableContents FindOrCreateDropTableContents(int spawnIndex, System.Collections.Generic.Dictionary<int, PvzN3xtBattleGen.Core.DynamicDropDistributor.DropTableContents> tempDropTable, Yeti.Data.UnitDropTableDefinition assignedTable);
            static /*0x363f6b8*/ void AssignDropTableId(System.Collections.Generic.Dictionary<int, PvzN3xtBattleGen.Core.DynamicDropDistributor.DropTableContents> tempDropTable, System.Collections.Generic.IList<Yeti.Data.BattleGeneratedSpawnData> spawns, System.Collections.Generic.IList<Yeti.Data.UnitDropTableDefinition> dropTables);
            static /*0x3640cec*/ void ConfigureUnitDropItemDefinition(Yeti.Data.UnitDropItemDefinition dropItem, Yeti.Data.DynamicDropDefinition dynamicDropDefinition, Yeti.Data.DynamicDropsConfig config);
            static /*0x3640d8c*/ Yeti.Data.DynamicDropConfig GetDropConfig(Yeti.Data.DynamicDropConfig.DropTypeOneofCase dropType, Yeti.Data.DynamicDropsConfig config);
            static /*0x364107c*/ void ConfigureMoneyTokenDropItem(Yeti.Data.UnitDropItemDefinition dropItem, Yeti.Data.MoneyTokenDropDefinition dropDefinition, Yeti.Data.DynamicDropConfig moneyTokenDropConfig);
            static /*0x36410e0*/ void ConfigureCascadeTokenDropItem(Yeti.Data.UnitDropItemDefinition dropItem, Yeti.Data.CascadeTokenDropDefinition dropDefinition, Yeti.Data.DynamicDropConfig cascadeTokenDropConfig);
            static /*0x3641158*/ bool IsValidCascadeUnitForTokens(System.Nullable<int> maybeCascadeUnitId, Yeti.Data.CascadeDatabase cascadeDatabase);
            static /*0x363ed2c*/ Yeti.Data.DropDistribution GetCascadeTokenDistribution(System.Nullable<int> maybeCascadeUnitId, Yeti.Data.BattleElementaryDefinition battleDef, Yeti.Data.CascadeDatabase cascadeDatabase, Yeti.Data.DynamicDropsConfig dynamicDropsConfig);
            static /*0x3641294*/ int AscendingSpawnTime(Yeti.Data.BattleGeneratedSpawnData x, Yeti.Data.BattleGeneratedSpawnData y);
            /*0x3636510*/ DynamicDropDistributor(YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider, Yeti.Data.DynamicDropsConfig dropsConfig, Yeti.Data.CascadeDatabase cascadeDatabase, YetiSimCoreLib.Game.MtRandom random);
            /*0x363e008*/ void DistributeDropsIntoStage(Yeti.Data.BattleGeneratedStage stageToModify, PvzN3xtBattleGen.DynamicDropDistributorParameters parameters);

            class DropTableContents
            {
                /*0x10*/ System.Collections.Generic.List<Yeti.Data.UnitDropItemDefinition> _drops;
                /*0x18*/ System.Collections.Generic.Dictionary<Yeti.Data.UnitDropItemDefinition, int> _dropsByCount;
                /*0x20*/ int AssignedDropTableId;

                /*0x3640af8*/ DropTableContents();
                /*0x36412c8*/ System.Collections.Generic.IReadOnlyList<Yeti.Data.UnitDropItemDefinition> get_Drops();
                /*0x3640bd4*/ void Add(Yeti.Data.UnitDropItemDefinition dropItem);
                /*0x36412d0*/ bool IsEquivalentTo(PvzN3xtBattleGen.Core.DynamicDropDistributor.DropTableContents other);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Collections.Generic.KeyValuePair<int, PvzN3xtBattleGen.Core.DynamicDropDistributor.DropTableContents> kvp;

                /*0x3640ce4*/ <>c__DisplayClass11_0();
                /*0x3641660*/ bool <AssignDropTableId>b__0(PvzN3xtBattleGen.Core.DynamicDropDistributor.DropTableContents existingTable);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Collections.Generic.List<Yeti.Data.BattleGeneratedSpawnData> playerFacingZombies;
                /*0x18*/ Yeti.Data.BattleGeneratedStage stageToModify;
                /*0x20*/ System.Collections.Generic.Dictionary<int, PvzN3xtBattleGen.Core.DynamicDropDistributor.DropTableContents> tempDropTable;
                /*0x28*/ PvzN3xtBattleGen.Core.DynamicDropDistributor <>4__this;

                /*0x363e3c8*/ <>c__DisplayClass5_0();
                /*0x3641730*/ void <DistributeDropsIntoStage>g__AssignDrop|0(int spawnIndex, Yeti.Data.DynamicDropDefinition dynamicDrop);
            }
        }

        class DynamicWaveGenerator
        {
            static int DefaultNumSolutions = 5;
            /*0x10*/ YetiSimCoreLib.Game.MtRandom _random;
            /*0x18*/ PvzN3xtBattleGen.DynamicSpawnTemplateStaticDataProvider _templateStaticDataProvider;
            /*0x20*/ System.Collections.Generic.List<Yeti.Data.DynamicWaveSpawnTemplateDefinition> _allSpawnTemplates;
            /*0x28*/ System.Collections.Generic.Dictionary<int, Yeti.Data.DynamicWaveSpawnTemplateDefinition> _spawnTemplateMapping;
            /*0x30*/ System.Collections.Generic.Dictionary<int, Yeti.Data.DynamicWaveSpawnTagDefinition> _tagIdToDefinitionMapping;
            /*0x38*/ System.Collections.Generic.IComparer<Yeti.Data.DynamicWaveSpawnTemplateDefinition> _highestDifficultySorter;
            /*0x40*/ System.Collections.Generic.HashSet<Yeti.Data.DynamicWaveSpawnTemplateDefinition> _validSpawnTemplatesForWaveLocalList;
            /*0x48*/ System.Collections.Generic.HashSet<int> _groupTemplatesLocalList;
            /*0x50*/ System.Collections.Generic.List<Yeti.Data.DynamicWaveSpawnTemplateDefinition> _filteredSpawnTemplatesLocalList;
            /*0x58*/ System.Collections.Generic.List<int> _validUnitIdLocalList;
            /*0x60*/ System.Collections.Generic.List<PvzN3xtBattleGen.Core.DynamicWaveSolution> _solutionsLocalList;
            /*0x68*/ YetiSimCoreLib.Core.ObjectPool<PvzN3xtBattleGen.Core.DynamicWaveSolution> _solutionPool;
            /*0x70*/ int _numSolutions;
            /*0x74*/ float _goodSolutionDifficultyRatioThreshold;

            static /*0x3642090*/ int SortByHighestDifficulty(Yeti.Data.DynamicWaveSpawnTemplateDefinition x, Yeti.Data.DynamicWaveSpawnTemplateDefinition y);
            static /*0x3642d78*/ Yeti.Data.BattleGeneratedSpawnLaneData CreateSpawnLaneData(Yeti.Data.DynamicWaveSpawnTemplateDefinition template, int baseLaneIndex, int laneOffset);
            /*0x363a734*/ DynamicWaveGenerator(Yeti.Data.WaveDatabase waveDatabase);
            /*0x363b9ec*/ void ResetWithSeed(PvzN3xtBattleGen.BattleGeneratorParameters parameters);
            /*0x363c11c*/ PvzN3xtBattleGen.Interface.DynamicWaveGeneratorResults CreateDynamicWave(Yeti.Data.WaveElementaryDefinition.Types.DynamicWaveDefinition dynamicWaveDef, Yeti.Data.BattleElementaryDefinition battleDef, PvzN3xtBattleGen.BattleGeneratorParameters parameters);
            /*0x364189c*/ PvzN3xtBattleGen.Core.DynamicWaveSolution GenerateSolution(System.Collections.Generic.HashSet<Yeti.Data.DynamicWaveSpawnTemplateDefinition> spawnTemplates, int targetDifficulty, int targetDuration, int numRandomPicks);
            /*0x3641a90*/ System.Collections.Generic.List<Yeti.Data.BattleGeneratedWave> CreateWavesFromSolution(PvzN3xtBattleGen.Core.DynamicWaveSolution dynamicWaveSolution, int waveStartTimeInMs, Yeti.Data.BattleElementaryDefinition battleDef);
            /*0x36420c4*/ Yeti.Data.BattleGeneratedWave CreateWaveForTemplate(Yeti.Data.BattleElementaryDefinition battleDef, Yeti.Data.DynamicWaveSpawnTemplateDefinition randomValidTemplate, int templateSpawnTime);
            /*0x3641818*/ System.Collections.Generic.HashSet<Yeti.Data.DynamicWaveSpawnTemplateDefinition> GetValidSpawnTemplatesForWave(Yeti.Data.BattleElementaryDefinition battleDef, Yeti.Data.WaveElementaryDefinition.Types.DynamicWaveDefinition dynamicWaveDefinition);
            /*0x3643030*/ void AddTemplatesFromGroup(int groupId, System.Collections.Generic.HashSet<Yeti.Data.DynamicWaveSpawnTemplateDefinition> validSpawnTemplates, Yeti.Data.BattleElementaryDefinition battleDef);
            /*0x36432c0*/ bool DoesBattleSupportTemplate(Yeti.Data.BattleElementaryDefinition battleDef, Yeti.Data.DynamicWaveSpawnTemplateDefinition spawnTemplate);
            /*0x3643608*/ bool BattleHasAtLeastOneZombieInTag(Yeti.Data.BattleElementaryDefinition battleDef, Yeti.Data.DynamicWaveSpawnTagDefinition tagDefinition);
            /*0x3641e98*/ void FilterSpawnTemplatesForDifficultyAndDuration(System.Collections.Generic.List<Yeti.Data.DynamicWaveSpawnTemplateDefinition> validSpawnTemplates, int remainingDifficultyToFill, int remainingDurationToFill);
            /*0x3642580*/ int GetRandomLaneFromSpawnTemplate(Yeti.Data.DynamicWaveSpawnTemplateDefinition template);
            /*0x364292c*/ int GetRandomUnitFromTag(int tagId, Yeti.Data.BattleElementaryDefinition battleDef);
            /*0x3641d44*/ PvzN3xtBattleGen.DynamicWaveGeneratorReport CreateReport(int targetDifficulty, int targetDurationInMs, int waveStartTimeInMs, PvzN3xtBattleGen.Core.DynamicWaveSolution dynamicWaveSolution);
        }

        class DynamicWaveGeneratorV2ZombieFormationAdjuster
        {
            /*0x10*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2Context _context;

            static /*0x36465cc*/ bool AreSameLane(Yeti.Data.BattleGeneratedSpawnData spawnDataA, Yeti.Data.BattleGeneratedSpawnData spawnDataB);
            /*0x3643934*/ DynamicWaveGeneratorV2ZombieFormationAdjuster(PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2Context context);
            /*0x3643964*/ void AdjustSpawnsForFormationDifficultyModifiers(Yeti.Data.BattleGeneratedSpawnGroup spawnGroup, System.Collections.Generic.List<int> zombiesToSpawn, int waveZombiePower, System.Collections.Generic.List<int> importantZombies, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig, Yeti.Data.DynamicWaveDefinitionV2 waveDef);
            /*0x36442a8*/ int DetermineFormationsActivated(Yeti.Data.BattleGeneratedSpawnGroup spawnGroup, System.Collections.Generic.List<int> zombiesToSpawn, System.Collections.Generic.List<int> relevantFormationIds, System.Collections.Generic.List<int> spawnIndexesInvolvedInFormations);
            /*0x364588c*/ void TryBreakFormationsToFitBudgetInSpawnGroup(Yeti.Data.BattleGeneratedSpawnGroup spawnGroup, System.Collections.Generic.List<int> formationIds, int adjustedZombiePower, int waveZombiePower);
            /*0x3644cdc*/ System.Collections.Generic.List<Yeti.Data.BattleGeneratedSpawnData> TryRemoveUnimportantZombieWithoutBreakingFormations(Yeti.Data.BattleGeneratedSpawnGroup spawnGroup, int waveZombiePower, int adjustedZombiePower, System.Collections.Generic.List<int> importantZombies, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig, System.Collections.Generic.List<int> spawnIndexesInvolvedInFormations, Yeti.Data.DynamicWaveDefinitionV2 waveDef);
            /*0x3645ea8*/ bool IsFormationActive(Yeti.Data.BattleGeneratedSpawnData frontSpawn, Yeti.Data.BattleGeneratedSpawnData backSpawn, Yeti.Data.DynamicWaveFormationOneOfWrapper.Types.UnitInFrontOfOtherFormationConfig unitInFrontOfOtherFormation);
        }

        class DynamicWaveGeneratorV2ZombiePositionSlotter
        {
            static int LaneWeightPrecision = 1000;
            /*0x10*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2Context _context;
            /*0x18*/ PvzN3xtBattleGen.Core.LaneTargetingSelector _laneTargetingSelector;

            /*0x36465f4*/ DynamicWaveGeneratorV2ZombiePositionSlotter(PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2Context context);
            /*0x3646794*/ void SlotZombiesIntoSpawnGroup(Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDef, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveDifficultyTierConfig, System.Collections.Generic.List<int> zombiesToSpawn, Yeti.Data.BattleGeneratedSpawnGroup spawnGroup, PvzN3xtBattleGen.Core.LaneTargetingParameters laneTargetingParameters);
            /*0x3646c98*/ void AddLanesToUse(PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveDifficultyTierConfig, System.Collections.Generic.List<int> zombiesToSpawn, PvzN3xtBattleGen.Core.LaneTargetingParameters laneTargetingParameters);
            /*0x3647be8*/ int GetSpawnLaneIndex(int zombieId, Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Core.LaneTargetingParameters laneTargetingParameters);
            /*0x3647ec8*/ void AddLaneSelectionWeights(int unitId, System.Collections.Generic.List<int> laneIndexes, System.Collections.Generic.List<int> laneSelectionWeights, PvzN3xtBattleGen.Core.LaneTargetingParameters laneTargetingParameters);
            /*0x364727c*/ int AdjustPositionIndexForSpawnRules(int unitId, int numZombiePositions, int positionIndex);
        }

        class DynamicWaveGeneratorV2ZombieSpawnDeterminer
        {
            /*0x10*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2Context _context;
            /*0x18*/ System.Collections.Generic.IComparer<int> _stableSortByUnusedZombiesComparer;
            /*0x20*/ System.Collections.Generic.List<int> _reusableListForZombieTeam;
            /*0x28*/ System.Collections.Generic.IComparer<int> _sortByZombiePowerComparer;
            /*0x30*/ int _previousWaveUnitTierLimit;

            /*0x3648c14*/ DynamicWaveGeneratorV2ZombieSpawnDeterminer(PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2Context context);
            /*0x3648d80*/ System.Collections.Generic.List<int> DetermineZombieSpawns(Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDefinitionV2, PvzN3xtBattleGen.Core.DynamicWaveV2SharedParameters sharedParameters, int totalZombiePower, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364ca28*/ void MergeZombies(System.Collections.Generic.List<int> selectedZombies, System.Collections.Generic.List<int> zombiesSortedByLowestPower, int numMerges, int powerBudgetRemaining, Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364cfd0*/ void SplitZombies(System.Collections.Generic.List<int> zombiesToSpawn, System.Collections.Generic.List<int> zombiesSortedByLowestPower, int numSplits, int powerBudgetRemaining, Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364d708*/ int StableSortByUnusedZombiesFirst(int x, int y);
            /*0x364d85c*/ int SortByZombiePower(int unitIdA, int unitIdB);
            /*0x364c67c*/ void SelectZombiesUsingWeightedSpawn(System.Collections.Generic.List<int> zombiesToSpawn, System.Collections.Generic.List<int> zombiesSortedByLowestPower, Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Core.DynamicWaveV2SharedParameters sharedParameters, int waveZombiePower, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364d5ac*/ bool CanZombiesSpawnForWave(int zombieAId, int zombieBId, int splitPowerBudget, Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364c5b4*/ bool CanZombieSpawnForWave(int unitId, int waveZombiePower, Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364c58c*/ int GetUnitTierLimit(Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364dff4*/ bool CanSpawnForSpawnCountLimits(int unitId);
            /*0x364d8c0*/ YetiSimCoreData.Utils.WeightedDrawBag<PvzN3xtBattleGen.Core.WeightedIntItem> FillWeightedDrawBag(Yeti.Data.DynamicWaveDefinitionV2 waveDef, PvzN3xtBattleGen.Core.DynamicWaveV2SharedParameters sharedParameters, int waveZombiePower, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
            /*0x364d580*/ void UpdatePreviousWaveUnitTierLimit(Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDefinitionV2, PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig waveTierConfig);
        }

        class DynamicWaveSolution
        {
            /*0x10*/ int <TotalDifficulty>k__BackingField;
            /*0x14*/ int <TotalDurationInMs>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<int> _selectedTemplateIds;

            /*0x364e0cc*/ DynamicWaveSolution();
            /*0x364e0a4*/ System.Collections.Generic.List<int> get_SelectedTemplateIds();
            /*0x364e0ac*/ int get_TotalDifficulty();
            /*0x364e0b4*/ void set_TotalDifficulty(int value);
            /*0x364e0bc*/ int get_TotalDurationInMs();
            /*0x364e0c4*/ void set_TotalDurationInMs(int value);
            /*0x3641dfc*/ void Clear();
            /*0x3641f74*/ void AddTemplate(YetiSimCoreLib.Game.IRandomProvider rng, Yeti.Data.DynamicWaveSpawnTemplateDefinition template);
        }

        class LaneTargetingSelector
        {
            static int InvalidLaneIndex = -1;
            /*0x10*/ YetiSimCoreLib.Game.IRandomProvider _random;
            /*0x18*/ YetiSimCoreCommon.Utils.IntListPool _intListPool;
            /*0x20*/ System.Collections.Generic.List<int> _countsPerLaneCacheForSorting;
            /*0x28*/ System.Comparison<int> _sortByLowest;
            /*0x30*/ System.Comparison<int> _sortByHighest;

            static /*0x364e5f4*/ int GetNumUniqueCounts(System.Collections.Generic.List<int> countsPerLane, System.Collections.Generic.List<int> validLanes);
            /*0x3646694*/ LaneTargetingSelector(YetiSimCoreLib.Game.IRandomProvider random, YetiSimCoreCommon.Utils.IntListPool intListPool);
            /*0x3648b0c*/ int GetTargetedLaneIndex(Yeti.Data.LaneSelectionDefinition.Types.UnitCountLaneSelectionDefinition unitCountLaneSelectionDef, PvzN3xtBattleGen.Core.LaneTargetingParameters laneTargetingParameters);
            /*0x364e154*/ int GetTargetedLaneIndex(Yeti.Data.LaneSelectionSortType sortType, int nthUniquePick, System.Collections.Generic.List<int> countsPerLane, int minCount, int maxCount);
            /*0x364e1e8*/ int GetLaneIndexWithNthUniqueCount(System.Collections.Generic.List<int> countsPerLane, int nthUniquePick, int minCount, int maxCount, System.Comparison<int> sortMethod);
            /*0x364e6f4*/ int CompareLaneIndexByLowestCount(int laneIndexA, int laneIndexB);
            /*0x364e78c*/ int CompareLaneIndexByHighestCount(int laneIndexA, int laneIndexB);
            /*0x3648b6c*/ int GetTargetedLaneIndex(Yeti.Data.LaneSelectionDefinition.Types.UnitTagCountLaneSelectionDefinition dataDef, PvzN3xtBattleGen.Core.LaneTargetingParameters laneTargetingParameters);
        }

        class WeightedIntItem : YetiSimCoreData.Utils.IWeightedItem<PvzN3xtBattleGen.Core.WeightedIntItem>
        {
            /*0x10*/ int <Weight>k__BackingField;
            /*0x14*/ int <IntValue>k__BackingField;

            /*0x364e84c*/ WeightedIntItem();
            /*0x364e828*/ int get_Weight();
            /*0x364e830*/ void set_Weight(int value);
            /*0x364e838*/ int get_IntValue();
            /*0x364e840*/ void set_IntValue(int value);
            /*0x364e848*/ PvzN3xtBattleGen.Core.WeightedIntItem get_Item();
        }

        struct DynamicWaveV2SharedParameters
        {
            /*0x10*/ int LevelDifficultyTier;
            /*0x18*/ System.Collections.Generic.IList<int> DynamicWaveZombiePool;
            /*0x20*/ System.Collections.Generic.IList<Yeti.Data.UnitPreSpawnData> PreSpawnedUnits;

            /*0x363b9a8*/ DynamicWaveV2SharedParameters(Yeti.Data.BattleElementaryDefinition battleDef);
            /*0x364e854*/ DynamicWaveV2SharedParameters(Yeti.Data.SharedDynamicWaveData sharedDynamicWaveData);
        }

        class LaneTargetingParameters
        {
            /*0x10*/ System.Collections.Generic.List<int> PlantsPerLane;
            /*0x18*/ System.Collections.Generic.List<int> ZombiesPerLane;
            /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> TagCountsPerLane;

            /*0x363beb0*/ LaneTargetingParameters(System.Collections.Generic.List<int> plantsPerLane, System.Collections.Generic.List<int> zombiesPerLane, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> tagsPerLane);
        }

        class DynamicWaveGeneratorV2Context
        {
            /*0x10*/ YetiSimCoreLib.Game.MtRandom Random;
            /*0x18*/ YetiSimCoreCommon.Utils.IntListPool IntListPool;
            /*0x20*/ System.Collections.Generic.List<Yeti.Data.BattleGeneratedSpawnData> ReusableSpawnDataList;
            /*0x28*/ YetiSimCoreLib.Core.ObjectPool<PvzN3xtBattleGen.Core.WeightedIntItem> WeightedItemPool;
            /*0x30*/ YetiSimCoreData.Utils.WeightedDrawBag<PvzN3xtBattleGen.Core.WeightedIntItem> WeightedDrawBag;
            /*0x38*/ PvzN3xtBattleGen.DynamicWaveV2DefinitionProvider Config;
            /*0x40*/ YetiSimCoreCommon.Utils.CombatDefinitionProvider CombatConfig;
            /*0x48*/ int DynamicWaveIndex;
            /*0x50*/ System.Collections.Generic.List<int> UnusedZombieTeam;
            /*0x58*/ PvzN3xtBattleGen.SpawnCountMap LevelUnitSpawnCounts;
            /*0x60*/ PvzN3xtBattleGen.SpawnCountMap WaveUnitSpawnCounts;
            /*0x68*/ System.Collections.Generic.List<int> UsedLanes;
            /*0x70*/ System.Collections.Generic.List<int> UnusedLanes;
            /*0x78*/ System.Collections.Generic.HashSet<PvzN3xtBattleGen.DynamicWaveErrorType> Errors;
            /*0x80*/ System.Collections.Generic.IComparer<Yeti.Data.BattleGeneratedSpawnData> _sortSpawnDataByTimeComparer;

            /*0x364e898*/ DynamicWaveGeneratorV2Context(PvzN3xtBattleGen.DynamicWaveV2DefinitionProvider config, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatConfig);
            /*0x3648804*/ void ReleaseWeightedItemsToPool(YetiSimCoreData.Utils.WeightedDrawBag<PvzN3xtBattleGen.Core.WeightedIntItem> weightedDrawBag);
            /*0x364620c*/ string UnitIdsToDebugString(System.Collections.Generic.IList<int> unitIds);
            /*0x364c394*/ string UnitIdToDebugString(int unitId);
            /*0x3647164*/ void Shuffle(System.Collections.Generic.List<int> zombiesToSpawn);
            /*0x364574c*/ void SortSpawnDataByTime(Yeti.Data.BattleGeneratedSpawnGroup spawnGroup);
            /*0x364ec1c*/ int SortSpawnDataByTime(Yeti.Data.BattleGeneratedSpawnData x, Yeti.Data.BattleGeneratedSpawnData y);
            /*0x3645288*/ string GeneratedSpawnsToDebugString(System.Collections.Generic.IList<Yeti.Data.BattleGeneratedSpawnData> spawns);
        }

        class DynamicWaveGeneratorV2
        {
            /*0x10*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2Context _context;
            /*0x18*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2ZombieSpawnDeterminer _zombieSpawnDeterminer;
            /*0x20*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2ZombiePositionSlotter _zombiePositionSlotter;
            /*0x28*/ PvzN3xtBattleGen.Core.DynamicWaveGeneratorV2ZombieFormationAdjuster _zombieFormationAdjuster;
            /*0x30*/ PvzN3xtBattleGen.Interface.InterpolatedWaveDifficultyTierConfig _emptyWaveTierConfig;

            /*0x364ec50*/ DynamicWaveGeneratorV2(Yeti.Data.WaveDatabase waveDatabase, Yeti.Data.CombatDatabase combatDatabase);
            /*0x363b008*/ DynamicWaveGeneratorV2(Yeti.Data.WaveDatabase waveDatabase, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            /*0x364ee4c*/ DynamicWaveGeneratorV2(Yeti.Data.GameSimDefinition simDefinition);
            /*0x364ecf4*/ DynamicWaveGeneratorV2(PvzN3xtBattleGen.DynamicWaveV2DefinitionProvider waveV2DefinitionProvider, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            /*0x363ba10*/ void ResetWithSeed(PvzN3xtBattleGen.BattleGeneratorParameters parameters, PvzN3xtBattleGen.Core.DynamicWaveV2SharedParameters battleDef);
            /*0x363c4b0*/ PvzN3xtBattleGen.Interface.DynamicWaveGeneratorResults CreateDynamicWave(Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDef, PvzN3xtBattleGen.Core.DynamicWaveV2SharedParameters sharedParameters, PvzN3xtBattleGen.BattleGeneratorParameters parameters, PvzN3xtBattleGen.Core.LaneTargetingParameters laneTargetingParameters);
            /*0x364eee4*/ int CalculateZombiePowerForPrespawnedPlants(PvzN3xtBattleGen.Core.DynamicWaveV2SharedParameters sharedParameters, Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDef);
            /*0x364f30c*/ void AddFlagZombieForHugeWave(Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDef, Yeti.Data.BattleGeneratedSpawnGroup spawnGroup);
            /*0x364fba0*/ int GetEarliestSpawnTime(Yeti.Data.BattleGeneratedSpawnGroup spawnGroup, Yeti.Data.DynamicWaveDefinitionV2 dynamicWave);
            /*0x364f870*/ void SpreadZombiesOutForExtraWaveDurationExtension(Yeti.Data.BattleGeneratedSpawnGroup spawnGroup, Yeti.Data.DynamicWaveDefinitionV2 dynamicWaveDef, PvzN3xtBattleGen.BattleGeneratorParameters parameters);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 76BB5E39524682B4714F1B604CF62DE4D1538B0EF1F735E2C3FBB194BACFBFAA;
    static /*0x10ee*/ <PrivateImplementationDetails> A81D8B0138B2A157BB6F7A83749AA139D0DF1B6BC55EC24BA0144C5F93C02A19;

    struct __StaticArrayInitTypeSize=1694
    {
    }

    struct __StaticArrayInitTypeSize=4334
    {
    }
}
