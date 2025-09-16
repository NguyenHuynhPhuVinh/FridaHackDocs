class <Module>
{
}

class VisualEffectActivationBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    /*0x10*/ UnityEngine.VFX.Utility.ExposedProperty onClipEnter;
    /*0x18*/ UnityEngine.VFX.Utility.ExposedProperty onClipExit;
    /*0x20*/ VisualEffectActivationBehaviour.EventState[] clipEnterEventAttributes;
    /*0x28*/ VisualEffectActivationBehaviour.EventState[] clipExitEventAttributes;

    /*0x7dbe054*/ VisualEffectActivationBehaviour();

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

    /*0x7dbe24c*/ VisualEffectActivationClip();
    /*0x7dbe158*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
    /*0x7dbe160*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7dbe2b4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7dbe3a8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            static /*0x7dbe4c4*/ IncrementStripIndexOnStart();
            /*0x7dbe4bc*/ IncrementStripIndexOnStart();
            /*0x7dbe3b0*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbe4b0*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbe4b8*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);

            class InputProperties
            {
                /*0x10*/ uint StripMaxCount;

                /*0x7dbe560*/ InputProperties();
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

            static /*0x7dbe7b0*/ LoopAndDelay();
            /*0x7dbe7a8*/ LoopAndDelay();
            /*0x7dbe570*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbe63c*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbe79c*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);

            class InputProperties
            {
                /*0x10*/ int LoopCount;
                /*0x14*/ float LoopDuration;
                /*0x18*/ float Delay;

                /*0x7dbe878*/ InputProperties();
            }
        }

        class SetSpawnTime : UnityEngine.VFX.VFXSpawnerCallbacks
        {
            static /*0x0*/ int spawnTimeID;

            static /*0x7dbe938*/ SetSpawnTime();
            /*0x7dbe930*/ SetSpawnTime();
            /*0x7dbe894*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbe898*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbe92c*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
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

            static /*0x7dbec94*/ SpawnOverDistance();
            /*0x7dbec8c*/ SpawnOverDistance();
            /*0x7dbe9a0*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbea24*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x7dbec88*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);

            class InputProperties
            {
                /*0x10*/ UnityEngine.Vector3 Position;
                /*0x1c*/ float RatePerUnit;
                /*0x20*/ float VelocityThreshold;
                /*0x24*/ bool ClampToOne;

                /*0x7dbedf0*/ InputProperties();
            }
        }

        class VFXTypeAttribute : System.Attribute
        {
            /*0x10*/ UnityEngine.VFX.VFXTypeAttribute.Usage <usages>k__BackingField;
            /*0x18*/ string <name>k__BackingField;

            /*0x7dbee5c*/ VFXTypeAttribute(UnityEngine.VFX.VFXTypeAttribute.Usage usages, string name);
            /*0x7dbee94*/ UnityEngine.VFX.VFXTypeAttribute.Usage get_usages();
            /*0x7dbee9c*/ void set_usages(UnityEngine.VFX.VFXTypeAttribute.Usage value);
            /*0x7dbeea4*/ string get_name();
            /*0x7dbeeac*/ void set_name(string value);

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

            /*0x7dbf718*/ VisualEffectControlClip();
            /*0x7dbeeb4*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7dbeebc*/ double get_clipStart();
            /*0x7dbeec4*/ void set_clipStart(double value);
            /*0x7dbeecc*/ double get_clipEnd();
            /*0x7dbeed4*/ void set_clipEnd(double value);
            /*0x7dbeedc*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);

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

                static /*0x7dbfb44*/ ClipEvent();
            }
        }

        struct EventAttributes
        {
            /*0x10*/ UnityEngine.VFX.EventAttribute[] content;
        }

        class EventAttribute
        {
            /*0x10*/ UnityEngine.VFX.Utility.ExposedProperty id;

            /*0x7dbfb94*/ EventAttribute();
            /*0x38141c4*/ bool ApplyToVFX(UnityEngine.VFX.VFXEventAttribute eventAttribute);
        }

        class EventAttributeValue<T> : UnityEngine.VFX.EventAttribute
        {
            /*0x0*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> m_HasFunc;
            /*0x0*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, T> m_ApplyFunc;
            /*0x0*/ T value;

            /*0x3816810*/ EventAttributeValue(System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> hasFunc, System.Action<UnityEngine.VFX.VFXEventAttribute, int, T> applyFunc);
            /*0x38141c4*/ bool ApplyToVFX(UnityEngine.VFX.VFXEventAttribute eventAttribute);
        }

        class EventAttributeFloat : UnityEngine.VFX.EventAttributeValue<float>
        {
            /*0x7dbfb9c*/ EventAttributeFloat();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeFloat.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, float> <>9__0_1;

                static /*0x7dbfd30*/ <>c();
                /*0x7dbfd98*/ <>c();
                /*0x7dbfda0*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7dbfdbc*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, float value);
            }
        }

        class EventAttributeVector2 : UnityEngine.VFX.EventAttributeValue<UnityEngine.Vector2>
        {
            /*0x7dbfdd8*/ EventAttributeVector2();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeVector2.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, UnityEngine.Vector2> <>9__0_1;

                static /*0x7dbff6c*/ <>c();
                /*0x7dbffd4*/ <>c();
                /*0x7dbffdc*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7dbfff8*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, UnityEngine.Vector2 value);
            }
        }

        class EventAttributeVector3 : UnityEngine.VFX.EventAttributeValue<UnityEngine.Vector3>
        {
            /*0x7dc0014*/ EventAttributeVector3();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeVector3.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, UnityEngine.Vector3> <>9__0_1;

                static /*0x7dc01a8*/ <>c();
                /*0x7dc0210*/ <>c();
                /*0x7dc0218*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7dc0234*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, UnityEngine.Vector3 value);
            }
        }

        class EventAttributeColor : UnityEngine.VFX.EventAttributeVector3
        {
            /*0x7dc0250*/ EventAttributeColor();
        }

        class EventAttributeVector4 : UnityEngine.VFX.EventAttributeValue<UnityEngine.Vector4>
        {
            /*0x7dc0254*/ EventAttributeVector4();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeVector4.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, UnityEngine.Vector4> <>9__0_1;

                static /*0x7dc03e8*/ <>c();
                /*0x7dc0450*/ <>c();
                /*0x7dc0458*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7dc0474*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, UnityEngine.Vector4 value);
            }
        }

        class EventAttributeInt : UnityEngine.VFX.EventAttributeValue<int>
        {
            /*0x7dc0490*/ EventAttributeInt();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeInt.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, int> <>9__0_1;

                static /*0x7dc0624*/ <>c();
                /*0x7dc068c*/ <>c();
                /*0x7dc0694*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7dc06b0*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, int value);
            }
        }

        class EventAttributeUInt : UnityEngine.VFX.EventAttributeValue<uint>
        {
            /*0x7dc06d0*/ EventAttributeUInt();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeUInt.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, uint> <>9__0_1;

                static /*0x7dc0864*/ <>c();
                /*0x7dc08cc*/ <>c();
                /*0x7dc08d4*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7dc08f0*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, uint value);
            }
        }

        class EventAttributeBool : UnityEngine.VFX.EventAttributeValue<bool>
        {
            /*0x7dc0910*/ EventAttributeBool();

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.EventAttributeBool.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_0;
                static /*0x10*/ System.Action<UnityEngine.VFX.VFXEventAttribute, int, bool> <>9__0_1;

                static /*0x7dc0aa4*/ <>c();
                /*0x7dc0b0c*/ <>c();
                /*0x7dc0b14*/ bool <.ctor>b__0_0(UnityEngine.VFX.VFXEventAttribute e, int id);
                /*0x7dc0b30*/ void <.ctor>b__0_1(UnityEngine.VFX.VFXEventAttribute e, int id, bool value);
            }
        }

        class VFXTimeSpaceHelper
        {
            static /*0x7dc0b54*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(UnityEngine.VFX.PlayableTimeSpace space, UnityEngine.VFX.VisualEffectControlPlayableBehaviour source);
            static /*0x7dc0c18*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> CollectClipEvents(UnityEngine.VFX.VisualEffectControlClip source);
            static /*0x7dc0cc8*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(UnityEngine.VFX.PlayableTimeSpace space, UnityEngine.VFX.VisualEffectControlClip source, bool clipEvents);
            static /*0x7dc0b74*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> GetEventNormalizedSpace(UnityEngine.VFX.PlayableTimeSpace space, System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> events, double clipStart, double clipEnd);
            static /*0x7dc0d44*/ double GetTimeInSpace(UnityEngine.VFX.PlayableTimeSpace srcSpace, double srcTime, UnityEngine.VFX.PlayableTimeSpace dstSpace, double clipStart, double clipEnd);

            class <CollectClipEvents>d__1 : System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent <>2__current;
                /*0x48*/ int <>l__initialThreadId;
                /*0x50*/ UnityEngine.VFX.VisualEffectControlClip source;
                /*0x58*/ UnityEngine.VFX.VisualEffectControlClip <>3__source;
                /*0x60*/ System.Collections.Generic.List.Enumerator<UnityEngine.VFX.VisualEffectControlClip.ClipEvent> <>7__wrap1;
                /*0xc0*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent <eventExit>5__3;

                /*0x7dc0c94*/ <CollectClipEvents>d__1(int <>1__state);
                /*0x7dc0f18*/ void System.IDisposable.Dispose();
                /*0x7dc0f44*/ bool MoveNext();
                /*0x7dc1290*/ void <>m__Finally1();
                /*0x7dc12e0*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.get_Current();
                /*0x7dc12f8*/ void System.Collections.IEnumerator.Reset();
                /*0x7dc1330*/ object System.Collections.IEnumerator.get_Current();
                /*0x7dc1398*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.GetEnumerator();
                /*0x7dc143c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                /*0x7dc0d10*/ <GetEventNormalizedSpace>d__3(int <>1__state);
                /*0x7dc1440*/ void System.IDisposable.Dispose();
                /*0x7dc145c*/ bool MoveNext();
                /*0x7dc179c*/ void <>m__Finally1();
                /*0x7dc184c*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.get_Current();
                /*0x7dc1864*/ void System.Collections.IEnumerator.Reset();
                /*0x7dc189c*/ object System.Collections.IEnumerator.get_Current();
                /*0x7dc1904*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectPlayableSerializedEvent> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectPlayableSerializedEvent>.GetEnumerator();
                /*0x7dc19c0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7dbf6a0*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent op_Implicit(UnityEngine.VFX.VisualEffectPlayableSerializedEventNoColor evt);
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

            /*0x7dc1a80*/ VisualEffectControlPlayableBehaviour();
            /*0x7dc19c4*/ double get_clipStart();
            /*0x7dc19cc*/ void set_clipStart(double value);
            /*0x7dc19d4*/ double get_clipEnd();
            /*0x7dc19dc*/ void set_clipEnd(double value);
            /*0x7dc19e4*/ bool get_scrubbing();
            /*0x7dc19ec*/ void set_scrubbing(bool value);
            /*0x7dc19f8*/ bool get_reinitEnter();
            /*0x7dc1a00*/ void set_reinitEnter(bool value);
            /*0x7dc1a0c*/ bool get_reinitExit();
            /*0x7dc1a14*/ void set_reinitExit(bool value);
            /*0x7dc1a20*/ uint get_startSeed();
            /*0x7dc1a28*/ void set_startSeed(uint value);
            /*0x7dc1a30*/ UnityEngine.VFX.VisualEffectPlayableSerializedEvent[] get_events();
            /*0x7dc1a38*/ void set_events(UnityEngine.VFX.VisualEffectPlayableSerializedEvent[] value);
            /*0x7dc1a40*/ uint get_clipEventsCount();
            /*0x7dc1a48*/ void set_clipEventsCount(uint value);
            /*0x7dc1a50*/ uint get_prewarmStepCount();
            /*0x7dc1a58*/ void set_prewarmStepCount(uint value);
            /*0x7dc1a60*/ float get_prewarmDeltaTime();
            /*0x7dc1a68*/ void set_prewarmDeltaTime(float value);
            /*0x7dc1a70*/ UnityEngine.VFX.Utility.ExposedProperty get_prewarmEvent();
            /*0x7dc1a78*/ void set_prewarmEvent(UnityEngine.VFX.Utility.ExposedProperty value);
        }

        class VisualEffectControlTrack : UnityEngine.Timeline.TrackAsset
        {
            static int kCurrentVersion = 1;
            /*0xa0*/ int m_VFXVersion;
            /*0xa4*/ UnityEngine.VFX.VisualEffectControlTrack.ReinitMode reinit;

            /*0x7dc20f0*/ VisualEffectControlTrack();
            /*0x7dc1a88*/ bool IsUpToDate();
            /*0x7dc1a98*/ void OnBeforeTrackSerialize();
            /*0x7dc1bcc*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x7dc2038*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);

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

                static /*0x7dc2150*/ <>c();
                /*0x7dc21b8*/ <>c();
                /*0x7dc21c0*/ bool <OnBeforeTrackSerialize>b__5_0(UnityEngine.Timeline.TimelineClip x);
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

            static /*0x7dc4858*/ VisualEffectControlTrackController();
            static /*0x7dc3234*/ void GetEventsIndex(UnityEngine.VFX.VisualEffectControlTrackController.Chunk chunk, double minTime, double maxTime, int lastIndex, System.Collections.Generic.List<int> eventListIndex);
            static /*0x7dc33c0*/ UnityEngine.VFX.VFXEventAttribute ComputeAttribute(UnityEngine.VFX.VisualEffect vfx, UnityEngine.VFX.EventAttributes attributes);
            static /*0x7dc347c*/ System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectControlTrackController.Event> ComputeRuntimeEvent(UnityEngine.VFX.VisualEffectControlPlayableBehaviour behavior, UnityEngine.VFX.VisualEffect vfx);
            /*0x7dc47c0*/ VisualEffectControlTrackController();
            /*0x7dc2244*/ void OnEnterChunk(int currentChunk);
            /*0x7dc2324*/ void OnLeaveChunk(int previousChunkIndex, bool leavingGoingBeforeClip);
            /*0x7dc28c0*/ bool IsTimeInChunk(double time, int index);
            /*0x7dc2908*/ void Update(double playableTime, float deltaTime);
            /*0x7dc24cc*/ void ProcessNoScrubbingEvents(UnityEngine.VFX.VisualEffectControlTrackController.Chunk chunk, double oldTime, double newTime);
            /*0x7dc3364*/ void ProcessEvent(int eventIndex, UnityEngine.VFX.VisualEffectControlTrackController.Chunk currentChunk);
            /*0x7dc27f4*/ void RestoreVFXState(bool restorePause, bool restoreSeedState);
            /*0x7dc3548*/ void Init(UnityEngine.Playables.Playable playable, UnityEngine.VFX.VisualEffect vfx, UnityEngine.VFX.VisualEffectControlTrack parentTrack);
            /*0x7dc47b4*/ void Release();

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
                /*0x7dc4718*/ VisualEffectControlPlayableBehaviourComparer();
                /*0x7dc48b0*/ int Compare(UnityEngine.VFX.VisualEffectControlPlayableBehaviour x, UnityEngine.VFX.VisualEffectControlPlayableBehaviour y);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.VFX.VisualEffectControlTrackController.<> <>9;
                static /*0x8*/ System.Comparison<System.ValueTuple<UnityEngine.VFX.VisualEffectControlTrackController.Event, int>> <>9__24_1;
                static /*0x10*/ System.Comparison<UnityEngine.VFX.VisualEffectControlTrackController.Event> <>9__24_0;

                static /*0x7dc48e4*/ <>c();
                /*0x7dc494c*/ <>c();
                /*0x7dc4954*/ int <Init>b__24_1(System.ValueTuple<UnityEngine.VFX.VisualEffectControlTrackController.Event, int> x, System.ValueTuple<UnityEngine.VFX.VisualEffectControlTrackController.Event, int> y);
                /*0x7dc4964*/ int <Init>b__24_0(UnityEngine.VFX.VisualEffectControlTrackController.Event x, UnityEngine.VFX.VisualEffectControlTrackController.Event y);
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

                /*0x7dc3514*/ <ComputeRuntimeEvent>d__21(int <>1__state);
                /*0x7dc4974*/ void System.IDisposable.Dispose();
                /*0x7dc4990*/ bool MoveNext();
                /*0x7dc4d4c*/ void <>m__Finally1();
                /*0x7dc4dfc*/ UnityEngine.VFX.VisualEffectControlTrackController.Event System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectControlTrackController.Event>.get_Current();
                /*0x7dc4e0c*/ void System.Collections.IEnumerator.Reset();
                /*0x7dc4e44*/ object System.Collections.IEnumerator.get_Current();
                /*0x7dc4ea4*/ System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectControlTrackController.Event> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectControlTrackController.Event>.GetEnumerator();
                /*0x7dc4f58*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class VisualEffectControlTrackMixerBehaviour : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ UnityEngine.VFX.VisualEffectControlTrackController m_ScrubbingCacheHelper;
            /*0x18*/ UnityEngine.VFX.VisualEffect m_Target;
            /*0x20*/ bool m_ReinitWithBinding;
            /*0x21*/ bool m_ReinitWithUnbinding;

            /*0x7dc54e8*/ VisualEffectControlTrackMixerBehaviour();
            /*0x7dc2024*/ void Init(UnityEngine.VFX.VisualEffectControlTrack parentTrack, bool reinitWithBinding, bool reinitWithUnbinding);
            /*0x7dc4f5c*/ void ApplyFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data);
            /*0x7dc5110*/ void BindVFX(UnityEngine.VFX.VisualEffect vfx);
            /*0x7dc51c4*/ void UnbindVFX();
            /*0x7dc5264*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data);
            /*0x7dc5458*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data);
            /*0x7dc5420*/ void InvalidateScrubbingHelper();
            /*0x7dc54cc*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x7dc54d0*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
        }

        class VFXRuntimeResources : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.ComputeShader m_SDFRayMapCS;
            /*0x20*/ UnityEngine.ComputeShader m_SDFNormalsCS;
            /*0x28*/ UnityEngine.Shader m_SDFRayMapShader;

            static /*0x7dc5520*/ UnityEngine.VFX.VFXRuntimeResources get_runtimeResources();
            /*0x7dc55c0*/ VFXRuntimeResources();
            /*0x7dc54f0*/ UnityEngine.ComputeShader get_sdfRayMapCS();
            /*0x7dc54f8*/ void set_sdfRayMapCS(UnityEngine.ComputeShader value);
            /*0x7dc5500*/ UnityEngine.ComputeShader get_sdfNormalsCS();
            /*0x7dc5508*/ void set_sdfNormalsCS(UnityEngine.ComputeShader value);
            /*0x7dc5510*/ UnityEngine.Shader get_sdfRayMapShader();
            /*0x7dc5518*/ void set_sdfRayMapShader(UnityEngine.Shader value);
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

                static /*0x7dccfe8*/ MeshToSDFBaker();
                static /*0x7dc55d0*/ UnityEngine.Mesh InitMeshFromList(System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Matrix4x4> transforms);
                /*0x7dc62b8*/ MeshToSDFBaker(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, UnityEngine.Mesh mesh, int signPassesCount, float threshold, float sdfOffset, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7dc6c28*/ MeshToSDFBaker(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Matrix4x4> transforms, int signPassesCount, float threshold, float sdfOffset, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7dc55c8*/ UnityEngine.RenderTexture get_SdfTexture();
                /*0x7dc5938*/ void InitCommandBuffer();
                /*0x7dc59dc*/ int GetTotalVoxelCount();
                /*0x7dc5a20*/ void InitSizeBox();
                /*0x7dc6268*/ UnityEngine.Vector3Int GetGridSize();
                /*0x7dc62a8*/ UnityEngine.Vector3 GetActualBoxSize();
                /*0x7dc6d24*/ void Finalize();
                /*0x7dc6e14*/ void Reinit(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, UnityEngine.Mesh mesh, int signPassesCount, float threshold, float sdfOffset);
                /*0x7dc6eb4*/ void Reinit(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Matrix4x4> transforms, int signPassesCount, float threshold, float sdfOffset);
                /*0x7dc657c*/ void SetParameters(UnityEngine.Vector3 sizeBox, UnityEngine.Vector3 center, int maxRes, int signPassesCount, float threshold, float sdfOffset);
                /*0x7dc6464*/ void LoadRuntimeResources();
                /*0x7dc6fa0*/ void InitTextures();
                /*0x7dc6604*/ void Init();
                /*0x7dc7c00*/ void UpdateCameras();
                /*0x7dc7fc0*/ UnityEngine.Matrix4x4 ComputeOrthographicWorldToClip(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, float width, float height, float near, float far, ref UnityEngine.Matrix4x4 proj, ref UnityEngine.Matrix4x4 view);
                /*0x7dc8170*/ int iDivUp(int a, int b);
                /*0x7dc8184*/ UnityEngine.Vector2Int GetThreadGroupsCount(int nbThreads, int threadCountPerGroup);
                /*0x7dc81f4*/ void PrefixSumCount();
                /*0x7dc8b78*/ void SurfaceClosing();
                /*0x7dc8e30*/ UnityEngine.RenderTexture GetTextureVoxelPrincipal(int step);
                /*0x7dc8e48*/ UnityEngine.RenderTexture GetTextureVoxelBis(int step);
                /*0x7dc8e60*/ void JFA();
                /*0x7dc9a8c*/ void GenerateRayMap();
                /*0x7dca5b4*/ UnityEngine.RenderTexture GetRayMapPrincipal(int step);
                /*0x7dca5f4*/ UnityEngine.RenderTexture GetRayMapBis(int step);
                /*0x7dc8df0*/ UnityEngine.RenderTexture GetSignMapPrincipal(int step);
                /*0x7dca63c*/ UnityEngine.RenderTexture GetSignMapBis(int step);
                /*0x7dca684*/ void SignPass();
                /*0x7dcade8*/ void BakeSDF();
                /*0x7dcb090*/ void InitMeshBuffers();
                /*0x7dcc01c*/ void FirstDraw();
                /*0x7dcc4e8*/ void SecondDraw();
                /*0x7dcb87c*/ void BuildGeometry();
                /*0x7dcb800*/ void InitGeometryBuffers(int upperBoundCount);
                /*0x7dc75dc*/ void InitPrefixSumBuffers();
                /*0x7dcb230*/ void ClearRenderTexturesAndBuffers();
                /*0x7dcc7f4*/ void PerformDistanceTransformWinding();
                /*0x7dccc88*/ void ReleaseBuffersAndTextures();
                /*0x7dccf7c*/ void Dispose();
                /*0x7dc7518*/ void CreateGraphicsBufferIfNeeded(ref UnityEngine.GraphicsBuffer gb, int length, int stride);
                /*0x7dccf50*/ void ReleaseGraphicsBuffer(ref UnityEngine.GraphicsBuffer gb);
                /*0x7dc738c*/ void CreateRenderTextureIfNeeded(ref UnityEngine.RenderTexture rt, UnityEngine.RenderTextureDescriptor rtDesc);
                /*0x7dcce68*/ void ReleaseRenderTexture(ref UnityEngine.RenderTexture rt);

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

                    static /*0x7dcd03c*/ ShaderProperties();
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

                    /*0x7dc783c*/ Kernels(UnityEngine.ComputeShader computeShader);
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

                static /*0x7dcda4c*/ UnityEngine.Vector2 GetMousePosition();
                /*0x7dce538*/ VFXMouseEventBinder();
                /*0x7dcd930*/ void SetEventAttribute(object[] parameters);
                /*0x7dcdac8*/ void Awake();
                /*0x7dcdd74*/ void RaycastMainCamera();
                /*0x7dcdfd4*/ void RayCastDrag();
                /*0x7dce054*/ void RayCastAndTriggerEvent(System.Action trigger);
                /*0x7dce158*/ void OnEnable();
                /*0x7dce1a0*/ void OnDisable();
                /*0x7dce1e0*/ void DoOnMouseDown();
                /*0x7dce338*/ void DoOnMouseUp();
                /*0x7dce3e0*/ void DoOnMouseDrag();
                /*0x7dcde7c*/ void DoOnMouseOver();
                /*0x7dce48c*/ void DoOnMouseEnter();
                /*0x7dcdf28*/ void DoOnMouseExit();
                /*0x7dce5f4*/ void <Awake>b__12_0(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                /*0x7dce674*/ void <Awake>b__12_1(UnityEngine.InputSystem.InputAction.CallbackContext ctx);

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

                /*0x7dce958*/ VFXRigidBodyCollisionEventBinder();
                /*0x7dce6f4*/ void SetEventAttribute(object[] parameters);
                /*0x7dce7f4*/ void OnCollisionEnter(UnityEngine.Collision collision);
            }

            class VFXTriggerEventBinder : UnityEngine.VFX.Utility.VFXEventBinderBase
            {
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Collider> colliders;
                /*0x40*/ UnityEngine.VFX.Utility.VFXTriggerEventBinder.Activation activation;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty positionParameter;

                /*0x7dced6c*/ VFXTriggerEventBinder();
                /*0x7dce9e8*/ void SetEventAttribute(object[] parameters);
                /*0x7dceab8*/ void OnTriggerEnter(UnityEngine.Collider other);
                /*0x7dceb9c*/ void OnTriggerExit(UnityEngine.Collider other);
                /*0x7dcec84*/ void OnTriggerStay(UnityEngine.Collider other);

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

                /*0x7dcef74*/ VFXVisibilityEventBinder();
                /*0x7dcee1c*/ void SetEventAttribute(object[] parameters);
                /*0x7dcee20*/ void OnBecameVisible();
                /*0x7dceec8*/ void OnBecameInvisible();

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

                /*0x7dce59c*/ VFXEventBinderBase();
                /*0x7dce19c*/ void OnEnable();
                /*0x7dcf010*/ void OnValidate();
                /*0x7dcef78*/ void UpdateCacheEventAttribute();
                /*0x3816710*/ void SetEventAttribute(object[] parameters);
                /*0x7dce28c*/ void SendEventToVisualEffect(object[] parameters);
            }

            class VFXOutputEventAbstractHandler : UnityEngine.MonoBehaviour
            {
                /*0x20*/ bool executeInEditor;
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty outputEvent;
                /*0x30*/ UnityEngine.VFX.VisualEffect <m_VisualEffect>k__BackingField;

                /*0x7dcf370*/ VFXOutputEventAbstractHandler();
                /*0x3813ffc*/ bool get_canExecuteInEditor();
                /*0x7dcf014*/ void set_m_VisualEffect(UnityEngine.VFX.VisualEffect value);
                /*0x7dcf01c*/ UnityEngine.VFX.VisualEffect get_m_VisualEffect();
                /*0x7dcf024*/ void OnEnable();
                /*0x7dcf188*/ void OnDisable();
                /*0x7dcf2b8*/ void OnOutputEventRecieved(UnityEngine.VFX.VFXOutputEventArgs args);
                /*0x3816710*/ void OnVFXOutputEvent(UnityEngine.VFX.VFXEventAttribute eventAttribute);
            }

            class ExposedProperty
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Id;

                static /*0x7dbe0e8*/ UnityEngine.VFX.Utility.ExposedProperty op_Implicit(string name);
                static /*0x7dcf414*/ string op_Explicit(UnityEngine.VFX.Utility.ExposedProperty parameter);
                static /*0x7dc4720*/ int op_Implicit(UnityEngine.VFX.Utility.ExposedProperty parameter);
                static /*0x7dcf42c*/ UnityEngine.VFX.Utility.ExposedProperty op_Addition(UnityEngine.VFX.Utility.ExposedProperty self, UnityEngine.VFX.Utility.ExposedProperty other);
                /*0x7dcf4c4*/ ExposedProperty();
                /*0x7dcf3d8*/ ExposedProperty(string name);
                /*0x7dcf4e4*/ string ToString();
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

                /*0x7dcf9b4*/ VFXAudioSpectrumBinder();
                /*0x7dcf4ec*/ string get_CountProperty();
                /*0x7dcf508*/ void set_CountProperty(string value);
                /*0x7dcf52c*/ string get_TextureProperty();
                /*0x7dcf548*/ void set_TextureProperty(string value);
                /*0x7dcf56c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dcf62c*/ void UpdateTexture();
                /*0x7dcf8cc*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dcf928*/ string ToString();

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

                /*0x7dcfca0*/ VFXEnabledBinder();
                /*0x7dcfa54*/ string get_Property();
                /*0x7dcfa70*/ void set_Property(string value);
                /*0x7dcfa94*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dcfb38*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dcfba4*/ string ToString();

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

                /*0x7dd094c*/ VFXHierarchyAttributeMapBinder();
                /*0x7dcfd00*/ void OnEnable();
                /*0x7dcfe50*/ void OnValidate();
                /*0x7dcfd1c*/ void UpdateHierarchy();
                /*0x7dcfe54*/ System.Collections.Generic.List<UnityEngine.VFX.Utility.VFXHierarchyAttributeMapBinder.Bone> ChildrenOf(UnityEngine.Transform source, uint depth);
                /*0x7dd0310*/ void UpdateData();
                /*0x7dd06d4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd07cc*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd088c*/ string ToString();

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

                /*0x7dd0b30*/ VFXInputAxisBinder();
                /*0x7dd0a50*/ string get_AxisProperty();
                /*0x7dd0a6c*/ void set_AxisProperty(string value);
                /*0x7dd0a90*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd0abc*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd0ac0*/ string ToString();
            }

            class VFXInputButtonBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_ButtonProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_ButtonSmoothProperty;
                /*0x38*/ string ButtonName;
                /*0x40*/ float SmoothSpeed;
                /*0x44*/ bool UseButtonSmooth;

                /*0x7dd0d38*/ VFXInputButtonBinder();
                /*0x7dd0bcc*/ string get_ButtonProperty();
                /*0x7dd0be8*/ void set_ButtonProperty(string value);
                /*0x7dd0c0c*/ string get_ButtonSmoothProperty();
                /*0x7dd0c28*/ void set_ButtonSmoothProperty(string value);
                /*0x7dd0c4c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd0cc0*/ void Start();
                /*0x7dd0cc4*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd0cc8*/ string ToString();
            }

            class VFXInputKeyBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_KeyProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_KeySmoothProperty;
                /*0x38*/ UnityEngine.KeyCode Key;
                /*0x3c*/ float SmoothSpeed;
                /*0x40*/ bool UseKeySmooth;

                /*0x7dd0f9c*/ VFXInputKeyBinder();
                /*0x7dd0e00*/ string get_KeyProperty();
                /*0x7dd0e1c*/ void set_KeyProperty(string value);
                /*0x7dd0e40*/ string get_KeySmoothProperty();
                /*0x7dd0e5c*/ void set_KeySmoothProperty(string value);
                /*0x7dd0e80*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd0ef4*/ void Start();
                /*0x7dd0ef8*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd0efc*/ string ToString();
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

                /*0x7dd15d0*/ VFXInputMouseBinder();
                /*0x7dd1044*/ string get_MouseLeftClickProperty();
                /*0x7dd1060*/ void set_MouseLeftClickProperty(string value);
                /*0x7dd1084*/ string get_MouseRightClickProperty();
                /*0x7dd10a0*/ void set_MouseRightClickProperty(string value);
                /*0x7dd10c4*/ string get_PositionProperty();
                /*0x7dd10e0*/ void set_PositionProperty(string value);
                /*0x7dd1104*/ string get_VelocityProperty();
                /*0x7dd1120*/ void set_VelocityProperty(string value);
                /*0x7dd1144*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd1200*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd1428*/ bool IsRightClickPressed();
                /*0x7dd13c8*/ bool IsLeftClickPressed();
                /*0x7dd1488*/ UnityEngine.Vector2 GetMousePosition();
                /*0x7dd1504*/ string ToString();
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

                /*0x7dd1f74*/ VFXInputTouchBinder();
                /*0x7dd16d4*/ string get_TouchEnabledProperty();
                /*0x7dd16f0*/ void set_TouchEnabledProperty(string value);
                /*0x7dd1714*/ string get_Parameter();
                /*0x7dd1730*/ void set_Parameter(string value);
                /*0x7dd1754*/ string get_VelocityParameter();
                /*0x7dd1770*/ void set_VelocityParameter(string value);
                /*0x7dd1794*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd1880*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd1a8c*/ int GetTouchCount();
                /*0x7dd1c78*/ UnityEngine.Vector2 GetTouchPosition(int touchIndex);
                /*0x7dd1e80*/ string ToString();

                class <>c
                {
                    static /*0x0*/ UnityEngine.VFX.Utility.VFXInputTouchBinder.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.InputSystem.Controls.TouchControl, bool> <>9__20_0;

                    static /*0x7dd203c*/ <>c();
                    /*0x7dd20a4*/ <>c();
                    /*0x7dd20ac*/ bool <GetTouchCount>b__20_0(UnityEngine.InputSystem.Controls.TouchControl t);
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

                /*0x7dd241c*/ VFXLightBinder();
                /*0x7dd20bc*/ string get_ColorProperty();
                /*0x7dd20d8*/ void set_ColorProperty(string value);
                /*0x7dd20fc*/ string get_BrightnessProperty();
                /*0x7dd2118*/ void set_BrightnessProperty(string value);
                /*0x7dd213c*/ string get_RadiusProperty();
                /*0x7dd2158*/ void set_RadiusProperty(string value);
                /*0x7dd217c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd2280*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd2350*/ string ToString();
            }

            class VFXMultiplePositionBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty PositionMapProperty;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty PositionCountProperty;
                /*0x38*/ UnityEngine.GameObject[] Targets;
                /*0x40*/ bool EveryFrame;
                /*0x48*/ UnityEngine.Texture2D positionMap;
                /*0x50*/ int count;

                /*0x7dd2ce0*/ VFXMultiplePositionBinder();
                /*0x7dd254c*/ void OnEnable();
                /*0x7dd2b40*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd2bb4*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd2654*/ void UpdateTexture();
                /*0x7dd2c68*/ string ToString();
            }

            class VFXPlaneBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty Position;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty Normal;

                /*0x7dd3240*/ VFXPlaneBinder();
                /*0x7dd2d84*/ string get_Property();
                /*0x7dd2da0*/ void set_Property(string value);
                /*0x7dd2e88*/ void OnEnable();
                /*0x7dd2ea0*/ void OnValidate();
                /*0x7dd2dd0*/ void UpdateSubProperties();
                /*0x7dd2ea4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd2f6c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd3178*/ string ToString();
            }

            class VFXPositionBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;

                /*0x7dd35a0*/ VFXPositionBinder();
                /*0x7dd32ac*/ string get_Property();
                /*0x7dd32c8*/ void set_Property(string value);
                /*0x7dd32f0*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd3398*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd34d8*/ string ToString();
            }

            class VFXPreviousPositionBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ UnityEngine.Vector3 oldPosition;

                /*0x7dd38b0*/ VFXPreviousPositionBinder();
                /*0x7dd3604*/ void OnEnable();
                /*0x7dd36cc*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd3774*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd37e8*/ string ToString();
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

                /*0x7dd3fb0*/ VFXRaycastBinder();
                /*0x7dd3914*/ string get_TargetPosition();
                /*0x7dd3930*/ void set_TargetPosition(string value);
                /*0x7dd3a18*/ string get_TargetNormal();
                /*0x7dd3a34*/ void set_TargetNormal(string value);
                /*0x7dd3a64*/ string get_TargetHit();
                /*0x7dd3a80*/ void set_TargetHit(string value);
                /*0x7dd3aa8*/ void OnEnable();
                /*0x7dd3ac0*/ void OnValidate();
                /*0x7dd3960*/ void UpdateSubProperties();
                /*0x7dd3ac4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd3ba0*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd3dfc*/ string ToString();

                enum Space
                {
                    Local = 0,
                    World = 1,
                }
            }

            class VFXSpaceableBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.VFXSpaceableBinder.BinderSpace Space;

                /*0x7dd32a4*/ VFXSpaceableBinder();
                /*0x7dd40d0*/ UnityEngine.VFX.VFXSpace GetTargetSpace(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty);
                /*0x7dd301c*/ void ApplySpacePositionNormal(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Transform sourceTransform, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 normal);
                /*0x7dd414c*/ void ApplySpaceTS(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Transform sourceTransform, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 scale);
                /*0x7dd4270*/ void ApplySpaceTRS(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Transform sourceTransform, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 eulerAngles, ref UnityEngine.Vector3 scale);
                /*0x7dd342c*/ UnityEngine.Vector3 ApplySpacePosition(UnityEngine.VFX.VisualEffect component, UnityEngine.VFX.Utility.ExposedProperty targetProperty, UnityEngine.Vector3 sourceWorldPosition);

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

                /*0x7dd4858*/ VFXSphereBinder();
                /*0x7dd43ec*/ string get_Property();
                /*0x7dd4408*/ void set_Property(string value);
                /*0x7dd4534*/ void OnEnable();
                /*0x7dd454c*/ void OnValidate();
                /*0x7dd4438*/ void UpdateSubProperties();
                /*0x7dd4550*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd4638*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd477c*/ float GetSphereColliderScale(UnityEngine.Vector3 scale);
                /*0x7dd4790*/ string ToString();
            }

            class VFXTerrainBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.Terrain Terrain;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_Bounds_center;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_Bounds_size;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_HeightMap;
                /*0x50*/ UnityEngine.VFX.Utility.ExposedProperty Terrain_Height;

                /*0x7dd4d84*/ VFXTerrainBinder();
                /*0x7dd48bc*/ string get_Property();
                /*0x7dd48d8*/ void set_Property(string value);
                /*0x7dd4a50*/ void OnEnable();
                /*0x7dd4a68*/ void OnValidate();
                /*0x7dd4908*/ void UpdateSubProperties();
                /*0x7dd4a6c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd4b74*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd4cbc*/ string ToString();
            }

            class VFXTransformBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty Position;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty Angles;
                /*0x50*/ UnityEngine.VFX.Utility.ExposedProperty Scale;

                /*0x7dd51bc*/ VFXTransformBinder();
                /*0x7dd4de8*/ string get_Property();
                /*0x7dd4e04*/ void set_Property(string value);
                /*0x7dd4f30*/ void OnEnable();
                /*0x7dd4f48*/ void OnValidate();
                /*0x7dd4e34*/ void UpdateSubProperties();
                /*0x7dd4f4c*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd5034*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd50f4*/ string ToString();
            }

            class VFXUIDropdownBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.UI.Dropdown Target;

                /*0x7dd541c*/ VFXUIDropdownBinder();
                /*0x7dd5220*/ string get_Property();
                /*0x7dd523c*/ void set_Property(string value);
                /*0x7dd5264*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd530c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd5354*/ string ToString();
            }

            class VFXUISliderBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.UI.Slider Target;

                /*0x7dd5690*/ VFXUISliderBinder();
                /*0x7dd5480*/ string get_Property();
                /*0x7dd549c*/ void set_Property(string value);
                /*0x7dd54c4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd556c*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd55c8*/ string ToString();
            }

            class VFXUIToggleBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x30*/ UnityEngine.UI.Toggle Target;

                /*0x7dd58f0*/ VFXUIToggleBinder();
                /*0x7dd56f4*/ string get_Property();
                /*0x7dd5710*/ void set_Property(string value);
                /*0x7dd5738*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd57e0*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd5828*/ string ToString();
            }

            class VFXVelocityBinder : UnityEngine.VFX.Utility.VFXSpaceableBinder
            {
                static /*0x0*/ float invalidPreviousTime;
                /*0x30*/ UnityEngine.VFX.Utility.ExposedProperty m_Property;
                /*0x38*/ UnityEngine.Transform Target;
                /*0x40*/ float m_PreviousTime;
                /*0x44*/ UnityEngine.Vector3 m_PreviousPosition;

                static /*0x7dd5df4*/ VFXVelocityBinder();
                /*0x7dd5d14*/ VFXVelocityBinder();
                /*0x7dd5954*/ string get_Property();
                /*0x7dd5970*/ void set_Property(string value);
                /*0x7dd5998*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd5a40*/ void Reset();
                /*0x7dd5aa0*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd5c4c*/ string ToString();
            }

            class VFXBinderAttribute : UnityEngine.PropertyAttribute
            {
                /*0x18*/ string MenuPath;

                /*0x7dd5e40*/ VFXBinderAttribute(string menuPath);
            }

            class VFXBinderBase : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.VFX.Utility.VFXPropertyBinder binder;

                /*0x7dd2d7c*/ VFXBinderBase();
                /*0x38141c4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7dd5e70*/ void Reset();
                /*0x7dd5e74*/ void Awake();
                /*0x7dd2564*/ void OnEnable();
                /*0x7dd5ecc*/ void OnDisable();
                /*0x3816710*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7dd5f68*/ string ToString();
            }

            class VFXPropertyBinder : UnityEngine.MonoBehaviour
            {
                /*0x20*/ bool m_ExecuteInEditor;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.VFX.Utility.VFXBinderBase> m_Bindings;
                /*0x30*/ UnityEngine.VFX.VisualEffect m_VisualEffect;

                static /*0x7dd60a0*/ void SafeDestroy(UnityEngine.Object toDelete);
                /*0x7dd6454*/ VFXPropertyBinder();
                /*0x7dd5f8c*/ void OnEnable();
                /*0x7dd609c*/ void OnValidate();
                /*0x7dd5f90*/ void Reload();
                /*0x7dd60f8*/ void Reset();
                /*0x7dd61a4*/ void LateUpdate();
                /*0x3910ae8*/ T AddPropertyBinder<T>();
                /*0x3910ae8*/ T AddParameterBinder<T>();
                /*0x7dd6110*/ void ClearPropertyBinders();
                /*0x7dd639c*/ void ClearParameterBinders();
                /*0x7dd63a0*/ void RemovePropertyBinder(UnityEngine.VFX.Utility.VFXBinderBase binder);
                /*0x7dd6450*/ void RemoveParameterBinder(UnityEngine.VFX.Utility.VFXBinderBase binder);
                /*0x38159dc*/ void RemovePropertyBinders<T>();
                /*0x38159dc*/ void RemoveParameterBinders<T>();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<T> GetPropertyBinders<T>();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<T> GetParameterBinders<T>();

                class <GetPropertyBinders>d__17<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ UnityEngine.VFX.Utility.VFXPropertyBinder <>4__this;
                    /*0x0*/ System.Collections.Generic.List.Enumerator<UnityEngine.VFX.Utility.VFXBinderBase> <>7__wrap1;

                    /*0x3815ed0*/ <GetPropertyBinders>d__17(int <>1__state);
                    /*0x38159dc*/ void System.IDisposable.Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void <>m__Finally1();
                    /*0x3910ae8*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class VFXPropertyBindingAttribute : UnityEngine.PropertyAttribute
            {
                /*0x18*/ string[] EditorTypes;

                /*0x7dd64e4*/ VFXPropertyBindingAttribute(string[] editorTypes);
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
