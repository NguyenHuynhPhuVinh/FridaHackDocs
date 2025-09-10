class <Module>
{
}

namespace Firebase
{
    class AppOptions : System.IDisposable
    {
        /*0x10*/ System.Uri <DatabaseUrl>k__BackingField;
        /*0x18*/ string <AppId>k__BackingField;
        /*0x20*/ string <ApiKey>k__BackingField;
        /*0x28*/ string <MessageSenderId>k__BackingField;
        /*0x30*/ string <StorageBucket>k__BackingField;
        /*0x38*/ string <ProjectId>k__BackingField;
        /*0x40*/ string <PackageName>k__BackingField;

        static /*0x13715a8*/ Firebase.AppOptions LoadFromJsonConfig(string json_config);
        /*0x137152c*/ AppOptions();
        /*0x137176c*/ AppOptions(Firebase.AppOptionsInternal other);
        /*0x1371534*/ void Dispose();
        /*0x1371538*/ System.Uri get_DatabaseUrl();
        /*0x1371540*/ void set_DatabaseUrl(System.Uri value);
        /*0x1371548*/ string get_AppId();
        /*0x1371550*/ void set_AppId(string value);
        /*0x1371558*/ string get_ApiKey();
        /*0x1371560*/ void set_ApiKey(string value);
        /*0x1371568*/ string get_MessageSenderId();
        /*0x1371570*/ void set_MessageSenderId(string value);
        /*0x1371578*/ string get_StorageBucket();
        /*0x1371580*/ void set_StorageBucket(string value);
        /*0x1371588*/ string get_ProjectId();
        /*0x1371590*/ void set_ProjectId(string value);
        /*0x1371598*/ string get_PackageName();
        /*0x13715a0*/ void set_PackageName(string value);
        /*0x1371d00*/ Firebase.AppOptionsInternal ConvertToInternal();
    }

    enum DependencyStatus
    {
        Available = 0,
        UnavailableDisabled = 1,
        UnavailableInvalid = 2,
        UnavilableMissing = 3,
        UnavailablePermission = 4,
        UnavailableUpdaterequired = 5,
        UnavailableUpdating = 6,
        UnavailableOther = 7,
    }

    class ErrorMessages
    {
        static /*0x0*/ string DEPENDENCY_NOT_FOUND_ERROR_ANDROID;
        static /*0x8*/ string DEPENDENCY_NOT_FOUND_ERROR_IOS;
        static /*0x10*/ string DEPENDENCY_NOT_FOUND_ERROR_GENERIC;
        static /*0x18*/ string DLL_NOT_FOUND_ERROR_ANDROID;
        static /*0x20*/ string DLL_NOT_FOUND_ERROR_IOS;
        static /*0x28*/ string DLL_NOT_FOUND_ERROR_GENERIC;

        static /*0x13725a4*/ ErrorMessages();
        static /*0x1372434*/ string get_DependencyNotFoundErrorMessage();
        static /*0x13724d4*/ string get_DllNotFoundExceptionErrorMessage();
        /*0x137259c*/ ErrorMessages();
    }

    class FirebaseException : System.Exception
    {
        /*0x8c*/ int <ErrorCode>k__BackingField;

        /*0x13726b0*/ FirebaseException();
        /*0x1372710*/ FirebaseException(int errorCode);
        /*0x137277c*/ FirebaseException(int errorCode, string message);
        /*0x13727f0*/ FirebaseException(int errorCode, string message, System.Exception inner);
        /*0x1372874*/ int get_ErrorCode();
        /*0x137287c*/ void set_ErrorCode(int value);
    }

    class InitializationException : System.Exception
    {
        /*0x8c*/ Firebase.InitResult <InitResult>k__BackingField;

        /*0x1372894*/ InitializationException(Firebase.InitResult result);
        /*0x1372900*/ InitializationException(Firebase.InitResult result, string message);
        /*0x1372974*/ InitializationException(Firebase.InitResult result, string message, System.Exception inner);
        /*0x1372884*/ Firebase.InitResult get_InitResult();
        /*0x137288c*/ void set_InitResult(Firebase.InitResult value);
    }

    class LogUtil : System.IDisposable
    {
        static /*0x0*/ Firebase.LogUtil _instance;
        static /*0x8*/ object InitializeLoggingLock;
        /*0x10*/ bool _disposed;

        static /*0x1372a9c*/ LogUtil();
        static /*0x1372c30*/ void InitializeLogging();
        static /*0x1372dc8*/ Firebase.Platform.PlatformLogLevel ConvertLogLevel(Firebase.LogLevel logLevel);
        static /*0x1372dd4*/ void LogMessage(Firebase.LogLevel logLevel, string message);
        static /*0x13729f8*/ void LogMessageFromCallback(Firebase.LogLevel logLevel, string message);
        /*0x1372b3c*/ LogUtil();
        /*0x1372fe0*/ void Finalize();
        /*0x13730b0*/ void Dispose();
        /*0x1373088*/ void Dispose(bool disposing);
        /*0x1373120*/ void <.ctor>b__9_0(object sender, System.EventArgs e);

        class LogMessageDelegate : System.MulticastDelegate
        {
            /*0x1372e68*/ LogMessageDelegate(object object, nint method);
            /*0x1373148*/ void Invoke(Firebase.LogLevel log_level, string message);
            /*0x137315c*/ System.IAsyncResult BeginInvoke(Firebase.LogLevel log_level, string message, System.AsyncCallback callback, object object);
            /*0x13731ec*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class VariantExtension
    {
        static Firebase.VariantExtension.KeyOptions DefaultKeyOptions = 0;

        static /*0x13731f8*/ object ToObject(Firebase.Variant variant);
        static /*0x1373200*/ object ToObject(Firebase.Variant variant, Firebase.VariantExtension.KeyOptions options);
        static /*0x1373280*/ object ToObjectInternal(Firebase.Variant variant, Firebase.VariantExtension.KeyOptions options);
        static /*0x13746a4*/ System.Collections.Generic.IDictionary<string, object> ToStringVariantMap(Firebase.VariantVariantMap originalMap);
        static /*0x137401c*/ System.Collections.Generic.IDictionary<string, object> ToStringVariantMap(Firebase.VariantVariantMap originalMap, Firebase.VariantExtension.KeyOptions options);

        enum KeyOptions
        {
            UseObjectKeys = 0,
            UseStringKeys = 1,
        }
    }

    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x1374964*/ MonoPInvokeCallbackAttribute(System.Type t);
    }

    enum FutureStatus
    {
        Complete = 0,
        Pending = 1,
        Invalid = 2,
    }

    class FutureBase : System.IDisposable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x13749c0*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.FutureBase obj);
        /*0x137496c*/ FutureBase(nint cPtr, bool cMemoryOwn);
        /*0x1374d80*/ FutureBase();
        /*0x13750cc*/ FutureBase(Firebase.FutureBase rhs);
        /*0x1374a38*/ void Finalize();
        /*0x1374ad8*/ void Dispose();
        /*0x1374b44*/ void Dispose(bool disposing);
        /*0x137525c*/ void Release();
        /*0x1375394*/ Firebase.FutureStatus status();
        /*0x13754d8*/ int error();
        /*0x137561c*/ string error_message();
    }

    class StringStringMap : System.IDisposable, System.Collections.Generic.IDictionary<string, string>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x13757cc*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.StringStringMap obj);
        /*0x1375778*/ StringStringMap(nint cPtr, bool cMemoryOwn);
        /*0x137700c*/ StringStringMap();
        /*0x1377164*/ StringStringMap(Firebase.StringStringMap other);
        /*0x1375844*/ void Finalize();
        /*0x13758e8*/ void Dispose();
        /*0x1375958*/ void Dispose(bool disposing);
        /*0x1375b94*/ string get_Item(string key);
        /*0x1375c70*/ void set_Item(string key, string value);
        /*0x1375d48*/ bool TryGetValue(string key, ref string value);
        /*0x1375e6c*/ int get_Count();
        /*0x1375f38*/ bool get_IsReadOnly();
        /*0x1375f40*/ System.Collections.Generic.ICollection<string> get_Keys();
        /*0x13762f0*/ System.Collections.Generic.ICollection<string> get_Values();
        /*0x1376830*/ void Add(System.Collections.Generic.KeyValuePair<string, string> item);
        /*0x1376964*/ bool Remove(System.Collections.Generic.KeyValuePair<string, string> item);
        /*0x13769dc*/ bool Contains(System.Collections.Generic.KeyValuePair<string, string> item);
        /*0x1376b1c*/ void CopyTo(System.Collections.Generic.KeyValuePair<string, string> array);
        /*0x1376b24*/ void CopyTo(System.Collections.Generic.KeyValuePair<string, string> array, int arrayIndex);
        /*0x1376e90*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator();
        /*0x1376fac*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x137654c*/ Firebase.StringStringMap.StringStringMapEnumerator GetEnumerator();
        /*0x1375e70*/ uint size();
        /*0x1377370*/ bool empty();
        /*0x13774bc*/ void Clear();
        /*0x1375b98*/ string getitem(string key);
        /*0x1375c74*/ void setitem(string key, string x);
        /*0x1375d94*/ bool ContainsKey(string key);
        /*0x1376890*/ void Add(string key, string value);
        /*0x1376a44*/ bool Remove(string key);
        /*0x1376084*/ nint create_iterator_begin();
        /*0x137614c*/ string get_next_key(nint swigiterator);
        /*0x1376224*/ void destroy_iterator(nint swigiterator);

        class StringStringMapEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable
        {
            /*0x10*/ Firebase.StringStringMap collectionRef;
            /*0x18*/ System.Collections.Generic.IList<string> keyCollection;
            /*0x20*/ int currentIndex;
            /*0x28*/ object currentObject;
            /*0x30*/ int currentSize;

            /*0x1376ef0*/ StringStringMapEnumerator(Firebase.StringStringMap collection);
            /*0x13765ac*/ System.Collections.Generic.KeyValuePair<string, string> get_Current();
            /*0x1377b00*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x13766cc*/ bool MoveNext();
            /*0x1377b64*/ void Reset();
            /*0x1377be8*/ void Dispose();
        }
    }

    class StringList : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IList<string>, System.Collections.Generic.ICollection<string>, System.Collections.Generic.IEnumerable<string>
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x1377c4c*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.StringList obj);
        static /*0x137a404*/ Firebase.StringList Repeat(string value, int count);
        /*0x1377bf8*/ StringList(nint cPtr, bool cMemoryOwn);
        /*0x1378014*/ StringList(System.Collections.IEnumerable c);
        /*0x137853c*/ StringList(System.Collections.Generic.IEnumerable<string> c);
        /*0x1378380*/ StringList();
        /*0x1379608*/ StringList(Firebase.StringList other);
        /*0x1379798*/ StringList(int capacity);
        /*0x1377cc4*/ void Finalize();
        /*0x1377d68*/ void Dispose();
        /*0x1377dd8*/ void Dispose(bool disposing);
        /*0x1378864*/ bool get_IsFixedSize();
        /*0x137886c*/ bool get_IsReadOnly();
        /*0x1378874*/ string get_Item(int index);
        /*0x1378950*/ void set_Item(int index, string value);
        /*0x1378a28*/ int get_Capacity();
        /*0x1378af4*/ void set_Capacity(int value);
        /*0x1378d08*/ int get_Count();
        /*0x1378d0c*/ bool get_IsSynchronized();
        /*0x1378d14*/ void CopyTo(string[] array);
        /*0x1378f5c*/ void CopyTo(string[] array, int arrayIndex);
        /*0x1378d48*/ void CopyTo(int index, string[] array, int arrayIndex, int count);
        /*0x137906c*/ string[] ToArray();
        /*0x13790ec*/ System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
        /*0x1379194*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x13791f4*/ Firebase.StringList.StringListEnumerator GetEnumerator();
        /*0x1379254*/ void Clear();
        /*0x1378470*/ void Add(string x);
        /*0x1378b74*/ uint size();
        /*0x1378a2c*/ uint capacity();
        /*0x1378c3c*/ void reserve(uint n);
        /*0x1378f94*/ string getitemcopy(int index);
        /*0x1378878*/ string getitem(int index);
        /*0x1378954*/ void setitem(int index, string val);
        /*0x1379af0*/ void AddRange(Firebase.StringList values);
        /*0x1379c54*/ Firebase.StringList GetRange(int index, int count);
        /*0x1379e54*/ void Insert(int index, string x);
        /*0x1379fcc*/ void InsertRange(int index, Firebase.StringList values);
        /*0x137a14c*/ void RemoveAt(int index);
        /*0x137a29c*/ void RemoveRange(int index, int count);
        /*0x137a5fc*/ void Reverse();
        /*0x137a734*/ void Reverse(int index, int count);
        /*0x137a89c*/ void SetRange(int index, Firebase.StringList values);
        /*0x137aa1c*/ bool Contains(string value);
        /*0x137ab98*/ int IndexOf(string value);
        /*0x137ad10*/ int LastIndexOf(string value);
        /*0x137ae88*/ bool Remove(string value);

        class StringListEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<string>, System.IDisposable
        {
            /*0x10*/ Firebase.StringList collectionRef;
            /*0x18*/ int currentIndex;
            /*0x20*/ object currentObject;
            /*0x28*/ int currentSize;

            /*0x137914c*/ StringListEnumerator(Firebase.StringList collection);
            /*0x137b004*/ string get_Current();
            /*0x137b110*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x137b114*/ bool MoveNext();
            /*0x137b178*/ void Reset();
            /*0x137b1fc*/ void Dispose();
        }
    }

    class CharVector : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IList<byte>, System.Collections.Generic.ICollection<byte>, System.Collections.Generic.IEnumerable<byte>
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x137b260*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.CharVector obj);
        static /*0x137da00*/ Firebase.CharVector Repeat(byte value, int count);
        /*0x137b20c*/ CharVector(nint cPtr, bool cMemoryOwn);
        /*0x137b628*/ CharVector(System.Collections.IEnumerable c);
        /*0x137bb58*/ CharVector(System.Collections.Generic.IEnumerable<byte> c);
        /*0x137b99c*/ CharVector();
        /*0x137cc54*/ CharVector(Firebase.CharVector other);
        /*0x137cde4*/ CharVector(int capacity);
        /*0x137b2d8*/ void Finalize();
        /*0x137b37c*/ void Dispose();
        /*0x137b3ec*/ void Dispose(bool disposing);
        /*0x137be80*/ bool get_IsFixedSize();
        /*0x137be88*/ bool get_IsReadOnly();
        /*0x137be90*/ byte get_Item(int index);
        /*0x137bf6c*/ void set_Item(int index, byte value);
        /*0x137c044*/ int get_Capacity();
        /*0x137c110*/ void set_Capacity(int value);
        /*0x137c324*/ int get_Count();
        /*0x137c328*/ bool get_IsSynchronized();
        /*0x137c330*/ void CopyTo(byte[] array);
        /*0x137c5bc*/ void CopyTo(byte[] array, int arrayIndex);
        /*0x137c364*/ void CopyTo(int index, byte[] array, int arrayIndex, int count);
        /*0x137c6cc*/ byte[] ToArray();
        /*0x137c74c*/ System.Collections.Generic.IEnumerator<byte> global::System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator();
        /*0x137c7f4*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x137c854*/ Firebase.CharVector.CharVectorEnumerator GetEnumerator();
        /*0x137c8b4*/ void Clear();
        /*0x137ba8c*/ void Add(byte x);
        /*0x137c190*/ uint size();
        /*0x137c048*/ uint capacity();
        /*0x137c258*/ void reserve(uint n);
        /*0x137c5f4*/ byte getitemcopy(int index);
        /*0x137be94*/ byte getitem(int index);
        /*0x137bf70*/ void setitem(int index, byte val);
        /*0x137d0fc*/ void AddRange(Firebase.CharVector values);
        /*0x137d260*/ Firebase.CharVector GetRange(int index, int count);
        /*0x137d460*/ void Insert(int index, byte x);
        /*0x137d5c8*/ void InsertRange(int index, Firebase.CharVector values);
        /*0x137d748*/ void RemoveAt(int index);
        /*0x137d898*/ void RemoveRange(int index, int count);
        /*0x137dbe0*/ void Reverse();
        /*0x137dd18*/ void Reverse(int index, int count);
        /*0x137de80*/ void SetRange(int index, Firebase.CharVector values);
        /*0x137e000*/ bool Contains(byte value);
        /*0x137e164*/ int IndexOf(byte value);
        /*0x137e2c0*/ int LastIndexOf(byte value);
        /*0x137e41c*/ bool Remove(byte value);

        class CharVectorEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<byte>, System.IDisposable
        {
            /*0x10*/ Firebase.CharVector collectionRef;
            /*0x18*/ int currentIndex;
            /*0x20*/ object currentObject;
            /*0x28*/ int currentSize;

            /*0x137c7ac*/ CharVectorEnumerator(Firebase.CharVector collection);
            /*0x137e580*/ byte get_Current();
            /*0x137e69c*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x137e700*/ bool MoveNext();
            /*0x137e7a4*/ void Reset();
            /*0x137e828*/ void Dispose();
        }
    }

    class FutureString : Firebase.FutureBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.FutureString.Action> Callbacks;
        static /*0x8*/ int CallbackIndex;
        static /*0x10*/ object CallbackLock;
        /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x38*/ nint callbackData;
        /*0x40*/ Firebase.FutureString.SWIG_CompletionDelegate SWIG_CompletionCB;

        static /*0x137fa58*/ FutureString();
        static /*0x137eb68*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.FutureString obj);
        static /*0x137ee84*/ System.Threading.Tasks.Task<string> GetTask(Firebase.FutureString fu);
        static /*0x137e838*/ void SWIG_CompletionDispatcher(int key);
        /*0x137e9f8*/ FutureString(nint cPtr, bool cMemoryOwn);
        /*0x137f6b8*/ FutureString();
        /*0x137ebe0*/ void Dispose(bool disposing);
        /*0x137f3a0*/ void ThrowIfDisposed();
        /*0x137f144*/ void SetOnCompletionCallback(Firebase.FutureString.Action userCompletionCallback);
        /*0x137edd8*/ void SetCompletionData(nint data);
        /*0x137f50c*/ nint SWIG_OnCompletion(Firebase.FutureString.SWIG_CompletionDelegate cs_callback, int cs_key);
        /*0x137f5ec*/ void SWIG_FreeCompletionData(nint data);
        /*0x137f8fc*/ string GetResult();

        class Action : System.MulticastDelegate
        {
            /*0x137f088*/ Action(object object, nint method);
            /*0x137fadc*/ void Invoke();
            /*0x137faf0*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x137fb10*/ void EndInvoke(System.IAsyncResult result);
        }

        class SWIG_CompletionDelegate : System.MulticastDelegate
        {
            /*0x137f448*/ SWIG_CompletionDelegate(object object, nint method);
            /*0x137fb1c*/ void Invoke(int index);
            /*0x137fb30*/ System.IAsyncResult BeginInvoke(int index, System.AsyncCallback callback, object object);
            /*0x137fbb4*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ Firebase.FutureString fu;
            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<string> tcs;

            /*0x137f080*/ <>c__DisplayClass4_0();
            /*0x137fbc0*/ void <GetTask>b__0();
        }
    }

    class FutureVoid : Firebase.FutureBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.FutureVoid.Action> Callbacks;
        static /*0x8*/ int CallbackIndex;
        static /*0x10*/ object CallbackLock;
        /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x38*/ nint callbackData;
        /*0x40*/ Firebase.FutureVoid.SWIG_CompletionDelegate SWIG_CompletionCB;

        static /*0x1380eac*/ FutureVoid();
        static /*0x1380118*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.FutureVoid obj);
        static /*0x1380434*/ System.Threading.Tasks.Task GetTask(Firebase.FutureVoid fu);
        static /*0x137fde8*/ void SWIG_CompletionDispatcher(int key);
        /*0x137ffa8*/ FutureVoid(nint cPtr, bool cMemoryOwn);
        /*0x1380c68*/ FutureVoid();
        /*0x1380190*/ void Dispose(bool disposing);
        /*0x1380950*/ void ThrowIfDisposed();
        /*0x13806f4*/ void SetOnCompletionCallback(Firebase.FutureVoid.Action userCompletionCallback);
        /*0x1380388*/ void SetCompletionData(nint data);
        /*0x1380abc*/ nint SWIG_OnCompletion(Firebase.FutureVoid.SWIG_CompletionDelegate cs_callback, int cs_key);
        /*0x1380b9c*/ void SWIG_FreeCompletionData(nint data);

        class Action : System.MulticastDelegate
        {
            /*0x1380638*/ Action(object object, nint method);
            /*0x1380f30*/ void Invoke();
            /*0x1380f44*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x1380f64*/ void EndInvoke(System.IAsyncResult result);
        }

        class SWIG_CompletionDelegate : System.MulticastDelegate
        {
            /*0x13809f8*/ SWIG_CompletionDelegate(object object, nint method);
            /*0x1380f70*/ void Invoke(int index);
            /*0x1380f84*/ System.IAsyncResult BeginInvoke(int index, System.AsyncCallback callback, object object);
            /*0x1381008*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ Firebase.FutureVoid fu;
            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<int> tcs;

            /*0x1380630*/ <>c__DisplayClass4_0();
            /*0x1381014*/ void <GetTask>b__0();
        }
    }

    class FutureBool : Firebase.FutureBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.FutureBool.Action> Callbacks;
        static /*0x8*/ int CallbackIndex;
        static /*0x10*/ object CallbackLock;
        /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x38*/ nint callbackData;
        /*0x40*/ Firebase.FutureBool.SWIG_CompletionDelegate SWIG_CompletionCB;

        static /*0x1382440*/ FutureBool();
        static /*0x1381560*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.FutureBool obj);
        static /*0x138187c*/ System.Threading.Tasks.Task<bool> GetTask(Firebase.FutureBool fu);
        static /*0x1381230*/ void SWIG_CompletionDispatcher(int key);
        /*0x13813f0*/ FutureBool(nint cPtr, bool cMemoryOwn);
        /*0x13820b0*/ FutureBool();
        /*0x13815d8*/ void Dispose(bool disposing);
        /*0x1381d98*/ void ThrowIfDisposed();
        /*0x1381b3c*/ void SetOnCompletionCallback(Firebase.FutureBool.Action userCompletionCallback);
        /*0x13817d0*/ void SetCompletionData(nint data);
        /*0x1381f04*/ nint SWIG_OnCompletion(Firebase.FutureBool.SWIG_CompletionDelegate cs_callback, int cs_key);
        /*0x1381fe4*/ void SWIG_FreeCompletionData(nint data);
        /*0x13822f4*/ bool GetResult();

        class Action : System.MulticastDelegate
        {
            /*0x1381a80*/ Action(object object, nint method);
            /*0x13824c4*/ void Invoke();
            /*0x13824d8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x13824f8*/ void EndInvoke(System.IAsyncResult result);
        }

        class SWIG_CompletionDelegate : System.MulticastDelegate
        {
            /*0x1381e40*/ SWIG_CompletionDelegate(object object, nint method);
            /*0x1382504*/ void Invoke(int index);
            /*0x1382518*/ System.IAsyncResult BeginInvoke(int index, System.AsyncCallback callback, object object);
            /*0x138259c*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ Firebase.FutureBool fu;
            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<bool> tcs;

            /*0x1381a78*/ <>c__DisplayClass4_0();
            /*0x13825a8*/ void <GetTask>b__0();
        }
    }

    enum InitResult
    {
        Success = 0,
        FailedMissingDependency = 1,
    }

    class AppOptionsInternal : System.IDisposable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x1382824*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.AppOptionsInternal obj);
        static /*0x1383084*/ Firebase.AppOptionsInternal LoadFromJsonConfig(string config, Firebase.AppOptionsInternal options);
        static /*0x138328c*/ Firebase.AppOptionsInternal LoadFromJsonConfig(string config);
        /*0x13827d0*/ AppOptionsInternal(nint cPtr, bool cMemoryOwn);
        /*0x1371e10*/ AppOptionsInternal();
        /*0x138289c*/ void Finalize();
        /*0x1382af4*/ void Dispose();
        /*0x1382934*/ void Dispose(bool disposing);
        /*0x13717ec*/ System.Uri get_DatabaseUrl();
        /*0x1371f00*/ void set_DatabaseUrl(System.Uri value);
        /*0x1382e24*/ void SetDatabaseUrlInternal(string url);
        /*0x1382bd4*/ string GetDatabaseUrlInternal();
        /*0x1371f6c*/ void set_AppId(string value);
        /*0x1371850*/ string get_AppId();
        /*0x1372038*/ void set_ApiKey(string value);
        /*0x1371918*/ string get_ApiKey();
        /*0x1372104*/ void set_MessageSenderId(string value);
        /*0x13719e0*/ string get_MessageSenderId();
        /*0x13721d0*/ void set_StorageBucket(string value);
        /*0x1371aa8*/ string get_StorageBucket();
        /*0x137229c*/ void set_ProjectId(string value);
        /*0x1371b70*/ string get_ProjectId();
        /*0x1372368*/ void set_PackageName(string value);
        /*0x1371c38*/ string get_PackageName();
    }

    class FirebaseApp : System.IDisposable
    {
        static int CheckDependenciesNoThread = -1;
        static int CheckDependenciesPendingThread = -2;
        static /*0x0*/ object disposeLock;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, Firebase.FirebaseApp> nameToProxy;
        static /*0x10*/ System.Collections.Generic.Dictionary<nint, Firebase.FirebaseApp> cPtrToProxy;
        static /*0x18*/ bool AppUtilCallbacksInitialized;
        static /*0x20*/ object AppUtilCallbacksLock;
        static /*0x28*/ bool PreventOnAllAppsDestroyed;
        static /*0x29*/ bool crashlyticsInitializationAttempted;
        static /*0x2c*/ int CheckDependenciesThread;
        static /*0x30*/ object CheckDependenciesThreadLock;
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;
        /*0x28*/ string name;
        /*0x30*/ System.EventHandler AppDisposed;
        /*0x38*/ Firebase.Platform.FirebaseAppPlatform appPlatform;

        static /*0x138415c*/ FirebaseApp();
        static /*0x1383bc8*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.FirebaseApp obj);
        static /*0x13842f0*/ void TranslateDllNotFoundException(System.Action closureToExecute);
        static /*0x1384444*/ Firebase.FirebaseApp get_DefaultInstance();
        static /*0x1384570*/ Firebase.FirebaseApp GetInstance(string name);
        static /*0x1384718*/ Firebase.FirebaseApp Create();
        static /*0x1385434*/ Firebase.FirebaseApp Create(Firebase.AppOptions options);
        static /*0x1385514*/ Firebase.FirebaseApp Create(Firebase.AppOptions options, string name);
        static /*0x13856d8*/ Firebase.LogLevel get_LogLevel();
        static /*0x138578c*/ void set_LogLevel(Firebase.LogLevel value);
        static /*0x1385b34*/ void DisposeAllApps();
        static /*0x1386308*/ void InitializeAppUtilCallbacks();
        static /*0x1386174*/ void OnAllAppsDestroyed();
        static /*0x1382c9c*/ System.Uri UrlStringToUri(string urlString);
        static /*0x1382d8c*/ string UriToUrlString(System.Uri uri);
        static /*0x1387104*/ object WeakReferenceGetTarget(System.WeakReference weakReference);
        static /*0x1387194*/ bool InitializeCrashlyticsIfPresent();
        static /*0x1384a6c*/ Firebase.FirebaseApp CreateAndTrack(Firebase.FirebaseApp.CreateDelegate createDelegate, Firebase.FirebaseApp existingProxy);
        static /*0x1387738*/ void SetCheckDependenciesThread(int threadId);
        static /*0x1384814*/ void ThrowIfCheckDependenciesRunning();
        static /*0x138763c*/ bool IsCheckDependenciesRunning();
        static /*0x138792c*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync();
        static /*0x1387ac8*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync();
        static /*0x1387c10*/ Firebase.DependencyStatus CheckDependencies();
        static /*0x1387cec*/ Firebase.DependencyStatus CheckDependenciesInternal();
        static /*0x1387f44*/ System.Threading.Tasks.Task FixDependenciesAsync();
        static /*0x1388020*/ void ResetDefaultAppCPtr();
        static /*0x1388510*/ System.Threading.SynchronizationContext get_ThreadSynchronizationContext();
        static /*0x1388980*/ Firebase.FirebaseApp CreateInternal();
        static /*0x1388ac4*/ Firebase.FirebaseApp CreateInternal(Firebase.AppOptionsInternal options);
        static /*0x1388ca0*/ Firebase.FirebaseApp CreateInternal(Firebase.AppOptionsInternal options, string name);
        static /*0x1386088*/ void ReleaseReferenceInternal(Firebase.FirebaseApp app);
        static /*0x1388f2c*/ void SetLogLevelInternal(Firebase.LogLevel level);
        static /*0x1388fe0*/ Firebase.LogLevel GetLogLevelInternal();
        static /*0x1387538*/ void RegisterLibraryInternal(string library, string version);
        static /*0x1387444*/ void AppSetDefaultConfigPath(string path);
        static /*0x13844b8*/ string get_DefaultName();
        /*0x1383b70*/ FirebaseApp(nint cPtr, bool cMemoryOwn);
        /*0x1383c40*/ void Finalize();
        /*0x1383d6c*/ void Dispose();
        /*0x1383cd8*/ void Dispose(bool disposing);
        /*0x1385604*/ string get_Name();
        /*0x138585c*/ void add_AppDisposed(System.EventHandler value);
        /*0x13858f8*/ void remove_AppDisposed(System.EventHandler value);
        /*0x1385994*/ bool get_IsDataCollectionDefaultEnabled();
        /*0x1385a60*/ void set_IsDataCollectionDefaultEnabled(bool value);
        /*0x1385efc*/ void AddReference();
        /*0x1383e98*/ void RemoveReference();
        /*0x1385630*/ void ThrowIfNull();
        /*0x1388374*/ Firebase.AppOptions get_Options();
        /*0x13885a8*/ Firebase.Platform.FirebaseAppPlatform get_AppPlatform();
        /*0x13883ec*/ Firebase.AppOptionsInternal options();
        /*0x1385a68*/ void SetDataCollectionDefaultEnabledInternal(bool enabled);
        /*0x1385998*/ bool IsDataCollectionDefaultEnabledInternal();
        /*0x1383dd0*/ string get_NameInternal();

        class EnableModuleParams
        {
            /*0x10*/ string <CppModuleName>k__BackingField;
            /*0x18*/ string <CSharpClassName>k__BackingField;
            /*0x20*/ bool <AlwaysEnable>k__BackingField;

            /*0x1386e8c*/ EnableModuleParams(string csharp, string cpp, bool always);
            /*0x1389258*/ string get_CppModuleName();
            /*0x1389260*/ void set_CppModuleName(string value);
            /*0x1389268*/ string get_CSharpClassName();
            /*0x1389270*/ void set_CSharpClassName(string value);
            /*0x1389278*/ bool get_AlwaysEnable();
            /*0x1389280*/ void set_AlwaysEnable(bool value);
        }

        class CreateDelegate : System.MulticastDelegate
        {
            /*0x13849b0*/ CreateDelegate(object object, nint method);
            /*0x138928c*/ Firebase.FirebaseApp Invoke();
            /*0x13892a0*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x13892c0*/ Firebase.FirebaseApp EndInvoke(System.IAsyncResult result);
        }

        class <>c
        {
            static /*0x0*/ Firebase.FirebaseApp.<> <>9;
            static /*0x8*/ Firebase.FirebaseApp.CreateDelegate <>9__14_0;
            static /*0x10*/ System.Func<bool> <>9__46_0;
            static /*0x18*/ System.Func<Firebase.DependencyStatus> <>9__54_0;
            static /*0x20*/ System.Func<System.Threading.Tasks.Task, System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__55_1;
            static /*0x28*/ System.Func<System.Threading.Tasks.Task<Firebase.DependencyStatus>, System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__55_0;
            static /*0x30*/ System.Action<System.Threading.Tasks.Task> <>9__58_1;

            static /*0x13892cc*/ <>c();
            /*0x1389330*/ <>c();
            /*0x1389338*/ Firebase.FirebaseApp <Create>b__14_0();
            /*0x1389384*/ bool <CreateAndTrack>b__46_0();
            /*0x13893d0*/ Firebase.DependencyStatus <CheckDependenciesAsync>b__54_0();
            /*0x1389450*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__55_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask);
            /*0x13895d8*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__55_1(System.Threading.Tasks.Task t);
            /*0x1389624*/ void <FixDependenciesAsync>b__58_1(System.Threading.Tasks.Task t);
        }

        class <>c__DisplayClass15_0
        {
            /*0x10*/ Firebase.AppOptions options;

            /*0x138550c*/ <>c__DisplayClass15_0();
            /*0x13896bc*/ Firebase.FirebaseApp <Create>b__0();
        }

        class <>c__DisplayClass16_0
        {
            /*0x10*/ Firebase.AppOptions options;
            /*0x18*/ string name;

            /*0x13855fc*/ <>c__DisplayClass16_0();
            /*0x1389728*/ Firebase.FirebaseApp <Create>b__0();
        }

        class <>c__DisplayClass56_0
        {
            /*0x10*/ Firebase.DependencyStatus status;

            /*0x1387ce4*/ <>c__DisplayClass56_0();
            /*0x138979c*/ void <CheckDependencies>b__0();
        }

        class <>c__DisplayClass58_0
        {
            /*0x10*/ System.Threading.Tasks.Task task;

            /*0x1388018*/ <>c__DisplayClass58_0();
            /*0x13897f4*/ void <FixDependenciesAsync>b__0();
        }
    }

    enum LogLevel
    {
        Verbose = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        Error = 4,
        Assert = 5,
    }

    enum GooglePlayServicesAvailability
    {
        AvailabilityAvailable = 0,
        AvailabilityUnavailableDisabled = 1,
        AvailabilityUnavailableInvalid = 2,
        AvailabilityUnavailableMissing = 3,
        AvailabilityUnavailablePermissions = 4,
        AvailabilityUnavailableUpdateRequired = 5,
        AvailabilityUnavailableUpdating = 6,
        AvailabilityUnavailableOther = 7,
    }

    class VariantVariantMap : System.IDisposable, System.Collections.Generic.IDictionary<Firebase.Variant, Firebase.Variant>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>>, System.Collections.IEnumerable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x13899ec*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.VariantVariantMap obj);
        /*0x1389998*/ VariantVariantMap(nint cPtr, bool cMemoryOwn);
        /*0x138b09c*/ VariantVariantMap();
        /*0x138b1f4*/ VariantVariantMap(Firebase.VariantVariantMap other);
        /*0x1389a64*/ void Finalize();
        /*0x1389b08*/ void Dispose();
        /*0x1389b78*/ void Dispose(bool disposing);
        /*0x1389db4*/ Firebase.Variant get_Item(Firebase.Variant key);
        /*0x1389f00*/ void set_Item(Firebase.Variant key, Firebase.Variant value);
        /*0x138a008*/ bool TryGetValue(Firebase.Variant key, ref Firebase.Variant value);
        /*0x138a140*/ int get_Count();
        /*0x138a20c*/ bool get_IsReadOnly();
        /*0x138a214*/ System.Collections.Generic.ICollection<Firebase.Variant> get_Keys();
        /*0x138a620*/ System.Collections.Generic.ICollection<Firebase.Variant> get_Values();
        /*0x138a87c*/ void Add(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> item);
        /*0x138a9e0*/ bool Remove(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> item);
        /*0x138aa58*/ bool Contains(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> item);
        /*0x138abac*/ void CopyTo(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> array);
        /*0x138abb4*/ void CopyTo(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> array, int arrayIndex);
        /*0x138af20*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant>>.GetEnumerator();
        /*0x138b03c*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x1374310*/ Firebase.VariantVariantMap.VariantVariantMapEnumerator GetEnumerator();
        /*0x138a144*/ uint size();
        /*0x138b400*/ bool empty();
        /*0x138b54c*/ void Clear();
        /*0x1389db8*/ Firebase.Variant getitem(Firebase.Variant key);
        /*0x1389f04*/ void setitem(Firebase.Variant key, Firebase.Variant x);
        /*0x138a054*/ bool ContainsKey(Firebase.Variant key);
        /*0x138a8dc*/ void Add(Firebase.Variant key, Firebase.Variant value);
        /*0x138aac0*/ bool Remove(Firebase.Variant key);
        /*0x138a358*/ nint create_iterator_begin();
        /*0x138a420*/ Firebase.Variant get_next_key(nint swigiterator);
        /*0x138a554*/ void destroy_iterator(nint swigiterator);

        class VariantVariantMapEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>>, System.IDisposable
        {
            /*0x10*/ Firebase.VariantVariantMap collectionRef;
            /*0x18*/ System.Collections.Generic.IList<Firebase.Variant> keyCollection;
            /*0x20*/ int currentIndex;
            /*0x28*/ object currentObject;
            /*0x30*/ int currentSize;

            /*0x138af80*/ VariantVariantMapEnumerator(Firebase.VariantVariantMap collection);
            /*0x1374370*/ System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> get_Current();
            /*0x138bb98*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x1374490*/ bool MoveNext();
            /*0x138bbfc*/ void Reset();
            /*0x138bc80*/ void Dispose();
        }
    }

    class VariantList : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<Firebase.Variant>
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x138bce4*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.VariantList obj);
        static /*0x138e4ec*/ Firebase.VariantList Repeat(Firebase.Variant value, int count);
        /*0x138bc90*/ VariantList(nint cPtr, bool cMemoryOwn);
        /*0x138c0a4*/ VariantList(System.Collections.IEnumerable c);
        /*0x138c5fc*/ VariantList(System.Collections.Generic.IEnumerable<Firebase.Variant> c);
        /*0x138c42c*/ VariantList();
        /*0x138d72c*/ VariantList(Firebase.VariantList other);
        /*0x138d8bc*/ VariantList(int capacity);
        /*0x138bd5c*/ void Finalize();
        /*0x138bdfc*/ void Dispose();
        /*0x138be68*/ void Dispose(bool disposing);
        /*0x138c924*/ bool get_IsFixedSize();
        /*0x138c92c*/ bool get_IsReadOnly();
        /*0x138c934*/ Firebase.Variant get_Item(int index);
        /*0x138ca6c*/ void set_Item(int index, Firebase.Variant value);
        /*0x138cb60*/ int get_Capacity();
        /*0x138cc2c*/ void set_Capacity(int value);
        /*0x138ce40*/ int get_Count();
        /*0x138ce44*/ bool get_IsSynchronized();
        /*0x138ce4c*/ void CopyTo(Firebase.Variant[] array);
        /*0x138d094*/ void CopyTo(Firebase.Variant[] array, int arrayIndex);
        /*0x138ce80*/ void CopyTo(int index, Firebase.Variant[] array, int arrayIndex, int count);
        /*0x138d204*/ Firebase.Variant[] ToArray();
        /*0x138d284*/ System.Collections.Generic.IEnumerator<Firebase.Variant> global::System.Collections.Generic.IEnumerable<Firebase.Variant>.GetEnumerator();
        /*0x138d32c*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x1373d0c*/ Firebase.VariantList.VariantListEnumerator GetEnumerator();
        /*0x138d38c*/ void Clear();
        /*0x138c51c*/ void Add(Firebase.Variant x);
        /*0x138ccac*/ uint size();
        /*0x138cb64*/ uint capacity();
        /*0x138cd74*/ void reserve(uint n);
        /*0x138d0cc*/ Firebase.Variant getitemcopy(int index);
        /*0x138c938*/ Firebase.Variant getitem(int index);
        /*0x138ca70*/ void setitem(int index, Firebase.Variant val);
        /*0x138dbd0*/ void AddRange(Firebase.VariantList values);
        /*0x138dd34*/ Firebase.VariantList GetRange(int index, int count);
        /*0x138df34*/ void Insert(int index, Firebase.Variant x);
        /*0x138e0b4*/ void InsertRange(int index, Firebase.VariantList values);
        /*0x138e234*/ void RemoveAt(int index);
        /*0x138e384*/ void RemoveRange(int index, int count);
        /*0x138e6e0*/ void Reverse();
        /*0x138e818*/ void Reverse(int index, int count);
        /*0x138e980*/ void SetRange(int index, Firebase.VariantList values);

        class VariantListEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<Firebase.Variant>, System.IDisposable
        {
            /*0x10*/ Firebase.VariantList collectionRef;
            /*0x18*/ int currentIndex;
            /*0x20*/ object currentObject;
            /*0x28*/ int currentSize;

            /*0x138d2e4*/ VariantListEnumerator(Firebase.VariantList collection);
            /*0x1373d6c*/ Firebase.Variant get_Current();
            /*0x138eb00*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x1373e94*/ bool MoveNext();
            /*0x138eb04*/ void Reset();
            /*0x138eb88*/ void Dispose();
        }
    }

    class Variant : System.IDisposable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x138b684*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Variant obj);
        static /*0x138eee0*/ Firebase.Variant FromBlob(byte[] blob);
        static /*0x138f220*/ Firebase.Variant FromObject(object o);
        static /*0x138fc00*/ Firebase.Variant Null();
        static /*0x13901a0*/ Firebase.Variant EmptyVector();
        static /*0x13902b8*/ Firebase.Variant EmptyMap();
        static /*0x138ef70*/ Firebase.Variant EmptyMutableBlob(uint sizeBytes);
        static /*0x138fe38*/ Firebase.Variant FromInt64(long value);
        static /*0x138ff58*/ Firebase.Variant FromDouble(double value);
        static /*0x1390080*/ Firebase.Variant FromBool(bool value);
        static /*0x138fd18*/ Firebase.Variant FromString(string value);
        /*0x138b780*/ Variant(nint cPtr, bool cMemoryOwn);
        /*0x138eb98*/ void Finalize();
        /*0x138ec38*/ void Dispose();
        /*0x138eca4*/ void Dispose(bool disposing);
        /*0x13745f4*/ byte[] blob_as_bytes();
        /*0x13737fc*/ Firebase.Variant.Type type();
        /*0x13746ac*/ bool is_string();
        /*0x1374774*/ bool is_fundamental_type();
        /*0x137483c*/ Firebase.Variant AsString();
        /*0x138f158*/ uint blob_size();
        /*0x1373be8*/ Firebase.VariantList vector();
        /*0x1373ef8*/ Firebase.VariantVariantMap map();
        /*0x13738c4*/ long int64_value();
        /*0x137398c*/ double double_value();
        /*0x1373a58*/ bool bool_value();
        /*0x1373b20*/ string string_value();
        /*0x138f090*/ nint untyped_mutable_blob_data();

        enum Type
        {
            Null = 0,
            Int64 = 1,
            Double = 2,
            Bool = 3,
            StaticString = 4,
            MutableString = 5,
            Vector = 6,
            Map = 7,
            StaticBlob = 8,
            MutableBlob = 9,
        }
    }

    class AppUtilPINVOKE
    {
        static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper;
        static /*0x8*/ Firebase.AppUtilPINVOKE.SWIGStringHelper swigStringHelper;

        static /*0x1390d8c*/ AppUtilPINVOKE();
        static /*0x1390e4c*/ void ExportFix();
        static /*0x1374e70*/ nint new_FutureBase__SWIG_0();
        static /*0x1374d04*/ void delete_FutureBase(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13751e0*/ nint new_FutureBase__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1375318*/ void FutureBase_Release(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137545c*/ int FutureBase_status(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13755a0*/ int FutureBase_error(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13756e4*/ string FutureBase_error_message(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13770fc*/ nint new_StringStringMap__SWIG_0();
        static /*0x1377278*/ nint new_StringStringMap__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13772f4*/ uint StringStringMap_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1377438*/ bool StringStringMap_empty(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1377578*/ void StringStringMap_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13775f4*/ string StringStringMap_getitem(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x13776a4*/ void StringStringMap_setitem(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
        static /*0x1377760*/ bool StringStringMap_ContainsKey(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1377804*/ void StringStringMap_Add(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
        static /*0x13778c0*/ bool StringStringMap_Remove(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1377964*/ nint StringStringMap_create_iterator_begin(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13779e0*/ string StringStringMap_get_next_key(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x1377a7c*/ void StringStringMap_destroy_iterator(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x1375b18*/ void delete_StringStringMap(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1379310*/ void StringList_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137938c*/ void StringList_Add(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1379424*/ uint StringList_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13794a0*/ uint StringList_capacity(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137951c*/ void StringList_reserve(System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);
        static /*0x13795a0*/ nint new_StringList__SWIG_0();
        static /*0x137971c*/ nint new_StringList__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1379898*/ nint new_StringList__SWIG_2(int jarg1);
        static /*0x1379914*/ string StringList_getitemcopy(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x13799b0*/ string StringList_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x1379a4c*/ void StringList_setitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);
        static /*0x1379bd0*/ void StringList_AddRange(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x1379dc0*/ nint StringList_GetRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x1379f28*/ void StringList_Insert(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);
        static /*0x137a0bc*/ void StringList_InsertRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x137a218*/ void StringList_RemoveAt(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x137a370*/ void StringList_RemoveRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x137a560*/ nint StringList_Repeat(string jarg1, int jarg2);
        static /*0x137a6b8*/ void StringList_Reverse__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137a808*/ void StringList_Reverse__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x137a98c*/ void StringList_SetRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x137aaf4*/ bool StringList_Contains(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x137ac70*/ int StringList_IndexOf(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x137ade8*/ int StringList_LastIndexOf(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x137af60*/ bool StringList_Remove(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1377f98*/ void delete_StringList(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137c970*/ void CharVector_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137c9ec*/ void CharVector_Add(System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        static /*0x137ca70*/ uint CharVector_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137caec*/ uint CharVector_capacity(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137cb68*/ void CharVector_reserve(System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);
        static /*0x137cbec*/ nint new_CharVector__SWIG_0();
        static /*0x137cd68*/ nint new_CharVector__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137cee4*/ nint new_CharVector__SWIG_2(int jarg1);
        static /*0x137cf60*/ byte CharVector_getitemcopy(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x137cfe4*/ byte CharVector_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x137d068*/ void CharVector_setitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, byte jarg3);
        static /*0x137d1dc*/ void CharVector_AddRange(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x137d3cc*/ nint CharVector_GetRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x137d534*/ void CharVector_Insert(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, byte jarg3);
        static /*0x137d6b8*/ void CharVector_InsertRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x137d814*/ void CharVector_RemoveAt(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x137d96c*/ void CharVector_RemoveRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x137db5c*/ nint CharVector_Repeat(byte jarg1, int jarg2);
        static /*0x137dc9c*/ void CharVector_Reverse__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137ddec*/ void CharVector_Reverse__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x137df70*/ void CharVector_SetRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x137e0d8*/ bool CharVector_Contains(System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        static /*0x137e23c*/ int CharVector_IndexOf(System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        static /*0x137e398*/ int CharVector_LastIndexOf(System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        static /*0x137e4f4*/ bool CharVector_Remove(System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        static /*0x137b5ac*/ void delete_CharVector(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137f778*/ nint new_FutureString();
        static /*0x137f7e0*/ nint FutureString_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.FutureString.SWIG_CompletionDelegate jarg2, int jarg3);
        static /*0x137f878*/ void FutureString_SWIG_FreeCompletionData(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x137f9c4*/ string FutureString_GetResult(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137ee08*/ void delete_FutureString(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1380d28*/ nint new_FutureVoid();
        static /*0x1380d90*/ nint FutureVoid_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);
        static /*0x1380e28*/ void FutureVoid_SWIG_FreeCompletionData(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x13803b8*/ void delete_FutureVoid(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1382170*/ nint new_FutureBool();
        static /*0x13821d8*/ nint FutureBool_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.FutureBool.SWIG_CompletionDelegate jarg2, int jarg3);
        static /*0x1382270*/ void FutureBool_SWIG_FreeCompletionData(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x13823bc*/ bool FutureBool_GetResult(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1381800*/ void delete_FutureBool(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1382ef0*/ nint new_AppOptionsInternal();
        static /*0x1382f58*/ void AppOptionsInternal_SetDatabaseUrlInternal(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1382ff0*/ string AppOptionsInternal_GetDatabaseUrlInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13831f0*/ nint AppOptionsInternal_LoadFromJsonConfig__SWIG_0(string jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x13833d4*/ nint AppOptionsInternal_LoadFromJsonConfig__SWIG_1(string jarg1);
        static /*0x1383468*/ void AppOptionsInternal_AppId_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1383500*/ string AppOptionsInternal_AppId_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1383594*/ void AppOptionsInternal_ApiKey_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x138362c*/ string AppOptionsInternal_ApiKey_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13836c0*/ void AppOptionsInternal_MessageSenderId_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1383758*/ string AppOptionsInternal_MessageSenderId_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13837ec*/ void AppOptionsInternal_StorageBucket_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1383884*/ string AppOptionsInternal_StorageBucket_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1383918*/ void AppOptionsInternal_ProjectId_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x13839b0*/ string AppOptionsInternal_ProjectId_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1383a44*/ void AppOptionsInternal_PackageName_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1383adc*/ string AppOptionsInternal_PackageName_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1382b58*/ void delete_AppOptionsInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390eb0*/ void delete_FirebaseApp(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1388768*/ nint FirebaseApp_options(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13887e4*/ void FirebaseApp_SetDataCollectionDefaultEnabledInternal(System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);
        static /*0x1388868*/ bool FirebaseApp_IsDataCollectionDefaultEnabledInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13888ec*/ string FirebaseApp_NameInternal_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1388260*/ nint FirebaseApp_CreateInternal__SWIG_0();
        static /*0x1388c24*/ nint FirebaseApp_CreateInternal__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1388e10*/ nint FirebaseApp_CreateInternal__SWIG_2(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x1388eb0*/ void FirebaseApp_ReleaseReferenceInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13857e0*/ void FirebaseApp_SetLogLevelInternal(int jarg1);
        static /*0x1385724*/ int FirebaseApp_GetLogLevelInternal();
        static /*0x1389098*/ void FirebaseApp_RegisterLibraryInternal(string jarg1, string jarg2);
        static /*0x1389144*/ void FirebaseApp_AppSetDefaultConfigPath(string jarg1);
        static /*0x13891d0*/ string FirebaseApp_DefaultName_get();
        static /*0x1390f2c*/ void SetLogLevel(int jarg1);
        static /*0x1390fa8*/ int GetLogLevel();
        static /*0x1391010*/ void PollCallbacks();
        static /*0x1391074*/ void AppEnableLogCallback(bool jarg1);
        static /*0x13910f0*/ int AppGetLogLevel();
        static /*0x1391158*/ void SetEnabledAllAppCallbacks(bool jarg1);
        static /*0x13911d4*/ void SetEnabledAppCallbackByName(string jarg1, bool jarg2);
        static /*0x1391268*/ bool GetEnabledAppCallbackByName(string jarg1);
        static /*0x1391300*/ void SetLogFunction(Firebase.LogUtil.LogMessageDelegate jarg1);
        static /*0x1391380*/ nint AppOptionsLoadFromJsonConfig(string jarg1);
        static /*0x1391414*/ int CheckAndroidDependencies();
        static /*0x139147c*/ nint FixAndroidDependencies();
        static /*0x13914e4*/ void InitializePlayServicesInternal();
        static /*0x1391548*/ void TerminatePlayServicesInternal();
        static /*0x138b18c*/ nint new_VariantVariantMap__SWIG_0();
        static /*0x138b308*/ nint new_VariantVariantMap__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138b384*/ uint VariantVariantMap_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138b4c8*/ bool VariantVariantMap_empty(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138b608*/ void VariantVariantMap_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138b6fc*/ nint VariantVariantMap_getitem(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x138b7d4*/ void VariantVariantMap_setitem(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x138b868*/ bool VariantVariantMap_ContainsKey(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x138b8f4*/ void VariantVariantMap_Add(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x138b988*/ bool VariantVariantMap_Remove(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x138ba14*/ nint VariantVariantMap_create_iterator_begin(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138ba90*/ nint VariantVariantMap_get_next_key(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x138bb14*/ void VariantVariantMap_destroy_iterator(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x1389d38*/ void delete_VariantVariantMap(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138d448*/ void VariantList_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138d4c4*/ void VariantList_Add(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x138d548*/ uint VariantList_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138d5c4*/ uint VariantList_capacity(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138d640*/ void VariantList_reserve(System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);
        static /*0x138d6c4*/ nint new_VariantList__SWIG_0();
        static /*0x138d840*/ nint new_VariantList__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138d9bc*/ nint new_VariantList__SWIG_2(int jarg1);
        static /*0x138da38*/ nint VariantList_getitemcopy(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x138dabc*/ nint VariantList_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x138db40*/ void VariantList_setitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x138dcb0*/ void VariantList_AddRange(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x138dea0*/ nint VariantList_GetRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x138e024*/ void VariantList_Insert(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x138e1a4*/ void VariantList_InsertRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x138e300*/ void VariantList_RemoveAt(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x138e458*/ void VariantList_RemoveRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x138e65c*/ nint VariantList_Repeat(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x138e79c*/ void VariantList_Reverse__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138e8ec*/ void VariantList_Reverse__SWIG_1(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        static /*0x138ea70*/ void VariantList_SetRange(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x138c028*/ void delete_VariantList(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x138ee64*/ void delete_Variant(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13903d0*/ nint Variant_Null();
        static /*0x1390438*/ nint Variant_EmptyVector();
        static /*0x13904a0*/ nint Variant_EmptyMap();
        static /*0x1390508*/ nint Variant_EmptyMutableBlob(uint jarg1);
        static /*0x1390584*/ int Variant_type(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390600*/ bool Variant_is_string(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390684*/ bool Variant_is_fundamental_type(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390708*/ nint Variant_AsString(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390784*/ uint Variant_blob_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390800*/ nint Variant_vector__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x139087c*/ nint Variant_map__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13908f8*/ long Variant_int64_value(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390974*/ double Variant_double_value(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x13909f0*/ bool Variant_bool_value(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390a74*/ string Variant_string_value(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x1390b08*/ nint Variant_FromInt64(long jarg1);
        static /*0x1390b84*/ nint Variant_FromDouble(double jarg1);
        static /*0x1390c00*/ nint Variant_FromBool(bool jarg1);
        static /*0x1390c7c*/ nint Variant_FromString(string jarg1);
        static /*0x1390d10*/ nint Variant_untyped_mutable_blob_data(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x137eaec*/ nint FutureString_SWIGUpcast(nint jarg1);
        static /*0x138009c*/ nint FutureVoid_SWIGUpcast(nint jarg1);
        static /*0x13814e4*/ nint FutureBool_SWIGUpcast(nint jarg1);
        /*0x13915ac*/ AppUtilPINVOKE();

        class SWIGExceptionHelper
        {
            static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
            static /*0x8*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
            static /*0x10*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
            static /*0x18*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
            static /*0x20*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
            static /*0x28*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
            static /*0x30*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
            static /*0x38*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
            static /*0x40*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
            static /*0x48*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
            static /*0x50*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
            static /*0x58*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
            static /*0x60*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
            static /*0x68*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

            static /*0x13922c4*/ SWIGExceptionHelper();
            static /*0x1391eb4*/ void SWIGRegisterExceptionCallbacks_AppUtil(Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
            static /*0x1392020*/ void SWIGRegisterExceptionCallbacksArgument_AppUtil(Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
            static /*0x13915b4*/ void SetPendingApplicationException(string message);
            static /*0x139164c*/ void SetPendingArithmeticException(string message);
            static /*0x13916e4*/ void SetPendingDivideByZeroException(string message);
            static /*0x139177c*/ void SetPendingIndexOutOfRangeException(string message);
            static /*0x1391814*/ void SetPendingInvalidCastException(string message);
            static /*0x13918ac*/ void SetPendingInvalidOperationException(string message);
            static /*0x1391944*/ void SetPendingIOException(string message);
            static /*0x13919dc*/ void SetPendingNullReferenceException(string message);
            static /*0x1391a74*/ void SetPendingOutOfMemoryException(string message);
            static /*0x1391b0c*/ void SetPendingOverflowException(string message);
            static /*0x1391ba4*/ void SetPendingSystemException(string message);
            static /*0x1391c3c*/ void SetPendingArgumentException(string message, string paramName);
            static /*0x1391ce4*/ void SetPendingArgumentNullException(string message, string paramName);
            static /*0x1391dcc*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
            /*0x1390e3c*/ SWIGExceptionHelper();

            class ExceptionDelegate : System.MulticastDelegate
            {
                /*0x13926b0*/ ExceptionDelegate(object object, nint method);
                /*0x139285c*/ void Invoke(string message);
                /*0x1392870*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                /*0x1392890*/ void EndInvoke(System.IAsyncResult result);
            }

            class ExceptionArgumentDelegate : System.MulticastDelegate
            {
                /*0x1392784*/ ExceptionArgumentDelegate(object object, nint method);
                /*0x139289c*/ void Invoke(string message, string paramName);
                /*0x13928b0*/ System.IAsyncResult BeginInvoke(string message, string paramName, System.AsyncCallback callback, object object);
                /*0x13928d8*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class SWIGPendingException
        {
            static /*0x0*/ int numExceptionsPending;
            static /*0x8*/ object exceptionsLock;
            [ThreadStatic] static System.Exception pendingException;

            static /*0x13928e4*/ SWIGPendingException();
            static /*0x1374ed8*/ bool get_Pending();
            static /*0x13920d4*/ void Set(System.Exception e);
            static /*0x1374f60*/ System.Exception Retrieve();
            /*0x1392980*/ SWIGPendingException();
        }

        class SWIGStringHelper
        {
            static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

            static /*0x1392a0c*/ SWIGStringHelper();
            static /*0x139298c*/ void SWIGRegisterStringCallback_AppUtil(Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
            static /*0x1392988*/ string CreateString(string cString);
            /*0x1390e44*/ SWIGStringHelper();

            class SWIGStringDelegate : System.MulticastDelegate
            {
                /*0x1392aa8*/ SWIGStringDelegate(object object, nint method);
                /*0x1392b7c*/ string Invoke(string message);
                /*0x1392b90*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                /*0x1392bb0*/ string EndInvoke(System.IAsyncResult result);
            }
        }
    }

    class AppUtil
    {
        static /*0x1392bbc*/ void ExportFix();
        static /*0x1392c08*/ void SetLogLevel(Firebase.LogLevel level);
        static /*0x1392cbc*/ Firebase.LogLevel GetLogLevel();
        static /*0x1392d74*/ void PollCallbacks();
        static /*0x1372d14*/ void AppEnableLogCallback(bool arg0);
        static /*0x1392e20*/ Firebase.LogLevel AppGetLogLevel();
        static /*0x1386ecc*/ void SetEnabledAllAppCallbacks(bool arg0);
        static /*0x1387040*/ void SetEnabledAppCallbackByName(string arg0, bool arg1);
        static /*0x1386f80*/ bool GetEnabledAppCallbackByName(string arg0);
        static /*0x1372f2c*/ void SetLogFunction(Firebase.LogUtil.LogMessageDelegate arg0);
        static /*0x1371620*/ Firebase.AppOptionsInternal AppOptionsLoadFromJsonConfig(string config);
        static /*0x1387e8c*/ Firebase.GooglePlayServicesAvailability CheckAndroidDependencies();
        static /*0x13898f8*/ System.Threading.Tasks.Task FixAndroidDependenciesAsync();
        static /*0x13881b4*/ void InitializePlayServicesInternal();
        static /*0x13882c8*/ void TerminatePlayServicesInternal();
        /*0x1392ed8*/ AppUtil();
    }

    class VersionInfo
    {
        static /*0x13874f8*/ string get_SdkVersion();
        static /*0x13875fc*/ string get_BuildSource();
        /*0x1392ee0*/ VersionInfo();
    }

    namespace Platform
    {
        class FirebaseAppUtils : Firebase.Platform.IFirebaseAppUtils
        {
            static /*0x0*/ Firebase.Platform.FirebaseAppUtils instance;

            static /*0x13930e4*/ FirebaseAppUtils();
            static /*0x13873ec*/ Firebase.Platform.FirebaseAppUtils get_Instance();
            /*0x13930dc*/ FirebaseAppUtils();
            /*0x1392ee8*/ void TranslateDllNotFoundException(System.Action action);
            /*0x1392f3c*/ void PollCallbacks();
            /*0x1392f40*/ Firebase.Platform.IFirebaseAppPlatform GetDefaultInstance();
            /*0x1392f98*/ string GetDefaultInstanceName();
            /*0x1392fe4*/ Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        class FirebaseAppPlatform : Firebase.Platform.IFirebaseAppPlatform
        {
            /*0x10*/ System.WeakReference <app>k__BackingField;

            /*0x13886e8*/ FirebaseAppPlatform(Firebase.FirebaseApp wrappedApp);
            /*0x1393148*/ System.WeakReference get_app();
            /*0x1393150*/ void set_app(System.WeakReference value);
            /*0x1393158*/ object get_AppObject();
            /*0x13931f4*/ Firebase.FirebaseApp get_App();
            /*0x1393250*/ string get_Name();
            /*0x139326c*/ System.Uri get_DatabaseUrl();
        }
    }

    namespace Internal
    {
        class TaskCompletionSourceCompat<T>
        {
            static void SetExceptionInternal(System.Threading.Tasks.TaskCompletionSource<T> tcs, System.AggregateException exception);
            static void SetException(System.Threading.Tasks.TaskCompletionSource<T> tcs, System.AggregateException exception);
        }
    }
}
