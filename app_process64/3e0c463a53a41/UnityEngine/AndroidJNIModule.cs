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
        static /*0x7dc2e00*/ bool get_debug();
        static /*0x7dc2e28*/ void set_debug(bool value);
        static /*0x7dc2e64*/ nint GetConstructorID(nint javaClass);
        static /*0x7dc2eac*/ nint GetConstructorID(nint javaClass, string signature);
        static /*0x7dc3108*/ nint GetMethodID(nint javaClass, string methodName);
        static /*0x7dc31e0*/ nint GetMethodID(nint javaClass, string methodName, string signature);
        static /*0x7dc3164*/ nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic);
        static /*0x7dc3410*/ nint GetFieldID(nint javaClass, string fieldName);
        static /*0x7dc34e8*/ nint GetFieldID(nint javaClass, string fieldName, string signature);
        static /*0x7dc346c*/ nint GetFieldID(nint javaClass, string fieldName, string signature, bool isStatic);
        static /*0x7dc37b8*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x7dc3864*/ nint CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy);
        static /*0x7dc3a58*/ nint ConvertToJNIArray(System.Array array);
        static /*0x7dc47a0*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x7dc4d50*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x7dc4e7c*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x7dc5078*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x7dc50e4*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x7dc51b4*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x7dc52b4*/ string GetSignature(object obj);
        static /*0x7dc6220*/ string GetSignature(object[] args);
        static /*0x3907c14*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x3907c14*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x3907c14*/ nint GetFieldID<FieldType>(nint jclass, string fieldName, bool isStatic);
        static /*0x382eaf0*/ string GetSignature<ReturnType>(object[] args);
        static /*0x7dc63cc*/ nint Box(UnityEngine.jvalue val, string boxedClass, string signature);
        static /*0x7dc667c*/ nint Box(sbyte value);
        static /*0x7dc66e4*/ nint Box(short value);
        static /*0x7dc674c*/ nint Box(int value);
        static /*0x7dc67b4*/ nint Box(long value);
        static /*0x7dc681c*/ nint Box(float value);
        static /*0x7dc6884*/ nint Box(double value);
        static /*0x7dc68ec*/ nint Box(char value);
        static /*0x7dc6954*/ nint Box(bool value);
        static /*0x7dc69bc*/ nint GetUnboxMethod(nint obj, string methodName, string signature);
        static /*0x7dc6bc8*/ void Unbox(nint obj, ref sbyte value);
        static /*0x7dc6cc8*/ void Unbox(nint obj, ref short value);
        static /*0x7dc6dc8*/ void Unbox(nint obj, ref int value);
        static /*0x7dc6ec8*/ void Unbox(nint obj, ref long value);
        static /*0x7dc6fc8*/ void Unbox(nint obj, ref float value);
        static /*0x7dc70d4*/ void Unbox(nint obj, ref double value);
        static /*0x7dc71e0*/ void Unbox(nint obj, ref char value);
        static /*0x7dc72e0*/ void Unbox(nint obj, ref bool value);
    }

    class AndroidJNI
    {
        static /*0x7dc73e4*/ void ReleaseStringChars(UnityEngine.AndroidJNI.JStringBinding str);
        static /*0x7dc745c*/ nint GetJavaVM();
        static /*0x7dc7484*/ int AttachCurrentThread();
        static /*0x7dc74ac*/ int DetachCurrentThread();
        static /*0x7dc74d4*/ void InvokeAction(System.Action action);
        static /*0x7dc74f8*/ void InvokeAttached(System.Action action);
        static /*0x7dc7534*/ int GetVersion();
        static /*0x7dc755c*/ nint FindClass(string name);
        static /*0x7dc7708*/ nint FromReflectedMethod(nint refMethod);
        static /*0x7dc7744*/ nint FromReflectedField(nint refField);
        static /*0x7dc7780*/ nint ToReflectedMethod(nint clazz, nint methodID, bool isStatic);
        static /*0x7dc77d4*/ nint ToReflectedField(nint clazz, nint fieldID, bool isStatic);
        static /*0x7dc7828*/ nint GetSuperclass(nint clazz);
        static /*0x7dc7864*/ bool IsAssignableFrom(nint clazz1, nint clazz2);
        static /*0x7dc78a8*/ int Throw(nint obj);
        static /*0x7dc78e4*/ int ThrowNew(nint clazz, string message);
        static /*0x7dc7aa0*/ nint ExceptionOccurred();
        static /*0x7dc7ac8*/ void ExceptionDescribe();
        static /*0x7dc7af0*/ void ExceptionClear();
        static /*0x7dc7b18*/ void FatalError(string message);
        static /*0x7dc7cbc*/ int PushLocalFrame(int capacity);
        static /*0x7dc7cf8*/ nint PopLocalFrame(nint ptr);
        static /*0x7dc7d34*/ nint NewGlobalRef(nint obj);
        static /*0x7dc7d70*/ void DeleteGlobalRef(nint obj);
        static /*0x7dc7dac*/ void QueueDeleteGlobalRef(nint obj);
        static /*0x7dc7de8*/ uint GetQueueGlobalRefsCount();
        static /*0x7dc7e10*/ nint NewWeakGlobalRef(nint obj);
        static /*0x7dc7e4c*/ void DeleteWeakGlobalRef(nint obj);
        static /*0x7dc7e88*/ nint NewLocalRef(nint obj);
        static /*0x7dc7ec4*/ void DeleteLocalRef(nint obj);
        static /*0x7dc7f00*/ bool IsSameObject(nint obj1, nint obj2);
        static /*0x7dc7f44*/ int EnsureLocalCapacity(int capacity);
        static /*0x7dc7f80*/ nint AllocObject(nint clazz);
        static /*0x7dc7fbc*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc8024*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc80bc*/ nint NewObjectA(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc8110*/ nint GetObjectClass(nint obj);
        static /*0x7dc814c*/ bool IsInstanceOf(nint obj, nint clazz);
        static /*0x7dc8190*/ nint GetMethodID(nint clazz, string name, string sig);
        static /*0x7dc842c*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x7dc86c8*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x7dc8964*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x7dc8c00*/ nint NewString(string chars);
        static /*0x7dc8c04*/ nint NewStringFromStr(string chars);
        static /*0x7dc8db0*/ nint NewString(char[] chars);
        static /*0x7dc8eb8*/ nint NewStringUTF(string bytes);
        static /*0x7dc9064*/ string GetStringChars(nint str);
        static /*0x7dc9140*/ UnityEngine.AndroidJNI.JStringBinding GetStringCharsInternal(nint str);
        static /*0x7dc9244*/ int GetStringLength(nint str);
        static /*0x7dc9280*/ int GetStringUTFLength(nint str);
        static /*0x7dc92bc*/ string GetStringUTFChars(nint str);
        static /*0x7dc93bc*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9424*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc9498*/ string CallStringMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc958c*/ UnityEngine.AndroidJNI.JStringBinding CallStringMethodUnsafeInternal(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc9668*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc96d0*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc9768*/ nint CallObjectMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc97bc*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9824*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc98bc*/ int CallIntMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc9910*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9978*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc9a14*/ bool CallBooleanMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc9a68*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9ad0*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc9b68*/ short CallShortMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc9bbc*/ byte CallByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9bc0*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9c28*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc9cc0*/ sbyte CallSByteMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc9d14*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9d7c*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc9e14*/ char CallCharMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc9e68*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc9ed0*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc9f68*/ float CallFloatMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dc9fbc*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dca024*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dca0bc*/ double CallDoubleMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dca110*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dca178*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dca210*/ long CallLongMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dca264*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dca2cc*/ void CallVoidMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dca364*/ void CallVoidMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dca3b8*/ string GetStringField(nint obj, nint fieldID);
        static /*0x7dca49c*/ UnityEngine.AndroidJNI.JStringBinding GetStringFieldInternal(nint obj, nint fieldID);
        static /*0x7dca560*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x7dca5a4*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x7dca5e8*/ byte GetByteField(nint obj, nint fieldID);
        static /*0x7dca62c*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x7dca670*/ char GetCharField(nint obj, nint fieldID);
        static /*0x7dca6b4*/ short GetShortField(nint obj, nint fieldID);
        static /*0x7dca6f8*/ int GetIntField(nint obj, nint fieldID);
        static /*0x7dca73c*/ long GetLongField(nint obj, nint fieldID);
        static /*0x7dca780*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x7dca7c4*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x7dca808*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x7dca9dc*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x7dcaa30*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x7dcaa84*/ void SetByteField(nint obj, nint fieldID, byte val);
        static /*0x7dcaad8*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x7dcab2c*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x7dcab80*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x7dcabd4*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x7dcac28*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x7dcac7c*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x7dcacd0*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x7dcad24*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcad8c*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcae00*/ string CallStaticStringMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcaef4*/ UnityEngine.AndroidJNI.JStringBinding CallStaticStringMethodUnsafeInternal(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcafd0*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb038*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcb0d0*/ nint CallStaticObjectMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcb124*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb18c*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcb224*/ int CallStaticIntMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcb278*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb2e0*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcb37c*/ bool CallStaticBooleanMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcb3d0*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb438*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcb4d0*/ short CallStaticShortMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcb524*/ byte CallStaticByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb528*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb590*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcb628*/ sbyte CallStaticSByteMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcb67c*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb6e4*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcb77c*/ char CallStaticCharMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcb7d0*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb838*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcb8d0*/ float CallStaticFloatMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcb924*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcb98c*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcba24*/ double CallStaticDoubleMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcba78*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcbae0*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcbb78*/ long CallStaticLongMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcbbcc*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcbc34*/ void CallStaticVoidMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcbccc*/ void CallStaticVoidMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x7dcbd20*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x7dcbe04*/ UnityEngine.AndroidJNI.JStringBinding GetStaticStringFieldInternal(nint clazz, nint fieldID);
        static /*0x7dcbec8*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x7dcbf0c*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x7dcbf50*/ byte GetStaticByteField(nint clazz, nint fieldID);
        static /*0x7dcbf94*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x7dcbfd8*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x7dcc01c*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x7dcc060*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x7dcc0a4*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x7dcc0e8*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x7dcc12c*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x7dcc170*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x7dcc344*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x7dcc398*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x7dcc3ec*/ void SetStaticByteField(nint clazz, nint fieldID, byte val);
        static /*0x7dcc440*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x7dcc494*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x7dcc4e8*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x7dcc53c*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x7dcc590*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x7dcc5e4*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x7dcc638*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x7dcc68c*/ nint ToBooleanArray(bool[] array);
        static /*0x7dcc794*/ nint ToByteArray(byte[] array);
        static /*0x7dcc89c*/ nint ToSByteArray(sbyte[] array);
        static /*0x7dcc8f0*/ nint ToSByteArray(sbyte* array, int length);
        static /*0x7dcc934*/ nint ToCharArray(char[] array);
        static /*0x7dcc988*/ nint ToCharArray(char* array, int length);
        static /*0x7dcc9cc*/ nint ToShortArray(short[] array);
        static /*0x7dcca20*/ nint ToShortArray(short* array, int length);
        static /*0x7dcca64*/ nint ToIntArray(int[] array);
        static /*0x7dccab8*/ nint ToIntArray(int* array, int length);
        static /*0x7dccafc*/ nint ToLongArray(long[] array);
        static /*0x7dccb50*/ nint ToLongArray(long* array, int length);
        static /*0x7dccb94*/ nint ToFloatArray(float[] array);
        static /*0x7dccbe8*/ nint ToFloatArray(float* array, int length);
        static /*0x7dccc2c*/ nint ToDoubleArray(double[] array);
        static /*0x7dccc80*/ nint ToDoubleArray(double* array, int length);
        static /*0x7dcccc4*/ nint ToObjectArray(nint* array, int length, nint arrayClass);
        static /*0x7dccd18*/ nint ToObjectArray(nint[] array, nint arrayClass);
        static /*0x7dccd7c*/ nint ToObjectArray(nint[] array);
        static /*0x7dccd84*/ bool[] FromBooleanArray(nint array);
        static /*0x7dccec4*/ byte[] FromByteArray(nint array);
        static /*0x7dcd004*/ sbyte[] FromSByteArray(nint array);
        static /*0x7dcd040*/ char[] FromCharArray(nint array);
        static /*0x7dcd07c*/ short[] FromShortArray(nint array);
        static /*0x7dcd0b8*/ int[] FromIntArray(nint array);
        static /*0x7dcd0f4*/ long[] FromLongArray(nint array);
        static /*0x7dcd130*/ float[] FromFloatArray(nint array);
        static /*0x7dcd16c*/ double[] FromDoubleArray(nint array);
        static /*0x7dcd1a8*/ nint[] FromObjectArray(nint array);
        static /*0x7dcd2e8*/ int GetArrayLength(nint array);
        static /*0x7dcd324*/ nint NewBooleanArray(int size);
        static /*0x7dcd360*/ nint NewByteArray(int size);
        static /*0x7dcd39c*/ nint NewSByteArray(int size);
        static /*0x7dcd3d8*/ nint NewCharArray(int size);
        static /*0x7dcd414*/ nint NewShortArray(int size);
        static /*0x7dcd450*/ nint NewIntArray(int size);
        static /*0x7dcd48c*/ nint NewLongArray(int size);
        static /*0x7dcd4c8*/ nint NewFloatArray(int size);
        static /*0x7dcd504*/ nint NewDoubleArray(int size);
        static /*0x7dcd540*/ nint NewObjectArray(int size, nint clazz, nint obj);
        static /*0x7dcd594*/ bool GetBooleanArrayElement(nint array, int index);
        static /*0x7dcd5d8*/ byte GetByteArrayElement(nint array, int index);
        static /*0x7dcd61c*/ sbyte GetSByteArrayElement(nint array, int index);
        static /*0x7dcd660*/ char GetCharArrayElement(nint array, int index);
        static /*0x7dcd6a4*/ short GetShortArrayElement(nint array, int index);
        static /*0x7dcd6e8*/ int GetIntArrayElement(nint array, int index);
        static /*0x7dcd72c*/ long GetLongArrayElement(nint array, int index);
        static /*0x7dcd770*/ float GetFloatArrayElement(nint array, int index);
        static /*0x7dcd7b4*/ double GetDoubleArrayElement(nint array, int index);
        static /*0x7dcd7f8*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x7dcd83c*/ void SetBooleanArrayElement(nint array, int index, byte val);
        static /*0x7dcd894*/ void SetBooleanArrayElement(nint array, int index, bool val);
        static /*0x7dcd8e8*/ void SetByteArrayElement(nint array, int index, sbyte val);
        static /*0x7dcd93c*/ void SetSByteArrayElement(nint array, int index, sbyte val);
        static /*0x7dcd990*/ void SetCharArrayElement(nint array, int index, char val);
        static /*0x7dcd9e4*/ void SetShortArrayElement(nint array, int index, short val);
        static /*0x7dcda38*/ void SetIntArrayElement(nint array, int index, int val);
        static /*0x7dcda8c*/ void SetLongArrayElement(nint array, int index, long val);
        static /*0x7dcdae0*/ void SetFloatArrayElement(nint array, int index, float val);
        static /*0x7dcdb34*/ void SetDoubleArrayElement(nint array, int index, double val);
        static /*0x7dcdb88*/ void SetObjectArrayElement(nint array, int index, nint obj);
        static /*0x7dcdbdc*/ nint NewDirectByteBuffer(byte* buffer, long capacity);
        static /*0x7dcdc20*/ nint NewDirectByteBuffer(Unity.Collections.NativeArray<byte> buffer);
        static /*0x7dcdc78*/ nint NewDirectByteBuffer(Unity.Collections.NativeArray<sbyte> buffer);
        static /*0x3907c14*/ nint NewDirectByteBufferFromNativeArray<T>(Unity.Collections.NativeArray<T> buffer);
        static /*0x7dcdcd0*/ sbyte* GetDirectBufferAddress(nint buffer);
        static /*0x7dcdd0c*/ long GetDirectBufferCapacity(nint buffer);
        static /*0x3907c14*/ Unity.Collections.NativeArray<T> GetDirectBuffer<T>(nint buffer);
        static /*0x7dcdd48*/ Unity.Collections.NativeArray<byte> GetDirectByteBuffer(nint buffer);
        static /*0x7dcdd90*/ Unity.Collections.NativeArray<sbyte> GetDirectSByteBuffer(nint buffer);
        static /*0x7dcddd8*/ int RegisterNatives(nint clazz, UnityEngine.JNINativeMethod[] methods);
        static /*0x7dcdf10*/ nint RegisterNativesAllocate(int length);
        static /*0x7dcdf4c*/ void RegisterNativesSet(nint natives, int idx, string name, string signature, nint fnPtr);
        static /*0x7dce1a4*/ int RegisterNativesAndFree(nint clazz, nint natives, int n);
        static /*0x7dce264*/ int UnregisterNatives(nint clazz);
        static /*0x7dc7420*/ void ReleaseStringChars_Injected(ref UnityEngine.AndroidJNI.JStringBinding str);
        static /*0x7dc76cc*/ nint FindClass_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dc7a5c*/ int ThrowNew_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper message);
        static /*0x7dc7c80*/ void FatalError_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper message);
        static /*0x7dc83d8*/ nint GetMethodID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7dc8674*/ nint GetFieldID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7dc8910*/ nint GetStaticMethodID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7dc8bac*/ nint GetStaticFieldID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x7dc8d74*/ nint NewStringFromStr_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper chars);
        static /*0x7dc8e7c*/ nint NewString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper chars);
        static /*0x7dc9028*/ nint NewStringUTF_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper bytes);
        static /*0x7dc9200*/ void GetStringCharsInternal_Injected(nint str, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7dc9378*/ void GetStringUTFChars_Injected(nint str, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dc960c*/ void CallStringMethodUnsafeInternal_Injected(nint obj, nint methodID, UnityEngine.jvalue* args, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7dca50c*/ void GetStringFieldInternal_Injected(nint obj, nint fieldID, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7dca988*/ void SetStringField_Injected(nint obj, nint fieldID, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x7dcaf74*/ void CallStaticStringMethodUnsafeInternal_Injected(nint clazz, nint methodID, UnityEngine.jvalue* args, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7dcbe74*/ void GetStaticStringFieldInternal_Injected(nint clazz, nint fieldID, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x7dcc2f0*/ void SetStaticStringField_Injected(nint clazz, nint fieldID, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x7dcc758*/ nint ToBooleanArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper array);
        static /*0x7dcc860*/ nint ToByteArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper array);
        static /*0x7dcce80*/ void FromBooleanArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7dccfc0*/ void FromByteArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7dcd2a4*/ void FromObjectArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7dce1f8*/ void RegisterNativesSet_Injected(nint natives, int idx, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper signature, nint fnPtr);

        struct JStringBinding : System.IDisposable
        {
            /*0x10*/ nint javaString;
            /*0x18*/ nint chars;
            /*0x20*/ int length;
            /*0x24*/ bool ownsRef;

            /*0x7dc91a8*/ string ToString();
            /*0x7dce2a0*/ void Dispose();
        }
    }

    class AndroidJNISafe
    {
        static /*0x7dce2f8*/ void CheckException();
        static /*0x7dce66c*/ void QueueDeleteGlobalRef(nint globalref);
        static /*0x7dce6b0*/ void DeleteWeakGlobalRef(nint globalref);
        static /*0x7dce6f4*/ void DeleteLocalRef(nint localref);
        static /*0x7dce738*/ nint NewString(string chars);
        static /*0x7dce7b0*/ string GetStringChars(nint str);
        static /*0x7dc6ab0*/ nint GetObjectClass(nint ptr);
        static /*0x7dc658c*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x7dc6b50*/ nint GetMethodID(nint obj, string name, string sig);
        static /*0x7dce828*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x7dce8a0*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x7dce918*/ nint FromReflectedMethod(nint refMethod);
        static /*0x7dc6514*/ nint FindClass(string name);
        static /*0x7dce9b8*/ void PushLocalFrame(int capacity);
        static /*0x7dcea08*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcea80*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x7dceb3c*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x7dcebb4*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x7dcec70*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x7dced2c*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x7dcede8*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x7dceea4*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x7dcef60*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x7dcf01c*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x7dcf0d8*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x7dcf194*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x7dcf23c*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x7dcf2b4*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x7dcf35c*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x7dcf410*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x7dcf4c4*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x7dcf56c*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x7dcf614*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x7dcf6bc*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x7dcf764*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x7dcf80c*/ void CallStaticVoidMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcf884*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dc6604*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcf8ec*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dcf954*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcf9cc*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfa44*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfac8*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfb4c*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfbc4*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfc3c*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfcb4*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfd2c*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dcfda4*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x7dcfe60*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x7dcfed8*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x7dcff94*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x7dd0050*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x7dd010c*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x7dd01c8*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x7dd0284*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x7dd0340*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x7dd03fc*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x7dd04b8*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x7dd0560*/ string GetStringField(nint obj, nint fieldID);
        static /*0x7dd05d8*/ char GetCharField(nint obj, nint fieldID);
        static /*0x7dd0680*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x7dd0734*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x7dd07e8*/ long GetLongField(nint obj, nint fieldID);
        static /*0x7dd0890*/ short GetShortField(nint obj, nint fieldID);
        static /*0x7dd0938*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x7dd09e0*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x7dd0a88*/ int GetIntField(nint obj, nint fieldID);
        static /*0x7dd0b30*/ void CallVoidMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dd0ba8*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x7dd0c10*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dd0c88*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc7268*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc715c*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc7050*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc6f50*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc6d50*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc6c50*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc736c*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dc6e50*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x7dd0d00*/ char[] FromCharArray(nint array);
        static /*0x7dd0da0*/ double[] FromDoubleArray(nint array);
        static /*0x7dd0e40*/ float[] FromFloatArray(nint array);
        static /*0x7dd0ee0*/ long[] FromLongArray(nint array);
        static /*0x7dd0f80*/ short[] FromShortArray(nint array);
        static /*0x7dd1020*/ byte[] FromByteArray(nint array);
        static /*0x7dd1098*/ sbyte[] FromSByteArray(nint array);
        static /*0x7dd1138*/ bool[] FromBooleanArray(nint array);
        static /*0x7dd11b0*/ int[] FromIntArray(nint array);
        static /*0x7dd1250*/ nint ToObjectArray(nint[] array, nint type);
        static /*0x7dd12c8*/ nint ToCharArray(char[] array);
        static /*0x7dd1340*/ nint ToDoubleArray(double[] array);
        static /*0x7dd13b8*/ nint ToFloatArray(float[] array);
        static /*0x7dd1430*/ nint ToLongArray(long[] array);
        static /*0x7dd14a8*/ nint ToShortArray(short[] array);
        static /*0x7dd1520*/ nint ToByteArray(byte[] array);
        static /*0x7dd1598*/ nint ToSByteArray(sbyte[] array);
        static /*0x7dd1610*/ nint ToBooleanArray(bool[] array);
        static /*0x7dd1688*/ nint ToIntArray(int[] array);
        static /*0x7dd1700*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x7dd17a8*/ int GetArrayLength(nint array);
    }

    class AndroidJavaRunnable : System.MulticastDelegate
    {
        /*0x7dd1848*/ AndroidJavaRunnable(object object, nint method);
        /*0x7dd18e4*/ void Invoke();
    }

    class AndroidJavaException : System.Exception
    {
        /*0x90*/ string mJavaStackTrace;

        /*0x7dce5f0*/ AndroidJavaException(string message, string javaStackTrace);
        /*0x7dd18f8*/ string get_StackTrace();
    }

    class GlobalJavaObjectRef
    {
        /*0x10*/ bool m_disposed;
        /*0x18*/ nint m_jobject;

        static /*0x7dd1a6c*/ nint op_Implicit(UnityEngine.GlobalJavaObjectRef obj);
        /*0x7dd191c*/ GlobalJavaObjectRef(nint jobject);
        /*0x7dd197c*/ void Finalize();
        /*0x7dd1a10*/ void Dispose();
    }

    class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ UnityEngine.AndroidJavaRunnable mRunnable;

        /*0x7dd1a84*/ AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable);
        /*0x7dd1b94*/ void run();
        /*0x7dd1bb8*/ nint Invoke(string methodName, nint javaArgs);
    }

    class AndroidJavaProxy
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        static /*0x8*/ nint s_HashCodeMethodID;
        /*0x10*/ UnityEngine.AndroidJavaClass javaInterface;
        /*0x18*/ nint proxyObject;

        static /*0x7dd484c*/ AndroidJavaProxy();
        /*0x7dd1b0c*/ AndroidJavaProxy(string javaInterface);
        /*0x7dd2078*/ AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface);
        /*0x7dd20ac*/ void Finalize();
        /*0x7dd216c*/ UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args);
        /*0x7dd373c*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs);
        /*0x7dd1c68*/ nint Invoke(string methodName, nint javaArgs);
        /*0x7dd4604*/ bool equals(UnityEngine.AndroidJavaObject obj);
        /*0x7dd465c*/ int hashCode();
        /*0x7dd47d8*/ string toString();
        /*0x7dd483c*/ UnityEngine.AndroidJavaObject GetProxyObject();
        /*0x7dd471c*/ nint GetRawProxy();
    }

    class AndroidJavaObject : System.IDisposable
    {
        static /*0x0*/ bool enableDebugPrints;
        /*0x10*/ UnityEngine.GlobalJavaObjectRef m_jobject;
        /*0x18*/ UnityEngine.GlobalJavaObjectRef m_jclass;

        static /*0x7dd44d8*/ UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject);
        static /*0x7dd5ca8*/ UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass);
        static /*0x3907c14*/ ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(nint jobject);
        static /*0x3907c14*/ ReturnType FromJavaArray<ReturnType>(nint jobject);
        /*0x7dd4954*/ AndroidJavaObject(string className, string[] args);
        /*0x7dd4b34*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaObject[] args);
        /*0x7dd4bf4*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaClass[] args);
        /*0x7dd4cb4*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaProxy[] args);
        /*0x7dd4d74*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaRunnable[] args);
        /*0x7dd4e34*/ AndroidJavaObject(string className, object[] args);
        /*0x7dd3608*/ AndroidJavaObject(nint jobject);
        /*0x7dd4e68*/ AndroidJavaObject(nint clazz, nint constructorID, object[] args);
        /*0x7dd4a14*/ AndroidJavaObject();
        /*0x7dd446c*/ void Dispose();
        /*0x380d93c*/ void Call<T>(string methodName, T[] args);
        /*0x380d7bc*/ void Call<T>(nint methodID, T[] args);
        /*0x7dd510c*/ void Call(string methodName, object[] args);
        /*0x7dd5150*/ void Call(nint methodID, object[] args);
        /*0x380d93c*/ void CallStatic<T>(string methodName, T[] args);
        /*0x380d7bc*/ void CallStatic<T>(nint methodID, T[] args);
        /*0x7dd5354*/ void CallStatic(string methodName, object[] args);
        /*0x7dd5398*/ void CallStatic(nint methodID, object[] args);
        /*0x3907c14*/ FieldType Get<FieldType>(string fieldName);
        /*0x3907c14*/ FieldType Get<FieldType>(nint fieldID);
        /*0x3907c14*/ void Set<FieldType>(string fieldName, FieldType val);
        /*0x3907c14*/ void Set<FieldType>(nint fieldID, FieldType val);
        /*0x3907c14*/ FieldType GetStatic<FieldType>(string fieldName);
        /*0x3907c14*/ FieldType GetStatic<FieldType>(nint fieldID);
        /*0x3907c14*/ void SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x3907c14*/ void SetStatic<FieldType>(nint fieldID, FieldType val);
        /*0x7dd45ec*/ nint GetRawObject();
        /*0x7dd55b4*/ nint GetRawClass();
        /*0x7dd55ec*/ UnityEngine.AndroidJavaObject CloneReference();
        /*0x3907c14*/ ReturnType Call<ReturnType, T>(string methodName, T[] args);
        /*0x3907c14*/ ReturnType Call<ReturnType, T>(nint methodID, T[] args);
        /*0x3907c14*/ ReturnType Call<ReturnType>(string methodName, object[] args);
        /*0x3907c14*/ ReturnType Call<ReturnType>(nint methodID, object[] args);
        /*0x3907c14*/ ReturnType CallStatic<ReturnType, T>(string methodName, T[] args);
        /*0x3907c14*/ ReturnType CallStatic<ReturnType, T>(nint methodID, T[] args);
        /*0x3907c14*/ ReturnType CallStatic<ReturnType>(string methodName, object[] args);
        /*0x3907c14*/ ReturnType CallStatic<ReturnType>(nint methodID, object[] args);
        /*0x7dd581c*/ void DebugPrint(string msg);
        /*0x7dd58a4*/ void DebugPrint(string call, string methodName, string signature, object[] args);
        /*0x7dd4a1c*/ void _AndroidJavaObject(string className, object[] args);
        /*0x7dd4f00*/ void _AndroidJavaObject(nint constructorID, object[] args);
        /*0x7dd5bac*/ void Finalize();
        /*0x7dd5c4c*/ void Dispose(bool disposing);
        /*0x7dd5110*/ void _Call(string methodName, object[] args);
        /*0x7dd5154*/ void _Call(nint methodID, object[] args);
        /*0x3907c14*/ ReturnType _Call<ReturnType>(string methodName, object[] args);
        /*0x3907c14*/ ReturnType _Call<ReturnType>(nint methodID, object[] args);
        /*0x3907c14*/ FieldType _Get<FieldType>(string fieldName);
        /*0x3907c14*/ FieldType _Get<FieldType>(nint fieldID);
        /*0x3907c14*/ void _Set<FieldType>(string fieldName, FieldType val);
        /*0x3907c14*/ void _Set<FieldType>(nint fieldID, FieldType val);
        /*0x7dd5358*/ void _CallStatic(string methodName, object[] args);
        /*0x7dd539c*/ void _CallStatic(nint methodID, object[] args);
        /*0x3907c14*/ ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
        /*0x3907c14*/ ReturnType _CallStatic<ReturnType>(nint methodID, object[] args);
        /*0x3907c14*/ FieldType _GetStatic<FieldType>(string fieldName);
        /*0x3907c14*/ FieldType _GetStatic<FieldType>(nint fieldID);
        /*0x3907c14*/ void _SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x3907c14*/ void _SetStatic<FieldType>(nint fieldID, FieldType val);
        /*0x7dd559c*/ nint _GetRawObject();
        /*0x7dd55d0*/ nint _GetRawClass();
    }

    class AndroidJavaObjectUnityOwned : UnityEngine.AndroidJavaObject
    {
        /*0x7dd5dbc*/ AndroidJavaObjectUnityOwned(nint jobject);
        /*0x7dd5dc0*/ void Dispose(bool disposing);
    }

    class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        /*0x7dd204c*/ AndroidJavaClass(string className);
        /*0x7dd5750*/ AndroidJavaClass(nint jclass);
        /*0x7dd5e18*/ void _AndroidJavaClass(string className);
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

        static /*0x7dd6898*/ AndroidReflection();
        static /*0x7dd5f24*/ bool IsPrimitive(System.Type t);
        static /*0x7dd5f38*/ bool IsAssignableFrom(System.Type t, System.Type from);
        static /*0x7dd5f58*/ nint GetStaticMethodID(string clazz, string methodName, string signature);
        static /*0x7dd604c*/ nint GetMethodID(string clazz, string methodName, string signature);
        static /*0x7dd6140*/ nint GetConstructorMember(nint jclass, string signature);
        static /*0x7dd6318*/ nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x7dd64e0*/ nint GetFieldMember(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x7dd66a8*/ nint GetFieldClass(nint field);
        static /*0x7dd670c*/ string GetFieldSignature(nint field);
        static /*0x7dd67b4*/ nint NewProxyInstance(nint player, nint delegateHandle, nint interfaze);
        static /*0x7dd3518*/ nint CreateInvocationError(System.Exception ex, bool methodNotFound);
    }

    class _AndroidJNIHelper
    {
        static /*0x0*/ int FRAME_SIZE_FOR_ARRAYS;

        static /*0x7dd74b8*/ _AndroidJNIHelper();
        static /*0x7dc39d0*/ nint CreateJavaProxy(nint player, nint delegateHandle, UnityEngine.AndroidJavaProxy proxy);
        static /*0x7dc380c*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x7dd6b4c*/ nint InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, nint jmethodName, nint jargs);
        static /*0x7dc485c*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret);
        static /*0x7dd6c34*/ object UnboxArray(UnityEngine.AndroidJavaObject obj);
        static /*0x7dd38f4*/ object Unbox(UnityEngine.AndroidJavaObject obj);
        static /*0x7dd2b9c*/ UnityEngine.AndroidJavaObject Box(object obj);
        static /*0x7dc4f0c*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x7dc3aac*/ nint ConvertToJNIArray(System.Array array);
        static /*0x3907c14*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x7dc5148*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x7dc5230*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x3907c14*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x3907c14*/ nint GetFieldID<ReturnType>(nint jclass, string fieldName, bool isStatic);
        static /*0x7dc2f10*/ nint GetConstructorID(nint jclass, string signature);
        static /*0x7dc31e8*/ nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x7dd741c*/ nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x7dc34f0*/ nint GetFieldID(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x7dc5308*/ string GetSignature(object obj);
        static /*0x7dc6274*/ string GetSignature(object[] args);
        static /*0x382eaf0*/ string GetSignature<ReturnType>(object[] args);
        /*0x7dd74b0*/ _AndroidJNIHelper();
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

            static /*0x7dc39a8*/ nint get_UnityPlayerRaw();
            static /*0x7dd7504*/ nint get_CurrentContextRaw();
            static /*0x7dd752c*/ nint get_CurrentActivityRaw();
            static /*0x7dd7554*/ void AcquireMainThreadSynchronizationContext();
            static /*0x7dd760c*/ UnityEngine.AndroidJavaObject get_currentContext();
            static /*0x7dd76cc*/ UnityEngine.AndroidJavaObject get_currentActivity();
            static /*0x7dd778c*/ void SetCurrentConfiguration(UnityEngine.Android.AndroidConfiguration config);
            static /*0x7dd77dc*/ UnityEngine.Android.AndroidConfiguration GetCurrentConfiguration();
            static /*0x7dd7824*/ void DispatchConfigurationChanged(bool notifySubscribers);
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

            static /*0x7dd7904*/ bool DownloadInProgress(UnityEngine.Android.AndroidAssetPackStatus status);
            /*0x7dd7894*/ AndroidAssetPackInfo(string name, UnityEngine.Android.AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackState
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x1c*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            /*0x7dd7930*/ AndroidAssetPackState(string name, UnityEngine.Android.AndroidAssetPackStatus status, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackUseMobileDataRequestResult
        {
            /*0x10*/ bool <allowed>k__BackingField;

            /*0x7dd7978*/ AndroidAssetPackUseMobileDataRequestResult(bool allowed);
        }

        class AndroidAssetPacks
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;
            static /*0x8*/ bool s_ApiMissing;

            static /*0x7dd79a0*/ UnityEngine.AndroidJavaObject GetAssetPackManager();

            class AssetPackManagerDownloadStatusCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackInfo> m_Callback;
                /*0x28*/ System.Collections.Generic.Dictionary<string, UnityEngine.Android.AndroidAssetPackStatus> m_AssetPacks;

                /*0x7dd7d54*/ AssetPackManagerDownloadStatusCallback(System.Action<UnityEngine.Android.AndroidAssetPackInfo> callback, string[] assetPacks);
                /*0x7dd7f54*/ void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Android.AndroidAssetPacks.AssetPackManagerDownloadStatusCallback.<> <>9;
                    static /*0x8*/ System.Func<string, string> <>9__2_0;
                    static /*0x10*/ System.Func<string, UnityEngine.Android.AndroidAssetPackStatus> <>9__2_1;

                    static /*0x7dd8224*/ <>c();
                    /*0x7dd828c*/ <>c();
                    /*0x7dd8294*/ string <.ctor>b__2_0(string ap);
                    /*0x7dd829c*/ UnityEngine.Android.AndroidAssetPackStatus <.ctor>b__2_1(string ap);
                }
            }

            class AssetPackManagerMobileDataConfirmationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> m_Callback;

                /*0x7dd82a4*/ AssetPackManagerMobileDataConfirmationCallback(System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> callback);
                /*0x7dd832c*/ void onMobileDataConfirmationResult(bool allowed);
            }

            class AssetPackManagerStatusQueryCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> m_Callback;
                /*0x28*/ System.Collections.Generic.List<string> m_AssetPackNames;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Android.AndroidAssetPackState> m_States;
                /*0x38*/ long m_Size;

                /*0x7dd83b0*/ AssetPackManagerStatusQueryCallback(System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> callback, string[] assetPacks);
                /*0x7dd84c8*/ void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes);
            }
        }

        class AndroidGame
        {
            static /*0x7dd81e8*/ void StopLoading(int label);
        }

        class PermissionCallbacks : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<string> PermissionGranted;
            /*0x28*/ System.Action<string> PermissionDenied;
            /*0x30*/ System.Action<string> PermissionDeniedAndDontAskAgain;
            /*0x38*/ System.Action<string> PermissionRequestDismissed;

            /*0x7dd8de0*/ PermissionCallbacks();
            /*0x7dd8860*/ void add_PermissionGranted(System.Action<string> value);
            /*0x7dd8910*/ void remove_PermissionGranted(System.Action<string> value);
            /*0x7dd89c0*/ void add_PermissionDenied(System.Action<string> value);
            /*0x7dd8a70*/ void remove_PermissionDenied(System.Action<string> value);
            /*0x7dd8b20*/ void add_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x7dd8bd0*/ void remove_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x7dd8c80*/ void add_PermissionRequestDismissed(System.Action<string> value);
            /*0x7dd8d30*/ void remove_PermissionRequestDismissed(System.Action<string> value);
            /*0x7dd8e4c*/ nint Invoke(string methodName, nint javaArgs);
            /*0x7dd8edc*/ void onPermissionResult(nint javaArgs);

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

            static /*0x7dd9028*/ UnityEngine.AndroidJavaObject GetUnityPermissions();
            static /*0x7dd90e8*/ bool HasUserAuthorizedPermission(string permission);
            static /*0x7dd9220*/ void RequestUserPermission(string permission);
            static /*0x7dd92ac*/ void RequestUserPermissions(string[] permissions, UnityEngine.Android.PermissionCallbacks callbacks);
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

            /*0x7dd9418*/ AndroidLocale(string _country, string _language);
            /*0x7dd9408*/ string get_country();
            /*0x7dd9410*/ string get_language();
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

            /*0x7dd945c*/ int get_colorMode();
            /*0x7dd9464*/ int get_densityDpi();
            /*0x7dd946c*/ float get_fontScale();
            /*0x7dd9474*/ int get_fontWeightAdjustment();
            /*0x7dd947c*/ UnityEngine.Android.AndroidKeyboard get_keyboard();
            /*0x7dd9484*/ UnityEngine.Android.AndroidHardwareKeyboardHidden get_hardKeyboardHidden();
            /*0x7dd948c*/ UnityEngine.Android.AndroidKeyboardHidden get_keyboardHidden();
            /*0x7dd9494*/ int get_mobileCountryCode();
            /*0x7dd949c*/ int get_mobileNetworkCode();
            /*0x7dd94a4*/ UnityEngine.Android.AndroidNavigation get_navigation();
            /*0x7dd94ac*/ UnityEngine.Android.AndroidNavigationHidden get_navigationHidden();
            /*0x7dd94b4*/ UnityEngine.Android.AndroidOrientation get_orientation();
            /*0x7dd94bc*/ int get_screenHeightDp();
            /*0x7dd94c4*/ int get_screenWidthDp();
            /*0x7dd94cc*/ int get_smallestScreenWidthDp();
            /*0x7dd94d4*/ int get_screenLayout();
            /*0x7dd94dc*/ UnityEngine.Android.AndroidTouchScreen get_touchScreen();
            /*0x7dd94e4*/ int get_uiMode();
            /*0x7dd94ec*/ string get_primaryLocaleCountry();
            /*0x7dd94f4*/ string get_primaryLocaleLanguage();
            /*0x7dd94fc*/ UnityEngine.Android.AndroidLocale[] get_locales();
            /*0x7dd9600*/ UnityEngine.Android.AndroidColorModeHdr get_colorModeHdr();
            /*0x7dd960c*/ UnityEngine.Android.AndroidColorModeWideColorGamut get_colorModeWideColorGamut();
            /*0x7dd9618*/ UnityEngine.Android.AndroidScreenLayoutDirection get_screenLayoutDirection();
            /*0x7dd9624*/ UnityEngine.Android.AndroidScreenLayoutLong get_screenLayoutLong();
            /*0x7dd9630*/ UnityEngine.Android.AndroidScreenLayoutRound get_screenLayoutRound();
            /*0x7dd963c*/ UnityEngine.Android.AndroidScreenLayoutSize get_screenLayoutSize();
            /*0x7dd9648*/ UnityEngine.Android.AndroidUIModeNight get_uiModeNight();
            /*0x7dd9654*/ UnityEngine.Android.AndroidUIModeType get_uiModeType();
            /*0x7dd9660*/ string ToString();
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
