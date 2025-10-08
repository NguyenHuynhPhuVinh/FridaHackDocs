class <Module>
{
}

namespace Firebase
{
    namespace Storage
    {
        class FirebaseStorage
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, Firebase.Storage.FirebaseStorage> storageByInstanceKey;
            static /*0x8*/ Firebase.Storage.Internal.ModuleLogger logger;
            static /*0x10*/ System.Reflection.FieldInfo pathFieldInfo;
            static /*0x18*/ System.Reflection.FieldInfo cachedToString;
            /*0x10*/ Firebase.Storage.FirebaseStorageInternal storageInternal;
            /*0x18*/ Firebase.FirebaseApp firebaseApp;
            /*0x20*/ string instanceKey;
            /*0x28*/ Firebase.Storage.Internal.ModuleLogger <Logger>k__BackingField;

            static /*0x2d4c750*/ FirebaseStorage();
            static /*0x2d4b9a0*/ Firebase.Storage.FirebaseStorage get_DefaultInstance();
            static /*0x2d4ba28*/ Firebase.Storage.FirebaseStorage GetInstance(Firebase.FirebaseApp app, string url);
            static /*0x2d4beb4*/ Firebase.Storage.FirebaseStorage FindByKey(string instanceKey);
            static /*0x2d4baf8*/ Firebase.Storage.FirebaseStorage GetInstanceInternal(Firebase.FirebaseApp app, string bucketUrl);
            /*0x2d4ace0*/ FirebaseStorage(Firebase.Storage.FirebaseStorageInternal storage, Firebase.FirebaseApp app);
            /*0x2d4b510*/ void Finalize();
            /*0x2d4b5f8*/ void Dispose();
            /*0x2d4b8c8*/ void OnAppDisposed(object sender, System.EventArgs eventArgs);
            /*0x2d4b940*/ void ThrowIfNull();
            /*0x2d4b990*/ Firebase.Storage.Internal.ModuleLogger get_Logger();
            /*0x2d4b998*/ void set_Logger(Firebase.Storage.Internal.ModuleLogger value);
            /*0x2d4c26c*/ Firebase.Storage.StorageReferenceInternal ValidateStorageReferenceInternal(Firebase.Storage.StorageReferenceInternal reference, string message);
            /*0x2d4c3a4*/ Firebase.Storage.StorageReference GetReferenceFromUrl(string fullUrl);
        }

        class MetadataChange
        {
            /*0x10*/ Firebase.Storage.StorageMetadata metadata;

            static /*0x2d4ca20*/ Firebase.Storage.StorageMetadata Build(Firebase.Storage.MetadataChange metadataChange);
            /*0x2d4c850*/ MetadataChange();
            /*0x2d4c970*/ Firebase.Storage.StorageMetadata Build();
            /*0x2d4ca2c*/ void set_ContentType(string value);
        }

        class StorageMetadata
        {
            static /*0x0*/ System.DateTime UnixEpoch;
            /*0x10*/ Firebase.Storage.StorageReference storageReference;
            /*0x18*/ Firebase.Storage.MetadataInternal <Internal>k__BackingField;

            static /*0x2d4cc58*/ StorageMetadata();
            static /*0x2d4cbd8*/ Firebase.Storage.MetadataInternal GetMetadataInternal(Firebase.Storage.StorageMetadata metadata);
            static /*0x2d4cbe4*/ Firebase.Storage.MetadataInternal BuildMetadataInternal(Firebase.Storage.MetadataChange metadataChange);
            /*0x2d4c8b8*/ StorageMetadata();
            /*0x2d4cb4c*/ StorageMetadata(Firebase.Storage.StorageReference reference, Firebase.Storage.MetadataInternal metadata);
            /*0x2d4c9cc*/ StorageMetadata(Firebase.Storage.StorageMetadata metadataToCopy);
            /*0x2d4cbc8*/ Firebase.Storage.MetadataInternal get_Internal();
            /*0x2d4cbd0*/ void set_Internal(Firebase.Storage.MetadataInternal value);
        }

        class StorageException : System.Exception
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<Firebase.Storage.ErrorInternal, System.Tuple<int, System.Net.HttpStatusCode>> errorToStorageErrorAndHttpStatusCode;
            static /*0x8*/ System.Tuple<int, System.Net.HttpStatusCode> unknownError;
            /*0x8c*/ int <ErrorCode>k__BackingField;
            /*0x90*/ int <HttpResultCode>k__BackingField;

            static /*0x2d4d418*/ StorageException();
            static /*0x2d4cf40*/ Firebase.Storage.StorageException CreateFromException(System.Exception exception);
            static /*0x2d4cd8c*/ string GetErrorMessageForCode(int errorCode);
            /*0x2d4ccd4*/ StorageException(int errorCode, int httpResultCode, string errorMessage);
            /*0x2d4d400*/ int get_ErrorCode();
            /*0x2d4d408*/ void set_ErrorCode(int value);
            /*0x2d4d410*/ void set_HttpResultCode(int value);
        }

        class StorageReference
        {
            /*0x10*/ Firebase.Storage.FirebaseStorage firebaseStorage;
            /*0x18*/ Firebase.Storage.Internal.ModuleLogger <Logger>k__BackingField;
            /*0x20*/ Firebase.Storage.StorageReferenceInternal <Internal>k__BackingField;

            /*0x2d4c654*/ StorageReference(Firebase.Storage.FirebaseStorage storage, Firebase.Storage.StorageReferenceInternal storageReferenceInternal);
            /*0x2d4d7cc*/ Firebase.Storage.Internal.ModuleLogger get_Logger();
            /*0x2d4d7d4*/ void set_Logger(Firebase.Storage.Internal.ModuleLogger value);
            /*0x2d4d7dc*/ string get_Path();
            /*0x2d4d8c0*/ string get_Bucket();
            /*0x2d4d9a4*/ System.Threading.Tasks.Task<Firebase.Storage.StorageMetadata> PutBytesAsync(byte[] bytes, Firebase.Storage.MetadataChange customMetadata, System.IProgress<Firebase.Storage.UploadState> progressHandler, System.Threading.CancellationToken cancelToken, System.Uri previousSessionUri);
            /*0x2d4dcd8*/ System.Threading.Tasks.Task<Firebase.Storage.MetadataInternal> PutBytesUsingMonitorControllerAsync(nint buffer, uint bufferSize, Firebase.Storage.MetadataInternal metadata, Firebase.Storage.MonitorControllerInternal monitorController, System.Threading.CancellationToken cancellationToken);
            /*0x2d4da4c*/ System.Threading.Tasks.Task<Firebase.Storage.StorageMetadata> PutBytesUsingCompletionSourceAsync(byte[] bytes, Firebase.Storage.MetadataChange customMetadata, System.IProgress<Firebase.Storage.UploadState> progressHandler, System.Threading.CancellationToken cancelToken, System.Uri previousSessionUri, System.Threading.Tasks.TaskCompletionSource<Firebase.Storage.StorageMetadata> completionSource);
            /*0x2d4e134*/ string ToString();
            /*0x2d4e1ac*/ bool Equals(object other);
            /*0x2d4e248*/ int GetHashCode();
            /*0x2d4e270*/ Firebase.Storage.StorageReferenceInternal get_Internal();
            /*0x2d4e278*/ void set_Internal(Firebase.Storage.StorageReferenceInternal value);
            /*0x1ffc854*/ O CompleteTask<I, O>(System.Threading.Tasks.Task<I> task, System.Threading.Tasks.TaskCompletionSource<O> completionSource, System.Func<O> getResult, string operationDescription, bool setCompletionSourceResult);

            class TaskCompletionStatus
            {
                /*0x10*/ bool <IsSuccessful>k__BackingField;
                /*0x11*/ bool <IsCanceled>k__BackingField;
                /*0x18*/ System.Exception <Exception>k__BackingField;

                /*0x2d4e2b0*/ TaskCompletionStatus(System.Threading.Tasks.Task task, string operationDescription, Firebase.Storage.Internal.ModuleLogger logger);
                /*0x2d4e280*/ bool get_IsSuccessful();
                /*0x2d4e288*/ void set_IsSuccessful(bool value);
                /*0x2d4e290*/ bool get_IsCanceled();
                /*0x2d4e298*/ void set_IsCanceled(bool value);
                /*0x2d4e2a0*/ System.Exception get_Exception();
                /*0x2d4e2a8*/ void set_Exception(System.Exception value);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ Firebase.Storage.MonitorControllerInternal monitorController;
                /*0x18*/ Firebase.Storage.MetadataInternal metadata;

                /*0x2d4de40*/ <>c__DisplayClass21_0();
                /*0x2d4e550*/ System.Threading.Tasks.Task<Firebase.Storage.MetadataInternal> <PutBytesUsingMonitorControllerAsync>b__0(System.Threading.Tasks.Task<Firebase.Storage.MetadataInternal> completedTask);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ System.Runtime.InteropServices.GCHandle bytesHandle;
                /*0x18*/ Firebase.Storage.StorageReference <>4__this;
                /*0x20*/ System.Threading.Tasks.TaskCompletionSource<Firebase.Storage.StorageMetadata> completionSource;
                /*0x28*/ Firebase.Storage.Internal.TransferStateUpdater<Firebase.Storage.UploadState> transferStateUpdater;

                /*0x2d4e09c*/ <>c__DisplayClass22_0();
                /*0x2d4e664*/ void <PutBytesUsingCompletionSourceAsync>b__0(System.Threading.Tasks.Task<Firebase.Storage.MetadataInternal> task);
            }

            class <>c__DisplayClass22_1
            {
                /*0x10*/ System.Threading.Tasks.Task<Firebase.Storage.MetadataInternal> task;
                /*0x18*/ Firebase.Storage.StorageReference.<> CS$<>8__locals1;

                /*0x2d4e7a0*/ <>c__DisplayClass22_1();
                /*0x2d4e7a8*/ Firebase.Storage.StorageMetadata <PutBytesUsingCompletionSourceAsync>b__1();
            }
        }

        class UploadState
        {
            /*0x10*/ Firebase.Storage.Internal.TransferState <State>k__BackingField;

            /*0x2d4e0a4*/ UploadState(Firebase.Storage.StorageReference reference, long totalByteCount);
            /*0x2d4e8a8*/ Firebase.Storage.Internal.TransferState get_State();
            /*0x2d4e8b0*/ void set_State(Firebase.Storage.Internal.TransferState value);
        }

        class Future_StorageMetadata : Firebase.FutureBase
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.Storage.Future_StorageMetadata.Action> Callbacks;
            static /*0x8*/ int CallbackIndex;
            static /*0x10*/ object CallbackLock;
            /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x38*/ nint callbackData;
            /*0x40*/ Firebase.Storage.Future_StorageMetadata.SWIG_CompletionDelegate SWIG_CompletionCB;

            static /*0x2d4fc90*/ Future_StorageMetadata();
            static /*0x2d4efac*/ System.Threading.Tasks.Task<Firebase.Storage.MetadataInternal> GetTask(Firebase.Storage.Future_StorageMetadata fu);
            static /*0x2d4e8b8*/ void SWIG_CompletionDispatcher(int key);
            static /*0x2d4f8dc*/ void SWIG_FreeCompletionData(nint data);
            /*0x2d4eaac*/ Future_StorageMetadata(nint cPtr, bool cMemoryOwn);
            /*0x2d4ebec*/ void Dispose(bool disposing);
            /*0x2d4f6fc*/ void ThrowIfDisposed();
            /*0x2d4f488*/ void SetOnCompletionCallback(Firebase.Storage.Future_StorageMetadata.Action userCompletionCallback);
            /*0x2d4edc4*/ void SetCompletionData(nint data);
            /*0x2d4f7f4*/ nint SWIG_OnCompletion(Firebase.Storage.Future_StorageMetadata.SWIG_CompletionDelegate cs_callback, int cs_key);
            /*0x2d4fab0*/ Firebase.Storage.MetadataInternal GetResult();

            class Action : System.MulticastDelegate
            {
                /*0x2d4f3ec*/ Action(object object, nint method);
                /*0x2d4fd10*/ void Invoke();
            }

            class SWIG_CompletionDelegate : System.MulticastDelegate
            {
                /*0x2d4f754*/ SWIG_CompletionDelegate(object object, nint method);
                /*0x2d4fd24*/ void Invoke(int index);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ Firebase.Storage.Future_StorageMetadata fu;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<Firebase.Storage.MetadataInternal> tcs;

                /*0x2d4f1cc*/ <>c__DisplayClass5_0();
                /*0x2d4fd38*/ void <GetTask>b__0();
            }
        }

        enum ErrorInternal
        {
            ErrorNone = 0,
            ErrorUnknown = 1,
            ErrorObjectNotFound = 2,
            ErrorBucketNotFound = 3,
            ErrorProjectNotFound = 4,
            ErrorQuotaExceeded = 5,
            ErrorUnauthenticated = 6,
            ErrorUnauthorized = 7,
            ErrorRetryLimitExceeded = 8,
            ErrorNonMatchingChecksum = 9,
            ErrorDownloadSizeExceeded = 10,
            ErrorCancelled = 11,
        }

        class ControllerInternal : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            /*0x2d4ff6c*/ ControllerInternal(nint cPtr, bool cMemoryOwn);
            /*0x2d4ffcc*/ void Finalize();
            /*0x2d5005c*/ void Dispose();
            /*0x2d500c8*/ void Dispose(bool disposing);
            /*0x2d502f0*/ bool Cancel();
        }

        class MetadataInternal : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;
            /*0x28*/ Firebase.Storage.FirebaseStorage storage;

            static /*0x2d50444*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Storage.MetadataInternal obj);
            /*0x2d4fc30*/ MetadataInternal(nint cPtr, bool cMemoryOwn);
            /*0x2d4cb20*/ MetadataInternal(Firebase.Storage.FirebaseStorage storage);
            /*0x2d50740*/ MetadataInternal();
            /*0x2d50488*/ void Finalize();
            /*0x2d4e5f8*/ void Dispose();
            /*0x2d50518*/ void Dispose(bool disposing);
            /*0x2d4cb90*/ Firebase.Storage.MetadataInternal Copy();
            /*0x2d4ca4c*/ void set_ContentType(string value);
            /*0x2d50808*/ Firebase.Storage.MetadataInternal CopyCppObject();
        }

        class StorageReferenceInternal : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2d50ae4*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Storage.StorageReferenceInternal obj);
            /*0x2d50a84*/ StorageReferenceInternal(nint cPtr, bool cMemoryOwn);
            /*0x2d50e4c*/ StorageReferenceInternal();
            /*0x2d50b28*/ void Finalize();
            /*0x2d50bb8*/ void Dispose();
            /*0x2d50c24*/ void Dispose(bool disposing);
            /*0x2d4d8d4*/ string get_Bucket();
            /*0x2d4d7f0*/ string get_FullPath();
            /*0x2d4c2d4*/ bool get_IsValid();
            /*0x2d4de48*/ System.Threading.Tasks.Task<Firebase.Storage.MetadataInternal> PutBytesUsingMonitorControllerAsync(nint buffer, uint buffer_size, Firebase.Storage.MetadataInternal metadata, Firebase.Storage.MonitorControllerInternal monitor_controller);
        }

        class MonitorControllerInternal : System.IDisposable
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<nint, System.WeakReference> cPtrsToProxies;
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;
            /*0x28*/ System.EventHandler<System.EventArgs> Paused;
            /*0x30*/ System.EventHandler<System.EventArgs> Progress;
            /*0x38*/ System.Action forwardToPausedEvent;
            /*0x40*/ System.Action forwardToProgressEvent;
            /*0x48*/ Firebase.Storage.StorageReferenceInternal storageReference;

            static /*0x2d52794*/ MonitorControllerInternal();
            static /*0x2d51124*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Storage.MonitorControllerInternal obj);
            static /*0x2d51914*/ Firebase.Storage.MonitorControllerInternal Create(Firebase.Storage.StorageReferenceInternal storageReference);
            static /*0x2d51214*/ void OnPaused(nint controllerPtr);
            static /*0x2d512c0*/ void OnProgress(nint controllerPtr);
            static /*0x2d51fcc*/ Firebase.Storage.MonitorControllerInternal ProxyFromCPtr(nint controllerPtr);
            /*0x2d5136c*/ MonitorControllerInternal(nint cPtr, bool cMemoryOwn);
            /*0x2d51c78*/ MonitorControllerInternal(Firebase.Storage.StorageReferenceInternal storage_reference);
            /*0x2d513cc*/ void Finalize();
            /*0x2d4e58c*/ void Dispose();
            /*0x2d5145c*/ void Dispose(bool disposing);
            /*0x2d517b4*/ void add_Progress(System.EventHandler<System.EventArgs> value);
            /*0x2d51864*/ void remove_Progress(System.EventHandler<System.EventArgs> value);
            /*0x2d4dfe0*/ void RegisterCancellationToken(System.Threading.CancellationToken cancellationToken);
            /*0x2d51e04*/ void SetPausedEvent(Firebase.Storage.MonitorControllerInternal.MonitorControllerEventDelegate event_, nint event_data);
            /*0x2d51ee0*/ void SetProgressEvent(Firebase.Storage.MonitorControllerInternal.MonitorControllerEventDelegate event_, nint event_data);
            /*0x2d5237c*/ Firebase.Storage.ControllerInternal get_Controller();
            /*0x2d524fc*/ long get_BytesTransferred();
            /*0x2d52648*/ long get_TotalByteCount();
            /*0x2d5282c*/ void <RegisterCancellationToken>b__23_0();

            class MonitorControllerEventDelegate : System.MulticastDelegate
            {
                /*0x2d51d64*/ MonitorControllerEventDelegate(object object, nint method);
                /*0x2d52844*/ void Invoke(nint controllerPtr);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ Firebase.Storage.MonitorControllerInternal proxy;

                /*0x2d51c70*/ <>c__DisplayClass19_0();
                /*0x2d52858*/ void <Create>b__0();
                /*0x2d528e4*/ void <Create>b__1();
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ nint controllerPtr;

                /*0x2d51fbc*/ <>c__DisplayClass20_0();
                /*0x2d52970*/ void <OnPaused>b__0();
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ nint controllerPtr;

                /*0x2d51fc4*/ <>c__DisplayClass21_0();
                /*0x2d529f4*/ void <OnProgress>b__0();
            }
        }

        class FirebaseStorageInternal : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2d4b818*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Storage.FirebaseStorageInternal obj);
            static /*0x2d4c094*/ Firebase.Storage.FirebaseStorageInternal GetInstanceInternal(Firebase.FirebaseApp app, string url, ref Firebase.InitResult init_result_out);
            static /*0x2d52ca0*/ void ReleaseReferenceInternal(Firebase.Storage.FirebaseStorageInternal instance);
            /*0x2d52a78*/ FirebaseStorageInternal(nint cPtr, bool cMemoryOwn);
            /*0x2d52ad8*/ void Finalize();
            /*0x2d4b85c*/ void Dispose();
            /*0x2d52b68*/ void Dispose(bool disposing);
            /*0x2d4b3bc*/ string get_InstanceKey();
            /*0x2d4b3b4*/ void SetSwigCMemOwn(bool ownership);
            /*0x2d4c548*/ Firebase.Storage.StorageReferenceInternal GetReferenceFromUrl(string url);
            /*0x2d52d70*/ Firebase.FirebaseApp get_App();
            /*0x2d4b2d4*/ string get_Url();
        }

        class StorageInternalPINVOKE
        {
            static /*0x0*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Storage.StorageInternalPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2d53154*/ StorageInternalPINVOKE();
            static /*0x2d4f998*/ nint Future_StorageMetadata_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Storage.Future_StorageMetadata.SWIG_CompletionDelegate jarg2, int jarg3);
            static /*0x2d4fa34*/ void Future_StorageMetadata_SWIG_FreeCompletionData(nint jarg1);
            static /*0x2d4fbb4*/ nint Future_StorageMetadata_GetResult(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d4ef30*/ void delete_Future_StorageMetadata(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d50274*/ void delete_ControllerInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d503c0*/ bool ControllerInternal_Cancel(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d5090c*/ nint new_MetadataInternal__SWIG_0();
            static /*0x2d506c4*/ void delete_MetadataInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d50970*/ void MetadataInternal_ContentType_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d50a08*/ nint MetadataInternal_CopyCppObject(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d50f14*/ nint new_StorageReferenceInternal__SWIG_0();
            static /*0x2d50dd0*/ void delete_StorageReferenceInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d50f78*/ string StorageReferenceInternal_Bucket_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d5100c*/ string StorageReferenceInternal_FullPath_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d510a0*/ bool StorageReferenceInternal_IsValid_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d51168*/ nint StorageReferenceInternal_PutBytesUsingMonitorController(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2, uint jarg3, System.Runtime.InteropServices.HandleRef jarg4, System.Runtime.InteropServices.HandleRef jarg5);
            static /*0x2d521c8*/ nint new_MonitorControllerInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d51738*/ void delete_MonitorControllerInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d52244*/ void MonitorControllerInternal_SetPausedEvent(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Storage.MonitorControllerInternal.MonitorControllerEventDelegate jarg2, nint jarg3);
            static /*0x2d522e0*/ void MonitorControllerInternal_SetProgressEvent(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Storage.MonitorControllerInternal.MonitorControllerEventDelegate jarg2, nint jarg3);
            static /*0x2d52480*/ nint MonitorControllerInternal_Controller_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d525cc*/ long MonitorControllerInternal_BytesTransferred_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d52718*/ long MonitorControllerInternal_TotalByteCount_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d52e78*/ nint FirebaseStorageInternal_GetReferenceFromUrl__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d52f18*/ nint FirebaseStorageInternal_GetInstanceInternal(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, ref int jarg3);
            static /*0x2d52fc8*/ void FirebaseStorageInternal_ReleaseReferenceInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d53044*/ nint FirebaseStorageInternal_App_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d530c0*/ string FirebaseStorageInternal_Url_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d4eb70*/ nint Future_StorageMetadata_SWIGUpcast(nint jarg1);

            class SWIGExceptionHelper
            {
                static /*0x0*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
                static /*0x8*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
                static /*0x10*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
                static /*0x18*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
                static /*0x20*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
                static /*0x28*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
                static /*0x30*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
                static /*0x38*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
                static /*0x40*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
                static /*0x48*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
                static /*0x50*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
                static /*0x58*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
                static /*0x60*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
                static /*0x68*/ Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

                static /*0x2d53ee0*/ SWIGExceptionHelper();
                static /*0x2d53ab4*/ void SWIGRegisterExceptionCallbacks_StorageInternal(Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2d53c20*/ void SWIGRegisterExceptionCallbacksArgument_StorageInternal(Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Storage.StorageInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2d53224*/ void SetPendingApplicationException(string message);
                static /*0x2d532b4*/ void SetPendingArithmeticException(string message);
                static /*0x2d53344*/ void SetPendingDivideByZeroException(string message);
                static /*0x2d533d4*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2d53464*/ void SetPendingInvalidCastException(string message);
                static /*0x2d534f4*/ void SetPendingInvalidOperationException(string message);
                static /*0x2d53584*/ void SetPendingIOException(string message);
                static /*0x2d53614*/ void SetPendingNullReferenceException(string message);
                static /*0x2d536a4*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2d53734*/ void SetPendingOverflowException(string message);
                static /*0x2d537c4*/ void SetPendingSystemException(string message);
                static /*0x2d53854*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2d538f4*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2d539d4*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2d53214*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2d54330*/ ExceptionDelegate(object object, nint method);
                    /*0x2d54494*/ void Invoke(string message);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2d543e0*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2d544a8*/ void Invoke(string message, string paramName);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2d544bc*/ SWIGPendingException();
                static /*0x2d4f1d4*/ bool get_Pending();
                static /*0x2d53cd4*/ void Set(System.Exception e);
                static /*0x2d4f25c*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Storage.StorageInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2d545e8*/ SWIGStringHelper();
                static /*0x2d54568*/ void SWIGRegisterStringCallback_StorageInternal(Firebase.Storage.StorageInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2d54564*/ string CreateString(string cString);
                /*0x2d5321c*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2d54694*/ SWIGStringDelegate(object object, nint method);
                    /*0x2d54744*/ string Invoke(string message);
                }
            }
        }

        namespace Internal
        {
            class ModuleLogger
            {
                static /*0x0*/ object lockObject;
                static /*0x8*/ System.Collections.Generic.List<System.WeakReference> roots;
                /*0x10*/ Firebase.Storage.Internal.ModuleLogger parent;
                /*0x18*/ System.Collections.Generic.List<Firebase.Storage.Internal.ModuleLogger> children;
                /*0x20*/ string tag;
                /*0x28*/ Firebase.LogLevel logLevel;

                static /*0x2d54c94*/ ModuleLogger();
                /*0x2d4af14*/ ModuleLogger(Firebase.Storage.Internal.ModuleLogger parentLogger);
                /*0x2d54758*/ void Finalize();
                /*0x2d54b6c*/ Firebase.LogLevel get_Level();
                /*0x2d4b3ac*/ void set_Level(Firebase.LogLevel value);
                /*0x2d4b18c*/ string get_Tag();
                /*0x2d4b3a4*/ void set_Tag(string value);
                /*0x2d4b400*/ void LogMessage(Firebase.LogLevel level, string message);
            }

            class TransferState
            {
                /*0x10*/ long <BytesTransferred>k__BackingField;
                /*0x18*/ long <TotalByteCount>k__BackingField;
                /*0x20*/ System.Uri <UploadSessionUri>k__BackingField;
                /*0x28*/ Firebase.Storage.StorageMetadata <Metadata>k__BackingField;
                /*0x30*/ Firebase.Storage.StorageReference <Reference>k__BackingField;

                /*0x2d4e878*/ TransferState(Firebase.Storage.StorageReference reference);
                /*0x2d54d68*/ long get_BytesTransferred();
                /*0x2d54d70*/ void set_BytesTransferred(long value);
                /*0x2d54d78*/ long get_TotalByteCount();
                /*0x2d54d80*/ void set_TotalByteCount(long value);
                /*0x2d54d88*/ void set_UploadSessionUri(System.Uri value);
                /*0x2d54d90*/ void set_Metadata(Firebase.Storage.StorageMetadata value);
                /*0x2d54d98*/ void set_Reference(Firebase.Storage.StorageReference value);
            }

            class TransferStateUpdater<T>
            {
                /*0x0*/ System.IProgress<T> handler;
                /*0x0*/ Firebase.Storage.Internal.TransferState transferState;
                /*0x0*/ T <ProgressState>k__BackingField;
                /*0x0*/ Firebase.Storage.MonitorControllerInternal <MonitorController>k__BackingField;

                /*0x1ffc854*/ TransferStateUpdater(Firebase.Storage.StorageReference storageReference, System.IProgress<T> progressHandler, T progressState, Firebase.Storage.Internal.TransferState progressStateBackingStore);
                /*0x1f30ebc*/ void SetMetadata(Firebase.Storage.StorageMetadata metadata);
                /*0x1ffc854*/ T get_ProgressState();
                /*0x1ffc854*/ void set_ProgressState(T value);
                /*0x1f30214*/ Firebase.Storage.MonitorControllerInternal get_MonitorController();
                /*0x1f30ebc*/ void set_MonitorController(Firebase.Storage.MonitorControllerInternal value);
                /*0x1f30ff0*/ void <.ctor>b__2_0(object sender, System.EventArgs eventArgs);
            }
        }
    }
}
