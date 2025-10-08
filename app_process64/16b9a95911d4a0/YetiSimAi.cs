class <Module>
{
}

namespace YetiSimAi
{
    namespace Util
    {
        struct Rect
        {
            /*0x10*/ int XMin;
            /*0x14*/ int ZMin;
            /*0x18*/ int XMax;
            /*0x1c*/ int ZMax;

            /*0x4107080*/ bool Contains(int x, int z);
            /*0x41070bc*/ void Scale(int value);
            /*0x41070d0*/ void Move(int x, int y);
            /*0x41070ec*/ bool Overlaps(YetiSimAi.Util.Rect other);
        }
    }

    namespace Runner
    {
        class AiUpdateHook
        {
            /*0x10*/ YetiSimAi.Core.SimulationStateTracker <SimulationStateTracker>k__BackingField;
            /*0x18*/ YetiSimAi.Core.IAi _ai;
            /*0x20*/ bool _isPaused;

            /*0x4107138*/ AiUpdateHook(YetiSimCoreLib.Core.IYetiSimContext simContext, Yeti.Data.GameInitState gameInitState, YetiSimCoreLib.Game.UnitDatabase unitDatabase, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider, int gestaltId);
            /*0x4107130*/ YetiSimAi.Core.SimulationStateTracker get_SimulationStateTracker();
            /*0x4107de8*/ void Pause();
            /*0x4107df4*/ void Resume();
            /*0x4107ea0*/ void Update(float deltaTime);
            /*0x4107c78*/ void Subscribe(YetiSimCoreLib.Core.IYetiSimContext simContext);
            /*0x4107f68*/ void HandlePointOfLoss(YetiSimCoreLib.Messaging.Events.PointOfLossEventArgs args);
        }
    }

    namespace Core
    {
        interface IPlayValidator
        {
            bool IsValidUnitPlacementPlay(int row, int column, int unitId);
            bool IsValidInstantPlantUsePlay(int row, int column, int unitId);
            /*0x1f2fe40*/ bool IsValidReclaimPlantPlay(int unitInstanceId);
        }

        class AiRulesUtil : YetiSimAi.Core.IPlayValidator
        {
            /*0x10*/ YetiSimAi.Core.ICoreSimAiApi _coreSimAiApi;
            /*0x18*/ YetiSimAi.Core.IGameStateSnapshot _gameStateSnapshot;

            /*0x4107474*/ AiRulesUtil(YetiSimAi.Core.ICoreSimAiApi coreSimAiApi, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            /*0x410800c*/ bool IsValidUnitPlacementPlay(int row, int column, int unitId);
            /*0x410818c*/ bool IsUnitPlacementValidForCell(int loadOutIndex, YetiSimCoreLib.Game.GridCell gridCell);
            /*0x4108254*/ bool IsValidInstantPlantUsePlay(int row, int column, int unitId);
            /*0x4108324*/ bool IsValidReclaimPlantPlay(int unitInstanceId);
        }

        class CompositeFilteredOptionComparer : System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption>
        {
            /*0x10*/ System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> _comparers;

            /*0x41083dc*/ CompositeFilteredOptionComparer(System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> comparers);
            /*0x4108464*/ int Compare(YetiSimAi.Core.FilteredOption x, YetiSimAi.Core.FilteredOption y);
        }

        class ClosestCellWithZombieFilteredOptionComparer : System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption>
        {
            static /*0x0*/ YetiSimAi.Core.ClosestCellWithZombieFilteredOptionComparer Instance;

            static /*0x4108d68*/ ClosestCellWithZombieFilteredOptionComparer();
            /*0x4108d60*/ ClosestCellWithZombieFilteredOptionComparer();
            /*0x410858c*/ int Compare(YetiSimAi.Core.FilteredOption x, YetiSimAi.Core.FilteredOption y);
        }

        class LeftMostColumnFilteredOptionComparer : System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption>
        {
            static /*0x0*/ YetiSimAi.Core.LeftMostColumnFilteredOptionComparer Instance;

            static /*0x4108dfc*/ LeftMostColumnFilteredOptionComparer();
            /*0x4108df4*/ LeftMostColumnFilteredOptionComparer();
            /*0x4108dd0*/ int Compare(YetiSimAi.Core.FilteredOption x, YetiSimAi.Core.FilteredOption y);
        }

        interface IUnitIdsProvider
        {
            /*0x1f30214*/ System.Collections.Generic.ISet<int> get_UnitIds();
            /*0x1f2fe40*/ bool IncludesUnit(int unitId);
        }

        class SingleUnitIdProvider : YetiSimAi.Core.IUnitIdsProvider
        {
            /*0x10*/ System.Collections.Generic.HashSet<int> _unitIds;

            /*0x4108f98*/ SingleUnitIdProvider(int unitId);
            /*0x4108e64*/ bool Equals(YetiSimAi.Core.SingleUnitIdProvider other);
            /*0x4108e80*/ bool Equals(object obj);
            /*0x4108f80*/ int GetHashCode();
            /*0x4109060*/ System.Collections.Generic.ISet<int> get_UnitIds();
            /*0x4109068*/ bool IncludesUnit(int unitId);
        }

        class FilteredOptionsProvider : System.MulticastDelegate
        {
            /*0x41090d4*/ FilteredOptionsProvider(object object, nint method);
            /*0x41091dc*/ System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> Invoke(YetiSimAi.Core.IUnitIdsProvider unitsToConsider);
        }

        enum ActionProviderSupportsMode
        {
            SameAsUnitsToConsider = 0,
            Always = 1,
            Never = 2,
        }

        class ComposedActionProvider : YetiSimAi.Core.IActionProvider
        {
            /*0x10*/ string _name;
            /*0x18*/ YetiSimAi.Core.IUnitIdsProvider _supportedUnitsProvider;
            /*0x20*/ YetiSimAi.Core.FilteredOptionsProvider _filteredOptionsProvider;
            /*0x28*/ System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> _comparer;
            /*0x30*/ YetiSimAi.Core.IUnitIdsProvider _preparingPlantsUnitsProvider;
            /*0x38*/ YetiSimAi.Core.ActionProviderSupportsMode _supportsMode;

            /*0x41091f0*/ ComposedActionProvider(string name, YetiSimAi.Core.FilteredOptionsProvider filteredOptionsProvider, System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> comparer, YetiSimAi.Core.IUnitIdsProvider supportedUnitsProvider, YetiSimAi.Core.IUnitIdsProvider preparingPlantsUnitsProvider, YetiSimAi.Core.ActionProviderSupportsMode supportsMode);
            /*0x410928c*/ bool SupportsLoadOut(YetiSimAi.Core.IGameStateSnapshot snapshot);
            /*0x41096c4*/ System.Nullable<YetiSimAi.Core.AiAction> GetAction();
        }

        interface ICoreSimAiApi
        {
            void PlaceLoadoutPlant(int loadoutIndex, YetiSimCoreLib.Game.GridCell gridCell);
            void ReclaimPlant(YetiSimCoreLib.Game.InstanceId instanceId);
            void PlaceInstantUsePlant(int unitId, YetiSimCoreLib.Game.GridCell placementCell);
            void CollectSun(YetiSimCoreLib.Game.InstanceId sunInstanceId);
            void CollectDrop(YetiSimCoreLib.Game.InstanceId dropInstanceId);
            /*0x1f30a84*/ void SendLossAversionResponse(bool activate);
            Yeti.Data.Messaging.Events.YetiSimErrorCode ValidatePlantPlacement(int loadoutIndex, YetiSimCoreLib.Game.GridCell gridcell);
            Yeti.Data.Messaging.Events.YetiSimErrorCode ValidateInstantUsePlantPlacement(int row, int column, int unitId);
            Yeti.Data.Messaging.Events.YetiSimErrorCode ValidateReclaimPlantPlacement(int unitInstanceId);
        }

        class CoreSimAiApi : YetiSimAi.Core.ICoreSimAiApi
        {
            /*0x10*/ YetiSimCoreLib.Core.IYetiSimContext _context;

            /*0x4107444*/ CoreSimAiApi(YetiSimCoreLib.Core.IYetiSimContext simContext);
            /*0x41098c8*/ void PlaceLoadoutPlant(int loadoutIndex, YetiSimCoreLib.Game.GridCell gridCell);
            /*0x4109a64*/ void ReclaimPlant(YetiSimCoreLib.Game.InstanceId instanceId);
            /*0x4109bf8*/ void PlaceInstantUsePlant(int unitId, YetiSimCoreLib.Game.GridCell placementCell);
            /*0x4109dd4*/ void CollectSun(YetiSimCoreLib.Game.InstanceId sunInstanceId);
            /*0x4109f68*/ void CollectDrop(YetiSimCoreLib.Game.InstanceId dropInstanceId);
            /*0x410a0fc*/ void SendLossAversionResponse(bool activate);
            /*0x410a290*/ Yeti.Data.Messaging.Events.YetiSimErrorCode ValidatePlantPlacement(int loadoutIndex, YetiSimCoreLib.Game.GridCell gridcell);
            /*0x410a3c4*/ Yeti.Data.Messaging.Events.YetiSimErrorCode ValidateInstantUsePlantPlacement(int row, int column, int unitId);
            /*0x410a500*/ Yeti.Data.Messaging.Events.YetiSimErrorCode ValidateReclaimPlantPlacement(int unitInstanceId);
        }

        struct FilteredOption
        {
            /*0x10*/ YetiSimAi.Core.IGameStateSnapshot <GameStateSnapshot>k__BackingField;
            /*0x18*/ int <Column>k__BackingField;
            /*0x1c*/ int <Row>k__BackingField;
            /*0x20*/ int <UnitId>k__BackingField;
            /*0x24*/ int <InstanceId>k__BackingField;
            /*0x28*/ YetiSimAi.Core.ActionType <ActionType>k__BackingField;

            /*0x410a624*/ YetiSimAi.Core.IGameStateSnapshot get_GameStateSnapshot();
            /*0x410a62c*/ void set_GameStateSnapshot(YetiSimAi.Core.IGameStateSnapshot value);
            /*0x410a634*/ int get_Column();
            /*0x410a63c*/ void set_Column(int value);
            /*0x410a644*/ int get_Row();
            /*0x410a64c*/ void set_Row(int value);
            /*0x410a654*/ int get_UnitId();
            /*0x410a65c*/ void set_UnitId(int value);
            /*0x410a664*/ int get_InstanceId();
            /*0x410a66c*/ void set_InstanceId(int value);
            /*0x410a674*/ YetiSimAi.Core.ActionType get_ActionType();
            /*0x410a67c*/ void set_ActionType(YetiSimAi.Core.ActionType value);
        }

        class AiConfigFactory
        {
            /*0x10*/ YetiSimAi.Core.IUnitGroupProvider _unitGroupProvider;
            /*0x18*/ YetiSimAi.Core.IActionProviderFactory _actionProviderFactory;
            /*0x20*/ YetiSimAi.Core.IActionResolverFactory _actionResolverFactory;
            /*0x28*/ YetiSimAi.Core.PriorityCalculatorFactory _priorityCalculatorFactory;
            /*0x30*/ YetiSimAi.Core.ICoreSimAiApi _coreSimAiApi;
            /*0x38*/ PvzN3xt.Data.AiConfig _config;

            /*0x41074b8*/ AiConfigFactory(PvzN3xt.Data.AiConfig config, YetiSimAi.Core.ICoreSimAiApi coreSimAiApi, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot, YetiSimAi.Core.IPlayValidator playValidator, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider, YetiSimAi.Core.IUnitGroupProvider unitGroupProvider);
            /*0x410778c*/ YetiSimAi.Core.Gestalt GestaltForId(int gestaltId, YetiSimAi.Core.SimulationStateTracker simulationStateTracker, YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot gameStateSnapshot);
            /*0x410ab00*/ PvzN3xt.Data.AiGestaltConfig GestaltConfigForId(int gestaltId);
            /*0x410ae80*/ PvzN3xt.Data.AiPriorityResolverConfig PriorityResolverForId(int priorityResolverId);
        }

        class AiGameDataConfigurationException : System.Exception
        {
            /*0x410b490*/ AiGameDataConfigurationException(string message);
            /*0x410b4f8*/ AiGameDataConfigurationException(string message, System.Exception innerException);
        }

        class FilteredOptionComparerCalculationFactory
        {
            /*0x10*/ YetiSimAi.Core.UnitIdsProviderFactory _unitGroupProviderFactory;

            static /*0x410bbb8*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory.OpForInput OpFor(PvzN3xt.Data.AiFilteredOptionCalculationOperation.Types.OpType configOpOperationType);
            static /*0x410be40*/ int MinusOp(int left, int right);
            static /*0x410be48*/ int PlusOp(int left, int right);
            /*0x410b568*/ FilteredOptionComparerCalculationFactory(YetiSimAi.Core.UnitIdsProviderFactory unitGroupProviderFactory);
            /*0x410b598*/ System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> BuildFor(PvzN3xt.Data.AiFilteredOptionComparerTypeCalculation config);
            /*0x410b9b8*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory.ValueForInput ValueFor(PvzN3xt.Data.AiFilteredOptionCalculationInput configOpInput);

            class ValueForInput : System.MulticastDelegate
            {
                /*0x410bd00*/ ValueForInput(object object, nint method);
                /*0x410be50*/ int Invoke(YetiSimAi.Core.FilteredOption option);
            }

            class OpForInput : System.MulticastDelegate
            {
                /*0x410bda0*/ OpForInput(object object, nint method);
                /*0x410be84*/ int Invoke(int left, int right);
            }

            class CalculatedFilteredOptionComparer : System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption>
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.FilteredOptionComparerCalculationFactory.CalculationInput> _inputs;
                /*0x18*/ bool _isGreaterThanComparison;

                /*0x410bcbc*/ CalculatedFilteredOptionComparer(System.Collections.Generic.List<YetiSimAi.Core.FilteredOptionComparerCalculationFactory.CalculationInput> inputs, bool isGreaterThanComparison);
                /*0x410be98*/ int Compare(YetiSimAi.Core.FilteredOption o1, YetiSimAi.Core.FilteredOption o2);
                /*0x410bf14*/ int Calculate(YetiSimAi.Core.FilteredOption fo);
            }

            class CalculationInput
            {
                /*0x10*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory.ValueForInput Value;
                /*0x18*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory.OpForInput Op;

                /*0x410b9b0*/ CalculationInput();
            }

            class <>c
            {
                static /*0x0*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory.<> <>9;
                static /*0x8*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory.ValueForInput <>9__6_0;

                static /*0x410c13c*/ <>c();
                /*0x410c1a4*/ <>c();
                /*0x410c1ac*/ int <ValueFor>b__6_0(YetiSimAi.Core.FilteredOption filteredOption);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory <>4__this;
                /*0x18*/ PvzN3xt.Data.AiFilteredOptionCalculationInputTypeCountOfSpecifiedPlantsInRow countOfSpecifiedPlantsInRow;

                /*0x410bcf8*/ <>c__DisplayClass6_0();
                /*0x410c2d8*/ int <ValueFor>b__1(YetiSimAi.Core.FilteredOption filteredOption);
            }
        }

        class FilteredOptionsConditionsFactory
        {
            /*0x10*/ YetiSimAi.Core.RowConditionFactory _rowConditionFactory;
            /*0x18*/ YetiSimAi.Core.GridCellConditionFactory _gridCellConditionFactory;

            /*0x410a708*/ FilteredOptionsConditionsFactory(YetiSimAi.Core.RowConditionFactory rowConditionFactory, YetiSimAi.Core.GridCellConditionFactory gridCellConditionFactory);
            /*0x410c69c*/ YetiSimAi.Core.IRowCondition RowConditionFor(PvzN3xt.Data.AiFilteredOptionRowConditions config);
            /*0x410cb48*/ YetiSimAi.Core.IGridCellCondition GridCellConditionFor(PvzN3xt.Data.AiFilteredOptionCellConditions config);
        }

        class FilteredOptionsProviderFactory
        {
            /*0x10*/ YetiSimAi.Core.IGameStateSnapshot _gameStateSnapshot;
            /*0x18*/ YetiSimAi.Core.IPlayValidator _playValidator;

            static /*0x410d0c4*/ YetiSimAi.Core.FilteredOptionsProviderFactory.UnitOptionsType UnitOptionTypeFor(PvzN3xt.Data.AiPlaceUnitFilteringOptionType gameDataType);
            /*0x410a74c*/ FilteredOptionsProviderFactory(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot, YetiSimAi.Core.IPlayValidator playValidator);
            /*0x410d158*/ YetiSimAi.Core.FilteredOptionsProvider Create(YetiSimAi.Core.IRowStateColumnComparison rowStateColumnComparison, YetiSimAi.Core.ColumnIterator.Direction columnIterationDirection, int minDistance, int maxDistance, YetiSimAi.Core.FilteredOptionsProviderFactory.UnitOptionsType unitOptionsType, YetiSimAi.Core.FilteredOptionsProviderFactory.ActionType actionType, YetiSimAi.Core.IRowCondition rowCondition, YetiSimAi.Core.IGridCellCondition gridCellCondition);
            /*0x410d28c*/ void AddAllValidInstantUseActionsForCell(int row, int col, YetiSimAi.Core.IUnitIdsProvider unitsToConsider, System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> filteredOptions);
            /*0x410d798*/ void AddAllValidPlacePlantActionsForCell(int row, int col, YetiSimAi.Core.IUnitIdsProvider unitsToConsider, System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> filteredOptions);
            /*0x410dbc4*/ void AddAllValidShovelPlantActionsForCell(int row, int col, YetiSimAi.Core.IUnitIdsProvider unitsToConsider, System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> filteredOptions);
            /*0x410e3f4*/ void AddFirstValidInstantUseActionForCell(int row, int col, YetiSimAi.Core.IUnitIdsProvider unitsToConsider, System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> filteredOptions);
            /*0x410e79c*/ void AddFirstValidShovelPlantActionForCell(int row, int col, YetiSimAi.Core.IUnitIdsProvider unitsToConsider, System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> filteredOptions);
            /*0x410eb50*/ void AddFirstValidPlacePlantActionForCell(int row, int col, YetiSimAi.Core.IUnitIdsProvider unitsToConsider, System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> filteredOptions);
            /*0x410d640*/ bool IsInstantUsePlayValid(int row, int col, int unitId);
            /*0x410df84*/ bool TryGetValidShovelPlantPlay(int row, int col, int unitId, ref int instanceId);

            enum ActionType
            {
                PlacePlant = 0,
                PlaceInstantUsePlant = 1,
                ShovelPlant = 2,
            }

            enum UnitOptionsType
            {
                FirstPlaceableUnit = 0,
                AllPlaceableUnits = 1,
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ YetiSimAi.Core.FilteredOptionsProviderFactory <>4__this;
                /*0x18*/ YetiSimAi.Core.IRowStateColumnComparison rowStateColumnComparison;
                /*0x20*/ YetiSimAi.Core.IRowCondition rowCondition;
                /*0x28*/ int maxDistance;
                /*0x2c*/ YetiSimAi.Core.ColumnIterator.Direction columnIterationDirection;
                /*0x30*/ int minDistance;
                /*0x38*/ YetiSimAi.Core.IGridCellCondition gridCellCondition;
                /*0x40*/ YetiSimAi.Core.FilteredOptionsProviderFactory.UnitOptionsType unitOptionsType;
                /*0x44*/ YetiSimAi.Core.FilteredOptionsProviderFactory.ActionType actionType;

                /*0x410d284*/ <>c__DisplayClass6_0();
                /*0x410ef70*/ System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> <Create>b__0(YetiSimAi.Core.IUnitIdsProvider unitsToConsider);
            }

            class <>c__DisplayClass6_1
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider unitsToConsider;
                /*0x18*/ System.Collections.Generic.List<YetiSimAi.Core.FilteredOption> filteredOptions;
                /*0x20*/ YetiSimAi.Core.FilteredOptionsProviderFactory.<> CS$<>8__locals1;

                /*0x410f648*/ <>c__DisplayClass6_1();
            }

            class <>c__DisplayClass6_2
            {
                /*0x10*/ YetiSimAi.Core.RowState rowState;
                /*0x18*/ YetiSimAi.Core.FilteredOptionsProviderFactory.<> CS$<>8__locals2;

                /*0x410f650*/ <>c__DisplayClass6_2();
                /*0x410f7a0*/ void <Create>b__1(int col);
            }
        }

        class GridCellConditionFactory
        {
            /*0x410a700*/ GridCellConditionFactory();
            /*0x410cbf4*/ YetiSimAi.Core.IGridCellCondition For(PvzN3xt.Data.AiFilteredOptionCellConditions config);
            /*0x410faa4*/ YetiSimAi.Core.IGridCellCondition BuildCondition(PvzN3xt.Data.AiFilteredOptionCellCondition config);

            class HasNoZombiesGridCellCondition : YetiSimAi.Core.IGridCellCondition
            {
                static /*0x0*/ YetiSimAi.Core.GridCellConditionFactory.HasNoZombiesGridCellCondition Instance;

                static /*0x410fce4*/ HasNoZombiesGridCellCondition();
                /*0x410fcdc*/ HasNoZombiesGridCellCondition();
                /*0x410fb8c*/ bool Evaluate(YetiSimCoreLib.Game.GridCell gridCell, YetiSimAi.Core.IGameStateSnapshot snapshot);
            }
        }

        interface IActionProviderFactory
        {
            /*0x1f30240*/ YetiSimAi.Core.IActionProvider ForId(int actionProviderId);
        }

        class GameDataActionProviderFactory : YetiSimAi.Core.IActionProviderFactory
        {
            /*0x10*/ Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiActionProvider> _config;
            /*0x18*/ YetiSimAi.Core.UnitIdsProviderFactory _unitIdsProviderFactory;
            /*0x20*/ YetiSimAi.Core.FilteredOptionsProviderFactory _filteredOptionsProviderFactory;
            /*0x28*/ YetiSimAi.Core.FilteredOptionComparerCalculationFactory _filteredOptionComparerCalculationFactory;
            /*0x30*/ YetiSimAi.Core.FilteredOptionsConditionsFactory _filteredOptionsConditionsFactory;
            /*0x38*/ YetiSimAi.Core.RowStateColumnComparisonFactory _rowStateColumnComparisonFactory;
            /*0x40*/ YetiSimAi.Core.ZombiesInTargetingAreaFilteredOptionComparer _zombiesInTargetingAreaFilteredOptionComparer;
            /*0x48*/ YetiSimAi.Core.ZombiesInOrWillCrossTargetingAreaFilteredOptionComparer _zombiesInOrWillCrossTargetingAreaFilteredOptionComparer;

            /*0x410a790*/ GameDataActionProviderFactory(Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiActionProvider> config, YetiSimAi.Core.IUnitGroupProvider unitGroupProvider, YetiSimAi.Core.FilteredOptionsProviderFactory filteredOptionsProviderFactory, YetiSimAi.Core.FilteredOptionsConditionsFactory filteredOptionsConditionsFactory, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            /*0x410fd7c*/ YetiSimAi.Core.IActionProvider ForId(int actionProviderId);
            /*0x4110104*/ YetiSimAi.Core.IActionProvider Build(PvzN3xt.Data.AiActionProvider actionProviderConfig);
            /*0x41101e0*/ YetiSimAi.Core.IActionProvider BuildPlacePlant(PvzN3xt.Data.AiActionProvider actionProviderConfig);
            /*0x4110474*/ YetiSimAi.Core.IActionProvider BuildPlaceInstantUsePlant(PvzN3xt.Data.AiActionProvider actionProviderConfig);
            /*0x4110708*/ YetiSimAi.Core.IActionProvider BuildShovelPlant(PvzN3xt.Data.AiActionProvider actionProviderConfig);
            /*0x4110c50*/ System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> BuildComparer(Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiFilteredOptionComparer> filteredOptionComparers);
            /*0x4110e34*/ System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> ComparerFor(PvzN3xt.Data.AiFilteredOptionComparer filteredOptionComparer);

            class ColumnPreferencesFilteredOptionsComparerFactory
            {
                static /*0x4110f90*/ System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption> BuildFor(PvzN3xt.Data.AiFilteredOptionComparerTypeColumnPreferences config);

                class ColumnPreferencesFilteredOptionComparer : System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption>
                {
                    /*0x10*/ int[] _columnPreferenceIndices;

                    /*0x4110ff4*/ ColumnPreferencesFilteredOptionComparer(Google.Protobuf.Collections.RepeatedField<int> columnPreferences);
                    /*0x41110e4*/ int GetColumnPreferenceIndexForColumnIndex(Google.Protobuf.Collections.RepeatedField<int> columnPreferences, int columnIndex);
                    /*0x4111190*/ int Compare(YetiSimAi.Core.FilteredOption a, YetiSimAi.Core.FilteredOption b);
                    /*0x41111f0*/ int ColumnPreferenceIndexFor(YetiSimAi.Core.FilteredOption filteredOption);
                }
            }
        }

        interface IActionResolverFactory
        {
            YetiSimAi.Core.IActionResolver ForId(int actionResolverId, string shortName);
        }

        class GameDataActionResolverFactory : YetiSimAi.Core.IActionResolverFactory
        {
            /*0x10*/ YetiSimAi.Core.IActionProviderFactory _actionProviderFactory;
            /*0x18*/ Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiActionResolver> _actionResolverConfigs;
            /*0x20*/ YetiSimAi.Core.ICoreSimAiApi _coreSimAiApi;
            /*0x28*/ YetiSimAi.Core.IGameStateSnapshot _gameStateSnapshot;

            /*0x410a984*/ GameDataActionResolverFactory(Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiActionResolver> actionResolverConfigs, YetiSimAi.Core.IActionProviderFactory actionProviderFactory, YetiSimAi.Core.ICoreSimAiApi coreSimAiApi, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            /*0x4111288*/ YetiSimAi.Core.IActionResolver ForId(int actionResolverId, string shortName);
            /*0x4111618*/ YetiSimAi.Core.IActionResolver BuildActionResolver(PvzN3xt.Data.AiActionResolver config, string shortName);
        }

        class ColumnAcceptor : System.MulticastDelegate
        {
            /*0x410f658*/ ColumnAcceptor(object object, nint method);
            /*0x4111da8*/ void Invoke(int column);
        }

        class ColumnIterator
        {
            static /*0x4110bbc*/ YetiSimAi.Core.ColumnIterator.Direction DirectionFor(PvzN3xt.Data.AiIterationDirection dataDirection);
            static /*0x410f6f8*/ void Iterate(YetiSimAi.Core.ColumnIterator.Direction direction, int targetColumn, int minDistance, int maxDistance, YetiSimAi.Core.ColumnAcceptor columnAcceptor);
            static /*0x4111dbc*/ void LeftOf(int targetColumn, int minDistance, int maxDistance, YetiSimAi.Core.ColumnAcceptor columnAcceptor);
            static /*0x4111e70*/ void RightOf(int targetColumn, int minDistance, int maxDistance, YetiSimAi.Core.ColumnAcceptor columnAcceptor);

            enum Direction
            {
                Left = 0,
                Right = 1,
            }
        }

        interface IInstanceCondition
        {
            /*0x1f2fec8*/ bool Evaluate(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
        }

        class AlwaysTrueInstanceCondition : YetiSimAi.Core.IInstanceCondition
        {
            static /*0x4111f2c*/ YetiSimAi.Core.AlwaysTrueInstanceCondition get_Instance();
            /*0x4111f24*/ AlwaysTrueInstanceCondition();
            /*0x4111f80*/ bool Evaluate(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
        }

        class AllAreTrueInstanceCondition : YetiSimAi.Core.IInstanceCondition
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IInstanceCondition> _conditions;

            /*0x4111f88*/ AllAreTrueInstanceCondition(System.Collections.Generic.List<YetiSimAi.Core.IInstanceCondition> conditions);
            /*0x4111fb8*/ bool Evaluate(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
        }

        class AnyAreTrueInstanceCondition : YetiSimAi.Core.IInstanceCondition
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IInstanceCondition> _conditions;

            /*0x4112200*/ AnyAreTrueInstanceCondition(System.Collections.Generic.List<YetiSimAi.Core.IInstanceCondition> conditions);
            /*0x4112230*/ bool Evaluate(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
        }

        class NoneAreTrueInstanceCondition : YetiSimAi.Core.IInstanceCondition
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IInstanceCondition> _conditions;

            /*0x4112474*/ NoneAreTrueInstanceCondition(System.Collections.Generic.List<YetiSimAi.Core.IInstanceCondition> conditions);
            /*0x41124a4*/ bool Evaluate(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
        }

        class InstanceIntComparisonCondition : YetiSimAi.Core.IInstanceCondition
        {
            /*0x10*/ YetiSimAi.Core.InstanceIntComparisonCondition.Evaluator _evaluator;

            static /*0x411273c*/ YetiSimAi.Core.InstanceIntComparisonCondition From(YetiSimAi.Core.InstanceIntComparisonCondition.Provider instanceIntProvider, int value, PvzN3xt.Data.NumericComparisonType comparisonType);
            /*0x41126ec*/ InstanceIntComparisonCondition(YetiSimAi.Core.InstanceIntComparisonCondition.Evaluator evaluator);
            /*0x411271c*/ bool Evaluate(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);

            class Provider : System.MulticastDelegate
            {
                /*0x4112ac0*/ Provider(object object, nint method);
                /*0x4112bc8*/ int Invoke(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instanceTrackingData);
            }

            class Evaluator : System.MulticastDelegate
            {
                /*0x41129b8*/ Evaluator(object object, nint method);
                /*0x4112bdc*/ bool Invoke(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ YetiSimAi.Core.InstanceIntComparisonCondition.Provider instanceIntProvider;
                /*0x18*/ int value;

                /*0x41129b0*/ <>c__DisplayClass5_0();
                /*0x4112bf0*/ bool <From>b__0(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
                /*0x4112c28*/ bool <From>b__1(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
                /*0x4112c60*/ bool <From>b__2(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
                /*0x4112c98*/ bool <From>b__3(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
                /*0x4112cd0*/ bool <From>b__4(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
                /*0x4112d08*/ bool <From>b__5(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
            }
        }

        class InstanceConditionFactory
        {
            /*0x410a6b4*/ InstanceConditionFactory();
            /*0x4112d40*/ YetiSimAi.Core.IInstanceCondition For(PvzN3xt.Data.AiInstanceCondition config);
            /*0x41130ac*/ System.Collections.Generic.List<YetiSimAi.Core.IInstanceCondition> BuildConditionsList(Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiInstanceCondition> conditionsConfig);

            class <>c
            {
                static /*0x0*/ YetiSimAi.Core.InstanceConditionFactory.<> <>9;
                static /*0x8*/ YetiSimAi.Core.InstanceIntComparisonCondition.Provider <>9__0_0;

                static /*0x41132d8*/ <>c();
                /*0x4113340*/ <>c();
                /*0x4113348*/ int <For>b__0_0(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
            }

            class <>c__DisplayClass0_0
            {
                /*0x10*/ PvzN3xt.Data.AiInstanceCondition config;

                /*0x41130a4*/ <>c__DisplayClass0_0();
                /*0x411335c*/ int <For>b__1(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instance);
            }
        }

        class LaneConditionStatCalculationFactory
        {
            /*0x10*/ YetiSimAi.Core.RowConditionFactory _rowConditionFactory;

            /*0x4113394*/ LaneConditionStatCalculationFactory(YetiSimAi.Core.UnitIdsProviderFactory unitIdsProviderFactory, YetiSimAi.Core.InstanceConditionFactory instanceConditionFactory);
            /*0x4113414*/ YetiSimAi.Core.IPriorityCalculation CreateLaneConditionStatCalculation(PvzN3xt.Data.AiPriorityCalculationLaneCondition laneConditionCalculationConfig);
            /*0x411351c*/ YetiSimAi.Core.IPriorityCalculation PriorityCalculationFor(PvzN3xt.Data.AiPriorityCalculationLaneCondition laneConditionCalculationConfig, YetiSimAi.Core.IRowCondition condition);

            class AnyRowMeetsPriorityCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ YetiSimAi.Core.IRowCondition _condition;
                /*0x18*/ float _trueValue;
                /*0x1c*/ float _falseValue;

                /*0x4113794*/ AnyRowMeetsPriorityCalculation(YetiSimAi.Core.IRowCondition condition, float trueValue, float falseValue);
                /*0x4113954*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }

            class NoRowMeetsPriorityCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ YetiSimAi.Core.IRowCondition _condition;
                /*0x18*/ float _trueValue;
                /*0x1c*/ float _falseValue;

                /*0x41137dc*/ NoRowMeetsPriorityCalculation(YetiSimAi.Core.IRowCondition condition, float trueValue, float falseValue);
                /*0x4113a30*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }

            class AllRowsMeetPriorityCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ YetiSimAi.Core.IRowCondition _condition;
                /*0x18*/ float _trueValue;
                /*0x1c*/ float _falseValue;

                /*0x4113824*/ AllRowsMeetPriorityCalculation(YetiSimAi.Core.IRowCondition condition, float trueValue, float falseValue);
                /*0x4113b0c*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }

            class AtLeastRowsMeetPriorityCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ YetiSimAi.Core.IRowCondition _condition;
                /*0x18*/ int _minRows;
                /*0x1c*/ float _trueValue;
                /*0x20*/ float _falseValue;

                /*0x411386c*/ AtLeastRowsMeetPriorityCalculation(YetiSimAi.Core.IRowCondition condition, int minRows, float trueValue, float falseValue);
                /*0x4113be8*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }

            class AtMostRowsMeetPriorityCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ YetiSimAi.Core.IRowCondition _condition;
                /*0x18*/ int _maxRows;
                /*0x1c*/ float _trueValue;
                /*0x20*/ float _falseValue;

                /*0x41138bc*/ AtMostRowsMeetPriorityCalculation(YetiSimAi.Core.IRowCondition condition, int maxRows, float trueValue, float falseValue);
                /*0x4113ce0*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }

            class MultiplyByNumberOfRowsThatMeetCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ YetiSimAi.Core.IRowCondition _condition;
                /*0x18*/ float _trueValue;
                /*0x1c*/ float _falseValue;

                /*0x411390c*/ MultiplyByNumberOfRowsThatMeetCalculation(YetiSimAi.Core.IRowCondition condition, float trueValue, float falseValue);
                /*0x4113dd0*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }
        }

        class PriorityCalculatorFactory
        {
            /*0x10*/ Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiPriorityCalculator> _config;
            /*0x18*/ YetiSimAi.Core.IUnitGroupProvider _unitGroupProvider;
            /*0x20*/ YetiSimAi.Core.LaneConditionStatCalculationFactory _laneConditionStatCalculationFactory;

            /*0x410a9f8*/ PriorityCalculatorFactory(Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiPriorityCalculator> config, YetiSimAi.Core.IUnitGroupProvider unitGroupProvider);
            /*0x410b200*/ YetiSimAi.Core.IPriorityCalculator ForId(int priorityCalculatorId, string shortName);
            /*0x4113ec8*/ YetiSimAi.Core.IPriorityCalculator Create(PvzN3xt.Data.AiPriorityCalculator config, string shortName);
            /*0x4114098*/ YetiSimAi.Core.IPriorityCalculation CreateCalculation(PvzN3xt.Data.AiPriorityCalculation aiPriorityCalculation);
            /*0x4114754*/ YetiSimAi.Core.PriorityCalculatorFactory.MinOfCalculation CreateMinOf(PvzN3xt.Data.AiPriorityCalculationMinOf minOfConfig);
            /*0x4114b04*/ YetiSimAi.Core.PriorityCalculatorFactory.MaxOfCalculation CreateMaxOf(PvzN3xt.Data.AiPriorityCalculationMaxOf maxOfConfig);
            /*0x4114eb4*/ YetiSimAi.Core.PriorityCalculatorFactory.SumOfCalculation CreateSumOf(PvzN3xt.Data.AiPriorityCalculationSumOf sumOfConfig);

            class MinOfCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IPriorityCalculation> _calculations;

                /*0x4115264*/ MinOfCalculation(System.Collections.Generic.List<YetiSimAi.Core.IPriorityCalculation> calculations);
                /*0x41152f4*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }

            class MaxOfCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IPriorityCalculation> _calculations;

                /*0x4115294*/ MaxOfCalculation(System.Collections.Generic.List<YetiSimAi.Core.IPriorityCalculation> calculations);
                /*0x4115474*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }

            class SumOfCalculation : YetiSimAi.Core.IPriorityCalculation
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IPriorityCalculation> _calculations;

                /*0x41152c4*/ SumOfCalculation(System.Collections.Generic.List<YetiSimAi.Core.IPriorityCalculation> calculations);
                /*0x41155fc*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            }
        }

        class RowConditionFactory
        {
            /*0x10*/ YetiSimAi.Core.UnitIdsProviderFactory _unitIdsProviderFactory;
            /*0x18*/ YetiSimAi.Core.InstanceConditionFactory _instanceConditionFactory;

            static /*0x4116eb4*/ YetiSimAi.Core.RowConditionFactory.OpForInput OpFor(PvzN3xt.Data.AiLaneStatComparisonTargetCalculationOperation.Types.OpType configOpOperationType);
            static /*0x4117058*/ int MinusOp(int left, int right);
            static /*0x4117060*/ int PlusOp(int left, int right);
            /*0x410a6bc*/ RowConditionFactory(YetiSimAi.Core.UnitIdsProviderFactory unitIdsProviderFactory, YetiSimAi.Core.InstanceConditionFactory instanceConditionFactory);
            /*0x410c804*/ YetiSimAi.Core.IRowCondition For(Google.Protobuf.Collections.RepeatedField<PvzN3xt.Data.AiLaneStateCondition> conditionConfigs, PvzN3xt.Data.AiConditionsType conditionType);
            /*0x4115744*/ YetiSimAi.Core.IRowCondition CreateCondition(PvzN3xt.Data.AiLaneStateCondition conditionConfig);
            /*0x4115b28*/ YetiSimAi.Core.IRowCondition CreateComparisonCondition(PvzN3xt.Data.AiLaneStatComparison conditionConfig);
            /*0x4116114*/ YetiSimAi.Core.RowConditionFactory.ValueProvider CreateValueProvider(PvzN3xt.Data.AiLaneStatComparisonTarget valueProviderConfig);
            /*0x41165bc*/ YetiSimAi.Core.RowConditionFactory.ValueProvider CreateLaneStat(PvzN3xt.Data.AiLaneStatComparisonTargetSimple simpleStat);
            /*0x41167b0*/ YetiSimAi.Core.RowConditionFactory.ValueProvider CreateCountOfPlantsOfTypeInRow(PvzN3xt.Data.AiLaneStatComparisonTargetCountOfPlantsOfTypeInRow countOfPlantsOfTypeInRow);
            /*0x4116880*/ YetiSimAi.Core.RowConditionFactory.ValueProvider CreateCountOfPlantsOfTypeOnBoard(PvzN3xt.Data.AiLaneStatComparisonTargetCountOfPlantsOfTypeOnBoard countOfPlantsOfTypeOnBoard);
            /*0x4116da4*/ YetiSimAi.Core.RowConditionFactory.ValueProvider CreateCountOfZombiesInRow(PvzN3xt.Data.AiLaneStatComparisonTargetCountOfZombiesInRow config);
            /*0x4116950*/ YetiSimAi.Core.RowConditionFactory.ValueProvider CreateCalculation(PvzN3xt.Data.AiLaneStatComparisonTargetCalculation config);
            /*0x4115dc8*/ YetiSimAi.Core.IRowCondition CreateInstantUsePlantIsAvailableCondition(PvzN3xt.Data.AiInstantUsePlantIsAvailable config);
            /*0x4115e54*/ YetiSimAi.Core.IRowCondition CreateInstantDefensePlantIsAvailableCondition(PvzN3xt.Data.AiInstantDefensePlantIsAvailable config);
            /*0x4115ee0*/ YetiSimAi.Core.IRowCondition CreateLoadoutPlantIsAvailableNowCondition(PvzN3xt.Data.AiLoadoutPlantIsAvailableNow config);
            /*0x4115f6c*/ YetiSimAi.Core.IRowCondition CreatePlantIsInLoadoutCondition(PvzN3xt.Data.AiPlantIsInLoadoutCondition config);
            /*0x4115ff8*/ YetiSimAi.Core.IRowCondition CreatePlantIsAvailableAndHasNotBeenPlayedRecently(PvzN3xt.Data.AiPlantIsAvailableAndHasNotBeenPlayedRecently config);
            /*0x411608c*/ YetiSimAi.Core.IRowCondition CreateNotCondition(PvzN3xt.Data.AiLaneStateConditionNot config);

            class EqualsCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _left;
                /*0x18*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _right;

                /*0x411637c*/ EqualsCondition(YetiSimAi.Core.RowConditionFactory.ValueProvider left, YetiSimAi.Core.RowConditionFactory.ValueProvider right);
                /*0x4117194*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class DoesNotEqualCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _left;
                /*0x18*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _right;

                /*0x41163c0*/ DoesNotEqualCondition(YetiSimAi.Core.RowConditionFactory.ValueProvider left, YetiSimAi.Core.RowConditionFactory.ValueProvider right);
                /*0x41171fc*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class GreaterThanCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _left;
                /*0x18*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _right;

                /*0x4116404*/ GreaterThanCondition(YetiSimAi.Core.RowConditionFactory.ValueProvider left, YetiSimAi.Core.RowConditionFactory.ValueProvider right);
                /*0x4117264*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class GreaterThanOrEqualCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _left;
                /*0x18*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _right;

                /*0x4116448*/ GreaterThanOrEqualCondition(YetiSimAi.Core.RowConditionFactory.ValueProvider left, YetiSimAi.Core.RowConditionFactory.ValueProvider right);
                /*0x41172cc*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class LessThanCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _left;
                /*0x18*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _right;

                /*0x411648c*/ LessThanCondition(YetiSimAi.Core.RowConditionFactory.ValueProvider left, YetiSimAi.Core.RowConditionFactory.ValueProvider right);
                /*0x4117334*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class LessThanOrEqualCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _left;
                /*0x18*/ YetiSimAi.Core.RowConditionFactory.ValueProvider _right;

                /*0x41164d0*/ LessThanOrEqualCondition(YetiSimAi.Core.RowConditionFactory.ValueProvider left, YetiSimAi.Core.RowConditionFactory.ValueProvider right);
                /*0x411739c*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class ValueProvider : System.MulticastDelegate
            {
                /*0x411651c*/ ValueProvider(object object, nint method);
                /*0x4117404*/ int Invoke(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class OpForInput : System.MulticastDelegate
            {
                /*0x4116fb8*/ OpForInput(object object, nint method);
                /*0x4117418*/ int Invoke(int left, int right);
            }

            class CalculationInput
            {
                /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider ValueProvider;
                /*0x18*/ YetiSimAi.Core.RowConditionFactory.OpForInput Op;

                /*0x4116eac*/ CalculationInput();
            }

            class InstantPlantIsAvailableCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider _unitIdsProvider;

                /*0x4117068*/ InstantPlantIsAvailableCondition(YetiSimAi.Core.IUnitIdsProvider unitIdsProvider);
                /*0x411742c*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class InstantDefenseIsAvailableCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider _unitIdsProvider;

                /*0x4117098*/ InstantDefenseIsAvailableCondition(YetiSimAi.Core.IUnitIdsProvider unitIdsProvider);
                /*0x41177dc*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class LoadoutPlantIsAvailableNowCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider _unitIdsProvider;

                /*0x41170c8*/ LoadoutPlantIsAvailableNowCondition(YetiSimAi.Core.IUnitIdsProvider unitIdsProvider);
                /*0x4117b8c*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class PlantIsInLoadoutCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider _unitIdsProvider;

                /*0x41170f8*/ PlantIsInLoadoutCondition(YetiSimAi.Core.IUnitIdsProvider unitIdsProvider);
                /*0x4117f3c*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class PlantIsAvailableAndHasNotBeenPlayedRecentlyCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider _unitIdsProvider;
                /*0x18*/ int _minimumMillisecondsSinceLastPlayed;

                /*0x4117128*/ PlantIsAvailableAndHasNotBeenPlayedRecentlyCondition(YetiSimAi.Core.IUnitIdsProvider unitIdsProvider, int minimumMillisecondsSinceLastPlayed);
                /*0x41182ec*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class NotRowCondition : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ YetiSimAi.Core.IRowCondition _condition;

                /*0x4117164*/ NotRowCondition(YetiSimAi.Core.IRowCondition condition);
                /*0x4118954*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class AnyOfConditionsEvaluator : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IRowCondition> _conditions;

                /*0x4115a60*/ AnyOfConditionsEvaluator(System.Collections.Generic.List<YetiSimAi.Core.IRowCondition> conditions);
                /*0x4118a18*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class AllOfConditionsEvaluator : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IRowCondition> _conditions;

                /*0x41159fc*/ AllOfConditionsEvaluator(System.Collections.Generic.List<YetiSimAi.Core.IRowCondition> conditions);
                /*0x4118c6c*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class NoneOfConditionsEvaluator : YetiSimAi.Core.IRowCondition
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IRowCondition> _conditions;

                /*0x4115ac4*/ NoneOfConditionsEvaluator(System.Collections.Generic.List<YetiSimAi.Core.IRowCondition> conditions);
                /*0x4118ec4*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c
            {
                static /*0x0*/ YetiSimAi.Core.RowConditionFactory.<> <>9;
                static /*0x8*/ YetiSimAi.Core.RowConditionFactory.ValueProvider <>9__14_0;
                static /*0x10*/ YetiSimAi.Core.RowConditionFactory.ValueProvider <>9__14_1;

                static /*0x411911c*/ <>c();
                /*0x4119184*/ <>c();
                /*0x411918c*/ int <CreateLaneStat>b__14_0(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
                /*0x41192a8*/ int <CreateLaneStat>b__14_1(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ PvzN3xt.Data.AiLaneStatComparisonTarget valueProviderConfig;

                /*0x4116514*/ <>c__DisplayClass13_0();
                /*0x4119414*/ int <CreateValueProvider>b__0(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider unitsProvider;

                /*0x4116e8c*/ <>c__DisplayClass15_0();
                /*0x411943c*/ int <CreateCountOfPlantsOfTypeInRow>b__0(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ YetiSimAi.Core.IUnitIdsProvider unitsProvider;

                /*0x4116e94*/ <>c__DisplayClass16_0();
                /*0x4119574*/ int <CreateCountOfPlantsOfTypeOnBoard>b__0(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ PvzN3xt.Data.AiLaneStatComparisonTargetCountOfZombiesInRow config;
                /*0x18*/ YetiSimAi.Core.IInstanceCondition conditions;

                /*0x4116e9c*/ <>c__DisplayClass17_0();
                /*0x41196d0*/ int <CreateCountOfZombiesInRow>b__0(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.RowConditionFactory.CalculationInput> operations;

                /*0x4116ea4*/ <>c__DisplayClass18_0();
                /*0x4119b3c*/ int <CreateCalculation>b__0(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }
        }

        class RowStateColumnComparisonFactory
        {
            /*0x10*/ YetiSimAi.Core.UnitIdsProviderFactory _unitIdsProviderFactory;

            /*0x410fd4c*/ RowStateColumnComparisonFactory(YetiSimAi.Core.UnitIdsProviderFactory unitIdsProviderFactory);
            /*0x411097c*/ YetiSimAi.Core.IRowStateColumnComparison For(PvzN3xt.Data.AIRowValue rowValueConfig);
            /*0x4119d64*/ YetiSimAi.Core.IRowStateColumnComparison BuildLeftMostCellContainingPlantColumnComparison(PvzN3xt.Data.AiRowStateComparisonTypeLeftMostCellContainingPlant leftMostCellContainingPlant);
            /*0x4119df8*/ YetiSimAi.Core.IRowStateColumnComparison BuildRightMostCellContainingPlantColumnComparison(PvzN3xt.Data.AiRowStateComparisonTypeRightMostCellContainingPlant rightMostCellContainingPlant);
            /*0x4119e8c*/ YetiSimAi.Core.IRowStateColumnComparison BuildMinOf(PvzN3xt.Data.AiRowStateComparisonTypeMinOf minOf);
            /*0x411a230*/ YetiSimAi.Core.IRowStateColumnComparison BuildMaxOf(PvzN3xt.Data.AiRowStateComparisonTypeMaxOf maxOf);
        }

        class SupportsLoadoutStrategyFactory
        {
            static /*0x41142f0*/ YetiSimAi.Core.SupportsLoadoutStrategy CreateSupportsLoadoutStrategy(PvzN3xt.Data.AiPriorityCalculator priorityCalculatorConfig, YetiSimAi.Core.IUnitGroupProvider unitGroupProvider);

            class <>c
            {
                static /*0x0*/ YetiSimAi.Core.SupportsLoadoutStrategyFactory.<> <>9;
                static /*0x8*/ YetiSimAi.Core.SupportsLoadoutStrategy <>9__0_0;

                static /*0x411a5ec*/ <>c();
                /*0x411a654*/ <>c();
                /*0x411a65c*/ bool <CreateSupportsLoadoutStrategy>b__0_0(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass0_0
            {
                /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.SupportsLoadoutStrategy> strategies;

                /*0x411a5d4*/ <>c__DisplayClass0_0();
                /*0x411a664*/ bool <CreateSupportsLoadoutStrategy>b__1(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass0_1
            {
                /*0x10*/ YetiSimAi.Core.UnitGroup unitGroup;

                /*0x411a5dc*/ <>c__DisplayClass0_1();
                /*0x411a83c*/ bool <CreateSupportsLoadoutStrategy>b__2(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }

            class <>c__DisplayClass0_2
            {
                /*0x10*/ YetiSimAi.Core.UnitGroup unitGroup;

                /*0x411a5e4*/ <>c__DisplayClass0_2();
                /*0x411ab80*/ bool <CreateSupportsLoadoutStrategy>b__3(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            }
        }

        class UnitIdsProviderFactory
        {
            /*0x10*/ YetiSimAi.Core.IUnitGroupProvider _unitGroupProvider;

            /*0x410a684*/ UnitIdsProviderFactory(YetiSimAi.Core.IUnitGroupProvider unitGroupProvider);
            /*0x410c434*/ YetiSimAi.Core.IUnitIdsProvider For(PvzN3xt.Data.AiUnitSelectorType plantsToConsider);
        }

        class Gestalt : YetiSimAi.Core.IAi
        {
            static /*0x0*/ YetiSimAi.Core.PriorityActionResolver NoOpPriorityActionResolver;
            /*0x10*/ float _minSecondsBetweenActions;
            /*0x14*/ int _minMsBeforeCollectingSun;
            /*0x18*/ int _minMsBeforeCollectingSunFromSky;
            /*0x1c*/ int _minMsBeforeCollectingToken;
            /*0x20*/ YetiSimAi.Core.ICoreSimAiApi _coreSimApi;
            /*0x28*/ YetiSimAi.Core.SimulationStateTracker _simulationStateTracker;
            /*0x30*/ YetiSimAi.Core.IGameStateSnapshot _gameStateSnapshot;
            /*0x38*/ System.Collections.Generic.List<int> _sunToCollect;
            /*0x40*/ System.Collections.Generic.List<int> _cascadeTokensToCollect;
            /*0x48*/ System.Collections.Generic.List<YetiSimAi.Core.PriorityActionResolver> _actionResolvers;
            /*0x50*/ float _elapsedTimeSinceLastAiUpdate;

            static /*0x411c3f0*/ Gestalt();
            /*0x410b34c*/ Gestalt(YetiSimAi.Core.ICoreSimAiApi coreSimApi, YetiSimAi.Core.SimulationStateTracker simulationStateTrackerTracker, YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot gameStateSnapshot, System.Collections.Generic.List<YetiSimAi.Core.PriorityActionResolver> actionResolvers, float minSecondsBetweenActions, int minMsBeforeCollectingSun, int minMsBeforeCollectingSunFromSky, int minMsBeforeCollectingToken);
            /*0x411aec4*/ void Update(float deltaTime);
            /*0x411af20*/ void Update();
            /*0x411c3e8*/ void ResetThinkTime();
            /*0x411af0c*/ bool PastThinkTime();
            /*0x411bf54*/ void ResolveAndAct();
            /*0x411b080*/ bool CollectSun();
            /*0x411b880*/ bool CollectDroppedTokens();
        }

        class HardCodedAiConfig
        {
            static /*0x0*/ PvzN3xt.Data.AiConfig AiConfig;

            static /*0x4124bcc*/ HardCodedAiConfig();
            static /*0x411c4f4*/ PvzN3xt.Data.AiConfig BuildConfig();
            static /*0x4121608*/ PvzN3xt.Data.AiPriorityCalculation CreateDefendPriorityCalculation();
            static /*0x41225c0*/ PvzN3xt.Data.AiPriorityCalculation CreateAttackPriorityCalculation();
            static /*0x4123108*/ PvzN3xt.Data.AiPriorityCalculation CreateSowSunPriorityCalculation();
            static /*0x41239cc*/ PvzN3xt.Data.AiPriorityCalculation CreatePreparePlantPriorityCalculation();
            static /*0x4123c1c*/ PvzN3xt.Data.AiPriorityCalculation CreateShovelPlantCalculation();
            static /*0x4124280*/ PvzN3xt.Data.AiPriorityCalculation CreateInstantUsePlantCalculation();
        }

        interface IActionProvider
        {
            /*0x1f2fec8*/ bool SupportsLoadOut(YetiSimAi.Core.IGameStateSnapshot snapshot);
            System.Nullable<YetiSimAi.Core.AiAction> GetAction();
        }

        enum ActionType
        {
            PlacePlant = 0,
            PlaceInstantUsePlant = 1,
            ShovelPlant = 2,
        }

        struct AiAction
        {
            /*0x10*/ YetiSimAi.Core.ActionType ActionType;
            /*0x14*/ YetiSimCoreLib.Game.GridCell GridCell;
            /*0x1c*/ int UnitId;
            /*0x20*/ int InstanceId;
            /*0x24*/ bool IsPreparingPlacement;
            /*0x28*/ string ProviderDescription;

            /*0x4124c24*/ bool Equals(YetiSimAi.Core.AiAction other);
            /*0x4124cdc*/ bool Equals(object obj);
            /*0x4124d64*/ int GetHashCode();
        }

        interface IActionResolver
        {
            /*0x1f309e4*/ void Resolve();
        }

        class ComposedActionResolver : YetiSimAi.Core.IActionResolver
        {
            /*0x10*/ string _shortName;
            /*0x18*/ YetiSimAi.Core.ICoreSimAiApi _coreSimAiApi;
            /*0x20*/ YetiSimAi.Core.IGameStateSnapshot _gameStateSnapshot;
            /*0x28*/ System.Collections.Generic.List<YetiSimAi.Core.IActionProvider> _configuredProviders;
            /*0x30*/ System.Collections.Generic.List<YetiSimAi.Core.IActionProvider> _enabledProviders;

            /*0x4111cb8*/ ComposedActionResolver(string shortName, YetiSimAi.Core.ICoreSimAiApi coreSimAiApi, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot, System.Collections.Generic.List<YetiSimAi.Core.IActionProvider> configuredProviders);
            /*0x4124e24*/ void UpdateEnabledProviders();
            /*0x4125114*/ void Resolve();
            /*0x4125398*/ bool TryAction(System.Nullable<YetiSimAi.Core.AiAction> possibleAction);
            /*0x4125560*/ bool TryPlacePlant(YetiSimAi.Core.AiAction action);
            /*0x41256b4*/ void PlayInstantUsePlant(YetiSimAi.Core.AiAction action);
            /*0x412576c*/ void ShovelPlant(YetiSimAi.Core.AiAction action);
        }

        interface IAi
        {
            void Update(float deltaTime);
            /*0x1f309e4*/ void ResetThinkTime();
        }

        interface ICoreAiSimInputCreator
        {
        }

        class RowState
        {
            /*0x10*/ System.Collections.Generic.Dictionary<YetiSimAi.Core.IUnitIdsProvider, System.Collections.Generic.List<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData>> _unitIdsProviderToInstances;
            /*0x18*/ int <RowIndex>k__BackingField;
            /*0x1c*/ System.Nullable<int> <ClosestCellWithZombie>k__BackingField;
            /*0x28*/ int[] <ZombieCountsByCell>k__BackingField;
            /*0x30*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> <PlantsInLane>k__BackingField;
            /*0x38*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> <ZombiesInLane>k__BackingField;

            /*0x4125d84*/ RowState();
            /*0x4125858*/ int get_RowIndex();
            /*0x4125860*/ void set_RowIndex(int value);
            /*0x4125868*/ System.Nullable<int> get_ClosestCellWithZombie();
            /*0x4125870*/ void set_ClosestCellWithZombie(System.Nullable<int> value);
            /*0x4125878*/ int get_ZombieCountForRow();
            /*0x4125918*/ int[] get_ZombieCountsByCell();
            /*0x4125920*/ void set_ZombieCountsByCell(int[] value);
            /*0x4125928*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> get_PlantsInLane();
            /*0x4125930*/ void set_PlantsInLane(System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> value);
            /*0x4125938*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> get_ZombiesInLane();
            /*0x4125940*/ void set_ZombiesInLane(System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> value);
            /*0x4125948*/ int CountOfPlantsInGroupInRow(YetiSimAi.Core.IUnitIdsProvider unitIdsProvider);
            /*0x41259f8*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> PlantsInRowForUnits(YetiSimAi.Core.IUnitIdsProvider unitIdsProvider);
            /*0x4125d10*/ void Reset();
        }

        interface IGameStateSnapshot
        {
            /*0x1f309e4*/ void Refresh();
            /*0x1f2ffc8*/ int get_CurrentSimulationTimeInMs();
            /*0x1f30214*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.RowState> get_RowStates();
            System.Nullable<int> GetLastPlantSpawnTimeInMs(int unitId);
            /*0x1f30240*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> ZombiesInRow(int row);
            /*0x1f2fe40*/ bool IsAvailableToPlant(int unitId);
            /*0x1f2fe40*/ bool IsInstantUsePlantAvailable(int unitId);
            /*0x1f2fe40*/ bool IsInstantDefensePlantAvailable(int unitId);
            /*0x1f2fe40*/ bool IsPlantInLoadOut(int unitId);
            System.Nullable<int> GetPlantableLoadoutIndexForUnit(int unitId);
            /*0x1f2fe80*/ bool TryGetPlantableLoadoutIndexForUnit(int unitId, ref int index);
        }

        class SimulationStateTrackerGameStateSnapshot : YetiSimAi.Core.IGameStateSnapshot
        {
            /*0x10*/ YetiSimAi.Core.SimulationStateTracker _simulationStateTracker;
            /*0x18*/ Yeti.Data.GameInitState _gameInitState;
            /*0x20*/ YetiSimCoreLib.Game.UnitDatabase _unitDatabase;
            /*0x28*/ System.Collections.Generic.Dictionary<int, Yeti.Data.UnitDefinition> _allPlantsInLoadOut;
            /*0x30*/ System.Collections.Generic.HashSet<int> _allCellPreparingUnitIdsInLoadOut;
            /*0x38*/ System.Collections.Generic.List<YetiSimAi.Core.RowState> _rowStates;
            /*0x40*/ YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot.PlantInstances _plantsOnBoard;
            /*0x48*/ YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot.ZombieInstances _zombiesOnBoard;
            /*0x50*/ int <CurrentSunAvailable>k__BackingField;
            /*0x54*/ int <CurrentSimulationTimeInMs>k__BackingField;

            /*0x4125e0c*/ SimulationStateTrackerGameStateSnapshot(YetiSimAi.Core.SimulationStateTracker simulationStateTracker, Yeti.Data.GameInitState gameInitState, YetiSimCoreLib.Game.UnitDatabase unitDatabase);
            /*0x4126a4c*/ void Refresh();
            /*0x4127700*/ int get_CurrentSunAvailable();
            /*0x4127708*/ void set_CurrentSunAvailable(int value);
            /*0x4127710*/ int get_CurrentSimulationTimeInMs();
            /*0x4127718*/ void set_CurrentSimulationTimeInMs(int value);
            /*0x41269a4*/ void InitializeRowStates();
            /*0x412758c*/ void UpdateRowStates();
            /*0x4127a88*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.RowState> get_RowStates();
            /*0x4127a90*/ System.Nullable<int> GetLastPlantSpawnTimeInMs(int unitId);
            /*0x4127bc0*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> ZombiesInRow(int row);
            /*0x4127bd4*/ bool IsAvailableToPlant(int unitId);
            /*0x4127dd8*/ bool IsInstantUsePlantAvailable(int unitId);
            /*0x4127eb0*/ bool IsInstantDefensePlantAvailable(int unitId);
            /*0x4127f88*/ bool IsPlantInLoadOut(int unitId);
            /*0x4127ff4*/ System.Nullable<int> GetPlantableLoadoutIndexForUnit(int unitId);
            /*0x41281b0*/ bool TryGetPlantableLoadoutIndexForUnit(int unitId, ref int index);
            /*0x4126614*/ void CapturePlantLoadOut();
            /*0x41282b0*/ System.Collections.Generic.IEnumerable<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> <.ctor>b__8_0();
            /*0x412835c*/ System.Collections.Generic.IEnumerable<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> <.ctor>b__8_1();

            class PlantInstances
            {
                /*0x10*/ YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot.PlantInstances.InstancesProvider _instancesProvider;
                /*0x18*/ System.Collections.Generic.List<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> _allInstances;
                /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData>> _instancesByRow;
                /*0x28*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData>> _defendingPlantInstancesByRow;

                /*0x412611c*/ PlantInstances(YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot.PlantInstances.InstancesProvider instancesProvider);
                /*0x4126aa4*/ void Refresh();
                /*0x41279cc*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> InstancesInRow(int row);

                class InstancesProvider : System.MulticastDelegate
                {
                    /*0x4126080*/ InstancesProvider(object object, nint method);
                    /*0x4128408*/ System.Collections.Generic.IEnumerable<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> Invoke();
                }
            }

            class ZombieInstances
            {
                /*0x10*/ YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot.ZombieInstances.InstancesProvider _instancesProvider;
                /*0x18*/ System.Collections.Generic.List<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> _allInstances;
                /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData>> _instancesByRow;
                /*0x28*/ System.Collections.Generic.Dictionary<int, YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> _closestInstanceToHousePerRow;

                static /*0x412841c*/ bool ZombieIsFarEnoughIntoTheBoard(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData instanceTrackingData);
                /*0x41263f4*/ ZombieInstances(YetiSimAi.Core.SimulationStateTrackerGameStateSnapshot.ZombieInstances.InstancesProvider instancesProvider);
                /*0x4126fc0*/ void Refresh();
                /*0x4127910*/ System.Collections.Generic.IReadOnlyList<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> InstancesInRow(int row);
                /*0x4127720*/ System.Nullable<int> ClosestCellWithZombieInRow(int row);
                /*0x41277dc*/ int[] ZombieCountsByCellForRow(int row);

                class InstancesProvider : System.MulticastDelegate
                {
                    /*0x4126358*/ InstancesProvider(object object, nint method);
                    /*0x4128464*/ System.Collections.Generic.IEnumerable<YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> Invoke();
                }
            }
        }

        interface IGridCellCondition
        {
            bool Evaluate(YetiSimCoreLib.Game.GridCell gridCell, YetiSimAi.Core.IGameStateSnapshot snapshot);
        }

        class AlwaysTrueGridCellCondition : YetiSimAi.Core.IGridCellCondition
        {
            static /*0x0*/ YetiSimAi.Core.AlwaysTrueGridCellCondition Instance;

            static /*0x4128488*/ AlwaysTrueGridCellCondition();
            /*0x4128480*/ AlwaysTrueGridCellCondition();
            /*0x4128478*/ bool Evaluate(YetiSimCoreLib.Game.GridCell gridCell, YetiSimAi.Core.IGameStateSnapshot snapshot);
        }

        class AllOfGridCellCondition : YetiSimAi.Core.IGridCellCondition
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IGridCellCondition> _conditions;

            /*0x41284f0*/ AllOfGridCellCondition(System.Collections.Generic.List<YetiSimAi.Core.IGridCellCondition> conditions);
            /*0x4128520*/ bool Evaluate(YetiSimCoreLib.Game.GridCell gridCell, YetiSimAi.Core.IGameStateSnapshot snapshot);
        }

        class AnyOfGridCellCondition : YetiSimAi.Core.IGridCellCondition
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IGridCellCondition> _conditions;

            /*0x4128778*/ AnyOfGridCellCondition(System.Collections.Generic.List<YetiSimAi.Core.IGridCellCondition> conditions);
            /*0x41287a8*/ bool Evaluate(YetiSimCoreLib.Game.GridCell gridCell, YetiSimAi.Core.IGameStateSnapshot snapshot);
        }

        class NoneOfGridCellCondition : YetiSimAi.Core.IGridCellCondition
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IGridCellCondition> _conditions;

            /*0x4128a00*/ NoneOfGridCellCondition(System.Collections.Generic.List<YetiSimAi.Core.IGridCellCondition> conditions);
            /*0x4128a30*/ bool Evaluate(YetiSimCoreLib.Game.GridCell gridCell, YetiSimAi.Core.IGameStateSnapshot snapshot);
        }

        interface IPriorityCalculator
        {
            float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            /*0x1f2fec8*/ bool SupportsLoadout(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
        }

        interface IRowCondition
        {
            /*0x1f2fe80*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
        }

        class AlwaysTrueRowCondition : YetiSimAi.Core.IRowCondition
        {
            static /*0x0*/ YetiSimAi.Core.AlwaysTrueRowCondition Instance;

            static /*0x4128c98*/ AlwaysTrueRowCondition();
            /*0x4128c90*/ AlwaysTrueRowCondition();
            /*0x4128c88*/ bool Evaluate(int rowIndex, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
        }

        interface IRowStateColumnComparison
        {
            System.Nullable<int> GetColumn(YetiSimAi.Core.RowState rowState);
        }

        class RowStateColumnComparisons
        {
            static /*0x0*/ YetiSimAi.Core.IRowStateColumnComparison ClosestZombieToHouse;

            static /*0x4128d00*/ RowStateColumnComparisons();
        }

        class ClosestZombieToHouseRowStateColumnComparison : YetiSimAi.Core.IRowStateColumnComparison
        {
            /*0x4128d7c*/ ClosestZombieToHouseRowStateColumnComparison();
            /*0x4128d84*/ System.Nullable<int> GetColumn(YetiSimAi.Core.RowState rowState);
        }

        class LeftMostCellContainingPlantRowStateColumnComparison : YetiSimAi.Core.IRowStateColumnComparison
        {
            /*0x10*/ YetiSimAi.Core.IUnitIdsProvider _relevantUnits;
            /*0x18*/ int _minColumn;
            /*0x1c*/ int _maxColumn;

            /*0x4128d98*/ LeftMostCellContainingPlantRowStateColumnComparison(YetiSimAi.Core.IUnitIdsProvider relevantUnits, int minColumn, int maxColumn);
            /*0x4128e48*/ System.Nullable<int> GetColumn(YetiSimAi.Core.RowState rowState);
        }

        class RightMostCellContainingPlantRowStateColumnComparison : YetiSimAi.Core.IRowStateColumnComparison
        {
            /*0x10*/ YetiSimAi.Core.IUnitIdsProvider _relevantUnits;
            /*0x18*/ int _minColumn;
            /*0x1c*/ int _maxColumn;

            /*0x41291f0*/ RightMostCellContainingPlantRowStateColumnComparison(YetiSimAi.Core.IUnitIdsProvider relevantUnits, int minColumn, int maxColumn);
            /*0x41292a0*/ System.Nullable<int> GetColumn(YetiSimAi.Core.RowState rowState);
        }

        class ConstantRowStateColumnComparison : YetiSimAi.Core.IRowStateColumnComparison
        {
            /*0x10*/ int _value;

            /*0x4129648*/ ConstantRowStateColumnComparison(int value);
            /*0x4129670*/ System.Nullable<int> GetColumn(YetiSimAi.Core.RowState rowState);
        }

        class MinOfRowStateColumnComparison : YetiSimAi.Core.IRowStateColumnComparison
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IRowStateColumnComparison> _comparisons;

            /*0x41296d8*/ MinOfRowStateColumnComparison(System.Collections.Generic.List<YetiSimAi.Core.IRowStateColumnComparison> comparisons);
            /*0x4129708*/ System.Nullable<int> GetColumn(YetiSimAi.Core.RowState rowState);
        }

        class MaxOfRowStateColumnComparison : YetiSimAi.Core.IRowStateColumnComparison
        {
            /*0x10*/ System.Collections.Generic.List<YetiSimAi.Core.IRowStateColumnComparison> _comparisons;

            /*0x4129a28*/ MaxOfRowStateColumnComparison(System.Collections.Generic.List<YetiSimAi.Core.IRowStateColumnComparison> comparisons);
            /*0x4129a58*/ System.Nullable<int> GetColumn(YetiSimAi.Core.RowState rowState);
        }

        interface ISimulationMessaging
        {
            /*0x1f30ebc*/ void add_CurrentTickChanged(YetiSimCoreLib.Messaging.CurrentTickChangedEventHandler value);
            /*0x1f30ebc*/ void remove_CurrentTickChanged(YetiSimCoreLib.Messaging.CurrentTickChangedEventHandler value);
            /*0x1f30ebc*/ void add_UnitSpawned(YetiSimCoreLib.Messaging.UnitSpawnedEventHandler value);
            /*0x1f30ebc*/ void remove_UnitSpawned(YetiSimCoreLib.Messaging.UnitSpawnedEventHandler value);
            /*0x1f30ebc*/ void add_SimObjectDied(YetiSimCoreLib.Messaging.SimObjectDiedEventHandler value);
            /*0x1f30ebc*/ void remove_SimObjectDied(YetiSimCoreLib.Messaging.SimObjectDiedEventHandler value);
            /*0x1f30ebc*/ void add_SimObjectMoved(YetiSimCoreLib.Messaging.SimObjectMovedEventHandler value);
            /*0x1f30ebc*/ void remove_SimObjectMoved(YetiSimCoreLib.Messaging.SimObjectMovedEventHandler value);
            /*0x1f30ebc*/ void add_PlantReclaimed(YetiSimCoreLib.Messaging.PlantReclaimedEventHandler value);
            /*0x1f30ebc*/ void remove_PlantReclaimed(YetiSimCoreLib.Messaging.PlantReclaimedEventHandler value);
            /*0x1f30ebc*/ void add_SunValueChanged(YetiSimCoreLib.Messaging.SunValueChangedEventHandler value);
            /*0x1f30ebc*/ void remove_SunValueChanged(YetiSimCoreLib.Messaging.SunValueChangedEventHandler value);
            /*0x1f30ebc*/ void add_SunSpawned(YetiSimCoreLib.Messaging.SunSpawnedEventHandler value);
            /*0x1f30ebc*/ void remove_SunSpawned(YetiSimCoreLib.Messaging.SunSpawnedEventHandler value);
            /*0x1f30ebc*/ void add_DynamicDropSpawned(YetiSimCoreLib.Messaging.DynamicDropSpawnedEventHandler value);
            /*0x1f30ebc*/ void remove_DynamicDropSpawned(YetiSimCoreLib.Messaging.DynamicDropSpawnedEventHandler value);
            /*0x1f30ebc*/ void add_PointOfLoss(YetiSimCoreLib.Messaging.PointOfLossEventHandler value);
            /*0x1f30ebc*/ void remove_PointOfLoss(YetiSimCoreLib.Messaging.PointOfLossEventHandler value);
            /*0x1f30ebc*/ void add_LossAversionResponse(YetiSimCoreLib.Messaging.LossAversionResponseEventHandler value);
            /*0x1f30ebc*/ void remove_LossAversionResponse(YetiSimCoreLib.Messaging.LossAversionResponseEventHandler value);
            /*0x1f30ebc*/ void add_LoadoutItemInitialized(YetiSimCoreLib.Messaging.LoadoutItemInitializedEventHandler value);
            /*0x1f30ebc*/ void remove_LoadoutItemInitialized(YetiSimCoreLib.Messaging.LoadoutItemInitializedEventHandler value);
            /*0x1f30ebc*/ void add_LoadoutCooldownUpdated(YetiSimCoreLib.Messaging.LoadoutCooldownUpdatedEventHandler value);
            /*0x1f30ebc*/ void remove_LoadoutCooldownUpdated(YetiSimCoreLib.Messaging.LoadoutCooldownUpdatedEventHandler value);
            /*0x1f30ebc*/ void add_InstantUsePlantChargesChanged(YetiSimCoreLib.Messaging.InstantUsePlantChargesChangedEventHandler value);
            /*0x1f30ebc*/ void remove_InstantUsePlantChargesChanged(YetiSimCoreLib.Messaging.InstantUsePlantChargesChangedEventHandler value);
            /*0x1f30ebc*/ void add_InstantDefensePlantChargesChanged(YetiSimCoreLib.Messaging.InstantDefensePlantChargesChangedEventHandler value);
            /*0x1f30ebc*/ void remove_InstantDefensePlantChargesChanged(YetiSimCoreLib.Messaging.InstantDefensePlantChargesChangedEventHandler value);
            /*0x1f30ebc*/ void add_AddedModifier(YetiSimCoreLib.Messaging.AddedModifierEventHandler value);
            /*0x1f30ebc*/ void remove_AddedModifier(YetiSimCoreLib.Messaging.AddedModifierEventHandler value);
            /*0x1f30ebc*/ void add_RemovedModifier(YetiSimCoreLib.Messaging.RemovedModifierEventHandler value);
            /*0x1f30ebc*/ void remove_RemovedModifier(YetiSimCoreLib.Messaging.RemovedModifierEventHandler value);
            /*0x1f30ebc*/ void add_CheatEnableUnlimitedResources(YetiSimCoreLib.Messaging.CheatEnableUnlimitedResourcesEventHandler value);
            /*0x1f30ebc*/ void remove_CheatEnableUnlimitedResources(YetiSimCoreLib.Messaging.CheatEnableUnlimitedResourcesEventHandler value);
        }

        class MessageListenerWrapper : YetiSimAi.Core.ISimulationMessaging
        {
            /*0x10*/ YetiSimCoreLib.Messaging.CurrentTickChangedEventHandler CurrentTickChanged;
            /*0x18*/ YetiSimCoreLib.Messaging.UnitSpawnedEventHandler UnitSpawned;
            /*0x20*/ YetiSimCoreLib.Messaging.SimObjectDiedEventHandler SimObjectDied;
            /*0x28*/ YetiSimCoreLib.Messaging.SimObjectMovedEventHandler SimObjectMoved;
            /*0x30*/ YetiSimCoreLib.Messaging.PlantReclaimedEventHandler PlantReclaimed;
            /*0x38*/ YetiSimCoreLib.Messaging.SunValueChangedEventHandler SunValueChanged;
            /*0x40*/ YetiSimCoreLib.Messaging.SunSpawnedEventHandler SunSpawned;
            /*0x48*/ YetiSimCoreLib.Messaging.DynamicDropSpawnedEventHandler DynamicDropSpawned;
            /*0x50*/ YetiSimCoreLib.Messaging.PointOfLossEventHandler PointOfLoss;
            /*0x58*/ YetiSimCoreLib.Messaging.LossAversionResponseEventHandler LossAversionResponse;
            /*0x60*/ YetiSimCoreLib.Messaging.LoadoutItemInitializedEventHandler LoadoutItemInitialized;
            /*0x68*/ YetiSimCoreLib.Messaging.LoadoutCooldownUpdatedEventHandler LoadoutCooldownUpdated;
            /*0x70*/ YetiSimCoreLib.Messaging.InstantUsePlantChargesChangedEventHandler InstantUsePlantChargesChanged;
            /*0x78*/ YetiSimCoreLib.Messaging.InstantDefensePlantChargesChangedEventHandler InstantDefensePlantChargesChanged;
            /*0x80*/ YetiSimCoreLib.Messaging.AddedModifierEventHandler AddedModifier;
            /*0x88*/ YetiSimCoreLib.Messaging.RemovedModifierEventHandler RemovedModifier;
            /*0x90*/ YetiSimCoreLib.Messaging.CheatEnableUnlimitedResourcesEventHandler CheatEnableUnlimitedResources;

            /*0x4129d78*/ MessageListenerWrapper(YetiSimCoreLib.Messaging.IMessageListener messageListener);
            /*0x412a8e8*/ void add_CurrentTickChanged(YetiSimCoreLib.Messaging.CurrentTickChangedEventHandler value);
            /*0x412a984*/ void remove_CurrentTickChanged(YetiSimCoreLib.Messaging.CurrentTickChangedEventHandler value);
            /*0x412aa20*/ void add_UnitSpawned(YetiSimCoreLib.Messaging.UnitSpawnedEventHandler value);
            /*0x412aabc*/ void remove_UnitSpawned(YetiSimCoreLib.Messaging.UnitSpawnedEventHandler value);
            /*0x412ab58*/ void add_SimObjectDied(YetiSimCoreLib.Messaging.SimObjectDiedEventHandler value);
            /*0x412abf4*/ void remove_SimObjectDied(YetiSimCoreLib.Messaging.SimObjectDiedEventHandler value);
            /*0x412ac90*/ void add_SimObjectMoved(YetiSimCoreLib.Messaging.SimObjectMovedEventHandler value);
            /*0x412ad2c*/ void remove_SimObjectMoved(YetiSimCoreLib.Messaging.SimObjectMovedEventHandler value);
            /*0x412adc8*/ void add_PlantReclaimed(YetiSimCoreLib.Messaging.PlantReclaimedEventHandler value);
            /*0x412ae64*/ void remove_PlantReclaimed(YetiSimCoreLib.Messaging.PlantReclaimedEventHandler value);
            /*0x412af00*/ void add_SunValueChanged(YetiSimCoreLib.Messaging.SunValueChangedEventHandler value);
            /*0x412af9c*/ void remove_SunValueChanged(YetiSimCoreLib.Messaging.SunValueChangedEventHandler value);
            /*0x412b038*/ void add_SunSpawned(YetiSimCoreLib.Messaging.SunSpawnedEventHandler value);
            /*0x412b0d4*/ void remove_SunSpawned(YetiSimCoreLib.Messaging.SunSpawnedEventHandler value);
            /*0x412b170*/ void add_DynamicDropSpawned(YetiSimCoreLib.Messaging.DynamicDropSpawnedEventHandler value);
            /*0x412b20c*/ void remove_DynamicDropSpawned(YetiSimCoreLib.Messaging.DynamicDropSpawnedEventHandler value);
            /*0x412b2a8*/ void add_PointOfLoss(YetiSimCoreLib.Messaging.PointOfLossEventHandler value);
            /*0x412b344*/ void remove_PointOfLoss(YetiSimCoreLib.Messaging.PointOfLossEventHandler value);
            /*0x412b3e0*/ void add_LossAversionResponse(YetiSimCoreLib.Messaging.LossAversionResponseEventHandler value);
            /*0x412b47c*/ void remove_LossAversionResponse(YetiSimCoreLib.Messaging.LossAversionResponseEventHandler value);
            /*0x412b518*/ void add_LoadoutItemInitialized(YetiSimCoreLib.Messaging.LoadoutItemInitializedEventHandler value);
            /*0x412b5b4*/ void remove_LoadoutItemInitialized(YetiSimCoreLib.Messaging.LoadoutItemInitializedEventHandler value);
            /*0x412b650*/ void add_LoadoutCooldownUpdated(YetiSimCoreLib.Messaging.LoadoutCooldownUpdatedEventHandler value);
            /*0x412b6ec*/ void remove_LoadoutCooldownUpdated(YetiSimCoreLib.Messaging.LoadoutCooldownUpdatedEventHandler value);
            /*0x412b788*/ void add_InstantUsePlantChargesChanged(YetiSimCoreLib.Messaging.InstantUsePlantChargesChangedEventHandler value);
            /*0x412b824*/ void remove_InstantUsePlantChargesChanged(YetiSimCoreLib.Messaging.InstantUsePlantChargesChangedEventHandler value);
            /*0x412b8c0*/ void add_InstantDefensePlantChargesChanged(YetiSimCoreLib.Messaging.InstantDefensePlantChargesChangedEventHandler value);
            /*0x412b95c*/ void remove_InstantDefensePlantChargesChanged(YetiSimCoreLib.Messaging.InstantDefensePlantChargesChangedEventHandler value);
            /*0x412b9f8*/ void add_AddedModifier(YetiSimCoreLib.Messaging.AddedModifierEventHandler value);
            /*0x412ba94*/ void remove_AddedModifier(YetiSimCoreLib.Messaging.AddedModifierEventHandler value);
            /*0x412bb30*/ void add_RemovedModifier(YetiSimCoreLib.Messaging.RemovedModifierEventHandler value);
            /*0x412bbcc*/ void remove_RemovedModifier(YetiSimCoreLib.Messaging.RemovedModifierEventHandler value);
            /*0x412bc68*/ void add_CheatEnableUnlimitedResources(YetiSimCoreLib.Messaging.CheatEnableUnlimitedResourcesEventHandler value);
            /*0x412bd04*/ void remove_CheatEnableUnlimitedResources(YetiSimCoreLib.Messaging.CheatEnableUnlimitedResourcesEventHandler value);
            /*0x4129da4*/ void Subscribe(YetiSimCoreLib.Messaging.IMessageListener messageListener);
            /*0x412bda0*/ void <Subscribe>b__52_0(YetiSimCoreLib.Messaging.Events.CurrentTickChangedEventArgs args);
            /*0x412bdc0*/ void <Subscribe>b__52_1(YetiSimCoreLib.Messaging.Events.UnitSpawnedEventArgs args);
            /*0x412bddc*/ void <Subscribe>b__52_2(YetiSimCoreLib.Messaging.Events.SimObjectDiedEventArgs args);
            /*0x412be1c*/ void <Subscribe>b__52_3(YetiSimCoreLib.Messaging.Events.SimObjectMovedEventArgs args);
            /*0x412be38*/ void <Subscribe>b__52_4(YetiSimCoreLib.Messaging.Events.PlantReclaimedEventArgs args);
            /*0x412be58*/ void <Subscribe>b__52_5(YetiSimCoreLib.Messaging.Events.SunValueChangedEventArgs args);
            /*0x412be74*/ void <Subscribe>b__52_6(YetiSimCoreLib.Messaging.Events.SunSpawnedEventArgs args);
            /*0x412beb4*/ void <Subscribe>b__52_7(YetiSimCoreLib.Messaging.Events.DynamicDropSpawnedEventArgs args);
            /*0x412beec*/ void <Subscribe>b__52_8(YetiSimCoreLib.Messaging.Events.PointOfLossEventArgs args);
            /*0x412bf0c*/ void <Subscribe>b__52_9(YetiSimCoreLib.Messaging.Events.ILossAversionResponseMessage args);
            /*0x412bf28*/ void <Subscribe>b__52_10(YetiSimCoreLib.Messaging.Events.LoadoutItemInitializedEventArgs args);
            /*0x412bf44*/ void <Subscribe>b__52_11(YetiSimCoreLib.Messaging.Events.LoadoutCooldownUpdatedEventArgs args);
            /*0x412bf64*/ void <Subscribe>b__52_12(YetiSimCoreLib.Messaging.Events.InstantUsePlantChargesChangedEventArgs args);
            /*0x412bf84*/ void <Subscribe>b__52_13(YetiSimCoreLib.Messaging.Events.InstantDefensePlantChargesChangedEventArgs args);
            /*0x412bfa4*/ void <Subscribe>b__52_14(YetiSimCoreLib.Messaging.Events.AddedModifierEventArgs args);
            /*0x412bfe4*/ void <Subscribe>b__52_15(YetiSimCoreLib.Messaging.Events.RemovedModifierEventArgs args);
            /*0x412c024*/ void <Subscribe>b__52_16(YetiSimCoreLib.Messaging.Events.ICheatEnableUnlimitedResourcesMessage args);
        }

        class NoOpActionResolver : YetiSimAi.Core.IActionResolver
        {
            /*0x412c044*/ NoOpActionResolver();
            /*0x412c040*/ void Resolve();
        }

        class PriorityActionResolver
        {
            /*0x10*/ string Name;
            /*0x18*/ YetiSimAi.Core.IPriorityCalculator PriorityCalculator;
            /*0x20*/ YetiSimAi.Core.IActionResolver ActionResolver;

            /*0x412c04c*/ PriorityActionResolver(string name, YetiSimAi.Core.IPriorityCalculator priorityCalculator, YetiSimAi.Core.IActionResolver actionResolver);
        }

        interface IPriorityCalculation
        {
            float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
        }

        class UnsupportedCalculation : YetiSimAi.Core.IPriorityCalculation
        {
            /*0x412c0b4*/ UnsupportedCalculation();
            /*0x412c0ac*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
        }

        class SupportsLoadoutStrategy : System.MulticastDelegate
        {
            /*0x412c0bc*/ SupportsLoadoutStrategy(object object, nint method);
            /*0x412c1c4*/ bool Invoke(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
        }

        class PriorityCalculator : YetiSimAi.Core.IPriorityCalculator
        {
            /*0x10*/ YetiSimAi.Core.IPriorityCalculation _calculation;
            /*0x18*/ YetiSimAi.Core.SupportsLoadoutStrategy _supportsLoadout;
            /*0x20*/ int <Id>k__BackingField;
            /*0x28*/ string <Name>k__BackingField;
            /*0x30*/ string <ShortName>k__BackingField;
            /*0x38*/ float <BaseValue>k__BackingField;
            /*0x3c*/ float <MinValue>k__BackingField;
            /*0x40*/ float <MaxValue>k__BackingField;

            /*0x412c1d8*/ PriorityCalculator(int id, string name, string shortName, float baseValue, float minValue, float maxValue, YetiSimAi.Core.IPriorityCalculation calculation, YetiSimAi.Core.SupportsLoadoutStrategy supportsLoadoutStrategy);
            /*0x412c280*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            /*0x412c390*/ bool SupportsLoadout(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
            /*0x412c3b0*/ float get_BaseValue();
            /*0x412c3b8*/ void set_BaseValue(float value);
            /*0x412c3c0*/ float get_MinValue();
            /*0x412c3c8*/ float get_MaxValue();
        }

        class SimulationStateTracker
        {
            /*0x10*/ YetiSimCoreLib.YetiSimTime _simTime;
            /*0x18*/ YetiSimCoreLib.Game.UnitDatabase _unitDatabase;
            /*0x20*/ System.Collections.Generic.Dictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> _trackedPlantInstances;
            /*0x28*/ System.Collections.Generic.Dictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> _trackedZombieInstances;
            /*0x30*/ System.Collections.Generic.Dictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.SunInstanceTrackingData> _trackedCollectableSunInstances;
            /*0x38*/ System.Collections.Generic.Dictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.DropInstanceTrackingData> _trackedCollectableDropInstances;
            /*0x40*/ System.Collections.Generic.List<int> _loadoutIndexCooldownTicksRemaining;
            /*0x48*/ System.Collections.Generic.List<YetiSimCoreLib.Game.UnitId> _loadoutIndexUnitIds;
            /*0x50*/ System.Collections.Generic.Dictionary<YetiSimCoreLib.Game.UnitId, int> _plantUnitLastSpawned;
            /*0x58*/ System.Collections.Generic.Dictionary<int, int> _instantUsePlantUnitIdToUsesAvailable;
            /*0x60*/ System.Collections.Generic.Dictionary<int, int> _instantDefensePlantUnitIdToUsesAvailable;
            /*0x68*/ int <CurrentSimulationTimeInMs>k__BackingField;
            /*0x6c*/ bool _unlimitedResourcesEnabled;
            /*0x70*/ int _currentSunAvailable;
            /*0x74*/ bool <PointOfLossResponseNeeded>k__BackingField;

            /*0x412c3d0*/ SimulationStateTracker(YetiSimAi.Core.ISimulationMessaging messages, YetiSimCoreLib.Game.UnitDatabase unitDatabase, YetiSimCoreLib.YetiSimTime simTime);
            /*0x412d1f8*/ int get_CurrentSimulationTimeInMs();
            /*0x412d200*/ void set_CurrentSimulationTimeInMs(int value);
            /*0x4127574*/ int get_CurrentSunAvailable();
            /*0x412d208*/ void set_CurrentSunAvailable(int value);
            /*0x412d210*/ bool get_PointOfLossResponseNeeded();
            /*0x412d218*/ void set_PointOfLossResponseNeeded(bool value);
            /*0x412d220*/ System.Collections.Generic.IReadOnlyDictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.SunInstanceTrackingData> SunInstances();
            /*0x412d228*/ System.Collections.Generic.IReadOnlyDictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.DropInstanceTrackingData> DropInstances();
            /*0x412d230*/ System.Collections.Generic.IReadOnlyDictionary<int, int> InstantUsePlantUsesAvailable();
            /*0x412d238*/ System.Collections.Generic.IReadOnlyDictionary<int, int> InstantDefensePlantUsesAvailable();
            /*0x4127cc8*/ int GetPlantCooldownTimeInTicks(YetiSimCoreLib.Game.UnitId unitId);
            /*0x4128070*/ System.Nullable<int> GetPlantableLoadoutIndexForUnit(YetiSimCoreLib.Game.UnitId unitId);
            /*0x4127b0c*/ System.Nullable<int> GetLastPlantSpawnTimeInMs(YetiSimCoreLib.Game.UnitId unitId);
            /*0x412d240*/ System.Collections.Generic.IReadOnlyDictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> ZombiesOnBoard();
            /*0x412d248*/ System.Collections.Generic.IReadOnlyDictionary<YetiSimCoreLib.Game.InstanceId, YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData> PlantsOnBoard();
            /*0x412c6b8*/ void Subscribe(YetiSimAi.Core.ISimulationMessaging messages);
            /*0x412d250*/ void HandleCurrentTickChanged(YetiSimCoreLib.Messaging.Events.CurrentTickChangedEventArgs args);
            /*0x412d278*/ void HandleSimObjectDied(YetiSimCoreLib.Messaging.Events.SimObjectDiedEventArgs args);
            /*0x412d360*/ void HandlePlantReclaimed(YetiSimCoreLib.Messaging.Events.PlantReclaimedEventArgs args);
            /*0x412d3c8*/ void HandleSunSpawned(YetiSimCoreLib.Messaging.Events.SunSpawnedEventArgs args);
            /*0x412d4ac*/ void HandleDynamicDropSpawned(YetiSimCoreLib.Messaging.Events.DynamicDropSpawnedEventArgs args);
            /*0x412d5a8*/ void HandleUnitSpawned(YetiSimCoreLib.Messaging.Events.UnitSpawnedEventArgs args);
            /*0x412da74*/ void HandleSimObjectMoved(YetiSimCoreLib.Messaging.Events.SimObjectMovedEventArgs args);
            /*0x412db68*/ void HandleSunValueChanged(YetiSimCoreLib.Messaging.Events.SunValueChangedEventArgs args);
            /*0x412db70*/ void HandlePointOfLoss(YetiSimCoreLib.Messaging.Events.PointOfLossEventArgs args);
            /*0x412db7c*/ void HandleLossAversionResponse(YetiSimCoreLib.Messaging.Events.ILossAversionResponseMessage args);
            /*0x412db84*/ void HandleLoadoutItemInitialized(YetiSimCoreLib.Messaging.Events.LoadoutItemInitializedEventArgs args);
            /*0x412dc20*/ void HandleUnitCooldownUpdated(YetiSimCoreLib.Messaging.Events.LoadoutCooldownUpdatedEventArgs args);
            /*0x412dc90*/ void HandleInstantUsePlantChargesChanged(YetiSimCoreLib.Messaging.Events.InstantUsePlantChargesChangedEventArgs args);
            /*0x412dd4c*/ void HandleInstantDefensePlantChargesChanged(YetiSimCoreLib.Messaging.Events.InstantDefensePlantChargesChangedEventArgs args);
            /*0x412de08*/ void HandleAddedModifier(YetiSimCoreLib.Messaging.Events.AddedModifierEventArgs args);
            /*0x412de94*/ void HandleRemovedModifier(YetiSimCoreLib.Messaging.Events.RemovedModifierEventArgs args);
            /*0x412df1c*/ void HandleCheatEnableUnlimitedResources(YetiSimCoreLib.Messaging.Events.ICheatEnableUnlimitedResourcesMessage args);

            class InstanceTrackingData
            {
                /*0x10*/ System.Collections.Generic.Dictionary<Yeti.Data.StatType, int> _stats;
                /*0x18*/ YetiSimCoreLib.Game.InstanceId <InstanceId>k__BackingField;
                /*0x1c*/ YetiSimCoreLib.Game.Position <CurrentPosition>k__BackingField;
                /*0x28*/ YetiSimCoreLib.Game.GridCell <GridCell>k__BackingField;
                /*0x30*/ Yeti.Data.UnitDefinition <UnitDefinition>k__BackingField;
                /*0x38*/ Yeti.Data.DirectionType <Orientation>k__BackingField;

                /*0x412d97c*/ InstanceTrackingData();
                /*0x412df28*/ YetiSimCoreLib.Game.InstanceId get_InstanceId();
                /*0x412df30*/ void set_InstanceId(YetiSimCoreLib.Game.InstanceId value);
                /*0x412df38*/ YetiSimCoreLib.Game.Position get_CurrentPosition();
                /*0x412df48*/ void set_CurrentPosition(YetiSimCoreLib.Game.Position value);
                /*0x412df54*/ void set_GridCell(YetiSimCoreLib.Game.GridCell value);
                /*0x412df5c*/ YetiSimCoreLib.Game.GridCell get_GridCell();
                /*0x412df64*/ Yeti.Data.UnitDefinition get_UnitDefinition();
                /*0x412df6c*/ void set_UnitDefinition(Yeti.Data.UnitDefinition value);
                /*0x412df74*/ Yeti.Data.DirectionType get_Orientation();
                /*0x412df7c*/ void set_Orientation(Yeti.Data.DirectionType value);
                /*0x412da04*/ void SetStatValue(Yeti.Data.StatType statType, int value);
                /*0x412df84*/ int GetStatValue(Yeti.Data.StatType statType);
            }

            class SunInstanceTrackingData
            {
                /*0x10*/ bool <IsFromSky>k__BackingField;
                /*0x14*/ int <SpawnTimeInMs>k__BackingField;

                /*0x412d47c*/ SunInstanceTrackingData(bool isFromSky, int spawnTimeInMs);
                /*0x412e000*/ bool get_IsFromSky();
                /*0x412e008*/ int get_SpawnTimeInMs();
            }

            class DropInstanceTrackingData
            {
                /*0x10*/ Yeti.Data.DynamicDropDefinition <DropDef>k__BackingField;
                /*0x18*/ int <SpawnTimeInMs>k__BackingField;

                /*0x412d56c*/ DropInstanceTrackingData(Yeti.Data.DynamicDropDefinition dropDef, int spawnTimeInMs);
                /*0x412e010*/ int get_SpawnTimeInMs();
            }
        }

        class StaticPriorityCalculator : YetiSimAi.Core.IPriorityCalculator
        {
            /*0x10*/ float _priority;
            /*0x18*/ string <ShortName>k__BackingField;

            /*0x412e018*/ StaticPriorityCalculator(float priority, string shortName);
            /*0x412e058*/ float Calculate(YetiSimAi.Core.IGameStateSnapshot snapshot);
            /*0x412e060*/ bool SupportsLoadout(YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot);
        }

        interface IUnitGroupProvider
        {
            /*0x1f2fe80*/ bool TryGet(int groupId, ref YetiSimAi.Core.UnitGroup unitGroup);
            /*0x1f30240*/ YetiSimAi.Core.UnitGroup ForId(int groupId);
            /*0x1f30214*/ YetiSimAi.Core.UnitGroup get_EmptyGroup();
        }

        class UnitGroup : YetiSimAi.Core.IUnitIdsProvider
        {
            /*0x10*/ System.Collections.Generic.HashSet<int> _unitIds;
            /*0x18*/ int <Id>k__BackingField;
            /*0x20*/ string <Name>k__BackingField;

            /*0x412e1a4*/ UnitGroup(int id, string name, System.Collections.Generic.HashSet<int> unitIds);
            /*0x412e068*/ bool Equals(YetiSimAi.Core.UnitGroup other);
            /*0x412e088*/ bool Equals(object obj);
            /*0x412e184*/ int GetHashCode();
            /*0x412e1f8*/ int get_Id();
            /*0x412e200*/ bool IncludesUnit(int unitId);
            /*0x412e26c*/ System.Collections.Generic.ISet<int> get_UnitIds();
        }

        class GameDataUnitGroupProvider : YetiSimAi.Core.IUnitGroupProvider
        {
            static /*0x0*/ YetiSimAi.Core.UnitGroup EmptyUnitGroup;
            /*0x10*/ System.Collections.Generic.Dictionary<int, YetiSimAi.Core.UnitGroup> _unitGroups;

            static /*0x412e800*/ GameDataUnitGroupProvider();
            /*0x412e274*/ GameDataUnitGroupProvider(PvzN3xt.Data.AiConfig config);
            /*0x412e698*/ bool TryGet(int groupId, ref YetiSimAi.Core.UnitGroup unitGroup);
            /*0x412e70c*/ YetiSimAi.Core.UnitGroup ForId(int groupId);
            /*0x412e7a8*/ YetiSimAi.Core.UnitGroup get_EmptyGroup();
        }

        class ZombiesInTargetingAreaFilteredOptionComparer : System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption>
        {
            /*0x10*/ YetiSimAi.Core.TargetingAreaZombieCalculator _targetingAreaZombieCalculator;

            /*0x412e8e4*/ ZombiesInTargetingAreaFilteredOptionComparer(YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            /*0x412e99c*/ int Compare(YetiSimAi.Core.FilteredOption x, YetiSimAi.Core.FilteredOption y);
        }

        class ZombiesInOrWillCrossTargetingAreaFilteredOptionComparer : System.Collections.Generic.IComparer<YetiSimAi.Core.FilteredOption>
        {
            /*0x10*/ YetiSimAi.Core.TargetingAreaZombieCalculator _targetingAreaZombieCalculator;

            /*0x412f1c4*/ ZombiesInOrWillCrossTargetingAreaFilteredOptionComparer(YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            /*0x412f24c*/ int Compare(YetiSimAi.Core.FilteredOption x, YetiSimAi.Core.FilteredOption y);
        }

        class TargetingAreaZombieCalculator
        {
            /*0x10*/ YetiSimCoreCommon.Utils.CombatDefinitionProvider _combatDefinitionProvider;

            /*0x412e96c*/ TargetingAreaZombieCalculator(YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            /*0x412ea14*/ int ZombiesInAreaByZombiePosition(YetiSimAi.Core.FilteredOption filteredOption);
            /*0x412f2c4*/ int ZombiesInOrThatWillCrossByZombiePosition(YetiSimAi.Core.FilteredOption filteredOption);
            /*0x412fa78*/ bool TryGetSupportedTargetingStrategy(Yeti.Data.TargetingDefinition targetingDef, ref YetiSimAi.Core.TargetingAreaZombieCalculator.IAreaZombiesFinder areaZombiesFinder);

            interface IAreaZombiesFinder
            {
                void AddAllZombiesInTargetAreaByPosition(System.Collections.Generic.ISet<int> zombieInstanceIdsInArea, Yeti.Data.TargetingDefinition targetingDef, YetiSimCoreLib.Game.Position targetingCenter, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
                void AddAllZombiesInOrThatWillCrossByZombiePosition(System.Collections.Generic.ISet<int> zombieInstanceIdsInArea, Yeti.Data.TargetingDefinition targetingDef, YetiSimCoreLib.Game.Position targetingCenter, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
            }

            class TargetPatternAreaZombiesFinder : YetiSimAi.Core.TargetingAreaZombieCalculator.IAreaZombiesFinder
            {
                static /*0x0*/ YetiSimAi.Core.TargetingAreaZombieCalculator.TargetPatternAreaZombiesFinder Instance;

                static /*0x4130f3c*/ TargetPatternAreaZombiesFinder();
                /*0x4130f34*/ TargetPatternAreaZombiesFinder();
                /*0x412fb14*/ void AddAllZombiesInTargetAreaByPosition(System.Collections.Generic.ISet<int> zombieInstanceIdsInArea, Yeti.Data.TargetingDefinition targetingDef, YetiSimCoreLib.Game.Position targetingCenter, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
                /*0x41304dc*/ void AddAllZombiesInOrThatWillCrossByZombiePosition(System.Collections.Generic.ISet<int> zombieInstanceIdsInArea, Yeti.Data.TargetingDefinition targetingDef, YetiSimCoreLib.Game.Position targetingCenter, YetiSimAi.Core.IGameStateSnapshot gameStateSnapshot, YetiSimCoreCommon.Utils.CombatDefinitionProvider combatDefinitionProvider);
                /*0x4130e1c*/ YetiSimAi.Util.Rect GenerateZombiePositionPath(YetiSimAi.Core.SimulationStateTracker.InstanceTrackingData zombie);
                /*0x4130440*/ YetiSimAi.Util.Rect GetTargetAreaRect(Yeti.Data.TargetArea area, YetiSimCoreLib.Game.Position targetingCenter);
            }
        }
    }
}
