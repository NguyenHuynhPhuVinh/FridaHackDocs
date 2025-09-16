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

        static /*0x737de40*/ SharpJson.Lexer.Token NextToken(char[] json, ref int index);
        /*0x737d658*/ Lexer(string text);
        /*0x737d62c*/ bool get_hasError();
        /*0x737d63c*/ int get_lineNumber();
        /*0x737d644*/ void set_lineNumber(int value);
        /*0x737d64c*/ void set_parseNumbersAsFloat(bool value);
        /*0x737d708*/ void Reset();
        /*0x737d71c*/ string ParseString();
        /*0x737dc0c*/ string GetNumberString();
        /*0x737dcd4*/ float ParseFloatNumber();
        /*0x737dd70*/ double ParseDoubleNumber();
        /*0x737dc54*/ int GetLastIndexOfNumber(int index);
        /*0x737db78*/ void SkipWhiteSpaces();
        /*0x737de0c*/ SharpJson.Lexer.Token LookAhead();
        /*0x737e094*/ SharpJson.Lexer.Token NextToken();

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

        /*0x737e0d4*/ JsonDecoder();
        /*0x737e0b0*/ string get_errorMessage();
        /*0x737e0b8*/ void set_errorMessage(string value);
        /*0x737e0c0*/ bool get_parseNumbersAsFloat();
        /*0x737e0c8*/ void set_parseNumbersAsFloat(bool value);
        /*0x737e100*/ object Decode(string text);
        /*0x737e394*/ System.Collections.Generic.IDictionary<string, object> ParseObject();
        /*0x737e62c*/ System.Collections.Generic.IList<object> ParseArray();
        /*0x737e19c*/ object ParseValue();
        /*0x737e590*/ void TriggerError(string message);
        /*0x3910ae8*/ T EvalLexer<T>(T value);
    }
}

namespace Spine
{
    class Animation
    {
        /*0x10*/ string name;
        /*0x18*/ Spine.ExposedList<Spine.Timeline> timelines;
        /*0x20*/ System.Collections.Generic.HashSet<string> timelineIds;
        /*0x28*/ float duration;

        /*0x737e7ec*/ Animation(string name, Spine.ExposedList<Spine.Timeline> timelines, float duration);
        /*0x737eae0*/ Spine.ExposedList<Spine.Timeline> get_Timelines();
        /*0x737e8a0*/ void SetTimelines(Spine.ExposedList<Spine.Timeline> timelines);
        /*0x737eae8*/ float get_Duration();
        /*0x737eaf0*/ string get_Name();
        /*0x737eaf8*/ bool HasTimeline(string[] propertyIds);
        /*0x737ebb0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, bool loop, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x737ed10*/ string ToString();
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

    enum Property
    {
        Rotate = 0,
        X = 1,
        Y = 2,
        ScaleX = 3,
        ScaleY = 4,
        ShearX = 5,
        ShearY = 6,
        Inherit = 7,
        RGB = 8,
        Alpha = 9,
        RGB2 = 10,
        Attachment = 11,
        Deform = 12,
        Event = 13,
        DrawOrder = 14,
        IkConstraint = 15,
        TransformConstraint = 16,
        PathConstraintPosition = 17,
        PathConstraintSpacing = 18,
        PathConstraintMix = 19,
        PhysicsConstraintInertia = 20,
        PhysicsConstraintStrength = 21,
        PhysicsConstraintDamping = 22,
        PhysicsConstraintMass = 23,
        PhysicsConstraintWind = 24,
        PhysicsConstraintGravity = 25,
        PhysicsConstraintMix = 26,
        PhysicsConstraintReset = 27,
        Sequence = 28,
    }

    class Timeline
    {
        /*0x10*/ string[] propertyIds;
        /*0x18*/ float[] frames;

        static /*0x737ee94*/ int Search(float[] frames, float time);
        static /*0x737eee8*/ int Search(float[] frames, float time, int step);
        /*0x737ed18*/ Timeline(int frameCount, string[] propertyIds);
        /*0x737ee10*/ string[] get_PropertyIds();
        /*0x737ee18*/ float[] get_Frames();
        /*0x737ee20*/ int get_FrameEntries();
        /*0x737ee28*/ int get_FrameCount();
        /*0x737ee54*/ float get_Duration();
        void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    interface IBoneTimeline
    {
        /*0x3814574*/ int get_BoneIndex();
    }

    class CurveTimeline : Spine.Timeline
    {
        /*0x20*/ float[] curves;

        /*0x737ef40*/ CurveTimeline(int frameCount, int bezierCount, string[] propertyIds);
        /*0x737eff8*/ void SetStepped(int frame);
        /*0x737f02c*/ void Shrink(int bezierCount);
        /*0x737f0e8*/ void SetBezier(int bezier, int frame, int value, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2);
        /*0x737f28c*/ float GetBezierValue(float time, int frameIndex, int valueOffset, int i);
    }

    class CurveTimeline1 : Spine.CurveTimeline
    {
        /*0x737f428*/ CurveTimeline1(int frameCount, int bezierCount, string propertyId);
        /*0x737f4c8*/ int get_FrameEntries();
        /*0x737f4d0*/ void SetFrame(int frame, float time, float value);
        /*0x737f51c*/ float GetCurveValue(float time);
        /*0x737f64c*/ float GetRelativeValue(float time, float alpha, Spine.MixBlend blend, float current, float setup);
        /*0x737f6ec*/ float GetAbsoluteValue(float time, float alpha, Spine.MixBlend blend, float current, float setup);
        /*0x737f780*/ float GetAbsoluteValue(float time, float alpha, Spine.MixBlend blend, float current, float setup, float value);
        /*0x737f7f0*/ float GetScaleValue(float time, float alpha, Spine.MixBlend blend, Spine.MixDirection direction, float current, float setup);
    }

    class CurveTimeline2 : Spine.CurveTimeline
    {
        /*0x737f9e0*/ CurveTimeline2(int frameCount, int bezierCount, string propertyId1, string propertyId2);
        /*0x737faa4*/ int get_FrameEntries();
        /*0x737faac*/ void SetFrame(int frame, float time, float value1, float value2);
    }

    class RotateTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x737fb08*/ RotateTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x737fbb4*/ int get_BoneIndex();
        /*0x737fbbc*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TranslateTimeline : Spine.CurveTimeline2, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x737fc30*/ TranslateTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x737fd20*/ int get_BoneIndex();
        /*0x737fd28*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x737fe84*/ void GetCurveValue(ref float x, ref float y, float time);
    }

    class TranslateXTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7380058*/ TranslateXTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7380108*/ int get_BoneIndex();
        /*0x7380110*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TranslateYTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7380184*/ TranslateYTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7380234*/ int get_BoneIndex();
        /*0x738023c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ScaleTimeline : Spine.CurveTimeline2, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x73802b0*/ ScaleTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x73803a0*/ int get_BoneIndex();
        /*0x73803a8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ScaleXTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7380894*/ ScaleXTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7380944*/ int get_BoneIndex();
        /*0x738094c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ScaleYTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x73809c4*/ ScaleYTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7380a74*/ int get_BoneIndex();
        /*0x7380a7c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ShearTimeline : Spine.CurveTimeline2, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7380af4*/ ShearTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7380be4*/ int get_BoneIndex();
        /*0x7380bec*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ShearXTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7380ee8*/ ShearXTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7380f98*/ int get_BoneIndex();
        /*0x7380fa0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ShearYTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7381014*/ ShearYTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x73810c4*/ int get_BoneIndex();
        /*0x73810cc*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class InheritTimeline : Spine.Timeline, Spine.IBoneTimeline
    {
        /*0x20*/ int boneIndex;

        /*0x7381140*/ InheritTimeline(int frameCount, int boneIndex);
        /*0x7381234*/ int get_BoneIndex();
        /*0x738123c*/ int get_FrameEntries();
        /*0x7381244*/ void SetFrame(int frame, float time, Spine.Inherit inherit);
        /*0x7381294*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGBATimeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x7381418*/ RGBATimeline(int frameCount, int bezierCount, int slotIndex);
        /*0x7381574*/ int get_FrameEntries();
        /*0x738157c*/ void SetFrame(int frame, float time, float r, float g, float b, float a);
        /*0x7381600*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGBTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x73819fc*/ RGBTimeline(int frameCount, int bezierCount, int slotIndex);
        /*0x7381af8*/ int get_FrameEntries();
        /*0x7381b00*/ void SetFrame(int frame, float time, float r, float g, float b);
        /*0x7381b74*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class AlphaTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int slotIndex;

        /*0x7381ee8*/ AlphaTimeline(int frameCount, int bezierCount, int slotIndex);
        /*0x7381f98*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGBA2Timeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x73820b0*/ RGBA2Timeline(int frameCount, int bezierCount, int slotIndex);
        /*0x7382264*/ int get_FrameEntries();
        /*0x738226c*/ void SetFrame(int frame, float time, float r, float g, float b, float a, float r2, float g2, float b2);
        /*0x7382334*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGB2Timeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x7382914*/ RGB2Timeline(int frameCount, int bezierCount, int slotIndex);
        /*0x7382a70*/ int get_FrameEntries();
        /*0x7382a78*/ void SetFrame(int frame, float time, float r, float g, float b, float r2, float g2, float b2);
        /*0x7382b28*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class AttachmentTimeline : Spine.Timeline
    {
        /*0x20*/ int slotIndex;
        /*0x28*/ string[] attachmentNames;

        /*0x73830ac*/ AttachmentTimeline(int frameCount, int slotIndex);
        /*0x73831bc*/ int get_SlotIndex();
        /*0x73831c4*/ string[] get_AttachmentNames();
        /*0x73831cc*/ void SetFrame(int frame, float time, string attachmentName);
        /*0x7383220*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x7383314*/ void SetAttachment(Spine.Skeleton skeleton, Spine.Slot slot, string attachmentName);
    }

    class DeformTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;
        /*0x30*/ Spine.VertexAttachment attachment;
        /*0x38*/ float[][] vertices;

        /*0x7383360*/ DeformTimeline(int frameCount, int bezierCount, int slotIndex, Spine.VertexAttachment attachment);
        /*0x7383560*/ void SetFrame(int frame, float time, float[] vertices);
        /*0x73835b4*/ float GetCurvePercent(float time, int frame);
        /*0x73837e4*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class EventTimeline : Spine.Timeline
    {
        static /*0x0*/ string[] propertyIds;
        /*0x20*/ Spine.Event[] events;

        static /*0x7384658*/ EventTimeline();
        /*0x7384310*/ EventTimeline(int frameCount);
        /*0x73843b0*/ void SetFrame(int frame, Spine.Event e);
        /*0x7384444*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class DrawOrderTimeline : Spine.Timeline
    {
        static /*0x0*/ string[] propertyIds;
        /*0x20*/ int[][] drawOrders;

        static /*0x73849d4*/ DrawOrderTimeline();
        /*0x7384710*/ DrawOrderTimeline(int frameCount);
        /*0x73847b0*/ void SetFrame(int frame, float time, int[] drawOrder);
        /*0x7384804*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class IkConstraintTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int constraintIndex;

        /*0x7384a8c*/ IkConstraintTimeline(int frameCount, int bezierCount, int ikConstraintIndex);
        /*0x7384b88*/ int get_FrameEntries();
        /*0x7384b90*/ void SetFrame(int frame, float time, float mix, float softness, int bendDirection, bool compress, bool stretch);
        /*0x7384c4c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TransformConstraintTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int constraintIndex;

        /*0x7384fb8*/ TransformConstraintTimeline(int frameCount, int bezierCount, int transformConstraintIndex);
        /*0x73850b4*/ int get_FrameEntries();
        /*0x73850bc*/ int get_TransformConstraintIndex();
        /*0x73850c4*/ void SetFrame(int frame, float time, float mixRotate, float mixX, float mixY, float mixScaleX, float mixScaleY, float mixShearY);
        /*0x7385174*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x7385340*/ void GetCurveValue(ref float rotate, ref float x, ref float y, ref float scaleX, ref float scaleY, ref float shearY, float time);
    }

    class PathConstraintPositionTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int constraintIndex;

        /*0x738570c*/ PathConstraintPositionTimeline(int frameCount, int bezierCount, int pathConstraintIndex);
        /*0x73857bc*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PathConstraintSpacingTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int constraintIndex;

        /*0x7385830*/ PathConstraintSpacingTimeline(int frameCount, int bezierCount, int pathConstraintIndex);
        /*0x73858e0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PathConstraintMixTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int constraintIndex;

        /*0x7385954*/ PathConstraintMixTimeline(int frameCount, int bezierCount, int pathConstraintIndex);
        /*0x7385a50*/ int get_FrameEntries();
        /*0x7385a58*/ void SetFrame(int frame, float time, float mixRotate, float mixX, float mixY);
        /*0x7385acc*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PhysicsConstraintTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int constraintIndex;

        /*0x7385e24*/ PhysicsConstraintTimeline(int frameCount, int bezierCount, int physicsConstraintIndex, Spine.Property property);
        /*0x7385ed4*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        float Setup(Spine.PhysicsConstraint constraint);
        float Get(Spine.PhysicsConstraint constraint);
        void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x38141c4*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintInertiaTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x73860d0*/ PhysicsConstraintInertiaTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x73860d8*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x73860f8*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x7386110*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x7386128*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintStrengthTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x7386140*/ PhysicsConstraintStrengthTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x7386148*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x7386168*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x7386180*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x7386198*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintDampingTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x73861b0*/ PhysicsConstraintDampingTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x73861b8*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x73861d8*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x73861f0*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x7386208*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintMassTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x7386220*/ PhysicsConstraintMassTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x7386228*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x7386250*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x7386270*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x7386290*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintWindTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x73862a8*/ PhysicsConstraintWindTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x73862b0*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x73862d0*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x73862e8*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x7386300*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintGravityTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x7386318*/ PhysicsConstraintGravityTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x7386320*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x7386340*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x7386358*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x7386370*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintMixTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x7386388*/ PhysicsConstraintMixTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x7386390*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x73863b0*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x73863c8*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x73863e0*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintResetTimeline : Spine.Timeline
    {
        static /*0x0*/ string[] propertyIds;
        /*0x20*/ int constraintIndex;

        static /*0x7386674*/ PhysicsConstraintResetTimeline();
        /*0x73863f8*/ PhysicsConstraintResetTimeline(int frameCount, int physicsConstraintIndex);
        /*0x7386474*/ int get_FrameCount();
        /*0x7386490*/ void SetFrame(int frame, float time);
        /*0x73864c0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class SequenceTimeline : Spine.Timeline
    {
        /*0x20*/ int slotIndex;
        /*0x28*/ Spine.IHasTextureRegion attachment;

        /*0x738672c*/ SequenceTimeline(int frameCount, int slotIndex, Spine.Attachment attachment);
        /*0x73869e0*/ int get_FrameEntries();
        /*0x73869e8*/ void SetFrame(int frame, float time, Spine.SequenceMode mode, int index, float delay);
        /*0x7386a4c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class AnimationState
    {
        static int Subsequent = 0;
        static int First = 1;
        static int HoldSubsequent = 2;
        static int HoldFirst = 3;
        static int HoldMix = 4;
        static int Setup = 1;
        static int Current = 2;
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
        /*0x60*/ System.Collections.Generic.HashSet<string> propertyIds;
        /*0x68*/ bool animationsChanged;
        /*0x6c*/ float timeScale;
        /*0x70*/ int unkeyedState;
        /*0x78*/ Spine.Pool<Spine.TrackEntry> trackEntryPool;

        static /*0x738a634*/ AnimationState();
        static /*0x73889a8*/ void ApplyRotateTimeline(Spine.RotateTimeline timeline, Spine.Skeleton skeleton, float time, float alpha, Spine.MixBlend blend, float[] timelinesRotation, int i, bool firstFrame);
        /*0x7386eac*/ AnimationState(Spine.AnimationStateData data);
        /*0x7386e04*/ void OnStart(Spine.TrackEntry entry);
        /*0x7386e20*/ void OnInterrupt(Spine.TrackEntry entry);
        /*0x7386e3c*/ void OnEnd(Spine.TrackEntry entry);
        /*0x7386e58*/ void OnDispose(Spine.TrackEntry entry);
        /*0x7386e74*/ void OnComplete(Spine.TrackEntry entry);
        /*0x7386e90*/ void OnEvent(Spine.TrackEntry entry, Spine.Event e);
        /*0x7387204*/ void Update(float delta);
        /*0x7387730*/ bool UpdateMixingFrom(Spine.TrackEntry to, float delta);
        /*0x7387ae4*/ bool Apply(Spine.Skeleton skeleton);
        /*0x7388f30*/ bool ApplyEventTimelinesOnly(Spine.Skeleton skeleton, bool issueEvents);
        /*0x73881a8*/ float ApplyMixingFrom(Spine.TrackEntry to, Spine.Skeleton skeleton, Spine.MixBlend blend);
        /*0x73891b0*/ float ApplyMixingFromEventTimelinesOnly(Spine.TrackEntry to, Spine.Skeleton skeleton, bool issueEvents);
        /*0x7388888*/ void ApplyAttachmentTimeline(Spine.AttachmentTimeline timeline, Spine.Skeleton skeleton, float time, Spine.MixBlend blend, bool attachments);
        /*0x738939c*/ void SetAttachment(Spine.Skeleton skeleton, Spine.Slot slot, string attachmentName, bool attachments);
        /*0x7388d84*/ void QueueEvents(Spine.TrackEntry entry, float animationTime);
        /*0x738965c*/ void ClearTracks();
        /*0x738970c*/ void ClearTrack(int trackIndex);
        /*0x7387404*/ void SetCurrent(int index, Spine.TrackEntry current, bool interrupt);
        /*0x7389b00*/ Spine.TrackEntry SetAnimation(int trackIndex, string animationName, bool loop);
        /*0x7389bc8*/ Spine.TrackEntry SetAnimation(int trackIndex, Spine.Animation animation, bool loop);
        /*0x7389820*/ Spine.TrackEntry ExpandToIndex(int index);
        /*0x7389d5c*/ Spine.TrackEntry NewTrackEntry(int trackIndex, Spine.Animation animation, bool loop, Spine.TrackEntry last);
        /*0x73876e0*/ void ClearNext(Spine.TrackEntry entry);
        /*0x73880c8*/ void AnimationsChanged();
        /*0x738a0d0*/ void ComputeHold(Spine.TrackEntry entry);
        /*0x738a480*/ Spine.TrackEntry GetCurrent(int trackIndex);
        /*0x738a4cc*/ void set_TimeScale(float value);
        /*0x738a4d4*/ Spine.ExposedList<Spine.TrackEntry> get_Tracks();
        /*0x738a4dc*/ string ToString();
        /*0x738a718*/ void <.ctor>b__45_0();

        class TrackEntryDelegate : System.MulticastDelegate
        {
            /*0x738a724*/ TrackEntryDelegate(object object, nint method);
            /*0x738a82c*/ void Invoke(Spine.TrackEntry trackEntry);
        }

        class TrackEntryEventDelegate : System.MulticastDelegate
        {
            /*0x738a840*/ TrackEntryEventDelegate(object object, nint method);
            /*0x738a94c*/ void Invoke(Spine.TrackEntry trackEntry, Spine.Event e);
        }
    }

    class TrackEntry : Spine.Pool.IPoolable<Spine.TrackEntry>
    {
        /*0x10*/ Spine.Animation animation;
        /*0x18*/ Spine.TrackEntry previous;
        /*0x20*/ Spine.TrackEntry next;
        /*0x28*/ Spine.TrackEntry mixingFrom;
        /*0x30*/ Spine.TrackEntry mixingTo;
        /*0x38*/ Spine.AnimationState.TrackEntryDelegate Start;
        /*0x40*/ Spine.AnimationState.TrackEntryDelegate Interrupt;
        /*0x48*/ Spine.AnimationState.TrackEntryDelegate End;
        /*0x50*/ Spine.AnimationState.TrackEntryDelegate Dispose;
        /*0x58*/ Spine.AnimationState.TrackEntryDelegate Complete;
        /*0x60*/ Spine.AnimationState.TrackEntryEventDelegate Event;
        /*0x68*/ int trackIndex;
        /*0x6c*/ bool loop;
        /*0x6d*/ bool holdPrevious;
        /*0x6e*/ bool reverse;
        /*0x6f*/ bool shortestRotation;
        /*0x70*/ float eventThreshold;
        /*0x74*/ float mixAttachmentThreshold;
        /*0x78*/ float alphaAttachmentThreshold;
        /*0x7c*/ float mixDrawOrderThreshold;
        /*0x80*/ float animationStart;
        /*0x84*/ float animationEnd;
        /*0x88*/ float animationLast;
        /*0x8c*/ float nextAnimationLast;
        /*0x90*/ float delay;
        /*0x94*/ float trackTime;
        /*0x98*/ float trackLast;
        /*0x9c*/ float nextTrackLast;
        /*0xa0*/ float trackEnd;
        /*0xa4*/ float timeScale;
        /*0xa8*/ float alpha;
        /*0xac*/ float mixTime;
        /*0xb0*/ float mixDuration;
        /*0xb4*/ float interruptAlpha;
        /*0xb8*/ float totalAlpha;
        /*0xbc*/ Spine.MixBlend mixBlend;
        /*0xc0*/ Spine.ExposedList<int> timelineMode;
        /*0xc8*/ Spine.ExposedList<Spine.TrackEntry> timelineHoldMix;
        /*0xd0*/ Spine.ExposedList<float> timelinesRotation;

        /*0x738ad4c*/ TrackEntry();
        /*0x738a960*/ void add_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x738a9fc*/ void remove_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x738aa98*/ void OnStart();
        /*0x738aab8*/ void OnInterrupt();
        /*0x738aad8*/ void OnEnd();
        /*0x738aaf8*/ void OnDispose();
        /*0x738ab18*/ void OnComplete();
        /*0x738ab38*/ void OnEvent(Spine.Event e);
        /*0x738ab60*/ void Reset();
        /*0x738acb8*/ Spine.Animation get_Animation();
        /*0x738acc0*/ bool get_Loop();
        /*0x738acc8*/ float get_AnimationLast();
        /*0x73887c4*/ float get_AnimationTime();
        /*0x738acd0*/ float get_Alpha();
        /*0x738acd8*/ float get_InterruptAlpha();
        /*0x738ace0*/ float get_MixTime();
        /*0x738ace8*/ float get_MixDuration();
        /*0x738acf0*/ Spine.TrackEntry get_MixingFrom();
        /*0x738acf8*/ string ToString();
    }

    class EventQueue
    {
        /*0x10*/ System.Collections.Generic.List<Spine.EventQueue.EventQueueEntry> eventQueueEntries;
        /*0x18*/ bool drainDisabled;
        /*0x20*/ Spine.AnimationState state;
        /*0x28*/ Spine.Pool<Spine.TrackEntry> trackEntryPool;
        /*0x30*/ System.Action AnimationsChanged;

        /*0x738713c*/ EventQueue(Spine.AnimationState state, System.Action HandleAnimationsChanged, Spine.Pool<Spine.TrackEntry> trackEntryPool);
        /*0x738ae8c*/ void add_AnimationsChanged(System.Action value);
        /*0x738af28*/ void remove_AnimationsChanged(System.Action value);
        /*0x73899cc*/ void Start(Spine.TrackEntry entry);
        /*0x73898b0*/ void Interrupt(Spine.TrackEntry entry);
        /*0x73875a4*/ void End(Spine.TrackEntry entry);
        /*0x7389fb4*/ void Dispose(Spine.TrackEntry entry);
        /*0x7389540*/ void Complete(Spine.TrackEntry entry);
        /*0x7389418*/ void Event(Spine.TrackEntry entry, Spine.Event e);
        /*0x7387828*/ void Drain();

        struct EventQueueEntry
        {
            /*0x10*/ Spine.EventQueue.EventType type;
            /*0x18*/ Spine.TrackEntry entry;
            /*0x20*/ Spine.Event e;

            /*0x738afc4*/ EventQueueEntry(Spine.EventQueue.EventType eventType, Spine.TrackEntry trackEntry, Spine.Event e);
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

        /*0x3815fb8*/ Pool(int initialCapacity, int max);
        /*0x3814574*/ int get_Peak();
        /*0x3815ed0*/ void set_Peak(int value);
        /*0x3910ae8*/ T Obtain();
        /*0x3910ae8*/ void Free(T obj);
        /*0x3910ae8*/ void Reset(T obj);

        interface IPoolable<T>
        {
            /*0x38159dc*/ void Reset();
        }
    }

    class HashSetExtensions
    {
        static /*0x3825b78*/ bool AddAll<T>(System.Collections.Generic.HashSet<T> set, T[] addSet);
    }

    class AnimationStateData
    {
        /*0x10*/ Spine.SkeletonData skeletonData;
        /*0x18*/ System.Collections.Generic.Dictionary<Spine.AnimationStateData.AnimationPair, float> animationToMixTime;
        /*0x20*/ float defaultMix;

        /*0x738b004*/ AnimationStateData(Spine.SkeletonData skeletonData);
        /*0x738affc*/ void set_DefaultMix(float value);
        /*0x738b134*/ void SetMix(string fromName, string toName, float duration);
        /*0x738b250*/ void SetMix(Spine.Animation from, Spine.Animation to, float duration);
        /*0x7389e6c*/ float GetMix(Spine.Animation from, Spine.Animation to);

        struct AnimationPair
        {
            /*0x10*/ Spine.Animation a1;
            /*0x18*/ Spine.Animation a2;

            /*0x738b3b4*/ AnimationPair(Spine.Animation a1, Spine.Animation a2);
            /*0x738b3e4*/ string ToString();
        }

        class AnimationPairComparer : System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>
        {
            static /*0x0*/ Spine.AnimationStateData.AnimationPairComparer Instance;

            static /*0x738b4bc*/ AnimationPairComparer();
            /*0x738b4b4*/ AnimationPairComparer();
            /*0x738b448*/ bool System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.Equals(Spine.AnimationStateData.AnimationPair x, Spine.AnimationStateData.AnimationPair y);
            /*0x738b460*/ int System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.GetHashCode(Spine.AnimationStateData.AnimationPair obj);
        }
    }

    class Atlas : System.Collections.Generic.IEnumerable<Spine.AtlasRegion>, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<Spine.AtlasPage> pages;
        /*0x18*/ System.Collections.Generic.List<Spine.AtlasRegion> regions;
        /*0x20*/ Spine.TextureLoader textureLoader;

        static /*0x738c79c*/ int ReadEntry(string[] entry, string line);
        /*0x738b644*/ Atlas(System.Collections.Generic.List<Spine.AtlasPage> pages, System.Collections.Generic.List<Spine.AtlasRegion> regions);
        /*0x738b7fc*/ Atlas(System.IO.TextReader reader, string imagesDir, Spine.TextureLoader textureLoader);
        /*0x738b524*/ System.Collections.Generic.IEnumerator<Spine.AtlasRegion> GetEnumerator();
        /*0x738b5b4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x738c92c*/ void FlipV();
        /*0x738c9e4*/ Spine.AtlasRegion FindRegion(string name);

        class <>c__DisplayClass10_0
        {
            /*0x10*/ Spine.AtlasPage page;
            /*0x18*/ string[] entry;
            /*0x20*/ Spine.AtlasRegion region;

            /*0x738cab8*/ <>c__DisplayClass10_0();
            /*0x738cac0*/ void <.ctor>b__0();
            /*0x738cb90*/ void <.ctor>b__1();
            /*0x738cc90*/ void <.ctor>b__2();
            /*0x738cdf0*/ void <.ctor>b__3();
            /*0x738ce88*/ void <.ctor>b__4();
            /*0x738cf04*/ void <.ctor>b__5();
            /*0x738cfd4*/ void <.ctor>b__6();
            /*0x738d0a4*/ void <.ctor>b__7();
            /*0x738d1ec*/ void <.ctor>b__8();
            /*0x738d2c4*/ void <.ctor>b__9();
            /*0x738d394*/ void <.ctor>b__10();
            /*0x738d4e4*/ void <.ctor>b__11();
            /*0x738d5d8*/ void <.ctor>b__12();
        }
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
        /*0x18*/ int width;
        /*0x1c*/ int height;
        /*0x20*/ Spine.Format format;
        /*0x24*/ Spine.TextureFilter minFilter;
        /*0x28*/ Spine.TextureFilter magFilter;
        /*0x2c*/ Spine.TextureWrap uWrap;
        /*0x30*/ Spine.TextureWrap vWrap;
        /*0x34*/ bool pma;
        /*0x38*/ object rendererObject;

        /*0x738d6f0*/ AtlasPage();
        /*0x738d66c*/ Spine.AtlasPage Clone();
    }

    class AtlasRegion : Spine.TextureRegion
    {
        /*0x28*/ Spine.AtlasPage page;
        /*0x30*/ string name;
        /*0x38*/ int x;
        /*0x3c*/ int y;
        /*0x40*/ float offsetX;
        /*0x44*/ float offsetY;
        /*0x48*/ int originalWidth;
        /*0x4c*/ int originalHeight;
        /*0x50*/ int degrees;
        /*0x54*/ bool rotate;
        /*0x58*/ int index;
        /*0x60*/ string[] names;
        /*0x68*/ int[][] values;

        /*0x738d7ac*/ AtlasRegion();
        /*0x738d708*/ int get_packedWidth();
        /*0x738d710*/ void set_packedWidth(int value);
        /*0x738d718*/ int get_packedHeight();
        /*0x738d720*/ void set_packedHeight(int value);
        /*0x738d728*/ Spine.AtlasRegion Clone();
    }

    interface TextureLoader
    {
        /*0x3816810*/ void Load(Spine.AtlasPage page, string path);
    }

    class AtlasAttachmentLoader : Spine.AttachmentLoader
    {
        /*0x10*/ Spine.Atlas[] atlasArray;

        /*0x738d7b4*/ AtlasAttachmentLoader(Spine.Atlas[] atlasArray);
        /*0x738d844*/ void LoadSequence(string name, string basePath, Spine.Sequence sequence);
        /*0x738db08*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x738dcb0*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x738de9c*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
        /*0x738df58*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
        /*0x738e014*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
        /*0x738e070*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
        /*0x738da98*/ Spine.AtlasRegion FindRegion(string name);
    }

    class Attachment
    {
        /*0x10*/ string <Name>k__BackingField;

        /*0x738e134*/ Attachment(string name);
        /*0x738e12c*/ string get_Name();
        /*0x738e1c4*/ string ToString();
    }

    interface AttachmentLoader
    {
        /*0x3814c50*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x3814c50*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x3814b90*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
        /*0x3814b90*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
        /*0x3814b90*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
        /*0x3814b90*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
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
        Sequence = 7,
    }

    class BoundingBoxAttachment : Spine.VertexAttachment
    {
        /*0x738def4*/ BoundingBoxAttachment(string name);
    }

    class ClippingAttachment : Spine.VertexAttachment
    {
        /*0x40*/ Spine.SlotData endSlot;

        /*0x738e0c8*/ ClippingAttachment(string name);
        /*0x738e30c*/ Spine.SlotData get_EndSlot();
        /*0x738e314*/ void set_EndSlot(Spine.SlotData value);
    }

    interface IHasTextureRegion
    {
        /*0x38148bc*/ Spine.TextureRegion get_Region();
        /*0x3816710*/ void set_Region(Spine.TextureRegion value);
        /*0x38159dc*/ void UpdateRegion();
        /*0x38148bc*/ Spine.Sequence get_Sequence();
    }

    class MeshAttachment : Spine.VertexAttachment, Spine.IHasTextureRegion
    {
        /*0x40*/ Spine.TextureRegion region;
        /*0x48*/ string path;
        /*0x50*/ float[] regionUVs;
        /*0x58*/ float[] uvs;
        /*0x60*/ int[] triangles;
        /*0x68*/ float r;
        /*0x6c*/ float g;
        /*0x70*/ float b;
        /*0x74*/ float a;
        /*0x78*/ int hullLength;
        /*0x80*/ Spine.MeshAttachment parentMesh;
        /*0x88*/ Spine.Sequence sequence;
        /*0x90*/ int[] <Edges>k__BackingField;
        /*0x98*/ float <Width>k__BackingField;
        /*0x9c*/ float <Height>k__BackingField;

        /*0x738ddb8*/ MeshAttachment(string name);
        /*0x738e31c*/ Spine.TextureRegion get_Region();
        /*0x738de24*/ void set_Region(Spine.TextureRegion value);
        /*0x738e324*/ int get_HullLength();
        /*0x738e32c*/ void set_HullLength(int value);
        /*0x738e334*/ float[] get_UVs();
        /*0x738e33c*/ int[] get_Triangles();
        /*0x738e344*/ float get_R();
        /*0x738e34c*/ float get_G();
        /*0x738e354*/ float get_B();
        /*0x738e35c*/ float get_A();
        /*0x738e364*/ void set_Path(string value);
        /*0x738e36c*/ Spine.Sequence get_Sequence();
        /*0x738e374*/ void set_Sequence(Spine.Sequence value);
        /*0x738e37c*/ void set_ParentMesh(Spine.MeshAttachment value);
        /*0x738e40c*/ int[] get_Edges();
        /*0x738e414*/ void set_Edges(int[] value);
        /*0x738e41c*/ float get_Width();
        /*0x738e424*/ void set_Width(float value);
        /*0x738e42c*/ float get_Height();
        /*0x738e434*/ void set_Height(float value);
        /*0x738e43c*/ void UpdateRegion();
        /*0x738e850*/ void ComputeWorldVertices(Spine.Slot slot, int start, int count, float[] worldVertices, int offset, int stride);
    }

    class PathAttachment : Spine.VertexAttachment
    {
        /*0x40*/ float[] lengths;
        /*0x48*/ bool closed;
        /*0x49*/ bool constantSpeed;

        /*0x738dfb0*/ PathAttachment(string name);
        /*0x738eebc*/ float[] get_Lengths();
        /*0x738eec4*/ bool get_Closed();
        /*0x738eecc*/ bool get_ConstantSpeed();
    }

    class PointAttachment : Spine.Attachment
    {
        /*0x18*/ float x;
        /*0x1c*/ float y;
        /*0x20*/ float rotation;

        /*0x738e06c*/ PointAttachment(string name);
        /*0x738eed4*/ void ComputeWorldPosition(Spine.Bone bone, ref float ox, ref float oy);
        /*0x738ef60*/ float ComputeWorldRotation(Spine.Bone bone);
    }

    class RegionAttachment : Spine.Attachment, Spine.IHasTextureRegion
    {
        /*0x18*/ Spine.TextureRegion region;
        /*0x20*/ float x;
        /*0x24*/ float y;
        /*0x28*/ float rotation;
        /*0x2c*/ float scaleX;
        /*0x30*/ float scaleY;
        /*0x34*/ float width;
        /*0x38*/ float height;
        /*0x40*/ float[] offset;
        /*0x48*/ float[] uvs;
        /*0x50*/ float r;
        /*0x54*/ float g;
        /*0x58*/ float b;
        /*0x5c*/ float a;
        /*0x60*/ Spine.Sequence sequence;
        /*0x68*/ string <Path>k__BackingField;

        /*0x738dc14*/ RegionAttachment(string name);
        /*0x738f0d0*/ float get_X();
        /*0x738f0d8*/ float get_Y();
        /*0x738f0e0*/ float get_Rotation();
        /*0x738f0e8*/ float get_ScaleX();
        /*0x738f0f0*/ float get_ScaleY();
        /*0x738f0f8*/ float get_Width();
        /*0x738f100*/ float get_Height();
        /*0x738f108*/ float get_R();
        /*0x738f110*/ float get_G();
        /*0x738f118*/ float get_B();
        /*0x738f120*/ float get_A();
        /*0x738f128*/ void set_Path(string value);
        /*0x738f130*/ Spine.TextureRegion get_Region();
        /*0x738f138*/ void set_Region(Spine.TextureRegion value);
        /*0x738f140*/ float[] get_UVs();
        /*0x738f148*/ Spine.Sequence get_Sequence();
        /*0x738f150*/ void UpdateRegion();
        /*0x738f514*/ void ComputeWorldVertices(Spine.Slot slot, float[] worldVertices, int offset, int stride);
    }

    class Sequence
    {
        static /*0x0*/ int nextID;
        static /*0x8*/ object nextIdLock;
        /*0x10*/ int id;
        /*0x18*/ Spine.TextureRegion[] regions;
        /*0x20*/ int start;
        /*0x24*/ int digits;
        /*0x28*/ int setupIndex;

        static /*0x738f858*/ Sequence();
        /*0x738f6f0*/ Sequence(int count);
        /*0x738f6c8*/ void set_Start(int value);
        /*0x738f6d0*/ void set_Digits(int value);
        /*0x738f6d8*/ void set_SetupIndex(int value);
        /*0x738f6e0*/ Spine.TextureRegion[] get_Regions();
        /*0x738f6e8*/ int get_Id();
        /*0x738e8c0*/ void Apply(Spine.Slot slot, Spine.IHasTextureRegion attachment);
        /*0x738d98c*/ string GetPath(string basePath, int index);
    }

    enum SequenceMode
    {
        Hold = 0,
        Once = 1,
        Loop = 2,
        Pingpong = 3,
        OnceReverse = 4,
        LoopReverse = 5,
        PingpongReverse = 6,
    }

    class VertexAttachment : Spine.Attachment
    {
        static /*0x0*/ int nextID;
        static /*0x8*/ object nextIdLock;
        /*0x18*/ int id;
        /*0x20*/ Spine.VertexAttachment timelineAttachment;
        /*0x28*/ int[] bones;
        /*0x30*/ float[] vertices;
        /*0x38*/ int worldVerticesLength;

        static /*0x738f930*/ VertexAttachment();
        /*0x738e1cc*/ VertexAttachment(string name);
        /*0x738f8d8*/ int get_Id();
        /*0x738f8e0*/ int[] get_Bones();
        /*0x738f8e8*/ float[] get_Vertices();
        /*0x738f8f0*/ int get_WorldVerticesLength();
        /*0x738f8f8*/ void set_WorldVerticesLength(int value);
        /*0x738f900*/ Spine.VertexAttachment get_TimelineAttachment();
        /*0x738f908*/ void set_TimelineAttachment(Spine.VertexAttachment value);
        /*0x738f910*/ void ComputeWorldVertices(Spine.Slot slot, float[] worldVertices);
        /*0x738ea80*/ void ComputeWorldVertices(Spine.Slot slot, int start, int count, float[] worldVertices, int offset, int stride);
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
        /*0x68*/ float a;
        /*0x6c*/ float b;
        /*0x70*/ float worldX;
        /*0x74*/ float c;
        /*0x78*/ float d;
        /*0x7c*/ float worldY;
        /*0x80*/ Spine.Inherit inherit;
        /*0x84*/ bool sorted;
        /*0x85*/ bool active;

        /*0x738fbe0*/ Bone(Spine.BoneData data, Spine.Skeleton skeleton, Spine.Bone parent);
        /*0x738f9b0*/ Spine.BoneData get_Data();
        /*0x738f9b8*/ Spine.Skeleton get_Skeleton();
        /*0x738f9c0*/ Spine.Bone get_Parent();
        /*0x738f9c8*/ Spine.ExposedList<Spine.Bone> get_Children();
        /*0x738f9d0*/ bool get_Active();
        /*0x738f9d8*/ float get_X();
        /*0x738f9e0*/ void set_X(float value);
        /*0x738f9e8*/ float get_Y();
        /*0x738f9f0*/ void set_Y(float value);
        /*0x738f9f8*/ float get_Rotation();
        /*0x738fa00*/ void set_Rotation(float value);
        /*0x738fa08*/ float get_ScaleX();
        /*0x738fa10*/ void set_ScaleX(float value);
        /*0x738fa18*/ float get_ScaleY();
        /*0x738fa20*/ void set_ScaleY(float value);
        /*0x738fa28*/ float get_AppliedRotation();
        /*0x738fa30*/ void set_AppliedRotation(float value);
        /*0x738fa38*/ float get_AX();
        /*0x738fa40*/ void set_AX(float value);
        /*0x738fa48*/ float get_AY();
        /*0x738fa50*/ void set_AY(float value);
        /*0x738fa58*/ float get_AScaleX();
        /*0x738fa60*/ float get_AScaleY();
        /*0x738fa68*/ float get_A();
        /*0x738fa70*/ float get_B();
        /*0x738fa78*/ float get_C();
        /*0x738fa80*/ float get_D();
        /*0x738fa88*/ float get_WorldX();
        /*0x738fa90*/ float get_WorldY();
        /*0x738fa98*/ float get_WorldRotationX();
        /*0x738fb00*/ float get_WorldScaleX();
        /*0x738fb70*/ float get_WorldScaleY();
        /*0x738fd80*/ void Update(Spine.Skeleton.Physics physics);
        /*0x738fd94*/ void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY);
        /*0x738fd48*/ void SetToSetupPose();
        /*0x7390720*/ void UpdateAppliedTransform();
        /*0x7390ccc*/ void WorldToLocal(float worldX, float worldY, ref float localX, ref float localY);
        /*0x738ef24*/ void LocalToWorld(float localX, float localY, ref float worldX, ref float worldY);
        /*0x7390d18*/ string ToString();
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
        /*0x48*/ Spine.Inherit inherit;
        /*0x4c*/ bool skinRequired;

        /*0x7390d7c*/ BoneData(int index, string name, Spine.BoneData parent);
        /*0x7390d34*/ int get_Index();
        /*0x7390d3c*/ string get_Name();
        /*0x7390d44*/ float get_Length();
        /*0x7390d4c*/ void set_Length(float value);
        /*0x7390d54*/ float get_X();
        /*0x7390d5c*/ float get_Y();
        /*0x7390d64*/ float get_Rotation();
        /*0x7390d6c*/ float get_ScaleY();
        /*0x7390d74*/ Spine.Inherit get_Inherit();
        /*0x7390e84*/ string ToString();
    }

    enum Inherit
    {
        Normal = 0,
        OnlyTranslation = 1,
        NoRotationOrReflection = 2,
        NoScale = 3,
        NoScaleOrReflection = 4,
    }

    class InheritEnum
    {
        static /*0x0*/ Spine.Inherit[] Values;

        static /*0x7390e8c*/ InheritEnum();
    }

    class ConstraintData
    {
        /*0x10*/ string name;
        /*0x18*/ int order;
        /*0x1c*/ bool skinRequired;

        /*0x7390f2c*/ ConstraintData(string name);
        /*0x7390fbc*/ string ToString();
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

        /*0x7390fcc*/ Event(float time, Spine.EventData data);
        /*0x7390fc4*/ Spine.EventData get_Data();
        /*0x739106c*/ string ToString();
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

        /*0x73910f0*/ EventData(string name);
        /*0x7391088*/ string get_Name();
        /*0x7391090*/ int get_Int();
        /*0x7391098*/ void set_Int(int value);
        /*0x73910a0*/ float get_Float();
        /*0x73910a8*/ void set_Float(float value);
        /*0x73910b0*/ string get_String();
        /*0x73910b8*/ void set_String(string value);
        /*0x73910c0*/ string get_AudioPath();
        /*0x73910c8*/ void set_AudioPath(string value);
        /*0x73910d0*/ float get_Volume();
        /*0x73910d8*/ void set_Volume(float value);
        /*0x73910e0*/ float get_Balance();
        /*0x73910e8*/ void set_Balance(float value);
        /*0x7391180*/ string ToString();
    }

    class ExposedList<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        static int DefaultCapacity = 4;
        static /*0x0*/ T[] EmptyArray;
        /*0x0*/ T[] Items;
        /*0x0*/ int Count;
        /*0x0*/ int version;

        static /*0x383e7a0*/ ExposedList();
        /*0x38159dc*/ ExposedList();
        /*0x3815ed0*/ ExposedList(int capacity);
        /*0x3910ae8*/ void Add(T item);
        /*0x3815ed0*/ void GrowIfNeeded(int addedCount);
        /*0x3814964*/ Spine.ExposedList<T> Resize(int newSize);
        /*0x3815ed0*/ void EnsureCapacity(int min);
        /*0x3815cc4*/ void Clear(bool clearArray);
        /*0x3910ae8*/ bool Contains(T item);
        /*0x3816710*/ void CopyTo(T[] array);
        /*0x3910ae8*/ Spine.ExposedList.Enumerator<T> GetEnumerator();
        /*0x3910ae8*/ int IndexOf(T item);
        /*0x3815fb8*/ void Shift(int start, int delta);
        /*0x3815ed0*/ void RemoveAt(int index);
        /*0x38148bc*/ T[] ToArray();
        /*0x38159dc*/ void TrimExcess();
        /*0x3814574*/ int get_Capacity();
        /*0x3815ed0*/ void set_Capacity(int value);
        /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

        struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ Spine.ExposedList<T> l;
            /*0x0*/ int next;
            /*0x0*/ int ver;
            /*0x0*/ T current;

            /*0x3816710*/ Enumerator(Spine.ExposedList<T> l);
            /*0x38159dc*/ void Dispose();
            /*0x38159dc*/ void VerifyState();
            /*0x3813ffc*/ bool MoveNext();
            /*0x3910ae8*/ T get_Current();
            /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
            /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
        }
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

        static /*0x73915dc*/ void Apply(Spine.Bone bone, float targetX, float targetY, bool compress, bool stretch, bool uniform, float alpha);
        static /*0x7391a98*/ void Apply(Spine.Bone parent, Spine.Bone child, float targetX, float targetY, int bendDir, bool stretch, bool uniform, float softness, float alpha);
        /*0x7391188*/ IkConstraint(Spine.IkConstraintData data, Spine.Skeleton skeleton);
        /*0x73914d8*/ void SetToSetupPose();
        /*0x7391510*/ void Update(Spine.Skeleton.Physics physics);
        /*0x73924b8*/ Spine.Bone get_Target();
        /*0x73924c0*/ string ToString();
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

        /*0x73924dc*/ IkConstraintData(string name);
    }

    interface IUpdatable
    {
        /*0x3815ed0*/ void Update(Spine.Skeleton.Physics physics);
    }

    class Json
    {
        static /*0x7392568*/ object Deserialize(System.IO.TextReader text);
    }

    class MathUtils
    {
        static /*0x0*/ System.Random random;

        static /*0x73926d4*/ MathUtils();
        static /*0x73925ec*/ float Sin(float radians);
        static /*0x7392650*/ float Cos(float radians);
        static /*0x738f058*/ float Atan2Deg(float y, float x);
        static /*0x73906b4*/ float Atan2(float y, float x);
        static /*0x73926b4*/ float Clamp(float value, float min, float max);
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
        /*0x30*/ float mixRotate;
        /*0x34*/ float mixX;
        /*0x38*/ float mixY;
        /*0x3c*/ bool active;
        /*0x40*/ Spine.ExposedList<float> spaces;
        /*0x48*/ Spine.ExposedList<float> positions;
        /*0x50*/ Spine.ExposedList<float> world;
        /*0x58*/ Spine.ExposedList<float> curves;
        /*0x60*/ Spine.ExposedList<float> lengths;
        /*0x68*/ float[] segments;

        static /*0x7392b80*/ void ArraysFill(float[] a, int fromIndex, int toIndex, float val);
        static /*0x7394208*/ void AddBeforePosition(float p, float[] temp, int i, float[] output, int o);
        static /*0x7394358*/ void AddAfterPosition(float p, float[] temp, int i, float[] output, int o);
        static /*0x73944a8*/ void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, float[] output, int o, bool tangents);
        /*0x7392750*/ PathConstraint(Spine.PathConstraintData data, Spine.Skeleton skeleton);
        /*0x7392bcc*/ void SetToSetupPose();
        /*0x7392bf4*/ void Update(Spine.Skeleton.Physics physics);
        /*0x73934d8*/ float[] ComputeWorldPositions(Spine.PathAttachment path, int spacesCount, bool tangents);
        /*0x73946f0*/ string ToString();
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
        /*0x48*/ float mixRotate;
        /*0x4c*/ float mixX;
        /*0x50*/ float mixY;

        /*0x739470c*/ PathConstraintData(string name);
        /*0x7394798*/ Spine.ExposedList<Spine.BoneData> get_Bones();
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
        Proportional = 3,
    }

    enum RotateMode
    {
        Tangent = 0,
        Chain = 1,
        ChainScale = 2,
    }

    class PhysicsConstraint : Spine.IUpdatable
    {
        /*0x10*/ Spine.PhysicsConstraintData data;
        /*0x18*/ Spine.Bone bone;
        /*0x20*/ float inertia;
        /*0x24*/ float strength;
        /*0x28*/ float damping;
        /*0x2c*/ float massInverse;
        /*0x30*/ float wind;
        /*0x34*/ float gravity;
        /*0x38*/ float mix;
        /*0x3c*/ bool reset;
        /*0x40*/ float ux;
        /*0x44*/ float uy;
        /*0x48*/ float cx;
        /*0x4c*/ float cy;
        /*0x50*/ float tx;
        /*0x54*/ float ty;
        /*0x58*/ float xOffset;
        /*0x5c*/ float xVelocity;
        /*0x60*/ float yOffset;
        /*0x64*/ float yVelocity;
        /*0x68*/ float rotateOffset;
        /*0x6c*/ float rotateVelocity;
        /*0x70*/ float scaleOffset;
        /*0x74*/ float scaleVelocity;
        /*0x78*/ bool active;
        /*0x80*/ Spine.Skeleton skeleton;
        /*0x88*/ float remaining;
        /*0x8c*/ float lastTime;

        /*0x73947a0*/ PhysicsConstraint(Spine.PhysicsConstraintData data, Spine.Skeleton skeleton);
        /*0x73948e0*/ void Reset();
        /*0x7394918*/ void SetToSetupPose();
        /*0x7394948*/ void Translate(float x, float y);
        /*0x7394968*/ void Rotate(float x, float y, float degrees);
        /*0x7394a3c*/ void Update(Spine.Skeleton.Physics physics);
        /*0x739540c*/ string ToString();
    }

    class PhysicsConstraintData : Spine.ConstraintData
    {
        /*0x20*/ Spine.BoneData bone;
        /*0x28*/ float x;
        /*0x2c*/ float y;
        /*0x30*/ float rotate;
        /*0x34*/ float scaleX;
        /*0x38*/ float shearX;
        /*0x3c*/ float limit;
        /*0x40*/ float step;
        /*0x44*/ float inertia;
        /*0x48*/ float strength;
        /*0x4c*/ float damping;
        /*0x50*/ float massInverse;
        /*0x54*/ float wind;
        /*0x58*/ float gravity;
        /*0x5c*/ float mix;
        /*0x60*/ bool inertiaGlobal;
        /*0x61*/ bool strengthGlobal;
        /*0x62*/ bool dampingGlobal;
        /*0x63*/ bool massGlobal;
        /*0x64*/ bool windGlobal;
        /*0x65*/ bool gravityGlobal;
        /*0x66*/ bool mixGlobal;

        /*0x7395428*/ PhysicsConstraintData(string name);
    }

    class Skeleton
    {
        static /*0x0*/ int[] quadTriangles;
        /*0x10*/ Spine.SkeletonData data;
        /*0x18*/ Spine.ExposedList<Spine.Bone> bones;
        /*0x20*/ Spine.ExposedList<Spine.Slot> slots;
        /*0x28*/ Spine.ExposedList<Spine.Slot> drawOrder;
        /*0x30*/ Spine.ExposedList<Spine.IkConstraint> ikConstraints;
        /*0x38*/ Spine.ExposedList<Spine.TransformConstraint> transformConstraints;
        /*0x40*/ Spine.ExposedList<Spine.PathConstraint> pathConstraints;
        /*0x48*/ Spine.ExposedList<Spine.PhysicsConstraint> physicsConstraints;
        /*0x50*/ Spine.ExposedList<Spine.IUpdatable> updateCache;
        /*0x58*/ Spine.Skin skin;
        /*0x60*/ float r;
        /*0x64*/ float g;
        /*0x68*/ float b;
        /*0x6c*/ float a;
        /*0x70*/ float x;
        /*0x74*/ float y;
        /*0x78*/ float scaleX;
        /*0x7c*/ float time;
        /*0x80*/ float scaleY;

        static /*0x7397ea0*/ Skeleton();
        static /*0x7396e98*/ void SortReset(Spine.ExposedList<Spine.Bone> bones);
        /*0x73954fc*/ Skeleton(Spine.SkeletonData data);
        /*0x739542c*/ Spine.SkeletonData get_Data();
        /*0x7395434*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x739543c*/ Spine.ExposedList<Spine.Slot> get_Slots();
        /*0x7395444*/ Spine.ExposedList<Spine.Slot> get_DrawOrder();
        /*0x739544c*/ Spine.ExposedList<Spine.IkConstraint> get_IkConstraints();
        /*0x7395454*/ Spine.ExposedList<Spine.TransformConstraint> get_TransformConstraints();
        /*0x739545c*/ Spine.Skin get_Skin();
        /*0x7395464*/ float get_R();
        /*0x739546c*/ void set_R(float value);
        /*0x7395474*/ float get_G();
        /*0x739547c*/ void set_G(float value);
        /*0x7395484*/ float get_B();
        /*0x739548c*/ void set_B(float value);
        /*0x7395494*/ float get_A();
        /*0x739549c*/ void set_A(float value);
        /*0x73954a4*/ float get_ScaleX();
        /*0x73954ac*/ void set_ScaleX(float value);
        /*0x7390658*/ float get_ScaleY();
        /*0x73954b4*/ void set_ScaleY(float value);
        /*0x73954bc*/ Spine.Bone get_RootBone();
        /*0x73962ac*/ void UpdateCache();
        /*0x7396604*/ void SortIkConstraint(Spine.IkConstraint constraint);
        /*0x73967f8*/ void SortTransformConstraint(Spine.TransformConstraint constraint);
        /*0x7396a48*/ void SortPathConstraint(Spine.PathConstraint constraint);
        /*0x7396f60*/ void SortPathConstraintAttachment(Spine.Skin skin, int slotIndex, Spine.Bone slotBone);
        /*0x7397270*/ void SortPathConstraintAttachment(Spine.Attachment attachment, Spine.Bone slotBone);
        /*0x7396cd4*/ void SortPhysicsConstraint(Spine.PhysicsConstraint constraint);
        /*0x7396e10*/ void SortBone(Spine.Bone bone);
        /*0x73973ec*/ void UpdateWorldTransform(Spine.Skeleton.Physics physics);
        /*0x7397544*/ void PhysicsTranslate(float x, float y);
        /*0x73975b8*/ void PhysicsRotate(float x, float y, float degrees);
        /*0x7397644*/ void Update(float delta);
        /*0x7397654*/ void SetToSetupPose();
        /*0x739766c*/ void SetBonesToSetupPose();
        /*0x7397800*/ void SetSlotsToSetupPose();
        /*0x739788c*/ Spine.Bone FindBone(string boneName);
        /*0x739797c*/ Spine.Slot FindSlot(string slotName);
        /*0x7397a6c*/ void SetSkin(string skinName);
        /*0x7397b10*/ void SetSkin(Spine.Skin newSkin);
        /*0x7397c10*/ Spine.Attachment GetAttachment(int slotIndex, string attachmentName);
        /*0x7397cd8*/ void SetAttachment(string slotName, string attachmentName);
        /*0x7397e84*/ string ToString();

        enum Physics
        {
            None = 0,
            Reset = 1,
            Update = 2,
            Pose = 3,
        }
    }

    class SkeletonBinary : Spine.SkeletonLoader
    {
        /*0x20*/ System.Collections.Generic.List<Spine.SkeletonBinary.LinkedMesh> linkedMeshes;

        /*0x7397f40*/ SkeletonBinary(Spine.AttachmentLoader attachmentLoader);
        /*0x7397fd0*/ Spine.SkeletonData ReadSkeletonData(System.IO.Stream file);
        /*0x73999f0*/ Spine.Skin ReadSkin(Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData, bool defaultSkin, bool nonessential);
        /*0x739cad0*/ Spine.Attachment ReadAttachment(Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData, Spine.Skin skin, int slotIndex, string attachmentName, bool nonessential);
        /*0x739d6d4*/ Spine.Sequence ReadSequence(Spine.SkeletonBinary.SkeletonInput input);
        /*0x739d78c*/ Spine.SkeletonBinary.Vertices ReadVertices(Spine.SkeletonBinary.SkeletonInput input, bool weighted);
        /*0x739da38*/ float[] ReadFloatArray(Spine.SkeletonBinary.SkeletonInput input, int n, float scale);
        /*0x739db48*/ int[] ReadShortArray(Spine.SkeletonBinary.SkeletonInput input, int n);
        /*0x7399ec4*/ Spine.Animation ReadAnimation(string name, Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData);
        /*0x739dcd8*/ void ReadTimeline(Spine.SkeletonBinary.SkeletonInput input, Spine.ExposedList<Spine.Timeline> timelines, Spine.CurveTimeline1 timeline, float scale);
        /*0x739de84*/ void ReadTimeline(Spine.SkeletonBinary.SkeletonInput input, Spine.ExposedList<Spine.Timeline> timelines, Spine.CurveTimeline2 timeline, float scale);
        /*0x739dbf8*/ void SetBezier(Spine.SkeletonBinary.SkeletonInput input, Spine.CurveTimeline timeline, int bezier, int frame, int value, float time1, float time2, float value1, float value2, float scale);

        class Vertices
        {
            /*0x10*/ int length;
            /*0x18*/ int[] bones;
            /*0x20*/ float[] vertices;

            /*0x739e094*/ Vertices();
        }

        class SkeletonInput
        {
            /*0x10*/ byte[] chars;
            /*0x18*/ byte[] bytesBigEndian;
            /*0x20*/ string[] strings;
            /*0x28*/ System.IO.Stream input;

            /*0x739e09c*/ SkeletonInput(System.IO.Stream input);
            /*0x739e138*/ int Read();
            /*0x739e15c*/ byte ReadUByte();
            /*0x739e184*/ bool ReadBoolean();
            /*0x739e1b4*/ float ReadFloat();
            /*0x739e2b4*/ int ReadInt();
            /*0x739e338*/ long ReadLong();
            /*0x739e3fc*/ int ReadInt(bool optimizePositive);
            /*0x739e4cc*/ string ReadString();
            /*0x739e658*/ string ReadStringRef();
            /*0x739e5b0*/ void ReadFully(byte[] buffer, int offset, int length);
        }

        class LinkedMesh
        {
            /*0x10*/ string parent;
            /*0x18*/ int skinIndex;
            /*0x1c*/ int slotIndex;
            /*0x20*/ Spine.MeshAttachment mesh;
            /*0x28*/ bool inheritTimelines;

            /*0x739e6a4*/ LinkedMesh(Spine.MeshAttachment mesh, int skinIndex, int slotIndex, string parent, bool inheritTimelines);
        }
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

        static /*0x739e9ec*/ void MakeClockwise(Spine.ExposedList<float> polygon);
        /*0x73a0980*/ SkeletonClipping();
        /*0x739e710*/ Spine.ExposedList<float> get_ClippedVertices();
        /*0x739e718*/ Spine.ExposedList<int> get_ClippedTriangles();
        /*0x739e720*/ Spine.ExposedList<float> get_ClippedUVs();
        /*0x739e728*/ bool get_IsClipping();
        /*0x739e738*/ int ClipStart(Spine.Slot slot, Spine.ClippingAttachment clip);
        /*0x739fbf4*/ void ClipEnd(Spine.Slot slot);
        /*0x739fc28*/ void ClipEnd();
        /*0x739fcf0*/ void ClipTriangles(float[] vertices, int[] triangles, int trianglesLength, float[] uvs);
        /*0x73a0468*/ bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, Spine.ExposedList<float> clippingArea, Spine.ExposedList<float> output);
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
        /*0x60*/ Spine.ExposedList<Spine.PhysicsConstraintData> physicsConstraints;
        /*0x68*/ float x;
        /*0x6c*/ float y;
        /*0x70*/ float width;
        /*0x74*/ float height;
        /*0x78*/ float referenceScale;
        /*0x80*/ string version;
        /*0x88*/ string hash;
        /*0x90*/ float fps;
        /*0x98*/ string imagesPath;
        /*0xa0*/ string audioPath;

        /*0x73a17d4*/ SkeletonData();
        /*0x73a0d9c*/ Spine.ExposedList<Spine.BoneData> get_Bones();
        /*0x73a0da4*/ Spine.ExposedList<Spine.SlotData> get_Slots();
        /*0x73a0dac*/ Spine.ExposedList<Spine.Skin> get_Skins();
        /*0x73a0db4*/ Spine.Skin get_DefaultSkin();
        /*0x73a0dbc*/ Spine.ExposedList<Spine.Animation> get_Animations();
        /*0x73a0dc4*/ Spine.ExposedList<Spine.IkConstraintData> get_IkConstraints();
        /*0x73a0dcc*/ Spine.ExposedList<Spine.TransformConstraintData> get_TransformConstraints();
        /*0x73a0dd4*/ float get_Width();
        /*0x73a0ddc*/ float get_Height();
        /*0x73a0de4*/ Spine.BoneData FindBone(string boneName);
        /*0x73a0ecc*/ Spine.SlotData FindSlot(string slotName);
        /*0x73a0fb4*/ Spine.Skin FindSkin(string skinName);
        /*0x73a1170*/ Spine.EventData FindEvent(string eventDataName);
        /*0x73a132c*/ Spine.Animation FindAnimation(string animationName);
        /*0x73a1414*/ Spine.IkConstraintData FindIkConstraint(string constraintName);
        /*0x73a14fc*/ Spine.TransformConstraintData FindTransformConstraint(string constraintName);
        /*0x73a15e4*/ Spine.PathConstraintData FindPathConstraint(string constraintName);
        /*0x73a16d0*/ Spine.PhysicsConstraintData FindPhysicsConstraint(string constraintName);
        /*0x73a17bc*/ string ToString();
    }

    class SkeletonJson : Spine.SkeletonLoader
    {
        /*0x20*/ System.Collections.Generic.List<Spine.SkeletonJson.LinkedMesh> linkedMeshes;

        static /*0x73aec3c*/ Spine.Sequence ReadSequence(object sequenceJson);
        static /*0x73af888*/ Spine.Timeline ReadTimeline(ref System.Collections.Generic.List.Enumerator<object> keyMapEnumerator, Spine.CurveTimeline1 timeline, float defaultValue, float scale);
        static /*0x73afb48*/ Spine.Timeline ReadTimeline(ref System.Collections.Generic.List.Enumerator<object> keyMapEnumerator, Spine.CurveTimeline2 timeline, string name1, string name2, float defaultValue, float scale);
        static /*0x73af62c*/ int ReadCurve(object curve, Spine.CurveTimeline timeline, int bezier, int frame, int value, float time1, float time2, float value1, float value2, float scale);
        static /*0x73afe70*/ void SetBezier(Spine.CurveTimeline timeline, int frame, int value, int bezier, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2);
        static /*0x73af160*/ float[] GetFloatArray(System.Collections.Generic.Dictionary<string, object> map, string name, float scale);
        static /*0x73af370*/ int[] GetIntArray(System.Collections.Generic.Dictionary<string, object> map, string name);
        static /*0x73a68c8*/ float GetFloat(System.Collections.Generic.Dictionary<string, object> map, string name, float defaultValue);
        static /*0x73a6d98*/ int GetInt(System.Collections.Generic.Dictionary<string, object> map, string name, int defaultValue);
        static /*0x73af50c*/ int GetInt(System.Collections.Generic.Dictionary<string, object> map, string name);
        static /*0x73a6a48*/ bool GetBoolean(System.Collections.Generic.Dictionary<string, object> map, string name, bool defaultValue);
        static /*0x73a698c*/ string GetString(System.Collections.Generic.Dictionary<string, object> map, string name, string defaultValue);
        static /*0x73a6c50*/ float ToColor(string hexString, int colorIndex, int expectedLength);
        /*0x73a1adc*/ SkeletonJson(Spine.AttachmentLoader attachmentLoader);
        /*0x73a1c00*/ Spine.SkeletonData ReadSkeletonData(System.IO.TextReader reader);
        /*0x73a71b8*/ Spine.Attachment ReadAttachment(System.Collections.Generic.Dictionary<string, object> map, Spine.Skin skin, int slotIndex, string name, Spine.SkeletonData skeletonData);
        /*0x73aed94*/ void ReadVertices(System.Collections.Generic.Dictionary<string, object> map, Spine.VertexAttachment attachment, int verticesLength);
        /*0x73a70dc*/ int FindSlotIndex(Spine.SkeletonData skeletonData, string slotName);
        /*0x73a80b4*/ void ReadAnimation(System.Collections.Generic.Dictionary<string, object> map, string name, Spine.SkeletonData skeletonData);

        class LinkedMesh
        {
            /*0x10*/ string parent;
            /*0x18*/ string skin;
            /*0x20*/ int slotIndex;
            /*0x28*/ Spine.MeshAttachment mesh;
            /*0x30*/ bool inheritTimelines;

            /*0x73af0e4*/ LinkedMesh(Spine.MeshAttachment mesh, string skin, int slotIndex, string parent, bool inheritTimelines);
        }
    }

    class SkeletonLoader
    {
        /*0x10*/ Spine.AttachmentLoader attachmentLoader;
        /*0x18*/ float scale;

        /*0x73a1b68*/ SkeletonLoader(Spine.AttachmentLoader attachmentLoader);
        /*0x73afe94*/ float get_Scale();
        /*0x73afe9c*/ void set_Scale(float value);
    }

    class Skin
    {
        /*0x10*/ string name;
        /*0x18*/ System.Collections.Generic.Dictionary<Spine.Skin.SkinKey, Spine.Skin.SkinEntry> attachments;
        /*0x20*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x28*/ Spine.ExposedList<Spine.ConstraintData> constraints;

        /*0x73a6f04*/ Skin(string name);
        /*0x73aff1c*/ string get_Name();
        /*0x73aff24*/ System.Collections.Generic.ICollection<Spine.Skin.SkinEntry> get_Attachments();
        /*0x73a7ebc*/ void SetAttachment(int slotIndex, string name, Spine.Attachment attachment);
        /*0x73a8000*/ Spine.Attachment GetAttachment(int slotIndex, string name);
        /*0x73b0090*/ void GetAttachments(int slotIndex, System.Collections.Generic.List<Spine.Skin.SkinEntry> attachments);
        /*0x73b03a4*/ string ToString();
        /*0x73b03ac*/ void AttachAll(Spine.Skeleton skeleton, Spine.Skin oldSkin);

        struct SkinEntry
        {
            /*0x10*/ int slotIndex;
            /*0x18*/ string name;
            /*0x20*/ Spine.Attachment attachment;

            /*0x73b0058*/ SkinEntry(int slotIndex, string name, Spine.Attachment attachment);
            /*0x73b0684*/ int get_SlotIndex();
            /*0x73b068c*/ string get_Name();
            /*0x73b0694*/ Spine.Attachment get_Attachment();
        }

        struct SkinKey
        {
            /*0x10*/ int slotIndex;
            /*0x18*/ string name;
            /*0x20*/ int hashCode;

            /*0x73aff74*/ SkinKey(int slotIndex, string name);
        }

        class SkinKeyComparer : System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>
        {
            static /*0x0*/ Spine.Skin.SkinKeyComparer Instance;

            static /*0x73b06d8*/ SkinKeyComparer();
            /*0x73b06d0*/ SkinKeyComparer();
            /*0x73b069c*/ bool System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.Equals(Spine.Skin.SkinKey e1, Spine.Skin.SkinKey e2);
            /*0x73b06c8*/ int System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.GetHashCode(Spine.Skin.SkinKey e);
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
        /*0x48*/ int sequenceIndex;
        /*0x50*/ Spine.ExposedList<float> deform;
        /*0x58*/ int attachmentState;

        /*0x73b0740*/ Slot(Spine.SlotData data, Spine.Bone bone);
        /*0x73b093c*/ Spine.SlotData get_Data();
        /*0x73b0944*/ Spine.Bone get_Bone();
        /*0x73b094c*/ Spine.Skeleton get_Skeleton();
        /*0x73b0968*/ float get_R();
        /*0x73b0970*/ float get_G();
        /*0x73b0978*/ float get_B();
        /*0x73b0980*/ float get_A();
        /*0x73b0988*/ void ClampColor();
        /*0x73b0a50*/ float get_R2();
        /*0x73b0a58*/ float get_G2();
        /*0x73b0a60*/ float get_B2();
        /*0x73b0a68*/ bool get_HasSecondColor();
        /*0x73b0a84*/ void ClampSecondColor();
        /*0x73b0b30*/ Spine.Attachment get_Attachment();
        /*0x73b0588*/ void set_Attachment(Spine.Attachment value);
        /*0x73b0b38*/ int get_SequenceIndex();
        /*0x73b0b40*/ void set_SequenceIndex(int value);
        /*0x73b0b48*/ Spine.ExposedList<float> get_Deform();
        /*0x73b08a4*/ void SetToSetupPose();
        /*0x73b0b50*/ string ToString();
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

        /*0x73a6b14*/ SlotData(int index, string name, Spine.BoneData boneData);
        /*0x73b0b6c*/ int get_Index();
        /*0x73b0b74*/ string get_Name();
        /*0x73b0b7c*/ Spine.BlendMode get_BlendMode();
        /*0x73b0b84*/ string ToString();
    }

    class TextureRegion
    {
        /*0x10*/ int width;
        /*0x14*/ int height;
        /*0x18*/ float u;
        /*0x1c*/ float v;
        /*0x20*/ float u2;
        /*0x24*/ float v2;

        /*0x73b0b8c*/ TextureRegion();
    }

    class TransformConstraint : Spine.IUpdatable
    {
        /*0x10*/ Spine.TransformConstraintData data;
        /*0x18*/ Spine.ExposedList<Spine.Bone> bones;
        /*0x20*/ Spine.Bone target;
        /*0x28*/ float mixRotate;
        /*0x2c*/ float mixX;
        /*0x30*/ float mixY;
        /*0x34*/ float mixScaleX;
        /*0x38*/ float mixScaleY;
        /*0x3c*/ float mixShearY;
        /*0x40*/ bool active;

        /*0x73b0b94*/ TransformConstraint(Spine.TransformConstraintData data, Spine.Skeleton skeleton);
        /*0x73b0ea8*/ void SetToSetupPose();
        /*0x73b0ed0*/ void Update(Spine.Skeleton.Physics physics);
        /*0x73b16c0*/ void ApplyAbsoluteWorld();
        /*0x73b1230*/ void ApplyRelativeWorld();
        /*0x73b10a0*/ void ApplyAbsoluteLocal();
        /*0x73b0f64*/ void ApplyRelativeLocal();
        /*0x73b1bfc*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x73b1c04*/ Spine.Bone get_Target();
        /*0x73b1c0c*/ string ToString();
    }

    class TransformConstraintData : Spine.ConstraintData
    {
        /*0x20*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x28*/ Spine.BoneData target;
        /*0x30*/ float mixRotate;
        /*0x34*/ float mixX;
        /*0x38*/ float mixY;
        /*0x3c*/ float mixScaleX;
        /*0x40*/ float mixScaleY;
        /*0x44*/ float mixShearY;
        /*0x48*/ float offsetRotation;
        /*0x4c*/ float offsetX;
        /*0x50*/ float offsetY;
        /*0x54*/ float offsetScaleX;
        /*0x58*/ float offsetScaleY;
        /*0x5c*/ float offsetShearY;
        /*0x60*/ bool relative;
        /*0x61*/ bool local;

        /*0x73a6e74*/ TransformConstraintData(string name);
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

        static /*0x73b1c28*/ bool IsConcave(int index, int vertexCount, float[] vertices, int[] indices);
        static /*0x73b1d40*/ bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
        static /*0x73b1d6c*/ int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
        /*0x73a0b4c*/ Triangulator();
        /*0x739eb34*/ Spine.ExposedList<int> Triangulate(Spine.ExposedList<float> verticesArray);
        /*0x739f134*/ Spine.ExposedList<Spine.ExposedList<float>> Decompose(Spine.ExposedList<float> verticesArray, Spine.ExposedList<int> triangles);
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 753D5E1ADA77B20B9959A1030B8E0BA5CF925F2881D3635C3F791E5A0AE0EEB1;
    static /*0x18*/ <PrivateImplementationDetails> E528F4309E1413E6BC35AEA5D8DB8519384D2FCC33F9DD5D1126D73F104CF92A;

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }
}
