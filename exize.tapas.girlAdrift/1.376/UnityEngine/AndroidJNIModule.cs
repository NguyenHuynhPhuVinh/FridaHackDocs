class <Module>
{
}

namespace UnityEngine
{
    class AndroidJNISafe
    {
        static /*0x1b8363c*/ void CheckException();
        static /*0x1b83be4*/ void DeleteGlobalRef(nint globalref);
        static /*0x1b83cac*/ void DeleteWeakGlobalRef(nint globalref);
        static /*0x1b83d74*/ void DeleteLocalRef(nint localref);
        static /*0x1b83e3c*/ nint NewString(string chars);
        static /*0x1b83f18*/ string GetStringChars(nint str);
        static /*0x1b83ff4*/ nint GetObjectClass(nint ptr);
        static /*0x1b840d0*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x1b84188*/ nint GetMethodID(nint obj, string name, string sig);
        static /*0x1b84240*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x1b8434c*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x1b84458*/ nint FromReflectedMethod(nint refMethod);
        static /*0x1b84534*/ nint FindClass(string name);
        static /*0x1b845d4*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b846e0*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x1b847f0*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x1b84900*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x1b84a10*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x1b84b20*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x1b84c30*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x1b84d40*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x1b84e50*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x1b84f60*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x1b85070*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x1b85180*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x1b8526c*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x1b85358*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x1b85444*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x1b8553c*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x1b85634*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x1b85720*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x1b8580c*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x1b858f8*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x1b859e4*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x1b85ad0*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85be0*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85cec*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85da4*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85eb0*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85fc8*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b860e0*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b861ec*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b862f8*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b86404*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b86510*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b8661c*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x1b8672c*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x1b8683c*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x1b8694c*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x1b86a5c*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x1b86b6c*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x1b86c7c*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x1b86d8c*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x1b86e9c*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x1b86fac*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x1b870bc*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x1b871a8*/ string GetStringField(nint obj, nint fieldID);
        static /*0x1b87294*/ char GetCharField(nint obj, nint fieldID);
        static /*0x1b87380*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x1b87478*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x1b87570*/ long GetLongField(nint obj, nint fieldID);
        static /*0x1b8765c*/ short GetShortField(nint obj, nint fieldID);
        static /*0x1b87748*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x1b87834*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x1b87920*/ int GetIntField(nint obj, nint fieldID);
        static /*0x1b87a0c*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87b1c*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87c28*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87ce0*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87dec*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87f04*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b8801c*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b88128*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b88234*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b88340*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b8844c*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b88558*/ char[] FromCharArray(nint array);
        static /*0x1b88634*/ double[] FromDoubleArray(nint array);
        static /*0x1b88710*/ float[] FromFloatArray(nint array);
        static /*0x1b887ec*/ long[] FromLongArray(nint array);
        static /*0x1b888c8*/ short[] FromShortArray(nint array);
        static /*0x1b889a4*/ byte[] FromByteArray(nint array);
        static /*0x1b88a80*/ sbyte[] FromSByteArray(nint array);
        static /*0x1b88b5c*/ bool[] FromBooleanArray(nint array);
        static /*0x1b88c38*/ int[] FromIntArray(nint array);
        static /*0x1b88d14*/ nint ToObjectArray(nint[] array, nint type);
        static /*0x1b88e00*/ nint ToCharArray(char[] array);
        static /*0x1b88edc*/ nint ToDoubleArray(double[] array);
        static /*0x1b88fb8*/ nint ToFloatArray(float[] array);
        static /*0x1b89094*/ nint ToLongArray(long[] array);
        static /*0x1b89170*/ nint ToShortArray(short[] array);
        static /*0x1b8924c*/ nint ToByteArray(byte[] array);
        static /*0x1b89328*/ nint ToSByteArray(sbyte[] array);
        static /*0x1b89404*/ nint ToBooleanArray(bool[] array);
        static /*0x1b894e0*/ nint ToIntArray(int[] array);
        static /*0x1b895bc*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x1b896a8*/ int GetArrayLength(nint array);
    }

    class AndroidJavaRunnable : System.MulticastDelegate
    {
        /*0x1b89784*/ AndroidJavaRunnable(object object, nint method);
        /*0x1b89840*/ void Invoke();
    }

    class AndroidJavaException : System.Exception
    {
        /*0x90*/ string mJavaStackTrace;

        /*0x1b83b70*/ AndroidJavaException(string message, string javaStackTrace);
        /*0x1b89854*/ string get_StackTrace();
    }

    class GlobalJavaObjectRef
    {
        /*0x10*/ bool m_disposed;
        /*0x18*/ nint m_jobject;

        static /*0x1b89a78*/ nint op_Implicit(UnityEngine.GlobalJavaObjectRef obj);
        /*0x1b89878*/ GlobalJavaObjectRef(nint jobject);
        /*0x1b89968*/ void Finalize();
        /*0x1b899fc*/ void Dispose();
    }

    class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ UnityEngine.AndroidJavaRunnable mRunnable;

        /*0x1b89a90*/ AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable);
        /*0x1b89b8c*/ void run();
    }

    class AndroidJavaProxy
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        static /*0x8*/ nint s_HashCodeMethodID;
        /*0x10*/ UnityEngine.AndroidJavaClass javaInterface;
        /*0x18*/ nint proxyObject;

        static /*0x1b8bef0*/ AndroidJavaProxy();
        /*0x1b89b10*/ AndroidJavaProxy(string javaInterface);
        /*0x1b89bdc*/ AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface);
        /*0x1b89c48*/ void Finalize();
        /*0x1b89ce0*/ UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args);
        /*0x1b8afb0*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs);
        /*0x1b8ba78*/ bool equals(UnityEngine.AndroidJavaObject obj);
        /*0x1b8bbd0*/ int hashCode();
        /*0x1b8bc80*/ string toString();
        /*0x1b8bce4*/ UnityEngine.AndroidJavaObject GetProxyObject();
        /*0x1b8ad60*/ nint GetRawProxy();
    }

    class AndroidJavaObject : System.IDisposable
    {
        static /*0x0*/ bool enableDebugPrints;
        /*0x10*/ UnityEngine.GlobalJavaObjectRef m_jobject;
        /*0x18*/ UnityEngine.GlobalJavaObjectRef m_jclass;

        static /*0x1b8bcf4*/ UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject);
        static /*0x1b8d13c*/ UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass);
        static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(nint jobject);
        /*0x1b8bfec*/ AndroidJavaObject(string className, string[] args);
        /*0x1b8c2a4*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaObject[] args);
        /*0x1b8c358*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaClass[] args);
        /*0x1b8c40c*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaProxy[] args);
        /*0x1b8c4c0*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaRunnable[] args);
        /*0x1b8c574*/ AndroidJavaObject(string className, object[] args);
        /*0x1b8cf10*/ AndroidJavaObject(nint jobject);
        /*0x1b8c0a0*/ AndroidJavaObject();
        /*0x1b8ba0c*/ void Dispose();
        void Call<T>(string methodName, T[] args);
        /*0x1b8c5a8*/ void Call(string methodName, object[] args);
        void CallStatic<T>(string methodName, T[] args);
        /*0x1b8c6e8*/ void CallStatic(string methodName, object[] args);
        FieldType Get<FieldType>(string fieldName);
        void Set<FieldType>(string fieldName, FieldType val);
        FieldType GetStatic<FieldType>(string fieldName);
        void SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x1b8bb30*/ nint GetRawObject();
        /*0x1b8c884*/ nint GetRawClass();
        /*0x1b8c8bc*/ UnityEngine.AndroidJavaObject CloneReference();
        ReturnType Call<ReturnType, T>(string methodName, T[] args);
        ReturnType Call<ReturnType>(string methodName, object[] args);
        ReturnType CallStatic<ReturnType, T>(string methodName, T[] args);
        ReturnType CallStatic<ReturnType>(string methodName, object[] args);
        /*0x1b8cb0c*/ void DebugPrint(string msg);
        /*0x1b8cb94*/ void DebugPrint(string call, string methodName, string signature, object[] args);
        /*0x1b8c0a8*/ void _AndroidJavaObject(string className, object[] args);
        /*0x1b8d034*/ void Finalize();
        /*0x1b8d0d4*/ void Dispose(bool disposing);
        /*0x1b8c5ac*/ void _Call(string methodName, object[] args);
        ReturnType _Call<ReturnType>(string methodName, object[] args);
        FieldType _Get<FieldType>(string fieldName);
        void _Set<FieldType>(string fieldName, FieldType val);
        /*0x1b8c6ec*/ void _CallStatic(string methodName, object[] args);
        ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
        FieldType _GetStatic<FieldType>(string fieldName);
        void _SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x1b8c828*/ nint _GetRawObject();
        /*0x1b8c8a0*/ nint _GetRawClass();
    }

    class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        /*0x1b89bb0*/ AndroidJavaClass(string className);
        /*0x1b8ca18*/ AndroidJavaClass(nint jclass);
        /*0x1b8d204*/ void _AndroidJavaClass(string className);
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

        static /*0x1b8db98*/ AndroidReflection();
        static /*0x1b8d2c4*/ bool IsPrimitive(System.Type t);
        static /*0x1b8d2d8*/ bool IsAssignableFrom(System.Type t, System.Type from);
        static /*0x1b8d2f8*/ nint GetStaticMethodID(string clazz, string methodName, string signature);
        static /*0x1b8d394*/ nint GetMethodID(string clazz, string methodName, string signature);
        static /*0x1b8d430*/ nint GetConstructorMember(nint jclass, string signature);
        static /*0x1b8d5bc*/ nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x1b8d7bc*/ nint GetFieldMember(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x1b8d9bc*/ nint GetFieldClass(nint field);
        static /*0x1b8da20*/ string GetFieldSignature(nint field);
        static /*0x1b8dac8*/ nint NewProxyInstance(nint delegateHandle, nint interfaze);
        static /*0x1b8aea4*/ void SetNativeExceptionOnProxy(nint proxy, System.Exception e, bool methodNotFound);
    }

    class _AndroidJNIHelper
    {
        static /*0x1b8de44*/ nint CreateJavaProxy(nint delegateHandle, UnityEngine.AndroidJavaProxy proxy);
        static /*0x1b8debc*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x1b8df1c*/ nint InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, nint jmethodName, nint jargs);
        static /*0x1b8e3b4*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x1b8f378*/ object UnboxArray(UnityEngine.AndroidJavaObject obj);
        static /*0x1b8b114*/ object Unbox(UnityEngine.AndroidJavaObject obj);
        static /*0x1b8a408*/ UnityEngine.AndroidJavaObject Box(object obj);
        static /*0x1b8fa10*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x1b8e9c0*/ nint ConvertToJNIArray(System.Array array);
        static ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x1b8fc18*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x1b8fd30*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetFieldID<ReturnType>(nint jclass, string fieldName, bool isStatic);
        static /*0x1b8fd68*/ nint GetConstructorID(nint jclass, string signature);
        static /*0x1b8ff68*/ nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x1b90178*/ nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x1b90274*/ nint GetFieldID(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x1b905c8*/ string GetSignature(object obj);
        static /*0x1b8fc38*/ string GetSignature(object[] args);
        static string GetSignature<ReturnType>(object[] args);
        /*0x1b9143c*/ _AndroidJNIHelper();
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
        static /*0x1b91444*/ bool get_debug();
        static /*0x1b9146c*/ void set_debug(bool value);
        static /*0x1b914a8*/ nint GetConstructorID(nint javaClass);
        static /*0x1b8fd2c*/ nint GetConstructorID(nint javaClass, string signature);
        static /*0x1b914f0*/ nint GetMethodID(nint javaClass, string methodName);
        static /*0x1b9154c*/ nint GetMethodID(nint javaClass, string methodName, string signature);
        static /*0x1b8bfe4*/ nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic);
        static /*0x1b91554*/ nint GetFieldID(nint javaClass, string fieldName);
        static /*0x1b915b8*/ nint GetFieldID(nint javaClass, string fieldName, string signature);
        static /*0x1b915b0*/ nint GetFieldID(nint javaClass, string fieldName, string signature, bool isStatic);
        static /*0x1b8f374*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x1b8bdf8*/ nint CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy);
        static /*0x1b915c0*/ nint ConvertToJNIArray(System.Array array);
        static /*0x1b8ceec*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x1b915c4*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x1b8cef0*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x1b8d104*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x1b915c8*/ string GetSignature(object obj);
        static /*0x1b915cc*/ string GetSignature(object[] args);
        static ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetFieldID<FieldType>(nint jclass, string fieldName, bool isStatic);
        static string GetSignature<ReturnType>(object[] args);
    }

    class AndroidJNI
    {
        static /*0x1b915d0*/ int AttachCurrentThread();
        static /*0x1b915f8*/ int DetachCurrentThread();
        static /*0x1b91620*/ int GetVersion();
        static /*0x1b839e4*/ nint FindClass(string name);
        static /*0x1b844f8*/ nint FromReflectedMethod(nint refMethod);
        static /*0x1b91648*/ nint FromReflectedField(nint refField);
        static /*0x1b91684*/ nint ToReflectedMethod(nint clazz, nint methodID, bool isStatic);
        static /*0x1b916d8*/ nint ToReflectedField(nint clazz, nint fieldID, bool isStatic);
        static /*0x1b9172c*/ nint GetSuperclass(nint clazz);
        static /*0x1b91768*/ bool IsAssignableFrom(nint clazz1, nint clazz2);
        static /*0x1b917ac*/ int Throw(nint obj);
        static /*0x1b917e8*/ int ThrowNew(nint clazz, string message);
        static /*0x1b83994*/ nint ExceptionOccurred();
        static /*0x1b9182c*/ void ExceptionDescribe();
        static /*0x1b839bc*/ void ExceptionClear();
        static /*0x1b91854*/ void FatalError(string message);
        static /*0x1b9058c*/ int PushLocalFrame(int capacity);
        static /*0x1b91890*/ nint PopLocalFrame(nint ptr);
        static /*0x1b8992c*/ nint NewGlobalRef(nint obj);
        static /*0x1b83c70*/ void DeleteGlobalRef(nint obj);
        static /*0x1b8beb4*/ nint NewWeakGlobalRef(nint obj);
        static /*0x1b83d38*/ void DeleteWeakGlobalRef(nint obj);
        static /*0x1b8bdbc*/ nint NewLocalRef(nint obj);
        static /*0x1b83e00*/ void DeleteLocalRef(nint obj);
        static /*0x1b8bb8c*/ bool IsSameObject(nint obj1, nint obj2);
        static /*0x1b918cc*/ int EnsureLocalCapacity(int capacity);
        static /*0x1b91908*/ nint AllocObject(nint clazz);
        static /*0x1b8468c*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b84094*/ nint GetObjectClass(nint obj);
        static /*0x1b91944*/ bool IsInstanceOf(nint obj, nint clazz);
        static /*0x1b83a20*/ nint GetMethodID(nint clazz, string name, string sig);
        static /*0x1b842f8*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x1b83a74*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x1b84404*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x1b83edc*/ nint NewString(string chars);
        static /*0x1b91988*/ nint NewStringFromStr(string chars);
        static /*0x1b919c4*/ nint NewString(char[] chars);
        static /*0x1b91a00*/ nint NewStringUTF(string bytes);
        static /*0x1b83fb8*/ string GetStringChars(nint str);
        static /*0x1b91a3c*/ int GetStringLength(nint str);
        static /*0x1b91a78*/ int GetStringUTFLength(nint str);
        static /*0x1b91ab4*/ string GetStringUTFChars(nint str);
        static /*0x1b83ac8*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87bd4*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b88504*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b883f8*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b881e0*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b91af0*/ byte CallByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b882ec*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87d98*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87fc8*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87eb0*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b880d4*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87ac8*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b87250*/ string GetStringField(nint obj, nint fieldID);
        static /*0x1b87164*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x1b878dc*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x1b91b44*/ byte GetByteField(nint obj, nint fieldID);
        static /*0x1b877f0*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x1b8733c*/ char GetCharField(nint obj, nint fieldID);
        static /*0x1b87704*/ short GetShortField(nint obj, nint fieldID);
        static /*0x1b879c8*/ int GetIntField(nint obj, nint fieldID);
        static /*0x1b87618*/ long GetLongField(nint obj, nint fieldID);
        static /*0x1b8752c*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x1b87434*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x1b867e8*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x1b866d8*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x1b86f58*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x1b91b88*/ void SetByteField(nint obj, nint fieldID, byte val);
        static /*0x1b86e48*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x1b868f8*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x1b86d38*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x1b87068*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x1b86c28*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x1b86b18*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x1b86a08*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x1b83b1c*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85c98*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b865c8*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b864bc*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b862a4*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b91bdc*/ byte CallStaticByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b863b0*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85e5c*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b8608c*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85f74*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b86198*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85b8c*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x1b85314*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x1b85228*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x1b859a0*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x1b91c30*/ byte GetStaticByteField(nint clazz, nint fieldID);
        static /*0x1b858b4*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x1b85400*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x1b857c8*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x1b85a8c*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x1b856dc*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x1b855f0*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x1b854f8*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x1b848ac*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x1b8479c*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x1b8501c*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x1b91c74*/ void SetStaticByteField(nint clazz, nint fieldID, byte val);
        static /*0x1b84f0c*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x1b849bc*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x1b84dfc*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x1b8512c*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x1b84cec*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x1b84bdc*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x1b84acc*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x1b894a4*/ nint ToBooleanArray(bool[] array);
        static /*0x1b892ec*/ nint ToByteArray(byte[] array);
        static /*0x1b893c8*/ nint ToSByteArray(sbyte[] array);
        static /*0x1b88ea0*/ nint ToCharArray(char[] array);
        static /*0x1b89210*/ nint ToShortArray(short[] array);
        static /*0x1b89580*/ nint ToIntArray(int[] array);
        static /*0x1b89134*/ nint ToLongArray(long[] array);
        static /*0x1b89058*/ nint ToFloatArray(float[] array);
        static /*0x1b88f7c*/ nint ToDoubleArray(double[] array);
        static /*0x1b88dbc*/ nint ToObjectArray(nint[] array, nint arrayClass);
        static /*0x1b91cc8*/ nint ToObjectArray(nint[] array);
        static /*0x1b88bfc*/ bool[] FromBooleanArray(nint array);
        static /*0x1b88a44*/ byte[] FromByteArray(nint array);
        static /*0x1b88b20*/ sbyte[] FromSByteArray(nint array);
        static /*0x1b885f8*/ char[] FromCharArray(nint array);
        static /*0x1b88968*/ short[] FromShortArray(nint array);
        static /*0x1b88cd8*/ int[] FromIntArray(nint array);
        static /*0x1b8888c*/ long[] FromLongArray(nint array);
        static /*0x1b887b0*/ float[] FromFloatArray(nint array);
        static /*0x1b886d4*/ double[] FromDoubleArray(nint array);
        static /*0x1b91d3c*/ nint[] FromObjectArray(nint array);
        static /*0x1b89748*/ int GetArrayLength(nint array);
        static /*0x1b91d78*/ nint NewBooleanArray(int size);
        static /*0x1b91db4*/ nint NewByteArray(int size);
        static /*0x1b91df0*/ nint NewSByteArray(int size);
        static /*0x1b91e2c*/ nint NewCharArray(int size);
        static /*0x1b91e68*/ nint NewShortArray(int size);
        static /*0x1b91ea4*/ nint NewIntArray(int size);
        static /*0x1b91ee0*/ nint NewLongArray(int size);
        static /*0x1b91f1c*/ nint NewFloatArray(int size);
        static /*0x1b91f58*/ nint NewDoubleArray(int size);
        static /*0x1b8fb70*/ nint NewObjectArray(int size, nint clazz, nint obj);
        static /*0x1b91f94*/ bool GetBooleanArrayElement(nint array, int index);
        static /*0x1b91fd8*/ byte GetByteArrayElement(nint array, int index);
        static /*0x1b9201c*/ sbyte GetSByteArrayElement(nint array, int index);
        static /*0x1b92060*/ char GetCharArrayElement(nint array, int index);
        static /*0x1b920a4*/ short GetShortArrayElement(nint array, int index);
        static /*0x1b920e8*/ int GetIntArrayElement(nint array, int index);
        static /*0x1b9212c*/ long GetLongArrayElement(nint array, int index);
        static /*0x1b92170*/ float GetFloatArrayElement(nint array, int index);
        static /*0x1b921b4*/ double GetDoubleArrayElement(nint array, int index);
        static /*0x1b89664*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x1b921f8*/ void SetBooleanArrayElement(nint array, int index, byte val);
        static /*0x1b92250*/ void SetBooleanArrayElement(nint array, int index, bool val);
        static /*0x1b922a4*/ void SetByteArrayElement(nint array, int index, sbyte val);
        static /*0x1b922f8*/ void SetSByteArrayElement(nint array, int index, sbyte val);
        static /*0x1b9234c*/ void SetCharArrayElement(nint array, int index, char val);
        static /*0x1b923a0*/ void SetShortArrayElement(nint array, int index, short val);
        static /*0x1b923f4*/ void SetIntArrayElement(nint array, int index, int val);
        static /*0x1b92448*/ void SetLongArrayElement(nint array, int index, long val);
        static /*0x1b9249c*/ void SetFloatArrayElement(nint array, int index, float val);
        static /*0x1b924f0*/ void SetDoubleArrayElement(nint array, int index, double val);
        static /*0x1b8fbc4*/ void SetObjectArrayElement(nint array, int index, nint obj);
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

            /*0x1b92544*/ AndroidAssetPackInfo(string name, UnityEngine.Android.AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackState
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x1c*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            /*0x1b925a8*/ AndroidAssetPackState(string name, UnityEngine.Android.AndroidAssetPackStatus status, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackUseMobileDataRequestResult
        {
            /*0x10*/ bool <allowed>k__BackingField;

            /*0x1b925e4*/ AndroidAssetPackUseMobileDataRequestResult(bool allowed);
        }

        class AndroidAssetPacks
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;
            static /*0x8*/ bool s_ApiMissing;

            static /*0x1b9260c*/ UnityEngine.AndroidJavaObject GetAssetPackManager();

            class AssetPackManagerDownloadStatusCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackInfo> m_Callback;
                /*0x28*/ string[] m_AssetPacks;

                /*0x1b92924*/ AssetPackManagerDownloadStatusCallback(System.Action<UnityEngine.Android.AndroidAssetPackInfo> callback, string[] assetPacks);
                /*0x1b929a8*/ void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode);
            }

            class AssetPackManagerMobileDataConfirmationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> m_Callback;

                /*0x1b92abc*/ AssetPackManagerMobileDataConfirmationCallback(System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> callback);
                /*0x1b92b3c*/ void onMobileDataConfirmationResult(bool allowed);
            }

            class AssetPackManagerStatusQueryCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> m_Callback;
                /*0x28*/ System.Collections.Generic.List<string> m_AssetPackNames;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Android.AndroidAssetPackState> m_States;
                /*0x38*/ long m_Size;

                /*0x1b92bc8*/ AssetPackManagerStatusQueryCallback(System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> callback, string[] assetPacks);
                /*0x1b92cc0*/ void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes);
            }
        }

        class PermissionCallbacks : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<string> PermissionGranted;
            /*0x28*/ System.Action<string> PermissionDenied;
            /*0x30*/ System.Action<string> PermissionDeniedAndDontAskAgain;

            /*0x1b9345c*/ PermissionCallbacks();
            /*0x1b9303c*/ void add_PermissionGranted(System.Action<string> value);
            /*0x1b930ec*/ void remove_PermissionGranted(System.Action<string> value);
            /*0x1b9319c*/ void add_PermissionDenied(System.Action<string> value);
            /*0x1b9324c*/ void remove_PermissionDenied(System.Action<string> value);
            /*0x1b932fc*/ void add_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x1b933ac*/ void remove_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x1b934c8*/ void onPermissionGranted(string permissionName);
            /*0x1b934e4*/ void onPermissionDenied(string permissionName);
            /*0x1b93500*/ void onPermissionDeniedAndDontAskAgain(string permissionName);
        }
    }
}
