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

    class AndroidJNIHelper
    {
        static /*0x2a2c638*/ bool get_debug();
        static /*0x2a2c66c*/ void set_debug(bool value);
        static /*0x2a2c6ac*/ nint GetConstructorID(nint javaClass);
        static /*0x2a2c6f8*/ nint GetConstructorID(nint javaClass, string signature);
        static /*0x2a2c8c0*/ nint GetMethodID(nint javaClass, string methodName);
        static /*0x2a2c928*/ nint GetMethodID(nint javaClass, string methodName, string signature);
        static /*0x2a2c920*/ nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic);
        static /*0x2a2cb04*/ nint GetFieldID(nint javaClass, string fieldName);
        static /*0x2a2cb6c*/ nint GetFieldID(nint javaClass, string fieldName, string signature);
        static /*0x2a2cb64*/ nint GetFieldID(nint javaClass, string fieldName, string signature, bool isStatic);
        static /*0x2a2ce74*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x2a2ced4*/ nint CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy);
        static /*0x2a2d034*/ nint ConvertToJNIArray(System.Array array);
        static /*0x2a2d9f4*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x2a2dfdc*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x2a2e154*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x2a2e1ac*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x2a2e234*/ string GetSignature(object obj);
        static /*0x2a2f060*/ string GetSignature(object[] args);
        static ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetFieldID<FieldType>(nint jclass, string fieldName, bool isStatic);
        static string GetSignature<ReturnType>(object[] args);
    }

    class AndroidJNI
    {
        static /*0x2a29500*/ int AttachCurrentThread();
        static /*0x2a29534*/ int DetachCurrentThread();
        static /*0x2a29568*/ int GetVersion();
        static /*0x2a2959c*/ nint FindClass(string name);
        static /*0x2a295dc*/ nint FromReflectedMethod(nint refMethod);
        static /*0x2a2961c*/ nint FromReflectedField(nint refField);
        static /*0x2a2965c*/ nint ToReflectedMethod(nint clazz, nint methodID, bool isStatic);
        static /*0x2a296b4*/ nint ToReflectedField(nint clazz, nint fieldID, bool isStatic);
        static /*0x2a2970c*/ nint GetSuperclass(nint clazz);
        static /*0x2a2974c*/ bool IsAssignableFrom(nint clazz1, nint clazz2);
        static /*0x2a2979c*/ int Throw(nint obj);
        static /*0x2a297dc*/ int ThrowNew(nint clazz, string message);
        static /*0x2a2982c*/ nint ExceptionOccurred();
        static /*0x2a29860*/ void ExceptionDescribe();
        static /*0x2a29894*/ void ExceptionClear();
        static /*0x2a298c8*/ void FatalError(string message);
        static /*0x2a29908*/ int PushLocalFrame(int capacity);
        static /*0x2a29948*/ nint PopLocalFrame(nint ptr);
        static /*0x2a29988*/ nint NewGlobalRef(nint obj);
        static /*0x2a299c8*/ void DeleteGlobalRef(nint obj);
        static /*0x2a29a08*/ nint NewWeakGlobalRef(nint obj);
        static /*0x2a29a48*/ void DeleteWeakGlobalRef(nint obj);
        static /*0x2a29a88*/ nint NewLocalRef(nint obj);
        static /*0x2a29ac8*/ void DeleteLocalRef(nint obj);
        static /*0x2a29b08*/ bool IsSameObject(nint obj1, nint obj2);
        static /*0x2a29b58*/ int EnsureLocalCapacity(int capacity);
        static /*0x2a29b98*/ nint AllocObject(nint clazz);
        static /*0x2a29bd8*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a29c30*/ nint GetObjectClass(nint obj);
        static /*0x2a29c70*/ bool IsInstanceOf(nint obj, nint clazz);
        static /*0x2a29cc0*/ nint GetMethodID(nint clazz, string name, string sig);
        static /*0x2a29d18*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x2a29d70*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x2a29dc8*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x2a29e20*/ nint NewString(string chars);
        static /*0x2a29e60*/ nint NewStringFromStr(string chars);
        static /*0x2a29ea0*/ nint NewString(char[] chars);
        static /*0x2a29ee0*/ nint NewStringUTF(string bytes);
        static /*0x2a29f20*/ string GetStringChars(nint str);
        static /*0x2a29f60*/ int GetStringLength(nint str);
        static /*0x2a29fa0*/ int GetStringUTFLength(nint str);
        static /*0x2a29fe0*/ string GetStringUTFChars(nint str);
        static /*0x2a2a020*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a078*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a0d0*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a128*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a180*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a1d8*/ byte CallByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a230*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a288*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a2e0*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a338*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a390*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a3e8*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2a440*/ string GetStringField(nint obj, nint fieldID);
        static /*0x2a2a490*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x2a2a4e0*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x2a2a530*/ byte GetByteField(nint obj, nint fieldID);
        static /*0x2a2a580*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x2a2a5d0*/ char GetCharField(nint obj, nint fieldID);
        static /*0x2a2a620*/ short GetShortField(nint obj, nint fieldID);
        static /*0x2a2a670*/ int GetIntField(nint obj, nint fieldID);
        static /*0x2a2a6c0*/ long GetLongField(nint obj, nint fieldID);
        static /*0x2a2a710*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x2a2a760*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x2a2a7b0*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x2a2a808*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x2a2a860*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x2a2a8b8*/ void SetByteField(nint obj, nint fieldID, byte val);
        static /*0x2a2a910*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x2a2a968*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x2a2a9c0*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x2a2aa18*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x2a2aa70*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x2a2aac8*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x2a2ab28*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x2a2ab88*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2abe0*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2ac38*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2ac90*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2ace8*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2ad40*/ byte CallStaticByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2ad98*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2adf0*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2ae48*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2aea0*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2aef8*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2af50*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2afa8*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x2a2aff8*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x2a2b048*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x2a2b098*/ byte GetStaticByteField(nint clazz, nint fieldID);
        static /*0x2a2b0e8*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x2a2b138*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x2a2b188*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x2a2b1d8*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x2a2b228*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x2a2b278*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x2a2b2c8*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x2a2b318*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x2a2b370*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x2a2b3c8*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x2a2b420*/ void SetStaticByteField(nint clazz, nint fieldID, byte val);
        static /*0x2a2b478*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x2a2b4d0*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x2a2b528*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x2a2b580*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x2a2b5d8*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x2a2b630*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x2a2b690*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x2a2b6f0*/ nint ToBooleanArray(bool[] array);
        static /*0x2a2b730*/ nint ToByteArray(byte[] array);
        static /*0x2a2b770*/ nint ToSByteArray(sbyte[] array);
        static /*0x2a2b7b0*/ nint ToCharArray(char[] array);
        static /*0x2a2b7f0*/ nint ToShortArray(short[] array);
        static /*0x2a2b830*/ nint ToIntArray(int[] array);
        static /*0x2a2b870*/ nint ToLongArray(long[] array);
        static /*0x2a2b8b0*/ nint ToFloatArray(float[] array);
        static /*0x2a2b8f0*/ nint ToDoubleArray(double[] array);
        static /*0x2a2b930*/ nint ToObjectArray(nint[] array, nint arrayClass);
        static /*0x2a2b980*/ nint ToObjectArray(nint[] array);
        static /*0x2a2b9e4*/ bool[] FromBooleanArray(nint array);
        static /*0x2a2ba24*/ byte[] FromByteArray(nint array);
        static /*0x2a2ba64*/ sbyte[] FromSByteArray(nint array);
        static /*0x2a2baa4*/ char[] FromCharArray(nint array);
        static /*0x2a2bae4*/ short[] FromShortArray(nint array);
        static /*0x2a2bb24*/ int[] FromIntArray(nint array);
        static /*0x2a2bb64*/ long[] FromLongArray(nint array);
        static /*0x2a2bba4*/ float[] FromFloatArray(nint array);
        static /*0x2a2bbe4*/ double[] FromDoubleArray(nint array);
        static /*0x2a2bc24*/ nint[] FromObjectArray(nint array);
        static /*0x2a2bc64*/ int GetArrayLength(nint array);
        static /*0x2a2bca4*/ nint NewBooleanArray(int size);
        static /*0x2a2bce4*/ nint NewByteArray(int size);
        static /*0x2a2bd24*/ nint NewSByteArray(int size);
        static /*0x2a2bd64*/ nint NewCharArray(int size);
        static /*0x2a2bda4*/ nint NewShortArray(int size);
        static /*0x2a2bde4*/ nint NewIntArray(int size);
        static /*0x2a2be24*/ nint NewLongArray(int size);
        static /*0x2a2be64*/ nint NewFloatArray(int size);
        static /*0x2a2bea4*/ nint NewDoubleArray(int size);
        static /*0x2a2bee4*/ nint NewObjectArray(int size, nint clazz, nint obj);
        static /*0x2a2bf3c*/ bool GetBooleanArrayElement(nint array, int index);
        static /*0x2a2bf8c*/ byte GetByteArrayElement(nint array, int index);
        static /*0x2a2bfdc*/ sbyte GetSByteArrayElement(nint array, int index);
        static /*0x2a2c02c*/ char GetCharArrayElement(nint array, int index);
        static /*0x2a2c07c*/ short GetShortArrayElement(nint array, int index);
        static /*0x2a2c0cc*/ int GetIntArrayElement(nint array, int index);
        static /*0x2a2c11c*/ long GetLongArrayElement(nint array, int index);
        static /*0x2a2c16c*/ float GetFloatArrayElement(nint array, int index);
        static /*0x2a2c1bc*/ double GetDoubleArrayElement(nint array, int index);
        static /*0x2a2c20c*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x2a2c25c*/ void SetBooleanArrayElement(nint array, int index, byte val);
        static /*0x2a2c2b8*/ void SetBooleanArrayElement(nint array, int index, bool val);
        static /*0x2a2c310*/ void SetByteArrayElement(nint array, int index, sbyte val);
        static /*0x2a2c368*/ void SetSByteArrayElement(nint array, int index, sbyte val);
        static /*0x2a2c3c0*/ void SetCharArrayElement(nint array, int index, char val);
        static /*0x2a2c418*/ void SetShortArrayElement(nint array, int index, short val);
        static /*0x2a2c470*/ void SetIntArrayElement(nint array, int index, int val);
        static /*0x2a2c4c8*/ void SetLongArrayElement(nint array, int index, long val);
        static /*0x2a2c520*/ void SetFloatArrayElement(nint array, int index, float val);
        static /*0x2a2c580*/ void SetDoubleArrayElement(nint array, int index, double val);
        static /*0x2a2c5e0*/ void SetObjectArrayElement(nint array, int index, nint obj);
    }

    class AndroidJNISafe
    {
        static /*0x2a2f164*/ void CheckException();
        static /*0x2a2f578*/ void DeleteGlobalRef(nint globalref);
        static /*0x2a2f5f8*/ void DeleteWeakGlobalRef(nint globalref);
        static /*0x2a2f4f8*/ void DeleteLocalRef(nint localref);
        static /*0x2a2f678*/ nint NewString(string chars);
        static /*0x2a2f6f4*/ string GetStringChars(nint str);
        static /*0x2a2f770*/ nint GetObjectClass(nint ptr);
        static /*0x2a2f7ec*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x2a2f880*/ nint GetMethodID(nint obj, string name, string sig);
        static /*0x2a2f914*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x2a2f9a8*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x2a2fa3c*/ nint FromReflectedMethod(nint refMethod);
        static /*0x2a2fab8*/ nint FindClass(string name);
        static /*0x2a2fb34*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a2fbc8*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x2a2fc60*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x2a2fcf8*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x2a2fd90*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x2a2fe34*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x2a2fed8*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x2a2ff70*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x2a30008*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x2a300a0*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x2a30138*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x2a301d0*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x2a3025c*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x2a302e8*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x2a30374*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x2a3040c*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x2a304a4*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x2a30530*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x2a305bc*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x2a30648*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x2a306d4*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x2a30760*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a307f8*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a3088c*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30920*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a309b4*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30a54*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30af4*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30b88*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30c1c*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30cb0*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30d44*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a30dd8*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x2a30e70*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x2a30f08*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x2a30fa0*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x2a31044*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x2a310e8*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x2a31180*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x2a31218*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x2a312b0*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x2a31348*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x2a313e0*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x2a3146c*/ string GetStringField(nint obj, nint fieldID);
        static /*0x2a314f8*/ char GetCharField(nint obj, nint fieldID);
        static /*0x2a31584*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x2a3161c*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x2a316b4*/ long GetLongField(nint obj, nint fieldID);
        static /*0x2a31740*/ short GetShortField(nint obj, nint fieldID);
        static /*0x2a317cc*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x2a31858*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x2a318e4*/ int GetIntField(nint obj, nint fieldID);
        static /*0x2a31970*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31a08*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31a9c*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31b30*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31bc4*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31c64*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31d04*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31d98*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31e2c*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31ec0*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31f54*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x2a31fe8*/ char[] FromCharArray(nint array);
        static /*0x2a32064*/ double[] FromDoubleArray(nint array);
        static /*0x2a320e0*/ float[] FromFloatArray(nint array);
        static /*0x2a3215c*/ long[] FromLongArray(nint array);
        static /*0x2a321d8*/ short[] FromShortArray(nint array);
        static /*0x2a32254*/ byte[] FromByteArray(nint array);
        static /*0x2a322d0*/ sbyte[] FromSByteArray(nint array);
        static /*0x2a3234c*/ bool[] FromBooleanArray(nint array);
        static /*0x2a323c8*/ int[] FromIntArray(nint array);
        static /*0x2a32444*/ nint ToObjectArray(nint[] array, nint type);
        static /*0x2a324d0*/ nint ToCharArray(char[] array);
        static /*0x2a3254c*/ nint ToDoubleArray(double[] array);
        static /*0x2a325c8*/ nint ToFloatArray(float[] array);
        static /*0x2a32644*/ nint ToLongArray(long[] array);
        static /*0x2a326c0*/ nint ToShortArray(short[] array);
        static /*0x2a3273c*/ nint ToByteArray(byte[] array);
        static /*0x2a327b8*/ nint ToSByteArray(sbyte[] array);
        static /*0x2a32834*/ nint ToBooleanArray(bool[] array);
        static /*0x2a328b0*/ nint ToIntArray(int[] array);
        static /*0x2a3292c*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x2a329b8*/ int GetArrayLength(nint array);
    }

    class AndroidJavaRunnable : System.MulticastDelegate
    {
        /*0x2a35fa8*/ AndroidJavaRunnable(object object, nint method);
        /*0x2a36008*/ void Invoke();
        /*0x2a36214*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
        /*0x2a36240*/ void EndInvoke(System.IAsyncResult result);
    }

    class AndroidJavaException : System.Exception
    {
        /*0x88*/ string mJavaStackTrace;

        /*0x2a2f478*/ AndroidJavaException(string message, string javaStackTrace);
        /*0x2a32d8c*/ string get_StackTrace();
    }

    class GlobalJavaObjectRef
    {
        /*0x10*/ bool m_disposed;
        /*0x18*/ nint m_jobject;

        static /*0x2a33a28*/ nint op_Implicit(UnityEngine.GlobalJavaObjectRef obj);
        /*0x2a32bcc*/ GlobalJavaObjectRef(nint jobject);
        /*0x2a36e9c*/ void Finalize();
        /*0x2a33c00*/ void Dispose();
    }

    class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ UnityEngine.AndroidJavaRunnable mRunnable;

        /*0x2a3624c*/ AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable);
        /*0x2a362d8*/ void run();
    }

    class AndroidJavaProxy
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        static /*0x8*/ nint s_HashCodeMethodID;
        /*0x10*/ UnityEngine.AndroidJavaClass javaInterface;
        /*0x18*/ nint proxyObject;

        static /*0x2a35eb4*/ AndroidJavaProxy();
        /*0x2a33de4*/ AndroidJavaProxy(string javaInterface);
        /*0x2a33e50*/ AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface);
        /*0x2a33eac*/ void Finalize();
        /*0x2a33f18*/ UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args);
        /*0x2a35290*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs);
        /*0x2a35c90*/ bool equals(UnityEngine.AndroidJavaObject obj);
        /*0x2a35d18*/ int hashCode();
        /*0x2a35ddc*/ string toString();
        /*0x2a35e44*/ UnityEngine.AndroidJavaObject GetProxyObject();
        /*0x2a35050*/ nint GetRawProxy();
    }

    class AndroidJavaObject : System.IDisposable
    {
        static /*0x0*/ bool enableDebugPrints;
        /*0x10*/ UnityEngine.GlobalJavaObjectRef m_jobject;
        /*0x18*/ UnityEngine.GlobalJavaObjectRef m_jclass;

        static /*0x2a33d98*/ AndroidJavaObject();
        static /*0x2a33c70*/ UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject);
        static /*0x2a33d04*/ UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass);
        static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(nint jobject);
        /*0x2a32dbc*/ AndroidJavaObject(string className, string[] args);
        /*0x2a33048*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaObject[] args);
        /*0x2a33108*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaClass[] args);
        /*0x2a331c8*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaProxy[] args);
        /*0x2a33288*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaRunnable[] args);
        /*0x2a33348*/ AndroidJavaObject(string className, object[] args);
        /*0x2a33a40*/ AndroidJavaObject(nint jobject);
        /*0x2a32a34*/ AndroidJavaObject();
        /*0x2a33388*/ void Dispose();
        void Call<T>(string methodName, T[] args);
        /*0x2a33400*/ void Call(string methodName, object[] args);
        void CallStatic<T>(string methodName, T[] args);
        /*0x2a33514*/ void CallStatic(string methodName, object[] args);
        FieldType Get<FieldType>(string fieldName);
        void Set<FieldType>(string fieldName, FieldType val);
        FieldType GetStatic<FieldType>(string fieldName);
        void SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x2a33628*/ nint GetRawObject();
        /*0x2a33660*/ nint GetRawClass();
        ReturnType Call<ReturnType, T>(string methodName, T[] args);
        ReturnType Call<ReturnType>(string methodName, object[] args);
        ReturnType CallStatic<ReturnType, T>(string methodName, T[] args);
        ReturnType CallStatic<ReturnType>(string methodName, object[] args);
        /*0x2a32b20*/ void DebugPrint(string msg);
        /*0x2a33698*/ void DebugPrint(string call, string methodName, string signature, object[] args);
        /*0x2a32e7c*/ void _AndroidJavaObject(string className, object[] args);
        /*0x2a33b50*/ void Finalize();
        /*0x2a33bc4*/ void Dispose(bool disposing);
        /*0x2a33404*/ void _Call(string methodName, object[] args);
        ReturnType _Call<ReturnType>(string methodName, object[] args);
        FieldType _Get<FieldType>(string fieldName);
        void _Set<FieldType>(string fieldName, FieldType val);
        /*0x2a33518*/ void _CallStatic(string methodName, object[] args);
        ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
        FieldType _GetStatic<FieldType>(string fieldName);
        void _SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x2a33644*/ nint _GetRawObject();
        /*0x2a3367c*/ nint _GetRawClass();
    }

    class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        /*0x2a29484*/ AndroidJavaClass(string className);
        /*0x2a32c6c*/ AndroidJavaClass(nint jclass);
        /*0x2a32a3c*/ void _AndroidJavaClass(string className);
    }

    class AndroidReflection
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass;
        static /*0x8*/ nint s_ReflectionHelperGetConstructorID;
        static /*0x10*/ nint s_ReflectionHelperGetMethodID;
        static /*0x18*/ nint s_ReflectionHelperGetFieldID;
        static /*0x20*/ nint s_ReflectionHelperGetFieldSignature;
        static /*0x28*/ nint s_ReflectionHelperNewProxyInstance;
        static /*0x30*/ nint s_ReflectionHelperSetNativeExceptionOnProxy;
        static /*0x38*/ nint s_FieldGetDeclaringClass;

        static /*0x2a36c0c*/ AndroidReflection();
        static /*0x2a362f0*/ bool IsPrimitive(System.Type t);
        static /*0x2a36308*/ bool IsAssignableFrom(System.Type t, System.Type from);
        static /*0x2a36328*/ nint GetStaticMethodID(string clazz, string methodName, string signature);
        static /*0x2a363a4*/ nint GetMethodID(string clazz, string methodName, string signature);
        static /*0x2a36420*/ nint GetConstructorMember(nint jclass, string signature);
        static /*0x2a365cc*/ nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x2a367e4*/ nint GetFieldMember(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x2a369fc*/ nint GetFieldClass(nint field);
        static /*0x2a36a6c*/ string GetFieldSignature(nint field);
        static /*0x2a36b28*/ nint NewProxyInstance(nint delegateHandle, nint interfaze);
        static /*0x2a3516c*/ void SetNativeExceptionOnProxy(nint proxy, System.Exception e, bool methodNotFound);
    }

    class _AndroidJNIHelper
    {
        static /*0x2a2cfa8*/ nint CreateJavaProxy(nint delegateHandle, UnityEngine.AndroidJavaProxy proxy);
        static /*0x2a2ce78*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x2a375fc*/ nint InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, nint jmethodName, nint jargs);
        static /*0x2a2d9f8*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x2a37a28*/ object UnboxArray(UnityEngine.AndroidJavaObject obj);
        static /*0x2a35408*/ object Unbox(UnityEngine.AndroidJavaObject obj);
        static /*0x2a34650*/ UnityEngine.AndroidJavaObject Box(object obj);
        static /*0x2a2dfe0*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x2a2d038*/ nint ConvertToJNIArray(System.Array array);
        static ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x2a2e180*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x2a2e1f0*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetFieldID<ReturnType>(nint jclass, string fieldName, bool isStatic);
        static /*0x2a2c6fc*/ nint GetConstructorID(nint jclass, string signature);
        static /*0x2a2c930*/ nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x2a380d0*/ nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x2a2cb74*/ nint GetFieldID(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x2a2e238*/ string GetSignature(object obj);
        static /*0x2a2f064*/ string GetSignature(object[] args);
        static string GetSignature<ReturnType>(object[] args);
        /*0x2a381c8*/ _AndroidJNIHelper();
    }

    namespace Android
    {
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

            /*0x2a290ec*/ AndroidAssetPackInfo(string name, UnityEngine.Android.AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackState
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x1c*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            /*0x2a29154*/ AndroidAssetPackState(string name, UnityEngine.Android.AndroidAssetPackStatus status, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackUseMobileDataRequestResult
        {
            /*0x10*/ bool <allowed>k__BackingField;

            /*0x2a29194*/ AndroidAssetPackUseMobileDataRequestResult(bool allowed);
        }

        class AndroidAssetPacks
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;
            static /*0x8*/ bool s_ApiMissing;

            static /*0x2a291c4*/ UnityEngine.AndroidJavaObject GetAssetPackManager();

            class AssetPackManagerDownloadStatusCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackInfo> m_Callback;
                /*0x28*/ string[] m_AssetPacks;

                /*0x2a381d0*/ void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode);
            }

            class AssetPackManagerMobileDataConfirmationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> m_Callback;

                /*0x2a382ec*/ void onMobileDataConfirmationResult(bool allowed);
            }

            class AssetPackManagerStatusQueryCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> m_Callback;
                /*0x28*/ System.Collections.Generic.List<string> m_AssetPackNames;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Android.AndroidAssetPackState> m_States;
                /*0x38*/ long m_Size;

                /*0x2a38390*/ void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes);
            }
        }

        class PermissionCallbacks : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<string> PermissionGranted;
            /*0x28*/ System.Action<string> PermissionDenied;
            /*0x30*/ System.Action<string> PermissionDeniedAndDontAskAgain;

            /*0x2a374a4*/ void onPermissionGranted(string permissionName);
            /*0x2a37514*/ void onPermissionDenied(string permissionName);
            /*0x2a37584*/ void onPermissionDeniedAndDontAskAgain(string permissionName);
        }

        struct Permission
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject m_UnityPermissions;
            static /*0x8*/ UnityEngine.AndroidJavaObject m_Activity;

            static /*0x2a36f04*/ UnityEngine.AndroidJavaObject GetActivity();
            static /*0x2a370d8*/ UnityEngine.AndroidJavaObject GetUnityPermissions();
            static /*0x2a3717c*/ bool HasUserAuthorizedPermission(string permission);
            static /*0x2a372a8*/ void RequestUserPermission(string permission);
            static /*0x2a37354*/ void RequestUserPermissions(string[] permissions, UnityEngine.Android.PermissionCallbacks callbacks);
        }
    }
}
