class <Module>
{
}

class VisualEffectActivationBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    /*0x10*/ UnityEngine.VFX.Utility.ExposedProperty onClipEnter;
    /*0x18*/ UnityEngine.VFX.Utility.ExposedProperty onClipExit;
    /*0x20*/ VisualEffectActivationBehaviour.EventState[] clipEnterEventAttributes;
    /*0x28*/ VisualEffectActivationBehaviour.EventState[] clipExitEventAttributes;

    /*0x7da6c24*/ VisualEffectActivationBehaviour();

    enum AttributeType
    {
        Float = 1,
        Float2 = 2,
        Float3 = 3,
        Float4 = 4,
        Int32 = 5,
        Uint32 = 6,
        Boolean = 17,
    }

    struct EventState
    {
        /*0x10*/ UnityEngine.VFX.Utility.ExposedProperty attribute;
        /*0x18*/ VisualEffectActivationBehaviour.AttributeType type;
        /*0x20*/ float[] values;
    }
}

class VisualEffectActivationClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    /*0x18*/ VisualEffectActivationBehaviour activationBehavior;

    /*0x7da6e1c*/ VisualEffectActivationClip();
    /*0x7da6d28*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
    /*0x7da6d30*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7da6e84*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7da6f78*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UnityEngine
{
    namespace VFX
    {
        class IncrementStripIndexOnStart : UnityEngine.VFX.VFXSpawnerCallbacks
        {
            static /*0x0*/ int stripMaxCountID;
            static /*0x4*/ int stripIndexID;
            /*0x18*/ uint m_Index;

            static /*0x7da7094*/ IncrementStripIndexOnStart();
            /*0x7da708c*/ IncrementStripIndexOnStart();
            /*0x7da6f80*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da7080*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da7088*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);

            class InputProperties
            {
                /*0x10*/ uint StripMaxCount;

                /*0x7da7130*/ InputProperties();
            }
        }

        class LoopAndDelay : UnityEngine.VFX.VFXSpawnerCallbacks
        {
            static /*0x0*/ int loopCountPropertyID;
            static /*0x4*/ int loopDurationPropertyID;
            static /*0x8*/ int delayPropertyID;
            /*0x18*/ int m_LoopMaxCount;
            /*0x1c*/ int m_LoopCurrentIndex;
            /*0x20*/ float m_WaitingForTotalTime;

            static /*0x7da7380*/ LoopAndDelay();
            /*0x7da7378*/ LoopAndDelay();
            /*0x7da7140*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da720c*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da736c*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);

            class InputProperties
            {
                /*0x10*/ int LoopCount;
                /*0x14*/ float LoopDuration;
                /*0x18*/ float Delay;

                /*0x7da7448*/ InputProperties();
            }
        }

        class SetSpawnTime : UnityEngine.VFX.VFXSpawnerCallbacks
        {
            static /*0x0*/ int spawnTimeID;

            static /*0x7da7508*/ SetSpawnTime();
            /*0x7da7500*/ SetSpawnTime();
            /*0x7da7464*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da7468*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da74fc*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
        }

        class SpawnOverDistance : UnityEngine.VFX.VFXSpawnerCallbacks
        {
            static /*0x0*/ int positionPropertyId;
            static /*0x4*/ int ratePerUnitPropertyId;
            static /*0x8*/ int velocityThresholdPropertyId;
            static /*0xc*/ int clampToOnePropertyId;
            static /*0x10*/ int positionAttributeId;
            static /*0x14*/ int oldPositionAttributeId;
            /*0x18*/ UnityEngine.Vector3 m_OldPosition;

            static /*0x7da7864*/ SpawnOverDistance();
            /*0x7da785c*/ SpawnOverDistance();
            /*0x7da7570*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da75f4*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7da7858*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);

            class InputProperties
            {
                /*0x10*/ UnityEngine.Vector3 Position;
                /*0x1c*/ float RatePerUnit;
                /*0x20*/ float VelocityThreshold;
                /*0x24*/ bool ClampToOne;

                /*0x7da79c0*/ InputProperties();
            }
        }

        class VFXTypeAttribute : System.Attribute
        {
            /*0x10*/ UnityEngine.VFX.VFXTypeAttribute.Usage <usages>k__BackingField;
            /*0x18*/ string <name>k__BackingField;

            /*0x7da7a2c*/ VFXTypeAttribute(UnityEngine.VFX.VFXTypeAttribute.Usage usages, string name);
            /*0x7da7a64*/ UnityEngine.VFX.VFXTypeAttribute.Usage get_usages();
            /*0x7da7a6c*/ void set_usages(UnityEngine.VFX.VFXTypeAttribute.Usage value);
            /*0x7da7a74*/ string get_name();
            /*0x7da7a7c*/ void set_name(string value);

            enum Usage
            {
                Default = 1,
                GraphicsBuffer = 2,
                ExcludeFromProperty = 4,
            }
        }

        class VisualEffectControlClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
        {
            /*0x18*/ double <clipStart>k__BackingField;
            /*0x20*/ double <clipEnd>k__BackingField;
            /*0x28*/ bool scrubbing;
            /*0x2c*/ uint startSeed;
            /*0x30*/ UnityEngine.VFX.VisualEffectControlClip.ReinitMode reinit;
            /*0x38*/ UnityEngine.VFX.VisualEffectControlClip.PrewarmClipSettings prewarm;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.VFX.VisualEffectControlClip.ClipEvent> clipEvents;
            /*0x58*/ System.Collections.Generic.List<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> singleEvents;

            /*0x7da82e8*/ VisualEffectControlClip();
            /*0x7da7a84*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7da7a8c*/ double get_clipStart();
            /*0x7da7a94*/ void set_clipStart(double value);
            /*0x7da7a9c*/ double get_clipEnd();
            /*0x7da7aa4*/ void set_clipEnd(double value);
            /*0x7da7aac*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);

            enum ReinitMode
            {
                None = 0,
                OnExitClip = 1,
                OnEnterClip = 2,
                OnEnterOrExitClip = 3,
            }

            struct PrewarmClipSettings
            {
                /*0x10*/ bool enable;
                /*0x14*/ uint stepCount;
                /*0x18*/ float deltaTime;
                /*0x20*/ UnityEngine.VFX.Utility.ExposedProperty eventName;
            }

            struct ClipEvent
            {
                static /*0x0*/ UnityEngine.Color defaultEditorColor;
                /*0x10*/ UnityEngine.Color editorColor;
                /*0x20*/ UnityEngine.VFX.VisualEffectPlayableSerializedEventNoColor enter;
                /*0x40*/ UnityEngine.VFX.VisualEffectPlayableSerializedEventNoColor exit;

                static /*0x7da8714*/ ClipEvent();
            }
        }

        struct EventAttributes
        {
            /*0x10*/ UnityEngine.VFX.EventAttribute[] content;
        }

        class EventAttribute
        {
            /*0x10*/ UnityEngine.VFX.Utility.ExposedProperty id;

            /*0x7da8764*/ EventAttribute();
            /*0x380b2f0*/ bool ApplyToVFX(UnityEngine.VFX.VFXEventAttribute eventAttribute);
        }

        class EventAttributeValue<T> : UnityEngine.VFX.EventAttribute
        {
            /*0x0*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> m_HasFunc;
            /*0x0*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, T> m_ApplyFunc;
            /*0x0*/ T value;

            /*0x380d93c*/ EventAttributeValue(System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> hasFunc, System.Action<UnityEngine.VFX.VFXEventAttribute, int, T> applyFunc);
            /*0x380b2f0*/ bool ApplyToVFX(UnityEngine.VFX.VFXEventAttribute eventAttribute);
        }

        class EventAttributeFloat : UnityEngine.VFX.EventAttributeValue<float>
        {
            /*0x7da876c*/ EventAttributeFloat();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeFloat.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, float> <>9__0_1;

                static /*0x7da8900*/ <>c();
                /*0x7da8968*/ <>c();
                /*0x7da8970*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7da898c*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, float value);
            }
        }

        class EventAttributeVector2 : UnityEngine.VFX.EventAttributeValue<UnityEngine.Vector2>
        {
            /*0x7da89a8*/ EventAttributeVector2();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeVector2.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, UnityEngine.Vector2> <>9__0_1;

                static /*0x7da8b3c*/ <>c();
                /*0x7da8ba4*/ <>c();
                /*0x7da8bac*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7da8bc8*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, UnityEngine.Vector2 value);
            }
        }

        class EventAttributeVector3 : UnityEngine.VFX.EventAttributeValue<UnityEngine.Vector3>
        {
            /*0x7da8be4*/ EventAttributeVector3();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeVector3.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, UnityEngine.Vector3> <>9__0_1;

                static /*0x7da8d78*/ <>c();
                /*0x7da8de0*/ <>c();
                /*0x7da8de8*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7da8e04*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, UnityEngine.Vector3 value);
            }
        }

        class EventAttributeColor : UnityEngine.VFX.EventAttributeVector3
        {
            /*0x7da8e20*/ EventAttributeColor();
        }

        class EventAttributeVector4 : UnityEngine.VFX.EventAttributeValue<UnityEngine.Vector4>
        {
            /*0x7da8e24*/ EventAttributeVector4();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeVector4.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, UnityEngine.Vector4> <>9__0_1;

                static /*0x7da8fb8*/ <>c();
                /*0x7da9020*/ <>c();
                /*0x7da9028*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7da9044*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, UnityEngine.Vector4 value);
            }
        }

        class EventAttributeInt : UnityEngine.VFX.EventAttributeValue<int>
        {
            /*0x7da9060*/ EventAttributeInt();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeInt.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, int> <>9__0_1;

                static /*0x7da91f4*/ <>c();
                /*0x7da925c*/ <>c();
                /*0x7da9264*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7da9280*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, int value);
            }
        }

        class EventAttributeUInt : UnityEngine.VFX.EventAttributeValue<uint>
        {
            /*0x7da92a0*/ EventAttributeUInt();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeUInt.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, uint> <>9__0_1;

                static /*0x7da9434*/ <>c();
                /*0x7da949c*/ <>c();
                /*0x7da94a4*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7da94c0*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, uint value);
            }
        }

        class EventAttributeBool : UnityEngine.VFX.EventAttributeValue<bool>
        {
            /*0x7da94e0*/ EventAttributeBool();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeBool.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_1;

                static /*0x7da9674*/ <>c();
                /*0x7da96dc*/ <>c();
                /*0x7da96e4*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7da9700*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, bool value);
            }
        }

        class VFXTimeSpaceHelper
        {
            static /*0x7da9724*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(UnityEngine.VFX.PlayableTimeSpace space, UnityEngine.VFX.VisualEffectControlPlayableBehaviour source);
            static /*0x7da97e8*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> CollectClipEvents(UnityEngine.VFX.VisualEffectControlClip source);
            static /*0x7da9898*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(UnityEngine.VFX.PlayableTimeSpace space, UnityEngine.VFX.VisualEffectControlClip source, bool clipEvents);
            static /*0x7da9744*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(UnityEngine.VFX.PlayableTimeSpace space, System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> events, double clipStart, double clipEnd);
            static /*0x7da9914*/ double GetTimeInSpace(UnityEngine.VFX.PlayableTimeSpace srcSpace, double srcTime, UnityEngine.VFX.PlayableTimeSpace dstSpace, double clipStart, double clipEnd);

            class <CollectClipEvents>d__1 : System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent <>2__current;
                /*0x48*/ int <>l__initialThreadId;
                /*0x50*/ UnityEngine.VFX.VisualEffectControlClip source;
                /*0x58*/ UnityEngine.VFX.VisualEffectControlClip <>3__source;
                /*0x60*/ System.Collections.Generic.List.Enumerator<UnityEngine.VFX.VisualEffectControlClip.ClipEvent> <>7__wrap1;
                /*0xc0*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent <eventExit>5__3;

                /*0x7da9864*/ <CollectClipEvents>d__1(int <>1__state);
                /*0x7da9ae8*/ void System.IDisposable.Dispose();
                /*0x7da9b14*/ bool MoveNext();
                /*0x7da9e60*/ void <>m__Finally1();
                /*0x7da9eb0*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.get_Current();
                /*0x7da9ec8*/ void System.Collections.IEnumerator.Reset();
                /*0x7da9f00*/ object System.Collections.IEnumerator.get_Current();
                /*0x7da9f68*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.GetEnumerator();
                /*0x7daa00c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetEventNormalizedSpace>d__3 : System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent <>2__current;
                /*0x48*/ int <>l__initialThreadId;
                /*0x50*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> events;
                /*0x58*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> <>3__events;
                /*0x60*/ UnityEngine.VFX.PlayableTimeSpace space;
                /*0x64*/ UnityEngine.VFX.PlayableTimeSpace <>3__space;
                /*0x68*/ double clipStart;
                /*0x70*/ double <>3__clipStart;
                /*0x78*/ double clipEnd;
                /*0x80*/ double <>3__clipEnd;
                /*0x88*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> <>7__wrap1;

                /*0x7da98e0*/ <GetEventNormalizedSpace>d__3(int <>1__state);
                /*0x7daa010*/ void System.IDisposable.Dispose();
                /*0x7daa02c*/ bool MoveNext();
                /*0x7daa36c*/ void <>m__Finally1();
                /*0x7daa41c*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.get_Current();
                /*0x7daa434*/ void System.Collections.IEnumerator.Reset();
                /*0x7daa46c*/ object System.Collections.IEnumerator.get_Current();
                /*0x7daa4d4*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.GetEnumerator();
                /*0x7daa590*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        enum PlayableTimeSpace
        {
            AfterClipStart = 0,
            BeforeClipEnd = 1,
            Percentage = 2,
            Absolute = 3,
        }

        struct VisualEffectPlayableSerializedEvent
        {
            /*0x10*/ UnityEngine.Color editorColor;
            /*0x20*/ double time;
            /*0x28*/ UnityEngine.VFX.PlayableTimeSpace timeSpace;
            /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty name;
            /*0x38*/ UnityEngine.VFX.EventAttributes eventAttributes;
        }

        struct VisualEffectPlayableSerializedEventNoColor
        {
            /*0x10*/ double time;
            /*0x18*/ UnityEngine.VFX.PlayableTimeSpace timeSpace;
            /*0x20*/ UnityEngine.VFX.Utility.ExposedProperty name;
            /*0x28*/ UnityEngine.VFX.EventAttributes eventAttributes;

            static /*0x7da8270*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent op_Implicit(UnityEngine.VFX.VisualEffectPlayableSerializedEventNoColor evt);
        }

        class VisualEffectControlPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ double <clipStart>k__BackingField;
            /*0x18*/ double <clipEnd>k__BackingField;
            /*0x20*/ bool <scrubbing>k__BackingField;
            /*0x21*/ bool <reinitEnter>k__BackingField;
            /*0x22*/ bool <reinitExit>k__BackingField;
            /*0x24*/ uint <startSeed>k__BackingField;
            /*0x28*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent[] <events>k__BackingField;
            /*0x30*/ uint <clipEventsCount>k__BackingField;
            /*0x34*/ uint <prewarmStepCount>k__BackingField;
            /*0x38*/ float <prewarmDeltaTime>k__BackingField;
            /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty <prewarmEvent>k__BackingField;

            /*0x7daa650*/ VisualEffectControlPlayableBehaviour();
            /*0x7daa594*/ double get_clipStart();
            /*0x7daa59c*/ void set_clipStart(double value);
            /*0x7daa5a4*/ double get_clipEnd();
            /*0x7daa5ac*/ void set_clipEnd(double value);
            /*0x7daa5b4*/ bool get_scrubbing();
            /*0x7daa5bc*/ void set_scrubbing(bool value);
            /*0x7daa5c8*/ bool get_reinitEnter();
            /*0x7daa5d0*/ void set_reinitEnter(bool value);
            /*0x7daa5dc*/ bool get_reinitExit();
            /*0x7daa5e4*/ void set_reinitExit(bool value);
            /*0x7daa5f0*/ uint get_startSeed();
            /*0x7daa5f8*/ void set_startSeed(uint value);
            /*0x7daa600*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent[] get_events();
            /*0x7daa608*/ void set_events(UnityEngine.VFX.VisualEffectPlayableSerializedEvent[] value);
            /*0x7daa610*/ uint get_clipEventsCount();
            /*0x7daa618*/ void set_clipEventsCount(uint value);
            /*0x7daa620*/ uint get_prewarmStepCount();
            /*0x7daa628*/ void set_prewarmStepCount(uint value);
            /*0x7daa630*/ float get_prewarmDeltaTime();
            /*0x7daa638*/ void set_prewarmDeltaTime(float value);
            /*0x7daa640*/ UnityEngine.VFX.Utility.ExposedProperty get_prewarmEvent();
            /*0x7daa648*/ void set_prewarmEvent(UnityEngine.VFX.Utility.ExposedProperty value);
        }

        class VisualEffectControlTrack : UnityEngine.Timeline.TrackAsset
        {
            static int kCurrentVersion = 1;
            /*0xa0*/ int m_VFXVersion;
            /*0xa4*/ UnityEngine.VFX.VisualEffectControlTrack.ReinitMode reinit;

            /*0x7daacc0*/ VisualEffectControlTrack();
            /*0x7daa658*/ bool IsUpToDate();
            /*0x7daa668*/ void OnBeforeTrackSerialize();
            /*0x7daa79c*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x7daac08*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);

            enum ReinitMode
            {
                None = 0,
                OnBindingEnable = 1,
                OnBindingDisable = 2,
                OnBindingEnableOrDisable = 3,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.VisualEffectControlTrack.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Timeline.TimelineClip, bool> <>9__5_0;

                static /*0x7daad20*/ <>c();
                /*0x7daad88*/ <>c();
                /*0x7daad90*/ bool <OnBeforeTrackSerialize>b__5_0(UnityEngine.Timeline.TimelineClip x);
            }
        }

        class VisualEffectControlTrackController
        {
            static int kErrorIndex = -2147483648;
            static /*0x0*/ double kEpsilonEvent;
            /*0x10*/ int m_LastChunk;
            /*0x14*/ int m_LastEvent;
            /*0x18*/ double m_LastPlayableTime;
            /*0x20*/ System.Collections.Generic.List<int> m_EventListIndexCache;
            /*0x28*/ UnityEngine.VFX.VisualEffect m_Target;
            /*0x30*/ bool m_BackupReseedOnPlay;
            /*0x34*/ uint m_BackupStartSeed;
            /*0x38*/ UnityEngine.VFX.VisualEffectControlTrackController.Chunk[] m_Chunks;

            static /*0x7dad428*/ VisualEffectControlTrackController();
            static /*0x7dabe04*/ void GetEventsIndex(UnityEngine.VFX.VisualEffectControlTrackController.Chunk chunk, double minTime, double maxTime, int lastIndex, System.Collections.Generic.List<int> eventListIndex);
            static /*0x7dabf90*/ UnityEngine.VFX.VFXEventAttribute ComputeAttribute(UnityEngine.VFX.VisualEffect vfx, UnityEngine.VFX.EventAttributes attributes);
            static /*0x7dac04c*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectControlTrackController.Event> ComputeRuntimeEvent(UnityEngine.VFX.VisualEffectControlPlayableBehaviour behavior, UnityEngine.VFX.VisualEffect vfx);
            /*0x7dad390*/ VisualEffectControlTrackController();
            /*0x7daae14*/ void OnEnterChunk(int currentChunk);
            /*0x7daaef4*/ void OnLeaveChunk(int previousChunkIndex, bool leavingGoingBeforeClip);
            /*0x7dab490*/ bool IsTimeInChunk(double time, int index);
            /*0x7dab4d8*/ void Update(double playableTime, float deltaTime);
            /*0x7dab09c*/ void ProcessNoScrubbingEvents(UnityEngine.VFX.VisualEffectControlTrackController.Chunk chunk, double oldTime, double newTime);
            /*0x7dabf34*/ void ProcessEvent(int eventIndex, UnityEngine.VFX.VisualEffectControlTrackController.Chunk currentChunk);
            /*0x7dab3c4*/ void RestoreVFXState(bool restorePause, bool restoreSeedState);
            /*0x7dac118*/ void Init(UnityEngine.Playables.Playable playable, UnityEngine.VFX.VisualEffect vfx, UnityEngine.VFX.VisualEffectControlTrack parentTrack);
            /*0x7dad384*/ void Release();

            struct Event
            {
                /*0x10*/ int nameId;
                /*0x18*/ UnityEngine.VFX.VFXEventAttribute attribute;
                /*0x20*/ double time;
                /*0x28*/ int clipIndex;
                /*0x2c*/ UnityEngine.VFX.VisualEffectControlTrackController.Event.ClipType clipType;

                enum ClipType
                {
                    None = 0,
                    Enter = 1,
                    Exit = 2,
                }
            }

            struct Clip
            {
                /*0x10*/ int enter;
                /*0x14*/ int exit;
            }

            struct Chunk
            {
                /*0x10*/ bool scrubbing;
                /*0x11*/ bool reinitEnter;
                /*0x12*/ bool reinitExit;
                /*0x14*/ uint startSeed;
                /*0x18*/ double begin;
                /*0x20*/ double end;
                /*0x28*/ uint prewarmCount;
                /*0x2c*/ float prewarmDeltaTime;
                /*0x30*/ double prewarmOffset;
                /*0x38*/ int prewarmEvent;
                /*0x40*/ UnityEngine.VFX.VisualEffectControlTrackController.Event[] events;
                /*0x48*/ UnityEngine.VFX.VisualEffectControlTrackController.Clip[] clips;
            }

            class VisualEffectControlPlayableBehaviourComparer : System.Collections.Generic.IComparer<UnityEngine.VFX.VisualEffectControlPlayableBehaviour>
            {
                /*0x7dad2e8*/ VisualEffectControlPlayableBehaviourComparer();
                /*0x7dad480*/ int Compare(UnityEngine.VFX.VisualEffectControlPlayableBehaviour x, UnityEngine.VFX.VisualEffectControlPlayableBehaviour y);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.VisualEffectControlTrackController.<> <>9;
                static /*0x8*/ System.Comparison<System.ValueTuple<UnityEngine.VFX.VisualEffectControlTrackController.Event, int>> <>9__24_1;
                static /*0x10*/ System.Comparison<UnityEngine.VFX.VisualEffectControlTrackController.Event> <>9__24_0;

                static /*0x7dad4b4*/ <>c();
                /*0x7dad51c*/ <>c();
                /*0x7dad524*/ int <Init>b__24_1(System.ValueTuple<UnityEngine.VFX.VisualEffectControlTrackController.Event, int> x, System.ValueTuple<UnityEngine.VFX.VisualEffectControlTrackController.Event, int> y);
                /*0x7dad534*/ int <Init>b__24_0(UnityEngine.VFX.VisualEffectControlTrackController.Event x, UnityEngine.VFX.VisualEffectControlTrackController.Event y);
            }

            class <ComputeRuntimeEvent>d__21 : System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectControlTrackController.Event>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectControlTrackController.Event>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.VFX.VisualEffectControlTrackController.Event <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.VFX.VisualEffectControlPlayableBehaviour behavior;
                /*0x48*/ UnityEngine.VFX.VisualEffectControlPlayableBehaviour <>3__behavior;
                /*0x50*/ UnityEngine.VFX.VisualEffect vfx;
                /*0x58*/ UnityEngine.VFX.VisualEffect <>3__vfx;
                /*0x60*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> <>7__wrap1;

                /*0x7dac0e4*/ <ComputeRuntimeEvent>d__21(int <>1__state);
                /*0x7dad544*/ void System.IDisposable.Dispose();
                /*0x7dad560*/ bool MoveNext();
                /*0x7dad91c*/ void <>m__Finally1();
                /*0x7dad9cc*/ UnityEngine.VFX.VisualEffectControlTrackController.Event System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectControlTrackController.Event>.get_Current();
                /*0x7dad9dc*/ void System.Collections.IEnumerator.Reset();
                /*0x7dada14*/ object System.Collections.IEnumerator.get_Current();
                /*0x7dada74*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectControlTrackController.Event> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectControlTrackController.Event>.GetEnumerator();
                /*0x7dadb28*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class VisualEffectControlTrackMixerBehaviour : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ UnityEngine.VFX.VisualEffectControlTrackController m_ScrubbingCacheHelper;
            /*0x18*/ UnityEngine.VFX.VisualEffect m_Target;
            /*0x20*/ bool m_ReinitWithBinding;
            /*0x21*/ bool m_ReinitWithUnbinding;

            /*0x7dae0b8*/ VisualEffectControlTrackMixerBehaviour();
            /*0x7daabf4*/ void Init(UnityEngine.VFX.VisualEffectControlTrack parentTrack, bool reinitWithBinding, bool reinitWithUnbinding);
            /*0x7dadb2c*/ void ApplyFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data);
            /*0x7dadce0*/ void BindVFX(UnityEngine.VFX.VisualEffect vfx);
            /*0x7dadd94*/ void UnbindVFX();
            /*0x7dade34*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data);
            /*0x7dae028*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data);
            /*0x7dadff0*/ void InvalidateScrubbingHelper();
            /*0x7dae09c*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x7dae0a0*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
        }

        class VFXRuntimeResources : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.ComputeShader m_SDFRayMapCS;
            /*0x20*/ UnityEngine.ComputeShader m_SDFNormalsCS;
            /*0x28*/ UnityEngine.Shader m_SDFRayMapShader;

            static /*0x7dae0f0*/ UnityEngine.VFX.VFXRuntimeResources get_runtimeResources();
            /*0x7dae190*/ VFXRuntimeResources();
            /*0x7dae0c0*/ UnityEngine.ComputeShader get_sdfRayMapCS();
            /*0x7dae0c8*/ void set_sdfRayMapCS(UnityEngine.ComputeShader value);
            /*0x7dae0d0*/ UnityEngine.ComputeShader get_sdfNormalsCS();
            /*0x7dae0d8*/ void set_sdfNormalsCS(UnityEngine.ComputeShader value);
            /*0x7dae0e0*/ UnityEngine.Shader get_sdfRayMapShader();
            /*0x7dae0e8*/ void set_sdfRayMapShader(UnityEngine.Shader value);
        }

        namespace SDF
        {
            class MeshToSDFBaker : System.IDisposable
            {
                static /*0x0*/ uint kMaxRecommandedGridSize;
                static /*0x4*/ uint kMaxAbsoluteGridSize;
                static /*0x8*/ int kNbActualRT;
                /*0x10*/ UnityEngine.RenderTexture[] m_RayMaps;
                /*0x18*/ UnityEngine.RenderTexture[] m_SignMaps;
                /*0x20*/ UnityEngine.RenderTexture[] m_RenderTextureViews;
                /*0x28*/ UnityEngine.GraphicsBuffer m_CounterBuffer;
                /*0x30*/ UnityEngine.GraphicsBuffer m_AccumCounterBuffer;
                /*0x38*/ UnityEngine.GraphicsBuffer m_TrianglesInVoxels;
                /*0x40*/ UnityEngine.GraphicsBuffer m_TrianglesUV;
                /*0x48*/ UnityEngine.GraphicsBuffer m_TmpBuffer;
                /*0x50*/ UnityEngine.GraphicsBuffer m_AccumSumBlocks;
                /*0x58*/ UnityEngine.GraphicsBuffer m_SumBlocksBuffer;
                /*0x60*/ UnityEngine.GraphicsBuffer m_InSumBlocksBuffer;
                /*0x68*/ UnityEngine.GraphicsBuffer m_SumBlocksAdditional;
                /*0x70*/ UnityEngine.GraphicsBuffer m_IndicesBuffer;
                /*0x78*/ UnityEngine.GraphicsBuffer m_VerticesBuffer;
                /*0x80*/ UnityEngine.GraphicsBuffer m_VerticesOutBuffer;
                /*0x88*/ UnityEngine.GraphicsBuffer m_CoordFlipBuffer;
                /*0x90*/ UnityEngine.GraphicsBuffer m_AabbBuffer;
                /*0x98*/ int m_VertexBufferOffset;
                /*0x9c*/ int m_ThreadGroupSize;
                /*0xa0*/ int m_SignPassesCount;
                /*0xa4*/ float m_InOutThreshold;
                /*0xa8*/ UnityEngine.Material[] m_Material;
                /*0xb0*/ UnityEngine.Matrix4x4[] m_WorldToClip;
                /*0xb8*/ UnityEngine.Matrix4x4[] m_ProjMat;
                /*0xc0*/ UnityEngine.Matrix4x4[] m_ViewMat;
                /*0xc8*/ int m_nStepsJFA;
                /*0xd0*/ UnityEngine.VFX.SDF.MeshToSDFBaker.Kernels m_Kernels;
                /*0xd8*/ UnityEngine.Mesh m_Mesh;
                /*0xe0*/ UnityEngine.RenderTexture m_textureVoxel;
                /*0xe8*/ UnityEngine.RenderTexture m_textureVoxelBis;
                /*0xf0*/ UnityEngine.RenderTexture m_DistanceTexture;
                /*0xf8*/ UnityEngine.GraphicsBuffer m_bufferVoxel;
                /*0x100*/ UnityEngine.ComputeShader m_computeShader;
                /*0x108*/ int m_maxResolution;
                /*0x10c*/ float m_MaxExtent;
                /*0x110*/ float m_SdfOffset;
                /*0x114*/ int nTriangles;
                /*0x118*/ UnityEngine.Vector3 m_SizeBox;
                /*0x124*/ UnityEngine.Vector3 m_Center;
                /*0x130*/ UnityEngine.Rendering.CommandBuffer m_Cmd;
                /*0x138*/ bool m_OwnsCommandBuffer;
                /*0x139*/ bool m_IsDisposed;
                /*0x140*/ int[] m_Dimensions;
                /*0x148*/ int[] m_OffsetRayMap;
                /*0x150*/ float[] m_MinBoundsExtended;
                /*0x158*/ float[] m_MaxBoundsExtended;
                /*0x160*/ int m_RayMapUseCounter;
                /*0x168*/ UnityEngine.VFX.VFXRuntimeResources m_RuntimeResources;

                static /*0x7db5bb8*/ MeshToSDFBaker();
                static /*0x7dae1a0*/ UnityEngine.Mesh InitMeshFromList(System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Matrix4x4> transforms);
                /*0x7daee88*/ MeshToSDFBaker(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, UnityEngine.Mesh mesh, int signPassesCount, float threshold, float sdfOffset, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7daf7f8*/ MeshToSDFBaker(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Matrix4x4> transforms, int signPassesCount, float threshold, float sdfOffset, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7dae198*/ UnityEngine.RenderTexture get_SdfTexture();
                /*0x7dae508*/ void InitCommandBuffer();
                /*0x7dae5ac*/ int GetTotalVoxelCount();
                /*0x7dae5f0*/ void InitSizeBox();
                /*0x7daee38*/ UnityEngine.Vector3Int GetGridSize();
                /*0x7daee78*/ UnityEngine.Vector3 GetActualBoxSize();
                /*0x7daf8f4*/ void Finalize();
                /*0x7daf9e4*/ void Reinit(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, UnityEngine.Mesh mesh, int signPassesCount, float threshold, float sdfOffset);
                /*0x7dafa84*/ void Reinit(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Matrix4x4> transforms, int signPassesCount, float threshold, float sdfOffset);
                /*0x7daf14c*/ void SetParameters(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, int signPassesCount, float threshold, float sdfOffset);
                /*0x7daf034*/ void LoadRuntimeResources();
                /*0x7dafb70*/ void InitTextures();
                /*0x7daf1d4*/ void Init();
                /*0x7db07d0*/ void UpdateCameras();
                /*0x7db0b90*/ UnityEngine.Matrix4x4 ComputeOrthographicWorldToClip(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, float width, float height, float near, float far, ref UnityEngine.Matrix4x4 proj, ref UnityEngine.Matrix4x4 view);
                /*0x7db0d40*/ int iDivUp(int a, int b);
                /*0x7db0d54*/ UnityEngine.Vector2Int GetThreadGroupsCount(int nbThreads, int threadCountPerGroup);
                /*0x7db0dc4*/ void PrefixSumCount();
                /*0x7db1748*/ void SurfaceClosing();
                /*0x7db1a00*/ UnityEngine.RenderTexture GetTextureVoxelPrincipal(int step);
                /*0x7db1a18*/ UnityEngine.RenderTexture GetTextureVoxelBis(int step);
                /*0x7db1a30*/ void JFA();
                /*0x7db265c*/ void GenerateRayMap();
                /*0x7db3184*/ UnityEngine.RenderTexture GetRayMapPrincipal(int step);
                /*0x7db31c4*/ UnityEngine.RenderTexture GetRayMapBis(int step);
                /*0x7db19c0*/ UnityEngine.RenderTexture GetSignMapPrincipal(int step);
                /*0x7db320c*/ UnityEngine.RenderTexture GetSignMapBis(int step);
                /*0x7db3254*/ void SignPass();
                /*0x7db39b8*/ void BakeSDF();
                /*0x7db3c60*/ void InitMeshBuffers();
                /*0x7db4bec*/ void FirstDraw();
                /*0x7db50b8*/ void SecondDraw();
                /*0x7db444c*/ void BuildGeometry();
                /*0x7db43d0*/ void InitGeometryBuffers(int upperBoundCount);
                /*0x7db01ac*/ void InitPrefixSumBuffers();
                /*0x7db3e00*/ void ClearRenderTexturesAndBuffers();
                /*0x7db53c4*/ void PerformDistanceTransformWinding();
                /*0x7db5858*/ void ReleaseBuffersAndTextures();
                /*0x7db5b4c*/ void Dispose();
                /*0x7db00e8*/ void CreateGraphicsBufferIfNeeded(ref UnityEngine.GraphicsBuffer gb, int length, int stride);
                /*0x7db5b20*/ void ReleaseGraphicsBuffer(ref UnityEngine.GraphicsBuffer gb);
                /*0x7daff5c*/ void CreateRenderTextureIfNeeded(ref UnityEngine.RenderTexture rt, UnityEngine.RenderTextureDescriptor rtDesc);
                /*0x7db5a38*/ void ReleaseRenderTexture(ref UnityEngine.RenderTexture rt);

                class ShaderProperties
                {
                    static /*0x0*/ int indicesBuffer;
                    static /*0x4*/ int verticesBuffer;
                    static /*0x8*/ int vertexPositionOffset;
                    static /*0xc*/ int vertexStride;
                    static /*0x10*/ int indexStride;
                    static /*0x14*/ int coordFlipBuffer;
                    static /*0x18*/ int verticesOutBuffer;
                    static /*0x1c*/ int aabbBuffer;
                    static /*0x20*/ int worldToClip;
                    static /*0x24*/ int currentAxis;
                    static /*0x28*/ int voxelsBuffer;
                    static /*0x2c*/ int rw_trianglesUV;
                    static /*0x30*/ int trianglesUV;
                    static /*0x34*/ int voxelsTexture;
                    static /*0x38*/ int voxelsTmpTexture;
                    static /*0x3c*/ int rayMap;
                    static /*0x40*/ int rayMapTmp;
                    static /*0x44*/ int rw_rayMapTmp;
                    static /*0x48*/ int nTriangles;
                    static /*0x4c*/ int minBoundsExtended;
                    static /*0x50*/ int maxBoundsExtended;
                    static /*0x54*/ int maxExtent;
                    static /*0x58*/ int upperBoundCount;
                    static /*0x5c*/ int counter;
                    static /*0x60*/ int dimX;
                    static /*0x64*/ int dimY;
                    static /*0x68*/ int dimZ;
                    static /*0x6c*/ int size;
                    static /*0x70*/ int inputBuffer;
                    static /*0x74*/ int inputCounter;
                    static /*0x78*/ int auxBuffer;
                    static /*0x7c*/ int resultBuffer;
                    static /*0x80*/ int numElem;
                    static /*0x84*/ int exclusive;
                    static /*0x88*/ int dispatchWidth;
                    static /*0x8c*/ int src;
                    static /*0x90*/ int dest;
                    static /*0x94*/ int signMap;
                    static /*0x98*/ int threshold;
                    static /*0x9c*/ int signMapTmp;
                    static /*0xa0*/ int normalizeFactor;
                    static /*0xa4*/ int numNeighbours;
                    static /*0xa8*/ int passId;
                    static /*0xac*/ int needNormalize;
                    static /*0xb0*/ int offset;
                    static /*0xb4*/ int offsetRayMap;
                    static /*0xb8*/ int triangleIDs;
                    static /*0xbc*/ int accumCounter;
                    static /*0xc0*/ int distanceTexture;
                    static /*0xc4*/ int sdfOffset;

                    static /*0x7db5c0c*/ ShaderProperties();
                }

                class Kernels
                {
                    /*0x10*/ int inBucketSum;
                    /*0x14*/ int blockSums;
                    /*0x18*/ int finalSum;
                    /*0x1c*/ int toTextureNormalized;
                    /*0x20*/ int copyTextures;
                    /*0x24*/ int jfa;
                    /*0x28*/ int distanceTransform;
                    /*0x2c*/ int copyBuffers;
                    /*0x30*/ int generateRayMapLocal;
                    /*0x34*/ int rayMapScanX;
                    /*0x38*/ int rayMapScanY;
                    /*0x3c*/ int rayMapScanZ;
                    /*0x40*/ int signPass6Rays;
                    /*0x44*/ int signPassNeighbors;
                    /*0x48*/ int toBlockSumBuffer;
                    /*0x4c*/ int clearTexturesAndBuffers;
                    /*0x50*/ int copyToBuffer;
                    /*0x54*/ int generateTrianglesUV;
                    /*0x58*/ int conservativeRasterization;
                    /*0x5c*/ int chooseDirectionTriangleOnly;
                    /*0x60*/ int surfaceClosing;

                    /*0x7db040c*/ Kernels(UnityEngine.ComputeShader computeShader);
                }
            }
        }

        namespace Utility
        {
            class VFXMouseEventBinder : UnityEngine.VFX.Utility.VFXEventBinderBase
            {
                /*0x38*/ UnityEngine.VFX.Utility.VFXMouseEventBinder.Activation activation;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty position;
                /*0x48*/ bool RaycastMousePosition;
                /*0x50*/ UnityEngine.InputSystem.InputAction mouseDown;
                /*0x58*/ UnityEngine.InputSystem.InputAction mouseUp;
                /*0x60*/ UnityEngine.InputSystem.InputAction mouseDragStart;
                /*0x68*/ UnityEngine.InputSystem.InputAction mouseDragStop;
                /*0x70*/ UnityEngine.InputSystem.InputAction mouseEnter;
                /*0x78*/ bool mouseOver;
                /*0x79*/ bool drag;

                static /*0x7db661c*/ UnityEngine.Vector2 GetMousePosition();
                /*0x7db7108*/ VFXMouseEventBinder();
                /*0x7db6500*/ void SetEventAttribute(object[] parameters);
                /*0x7db6698*/ void Awake();
                /*0x7db6944*/ void RaycastMainCamera();
                /*0x7db6ba4*/ void RayCastDrag();
                /*0x7db6c24*/ void RayCastAndTriggerEvent(System.Action trigger);
                /*0x7db6d28*/ void OnEnable();
                /*0x7db6d70*/ void OnDisable();
                /*0x7db6db0*/ void DoOnMouseDown();
                /*0x7db6f08*/ void DoOnMouseUp();
                /*0x7db6fb0*/ void DoOnMouseDrag();
                /*0x7db6a4c*/ void DoOnMouseOver();
                /*0x7db705c*/ void DoOnMouseEnter();
                /*0x7db6af8*/ void DoOnMouseExit();
                /*0x7db71c4*/ void <Awake>b__12_0(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7db7244*/ void <Awake>b__12_1(UnityEngine.InputSystem.InputAction.CallbackContext ctx);

                enum Activation
                {
                    OnMouseUp = 0,
                    OnMouseDown = 1,
                    OnMouseEnter = 2,
                    OnMouseExit = 3,
                    OnMouseOver = 4,
                    OnMouseDrag = 5,
                }
            }

            class VFXRigidBodyCollisionEventBinder : UnityEngine.VFX.Utility.VFXEventBinderBase
            {
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty positionParameter;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty directionParameter;

                /*0x7db7528*/ VFXRigidBodyCollisionEventBinder();
                /*0x7db72c4*/ void SetEventAttribute(object[] parameters);
                /*0x7db73c4*/ void OnCollisionEnter(UnityEngine.Collision collision);
            }

            class VFXTriggerEventBinder : UnityEngine.VFX.Utility.VFXEventBinderBase
            {
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Collider> colliders;
                /*0x40*/ UnityEngine.VFX.Utility.VFXTriggerEventBinder.Activation activation;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty positionParameter;

                /*0x7db793c*/ VFXTriggerEventBinder();
                /*0x7db75b8*/ void SetEventAttribute(object[] parameters);
                /*0x7db7688*/ void OnTriggerEnter(UnityEngine.Collider other);
                /*0x7db776c*/ void OnTriggerExit(UnityEngine.Collider other);
                /*0x7db7854*/ void OnTriggerStay(UnityEngine.Collider other);

                enum Activation
                {
                    OnEnter = 0,
                    OnExit = 1,
                    OnStay = 2,
                }
            }

            class VFXVisibilityEventBinder : UnityEngine.VFX.Utility.VFXEventBinderBase
            {
                /*0x38*/ UnityEngine.VFX.Utility.VFXVisibilityEventBinder.Activation activation;

                /*0x7db7b44*/ VFXVisibilityEventBinder();
                /*0x7db79ec*/ void SetEventAttribute(object[] parameters);
                /*0x7db79f0*/ void OnBecameVisible();
                /*0x7db7a98*/ void OnBecameInvisible();

                enum Activation
                {
                    OnBecameVisible = 0,
                    OnBecameInvisible = 1,
                }
            }

            class VFXEventBinderBase : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.VFX.VisualEffect target;
                /*0x28*/ string EventName;
                /*0x30*/ UnityEngine.VFX.VFXEventAttribute eventAttribute;

                /*0x7db716c*/ VFXEventBinderBase();
                /*0x7db6d6c*/ void OnEnable();
                /*0x7db7be0*/ void OnValidate();
                /*0x7db7b48*/ void UpdateCacheEventAttribute();
                /*0x380d83c*/ void SetEventAttribute(object[] parameters);
                /*0x7db6e5c*/ void SendEventToVisualEffect(object[] parameters);
            }

            class VFXOutputEventAbstractHandler : UnityEngine.MonoBehaviour
            {
                /*0x20*/ bool executeInEditor;
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty outputEvent;
                /*0x30*/ UnityEngine.VFX.VisualEffect <m_VisualEffect>k__BackingField;

                /*0x7db7f40*/ VFXOutputEventAbstractHandler();
                /*0x380b128*/ bool get_canExecuteInEditor();
                /*0x7db7be4*/ void set_m_VisualEffect(UnityEngine.VFX.VisualEffect value);
                /*0x7db7bec*/ UnityEngine.VFX.VisualEffect get_m_VisualEffect();
                /*0x7db7bf4*/ void OnEnable();
                /*0x7db7d58*/ void OnDisable();
                /*0x7db7e88*/ void OnOutputEventRecieved(UnityEngine.VFX.VFXOutputEventArgs args);
                /*0x380d83c*/ void OnVFXOutputEvent(UnityEngine.VFX.VFXEventAttribute eventAttribute);
            }

            class ExposedProperty
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Id;

                static /*0x7da6cb8*/ UnityEngine.VFX.Utility.ExposedProperty op_Implicit(string name);
                static /*0x7db7fe4*/ string op_Explicit(UnityEngine.VFX.Utility.ExposedProperty parameter);
                static /*0x7dad2f0*/ int op_Implicit(UnityEngine.VFX.Utility.ExposedProperty parameter);
                static /*0x7db7ffc*/ UnityEngine.VFX.Utility.ExposedProperty op_Addition(UnityEngine.VFX.Utility.ExposedProperty self, UnityEngine.VFX.Utility.ExposedProperty other);
                /*0x7db8094*/ ExposedProperty();
                /*0x7db7fa8*/ ExposedProperty(string name);
                /*0x7db80b4*/ string ToString();
            }

            class VFXAudioSpectrumBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_CountProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_TextureProperty;
                /*0x38*/ UnityEngine.FFTWindow FFTWindow;
                /*0x3c*/ uint Samples;
                /*0x40*/ UnityEngine.VFX.Utility.VFXAudioSpectrumBinder.AudioSourceMode Mode;
                /*0x48*/ UnityEngine.AudioSource AudioSource;
                /*0x50*/ UnityEngine.Texture2D m_Texture;
                /*0x58*/ float[] m_AudioCache;
                /*0x60*/ UnityEngine.Color[] m_ColorCache;

                /*0x7db8584*/ VFXAudioSpectrumBinder();
                /*0x7db80bc*/ string get_CountProperty();
                /*0x7db80d8*/ void set_CountProperty(string value);
                /*0x7db80fc*/ string get_TextureProperty();
                /*0x7db8118*/ void set_TextureProperty(string value);
                /*0x7db813c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7db81fc*/ void UpdateTexture();
                /*0x7db849c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7db84f8*/ string ToString();

                enum AudioSourceMode
                {
                    AudioSource = 0,
                    AudioListener = 1,
                }
            }

            class VFXEnabledBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.VFXEnabledBinder.Check check;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.GameObject Target;

                /*0x7db8870*/ VFXEnabledBinder();
                /*0x7db8624*/ string get_Property();
                /*0x7db8640*/ void set_Property(string value);
                /*0x7db8664*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7db8708*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7db8774*/ string ToString();

                enum Check
                {
                    ActiveInHierarchy = 0,
                    ActiveSelf = 1,
                }
            }

            class VFXHierarchyAttributeMapBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_BoneCount;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_PositionMap;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty m_TargetPositionMap;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty m_RadiusPositionMap;
                /*0x48*/ UnityEngine.Transform HierarchyRoot;
                /*0x50*/ float DefaultRadius;
                /*0x54*/ uint MaximumDepth;
                /*0x58*/ UnityEngine.VFX.Utility.VFXHierarchyAttributeMapBinder.RadiusMode Radius;
                /*0x60*/ UnityEngine.Texture2D position;
                /*0x68*/ UnityEngine.Texture2D targetPosition;
                /*0x70*/ UnityEngine.Texture2D radius;
                /*0x78*/ System.Collections.Generic.List<UnityEngine.VFX.Utility.VFXHierarchyAttributeMapBinder.Bone> bones;

                /*0x7db951c*/ VFXHierarchyAttributeMapBinder();
                /*0x7db88d0*/ void OnEnable();
                /*0x7db8a20*/ void OnValidate();
                /*0x7db88ec*/ void UpdateHierarchy();
                /*0x7db8a24*/ System.Collections.Generic.List<UnityEngine.VFX.Utility.VFXHierarchyAttributeMapBinder.Bone> ChildrenOf(UnityEngine.Transform source, uint depth);
                /*0x7db8ee0*/ void UpdateData();
                /*0x7db92a4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7db939c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7db945c*/ string ToString();

                enum RadiusMode
                {
                    Fixed = 0,
                    Interpolate = 1,
                }

                struct Bone
                {
                    /*0x10*/ UnityEngine.Transform source;
                    /*0x18*/ float sourceRadius;
                    /*0x20*/ UnityEngine.Transform target;
                    /*0x28*/ float targetRadius;
                }
            }

            class VFXInputAxisBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_AxisProperty;
                /*0x30*/ string AxisName;
                /*0x38*/ float AccumulateSpeed;
                /*0x3c*/ bool Accumulate;

                /*0x7db9700*/ VFXInputAxisBinder();
                /*0x7db9620*/ string get_AxisProperty();
                /*0x7db963c*/ void set_AxisProperty(string value);
                /*0x7db9660*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7db968c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7db9690*/ string ToString();
            }

            class VFXInputButtonBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_ButtonProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_ButtonSmoothProperty;
                /*0x38*/ string ButtonName;
                /*0x40*/ float SmoothSpeed;
                /*0x44*/ bool UseButtonSmooth;

                /*0x7db9908*/ VFXInputButtonBinder();
                /*0x7db979c*/ string get_ButtonProperty();
                /*0x7db97b8*/ void set_ButtonProperty(string value);
                /*0x7db97dc*/ string get_ButtonSmoothProperty();
                /*0x7db97f8*/ void set_ButtonSmoothProperty(string value);
                /*0x7db981c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7db9890*/ void Start();
                /*0x7db9894*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7db9898*/ string ToString();
            }

            class VFXInputKeyBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_KeyProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_KeySmoothProperty;
                /*0x38*/ UnityEngine.KeyCode Key;
                /*0x3c*/ float SmoothSpeed;
                /*0x40*/ bool UseKeySmooth;

                /*0x7db9b6c*/ VFXInputKeyBinder();
                /*0x7db99d0*/ string get_KeyProperty();
                /*0x7db99ec*/ void set_KeyProperty(string value);
                /*0x7db9a10*/ string get_KeySmoothProperty();
                /*0x7db9a2c*/ void set_KeySmoothProperty(string value);
                /*0x7db9a50*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7db9ac4*/ void Start();
                /*0x7db9ac8*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7db9acc*/ string ToString();
            }

            class VFXInputMouseBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_MouseLeftClickProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_MouseRightClickProperty;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty m_PositionProperty;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty m_VelocityProperty;
                /*0x48*/ UnityEngine.Camera Target;
                /*0x50*/ float Distance;
                /*0x54*/ bool SetVelocity;
                /*0x55*/ bool CheckLeftClick;
                /*0x56*/ bool CheckRightClick;
                /*0x58*/ UnityEngine.Vector3 m_PreviousPosition;

                /*0x7dba1a0*/ VFXInputMouseBinder();
                /*0x7db9c14*/ string get_MouseLeftClickProperty();
                /*0x7db9c30*/ void set_MouseLeftClickProperty(string value);
                /*0x7db9c54*/ string get_MouseRightClickProperty();
                /*0x7db9c70*/ void set_MouseRightClickProperty(string value);
                /*0x7db9c94*/ string get_PositionProperty();
                /*0x7db9cb0*/ void set_PositionProperty(string value);
                /*0x7db9cd4*/ string get_VelocityProperty();
                /*0x7db9cf0*/ void set_VelocityProperty(string value);
                /*0x7db9d14*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7db9dd0*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7db9ff8*/ bool IsRightClickPressed();
                /*0x7db9f98*/ bool IsLeftClickPressed();
                /*0x7dba058*/ UnityEngine.Vector2 GetMousePosition();
                /*0x7dba0d4*/ string ToString();
            }

            class VFXInputTouchBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_TouchEnabledProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Parameter;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty m_VelocityParameter;
                /*0x40*/ int TouchIndex;
                /*0x48*/ UnityEngine.Camera Target;
                /*0x50*/ float Distance;
                /*0x54*/ bool SetVelocity;
                /*0x58*/ UnityEngine.Vector3 m_PreviousPosition;
                /*0x64*/ bool m_PreviousTouch;

                /*0x7dbab44*/ VFXInputTouchBinder();
                /*0x7dba2a4*/ string get_TouchEnabledProperty();
                /*0x7dba2c0*/ void set_TouchEnabledProperty(string value);
                /*0x7dba2e4*/ string get_Parameter();
                /*0x7dba300*/ void set_Parameter(string value);
                /*0x7dba324*/ string get_VelocityParameter();
                /*0x7dba340*/ void set_VelocityParameter(string value);
                /*0x7dba364*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dba450*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dba65c*/ int GetTouchCount();
                /*0x7dba848*/ UnityEngine.Vector2 GetTouchPosition(int touchIndex);
                /*0x7dbaa50*/ string ToString();

                class <>c
                {
                    static /*0x0*/ UnityEngine.VFX.Utility.VFXInputTouchBinder.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Controls.TouchControl, bool> <>9__20_0;

                    static /*0x7dbac0c*/ <>c();
                    /*0x7dbac74*/ <>c();
                    /*0x7dbac7c*/ bool <GetTouchCount>b__20_0(UnityEngine.InputSystem.Controls.TouchControl t);
                }
            }

            class VFXLightBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_ColorProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_BrightnessProperty;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty m_RadiusProperty;
                /*0x40*/ UnityEngine.Light Target;
                /*0x48*/ bool BindColor;
                /*0x49*/ bool BindBrightness;
                /*0x4a*/ bool BindRadius;

                /*0x7dbafec*/ VFXLightBinder();
                /*0x7dbac8c*/ string get_ColorProperty();
                /*0x7dbaca8*/ void set_ColorProperty(string value);
                /*0x7dbaccc*/ string get_BrightnessProperty();
                /*0x7dbace8*/ void set_BrightnessProperty(string value);
                /*0x7dbad0c*/ string get_RadiusProperty();
                /*0x7dbad28*/ void set_RadiusProperty(string value);
                /*0x7dbad4c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbae50*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbaf20*/ string ToString();
            }

            class VFXMultiplePositionBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty PositionMapProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty PositionCountProperty;
                /*0x38*/ UnityEngine.GameObject[] Targets;
                /*0x40*/ bool EveryFrame;
                /*0x48*/ UnityEngine.Texture2D positionMap;
                /*0x50*/ int count;

                /*0x7dbb8b0*/ VFXMultiplePositionBinder();
                /*0x7dbb11c*/ void OnEnable();
                /*0x7dbb710*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbb784*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbb224*/ void UpdateTexture();
                /*0x7dbb838*/ string ToString();
            }

            class VFXPlaneBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty Position;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty Normal;

                /*0x7dbbe10*/ VFXPlaneBinder();
                /*0x7dbb954*/ string get_Property();
                /*0x7dbb970*/ void set_Property(string value);
                /*0x7dbba58*/ void OnEnable();
                /*0x7dbba70*/ void OnValidate();
                /*0x7dbb9a0*/ void UpdateSubProperties();
                /*0x7dbba74*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbbb3c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbbd48*/ string ToString();
            }

            class VFXPositionBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;

                /*0x7dbc170*/ VFXPositionBinder();
                /*0x7dbbe7c*/ string get_Property();
                /*0x7dbbe98*/ void set_Property(string value);
                /*0x7dbbec0*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbbf68*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbc0a8*/ string ToString();
            }

            class VFXPreviousPositionBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ UnityEngine.Vector3 oldPosition;

                /*0x7dbc480*/ VFXPreviousPositionBinder();
                /*0x7dbc1d4*/ void OnEnable();
                /*0x7dbc29c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbc344*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbc3b8*/ string ToString();
            }

            class VFXRaycastBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_TargetPosition;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_TargetNormal;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty m_TargetHit;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty m_TargetPosition_position;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty m_TargetNormal_direction;
                /*0x50*/ UnityEngine.GameObject RaycastSource;
                /*0x58*/ UnityEngine.Vector3 RaycastDirection;
                /*0x64*/ UnityEngine.VFX.Utility.VFXRaycastBinder.Space RaycastDirectionSpace;
                /*0x68*/ UnityEngine.LayerMask Layers;
                /*0x6c*/ float MaxDistance;
                /*0x70*/ UnityEngine.RaycastHit m_HitInfo;

                /*0x7dbcb80*/ VFXRaycastBinder();
                /*0x7dbc4e4*/ string get_TargetPosition();
                /*0x7dbc500*/ void set_TargetPosition(string value);
                /*0x7dbc5e8*/ string get_TargetNormal();
                /*0x7dbc604*/ void set_TargetNormal(string value);
                /*0x7dbc634*/ string get_TargetHit();
                /*0x7dbc650*/ void set_TargetHit(string value);
                /*0x7dbc678*/ void OnEnable();
                /*0x7dbc690*/ void OnValidate();
                /*0x7dbc530*/ void UpdateSubProperties();
                /*0x7dbc694*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbc770*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbc9cc*/ string ToString();

                enum Space
                {
                    Local = 0,
                    World = 1,
                }
            }

            class VFXSpaceableBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.VFXSpaceableBinder.BinderSpace Space;

                /*0x7dbbe74*/ VFXSpaceableBinder();
                /*0x7dbcca0*/ UnityEngine.VFX.VFXSpace GetTargetSpace(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty);
                /*0x7dbbbec*/ void ApplySpacePositionNormal(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Transform sourceTransform, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 normal);
                /*0x7dbcd1c*/ void ApplySpaceTS(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Transform sourceTransform, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 scale);
                /*0x7dbce40*/ void ApplySpaceTRS(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Transform sourceTransform, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 eulerAngles, ref UnityEngine.Vector3 scale);
                /*0x7dbbffc*/ UnityEngine.Vector3 ApplySpacePosition(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Vector3 sourceWorldPosition);

                enum BinderSpace
                {
                    Automatic = 0,
                    World = 1,
                    Local = 2,
                }
            }

            class VFXSphereBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.SphereCollider Target;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty m_Old_Center;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty m_New_Center;
                /*0x50*/ UnityEngine.VFX.Utility.ExposedProperty m_Radius;

                /*0x7dbd428*/ VFXSphereBinder();
                /*0x7dbcfbc*/ string get_Property();
                /*0x7dbcfd8*/ void set_Property(string value);
                /*0x7dbd104*/ void OnEnable();
                /*0x7dbd11c*/ void OnValidate();
                /*0x7dbd008*/ void UpdateSubProperties();
                /*0x7dbd120*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbd208*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbd34c*/ float GetSphereColliderScale(UnityEngine.Vector3 scale);
                /*0x7dbd360*/ string ToString();
            }

            class VFXTerrainBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.Terrain Terrain;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_Bounds_center;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_Bounds_size;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_HeightMap;
                /*0x50*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_Height;

                /*0x7dbd954*/ VFXTerrainBinder();
                /*0x7dbd48c*/ string get_Property();
                /*0x7dbd4a8*/ void set_Property(string value);
                /*0x7dbd620*/ void OnEnable();
                /*0x7dbd638*/ void OnValidate();
                /*0x7dbd4d8*/ void UpdateSubProperties();
                /*0x7dbd63c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbd744*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbd88c*/ string ToString();
            }

            class VFXTransformBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty Position;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty Angles;
                /*0x50*/ UnityEngine.VFX.Utility.ExposedProperty Scale;

                /*0x7dbdd8c*/ VFXTransformBinder();
                /*0x7dbd9b8*/ string get_Property();
                /*0x7dbd9d4*/ void set_Property(string value);
                /*0x7dbdb00*/ void OnEnable();
                /*0x7dbdb18*/ void OnValidate();
                /*0x7dbda04*/ void UpdateSubProperties();
                /*0x7dbdb1c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbdc04*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbdcc4*/ string ToString();
            }

            class VFXUIDropdownBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.UI.Dropdown Target;

                /*0x7dbdfec*/ VFXUIDropdownBinder();
                /*0x7dbddf0*/ string get_Property();
                /*0x7dbde0c*/ void set_Property(string value);
                /*0x7dbde34*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbdedc*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbdf24*/ string ToString();
            }

            class VFXUISliderBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.UI.Slider Target;

                /*0x7dbe260*/ VFXUISliderBinder();
                /*0x7dbe050*/ string get_Property();
                /*0x7dbe06c*/ void set_Property(string value);
                /*0x7dbe094*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbe13c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbe198*/ string ToString();
            }

            class VFXUIToggleBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.UI.Toggle Target;

                /*0x7dbe4c0*/ VFXUIToggleBinder();
                /*0x7dbe2c4*/ string get_Property();
                /*0x7dbe2e0*/ void set_Property(string value);
                /*0x7dbe308*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbe3b0*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbe3f8*/ string ToString();
            }

            class VFXVelocityBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                static /*0x0*/ float invalidPreviousTime;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ float m_PreviousTime;
                /*0x44*/ UnityEngine.Vector3 m_PreviousPosition;

                static /*0x7dbe9c4*/ VFXVelocityBinder();
                /*0x7dbe8e4*/ VFXVelocityBinder();
                /*0x7dbe524*/ string get_Property();
                /*0x7dbe540*/ void set_Property(string value);
                /*0x7dbe568*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbe610*/ void Reset();
                /*0x7dbe670*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbe81c*/ string ToString();
            }

            class VFXBinderAttribute : UnityEngine.PropertyAttribute
            {
                /*0x18*/ string MenuPath;

                /*0x7dbea10*/ VFXBinderAttribute(string menuPath);
            }

            class VFXBinderBase : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.VFX.Utility.VFXPropertyBinder binder;

                /*0x7dbb94c*/ VFXBinderBase();
                /*0x380b2f0*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dbea40*/ void Reset();
                /*0x7dbea44*/ void Awake();
                /*0x7dbb134*/ void OnEnable();
                /*0x7dbea9c*/ void OnDisable();
                /*0x380d83c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dbeb38*/ string ToString();
            }

            class VFXPropertyBinder : UnityEngine.MonoBehaviour
            {
                /*0x20*/ bool m_ExecuteInEditor;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.VFX.Utility.VFXBinderBase> m_Bindings;
                /*0x30*/ UnityEngine.VFX.VisualEffect m_VisualEffect;

                static /*0x7dbec70*/ void SafeDestroy(UnityEngine.Object toDelete);
                /*0x7dbf024*/ VFXPropertyBinder();
                /*0x7dbeb5c*/ void OnEnable();
                /*0x7dbec6c*/ void OnValidate();
                /*0x7dbeb60*/ void Reload();
                /*0x7dbecc8*/ void Reset();
                /*0x7dbed74*/ void LateUpdate();
                /*0x3907c14*/ T AddPropertyBinder<T>();
                /*0x3907c14*/ T AddParameterBinder<T>();
                /*0x7dbece0*/ void ClearPropertyBinders();
                /*0x7dbef6c*/ void ClearParameterBinders();
                /*0x7dbef70*/ void RemovePropertyBinder(UnityEngine.VFX.Utility.VFXBinderBase binder);
                /*0x7dbf020*/ void RemoveParameterBinder(UnityEngine.VFX.Utility.VFXBinderBase binder);
                /*0x380cb08*/ void RemovePropertyBinders<T>();
                /*0x380cb08*/ void RemoveParameterBinders<T>();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<T> GetPropertyBinders<T>();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<T> GetParameterBinders<T>();

                class <GetPropertyBinders>d__17<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ UnityEngine.VFX.Utility.VFXPropertyBinder <>4__this;
                    /*0x0*/ System.Collections.Generic.List.Enumerator<UnityEngine.VFX.Utility.VFXBinderBase> <>7__wrap1;

                    /*0x380cffc*/ <GetPropertyBinders>d__17(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void <>m__Finally1();
                    /*0x3907c14*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class VFXPropertyBindingAttribute : UnityEngine.PropertyAttribute
            {
                /*0x18*/ string[] EditorTypes;

                /*0x7dbf0b4*/ VFXPropertyBindingAttribute(string[] editorTypes);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1FCB71F4BF8F5DE5655527535EC46F32895D95B547568A065A6333AC652D6BFC;
    static /*0x1895*/ <PrivateImplementationDetails> EBB49FC4B9DF9593EFE6354EC463D0B2B218C84ECF16B55C0960D1B15632F5A6;

    struct __StaticArrayInitTypeSize=3566
    {
    }

    struct __StaticArrayInitTypeSize=6293
    {
    }
}
