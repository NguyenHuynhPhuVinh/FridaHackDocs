class <Module>
{
}

namespace YetiSimCoreData
{
    namespace Utils
    {
        interface IWeightedItem<T>
        {
            /*0x1f2ffc8*/ int get_Weight();
            /*0x1ffc854*/ T get_Item();
        }

        class WeightedDrawBag<T>
        {
            /*0x0*/ System.Collections.Generic.ICollection<T> <WeightedItems>k__BackingField;
            /*0x0*/ int <Sum>k__BackingField;

            /*0x1f309e4*/ WeightedDrawBag();
            /*0x1f30214*/ System.Collections.Generic.ICollection<T> get_WeightedItems();
            /*0x1f2ffc8*/ int get_Sum();
            /*0x1f30b78*/ void set_Sum(int value);
            /*0x1f309e4*/ void Clear();
            /*0x1ffc854*/ void Add(T item);
            /*0x1ffc854*/ T DrawWithoutRemoving(YetiSimCoreLib.Game.IRandomProvider random);
            /*0x1f2fe14*/ bool HasItems();
        }
    }
}

namespace YetiSmCoreCommon
{
    namespace Utils
    {
        class UnitSpawnedUnitListGenerator
        {
            static /*0x4130fa4*/ System.Collections.Generic.IEnumerable<int> GetSpawnedUnitIdsByUnitAttributes(Yeti.Data.UnitDefinition unitDef);
            static /*0x4131058*/ System.Collections.Generic.IEnumerable<int> GetSpawnedUnitIdsForUnit(YetiSimCoreLib.Game.AbilityDatabase abilityDatabase, Yeti.Data.UnitDefinition unitDef);
            static /*0x4131128*/ System.Collections.Generic.IEnumerable<int> GetSpawnedUnitIdsForAbility(YetiSimCoreLib.Game.AbilityDatabase abilityDatabase, int abilityId);
            static /*0x41311bc*/ System.Collections.Generic.IEnumerable<int> GetSpawnedUnitIdsFromAbilities(YetiSimCoreLib.Game.AbilityDatabase abilityDatabase, Yeti.Data.UnitDefinition unitDef);
            static /*0x413112c*/ System.Collections.Generic.IEnumerable<int> GetSpawnedUnitIdsFromAbilityId(YetiSimCoreLib.Game.AbilityDatabase abilityDatabase, int abilityId);
            static /*0x41312c0*/ System.Collections.IEnumerable GetUnitsSpawnedByUnitActions(System.Collections.Generic.IReadOnlyList<Yeti.Data.AbilityActionDefintion> actions);

            class <GetSpawnedUnitIdsByUnitAttributes>d__0 : System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ int <>2__current;
                /*0x18*/ int <>l__initialThreadId;
                /*0x20*/ Yeti.Data.UnitDefinition unitDef;
                /*0x28*/ Yeti.Data.UnitDefinition <>3__unitDef;
                /*0x30*/ System.Collections.Generic.IEnumerator<Yeti.Data.UnitAttributeDefinition> <>7__wrap1;
                /*0x38*/ Yeti.Data.UnitAttributeDefinition <attribute>5__3;
                /*0x40*/ Yeti.Data.UnitAttributeDefinition.Types.UnitFormationAttribute <formation>5__4;

                /*0x4131024*/ <GetSpawnedUnitIdsByUnitAttributes>d__0(int <>1__state);
                /*0x4131374*/ void System.IDisposable.Dispose();
                /*0x41313a0*/ bool MoveNext();
                /*0x413179c*/ void <>m__Finally1();
                /*0x413184c*/ int System.Collections.Generic.IEnumerator<System.Int32>.get_Current();
                /*0x4131854*/ void System.Collections.IEnumerator.Reset();
                /*0x413188c*/ object System.Collections.IEnumerator.get_Current();
                /*0x41318b4*/ System.Collections.Generic.IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();
                /*0x4131958*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetSpawnedUnitIdsForUnit>d__1 : System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ int <>2__current;
                /*0x18*/ int <>l__initialThreadId;
                /*0x20*/ YetiSimCoreLib.Game.AbilityDatabase abilityDatabase;
                /*0x28*/ YetiSimCoreLib.Game.AbilityDatabase <>3__abilityDatabase;
                /*0x30*/ Yeti.Data.UnitDefinition unitDef;
                /*0x38*/ Yeti.Data.UnitDefinition <>3__unitDef;
                /*0x40*/ System.Collections.Generic.IEnumerator<int> <>7__wrap1;

                /*0x41310f4*/ <GetSpawnedUnitIdsForUnit>d__1(int <>1__state);
                /*0x413195c*/ void System.IDisposable.Dispose();
                /*0x4131994*/ bool MoveNext();
                /*0x4131dcc*/ void <>m__Finally1();
                /*0x4131e7c*/ void <>m__Finally2();
                /*0x4131f2c*/ int System.Collections.Generic.IEnumerator<System.Int32>.get_Current();
                /*0x4131f34*/ void System.Collections.IEnumerator.Reset();
                /*0x4131f6c*/ object System.Collections.IEnumerator.get_Current();
                /*0x4131f94*/ System.Collections.Generic.IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();
                /*0x4132048*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetSpawnedUnitIdsFromAbilities>d__4 : System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ int <>2__current;
                /*0x18*/ int <>l__initialThreadId;
                /*0x20*/ Yeti.Data.UnitDefinition unitDef;
                /*0x28*/ Yeti.Data.UnitDefinition <>3__unitDef;
                /*0x30*/ YetiSimCoreLib.Game.AbilityDatabase abilityDatabase;
                /*0x38*/ YetiSimCoreLib.Game.AbilityDatabase <>3__abilityDatabase;
                /*0x40*/ System.Collections.Generic.IEnumerator<Yeti.Data.UnitBehaviorDefinition> <>7__wrap1;
                /*0x48*/ System.Collections.Generic.IEnumerator<Yeti.Data.UnitAbilityDefinition> <>7__wrap2;
                /*0x50*/ System.Collections.Generic.IEnumerator<int> <>7__wrap3;

                /*0x4131258*/ <GetSpawnedUnitIdsFromAbilities>d__4(int <>1__state);
                /*0x413204c*/ void System.IDisposable.Dispose();
                /*0x413216c*/ bool MoveNext();
                /*0x4132958*/ void <>m__Finally1();
                /*0x41328a8*/ void <>m__Finally2();
                /*0x41327f8*/ void <>m__Finally3();
                /*0x4132a08*/ int System.Collections.Generic.IEnumerator<System.Int32>.get_Current();
                /*0x4132a10*/ void System.Collections.IEnumerator.Reset();
                /*0x4132a48*/ object System.Collections.IEnumerator.get_Current();
                /*0x4132a70*/ System.Collections.Generic.IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();
                /*0x4132b24*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetSpawnedUnitIdsFromAbilityId>d__5 : System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ int <>2__current;
                /*0x18*/ int <>l__initialThreadId;
                /*0x20*/ YetiSimCoreLib.Game.AbilityDatabase abilityDatabase;
                /*0x28*/ YetiSimCoreLib.Game.AbilityDatabase <>3__abilityDatabase;
                /*0x30*/ int abilityId;
                /*0x34*/ int <>3__abilityId;
                /*0x38*/ System.Collections.Generic.IEnumerator<Yeti.Data.AbilityTimelineGroupDefinition> <>7__wrap1;
                /*0x40*/ System.Collections.Generic.IEnumerator<Yeti.Data.AbilityTimelineDefinition> <>7__wrap2;
                /*0x48*/ System.Collections.IEnumerator <>7__wrap3;

                /*0x413128c*/ <GetSpawnedUnitIdsFromAbilityId>d__5(int <>1__state);
                /*0x4132b28*/ void System.IDisposable.Dispose();
                /*0x4132c48*/ bool MoveNext();
                /*0x41334e8*/ void <>m__Finally1();
                /*0x4133438*/ void <>m__Finally2();
                /*0x413337c*/ void <>m__Finally3();
                /*0x4133598*/ int System.Collections.Generic.IEnumerator<System.Int32>.get_Current();
                /*0x41335a0*/ void System.Collections.IEnumerator.Reset();
                /*0x41335d8*/ object System.Collections.IEnumerator.get_Current();
                /*0x4133600*/ System.Collections.Generic.IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();
                /*0x41336ac*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetUnitsSpawnedByUnitActions>d__6 : System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Collections.Generic.IReadOnlyList<Yeti.Data.AbilityActionDefintion> actions;
                /*0x30*/ System.Collections.Generic.IReadOnlyList<Yeti.Data.AbilityActionDefintion> <>3__actions;
                /*0x38*/ System.Collections.Generic.IEnumerator<Yeti.Data.AbilityActionDefintion> <>7__wrap1;
                /*0x40*/ System.Collections.Generic.IEnumerator<Yeti.Data.AbilityEffectWrapper> <>7__wrap2;
                /*0x48*/ System.Collections.IEnumerator <>7__wrap3;

                /*0x4131340*/ <GetUnitsSpawnedByUnitActions>d__6(int <>1__state);
                /*0x41336b0*/ void System.IDisposable.Dispose();
                /*0x41337d4*/ bool MoveNext();
                /*0x413401c*/ void <>m__Finally1();
                /*0x4133f6c*/ void <>m__Finally2();
                /*0x4133eb0*/ void <>m__Finally3();
                /*0x41340cc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x41340d4*/ void System.Collections.IEnumerator.Reset();
                /*0x413410c*/ object System.Collections.IEnumerator.get_Current();
                /*0x4134114*/ System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
                /*0x41341b8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }
    }
}

namespace YetiSimCoreCommon
{
    namespace Utils
    {
        class CombatDefinitionProvider
        {
            static string PlantTag = "Plant";
            static string ZombieTag = "Zombie";
            static string NeutralTag = "Neutral";
            static string SunProducerTag = "SunProducer";
            /*0x10*/ System.Collections.Generic.HashSet<string> _allTags;
            /*0x18*/ System.Collections.Generic.Dictionary<int, Yeti.Data.UnitDefinition> _unitsById;
            /*0x20*/ System.Collections.Generic.Dictionary<int, Yeti.Data.UnitTag> _unitTagsById;
            /*0x28*/ System.Collections.Generic.Dictionary<int, Yeti.Data.ThreatVectorDefinition> _threatVectorById;
            /*0x30*/ System.Collections.Generic.Dictionary<int, Yeti.Data.AbilityDefinition> _abilitiesById;
            /*0x38*/ System.Collections.Generic.Dictionary<int, Yeti.Data.TargetPatternDefinition> _targetPatternsById;
            /*0x40*/ System.Collections.Generic.List<string> _tagsList;
            /*0x48*/ System.Collections.Generic.List<string> _threatVectorsList;

            static /*0x4136268*/ int GetUnitSpeedCgPerSecond(Yeti.Data.UnitDefinition unitDef, int unitLevel, int promotionLevel, int plantFoodLevel);
            static /*0x413639c*/ int CalculateValue(Yeti.Data.UnitDefinition unitDef, Yeti.Data.ScalableValue value, int unitLevel, int promotionLevel, int plantFoodLevel);
            static /*0x4136424*/ int CalculateBaseStatScaledValue(Yeti.Data.UnitDefinition unitDef, Yeti.Data.BaseStatScaledValue value, int unitLevel, int promotionLevel, int plantFoodLevel);
            /*0x41341c4*/ CombatDefinitionProvider(Yeti.Data.GameSimDefinition simDefinition);
            /*0x4135348*/ CombatDefinitionProvider(Yeti.Data.CombatDatabase config);
            /*0x4134268*/ CombatDefinitionProvider(Yeti.Data.UnitTagList unitTagList, Yeti.Data.ThreatVectorConfig threatVectorConfig, System.Collections.Generic.IList<Yeti.Data.UnitDefinition> units, System.Collections.Generic.IList<Yeti.Data.AbilityDefinition> abilities, System.Collections.Generic.IList<Yeti.Data.TargetPatternDefinition> targetPatterns);
            /*0x41341bc*/ System.Collections.Generic.List<string> get_AllTags();
            /*0x413536c*/ bool HasAllTags(System.Collections.Generic.IList<string> tags, int unitId);
            /*0x413574c*/ bool HasTag(Yeti.Data.UnitDefinition unit, string tag);
            /*0x4135dd0*/ Yeti.Data.UnitTag GetTagById(int tagId);
            /*0x4135ee0*/ Yeti.Data.ThreatVectorDefinition GetMetaTagById(int tagId);
            /*0x4135ff0*/ Yeti.Data.AbilityDefinition GetAbilityById(int abilityId);
            /*0x41360d8*/ Yeti.Data.TargetPatternDefinition GetTargetPatterById(int targetPatternId);
            /*0x413563c*/ Yeti.Data.UnitDefinition GetUnit(int unitId);
            /*0x41361c0*/ bool TryGetUnitDefinition(int unitId, ref Yeti.Data.UnitDefinition unitDef);
            /*0x4136234*/ int GetUnitSpeedCgPerSecond(int unitId);
        }

        class IntListPool : YetiSimCoreLib.Core.ObjectPool<System.Collections.Generic.List<int>>
        {
            /*0x4136548*/ IntListPool();
            /*0x413659c*/ void OnRelease(System.Collections.Generic.List<int> obj);
        }

        class KeyedListCollection<K, V>
        {
            /*0x0*/ System.Collections.Generic.Dictionary<K, V> _dictionary;
            /*0x0*/ System.Collections.Generic.List<V> _list;

            /*0x1f309e4*/ KeyedListCollection();
            /*0x1f30214*/ System.Collections.Generic.IReadOnlyList<V> get_ReadOnlyList();
            /*0x1f30214*/ System.Collections.Generic.Dictionary.KeyCollection<K, V> get_Keys();
            /*0x1ffc854*/ bool ContainsKey(K key);
            /*0x1ffc854*/ bool TryGetValue(K key, ref V item);
            /*0x1ffc854*/ bool Add(K key, V value);
            /*0x1f309e4*/ void Clear();
            /*0x1ffc854*/ V get_Item(K key);
            /*0x1ffc854*/ void set_Item(K key, V value);

            class <>c__DisplayClass15_0<K, V>
            {
                /*0x0*/ V oldValue;

                /*0x1f309e4*/ <>c__DisplayClass15_0();
                /*0x1ffc854*/ bool <set_Item>b__0(V ov);
            }
        }

        class LevelLayoutTagUtils
        {
            static /*0x4136634*/ System.Collections.Generic.HashSet<string> GetLevelLayoutImpliedTags(Yeti.Data.IPreSpawnedUnits levelLayout, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            static /*0x41370dc*/ System.Collections.Generic.HashSet<string> GetLevelLayoutImpliedTagsWithoutPreSpawnTags(Yeti.Data.IPreSpawnedUnits levelLayout, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            static /*0x4136d98*/ void AddElevationTags(Yeti.Data.IPreSpawnedUnits levelLayout, System.Collections.Generic.HashSet<string> unitTags);
            static /*0x4136a6c*/ void AddTagsForUnitId(int unitId, System.Collections.Generic.HashSet<string> unitTags, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
        }

        struct ListSorter<T>
        {
            /*0x0*/ System.Collections.Generic.IList<T> _keys;
            /*0x0*/ System.Collections.Generic.IComparer<T> _comparer;

            static /*0x1f36f18*/ void Sort(System.Collections.Generic.IList<T> list, System.Collections.Generic.IComparer<T> comparer);
            static /*0x1f31e78*/ int GetMedian(int low, int hi);
            /*0x1f30ff0*/ ListSorter(System.Collections.Generic.IList<T> keys, System.Collections.Generic.IComparer<T> comparer);
            /*0x1f30bb4*/ void SwapIfGreaterWithItems(int a, int b);
            /*0x1f30bb4*/ void QuickSort(int left, int right);
        }

        class MergeDefinitionProvider
        {
            static int UnmergeableTierNumber = -1;
            static int BaseTierNumber = 1;
            static int MaxTierNumber = 4;
            /*0x10*/ Yeti.Data.UnitMergeDatabase _unitMergeDatabase;
            /*0x18*/ System.Collections.Generic.Dictionary<int, Yeti.Data.UnitMergeDefinition> _recipesByResultUnitId;
            /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<Yeti.Data.UnitMergeDefinition>> _recipesByRequiredUnitId;
            /*0x28*/ System.Collections.Generic.HashSet<int> _unitsInRecipes;
            /*0x30*/ System.Collections.Generic.Dictionary<int, int> _mergeTiers;
            /*0x38*/ System.Collections.Generic.HashSet<int> _allMergeUnits;
            /*0x40*/ System.Collections.Generic.List<int> _tempList;
            /*0x48*/ System.Collections.Generic.List<int> _tempList2;
            /*0x50*/ System.Collections.Generic.HashSet<int> _tempSet;

            /*0x41393e4*/ MergeDefinitionProvider();
            /*0x41374a8*/ System.Collections.Generic.IReadOnlyCollection<int> get_AllMergeUnits();
            /*0x41374b0*/ void SetDatabase(Yeti.Data.UnitMergeDatabase mergeDatabase);
            /*0x4137fb0*/ bool TryGetUnitMergeIngredients(int resultUnitId, ref int unitIdA, ref int unitIdB);
            /*0x41380e4*/ System.Collections.Generic.HashSet<int> GetMergeTree(int resultingUnitId);
            /*0x4138184*/ void FetchMergeTree(int unitId, System.Collections.Generic.HashSet<int> visited, System.Collections.Generic.HashSet<int> result);
            /*0x41384f4*/ bool TryGetUnitMerge(int unitIdA, int unitIdB, ref int resultUnitId);
            /*0x41389e4*/ int GetMergeTier(int unitId);
            /*0x4137c08*/ int GetMaxDagDepth(int unitId, int currentDepth);
            /*0x4138a60*/ void AddAllPossibleMergeCombinationsTo(System.Collections.Generic.HashSet<int> unitIds, System.Collections.Generic.HashSet<int> setToAddTo);
            /*0x41390c8*/ void AddAllPossibleMergeResultsTo(int unitId, System.Collections.Generic.HashSet<int> setToAddTo);
            /*0x4139318*/ void AddAllIngredientsRecursive(int unitId, System.Collections.Generic.List<int> setToAddTo);
        }

        class PerksAndHazardsCombatDefinitionProvider
        {
            /*0x10*/ Yeti.Data.PerksAndHazardsConfig _perksAndHazardsConfig;
            /*0x18*/ System.Collections.Generic.Dictionary<int, Yeti.Data.CombatModifier> _combatModifiersById;
            /*0x20*/ System.Collections.Generic.Dictionary<int, Yeti.Data.HybridCombatModifier> _hybridCombatModifiersById;
            /*0x28*/ System.Collections.Generic.List<Yeti.Data.PerLevelCombatModifier> _activePerLevelCombatModifiers;
            /*0x30*/ System.Collections.Generic.Dictionary<string, Yeti.Data.PlantPerks> _plantLevelPerks;

            /*0x413ae38*/ PerksAndHazardsCombatDefinitionProvider();
            /*0x4139620*/ Yeti.Data.RapidFireConfig get_RapidFireConfig();
            /*0x4139648*/ Yeti.Data.TargetingDefinition get_BouncingProjectileTargeting();
            /*0x4139678*/ Yeti.Data.TargetingDefinition get_BouncingFallbackProjectileTargeting();
            /*0x41396a8*/ Yeti.Data.ActionTypeDefinition.Types.LobberProjectileAction get_BouncingLobbedProjectile();
            /*0x41396d8*/ Yeti.Data.TargetingDefinition get_SplitHitProjectileTargeting();
            /*0x4139708*/ void SetDatabase(Yeti.Data.PerksAndHazardsConfig config, System.Collections.Generic.IEnumerable<Yeti.Data.PerLevelCombatModifier> activePerLevelCombatModifiers, System.Collections.Generic.IList<Yeti.Data.PlantPerks> plantPerks);
            /*0x41397b8*/ void CacheCombatModifierDefinitions(Yeti.Data.PerksAndHazardsConfig perksAndHazardsConfig);
            /*0x413997c*/ void CacheActivePerLevelCombatModifiers(System.Collections.Generic.IEnumerable<Yeti.Data.PerLevelCombatModifier> activePerLevelCombatModifiers);
            /*0x4139dc4*/ void CachePlantLevelPerks(System.Collections.Generic.IList<Yeti.Data.PlantPerks> plantPerks);
            /*0x4139f58*/ bool TryGetCombatModifier(int id, ref Yeti.Data.CombatModifier result);
            /*0x4139fdc*/ bool TryGetHybridCombatModifier(int id, ref Yeti.Data.HybridCombatModifier result);
            /*0x413a060*/ System.Collections.Generic.IList<Yeti.Data.CombatModifierStacks> GetPerksForUnit(string alias, int level);
            /*0x413a150*/ void CollectLevelCombatModStacks(Yeti.Data.UnitDefinition unitDef, System.Collections.Generic.Dictionary<int, int> modStacks);
            /*0x413aa48*/ void CollectPlantPerkCombatModStacks(Yeti.Data.UnitDefinition unitDef, int unitLevel, System.Collections.Generic.Dictionary<int, int> modStacks);
        }

        class PerksAndHazardsUtils
        {
            static /*0x413afbc*/ Yeti.Data.CombatModifierTier GetCombatModifierTier(Yeti.Data.CombatModifier combatModifier, int stacks);
            static /*0x413a948*/ bool DoesUnitQualifyForUnitsEffected(Yeti.Data.UnitDefinition unitDef, Yeti.Data.CombatModifierUnitsEffected unitsEffected);
        }

        class SimpleTagsUtility
        {
            static /*0x413b070*/ bool HasAllTags(Google.Protobuf.Collections.RepeatedField<int> tags, Google.Protobuf.Collections.RepeatedField<int> tagsToCheck);
            static /*0x413b06c*/ bool HasAnyTags(Google.Protobuf.Collections.RepeatedField<int> tagsToCheck, Google.Protobuf.Collections.RepeatedField<int> tags);
            static /*0x413b244*/ bool DoesNotHaveAnyTags(Google.Protobuf.Collections.RepeatedField<int> tagsToCheck, Google.Protobuf.Collections.RepeatedField<int> tags);
            static /*0x413b168*/ bool HasAnyTagsInternal(Google.Protobuf.Collections.RepeatedField<int> tagsToCheck, Google.Protobuf.Collections.RepeatedField<int> tags);
        }
    }
}

namespace YetiSimCoreLib
{
    namespace Core
    {
        class ObjectPool<T>
        {
            static int kDefaultInitialPoolSize = 10;
            static int kDefaultPoolAllocationSize = 10;
            /*0x0*/ int mInitialPoolSize;
            /*0x0*/ int mAllocationSize;
            /*0x0*/ bool mInitialized;
            /*0x0*/ System.Collections.Generic.Stack<T> mObjects;
            /*0x0*/ System.Collections.Generic.HashSet<T> mActiveObjects;
            /*0x0*/ System.Delegate mInstantiationMethod;

            ObjectPool(System.Delegate instantiationMethod, int initialPoolSize, int allocationSize);
            ObjectPool(System.Delegate instantiationMethod, System.Collections.Generic.IEqualityComparer<T> comparer, int initialPoolSize, int allocationSize);
            /*0x1f309e4*/ void Initialize();
            /*0x1ffc854*/ T Fetch();
            /*0x1ffc854*/ bool Release(T obj);
            /*0x1f309e4*/ void ReleaseAll();
            /*0x1f30b78*/ void IncreasePoolSize(int allocationSize);
            /*0x1ffc854*/ T OnCreateObject();
            /*0x1ffc854*/ void OnObjectCreated(T obj);
            /*0x1ffc854*/ void OnRelease(T obj);
            /*0x1f2ffc8*/ int GetActiveCount();
            /*0x1f2ffc8*/ int GetCreatedObjectsCount();
        }
    }

    namespace Utils
    {
        class GameInitStateFactory
        {
            static /*0x413b25c*/ Yeti.Data.GameInitState CreateEmptyGameInitState();
        }
    }

    namespace External
    {
        class UnitDefinitionUtils
        {
            static /*0x413b824*/ bool IsPlayerFacingZombieUnit(Yeti.Data.UnitDefinition unitDefinition);
        }

        class TrickInfo
        {
            /*0x10*/ int <UnitId>k__BackingField;
            /*0x18*/ string <Alias>k__BackingField;
            /*0x20*/ int <SpawnTimeInMs>k__BackingField;

            /*0x413b8e0*/ TrickInfo(int unitId, string alias, int spawnTimeInMs);
            /*0x413b8d0*/ string get_Alias();
            /*0x413b8d8*/ int get_SpawnTimeInMs();
        }

        class WaveStaticDataProvider
        {
            /*0x10*/ int <LastSpawnTimeInBattleMs>k__BackingField;
            /*0x14*/ int <NumberOfStandardWaves>k__BackingField;
            /*0x18*/ bool <HasWaterSurge>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<int> _hugeWaveSpawnTimesMs;
            /*0x28*/ System.Collections.Generic.List<YetiSimCoreLib.External.TrickInfo> _sortedTrickSpawns;
            /*0x30*/ YetiSimCoreCommon.Utils.KeyedListCollection<string, System.Collections.Generic.List<YetiSimCoreLib.External.TrickInfo>> _sortedTrickSpawnsByAlias;

            static /*0x413bf58*/ int CalculateLastSpawnTimeMs(Yeti.Data.BattleGeneratedWave.Types.StandardWaveData waveStandardWave);
            /*0x413c574*/ WaveStaticDataProvider();
            /*0x413b92c*/ int get_LastSpawnTimeInBattleMs();
            /*0x413b934*/ void set_LastSpawnTimeInBattleMs(int value);
            /*0x413b93c*/ int get_NumberOfStandardWaves();
            /*0x413b944*/ void set_NumberOfStandardWaves(int value);
            /*0x413b94c*/ System.Collections.Generic.IReadOnlyList<int> get_HugeWaveSpawnTimesMs();
            /*0x413b954*/ System.Collections.Generic.IReadOnlyList<YetiSimCoreLib.External.TrickInfo> get_SortedTrickSpawns();
            /*0x413b95c*/ YetiSimCoreCommon.Utils.KeyedListCollection<string, System.Collections.Generic.List<YetiSimCoreLib.External.TrickInfo>> get_SortedTrickSpawnsByAlias();
            /*0x413b964*/ bool get_HasWaterSurge();
            /*0x413b96c*/ void set_HasWaterSurge(bool value);
            /*0x413b974*/ void SetWaveData(Yeti.Data.BattleGeneratedStage stageData, YetiSimCoreLib.Game.UnitDatabase unitDatabase);
            /*0x413c0bc*/ void AddHugeWaveSpawns(Yeti.Data.BattleGeneratedWave.Types.StandardWaveData wave);
            /*0x413c134*/ void AddTrickSpawns(Yeti.Data.BattleGeneratedWave.Types.StandardWaveData wave, YetiSimCoreLib.Game.UnitDatabase unitDatabase);
            /*0x413c540*/ int SortByTime(YetiSimCoreLib.External.TrickInfo x, YetiSimCoreLib.External.TrickInfo y);
        }
    }

    namespace Game
    {
        class AbilityDatabase
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, Yeti.Data.AbilityDefinition> _abilities;

            /*0x413c9a8*/ AbilityDatabase();
            /*0x413c6a4*/ void SetAbilities(System.Collections.Generic.IEnumerable<Yeti.Data.AbilityDefinition> abilities);
            /*0x4133300*/ Yeti.Data.AbilityDefinition FindAbility(int abilityId);
        }

        class InstanceIdComparer : System.Collections.Generic.IEqualityComparer<YetiSimCoreLib.Game.InstanceId>
        {
            static /*0x0*/ YetiSimCoreLib.Game.InstanceIdComparer Comparer;

            static /*0x413ca4c*/ InstanceIdComparer();
            /*0x413ca44*/ InstanceIdComparer();
            /*0x413ca30*/ bool Equals(YetiSimCoreLib.Game.InstanceId x, YetiSimCoreLib.Game.InstanceId y);
            /*0x413ca3c*/ int GetHashCode(YetiSimCoreLib.Game.InstanceId obj);
        }

        struct InstanceId
        {
            static /*0x0*/ YetiSimCoreLib.Game.InstanceId InvalidId;
            /*0x10*/ int IntValue;

            static /*0x413cb3c*/ InstanceId();
            static /*0x413cab4*/ int op_Implicit(YetiSimCoreLib.Game.InstanceId id);
            static /*0x413cab8*/ YetiSimCoreLib.Game.InstanceId op_Implicit(int id);
            /*0x413cabc*/ InstanceId(int intValue);
            /*0x413cac4*/ string ToString();
        }

        interface IRandomProvider
        {
            /*0x1f309b8*/ ulong get_Seed();
            /*0x1f309b8*/ ulong get_CallCount();
            int Next(int max);
            /*0x1f2fff4*/ int Next(int min, int max);
        }

        class MtRandom : YetiSimCoreLib.Game.IRandomProvider
        {
            static int N = 624;
            static int M = 397;
            static uint K = 2567483615;
            /*0x10*/ ulong[] _state;
            /*0x18*/ ulong _callCount;
            /*0x20*/ ulong <Seed>k__BackingField;

            static /*0x413d020*/ ulong HiBit(ulong u);
            static /*0x413d018*/ ulong LowBit(ulong u);
            static /*0x413d028*/ ulong LoBits(ulong u);
            static /*0x413d00c*/ ulong MixBits(ulong u, ulong v);
            /*0x413cb88*/ MtRandom();
            /*0x413cc08*/ MtRandom(ulong seed);
            /*0x413ccdc*/ void ResetWithNewSeed(ulong seed);
            /*0x413cce0*/ ulong get_CallCount();
            /*0x413cce8*/ void SetFromSeedAndCallCount(ulong initialSeed, ulong callCount);
            /*0x413ce98*/ ulong InternalNext();
            /*0x413cf64*/ ulong get_Seed();
            /*0x413cf6c*/ void set_Seed(ulong value);
            /*0x413cf74*/ int Next(int max);
            /*0x413cf80*/ int Next(int min, int max);
            /*0x413cc84*/ void SetSeed(ulong seed);
            /*0x413cd48*/ void MutateInternalState();
        }

        struct Position
        {
            static /*0x0*/ YetiSimCoreLib.Game.Position Origin;
            /*0x10*/ int X;
            /*0x14*/ int Y;
            /*0x18*/ int Z;

            static /*0x413d030*/ YetiSimCoreLib.Game.Position FromComponent(YetiSimCoreLib.Components.PositionComponent component);
            static /*0x413d058*/ YetiSimCoreLib.Game.Position FromComponent(YetiSimCoreLib.Components.PreviousPositionComponent component);
            static /*0x413d074*/ YetiSimCoreLib.Game.Position FromComponent(YetiSimCoreLib.Components.VelocityComponent component);
            static /*0x413d090*/ YetiSimCoreLib.Game.Position FromComponent(YetiSimCoreLib.Components.SpawnPositionComponent component);
            static /*0x413d0ac*/ YetiSimCoreLib.Game.Position FromComponent(YetiSimCoreLib.Components.PredictedPositionComponent component);
            static /*0x413d1b0*/ YetiSimCoreLib.Game.Position op_Multiply(YetiSimCoreLib.Game.Position p, float value);
            static /*0x413d20c*/ YetiSimCoreLib.Game.Position op_Multiply(YetiSimCoreLib.Game.Position p, YetiSimCoreLib.Game.Position value);
            static /*0x413d228*/ YetiSimCoreLib.Game.Position op_Addition(YetiSimCoreLib.Game.Position a, YetiSimCoreLib.Game.Position b);
            static /*0x413d244*/ YetiSimCoreLib.Game.Position op_Subtraction(YetiSimCoreLib.Game.Position a, YetiSimCoreLib.Game.Position b);
            /*0x413d04c*/ Position(int x, int y, int z);
            /*0x413d0c8*/ Position(YetiSimCoreLib.Game.Position position);
            /*0x413d0d8*/ string ToString();
            /*0x413d190*/ void CopyTo(YetiSimCoreLib.Components.PreviousPositionComponent component);
            /*0x413d260*/ bool CompareTo(YetiSimCoreLib.Game.Position position);
        }

        class ReservedUnitTagIds
        {
            static /*0x0*/ Yeti.Data.UnitTag NotShovelable;
            static /*0x8*/ System.Collections.Generic.List<Yeti.Data.UnitTag> ReservedTags;

            static /*0x413d294*/ ReservedUnitTagIds();
        }

        class ScoreCalculator
        {
            static /*0x413d3d0*/ int CalculateNominalTotalStageScore(Yeti.Data.GameSimDefinition gameSimDefinition, YetiSimCoreLib.Game.UnitDatabase unitDatabase);
            static /*0x413dd40*/ int GetMaxScore(int nominalTotalScore, Yeti.Data.ColumnScoringDefinitions columnScoringDefinition);
            static /*0x413e088*/ int GetNumStars(int totalScore, int maxScore, System.Collections.Generic.IList<Yeti.Data.StarThresholdsDefinition> starThresholdsDefinitions);
            static /*0x413d6c0*/ int CalculateWaveScore(Yeti.Data.BattleGeneratedWave wave, YetiSimCoreLib.Game.UnitDatabase unitDatabase);
            static /*0x413e1f8*/ int CalculateZombieBaseScore(Yeti.Data.UnitDefinition unitDefinition, int zombieLevel);
        }

        struct Speed
        {
            /*0x10*/ int <Vx>k__BackingField;
            /*0x14*/ int <Vy>k__BackingField;
            /*0x18*/ int <Vz>k__BackingField;

            /*0x413e23c*/ Speed(int vx, int vy, int vz);
            /*0x413e224*/ int get_Vx();
            /*0x413e22c*/ int get_Vy();
            /*0x413e234*/ int get_Vz();
            /*0x413e248*/ string ToString();
        }

        class UnitDatabase
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, Yeti.Data.UnitDefinition> _unitDefinitions;

            /*0x413e568*/ UnitDatabase();
            /*0x413c494*/ Yeti.Data.UnitDefinition GetUnitDefinition(YetiSimCoreLib.Game.UnitId id);
            /*0x413e3cc*/ void SetDefinitions(System.Collections.Generic.IList<Yeti.Data.UnitDefinition> definitions);
        }

        class MissingUnitDefinitionException : System.Exception
        {
            /*0x8c*/ YetiSimCoreLib.Game.UnitId <UnitId>k__BackingField;

            /*0x413e300*/ MissingUnitDefinitionException(YetiSimCoreLib.Game.UnitId id);
        }

        struct UnitId
        {
            static int InvalidInt = -1;
            static /*0x0*/ YetiSimCoreLib.Game.UnitId Invalid;
            /*0x10*/ int IntValue;

            static /*0x413e674*/ UnitId();
            static /*0x413e5f0*/ int op_Implicit(YetiSimCoreLib.Game.UnitId id);
            static /*0x413c490*/ YetiSimCoreLib.Game.UnitId op_Implicit(int id);
            /*0x413e5f4*/ UnitId(int intValue);
            /*0x413e5fc*/ string ToString();
        }

        struct UnitProgressionArgs
        {
            static /*0x0*/ YetiSimCoreLib.Game.UnitProgressionArgs Default;
            /*0x10*/ System.Nullable<int> OverrideLevel;
            /*0x18*/ int PlantFoodLevel;
            /*0x1c*/ int PromotionLevel;

            static /*0x413e870*/ UnitProgressionArgs();
            /*0x413e6c0*/ UnitProgressionArgs(int plantFoodLevel, int promotionLevel);
            /*0x413e6cc*/ UnitProgressionArgs(int overrideLevel, int plantFoodLevel, int promotionLevel);
            /*0x413e750*/ UnitProgressionArgs(YetiSimCoreLib.Components.LevelsComponent levels);
            /*0x413e7d0*/ UnitProgressionArgs(YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction spawnUnitAction);
            /*0x413e850*/ UnitProgressionArgs(Yeti.Data.UnitInstance unit);
        }

        class MathUtil
        {
            static /*0x413e8c0*/ int FlooredDivision(int numerator, int denominator);
            static /*0x413e8e8*/ int MultiplyByIntPercentMille(int baseValue, int multiplier);
            static /*0x413e068*/ int MultiplyByIntPercent(int baseValue, int multiplier);
            static /*0x413e908*/ int ZeroClampedMultiplyByIntPercent(int baseValue, int multiplier);
            static /*0x413e938*/ string FormatAsPercent(int percentMille);
            static /*0x413e9ec*/ int GetPercent(int current, int max);
            static /*0x413e9fc*/ int RoundUpDivision(int numerator, int denominator);
        }

        class ValueComparisonUtil
        {
            static /*0x413ea20*/ bool Compare(int left, int right, Yeti.Data.ValueComparison comparison);
        }
    }

    namespace Components
    {
        class AbilityComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityComponent> _parser;
            /*0x10*/ Yeti.Data.AbilityDefinition AbilityDefinition;
            /*0x18*/ Entitas.Entity UnitEntity;
            /*0x20*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x28*/ int sourceId_;
            /*0x2c*/ int abilityId_;

            static /*0x413f0b0*/ AbilityComponent();
            static /*0x413ea60*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityComponent> get_Parser();
            static /*0x413eab8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x413ec08*/ AbilityComponent();
            /*0x413ec10*/ AbilityComponent(YetiSimCoreLib.Components.AbilityComponent other);
            /*0x413ebbc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x413ec5c*/ YetiSimCoreLib.Components.AbilityComponent Clone();
            /*0x413ecb4*/ int get_SourceId();
            /*0x413ecbc*/ void set_SourceId(int value);
            /*0x413ecc4*/ int get_AbilityId();
            /*0x413eccc*/ void set_AbilityId(int value);
            /*0x413ecd4*/ bool Equals(object other);
            /*0x413ed38*/ bool Equals(YetiSimCoreLib.Components.AbilityComponent other);
            /*0x413ed84*/ int GetHashCode();
            /*0x413edfc*/ string ToString();
            /*0x413ee54*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x413ee74*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x413eefc*/ int CalculateSize();
            /*0x413efb0*/ void MergeFrom(YetiSimCoreLib.Components.AbilityComponent other);
            /*0x413effc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x413f01c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityComponent.<> <>9;

                static /*0x413f1c8*/ <>c();
                /*0x413f230*/ <>c();
                /*0x413f238*/ YetiSimCoreLib.Components.AbilityComponent <.cctor>b__34_0();
            }
        }

        class AbilityEntry : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityEntry>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityEntry>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityEntry>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityEntry> _parser;
            /*0x10*/ Entitas.Entity AbilityEntity;
            /*0x18*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x20*/ int abilityId_;
            /*0x24*/ YetiSimCoreLib.Components.ModifierDurationType durationType_;
            /*0x28*/ int remainingDuration_;
            /*0x2c*/ Yeti.Data.AbilityBehaviorType behaviorType_;
            /*0x30*/ int entityId_;
            /*0x34*/ int weight_;
            /*0x38*/ bool canActivateOnInactiveUnit_;
            /*0x3c*/ Yeti.Data.AbilityApplicationType applicationType_;
            /*0x40*/ Yeti.Data.AbilityActionType actionType_;
            /*0x44*/ bool isCombatModifierAppliedAbility_;

            static /*0x413ffa0*/ AbilityEntry();
            static /*0x413f2e8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityEntry> get_Parser();
            static /*0x413f340*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x413f490*/ AbilityEntry();
            /*0x413f498*/ AbilityEntry(YetiSimCoreLib.Components.AbilityEntry other);
            /*0x413f28c*/ void CopyFrom(YetiSimCoreLib.Components.AbilityEntry other);
            /*0x413f444*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x413f504*/ YetiSimCoreLib.Components.AbilityEntry Clone();
            /*0x413f55c*/ int get_AbilityId();
            /*0x413f564*/ void set_AbilityId(int value);
            /*0x413f56c*/ YetiSimCoreLib.Components.ModifierDurationType get_DurationType();
            /*0x413f574*/ void set_DurationType(YetiSimCoreLib.Components.ModifierDurationType value);
            /*0x413f57c*/ int get_RemainingDuration();
            /*0x413f584*/ void set_RemainingDuration(int value);
            /*0x413f58c*/ Yeti.Data.AbilityBehaviorType get_BehaviorType();
            /*0x413f594*/ void set_BehaviorType(Yeti.Data.AbilityBehaviorType value);
            /*0x413f59c*/ int get_EntityId();
            /*0x413f5a4*/ void set_EntityId(int value);
            /*0x413f5ac*/ int get_Weight();
            /*0x413f5b4*/ void set_Weight(int value);
            /*0x413f5bc*/ bool get_CanActivateOnInactiveUnit();
            /*0x413f5c4*/ void set_CanActivateOnInactiveUnit(bool value);
            /*0x413f5cc*/ Yeti.Data.AbilityApplicationType get_ApplicationType();
            /*0x413f5d4*/ void set_ApplicationType(Yeti.Data.AbilityApplicationType value);
            /*0x413f5dc*/ Yeti.Data.AbilityActionType get_ActionType();
            /*0x413f5e4*/ void set_ActionType(Yeti.Data.AbilityActionType value);
            /*0x413f5ec*/ bool get_IsCombatModifierAppliedAbility();
            /*0x413f5f4*/ void set_IsCombatModifierAppliedAbility(bool value);
            /*0x413f5fc*/ bool Equals(object other);
            /*0x413f660*/ bool Equals(YetiSimCoreLib.Components.AbilityEntry other);
            /*0x413f74c*/ int GetHashCode();
            /*0x413f8e8*/ string ToString();
            /*0x413f940*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x413f960*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x413fb28*/ int CalculateSize();
            /*0x413fd0c*/ void MergeFrom(YetiSimCoreLib.Components.AbilityEntry other);
            /*0x413fdc0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x413fde0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityEntry.<> <>9;

                static /*0x41400b8*/ <>c();
                /*0x4140120*/ <>c();
                /*0x4140128*/ YetiSimCoreLib.Components.AbilityEntry <.cctor>b__74_0();
            }
        }

        interface IAttackCounterComponent
        {
            /*0x1f2ffc8*/ int get_AttacksRemaining();
            /*0x1f30b78*/ void set_AttacksRemaining(int value);
        }

        interface ICounterComponent
        {
            /*0x1f2ffc8*/ int get_TicksRemaining();
            /*0x1f30b78*/ void set_TicksRemaining(int value);
        }

        interface IStatComponent : Entitas.IComponent
        {
            /*0x1f30214*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x1f30ebc*/ void set_Data(YetiSimCoreLib.Components.Stat value);
        }

        interface ITaggableComponent
        {
            /*0x1f30214*/ Google.Protobuf.Collections.RepeatedField<int> get_Tags();
        }

        interface ITagCountableComponent : YetiSimCoreLib.Components.ITaggableComponent
        {
            /*0x1f30214*/ Google.Protobuf.Collections.RepeatedField<int> get_TagCounters();
        }

        class UnitTagsComponent : YetiSimCoreLib.Components.ITaggableComponent, Google.Protobuf.IMessage<YetiSimCoreLib.Components.UnitTagsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.UnitTagsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.UnitTagsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitTagsComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_tags_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> tags_;

            static /*0x414093c*/ UnitTagsComponent();
            static /*0x414017c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitTagsComponent> get_Parser();
            static /*0x41401d4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4140324*/ UnitTagsComponent();
            /*0x41403ac*/ UnitTagsComponent(YetiSimCoreLib.Components.UnitTagsComponent other);
            /*0x41402d8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4140438*/ YetiSimCoreLib.Components.UnitTagsComponent Clone();
            /*0x4140490*/ Google.Protobuf.Collections.RepeatedField<int> get_Tags();
            /*0x4140498*/ bool Equals(object other);
            /*0x41404fc*/ bool Equals(YetiSimCoreLib.Components.UnitTagsComponent other);
            /*0x414058c*/ int GetHashCode();
            /*0x41405d8*/ string ToString();
            /*0x4140630*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4140650*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4140708*/ int CalculateSize();
            /*0x41407b0*/ void MergeFrom(YetiSimCoreLib.Components.UnitTagsComponent other);
            /*0x4140838*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4140858*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.UnitTagsComponent.<> <>9;

                static /*0x4140a78*/ <>c();
                /*0x4140ae0*/ <>c();
                /*0x4140ae8*/ YetiSimCoreLib.Components.UnitTagsComponent <.cctor>b__27_0();
            }
        }

        class TargetingImmunityComponent : YetiSimCoreLib.Components.ITagCountableComponent, YetiSimCoreLib.Components.ITaggableComponent, Google.Protobuf.IMessage<YetiSimCoreLib.Components.TargetingImmunityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TargetingImmunityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TargetingImmunityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetingImmunityComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_tags_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_tagCounters_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> tags_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> tagCounters_;

            static /*0x4141428*/ TargetingImmunityComponent();
            static /*0x4140b38*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetingImmunityComponent> get_Parser();
            static /*0x4140b90*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4140ce0*/ TargetingImmunityComponent();
            /*0x4140d8c*/ TargetingImmunityComponent(YetiSimCoreLib.Components.TargetingImmunityComponent other);
            /*0x4140c94*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4140e38*/ YetiSimCoreLib.Components.TargetingImmunityComponent Clone();
            /*0x4140e90*/ Google.Protobuf.Collections.RepeatedField<int> get_Tags();
            /*0x4140e98*/ Google.Protobuf.Collections.RepeatedField<int> get_TagCounters();
            /*0x4140ea0*/ bool Equals(object other);
            /*0x4140f04*/ bool Equals(YetiSimCoreLib.Components.TargetingImmunityComponent other);
            /*0x4140fac*/ int GetHashCode();
            /*0x4141020*/ string ToString();
            /*0x4141078*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4141098*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4141170*/ int CalculateSize();
            /*0x4141244*/ void MergeFrom(YetiSimCoreLib.Components.TargetingImmunityComponent other);
            /*0x41412e0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4141300*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TargetingImmunityComponent.<> <>9;

                static /*0x4141588*/ <>c();
                /*0x41415f0*/ <>c();
                /*0x41415f8*/ YetiSimCoreLib.Components.TargetingImmunityComponent <.cctor>b__32_0();
            }
        }

        class TargetingRequirementComponent : YetiSimCoreLib.Components.ITagCountableComponent, YetiSimCoreLib.Components.ITaggableComponent, Google.Protobuf.IMessage<YetiSimCoreLib.Components.TargetingRequirementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TargetingRequirementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TargetingRequirementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetingRequirementComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_tags_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_tagCounters_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> tags_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> tagCounters_;

            static /*0x4141f38*/ TargetingRequirementComponent();
            static /*0x4141648*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetingRequirementComponent> get_Parser();
            static /*0x41416a0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41417f0*/ TargetingRequirementComponent();
            /*0x414189c*/ TargetingRequirementComponent(YetiSimCoreLib.Components.TargetingRequirementComponent other);
            /*0x41417a4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4141948*/ YetiSimCoreLib.Components.TargetingRequirementComponent Clone();
            /*0x41419a0*/ Google.Protobuf.Collections.RepeatedField<int> get_Tags();
            /*0x41419a8*/ Google.Protobuf.Collections.RepeatedField<int> get_TagCounters();
            /*0x41419b0*/ bool Equals(object other);
            /*0x4141a14*/ bool Equals(YetiSimCoreLib.Components.TargetingRequirementComponent other);
            /*0x4141abc*/ int GetHashCode();
            /*0x4141b30*/ string ToString();
            /*0x4141b88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4141ba8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4141c80*/ int CalculateSize();
            /*0x4141d54*/ void MergeFrom(YetiSimCoreLib.Components.TargetingRequirementComponent other);
            /*0x4141df0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4141e10*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TargetingRequirementComponent.<> <>9;

                static /*0x4142098*/ <>c();
                /*0x4142100*/ <>c();
                /*0x4142108*/ YetiSimCoreLib.Components.TargetingRequirementComponent <.cctor>b__32_0();
            }
        }

        class MessageComparer<T> : System.Collections.Generic.IEqualityComparer<T>
        {
            /*0x1f309e4*/ MessageComparer();
            /*0x1ffc854*/ bool Equals(T x, T y);
            /*0x1ffc854*/ int GetHashCode(T obj);
        }

        class UnitComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.UnitComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.UnitComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.UnitComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitComponent> _parser;
            /*0x10*/ Yeti.Data.UnitDefinition Definition;
            /*0x18*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x20*/ int unitId_;
            /*0x24*/ int behaviorId_;
            /*0x28*/ int previousBehaviorId_;

            static /*0x4142878*/ UnitComponent();
            static /*0x4142158*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitComponent> get_Parser();
            static /*0x41421b0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4142300*/ UnitComponent();
            /*0x4142308*/ UnitComponent(YetiSimCoreLib.Components.UnitComponent other);
            /*0x41422b4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414235c*/ YetiSimCoreLib.Components.UnitComponent Clone();
            /*0x41423b4*/ int get_UnitId();
            /*0x41423bc*/ void set_UnitId(int value);
            /*0x41423c4*/ int get_BehaviorId();
            /*0x41423cc*/ void set_BehaviorId(int value);
            /*0x41423d4*/ int get_PreviousBehaviorId();
            /*0x41423dc*/ void set_PreviousBehaviorId(int value);
            /*0x41423e4*/ bool Equals(object other);
            /*0x4142448*/ bool Equals(YetiSimCoreLib.Components.UnitComponent other);
            /*0x41424a4*/ int GetHashCode();
            /*0x4142538*/ string ToString();
            /*0x4142590*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41425b0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4142660*/ int CalculateSize();
            /*0x4142740*/ void MergeFrom(YetiSimCoreLib.Components.UnitComponent other);
            /*0x4142798*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41427b8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.UnitComponent.<> <>9;

                static /*0x4142990*/ <>c();
                /*0x41429f8*/ <>c();
                /*0x4142a00*/ YetiSimCoreLib.Components.UnitComponent <.cctor>b__38_0();
            }
        }

        class AbilitiesComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4142aac*/ AbilitiesComponentReflection();
            static /*0x4142a54*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AbilitiesComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilitiesComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilitiesComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilitiesComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilitiesComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<YetiSimCoreLib.Components.AbilityEntry> _repeated_abilities_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.AbilityEntry> abilities_;

            static /*0x4144ad0*/ AbilitiesComponent();
            static /*0x4144318*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilitiesComponent> get_Parser();
            static /*0x4144370*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41444c0*/ AbilitiesComponent();
            /*0x4144548*/ AbilitiesComponent(YetiSimCoreLib.Components.AbilitiesComponent other);
            /*0x4144474*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41445d4*/ YetiSimCoreLib.Components.AbilitiesComponent Clone();
            /*0x414462c*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.AbilityEntry> get_Abilities();
            /*0x4144634*/ bool Equals(object other);
            /*0x4144698*/ bool Equals(YetiSimCoreLib.Components.AbilitiesComponent other);
            /*0x4144728*/ int GetHashCode();
            /*0x4144774*/ string ToString();
            /*0x41447cc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41447ec*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41448a4*/ int CalculateSize();
            /*0x414494c*/ void MergeFrom(YetiSimCoreLib.Components.AbilitiesComponent other);
            /*0x41449d4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41449f4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilitiesComponent.<> <>9;

                static /*0x4144c80*/ <>c();
                /*0x4144ce8*/ <>c();
                /*0x4144cf0*/ YetiSimCoreLib.Components.AbilitiesComponent <.cctor>b__27_0();
            }
        }

        class ActiveAbilityComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ActiveAbilityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ActiveAbilityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ActiveAbilityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ActiveAbilityComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41451b4*/ ActiveAbilityComponent();
            static /*0x4144d40*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ActiveAbilityComponent> get_Parser();
            static /*0x4144d98*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4144ee8*/ ActiveAbilityComponent();
            /*0x4144ef0*/ ActiveAbilityComponent(YetiSimCoreLib.Components.ActiveAbilityComponent other);
            /*0x4144e9c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4144f34*/ YetiSimCoreLib.Components.ActiveAbilityComponent Clone();
            /*0x4144f8c*/ bool Equals(object other);
            /*0x4145010*/ bool Equals(YetiSimCoreLib.Components.ActiveAbilityComponent other);
            /*0x414503c*/ int GetHashCode();
            /*0x4145068*/ string ToString();
            /*0x41450c0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41450e0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41450f4*/ int CalculateSize();
            /*0x4145108*/ void MergeFrom(YetiSimCoreLib.Components.ActiveAbilityComponent other);
            /*0x414513c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414515c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ActiveAbilityComponent.<> <>9;

                static /*0x41452cc*/ <>c();
                /*0x4145334*/ <>c();
                /*0x414533c*/ YetiSimCoreLib.Components.ActiveAbilityComponent <.cctor>b__22_0();
            }
        }

        class EnabledAbilityComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.EnabledAbilityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.EnabledAbilityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.EnabledAbilityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.EnabledAbilityComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4145804*/ EnabledAbilityComponent();
            static /*0x4145390*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.EnabledAbilityComponent> get_Parser();
            static /*0x41453e8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4145538*/ EnabledAbilityComponent();
            /*0x4145540*/ EnabledAbilityComponent(YetiSimCoreLib.Components.EnabledAbilityComponent other);
            /*0x41454ec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4145584*/ YetiSimCoreLib.Components.EnabledAbilityComponent Clone();
            /*0x41455dc*/ bool Equals(object other);
            /*0x4145660*/ bool Equals(YetiSimCoreLib.Components.EnabledAbilityComponent other);
            /*0x414568c*/ int GetHashCode();
            /*0x41456b8*/ string ToString();
            /*0x4145710*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4145730*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4145744*/ int CalculateSize();
            /*0x4145758*/ void MergeFrom(YetiSimCoreLib.Components.EnabledAbilityComponent other);
            /*0x414578c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41457ac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.EnabledAbilityComponent.<> <>9;

                static /*0x414591c*/ <>c();
                /*0x4145984*/ <>c();
                /*0x414598c*/ YetiSimCoreLib.Components.EnabledAbilityComponent <.cctor>b__22_0();
            }
        }

        class PausedAbilityComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PausedAbilityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PausedAbilityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PausedAbilityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PausedAbilityComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4145e54*/ PausedAbilityComponent();
            static /*0x41459e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PausedAbilityComponent> get_Parser();
            static /*0x4145a38*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4145b88*/ PausedAbilityComponent();
            /*0x4145b90*/ PausedAbilityComponent(YetiSimCoreLib.Components.PausedAbilityComponent other);
            /*0x4145b3c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4145bd4*/ YetiSimCoreLib.Components.PausedAbilityComponent Clone();
            /*0x4145c2c*/ bool Equals(object other);
            /*0x4145cb0*/ bool Equals(YetiSimCoreLib.Components.PausedAbilityComponent other);
            /*0x4145cdc*/ int GetHashCode();
            /*0x4145d08*/ string ToString();
            /*0x4145d60*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4145d80*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4145d94*/ int CalculateSize();
            /*0x4145da8*/ void MergeFrom(YetiSimCoreLib.Components.PausedAbilityComponent other);
            /*0x4145ddc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4145dfc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PausedAbilityComponent.<> <>9;

                static /*0x4145f6c*/ <>c();
                /*0x4145fd4*/ <>c();
                /*0x4145fdc*/ YetiSimCoreLib.Components.PausedAbilityComponent <.cctor>b__22_0();
            }
        }

        class PrimaryAbiltyComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PrimaryAbiltyComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PrimaryAbiltyComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PrimaryAbiltyComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PrimaryAbiltyComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41464a4*/ PrimaryAbiltyComponent();
            static /*0x4146030*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PrimaryAbiltyComponent> get_Parser();
            static /*0x4146088*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41461d8*/ PrimaryAbiltyComponent();
            /*0x41461e0*/ PrimaryAbiltyComponent(YetiSimCoreLib.Components.PrimaryAbiltyComponent other);
            /*0x414618c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4146224*/ YetiSimCoreLib.Components.PrimaryAbiltyComponent Clone();
            /*0x414627c*/ bool Equals(object other);
            /*0x4146300*/ bool Equals(YetiSimCoreLib.Components.PrimaryAbiltyComponent other);
            /*0x414632c*/ int GetHashCode();
            /*0x4146358*/ string ToString();
            /*0x41463b0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41463d0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41463e4*/ int CalculateSize();
            /*0x41463f8*/ void MergeFrom(YetiSimCoreLib.Components.PrimaryAbiltyComponent other);
            /*0x414642c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414644c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PrimaryAbiltyComponent.<> <>9;

                static /*0x41465bc*/ <>c();
                /*0x4146624*/ <>c();
                /*0x414662c*/ YetiSimCoreLib.Components.PrimaryAbiltyComponent <.cctor>b__22_0();
            }
        }

        class ContinuousAbilityComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ContinuousAbilityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ContinuousAbilityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ContinuousAbilityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ContinuousAbilityComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4146af4*/ ContinuousAbilityComponent();
            static /*0x4146680*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ContinuousAbilityComponent> get_Parser();
            static /*0x41466d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4146828*/ ContinuousAbilityComponent();
            /*0x4146830*/ ContinuousAbilityComponent(YetiSimCoreLib.Components.ContinuousAbilityComponent other);
            /*0x41467dc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4146874*/ YetiSimCoreLib.Components.ContinuousAbilityComponent Clone();
            /*0x41468cc*/ bool Equals(object other);
            /*0x4146950*/ bool Equals(YetiSimCoreLib.Components.ContinuousAbilityComponent other);
            /*0x414697c*/ int GetHashCode();
            /*0x41469a8*/ string ToString();
            /*0x4146a00*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4146a20*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4146a34*/ int CalculateSize();
            /*0x4146a48*/ void MergeFrom(YetiSimCoreLib.Components.ContinuousAbilityComponent other);
            /*0x4146a7c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4146a9c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ContinuousAbilityComponent.<> <>9;

                static /*0x4146c0c*/ <>c();
                /*0x4146c74*/ <>c();
                /*0x4146c7c*/ YetiSimCoreLib.Components.ContinuousAbilityComponent <.cctor>b__22_0();
            }
        }

        class AbilityStartedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityStartedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityStartedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityStartedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityStartedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4147144*/ AbilityStartedComponent();
            static /*0x4146cd0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityStartedComponent> get_Parser();
            static /*0x4146d28*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4146e78*/ AbilityStartedComponent();
            /*0x4146e80*/ AbilityStartedComponent(YetiSimCoreLib.Components.AbilityStartedComponent other);
            /*0x4146e2c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4146ec4*/ YetiSimCoreLib.Components.AbilityStartedComponent Clone();
            /*0x4146f1c*/ bool Equals(object other);
            /*0x4146fa0*/ bool Equals(YetiSimCoreLib.Components.AbilityStartedComponent other);
            /*0x4146fcc*/ int GetHashCode();
            /*0x4146ff8*/ string ToString();
            /*0x4147050*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4147070*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4147084*/ int CalculateSize();
            /*0x4147098*/ void MergeFrom(YetiSimCoreLib.Components.AbilityStartedComponent other);
            /*0x41470cc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41470ec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityStartedComponent.<> <>9;

                static /*0x414725c*/ <>c();
                /*0x41472c4*/ <>c();
                /*0x41472cc*/ YetiSimCoreLib.Components.AbilityStartedComponent <.cctor>b__22_0();
            }
        }

        class AbilityChargesComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityChargesComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityChargesComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityChargesComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityChargesComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int chargesRemaining_;
            /*0x1c*/ int totalCharges_;

            static /*0x4147970*/ AbilityChargesComponent();
            static /*0x4147320*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityChargesComponent> get_Parser();
            static /*0x4147378*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41474c8*/ AbilityChargesComponent();
            /*0x41474d0*/ AbilityChargesComponent(YetiSimCoreLib.Components.AbilityChargesComponent other);
            /*0x414747c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414751c*/ YetiSimCoreLib.Components.AbilityChargesComponent Clone();
            /*0x4147574*/ int get_ChargesRemaining();
            /*0x414757c*/ void set_ChargesRemaining(int value);
            /*0x4147584*/ int get_TotalCharges();
            /*0x414758c*/ void set_TotalCharges(int value);
            /*0x4147594*/ bool Equals(object other);
            /*0x41475f8*/ bool Equals(YetiSimCoreLib.Components.AbilityChargesComponent other);
            /*0x4147644*/ int GetHashCode();
            /*0x41476bc*/ string ToString();
            /*0x4147714*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4147734*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41477bc*/ int CalculateSize();
            /*0x4147870*/ void MergeFrom(YetiSimCoreLib.Components.AbilityChargesComponent other);
            /*0x41478bc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41478dc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityChargesComponent.<> <>9;

                static /*0x4147a88*/ <>c();
                /*0x4147af0*/ <>c();
                /*0x4147af8*/ YetiSimCoreLib.Components.AbilityChargesComponent <.cctor>b__32_0();
            }
        }

        class AbilityCritHitComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityCritHitComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityCritHitComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityCritHitComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityCritHitComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isActiveCritHit_;

            static /*0x41480b4*/ AbilityCritHitComponent();
            static /*0x4147b4c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityCritHitComponent> get_Parser();
            static /*0x4147ba4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4147cf4*/ AbilityCritHitComponent();
            /*0x4147cfc*/ AbilityCritHitComponent(YetiSimCoreLib.Components.AbilityCritHitComponent other);
            /*0x4147ca8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4147d48*/ YetiSimCoreLib.Components.AbilityCritHitComponent Clone();
            /*0x4147da0*/ bool get_IsActiveCritHit();
            /*0x4147da8*/ void set_IsActiveCritHit(bool value);
            /*0x4147db0*/ bool Equals(object other);
            /*0x4147e14*/ bool Equals(YetiSimCoreLib.Components.AbilityCritHitComponent other);
            /*0x4147e60*/ int GetHashCode();
            /*0x4147ed0*/ string ToString();
            /*0x4147f28*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4147f48*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4147fa8*/ int CalculateSize();
            /*0x4147fd4*/ void MergeFrom(YetiSimCoreLib.Components.AbilityCritHitComponent other);
            /*0x4148018*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4148038*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityCritHitComponent.<> <>9;

                static /*0x41481cc*/ <>c();
                /*0x4148234*/ <>c();
                /*0x414823c*/ YetiSimCoreLib.Components.AbilityCritHitComponent <.cctor>b__27_0();
            }
        }

        class AbilityStaggerComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityStaggerComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityStaggerComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityStaggerComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityStaggerComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isActiveStagger_;

            static /*0x41487f8*/ AbilityStaggerComponent();
            static /*0x4148290*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityStaggerComponent> get_Parser();
            static /*0x41482e8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4148438*/ AbilityStaggerComponent();
            /*0x4148440*/ AbilityStaggerComponent(YetiSimCoreLib.Components.AbilityStaggerComponent other);
            /*0x41483ec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414848c*/ YetiSimCoreLib.Components.AbilityStaggerComponent Clone();
            /*0x41484e4*/ bool get_IsActiveStagger();
            /*0x41484ec*/ void set_IsActiveStagger(bool value);
            /*0x41484f4*/ bool Equals(object other);
            /*0x4148558*/ bool Equals(YetiSimCoreLib.Components.AbilityStaggerComponent other);
            /*0x41485a4*/ int GetHashCode();
            /*0x4148614*/ string ToString();
            /*0x414866c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414868c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41486ec*/ int CalculateSize();
            /*0x4148718*/ void MergeFrom(YetiSimCoreLib.Components.AbilityStaggerComponent other);
            /*0x414875c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414877c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityStaggerComponent.<> <>9;

                static /*0x4148910*/ <>c();
                /*0x4148978*/ <>c();
                /*0x4148980*/ YetiSimCoreLib.Components.AbilityStaggerComponent <.cctor>b__27_0();
            }
        }

        class AbilityRapidFireComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityRapidFireComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityRapidFireComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityRapidFireComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityRapidFireComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isActiveRapidFire_;

            static /*0x4148f3c*/ AbilityRapidFireComponent();
            static /*0x41489d4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityRapidFireComponent> get_Parser();
            static /*0x4148a2c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4148b7c*/ AbilityRapidFireComponent();
            /*0x4148b84*/ AbilityRapidFireComponent(YetiSimCoreLib.Components.AbilityRapidFireComponent other);
            /*0x4148b30*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4148bd0*/ YetiSimCoreLib.Components.AbilityRapidFireComponent Clone();
            /*0x4148c28*/ bool get_IsActiveRapidFire();
            /*0x4148c30*/ void set_IsActiveRapidFire(bool value);
            /*0x4148c38*/ bool Equals(object other);
            /*0x4148c9c*/ bool Equals(YetiSimCoreLib.Components.AbilityRapidFireComponent other);
            /*0x4148ce8*/ int GetHashCode();
            /*0x4148d58*/ string ToString();
            /*0x4148db0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4148dd0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4148e30*/ int CalculateSize();
            /*0x4148e5c*/ void MergeFrom(YetiSimCoreLib.Components.AbilityRapidFireComponent other);
            /*0x4148ea0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4148ec0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityRapidFireComponent.<> <>9;

                static /*0x4149054*/ <>c();
                /*0x41490bc*/ <>c();
                /*0x41490c4*/ YetiSimCoreLib.Components.AbilityRapidFireComponent <.cctor>b__27_0();
            }
        }

        class AbilitySplitHitComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilitySplitHitComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilitySplitHitComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilitySplitHitComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilitySplitHitComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isActiveSplitHit_;

            static /*0x4149680*/ AbilitySplitHitComponent();
            static /*0x4149118*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilitySplitHitComponent> get_Parser();
            static /*0x4149170*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41492c0*/ AbilitySplitHitComponent();
            /*0x41492c8*/ AbilitySplitHitComponent(YetiSimCoreLib.Components.AbilitySplitHitComponent other);
            /*0x4149274*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4149314*/ YetiSimCoreLib.Components.AbilitySplitHitComponent Clone();
            /*0x414936c*/ bool get_IsActiveSplitHit();
            /*0x4149374*/ void set_IsActiveSplitHit(bool value);
            /*0x414937c*/ bool Equals(object other);
            /*0x41493e0*/ bool Equals(YetiSimCoreLib.Components.AbilitySplitHitComponent other);
            /*0x414942c*/ int GetHashCode();
            /*0x414949c*/ string ToString();
            /*0x41494f4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4149514*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4149574*/ int CalculateSize();
            /*0x41495a0*/ void MergeFrom(YetiSimCoreLib.Components.AbilitySplitHitComponent other);
            /*0x41495e4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4149604*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilitySplitHitComponent.<> <>9;

                static /*0x4149798*/ <>c();
                /*0x4149800*/ <>c();
                /*0x4149808*/ YetiSimCoreLib.Components.AbilitySplitHitComponent <.cctor>b__27_0();
            }
        }

        class AbilityIdlePeriodComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41498b4*/ AbilityIdlePeriodComponentReflection();
            static /*0x414985c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AbilityIdlePeriodComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityIdlePeriodComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityIdlePeriodComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityIdlePeriodComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityIdlePeriodComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int cooldownTicks_;

            static /*0x414a1dc*/ AbilityIdlePeriodComponent();
            static /*0x4149c50*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityIdlePeriodComponent> get_Parser();
            static /*0x4149ca8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4149df8*/ AbilityIdlePeriodComponent();
            /*0x4149e00*/ AbilityIdlePeriodComponent(YetiSimCoreLib.Components.AbilityIdlePeriodComponent other);
            /*0x4149dac*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4149e4c*/ YetiSimCoreLib.Components.AbilityIdlePeriodComponent Clone();
            /*0x4149ea4*/ int get_CooldownTicks();
            /*0x4149eac*/ void set_CooldownTicks(int value);
            /*0x4149eb4*/ bool Equals(object other);
            /*0x4149f18*/ bool Equals(YetiSimCoreLib.Components.AbilityIdlePeriodComponent other);
            /*0x4149f54*/ int GetHashCode();
            /*0x4149fb0*/ string ToString();
            /*0x414a008*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414a028*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414a088*/ int CalculateSize();
            /*0x414a108*/ void MergeFrom(YetiSimCoreLib.Components.AbilityIdlePeriodComponent other);
            /*0x414a148*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414a168*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityIdlePeriodComponent.<> <>9;

                static /*0x414a2f4*/ <>c();
                /*0x414a35c*/ <>c();
                /*0x414a364*/ YetiSimCoreLib.Components.AbilityIdlePeriodComponent <.cctor>b__27_0();
            }
        }

        class AbilityTagsComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x414a410*/ AbilityTagsComponentReflection();
            static /*0x414a3b8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AbilityTagsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityTagsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityTagsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityTagsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityTagsComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<string> _repeated_tags_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<string> tags_;

            static /*0x414af64*/ AbilityTagsComponent();
            static /*0x414a7ac*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityTagsComponent> get_Parser();
            static /*0x414a804*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x414a954*/ AbilityTagsComponent();
            /*0x414a9dc*/ AbilityTagsComponent(YetiSimCoreLib.Components.AbilityTagsComponent other);
            /*0x414a908*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414aa68*/ YetiSimCoreLib.Components.AbilityTagsComponent Clone();
            /*0x414aac0*/ Google.Protobuf.Collections.RepeatedField<string> get_Tags();
            /*0x414aac8*/ bool Equals(object other);
            /*0x414ab2c*/ bool Equals(YetiSimCoreLib.Components.AbilityTagsComponent other);
            /*0x414abbc*/ int GetHashCode();
            /*0x414ac08*/ string ToString();
            /*0x414ac60*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414ac80*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414ad38*/ int CalculateSize();
            /*0x414ade0*/ void MergeFrom(YetiSimCoreLib.Components.AbilityTagsComponent other);
            /*0x414ae68*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414ae88*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityTagsComponent.<> <>9;

                static /*0x414b0a0*/ <>c();
                /*0x414b108*/ <>c();
                /*0x414b110*/ YetiSimCoreLib.Components.AbilityTagsComponent <.cctor>b__27_0();
            }
        }

        class AbilityUsesCooldownComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x414b1b8*/ AbilityUsesCooldownComponentReflection();
            static /*0x414b160*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AbilityUsesCooldownComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityUsesCooldownComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityUsesCooldownComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityUsesCooldownComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityUsesCooldownComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int usesRemaining_;

            static /*0x414bb94*/ AbilityUsesCooldownComponent();
            static /*0x414b608*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityUsesCooldownComponent> get_Parser();
            static /*0x414b660*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x414b7b0*/ AbilityUsesCooldownComponent();
            /*0x414b7b8*/ AbilityUsesCooldownComponent(YetiSimCoreLib.Components.AbilityUsesCooldownComponent other);
            /*0x414b764*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414b804*/ YetiSimCoreLib.Components.AbilityUsesCooldownComponent Clone();
            /*0x414b85c*/ int get_UsesRemaining();
            /*0x414b864*/ void set_UsesRemaining(int value);
            /*0x414b86c*/ bool Equals(object other);
            /*0x414b8d0*/ bool Equals(YetiSimCoreLib.Components.AbilityUsesCooldownComponent other);
            /*0x414b90c*/ int GetHashCode();
            /*0x414b968*/ string ToString();
            /*0x414b9c0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414b9e0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414ba40*/ int CalculateSize();
            /*0x414bac0*/ void MergeFrom(YetiSimCoreLib.Components.AbilityUsesCooldownComponent other);
            /*0x414bb00*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414bb20*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityUsesCooldownComponent.<> <>9;

                static /*0x414bcac*/ <>c();
                /*0x414bd14*/ <>c();
                /*0x414bd1c*/ YetiSimCoreLib.Components.AbilityUsesCooldownComponent <.cctor>b__27_0();
            }
        }

        class ActionCooldownComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x414bdc8*/ ActionCooldownComponentReflection();
            static /*0x414bd70*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ActionCooldownComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ActionCooldownComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ActionCooldownComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ActionCooldownComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ActionCooldownComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;
            /*0x1c*/ int totalTimeInMs_;
            /*0x20*/ long elapsedTimeInMs_;

            static /*0x414cb20*/ ActionCooldownComponent();
            static /*0x414c3fc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ActionCooldownComponent> get_Parser();
            static /*0x414c454*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x414c5a4*/ ActionCooldownComponent();
            /*0x414c5ac*/ ActionCooldownComponent(YetiSimCoreLib.Components.ActionCooldownComponent other);
            /*0x414c558*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414c600*/ YetiSimCoreLib.Components.ActionCooldownComponent Clone();
            /*0x414c658*/ int get_TicksRemaining();
            /*0x414c660*/ void set_TicksRemaining(int value);
            /*0x414c668*/ int get_TotalTimeInMs();
            /*0x414c670*/ void set_TotalTimeInMs(int value);
            /*0x414c678*/ long get_ElapsedTimeInMs();
            /*0x414c680*/ void set_ElapsedTimeInMs(long value);
            /*0x414c688*/ bool Equals(object other);
            /*0x414c6ec*/ bool Equals(YetiSimCoreLib.Components.ActionCooldownComponent other);
            /*0x414c748*/ int GetHashCode();
            /*0x414c7e4*/ string ToString();
            /*0x414c83c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414c85c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414c90c*/ int CalculateSize();
            /*0x414c9ec*/ void MergeFrom(YetiSimCoreLib.Components.ActionCooldownComponent other);
            /*0x414ca44*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414ca64*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ActionCooldownComponent.<> <>9;

                static /*0x414cc38*/ <>c();
                /*0x414cca0*/ <>c();
                /*0x414cca8*/ YetiSimCoreLib.Components.ActionCooldownComponent <.cctor>b__37_0();
            }
        }

        class BroadcastCooldownComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BroadcastCooldownComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BroadcastCooldownComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BroadcastCooldownComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BroadcastCooldownComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int totalTicks_;

            static /*0x414d288*/ BroadcastCooldownComponent();
            static /*0x414ccfc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BroadcastCooldownComponent> get_Parser();
            static /*0x414cd54*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x414cea4*/ BroadcastCooldownComponent();
            /*0x414ceac*/ BroadcastCooldownComponent(YetiSimCoreLib.Components.BroadcastCooldownComponent other);
            /*0x414ce58*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414cef8*/ YetiSimCoreLib.Components.BroadcastCooldownComponent Clone();
            /*0x414cf50*/ int get_TotalTicks();
            /*0x414cf58*/ void set_TotalTicks(int value);
            /*0x414cf60*/ bool Equals(object other);
            /*0x414cfc4*/ bool Equals(YetiSimCoreLib.Components.BroadcastCooldownComponent other);
            /*0x414d000*/ int GetHashCode();
            /*0x414d05c*/ string ToString();
            /*0x414d0b4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414d0d4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414d134*/ int CalculateSize();
            /*0x414d1b4*/ void MergeFrom(YetiSimCoreLib.Components.BroadcastCooldownComponent other);
            /*0x414d1f4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414d214*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BroadcastCooldownComponent.<> <>9;

                static /*0x414d3a0*/ <>c();
                /*0x414d408*/ <>c();
                /*0x414d410*/ YetiSimCoreLib.Components.BroadcastCooldownComponent <.cctor>b__27_0();
            }
        }

        class ActionCycleComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x414d4bc*/ ActionCycleComponentReflection();
            static /*0x414d464*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ActionCycleComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ActionCycleComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ActionCycleComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ActionCycleComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ActionCycleComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int durationMs_;
            /*0x20*/ long elapsedTimeMs_;
            /*0x28*/ int actionTimeMs_;
            /*0x2c*/ int remainingActionsToTake_;
            /*0x30*/ int delayTimeMs_;

            static /*0x414ec78*/ ActionCycleComponent();
            static /*0x414e3c8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ActionCycleComponent> get_Parser();
            static /*0x414e420*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x414e570*/ ActionCycleComponent();
            /*0x414e578*/ ActionCycleComponent(YetiSimCoreLib.Components.ActionCycleComponent other);
            /*0x414e524*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414e5dc*/ YetiSimCoreLib.Components.ActionCycleComponent Clone();
            /*0x414e634*/ int get_DurationMs();
            /*0x414e63c*/ void set_DurationMs(int value);
            /*0x414e644*/ long get_ElapsedTimeMs();
            /*0x414e64c*/ void set_ElapsedTimeMs(long value);
            /*0x414e654*/ int get_ActionTimeMs();
            /*0x414e65c*/ void set_ActionTimeMs(int value);
            /*0x414e664*/ int get_RemainingActionsToTake();
            /*0x414e66c*/ void set_RemainingActionsToTake(int value);
            /*0x414e674*/ int get_DelayTimeMs();
            /*0x414e67c*/ void set_DelayTimeMs(int value);
            /*0x414e684*/ bool Equals(object other);
            /*0x414e6e8*/ bool Equals(YetiSimCoreLib.Components.ActionCycleComponent other);
            /*0x414e764*/ int GetHashCode();
            /*0x414e838*/ string ToString();
            /*0x414e890*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414e8b0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414e9b0*/ int CalculateSize();
            /*0x414eae8*/ void MergeFrom(YetiSimCoreLib.Components.ActionCycleComponent other);
            /*0x414eb58*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414eb78*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ActionCycleComponent.<> <>9;

                static /*0x414ed90*/ <>c();
                /*0x414edf8*/ <>c();
                /*0x414ee00*/ YetiSimCoreLib.Components.ActionCycleComponent <.cctor>b__47_0();
            }
        }

        class GenerateActionsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GenerateActionsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GenerateActionsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GenerateActionsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GenerateActionsComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int timelineGroupIndex_;
            /*0x1c*/ int timelineIndex_;

            static /*0x414f4a4*/ GenerateActionsComponent();
            static /*0x414ee54*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GenerateActionsComponent> get_Parser();
            static /*0x414eeac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x414effc*/ GenerateActionsComponent();
            /*0x414f004*/ GenerateActionsComponent(YetiSimCoreLib.Components.GenerateActionsComponent other);
            /*0x414efb0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414f050*/ YetiSimCoreLib.Components.GenerateActionsComponent Clone();
            /*0x414f0a8*/ int get_TimelineGroupIndex();
            /*0x414f0b0*/ void set_TimelineGroupIndex(int value);
            /*0x414f0b8*/ int get_TimelineIndex();
            /*0x414f0c0*/ void set_TimelineIndex(int value);
            /*0x414f0c8*/ bool Equals(object other);
            /*0x414f12c*/ bool Equals(YetiSimCoreLib.Components.GenerateActionsComponent other);
            /*0x414f178*/ int GetHashCode();
            /*0x414f1f0*/ string ToString();
            /*0x414f248*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414f268*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414f2f0*/ int CalculateSize();
            /*0x414f3a4*/ void MergeFrom(YetiSimCoreLib.Components.GenerateActionsComponent other);
            /*0x414f3f0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414f410*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.GenerateActionsComponent.<> <>9;

                static /*0x414f5bc*/ <>c();
                /*0x414f624*/ <>c();
                /*0x414f62c*/ YetiSimCoreLib.Components.GenerateActionsComponent <.cctor>b__32_0();
            }
        }

        class GenerateRapidFireActionsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat> _repeated_actionsToRepeat_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool dummyPrimitiveForEntitas_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat> actionsToRepeat_;

            static /*0x414ff24*/ GenerateRapidFireActionsComponent();
            static /*0x414f680*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent> get_Parser();
            static /*0x414f6d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x414f828*/ GenerateRapidFireActionsComponent();
            /*0x414f8b0*/ GenerateRapidFireActionsComponent(YetiSimCoreLib.Components.GenerateRapidFireActionsComponent other);
            /*0x414f7dc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x414f944*/ YetiSimCoreLib.Components.GenerateRapidFireActionsComponent Clone();
            /*0x414f99c*/ bool get_DummyPrimitiveForEntitas();
            /*0x414f9a4*/ void set_DummyPrimitiveForEntitas(bool value);
            /*0x414f9ac*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat> get_ActionsToRepeat();
            /*0x414f9b4*/ bool Equals(object other);
            /*0x414fa18*/ bool Equals(YetiSimCoreLib.Components.GenerateRapidFireActionsComponent other);
            /*0x414fac8*/ int GetHashCode();
            /*0x414fb58*/ string ToString();
            /*0x414fbb0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x414fbd0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x414fcb0*/ int CalculateSize();
            /*0x414fd68*/ void MergeFrom(YetiSimCoreLib.Components.GenerateRapidFireActionsComponent other);
            /*0x414fe00*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x414fe20*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class Types
            {
                class GenerateRapidFireActionsToRepeat : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int timelineGroupIndex_;
                    /*0x1c*/ int timelineIndex_;
                    /*0x20*/ int ticksRemaining_;

                    static /*0x41507b8*/ GenerateRapidFireActionsToRepeat();
                    static /*0x41500d4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat> get_Parser();
                    static /*0x415012c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x4150244*/ GenerateRapidFireActionsToRepeat();
                    /*0x415024c*/ GenerateRapidFireActionsToRepeat(YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat other);
                    /*0x41501f8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41502a0*/ YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat Clone();
                    /*0x41502f8*/ int get_TimelineGroupIndex();
                    /*0x4150300*/ void set_TimelineGroupIndex(int value);
                    /*0x4150308*/ int get_TimelineIndex();
                    /*0x4150310*/ void set_TimelineIndex(int value);
                    /*0x4150318*/ int get_TicksRemaining();
                    /*0x4150320*/ void set_TicksRemaining(int value);
                    /*0x4150328*/ bool Equals(object other);
                    /*0x415038c*/ bool Equals(YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat other);
                    /*0x41503e8*/ int GetHashCode();
                    /*0x415047c*/ string ToString();
                    /*0x41504d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41504f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41505a4*/ int CalculateSize();
                    /*0x4150684*/ void MergeFrom(YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat other);
                    /*0x41506dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41506fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat.<> <>9;

                        static /*0x41508d0*/ <>c();
                        /*0x4150938*/ <>c();
                        /*0x4150940*/ YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.Types.GenerateRapidFireActionsToRepeat <.cctor>b__37_0();
                    }
                }
            }

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.GenerateRapidFireActionsComponent.<> <>9;

                static /*0x4150994*/ <>c();
                /*0x41509fc*/ <>c();
                /*0x4150a04*/ YetiSimCoreLib.Components.GenerateRapidFireActionsComponent <.cctor>b__33_0();
            }
        }

        class DoActionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DoActionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DoActionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DoActionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DoActionComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4150ec8*/ DoActionComponent();
            static /*0x4150a54*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DoActionComponent> get_Parser();
            static /*0x4150aac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4150bfc*/ DoActionComponent();
            /*0x4150c04*/ DoActionComponent(YetiSimCoreLib.Components.DoActionComponent other);
            /*0x4150bb0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4150c48*/ YetiSimCoreLib.Components.DoActionComponent Clone();
            /*0x4150ca0*/ bool Equals(object other);
            /*0x4150d24*/ bool Equals(YetiSimCoreLib.Components.DoActionComponent other);
            /*0x4150d50*/ int GetHashCode();
            /*0x4150d7c*/ string ToString();
            /*0x4150dd4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4150df4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4150e08*/ int CalculateSize();
            /*0x4150e1c*/ void MergeFrom(YetiSimCoreLib.Components.DoActionComponent other);
            /*0x4150e50*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4150e70*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DoActionComponent.<> <>9;

                static /*0x4150fe0*/ <>c();
                /*0x4151048*/ <>c();
                /*0x4151050*/ YetiSimCoreLib.Components.DoActionComponent <.cctor>b__22_0();
            }
        }

        class DoPlantFoodComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DoPlantFoodComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DoPlantFoodComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DoPlantFoodComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DoPlantFoodComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int delayTicks_;

            static /*0x4151630*/ DoPlantFoodComponent();
            static /*0x41510a4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DoPlantFoodComponent> get_Parser();
            static /*0x41510fc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415124c*/ DoPlantFoodComponent();
            /*0x4151254*/ DoPlantFoodComponent(YetiSimCoreLib.Components.DoPlantFoodComponent other);
            /*0x4151200*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41512a0*/ YetiSimCoreLib.Components.DoPlantFoodComponent Clone();
            /*0x41512f8*/ int get_DelayTicks();
            /*0x4151300*/ void set_DelayTicks(int value);
            /*0x4151308*/ bool Equals(object other);
            /*0x415136c*/ bool Equals(YetiSimCoreLib.Components.DoPlantFoodComponent other);
            /*0x41513a8*/ int GetHashCode();
            /*0x4151404*/ string ToString();
            /*0x415145c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415147c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41514dc*/ int CalculateSize();
            /*0x415155c*/ void MergeFrom(YetiSimCoreLib.Components.DoPlantFoodComponent other);
            /*0x415159c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41515bc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DoPlantFoodComponent.<> <>9;

                static /*0x4151748*/ <>c();
                /*0x41517b0*/ <>c();
                /*0x41517b8*/ YetiSimCoreLib.Components.DoPlantFoodComponent <.cctor>b__27_0();
            }
        }

        class AbilityTimelineTrackerComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityTimelineTrackerComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityTimelineTrackerComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityTimelineTrackerComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityTimelineTrackerComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int timelineGroupIndex_;
            /*0x1c*/ int timelineIndex_;

            static /*0x4151e5c*/ AbilityTimelineTrackerComponent();
            static /*0x415180c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityTimelineTrackerComponent> get_Parser();
            static /*0x4151864*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41519b4*/ AbilityTimelineTrackerComponent();
            /*0x41519bc*/ AbilityTimelineTrackerComponent(YetiSimCoreLib.Components.AbilityTimelineTrackerComponent other);
            /*0x4151968*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4151a08*/ YetiSimCoreLib.Components.AbilityTimelineTrackerComponent Clone();
            /*0x4151a60*/ int get_TimelineGroupIndex();
            /*0x4151a68*/ void set_TimelineGroupIndex(int value);
            /*0x4151a70*/ int get_TimelineIndex();
            /*0x4151a78*/ void set_TimelineIndex(int value);
            /*0x4151a80*/ bool Equals(object other);
            /*0x4151ae4*/ bool Equals(YetiSimCoreLib.Components.AbilityTimelineTrackerComponent other);
            /*0x4151b30*/ int GetHashCode();
            /*0x4151ba8*/ string ToString();
            /*0x4151c00*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4151c20*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4151ca8*/ int CalculateSize();
            /*0x4151d5c*/ void MergeFrom(YetiSimCoreLib.Components.AbilityTimelineTrackerComponent other);
            /*0x4151da8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4151dc8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityTimelineTrackerComponent.<> <>9;

                static /*0x4151f74*/ <>c();
                /*0x4151fdc*/ <>c();
                /*0x4151fe4*/ YetiSimCoreLib.Components.AbilityTimelineTrackerComponent <.cctor>b__32_0();
            }
        }

        class AfterSpawnActionDelayComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4152090*/ AfterSpawnActionDelayComponentReflection();
            static /*0x4152038*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AfterSpawnActionDelayComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AfterSpawnActionDelayComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AfterSpawnActionDelayComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AfterSpawnActionDelayComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AfterSpawnActionDelayComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;
            /*0x1c*/ int ticksTotal_;

            static /*0x4152b64*/ AfterSpawnActionDelayComponent();
            static /*0x4152514*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AfterSpawnActionDelayComponent> get_Parser();
            static /*0x415256c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41526bc*/ AfterSpawnActionDelayComponent();
            /*0x41526c4*/ AfterSpawnActionDelayComponent(YetiSimCoreLib.Components.AfterSpawnActionDelayComponent other);
            /*0x4152670*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4152710*/ YetiSimCoreLib.Components.AfterSpawnActionDelayComponent Clone();
            /*0x4152768*/ int get_TicksRemaining();
            /*0x4152770*/ void set_TicksRemaining(int value);
            /*0x4152778*/ int get_TicksTotal();
            /*0x4152780*/ void set_TicksTotal(int value);
            /*0x4152788*/ bool Equals(object other);
            /*0x41527ec*/ bool Equals(YetiSimCoreLib.Components.AfterSpawnActionDelayComponent other);
            /*0x4152838*/ int GetHashCode();
            /*0x41528b0*/ string ToString();
            /*0x4152908*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4152928*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41529b0*/ int CalculateSize();
            /*0x4152a64*/ void MergeFrom(YetiSimCoreLib.Components.AfterSpawnActionDelayComponent other);
            /*0x4152ab0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4152ad0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AfterSpawnActionDelayComponent.<> <>9;

                static /*0x4152c7c*/ <>c();
                /*0x4152ce4*/ <>c();
                /*0x4152cec*/ YetiSimCoreLib.Components.AfterSpawnActionDelayComponent <.cctor>b__32_0();
            }
        }

        class AfterSpawnTargetableDelayComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4152d98*/ AfterSpawnTargetableDelayComponentReflection();
            static /*0x4152d40*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AfterSpawnTargetableDelayComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x4153774*/ AfterSpawnTargetableDelayComponent();
            static /*0x41531e8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent> get_Parser();
            static /*0x4153240*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4153390*/ AfterSpawnTargetableDelayComponent();
            /*0x4153398*/ AfterSpawnTargetableDelayComponent(YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent other);
            /*0x4153344*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41533e4*/ YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent Clone();
            /*0x415343c*/ int get_TicksRemaining();
            /*0x4153444*/ void set_TicksRemaining(int value);
            /*0x415344c*/ bool Equals(object other);
            /*0x41534b0*/ bool Equals(YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent other);
            /*0x41534ec*/ int GetHashCode();
            /*0x4153548*/ string ToString();
            /*0x41535a0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41535c0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4153620*/ int CalculateSize();
            /*0x41536a0*/ void MergeFrom(YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent other);
            /*0x41536e0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4153700*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent.<> <>9;

                static /*0x415388c*/ <>c();
                /*0x41538f4*/ <>c();
                /*0x41538fc*/ YetiSimCoreLib.Components.AfterSpawnTargetableDelayComponent <.cctor>b__27_0();
            }
        }

        class AllAbilityCooldownComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41539a8*/ AllAbilityCooldownComponentReflection();
            static /*0x4153950*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AllAbilityCooldownComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AllAbilityCooldownComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AllAbilityCooldownComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AllAbilityCooldownComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AllAbilityCooldownComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x4154384*/ AllAbilityCooldownComponent();
            static /*0x4153df8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AllAbilityCooldownComponent> get_Parser();
            static /*0x4153e50*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4153fa0*/ AllAbilityCooldownComponent();
            /*0x4153fa8*/ AllAbilityCooldownComponent(YetiSimCoreLib.Components.AllAbilityCooldownComponent other);
            /*0x4153f54*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4153ff4*/ YetiSimCoreLib.Components.AllAbilityCooldownComponent Clone();
            /*0x415404c*/ int get_TicksRemaining();
            /*0x4154054*/ void set_TicksRemaining(int value);
            /*0x415405c*/ bool Equals(object other);
            /*0x41540c0*/ bool Equals(YetiSimCoreLib.Components.AllAbilityCooldownComponent other);
            /*0x41540fc*/ int GetHashCode();
            /*0x4154158*/ string ToString();
            /*0x41541b0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41541d0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4154230*/ int CalculateSize();
            /*0x41542b0*/ void MergeFrom(YetiSimCoreLib.Components.AllAbilityCooldownComponent other);
            /*0x41542f0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4154310*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AllAbilityCooldownComponent.<> <>9;

                static /*0x415449c*/ <>c();
                /*0x4154504*/ <>c();
                /*0x415450c*/ YetiSimCoreLib.Components.AllAbilityCooldownComponent <.cctor>b__27_0();
            }
        }

        class ArmingComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41545b8*/ ArmingComponentReflection();
            static /*0x4154560*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ArmingComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ArmingComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ArmingComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ArmingComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmingComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x4154ee0*/ ArmingComponent();
            static /*0x4154954*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmingComponent> get_Parser();
            static /*0x41549ac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4154afc*/ ArmingComponent();
            /*0x4154b04*/ ArmingComponent(YetiSimCoreLib.Components.ArmingComponent other);
            /*0x4154ab0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4154b50*/ YetiSimCoreLib.Components.ArmingComponent Clone();
            /*0x4154ba8*/ int get_TicksRemaining();
            /*0x4154bb0*/ void set_TicksRemaining(int value);
            /*0x4154bb8*/ bool Equals(object other);
            /*0x4154c1c*/ bool Equals(YetiSimCoreLib.Components.ArmingComponent other);
            /*0x4154c58*/ int GetHashCode();
            /*0x4154cb4*/ string ToString();
            /*0x4154d0c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4154d2c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4154d8c*/ int CalculateSize();
            /*0x4154e0c*/ void MergeFrom(YetiSimCoreLib.Components.ArmingComponent other);
            /*0x4154e4c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4154e6c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ArmingComponent.<> <>9;

                static /*0x4154ff8*/ <>c();
                /*0x4155060*/ <>c();
                /*0x4155068*/ YetiSimCoreLib.Components.ArmingComponent <.cctor>b__27_0();
            }
        }

        class ArmorComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4155114*/ ArmorComponentReflection();
            static /*0x41550bc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ArmorStack : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ArmorStack>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ArmorStack>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ArmorStack>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorStack> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int currentArmor_;
            /*0x1c*/ int totalArmor_;

            static /*0x4155d64*/ ArmorStack();
            static /*0x4155714*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorStack> get_Parser();
            static /*0x415576c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41558bc*/ ArmorStack();
            /*0x41558c4*/ ArmorStack(YetiSimCoreLib.Components.ArmorStack other);
            /*0x4155870*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4155910*/ YetiSimCoreLib.Components.ArmorStack Clone();
            /*0x4155968*/ int get_CurrentArmor();
            /*0x4155970*/ void set_CurrentArmor(int value);
            /*0x4155978*/ int get_TotalArmor();
            /*0x4155980*/ void set_TotalArmor(int value);
            /*0x4155988*/ bool Equals(object other);
            /*0x41559ec*/ bool Equals(YetiSimCoreLib.Components.ArmorStack other);
            /*0x4155a38*/ int GetHashCode();
            /*0x4155ab0*/ string ToString();
            /*0x4155b08*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4155b28*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4155bb0*/ int CalculateSize();
            /*0x4155c64*/ void MergeFrom(YetiSimCoreLib.Components.ArmorStack other);
            /*0x4155cb0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4155cd0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ArmorStack.<> <>9;

                static /*0x4155e7c*/ <>c();
                /*0x4155ee4*/ <>c();
                /*0x4155eec*/ YetiSimCoreLib.Components.ArmorStack <.cctor>b__32_0();
            }
        }

        class ArmorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ArmorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ArmorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ArmorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<YetiSimCoreLib.Components.ArmorStack> _repeated_stacks_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.ArmorStack> stacks_;
            /*0x20*/ bool stopsDamage_;

            static /*0x41567dc*/ ArmorComponent();
            static /*0x4155f40*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorComponent> get_Parser();
            static /*0x4155f98*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41560e8*/ ArmorComponent();
            /*0x4156170*/ ArmorComponent(YetiSimCoreLib.Components.ArmorComponent other);
            /*0x415609c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4156204*/ YetiSimCoreLib.Components.ArmorComponent Clone();
            /*0x415625c*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.ArmorStack> get_Stacks();
            /*0x4156264*/ bool get_StopsDamage();
            /*0x415626c*/ void set_StopsDamage(bool value);
            /*0x4156274*/ bool Equals(object other);
            /*0x41562d8*/ bool Equals(YetiSimCoreLib.Components.ArmorComponent other);
            /*0x4156388*/ int GetHashCode();
            /*0x4156414*/ string ToString();
            /*0x415646c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415648c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415656c*/ int CalculateSize();
            /*0x4156620*/ void MergeFrom(YetiSimCoreLib.Components.ArmorComponent other);
            /*0x41566b8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41566d8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ArmorComponent.<> <>9;

                static /*0x415698c*/ <>c();
                /*0x41569f4*/ <>c();
                /*0x41569fc*/ YetiSimCoreLib.Components.ArmorComponent <.cctor>b__32_0();
            }
        }

        class ArmorThresholdComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4156aa4*/ ArmorThresholdComponentReflection();
            static /*0x4156a4c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ArmorThresholdComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ArmorThresholdComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ArmorThresholdComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ArmorThresholdComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorThresholdComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int percent_;
            /*0x1c*/ Yeti.Data.UnitMaterialType armoredMaterial_;
            /*0x20*/ Yeti.Data.UnitMaterialType unarmoredMaterial_;

            static /*0x4157758*/ ArmorThresholdComponent();
            static /*0x415703c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorThresholdComponent> get_Parser();
            static /*0x4157094*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41571e4*/ ArmorThresholdComponent();
            /*0x41571ec*/ ArmorThresholdComponent(YetiSimCoreLib.Components.ArmorThresholdComponent other);
            /*0x4157198*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4157240*/ YetiSimCoreLib.Components.ArmorThresholdComponent Clone();
            /*0x4157298*/ int get_Percent();
            /*0x41572a0*/ void set_Percent(int value);
            /*0x41572a8*/ Yeti.Data.UnitMaterialType get_ArmoredMaterial();
            /*0x41572b0*/ void set_ArmoredMaterial(Yeti.Data.UnitMaterialType value);
            /*0x41572b8*/ Yeti.Data.UnitMaterialType get_UnarmoredMaterial();
            /*0x41572c0*/ void set_UnarmoredMaterial(Yeti.Data.UnitMaterialType value);
            /*0x41572c8*/ bool Equals(object other);
            /*0x415732c*/ bool Equals(YetiSimCoreLib.Components.ArmorThresholdComponent other);
            /*0x4157388*/ int GetHashCode();
            /*0x415741c*/ string ToString();
            /*0x4157474*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4157494*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4157544*/ int CalculateSize();
            /*0x4157624*/ void MergeFrom(YetiSimCoreLib.Components.ArmorThresholdComponent other);
            /*0x415767c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415769c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ArmorThresholdComponent.<> <>9;

                static /*0x4157870*/ <>c();
                /*0x41578d8*/ <>c();
                /*0x41578e0*/ YetiSimCoreLib.Components.ArmorThresholdComponent <.cctor>b__37_0();
            }
        }

        class AttackedComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x415798c*/ AttackedComponentReflection();
            static /*0x4157934*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class AttackedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AttackedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AttackedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AttackedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AttackedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int attackerId_;

            static /*0x41582b4*/ AttackedComponent();
            static /*0x4157d28*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AttackedComponent> get_Parser();
            static /*0x4157d80*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4157ed0*/ AttackedComponent();
            /*0x4157ed8*/ AttackedComponent(YetiSimCoreLib.Components.AttackedComponent other);
            /*0x4157e84*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4157f24*/ YetiSimCoreLib.Components.AttackedComponent Clone();
            /*0x4157f7c*/ int get_AttackerId();
            /*0x4157f84*/ void set_AttackerId(int value);
            /*0x4157f8c*/ bool Equals(object other);
            /*0x4157ff0*/ bool Equals(YetiSimCoreLib.Components.AttackedComponent other);
            /*0x415802c*/ int GetHashCode();
            /*0x4158088*/ string ToString();
            /*0x41580e0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4158100*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4158160*/ int CalculateSize();
            /*0x41581e0*/ void MergeFrom(YetiSimCoreLib.Components.AttackedComponent other);
            /*0x4158220*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4158240*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AttackedComponent.<> <>9;

                static /*0x41583cc*/ <>c();
                /*0x4158434*/ <>c();
                /*0x415843c*/ YetiSimCoreLib.Components.AttackedComponent <.cctor>b__27_0();
            }
        }

        class BoardEdgeComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41584e8*/ BoardEdgeComponentReflection();
            static /*0x4158490*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class BoardEdgeComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BoardEdgeComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BoardEdgeComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BoardEdgeComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BoardEdgeComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4158ca4*/ BoardEdgeComponent();
            static /*0x4158830*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BoardEdgeComponent> get_Parser();
            static /*0x4158888*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41589d8*/ BoardEdgeComponent();
            /*0x41589e0*/ BoardEdgeComponent(YetiSimCoreLib.Components.BoardEdgeComponent other);
            /*0x415898c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4158a24*/ YetiSimCoreLib.Components.BoardEdgeComponent Clone();
            /*0x4158a7c*/ bool Equals(object other);
            /*0x4158b00*/ bool Equals(YetiSimCoreLib.Components.BoardEdgeComponent other);
            /*0x4158b2c*/ int GetHashCode();
            /*0x4158b58*/ string ToString();
            /*0x4158bb0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4158bd0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4158be4*/ int CalculateSize();
            /*0x4158bf8*/ void MergeFrom(YetiSimCoreLib.Components.BoardEdgeComponent other);
            /*0x4158c2c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4158c4c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BoardEdgeComponent.<> <>9;

                static /*0x4158dbc*/ <>c();
                /*0x4158e24*/ <>c();
                /*0x4158e2c*/ YetiSimCoreLib.Components.BoardEdgeComponent <.cctor>b__22_0();
            }
        }

        class BossComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4158ed8*/ BossComponentReflection();
            static /*0x4158e80*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class BossComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BossComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BossComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BossComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BossComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4159768*/ BossComponent();
            static /*0x41592f4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BossComponent> get_Parser();
            static /*0x415934c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415949c*/ BossComponent();
            /*0x41594a4*/ BossComponent(YetiSimCoreLib.Components.BossComponent other);
            /*0x4159450*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41594e8*/ YetiSimCoreLib.Components.BossComponent Clone();
            /*0x4159540*/ bool Equals(object other);
            /*0x41595c4*/ bool Equals(YetiSimCoreLib.Components.BossComponent other);
            /*0x41595f0*/ int GetHashCode();
            /*0x415961c*/ string ToString();
            /*0x4159674*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4159694*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41596a8*/ int CalculateSize();
            /*0x41596bc*/ void MergeFrom(YetiSimCoreLib.Components.BossComponent other);
            /*0x41596f0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4159710*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BossComponent.<> <>9;

                static /*0x4159880*/ <>c();
                /*0x41598e8*/ <>c();
                /*0x41598f0*/ YetiSimCoreLib.Components.BossComponent <.cctor>b__22_0();
            }
        }

        class BossObstacleComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BossObstacleComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BossObstacleComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BossObstacleComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BossObstacleComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4159db8*/ BossObstacleComponent();
            static /*0x4159944*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BossObstacleComponent> get_Parser();
            static /*0x415999c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4159aec*/ BossObstacleComponent();
            /*0x4159af4*/ BossObstacleComponent(YetiSimCoreLib.Components.BossObstacleComponent other);
            /*0x4159aa0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4159b38*/ YetiSimCoreLib.Components.BossObstacleComponent Clone();
            /*0x4159b90*/ bool Equals(object other);
            /*0x4159c14*/ bool Equals(YetiSimCoreLib.Components.BossObstacleComponent other);
            /*0x4159c40*/ int GetHashCode();
            /*0x4159c6c*/ string ToString();
            /*0x4159cc4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4159ce4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4159cf8*/ int CalculateSize();
            /*0x4159d0c*/ void MergeFrom(YetiSimCoreLib.Components.BossObstacleComponent other);
            /*0x4159d40*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4159d60*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BossObstacleComponent.<> <>9;

                static /*0x4159ed0*/ <>c();
                /*0x4159f38*/ <>c();
                /*0x4159f40*/ YetiSimCoreLib.Components.BossObstacleComponent <.cctor>b__22_0();
            }
        }

        class BossTrackerComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4159fec*/ BossTrackerComponentReflection();
            static /*0x4159f94*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class BossTrackerComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BossTrackerComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BossTrackerComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BossTrackerComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BossTrackerComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int numBossSpawned_;
            /*0x1c*/ bool hasBossDeathTriggered_;
            /*0x20*/ int bossInstanceId_;

            static /*0x415ac24*/ BossTrackerComponent();
            static /*0x415a4d8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BossTrackerComponent> get_Parser();
            static /*0x415a530*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415a680*/ BossTrackerComponent();
            /*0x415a688*/ BossTrackerComponent(YetiSimCoreLib.Components.BossTrackerComponent other);
            /*0x415a634*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415a6e4*/ YetiSimCoreLib.Components.BossTrackerComponent Clone();
            /*0x415a73c*/ int get_NumBossSpawned();
            /*0x415a744*/ void set_NumBossSpawned(int value);
            /*0x415a74c*/ bool get_HasBossDeathTriggered();
            /*0x415a754*/ void set_HasBossDeathTriggered(bool value);
            /*0x415a75c*/ int get_BossInstanceId();
            /*0x415a764*/ void set_BossInstanceId(int value);
            /*0x415a76c*/ bool Equals(object other);
            /*0x415a7d0*/ bool Equals(YetiSimCoreLib.Components.BossTrackerComponent other);
            /*0x415a83c*/ int GetHashCode();
            /*0x415a8f0*/ string ToString();
            /*0x415a948*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415a968*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415aa18*/ int CalculateSize();
            /*0x415aae4*/ void MergeFrom(YetiSimCoreLib.Components.BossTrackerComponent other);
            /*0x415ab40*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415ab60*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BossTrackerComponent.<> <>9;

                static /*0x415ad3c*/ <>c();
                /*0x415ada4*/ <>c();
                /*0x415adac*/ YetiSimCoreLib.Components.BossTrackerComponent <.cctor>b__37_0();
            }
        }

        class BouncingProjectileComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x415ae58*/ BouncingProjectileComponentReflection();
            static /*0x415ae00*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class BouncingProjectileComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BouncingProjectileComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BouncingProjectileComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BouncingProjectileComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IAttackCounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingProjectileComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int attacksRemaining_;

            static /*0x415b97c*/ BouncingProjectileComponent();
            static /*0x415b3f0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingProjectileComponent> get_Parser();
            static /*0x415b448*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415b598*/ BouncingProjectileComponent();
            /*0x415b5a0*/ BouncingProjectileComponent(YetiSimCoreLib.Components.BouncingProjectileComponent other);
            /*0x415b54c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415b5ec*/ YetiSimCoreLib.Components.BouncingProjectileComponent Clone();
            /*0x415b644*/ int get_AttacksRemaining();
            /*0x415b64c*/ void set_AttacksRemaining(int value);
            /*0x415b654*/ bool Equals(object other);
            /*0x415b6b8*/ bool Equals(YetiSimCoreLib.Components.BouncingProjectileComponent other);
            /*0x415b6f4*/ int GetHashCode();
            /*0x415b750*/ string ToString();
            /*0x415b7a8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415b7c8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415b828*/ int CalculateSize();
            /*0x415b8a8*/ void MergeFrom(YetiSimCoreLib.Components.BouncingProjectileComponent other);
            /*0x415b8e8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415b908*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BouncingProjectileComponent.<> <>9;

                static /*0x415ba94*/ <>c();
                /*0x415bafc*/ <>c();
                /*0x415bb04*/ YetiSimCoreLib.Components.BouncingProjectileComponent <.cctor>b__27_0();
            }
        }

        class AbilityBouncingProjectileComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AbilityBouncingProjectileComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AbilityBouncingProjectileComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AbilityBouncingProjectileComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityBouncingProjectileComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isActive_;

            static /*0x415c0c0*/ AbilityBouncingProjectileComponent();
            static /*0x415bb58*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AbilityBouncingProjectileComponent> get_Parser();
            static /*0x415bbb0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415bd00*/ AbilityBouncingProjectileComponent();
            /*0x415bd08*/ AbilityBouncingProjectileComponent(YetiSimCoreLib.Components.AbilityBouncingProjectileComponent other);
            /*0x415bcb4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415bd54*/ YetiSimCoreLib.Components.AbilityBouncingProjectileComponent Clone();
            /*0x415bdac*/ bool get_IsActive();
            /*0x415bdb4*/ void set_IsActive(bool value);
            /*0x415bdbc*/ bool Equals(object other);
            /*0x415be20*/ bool Equals(YetiSimCoreLib.Components.AbilityBouncingProjectileComponent other);
            /*0x415be6c*/ int GetHashCode();
            /*0x415bedc*/ string ToString();
            /*0x415bf34*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415bf54*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415bfb4*/ int CalculateSize();
            /*0x415bfe0*/ void MergeFrom(YetiSimCoreLib.Components.AbilityBouncingProjectileComponent other);
            /*0x415c024*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415c044*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AbilityBouncingProjectileComponent.<> <>9;

                static /*0x415c1d8*/ <>c();
                /*0x415c240*/ <>c();
                /*0x415c248*/ YetiSimCoreLib.Components.AbilityBouncingProjectileComponent <.cctor>b__27_0();
            }
        }

        class CantReachGoalComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x415c2f4*/ CantReachGoalComponentReflection();
            static /*0x415c29c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class CantReachGoalComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CantReachGoalComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CantReachGoalComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CantReachGoalComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CantReachGoalComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x415ce0c*/ CantReachGoalComponent();
            static /*0x415c880*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CantReachGoalComponent> get_Parser();
            static /*0x415c8d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415ca28*/ CantReachGoalComponent();
            /*0x415ca30*/ CantReachGoalComponent(YetiSimCoreLib.Components.CantReachGoalComponent other);
            /*0x415c9dc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415ca7c*/ YetiSimCoreLib.Components.CantReachGoalComponent Clone();
            /*0x415cad4*/ int get_TicksRemaining();
            /*0x415cadc*/ void set_TicksRemaining(int value);
            /*0x415cae4*/ bool Equals(object other);
            /*0x415cb48*/ bool Equals(YetiSimCoreLib.Components.CantReachGoalComponent other);
            /*0x415cb84*/ int GetHashCode();
            /*0x415cbe0*/ string ToString();
            /*0x415cc38*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415cc58*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415ccb8*/ int CalculateSize();
            /*0x415cd38*/ void MergeFrom(YetiSimCoreLib.Components.CantReachGoalComponent other);
            /*0x415cd78*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415cd98*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CantReachGoalComponent.<> <>9;

                static /*0x415cf24*/ <>c();
                /*0x415cf8c*/ <>c();
                /*0x415cf94*/ YetiSimCoreLib.Components.CantReachGoalComponent <.cctor>b__27_0();
            }
        }

        class PreventsGameEndComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PreventsGameEndComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PreventsGameEndComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PreventsGameEndComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreventsGameEndComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x415d574*/ PreventsGameEndComponent();
            static /*0x415cfe8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreventsGameEndComponent> get_Parser();
            static /*0x415d040*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415d190*/ PreventsGameEndComponent();
            /*0x415d198*/ PreventsGameEndComponent(YetiSimCoreLib.Components.PreventsGameEndComponent other);
            /*0x415d144*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415d1e4*/ YetiSimCoreLib.Components.PreventsGameEndComponent Clone();
            /*0x415d23c*/ int get_TicksRemaining();
            /*0x415d244*/ void set_TicksRemaining(int value);
            /*0x415d24c*/ bool Equals(object other);
            /*0x415d2b0*/ bool Equals(YetiSimCoreLib.Components.PreventsGameEndComponent other);
            /*0x415d2ec*/ int GetHashCode();
            /*0x415d348*/ string ToString();
            /*0x415d3a0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415d3c0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415d420*/ int CalculateSize();
            /*0x415d4a0*/ void MergeFrom(YetiSimCoreLib.Components.PreventsGameEndComponent other);
            /*0x415d4e0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415d500*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PreventsGameEndComponent.<> <>9;

                static /*0x415d68c*/ <>c();
                /*0x415d6f4*/ <>c();
                /*0x415d6fc*/ YetiSimCoreLib.Components.PreventsGameEndComponent <.cctor>b__27_0();
            }
        }

        class CascadeMeterComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x415d7a8*/ CascadeMeterComponentReflection();
            static /*0x415d750*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class CascadeMeterComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CascadeMeterComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CascadeMeterComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CascadeMeterComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CascadeMeterComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int points_;

            static /*0x415e0d0*/ CascadeMeterComponent();
            static /*0x415db44*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CascadeMeterComponent> get_Parser();
            static /*0x415db9c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415dcec*/ CascadeMeterComponent();
            /*0x415dcf4*/ CascadeMeterComponent(YetiSimCoreLib.Components.CascadeMeterComponent other);
            /*0x415dca0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415dd40*/ YetiSimCoreLib.Components.CascadeMeterComponent Clone();
            /*0x415dd98*/ int get_Points();
            /*0x415dda0*/ void set_Points(int value);
            /*0x415dda8*/ bool Equals(object other);
            /*0x415de0c*/ bool Equals(YetiSimCoreLib.Components.CascadeMeterComponent other);
            /*0x415de48*/ int GetHashCode();
            /*0x415dea4*/ string ToString();
            /*0x415defc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415df1c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415df7c*/ int CalculateSize();
            /*0x415dffc*/ void MergeFrom(YetiSimCoreLib.Components.CascadeMeterComponent other);
            /*0x415e03c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415e05c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CascadeMeterComponent.<> <>9;

                static /*0x415e1e8*/ <>c();
                /*0x415e250*/ <>c();
                /*0x415e258*/ YetiSimCoreLib.Components.CascadeMeterComponent <.cctor>b__27_0();
            }
        }

        class CausedByDamageOverTimeComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x415e304*/ CausedByDamageOverTimeComponentReflection();
            static /*0x415e2ac*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class CausedByDamageOverTimeComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CausedByDamageOverTimeComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CausedByDamageOverTimeComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CausedByDamageOverTimeComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CausedByDamageOverTimeComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x415eac0*/ CausedByDamageOverTimeComponent();
            static /*0x415e64c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CausedByDamageOverTimeComponent> get_Parser();
            static /*0x415e6a4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415e7f4*/ CausedByDamageOverTimeComponent();
            /*0x415e7fc*/ CausedByDamageOverTimeComponent(YetiSimCoreLib.Components.CausedByDamageOverTimeComponent other);
            /*0x415e7a8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415e840*/ YetiSimCoreLib.Components.CausedByDamageOverTimeComponent Clone();
            /*0x415e898*/ bool Equals(object other);
            /*0x415e91c*/ bool Equals(YetiSimCoreLib.Components.CausedByDamageOverTimeComponent other);
            /*0x415e948*/ int GetHashCode();
            /*0x415e974*/ string ToString();
            /*0x415e9cc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415e9ec*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415ea00*/ int CalculateSize();
            /*0x415ea14*/ void MergeFrom(YetiSimCoreLib.Components.CausedByDamageOverTimeComponent other);
            /*0x415ea48*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415ea68*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CausedByDamageOverTimeComponent.<> <>9;

                static /*0x415ebd8*/ <>c();
                /*0x415ec40*/ <>c();
                /*0x415ec48*/ YetiSimCoreLib.Components.CausedByDamageOverTimeComponent <.cctor>b__22_0();
            }
        }

        class CollidingComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x415ecf4*/ CollidingComponentReflection();
            static /*0x415ec9c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class CollidingComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CollidingComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CollidingComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CollidingComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CollidingComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_collidingEntities_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> collidingEntities_;

            static /*0x415f850*/ CollidingComponent();
            static /*0x415f090*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CollidingComponent> get_Parser();
            static /*0x415f0e8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x415f238*/ CollidingComponent();
            /*0x415f2c0*/ CollidingComponent(YetiSimCoreLib.Components.CollidingComponent other);
            /*0x415f1ec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x415f34c*/ YetiSimCoreLib.Components.CollidingComponent Clone();
            /*0x415f3a4*/ Google.Protobuf.Collections.RepeatedField<int> get_CollidingEntities();
            /*0x415f3ac*/ bool Equals(object other);
            /*0x415f410*/ bool Equals(YetiSimCoreLib.Components.CollidingComponent other);
            /*0x415f4a0*/ int GetHashCode();
            /*0x415f4ec*/ string ToString();
            /*0x415f544*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x415f564*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x415f61c*/ int CalculateSize();
            /*0x415f6c4*/ void MergeFrom(YetiSimCoreLib.Components.CollidingComponent other);
            /*0x415f74c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x415f76c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CollidingComponent.<> <>9;

                static /*0x415f98c*/ <>c();
                /*0x415f9f4*/ <>c();
                /*0x415f9fc*/ YetiSimCoreLib.Components.CollidingComponent <.cctor>b__27_0();
            }
        }

        class ConsumedProjectileComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x415faa4*/ ConsumedProjectileComponentReflection();
            static /*0x415fa4c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ConsumedProjectileComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ConsumedProjectileComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ConsumedProjectileComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ConsumedProjectileComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ConsumedProjectileComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int remainingConsumers_;

            static /*0x41605c8*/ ConsumedProjectileComponent();
            static /*0x416003c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ConsumedProjectileComponent> get_Parser();
            static /*0x4160094*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41601e4*/ ConsumedProjectileComponent();
            /*0x41601ec*/ ConsumedProjectileComponent(YetiSimCoreLib.Components.ConsumedProjectileComponent other);
            /*0x4160198*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4160238*/ YetiSimCoreLib.Components.ConsumedProjectileComponent Clone();
            /*0x4160290*/ int get_RemainingConsumers();
            /*0x4160298*/ void set_RemainingConsumers(int value);
            /*0x41602a0*/ bool Equals(object other);
            /*0x4160304*/ bool Equals(YetiSimCoreLib.Components.ConsumedProjectileComponent other);
            /*0x4160340*/ int GetHashCode();
            /*0x416039c*/ string ToString();
            /*0x41603f4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4160414*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4160474*/ int CalculateSize();
            /*0x41604f4*/ void MergeFrom(YetiSimCoreLib.Components.ConsumedProjectileComponent other);
            /*0x4160534*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4160554*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ConsumedProjectileComponent.<> <>9;

                static /*0x41606e0*/ <>c();
                /*0x4160748*/ <>c();
                /*0x4160750*/ YetiSimCoreLib.Components.ConsumedProjectileComponent <.cctor>b__27_0();
            }
        }

        class ProjectileConsumerComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ProjectileConsumerComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ProjectileConsumerComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ProjectileConsumerComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ProjectileConsumerComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int projectileId_;

            static /*0x4160d30*/ ProjectileConsumerComponent();
            static /*0x41607a4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ProjectileConsumerComponent> get_Parser();
            static /*0x41607fc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416094c*/ ProjectileConsumerComponent();
            /*0x4160954*/ ProjectileConsumerComponent(YetiSimCoreLib.Components.ProjectileConsumerComponent other);
            /*0x4160900*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41609a0*/ YetiSimCoreLib.Components.ProjectileConsumerComponent Clone();
            /*0x41609f8*/ int get_ProjectileId();
            /*0x4160a00*/ void set_ProjectileId(int value);
            /*0x4160a08*/ bool Equals(object other);
            /*0x4160a6c*/ bool Equals(YetiSimCoreLib.Components.ProjectileConsumerComponent other);
            /*0x4160aa8*/ int GetHashCode();
            /*0x4160b04*/ string ToString();
            /*0x4160b5c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4160b7c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4160bdc*/ int CalculateSize();
            /*0x4160c5c*/ void MergeFrom(YetiSimCoreLib.Components.ProjectileConsumerComponent other);
            /*0x4160c9c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4160cbc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ProjectileConsumerComponent.<> <>9;

                static /*0x4160e48*/ <>c();
                /*0x4160eb0*/ <>c();
                /*0x4160eb8*/ YetiSimCoreLib.Components.ProjectileConsumerComponent <.cctor>b__27_0();
            }
        }

        class CritHitComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4160f64*/ CritHitComponentReflection();
            static /*0x4160f0c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class CritHitComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CritHitComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CritHitComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CritHitComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IAttackCounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritHitComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int attacksRemaining_;

            static /*0x416188c*/ CritHitComponent();
            static /*0x4161300*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritHitComponent> get_Parser();
            static /*0x4161358*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41614a8*/ CritHitComponent();
            /*0x41614b0*/ CritHitComponent(YetiSimCoreLib.Components.CritHitComponent other);
            /*0x416145c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41614fc*/ YetiSimCoreLib.Components.CritHitComponent Clone();
            /*0x4161554*/ int get_AttacksRemaining();
            /*0x416155c*/ void set_AttacksRemaining(int value);
            /*0x4161564*/ bool Equals(object other);
            /*0x41615c8*/ bool Equals(YetiSimCoreLib.Components.CritHitComponent other);
            /*0x4161604*/ int GetHashCode();
            /*0x4161660*/ string ToString();
            /*0x41616b8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41616d8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4161738*/ int CalculateSize();
            /*0x41617b8*/ void MergeFrom(YetiSimCoreLib.Components.CritHitComponent other);
            /*0x41617f8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4161818*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CritHitComponent.<> <>9;

                static /*0x41619a4*/ <>c();
                /*0x4161a0c*/ <>c();
                /*0x4161a14*/ YetiSimCoreLib.Components.CritHitComponent <.cctor>b__27_0();
            }
        }

        class DamageRedirectionComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4161ac0*/ DamageRedirectionComponentReflection();
            static /*0x4161a68*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class DamageRedirectionProtectorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DamageRedirectionProtectorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DamageRedirectionProtectorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DamageRedirectionProtectorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageRedirectionProtectorComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_mustHaveAnyOfTags_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_mustHaveAllOfTags_codec;
            static /*0x18*/ Google.Protobuf.FieldCodec<int> _repeated_mustNotHaveAnyOfTags_codec;
            static /*0x20*/ Google.Protobuf.FieldCodec<int> _repeated_protectedInstanceIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int targetPatternId_;
            /*0x1c*/ int numRedirects_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> mustHaveAnyOfTags_;
            /*0x28*/ Google.Protobuf.Collections.RepeatedField<int> mustHaveAllOfTags_;
            /*0x30*/ Google.Protobuf.Collections.RepeatedField<int> mustNotHaveAnyOfTags_;
            /*0x38*/ Google.Protobuf.Collections.RepeatedField<int> protectedInstanceIds_;

            static /*0x4162eec*/ DamageRedirectionProtectorComponent();
            static /*0x41621f8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageRedirectionProtectorComponent> get_Parser();
            static /*0x4162250*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41623a0*/ DamageRedirectionProtectorComponent();
            /*0x4162494*/ DamageRedirectionProtectorComponent(YetiSimCoreLib.Components.DamageRedirectionProtectorComponent other);
            /*0x4162354*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4162588*/ YetiSimCoreLib.Components.DamageRedirectionProtectorComponent Clone();
            /*0x41625e0*/ int get_TargetPatternId();
            /*0x41625e8*/ void set_TargetPatternId(int value);
            /*0x41625f0*/ int get_NumRedirects();
            /*0x41625f8*/ void set_NumRedirects(int value);
            /*0x4162600*/ Google.Protobuf.Collections.RepeatedField<int> get_MustHaveAnyOfTags();
            /*0x4162608*/ Google.Protobuf.Collections.RepeatedField<int> get_MustHaveAllOfTags();
            /*0x4162610*/ Google.Protobuf.Collections.RepeatedField<int> get_MustNotHaveAnyOfTags();
            /*0x4162618*/ Google.Protobuf.Collections.RepeatedField<int> get_ProtectedInstanceIds();
            /*0x4162620*/ bool Equals(object other);
            /*0x4162684*/ bool Equals(YetiSimCoreLib.Components.DamageRedirectionProtectorComponent other);
            /*0x416277c*/ int GetHashCode();
            /*0x4162878*/ string ToString();
            /*0x41628d0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41628f0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4162a58*/ int CalculateSize();
            /*0x4162bf4*/ void MergeFrom(YetiSimCoreLib.Components.DamageRedirectionProtectorComponent other);
            /*0x4162cd0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4162cf0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DamageRedirectionProtectorComponent.<> <>9;

                static /*0x4163094*/ <>c();
                /*0x41630fc*/ <>c();
                /*0x4163104*/ YetiSimCoreLib.Components.DamageRedirectionProtectorComponent <.cctor>b__52_0();
            }
        }

        class DamageRedirectionProtectedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DamageRedirectionProtectedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DamageRedirectionProtectedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DamageRedirectionProtectedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageRedirectionProtectedComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_protectorIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> protectorIds_;

            static /*0x4163914*/ DamageRedirectionProtectedComponent();
            static /*0x4163154*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageRedirectionProtectedComponent> get_Parser();
            static /*0x41631ac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41632fc*/ DamageRedirectionProtectedComponent();
            /*0x4163384*/ DamageRedirectionProtectedComponent(YetiSimCoreLib.Components.DamageRedirectionProtectedComponent other);
            /*0x41632b0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4163410*/ YetiSimCoreLib.Components.DamageRedirectionProtectedComponent Clone();
            /*0x4163468*/ Google.Protobuf.Collections.RepeatedField<int> get_ProtectorIds();
            /*0x4163470*/ bool Equals(object other);
            /*0x41634d4*/ bool Equals(YetiSimCoreLib.Components.DamageRedirectionProtectedComponent other);
            /*0x4163564*/ int GetHashCode();
            /*0x41635b0*/ string ToString();
            /*0x4163608*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4163628*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41636e0*/ int CalculateSize();
            /*0x4163788*/ void MergeFrom(YetiSimCoreLib.Components.DamageRedirectionProtectedComponent other);
            /*0x4163810*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4163830*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DamageRedirectionProtectedComponent.<> <>9;

                static /*0x4163a50*/ <>c();
                /*0x4163ab8*/ <>c();
                /*0x4163ac0*/ YetiSimCoreLib.Components.DamageRedirectionProtectedComponent <.cctor>b__27_0();
            }
        }

        class DamageTypeComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4163b68*/ DamageTypeComponentReflection();
            static /*0x4163b10*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class DamageTypeComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DamageTypeComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DamageTypeComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DamageTypeComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageTypeComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int id_;

            static /*0x4164658*/ DamageTypeComponent();
            static /*0x41640cc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageTypeComponent> get_Parser();
            static /*0x4164124*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4164274*/ DamageTypeComponent();
            /*0x416427c*/ DamageTypeComponent(YetiSimCoreLib.Components.DamageTypeComponent other);
            /*0x4164228*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41642c8*/ YetiSimCoreLib.Components.DamageTypeComponent Clone();
            /*0x4164320*/ int get_Id();
            /*0x4164328*/ void set_Id(int value);
            /*0x4164330*/ bool Equals(object other);
            /*0x4164394*/ bool Equals(YetiSimCoreLib.Components.DamageTypeComponent other);
            /*0x41643d0*/ int GetHashCode();
            /*0x416442c*/ string ToString();
            /*0x4164484*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41644a4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4164504*/ int CalculateSize();
            /*0x4164584*/ void MergeFrom(YetiSimCoreLib.Components.DamageTypeComponent other);
            /*0x41645c4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41645e4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DamageTypeComponent.<> <>9;

                static /*0x4164770*/ <>c();
                /*0x41647d8*/ <>c();
                /*0x41647e0*/ YetiSimCoreLib.Components.DamageTypeComponent <.cctor>b__27_0();
            }
        }

        class DamageTypeImmunityComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DamageTypeImmunityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DamageTypeImmunityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DamageTypeImmunityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageTypeImmunityComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_ids_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> ids_;

            static /*0x4164ff4*/ DamageTypeImmunityComponent();
            static /*0x4164834*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageTypeImmunityComponent> get_Parser();
            static /*0x416488c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41649dc*/ DamageTypeImmunityComponent();
            /*0x4164a64*/ DamageTypeImmunityComponent(YetiSimCoreLib.Components.DamageTypeImmunityComponent other);
            /*0x4164990*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4164af0*/ YetiSimCoreLib.Components.DamageTypeImmunityComponent Clone();
            /*0x4164b48*/ Google.Protobuf.Collections.RepeatedField<int> get_Ids();
            /*0x4164b50*/ bool Equals(object other);
            /*0x4164bb4*/ bool Equals(YetiSimCoreLib.Components.DamageTypeImmunityComponent other);
            /*0x4164c44*/ int GetHashCode();
            /*0x4164c90*/ string ToString();
            /*0x4164ce8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4164d08*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4164dc0*/ int CalculateSize();
            /*0x4164e68*/ void MergeFrom(YetiSimCoreLib.Components.DamageTypeImmunityComponent other);
            /*0x4164ef0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4164f10*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DamageTypeImmunityComponent.<> <>9;

                static /*0x4165130*/ <>c();
                /*0x4165198*/ <>c();
                /*0x41651a0*/ YetiSimCoreLib.Components.DamageTypeImmunityComponent <.cctor>b__27_0();
            }
        }

        class DeadComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4165248*/ DeadComponentReflection();
            static /*0x41651f0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class DeadComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DeadComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DeadComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DeadComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DeadComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4165c74*/ DeadComponent();
            static /*0x4165800*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DeadComponent> get_Parser();
            static /*0x4165858*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41659a8*/ DeadComponent();
            /*0x41659b0*/ DeadComponent(YetiSimCoreLib.Components.DeadComponent other);
            /*0x416595c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41659f4*/ YetiSimCoreLib.Components.DeadComponent Clone();
            /*0x4165a4c*/ bool Equals(object other);
            /*0x4165ad0*/ bool Equals(YetiSimCoreLib.Components.DeadComponent other);
            /*0x4165afc*/ int GetHashCode();
            /*0x4165b28*/ string ToString();
            /*0x4165b80*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4165ba0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4165bb4*/ int CalculateSize();
            /*0x4165bc8*/ void MergeFrom(YetiSimCoreLib.Components.DeadComponent other);
            /*0x4165bfc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4165c1c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DeadComponent.<> <>9;

                static /*0x4165d8c*/ <>c();
                /*0x4165df4*/ <>c();
                /*0x4165dfc*/ YetiSimCoreLib.Components.DeadComponent <.cctor>b__22_0();
            }
        }

        class RemovedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RemovedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RemovedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RemovedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RemovedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41662c4*/ RemovedComponent();
            static /*0x4165e50*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RemovedComponent> get_Parser();
            static /*0x4165ea8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4165ff8*/ RemovedComponent();
            /*0x4166000*/ RemovedComponent(YetiSimCoreLib.Components.RemovedComponent other);
            /*0x4165fac*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4166044*/ YetiSimCoreLib.Components.RemovedComponent Clone();
            /*0x416609c*/ bool Equals(object other);
            /*0x4166120*/ bool Equals(YetiSimCoreLib.Components.RemovedComponent other);
            /*0x416614c*/ int GetHashCode();
            /*0x4166178*/ string ToString();
            /*0x41661d0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41661f0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4166204*/ int CalculateSize();
            /*0x4166218*/ void MergeFrom(YetiSimCoreLib.Components.RemovedComponent other);
            /*0x416624c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416626c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RemovedComponent.<> <>9;

                static /*0x41663dc*/ <>c();
                /*0x4166444*/ <>c();
                /*0x416644c*/ YetiSimCoreLib.Components.RemovedComponent <.cctor>b__22_0();
            }
        }

        class GeneratesNoScoreComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GeneratesNoScoreComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GeneratesNoScoreComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GeneratesNoScoreComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GeneratesNoScoreComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4166914*/ GeneratesNoScoreComponent();
            static /*0x41664a0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GeneratesNoScoreComponent> get_Parser();
            static /*0x41664f8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4166648*/ GeneratesNoScoreComponent();
            /*0x4166650*/ GeneratesNoScoreComponent(YetiSimCoreLib.Components.GeneratesNoScoreComponent other);
            /*0x41665fc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4166694*/ YetiSimCoreLib.Components.GeneratesNoScoreComponent Clone();
            /*0x41666ec*/ bool Equals(object other);
            /*0x4166770*/ bool Equals(YetiSimCoreLib.Components.GeneratesNoScoreComponent other);
            /*0x416679c*/ int GetHashCode();
            /*0x41667c8*/ string ToString();
            /*0x4166820*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4166840*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4166854*/ int CalculateSize();
            /*0x4166868*/ void MergeFrom(YetiSimCoreLib.Components.GeneratesNoScoreComponent other);
            /*0x416689c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41668bc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.GeneratesNoScoreComponent.<> <>9;

                static /*0x4166a2c*/ <>c();
                /*0x4166a94*/ <>c();
                /*0x4166a9c*/ YetiSimCoreLib.Components.GeneratesNoScoreComponent <.cctor>b__22_0();
            }
        }

        class DropsItemsOnDeathComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4166b48*/ DropsItemsOnDeathComponentReflection();
            static /*0x4166af0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class DropsItemsOnDeathComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DropsItemsOnDeathComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DropsItemsOnDeathComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DropsItemsOnDeathComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DropsItemsOnDeathComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int dropTableId_;

            static /*0x4167470*/ DropsItemsOnDeathComponent();
            static /*0x4166ee4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DropsItemsOnDeathComponent> get_Parser();
            static /*0x4166f3c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416708c*/ DropsItemsOnDeathComponent();
            /*0x4167094*/ DropsItemsOnDeathComponent(YetiSimCoreLib.Components.DropsItemsOnDeathComponent other);
            /*0x4167040*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41670e0*/ YetiSimCoreLib.Components.DropsItemsOnDeathComponent Clone();
            /*0x4167138*/ int get_DropTableId();
            /*0x4167140*/ void set_DropTableId(int value);
            /*0x4167148*/ bool Equals(object other);
            /*0x41671ac*/ bool Equals(YetiSimCoreLib.Components.DropsItemsOnDeathComponent other);
            /*0x41671e8*/ int GetHashCode();
            /*0x4167244*/ string ToString();
            /*0x416729c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41672bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416731c*/ int CalculateSize();
            /*0x416739c*/ void MergeFrom(YetiSimCoreLib.Components.DropsItemsOnDeathComponent other);
            /*0x41673dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41673fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DropsItemsOnDeathComponent.<> <>9;

                static /*0x4167588*/ <>c();
                /*0x41675f0*/ <>c();
                /*0x41675f8*/ YetiSimCoreLib.Components.DropsItemsOnDeathComponent <.cctor>b__27_0();
            }
        }

        class DynamicDropComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41676a4*/ DynamicDropComponentReflection();
            static /*0x416764c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class DynamicDropComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DynamicDropComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DynamicDropComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DynamicDropComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DynamicDropComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.DynamicDropDefinition dropDefinition_;

            static /*0x4168290*/ DynamicDropComponent();
            static /*0x4167ba0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DynamicDropComponent> get_Parser();
            static /*0x4167bf8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4167d48*/ DynamicDropComponent();
            /*0x4167d50*/ DynamicDropComponent(YetiSimCoreLib.Components.DynamicDropComponent other);
            /*0x4167cfc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4167dc0*/ YetiSimCoreLib.Components.DynamicDropComponent Clone();
            /*0x4167e18*/ Yeti.Data.DynamicDropDefinition get_DropDefinition();
            /*0x4167e20*/ void set_DropDefinition(Yeti.Data.DynamicDropDefinition value);
            /*0x4167e28*/ bool Equals(object other);
            /*0x4167e8c*/ bool Equals(YetiSimCoreLib.Components.DynamicDropComponent other);
            /*0x4167eec*/ int GetHashCode();
            /*0x4167f40*/ string ToString();
            /*0x4167f98*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4167fb8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4168018*/ int CalculateSize();
            /*0x4168098*/ void MergeFrom(YetiSimCoreLib.Components.DynamicDropComponent other);
            /*0x4168164*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4168184*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DynamicDropComponent.<> <>9;

                static /*0x41683a8*/ <>c();
                /*0x4168410*/ <>c();
                /*0x4168418*/ YetiSimCoreLib.Components.DynamicDropComponent <.cctor>b__27_0();
            }
        }

        class FactionsReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41684c4*/ FactionsReflection();
            static /*0x416846c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PlantComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PlantComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PlantComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PlantComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PlantComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4168d54*/ PlantComponent();
            static /*0x41688e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PlantComponent> get_Parser();
            static /*0x4168938*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4168a88*/ PlantComponent();
            /*0x4168a90*/ PlantComponent(YetiSimCoreLib.Components.PlantComponent other);
            /*0x4168a3c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4168ad4*/ YetiSimCoreLib.Components.PlantComponent Clone();
            /*0x4168b2c*/ bool Equals(object other);
            /*0x4168bb0*/ bool Equals(YetiSimCoreLib.Components.PlantComponent other);
            /*0x4168bdc*/ int GetHashCode();
            /*0x4168c08*/ string ToString();
            /*0x4168c60*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4168c80*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4168c94*/ int CalculateSize();
            /*0x4168ca8*/ void MergeFrom(YetiSimCoreLib.Components.PlantComponent other);
            /*0x4168cdc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4168cfc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PlantComponent.<> <>9;

                static /*0x4168e6c*/ <>c();
                /*0x4168ed4*/ <>c();
                /*0x4168edc*/ YetiSimCoreLib.Components.PlantComponent <.cctor>b__22_0();
            }
        }

        class ZombieComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ZombieComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ZombieComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ZombieComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ZombieComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41693a4*/ ZombieComponent();
            static /*0x4168f30*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ZombieComponent> get_Parser();
            static /*0x4168f88*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41690d8*/ ZombieComponent();
            /*0x41690e0*/ ZombieComponent(YetiSimCoreLib.Components.ZombieComponent other);
            /*0x416908c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4169124*/ YetiSimCoreLib.Components.ZombieComponent Clone();
            /*0x416917c*/ bool Equals(object other);
            /*0x4169200*/ bool Equals(YetiSimCoreLib.Components.ZombieComponent other);
            /*0x416922c*/ int GetHashCode();
            /*0x4169258*/ string ToString();
            /*0x41692b0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41692d0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41692e4*/ int CalculateSize();
            /*0x41692f8*/ void MergeFrom(YetiSimCoreLib.Components.ZombieComponent other);
            /*0x416932c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416934c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ZombieComponent.<> <>9;

                static /*0x41694bc*/ <>c();
                /*0x4169524*/ <>c();
                /*0x416952c*/ YetiSimCoreLib.Components.ZombieComponent <.cctor>b__22_0();
            }
        }

        class ForcePrioritizeAbilityBehaviorComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41695d8*/ ForcePrioritizeAbilityBehaviorComponentReflection();
            static /*0x4169580*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ForcePrioritizeAbilityBehaviorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int abilityId_;

            static /*0x4169fb4*/ ForcePrioritizeAbilityBehaviorComponent();
            static /*0x4169a28*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent> get_Parser();
            static /*0x4169a80*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4169bd0*/ ForcePrioritizeAbilityBehaviorComponent();
            /*0x4169bd8*/ ForcePrioritizeAbilityBehaviorComponent(YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent other);
            /*0x4169b84*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4169c24*/ YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent Clone();
            /*0x4169c7c*/ int get_AbilityId();
            /*0x4169c84*/ void set_AbilityId(int value);
            /*0x4169c8c*/ bool Equals(object other);
            /*0x4169cf0*/ bool Equals(YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent other);
            /*0x4169d2c*/ int GetHashCode();
            /*0x4169d88*/ string ToString();
            /*0x4169de0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4169e00*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4169e60*/ int CalculateSize();
            /*0x4169ee0*/ void MergeFrom(YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent other);
            /*0x4169f20*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4169f40*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent.<> <>9;

                static /*0x416a0cc*/ <>c();
                /*0x416a134*/ <>c();
                /*0x416a13c*/ YetiSimCoreLib.Components.ForcePrioritizeAbilityBehaviorComponent <.cctor>b__27_0();
            }
        }

        class FormationComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x416a1e8*/ FormationComponentReflection();
            static /*0x416a190*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class FormationParentComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FormationParentComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FormationParentComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FormationParentComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FormationParentComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_childInstanceIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> childInstanceIds_;
            /*0x20*/ int currentChildCount_;
            /*0x24*/ int childUnitId_;
            /*0x28*/ int childXOffset_;
            /*0x2c*/ int childYOffset_;
            /*0x30*/ int childZOffset_;
            /*0x34*/ bool childrenGenerateScore_;
            /*0x35*/ bool preserveLinkOnMovingAbilities_;
            /*0x38*/ int overrideXSpeed_;
            /*0x3c*/ bool childrenIneligibleForCoins_;
            /*0x3d*/ bool childrenIneligibleForCascade_;
            /*0x3e*/ bool childrenIneligibleForLeaderboard_;
            /*0x3f*/ bool childrenCannotAttack_;
            /*0x40*/ bool syncForcedMovementOnChildren_;

            static /*0x416c18c*/ FormationParentComponent();
            static /*0x416af0c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FormationParentComponent> get_Parser();
            static /*0x416af64*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416b0b4*/ FormationParentComponent();
            /*0x416b13c*/ FormationParentComponent(YetiSimCoreLib.Components.FormationParentComponent other);
            /*0x416b068*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416b1f8*/ YetiSimCoreLib.Components.FormationParentComponent Clone();
            /*0x416b250*/ Google.Protobuf.Collections.RepeatedField<int> get_ChildInstanceIds();
            /*0x416b258*/ int get_CurrentChildCount();
            /*0x416b260*/ void set_CurrentChildCount(int value);
            /*0x416b268*/ int get_ChildUnitId();
            /*0x416b270*/ void set_ChildUnitId(int value);
            /*0x416b278*/ int get_ChildXOffset();
            /*0x416b280*/ void set_ChildXOffset(int value);
            /*0x416b288*/ int get_ChildYOffset();
            /*0x416b290*/ void set_ChildYOffset(int value);
            /*0x416b298*/ int get_ChildZOffset();
            /*0x416b2a0*/ void set_ChildZOffset(int value);
            /*0x416b2a8*/ bool get_ChildrenGenerateScore();
            /*0x416b2b0*/ void set_ChildrenGenerateScore(bool value);
            /*0x416b2b8*/ bool get_PreserveLinkOnMovingAbilities();
            /*0x416b2c0*/ void set_PreserveLinkOnMovingAbilities(bool value);
            /*0x416b2c8*/ int get_OverrideXSpeed();
            /*0x416b2d0*/ void set_OverrideXSpeed(int value);
            /*0x416b2d8*/ bool get_ChildrenIneligibleForCoins();
            /*0x416b2e0*/ void set_ChildrenIneligibleForCoins(bool value);
            /*0x416b2e8*/ bool get_ChildrenIneligibleForCascade();
            /*0x416b2f0*/ void set_ChildrenIneligibleForCascade(bool value);
            /*0x416b2f8*/ bool get_ChildrenIneligibleForLeaderboard();
            /*0x416b300*/ void set_ChildrenIneligibleForLeaderboard(bool value);
            /*0x416b308*/ bool get_ChildrenCannotAttack();
            /*0x416b310*/ void set_ChildrenCannotAttack(bool value);
            /*0x416b318*/ bool get_SyncForcedMovementOnChildren();
            /*0x416b320*/ void set_SyncForcedMovementOnChildren(bool value);
            /*0x416b328*/ bool Equals(object other);
            /*0x416b38c*/ bool Equals(YetiSimCoreLib.Components.FormationParentComponent other);
            /*0x416b55c*/ int GetHashCode();
            /*0x416b7bc*/ string ToString();
            /*0x416b814*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416b834*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416baf4*/ int CalculateSize();
            /*0x416bd2c*/ void MergeFrom(YetiSimCoreLib.Components.FormationParentComponent other);
            /*0x416be6c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416be8c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FormationParentComponent.<> <>9;

                static /*0x416c2c8*/ <>c();
                /*0x416c330*/ <>c();
                /*0x416c338*/ YetiSimCoreLib.Components.FormationParentComponent <.cctor>b__92_0();
            }
        }

        class FormationChildComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FormationChildComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FormationChildComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FormationChildComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FormationChildComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int parentId_;
            /*0x1c*/ int xOffset_;
            /*0x20*/ int yOffset_;
            /*0x24*/ int zOffset_;
            /*0x28*/ bool cannotAttack_;

            static /*0x416cc4c*/ FormationChildComponent();
            static /*0x416c38c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FormationChildComponent> get_Parser();
            static /*0x416c3e4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416c534*/ FormationChildComponent();
            /*0x416c53c*/ FormationChildComponent(YetiSimCoreLib.Components.FormationChildComponent other);
            /*0x416c4e8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416c590*/ YetiSimCoreLib.Components.FormationChildComponent Clone();
            /*0x416c5e8*/ int get_ParentId();
            /*0x416c5f0*/ void set_ParentId(int value);
            /*0x416c5f8*/ int get_XOffset();
            /*0x416c600*/ void set_XOffset(int value);
            /*0x416c608*/ int get_YOffset();
            /*0x416c610*/ void set_YOffset(int value);
            /*0x416c618*/ int get_ZOffset();
            /*0x416c620*/ void set_ZOffset(int value);
            /*0x416c628*/ bool get_CannotAttack();
            /*0x416c630*/ void set_CannotAttack(bool value);
            /*0x416c638*/ bool Equals(object other);
            /*0x416c69c*/ bool Equals(YetiSimCoreLib.Components.FormationChildComponent other);
            /*0x416c728*/ int GetHashCode();
            /*0x416c814*/ string ToString();
            /*0x416c86c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416c88c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416c98c*/ int CalculateSize();
            /*0x416cab0*/ void MergeFrom(YetiSimCoreLib.Components.FormationChildComponent other);
            /*0x416cb24*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416cb44*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FormationChildComponent.<> <>9;

                static /*0x416cd64*/ <>c();
                /*0x416cdcc*/ <>c();
                /*0x416cdd4*/ YetiSimCoreLib.Components.FormationChildComponent <.cctor>b__47_0();
            }
        }

        class FormationStoppedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FormationStoppedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FormationStoppedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FormationStoppedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FormationStoppedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x416d29c*/ FormationStoppedComponent();
            static /*0x416ce28*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FormationStoppedComponent> get_Parser();
            static /*0x416ce80*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416cfd0*/ FormationStoppedComponent();
            /*0x416cfd8*/ FormationStoppedComponent(YetiSimCoreLib.Components.FormationStoppedComponent other);
            /*0x416cf84*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416d01c*/ YetiSimCoreLib.Components.FormationStoppedComponent Clone();
            /*0x416d074*/ bool Equals(object other);
            /*0x416d0f8*/ bool Equals(YetiSimCoreLib.Components.FormationStoppedComponent other);
            /*0x416d124*/ int GetHashCode();
            /*0x416d150*/ string ToString();
            /*0x416d1a8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416d1c8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416d1dc*/ int CalculateSize();
            /*0x416d1f0*/ void MergeFrom(YetiSimCoreLib.Components.FormationStoppedComponent other);
            /*0x416d224*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416d244*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FormationStoppedComponent.<> <>9;

                static /*0x416d3b4*/ <>c();
                /*0x416d41c*/ <>c();
                /*0x416d424*/ YetiSimCoreLib.Components.FormationStoppedComponent <.cctor>b__22_0();
            }
        }

        class MovementRestrictedFormationChildComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x416d8ec*/ MovementRestrictedFormationChildComponent();
            static /*0x416d478*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent> get_Parser();
            static /*0x416d4d0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416d620*/ MovementRestrictedFormationChildComponent();
            /*0x416d628*/ MovementRestrictedFormationChildComponent(YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent other);
            /*0x416d5d4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416d66c*/ YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent Clone();
            /*0x416d6c4*/ bool Equals(object other);
            /*0x416d748*/ bool Equals(YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent other);
            /*0x416d774*/ int GetHashCode();
            /*0x416d7a0*/ string ToString();
            /*0x416d7f8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416d818*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416d82c*/ int CalculateSize();
            /*0x416d840*/ void MergeFrom(YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent other);
            /*0x416d874*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416d894*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent.<> <>9;

                static /*0x416da04*/ <>c();
                /*0x416da6c*/ <>c();
                /*0x416da74*/ YetiSimCoreLib.Components.MovementRestrictedFormationChildComponent <.cctor>b__22_0();
            }
        }

        class GridCellComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x416db20*/ GridCellComponentReflection();
            static /*0x416dac8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class GridCellComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GridCellComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GridCellComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GridCellComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GridCellComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int rowIndex_;
            /*0x1c*/ int columnIndex_;

            static /*0x416eabc*/ GridCellComponent();
            static /*0x416e46c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GridCellComponent> get_Parser();
            static /*0x416e4c4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416e614*/ GridCellComponent();
            /*0x416e61c*/ GridCellComponent(YetiSimCoreLib.Components.GridCellComponent other);
            /*0x416e5c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416e668*/ YetiSimCoreLib.Components.GridCellComponent Clone();
            /*0x416e6c0*/ int get_RowIndex();
            /*0x416e6c8*/ void set_RowIndex(int value);
            /*0x416e6d0*/ int get_ColumnIndex();
            /*0x416e6d8*/ void set_ColumnIndex(int value);
            /*0x416e6e0*/ bool Equals(object other);
            /*0x416e744*/ bool Equals(YetiSimCoreLib.Components.GridCellComponent other);
            /*0x416e790*/ int GetHashCode();
            /*0x416e808*/ string ToString();
            /*0x416e860*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416e880*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416e908*/ int CalculateSize();
            /*0x416e9bc*/ void MergeFrom(YetiSimCoreLib.Components.GridCellComponent other);
            /*0x416ea08*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416ea28*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.GridCellComponent.<> <>9;

                static /*0x416ebd4*/ <>c();
                /*0x416ec3c*/ <>c();
                /*0x416ec44*/ YetiSimCoreLib.Components.GridCellComponent <.cctor>b__32_0();
            }
        }

        class OccupiedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OccupiedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OccupiedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OccupiedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OccupiedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isPlantOccupied_;
            /*0x19*/ bool isZombieOrNoFactionOccupied_;
            /*0x1c*/ int lastOccupancyChangedTick_;

            static /*0x416f3dc*/ OccupiedComponent();
            static /*0x416ec98*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OccupiedComponent> get_Parser();
            static /*0x416ecf0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416ee40*/ OccupiedComponent();
            /*0x416ee48*/ OccupiedComponent(YetiSimCoreLib.Components.OccupiedComponent other);
            /*0x416edf4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416ee9c*/ YetiSimCoreLib.Components.OccupiedComponent Clone();
            /*0x416eef4*/ bool get_IsPlantOccupied();
            /*0x416eefc*/ void set_IsPlantOccupied(bool value);
            /*0x416ef04*/ bool get_IsZombieOrNoFactionOccupied();
            /*0x416ef0c*/ void set_IsZombieOrNoFactionOccupied(bool value);
            /*0x416ef14*/ int get_LastOccupancyChangedTick();
            /*0x416ef1c*/ void set_LastOccupancyChangedTick(int value);
            /*0x416ef24*/ bool Equals(object other);
            /*0x416ef88*/ bool Equals(YetiSimCoreLib.Components.OccupiedComponent other);
            /*0x416f004*/ int GetHashCode();
            /*0x416f0cc*/ string ToString();
            /*0x416f124*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416f144*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416f1f4*/ int CalculateSize();
            /*0x416f290*/ void MergeFrom(YetiSimCoreLib.Components.OccupiedComponent other);
            /*0x416f2f0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416f310*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OccupiedComponent.<> <>9;

                static /*0x416f4f4*/ <>c();
                /*0x416f55c*/ <>c();
                /*0x416f564*/ YetiSimCoreLib.Components.OccupiedComponent <.cctor>b__37_0();
            }
        }

        class CellOccupierComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CellOccupierComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CellOccupierComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CellOccupierComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CellOccupierComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x416fa2c*/ CellOccupierComponent();
            static /*0x416f5b8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CellOccupierComponent> get_Parser();
            static /*0x416f610*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416f760*/ CellOccupierComponent();
            /*0x416f768*/ CellOccupierComponent(YetiSimCoreLib.Components.CellOccupierComponent other);
            /*0x416f714*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416f7ac*/ YetiSimCoreLib.Components.CellOccupierComponent Clone();
            /*0x416f804*/ bool Equals(object other);
            /*0x416f888*/ bool Equals(YetiSimCoreLib.Components.CellOccupierComponent other);
            /*0x416f8b4*/ int GetHashCode();
            /*0x416f8e0*/ string ToString();
            /*0x416f938*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416f958*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416f96c*/ int CalculateSize();
            /*0x416f980*/ void MergeFrom(YetiSimCoreLib.Components.CellOccupierComponent other);
            /*0x416f9b4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x416f9d4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CellOccupierComponent.<> <>9;

                static /*0x416fb44*/ <>c();
                /*0x416fbac*/ <>c();
                /*0x416fbb4*/ YetiSimCoreLib.Components.CellOccupierComponent <.cctor>b__22_0();
            }
        }

        class RestrictedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RestrictedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RestrictedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RestrictedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RestrictedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x417007c*/ RestrictedComponent();
            static /*0x416fc08*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RestrictedComponent> get_Parser();
            static /*0x416fc60*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x416fdb0*/ RestrictedComponent();
            /*0x416fdb8*/ RestrictedComponent(YetiSimCoreLib.Components.RestrictedComponent other);
            /*0x416fd64*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x416fdfc*/ YetiSimCoreLib.Components.RestrictedComponent Clone();
            /*0x416fe54*/ bool Equals(object other);
            /*0x416fed8*/ bool Equals(YetiSimCoreLib.Components.RestrictedComponent other);
            /*0x416ff04*/ int GetHashCode();
            /*0x416ff30*/ string ToString();
            /*0x416ff88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x416ffa8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x416ffbc*/ int CalculateSize();
            /*0x416ffd0*/ void MergeFrom(YetiSimCoreLib.Components.RestrictedComponent other);
            /*0x4170004*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4170024*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RestrictedComponent.<> <>9;

                static /*0x4170194*/ <>c();
                /*0x41701fc*/ <>c();
                /*0x4170204*/ YetiSimCoreLib.Components.RestrictedComponent <.cctor>b__22_0();
            }
        }

        class VacantComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.VacantComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.VacantComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.VacantComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.VacantComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41706cc*/ VacantComponent();
            static /*0x4170258*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.VacantComponent> get_Parser();
            static /*0x41702b0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4170400*/ VacantComponent();
            /*0x4170408*/ VacantComponent(YetiSimCoreLib.Components.VacantComponent other);
            /*0x41703b4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417044c*/ YetiSimCoreLib.Components.VacantComponent Clone();
            /*0x41704a4*/ bool Equals(object other);
            /*0x4170528*/ bool Equals(YetiSimCoreLib.Components.VacantComponent other);
            /*0x4170554*/ int GetHashCode();
            /*0x4170580*/ string ToString();
            /*0x41705d8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41705f8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417060c*/ int CalculateSize();
            /*0x4170620*/ void MergeFrom(YetiSimCoreLib.Components.VacantComponent other);
            /*0x4170654*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4170674*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.VacantComponent.<> <>9;

                static /*0x41707e4*/ <>c();
                /*0x417084c*/ <>c();
                /*0x4170854*/ YetiSimCoreLib.Components.VacantComponent <.cctor>b__22_0();
            }
        }

        class GridCellTagsComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4170900*/ GridCellTagsComponentReflection();
            static /*0x41708a8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class GridCellTagsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GridCellTagsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GridCellTagsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GridCellTagsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GridCellTagsComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_tags_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> tags_;

            static /*0x4171b58*/ GridCellTagsComponent();
            static /*0x4171398*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GridCellTagsComponent> get_Parser();
            static /*0x41713f0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4171540*/ GridCellTagsComponent();
            /*0x41715c8*/ GridCellTagsComponent(YetiSimCoreLib.Components.GridCellTagsComponent other);
            /*0x41714f4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4171654*/ YetiSimCoreLib.Components.GridCellTagsComponent Clone();
            /*0x41716ac*/ Google.Protobuf.Collections.RepeatedField<int> get_Tags();
            /*0x41716b4*/ bool Equals(object other);
            /*0x4171718*/ bool Equals(YetiSimCoreLib.Components.GridCellTagsComponent other);
            /*0x41717a8*/ int GetHashCode();
            /*0x41717f4*/ string ToString();
            /*0x417184c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417186c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4171924*/ int CalculateSize();
            /*0x41719cc*/ void MergeFrom(YetiSimCoreLib.Components.GridCellTagsComponent other);
            /*0x4171a54*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4171a74*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.GridCellTagsComponent.<> <>9;

                static /*0x4171c94*/ <>c();
                /*0x4171cfc*/ <>c();
                /*0x4171d04*/ YetiSimCoreLib.Components.GridCellTagsComponent <.cctor>b__27_0();
            }
        }

        class GridCellTagApplierComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GridCellTagApplierComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GridCellTagApplierComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GridCellTagApplierComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GridCellTagApplierComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_addTags_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_removeTags_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> addTags_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> removeTags_;

            static /*0x4172644*/ GridCellTagApplierComponent();
            static /*0x4171d54*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GridCellTagApplierComponent> get_Parser();
            static /*0x4171dac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4171efc*/ GridCellTagApplierComponent();
            /*0x4171fa8*/ GridCellTagApplierComponent(YetiSimCoreLib.Components.GridCellTagApplierComponent other);
            /*0x4171eb0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4172054*/ YetiSimCoreLib.Components.GridCellTagApplierComponent Clone();
            /*0x41720ac*/ Google.Protobuf.Collections.RepeatedField<int> get_AddTags();
            /*0x41720b4*/ Google.Protobuf.Collections.RepeatedField<int> get_RemoveTags();
            /*0x41720bc*/ bool Equals(object other);
            /*0x4172120*/ bool Equals(YetiSimCoreLib.Components.GridCellTagApplierComponent other);
            /*0x41721c8*/ int GetHashCode();
            /*0x417223c*/ string ToString();
            /*0x4172294*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41722b4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417238c*/ int CalculateSize();
            /*0x4172460*/ void MergeFrom(YetiSimCoreLib.Components.GridCellTagApplierComponent other);
            /*0x41724fc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417251c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.GridCellTagApplierComponent.<> <>9;

                static /*0x41727a4*/ <>c();
                /*0x417280c*/ <>c();
                /*0x4172814*/ YetiSimCoreLib.Components.GridCellTagApplierComponent <.cctor>b__32_0();
            }
        }

        class OccupancyRestrictionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OccupancyRestrictionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OccupancyRestrictionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OccupancyRestrictionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OccupancyRestrictionComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_allowListedTags_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_allowListedTagCounters_codec;
            static /*0x18*/ Google.Protobuf.FieldCodec<int> _repeated_denyListedTags_codec;
            static /*0x20*/ Google.Protobuf.FieldCodec<int> _repeated_denyListedTagCounters_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> allowListedTags_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> allowListedTagCounters_;
            /*0x28*/ Google.Protobuf.Collections.RepeatedField<int> denyListedTags_;
            /*0x30*/ Google.Protobuf.Collections.RepeatedField<int> denyListedTagCounters_;

            static /*0x4173390*/ OccupancyRestrictionComponent();
            static /*0x4172864*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OccupancyRestrictionComponent> get_Parser();
            static /*0x41728bc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4172a0c*/ OccupancyRestrictionComponent();
            /*0x4172b00*/ OccupancyRestrictionComponent(YetiSimCoreLib.Components.OccupancyRestrictionComponent other);
            /*0x41729c0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4172bec*/ YetiSimCoreLib.Components.OccupancyRestrictionComponent Clone();
            /*0x4172c44*/ Google.Protobuf.Collections.RepeatedField<int> get_AllowListedTags();
            /*0x4172c4c*/ Google.Protobuf.Collections.RepeatedField<int> get_AllowListedTagCounters();
            /*0x4172c54*/ Google.Protobuf.Collections.RepeatedField<int> get_DenyListedTags();
            /*0x4172c5c*/ Google.Protobuf.Collections.RepeatedField<int> get_DenyListedTagCounters();
            /*0x4172c64*/ bool Equals(object other);
            /*0x4172cc8*/ bool Equals(YetiSimCoreLib.Components.OccupancyRestrictionComponent other);
            /*0x4172da0*/ int GetHashCode();
            /*0x4172e58*/ string ToString();
            /*0x4172eb0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4172ed0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4172fe8*/ int CalculateSize();
            /*0x4173114*/ void MergeFrom(YetiSimCoreLib.Components.OccupancyRestrictionComponent other);
            /*0x41731d8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41731f8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OccupancyRestrictionComponent.<> <>9;

                static /*0x4173538*/ <>c();
                /*0x41735a0*/ <>c();
                /*0x41735a8*/ YetiSimCoreLib.Components.OccupancyRestrictionComponent <.cctor>b__42_0();
            }
        }

        class OccupancyRestrictionApplierComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_addAllowListedTags_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_removeAllowListedTags_codec;
            static /*0x18*/ Google.Protobuf.FieldCodec<int> _repeated_addDenyListedTags_codec;
            static /*0x20*/ Google.Protobuf.FieldCodec<int> _repeated_removeDenyListedTags_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> addAllowListedTags_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> removeAllowListedTags_;
            /*0x28*/ Google.Protobuf.Collections.RepeatedField<int> addDenyListedTags_;
            /*0x30*/ Google.Protobuf.Collections.RepeatedField<int> removeDenyListedTags_;

            static /*0x4174124*/ OccupancyRestrictionApplierComponent();
            static /*0x41735f8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent> get_Parser();
            static /*0x4173650*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41737a0*/ OccupancyRestrictionApplierComponent();
            /*0x4173894*/ OccupancyRestrictionApplierComponent(YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent other);
            /*0x4173754*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4173980*/ YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent Clone();
            /*0x41739d8*/ Google.Protobuf.Collections.RepeatedField<int> get_AddAllowListedTags();
            /*0x41739e0*/ Google.Protobuf.Collections.RepeatedField<int> get_RemoveAllowListedTags();
            /*0x41739e8*/ Google.Protobuf.Collections.RepeatedField<int> get_AddDenyListedTags();
            /*0x41739f0*/ Google.Protobuf.Collections.RepeatedField<int> get_RemoveDenyListedTags();
            /*0x41739f8*/ bool Equals(object other);
            /*0x4173a5c*/ bool Equals(YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent other);
            /*0x4173b34*/ int GetHashCode();
            /*0x4173bec*/ string ToString();
            /*0x4173c44*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4173c64*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4173d7c*/ int CalculateSize();
            /*0x4173ea8*/ void MergeFrom(YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent other);
            /*0x4173f6c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4173f8c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent.<> <>9;

                static /*0x41742cc*/ <>c();
                /*0x4174334*/ <>c();
                /*0x417433c*/ YetiSimCoreLib.Components.OccupancyRestrictionApplierComponent <.cctor>b__42_0();
            }
        }

        class GrowthTimerComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41743e4*/ GrowthTimerComponentReflection();
            static /*0x417438c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class GrowthTimerComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.GrowthTimerComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.GrowthTimerComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.GrowthTimerComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GrowthTimerComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;
            /*0x1c*/ int ticksTotal_;

            static /*0x4174eb8*/ GrowthTimerComponent();
            static /*0x4174868*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.GrowthTimerComponent> get_Parser();
            static /*0x41748c0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4174a10*/ GrowthTimerComponent();
            /*0x4174a18*/ GrowthTimerComponent(YetiSimCoreLib.Components.GrowthTimerComponent other);
            /*0x41749c4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4174a64*/ YetiSimCoreLib.Components.GrowthTimerComponent Clone();
            /*0x4174abc*/ int get_TicksRemaining();
            /*0x4174ac4*/ void set_TicksRemaining(int value);
            /*0x4174acc*/ int get_TicksTotal();
            /*0x4174ad4*/ void set_TicksTotal(int value);
            /*0x4174adc*/ bool Equals(object other);
            /*0x4174b40*/ bool Equals(YetiSimCoreLib.Components.GrowthTimerComponent other);
            /*0x4174b8c*/ int GetHashCode();
            /*0x4174c04*/ string ToString();
            /*0x4174c5c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4174c7c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4174d04*/ int CalculateSize();
            /*0x4174db8*/ void MergeFrom(YetiSimCoreLib.Components.GrowthTimerComponent other);
            /*0x4174e04*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4174e24*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.GrowthTimerComponent.<> <>9;

                static /*0x4174fd0*/ <>c();
                /*0x4175038*/ <>c();
                /*0x4175040*/ YetiSimCoreLib.Components.GrowthTimerComponent <.cctor>b__32_0();
            }
        }

        class HitboxComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41750ec*/ HitboxComponentReflection();
            static /*0x4175094*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class HitboxComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.HitboxComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.HitboxComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.HitboxComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HitboxComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int xMin_;
            /*0x1c*/ int xMax_;
            /*0x20*/ int yMin_;
            /*0x24*/ int yMax_;
            /*0x28*/ int zMin_;
            /*0x2c*/ int zMax_;

            static /*0x4176218*/ HitboxComponent();
            static /*0x41758c4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HitboxComponent> get_Parser();
            static /*0x417591c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4175a6c*/ HitboxComponent();
            /*0x4175a74*/ HitboxComponent(YetiSimCoreLib.Components.HitboxComponent other);
            /*0x4175a20*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4175ac8*/ YetiSimCoreLib.Components.HitboxComponent Clone();
            /*0x4175b20*/ int get_XMin();
            /*0x4175b28*/ void set_XMin(int value);
            /*0x4175b30*/ int get_XMax();
            /*0x4175b38*/ void set_XMax(int value);
            /*0x4175b40*/ int get_YMin();
            /*0x4175b48*/ void set_YMin(int value);
            /*0x4175b50*/ int get_YMax();
            /*0x4175b58*/ void set_YMax(int value);
            /*0x4175b60*/ int get_ZMin();
            /*0x4175b68*/ void set_ZMin(int value);
            /*0x4175b70*/ int get_ZMax();
            /*0x4175b78*/ void set_ZMax(int value);
            /*0x4175b80*/ bool Equals(object other);
            /*0x4175be4*/ bool Equals(YetiSimCoreLib.Components.HitboxComponent other);
            /*0x4175c70*/ int GetHashCode();
            /*0x4175d58*/ string ToString();
            /*0x4175db0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4175dd0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4175ef8*/ int CalculateSize();
            /*0x417605c*/ void MergeFrom(YetiSimCoreLib.Components.HitboxComponent other);
            /*0x41760d8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41760f8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.HitboxComponent.<> <>9;

                static /*0x4176330*/ <>c();
                /*0x4176398*/ <>c();
                /*0x41763a0*/ YetiSimCoreLib.Components.HitboxComponent <.cctor>b__52_0();
            }
        }

        class IgnoresCollisionsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.IgnoresCollisionsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.IgnoresCollisionsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.IgnoresCollisionsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IgnoresCollisionsComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4176868*/ IgnoresCollisionsComponent();
            static /*0x41763f4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IgnoresCollisionsComponent> get_Parser();
            static /*0x417644c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417659c*/ IgnoresCollisionsComponent();
            /*0x41765a4*/ IgnoresCollisionsComponent(YetiSimCoreLib.Components.IgnoresCollisionsComponent other);
            /*0x4176550*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41765e8*/ YetiSimCoreLib.Components.IgnoresCollisionsComponent Clone();
            /*0x4176640*/ bool Equals(object other);
            /*0x41766c4*/ bool Equals(YetiSimCoreLib.Components.IgnoresCollisionsComponent other);
            /*0x41766f0*/ int GetHashCode();
            /*0x417671c*/ string ToString();
            /*0x4176774*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4176794*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41767a8*/ int CalculateSize();
            /*0x41767bc*/ void MergeFrom(YetiSimCoreLib.Components.IgnoresCollisionsComponent other);
            /*0x41767f0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4176810*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.IgnoresCollisionsComponent.<> <>9;

                static /*0x4176980*/ <>c();
                /*0x41769e8*/ <>c();
                /*0x41769f0*/ YetiSimCoreLib.Components.IgnoresCollisionsComponent <.cctor>b__22_0();
            }
        }

        class RightTriangleHitboxComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RightTriangleHitboxComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RightTriangleHitboxComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RightTriangleHitboxComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RightTriangleHitboxComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isSlopeUpRightToLeft_;

            static /*0x4176fac*/ RightTriangleHitboxComponent();
            static /*0x4176a44*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RightTriangleHitboxComponent> get_Parser();
            static /*0x4176a9c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4176bec*/ RightTriangleHitboxComponent();
            /*0x4176bf4*/ RightTriangleHitboxComponent(YetiSimCoreLib.Components.RightTriangleHitboxComponent other);
            /*0x4176ba0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4176c40*/ YetiSimCoreLib.Components.RightTriangleHitboxComponent Clone();
            /*0x4176c98*/ bool get_IsSlopeUpRightToLeft();
            /*0x4176ca0*/ void set_IsSlopeUpRightToLeft(bool value);
            /*0x4176ca8*/ bool Equals(object other);
            /*0x4176d0c*/ bool Equals(YetiSimCoreLib.Components.RightTriangleHitboxComponent other);
            /*0x4176d58*/ int GetHashCode();
            /*0x4176dc8*/ string ToString();
            /*0x4176e20*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4176e40*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4176ea0*/ int CalculateSize();
            /*0x4176ecc*/ void MergeFrom(YetiSimCoreLib.Components.RightTriangleHitboxComponent other);
            /*0x4176f10*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4176f30*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RightTriangleHitboxComponent.<> <>9;

                static /*0x41770c4*/ <>c();
                /*0x417712c*/ <>c();
                /*0x4177134*/ YetiSimCoreLib.Components.RightTriangleHitboxComponent <.cctor>b__27_0();
            }
        }

        class HitByAbilityInstanceComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41771e0*/ HitByAbilityInstanceComponentReflection();
            static /*0x4177188*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class HitByAbilityInstanceComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.HitByAbilityInstanceComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.HitByAbilityInstanceComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.HitByAbilityInstanceComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HitByAbilityInstanceComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_instanceIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> instanceIds_;

            static /*0x4177df0*/ HitByAbilityInstanceComponent();
            static /*0x4177630*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HitByAbilityInstanceComponent> get_Parser();
            static /*0x4177688*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41777d8*/ HitByAbilityInstanceComponent();
            /*0x4177860*/ HitByAbilityInstanceComponent(YetiSimCoreLib.Components.HitByAbilityInstanceComponent other);
            /*0x417778c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41778ec*/ YetiSimCoreLib.Components.HitByAbilityInstanceComponent Clone();
            /*0x4177944*/ Google.Protobuf.Collections.RepeatedField<int> get_InstanceIds();
            /*0x417794c*/ bool Equals(object other);
            /*0x41779b0*/ bool Equals(YetiSimCoreLib.Components.HitByAbilityInstanceComponent other);
            /*0x4177a40*/ int GetHashCode();
            /*0x4177a8c*/ string ToString();
            /*0x4177ae4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4177b04*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4177bbc*/ int CalculateSize();
            /*0x4177c64*/ void MergeFrom(YetiSimCoreLib.Components.HitByAbilityInstanceComponent other);
            /*0x4177cec*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4177d0c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.HitByAbilityInstanceComponent.<> <>9;

                static /*0x4177f2c*/ <>c();
                /*0x4177f94*/ <>c();
                /*0x4177f9c*/ YetiSimCoreLib.Components.HitByAbilityInstanceComponent <.cctor>b__27_0();
            }
        }

        class InclineComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4178044*/ InclineComponentReflection();
            static /*0x4177fec*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class InclineComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.InclineComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.InclineComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.InclineComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InclineComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4178800*/ InclineComponent();
            static /*0x417838c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InclineComponent> get_Parser();
            static /*0x41783e4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4178534*/ InclineComponent();
            /*0x417853c*/ InclineComponent(YetiSimCoreLib.Components.InclineComponent other);
            /*0x41784e8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4178580*/ YetiSimCoreLib.Components.InclineComponent Clone();
            /*0x41785d8*/ bool Equals(object other);
            /*0x417865c*/ bool Equals(YetiSimCoreLib.Components.InclineComponent other);
            /*0x4178688*/ int GetHashCode();
            /*0x41786b4*/ string ToString();
            /*0x417870c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417872c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4178740*/ int CalculateSize();
            /*0x4178754*/ void MergeFrom(YetiSimCoreLib.Components.InclineComponent other);
            /*0x4178788*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41787a8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.InclineComponent.<> <>9;

                static /*0x4178918*/ <>c();
                /*0x4178980*/ <>c();
                /*0x4178988*/ YetiSimCoreLib.Components.InclineComponent <.cctor>b__22_0();
            }
        }

        class IsIneligibleForCascadeComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4178a34*/ IsIneligibleForCascadeComponentReflection();
            static /*0x41789dc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class IsIneligibleForCascadeComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.IsIneligibleForCascadeComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.IsIneligibleForCascadeComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.IsIneligibleForCascadeComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IsIneligibleForCascadeComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41791f0*/ IsIneligibleForCascadeComponent();
            static /*0x4178d7c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IsIneligibleForCascadeComponent> get_Parser();
            static /*0x4178dd4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4178f24*/ IsIneligibleForCascadeComponent();
            /*0x4178f2c*/ IsIneligibleForCascadeComponent(YetiSimCoreLib.Components.IsIneligibleForCascadeComponent other);
            /*0x4178ed8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4178f70*/ YetiSimCoreLib.Components.IsIneligibleForCascadeComponent Clone();
            /*0x4178fc8*/ bool Equals(object other);
            /*0x417904c*/ bool Equals(YetiSimCoreLib.Components.IsIneligibleForCascadeComponent other);
            /*0x4179078*/ int GetHashCode();
            /*0x41790a4*/ string ToString();
            /*0x41790fc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417911c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4179130*/ int CalculateSize();
            /*0x4179144*/ void MergeFrom(YetiSimCoreLib.Components.IsIneligibleForCascadeComponent other);
            /*0x4179178*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4179198*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.IsIneligibleForCascadeComponent.<> <>9;

                static /*0x4179308*/ <>c();
                /*0x4179370*/ <>c();
                /*0x4179378*/ YetiSimCoreLib.Components.IsIneligibleForCascadeComponent <.cctor>b__22_0();
            }
        }

        class IsIneligibleForCoinsComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4179424*/ IsIneligibleForCoinsComponentReflection();
            static /*0x41793cc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class IsIneligibleForCoinsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.IsIneligibleForCoinsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.IsIneligibleForCoinsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.IsIneligibleForCoinsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IsIneligibleForCoinsComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4179be0*/ IsIneligibleForCoinsComponent();
            static /*0x417976c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IsIneligibleForCoinsComponent> get_Parser();
            static /*0x41797c4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4179914*/ IsIneligibleForCoinsComponent();
            /*0x417991c*/ IsIneligibleForCoinsComponent(YetiSimCoreLib.Components.IsIneligibleForCoinsComponent other);
            /*0x41798c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4179960*/ YetiSimCoreLib.Components.IsIneligibleForCoinsComponent Clone();
            /*0x41799b8*/ bool Equals(object other);
            /*0x4179a3c*/ bool Equals(YetiSimCoreLib.Components.IsIneligibleForCoinsComponent other);
            /*0x4179a68*/ int GetHashCode();
            /*0x4179a94*/ string ToString();
            /*0x4179aec*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4179b0c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4179b20*/ int CalculateSize();
            /*0x4179b34*/ void MergeFrom(YetiSimCoreLib.Components.IsIneligibleForCoinsComponent other);
            /*0x4179b68*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4179b88*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.IsIneligibleForCoinsComponent.<> <>9;

                static /*0x4179cf8*/ <>c();
                /*0x4179d60*/ <>c();
                /*0x4179d68*/ YetiSimCoreLib.Components.IsIneligibleForCoinsComponent <.cctor>b__22_0();
            }
        }

        class IsIneligibleForLeaderboardComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4179e14*/ IsIneligibleForLeaderboardComponentReflection();
            static /*0x4179dbc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class IsIneligibleForLeaderboardComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x417a5d0*/ IsIneligibleForLeaderboardComponent();
            static /*0x417a15c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent> get_Parser();
            static /*0x417a1b4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417a304*/ IsIneligibleForLeaderboardComponent();
            /*0x417a30c*/ IsIneligibleForLeaderboardComponent(YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent other);
            /*0x417a2b8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417a350*/ YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent Clone();
            /*0x417a3a8*/ bool Equals(object other);
            /*0x417a42c*/ bool Equals(YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent other);
            /*0x417a458*/ int GetHashCode();
            /*0x417a484*/ string ToString();
            /*0x417a4dc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417a4fc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417a510*/ int CalculateSize();
            /*0x417a524*/ void MergeFrom(YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent other);
            /*0x417a558*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417a578*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent.<> <>9;

                static /*0x417a6e8*/ <>c();
                /*0x417a750*/ <>c();
                /*0x417a758*/ YetiSimCoreLib.Components.IsIneligibleForLeaderboardComponent <.cctor>b__22_0();
            }
        }

        class KilledComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x417a804*/ KilledComponentReflection();
            static /*0x417a7ac*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class KilledComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.KilledComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.KilledComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.KilledComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KilledComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_killerIds_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_killerAbilityTags_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> killerIds_;
            /*0x20*/ bool killedByOwnFaction_;
            /*0x28*/ Google.Protobuf.Collections.RepeatedField<int> killerAbilityTags_;
            /*0x30*/ int killerLevel_;
            /*0x38*/ string presentationTag_;

            static /*0x417b9e4*/ KilledComponent();
            static /*0x417ad58*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KilledComponent> get_Parser();
            static /*0x417adb0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417af00*/ KilledComponent();
            /*0x417afd0*/ KilledComponent(YetiSimCoreLib.Components.KilledComponent other);
            /*0x417aeb4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417b0a8*/ YetiSimCoreLib.Components.KilledComponent Clone();
            /*0x417b100*/ Google.Protobuf.Collections.RepeatedField<int> get_KillerIds();
            /*0x417b108*/ bool get_KilledByOwnFaction();
            /*0x417b110*/ void set_KilledByOwnFaction(bool value);
            /*0x417b118*/ Google.Protobuf.Collections.RepeatedField<int> get_KillerAbilityTags();
            /*0x417b120*/ int get_KillerLevel();
            /*0x417b128*/ void set_KillerLevel(int value);
            /*0x417b130*/ string get_PresentationTag();
            /*0x417b138*/ void set_PresentationTag(string value);
            /*0x417b1b4*/ bool Equals(object other);
            /*0x417b218*/ bool Equals(YetiSimCoreLib.Components.KilledComponent other);
            /*0x417b304*/ int GetHashCode();
            /*0x417b3e8*/ string ToString();
            /*0x417b440*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417b460*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417b5cc*/ int CalculateSize();
            /*0x417b738*/ void MergeFrom(YetiSimCoreLib.Components.KilledComponent other);
            /*0x417b808*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417b828*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.KilledComponent.<> <>9;

                static /*0x417bb44*/ <>c();
                /*0x417bbac*/ <>c();
                /*0x417bbb4*/ YetiSimCoreLib.Components.KilledComponent <.cctor>b__47_0();
            }
        }

        class KillStreakComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x417bc5c*/ KillStreakComponentReflection();
            static /*0x417bc04*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class KillStreakComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.KillStreakComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.KillStreakComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.KillStreakComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KillStreakComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int killStreak_;
            /*0x1c*/ int killStreakTicksRemaining_;

            static /*0x417c730*/ KillStreakComponent();
            static /*0x417c0e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KillStreakComponent> get_Parser();
            static /*0x417c138*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417c288*/ KillStreakComponent();
            /*0x417c290*/ KillStreakComponent(YetiSimCoreLib.Components.KillStreakComponent other);
            /*0x417c23c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417c2dc*/ YetiSimCoreLib.Components.KillStreakComponent Clone();
            /*0x417c334*/ int get_KillStreak();
            /*0x417c33c*/ void set_KillStreak(int value);
            /*0x417c344*/ int get_KillStreakTicksRemaining();
            /*0x417c34c*/ void set_KillStreakTicksRemaining(int value);
            /*0x417c354*/ bool Equals(object other);
            /*0x417c3b8*/ bool Equals(YetiSimCoreLib.Components.KillStreakComponent other);
            /*0x417c404*/ int GetHashCode();
            /*0x417c47c*/ string ToString();
            /*0x417c4d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417c4f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417c57c*/ int CalculateSize();
            /*0x417c630*/ void MergeFrom(YetiSimCoreLib.Components.KillStreakComponent other);
            /*0x417c67c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417c69c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.KillStreakComponent.<> <>9;

                static /*0x417c848*/ <>c();
                /*0x417c8b0*/ <>c();
                /*0x417c8b8*/ YetiSimCoreLib.Components.KillStreakComponent <.cctor>b__32_0();
            }
        }

        class LifespanComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x417c964*/ LifespanComponentReflection();
            static /*0x417c90c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class LifespanComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LifespanComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LifespanComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LifespanComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifespanComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x417d55c*/ LifespanComponent();
            static /*0x417cfd0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifespanComponent> get_Parser();
            static /*0x417d028*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417d178*/ LifespanComponent();
            /*0x417d180*/ LifespanComponent(YetiSimCoreLib.Components.LifespanComponent other);
            /*0x417d12c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417d1cc*/ YetiSimCoreLib.Components.LifespanComponent Clone();
            /*0x417d224*/ int get_TicksRemaining();
            /*0x417d22c*/ void set_TicksRemaining(int value);
            /*0x417d234*/ bool Equals(object other);
            /*0x417d298*/ bool Equals(YetiSimCoreLib.Components.LifespanComponent other);
            /*0x417d2d4*/ int GetHashCode();
            /*0x417d330*/ string ToString();
            /*0x417d388*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417d3a8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417d408*/ int CalculateSize();
            /*0x417d488*/ void MergeFrom(YetiSimCoreLib.Components.LifespanComponent other);
            /*0x417d4c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417d4e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LifespanComponent.<> <>9;

                static /*0x417d674*/ <>c();
                /*0x417d6dc*/ <>c();
                /*0x417d6e4*/ YetiSimCoreLib.Components.LifespanComponent <.cctor>b__27_0();
            }
        }

        class NearEndOfLifespanComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.NearEndOfLifespanComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.NearEndOfLifespanComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.NearEndOfLifespanComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.NearEndOfLifespanComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x417dbac*/ NearEndOfLifespanComponent();
            static /*0x417d738*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.NearEndOfLifespanComponent> get_Parser();
            static /*0x417d790*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417d8e0*/ NearEndOfLifespanComponent();
            /*0x417d8e8*/ NearEndOfLifespanComponent(YetiSimCoreLib.Components.NearEndOfLifespanComponent other);
            /*0x417d894*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417d92c*/ YetiSimCoreLib.Components.NearEndOfLifespanComponent Clone();
            /*0x417d984*/ bool Equals(object other);
            /*0x417da08*/ bool Equals(YetiSimCoreLib.Components.NearEndOfLifespanComponent other);
            /*0x417da34*/ int GetHashCode();
            /*0x417da60*/ string ToString();
            /*0x417dab8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417dad8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417daec*/ int CalculateSize();
            /*0x417db00*/ void MergeFrom(YetiSimCoreLib.Components.NearEndOfLifespanComponent other);
            /*0x417db34*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417db54*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.NearEndOfLifespanComponent.<> <>9;

                static /*0x417dcc4*/ <>c();
                /*0x417dd2c*/ <>c();
                /*0x417dd34*/ YetiSimCoreLib.Components.NearEndOfLifespanComponent <.cctor>b__22_0();
            }
        }

        class ExpiryWarningComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ExpiryWarningComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ExpiryWarningComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ExpiryWarningComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ExpiryWarningComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int timeInTicks_;

            static /*0x417e314*/ ExpiryWarningComponent();
            static /*0x417dd88*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ExpiryWarningComponent> get_Parser();
            static /*0x417dde0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417df30*/ ExpiryWarningComponent();
            /*0x417df38*/ ExpiryWarningComponent(YetiSimCoreLib.Components.ExpiryWarningComponent other);
            /*0x417dee4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417df84*/ YetiSimCoreLib.Components.ExpiryWarningComponent Clone();
            /*0x417dfdc*/ int get_TimeInTicks();
            /*0x417dfe4*/ void set_TimeInTicks(int value);
            /*0x417dfec*/ bool Equals(object other);
            /*0x417e050*/ bool Equals(YetiSimCoreLib.Components.ExpiryWarningComponent other);
            /*0x417e08c*/ int GetHashCode();
            /*0x417e0e8*/ string ToString();
            /*0x417e140*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417e160*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417e1c0*/ int CalculateSize();
            /*0x417e240*/ void MergeFrom(YetiSimCoreLib.Components.ExpiryWarningComponent other);
            /*0x417e280*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417e2a0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ExpiryWarningComponent.<> <>9;

                static /*0x417e42c*/ <>c();
                /*0x417e494*/ <>c();
                /*0x417e49c*/ YetiSimCoreLib.Components.ExpiryWarningComponent <.cctor>b__27_0();
            }
        }

        class LifeSpanScoringDecayComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x417e548*/ LifeSpanScoringDecayComponentReflection();
            static /*0x417e4f0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class LifeSpanScoringDecayComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LifeSpanScoringDecayComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LifeSpanScoringDecayComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LifeSpanScoringDecayComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifeSpanScoringDecayComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int decayStartTick_;

            static /*0x417ef24*/ LifeSpanScoringDecayComponent();
            static /*0x417e998*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifeSpanScoringDecayComponent> get_Parser();
            static /*0x417e9f0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417eb40*/ LifeSpanScoringDecayComponent();
            /*0x417eb48*/ LifeSpanScoringDecayComponent(YetiSimCoreLib.Components.LifeSpanScoringDecayComponent other);
            /*0x417eaf4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417eb94*/ YetiSimCoreLib.Components.LifeSpanScoringDecayComponent Clone();
            /*0x417ebec*/ int get_DecayStartTick();
            /*0x417ebf4*/ void set_DecayStartTick(int value);
            /*0x417ebfc*/ bool Equals(object other);
            /*0x417ec60*/ bool Equals(YetiSimCoreLib.Components.LifeSpanScoringDecayComponent other);
            /*0x417ec9c*/ int GetHashCode();
            /*0x417ecf8*/ string ToString();
            /*0x417ed50*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417ed70*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417edd0*/ int CalculateSize();
            /*0x417ee50*/ void MergeFrom(YetiSimCoreLib.Components.LifeSpanScoringDecayComponent other);
            /*0x417ee90*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417eeb0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LifeSpanScoringDecayComponent.<> <>9;

                static /*0x417f03c*/ <>c();
                /*0x417f0a4*/ <>c();
                /*0x417f0ac*/ YetiSimCoreLib.Components.LifeSpanScoringDecayComponent <.cctor>b__27_0();
            }
        }

        class LinkingComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x417f158*/ LinkingComponentReflection();
            static /*0x417f100*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class LinkingParentComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LinkingParentComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LinkingParentComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LinkingParentComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LinkingParentComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_childInstanceIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> childInstanceIds_;

            static /*0x417feb0*/ LinkingParentComponent();
            static /*0x417f6f0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LinkingParentComponent> get_Parser();
            static /*0x417f748*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x417f898*/ LinkingParentComponent();
            /*0x417f920*/ LinkingParentComponent(YetiSimCoreLib.Components.LinkingParentComponent other);
            /*0x417f84c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x417f9ac*/ YetiSimCoreLib.Components.LinkingParentComponent Clone();
            /*0x417fa04*/ Google.Protobuf.Collections.RepeatedField<int> get_ChildInstanceIds();
            /*0x417fa0c*/ bool Equals(object other);
            /*0x417fa70*/ bool Equals(YetiSimCoreLib.Components.LinkingParentComponent other);
            /*0x417fb00*/ int GetHashCode();
            /*0x417fb4c*/ string ToString();
            /*0x417fba4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x417fbc4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x417fc7c*/ int CalculateSize();
            /*0x417fd24*/ void MergeFrom(YetiSimCoreLib.Components.LinkingParentComponent other);
            /*0x417fdac*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x417fdcc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LinkingParentComponent.<> <>9;

                static /*0x417ffec*/ <>c();
                /*0x4180054*/ <>c();
                /*0x418005c*/ YetiSimCoreLib.Components.LinkingParentComponent <.cctor>b__27_0();
            }
        }

        class LinkingChildComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LinkingChildComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LinkingChildComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LinkingChildComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LinkingChildComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_parentInstanceIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> parentInstanceIds_;

            static /*0x418086c*/ LinkingChildComponent();
            static /*0x41800ac*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LinkingChildComponent> get_Parser();
            static /*0x4180104*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4180254*/ LinkingChildComponent();
            /*0x41802dc*/ LinkingChildComponent(YetiSimCoreLib.Components.LinkingChildComponent other);
            /*0x4180208*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4180368*/ YetiSimCoreLib.Components.LinkingChildComponent Clone();
            /*0x41803c0*/ Google.Protobuf.Collections.RepeatedField<int> get_ParentInstanceIds();
            /*0x41803c8*/ bool Equals(object other);
            /*0x418042c*/ bool Equals(YetiSimCoreLib.Components.LinkingChildComponent other);
            /*0x41804bc*/ int GetHashCode();
            /*0x4180508*/ string ToString();
            /*0x4180560*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4180580*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4180638*/ int CalculateSize();
            /*0x41806e0*/ void MergeFrom(YetiSimCoreLib.Components.LinkingChildComponent other);
            /*0x4180768*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4180788*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LinkingChildComponent.<> <>9;

                static /*0x41809a8*/ <>c();
                /*0x4180a10*/ <>c();
                /*0x4180a18*/ YetiSimCoreLib.Components.LinkingChildComponent <.cctor>b__27_0();
            }
        }

        class LoadoutItemComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4180ac0*/ LoadoutItemComponentReflection();
            static /*0x4180a68*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class LoadoutItemComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LoadoutItemComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LoadoutItemComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LoadoutItemComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LoadoutItemComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int loadoutIndex_;
            /*0x1c*/ int unitId_;
            /*0x20*/ int cooldownTicksRemaining_;
            /*0x24*/ int cooldownTicksTotal_;
            /*0x28*/ bool countdownDisabled_;
            /*0x29*/ bool cooldownDisabled_;

            static /*0x4181fec*/ LoadoutItemComponent();
            static /*0x4181654*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LoadoutItemComponent> get_Parser();
            static /*0x41816ac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41817fc*/ LoadoutItemComponent();
            /*0x4181804*/ LoadoutItemComponent(YetiSimCoreLib.Components.LoadoutItemComponent other);
            /*0x41817b0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4181858*/ YetiSimCoreLib.Components.LoadoutItemComponent Clone();
            /*0x41818b0*/ int get_LoadoutIndex();
            /*0x41818b8*/ void set_LoadoutIndex(int value);
            /*0x41818c0*/ int get_UnitId();
            /*0x41818c8*/ void set_UnitId(int value);
            /*0x41818d0*/ int get_CooldownTicksRemaining();
            /*0x41818d8*/ void set_CooldownTicksRemaining(int value);
            /*0x41818e0*/ int get_CooldownTicksTotal();
            /*0x41818e8*/ void set_CooldownTicksTotal(int value);
            /*0x41818f0*/ bool get_CountdownDisabled();
            /*0x41818f8*/ void set_CountdownDisabled(bool value);
            /*0x4181900*/ bool get_CooldownDisabled();
            /*0x4181908*/ void set_CooldownDisabled(bool value);
            /*0x4181910*/ bool Equals(object other);
            /*0x4181974*/ bool Equals(YetiSimCoreLib.Components.LoadoutItemComponent other);
            /*0x4181a20*/ int GetHashCode();
            /*0x4181b44*/ string ToString();
            /*0x4181b9c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4181bbc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4181ce4*/ int CalculateSize();
            /*0x4181e18*/ void MergeFrom(YetiSimCoreLib.Components.LoadoutItemComponent other);
            /*0x4181e9c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4181ebc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LoadoutItemComponent.<> <>9;

                static /*0x4182104*/ <>c();
                /*0x418216c*/ <>c();
                /*0x4182174*/ YetiSimCoreLib.Components.LoadoutItemComponent <.cctor>b__52_0();
            }
        }

        class LoadoutItemSpecialChargeComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isSupercharged_;
            /*0x1c*/ int firstStrikePercentMilleChance_;
            /*0x20*/ bool isTacoCharged_;
            /*0x24*/ int tacoStrikePercentMilleChance_;

            static /*0x41829e4*/ LoadoutItemSpecialChargeComponent();
            static /*0x41821c8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent> get_Parser();
            static /*0x4182220*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4182370*/ LoadoutItemSpecialChargeComponent();
            /*0x4182378*/ LoadoutItemSpecialChargeComponent(YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent other);
            /*0x4182324*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41823dc*/ YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent Clone();
            /*0x4182434*/ bool get_IsSupercharged();
            /*0x418243c*/ void set_IsSupercharged(bool value);
            /*0x4182444*/ int get_FirstStrikePercentMilleChance();
            /*0x418244c*/ void set_FirstStrikePercentMilleChance(int value);
            /*0x4182454*/ bool get_IsTacoCharged();
            /*0x418245c*/ void set_IsTacoCharged(bool value);
            /*0x4182464*/ int get_TacoStrikePercentMilleChance();
            /*0x418246c*/ void set_TacoStrikePercentMilleChance(int value);
            /*0x4182474*/ bool Equals(object other);
            /*0x41824d8*/ bool Equals(YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent other);
            /*0x4182564*/ int GetHashCode();
            /*0x4182648*/ string ToString();
            /*0x41826a0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41826c0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4182798*/ int CalculateSize();
            /*0x4182868*/ void MergeFrom(YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent other);
            /*0x41828d4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41828f4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent.<> <>9;

                static /*0x4182afc*/ <>c();
                /*0x4182b64*/ <>c();
                /*0x4182b6c*/ YetiSimCoreLib.Components.LoadoutItemSpecialChargeComponent <.cctor>b__42_0();
            }
        }

        class LoadoutItemUsesComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LoadoutItemUsesComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LoadoutItemUsesComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LoadoutItemUsesComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LoadoutItemUsesComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int usesRemaining_;

            static /*0x418314c*/ LoadoutItemUsesComponent();
            static /*0x4182bc0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LoadoutItemUsesComponent> get_Parser();
            static /*0x4182c18*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4182d68*/ LoadoutItemUsesComponent();
            /*0x4182d70*/ LoadoutItemUsesComponent(YetiSimCoreLib.Components.LoadoutItemUsesComponent other);
            /*0x4182d1c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4182dbc*/ YetiSimCoreLib.Components.LoadoutItemUsesComponent Clone();
            /*0x4182e14*/ int get_UsesRemaining();
            /*0x4182e1c*/ void set_UsesRemaining(int value);
            /*0x4182e24*/ bool Equals(object other);
            /*0x4182e88*/ bool Equals(YetiSimCoreLib.Components.LoadoutItemUsesComponent other);
            /*0x4182ec4*/ int GetHashCode();
            /*0x4182f20*/ string ToString();
            /*0x4182f78*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4182f98*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4182ff8*/ int CalculateSize();
            /*0x4183078*/ void MergeFrom(YetiSimCoreLib.Components.LoadoutItemUsesComponent other);
            /*0x41830b8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41830d8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LoadoutItemUsesComponent.<> <>9;

                static /*0x4183264*/ <>c();
                /*0x41832cc*/ <>c();
                /*0x41832d4*/ YetiSimCoreLib.Components.LoadoutItemUsesComponent <.cctor>b__27_0();
            }
        }

        class InstantUsePlantLoadoutItem : Google.Protobuf.IMessage<YetiSimCoreLib.Components.InstantUsePlantLoadoutItem>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.InstantUsePlantLoadoutItem>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.InstantUsePlantLoadoutItem>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InstantUsePlantLoadoutItem> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418379c*/ InstantUsePlantLoadoutItem();
            static /*0x4183328*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InstantUsePlantLoadoutItem> get_Parser();
            static /*0x4183380*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41834d0*/ InstantUsePlantLoadoutItem();
            /*0x41834d8*/ InstantUsePlantLoadoutItem(YetiSimCoreLib.Components.InstantUsePlantLoadoutItem other);
            /*0x4183484*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418351c*/ YetiSimCoreLib.Components.InstantUsePlantLoadoutItem Clone();
            /*0x4183574*/ bool Equals(object other);
            /*0x41835f8*/ bool Equals(YetiSimCoreLib.Components.InstantUsePlantLoadoutItem other);
            /*0x4183624*/ int GetHashCode();
            /*0x4183650*/ string ToString();
            /*0x41836a8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41836c8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41836dc*/ int CalculateSize();
            /*0x41836f0*/ void MergeFrom(YetiSimCoreLib.Components.InstantUsePlantLoadoutItem other);
            /*0x4183724*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4183744*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.InstantUsePlantLoadoutItem.<> <>9;

                static /*0x41838b4*/ <>c();
                /*0x418391c*/ <>c();
                /*0x4183924*/ YetiSimCoreLib.Components.InstantUsePlantLoadoutItem <.cctor>b__22_0();
            }
        }

        class InstantDefensePlantLoadoutItem : Google.Protobuf.IMessage<YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4183dec*/ InstantDefensePlantLoadoutItem();
            static /*0x4183978*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem> get_Parser();
            static /*0x41839d0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4183b20*/ InstantDefensePlantLoadoutItem();
            /*0x4183b28*/ InstantDefensePlantLoadoutItem(YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem other);
            /*0x4183ad4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4183b6c*/ YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem Clone();
            /*0x4183bc4*/ bool Equals(object other);
            /*0x4183c48*/ bool Equals(YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem other);
            /*0x4183c74*/ int GetHashCode();
            /*0x4183ca0*/ string ToString();
            /*0x4183cf8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4183d18*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4183d2c*/ int CalculateSize();
            /*0x4183d40*/ void MergeFrom(YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem other);
            /*0x4183d74*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4183d94*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem.<> <>9;

                static /*0x4183f04*/ <>c();
                /*0x4183f6c*/ <>c();
                /*0x4183f74*/ YetiSimCoreLib.Components.InstantDefensePlantLoadoutItem <.cctor>b__22_0();
            }
        }

        class LossAversionComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4184020*/ LossAversionComponentReflection();
            static /*0x4183fc8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class LossAversionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LossAversionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LossAversionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LossAversionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LossAversionComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int uses_;
            /*0x1c*/ int offersSend_;
            /*0x20*/ int triggerTick_;

            static /*0x4184bf4*/ LossAversionComponent();
            static /*0x41844d8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LossAversionComponent> get_Parser();
            static /*0x4184530*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4184680*/ LossAversionComponent();
            /*0x4184688*/ LossAversionComponent(YetiSimCoreLib.Components.LossAversionComponent other);
            /*0x4184634*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41846dc*/ YetiSimCoreLib.Components.LossAversionComponent Clone();
            /*0x4184734*/ int get_Uses();
            /*0x418473c*/ void set_Uses(int value);
            /*0x4184744*/ int get_OffersSend();
            /*0x418474c*/ void set_OffersSend(int value);
            /*0x4184754*/ int get_TriggerTick();
            /*0x418475c*/ void set_TriggerTick(int value);
            /*0x4184764*/ bool Equals(object other);
            /*0x41847c8*/ bool Equals(YetiSimCoreLib.Components.LossAversionComponent other);
            /*0x4184824*/ int GetHashCode();
            /*0x41848b8*/ string ToString();
            /*0x4184910*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4184930*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41849e0*/ int CalculateSize();
            /*0x4184ac0*/ void MergeFrom(YetiSimCoreLib.Components.LossAversionComponent other);
            /*0x4184b18*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4184b38*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LossAversionComponent.<> <>9;

                static /*0x4184d0c*/ <>c();
                /*0x4184d74*/ <>c();
                /*0x4184d7c*/ YetiSimCoreLib.Components.LossAversionComponent <.cctor>b__37_0();
            }
        }

        class ModifierDurationReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4184e28*/ ModifierDurationReflection();
            static /*0x4184dd0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        enum ModifierDurationType
        {
            InvalidModifierDuration = 0,
            PermanentDuration = 1,
            TimedDuration = 2,
            AttackCycleDuration = 3,
        }

        class ModifySunOverTimeComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4185198*/ ModifySunOverTimeComponentReflection();
            static /*0x4185140*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ModifySunOverTimeComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ModifySunOverTimeComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ModifySunOverTimeComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ModifySunOverTimeComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ModifySunOverTimeComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int sunRemaining_;
            /*0x1c*/ int sunSpawned_;
            /*0x20*/ double sunAccumulated_;
            /*0x28*/ double sunPerSpawn_;
            /*0x30*/ int ticksRemaining_;
            /*0x34*/ int ticksInterval_;
            /*0x38*/ bool isFromSky_;
            /*0x3c*/ int spawnPositionX_;
            /*0x40*/ int spawnPositionY_;
            /*0x44*/ int spawnPositionZ_;

            static /*0x41866e4*/ ModifySunOverTimeComponent();
            static /*0x418588c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ModifySunOverTimeComponent> get_Parser();
            static /*0x41858e4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4185a34*/ ModifySunOverTimeComponent();
            /*0x4185a3c*/ ModifySunOverTimeComponent(YetiSimCoreLib.Components.ModifySunOverTimeComponent other);
            /*0x41859e8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4185ab0*/ YetiSimCoreLib.Components.ModifySunOverTimeComponent Clone();
            /*0x4185b08*/ int get_SunRemaining();
            /*0x4185b10*/ void set_SunRemaining(int value);
            /*0x4185b18*/ int get_SunSpawned();
            /*0x4185b20*/ void set_SunSpawned(int value);
            /*0x4185b28*/ double get_SunAccumulated();
            /*0x4185b30*/ void set_SunAccumulated(double value);
            /*0x4185b38*/ double get_SunPerSpawn();
            /*0x4185b40*/ void set_SunPerSpawn(double value);
            /*0x4185b48*/ int get_TicksRemaining();
            /*0x4185b50*/ void set_TicksRemaining(int value);
            /*0x4185b58*/ int get_TicksInterval();
            /*0x4185b60*/ void set_TicksInterval(int value);
            /*0x4185b68*/ bool get_IsFromSky();
            /*0x4185b70*/ void set_IsFromSky(bool value);
            /*0x4185b78*/ int get_SpawnPositionX();
            /*0x4185b80*/ void set_SpawnPositionX(int value);
            /*0x4185b88*/ int get_SpawnPositionY();
            /*0x4185b90*/ void set_SpawnPositionY(int value);
            /*0x4185b98*/ int get_SpawnPositionZ();
            /*0x4185ba0*/ void set_SpawnPositionZ(int value);
            /*0x4185ba8*/ bool Equals(object other);
            /*0x4185c0c*/ bool Equals(YetiSimCoreLib.Components.ModifySunOverTimeComponent other);
            /*0x4185dec*/ int GetHashCode();
            /*0x4186048*/ string ToString();
            /*0x41860a0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41860c0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4186290*/ int CalculateSize();
            /*0x4186454*/ void MergeFrom(YetiSimCoreLib.Components.ModifySunOverTimeComponent other);
            /*0x418650c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418652c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ModifySunOverTimeComponent.<> <>9;

                static /*0x41867fc*/ <>c();
                /*0x4186864*/ <>c();
                /*0x418686c*/ YetiSimCoreLib.Components.ModifySunOverTimeComponent <.cctor>b__72_0();
            }
        }

        class MovementReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4186918*/ MovementReflection();
            static /*0x41868c0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class StopAtPositionMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StopAtPositionMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StopAtPositionMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StopAtPositionMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StopAtPositionMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int distanceFromHouse_;

            static /*0x41883ec*/ StopAtPositionMovementComponent();
            static /*0x4187e60*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StopAtPositionMovementComponent> get_Parser();
            static /*0x4187eb8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4188008*/ StopAtPositionMovementComponent();
            /*0x4188010*/ StopAtPositionMovementComponent(YetiSimCoreLib.Components.StopAtPositionMovementComponent other);
            /*0x4187fbc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418805c*/ YetiSimCoreLib.Components.StopAtPositionMovementComponent Clone();
            /*0x41880b4*/ int get_DistanceFromHouse();
            /*0x41880bc*/ void set_DistanceFromHouse(int value);
            /*0x41880c4*/ bool Equals(object other);
            /*0x4188128*/ bool Equals(YetiSimCoreLib.Components.StopAtPositionMovementComponent other);
            /*0x4188164*/ int GetHashCode();
            /*0x41881c0*/ string ToString();
            /*0x4188218*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4188238*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4188298*/ int CalculateSize();
            /*0x4188318*/ void MergeFrom(YetiSimCoreLib.Components.StopAtPositionMovementComponent other);
            /*0x4188358*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4188378*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StopAtPositionMovementComponent.<> <>9;

                static /*0x4188504*/ <>c();
                /*0x418856c*/ <>c();
                /*0x4188574*/ YetiSimCoreLib.Components.StopAtPositionMovementComponent <.cctor>b__27_0();
            }
        }

        class KnockbackMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.KnockbackMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.KnockbackMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.KnockbackMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KnockbackMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int targetX_;
            /*0x1c*/ int velocityX_;
            /*0x20*/ bool canPushOffBoard_;

            static /*0x4188d0c*/ KnockbackMovementComponent();
            static /*0x41885c8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KnockbackMovementComponent> get_Parser();
            static /*0x4188620*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4188770*/ KnockbackMovementComponent();
            /*0x4188778*/ KnockbackMovementComponent(YetiSimCoreLib.Components.KnockbackMovementComponent other);
            /*0x4188724*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41887cc*/ YetiSimCoreLib.Components.KnockbackMovementComponent Clone();
            /*0x4188824*/ int get_TargetX();
            /*0x418882c*/ void set_TargetX(int value);
            /*0x4188834*/ int get_VelocityX();
            /*0x418883c*/ void set_VelocityX(int value);
            /*0x4188844*/ bool get_CanPushOffBoard();
            /*0x418884c*/ void set_CanPushOffBoard(bool value);
            /*0x4188854*/ bool Equals(object other);
            /*0x41888b8*/ bool Equals(YetiSimCoreLib.Components.KnockbackMovementComponent other);
            /*0x4188924*/ int GetHashCode();
            /*0x41889d8*/ string ToString();
            /*0x4188a30*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4188a50*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4188b00*/ int CalculateSize();
            /*0x4188bcc*/ void MergeFrom(YetiSimCoreLib.Components.KnockbackMovementComponent other);
            /*0x4188c28*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4188c48*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.KnockbackMovementComponent.<> <>9;

                static /*0x4188e24*/ <>c();
                /*0x4188e8c*/ <>c();
                /*0x4188e94*/ YetiSimCoreLib.Components.KnockbackMovementComponent <.cctor>b__37_0();
            }
        }

        class ForcedToLaneMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ForcedToLaneMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ForcedToLaneMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ForcedToLaneMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ForcedToLaneMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418935c*/ ForcedToLaneMovementComponent();
            static /*0x4188ee8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ForcedToLaneMovementComponent> get_Parser();
            static /*0x4188f40*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4189090*/ ForcedToLaneMovementComponent();
            /*0x4189098*/ ForcedToLaneMovementComponent(YetiSimCoreLib.Components.ForcedToLaneMovementComponent other);
            /*0x4189044*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41890dc*/ YetiSimCoreLib.Components.ForcedToLaneMovementComponent Clone();
            /*0x4189134*/ bool Equals(object other);
            /*0x41891b8*/ bool Equals(YetiSimCoreLib.Components.ForcedToLaneMovementComponent other);
            /*0x41891e4*/ int GetHashCode();
            /*0x4189210*/ string ToString();
            /*0x4189268*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4189288*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418929c*/ int CalculateSize();
            /*0x41892b0*/ void MergeFrom(YetiSimCoreLib.Components.ForcedToLaneMovementComponent other);
            /*0x41892e4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4189304*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ForcedToLaneMovementComponent.<> <>9;

                static /*0x4189474*/ <>c();
                /*0x41894dc*/ <>c();
                /*0x41894e4*/ YetiSimCoreLib.Components.ForcedToLaneMovementComponent <.cctor>b__22_0();
            }
        }

        class MoveToAdjacentLaneMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int targetZ_;
            /*0x1c*/ int velocityZ_;

            static /*0x4189b88*/ MoveToAdjacentLaneMovementComponent();
            static /*0x4189538*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent> get_Parser();
            static /*0x4189590*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41896e0*/ MoveToAdjacentLaneMovementComponent();
            /*0x41896e8*/ MoveToAdjacentLaneMovementComponent(YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent other);
            /*0x4189694*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4189734*/ YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent Clone();
            /*0x418978c*/ int get_TargetZ();
            /*0x4189794*/ void set_TargetZ(int value);
            /*0x418979c*/ int get_VelocityZ();
            /*0x41897a4*/ void set_VelocityZ(int value);
            /*0x41897ac*/ bool Equals(object other);
            /*0x4189810*/ bool Equals(YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent other);
            /*0x418985c*/ int GetHashCode();
            /*0x41898d4*/ string ToString();
            /*0x418992c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418994c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41899d4*/ int CalculateSize();
            /*0x4189a88*/ void MergeFrom(YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent other);
            /*0x4189ad4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4189af4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent.<> <>9;

                static /*0x4189ca0*/ <>c();
                /*0x4189d08*/ <>c();
                /*0x4189d10*/ YetiSimCoreLib.Components.MoveToAdjacentLaneMovementComponent <.cctor>b__32_0();
            }
        }

        class MoveToAdjacentLaneCooldownComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x418a2f0*/ MoveToAdjacentLaneCooldownComponent();
            static /*0x4189d64*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent> get_Parser();
            static /*0x4189dbc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4189f0c*/ MoveToAdjacentLaneCooldownComponent();
            /*0x4189f14*/ MoveToAdjacentLaneCooldownComponent(YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent other);
            /*0x4189ec0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4189f60*/ YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent Clone();
            /*0x4189fb8*/ int get_TicksRemaining();
            /*0x4189fc0*/ void set_TicksRemaining(int value);
            /*0x4189fc8*/ bool Equals(object other);
            /*0x418a02c*/ bool Equals(YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent other);
            /*0x418a068*/ int GetHashCode();
            /*0x418a0c4*/ string ToString();
            /*0x418a11c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418a13c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418a19c*/ int CalculateSize();
            /*0x418a21c*/ void MergeFrom(YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent other);
            /*0x418a25c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418a27c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent.<> <>9;

                static /*0x418a408*/ <>c();
                /*0x418a470*/ <>c();
                /*0x418a478*/ YetiSimCoreLib.Components.MoveToAdjacentLaneCooldownComponent <.cctor>b__27_0();
            }
        }

        class KinematicMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.KinematicMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.KinematicMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.KinematicMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KinematicMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418a940*/ KinematicMovementComponent();
            static /*0x418a4cc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KinematicMovementComponent> get_Parser();
            static /*0x418a524*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418a674*/ KinematicMovementComponent();
            /*0x418a67c*/ KinematicMovementComponent(YetiSimCoreLib.Components.KinematicMovementComponent other);
            /*0x418a628*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418a6c0*/ YetiSimCoreLib.Components.KinematicMovementComponent Clone();
            /*0x418a718*/ bool Equals(object other);
            /*0x418a79c*/ bool Equals(YetiSimCoreLib.Components.KinematicMovementComponent other);
            /*0x418a7c8*/ int GetHashCode();
            /*0x418a7f4*/ string ToString();
            /*0x418a84c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418a86c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418a880*/ int CalculateSize();
            /*0x418a894*/ void MergeFrom(YetiSimCoreLib.Components.KinematicMovementComponent other);
            /*0x418a8c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418a8e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.KinematicMovementComponent.<> <>9;

                static /*0x418aa58*/ <>c();
                /*0x418aac0*/ <>c();
                /*0x418aac8*/ YetiSimCoreLib.Components.KinematicMovementComponent <.cctor>b__22_0();
            }
        }

        class DisabledMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DisabledMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DisabledMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DisabledMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DisabledMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418af90*/ DisabledMovementComponent();
            static /*0x418ab1c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DisabledMovementComponent> get_Parser();
            static /*0x418ab74*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418acc4*/ DisabledMovementComponent();
            /*0x418accc*/ DisabledMovementComponent(YetiSimCoreLib.Components.DisabledMovementComponent other);
            /*0x418ac78*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418ad10*/ YetiSimCoreLib.Components.DisabledMovementComponent Clone();
            /*0x418ad68*/ bool Equals(object other);
            /*0x418adec*/ bool Equals(YetiSimCoreLib.Components.DisabledMovementComponent other);
            /*0x418ae18*/ int GetHashCode();
            /*0x418ae44*/ string ToString();
            /*0x418ae9c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418aebc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418aed0*/ int CalculateSize();
            /*0x418aee4*/ void MergeFrom(YetiSimCoreLib.Components.DisabledMovementComponent other);
            /*0x418af18*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418af38*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DisabledMovementComponent.<> <>9;

                static /*0x418b0a8*/ <>c();
                /*0x418b110*/ <>c();
                /*0x418b118*/ YetiSimCoreLib.Components.DisabledMovementComponent <.cctor>b__22_0();
            }
        }

        class PulledTowardLocationMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PulledTowardLocationMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PulledTowardLocationMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PulledTowardLocationMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PulledTowardLocationMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int targetX_;
            /*0x1c*/ int velocityX_;
            /*0x20*/ int ticksRemaining_;

            static /*0x418b888*/ PulledTowardLocationMovementComponent();
            static /*0x418b16c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PulledTowardLocationMovementComponent> get_Parser();
            static /*0x418b1c4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418b314*/ PulledTowardLocationMovementComponent();
            /*0x418b31c*/ PulledTowardLocationMovementComponent(YetiSimCoreLib.Components.PulledTowardLocationMovementComponent other);
            /*0x418b2c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418b370*/ YetiSimCoreLib.Components.PulledTowardLocationMovementComponent Clone();
            /*0x418b3c8*/ int get_TargetX();
            /*0x418b3d0*/ void set_TargetX(int value);
            /*0x418b3d8*/ int get_VelocityX();
            /*0x418b3e0*/ void set_VelocityX(int value);
            /*0x418b3e8*/ int get_TicksRemaining();
            /*0x418b3f0*/ void set_TicksRemaining(int value);
            /*0x418b3f8*/ bool Equals(object other);
            /*0x418b45c*/ bool Equals(YetiSimCoreLib.Components.PulledTowardLocationMovementComponent other);
            /*0x418b4b8*/ int GetHashCode();
            /*0x418b54c*/ string ToString();
            /*0x418b5a4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418b5c4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418b674*/ int CalculateSize();
            /*0x418b754*/ void MergeFrom(YetiSimCoreLib.Components.PulledTowardLocationMovementComponent other);
            /*0x418b7ac*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418b7cc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PulledTowardLocationMovementComponent.<> <>9;

                static /*0x418b9a0*/ <>c();
                /*0x418ba08*/ <>c();
                /*0x418ba10*/ YetiSimCoreLib.Components.PulledTowardLocationMovementComponent <.cctor>b__37_0();
            }
        }

        class BounceMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BounceMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BounceMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BounceMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BounceMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int targetX_;
            /*0x1c*/ int targetY_;
            /*0x20*/ int velocityX_;
            /*0x24*/ int velocityY_;
            /*0x28*/ int accelerationY_;
            /*0x2c*/ bool keepPlayingAnimation_;
            /*0x30*/ int ticksRemaining_;

            static /*0x418c4b4*/ BounceMovementComponent();
            static /*0x418ba64*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BounceMovementComponent> get_Parser();
            static /*0x418babc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418bc0c*/ BounceMovementComponent();
            /*0x418bc14*/ BounceMovementComponent(YetiSimCoreLib.Components.BounceMovementComponent other);
            /*0x418bbc0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418bc78*/ YetiSimCoreLib.Components.BounceMovementComponent Clone();
            /*0x418bcd0*/ int get_TargetX();
            /*0x418bcd8*/ void set_TargetX(int value);
            /*0x418bce0*/ int get_TargetY();
            /*0x418bce8*/ void set_TargetY(int value);
            /*0x418bcf0*/ int get_VelocityX();
            /*0x418bcf8*/ void set_VelocityX(int value);
            /*0x418bd00*/ int get_VelocityY();
            /*0x418bd08*/ void set_VelocityY(int value);
            /*0x418bd10*/ int get_AccelerationY();
            /*0x418bd18*/ void set_AccelerationY(int value);
            /*0x418bd20*/ bool get_KeepPlayingAnimation();
            /*0x418bd28*/ void set_KeepPlayingAnimation(bool value);
            /*0x418bd30*/ int get_TicksRemaining();
            /*0x418bd38*/ void set_TicksRemaining(int value);
            /*0x418bd40*/ bool Equals(object other);
            /*0x418bda4*/ bool Equals(YetiSimCoreLib.Components.BounceMovementComponent other);
            /*0x418be50*/ int GetHashCode();
            /*0x418bf74*/ string ToString();
            /*0x418bfcc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418bfec*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418c13c*/ int CalculateSize();
            /*0x418c2b8*/ void MergeFrom(YetiSimCoreLib.Components.BounceMovementComponent other);
            /*0x418c344*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418c364*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BounceMovementComponent.<> <>9;

                static /*0x418c5cc*/ <>c();
                /*0x418c634*/ <>c();
                /*0x418c63c*/ YetiSimCoreLib.Components.BounceMovementComponent <.cctor>b__57_0();
            }
        }

        class CanBounceOffBoard : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CanBounceOffBoard>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CanBounceOffBoard>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CanBounceOffBoard>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CanBounceOffBoard> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418cb04*/ CanBounceOffBoard();
            static /*0x418c690*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CanBounceOffBoard> get_Parser();
            static /*0x418c6e8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418c838*/ CanBounceOffBoard();
            /*0x418c840*/ CanBounceOffBoard(YetiSimCoreLib.Components.CanBounceOffBoard other);
            /*0x418c7ec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418c884*/ YetiSimCoreLib.Components.CanBounceOffBoard Clone();
            /*0x418c8dc*/ bool Equals(object other);
            /*0x418c960*/ bool Equals(YetiSimCoreLib.Components.CanBounceOffBoard other);
            /*0x418c98c*/ int GetHashCode();
            /*0x418c9b8*/ string ToString();
            /*0x418ca10*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418ca30*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418ca44*/ int CalculateSize();
            /*0x418ca58*/ void MergeFrom(YetiSimCoreLib.Components.CanBounceOffBoard other);
            /*0x418ca8c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418caac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CanBounceOffBoard.<> <>9;

                static /*0x418cc1c*/ <>c();
                /*0x418cc84*/ <>c();
                /*0x418cc8c*/ YetiSimCoreLib.Components.CanBounceOffBoard <.cctor>b__22_0();
            }
        }

        class ShiftPositionMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ShiftPositionMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ShiftPositionMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ShiftPositionMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ShiftPositionMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418d154*/ ShiftPositionMovementComponent();
            static /*0x418cce0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ShiftPositionMovementComponent> get_Parser();
            static /*0x418cd38*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418ce88*/ ShiftPositionMovementComponent();
            /*0x418ce90*/ ShiftPositionMovementComponent(YetiSimCoreLib.Components.ShiftPositionMovementComponent other);
            /*0x418ce3c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418ced4*/ YetiSimCoreLib.Components.ShiftPositionMovementComponent Clone();
            /*0x418cf2c*/ bool Equals(object other);
            /*0x418cfb0*/ bool Equals(YetiSimCoreLib.Components.ShiftPositionMovementComponent other);
            /*0x418cfdc*/ int GetHashCode();
            /*0x418d008*/ string ToString();
            /*0x418d060*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418d080*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418d094*/ int CalculateSize();
            /*0x418d0a8*/ void MergeFrom(YetiSimCoreLib.Components.ShiftPositionMovementComponent other);
            /*0x418d0dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418d0fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ShiftPositionMovementComponent.<> <>9;

                static /*0x418d26c*/ <>c();
                /*0x418d2d4*/ <>c();
                /*0x418d2dc*/ YetiSimCoreLib.Components.ShiftPositionMovementComponent <.cctor>b__22_0();
            }
        }

        class HorizontalShiftPositionMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int targetX_;
            /*0x1c*/ int velocityX_;

            static /*0x418d980*/ HorizontalShiftPositionMovementComponent();
            static /*0x418d330*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent> get_Parser();
            static /*0x418d388*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418d4d8*/ HorizontalShiftPositionMovementComponent();
            /*0x418d4e0*/ HorizontalShiftPositionMovementComponent(YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent other);
            /*0x418d48c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418d52c*/ YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent Clone();
            /*0x418d584*/ int get_TargetX();
            /*0x418d58c*/ void set_TargetX(int value);
            /*0x418d594*/ int get_VelocityX();
            /*0x418d59c*/ void set_VelocityX(int value);
            /*0x418d5a4*/ bool Equals(object other);
            /*0x418d608*/ bool Equals(YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent other);
            /*0x418d654*/ int GetHashCode();
            /*0x418d6cc*/ string ToString();
            /*0x418d724*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418d744*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418d7cc*/ int CalculateSize();
            /*0x418d880*/ void MergeFrom(YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent other);
            /*0x418d8cc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418d8ec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent.<> <>9;

                static /*0x418da98*/ <>c();
                /*0x418db00*/ <>c();
                /*0x418db08*/ YetiSimCoreLib.Components.HorizontalShiftPositionMovementComponent <.cctor>b__32_0();
            }
        }

        class FloorBoundMovementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FloorBoundMovementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FloorBoundMovementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FloorBoundMovementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FloorBoundMovementComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418dfd0*/ FloorBoundMovementComponent();
            static /*0x418db5c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FloorBoundMovementComponent> get_Parser();
            static /*0x418dbb4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418dd04*/ FloorBoundMovementComponent();
            /*0x418dd0c*/ FloorBoundMovementComponent(YetiSimCoreLib.Components.FloorBoundMovementComponent other);
            /*0x418dcb8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418dd50*/ YetiSimCoreLib.Components.FloorBoundMovementComponent Clone();
            /*0x418dda8*/ bool Equals(object other);
            /*0x418de2c*/ bool Equals(YetiSimCoreLib.Components.FloorBoundMovementComponent other);
            /*0x418de58*/ int GetHashCode();
            /*0x418de84*/ string ToString();
            /*0x418dedc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418defc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418df10*/ int CalculateSize();
            /*0x418df24*/ void MergeFrom(YetiSimCoreLib.Components.FloorBoundMovementComponent other);
            /*0x418df58*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418df78*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FloorBoundMovementComponent.<> <>9;

                static /*0x418e0e8*/ <>c();
                /*0x418e150*/ <>c();
                /*0x418e158*/ YetiSimCoreLib.Components.FloorBoundMovementComponent <.cctor>b__22_0();
            }
        }

        class NoCascadePointsComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x418e204*/ NoCascadePointsComponentReflection();
            static /*0x418e1ac*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class NoCascadePointsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.NoCascadePointsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.NoCascadePointsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.NoCascadePointsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.NoCascadePointsComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418e9c0*/ NoCascadePointsComponent();
            static /*0x418e54c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.NoCascadePointsComponent> get_Parser();
            static /*0x418e5a4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418e6f4*/ NoCascadePointsComponent();
            /*0x418e6fc*/ NoCascadePointsComponent(YetiSimCoreLib.Components.NoCascadePointsComponent other);
            /*0x418e6a8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418e740*/ YetiSimCoreLib.Components.NoCascadePointsComponent Clone();
            /*0x418e798*/ bool Equals(object other);
            /*0x418e81c*/ bool Equals(YetiSimCoreLib.Components.NoCascadePointsComponent other);
            /*0x418e848*/ int GetHashCode();
            /*0x418e874*/ string ToString();
            /*0x418e8cc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418e8ec*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418e900*/ int CalculateSize();
            /*0x418e914*/ void MergeFrom(YetiSimCoreLib.Components.NoCascadePointsComponent other);
            /*0x418e948*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418e968*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.NoCascadePointsComponent.<> <>9;

                static /*0x418ead8*/ <>c();
                /*0x418eb40*/ <>c();
                /*0x418eb48*/ YetiSimCoreLib.Components.NoCascadePointsComponent <.cctor>b__22_0();
            }
        }

        class OnBoardBoostComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x418ebf4*/ OnBoardBoostComponentReflection();
            static /*0x418eb9c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class OnBoardBoostComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OnBoardBoostComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OnBoardBoostComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OnBoardBoostComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OnBoardBoostComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x418f694*/ OnBoardBoostComponent();
            static /*0x418f220*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OnBoardBoostComponent> get_Parser();
            static /*0x418f278*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418f3c8*/ OnBoardBoostComponent();
            /*0x418f3d0*/ OnBoardBoostComponent(YetiSimCoreLib.Components.OnBoardBoostComponent other);
            /*0x418f37c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418f414*/ YetiSimCoreLib.Components.OnBoardBoostComponent Clone();
            /*0x418f46c*/ bool Equals(object other);
            /*0x418f4f0*/ bool Equals(YetiSimCoreLib.Components.OnBoardBoostComponent other);
            /*0x418f51c*/ int GetHashCode();
            /*0x418f548*/ string ToString();
            /*0x418f5a0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418f5c0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418f5d4*/ int CalculateSize();
            /*0x418f5e8*/ void MergeFrom(YetiSimCoreLib.Components.OnBoardBoostComponent other);
            /*0x418f61c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418f63c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OnBoardBoostComponent.<> <>9;

                static /*0x418f7ac*/ <>c();
                /*0x418f814*/ <>c();
                /*0x418f81c*/ YetiSimCoreLib.Components.OnBoardBoostComponent <.cctor>b__22_0();
            }
        }

        class OnBoardInstantUsePlantBoostComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int unitId_;

            static /*0x418fdfc*/ OnBoardInstantUsePlantBoostComponent();
            static /*0x418f870*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent> get_Parser();
            static /*0x418f8c8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x418fa18*/ OnBoardInstantUsePlantBoostComponent();
            /*0x418fa20*/ OnBoardInstantUsePlantBoostComponent(YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent other);
            /*0x418f9cc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x418fa6c*/ YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent Clone();
            /*0x418fac4*/ int get_UnitId();
            /*0x418facc*/ void set_UnitId(int value);
            /*0x418fad4*/ bool Equals(object other);
            /*0x418fb38*/ bool Equals(YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent other);
            /*0x418fb74*/ int GetHashCode();
            /*0x418fbd0*/ string ToString();
            /*0x418fc28*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x418fc48*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x418fca8*/ int CalculateSize();
            /*0x418fd28*/ void MergeFrom(YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent other);
            /*0x418fd68*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x418fd88*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent.<> <>9;

                static /*0x418ff14*/ <>c();
                /*0x418ff7c*/ <>c();
                /*0x418ff84*/ YetiSimCoreLib.Components.OnBoardInstantUsePlantBoostComponent <.cctor>b__27_0();
            }
        }

        class OnBoardPlantFoodBoostComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x419044c*/ OnBoardPlantFoodBoostComponent();
            static /*0x418ffd8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent> get_Parser();
            static /*0x4190030*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4190180*/ OnBoardPlantFoodBoostComponent();
            /*0x4190188*/ OnBoardPlantFoodBoostComponent(YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent other);
            /*0x4190134*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41901cc*/ YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent Clone();
            /*0x4190224*/ bool Equals(object other);
            /*0x41902a8*/ bool Equals(YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent other);
            /*0x41902d4*/ int GetHashCode();
            /*0x4190300*/ string ToString();
            /*0x4190358*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4190378*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x419038c*/ int CalculateSize();
            /*0x41903a0*/ void MergeFrom(YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent other);
            /*0x41903d4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41903f4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent.<> <>9;

                static /*0x4190564*/ <>c();
                /*0x41905cc*/ <>c();
                /*0x41905d4*/ YetiSimCoreLib.Components.OnBoardPlantFoodBoostComponent <.cctor>b__22_0();
            }
        }

        class OrientationComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4190680*/ OrientationComponentReflection();
            static /*0x4190628*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class OrientationComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OrientationComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OrientationComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OrientationComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OrientationComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.DirectionType value_;

            static /*0x4191108*/ OrientationComponent();
            static /*0x4190b7c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OrientationComponent> get_Parser();
            static /*0x4190bd4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4190d24*/ OrientationComponent();
            /*0x4190d2c*/ OrientationComponent(YetiSimCoreLib.Components.OrientationComponent other);
            /*0x4190cd8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4190d78*/ YetiSimCoreLib.Components.OrientationComponent Clone();
            /*0x4190dd0*/ Yeti.Data.DirectionType get_Value();
            /*0x4190dd8*/ void set_Value(Yeti.Data.DirectionType value);
            /*0x4190de0*/ bool Equals(object other);
            /*0x4190e44*/ bool Equals(YetiSimCoreLib.Components.OrientationComponent other);
            /*0x4190e80*/ int GetHashCode();
            /*0x4190edc*/ string ToString();
            /*0x4190f34*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4190f54*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4190fb4*/ int CalculateSize();
            /*0x4191034*/ void MergeFrom(YetiSimCoreLib.Components.OrientationComponent other);
            /*0x4191074*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4191094*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OrientationComponent.<> <>9;

                static /*0x4191220*/ <>c();
                /*0x4191288*/ <>c();
                /*0x4191290*/ YetiSimCoreLib.Components.OrientationComponent <.cctor>b__27_0();
            }
        }

        class PausedComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x419133c*/ PausedComponentReflection();
            static /*0x41912e4*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PausedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PausedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PausedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PausedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PausedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4191ae0*/ PausedComponent();
            static /*0x419166c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PausedComponent> get_Parser();
            static /*0x41916c4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4191814*/ PausedComponent();
            /*0x419181c*/ PausedComponent(YetiSimCoreLib.Components.PausedComponent other);
            /*0x41917c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4191860*/ YetiSimCoreLib.Components.PausedComponent Clone();
            /*0x41918b8*/ bool Equals(object other);
            /*0x419193c*/ bool Equals(YetiSimCoreLib.Components.PausedComponent other);
            /*0x4191968*/ int GetHashCode();
            /*0x4191994*/ string ToString();
            /*0x41919ec*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4191a0c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4191a20*/ int CalculateSize();
            /*0x4191a34*/ void MergeFrom(YetiSimCoreLib.Components.PausedComponent other);
            /*0x4191a68*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4191a88*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PausedComponent.<> <>9;

                static /*0x4191bf8*/ <>c();
                /*0x4191c60*/ <>c();
                /*0x4191c68*/ YetiSimCoreLib.Components.PausedComponent <.cctor>b__22_0();
            }
        }

        class PayloadComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4191d14*/ PayloadComponentReflection();
            static /*0x4191cbc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PayloadComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadComponent> _parser;
            static /*0x8*/ Google.Protobuf.Collections.MapField.Codec<int, int> _map_values_codec;
            static /*0x10*/ Google.Protobuf.FieldCodec<YetiSimCoreLib.Components.PayloadAction> _repeated_actions_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int sourceId_;
            /*0x1c*/ int sourceUnitId_;
            /*0x20*/ int abilityId_;
            /*0x28*/ Google.Protobuf.Collections.MapField<int, int> values_;
            /*0x30*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.PayloadAction> actions_;

            static /*0x419bb38*/ PayloadComponent();
            static /*0x419af14*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadComponent> get_Parser();
            static /*0x419af6c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x419b0bc*/ PayloadComponent();
            /*0x419b198*/ PayloadComponent(YetiSimCoreLib.Components.PayloadComponent other);
            /*0x419b070*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x419b268*/ YetiSimCoreLib.Components.PayloadComponent Clone();
            /*0x419b2c0*/ int get_SourceId();
            /*0x419b2c8*/ void set_SourceId(int value);
            /*0x419b2d0*/ int get_SourceUnitId();
            /*0x419b2d8*/ void set_SourceUnitId(int value);
            /*0x419b2e0*/ int get_AbilityId();
            /*0x419b2e8*/ void set_AbilityId(int value);
            /*0x419b2f0*/ Google.Protobuf.Collections.MapField<int, int> get_Values();
            /*0x419b2f8*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.PayloadAction> get_Actions();
            /*0x419b300*/ bool Equals(object other);
            /*0x419b364*/ bool Equals(YetiSimCoreLib.Components.PayloadComponent other);
            /*0x419b450*/ int GetHashCode();
            /*0x419b520*/ string ToString();
            /*0x419b578*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x419b598*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x419b710*/ int CalculateSize();
            /*0x419b894*/ void MergeFrom(YetiSimCoreLib.Components.PayloadComponent other);
            /*0x419b968*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x419b988*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PayloadComponent.<> <>9;

                static /*0x419bd78*/ <>c();
                /*0x419bde0*/ <>c();
                /*0x419bde8*/ YetiSimCoreLib.Components.PayloadComponent <.cctor>b__47_0();
            }
        }

        class PayloadAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<YetiSimCoreLib.Components.PayloadConstraint> _repeated_perTargetActionConstraints_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.PayloadConstraint> perTargetActionConstraints_;
            /*0x20*/ bool isPerkGeneratedPayload_;
            /*0x28*/ object action_;
            /*0x30*/ YetiSimCoreLib.Components.PayloadAction.ActionOneofCase actionCase_;

            static /*0x41a6e88*/ PayloadAction();
            static /*0x419be38*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction> get_Parser();
            static /*0x419be90*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x419bfe0*/ PayloadAction();
            /*0x419c068*/ PayloadAction(YetiSimCoreLib.Components.PayloadAction other);
            /*0x419bf94*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x419ee0c*/ YetiSimCoreLib.Components.PayloadAction Clone();
            /*0x419ee64*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.PayloadConstraint> get_PerTargetActionConstraints();
            /*0x419ee6c*/ bool get_IsPerkGeneratedPayload();
            /*0x419ee74*/ void set_IsPerkGeneratedPayload(bool value);
            /*0x419c704*/ YetiSimCoreLib.Components.PayloadAction.Types.DamageAction get_Damage();
            /*0x419c770*/ void set_Damage(YetiSimCoreLib.Components.PayloadAction.Types.DamageAction value);
            /*0x419c7a8*/ YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction get_Knockback();
            /*0x419c814*/ void set_Knockback(YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction value);
            /*0x419c84c*/ YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction get_StatModifier();
            /*0x419c8b8*/ void set_StatModifier(YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction value);
            /*0x419c8f0*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction get_ApplyAbility();
            /*0x419c95c*/ void set_ApplyAbility(YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction value);
            /*0x419c994*/ YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction get_Explode();
            /*0x419ca00*/ void set_Explode(YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction value);
            /*0x419ca38*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction get_DestroySelf();
            /*0x419caa4*/ void set_DestroySelf(YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction value);
            /*0x419cadc*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction get_ChangeState();
            /*0x419cb48*/ void set_ChangeState(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction value);
            /*0x419cb7c*/ YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction get_AddArmor();
            /*0x419cbe8*/ void set_AddArmor(YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction value);
            /*0x419cc20*/ YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction get_AutoArm();
            /*0x419cc8c*/ void set_AutoArm(YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction value);
            /*0x419ccc4*/ YetiSimCoreLib.Components.PayloadAction.Types.HealAction get_Heal();
            /*0x419cd30*/ void set_Heal(YetiSimCoreLib.Components.PayloadAction.Types.HealAction value);
            /*0x419cd68*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction get_SpawnUnit();
            /*0x419cdd4*/ void set_SpawnUnit(YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction value);
            /*0x419ce0c*/ YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction get_HealArmor();
            /*0x419ce78*/ void set_HealArmor(YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction value);
            /*0x419ceb0*/ YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction get_UnarmSelf();
            /*0x419cf1c*/ void set_UnarmSelf(YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction value);
            /*0x419cf54*/ YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction get_PushAwayFromLane();
            /*0x419cfc0*/ void set_PushAwayFromLane(YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction value);
            /*0x419cff8*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction get_PullTowardLane();
            /*0x419d064*/ void set_PullTowardLane(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction value);
            /*0x419d09c*/ YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction get_ModifySun();
            /*0x419d108*/ void set_ModifySun(YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction value);
            /*0x419d140*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction get_RemoveStat();
            /*0x419d1ac*/ void set_RemoveStat(YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction value);
            /*0x419d1e4*/ YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction get_HealOrAddArmor();
            /*0x419d250*/ void set_HealOrAddArmor(YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction value);
            /*0x419d288*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction get_MoveToRandomLane();
            /*0x419d2f4*/ void set_MoveToRandomLane(YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction value);
            /*0x419d32c*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction get_AddTag();
            /*0x419d398*/ void set_AddTag(YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction value);
            /*0x419d3d0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction get_RemoveTag();
            /*0x419d43c*/ void set_RemoveTag(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction value);
            /*0x419d474*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction get_AddTargetingImmunity();
            /*0x419d4e0*/ void set_AddTargetingImmunity(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction value);
            /*0x419d514*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction get_RemoveTargetingImmunity();
            /*0x419d580*/ void set_RemoveTargetingImmunity(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction value);
            /*0x419d5b8*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction get_AddTargetingRequirement();
            /*0x419d624*/ void set_AddTargetingRequirement(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction value);
            /*0x419d65c*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction get_RemoveTargetingRequirement();
            /*0x419d6c8*/ void set_RemoveTargetingRequirement(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction value);
            /*0x419d700*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction get_PullTowardSelf();
            /*0x419d76c*/ void set_PullTowardSelf(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction value);
            /*0x419d7a4*/ YetiSimCoreLib.Components.PayloadAction.Types.TransformAction get_Transform();
            /*0x419d810*/ void set_Transform(YetiSimCoreLib.Components.PayloadAction.Types.TransformAction value);
            /*0x419d848*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction get_ChangeMovementDirection();
            /*0x419d8b4*/ void set_ChangeMovementDirection(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction value);
            /*0x419d8ec*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction get_ChangeStatBaseValue();
            /*0x419d958*/ void set_ChangeStatBaseValue(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction value);
            /*0x419d990*/ YetiSimCoreLib.Components.PayloadAction.Types.BounceAction get_Bounce();
            /*0x419d9fc*/ void set_Bounce(YetiSimCoreLib.Components.PayloadAction.Types.BounceAction value);
            /*0x419da34*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction get_ChangeBehaviorState();
            /*0x419daa0*/ void set_ChangeBehaviorState(YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction value);
            /*0x419dad8*/ YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction get_DeathSpotTrigger();
            /*0x419db44*/ void set_DeathSpotTrigger(YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction value);
            /*0x419db7c*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction get_SpawnPushedObstacle();
            /*0x419dbe8*/ void set_SpawnPushedObstacle(YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction value);
            /*0x419dc20*/ YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction get_RestoreCharges();
            /*0x419dc8c*/ void set_RestoreCharges(YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction value);
            /*0x419dcc4*/ YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction get_StoreUnit();
            /*0x419dd30*/ void set_StoreUnit(YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction value);
            /*0x419dd68*/ YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction get_PromoteUnit();
            /*0x419ddd4*/ void set_PromoteUnit(YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction value);
            /*0x419de0c*/ YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction get_GenerateImpactActions();
            /*0x419de78*/ void set_GenerateImpactActions(YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction value);
            /*0x419deb0*/ YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction get_TeleportToUnit();
            /*0x419df1c*/ void set_TeleportToUnit(YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction value);
            /*0x419df54*/ YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction get_Impact();
            /*0x419dfc0*/ void set_Impact(YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction value);
            /*0x419dff8*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction get_ChangeMaterial();
            /*0x419e064*/ void set_ChangeMaterial(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction value);
            /*0x419e09c*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction get_ChangeHitbox();
            /*0x419e108*/ void set_ChangeHitbox(YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction value);
            /*0x419e140*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction get_RemoveArmorStack();
            /*0x419e1ac*/ void set_RemoveArmorStack(YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction value);
            /*0x419e1e4*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction get_RemoveUnit();
            /*0x419e250*/ void set_RemoveUnit(YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction value);
            /*0x419e288*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction get_ChangeMovementSpeed();
            /*0x419e2f4*/ void set_ChangeMovementSpeed(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction value);
            /*0x419e32c*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction get_ApplyPlantFood();
            /*0x419e398*/ void set_ApplyPlantFood(YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction value);
            /*0x419e3d0*/ YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction get_DetachAttachedUnit();
            /*0x419e43c*/ void set_DetachAttachedUnit(YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction value);
            /*0x419e474*/ YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction get_RepopulateUnitFormation();
            /*0x419e4e0*/ void set_RepopulateUnitFormation(YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction value);
            /*0x419e518*/ YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction get_SetSunGenerationRate();
            /*0x419e584*/ void set_SetSunGenerationRate(YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction value);
            /*0x419e5bc*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction get_Destroy();
            /*0x419e628*/ void set_Destroy(YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction value);
            /*0x419e660*/ YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction get_DeflectConsumedProjectile();
            /*0x419e6cc*/ void set_DeflectConsumedProjectile(YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction value);
            /*0x419e704*/ YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction get_ManualActivateAbility();
            /*0x419e770*/ void set_ManualActivateAbility(YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction value);
            /*0x419e7a8*/ YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction get_ShiftPosition();
            /*0x419e814*/ void set_ShiftPosition(YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction value);
            /*0x419e84c*/ YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction get_DelayFutureWaves();
            /*0x419e8b8*/ void set_DelayFutureWaves(YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction value);
            /*0x419e8f0*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction get_PreventReachingGoal();
            /*0x419e95c*/ void set_PreventReachingGoal(YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction value);
            /*0x419e990*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction get_MoveSelfToTargetLane();
            /*0x419e9fc*/ void set_MoveSelfToTargetLane(YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction value);
            /*0x419ea34*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction get_RemoveCellOccupancy();
            /*0x419eaa0*/ void set_RemoveCellOccupancy(YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction value);
            /*0x419ead8*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction get_PreventGameEnd();
            /*0x419eb44*/ void set_PreventGameEnd(YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction value);
            /*0x419eb7c*/ YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction get_ForceNextSpawnToLane();
            /*0x419ebe8*/ void set_ForceNextSpawnToLane(YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction value);
            /*0x419ec20*/ YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction get_MarkHitByAbilityInstance();
            /*0x419ec8c*/ void set_MarkHitByAbilityInstance(YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction value);
            /*0x419ecc4*/ YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction get_GrantDamageRedirection();
            /*0x419ed30*/ void set_GrantDamageRedirection(YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction value);
            /*0x419ed68*/ YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction get_SetAbilityCooldown();
            /*0x419edd4*/ void set_SetAbilityCooldown(YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction value);
            /*0x419ee7c*/ YetiSimCoreLib.Components.PayloadAction.ActionOneofCase get_ActionCase();
            /*0x419ee84*/ void ClearAction();
            /*0x419ee94*/ bool Equals(object other);
            /*0x419eef8*/ bool Equals(YetiSimCoreLib.Components.PayloadAction other);
            /*0x419f940*/ int GetHashCode();
            /*0x41a035c*/ string ToString();
            /*0x41a03b4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41a03d4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41a11f4*/ int CalculateSize();
            /*0x41a23d8*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction other);
            /*0x41a4414*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41a4434*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            enum ActionOneofCase
            {
                None = 0,
                Damage = 10,
                Knockback = 11,
                StatModifier = 12,
                ApplyAbility = 13,
                Explode = 14,
                DestroySelf = 15,
                ChangeState = 16,
                AddArmor = 17,
                AutoArm = 18,
                Heal = 19,
                SpawnUnit = 20,
                HealArmor = 22,
                UnarmSelf = 23,
                PushAwayFromLane = 24,
                PullTowardLane = 25,
                ModifySun = 26,
                RemoveStat = 27,
                HealOrAddArmor = 28,
                MoveToRandomLane = 29,
                AddTag = 30,
                RemoveTag = 31,
                AddTargetingImmunity = 32,
                RemoveTargetingImmunity = 33,
                AddTargetingRequirement = 34,
                RemoveTargetingRequirement = 35,
                PullTowardSelf = 36,
                Transform = 37,
                ChangeMovementDirection = 38,
                ChangeStatBaseValue = 39,
                Bounce = 40,
                ChangeBehaviorState = 41,
                DeathSpotTrigger = 42,
                SpawnPushedObstacle = 43,
                RestoreCharges = 44,
                StoreUnit = 45,
                PromoteUnit = 46,
                GenerateImpactActions = 47,
                TeleportToUnit = 48,
                Impact = 49,
                ChangeMaterial = 50,
                ChangeHitbox = 51,
                RemoveArmorStack = 52,
                RemoveUnit = 53,
                ChangeMovementSpeed = 54,
                ApplyPlantFood = 55,
                DetachAttachedUnit = 56,
                RepopulateUnitFormation = 57,
                SetSunGenerationRate = 58,
                Destroy = 59,
                DeflectConsumedProjectile = 60,
                ManualActivateAbility = 61,
                ShiftPosition = 62,
                DelayFutureWaves = 63,
                PreventReachingGoal = 64,
                MoveSelfToTargetLane = 65,
                RemoveCellOccupancy = 66,
                PreventGameEnd = 67,
                ForceNextSpawnToLane = 68,
                MarkHitByAbilityInstance = 69,
                GrantDamageRedirection = 70,
                SetAbilityCooldown = 71,
            }

            class Types
            {
                class DamageAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.DamageAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.DamageAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.DamageAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DamageAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool removeTargetIfKilled_;
                    /*0x20*/ string deathPresentationTag_;

                    static /*0x41a77b0*/ DamageAction();
                    static /*0x41a7038*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DamageAction> get_Parser();
                    static /*0x41a7090*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41a71ac*/ DamageAction();
                    /*0x41a7204*/ DamageAction(YetiSimCoreLib.Components.PayloadAction.Types.DamageAction other);
                    /*0x41a7160*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41a725c*/ YetiSimCoreLib.Components.PayloadAction.Types.DamageAction Clone();
                    /*0x41a72b4*/ bool get_RemoveTargetIfKilled();
                    /*0x41a72bc*/ void set_RemoveTargetIfKilled(bool value);
                    /*0x41a72c4*/ string get_DeathPresentationTag();
                    /*0x41a72cc*/ void set_DeathPresentationTag(string value);
                    /*0x41a7348*/ bool Equals(object other);
                    /*0x41a73ac*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.DamageAction other);
                    /*0x41a742c*/ int GetHashCode();
                    /*0x41a74c0*/ string ToString();
                    /*0x41a7518*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41a7538*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41a75cc*/ int CalculateSize();
                    /*0x41a7664*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.DamageAction other);
                    /*0x41a76d8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41a76f8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.DamageAction.<> <>9;

                        static /*0x41a78c8*/ <>c();
                        /*0x41a7930*/ <>c();
                        /*0x41a7938*/ YetiSimCoreLib.Components.PayloadAction.Types.DamageAction <.cctor>b__32_0();
                    }
                }

                class KnockbackAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool canPushOffBoard_;
                    /*0x19*/ bool ignoreResistance_;
                    /*0x1a*/ bool overrideKinematicMovements_;

                    static /*0x41a8074*/ KnockbackAction();
                    static /*0x41a7988*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction> get_Parser();
                    static /*0x41a79e0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41a7afc*/ KnockbackAction();
                    /*0x41a7b04*/ KnockbackAction(YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction other);
                    /*0x41a7ab0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41a7b58*/ YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction Clone();
                    /*0x41a7bb0*/ bool get_CanPushOffBoard();
                    /*0x41a7bb8*/ void set_CanPushOffBoard(bool value);
                    /*0x41a7bc0*/ bool get_IgnoreResistance();
                    /*0x41a7bc8*/ void set_IgnoreResistance(bool value);
                    /*0x41a7bd0*/ bool get_OverrideKinematicMovements();
                    /*0x41a7bd8*/ void set_OverrideKinematicMovements(bool value);
                    /*0x41a7be0*/ bool Equals(object other);
                    /*0x41a7c44*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction other);
                    /*0x41a7cd0*/ int GetHashCode();
                    /*0x41a7da8*/ string ToString();
                    /*0x41a7e00*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41a7e20*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41a7ed0*/ int CalculateSize();
                    /*0x41a7f1c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction other);
                    /*0x41a7f80*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41a7fa0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction.<> <>9;

                        static /*0x41a818c*/ <>c();
                        /*0x41a81f4*/ <>c();
                        /*0x41a81fc*/ YetiSimCoreLib.Components.PayloadAction.Types.KnockbackAction <.cctor>b__37_0();
                    }
                }

                class StatModifierAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ YetiSimCoreLib.Components.StatModifier modifier_;

                    static /*0x41a890c*/ StatModifierAction();
                    static /*0x41a8250*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction> get_Parser();
                    static /*0x41a82a8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41a83c4*/ StatModifierAction();
                    /*0x41a83cc*/ StatModifierAction(YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction other);
                    /*0x41a8378*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41a843c*/ YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction Clone();
                    /*0x41a8494*/ YetiSimCoreLib.Components.StatModifier get_Modifier();
                    /*0x41a849c*/ void set_Modifier(YetiSimCoreLib.Components.StatModifier value);
                    /*0x41a84a4*/ bool Equals(object other);
                    /*0x41a8508*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction other);
                    /*0x41a8568*/ int GetHashCode();
                    /*0x41a85bc*/ string ToString();
                    /*0x41a8614*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41a8634*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41a8694*/ int CalculateSize();
                    /*0x41a8714*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction other);
                    /*0x41a87e0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41a8800*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction.<> <>9;

                        static /*0x41a8a24*/ <>c();
                        /*0x41a8a8c*/ <>c();
                        /*0x41a8a94*/ YetiSimCoreLib.Components.PayloadAction.Types.StatModifierAction <.cctor>b__27_0();
                    }
                }

                class ApplyAbilityAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ YetiSimCoreLib.Components.AbilityEntry entry_;

                    static /*0x41a91a4*/ ApplyAbilityAction();
                    static /*0x41a8ae8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction> get_Parser();
                    static /*0x41a8b40*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41a8c5c*/ ApplyAbilityAction();
                    /*0x41a8c64*/ ApplyAbilityAction(YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction other);
                    /*0x41a8c10*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41a8cd4*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction Clone();
                    /*0x41a8d2c*/ YetiSimCoreLib.Components.AbilityEntry get_Entry();
                    /*0x41a8d34*/ void set_Entry(YetiSimCoreLib.Components.AbilityEntry value);
                    /*0x41a8d3c*/ bool Equals(object other);
                    /*0x41a8da0*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction other);
                    /*0x41a8e00*/ int GetHashCode();
                    /*0x41a8e54*/ string ToString();
                    /*0x41a8eac*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41a8ecc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41a8f2c*/ int CalculateSize();
                    /*0x41a8fac*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction other);
                    /*0x41a9078*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41a9098*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction.<> <>9;

                        static /*0x41a92bc*/ <>c();
                        /*0x41a9324*/ <>c();
                        /*0x41a932c*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyAbilityAction <.cctor>b__27_0();
                    }
                }

                class ExplodeAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.ExplosionLocationType location_;
                    /*0x20*/ string visualTag_;
                    /*0x28*/ int targetPatternId_;
                    /*0x2c*/ bool noCascadePointsIfKill_;
                    /*0x30*/ string deathPresentationTag_;

                    static /*0x41a9e40*/ ExplodeAction();
                    static /*0x41a9380*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction> get_Parser();
                    static /*0x41a93d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41a94f4*/ ExplodeAction();
                    /*0x41a955c*/ ExplodeAction(YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction other);
                    /*0x41a94a8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41a95d4*/ YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction Clone();
                    /*0x41a962c*/ Yeti.Data.ExplosionLocationType get_Location();
                    /*0x41a9634*/ void set_Location(Yeti.Data.ExplosionLocationType value);
                    /*0x41a963c*/ string get_VisualTag();
                    /*0x41a9644*/ void set_VisualTag(string value);
                    /*0x41a96c0*/ int get_TargetPatternId();
                    /*0x41a96c8*/ void set_TargetPatternId(int value);
                    /*0x41a96d0*/ bool get_NoCascadePointsIfKill();
                    /*0x41a96d8*/ void set_NoCascadePointsIfKill(bool value);
                    /*0x41a96e0*/ string get_DeathPresentationTag();
                    /*0x41a96e8*/ void set_DeathPresentationTag(string value);
                    /*0x41a9764*/ bool Equals(object other);
                    /*0x41a97c8*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction other);
                    /*0x41a987c*/ int GetHashCode();
                    /*0x41a9978*/ string ToString();
                    /*0x41a99d0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41a99f0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41a9b04*/ int CalculateSize();
                    /*0x41a9c3c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction other);
                    /*0x41a9ce0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41a9d00*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction.<> <>9;

                        static /*0x41a9f58*/ <>c();
                        /*0x41a9fc0*/ <>c();
                        /*0x41a9fc8*/ YetiSimCoreLib.Components.PayloadAction.Types.ExplodeAction <.cctor>b__47_0();
                    }
                }

                class DestroySelfAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41aa458*/ DestroySelfAction();
                    static /*0x41aa018*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction> get_Parser();
                    static /*0x41aa070*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41aa18c*/ DestroySelfAction();
                    /*0x41aa194*/ DestroySelfAction(YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction other);
                    /*0x41aa140*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41aa1d8*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction Clone();
                    /*0x41aa230*/ bool Equals(object other);
                    /*0x41aa2b4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction other);
                    /*0x41aa2e0*/ int GetHashCode();
                    /*0x41aa30c*/ string ToString();
                    /*0x41aa364*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41aa384*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41aa398*/ int CalculateSize();
                    /*0x41aa3ac*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction other);
                    /*0x41aa3e0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41aa400*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction.<> <>9;

                        static /*0x41aa570*/ <>c();
                        /*0x41aa5d8*/ <>c();
                        /*0x41aa5e0*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroySelfAction <.cctor>b__22_0();
                    }
                }

                class ChangeStateAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41aaa74*/ ChangeStateAction();
                    static /*0x41aa634*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction> get_Parser();
                    static /*0x41aa68c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41aa7a8*/ ChangeStateAction();
                    /*0x41aa7b0*/ ChangeStateAction(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction other);
                    /*0x41aa75c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41aa7f4*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction Clone();
                    /*0x41aa84c*/ bool Equals(object other);
                    /*0x41aa8d0*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction other);
                    /*0x41aa8fc*/ int GetHashCode();
                    /*0x41aa928*/ string ToString();
                    /*0x41aa980*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41aa9a0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41aa9b4*/ int CalculateSize();
                    /*0x41aa9c8*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction other);
                    /*0x41aa9fc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41aaa1c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction.<> <>9;

                        static /*0x41aab8c*/ <>c();
                        /*0x41aabf4*/ <>c();
                        /*0x41aabfc*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStateAction <.cctor>b__22_0();
                    }
                }

                class AddArmorAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool stopsDamage_;

                    static /*0x41ab184*/ AddArmorAction();
                    static /*0x41aac50*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction> get_Parser();
                    static /*0x41aaca8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41aadc4*/ AddArmorAction();
                    /*0x41aadcc*/ AddArmorAction(YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction other);
                    /*0x41aad78*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41aae18*/ YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction Clone();
                    /*0x41aae70*/ bool get_StopsDamage();
                    /*0x41aae78*/ void set_StopsDamage(bool value);
                    /*0x41aae80*/ bool Equals(object other);
                    /*0x41aaee4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction other);
                    /*0x41aaf30*/ int GetHashCode();
                    /*0x41aafa0*/ string ToString();
                    /*0x41aaff8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41ab018*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41ab078*/ int CalculateSize();
                    /*0x41ab0a4*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction other);
                    /*0x41ab0e8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41ab108*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction.<> <>9;

                        static /*0x41ab29c*/ <>c();
                        /*0x41ab304*/ <>c();
                        /*0x41ab30c*/ YetiSimCoreLib.Components.PayloadAction.Types.AddArmorAction <.cctor>b__27_0();
                    }
                }

                class AutoArmAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41ab7a0*/ AutoArmAction();
                    static /*0x41ab360*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction> get_Parser();
                    static /*0x41ab3b8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41ab4d4*/ AutoArmAction();
                    /*0x41ab4dc*/ AutoArmAction(YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction other);
                    /*0x41ab488*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41ab520*/ YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction Clone();
                    /*0x41ab578*/ bool Equals(object other);
                    /*0x41ab5fc*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction other);
                    /*0x41ab628*/ int GetHashCode();
                    /*0x41ab654*/ string ToString();
                    /*0x41ab6ac*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41ab6cc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41ab6e0*/ int CalculateSize();
                    /*0x41ab6f4*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction other);
                    /*0x41ab728*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41ab748*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction.<> <>9;

                        static /*0x41ab8b8*/ <>c();
                        /*0x41ab920*/ <>c();
                        /*0x41ab928*/ YetiSimCoreLib.Components.PayloadAction.Types.AutoArmAction <.cctor>b__22_0();
                    }
                }

                class HealAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.HealAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.HealAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.HealAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.HealAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41abdbc*/ HealAction();
                    static /*0x41ab97c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.HealAction> get_Parser();
                    static /*0x41ab9d4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41abaf0*/ HealAction();
                    /*0x41abaf8*/ HealAction(YetiSimCoreLib.Components.PayloadAction.Types.HealAction other);
                    /*0x41abaa4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41abb3c*/ YetiSimCoreLib.Components.PayloadAction.Types.HealAction Clone();
                    /*0x41abb94*/ bool Equals(object other);
                    /*0x41abc18*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.HealAction other);
                    /*0x41abc44*/ int GetHashCode();
                    /*0x41abc70*/ string ToString();
                    /*0x41abcc8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41abce8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41abcfc*/ int CalculateSize();
                    /*0x41abd10*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.HealAction other);
                    /*0x41abd44*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41abd64*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.HealAction.<> <>9;

                        static /*0x41abed4*/ <>c();
                        /*0x41abf3c*/ <>c();
                        /*0x41abf44*/ YetiSimCoreLib.Components.PayloadAction.Types.HealAction <.cctor>b__22_0();
                    }
                }

                class SpawnUnitAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction> _parser;
                    static /*0x8*/ Google.Protobuf.Collections.MapField.Codec<int, int> _map_runtimeStatOverrides_codec;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int unitId_;
                    /*0x1c*/ bool isPromoted_;
                    /*0x20*/ int numUnits_;
                    /*0x24*/ int initialSpawnDelay_;
                    /*0x28*/ int spawnDelayBetweenUnits_;
                    /*0x2c*/ bool hasRandomSpawnOffset_;
                    /*0x2d*/ bool cloneSelf_;
                    /*0x30*/ int plantFoodLevel_;
                    /*0x34*/ int promotionLevel_;
                    /*0x38*/ bool spawnAtExactXPosition_;
                    /*0x3c*/ int xPosition_;
                    /*0x40*/ int minNumUnits_;
                    /*0x44*/ int maxNumUnits_;
                    /*0x48*/ int minInitialSpawnDelay_;
                    /*0x4c*/ int maxInitialSpawnDelay_;
                    /*0x50*/ int placementOffsetX_;
                    /*0x54*/ bool attachFirstUnit_;
                    /*0x55*/ bool stayAttachedWhenBounced_;
                    /*0x56*/ bool spawnedUnitsGenerateNoScore_;
                    /*0x57*/ bool copyPrefabOrAltChoiceOfTarget_;
                    /*0x58*/ bool copyBounceOfTarget_;
                    /*0x59*/ bool copyOrientationOfTarget_;
                    /*0x5a*/ bool spawnedUnitsIneligibleForCoins_;
                    /*0x5b*/ bool spawnedUnitsIneligibleForCascade_;
                    /*0x5c*/ bool spawnedUnitsIneligibleForLeaderboard_;
                    /*0x5d*/ bool linkAsChild_;
                    /*0x60*/ Google.Protobuf.Collections.MapField<int, int> runtimeStatOverrides_;
                    /*0x68*/ int unitLevel_;

                    static /*0x41add60*/ SpawnUnitAction();
                    static /*0x41abf98*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction> get_Parser();
                    static /*0x41abff0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41ac10c*/ SpawnUnitAction();
                    /*0x41ac194*/ SpawnUnitAction(YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction other);
                    /*0x41ac0c0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41ac280*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction Clone();
                    /*0x41ac2d8*/ int get_UnitId();
                    /*0x41ac2e0*/ void set_UnitId(int value);
                    /*0x41ac2e8*/ bool get_IsPromoted();
                    /*0x41ac2f0*/ void set_IsPromoted(bool value);
                    /*0x41ac2f8*/ int get_NumUnits();
                    /*0x41ac300*/ void set_NumUnits(int value);
                    /*0x41ac308*/ int get_InitialSpawnDelay();
                    /*0x41ac310*/ void set_InitialSpawnDelay(int value);
                    /*0x41ac318*/ int get_SpawnDelayBetweenUnits();
                    /*0x41ac320*/ void set_SpawnDelayBetweenUnits(int value);
                    /*0x41ac328*/ bool get_HasRandomSpawnOffset();
                    /*0x41ac330*/ void set_HasRandomSpawnOffset(bool value);
                    /*0x41ac338*/ bool get_CloneSelf();
                    /*0x41ac340*/ void set_CloneSelf(bool value);
                    /*0x41ac348*/ int get_PlantFoodLevel();
                    /*0x41ac350*/ void set_PlantFoodLevel(int value);
                    /*0x41ac358*/ int get_PromotionLevel();
                    /*0x41ac360*/ void set_PromotionLevel(int value);
                    /*0x41ac368*/ bool get_SpawnAtExactXPosition();
                    /*0x41ac370*/ void set_SpawnAtExactXPosition(bool value);
                    /*0x41ac378*/ int get_XPosition();
                    /*0x41ac380*/ void set_XPosition(int value);
                    /*0x41ac388*/ int get_MinNumUnits();
                    /*0x41ac390*/ void set_MinNumUnits(int value);
                    /*0x41ac398*/ int get_MaxNumUnits();
                    /*0x41ac3a0*/ void set_MaxNumUnits(int value);
                    /*0x41ac3a8*/ int get_MinInitialSpawnDelay();
                    /*0x41ac3b0*/ void set_MinInitialSpawnDelay(int value);
                    /*0x41ac3b8*/ int get_MaxInitialSpawnDelay();
                    /*0x41ac3c0*/ void set_MaxInitialSpawnDelay(int value);
                    /*0x41ac3c8*/ int get_PlacementOffsetX();
                    /*0x41ac3d0*/ void set_PlacementOffsetX(int value);
                    /*0x41ac3d8*/ bool get_AttachFirstUnit();
                    /*0x41ac3e0*/ void set_AttachFirstUnit(bool value);
                    /*0x41ac3e8*/ bool get_StayAttachedWhenBounced();
                    /*0x41ac3f0*/ void set_StayAttachedWhenBounced(bool value);
                    /*0x41ac3f8*/ bool get_SpawnedUnitsGenerateNoScore();
                    /*0x41ac400*/ void set_SpawnedUnitsGenerateNoScore(bool value);
                    /*0x41ac408*/ bool get_CopyPrefabOrAltChoiceOfTarget();
                    /*0x41ac410*/ void set_CopyPrefabOrAltChoiceOfTarget(bool value);
                    /*0x41ac418*/ bool get_CopyBounceOfTarget();
                    /*0x41ac420*/ void set_CopyBounceOfTarget(bool value);
                    /*0x41ac428*/ bool get_CopyOrientationOfTarget();
                    /*0x41ac430*/ void set_CopyOrientationOfTarget(bool value);
                    /*0x41ac438*/ bool get_SpawnedUnitsIneligibleForCoins();
                    /*0x41ac440*/ void set_SpawnedUnitsIneligibleForCoins(bool value);
                    /*0x41ac448*/ bool get_SpawnedUnitsIneligibleForCascade();
                    /*0x41ac450*/ void set_SpawnedUnitsIneligibleForCascade(bool value);
                    /*0x41ac458*/ bool get_SpawnedUnitsIneligibleForLeaderboard();
                    /*0x41ac460*/ void set_SpawnedUnitsIneligibleForLeaderboard(bool value);
                    /*0x41ac468*/ bool get_LinkAsChild();
                    /*0x41ac470*/ void set_LinkAsChild(bool value);
                    /*0x41ac478*/ Google.Protobuf.Collections.MapField<int, int> get_RuntimeStatOverrides();
                    /*0x41ac480*/ int get_UnitLevel();
                    /*0x41ac488*/ void set_UnitLevel(int value);
                    /*0x41ac490*/ bool Equals(object other);
                    /*0x41ac4f4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction other);
                    /*0x41ac814*/ int GetHashCode();
                    /*0x41acc90*/ string ToString();
                    /*0x41acce8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41acd08*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41ad22c*/ int CalculateSize();
                    /*0x41ad614*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction other);
                    /*0x41ad818*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41ad838*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction.<> <>9;

                        static /*0x41adf08*/ <>c();
                        /*0x41adf70*/ <>c();
                        /*0x41adf78*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnUnitAction <.cctor>b__162_0();
                    }
                }

                class HealArmorAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41ae408*/ HealArmorAction();
                    static /*0x41adfc8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction> get_Parser();
                    static /*0x41ae020*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41ae13c*/ HealArmorAction();
                    /*0x41ae144*/ HealArmorAction(YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction other);
                    /*0x41ae0f0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41ae188*/ YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction Clone();
                    /*0x41ae1e0*/ bool Equals(object other);
                    /*0x41ae264*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction other);
                    /*0x41ae290*/ int GetHashCode();
                    /*0x41ae2bc*/ string ToString();
                    /*0x41ae314*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41ae334*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41ae348*/ int CalculateSize();
                    /*0x41ae35c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction other);
                    /*0x41ae390*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41ae3b0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction.<> <>9;

                        static /*0x41ae520*/ <>c();
                        /*0x41ae588*/ <>c();
                        /*0x41ae590*/ YetiSimCoreLib.Components.PayloadAction.Types.HealArmorAction <.cctor>b__22_0();
                    }
                }

                class UnarmSelfAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int armTimeInTicks_;

                    static /*0x41aeb3c*/ UnarmSelfAction();
                    static /*0x41ae5e4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction> get_Parser();
                    static /*0x41ae63c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41ae758*/ UnarmSelfAction();
                    /*0x41ae760*/ UnarmSelfAction(YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction other);
                    /*0x41ae70c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41ae7ac*/ YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction Clone();
                    /*0x41ae804*/ int get_ArmTimeInTicks();
                    /*0x41ae80c*/ void set_ArmTimeInTicks(int value);
                    /*0x41ae814*/ bool Equals(object other);
                    /*0x41ae878*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction other);
                    /*0x41ae8b4*/ int GetHashCode();
                    /*0x41ae910*/ string ToString();
                    /*0x41ae968*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41ae988*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41ae9e8*/ int CalculateSize();
                    /*0x41aea68*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction other);
                    /*0x41aeaa8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41aeac8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction.<> <>9;

                        static /*0x41aec54*/ <>c();
                        /*0x41aecbc*/ <>c();
                        /*0x41aecc4*/ YetiSimCoreLib.Components.PayloadAction.Types.UnarmSelfAction <.cctor>b__27_0();
                    }
                }

                class PushAwayFromLaneAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.PushAwayFromLaneType movementType_;
                    /*0x1c*/ bool failIfCantMoveToLane_;

                    static /*0x41af35c*/ PushAwayFromLaneAction();
                    static /*0x41aed18*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction> get_Parser();
                    static /*0x41aed70*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41aee8c*/ PushAwayFromLaneAction();
                    /*0x41aee94*/ PushAwayFromLaneAction(YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction other);
                    /*0x41aee40*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41aeee8*/ YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction Clone();
                    /*0x41aef40*/ Yeti.Data.PushAwayFromLaneType get_MovementType();
                    /*0x41aef48*/ void set_MovementType(Yeti.Data.PushAwayFromLaneType value);
                    /*0x41aef50*/ bool get_FailIfCantMoveToLane();
                    /*0x41aef58*/ void set_FailIfCantMoveToLane(bool value);
                    /*0x41aef60*/ bool Equals(object other);
                    /*0x41aefc4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction other);
                    /*0x41af020*/ int GetHashCode();
                    /*0x41af0b8*/ string ToString();
                    /*0x41af110*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41af130*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41af1b8*/ int CalculateSize();
                    /*0x41af250*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction other);
                    /*0x41af2a0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41af2c0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction.<> <>9;

                        static /*0x41af474*/ <>c();
                        /*0x41af4dc*/ <>c();
                        /*0x41af4e4*/ YetiSimCoreLib.Components.PayloadAction.Types.PushAwayFromLaneAction <.cctor>b__32_0();
                    }
                }

                class PullTowardLaneAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int pullTowardPositionZ_;
                    /*0x1c*/ bool pullToLaneInOneGo_;
                    /*0x20*/ int overridePullLaneSpeedZ_;

                    static /*0x41afc50*/ PullTowardLaneAction();
                    static /*0x41af538*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction> get_Parser();
                    static /*0x41af590*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41af6ac*/ PullTowardLaneAction();
                    /*0x41af6b4*/ PullTowardLaneAction(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction other);
                    /*0x41af660*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41af710*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction Clone();
                    /*0x41af768*/ int get_PullTowardPositionZ();
                    /*0x41af770*/ void set_PullTowardPositionZ(int value);
                    /*0x41af778*/ bool get_PullToLaneInOneGo();
                    /*0x41af780*/ void set_PullToLaneInOneGo(bool value);
                    /*0x41af788*/ int get_OverridePullLaneSpeedZ();
                    /*0x41af790*/ void set_OverridePullLaneSpeedZ(int value);
                    /*0x41af798*/ bool Equals(object other);
                    /*0x41af7fc*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction other);
                    /*0x41af868*/ int GetHashCode();
                    /*0x41af91c*/ string ToString();
                    /*0x41af974*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41af994*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41afa44*/ int CalculateSize();
                    /*0x41afb10*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction other);
                    /*0x41afb6c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41afb8c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction.<> <>9;

                        static /*0x41afd68*/ <>c();
                        /*0x41afdd0*/ <>c();
                        /*0x41afdd8*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardLaneAction <.cctor>b__37_0();
                    }
                }

                class ModifySunAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool isFromSky_;
                    /*0x1c*/ int spawnOverMsMin_;
                    /*0x20*/ int spawnOverMsMax_;

                    static /*0x41b0528*/ ModifySunAction();
                    static /*0x41afe2c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction> get_Parser();
                    static /*0x41afe84*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41affa0*/ ModifySunAction();
                    /*0x41affa8*/ ModifySunAction(YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction other);
                    /*0x41aff54*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41afffc*/ YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction Clone();
                    /*0x41b0054*/ bool get_IsFromSky();
                    /*0x41b005c*/ void set_IsFromSky(bool value);
                    /*0x41b0064*/ int get_SpawnOverMsMin();
                    /*0x41b006c*/ void set_SpawnOverMsMin(int value);
                    /*0x41b0074*/ int get_SpawnOverMsMax();
                    /*0x41b007c*/ void set_SpawnOverMsMax(int value);
                    /*0x41b0084*/ bool Equals(object other);
                    /*0x41b00e8*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction other);
                    /*0x41b0154*/ int GetHashCode();
                    /*0x41b0200*/ string ToString();
                    /*0x41b0258*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b0278*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b0328*/ int CalculateSize();
                    /*0x41b03e8*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction other);
                    /*0x41b0444*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b0464*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction.<> <>9;

                        static /*0x41b0640*/ <>c();
                        /*0x41b06a8*/ <>c();
                        /*0x41b06b0*/ YetiSimCoreLib.Components.PayloadAction.Types.ModifySunAction <.cctor>b__37_0();
                    }
                }

                class RemoveStatAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.StatType stat_;

                    static /*0x41b0c5c*/ RemoveStatAction();
                    static /*0x41b0704*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction> get_Parser();
                    static /*0x41b075c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b0878*/ RemoveStatAction();
                    /*0x41b0880*/ RemoveStatAction(YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction other);
                    /*0x41b082c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b08cc*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction Clone();
                    /*0x41b0924*/ Yeti.Data.StatType get_Stat();
                    /*0x41b092c*/ void set_Stat(Yeti.Data.StatType value);
                    /*0x41b0934*/ bool Equals(object other);
                    /*0x41b0998*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction other);
                    /*0x41b09d4*/ int GetHashCode();
                    /*0x41b0a30*/ string ToString();
                    /*0x41b0a88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b0aa8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b0b08*/ int CalculateSize();
                    /*0x41b0b88*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction other);
                    /*0x41b0bc8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b0be8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction.<> <>9;

                        static /*0x41b0d74*/ <>c();
                        /*0x41b0ddc*/ <>c();
                        /*0x41b0de4*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveStatAction <.cctor>b__27_0();
                    }
                }

                class HealOrAddArmorAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool stopsDamage_;

                    static /*0x41b136c*/ HealOrAddArmorAction();
                    static /*0x41b0e38*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction> get_Parser();
                    static /*0x41b0e90*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b0fac*/ HealOrAddArmorAction();
                    /*0x41b0fb4*/ HealOrAddArmorAction(YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction other);
                    /*0x41b0f60*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b1000*/ YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction Clone();
                    /*0x41b1058*/ bool get_StopsDamage();
                    /*0x41b1060*/ void set_StopsDamage(bool value);
                    /*0x41b1068*/ bool Equals(object other);
                    /*0x41b10cc*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction other);
                    /*0x41b1118*/ int GetHashCode();
                    /*0x41b1188*/ string ToString();
                    /*0x41b11e0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b1200*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b1260*/ int CalculateSize();
                    /*0x41b128c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction other);
                    /*0x41b12d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b12f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction.<> <>9;

                        static /*0x41b1484*/ <>c();
                        /*0x41b14ec*/ <>c();
                        /*0x41b14f4*/ YetiSimCoreLib.Components.PayloadAction.Types.HealOrAddArmorAction <.cctor>b__27_0();
                    }
                }

                class MoveToRandomLaneAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int speedInCentigridsPerSec_;

                    static /*0x41b1aa0*/ MoveToRandomLaneAction();
                    static /*0x41b1548*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction> get_Parser();
                    static /*0x41b15a0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b16bc*/ MoveToRandomLaneAction();
                    /*0x41b16c4*/ MoveToRandomLaneAction(YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction other);
                    /*0x41b1670*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b1710*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction Clone();
                    /*0x41b1768*/ int get_SpeedInCentigridsPerSec();
                    /*0x41b1770*/ void set_SpeedInCentigridsPerSec(int value);
                    /*0x41b1778*/ bool Equals(object other);
                    /*0x41b17dc*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction other);
                    /*0x41b1818*/ int GetHashCode();
                    /*0x41b1874*/ string ToString();
                    /*0x41b18cc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b18ec*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b194c*/ int CalculateSize();
                    /*0x41b19cc*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction other);
                    /*0x41b1a0c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b1a2c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction.<> <>9;

                        static /*0x41b1bb8*/ <>c();
                        /*0x41b1c20*/ <>c();
                        /*0x41b1c28*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveToRandomLaneAction <.cctor>b__27_0();
                    }
                }

                class AddTagAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int tag_;

                    static /*0x41b21d4*/ AddTagAction();
                    static /*0x41b1c7c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction> get_Parser();
                    static /*0x41b1cd4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b1df0*/ AddTagAction();
                    /*0x41b1df8*/ AddTagAction(YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction other);
                    /*0x41b1da4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b1e44*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction Clone();
                    /*0x41b1e9c*/ int get_Tag();
                    /*0x41b1ea4*/ void set_Tag(int value);
                    /*0x41b1eac*/ bool Equals(object other);
                    /*0x41b1f10*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction other);
                    /*0x41b1f4c*/ int GetHashCode();
                    /*0x41b1fa8*/ string ToString();
                    /*0x41b2000*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b2020*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b2080*/ int CalculateSize();
                    /*0x41b2100*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction other);
                    /*0x41b2140*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b2160*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction.<> <>9;

                        static /*0x41b22ec*/ <>c();
                        /*0x41b2354*/ <>c();
                        /*0x41b235c*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTagAction <.cctor>b__27_0();
                    }
                }

                class RemoveTagAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int tag_;

                    static /*0x41b2908*/ RemoveTagAction();
                    static /*0x41b23b0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction> get_Parser();
                    static /*0x41b2408*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b2524*/ RemoveTagAction();
                    /*0x41b252c*/ RemoveTagAction(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction other);
                    /*0x41b24d8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b2578*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction Clone();
                    /*0x41b25d0*/ int get_Tag();
                    /*0x41b25d8*/ void set_Tag(int value);
                    /*0x41b25e0*/ bool Equals(object other);
                    /*0x41b2644*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction other);
                    /*0x41b2680*/ int GetHashCode();
                    /*0x41b26dc*/ string ToString();
                    /*0x41b2734*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b2754*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b27b4*/ int CalculateSize();
                    /*0x41b2834*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction other);
                    /*0x41b2874*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b2894*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction.<> <>9;

                        static /*0x41b2a20*/ <>c();
                        /*0x41b2a88*/ <>c();
                        /*0x41b2a90*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTagAction <.cctor>b__27_0();
                    }
                }

                class AddTargetingImmunityAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int tag_;

                    static /*0x41b303c*/ AddTargetingImmunityAction();
                    static /*0x41b2ae4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction> get_Parser();
                    static /*0x41b2b3c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b2c58*/ AddTargetingImmunityAction();
                    /*0x41b2c60*/ AddTargetingImmunityAction(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction other);
                    /*0x41b2c0c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b2cac*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction Clone();
                    /*0x41b2d04*/ int get_Tag();
                    /*0x41b2d0c*/ void set_Tag(int value);
                    /*0x41b2d14*/ bool Equals(object other);
                    /*0x41b2d78*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction other);
                    /*0x41b2db4*/ int GetHashCode();
                    /*0x41b2e10*/ string ToString();
                    /*0x41b2e68*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b2e88*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b2ee8*/ int CalculateSize();
                    /*0x41b2f68*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction other);
                    /*0x41b2fa8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b2fc8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction.<> <>9;

                        static /*0x41b3154*/ <>c();
                        /*0x41b31bc*/ <>c();
                        /*0x41b31c4*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingImmunityAction <.cctor>b__27_0();
                    }
                }

                class RemoveTargetingImmunityAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int tag_;

                    static /*0x41b3770*/ RemoveTargetingImmunityAction();
                    static /*0x41b3218*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction> get_Parser();
                    static /*0x41b3270*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b338c*/ RemoveTargetingImmunityAction();
                    /*0x41b3394*/ RemoveTargetingImmunityAction(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction other);
                    /*0x41b3340*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b33e0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction Clone();
                    /*0x41b3438*/ int get_Tag();
                    /*0x41b3440*/ void set_Tag(int value);
                    /*0x41b3448*/ bool Equals(object other);
                    /*0x41b34ac*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction other);
                    /*0x41b34e8*/ int GetHashCode();
                    /*0x41b3544*/ string ToString();
                    /*0x41b359c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b35bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b361c*/ int CalculateSize();
                    /*0x41b369c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction other);
                    /*0x41b36dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b36fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction.<> <>9;

                        static /*0x41b3888*/ <>c();
                        /*0x41b38f0*/ <>c();
                        /*0x41b38f8*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingImmunityAction <.cctor>b__27_0();
                    }
                }

                class AddTargetingRequirementAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int tag_;

                    static /*0x41b3ea4*/ AddTargetingRequirementAction();
                    static /*0x41b394c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction> get_Parser();
                    static /*0x41b39a4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b3ac0*/ AddTargetingRequirementAction();
                    /*0x41b3ac8*/ AddTargetingRequirementAction(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction other);
                    /*0x41b3a74*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b3b14*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction Clone();
                    /*0x41b3b6c*/ int get_Tag();
                    /*0x41b3b74*/ void set_Tag(int value);
                    /*0x41b3b7c*/ bool Equals(object other);
                    /*0x41b3be0*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction other);
                    /*0x41b3c1c*/ int GetHashCode();
                    /*0x41b3c78*/ string ToString();
                    /*0x41b3cd0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b3cf0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b3d50*/ int CalculateSize();
                    /*0x41b3dd0*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction other);
                    /*0x41b3e10*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b3e30*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction.<> <>9;

                        static /*0x41b3fbc*/ <>c();
                        /*0x41b4024*/ <>c();
                        /*0x41b402c*/ YetiSimCoreLib.Components.PayloadAction.Types.AddTargetingRequirementAction <.cctor>b__27_0();
                    }
                }

                class RemoveTargetingRequirementAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int tag_;

                    static /*0x41b45d8*/ RemoveTargetingRequirementAction();
                    static /*0x41b4080*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction> get_Parser();
                    static /*0x41b40d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b41f4*/ RemoveTargetingRequirementAction();
                    /*0x41b41fc*/ RemoveTargetingRequirementAction(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction other);
                    /*0x41b41a8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b4248*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction Clone();
                    /*0x41b42a0*/ int get_Tag();
                    /*0x41b42a8*/ void set_Tag(int value);
                    /*0x41b42b0*/ bool Equals(object other);
                    /*0x41b4314*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction other);
                    /*0x41b4350*/ int GetHashCode();
                    /*0x41b43ac*/ string ToString();
                    /*0x41b4404*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b4424*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b4484*/ int CalculateSize();
                    /*0x41b4504*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction other);
                    /*0x41b4544*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b4564*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction.<> <>9;

                        static /*0x41b46f0*/ <>c();
                        /*0x41b4758*/ <>c();
                        /*0x41b4760*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveTargetingRequirementAction <.cctor>b__27_0();
                    }
                }

                class PullTowardSelfAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int targetX_;

                    static /*0x41b4d0c*/ PullTowardSelfAction();
                    static /*0x41b47b4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction> get_Parser();
                    static /*0x41b480c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b4928*/ PullTowardSelfAction();
                    /*0x41b4930*/ PullTowardSelfAction(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction other);
                    /*0x41b48dc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b497c*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction Clone();
                    /*0x41b49d4*/ int get_TargetX();
                    /*0x41b49dc*/ void set_TargetX(int value);
                    /*0x41b49e4*/ bool Equals(object other);
                    /*0x41b4a48*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction other);
                    /*0x41b4a84*/ int GetHashCode();
                    /*0x41b4ae0*/ string ToString();
                    /*0x41b4b38*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b4b58*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b4bb8*/ int CalculateSize();
                    /*0x41b4c38*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction other);
                    /*0x41b4c78*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b4c98*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction.<> <>9;

                        static /*0x41b4e24*/ <>c();
                        /*0x41b4e8c*/ <>c();
                        /*0x41b4e94*/ YetiSimCoreLib.Components.PayloadAction.Types.PullTowardSelfAction <.cctor>b__27_0();
                    }
                }

                class TransformAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.TransformAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.TransformAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.TransformAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.TransformAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int transformationId_;
                    /*0x1c*/ bool onlyChangeAnimationState_;

                    static /*0x41b552c*/ TransformAction();
                    static /*0x41b4ee8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.TransformAction> get_Parser();
                    static /*0x41b4f40*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b505c*/ TransformAction();
                    /*0x41b5064*/ TransformAction(YetiSimCoreLib.Components.PayloadAction.Types.TransformAction other);
                    /*0x41b5010*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b50b8*/ YetiSimCoreLib.Components.PayloadAction.Types.TransformAction Clone();
                    /*0x41b5110*/ int get_TransformationId();
                    /*0x41b5118*/ void set_TransformationId(int value);
                    /*0x41b5120*/ bool get_OnlyChangeAnimationState();
                    /*0x41b5128*/ void set_OnlyChangeAnimationState(bool value);
                    /*0x41b5130*/ bool Equals(object other);
                    /*0x41b5194*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.TransformAction other);
                    /*0x41b51f0*/ int GetHashCode();
                    /*0x41b5288*/ string ToString();
                    /*0x41b52e0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b5300*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b5388*/ int CalculateSize();
                    /*0x41b5420*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.TransformAction other);
                    /*0x41b5470*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b5490*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.TransformAction.<> <>9;

                        static /*0x41b5644*/ <>c();
                        /*0x41b56ac*/ <>c();
                        /*0x41b56b4*/ YetiSimCoreLib.Components.PayloadAction.Types.TransformAction <.cctor>b__32_0();
                    }
                }

                class ChangeMovementDirectionAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.DirectionType direction_;
                    /*0x1c*/ bool flipDirection_;
                    /*0x1d*/ bool queueFlipUntilNextAnimation_;

                    static /*0x41b5e2c*/ ChangeMovementDirectionAction();
                    static /*0x41b5708*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction> get_Parser();
                    static /*0x41b5760*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b587c*/ ChangeMovementDirectionAction();
                    /*0x41b5884*/ ChangeMovementDirectionAction(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction other);
                    /*0x41b5830*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b58d8*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction Clone();
                    /*0x41b5930*/ Yeti.Data.DirectionType get_Direction();
                    /*0x41b5938*/ void set_Direction(Yeti.Data.DirectionType value);
                    /*0x41b5940*/ bool get_FlipDirection();
                    /*0x41b5948*/ void set_FlipDirection(bool value);
                    /*0x41b5950*/ bool get_QueueFlipUntilNextAnimation();
                    /*0x41b5958*/ void set_QueueFlipUntilNextAnimation(bool value);
                    /*0x41b5960*/ bool Equals(object other);
                    /*0x41b59c4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction other);
                    /*0x41b5a40*/ int GetHashCode();
                    /*0x41b5b10*/ string ToString();
                    /*0x41b5b68*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b5b88*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b5c38*/ int CalculateSize();
                    /*0x41b5ce0*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction other);
                    /*0x41b5d40*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b5d60*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction.<> <>9;

                        static /*0x41b5f44*/ <>c();
                        /*0x41b5fac*/ <>c();
                        /*0x41b5fb4*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementDirectionAction <.cctor>b__37_0();
                    }
                }

                class ChangeStatBaseValueAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.StatType statType_;
                    /*0x1c*/ int value_;

                    static /*0x41b6624*/ ChangeStatBaseValueAction();
                    static /*0x41b6008*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction> get_Parser();
                    static /*0x41b6060*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b617c*/ ChangeStatBaseValueAction();
                    /*0x41b6184*/ ChangeStatBaseValueAction(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction other);
                    /*0x41b6130*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b61d0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction Clone();
                    /*0x41b6228*/ Yeti.Data.StatType get_StatType();
                    /*0x41b6230*/ void set_StatType(Yeti.Data.StatType value);
                    /*0x41b6238*/ int get_Value();
                    /*0x41b6240*/ void set_Value(int value);
                    /*0x41b6248*/ bool Equals(object other);
                    /*0x41b62ac*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction other);
                    /*0x41b62f8*/ int GetHashCode();
                    /*0x41b6370*/ string ToString();
                    /*0x41b63c8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b63e8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b6470*/ int CalculateSize();
                    /*0x41b6524*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction other);
                    /*0x41b6570*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b6590*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction.<> <>9;

                        static /*0x41b673c*/ <>c();
                        /*0x41b67a4*/ <>c();
                        /*0x41b67ac*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeStatBaseValueAction <.cctor>b__32_0();
                    }
                }

                class BounceAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.BounceAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.BounceAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.BounceAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.BounceAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int timeInTicks_;
                    /*0x1c*/ int maxHeight_;
                    /*0x20*/ bool keepPlayingUnitAnimation_;
                    /*0x21*/ bool displacementIsRelativeToOrientation_;
                    /*0x22*/ bool canPushNonCellOccupierOffBoard_;

                    static /*0x41b70c4*/ BounceAction();
                    static /*0x41b6800*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.BounceAction> get_Parser();
                    static /*0x41b6858*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b6974*/ BounceAction();
                    /*0x41b697c*/ BounceAction(YetiSimCoreLib.Components.PayloadAction.Types.BounceAction other);
                    /*0x41b6928*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b69d8*/ YetiSimCoreLib.Components.PayloadAction.Types.BounceAction Clone();
                    /*0x41b6a30*/ int get_TimeInTicks();
                    /*0x41b6a38*/ void set_TimeInTicks(int value);
                    /*0x41b6a40*/ int get_MaxHeight();
                    /*0x41b6a48*/ void set_MaxHeight(int value);
                    /*0x41b6a50*/ bool get_KeepPlayingUnitAnimation();
                    /*0x41b6a58*/ void set_KeepPlayingUnitAnimation(bool value);
                    /*0x41b6a60*/ bool get_DisplacementIsRelativeToOrientation();
                    /*0x41b6a68*/ void set_DisplacementIsRelativeToOrientation(bool value);
                    /*0x41b6a70*/ bool get_CanPushNonCellOccupierOffBoard();
                    /*0x41b6a78*/ void set_CanPushNonCellOccupierOffBoard(bool value);
                    /*0x41b6a80*/ bool Equals(object other);
                    /*0x41b6ae4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.BounceAction other);
                    /*0x41b6b90*/ int GetHashCode();
                    /*0x41b6cac*/ string ToString();
                    /*0x41b6d04*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b6d24*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b6e24*/ int CalculateSize();
                    /*0x41b6f10*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.BounceAction other);
                    /*0x41b6f8c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b6fac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.BounceAction.<> <>9;

                        static /*0x41b71dc*/ <>c();
                        /*0x41b7244*/ <>c();
                        /*0x41b724c*/ YetiSimCoreLib.Components.PayloadAction.Types.BounceAction <.cctor>b__47_0();
                    }
                }

                class DeflectConsumedProjectileAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41b76e0*/ DeflectConsumedProjectileAction();
                    static /*0x41b72a0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction> get_Parser();
                    static /*0x41b72f8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b7414*/ DeflectConsumedProjectileAction();
                    /*0x41b741c*/ DeflectConsumedProjectileAction(YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction other);
                    /*0x41b73c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b7460*/ YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction Clone();
                    /*0x41b74b8*/ bool Equals(object other);
                    /*0x41b753c*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction other);
                    /*0x41b7568*/ int GetHashCode();
                    /*0x41b7594*/ string ToString();
                    /*0x41b75ec*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b760c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b7620*/ int CalculateSize();
                    /*0x41b7634*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction other);
                    /*0x41b7668*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b7688*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction.<> <>9;

                        static /*0x41b77f8*/ <>c();
                        /*0x41b7860*/ <>c();
                        /*0x41b7868*/ YetiSimCoreLib.Components.PayloadAction.Types.DeflectConsumedProjectileAction <.cctor>b__22_0();
                    }
                }

                class ChangeBehaviorStateAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int behaviorId_;

                    static /*0x41b7e14*/ ChangeBehaviorStateAction();
                    static /*0x41b78bc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction> get_Parser();
                    static /*0x41b7914*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b7a30*/ ChangeBehaviorStateAction();
                    /*0x41b7a38*/ ChangeBehaviorStateAction(YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction other);
                    /*0x41b79e4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b7a84*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction Clone();
                    /*0x41b7adc*/ int get_BehaviorId();
                    /*0x41b7ae4*/ void set_BehaviorId(int value);
                    /*0x41b7aec*/ bool Equals(object other);
                    /*0x41b7b50*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction other);
                    /*0x41b7b8c*/ int GetHashCode();
                    /*0x41b7be8*/ string ToString();
                    /*0x41b7c40*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b7c60*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b7cc0*/ int CalculateSize();
                    /*0x41b7d40*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction other);
                    /*0x41b7d80*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b7da0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction.<> <>9;

                        static /*0x41b7f2c*/ <>c();
                        /*0x41b7f94*/ <>c();
                        /*0x41b7f9c*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeBehaviorStateAction <.cctor>b__27_0();
                    }
                }

                class DeathSpotTriggerAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool triggersOnOccupiedCells_;

                    static /*0x41b8524*/ DeathSpotTriggerAction();
                    static /*0x41b7ff0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction> get_Parser();
                    static /*0x41b8048*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b8164*/ DeathSpotTriggerAction();
                    /*0x41b816c*/ DeathSpotTriggerAction(YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction other);
                    /*0x41b8118*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b81b8*/ YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction Clone();
                    /*0x41b8210*/ bool get_TriggersOnOccupiedCells();
                    /*0x41b8218*/ void set_TriggersOnOccupiedCells(bool value);
                    /*0x41b8220*/ bool Equals(object other);
                    /*0x41b8284*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction other);
                    /*0x41b82d0*/ int GetHashCode();
                    /*0x41b8340*/ string ToString();
                    /*0x41b8398*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b83b8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b8418*/ int CalculateSize();
                    /*0x41b8444*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction other);
                    /*0x41b8488*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b84a8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction.<> <>9;

                        static /*0x41b863c*/ <>c();
                        /*0x41b86a4*/ <>c();
                        /*0x41b86ac*/ YetiSimCoreLib.Components.PayloadAction.Types.DeathSpotTriggerAction <.cctor>b__27_0();
                    }
                }

                class SpawnPushedObstacleAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int obstacleId_;
                    /*0x1c*/ int distanceFromUnit_;
                    /*0x20*/ bool staysAttachedWhenBouncing_;

                    static /*0x41b8e10*/ SpawnPushedObstacleAction();
                    static /*0x41b8700*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction> get_Parser();
                    static /*0x41b8758*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b8874*/ SpawnPushedObstacleAction();
                    /*0x41b887c*/ SpawnPushedObstacleAction(YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction other);
                    /*0x41b8828*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b88d0*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction Clone();
                    /*0x41b8928*/ int get_ObstacleId();
                    /*0x41b8930*/ void set_ObstacleId(int value);
                    /*0x41b8938*/ int get_DistanceFromUnit();
                    /*0x41b8940*/ void set_DistanceFromUnit(int value);
                    /*0x41b8948*/ bool get_StaysAttachedWhenBouncing();
                    /*0x41b8950*/ void set_StaysAttachedWhenBouncing(bool value);
                    /*0x41b8958*/ bool Equals(object other);
                    /*0x41b89bc*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction other);
                    /*0x41b8a28*/ int GetHashCode();
                    /*0x41b8adc*/ string ToString();
                    /*0x41b8b34*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b8b54*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b8c04*/ int CalculateSize();
                    /*0x41b8cd0*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction other);
                    /*0x41b8d2c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b8d4c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction.<> <>9;

                        static /*0x41b8f28*/ <>c();
                        /*0x41b8f90*/ <>c();
                        /*0x41b8f98*/ YetiSimCoreLib.Components.PayloadAction.Types.SpawnPushedObstacleAction <.cctor>b__37_0();
                    }
                }

                class RestoreChargesAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int abilityId_;
                    /*0x1c*/ bool hasOverrideAmount_;
                    /*0x20*/ int overrideAmount_;

                    static /*0x41b9704*/ RestoreChargesAction();
                    static /*0x41b8fec*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction> get_Parser();
                    static /*0x41b9044*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b9160*/ RestoreChargesAction();
                    /*0x41b9168*/ RestoreChargesAction(YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction other);
                    /*0x41b9114*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b91c4*/ YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction Clone();
                    /*0x41b921c*/ int get_AbilityId();
                    /*0x41b9224*/ void set_AbilityId(int value);
                    /*0x41b922c*/ bool get_HasOverrideAmount();
                    /*0x41b9234*/ void set_HasOverrideAmount(bool value);
                    /*0x41b923c*/ int get_OverrideAmount();
                    /*0x41b9244*/ void set_OverrideAmount(int value);
                    /*0x41b924c*/ bool Equals(object other);
                    /*0x41b92b0*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction other);
                    /*0x41b931c*/ int GetHashCode();
                    /*0x41b93d0*/ string ToString();
                    /*0x41b9428*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b9448*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b94f8*/ int CalculateSize();
                    /*0x41b95c4*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction other);
                    /*0x41b9620*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b9640*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction.<> <>9;

                        static /*0x41b981c*/ <>c();
                        /*0x41b9884*/ <>c();
                        /*0x41b988c*/ YetiSimCoreLib.Components.PayloadAction.Types.RestoreChargesAction <.cctor>b__37_0();
                    }
                }

                class StoreUnitAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool isVisible_;

                    static /*0x41b9e14*/ StoreUnitAction();
                    static /*0x41b98e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction> get_Parser();
                    static /*0x41b9938*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41b9a54*/ StoreUnitAction();
                    /*0x41b9a5c*/ StoreUnitAction(YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction other);
                    /*0x41b9a08*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41b9aa8*/ YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction Clone();
                    /*0x41b9b00*/ bool get_IsVisible();
                    /*0x41b9b08*/ void set_IsVisible(bool value);
                    /*0x41b9b10*/ bool Equals(object other);
                    /*0x41b9b74*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction other);
                    /*0x41b9bc0*/ int GetHashCode();
                    /*0x41b9c30*/ string ToString();
                    /*0x41b9c88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41b9ca8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41b9d08*/ int CalculateSize();
                    /*0x41b9d34*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction other);
                    /*0x41b9d78*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41b9d98*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction.<> <>9;

                        static /*0x41b9f2c*/ <>c();
                        /*0x41b9f94*/ <>c();
                        /*0x41b9f9c*/ YetiSimCoreLib.Components.PayloadAction.Types.StoreUnitAction <.cctor>b__27_0();
                    }
                }

                class PromoteUnitAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41ba430*/ PromoteUnitAction();
                    static /*0x41b9ff0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction> get_Parser();
                    static /*0x41ba048*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41ba164*/ PromoteUnitAction();
                    /*0x41ba16c*/ PromoteUnitAction(YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction other);
                    /*0x41ba118*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41ba1b0*/ YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction Clone();
                    /*0x41ba208*/ bool Equals(object other);
                    /*0x41ba28c*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction other);
                    /*0x41ba2b8*/ int GetHashCode();
                    /*0x41ba2e4*/ string ToString();
                    /*0x41ba33c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41ba35c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41ba370*/ int CalculateSize();
                    /*0x41ba384*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction other);
                    /*0x41ba3b8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41ba3d8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction.<> <>9;

                        static /*0x41ba548*/ <>c();
                        /*0x41ba5b0*/ <>c();
                        /*0x41ba5b8*/ YetiSimCoreLib.Components.PayloadAction.Types.PromoteUnitAction <.cctor>b__22_0();
                    }
                }

                class GenerateImpactActionsAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction> _parser;
                    static /*0x8*/ Google.Protobuf.FieldCodec<Yeti.Data.ActionTypeDefinition> _repeated_actionTypes_codec;
                    static /*0x10*/ Google.Protobuf.FieldCodec<Yeti.Data.AbilityActionDefintion> _repeated_actions_codec;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Google.Protobuf.Collections.RepeatedField<Yeti.Data.ActionTypeDefinition> actionTypes_;
                    /*0x20*/ Google.Protobuf.Collections.RepeatedField<Yeti.Data.AbilityActionDefintion> actions_;
                    /*0x28*/ bool spawnAtImpactLocation_;

                    static /*0x41bb03c*/ GenerateImpactActionsAction();
                    static /*0x41ba60c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction> get_Parser();
                    static /*0x41ba664*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41ba780*/ GenerateImpactActionsAction();
                    /*0x41ba85c*/ GenerateImpactActionsAction(YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction other);
                    /*0x41ba734*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41ba924*/ YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction Clone();
                    /*0x41ba97c*/ Google.Protobuf.Collections.RepeatedField<Yeti.Data.ActionTypeDefinition> get_ActionTypes();
                    /*0x41ba984*/ Google.Protobuf.Collections.RepeatedField<Yeti.Data.AbilityActionDefintion> get_Actions();
                    /*0x41ba98c*/ bool get_SpawnAtImpactLocation();
                    /*0x41ba994*/ void set_SpawnAtImpactLocation(bool value);
                    /*0x41ba99c*/ bool Equals(object other);
                    /*0x41baa00*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction other);
                    /*0x41baadc*/ int GetHashCode();
                    /*0x41bab88*/ string ToString();
                    /*0x41babe0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bac00*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bad14*/ int CalculateSize();
                    /*0x41bae00*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction other);
                    /*0x41baec0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41baee0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction.<> <>9;

                        static /*0x41bb284*/ <>c();
                        /*0x41bb2ec*/ <>c();
                        /*0x41bb2f4*/ YetiSimCoreLib.Components.PayloadAction.Types.GenerateImpactActionsAction <.cctor>b__37_0();
                    }
                }

                class TeleportToUnitAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int unitId_;
                    /*0x1c*/ int offsetX_;

                    static /*0x41bb960*/ TeleportToUnitAction();
                    static /*0x41bb344*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction> get_Parser();
                    static /*0x41bb39c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bb4b8*/ TeleportToUnitAction();
                    /*0x41bb4c0*/ TeleportToUnitAction(YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction other);
                    /*0x41bb46c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bb50c*/ YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction Clone();
                    /*0x41bb564*/ int get_UnitId();
                    /*0x41bb56c*/ void set_UnitId(int value);
                    /*0x41bb574*/ int get_OffsetX();
                    /*0x41bb57c*/ void set_OffsetX(int value);
                    /*0x41bb584*/ bool Equals(object other);
                    /*0x41bb5e8*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction other);
                    /*0x41bb634*/ int GetHashCode();
                    /*0x41bb6ac*/ string ToString();
                    /*0x41bb704*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bb724*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bb7ac*/ int CalculateSize();
                    /*0x41bb860*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction other);
                    /*0x41bb8ac*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bb8cc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction.<> <>9;

                        static /*0x41bba78*/ <>c();
                        /*0x41bbae0*/ <>c();
                        /*0x41bbae8*/ YetiSimCoreLib.Components.PayloadAction.Types.TeleportToUnitAction <.cctor>b__32_0();
                    }
                }

                class ImpactAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.ImpactType impactType_;
                    /*0x1c*/ bool isCritHit_;
                    /*0x1d*/ bool isBouncing_;

                    static /*0x41bc260*/ ImpactAction();
                    static /*0x41bbb3c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction> get_Parser();
                    static /*0x41bbb94*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bbcb0*/ ImpactAction();
                    /*0x41bbcb8*/ ImpactAction(YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction other);
                    /*0x41bbc64*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bbd0c*/ YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction Clone();
                    /*0x41bbd64*/ Yeti.Data.ImpactType get_ImpactType();
                    /*0x41bbd6c*/ void set_ImpactType(Yeti.Data.ImpactType value);
                    /*0x41bbd74*/ bool get_IsCritHit();
                    /*0x41bbd7c*/ void set_IsCritHit(bool value);
                    /*0x41bbd84*/ bool get_IsBouncing();
                    /*0x41bbd8c*/ void set_IsBouncing(bool value);
                    /*0x41bbd94*/ bool Equals(object other);
                    /*0x41bbdf8*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction other);
                    /*0x41bbe74*/ int GetHashCode();
                    /*0x41bbf44*/ string ToString();
                    /*0x41bbf9c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bbfbc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bc06c*/ int CalculateSize();
                    /*0x41bc114*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction other);
                    /*0x41bc174*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bc194*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction.<> <>9;

                        static /*0x41bc378*/ <>c();
                        /*0x41bc3e0*/ <>c();
                        /*0x41bc3e8*/ YetiSimCoreLib.Components.PayloadAction.Types.ImpactAction <.cctor>b__37_0();
                    }
                }

                class ChangeMaterialAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.UnitMaterialType material_;

                    static /*0x41bc994*/ ChangeMaterialAction();
                    static /*0x41bc43c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction> get_Parser();
                    static /*0x41bc494*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bc5b0*/ ChangeMaterialAction();
                    /*0x41bc5b8*/ ChangeMaterialAction(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction other);
                    /*0x41bc564*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bc604*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction Clone();
                    /*0x41bc65c*/ Yeti.Data.UnitMaterialType get_Material();
                    /*0x41bc664*/ void set_Material(Yeti.Data.UnitMaterialType value);
                    /*0x41bc66c*/ bool Equals(object other);
                    /*0x41bc6d0*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction other);
                    /*0x41bc70c*/ int GetHashCode();
                    /*0x41bc768*/ string ToString();
                    /*0x41bc7c0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bc7e0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bc840*/ int CalculateSize();
                    /*0x41bc8c0*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction other);
                    /*0x41bc900*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bc920*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction.<> <>9;

                        static /*0x41bcaac*/ <>c();
                        /*0x41bcb14*/ <>c();
                        /*0x41bcb1c*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMaterialAction <.cctor>b__27_0();
                    }
                }

                class ChangeHitboxAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.HitboxDefinition hitbox_;

                    static /*0x41bd22c*/ ChangeHitboxAction();
                    static /*0x41bcb70*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction> get_Parser();
                    static /*0x41bcbc8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bcce4*/ ChangeHitboxAction();
                    /*0x41bccec*/ ChangeHitboxAction(YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction other);
                    /*0x41bcc98*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bcd5c*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction Clone();
                    /*0x41bcdb4*/ Yeti.Data.HitboxDefinition get_Hitbox();
                    /*0x41bcdbc*/ void set_Hitbox(Yeti.Data.HitboxDefinition value);
                    /*0x41bcdc4*/ bool Equals(object other);
                    /*0x41bce28*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction other);
                    /*0x41bce88*/ int GetHashCode();
                    /*0x41bcedc*/ string ToString();
                    /*0x41bcf34*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bcf54*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bcfb4*/ int CalculateSize();
                    /*0x41bd034*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction other);
                    /*0x41bd100*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bd120*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction.<> <>9;

                        static /*0x41bd344*/ <>c();
                        /*0x41bd3ac*/ <>c();
                        /*0x41bd3b4*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeHitboxAction <.cctor>b__27_0();
                    }
                }

                class RemoveArmorStackAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41bd848*/ RemoveArmorStackAction();
                    static /*0x41bd408*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction> get_Parser();
                    static /*0x41bd460*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bd57c*/ RemoveArmorStackAction();
                    /*0x41bd584*/ RemoveArmorStackAction(YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction other);
                    /*0x41bd530*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bd5c8*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction Clone();
                    /*0x41bd620*/ bool Equals(object other);
                    /*0x41bd6a4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction other);
                    /*0x41bd6d0*/ int GetHashCode();
                    /*0x41bd6fc*/ string ToString();
                    /*0x41bd754*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bd774*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bd788*/ int CalculateSize();
                    /*0x41bd79c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction other);
                    /*0x41bd7d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bd7f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction.<> <>9;

                        static /*0x41bd960*/ <>c();
                        /*0x41bd9c8*/ <>c();
                        /*0x41bd9d0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveArmorStackAction <.cctor>b__22_0();
                    }
                }

                class RemoveUnitAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41bde64*/ RemoveUnitAction();
                    static /*0x41bda24*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction> get_Parser();
                    static /*0x41bda7c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bdb98*/ RemoveUnitAction();
                    /*0x41bdba0*/ RemoveUnitAction(YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction other);
                    /*0x41bdb4c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bdbe4*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction Clone();
                    /*0x41bdc3c*/ bool Equals(object other);
                    /*0x41bdcc0*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction other);
                    /*0x41bdcec*/ int GetHashCode();
                    /*0x41bdd18*/ string ToString();
                    /*0x41bdd70*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bdd90*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bdda4*/ int CalculateSize();
                    /*0x41bddb8*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction other);
                    /*0x41bddec*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bde0c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction.<> <>9;

                        static /*0x41bdf7c*/ <>c();
                        /*0x41bdfe4*/ <>c();
                        /*0x41bdfec*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveUnitAction <.cctor>b__22_0();
                    }
                }

                class ChangeMovementSpeedAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int speedXInCentigridsPerSec_;

                    static /*0x41be598*/ ChangeMovementSpeedAction();
                    static /*0x41be040*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction> get_Parser();
                    static /*0x41be098*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41be1b4*/ ChangeMovementSpeedAction();
                    /*0x41be1bc*/ ChangeMovementSpeedAction(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction other);
                    /*0x41be168*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41be208*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction Clone();
                    /*0x41be260*/ int get_SpeedXInCentigridsPerSec();
                    /*0x41be268*/ void set_SpeedXInCentigridsPerSec(int value);
                    /*0x41be270*/ bool Equals(object other);
                    /*0x41be2d4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction other);
                    /*0x41be310*/ int GetHashCode();
                    /*0x41be36c*/ string ToString();
                    /*0x41be3c4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41be3e4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41be444*/ int CalculateSize();
                    /*0x41be4c4*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction other);
                    /*0x41be504*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41be524*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction.<> <>9;

                        static /*0x41be6b0*/ <>c();
                        /*0x41be718*/ <>c();
                        /*0x41be720*/ YetiSimCoreLib.Components.PayloadAction.Types.ChangeMovementSpeedAction <.cctor>b__27_0();
                    }
                }

                class ApplyPlantFoodAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41bebb4*/ ApplyPlantFoodAction();
                    static /*0x41be774*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction> get_Parser();
                    static /*0x41be7cc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41be8e8*/ ApplyPlantFoodAction();
                    /*0x41be8f0*/ ApplyPlantFoodAction(YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction other);
                    /*0x41be89c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41be934*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction Clone();
                    /*0x41be98c*/ bool Equals(object other);
                    /*0x41bea10*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction other);
                    /*0x41bea3c*/ int GetHashCode();
                    /*0x41bea68*/ string ToString();
                    /*0x41beac0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41beae0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41beaf4*/ int CalculateSize();
                    /*0x41beb08*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction other);
                    /*0x41beb3c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41beb5c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction.<> <>9;

                        static /*0x41beccc*/ <>c();
                        /*0x41bed34*/ <>c();
                        /*0x41bed3c*/ YetiSimCoreLib.Components.PayloadAction.Types.ApplyPlantFoodAction <.cctor>b__22_0();
                    }
                }

                class DetachAttachedUnitAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41bf1d0*/ DetachAttachedUnitAction();
                    static /*0x41bed90*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction> get_Parser();
                    static /*0x41bede8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bef04*/ DetachAttachedUnitAction();
                    /*0x41bef0c*/ DetachAttachedUnitAction(YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction other);
                    /*0x41beeb8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bef50*/ YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction Clone();
                    /*0x41befa8*/ bool Equals(object other);
                    /*0x41bf02c*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction other);
                    /*0x41bf058*/ int GetHashCode();
                    /*0x41bf084*/ string ToString();
                    /*0x41bf0dc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bf0fc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bf110*/ int CalculateSize();
                    /*0x41bf124*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction other);
                    /*0x41bf158*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bf178*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction.<> <>9;

                        static /*0x41bf2e8*/ <>c();
                        /*0x41bf350*/ <>c();
                        /*0x41bf358*/ YetiSimCoreLib.Components.PayloadAction.Types.DetachAttachedUnitAction <.cctor>b__22_0();
                    }
                }

                class RepopulateUnitFormationAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41bf7ec*/ RepopulateUnitFormationAction();
                    static /*0x41bf3ac*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction> get_Parser();
                    static /*0x41bf404*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bf520*/ RepopulateUnitFormationAction();
                    /*0x41bf528*/ RepopulateUnitFormationAction(YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction other);
                    /*0x41bf4d4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bf56c*/ YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction Clone();
                    /*0x41bf5c4*/ bool Equals(object other);
                    /*0x41bf648*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction other);
                    /*0x41bf674*/ int GetHashCode();
                    /*0x41bf6a0*/ string ToString();
                    /*0x41bf6f8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bf718*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bf72c*/ int CalculateSize();
                    /*0x41bf740*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction other);
                    /*0x41bf774*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bf794*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction.<> <>9;

                        static /*0x41bf904*/ <>c();
                        /*0x41bf96c*/ <>c();
                        /*0x41bf974*/ YetiSimCoreLib.Components.PayloadAction.Types.RepopulateUnitFormationAction <.cctor>b__22_0();
                    }
                }

                class SetSunGenerationRateAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41bfe08*/ SetSunGenerationRateAction();
                    static /*0x41bf9c8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction> get_Parser();
                    static /*0x41bfa20*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41bfb3c*/ SetSunGenerationRateAction();
                    /*0x41bfb44*/ SetSunGenerationRateAction(YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction other);
                    /*0x41bfaf0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41bfb88*/ YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction Clone();
                    /*0x41bfbe0*/ bool Equals(object other);
                    /*0x41bfc64*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction other);
                    /*0x41bfc90*/ int GetHashCode();
                    /*0x41bfcbc*/ string ToString();
                    /*0x41bfd14*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41bfd34*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41bfd48*/ int CalculateSize();
                    /*0x41bfd5c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction other);
                    /*0x41bfd90*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41bfdb0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction.<> <>9;

                        static /*0x41bff20*/ <>c();
                        /*0x41bff88*/ <>c();
                        /*0x41bff90*/ YetiSimCoreLib.Components.PayloadAction.Types.SetSunGenerationRateAction <.cctor>b__22_0();
                    }
                }

                class DestroyAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ bool shouldGenerateScore_;
                    /*0x20*/ string deathPresentationTag_;

                    static /*0x41c075c*/ DestroyAction();
                    static /*0x41bffe4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction> get_Parser();
                    static /*0x41c003c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c0158*/ DestroyAction();
                    /*0x41c01b0*/ DestroyAction(YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction other);
                    /*0x41c010c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c0208*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction Clone();
                    /*0x41c0260*/ bool get_ShouldGenerateScore();
                    /*0x41c0268*/ void set_ShouldGenerateScore(bool value);
                    /*0x41c0270*/ string get_DeathPresentationTag();
                    /*0x41c0278*/ void set_DeathPresentationTag(string value);
                    /*0x41c02f4*/ bool Equals(object other);
                    /*0x41c0358*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction other);
                    /*0x41c03d8*/ int GetHashCode();
                    /*0x41c046c*/ string ToString();
                    /*0x41c04c4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c04e4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c0578*/ int CalculateSize();
                    /*0x41c0610*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction other);
                    /*0x41c0684*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c06a4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction.<> <>9;

                        static /*0x41c0874*/ <>c();
                        /*0x41c08dc*/ <>c();
                        /*0x41c08e4*/ YetiSimCoreLib.Components.PayloadAction.Types.DestroyAction <.cctor>b__32_0();
                    }
                }

                class ManualActivateAbilityAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int abilityGroupId_;

                    static /*0x41c0e8c*/ ManualActivateAbilityAction();
                    static /*0x41c0934*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction> get_Parser();
                    static /*0x41c098c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c0aa8*/ ManualActivateAbilityAction();
                    /*0x41c0ab0*/ ManualActivateAbilityAction(YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction other);
                    /*0x41c0a5c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c0afc*/ YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction Clone();
                    /*0x41c0b54*/ int get_AbilityGroupId();
                    /*0x41c0b5c*/ void set_AbilityGroupId(int value);
                    /*0x41c0b64*/ bool Equals(object other);
                    /*0x41c0bc8*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction other);
                    /*0x41c0c04*/ int GetHashCode();
                    /*0x41c0c60*/ string ToString();
                    /*0x41c0cb8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c0cd8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c0d38*/ int CalculateSize();
                    /*0x41c0db8*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction other);
                    /*0x41c0df8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c0e18*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction.<> <>9;

                        static /*0x41c0fa4*/ <>c();
                        /*0x41c100c*/ <>c();
                        /*0x41c1014*/ YetiSimCoreLib.Components.PayloadAction.Types.ManualActivateAbilityAction <.cctor>b__27_0();
                    }
                }

                class ShiftPositionAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.ShiftPositionType movementType_;
                    /*0x1c*/ int timeInTicks_;

                    static /*0x41c1684*/ ShiftPositionAction();
                    static /*0x41c1068*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction> get_Parser();
                    static /*0x41c10c0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c11dc*/ ShiftPositionAction();
                    /*0x41c11e4*/ ShiftPositionAction(YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction other);
                    /*0x41c1190*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c1230*/ YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction Clone();
                    /*0x41c1288*/ Yeti.Data.ShiftPositionType get_MovementType();
                    /*0x41c1290*/ void set_MovementType(Yeti.Data.ShiftPositionType value);
                    /*0x41c1298*/ int get_TimeInTicks();
                    /*0x41c12a0*/ void set_TimeInTicks(int value);
                    /*0x41c12a8*/ bool Equals(object other);
                    /*0x41c130c*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction other);
                    /*0x41c1358*/ int GetHashCode();
                    /*0x41c13d0*/ string ToString();
                    /*0x41c1428*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c1448*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c14d0*/ int CalculateSize();
                    /*0x41c1584*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction other);
                    /*0x41c15d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c15f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction.<> <>9;

                        static /*0x41c179c*/ <>c();
                        /*0x41c1804*/ <>c();
                        /*0x41c180c*/ YetiSimCoreLib.Components.PayloadAction.Types.ShiftPositionAction <.cctor>b__32_0();
                    }
                }

                class DelayFutureWavesAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int delayInTicks_;

                    static /*0x41c1db8*/ DelayFutureWavesAction();
                    static /*0x41c1860*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction> get_Parser();
                    static /*0x41c18b8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c19d4*/ DelayFutureWavesAction();
                    /*0x41c19dc*/ DelayFutureWavesAction(YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction other);
                    /*0x41c1988*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c1a28*/ YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction Clone();
                    /*0x41c1a80*/ int get_DelayInTicks();
                    /*0x41c1a88*/ void set_DelayInTicks(int value);
                    /*0x41c1a90*/ bool Equals(object other);
                    /*0x41c1af4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction other);
                    /*0x41c1b30*/ int GetHashCode();
                    /*0x41c1b8c*/ string ToString();
                    /*0x41c1be4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c1c04*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c1c64*/ int CalculateSize();
                    /*0x41c1ce4*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction other);
                    /*0x41c1d24*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c1d44*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction.<> <>9;

                        static /*0x41c1ed0*/ <>c();
                        /*0x41c1f38*/ <>c();
                        /*0x41c1f40*/ YetiSimCoreLib.Components.PayloadAction.Types.DelayFutureWavesAction <.cctor>b__27_0();
                    }
                }

                class PreventReachingGoalAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int durationInTicks_;

                    static /*0x41c24ec*/ PreventReachingGoalAction();
                    static /*0x41c1f94*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction> get_Parser();
                    static /*0x41c1fec*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c2108*/ PreventReachingGoalAction();
                    /*0x41c2110*/ PreventReachingGoalAction(YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction other);
                    /*0x41c20bc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c215c*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction Clone();
                    /*0x41c21b4*/ int get_DurationInTicks();
                    /*0x41c21bc*/ void set_DurationInTicks(int value);
                    /*0x41c21c4*/ bool Equals(object other);
                    /*0x41c2228*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction other);
                    /*0x41c2264*/ int GetHashCode();
                    /*0x41c22c0*/ string ToString();
                    /*0x41c2318*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c2338*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c2398*/ int CalculateSize();
                    /*0x41c2418*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction other);
                    /*0x41c2458*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c2478*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction.<> <>9;

                        static /*0x41c2604*/ <>c();
                        /*0x41c266c*/ <>c();
                        /*0x41c2674*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventReachingGoalAction <.cctor>b__27_0();
                    }
                }

                class MoveSelfToTargetLaneAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int overridePullLaneSpeedZ_;

                    static /*0x41c2c20*/ MoveSelfToTargetLaneAction();
                    static /*0x41c26c8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction> get_Parser();
                    static /*0x41c2720*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c283c*/ MoveSelfToTargetLaneAction();
                    /*0x41c2844*/ MoveSelfToTargetLaneAction(YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction other);
                    /*0x41c27f0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c2890*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction Clone();
                    /*0x41c28e8*/ int get_OverridePullLaneSpeedZ();
                    /*0x41c28f0*/ void set_OverridePullLaneSpeedZ(int value);
                    /*0x41c28f8*/ bool Equals(object other);
                    /*0x41c295c*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction other);
                    /*0x41c2998*/ int GetHashCode();
                    /*0x41c29f4*/ string ToString();
                    /*0x41c2a4c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c2a6c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c2acc*/ int CalculateSize();
                    /*0x41c2b4c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction other);
                    /*0x41c2b8c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c2bac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction.<> <>9;

                        static /*0x41c2d38*/ <>c();
                        /*0x41c2da0*/ <>c();
                        /*0x41c2da8*/ YetiSimCoreLib.Components.PayloadAction.Types.MoveSelfToTargetLaneAction <.cctor>b__27_0();
                    }
                }

                class RemoveCellOccupancyAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41c323c*/ RemoveCellOccupancyAction();
                    static /*0x41c2dfc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction> get_Parser();
                    static /*0x41c2e54*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c2f70*/ RemoveCellOccupancyAction();
                    /*0x41c2f78*/ RemoveCellOccupancyAction(YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction other);
                    /*0x41c2f24*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c2fbc*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction Clone();
                    /*0x41c3014*/ bool Equals(object other);
                    /*0x41c3098*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction other);
                    /*0x41c30c4*/ int GetHashCode();
                    /*0x41c30f0*/ string ToString();
                    /*0x41c3148*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c3168*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c317c*/ int CalculateSize();
                    /*0x41c3190*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction other);
                    /*0x41c31c4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c31e4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction.<> <>9;

                        static /*0x41c3354*/ <>c();
                        /*0x41c33bc*/ <>c();
                        /*0x41c33c4*/ YetiSimCoreLib.Components.PayloadAction.Types.RemoveCellOccupancyAction <.cctor>b__22_0();
                    }
                }

                class PreventGameEndAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int durationInTicks_;

                    static /*0x41c3970*/ PreventGameEndAction();
                    static /*0x41c3418*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction> get_Parser();
                    static /*0x41c3470*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c358c*/ PreventGameEndAction();
                    /*0x41c3594*/ PreventGameEndAction(YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction other);
                    /*0x41c3540*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c35e0*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction Clone();
                    /*0x41c3638*/ int get_DurationInTicks();
                    /*0x41c3640*/ void set_DurationInTicks(int value);
                    /*0x41c3648*/ bool Equals(object other);
                    /*0x41c36ac*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction other);
                    /*0x41c36e8*/ int GetHashCode();
                    /*0x41c3744*/ string ToString();
                    /*0x41c379c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c37bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c381c*/ int CalculateSize();
                    /*0x41c389c*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction other);
                    /*0x41c38dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c38fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction.<> <>9;

                        static /*0x41c3a88*/ <>c();
                        /*0x41c3af0*/ <>c();
                        /*0x41c3af8*/ YetiSimCoreLib.Components.PayloadAction.Types.PreventGameEndAction <.cctor>b__27_0();
                    }
                }

                class ForceNextSpawnToLaneAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction> _parser;
                    static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_mustHaveTags_codec;
                    static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_mustNotHaveTags_codec;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> mustHaveTags_;
                    /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> mustNotHaveTags_;

                    static /*0x41c4408*/ ForceNextSpawnToLaneAction();
                    static /*0x41c3b4c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction> get_Parser();
                    static /*0x41c3ba4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c3cc0*/ ForceNextSpawnToLaneAction();
                    /*0x41c3d6c*/ ForceNextSpawnToLaneAction(YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction other);
                    /*0x41c3c74*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c3e18*/ YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction Clone();
                    /*0x41c3e70*/ Google.Protobuf.Collections.RepeatedField<int> get_MustHaveTags();
                    /*0x41c3e78*/ Google.Protobuf.Collections.RepeatedField<int> get_MustNotHaveTags();
                    /*0x41c3e80*/ bool Equals(object other);
                    /*0x41c3ee4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction other);
                    /*0x41c3f8c*/ int GetHashCode();
                    /*0x41c4000*/ string ToString();
                    /*0x41c4058*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c4078*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c4150*/ int CalculateSize();
                    /*0x41c4224*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction other);
                    /*0x41c42c0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c42e0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction.<> <>9;

                        static /*0x41c4568*/ <>c();
                        /*0x41c45d0*/ <>c();
                        /*0x41c45d8*/ YetiSimCoreLib.Components.PayloadAction.Types.ForceNextSpawnToLaneAction <.cctor>b__32_0();
                    }
                }

                class MarkHitByAbilityInstanceAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                    static /*0x41c4a68*/ MarkHitByAbilityInstanceAction();
                    static /*0x41c4628*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction> get_Parser();
                    static /*0x41c4680*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c479c*/ MarkHitByAbilityInstanceAction();
                    /*0x41c47a4*/ MarkHitByAbilityInstanceAction(YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction other);
                    /*0x41c4750*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c47e8*/ YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction Clone();
                    /*0x41c4840*/ bool Equals(object other);
                    /*0x41c48c4*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction other);
                    /*0x41c48f0*/ int GetHashCode();
                    /*0x41c491c*/ string ToString();
                    /*0x41c4974*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c4994*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c49a8*/ int CalculateSize();
                    /*0x41c49bc*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction other);
                    /*0x41c49f0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c4a10*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction.<> <>9;

                        static /*0x41c4b80*/ <>c();
                        /*0x41c4be8*/ <>c();
                        /*0x41c4bf0*/ YetiSimCoreLib.Components.PayloadAction.Types.MarkHitByAbilityInstanceAction <.cctor>b__22_0();
                    }
                }

                class GrantDamageRedirectionAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction> _parser;
                    static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_mustHaveAnyOfTags_codec;
                    static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_mustHaveAllOfTags_codec;
                    static /*0x18*/ Google.Protobuf.FieldCodec<int> _repeated_mustNotHaveAnyOfTags_codec;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int targetPatternId_;
                    /*0x1c*/ int numRedirects_;
                    /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> mustHaveAnyOfTags_;
                    /*0x28*/ Google.Protobuf.Collections.RepeatedField<int> mustHaveAllOfTags_;
                    /*0x30*/ Google.Protobuf.Collections.RepeatedField<int> mustNotHaveAnyOfTags_;

                    static /*0x41c57e0*/ GrantDamageRedirectionAction();
                    static /*0x41c4c44*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction> get_Parser();
                    static /*0x41c4c9c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c4db8*/ GrantDamageRedirectionAction();
                    /*0x41c4e88*/ GrantDamageRedirectionAction(YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction other);
                    /*0x41c4d6c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c4f5c*/ YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction Clone();
                    /*0x41c4fb4*/ int get_TargetPatternId();
                    /*0x41c4fbc*/ void set_TargetPatternId(int value);
                    /*0x41c4fc4*/ int get_NumRedirects();
                    /*0x41c4fcc*/ void set_NumRedirects(int value);
                    /*0x41c4fd4*/ Google.Protobuf.Collections.RepeatedField<int> get_MustHaveAnyOfTags();
                    /*0x41c4fdc*/ Google.Protobuf.Collections.RepeatedField<int> get_MustHaveAllOfTags();
                    /*0x41c4fe4*/ Google.Protobuf.Collections.RepeatedField<int> get_MustNotHaveAnyOfTags();
                    /*0x41c4fec*/ bool Equals(object other);
                    /*0x41c5050*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction other);
                    /*0x41c5130*/ int GetHashCode();
                    /*0x41c5210*/ string ToString();
                    /*0x41c5268*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c5288*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c53d0*/ int CalculateSize();
                    /*0x41c5548*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction other);
                    /*0x41c5610*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c5630*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction.<> <>9;

                        static /*0x41c5964*/ <>c();
                        /*0x41c59cc*/ <>c();
                        /*0x41c59d4*/ YetiSimCoreLib.Components.PayloadAction.Types.GrantDamageRedirectionAction <.cctor>b__47_0();
                    }
                }

                class SetAbilityCooldownAction : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int abilityId_;
                    /*0x1c*/ int cooldownToSet_;

                    static /*0x41c6040*/ SetAbilityCooldownAction();
                    static /*0x41c5a24*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction> get_Parser();
                    static /*0x41c5a7c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c5b98*/ SetAbilityCooldownAction();
                    /*0x41c5ba0*/ SetAbilityCooldownAction(YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction other);
                    /*0x41c5b4c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c5bec*/ YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction Clone();
                    /*0x41c5c44*/ int get_AbilityId();
                    /*0x41c5c4c*/ void set_AbilityId(int value);
                    /*0x41c5c54*/ int get_CooldownToSet();
                    /*0x41c5c5c*/ void set_CooldownToSet(int value);
                    /*0x41c5c64*/ bool Equals(object other);
                    /*0x41c5cc8*/ bool Equals(YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction other);
                    /*0x41c5d14*/ int GetHashCode();
                    /*0x41c5d8c*/ string ToString();
                    /*0x41c5de4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c5e04*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c5e8c*/ int CalculateSize();
                    /*0x41c5f40*/ void MergeFrom(YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction other);
                    /*0x41c5f8c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c5fac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction.<> <>9;

                        static /*0x41c6158*/ <>c();
                        /*0x41c61c0*/ <>c();
                        /*0x41c61c8*/ YetiSimCoreLib.Components.PayloadAction.Types.SetAbilityCooldownAction <.cctor>b__32_0();
                    }
                }
            }

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PayloadAction.<> <>9;

                static /*0x41c621c*/ <>c();
                /*0x41c6284*/ <>c();
                /*0x41c628c*/ YetiSimCoreLib.Components.PayloadAction <.cctor>b__283_0();
            }
        }

        class PayloadConstraint : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadConstraint>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadConstraint>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadConstraint>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ object constraint_;
            /*0x20*/ YetiSimCoreLib.Components.PayloadConstraint.ConstraintOneofCase constraintCase_;

            static /*0x41c73c0*/ PayloadConstraint();
            static /*0x41c62e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint> get_Parser();
            static /*0x41c6338*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41c6488*/ PayloadConstraint();
            /*0x41c6490*/ PayloadConstraint(YetiSimCoreLib.Components.PayloadConstraint other);
            /*0x41c643c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41c6870*/ YetiSimCoreLib.Components.PayloadConstraint Clone();
            /*0x41c6584*/ YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint get_Tags();
            /*0x41c6648*/ void set_Tags(YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint value);
            /*0x41c667c*/ YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint get_ProcChance();
            /*0x41c6740*/ void set_ProcChance(YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint value);
            /*0x41c6774*/ YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint get_StatComparison();
            /*0x41c6838*/ void set_StatComparison(YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint value);
            /*0x41c68c8*/ YetiSimCoreLib.Components.PayloadConstraint.ConstraintOneofCase get_ConstraintCase();
            /*0x41c68d0*/ void ClearConstraint();
            /*0x41c68e0*/ bool Equals(object other);
            /*0x41c6944*/ bool Equals(YetiSimCoreLib.Components.PayloadConstraint other);
            /*0x41c6a18*/ int GetHashCode();
            /*0x41c6ad8*/ string ToString();
            /*0x41c6b30*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41c6b50*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41c6c24*/ int CalculateSize();
            /*0x41c6d48*/ void MergeFrom(YetiSimCoreLib.Components.PayloadConstraint other);
            /*0x41c7108*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41c7128*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            enum ConstraintOneofCase
            {
                None = 0,
                Tags = 1,
                ProcChance = 2,
                StatComparison = 3,
            }

            class Types
            {
                class TagsPayloadConstraint : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint> _parser;
                    static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_tags_codec;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> tags_;
                    /*0x20*/ Yeti.Data.TagsEvaluationType evaluationType_;

                    static /*0x41c7bc8*/ TagsPayloadConstraint();
                    static /*0x41c74d8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint> get_Parser();
                    static /*0x41c7530*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c6f44*/ TagsPayloadConstraint();
                    /*0x41c7648*/ TagsPayloadConstraint(YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint other);
                    /*0x41c75fc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c65f0*/ YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint Clone();
                    /*0x41c76dc*/ Google.Protobuf.Collections.RepeatedField<int> get_Tags();
                    /*0x41c76e4*/ Yeti.Data.TagsEvaluationType get_EvaluationType();
                    /*0x41c76ec*/ void set_EvaluationType(Yeti.Data.TagsEvaluationType value);
                    /*0x41c76f4*/ bool Equals(object other);
                    /*0x41c7758*/ bool Equals(YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint other);
                    /*0x41c77f8*/ int GetHashCode();
                    /*0x41c7868*/ string ToString();
                    /*0x41c78c0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c78e0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c79c0*/ int CalculateSize();
                    /*0x41c6fcc*/ void MergeFrom(YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint other);
                    /*0x41c7aa4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c7ac4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint.<> <>9;

                        static /*0x41c7d04*/ <>c();
                        /*0x41c7d6c*/ <>c();
                        /*0x41c7d74*/ YetiSimCoreLib.Components.PayloadConstraint.Types.TagsPayloadConstraint <.cctor>b__32_0();
                    }
                }

                class ProcChancePayloadConstraint : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ int procChance_;

                    static /*0x41c8278*/ ProcChancePayloadConstraint();
                    static /*0x41c7dc4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint> get_Parser();
                    static /*0x41c7e1c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c7060*/ ProcChancePayloadConstraint();
                    /*0x41c7f34*/ ProcChancePayloadConstraint(YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint other);
                    /*0x41c7ee8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c66e8*/ YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint Clone();
                    /*0x41c7f80*/ int get_ProcChance();
                    /*0x41c7f88*/ void set_ProcChance(int value);
                    /*0x41c7f90*/ bool Equals(object other);
                    /*0x41c7ff4*/ bool Equals(YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint other);
                    /*0x41c8030*/ int GetHashCode();
                    /*0x41c808c*/ string ToString();
                    /*0x41c80e4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c8104*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c8164*/ int CalculateSize();
                    /*0x41c7068*/ void MergeFrom(YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint other);
                    /*0x41c81e4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c8204*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint.<> <>9;

                        static /*0x41c8390*/ <>c();
                        /*0x41c83f8*/ <>c();
                        /*0x41c8400*/ YetiSimCoreLib.Components.PayloadConstraint.Types.ProcChancePayloadConstraint <.cctor>b__27_0();
                    }
                }

                class StatComparisonPayloadConstraint : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint>, Google.Protobuf.IBufferMessage
                {
                    static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint> _parser;
                    /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                    /*0x18*/ Yeti.Data.StatType statType_;
                    /*0x1c*/ Yeti.Data.ValueComparison comparison_;
                    /*0x20*/ int statValue_;

                    static /*0x41c8a88*/ StatComparisonPayloadConstraint();
                    static /*0x41c8454*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint> get_Parser();
                    static /*0x41c84ac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                    /*0x41c70a8*/ StatComparisonPayloadConstraint();
                    /*0x41c85c4*/ StatComparisonPayloadConstraint(YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint other);
                    /*0x41c8578*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                    /*0x41c67e0*/ YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint Clone();
                    /*0x41c8618*/ Yeti.Data.StatType get_StatType();
                    /*0x41c8620*/ void set_StatType(Yeti.Data.StatType value);
                    /*0x41c8628*/ Yeti.Data.ValueComparison get_Comparison();
                    /*0x41c8630*/ void set_Comparison(Yeti.Data.ValueComparison value);
                    /*0x41c8638*/ int get_StatValue();
                    /*0x41c8640*/ void set_StatValue(int value);
                    /*0x41c8648*/ bool Equals(object other);
                    /*0x41c86ac*/ bool Equals(YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint other);
                    /*0x41c8708*/ int GetHashCode();
                    /*0x41c87a4*/ string ToString();
                    /*0x41c87fc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                    /*0x41c881c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                    /*0x41c88cc*/ int CalculateSize();
                    /*0x41c70b0*/ void MergeFrom(YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint other);
                    /*0x41c89ac*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                    /*0x41c89cc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                    class <>c
                    {
                        static /*0x0*/ YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint.<> <>9;

                        static /*0x41c8ba0*/ <>c();
                        /*0x41c8c08*/ <>c();
                        /*0x41c8c10*/ YetiSimCoreLib.Components.PayloadConstraint.Types.StatComparisonPayloadConstraint <.cctor>b__37_0();
                    }
                }
            }

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PayloadConstraint.<> <>9;

                static /*0x41c8c64*/ <>c();
                /*0x41c8ccc*/ <>c();
                /*0x41c8cd4*/ YetiSimCoreLib.Components.PayloadConstraint <.cctor>b__41_0();
            }
        }

        class ArmorPiercingPayloadComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ArmorPiercingPayloadComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ArmorPiercingPayloadComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ArmorPiercingPayloadComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorPiercingPayloadComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41c919c*/ ArmorPiercingPayloadComponent();
            static /*0x41c8d28*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ArmorPiercingPayloadComponent> get_Parser();
            static /*0x41c8d80*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41c8ed0*/ ArmorPiercingPayloadComponent();
            /*0x41c8ed8*/ ArmorPiercingPayloadComponent(YetiSimCoreLib.Components.ArmorPiercingPayloadComponent other);
            /*0x41c8e84*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41c8f1c*/ YetiSimCoreLib.Components.ArmorPiercingPayloadComponent Clone();
            /*0x41c8f74*/ bool Equals(object other);
            /*0x41c8ff8*/ bool Equals(YetiSimCoreLib.Components.ArmorPiercingPayloadComponent other);
            /*0x41c9024*/ int GetHashCode();
            /*0x41c9050*/ string ToString();
            /*0x41c90a8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41c90c8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41c90dc*/ int CalculateSize();
            /*0x41c90f0*/ void MergeFrom(YetiSimCoreLib.Components.ArmorPiercingPayloadComponent other);
            /*0x41c9124*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41c9144*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ArmorPiercingPayloadComponent.<> <>9;

                static /*0x41c92b4*/ <>c();
                /*0x41c931c*/ <>c();
                /*0x41c9324*/ YetiSimCoreLib.Components.ArmorPiercingPayloadComponent <.cctor>b__22_0();
            }
        }

        class IgnoreEnemyImmunity : Google.Protobuf.IMessage<YetiSimCoreLib.Components.IgnoreEnemyImmunity>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.IgnoreEnemyImmunity>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.IgnoreEnemyImmunity>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IgnoreEnemyImmunity> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41c97ec*/ IgnoreEnemyImmunity();
            static /*0x41c9378*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IgnoreEnemyImmunity> get_Parser();
            static /*0x41c93d0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41c9520*/ IgnoreEnemyImmunity();
            /*0x41c9528*/ IgnoreEnemyImmunity(YetiSimCoreLib.Components.IgnoreEnemyImmunity other);
            /*0x41c94d4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41c956c*/ YetiSimCoreLib.Components.IgnoreEnemyImmunity Clone();
            /*0x41c95c4*/ bool Equals(object other);
            /*0x41c9648*/ bool Equals(YetiSimCoreLib.Components.IgnoreEnemyImmunity other);
            /*0x41c9674*/ int GetHashCode();
            /*0x41c96a0*/ string ToString();
            /*0x41c96f8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41c9718*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41c972c*/ int CalculateSize();
            /*0x41c9740*/ void MergeFrom(YetiSimCoreLib.Components.IgnoreEnemyImmunity other);
            /*0x41c9774*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41c9794*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.IgnoreEnemyImmunity.<> <>9;

                static /*0x41c9904*/ <>c();
                /*0x41c996c*/ <>c();
                /*0x41c9974*/ YetiSimCoreLib.Components.IgnoreEnemyImmunity <.cctor>b__22_0();
            }
        }

        class IgnoreAfterSpawnTargetableDelay : Google.Protobuf.IMessage<YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41c9e3c*/ IgnoreAfterSpawnTargetableDelay();
            static /*0x41c99c8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay> get_Parser();
            static /*0x41c9a20*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41c9b70*/ IgnoreAfterSpawnTargetableDelay();
            /*0x41c9b78*/ IgnoreAfterSpawnTargetableDelay(YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay other);
            /*0x41c9b24*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41c9bbc*/ YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay Clone();
            /*0x41c9c14*/ bool Equals(object other);
            /*0x41c9c98*/ bool Equals(YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay other);
            /*0x41c9cc4*/ int GetHashCode();
            /*0x41c9cf0*/ string ToString();
            /*0x41c9d48*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41c9d68*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41c9d7c*/ int CalculateSize();
            /*0x41c9d90*/ void MergeFrom(YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay other);
            /*0x41c9dc4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41c9de4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay.<> <>9;

                static /*0x41c9f54*/ <>c();
                /*0x41c9fbc*/ <>c();
                /*0x41c9fc4*/ YetiSimCoreLib.Components.IgnoreAfterSpawnTargetableDelay <.cctor>b__22_0();
            }
        }

        class PlantFoodGeneratorComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41ca070*/ PlantFoodGeneratorComponentReflection();
            static /*0x41ca018*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PlantFoodGeneratorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PlantFoodGeneratorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PlantFoodGeneratorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PlantFoodGeneratorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PlantFoodGeneratorComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;
            /*0x1c*/ int incrementValue_;
            /*0x20*/ int rateInTicks_;

            static /*0x41cac78*/ PlantFoodGeneratorComponent();
            static /*0x41ca55c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PlantFoodGeneratorComponent> get_Parser();
            static /*0x41ca5b4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ca704*/ PlantFoodGeneratorComponent();
            /*0x41ca70c*/ PlantFoodGeneratorComponent(YetiSimCoreLib.Components.PlantFoodGeneratorComponent other);
            /*0x41ca6b8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ca760*/ YetiSimCoreLib.Components.PlantFoodGeneratorComponent Clone();
            /*0x41ca7b8*/ int get_TicksRemaining();
            /*0x41ca7c0*/ void set_TicksRemaining(int value);
            /*0x41ca7c8*/ int get_IncrementValue();
            /*0x41ca7d0*/ void set_IncrementValue(int value);
            /*0x41ca7d8*/ int get_RateInTicks();
            /*0x41ca7e0*/ void set_RateInTicks(int value);
            /*0x41ca7e8*/ bool Equals(object other);
            /*0x41ca84c*/ bool Equals(YetiSimCoreLib.Components.PlantFoodGeneratorComponent other);
            /*0x41ca8a8*/ int GetHashCode();
            /*0x41ca93c*/ string ToString();
            /*0x41ca994*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ca9b4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41caa64*/ int CalculateSize();
            /*0x41cab44*/ void MergeFrom(YetiSimCoreLib.Components.PlantFoodGeneratorComponent other);
            /*0x41cab9c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41cabbc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PlantFoodGeneratorComponent.<> <>9;

                static /*0x41cad90*/ <>c();
                /*0x41cadf8*/ <>c();
                /*0x41cae00*/ YetiSimCoreLib.Components.PlantFoodGeneratorComponent <.cctor>b__37_0();
            }
        }

        class PlayerLoadoutComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41caeac*/ PlayerLoadoutComponentReflection();
            static /*0x41cae54*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PlayerLoadoutComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PlayerLoadoutComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PlayerLoadoutComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PlayerLoadoutComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PlayerLoadoutComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isAllCooldownsPaused_;

            static /*0x41cb864*/ PlayerLoadoutComponent();
            static /*0x41cb2fc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PlayerLoadoutComponent> get_Parser();
            static /*0x41cb354*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41cb4a4*/ PlayerLoadoutComponent();
            /*0x41cb4ac*/ PlayerLoadoutComponent(YetiSimCoreLib.Components.PlayerLoadoutComponent other);
            /*0x41cb458*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41cb4f8*/ YetiSimCoreLib.Components.PlayerLoadoutComponent Clone();
            /*0x41cb550*/ bool get_IsAllCooldownsPaused();
            /*0x41cb558*/ void set_IsAllCooldownsPaused(bool value);
            /*0x41cb560*/ bool Equals(object other);
            /*0x41cb5c4*/ bool Equals(YetiSimCoreLib.Components.PlayerLoadoutComponent other);
            /*0x41cb610*/ int GetHashCode();
            /*0x41cb680*/ string ToString();
            /*0x41cb6d8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41cb6f8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41cb758*/ int CalculateSize();
            /*0x41cb784*/ void MergeFrom(YetiSimCoreLib.Components.PlayerLoadoutComponent other);
            /*0x41cb7c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41cb7e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PlayerLoadoutComponent.<> <>9;

                static /*0x41cb97c*/ <>c();
                /*0x41cb9e4*/ <>c();
                /*0x41cb9ec*/ YetiSimCoreLib.Components.PlayerLoadoutComponent <.cctor>b__27_0();
            }
        }

        class PositionComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41cba98*/ PositionComponentReflection();
            static /*0x41cba40*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PositionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PositionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PositionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PositionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PositionComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int x_;
            /*0x1c*/ int y_;
            /*0x20*/ int z_;
            /*0x24*/ int topLaneBounds_;
            /*0x28*/ int bottomLaneBounds_;

            static /*0x41cc850*/ PositionComponent();
            static /*0x41cbfb8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PositionComponent> get_Parser();
            static /*0x41cc010*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41cc160*/ PositionComponent();
            /*0x41cc168*/ PositionComponent(YetiSimCoreLib.Components.PositionComponent other);
            /*0x41cc114*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41cc1bc*/ YetiSimCoreLib.Components.PositionComponent Clone();
            /*0x41cc214*/ int get_X();
            /*0x41cc21c*/ void set_X(int value);
            /*0x41cc224*/ int get_Y();
            /*0x41cc22c*/ void set_Y(int value);
            /*0x41cc234*/ int get_Z();
            /*0x41cc23c*/ void set_Z(int value);
            /*0x41cc244*/ int get_TopLaneBounds();
            /*0x41cc24c*/ void set_TopLaneBounds(int value);
            /*0x41cc254*/ int get_BottomLaneBounds();
            /*0x41cc25c*/ void set_BottomLaneBounds(int value);
            /*0x41cc264*/ bool Equals(object other);
            /*0x41cc2c8*/ bool Equals(YetiSimCoreLib.Components.PositionComponent other);
            /*0x41cc344*/ int GetHashCode();
            /*0x41cc410*/ string ToString();
            /*0x41cc468*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41cc488*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41cc588*/ int CalculateSize();
            /*0x41cc6c0*/ void MergeFrom(YetiSimCoreLib.Components.PositionComponent other);
            /*0x41cc730*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41cc750*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PositionComponent.<> <>9;

                static /*0x41cc968*/ <>c();
                /*0x41cc9d0*/ <>c();
                /*0x41cc9d8*/ YetiSimCoreLib.Components.PositionComponent <.cctor>b__47_0();
            }
        }

        class PreBattleBoostComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41cca84*/ PreBattleBoostComponentReflection();
            static /*0x41cca2c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PreBattleBoostComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PreBattleBoostComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PreBattleBoostComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PreBattleBoostComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreBattleBoostComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41cd240*/ PreBattleBoostComponent();
            static /*0x41ccdcc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreBattleBoostComponent> get_Parser();
            static /*0x41cce24*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ccf74*/ PreBattleBoostComponent();
            /*0x41ccf7c*/ PreBattleBoostComponent(YetiSimCoreLib.Components.PreBattleBoostComponent other);
            /*0x41ccf28*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ccfc0*/ YetiSimCoreLib.Components.PreBattleBoostComponent Clone();
            /*0x41cd018*/ bool Equals(object other);
            /*0x41cd09c*/ bool Equals(YetiSimCoreLib.Components.PreBattleBoostComponent other);
            /*0x41cd0c8*/ int GetHashCode();
            /*0x41cd0f4*/ string ToString();
            /*0x41cd14c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41cd16c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41cd180*/ int CalculateSize();
            /*0x41cd194*/ void MergeFrom(YetiSimCoreLib.Components.PreBattleBoostComponent other);
            /*0x41cd1c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41cd1e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PreBattleBoostComponent.<> <>9;

                static /*0x41cd358*/ <>c();
                /*0x41cd3c0*/ <>c();
                /*0x41cd3c8*/ YetiSimCoreLib.Components.PreBattleBoostComponent <.cctor>b__22_0();
            }
        }

        class PredictedDamageComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41cd474*/ PredictedDamageComponentReflection();
            static /*0x41cd41c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PredictedDamageComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PredictedDamageComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PredictedDamageComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PredictedDamageComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PredictedDamageComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int damageAmount_;
            /*0x1c*/ int armorDamageAmount_;

            static /*0x41ce140*/ PredictedDamageComponent();
            static /*0x41cdaf0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PredictedDamageComponent> get_Parser();
            static /*0x41cdb48*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41cdc98*/ PredictedDamageComponent();
            /*0x41cdca0*/ PredictedDamageComponent(YetiSimCoreLib.Components.PredictedDamageComponent other);
            /*0x41cdc4c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41cdcec*/ YetiSimCoreLib.Components.PredictedDamageComponent Clone();
            /*0x41cdd44*/ int get_DamageAmount();
            /*0x41cdd4c*/ void set_DamageAmount(int value);
            /*0x41cdd54*/ int get_ArmorDamageAmount();
            /*0x41cdd5c*/ void set_ArmorDamageAmount(int value);
            /*0x41cdd64*/ bool Equals(object other);
            /*0x41cddc8*/ bool Equals(YetiSimCoreLib.Components.PredictedDamageComponent other);
            /*0x41cde14*/ int GetHashCode();
            /*0x41cde8c*/ string ToString();
            /*0x41cdee4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41cdf04*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41cdf8c*/ int CalculateSize();
            /*0x41ce040*/ void MergeFrom(YetiSimCoreLib.Components.PredictedDamageComponent other);
            /*0x41ce08c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ce0ac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PredictedDamageComponent.<> <>9;

                static /*0x41ce258*/ <>c();
                /*0x41ce2c0*/ <>c();
                /*0x41ce2c8*/ YetiSimCoreLib.Components.PredictedDamageComponent <.cctor>b__32_0();
            }
        }

        class DamagePredictorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DamagePredictorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DamagePredictorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DamagePredictorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamagePredictorComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int damageAmount_;
            /*0x1c*/ int armorDamageAmount_;
            /*0x20*/ int targetId_;

            static /*0x41cea38*/ DamagePredictorComponent();
            static /*0x41ce31c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamagePredictorComponent> get_Parser();
            static /*0x41ce374*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ce4c4*/ DamagePredictorComponent();
            /*0x41ce4cc*/ DamagePredictorComponent(YetiSimCoreLib.Components.DamagePredictorComponent other);
            /*0x41ce478*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ce520*/ YetiSimCoreLib.Components.DamagePredictorComponent Clone();
            /*0x41ce578*/ int get_DamageAmount();
            /*0x41ce580*/ void set_DamageAmount(int value);
            /*0x41ce588*/ int get_ArmorDamageAmount();
            /*0x41ce590*/ void set_ArmorDamageAmount(int value);
            /*0x41ce598*/ int get_TargetId();
            /*0x41ce5a0*/ void set_TargetId(int value);
            /*0x41ce5a8*/ bool Equals(object other);
            /*0x41ce60c*/ bool Equals(YetiSimCoreLib.Components.DamagePredictorComponent other);
            /*0x41ce668*/ int GetHashCode();
            /*0x41ce6fc*/ string ToString();
            /*0x41ce754*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ce774*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41ce824*/ int CalculateSize();
            /*0x41ce904*/ void MergeFrom(YetiSimCoreLib.Components.DamagePredictorComponent other);
            /*0x41ce95c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ce97c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DamagePredictorComponent.<> <>9;

                static /*0x41ceb50*/ <>c();
                /*0x41cebb8*/ <>c();
                /*0x41cebc0*/ YetiSimCoreLib.Components.DamagePredictorComponent <.cctor>b__37_0();
            }
        }

        class PredictedGridCellOccupancyComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41cec6c*/ PredictedGridCellOccupancyComponentReflection();
            static /*0x41cec14*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PredictedGridCellOccupancyComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_gridCellInstanceIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> gridCellInstanceIds_;

            static /*0x41cf87c*/ PredictedGridCellOccupancyComponent();
            static /*0x41cf0bc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent> get_Parser();
            static /*0x41cf114*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41cf264*/ PredictedGridCellOccupancyComponent();
            /*0x41cf2ec*/ PredictedGridCellOccupancyComponent(YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent other);
            /*0x41cf218*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41cf378*/ YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent Clone();
            /*0x41cf3d0*/ Google.Protobuf.Collections.RepeatedField<int> get_GridCellInstanceIds();
            /*0x41cf3d8*/ bool Equals(object other);
            /*0x41cf43c*/ bool Equals(YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent other);
            /*0x41cf4cc*/ int GetHashCode();
            /*0x41cf518*/ string ToString();
            /*0x41cf570*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41cf590*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41cf648*/ int CalculateSize();
            /*0x41cf6f0*/ void MergeFrom(YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent other);
            /*0x41cf778*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41cf798*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent.<> <>9;

                static /*0x41cf9b8*/ <>c();
                /*0x41cfa20*/ <>c();
                /*0x41cfa28*/ YetiSimCoreLib.Components.PredictedGridCellOccupancyComponent <.cctor>b__27_0();
            }
        }

        class PredictedPositionComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41cfad0*/ PredictedPositionComponentReflection();
            static /*0x41cfa78*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PredictedPositionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PredictedPositionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PredictedPositionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PredictedPositionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PredictedPositionComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int x_;
            /*0x1c*/ int y_;
            /*0x20*/ int z_;

            static /*0x41d06a4*/ PredictedPositionComponent();
            static /*0x41cff88*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PredictedPositionComponent> get_Parser();
            static /*0x41cffe0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d0130*/ PredictedPositionComponent();
            /*0x41d0138*/ PredictedPositionComponent(YetiSimCoreLib.Components.PredictedPositionComponent other);
            /*0x41d00e4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d018c*/ YetiSimCoreLib.Components.PredictedPositionComponent Clone();
            /*0x41d01e4*/ int get_X();
            /*0x41d01ec*/ void set_X(int value);
            /*0x41d01f4*/ int get_Y();
            /*0x41d01fc*/ void set_Y(int value);
            /*0x41d0204*/ int get_Z();
            /*0x41d020c*/ void set_Z(int value);
            /*0x41d0214*/ bool Equals(object other);
            /*0x41d0278*/ bool Equals(YetiSimCoreLib.Components.PredictedPositionComponent other);
            /*0x41d02d4*/ int GetHashCode();
            /*0x41d0368*/ string ToString();
            /*0x41d03c0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d03e0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d0490*/ int CalculateSize();
            /*0x41d0570*/ void MergeFrom(YetiSimCoreLib.Components.PredictedPositionComponent other);
            /*0x41d05c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d05e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PredictedPositionComponent.<> <>9;

                static /*0x41d07bc*/ <>c();
                /*0x41d0824*/ <>c();
                /*0x41d082c*/ YetiSimCoreLib.Components.PredictedPositionComponent <.cctor>b__37_0();
            }
        }

        class PreviousPositionComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41d08d8*/ PreviousPositionComponentReflection();
            static /*0x41d0880*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PreviousPositionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PreviousPositionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PreviousPositionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PreviousPositionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreviousPositionComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int x_;
            /*0x1c*/ int y_;
            /*0x20*/ int z_;

            static /*0x41d14ac*/ PreviousPositionComponent();
            static /*0x41d0d90*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreviousPositionComponent> get_Parser();
            static /*0x41d0de8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d0f38*/ PreviousPositionComponent();
            /*0x41d0f40*/ PreviousPositionComponent(YetiSimCoreLib.Components.PreviousPositionComponent other);
            /*0x41d0eec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d0f94*/ YetiSimCoreLib.Components.PreviousPositionComponent Clone();
            /*0x41d0fec*/ int get_X();
            /*0x41d0ff4*/ void set_X(int value);
            /*0x41d0ffc*/ int get_Y();
            /*0x41d1004*/ void set_Y(int value);
            /*0x41d100c*/ int get_Z();
            /*0x41d1014*/ void set_Z(int value);
            /*0x41d101c*/ bool Equals(object other);
            /*0x41d1080*/ bool Equals(YetiSimCoreLib.Components.PreviousPositionComponent other);
            /*0x41d10dc*/ int GetHashCode();
            /*0x41d1170*/ string ToString();
            /*0x41d11c8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d11e8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d1298*/ int CalculateSize();
            /*0x41d1378*/ void MergeFrom(YetiSimCoreLib.Components.PreviousPositionComponent other);
            /*0x41d13d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d13f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PreviousPositionComponent.<> <>9;

                static /*0x41d15c4*/ <>c();
                /*0x41d162c*/ <>c();
                /*0x41d1634*/ YetiSimCoreLib.Components.PreviousPositionComponent <.cctor>b__37_0();
            }
        }

        class ProjectileComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41d16e0*/ ProjectileComponentReflection();
            static /*0x41d1688*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ProjectileComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ProjectileComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ProjectileComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ProjectileComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ProjectileComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41d3240*/ ProjectileComponent();
            static /*0x41d2dcc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ProjectileComponent> get_Parser();
            static /*0x41d2e24*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d2f74*/ ProjectileComponent();
            /*0x41d2f7c*/ ProjectileComponent(YetiSimCoreLib.Components.ProjectileComponent other);
            /*0x41d2f28*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d2fc0*/ YetiSimCoreLib.Components.ProjectileComponent Clone();
            /*0x41d3018*/ bool Equals(object other);
            /*0x41d309c*/ bool Equals(YetiSimCoreLib.Components.ProjectileComponent other);
            /*0x41d30c8*/ int GetHashCode();
            /*0x41d30f4*/ string ToString();
            /*0x41d314c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d316c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d3180*/ int CalculateSize();
            /*0x41d3194*/ void MergeFrom(YetiSimCoreLib.Components.ProjectileComponent other);
            /*0x41d31c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d31e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ProjectileComponent.<> <>9;

                static /*0x41d3358*/ <>c();
                /*0x41d33c0*/ <>c();
                /*0x41d33c8*/ YetiSimCoreLib.Components.ProjectileComponent <.cctor>b__22_0();
            }
        }

        class CollidableComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CollidableComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CollidableComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CollidableComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CollidableComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int collisionFlags_;

            static /*0x41d39a8*/ CollidableComponent();
            static /*0x41d341c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CollidableComponent> get_Parser();
            static /*0x41d3474*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d35c4*/ CollidableComponent();
            /*0x41d35cc*/ CollidableComponent(YetiSimCoreLib.Components.CollidableComponent other);
            /*0x41d3578*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d3618*/ YetiSimCoreLib.Components.CollidableComponent Clone();
            /*0x41d3670*/ int get_CollisionFlags();
            /*0x41d3678*/ void set_CollisionFlags(int value);
            /*0x41d3680*/ bool Equals(object other);
            /*0x41d36e4*/ bool Equals(YetiSimCoreLib.Components.CollidableComponent other);
            /*0x41d3720*/ int GetHashCode();
            /*0x41d377c*/ string ToString();
            /*0x41d37d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d37f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d3854*/ int CalculateSize();
            /*0x41d38d4*/ void MergeFrom(YetiSimCoreLib.Components.CollidableComponent other);
            /*0x41d3914*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d3934*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CollidableComponent.<> <>9;

                static /*0x41d3ac0*/ <>c();
                /*0x41d3b28*/ <>c();
                /*0x41d3b30*/ YetiSimCoreLib.Components.CollidableComponent <.cctor>b__27_0();
            }
        }

        class TargetedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TargetedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TargetedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TargetedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int timeInTicksRemaining_;
            /*0x1c*/ int collisionFlags_;
            /*0x20*/ int homingStrength_;

            static /*0x41d42a0*/ TargetedComponent();
            static /*0x41d3b84*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetedComponent> get_Parser();
            static /*0x41d3bdc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d3d2c*/ TargetedComponent();
            /*0x41d3d34*/ TargetedComponent(YetiSimCoreLib.Components.TargetedComponent other);
            /*0x41d3ce0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d3d88*/ YetiSimCoreLib.Components.TargetedComponent Clone();
            /*0x41d3de0*/ int get_TimeInTicksRemaining();
            /*0x41d3de8*/ void set_TimeInTicksRemaining(int value);
            /*0x41d3df0*/ int get_CollisionFlags();
            /*0x41d3df8*/ void set_CollisionFlags(int value);
            /*0x41d3e00*/ int get_HomingStrength();
            /*0x41d3e08*/ void set_HomingStrength(int value);
            /*0x41d3e10*/ bool Equals(object other);
            /*0x41d3e74*/ bool Equals(YetiSimCoreLib.Components.TargetedComponent other);
            /*0x41d3ed0*/ int GetHashCode();
            /*0x41d3f64*/ string ToString();
            /*0x41d3fbc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d3fdc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d408c*/ int CalculateSize();
            /*0x41d416c*/ void MergeFrom(YetiSimCoreLib.Components.TargetedComponent other);
            /*0x41d41c4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d41e4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TargetedComponent.<> <>9;

                static /*0x41d43b8*/ <>c();
                /*0x41d4420*/ <>c();
                /*0x41d4428*/ YetiSimCoreLib.Components.TargetedComponent <.cctor>b__37_0();
            }
        }

        class PassThroughComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PassThroughComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PassThroughComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PassThroughComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PassThroughComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_collidedTargets_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> collidedTargets_;
            /*0x20*/ int numPassThroughs_;
            /*0x24*/ int maxPassThroughs_;

            static /*0x41d4df0*/ PassThroughComponent();
            static /*0x41d447c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PassThroughComponent> get_Parser();
            static /*0x41d44d4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d4624*/ PassThroughComponent();
            /*0x41d46ac*/ PassThroughComponent(YetiSimCoreLib.Components.PassThroughComponent other);
            /*0x41d45d8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d4740*/ YetiSimCoreLib.Components.PassThroughComponent Clone();
            /*0x41d4798*/ Google.Protobuf.Collections.RepeatedField<int> get_CollidedTargets();
            /*0x41d47a0*/ int get_NumPassThroughs();
            /*0x41d47a8*/ void set_NumPassThroughs(int value);
            /*0x41d47b0*/ int get_MaxPassThroughs();
            /*0x41d47b8*/ void set_MaxPassThroughs(int value);
            /*0x41d47c0*/ bool Equals(object other);
            /*0x41d4824*/ bool Equals(YetiSimCoreLib.Components.PassThroughComponent other);
            /*0x41d48d4*/ int GetHashCode();
            /*0x41d4960*/ string ToString();
            /*0x41d49b8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d49d8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d4ae0*/ int CalculateSize();
            /*0x41d4bf8*/ void MergeFrom(YetiSimCoreLib.Components.PassThroughComponent other);
            /*0x41d4c98*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d4cb8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PassThroughComponent.<> <>9;

                static /*0x41d4f2c*/ <>c();
                /*0x41d4f94*/ <>c();
                /*0x41d4f9c*/ YetiSimCoreLib.Components.PassThroughComponent <.cctor>b__37_0();
            }
        }

        class MaxTravelDistanceXComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MaxTravelDistanceXComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MaxTravelDistanceXComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MaxTravelDistanceXComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaxTravelDistanceXComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int targetX_;
            /*0x1c*/ int velocityX_;

            static /*0x41d563c*/ MaxTravelDistanceXComponent();
            static /*0x41d4fec*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaxTravelDistanceXComponent> get_Parser();
            static /*0x41d5044*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d5194*/ MaxTravelDistanceXComponent();
            /*0x41d519c*/ MaxTravelDistanceXComponent(YetiSimCoreLib.Components.MaxTravelDistanceXComponent other);
            /*0x41d5148*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d51e8*/ YetiSimCoreLib.Components.MaxTravelDistanceXComponent Clone();
            /*0x41d5240*/ int get_TargetX();
            /*0x41d5248*/ void set_TargetX(int value);
            /*0x41d5250*/ int get_VelocityX();
            /*0x41d5258*/ void set_VelocityX(int value);
            /*0x41d5260*/ bool Equals(object other);
            /*0x41d52c4*/ bool Equals(YetiSimCoreLib.Components.MaxTravelDistanceXComponent other);
            /*0x41d5310*/ int GetHashCode();
            /*0x41d5388*/ string ToString();
            /*0x41d53e0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d5400*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d5488*/ int CalculateSize();
            /*0x41d553c*/ void MergeFrom(YetiSimCoreLib.Components.MaxTravelDistanceXComponent other);
            /*0x41d5588*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d55a8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MaxTravelDistanceXComponent.<> <>9;

                static /*0x41d5754*/ <>c();
                /*0x41d57bc*/ <>c();
                /*0x41d57c4*/ YetiSimCoreLib.Components.MaxTravelDistanceXComponent <.cctor>b__32_0();
            }
        }

        class MaxTravelDistanceComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MaxTravelDistanceComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MaxTravelDistanceComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MaxTravelDistanceComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaxTravelDistanceComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ long distanceSquared_;
            /*0x20*/ int startX_;
            /*0x24*/ int startZ_;

            static /*0x41d5f38*/ MaxTravelDistanceComponent();
            static /*0x41d5818*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaxTravelDistanceComponent> get_Parser();
            static /*0x41d5870*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d59c0*/ MaxTravelDistanceComponent();
            /*0x41d59c8*/ MaxTravelDistanceComponent(YetiSimCoreLib.Components.MaxTravelDistanceComponent other);
            /*0x41d5974*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d5a18*/ YetiSimCoreLib.Components.MaxTravelDistanceComponent Clone();
            /*0x41d5a70*/ long get_DistanceSquared();
            /*0x41d5a78*/ void set_DistanceSquared(long value);
            /*0x41d5a80*/ int get_StartX();
            /*0x41d5a88*/ void set_StartX(int value);
            /*0x41d5a90*/ int get_StartZ();
            /*0x41d5a98*/ void set_StartZ(int value);
            /*0x41d5aa0*/ bool Equals(object other);
            /*0x41d5b04*/ bool Equals(YetiSimCoreLib.Components.MaxTravelDistanceComponent other);
            /*0x41d5b60*/ int GetHashCode();
            /*0x41d5bfc*/ string ToString();
            /*0x41d5c54*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d5c74*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d5d24*/ int CalculateSize();
            /*0x41d5e04*/ void MergeFrom(YetiSimCoreLib.Components.MaxTravelDistanceComponent other);
            /*0x41d5e5c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d5e7c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MaxTravelDistanceComponent.<> <>9;

                static /*0x41d6050*/ <>c();
                /*0x41d60b8*/ <>c();
                /*0x41d60c0*/ YetiSimCoreLib.Components.MaxTravelDistanceComponent <.cctor>b__37_0();
            }
        }

        class OrbiterComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OrbiterComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OrbiterComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OrbiterComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OrbiterComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int orbitTicksTotal_;
            /*0x1c*/ int orbitTicksRemaining_;
            /*0x20*/ int orbitRadius_;
            /*0x28*/ long rawStartingAngle_;
            /*0x30*/ int parentBodyId_;
            /*0x34*/ bool hitTargetsInRadius_;
            /*0x38*/ long rawCurrentAngle_;
            /*0x40*/ long rawLastAngle_;
            /*0x48*/ int orbitCenterX_;
            /*0x4c*/ int orbitCenterZ_;

            static /*0x41d6dc0*/ OrbiterComponent();
            static /*0x41d6114*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OrbiterComponent> get_Parser();
            static /*0x41d616c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d62bc*/ OrbiterComponent();
            /*0x41d62c4*/ OrbiterComponent(YetiSimCoreLib.Components.OrbiterComponent other);
            /*0x41d6270*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d6340*/ YetiSimCoreLib.Components.OrbiterComponent Clone();
            /*0x41d6398*/ int get_OrbitTicksTotal();
            /*0x41d63a0*/ void set_OrbitTicksTotal(int value);
            /*0x41d63a8*/ int get_OrbitTicksRemaining();
            /*0x41d63b0*/ void set_OrbitTicksRemaining(int value);
            /*0x41d63b8*/ int get_OrbitRadius();
            /*0x41d63c0*/ void set_OrbitRadius(int value);
            /*0x41d63c8*/ long get_RawStartingAngle();
            /*0x41d63d0*/ void set_RawStartingAngle(long value);
            /*0x41d63d8*/ int get_ParentBodyId();
            /*0x41d63e0*/ void set_ParentBodyId(int value);
            /*0x41d63e8*/ bool get_HitTargetsInRadius();
            /*0x41d63f0*/ void set_HitTargetsInRadius(bool value);
            /*0x41d63f8*/ long get_RawCurrentAngle();
            /*0x41d6400*/ void set_RawCurrentAngle(long value);
            /*0x41d6408*/ long get_RawLastAngle();
            /*0x41d6410*/ void set_RawLastAngle(long value);
            /*0x41d6418*/ int get_OrbitCenterX();
            /*0x41d6420*/ void set_OrbitCenterX(int value);
            /*0x41d6428*/ int get_OrbitCenterZ();
            /*0x41d6430*/ void set_OrbitCenterZ(int value);
            /*0x41d6438*/ bool Equals(object other);
            /*0x41d649c*/ bool Equals(YetiSimCoreLib.Components.OrbiterComponent other);
            /*0x41d6578*/ int GetHashCode();
            /*0x41d66f8*/ string ToString();
            /*0x41d6750*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d6770*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d6938*/ int CalculateSize();
            /*0x41d6b38*/ void MergeFrom(YetiSimCoreLib.Components.OrbiterComponent other);
            /*0x41d6be8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d6c08*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OrbiterComponent.<> <>9;

                static /*0x41d6ed8*/ <>c();
                /*0x41d6f40*/ <>c();
                /*0x41d6f48*/ YetiSimCoreLib.Components.OrbiterComponent <.cctor>b__72_0();
            }
        }

        class OrbitingParentBodyComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.OrbitingParentBodyComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.OrbitingParentBodyComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.OrbitingParentBodyComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OrbitingParentBodyComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_orbiterIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> orbiterIds_;

            static /*0x41d775c*/ OrbitingParentBodyComponent();
            static /*0x41d6f9c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.OrbitingParentBodyComponent> get_Parser();
            static /*0x41d6ff4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d7144*/ OrbitingParentBodyComponent();
            /*0x41d71cc*/ OrbitingParentBodyComponent(YetiSimCoreLib.Components.OrbitingParentBodyComponent other);
            /*0x41d70f8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d7258*/ YetiSimCoreLib.Components.OrbitingParentBodyComponent Clone();
            /*0x41d72b0*/ Google.Protobuf.Collections.RepeatedField<int> get_OrbiterIds();
            /*0x41d72b8*/ bool Equals(object other);
            /*0x41d731c*/ bool Equals(YetiSimCoreLib.Components.OrbitingParentBodyComponent other);
            /*0x41d73ac*/ int GetHashCode();
            /*0x41d73f8*/ string ToString();
            /*0x41d7450*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d7470*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d7528*/ int CalculateSize();
            /*0x41d75d0*/ void MergeFrom(YetiSimCoreLib.Components.OrbitingParentBodyComponent other);
            /*0x41d7658*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d7678*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.OrbitingParentBodyComponent.<> <>9;

                static /*0x41d7898*/ <>c();
                /*0x41d7900*/ <>c();
                /*0x41d7908*/ YetiSimCoreLib.Components.OrbitingParentBodyComponent <.cctor>b__27_0();
            }
        }

        class RicochetComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RicochetComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RicochetComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RicochetComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RicochetComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int numRicochets_;
            /*0x1c*/ int maxRicochets_;
            /*0x20*/ int speed_;
            /*0x24*/ Yeti.Data.DirectionType orientation_;
            /*0x28*/ int initialAngleIndex_;
            /*0x2c*/ int lastCollisionId_;

            static /*0x41d82ac*/ RicochetComponent();
            static /*0x41d7958*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RicochetComponent> get_Parser();
            static /*0x41d79b0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d7b00*/ RicochetComponent();
            /*0x41d7b08*/ RicochetComponent(YetiSimCoreLib.Components.RicochetComponent other);
            /*0x41d7ab4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d7b5c*/ YetiSimCoreLib.Components.RicochetComponent Clone();
            /*0x41d7bb4*/ int get_NumRicochets();
            /*0x41d7bbc*/ void set_NumRicochets(int value);
            /*0x41d7bc4*/ int get_MaxRicochets();
            /*0x41d7bcc*/ void set_MaxRicochets(int value);
            /*0x41d7bd4*/ int get_Speed();
            /*0x41d7bdc*/ void set_Speed(int value);
            /*0x41d7be4*/ Yeti.Data.DirectionType get_Orientation();
            /*0x41d7bec*/ void set_Orientation(Yeti.Data.DirectionType value);
            /*0x41d7bf4*/ int get_InitialAngleIndex();
            /*0x41d7bfc*/ void set_InitialAngleIndex(int value);
            /*0x41d7c04*/ int get_LastCollisionId();
            /*0x41d7c0c*/ void set_LastCollisionId(int value);
            /*0x41d7c14*/ bool Equals(object other);
            /*0x41d7c78*/ bool Equals(YetiSimCoreLib.Components.RicochetComponent other);
            /*0x41d7d04*/ int GetHashCode();
            /*0x41d7dec*/ string ToString();
            /*0x41d7e44*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d7e64*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d7f8c*/ int CalculateSize();
            /*0x41d80f0*/ void MergeFrom(YetiSimCoreLib.Components.RicochetComponent other);
            /*0x41d816c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d818c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RicochetComponent.<> <>9;

                static /*0x41d83c4*/ <>c();
                /*0x41d842c*/ <>c();
                /*0x41d8434*/ YetiSimCoreLib.Components.RicochetComponent <.cctor>b__52_0();
            }
        }

        class VerticalOffsetComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.VerticalOffsetComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.VerticalOffsetComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.VerticalOffsetComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.VerticalOffsetComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int offset_;

            static /*0x41d8a14*/ VerticalOffsetComponent();
            static /*0x41d8488*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.VerticalOffsetComponent> get_Parser();
            static /*0x41d84e0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d8630*/ VerticalOffsetComponent();
            /*0x41d8638*/ VerticalOffsetComponent(YetiSimCoreLib.Components.VerticalOffsetComponent other);
            /*0x41d85e4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d8684*/ YetiSimCoreLib.Components.VerticalOffsetComponent Clone();
            /*0x41d86dc*/ int get_Offset();
            /*0x41d86e4*/ void set_Offset(int value);
            /*0x41d86ec*/ bool Equals(object other);
            /*0x41d8750*/ bool Equals(YetiSimCoreLib.Components.VerticalOffsetComponent other);
            /*0x41d878c*/ int GetHashCode();
            /*0x41d87e8*/ string ToString();
            /*0x41d8840*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d8860*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d88c0*/ int CalculateSize();
            /*0x41d8940*/ void MergeFrom(YetiSimCoreLib.Components.VerticalOffsetComponent other);
            /*0x41d8980*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d89a0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.VerticalOffsetComponent.<> <>9;

                static /*0x41d8b2c*/ <>c();
                /*0x41d8b94*/ <>c();
                /*0x41d8b9c*/ YetiSimCoreLib.Components.VerticalOffsetComponent <.cctor>b__27_0();
            }
        }

        class PromotedComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41d8c48*/ PromotedComponentReflection();
            static /*0x41d8bf0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class PromotedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PromotedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PromotedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PromotedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PromotedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41d9404*/ PromotedComponent();
            static /*0x41d8f90*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PromotedComponent> get_Parser();
            static /*0x41d8fe8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d9138*/ PromotedComponent();
            /*0x41d9140*/ PromotedComponent(YetiSimCoreLib.Components.PromotedComponent other);
            /*0x41d90ec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d9184*/ YetiSimCoreLib.Components.PromotedComponent Clone();
            /*0x41d91dc*/ bool Equals(object other);
            /*0x41d9260*/ bool Equals(YetiSimCoreLib.Components.PromotedComponent other);
            /*0x41d928c*/ int GetHashCode();
            /*0x41d92b8*/ string ToString();
            /*0x41d9310*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d9330*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d9344*/ int CalculateSize();
            /*0x41d9358*/ void MergeFrom(YetiSimCoreLib.Components.PromotedComponent other);
            /*0x41d938c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d93ac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PromotedComponent.<> <>9;

                static /*0x41d951c*/ <>c();
                /*0x41d9584*/ <>c();
                /*0x41d958c*/ YetiSimCoreLib.Components.PromotedComponent <.cctor>b__22_0();
            }
        }

        class RandomAbilityBehaviorComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41d9638*/ RandomAbilityBehaviorComponentReflection();
            static /*0x41d95e0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class RandomAbilityBehaviorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RandomAbilityBehaviorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RandomAbilityBehaviorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RandomAbilityBehaviorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RandomAbilityBehaviorComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41d9df4*/ RandomAbilityBehaviorComponent();
            static /*0x41d9980*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RandomAbilityBehaviorComponent> get_Parser();
            static /*0x41d99d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41d9b28*/ RandomAbilityBehaviorComponent();
            /*0x41d9b30*/ RandomAbilityBehaviorComponent(YetiSimCoreLib.Components.RandomAbilityBehaviorComponent other);
            /*0x41d9adc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41d9b74*/ YetiSimCoreLib.Components.RandomAbilityBehaviorComponent Clone();
            /*0x41d9bcc*/ bool Equals(object other);
            /*0x41d9c50*/ bool Equals(YetiSimCoreLib.Components.RandomAbilityBehaviorComponent other);
            /*0x41d9c7c*/ int GetHashCode();
            /*0x41d9ca8*/ string ToString();
            /*0x41d9d00*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41d9d20*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41d9d34*/ int CalculateSize();
            /*0x41d9d48*/ void MergeFrom(YetiSimCoreLib.Components.RandomAbilityBehaviorComponent other);
            /*0x41d9d7c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41d9d9c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RandomAbilityBehaviorComponent.<> <>9;

                static /*0x41d9f0c*/ <>c();
                /*0x41d9f74*/ <>c();
                /*0x41d9f7c*/ YetiSimCoreLib.Components.RandomAbilityBehaviorComponent <.cctor>b__22_0();
            }
        }

        class RapidFireComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41da028*/ RapidFireComponentReflection();
            static /*0x41d9fd0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class RapidFireComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RapidFireComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RapidFireComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RapidFireComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IAttackCounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RapidFireComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int attacksRemaining_;

            static /*0x41da950*/ RapidFireComponent();
            static /*0x41da3c4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RapidFireComponent> get_Parser();
            static /*0x41da41c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41da56c*/ RapidFireComponent();
            /*0x41da574*/ RapidFireComponent(YetiSimCoreLib.Components.RapidFireComponent other);
            /*0x41da520*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41da5c0*/ YetiSimCoreLib.Components.RapidFireComponent Clone();
            /*0x41da618*/ int get_AttacksRemaining();
            /*0x41da620*/ void set_AttacksRemaining(int value);
            /*0x41da628*/ bool Equals(object other);
            /*0x41da68c*/ bool Equals(YetiSimCoreLib.Components.RapidFireComponent other);
            /*0x41da6c8*/ int GetHashCode();
            /*0x41da724*/ string ToString();
            /*0x41da77c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41da79c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41da7fc*/ int CalculateSize();
            /*0x41da87c*/ void MergeFrom(YetiSimCoreLib.Components.RapidFireComponent other);
            /*0x41da8bc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41da8dc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RapidFireComponent.<> <>9;

                static /*0x41daa68*/ <>c();
                /*0x41daad0*/ <>c();
                /*0x41daad8*/ YetiSimCoreLib.Components.RapidFireComponent <.cctor>b__27_0();
            }
        }

        class ReflectDamageComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41dab84*/ ReflectDamageComponentReflection();
            static /*0x41dab2c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ReflectDamageComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ReflectDamageComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ReflectDamageComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ReflectDamageComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ReflectDamageComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41db340*/ ReflectDamageComponent();
            static /*0x41daecc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ReflectDamageComponent> get_Parser();
            static /*0x41daf24*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41db074*/ ReflectDamageComponent();
            /*0x41db07c*/ ReflectDamageComponent(YetiSimCoreLib.Components.ReflectDamageComponent other);
            /*0x41db028*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41db0c0*/ YetiSimCoreLib.Components.ReflectDamageComponent Clone();
            /*0x41db118*/ bool Equals(object other);
            /*0x41db19c*/ bool Equals(YetiSimCoreLib.Components.ReflectDamageComponent other);
            /*0x41db1c8*/ int GetHashCode();
            /*0x41db1f4*/ string ToString();
            /*0x41db24c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41db26c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41db280*/ int CalculateSize();
            /*0x41db294*/ void MergeFrom(YetiSimCoreLib.Components.ReflectDamageComponent other);
            /*0x41db2c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41db2e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ReflectDamageComponent.<> <>9;

                static /*0x41db458*/ <>c();
                /*0x41db4c0*/ <>c();
                /*0x41db4c8*/ YetiSimCoreLib.Components.ReflectDamageComponent <.cctor>b__22_0();
            }
        }

        class ResistanceStatTagRequirementComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41db574*/ ResistanceStatTagRequirementComponentReflection();
            static /*0x41db51c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ResistanceStatTagRequirementComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry> _repeated_entries_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry> entries_;

            static /*0x41dc3d8*/ ResistanceStatTagRequirementComponent();
            static /*0x41dbc20*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent> get_Parser();
            static /*0x41dbc78*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41dbdc8*/ ResistanceStatTagRequirementComponent();
            /*0x41dbe50*/ ResistanceStatTagRequirementComponent(YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent other);
            /*0x41dbd7c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41dbedc*/ YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent Clone();
            /*0x41dbf34*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry> get_Entries();
            /*0x41dbf3c*/ bool Equals(object other);
            /*0x41dbfa0*/ bool Equals(YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent other);
            /*0x41dc030*/ int GetHashCode();
            /*0x41dc07c*/ string ToString();
            /*0x41dc0d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41dc0f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41dc1ac*/ int CalculateSize();
            /*0x41dc254*/ void MergeFrom(YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent other);
            /*0x41dc2dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41dc2fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent.<> <>9;

                static /*0x41dc588*/ <>c();
                /*0x41dc5f0*/ <>c();
                /*0x41dc5f8*/ YetiSimCoreLib.Components.ResistanceStatTagRequirementComponent <.cctor>b__27_0();
            }
        }

        class ResistanceStatTagRequirementEntry : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_tags_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.StatType stat_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> tags_;

            static /*0x41dcf00*/ ResistanceStatTagRequirementEntry();
            static /*0x41dc648*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry> get_Parser();
            static /*0x41dc6a0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41dc7f0*/ ResistanceStatTagRequirementEntry();
            /*0x41dc878*/ ResistanceStatTagRequirementEntry(YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry other);
            /*0x41dc7a4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41dc90c*/ YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry Clone();
            /*0x41dc964*/ Yeti.Data.StatType get_Stat();
            /*0x41dc96c*/ void set_Stat(Yeti.Data.StatType value);
            /*0x41dc974*/ Google.Protobuf.Collections.RepeatedField<int> get_Tags();
            /*0x41dc97c*/ bool Equals(object other);
            /*0x41dc9e0*/ bool Equals(YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry other);
            /*0x41dca80*/ int GetHashCode();
            /*0x41dcafc*/ string ToString();
            /*0x41dcb54*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41dcb74*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41dcc54*/ int CalculateSize();
            /*0x41dcd48*/ void MergeFrom(YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry other);
            /*0x41dcddc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41dcdfc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry.<> <>9;

                static /*0x41dd03c*/ <>c();
                /*0x41dd0a4*/ <>c();
                /*0x41dd0ac*/ YetiSimCoreLib.Components.ResistanceStatTagRequirementEntry <.cctor>b__32_0();
            }
        }

        class ResourceBanksComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41dd154*/ ResourceBanksComponentReflection();
            static /*0x41dd0fc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ResourceBanksComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ResourceBanksComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ResourceBanksComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ResourceBanksComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ResourceBanksComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.ResourceBank sun_;
            /*0x20*/ Yeti.Data.ResourceBank plantFood_;
            /*0x28*/ Yeti.Data.ResourceBank promotions_;

            static /*0x41de07c*/ ResourceBanksComponent();
            static /*0x41dd6ec*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ResourceBanksComponent> get_Parser();
            static /*0x41dd744*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41dd894*/ ResourceBanksComponent();
            /*0x41dd89c*/ ResourceBanksComponent(YetiSimCoreLib.Components.ResourceBanksComponent other);
            /*0x41dd848*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41dd95c*/ YetiSimCoreLib.Components.ResourceBanksComponent Clone();
            /*0x41dd9b4*/ Yeti.Data.ResourceBank get_Sun();
            /*0x41dd9bc*/ void set_Sun(Yeti.Data.ResourceBank value);
            /*0x41dd9c4*/ Yeti.Data.ResourceBank get_PlantFood();
            /*0x41dd9cc*/ void set_PlantFood(Yeti.Data.ResourceBank value);
            /*0x41dd9d4*/ Yeti.Data.ResourceBank get_Promotions();
            /*0x41dd9dc*/ void set_Promotions(Yeti.Data.ResourceBank value);
            /*0x41dd9e4*/ bool Equals(object other);
            /*0x41dda48*/ bool Equals(YetiSimCoreLib.Components.ResourceBanksComponent other);
            /*0x41ddad0*/ int GetHashCode();
            /*0x41ddb54*/ string ToString();
            /*0x41ddbac*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ddbcc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41ddc7c*/ int CalculateSize();
            /*0x41ddd5c*/ void MergeFrom(YetiSimCoreLib.Components.ResourceBanksComponent other);
            /*0x41dded0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ddef0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ResourceBanksComponent.<> <>9;

                static /*0x41de194*/ <>c();
                /*0x41de1fc*/ <>c();
                /*0x41de204*/ YetiSimCoreLib.Components.ResourceBanksComponent <.cctor>b__37_0();
            }
        }

        class ScoringComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41de2b0*/ ScoringComponentReflection();
            static /*0x41de258*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ScoringComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ScoringComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ScoringComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ScoringComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ScoringComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.ScoringRecords scoringRecords_;
            /*0x20*/ bool shouldCheckMovedUnits_;

            static /*0x41defbc*/ ScoringComponent();
            static /*0x41de7e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ScoringComponent> get_Parser();
            static /*0x41de838*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41de988*/ ScoringComponent();
            /*0x41de990*/ ScoringComponent(YetiSimCoreLib.Components.ScoringComponent other);
            /*0x41de93c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41dea08*/ YetiSimCoreLib.Components.ScoringComponent Clone();
            /*0x41dea60*/ Yeti.Data.ScoringRecords get_ScoringRecords();
            /*0x41dea68*/ void set_ScoringRecords(Yeti.Data.ScoringRecords value);
            /*0x41dea70*/ bool get_ShouldCheckMovedUnits();
            /*0x41dea78*/ void set_ShouldCheckMovedUnits(bool value);
            /*0x41dea80*/ bool Equals(object other);
            /*0x41deae4*/ bool Equals(YetiSimCoreLib.Components.ScoringComponent other);
            /*0x41deb64*/ int GetHashCode();
            /*0x41debf4*/ string ToString();
            /*0x41dec4c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41dec6c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41decf4*/ int CalculateSize();
            /*0x41ded8c*/ void MergeFrom(YetiSimCoreLib.Components.ScoringComponent other);
            /*0x41dee68*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41dee88*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ScoringComponent.<> <>9;

                static /*0x41df0d4*/ <>c();
                /*0x41df13c*/ <>c();
                /*0x41df144*/ YetiSimCoreLib.Components.ScoringComponent <.cctor>b__32_0();
            }
        }

        class ShovelComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41df1f0*/ ShovelComponentReflection();
            static /*0x41df198*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class ShovelComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ShovelComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ShovelComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ShovelComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ShovelComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.ShovelConfig config_;
            /*0x20*/ int totalCooldownTicks_;
            /*0x24*/ int cooldownTicksRemaining_;
            /*0x28*/ bool cooldownDisabled_;

            static /*0x41e013c*/ ShovelComponent();
            static /*0x41df7bc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ShovelComponent> get_Parser();
            static /*0x41df814*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41df964*/ ShovelComponent();
            /*0x41df96c*/ ShovelComponent(YetiSimCoreLib.Components.ShovelComponent other);
            /*0x41df918*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41df9ec*/ YetiSimCoreLib.Components.ShovelComponent Clone();
            /*0x41dfa44*/ Yeti.Data.ShovelConfig get_Config();
            /*0x41dfa4c*/ void set_Config(Yeti.Data.ShovelConfig value);
            /*0x41dfa54*/ int get_TotalCooldownTicks();
            /*0x41dfa5c*/ void set_TotalCooldownTicks(int value);
            /*0x41dfa64*/ int get_CooldownTicksRemaining();
            /*0x41dfa6c*/ void set_CooldownTicksRemaining(int value);
            /*0x41dfa74*/ bool get_CooldownDisabled();
            /*0x41dfa7c*/ void set_CooldownDisabled(bool value);
            /*0x41dfa84*/ bool Equals(object other);
            /*0x41dfae8*/ bool Equals(YetiSimCoreLib.Components.ShovelComponent other);
            /*0x41dfb88*/ int GetHashCode();
            /*0x41dfc54*/ string ToString();
            /*0x41dfcac*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41dfccc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41dfda4*/ int CalculateSize();
            /*0x41dfe9c*/ void MergeFrom(YetiSimCoreLib.Components.ShovelComponent other);
            /*0x41dff90*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41dffb0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ShovelComponent.<> <>9;

                static /*0x41e0254*/ <>c();
                /*0x41e02bc*/ <>c();
                /*0x41e02c4*/ YetiSimCoreLib.Components.ShovelComponent <.cctor>b__42_0();
            }
        }

        class SpawnedTrackerComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41e0370*/ SpawnedTrackerComponentReflection();
            static /*0x41e0318*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class SpawnedTrackerComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SpawnedTrackerComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SpawnedTrackerComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SpawnedTrackerComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SpawnedTrackerComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int spawnedAtTick_;
            /*0x1c*/ int spawnX_;

            static /*0x41e0e44*/ SpawnedTrackerComponent();
            static /*0x41e07f4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SpawnedTrackerComponent> get_Parser();
            static /*0x41e084c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e099c*/ SpawnedTrackerComponent();
            /*0x41e09a4*/ SpawnedTrackerComponent(YetiSimCoreLib.Components.SpawnedTrackerComponent other);
            /*0x41e0950*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e09f0*/ YetiSimCoreLib.Components.SpawnedTrackerComponent Clone();
            /*0x41e0a48*/ int get_SpawnedAtTick();
            /*0x41e0a50*/ void set_SpawnedAtTick(int value);
            /*0x41e0a58*/ int get_SpawnX();
            /*0x41e0a60*/ void set_SpawnX(int value);
            /*0x41e0a68*/ bool Equals(object other);
            /*0x41e0acc*/ bool Equals(YetiSimCoreLib.Components.SpawnedTrackerComponent other);
            /*0x41e0b18*/ int GetHashCode();
            /*0x41e0b90*/ string ToString();
            /*0x41e0be8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e0c08*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e0c90*/ int CalculateSize();
            /*0x41e0d44*/ void MergeFrom(YetiSimCoreLib.Components.SpawnedTrackerComponent other);
            /*0x41e0d90*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e0db0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SpawnedTrackerComponent.<> <>9;

                static /*0x41e0f5c*/ <>c();
                /*0x41e0fc4*/ <>c();
                /*0x41e0fcc*/ YetiSimCoreLib.Components.SpawnedTrackerComponent <.cctor>b__32_0();
            }
        }

        class SpawnPositionComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41e1078*/ SpawnPositionComponentReflection();
            static /*0x41e1020*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class SpawnPositionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SpawnPositionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SpawnPositionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SpawnPositionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SpawnPositionComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int x_;
            /*0x1c*/ int y_;
            /*0x20*/ int z_;

            static /*0x41e1c4c*/ SpawnPositionComponent();
            static /*0x41e1530*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SpawnPositionComponent> get_Parser();
            static /*0x41e1588*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e16d8*/ SpawnPositionComponent();
            /*0x41e16e0*/ SpawnPositionComponent(YetiSimCoreLib.Components.SpawnPositionComponent other);
            /*0x41e168c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e1734*/ YetiSimCoreLib.Components.SpawnPositionComponent Clone();
            /*0x41e178c*/ int get_X();
            /*0x41e1794*/ void set_X(int value);
            /*0x41e179c*/ int get_Y();
            /*0x41e17a4*/ void set_Y(int value);
            /*0x41e17ac*/ int get_Z();
            /*0x41e17b4*/ void set_Z(int value);
            /*0x41e17bc*/ bool Equals(object other);
            /*0x41e1820*/ bool Equals(YetiSimCoreLib.Components.SpawnPositionComponent other);
            /*0x41e187c*/ int GetHashCode();
            /*0x41e1910*/ string ToString();
            /*0x41e1968*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e1988*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e1a38*/ int CalculateSize();
            /*0x41e1b18*/ void MergeFrom(YetiSimCoreLib.Components.SpawnPositionComponent other);
            /*0x41e1b70*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e1b90*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SpawnPositionComponent.<> <>9;

                static /*0x41e1d64*/ <>c();
                /*0x41e1dcc*/ <>c();
                /*0x41e1dd4*/ YetiSimCoreLib.Components.SpawnPositionComponent <.cctor>b__37_0();
            }
        }

        class SplitHitComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41e1e80*/ SplitHitComponentReflection();
            static /*0x41e1e28*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class SplitHitComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SplitHitComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SplitHitComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SplitHitComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IAttackCounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SplitHitComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int attacksRemaining_;

            static /*0x41e27a8*/ SplitHitComponent();
            static /*0x41e221c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SplitHitComponent> get_Parser();
            static /*0x41e2274*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e23c4*/ SplitHitComponent();
            /*0x41e23cc*/ SplitHitComponent(YetiSimCoreLib.Components.SplitHitComponent other);
            /*0x41e2378*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e2418*/ YetiSimCoreLib.Components.SplitHitComponent Clone();
            /*0x41e2470*/ int get_AttacksRemaining();
            /*0x41e2478*/ void set_AttacksRemaining(int value);
            /*0x41e2480*/ bool Equals(object other);
            /*0x41e24e4*/ bool Equals(YetiSimCoreLib.Components.SplitHitComponent other);
            /*0x41e2520*/ int GetHashCode();
            /*0x41e257c*/ string ToString();
            /*0x41e25d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e25f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e2654*/ int CalculateSize();
            /*0x41e26d4*/ void MergeFrom(YetiSimCoreLib.Components.SplitHitComponent other);
            /*0x41e2714*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e2734*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SplitHitComponent.<> <>9;

                static /*0x41e28c0*/ <>c();
                /*0x41e2928*/ <>c();
                /*0x41e2930*/ YetiSimCoreLib.Components.SplitHitComponent <.cctor>b__27_0();
            }
        }

        class StaggerComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41e29dc*/ StaggerComponentReflection();
            static /*0x41e2984*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class StaggerComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StaggerComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StaggerComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StaggerComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IAttackCounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StaggerComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int attacksRemaining_;

            static /*0x41e3304*/ StaggerComponent();
            static /*0x41e2d78*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StaggerComponent> get_Parser();
            static /*0x41e2dd0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e2f20*/ StaggerComponent();
            /*0x41e2f28*/ StaggerComponent(YetiSimCoreLib.Components.StaggerComponent other);
            /*0x41e2ed4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e2f74*/ YetiSimCoreLib.Components.StaggerComponent Clone();
            /*0x41e2fcc*/ int get_AttacksRemaining();
            /*0x41e2fd4*/ void set_AttacksRemaining(int value);
            /*0x41e2fdc*/ bool Equals(object other);
            /*0x41e3040*/ bool Equals(YetiSimCoreLib.Components.StaggerComponent other);
            /*0x41e307c*/ int GetHashCode();
            /*0x41e30d8*/ string ToString();
            /*0x41e3130*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e3150*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e31b0*/ int CalculateSize();
            /*0x41e3230*/ void MergeFrom(YetiSimCoreLib.Components.StaggerComponent other);
            /*0x41e3270*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e3290*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StaggerComponent.<> <>9;

                static /*0x41e341c*/ <>c();
                /*0x41e3484*/ <>c();
                /*0x41e348c*/ YetiSimCoreLib.Components.StaggerComponent <.cctor>b__27_0();
            }
        }

        class StateComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41e3538*/ StateComponentReflection();
            static /*0x41e34e0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class StateComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StateComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StateComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StateComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StateComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int stateId_;

            static /*0x41e3e60*/ StateComponent();
            static /*0x41e38d4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StateComponent> get_Parser();
            static /*0x41e392c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e3a7c*/ StateComponent();
            /*0x41e3a84*/ StateComponent(YetiSimCoreLib.Components.StateComponent other);
            /*0x41e3a30*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e3ad0*/ YetiSimCoreLib.Components.StateComponent Clone();
            /*0x41e3b28*/ int get_StateId();
            /*0x41e3b30*/ void set_StateId(int value);
            /*0x41e3b38*/ bool Equals(object other);
            /*0x41e3b9c*/ bool Equals(YetiSimCoreLib.Components.StateComponent other);
            /*0x41e3bd8*/ int GetHashCode();
            /*0x41e3c34*/ string ToString();
            /*0x41e3c8c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e3cac*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e3d0c*/ int CalculateSize();
            /*0x41e3d8c*/ void MergeFrom(YetiSimCoreLib.Components.StateComponent other);
            /*0x41e3dcc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e3dec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StateComponent.<> <>9;

                static /*0x41e3f78*/ <>c();
                /*0x41e3fe0*/ <>c();
                /*0x41e3fe8*/ YetiSimCoreLib.Components.StateComponent <.cctor>b__27_0();
            }
        }

        class StatesReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41e4094*/ StatesReflection();
            static /*0x41e403c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class IdleComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.IdleComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.IdleComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.IdleComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IdleComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41e4d50*/ IdleComponent();
            static /*0x41e48dc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.IdleComponent> get_Parser();
            static /*0x41e4934*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e4a84*/ IdleComponent();
            /*0x41e4a8c*/ IdleComponent(YetiSimCoreLib.Components.IdleComponent other);
            /*0x41e4a38*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e4ad0*/ YetiSimCoreLib.Components.IdleComponent Clone();
            /*0x41e4b28*/ bool Equals(object other);
            /*0x41e4bac*/ bool Equals(YetiSimCoreLib.Components.IdleComponent other);
            /*0x41e4bd8*/ int GetHashCode();
            /*0x41e4c04*/ string ToString();
            /*0x41e4c5c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e4c7c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e4c90*/ int CalculateSize();
            /*0x41e4ca4*/ void MergeFrom(YetiSimCoreLib.Components.IdleComponent other);
            /*0x41e4cd8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e4cf8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.IdleComponent.<> <>9;

                static /*0x41e4e68*/ <>c();
                /*0x41e4ed0*/ <>c();
                /*0x41e4ed8*/ YetiSimCoreLib.Components.IdleComponent <.cctor>b__22_0();
            }
        }

        class MovingComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MovingComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MovingComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MovingComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MovingComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41e53a0*/ MovingComponent();
            static /*0x41e4f2c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MovingComponent> get_Parser();
            static /*0x41e4f84*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e50d4*/ MovingComponent();
            /*0x41e50dc*/ MovingComponent(YetiSimCoreLib.Components.MovingComponent other);
            /*0x41e5088*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e5120*/ YetiSimCoreLib.Components.MovingComponent Clone();
            /*0x41e5178*/ bool Equals(object other);
            /*0x41e51fc*/ bool Equals(YetiSimCoreLib.Components.MovingComponent other);
            /*0x41e5228*/ int GetHashCode();
            /*0x41e5254*/ string ToString();
            /*0x41e52ac*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e52cc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e52e0*/ int CalculateSize();
            /*0x41e52f4*/ void MergeFrom(YetiSimCoreLib.Components.MovingComponent other);
            /*0x41e5328*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e5348*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MovingComponent.<> <>9;

                static /*0x41e54b8*/ <>c();
                /*0x41e5520*/ <>c();
                /*0x41e5528*/ YetiSimCoreLib.Components.MovingComponent <.cctor>b__22_0();
            }
        }

        class AttackingComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AttackingComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AttackingComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AttackingComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AttackingComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x41e59f0*/ AttackingComponent();
            static /*0x41e557c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AttackingComponent> get_Parser();
            static /*0x41e55d4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e5724*/ AttackingComponent();
            /*0x41e572c*/ AttackingComponent(YetiSimCoreLib.Components.AttackingComponent other);
            /*0x41e56d8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e5770*/ YetiSimCoreLib.Components.AttackingComponent Clone();
            /*0x41e57c8*/ bool Equals(object other);
            /*0x41e584c*/ bool Equals(YetiSimCoreLib.Components.AttackingComponent other);
            /*0x41e5878*/ int GetHashCode();
            /*0x41e58a4*/ string ToString();
            /*0x41e58fc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e591c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e5930*/ int CalculateSize();
            /*0x41e5944*/ void MergeFrom(YetiSimCoreLib.Components.AttackingComponent other);
            /*0x41e5978*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e5998*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AttackingComponent.<> <>9;

                static /*0x41e5b08*/ <>c();
                /*0x41e5b70*/ <>c();
                /*0x41e5b78*/ YetiSimCoreLib.Components.AttackingComponent <.cctor>b__22_0();
            }
        }

        class WaitingToStartComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.WaitingToStartComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.WaitingToStartComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.WaitingToStartComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaitingToStartComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x41e6158*/ WaitingToStartComponent();
            static /*0x41e5bcc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaitingToStartComponent> get_Parser();
            static /*0x41e5c24*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e5d74*/ WaitingToStartComponent();
            /*0x41e5d7c*/ WaitingToStartComponent(YetiSimCoreLib.Components.WaitingToStartComponent other);
            /*0x41e5d28*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e5dc8*/ YetiSimCoreLib.Components.WaitingToStartComponent Clone();
            /*0x41e5e20*/ int get_TicksRemaining();
            /*0x41e5e28*/ void set_TicksRemaining(int value);
            /*0x41e5e30*/ bool Equals(object other);
            /*0x41e5e94*/ bool Equals(YetiSimCoreLib.Components.WaitingToStartComponent other);
            /*0x41e5ed0*/ int GetHashCode();
            /*0x41e5f2c*/ string ToString();
            /*0x41e5f84*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e5fa4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e6004*/ int CalculateSize();
            /*0x41e6084*/ void MergeFrom(YetiSimCoreLib.Components.WaitingToStartComponent other);
            /*0x41e60c4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e60e4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.WaitingToStartComponent.<> <>9;

                static /*0x41e6270*/ <>c();
                /*0x41e62d8*/ <>c();
                /*0x41e62e0*/ YetiSimCoreLib.Components.WaitingToStartComponent <.cctor>b__27_0();
            }
        }

        class LastActionComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LastActionComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LastActionComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LastActionComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LastActionComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int actionId_;

            static /*0x41e68c0*/ LastActionComponent();
            static /*0x41e6334*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LastActionComponent> get_Parser();
            static /*0x41e638c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41e64dc*/ LastActionComponent();
            /*0x41e64e4*/ LastActionComponent(YetiSimCoreLib.Components.LastActionComponent other);
            /*0x41e6490*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41e6530*/ YetiSimCoreLib.Components.LastActionComponent Clone();
            /*0x41e6588*/ int get_ActionId();
            /*0x41e6590*/ void set_ActionId(int value);
            /*0x41e6598*/ bool Equals(object other);
            /*0x41e65fc*/ bool Equals(YetiSimCoreLib.Components.LastActionComponent other);
            /*0x41e6638*/ int GetHashCode();
            /*0x41e6694*/ string ToString();
            /*0x41e66ec*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41e670c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41e676c*/ int CalculateSize();
            /*0x41e67ec*/ void MergeFrom(YetiSimCoreLib.Components.LastActionComponent other);
            /*0x41e682c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41e684c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LastActionComponent.<> <>9;

                static /*0x41e69d8*/ <>c();
                /*0x41e6a40*/ <>c();
                /*0x41e6a48*/ YetiSimCoreLib.Components.LastActionComponent <.cctor>b__27_0();
            }
        }

        class StatsComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x41e6af4*/ StatsComponentReflection();
            static /*0x41e6a9c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class StatModifier : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StatModifier>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StatModifier>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StatModifier>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StatModifier> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.StatType type_;
            /*0x1c*/ YetiSimCoreLib.Components.ModifierDurationType durationType_;
            /*0x20*/ int remainingDuration_;
            /*0x24*/ Yeti.Data.EffectValueType valueType_;
            /*0x28*/ int value_;
            /*0x2c*/ int stackId_;
            /*0x30*/ int sourceId_;
            /*0x34*/ bool replaceSelf_;

            static /*0x41ec7a4*/ StatModifier();
            static /*0x41ebc88*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StatModifier> get_Parser();
            static /*0x41ebce0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ebe30*/ StatModifier();
            /*0x41ebe38*/ StatModifier(YetiSimCoreLib.Components.StatModifier other);
            /*0x41ebde4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ebe9c*/ YetiSimCoreLib.Components.StatModifier Clone();
            /*0x41ebef4*/ Yeti.Data.StatType get_Type();
            /*0x41ebefc*/ void set_Type(Yeti.Data.StatType value);
            /*0x41ebf04*/ YetiSimCoreLib.Components.ModifierDurationType get_DurationType();
            /*0x41ebf0c*/ void set_DurationType(YetiSimCoreLib.Components.ModifierDurationType value);
            /*0x41ebf14*/ int get_RemainingDuration();
            /*0x41ebf1c*/ void set_RemainingDuration(int value);
            /*0x41ebf24*/ Yeti.Data.EffectValueType get_ValueType();
            /*0x41ebf2c*/ void set_ValueType(Yeti.Data.EffectValueType value);
            /*0x41ebf34*/ int get_Value();
            /*0x41ebf3c*/ void set_Value(int value);
            /*0x41ebf44*/ int get_StackId();
            /*0x41ebf4c*/ void set_StackId(int value);
            /*0x41ebf54*/ int get_SourceId();
            /*0x41ebf5c*/ void set_SourceId(int value);
            /*0x41ebf64*/ bool get_ReplaceSelf();
            /*0x41ebf6c*/ void set_ReplaceSelf(bool value);
            /*0x41ebf74*/ bool Equals(object other);
            /*0x41ebfd8*/ bool Equals(YetiSimCoreLib.Components.StatModifier other);
            /*0x41ec094*/ int GetHashCode();
            /*0x41ec1dc*/ string ToString();
            /*0x41ec234*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ec254*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41ec3cc*/ int CalculateSize();
            /*0x41ec574*/ void MergeFrom(YetiSimCoreLib.Components.StatModifier other);
            /*0x41ec60c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ec62c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StatModifier.<> <>9;

                static /*0x41ec8bc*/ <>c();
                /*0x41ec924*/ <>c();
                /*0x41ec92c*/ YetiSimCoreLib.Components.StatModifier <.cctor>b__62_0();
            }
        }

        class Stat : Google.Protobuf.IMessage<YetiSimCoreLib.Components.Stat>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.Stat>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.Stat>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.Stat> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<YetiSimCoreLib.Components.StatModifier> _repeated_modifiers_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int currentValue_;
            /*0x20*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.StatModifier> modifiers_;
            /*0x28*/ int statTickCounter_;
            /*0x2c*/ Yeti.Data.StatType type_;

            static /*0x41ed3c0*/ Stat();
            static /*0x41ec980*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.Stat> get_Parser();
            static /*0x41ec9d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ecb28*/ Stat();
            /*0x41ecbb0*/ Stat(YetiSimCoreLib.Components.Stat other);
            /*0x41ecadc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ecc4c*/ YetiSimCoreLib.Components.Stat Clone();
            /*0x41ecca4*/ int get_CurrentValue();
            /*0x41eccac*/ void set_CurrentValue(int value);
            /*0x41eccb4*/ Google.Protobuf.Collections.RepeatedField<YetiSimCoreLib.Components.StatModifier> get_Modifiers();
            /*0x41eccbc*/ int get_StatTickCounter();
            /*0x41eccc4*/ void set_StatTickCounter(int value);
            /*0x41ecccc*/ Yeti.Data.StatType get_Type();
            /*0x41eccd4*/ void set_Type(Yeti.Data.StatType value);
            /*0x41eccdc*/ bool Equals(object other);
            /*0x41ecd40*/ bool Equals(YetiSimCoreLib.Components.Stat other);
            /*0x41ece00*/ int GetHashCode();
            /*0x41eceb0*/ string ToString();
            /*0x41ecf08*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ecf28*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41ed058*/ int CalculateSize();
            /*0x41ed1a0*/ void MergeFrom(YetiSimCoreLib.Components.Stat other);
            /*0x41ed24c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ed26c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.Stat.<> <>9;

                static /*0x41ed570*/ <>c();
                /*0x41ed5d8*/ <>c();
                /*0x41ed5e0*/ YetiSimCoreLib.Components.Stat <.cctor>b__42_0();
            }
        }

        class BaseStatOverrides : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BaseStatOverrides>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BaseStatOverrides>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BaseStatOverrides>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BaseStatOverrides> _parser;
            static /*0x8*/ Google.Protobuf.Collections.MapField.Codec<int, YetiSimCoreLib.Components.BaseStats> _map_perUnitIdOverrides_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.MapField<int, YetiSimCoreLib.Components.BaseStats> perUnitIdOverrides_;

            static /*0x41edde8*/ BaseStatOverrides();
            static /*0x41ed630*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BaseStatOverrides> get_Parser();
            static /*0x41ed688*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ed7d8*/ BaseStatOverrides();
            /*0x41ed860*/ BaseStatOverrides(YetiSimCoreLib.Components.BaseStatOverrides other);
            /*0x41ed78c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ed8ec*/ YetiSimCoreLib.Components.BaseStatOverrides Clone();
            /*0x41ed944*/ Google.Protobuf.Collections.MapField<int, YetiSimCoreLib.Components.BaseStats> get_PerUnitIdOverrides();
            /*0x41ed94c*/ bool Equals(object other);
            /*0x41ed9b0*/ bool Equals(YetiSimCoreLib.Components.BaseStatOverrides other);
            /*0x41eda40*/ int GetHashCode();
            /*0x41eda8c*/ string ToString();
            /*0x41edae4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41edb04*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41edbbc*/ int CalculateSize();
            /*0x41edc64*/ void MergeFrom(YetiSimCoreLib.Components.BaseStatOverrides other);
            /*0x41edcec*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41edd0c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BaseStatOverrides.<> <>9;

                static /*0x41edffc*/ <>c();
                /*0x41ee064*/ <>c();
                /*0x41ee06c*/ YetiSimCoreLib.Components.BaseStatOverrides <.cctor>b__27_0();
            }
        }

        class BaseStats : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BaseStats>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BaseStats>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BaseStats>, Google.Protobuf.IBufferMessage
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BaseStats> _parser;
            static /*0x8*/ Google.Protobuf.Collections.MapField.Codec<string, int> _map_mapping_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.MapField<string, int> mapping_;

            static /*0x41ee874*/ BaseStats();
            static /*0x41ee0bc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BaseStats> get_Parser();
            static /*0x41ee114*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ee264*/ BaseStats();
            /*0x41ee2ec*/ BaseStats(YetiSimCoreLib.Components.BaseStats other);
            /*0x41ee218*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ee378*/ YetiSimCoreLib.Components.BaseStats Clone();
            /*0x41ee3d0*/ Google.Protobuf.Collections.MapField<string, int> get_Mapping();
            /*0x41ee3d8*/ bool Equals(object other);
            /*0x41ee43c*/ bool Equals(YetiSimCoreLib.Components.BaseStats other);
            /*0x41ee4cc*/ int GetHashCode();
            /*0x41ee518*/ string ToString();
            /*0x41ee570*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ee590*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41ee648*/ int CalculateSize();
            /*0x41ee6f0*/ void MergeFrom(YetiSimCoreLib.Components.BaseStats other);
            /*0x41ee778*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ee798*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BaseStats.<> <>9;

                static /*0x41eea30*/ <>c();
                /*0x41eea98*/ <>c();
                /*0x41eeaa0*/ YetiSimCoreLib.Components.BaseStats <.cctor>b__27_0();
            }
        }

        class HealthStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.HealthStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.HealthStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.HealthStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HealthStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41ef1d0*/ HealthStatComponent();
            static /*0x41eeaf0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HealthStatComponent> get_Parser();
            static /*0x41eeb48*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41eec98*/ HealthStatComponent();
            /*0x41eeca0*/ HealthStatComponent(YetiSimCoreLib.Components.HealthStatComponent other);
            /*0x41eec4c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41eed0c*/ YetiSimCoreLib.Components.HealthStatComponent Clone();
            /*0x41eed64*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41eed6c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41eed74*/ bool Equals(object other);
            /*0x41eedd8*/ bool Equals(YetiSimCoreLib.Components.HealthStatComponent other);
            /*0x41eee38*/ int GetHashCode();
            /*0x41eee8c*/ string ToString();
            /*0x41eeee4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41eef04*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41eef64*/ int CalculateSize();
            /*0x41eefe4*/ void MergeFrom(YetiSimCoreLib.Components.HealthStatComponent other);
            /*0x41ef0a8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ef0c8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.HealthStatComponent.<> <>9;

                static /*0x41ef2e8*/ <>c();
                /*0x41ef350*/ <>c();
                /*0x41ef358*/ YetiSimCoreLib.Components.HealthStatComponent <.cctor>b__27_0();
            }
        }

        class MaxHealthStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MaxHealthStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MaxHealthStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MaxHealthStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaxHealthStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41efa8c*/ MaxHealthStatComponent();
            static /*0x41ef3ac*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaxHealthStatComponent> get_Parser();
            static /*0x41ef404*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ef554*/ MaxHealthStatComponent();
            /*0x41ef55c*/ MaxHealthStatComponent(YetiSimCoreLib.Components.MaxHealthStatComponent other);
            /*0x41ef508*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ef5c8*/ YetiSimCoreLib.Components.MaxHealthStatComponent Clone();
            /*0x41ef620*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41ef628*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41ef630*/ bool Equals(object other);
            /*0x41ef694*/ bool Equals(YetiSimCoreLib.Components.MaxHealthStatComponent other);
            /*0x41ef6f4*/ int GetHashCode();
            /*0x41ef748*/ string ToString();
            /*0x41ef7a0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ef7c0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41ef820*/ int CalculateSize();
            /*0x41ef8a0*/ void MergeFrom(YetiSimCoreLib.Components.MaxHealthStatComponent other);
            /*0x41ef964*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ef984*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MaxHealthStatComponent.<> <>9;

                static /*0x41efba4*/ <>c();
                /*0x41efc0c*/ <>c();
                /*0x41efc14*/ YetiSimCoreLib.Components.MaxHealthStatComponent <.cctor>b__27_0();
            }
        }

        class DamageStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DamageStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DamageStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DamageStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f0348*/ DamageStatComponent();
            static /*0x41efc68*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DamageStatComponent> get_Parser();
            static /*0x41efcc0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41efe10*/ DamageStatComponent();
            /*0x41efe18*/ DamageStatComponent(YetiSimCoreLib.Components.DamageStatComponent other);
            /*0x41efdc4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41efe84*/ YetiSimCoreLib.Components.DamageStatComponent Clone();
            /*0x41efedc*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41efee4*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41efeec*/ bool Equals(object other);
            /*0x41eff50*/ bool Equals(YetiSimCoreLib.Components.DamageStatComponent other);
            /*0x41effb0*/ int GetHashCode();
            /*0x41f0004*/ string ToString();
            /*0x41f005c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f007c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f00dc*/ int CalculateSize();
            /*0x41f015c*/ void MergeFrom(YetiSimCoreLib.Components.DamageStatComponent other);
            /*0x41f0220*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f0240*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DamageStatComponent.<> <>9;

                static /*0x41f0460*/ <>c();
                /*0x41f04c8*/ <>c();
                /*0x41f04d0*/ YetiSimCoreLib.Components.DamageStatComponent <.cctor>b__27_0();
            }
        }

        class ChillPercentStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ChillPercentStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ChillPercentStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ChillPercentStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ChillPercentStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f0c04*/ ChillPercentStatComponent();
            static /*0x41f0524*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ChillPercentStatComponent> get_Parser();
            static /*0x41f057c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f06cc*/ ChillPercentStatComponent();
            /*0x41f06d4*/ ChillPercentStatComponent(YetiSimCoreLib.Components.ChillPercentStatComponent other);
            /*0x41f0680*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f0740*/ YetiSimCoreLib.Components.ChillPercentStatComponent Clone();
            /*0x41f0798*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f07a0*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f07a8*/ bool Equals(object other);
            /*0x41f080c*/ bool Equals(YetiSimCoreLib.Components.ChillPercentStatComponent other);
            /*0x41f086c*/ int GetHashCode();
            /*0x41f08c0*/ string ToString();
            /*0x41f0918*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f0938*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f0998*/ int CalculateSize();
            /*0x41f0a18*/ void MergeFrom(YetiSimCoreLib.Components.ChillPercentStatComponent other);
            /*0x41f0adc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f0afc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ChillPercentStatComponent.<> <>9;

                static /*0x41f0d1c*/ <>c();
                /*0x41f0d84*/ <>c();
                /*0x41f0d8c*/ YetiSimCoreLib.Components.ChillPercentStatComponent <.cctor>b__27_0();
            }
        }

        class FreezeStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FreezeStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FreezeStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FreezeStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FreezeStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f14d0*/ FreezeStatComponent();
            static /*0x41f0de0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FreezeStatComponent> get_Parser();
            static /*0x41f0e38*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f0f88*/ FreezeStatComponent();
            /*0x41f0f90*/ FreezeStatComponent(YetiSimCoreLib.Components.FreezeStatComponent other);
            /*0x41f0f3c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f1000*/ YetiSimCoreLib.Components.FreezeStatComponent Clone();
            /*0x41f1058*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f1060*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f1068*/ bool Equals(object other);
            /*0x41f10cc*/ bool Equals(YetiSimCoreLib.Components.FreezeStatComponent other);
            /*0x41f112c*/ int GetHashCode();
            /*0x41f1180*/ string ToString();
            /*0x41f11d8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f11f8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f1258*/ int CalculateSize();
            /*0x41f12d8*/ void MergeFrom(YetiSimCoreLib.Components.FreezeStatComponent other);
            /*0x41f13a4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f13c4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FreezeStatComponent.<> <>9;

                static /*0x41f15e8*/ <>c();
                /*0x41f1650*/ <>c();
                /*0x41f1658*/ YetiSimCoreLib.Components.FreezeStatComponent <.cctor>b__27_0();
            }
        }

        class StunStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StunStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StunStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StunStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StunStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f1d9c*/ StunStatComponent();
            static /*0x41f16ac*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StunStatComponent> get_Parser();
            static /*0x41f1704*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f1854*/ StunStatComponent();
            /*0x41f185c*/ StunStatComponent(YetiSimCoreLib.Components.StunStatComponent other);
            /*0x41f1808*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f18cc*/ YetiSimCoreLib.Components.StunStatComponent Clone();
            /*0x41f1924*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f192c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f1934*/ bool Equals(object other);
            /*0x41f1998*/ bool Equals(YetiSimCoreLib.Components.StunStatComponent other);
            /*0x41f19f8*/ int GetHashCode();
            /*0x41f1a4c*/ string ToString();
            /*0x41f1aa4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f1ac4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f1b24*/ int CalculateSize();
            /*0x41f1ba4*/ void MergeFrom(YetiSimCoreLib.Components.StunStatComponent other);
            /*0x41f1c70*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f1c90*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StunStatComponent.<> <>9;

                static /*0x41f1eb4*/ <>c();
                /*0x41f1f1c*/ <>c();
                /*0x41f1f24*/ YetiSimCoreLib.Components.StunStatComponent <.cctor>b__27_0();
            }
        }

        class EnemyImmunityStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.EnemyImmunityStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.EnemyImmunityStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.EnemyImmunityStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.EnemyImmunityStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f2668*/ EnemyImmunityStatComponent();
            static /*0x41f1f78*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.EnemyImmunityStatComponent> get_Parser();
            static /*0x41f1fd0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f2120*/ EnemyImmunityStatComponent();
            /*0x41f2128*/ EnemyImmunityStatComponent(YetiSimCoreLib.Components.EnemyImmunityStatComponent other);
            /*0x41f20d4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f2198*/ YetiSimCoreLib.Components.EnemyImmunityStatComponent Clone();
            /*0x41f21f0*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f21f8*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f2200*/ bool Equals(object other);
            /*0x41f2264*/ bool Equals(YetiSimCoreLib.Components.EnemyImmunityStatComponent other);
            /*0x41f22c4*/ int GetHashCode();
            /*0x41f2318*/ string ToString();
            /*0x41f2370*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f2390*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f23f0*/ int CalculateSize();
            /*0x41f2470*/ void MergeFrom(YetiSimCoreLib.Components.EnemyImmunityStatComponent other);
            /*0x41f253c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f255c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.EnemyImmunityStatComponent.<> <>9;

                static /*0x41f2780*/ <>c();
                /*0x41f27e8*/ <>c();
                /*0x41f27f0*/ YetiSimCoreLib.Components.EnemyImmunityStatComponent <.cctor>b__27_0();
            }
        }

        class LifeSpanDotStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LifeSpanDotStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LifeSpanDotStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LifeSpanDotStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifeSpanDotStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f2f34*/ LifeSpanDotStatComponent();
            static /*0x41f2844*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifeSpanDotStatComponent> get_Parser();
            static /*0x41f289c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f29ec*/ LifeSpanDotStatComponent();
            /*0x41f29f4*/ LifeSpanDotStatComponent(YetiSimCoreLib.Components.LifeSpanDotStatComponent other);
            /*0x41f29a0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f2a64*/ YetiSimCoreLib.Components.LifeSpanDotStatComponent Clone();
            /*0x41f2abc*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f2ac4*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f2acc*/ bool Equals(object other);
            /*0x41f2b30*/ bool Equals(YetiSimCoreLib.Components.LifeSpanDotStatComponent other);
            /*0x41f2b90*/ int GetHashCode();
            /*0x41f2be4*/ string ToString();
            /*0x41f2c3c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f2c5c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f2cbc*/ int CalculateSize();
            /*0x41f2d3c*/ void MergeFrom(YetiSimCoreLib.Components.LifeSpanDotStatComponent other);
            /*0x41f2e08*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f2e28*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LifeSpanDotStatComponent.<> <>9;

                static /*0x41f304c*/ <>c();
                /*0x41f30b4*/ <>c();
                /*0x41f30bc*/ YetiSimCoreLib.Components.LifeSpanDotStatComponent <.cctor>b__27_0();
            }
        }

        class MovementSpeedRawStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MovementSpeedRawStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MovementSpeedRawStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MovementSpeedRawStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MovementSpeedRawStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f3800*/ MovementSpeedRawStatComponent();
            static /*0x41f3110*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MovementSpeedRawStatComponent> get_Parser();
            static /*0x41f3168*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f32b8*/ MovementSpeedRawStatComponent();
            /*0x41f32c0*/ MovementSpeedRawStatComponent(YetiSimCoreLib.Components.MovementSpeedRawStatComponent other);
            /*0x41f326c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f3330*/ YetiSimCoreLib.Components.MovementSpeedRawStatComponent Clone();
            /*0x41f3388*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f3390*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f3398*/ bool Equals(object other);
            /*0x41f33fc*/ bool Equals(YetiSimCoreLib.Components.MovementSpeedRawStatComponent other);
            /*0x41f345c*/ int GetHashCode();
            /*0x41f34b0*/ string ToString();
            /*0x41f3508*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f3528*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f3588*/ int CalculateSize();
            /*0x41f3608*/ void MergeFrom(YetiSimCoreLib.Components.MovementSpeedRawStatComponent other);
            /*0x41f36d4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f36f4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MovementSpeedRawStatComponent.<> <>9;

                static /*0x41f3918*/ <>c();
                /*0x41f3980*/ <>c();
                /*0x41f3988*/ YetiSimCoreLib.Components.MovementSpeedRawStatComponent <.cctor>b__27_0();
            }
        }

        class AttackSpeedRawStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AttackSpeedRawStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AttackSpeedRawStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AttackSpeedRawStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AttackSpeedRawStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f40cc*/ AttackSpeedRawStatComponent();
            static /*0x41f39dc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AttackSpeedRawStatComponent> get_Parser();
            static /*0x41f3a34*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f3b84*/ AttackSpeedRawStatComponent();
            /*0x41f3b8c*/ AttackSpeedRawStatComponent(YetiSimCoreLib.Components.AttackSpeedRawStatComponent other);
            /*0x41f3b38*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f3bfc*/ YetiSimCoreLib.Components.AttackSpeedRawStatComponent Clone();
            /*0x41f3c54*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f3c5c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f3c64*/ bool Equals(object other);
            /*0x41f3cc8*/ bool Equals(YetiSimCoreLib.Components.AttackSpeedRawStatComponent other);
            /*0x41f3d28*/ int GetHashCode();
            /*0x41f3d7c*/ string ToString();
            /*0x41f3dd4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f3df4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f3e54*/ int CalculateSize();
            /*0x41f3ed4*/ void MergeFrom(YetiSimCoreLib.Components.AttackSpeedRawStatComponent other);
            /*0x41f3fa0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f3fc0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AttackSpeedRawStatComponent.<> <>9;

                static /*0x41f41e4*/ <>c();
                /*0x41f424c*/ <>c();
                /*0x41f4254*/ YetiSimCoreLib.Components.AttackSpeedRawStatComponent <.cctor>b__27_0();
            }
        }

        class SpeedPercentComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SpeedPercentComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SpeedPercentComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SpeedPercentComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SpeedPercentComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f4998*/ SpeedPercentComponent();
            static /*0x41f42a8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SpeedPercentComponent> get_Parser();
            static /*0x41f4300*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f4450*/ SpeedPercentComponent();
            /*0x41f4458*/ SpeedPercentComponent(YetiSimCoreLib.Components.SpeedPercentComponent other);
            /*0x41f4404*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f44c8*/ YetiSimCoreLib.Components.SpeedPercentComponent Clone();
            /*0x41f4520*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f4528*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f4530*/ bool Equals(object other);
            /*0x41f4594*/ bool Equals(YetiSimCoreLib.Components.SpeedPercentComponent other);
            /*0x41f45f4*/ int GetHashCode();
            /*0x41f4648*/ string ToString();
            /*0x41f46a0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f46c0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f4720*/ int CalculateSize();
            /*0x41f47a0*/ void MergeFrom(YetiSimCoreLib.Components.SpeedPercentComponent other);
            /*0x41f486c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f488c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SpeedPercentComponent.<> <>9;

                static /*0x41f4ab0*/ <>c();
                /*0x41f4b18*/ <>c();
                /*0x41f4b20*/ YetiSimCoreLib.Components.SpeedPercentComponent <.cctor>b__27_0();
            }
        }

        class StunResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StunResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StunResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StunResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StunResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f5264*/ StunResistanceStatComponent();
            static /*0x41f4b74*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StunResistanceStatComponent> get_Parser();
            static /*0x41f4bcc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f4d1c*/ StunResistanceStatComponent();
            /*0x41f4d24*/ StunResistanceStatComponent(YetiSimCoreLib.Components.StunResistanceStatComponent other);
            /*0x41f4cd0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f4d94*/ YetiSimCoreLib.Components.StunResistanceStatComponent Clone();
            /*0x41f4dec*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f4df4*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f4dfc*/ bool Equals(object other);
            /*0x41f4e60*/ bool Equals(YetiSimCoreLib.Components.StunResistanceStatComponent other);
            /*0x41f4ec0*/ int GetHashCode();
            /*0x41f4f14*/ string ToString();
            /*0x41f4f6c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f4f8c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f4fec*/ int CalculateSize();
            /*0x41f506c*/ void MergeFrom(YetiSimCoreLib.Components.StunResistanceStatComponent other);
            /*0x41f5138*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f5158*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StunResistanceStatComponent.<> <>9;

                static /*0x41f537c*/ <>c();
                /*0x41f53e4*/ <>c();
                /*0x41f53ec*/ YetiSimCoreLib.Components.StunResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class FreezeResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FreezeResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FreezeResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FreezeResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FreezeResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f5b30*/ FreezeResistanceStatComponent();
            static /*0x41f5440*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FreezeResistanceStatComponent> get_Parser();
            static /*0x41f5498*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f55e8*/ FreezeResistanceStatComponent();
            /*0x41f55f0*/ FreezeResistanceStatComponent(YetiSimCoreLib.Components.FreezeResistanceStatComponent other);
            /*0x41f559c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f5660*/ YetiSimCoreLib.Components.FreezeResistanceStatComponent Clone();
            /*0x41f56b8*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f56c0*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f56c8*/ bool Equals(object other);
            /*0x41f572c*/ bool Equals(YetiSimCoreLib.Components.FreezeResistanceStatComponent other);
            /*0x41f578c*/ int GetHashCode();
            /*0x41f57e0*/ string ToString();
            /*0x41f5838*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f5858*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f58b8*/ int CalculateSize();
            /*0x41f5938*/ void MergeFrom(YetiSimCoreLib.Components.FreezeResistanceStatComponent other);
            /*0x41f5a04*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f5a24*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FreezeResistanceStatComponent.<> <>9;

                static /*0x41f5c48*/ <>c();
                /*0x41f5cb0*/ <>c();
                /*0x41f5cb8*/ YetiSimCoreLib.Components.FreezeResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class ChillResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ChillResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ChillResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ChillResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ChillResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f63fc*/ ChillResistanceStatComponent();
            static /*0x41f5d0c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ChillResistanceStatComponent> get_Parser();
            static /*0x41f5d64*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f5eb4*/ ChillResistanceStatComponent();
            /*0x41f5ebc*/ ChillResistanceStatComponent(YetiSimCoreLib.Components.ChillResistanceStatComponent other);
            /*0x41f5e68*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f5f2c*/ YetiSimCoreLib.Components.ChillResistanceStatComponent Clone();
            /*0x41f5f84*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f5f8c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f5f94*/ bool Equals(object other);
            /*0x41f5ff8*/ bool Equals(YetiSimCoreLib.Components.ChillResistanceStatComponent other);
            /*0x41f6058*/ int GetHashCode();
            /*0x41f60ac*/ string ToString();
            /*0x41f6104*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f6124*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f6184*/ int CalculateSize();
            /*0x41f6204*/ void MergeFrom(YetiSimCoreLib.Components.ChillResistanceStatComponent other);
            /*0x41f62d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f62f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ChillResistanceStatComponent.<> <>9;

                static /*0x41f6514*/ <>c();
                /*0x41f657c*/ <>c();
                /*0x41f6584*/ YetiSimCoreLib.Components.ChillResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class KnockbackResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.KnockbackResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.KnockbackResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.KnockbackResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KnockbackResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f6cc8*/ KnockbackResistanceStatComponent();
            static /*0x41f65d8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KnockbackResistanceStatComponent> get_Parser();
            static /*0x41f6630*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f6780*/ KnockbackResistanceStatComponent();
            /*0x41f6788*/ KnockbackResistanceStatComponent(YetiSimCoreLib.Components.KnockbackResistanceStatComponent other);
            /*0x41f6734*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f67f8*/ YetiSimCoreLib.Components.KnockbackResistanceStatComponent Clone();
            /*0x41f6850*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f6858*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f6860*/ bool Equals(object other);
            /*0x41f68c4*/ bool Equals(YetiSimCoreLib.Components.KnockbackResistanceStatComponent other);
            /*0x41f6924*/ int GetHashCode();
            /*0x41f6978*/ string ToString();
            /*0x41f69d0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f69f0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f6a50*/ int CalculateSize();
            /*0x41f6ad0*/ void MergeFrom(YetiSimCoreLib.Components.KnockbackResistanceStatComponent other);
            /*0x41f6b9c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f6bbc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.KnockbackResistanceStatComponent.<> <>9;

                static /*0x41f6de0*/ <>c();
                /*0x41f6e48*/ <>c();
                /*0x41f6e50*/ YetiSimCoreLib.Components.KnockbackResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class MoveLanesResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MoveLanesResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MoveLanesResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MoveLanesResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MoveLanesResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f7594*/ MoveLanesResistanceStatComponent();
            static /*0x41f6ea4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MoveLanesResistanceStatComponent> get_Parser();
            static /*0x41f6efc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f704c*/ MoveLanesResistanceStatComponent();
            /*0x41f7054*/ MoveLanesResistanceStatComponent(YetiSimCoreLib.Components.MoveLanesResistanceStatComponent other);
            /*0x41f7000*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f70c4*/ YetiSimCoreLib.Components.MoveLanesResistanceStatComponent Clone();
            /*0x41f711c*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f7124*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f712c*/ bool Equals(object other);
            /*0x41f7190*/ bool Equals(YetiSimCoreLib.Components.MoveLanesResistanceStatComponent other);
            /*0x41f71f0*/ int GetHashCode();
            /*0x41f7244*/ string ToString();
            /*0x41f729c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f72bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f731c*/ int CalculateSize();
            /*0x41f739c*/ void MergeFrom(YetiSimCoreLib.Components.MoveLanesResistanceStatComponent other);
            /*0x41f7468*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f7488*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MoveLanesResistanceStatComponent.<> <>9;

                static /*0x41f76ac*/ <>c();
                /*0x41f7714*/ <>c();
                /*0x41f771c*/ YetiSimCoreLib.Components.MoveLanesResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class StatusEffectResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StatusEffectResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StatusEffectResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StatusEffectResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StatusEffectResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f7e60*/ StatusEffectResistanceStatComponent();
            static /*0x41f7770*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StatusEffectResistanceStatComponent> get_Parser();
            static /*0x41f77c8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f7918*/ StatusEffectResistanceStatComponent();
            /*0x41f7920*/ StatusEffectResistanceStatComponent(YetiSimCoreLib.Components.StatusEffectResistanceStatComponent other);
            /*0x41f78cc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f7990*/ YetiSimCoreLib.Components.StatusEffectResistanceStatComponent Clone();
            /*0x41f79e8*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f79f0*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f79f8*/ bool Equals(object other);
            /*0x41f7a5c*/ bool Equals(YetiSimCoreLib.Components.StatusEffectResistanceStatComponent other);
            /*0x41f7abc*/ int GetHashCode();
            /*0x41f7b10*/ string ToString();
            /*0x41f7b68*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f7b88*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f7be8*/ int CalculateSize();
            /*0x41f7c68*/ void MergeFrom(YetiSimCoreLib.Components.StatusEffectResistanceStatComponent other);
            /*0x41f7d34*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f7d54*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StatusEffectResistanceStatComponent.<> <>9;

                static /*0x41f7f78*/ <>c();
                /*0x41f7fe0*/ <>c();
                /*0x41f7fe8*/ YetiSimCoreLib.Components.StatusEffectResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class ButterStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ButterStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ButterStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ButterStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ButterStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f872c*/ ButterStatComponent();
            static /*0x41f803c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ButterStatComponent> get_Parser();
            static /*0x41f8094*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f81e4*/ ButterStatComponent();
            /*0x41f81ec*/ ButterStatComponent(YetiSimCoreLib.Components.ButterStatComponent other);
            /*0x41f8198*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f825c*/ YetiSimCoreLib.Components.ButterStatComponent Clone();
            /*0x41f82b4*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f82bc*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f82c4*/ bool Equals(object other);
            /*0x41f8328*/ bool Equals(YetiSimCoreLib.Components.ButterStatComponent other);
            /*0x41f8388*/ int GetHashCode();
            /*0x41f83dc*/ string ToString();
            /*0x41f8434*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f8454*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f84b4*/ int CalculateSize();
            /*0x41f8534*/ void MergeFrom(YetiSimCoreLib.Components.ButterStatComponent other);
            /*0x41f8600*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f8620*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ButterStatComponent.<> <>9;

                static /*0x41f8844*/ <>c();
                /*0x41f88ac*/ <>c();
                /*0x41f88b4*/ YetiSimCoreLib.Components.ButterStatComponent <.cctor>b__27_0();
            }
        }

        class FlyingStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FlyingStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FlyingStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FlyingStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FlyingStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f8ff8*/ FlyingStatComponent();
            static /*0x41f8908*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FlyingStatComponent> get_Parser();
            static /*0x41f8960*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f8ab0*/ FlyingStatComponent();
            /*0x41f8ab8*/ FlyingStatComponent(YetiSimCoreLib.Components.FlyingStatComponent other);
            /*0x41f8a64*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f8b28*/ YetiSimCoreLib.Components.FlyingStatComponent Clone();
            /*0x41f8b80*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f8b88*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f8b90*/ bool Equals(object other);
            /*0x41f8bf4*/ bool Equals(YetiSimCoreLib.Components.FlyingStatComponent other);
            /*0x41f8c54*/ int GetHashCode();
            /*0x41f8ca8*/ string ToString();
            /*0x41f8d00*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f8d20*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f8d80*/ int CalculateSize();
            /*0x41f8e00*/ void MergeFrom(YetiSimCoreLib.Components.FlyingStatComponent other);
            /*0x41f8ecc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f8eec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FlyingStatComponent.<> <>9;

                static /*0x41f9110*/ <>c();
                /*0x41f9178*/ <>c();
                /*0x41f9180*/ YetiSimCoreLib.Components.FlyingStatComponent <.cctor>b__27_0();
            }
        }

        class StealthStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StealthStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StealthStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StealthStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StealthStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41f98c4*/ StealthStatComponent();
            static /*0x41f91d4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StealthStatComponent> get_Parser();
            static /*0x41f922c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f937c*/ StealthStatComponent();
            /*0x41f9384*/ StealthStatComponent(YetiSimCoreLib.Components.StealthStatComponent other);
            /*0x41f9330*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f93f4*/ YetiSimCoreLib.Components.StealthStatComponent Clone();
            /*0x41f944c*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f9454*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f945c*/ bool Equals(object other);
            /*0x41f94c0*/ bool Equals(YetiSimCoreLib.Components.StealthStatComponent other);
            /*0x41f9520*/ int GetHashCode();
            /*0x41f9574*/ string ToString();
            /*0x41f95cc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f95ec*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f964c*/ int CalculateSize();
            /*0x41f96cc*/ void MergeFrom(YetiSimCoreLib.Components.StealthStatComponent other);
            /*0x41f9798*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41f97b8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StealthStatComponent.<> <>9;

                static /*0x41f99dc*/ <>c();
                /*0x41f9a44*/ <>c();
                /*0x41f9a4c*/ YetiSimCoreLib.Components.StealthStatComponent <.cctor>b__27_0();
            }
        }

        class TranslucentStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TranslucentStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TranslucentStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TranslucentStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TranslucentStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fa190*/ TranslucentStatComponent();
            static /*0x41f9aa0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TranslucentStatComponent> get_Parser();
            static /*0x41f9af8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41f9c48*/ TranslucentStatComponent();
            /*0x41f9c50*/ TranslucentStatComponent(YetiSimCoreLib.Components.TranslucentStatComponent other);
            /*0x41f9bfc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41f9cc0*/ YetiSimCoreLib.Components.TranslucentStatComponent Clone();
            /*0x41f9d18*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41f9d20*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41f9d28*/ bool Equals(object other);
            /*0x41f9d8c*/ bool Equals(YetiSimCoreLib.Components.TranslucentStatComponent other);
            /*0x41f9dec*/ int GetHashCode();
            /*0x41f9e40*/ string ToString();
            /*0x41f9e98*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41f9eb8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41f9f18*/ int CalculateSize();
            /*0x41f9f98*/ void MergeFrom(YetiSimCoreLib.Components.TranslucentStatComponent other);
            /*0x41fa064*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fa084*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TranslucentStatComponent.<> <>9;

                static /*0x41fa2a8*/ <>c();
                /*0x41fa310*/ <>c();
                /*0x41fa318*/ YetiSimCoreLib.Components.TranslucentStatComponent <.cctor>b__27_0();
            }
        }

        class FlatDamageResistanceComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FlatDamageResistanceComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FlatDamageResistanceComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FlatDamageResistanceComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FlatDamageResistanceComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41faa5c*/ FlatDamageResistanceComponent();
            static /*0x41fa36c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FlatDamageResistanceComponent> get_Parser();
            static /*0x41fa3c4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fa514*/ FlatDamageResistanceComponent();
            /*0x41fa51c*/ FlatDamageResistanceComponent(YetiSimCoreLib.Components.FlatDamageResistanceComponent other);
            /*0x41fa4c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fa58c*/ YetiSimCoreLib.Components.FlatDamageResistanceComponent Clone();
            /*0x41fa5e4*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fa5ec*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fa5f4*/ bool Equals(object other);
            /*0x41fa658*/ bool Equals(YetiSimCoreLib.Components.FlatDamageResistanceComponent other);
            /*0x41fa6b8*/ int GetHashCode();
            /*0x41fa70c*/ string ToString();
            /*0x41fa764*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fa784*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fa7e4*/ int CalculateSize();
            /*0x41fa864*/ void MergeFrom(YetiSimCoreLib.Components.FlatDamageResistanceComponent other);
            /*0x41fa930*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fa950*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FlatDamageResistanceComponent.<> <>9;

                static /*0x41fab74*/ <>c();
                /*0x41fabdc*/ <>c();
                /*0x41fabe4*/ YetiSimCoreLib.Components.FlatDamageResistanceComponent <.cctor>b__27_0();
            }
        }

        class PercentDamageResistanceComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PercentDamageResistanceComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PercentDamageResistanceComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PercentDamageResistanceComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PercentDamageResistanceComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fb328*/ PercentDamageResistanceComponent();
            static /*0x41fac38*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PercentDamageResistanceComponent> get_Parser();
            static /*0x41fac90*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fade0*/ PercentDamageResistanceComponent();
            /*0x41fade8*/ PercentDamageResistanceComponent(YetiSimCoreLib.Components.PercentDamageResistanceComponent other);
            /*0x41fad94*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fae58*/ YetiSimCoreLib.Components.PercentDamageResistanceComponent Clone();
            /*0x41faeb0*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41faeb8*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41faec0*/ bool Equals(object other);
            /*0x41faf24*/ bool Equals(YetiSimCoreLib.Components.PercentDamageResistanceComponent other);
            /*0x41faf84*/ int GetHashCode();
            /*0x41fafd8*/ string ToString();
            /*0x41fb030*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fb050*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fb0b0*/ int CalculateSize();
            /*0x41fb130*/ void MergeFrom(YetiSimCoreLib.Components.PercentDamageResistanceComponent other);
            /*0x41fb1fc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fb21c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PercentDamageResistanceComponent.<> <>9;

                static /*0x41fb440*/ <>c();
                /*0x41fb4a8*/ <>c();
                /*0x41fb4b0*/ YetiSimCoreLib.Components.PercentDamageResistanceComponent <.cctor>b__27_0();
            }
        }

        class SizePercentStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SizePercentStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SizePercentStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SizePercentStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SizePercentStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fbbf4*/ SizePercentStatComponent();
            static /*0x41fb504*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SizePercentStatComponent> get_Parser();
            static /*0x41fb55c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fb6ac*/ SizePercentStatComponent();
            /*0x41fb6b4*/ SizePercentStatComponent(YetiSimCoreLib.Components.SizePercentStatComponent other);
            /*0x41fb660*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fb724*/ YetiSimCoreLib.Components.SizePercentStatComponent Clone();
            /*0x41fb77c*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fb784*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fb78c*/ bool Equals(object other);
            /*0x41fb7f0*/ bool Equals(YetiSimCoreLib.Components.SizePercentStatComponent other);
            /*0x41fb850*/ int GetHashCode();
            /*0x41fb8a4*/ string ToString();
            /*0x41fb8fc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fb91c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fb97c*/ int CalculateSize();
            /*0x41fb9fc*/ void MergeFrom(YetiSimCoreLib.Components.SizePercentStatComponent other);
            /*0x41fbac8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fbae8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SizePercentStatComponent.<> <>9;

                static /*0x41fbd0c*/ <>c();
                /*0x41fbd74*/ <>c();
                /*0x41fbd7c*/ YetiSimCoreLib.Components.SizePercentStatComponent <.cctor>b__27_0();
            }
        }

        class TransformCooldownStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TransformCooldownStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TransformCooldownStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TransformCooldownStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TransformCooldownStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fc4c0*/ TransformCooldownStatComponent();
            static /*0x41fbdd0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TransformCooldownStatComponent> get_Parser();
            static /*0x41fbe28*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fbf78*/ TransformCooldownStatComponent();
            /*0x41fbf80*/ TransformCooldownStatComponent(YetiSimCoreLib.Components.TransformCooldownStatComponent other);
            /*0x41fbf2c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fbff0*/ YetiSimCoreLib.Components.TransformCooldownStatComponent Clone();
            /*0x41fc048*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fc050*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fc058*/ bool Equals(object other);
            /*0x41fc0bc*/ bool Equals(YetiSimCoreLib.Components.TransformCooldownStatComponent other);
            /*0x41fc11c*/ int GetHashCode();
            /*0x41fc170*/ string ToString();
            /*0x41fc1c8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fc1e8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fc248*/ int CalculateSize();
            /*0x41fc2c8*/ void MergeFrom(YetiSimCoreLib.Components.TransformCooldownStatComponent other);
            /*0x41fc394*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fc3b4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TransformCooldownStatComponent.<> <>9;

                static /*0x41fc5d8*/ <>c();
                /*0x41fc640*/ <>c();
                /*0x41fc648*/ YetiSimCoreLib.Components.TransformCooldownStatComponent <.cctor>b__27_0();
            }
        }

        class HiddenStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.HiddenStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.HiddenStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.HiddenStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HiddenStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fcd8c*/ HiddenStatComponent();
            static /*0x41fc69c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.HiddenStatComponent> get_Parser();
            static /*0x41fc6f4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fc844*/ HiddenStatComponent();
            /*0x41fc84c*/ HiddenStatComponent(YetiSimCoreLib.Components.HiddenStatComponent other);
            /*0x41fc7f8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fc8bc*/ YetiSimCoreLib.Components.HiddenStatComponent Clone();
            /*0x41fc914*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fc91c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fc924*/ bool Equals(object other);
            /*0x41fc988*/ bool Equals(YetiSimCoreLib.Components.HiddenStatComponent other);
            /*0x41fc9e8*/ int GetHashCode();
            /*0x41fca3c*/ string ToString();
            /*0x41fca94*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fcab4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fcb14*/ int CalculateSize();
            /*0x41fcb94*/ void MergeFrom(YetiSimCoreLib.Components.HiddenStatComponent other);
            /*0x41fcc60*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fcc80*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.HiddenStatComponent.<> <>9;

                static /*0x41fcea4*/ <>c();
                /*0x41fcf0c*/ <>c();
                /*0x41fcf14*/ YetiSimCoreLib.Components.HiddenStatComponent <.cctor>b__27_0();
            }
        }

        class FlatArmorDamageResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fd658*/ FlatArmorDamageResistanceStatComponent();
            static /*0x41fcf68*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent> get_Parser();
            static /*0x41fcfc0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fd110*/ FlatArmorDamageResistanceStatComponent();
            /*0x41fd118*/ FlatArmorDamageResistanceStatComponent(YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent other);
            /*0x41fd0c4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fd188*/ YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent Clone();
            /*0x41fd1e0*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fd1e8*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fd1f0*/ bool Equals(object other);
            /*0x41fd254*/ bool Equals(YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent other);
            /*0x41fd2b4*/ int GetHashCode();
            /*0x41fd308*/ string ToString();
            /*0x41fd360*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fd380*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fd3e0*/ int CalculateSize();
            /*0x41fd460*/ void MergeFrom(YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent other);
            /*0x41fd52c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fd54c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent.<> <>9;

                static /*0x41fd770*/ <>c();
                /*0x41fd7d8*/ <>c();
                /*0x41fd7e0*/ YetiSimCoreLib.Components.FlatArmorDamageResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class PercentArmorDamageResistanceStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fdf24*/ PercentArmorDamageResistanceStatComponent();
            static /*0x41fd834*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent> get_Parser();
            static /*0x41fd88c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fd9dc*/ PercentArmorDamageResistanceStatComponent();
            /*0x41fd9e4*/ PercentArmorDamageResistanceStatComponent(YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent other);
            /*0x41fd990*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fda54*/ YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent Clone();
            /*0x41fdaac*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fdab4*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fdabc*/ bool Equals(object other);
            /*0x41fdb20*/ bool Equals(YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent other);
            /*0x41fdb80*/ int GetHashCode();
            /*0x41fdbd4*/ string ToString();
            /*0x41fdc2c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fdc4c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fdcac*/ int CalculateSize();
            /*0x41fdd2c*/ void MergeFrom(YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent other);
            /*0x41fddf8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fde18*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent.<> <>9;

                static /*0x41fe03c*/ <>c();
                /*0x41fe0a4*/ <>c();
                /*0x41fe0ac*/ YetiSimCoreLib.Components.PercentArmorDamageResistanceStatComponent <.cctor>b__27_0();
            }
        }

        class SnottedStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SnottedStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SnottedStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SnottedStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SnottedStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41fe7f0*/ SnottedStatComponent();
            static /*0x41fe100*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SnottedStatComponent> get_Parser();
            static /*0x41fe158*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41fe2a8*/ SnottedStatComponent();
            /*0x41fe2b0*/ SnottedStatComponent(YetiSimCoreLib.Components.SnottedStatComponent other);
            /*0x41fe25c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41fe320*/ YetiSimCoreLib.Components.SnottedStatComponent Clone();
            /*0x41fe378*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fe380*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fe388*/ bool Equals(object other);
            /*0x41fe3ec*/ bool Equals(YetiSimCoreLib.Components.SnottedStatComponent other);
            /*0x41fe44c*/ int GetHashCode();
            /*0x41fe4a0*/ string ToString();
            /*0x41fe4f8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fe518*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fe578*/ int CalculateSize();
            /*0x41fe5f8*/ void MergeFrom(YetiSimCoreLib.Components.SnottedStatComponent other);
            /*0x41fe6c4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fe6e4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SnottedStatComponent.<> <>9;

                static /*0x41fe908*/ <>c();
                /*0x41fe970*/ <>c();
                /*0x41fe978*/ YetiSimCoreLib.Components.SnottedStatComponent <.cctor>b__27_0();
            }
        }

        class BouncingStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BouncingStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BouncingStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BouncingStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41ff0bc*/ BouncingStatComponent();
            static /*0x41fe9cc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingStatComponent> get_Parser();
            static /*0x41fea24*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41feb74*/ BouncingStatComponent();
            /*0x41feb7c*/ BouncingStatComponent(YetiSimCoreLib.Components.BouncingStatComponent other);
            /*0x41feb28*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41febec*/ YetiSimCoreLib.Components.BouncingStatComponent Clone();
            /*0x41fec44*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41fec4c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41fec54*/ bool Equals(object other);
            /*0x41fecb8*/ bool Equals(YetiSimCoreLib.Components.BouncingStatComponent other);
            /*0x41fed18*/ int GetHashCode();
            /*0x41fed6c*/ string ToString();
            /*0x41fedc4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fede4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fee44*/ int CalculateSize();
            /*0x41feec4*/ void MergeFrom(YetiSimCoreLib.Components.BouncingStatComponent other);
            /*0x41fef90*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41fefb0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BouncingStatComponent.<> <>9;

                static /*0x41ff1d4*/ <>c();
                /*0x41ff23c*/ <>c();
                /*0x41ff244*/ YetiSimCoreLib.Components.BouncingStatComponent <.cctor>b__27_0();
            }
        }

        class DiggingStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.DiggingStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.DiggingStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.DiggingStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DiggingStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x41ff988*/ DiggingStatComponent();
            static /*0x41ff298*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.DiggingStatComponent> get_Parser();
            static /*0x41ff2f0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ff440*/ DiggingStatComponent();
            /*0x41ff448*/ DiggingStatComponent(YetiSimCoreLib.Components.DiggingStatComponent other);
            /*0x41ff3f4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ff4b8*/ YetiSimCoreLib.Components.DiggingStatComponent Clone();
            /*0x41ff510*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41ff518*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41ff520*/ bool Equals(object other);
            /*0x41ff584*/ bool Equals(YetiSimCoreLib.Components.DiggingStatComponent other);
            /*0x41ff5e4*/ int GetHashCode();
            /*0x41ff638*/ string ToString();
            /*0x41ff690*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41ff6b0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41ff710*/ int CalculateSize();
            /*0x41ff790*/ void MergeFrom(YetiSimCoreLib.Components.DiggingStatComponent other);
            /*0x41ff85c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x41ff87c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.DiggingStatComponent.<> <>9;

                static /*0x41ffaa0*/ <>c();
                /*0x41ffb08*/ <>c();
                /*0x41ffb10*/ YetiSimCoreLib.Components.DiggingStatComponent <.cctor>b__27_0();
            }
        }

        class LowStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LowStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LowStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LowStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LowStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4200254*/ LowStatComponent();
            static /*0x41ffb64*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LowStatComponent> get_Parser();
            static /*0x41ffbbc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x41ffd0c*/ LowStatComponent();
            /*0x41ffd14*/ LowStatComponent(YetiSimCoreLib.Components.LowStatComponent other);
            /*0x41ffcc0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x41ffd84*/ YetiSimCoreLib.Components.LowStatComponent Clone();
            /*0x41ffddc*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x41ffde4*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x41ffdec*/ bool Equals(object other);
            /*0x41ffe50*/ bool Equals(YetiSimCoreLib.Components.LowStatComponent other);
            /*0x41ffeb0*/ int GetHashCode();
            /*0x41fff04*/ string ToString();
            /*0x41fff5c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x41fff7c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x41fffdc*/ int CalculateSize();
            /*0x420005c*/ void MergeFrom(YetiSimCoreLib.Components.LowStatComponent other);
            /*0x4200128*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4200148*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LowStatComponent.<> <>9;

                static /*0x420036c*/ <>c();
                /*0x42003d4*/ <>c();
                /*0x42003dc*/ YetiSimCoreLib.Components.LowStatComponent <.cctor>b__27_0();
            }
        }

        class CooldownSpeedPercentStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4200b20*/ CooldownSpeedPercentStatComponent();
            static /*0x4200430*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent> get_Parser();
            static /*0x4200488*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42005d8*/ CooldownSpeedPercentStatComponent();
            /*0x42005e0*/ CooldownSpeedPercentStatComponent(YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent other);
            /*0x420058c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4200650*/ YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent Clone();
            /*0x42006a8*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x42006b0*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x42006b8*/ bool Equals(object other);
            /*0x420071c*/ bool Equals(YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent other);
            /*0x420077c*/ int GetHashCode();
            /*0x42007d0*/ string ToString();
            /*0x4200828*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4200848*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42008a8*/ int CalculateSize();
            /*0x4200928*/ void MergeFrom(YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent other);
            /*0x42009f4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4200a14*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent.<> <>9;

                static /*0x4200c38*/ <>c();
                /*0x4200ca0*/ <>c();
                /*0x4200ca8*/ YetiSimCoreLib.Components.CooldownSpeedPercentStatComponent <.cctor>b__27_0();
            }
        }

        class BonusArmorDamageStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BonusArmorDamageStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BonusArmorDamageStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BonusArmorDamageStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BonusArmorDamageStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x42013ec*/ BonusArmorDamageStatComponent();
            static /*0x4200cfc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BonusArmorDamageStatComponent> get_Parser();
            static /*0x4200d54*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4200ea4*/ BonusArmorDamageStatComponent();
            /*0x4200eac*/ BonusArmorDamageStatComponent(YetiSimCoreLib.Components.BonusArmorDamageStatComponent other);
            /*0x4200e58*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4200f1c*/ YetiSimCoreLib.Components.BonusArmorDamageStatComponent Clone();
            /*0x4200f74*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4200f7c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4200f84*/ bool Equals(object other);
            /*0x4200fe8*/ bool Equals(YetiSimCoreLib.Components.BonusArmorDamageStatComponent other);
            /*0x4201048*/ int GetHashCode();
            /*0x420109c*/ string ToString();
            /*0x42010f4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4201114*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4201174*/ int CalculateSize();
            /*0x42011f4*/ void MergeFrom(YetiSimCoreLib.Components.BonusArmorDamageStatComponent other);
            /*0x42012c0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42012e0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BonusArmorDamageStatComponent.<> <>9;

                static /*0x4201504*/ <>c();
                /*0x420156c*/ <>c();
                /*0x4201574*/ YetiSimCoreLib.Components.BonusArmorDamageStatComponent <.cctor>b__27_0();
            }
        }

        class SunburnStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SunburnStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SunburnStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SunburnStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SunburnStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4201cb8*/ SunburnStatComponent();
            static /*0x42015c8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SunburnStatComponent> get_Parser();
            static /*0x4201620*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4201770*/ SunburnStatComponent();
            /*0x4201778*/ SunburnStatComponent(YetiSimCoreLib.Components.SunburnStatComponent other);
            /*0x4201724*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42017e8*/ YetiSimCoreLib.Components.SunburnStatComponent Clone();
            /*0x4201840*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4201848*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4201850*/ bool Equals(object other);
            /*0x42018b4*/ bool Equals(YetiSimCoreLib.Components.SunburnStatComponent other);
            /*0x4201914*/ int GetHashCode();
            /*0x4201968*/ string ToString();
            /*0x42019c0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42019e0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4201a40*/ int CalculateSize();
            /*0x4201ac0*/ void MergeFrom(YetiSimCoreLib.Components.SunburnStatComponent other);
            /*0x4201b8c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4201bac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SunburnStatComponent.<> <>9;

                static /*0x4201dd0*/ <>c();
                /*0x4201e38*/ <>c();
                /*0x4201e40*/ YetiSimCoreLib.Components.SunburnStatComponent <.cctor>b__27_0();
            }
        }

        class ExpiryStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ExpiryStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ExpiryStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ExpiryStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ExpiryStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4202584*/ ExpiryStatComponent();
            static /*0x4201e94*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ExpiryStatComponent> get_Parser();
            static /*0x4201eec*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420203c*/ ExpiryStatComponent();
            /*0x4202044*/ ExpiryStatComponent(YetiSimCoreLib.Components.ExpiryStatComponent other);
            /*0x4201ff0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42020b4*/ YetiSimCoreLib.Components.ExpiryStatComponent Clone();
            /*0x420210c*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4202114*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x420211c*/ bool Equals(object other);
            /*0x4202180*/ bool Equals(YetiSimCoreLib.Components.ExpiryStatComponent other);
            /*0x42021e0*/ int GetHashCode();
            /*0x4202234*/ string ToString();
            /*0x420228c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42022ac*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420230c*/ int CalculateSize();
            /*0x420238c*/ void MergeFrom(YetiSimCoreLib.Components.ExpiryStatComponent other);
            /*0x4202458*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4202478*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ExpiryStatComponent.<> <>9;

                static /*0x420269c*/ <>c();
                /*0x4202704*/ <>c();
                /*0x420270c*/ YetiSimCoreLib.Components.ExpiryStatComponent <.cctor>b__27_0();
            }
        }

        class PuddleStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PuddleStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PuddleStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PuddleStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PuddleStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4202e50*/ PuddleStatComponent();
            static /*0x4202760*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PuddleStatComponent> get_Parser();
            static /*0x42027b8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4202908*/ PuddleStatComponent();
            /*0x4202910*/ PuddleStatComponent(YetiSimCoreLib.Components.PuddleStatComponent other);
            /*0x42028bc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4202980*/ YetiSimCoreLib.Components.PuddleStatComponent Clone();
            /*0x42029d8*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x42029e0*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x42029e8*/ bool Equals(object other);
            /*0x4202a4c*/ bool Equals(YetiSimCoreLib.Components.PuddleStatComponent other);
            /*0x4202aac*/ int GetHashCode();
            /*0x4202b00*/ string ToString();
            /*0x4202b58*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4202b78*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4202bd8*/ int CalculateSize();
            /*0x4202c58*/ void MergeFrom(YetiSimCoreLib.Components.PuddleStatComponent other);
            /*0x4202d24*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4202d44*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PuddleStatComponent.<> <>9;

                static /*0x4202f68*/ <>c();
                /*0x4202fd0*/ <>c();
                /*0x4202fd8*/ YetiSimCoreLib.Components.PuddleStatComponent <.cctor>b__27_0();
            }
        }

        class SickStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SickStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SickStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SickStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SickStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x420371c*/ SickStatComponent();
            static /*0x420302c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SickStatComponent> get_Parser();
            static /*0x4203084*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42031d4*/ SickStatComponent();
            /*0x42031dc*/ SickStatComponent(YetiSimCoreLib.Components.SickStatComponent other);
            /*0x4203188*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420324c*/ YetiSimCoreLib.Components.SickStatComponent Clone();
            /*0x42032a4*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x42032ac*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x42032b4*/ bool Equals(object other);
            /*0x4203318*/ bool Equals(YetiSimCoreLib.Components.SickStatComponent other);
            /*0x4203378*/ int GetHashCode();
            /*0x42033cc*/ string ToString();
            /*0x4203424*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4203444*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42034a4*/ int CalculateSize();
            /*0x4203524*/ void MergeFrom(YetiSimCoreLib.Components.SickStatComponent other);
            /*0x42035f0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4203610*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SickStatComponent.<> <>9;

                static /*0x4203834*/ <>c();
                /*0x420389c*/ <>c();
                /*0x42038a4*/ YetiSimCoreLib.Components.SickStatComponent <.cctor>b__27_0();
            }
        }

        class KinematicMovementImmunityStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4203fe8*/ KinematicMovementImmunityStatComponent();
            static /*0x42038f8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent> get_Parser();
            static /*0x4203950*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4203aa0*/ KinematicMovementImmunityStatComponent();
            /*0x4203aa8*/ KinematicMovementImmunityStatComponent(YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent other);
            /*0x4203a54*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4203b18*/ YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent Clone();
            /*0x4203b70*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4203b78*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4203b80*/ bool Equals(object other);
            /*0x4203be4*/ bool Equals(YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent other);
            /*0x4203c44*/ int GetHashCode();
            /*0x4203c98*/ string ToString();
            /*0x4203cf0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4203d10*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4203d70*/ int CalculateSize();
            /*0x4203df0*/ void MergeFrom(YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent other);
            /*0x4203ebc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4203edc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent.<> <>9;

                static /*0x4204100*/ <>c();
                /*0x4204168*/ <>c();
                /*0x4204170*/ YetiSimCoreLib.Components.KinematicMovementImmunityStatComponent <.cctor>b__27_0();
            }
        }

        class CorrosionDotStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CorrosionDotStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CorrosionDotStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CorrosionDotStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CorrosionDotStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x42048b4*/ CorrosionDotStatComponent();
            static /*0x42041c4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CorrosionDotStatComponent> get_Parser();
            static /*0x420421c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420436c*/ CorrosionDotStatComponent();
            /*0x4204374*/ CorrosionDotStatComponent(YetiSimCoreLib.Components.CorrosionDotStatComponent other);
            /*0x4204320*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42043e4*/ YetiSimCoreLib.Components.CorrosionDotStatComponent Clone();
            /*0x420443c*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4204444*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x420444c*/ bool Equals(object other);
            /*0x42044b0*/ bool Equals(YetiSimCoreLib.Components.CorrosionDotStatComponent other);
            /*0x4204510*/ int GetHashCode();
            /*0x4204564*/ string ToString();
            /*0x42045bc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42045dc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420463c*/ int CalculateSize();
            /*0x42046bc*/ void MergeFrom(YetiSimCoreLib.Components.CorrosionDotStatComponent other);
            /*0x4204788*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42047a8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CorrosionDotStatComponent.<> <>9;

                static /*0x42049cc*/ <>c();
                /*0x4204a34*/ <>c();
                /*0x4204a3c*/ YetiSimCoreLib.Components.CorrosionDotStatComponent <.cctor>b__27_0();
            }
        }

        class CritAttackCountStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CritAttackCountStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CritAttackCountStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CritAttackCountStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritAttackCountStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4205180*/ CritAttackCountStatComponent();
            static /*0x4204a90*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritAttackCountStatComponent> get_Parser();
            static /*0x4204ae8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4204c38*/ CritAttackCountStatComponent();
            /*0x4204c40*/ CritAttackCountStatComponent(YetiSimCoreLib.Components.CritAttackCountStatComponent other);
            /*0x4204bec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4204cb0*/ YetiSimCoreLib.Components.CritAttackCountStatComponent Clone();
            /*0x4204d08*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4204d10*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4204d18*/ bool Equals(object other);
            /*0x4204d7c*/ bool Equals(YetiSimCoreLib.Components.CritAttackCountStatComponent other);
            /*0x4204ddc*/ int GetHashCode();
            /*0x4204e30*/ string ToString();
            /*0x4204e88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4204ea8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4204f08*/ int CalculateSize();
            /*0x4204f88*/ void MergeFrom(YetiSimCoreLib.Components.CritAttackCountStatComponent other);
            /*0x4205054*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4205074*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CritAttackCountStatComponent.<> <>9;

                static /*0x4205298*/ <>c();
                /*0x4205300*/ <>c();
                /*0x4205308*/ YetiSimCoreLib.Components.CritAttackCountStatComponent <.cctor>b__27_0();
            }
        }

        class CritDamagePercentStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CritDamagePercentStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CritDamagePercentStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CritDamagePercentStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritDamagePercentStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4205a4c*/ CritDamagePercentStatComponent();
            static /*0x420535c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritDamagePercentStatComponent> get_Parser();
            static /*0x42053b4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4205504*/ CritDamagePercentStatComponent();
            /*0x420550c*/ CritDamagePercentStatComponent(YetiSimCoreLib.Components.CritDamagePercentStatComponent other);
            /*0x42054b8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420557c*/ YetiSimCoreLib.Components.CritDamagePercentStatComponent Clone();
            /*0x42055d4*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x42055dc*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x42055e4*/ bool Equals(object other);
            /*0x4205648*/ bool Equals(YetiSimCoreLib.Components.CritDamagePercentStatComponent other);
            /*0x42056a8*/ int GetHashCode();
            /*0x42056fc*/ string ToString();
            /*0x4205754*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4205774*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42057d4*/ int CalculateSize();
            /*0x4205854*/ void MergeFrom(YetiSimCoreLib.Components.CritDamagePercentStatComponent other);
            /*0x4205920*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4205940*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CritDamagePercentStatComponent.<> <>9;

                static /*0x4205b64*/ <>c();
                /*0x4205bcc*/ <>c();
                /*0x4205bd4*/ YetiSimCoreLib.Components.CritDamagePercentStatComponent <.cctor>b__27_0();
            }
        }

        class CritHitEnabledStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.CritHitEnabledStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.CritHitEnabledStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.CritHitEnabledStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritHitEnabledStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4206318*/ CritHitEnabledStatComponent();
            static /*0x4205c28*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.CritHitEnabledStatComponent> get_Parser();
            static /*0x4205c80*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4205dd0*/ CritHitEnabledStatComponent();
            /*0x4205dd8*/ CritHitEnabledStatComponent(YetiSimCoreLib.Components.CritHitEnabledStatComponent other);
            /*0x4205d84*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4205e48*/ YetiSimCoreLib.Components.CritHitEnabledStatComponent Clone();
            /*0x4205ea0*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4205ea8*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4205eb0*/ bool Equals(object other);
            /*0x4205f14*/ bool Equals(YetiSimCoreLib.Components.CritHitEnabledStatComponent other);
            /*0x4205f74*/ int GetHashCode();
            /*0x4205fc8*/ string ToString();
            /*0x4206020*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4206040*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42060a0*/ int CalculateSize();
            /*0x4206120*/ void MergeFrom(YetiSimCoreLib.Components.CritHitEnabledStatComponent other);
            /*0x42061ec*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420620c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.CritHitEnabledStatComponent.<> <>9;

                static /*0x4206430*/ <>c();
                /*0x4206498*/ <>c();
                /*0x42064a0*/ YetiSimCoreLib.Components.CritHitEnabledStatComponent <.cctor>b__27_0();
            }
        }

        class StaggerPerkAttackCountStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4206be4*/ StaggerPerkAttackCountStatComponent();
            static /*0x42064f4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent> get_Parser();
            static /*0x420654c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420669c*/ StaggerPerkAttackCountStatComponent();
            /*0x42066a4*/ StaggerPerkAttackCountStatComponent(YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent other);
            /*0x4206650*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4206714*/ YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent Clone();
            /*0x420676c*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4206774*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x420677c*/ bool Equals(object other);
            /*0x42067e0*/ bool Equals(YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent other);
            /*0x4206840*/ int GetHashCode();
            /*0x4206894*/ string ToString();
            /*0x42068ec*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420690c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420696c*/ int CalculateSize();
            /*0x42069ec*/ void MergeFrom(YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent other);
            /*0x4206ab8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4206ad8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent.<> <>9;

                static /*0x4206cfc*/ <>c();
                /*0x4206d64*/ <>c();
                /*0x4206d6c*/ YetiSimCoreLib.Components.StaggerPerkAttackCountStatComponent <.cctor>b__27_0();
            }
        }

        class StaggerPerkStunDurationStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x42074b0*/ StaggerPerkStunDurationStatComponent();
            static /*0x4206dc0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent> get_Parser();
            static /*0x4206e18*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4206f68*/ StaggerPerkStunDurationStatComponent();
            /*0x4206f70*/ StaggerPerkStunDurationStatComponent(YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent other);
            /*0x4206f1c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4206fe0*/ YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent Clone();
            /*0x4207038*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4207040*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4207048*/ bool Equals(object other);
            /*0x42070ac*/ bool Equals(YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent other);
            /*0x420710c*/ int GetHashCode();
            /*0x4207160*/ string ToString();
            /*0x42071b8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42071d8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4207238*/ int CalculateSize();
            /*0x42072b8*/ void MergeFrom(YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent other);
            /*0x4207384*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42073a4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent.<> <>9;

                static /*0x42075c8*/ <>c();
                /*0x4207630*/ <>c();
                /*0x4207638*/ YetiSimCoreLib.Components.StaggerPerkStunDurationStatComponent <.cctor>b__27_0();
            }
        }

        class ShieldedStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ShieldedStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ShieldedStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ShieldedStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ShieldedStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4207d7c*/ ShieldedStatComponent();
            static /*0x420768c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ShieldedStatComponent> get_Parser();
            static /*0x42076e4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4207834*/ ShieldedStatComponent();
            /*0x420783c*/ ShieldedStatComponent(YetiSimCoreLib.Components.ShieldedStatComponent other);
            /*0x42077e8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42078ac*/ YetiSimCoreLib.Components.ShieldedStatComponent Clone();
            /*0x4207904*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x420790c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4207914*/ bool Equals(object other);
            /*0x4207978*/ bool Equals(YetiSimCoreLib.Components.ShieldedStatComponent other);
            /*0x42079d8*/ int GetHashCode();
            /*0x4207a2c*/ string ToString();
            /*0x4207a84*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4207aa4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4207b04*/ int CalculateSize();
            /*0x4207b84*/ void MergeFrom(YetiSimCoreLib.Components.ShieldedStatComponent other);
            /*0x4207c50*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4207c70*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ShieldedStatComponent.<> <>9;

                static /*0x4207e94*/ <>c();
                /*0x4207efc*/ <>c();
                /*0x4207f04*/ YetiSimCoreLib.Components.ShieldedStatComponent <.cctor>b__27_0();
            }
        }

        class RapidFireActionCountStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RapidFireActionCountStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RapidFireActionCountStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RapidFireActionCountStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RapidFireActionCountStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4208648*/ RapidFireActionCountStatComponent();
            static /*0x4207f58*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RapidFireActionCountStatComponent> get_Parser();
            static /*0x4207fb0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4208100*/ RapidFireActionCountStatComponent();
            /*0x4208108*/ RapidFireActionCountStatComponent(YetiSimCoreLib.Components.RapidFireActionCountStatComponent other);
            /*0x42080b4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4208178*/ YetiSimCoreLib.Components.RapidFireActionCountStatComponent Clone();
            /*0x42081d0*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x42081d8*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x42081e0*/ bool Equals(object other);
            /*0x4208244*/ bool Equals(YetiSimCoreLib.Components.RapidFireActionCountStatComponent other);
            /*0x42082a4*/ int GetHashCode();
            /*0x42082f8*/ string ToString();
            /*0x4208350*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4208370*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42083d0*/ int CalculateSize();
            /*0x4208450*/ void MergeFrom(YetiSimCoreLib.Components.RapidFireActionCountStatComponent other);
            /*0x420851c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420853c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RapidFireActionCountStatComponent.<> <>9;

                static /*0x4208760*/ <>c();
                /*0x42087c8*/ <>c();
                /*0x42087d0*/ YetiSimCoreLib.Components.RapidFireActionCountStatComponent <.cctor>b__27_0();
            }
        }

        class RapidFireEnabledStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.RapidFireEnabledStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.RapidFireEnabledStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.RapidFireEnabledStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RapidFireEnabledStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x4208f14*/ RapidFireEnabledStatComponent();
            static /*0x4208824*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.RapidFireEnabledStatComponent> get_Parser();
            static /*0x420887c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42089cc*/ RapidFireEnabledStatComponent();
            /*0x42089d4*/ RapidFireEnabledStatComponent(YetiSimCoreLib.Components.RapidFireEnabledStatComponent other);
            /*0x4208980*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4208a44*/ YetiSimCoreLib.Components.RapidFireEnabledStatComponent Clone();
            /*0x4208a9c*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4208aa4*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4208aac*/ bool Equals(object other);
            /*0x4208b10*/ bool Equals(YetiSimCoreLib.Components.RapidFireEnabledStatComponent other);
            /*0x4208b70*/ int GetHashCode();
            /*0x4208bc4*/ string ToString();
            /*0x4208c1c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4208c3c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4208c9c*/ int CalculateSize();
            /*0x4208d1c*/ void MergeFrom(YetiSimCoreLib.Components.RapidFireEnabledStatComponent other);
            /*0x4208de8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4208e08*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.RapidFireEnabledStatComponent.<> <>9;

                static /*0x420902c*/ <>c();
                /*0x4209094*/ <>c();
                /*0x420909c*/ YetiSimCoreLib.Components.RapidFireEnabledStatComponent <.cctor>b__27_0();
            }
        }

        class BunchedStatusStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BunchedStatusStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BunchedStatusStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BunchedStatusStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BunchedStatusStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x42097e0*/ BunchedStatusStatComponent();
            static /*0x42090f0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BunchedStatusStatComponent> get_Parser();
            static /*0x4209148*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4209298*/ BunchedStatusStatComponent();
            /*0x42092a0*/ BunchedStatusStatComponent(YetiSimCoreLib.Components.BunchedStatusStatComponent other);
            /*0x420924c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4209310*/ YetiSimCoreLib.Components.BunchedStatusStatComponent Clone();
            /*0x4209368*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4209370*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4209378*/ bool Equals(object other);
            /*0x42093dc*/ bool Equals(YetiSimCoreLib.Components.BunchedStatusStatComponent other);
            /*0x420943c*/ int GetHashCode();
            /*0x4209490*/ string ToString();
            /*0x42094e8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4209508*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4209568*/ int CalculateSize();
            /*0x42095e8*/ void MergeFrom(YetiSimCoreLib.Components.BunchedStatusStatComponent other);
            /*0x42096b4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42096d4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BunchedStatusStatComponent.<> <>9;

                static /*0x42098f8*/ <>c();
                /*0x4209960*/ <>c();
                /*0x4209968*/ YetiSimCoreLib.Components.BunchedStatusStatComponent <.cctor>b__27_0();
            }
        }

        class BouncingProjectileActionCountStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x420a0ac*/ BouncingProjectileActionCountStatComponent();
            static /*0x42099bc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent> get_Parser();
            static /*0x4209a14*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4209b64*/ BouncingProjectileActionCountStatComponent();
            /*0x4209b6c*/ BouncingProjectileActionCountStatComponent(YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent other);
            /*0x4209b18*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4209bdc*/ YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent Clone();
            /*0x4209c34*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x4209c3c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x4209c44*/ bool Equals(object other);
            /*0x4209ca8*/ bool Equals(YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent other);
            /*0x4209d08*/ int GetHashCode();
            /*0x4209d5c*/ string ToString();
            /*0x4209db4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4209dd4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4209e34*/ int CalculateSize();
            /*0x4209eb4*/ void MergeFrom(YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent other);
            /*0x4209f80*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4209fa0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent.<> <>9;

                static /*0x420a1c4*/ <>c();
                /*0x420a22c*/ <>c();
                /*0x420a234*/ YetiSimCoreLib.Components.BouncingProjectileActionCountStatComponent <.cctor>b__27_0();
            }
        }

        class BouncingProjectileEnabledStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x420a978*/ BouncingProjectileEnabledStatComponent();
            static /*0x420a288*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent> get_Parser();
            static /*0x420a2e0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420a430*/ BouncingProjectileEnabledStatComponent();
            /*0x420a438*/ BouncingProjectileEnabledStatComponent(YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent other);
            /*0x420a3e4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420a4a8*/ YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent Clone();
            /*0x420a500*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x420a508*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x420a510*/ bool Equals(object other);
            /*0x420a574*/ bool Equals(YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent other);
            /*0x420a5d4*/ int GetHashCode();
            /*0x420a628*/ string ToString();
            /*0x420a680*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420a6a0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420a700*/ int CalculateSize();
            /*0x420a780*/ void MergeFrom(YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent other);
            /*0x420a84c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420a86c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent.<> <>9;

                static /*0x420aa90*/ <>c();
                /*0x420aaf8*/ <>c();
                /*0x420ab00*/ YetiSimCoreLib.Components.BouncingProjectileEnabledStatComponent <.cctor>b__27_0();
            }
        }

        class SplitHitProjectileActionCountStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x420b244*/ SplitHitProjectileActionCountStatComponent();
            static /*0x420ab54*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent> get_Parser();
            static /*0x420abac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420acfc*/ SplitHitProjectileActionCountStatComponent();
            /*0x420ad04*/ SplitHitProjectileActionCountStatComponent(YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent other);
            /*0x420acb0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420ad74*/ YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent Clone();
            /*0x420adcc*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x420add4*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x420addc*/ bool Equals(object other);
            /*0x420ae40*/ bool Equals(YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent other);
            /*0x420aea0*/ int GetHashCode();
            /*0x420aef4*/ string ToString();
            /*0x420af4c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420af6c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420afcc*/ int CalculateSize();
            /*0x420b04c*/ void MergeFrom(YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent other);
            /*0x420b118*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420b138*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent.<> <>9;

                static /*0x420b35c*/ <>c();
                /*0x420b3c4*/ <>c();
                /*0x420b3cc*/ YetiSimCoreLib.Components.SplitHitProjectileActionCountStatComponent <.cctor>b__27_0();
            }
        }

        class SplitHitProjectileEnabledStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x420bb10*/ SplitHitProjectileEnabledStatComponent();
            static /*0x420b420*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent> get_Parser();
            static /*0x420b478*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420b5c8*/ SplitHitProjectileEnabledStatComponent();
            /*0x420b5d0*/ SplitHitProjectileEnabledStatComponent(YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent other);
            /*0x420b57c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420b640*/ YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent Clone();
            /*0x420b698*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x420b6a0*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x420b6a8*/ bool Equals(object other);
            /*0x420b70c*/ bool Equals(YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent other);
            /*0x420b76c*/ int GetHashCode();
            /*0x420b7c0*/ string ToString();
            /*0x420b818*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420b838*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420b898*/ int CalculateSize();
            /*0x420b918*/ void MergeFrom(YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent other);
            /*0x420b9e4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420ba04*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent.<> <>9;

                static /*0x420bc28*/ <>c();
                /*0x420bc90*/ <>c();
                /*0x420bc98*/ YetiSimCoreLib.Components.SplitHitProjectileEnabledStatComponent <.cctor>b__27_0();
            }
        }

        class LifespanStatComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LifespanStatComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LifespanStatComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LifespanStatComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.IStatComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifespanStatComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ YetiSimCoreLib.Components.Stat data_;

            static /*0x420c3dc*/ LifespanStatComponent();
            static /*0x420bcec*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LifespanStatComponent> get_Parser();
            static /*0x420bd44*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420be94*/ LifespanStatComponent();
            /*0x420be9c*/ LifespanStatComponent(YetiSimCoreLib.Components.LifespanStatComponent other);
            /*0x420be48*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420bf0c*/ YetiSimCoreLib.Components.LifespanStatComponent Clone();
            /*0x420bf64*/ YetiSimCoreLib.Components.Stat get_Data();
            /*0x420bf6c*/ void set_Data(YetiSimCoreLib.Components.Stat value);
            /*0x420bf74*/ bool Equals(object other);
            /*0x420bfd8*/ bool Equals(YetiSimCoreLib.Components.LifespanStatComponent other);
            /*0x420c038*/ int GetHashCode();
            /*0x420c08c*/ string ToString();
            /*0x420c0e4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420c104*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420c164*/ int CalculateSize();
            /*0x420c1e4*/ void MergeFrom(YetiSimCoreLib.Components.LifespanStatComponent other);
            /*0x420c2b0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420c2d0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LifespanStatComponent.<> <>9;

                static /*0x420c4f4*/ <>c();
                /*0x420c55c*/ <>c();
                /*0x420c564*/ YetiSimCoreLib.Components.LifespanStatComponent <.cctor>b__27_0();
            }
        }

        class StoredComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x420c610*/ StoredComponentReflection();
            static /*0x420c5b8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class StoredComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.StoredComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.StoredComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.StoredComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StoredComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ bool isVisible_;
            /*0x1c*/ int storerId_;

            static /*0x420d274*/ StoredComponent();
            static /*0x420cc10*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.StoredComponent> get_Parser();
            static /*0x420cc68*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420cdb8*/ StoredComponent();
            /*0x420cdc0*/ StoredComponent(YetiSimCoreLib.Components.StoredComponent other);
            /*0x420cd6c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420ce14*/ YetiSimCoreLib.Components.StoredComponent Clone();
            /*0x420ce6c*/ bool get_IsVisible();
            /*0x420ce74*/ void set_IsVisible(bool value);
            /*0x420ce7c*/ int get_StorerId();
            /*0x420ce84*/ void set_StorerId(int value);
            /*0x420ce8c*/ bool Equals(object other);
            /*0x420cef0*/ bool Equals(YetiSimCoreLib.Components.StoredComponent other);
            /*0x420cf4c*/ int GetHashCode();
            /*0x420cfdc*/ string ToString();
            /*0x420d034*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420d054*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420d0dc*/ int CalculateSize();
            /*0x420d168*/ void MergeFrom(YetiSimCoreLib.Components.StoredComponent other);
            /*0x420d1b8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420d1d8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.StoredComponent.<> <>9;

                static /*0x420d38c*/ <>c();
                /*0x420d3f4*/ <>c();
                /*0x420d3fc*/ YetiSimCoreLib.Components.StoredComponent <.cctor>b__32_0();
            }
        }

        class UnitStorageComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.UnitStorageComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.UnitStorageComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.UnitStorageComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitStorageComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_unitIds_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> unitIds_;
            /*0x20*/ bool unitsAreVisible_;

            static /*0x420dcf4*/ UnitStorageComponent();
            static /*0x420d450*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitStorageComponent> get_Parser();
            static /*0x420d4a8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420d5f8*/ UnitStorageComponent();
            /*0x420d680*/ UnitStorageComponent(YetiSimCoreLib.Components.UnitStorageComponent other);
            /*0x420d5ac*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420d714*/ YetiSimCoreLib.Components.UnitStorageComponent Clone();
            /*0x420d76c*/ Google.Protobuf.Collections.RepeatedField<int> get_UnitIds();
            /*0x420d774*/ bool get_UnitsAreVisible();
            /*0x420d77c*/ void set_UnitsAreVisible(bool value);
            /*0x420d784*/ bool Equals(object other);
            /*0x420d7e8*/ bool Equals(YetiSimCoreLib.Components.UnitStorageComponent other);
            /*0x420d898*/ int GetHashCode();
            /*0x420d924*/ string ToString();
            /*0x420d97c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420d99c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420da7c*/ int CalculateSize();
            /*0x420db30*/ void MergeFrom(YetiSimCoreLib.Components.UnitStorageComponent other);
            /*0x420dbc8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420dbe8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.UnitStorageComponent.<> <>9;

                static /*0x420de30*/ <>c();
                /*0x420de98*/ <>c();
                /*0x420dea0*/ YetiSimCoreLib.Components.UnitStorageComponent <.cctor>b__32_0();
            }
        }

        class SummoningInComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x420df48*/ SummoningInComponentReflection();
            static /*0x420def0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class SummoningInComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SummoningInComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SummoningInComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SummoningInComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SummoningInComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;

            static /*0x420e870*/ SummoningInComponent();
            static /*0x420e2e4*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SummoningInComponent> get_Parser();
            static /*0x420e33c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420e48c*/ SummoningInComponent();
            /*0x420e494*/ SummoningInComponent(YetiSimCoreLib.Components.SummoningInComponent other);
            /*0x420e440*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420e4e0*/ YetiSimCoreLib.Components.SummoningInComponent Clone();
            /*0x420e538*/ int get_TicksRemaining();
            /*0x420e540*/ void set_TicksRemaining(int value);
            /*0x420e548*/ bool Equals(object other);
            /*0x420e5ac*/ bool Equals(YetiSimCoreLib.Components.SummoningInComponent other);
            /*0x420e5e8*/ int GetHashCode();
            /*0x420e644*/ string ToString();
            /*0x420e69c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420e6bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420e71c*/ int CalculateSize();
            /*0x420e79c*/ void MergeFrom(YetiSimCoreLib.Components.SummoningInComponent other);
            /*0x420e7dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420e7fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SummoningInComponent.<> <>9;

                static /*0x420e988*/ <>c();
                /*0x420e9f0*/ <>c();
                /*0x420e9f8*/ YetiSimCoreLib.Components.SummoningInComponent <.cctor>b__27_0();
            }
        }

        class SunComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x420eaa4*/ SunComponentReflection();
            static /*0x420ea4c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class SunComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SunComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SunComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SunComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SunComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int sourceId_;
            /*0x1c*/ int value_;

            static /*0x420f4c4*/ SunComponent();
            static /*0x420ee74*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SunComponent> get_Parser();
            static /*0x420eecc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420f01c*/ SunComponent();
            /*0x420f024*/ SunComponent(YetiSimCoreLib.Components.SunComponent other);
            /*0x420efd0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420f070*/ YetiSimCoreLib.Components.SunComponent Clone();
            /*0x420f0c8*/ int get_SourceId();
            /*0x420f0d0*/ void set_SourceId(int value);
            /*0x420f0d8*/ int get_Value();
            /*0x420f0e0*/ void set_Value(int value);
            /*0x420f0e8*/ bool Equals(object other);
            /*0x420f14c*/ bool Equals(YetiSimCoreLib.Components.SunComponent other);
            /*0x420f198*/ int GetHashCode();
            /*0x420f210*/ string ToString();
            /*0x420f268*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x420f288*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x420f310*/ int CalculateSize();
            /*0x420f3c4*/ void MergeFrom(YetiSimCoreLib.Components.SunComponent other);
            /*0x420f410*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x420f430*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SunComponent.<> <>9;

                static /*0x420f5dc*/ <>c();
                /*0x420f644*/ <>c();
                /*0x420f64c*/ YetiSimCoreLib.Components.SunComponent <.cctor>b__32_0();
            }
        }

        class SunGeneratorComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x420f6f8*/ SunGeneratorComponentReflection();
            static /*0x420f6a0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class SunGeneratorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SunGeneratorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SunGeneratorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SunGeneratorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SunGeneratorComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int incrementValue_;
            /*0x1c*/ int accumulator_;
            /*0x20*/ int rate_;
            /*0x24*/ int lastTick_;
            /*0x28*/ int nextTick_;
            /*0x2c*/ bool isPaused_;
            /*0x30*/ int generationCount_;
            /*0x34*/ int rateBonusPercent_;
            /*0x38*/ int rateRange_;

            static /*0x421095c*/ SunGeneratorComponent();
            static /*0x420fd84*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SunGeneratorComponent> get_Parser();
            static /*0x420fddc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x420ff2c*/ SunGeneratorComponent();
            /*0x420ff34*/ SunGeneratorComponent(YetiSimCoreLib.Components.SunGeneratorComponent other);
            /*0x420fee0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x420ffa0*/ YetiSimCoreLib.Components.SunGeneratorComponent Clone();
            /*0x420fff8*/ int get_IncrementValue();
            /*0x4210000*/ void set_IncrementValue(int value);
            /*0x4210008*/ int get_Accumulator();
            /*0x4210010*/ void set_Accumulator(int value);
            /*0x4210018*/ int get_Rate();
            /*0x4210020*/ void set_Rate(int value);
            /*0x4210028*/ int get_LastTick();
            /*0x4210030*/ void set_LastTick(int value);
            /*0x4210038*/ int get_NextTick();
            /*0x4210040*/ void set_NextTick(int value);
            /*0x4210048*/ bool get_IsPaused();
            /*0x4210050*/ void set_IsPaused(bool value);
            /*0x4210058*/ int get_GenerationCount();
            /*0x4210060*/ void set_GenerationCount(int value);
            /*0x4210068*/ int get_RateBonusPercent();
            /*0x4210070*/ void set_RateBonusPercent(int value);
            /*0x4210078*/ int get_RateRange();
            /*0x4210080*/ void set_RateRange(int value);
            /*0x4210088*/ bool Equals(object other);
            /*0x42100ec*/ bool Equals(YetiSimCoreLib.Components.SunGeneratorComponent other);
            /*0x42101b8*/ int GetHashCode();
            /*0x4210314*/ string ToString();
            /*0x421036c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421038c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421052c*/ int CalculateSize();
            /*0x4210700*/ void MergeFrom(YetiSimCoreLib.Components.SunGeneratorComponent other);
            /*0x42107a4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42107c4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SunGeneratorComponent.<> <>9;

                static /*0x4210a74*/ <>c();
                /*0x4210adc*/ <>c();
                /*0x4210ae4*/ YetiSimCoreLib.Components.SunGeneratorComponent <.cctor>b__67_0();
            }
        }

        class TargetsComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4210b90*/ TargetsComponentReflection();
            static /*0x4210b38*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class TargetsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TargetsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TargetsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TargetsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetsComponent> _parser;
            static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_targets_codec;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> targets_;
            /*0x20*/ int lastTargetX_;
            /*0x24*/ int lastTargetY_;
            /*0x28*/ int lastTargetZ_;

            static /*0x4211ab4*/ TargetsComponent();
            static /*0x421107c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TargetsComponent> get_Parser();
            static /*0x42110d4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4211224*/ TargetsComponent();
            /*0x42112ac*/ TargetsComponent(YetiSimCoreLib.Components.TargetsComponent other);
            /*0x42111d8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4211348*/ YetiSimCoreLib.Components.TargetsComponent Clone();
            /*0x42113a0*/ Google.Protobuf.Collections.RepeatedField<int> get_Targets();
            /*0x42113a8*/ int get_LastTargetX();
            /*0x42113b0*/ void set_LastTargetX(int value);
            /*0x42113b8*/ int get_LastTargetY();
            /*0x42113c0*/ void set_LastTargetY(int value);
            /*0x42113c8*/ int get_LastTargetZ();
            /*0x42113d0*/ void set_LastTargetZ(int value);
            /*0x42113d8*/ bool Equals(object other);
            /*0x421143c*/ bool Equals(YetiSimCoreLib.Components.TargetsComponent other);
            /*0x42114fc*/ int GetHashCode();
            /*0x42115a4*/ string ToString();
            /*0x42115fc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421161c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421174c*/ int CalculateSize();
            /*0x4211890*/ void MergeFrom(YetiSimCoreLib.Components.TargetsComponent other);
            /*0x421193c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421195c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TargetsComponent.<> <>9;

                static /*0x4211bf0*/ <>c();
                /*0x4211c58*/ <>c();
                /*0x4211c60*/ YetiSimCoreLib.Components.TargetsComponent <.cctor>b__42_0();
            }
        }

        class TickComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4211d08*/ TickComponentReflection();
            static /*0x4211cb0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class TickComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TickComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TickComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TickComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TickComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int currentTick_;
            /*0x1c*/ int totalRunningTicks_;

            static /*0x42127dc*/ TickComponent();
            static /*0x421218c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TickComponent> get_Parser();
            static /*0x42121e4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4212334*/ TickComponent();
            /*0x421233c*/ TickComponent(YetiSimCoreLib.Components.TickComponent other);
            /*0x42122e8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4212388*/ YetiSimCoreLib.Components.TickComponent Clone();
            /*0x42123e0*/ int get_CurrentTick();
            /*0x42123e8*/ void set_CurrentTick(int value);
            /*0x42123f0*/ int get_TotalRunningTicks();
            /*0x42123f8*/ void set_TotalRunningTicks(int value);
            /*0x4212400*/ bool Equals(object other);
            /*0x4212464*/ bool Equals(YetiSimCoreLib.Components.TickComponent other);
            /*0x42124b0*/ int GetHashCode();
            /*0x4212528*/ string ToString();
            /*0x4212580*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42125a0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4212628*/ int CalculateSize();
            /*0x42126dc*/ void MergeFrom(YetiSimCoreLib.Components.TickComponent other);
            /*0x4212728*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4212748*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TickComponent.<> <>9;

                static /*0x42128f4*/ <>c();
                /*0x421295c*/ <>c();
                /*0x4212964*/ YetiSimCoreLib.Components.TickComponent <.cctor>b__32_0();
            }
        }

        class TimedCascadeMeterComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4212a10*/ TimedCascadeMeterComponentReflection();
            static /*0x42129b8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class TimedCascadeMeterComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TimedCascadeMeterComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TimedCascadeMeterComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TimedCascadeMeterComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent, YetiSimCoreLib.Components.ICounterComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TimedCascadeMeterComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ticksRemaining_;
            /*0x1c*/ int pointsToGrant_;
            /*0x20*/ bool isPaused_;

            static /*0x4213640*/ TimedCascadeMeterComponent();
            static /*0x4212efc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TimedCascadeMeterComponent> get_Parser();
            static /*0x4212f54*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42130a4*/ TimedCascadeMeterComponent();
            /*0x42130ac*/ TimedCascadeMeterComponent(YetiSimCoreLib.Components.TimedCascadeMeterComponent other);
            /*0x4213058*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4213100*/ YetiSimCoreLib.Components.TimedCascadeMeterComponent Clone();
            /*0x4213158*/ int get_TicksRemaining();
            /*0x4213160*/ void set_TicksRemaining(int value);
            /*0x4213168*/ int get_PointsToGrant();
            /*0x4213170*/ void set_PointsToGrant(int value);
            /*0x4213178*/ bool get_IsPaused();
            /*0x4213180*/ void set_IsPaused(bool value);
            /*0x4213188*/ bool Equals(object other);
            /*0x42131ec*/ bool Equals(YetiSimCoreLib.Components.TimedCascadeMeterComponent other);
            /*0x4213258*/ int GetHashCode();
            /*0x421330c*/ string ToString();
            /*0x4213364*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4213384*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4213434*/ int CalculateSize();
            /*0x4213500*/ void MergeFrom(YetiSimCoreLib.Components.TimedCascadeMeterComponent other);
            /*0x421355c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421357c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TimedCascadeMeterComponent.<> <>9;

                static /*0x4213758*/ <>c();
                /*0x42137c0*/ <>c();
                /*0x42137c8*/ YetiSimCoreLib.Components.TimedCascadeMeterComponent <.cctor>b__37_0();
            }
        }

        class TransformationComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4213874*/ TransformationComponentReflection();
            static /*0x421381c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class TransformationComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TransformationComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TransformationComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TransformationComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TransformationComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int transformationId_;
            /*0x1c*/ bool onlyChangeAnimationState_;

            static /*0x4214370*/ TransformationComponent();
            static /*0x4213cf8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TransformationComponent> get_Parser();
            static /*0x4213d50*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4213ea0*/ TransformationComponent();
            /*0x4213ea8*/ TransformationComponent(YetiSimCoreLib.Components.TransformationComponent other);
            /*0x4213e54*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4213efc*/ YetiSimCoreLib.Components.TransformationComponent Clone();
            /*0x4213f54*/ int get_TransformationId();
            /*0x4213f5c*/ void set_TransformationId(int value);
            /*0x4213f64*/ bool get_OnlyChangeAnimationState();
            /*0x4213f6c*/ void set_OnlyChangeAnimationState(bool value);
            /*0x4213f74*/ bool Equals(object other);
            /*0x4213fd8*/ bool Equals(YetiSimCoreLib.Components.TransformationComponent other);
            /*0x4214034*/ int GetHashCode();
            /*0x42140cc*/ string ToString();
            /*0x4214124*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4214144*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42141cc*/ int CalculateSize();
            /*0x4214264*/ void MergeFrom(YetiSimCoreLib.Components.TransformationComponent other);
            /*0x42142b4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42142d4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TransformationComponent.<> <>9;

                static /*0x4214488*/ <>c();
                /*0x42144f0*/ <>c();
                /*0x42144f8*/ YetiSimCoreLib.Components.TransformationComponent <.cctor>b__32_0();
            }
        }

        class TriggerReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x42145a4*/ TriggerReflection();
            static /*0x421454c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class TriggersOnDeathComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TriggersOnDeathComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TriggersOnDeathComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TriggersOnDeathComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TriggersOnDeathComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4214e34*/ TriggersOnDeathComponent();
            static /*0x42149c0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TriggersOnDeathComponent> get_Parser();
            static /*0x4214a18*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4214b68*/ TriggersOnDeathComponent();
            /*0x4214b70*/ TriggersOnDeathComponent(YetiSimCoreLib.Components.TriggersOnDeathComponent other);
            /*0x4214b1c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4214bb4*/ YetiSimCoreLib.Components.TriggersOnDeathComponent Clone();
            /*0x4214c0c*/ bool Equals(object other);
            /*0x4214c90*/ bool Equals(YetiSimCoreLib.Components.TriggersOnDeathComponent other);
            /*0x4214cbc*/ int GetHashCode();
            /*0x4214ce8*/ string ToString();
            /*0x4214d40*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4214d60*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4214d74*/ int CalculateSize();
            /*0x4214d88*/ void MergeFrom(YetiSimCoreLib.Components.TriggersOnDeathComponent other);
            /*0x4214dbc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4214ddc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TriggersOnDeathComponent.<> <>9;

                static /*0x4214f4c*/ <>c();
                /*0x4214fb4*/ <>c();
                /*0x4214fbc*/ YetiSimCoreLib.Components.TriggersOnDeathComponent <.cctor>b__22_0();
            }
        }

        class TriggersOnReclaimedComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.TriggersOnReclaimedComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.TriggersOnReclaimedComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.TriggersOnReclaimedComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TriggersOnReclaimedComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4215484*/ TriggersOnReclaimedComponent();
            static /*0x4215010*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.TriggersOnReclaimedComponent> get_Parser();
            static /*0x4215068*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42151b8*/ TriggersOnReclaimedComponent();
            /*0x42151c0*/ TriggersOnReclaimedComponent(YetiSimCoreLib.Components.TriggersOnReclaimedComponent other);
            /*0x421516c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4215204*/ YetiSimCoreLib.Components.TriggersOnReclaimedComponent Clone();
            /*0x421525c*/ bool Equals(object other);
            /*0x42152e0*/ bool Equals(YetiSimCoreLib.Components.TriggersOnReclaimedComponent other);
            /*0x421530c*/ int GetHashCode();
            /*0x4215338*/ string ToString();
            /*0x4215390*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42153b0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42153c4*/ int CalculateSize();
            /*0x42153d8*/ void MergeFrom(YetiSimCoreLib.Components.TriggersOnReclaimedComponent other);
            /*0x421540c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421542c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.TriggersOnReclaimedComponent.<> <>9;

                static /*0x421559c*/ <>c();
                /*0x4215604*/ <>c();
                /*0x421560c*/ YetiSimCoreLib.Components.TriggersOnReclaimedComponent <.cctor>b__22_0();
            }
        }

        class UniqueOnBoardComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x42156b8*/ UniqueOnBoardComponentReflection();
            static /*0x4215660*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class UniqueOnBoardComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.UniqueOnBoardComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.UniqueOnBoardComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.UniqueOnBoardComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UniqueOnBoardComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4215e74*/ UniqueOnBoardComponent();
            static /*0x4215a00*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UniqueOnBoardComponent> get_Parser();
            static /*0x4215a58*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4215ba8*/ UniqueOnBoardComponent();
            /*0x4215bb0*/ UniqueOnBoardComponent(YetiSimCoreLib.Components.UniqueOnBoardComponent other);
            /*0x4215b5c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4215bf4*/ YetiSimCoreLib.Components.UniqueOnBoardComponent Clone();
            /*0x4215c4c*/ bool Equals(object other);
            /*0x4215cd0*/ bool Equals(YetiSimCoreLib.Components.UniqueOnBoardComponent other);
            /*0x4215cfc*/ int GetHashCode();
            /*0x4215d28*/ string ToString();
            /*0x4215d80*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4215da0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4215db4*/ int CalculateSize();
            /*0x4215dc8*/ void MergeFrom(YetiSimCoreLib.Components.UniqueOnBoardComponent other);
            /*0x4215dfc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4215e1c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.UniqueOnBoardComponent.<> <>9;

                static /*0x4215f8c*/ <>c();
                /*0x4215ff4*/ <>c();
                /*0x4215ffc*/ YetiSimCoreLib.Components.UniqueOnBoardComponent <.cctor>b__22_0();
            }
        }

        class UnitComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x42160a8*/ UnitComponentReflection();
            static /*0x4216050*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class LevelsComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.LevelsComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.LevelsComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.LevelsComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LevelsComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int unitLevel_;
            /*0x1c*/ int plantFoodLevel_;
            /*0x20*/ int promotionLevel_;

            static /*0x4217dfc*/ LevelsComponent();
            static /*0x42176e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.LevelsComponent> get_Parser();
            static /*0x4217738*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4217888*/ LevelsComponent();
            /*0x4217890*/ LevelsComponent(YetiSimCoreLib.Components.LevelsComponent other);
            /*0x421783c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42178e4*/ YetiSimCoreLib.Components.LevelsComponent Clone();
            /*0x421793c*/ int get_UnitLevel();
            /*0x4217944*/ void set_UnitLevel(int value);
            /*0x421794c*/ int get_PlantFoodLevel();
            /*0x4217954*/ void set_PlantFoodLevel(int value);
            /*0x421795c*/ int get_PromotionLevel();
            /*0x4217964*/ void set_PromotionLevel(int value);
            /*0x421796c*/ bool Equals(object other);
            /*0x42179d0*/ bool Equals(YetiSimCoreLib.Components.LevelsComponent other);
            /*0x4217a2c*/ int GetHashCode();
            /*0x4217ac0*/ string ToString();
            /*0x4217b18*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4217b38*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4217be8*/ int CalculateSize();
            /*0x4217cc8*/ void MergeFrom(YetiSimCoreLib.Components.LevelsComponent other);
            /*0x4217d20*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4217d40*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.LevelsComponent.<> <>9;

                static /*0x4217f14*/ <>c();
                /*0x4217f7c*/ <>c();
                /*0x4217f84*/ YetiSimCoreLib.Components.LevelsComponent <.cctor>b__37_0();
            }
        }

        class SimObjectComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SimObjectComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SimObjectComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SimObjectComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SimObjectComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int instanceId_;

            static /*0x4218564*/ SimObjectComponent();
            static /*0x4217fd8*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SimObjectComponent> get_Parser();
            static /*0x4218030*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4218180*/ SimObjectComponent();
            /*0x4218188*/ SimObjectComponent(YetiSimCoreLib.Components.SimObjectComponent other);
            /*0x4218134*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42181d4*/ YetiSimCoreLib.Components.SimObjectComponent Clone();
            /*0x421822c*/ int get_InstanceId();
            /*0x4218234*/ void set_InstanceId(int value);
            /*0x421823c*/ bool Equals(object other);
            /*0x42182a0*/ bool Equals(YetiSimCoreLib.Components.SimObjectComponent other);
            /*0x42182dc*/ int GetHashCode();
            /*0x4218338*/ string ToString();
            /*0x4218390*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42183b0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4218410*/ int CalculateSize();
            /*0x4218490*/ void MergeFrom(YetiSimCoreLib.Components.SimObjectComponent other);
            /*0x42184d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42184f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SimObjectComponent.<> <>9;

                static /*0x421867c*/ <>c();
                /*0x42186e4*/ <>c();
                /*0x42186ec*/ YetiSimCoreLib.Components.SimObjectComponent <.cctor>b__27_0();
            }
        }

        class FighterComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.FighterComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.FighterComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.FighterComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FighterComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4218bb4*/ FighterComponent();
            static /*0x4218740*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.FighterComponent> get_Parser();
            static /*0x4218798*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42188e8*/ FighterComponent();
            /*0x42188f0*/ FighterComponent(YetiSimCoreLib.Components.FighterComponent other);
            /*0x421889c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4218934*/ YetiSimCoreLib.Components.FighterComponent Clone();
            /*0x421898c*/ bool Equals(object other);
            /*0x4218a10*/ bool Equals(YetiSimCoreLib.Components.FighterComponent other);
            /*0x4218a3c*/ int GetHashCode();
            /*0x4218a68*/ string ToString();
            /*0x4218ac0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4218ae0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4218af4*/ int CalculateSize();
            /*0x4218b08*/ void MergeFrom(YetiSimCoreLib.Components.FighterComponent other);
            /*0x4218b3c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4218b5c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.FighterComponent.<> <>9;

                static /*0x4218ccc*/ <>c();
                /*0x4218d34*/ <>c();
                /*0x4218d3c*/ YetiSimCoreLib.Components.FighterComponent <.cctor>b__22_0();
            }
        }

        class ObstacleComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.ObstacleComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.ObstacleComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.ObstacleComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ObstacleComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4219204*/ ObstacleComponent();
            static /*0x4218d90*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.ObstacleComponent> get_Parser();
            static /*0x4218de8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4218f38*/ ObstacleComponent();
            /*0x4218f40*/ ObstacleComponent(YetiSimCoreLib.Components.ObstacleComponent other);
            /*0x4218eec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4218f84*/ YetiSimCoreLib.Components.ObstacleComponent Clone();
            /*0x4218fdc*/ bool Equals(object other);
            /*0x4219060*/ bool Equals(YetiSimCoreLib.Components.ObstacleComponent other);
            /*0x421908c*/ int GetHashCode();
            /*0x42190b8*/ string ToString();
            /*0x4219110*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4219130*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4219144*/ int CalculateSize();
            /*0x4219158*/ void MergeFrom(YetiSimCoreLib.Components.ObstacleComponent other);
            /*0x421918c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42191ac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.ObstacleComponent.<> <>9;

                static /*0x421931c*/ <>c();
                /*0x4219384*/ <>c();
                /*0x421938c*/ YetiSimCoreLib.Components.ObstacleComponent <.cctor>b__22_0();
            }
        }

        class WillChangeBehaviorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.WillChangeBehaviorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.WillChangeBehaviorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.WillChangeBehaviorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WillChangeBehaviorComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int newBehaviorId_;

            static /*0x421996c*/ WillChangeBehaviorComponent();
            static /*0x42193e0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WillChangeBehaviorComponent> get_Parser();
            static /*0x4219438*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4219588*/ WillChangeBehaviorComponent();
            /*0x4219590*/ WillChangeBehaviorComponent(YetiSimCoreLib.Components.WillChangeBehaviorComponent other);
            /*0x421953c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42195dc*/ YetiSimCoreLib.Components.WillChangeBehaviorComponent Clone();
            /*0x4219634*/ int get_NewBehaviorId();
            /*0x421963c*/ void set_NewBehaviorId(int value);
            /*0x4219644*/ bool Equals(object other);
            /*0x42196a8*/ bool Equals(YetiSimCoreLib.Components.WillChangeBehaviorComponent other);
            /*0x42196e4*/ int GetHashCode();
            /*0x4219740*/ string ToString();
            /*0x4219798*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x42197b8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4219818*/ int CalculateSize();
            /*0x4219898*/ void MergeFrom(YetiSimCoreLib.Components.WillChangeBehaviorComponent other);
            /*0x42198d8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42198f8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.WillChangeBehaviorComponent.<> <>9;

                static /*0x4219a84*/ <>c();
                /*0x4219aec*/ <>c();
                /*0x4219af4*/ YetiSimCoreLib.Components.WillChangeBehaviorComponent <.cctor>b__27_0();
            }
        }

        class PusherComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PusherComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PusherComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PusherComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PusherComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int pusheeId_;
            /*0x1c*/ int xDistance_;
            /*0x20*/ bool stayAttachedWhenBounced_;

            static /*0x421a28c*/ PusherComponent();
            static /*0x4219b48*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PusherComponent> get_Parser();
            static /*0x4219ba0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4219cf0*/ PusherComponent();
            /*0x4219cf8*/ PusherComponent(YetiSimCoreLib.Components.PusherComponent other);
            /*0x4219ca4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4219d4c*/ YetiSimCoreLib.Components.PusherComponent Clone();
            /*0x4219da4*/ int get_PusheeId();
            /*0x4219dac*/ void set_PusheeId(int value);
            /*0x4219db4*/ int get_XDistance();
            /*0x4219dbc*/ void set_XDistance(int value);
            /*0x4219dc4*/ bool get_StayAttachedWhenBounced();
            /*0x4219dcc*/ void set_StayAttachedWhenBounced(bool value);
            /*0x4219dd4*/ bool Equals(object other);
            /*0x4219e38*/ bool Equals(YetiSimCoreLib.Components.PusherComponent other);
            /*0x4219ea4*/ int GetHashCode();
            /*0x4219f58*/ string ToString();
            /*0x4219fb0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4219fd0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421a080*/ int CalculateSize();
            /*0x421a14c*/ void MergeFrom(YetiSimCoreLib.Components.PusherComponent other);
            /*0x421a1a8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421a1c8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PusherComponent.<> <>9;

                static /*0x421a3a4*/ <>c();
                /*0x421a40c*/ <>c();
                /*0x421a414*/ YetiSimCoreLib.Components.PusherComponent <.cctor>b__37_0();
            }
        }

        class PusheeComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PusheeComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PusheeComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PusheeComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PusheeComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int pusherId_;

            static /*0x421a9f4*/ PusheeComponent();
            static /*0x421a468*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PusheeComponent> get_Parser();
            static /*0x421a4c0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421a610*/ PusheeComponent();
            /*0x421a618*/ PusheeComponent(YetiSimCoreLib.Components.PusheeComponent other);
            /*0x421a5c4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421a664*/ YetiSimCoreLib.Components.PusheeComponent Clone();
            /*0x421a6bc*/ int get_PusherId();
            /*0x421a6c4*/ void set_PusherId(int value);
            /*0x421a6cc*/ bool Equals(object other);
            /*0x421a730*/ bool Equals(YetiSimCoreLib.Components.PusheeComponent other);
            /*0x421a76c*/ int GetHashCode();
            /*0x421a7c8*/ string ToString();
            /*0x421a820*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421a840*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421a8a0*/ int CalculateSize();
            /*0x421a920*/ void MergeFrom(YetiSimCoreLib.Components.PusheeComponent other);
            /*0x421a960*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421a980*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PusheeComponent.<> <>9;

                static /*0x421ab0c*/ <>c();
                /*0x421ab74*/ <>c();
                /*0x421ab7c*/ YetiSimCoreLib.Components.PusheeComponent <.cctor>b__27_0();
            }
        }

        class UnitAttachmentTracker : Google.Protobuf.IMessage<YetiSimCoreLib.Components.UnitAttachmentTracker>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.UnitAttachmentTracker>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.UnitAttachmentTracker>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitAttachmentTracker> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int detachTimeInTicks_;

            static /*0x421b15c*/ UnitAttachmentTracker();
            static /*0x421abd0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnitAttachmentTracker> get_Parser();
            static /*0x421ac28*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421ad78*/ UnitAttachmentTracker();
            /*0x421ad80*/ UnitAttachmentTracker(YetiSimCoreLib.Components.UnitAttachmentTracker other);
            /*0x421ad2c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421adcc*/ YetiSimCoreLib.Components.UnitAttachmentTracker Clone();
            /*0x421ae24*/ int get_DetachTimeInTicks();
            /*0x421ae2c*/ void set_DetachTimeInTicks(int value);
            /*0x421ae34*/ bool Equals(object other);
            /*0x421ae98*/ bool Equals(YetiSimCoreLib.Components.UnitAttachmentTracker other);
            /*0x421aed4*/ int GetHashCode();
            /*0x421af30*/ string ToString();
            /*0x421af88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421afa8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421b008*/ int CalculateSize();
            /*0x421b088*/ void MergeFrom(YetiSimCoreLib.Components.UnitAttachmentTracker other);
            /*0x421b0c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421b0e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.UnitAttachmentTracker.<> <>9;

                static /*0x421b274*/ <>c();
                /*0x421b2dc*/ <>c();
                /*0x421b2e4*/ YetiSimCoreLib.Components.UnitAttachmentTracker <.cctor>b__27_0();
            }
        }

        class PreviewZombie : Google.Protobuf.IMessage<YetiSimCoreLib.Components.PreviewZombie>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.PreviewZombie>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.PreviewZombie>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreviewZombie> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x421b7ac*/ PreviewZombie();
            static /*0x421b338*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.PreviewZombie> get_Parser();
            static /*0x421b390*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421b4e0*/ PreviewZombie();
            /*0x421b4e8*/ PreviewZombie(YetiSimCoreLib.Components.PreviewZombie other);
            /*0x421b494*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421b52c*/ YetiSimCoreLib.Components.PreviewZombie Clone();
            /*0x421b584*/ bool Equals(object other);
            /*0x421b608*/ bool Equals(YetiSimCoreLib.Components.PreviewZombie other);
            /*0x421b634*/ int GetHashCode();
            /*0x421b660*/ string ToString();
            /*0x421b6b8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421b6d8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421b6ec*/ int CalculateSize();
            /*0x421b700*/ void MergeFrom(YetiSimCoreLib.Components.PreviewZombie other);
            /*0x421b734*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421b754*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.PreviewZombie.<> <>9;

                static /*0x421b8c4*/ <>c();
                /*0x421b92c*/ <>c();
                /*0x421b934*/ YetiSimCoreLib.Components.PreviewZombie <.cctor>b__22_0();
            }
        }

        class MaterialComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.MaterialComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.MaterialComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.MaterialComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaterialComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.UnitMaterialType material_;

            static /*0x421bf14*/ MaterialComponent();
            static /*0x421b988*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.MaterialComponent> get_Parser();
            static /*0x421b9e0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421bb30*/ MaterialComponent();
            /*0x421bb38*/ MaterialComponent(YetiSimCoreLib.Components.MaterialComponent other);
            /*0x421bae4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421bb84*/ YetiSimCoreLib.Components.MaterialComponent Clone();
            /*0x421bbdc*/ Yeti.Data.UnitMaterialType get_Material();
            /*0x421bbe4*/ void set_Material(Yeti.Data.UnitMaterialType value);
            /*0x421bbec*/ bool Equals(object other);
            /*0x421bc50*/ bool Equals(YetiSimCoreLib.Components.MaterialComponent other);
            /*0x421bc8c*/ int GetHashCode();
            /*0x421bce8*/ string ToString();
            /*0x421bd40*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421bd60*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421bdc0*/ int CalculateSize();
            /*0x421be40*/ void MergeFrom(YetiSimCoreLib.Components.MaterialComponent other);
            /*0x421be80*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421bea0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.MaterialComponent.<> <>9;

                static /*0x421c02c*/ <>c();
                /*0x421c094*/ <>c();
                /*0x421c09c*/ YetiSimCoreLib.Components.MaterialComponent <.cctor>b__27_0();
            }
        }

        class SharedTriggerProcChanceComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SharedTriggerProcChanceComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SharedTriggerProcChanceComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SharedTriggerProcChanceComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SharedTriggerProcChanceComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int roll_;

            static /*0x421c67c*/ SharedTriggerProcChanceComponent();
            static /*0x421c0f0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SharedTriggerProcChanceComponent> get_Parser();
            static /*0x421c148*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421c298*/ SharedTriggerProcChanceComponent();
            /*0x421c2a0*/ SharedTriggerProcChanceComponent(YetiSimCoreLib.Components.SharedTriggerProcChanceComponent other);
            /*0x421c24c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421c2ec*/ YetiSimCoreLib.Components.SharedTriggerProcChanceComponent Clone();
            /*0x421c344*/ int get_Roll();
            /*0x421c34c*/ void set_Roll(int value);
            /*0x421c354*/ bool Equals(object other);
            /*0x421c3b8*/ bool Equals(YetiSimCoreLib.Components.SharedTriggerProcChanceComponent other);
            /*0x421c3f4*/ int GetHashCode();
            /*0x421c450*/ string ToString();
            /*0x421c4a8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421c4c8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421c528*/ int CalculateSize();
            /*0x421c5a8*/ void MergeFrom(YetiSimCoreLib.Components.SharedTriggerProcChanceComponent other);
            /*0x421c5e8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421c608*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SharedTriggerProcChanceComponent.<> <>9;

                static /*0x421c794*/ <>c();
                /*0x421c7fc*/ <>c();
                /*0x421c804*/ YetiSimCoreLib.Components.SharedTriggerProcChanceComponent <.cctor>b__27_0();
            }
        }

        class SharedActionProcChanceComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.SharedActionProcChanceComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.SharedActionProcChanceComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.SharedActionProcChanceComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SharedActionProcChanceComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int roll_;

            static /*0x421cde4*/ SharedActionProcChanceComponent();
            static /*0x421c858*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.SharedActionProcChanceComponent> get_Parser();
            static /*0x421c8b0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421ca00*/ SharedActionProcChanceComponent();
            /*0x421ca08*/ SharedActionProcChanceComponent(YetiSimCoreLib.Components.SharedActionProcChanceComponent other);
            /*0x421c9b4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421ca54*/ YetiSimCoreLib.Components.SharedActionProcChanceComponent Clone();
            /*0x421caac*/ int get_Roll();
            /*0x421cab4*/ void set_Roll(int value);
            /*0x421cabc*/ bool Equals(object other);
            /*0x421cb20*/ bool Equals(YetiSimCoreLib.Components.SharedActionProcChanceComponent other);
            /*0x421cb5c*/ int GetHashCode();
            /*0x421cbb8*/ string ToString();
            /*0x421cc10*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421cc30*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421cc90*/ int CalculateSize();
            /*0x421cd10*/ void MergeFrom(YetiSimCoreLib.Components.SharedActionProcChanceComponent other);
            /*0x421cd50*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421cd70*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.SharedActionProcChanceComponent.<> <>9;

                static /*0x421cefc*/ <>c();
                /*0x421cf64*/ <>c();
                /*0x421cf6c*/ YetiSimCoreLib.Components.SharedActionProcChanceComponent <.cctor>b__27_0();
            }
        }

        class InstantDefenseUnitComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.InstantDefenseUnitComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.InstantDefenseUnitComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.InstantDefenseUnitComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InstantDefenseUnitComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x421d434*/ InstantDefenseUnitComponent();
            static /*0x421cfc0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.InstantDefenseUnitComponent> get_Parser();
            static /*0x421d018*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421d168*/ InstantDefenseUnitComponent();
            /*0x421d170*/ InstantDefenseUnitComponent(YetiSimCoreLib.Components.InstantDefenseUnitComponent other);
            /*0x421d11c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421d1b4*/ YetiSimCoreLib.Components.InstantDefenseUnitComponent Clone();
            /*0x421d20c*/ bool Equals(object other);
            /*0x421d290*/ bool Equals(YetiSimCoreLib.Components.InstantDefenseUnitComponent other);
            /*0x421d2bc*/ int GetHashCode();
            /*0x421d2e8*/ string ToString();
            /*0x421d340*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421d360*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421d374*/ int CalculateSize();
            /*0x421d388*/ void MergeFrom(YetiSimCoreLib.Components.InstantDefenseUnitComponent other);
            /*0x421d3bc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421d3dc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.InstantDefenseUnitComponent.<> <>9;

                static /*0x421d54c*/ <>c();
                /*0x421d5b4*/ <>c();
                /*0x421d5bc*/ YetiSimCoreLib.Components.InstantDefenseUnitComponent <.cctor>b__22_0();
            }
        }

        class UnitTagsComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x421d668*/ UnitTagsComponentReflection();
            static /*0x421d610*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class UnlimitedResourcesReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x421ddd4*/ UnlimitedResourcesReflection();
            static /*0x421dd7c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class UnlimitedResourcesComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.UnlimitedResourcesComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.UnlimitedResourcesComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.UnlimitedResourcesComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnlimitedResourcesComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x421e590*/ UnlimitedResourcesComponent();
            static /*0x421e11c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.UnlimitedResourcesComponent> get_Parser();
            static /*0x421e174*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421e2c4*/ UnlimitedResourcesComponent();
            /*0x421e2cc*/ UnlimitedResourcesComponent(YetiSimCoreLib.Components.UnlimitedResourcesComponent other);
            /*0x421e278*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421e310*/ YetiSimCoreLib.Components.UnlimitedResourcesComponent Clone();
            /*0x421e368*/ bool Equals(object other);
            /*0x421e3ec*/ bool Equals(YetiSimCoreLib.Components.UnlimitedResourcesComponent other);
            /*0x421e418*/ int GetHashCode();
            /*0x421e444*/ string ToString();
            /*0x421e49c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421e4bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421e4d0*/ int CalculateSize();
            /*0x421e4e4*/ void MergeFrom(YetiSimCoreLib.Components.UnlimitedResourcesComponent other);
            /*0x421e518*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421e538*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.UnlimitedResourcesComponent.<> <>9;

                static /*0x421e6a8*/ <>c();
                /*0x421e710*/ <>c();
                /*0x421e718*/ YetiSimCoreLib.Components.UnlimitedResourcesComponent <.cctor>b__22_0();
            }
        }

        class VelocityComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x421e7c4*/ VelocityComponentReflection();
            static /*0x421e76c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class VelocityComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.VelocityComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.VelocityComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.VelocityComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.VelocityComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int vx_;
            /*0x1c*/ int vy_;
            /*0x20*/ int vz_;

            static /*0x421f548*/ VelocityComponent();
            static /*0x421ee2c*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.VelocityComponent> get_Parser();
            static /*0x421ee84*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421efd4*/ VelocityComponent();
            /*0x421efdc*/ VelocityComponent(YetiSimCoreLib.Components.VelocityComponent other);
            /*0x421ef88*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421f030*/ YetiSimCoreLib.Components.VelocityComponent Clone();
            /*0x421f088*/ int get_Vx();
            /*0x421f090*/ void set_Vx(int value);
            /*0x421f098*/ int get_Vy();
            /*0x421f0a0*/ void set_Vy(int value);
            /*0x421f0a8*/ int get_Vz();
            /*0x421f0b0*/ void set_Vz(int value);
            /*0x421f0b8*/ bool Equals(object other);
            /*0x421f11c*/ bool Equals(YetiSimCoreLib.Components.VelocityComponent other);
            /*0x421f178*/ int GetHashCode();
            /*0x421f20c*/ string ToString();
            /*0x421f264*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421f284*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421f334*/ int CalculateSize();
            /*0x421f414*/ void MergeFrom(YetiSimCoreLib.Components.VelocityComponent other);
            /*0x421f46c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421f48c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.VelocityComponent.<> <>9;

                static /*0x421f660*/ <>c();
                /*0x421f6c8*/ <>c();
                /*0x421f6d0*/ YetiSimCoreLib.Components.VelocityComponent <.cctor>b__37_0();
            }
        }

        class AccelerationComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.AccelerationComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.AccelerationComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.AccelerationComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AccelerationComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int ax_;
            /*0x1c*/ int ay_;
            /*0x20*/ int az_;

            static /*0x421fe40*/ AccelerationComponent();
            static /*0x421f724*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.AccelerationComponent> get_Parser();
            static /*0x421f77c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x421f8cc*/ AccelerationComponent();
            /*0x421f8d4*/ AccelerationComponent(YetiSimCoreLib.Components.AccelerationComponent other);
            /*0x421f880*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x421f928*/ YetiSimCoreLib.Components.AccelerationComponent Clone();
            /*0x421f980*/ int get_Ax();
            /*0x421f988*/ void set_Ax(int value);
            /*0x421f990*/ int get_Ay();
            /*0x421f998*/ void set_Ay(int value);
            /*0x421f9a0*/ int get_Az();
            /*0x421f9a8*/ void set_Az(int value);
            /*0x421f9b0*/ bool Equals(object other);
            /*0x421fa14*/ bool Equals(YetiSimCoreLib.Components.AccelerationComponent other);
            /*0x421fa70*/ int GetHashCode();
            /*0x421fb04*/ string ToString();
            /*0x421fb5c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x421fb7c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x421fc2c*/ int CalculateSize();
            /*0x421fd0c*/ void MergeFrom(YetiSimCoreLib.Components.AccelerationComponent other);
            /*0x421fd64*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x421fd84*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.AccelerationComponent.<> <>9;

                static /*0x421ff58*/ <>c();
                /*0x421ffc0*/ <>c();
                /*0x421ffc8*/ YetiSimCoreLib.Components.AccelerationComponent <.cctor>b__37_0();
            }
        }

        class WaitingOnInputComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4220074*/ WaitingOnInputComponentReflection();
            static /*0x422001c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class WaitingOnInputComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.WaitingOnInputComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.WaitingOnInputComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.WaitingOnInputComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaitingOnInputComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4220830*/ WaitingOnInputComponent();
            static /*0x42203bc*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaitingOnInputComponent> get_Parser();
            static /*0x4220414*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4220564*/ WaitingOnInputComponent();
            /*0x422056c*/ WaitingOnInputComponent(YetiSimCoreLib.Components.WaitingOnInputComponent other);
            /*0x4220518*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x42205b0*/ YetiSimCoreLib.Components.WaitingOnInputComponent Clone();
            /*0x4220608*/ bool Equals(object other);
            /*0x422068c*/ bool Equals(YetiSimCoreLib.Components.WaitingOnInputComponent other);
            /*0x42206b8*/ int GetHashCode();
            /*0x42206e4*/ string ToString();
            /*0x422073c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x422075c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4220770*/ int CalculateSize();
            /*0x4220784*/ void MergeFrom(YetiSimCoreLib.Components.WaitingOnInputComponent other);
            /*0x42207b8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x42207d8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.WaitingOnInputComponent.<> <>9;

                static /*0x4220948*/ <>c();
                /*0x42209b0*/ <>c();
                /*0x42209b8*/ YetiSimCoreLib.Components.WaitingOnInputComponent <.cctor>b__22_0();
            }
        }

        class WaveGeneratorComponentReflection
        {
            static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

            static /*0x4220a64*/ WaveGeneratorComponentReflection();
            static /*0x4220a0c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
        }

        class WaveGeneratorComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.WaveGeneratorComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.WaveGeneratorComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.WaveGeneratorComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaveGeneratorComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ int currentTick_;
            /*0x1c*/ int lastSpawnedGlobalTick_;
            /*0x20*/ int nextWaveIndex_;
            /*0x24*/ bool isStalled_;
            /*0x28*/ int stallWaveHealthTotal_;
            /*0x2c*/ bool sunGenerationStopped_;
            /*0x30*/ int maxStallTicks_;
            /*0x34*/ int waveHealthThresholdPercent_;
            /*0x38*/ bool sunGenerationWarningEndingFired_;

            static /*0x422206c*/ WaveGeneratorComponent();
            static /*0x4221454*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaveGeneratorComponent> get_Parser();
            static /*0x42214ac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42215fc*/ WaveGeneratorComponent();
            /*0x4221604*/ WaveGeneratorComponent(YetiSimCoreLib.Components.WaveGeneratorComponent other);
            /*0x42215b0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4221680*/ YetiSimCoreLib.Components.WaveGeneratorComponent Clone();
            /*0x42216d8*/ int get_CurrentTick();
            /*0x42216e0*/ void set_CurrentTick(int value);
            /*0x42216e8*/ int get_LastSpawnedGlobalTick();
            /*0x42216f0*/ void set_LastSpawnedGlobalTick(int value);
            /*0x42216f8*/ int get_NextWaveIndex();
            /*0x4221700*/ void set_NextWaveIndex(int value);
            /*0x4221708*/ bool get_IsStalled();
            /*0x4221710*/ void set_IsStalled(bool value);
            /*0x4221718*/ int get_StallWaveHealthTotal();
            /*0x4221720*/ void set_StallWaveHealthTotal(int value);
            /*0x4221728*/ bool get_SunGenerationStopped();
            /*0x4221730*/ void set_SunGenerationStopped(bool value);
            /*0x4221738*/ int get_MaxStallTicks();
            /*0x4221740*/ void set_MaxStallTicks(int value);
            /*0x4221748*/ int get_WaveHealthThresholdPercent();
            /*0x4221750*/ void set_WaveHealthThresholdPercent(int value);
            /*0x4221758*/ bool get_SunGenerationWarningEndingFired();
            /*0x4221760*/ void set_SunGenerationWarningEndingFired(bool value);
            /*0x4221768*/ bool Equals(object other);
            /*0x42217cc*/ bool Equals(YetiSimCoreLib.Components.WaveGeneratorComponent other);
            /*0x42218b8*/ int GetHashCode();
            /*0x4221a44*/ string ToString();
            /*0x4221a9c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4221abc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4221c5c*/ int CalculateSize();
            /*0x4221df8*/ void MergeFrom(YetiSimCoreLib.Components.WaveGeneratorComponent other);
            /*0x4221ea4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4221ec4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.WaveGeneratorComponent.<> <>9;

                static /*0x4222184*/ <>c();
                /*0x42221ec*/ <>c();
                /*0x42221f4*/ YetiSimCoreLib.Components.WaveGeneratorComponent <.cctor>b__67_0();
            }
        }

        class WaveStateComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.WaveStateComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.WaveStateComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.WaveStateComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaveStateComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
            /*0x18*/ Yeti.Data.WaveState state_;

            static /*0x4222938*/ WaveStateComponent();
            static /*0x4222248*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaveStateComponent> get_Parser();
            static /*0x42222a0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x42223f0*/ WaveStateComponent();
            /*0x42223f8*/ WaveStateComponent(YetiSimCoreLib.Components.WaveStateComponent other);
            /*0x42223a4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4222468*/ YetiSimCoreLib.Components.WaveStateComponent Clone();
            /*0x42224c0*/ Yeti.Data.WaveState get_State();
            /*0x42224c8*/ void set_State(Yeti.Data.WaveState value);
            /*0x42224d0*/ bool Equals(object other);
            /*0x4222534*/ bool Equals(YetiSimCoreLib.Components.WaveStateComponent other);
            /*0x4222594*/ int GetHashCode();
            /*0x42225e8*/ string ToString();
            /*0x4222640*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4222660*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x42226c0*/ int CalculateSize();
            /*0x4222740*/ void MergeFrom(YetiSimCoreLib.Components.WaveStateComponent other);
            /*0x422280c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x422282c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.WaveStateComponent.<> <>9;

                static /*0x4222a50*/ <>c();
                /*0x4222ab8*/ <>c();
                /*0x4222ac0*/ YetiSimCoreLib.Components.WaveStateComponent <.cctor>b__27_0();
            }
        }

        class WaveUnitComponent : Google.Protobuf.IMessage<YetiSimCoreLib.Components.WaveUnitComponent>, Google.Protobuf.IMessage, System.IEquatable<YetiSimCoreLib.Components.WaveUnitComponent>, Google.Protobuf.IDeepCloneable<YetiSimCoreLib.Components.WaveUnitComponent>, Google.Protobuf.IBufferMessage, Entitas.IComponent
        {
            static /*0x0*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaveUnitComponent> _parser;
            /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

            static /*0x4222f88*/ WaveUnitComponent();
            static /*0x4222b14*/ Google.Protobuf.MessageParser<YetiSimCoreLib.Components.WaveUnitComponent> get_Parser();
            static /*0x4222b6c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
            /*0x4222cbc*/ WaveUnitComponent();
            /*0x4222cc4*/ WaveUnitComponent(YetiSimCoreLib.Components.WaveUnitComponent other);
            /*0x4222c70*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
            /*0x4222d08*/ YetiSimCoreLib.Components.WaveUnitComponent Clone();
            /*0x4222d60*/ bool Equals(object other);
            /*0x4222de4*/ bool Equals(YetiSimCoreLib.Components.WaveUnitComponent other);
            /*0x4222e10*/ int GetHashCode();
            /*0x4222e3c*/ string ToString();
            /*0x4222e94*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x4222eb4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
            /*0x4222ec8*/ int CalculateSize();
            /*0x4222edc*/ void MergeFrom(YetiSimCoreLib.Components.WaveUnitComponent other);
            /*0x4222f10*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x4222f30*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

            class <>c
            {
                static /*0x0*/ YetiSimCoreLib.Components.WaveUnitComponent.<> <>9;

                static /*0x42230a0*/ <>c();
                /*0x4223108*/ <>c();
                /*0x4223110*/ YetiSimCoreLib.Components.WaveUnitComponent <.cctor>b__22_0();
            }
        }
    }
}
