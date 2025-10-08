class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x304c098*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x304c18c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Google
{
    namespace Play
    {
        namespace Integrity
        {
            enum IntegrityErrorCode
            {
                NoError = 0,
                ApiNotAvailable = 1,
                PlayStoreNotFound = 2,
                NetworkError = 3,
                PlayStoreAccountNotFound = 4,
                AppNotInstalled = 5,
                PlayServicesNotFound = 6,
                AppUidMismatch = 7,
                TooManyRequests = 8,
                CannotBindToService = 9,
                GoogleServerUnavailable = 10,
                NonceTooShort = 11,
                NonceTooLong = 12,
                NonceIsNotBase64 = 13,
                PlayStoreVersionOutdated = 14,
                PlayServicesVersionOutdated = 15,
                CloudProjectNumberIsInvalid = 16,
                ClientTransientError = 17,
                InternalError = 100,
            }

            class IntegrityManager
            {
                static string IntegrityTokenRequestClassName = "com.google.android.play.core.integrity.IntegrityTokenRequest";
                /*0x10*/ Google.Play.Integrity.Internal.PlayCoreIntegrityManager _playCoreIntegrityManager;

                /*0x304c194*/ IntegrityManager();
                /*0x304c574*/ Google.Play.Common.PlayAsyncOperation<Google.Play.Integrity.IntegrityTokenResponse, Google.Play.Integrity.IntegrityErrorCode> RequestIntegrityToken(Google.Play.Integrity.IntegrityTokenRequest integrityTokenRequest);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ Google.Play.Integrity.Internal.IntegrityAsyncOperation<Google.Play.Integrity.IntegrityTokenResponse> operation;
                    /*0x18*/ Google.Play.Core.Internal.PlayServicesTask<UnityEngine.AndroidJavaObject> requestIntegrityTokenTask;
                    /*0x20*/ UnityEngine.AndroidJavaObject javaIntegrityTokenRequest;

                    /*0x304ccd0*/ <>c__DisplayClass3_0();
                    /*0x304ce14*/ void <RequestIntegrityToken>b__0(UnityEngine.AndroidJavaObject tokenResponse);
                    /*0x304d0cc*/ void <RequestIntegrityToken>b__1(string reason, int errorCode);
                }
            }

            class IntegrityTokenRequest
            {
                /*0x10*/ string <Nonce>k__BackingField;
                /*0x18*/ System.Nullable<long> <CloudProjectNumber>k__BackingField;

                /*0x304d2c4*/ IntegrityTokenRequest(string nonce, System.Nullable<long> cloudProjectNumber);
                /*0x304d2a0*/ string get_Nonce();
                /*0x304d2a8*/ void set_Nonce(string value);
                /*0x304d2b0*/ System.Nullable<long> get_CloudProjectNumber();
                /*0x304d2bc*/ void set_CloudProjectNumber(System.Nullable<long> value);
            }

            class IntegrityTokenResponse
            {
                /*0x10*/ string <Token>k__BackingField;

                /*0x304ced4*/ IntegrityTokenResponse(UnityEngine.AndroidJavaObject tokenResponse);
                /*0x304d30c*/ string get_Token();
                /*0x304d314*/ void set_Token(string value);
            }

            class PrepareIntegrityTokenRequest
            {
                /*0x10*/ long <CloudProjectNumber>k__BackingField;

                /*0x304d32c*/ PrepareIntegrityTokenRequest(long cloudProjectNumber);
                /*0x304d31c*/ long get_CloudProjectNumber();
                /*0x304d324*/ void set_CloudProjectNumber(long value);
            }

            enum StandardIntegrityErrorCode
            {
                NoError = 0,
                ApiNotAvailable = -1,
                PlayStoreNotFound = -2,
                NetworkError = -3,
                AppNotInstalled = -5,
                PlayServicesNotFound = -6,
                AppUidMismatch = -7,
                TooManyRequests = -8,
                CannotBindToService = -9,
                GoogleServerUnavailable = -12,
                PlayStoreVersionOutdated = -14,
                PlayServicesVersionOutdated = -15,
                CloudProjectNumberIsInvalid = -16,
                RequestHashTooLong = -17,
                ClientTransientError = -18,
                IntegrityTokenProviderInvalid = -19,
                InternalError = -100,
            }

            class StandardIntegrityManager
            {
                static string PrepareIntegrityTokenRequestClassName = "com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest";
                /*0x10*/ Google.Play.Integrity.Internal.PlayCoreStandardIntegrityManager _playCoreStandardIntegrityManager;

                /*0x304d354*/ StandardIntegrityManager();
                /*0x304d734*/ Google.Play.Common.PlayAsyncOperation<Google.Play.Integrity.StandardIntegrityTokenProvider, Google.Play.Integrity.StandardIntegrityErrorCode> PrepareIntegrityToken(Google.Play.Integrity.PrepareIntegrityTokenRequest request);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ Google.Play.Integrity.Internal.StandardIntegrityAsyncOperation<Google.Play.Integrity.StandardIntegrityTokenProvider> operation;
                    /*0x18*/ Google.Play.Core.Internal.PlayServicesTask<UnityEngine.AndroidJavaObject> prepareIntegrityTokenTask;
                    /*0x20*/ UnityEngine.AndroidJavaObject javaPrepareIntegrityTokenRequest;

                    /*0x304dd6c*/ <>c__DisplayClass3_0();
                    /*0x304deb0*/ void <PrepareIntegrityToken>b__0(UnityEngine.AndroidJavaObject tokenProvider);
                    /*0x304e018*/ void <PrepareIntegrityToken>b__1(string reason, int errorCode);
                }
            }

            class StandardIntegrityToken
            {
                /*0x10*/ string <Token>k__BackingField;

                /*0x304e1fc*/ StandardIntegrityToken(UnityEngine.AndroidJavaObject tokenResponse);
                /*0x304e1ec*/ string get_Token();
                /*0x304e1f4*/ void set_Token(string value);
            }

            class StandardIntegrityTokenProvider
            {
                static string StandardIntegrityTokenRequestClassName = "com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest";
                /*0x10*/ Google.Play.Integrity.Internal.PlayCoreStandardIntegrityTokenProvider _playCoreStandardIntegrityTokenProvider;

                /*0x304dfe8*/ StandardIntegrityTokenProvider(Google.Play.Integrity.Internal.PlayCoreStandardIntegrityTokenProvider tokenProvider);
                /*0x304e3f4*/ Google.Play.Common.PlayAsyncOperation<Google.Play.Integrity.StandardIntegrityToken, Google.Play.Integrity.StandardIntegrityErrorCode> Request(Google.Play.Integrity.StandardIntegrityTokenRequest request);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ Google.Play.Integrity.Internal.StandardIntegrityAsyncOperation<Google.Play.Integrity.StandardIntegrityToken> operation;
                    /*0x18*/ Google.Play.Core.Internal.PlayServicesTask<UnityEngine.AndroidJavaObject> standardIntegrityTokenTask;
                    /*0x20*/ UnityEngine.AndroidJavaObject javaStandardIntegrityTokenRequest;

                    /*0x304ea10*/ <>c__DisplayClass3_0();
                    /*0x304eb54*/ void <Request>b__0(UnityEngine.AndroidJavaObject tokenResponse);
                    /*0x304ec14*/ void <Request>b__1(string reason, int errorCode);
                }
            }

            class StandardIntegrityTokenRequest
            {
                /*0x10*/ string <RequestHash>k__BackingField;

                /*0x304ecf0*/ StandardIntegrityTokenRequest(string requestHash);
                /*0x304ece0*/ string get_RequestHash();
                /*0x304ece8*/ void set_RequestHash(string value);
            }

            namespace Internal
            {
                class IntegrityAsyncOperation<TResult> : Google.Play.Common.Internal.PlayAsyncOperationImpl<TResult, Google.Play.Integrity.IntegrityErrorCode>
                {
                    /*0x1f309e4*/ IntegrityAsyncOperation();
                    /*0x1f2fe14*/ bool get_IsSuccessful();
                }

                class PlayCoreIntegrityManager : System.IDisposable
                {
                    /*0x10*/ UnityEngine.AndroidJavaObject _javaIntegrityManager;

                    /*0x304c1fc*/ PlayCoreIntegrityManager();
                    /*0x304ccd8*/ Google.Play.Core.Internal.PlayServicesTask<UnityEngine.AndroidJavaObject> RequestIntegrityToken(UnityEngine.AndroidJavaObject integrityTokenRequest);
                    /*0x304ed20*/ void Dispose();
                }

                class PlayCoreStandardIntegrityManager : System.IDisposable
                {
                    /*0x10*/ UnityEngine.AndroidJavaObject _javaStandardIntegrityManager;

                    /*0x304d3bc*/ PlayCoreStandardIntegrityManager();
                    /*0x304dd74*/ Google.Play.Core.Internal.PlayServicesTask<UnityEngine.AndroidJavaObject> PrepareIntegrityToken(UnityEngine.AndroidJavaObject prepareIntegrityTokenRequest);
                    /*0x304ed38*/ void Dispose();
                }

                class PlayCoreStandardIntegrityTokenProvider : System.IDisposable
                {
                    /*0x10*/ UnityEngine.AndroidJavaObject _javaStandardIntegrityTokenProvider;

                    /*0x304dfb8*/ PlayCoreStandardIntegrityTokenProvider(UnityEngine.AndroidJavaObject javaTokenProvider);
                    /*0x304ea18*/ Google.Play.Core.Internal.PlayServicesTask<UnityEngine.AndroidJavaObject> Request(UnityEngine.AndroidJavaObject standardIntegrityTokenRequest);
                    /*0x304ed50*/ void Dispose();
                }

                class PlayCoreTranslator
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, Google.Play.Integrity.IntegrityErrorCode> PlayCoreToIntegrityErrors;
                    static /*0x8*/ System.Collections.Generic.Dictionary<int, Google.Play.Integrity.StandardIntegrityErrorCode> PlayCoreToStandardIntegrityErrors;

                    static /*0x304ed68*/ PlayCoreTranslator();
                    static /*0x304d198*/ Google.Play.Integrity.IntegrityErrorCode TranslatePlayCoreErrorCode(int javaIntegrityErrorCode);
                    static /*0x304e0e4*/ Google.Play.Integrity.StandardIntegrityErrorCode TranslatePlayCoreStandardIntegrityErrorCode(int javaStandardIntegrityErrorCode);

                    class JavaIntegrityErrorCode
                    {
                        static int NoError = 0;
                        static int ApiNotAvailable = -1;
                        static int PlayStoreNotFound = -2;
                        static int NetworkError = -3;
                        static int PlayStoreAccountNotFound = -4;
                        static int AppNotInstalled = -5;
                        static int PlayServicesNotFound = -6;
                        static int AppUidMismatch = -7;
                        static int TooManyRequests = -8;
                        static int CannotBindToService = -9;
                        static int NonceTooShort = -10;
                        static int NonceTooLong = -11;
                        static int GoogleServerUnavailable = -12;
                        static int NonceIsNotBase64 = -13;
                        static int PlayStoreVersionOutdated = -14;
                        static int PlayServicesVersionOutdated = -15;
                        static int CloudProjectNumberIsInvalid = -16;
                        static int ClientTransientError = -17;
                        static int InternalError = -100;
                    }

                    class JavaStandardIntegrityErrorCode
                    {
                        static int NoError = 0;
                        static int ApiNotAvailable = -1;
                        static int PlayStoreNotFound = -2;
                        static int NetworkError = -3;
                        static int AppNotInstalled = -5;
                        static int PlayServicesNotFound = -6;
                        static int AppUidMismatch = -7;
                        static int TooManyRequests = -8;
                        static int CannotBindToService = -9;
                        static int GoogleServerUnavailable = -12;
                        static int PlayStoreVersionOutdated = -14;
                        static int PlayServicesVersionOutdated = -15;
                        static int CloudProjectNumberIsInvalid = -16;
                        static int RequestHashTooLong = -17;
                        static int ClientTransientError = -18;
                        static int IntegrityTokenProviderInvalid = -19;
                        static int InternalError = -100;
                    }
                }

                class StandardIntegrityAsyncOperation<TResult> : Google.Play.Common.Internal.PlayAsyncOperationImpl<TResult, Google.Play.Integrity.StandardIntegrityErrorCode>
                {
                    /*0x1f309e4*/ StandardIntegrityAsyncOperation();
                    /*0x1f2fe14*/ bool get_IsSuccessful();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 3BDDDC711C6AD96C7214C4FE16F1409DE356071BA87C54EDDFE0275B9813CB33;
    static /*0x5ee*/ <PrivateImplementationDetails> D343210503A89EA915E5A4FE46C8D5D4AF4A21961BB30C4FA34BE496DC47E394;

    struct __StaticArrayInitTypeSize=952
    {
    }

    struct __StaticArrayInitTypeSize=1518
    {
    }
}
