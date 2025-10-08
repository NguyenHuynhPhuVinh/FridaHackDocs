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
        static /*0x3d3461c*/ bool get_debug();
        static /*0x3d34644*/ void set_debug(bool value);
        static /*0x3d34680*/ nint GetConstructorID(nint javaClass);
        static /*0x3d346c8*/ nint GetConstructorID(nint javaClass, string signature);
        static /*0x3d34918*/ nint GetMethodID(nint javaClass, string methodName);
        static /*0x3d349f0*/ nint GetMethodID(nint javaClass, string methodName, string signature);
        static /*0x3d34974*/ nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic);
        static /*0x3d34c10*/ nint GetFieldID(nint javaClass, string fieldName);
        static /*0x3d34ce8*/ nint GetFieldID(nint javaClass, string fieldName, string signature);
        static /*0x3d34c6c*/ nint GetFieldID(nint javaClass, string fieldName, string signature, bool isStatic);
        static /*0x3d34f98*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x3d35044*/ nint CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy);
        static /*0x3d3523c*/ nint ConvertToJNIArray(System.Array array);
        static /*0x3d35f44*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x3d3650c*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x3d36638*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x3d36834*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x3d368a0*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x3d36970*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x3d36a70*/ string GetSignature(object obj);
        static /*0x3d377dc*/ string GetSignature(object[] args);
        static /*0x1ffc854*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x1ffc854*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x1ffc854*/ nint GetFieldID<FieldType>(nint jclass, string fieldName, bool isStatic);
        static /*0x1f327cc*/ string GetSignature<ReturnType>(object[] args);
        static /*0x3d37988*/ nint Box(UnityEngine.jvalue val, string boxedClass, string signature);
        static /*0x3d37c88*/ nint Box(sbyte value);
        static /*0x3d37cf0*/ nint Box(short value);
        static /*0x3d37d58*/ nint Box(int value);
        static /*0x3d37dc0*/ nint Box(long value);
        static /*0x3d37e28*/ nint Box(float value);
        static /*0x3d37e90*/ nint Box(double value);
        static /*0x3d37ef8*/ nint Box(char value);
        static /*0x3d37f60*/ nint Box(bool value);
        static /*0x3d37fc8*/ nint GetUnboxMethod(nint obj, string methodName, string signature);
        static /*0x3d381ac*/ void Unbox(nint obj, ref sbyte value);
        static /*0x3d382a4*/ void Unbox(nint obj, ref short value);
        static /*0x3d3839c*/ void Unbox(nint obj, ref int value);
        static /*0x3d38494*/ void Unbox(nint obj, ref long value);
        static /*0x3d3858c*/ void Unbox(nint obj, ref float value);
        static /*0x3d38690*/ void Unbox(nint obj, ref double value);
        static /*0x3d38794*/ void Unbox(nint obj, ref char value);
        static /*0x3d3888c*/ void Unbox(nint obj, ref bool value);
    }

    class AndroidJNI
    {
        static /*0x3d38988*/ void ReleaseStringChars(UnityEngine.AndroidJNI.JStringBinding str);
        static /*0x3d38a00*/ nint GetJavaVM();
        static /*0x3d38a28*/ int AttachCurrentThread();
        static /*0x3d38a50*/ int DetachCurrentThread();
        static /*0x3d38a78*/ void InvokeAction(System.Action action);
        static /*0x3d38a98*/ void InvokeAttached(System.Action action);
        static /*0x3d38ad4*/ int GetVersion();
        static /*0x3d38afc*/ nint FindClass(string name);
        static /*0x3d38ca8*/ nint FromReflectedMethod(nint refMethod);
        static /*0x3d38ce4*/ nint FromReflectedField(nint refField);
        static /*0x3d38d20*/ nint ToReflectedMethod(nint clazz, nint methodID, bool isStatic);
        static /*0x3d38d74*/ nint ToReflectedField(nint clazz, nint fieldID, bool isStatic);
        static /*0x3d38dc8*/ nint GetSuperclass(nint clazz);
        static /*0x3d38e04*/ bool IsAssignableFrom(nint clazz1, nint clazz2);
        static /*0x3d38e48*/ int Throw(nint obj);
        static /*0x3d38e84*/ int ThrowNew(nint clazz, string message);
        static /*0x3d39040*/ nint ExceptionOccurred();
        static /*0x3d39068*/ void ExceptionDescribe();
        static /*0x3d39090*/ void ExceptionClear();
        static /*0x3d390b8*/ void FatalError(string message);
        static /*0x3d3925c*/ int PushLocalFrame(int capacity);
        static /*0x3d39298*/ nint PopLocalFrame(nint ptr);
        static /*0x3d392d4*/ nint NewGlobalRef(nint obj);
        static /*0x3d39310*/ void DeleteGlobalRef(nint obj);
        static /*0x3d3934c*/ void QueueDeleteGlobalRef(nint obj);
        static /*0x3d39388*/ uint GetQueueGlobalRefsCount();
        static /*0x3d393b0*/ nint NewWeakGlobalRef(nint obj);
        static /*0x3d393ec*/ void DeleteWeakGlobalRef(nint obj);
        static /*0x3d39428*/ nint NewLocalRef(nint obj);
        static /*0x3d39464*/ void DeleteLocalRef(nint obj);
        static /*0x3d394a0*/ bool IsSameObject(nint obj1, nint obj2);
        static /*0x3d394e4*/ int EnsureLocalCapacity(int capacity);
        static /*0x3d39520*/ nint AllocObject(nint clazz);
        static /*0x3d3955c*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d395d8*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d39670*/ nint NewObjectA(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d396c4*/ nint GetObjectClass(nint obj);
        static /*0x3d39700*/ bool IsInstanceOf(nint obj, nint clazz);
        static /*0x3d39744*/ nint GetMethodID(nint clazz, string name, string sig);
        static /*0x3d399e0*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x3d39c7c*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x3d39f18*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x3d3a1b4*/ nint NewString(string chars);
        static /*0x3d3a1b8*/ nint NewStringFromStr(string chars);
        static /*0x3d3a364*/ nint NewString(char[] chars);
        static /*0x3d3a470*/ nint NewStringUTF(string bytes);
        static /*0x3d3a61c*/ string GetStringChars(nint str);
        static /*0x3d3a6f0*/ UnityEngine.AndroidJNI.JStringBinding GetStringCharsInternal(nint str);
        static /*0x3d3a7f4*/ int GetStringLength(nint str);
        static /*0x3d3a830*/ int GetStringUTFLength(nint str);
        static /*0x3d3a86c*/ string GetStringUTFChars(nint str);
        static /*0x3d3a97c*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3a9f8*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3aa6c*/ string CallStringMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3ab58*/ UnityEngine.AndroidJNI.JStringBinding CallStringMethodUnsafeInternal(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3ac34*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3acb0*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3ad48*/ nint CallObjectMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3ad9c*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3ae18*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3aeb0*/ int CallIntMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3af04*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3af84*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b020*/ bool CallBooleanMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3b074*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b0f0*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b188*/ short CallShortMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3b1dc*/ byte CallByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b1e0*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b25c*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b2f4*/ sbyte CallSByteMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3b348*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b3c4*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b45c*/ char CallCharMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3b4b0*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b52c*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b5c4*/ float CallFloatMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3b618*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b694*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b72c*/ double CallDoubleMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3b780*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b7fc*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b894*/ long CallLongMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3b8e8*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3b964*/ void CallVoidMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3b9fc*/ void CallVoidMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3ba50*/ string GetStringField(nint obj, nint fieldID);
        static /*0x3d3bb2c*/ UnityEngine.AndroidJNI.JStringBinding GetStringFieldInternal(nint obj, nint fieldID);
        static /*0x3d3bbf0*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x3d3bc34*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x3d3bc78*/ byte GetByteField(nint obj, nint fieldID);
        static /*0x3d3bcbc*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x3d3bd00*/ char GetCharField(nint obj, nint fieldID);
        static /*0x3d3bd44*/ short GetShortField(nint obj, nint fieldID);
        static /*0x3d3bd88*/ int GetIntField(nint obj, nint fieldID);
        static /*0x3d3bdcc*/ long GetLongField(nint obj, nint fieldID);
        static /*0x3d3be10*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x3d3be54*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x3d3be98*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x3d3c06c*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x3d3c0c0*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x3d3c114*/ void SetByteField(nint obj, nint fieldID, byte val);
        static /*0x3d3c168*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x3d3c1bc*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x3d3c210*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x3d3c264*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x3d3c2b8*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x3d3c30c*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x3d3c360*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x3d3c3b4*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3c430*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3c4a4*/ string CallStaticStringMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3c590*/ UnityEngine.AndroidJNI.JStringBinding CallStaticStringMethodUnsafeInternal(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3c66c*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3c6e8*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3c780*/ nint CallStaticObjectMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3c7d4*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3c850*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3c8e8*/ int CallStaticIntMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3c93c*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3c9bc*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3ca58*/ bool CallStaticBooleanMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3caac*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3cb28*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3cbc0*/ short CallStaticShortMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3cc14*/ byte CallStaticByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3cc18*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3cc94*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3cd2c*/ sbyte CallStaticSByteMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3cd80*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3cdfc*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3ce94*/ char CallStaticCharMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3cee8*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3cf64*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3cffc*/ float CallStaticFloatMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3d050*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3d0cc*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3d164*/ double CallStaticDoubleMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3d1b8*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3d234*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3d2cc*/ long CallStaticLongMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3d320*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d3d39c*/ void CallStaticVoidMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3d434*/ void CallStaticVoidMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x3d3d488*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x3d3d564*/ UnityEngine.AndroidJNI.JStringBinding GetStaticStringFieldInternal(nint clazz, nint fieldID);
        static /*0x3d3d628*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x3d3d66c*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x3d3d6b0*/ byte GetStaticByteField(nint clazz, nint fieldID);
        static /*0x3d3d6f4*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x3d3d738*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x3d3d77c*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x3d3d7c0*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x3d3d804*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x3d3d848*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x3d3d88c*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x3d3d8d0*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x3d3daa4*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x3d3daf8*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x3d3db4c*/ void SetStaticByteField(nint clazz, nint fieldID, byte val);
        static /*0x3d3dba0*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x3d3dbf4*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x3d3dc48*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x3d3dc9c*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x3d3dcf0*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x3d3dd44*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x3d3dd98*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x3d3ddec*/ nint ConvertToBooleanArray(bool[] array);
        static /*0x3d3def8*/ nint ToBooleanArray(bool[] array);
        static /*0x3d3df04*/ nint ToByteArray(byte[] array);
        static /*0x3d3e010*/ nint ToSByteArray(sbyte[] array);
        static /*0x3d3e064*/ nint ToSByteArray(sbyte* array, int length);
        static /*0x3d3e0a8*/ nint ToCharArray(char[] array);
        static /*0x3d3e0fc*/ nint ToCharArray(char* array, int length);
        static /*0x3d3e140*/ nint ToShortArray(short[] array);
        static /*0x3d3e194*/ nint ToShortArray(short* array, int length);
        static /*0x3d3e1d8*/ nint ToIntArray(int[] array);
        static /*0x3d3e22c*/ nint ToIntArray(int* array, int length);
        static /*0x3d3e270*/ nint ToLongArray(long[] array);
        static /*0x3d3e2c4*/ nint ToLongArray(long* array, int length);
        static /*0x3d3e308*/ nint ToFloatArray(float[] array);
        static /*0x3d3e35c*/ nint ToFloatArray(float* array, int length);
        static /*0x3d3e3a0*/ nint ToDoubleArray(double[] array);
        static /*0x3d3e3f4*/ nint ToDoubleArray(double* array, int length);
        static /*0x3d3e438*/ nint ToObjectArray(nint* array, int length, nint arrayClass);
        static /*0x3d3e48c*/ nint ToObjectArray(nint[] array, nint arrayClass);
        static /*0x3d3e4f0*/ nint ToObjectArray(nint[] array);
        static /*0x3d3e4f8*/ bool[] FromBooleanArray(nint array);
        static /*0x3d3e654*/ byte[] FromByteArray(nint array);
        static /*0x3d3e7b0*/ sbyte[] FromSByteArray(nint array);
        static /*0x3d3e7ec*/ char[] FromCharArray(nint array);
        static /*0x3d3e828*/ short[] FromShortArray(nint array);
        static /*0x3d3e864*/ int[] FromIntArray(nint array);
        static /*0x3d3e8a0*/ long[] FromLongArray(nint array);
        static /*0x3d3e8dc*/ float[] FromFloatArray(nint array);
        static /*0x3d3e918*/ double[] FromDoubleArray(nint array);
        static /*0x3d3e954*/ nint[] FromObjectArray(nint array);
        static /*0x3d3eab0*/ int GetArrayLength(nint array);
        static /*0x3d3eaec*/ nint NewBooleanArray(int size);
        static /*0x3d3eb28*/ nint NewByteArray(int size);
        static /*0x3d3eb64*/ nint NewSByteArray(int size);
        static /*0x3d3eba0*/ nint NewCharArray(int size);
        static /*0x3d3ebdc*/ nint NewShortArray(int size);
        static /*0x3d3ec18*/ nint NewIntArray(int size);
        static /*0x3d3ec54*/ nint NewLongArray(int size);
        static /*0x3d3ec90*/ nint NewFloatArray(int size);
        static /*0x3d3eccc*/ nint NewDoubleArray(int size);
        static /*0x3d3ed08*/ nint NewObjectArray(int size, nint clazz, nint obj);
        static /*0x3d3ed5c*/ bool GetBooleanArrayElement(nint array, int index);
        static /*0x3d3eda0*/ byte GetByteArrayElement(nint array, int index);
        static /*0x3d3ede4*/ sbyte GetSByteArrayElement(nint array, int index);
        static /*0x3d3ee28*/ char GetCharArrayElement(nint array, int index);
        static /*0x3d3ee6c*/ short GetShortArrayElement(nint array, int index);
        static /*0x3d3eeb0*/ int GetIntArrayElement(nint array, int index);
        static /*0x3d3eef4*/ long GetLongArrayElement(nint array, int index);
        static /*0x3d3ef38*/ float GetFloatArrayElement(nint array, int index);
        static /*0x3d3ef7c*/ double GetDoubleArrayElement(nint array, int index);
        static /*0x3d3efc0*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x3d3f004*/ void SetBooleanArrayElement(nint array, int index, byte val);
        static /*0x3d3f05c*/ void SetBooleanArrayElement(nint array, int index, bool val);
        static /*0x3d3f0b0*/ void SetByteArrayElement(nint array, int index, sbyte val);
        static /*0x3d3f104*/ void SetSByteArrayElement(nint array, int index, sbyte val);
        static /*0x3d3f158*/ void SetCharArrayElement(nint array, int index, char val);
        static /*0x3d3f1ac*/ void SetShortArrayElement(nint array, int index, short val);
        static /*0x3d3f200*/ void SetIntArrayElement(nint array, int index, int val);
        static /*0x3d3f254*/ void SetLongArrayElement(nint array, int index, long val);
        static /*0x3d3f2a8*/ void SetFloatArrayElement(nint array, int index, float val);
        static /*0x3d3f2fc*/ void SetDoubleArrayElement(nint array, int index, double val);
        static /*0x3d3f350*/ void SetObjectArrayElement(nint array, int index, nint obj);
        static /*0x3d3f3a4*/ nint NewDirectByteBuffer(byte* buffer, long capacity);
        static /*0x3d3f3e8*/ nint NewDirectByteBuffer(Unity.Collections.NativeArray<byte> buffer);
        static /*0x3d3f440*/ nint NewDirectByteBuffer(Unity.Collections.NativeArray<sbyte> buffer);
        static /*0x1ffc854*/ nint NewDirectByteBufferFromNativeArray<T>(Unity.Collections.NativeArray<T> buffer);
        static /*0x3d3f498*/ sbyte* GetDirectBufferAddress(nint buffer);
        static /*0x3d3f4d4*/ long GetDirectBufferCapacity(nint buffer);
        static /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetDirectBuffer<T>(nint buffer);
        static /*0x3d3f510*/ Unity.Collections.NativeArray<byte> GetDirectByteBuffer(nint buffer);
        static /*0x3d3f558*/ Unity.Collections.NativeArray<sbyte> GetDirectSByteBuffer(nint buffer);
        static /*0x3d3f5a0*/ int RegisterNatives(nint clazz, UnityEngine.JNINativeMethod[] methods);
        static /*0x3d3f6d4*/ nint RegisterNativesAllocate(int length);
        static /*0x3d3f710*/ void RegisterNativesSet(nint natives, int idx, string name, string signature, nint fnPtr);
        static /*0x3d3f968*/ int RegisterNativesAndFree(nint clazz, nint natives, int n);
        static /*0x3d3fa28*/ int UnregisterNatives(nint clazz);
        static /*0x3d389c4*/ void ReleaseStringChars_Injected(ref UnityEngine.AndroidJNI.JStringBinding str);
        static /*0x3d38c6c*/ nint FindClass_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d38ffc*/ int ThrowNew_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper message);
        static /*0x3d39220*/ void FatalError_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper message);
        static /*0x3d3998c*/ nint GetMethodID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x3d39c28*/ nint GetFieldID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x3d39ec4*/ nint GetStaticMethodID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x3d3a160*/ nint GetStaticFieldID_Injected(nint clazz, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper sig);
        static /*0x3d3a328*/ nint NewStringFromStr_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper chars);
        static /*0x3d3a434*/ nint NewString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper chars);
        static /*0x3d3a5e0*/ nint NewStringUTF_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper bytes);
        static /*0x3d3a7b0*/ void GetStringCharsInternal_Injected(nint str, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x3d3a938*/ void GetStringUTFChars_Injected(nint str, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d3abd8*/ void CallStringMethodUnsafeInternal_Injected(nint obj, nint methodID, UnityEngine.jvalue* args, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x3d3bb9c*/ void GetStringFieldInternal_Injected(nint obj, nint fieldID, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x3d3c018*/ void SetStringField_Injected(nint obj, nint fieldID, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x3d3c610*/ void CallStaticStringMethodUnsafeInternal_Injected(nint clazz, nint methodID, UnityEngine.jvalue* args, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x3d3d5d4*/ void GetStaticStringFieldInternal_Injected(nint clazz, nint fieldID, ref UnityEngine.AndroidJNI.JStringBinding ret);
        static /*0x3d3da50*/ void SetStaticStringField_Injected(nint clazz, nint fieldID, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x3d3debc*/ nint ConvertToBooleanArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper array);
        static /*0x3d3dfd4*/ nint ToByteArray_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper array);
        static /*0x3d3e610*/ void FromBooleanArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d3e76c*/ void FromByteArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d3ea6c*/ void FromObjectArray_Injected(nint array, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d3f9bc*/ void RegisterNativesSet_Injected(nint natives, int idx, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper signature, nint fnPtr);

        struct JStringBinding : System.IDisposable
        {
            /*0x10*/ nint javaString;
            /*0x18*/ nint chars;
            /*0x20*/ int length;
            /*0x24*/ bool ownsRef;

            /*0x3d3a758*/ string ToString();
            /*0x3d3fa64*/ void Dispose();
        }
    }

    class AndroidJNISafe
    {
        static /*0x3d3fabc*/ void CheckException();
        static /*0x3d3fd54*/ void QueueDeleteGlobalRef(nint globalref);
        static /*0x3d3fd98*/ void DeleteWeakGlobalRef(nint globalref);
        static /*0x3d3fddc*/ void DeleteLocalRef(nint localref);
        static /*0x3d3fe20*/ nint NewString(string chars);
        static /*0x3d3fe90*/ string GetStringChars(nint str);
        static /*0x3d3809c*/ nint GetObjectClass(nint ptr);
        static /*0x3d37ba8*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x3d3813c*/ nint GetMethodID(nint obj, string name, string sig);
        static /*0x3d3ff00*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x3d3ff70*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x3d3ffe0*/ nint FromReflectedMethod(nint refMethod);
        static /*0x3d37b38*/ nint FindClass(string name);
        static /*0x3d40080*/ void PushLocalFrame(int capacity);
        static /*0x3d400d0*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d40140*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x3d40200*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x3d40270*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x3d40330*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x3d403f0*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x3d404b0*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x3d40570*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x3d40630*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x3d406f0*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x3d407b0*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x3d40870*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x3d40918*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x3d40988*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x3d40a30*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x3d40ae4*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x3d40b98*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x3d40c40*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x3d40ce8*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x3d40d90*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x3d40e38*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x3d40ee0*/ void CallStaticVoidMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d40f50*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d37c18*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d40fcc*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d41048*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d410f8*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d41168*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d411e4*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d41260*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d412d0*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d41340*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d413b0*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d41420*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d41490*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x3d41550*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x3d415c0*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x3d41680*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x3d41740*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x3d41800*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x3d418c0*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x3d41980*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x3d41a40*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x3d41b00*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x3d41bc0*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x3d41c68*/ string GetStringField(nint obj, nint fieldID);
        static /*0x3d41cd8*/ char GetCharField(nint obj, nint fieldID);
        static /*0x3d41d80*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x3d41e34*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x3d41ee8*/ long GetLongField(nint obj, nint fieldID);
        static /*0x3d41f90*/ short GetShortField(nint obj, nint fieldID);
        static /*0x3d42038*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x3d420e0*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x3d42188*/ int GetIntField(nint obj, nint fieldID);
        static /*0x3d42230*/ void CallVoidMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d422a0*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x3d4231c*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d4238c*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3881c*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d38718*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d38614*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3851c*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d3832c*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d38234*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d38918*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d38424*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x3d4243c*/ char[] FromCharArray(nint array);
        static /*0x3d424dc*/ double[] FromDoubleArray(nint array);
        static /*0x3d4257c*/ float[] FromFloatArray(nint array);
        static /*0x3d4261c*/ long[] FromLongArray(nint array);
        static /*0x3d426bc*/ short[] FromShortArray(nint array);
        static /*0x3d4275c*/ byte[] FromByteArray(nint array);
        static /*0x3d427cc*/ sbyte[] FromSByteArray(nint array);
        static /*0x3d4286c*/ bool[] FromBooleanArray(nint array);
        static /*0x3d428dc*/ int[] FromIntArray(nint array);
        static /*0x3d4297c*/ nint ToObjectArray(nint[] array, nint type);
        static /*0x3d429ec*/ nint ToCharArray(char[] array);
        static /*0x3d42a5c*/ nint ToDoubleArray(double[] array);
        static /*0x3d42acc*/ nint ToFloatArray(float[] array);
        static /*0x3d42b3c*/ nint ToLongArray(long[] array);
        static /*0x3d42bac*/ nint ToShortArray(short[] array);
        static /*0x3d42c1c*/ nint ToByteArray(byte[] array);
        static /*0x3d42c8c*/ nint ToSByteArray(sbyte[] array);
        static /*0x3d42cfc*/ nint ToBooleanArray(bool[] array);
        static /*0x3d42d78*/ nint ToIntArray(int[] array);
        static /*0x3d42de8*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x3d42e90*/ int GetArrayLength(nint array);
    }

    class AndroidJavaRunnable : System.MulticastDelegate
    {
        /*0x3d42f30*/ AndroidJavaRunnable(object object, nint method);
        /*0x3d42fcc*/ void Invoke();
    }

    class AndroidJavaException : System.Exception
    {
        /*0x90*/ string mJavaStackTrace;

        /*0x3d3fcd8*/ AndroidJavaException(string message, string javaStackTrace);
        /*0x3d42fe0*/ string get_StackTrace();
    }

    class GlobalJavaObjectRef
    {
        /*0x10*/ bool m_disposed;
        /*0x18*/ nint m_jobject;

        static /*0x3d43144*/ nint op_Implicit(UnityEngine.GlobalJavaObjectRef obj);
        /*0x3d43004*/ GlobalJavaObjectRef(nint jobject);
        /*0x3d43064*/ void Finalize();
        /*0x3d430e8*/ void Dispose();
    }

    class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ UnityEngine.AndroidJavaRunnable mRunnable;

        /*0x3d43158*/ AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable);
        /*0x3d43268*/ void run();
        /*0x3d43288*/ nint Invoke(string methodName, nint javaArgs);
    }

    class AndroidJavaProxy
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        static /*0x8*/ nint s_HashCodeMethodID;
        /*0x10*/ UnityEngine.AndroidJavaClass javaInterface;
        /*0x18*/ nint proxyObject;

        static /*0x3d45d68*/ AndroidJavaProxy();
        /*0x3d431e0*/ AndroidJavaProxy(string javaInterface);
        /*0x3d43700*/ AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface);
        /*0x3d43734*/ void Finalize();
        /*0x3d437ec*/ UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args);
        /*0x3d44d30*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs);
        /*0x3d43338*/ nint Invoke(string methodName, nint javaArgs);
        /*0x3d45a68*/ bool equals(UnityEngine.AndroidJavaObject obj);
        /*0x3d45ac0*/ int hashCode();
        /*0x3d45cf4*/ string toString();
        /*0x3d45d58*/ UnityEngine.AndroidJavaObject GetProxyObject();
        /*0x3d45c38*/ nint GetRawProxy();
    }

    class AndroidJavaObject : System.IDisposable
    {
        static /*0x0*/ bool enableDebugPrints;
        /*0x10*/ UnityEngine.GlobalJavaObjectRef m_jobject;
        /*0x18*/ UnityEngine.GlobalJavaObjectRef m_jclass;

        static /*0x3d45954*/ UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject);
        static /*0x3d473b8*/ UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass);
        static /*0x1ffc854*/ ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(nint jobject);
        static /*0x1ffc854*/ ReturnType FromJavaArray<ReturnType>(nint jobject);
        /*0x3d45e70*/ AndroidJavaObject(string className, string[] args);
        /*0x3d46050*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaObject[] args);
        /*0x3d46110*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaClass[] args);
        /*0x3d461d0*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaProxy[] args);
        /*0x3d46290*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaRunnable[] args);
        /*0x3d46350*/ AndroidJavaObject(string className, object[] args);
        /*0x3d44bfc*/ AndroidJavaObject(nint jobject);
        /*0x3d46384*/ AndroidJavaObject(nint clazz, nint constructorID, object[] args);
        /*0x3d45f30*/ AndroidJavaObject();
        /*0x3d458e8*/ void Dispose();
        /*0x1f30ff0*/ void Call<T>(string methodName, T[] args);
        /*0x1f30e7c*/ void Call<T>(nint methodID, T[] args);
        /*0x3d466dc*/ void Call(string methodName, object[] args);
        /*0x3d46720*/ void Call(nint methodID, object[] args);
        /*0x1f30ff0*/ void CallStatic<T>(string methodName, T[] args);
        /*0x1f30e7c*/ void CallStatic<T>(nint methodID, T[] args);
        /*0x3d469d0*/ void CallStatic(string methodName, object[] args);
        /*0x3d46a14*/ void CallStatic(nint methodID, object[] args);
        /*0x1ffc854*/ FieldType Get<FieldType>(string fieldName);
        /*0x1ffc854*/ FieldType Get<FieldType>(nint fieldID);
        /*0x1ffc854*/ void Set<FieldType>(string fieldName, FieldType val);
        /*0x1ffc854*/ void Set<FieldType>(nint fieldID, FieldType val);
        /*0x1ffc854*/ FieldType GetStatic<FieldType>(string fieldName);
        /*0x1ffc854*/ FieldType GetStatic<FieldType>(nint fieldID);
        /*0x1ffc854*/ void SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x1ffc854*/ void SetStatic<FieldType>(nint fieldID, FieldType val);
        /*0x3d45a50*/ nint GetRawObject();
        /*0x3d46cdc*/ nint GetRawClass();
        /*0x3d46d0c*/ UnityEngine.AndroidJavaObject CloneReference();
        /*0x1ffc854*/ ReturnType Call<ReturnType, T>(string methodName, T[] args);
        /*0x1ffc854*/ ReturnType Call<ReturnType, T>(nint methodID, T[] args);
        /*0x1ffc854*/ ReturnType Call<ReturnType>(string methodName, object[] args);
        /*0x1ffc854*/ ReturnType Call<ReturnType>(nint methodID, object[] args);
        /*0x1ffc854*/ ReturnType CallStatic<ReturnType, T>(string methodName, T[] args);
        /*0x1ffc854*/ ReturnType CallStatic<ReturnType, T>(nint methodID, T[] args);
        /*0x1ffc854*/ ReturnType CallStatic<ReturnType>(string methodName, object[] args);
        /*0x1ffc854*/ ReturnType CallStatic<ReturnType>(nint methodID, object[] args);
        /*0x3d46f3c*/ void DebugPrint(string msg);
        /*0x3d46fc4*/ void DebugPrint(string call, string methodName, string signature, object[] args);
        /*0x3d45f38*/ void _AndroidJavaObject(string className, object[] args);
        /*0x3d4641c*/ void _AndroidJavaObject(nint constructorID, object[] args);
        /*0x3d472cc*/ void Finalize();
        /*0x3d4735c*/ void Dispose(bool disposing);
        /*0x3d466e0*/ void _Call(string methodName, object[] args);
        /*0x3d46724*/ void _Call(nint methodID, object[] args);
        /*0x1ffc854*/ ReturnType _Call<ReturnType>(string methodName, object[] args);
        /*0x1ffc854*/ ReturnType _Call<ReturnType>(nint methodID, object[] args);
        /*0x1ffc854*/ FieldType _Get<FieldType>(string fieldName);
        /*0x1ffc854*/ FieldType _Get<FieldType>(nint fieldID);
        /*0x1ffc854*/ void _Set<FieldType>(string fieldName, FieldType val);
        /*0x1ffc854*/ void _Set<FieldType>(nint fieldID, FieldType val);
        /*0x3d469d4*/ void _CallStatic(string methodName, object[] args);
        /*0x3d46a18*/ void _CallStatic(nint methodID, object[] args);
        /*0x1ffc854*/ ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
        /*0x1ffc854*/ ReturnType _CallStatic<ReturnType>(nint methodID, object[] args);
        /*0x1ffc854*/ FieldType _GetStatic<FieldType>(string fieldName);
        /*0x1ffc854*/ FieldType _GetStatic<FieldType>(nint fieldID);
        /*0x1ffc854*/ void _SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x1ffc854*/ void _SetStatic<FieldType>(nint fieldID, FieldType val);
        /*0x3d46cc4*/ nint _GetRawObject();
        /*0x3d46cf4*/ nint _GetRawClass();
    }

    class AndroidJavaObjectUnityOwned : UnityEngine.AndroidJavaObject
    {
        /*0x3d474b4*/ AndroidJavaObjectUnityOwned(nint jobject);
        /*0x3d474b8*/ void Dispose(bool disposing);
    }

    class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        /*0x3d436d4*/ AndroidJavaClass(string className);
        /*0x3d46e70*/ AndroidJavaClass(nint jclass);
        /*0x3d47510*/ void _AndroidJavaClass(string className);
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

        static /*0x3d47f08*/ AndroidReflection();
        static /*0x3d4761c*/ bool IsPrimitive(System.Type t);
        static /*0x3d47630*/ bool IsAssignableFrom(System.Type t, System.Type from);
        static /*0x3d4764c*/ nint GetStaticMethodID(string clazz, string methodName, string signature);
        static /*0x3d47720*/ nint GetMethodID(string clazz, string methodName, string signature);
        static /*0x3d477f4*/ nint GetConstructorMember(nint jclass, string signature);
        static /*0x3d479a0*/ nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x3d47b5c*/ nint GetFieldMember(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x3d47d18*/ nint GetFieldClass(nint field);
        static /*0x3d47d7c*/ string GetFieldSignature(nint field);
        static /*0x3d47e24*/ nint NewProxyInstance(nint player, nint delegateHandle, nint interfaze);
        static /*0x3d44b0c*/ nint CreateInvocationError(System.Exception ex, bool methodNotFound);
    }

    class _AndroidJNIHelper
    {
        static /*0x0*/ int FRAME_SIZE_FOR_ARRAYS;

        static /*0x3d48b74*/ _AndroidJNIHelper();
        static /*0x3d351b4*/ nint CreateJavaProxy(nint player, nint delegateHandle, UnityEngine.AndroidJavaProxy proxy);
        static /*0x3d34fec*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x3d481d4*/ nint InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, nint jmethodName, nint jargs);
        static /*0x3d36000*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret);
        static /*0x3d482bc*/ object UnboxArray(UnityEngine.AndroidJavaObject obj);
        static /*0x3d44ed8*/ object Unbox(UnityEngine.AndroidJavaObject obj);
        static /*0x3d44210*/ UnityEngine.AndroidJavaObject Box(object obj);
        static /*0x3d366c8*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x3d35290*/ nint ConvertToJNIArray(System.Array array);
        static /*0x1ffc854*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x3d36904*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x3d369ec*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x1ffc854*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x1ffc854*/ nint GetFieldID<ReturnType>(nint jclass, string fieldName, bool isStatic);
        static /*0x3d3472c*/ nint GetConstructorID(nint jclass, string signature);
        static /*0x3d349f8*/ nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x3d48ad8*/ nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x3d34cf0*/ nint GetFieldID(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x3d36ac4*/ string GetSignature(object obj);
        static /*0x3d37830*/ string GetSignature(object[] args);
        static /*0x1f327cc*/ string GetSignature<ReturnType>(object[] args);
        /*0x3d48b6c*/ _AndroidJNIHelper();
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

            static /*0x3d3518c*/ nint get_UnityPlayerRaw();
            static /*0x3d48bc0*/ nint get_CurrentContextRaw();
            static /*0x3d48be8*/ nint get_CurrentActivityRaw();
            static /*0x3d48c10*/ void AcquireMainThreadSynchronizationContext();
            static /*0x3d48cc8*/ UnityEngine.AndroidJavaObject get_currentContext();
            static /*0x3d48d84*/ UnityEngine.AndroidJavaObject get_currentActivity();
            static /*0x3d48e40*/ void SetCurrentConfiguration(UnityEngine.Android.AndroidConfiguration config);
            static /*0x3d48e90*/ UnityEngine.Android.AndroidConfiguration GetCurrentConfiguration();
            static /*0x3d48ed8*/ void DispatchConfigurationChanged(bool notifySubscribers);
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

            static /*0x3d48fb8*/ bool DownloadInProgress(UnityEngine.Android.AndroidAssetPackStatus status);
            /*0x3d48f48*/ AndroidAssetPackInfo(string name, UnityEngine.Android.AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackState
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x1c*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            /*0x3d48fd4*/ AndroidAssetPackState(string name, UnityEngine.Android.AndroidAssetPackStatus status, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackUseMobileDataRequestResult
        {
            /*0x10*/ bool <allowed>k__BackingField;

            /*0x3d4901c*/ AndroidAssetPackUseMobileDataRequestResult(bool allowed);
        }

        class AndroidAssetPacks
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;
            static /*0x8*/ bool s_ApiMissing;

            static /*0x3d49044*/ UnityEngine.AndroidJavaObject GetAssetPackManager();

            class AssetPackManagerDownloadStatusCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackInfo> m_Callback;
                /*0x28*/ System.Collections.Generic.Dictionary<string, UnityEngine.Android.AndroidAssetPackStatus> m_AssetPacks;

                /*0x3d493c8*/ AssetPackManagerDownloadStatusCallback(System.Action<UnityEngine.Android.AndroidAssetPackInfo> callback, string[] assetPacks);
                /*0x3d495c8*/ void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Android.AndroidAssetPacks.AssetPackManagerDownloadStatusCallback.<> <>9;
                    static /*0x8*/ System.Func<string, string> <>9__2_0;
                    static /*0x10*/ System.Func<string, UnityEngine.Android.AndroidAssetPackStatus> <>9__2_1;

                    static /*0x3d499a0*/ <>c();
                    /*0x3d49a08*/ <>c();
                    /*0x3d49a10*/ string <.ctor>b__2_0(string ap);
                    /*0x3d49a18*/ UnityEngine.Android.AndroidAssetPackStatus <.ctor>b__2_1(string ap);
                }
            }

            class AssetPackManagerMobileDataConfirmationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> m_Callback;

                /*0x3d49a20*/ AssetPackManagerMobileDataConfirmationCallback(System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> callback);
                /*0x3d49aa8*/ void onMobileDataConfirmationResult(bool allowed);
            }

            class AssetPackManagerStatusQueryCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> m_Callback;
                /*0x28*/ System.Collections.Generic.List<string> m_AssetPackNames;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Android.AndroidAssetPackState> m_States;
                /*0x38*/ long m_Size;

                /*0x3d49b2c*/ AssetPackManagerStatusQueryCallback(System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> callback, string[] assetPacks);
                /*0x3d49c44*/ void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes);
            }
        }

        class AndroidGame
        {
            static /*0x3d49964*/ void StopLoading(int label);
        }

        class PermissionCallbacks : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<string> PermissionGranted;
            /*0x28*/ System.Action<string> PermissionDenied;
            /*0x30*/ System.Action<string> PermissionDeniedAndDontAskAgain;
            /*0x38*/ System.Action<string> PermissionRequestDismissed;

            /*0x3d4a4e8*/ PermissionCallbacks();
            /*0x3d49f68*/ void add_PermissionGranted(System.Action<string> value);
            /*0x3d4a018*/ void remove_PermissionGranted(System.Action<string> value);
            /*0x3d4a0c8*/ void add_PermissionDenied(System.Action<string> value);
            /*0x3d4a178*/ void remove_PermissionDenied(System.Action<string> value);
            /*0x3d4a228*/ void add_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x3d4a2d8*/ void remove_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x3d4a388*/ void add_PermissionRequestDismissed(System.Action<string> value);
            /*0x3d4a438*/ void remove_PermissionRequestDismissed(System.Action<string> value);
            /*0x3d4a554*/ nint Invoke(string methodName, nint javaArgs);
            /*0x3d4a5e4*/ void onPermissionResult(nint javaArgs);

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

            static /*0x3d4a6dc*/ UnityEngine.AndroidJavaObject GetUnityPermissions();
            static /*0x3d4a79c*/ bool HasUserAuthorizedPermission(string permission);
            static /*0x3d4a8dc*/ void RequestUserPermission(string permission, UnityEngine.Android.PermissionCallbacks callbacks);
            static /*0x3d4a96c*/ void RequestUserPermissions(string[] permissions, UnityEngine.Android.PermissionCallbacks callbacks);
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

            /*0x3d4aad8*/ AndroidLocale(string _country, string _language);
            /*0x3d4aac8*/ string get_country();
            /*0x3d4aad0*/ string get_language();
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

            /*0x3d4ab1c*/ int get_colorMode();
            /*0x3d4ab24*/ int get_densityDpi();
            /*0x3d4ab2c*/ float get_fontScale();
            /*0x3d4ab34*/ int get_fontWeightAdjustment();
            /*0x3d4ab3c*/ UnityEngine.Android.AndroidKeyboard get_keyboard();
            /*0x3d4ab44*/ UnityEngine.Android.AndroidHardwareKeyboardHidden get_hardKeyboardHidden();
            /*0x3d4ab4c*/ UnityEngine.Android.AndroidKeyboardHidden get_keyboardHidden();
            /*0x3d4ab54*/ int get_mobileCountryCode();
            /*0x3d4ab5c*/ int get_mobileNetworkCode();
            /*0x3d4ab64*/ UnityEngine.Android.AndroidNavigation get_navigation();
            /*0x3d4ab6c*/ UnityEngine.Android.AndroidNavigationHidden get_navigationHidden();
            /*0x3d4ab74*/ UnityEngine.Android.AndroidOrientation get_orientation();
            /*0x3d4ab7c*/ int get_screenHeightDp();
            /*0x3d4ab84*/ int get_screenWidthDp();
            /*0x3d4ab8c*/ int get_smallestScreenWidthDp();
            /*0x3d4ab94*/ int get_screenLayout();
            /*0x3d4ab9c*/ UnityEngine.Android.AndroidTouchScreen get_touchScreen();
            /*0x3d4aba4*/ int get_uiMode();
            /*0x3d4abac*/ string get_primaryLocaleCountry();
            /*0x3d4abb4*/ string get_primaryLocaleLanguage();
            /*0x3d4abbc*/ UnityEngine.Android.AndroidLocale[] get_locales();
            /*0x3d4acbc*/ UnityEngine.Android.AndroidColorModeHdr get_colorModeHdr();
            /*0x3d4acc8*/ UnityEngine.Android.AndroidColorModeWideColorGamut get_colorModeWideColorGamut();
            /*0x3d4acd4*/ UnityEngine.Android.AndroidScreenLayoutDirection get_screenLayoutDirection();
            /*0x3d4ace0*/ UnityEngine.Android.AndroidScreenLayoutLong get_screenLayoutLong();
            /*0x3d4acec*/ UnityEngine.Android.AndroidScreenLayoutRound get_screenLayoutRound();
            /*0x3d4acf8*/ UnityEngine.Android.AndroidScreenLayoutSize get_screenLayoutSize();
            /*0x3d4ad04*/ UnityEngine.Android.AndroidUIModeNight get_uiModeNight();
            /*0x3d4ad10*/ UnityEngine.Android.AndroidUIModeType get_uiModeType();
            /*0x3d4ad1c*/ string ToString();
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
