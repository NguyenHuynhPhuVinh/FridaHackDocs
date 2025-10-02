class <Module>
{
}

namespace UnityEngine
{
    class AndroidJavaRunnable : System.MulticastDelegate
    {
        /*0xe25c50*/ AndroidJavaRunnable(object object, nint method);
        /*0x9dbe20*/ void Invoke();
    }

    class AndroidJavaException : System.Exception
    {
        /*0x90*/ string mJavaStackTrace;

        /*0x15aec60*/ AndroidJavaException(string message, string javaStackTrace);
        /*0x15aece0*/ string get_StackTrace();
    }

    class GlobalJavaObjectRef
    {
        /*0x10*/ bool m_disposed;
        /*0x18*/ nint m_jobject;

        static /*0xdd4590*/ nint op_Implicit(UnityEngine.GlobalJavaObjectRef obj);
        /*0x15b1a30*/ GlobalJavaObjectRef(nint jobject);
        /*0x15b1980*/ void Finalize();
        /*0x15b1910*/ void Dispose();
    }

    class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ UnityEngine.AndroidJavaRunnable mRunnable;

        /*0x15b0d70*/ AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable);
        /*0x15b0e50*/ void run();
        /*0x15b0cb0*/ nint Invoke(string methodName, nint javaArgs);
    }

    class AndroidJavaProxy
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        static /*0x8*/ nint s_HashCodeMethodID;
        /*0x10*/ UnityEngine.AndroidJavaClass javaInterface;
        /*0x18*/ nint proxyObject;

        static /*0x15b0940*/ AndroidJavaProxy();
        /*0x15b0a50*/ AndroidJavaProxy(string javaInterface);
        /*0x15b0ad0*/ AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface);
        /*0x15af860*/ void Finalize();
        /*0x15afa00*/ UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args);
        /*0x15b03d0*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs);
        /*0x15b0570*/ nint Invoke(string methodName, nint javaArgs);
        /*0x15b0b10*/ bool equals(UnityEngine.AndroidJavaObject obj);
        /*0x15b0b70*/ int hashCode();
        /*0x15b0c50*/ string toString();
        /*0x15af8f0*/ UnityEngine.AndroidJavaObject GetProxyObject();
        /*0x15af910*/ nint GetRawProxy();
    }

    class AndroidJavaObject : System.IDisposable
    {
        static /*0x0*/ bool enableDebugPrints;
        /*0x10*/ UnityEngine.GlobalJavaObjectRef m_jobject;
        /*0x18*/ UnityEngine.GlobalJavaObjectRef m_jclass;

        static /*0x15aedf0*/ UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject);
        static /*0x15aed10*/ UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass);
        static /*0x2a5510*/ ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(nint jobject);
        /*0x15af820*/ AndroidJavaObject(string className, object[] args);
        /*0x15af6d0*/ AndroidJavaObject(nint jobject);
        /*0x32f970*/ AndroidJavaObject();
        /*0x15aef40*/ void Dispose();
        /*0x15af140*/ nint GetRawObject();
        /*0x15af120*/ nint GetRawClass();
        /*0x2a5510*/ ReturnType Call<ReturnType>(string methodName, object[] args);
        /*0x2a5510*/ ReturnType CallStatic<ReturnType>(string methodName, object[] args);
        /*0x15aeed0*/ void DebugPrint(string msg);
        /*0x15af160*/ void _AndroidJavaObject(string className, object[] args);
        /*0x15af3e0*/ void _AndroidJavaObject(nint constructorID, object[] args);
        /*0x15af0b0*/ void Finalize();
        /*0x15aefb0*/ void Dispose(bool disposing);
        /*0x2a5510*/ ReturnType _Call<ReturnType>(string methodName, object[] args);
        /*0x2a5510*/ ReturnType _Call<ReturnType>(nint methodID, object[] args);
        /*0x2a5510*/ ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
        /*0x2a5510*/ ReturnType _CallStatic<ReturnType>(nint methodID, object[] args);
        /*0x15af140*/ nint _GetRawObject();
        /*0x15af120*/ nint _GetRawClass();
    }

    class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        /*0x15aeaf0*/ AndroidJavaClass(string className);
        /*0x15aea00*/ AndroidJavaClass(nint jclass);
        /*0x15ae890*/ void _AndroidJavaClass(string className);
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

        static /*0x15b1670*/ AndroidReflection();
        static /*0x15b1510*/ bool IsPrimitive(System.Type t);
        static /*0x14b7a70*/ bool IsAssignableFrom(System.Type t, System.Type from);
        static /*0x15b1450*/ nint GetStaticMethodID(string clazz, string methodName, string signature);
        static /*0x15b1170*/ nint GetMethodID(string clazz, string methodName, string signature);
        static /*0x15b0fc0*/ nint GetConstructorMember(nint jclass, string signature);
        static /*0x15b1230*/ nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x15b1530*/ nint NewProxyInstance(nint player, nint delegateHandle, nint interfaze);
        static /*0x15b0e80*/ nint CreateInvocationError(System.Exception ex, bool methodNotFound);
    }

    class _AndroidJNIHelper
    {
        static /*0x15b3f10*/ nint CreateJavaProxy(nint player, nint delegateHandle, UnityEngine.AndroidJavaProxy proxy);
        static /*0x15aa030*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x15b5470*/ nint InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, nint jmethodName, nint jargs);
        static /*0x15b36e0*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret);
        static /*0x15b5520*/ object UnboxArray(UnityEngine.AndroidJavaObject obj);
        static /*0x15b5c00*/ object Unbox(UnityEngine.AndroidJavaObject obj);
        static /*0x15b1ab0*/ UnityEngine.AndroidJavaObject Box(object obj);
        static /*0x15b40c0*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x15b2a20*/ nint ConvertToJNIArray(System.Array array);
        static /*0x2a5510*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x15aa2d0*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x2a5510*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x15b4240*/ nint GetConstructorID(nint jclass, string signature);
        static /*0x15b43e0*/ nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x15b43b0*/ nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x15b4680*/ string GetSignature(object obj);
        static /*0x15b4560*/ string GetSignature(object[] args);
        static /*0x17e030*/ string GetSignature<ReturnType>(object[] args);
    }

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
        static /*0x15aa400*/ nint GetConstructorID(nint javaClass, string signature);
        static /*0x15aa410*/ nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic);
        static /*0x15aa030*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x15a9e10*/ nint CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy);
        static /*0x15a9ce0*/ void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x15aa140*/ void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs);
        static /*0x15aa2d0*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x2a5510*/ ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x2a5510*/ nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x15a9bb0*/ nint Box(UnityEngine.jvalue val, string boxedClass, string signature);
        static /*0x15a9af0*/ nint Box(int value);
        static /*0x15a9b50*/ nint Box(bool value);
    }

    class AndroidJNI
    {
        static /*0x15adae0*/ nint FindClass(string name);
        static /*0x15adce0*/ nint FromReflectedMethod(nint refMethod);
        static /*0x15adab0*/ nint ExceptionOccurred();
        static /*0x15ada80*/ void ExceptionClear();
        static /*0x15adfb0*/ nint NewGlobalRef(nint obj);
        static /*0x15ae1e0*/ void QueueDeleteGlobalRef(nint obj);
        static /*0x15ae1a0*/ nint NewWeakGlobalRef(nint obj);
        static /*0x15ada40*/ void DeleteWeakGlobalRef(nint obj);
        static /*0x15adff0*/ nint NewLocalRef(nint obj);
        static /*0x15ada00*/ void DeleteLocalRef(nint obj);
        static /*0x15adf60*/ bool IsSameObject(nint obj1, nint obj2);
        static /*0x15ae0e0*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ae030*/ nint NewObjectA(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ade80*/ nint GetObjectClass(nint obj);
        static /*0x15adde0*/ nint GetMethodID(nint clazz, string name, string sig);
        static /*0x15adec0*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x15ae160*/ nint NewString(string chars);
        static /*0x15ae160*/ nint NewStringFromStr(string chars);
        static /*0x15adf20*/ string GetStringChars(nint str);
        static /*0x15ad8f0*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x15ad870*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad810*/ string CallStringMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15acc40*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15acbe0*/ nint CallObjectMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15aca80*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aca20*/ int CallIntMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ac700*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ac6a0*/ bool CallBooleanMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ace00*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15acda0*/ short CallShortMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15acd20*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15accc0*/ sbyte CallSByteMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ac7e0*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ac780*/ char CallCharMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ac9a0*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ac940*/ float CallFloatMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ac8c0*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ac860*/ double CallDoubleMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15acb60*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15acb00*/ long CallLongMethodUnsafe(nint obj, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad740*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x15ad6c0*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad660*/ string CallStaticStringMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad420*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad3c0*/ nint CallStaticObjectMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad260*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad200*/ int CallStaticIntMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15acee0*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ace80*/ bool CallStaticBooleanMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad5e0*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad580*/ short CallStaticShortMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad500*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad4a0*/ sbyte CallStaticSByteMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15acfc0*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15acf60*/ char CallStaticCharMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad180*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad120*/ float CallStaticFloatMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad0a0*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad040*/ double CallStaticDoubleMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad340*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ad2e0*/ long CallStaticLongMethodUnsafe(nint clazz, nint methodID, UnityEngine.jvalue* args);
        static /*0x15ad9c0*/ nint ConvertToBooleanArray(bool[] array);
        static /*0x15ae270*/ nint ToBooleanArray(bool[] array);
        static /*0x15ae2b0*/ nint ToByteArray(byte[] array);
        static /*0x15ae730*/ nint ToSByteArray(sbyte[] array);
        static /*0x15ae7a0*/ nint ToSByteArray(sbyte* array, int length);
        static /*0x15ae330*/ nint ToCharArray(char[] array);
        static /*0x15ae2f0*/ nint ToCharArray(char* array, int length);
        static /*0x15ae820*/ nint ToShortArray(short[] array);
        static /*0x15ae7e0*/ nint ToShortArray(short* array, int length);
        static /*0x15ae540*/ nint ToIntArray(int[] array);
        static /*0x15ae500*/ nint ToIntArray(int* array, int length);
        static /*0x15ae5b0*/ nint ToLongArray(long[] array);
        static /*0x15ae620*/ nint ToLongArray(long* array, int length);
        static /*0x15ae450*/ nint ToFloatArray(float[] array);
        static /*0x15ae4c0*/ nint ToFloatArray(float* array, int length);
        static /*0x15ae3a0*/ nint ToDoubleArray(double[] array);
        static /*0x15ae410*/ nint ToDoubleArray(double* array, int length);
        static /*0x15ae6e0*/ nint ToObjectArray(nint* array, int length, nint arrayClass);
        static /*0x15ae660*/ nint ToObjectArray(nint[] array, nint arrayClass);
        static /*0x15adb20*/ bool[] FromBooleanArray(nint array);
        static /*0x15adb60*/ byte[] FromByteArray(nint array);
        static /*0x15add20*/ sbyte[] FromSByteArray(nint array);
        static /*0x15adba0*/ char[] FromCharArray(nint array);
        static /*0x15add60*/ short[] FromShortArray(nint array);
        static /*0x15adc60*/ int[] FromIntArray(nint array);
        static /*0x15adca0*/ long[] FromLongArray(nint array);
        static /*0x15adc20*/ float[] FromFloatArray(nint array);
        static /*0x15adbe0*/ double[] FromDoubleArray(nint array);
        static /*0x15adda0*/ int GetArrayLength(nint array);
        static /*0x15ae090*/ nint NewObjectArray(int size, nint clazz, nint obj);
        static /*0x15ade40*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x15ae220*/ void SetObjectArrayElement(nint array, int index, nint obj);
    }

    class AndroidJNISafe
    {
        static /*0x15ab510*/ void CheckException();
        static /*0x15ac0d0*/ void QueueDeleteGlobalRef(nint globalref);
        static /*0x15ab780*/ void DeleteWeakGlobalRef(nint globalref);
        static /*0x15ab730*/ void DeleteLocalRef(nint localref);
        static /*0x15ac060*/ nint NewString(string chars);
        static /*0x15abf20*/ string GetStringChars(nint str);
        static /*0x15abe20*/ nint GetObjectClass(nint ptr);
        static /*0x15abe90*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x15abd10*/ nint GetMethodID(nint obj, string name, string sig);
        static /*0x15abb50*/ nint FromReflectedMethod(nint refMethod);
        static /*0x15ab7d0*/ nint FindClass(string name);
        static /*0x15abf90*/ nint NewObject(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ab140*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x15ab070*/ nint CallStaticObjectMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ab370*/ string CallStaticStringMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aac50*/ char CallStaticCharMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aad20*/ double CallStaticDoubleMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aae00*/ float CallStaticFloatMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aafa0*/ long CallStaticLongMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ab2a0*/ short CallStaticShortMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ab1d0*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aab80*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aaee0*/ int CallStaticIntMethod(nint clazz, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa910*/ nint CallObjectMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ab440*/ string CallStringMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa4f0*/ char CallCharMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa5c0*/ double CallDoubleMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa6a0*/ float CallFloatMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa840*/ long CallLongMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aaab0*/ short CallShortMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa9e0*/ sbyte CallSByteMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa420*/ bool CallBooleanMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15aa780*/ int CallIntMethod(nint obj, nint methodID, System.Span<UnityEngine.jvalue> args);
        static /*0x15ab920*/ char[] FromCharArray(nint array);
        static /*0x15ab990*/ double[] FromDoubleArray(nint array);
        static /*0x15aba00*/ float[] FromFloatArray(nint array);
        static /*0x15abae0*/ long[] FromLongArray(nint array);
        static /*0x15abc30*/ short[] FromShortArray(nint array);
        static /*0x15ab8b0*/ byte[] FromByteArray(nint array);
        static /*0x15abbc0*/ sbyte[] FromSByteArray(nint array);
        static /*0x15ab840*/ bool[] FromBooleanArray(nint array);
        static /*0x15aba70*/ int[] FromIntArray(nint array);
        static /*0x15ac4e0*/ nint ToObjectArray(nint[] array, nint type);
        static /*0x15ac210*/ nint ToCharArray(char[] array);
        static /*0x15ac2a0*/ nint ToDoubleArray(double[] array);
        static /*0x15ac330*/ nint ToFloatArray(float[] array);
        static /*0x15ac450*/ nint ToLongArray(long[] array);
        static /*0x15ac610*/ nint ToShortArray(short[] array);
        static /*0x15ac1a0*/ nint ToByteArray(byte[] array);
        static /*0x15ac580*/ nint ToSByteArray(sbyte[] array);
        static /*0x15ac120*/ nint ToBooleanArray(bool[] array);
        static /*0x15ac3c0*/ nint ToIntArray(int[] array);
        static /*0x15abda0*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x15abca0*/ int GetArrayLength(nint array);
    }

    namespace Android
    {
        class AndroidApp
        {
            static /*0x15a9ac0*/ nint get_UnityPlayerRaw();
        }
    }
}
