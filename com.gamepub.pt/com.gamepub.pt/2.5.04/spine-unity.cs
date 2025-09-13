class <Module>
{
}

namespace SharpJson
{
    class Lexer
    {
        /*0x10*/ int <lineNumber>k__BackingField;
        /*0x14*/ bool <parseNumbersAsFloat>k__BackingField;
        /*0x18*/ char[] json;
        /*0x20*/ int index;
        /*0x24*/ bool success;
        /*0x28*/ char[] stringBuffer;

        static /*0x25a22b4*/ SharpJson.Lexer.Token NextToken(char[] json, ref int index);
        /*0x25a1310*/ Lexer(string text);
        /*0x25a20b4*/ bool get_hasError();
        /*0x25a20c4*/ int get_lineNumber();
        /*0x25a20cc*/ void set_lineNumber(int value);
        /*0x25a20d4*/ bool get_parseNumbersAsFloat();
        /*0x25a20dc*/ void set_parseNumbersAsFloat(bool value);
        /*0x25a20e8*/ void Reset();
        /*0x25a1934*/ string ParseString();
        /*0x25a21dc*/ string GetNumberString();
        /*0x25a1f30*/ float ParseFloatNumber();
        /*0x25a1fd8*/ double ParseDoubleNumber();
        /*0x25a2228*/ int GetLastIndexOfNumber(int index);
        /*0x25a20fc*/ void SkipWhiteSpaces();
        /*0x25a1860*/ SharpJson.Lexer.Token LookAhead();
        /*0x25a1838*/ SharpJson.Lexer.Token NextToken();

        enum Token
        {
            None = 0,
            Null = 1,
            True = 2,
            False = 3,
            Colon = 4,
            Comma = 5,
            String = 6,
            Number = 7,
            CurlyOpen = 8,
            CurlyClose = 9,
            SquaredOpen = 10,
            SquaredClose = 11,
        }
    }

    class JsonDecoder
    {
        /*0x10*/ string <errorMessage>k__BackingField;
        /*0x18*/ bool <parseNumbersAsFloat>k__BackingField;
        /*0x20*/ SharpJson.Lexer lexer;

        static /*0x25a15c4*/ object DecodeText(string text);
        /*0x25a1240*/ JsonDecoder();
        /*0x25a12ec*/ string get_errorMessage();
        /*0x25a12f4*/ void set_errorMessage(string value);
        /*0x25a12fc*/ bool get_parseNumbersAsFloat();
        /*0x25a1304*/ void set_parseNumbersAsFloat(bool value);
        /*0x25a126c*/ object Decode(string text);
        /*0x25a1634*/ System.Collections.Generic.IDictionary<string, object> ParseObject();
        /*0x25a1db0*/ System.Collections.Generic.IList<object> ParseArray();
        /*0x25a13ac*/ object ParseValue();
        /*0x25a1894*/ void TriggerError(string message);
        T EvalLexer<T>(T value);
    }
}

namespace Spine
{
    class Animation
    {
        /*0x10*/ string name;
        /*0x18*/ Spine.ExposedList<Spine.Timeline> timelines;
        /*0x20*/ System.Collections.Generic.HashSet<int> timelineIds;
        /*0x28*/ float duration;

        static /*0x224f060*/ int BinarySearch(float[] values, float target, int step);
        static /*0x224f0ec*/ int BinarySearch(float[] values, float target);
        static /*0x224f16c*/ int LinearSearch(float[] values, float target, int step);
        /*0x224eaf8*/ Animation(string name, Spine.ExposedList<Spine.Timeline> timelines, float duration);
        /*0x224edd4*/ Spine.ExposedList<Spine.Timeline> get_Timelines();
        /*0x224eddc*/ void set_Timelines(Spine.ExposedList<Spine.Timeline> value);
        /*0x224ede4*/ float get_Duration();
        /*0x224edec*/ void set_Duration(float value);
        /*0x224edf4*/ string get_Name();
        /*0x224edfc*/ bool HasTimeline(int id);
        /*0x224ee60*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, bool loop, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x224f058*/ string ToString();
    }

    interface Timeline
    {
        void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        int get_PropertyId();
    }

    enum MixBlend
    {
        Setup = 0,
        First = 1,
        Replace = 2,
        Add = 3,
    }

    enum MixDirection
    {
        In = 0,
        Out = 1,
    }

    enum TimelineType
    {
        Rotate = 0,
        Translate = 1,
        Scale = 2,
        Shear = 3,
        Attachment = 4,
        Color = 5,
        Deform = 6,
        Event = 7,
        DrawOrder = 8,
        IkConstraint = 9,
        TransformConstraint = 10,
        PathConstraintPosition = 11,
        PathConstraintSpacing = 12,
        PathConstraintMix = 13,
        TwoColor = 14,
    }

    interface IBoneTimeline
    {
        int get_BoneIndex();
    }

    interface ISlotTimeline
    {
        int get_SlotIndex();
    }

    class CurveTimeline : Spine.Timeline
    {
        static float LINEAR = 0;
        static float STEPPED = 1;
        static float BEZIER = 2;
        static int BEZIER_SIZE = 19;
        /*0x10*/ float[] curves;

        /*0x225ea2c*/ CurveTimeline(int frameCount);
        /*0x225f0bc*/ int get_FrameCount();
        void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        int get_PropertyId();
        /*0x225f0f4*/ void SetLinear(int frameIndex);
        /*0x225f138*/ void SetStepped(int frameIndex);
        /*0x225f180*/ float GetCurveType(int frameIndex);
        /*0x225f1ec*/ void SetCurve(int frameIndex, float cx1, float cy1, float cx2, float cy2);
        /*0x225176c*/ float GetCurvePercent(int frameIndex, float percent);
    }

    class RotateTimeline : Spine.CurveTimeline, Spine.IBoneTimeline
    {
        static int ENTRIES = 2;
        static int PREV_TIME = -2;
        static int PREV_ROTATION = -1;
        static int ROTATION = 1;
        /*0x18*/ int boneIndex;
        /*0x20*/ float[] frames;

        /*0x2311014*/ RotateTimeline(int frameCount);
        /*0x2311084*/ int get_PropertyId();
        /*0x231108c*/ void set_BoneIndex(int value);
        /*0x23110ec*/ int get_BoneIndex();
        /*0x23110f4*/ float[] get_Frames();
        /*0x23110fc*/ void set_Frames(float[] value);
        /*0x2311104*/ void SetFrame(int frameIndex, float time, float degrees);
        /*0x2311168*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TranslateTimeline : Spine.CurveTimeline, Spine.IBoneTimeline
    {
        static int ENTRIES = 3;
        static int PREV_TIME = -3;
        static int PREV_X = -2;
        static int PREV_Y = -1;
        static int X = 1;
        static int Y = 2;
        /*0x18*/ int boneIndex;
        /*0x20*/ float[] frames;

        /*0x2480934*/ TranslateTimeline(int frameCount);
        /*0x24809a4*/ int get_PropertyId();
        /*0x24809b4*/ void set_BoneIndex(int value);
        /*0x2480a14*/ int get_BoneIndex();
        /*0x2480a1c*/ float[] get_Frames();
        /*0x2480a24*/ void set_Frames(float[] value);
        /*0x2480a2c*/ void SetFrame(int frameIndex, float time, float x, float y);
        /*0x2480aac*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ScaleTimeline : Spine.TranslateTimeline, Spine.IBoneTimeline
    {
        /*0x2311530*/ ScaleTimeline(int frameCount);
        /*0x2311538*/ int get_PropertyId();
        /*0x2311548*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ShearTimeline : Spine.TranslateTimeline, Spine.IBoneTimeline
    {
        /*0x2311b00*/ ShearTimeline(int frameCount);
        /*0x2311b08*/ int get_PropertyId();
        /*0x2311b18*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ColorTimeline : Spine.CurveTimeline, Spine.ISlotTimeline
    {
        static int ENTRIES = 5;
        static int PREV_TIME = -5;
        static int PREV_R = -4;
        static int PREV_G = -3;
        static int PREV_B = -2;
        static int PREV_A = -1;
        static int R = 1;
        static int G = 2;
        static int B = 3;
        static int A = 4;
        /*0x18*/ int slotIndex;
        /*0x20*/ float[] frames;

        /*0x225e9c0*/ ColorTimeline(int frameCount);
        /*0x225eaf0*/ int get_PropertyId();
        /*0x225eb00*/ void set_SlotIndex(int value);
        /*0x225eb60*/ int get_SlotIndex();
        /*0x225eb68*/ float[] get_Frames();
        /*0x225eb70*/ void set_Frames(float[] value);
        /*0x225eb78*/ void SetFrame(int frameIndex, float time, float r, float g, float b, float a);
        /*0x225ec38*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TwoColorTimeline : Spine.CurveTimeline, Spine.ISlotTimeline
    {
        static int ENTRIES = 8;
        static int PREV_TIME = -8;
        static int PREV_R = -7;
        static int PREV_G = -6;
        static int PREV_B = -5;
        static int PREV_A = -4;
        static int PREV_R2 = -3;
        static int PREV_G2 = -2;
        static int PREV_B2 = -1;
        static int R = 1;
        static int G = 2;
        static int B = 3;
        static int A = 4;
        static int R2 = 5;
        static int G2 = 6;
        static int B2 = 7;
        /*0x18*/ int slotIndex;
        /*0x20*/ float[] frames;

        /*0x24821f4*/ TwoColorTimeline(int frameCount);
        /*0x2482264*/ int get_PropertyId();
        /*0x2482274*/ void set_SlotIndex(int value);
        /*0x24822d4*/ int get_SlotIndex();
        /*0x24822dc*/ float[] get_Frames();
        /*0x24822e4*/ void SetFrame(int frameIndex, float time, float r, float g, float b, float a, float r2, float g2, float b2);
        /*0x248240c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class AttachmentTimeline : Spine.Timeline, Spine.ISlotTimeline
    {
        /*0x10*/ int slotIndex;
        /*0x18*/ float[] frames;
        /*0x20*/ string[] attachmentNames;

        /*0x2259cec*/ AttachmentTimeline(int frameCount);
        /*0x2259d7c*/ int get_PropertyId();
        /*0x2259d8c*/ int get_FrameCount();
        /*0x2259da8*/ void set_SlotIndex(int value);
        /*0x2259e08*/ int get_SlotIndex();
        /*0x2259e10*/ float[] get_Frames();
        /*0x2259e18*/ void set_Frames(float[] value);
        /*0x2259e20*/ string[] get_AttachmentNames();
        /*0x2259e28*/ void set_AttachmentNames(string[] value);
        /*0x2259e30*/ void SetFrame(int frameIndex, float time, string attachmentName);
        /*0x2259ec8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class DeformTimeline : Spine.CurveTimeline, Spine.ISlotTimeline
    {
        /*0x18*/ int slotIndex;
        /*0x20*/ Spine.VertexAttachment attachment;
        /*0x28*/ float[] frames;
        /*0x30*/ float[][] frameVertices;

        /*0x225f314*/ DeformTimeline(int frameCount);
        /*0x225f3a4*/ int get_PropertyId();
        /*0x225f3d0*/ void set_SlotIndex(int value);
        /*0x225f430*/ int get_SlotIndex();
        /*0x225f438*/ Spine.VertexAttachment get_Attachment();
        /*0x225f440*/ void set_Attachment(Spine.VertexAttachment value);
        /*0x225f448*/ float[] get_Frames();
        /*0x225f450*/ void set_Frames(float[] value);
        /*0x225f458*/ float[][] get_Vertices();
        /*0x225f460*/ void set_Vertices(float[][] value);
        /*0x225f468*/ void SetFrame(int frameIndex, float time, float[] vertices);
        /*0x225f500*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class EventTimeline : Spine.Timeline
    {
        /*0x10*/ float[] frames;
        /*0x18*/ Spine.Event[] events;

        /*0x259ebec*/ EventTimeline(int frameCount);
        /*0x259ec7c*/ int get_PropertyId();
        /*0x259ec84*/ int get_FrameCount();
        /*0x259eca0*/ float[] get_Frames();
        /*0x259eca8*/ void set_Frames(float[] value);
        /*0x259ecb0*/ Spine.Event[] get_Events();
        /*0x259ecb8*/ void set_Events(Spine.Event[] value);
        /*0x259ecc0*/ void SetFrame(int frameIndex, Spine.Event e);
        /*0x259ed5c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class DrawOrderTimeline : Spine.Timeline
    {
        /*0x10*/ float[] frames;
        /*0x18*/ int[][] drawOrders;

        /*0x259dc3c*/ DrawOrderTimeline(int frameCount);
        /*0x259dccc*/ int get_PropertyId();
        /*0x259dcd4*/ int get_FrameCount();
        /*0x259dcf0*/ float[] get_Frames();
        /*0x259dcf8*/ void set_Frames(float[] value);
        /*0x259dd00*/ int[][] get_DrawOrders();
        /*0x259dd08*/ void set_DrawOrders(int[][] value);
        /*0x259dd10*/ void SetFrame(int frameIndex, float time, int[] drawOrder);
        /*0x259dda8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class IkConstraintTimeline : Spine.CurveTimeline
    {
        static int ENTRIES = 6;
        static int PREV_TIME = -6;
        static int PREV_MIX = -5;
        static int PREV_SOFTNESS = -4;
        static int PREV_BEND_DIRECTION = -3;
        static int PREV_COMPRESS = -2;
        static int PREV_STRETCH = -1;
        static int MIX = 1;
        static int SOFTNESS = 2;
        static int BEND_DIRECTION = 3;
        static int COMPRESS = 4;
        static int STRETCH = 5;
        /*0x18*/ int ikConstraintIndex;
        /*0x20*/ float[] frames;

        /*0x25a0af4*/ IkConstraintTimeline(int frameCount);
        /*0x25a0b68*/ int get_PropertyId();
        /*0x25a0b78*/ void set_IkConstraintIndex(int value);
        /*0x25a0bd8*/ int get_IkConstraintIndex();
        /*0x25a0be0*/ float[] get_Frames();
        /*0x25a0be8*/ void set_Frames(float[] value);
        /*0x25a0bf0*/ void SetFrame(int frameIndex, float time, float mix, float softness, int bendDirection, bool compress, bool stretch);
        /*0x25a0cf8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TransformConstraintTimeline : Spine.CurveTimeline
    {
        static int ENTRIES = 5;
        static int PREV_TIME = -5;
        static int PREV_ROTATE = -4;
        static int PREV_TRANSLATE = -3;
        static int PREV_SCALE = -2;
        static int PREV_SHEAR = -1;
        static int ROTATE = 1;
        static int TRANSLATE = 2;
        static int SCALE = 3;
        static int SHEAR = 4;
        /*0x18*/ int transformConstraintIndex;
        /*0x20*/ float[] frames;

        /*0x24803d4*/ TransformConstraintTimeline(int frameCount);
        /*0x2480444*/ int get_PropertyId();
        /*0x2480454*/ void set_TransformConstraintIndex(int value);
        /*0x24804b4*/ int get_TransformConstraintIndex();
        /*0x24804bc*/ float[] get_Frames();
        /*0x24804c4*/ void set_Frames(float[] value);
        /*0x24804cc*/ void SetFrame(int frameIndex, float time, float rotateMix, float translateMix, float scaleMix, float shearMix);
        /*0x248058c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PathConstraintPositionTimeline : Spine.CurveTimeline
    {
        static int ENTRIES = 2;
        static int PREV_TIME = -2;
        static int PREV_VALUE = -1;
        static int VALUE = 1;
        /*0x18*/ int pathConstraintIndex;
        /*0x20*/ float[] frames;

        /*0x230f24c*/ PathConstraintPositionTimeline(int frameCount);
        /*0x230f2bc*/ int get_PropertyId();
        /*0x230f2cc*/ void set_PathConstraintIndex(int value);
        /*0x230f32c*/ int get_PathConstraintIndex();
        /*0x230f334*/ float[] get_Frames();
        /*0x230f33c*/ void set_Frames(float[] value);
        /*0x230f344*/ void SetFrame(int frameIndex, float time, float position);
        /*0x230f3a8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PathConstraintSpacingTimeline : Spine.PathConstraintPositionTimeline
    {
        /*0x230f59c*/ PathConstraintSpacingTimeline(int frameCount);
        /*0x230f5a0*/ int get_PropertyId();
        /*0x230f5b0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PathConstraintMixTimeline : Spine.CurveTimeline
    {
        static int ENTRIES = 3;
        static int PREV_TIME = -3;
        static int PREV_ROTATE = -2;
        static int PREV_TRANSLATE = -1;
        static int ROTATE = 1;
        static int TRANSLATE = 2;
        /*0x18*/ int pathConstraintIndex;
        /*0x20*/ float[] frames;

        /*0x230ee40*/ PathConstraintMixTimeline(int frameCount);
        /*0x230eeb0*/ int get_PropertyId();
        /*0x230eec0*/ void set_PathConstraintIndex(int value);
        /*0x230ef20*/ int get_PathConstraintIndex();
        /*0x230ef28*/ float[] get_Frames();
        /*0x230ef30*/ void set_Frames(float[] value);
        /*0x230ef38*/ void SetFrame(int frameIndex, float time, float rotateMix, float translateMix);
        /*0x230efb8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class AnimationState
    {
        static int Subsequent = 0;
        static int First = 1;
        static int Hold = 2;
        static int HoldMix = 3;
        static int NotLast = 4;
        static /*0x0*/ Spine.Animation EmptyAnimation;
        /*0x10*/ Spine.AnimationStateData data;
        /*0x18*/ Spine.ExposedList<Spine.TrackEntry> tracks;
        /*0x20*/ Spine.ExposedList<Spine.Event> events;
        /*0x28*/ Spine.AnimationState.TrackEntryDelegate Start;
        /*0x30*/ Spine.AnimationState.TrackEntryDelegate Interrupt;
        /*0x38*/ Spine.AnimationState.TrackEntryDelegate End;
        /*0x40*/ Spine.AnimationState.TrackEntryDelegate Dispose;
        /*0x48*/ Spine.AnimationState.TrackEntryDelegate Complete;
        /*0x50*/ Spine.AnimationState.TrackEntryEventDelegate Event;
        /*0x58*/ Spine.EventQueue queue;
        /*0x60*/ System.Collections.Generic.HashSet<int> propertyIDs;
        /*0x68*/ bool animationsChanged;
        /*0x6c*/ float timeScale;
        /*0x70*/ Spine.Pool<Spine.TrackEntry> trackEntryPool;

        static /*0x2252d9c*/ AnimationState();
        static /*0x2251054*/ void ApplyRotateTimeline(Spine.RotateTimeline timeline, Spine.Skeleton skeleton, float time, float alpha, Spine.MixBlend blend, float[] timelinesRotation, int i, bool firstFrame);
        /*0x224fbe8*/ AnimationState(Spine.AnimationStateData data);
        /*0x224f3f0*/ void OnStart(Spine.TrackEntry entry);
        /*0x224f404*/ void OnInterrupt(Spine.TrackEntry entry);
        /*0x224f418*/ void OnEnd(Spine.TrackEntry entry);
        /*0x224f42c*/ void OnDispose(Spine.TrackEntry entry);
        /*0x224f440*/ void OnComplete(Spine.TrackEntry entry);
        /*0x224f454*/ void OnEvent(Spine.TrackEntry entry, Spine.Event e);
        /*0x224f468*/ void add_Start(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f508*/ void remove_Start(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f5a8*/ void add_Interrupt(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f648*/ void remove_Interrupt(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f6e8*/ void add_End(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f788*/ void remove_End(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f828*/ void add_Dispose(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f8c8*/ void remove_Dispose(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224f968*/ void add_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224fa08*/ void remove_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x224faa8*/ void add_Event(Spine.AnimationState.TrackEntryEventDelegate value);
        /*0x224fb48*/ void remove_Event(Spine.AnimationState.TrackEntryEventDelegate value);
        /*0x224fe24*/ void Update(float delta);
        /*0x2250220*/ bool UpdateMixingFrom(Spine.TrackEntry to, float delta);
        /*0x2250310*/ bool Apply(Spine.Skeleton skeleton);
        /*0x225097c*/ float ApplyMixingFrom(Spine.TrackEntry to, Spine.Skeleton skeleton, Spine.MixBlend blend);
        /*0x22515dc*/ void QueueEvents(Spine.TrackEntry entry, float animationTime);
        /*0x2251938*/ void ClearTracks();
        /*0x22519f8*/ void ClearTrack(int trackIndex);
        /*0x2250040*/ void SetCurrent(int index, Spine.TrackEntry current, bool interrupt);
        /*0x2251b9c*/ Spine.TrackEntry SetAnimation(int trackIndex, string animationName, bool loop);
        /*0x2251c68*/ Spine.TrackEntry SetAnimation(int trackIndex, Spine.Animation animation, bool loop);
        /*0x2251f04*/ Spine.TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay);
        /*0x2251fe0*/ Spine.TrackEntry AddAnimation(int trackIndex, Spine.Animation animation, bool loop, float delay);
        /*0x2252324*/ Spine.TrackEntry SetEmptyAnimation(int trackIndex, float mixDuration);
        /*0x22523c4*/ Spine.TrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay);
        /*0x2252478*/ void SetEmptyAnimations(float mixDuration);
        /*0x2251af8*/ Spine.TrackEntry ExpandToIndex(int index);
        /*0x2251e14*/ Spine.TrackEntry NewTrackEntry(int trackIndex, Spine.Animation animation, bool loop, Spine.TrackEntry last);
        /*0x22501c8*/ void DisposeNext(Spine.TrackEntry entry);
        /*0x2250828*/ void AnimationsChanged();
        /*0x2252540*/ void ComputeHold(Spine.TrackEntry entry);
        /*0x22529d4*/ void ComputeNotLast(Spine.TrackEntry entry);
        /*0x2252b24*/ Spine.TrackEntry GetCurrent(int trackIndex);
        /*0x2252b7c*/ void ClearListenerNotifications();
        /*0x2252b98*/ float get_TimeScale();
        /*0x2252ba0*/ void set_TimeScale(float value);
        /*0x2252ba8*/ Spine.AnimationStateData get_Data();
        /*0x2252bb0*/ void set_Data(Spine.AnimationStateData value);
        /*0x2252c28*/ Spine.ExposedList<Spine.TrackEntry> get_Tracks();
        /*0x2252c30*/ string ToString();
        /*0x2252e68*/ void <.ctor>b__40_0();

        class TrackEntryDelegate : System.MulticastDelegate
        {
            /*0x2483808*/ TrackEntryDelegate(object object, nint method);
            /*0x247e160*/ void Invoke(Spine.TrackEntry trackEntry);
            /*0x24844d0*/ System.IAsyncResult BeginInvoke(Spine.TrackEntry trackEntry, System.AsyncCallback callback, object object);
            /*0x24844f4*/ void EndInvoke(System.IAsyncResult result);
        }

        class TrackEntryEventDelegate : System.MulticastDelegate
        {
            /*0x2483aa4*/ TrackEntryEventDelegate(object object, nint method);
            /*0x247e544*/ void Invoke(Spine.TrackEntry trackEntry, Spine.Event e);
            /*0x2484500*/ System.IAsyncResult BeginInvoke(Spine.TrackEntry trackEntry, Spine.Event e, System.AsyncCallback callback, object object);
            /*0x2484530*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class TrackEntry : Spine.Pool.IPoolable<Spine.TrackEntry>
    {
        /*0x10*/ Spine.Animation animation;
        /*0x18*/ Spine.TrackEntry next;
        /*0x20*/ Spine.TrackEntry mixingFrom;
        /*0x28*/ Spine.TrackEntry mixingTo;
        /*0x30*/ Spine.AnimationState.TrackEntryDelegate Start;
        /*0x38*/ Spine.AnimationState.TrackEntryDelegate Interrupt;
        /*0x40*/ Spine.AnimationState.TrackEntryDelegate End;
        /*0x48*/ Spine.AnimationState.TrackEntryDelegate Dispose;
        /*0x50*/ Spine.AnimationState.TrackEntryDelegate Complete;
        /*0x58*/ Spine.AnimationState.TrackEntryEventDelegate Event;
        /*0x60*/ int trackIndex;
        /*0x64*/ bool loop;
        /*0x65*/ bool holdPrevious;
        /*0x68*/ float eventThreshold;
        /*0x6c*/ float attachmentThreshold;
        /*0x70*/ float drawOrderThreshold;
        /*0x74*/ float animationStart;
        /*0x78*/ float animationEnd;
        /*0x7c*/ float animationLast;
        /*0x80*/ float nextAnimationLast;
        /*0x84*/ float delay;
        /*0x88*/ float trackTime;
        /*0x8c*/ float trackLast;
        /*0x90*/ float nextTrackLast;
        /*0x94*/ float trackEnd;
        /*0x98*/ float timeScale;
        /*0x9c*/ float alpha;
        /*0xa0*/ float mixTime;
        /*0xa4*/ float mixDuration;
        /*0xa8*/ float interruptAlpha;
        /*0xac*/ float totalAlpha;
        /*0xb0*/ Spine.MixBlend mixBlend;
        /*0xb8*/ Spine.ExposedList<int> timelineMode;
        /*0xc0*/ Spine.ExposedList<Spine.TrackEntry> timelineHoldMix;
        /*0xc8*/ Spine.ExposedList<float> timelinesRotation;

        /*0x247ec44*/ TrackEntry();
        /*0x247d9cc*/ void add_Start(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247da6c*/ void remove_Start(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247db0c*/ void add_Interrupt(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247dbac*/ void remove_Interrupt(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247dc4c*/ void add_End(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247dcec*/ void remove_End(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247dd8c*/ void add_Dispose(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247de2c*/ void remove_Dispose(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247decc*/ void add_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247df6c*/ void remove_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x247e00c*/ void add_Event(Spine.AnimationState.TrackEntryEventDelegate value);
        /*0x247e0ac*/ void remove_Event(Spine.AnimationState.TrackEntryEventDelegate value);
        /*0x247e14c*/ void OnStart();
        /*0x247e4d8*/ void OnInterrupt();
        /*0x247e4ec*/ void OnEnd();
        /*0x247e500*/ void OnDispose();
        /*0x247e514*/ void OnComplete();
        /*0x247e528*/ void OnEvent(Spine.Event e);
        /*0x247e8d8*/ void Reset();
        /*0x247e990*/ int get_TrackIndex();
        /*0x247e998*/ Spine.Animation get_Animation();
        /*0x247e9a0*/ bool get_Loop();
        /*0x247e9a8*/ void set_Loop(bool value);
        /*0x247e9b4*/ float get_Delay();
        /*0x247e9bc*/ void set_Delay(float value);
        /*0x247e9c4*/ float get_TrackTime();
        /*0x247e9cc*/ void set_TrackTime(float value);
        /*0x247e9d4*/ float get_TrackEnd();
        /*0x247e9dc*/ void set_TrackEnd(float value);
        /*0x247e9e4*/ float get_AnimationStart();
        /*0x247e9ec*/ void set_AnimationStart(float value);
        /*0x247e9f4*/ float get_AnimationEnd();
        /*0x247e9fc*/ void set_AnimationEnd(float value);
        /*0x247ea04*/ float get_AnimationLast();
        /*0x247ea0c*/ void set_AnimationLast(float value);
        /*0x247ea14*/ float get_AnimationTime();
        /*0x247ead0*/ float get_TimeScale();
        /*0x247ead8*/ void set_TimeScale(float value);
        /*0x247eae0*/ float get_Alpha();
        /*0x247eae8*/ void set_Alpha(float value);
        /*0x247eaf0*/ float get_EventThreshold();
        /*0x247eaf8*/ void set_EventThreshold(float value);
        /*0x247eb00*/ float get_AttachmentThreshold();
        /*0x247eb08*/ void set_AttachmentThreshold(float value);
        /*0x247eb10*/ float get_DrawOrderThreshold();
        /*0x247eb18*/ void set_DrawOrderThreshold(float value);
        /*0x247eb20*/ Spine.TrackEntry get_Next();
        /*0x247eb28*/ bool get_IsComplete();
        /*0x247eb40*/ float get_MixTime();
        /*0x247eb48*/ void set_MixTime(float value);
        /*0x247eb50*/ float get_MixDuration();
        /*0x247eb58*/ void set_MixDuration(float value);
        /*0x247eb60*/ Spine.MixBlend get_MixBlend();
        /*0x247eb68*/ void set_MixBlend(Spine.MixBlend value);
        /*0x247eb70*/ Spine.TrackEntry get_MixingFrom();
        /*0x247eb78*/ Spine.TrackEntry get_MixingTo();
        /*0x247eb80*/ bool get_HoldPrevious();
        /*0x247eb88*/ void set_HoldPrevious(bool value);
        /*0x247eb94*/ void ResetRotationDirections();
        /*0x247ebec*/ string ToString();
    }

    class EventQueue
    {
        /*0x10*/ System.Collections.Generic.List<Spine.EventQueue.EventQueueEntry> eventQueueEntries;
        /*0x18*/ bool drainDisabled;
        /*0x20*/ Spine.AnimationState state;
        /*0x28*/ Spine.Pool<Spine.TrackEntry> trackEntryPool;
        /*0x30*/ System.Action AnimationsChanged;

        /*0x259e4b0*/ EventQueue(Spine.AnimationState state, System.Action HandleAnimationsChanged, Spine.Pool<Spine.TrackEntry> trackEntryPool);
        /*0x259e370*/ void add_AnimationsChanged(System.Action value);
        /*0x259e410*/ void remove_AnimationsChanged(System.Action value);
        /*0x259e55c*/ void Start(Spine.TrackEntry entry);
        /*0x259e610*/ void Interrupt(Spine.TrackEntry entry);
        /*0x259e6b4*/ void End(Spine.TrackEntry entry);
        /*0x259e768*/ void Dispose(Spine.TrackEntry entry);
        /*0x259e80c*/ void Complete(Spine.TrackEntry entry);
        /*0x259e8b0*/ void Event(Spine.TrackEntry entry, Spine.Event e);
        /*0x259e958*/ void Drain();
        /*0x259eb98*/ void Clear();

        struct EventQueueEntry
        {
            /*0x10*/ Spine.EventQueue.EventType type;
            /*0x18*/ Spine.TrackEntry entry;
            /*0x20*/ Spine.Event e;

            /*0xae6790*/ EventQueueEntry(Spine.EventQueue.EventType eventType, Spine.TrackEntry trackEntry, Spine.Event e);
        }

        enum EventType
        {
            Start = 0,
            Interrupt = 1,
            End = 2,
            Dispose = 3,
            Complete = 4,
            Event = 5,
        }
    }

    class Pool<T>
    {
        /*0x0*/ int max;
        /*0x0*/ System.Collections.Generic.Stack<T> freeObjects;
        /*0x0*/ int <Peak>k__BackingField;

        Pool(int initialCapacity, int max);
        int get_Count();
        int get_Peak();
        void set_Peak(int value);
        T Obtain();
        void Free(T obj);
        void Clear();
        void Reset(T obj);

        interface IPoolable<T>
        {
            void Reset();
        }
    }

    class AnimationStateData
    {
        /*0x10*/ Spine.SkeletonData skeletonData;
        /*0x18*/ System.Collections.Generic.Dictionary<Spine.AnimationStateData.AnimationPair, float> animationToMixTime;
        /*0x20*/ float defaultMix;

        /*0x2252e8c*/ AnimationStateData(Spine.SkeletonData skeletonData);
        /*0x2252e74*/ Spine.SkeletonData get_SkeletonData();
        /*0x2252e7c*/ float get_DefaultMix();
        /*0x2252e84*/ void set_DefaultMix(float value);
        /*0x2252fb4*/ void SetMix(string fromName, string toName, float duration);
        /*0x22530d4*/ void SetMix(Spine.Animation from, Spine.Animation to, float duration);
        /*0x22521e8*/ float GetMix(Spine.Animation from, Spine.Animation to);

        struct AnimationPair
        {
            /*0x10*/ Spine.Animation a1;
            /*0x18*/ Spine.Animation a2;

            /*0xae66f4*/ AnimationPair(Spine.Animation a1, Spine.Animation a2);
            /*0xae66fc*/ string ToString();
        }

        class AnimationPairComparer : System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>
        {
            static /*0x0*/ Spine.AnimationStateData.AnimationPairComparer Instance;

            static /*0x2484620*/ AnimationPairComparer();
            /*0x2484618*/ AnimationPairComparer();
            /*0x24845ac*/ bool System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.Equals(Spine.AnimationStateData.AnimationPair x, Spine.AnimationStateData.AnimationPair y);
            /*0x24845c4*/ int System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.GetHashCode(Spine.AnimationStateData.AnimationPair obj);
        }
    }

    class Atlas : System.Collections.Generic.IEnumerable<Spine.AtlasRegion>, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<Spine.AtlasPage> pages;
        /*0x18*/ System.Collections.Generic.List<Spine.AtlasRegion> regions;
        /*0x20*/ Spine.TextureLoader textureLoader;

        static /*0x2254244*/ string ReadValue(System.IO.TextReader reader);
        static /*0x2254090*/ int ReadTuple(System.IO.TextReader reader, string[] tuple);
        /*0x2253354*/ Atlas(System.IO.TextReader reader, string dir, Spine.TextureLoader textureLoader);
        /*0x2253fb4*/ Atlas(System.Collections.Generic.List<Spine.AtlasPage> pages, System.Collections.Generic.List<Spine.AtlasRegion> regions);
        /*0x225322c*/ System.Collections.Generic.IEnumerator<Spine.AtlasRegion> GetEnumerator();
        /*0x22532c0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x225343c*/ void Load(System.IO.TextReader reader, string imagesDir, Spine.TextureLoader textureLoader);
        /*0x2254304*/ void FlipV();
        /*0x22543cc*/ Spine.AtlasRegion FindRegion(string name);
        /*0x22544c8*/ void Dispose();
    }

    enum Format
    {
        Alpha = 0,
        Intensity = 1,
        LuminanceAlpha = 2,
        RGB565 = 3,
        RGBA4444 = 4,
        RGB888 = 5,
        RGBA8888 = 6,
    }

    enum TextureFilter
    {
        Nearest = 0,
        Linear = 1,
        MipMap = 2,
        MipMapNearestNearest = 3,
        MipMapLinearNearest = 4,
        MipMapNearestLinear = 5,
        MipMapLinearLinear = 6,
    }

    enum TextureWrap
    {
        MirroredRepeat = 0,
        ClampToEdge = 1,
        Repeat = 2,
    }

    class AtlasPage
    {
        /*0x10*/ string name;
        /*0x18*/ Spine.Format format;
        /*0x1c*/ Spine.TextureFilter minFilter;
        /*0x20*/ Spine.TextureFilter magFilter;
        /*0x24*/ Spine.TextureWrap uWrap;
        /*0x28*/ Spine.TextureWrap vWrap;
        /*0x30*/ object rendererObject;
        /*0x38*/ int width;
        /*0x3c*/ int height;

        /*0x2254088*/ AtlasPage();
        /*0x2254bfc*/ Spine.AtlasPage Clone();
    }

    class AtlasRegion
    {
        /*0x10*/ Spine.AtlasPage page;
        /*0x18*/ string name;
        /*0x20*/ int x;
        /*0x24*/ int y;
        /*0x28*/ int width;
        /*0x2c*/ int height;
        /*0x30*/ float u;
        /*0x34*/ float v;
        /*0x38*/ float u2;
        /*0x3c*/ float v2;
        /*0x40*/ float offsetX;
        /*0x44*/ float offsetY;
        /*0x48*/ int originalWidth;
        /*0x4c*/ int originalHeight;
        /*0x50*/ int index;
        /*0x54*/ bool rotate;
        /*0x58*/ int degrees;
        /*0x60*/ int[] splits;
        /*0x68*/ int[] pads;

        /*0x22542fc*/ AtlasRegion();
        /*0x2254c84*/ Spine.AtlasRegion Clone();
    }

    interface TextureLoader
    {
        void Load(Spine.AtlasPage page, string path);
        void Unload(object texture);
    }

    class AtlasAttachmentLoader : Spine.AttachmentLoader
    {
        /*0x10*/ Spine.Atlas[] atlasArray;

        /*0x225460c*/ AtlasAttachmentLoader(Spine.Atlas[] atlasArray);
        /*0x2254684*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path);
        /*0x2254844*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path);
        /*0x225499c*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
        /*0x2254a6c*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
        /*0x2254acc*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
        /*0x2254b2c*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
        /*0x22547c4*/ Spine.AtlasRegion FindRegion(string name);
    }

    class Attachment
    {
        /*0x10*/ string <Name>k__BackingField;

        /*0x2258dac*/ Attachment(string name);
        /*0x2258d9c*/ string get_Name();
        /*0x2258da4*/ void set_Name(string value);
        /*0x2258e38*/ string ToString();
        Spine.Attachment Copy();
    }

    interface IHasRendererObject
    {
        object get_RendererObject();
        void set_RendererObject(object value);
    }

    interface AttachmentLoader
    {
        Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path);
        Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path);
        Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
        Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
        Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
        Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
    }

    enum AttachmentType
    {
        Region = 0,
        Boundingbox = 1,
        Mesh = 2,
        Linkedmesh = 3,
        Path = 4,
        Point = 5,
        Clipping = 6,
    }

    class BoundingBoxAttachment : Spine.VertexAttachment
    {
        /*0x22549f8*/ BoundingBoxAttachment(string name);
        /*0x225d710*/ Spine.Attachment Copy();
    }

    class ClippingAttachment : Spine.VertexAttachment
    {
        /*0x40*/ Spine.SlotData endSlot;

        /*0x2254b88*/ ClippingAttachment(string name);
        /*0x225e928*/ Spine.SlotData get_EndSlot();
        /*0x225e930*/ void set_EndSlot(Spine.SlotData value);
        /*0x225e938*/ Spine.Attachment Copy();
    }

    class MeshAttachment : Spine.VertexAttachment, Spine.IHasRendererObject
    {
        /*0x40*/ float regionOffsetX;
        /*0x44*/ float regionOffsetY;
        /*0x48*/ float regionWidth;
        /*0x4c*/ float regionHeight;
        /*0x50*/ float regionOriginalWidth;
        /*0x54*/ float regionOriginalHeight;
        /*0x58*/ Spine.MeshAttachment parentMesh;
        /*0x60*/ float[] uvs;
        /*0x68*/ float[] regionUVs;
        /*0x70*/ int[] triangles;
        /*0x78*/ float r;
        /*0x7c*/ float g;
        /*0x80*/ float b;
        /*0x84*/ float a;
        /*0x88*/ int hulllength;
        /*0x90*/ string <Path>k__BackingField;
        /*0x98*/ object <RendererObject>k__BackingField;
        /*0xa0*/ float <RegionU>k__BackingField;
        /*0xa4*/ float <RegionV>k__BackingField;
        /*0xa8*/ float <RegionU2>k__BackingField;
        /*0xac*/ float <RegionV2>k__BackingField;
        /*0xb0*/ bool <RegionRotate>k__BackingField;
        /*0xb4*/ int <RegionDegrees>k__BackingField;
        /*0xb8*/ int[] <Edges>k__BackingField;
        /*0xc0*/ float <Width>k__BackingField;
        /*0xc4*/ float <Height>k__BackingField;

        /*0x25a2ee4*/ MeshAttachment(string name);
        /*0x25a2cf4*/ int get_HullLength();
        /*0x25a2cfc*/ void set_HullLength(int value);
        /*0x25a2d04*/ float[] get_RegionUVs();
        /*0x25a2d0c*/ void set_RegionUVs(float[] value);
        /*0x25a2d14*/ float[] get_UVs();
        /*0x25a2d1c*/ void set_UVs(float[] value);
        /*0x25a2d24*/ int[] get_Triangles();
        /*0x25a2d2c*/ void set_Triangles(int[] value);
        /*0x25a2d34*/ float get_R();
        /*0x25a2d3c*/ void set_R(float value);
        /*0x25a2d44*/ float get_G();
        /*0x25a2d4c*/ void set_G(float value);
        /*0x25a2d54*/ float get_B();
        /*0x25a2d5c*/ void set_B(float value);
        /*0x25a2d64*/ float get_A();
        /*0x25a2d6c*/ void set_A(float value);
        /*0x25a2d74*/ string get_Path();
        /*0x25a2d7c*/ void set_Path(string value);
        /*0x25a2d84*/ object get_RendererObject();
        /*0x25a2d8c*/ void set_RendererObject(object value);
        /*0x25a2d94*/ float get_RegionU();
        /*0x25a2d9c*/ void set_RegionU(float value);
        /*0x25a2da4*/ float get_RegionV();
        /*0x25a2dac*/ void set_RegionV(float value);
        /*0x25a2db4*/ float get_RegionU2();
        /*0x25a2dbc*/ void set_RegionU2(float value);
        /*0x25a2dc4*/ float get_RegionV2();
        /*0x25a2dcc*/ void set_RegionV2(float value);
        /*0x25a2dd4*/ bool get_RegionRotate();
        /*0x25a2ddc*/ void set_RegionRotate(bool value);
        /*0x25a2de8*/ int get_RegionDegrees();
        /*0x25a2df0*/ void set_RegionDegrees(int value);
        /*0x25a2df8*/ float get_RegionOffsetX();
        /*0x25a2e00*/ void set_RegionOffsetX(float value);
        /*0x25a2e08*/ float get_RegionOffsetY();
        /*0x25a2e10*/ void set_RegionOffsetY(float value);
        /*0x25a2e18*/ float get_RegionWidth();
        /*0x25a2e20*/ void set_RegionWidth(float value);
        /*0x25a2e28*/ float get_RegionHeight();
        /*0x25a2e30*/ void set_RegionHeight(float value);
        /*0x25a2e38*/ float get_RegionOriginalWidth();
        /*0x25a2e40*/ void set_RegionOriginalWidth(float value);
        /*0x25a2e48*/ float get_RegionOriginalHeight();
        /*0x25a2e50*/ void set_RegionOriginalHeight(float value);
        /*0x25a2e58*/ Spine.MeshAttachment get_ParentMesh();
        /*0x25a2e60*/ void set_ParentMesh(Spine.MeshAttachment value);
        /*0x25a2eb4*/ int[] get_Edges();
        /*0x25a2ebc*/ void set_Edges(int[] value);
        /*0x25a2ec4*/ float get_Width();
        /*0x25a2ecc*/ void set_Width(float value);
        /*0x25a2ed4*/ float get_Height();
        /*0x25a2edc*/ void set_Height(float value);
        /*0x25a2f60*/ void UpdateUVs();
        /*0x25a334c*/ Spine.Attachment Copy();
        /*0x25a3594*/ Spine.MeshAttachment NewLinkedMesh();
    }

    class PathAttachment : Spine.VertexAttachment
    {
        /*0x40*/ float[] lengths;
        /*0x48*/ bool closed;
        /*0x49*/ bool constantSpeed;

        /*0x25a90b4*/ PathAttachment(string name);
        /*0x25a907c*/ float[] get_Lengths();
        /*0x25a9084*/ void set_Lengths(float[] value);
        /*0x25a908c*/ bool get_Closed();
        /*0x25a9094*/ void set_Closed(bool value);
        /*0x25a90a0*/ bool get_ConstantSpeed();
        /*0x25a90a8*/ void set_ConstantSpeed(bool value);
        /*0x25a9128*/ Spine.Attachment Copy();
    }

    class PointAttachment : Spine.Attachment
    {
        /*0x18*/ float x;
        /*0x1c*/ float y;
        /*0x20*/ float rotation;

        /*0x230f7d4*/ PointAttachment(string name);
        /*0x230f7a4*/ float get_X();
        /*0x230f7ac*/ void set_X(float value);
        /*0x230f7b4*/ float get_Y();
        /*0x230f7bc*/ void set_Y(float value);
        /*0x230f7c4*/ float get_Rotation();
        /*0x230f7cc*/ void set_Rotation(float value);
        /*0x230f7dc*/ void ComputeWorldPosition(Spine.Bone bone, ref float ox, ref float oy);
        /*0x230f804*/ float ComputeWorldRotation(Spine.Bone bone);
        /*0x230f8d4*/ Spine.Attachment Copy();
    }

    class RegionAttachment : Spine.Attachment, Spine.IHasRendererObject
    {
        static int BLX = 0;
        static int BLY = 1;
        static int ULX = 2;
        static int ULY = 3;
        static int URX = 4;
        static int URY = 5;
        static int BRX = 6;
        static int BRY = 7;
        /*0x18*/ float x;
        /*0x1c*/ float y;
        /*0x20*/ float rotation;
        /*0x24*/ float scaleX;
        /*0x28*/ float scaleY;
        /*0x2c*/ float width;
        /*0x30*/ float height;
        /*0x34*/ float regionOffsetX;
        /*0x38*/ float regionOffsetY;
        /*0x3c*/ float regionWidth;
        /*0x40*/ float regionHeight;
        /*0x44*/ float regionOriginalWidth;
        /*0x48*/ float regionOriginalHeight;
        /*0x50*/ float[] offset;
        /*0x58*/ float[] uvs;
        /*0x60*/ float r;
        /*0x64*/ float g;
        /*0x68*/ float b;
        /*0x6c*/ float a;
        /*0x70*/ string <Path>k__BackingField;
        /*0x78*/ object <RendererObject>k__BackingField;

        /*0x23105ac*/ RegionAttachment(string name);
        /*0x231046c*/ float get_X();
        /*0x2310474*/ void set_X(float value);
        /*0x231047c*/ float get_Y();
        /*0x2310484*/ void set_Y(float value);
        /*0x231048c*/ float get_Rotation();
        /*0x2310494*/ void set_Rotation(float value);
        /*0x231049c*/ float get_ScaleX();
        /*0x23104a4*/ void set_ScaleX(float value);
        /*0x23104ac*/ float get_ScaleY();
        /*0x23104b4*/ void set_ScaleY(float value);
        /*0x23104bc*/ float get_Width();
        /*0x23104c4*/ void set_Width(float value);
        /*0x23104cc*/ float get_Height();
        /*0x23104d4*/ void set_Height(float value);
        /*0x23104dc*/ float get_R();
        /*0x23104e4*/ void set_R(float value);
        /*0x23104ec*/ float get_G();
        /*0x23104f4*/ void set_G(float value);
        /*0x23104fc*/ float get_B();
        /*0x2310504*/ void set_B(float value);
        /*0x231050c*/ float get_A();
        /*0x2310514*/ void set_A(float value);
        /*0x231051c*/ string get_Path();
        /*0x2310524*/ void set_Path(string value);
        /*0x231052c*/ object get_RendererObject();
        /*0x2310534*/ void set_RendererObject(object value);
        /*0x231053c*/ float get_RegionOffsetX();
        /*0x2310544*/ void set_RegionOffsetX(float value);
        /*0x231054c*/ float get_RegionOffsetY();
        /*0x2310554*/ void set_RegionOffsetY(float value);
        /*0x231055c*/ float get_RegionWidth();
        /*0x2310564*/ void set_RegionWidth(float value);
        /*0x231056c*/ float get_RegionHeight();
        /*0x2310574*/ void set_RegionHeight(float value);
        /*0x231057c*/ float get_RegionOriginalWidth();
        /*0x2310584*/ void set_RegionOriginalWidth(float value);
        /*0x231058c*/ float get_RegionOriginalHeight();
        /*0x2310594*/ void set_RegionOriginalHeight(float value);
        /*0x231059c*/ float[] get_Offset();
        /*0x23105a4*/ float[] get_UVs();
        /*0x2310638*/ void UpdateOffset();
        /*0x2310848*/ void SetUVs(float u, float v, float u2, float v2, bool rotate);
        /*0x231090c*/ void ComputeWorldVertices(Spine.Bone bone, float[] worldVertices, int offset, int stride);
        /*0x2310ae0*/ Spine.Attachment Copy();
    }

    class VertexAttachment : Spine.Attachment
    {
        static /*0x0*/ int nextID;
        static /*0x8*/ object nextIdLock;
        /*0x18*/ int id;
        /*0x20*/ int[] bones;
        /*0x28*/ float[] vertices;
        /*0x30*/ int worldVerticesLength;
        /*0x38*/ Spine.VertexAttachment deformAttachment;

        static /*0x248346c*/ VertexAttachment();
        /*0x2482dd0*/ VertexAttachment(string name);
        /*0x2482d88*/ int get_Id();
        /*0x2482d90*/ int[] get_Bones();
        /*0x2482d98*/ void set_Bones(int[] value);
        /*0x2482da0*/ float[] get_Vertices();
        /*0x2482da8*/ void set_Vertices(float[] value);
        /*0x2482db0*/ int get_WorldVerticesLength();
        /*0x2482db8*/ void set_WorldVerticesLength(int value);
        /*0x2482dc0*/ Spine.VertexAttachment get_DeformAttachment();
        /*0x2482dc8*/ void set_DeformAttachment(Spine.VertexAttachment value);
        /*0x2482f24*/ void ComputeWorldVertices(Spine.Slot slot, float[] worldVertices);
        /*0x2482f3c*/ void ComputeWorldVertices(Spine.Slot slot, int start, int count, float[] worldVertices, int offset, int stride);
        /*0x248336c*/ void CopyTo(Spine.VertexAttachment attachment);
    }

    enum BlendMode
    {
        Normal = 0,
        Additive = 1,
        Multiply = 2,
        Screen = 3,
    }

    class Bone : Spine.IUpdatable
    {
        static /*0x0*/ bool yDown;
        /*0x10*/ Spine.BoneData data;
        /*0x18*/ Spine.Skeleton skeleton;
        /*0x20*/ Spine.Bone parent;
        /*0x28*/ Spine.ExposedList<Spine.Bone> children;
        /*0x30*/ float x;
        /*0x34*/ float y;
        /*0x38*/ float rotation;
        /*0x3c*/ float scaleX;
        /*0x40*/ float scaleY;
        /*0x44*/ float shearX;
        /*0x48*/ float shearY;
        /*0x4c*/ float ax;
        /*0x50*/ float ay;
        /*0x54*/ float arotation;
        /*0x58*/ float ascaleX;
        /*0x5c*/ float ascaleY;
        /*0x60*/ float ashearX;
        /*0x64*/ float ashearY;
        /*0x68*/ bool appliedValid;
        /*0x6c*/ float a;
        /*0x70*/ float b;
        /*0x74*/ float worldX;
        /*0x78*/ float c;
        /*0x7c*/ float d;
        /*0x80*/ float worldY;
        /*0x84*/ bool sorted;
        /*0x85*/ bool active;

        /*0x225ab54*/ Bone(Spine.BoneData data, Spine.Skeleton skeleton, Spine.Bone parent);
        /*0x225a7dc*/ Spine.BoneData get_Data();
        /*0x225a7e4*/ Spine.Skeleton get_Skeleton();
        /*0x225a7ec*/ Spine.Bone get_Parent();
        /*0x225a7f4*/ Spine.ExposedList<Spine.Bone> get_Children();
        /*0x225a7fc*/ bool get_Active();
        /*0x225a804*/ float get_X();
        /*0x225a80c*/ void set_X(float value);
        /*0x225a814*/ float get_Y();
        /*0x225a81c*/ void set_Y(float value);
        /*0x225a824*/ float get_Rotation();
        /*0x225a82c*/ void set_Rotation(float value);
        /*0x225a834*/ float get_ScaleX();
        /*0x225a83c*/ void set_ScaleX(float value);
        /*0x225a844*/ float get_ScaleY();
        /*0x225a84c*/ void set_ScaleY(float value);
        /*0x225a854*/ float get_ShearX();
        /*0x225a85c*/ void set_ShearX(float value);
        /*0x225a864*/ float get_ShearY();
        /*0x225a86c*/ void set_ShearY(float value);
        /*0x225a874*/ float get_AppliedRotation();
        /*0x225a87c*/ void set_AppliedRotation(float value);
        /*0x225a884*/ float get_AX();
        /*0x225a88c*/ void set_AX(float value);
        /*0x225a894*/ float get_AY();
        /*0x225a89c*/ void set_AY(float value);
        /*0x225a8a4*/ float get_AScaleX();
        /*0x225a8ac*/ void set_AScaleX(float value);
        /*0x225a8b4*/ float get_AScaleY();
        /*0x225a8bc*/ void set_AScaleY(float value);
        /*0x225a8c4*/ float get_AShearX();
        /*0x225a8cc*/ void set_AShearX(float value);
        /*0x225a8d4*/ float get_AShearY();
        /*0x225a8dc*/ void set_AShearY(float value);
        /*0x225a8e4*/ float get_A();
        /*0x225a8ec*/ float get_B();
        /*0x225a8f4*/ float get_C();
        /*0x225a8fc*/ float get_D();
        /*0x225a904*/ float get_WorldX();
        /*0x225a90c*/ float get_WorldY();
        /*0x225a914*/ float get_WorldRotationX();
        /*0x225a99c*/ float get_WorldRotationY();
        /*0x225aa24*/ float get_WorldScaleX();
        /*0x225aabc*/ float get_WorldScaleY();
        /*0x225acdc*/ void Update();
        /*0x225b4c4*/ void UpdateWorldTransform();
        /*0x225acf0*/ void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY);
        /*0x225ac8c*/ void SetToSetupPose();
        /*0x225b4d8*/ void UpdateAppliedTransform();
        /*0x225b854*/ void WorldToLocal(float worldX, float worldY, ref float localX, ref float localY);
        /*0x225b8b0*/ void LocalToWorld(float localX, float localY, ref float worldX, ref float worldY);
        /*0x225b8ec*/ float get_WorldToLocalRotationX();
        /*0x225b9ac*/ float get_WorldToLocalRotationY();
        /*0x225ba6c*/ float WorldToLocalRotation(float worldRotation);
        /*0x225bb34*/ float LocalToWorldRotation(float localRotation);
        /*0x225bbfc*/ void RotateWorld(float degrees);
        /*0x225bcc0*/ string ToString();
    }

    class BoneData
    {
        /*0x10*/ int index;
        /*0x18*/ string name;
        /*0x20*/ Spine.BoneData parent;
        /*0x28*/ float length;
        /*0x2c*/ float x;
        /*0x30*/ float y;
        /*0x34*/ float rotation;
        /*0x38*/ float scaleX;
        /*0x3c*/ float scaleY;
        /*0x40*/ float shearX;
        /*0x44*/ float shearY;
        /*0x48*/ Spine.TransformMode transformMode;
        /*0x4c*/ bool skinRequired;

        /*0x225bd98*/ BoneData(int index, string name, Spine.BoneData parent);
        /*0x225bcdc*/ int get_Index();
        /*0x225bce4*/ string get_Name();
        /*0x225bcec*/ Spine.BoneData get_Parent();
        /*0x225bcf4*/ float get_Length();
        /*0x225bcfc*/ void set_Length(float value);
        /*0x225bd04*/ float get_X();
        /*0x225bd0c*/ void set_X(float value);
        /*0x225bd14*/ float get_Y();
        /*0x225bd1c*/ void set_Y(float value);
        /*0x225bd24*/ float get_Rotation();
        /*0x225bd2c*/ void set_Rotation(float value);
        /*0x225bd34*/ float get_ScaleX();
        /*0x225bd3c*/ void set_ScaleX(float value);
        /*0x225bd44*/ float get_ScaleY();
        /*0x225bd4c*/ void set_ScaleY(float value);
        /*0x225bd54*/ float get_ShearX();
        /*0x225bd5c*/ void set_ShearX(float value);
        /*0x225bd64*/ float get_ShearY();
        /*0x225bd6c*/ void set_ShearY(float value);
        /*0x225bd74*/ Spine.TransformMode get_TransformMode();
        /*0x225bd7c*/ void set_TransformMode(Spine.TransformMode value);
        /*0x225bd84*/ bool get_SkinRequired();
        /*0x225bd8c*/ void set_SkinRequired(bool value);
        /*0x225be8c*/ string ToString();
    }

    enum TransformMode
    {
        Normal = 0,
        OnlyTranslation = 7,
        NoRotationOrReflection = 1,
        NoScale = 2,
        NoScaleOrReflection = 6,
    }

    class ConstraintData
    {
        /*0x10*/ string name;
        /*0x18*/ int order;
        /*0x1c*/ bool skinRequired;

        /*0x225effc*/ ConstraintData(string name);
        /*0x225f088*/ string get_Name();
        /*0x225f090*/ int get_Order();
        /*0x225f098*/ void set_Order(int value);
        /*0x225f0a0*/ bool get_SkinRequired();
        /*0x225f0a8*/ void set_SkinRequired(bool value);
        /*0x225f0b4*/ string ToString();
    }

    class Event
    {
        /*0x10*/ Spine.EventData data;
        /*0x18*/ float time;
        /*0x1c*/ int intValue;
        /*0x20*/ float floatValue;
        /*0x28*/ string stringValue;
        /*0x30*/ float volume;
        /*0x34*/ float balance;

        /*0x259dfa0*/ Event(float time, Spine.EventData data);
        /*0x259df40*/ Spine.EventData get_Data();
        /*0x259df48*/ float get_Time();
        /*0x259df50*/ int get_Int();
        /*0x259df58*/ void set_Int(int value);
        /*0x259df60*/ float get_Float();
        /*0x259df68*/ void set_Float(float value);
        /*0x259df70*/ string get_String();
        /*0x259df78*/ void set_String(string value);
        /*0x259df80*/ float get_Volume();
        /*0x259df88*/ void set_Volume(float value);
        /*0x259df90*/ float get_Balance();
        /*0x259df98*/ void set_Balance(float value);
        /*0x259e03c*/ string ToString();
    }

    class EventData
    {
        /*0x10*/ string name;
        /*0x18*/ int <Int>k__BackingField;
        /*0x1c*/ float <Float>k__BackingField;
        /*0x20*/ string <String>k__BackingField;
        /*0x28*/ string <AudioPath>k__BackingField;
        /*0x30*/ float <Volume>k__BackingField;
        /*0x34*/ float <Balance>k__BackingField;

        /*0x259e0c0*/ EventData(string name);
        /*0x259e058*/ string get_Name();
        /*0x259e060*/ int get_Int();
        /*0x259e068*/ void set_Int(int value);
        /*0x259e070*/ float get_Float();
        /*0x259e078*/ void set_Float(float value);
        /*0x259e080*/ string get_String();
        /*0x259e088*/ void set_String(string value);
        /*0x259e090*/ string get_AudioPath();
        /*0x259e098*/ void set_AudioPath(string value);
        /*0x259e0a0*/ float get_Volume();
        /*0x259e0a8*/ void set_Volume(float value);
        /*0x259e0b0*/ float get_Balance();
        /*0x259e0b8*/ void set_Balance(float value);
        /*0x259e14c*/ string ToString();
    }

    class ExposedList<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        static int DefaultCapacity = 4;
        static /*0x0*/ T[] EmptyArray;
        /*0x0*/ T[] Items;
        /*0x0*/ int Count;
        /*0x0*/ int version;

        static ExposedList();
        static void CheckMatch(System.Predicate<T> match);
        ExposedList();
        ExposedList(System.Collections.Generic.IEnumerable<T> collection);
        ExposedList(int capacity);
        ExposedList(T[] data, int size);
        void Add(T item);
        void GrowIfNeeded(int addedCount);
        Spine.ExposedList<T> Resize(int newSize);
        void EnsureCapacity(int min);
        void CheckRange(int index, int count);
        void AddCollection(System.Collections.Generic.ICollection<T> collection);
        void AddEnumerable(System.Collections.Generic.IEnumerable<T> enumerable);
        void AddRange(Spine.ExposedList<T> list);
        void AddRange(System.Collections.Generic.IEnumerable<T> collection);
        int BinarySearch(T item);
        int BinarySearch(T item, System.Collections.Generic.IComparer<T> comparer);
        int BinarySearch(int index, int count, T item, System.Collections.Generic.IComparer<T> comparer);
        void Clear(bool clearArray);
        bool Contains(T item);
        Spine.ExposedList<TOutput> ConvertAll<TOutput>(System.Converter<T, TOutput> converter);
        void CopyTo(T[] array);
        void CopyTo(T[] array, int arrayIndex);
        void CopyTo(int index, T[] array, int arrayIndex, int count);
        bool Exists(System.Predicate<T> match);
        T Find(System.Predicate<T> match);
        Spine.ExposedList<T> FindAll(System.Predicate<T> match);
        Spine.ExposedList<T> FindAllList(System.Predicate<T> match);
        int FindIndex(System.Predicate<T> match);
        int FindIndex(int startIndex, System.Predicate<T> match);
        int FindIndex(int startIndex, int count, System.Predicate<T> match);
        int GetIndex(int startIndex, int count, System.Predicate<T> match);
        T FindLast(System.Predicate<T> match);
        int FindLastIndex(System.Predicate<T> match);
        int FindLastIndex(int startIndex, System.Predicate<T> match);
        int FindLastIndex(int startIndex, int count, System.Predicate<T> match);
        int GetLastIndex(int startIndex, int count, System.Predicate<T> match);
        void ForEach(System.Action<T> action);
        Spine.ExposedList.Enumerator<T> GetEnumerator();
        Spine.ExposedList<T> GetRange(int index, int count);
        int IndexOf(T item);
        int IndexOf(T item, int index);
        int IndexOf(T item, int index, int count);
        void Shift(int start, int delta);
        void CheckIndex(int index);
        void Insert(int index, T item);
        void CheckCollection(System.Collections.Generic.IEnumerable<T> collection);
        void InsertRange(int index, System.Collections.Generic.IEnumerable<T> collection);
        void InsertCollection(int index, System.Collections.Generic.ICollection<T> collection);
        void InsertEnumeration(int index, System.Collections.Generic.IEnumerable<T> enumerable);
        int LastIndexOf(T item);
        int LastIndexOf(T item, int index);
        int LastIndexOf(T item, int index, int count);
        bool Remove(T item);
        int RemoveAll(System.Predicate<T> match);
        void RemoveAt(int index);
        T Pop();
        void RemoveRange(int index, int count);
        void Reverse();
        void Reverse(int index, int count);
        void Sort();
        void Sort(System.Collections.Generic.IComparer<T> comparer);
        void Sort(System.Comparison<T> comparison);
        void Sort(int index, int count, System.Collections.Generic.IComparer<T> comparer);
        T[] ToArray();
        void TrimExcess();
        bool TrueForAll(System.Predicate<T> match);
        int get_Capacity();
        void set_Capacity(int value);
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

        struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ Spine.ExposedList<T> l;
            /*0x0*/ int next;
            /*0x0*/ int ver;
            /*0x0*/ T current;

            Enumerator(Spine.ExposedList<T> l);
            void Dispose();
            void VerifyState();
            bool MoveNext();
            T get_Current();
            void System.Collections.IEnumerator.Reset();
            object System.Collections.IEnumerator.get_Current();
        }
    }

    interface IUpdatable
    {
        void Update();
        bool get_Active();
    }

    class IkConstraint : Spine.IUpdatable
    {
        /*0x10*/ Spine.IkConstraintData data;
        /*0x18*/ Spine.ExposedList<Spine.Bone> bones;
        /*0x20*/ Spine.Bone target;
        /*0x28*/ int bendDirection;
        /*0x2c*/ bool compress;
        /*0x2d*/ bool stretch;
        /*0x30*/ float mix;
        /*0x34*/ float softness;
        /*0x38*/ bool active;

        static /*0x259fbc4*/ void Apply(Spine.Bone bone, float targetX, float targetY, bool compress, bool stretch, bool uniform, float alpha);
        static /*0x259ff1c*/ void Apply(Spine.Bone parent, Spine.Bone child, float targetX, float targetY, int bendDir, bool stretch, float softness, float alpha);
        /*0x259f4f4*/ IkConstraint(Spine.IkConstraintData data, Spine.Skeleton skeleton);
        /*0x259f7cc*/ IkConstraint(Spine.IkConstraint constraint, Spine.Skeleton skeleton);
        /*0x259fafc*/ void Apply();
        /*0x259fb00*/ void Update();
        /*0x25a093c*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x25a0944*/ Spine.Bone get_Target();
        /*0x25a094c*/ void set_Target(Spine.Bone value);
        /*0x25a0954*/ float get_Mix();
        /*0x25a095c*/ void set_Mix(float value);
        /*0x25a0964*/ float get_Softness();
        /*0x25a096c*/ void set_Softness(float value);
        /*0x25a0974*/ int get_BendDirection();
        /*0x25a097c*/ void set_BendDirection(int value);
        /*0x25a0984*/ bool get_Compress();
        /*0x25a098c*/ void set_Compress(bool value);
        /*0x25a0998*/ bool get_Stretch();
        /*0x25a09a0*/ void set_Stretch(bool value);
        /*0x25a09ac*/ bool get_Active();
        /*0x25a09b4*/ Spine.IkConstraintData get_Data();
        /*0x25a09bc*/ string ToString();
    }

    class IkConstraintData : Spine.ConstraintData
    {
        /*0x20*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x28*/ Spine.BoneData target;
        /*0x30*/ int bendDirection;
        /*0x34*/ bool compress;
        /*0x35*/ bool stretch;
        /*0x36*/ bool uniform;
        /*0x38*/ float mix;
        /*0x3c*/ float softness;

        /*0x25a09d8*/ IkConstraintData(string name);
        /*0x25a0a70*/ Spine.ExposedList<Spine.BoneData> get_Bones();
        /*0x25a0a78*/ Spine.BoneData get_Target();
        /*0x25a0a80*/ void set_Target(Spine.BoneData value);
        /*0x25a0a88*/ float get_Mix();
        /*0x25a0a90*/ void set_Mix(float value);
        /*0x25a0a98*/ float get_Softness();
        /*0x25a0aa0*/ void set_Softness(float value);
        /*0x25a0aa8*/ int get_BendDirection();
        /*0x25a0ab0*/ void set_BendDirection(int value);
        /*0x25a0ab8*/ bool get_Compress();
        /*0x25a0ac0*/ void set_Compress(bool value);
        /*0x25a0acc*/ bool get_Stretch();
        /*0x25a0ad4*/ void set_Stretch(bool value);
        /*0x25a0ae0*/ bool get_Uniform();
        /*0x25a0ae8*/ void set_Uniform(bool value);
    }

    class Json
    {
        static /*0x25a11b4*/ object Deserialize(System.IO.TextReader text);
    }

    class MathUtils
    {
        static float PI = 3.1415927410125732;
        static float PI2 = 6.2831854820251465;
        static float RadDeg = 57.2957763671875;
        static float DegRad = 0.01745329238474369;
        static /*0x0*/ System.Random random;

        static /*0x25a2c80*/ MathUtils();
        static /*0x25a2858*/ float Sin(float radians);
        static /*0x25a28c8*/ float Cos(float radians);
        static /*0x25a2938*/ float SinDeg(float degrees);
        static /*0x25a29b4*/ float CosDeg(float degrees);
        static /*0x25a2a30*/ float Atan2(float y, float x);
        static /*0x25a2aa8*/ float Clamp(float value, float min, float max);
        static /*0x25a2ac4*/ float RandomTriangle(float min, float max);
        static /*0x25a2b40*/ float RandomTriangle(float min, float max, float mode);
    }

    class IInterpolation
    {
        static /*0x0*/ Spine.IInterpolation Pow2;
        static /*0x8*/ Spine.IInterpolation Pow2Out;

        static /*0x259f438*/ IInterpolation();
        /*0x259f430*/ IInterpolation();
        float Apply(float a);
        /*0x259f3f4*/ float Apply(float start, float end, float a);
    }

    class Pow : Spine.IInterpolation
    {
        /*0x10*/ float <Power>k__BackingField;

        /*0x2310240*/ Pow(float power);
        /*0x2310230*/ float get_Power();
        /*0x2310238*/ void set_Power(float value);
        /*0x23102b8*/ float Apply(float a);
    }

    class PowOut : Spine.Pow
    {
        /*0x23103b4*/ PowOut(float power);
        /*0x23103b8*/ float Apply(float a);
    }

    class PathConstraint : Spine.IUpdatable
    {
        static int NONE = -1;
        static int BEFORE = -2;
        static int AFTER = -3;
        static float Epsilon = 0.000009999999747378752;
        /*0x10*/ Spine.PathConstraintData data;
        /*0x18*/ Spine.ExposedList<Spine.Bone> bones;
        /*0x20*/ Spine.Slot target;
        /*0x28*/ float position;
        /*0x2c*/ float spacing;
        /*0x30*/ float rotateMix;
        /*0x34*/ float translateMix;
        /*0x38*/ bool active;
        /*0x40*/ Spine.ExposedList<float> spaces;
        /*0x48*/ Spine.ExposedList<float> positions;
        /*0x50*/ Spine.ExposedList<float> world;
        /*0x58*/ Spine.ExposedList<float> curves;
        /*0x60*/ Spine.ExposedList<float> lengths;
        /*0x68*/ float[] segments;

        static /*0x25aaf68*/ void AddBeforePosition(float p, float[] temp, int i, float[] output, int o);
        static /*0x25ab0d8*/ void AddAfterPosition(float p, float[] temp, int i, float[] output, int o);
        static /*0x25ab248*/ void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, float[] output, int o, bool tangents);
        /*0x25a9204*/ PathConstraint(Spine.PathConstraintData data, Spine.Skeleton skeleton);
        /*0x25a9564*/ PathConstraint(Spine.PathConstraint constraint, Spine.Skeleton skeleton);
        /*0x25a991c*/ void Apply();
        /*0x25a9920*/ void Update();
        /*0x25aa120*/ float[] ComputeWorldPositions(Spine.PathAttachment path, int spacesCount, bool tangents, bool percentPosition, bool percentSpacing);
        /*0x25ab4b4*/ float get_Position();
        /*0x25ab4bc*/ void set_Position(float value);
        /*0x25ab4c4*/ float get_Spacing();
        /*0x25ab4cc*/ void set_Spacing(float value);
        /*0x25ab4d4*/ float get_RotateMix();
        /*0x25ab4dc*/ void set_RotateMix(float value);
        /*0x25ab4e4*/ float get_TranslateMix();
        /*0x25ab4ec*/ void set_TranslateMix(float value);
        /*0x25ab4f4*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x25ab4fc*/ Spine.Slot get_Target();
        /*0x25ab504*/ void set_Target(Spine.Slot value);
        /*0x25ab50c*/ bool get_Active();
        /*0x25ab514*/ Spine.PathConstraintData get_Data();
    }

    class PathConstraintData : Spine.ConstraintData
    {
        /*0x20*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x28*/ Spine.SlotData target;
        /*0x30*/ Spine.PositionMode positionMode;
        /*0x34*/ Spine.SpacingMode spacingMode;
        /*0x38*/ Spine.RotateMode rotateMode;
        /*0x3c*/ float offsetRotation;
        /*0x40*/ float position;
        /*0x44*/ float spacing;
        /*0x48*/ float rotateMix;
        /*0x4c*/ float translateMix;

        /*0x230ed20*/ PathConstraintData(string name);
        /*0x230eda8*/ Spine.ExposedList<Spine.BoneData> get_Bones();
        /*0x230edb0*/ Spine.SlotData get_Target();
        /*0x230edb8*/ void set_Target(Spine.SlotData value);
        /*0x230edc0*/ Spine.PositionMode get_PositionMode();
        /*0x230edc8*/ void set_PositionMode(Spine.PositionMode value);
        /*0x230edd0*/ Spine.SpacingMode get_SpacingMode();
        /*0x230edd8*/ void set_SpacingMode(Spine.SpacingMode value);
        /*0x230ede0*/ Spine.RotateMode get_RotateMode();
        /*0x230ede8*/ void set_RotateMode(Spine.RotateMode value);
        /*0x230edf0*/ float get_OffsetRotation();
        /*0x230edf8*/ void set_OffsetRotation(float value);
        /*0x230ee00*/ float get_Position();
        /*0x230ee08*/ void set_Position(float value);
        /*0x230ee10*/ float get_Spacing();
        /*0x230ee18*/ void set_Spacing(float value);
        /*0x230ee20*/ float get_RotateMix();
        /*0x230ee28*/ void set_RotateMix(float value);
        /*0x230ee30*/ float get_TranslateMix();
        /*0x230ee38*/ void set_TranslateMix(float value);
    }

    enum PositionMode
    {
        Fixed = 0,
        Percent = 1,
    }

    enum SpacingMode
    {
        Length = 0,
        Fixed = 1,
        Percent = 2,
    }

    enum RotateMode
    {
        Tangent = 0,
        Chain = 1,
        ChainScale = 2,
    }

    class Skeleton
    {
        /*0x10*/ Spine.SkeletonData data;
        /*0x18*/ Spine.ExposedList<Spine.Bone> bones;
        /*0x20*/ Spine.ExposedList<Spine.Slot> slots;
        /*0x28*/ Spine.ExposedList<Spine.Slot> drawOrder;
        /*0x30*/ Spine.ExposedList<Spine.IkConstraint> ikConstraints;
        /*0x38*/ Spine.ExposedList<Spine.TransformConstraint> transformConstraints;
        /*0x40*/ Spine.ExposedList<Spine.PathConstraint> pathConstraints;
        /*0x48*/ Spine.ExposedList<Spine.IUpdatable> updateCache;
        /*0x50*/ Spine.ExposedList<Spine.Bone> updateCacheReset;
        /*0x58*/ Spine.Skin skin;
        /*0x60*/ float r;
        /*0x64*/ float g;
        /*0x68*/ float b;
        /*0x6c*/ float a;
        /*0x70*/ float time;
        /*0x74*/ float scaleX;
        /*0x78*/ float scaleY;
        /*0x7c*/ float x;
        /*0x80*/ float y;

        static /*0x2313824*/ void SortReset(Spine.ExposedList<Spine.Bone> bones);
        /*0x2312070*/ Skeleton(Spine.SkeletonData data);
        /*0x2311de4*/ Spine.SkeletonData get_Data();
        /*0x2311dec*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x2311df4*/ Spine.ExposedList<Spine.IUpdatable> get_UpdateCacheList();
        /*0x2311dfc*/ Spine.ExposedList<Spine.Slot> get_Slots();
        /*0x2311e04*/ Spine.ExposedList<Spine.Slot> get_DrawOrder();
        /*0x2311e0c*/ Spine.ExposedList<Spine.IkConstraint> get_IkConstraints();
        /*0x2311e14*/ Spine.ExposedList<Spine.PathConstraint> get_PathConstraints();
        /*0x2311e1c*/ Spine.ExposedList<Spine.TransformConstraint> get_TransformConstraints();
        /*0x2311e24*/ Spine.Skin get_Skin();
        /*0x2311e2c*/ void set_Skin(Spine.Skin value);
        /*0x2311f2c*/ float get_R();
        /*0x2311f34*/ void set_R(float value);
        /*0x2311f3c*/ float get_G();
        /*0x2311f44*/ void set_G(float value);
        /*0x2311f4c*/ float get_B();
        /*0x2311f54*/ void set_B(float value);
        /*0x2311f5c*/ float get_A();
        /*0x2311f64*/ void set_A(float value);
        /*0x2311f6c*/ float get_Time();
        /*0x2311f74*/ void set_Time(float value);
        /*0x2311f7c*/ float get_X();
        /*0x2311f84*/ void set_X(float value);
        /*0x2311f8c*/ float get_Y();
        /*0x2311f94*/ void set_Y(float value);
        /*0x2311f9c*/ float get_ScaleX();
        /*0x2311fa4*/ void set_ScaleX(float value);
        /*0x2310138*/ float get_ScaleY();
        /*0x2311fac*/ void set_ScaleY(float value);
        /*0x2311fb4*/ bool get_FlipX();
        /*0x2311fc4*/ void set_FlipX(bool value);
        /*0x2311fec*/ bool get_FlipY();
        /*0x2311ffc*/ void set_FlipY(bool value);
        /*0x2312024*/ Spine.Bone get_RootBone();
        /*0x2312be8*/ void UpdateCache();
        /*0x23130cc*/ void SortIkConstraint(Spine.IkConstraint constraint);
        /*0x2313520*/ void SortPathConstraint(Spine.PathConstraint constraint);
        /*0x23132b0*/ void SortTransformConstraint(Spine.TransformConstraint constraint);
        /*0x23138b8*/ void SortPathConstraintAttachment(Spine.Skin skin, int slotIndex, Spine.Bone slotBone);
        /*0x2313b60*/ void SortPathConstraintAttachment(Spine.Attachment attachment, Spine.Bone slotBone);
        /*0x231378c*/ void SortBone(Spine.Bone bone);
        /*0x2312f60*/ void UpdateWorldTransform();
        /*0x2313cdc*/ void UpdateWorldTransform(Spine.Bone parent);
        /*0x2313fc0*/ void SetToSetupPose();
        /*0x2313fe4*/ void SetBonesToSetupPose();
        /*0x23141b8*/ void SetSlotsToSetupPose();
        /*0x23142d8*/ Spine.Bone FindBone(string boneName);
        /*0x23143dc*/ int FindBoneIndex(string boneName);
        /*0x23144e0*/ Spine.Slot FindSlot(string slotName);
        /*0x230fc08*/ int FindSlotIndex(string slotName);
        /*0x23145e4*/ void SetSkin(string skinName);
        /*0x2311e30*/ void SetSkin(Spine.Skin newSkin);
        /*0x23147d8*/ Spine.Attachment GetAttachment(string slotName, string attachmentName);
        /*0x230fd10*/ Spine.Attachment GetAttachment(int slotIndex, string attachmentName);
        /*0x2314908*/ void SetAttachment(string slotName, string attachmentName);
        /*0x2314ac8*/ Spine.IkConstraint FindIkConstraint(string constraintName);
        /*0x2314bcc*/ Spine.TransformConstraint FindTransformConstraint(string constraintName);
        /*0x2314cd0*/ Spine.PathConstraint FindPathConstraint(string constraintName);
        /*0x2314dd8*/ void Update(float delta);
        /*0x2314de8*/ void GetBounds(ref float x, ref float y, ref float width, ref float height, ref float[] vertexBuffer);
    }

    class SkeletonBinary
    {
        static int BONE_ROTATE = 0;
        static int BONE_TRANSLATE = 1;
        static int BONE_SCALE = 2;
        static int BONE_SHEAR = 3;
        static int SLOT_ATTACHMENT = 0;
        static int SLOT_COLOR = 1;
        static int SLOT_TWO_COLOR = 2;
        static int PATH_POSITION = 0;
        static int PATH_SPACING = 1;
        static int PATH_MIX = 2;
        static int CURVE_LINEAR = 0;
        static int CURVE_STEPPED = 1;
        static int CURVE_BEZIER = 2;
        static /*0x0*/ Spine.TransformMode[] TransformModeValues;
        /*0x10*/ float <Scale>k__BackingField;
        /*0x18*/ Spine.AttachmentLoader attachmentLoader;
        /*0x20*/ System.Collections.Generic.List<Spine.SkeletonJson.LinkedMesh> linkedMeshes;

        static /*0x231a9e4*/ SkeletonBinary();
        static /*0x2317a20*/ string GetVersionString(System.IO.Stream file);
        /*0x231613c*/ SkeletonBinary(Spine.Atlas[] atlasArray);
        /*0x23161ac*/ SkeletonBinary(Spine.AttachmentLoader attachmentLoader);
        /*0x231612c*/ float get_Scale();
        /*0x2316134*/ void set_Scale(float value);
        /*0x231628c*/ Spine.SkeletonData ReadSkeletonData(string path);
        /*0x231644c*/ Spine.SkeletonData ReadSkeletonData(System.IO.Stream file);
        /*0x2317d10*/ Spine.Skin ReadSkin(Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData, bool defaultSkin, bool nonessential);
        /*0x2319944*/ Spine.Attachment ReadAttachment(Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData, Spine.Skin skin, int slotIndex, string attachmentName, bool nonessential);
        /*0x231a438*/ Spine.SkeletonBinary.Vertices ReadVertices(Spine.SkeletonBinary.SkeletonInput input, int vertexCount);
        /*0x231a6d0*/ float[] ReadFloatArray(Spine.SkeletonBinary.SkeletonInput input, int n, float scale);
        /*0x231a7f4*/ int[] ReadShortArray(Spine.SkeletonBinary.SkeletonInput input);
        /*0x2318188*/ Spine.Animation ReadAnimation(string name, Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData);
        /*0x231a8e4*/ void ReadCurve(Spine.SkeletonBinary.SkeletonInput input, int frameIndex, Spine.CurveTimeline timeline);

        class Vertices
        {
            /*0x10*/ int[] bones;
            /*0x18*/ float[] vertices;

            /*0x2485444*/ Vertices();
        }

        class SkeletonInput
        {
            /*0x10*/ byte[] chars;
            /*0x18*/ Spine.ExposedList<string> strings;
            /*0x20*/ System.IO.Stream input;

            /*0x2484ba4*/ SkeletonInput(System.IO.Stream input);
            /*0x2484c14*/ byte ReadByte();
            /*0x2484c40*/ sbyte ReadSByte();
            /*0x2484cb0*/ bool ReadBoolean();
            /*0x2484ce4*/ float ReadFloat();
            /*0x2484e1c*/ int ReadInt();
            /*0x2484ecc*/ int ReadInt(bool optimizePositive);
            /*0x2484fa8*/ string ReadString();
            /*0x2485148*/ string ReadStringRef();
            /*0x248509c*/ void ReadFully(byte[] buffer, int offset, int length);
            /*0x24851b0*/ string GetVersionString();
        }
    }

    class SkeletonBounds
    {
        /*0x10*/ Spine.ExposedList<Spine.Polygon> polygonPool;
        /*0x18*/ float minX;
        /*0x1c*/ float minY;
        /*0x20*/ float maxX;
        /*0x24*/ float maxY;
        /*0x28*/ Spine.ExposedList<Spine.BoundingBoxAttachment> <BoundingBoxes>k__BackingField;
        /*0x30*/ Spine.ExposedList<Spine.Polygon> <Polygons>k__BackingField;

        /*0x231aaf4*/ SkeletonBounds();
        /*0x231aa74*/ Spine.ExposedList<Spine.BoundingBoxAttachment> get_BoundingBoxes();
        /*0x231aa7c*/ void set_BoundingBoxes(Spine.ExposedList<Spine.BoundingBoxAttachment> value);
        /*0x231aa84*/ Spine.ExposedList<Spine.Polygon> get_Polygons();
        /*0x231aa8c*/ void set_Polygons(Spine.ExposedList<Spine.Polygon> value);
        /*0x231aa94*/ float get_MinX();
        /*0x231aa9c*/ void set_MinX(float value);
        /*0x231aaa4*/ float get_MinY();
        /*0x231aaac*/ void set_MinY(float value);
        /*0x231aab4*/ float get_MaxX();
        /*0x231aabc*/ void set_MaxX(float value);
        /*0x231aac4*/ float get_MaxY();
        /*0x231aacc*/ void set_MaxY(float value);
        /*0x231aad4*/ float get_Width();
        /*0x231aae4*/ float get_Height();
        /*0x231abd0*/ void Update(Spine.Skeleton skeleton, bool updateAabb);
        /*0x231aed4*/ void AabbCompute();
        /*0x231b084*/ bool AabbContainsPoint(float x, float y);
        /*0x231b0c0*/ bool AabbIntersectsSegment(float x1, float y1, float x2, float y2);
        /*0x231b19c*/ bool AabbIntersectsSkeleton(Spine.SkeletonBounds bounds);
        /*0x231b1f8*/ bool ContainsPoint(Spine.Polygon polygon, float x, float y);
        /*0x231b2ec*/ Spine.BoundingBoxAttachment ContainsPoint(float x, float y);
        /*0x231b3ac*/ Spine.BoundingBoxAttachment IntersectsSegment(float x1, float y1, float x2, float y2);
        /*0x231b484*/ bool IntersectsSegment(Spine.Polygon polygon, float x1, float y1, float x2, float y2);
        /*0x231b600*/ Spine.Polygon GetPolygon(Spine.BoundingBoxAttachment attachment);
    }

    class Polygon
    {
        /*0x10*/ float[] <Vertices>k__BackingField;
        /*0x18*/ int <Count>k__BackingField;

        /*0x23101d0*/ Polygon();
        /*0x23101b0*/ float[] get_Vertices();
        /*0x23101b8*/ void set_Vertices(float[] value);
        /*0x23101c0*/ int get_Count();
        /*0x23101c8*/ void set_Count(int value);
    }

    class SkeletonClipping
    {
        /*0x10*/ Spine.Triangulator triangulator;
        /*0x18*/ Spine.ExposedList<float> clippingPolygon;
        /*0x20*/ Spine.ExposedList<float> clipOutput;
        /*0x28*/ Spine.ExposedList<float> clippedVertices;
        /*0x30*/ Spine.ExposedList<int> clippedTriangles;
        /*0x38*/ Spine.ExposedList<float> clippedUVs;
        /*0x40*/ Spine.ExposedList<float> scratch;
        /*0x48*/ Spine.ClippingAttachment clipAttachment;
        /*0x50*/ Spine.ExposedList<Spine.ExposedList<float>> clippingPolygons;

        static /*0x231b948*/ void MakeClockwise(Spine.ExposedList<float> polygon);
        /*0x231c978*/ SkeletonClipping();
        /*0x231b6a8*/ Spine.ExposedList<float> get_ClippedVertices();
        /*0x231b6b0*/ Spine.ExposedList<int> get_ClippedTriangles();
        /*0x231b6b8*/ Spine.ExposedList<float> get_ClippedUVs();
        /*0x231b6c0*/ bool get_IsClipping();
        /*0x231b6d0*/ int ClipStart(Spine.Slot slot, Spine.ClippingAttachment clip);
        /*0x231bab8*/ void ClipEnd(Spine.Slot slot);
        /*0x231bae8*/ void ClipEnd();
        /*0x231bb98*/ void ClipTriangles(float[] vertices, int verticesLength, int[] triangles, int trianglesLength, float[] uvs);
        /*0x231c340*/ bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, Spine.ExposedList<float> clippingArea, Spine.ExposedList<float> output);
    }

    class SkeletonData
    {
        /*0x10*/ string name;
        /*0x18*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x20*/ Spine.ExposedList<Spine.SlotData> slots;
        /*0x28*/ Spine.ExposedList<Spine.Skin> skins;
        /*0x30*/ Spine.Skin defaultSkin;
        /*0x38*/ Spine.ExposedList<Spine.EventData> events;
        /*0x40*/ Spine.ExposedList<Spine.Animation> animations;
        /*0x48*/ Spine.ExposedList<Spine.IkConstraintData> ikConstraints;
        /*0x50*/ Spine.ExposedList<Spine.TransformConstraintData> transformConstraints;
        /*0x58*/ Spine.ExposedList<Spine.PathConstraintData> pathConstraints;
        /*0x60*/ float x;
        /*0x64*/ float y;
        /*0x68*/ float width;
        /*0x6c*/ float height;
        /*0x70*/ string version;
        /*0x78*/ string hash;
        /*0x80*/ float fps;
        /*0x88*/ string imagesPath;
        /*0x90*/ string audioPath;

        /*0x2317ad8*/ SkeletonData();
        /*0x231caf0*/ string get_Name();
        /*0x231caf8*/ void set_Name(string value);
        /*0x231cb00*/ Spine.ExposedList<Spine.BoneData> get_Bones();
        /*0x231cb08*/ Spine.ExposedList<Spine.SlotData> get_Slots();
        /*0x231cb10*/ Spine.ExposedList<Spine.Skin> get_Skins();
        /*0x231cb18*/ void set_Skins(Spine.ExposedList<Spine.Skin> value);
        /*0x231cb20*/ Spine.Skin get_DefaultSkin();
        /*0x231cb28*/ void set_DefaultSkin(Spine.Skin value);
        /*0x231cb30*/ Spine.ExposedList<Spine.EventData> get_Events();
        /*0x231cb38*/ void set_Events(Spine.ExposedList<Spine.EventData> value);
        /*0x231cb40*/ Spine.ExposedList<Spine.Animation> get_Animations();
        /*0x231cb48*/ void set_Animations(Spine.ExposedList<Spine.Animation> value);
        /*0x231cb50*/ Spine.ExposedList<Spine.IkConstraintData> get_IkConstraints();
        /*0x231cb58*/ void set_IkConstraints(Spine.ExposedList<Spine.IkConstraintData> value);
        /*0x231cb60*/ Spine.ExposedList<Spine.TransformConstraintData> get_TransformConstraints();
        /*0x231cb68*/ void set_TransformConstraints(Spine.ExposedList<Spine.TransformConstraintData> value);
        /*0x231cb70*/ Spine.ExposedList<Spine.PathConstraintData> get_PathConstraints();
        /*0x231cb78*/ void set_PathConstraints(Spine.ExposedList<Spine.PathConstraintData> value);
        /*0x231cb80*/ float get_X();
        /*0x231cb88*/ void set_X(float value);
        /*0x231cb90*/ float get_Y();
        /*0x231cb98*/ void set_Y(float value);
        /*0x231cba0*/ float get_Width();
        /*0x231cba8*/ void set_Width(float value);
        /*0x231cbb0*/ float get_Height();
        /*0x231cbb8*/ void set_Height(float value);
        /*0x231cbc0*/ string get_Version();
        /*0x231cbc8*/ void set_Version(string value);
        /*0x231cbd0*/ string get_Hash();
        /*0x231cbd8*/ void set_Hash(string value);
        /*0x231cbe0*/ string get_ImagesPath();
        /*0x231cbe8*/ void set_ImagesPath(string value);
        /*0x231cbf0*/ string get_AudioPath();
        /*0x231cbf8*/ void set_AudioPath(string value);
        /*0x231cc00*/ float get_Fps();
        /*0x231cc08*/ void set_Fps(float value);
        /*0x231cc10*/ Spine.BoneData FindBone(string boneName);
        /*0x231cd0c*/ int FindBoneIndex(string boneName);
        /*0x231ce08*/ Spine.SlotData FindSlot(string slotName);
        /*0x2314814*/ int FindSlotIndex(string slotName);
        /*0x2314628*/ Spine.Skin FindSkin(string skinName);
        /*0x231cf04*/ Spine.EventData FindEvent(string eventDataName);
        /*0x2315c3c*/ Spine.Animation FindAnimation(string animationName);
        /*0x231d0b4*/ Spine.IkConstraintData FindIkConstraint(string constraintName);
        /*0x231d1b0*/ Spine.TransformConstraintData FindTransformConstraint(string constraintName);
        /*0x231d2ac*/ Spine.PathConstraintData FindPathConstraint(string constraintName);
        /*0x231d3ac*/ int FindPathConstraintIndex(string pathConstraintName);
        /*0x231d4a4*/ string ToString();
    }

    class SkeletonJson
    {
        /*0x10*/ float <Scale>k__BackingField;
        /*0x18*/ Spine.AttachmentLoader attachmentLoader;
        /*0x20*/ System.Collections.Generic.List<Spine.SkeletonJson.LinkedMesh> linkedMeshes;

        static /*0x1dd547c*/ void ReadCurve(System.Collections.Generic.Dictionary<string, object> valueMap, Spine.CurveTimeline timeline, int frameIndex);
        static /*0x1dd5060*/ float[] GetFloatArray(System.Collections.Generic.Dictionary<string, object> map, string name, float scale);
        static /*0x1dd52b0*/ int[] GetIntArray(System.Collections.Generic.Dictionary<string, object> map, string name);
        static /*0x1dcea34*/ float GetFloat(System.Collections.Generic.Dictionary<string, object> map, string name, float defaultValue);
        static /*0x1dcee14*/ int GetInt(System.Collections.Generic.Dictionary<string, object> map, string name, int defaultValue);
        static /*0x1dcebdc*/ bool GetBoolean(System.Collections.Generic.Dictionary<string, object> map, string name, bool defaultValue);
        static /*0x1dceb10*/ string GetString(System.Collections.Generic.Dictionary<string, object> map, string name, string defaultValue);
        static /*0x1dcecb8*/ float ToColor(string hexString, int colorIndex, int expectedLength);
        /*0x1dca44c*/ SkeletonJson(Spine.Atlas[] atlasArray);
        /*0x1dca4bc*/ SkeletonJson(Spine.AttachmentLoader attachmentLoader);
        /*0x1dca43c*/ float get_Scale();
        /*0x1dca444*/ void set_Scale(float value);
        /*0x1dca5b0*/ Spine.SkeletonData ReadSkeletonData(string path);
        /*0x1dca79c*/ Spine.SkeletonData ReadSkeletonData(System.IO.TextReader reader);
        /*0x1dcf0ac*/ Spine.Attachment ReadAttachment(System.Collections.Generic.Dictionary<string, object> map, Spine.Skin skin, int slotIndex, string name, Spine.SkeletonData skeletonData);
        /*0x1dd4d04*/ void ReadVertices(System.Collections.Generic.Dictionary<string, object> map, Spine.VertexAttachment attachment, int verticesLength);
        /*0x1dcfeb4*/ void ReadAnimation(System.Collections.Generic.Dictionary<string, object> map, string name, Spine.SkeletonData skeletonData);

        class LinkedMesh
        {
            /*0x10*/ string parent;
            /*0x18*/ string skin;
            /*0x20*/ int slotIndex;
            /*0x28*/ Spine.MeshAttachment mesh;
            /*0x30*/ bool inheritDeform;

            /*0x2485738*/ LinkedMesh(Spine.MeshAttachment mesh, string skin, int slotIndex, string parent, bool inheritDeform);
        }
    }

    class Skin
    {
        /*0x10*/ string name;
        /*0x18*/ Spine.Collections.OrderedDictionary<Spine.Skin.SkinEntry, Spine.Attachment> attachments;
        /*0x20*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x28*/ Spine.ExposedList<Spine.ConstraintData> constraints;

        /*0x1dcef04*/ Skin(string name);
        /*0x1ddc728*/ string get_Name();
        /*0x1ddc730*/ Spine.Collections.OrderedDictionary<Spine.Skin.SkinEntry, Spine.Attachment> get_Attachments();
        /*0x1ddc738*/ Spine.ExposedList<Spine.BoneData> get_Bones();
        /*0x1ddc740*/ Spine.ExposedList<Spine.ConstraintData> get_Constraints();
        /*0x1dcfcb8*/ void SetAttachment(int slotIndex, string name, Spine.Attachment attachment);
        /*0x1ddc748*/ void AddSkin(Spine.Skin skin);
        /*0x1ddcc98*/ void CopySkin(Spine.Skin skin);
        /*0x1dcfdfc*/ Spine.Attachment GetAttachment(int slotIndex, string name);
        /*0x1ddd2a4*/ void RemoveAttachment(int slotIndex, string name);
        /*0x1ddd3a8*/ System.Collections.Generic.ICollection<Spine.Skin.SkinEntry> GetAttachments();
        /*0x1ddd3fc*/ void GetAttachments(int slotIndex, System.Collections.Generic.List<Spine.Skin.SkinEntry> attachments);
        /*0x1ddd714*/ void Clear();
        /*0x1ddd7b8*/ string ToString();
        /*0x1ddd7c0*/ void AttachAll(Spine.Skeleton skeleton, Spine.Skin oldSkin);

        struct SkinEntry
        {
            /*0x10*/ int slotIndex;
            /*0x18*/ string name;
            /*0x20*/ Spine.Attachment attachment;
            /*0x28*/ int hashCode;

            /*0xae6978*/ SkinEntry(int slotIndex, string name, Spine.Attachment attachment);
            /*0xae6980*/ int get_SlotIndex();
            /*0xae6988*/ string get_Name();
            /*0xae6990*/ Spine.Attachment get_Attachment();
        }

        class SkinEntryComparer : System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinEntry>
        {
            static /*0x0*/ Spine.Skin.SkinEntryComparer Instance;

            static /*0x248877c*/ SkinEntryComparer();
            /*0x2488774*/ SkinEntryComparer();
            /*0x2488708*/ bool System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinEntry>.Equals(Spine.Skin.SkinEntry e1, Spine.Skin.SkinEntry e2);
            /*0x2488734*/ int System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinEntry>.GetHashCode(Spine.Skin.SkinEntry e);
        }
    }

    class Slot
    {
        /*0x10*/ Spine.SlotData data;
        /*0x18*/ Spine.Bone bone;
        /*0x20*/ float r;
        /*0x24*/ float g;
        /*0x28*/ float b;
        /*0x2c*/ float a;
        /*0x30*/ float r2;
        /*0x34*/ float g2;
        /*0x38*/ float b2;
        /*0x3c*/ bool hasSecondColor;
        /*0x40*/ Spine.Attachment attachment;
        /*0x48*/ float attachmentTime;
        /*0x50*/ Spine.ExposedList<float> deform;

        /*0x247aa70*/ Slot(Spine.SlotData data, Spine.Bone bone);
        /*0x247ac50*/ Slot(Spine.Slot slot, Spine.Bone bone);
        /*0x247ae04*/ Spine.SlotData get_Data();
        /*0x247ae0c*/ Spine.Bone get_Bone();
        /*0x247ae14*/ Spine.Skeleton get_Skeleton();
        /*0x247ae30*/ float get_R();
        /*0x247ae38*/ void set_R(float value);
        /*0x247ae40*/ float get_G();
        /*0x247ae48*/ void set_G(float value);
        /*0x247ae50*/ float get_B();
        /*0x247ae58*/ void set_B(float value);
        /*0x247ae60*/ float get_A();
        /*0x247ae68*/ void set_A(float value);
        /*0x247ae70*/ float get_R2();
        /*0x247ae78*/ void set_R2(float value);
        /*0x247ae80*/ float get_G2();
        /*0x247ae88*/ void set_G2(float value);
        /*0x247ae90*/ float get_B2();
        /*0x247ae98*/ void set_B2(float value);
        /*0x247aea0*/ bool get_HasSecondColor();
        /*0x247aebc*/ void set_HasSecondColor(bool value);
        /*0x247aedc*/ Spine.Attachment get_Attachment();
        /*0x247aee4*/ void set_Attachment(Spine.Attachment value);
        /*0x247af80*/ float get_AttachmentTime();
        /*0x247afb0*/ void set_AttachmentTime(float value);
        /*0x247afe0*/ Spine.ExposedList<float> get_Deform();
        /*0x247afe8*/ void set_Deform(Spine.ExposedList<float> value);
        /*0x247aba8*/ void SetToSetupPose();
        /*0x247b060*/ string ToString();
    }

    class SlotData
    {
        /*0x10*/ int index;
        /*0x18*/ string name;
        /*0x20*/ Spine.BoneData boneData;
        /*0x28*/ float r;
        /*0x2c*/ float g;
        /*0x30*/ float b;
        /*0x34*/ float a;
        /*0x38*/ float r2;
        /*0x3c*/ float g2;
        /*0x40*/ float b2;
        /*0x44*/ bool hasSecondColor;
        /*0x48*/ string attachmentName;
        /*0x50*/ Spine.BlendMode blendMode;

        /*0x247bf9c*/ SlotData(int index, string name, Spine.BoneData boneData);
        /*0x247bee0*/ int get_Index();
        /*0x247bee8*/ string get_Name();
        /*0x247bef0*/ Spine.BoneData get_BoneData();
        /*0x247bef8*/ float get_R();
        /*0x247bf00*/ void set_R(float value);
        /*0x247bf08*/ float get_G();
        /*0x247bf10*/ void set_G(float value);
        /*0x247bf18*/ float get_B();
        /*0x247bf20*/ void set_B(float value);
        /*0x247bf28*/ float get_A();
        /*0x247bf30*/ void set_A(float value);
        /*0x247bf38*/ float get_R2();
        /*0x247bf40*/ void set_R2(float value);
        /*0x247bf48*/ float get_G2();
        /*0x247bf50*/ void set_G2(float value);
        /*0x247bf58*/ float get_B2();
        /*0x247bf60*/ void set_B2(float value);
        /*0x247bf68*/ bool get_HasSecondColor();
        /*0x247bf70*/ void set_HasSecondColor(bool value);
        /*0x247bf7c*/ string get_AttachmentName();
        /*0x247bf84*/ void set_AttachmentName(string value);
        /*0x247bf8c*/ Spine.BlendMode get_BlendMode();
        /*0x247bf94*/ void set_BlendMode(Spine.BlendMode value);
        /*0x247c0c4*/ string ToString();
    }

    class TransformConstraint : Spine.IUpdatable
    {
        /*0x10*/ Spine.TransformConstraintData data;
        /*0x18*/ Spine.ExposedList<Spine.Bone> bones;
        /*0x20*/ Spine.Bone target;
        /*0x28*/ float rotateMix;
        /*0x2c*/ float translateMix;
        /*0x30*/ float scaleMix;
        /*0x34*/ float shearMix;
        /*0x38*/ bool active;

        /*0x247ed4c*/ TransformConstraint(Spine.TransformConstraintData data, Spine.Skeleton skeleton);
        /*0x247efd8*/ TransformConstraint(Spine.TransformConstraint constraint, Spine.Skeleton skeleton);
        /*0x247f2cc*/ void Apply();
        /*0x247f2d0*/ void Update();
        /*0x247fc4c*/ void ApplyAbsoluteWorld();
        /*0x247f744*/ void ApplyRelativeWorld();
        /*0x247f4d0*/ void ApplyAbsoluteLocal();
        /*0x247f308*/ void ApplyRelativeLocal();
        /*0x24801e8*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x24801f0*/ Spine.Bone get_Target();
        /*0x24801f8*/ void set_Target(Spine.Bone value);
        /*0x2480200*/ float get_RotateMix();
        /*0x2480208*/ void set_RotateMix(float value);
        /*0x2480210*/ float get_TranslateMix();
        /*0x2480218*/ void set_TranslateMix(float value);
        /*0x2480220*/ float get_ScaleMix();
        /*0x2480228*/ void set_ScaleMix(float value);
        /*0x2480230*/ float get_ShearMix();
        /*0x2480238*/ void set_ShearMix(float value);
        /*0x2480240*/ bool get_Active();
        /*0x2480248*/ Spine.TransformConstraintData get_Data();
        /*0x2480250*/ string ToString();
    }

    class TransformConstraintData : Spine.ConstraintData
    {
        /*0x20*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x28*/ Spine.BoneData target;
        /*0x30*/ float rotateMix;
        /*0x34*/ float translateMix;
        /*0x38*/ float scaleMix;
        /*0x3c*/ float shearMix;
        /*0x40*/ float offsetRotation;
        /*0x44*/ float offsetX;
        /*0x48*/ float offsetY;
        /*0x4c*/ float offsetScaleX;
        /*0x50*/ float offsetScaleY;
        /*0x54*/ float offsetShearY;
        /*0x58*/ bool relative;
        /*0x59*/ bool local;

        /*0x248034c*/ TransformConstraintData(string name);
        /*0x248026c*/ Spine.ExposedList<Spine.BoneData> get_Bones();
        /*0x2480274*/ Spine.BoneData get_Target();
        /*0x248027c*/ void set_Target(Spine.BoneData value);
        /*0x2480284*/ float get_RotateMix();
        /*0x248028c*/ void set_RotateMix(float value);
        /*0x2480294*/ float get_TranslateMix();
        /*0x248029c*/ void set_TranslateMix(float value);
        /*0x24802a4*/ float get_ScaleMix();
        /*0x24802ac*/ void set_ScaleMix(float value);
        /*0x24802b4*/ float get_ShearMix();
        /*0x24802bc*/ void set_ShearMix(float value);
        /*0x24802c4*/ float get_OffsetRotation();
        /*0x24802cc*/ void set_OffsetRotation(float value);
        /*0x24802d4*/ float get_OffsetX();
        /*0x24802dc*/ void set_OffsetX(float value);
        /*0x24802e4*/ float get_OffsetY();
        /*0x24802ec*/ void set_OffsetY(float value);
        /*0x24802f4*/ float get_OffsetScaleX();
        /*0x24802fc*/ void set_OffsetScaleX(float value);
        /*0x2480304*/ float get_OffsetScaleY();
        /*0x248030c*/ void set_OffsetScaleY(float value);
        /*0x2480314*/ float get_OffsetShearY();
        /*0x248031c*/ void set_OffsetShearY(float value);
        /*0x2480324*/ bool get_Relative();
        /*0x248032c*/ void set_Relative(bool value);
        /*0x2480338*/ bool get_Local();
        /*0x2480340*/ void set_Local(bool value);
    }

    class Triangulator
    {
        /*0x10*/ Spine.ExposedList<Spine.ExposedList<float>> convexPolygons;
        /*0x18*/ Spine.ExposedList<Spine.ExposedList<int>> convexPolygonsIndices;
        /*0x20*/ Spine.ExposedList<int> indicesArray;
        /*0x28*/ Spine.ExposedList<bool> isConcaveArray;
        /*0x30*/ Spine.ExposedList<int> triangles;
        /*0x38*/ Spine.Pool<Spine.ExposedList<float>> polygonPool;
        /*0x40*/ Spine.Pool<Spine.ExposedList<int>> polygonIndicesPool;

        static /*0x2481388*/ bool IsConcave(int index, int vertexCount, float[] vertices, int[] indices);
        static /*0x24814ac*/ bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
        static /*0x2481fd8*/ int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
        /*0x248200c*/ Triangulator();
        /*0x2480d78*/ Spine.ExposedList<int> Triangulate(Spine.ExposedList<float> verticesArray);
        /*0x24814d8*/ Spine.ExposedList<Spine.ExposedList<float>> Decompose(Spine.ExposedList<float> verticesArray, Spine.ExposedList<int> triangles);
    }

    struct BoneMatrix
    {
        /*0x10*/ float a;
        /*0x14*/ float b;
        /*0x18*/ float c;
        /*0x1c*/ float d;
        /*0x20*/ float x;
        /*0x24*/ float y;

        static /*0x225cd84*/ Spine.BoneMatrix CalculateSetupWorld(Spine.BoneData boneData);
        static /*0x225ce18*/ Spine.BoneMatrix GetInheritedInternal(Spine.BoneData boneData, Spine.BoneMatrix parentMatrix);
        /*0xae3a14*/ BoneMatrix(Spine.BoneData boneData);
        /*0xae3a1c*/ BoneMatrix(Spine.Bone bone);
        /*0xae3a24*/ Spine.BoneMatrix TransformMatrix(Spine.BoneMatrix local);
    }

    class SkeletonExtensions
    {
        static /*0x231dc6c*/ bool IsWeighted(Spine.VertexAttachment va);
        static /*0x231dc9c*/ bool IsRenderable(Spine.Attachment a);
        static /*0x231dcf4*/ bool InheritsRotation(Spine.TransformMode mode);
        static /*0x231dd00*/ bool InheritsScale(Spine.TransformMode mode);
        static /*0x231dd0c*/ void SetPropertyToSetupPose(Spine.Skeleton skeleton, int propertyID);
        static /*0x231e1c0*/ void SetDrawOrderToSetupPose(Spine.Skeleton skeleton);
        static /*0x231e274*/ void SetSlotAttachmentsToSetupPose(Spine.Skeleton skeleton);
        static /*0x231e168*/ void SetColorToSetupPose(Spine.Slot slot);
        static /*0x231e338*/ void SetAttachmentToSetupPose(Spine.Slot slot);
        static /*0x231e0c0*/ void SetSlotAttachmentToSetupPose(Spine.Skeleton skeleton, int slotIndex);
        static /*0x231e38c*/ void SetKeyedItemsToSetupPose(Spine.Animation animation, Spine.Skeleton skeleton);
        static /*0x231e3c0*/ void AllowImmediateQueue(Spine.TrackEntry trackEntry);
    }

    namespace Unity
    {
        class AnimationReferenceAsset : UnityEngine.ScriptableObject, Spine.Unity.IHasSkeletonDataAsset
        {
            static bool QuietSkeletonData = true;
            /*0x18*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x20*/ string animationName;
            /*0x28*/ Spine.Animation animation;

            static /*0x224f3b0*/ Spine.Animation op_Implicit(Spine.Unity.AnimationReferenceAsset asset);
            /*0x224f3e8*/ AnimationReferenceAsset();
            /*0x224f1cc*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x224f1d4*/ Spine.Animation get_Animation();
            /*0x224f204*/ void Initialize();
        }

        class AtlasAssetBase : UnityEngine.ScriptableObject
        {
            /*0x2254604*/ AtlasAssetBase();
            UnityEngine.Material get_PrimaryMaterial();
            System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            int get_MaterialCount();
            bool get_IsLoaded();
            void Clear();
            Spine.Atlas GetAtlas();
        }

        class EventDataReferenceAsset : UnityEngine.ScriptableObject
        {
            static bool QuietSkeletonData = true;
            /*0x18*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x20*/ string eventName;
            /*0x28*/ Spine.EventData eventData;

            static /*0x259e330*/ Spine.EventData op_Implicit(Spine.Unity.EventDataReferenceAsset asset);
            /*0x259e368*/ EventDataReferenceAsset();
            /*0x259e154*/ Spine.EventData get_EventData();
            /*0x259e184*/ void Initialize();
        }

        class RegionlessAttachmentLoader : Spine.AttachmentLoader
        {
            static /*0x0*/ Spine.AtlasRegion emptyRegion;

            static /*0x2310c20*/ Spine.AtlasRegion get_EmptyRegion();
            /*0x231100c*/ RegionlessAttachmentLoader();
            /*0x2310db0*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path);
            /*0x2310e1c*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path);
            /*0x2310e8c*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
            /*0x2310eec*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
            /*0x2310f4c*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
            /*0x2310fac*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
        }

        class SkeletonDataAsset : UnityEngine.ScriptableObject
        {
            /*0x18*/ Spine.Unity.AtlasAssetBase[] atlasAssets;
            /*0x20*/ float scale;
            /*0x28*/ UnityEngine.TextAsset skeletonJSON;
            /*0x30*/ System.Collections.Generic.List<Spine.Unity.SkeletonDataModifierAsset> skeletonDataModifiers;
            /*0x38*/ string[] fromAnimation;
            /*0x40*/ string[] toAnimation;
            /*0x48*/ float[] duration;
            /*0x50*/ float defaultMix;
            /*0x58*/ UnityEngine.RuntimeAnimatorController controller;
            /*0x60*/ Spine.SkeletonData skeletonData;
            /*0x68*/ Spine.AnimationStateData stateData;

            static /*0x231d4dc*/ Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAssetBase atlasAsset, bool initialize, float scale);
            static /*0x231d5a0*/ Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAssetBase[] atlasAssets, bool initialize, float scale);
            static /*0x231d7a4*/ Spine.SkeletonData ReadSkeletonData(byte[] bytes, Spine.AttachmentLoader attachmentLoader, float scale);
            static /*0x231d94c*/ Spine.SkeletonData ReadSkeletonData(string text, Spine.AttachmentLoader attachmentLoader, float scale);
            /*0x231db64*/ SkeletonDataAsset();
            /*0x231d4bc*/ bool get_IsLoaded();
            /*0x231d4cc*/ void Reset();
            /*0x231d4d4*/ void Clear();
            /*0x2315f88*/ Spine.AnimationStateData GetAnimationStateData();
            /*0x2315658*/ Spine.SkeletonData GetSkeletonData(bool quiet);
            /*0x231da04*/ void InitializeWithData(Spine.SkeletonData sd);
            /*0x231da78*/ void FillStateData();
            /*0x231d638*/ Spine.Atlas[] GetAtlasArray();
        }

        class SkeletonDataCompatibility
        {
            enum SourceType
            {
                Json = 0,
                Binary = 1,
            }

            class VersionInfo
            {
                /*0x10*/ string rawVersion;
                /*0x18*/ int[] version;
                /*0x20*/ Spine.Unity.SkeletonDataCompatibility.SourceType sourceType;

                /*0x2485730*/ VersionInfo();
            }

            class CompatibilityProblemInfo
            {
                /*0x10*/ Spine.Unity.SkeletonDataCompatibility.VersionInfo actualVersion;
                /*0x18*/ int[][] compatibleVersions;

                /*0x2485728*/ CompatibilityProblemInfo();
                /*0x248544c*/ string DescriptionString();
            }
        }

        class SkeletonDataModifierAsset : UnityEngine.ScriptableObject
        {
            /*0x231dc64*/ SkeletonDataModifierAsset();
            void Apply(Spine.SkeletonData skeletonData);
        }

        class SpineAtlasAsset : Spine.Unity.AtlasAssetBase
        {
            /*0x18*/ UnityEngine.TextAsset atlasFile;
            /*0x20*/ UnityEngine.Material[] materials;
            /*0x28*/ Spine.Atlas atlas;

            static /*0x247c1e0*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Material[] materials, bool initialize);
            static /*0x247c27c*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Material materialPropertySource, bool initialize);
            static /*0x247c6ac*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Shader shader, bool initialize);
            /*0x247d068*/ SpineAtlasAsset();
            /*0x247c17c*/ bool get_IsLoaded();
            /*0x247c18c*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            /*0x247c194*/ int get_MaterialCount();
            /*0x247c1ac*/ UnityEngine.Material get_PrimaryMaterial();
            /*0x247c270*/ void Reset();
            /*0x247c798*/ void Clear();
            /*0x247c7a0*/ Spine.Atlas GetAtlas();
            /*0x247cc38*/ UnityEngine.Mesh GenerateMesh(string name, UnityEngine.Mesh mesh, ref UnityEngine.Material material, float scale);
        }

        class MaterialsTextureLoader : Spine.TextureLoader
        {
            /*0x10*/ Spine.Unity.SpineAtlasAsset atlasAsset;

            /*0x25a2520*/ MaterialsTextureLoader(Spine.Unity.SpineAtlasAsset atlasAsset);
            /*0x25a254c*/ void Load(Spine.AtlasPage page, string path);
            /*0x25a2854*/ void Unload(object texture);
        }

        class BoneFollower : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x20*/ string boneName;
            /*0x28*/ bool followXYPosition;
            /*0x29*/ bool followZPosition;
            /*0x2a*/ bool followBoneRotation;
            /*0x2b*/ bool followSkeletonFlip;
            /*0x2c*/ bool followLocalScale;
            /*0x2d*/ bool initializeOnAwake;
            /*0x2e*/ bool valid;
            /*0x30*/ Spine.Bone bone;
            /*0x38*/ UnityEngine.Transform skeletonTransform;
            /*0x40*/ bool skeletonTransformIsParent;

            /*0x225c660*/ BoneFollower();
            /*0x225be94*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x225be9c*/ void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value);
            /*0x225c070*/ bool SetBone(string name);
            /*0x225c14c*/ void Awake();
            /*0x225c160*/ void HandleRebuildRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer);
            /*0x225beac*/ void Initialize(bool isEditorOnly);
            /*0x225c578*/ void OnDestroy();
            /*0x225c168*/ void LateUpdate();
        }

        class BoneFollowerGraphic : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Spine.Unity.SkeletonGraphic skeletonGraphic;
            /*0x20*/ bool initializeOnAwake;
            /*0x28*/ string boneName;
            /*0x30*/ bool followBoneRotation;
            /*0x31*/ bool followSkeletonFlip;
            /*0x32*/ bool followLocalScale;
            /*0x33*/ bool followXYPosition;
            /*0x34*/ bool followZPosition;
            /*0x38*/ Spine.Bone bone;
            /*0x40*/ UnityEngine.Transform skeletonTransform;
            /*0x48*/ bool skeletonTransformIsParent;
            /*0x49*/ bool valid;

            /*0x225cd68*/ BoneFollowerGraphic();
            /*0x225c678*/ Spine.Unity.SkeletonGraphic get_SkeletonGraphic();
            /*0x225c680*/ void set_SkeletonGraphic(Spine.Unity.SkeletonGraphic value);
            /*0x225c798*/ bool SetBone(string name);
            /*0x225c874*/ void Awake();
            /*0x225c688*/ void Initialize();
            /*0x225c884*/ void LateUpdate();
        }

        class BoundingBoxFollower : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ bool DebugMessages;
            /*0x18*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x20*/ string slotName;
            /*0x28*/ bool isTrigger;
            /*0x29*/ bool clearStateOnDisable;
            /*0x30*/ Spine.Slot slot;
            /*0x38*/ Spine.BoundingBoxAttachment currentAttachment;
            /*0x40*/ string currentAttachmentName;
            /*0x48*/ UnityEngine.PolygonCollider2D currentCollider;
            /*0x50*/ System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, UnityEngine.PolygonCollider2D> colliderTable;
            /*0x58*/ System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, string> nameTable;

            static /*0x225e8d8*/ BoundingBoxFollower();
            /*0x225e818*/ BoundingBoxFollower();
            /*0x225d788*/ Spine.Slot get_Slot();
            /*0x225d790*/ Spine.BoundingBoxAttachment get_CurrentAttachment();
            /*0x225d798*/ string get_CurrentAttachmentName();
            /*0x225d7a0*/ UnityEngine.PolygonCollider2D get_CurrentCollider();
            /*0x225d7a8*/ bool get_IsTrigger();
            /*0x225d7b0*/ void Start();
            /*0x225dbf0*/ void OnEnable();
            /*0x225dd10*/ void HandleRebuild(Spine.Unity.SkeletonRenderer sr);
            /*0x225d7b8*/ void Initialize(bool overwrite);
            /*0x225dfbc*/ void AddSkin(Spine.Skin skin, int slotIndex);
            /*0x225e390*/ void OnDisable();
            /*0x225e3a0*/ void ClearState();
            /*0x225dd18*/ void DisposeColliders();
            /*0x225e4e4*/ void LateUpdate();
            /*0x225e504*/ void MatchAttachment(Spine.Attachment attachment);
        }

        class PointFollower : UnityEngine.MonoBehaviour, Spine.Unity.IHasSkeletonRenderer, Spine.Unity.IHasSkeletonComponent
        {
            /*0x18*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x20*/ string slotName;
            /*0x28*/ string pointAttachmentName;
            /*0x30*/ bool followRotation;
            /*0x31*/ bool followSkeletonFlip;
            /*0x32*/ bool followSkeletonZPosition;
            /*0x38*/ UnityEngine.Transform skeletonTransform;
            /*0x40*/ bool skeletonTransformIsParent;
            /*0x48*/ Spine.PointAttachment point;
            /*0x50*/ Spine.Bone bone;
            /*0x58*/ bool valid;

            /*0x23101a0*/ PointFollower();
            /*0x230f960*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x230f968*/ Spine.Unity.ISkeletonComponent get_SkeletonComponent();
            /*0x230f970*/ bool get_IsValid();
            /*0x230f978*/ void Initialize();
            /*0x230fc04*/ void HandleRebuildRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer);
            /*0x230fa18*/ void UpdateReferences();
            /*0x230fde8*/ void LateUpdate();
        }

        class SkeletonAnimation : Spine.Unity.SkeletonRenderer, Spine.Unity.ISkeletonAnimation, Spine.Unity.IAnimationStateComponent
        {
            /*0xd0*/ bool isPassiveUpdate;
            /*0xd8*/ Spine.AnimationState state;
            /*0xe0*/ Spine.Unity.UpdateBonesDelegate _UpdateLocal;
            /*0xe8*/ Spine.Unity.UpdateBonesDelegate _UpdateWorld;
            /*0xf0*/ Spine.Unity.UpdateBonesDelegate _UpdateComplete;
            /*0xf8*/ string _animationName;
            /*0x100*/ bool loop;
            /*0x104*/ float timeScale;

            static /*0x2315d38*/ Spine.Unity.SkeletonAnimation AddToGameObject(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            static /*0x2315dc0*/ Spine.Unity.SkeletonAnimation NewSkeletonAnimationGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            /*0x23160b8*/ SkeletonAnimation();
            /*0x2315140*/ void SetPassiveUpdate(bool isPassive);
            /*0x231514c*/ Spine.AnimationState get_AnimationState();
            /*0x2315154*/ void add__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x23151f4*/ void remove__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315294*/ void add__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315334*/ void remove__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x23153d4*/ void add__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315474*/ void remove__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315514*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315518*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x231551c*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315520*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315524*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x2315528*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x231552c*/ string get_AnimationName();
            /*0x2315578*/ void set_AnimationName(string value);
            /*0x2315e38*/ void ClearState();
            /*0x2315e74*/ void Initialize(bool overwrite);
            /*0x2315fbc*/ void UpdateSkeleton(float _deltaTime);
            /*0x2316084*/ void Update();
            /*0x2315fc0*/ void Update(float deltaTime);
        }

        class SkeletonGraphic : UnityEngine.UI.MaskableGraphic, Spine.Unity.ISkeletonComponent, Spine.Unity.IAnimationStateComponent, Spine.Unity.ISkeletonAnimation, Spine.Unity.IHasSkeletonDataAsset
        {
            /*0xd0*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0xd8*/ string initialSkinName;
            /*0xe0*/ bool initialFlipX;
            /*0xe1*/ bool initialFlipY;
            /*0xe8*/ string startingAnimation;
            /*0xf0*/ bool startingLoop;
            /*0xf4*/ float timeScale;
            /*0xf8*/ bool freeze;
            /*0xf9*/ bool unscaledTime;
            /*0xfa*/ bool passiveUpdate;
            /*0xfc*/ float _inspectorAnimationTime;
            /*0x100*/ UnityEngine.Texture baseTexture;
            /*0x108*/ UnityEngine.Texture overrideTexture;
            /*0x110*/ Spine.Skeleton skeleton;
            /*0x118*/ Spine.AnimationState state;
            /*0x120*/ Spine.Unity.MeshGenerator meshGenerator;
            /*0x128*/ Spine.Unity.DoubleBuffered<Spine.Unity.MeshRendererBuffers.SmartMesh> meshBuffers;
            /*0x130*/ Spine.Unity.SkeletonRendererInstruction currentInstructions;
            /*0x138*/ Spine.Unity.UpdateBonesDelegate UpdateLocal;
            /*0x140*/ Spine.Unity.UpdateBonesDelegate UpdateWorld;
            /*0x148*/ Spine.Unity.UpdateBonesDelegate UpdateComplete;
            /*0x150*/ Spine.Unity.MeshGeneratorDelegate OnPostProcessVertices;

            static /*0x1dc8c24*/ Spine.Unity.SkeletonGraphic NewSkeletonGraphicGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset, UnityEngine.Transform parent, UnityEngine.Material material);
            static /*0x1dc8d28*/ Spine.Unity.SkeletonGraphic AddSkeletonGraphicComponent(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset, UnityEngine.Material material);
            /*0x1dca2e8*/ SkeletonGraphic();
            /*0x1dc8c1c*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x1dc910c*/ UnityEngine.Texture get_OverrideTexture();
            /*0x1dc9114*/ void set_OverrideTexture(UnityEngine.Texture value);
            /*0x1dc9168*/ UnityEngine.Texture get_mainTexture();
            /*0x1dc91ec*/ void Awake();
            /*0x1dc9254*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x1dc9680*/ void Update();
            /*0x1dc96e4*/ void Update(float deltaTime);
            /*0x1dc97b8*/ void LateUpdate();
            /*0x1dc97c8*/ Spine.Skeleton get_Skeleton();
            /*0x1dc97d0*/ void set_Skeleton(Spine.Skeleton value);
            /*0x1dc97d8*/ Spine.SkeletonData get_SkeletonData();
            /*0x1dc9244*/ bool get_IsValid();
            /*0x1dc97f0*/ Spine.AnimationState get_AnimationState();
            /*0x1dc97f8*/ Spine.Unity.MeshGenerator get_MeshGenerator();
            /*0x1dc9800*/ UnityEngine.Mesh GetLastMesh();
            /*0x1dc9860*/ bool MatchRectTransformWithBounds();
            /*0x1dc9a10*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dc9ab4*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dc9b58*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dc9bfc*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dc9ca0*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dc9d44*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dc9de8*/ void add_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x1dc9e8c*/ void remove_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x1dc9f30*/ void Clear();
            /*0x1dc8e08*/ void Initialize(bool overwrite);
            /*0x1dc92b4*/ void UpdateMesh();
        }

        class SkeletonMecanim : Spine.Unity.SkeletonRenderer, Spine.Unity.ISkeletonAnimation
        {
            /*0xd0*/ Spine.Unity.SkeletonMecanim.MecanimTranslator translator;
            /*0xd8*/ Spine.Unity.UpdateBonesDelegate _UpdateLocal;
            /*0xe0*/ Spine.Unity.UpdateBonesDelegate _UpdateWorld;
            /*0xe8*/ Spine.Unity.UpdateBonesDelegate _UpdateComplete;

            /*0x1dd5e94*/ SkeletonMecanim();
            /*0x1dd567c*/ Spine.Unity.SkeletonMecanim.MecanimTranslator get_Translator();
            /*0x1dd5684*/ void add__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5724*/ void remove__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd57c4*/ void add__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5864*/ void remove__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5904*/ void add__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd59a4*/ void remove__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5a44*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5a48*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5a4c*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5a50*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5a54*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5a58*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x1dd5a5c*/ void Initialize(bool overwrite);
            /*0x1dd5df4*/ void Update();

            class MecanimTranslator
            {
                /*0x10*/ bool autoReset;
                /*0x18*/ Spine.Unity.SkeletonMecanim.MecanimTranslator.MixMode[] layerMixModes;
                /*0x20*/ Spine.MixBlend[] layerBlendModes;
                /*0x28*/ System.Collections.Generic.Dictionary<int, Spine.Animation> animationTable;
                /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.AnimationClip, int> clipNameHashCodeTable;
                /*0x38*/ System.Collections.Generic.List<Spine.Animation> previousAnimations;
                /*0x40*/ Spine.Unity.SkeletonMecanim.MecanimTranslator.ClipInfos[] layerClipInfos;
                /*0x48*/ UnityEngine.Animator animator;

                static /*0x2487664*/ float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed);
                static /*0x24876b8*/ float AnimationTime(float normalizedTime, float clipLength, bool reversed);
                /*0x24877a4*/ MecanimTranslator();
                /*0x2485794*/ UnityEngine.Animator get_Animator();
                /*0x248579c*/ void Initialize(UnityEngine.Animator animator, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
                /*0x2485b78*/ void Apply(Spine.Skeleton skeleton);
                /*0x2486fec*/ void InitClipInfosForLayers();
                /*0x24859bc*/ void ClearClipInfosForLayers();
                /*0x2487140*/ void GetStateUpdatesFromAnimator(int layer);
                /*0x2487438*/ void GetAnimatorClipInfos(int layer, ref bool isInterruptionActive, ref int clipInfoCount, ref int nextClipInfoCount, ref int interruptingClipInfoCount, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> clipInfo, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> nextClipInfo, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> interruptingClipInfo, ref bool shallInterpolateWeightTo1);
                /*0x24875cc*/ void GetAnimatorStateInfos(int layer, ref bool isInterruptionActive, ref UnityEngine.AnimatorStateInfo stateInfo, ref UnityEngine.AnimatorStateInfo nextStateInfo, ref UnityEngine.AnimatorStateInfo interruptingStateInfo, ref float interruptingClipTimeAddition);
                /*0x24874d0*/ Spine.Animation GetAnimation(UnityEngine.AnimationClip clip);

                enum MixMode
                {
                    AlwaysMix = 0,
                    MixNext = 1,
                    Hard = 2,
                }

                class ClipInfos
                {
                    /*0x10*/ bool isInterruptionActive;
                    /*0x11*/ bool isLastFrameOfInterruption;
                    /*0x14*/ int clipInfoCount;
                    /*0x18*/ int nextClipInfoCount;
                    /*0x1c*/ int interruptingClipInfoCount;
                    /*0x20*/ System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clipInfos;
                    /*0x28*/ System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> nextClipInfos;
                    /*0x30*/ System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> interruptingClipInfos;
                    /*0x38*/ UnityEngine.AnimatorStateInfo stateInfo;
                    /*0x5c*/ UnityEngine.AnimatorStateInfo nextStateInfo;
                    /*0x80*/ UnityEngine.AnimatorStateInfo interruptingStateInfo;
                    /*0xa4*/ float interruptingClipTimeAddition;

                    /*0x24876f4*/ ClipInfos();
                }

                class AnimationClipEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.AnimationClip>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<UnityEngine.AnimationClip> Instance;

                    static /*0x248884c*/ AnimationClipEqualityComparer();
                    /*0x2488844*/ AnimationClipEqualityComparer();
                    /*0x24887dc*/ bool Equals(UnityEngine.AnimationClip x, UnityEngine.AnimationClip y);
                    /*0x2488828*/ int GetHashCode(UnityEngine.AnimationClip o);
                }

                class IntEqualityComparer : System.Collections.Generic.IEqualityComparer<int>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<int> Instance;

                    static /*0x24888c8*/ IntEqualityComparer();
                    /*0x24888c0*/ IntEqualityComparer();
                    /*0x24888ac*/ bool Equals(int x, int y);
                    /*0x24888b8*/ int GetHashCode(int o);
                }
            }
        }

        class SkeletonPartsRenderer : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Spine.Unity.MeshGenerator meshGenerator;
            /*0x20*/ UnityEngine.MeshRenderer meshRenderer;
            /*0x28*/ UnityEngine.MeshFilter meshFilter;
            /*0x30*/ Spine.Unity.MeshRendererBuffers buffers;
            /*0x38*/ Spine.Unity.SkeletonRendererInstruction currentInstructions;

            static /*0x1dd6894*/ Spine.Unity.SkeletonPartsRenderer NewPartsRendererGameObject(UnityEngine.Transform parent, string name, int sortingOrder);
            /*0x1dd6a80*/ SkeletonPartsRenderer();
            /*0x1dd60d4*/ Spine.Unity.MeshGenerator get_MeshGenerator();
            /*0x1dd6204*/ UnityEngine.MeshRenderer get_MeshRenderer();
            /*0x1dd6228*/ UnityEngine.MeshFilter get_MeshFilter();
            /*0x1dd60f8*/ void LazyIntialize();
            /*0x1dd62d8*/ void ClearMesh();
            /*0x1dd630c*/ void RenderParts(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
            /*0x1dd685c*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock block);
        }

        class SkeletonRenderSeparator : UnityEngine.MonoBehaviour
        {
            static int DefaultSortingOrderIncrement = 5;
            /*0x18*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x20*/ UnityEngine.MeshRenderer mainMeshRenderer;
            /*0x28*/ bool copyPropertyBlock;
            /*0x29*/ bool copyMeshRendererFlags;
            /*0x30*/ System.Collections.Generic.List<Spine.Unity.SkeletonPartsRenderer> partsRenderers;
            /*0x38*/ UnityEngine.MaterialPropertyBlock copiedBlock;

            static /*0x1dd6c80*/ Spine.Unity.SkeletonRenderSeparator AddToSkeletonRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer, int sortingLayerID, int extraPartsRenderers, int sortingOrderIncrement, int baseSortingOrder, bool addMinimumPartsRenderers);
            /*0x1dd77d8*/ SkeletonRenderSeparator();
            /*0x1dd6ae0*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x1dd6ae8*/ void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value);
            /*0x1dd71c8*/ Spine.Unity.SkeletonPartsRenderer AddPartsRenderer(int sortingOrderIncrement, string name);
            /*0x1dd6eb8*/ void OnEnable();
            /*0x1dd73a8*/ void OnDisable();
            /*0x1dd7574*/ void HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
        }

        class SkeletonRenderer : UnityEngine.MonoBehaviour, Spine.Unity.ISkeletonComponent, Spine.Unity.IHasSkeletonDataAsset
        {
            static UnityEngine.Rendering.CompareFunction STENCIL_COMP_MASKINTERACTION_NONE = 8;
            static UnityEngine.Rendering.CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_INSIDE = 4;
            static UnityEngine.Rendering.CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_OUTSIDE = 5;
            static /*0x0*/ int STENCIL_COMP_PARAM_ID;
            static /*0x4*/ int SUBMESH_DUMMY_PARAM_ID;
            /*0x18*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x20*/ string initialSkinName;
            /*0x28*/ bool initialFlipX;
            /*0x29*/ bool initialFlipY;
            /*0x30*/ string[] separatorSlotNames;
            /*0x38*/ System.Collections.Generic.List<Spine.Slot> separatorSlots;
            /*0x40*/ float zSpacing;
            /*0x44*/ bool useClipping;
            /*0x45*/ bool immutableTriangles;
            /*0x46*/ bool pmaVertexColors;
            /*0x47*/ bool clearStateOnDisable;
            /*0x48*/ bool tintBlack;
            /*0x49*/ bool singleSubmesh;
            /*0x4a*/ bool fixDrawOrder;
            /*0x4b*/ bool addNormals;
            /*0x4c*/ bool calculateTangents;
            /*0x50*/ UnityEngine.SpriteMaskInteraction maskInteraction;
            /*0x58*/ Spine.Unity.SkeletonRenderer.SpriteMaskInteractionMaterials maskMaterials;
            /*0x60*/ bool disableRenderingOnOverride;
            /*0x68*/ Spine.Unity.SkeletonRenderer.InstructionDelegate generateMeshOverride;
            /*0x70*/ Spine.Unity.MeshGeneratorDelegate OnPostProcessVertices;
            /*0x78*/ System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> customMaterialOverride;
            /*0x80*/ System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> customSlotMaterials;
            /*0x88*/ Spine.Unity.SkeletonRendererInstruction currentInstructions;
            /*0x90*/ Spine.Unity.MeshGenerator meshGenerator;
            /*0x98*/ Spine.Unity.MeshRendererBuffers rendererBuffers;
            /*0xa0*/ UnityEngine.MeshRenderer meshRenderer;
            /*0xa8*/ UnityEngine.MeshFilter meshFilter;
            /*0xb0*/ bool valid;
            /*0xb8*/ Spine.Skeleton skeleton;
            /*0xc0*/ Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate OnRebuild;
            /*0xc8*/ UnityEngine.MaterialPropertyBlock reusedPropertyBlock;

            static /*0x1dd8f1c*/ SkeletonRenderer();
            static T NewSpineGameObject<T>(Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            static T AddSpineComponent<T>(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            /*0x1dd5ef4*/ SkeletonRenderer();
            /*0x1dd7858*/ void add_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x1dd78f8*/ void remove_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x1dd7344*/ void add_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x1dd6c1c*/ void remove_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x1dd7998*/ void add_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x1dd7a38*/ void remove_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x1dd7ad8*/ System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> get_CustomMaterialOverride();
            /*0x1dd7ae0*/ System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> get_CustomSlotMaterials();
            /*0x1dd7ae8*/ Spine.Skeleton get_Skeleton();
            /*0x1dd7b18*/ void add_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x1dd7bb8*/ void remove_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x1dd7c58*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x1dd7c60*/ void SetMeshSettings(Spine.Unity.MeshGenerator.Settings settings);
            /*0x1dd7cc0*/ void Awake();
            /*0x1dd7cd0*/ void OnDisable();
            /*0x1dd7cf0*/ void OnDestroy();
            /*0x1dd7d24*/ void ClearState();
            /*0x1dd7df8*/ void EnsureMeshGeneratorCapacity(int minimumVertexCount);
            /*0x1dd5b34*/ void Initialize(bool overwrite);
            /*0x1dd7e20*/ void LateUpdate();
            /*0x1dd873c*/ void FindAndApplySeparatorSlots(string startsWith, bool clearExistingSeparators, bool updateStringArray);
            /*0x1dd8848*/ void FindAndApplySeparatorSlots(System.Func<string, bool> slotNamePredicate, bool clearExistingSeparators, bool updateStringArray);
            /*0x1dd8c44*/ void ReapplySeparatorSlotNames();
            /*0x1dd8398*/ void AssignSpriteMaskMaterials();
            /*0x1dd8d38*/ bool InitSpriteMaskMaterialsInsideMask();
            /*0x1dd8d64*/ bool InitSpriteMaskMaterialsOutsideMask();
            /*0x1dd8d90*/ bool InitSpriteMaskMaterialsForMaskType(UnityEngine.Rendering.CompareFunction maskFunction, ref UnityEngine.Material[] materialsToFill);
            /*0x1dd85a0*/ void SetMaterialSettingsToFixDrawOrder();

            class SpriteMaskInteractionMaterials
            {
                /*0x10*/ UnityEngine.Material[] materialsMaskDisabled;
                /*0x18*/ UnityEngine.Material[] materialsInsideMask;
                /*0x20*/ UnityEngine.Material[] materialsOutsideMask;

                /*0x248821c*/ SpriteMaskInteractionMaterials();
                /*0x24881cc*/ bool get_AnyMaterialCreated();
            }

            class InstructionDelegate : System.MulticastDelegate
            {
                /*0x24879bc*/ InstructionDelegate(object object, nint method);
                /*0x2487a1c*/ void Invoke(Spine.Unity.SkeletonRendererInstruction instruction);
                /*0x2487d94*/ System.IAsyncResult BeginInvoke(Spine.Unity.SkeletonRendererInstruction instruction, System.AsyncCallback callback, object object);
                /*0x2487db8*/ void EndInvoke(System.IAsyncResult result);
            }

            class SkeletonRendererDelegate : System.MulticastDelegate
            {
                /*0x2487dc4*/ SkeletonRendererDelegate(object object, nint method);
                /*0x2487e24*/ void Invoke(Spine.Unity.SkeletonRenderer skeletonRenderer);
                /*0x248819c*/ System.IAsyncResult BeginInvoke(Spine.Unity.SkeletonRenderer skeletonRenderer, System.AsyncCallback callback, object object);
                /*0x24881c0*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ string startsWith;

                /*0x2487990*/ <>c__DisplayClass65_0();
                /*0x2487998*/ bool <FindAndApplySeparatorSlots>b__0(string slotName);
            }
        }

        class SkeletonRendererCustomMaterials : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x20*/ System.Collections.Generic.List<Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride> customSlotMaterials;
            /*0x28*/ System.Collections.Generic.List<Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;

            /*0x1dd990c*/ SkeletonRendererCustomMaterials();
            /*0x1dd8fb4*/ void SetCustomSlotMaterials();
            /*0x1dd9164*/ void RemoveCustomSlotMaterials();
            /*0x1dd937c*/ void SetCustomMaterialOverrides();
            /*0x1dd94f8*/ void RemoveCustomMaterialOverrides();
            /*0x1dd96e0*/ void OnEnable();
            /*0x1dd9838*/ void OnDisable();

            struct SlotMaterialOverride : System.IEquatable<Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride>
            {
                /*0x10*/ bool overrideDisabled;
                /*0x18*/ string slotName;
                /*0x20*/ UnityEngine.Material material;

                /*0xae68f8*/ bool Equals(Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride other);
            }

            struct AtlasMaterialOverride : System.IEquatable<Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride>
            {
                /*0x10*/ bool overrideDisabled;
                /*0x18*/ UnityEngine.Material originalMaterial;
                /*0x20*/ UnityEngine.Material replacementMaterial;

                /*0xae6884*/ bool Equals(Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride other);
            }
        }

        class ActivateBasedOnFlipDirection : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x20*/ UnityEngine.GameObject activeOnNormalX;
            /*0x28*/ UnityEngine.GameObject activeOnFlippedX;
            /*0x30*/ UnityEngine.HingeJoint2D[] jointsNormalX;
            /*0x38*/ UnityEngine.HingeJoint2D[] jointsFlippedX;
            /*0x40*/ bool wasFlippedXBefore;

            /*0x224eaf0*/ ActivateBasedOnFlipDirection();
            /*0x224e7a4*/ void Start();
            /*0x224e818*/ void FixedUpdate();
            /*0x224e890*/ void HandleFlip(bool isFlippedX);
            /*0x224e94c*/ void ResetJointPositions(UnityEngine.HingeJoint2D[] joints);
            /*0x224ea1c*/ void CompensateMovementAfterFlipX(UnityEngine.Transform toActivate, UnityEngine.Transform toDeactivate);
        }

        class FollowLocationRigidbody : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.Transform reference;
            /*0x20*/ UnityEngine.Rigidbody ownRigidbody;

            /*0x259eff4*/ FollowLocationRigidbody();
            /*0x259ef3c*/ void Awake();
            /*0x259ef90*/ void FixedUpdate();
        }

        class FollowLocationRigidbody2D : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.Transform reference;
            /*0x20*/ bool followFlippedX;
            /*0x28*/ UnityEngine.Rigidbody2D ownRigidbody;

            /*0x259f11c*/ FollowLocationRigidbody2D();
            /*0x259effc*/ void Awake();
            /*0x259f050*/ void FixedUpdate();
        }

        class FollowSkeletonUtilityRootRotation : UnityEngine.MonoBehaviour
        {
            static float FLIP_ANGLE_THRESHOLD = 100;
            /*0x18*/ UnityEngine.Transform reference;
            /*0x20*/ UnityEngine.Vector3 prevLocalEulerAngles;

            /*0x259f3ec*/ FollowSkeletonUtilityRootRotation();
            /*0x259f124*/ void Start();
            /*0x259f160*/ void FixedUpdate();
            /*0x259f244*/ void CompensatePositionToYRotation();
            /*0x259f318*/ void CompensatePositionToXRotation();
        }

        class SkeletonUtility : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate OnReset;
            /*0x20*/ UnityEngine.Transform boneRoot;
            /*0x28*/ bool flipBy180DegreeRotation;
            /*0x30*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x38*/ Spine.Unity.ISkeletonAnimation skeletonAnimation;
            /*0x40*/ System.Collections.Generic.List<Spine.Unity.SkeletonUtilityBone> boneComponents;
            /*0x48*/ System.Collections.Generic.List<Spine.Unity.SkeletonUtilityConstraint> constraintComponents;
            /*0x50*/ bool hasOverrideBones;
            /*0x51*/ bool hasConstraints;
            /*0x52*/ bool needToReprocessBones;

            static /*0x1dd9a1c*/ UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(Spine.Skeleton skeleton, string skinName, string slotName, string attachmentName, UnityEngine.Transform parent, bool isTrigger);
            static /*0x1dd9d5c*/ UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(string name, Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.Transform parent, bool isTrigger);
            static /*0x1dd9e94*/ UnityEngine.PolygonCollider2D AddBoundingBoxAsComponent(Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.GameObject gameObject, bool isTrigger);
            static /*0x1dd9f3c*/ void SetColliderPointsLocal(UnityEngine.PolygonCollider2D collider, Spine.Slot slot, Spine.BoundingBoxAttachment box);
            static /*0x1dda014*/ UnityEngine.Bounds GetBoundingBoxBounds(Spine.BoundingBoxAttachment boundingBox, float depth);
            static /*0x1dda114*/ UnityEngine.Rigidbody2D AddBoneRigidbody2D(UnityEngine.GameObject gameObject, bool isKinematic, float gravityScale);
            /*0x1ddc288*/ SkeletonUtility();
            /*0x1dda214*/ void add_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value);
            /*0x1dda2b4*/ void remove_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value);
            /*0x1dda354*/ void Update();
            /*0x1dda4a4*/ void ResubscribeEvents();
            /*0x1dda77c*/ void OnEnable();
            /*0x1ddb044*/ void Start();
            /*0x1dda4c8*/ void OnDisable();
            /*0x1ddb048*/ void HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            /*0x1ddb078*/ void RegisterBone(Spine.Unity.SkeletonUtilityBone bone);
            /*0x1ddb114*/ void UnregisterBone(Spine.Unity.SkeletonUtilityBone bone);
            /*0x1ddb178*/ void RegisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint);
            /*0x1ddb214*/ void UnregisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint);
            /*0x1ddaa80*/ void CollectBones();
            /*0x1ddb948*/ void UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
            /*0x1ddbb1c*/ void UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
            /*0x1ddbbd8*/ void UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
            /*0x1ddba1c*/ void UpdateAllBones(Spine.Unity.SkeletonUtilityBone.UpdatePhase phase);
            /*0x1ddbbe0*/ UnityEngine.Transform GetBoneRoot();
            /*0x1ddbd28*/ UnityEngine.GameObject SpawnRoot(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x1ddbf58*/ UnityEngine.GameObject SpawnHierarchy(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x1ddbfe4*/ UnityEngine.GameObject SpawnBoneRecursively(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x1ddbdb4*/ UnityEngine.GameObject SpawnBone(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);

            class SkeletonUtilityDelegate : System.MulticastDelegate
            {
                /*0x248844c*/ SkeletonUtilityDelegate(object object, nint method);
                /*0x24884ac*/ void Invoke();
                /*0x24886b8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x24886e4*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class SkeletonUtilityBone : UnityEngine.MonoBehaviour
        {
            /*0x18*/ string boneName;
            /*0x20*/ UnityEngine.Transform parentReference;
            /*0x28*/ Spine.Unity.SkeletonUtilityBone.Mode mode;
            /*0x2c*/ bool position;
            /*0x2d*/ bool rotation;
            /*0x2e*/ bool scale;
            /*0x2f*/ bool zPosition;
            /*0x30*/ float overrideAlpha;
            /*0x38*/ Spine.Unity.SkeletonUtility hierarchy;
            /*0x40*/ Spine.Bone bone;
            /*0x48*/ bool transformLerpComplete;
            /*0x49*/ bool valid;
            /*0x50*/ UnityEngine.Transform cachedTransform;
            /*0x58*/ UnityEngine.Transform skeletonTransform;
            /*0x60*/ bool incompatibleTransformMode;

            static /*0x1ddc59c*/ bool BoneTransformModeIncompatible(Spine.Bone bone);
            /*0x1ddc65c*/ SkeletonUtilityBone();
            /*0x1ddc340*/ bool get_IncompatibleTransformMode();
            /*0x1ddc0dc*/ void Reset();
            /*0x1ddc348*/ void OnEnable();
            /*0x1ddc4a4*/ void HandleOnReset();
            /*0x1ddc4a8*/ void OnDisable();
            /*0x1ddb278*/ void DoUpdate(Spine.Unity.SkeletonUtilityBone.UpdatePhase phase);
            /*0x1ddc5d0*/ void AddBoundingBox(string skinName, string slotName, string attachmentName);

            enum Mode
            {
                Follow = 0,
                Override = 1,
            }

            enum UpdatePhase
            {
                Local = 0,
                World = 1,
                Complete = 2,
            }
        }

        class SkeletonUtilityConstraint : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Spine.Unity.SkeletonUtilityBone bone;
            /*0x20*/ Spine.Unity.SkeletonUtility hierarchy;

            /*0x1ddc720*/ SkeletonUtilityConstraint();
            /*0x1ddc674*/ void OnEnable();
            /*0x1ddc704*/ void OnDisable();
            void DoUpdate();
        }

        class UpdateBonesDelegate : System.MulticastDelegate
        {
            /*0x2482980*/ UpdateBonesDelegate(object object, nint method);
            /*0x24829e0*/ void Invoke(Spine.Unity.ISkeletonAnimation animated);
            /*0x2482d58*/ System.IAsyncResult BeginInvoke(Spine.Unity.ISkeletonAnimation animated, System.AsyncCallback callback, object object);
            /*0x2482d7c*/ void EndInvoke(System.IAsyncResult result);
        }

        interface ISkeletonAnimation
        {
            void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            Spine.Skeleton get_Skeleton();
        }

        interface IHasSkeletonDataAsset
        {
            Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
        }

        interface ISkeletonComponent
        {
            Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            Spine.Skeleton get_Skeleton();
        }

        interface IAnimationStateComponent
        {
            Spine.AnimationState get_AnimationState();
        }

        interface IHasSkeletonRenderer
        {
            Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
        }

        interface IHasSkeletonComponent
        {
            Spine.Unity.ISkeletonComponent get_SkeletonComponent();
        }

        class DoubleBuffered<T>
        {
            /*0x0*/ T a;
            /*0x0*/ T b;
            /*0x0*/ bool usingA;

            DoubleBuffered();
            T GetCurrent();
            T GetNext();
        }

        class MeshGeneratorDelegate : System.MulticastDelegate
        {
            /*0x25a8734*/ MeshGeneratorDelegate(object object, nint method);
            /*0x25a8794*/ void Invoke(Spine.Unity.MeshGeneratorBuffers buffers);
            /*0x25a8a98*/ System.IAsyncResult BeginInvoke(Spine.Unity.MeshGeneratorBuffers buffers, System.AsyncCallback callback, object object);
            /*0x25a8b28*/ void EndInvoke(System.IAsyncResult result);
        }

        struct MeshGeneratorBuffers
        {
            /*0x10*/ int vertexCount;
            /*0x18*/ UnityEngine.Vector3[] vertexBuffer;
            /*0x20*/ UnityEngine.Vector2[] uvBuffer;
            /*0x28*/ UnityEngine.Color32[] colorBuffer;
            /*0x30*/ Spine.Unity.MeshGenerator meshGenerator;
        }

        class MeshGenerator
        {
            static float BoundsMinDefault = Infinity;
            static float BoundsMaxDefault = -Infinity;
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Vector3> AttachmentVerts;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Vector2> AttachmentUVs;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.Color32> AttachmentColors32;
            static /*0x18*/ System.Collections.Generic.List<int> AttachmentIndices;
            /*0x10*/ Spine.Unity.MeshGenerator.Settings settings;
            /*0x20*/ Spine.ExposedList<UnityEngine.Vector3> vertexBuffer;
            /*0x28*/ Spine.ExposedList<UnityEngine.Vector2> uvBuffer;
            /*0x30*/ Spine.ExposedList<UnityEngine.Color32> colorBuffer;
            /*0x38*/ Spine.ExposedList<Spine.ExposedList<int>> submeshes;
            /*0x40*/ UnityEngine.Vector2 meshBoundsMin;
            /*0x48*/ UnityEngine.Vector2 meshBoundsMax;
            /*0x50*/ float meshBoundsThickness;
            /*0x54*/ int submeshIndex;
            /*0x58*/ Spine.SkeletonClipping clipper;
            /*0x60*/ float[] tempVerts;
            /*0x68*/ int[] regionTriangles;
            /*0x70*/ UnityEngine.Vector3[] normals;
            /*0x78*/ UnityEngine.Vector4[] tangents;
            /*0x80*/ UnityEngine.Vector2[] tempTanBuffer;
            /*0x88*/ Spine.ExposedList<UnityEngine.Vector2> uv2;
            /*0x90*/ Spine.ExposedList<UnityEngine.Vector2> uv3;

            static /*0x25a85d4*/ MeshGenerator();
            static /*0x25a399c*/ void GenerateSingleSubmeshInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, UnityEngine.Material material);
            static /*0x25a3e00*/ void GenerateSkeletonRendererInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> customSlotMaterials, System.Collections.Generic.List<Spine.Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles);
            static /*0x25a4790*/ void TryReplaceMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> workingSubmeshInstructions, System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> customMaterialOverride);
            static /*0x25a71ec*/ void SolveTangents2DEnsureSize(ref UnityEngine.Vector4[] tangentBuffer, ref UnityEngine.Vector2[] tempTanBuffer, int vertexCount, int vertexBufferLength);
            static /*0x25a72b0*/ void SolveTangents2DTriangles(UnityEngine.Vector2[] tempTanBuffer, int[] triangles, int triangleCount, UnityEngine.Vector3[] vertices, UnityEngine.Vector2[] uvs, int vertexCount);
            static /*0x25a7490*/ void SolveTangents2DBuffer(UnityEngine.Vector4[] tangents, UnityEngine.Vector2[] tempTanBuffer, int vertexCount);
            static /*0x25a79ec*/ void FillMeshLocal(UnityEngine.Mesh mesh, Spine.RegionAttachment regionAttachment);
            static /*0x25a7f4c*/ void FillMeshLocal(UnityEngine.Mesh mesh, Spine.MeshAttachment meshAttachment, Spine.SkeletonData skeletonData);
            /*0x25a371c*/ MeshGenerator();
            /*0x25a36b8*/ int get_VertexCount();
            /*0x25a36d4*/ Spine.Unity.MeshGeneratorBuffers get_Buffers();
            /*0x25a4874*/ void Begin();
            /*0x25a4950*/ void AddSubmesh(Spine.Unity.SubmeshInstruction instruction, bool updateTriangles);
            /*0x25a57d0*/ void BuildMesh(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles);
            /*0x25a5878*/ void BuildMeshWithArrays(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles);
            /*0x25a6c54*/ void ScaleVertexData(float scale);
            /*0x25a55f4*/ void AddAttachmentTintBlack(float r2, float g2, float b2, int vertexCount);
            /*0x25a6ce4*/ void FillVertexData(UnityEngine.Mesh mesh);
            /*0x25a700c*/ void FillLateVertexData(UnityEngine.Mesh mesh);
            /*0x25a75c0*/ void FillTriangles(UnityEngine.Mesh mesh);
            /*0x25a766c*/ void EnsureVertexCapacity(int minimumVertexCount, bool inlcudeTintBlack, bool includeTangents, bool includeNormals);
            /*0x25a78b8*/ void TrimExcess();

            struct Settings
            {
                /*0x10*/ bool useClipping;
                /*0x14*/ float zSpacing;
                /*0x18*/ bool pmaVertexColors;
                /*0x19*/ bool tintBlack;
                /*0x1a*/ bool calculateTangents;
                /*0x1b*/ bool addNormals;
                /*0x1c*/ bool immutableTriangles;

                static /*0x2484a48*/ Spine.Unity.MeshGenerator.Settings get_Default();
            }
        }

        class MeshRendererBuffers : System.IDisposable
        {
            /*0x10*/ Spine.Unity.DoubleBuffered<Spine.Unity.MeshRendererBuffers.SmartMesh> doubleBufferedMesh;
            /*0x18*/ Spine.ExposedList<UnityEngine.Material> submeshMaterials;
            /*0x20*/ UnityEngine.Material[] sharedMaterials;

            /*0x25a8fe0*/ MeshRendererBuffers();
            /*0x25a8b34*/ void Initialize();
            /*0x25a8c24*/ UnityEngine.Material[] GetUpdatedSharedMaterialsArray();
            /*0x25a8cbc*/ bool MaterialsChangedInLastUpdate();
            /*0x25a8d54*/ void UpdateSharedMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions);
            /*0x25a8e88*/ Spine.Unity.MeshRendererBuffers.SmartMesh GetNextMesh();
            /*0x25a8edc*/ void Clear();
            /*0x25a8f5c*/ void Dispose();

            class SmartMesh : System.IDisposable
            {
                /*0x10*/ UnityEngine.Mesh mesh;
                /*0x18*/ Spine.Unity.SkeletonRendererInstruction instructionUsed;

                /*0x2484b38*/ SmartMesh();
                /*0x2484a54*/ void Clear();
                /*0x2484a90*/ void Dispose();
            }
        }

        class SkeletonRendererInstruction
        {
            /*0x10*/ Spine.ExposedList<Spine.Unity.SubmeshInstruction> submeshInstructions;
            /*0x18*/ bool immutableTriangles;
            /*0x19*/ bool hasActiveClipping;
            /*0x1c*/ int rawVertexCount;
            /*0x20*/ Spine.ExposedList<Spine.Attachment> attachments;

            static /*0x1dc9f58*/ bool GeometryNotEqual(Spine.Unity.SkeletonRendererInstruction a, Spine.Unity.SkeletonRendererInstruction b);
            /*0x1dca37c*/ SkeletonRendererInstruction();
            /*0x1dd624c*/ void Clear();
            /*0x1dd99c4*/ void Dispose();
            /*0x1dd6550*/ void SetWithSubset(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
            /*0x1dca110*/ void Set(Spine.Unity.SkeletonRendererInstruction other);
        }

        class SpineMesh
        {
            static UnityEngine.HideFlags MeshHideflags = 20;

            static /*0x247d590*/ UnityEngine.Mesh NewSkeletonMesh();
        }

        struct SubmeshInstruction
        {
            /*0x10*/ Spine.Skeleton skeleton;
            /*0x18*/ int startSlot;
            /*0x1c*/ int endSlot;
            /*0x20*/ UnityEngine.Material material;
            /*0x28*/ bool forceSeparate;
            /*0x2c*/ int preActiveClippingSlotSource;
            /*0x30*/ int rawTriangleCount;
            /*0x34*/ int rawVertexCount;
            /*0x38*/ int rawFirstVertexIndex;
            /*0x3c*/ bool hasClipping;

            /*0xae66a4*/ int get_SlotCount();
            /*0xae66b0*/ string ToString();
        }

        class BlendModeMaterialsAsset : Spine.Unity.SkeletonDataModifierAsset
        {
            /*0x18*/ UnityEngine.Material multiplyMaterialTemplate;
            /*0x20*/ UnityEngine.Material screenMaterialTemplate;
            /*0x28*/ UnityEngine.Material additiveMaterialTemplate;
            /*0x30*/ bool applyAdditiveMaterial;

            static /*0x225a014*/ void ApplyMaterials(Spine.SkeletonData skeletonData, UnityEngine.Material multiplyTemplate, UnityEngine.Material screenTemplate, UnityEngine.Material additiveTemplate, bool includeAdditiveSlots);
            /*0x225a7cc*/ BlendModeMaterialsAsset();
            /*0x2259ffc*/ void Apply(Spine.SkeletonData skeletonData);

            class AtlasMaterialCache : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<Spine.AtlasPage, UnityEngine.Material>, Spine.AtlasPage> cache;

                /*0x24849c4*/ AtlasMaterialCache();
                /*0x24846dc*/ Spine.AtlasRegion CloneAtlasRegionWithMaterial(Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate);
                /*0x248473c*/ Spine.AtlasPage GetAtlasPageWithMaterial(Spine.AtlasPage originalPage, UnityEngine.Material materialTemplate);
                /*0x2484970*/ void Dispose();
            }
        }

        class SpineAttributeBase : UnityEngine.PropertyAttribute
        {
            /*0x10*/ string dataField;
            /*0x18*/ string startsWith;
            /*0x20*/ bool includeNone;
            /*0x21*/ bool fallbackToTextField;

            /*0x247c120*/ SpineAttributeBase();
        }

        class SpineBone : Spine.Unity.SpineAttributeBase
        {
            static /*0x247d46c*/ Spine.Bone GetBone(string boneName, Spine.Unity.SkeletonRenderer renderer);
            static /*0x247d498*/ Spine.BoneData GetBoneData(string boneName, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            /*0x247d418*/ SpineBone(string startsWith, string dataField, bool includeNone, bool fallbackToTextField);
        }

        class SpineSlot : Spine.Unity.SpineAttributeBase
        {
            /*0x22*/ bool containsBoundingBoxes;

            /*0x247d6e4*/ SpineSlot(string startsWith, string dataField, bool containsBoundingBoxes, bool includeNone, bool fallbackToTextField);
        }

        class SpineAnimation : Spine.Unity.SpineAttributeBase
        {
            /*0x247c0cc*/ SpineAnimation(string startsWith, string dataField, bool includeNone, bool fallbackToTextField);
        }

        class SpineEvent : Spine.Unity.SpineAttributeBase
        {
            /*0x22*/ bool audioOnly;

            /*0x247d4dc*/ SpineEvent(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool audioOnly);
        }

        class SpineIkConstraint : Spine.Unity.SpineAttributeBase
        {
            /*0x247d53c*/ SpineIkConstraint(string startsWith, string dataField, bool includeNone, bool fallbackToTextField);
        }

        class SpineTransformConstraint : Spine.Unity.SpineAttributeBase
        {
            /*0x247d744*/ SpineTransformConstraint(string startsWith, string dataField, bool includeNone, bool fallbackToTextField);
        }

        class SpinePathConstraint : Spine.Unity.SpineAttributeBase
        {
            /*0x247d630*/ SpinePathConstraint(string startsWith, string dataField, bool includeNone, bool fallbackToTextField);
        }

        class SpineSkin : Spine.Unity.SpineAttributeBase
        {
            /*0x22*/ bool defaultAsEmptyString;

            /*0x247d684*/ SpineSkin(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool defaultAsEmptyString);
        }

        class SpineAttachment : Spine.Unity.SpineAttributeBase
        {
            /*0x22*/ bool returnAttachmentPath;
            /*0x23*/ bool currentSkinOnly;
            /*0x24*/ bool placeholdersOnly;
            /*0x28*/ string skinField;
            /*0x30*/ string slotField;

            static /*0x247d160*/ Spine.Unity.SpineAttachment.Hierarchy GetHierarchy(string fullPath);
            static /*0x247d328*/ Spine.Attachment GetAttachment(string attachmentPath, Spine.SkeletonData skeletonData);
            static /*0x247d3d8*/ Spine.Attachment GetAttachment(string attachmentPath, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            /*0x247d09c*/ SpineAttachment(bool currentSkinOnly, bool returnAttachmentPath, bool placeholdersOnly, string slotField, string dataField, string skinField, bool includeNone, bool fallbackToTextField);

            struct Hierarchy
            {
                /*0x10*/ string skin;
                /*0x18*/ string slot;
                /*0x20*/ string name;

                /*0xae6ae4*/ Hierarchy(string fullPath);
            }
        }

        class SpineAtlasRegion : UnityEngine.PropertyAttribute
        {
            /*0x10*/ string atlasAssetField;

            /*0x247d070*/ SpineAtlasRegion(string atlasAssetField);
        }

        class SkeletonExtensions
        {
            static float ByteToFloat = 0.003921568859368563;

            static /*0x1dc7f2c*/ UnityEngine.Color GetColor(Spine.Skeleton s);
            static /*0x1dc7f6c*/ UnityEngine.Color GetColor(Spine.RegionAttachment a);
            static /*0x1dc7fac*/ UnityEngine.Color GetColor(Spine.MeshAttachment a);
            static /*0x1dc7fec*/ UnityEngine.Color GetColor(Spine.Slot s);
            static /*0x1dc802c*/ UnityEngine.Color GetColorTintBlack(Spine.Slot s);
            static /*0x1dc8070*/ void SetColor(Spine.Skeleton skeleton, UnityEngine.Color color);
            static /*0x1dc808c*/ void SetColor(Spine.Skeleton skeleton, UnityEngine.Color32 color);
            static /*0x1dc80dc*/ void SetColor(Spine.Slot slot, UnityEngine.Color color);
            static /*0x1dc80f8*/ void SetColor(Spine.Slot slot, UnityEngine.Color32 color);
            static /*0x1dc8148*/ void SetColor(Spine.RegionAttachment attachment, UnityEngine.Color color);
            static /*0x1dc8164*/ void SetColor(Spine.RegionAttachment attachment, UnityEngine.Color32 color);
            static /*0x1dc81b4*/ void SetColor(Spine.MeshAttachment attachment, UnityEngine.Color color);
            static /*0x1dc81d0*/ void SetColor(Spine.MeshAttachment attachment, UnityEngine.Color32 color);
            static /*0x1dc8220*/ void SetLocalScale(Spine.Skeleton skeleton, UnityEngine.Vector2 scale);
            static /*0x1dc8238*/ UnityEngine.Matrix4x4 GetMatrix4x4(Spine.Bone bone);
            static /*0x1dc8298*/ void SetLocalPosition(Spine.Bone bone, UnityEngine.Vector2 position);
            static /*0x1dc82b0*/ void SetLocalPosition(Spine.Bone bone, UnityEngine.Vector3 position);
            static /*0x1dc82c8*/ UnityEngine.Vector2 GetLocalPosition(Spine.Bone bone);
            static /*0x1dc82e0*/ UnityEngine.Vector2 GetSkeletonSpacePosition(Spine.Bone bone);
            static /*0x1dc82fc*/ UnityEngine.Vector2 GetSkeletonSpacePosition(Spine.Bone bone, UnityEngine.Vector2 boneLocal);
            static /*0x1dc8338*/ UnityEngine.Vector3 GetWorldPosition(Spine.Bone bone, UnityEngine.Transform spineGameObjectTransform);
            static /*0x1dc8368*/ UnityEngine.Vector3 GetWorldPosition(Spine.Bone bone, UnityEngine.Transform spineGameObjectTransform, float positionScale);
            static /*0x1dc83a0*/ UnityEngine.Quaternion GetQuaternion(Spine.Bone bone);
            static /*0x1dc8418*/ UnityEngine.Quaternion GetLocalQuaternion(Spine.Bone bone);
            static /*0x1dc8494*/ UnityEngine.Vector2 GetLocalScale(Spine.Skeleton skeleton);
            static /*0x1dc84c8*/ void GetWorldToLocalMatrix(Spine.Bone bone, ref float ia, ref float ib, ref float ic, ref float id);
            static /*0x1dc8518*/ UnityEngine.Vector2 WorldToLocal(Spine.Bone bone, UnityEngine.Vector2 worldPosition);
            static /*0x1dc8554*/ UnityEngine.Vector2 SetPositionSkeletonSpace(Spine.Bone bone, UnityEngine.Vector2 skeletonSpacePosition);
            static /*0x1dc8588*/ UnityEngine.Material GetMaterial(Spine.Attachment a);
            static /*0x1dc86dc*/ UnityEngine.Vector2[] GetLocalVertices(Spine.VertexAttachment va, Spine.Slot slot, UnityEngine.Vector2[] buffer);
            static /*0x1dc897c*/ UnityEngine.Vector2[] GetWorldVertices(Spine.VertexAttachment a, Spine.Slot slot, UnityEngine.Vector2[] buffer);
            static /*0x1dc8b54*/ UnityEngine.Vector3 GetWorldPosition(Spine.PointAttachment attachment, Spine.Slot slot, UnityEngine.Transform spineGameObjectTransform);
            static /*0x1dc8bbc*/ UnityEngine.Vector3 GetWorldPosition(Spine.PointAttachment attachment, Spine.Bone bone, UnityEngine.Transform spineGameObjectTransform);
        }

        class WaitForSpineAnimation : System.Collections.IEnumerator
        {
            /*0x10*/ bool m_WasFired;

            /*0x24834ec*/ WaitForSpineAnimation(Spine.TrackEntry trackEntry, Spine.Unity.WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor);
            /*0x2483718*/ Spine.Unity.WaitForSpineAnimation NowWaitFor(Spine.TrackEntry trackEntry, Spine.Unity.WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor);
            /*0x248373c*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x24837f8*/ void System.Collections.IEnumerator.Reset();
            /*0x2483800*/ object System.Collections.IEnumerator.get_Current();
            /*0x248352c*/ void SafeSubscribe(Spine.TrackEntry trackEntry, Spine.Unity.WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor);
            /*0x2483868*/ void HandleComplete(Spine.TrackEntry trackEntry);

            enum AnimationEventTypes
            {
                Start = 1,
                Interrupt = 2,
                End = 4,
                Dispose = 8,
                Complete = 16,
            }
        }

        class WaitForSpineAnimationComplete : Spine.Unity.WaitForSpineAnimation, System.Collections.IEnumerator
        {
            /*0x2483874*/ WaitForSpineAnimationComplete(Spine.TrackEntry trackEntry, bool includeEndEvent);
            /*0x24838c8*/ Spine.Unity.WaitForSpineAnimationComplete NowWaitFor(Spine.TrackEntry trackEntry, bool includeEndEvent);
        }

        class WaitForSpineAnimationEnd : Spine.Unity.WaitForSpineAnimation, System.Collections.IEnumerator
        {
            /*0x2483904*/ WaitForSpineAnimationEnd(Spine.TrackEntry trackEntry);
            /*0x2483938*/ Spine.Unity.WaitForSpineAnimationEnd NowWaitFor(Spine.TrackEntry trackEntry);
        }

        class WaitForSpineEvent : System.Collections.IEnumerator
        {
            /*0x10*/ Spine.EventData m_TargetEvent;
            /*0x18*/ string m_EventName;
            /*0x20*/ Spine.AnimationState m_AnimationState;
            /*0x28*/ bool m_WasFired;
            /*0x29*/ bool m_unsubscribeAfterFiring;

            /*0x2483c50*/ WaitForSpineEvent(Spine.AnimationState state, Spine.EventData eventDataReference, bool unsubscribeAfterFiring);
            /*0x2483c98*/ WaitForSpineEvent(Spine.Unity.SkeletonAnimation skeletonAnimation, Spine.EventData eventDataReference, bool unsubscribeAfterFiring);
            /*0x2483ce8*/ WaitForSpineEvent(Spine.AnimationState state, string eventName, bool unsubscribeAfterFiring);
            /*0x2483d30*/ WaitForSpineEvent(Spine.Unity.SkeletonAnimation skeletonAnimation, string eventName, bool unsubscribeAfterFiring);
            /*0x2483960*/ void Subscribe(Spine.AnimationState state, Spine.EventData eventDataReference, bool unsubscribe);
            /*0x2483b04*/ void SubscribeByName(Spine.AnimationState state, string eventName, bool unsubscribe);
            /*0x2483d80*/ void HandleAnimationStateEventByName(Spine.TrackEntry trackEntry, Spine.Event e);
            /*0x2483e64*/ void HandleAnimationStateEvent(Spine.TrackEntry trackEntry, Spine.Event e);
            /*0x2483f3c*/ bool get_WillUnsubscribeAfterFiring();
            /*0x2483f44*/ void set_WillUnsubscribeAfterFiring(bool value);
            /*0x2483f50*/ Spine.Unity.WaitForSpineEvent NowWaitFor(Spine.AnimationState state, Spine.EventData eventDataReference, bool unsubscribeAfterFiring);
            /*0x2484104*/ Spine.Unity.WaitForSpineEvent NowWaitFor(Spine.AnimationState state, string eventName, bool unsubscribeAfterFiring);
            /*0x2484038*/ void Clear(Spine.AnimationState state);
            /*0x24841ec*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x24842a8*/ void System.Collections.IEnumerator.Reset();
            /*0x24842b0*/ object System.Collections.IEnumerator.get_Current();
        }

        class WaitForSpineTrackEntryEnd : System.Collections.IEnumerator
        {
            /*0x10*/ bool m_WasFired;

            /*0x24842b8*/ WaitForSpineTrackEntryEnd(Spine.TrackEntry trackEntry);
            /*0x24843d4*/ void HandleEnd(Spine.TrackEntry trackEntry);
            /*0x24842e8*/ void SafeSubscribe(Spine.TrackEntry trackEntry);
            /*0x24843e0*/ Spine.Unity.WaitForSpineTrackEntryEnd NowWaitFor(Spine.TrackEntry trackEntry);
            /*0x2484404*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x24844c0*/ void System.Collections.IEnumerator.Reset();
            /*0x24844c8*/ object System.Collections.IEnumerator.get_Current();
        }

        namespace AttachmentTools
        {
            class AtlasUtilities
            {
                static UnityEngine.TextureFormat SpineTextureFormat = 4;
                static float DefaultMipmapBias = -0.5;
                static bool UseMipMaps = false;
                static float DefaultScale = 0.009999999776482582;
                static int NonrenderingRegion = -1;
                static /*0x0*/ System.Collections.Generic.Dictionary<Spine.Unity.AttachmentTools.AtlasUtilities.IntAndAtlasRegionKey, UnityEngine.Texture2D> CachedRegionTextures;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.Texture2D> CachedRegionTexturesList;

                static /*0x2258ccc*/ AtlasUtilities();
                static /*0x2254d0c*/ Spine.AtlasRegion ToAtlasRegion(UnityEngine.Texture2D t, UnityEngine.Material materialPropertySource, float scale);
                static /*0x2254dac*/ Spine.AtlasRegion ToAtlasRegion(UnityEngine.Texture2D t, UnityEngine.Shader shader, float scale, UnityEngine.Material materialPropertySource);
                static /*0x22550f4*/ Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Texture2D t, UnityEngine.Material materialPropertySource, UnityEngine.TextureFormat textureFormat, bool mipmaps);
                static /*0x225519c*/ Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Texture2D t, UnityEngine.Shader shader, UnityEngine.TextureFormat textureFormat, bool mipmaps, UnityEngine.Material materialPropertySource);
                static /*0x2254fe8*/ Spine.AtlasPage ToSpineAtlasPage(UnityEngine.Material m);
                static /*0x22555b4*/ Spine.AtlasRegion ToAtlasRegion(UnityEngine.Sprite s, Spine.AtlasPage page);
                static /*0x2255a8c*/ Spine.AtlasRegion ToAtlasRegion(UnityEngine.Sprite s, UnityEngine.Material material);
                static /*0x2255b1c*/ Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Sprite s, UnityEngine.Material materialPropertySource, UnityEngine.TextureFormat textureFormat, bool mipmaps);
                static /*0x2255bc4*/ Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Sprite s, UnityEngine.Shader shader, UnityEngine.TextureFormat textureFormat, bool mipmaps, UnityEngine.Material materialPropertySource);
                static /*0x2255694*/ Spine.AtlasRegion ToAtlasRegion(UnityEngine.Sprite s, bool isolatedTexture);
                static /*0x2256084*/ void GetRepackedAttachments(System.Collections.Generic.List<Spine.Attachment> sourceAttachments, System.Collections.Generic.List<Spine.Attachment> outputAttachments, UnityEngine.Material materialPropertySource, ref UnityEngine.Material outputMaterial, ref UnityEngine.Texture2D outputTexture, int maxAtlasSize, int padding, UnityEngine.TextureFormat textureFormat, bool mipmaps, string newAssetName, bool clearCache, bool useOriginalNonrenderables);
                static /*0x22574f8*/ Spine.Skin GetRepackedSkin(Spine.Skin o, string newName, UnityEngine.Material materialPropertySource, ref UnityEngine.Material outputMaterial, ref UnityEngine.Texture2D outputTexture, int maxAtlasSize, int padding, UnityEngine.TextureFormat textureFormat, bool mipmaps, bool useOriginalNonrenderables, bool clearCache, int[] additionalTexturePropertyIDsToCopy, UnityEngine.Texture2D[] additionalOutputTextures, UnityEngine.TextureFormat[] additionalTextureFormats, bool[] additionalTextureIsLinear);
                static /*0x2257600*/ Spine.Skin GetRepackedSkin(Spine.Skin o, string newName, UnityEngine.Shader shader, ref UnityEngine.Material outputMaterial, ref UnityEngine.Texture2D outputTexture, int maxAtlasSize, int padding, UnityEngine.TextureFormat textureFormat, bool mipmaps, UnityEngine.Material materialPropertySource, bool clearCache, bool useOriginalNonrenderables, int[] additionalTexturePropertyIDsToCopy, UnityEngine.Texture2D[] additionalOutputTextures, UnityEngine.TextureFormat[] additionalTextureFormats, bool[] additionalTextureIsLinear);
                static /*0x22585f4*/ UnityEngine.Sprite ToSprite(Spine.AtlasRegion ar, float pixelsPerUnit);
                static /*0x2257314*/ void ClearCache();
                static /*0x2256bc4*/ UnityEngine.Texture2D ToTexture(Spine.AtlasRegion ar, UnityEngine.TextureFormat textureFormat, bool mipmaps, int texturePropertyId, bool linear);
                static /*0x2255dbc*/ UnityEngine.Texture2D ToTexture(UnityEngine.Sprite s, UnityEngine.TextureFormat textureFormat, bool mipmaps, bool linear);
                static /*0x22553a0*/ UnityEngine.Texture2D GetClone(UnityEngine.Texture2D t, UnityEngine.TextureFormat textureFormat, bool mipmaps, bool linear);
                static /*0x2258880*/ void CopyTexture(UnityEngine.Texture2D source, UnityEngine.Rect sourceRect, UnityEngine.Texture2D destination);
                static /*0x22569bc*/ bool IsRenderable(Spine.Attachment a);
                static /*0x2255f1c*/ UnityEngine.Rect SpineUnityFlipRect(UnityEngine.Rect rect, int textureHeight);
                static /*0x225873c*/ UnityEngine.Rect GetUnityRect(Spine.AtlasRegion region);
                static /*0x2258ad4*/ UnityEngine.Rect GetUnityRect(Spine.AtlasRegion region, int textureHeight);
                static /*0x2258a68*/ UnityEngine.Rect GetSpineAtlasRect(Spine.AtlasRegion region, bool includeRotate);
                static /*0x2258b4c*/ UnityEngine.Rect UVRectToTextureRect(UnityEngine.Rect uvRect, int texWidth, int texHeight);
                static /*0x2255f8c*/ UnityEngine.Rect TextureRectToUVRect(UnityEngine.Rect textureRect, int texWidth, int texHeight);
                static /*0x2256f40*/ Spine.AtlasRegion UVRectToAtlasRegion(UnityEngine.Rect uvRect, Spine.AtlasRegion referenceRegion, Spine.AtlasPage page);
                static /*0x2258684*/ UnityEngine.Texture2D GetMainTexture(Spine.AtlasRegion region);
                static /*0x2258c04*/ UnityEngine.Texture2D GetTexture(Spine.AtlasRegion region, string texturePropertyName);
                static /*0x22587b8*/ UnityEngine.Texture2D GetTexture(Spine.AtlasRegion region, int texturePropertyId);
                static /*0x2256e8c*/ void CopyTextureAttributesFrom(UnityEngine.Texture2D destination, UnityEngine.Texture2D source);
                static /*0x2255500*/ void ApplyPMA(UnityEngine.Texture2D texture, bool applyImmediately);
                static /*0x22550e4*/ float InverseLerp(float a, float b, float value);

                struct IntAndAtlasRegionKey
                {
                    /*0x10*/ int i;
                    /*0x18*/ Spine.AtlasRegion region;

                    /*0xae6740*/ IntAndAtlasRegionKey(int i, Spine.AtlasRegion region);
                    /*0xae674c*/ int GetHashCode();
                }
            }

            class AttachmentCloneExtensions
            {
                static /*0x2256a14*/ Spine.Attachment GetCopy(Spine.Attachment o, bool cloneMeshesAsLinked);
                static /*0x2258e40*/ Spine.MeshAttachment GetLinkedMesh(Spine.MeshAttachment o, string newLinkedMeshName, Spine.AtlasRegion region);
                static /*0x2258fb8*/ Spine.MeshAttachment GetLinkedMesh(Spine.MeshAttachment o, UnityEngine.Sprite sprite, UnityEngine.Shader shader, UnityEngine.Material materialPropertySource);
                static /*0x22590f8*/ Spine.MeshAttachment GetLinkedMesh(Spine.MeshAttachment o, UnityEngine.Sprite sprite, UnityEngine.Material materialPropertySource);
                static /*0x2259148*/ Spine.Attachment GetRemappedClone(Spine.Attachment o, UnityEngine.Sprite sprite, UnityEngine.Material sourceMaterial, bool premultiplyAlpha, bool cloneMeshAsLinked, bool useOriginalRegionSize);
                static /*0x2259298*/ Spine.Attachment GetRemappedClone(Spine.Attachment o, Spine.AtlasRegion atlasRegion, bool cloneMeshAsLinked, bool useOriginalRegionSize, float scale);
            }

            class AttachmentRegionExtensions
            {
                static /*0x2256ac0*/ Spine.AtlasRegion GetRegion(Spine.Attachment attachment);
                static /*0x2259590*/ Spine.AtlasRegion GetRegion(Spine.RegionAttachment regionAttachment);
                static /*0x2259618*/ Spine.AtlasRegion GetRegion(Spine.MeshAttachment meshAttachment);
                static /*0x2257224*/ void SetRegion(Spine.Attachment attachment, Spine.AtlasRegion region, bool updateOffset);
                static /*0x2259498*/ void SetRegion(Spine.RegionAttachment attachment, Spine.AtlasRegion region, bool updateOffset);
                static /*0x2258ecc*/ void SetRegion(Spine.MeshAttachment attachment, Spine.AtlasRegion region, bool updateUVs);
                static /*0x22596a0*/ Spine.RegionAttachment ToRegionAttachment(UnityEngine.Sprite sprite, UnityEngine.Material material, float rotation);
                static /*0x2259728*/ Spine.RegionAttachment ToRegionAttachment(UnityEngine.Sprite sprite, Spine.AtlasPage page, float rotation);
                static /*0x2259a5c*/ Spine.RegionAttachment ToRegionAttachmentPMAClone(UnityEngine.Sprite sprite, UnityEngine.Shader shader, UnityEngine.TextureFormat textureFormat, bool mipmaps, UnityEngine.Material materialPropertySource, float rotation);
                static /*0x2259c0c*/ Spine.RegionAttachment ToRegionAttachmentPMAClone(UnityEngine.Sprite sprite, UnityEngine.Material materialPropertySource, UnityEngine.TextureFormat textureFormat, bool mipmaps, float rotation);
                static /*0x2259890*/ Spine.RegionAttachment ToRegionAttachment(Spine.AtlasRegion region, string attachmentName, float scale, float rotation);
                static /*0x2259c74*/ void SetScale(Spine.RegionAttachment regionAttachment, UnityEngine.Vector2 scale);
                static /*0x2259c8c*/ void SetScale(Spine.RegionAttachment regionAttachment, float x, float y);
                static /*0x2259ca4*/ void SetPositionOffset(Spine.RegionAttachment regionAttachment, UnityEngine.Vector2 offset);
                static /*0x2259cbc*/ void SetPositionOffset(Spine.RegionAttachment regionAttachment, float x, float y);
                static /*0x2259cd4*/ void SetRotation(Spine.RegionAttachment regionAttachment, float rotation);
            }

            class SkinUtilities
            {
                static /*0x247944c*/ Spine.Skin UnshareSkin(Spine.Skeleton skeleton, bool includeDefaultSkin, bool unshareAttachments, Spine.AnimationState state);
                static /*0x2479504*/ Spine.Skin GetClonedSkin(Spine.Skeleton skeleton, string newSkinName, bool includeDefaultSkin, bool cloneAttachments, bool cloneMeshesAsLinked);
                static /*0x247a384*/ Spine.Skin GetClone(Spine.Skin original);
                static /*0x247a720*/ void SetAttachment(Spine.Skin skin, string slotName, string keyName, Spine.Attachment attachment, Spine.Skeleton skeleton);
                static /*0x247a7ec*/ void AddAttachments(Spine.Skin skin, Spine.Skin otherSkin);
                static /*0x247a810*/ Spine.Attachment GetAttachment(Spine.Skin skin, string slotName, string keyName, Spine.Skeleton skeleton);
                static /*0x247a8d4*/ void SetAttachment(Spine.Skin skin, int slotIndex, string keyName, Spine.Attachment attachment);
                static /*0x247a8ec*/ void RemoveAttachment(Spine.Skin skin, string slotName, string keyName, Spine.SkeletonData skeletonData);
                static /*0x247a9b0*/ void Clear(Spine.Skin skin);
                static /*0x247aa08*/ void Append(Spine.Skin destination, Spine.Skin source);
                static /*0x24795d0*/ void CopyTo(Spine.Skin source, Spine.Skin destination, bool overwrite, bool cloneAttachments, bool cloneMeshesAsLinked);
            }
        }

        namespace Deprecated
        {
            class SlotBlendModes : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<Spine.Unity.Deprecated.SlotBlendModes.MaterialTexturePair, Spine.Unity.Deprecated.SlotBlendModes.MaterialWithRefcount> materialTable;
                /*0x18*/ UnityEngine.Material multiplyMaterialSource;
                /*0x20*/ UnityEngine.Material screenMaterialSource;
                /*0x28*/ UnityEngine.Texture2D texture;
                /*0x30*/ Spine.Unity.Deprecated.SlotBlendModes.SlotMaterialTextureTuple[] slotsWithCustomMaterial;
                /*0x38*/ bool <Applied>k__BackingField;

                static /*0x247b07c*/ System.Collections.Generic.Dictionary<Spine.Unity.Deprecated.SlotBlendModes.MaterialTexturePair, Spine.Unity.Deprecated.SlotBlendModes.MaterialWithRefcount> get_MaterialTable();
                static /*0x247b120*/ UnityEngine.Material GetOrAddMaterialFor(UnityEngine.Material materialSource, UnityEngine.Texture2D texture);
                static /*0x247b398*/ Spine.Unity.Deprecated.SlotBlendModes.MaterialWithRefcount GetExistingMaterialFor(UnityEngine.Material materialSource, UnityEngine.Texture2D texture);
                static /*0x247b494*/ void RemoveMaterialFromTable(UnityEngine.Material materialSource, UnityEngine.Texture2D texture);
                /*0x247be84*/ SlotBlendModes();
                /*0x247b4fc*/ bool get_Applied();
                /*0x247b504*/ void set_Applied(bool value);
                /*0x247b510*/ void Start();
                /*0x247ba70*/ void OnDestroy();
                /*0x247b520*/ void Apply();
                /*0x247ba80*/ void Remove();
                /*0x247bc94*/ void GetTexture();

                struct MaterialTexturePair
                {
                    /*0x10*/ UnityEngine.Texture2D texture2D;
                    /*0x18*/ UnityEngine.Material material;
                }

                class MaterialWithRefcount
                {
                    /*0x10*/ UnityEngine.Material materialClone;
                    /*0x18*/ int refcount;

                    /*0x247b364*/ MaterialWithRefcount(UnityEngine.Material mat);
                }

                struct SlotMaterialTextureTuple
                {
                    /*0x10*/ Spine.Slot slot;
                    /*0x18*/ UnityEngine.Texture2D texture2D;
                    /*0x20*/ UnityEngine.Material material;

                    /*0xae6a10*/ SlotMaterialTextureTuple(Spine.Slot slot, UnityEngine.Material material, UnityEngine.Texture2D texture);
                }
            }
        }
    }

    namespace Collections
    {
        class OrderedDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey, TValue>>
        {
            static string CollectionModifiedMessage = "Collection was modified; enumeration operation may not execute.";
            static string EditReadOnlyListMessage = "An attempt was made to edit a read-only list.";
            static string IndexOutOfRangeMessage = "The index is negative or outside the bounds of the collection.";
            /*0x0*/ System.Collections.Generic.Dictionary<TKey, int> dictionary;
            /*0x0*/ System.Collections.Generic.List<TKey> keys;
            /*0x0*/ System.Collections.Generic.List<TValue> values;
            /*0x0*/ int version;

            OrderedDictionary();
            OrderedDictionary(int capacity);
            OrderedDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer);
            OrderedDictionary(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer);
            System.Collections.Generic.IEqualityComparer<TKey> get_Comparer();
            void Add(TKey key, TValue value);
            void Insert(int index, TKey key, TValue value);
            bool ContainsKey(TKey key);
            TKey GetKey(int index);
            int IndexOf(TKey key);
            Spine.Collections.OrderedDictionary.KeyCollection<TKey, TValue> get_Keys();
            bool Remove(TKey key);
            void RemoveAt(int index);
            bool TryGetValue(TKey key, ref TValue value);
            Spine.Collections.OrderedDictionary.ValueCollection<TKey, TValue> get_Values();
            TValue get_Item(int index);
            void set_Item(int index, TValue value);
            TValue get_Item(TKey key);
            void set_Item(TKey key, TValue value);
            void Clear();
            int get_Count();
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
            int System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IndexOf(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            void System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Insert(int index, System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            System.Collections.Generic.KeyValuePair<TKey, TValue> System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Item(int index);
            void System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey,TValue>>.set_Item(int index, System.Collections.Generic.KeyValuePair<TKey, TValue> value);
            System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
            System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
            void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
            bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
            bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.Dictionary<TKey, int> dictionary;

                KeyCollection(System.Collections.Generic.Dictionary<TKey, int> dictionary);
                void CopyTo(TKey[] array, int arrayIndex);
                int get_Count();
                System.Collections.Generic.IEnumerator<TKey> GetEnumerator();
                bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item);
                void System.Collections.Generic.ICollection<TKey>.Add(TKey item);
                void System.Collections.Generic.ICollection<TKey>.Clear();
                bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly();
                bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item);
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<TValue> values;

                ValueCollection(System.Collections.Generic.List<TValue> values);
                void CopyTo(TValue[] array, int arrayIndex);
                int get_Count();
                System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item);
                void System.Collections.Generic.ICollection<TValue>.Add(TValue item);
                void System.Collections.Generic.ICollection<TValue>.Clear();
                bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly();
                bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item);
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetEnumerator>d__34<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Collections.Generic.KeyValuePair<TKey, TValue> <>2__current;
                /*0x0*/ Spine.Collections.OrderedDictionary<TKey, TValue> <>4__this;
                /*0x0*/ int <startVersion>5__2;
                /*0x0*/ int <index>5__3;

                <GetEnumerator>d__34(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                System.Collections.Generic.KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
            }
        }

        class OrderedDictionaryDebugView<TKey, TValue>
        {
            /*0x0*/ Spine.Collections.OrderedDictionary<TKey, TValue> dictionary;

            OrderedDictionaryDebugView(Spine.Collections.OrderedDictionary<TKey, TValue> dictionary);
            System.Collections.Generic.KeyValuePair<TKey, TValue> get_Items();
        }

        class CollectionExtensions
        {
            static Spine.Collections.OrderedDictionary<TKey, TSource> ToOrderedDictionary<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector);
            static Spine.Collections.OrderedDictionary<TKey, TSource> ToOrderedDictionary<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0C6A9A02BE5F7EB53FB20C6B5B3C610B857B50E630614FEC5F4BFCD7FC6F1567;
    static /*0x18*/ <PrivateImplementationDetails> 753D5E1ADA77B20B9959A1030B8E0BA5CF925F2881D3635C3F791E5A0AE0EEB1;
    static /*0x30*/ <PrivateImplementationDetails> ADCCF6F914B86A7EF3FFAA75A291E94CBA3B3DFBF16E94206A5A932D18E28891;

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }
}
