class <Module>
{
}

namespace UnityEngine
{
    struct jvalue
    {
        /*0x10*/ bool z;
        /*0x10*/ sbyte b;
        /*0x10*/ char c;
        /*0x10*/ short s;
        /*0x10*/ int i;
        /*0x10*/ long j;
        /*0x10*/ float f;
        /*0x10*/ double d;
        /*0x10*/ nint l;
    }

    struct JNINativeMethod
    {
        /*0x10*/ string name;
        /*0x18*/ string signature;
        /*0x20*/ nint fnPtr;
    }

    class AndroidJNIHelper
    {
        static /*0x7dda230*/ bool get_debug();
        static /*0x7dda258*/ void set_debug(bool value);
        static /*0x7dda294*/ nint GetConstructorID(nint javaClass);
        static /*0x7dda2dc*/ nint GetConstructorID(nint javaClass, string signature);
        static /*0x7dda538*/ nint GetMethodID(nint javaClass, string methodName);
        static /*0x7dda610*/ nint GetMethodID(nint javaClass, string methodName, string signature);
        static /*0x7dda594*/ nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic);
        static /*0x7dda840*/ nint GetFieldID(nint javaClass, string fieldName);
        static /*0x7dda918*/ nint GetFieldID(nint javaClass, string fieldName, string signature);
        static /*0x7dda89c*/ nint GetFieldID(nint javaClass, string fieldName, string signature, bool isStatic);
        static /*0x7ddabe8*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x7ddac94*/ nint CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy);
        static /*0x7ddae88*/ nint ConvertToJNIArray(System.Array array);
        static /*0x7ddbbd0*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x7ddc180*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x7ddc2ac*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x7ddc4a8*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x7ddc514*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x7ddc5e4*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x7ddc6e4*/ string GetSignature(object obj);
        static /*0x7ddd650*/ string GetSignature(object[] args);
        static /*0x3910ae8*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x3910ae8*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x3910ae8*/ nint GetFieldID<FieldType>(nint jclass, string fieldName, bool isStatic);
        static /*0x38379c4*/ string GetSignature<ReturnType>(object[] args);
        static /*0x7ddd7fc*/ nint Box(UnityEngine.jvalue val, string boxedClass, string signature);
        static /*0x7dddaac*/ nint Box(sbyte value);
        static /*0x7dddb14*/ nint Box(short value);
        static /*0x7dddb7c*/ nint Box(int value);
        static /*0x7dddbe4*/ nint Box(long value);
        static /*0x7dddc4c*/ nint Box(float value);
        static /*0x7dddcb4*/ nint Box(double value);
        static /*0x7dddd1c*/ nint Box(char value);
        static /*0x7dddd84*/ nint Box(bool value);
        static /*0x7ddddec*/ nint GetUnboxMethod(nint obj, string methodName, string signature);
        static /*0x7dddff8*/ void Unbox(nint obj, ref sbyte value);
        static /*0x7dde0f8*/ void Unbox(nint obj, ref short value);
        static /*0x7dde1f8*/ void Unbox(nint obj, ref int value);
        static /*0x7dde2f8*/ void Unbox(nint obj, ref long value);
        static /*0x7dde3f8*/ void Unbox(nint obj, ref float value);
        static /*0x7dde504*/ void Unbox(nint obj, ref double value);
        static /*0x7dde610*/ void Unbox(nint obj, ref char value);
        static /*0x7dde710*/ void Unbox(nint obj, ref bool value);
    }

    class AndroidJNI
    {
        static /*0x7dde814*/ void ReleaseStringChars(UnityEngine.AndroidJNI.JStringBinding str);
        static /*0x7dde88c*/ nint GetJavaVM();
        static /*0x7dde8b4*/ int AttachCurrentThread();
        static /*0x7dde8dc*/ int DetachCurrentThread();
        static /*0x7dde904*/ void InvokeAction(System.Action action);
        static /*0x7dde928*/ void InvokeAttached(System.Action action);
        static /*0x7dde964*/ int GetVersion();
        static /*0x7dde98c*/ nint FindClass(string name);
        static /*0x7ddeb38*/ nint FromReflectedMethod(nint refMethod);
        static /*0x7ddeb74*/ nint FromReflectedField(nint refField);
        static /*0x7ddebb0*/ nint ToReflectedMethod(nint clazz, nint methodID, bool isStatic);
        static /*0x7ddec04*/ nint ToReflectedField(nint clazz, nint fieldID, bool isStatic);
        static /*0x7ddec58*/ nint GetSuperclass(nint clazz);
        static /*0x7ddec94*/ bool IsAssignableFrom(nint clazz1, nint clazz2);
        static /*0x7ddecd8*/ int Throw(nint obj);
        static /*0x7dded14*/ int ThrowNew(nint clazz, string message);
        static /*0x7ddeed0*/ nint ExceptionOccurred();
        static /*0x7ddeef8*/ void ExceptionDescribe();
        static /*0x7ddef20*/ void ExceptionClear();
        static /*0x7ddef48*/ void FatalError(string message);
        static /*0x7ddf0ec*/ int PushLocalFrame(int capacity);
        static /*0x7ddf128*/ nint PopLocalFrame(nint ptr);
        static /*0x7ddf164*/ nint NewGlobalRef(nint obj);
        static /*0x7ddf1a0*/ void DeleteGlobalRef(nint obj);
        static /*0x7ddf1dc*/ void QueueDeleteGlobalRef(nint obj);
        static /*0x7ddf218*/ uint GetQueueGlobalRefsCount();
        static /*0x7ddf240*/ nint NewWeakGlobalRef(nint obj);
        static /*0x7ddf27c*/ void DeleteWeakGlobalRef(nint obj);
        static /*0x7ddf2b8*/ nint NewLocalRef(nint obj);
        static /*0x7ddf2f4*/ void DeleteLocalRef(nint obj);
        static /*0x7ddf330*/ bool IsSameObject(nint obj1, nint obj2);
        static /*0x7ddf374*/ int EnsureLocalCapacity(int capacity);
        static /*0x7ddf3b0*/ nint AllocObject(nint clazz);
        static /*0x7ddf3ec*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7ddf454*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7ddf4ec*/ nint NewObjectA(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7ddf540*/ nint GetObjectClass(nint obj);
        static /*0x7ddf57c*/ bool IsInstanceOf(nint obj, nint clazz);
        static /*0x7ddf5c0*/ nint GetMethodID(nint clazz, string name, string sig);
        static /*0x7ddf85c*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x7ddfaf8*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x7ddfd94*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x7de0030*/ nint NewString(string chars);
        static /*0x7de0034*/ nint NewStringFromStr(string chars);
        static /*0x7de01e0*/ nint NewString(char[] chars);
        static /*0x7de02e8*/ nint NewStringUTF(string bytes);
        static /*0x7de0494*/ string GetStringChars(nint str);
        static /*0x7de0570*/ UnityEngine.AndroidJNI.JStringBinding GetStringCharsInternal(nint str);
        static /*0x7de0674*/ int GetStringLength(nint str);
        static /*0x7de06b0*/ int GetStringUTFLength(nint str);
        static /*0x7de06ec*/ string GetStringUTFChars(nint str);
        static /*0x7de07ec*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de0854*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de08c8*/ string CallStringMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de09bc*/ UnityEngine.AndroidJNI.JStringBinding CallStringMethodUnsafeInternal(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de0a98*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de0b00*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de0b98*/ nint CallObjectMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de0bec*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de0c54*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de0cec*/ int CallIntMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de0d40*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de0da8*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de0e44*/ bool CallBooleanMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de0e98*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de0f00*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de0f98*/ short CallShortMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de0fec*/ byte CallByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de0ff0*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de1058*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de10f0*/ sbyte CallSByteMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de1144*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de11ac*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de1244*/ char CallCharMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de1298*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de1300*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de1398*/ float CallFloatMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de13ec*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de1454*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de14ec*/ double CallDoubleMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de1540*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de15a8*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de1640*/ long CallLongMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de1694*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de16fc*/ void CallVoidMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de1794*/ void CallVoidMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de17e8*/ string GetStringField(nint obj, nint fieldID);
        static /*0x7de18cc*/ UnityEngine.AndroidJNI.JStringBinding GetStringFieldInternal(nint obj, nint fieldID);
        static /*0x7de1990*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x7de19d4*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x7de1a18*/ byte GetByteField(nint obj, nint fieldID);
        static /*0x7de1a5c*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x7de1aa0*/ char GetCharField(nint obj, nint fieldID);
        static /*0x7de1ae4*/ short GetShortField(nint obj, nint fieldID);
        static /*0x7de1b28*/ int GetIntField(nint obj, nint fieldID);
        static /*0x7de1b6c*/ long GetLongField(nint obj, nint fieldID);
        static /*0x7de1bb0*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x7de1bf4*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x7de1c38*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x7de1e0c*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x7de1e60*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x7de1eb4*/ void SetByteField(nint obj, nint fieldID, byte val);
        static /*0x7de1f08*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x7de1f5c*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x7de1fb0*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x7de2004*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x7de2058*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x7de20ac*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x7de2100*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x7de2154*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de21bc*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2230*/ string CallStaticStringMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2324*/ UnityEngine.AndroidJNI.JStringBinding CallStaticStringMethodUnsafeInternal(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2400*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2468*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2500*/ nint CallStaticObjectMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2554*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de25bc*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2654*/ int CallStaticIntMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de26a8*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2710*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de27ac*/ bool CallStaticBooleanMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2800*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2868*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2900*/ short CallStaticShortMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2954*/ byte CallStaticByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2958*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de29c0*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2a58*/ sbyte CallStaticSByteMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2aac*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2b14*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2bac*/ char CallStaticCharMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2c00*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2c68*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2d00*/ float CallStaticFloatMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2d54*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2dbc*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2e54*/ double CallStaticDoubleMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2ea8*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de2f10*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de2fa8*/ long CallStaticLongMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de2ffc*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de3064*/ void CallStaticVoidMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de30fc*/ void CallStaticVoidMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7de3150*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x7de3234*/ UnityEngine.AndroidJNI.JStringBinding GetStaticStringFieldInternal(nint clazz, nint fieldID);
        static /*0x7de32f8*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x7de333c*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x7de3380*/ byte GetStaticByteField(nint clazz, nint fieldID);
        static /*0x7de33c4*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x7de3408*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x7de344c*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x7de3490*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x7de34d4*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x7de3518*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x7de355c*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x7de35a0*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x7de3774*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x7de37c8*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x7de381c*/ void SetStaticByteField(nint clazz, nint fieldID, byte val);
        static /*0x7de3870*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x7de38c4*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x7de3918*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x7de396c*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x7de39c0*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x7de3a14*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x7de3a68*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x7de3abc*/ nint ToBooleanArray(bool[] array);
        static /*0x7de3bc4*/ nint ToByteArray(byte[] array);
        static /*0x7de3ccc*/ nint ToSByteArray(sbyte[] array);
        static /*0x7de3d20*/ nint ToSByteArray(sbyte* array, int length);
        static /*0x7de3d64*/ nint ToCharArray(char[] array);
        static /*0x7de3db8*/ nint ToCharArray(char* array, int length);
        static /*0x7de3dfc*/ nint ToShortArray(short[] array);
        static /*0x7de3e50*/ nint ToShortArray(short* array, int length);
        static /*0x7de3e94*/ nint ToIntArray(int[] array);
        static /*0x7de3ee8*/ nint ToIntArray(int* array, int length);
        static /*0x7de3f2c*/ nint ToLongArray(long[] array);
        static /*0x7de3f80*/ nint ToLongArray(long* array, int length);
        static /*0x7de3fc4*/ nint ToFloatArray(float[] array);
        static /*0x7de4018*/ nint ToFloatArray(float* array, int length);
        static /*0x7de405c*/ nint ToDoubleArray(double[] array);
        static /*0x7de40b0*/ nint ToDoubleArray(double* array, int length);
        static /*0x7de40f4*/ nint ToObjectArray(nint* array, int length, nint arrayClass);
        static /*0x7de4148*/ nint ToObjectArray(nint[] array, nint arrayClass);
        static /*0x7de41ac*/ nint ToObjectArray(nint[] array);
        static /*0x7de41b4*/ bool[] FromBooleanArray(nint array);
        static /*0x7de42f4*/ byte[] FromByteArray(nint array);
        static /*0x7de4434*/ sbyte[] FromSByteArray(nint array);
        static /*0x7de4470*/ char[] FromCharArray(nint array);
        static /*0x7de44ac*/ short[] FromShortArray(nint array);
        static /*0x7de44e8*/ int[] FromIntArray(nint array);
        static /*0x7de4524*/ long[] FromLongArray(nint array);
        static /*0x7de4560*/ float[] FromFloatArray(nint array);
        static /*0x7de459c*/ double[] FromDoubleArray(nint array);
        static /*0x7de45d8*/ nint[] FromObjectArray(nint array);
        static /*0x7de4718*/ int GetArrayLength(nint array);
        static /*0x7de4754*/ nint NewBooleanArray(int size);
        static /*0x7de4790*/ nint NewByteArray(int size);
        static /*0x7de47cc*/ nint NewSByteArray(int size);
        static /*0x7de4808*/ nint NewCharArray(int size);
        static /*0x7de4844*/ nint NewShortArray(int size);
        static /*0x7de4880*/ nint NewIntArray(int size);
        static /*0x7de48bc*/ nint NewLongArray(int size);
        static /*0x7de48f8*/ nint NewFloatArray(int size);
        static /*0x7de4934*/ nint NewDoubleArray(int size);
        static /*0x7de4970*/ nint NewObjectArray(int size, nint clazz, nint obj);
        static /*0x7de49c4*/ bool GetBooleanArrayElement(nint array, int index);
        static /*0x7de4a08*/ byte GetByteArrayElement(nint array, int index);
        static /*0x7de4a4c*/ sbyte GetSByteArrayElement(nint array, int index);
        static /*0x7de4a90*/ char GetCharArrayElement(nint array, int index);
        static /*0x7de4ad4*/ short GetShortArrayElement(nint array, int index);
        static /*0x7de4b18*/ int GetIntArrayElement(nint array, int index);
        static /*0x7de4b5c*/ long GetLongArrayElement(nint array, int index);
        static /*0x7de4ba0*/ float GetFloatArrayElement(nint array, int index);
        static /*0x7de4be4*/ double GetDoubleArrayElement(nint array, int index);
        static /*0x7de4c28*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x7de4c6c*/ void SetBooleanArrayElement(nint array, int index, byte val);
        static /*0x7de4cc4*/ void SetBooleanArrayElement(nint array, int index, bool val);
        static /*0x7de4d18*/ void SetByteArrayElement(nint array, int index, sbyte val);
        static /*0x7de4d6c*/ void SetSByteArrayElement(nint array, int index, sbyte val);
        static /*0x7de4dc0*/ void SetCharArrayElement(nint array, int index, char val);
        static /*0x7de4e14*/ void SetShortArrayElement(nint array, int index, short val);
        static /*0x7de4e68*/ void SetIntArrayElement(nint array, int index, int val);
        static /*0x7de4ebc*/ void SetLongArrayElement(nint array, int index, long val);
        static /*0x7de4f10*/ void SetFloatArrayElement(nint array, int index, float val);
        static /*0x7de4f64*/ void SetDoubleArrayElement(nint array, int index, double val);
        static /*0x7de4fb8*/ void SetObjectArrayElement(nint array, int index, nint obj);
        static /*0x7de500c*/ nint NewDirectByteBuffer(byte* buffer, long capacity);
        static /*0x7de5050*/ nint NewDirectByteBuffer(Unity.Collections.NativeArray<byte> buffer);
        static /*0x7de50a8*/ nint NewDirectByteBuffer(Unity.Collections.NativeArray<sbyte> buffer);
        static /*0x3910ae8*/ nint NewDirectByteBufferFromNativeArray<T>(Unity.Collections.NativeArray<T> buffer);
        static /*0x7de5100*/ sbyte* GetDirectBufferAddress(nint buffer);
        static /*0x7de513c*/ long GetDirectBufferCapacity(nint buffer);
        static /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetDirectBuffer<T>(nint buffer);
        static /*0x7de5178*/ Unity.Collections.NativeArray<byte> GetDirectByteBuffer(nint buffer);
        static /*0x7de51c0*/ Unity.Collections.NativeArray<sbyte> GetDirectSByteBuffer(nint buffer);
        static /*0x7de5208*/ int RegisterNatives(nint clazz, UnityEngine.JNINativeMethod[] methods);
        static /*0x7de5340*/ nint RegisterNativesAllocate(int length);
        static /*0x7de537c*/ void RegisterNativesSet(nint natives, int idx, string name, string signature, nint fnPtr);
        static /*0x7de55d4*/ int RegisterNativesAndFree(nint clazz, nint natives, int n);
        static /*0x7de5694*/ int UnregisterNatives(nint clazz);
        static /*0x7dde850*/ void ReleaseStringChars_Injected(ref UnityEngine.AndroidJNI.JStringBinding str);
        static /*0x7ddeafc*/ nint FindClass_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7ddee8c*/ int ThrowNew_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper message);
        static /*0x7ddf0b0*/ void FatalError_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper message);
        static /*0x7ddf808*/ nint GetMethodID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7ddfaa4*/ nint GetFieldID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7ddfd40*/ nint GetStaticMethodID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7ddffdc*/ nint GetStaticFieldID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7de01a4*/ nint NewStringFromStr_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper chars);
        static /*0x7de02ac*/ nint NewString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper chars);
        static /*0x7de0458*/ nint NewStringUTF_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper bytes);
        static /*0x7de0630*/ void GetStringCharsInternal_Injected(nint str, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7de07a8*/ void GetStringUTFChars_Injected(nint str, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7de0a3c*/ void CallStringMethodUnsafeInternal_Injected(nint obj, nint methodID, UnityEngine.jvalue* args, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7de193c*/ void GetStringFieldInternal_Injected(nint obj, nint fieldID, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7de1db8*/ void SetStringField_Injected(nint obj, nint fieldID, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x7de23a4*/ void CallStaticStringMethodUnsafeInternal_Injected(nint clazz, nint methodID, UnityEngine.jvalue* args, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7de32a4*/ void GetStaticStringFieldInternal_Injected(nint clazz, nint fieldID, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7de3720*/ void SetStaticStringField_Injected(nint clazz, nint fieldID, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x7de3b88*/ nint ToBooleanArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper array);
        static /*0x7de3c90*/ nint ToByteArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper array);
        static /*0x7de42b0*/ void FromBooleanArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7de43f0*/ void FromByteArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7de46d4*/ void FromObjectArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7de5628*/ void RegisterNativesSet_Injected(nint natives, int idx, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper signature, nint fnPtr);

        struct JStringBinding : System.IDisposable
        {
            /*0x10*/ nint javaString;
            /*0x18*/ nint chars;
            /*0x20*/ int length;
            /*0x24*/ bool ownsRef;

            /*0x7de05d8*/ string ToString();
            /*0x7de56d0*/ void Dispose();
        }
    }

    class AndroidJNISafe
    {
        static /*0x7de5728*/ void CheckException();
        static /*0x7de5a9c*/ void QueueDeleteGlobalRef(nint globalref);
        static /*0x7de5ae0*/ void DeleteWeakGlobalRef(nint globalref);
        static /*0x7de5b24*/ void DeleteLocalRef(nint localref);
        static /*0x7de5b68*/ nint NewString(string chars);
        static /*0x7de5be0*/ string GetStringChars(nint str);
        static /*0x7dddee0*/ nint GetObjectClass(nint ptr);
        static /*0x7ddd9bc*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x7dddf80*/ nint GetMethodID(nint obj, string name, string sig);
        static /*0x7de5c58*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x7de5cd0*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x7de5d48*/ nint FromReflectedMethod(nint refMethod);
        static /*0x7ddd944*/ nint FindClass(string name);
        static /*0x7de5de8*/ void PushLocalFrame(int capacity);
        static /*0x7de5e38*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de5eb0*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x7de5f6c*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x7de5fe4*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x7de60a0*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x7de615c*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x7de6218*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x7de62d4*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x7de6390*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x7de644c*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x7de6508*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x7de65c4*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x7de666c*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x7de66e4*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x7de678c*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x7de6840*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x7de68f4*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x7de699c*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x7de6a44*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x7de6aec*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x7de6b94*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x7de6c3c*/ void CallStaticVoidMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de6cb4*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7ddda34*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de6d1c*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de6d84*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de6dfc*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de6e74*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de6ef8*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de6f7c*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de6ff4*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de706c*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de70e4*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de715c*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de71d4*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x7de7290*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x7de7308*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x7de73c4*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x7de7480*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x7de753c*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x7de75f8*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x7de76b4*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x7de7770*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x7de782c*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x7de78e8*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x7de7990*/ string GetStringField(nint obj, nint fieldID);
        static /*0x7de7a08*/ char GetCharField(nint obj, nint fieldID);
        static /*0x7de7ab0*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x7de7b64*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x7de7c18*/ long GetLongField(nint obj, nint fieldID);
        static /*0x7de7cc0*/ short GetShortField(nint obj, nint fieldID);
        static /*0x7de7d68*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x7de7e10*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x7de7eb8*/ int GetIntField(nint obj, nint fieldID);
        static /*0x7de7f60*/ void CallVoidMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de7fd8*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7de8040*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de80b8*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde698*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde58c*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde480*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde380*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde180*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde080*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde79c*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dde280*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7de8130*/ char[] FromCharArray(nint array);
        static /*0x7de81d0*/ double[] FromDoubleArray(nint array);
        static /*0x7de8270*/ float[] FromFloatArray(nint array);
        static /*0x7de8310*/ long[] FromLongArray(nint array);
        static /*0x7de83b0*/ short[] FromShortArray(nint array);
        static /*0x7de8450*/ byte[] FromByteArray(nint array);
        static /*0x7de84c8*/ sbyte[] FromSByteArray(nint array);
        static /*0x7de8568*/ bool[] FromBooleanArray(nint array);
        static /*0x7de85e0*/ int[] FromIntArray(nint array);
        static /*0x7de8680*/ nint ToObjectArray(nint[] array, nint type);
        static /*0x7de86f8*/ nint ToCharArray(char[] array);
        static /*0x7de8770*/ nint ToDoubleArray(double[] array);
        static /*0x7de87e8*/ nint ToFloatArray(float[] array);
        static /*0x7de8860*/ nint ToLongArray(long[] array);
        static /*0x7de88d8*/ nint ToShortArray(short[] array);
        static /*0x7de8950*/ nint ToByteArray(byte[] array);
        static /*0x7de89c8*/ nint ToSByteArray(sbyte[] array);
        static /*0x7de8a40*/ nint ToBooleanArray(bool[] array);
        static /*0x7de8ab8*/ nint ToIntArray(int[] array);
        static /*0x7de8b30*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x7de8bd8*/ int GetArrayLength(nint array);
    }

    class AndroidJavaRunnable : System.MulticastDelegate
    {
        /*0x7de8c78*/ AndroidJavaRunnable(object object, nint method);
        /*0x7de8d14*/ void Invoke();
    }

    class AndroidJavaException : System.Exception
    {
        /*0x90*/ string mJavaStackTrace;

        /*0x7de5a20*/ AndroidJavaException(string message, string javaStackTrace);
        /*0x7de8d28*/ string get_StackTrace();
    }

    class GlobalJavaObjectRef
    {
        /*0x10*/ bool m_disposed;
        /*0x18*/ nint m_jobject;

        static /*0x7de8e9c*/ nint op_Implicit(UnityEngine.GlobalJavaObjectRef obj);
        /*0x7de8d4c*/ GlobalJavaObjectRef(nint jobject);
        /*0x7de8dac*/ void Finalize();
        /*0x7de8e40*/ void Dispose();
    }

    class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ UnityEngine.AndroidJavaRunnable mRunnable;

        /*0x7de8eb4*/ AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable);
        /*0x7de8fc4*/ void run();
        /*0x7de8fe8*/ nint Invoke(string methodName, nint javaArgs);
    }

    class AndroidJavaProxy
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        static /*0x8*/ nint s_HashCodeMethodID;
        /*0x10*/ UnityEngine.AndroidJavaClass javaInterface;
        /*0x18*/ nint proxyObject;

        static /*0x7debc7c*/ AndroidJavaProxy();
        /*0x7de8f3c*/ AndroidJavaProxy(string javaInterface);
        /*0x7de94a8*/ AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface);
        /*0x7de94dc*/ void Finalize();
        /*0x7de959c*/ UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args);
        /*0x7deab6c*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs);
        /*0x7de9098*/ nint Invoke(string methodName, nint javaArgs);
        /*0x7deba34*/ bool equals(UnityEngine.AndroidJavaObject obj);
        /*0x7deba8c*/ int hashCode();
        /*0x7debc08*/ string toString();
        /*0x7debc6c*/ UnityEngine.AndroidJavaObject GetProxyObject();
        /*0x7debb4c*/ nint GetRawProxy();
    }

    class AndroidJavaObject : System.IDisposable
    {
        static /*0x0*/ bool enableDebugPrints;
        /*0x10*/ UnityEngine.GlobalJavaObjectRef m_jobject;
        /*0x18*/ UnityEngine.GlobalJavaObjectRef m_jclass;

        static /*0x7deb908*/ UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject);
        static /*0x7ded0d8*/ UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass);
        static /*0x3910ae8*/ ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(nint jobject);
        static /*0x3910ae8*/ ReturnType FromJavaArray<ReturnType>(nint jobject);
        /*0x7debd84*/ AndroidJavaObject(string className, string[] args);
        /*0x7debf64*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaObject[] args);
        /*0x7dec024*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaClass[] args);
        /*0x7dec0e4*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaProxy[] args);
        /*0x7dec1a4*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaRunnable[] args);
        /*0x7dec264*/ AndroidJavaObject(string className, object[] args);
        /*0x7deaa38*/ AndroidJavaObject(nint jobject);
        /*0x7dec298*/ AndroidJavaObject(nint clazz, nint constructorID, object[] args);
        /*0x7debe44*/ AndroidJavaObject();
        /*0x7deb89c*/ void Dispose();
        /*0x3816810*/ void Call<T>(string methodName, T[] args);
        /*0x3816690*/ void Call<T>(nint methodID, T[] args);
        /*0x7dec53c*/ void Call(string methodName, object[] args);
        /*0x7dec580*/ void Call(nint methodID, object[] args);
        /*0x3816810*/ void CallStatic<T>(string methodName, T[] args);
        /*0x3816690*/ void CallStatic<T>(nint methodID, T[] args);
        /*0x7dec784*/ void CallStatic(string methodName, object[] args);
        /*0x7dec7c8*/ void CallStatic(nint methodID, object[] args);
        /*0x3910ae8*/ FieldType Get<FieldType>(string fieldName);
        /*0x3910ae8*/ FieldType Get<FieldType>(nint fieldID);
        /*0x3910ae8*/ void Set<FieldType>(string fieldName, FieldType val);
        /*0x3910ae8*/ void Set<FieldType>(nint fieldID, FieldType val);
        /*0x3910ae8*/ FieldType GetStatic<FieldType>(string fieldName);
        /*0x3910ae8*/ FieldType GetStatic<FieldType>(nint fieldID);
        /*0x3910ae8*/ void SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x3910ae8*/ void SetStatic<FieldType>(nint fieldID, FieldType val);
        /*0x7deba1c*/ nint GetRawObject();
        /*0x7dec9e4*/ nint GetRawClass();
        /*0x7deca1c*/ UnityEngine.AndroidJavaObject CloneReference();
        /*0x3910ae8*/ ReturnType Call<ReturnType, T>(string methodName, T[] args);
        /*0x3910ae8*/ ReturnType Call<ReturnType, T>(nint methodID, T[] args);
        /*0x3910ae8*/ ReturnType Call<ReturnType>(string methodName, object[] args);
        /*0x3910ae8*/ ReturnType Call<ReturnType>(nint methodID, object[] args);
        /*0x3910ae8*/ ReturnType CallStatic<ReturnType, T>(string methodName, T[] args);
        /*0x3910ae8*/ ReturnType CallStatic<ReturnType, T>(nint methodID, T[] args);
        /*0x3910ae8*/ ReturnType CallStatic<ReturnType>(string methodName, object[] args);
        /*0x3910ae8*/ ReturnType CallStatic<ReturnType>(nint methodID, object[] args);
        /*0x7decc4c*/ void DebugPrint(string msg);
        /*0x7deccd4*/ void DebugPrint(string call, string methodName, string signature, object[] args);
        /*0x7debe4c*/ void _AndroidJavaObject(string className, object[] args);
        /*0x7dec330*/ void _AndroidJavaObject(nint constructorID, object[] args);
        /*0x7decfdc*/ void Finalize();
        /*0x7ded07c*/ void Dispose(bool disposing);
        /*0x7dec540*/ void _Call(string methodName, object[] args);
        /*0x7dec584*/ void _Call(nint methodID, object[] args);
        /*0x3910ae8*/ ReturnType _Call<ReturnType>(string methodName, object[] args);
        /*0x3910ae8*/ ReturnType _Call<ReturnType>(nint methodID, object[] args);
        /*0x3910ae8*/ FieldType _Get<FieldType>(string fieldName);
        /*0x3910ae8*/ FieldType _Get<FieldType>(nint fieldID);
        /*0x3910ae8*/ void _Set<FieldType>(string fieldName, FieldType val);
        /*0x3910ae8*/ void _Set<FieldType>(nint fieldID, FieldType val);
        /*0x7dec788*/ void _CallStatic(string methodName, object[] args);
        /*0x7dec7cc*/ void _CallStatic(nint methodID, object[] args);
        /*0x3910ae8*/ ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
        /*0x3910ae8*/ ReturnType _CallStatic<ReturnType>(nint methodID, object[] args);
        /*0x3910ae8*/ FieldType _GetStatic<FieldType>(string fieldName);
        /*0x3910ae8*/ FieldType _GetStatic<FieldType>(nint fieldID);
        /*0x3910ae8*/ void _SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x3910ae8*/ void _SetStatic<FieldType>(nint fieldID, FieldType val);
        /*0x7dec9cc*/ nint _GetRawObject();
        /*0x7deca00*/ nint _GetRawClass();
    }

    class AndroidJavaObjectUnityOwned : UnityEngine.AndroidJavaObject
    {
        /*0x7ded1ec*/ AndroidJavaObjectUnityOwned(nint jobject);
        /*0x7ded1f0*/ void Dispose(bool disposing);
    }

    class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        /*0x7de947c*/ AndroidJavaClass(string className);
        /*0x7decb80*/ AndroidJavaClass(nint jclass);
        /*0x7ded248*/ void _AndroidJavaClass(string className);
    }

    class AndroidReflection
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass;
        static /*0x8*/ nint s_ReflectionHelperGetConstructorID;
        static /*0x10*/ nint s_ReflectionHelperGetMethodID;
        static /*0x18*/ nint s_ReflectionHelperGetFieldID;
        static /*0x20*/ nint s_ReflectionHelperGetFieldSignature;
        static /*0x28*/ nint s_ReflectionHelperNewProxyInstance;
        static /*0x30*/ nint s_ReflectionHelperCeateInvocationError;
        static /*0x38*/ nint s_FieldGetDeclaringClass;

        static /*0x7dedcc8*/ AndroidReflection();
        static /*0x7ded354*/ bool IsPrimitive(System.Type t);
        static /*0x7ded368*/ bool IsAssignableFrom(System.Type t, System.Type from);
        static /*0x7ded388*/ nint GetStaticMethodID(string clazz, string methodName, string signature);
        static /*0x7ded47c*/ nint GetMethodID(string clazz, string methodName, string signature);
        static /*0x7ded570*/ nint GetConstructorMember(nint jclass, string signature);
        static /*0x7ded748*/ nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x7ded910*/ nint GetFieldMember(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x7dedad8*/ nint GetFieldClass(nint field);
        static /*0x7dedb3c*/ string GetFieldSignature(nint field);
        static /*0x7dedbe4*/ nint NewProxyInstance(nint player, nint delegateHandle, nint interfaze);
        static /*0x7dea948*/ nint CreateInvocationError(System.Exception ex, bool methodNotFound);
    }

    class _AndroidJNIHelper
    {
        static /*0x0*/ int FRAME_SIZE_FOR_ARRAYS;

        static /*0x7dee8e8*/ _AndroidJNIHelper();
        static /*0x7ddae00*/ nint CreateJavaProxy(nint player, nint delegateHandle, UnityEngine.AndroidJavaProxy proxy);
        static /*0x7ddac3c*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x7dedf7c*/ nint InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, nint jmethodName, nint jargs);
        static /*0x7ddbc8c*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret);
        static /*0x7dee064*/ object UnboxArray(UnityEngine.AndroidJavaObject obj);
        static /*0x7dead24*/ object Unbox(UnityEngine.AndroidJavaObject obj);
        static /*0x7de9fcc*/ UnityEngine.AndroidJavaObject Box(object obj);
        static /*0x7ddc33c*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x7ddaedc*/ nint ConvertToJNIArray(System.Array array);
        static /*0x3910ae8*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x7ddc578*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x7ddc660*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x3910ae8*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x3910ae8*/ nint GetFieldID<ReturnType>(nint jclass, string fieldName, bool isStatic);
        static /*0x7dda340*/ nint GetConstructorID(nint jclass, string signature);
        static /*0x7dda618*/ nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x7dee84c*/ nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x7dda920*/ nint GetFieldID(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x7ddc738*/ string GetSignature(object obj);
        static /*0x7ddd6a4*/ string GetSignature(object[] args);
        static /*0x38379c4*/ string GetSignature<ReturnType>(object[] args);
        /*0x7dee8e0*/ _AndroidJNIHelper();
    }

    namespace Android
    {
        class AndroidApplication
        {
            static /*0x0*/ System.Threading.SynchronizationContext m_MainThreadSynchronizationContext;
            static /*0x8*/ UnityEngine.AndroidJavaObjectUnityOwned m_Context;
            static /*0x10*/ UnityEngine.AndroidJavaObjectUnityOwned m_Activity;
            static /*0x18*/ UnityEngine.Android.AndroidConfiguration m_CurrentConfiguration;
            static /*0x20*/ System.Action<UnityEngine.Android.AndroidConfiguration> onConfigurationChanged;

            static /*0x7ddadd8*/ nint get_UnityPlayerRaw();
            static /*0x7dee934*/ nint get_CurrentContextRaw();
            static /*0x7dee95c*/ nint get_CurrentActivityRaw();
            static /*0x7dee984*/ void AcquireMainThreadSynchronizationContext();
            static /*0x7deea3c*/ UnityEngine.AndroidJavaObject get_currentContext();
            static /*0x7deeafc*/ UnityEngine.AndroidJavaObject get_currentActivity();
            static /*0x7deebbc*/ void SetCurrentConfiguration(UnityEngine.Android.AndroidConfiguration config);
            static /*0x7deec0c*/ UnityEngine.Android.AndroidConfiguration GetCurrentConfiguration();
            static /*0x7deec54*/ void DispatchConfigurationChanged(bool notifySubscribers);
        }

        enum AndroidAssetPackStatus
        {
            Unknown = 0,
            Pending = 1,
            Downloading = 2,
            Transferring = 3,
            Completed = 4,
            Failed = 5,
            Canceled = 6,
            WaitingForWifi = 7,
            NotInstalled = 8,
        }

        enum AndroidAssetPackError
        {
            NoError = 0,
            AppUnavailable = -1,
            PackUnavailable = -2,
            InvalidRequest = -3,
            DownloadNotFound = -4,
            ApiNotAvailable = -5,
            NetworkError = -6,
            AccessDenied = -7,
            InsufficientStorage = -10,
            PlayStoreNotFound = -11,
            NetworkUnrestricted = -12,
            AppNotOwned = -13,
            InternalError = -100,
        }

        class AndroidAssetPackInfo
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x20*/ ulong <size>k__BackingField;
            /*0x28*/ ulong <bytesDownloaded>k__BackingField;
            /*0x30*/ float <transferProgress>k__BackingField;
            /*0x34*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            static /*0x7deed34*/ bool DownloadInProgress(UnityEngine.Android.AndroidAssetPackStatus status);
            /*0x7deecc4*/ AndroidAssetPackInfo(string name, UnityEngine.Android.AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackState
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x1c*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            /*0x7deed60*/ AndroidAssetPackState(string name, UnityEngine.Android.AndroidAssetPackStatus status, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackUseMobileDataRequestResult
        {
            /*0x10*/ bool <allowed>k__BackingField;

            /*0x7deeda8*/ AndroidAssetPackUseMobileDataRequestResult(bool allowed);
        }

        class AndroidAssetPacks
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;
            static /*0x8*/ bool s_ApiMissing;

            static /*0x7deedd0*/ UnityEngine.AndroidJavaObject GetAssetPackManager();

            class AssetPackManagerDownloadStatusCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackInfo> m_Callback;
                /*0x28*/ System.Collections.Generic.Dictionary<string, UnityEngine.Android.AndroidAssetPackStatus> m_AssetPacks;

                /*0x7def184*/ AssetPackManagerDownloadStatusCallback(System.Action<UnityEngine.Android.AndroidAssetPackInfo> callback, string[] assetPacks);
                /*0x7def384*/ void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Android.AndroidAssetPacks.AssetPackManagerDownloadStatusCallback.<> <>9;
                    static /*0x8*/ System.Func<string, string> <>9__2_0;
                    static /*0x10*/ System.Func<string, UnityEngine.Android.AndroidAssetPackStatus> <>9__2_1;

                    static /*0x7def654*/ <>c();
                    /*0x7def6bc*/ <>c();
                    /*0x7def6c4*/ string <.ctor>b__2_0(string ap);
                    /*0x7def6cc*/ UnityEngine.Android.AndroidAssetPackStatus <.ctor>b__2_1(string ap);
                }
            }

            class AssetPackManagerMobileDataConfirmationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> m_Callback;

                /*0x7def6d4*/ AssetPackManagerMobileDataConfirmationCallback(System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> callback);
                /*0x7def75c*/ void onMobileDataConfirmationResult(bool allowed);
            }

            class AssetPackManagerStatusQueryCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> m_Callback;
                /*0x28*/ System.Collections.Generic.List<string> m_AssetPackNames;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Android.AndroidAssetPackState> m_States;
                /*0x38*/ long m_Size;

                /*0x7def7e0*/ AssetPackManagerStatusQueryCallback(System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> callback, string[] assetPacks);
                /*0x7def8f8*/ void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes);
            }
        }

        class AndroidGame
        {
            static /*0x7def618*/ void StopLoading(int label);
        }

        class PermissionCallbacks : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<string> PermissionGranted;
            /*0x28*/ System.Action<string> PermissionDenied;
            /*0x30*/ System.Action<string> PermissionDeniedAndDontAskAgain;
            /*0x38*/ System.Action<string> PermissionRequestDismissed;

            /*0x7df0210*/ PermissionCallbacks();
            /*0x7defc90*/ void add_PermissionGranted(System.Action<string> value);
            /*0x7defd40*/ void remove_PermissionGranted(System.Action<string> value);
            /*0x7defdf0*/ void add_PermissionDenied(System.Action<string> value);
            /*0x7defea0*/ void remove_PermissionDenied(System.Action<string> value);
            /*0x7deff50*/ void add_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x7df0000*/ void remove_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x7df00b0*/ void add_PermissionRequestDismissed(System.Action<string> value);
            /*0x7df0160*/ void remove_PermissionRequestDismissed(System.Action<string> value);
            /*0x7df027c*/ nint Invoke(string methodName, nint javaArgs);
            /*0x7df030c*/ void onPermissionResult(nint javaArgs);

            enum Result
            {
                Dismissed = 0,
                Granted = 1,
                Denied = 2,
                DeniedDontAskAgain = 3,
            }
        }

        struct Permission
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject m_UnityPermissions;

            static /*0x7df0458*/ UnityEngine.AndroidJavaObject GetUnityPermissions();
            static /*0x7df0518*/ bool HasUserAuthorizedPermission(string permission);
            static /*0x7df0650*/ void RequestUserPermission(string permission);
            static /*0x7df06dc*/ void RequestUserPermissions(string[] permissions, UnityEngine.Android.PermissionCallbacks callbacks);
        }

        enum AndroidColorModeHdr
        {
            Undefined = 0,
            No = 4,
            Yes = 8,
        }

        enum AndroidColorModeWideColorGamut
        {
            Undefined = 0,
            No = 1,
            Yes = 2,
        }

        class AndroidLocale
        {
            /*0x10*/ string <country>k__BackingField;
            /*0x18*/ string <language>k__BackingField;

            /*0x7df0848*/ AndroidLocale(string _country, string _language);
            /*0x7df0838*/ string get_country();
            /*0x7df0840*/ string get_language();
        }

        class AndroidConfiguration
        {
            /*0x10*/ int <colorMode>k__BackingField;
            /*0x14*/ int <densityDpi>k__BackingField;
            /*0x18*/ float <fontScale>k__BackingField;
            /*0x1c*/ int <fontWeightAdjustment>k__BackingField;
            /*0x20*/ UnityEngine.Android.AndroidKeyboard <keyboard>k__BackingField;
            /*0x24*/ UnityEngine.Android.AndroidHardwareKeyboardHidden <hardKeyboardHidden>k__BackingField;
            /*0x28*/ UnityEngine.Android.AndroidKeyboardHidden <keyboardHidden>k__BackingField;
            /*0x2c*/ int <mobileCountryCode>k__BackingField;
            /*0x30*/ int <mobileNetworkCode>k__BackingField;
            /*0x34*/ UnityEngine.Android.AndroidNavigation <navigation>k__BackingField;
            /*0x38*/ UnityEngine.Android.AndroidNavigationHidden <navigationHidden>k__BackingField;
            /*0x3c*/ UnityEngine.Android.AndroidOrientation <orientation>k__BackingField;
            /*0x40*/ int <screenHeightDp>k__BackingField;
            /*0x44*/ int <screenWidthDp>k__BackingField;
            /*0x48*/ int <smallestScreenWidthDp>k__BackingField;
            /*0x4c*/ int <screenLayout>k__BackingField;
            /*0x50*/ UnityEngine.Android.AndroidTouchScreen <touchScreen>k__BackingField;
            /*0x54*/ int <uiMode>k__BackingField;
            /*0x58*/ string <primaryLocaleCountry>k__BackingField;
            /*0x60*/ string <primaryLocaleLanguage>k__BackingField;

            /*0x7df088c*/ int get_colorMode();
            /*0x7df0894*/ int get_densityDpi();
            /*0x7df089c*/ float get_fontScale();
            /*0x7df08a4*/ int get_fontWeightAdjustment();
            /*0x7df08ac*/ UnityEngine.Android.AndroidKeyboard get_keyboard();
            /*0x7df08b4*/ UnityEngine.Android.AndroidHardwareKeyboardHidden get_hardKeyboardHidden();
            /*0x7df08bc*/ UnityEngine.Android.AndroidKeyboardHidden get_keyboardHidden();
            /*0x7df08c4*/ int get_mobileCountryCode();
            /*0x7df08cc*/ int get_mobileNetworkCode();
            /*0x7df08d4*/ UnityEngine.Android.AndroidNavigation get_navigation();
            /*0x7df08dc*/ UnityEngine.Android.AndroidNavigationHidden get_navigationHidden();
            /*0x7df08e4*/ UnityEngine.Android.AndroidOrientation get_orientation();
            /*0x7df08ec*/ int get_screenHeightDp();
            /*0x7df08f4*/ int get_screenWidthDp();
            /*0x7df08fc*/ int get_smallestScreenWidthDp();
            /*0x7df0904*/ int get_screenLayout();
            /*0x7df090c*/ UnityEngine.Android.AndroidTouchScreen get_touchScreen();
            /*0x7df0914*/ int get_uiMode();
            /*0x7df091c*/ string get_primaryLocaleCountry();
            /*0x7df0924*/ string get_primaryLocaleLanguage();
            /*0x7df092c*/ UnityEngine.Android.AndroidLocale[] get_locales();
            /*0x7df0a30*/ UnityEngine.Android.AndroidColorModeHdr get_colorModeHdr();
            /*0x7df0a3c*/ UnityEngine.Android.AndroidColorModeWideColorGamut get_colorModeWideColorGamut();
            /*0x7df0a48*/ UnityEngine.Android.AndroidScreenLayoutDirection get_screenLayoutDirection();
            /*0x7df0a54*/ UnityEngine.Android.AndroidScreenLayoutLong get_screenLayoutLong();
            /*0x7df0a60*/ UnityEngine.Android.AndroidScreenLayoutRound get_screenLayoutRound();
            /*0x7df0a6c*/ UnityEngine.Android.AndroidScreenLayoutSize get_screenLayoutSize();
            /*0x7df0a78*/ UnityEngine.Android.AndroidUIModeNight get_uiModeNight();
            /*0x7df0a84*/ UnityEngine.Android.AndroidUIModeType get_uiModeType();
            /*0x7df0a90*/ string ToString();
        }

        enum AndroidHardwareKeyboardHidden
        {
            Undefined = 0,
            No = 1,
            Yes = 2,
        }

        enum AndroidKeyboard
        {
            Undefined = 0,
            NoKeys = 1,
            Qwerty = 2,
            _12Key = 3,
        }

        enum AndroidKeyboardHidden
        {
            Undefined = 0,
            No = 1,
            Yes = 2,
        }

        enum AndroidNavigation
        {
            Undefined = 0,
            NoNav = 1,
            Dpad = 2,
            TrackBall = 3,
            Wheel = 4,
        }

        enum AndroidNavigationHidden
        {
            Undefined = 0,
            No = 1,
            Yes = 2,
        }

        enum AndroidOrientation
        {
            Undefined = 0,
            Portrait = 1,
            Landscape = 2,
        }

        enum AndroidScreenLayoutDirection
        {
            LTR = 64,
            RTL = 128,
        }

        enum AndroidScreenLayoutLong
        {
            Undefined = 0,
            No = 16,
            Yes = 32,
        }

        enum AndroidScreenLayoutRound
        {
            Undefined = 0,
            No = 256,
            Yes = 512,
        }

        enum AndroidScreenLayoutSize
        {
            Undefined = 0,
            Small = 1,
            Normal = 2,
            Large = 3,
            XLarge = 4,
        }

        enum AndroidTouchScreen
        {
            Undefined = 0,
            NoTouch = 1,
            Finger = 3,
        }

        enum AndroidUIModeNight
        {
            Undefined = 0,
            No = 16,
            Yes = 32,
        }

        enum AndroidUIModeType
        {
            Undefined = 0,
            Normal = 1,
            Desk = 2,
            Car = 3,
            Television = 4,
            Appliance = 5,
            Watch = 6,
            VrHeadset = 7,
        }
    }
}
