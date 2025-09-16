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

        static /*0x7366a10*/ SharpJson.Lexer.Token NextToken(char[] json, ref int index);
        /*0x7366228*/ Lexer(string text);
        /*0x73661fc*/ bool get_hasError();
        /*0x736620c*/ int get_lineNumber();
        /*0x7366214*/ void set_lineNumber(int value);
        /*0x736621c*/ void set_parseNumbersAsFloat(bool value);
        /*0x73662d8*/ void Reset();
        /*0x73662ec*/ string ParseString();
        /*0x73667dc*/ string GetNumberString();
        /*0x73668a4*/ float ParseFloatNumber();
        /*0x7366940*/ double ParseDoubleNumber();
        /*0x7366824*/ int GetLastIndexOfNumber(int index);
        /*0x7366748*/ void SkipWhiteSpaces();
        /*0x73669dc*/ SharpJson.Lexer.Token LookAhead();
        /*0x7366c64*/ SharpJson.Lexer.Token NextToken();

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

        /*0x7366ca4*/ JsonDecoder();
        /*0x7366c80*/ string get_errorMessage();
        /*0x7366c88*/ void set_errorMessage(string value);
        /*0x7366c90*/ bool get_parseNumbersAsFloat();
        /*0x7366c98*/ void set_parseNumbersAsFloat(bool value);
        /*0x7366cd0*/ object Decode(string text);
        /*0x7366f64*/ System.Collections.Generic.IDictionary<string, object> ParseObject();
        /*0x73671fc*/ System.Collections.Generic.IList<object> ParseArray();
        /*0x7366d6c*/ object ParseValue();
        /*0x7367160*/ void TriggerError(string message);
        /*0x3907c14*/ T EvalLexer<T>(T value);
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

        /*0x73673bc*/ Animation(string name, Spine.ExposedList<Spine.Timeline> timelines, float duration);
        /*0x73676b0*/ Spine.ExposedList<Spine.Timeline> get_Timelines();
        /*0x7367470*/ void SetTimelines(Spine.ExposedList<Spine.Timeline> timelines);
        /*0x73676b8*/ float get_Duration();
        /*0x73676c0*/ string get_Name();
        /*0x73676c8*/ bool HasTimeline(string[] propertyIds);
        /*0x7367780*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, bool loop, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x73678e0*/ string ToString();
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

        static /*0x7367a64*/ int Search(float[] frames, float time);
        static /*0x7367ab8*/ int Search(float[] frames, float time, int step);
        /*0x73678e8*/ Timeline(int frameCount, string[] propertyIds);
        /*0x73679e0*/ string[] get_PropertyIds();
        /*0x73679e8*/ float[] get_Frames();
        /*0x73679f0*/ int get_FrameEntries();
        /*0x73679f8*/ int get_FrameCount();
        /*0x7367a24*/ float get_Duration();
        void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    interface IBoneTimeline
    {
        /*0x380b6a0*/ int get_BoneIndex();
    }

    class CurveTimeline : Spine.Timeline
    {
        /*0x20*/ float[] curves;

        /*0x7367b10*/ CurveTimeline(int frameCount, int bezierCount, string[] propertyIds);
        /*0x7367bc8*/ void SetStepped(int frame);
        /*0x7367bfc*/ void Shrink(int bezierCount);
        /*0x7367cb8*/ void SetBezier(int bezier, int frame, int value, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2);
        /*0x7367e5c*/ float GetBezierValue(float time, int frameIndex, int valueOffset, int i);
    }

    class CurveTimeline1 : Spine.CurveTimeline
    {
        /*0x7367ff8*/ CurveTimeline1(int frameCount, int bezierCount, string propertyId);
        /*0x7368098*/ int get_FrameEntries();
        /*0x73680a0*/ void SetFrame(int frame, float time, float value);
        /*0x73680ec*/ float GetCurveValue(float time);
        /*0x736821c*/ float GetRelativeValue(float time, float alpha, Spine.MixBlend blend, float current, float setup);
        /*0x73682bc*/ float GetAbsoluteValue(float time, float alpha, Spine.MixBlend blend, float current, float setup);
        /*0x7368350*/ float GetAbsoluteValue(float time, float alpha, Spine.MixBlend blend, float current, float setup, float value);
        /*0x73683c0*/ float GetScaleValue(float time, float alpha, Spine.MixBlend blend, Spine.MixDirection direction, float current, float setup);
    }

    class CurveTimeline2 : Spine.CurveTimeline
    {
        /*0x73685b0*/ CurveTimeline2(int frameCount, int bezierCount, string propertyId1, string propertyId2);
        /*0x7368674*/ int get_FrameEntries();
        /*0x736867c*/ void SetFrame(int frame, float time, float value1, float value2);
    }

    class RotateTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x73686d8*/ RotateTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7368784*/ int get_BoneIndex();
        /*0x736878c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TranslateTimeline : Spine.CurveTimeline2, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7368800*/ TranslateTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x73688f0*/ int get_BoneIndex();
        /*0x73688f8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x7368a54*/ void GetCurveValue(ref float x, ref float y, float time);
    }

    class TranslateXTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7368c28*/ TranslateXTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7368cd8*/ int get_BoneIndex();
        /*0x7368ce0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TranslateYTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7368d54*/ TranslateYTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7368e04*/ int get_BoneIndex();
        /*0x7368e0c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ScaleTimeline : Spine.CurveTimeline2, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7368e80*/ ScaleTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7368f70*/ int get_BoneIndex();
        /*0x7368f78*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ScaleXTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7369464*/ ScaleXTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7369514*/ int get_BoneIndex();
        /*0x736951c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ScaleYTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7369594*/ ScaleYTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7369644*/ int get_BoneIndex();
        /*0x736964c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ShearTimeline : Spine.CurveTimeline2, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x73696c4*/ ShearTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x73697b4*/ int get_BoneIndex();
        /*0x73697bc*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ShearXTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7369ab8*/ ShearXTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7369b68*/ int get_BoneIndex();
        /*0x7369b70*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class ShearYTimeline : Spine.CurveTimeline1, Spine.IBoneTimeline
    {
        /*0x28*/ int boneIndex;

        /*0x7369be4*/ ShearYTimeline(int frameCount, int bezierCount, int boneIndex);
        /*0x7369c94*/ int get_BoneIndex();
        /*0x7369c9c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class InheritTimeline : Spine.Timeline, Spine.IBoneTimeline
    {
        /*0x20*/ int boneIndex;

        /*0x7369d10*/ InheritTimeline(int frameCount, int boneIndex);
        /*0x7369e04*/ int get_BoneIndex();
        /*0x7369e0c*/ int get_FrameEntries();
        /*0x7369e14*/ void SetFrame(int frame, float time, Spine.Inherit inherit);
        /*0x7369e64*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGBATimeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x7369fe8*/ RGBATimeline(int frameCount, int bezierCount, int slotIndex);
        /*0x736a144*/ int get_FrameEntries();
        /*0x736a14c*/ void SetFrame(int frame, float time, float r, float g, float b, float a);
        /*0x736a1d0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGBTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x736a5cc*/ RGBTimeline(int frameCount, int bezierCount, int slotIndex);
        /*0x736a6c8*/ int get_FrameEntries();
        /*0x736a6d0*/ void SetFrame(int frame, float time, float r, float g, float b);
        /*0x736a744*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class AlphaTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int slotIndex;

        /*0x736aab8*/ AlphaTimeline(int frameCount, int bezierCount, int slotIndex);
        /*0x736ab68*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGBA2Timeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x736ac80*/ RGBA2Timeline(int frameCount, int bezierCount, int slotIndex);
        /*0x736ae34*/ int get_FrameEntries();
        /*0x736ae3c*/ void SetFrame(int frame, float time, float r, float g, float b, float a, float r2, float g2, float b2);
        /*0x736af04*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class RGB2Timeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;

        /*0x736b4e4*/ RGB2Timeline(int frameCount, int bezierCount, int slotIndex);
        /*0x736b640*/ int get_FrameEntries();
        /*0x736b648*/ void SetFrame(int frame, float time, float r, float g, float b, float r2, float g2, float b2);
        /*0x736b6f8*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class AttachmentTimeline : Spine.Timeline
    {
        /*0x20*/ int slotIndex;
        /*0x28*/ string[] attachmentNames;

        /*0x736bc7c*/ AttachmentTimeline(int frameCount, int slotIndex);
        /*0x736bd8c*/ int get_SlotIndex();
        /*0x736bd94*/ string[] get_AttachmentNames();
        /*0x736bd9c*/ void SetFrame(int frame, float time, string attachmentName);
        /*0x736bdf0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x736bee4*/ void SetAttachment(Spine.Skeleton skeleton, Spine.Slot slot, string attachmentName);
    }

    class DeformTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int slotIndex;
        /*0x30*/ Spine.VertexAttachment attachment;
        /*0x38*/ float[][] vertices;

        /*0x736bf30*/ DeformTimeline(int frameCount, int bezierCount, int slotIndex, Spine.VertexAttachment attachment);
        /*0x736c130*/ void SetFrame(int frame, float time, float[] vertices);
        /*0x736c184*/ float GetCurvePercent(float time, int frame);
        /*0x736c3b4*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class EventTimeline : Spine.Timeline
    {
        static /*0x0*/ string[] propertyIds;
        /*0x20*/ Spine.Event[] events;

        static /*0x736d228*/ EventTimeline();
        /*0x736cee0*/ EventTimeline(int frameCount);
        /*0x736cf80*/ void SetFrame(int frame, Spine.Event e);
        /*0x736d014*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class DrawOrderTimeline : Spine.Timeline
    {
        static /*0x0*/ string[] propertyIds;
        /*0x20*/ int[][] drawOrders;

        static /*0x736d5a4*/ DrawOrderTimeline();
        /*0x736d2e0*/ DrawOrderTimeline(int frameCount);
        /*0x736d380*/ void SetFrame(int frame, float time, int[] drawOrder);
        /*0x736d3d4*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class IkConstraintTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int constraintIndex;

        /*0x736d65c*/ IkConstraintTimeline(int frameCount, int bezierCount, int ikConstraintIndex);
        /*0x736d758*/ int get_FrameEntries();
        /*0x736d760*/ void SetFrame(int frame, float time, float mix, float softness, int bendDirection, bool compress, bool stretch);
        /*0x736d81c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class TransformConstraintTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int constraintIndex;

        /*0x736db88*/ TransformConstraintTimeline(int frameCount, int bezierCount, int transformConstraintIndex);
        /*0x736dc84*/ int get_FrameEntries();
        /*0x736dc8c*/ int get_TransformConstraintIndex();
        /*0x736dc94*/ void SetFrame(int frame, float time, float mixRotate, float mixX, float mixY, float mixScaleX, float mixScaleY, float mixShearY);
        /*0x736dd44*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        /*0x736df10*/ void GetCurveValue(ref float rotate, ref float x, ref float y, ref float scaleX, ref float scaleY, ref float shearY, float time);
    }

    class PathConstraintPositionTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int constraintIndex;

        /*0x736e2dc*/ PathConstraintPositionTimeline(int frameCount, int bezierCount, int pathConstraintIndex);
        /*0x736e38c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PathConstraintSpacingTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int constraintIndex;

        /*0x736e400*/ PathConstraintSpacingTimeline(int frameCount, int bezierCount, int pathConstraintIndex);
        /*0x736e4b0*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PathConstraintMixTimeline : Spine.CurveTimeline
    {
        /*0x28*/ int constraintIndex;

        /*0x736e524*/ PathConstraintMixTimeline(int frameCount, int bezierCount, int pathConstraintIndex);
        /*0x736e620*/ int get_FrameEntries();
        /*0x736e628*/ void SetFrame(int frame, float time, float mixRotate, float mixX, float mixY);
        /*0x736e69c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class PhysicsConstraintTimeline : Spine.CurveTimeline1
    {
        /*0x28*/ int constraintIndex;

        /*0x736e9f4*/ PhysicsConstraintTimeline(int frameCount, int bezierCount, int physicsConstraintIndex, Spine.Property property);
        /*0x736eaa4*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
        float Setup(Spine.PhysicsConstraint constraint);
        float Get(Spine.PhysicsConstraint constraint);
        void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x380b2f0*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintInertiaTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x736eca0*/ PhysicsConstraintInertiaTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x736eca8*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x736ecc8*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x736ece0*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x736ecf8*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintStrengthTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x736ed10*/ PhysicsConstraintStrengthTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x736ed18*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x736ed38*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x736ed50*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x736ed68*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintDampingTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x736ed80*/ PhysicsConstraintDampingTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x736ed88*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x736eda8*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x736edc0*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x736edd8*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintMassTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x736edf0*/ PhysicsConstraintMassTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x736edf8*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x736ee20*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x736ee40*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x736ee60*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintWindTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x736ee78*/ PhysicsConstraintWindTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x736ee80*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x736eea0*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x736eeb8*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x736eed0*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintGravityTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x736eee8*/ PhysicsConstraintGravityTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x736eef0*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x736ef10*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x736ef28*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x736ef40*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintMixTimeline : Spine.PhysicsConstraintTimeline
    {
        /*0x736ef58*/ PhysicsConstraintMixTimeline(int frameCount, int bezierCount, int physicsConstraintIndex);
        /*0x736ef60*/ float Setup(Spine.PhysicsConstraint constraint);
        /*0x736ef80*/ float Get(Spine.PhysicsConstraint constraint);
        /*0x736ef98*/ void Set(Spine.PhysicsConstraint constraint, float value);
        /*0x736efb0*/ bool Global(Spine.PhysicsConstraintData constraint);
    }

    class PhysicsConstraintResetTimeline : Spine.Timeline
    {
        static /*0x0*/ string[] propertyIds;
        /*0x20*/ int constraintIndex;

        static /*0x736f244*/ PhysicsConstraintResetTimeline();
        /*0x736efc8*/ PhysicsConstraintResetTimeline(int frameCount, int physicsConstraintIndex);
        /*0x736f044*/ int get_FrameCount();
        /*0x736f060*/ void SetFrame(int frame, float time);
        /*0x736f090*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
    }

    class SequenceTimeline : Spine.Timeline
    {
        /*0x20*/ int slotIndex;
        /*0x28*/ Spine.IHasTextureRegion attachment;

        /*0x736f2fc*/ SequenceTimeline(int frameCount, int slotIndex, Spine.Attachment attachment);
        /*0x736f5b0*/ int get_FrameEntries();
        /*0x736f5b8*/ void SetFrame(int frame, float time, Spine.SequenceMode mode, int index, float delay);
        /*0x736f61c*/ void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixBlend blend, Spine.MixDirection direction);
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

        static /*0x7373204*/ AnimationState();
        static /*0x7371578*/ void ApplyRotateTimeline(Spine.RotateTimeline timeline, Spine.Skeleton skeleton, float time, float alpha, Spine.MixBlend blend, float[] timelinesRotation, int i, bool firstFrame);
        /*0x736fa7c*/ AnimationState(Spine.AnimationStateData data);
        /*0x736f9d4*/ void OnStart(Spine.TrackEntry entry);
        /*0x736f9f0*/ void OnInterrupt(Spine.TrackEntry entry);
        /*0x736fa0c*/ void OnEnd(Spine.TrackEntry entry);
        /*0x736fa28*/ void OnDispose(Spine.TrackEntry entry);
        /*0x736fa44*/ void OnComplete(Spine.TrackEntry entry);
        /*0x736fa60*/ void OnEvent(Spine.TrackEntry entry, Spine.Event e);
        /*0x736fdd4*/ void Update(float delta);
        /*0x7370300*/ bool UpdateMixingFrom(Spine.TrackEntry to, float delta);
        /*0x73706b4*/ bool Apply(Spine.Skeleton skeleton);
        /*0x7371b00*/ bool ApplyEventTimelinesOnly(Spine.Skeleton skeleton, bool issueEvents);
        /*0x7370d78*/ float ApplyMixingFrom(Spine.TrackEntry to, Spine.Skeleton skeleton, Spine.MixBlend blend);
        /*0x7371d80*/ float ApplyMixingFromEventTimelinesOnly(Spine.TrackEntry to, Spine.Skeleton skeleton, bool issueEvents);
        /*0x7371458*/ void ApplyAttachmentTimeline(Spine.AttachmentTimeline timeline, Spine.Skeleton skeleton, float time, Spine.MixBlend blend, bool attachments);
        /*0x7371f6c*/ void SetAttachment(Spine.Skeleton skeleton, Spine.Slot slot, string attachmentName, bool attachments);
        /*0x7371954*/ void QueueEvents(Spine.TrackEntry entry, float animationTime);
        /*0x737222c*/ void ClearTracks();
        /*0x73722dc*/ void ClearTrack(int trackIndex);
        /*0x736ffd4*/ void SetCurrent(int index, Spine.TrackEntry current, bool interrupt);
        /*0x73726d0*/ Spine.TrackEntry SetAnimation(int trackIndex, string animationName, bool loop);
        /*0x7372798*/ Spine.TrackEntry SetAnimation(int trackIndex, Spine.Animation animation, bool loop);
        /*0x73723f0*/ Spine.TrackEntry ExpandToIndex(int index);
        /*0x737292c*/ Spine.TrackEntry NewTrackEntry(int trackIndex, Spine.Animation animation, bool loop, Spine.TrackEntry last);
        /*0x73702b0*/ void ClearNext(Spine.TrackEntry entry);
        /*0x7370c98*/ void AnimationsChanged();
        /*0x7372ca0*/ void ComputeHold(Spine.TrackEntry entry);
        /*0x7373050*/ Spine.TrackEntry GetCurrent(int trackIndex);
        /*0x737309c*/ void set_TimeScale(float value);
        /*0x73730a4*/ Spine.ExposedList<Spine.TrackEntry> get_Tracks();
        /*0x73730ac*/ string ToString();
        /*0x73732e8*/ void <.ctor>b__45_0();

        class TrackEntryDelegate : System.MulticastDelegate
        {
            /*0x73732f4*/ TrackEntryDelegate(object object, nint method);
            /*0x73733fc*/ void Invoke(Spine.TrackEntry trackEntry);
        }

        class TrackEntryEventDelegate : System.MulticastDelegate
        {
            /*0x7373410*/ TrackEntryEventDelegate(object object, nint method);
            /*0x737351c*/ void Invoke(Spine.TrackEntry trackEntry, Spine.Event e);
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

        /*0x737391c*/ TrackEntry();
        /*0x7373530*/ void add_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x73735cc*/ void remove_Complete(Spine.AnimationState.TrackEntryDelegate value);
        /*0x7373668*/ void OnStart();
        /*0x7373688*/ void OnInterrupt();
        /*0x73736a8*/ void OnEnd();
        /*0x73736c8*/ void OnDispose();
        /*0x73736e8*/ void OnComplete();
        /*0x7373708*/ void OnEvent(Spine.Event e);
        /*0x7373730*/ void Reset();
        /*0x7373888*/ Spine.Animation get_Animation();
        /*0x7373890*/ bool get_Loop();
        /*0x7373898*/ float get_AnimationLast();
        /*0x7371394*/ float get_AnimationTime();
        /*0x73738a0*/ float get_Alpha();
        /*0x73738a8*/ float get_InterruptAlpha();
        /*0x73738b0*/ float get_MixTime();
        /*0x73738b8*/ float get_MixDuration();
        /*0x73738c0*/ Spine.TrackEntry get_MixingFrom();
        /*0x73738c8*/ string ToString();
    }

    class EventQueue
    {
        /*0x10*/ System.Collections.Generic.List<Spine.EventQueue.EventQueueEntry> eventQueueEntries;
        /*0x18*/ bool drainDisabled;
        /*0x20*/ Spine.AnimationState state;
        /*0x28*/ Spine.Pool<Spine.TrackEntry> trackEntryPool;
        /*0x30*/ System.Action AnimationsChanged;

        /*0x736fd0c*/ EventQueue(Spine.AnimationState state, System.Action HandleAnimationsChanged, Spine.Pool<Spine.TrackEntry> trackEntryPool);
        /*0x7373a5c*/ void add_AnimationsChanged(System.Action value);
        /*0x7373af8*/ void remove_AnimationsChanged(System.Action value);
        /*0x737259c*/ void Start(Spine.TrackEntry entry);
        /*0x7372480*/ void Interrupt(Spine.TrackEntry entry);
        /*0x7370174*/ void End(Spine.TrackEntry entry);
        /*0x7372b84*/ void Dispose(Spine.TrackEntry entry);
        /*0x7372110*/ void Complete(Spine.TrackEntry entry);
        /*0x7371fe8*/ void Event(Spine.TrackEntry entry, Spine.Event e);
        /*0x73703f8*/ void Drain();

        struct EventQueueEntry
        {
            /*0x10*/ Spine.EventQueue.EventType type;
            /*0x18*/ Spine.TrackEntry entry;
            /*0x20*/ Spine.Event e;

            /*0x7373b94*/ EventQueueEntry(Spine.EventQueue.EventType eventType, Spine.TrackEntry trackEntry, Spine.Event e);
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

        /*0x380d0e4*/ Pool(int initialCapacity, int max);
        /*0x380b6a0*/ int get_Peak();
        /*0x380cffc*/ void set_Peak(int value);
        /*0x3907c14*/ T Obtain();
        /*0x3907c14*/ void Free(T obj);
        /*0x3907c14*/ void Reset(T obj);

        interface IPoolable<T>
        {
            /*0x380cb08*/ void Reset();
        }
    }

    class HashSetExtensions
    {
        static /*0x381cca4*/ bool AddAll<T>(System.Collections.Generic.HashSet<T> set, T[] addSet);
    }

    class AnimationStateData
    {
        /*0x10*/ Spine.SkeletonData skeletonData;
        /*0x18*/ System.Collections.Generic.Dictionary<Spine.AnimationStateData.AnimationPair, float> animationToMixTime;
        /*0x20*/ float defaultMix;

        /*0x7373bd4*/ AnimationStateData(Spine.SkeletonData skeletonData);
        /*0x7373bcc*/ void set_DefaultMix(float value);
        /*0x7373d04*/ void SetMix(string fromName, string toName, float duration);
        /*0x7373e20*/ void SetMix(Spine.Animation from, Spine.Animation to, float duration);
        /*0x7372a3c*/ float GetMix(Spine.Animation from, Spine.Animation to);

        struct AnimationPair
        {
            /*0x10*/ Spine.Animation a1;
            /*0x18*/ Spine.Animation a2;

            /*0x7373f84*/ AnimationPair(Spine.Animation a1, Spine.Animation a2);
            /*0x7373fb4*/ string ToString();
        }

        class AnimationPairComparer : System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>
        {
            static /*0x0*/ Spine.AnimationStateData.AnimationPairComparer Instance;

            static /*0x737408c*/ AnimationPairComparer();
            /*0x7374084*/ AnimationPairComparer();
            /*0x7374018*/ bool System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.Equals(Spine.AnimationStateData.AnimationPair x, Spine.AnimationStateData.AnimationPair y);
            /*0x7374030*/ int System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.GetHashCode(Spine.AnimationStateData.AnimationPair obj);
        }
    }

    class Atlas : System.Collections.Generic.IEnumerable<Spine.AtlasRegion>, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<Spine.AtlasPage> pages;
        /*0x18*/ System.Collections.Generic.List<Spine.AtlasRegion> regions;
        /*0x20*/ Spine.TextureLoader textureLoader;

        static /*0x737536c*/ int ReadEntry(string[] entry, string line);
        /*0x7374214*/ Atlas(System.Collections.Generic.List<Spine.AtlasPage> pages, System.Collections.Generic.List<Spine.AtlasRegion> regions);
        /*0x73743cc*/ Atlas(System.IO.TextReader reader, string imagesDir, Spine.TextureLoader textureLoader);
        /*0x73740f4*/ System.Collections.Generic.IEnumerator<Spine.AtlasRegion> GetEnumerator();
        /*0x7374184*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x73754fc*/ void FlipV();
        /*0x73755b4*/ Spine.AtlasRegion FindRegion(string name);

        class <>c__DisplayClass10_0
        {
            /*0x10*/ Spine.AtlasPage page;
            /*0x18*/ string[] entry;
            /*0x20*/ Spine.AtlasRegion region;

            /*0x7375688*/ <>c__DisplayClass10_0();
            /*0x7375690*/ void <.ctor>b__0();
            /*0x7375760*/ void <.ctor>b__1();
            /*0x7375860*/ void <.ctor>b__2();
            /*0x73759c0*/ void <.ctor>b__3();
            /*0x7375a58*/ void <.ctor>b__4();
            /*0x7375ad4*/ void <.ctor>b__5();
            /*0x7375ba4*/ void <.ctor>b__6();
            /*0x7375c74*/ void <.ctor>b__7();
            /*0x7375dbc*/ void <.ctor>b__8();
            /*0x7375e94*/ void <.ctor>b__9();
            /*0x7375f64*/ void <.ctor>b__10();
            /*0x73760b4*/ void <.ctor>b__11();
            /*0x73761a8*/ void <.ctor>b__12();
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

        /*0x73762c0*/ AtlasPage();
        /*0x737623c*/ Spine.AtlasPage Clone();
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

        /*0x737637c*/ AtlasRegion();
        /*0x73762d8*/ int get_packedWidth();
        /*0x73762e0*/ void set_packedWidth(int value);
        /*0x73762e8*/ int get_packedHeight();
        /*0x73762f0*/ void set_packedHeight(int value);
        /*0x73762f8*/ Spine.AtlasRegion Clone();
    }

    interface TextureLoader
    {
        /*0x380d93c*/ void Load(Spine.AtlasPage page, string path);
    }

    class AtlasAttachmentLoader : Spine.AttachmentLoader
    {
        /*0x10*/ Spine.Atlas[] atlasArray;

        /*0x7376384*/ AtlasAttachmentLoader(Spine.Atlas[] atlasArray);
        /*0x7376414*/ void LoadSequence(string name, string basePath, Spine.Sequence sequence);
        /*0x73766d8*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x7376880*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x7376a6c*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
        /*0x7376b28*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
        /*0x7376be4*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
        /*0x7376c40*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
        /*0x7376668*/ Spine.AtlasRegion FindRegion(string name);
    }

    class Attachment
    {
        /*0x10*/ string <Name>k__BackingField;

        /*0x7376d04*/ Attachment(string name);
        /*0x7376cfc*/ string get_Name();
        /*0x7376d94*/ string ToString();
    }

    interface AttachmentLoader
    {
        /*0x380bd7c*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x380bd7c*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
        /*0x380bcbc*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
        /*0x380bcbc*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
        /*0x380bcbc*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
        /*0x380bcbc*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
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
        /*0x7376ac4*/ BoundingBoxAttachment(string name);
    }

    class ClippingAttachment : Spine.VertexAttachment
    {
        /*0x40*/ Spine.SlotData endSlot;

        /*0x7376c98*/ ClippingAttachment(string name);
        /*0x7376edc*/ Spine.SlotData get_EndSlot();
        /*0x7376ee4*/ void set_EndSlot(Spine.SlotData value);
    }

    interface IHasTextureRegion
    {
        /*0x380b9e8*/ Spine.TextureRegion get_Region();
        /*0x380d83c*/ void set_Region(Spine.TextureRegion value);
        /*0x380cb08*/ void UpdateRegion();
        /*0x380b9e8*/ Spine.Sequence get_Sequence();
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

        /*0x7376988*/ MeshAttachment(string name);
        /*0x7376eec*/ Spine.TextureRegion get_Region();
        /*0x73769f4*/ void set_Region(Spine.TextureRegion value);
        /*0x7376ef4*/ int get_HullLength();
        /*0x7376efc*/ void set_HullLength(int value);
        /*0x7376f04*/ float[] get_UVs();
        /*0x7376f0c*/ int[] get_Triangles();
        /*0x7376f14*/ float get_R();
        /*0x7376f1c*/ float get_G();
        /*0x7376f24*/ float get_B();
        /*0x7376f2c*/ float get_A();
        /*0x7376f34*/ void set_Path(string value);
        /*0x7376f3c*/ Spine.Sequence get_Sequence();
        /*0x7376f44*/ void set_Sequence(Spine.Sequence value);
        /*0x7376f4c*/ void set_ParentMesh(Spine.MeshAttachment value);
        /*0x7376fdc*/ int[] get_Edges();
        /*0x7376fe4*/ void set_Edges(int[] value);
        /*0x7376fec*/ float get_Width();
        /*0x7376ff4*/ void set_Width(float value);
        /*0x7376ffc*/ float get_Height();
        /*0x7377004*/ void set_Height(float value);
        /*0x737700c*/ void UpdateRegion();
        /*0x7377420*/ void ComputeWorldVertices(Spine.Slot slot, int start, int count, float[] worldVertices, int offset, int stride);
    }

    class PathAttachment : Spine.VertexAttachment
    {
        /*0x40*/ float[] lengths;
        /*0x48*/ bool closed;
        /*0x49*/ bool constantSpeed;

        /*0x7376b80*/ PathAttachment(string name);
        /*0x7377a8c*/ float[] get_Lengths();
        /*0x7377a94*/ bool get_Closed();
        /*0x7377a9c*/ bool get_ConstantSpeed();
    }

    class PointAttachment : Spine.Attachment
    {
        /*0x18*/ float x;
        /*0x1c*/ float y;
        /*0x20*/ float rotation;

        /*0x7376c3c*/ PointAttachment(string name);
        /*0x7377aa4*/ void ComputeWorldPosition(Spine.Bone bone, ref float ox, ref float oy);
        /*0x7377b30*/ float ComputeWorldRotation(Spine.Bone bone);
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

        /*0x73767e4*/ RegionAttachment(string name);
        /*0x7377ca0*/ float get_X();
        /*0x7377ca8*/ float get_Y();
        /*0x7377cb0*/ float get_Rotation();
        /*0x7377cb8*/ float get_ScaleX();
        /*0x7377cc0*/ float get_ScaleY();
        /*0x7377cc8*/ float get_Width();
        /*0x7377cd0*/ float get_Height();
        /*0x7377cd8*/ float get_R();
        /*0x7377ce0*/ float get_G();
        /*0x7377ce8*/ float get_B();
        /*0x7377cf0*/ float get_A();
        /*0x7377cf8*/ void set_Path(string value);
        /*0x7377d00*/ Spine.TextureRegion get_Region();
        /*0x7377d08*/ void set_Region(Spine.TextureRegion value);
        /*0x7377d10*/ float[] get_UVs();
        /*0x7377d18*/ Spine.Sequence get_Sequence();
        /*0x7377d20*/ void UpdateRegion();
        /*0x73780e4*/ void ComputeWorldVertices(Spine.Slot slot, float[] worldVertices, int offset, int stride);
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

        static /*0x7378428*/ Sequence();
        /*0x73782c0*/ Sequence(int count);
        /*0x7378298*/ void set_Start(int value);
        /*0x73782a0*/ void set_Digits(int value);
        /*0x73782a8*/ void set_SetupIndex(int value);
        /*0x73782b0*/ Spine.TextureRegion[] get_Regions();
        /*0x73782b8*/ int get_Id();
        /*0x7377490*/ void Apply(Spine.Slot slot, Spine.IHasTextureRegion attachment);
        /*0x737655c*/ string GetPath(string basePath, int index);
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

        static /*0x7378500*/ VertexAttachment();
        /*0x7376d9c*/ VertexAttachment(string name);
        /*0x73784a8*/ int get_Id();
        /*0x73784b0*/ int[] get_Bones();
        /*0x73784b8*/ float[] get_Vertices();
        /*0x73784c0*/ int get_WorldVerticesLength();
        /*0x73784c8*/ void set_WorldVerticesLength(int value);
        /*0x73784d0*/ Spine.VertexAttachment get_TimelineAttachment();
        /*0x73784d8*/ void set_TimelineAttachment(Spine.VertexAttachment value);
        /*0x73784e0*/ void ComputeWorldVertices(Spine.Slot slot, float[] worldVertices);
        /*0x7377650*/ void ComputeWorldVertices(Spine.Slot slot, int start, int count, float[] worldVertices, int offset, int stride);
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

        /*0x73787b0*/ Bone(Spine.BoneData data, Spine.Skeleton skeleton, Spine.Bone parent);
        /*0x7378580*/ Spine.BoneData get_Data();
        /*0x7378588*/ Spine.Skeleton get_Skeleton();
        /*0x7378590*/ Spine.Bone get_Parent();
        /*0x7378598*/ Spine.ExposedList<Spine.Bone> get_Children();
        /*0x73785a0*/ bool get_Active();
        /*0x73785a8*/ float get_X();
        /*0x73785b0*/ void set_X(float value);
        /*0x73785b8*/ float get_Y();
        /*0x73785c0*/ void set_Y(float value);
        /*0x73785c8*/ float get_Rotation();
        /*0x73785d0*/ void set_Rotation(float value);
        /*0x73785d8*/ float get_ScaleX();
        /*0x73785e0*/ void set_ScaleX(float value);
        /*0x73785e8*/ float get_ScaleY();
        /*0x73785f0*/ void set_ScaleY(float value);
        /*0x73785f8*/ float get_AppliedRotation();
        /*0x7378600*/ void set_AppliedRotation(float value);
        /*0x7378608*/ float get_AX();
        /*0x7378610*/ void set_AX(float value);
        /*0x7378618*/ float get_AY();
        /*0x7378620*/ void set_AY(float value);
        /*0x7378628*/ float get_AScaleX();
        /*0x7378630*/ float get_AScaleY();
        /*0x7378638*/ float get_A();
        /*0x7378640*/ float get_B();
        /*0x7378648*/ float get_C();
        /*0x7378650*/ float get_D();
        /*0x7378658*/ float get_WorldX();
        /*0x7378660*/ float get_WorldY();
        /*0x7378668*/ float get_WorldRotationX();
        /*0x73786d0*/ float get_WorldScaleX();
        /*0x7378740*/ float get_WorldScaleY();
        /*0x7378950*/ void Update(Spine.Skeleton.Physics physics);
        /*0x7378964*/ void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY);
        /*0x7378918*/ void SetToSetupPose();
        /*0x73792f0*/ void UpdateAppliedTransform();
        /*0x737989c*/ void WorldToLocal(float worldX, float worldY, ref float localX, ref float localY);
        /*0x7377af4*/ void LocalToWorld(float localX, float localY, ref float worldX, ref float worldY);
        /*0x73798e8*/ string ToString();
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

        /*0x737994c*/ BoneData(int index, string name, Spine.BoneData parent);
        /*0x7379904*/ int get_Index();
        /*0x737990c*/ string get_Name();
        /*0x7379914*/ float get_Length();
        /*0x737991c*/ void set_Length(float value);
        /*0x7379924*/ float get_X();
        /*0x737992c*/ float get_Y();
        /*0x7379934*/ float get_Rotation();
        /*0x737993c*/ float get_ScaleY();
        /*0x7379944*/ Spine.Inherit get_Inherit();
        /*0x7379a54*/ string ToString();
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

        static /*0x7379a5c*/ InheritEnum();
    }

    class ConstraintData
    {
        /*0x10*/ string name;
        /*0x18*/ int order;
        /*0x1c*/ bool skinRequired;

        /*0x7379afc*/ ConstraintData(string name);
        /*0x7379b8c*/ string ToString();
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

        /*0x7379b9c*/ Event(float time, Spine.EventData data);
        /*0x7379b94*/ Spine.EventData get_Data();
        /*0x7379c3c*/ string ToString();
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

        /*0x7379cc0*/ EventData(string name);
        /*0x7379c58*/ string get_Name();
        /*0x7379c60*/ int get_Int();
        /*0x7379c68*/ void set_Int(int value);
        /*0x7379c70*/ float get_Float();
        /*0x7379c78*/ void set_Float(float value);
        /*0x7379c80*/ string get_String();
        /*0x7379c88*/ void set_String(string value);
        /*0x7379c90*/ string get_AudioPath();
        /*0x7379c98*/ void set_AudioPath(string value);
        /*0x7379ca0*/ float get_Volume();
        /*0x7379ca8*/ void set_Volume(float value);
        /*0x7379cb0*/ float get_Balance();
        /*0x7379cb8*/ void set_Balance(float value);
        /*0x7379d50*/ string ToString();
    }

    class ExposedList<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        static int DefaultCapacity = 4;
        static /*0x0*/ T[] EmptyArray;
        /*0x0*/ T[] Items;
        /*0x0*/ int Count;
        /*0x0*/ int version;

        static /*0x38358cc*/ ExposedList();
        /*0x380cb08*/ ExposedList();
        /*0x380cffc*/ ExposedList(int capacity);
        /*0x3907c14*/ void Add(T item);
        /*0x380cffc*/ void GrowIfNeeded(int addedCount);
        /*0x380ba90*/ Spine.ExposedList<T> Resize(int newSize);
        /*0x380cffc*/ void EnsureCapacity(int min);
        /*0x380cdf0*/ void Clear(bool clearArray);
        /*0x3907c14*/ bool Contains(T item);
        /*0x380d83c*/ void CopyTo(T[] array);
        /*0x3907c14*/ Spine.ExposedList.Enumerator<T> GetEnumerator();
        /*0x3907c14*/ int IndexOf(T item);
        /*0x380d0e4*/ void Shift(int start, int delta);
        /*0x380cffc*/ void RemoveAt(int index);
        /*0x380b9e8*/ T[] ToArray();
        /*0x380cb08*/ void TrimExcess();
        /*0x380b6a0*/ int get_Capacity();
        /*0x380cffc*/ void set_Capacity(int value);
        /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

        struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ Spine.ExposedList<T> l;
            /*0x0*/ int next;
            /*0x0*/ int ver;
            /*0x0*/ T current;

            /*0x380d83c*/ Enumerator(Spine.ExposedList<T> l);
            /*0x380cb08*/ void Dispose();
            /*0x380cb08*/ void VerifyState();
            /*0x380b128*/ bool MoveNext();
            /*0x3907c14*/ T get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x737a1ac*/ void Apply(Spine.Bone bone, float targetX, float targetY, bool compress, bool stretch, bool uniform, float alpha);
        static /*0x737a668*/ void Apply(Spine.Bone parent, Spine.Bone child, float targetX, float targetY, int bendDir, bool stretch, bool uniform, float softness, float alpha);
        /*0x7379d58*/ IkConstraint(Spine.IkConstraintData data, Spine.Skeleton skeleton);
        /*0x737a0a8*/ void SetToSetupPose();
        /*0x737a0e0*/ void Update(Spine.Skeleton.Physics physics);
        /*0x737b088*/ Spine.Bone get_Target();
        /*0x737b090*/ string ToString();
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

        /*0x737b0ac*/ IkConstraintData(string name);
    }

    interface IUpdatable
    {
        /*0x380cffc*/ void Update(Spine.Skeleton.Physics physics);
    }

    class Json
    {
        static /*0x737b138*/ object Deserialize(System.IO.TextReader text);
    }

    class MathUtils
    {
        static /*0x0*/ System.Random random;

        static /*0x737b2a4*/ MathUtils();
        static /*0x737b1bc*/ float Sin(float radians);
        static /*0x737b220*/ float Cos(float radians);
        static /*0x7377c28*/ float Atan2Deg(float y, float x);
        static /*0x7379284*/ float Atan2(float y, float x);
        static /*0x737b284*/ float Clamp(float value, float min, float max);
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

        static /*0x737b750*/ void ArraysFill(float[] a, int fromIndex, int toIndex, float val);
        static /*0x737cdd8*/ void AddBeforePosition(float p, float[] temp, int i, float[] output, int o);
        static /*0x737cf28*/ void AddAfterPosition(float p, float[] temp, int i, float[] output, int o);
        static /*0x737d078*/ void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, float[] output, int o, bool tangents);
        /*0x737b320*/ PathConstraint(Spine.PathConstraintData data, Spine.Skeleton skeleton);
        /*0x737b79c*/ void SetToSetupPose();
        /*0x737b7c4*/ void Update(Spine.Skeleton.Physics physics);
        /*0x737c0a8*/ float[] ComputeWorldPositions(Spine.PathAttachment path, int spacesCount, bool tangents);
        /*0x737d2c0*/ string ToString();
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

        /*0x737d2dc*/ PathConstraintData(string name);
        /*0x737d368*/ Spine.ExposedList<Spine.BoneData> get_Bones();
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

        /*0x737d370*/ PhysicsConstraint(Spine.PhysicsConstraintData data, Spine.Skeleton skeleton);
        /*0x737d4b0*/ void Reset();
        /*0x737d4e8*/ void SetToSetupPose();
        /*0x737d518*/ void Translate(float x, float y);
        /*0x737d538*/ void Rotate(float x, float y, float degrees);
        /*0x737d60c*/ void Update(Spine.Skeleton.Physics physics);
        /*0x737dfdc*/ string ToString();
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

        /*0x737dff8*/ PhysicsConstraintData(string name);
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

        static /*0x7380a70*/ Skeleton();
        static /*0x737fa68*/ void SortReset(Spine.ExposedList<Spine.Bone> bones);
        /*0x737e0cc*/ Skeleton(Spine.SkeletonData data);
        /*0x737dffc*/ Spine.SkeletonData get_Data();
        /*0x737e004*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x737e00c*/ Spine.ExposedList<Spine.Slot> get_Slots();
        /*0x737e014*/ Spine.ExposedList<Spine.Slot> get_DrawOrder();
        /*0x737e01c*/ Spine.ExposedList<Spine.IkConstraint> get_IkConstraints();
        /*0x737e024*/ Spine.ExposedList<Spine.TransformConstraint> get_TransformConstraints();
        /*0x737e02c*/ Spine.Skin get_Skin();
        /*0x737e034*/ float get_R();
        /*0x737e03c*/ void set_R(float value);
        /*0x737e044*/ float get_G();
        /*0x737e04c*/ void set_G(float value);
        /*0x737e054*/ float get_B();
        /*0x737e05c*/ void set_B(float value);
        /*0x737e064*/ float get_A();
        /*0x737e06c*/ void set_A(float value);
        /*0x737e074*/ float get_ScaleX();
        /*0x737e07c*/ void set_ScaleX(float value);
        /*0x7379228*/ float get_ScaleY();
        /*0x737e084*/ void set_ScaleY(float value);
        /*0x737e08c*/ Spine.Bone get_RootBone();
        /*0x737ee7c*/ void UpdateCache();
        /*0x737f1d4*/ void SortIkConstraint(Spine.IkConstraint constraint);
        /*0x737f3c8*/ void SortTransformConstraint(Spine.TransformConstraint constraint);
        /*0x737f618*/ void SortPathConstraint(Spine.PathConstraint constraint);
        /*0x737fb30*/ void SortPathConstraintAttachment(Spine.Skin skin, int slotIndex, Spine.Bone slotBone);
        /*0x737fe40*/ void SortPathConstraintAttachment(Spine.Attachment attachment, Spine.Bone slotBone);
        /*0x737f8a4*/ void SortPhysicsConstraint(Spine.PhysicsConstraint constraint);
        /*0x737f9e0*/ void SortBone(Spine.Bone bone);
        /*0x737ffbc*/ void UpdateWorldTransform(Spine.Skeleton.Physics physics);
        /*0x7380114*/ void PhysicsTranslate(float x, float y);
        /*0x7380188*/ void PhysicsRotate(float x, float y, float degrees);
        /*0x7380214*/ void Update(float delta);
        /*0x7380224*/ void SetToSetupPose();
        /*0x738023c*/ void SetBonesToSetupPose();
        /*0x73803d0*/ void SetSlotsToSetupPose();
        /*0x738045c*/ Spine.Bone FindBone(string boneName);
        /*0x738054c*/ Spine.Slot FindSlot(string slotName);
        /*0x738063c*/ void SetSkin(string skinName);
        /*0x73806e0*/ void SetSkin(Spine.Skin newSkin);
        /*0x73807e0*/ Spine.Attachment GetAttachment(int slotIndex, string attachmentName);
        /*0x73808a8*/ void SetAttachment(string slotName, string attachmentName);
        /*0x7380a54*/ string ToString();

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

        /*0x7380b10*/ SkeletonBinary(Spine.AttachmentLoader attachmentLoader);
        /*0x7380ba0*/ Spine.SkeletonData ReadSkeletonData(System.IO.Stream file);
        /*0x73825c0*/ Spine.Skin ReadSkin(Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData, bool defaultSkin, bool nonessential);
        /*0x73856a0*/ Spine.Attachment ReadAttachment(Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData, Spine.Skin skin, int slotIndex, string attachmentName, bool nonessential);
        /*0x73862a4*/ Spine.Sequence ReadSequence(Spine.SkeletonBinary.SkeletonInput input);
        /*0x738635c*/ Spine.SkeletonBinary.Vertices ReadVertices(Spine.SkeletonBinary.SkeletonInput input, bool weighted);
        /*0x7386608*/ float[] ReadFloatArray(Spine.SkeletonBinary.SkeletonInput input, int n, float scale);
        /*0x7386718*/ int[] ReadShortArray(Spine.SkeletonBinary.SkeletonInput input, int n);
        /*0x7382a94*/ Spine.Animation ReadAnimation(string name, Spine.SkeletonBinary.SkeletonInput input, Spine.SkeletonData skeletonData);
        /*0x73868a8*/ void ReadTimeline(Spine.SkeletonBinary.SkeletonInput input, Spine.ExposedList<Spine.Timeline> timelines, Spine.CurveTimeline1 timeline, float scale);
        /*0x7386a54*/ void ReadTimeline(Spine.SkeletonBinary.SkeletonInput input, Spine.ExposedList<Spine.Timeline> timelines, Spine.CurveTimeline2 timeline, float scale);
        /*0x73867c8*/ void SetBezier(Spine.SkeletonBinary.SkeletonInput input, Spine.CurveTimeline timeline, int bezier, int frame, int value, float time1, float time2, float value1, float value2, float scale);

        class Vertices
        {
            /*0x10*/ int length;
            /*0x18*/ int[] bones;
            /*0x20*/ float[] vertices;

            /*0x7386c64*/ Vertices();
        }

        class SkeletonInput
        {
            /*0x10*/ byte[] chars;
            /*0x18*/ byte[] bytesBigEndian;
            /*0x20*/ string[] strings;
            /*0x28*/ System.IO.Stream input;

            /*0x7386c6c*/ SkeletonInput(System.IO.Stream input);
            /*0x7386d08*/ int Read();
            /*0x7386d2c*/ byte ReadUByte();
            /*0x7386d54*/ bool ReadBoolean();
            /*0x7386d84*/ float ReadFloat();
            /*0x7386e84*/ int ReadInt();
            /*0x7386f08*/ long ReadLong();
            /*0x7386fcc*/ int ReadInt(bool optimizePositive);
            /*0x738709c*/ string ReadString();
            /*0x7387228*/ string ReadStringRef();
            /*0x7387180*/ void ReadFully(byte[] buffer, int offset, int length);
        }

        class LinkedMesh
        {
            /*0x10*/ string parent;
            /*0x18*/ int skinIndex;
            /*0x1c*/ int slotIndex;
            /*0x20*/ Spine.MeshAttachment mesh;
            /*0x28*/ bool inheritTimelines;

            /*0x7387274*/ LinkedMesh(Spine.MeshAttachment mesh, int skinIndex, int slotIndex, string parent, bool inheritTimelines);
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

        static /*0x73875bc*/ void MakeClockwise(Spine.ExposedList<float> polygon);
        /*0x7389550*/ SkeletonClipping();
        /*0x73872e0*/ Spine.ExposedList<float> get_ClippedVertices();
        /*0x73872e8*/ Spine.ExposedList<int> get_ClippedTriangles();
        /*0x73872f0*/ Spine.ExposedList<float> get_ClippedUVs();
        /*0x73872f8*/ bool get_IsClipping();
        /*0x7387308*/ int ClipStart(Spine.Slot slot, Spine.ClippingAttachment clip);
        /*0x73887c4*/ void ClipEnd(Spine.Slot slot);
        /*0x73887f8*/ void ClipEnd();
        /*0x73888c0*/ void ClipTriangles(float[] vertices, int[] triangles, int trianglesLength, float[] uvs);
        /*0x7389038*/ bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, Spine.ExposedList<float> clippingArea, Spine.ExposedList<float> output);
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

        /*0x738a3a4*/ SkeletonData();
        /*0x738996c*/ Spine.ExposedList<Spine.BoneData> get_Bones();
        /*0x7389974*/ Spine.ExposedList<Spine.SlotData> get_Slots();
        /*0x738997c*/ Spine.ExposedList<Spine.Skin> get_Skins();
        /*0x7389984*/ Spine.Skin get_DefaultSkin();
        /*0x738998c*/ Spine.ExposedList<Spine.Animation> get_Animations();
        /*0x7389994*/ Spine.ExposedList<Spine.IkConstraintData> get_IkConstraints();
        /*0x738999c*/ Spine.ExposedList<Spine.TransformConstraintData> get_TransformConstraints();
        /*0x73899a4*/ float get_Width();
        /*0x73899ac*/ float get_Height();
        /*0x73899b4*/ Spine.BoneData FindBone(string boneName);
        /*0x7389a9c*/ Spine.SlotData FindSlot(string slotName);
        /*0x7389b84*/ Spine.Skin FindSkin(string skinName);
        /*0x7389d40*/ Spine.EventData FindEvent(string eventDataName);
        /*0x7389efc*/ Spine.Animation FindAnimation(string animationName);
        /*0x7389fe4*/ Spine.IkConstraintData FindIkConstraint(string constraintName);
        /*0x738a0cc*/ Spine.TransformConstraintData FindTransformConstraint(string constraintName);
        /*0x738a1b4*/ Spine.PathConstraintData FindPathConstraint(string constraintName);
        /*0x738a2a0*/ Spine.PhysicsConstraintData FindPhysicsConstraint(string constraintName);
        /*0x738a38c*/ string ToString();
    }

    class SkeletonJson : Spine.SkeletonLoader
    {
        /*0x20*/ System.Collections.Generic.List<Spine.SkeletonJson.LinkedMesh> linkedMeshes;

        static /*0x739780c*/ Spine.Sequence ReadSequence(object sequenceJson);
        static /*0x7398458*/ Spine.Timeline ReadTimeline(ref System.Collections.Generic.List.Enumerator<object> keyMapEnumerator, Spine.CurveTimeline1 timeline, float defaultValue, float scale);
        static /*0x7398718*/ Spine.Timeline ReadTimeline(ref System.Collections.Generic.List.Enumerator<object> keyMapEnumerator, Spine.CurveTimeline2 timeline, string name1, string name2, float defaultValue, float scale);
        static /*0x73981fc*/ int ReadCurve(object curve, Spine.CurveTimeline timeline, int bezier, int frame, int value, float time1, float time2, float value1, float value2, float scale);
        static /*0x7398a40*/ void SetBezier(Spine.CurveTimeline timeline, int frame, int value, int bezier, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2);
        static /*0x7397d30*/ float[] GetFloatArray(System.Collections.Generic.Dictionary<string, object> map, string name, float scale);
        static /*0x7397f40*/ int[] GetIntArray(System.Collections.Generic.Dictionary<string, object> map, string name);
        static /*0x738f498*/ float GetFloat(System.Collections.Generic.Dictionary<string, object> map, string name, float defaultValue);
        static /*0x738f968*/ int GetInt(System.Collections.Generic.Dictionary<string, object> map, string name, int defaultValue);
        static /*0x73980dc*/ int GetInt(System.Collections.Generic.Dictionary<string, object> map, string name);
        static /*0x738f618*/ bool GetBoolean(System.Collections.Generic.Dictionary<string, object> map, string name, bool defaultValue);
        static /*0x738f55c*/ string GetString(System.Collections.Generic.Dictionary<string, object> map, string name, string defaultValue);
        static /*0x738f820*/ float ToColor(string hexString, int colorIndex, int expectedLength);
        /*0x738a6ac*/ SkeletonJson(Spine.AttachmentLoader attachmentLoader);
        /*0x738a7d0*/ Spine.SkeletonData ReadSkeletonData(System.IO.TextReader reader);
        /*0x738fd88*/ Spine.Attachment ReadAttachment(System.Collections.Generic.Dictionary<string, object> map, Spine.Skin skin, int slotIndex, string name, Spine.SkeletonData skeletonData);
        /*0x7397964*/ void ReadVertices(System.Collections.Generic.Dictionary<string, object> map, Spine.VertexAttachment attachment, int verticesLength);
        /*0x738fcac*/ int FindSlotIndex(Spine.SkeletonData skeletonData, string slotName);
        /*0x7390c84*/ void ReadAnimation(System.Collections.Generic.Dictionary<string, object> map, string name, Spine.SkeletonData skeletonData);

        class LinkedMesh
        {
            /*0x10*/ string parent;
            /*0x18*/ string skin;
            /*0x20*/ int slotIndex;
            /*0x28*/ Spine.MeshAttachment mesh;
            /*0x30*/ bool inheritTimelines;

            /*0x7397cb4*/ LinkedMesh(Spine.MeshAttachment mesh, string skin, int slotIndex, string parent, bool inheritTimelines);
        }
    }

    class SkeletonLoader
    {
        /*0x10*/ Spine.AttachmentLoader attachmentLoader;
        /*0x18*/ float scale;

        /*0x738a738*/ SkeletonLoader(Spine.AttachmentLoader attachmentLoader);
        /*0x7398a64*/ float get_Scale();
        /*0x7398a6c*/ void set_Scale(float value);
    }

    class Skin
    {
        /*0x10*/ string name;
        /*0x18*/ System.Collections.Generic.Dictionary<Spine.Skin.SkinKey, Spine.Skin.SkinEntry> attachments;
        /*0x20*/ Spine.ExposedList<Spine.BoneData> bones;
        /*0x28*/ Spine.ExposedList<Spine.ConstraintData> constraints;

        /*0x738fad4*/ Skin(string name);
        /*0x7398aec*/ string get_Name();
        /*0x7398af4*/ System.Collections.Generic.ICollection<Spine.Skin.SkinEntry> get_Attachments();
        /*0x7390a8c*/ void SetAttachment(int slotIndex, string name, Spine.Attachment attachment);
        /*0x7390bd0*/ Spine.Attachment GetAttachment(int slotIndex, string name);
        /*0x7398c60*/ void GetAttachments(int slotIndex, System.Collections.Generic.List<Spine.Skin.SkinEntry> attachments);
        /*0x7398f74*/ string ToString();
        /*0x7398f7c*/ void AttachAll(Spine.Skeleton skeleton, Spine.Skin oldSkin);

        struct SkinEntry
        {
            /*0x10*/ int slotIndex;
            /*0x18*/ string name;
            /*0x20*/ Spine.Attachment attachment;

            /*0x7398c28*/ SkinEntry(int slotIndex, string name, Spine.Attachment attachment);
            /*0x7399254*/ int get_SlotIndex();
            /*0x739925c*/ string get_Name();
            /*0x7399264*/ Spine.Attachment get_Attachment();
        }

        struct SkinKey
        {
            /*0x10*/ int slotIndex;
            /*0x18*/ string name;
            /*0x20*/ int hashCode;

            /*0x7398b44*/ SkinKey(int slotIndex, string name);
        }

        class SkinKeyComparer : System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>
        {
            static /*0x0*/ Spine.Skin.SkinKeyComparer Instance;

            static /*0x73992a8*/ SkinKeyComparer();
            /*0x73992a0*/ SkinKeyComparer();
            /*0x739926c*/ bool System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.Equals(Spine.Skin.SkinKey e1, Spine.Skin.SkinKey e2);
            /*0x7399298*/ int System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.GetHashCode(Spine.Skin.SkinKey e);
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

        /*0x7399310*/ Slot(Spine.SlotData data, Spine.Bone bone);
        /*0x739950c*/ Spine.SlotData get_Data();
        /*0x7399514*/ Spine.Bone get_Bone();
        /*0x739951c*/ Spine.Skeleton get_Skeleton();
        /*0x7399538*/ float get_R();
        /*0x7399540*/ float get_G();
        /*0x7399548*/ float get_B();
        /*0x7399550*/ float get_A();
        /*0x7399558*/ void ClampColor();
        /*0x7399620*/ float get_R2();
        /*0x7399628*/ float get_G2();
        /*0x7399630*/ float get_B2();
        /*0x7399638*/ bool get_HasSecondColor();
        /*0x7399654*/ void ClampSecondColor();
        /*0x7399700*/ Spine.Attachment get_Attachment();
        /*0x7399158*/ void set_Attachment(Spine.Attachment value);
        /*0x7399708*/ int get_SequenceIndex();
        /*0x7399710*/ void set_SequenceIndex(int value);
        /*0x7399718*/ Spine.ExposedList<float> get_Deform();
        /*0x7399474*/ void SetToSetupPose();
        /*0x7399720*/ string ToString();
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

        /*0x738f6e4*/ SlotData(int index, string name, Spine.BoneData boneData);
        /*0x739973c*/ int get_Index();
        /*0x7399744*/ string get_Name();
        /*0x739974c*/ Spine.BlendMode get_BlendMode();
        /*0x7399754*/ string ToString();
    }

    class TextureRegion
    {
        /*0x10*/ int width;
        /*0x14*/ int height;
        /*0x18*/ float u;
        /*0x1c*/ float v;
        /*0x20*/ float u2;
        /*0x24*/ float v2;

        /*0x739975c*/ TextureRegion();
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

        /*0x7399764*/ TransformConstraint(Spine.TransformConstraintData data, Spine.Skeleton skeleton);
        /*0x7399a78*/ void SetToSetupPose();
        /*0x7399aa0*/ void Update(Spine.Skeleton.Physics physics);
        /*0x739a290*/ void ApplyAbsoluteWorld();
        /*0x7399e00*/ void ApplyRelativeWorld();
        /*0x7399c70*/ void ApplyAbsoluteLocal();
        /*0x7399b34*/ void ApplyRelativeLocal();
        /*0x739a7cc*/ Spine.ExposedList<Spine.Bone> get_Bones();
        /*0x739a7d4*/ Spine.Bone get_Target();
        /*0x739a7dc*/ string ToString();
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

        /*0x738fa44*/ TransformConstraintData(string name);
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

        static /*0x739a7f8*/ bool IsConcave(int index, int vertexCount, float[] vertices, int[] indices);
        static /*0x739a910*/ bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
        static /*0x739a93c*/ int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
        /*0x738971c*/ Triangulator();
        /*0x7387704*/ Spine.ExposedList<int> Triangulate(Spine.ExposedList<float> verticesArray);
        /*0x7387d04*/ Spine.ExposedList<Spine.ExposedList<float>> Decompose(Spine.ExposedList<float> verticesArray, Spine.ExposedList<int> triangles);
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
