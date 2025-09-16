class <Module>
{
}

namespace Mono
{
    class SystemCertificateProvider : Mono.ISystemCertificateProvider
    {
        static /*0x0*/ int initialized;
        static /*0x8*/ Mono.X509PalImpl x509pal;
        static /*0x10*/ object syncRoot;

        static /*0x7447b78*/ SystemCertificateProvider();
        static /*0x7447498*/ Mono.X509PalImpl GetX509Pal();
        static /*0x7447540*/ void EnsureInitialized();
        /*0x7447b70*/ SystemCertificateProvider();
        /*0x7447694*/ Mono.X509PalImpl get_X509Pal();
        /*0x74476f0*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, Mono.CertificateImportFlags importFlags);
        /*0x7447950*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x7447954*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x7447a58*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
        /*0x7447a5c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
    }

    class SystemDependencyProvider : Mono.ISystemDependencyProvider
    {
        static /*0x0*/ Mono.SystemDependencyProvider instance;
        static /*0x8*/ object syncRoot;
        /*0x10*/ Mono.SystemCertificateProvider <CertificateProvider>k__BackingField;

        static /*0x7447e64*/ SystemDependencyProvider();
        static /*0x7447bec*/ Mono.SystemDependencyProvider get_Instance();
        static /*0x7447c48*/ void Initialize();
        /*0x7447d98*/ SystemDependencyProvider();
        /*0x7447e3c*/ Mono.ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider();
        /*0x7447e44*/ Mono.SystemCertificateProvider get_CertificateProvider();
        /*0x7447e4c*/ Mono.X509PalImpl get_X509Pal();
    }

    class X509Pal
    {
        static /*0x7447ed8*/ Mono.X509PalImpl get_Instance();
    }

    class X509PalImplMono : Mono.X509PalImpl
    {
        /*0x74474e8*/ X509PalImplMono();
        /*0x7447f38*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        /*0x7447f3c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x7447f40*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
    }

    class X509PalImpl
    {
        static /*0x0*/ byte[] signedData;

        static /*0x7448598*/ X509PalImpl();
        static /*0x7447f50*/ byte[] PEM(string type, byte[] data);
        static /*0x7448084*/ byte[] ConvertData(byte[] data);
        /*0x7447f48*/ X509PalImpl();
        /*0x380bb68*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x380bb68*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
        /*0x744775c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data);
        /*0x74479e4*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x7448190*/ bool get_SupportsLegacyBasicConstraintsExtension();
        /*0x7448198*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
    }

    namespace Util
    {
        class MonoPInvokeCallbackAttribute : System.Attribute
        {
            /*0x7448638*/ MonoPInvokeCallbackAttribute(System.Type t);
        }
    }

    namespace Unity
    {
        class CertHelper
        {
            static /*0x7448640*/ void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x7448818*/ void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class Debug
        {
            static /*0x7448a8c*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, string context, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x7448b24*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, string context, Mono.Security.Interface.AlertDescription defaultAlert);
        }

        class UnityTls
        {
            static /*0x0*/ Mono.Unity.UnityTls.unitytls_interface_struct marshalledInterface;

            static /*0x7448c48*/ nint GetUnityTlsInterface();
            static /*0x7448c4c*/ bool get_IsSupported();
            static /*0x74489c8*/ Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface();

            enum unitytls_error_code
            {
                UNITYTLS_SUCCESS = 0,
                UNITYTLS_INVALID_ARGUMENT = 1,
                UNITYTLS_INVALID_FORMAT = 2,
                UNITYTLS_INVALID_PASSWORD = 3,
                UNITYTLS_INVALID_STATE = 4,
                UNITYTLS_BUFFER_OVERFLOW = 5,
                UNITYTLS_OUT_OF_MEMORY = 6,
                UNITYTLS_INTERNAL_ERROR = 7,
                UNITYTLS_NOT_SUPPORTED = 8,
                UNITYTLS_ENTROPY_SOURCE_FAILED = 9,
                UNITYTLS_STREAM_CLOSED = 10,
                UNITYTLS_DER_PARSE_ERROR = 11,
                UNITYTLS_KEY_PARSE_ERROR = 12,
                UNITYTLS_SSL_ERROR = 13,
                UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
                UNITYTLS_USER_WOULD_BLOCK = 1048577,
                UNITYTLS_USER_WOULD_BLOCK_READ = 1048578,
                UNITYTLS_USER_WOULD_BLOCK_WRITE = 1048579,
                UNITYTLS_USER_READ_FAILED = 1048580,
                UNITYTLS_USER_WRITE_FAILED = 1048581,
                UNITYTLS_USER_UNKNOWN_ERROR = 1048582,
                UNITYTLS_SSL_NEEDS_VERIFY = 1048583,
                UNITYTLS_HANDSHAKE_STEP = 1048584,
                UNITYTLS_USER_CUSTOM_ERROR_END = 2097152,
            }

            enum unitytls_log_level
            {
                UNITYTLS_LOGLEVEL_MIN = 0,
                UNITYTLS_LOGLEVEL_FATAL = 0,
                UNITYTLS_LOGLEVEL_ERROR = 1,
                UNITYTLS_LOGLEVEL_WARN = 2,
                UNITYTLS_LOGLEVEL_INFO = 3,
                UNITYTLS_LOGLEVEL_DEBUG = 4,
                UNITYTLS_LOGLEVEL_TRACE = 5,
                UNITYTLS_LOGLEVEL_MAX = 5,
            }

            struct unitytls_errorstate
            {
                /*0x10*/ uint magic;
                /*0x14*/ Mono.Unity.UnityTls.unitytls_error_code code;
                /*0x18*/ ulong reserved;
            }

            struct unitytls_key
            {
            }

            struct unitytls_key_ref
            {
                /*0x10*/ ulong handle;
            }

            struct unitytls_x509_ref
            {
                /*0x10*/ ulong handle;
            }

            struct unitytls_x509list
            {
            }

            struct unitytls_x509list_ref
            {
                /*0x10*/ ulong handle;
            }

            enum unitytls_x509verify_result
            {
                UNITYTLS_X509VERIFY_SUCCESS = 0,
                UNITYTLS_X509VERIFY_NOT_DONE = 2147483648,
                UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295,
                UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1,
                UNITYTLS_X509VERIFY_FLAG_REVOKED = 2,
                UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4,
                UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8,
                UNITYTLS_X509VERIFY_FLAG_BADCRL_NOT_TRUSTED = 16,
                UNITYTLS_X509VERIFY_FLAG_BADCRL_EXPIRED = 32,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_MISSING = 64,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_SKIP_VERIFY = 128,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_OTHER = 256,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_FUTURE = 512,
                UNITYTLS_X509VERIFY_FLAG_BADCRL_FUTURE = 1024,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_KEY_USAGE = 2048,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_EXT_KEY_USAGE = 4096,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_NS_CERT_TYPE = 8192,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_MD = 16384,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_PK = 32768,
                UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_KEY = 65536,
                UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_MD = 131072,
                UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_PK = 262144,
                UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_KEY = 524288,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608,
                UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728,
            }

            class unitytls_x509verify_callback : System.MulticastDelegate
            {
                /*0x7448c64*/ unitytls_x509verify_callback(object object, nint method);
                /*0x7448d18*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            struct unitytls_tlsctx
            {
            }

            struct unitytls_x509name
            {
            }

            enum unitytls_ciphersuite
            {
                UNITYTLS_CIPHERSUITE_INVALID = 16777215,
            }

            enum unitytls_protocol
            {
                UNITYTLS_PROTOCOL_TLS_1_0 = 0,
                UNITYTLS_PROTOCOL_TLS_1_1 = 1,
                UNITYTLS_PROTOCOL_TLS_1_2 = 2,
                UNITYTLS_PROTOCOL_INVALID = 3,
            }

            struct unitytls_tlsctx_protocolrange
            {
                /*0x10*/ Mono.Unity.UnityTls.unitytls_protocol min;
                /*0x14*/ Mono.Unity.UnityTls.unitytls_protocol max;
            }

            class unitytls_tlsctx_write_callback : System.MulticastDelegate
            {
                /*0x7448d2c*/ unitytls_tlsctx_write_callback(object object, nint method);
                /*0x7448de0*/ nint Invoke(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_read_callback : System.MulticastDelegate
            {
                /*0x7448df4*/ unitytls_tlsctx_read_callback(object object, nint method);
                /*0x7448ea8*/ nint Invoke(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_trace_callback : System.MulticastDelegate
            {
                /*0x7448ebc*/ unitytls_tlsctx_trace_callback(object object, nint method);
                /*0x7448f70*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen);
            }

            class unitytls_tlsctx_certificate_callback : System.MulticastDelegate
            {
                /*0x7448f84*/ unitytls_tlsctx_certificate_callback(object object, nint method);
                /*0x7449038*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_x509verify_callback : System.MulticastDelegate
            {
                /*0x7449054*/ unitytls_tlsctx_x509verify_callback(object object, nint method);
                /*0x7449108*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            struct unitytls_tlsctx_callbacks
            {
                /*0x10*/ Mono.Unity.UnityTls.unitytls_tlsctx_read_callback read;
                /*0x18*/ Mono.Unity.UnityTls.unitytls_tlsctx_write_callback write;
                /*0x20*/ void* data;
            }

            class unitytls_interface_struct
            {
                /*0x10*/ ulong UNITYTLS_INVALID_HANDLE;
                /*0x18*/ Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;
                /*0x20*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create;
                /*0x28*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error;
                /*0x30*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref;
                /*0x38*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der;
                /*0x40*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem;
                /*0x48*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free;
                /*0x50*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der;
                /*0x58*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref;
                /*0x60*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509;
                /*0x68*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create;
                /*0x70*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append;
                /*0x78*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der;
                /*0x80*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem;
                /*0x88*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free;
                /*0x90*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca;
                /*0x98*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca;
                /*0xa0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server;
                /*0xa8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client;
                /*0xb0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication;
                /*0xb8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback;
                /*0xc0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback;
                /*0xc8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback;
                /*0xd0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites;
                /*0xd8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite;
                /*0xe0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol;
                /*0xe8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake;
                /*0xf0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read;
                /*0xf8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write;
                /*0x100*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close;
                /*0x108*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free;
                /*0x110*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes;
                /*0x118*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_result_to_string_t unitytls_x509verify_result_to_string;
                /*0x120*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_level_t unitytls_tlsctx_set_trace_level;

                /*0x744911c*/ unitytls_interface_struct();

                class unitytls_errorstate_create_t : System.MulticastDelegate
                {
                    /*0x7449124*/ unitytls_errorstate_create_t(object object, nint method);
                    /*0x74491c0*/ Mono.Unity.UnityTls.unitytls_errorstate Invoke();
                }

                class unitytls_errorstate_raise_error_t : System.MulticastDelegate
                {
                    /*0x74491d4*/ unitytls_errorstate_raise_error_t(object object, nint method);
                    /*0x7449288*/ void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode);
                }

                class unitytls_key_get_ref_t : System.MulticastDelegate
                {
                    /*0x744929c*/ unitytls_key_get_ref_t(object object, nint method);
                    /*0x7449350*/ Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_der_t : System.MulticastDelegate
                {
                    /*0x7449364*/ unitytls_key_parse_der_t(object object, nint method);
                    /*0x7449418*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_pem_t : System.MulticastDelegate
                {
                    /*0x744942c*/ unitytls_key_parse_pem_t(object object, nint method);
                    /*0x74494e0*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_free_t : System.MulticastDelegate
                {
                    /*0x74494f4*/ unitytls_key_free_t(object object, nint method);
                    /*0x74495a4*/ void Invoke(Mono.Unity.UnityTls.unitytls_key* key);
                }

                class unitytls_x509_export_der_t : System.MulticastDelegate
                {
                    /*0x74495b8*/ unitytls_x509_export_der_t(object object, nint method);
                    /*0x7449658*/ nint Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_ref_t : System.MulticastDelegate
                {
                    /*0x744966c*/ unitytls_x509list_get_ref_t(object object, nint method);
                    /*0x7449720*/ Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_x509_t : System.MulticastDelegate
                {
                    /*0x7449734*/ unitytls_x509list_get_x509_t(object object, nint method);
                    /*0x74497d4*/ Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, nint index, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_create_t : System.MulticastDelegate
                {
                    /*0x74497e8*/ unitytls_x509list_create_t(object object, nint method);
                    /*0x7449898*/ Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_t : System.MulticastDelegate
                {
                    /*0x74498ac*/ unitytls_x509list_append_t(object object, nint method);
                    /*0x7449960*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_der_t : System.MulticastDelegate
                {
                    /*0x7449974*/ unitytls_x509list_append_der_t(object object, nint method);
                    /*0x7449a28*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_free_t : System.MulticastDelegate
                {
                    /*0x7449a3c*/ unitytls_x509list_free_t(object object, nint method);
                    /*0x7449aec*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list);
                }

                class unitytls_x509verify_default_ca_t : System.MulticastDelegate
                {
                    /*0x7449b00*/ unitytls_x509verify_default_ca_t(object object, nint method);
                    /*0x7449ba0*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_explicit_ca_t : System.MulticastDelegate
                {
                    /*0x7449bb4*/ unitytls_x509verify_explicit_ca_t(object object, nint method);
                    /*0x7449c54*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_server_t : System.MulticastDelegate
                {
                    /*0x7449c6c*/ unitytls_tlsctx_create_server_t(object object, nint method);
                    /*0x7449d0c*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_client_t : System.MulticastDelegate
                {
                    /*0x7449d48*/ unitytls_tlsctx_create_client_t(object object, nint method);
                    /*0x7449de8*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_server_require_client_authentication_t : System.MulticastDelegate
                {
                    /*0x7449e24*/ unitytls_tlsctx_server_require_client_authentication_t(object object, nint method);
                    /*0x7449ed8*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_certificate_callback_t : System.MulticastDelegate
                {
                    /*0x7449eec*/ unitytls_tlsctx_set_certificate_callback_t(object object, nint method);
                    /*0x7449fa0*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_trace_callback_t : System.MulticastDelegate
                {
                    /*0x7449fb4*/ unitytls_tlsctx_set_trace_callback_t(object object, nint method);
                    /*0x744a068*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_x509verify_callback_t : System.MulticastDelegate
                {
                    /*0x744a07c*/ unitytls_tlsctx_set_x509verify_callback_t(object object, nint method);
                    /*0x744a130*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_supported_ciphersuites_t : System.MulticastDelegate
                {
                    /*0x744a144*/ unitytls_tlsctx_set_supported_ciphersuites_t(object object, nint method);
                    /*0x744a1f8*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_ciphersuite_t : System.MulticastDelegate
                {
                    /*0x744a20c*/ unitytls_tlsctx_get_ciphersuite_t(object object, nint method);
                    /*0x744a2c0*/ Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_protocol_t : System.MulticastDelegate
                {
                    /*0x744a2d4*/ unitytls_tlsctx_get_protocol_t(object object, nint method);
                    /*0x744a388*/ Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_process_handshake_t : System.MulticastDelegate
                {
                    /*0x744a39c*/ unitytls_tlsctx_process_handshake_t(object object, nint method);
                    /*0x744a450*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_read_t : System.MulticastDelegate
                {
                    /*0x744a464*/ unitytls_tlsctx_read_t(object object, nint method);
                    /*0x744a518*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_write_t : System.MulticastDelegate
                {
                    /*0x744a52c*/ unitytls_tlsctx_write_t(object object, nint method);
                    /*0x744a5e0*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_notify_close_t : System.MulticastDelegate
                {
                    /*0x744a5f4*/ unitytls_tlsctx_notify_close_t(object object, nint method);
                    /*0x744a6a8*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_free_t : System.MulticastDelegate
                {
                    /*0x744a6bc*/ unitytls_tlsctx_free_t(object object, nint method);
                    /*0x744a76c*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx);
                }

                class unitytls_random_generate_bytes_t : System.MulticastDelegate
                {
                    /*0x744a780*/ unitytls_random_generate_bytes_t(object object, nint method);
                    /*0x744a834*/ void Invoke(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_result_to_string_t : System.MulticastDelegate
                {
                    /*0x744a848*/ unitytls_x509verify_result_to_string_t(object object, nint method);
                    /*0x744a8e8*/ char* Invoke(Mono.Unity.UnityTls.unitytls_x509verify_result v);
                }

                class unitytls_tlsctx_set_trace_level_t : System.MulticastDelegate
                {
                    /*0x744a8fc*/ unitytls_tlsctx_set_trace_level_t(object object, nint method);
                    /*0x744a9b0*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_log_level level);
                }
            }
        }

        class UnityTlsContext : Mono.Net.Security.MobileTlsContext
        {
            /*0x58*/ Mono.Unity.UnityTls.unitytls_tlsctx* tlsContext;
            /*0x60*/ Mono.Unity.UnityTls.unitytls_x509list* requestedClientCertChain;
            /*0x68*/ Mono.Unity.UnityTls.unitytls_key* requestedClientKey;
            /*0x70*/ Mono.Unity.UnityTls.unitytls_tlsctx_read_callback readCallback;
            /*0x78*/ Mono.Unity.UnityTls.unitytls_tlsctx_write_callback writeCallback;
            /*0x80*/ Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback certificateCallback;
            /*0x88*/ Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback;
            /*0x90*/ System.Security.Cryptography.X509Certificates.X509Certificate localClientCertificate;
            /*0x98*/ System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate;
            /*0xa0*/ Mono.Security.Interface.MonoTlsConnectionInfo connectioninfo;
            /*0xa8*/ bool isAuthenticated;
            /*0xa9*/ bool hasContext;
            /*0xaa*/ bool closedGraceful;
            /*0xb0*/ byte[] writeBuffer;
            /*0xb8*/ byte[] readBuffer;
            /*0xc0*/ System.Runtime.InteropServices.GCHandle handle;
            /*0xc8*/ System.Exception lastException;

            static /*0x744b784*/ void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, ref Mono.Unity.UnityTls.unitytls_x509list* nativeCertChain, ref Mono.Unity.UnityTls.unitytls_key* nativeKey);
            static /*0x744a9c4*/ nint WriteCallback(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x744aad4*/ nint ReadCallback(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x744abe4*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x744acdc*/ void CertificateCallback(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x744adec*/ UnityTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
            /*0x744bad8*/ bool get_IsAuthenticated();
            /*0x744bae0*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
            /*0x744bae8*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
            /*0x744baf0*/ System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
            /*0x744bcbc*/ System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
            /*0x744be7c*/ void Renegotiate();
            /*0x744beb4*/ bool PendingRenegotiation();
            /*0x744bebc*/ void Shutdown();
            /*0x744bfd0*/ void Dispose(bool disposing);
            /*0x744c0c8*/ void StartHandshake();
            /*0x744c248*/ bool ProcessHandshake();
            /*0x744c420*/ void FinishHandshake();
            /*0x744c57c*/ nint WriteCallback(byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x744c9e0*/ nint ReadCallback(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x744ce00*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x744d2a8*/ void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class UnityTlsConversions
        {
            static /*0x744b714*/ Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x744b74c*/ Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x744c55c*/ Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol);
            static /*0x7448bf4*/ Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x744da70*/ System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
            static /*0x744daa0*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
        }

        class UnityTlsProvider : Mono.Net.Security.MobileTlsProvider
        {
            static /*0x744dae0*/ Mono.Unity.UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x744e738*/ UnityTlsProvider();
            /*0x744db44*/ string get_Name();
            /*0x744db84*/ System.Guid get_ID();
            /*0x744dbdc*/ bool get_SupportsSslStream();
            /*0x744dbe4*/ bool get_SupportsMonoExtensions();
            /*0x744dbec*/ bool get_SupportsConnectionInfo();
            /*0x744dbf4*/ bool get_SupportsCleanShutdown();
            /*0x744dbfc*/ System.Security.Authentication.SslProtocols get_SupportedProtocols();
            /*0x744dc04*/ Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x744dd20*/ bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
        }

        class UnityTlsStream : Mono.Net.Security.MobileAuthenticatedStream
        {
            /*0x744dc8c*/ UnityTlsStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
            /*0x744e8b8*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
        }

        class X509ChainImplUnityTls : System.Security.Cryptography.X509Certificates.X509ChainImpl
        {
            /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
            /*0x18*/ Mono.Unity.UnityTls.unitytls_x509list* ownedList;
            /*0x20*/ Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain;
            /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
            /*0x30*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;
            /*0x38*/ bool reverseOrder;

            /*0x744d20c*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder);
            /*0x744e65c*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list* ownedList, Mono.Unity.UnityTls.unitytls_errorstate* errorState, bool reverseOrder);
            /*0x744e920*/ bool get_IsValid();
            /*0x744e948*/ Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain();
            /*0x744e950*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
            /*0x744ec40*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
            /*0x744ed60*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
            /*0x744ed68*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
            /*0x744ed70*/ void Reset();
            /*0x744edf8*/ void Dispose(bool disposing);
        }
    }

    namespace Net
    {
        namespace Security
        {
            class BufferOffsetSize
            {
                /*0x10*/ byte[] Buffer;
                /*0x18*/ int Offset;
                /*0x1c*/ int Size;
                /*0x20*/ int TotalBytes;
                /*0x24*/ bool Complete;

                /*0x744ee64*/ BufferOffsetSize(byte[] buffer, int offset, int size);
                /*0x744ee30*/ int get_EndOffset();
                /*0x744ee3c*/ int get_Remaining();
                /*0x744ef68*/ string ToString();
            }

            class BufferOffsetSize2 : Mono.Net.Security.BufferOffsetSize
            {
                /*0x28*/ int InitialSize;

                /*0x744effc*/ BufferOffsetSize2(int size);
                /*0x744f06c*/ void Reset();
                /*0x744f0d4*/ void MakeRoom(int size);
                /*0x744f1a4*/ void AppendData(byte[] buffer, int offset, int size);
            }

            enum AsyncOperationStatus
            {
                Initialize = 0,
                Continue = 1,
                ReadDone = 2,
                Complete = 3,
            }

            class AsyncProtocolResult
            {
                /*0x10*/ int <UserResult>k__BackingField;
                /*0x18*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo <Error>k__BackingField;

                /*0x744f214*/ AsyncProtocolResult(int result);
                /*0x744f23c*/ AsyncProtocolResult(System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x744f204*/ int get_UserResult();
                /*0x744f20c*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
            }

            class AsyncProtocolRequest
            {
                /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField;
                /*0x18*/ bool <RunSynchronously>k__BackingField;
                /*0x1c*/ int <UserResult>k__BackingField;
                /*0x20*/ int Started;
                /*0x24*/ int RequestedSize;
                /*0x28*/ int WriteRequested;
                /*0x30*/ object locker;

                /*0x744f2b0*/ AsyncProtocolRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x744f26c*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x744f274*/ bool get_RunSynchronously();
                /*0x744f27c*/ string get_Name();
                /*0x744f2a0*/ int get_UserResult();
                /*0x744f2a8*/ void set_UserResult(int value);
                /*0x744f348*/ void RequestRead(int size);
                /*0x744f410*/ void RequestWrite();
                /*0x744f41c*/ System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken);
                /*0x744f544*/ System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken);
                /*0x744f650*/ System.Threading.Tasks.Task<System.Nullable<int>> InnerRead(System.Threading.CancellationToken cancellationToken);
                /*0x380b6cc*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
                /*0x744f77c*/ string ToString();

                struct <StartOperation>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Mono.Net.Security.AsyncProtocolResult> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x744f7d4*/ void MoveNext();
                    /*0x744fbb0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessOperation>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x40*/ Mono.Net.Security.AsyncOperationStatus <status>5__2;
                    /*0x44*/ Mono.Net.Security.AsyncOperationStatus <newStatus>5__3;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Nullable<int>> <>u__1;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0x744fc2c*/ void MoveNext();
                    /*0x7450410*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerRead>d__25 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<int>> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Nullable<int> <totalRead>5__2;
                    /*0x48*/ int <requestedSize>5__3;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                    /*0x7450478*/ void MoveNext();
                    /*0x745096c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AsyncHandshakeRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x74509e8*/ AsyncHandshakeRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x74509f0*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncReadOrWriteRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x38*/ Mono.Net.Security.BufferOffsetSize <UserBuffer>k__BackingField;
                /*0x40*/ int <CurrentSize>k__BackingField;

                /*0x7450dec*/ AsyncReadOrWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x7450dd4*/ Mono.Net.Security.BufferOffsetSize get_UserBuffer();
                /*0x7450ddc*/ int get_CurrentSize();
                /*0x7450de4*/ void set_CurrentSize(int value);
                /*0x7450e90*/ string ToString();
            }

            class AsyncReadRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x7450eec*/ AsyncReadRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x7450ef4*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncWriteRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x74510c0*/ AsyncWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x74510c8*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class ChainValidationHelper : Mono.Security.Interface.ICertificateValidator
            {
                /*0x10*/ System.WeakReference<System.Net.Security.SslStream> owner;
                /*0x18*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x20*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x28*/ System.Net.ServerCertValidationCallback certValidationCallback;
                /*0x30*/ System.Net.Security.LocalCertSelectionCallback certSelectionCallback;
                /*0x38*/ Mono.Net.Security.MonoTlsStream tlsStream;
                /*0x40*/ System.Net.HttpWebRequest request;

                static /*0x74512a4*/ Mono.Net.Security.ChainValidationHelper GetInternalValidator(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x7451674*/ Mono.Net.Security.ChainValidationHelper Create(Mono.Net.Security.MobileTlsProvider provider, ref Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MonoTlsStream stream);
                static /*0x7451824*/ System.Net.ServerCertValidationCallback GetValidationCallback(Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x74519f0*/ System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x7451384*/ ChainValidationHelper(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, bool cloneSettings, Mono.Net.Security.MonoTlsStream stream);
                /*0x7451a2c*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x7451a34*/ bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, ref System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
                /*0x7451a8c*/ Mono.Security.Interface.ValidationResult ValidateCertificate(string host, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x7451b60*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x7451c2c*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, ref System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x7452034*/ bool InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ Mono.Security.Interface.MonoTlsSettings settings;

                    /*0x74519e8*/ <>c__DisplayClass11_0();
                    /*0x74520f0*/ bool <GetValidationCallback>b__0(object s, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, System.Net.Security.SslPolicyErrors e);
                }
            }

            class MobileAuthenticatedStream : System.Net.Security.AuthenticatedStream, System.IDisposable
            {
                static /*0x0*/ int uniqueNameInteger;
                static /*0x4*/ int nextId;
                /*0x38*/ Mono.Net.Security.MobileTlsContext xobileTlsContext;
                /*0x40*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo lastException;
                /*0x48*/ Mono.Net.Security.AsyncProtocolRequest asyncHandshakeRequest;
                /*0x50*/ Mono.Net.Security.AsyncProtocolRequest asyncReadRequest;
                /*0x58*/ Mono.Net.Security.AsyncProtocolRequest asyncWriteRequest;
                /*0x60*/ Mono.Net.Security.BufferOffsetSize2 readBuffer;
                /*0x68*/ Mono.Net.Security.BufferOffsetSize2 writeBuffer;
                /*0x70*/ object ioLock;
                /*0x78*/ int closeRequested;
                /*0x7c*/ bool shutdown;
                /*0x80*/ Mono.Net.Security.MobileAuthenticatedStream.Operation operation;
                /*0x88*/ System.Net.Security.SslStream <SslStream>k__BackingField;
                /*0x90*/ Mono.Security.Interface.MonoTlsSettings <Settings>k__BackingField;
                /*0x98*/ Mono.Net.Security.MobileTlsProvider <Provider>k__BackingField;
                /*0xa0*/ string <TargetHost>k__BackingField;
                /*0xa8*/ int ID;

                static /*0x74537fc*/ MobileAuthenticatedStream();
                static /*0x7450168*/ System.Exception GetSSPIException(System.Exception e);
                static /*0x7452338*/ System.Exception GetIOException(System.Exception e, string message);
                static /*0x74524b4*/ System.Exception GetInternalError();
                static /*0x7452500*/ System.Exception GetInvalidNestedCallException();
                /*0x744e748*/ MobileAuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
                /*0x7452250*/ System.Net.Security.SslStream get_SslStream();
                /*0x7452258*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x7452260*/ Mono.Net.Security.MobileTlsProvider get_Provider();
                /*0x7452268*/ string get_TargetHost();
                /*0x7452270*/ void set_TargetHost(string value);
                /*0x7452278*/ void CheckThrow(bool authSuccessCheck, bool shutdownCheck);
                /*0x744fb70*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e);
                /*0x745254c*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x74528c0*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x7452790*/ System.Threading.Tasks.Task ProcessAuthentication(bool runSynchronously, Mono.Net.Security.MonoSslAuthenticationOptions options, System.Threading.CancellationToken cancellationToken);
                /*0x380bb68*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x74529dc*/ int Read(byte[] buffer, int offset, int count);
                /*0x7452c18*/ void Write(byte[] buffer, int offset, int count);
                /*0x7452ce4*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7452d78*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7452abc*/ System.Threading.Tasks.Task<int> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken);
                /*0x744ccf4*/ int InternalRead(byte[] buffer, int offset, int size, ref bool outWantMore);
                /*0x7452e0c*/ System.ValueTuple<int, bool> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size);
                /*0x744c7f8*/ bool InternalWrite(byte[] buffer, int offset, int size);
                /*0x7452f84*/ bool InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size);
                /*0x7450824*/ System.Threading.Tasks.Task<int> InnerRead(bool sync, int requestedSize, System.Threading.CancellationToken cancellationToken);
                /*0x74502fc*/ System.Threading.Tasks.Task InnerWrite(bool sync, System.Threading.CancellationToken cancellationToken);
                /*0x7450a0c*/ Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status, bool renegotiate);
                /*0x7450f5c*/ System.ValueTuple<int, bool> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x7451140*/ System.ValueTuple<int, bool> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x7453078*/ bool get_IsAuthenticated();
                /*0x7453164*/ void Dispose(bool disposing);
                /*0x74533bc*/ void Flush();
                /*0x74533e0*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x74534c0*/ System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate();
                /*0x74535c4*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x74535fc*/ void SetLength(long value);
                /*0x7453620*/ bool get_CanRead();
                /*0x7453664*/ bool get_CanTimeout();
                /*0x7453684*/ bool get_CanWrite();
                /*0x74536e8*/ bool get_CanSeek();
                /*0x74536f0*/ long get_Length();
                /*0x7453710*/ long get_Position();
                /*0x7453734*/ void set_Position(long value);
                /*0x745376c*/ int get_ReadTimeout();
                /*0x7453790*/ void set_ReadTimeout(int value);
                /*0x74537b4*/ int get_WriteTimeout();
                /*0x74537d8*/ void set_WriteTimeout(int value);
                /*0x7453848*/ void <InnerWrite>b__67_0();

                enum Operation
                {
                    None = 0,
                    Handshake = 1,
                    Authenticated = 2,
                    Renegotiate = 3,
                    Read = 4,
                    Write = 5,
                    Close = 6,
                }

                enum OperationType
                {
                    Read = 0,
                    Write = 1,
                    Renegotiate = 2,
                    Shutdown = 3,
                }

                struct <ProcessAuthentication>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoSslAuthenticationOptions options;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool runSynchronously;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Mono.Net.Security.AsyncProtocolResult> <>u__1;

                    /*0x745387c*/ void MoveNext();
                    /*0x74541d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <StartOperation>d__57 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream.OperationType type;
                    /*0x40*/ Mono.Net.Security.AsyncProtocolRequest asyncRequest;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Mono.Net.Security.AsyncProtocolResult> <>u__1;

                    /*0x7454240*/ void MoveNext();
                    /*0x7454a10*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass66_0
                {
                    /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x18*/ int len;

                    /*0x7454a8c*/ <>c__DisplayClass66_0();
                    /*0x7454a94*/ int <InnerRead>b__0();
                }

                struct <InnerRead>d__66 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ int requestedSize;
                    /*0x44*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                    /*0x7454adc*/ void MoveNext();
                    /*0x7454f98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerWrite>d__67 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x7455014*/ void MoveNext();
                    /*0x7455320*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class MobileTlsContext : System.IDisposable
            {
                /*0x10*/ Mono.Net.Security.ChainValidationHelper certificateValidator;
                /*0x18*/ Mono.Net.Security.MonoSslAuthenticationOptions <Options>k__BackingField;
                /*0x20*/ Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField;
                /*0x28*/ bool <IsServer>k__BackingField;
                /*0x30*/ string <TargetHost>k__BackingField;
                /*0x38*/ string <ServerName>k__BackingField;
                /*0x40*/ bool <AskForClientCertificate>k__BackingField;
                /*0x44*/ System.Security.Authentication.SslProtocols <EnabledProtocols>k__BackingField;
                /*0x48*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;
                /*0x50*/ System.Security.Cryptography.X509Certificates.X509Certificate <LocalServerCertificate>k__BackingField;

                /*0x744b568*/ MobileTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x7455388*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x744bfb4*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x380b128*/ bool get_IsAuthenticated();
                /*0x7455390*/ bool get_IsServer();
                /*0x7455398*/ string get_TargetHost();
                /*0x74553a0*/ string get_ServerName();
                /*0x74553a8*/ bool get_AskForClientCertificate();
                /*0x74553b0*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x380cb08*/ void StartHandshake();
                /*0x380b128*/ bool ProcessHandshake();
                /*0x380cb08*/ void FinishHandshake();
                /*0x74553b8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate();
                /*0x74553c0*/ void set_LocalServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
                /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
                System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
                System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
                /*0x380cb08*/ void Shutdown();
                /*0x380b128*/ bool PendingRenegotiation();
                /*0x744c3d0*/ bool ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x744d598*/ System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(string[] acceptableIssuers);
                /*0x380cb08*/ void Renegotiate();
                /*0x745334c*/ void Dispose();
                /*0x74553c8*/ void Dispose(bool disposing);
                /*0x74553cc*/ void Finalize();
            }

            class MobileTlsProvider : Mono.Security.Interface.MonoTlsProvider
            {
                /*0x744e740*/ MobileTlsProvider();
                Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
                bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
            }

            class MonoSslAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;

                /*0x7455478*/ MonoSslAuthenticationOptions();
                /*0x380b128*/ bool get_ServerMode();
                /*0x380b6a0*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x380cffc*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x380cffc*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x380cffc*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x380b9e8*/ string get_TargetHost();
                /*0x380d83c*/ void set_TargetHost(string value);
                /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x380d83c*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x380b128*/ bool get_ClientCertificateRequired();
                /*0x7455470*/ System.Net.Security.ServerCertSelectionCallback get_ServerCertSelectionDelegate();
            }

            class MonoSslClientAuthenticationOptions : Mono.Net.Security.MonoSslAuthenticationOptions
            {
                /*0x18*/ System.Net.Security.SslClientAuthenticationOptions <Options>k__BackingField;

                /*0x7452724*/ MonoSslClientAuthenticationOptions();
                /*0x7455480*/ System.Net.Security.SslClientAuthenticationOptions get_Options();
                /*0x7455488*/ bool get_ServerMode();
                /*0x7455490*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x74554ac*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x74554c8*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x74554e4*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x7455500*/ string get_TargetHost();
                /*0x745551c*/ void set_TargetHost(string value);
                /*0x7455538*/ bool get_ClientCertificateRequired();
                /*0x7455570*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x745558c*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x74555a8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
            }

            class MonoTlsProviderFactory
            {
                static /*0x0*/ object locker;
                static /*0x8*/ bool initialized;
                static /*0x10*/ Mono.Net.Security.MobileTlsProvider defaultProvider;
                static /*0x18*/ System.Collections.Generic.Dictionary<string, System.Tuple<System.Guid, string>> providerRegistration;
                static /*0x20*/ System.Collections.Generic.Dictionary<System.Guid, Mono.Net.Security.MobileTlsProvider> providerCache;
                static /*0x28*/ System.Guid UnityTlsId;
                static /*0x38*/ System.Guid AppleTlsId;
                static /*0x48*/ System.Guid BtlsId;

                static /*0x745644c*/ MonoTlsProviderFactory();
                static /*0x7451708*/ Mono.Net.Security.MobileTlsProvider GetProviderInternal();
                static /*0x74555e0*/ void InitializeInternal();
                static /*0x7455d18*/ Mono.Net.Security.MobileTlsProvider LookupProvider(string name, bool throwOnError);
                static /*0x745598c*/ void InitializeProviderRegistration();
                static /*0x7456270*/ void PopulateUnityProviders();
                static /*0x74563b0*/ void PopulateProviders();
                static /*0x7455b90*/ Mono.Net.Security.MobileTlsProvider CreateDefaultProviderImpl();
                static /*0x7456400*/ Mono.Net.Security.MobileTlsProvider GetProvider();
            }

            class MonoTlsStream : System.IDisposable
            {
                /*0x10*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x18*/ System.Net.Sockets.NetworkStream networkStream;
                /*0x20*/ System.Net.HttpWebRequest request;
                /*0x28*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x30*/ System.Net.Security.SslStream sslStream;
                /*0x38*/ object sslStreamLock;
                /*0x40*/ System.Net.WebExceptionStatus status;
                /*0x44*/ bool <CertificateValidationFailed>k__BackingField;

                /*0x74565b0*/ MonoTlsStream(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream);
                /*0x745658c*/ System.Net.HttpWebRequest get_Request();
                /*0x7456594*/ System.Net.WebExceptionStatus get_ExceptionStatus();
                /*0x745659c*/ bool get_CertificateValidationFailed();
                /*0x74565a4*/ void set_CertificateValidationFailed(bool value);
                /*0x74567dc*/ System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken);
                /*0x7456928*/ void Dispose();
                /*0x745692c*/ void CloseSslStream();

                struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoTlsStream <>4__this;
                    /*0x38*/ System.Net.WebConnectionTunnel tunnel;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Net.Sockets.Socket <socket>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x7456a10*/ void MoveNext();
                    /*0x7457164*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NoReflectionHelper
            {
                static /*0x74571e0*/ object GetProvider();
            }

            class SystemCertificateValidator
            {
                static /*0x0*/ bool is_macosx;
                static /*0x4*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;

                static /*0x745722c*/ SystemCertificateValidator();
                static /*0x74520e8*/ bool NeedsChain(Mono.Security.Interface.MonoTlsSettings settings);
            }

            namespace Private
            {
                class CallbackHelpers
                {
                    static /*0x7456714*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback PublicToMono(System.Net.Security.RemoteCertificateValidationCallback callback);
                    static /*0x7451920*/ System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback callback;

                        /*0x745727c*/ <>c__DisplayClass0_0();
                        /*0x745728c*/ bool <PublicToMono>b__0(string h, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, Mono.Security.Interface.MonoSslPolicyErrors e);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback;

                        /*0x7457284*/ <>c__DisplayClass6_0();
                        /*0x74572b0*/ System.Security.Cryptography.X509Certificates.X509Certificate <MonoToInternal>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
                    }
                }
            }
        }
    }

    namespace Http
    {
        class NtlmSession
        {
            /*0x10*/ Mono.Security.Protocol.Ntlm.MessageBase message;

            /*0x74572d4*/ NtlmSession();
            /*0x74572dc*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession> cache;

            static /*0x7457b34*/ NtlmClient();
            /*0x7457b2c*/ NtlmClient();
            /*0x7457770*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x7457ae4*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x7457aec*/ string get_AuthenticationType();

            class <>c
            {
                static /*0x0*/ Mono.Http.NtlmClient.<> <>9;
                static /*0x8*/ System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<System.Net.HttpWebRequest, Mono.Http.NtlmSession> <>9__1_0;

                static /*0x7457bcc*/ <>c();
                /*0x7457c34*/ <>c();
                /*0x7457c3c*/ Mono.Http.NtlmSession <Authenticate>b__1_0(System.Net.HttpWebRequest x);
            }
        }
    }
}

namespace Internal
{
    namespace Cryptography
    {
        class OidLookup
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid;
            static /*0x10*/ System.Collections.Generic.Dictionary<string, string> s_friendlyNameToOid;
            static /*0x18*/ System.Collections.Generic.Dictionary<string, string> s_oidToFriendlyName;
            static /*0x20*/ System.Collections.Generic.Dictionary<string, string> s_compatOids;

            static /*0x7458790*/ OidLookup();
            static /*0x7457c90*/ string ToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x7458224*/ string ToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x7457e6c*/ bool ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup);
            static /*0x7457e74*/ string NativeOidToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x74583d4*/ string NativeFriendlyNameToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);

            class <>c
            {
                static /*0x0*/ Internal.Cryptography.OidLookup.<> <>9;

                static /*0x745a478*/ <>c();
                /*0x745a4e0*/ <>c();
                /*0x745a4e8*/ string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<string, string> kvp);
                /*0x745a524*/ string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<string, string> kvp);
            }
        }

        namespace Pal
        {
            enum GeneralNameType
            {
                OtherName = 0,
                Rfc822Name = 1,
                Email = 1,
                DnsName = 2,
                X400Address = 3,
                DirectoryName = 4,
                EdiPartyName = 5,
                UniformResourceIdentifier = 6,
                IPAddress = 7,
                RegisteredId = 8,
            }

            struct CertificateData
            {
                /*0x10*/ byte[] RawData;
                /*0x18*/ byte[] SubjectPublicKeyInfo;
                /*0x20*/ int Version;
                /*0x28*/ byte[] SerialNumber;
                /*0x30*/ Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier TbsSignature;
                /*0x40*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName Issuer;
                /*0x48*/ System.DateTime NotBefore;
                /*0x50*/ System.DateTime NotAfter;
                /*0x58*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName Subject;
                /*0x60*/ Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier PublicKeyAlgorithm;
                /*0x70*/ byte[] PublicKey;
                /*0x78*/ byte[] IssuerUniqueId;
                /*0x80*/ byte[] SubjectUniqueId;
                /*0x88*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Extension> Extensions;
                /*0x90*/ Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier SignatureAlgorithm;
                /*0xa0*/ byte[] SignatureValue;

                static /*0x745b3c4*/ string GetSimpleNameInfo(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                static /*0x745b81c*/ string FindAltNameMatch(byte[] extensionBytes, Internal.Cryptography.Pal.GeneralNameType matchType, string otherOid);
                static /*0x745b9dc*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                /*0x745a560*/ CertificateData(byte[] rawData);
                /*0x745ad54*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);

                struct AlgorithmIdentifier
                {
                    /*0x10*/ string AlgorithmId;
                    /*0x18*/ byte[] Parameters;
                }

                class <ReadReverseRdns>d__21 : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, string> <>2__current;
                    /*0x28*/ int <>l__initialThreadId;
                    /*0x30*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName name;
                    /*0x38*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName <>3__name;
                    /*0x40*/ System.Collections.Generic.Stack<System.Security.Cryptography.DerSequenceReader> <rdnReaders>5__2;
                    /*0x48*/ System.Security.Cryptography.DerSequenceReader <rdnReader>5__3;

                    /*0x745ba58*/ <ReadReverseRdns>d__21(int <>1__state);
                    /*0x745ba8c*/ void System.IDisposable.Dispose();
                    /*0x745ba90*/ bool MoveNext();
                    /*0x745bd58*/ System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current();
                    /*0x745bd64*/ void System.Collections.IEnumerator.Reset();
                    /*0x745bd9c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x745bdf8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator();
                    /*0x745be9c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }
        }
    }
}

namespace Microsoft
{
    namespace Win32
    {
        class NativeMethods
        {
            static /*0x745bea0*/ bool DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.HandleRef hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, ref Microsoft.Win32.SafeHandles.SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
            static /*0x745c014*/ nint GetCurrentProcess();
            static /*0x745c018*/ bool GetExitCodeProcess(nint processHandle, ref int exitCode);
            static /*0x745c01c*/ bool GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, ref int exitCode);
            static /*0x745c114*/ int GetCurrentProcessId();
            static /*0x745c118*/ bool CloseProcess(nint handle);
        }

        namespace SafeHandles
        {
            class SafeProcessHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle InvalidHandle;

                static /*0x745c150*/ SafeProcessHandle();
                /*0x745c11c*/ SafeProcessHandle(nint handle);
                /*0x745bfe8*/ SafeProcessHandle(nint existingHandle, bool ownsHandle);
                /*0x745c148*/ bool ReleaseHandle();
            }
        }
    }
}

namespace System
{
    class IPv4AddressHelper
    {
        static /*0x745c1c0*/ int ParseHostNumber(System.ReadOnlySpan<char> str, int start, int end);
        static /*0x745c280*/ bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme);
        static /*0x745c1f0*/ bool ParseCanonical(System.ReadOnlySpan<char> name, byte* numbers, int start, int end);
        static /*0x745c2b0*/ bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile);
        static /*0x745c3f8*/ long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile);
        static /*0x745c6f0*/ string ParseCanonicalName(string str, int start, int end, ref bool isLoopback);
        static /*0x745c8ec*/ bool Parse(string name, byte* numbers, int start, int end);
    }

    class IPv6AddressHelper
    {
        static /*0x77e7edc*/ System.ValueTuple<int, int> FindCompressionRange(System.ReadOnlySpan<ushort> numbers);
        static /*0x77e7fbc*/ bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<ushort> numbers);
        static /*0x77e808c*/ bool IsValidStrict(char* name, int start, ref int end);
        static /*0x77e83d0*/ void Parse(System.ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId);
        static /*0x77e8880*/ string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId);
        static /*0x77e8e2c*/ bool IsLoopback(System.ReadOnlySpan<ushort> numbers);
        static /*0x77e8f0c*/ bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress);
        static /*0x77e91e4*/ bool IsValid(char* name, int start, ref int end);
    }

    class NotImplemented
    {
        static /*0x77e91ec*/ System.Exception ByDesignWithMessage(string message);
    }

    class UriBuilder
    {
        /*0x10*/ bool _changed;
        /*0x18*/ string _fragment;
        /*0x20*/ string _host;
        /*0x28*/ string _password;
        /*0x30*/ string _path;
        /*0x38*/ int _port;
        /*0x40*/ string _query;
        /*0x48*/ string _scheme;
        /*0x50*/ string _schemeDelimiter;
        /*0x58*/ System.Uri _uri;
        /*0x60*/ string _username;

        /*0x77e9248*/ UriBuilder(System.Uri uri);
        /*0x77e97b8*/ UriBuilder(string schemeName, string hostName);
        /*0x77e9b74*/ UriBuilder(string scheme, string host, int portNumber);
        /*0x77e9c08*/ UriBuilder(string scheme, string host, int port, string pathValue);
        /*0x77e9d00*/ UriBuilder(string scheme, string host, int port, string path, string extraValue);
        /*0x77e9408*/ void Init(System.Uri uri);
        /*0x77e9e38*/ void set_Extra(string value);
        /*0x77e9fc0*/ void set_Fragment(string value);
        /*0x77e9a88*/ void set_Host(string value);
        /*0x77ea130*/ string get_Path();
        /*0x77e9c40*/ void set_Path(string value);
        /*0x77e9b9c*/ void set_Port(int value);
        /*0x77ea138*/ string get_Query();
        /*0x77ea078*/ void set_Query(string value);
        /*0x77e9944*/ void set_Scheme(string value);
        /*0x77ea140*/ System.Uri get_Uri();
        /*0x77ea1e0*/ bool Equals(object rparam);
        /*0x77ea23c*/ int GetHashCode();
        /*0x77e95e4*/ void SetFieldsFromUri(System.Uri uri);
        /*0x77ea25c*/ string ToString();
    }

    class SecurityUtils
    {
        static /*0x77ea800*/ void DemandReflectionAccess(System.Type type);
        static /*0x77ea804*/ void DemandGrantSet(System.Reflection.Assembly assembly);
        static /*0x77ea808*/ bool HasReflectionPermission(System.Type type);
        static /*0x77ea810*/ object SecureCreateInstance(System.Type type);
        static /*0x77ea81c*/ object SecureCreateInstance(System.Type type, object[] args, bool allowNonPublic);
        static /*0x77ea8ec*/ object SecureCreateInstance(System.Type type, object[] args);
        static /*0x77ea8f4*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic);
        static /*0x77ea900*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic, System.Reflection.BindingFlags extraFlags);
        static /*0x77eaa68*/ bool GenericArgumentsAreVisible(System.Reflection.MethodInfo method);
        static /*0x77eab18*/ object MethodInfoInvoke(System.Reflection.MethodInfo method, object target, object[] args);
    }

    class InvariantComparer : System.Collections.IComparer
    {
        static /*0x0*/ System.InvariantComparer Default;
        /*0x10*/ System.Globalization.CompareInfo m_compareInfo;

        static /*0x77ead68*/ InvariantComparer();
        /*0x77eac04*/ InvariantComparer();
        /*0x77eac88*/ int Compare(object a, object b);
    }

    class IriHelper
    {
        static /*0x77eadcc*/ bool CheckIriUnicodeRange(char unicode, bool isQuery);
        static /*0x77eae24*/ bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery);
        static /*0x77eb440*/ bool CheckIsReserved(char ch, System.UriComponents component);
        static /*0x77eb584*/ string EscapeUnescapeIri(char* pInput, int start, int end, System.UriComponents component);
    }

    class Uri : System.Runtime.Serialization.ISerializable
    {
        static int c_Max16BitUtf8SequenceLength = 12;
        static int c_MaxUriBufferSize = 65520;
        static int c_MaxUriSchemeName = 1024;
        static System.UriKind DotNetRelativeOrAbsolute = 300;
        static System.UriFormat V1ToStringUnescape = 32767;
        static char c_DummyChar = 65535;
        static char c_EOL = 65534;
        static /*0x0*/ string UriSchemeFile;
        static /*0x8*/ string UriSchemeFtp;
        static /*0x10*/ string UriSchemeGopher;
        static /*0x18*/ string UriSchemeHttp;
        static /*0x20*/ string UriSchemeHttps;
        static /*0x28*/ string UriSchemeWs;
        static /*0x30*/ string UriSchemeWss;
        static /*0x38*/ string UriSchemeMailto;
        static /*0x40*/ string UriSchemeNews;
        static /*0x48*/ string UriSchemeNntp;
        static /*0x50*/ string UriSchemeNetTcp;
        static /*0x58*/ string UriSchemeNetPipe;
        static /*0x60*/ string SchemeDelimiter;
        static /*0x68*/ bool s_ConfigInitialized;
        static /*0x69*/ bool s_ConfigInitializing;
        static /*0x6c*/ System.UriIdnScope s_IdnScope;
        static /*0x70*/ bool s_IriParsing;
        static /*0x71*/ bool useDotNetRelativeOrAbsolute;
        static /*0x72*/ bool IsWindowsFileSystem;
        static /*0x78*/ object s_initLock;
        static /*0x80*/ char[] HexLowerChars;
        static /*0x88*/ char[] _WSchars;
        /*0x10*/ string m_String;
        /*0x18*/ string m_originalUnicodeString;
        /*0x20*/ System.UriParser m_Syntax;
        /*0x28*/ string m_DnsSafeHost;
        /*0x30*/ System.Uri.Flags m_Flags;
        /*0x38*/ System.Uri.UriInfo m_Info;
        /*0x40*/ bool m_iriParsing;

        static /*0x77ca48c*/ Uri();
        static /*0x77bcd68*/ bool IriParsingStatic(System.UriParser syntax);
        static /*0x77bcf88*/ bool StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x77bd028*/ bool StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x77bf4b8*/ System.ParsingError GetCombinedString(System.Uri baseUri, string relativeStr, bool dontEscape, ref string result);
        static /*0x77c0248*/ System.UriFormatException GetException(System.ParsingError err);
        static /*0x77c15a8*/ bool StaticIsFile(System.UriParser syntax);
        static /*0x77c15c0*/ object get_InitializeLock();
        static /*0x77c168c*/ void InitializeUriConfig();
        static /*0x77c245c*/ bool IsGenDelim(char ch);
        static /*0x77c248c*/ bool CheckSchemeName(string schemeName);
        static /*0x77c2674*/ bool IsHexDigit(char character);
        static /*0x77c26b0*/ int FromHex(char digit);
        static /*0x77c2c20*/ bool op_Equality(System.Uri uri1, System.Uri uri2);
        static /*0x77bf0ec*/ bool op_Inequality(System.Uri uri1, System.Uri uri2);
        static /*0x77c3320*/ bool CheckForColonInFirstPathSegment(string uriString);
        static /*0x77c33d8*/ string InternalEscapeString(string rawString);
        static /*0x77c34ac*/ System.ParsingError ParseScheme(string uriString, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x77c55dc*/ string CreateHostStringHelper(string str, ushort idx, ushort end, ref System.Uri.Flags flags, ref string scopeId);
        static /*0x77c3584*/ ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x77c7780*/ bool CheckKnownSchemes(long* lptr, ushort nChars, ref System.UriParser syntax);
        static /*0x77bf714*/ System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref System.UriParser syntax);
        static /*0x77c85a8*/ void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3);
        static /*0x77c182c*/ char[] Compress(char[] dest, ushort start, ref int destLength, System.UriParser syntax);
        static /*0x77c28a0*/ int CalculateCaseInsensitiveHashCode(string text);
        static /*0x77bf87c*/ string CombineUri(System.Uri basePart, string relativePart, System.UriFormat uriFormat);
        static /*0x77c420c*/ bool IsLWS(char ch);
        static /*0x77c25cc*/ bool IsAsciiLetter(char character);
        static /*0x77c25f8*/ bool IsAsciiLetterOrDigit(char character);
        static /*0x77c87d0*/ bool IsBidiControlCharacter(char ch);
        static /*0x77c83b0*/ string StripBidiControlCharacter(char* strToClean, int start, int length);
        static /*0x77c3250*/ bool TryCreate(string uriString, System.UriKind uriKind, ref System.Uri result);
        static /*0x77c93bc*/ bool TryCreate(System.Uri baseUri, string relativeUri, ref System.Uri result);
        static /*0x77c94a4*/ bool TryCreate(System.Uri baseUri, System.Uri relativeUri, ref System.Uri result);
        static /*0x77c9d18*/ bool IsWellFormedUriString(string uriString, System.UriKind uriKind);
        static /*0x77c9db4*/ string UnescapeDataString(string stringToUnescape);
        static /*0x77c9f54*/ string EscapeUriString(string stringToEscape);
        static /*0x77ca074*/ string EscapeDataString(string stringToEscape);
        static /*0x77c9154*/ System.Uri CreateHelper(string uriString, bool dontEscape, System.UriKind uriKind, ref System.UriFormatException e);
        static /*0x77bec08*/ System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, ref string newUriString, ref bool userEscaped, ref System.UriFormatException e);
        /*0x77be6dc*/ Uri(string uriString);
        /*0x77be918*/ Uri(string uriString, System.UriKind uriKind);
        /*0x77be99c*/ Uri(System.Uri baseUri, string relativeUri);
        /*0x77bf288*/ Uri(System.Uri baseUri, System.Uri relativeUri);
        /*0x77c03e8*/ Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x77ca194*/ Uri(System.Uri.Flags flags, System.UriParser uriParser, string uri);
        /*0x77bcd10*/ bool get_IsImplicitFile();
        /*0x77bcd1c*/ bool get_IsUncOrDosPath();
        /*0x77bcd2c*/ bool get_IsDosPath();
        /*0x77bcd38*/ bool get_IsUncPath();
        /*0x77bcd44*/ System.Uri.Flags get_HostType();
        /*0x77bcd50*/ System.UriParser get_Syntax();
        /*0x77bcd58*/ bool get_IsNotAbsoluteUri();
        /*0x77bcdf4*/ bool get_AllowIdn();
        /*0x77bcec0*/ bool AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags);
        /*0x77bcf94*/ bool IsIntranet(string schemeHost);
        /*0x77bcf9c*/ bool get_UserDrivenParsing();
        /*0x77bcfa8*/ void SetUserDrivenParsing();
        /*0x77bcfbc*/ ushort get_SecuredPathIndex();
        /*0x77bceb0*/ bool NotAny(System.Uri.Flags flags);
        /*0x77bd018*/ bool InFact(System.Uri.Flags flags);
        /*0x77bd034*/ System.Uri.UriInfo EnsureUriInfo();
        /*0x77bd604*/ void EnsureParseRemaining();
        /*0x77be26c*/ void EnsureHostString(bool allowDnsOptimization);
        /*0x77bea6c*/ void CreateUri(System.Uri baseUri, string relativeUri, bool dontEscape);
        /*0x77c04e8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x77c04ec*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x77c05bc*/ string get_AbsolutePath();
        /*0x77c067c*/ string get_PrivateAbsolutePath();
        /*0x77c0748*/ string get_AbsoluteUri();
        /*0x77c0868*/ string get_LocalPath();
        /*0x77c0ec0*/ string get_Authority();
        /*0x77c0f34*/ System.UriHostNameType get_HostNameType();
        /*0x77c102c*/ bool get_IsDefaultPort();
        /*0x77c10d4*/ bool get_IsFile();
        /*0x77c1194*/ bool get_IsLoopback();
        /*0x77c1214*/ string get_PathAndQuery();
        /*0x77c12dc*/ string[] get_Segments();
        /*0x77c14c0*/ bool get_IsUnc();
        /*0x77c1534*/ string get_Host();
        /*0x77c08d4*/ string GetLocalPath();
        /*0x77c1dd0*/ int get_Port();
        /*0x77c1e94*/ string get_Query();
        /*0x77c1fb8*/ string get_Fragment();
        /*0x77c20dc*/ string get_Scheme();
        /*0x77c214c*/ bool get_OriginalStringSwitched();
        /*0x77bf854*/ string get_OriginalString();
        /*0x77c2194*/ string get_DnsSafeHost();
        /*0x77bea5c*/ bool get_IsAbsoluteUri();
        /*0x77c23dc*/ bool get_UserEscaped();
        /*0x77c23e8*/ string get_UserInfo();
        /*0x77c275c*/ int GetHashCode();
        /*0x77c2940*/ string ToString();
        /*0x77c2c54*/ bool Equals(object comparand);
        /*0x77c3af4*/ System.UriFormatException ParseMinimal();
        /*0x77c3b74*/ System.ParsingError PrivateParseMinimal();
        /*0x77c50a8*/ void PrivateParseMinimalIri(string newHost, ushort idx);
        /*0x77bd058*/ void CreateUriInfo(System.Uri.Flags cF);
        /*0x77be2cc*/ void CreateHostString();
        /*0x77c519c*/ void GetHostViaCustomSyntax();
        /*0x77c05b8*/ string GetParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x77c5d70*/ string GetEscapedParts(System.UriComponents uriParts);
        /*0x77c1d00*/ string GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x77c63c4*/ string ReCreateParts(System.UriComponents parts, ushort nonCanonical, System.UriFormat formatAs);
        /*0x77c5e38*/ string GetUriPartsFromUserString(System.UriComponents uriParts);
        /*0x77bd614*/ void ParseRemaining();
        /*0x77c4244*/ ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, System.UriParser syntax, ref string newHost);
        /*0x77c7d04*/ void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, System.UriParser syntax, string userInfoString, ref System.Uri.Flags flags, ref bool justNormalized, ref string newHost, ref System.ParsingError err);
        /*0x77c809c*/ void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, System.UriParser syntax, ref System.Uri.Flags flags, ref string newHost, ref System.ParsingError err);
        /*0x77c76dc*/ void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim);
        /*0x77c8510*/ void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim);
        /*0x77c57b8*/ System.Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim);
        /*0x77c7068*/ char[] GetCanonicalPath(char[] dest, ref int pos, System.UriFormat formatAs);
        /*0x77c87c4*/ bool get_HasAuthority();
        /*0x77be75c*/ void CreateThis(string uri, bool dontEscape, System.UriKind uriKind);
        /*0x77c8800*/ void InitializeUri(System.ParsingError err, System.UriKind uriKind, ref System.UriFormatException e);
        /*0x77c8d80*/ bool CheckForConfigLoad(string data);
        /*0x77c8e64*/ bool CheckForUnicode(string data);
        /*0x77c8f90*/ bool CheckForEscapedUnreserved(string data);
        /*0x77c5ba8*/ string GetComponents(System.UriComponents components, System.UriFormat format);
        /*0x77c985c*/ bool IsWellFormedOriginalString();
        /*0x77c98a0*/ bool InternalIsWellFormedOriginalString();
        /*0x77c7730*/ string EscapeUnescapeIri(string input, int start, int end, System.UriComponents component);
        /*0x77c964c*/ string GetRelativeSerializationString(System.UriFormat format);
        /*0x77c2a18*/ string GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x77ca1e8*/ bool IsBaseOf(System.Uri uri);
        /*0x77ca29c*/ bool IsBaseOfHelper(System.Uri uriLink);
        /*0x77bf134*/ void CreateThisFromUri(System.Uri otherUri);

        enum Flags
        {
            Zero = 0,
            SchemeNotCanonical = 1,
            UserNotCanonical = 2,
            HostNotCanonical = 4,
            PortNotCanonical = 8,
            PathNotCanonical = 16,
            QueryNotCanonical = 32,
            FragmentNotCanonical = 64,
            CannotDisplayCanonical = 127,
            E_UserNotCanonical = 128,
            E_HostNotCanonical = 256,
            E_PortNotCanonical = 512,
            E_PathNotCanonical = 1024,
            E_QueryNotCanonical = 2048,
            E_FragmentNotCanonical = 4096,
            E_CannotDisplayCanonical = 8064,
            ShouldBeCompressed = 8192,
            FirstSlashAbsent = 16384,
            BackslashInPath = 32768,
            IndexMask = 65535,
            HostTypeMask = 458752,
            HostNotParsed = 0,
            IPv6HostType = 65536,
            IPv4HostType = 131072,
            DnsHostType = 196608,
            UncHostType = 262144,
            BasicHostType = 327680,
            UnusedHostType = 393216,
            UnknownHostType = 458752,
            UserEscaped = 524288,
            AuthorityFound = 1048576,
            HasUserInfo = 2097152,
            LoopbackHost = 4194304,
            NotDefaultPort = 8388608,
            UserDrivenParsing = 16777216,
            CanonicalDnsHost = 33554432,
            ErrorOrParsingRecursion = 67108864,
            DosPath = 134217728,
            UncPath = 268435456,
            ImplicitFile = 536870912,
            MinimalUriInfoSet = 1073741824,
            AllUriInfoSet = 2147483648,
            IdnHost = 4294967296,
            HasUnicode = 8589934592,
            HostUnicodeNormalized = 17179869184,
            RestUnicodeNormalized = 34359738368,
            UnicodeHost = 68719476736,
            IntranetUri = 137438953472,
            UseOrigUncdStrOffset = 274877906944,
            UserIriCanonical = 549755813888,
            PathIriCanonical = 1099511627776,
            QueryIriCanonical = 2199023255552,
            FragmentIriCanonical = 4398046511104,
            IriCanonical = 8246337208320,
            CompressedSlashes = 17592186044416,
        }

        class UriInfo
        {
            /*0x10*/ string Host;
            /*0x18*/ string ScopeId;
            /*0x20*/ string String;
            /*0x28*/ System.Uri.Offset Offset;
            /*0x38*/ string DnsSafeHost;
            /*0x40*/ System.Uri.MoreInfo MoreInfo;

            /*0x77ec500*/ UriInfo();
        }

        struct Offset
        {
            /*0x10*/ ushort Scheme;
            /*0x12*/ ushort User;
            /*0x14*/ ushort Host;
            /*0x16*/ ushort PortValue;
            /*0x18*/ ushort Path;
            /*0x1a*/ ushort Query;
            /*0x1c*/ ushort Fragment;
            /*0x1e*/ ushort End;
        }

        class MoreInfo
        {
            /*0x10*/ string Path;
            /*0x18*/ string Query;
            /*0x20*/ string Fragment;
            /*0x28*/ string AbsoluteUri;
            /*0x30*/ int Hash;
            /*0x38*/ string RemoteUrl;

            /*0x77ec508*/ MoreInfo();
        }

        enum Check
        {
            None = 0,
            EscapedCanonical = 1,
            DisplayCanonical = 2,
            DotSlashAttn = 4,
            DotSlashEscaped = 128,
            BackslashInPath = 16,
            ReservedFound = 32,
            NotIriCanonical = 64,
            FoundNonAscii = 8,
        }
    }

    class UriFormatException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        /*0x77ec510*/ UriFormatException();
        /*0x77ea704*/ UriFormatException(string textString);
        /*0x77ec518*/ UriFormatException(string textString, System.Exception e);
        /*0x77ec520*/ UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x77ec528*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
    }

    enum UriKind
    {
        RelativeOrAbsolute = 0,
        Absolute = 1,
        Relative = 2,
    }

    enum UriComponents
    {
        Scheme = 1,
        UserInfo = 2,
        Host = 4,
        Port = 8,
        Path = 16,
        Query = 32,
        Fragment = 64,
        StrongPort = 128,
        NormalizedHost = 256,
        KeepDelimiter = 1073741824,
        SerializationInfoString = -2147483648,
        AbsoluteUri = 127,
        HostAndPort = 132,
        StrongAuthority = 134,
        SchemeAndServer = 13,
        HttpRequestUrl = 61,
        PathAndQuery = 48,
    }

    enum UriFormat
    {
        UriEscaped = 1,
        Unescaped = 2,
        SafeUnescaped = 3,
    }

    enum UriIdnScope
    {
        None = 0,
        AllExceptIntranet = 1,
        All = 2,
    }

    enum ParsingError
    {
        None = 0,
        BadFormat = 1,
        BadScheme = 2,
        BadAuthority = 3,
        EmptyUriString = 4,
        LastRelativeUriOkErrIndex = 4,
        SchemeLimit = 5,
        SizeLimit = 6,
        MustRootedPath = 7,
        BadHostName = 8,
        NonEmptyHost = 9,
        BadPort = 10,
        BadAuthorityTerminator = 11,
        CannotCreateRelative = 12,
    }

    enum UnescapeMode
    {
        CopyOnly = 0,
        Escape = 1,
        Unescape = 2,
        EscapeUnescape = 3,
        V1ToStringFlag = 4,
        UnescapeAll = 8,
        UnescapeAllOrThrow = 24,
    }

    class UriHelper
    {
        static /*0x0*/ char[] HexUpperChars;

        static /*0x77edad8*/ UriHelper();
        static /*0x77ec530*/ bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase);
        static /*0x77ec720*/ char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd);
        static /*0x77ecc34*/ char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos);
        static /*0x77ecf48*/ char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x77ed028*/ char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x77ebf24*/ void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing);
        static /*0x77ec3f8*/ void EscapeAsciiChar(char ch, char[] to, ref int pos);
        static /*0x77ebddc*/ char EscapedAscii(char digit, char next);
        static /*0x77ebe98*/ bool IsNotSafeForUnescape(char ch);
        static /*0x77ece40*/ bool IsReservedUnreservedOrHash(char c);
        static /*0x77ecd60*/ bool IsUnreserved(char c);
        static /*0x77eda3c*/ bool Is3986Unreserved(char c);
    }

    enum UriHostNameType
    {
        Unknown = 0,
        Basic = 1,
        Dns = 2,
        IPv4 = 3,
        IPv6 = 4,
    }

    class UriParser
    {
        static System.UriSyntaxFlags SchemeOnlyFlags = 16;
        static System.UriSyntaxFlags c_UpdatableFlags = 33554432;
        static int NoDefaultPort = -1;
        static int c_InitialTableSize = 25;
        static int c_MaxCapacity = 512;
        static System.UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
        static System.UriSyntaxFlags FtpSyntaxFlags = 367005533;
        static System.UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
        static System.UriSyntaxFlags GopherSyntaxFlags = 337645405;
        static System.UriSyntaxFlags NewsSyntaxFlags = 268435536;
        static System.UriSyntaxFlags NntpSyntaxFlags = 337645405;
        static System.UriSyntaxFlags TelnetSyntaxFlags = 337645405;
        static System.UriSyntaxFlags LdapSyntaxFlags = 337645565;
        static System.UriSyntaxFlags MailtoSyntaxFlags = 335564796;
        static System.UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
        static System.UriSyntaxFlags NetTcpSyntaxFlags = 400559737;
        static /*0x0*/ System.Collections.Generic.Dictionary<string, System.UriParser> m_Table;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, System.UriParser> m_TempTable;
        static /*0x10*/ System.UriParser HttpUri;
        static /*0x18*/ System.UriParser HttpsUri;
        static /*0x20*/ System.UriParser WsUri;
        static /*0x28*/ System.UriParser WssUri;
        static /*0x30*/ System.UriParser FtpUri;
        static /*0x38*/ System.UriParser FileUri;
        static /*0x40*/ System.UriParser GopherUri;
        static /*0x48*/ System.UriParser NntpUri;
        static /*0x50*/ System.UriParser NewsUri;
        static /*0x58*/ System.UriParser MailToUri;
        static /*0x60*/ System.UriParser UuidUri;
        static /*0x68*/ System.UriParser TelnetUri;
        static /*0x70*/ System.UriParser LdapUri;
        static /*0x78*/ System.UriParser NetTcpUri;
        static /*0x80*/ System.UriParser NetPipeUri;
        static /*0x88*/ System.UriParser VsMacrosUri;
        static /*0x90*/ System.UriParser.UriQuirksVersion s_QuirksVersion;
        static /*0x94*/ System.UriSyntaxFlags HttpSyntaxFlags;
        static /*0x98*/ System.UriSyntaxFlags FileSyntaxFlags;
        /*0x10*/ System.UriSyntaxFlags m_Flags;
        /*0x14*/ System.UriSyntaxFlags m_UpdatableFlags;
        /*0x18*/ bool m_UpdatableFlagsUsed;
        /*0x1c*/ int m_Port;
        /*0x20*/ string m_Scheme;

        static /*0x77ee068*/ UriParser();
        static /*0x77ed9dc*/ bool get_ShouldUseLegacyV2Quirks();
        static /*0x77eea24*/ System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme);
        static /*0x77ea70c*/ System.UriParser GetSyntax(string lwrCaseScheme);
        /*0x77edb88*/ UriParser();
        /*0x77edbc4*/ UriParser(System.UriSyntaxFlags flags);
        /*0x77edb78*/ string get_SchemeName();
        /*0x77edb80*/ int get_DefaultPort();
        /*0x77edc08*/ System.UriParser OnNewUri();
        /*0x77edc0c*/ void InitializeAndValidate(System.Uri uri, ref System.UriFormatException parsingError);
        /*0x77edc3c*/ string Resolve(System.Uri baseUri, System.Uri relativeUri, ref System.UriFormatException parsingError);
        /*0x77ede1c*/ bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri);
        /*0x77ede38*/ string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format);
        /*0x77ee050*/ bool IsWellFormedOriginalString(System.Uri uri);
        /*0x77ee9b8*/ System.UriSyntaxFlags get_Flags();
        /*0x77ea7f8*/ bool NotAny(System.UriSyntaxFlags flags);
        /*0x77ea7dc*/ bool InFact(System.UriSyntaxFlags flags);
        /*0x77eea1c*/ bool IsAllSet(System.UriSyntaxFlags flags);
        /*0x77ee9c0*/ bool IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected);
        /*0x77eed04*/ bool get_IsSimple();
        /*0x77eed10*/ System.UriParser InternalOnNewUri();
        /*0x77eed70*/ void InternalValidate(System.Uri thisUri, ref System.UriFormatException parsingError);
        /*0x77eed7c*/ string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, ref System.UriFormatException parsingError);
        /*0x77eed88*/ bool InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink);
        /*0x77eed94*/ string InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x77eeda0*/ bool InternalIsWellFormedOriginalString(System.Uri thisUri);

        enum UriQuirksVersion
        {
            V2 = 2,
            V3 = 3,
        }

        class BuiltInUriParser : System.UriParser
        {
            /*0x77ee904*/ BuiltInUriParser(string lwrCaseScheme, int defaultPort, System.UriSyntaxFlags syntaxFlags);
        }
    }

    class DomainNameHelper
    {
        static /*0x77eedac*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x77eef44*/ bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x77ef174*/ bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x77ef364*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x77ef5f0*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost);
        static /*0x77ef83c*/ bool IsIdnAce(string input, int index);
        static /*0x77ef7f0*/ bool IsIdnAce(char* input, int index);
        static /*0x77ef8d4*/ string UnicodeEquivalent(string idnHost, char* hostname, int start, int end);
        static /*0x77ef9f4*/ string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x77ef0c4*/ bool IsASCIILetterOrDigit(char character, ref bool notCanonical);
        static /*0x77ef110*/ bool IsValidDomainLabelCharacter(char character, ref bool notCanonical);
    }

    class UncNameHelper
    {
        static /*0x77efe50*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x77efe54*/ bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile);
    }

    enum UriSyntaxFlags
    {
        None = 0,
        MustHaveAuthority = 1,
        OptionalAuthority = 2,
        MayHaveUserInfo = 4,
        MayHavePort = 8,
        MayHavePath = 16,
        MayHaveQuery = 32,
        MayHaveFragment = 64,
        AllowEmptyHost = 128,
        AllowUncHost = 256,
        AllowDnsHost = 512,
        AllowIPv4Host = 1024,
        AllowIPv6Host = 2048,
        AllowAnInternetHost = 3584,
        AllowAnyOtherHost = 4096,
        FileLikeUri = 8192,
        MailToLikeUri = 16384,
        V1_UnknownUri = 65536,
        SimpleUserSyntax = 131072,
        BuiltInSyntax = 262144,
        ParserSchemeOnly = 524288,
        AllowDOSPath = 1048576,
        PathIsRooted = 2097152,
        ConvertPathSlashes = 4194304,
        CompressPath = 8388608,
        CanonicalizeAsFilePath = 16777216,
        UnEscapeDotsAndSlashes = 33554432,
        AllowIdn = 67108864,
        AllowIriParsing = 268435456,
    }

    class LocalAppContextSwitches
    {
        static /*0x0*/ bool MemberDescriptorEqualsReturnsFalseIfEquivalent;
    }

    enum IOOperation
    {
        Read = 1,
        Write = 2,
    }

    class IOAsyncCallback : System.MulticastDelegate
    {
        /*0x77f0104*/ IOAsyncCallback(object object, nint method);
        /*0x77f020c*/ void Invoke(System.IOAsyncResult ioares);
    }

    class IOAsyncResult : System.IAsyncResult
    {
        /*0x10*/ System.AsyncCallback async_callback;
        /*0x18*/ object async_state;
        /*0x20*/ System.Threading.ManualResetEvent wait_handle;
        /*0x28*/ bool completed_synchronously;
        /*0x29*/ bool completed;

        /*0x77f0220*/ IOAsyncResult();
        /*0x77f0278*/ IOAsyncResult(System.AsyncCallback async_callback, object async_state);
        /*0x77f0228*/ void Init(System.AsyncCallback async_callback, object async_state);
        /*0x77f02bc*/ System.AsyncCallback get_AsyncCallback();
        /*0x77f02c4*/ object get_AsyncState();
        /*0x77f02cc*/ System.Threading.WaitHandle get_AsyncWaitHandle();
        /*0x77f03f0*/ bool get_CompletedSynchronously();
        /*0x77f03f8*/ void set_CompletedSynchronously(bool value);
        /*0x77f0404*/ bool get_IsCompleted();
        /*0x77f040c*/ void set_IsCompleted(bool value);
        /*0x380cb08*/ void CompleteDisposed();
    }

    class IOSelectorJob : System.Threading.IThreadPoolWorkItem
    {
        /*0x10*/ System.IOOperation operation;
        /*0x18*/ System.IOAsyncCallback callback;
        /*0x20*/ System.IOAsyncResult state;

        /*0x77f04e8*/ IOSelectorJob(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state);
        /*0x77f053c*/ void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem();
        /*0x77f0564*/ void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae);
        /*0x77f0568*/ void MarkDisposed();
    }

    class IOSelector
    {
        static /*0x77f0588*/ void Add(nint handle, System.IOSelectorJob job);
    }

    class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        /*0x77f058c*/ UriTypeConverter();
        /*0x77f0594*/ bool CanConvert(System.Type type);
        /*0x77f0650*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
        /*0x77f06d8*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        /*0x77f0724*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        /*0x77f08b4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
    }

    namespace Text
    {
        namespace RegularExpressions
        {
            class Capture
            {
                /*0x10*/ int <Index>k__BackingField;
                /*0x14*/ int <Length>k__BackingField;
                /*0x18*/ string <Text>k__BackingField;

                /*0x77f0a7c*/ Capture(string text, int index, int length);
                /*0x77f0c34*/ Capture();
                /*0x77f0ac4*/ int get_Index();
                /*0x77f0acc*/ void set_Index(int value);
                /*0x77f0ad4*/ int get_Length();
                /*0x77f0adc*/ void set_Length(int value);
                /*0x77f0ae4*/ string get_Text();
                /*0x77f0aec*/ void set_Text(string value);
                /*0x77f0af4*/ string get_Value();
                /*0x77f0b18*/ string ToString();
                /*0x77f0b1c*/ System.ReadOnlySpan<char> GetLeftSubstring();
                /*0x77f0ba4*/ System.ReadOnlySpan<char> GetRightSubstring();
            }

            class CaptureCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Capture>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Group _group;
                /*0x18*/ int _capcount;
                /*0x20*/ System.Text.RegularExpressions.Capture[] _captures;

                /*0x77f1908*/ CaptureCollection();
                /*0x77f0c6c*/ bool get_IsReadOnly();
                /*0x77f0c74*/ int get_Count();
                /*0x77f0c7c*/ System.Text.RegularExpressions.Capture get_Item(int i);
                /*0x77f0d44*/ System.Collections.IEnumerator GetEnumerator();
                /*0x77f0df0*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator();
                /*0x77f0c80*/ System.Text.RegularExpressions.Capture GetCapture(int i);
                /*0x77f0e60*/ void ForceInitialized();
                /*0x77f0fe8*/ bool get_IsSynchronized();
                /*0x77f0ff0*/ object get_SyncRoot();
                /*0x77f0ff8*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x77f10b0*/ void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex);
                /*0x77f121c*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item);
                /*0x77f12cc*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, System.Text.RegularExpressions.Capture item);
                /*0x77f1318*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index);
                /*0x77f1364*/ System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index);
                /*0x77f1368*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, System.Text.RegularExpressions.Capture value);
                /*0x77f13b4*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item);
                /*0x77f1400*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear();
                /*0x77f144c*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item);
                /*0x77f1500*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item);
                /*0x77f154c*/ int System.Collections.IList.Add(object value);
                /*0x77f1598*/ void System.Collections.IList.Clear();
                /*0x77f15e4*/ bool System.Collections.IList.Contains(object value);
                /*0x77f16d8*/ int System.Collections.IList.IndexOf(object value);
                /*0x77f17cc*/ void System.Collections.IList.Insert(int index, object value);
                /*0x77f1818*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x77f1820*/ void System.Collections.IList.Remove(object value);
                /*0x77f186c*/ void System.Collections.IList.RemoveAt(int index);
                /*0x77f18b8*/ object System.Collections.IList.get_Item(int index);
                /*0x77f18bc*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.CaptureCollection _collection;
                    /*0x18*/ int _index;

                    /*0x77f0db4*/ Enumerator(System.Text.RegularExpressions.CaptureCollection collection);
                    /*0x77f1940*/ bool MoveNext();
                    /*0x77f1980*/ System.Text.RegularExpressions.Capture get_Current();
                    /*0x77f19f4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x77f19f8*/ void System.Collections.IEnumerator.Reset();
                    /*0x77f1a04*/ void System.IDisposable.Dispose();
                }
            }

            class CollectionDebuggerProxy<T>
            {
            }

            class Group : System.Text.RegularExpressions.Capture
            {
                static /*0x0*/ System.Text.RegularExpressions.Group s_emptyGroup;
                /*0x20*/ int[] _caps;
                /*0x28*/ int _capcount;
                /*0x30*/ System.Text.RegularExpressions.CaptureCollection _capcoll;
                /*0x38*/ string <Name>k__BackingField;

                static /*0x77f1ad8*/ Group();
                /*0x77f1a08*/ Group(string text, int[] caps, int capcount, string name);
                /*0x77f1bd8*/ Group();
                /*0x77f1ac8*/ bool get_Success();
            }

            class GroupCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Match _match;
                /*0x18*/ System.Collections.Hashtable _captureMap;
                /*0x20*/ System.Text.RegularExpressions.Group[] _groups;

                /*0x77f1c10*/ GroupCollection(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps);
                /*0x77f2cd0*/ GroupCollection();
                /*0x77f1c54*/ bool get_IsReadOnly();
                /*0x77f1c5c*/ int get_Count();
                /*0x77f1c80*/ System.Text.RegularExpressions.Group get_Item(int groupnum);
                /*0x77f1d7c*/ System.Text.RegularExpressions.Group get_Item(string groupname);
                /*0x77f1f54*/ System.Collections.IEnumerator GetEnumerator();
                /*0x77f2000*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator();
                /*0x77f1c84*/ System.Text.RegularExpressions.Group GetGroup(int groupnum);
                /*0x77f2070*/ System.Text.RegularExpressions.Group GetGroupImpl(int groupnum);
                /*0x77f2390*/ bool get_IsSynchronized();
                /*0x77f2398*/ object get_SyncRoot();
                /*0x77f23a0*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x77f245c*/ void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex);
                /*0x77f25dc*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item);
                /*0x77f2694*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item);
                /*0x77f26e0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index);
                /*0x77f272c*/ System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index);
                /*0x77f2730*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, System.Text.RegularExpressions.Group value);
                /*0x77f277c*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item);
                /*0x77f27c8*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear();
                /*0x77f2814*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item);
                /*0x77f28c8*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item);
                /*0x77f2914*/ int System.Collections.IList.Add(object value);
                /*0x77f2960*/ void System.Collections.IList.Clear();
                /*0x77f29ac*/ bool System.Collections.IList.Contains(object value);
                /*0x77f2aa0*/ int System.Collections.IList.IndexOf(object value);
                /*0x77f2b94*/ void System.Collections.IList.Insert(int index, object value);
                /*0x77f2be0*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x77f2be8*/ void System.Collections.IList.Remove(object value);
                /*0x77f2c34*/ void System.Collections.IList.RemoveAt(int index);
                /*0x77f2c80*/ object System.Collections.IList.get_Item(int index);
                /*0x77f2c84*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.GroupCollection _collection;
                    /*0x18*/ int _index;

                    /*0x77f1fc4*/ Enumerator(System.Text.RegularExpressions.GroupCollection collection);
                    /*0x77f2d08*/ bool MoveNext();
                    /*0x77f2d4c*/ System.Text.RegularExpressions.Group get_Current();
                    /*0x77f2dd8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x77f2ddc*/ void System.Collections.IEnumerator.Reset();
                    /*0x77f2de8*/ void System.IDisposable.Dispose();
                }
            }

            class Match : System.Text.RegularExpressions.Group
            {
                static /*0x0*/ System.Text.RegularExpressions.Match <Empty>k__BackingField;
                /*0x40*/ System.Text.RegularExpressions.GroupCollection _groupcoll;
                /*0x48*/ System.Text.RegularExpressions.Regex _regex;
                /*0x50*/ int _textbeg;
                /*0x54*/ int _textpos;
                /*0x58*/ int _textend;
                /*0x5c*/ int _textstart;
                /*0x60*/ int[][] _matches;
                /*0x68*/ int[] _matchcount;
                /*0x70*/ bool _balancing;

                static /*0x77f3b38*/ Match();
                static /*0x77f2f5c*/ System.Text.RegularExpressions.Match get_Empty();
                /*0x77f2dec*/ Match(System.Text.RegularExpressions.Regex regex, int capcount, string text, int begpos, int len, int startpos);
                /*0x77f3bc8*/ Match();
                /*0x77f2fb4*/ void Reset(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart);
                /*0x77f3058*/ System.Text.RegularExpressions.GroupCollection get_Groups();
                /*0x77f30d0*/ System.Text.RegularExpressions.Match NextMatch();
                /*0x77f3384*/ System.ReadOnlySpan<char> GroupToStringImpl(int groupnum);
                /*0x77f34f4*/ System.ReadOnlySpan<char> LastGroupToStringImpl();
                /*0x77f351c*/ void AddMatch(int cap, int start, int len);
                /*0x77f3710*/ void BalanceMatch(int cap);
                /*0x77f37e8*/ void RemoveMatch(int cap);
                /*0x77f3820*/ bool IsMatched(int cap);
                /*0x77f38b0*/ int MatchIndex(int cap);
                /*0x77f393c*/ int MatchLength(int cap);
                /*0x77f39c8*/ void Tidy(int textpos);
            }

            class MatchSparse : System.Text.RegularExpressions.Match
            {
                /*0x78*/ System.Collections.Hashtable _caps;

                /*0x77f3c00*/ MatchSparse(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, int capcount, string text, int begpos, int len, int startpos);
                /*0x77f3cb8*/ System.Text.RegularExpressions.GroupCollection get_Groups();
            }

            class MatchCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Match>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Match>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Match>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Regex _regex;
                /*0x18*/ System.Collections.Generic.List<System.Text.RegularExpressions.Match> _matches;
                /*0x20*/ bool _done;
                /*0x28*/ string _input;
                /*0x30*/ int _beginning;
                /*0x34*/ int _length;
                /*0x38*/ int _startat;
                /*0x3c*/ int _prevlen;

                /*0x77f3d3c*/ MatchCollection(System.Text.RegularExpressions.Regex regex, string input, int beginning, int length, int startat);
                /*0x77f49c4*/ MatchCollection();
                /*0x77f3e90*/ bool get_IsReadOnly();
                /*0x77f3e98*/ int get_Count();
                /*0x77f3f08*/ System.Text.RegularExpressions.Match get_Item(int i);
                /*0x77f40dc*/ System.Collections.IEnumerator GetEnumerator();
                /*0x77f4188*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator();
                /*0x77f3f68*/ System.Text.RegularExpressions.Match GetMatch(int i);
                /*0x77f3ef4*/ void EnsureInitialized();
                /*0x77f41f8*/ bool get_IsSynchronized();
                /*0x77f4200*/ object get_SyncRoot();
                /*0x77f4204*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x77f42d0*/ void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex);
                /*0x77f434c*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item);
                /*0x77f43b8*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, System.Text.RegularExpressions.Match item);
                /*0x77f4404*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index);
                /*0x77f4450*/ System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index);
                /*0x77f4460*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, System.Text.RegularExpressions.Match value);
                /*0x77f44ac*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item);
                /*0x77f44f8*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear();
                /*0x77f4544*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item);
                /*0x77f45b0*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item);
                /*0x77f45fc*/ int System.Collections.IList.Add(object value);
                /*0x77f4648*/ void System.Collections.IList.Clear();
                /*0x77f4694*/ bool System.Collections.IList.Contains(object value);
                /*0x77f4788*/ int System.Collections.IList.IndexOf(object value);
                /*0x77f487c*/ void System.Collections.IList.Insert(int index, object value);
                /*0x77f48c8*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x77f48d0*/ void System.Collections.IList.Remove(object value);
                /*0x77f491c*/ void System.Collections.IList.RemoveAt(int index);
                /*0x77f4968*/ object System.Collections.IList.get_Item(int index);
                /*0x77f4978*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.MatchCollection _collection;
                    /*0x18*/ int _index;

                    /*0x77f414c*/ Enumerator(System.Text.RegularExpressions.MatchCollection collection);
                    /*0x77f49fc*/ bool MoveNext();
                    /*0x77f4a4c*/ System.Text.RegularExpressions.Match get_Current();
                    /*0x77f4ab4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x77f4ab8*/ void System.Collections.IEnumerator.Reset();
                    /*0x77f4ac4*/ void System.IDisposable.Dispose();
                }
            }

            class ExclusiveReference
            {
                /*0x10*/ System.Text.RegularExpressions.RegexRunner _ref;
                /*0x18*/ System.Text.RegularExpressions.RegexRunner _obj;
                /*0x20*/ int _locked;

                /*0x77f4bf4*/ ExclusiveReference();
                /*0x77f4ac8*/ System.Text.RegularExpressions.RegexRunner Get();
                /*0x77f4b28*/ void Release(System.Text.RegularExpressions.RegexRunner obj);
            }

            class Regex : System.Runtime.Serialization.ISerializable
            {
                static int CacheDictionarySwitchLimit = 10;
                static string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
                static int MaxOptionShift = 10;
                static /*0x0*/ int s_cacheSize;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.Text.RegularExpressions.Regex.CachedCodeEntryKey, System.Text.RegularExpressions.Regex.CachedCodeEntry> s_cache;
                static /*0x10*/ int s_cacheCount;
                static /*0x18*/ System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheFirst;
                static /*0x20*/ System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheLast;
                static /*0x28*/ System.TimeSpan s_maximumMatchTimeout;
                static /*0x30*/ System.TimeSpan s_defaultMatchTimeout;
                static /*0x38*/ System.TimeSpan InfiniteMatchTimeout;
                /*0x10*/ System.TimeSpan internalMatchTimeout;
                /*0x18*/ string pattern;
                /*0x20*/ System.Text.RegularExpressions.RegexOptions roptions;
                /*0x28*/ System.Text.RegularExpressions.RegexRunnerFactory factory;
                /*0x30*/ System.Collections.Hashtable caps;
                /*0x38*/ System.Collections.Hashtable capnames;
                /*0x40*/ string[] capslist;
                /*0x48*/ int capsize;
                /*0x50*/ System.Text.RegularExpressions.ExclusiveReference _runnerref;
                /*0x58*/ System.WeakReference<System.Text.RegularExpressions.RegexReplacement> _replref;
                /*0x60*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x68*/ bool _refsInitialized;

                static /*0x77f7410*/ Regex();
                static /*0x77f5600*/ bool TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x77f571c*/ bool TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x77f5218*/ System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key);
                static /*0x77f5814*/ bool IsMatch(string input, string pattern);
                static /*0x77f5914*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0x77f5888*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x77f5ef8*/ System.Text.RegularExpressions.Match Match(string input, string pattern);
                static /*0x77f5f6c*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x77f60d4*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern);
                static /*0x77f6148*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x77f6308*/ string Replace(string input, string pattern, string replacement);
                static /*0x77f6384*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x77f6560*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator);
                static /*0x77f65dc*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x77f67b0*/ string Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x77f6be0*/ string[] Split(string input, string pattern);
                static /*0x77f6c54*/ string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x77f6e10*/ string[] Split(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x77f7780*/ void ValidateMatchTimeout(System.TimeSpan matchTimeout);
                static /*0x77f7550*/ System.TimeSpan InitDefaultMatchTimeout();
                static /*0x77f7bb8*/ string Escape(string str);
                /*0x77f78d8*/ Regex();
                /*0x77f7944*/ Regex(string pattern);
                /*0x77f79bc*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options);
                /*0x77f598c*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, bool addToCache);
                /*0x77f4bfc*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x77f4d24*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x77f54fc*/ void FillCacheDictionary();
                /*0x77f5e04*/ bool IsMatch(string input);
                /*0x77f5e7c*/ bool IsMatch(string input, int startat);
                /*0x77f5ff8*/ System.Text.RegularExpressions.Match Match(string input);
                /*0x77f6064*/ System.Text.RegularExpressions.Match Match(string input, int startat);
                /*0x77f61d4*/ System.Text.RegularExpressions.MatchCollection Matches(string input);
                /*0x77f6240*/ System.Text.RegularExpressions.MatchCollection Matches(string input, int startat);
                /*0x77f6418*/ string Replace(string input, string replacement);
                /*0x77f6488*/ string Replace(string input, string replacement, int count, int startat);
                /*0x77f6670*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator);
                /*0x77f66e0*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat);
                /*0x77f6ce0*/ string[] Split(string input);
                /*0x77f6d50*/ string[] Split(string input, int count, int startat);
                /*0x77f7a38*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0x77f7c5c*/ System.Text.RegularExpressions.RegexOptions get_Options();
                /*0x77f6bd4*/ bool get_RightToLeft();
                /*0x77f7c64*/ string ToString();
                /*0x77f2260*/ string GroupNameFromNumber(int i);
                /*0x77f1e0c*/ int GroupNumberFromName(string name);
                /*0x77f7aa8*/ void InitializeReferences();
                /*0x77f3100*/ System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat);
                /*0x77f5e70*/ bool UseOptionR();
                /*0x77f7c6c*/ bool UseOptionInvariant();

                struct CachedCodeEntryKey : System.IEquatable<System.Text.RegularExpressions.Regex.CachedCodeEntryKey>
                {
                    /*0x10*/ System.Text.RegularExpressions.RegexOptions _options;
                    /*0x18*/ string _cultureKey;
                    /*0x20*/ string _pattern;

                    static /*0x77f4cf4*/ bool op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right);
                    /*0x77f7a70*/ CachedCodeEntryKey(System.Text.RegularExpressions.RegexOptions options, string cultureKey, string pattern);
                    /*0x77f7c78*/ bool Equals(object obj);
                    /*0x77f7d08*/ bool Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other);
                    /*0x77f7d70*/ int GetHashCode();
                }

                class CachedCodeEntry
                {
                    /*0x10*/ System.Text.RegularExpressions.Regex.CachedCodeEntry Next;
                    /*0x18*/ System.Text.RegularExpressions.Regex.CachedCodeEntry Previous;
                    /*0x20*/ System.Text.RegularExpressions.Regex.CachedCodeEntryKey Key;
                    /*0x38*/ System.Text.RegularExpressions.RegexCode Code;
                    /*0x40*/ System.Collections.Hashtable Caps;
                    /*0x48*/ System.Collections.Hashtable Capnames;
                    /*0x50*/ string[] Capslist;
                    /*0x58*/ int Capsize;
                    /*0x60*/ System.Text.RegularExpressions.ExclusiveReference Runnerref;
                    /*0x68*/ System.WeakReference<System.Text.RegularExpressions.RegexReplacement> ReplRef;

                    /*0x77f5428*/ CachedCodeEntry(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref);
                }
            }

            class MatchEvaluator : System.MulticastDelegate
            {
                /*0x77f7dc8*/ MatchEvaluator(object object, nint method);
                /*0x77f7ed0*/ string Invoke(System.Text.RegularExpressions.Match match);
            }

            class RegexBoyerMoore
            {
                /*0x10*/ int[] Positive;
                /*0x18*/ int[] NegativeASCII;
                /*0x20*/ int[][] NegativeUnicode;
                /*0x28*/ string Pattern;
                /*0x30*/ int LowASCII;
                /*0x34*/ int HighASCII;
                /*0x38*/ bool RightToLeft;
                /*0x39*/ bool CaseInsensitive;
                /*0x40*/ System.Globalization.CultureInfo _culture;

                /*0x77f7ee4*/ RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, System.Globalization.CultureInfo culture);
                /*0x77f8404*/ bool MatchPattern(string text, int index);
                /*0x77f8528*/ bool IsMatch(string text, int index, int beglimit, int endlimit);
                /*0x77f8594*/ int Scan(string text, int index, int beglimit, int endlimit);
            }

            class RegexCharClass
            {
                static /*0x0*/ string s_internalRegexIgnoreCase;
                static /*0x8*/ string s_space;
                static /*0x10*/ string s_notSpace;
                static /*0x18*/ string s_word;
                static /*0x20*/ string s_notWord;
                static /*0x28*/ string SpaceClass;
                static /*0x30*/ string NotSpaceClass;
                static /*0x38*/ string WordClass;
                static /*0x40*/ string NotWordClass;
                static /*0x48*/ string DigitClass;
                static /*0x50*/ string NotDigitClass;
                static /*0x58*/ System.Collections.Generic.Dictionary<string, string> s_definedCategories;
                static /*0x60*/ string[][] s_propTable;
                static /*0x68*/ System.Text.RegularExpressions.RegexCharClass.LowerCaseMapping[] s_lcTable;
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> _rangelist;
                /*0x18*/ System.Text.StringBuilder _categories;
                /*0x20*/ bool _canonical;
                /*0x21*/ bool _negate;
                /*0x28*/ System.Text.RegularExpressions.RegexCharClass _subtractor;

                static /*0x77faaf4*/ RegexCharClass();
                static /*0x77f9a70*/ char SingletonChar(string set);
                static /*0x77f9a88*/ bool IsMergeable(string charClass);
                static /*0x77f9ba4*/ bool IsEmpty(string charClass);
                static /*0x77f9c64*/ bool IsSingleton(string set);
                static /*0x77f9d70*/ bool IsSingletonInverse(string set);
                static /*0x77f9b4c*/ bool IsSubtraction(string charClass);
                static /*0x77f9b24*/ bool IsNegated(string set);
                static /*0x77f9e80*/ bool IsECMAWordChar(char ch);
                static /*0x77f9f54*/ bool IsWordChar(char ch);
                static /*0x77f9eec*/ bool CharInClass(char ch, string set);
                static /*0x77f9fd0*/ bool CharInClassRecursive(char ch, string set, int start);
                static /*0x77fa0f8*/ bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x77fa208*/ bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x77fa38c*/ bool CharInCategoryGroup(char ch, System.Globalization.UnicodeCategory chcategory, string category, ref int i);
                static /*0x77f9158*/ string NegateCategory(string category);
                static /*0x77fa45c*/ System.Text.RegularExpressions.RegexCharClass Parse(string charClass);
                static /*0x77fa4b4*/ System.Text.RegularExpressions.RegexCharClass ParseRecursive(string charClass, int start);
                static /*0x77f91e0*/ string SetFromProperty(string capname, bool invert, string pattern);
                /*0x77f8878*/ RegexCharClass();
                /*0x77f8944*/ RegexCharClass(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction);
                /*0x77f89b4*/ bool get_CanMerge();
                /*0x77f89d4*/ void set_Negate(bool value);
                /*0x77f89e0*/ void AddChar(char c);
                /*0x77f8b04*/ void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc);
                /*0x77f8d1c*/ void AddSet(string set);
                /*0x77f8f40*/ void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub);
                /*0x77f89e8*/ void AddRange(char first, char last);
                /*0x77f8f48*/ void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern);
                /*0x77f943c*/ void AddCategory(string category);
                /*0x77f9458*/ void AddLowercase(System.Globalization.CultureInfo culture);
                /*0x77f9594*/ void AddLowercaseRange(char chMin, char chMax, System.Globalization.CultureInfo culture);
                /*0x77f97c4*/ void AddWord(bool ecma, bool negate);
                /*0x77f98c0*/ void AddSpace(bool ecma, bool negate);
                /*0x77f99bc*/ void AddDigit(bool ecma, bool negate, string pattern);
                /*0x77f8c74*/ int RangeCount();
                /*0x77fa720*/ string ToStringClass();
                /*0x77f8cbc*/ System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(int i);
                /*0x77fa8bc*/ void Canonicalize();

                struct LowerCaseMapping
                {
                    /*0x10*/ char ChMin;
                    /*0x12*/ char ChMax;
                    /*0x14*/ int LcOp;
                    /*0x18*/ int Data;

                    /*0x7800ef4*/ LowerCaseMapping(char chMin, char chMax, int lcOp, int data);
                }

                class SingleRangeComparer : System.Collections.Generic.IComparer<System.Text.RegularExpressions.RegexCharClass.SingleRange>
                {
                    static /*0x0*/ System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer Instance;

                    static /*0x7800f50*/ SingleRangeComparer();
                    /*0x7800f04*/ SingleRangeComparer();
                    /*0x7800f0c*/ int Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y);
                }

                struct SingleRange
                {
                    /*0x10*/ char First;
                    /*0x12*/ char Last;

                    /*0x7800fb8*/ SingleRange(char first, char last);
                }
            }

            class RegexCode
            {
                static int Onerep = 0;
                static int Notonerep = 1;
                static int Setrep = 2;
                static int Oneloop = 3;
                static int Notoneloop = 4;
                static int Setloop = 5;
                static int Onelazy = 6;
                static int Notonelazy = 7;
                static int Setlazy = 8;
                static int One = 9;
                static int Notone = 10;
                static int Set = 11;
                static int Multi = 12;
                static int Ref = 13;
                static int Bol = 14;
                static int Eol = 15;
                static int Boundary = 16;
                static int Nonboundary = 17;
                static int Beginning = 18;
                static int Start = 19;
                static int EndZ = 20;
                static int End = 21;
                static int Nothing = 22;
                static int Lazybranch = 23;
                static int Branchmark = 24;
                static int Lazybranchmark = 25;
                static int Nullcount = 26;
                static int Setcount = 27;
                static int Branchcount = 28;
                static int Lazybranchcount = 29;
                static int Nullmark = 30;
                static int Setmark = 31;
                static int Capturemark = 32;
                static int Getmark = 33;
                static int Setjump = 34;
                static int Backjump = 35;
                static int Forejump = 36;
                static int Testref = 37;
                static int Goto = 38;
                static int Prune = 39;
                static int Stop = 40;
                static int ECMABoundary = 41;
                static int NonECMABoundary = 42;
                static int Mask = 63;
                static int Rtl = 64;
                static int Back = 128;
                static int Back2 = 256;
                static int Ci = 512;
                /*0x10*/ int[] Codes;
                /*0x18*/ string[] Strings;
                /*0x20*/ int TrackCount;
                /*0x28*/ System.Collections.Hashtable Caps;
                /*0x30*/ int CapSize;
                /*0x38*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FCPrefix;
                /*0x50*/ System.Text.RegularExpressions.RegexBoyerMoore BMPrefix;
                /*0x58*/ int Anchors;
                /*0x5c*/ bool RightToLeft;

                static /*0x78010d0*/ bool OpcodeBacktracks(int Op);
                /*0x7800fc4*/ RegexCode(int[] codes, System.Collections.Generic.List<string> stringlist, int trackcount, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft);
            }

            struct RegexFCD
            {
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack;
                /*0x18*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x38*/ bool _skipAllChildren;
                /*0x39*/ bool _skipchild;
                /*0x3a*/ bool _failed;

                static /*0x78011d4*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t);
                static /*0x7801580*/ System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree);
                static /*0x7801858*/ int Anchors(System.Text.RegularExpressions.RegexTree tree);
                static /*0x7801988*/ int AnchorFromType(int type);
                /*0x7801100*/ RegexFCD(System.Span<int> intStack);
                /*0x78019f8*/ void PushInt(int i);
                /*0x7801aac*/ bool IntIsEmpty();
                /*0x7801af0*/ int PopInt();
                /*0x7801b4c*/ void PushFC(System.Text.RegularExpressions.RegexFC fc);
                /*0x7801bf8*/ bool FCIsEmpty();
                /*0x7801c48*/ System.Text.RegularExpressions.RegexFC PopFC();
                /*0x7801cc4*/ System.Text.RegularExpressions.RegexFC TopFC();
                /*0x78014d8*/ void Dispose();
                /*0x7801340*/ System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x7802124*/ void SkipChild();
                /*0x7801d28*/ void CalculateFC(int NodeType, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }

            class RegexFC
            {
                /*0x10*/ System.Text.RegularExpressions.RegexCharClass _cc;
                /*0x18*/ bool _nullable;
                /*0x19*/ bool <CaseInsensitive>k__BackingField;

                /*0x7802130*/ RegexFC(bool nullable);
                /*0x7802260*/ RegexFC(char ch, bool not, bool nullable, bool caseInsensitive);
                /*0x7802364*/ RegexFC(string charClass, bool nullable, bool caseInsensitive);
                /*0x78021b4*/ bool AddFC(System.Text.RegularExpressions.RegexFC fc, bool concatenate);
                /*0x7802408*/ bool get_CaseInsensitive();
                /*0x7802410*/ void set_CaseInsensitive(bool value);
                /*0x7801520*/ string GetFirstChars(System.Globalization.CultureInfo culture);
            }

            class RegexInterpreter : System.Text.RegularExpressions.RegexRunner
            {
                /*0x80*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x88*/ System.Globalization.CultureInfo _culture;
                /*0x90*/ int _operator;
                /*0x94*/ int _codepos;
                /*0x98*/ bool _rightToLeft;
                /*0x99*/ bool _caseInsensitive;

                /*0x780241c*/ RegexInterpreter(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture);
                /*0x7802468*/ void InitTrackCount();
                /*0x7802488*/ void Advance(int i);
                /*0x780250c*/ void Goto(int newpos);
                /*0x78025cc*/ void Textto(int newpos);
                /*0x78025d4*/ void Trackto(int newpos);
                /*0x78025f8*/ int Textstart();
                /*0x7802600*/ int Textpos();
                /*0x7802608*/ int Trackpos();
                /*0x780262c*/ void TrackPush();
                /*0x780266c*/ void TrackPush(int I1);
                /*0x78026c8*/ void TrackPush(int I1, int I2);
                /*0x7802740*/ void TrackPush(int I1, int I2, int I3);
                /*0x78027d4*/ void TrackPush2(int I1);
                /*0x7802834*/ void TrackPush2(int I1, int I2);
                /*0x78028b0*/ void Backtrack();
                /*0x78024ec*/ void SetOperator(int op);
                /*0x78029a4*/ void TrackPop();
                /*0x78029b4*/ void TrackPop(int framesize);
                /*0x78029c4*/ int TrackPeek();
                /*0x78029fc*/ int TrackPeek(int i);
                /*0x7802a38*/ void StackPush(int I1);
                /*0x7802a74*/ void StackPush(int I1, int I2);
                /*0x7802acc*/ void StackPop();
                /*0x7802adc*/ void StackPop(int framesize);
                /*0x7802aec*/ int StackPeek();
                /*0x7802b24*/ int StackPeek(int i);
                /*0x7802b60*/ int Operator();
                /*0x7802b68*/ int Operand(int i);
                /*0x7802bac*/ int Leftchars();
                /*0x7802bbc*/ int Rightchars();
                /*0x7802bcc*/ int Bump();
                /*0x7802be0*/ int Forwardchars();
                /*0x7802c0c*/ char Forwardcharnext();
                /*0x7802c9c*/ bool Stringmatch(string str);
                /*0x7802e08*/ bool Refmatch(int index, int len);
                /*0x7802fa4*/ void Backwardnext();
                /*0x7802fd4*/ char CharAt(int j);
                /*0x7802ff0*/ bool FindFirstChar();
                /*0x780338c*/ void Go();
            }

            class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                /*0x90*/ string <Input>k__BackingField;
                /*0x98*/ string <Pattern>k__BackingField;
                /*0xa0*/ System.TimeSpan <MatchTimeout>k__BackingField;

                /*0x780495c*/ RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout);
                /*0x7804a68*/ RegexMatchTimeoutException();
                /*0x7804b08*/ RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x7804c74*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x7804d70*/ string get_Input();
                /*0x7804d78*/ string get_Pattern();
                /*0x7804d80*/ System.TimeSpan get_MatchTimeout();
            }

            class RegexNode
            {
                /*0x10*/ int NType;
                /*0x18*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode> Children;
                /*0x20*/ string Str;
                /*0x28*/ char Ch;
                /*0x2c*/ int M;
                /*0x30*/ int N;
                /*0x34*/ System.Text.RegularExpressions.RegexOptions Options;
                /*0x38*/ System.Text.RegularExpressions.RegexNode Next;

                /*0x7804d88*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options);
                /*0x7804db8*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, char ch);
                /*0x7804df8*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, string str);
                /*0x7804e40*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m);
                /*0x7804e80*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m, int n);
                /*0x7804ec4*/ bool UseOptionR();
                /*0x7804ed0*/ System.Text.RegularExpressions.RegexNode ReverseLeft();
                /*0x7804f4c*/ void MakeRep(int type, int min, int max);
                /*0x7804f64*/ System.Text.RegularExpressions.RegexNode Reduce();
                /*0x7805a5c*/ System.Text.RegularExpressions.RegexNode StripEnation(int emptyType);
                /*0x78058ec*/ System.Text.RegularExpressions.RegexNode ReduceGroup();
                /*0x7805764*/ System.Text.RegularExpressions.RegexNode ReduceRep();
                /*0x7805918*/ System.Text.RegularExpressions.RegexNode ReduceSet();
                /*0x7804fcc*/ System.Text.RegularExpressions.RegexNode ReduceAlternation();
                /*0x78053b4*/ System.Text.RegularExpressions.RegexNode ReduceConcatenation();
                /*0x7805b10*/ System.Text.RegularExpressions.RegexNode MakeQuantifier(bool lazy, int min, int max);
                /*0x7805c28*/ void AddChild(System.Text.RegularExpressions.RegexNode newChild);
                /*0x7801800*/ System.Text.RegularExpressions.RegexNode Child(int i);
                /*0x78017b4*/ int ChildCount();
                /*0x7805d58*/ int Type();
            }

            enum RegexOptions
            {
                None = 0,
                IgnoreCase = 1,
                Multiline = 2,
                ExplicitCapture = 4,
                Compiled = 8,
                Singleline = 16,
                IgnorePatternWhitespace = 32,
                RightToLeft = 64,
                ECMAScript = 256,
                CultureInvariant = 512,
            }

            class RegexParser
            {
                static /*0x0*/ byte[] s_category;
                /*0x10*/ System.Text.RegularExpressions.RegexNode _stack;
                /*0x18*/ System.Text.RegularExpressions.RegexNode _group;
                /*0x20*/ System.Text.RegularExpressions.RegexNode _alternation;
                /*0x28*/ System.Text.RegularExpressions.RegexNode _concatenation;
                /*0x30*/ System.Text.RegularExpressions.RegexNode _unit;
                /*0x38*/ string _pattern;
                /*0x40*/ int _currentPos;
                /*0x48*/ System.Globalization.CultureInfo _culture;
                /*0x50*/ int _autocap;
                /*0x54*/ int _capcount;
                /*0x58*/ int _captop;
                /*0x5c*/ int _capsize;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ System.Collections.Hashtable _capnames;
                /*0x70*/ int[] _capnumlist;
                /*0x78*/ System.Collections.Generic.List<string> _capnamelist;
                /*0x80*/ System.Text.RegularExpressions.RegexOptions _options;
                /*0x88*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexOptions> _optionsStack;
                /*0x90*/ bool _ignoreNextParen;

                static /*0x780bba4*/ RegexParser();
                static /*0x7805d60*/ System.Text.RegularExpressions.RegexTree Parse(string re, System.Text.RegularExpressions.RegexOptions op);
                static /*0x7806bf0*/ System.Text.RegularExpressions.RegexReplacement ParseReplacement(string rep, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op);
                static /*0x78073cc*/ string Escape(string input);
                static /*0x780b0a4*/ int HexDigit(char ch);
                static /*0x780b19c*/ System.Text.RegularExpressions.RegexOptions OptionFromCode(char ch);
                static /*0x7807c8c*/ bool IsSpecial(char ch);
                static /*0x7807a64*/ bool IsStopperX(char ch);
                static /*0x7807d24*/ bool IsQuantifier(char ch);
                static /*0x780a80c*/ bool IsSpace(char ch);
                static /*0x78075c4*/ bool IsMetachar(char ch);
                /*0x7805ef0*/ RegexParser(System.Globalization.CultureInfo culture);
                /*0x7805fcc*/ void SetPattern(string Re);
                /*0x7806344*/ void Reset(System.Text.RegularExpressions.RegexOptions topopts);
                /*0x78063d8*/ System.Text.RegularExpressions.RegexNode ScanRegex();
                /*0x7806d78*/ System.Text.RegularExpressions.RegexNode ScanReplacement();
                /*0x7808088*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly);
                /*0x78087e0*/ System.Text.RegularExpressions.RegexNode ScanGroupOpen();
                /*0x780771c*/ void ScanBlank();
                /*0x7809618*/ System.Text.RegularExpressions.RegexNode ScanBackslash(bool scanOnly);
                /*0x780a934*/ System.Text.RegularExpressions.RegexNode ScanBasicBackslash(bool scanOnly);
                /*0x7809e18*/ System.Text.RegularExpressions.RegexNode ScanDollar();
                /*0x780a520*/ string ScanCapname();
                /*0x780aed4*/ char ScanOctal();
                /*0x7809d00*/ int ScanDecimal();
                /*0x780af70*/ char ScanHex(int c);
                /*0x780b0dc*/ char ScanControl();
                /*0x780b178*/ bool IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option);
                /*0x780a700*/ void ScanOptions();
                /*0x780a38c*/ char ScanCharEscape();
                /*0x780a21c*/ string ParseProperty();
                /*0x780a8a4*/ int TypeFromCode(char ch);
                /*0x7806004*/ void CountCaptures();
                /*0x780b1fc*/ void NoteCaptureSlot(int i, int pos);
                /*0x780b334*/ void NoteCaptureName(string name, int pos);
                /*0x7806d40*/ void NoteCaptures(System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames);
                /*0x780b4e0*/ void AssignNameSlots();
                /*0x780a6a8*/ int CaptureSlotFromName(string capname);
                /*0x780a620*/ bool IsCaptureSlot(int i);
                /*0x780a68c*/ bool IsCaptureName(string capname);
                /*0x780a614*/ bool UseOptionN();
                /*0x780807c*/ bool UseOptionI();
                /*0x7809b48*/ bool UseOptionM();
                /*0x7809bcc*/ bool UseOptionS();
                /*0x7807a00*/ bool UseOptionX();
                /*0x780a210*/ bool UseOptionE();
                /*0x7807afc*/ bool IsTrueQuantifier();
                /*0x7807dbc*/ void AddConcatenate(int pos, int cch, bool isReplacement);
                /*0x7809128*/ void PushGroup();
                /*0x7809448*/ void PopGroup();
                /*0x780925c*/ bool EmptyStack();
                /*0x780765c*/ void StartGroup(System.Text.RegularExpressions.RegexNode openGroup);
                /*0x7809190*/ void AddAlternate();
                /*0x7809ca0*/ void AddConcatenate();
                /*0x7809dcc*/ void AddConcatenate(bool lazy, int min, int max);
                /*0x780bb84*/ System.Text.RegularExpressions.RegexNode Unit();
                /*0x7807fc4*/ void AddUnitOne(char ch);
                /*0x7809bd8*/ void AddUnitNotone(char ch);
                /*0x78086b4*/ void AddUnitSet(string cc);
                /*0x780bb8c*/ void AddUnitNode(System.Text.RegularExpressions.RegexNode node);
                /*0x7809b54*/ void AddUnitType(int type);
                /*0x7809304*/ void AddGroup();
                /*0x7808740*/ void PushOptions();
                /*0x7809580*/ void PopOptions();
                /*0x780b2e4*/ bool EmptyOptionsStack();
                /*0x78090c4*/ void PopKeepOptions();
                /*0x780926c*/ System.ArgumentException MakeException(string message);
                /*0x780bb94*/ int Textpos();
                /*0x780bb9c*/ void Textto(int pos);
                /*0x7809cd4*/ char RightCharMoveRight();
                /*0x7807a0c*/ void MoveRight();
                /*0x780a604*/ void MoveRight(int i);
                /*0x7809c90*/ void MoveLeft();
                /*0x7807fa8*/ char CharAt(int i);
                /*0x7807a40*/ char RightChar();
                /*0x780a5dc*/ char RightChar(int i);
                /*0x7807a1c*/ int CharsRight();
            }

            struct RegexPrefix
            {
                static /*0x0*/ System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;
                /*0x10*/ bool <CaseInsensitive>k__BackingField;
                /*0x18*/ string <Prefix>k__BackingField;

                static /*0x780bcac*/ RegexPrefix();
                static /*0x780bc4c*/ System.Text.RegularExpressions.RegexPrefix get_Empty();
                /*0x7801558*/ RegexPrefix(string prefix, bool ci);
                /*0x780bc44*/ bool get_CaseInsensitive();
                /*0x780bca4*/ string get_Prefix();
            }

            class RegexReplacement
            {
                static int Specials = 4;
                static int LeftPortion = -1;
                static int RightPortion = -2;
                static int LastGroup = -3;
                static int WholeString = -4;
                /*0x10*/ System.Collections.Generic.List<string> _strings;
                /*0x18*/ System.Collections.Generic.List<int> _rules;
                /*0x20*/ string <Pattern>k__BackingField;

                static /*0x780bd3c*/ System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions roptions);
                /*0x7806ec0*/ RegexReplacement(string rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps);
                /*0x780be50*/ string get_Pattern();
                /*0x780be58*/ void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match);
                /*0x780bffc*/ void ReplacementImplRTL(System.Collections.Generic.List<string> al, System.Text.RegularExpressions.Match match);
                /*0x780c22c*/ string Replace(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
            }

            class RegexRunner
            {
                static int TimeoutCheckFrequency = 1000;
                /*0x10*/ int runtextbeg;
                /*0x14*/ int runtextend;
                /*0x18*/ int runtextstart;
                /*0x20*/ string runtext;
                /*0x28*/ int runtextpos;
                /*0x30*/ int[] runtrack;
                /*0x38*/ int runtrackpos;
                /*0x40*/ int[] runstack;
                /*0x48*/ int runstackpos;
                /*0x50*/ int[] runcrawl;
                /*0x58*/ int runcrawlpos;
                /*0x5c*/ int runtrackcount;
                /*0x60*/ System.Text.RegularExpressions.Match runmatch;
                /*0x68*/ System.Text.RegularExpressions.Regex runregex;
                /*0x70*/ int _timeout;
                /*0x74*/ bool _ignoreTimeout;
                /*0x78*/ int _timeoutOccursAt;
                /*0x7c*/ int _timeoutChecksToSkip;

                /*0x7802460*/ RegexRunner();
                /*0x780c5c8*/ System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout);
                /*0x780c918*/ void StartTimeoutWatch();
                /*0x7804524*/ void CheckTimeout();
                /*0x780cbc8*/ void DoCheckTimeout();
                /*0x380cb08*/ void Go();
                /*0x380b128*/ bool FindFirstChar();
                /*0x380cb08*/ void InitTrackCount();
                /*0x780c94c*/ void InitMatch();
                /*0x780cb70*/ System.Text.RegularExpressions.Match TidyMatch(bool quick);
                /*0x7802584*/ void EnsureStorage();
                /*0x780471c*/ bool IsBoundary(int index, int startpos, int endpos);
                /*0x780481c*/ bool IsECMABoundary(int index, int startpos, int endpos);
                /*0x780cd40*/ void DoubleTrack();
                /*0x780cc94*/ void DoubleStack();
                /*0x780cdec*/ void DoubleCrawl();
                /*0x780ce98*/ void Crawl(int i);
                /*0x780cef4*/ int Popcrawl();
                /*0x78046f8*/ int Crawlpos();
                /*0x7804668*/ void Capture(int capnum, int start, int end);
                /*0x7804554*/ void TransferCapture(int capnum, int uncapnum, int start, int end);
                /*0x78046c8*/ void Uncapture();
                /*0x7804534*/ bool IsMatched(int cap);
                /*0x780491c*/ int MatchIndex(int cap);
                /*0x780493c*/ int MatchLength(int cap);
            }

            class RegexRunnerFactory
            {
                /*0x780cf30*/ RegexRunnerFactory();
                /*0x380b9e8*/ System.Text.RegularExpressions.RegexRunner CreateInstance();
            }

            class RegexTree
            {
                /*0x10*/ System.Text.RegularExpressions.RegexNode Root;
                /*0x18*/ System.Collections.Hashtable Caps;
                /*0x20*/ int[] CapNumList;
                /*0x28*/ int CapTop;
                /*0x30*/ System.Collections.Hashtable CapNames;
                /*0x38*/ string[] CapsList;
                /*0x40*/ System.Text.RegularExpressions.RegexOptions Options;

                /*0x7806b44*/ RegexTree(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, int[] capNumList, int capTop, System.Collections.Hashtable capNames, string[] capsList, System.Text.RegularExpressions.RegexOptions options);
            }

            struct RegexWriter
            {
                /*0x10*/ System.Collections.Generic.ValueListBuilder<int> _emitted;
                /*0x30*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x50*/ System.Collections.Generic.Dictionary<string, int> _stringHash;
                /*0x58*/ System.Collections.Generic.List<string> _stringTable;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ int _trackCount;

                static /*0x780d07c*/ System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree);
                /*0x780cf38*/ RegexWriter(System.Span<int> emittedSpan, System.Span<int> intStackSpan);
                /*0x780d5dc*/ void Dispose();
                /*0x780d160*/ System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x780e198*/ void PatchJump(int offset, int jumpDest);
                /*0x780e1fc*/ void Emit(int op);
                /*0x780d630*/ void Emit(int op, int opd1);
                /*0x780e2c4*/ void Emit(int op, int opd1, int opd2);
                /*0x780e454*/ int StringCode(string str);
                /*0x780e59c*/ int MapCapnum(int capnum);
                /*0x780d760*/ void EmitFragment(int nodetype, System.Text.RegularExpressions.RegexNode node, int curIndex);
            }
        }
    }

    namespace CodeDom
    {
        namespace Compiler
        {
            class GeneratedCodeAttribute : System.Attribute
            {
                /*0x10*/ string tool;
                /*0x18*/ string version;

                /*0x780e708*/ GeneratedCodeAttribute(string tool, string version);
            }
        }
    }

    namespace Diagnostics
    {
        class BooleanSwitch : System.Diagnostics.Switch
        {
            /*0x780e74c*/ BooleanSwitch(string displayName, string description);
            /*0x780e818*/ void OnValueChanged();
        }

        enum SourceLevels
        {
            Off = 0,
            Critical = 1,
            Error = 3,
            Warning = 7,
            Information = 15,
            Verbose = 31,
            ActivityTracing = 65280,
            All = -1,
        }

        class SourceSwitch : System.Diagnostics.Switch
        {
            /*0x780ea3c*/ SourceSwitch(string displayName, string defaultSwitchValue);
            /*0x780ed28*/ System.Diagnostics.SourceLevels get_Level();
            /*0x780ed70*/ void set_Level(System.Diagnostics.SourceLevels value);
            /*0x780ed74*/ void OnValueChanged();
        }

        class Switch
        {
            static /*0x0*/ System.Collections.Generic.List<System.WeakReference> switches;
            static /*0x8*/ int s_LastCollectionCount;
            /*0x10*/ object switchSettings;
            /*0x18*/ string description;
            /*0x20*/ string displayName;
            /*0x28*/ int switchSetting;
            /*0x2c*/ bool initialized;
            /*0x2d*/ bool initializing;
            /*0x30*/ string switchValueString;
            /*0x38*/ string defaultValue;
            /*0x40*/ object m_intializedLock;

            static /*0x780f4ec*/ Switch();
            static /*0x780eebc*/ void _pruneCachedSwitches();
            /*0x780e7b8*/ Switch(string displayName, string description);
            /*0x780eac0*/ Switch(string displayName, string description, string defaultSwitchValue);
            /*0x780ee4c*/ object get_IntializedLock();
            /*0x780ed2c*/ int get_SwitchSetting();
            /*0x780e8a4*/ void set_SwitchSetting(int value);
            /*0x780e884*/ string get_Value();
            /*0x780f4dc*/ void Initialize();
            /*0x780f3a0*/ bool InitializeWithStatus();
            /*0x780f4e0*/ bool InitializeConfigSettings();
            /*0x780f4e8*/ void OnSwitchSettingChanged();
            /*0x780e9bc*/ void OnValueChanged();
        }

        class SwitchLevelAttribute : System.Attribute
        {
            /*0x10*/ System.Type type;

            /*0x780f584*/ SwitchLevelAttribute(System.Type switchLevelType);
            /*0x780f5b0*/ void set_SwitchLevelType(System.Type value);
        }

        enum TraceEventType
        {
            Critical = 1,
            Error = 2,
            Warning = 4,
            Information = 8,
            Verbose = 16,
            Start = 256,
            Stop = 512,
            Suspend = 1024,
            Resume = 2048,
            Transfer = 4096,
        }

        class TraceInternal
        {
            static /*0x0*/ string appName;
            static /*0x8*/ bool useGlobalLock;
            static /*0xc*/ int indentSize;
            static /*0x10*/ object critSec;
            [ThreadStatic] static int indentLevel;

            static /*0x780f76c*/ TraceInternal();
            static /*0x780f650*/ bool get_UseGlobalLock();
            static /*0x780f6b4*/ int get_IndentLevel();
            static /*0x780f70c*/ int get_IndentSize();
            static /*0x780f6b0*/ void InitializeSettings();
        }

        enum TraceLevel
        {
            Off = 0,
            Error = 1,
            Warning = 2,
            Info = 3,
            Verbose = 4,
        }

        class TraceListener : System.MarshalByRefObject, System.IDisposable
        {
            /*0x18*/ int indentLevel;
            /*0x1c*/ int indentSize;
            /*0x20*/ bool needIndent;
            /*0x28*/ string listenerName;

            /*0x780f800*/ TraceListener(string name);
            /*0x780f840*/ string get_Name();
            /*0x780f890*/ bool get_IsThreadSafe();
            /*0x780f898*/ void Dispose();
            /*0x780f904*/ void Dispose(bool disposing);
            /*0x780f908*/ void Flush();
            /*0x780f90c*/ void set_IndentLevel(int value);
            /*0x780f928*/ void set_IndentSize(int value);
        }

        class TraceListenerCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.ArrayList list;

            /*0x780f9d0*/ TraceListenerCollection();
            /*0x780fa40*/ System.Diagnostics.TraceListener get_Item(string name);
            /*0x780fd6c*/ int get_Count();
            /*0x780fd90*/ int Add(System.Diagnostics.TraceListener listener);
            /*0x780ffb8*/ void Clear();
            /*0x780fd48*/ System.Collections.IEnumerator GetEnumerator();
            /*0x780fec8*/ void InitializeListener(System.Diagnostics.TraceListener listener);
            /*0x7810018*/ void Remove(string name);
            /*0x78100d8*/ void RemoveAt(int index);
            /*0x78101f8*/ object System.Collections.IList.get_Item(int index);
            /*0x781021c*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x7810328*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x7810330*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x7810338*/ int System.Collections.IList.Add(object value);
            /*0x7810518*/ bool System.Collections.IList.Contains(object value);
            /*0x781053c*/ int System.Collections.IList.IndexOf(object value);
            /*0x7810560*/ void System.Collections.IList.Insert(int index, object value);
            /*0x7810738*/ void System.Collections.IList.Remove(object value);
            /*0x7810858*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x781085c*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x7810864*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
        }

        class TraceSource
        {
            static /*0x0*/ System.Collections.Generic.List<System.WeakReference> tracesources;
            static /*0x8*/ int s_LastCollectionCount;
            /*0x10*/ System.Diagnostics.SourceSwitch internalSwitch;
            /*0x18*/ System.Diagnostics.TraceListenerCollection listeners;
            /*0x20*/ System.Collections.Specialized.StringDictionary attributes;
            /*0x28*/ System.Diagnostics.SourceLevels switchLevel;
            /*0x30*/ string sourceName;
            /*0x38*/ bool _initCalled;

            static /*0x7811b70*/ TraceSource();
            static /*0x7810c20*/ void _pruneCachedTraceSources();
            /*0x7810994*/ TraceSource(string name);
            /*0x781099c*/ TraceSource(string name, System.Diagnostics.SourceLevels defaultLevel);
            /*0x7811104*/ void Initialize();
            /*0x78111f4*/ void NoConfigInit();
            /*0x78113b4*/ void Flush();
            /*0x7811b30*/ System.Diagnostics.TraceListenerCollection get_Listeners();
            /*0x7811b50*/ System.Diagnostics.SourceSwitch get_Switch();
        }

        class TraceSwitch : System.Diagnostics.Switch
        {
            /*0x7811c08*/ TraceSwitch(string displayName, string description);
            /*0x7811c74*/ void OnSwitchSettingChanged();
            /*0x7811cac*/ void OnValueChanged();
        }

        class AsyncStreamReader
        {
            /*0x10*/ System.IO.Stream stream;
            /*0x18*/ System.Text.Encoding encoding;
            /*0x20*/ System.Text.Decoder decoder;
            /*0x28*/ byte[] byteBuffer;
            /*0x30*/ char[] charBuffer;
            /*0x38*/ bool cancelOperation;
            /*0x40*/ System.Threading.ManualResetEvent eofEvent;
            /*0x48*/ object syncObject;
            /*0x50*/ System.IAsyncResult asyncReadResult;

            /*0x7811d84*/ void Close();
            /*0x7811d94*/ void Dispose(bool disposing);
            /*0x781215c*/ void CancelOperation();
        }

        class Process : System.ComponentModel.Component
        {
            /*0x28*/ bool haveProcessId;
            /*0x2c*/ int processId;
            /*0x30*/ bool haveProcessHandle;
            /*0x38*/ Microsoft.Win32.SafeHandles.SafeProcessHandle m_processHandle;
            /*0x40*/ bool isRemoteMachine;
            /*0x48*/ string machineName;
            /*0x50*/ int m_processAccess;
            /*0x58*/ System.Diagnostics.ProcessThreadCollection threads;
            /*0x60*/ System.Diagnostics.ProcessModuleCollection modules;
            /*0x68*/ bool haveWorkingSetLimits;
            /*0x69*/ bool havePriorityClass;
            /*0x6a*/ bool watchForExit;
            /*0x6b*/ bool watchingForExit;
            /*0x70*/ System.EventHandler onExited;
            /*0x78*/ bool exited;
            /*0x7c*/ int exitCode;
            /*0x80*/ bool signaled;
            /*0x81*/ bool haveExitTime;
            /*0x82*/ bool raisedOnExited;
            /*0x88*/ System.Threading.RegisteredWaitHandle registeredWaitHandle;
            /*0x90*/ System.Threading.WaitHandle waitHandle;
            /*0x98*/ System.ComponentModel.ISynchronizeInvoke synchronizingObject;
            /*0xa0*/ System.IO.StreamReader standardOutput;
            /*0xa8*/ System.IO.StreamWriter standardInput;
            /*0xb0*/ System.IO.StreamReader standardError;
            /*0xb8*/ bool disposed;
            /*0xbc*/ System.Diagnostics.Process.StreamReadMode outputStreamReadMode;
            /*0xc0*/ System.Diagnostics.Process.StreamReadMode errorStreamReadMode;
            /*0xc4*/ System.Diagnostics.Process.StreamReadMode inputStreamReadMode;
            /*0xc8*/ System.Diagnostics.AsyncStreamReader output;
            /*0xd0*/ System.Diagnostics.AsyncStreamReader error;
            /*0xd8*/ string process_name;

            static /*0x7813204*/ System.Diagnostics.Process GetCurrentProcess();
            static /*0x7813878*/ string ProcessName_icall(nint handle);
            static /*0x781387c*/ string ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0x7812168*/ Process(string machineName, bool isRemoteMachine, int processId, System.Diagnostics.ProcessInfo processInfo);
            /*0x7812214*/ bool get_Associated();
            /*0x7812234*/ bool get_HasExited();
            /*0x7812c8c*/ int get_Id();
            /*0x7812ca8*/ System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject();
            /*0x7812e4c*/ void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0x7812e74*/ void Dispose(bool disposing);
            /*0x7812ec4*/ void Close();
            /*0x7812590*/ void EnsureState(System.Diagnostics.Process.State state);
            /*0x7813284*/ void OnExited();
            /*0x78126b8*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access, bool throwIfExited);
            /*0x78134d8*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access);
            /*0x78131cc*/ void Refresh();
            /*0x7813098*/ void StopWatchingForExit();
            /*0x78134e0*/ string ToString();
            /*0x7813640*/ string get_ProcessName();
            /*0x7812bac*/ void RaiseOnExited();

            enum StreamReadMode
            {
                undefined = 0,
                syncMode = 1,
                asyncMode = 2,
            }

            enum State
            {
                HaveId = 1,
                IsLocal = 2,
                IsNt = 4,
                HaveProcessInfo = 8,
                Exited = 16,
                Associated = 32,
                IsWin2k = 64,
                HaveNtProcessInfo = 12,
            }
        }

        class ProcessInfo
        {
        }

        class ProcessModuleCollection : System.Collections.ReadOnlyCollectionBase
        {
        }

        class ProcessThreadCollection : System.Collections.ReadOnlyCollectionBase
        {
        }

        class ProcessWaitHandle : System.Threading.WaitHandle
        {
            /*0x7812b54*/ ProcessWaitHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle);
        }

        class DefaultTraceListener : System.Diagnostics.TraceListener
        {
            static /*0x0*/ bool OnWin32;
            static /*0x8*/ string MonoTracePrefix;
            static /*0x10*/ string MonoTraceFile;

            static /*0x781396c*/ DefaultTraceListener();
            static /*0x7813adc*/ string GetPrefix(string var, string target);
            /*0x7811348*/ DefaultTraceListener();
        }

        class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute
        {
            /*0x7813b58*/ MonitoringDescriptionAttribute(string description);
            /*0x7813bc0*/ string get_Description();
        }

        class Stopwatch
        {
            static /*0x0*/ long Frequency;
            static /*0x8*/ bool IsHighResolution;
            /*0x10*/ long elapsed;
            /*0x18*/ long started;
            /*0x20*/ bool is_running;

            static /*0x781402c*/ Stopwatch();
            static /*0x7813bc8*/ long GetTimestamp();
            static /*0x7813bcc*/ System.Diagnostics.Stopwatch StartNew();
            /*0x7813c30*/ Stopwatch();
            /*0x7813ca0*/ System.TimeSpan get_Elapsed();
            /*0x7813e08*/ long get_ElapsedMilliseconds();
            /*0x7813d98*/ long get_ElapsedTicks();
            /*0x7813f4c*/ bool get_IsRunning();
            /*0x7813c38*/ void Start();
            /*0x7813f54*/ void Stop();
            /*0x7813fcc*/ void Restart();
        }

        namespace CodeAnalysis
        {
            class ExcludeFromCodeCoverageAttribute : System.Attribute
            {
                /*0x7814084*/ ExcludeFromCodeCoverageAttribute();
            }
        }
    }

    namespace Security
    {
        namespace Authentication
        {
            class AuthenticationException : System.SystemException
            {
                /*0x781408c*/ AuthenticationException();
                /*0x78140e4*/ AuthenticationException(string message, System.Exception innerException);
                /*0x78140ec*/ AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            }

            enum SslProtocols
            {
                None = 0,
                Ssl2 = 12,
                Ssl3 = 48,
                Tls = 192,
                Tls11 = 768,
                Tls12 = 3072,
                Tls13 = 12288,
                Default = 240,
            }
        }

        namespace Cryptography
        {
            class DerSequenceReader
            {
                static /*0x0*/ System.Globalization.DateTimeFormatInfo s_validityDateTimeFormatInfo;
                static /*0x8*/ System.Text.Encoding s_utf8EncodingWithExceptionFallback;
                static /*0x10*/ System.Text.Encoding s_latin1Encoding;
                /*0x10*/ byte[] _data;
                /*0x18*/ int _end;
                /*0x1c*/ int _position;
                /*0x20*/ int <ContentLength>k__BackingField;

                static /*0x7814cb8*/ string TrimTrailingNulls(string value);
                static /*0x7814df8*/ void CheckTag(System.Security.Cryptography.DerSequenceReader.DerTag expected, byte[] data, int position);
                static /*0x78144a0*/ int ScanContentLength(byte[] data, int offset, int end, ref int bytesConsumed);
                /*0x78140fc*/ DerSequenceReader(byte[] data);
                /*0x7814120*/ DerSequenceReader(byte[] data, int offset, int length);
                /*0x7814134*/ DerSequenceReader(System.Security.Cryptography.DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length);
                /*0x78140f4*/ void set_ContentLength(int value);
                /*0x78142f0*/ bool get_HasData();
                /*0x7814300*/ byte PeekTag();
                /*0x7814394*/ void SkipValue();
                /*0x78143e8*/ byte[] ReadNextEncodedValue();
                /*0x78145c4*/ bool ReadBoolean();
                /*0x781468c*/ int ReadInteger();
                /*0x7814740*/ byte[] ReadIntegerBytes();
                /*0x7814810*/ byte[] ReadBitString();
                /*0x7814954*/ byte[] ReadOctetString();
                /*0x7814970*/ string ReadOidAsString();
                /*0x7814c38*/ string ReadUtf8String();
                /*0x7814d34*/ System.Security.Cryptography.DerSequenceReader ReadCollectionWithTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x7814e8c*/ System.Security.Cryptography.DerSequenceReader ReadSequence();
                /*0x7814e94*/ System.Security.Cryptography.DerSequenceReader ReadSet();
                /*0x7814e9c*/ string ReadPrintableString();
                /*0x7814f1c*/ string ReadIA5String();
                /*0x7814f9c*/ string ReadT61String();
                /*0x7815284*/ System.DateTime ReadX509Date();
                /*0x7815304*/ System.DateTime ReadUtcTime();
                /*0x7815350*/ System.DateTime ReadGeneralizedTime();
                /*0x78155e4*/ string ReadBMPString();
                /*0x781539c*/ System.DateTime ReadTime(System.Security.Cryptography.DerSequenceReader.DerTag timeTag, string formatString);
                /*0x781475c*/ byte[] ReadContentAsBytes();
                /*0x7814234*/ void EatTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x78142b4*/ int EatLength();

                enum DerTag
                {
                    Boolean = 1,
                    Integer = 2,
                    BitString = 3,
                    OctetString = 4,
                    Null = 5,
                    ObjectIdentifier = 6,
                    UTF8String = 12,
                    Sequence = 16,
                    Set = 17,
                    PrintableString = 19,
                    T61String = 20,
                    IA5String = 22,
                    UTCTime = 23,
                    GeneralizedTime = 24,
                    BMPString = 30,
                }

                class <>c
                {
                    static /*0x0*/ System.Security.Cryptography.DerSequenceReader.<> <>9;
                    static /*0x8*/ System.Func<System.Text.Encoding> <>9__45_0;
                    static /*0x10*/ System.Func<System.Text.Encoding> <>9__45_1;
                    static /*0x18*/ System.Func<System.Globalization.DateTimeFormatInfo> <>9__51_0;

                    static /*0x7815664*/ <>c();
                    /*0x78156cc*/ <>c();
                    /*0x78156d4*/ System.Text.Encoding <ReadT61String>b__45_0();
                    /*0x7815730*/ System.Text.Encoding <ReadT61String>b__45_1();
                    /*0x7815774*/ System.Globalization.DateTimeFormatInfo <ReadTime>b__51_0();
                }
            }

            class Oid
            {
                /*0x10*/ string _value;
                /*0x18*/ string _friendlyName;
                /*0x20*/ System.Security.Cryptography.OidGroup _group;

                static /*0x78159b8*/ System.Security.Cryptography.Oid FromOidValue(string oidValue, System.Security.Cryptography.OidGroup group);
                /*0x7815840*/ Oid();
                /*0x7815848*/ Oid(string oid);
                /*0x78158dc*/ Oid(string value, string friendlyName);
                /*0x7815920*/ Oid(System.Security.Cryptography.Oid oid);
                /*0x7815ae4*/ Oid(string value, string friendlyName, System.Security.Cryptography.OidGroup group);
                /*0x7815b3c*/ string get_Value();
                /*0x7815b44*/ void set_Value(string value);
                /*0x7815b4c*/ string get_FriendlyName();
            }

            class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.Oid> _list;

                /*0x7815be4*/ OidCollection();
                /*0x7815c6c*/ int Add(System.Security.Cryptography.Oid oid);
                /*0x7815d28*/ System.Security.Cryptography.Oid get_Item(int index);
                /*0x7815d80*/ int get_Count();
                /*0x7815dc8*/ System.Security.Cryptography.OidEnumerator GetEnumerator();
                /*0x7815e74*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7815e78*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x7816024*/ bool get_IsSynchronized();
                /*0x781602c*/ object get_SyncRoot();
            }

            class OidEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Security.Cryptography.OidCollection _oids;
                /*0x18*/ int _current;

                /*0x7815e38*/ OidEnumerator(System.Security.Cryptography.OidCollection oids);
                /*0x7816030*/ System.Security.Cryptography.Oid get_Current();
                /*0x7816050*/ object System.Collections.IEnumerator.get_Current();
                /*0x7816054*/ bool MoveNext();
                /*0x78160a0*/ void Reset();
            }

            enum OidGroup
            {
                All = 0,
                HashAlgorithm = 1,
                EncryptionAlgorithm = 2,
                PublicKeyAlgorithm = 3,
                SignatureAlgorithm = 4,
                Attribute = 5,
                ExtensionOrAttribute = 6,
                EnhancedKeyUsage = 7,
                Policy = 8,
                Template = 9,
                KeyDerivationFunction = 10,
            }

            enum AsnDecodeStatus
            {
                NotDecoded = -1,
                Ok = 0,
                BadAsn = 1,
                BadTag = 2,
                BadLength = 3,
                InformationNotAvailable = 4,
            }

            class AsnEncodedData
            {
                /*0x10*/ System.Security.Cryptography.Oid _oid;
                /*0x18*/ byte[] _raw;

                /*0x78160ac*/ AsnEncodedData();
                /*0x78160b4*/ AsnEncodedData(string oid, byte[] rawData);
                /*0x7816230*/ AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData);
                /*0x78162e4*/ AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x78163b8*/ System.Security.Cryptography.Oid get_Oid();
                /*0x781626c*/ void set_Oid(System.Security.Cryptography.Oid value);
                /*0x78163c0*/ byte[] get_RawData();
                /*0x781613c*/ void set_RawData(byte[] value);
                /*0x78163c8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x7816498*/ string Format(bool multiLine);
                /*0x78165f0*/ string ToString(bool multiLine);
                /*0x78164d8*/ string Default(bool multiLine);
                /*0x78167a0*/ string BasicConstraintsExtension(bool multiLine);
                /*0x78168a4*/ string EnhancedKeyUsageExtension(bool multiLine);
                /*0x78169a8*/ string KeyUsageExtension(bool multiLine);
                /*0x7816aac*/ string SubjectKeyIdentifierExtension(bool multiLine);
                /*0x7816bb0*/ string SubjectAltName(bool multiLine);
                /*0x7816f64*/ string NetscapeCertType(bool multiLine);
            }

            namespace X509Certificates
            {
                enum OpenFlags
                {
                    ReadOnly = 0,
                    ReadWrite = 1,
                    MaxAllowed = 2,
                    OpenExistingOnly = 4,
                    IncludeArchived = 8,
                }

                enum StoreLocation
                {
                    CurrentUser = 1,
                    LocalMachine = 2,
                }

                enum StoreName
                {
                    AddressBook = 1,
                    AuthRoot = 2,
                    CertificateAuthority = 3,
                    Disallowed = 4,
                    My = 5,
                    Root = 6,
                    TrustedPeople = 7,
                    TrustedPublisher = 8,
                }

                enum X500DistinguishedNameFlags
                {
                    None = 0,
                    Reversed = 1,
                    UseSemicolons = 16,
                    DoNotUsePlusSign = 32,
                    DoNotUseQuotes = 64,
                    UseCommas = 128,
                    UseNewLines = 256,
                    UseUTF8Encoding = 4096,
                    UseT61Encoding = 8192,
                    ForceUTF8Encoding = 16384,
                }

                enum X509ChainStatusFlags
                {
                    NoError = 0,
                    NotTimeValid = 1,
                    NotTimeNested = 2,
                    Revoked = 4,
                    NotSignatureValid = 8,
                    NotValidForUsage = 16,
                    UntrustedRoot = 32,
                    RevocationStatusUnknown = 64,
                    Cyclic = 128,
                    InvalidExtension = 256,
                    InvalidPolicyConstraints = 512,
                    InvalidBasicConstraints = 1024,
                    InvalidNameConstraints = 2048,
                    HasNotSupportedNameConstraint = 4096,
                    HasNotDefinedNameConstraint = 8192,
                    HasNotPermittedNameConstraint = 16384,
                    HasExcludedNameConstraint = 32768,
                    PartialChain = 65536,
                    CtlNotTimeValid = 131072,
                    CtlNotSignatureValid = 262144,
                    CtlNotValidForUsage = 524288,
                    OfflineRevocation = 16777216,
                    NoIssuanceChainPolicy = 33554432,
                    ExplicitDistrust = 67108864,
                    HasNotSupportedCriticalExtension = 134217728,
                    HasWeakSignature = 1048576,
                }

                enum X509FindType
                {
                    FindByThumbprint = 0,
                    FindBySubjectName = 1,
                    FindBySubjectDistinguishedName = 2,
                    FindByIssuerName = 3,
                    FindByIssuerDistinguishedName = 4,
                    FindBySerialNumber = 5,
                    FindByTimeValid = 6,
                    FindByTimeNotYetValid = 7,
                    FindByTimeExpired = 8,
                    FindByTemplateName = 9,
                    FindByApplicationPolicy = 10,
                    FindByCertificatePolicy = 11,
                    FindByExtension = 12,
                    FindByKeyUsage = 13,
                    FindBySubjectKeyIdentifier = 14,
                }

                enum X509KeyUsageFlags
                {
                    None = 0,
                    EncipherOnly = 1,
                    CrlSign = 2,
                    KeyCertSign = 4,
                    KeyAgreement = 8,
                    DataEncipherment = 16,
                    KeyEncipherment = 32,
                    NonRepudiation = 64,
                    DigitalSignature = 128,
                    DecipherOnly = 32768,
                }

                enum X509NameType
                {
                    SimpleName = 0,
                    EmailName = 1,
                    UpnName = 2,
                    DnsName = 3,
                    DnsFromAlternativeName = 4,
                    UrlName = 5,
                }

                enum X509RevocationFlag
                {
                    EndCertificateOnly = 0,
                    EntireChain = 1,
                    ExcludeRoot = 2,
                }

                enum X509RevocationMode
                {
                    NoCheck = 0,
                    Online = 1,
                    Offline = 2,
                }

                enum X509SubjectKeyIdentifierHashAlgorithm
                {
                    Sha1 = 0,
                    ShortSha1 = 1,
                    CapiSha1 = 2,
                }

                enum X509VerificationFlags
                {
                    NoFlag = 0,
                    IgnoreNotTimeValid = 1,
                    IgnoreCtlNotTimeValid = 2,
                    IgnoreNotTimeNested = 4,
                    IgnoreInvalidBasicConstraints = 8,
                    AllowUnknownCertificateAuthority = 16,
                    IgnoreWrongUsage = 32,
                    IgnoreInvalidName = 64,
                    IgnoreInvalidPolicy = 128,
                    IgnoreEndRevocationUnknown = 256,
                    IgnoreCtlSignerRevocationUnknown = 512,
                    IgnoreCertificateAuthorityRevocationUnknown = 1024,
                    IgnoreRootRevocationUnknown = 2048,
                    AllFlags = 4095,
                }

                class PublicKey
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Security.Cryptography.AsnEncodedData _keyValue;
                    /*0x18*/ System.Security.Cryptography.AsnEncodedData _params;
                    /*0x20*/ System.Security.Cryptography.Oid _oid;

                    static /*0x7818328*/ PublicKey();
                    static /*0x7818294*/ byte[] GetUnsignedBigInteger(byte[] integer);
                    static /*0x7817dc0*/ System.Security.Cryptography.DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters);
                    static /*0x7817a08*/ System.Security.Cryptography.RSA DecodeRSA(byte[] rawPublicKey);
                    /*0x78176dc*/ PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue);
                    /*0x7817854*/ System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue();
                    /*0x781785c*/ System.Security.Cryptography.AsnEncodedData get_EncodedParameters();
                    /*0x7817864*/ System.Security.Cryptography.AsymmetricAlgorithm get_Key();
                    /*0x781828c*/ System.Security.Cryptography.Oid get_Oid();
                }

                class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ string name;
                    /*0x28*/ byte[] canonEncoding;

                    static /*0x78186c8*/ string GetSeparator(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    static /*0x781879c*/ string Canonize(string s);
                    static /*0x781896c*/ bool AreEqual(System.Security.Cryptography.X509Certificates.X500DistinguishedName name1, System.Security.Cryptography.X509Certificates.X500DistinguishedName name2);
                    /*0x781839c*/ X500DistinguishedName(byte[] encodedDistinguishedName);
                    /*0x781857c*/ string get_Name();
                    /*0x7818584*/ string Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    /*0x7818740*/ string Format(bool multiLine);
                    /*0x7818498*/ void DecodeRawData();
                }

                class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.19";
                    static string friendlyName = "Basic Constraints";
                    /*0x21*/ bool _certificateAuthority;
                    /*0x22*/ bool _hasPathLengthConstraint;
                    /*0x24*/ int _pathLengthConstraint;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x7818b5c*/ X509BasicConstraintsExtension();
                    /*0x781733c*/ X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical);
                    /*0x7818dc8*/ X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical);
                    /*0x781905c*/ bool get_CertificateAuthority();
                    /*0x78190c4*/ bool get_HasPathLengthConstraint();
                    /*0x781912c*/ int get_PathLengthConstraint();
                    /*0x7819194*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x7818c04*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x7818f00*/ byte[] Encode();
                    /*0x7819360*/ string ToString(bool multiLine);
                }

                class X509Certificate2 : System.Security.Cryptography.X509Certificates.X509Certificate
                {
                    /*0x60*/ byte[] lazyRawData;
                    /*0x68*/ System.Security.Cryptography.Oid lazySignatureAlgorithm;
                    /*0x70*/ int lazyVersion;
                    /*0x78*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName lazySubjectName;
                    /*0x80*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName lazyIssuerName;
                    /*0x88*/ System.Security.Cryptography.X509Certificates.PublicKey lazyPublicKey;
                    /*0x90*/ System.Security.Cryptography.AsymmetricAlgorithm lazyPrivateKey;
                    /*0x98*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection lazyExtensions;

                    static /*0x781a5d0*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
                    static /*0x7819e5c*/ System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid);
                    /*0x7819778*/ X509Certificate2();
                    /*0x7819780*/ X509Certificate2(byte[] rawData);
                    /*0x7819948*/ X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
                    /*0x7819950*/ X509Certificate2(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x78196cc*/ void Reset();
                    /*0x7819990*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection get_Extensions();
                    /*0x781a090*/ bool get_HasPrivateKey();
                    /*0x781a0c4*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x781a228*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x781a294*/ System.DateTime get_NotAfter();
                    /*0x781a29c*/ System.DateTime get_NotBefore();
                    /*0x781a2a4*/ System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    /*0x781a3fc*/ byte[] get_RawData();
                    /*0x781a468*/ string get_SerialNumber();
                    /*0x781a478*/ System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    /*0x781a4ec*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x781a558*/ string get_Thumbprint();
                    /*0x781a574*/ int get_Version();
                    /*0x781a668*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x781a6a4*/ string ToString();
                    /*0x781a6b0*/ string ToString(bool verbose);
                    /*0x781b750*/ bool Verify();
                    /*0x7819dd0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl();
                }

                class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection
                {
                    static /*0x0*/ string[] newline_split;

                    static /*0x781daa0*/ X509Certificate2Collection();
                    /*0x781b95c*/ X509Certificate2Collection();
                    /*0x781b96c*/ X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x781ba08*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Item(int index);
                    /*0x781bb2c*/ int Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x781b998*/ void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x781bb9c*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x781bedc*/ string GetKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 x);
                    /*0x781c788*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, bool validOnly);
                    /*0x781d98c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator();
                }

                class X509Certificate2Enumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x781d9e4*/ X509Certificate2Enumerator(System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection);
                    /*0x781db44*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Current();
                    /*0x781dc34*/ bool MoveNext();
                    /*0x781dcd4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x781dd78*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x781de18*/ void System.Collections.IEnumerator.Reset();
                }

                class X509Certificate2Impl : System.Security.Cryptography.X509Certificates.X509CertificateImpl
                {
                    /*0x781debc*/ X509Certificate2Impl();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x380b9e8*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x380d83c*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0x380b9e8*/ string get_SignatureAlgorithm();
                    /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x380b6a0*/ int get_Version();
                    /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x380b2f0*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0x380d83c*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509Certificate2ImplMono : System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix
                {
                    static /*0x0*/ string empty_error;
                    static /*0x8*/ byte[] signedData;
                    /*0xb0*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;
                    /*0xb8*/ Mono.Security.X509.X509Certificate _cert;

                    static /*0x781f34c*/ X509Certificate2ImplMono();
                    /*0x781ded4*/ X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert);
                    /*0x781df0c*/ X509Certificate2ImplMono(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other);
                    /*0x781dfc4*/ X509Certificate2ImplMono(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x781dec4*/ bool get_IsValid();
                    /*0x781e194*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone();
                    /*0x781e1f8*/ Mono.Security.X509.X509Certificate get_Cert();
                    /*0x781e214*/ byte[] GetRawCertData();
                    /*0x781e24c*/ bool get_HasPrivateKey();
                    /*0x781e270*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x781e668*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0x781e7f0*/ System.Security.Cryptography.RSA GetRSAPrivateKey();
                    /*0x781e87c*/ System.Security.Cryptography.DSA GetDSAPrivateKey();
                    /*0x781e13c*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password);
                    /*0x781e908*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password);
                    /*0x781f220*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0x781f33c*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    /*0x781f344*/ Mono.Security.X509.X509Certificate get_MonoCertificate();
                }

                class X509Certificate2ImplUnix : System.Security.Cryptography.X509Certificates.X509Certificate2Impl
                {
                    /*0x10*/ bool readCertData;
                    /*0x18*/ Internal.Cryptography.Pal.CertificateData certData;

                    /*0x781df04*/ X509Certificate2ImplUnix();
                    /*0x781f420*/ void EnsureCertData();
                    /*0x380b9e8*/ byte[] GetRawCertData();
                    /*0x781f4b0*/ string get_KeyAlgorithm();
                    /*0x781f4c8*/ byte[] get_KeyAlgorithmParameters();
                    /*0x781f4e0*/ byte[] get_PublicKeyValue();
                    /*0x781f4f8*/ byte[] get_SerialNumber();
                    /*0x781f510*/ string get_SignatureAlgorithm();
                    /*0x781f528*/ int get_Version();
                    /*0x781f544*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x781f55c*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x781f574*/ string get_Subject();
                    /*0x781f59c*/ string get_Issuer();
                    /*0x781f5c4*/ byte[] get_RawData();
                    /*0x781f5dc*/ byte[] get_Thumbprint();
                    /*0x781f76c*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x781f7a0*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0x781f7b8*/ System.DateTime get_NotAfter();
                    /*0x781f818*/ System.DateTime get_NotBefore();
                    /*0x781f878*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509CertificateCollection : System.Collections.CollectionBase
                {
                    /*0x781b964*/ X509CertificateCollection();
                    /*0x781f90c*/ X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x781fa08*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Item(int index);
                    /*0x781f938*/ void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x781faa0*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                    /*0x781fbb4*/ int GetHashCode();

                    class X509CertificateEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.IEnumerator enumerator;

                        /*0x781faf8*/ X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings);
                        /*0x781fbd4*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Current();
                        /*0x781fcc4*/ object System.Collections.IEnumerator.get_Current();
                        /*0x781fd68*/ bool System.Collections.IEnumerator.MoveNext();
                        /*0x781fe08*/ void System.Collections.IEnumerator.Reset();
                        /*0x781feac*/ bool MoveNext();
                    }
                }

                class X509CertificateImplCollection : System.IDisposable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list;

                    /*0x781f0c0*/ X509CertificateImplCollection();
                    /*0x781ff4c*/ X509CertificateImplCollection(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other);
                    /*0x7820184*/ int get_Count();
                    /*0x78201cc*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(int index);
                    /*0x781f148*/ void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, bool takeOwnership);
                    /*0x781df6c*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone();
                    /*0x7820224*/ void Dispose();
                    /*0x7820290*/ void Dispose(bool disposing);
                    /*0x78204a8*/ void Finalize();
                }

                class X509Chain : System.IDisposable
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainImpl impl;

                    static /*0x781f2ac*/ System.Security.Cryptography.X509Certificates.X509Chain Create();
                    /*0x78205a4*/ X509Chain();
                    /*0x78205ac*/ X509Chain(bool useMachineContext);
                    /*0x782063c*/ X509Chain(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    /*0x7820674*/ X509Chain(nint chainContext);
                    /*0x7820548*/ System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl();
                    /*0x78206b4*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x78206e0*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x781f300*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x782070c*/ void Reset();
                    /*0x7820738*/ void Dispose();
                    /*0x78207a4*/ void Dispose(bool disposing);
                    /*0x7820840*/ void Finalize();
                }

                class X509ChainElement
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509Certificate2 certificate;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x20*/ string info;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags compressed_status_flags;

                    /*0x78208e0*/ X509ChainElement(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7820930*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate();
                    /*0x7820938*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainElementStatus();
                    /*0x7820940*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_StatusFlags();
                    /*0x7820948*/ void set_StatusFlags(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x7820950*/ int Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x7820974*/ void Set(System.Security.Cryptography.X509Certificates.X509ChainStatus[] status, ref int position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask);
                    /*0x7820b74*/ void UncompressFlags();
                }

                class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _list;

                    /*0x7820dd4*/ X509ChainElementCollection();
                    /*0x7820e40*/ int get_Count();
                    /*0x7820e64*/ bool get_IsSynchronized();
                    /*0x7820e88*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(int index);
                    /*0x7820f20*/ object get_SyncRoot();
                    /*0x7820f44*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x7820f68*/ System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator();
                    /*0x7821080*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x78210dc*/ void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x782115c*/ void Clear();
                    /*0x7821180*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                }

                class X509ChainElementEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x7820fc4*/ X509ChainElementEnumerator(System.Collections.IEnumerable enumerable);
                    /*0x7821288*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Current();
                    /*0x7821378*/ object System.Collections.IEnumerator.get_Current();
                    /*0x782141c*/ bool MoveNext();
                    /*0x78214bc*/ void Reset();
                }

                class X509ChainImpl : System.IDisposable
                {
                    /*0x78216c0*/ X509ChainImpl();
                    /*0x380b128*/ bool get_IsValid();
                    /*0x7821560*/ void ThrowIfContextInvalid();
                    /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x380b9e8*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x380b2f0*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x380cffc*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode);
                    /*0x380cb08*/ void Reset();
                    /*0x78207d4*/ void Dispose();
                    /*0x782161c*/ void Dispose(bool disposing);
                    /*0x7821620*/ void Finalize();
                }

                class X509ChainImplMono : System.Security.Cryptography.X509Certificates.X509ChainImpl
                {
                    static /*0x0*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] Empty;
                    /*0x10*/ System.Security.Cryptography.X509Certificates.StoreLocation location;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x30*/ int max_path_length;
                    /*0x38*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName working_issuer_name;
                    /*0x40*/ System.Security.Cryptography.AsymmetricAlgorithm working_public_key;
                    /*0x48*/ System.Security.Cryptography.X509Certificates.X509ChainElement bce_restriction;
                    /*0x50*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection roots;
                    /*0x58*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection cas;
                    /*0x60*/ System.Security.Cryptography.X509Certificates.X509Store root_store;
                    /*0x68*/ System.Security.Cryptography.X509Certificates.X509Store ca_store;
                    /*0x70*/ System.Security.Cryptography.X509Certificates.X509Store user_root_store;
                    /*0x78*/ System.Security.Cryptography.X509Certificates.X509Store user_ca_store;
                    /*0x80*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection;

                    static /*0x7824dc0*/ X509ChainImplMono();
                    static /*0x782336c*/ string GetAuthorityKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x7823f58*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Crl crl);
                    static /*0x7823e00*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext);
                    static /*0x7824a40*/ Mono.Security.X509.X509Crl CheckCrls(string subject, string ski, Mono.Security.X509.X509Store store);
                    /*0x78216c8*/ X509ChainImplMono(bool useMachineContext);
                    /*0x78217a8*/ bool get_IsValid();
                    /*0x78217b0*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x78217b8*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x78217c0*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
                    /*0x78217c4*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7821ff4*/ void Reset();
                    /*0x7822174*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Roots();
                    /*0x78224c0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateAuthorities();
                    /*0x7822248*/ System.Security.Cryptography.X509Certificates.X509Store get_LMRootStore();
                    /*0x7822340*/ System.Security.Cryptography.X509Certificates.X509Store get_UserRootStore();
                    /*0x7822594*/ System.Security.Cryptography.X509Certificates.X509Store get_LMCAStore();
                    /*0x782268c*/ System.Security.Cryptography.X509Certificates.X509Store get_UserCAStore();
                    /*0x7822cb0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateCollection();
                    /*0x7821db4*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x78231e0*/ System.Security.Cryptography.X509Certificates.X509Certificate2 SelectBestFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2 child, System.Security.Cryptography.X509Certificates.X509Certificate2Collection c);
                    /*0x7823004*/ System.Security.Cryptography.X509Certificates.X509Certificate2 FindParent(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7823118*/ bool IsChainComplete(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x78234a4*/ bool IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7821e9c*/ void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x78234ec*/ void Process(int n);
                    /*0x7823794*/ void PrepareForNextCertificate(int n);
                    /*0x7823b8c*/ void WrapUp();
                    /*0x7823d18*/ void ProcessCertificateExtensions(System.Security.Cryptography.X509Certificates.X509ChainElement element);
                    /*0x7823ce0*/ bool IsSignedWith(System.Security.Cryptography.X509Certificates.X509Certificate2 signed, System.Security.Cryptography.AsymmetricAlgorithm pubkey);
                    /*0x7823400*/ string GetSubjectKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x78239a4*/ void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x7823fe4*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, int ca, bool online);
                    /*0x78240b0*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2 ca_cert, bool online);
                    /*0x7824284*/ Mono.Security.X509.X509Crl FindCrl(System.Security.Cryptography.X509Certificates.X509Certificate2 caCertificate);
                    /*0x7824700*/ bool ProcessCrlExtensions(Mono.Security.X509.X509Crl crl);
                    /*0x78243f8*/ bool ProcessCrlEntryExtensions(Mono.Security.X509.X509Crl.X509CrlEntry entry);
                }

                class X509ChainPolicy
                {
                    /*0x10*/ System.Security.Cryptography.OidCollection apps;
                    /*0x18*/ System.Security.Cryptography.OidCollection cert;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection store;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection store2;
                    /*0x30*/ System.Security.Cryptography.X509Certificates.X509RevocationFlag rflag;
                    /*0x34*/ System.Security.Cryptography.X509Certificates.X509RevocationMode mode;
                    /*0x38*/ System.TimeSpan timeout;
                    /*0x40*/ System.Security.Cryptography.X509Certificates.X509VerificationFlags vflags;
                    /*0x48*/ System.DateTime vtime;

                    /*0x782178c*/ X509ChainPolicy();
                    /*0x7822d94*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_ExtraStore();
                    /*0x7824f44*/ System.Security.Cryptography.X509Certificates.X509RevocationFlag get_RevocationFlag();
                    /*0x7824f4c*/ System.Security.Cryptography.X509Certificates.X509RevocationMode get_RevocationMode();
                    /*0x7824f54*/ void set_RevocationMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                    /*0x7824fb4*/ System.Security.Cryptography.X509Certificates.X509VerificationFlags get_VerificationFlags();
                    /*0x7824fbc*/ void set_VerificationFlags(System.Security.Cryptography.X509Certificates.X509VerificationFlags value);
                    /*0x782501c*/ System.DateTime get_VerificationTime();
                    /*0x7824e34*/ void Reset();
                }

                struct X509ChainStatus
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status;
                    /*0x18*/ string info;

                    static /*0x78209f0*/ string GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x7821fcc*/ X509ChainStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x7825024*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_Status();
                    /*0x782502c*/ void set_Status(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x7825034*/ void set_StatusInformation(string value);
                }

                class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    /*0x28*/ System.Security.Cryptography.OidCollection _enhKeyUsage;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x781b81c*/ X509EnhancedKeyUsageExtension();
                    /*0x7817424*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical);
                    /*0x7825288*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical);
                    /*0x78254d4*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x782503c*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x7825418*/ byte[] Encode();
                    /*0x78256a0*/ string ToString(bool multiLine);
                }

                class X509Extension : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ bool _critical;

                    /*0x7818bfc*/ X509Extension();
                    /*0x7825964*/ X509Extension(string oid, byte[] rawData, bool critical);
                    /*0x7825988*/ bool get_Critical();
                    /*0x7825990*/ void set_Critical(bool value);
                    /*0x782599c*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x78195bc*/ string FormatUnkownData(byte[] data);
                }

                class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Collections.ArrayList _list;

                    static /*0x7825c84*/ X509ExtensionCollection();
                    /*0x7819d64*/ X509ExtensionCollection();
                    /*0x781b540*/ int get_Count();
                    /*0x7825abc*/ bool get_IsSynchronized();
                    /*0x7825ae0*/ object get_SyncRoot();
                    /*0x781bf98*/ System.Security.Cryptography.X509Certificates.X509Extension get_Item(string oid);
                    /*0x781a020*/ int Add(System.Security.Cryptography.X509Certificates.X509Extension extension);
                    /*0x7825ae4*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x781b564*/ System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator();
                    /*0x7825c28*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class X509ExtensionEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x7825bdc*/ X509ExtensionEnumerator(System.Collections.ArrayList list);
                    /*0x781b5c0*/ System.Security.Cryptography.X509Certificates.X509Extension get_Current();
                    /*0x7825cf8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x781b6b0*/ bool MoveNext();
                    /*0x7825d9c*/ void Reset();
                }

                class X509Helper2
                {
                    static /*0x7823c18*/ Mono.Security.X509.X509Certificate GetMonoCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x78205e4*/ System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(bool useMachineContext);
                    static /*0x7825e40*/ bool IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x7820564*/ void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x782159c*/ System.Exception GetInvalidChainContextException();
                }

                class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.15";
                    static string friendlyName = "Key Usage";
                    static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all = 33023;
                    /*0x24*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x781b77c*/ X509KeyUsageExtension();
                    /*0x781750c*/ X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical);
                    /*0x7826008*/ X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical);
                    /*0x781d924*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages();
                    /*0x7826250*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x78260e4*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags);
                    /*0x7825e54*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x78260f4*/ byte[] Encode();
                    /*0x782641c*/ string ToString(bool multiLine);
                }

                class X509Store : System.IDisposable
                {
                    /*0x10*/ string _name;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.StoreLocation _location;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection list;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.OpenFlags _flags;
                    /*0x30*/ Mono.Security.X509.X509Store store;

                    /*0x7822784*/ X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation);
                    /*0x7822438*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Certificates();
                    /*0x7826970*/ Mono.Security.X509.X509Stores get_Factory();
                    /*0x782698c*/ Mono.Security.X509.X509Store get_Store();
                    /*0x7822140*/ void Close();
                    /*0x7826994*/ void Dispose();
                    /*0x78228bc*/ void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags);
                }

                class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.14";
                    static string friendlyName = "Subject Key Identifier";
                    /*0x28*/ byte[] _subjectKeyIdentifier;
                    /*0x30*/ string _ski;
                    /*0x38*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    static /*0x7827184*/ byte FromHexChar(char c);
                    static /*0x78271c8*/ byte FromHexChars(char c1, char c2);
                    static /*0x7826eb8*/ byte[] FromHex(string hex);
                    /*0x781b8bc*/ X509SubjectKeyIdentifierExtension();
                    /*0x78175f4*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical);
                    /*0x7826b04*/ X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical);
                    /*0x7826d50*/ X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical);
                    /*0x7826fac*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical);
                    /*0x781c32c*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical);
                    /*0x781c6fc*/ string get_SubjectKeyIdentifier();
                    /*0x7826fb8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x7826998*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x7826cdc*/ byte[] Encode();
                    /*0x7827264*/ string ToString(bool multiLine);
                }
            }
        }
    }

    namespace ComponentModel
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object _value;

            /*0x7827490*/ DefaultValueAttribute(int value);
            /*0x78274dc*/ DefaultValueAttribute(long value);
            /*0x7827528*/ DefaultValueAttribute(bool value);
            /*0x7827574*/ DefaultValueAttribute(string value);
            /*0x78275a4*/ DefaultValueAttribute(object value);
            /*0x78275d4*/ object get_Value();
            /*0x78275dc*/ bool Equals(object obj);
            /*0x78276e8*/ int GetHashCode();
        }

        class EditorBrowsableAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.EditorBrowsableState browsableState;

            /*0x78276f0*/ EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state);
            /*0x7827718*/ bool Equals(object obj);
            /*0x78277a4*/ int GetHashCode();
        }

        enum EditorBrowsableState
        {
            Always = 0,
            Never = 1,
            Advanced = 2,
        }

        class BrowsableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.BrowsableAttribute Yes;
            static /*0x8*/ System.ComponentModel.BrowsableAttribute No;
            static /*0x10*/ System.ComponentModel.BrowsableAttribute Default;
            /*0x10*/ bool <Browsable>k__BackingField;

            static /*0x7827964*/ BrowsableAttribute();
            /*0x78277ac*/ BrowsableAttribute(bool browsable);
            /*0x78277d4*/ bool get_Browsable();
            /*0x78277dc*/ bool Equals(object obj);
            /*0x78278c0*/ int GetHashCode();
            /*0x78278fc*/ bool IsDefaultAttribute();
        }

        class ComponentCollection : System.Collections.ReadOnlyCollectionBase
        {
            /*0x7827a14*/ System.ComponentModel.IComponent get_Item(string name);
        }

        class DescriptionAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DescriptionAttribute Default;
            /*0x10*/ string <DescriptionValue>k__BackingField;

            static /*0x782816c*/ DescriptionAttribute();
            /*0x7827f88*/ DescriptionAttribute();
            /*0x7827fc8*/ DescriptionAttribute(string description);
            /*0x7827ff8*/ string get_Description();
            /*0x7828000*/ string get_DescriptionValue();
            /*0x7828008*/ void set_DescriptionValue(string value);
            /*0x7828010*/ bool Equals(object obj);
            /*0x78280dc*/ int GetHashCode();
            /*0x7828104*/ bool IsDefaultAttribute();
        }

        class DesignOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.DesignOnlyAttribute Default;
            /*0x10*/ bool <IsDesignOnly>k__BackingField;

            static /*0x78283c8*/ DesignOnlyAttribute();
            /*0x78281f8*/ DesignOnlyAttribute(bool isDesignOnly);
            /*0x7828220*/ bool get_IsDesignOnly();
            /*0x7828228*/ bool Equals(object obj);
            /*0x782830c*/ int GetHashCode();
            /*0x7828348*/ bool IsDefaultAttribute();
        }

        class DesignerCategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerCategoryAttribute Component;
            static /*0x8*/ System.ComponentModel.DesignerCategoryAttribute Default;
            static /*0x10*/ System.ComponentModel.DesignerCategoryAttribute Form;
            static /*0x18*/ System.ComponentModel.DesignerCategoryAttribute Generic;
            /*0x10*/ string <Category>k__BackingField;

            static /*0x7828644*/ DesignerCategoryAttribute();
            /*0x7828478*/ DesignerCategoryAttribute();
            /*0x78284ac*/ DesignerCategoryAttribute(string category);
            /*0x78284dc*/ string get_Category();
            /*0x78284e4*/ bool Equals(object obj);
            /*0x7828574*/ int GetHashCode();
            /*0x7828594*/ bool IsDefaultAttribute();
            /*0x782860c*/ object get_TypeId();
        }

        enum DesignerSerializationVisibility
        {
            Hidden = 0,
            Visible = 1,
            Content = 2,
        }

        class DesignerSerializationVisibilityAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Content;
            static /*0x8*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Hidden;
            static /*0x10*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Visible;
            static /*0x18*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Default;
            /*0x10*/ System.ComponentModel.DesignerSerializationVisibility <Visibility>k__BackingField;

            static /*0x782893c*/ DesignerSerializationVisibilityAttribute();
            /*0x78287c4*/ DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility);
            /*0x78287ec*/ System.ComponentModel.DesignerSerializationVisibility get_Visibility();
            /*0x78287f4*/ bool Equals(object obj);
            /*0x78288cc*/ int GetHashCode();
            /*0x78288d4*/ bool IsDefaultAttribute();
        }

        class DisplayNameAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DisplayNameAttribute Default;
            /*0x10*/ string <DisplayNameValue>k__BackingField;

            static /*0x7828c00*/ DisplayNameAttribute();
            /*0x7828a1c*/ DisplayNameAttribute();
            /*0x7828a5c*/ DisplayNameAttribute(string displayName);
            /*0x7828a8c*/ string get_DisplayName();
            /*0x7828a94*/ string get_DisplayNameValue();
            /*0x7828a9c*/ void set_DisplayNameValue(string value);
            /*0x7828aa4*/ bool Equals(object obj);
            /*0x7828b70*/ int GetHashCode();
            /*0x7828b98*/ bool IsDefaultAttribute();
        }

        class EventHandlerList
        {
            /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _head;
            /*0x18*/ System.ComponentModel.Component _parent;

            /*0x7828c8c*/ System.Delegate get_Item(object key);
            /*0x7828cf4*/ System.ComponentModel.EventHandlerList.ListEntry Find(object key);

            class ListEntry
            {
                /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _next;
                /*0x18*/ object _key;
                /*0x20*/ System.Delegate _handler;
            }
        }

        interface IContainer : System.IDisposable
        {
            /*0x380b9e8*/ System.ComponentModel.ComponentCollection get_Components();
            /*0x380d83c*/ void Remove(System.ComponentModel.IComponent component);
        }

        interface ISite : System.IServiceProvider
        {
            /*0x380b9e8*/ System.ComponentModel.IContainer get_Container();
            /*0x380b128*/ bool get_DesignMode();
            /*0x380b9e8*/ string get_Name();
        }

        interface ISynchronizeInvoke
        {
            /*0x380b128*/ bool get_InvokeRequired();
            /*0x380bcbc*/ System.IAsyncResult BeginInvoke(System.Delegate method, object[] args);
        }

        class InvalidEnumArgumentException : System.ArgumentException
        {
            /*0x7828d0c*/ InvalidEnumArgumentException();
            /*0x7828d18*/ InvalidEnumArgumentException(string message);
            /*0x7828d20*/ InvalidEnumArgumentException(string argumentName, int invalidValue, System.Type enumClass);
            /*0x7828e04*/ InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class ReadOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ReadOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.ReadOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.ReadOnlyAttribute Default;
            /*0x10*/ bool <IsReadOnly>k__BackingField;

            static /*0x7828fa8*/ ReadOnlyAttribute();
            /*0x7828e0c*/ ReadOnlyAttribute(bool isReadOnly);
            /*0x7828e34*/ bool get_IsReadOnly();
            /*0x7828e3c*/ bool Equals(object value);
            /*0x7828f20*/ int GetHashCode();
            /*0x7828f28*/ bool IsDefaultAttribute();
        }

        class AmbientValueAttribute : System.Attribute
        {
            /*0x10*/ object <Value>k__BackingField;

            /*0x7829058*/ object get_Value();
        }

        class ArrayConverter : System.ComponentModel.CollectionConverter
        {
            /*0x7829710*/ ArrayConverter();
            /*0x7829060*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7829358*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x7829708*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class ArrayPropertyDescriptor : System.ComponentModel.TypeConverter.SimplePropertyDescriptor
            {
                /*0x98*/ int _index;

                /*0x7829538*/ ArrayPropertyDescriptor(System.Type arrayType, System.Type elementType, int index);
                /*0x7829720*/ object GetValue(object instance);
                /*0x78297b0*/ void SetValue(object instance, object value);
            }
        }

        class AttributeCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            static /*0x0*/ System.ComponentModel.AttributeCollection Empty;
            static /*0x8*/ System.Collections.Hashtable s_defaultAttributes;
            static /*0x10*/ object s_internalSyncObject;
            /*0x10*/ System.Attribute[] _attributes;
            /*0x18*/ System.ComponentModel.AttributeCollection.AttributeEntry[] _foundAttributeTypes;
            /*0x20*/ int _index;

            static /*0x782a59c*/ AttributeCollection();
            /*0x78298a4*/ AttributeCollection(System.Attribute[] attributes);
            /*0x78299e4*/ System.Attribute[] get_Attributes();
            /*0x78299ec*/ int get_Count();
            /*0x7829a10*/ System.Attribute get_Item(System.Type attributeType);
            /*0x782a474*/ bool Contains(System.Attribute attribute);
            /*0x7829ef8*/ System.Attribute GetDefaultAttribute(System.Type attributeType);
            /*0x782a4d4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x782a4f8*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x782a500*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x782a508*/ int System.Collections.ICollection.get_Count();
            /*0x782a52c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x782a530*/ void CopyTo(System.Array array, int index);

            struct AttributeEntry
            {
                /*0x10*/ System.Type type;
                /*0x18*/ int index;
            }
        }

        class AttributeProviderAttribute : System.Attribute
        {
            /*0x10*/ string <TypeName>k__BackingField;
            /*0x18*/ string <PropertyName>k__BackingField;

            /*0x782a640*/ string get_TypeName();
            /*0x782a648*/ string get_PropertyName();
        }

        class BaseNumberConverter : System.ComponentModel.TypeConverter
        {
            /*0x782a650*/ BaseNumberConverter();
            /*0x782a658*/ bool get_AllowHex();
            /*0x380b9e8*/ System.Type get_TargetType();
            /*0x380bc74*/ object FromString(string value, int radix);
            /*0x380bcbc*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x380bcbc*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x782a660*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x782a6ec*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x782aac4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x782ad48*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        }

        class BooleanConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.ComponentModel.TypeConverter.StandardValuesCollection s_values;

            /*0x782b12c*/ BooleanConverter();
            /*0x782ad80*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x782ae0c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x782afa0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x782b11c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x782b124*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x782b2c8*/ ByteConverter();
            /*0x782b134*/ System.Type get_TargetType();
            /*0x782b164*/ object FromString(string value, int radix);
            /*0x782b1ec*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x782b224*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class CharConverter : System.ComponentModel.TypeConverter
        {
            /*0x782b568*/ CharConverter();
            /*0x782b2d0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x782b35c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x782b450*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        enum CollectionChangeAction
        {
            Add = 1,
            Remove = 2,
            Refresh = 3,
        }

        class CollectionChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.ComponentModel.CollectionChangeAction <Action>k__BackingField;
            /*0x18*/ object <Element>k__BackingField;

            /*0x782b570*/ CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element);
            /*0x782b5ec*/ System.ComponentModel.CollectionChangeAction get_Action();
            /*0x782b5f4*/ object get_Element();
        }

        class CollectionChangeEventHandler : System.MulticastDelegate
        {
            /*0x782b5fc*/ CollectionChangeEventHandler(object object, nint method);
            /*0x782b708*/ void Invoke(object sender, System.ComponentModel.CollectionChangeEventArgs e);
        }

        class CultureInfoConverter : System.ComponentModel.TypeConverter
        {
            static string DefaultInvariantCultureString = "(Default)";
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x782c91c*/ CultureInfoConverter();
            /*0x782b71c*/ string get_DefaultCultureString();
            /*0x782b75c*/ string GetCultureName(System.Globalization.CultureInfo culture);
            /*0x782b780*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x782b80c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x782b8bc*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x782c25c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x782c6c4*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x782c90c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x782c914*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class CultureComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.CultureInfoConverter _converter;

                /*0x782c8dc*/ CultureComparer(System.ComponentModel.CultureInfoConverter cultureConverter);
                /*0x782c924*/ int Compare(object item1, object item2);
            }

            class CultureInfoMapper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> s_cultureInfoNameMap;

                static /*0x7830b70*/ CultureInfoMapper();
                static /*0x782ca90*/ System.Collections.Generic.Dictionary<string, string> CreateMap();
                static /*0x782c1bc*/ string GetCultureInfoName(string cultureInfoDisplayName);
            }
        }

        class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
        {
            /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _parent;

            /*0x7830bc8*/ CustomTypeDescriptor();
            /*0x7830bd0*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x7830ca8*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x7830d80*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x7830e5c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x7830f40*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        class DateTimeConverter : System.ComponentModel.TypeConverter
        {
            /*0x7831794*/ DateTimeConverter();
            /*0x7830ff8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7831084*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7831134*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7831430*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class DecimalConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x7831e5c*/ DecimalConverter();
            /*0x783179c*/ bool get_AllowHex();
            /*0x78317a4*/ System.Type get_TargetType();
            /*0x7831804*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x78318b0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7831bdc*/ object FromString(string value, int radix);
            /*0x7831cc8*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7831d74*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class DefaultEventAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultEventAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x7831f24*/ DefaultEventAttribute();
            /*0x7831e64*/ DefaultEventAttribute(string name);
            /*0x7831e94*/ string get_Name();
            /*0x7831e9c*/ bool Equals(object obj);
            /*0x7831f1c*/ int GetHashCode();
        }

        class DefaultPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultPropertyAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x783205c*/ DefaultPropertyAttribute();
            /*0x7831f9c*/ DefaultPropertyAttribute(string name);
            /*0x7831fcc*/ string get_Name();
            /*0x7831fd4*/ bool Equals(object obj);
            /*0x7832054*/ int GetHashCode();
        }

        class DelegatingTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
        {
            /*0x20*/ System.Type _type;

            /*0x78320d4*/ DelegatingTypeDescriptionProvider(System.Type type);
            /*0x783210c*/ System.ComponentModel.TypeDescriptionProvider get_Provider();
            /*0x7832168*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x78321b8*/ System.Collections.IDictionary GetCache(object instance);
            /*0x78321e0*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x7832208*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x7832230*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x7832268*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
        }

        class ToolboxItemAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ToolboxItemAttribute Default;
            static /*0x8*/ System.ComponentModel.ToolboxItemAttribute None;
            /*0x10*/ string _toolboxItemTypeName;

            static /*0x783252c*/ ToolboxItemAttribute();
            /*0x7832308*/ ToolboxItemAttribute(bool defaultType);
            /*0x7832374*/ ToolboxItemAttribute(string toolboxItemTypeName);
            /*0x78322a0*/ bool IsDefaultAttribute();
            /*0x7832408*/ string get_ToolboxItemTypeName();
            /*0x783242c*/ bool Equals(object obj);
            /*0x7832508*/ int GetHashCode();
        }

        class DesignTimeVisibleAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignTimeVisibleAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignTimeVisibleAttribute No;
            static /*0x10*/ System.ComponentModel.DesignTimeVisibleAttribute Default;
            /*0x10*/ bool <Visible>k__BackingField;

            static /*0x78327c4*/ DesignTimeVisibleAttribute();
            /*0x78325f4*/ DesignTimeVisibleAttribute(bool visible);
            /*0x783261c*/ bool get_Visible();
            /*0x7832624*/ bool Equals(object obj);
            /*0x78326bc*/ int GetHashCode();
            /*0x7832744*/ bool IsDefaultAttribute();
        }

        class DoubleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x7832a38*/ DoubleConverter();
            /*0x7832874*/ bool get_AllowHex();
            /*0x783287c*/ System.Type get_TargetType();
            /*0x78328ac*/ object FromString(string value, int radix);
            /*0x7832960*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7832994*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class EditorAttribute : System.Attribute
        {
            /*0x10*/ string _typeId;
            /*0x18*/ string <EditorBaseTypeName>k__BackingField;
            /*0x20*/ string <EditorTypeName>k__BackingField;

            /*0x7832a40*/ EditorAttribute(string typeName, string baseTypeName);
            /*0x7832ae8*/ string get_EditorBaseTypeName();
            /*0x7832af0*/ string get_EditorTypeName();
            /*0x7832af8*/ object get_TypeId();
            /*0x7832b98*/ bool Equals(object obj);
            /*0x7832c3c*/ int GetHashCode();
        }

        class EventDescriptor : System.ComponentModel.MemberDescriptor
        {
        }

        class EventDescriptorCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
        {
            static /*0x0*/ System.ComponentModel.EventDescriptorCollection Empty;
            /*0x10*/ System.ComponentModel.EventDescriptor[] _events;
            /*0x18*/ string[] _namedSort;
            /*0x20*/ System.Collections.IComparer _comparer;
            /*0x28*/ bool _eventsOwned;
            /*0x29*/ bool _needSort;
            /*0x2a*/ bool _readOnly;
            /*0x2c*/ int <Count>k__BackingField;

            static /*0x7833bd4*/ EventDescriptorCollection();
            /*0x7832c44*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events);
            /*0x7832d1c*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly);
            /*0x7832d40*/ int get_Count();
            /*0x7832d48*/ void set_Count(int value);
            /*0x7832d50*/ System.ComponentModel.EventDescriptor get_Item(int index);
            /*0x7832e90*/ int Add(System.ComponentModel.EventDescriptor value);
            /*0x7833088*/ void Clear();
            /*0x78330d4*/ bool Contains(System.ComponentModel.EventDescriptor value);
            /*0x783314c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x7832dd4*/ void EnsureEventsOwned();
            /*0x7832f60*/ void EnsureSize(int sizeNeeded);
            /*0x78330ec*/ int IndexOf(System.ComponentModel.EventDescriptor value);
            /*0x7833408*/ void Insert(int index, System.ComponentModel.EventDescriptor value);
            /*0x78334f8*/ void Remove(System.ComponentModel.EventDescriptor value);
            /*0x7833560*/ void RemoveAt(int index);
            /*0x783361c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7833188*/ void InternalSort(string[] names);
            /*0x78336fc*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x7833774*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x783377c*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x7833784*/ int System.Collections.ICollection.get_Count();
            /*0x783378c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7833790*/ object System.Collections.IList.get_Item(int index);
            /*0x78337a0*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x783390c*/ int System.Collections.IList.Add(object value);
            /*0x7833990*/ bool System.Collections.IList.Contains(object value);
            /*0x7833a20*/ void System.Collections.IList.Clear();
            /*0x7833a24*/ int System.Collections.IList.IndexOf(object value);
            /*0x7833aa8*/ void System.Collections.IList.Insert(int index, object value);
            /*0x7833b3c*/ void System.Collections.IList.Remove(object value);
            /*0x7833bc0*/ void System.Collections.IList.RemoveAt(int index);
            /*0x7833bc4*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x7833bcc*/ bool System.Collections.IList.get_IsFixedSize();

            class ArraySubsetEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Array _array;
                /*0x18*/ int _total;
                /*0x1c*/ int _current;

                /*0x78336bc*/ ArraySubsetEnumerator(System.Array array, int count);
                /*0x7833c44*/ bool MoveNext();
                /*0x7833c68*/ void Reset();
                /*0x7833c74*/ object get_Current();
            }
        }

        class ExpandableObjectConverter : System.ComponentModel.TypeConverter
        {
            /*0x7833cd0*/ ExpandableObjectConverter();
            /*0x7833cd8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x7833d40*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ExtendedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.ComponentModel.ReflectPropertyDescriptor _extenderInfo;
            /*0x90*/ System.ComponentModel.IExtenderProvider _provider;

            /*0x7833d48*/ ExtendedPropertyDescriptor(System.ComponentModel.ReflectPropertyDescriptor extenderInfo, System.Type receiverType, System.ComponentModel.IExtenderProvider provider, System.Attribute[] attributes);
            /*0x7834054*/ bool CanResetValue(object comp);
            /*0x78342fc*/ System.Type get_ComponentType();
            /*0x7834320*/ bool get_IsReadOnly();
            /*0x7834404*/ System.Type get_PropertyType();
            /*0x7834438*/ string get_DisplayName();
            /*0x783480c*/ object GetValue(object comp);
            /*0x783496c*/ void ResetValue(object comp);
            /*0x7834ea0*/ void SetValue(object component, object value);
            /*0x7835340*/ bool ShouldSerializeValue(object comp);
        }

        class ExtenderProvidedPropertyAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.PropertyDescriptor <ExtenderProperty>k__BackingField;
            /*0x18*/ System.ComponentModel.IExtenderProvider <Provider>k__BackingField;
            /*0x20*/ System.Type <ReceiverType>k__BackingField;

            static /*0x7833fb4*/ System.ComponentModel.ExtenderProvidedPropertyAttribute Create(System.ComponentModel.PropertyDescriptor extenderProperty, System.Type receiverType, System.ComponentModel.IExtenderProvider provider);
            /*0x78357a0*/ ExtenderProvidedPropertyAttribute();
            /*0x78357a8*/ System.ComponentModel.PropertyDescriptor get_ExtenderProperty();
            /*0x78357b0*/ void set_ExtenderProperty(System.ComponentModel.PropertyDescriptor value);
            /*0x78357b8*/ System.ComponentModel.IExtenderProvider get_Provider();
            /*0x78357c0*/ void set_Provider(System.ComponentModel.IExtenderProvider value);
            /*0x78357c8*/ System.Type get_ReceiverType();
            /*0x78357d0*/ void set_ReceiverType(System.Type value);
            /*0x78357d8*/ bool Equals(object obj);
            /*0x78358ac*/ int GetHashCode();
            /*0x78358b4*/ bool IsDefaultAttribute();
        }

        class GuidConverter : System.ComponentModel.TypeConverter
        {
            /*0x7835e14*/ GuidConverter();
            /*0x78358ec*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7835978*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7835a28*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7835afc*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        interface IBindingList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
        }

        interface ICustomTypeDescriptor
        {
            /*0x380b9e8*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x380b9e8*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x380b9e8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x380bb68*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x380bb68*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        interface IExtenderProvider
        {
            /*0x380b2f0*/ bool CanExtend(object extendee);
        }

        interface ITypeDescriptorContext : System.IServiceProvider
        {
            /*0x380b9e8*/ System.ComponentModel.IContainer get_Container();
        }

        class Int16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x7835fb0*/ Int16Converter();
            /*0x7835e1c*/ System.Type get_TargetType();
            /*0x7835e4c*/ object FromString(string value, int radix);
            /*0x7835ed4*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7835f0c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x783614c*/ Int32Converter();
            /*0x7835fb8*/ System.Type get_TargetType();
            /*0x7835fe8*/ object FromString(string value, int radix);
            /*0x7836070*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x78360a8*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x78362e8*/ Int64Converter();
            /*0x7836154*/ System.Type get_TargetType();
            /*0x7836184*/ object FromString(string value, int radix);
            /*0x783620c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7836244*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class ListBindableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ListBindableAttribute Yes;
            static /*0x8*/ System.ComponentModel.ListBindableAttribute No;
            static /*0x10*/ System.ComponentModel.ListBindableAttribute Default;
            /*0x10*/ bool _isDefault;
            /*0x11*/ bool <ListBindable>k__BackingField;

            static /*0x7836444*/ ListBindableAttribute();
            /*0x78362f0*/ ListBindableAttribute(bool listBindable);
            /*0x7836318*/ bool get_ListBindable();
            /*0x7836320*/ bool Equals(object obj);
            /*0x78363b8*/ int GetHashCode();
            /*0x78363c0*/ bool IsDefaultAttribute();
        }

        class ListChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.ComponentModel.ListChangedType <ListChangedType>k__BackingField;
            /*0x14*/ int <NewIndex>k__BackingField;
            /*0x18*/ int <OldIndex>k__BackingField;
            /*0x20*/ System.ComponentModel.PropertyDescriptor <PropertyDescriptor>k__BackingField;

            /*0x78364f4*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex);
            /*0x783657c*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x78365b8*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x78364fc*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex);
            /*0x7836634*/ System.ComponentModel.ListChangedType get_ListChangedType();
            /*0x783663c*/ int get_NewIndex();
            /*0x7836644*/ int get_OldIndex();
        }

        class ListChangedEventHandler : System.MulticastDelegate
        {
            /*0x783664c*/ ListChangedEventHandler(object object, nint method);
            /*0x7836758*/ void Invoke(object sender, System.ComponentModel.ListChangedEventArgs e);
        }

        enum ListChangedType
        {
            Reset = 0,
            ItemAdded = 1,
            ItemDeleted = 2,
            ItemMoved = 3,
            ItemChanged = 4,
            PropertyDescriptorAdded = 5,
            PropertyDescriptorDeleted = 6,
            PropertyDescriptorChanged = 7,
        }

        class MarshalByValueComponent : System.ComponentModel.IComponent, System.IDisposable, System.IServiceProvider
        {
            static /*0x0*/ object s_eventDisposed;
            /*0x10*/ System.ComponentModel.ISite _site;
            /*0x18*/ System.ComponentModel.EventHandlerList _events;

            static /*0x7836cf8*/ MarshalByValueComponent();
            /*0x783676c*/ MarshalByValueComponent();
            /*0x7836774*/ void Finalize();
            /*0x7836814*/ System.ComponentModel.ISite get_Site();
            /*0x783681c*/ void Dispose();
            /*0x7836888*/ void Dispose(bool disposing);
            /*0x7836b14*/ object GetService(System.Type service);
            /*0x7836bc8*/ string ToString();
        }

        class MultilineStringConverter : System.ComponentModel.TypeConverter
        {
            /*0x7836ed4*/ MultilineStringConverter();
            /*0x7836d74*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7836ec4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x7836ecc*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class NullableConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type <NullableType>k__BackingField;
            /*0x18*/ System.Type <UnderlyingType>k__BackingField;
            /*0x20*/ System.ComponentModel.TypeConverter <UnderlyingTypeConverter>k__BackingField;

            /*0x7836edc*/ NullableConverter(System.Type type);
            /*0x7837014*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x78370b8*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x78371c0*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7837264*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7837410*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x7837434*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7837458*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x783747c*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x78374a0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x783786c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7837894*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x78378bc*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x78378f0*/ System.Type get_NullableType();
            /*0x78378f8*/ System.Type get_UnderlyingType();
            /*0x7837900*/ System.ComponentModel.TypeConverter get_UnderlyingTypeConverter();
        }

        class PropertyDescriptor : System.ComponentModel.MemberDescriptor
        {
            /*0x60*/ System.ComponentModel.TypeConverter _converter;
            /*0x68*/ System.Collections.Hashtable _valueChangedHandlers;
            /*0x70*/ object[] _editors;
            /*0x78*/ System.Type[] _editorTypes;
            /*0x80*/ int _editorCount;

            /*0x7837908*/ PropertyDescriptor(string name, System.Attribute[] attrs);
            /*0x7833fb0*/ PropertyDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs);
            /*0x380b9e8*/ System.Type get_ComponentType();
            /*0x7837f5c*/ System.ComponentModel.TypeConverter get_Converter();
            /*0x380b128*/ bool get_IsReadOnly();
            /*0x380b9e8*/ System.Type get_PropertyType();
            /*0x380b2f0*/ bool CanResetValue(object component);
            /*0x78385ac*/ bool Equals(object obj);
            /*0x78383b4*/ object CreateInstance(System.Type type);
            /*0x78387a0*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x78388e8*/ int GetHashCode();
            /*0x783893c*/ object GetInvocationTarget(System.Type type, object instance);
            /*0x78381c4*/ System.Type GetTypeFromName(string typeName);
            /*0x380bb68*/ object GetValue(object component);
            /*0x7838b14*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x380d83c*/ void ResetValue(object component);
            /*0x380d93c*/ void SetValue(object component, object value);
            /*0x380b2f0*/ bool ShouldSerializeValue(object component);
        }

        class PropertyDescriptorCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.IDictionary
        {
            static /*0x0*/ System.ComponentModel.PropertyDescriptorCollection Empty;
            /*0x10*/ System.Collections.IDictionary _cachedFoundProperties;
            /*0x18*/ bool _cachedIgnoreCase;
            /*0x20*/ System.ComponentModel.PropertyDescriptor[] _properties;
            /*0x28*/ string[] _namedSort;
            /*0x30*/ System.Collections.IComparer _comparer;
            /*0x38*/ bool _propsOwned;
            /*0x39*/ bool _needSort;
            /*0x3a*/ bool _readOnly;
            /*0x40*/ object _internalSyncObject;
            /*0x48*/ int <Count>k__BackingField;

            static /*0x783a9f0*/ PropertyDescriptorCollection();
            /*0x78295f0*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties);
            /*0x7838bc4*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly);
            /*0x7838be8*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, int propCount, string[] namedSort, System.Collections.IComparer comparer);
            /*0x7838d34*/ int get_Count();
            /*0x7838d3c*/ void set_Count(int value);
            /*0x7838d44*/ System.ComponentModel.PropertyDescriptor get_Item(int index);
            /*0x7838e84*/ System.ComponentModel.PropertyDescriptor get_Item(string name);
            /*0x7838e98*/ int Add(System.ComponentModel.PropertyDescriptor value);
            /*0x7839090*/ void Clear();
            /*0x78390e4*/ bool Contains(System.ComponentModel.PropertyDescriptor value);
            /*0x783915c*/ void CopyTo(System.Array array, int index);
            /*0x7838dc8*/ void EnsurePropsOwned();
            /*0x7838f68*/ void EnsureSize(int sizeNeeded);
            /*0x7839418*/ System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase);
            /*0x78390fc*/ int IndexOf(System.ComponentModel.PropertyDescriptor value);
            /*0x7839948*/ void Insert(int index, System.ComponentModel.PropertyDescriptor value);
            /*0x7839a38*/ void Remove(System.ComponentModel.PropertyDescriptor value);
            /*0x7839aa0*/ void RemoveAt(int index);
            /*0x7839b5c*/ System.ComponentModel.PropertyDescriptorCollection Sort(string[] names);
            /*0x7839198*/ void InternalSort(string[] names);
            /*0x7839bd8*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x7839c50*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7839cec*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x7839cf4*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x7839cfc*/ int System.Collections.ICollection.get_Count();
            /*0x7839d04*/ void System.Collections.IList.Clear();
            /*0x7839d08*/ void System.Collections.IDictionary.Clear();
            /*0x7839d0c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7839d1c*/ void System.Collections.IList.RemoveAt(int index);
            /*0x7839d20*/ void System.Collections.IDictionary.Add(object key, object value);
            /*0x7839de4*/ bool System.Collections.IDictionary.Contains(object key);
            /*0x7839e2c*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
            /*0x7839ed4*/ bool System.Collections.IDictionary.get_IsFixedSize();
            /*0x7839edc*/ bool System.Collections.IDictionary.get_IsReadOnly();
            /*0x7839ee4*/ object System.Collections.IDictionary.get_Item(object key);
            /*0x7839f18*/ void System.Collections.IDictionary.set_Item(object key, object value);
            /*0x783a2b0*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
            /*0x783a390*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
            /*0x783a468*/ void System.Collections.IDictionary.Remove(object key);
            /*0x783a550*/ int System.Collections.IList.Add(object value);
            /*0x783a5d4*/ bool System.Collections.IList.Contains(object value);
            /*0x783a664*/ int System.Collections.IList.IndexOf(object value);
            /*0x783a6e8*/ void System.Collections.IList.Insert(int index, object value);
            /*0x783a77c*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x783a784*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x783a78c*/ void System.Collections.IList.Remove(object value);
            /*0x783a810*/ object System.Collections.IList.get_Item(int index);
            /*0x783a820*/ void System.Collections.IList.set_Item(int index, object value);

            class PropertyDescriptorEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
            {
                /*0x10*/ System.ComponentModel.PropertyDescriptorCollection _owner;
                /*0x18*/ int _index;

                /*0x7839e9c*/ PropertyDescriptorEnumerator(System.ComponentModel.PropertyDescriptorCollection owner);
                /*0x783aa60*/ object get_Current();
                /*0x783aac4*/ System.Collections.DictionaryEntry get_Entry();
                /*0x783ab2c*/ object get_Key();
                /*0x783ab68*/ object get_Value();
                /*0x783aba4*/ bool MoveNext();
                /*0x783abe0*/ void Reset();
            }
        }

        class ProvidePropertyAttribute : System.Attribute
        {
            /*0x10*/ string <PropertyName>k__BackingField;
            /*0x18*/ string <ReceiverTypeName>k__BackingField;

            /*0x783abec*/ string get_PropertyName();
            /*0x783abf4*/ string get_ReceiverTypeName();
        }

        class ReferenceConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ string s_none;
            /*0x10*/ System.Type _type;

            static /*0x783bc48*/ ReferenceConverter();
            /*0x783abfc*/ ReferenceConverter(System.Type type);
            /*0x783ac2c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x783acbc*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x783afe4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x783b404*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x783bc30*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x783bc38*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x783bc40*/ bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value);

            class ReferenceComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.ReferenceConverter _converter;

                /*0x783bc00*/ ReferenceComparer(System.ComponentModel.ReferenceConverter converter);
                /*0x783bcb4*/ int Compare(object item1, object item2);
            }
        }

        class RefreshEventArgs : System.EventArgs
        {
            /*0x10*/ System.Type <TypeChanged>k__BackingField;

            /*0x783bd6c*/ RefreshEventArgs(System.Type typeChanged);
        }

        class RefreshEventHandler : System.MulticastDelegate
        {
            /*0x783bde0*/ RefreshEventHandler(object object, nint method);
            /*0x783bee8*/ void Invoke(System.ComponentModel.RefreshEventArgs e);
        }

        class SByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x783c090*/ SByteConverter();
            /*0x783befc*/ System.Type get_TargetType();
            /*0x783bf2c*/ object FromString(string value, int radix);
            /*0x783bfb4*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x783bfec*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class SingleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x783c25c*/ SingleConverter();
            /*0x783c098*/ bool get_AllowHex();
            /*0x783c0a0*/ System.Type get_TargetType();
            /*0x783c0d0*/ object FromString(string value, int radix);
            /*0x783c184*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x783c1b8*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class StringConverter : System.ComponentModel.TypeConverter
        {
            /*0x783c324*/ StringConverter();
            /*0x783c264*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x783c2f0*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        class TimeSpanConverter : System.ComponentModel.TypeConverter
        {
            /*0x783c94c*/ TimeSpanConverter();
            /*0x783c32c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x783c3b8*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x783c468*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x783c648*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class TypeConverterAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.TypeConverterAttribute Default;
            /*0x10*/ string <ConverterTypeName>k__BackingField;

            static /*0x783caac*/ TypeConverterAttribute();
            /*0x783c954*/ TypeConverterAttribute();
            /*0x783c988*/ TypeConverterAttribute(System.Type type);
            /*0x783c9d4*/ TypeConverterAttribute(string typeName);
            /*0x783ca04*/ string get_ConverterTypeName();
            /*0x783ca0c*/ bool Equals(object obj);
            /*0x783ca8c*/ int GetHashCode();
        }

        class TypeDescriptionProvider
        {
            /*0x10*/ System.ComponentModel.TypeDescriptionProvider _parent;
            /*0x18*/ System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

            /*0x7832104*/ TypeDescriptionProvider();
            /*0x783cb34*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x783cbf4*/ System.Collections.IDictionary GetCache(object instance);
            /*0x783cc0c*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x783cca8*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x783cda8*/ System.Type GetReflectionType(System.Type objectType);
            /*0x783cdb8*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x783cdd4*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType);
            /*0x783cde4*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance);
            /*0x783ce6c*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

            class EmptyCustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor
            {
                /*0x783cca0*/ EmptyCustomTypeDescriptor();
            }
        }

        class TypeDescriptionProviderAttribute : System.Attribute
        {
            /*0x10*/ string <TypeName>k__BackingField;

            /*0x783cf14*/ TypeDescriptionProviderAttribute(string typeName);
            /*0x783cf90*/ string get_TypeName();
        }

        class TypeListConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type[] _types;
            /*0x18*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x783cf98*/ TypeListConverter(System.Type[] types);
            /*0x783cfc8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x783d054*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x783d104*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x783d1f4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x783d388*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x783d454*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x783d45c*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class UInt16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x783d5f8*/ UInt16Converter();
            /*0x783d464*/ System.Type get_TargetType();
            /*0x783d494*/ object FromString(string value, int radix);
            /*0x783d51c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x783d554*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x783d794*/ UInt32Converter();
            /*0x783d600*/ System.Type get_TargetType();
            /*0x783d630*/ object FromString(string value, int radix);
            /*0x783d6b8*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x783d6f0*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x783d930*/ UInt64Converter();
            /*0x783d79c*/ System.Type get_TargetType();
            /*0x783d7cc*/ object FromString(string value, int radix);
            /*0x783d854*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x783d88c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        interface IChangeTracking
        {
            /*0x380b128*/ bool get_IsChanged();
            /*0x380cb08*/ void AcceptChanges();
        }

        interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking
        {
            /*0x380cb08*/ void RejectChanges();
        }

        interface INotifyPropertyChanged
        {
            /*0x380d83c*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x380d83c*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
        }

        class PropertyChangedEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x783d938*/ PropertyChangedEventArgs(string propertyName);
        }

        class PropertyChangedEventHandler : System.MulticastDelegate
        {
            /*0x783d9ac*/ PropertyChangedEventHandler(object object, nint method);
            /*0x783dab8*/ void Invoke(object sender, System.ComponentModel.PropertyChangedEventArgs e);
        }

        class PropertyChangingEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x783dacc*/ PropertyChangingEventArgs(string propertyName);
        }

        class PropertyChangingEventHandler : System.MulticastDelegate
        {
            /*0x783db40*/ PropertyChangingEventHandler(object object, nint method);
            /*0x783dc4c*/ void Invoke(object sender, System.ComponentModel.PropertyChangingEventArgs e);
        }

        class CategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.CategoryAttribute defAttr;
            /*0x10*/ bool localized;
            /*0x18*/ string categoryValue;

            static /*0x783dc60*/ System.ComponentModel.CategoryAttribute get_Default();
            /*0x783dcf4*/ CategoryAttribute();
            /*0x783dd58*/ CategoryAttribute(string category);
            /*0x783dd90*/ string get_Category();
            /*0x783dde8*/ bool Equals(object obj);
            /*0x783ded8*/ int GetHashCode();
            /*0x783def8*/ string GetLocalizedString(string value);
            /*0x783e274*/ bool IsDefaultAttribute();
        }

        class CollectionConverter : System.ComponentModel.TypeConverter
        {
            /*0x7829718*/ CollectionConverter();
            /*0x78291f4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x783e2a8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x783e2b0*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class Component : System.MarshalByRefObject, System.ComponentModel.IComponent, System.IDisposable
        {
            static /*0x0*/ object EventDisposed;
            /*0x18*/ System.ComponentModel.ISite site;
            /*0x20*/ System.ComponentModel.EventHandlerList events;

            static /*0x783e970*/ Component();
            /*0x783e968*/ Component();
            /*0x783e2b8*/ void Finalize();
            /*0x783e358*/ bool get_CanRaiseEvents();
            /*0x7828ce8*/ bool get_CanRaiseEventsInternal();
            /*0x783e360*/ System.ComponentModel.ISite get_Site();
            /*0x783e368*/ void Dispose();
            /*0x783e3d4*/ void Dispose(bool disposing);
            /*0x783e6d4*/ object GetService(System.Type service);
            /*0x783e788*/ bool get_DesignMode();
            /*0x783e838*/ string ToString();
        }

        class ComponentConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x783e9ec*/ ComponentConverter(System.Type type);
            /*0x783ea60*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x783eac8*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DateTimeOffsetConverter : System.ComponentModel.TypeConverter
        {
            /*0x783fb54*/ DateTimeOffsetConverter();
            /*0x783ead0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x783eb5c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x783ec0c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x783ef6c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class EnumConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;
            /*0x18*/ System.Type type;

            /*0x783fb5c*/ EnumConverter(System.Type type);
            /*0x783fb8c*/ System.Type get_EnumType();
            /*0x783fb94*/ System.ComponentModel.TypeConverter.StandardValuesCollection get_Values();
            /*0x783fb9c*/ void set_Values(System.ComponentModel.TypeConverter.StandardValuesCollection value);
            /*0x783fba4*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x783fc8c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x783fd84*/ System.Collections.IComparer get_Comparer();
            /*0x783fddc*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x78402b0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x784104c*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7841420*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x78414b4*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x78414bc*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
        }

        interface IComponent : System.IDisposable
        {
            /*0x380b9e8*/ System.ComponentModel.ISite get_Site();
        }

        class MemberDescriptor
        {
            /*0x10*/ string name;
            /*0x18*/ string displayName;
            /*0x20*/ int nameHash;
            /*0x28*/ System.ComponentModel.AttributeCollection attributeCollection;
            /*0x30*/ System.Attribute[] attributes;
            /*0x38*/ System.Attribute[] originalAttributes;
            /*0x40*/ bool attributesFiltered;
            /*0x41*/ bool attributesFilled;
            /*0x44*/ int metadataVersion;
            /*0x48*/ string category;
            /*0x50*/ string description;
            /*0x58*/ object lockCookie;

            static /*0x7842280*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType);
            static /*0x7842288*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly);
            static /*0x7834710*/ System.ComponentModel.ISite GetSite(object component);
            /*0x783790c*/ MemberDescriptor(string name, System.Attribute[] attributes);
            /*0x7837ae4*/ MemberDescriptor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes);
            /*0x7841500*/ System.Attribute[] get_AttributeArray();
            /*0x7841d58*/ void set_AttributeArray(System.Attribute[] value);
            /*0x7841e50*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x7841f50*/ string get_Name();
            /*0x7841fa0*/ int get_NameHashCode();
            /*0x7834600*/ string get_DisplayName();
            /*0x7841520*/ void CheckAttributesValid();
            /*0x7841fa8*/ System.ComponentModel.AttributeCollection CreateAttributeCollection();
            /*0x7842018*/ bool Equals(object obj);
            /*0x78387f4*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x78415e8*/ void FilterAttributesIfNeeded();
            /*0x784232c*/ int GetHashCode();
            /*0x7838a1c*/ object GetInvocationTarget(System.Type type, object instance);
        }

        class ReflectPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            static /*0x0*/ System.Type[] argsNone;
            static /*0x8*/ object noValue;
            static /*0x10*/ System.Diagnostics.TraceSwitch PropDescCreateSwitch;
            static /*0x18*/ System.Diagnostics.TraceSwitch PropDescUsageSwitch;
            static /*0x20*/ int BitDefaultValueQueried;
            static /*0x24*/ int BitGetQueried;
            static /*0x28*/ int BitSetQueried;
            static /*0x2c*/ int BitShouldSerializeQueried;
            static /*0x30*/ int BitResetQueried;
            static /*0x34*/ int BitChangedQueried;
            static /*0x38*/ int BitIPropChangedQueried;
            static /*0x3c*/ int BitReadOnlyChecked;
            static /*0x40*/ int BitAmbientValueQueried;
            static /*0x44*/ int BitSetOnDemand;
            /*0x84*/ System.Collections.Specialized.BitVector32 state;
            /*0x88*/ System.Type componentClass;
            /*0x90*/ System.Type type;
            /*0x98*/ object defaultValue;
            /*0xa0*/ object ambientValue;
            /*0xa8*/ System.Reflection.PropertyInfo propInfo;
            /*0xb0*/ System.Reflection.MethodInfo getMethod;
            /*0xb8*/ System.Reflection.MethodInfo setMethod;
            /*0xc0*/ System.Reflection.MethodInfo shouldSerializeMethod;
            /*0xc8*/ System.Reflection.MethodInfo resetMethod;
            /*0xd0*/ System.ComponentModel.EventDescriptor realChangedEvent;
            /*0xd8*/ System.Type receiverType;

            static /*0x78459ec*/ ReflectPropertyDescriptor();
            /*0x7842334*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Attribute[] attributes);
            /*0x7842614*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Reflection.PropertyInfo propInfo, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x784275c*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Type receiverType, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x784284c*/ object get_AmbientValue();
            /*0x78429c0*/ System.Type get_ComponentType();
            /*0x78429c8*/ object get_DefaultValue();
            /*0x7842c5c*/ System.Reflection.MethodInfo get_GetMethodValue();
            /*0x78430c0*/ bool get_IsExtender();
            /*0x78430f8*/ bool get_IsReadOnly();
            /*0x7843724*/ System.Type get_PropertyType();
            /*0x784372c*/ System.Reflection.MethodInfo get_ResetMethodValue();
            /*0x78431ec*/ System.Reflection.MethodInfo get_SetMethodValue();
            /*0x7843920*/ System.Reflection.MethodInfo get_ShouldSerializeMethodValue();
            /*0x7834078*/ bool ExtenderCanResetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x7843b14*/ System.Type ExtenderGetReceiverType();
            /*0x7834428*/ System.Type ExtenderGetType(System.ComponentModel.IExtenderProvider provider);
            /*0x7834830*/ object ExtenderGetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x7834990*/ void ExtenderResetValue(System.ComponentModel.IExtenderProvider provider, object component, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x7834ec8*/ void ExtenderSetValue(System.ComponentModel.IExtenderProvider provider, object component, object value, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x7835364*/ bool ExtenderShouldSerializeValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x7843b1c*/ bool CanResetValue(object component);
            /*0x7843d84*/ void FillAttributes(System.Collections.IList attributes);
            /*0x7844834*/ object GetValue(object component);
            /*0x7844bf4*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x7844c98*/ void ResetValue(object component);
            /*0x78450f0*/ void SetValue(object component, object value);
            /*0x78456cc*/ bool ShouldSerializeValue(object component);
        }

        class ReflectTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
        {
            static /*0x0*/ System.Type[] _typeConstructor;
            static /*0x8*/ System.Collections.Hashtable _intrinsicTypeConverters;
            static /*0x10*/ object _intrinsicReferenceKey;
            static /*0x18*/ object _intrinsicNullableKey;
            static /*0x20*/ object _dictionaryKey;
            static /*0x28*/ System.Collections.Hashtable _propertyCache;
            static /*0x30*/ System.Collections.Hashtable _attributeCache;
            static /*0x38*/ System.Collections.Hashtable _extendedPropertyCache;
            static /*0x40*/ System.Guid _extenderProviderKey;
            static /*0x50*/ System.Guid _extenderPropertiesKey;
            static /*0x60*/ System.Guid _extenderProviderPropertiesKey;
            static /*0x70*/ System.Type[] _skipInterfaceAttributeList;
            static /*0x78*/ object _internalSyncObject;
            /*0x20*/ System.Collections.Hashtable _typeData;

            static /*0x784c3a8*/ ReflectTypeDescriptionProvider();
            static /*0x7845c4c*/ System.Collections.Hashtable get_IntrinsicTypeConverters();
            static /*0x78467fc*/ object CreateInstance(System.Type objectType, System.Type callingType);
            static /*0x7849338*/ System.ComponentModel.IExtenderProvider[] GetExtenders(System.Collections.ICollection components, object instance, System.Collections.IDictionary cache);
            static /*0x784a8c8*/ System.Type GetTypeFromName(string typeName);
            static /*0x784aa18*/ System.Attribute[] ReflectGetAttributes(System.Type type);
            static /*0x784ae50*/ System.Attribute[] ReflectGetAttributes(System.Reflection.MemberInfo member);
            static /*0x7847f64*/ System.ComponentModel.PropertyDescriptor[] ReflectGetExtendedProperties(System.ComponentModel.IExtenderProvider provider);
            static /*0x784b3d4*/ System.ComponentModel.PropertyDescriptor[] ReflectGetProperties(System.Type type);
            static /*0x784ba90*/ object SearchIntrinsicTable(System.Collections.Hashtable table, System.Type callingType);
            /*0x7845c44*/ ReflectTypeDescriptionProvider();
            /*0x7846618*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x7846904*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type type);
            /*0x78470d8*/ System.Collections.IDictionary GetCache(object instance);
            /*0x7847430*/ System.ComponentModel.TypeConverter GetConverter(System.Type type, object instance);
            /*0x7847924*/ System.ComponentModel.AttributeCollection GetExtendedAttributes(object instance);
            /*0x784797c*/ System.ComponentModel.TypeConverter GetExtendedConverter(object instance);
            /*0x78479b8*/ System.ComponentModel.PropertyDescriptorCollection GetExtendedProperties(object instance);
            /*0x7848ebc*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x7849e54*/ object GetExtendedPropertyOwner(object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x7849ee4*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x7849eec*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type type);
            /*0x7849e80*/ object GetPropertyOwner(System.Type type, object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x784a888*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x7846920*/ System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(System.Type type, bool createIfNeeded);
            /*0x784a8c0*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
            /*0x784a9cc*/ bool IsPopulated(System.Type type);
            /*0x784ba00*/ void Refresh(System.Type type);

            class ReflectedTypeData
            {
                /*0x10*/ System.Type _type;
                /*0x18*/ System.ComponentModel.AttributeCollection _attributes;
                /*0x20*/ System.ComponentModel.EventDescriptorCollection _events;
                /*0x28*/ System.ComponentModel.PropertyDescriptorCollection _properties;
                /*0x30*/ System.ComponentModel.TypeConverter _converter;
                /*0x38*/ object[] _editors;
                /*0x40*/ System.Type[] _editorTypes;
                /*0x48*/ int _editorCount;

                /*0x784a890*/ ReflectedTypeData(System.Type type);
                /*0x784a9fc*/ bool get_IsPopulated();
                /*0x7846ba8*/ System.ComponentModel.AttributeCollection GetAttributes();
                /*0x7847454*/ System.ComponentModel.TypeConverter GetConverter(object instance);
                /*0x7849f08*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
                /*0x784c998*/ System.Type GetTypeFromName(string typeName);
                /*0x784ba20*/ void Refresh();
            }
        }

        class TypeConverter
        {
            static string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
            static /*0x0*/ bool useCompatibleTypeConversion;

            static /*0x784cb38*/ bool get_UseCompatibleTypeConversion();
            /*0x784dd8c*/ TypeConverter();
            /*0x784cb88*/ bool CanConvertFrom(System.Type sourceType);
            /*0x784cb9c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x784cc10*/ bool CanConvertTo(System.Type destinationType);
            /*0x784cc24*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x784cc70*/ object ConvertFrom(object value);
            /*0x784ccec*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x784d1f0*/ object ConvertFromInvariantString(string text);
            /*0x784d278*/ object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x784d2f8*/ object ConvertFromString(string text);
            /*0x784d310*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x784d26c*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text);
            /*0x784d390*/ object ConvertTo(object value, System.Type destinationType);
            /*0x784d3ac*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x784d728*/ string ConvertToInvariantString(object value);
            /*0x784d834*/ string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x784d8ac*/ string ConvertToString(object value);
            /*0x784d978*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x784d79c*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x784da50*/ object CreateInstance(System.Collections.IDictionary propertyValues);
            /*0x784da64*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x784d0c4*/ System.Exception GetConvertFromException(object value);
            /*0x784d5b0*/ System.Exception GetConvertToException(object value, System.Type destinationType);
            /*0x784da6c*/ bool GetCreateInstanceSupported();
            /*0x784da7c*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784da84*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object value);
            /*0x784da90*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x784db8c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x784db94*/ bool GetPropertiesSupported();
            /*0x784dba4*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784dbac*/ System.Collections.ICollection GetStandardValues();
            /*0x784dbbc*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784dbc4*/ bool GetStandardValuesExclusive();
            /*0x784dbd8*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784dbe0*/ bool GetStandardValuesSupported();
            /*0x784dbf4*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784dbfc*/ bool IsValid(object value);
            /*0x784dc14*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x784dd54*/ System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, string[] names);

            class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x88*/ System.Type componentType;
                /*0x90*/ System.Type propertyType;

                /*0x784dd94*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType);
                /*0x784de10*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes);
                /*0x784de5c*/ System.Type get_ComponentType();
                /*0x784de64*/ bool get_IsReadOnly();
                /*0x784dee8*/ System.Type get_PropertyType();
                /*0x784def0*/ bool CanResetValue(object component);
                /*0x784e028*/ void ResetValue(object component);
                /*0x784e148*/ bool ShouldSerializeValue(object component);
            }

            class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ICollection values;
                /*0x18*/ System.Array valueArray;

                /*0x784e150*/ StandardValuesCollection(System.Collections.ICollection values);
                /*0x784e208*/ int get_Count();
                /*0x784e2c4*/ object get_Item(int index);
                /*0x784e4c4*/ void CopyTo(System.Array array, int index);
                /*0x784e57c*/ System.Collections.IEnumerator GetEnumerator();
                /*0x784e61c*/ int System.Collections.ICollection.get_Count();
                /*0x784e620*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x784e628*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x784e630*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x784e634*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TypeDescriptor
        {
            static /*0x0*/ System.ComponentModel.WeakHashtable _providerTable;
            static /*0x8*/ System.Collections.Hashtable _providerTypeTable;
            static /*0x10*/ System.Collections.Hashtable _defaultProviders;
            static /*0x18*/ System.ComponentModel.WeakHashtable _associationTable;
            static /*0x20*/ int _metadataVersion;
            static /*0x24*/ int _collisionIndex;
            static /*0x28*/ System.Diagnostics.BooleanSwitch TraceDescriptor;
            static /*0x30*/ System.Guid[] _pipelineInitializeKeys;
            static /*0x38*/ System.Guid[] _pipelineMergeKeys;
            static /*0x40*/ System.Guid[] _pipelineFilterKeys;
            static /*0x48*/ System.Guid[] _pipelineAttributeFilterKeys;
            static /*0x50*/ object _internalSyncObject;
            static /*0x58*/ System.ComponentModel.RefreshEventHandler Refreshed;

            static /*0x785543c*/ TypeDescriptor();
            static /*0x784e638*/ System.Type get_ComObjectType();
            static /*0x784e698*/ System.Type get_InterfaceType();
            static /*0x784e6f8*/ int get_MetadataVersion();
            static /*0x784e750*/ void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type);
            static /*0x784f4c0*/ void CheckDefaultProvider(System.Type type);
            static /*0x784fac4*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            static /*0x784fdcc*/ System.Collections.ArrayList FilterMembers(System.Collections.IList members, System.Attribute[] attributes);
            static /*0x784a1f8*/ object GetAssociation(System.Type type, object primary);
            static /*0x784b288*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType);
            static /*0x784c940*/ System.ComponentModel.AttributeCollection GetAttributes(object component);
            static /*0x7850284*/ System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc);
            static /*0x7847ef8*/ System.Collections.IDictionary GetCache(object instance);
            static /*0x7853a84*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x78501b4*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Type type, string typeName);
            static /*0x7850698*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc);
            static /*0x78508a0*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedDescriptor(object component);
            static /*0x7853bb0*/ string GetExtenderCollisionSuffix(System.ComponentModel.MemberDescriptor member);
            static /*0x7853eb4*/ System.Type GetNodeForBaseType(System.Type searchType);
            static /*0x7853f7c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component);
            static /*0x7853fd4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc);
            static /*0x7854698*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
            static /*0x7854700*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc);
            static /*0x7854040*/ System.ComponentModel.PropertyDescriptorCollection GetPropertiesImpl(object component, System.Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes);
            static /*0x7854dc8*/ System.ComponentModel.TypeDescriptionProvider GetProviderRecursive(System.Type type);
            static /*0x7854e20*/ System.Type GetReflectionType(System.Type type);
            static /*0x784fd74*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type);
            static /*0x784e9d4*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type, bool createDelegator);
            static /*0x7853a2c*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance);
            static /*0x7854efc*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator);
            static /*0x7854770*/ System.Collections.ICollection PipelineAttributeFilter(int pipelineType, System.Collections.ICollection members, System.Attribute[] filter, object instance, System.Collections.IDictionary cache);
            static /*0x7851a9c*/ System.Collections.ICollection PipelineFilter(int pipelineType, System.Collections.ICollection members, object instance, System.Collections.IDictionary cache);
            static /*0x7853318*/ System.Collections.ICollection PipelineInitialize(int pipelineType, System.Collections.ICollection members, System.Collections.IDictionary cache);
            static /*0x7850958*/ System.Collections.ICollection PipelineMerge(int pipelineType, System.Collections.ICollection primary, System.Collections.ICollection secondary, object instance, System.Collections.IDictionary cache);
            static /*0x78552bc*/ void RaiseRefresh(System.Type type);
            static /*0x784eeec*/ void Refresh(System.Type type);
            static /*0x7850124*/ bool ShouldHideMember(System.ComponentModel.MemberDescriptor member, System.Attribute attribute);
            static /*0x7855368*/ void SortDescriptorArray(System.Collections.IList infos);

            class AttributeFilterCacheItem
            {
                /*0x10*/ System.Attribute[] _filter;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x78550f8*/ AttributeFilterCacheItem(System.Attribute[] filter, System.Collections.ICollection filteredMembers);
                /*0x785506c*/ bool IsValid(System.Attribute[] filter);
            }

            class FilterCacheItem
            {
                /*0x10*/ System.ComponentModel.Design.ITypeDescriptorFilterService _filterService;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x7855278*/ FilterCacheItem(System.ComponentModel.Design.ITypeDescriptorFilterService filterService, System.Collections.ICollection filteredMembers);
                /*0x785513c*/ bool IsValid(System.ComponentModel.Design.ITypeDescriptorFilterService filterService);
            }

            interface IUnimplemented
            {
            }

            class MemberDescriptorComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.ComponentModel.TypeDescriptor.MemberDescriptorComparer Instance;

                static /*0x7855930*/ MemberDescriptorComparer();
                /*0x7855928*/ MemberDescriptorComparer();
                /*0x785580c*/ int Compare(object left, object right);
            }

            class MergedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _primary;
                /*0x18*/ System.ComponentModel.ICustomTypeDescriptor _secondary;

                /*0x7853b6c*/ MergedTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor primary, System.ComponentModel.ICustomTypeDescriptor secondary);
                /*0x7855998*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x7855aa8*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x7855bc0*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x7855cd8*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x7855e08*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
            }

            class TypeDescriptionNode : System.ComponentModel.TypeDescriptionProvider
            {
                /*0x20*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode Next;
                /*0x28*/ System.ComponentModel.TypeDescriptionProvider Provider;

                /*0x784eebc*/ TypeDescriptionNode(System.ComponentModel.TypeDescriptionProvider provider);
                /*0x7855f38*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
                /*0x785608c*/ System.Collections.IDictionary GetCache(object instance);
                /*0x78560f8*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
                /*0x7856204*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
                /*0x7856270*/ System.Type GetReflectionType(System.Type objectType, object instance);
                /*0x7856324*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

                struct DefaultExtendedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ object _instance;

                    /*0x78561d4*/ DefaultExtendedTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, object instance);
                    /*0x78564c8*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x785679c*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x7856a3c*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x7856cdc*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x7856f84*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                }

                struct DefaultTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ System.Type _objectType;
                    /*0x20*/ object _instance;

                    /*0x7856484*/ DefaultTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Type objectType, object instance);
                    /*0x78571a4*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x7857440*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x78576e0*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x7857980*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x7857c28*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                }
            }

            class TypeDescriptorComObject
            {
            }

            class TypeDescriptorInterface
            {
            }
        }

        class Win32Exception : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable
        {
            /*0x8c*/ int nativeErrorCode;

            static /*0x7857ef0*/ string GetErrorMessage(int error);
            /*0x7857e44*/ Win32Exception();
            /*0x7857eb8*/ Win32Exception(int error);
            /*0x78587d8*/ Win32Exception(int error, string message);
            /*0x7858804*/ Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x785888c*/ int get_NativeErrorCode();
            /*0x7858894*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        enum RefreshProperties
        {
            None = 0,
            All = 1,
            Repaint = 2,
        }

        class RefreshPropertiesAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.RefreshPropertiesAttribute All;
            static /*0x8*/ System.ComponentModel.RefreshPropertiesAttribute Repaint;
            static /*0x10*/ System.ComponentModel.RefreshPropertiesAttribute Default;
            /*0x10*/ System.ComponentModel.RefreshProperties refresh;

            static /*0x7858a6c*/ RefreshPropertiesAttribute();
            /*0x785895c*/ RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh);
            /*0x7858984*/ System.ComponentModel.RefreshProperties get_RefreshProperties();
            /*0x785898c*/ bool Equals(object value);
            /*0x78589fc*/ int GetHashCode();
            /*0x7858a04*/ bool IsDefaultAttribute();
        }

        class WeakHashtable : System.Collections.Hashtable
        {
            static /*0x0*/ System.Collections.IEqualityComparer _comparer;

            static /*0x7858b48*/ WeakHashtable();
            /*0x78557a8*/ WeakHashtable();
            /*0x7858b38*/ void Clear();
            /*0x7858b40*/ void Remove(object key);

            class WeakKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x7858bc4*/ WeakKeyComparer();
                /*0x7858bcc*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
                /*0x7858d28*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
            }
        }

        namespace Design
        {
            class CheckoutException : System.Runtime.InteropServices.ExternalException
            {
                static /*0x0*/ System.ComponentModel.Design.CheckoutException Canceled;

                static /*0x7858d64*/ CheckoutException();
                /*0x7858d4c*/ CheckoutException();
                /*0x7858d54*/ CheckoutException(string message, int errorCode);
                /*0x7858d5c*/ CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            interface IComponentChangeService
            {
                /*0x380da84*/ void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
                /*0x380d93c*/ void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
            }

            interface IDesigner : System.IDisposable
            {
            }

            interface IDesignerHost : System.IServiceProvider
            {
                /*0x380b9e8*/ System.ComponentModel.IComponent get_RootComponent();
                /*0x380bb68*/ System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
            }

            interface IDictionaryService
            {
                /*0x380bb68*/ object GetValue(object key);
                /*0x380d93c*/ void SetValue(object key, object value);
            }

            interface IExtenderListService
            {
                /*0x380b9e8*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
            }

            interface IReferenceService
            {
                /*0x380bb68*/ object GetReference(string name);
                /*0x380bb68*/ string GetName(object reference);
                /*0x380bb68*/ object[] GetReferences(System.Type baseType);
            }

            interface ITypeDescriptorFilterService
            {
                /*0x380b32c*/ bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
                /*0x380b32c*/ bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
                /*0x380b32c*/ bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
            }

            class DesignerOptionService
            {
                /*0x7858dec*/ void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options);

                class DesignerOptionCollection : System.Collections.ICollection
                {
                    /*0x10*/ System.ComponentModel.Design.DesignerOptionService _service;
                    /*0x18*/ string _name;
                    /*0x20*/ object _value;
                    /*0x28*/ System.Collections.ArrayList _children;
                    /*0x30*/ System.ComponentModel.PropertyDescriptorCollection _properties;

                    /*0x7858df0*/ int get_Count();
                    /*0x7858ebc*/ string get_Name();
                    /*0x7858ec4*/ System.ComponentModel.PropertyDescriptorCollection get_Properties();
                    /*0x7859694*/ void CopyTo(System.Array array, int index);
                    /*0x7858e1c*/ void EnsurePopulated();
                    /*0x78596d8*/ System.Collections.IEnumerator GetEnumerator();
                    /*0x7859704*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x785970c*/ object System.Collections.ICollection.get_SyncRoot();

                    class WrappedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ object target;
                        /*0x90*/ System.ComponentModel.PropertyDescriptor property;

                        /*0x785962c*/ WrappedPropertyDescriptor(System.ComponentModel.PropertyDescriptor property, object target);
                        /*0x7859710*/ System.ComponentModel.AttributeCollection get_Attributes();
                        /*0x7859730*/ System.Type get_ComponentType();
                        /*0x7859754*/ bool get_IsReadOnly();
                        /*0x7859778*/ System.Type get_PropertyType();
                        /*0x785979c*/ bool CanResetValue(object component);
                        /*0x78597c8*/ object GetValue(object component);
                        /*0x78597f4*/ void ResetValue(object component);
                        /*0x7859820*/ void SetValue(object component, object value);
                        /*0x785984c*/ bool ShouldSerializeValue(object component);
                    }
                }

                class DesignerOptionConverter : System.ComponentModel.TypeConverter
                {
                    /*0x7859f64*/ DesignerOptionConverter();
                    /*0x7859878*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext cxt);
                    /*0x7859880*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext cxt, object value, System.Attribute[] attributes);
                    /*0x7859ea8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext cxt, System.Globalization.CultureInfo culture, object value, System.Type destinationType);

                    class OptionPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection _option;

                        /*0x7859e68*/ OptionPropertyDescriptor(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection option);
                        /*0x7859f6c*/ System.Type get_ComponentType();
                        /*0x7859f88*/ bool get_IsReadOnly();
                        /*0x7859f90*/ System.Type get_PropertyType();
                        /*0x7859fac*/ bool CanResetValue(object component);
                        /*0x7859fb4*/ object GetValue(object component);
                        /*0x7859fbc*/ void ResetValue(object component);
                        /*0x7859fc0*/ void SetValue(object component, object value);
                        /*0x7859fc4*/ bool ShouldSerializeValue(object component);
                    }
                }
            }

            namespace Serialization
            {
                class InstanceDescriptor
                {
                    /*0x10*/ System.Collections.ICollection <Arguments>k__BackingField;
                    /*0x18*/ bool <IsComplete>k__BackingField;
                    /*0x20*/ System.Reflection.MemberInfo <MemberInfo>k__BackingField;

                    /*0x7859fcc*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments);
                    /*0x7859fd4*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete);
                    /*0x785a508*/ System.Collections.ICollection get_Arguments();
                    /*0x785a510*/ System.Reflection.MemberInfo get_MemberInfo();
                    /*0x784cd54*/ object Invoke();
                }

                class RootDesignerSerializerAttribute : System.Attribute
                {
                    /*0x10*/ string _typeId;
                    /*0x18*/ bool <Reloadable>k__BackingField;
                    /*0x20*/ string <SerializerTypeName>k__BackingField;
                    /*0x28*/ string <SerializerBaseTypeName>k__BackingField;

                    /*0x785a518*/ RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable);
                    /*0x785a570*/ string get_SerializerBaseTypeName();
                    /*0x785a578*/ object get_TypeId();
                }
            }
        }
    }

    namespace Collections
    {
        class HashtableExtensions
        {
            static /*0x381cd68*/ bool TryGetValue<T>(System.Collections.Hashtable table, object key, ref T value);
        }

        namespace ObjectModel
        {
            class ObservableCollection<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
            {
                /*0x0*/ System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> _monitor;
                /*0x0*/ int _blockReentrancyCount;
                /*0x0*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
                /*0x0*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

                /*0x380cb08*/ ObservableCollection();
                /*0x380d83c*/ void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380d83c*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380cb08*/ void ClearItems();
                /*0x380cffc*/ void RemoveItem(int index);
                /*0x3907c14*/ void InsertItem(int index, T item);
                /*0x3907c14*/ void SetItem(int index, T item);
                /*0x380d83c*/ void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e);
                /*0x380d83c*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x380cb08*/ void CheckReentrancy();
                /*0x380cb08*/ void OnCountPropertyChanged();
                /*0x380cb08*/ void OnIndexerPropertyChanged();
                /*0x3907c14*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, object item, int index);
                void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, object oldItem, object newItem, int index);
                /*0x380cb08*/ void OnCollectionReset();
                /*0x380b9e8*/ System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> EnsureMonitorInitialized();
                /*0x380e0e8*/ void OnSerializing(System.Runtime.Serialization.StreamingContext context);
                /*0x380e0e8*/ void OnDeserialized(System.Runtime.Serialization.StreamingContext context);

                class SimpleMonitor<T> : System.IDisposable
                {
                    /*0x0*/ int _busyCount;
                    /*0x0*/ System.Collections.ObjectModel.ObservableCollection<T> _collection;

                    /*0x380d83c*/ SimpleMonitor(System.Collections.ObjectModel.ObservableCollection<T> collection);
                    /*0x380cb08*/ void Dispose();
                }
            }

            class EventArgsCache
            {
                static /*0x0*/ System.ComponentModel.PropertyChangedEventArgs CountPropertyChanged;
                static /*0x8*/ System.ComponentModel.PropertyChangedEventArgs IndexerPropertyChanged;
                static /*0x10*/ System.Collections.Specialized.NotifyCollectionChangedEventArgs ResetCollectionChanged;

                static /*0x785a618*/ EventArgsCache();
            }

            class ReadOnlyObservableCollection<T> : System.Collections.ObjectModel.ReadOnlyCollection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
            {
                /*0x0*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
                /*0x0*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

                /*0x380d83c*/ ReadOnlyObservableCollection(System.Collections.ObjectModel.ObservableCollection<T> list);
                /*0x380d83c*/ void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380d83c*/ void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380d83c*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380d83c*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380d83c*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs args);
                /*0x380d83c*/ void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x380d83c*/ void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args);
                /*0x380d93c*/ void HandleCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x380d93c*/ void HandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e);
            }
        }

        namespace Specialized
        {
            struct BitVector32
            {
                /*0x10*/ uint _data;

                static /*0x785a874*/ int CreateMask();
                static /*0x785a87c*/ int CreateMask(int previous);
                static /*0x785a9c4*/ string ToString(System.Collections.Specialized.BitVector32 value);
                /*0x785a848*/ bool get_Item(int bit);
                /*0x785a858*/ void set_Item(int bit, bool value);
                /*0x785a8e8*/ bool Equals(object o);
                /*0x785a960*/ int GetHashCode();
                /*0x785aa94*/ string ToString();
            }

            class ListDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Specialized.ListDictionary.DictionaryNode head;
                /*0x18*/ int version;
                /*0x1c*/ int count;
                /*0x20*/ System.Collections.IComparer comparer;
                /*0x28*/ object _syncRoot;

                /*0x785aa9c*/ ListDictionary();
                /*0x785aaa4*/ ListDictionary(System.Collections.IComparer comparer);
                /*0x785aad4*/ object get_Item(object key);
                /*0x785ac30*/ void set_Item(object key, object value);
                /*0x785ae38*/ int get_Count();
                /*0x785ae40*/ System.Collections.ICollection get_Keys();
                /*0x785aeec*/ bool get_IsReadOnly();
                /*0x785aef4*/ bool get_IsFixedSize();
                /*0x785aefc*/ bool get_IsSynchronized();
                /*0x785af04*/ object get_SyncRoot();
                /*0x785af78*/ System.Collections.ICollection get_Values();
                /*0x785afe4*/ void Add(object key, object value);
                /*0x785b214*/ void Clear();
                /*0x785b244*/ bool Contains(object key);
                /*0x785b394*/ void CopyTo(System.Array array, int index);
                /*0x785b558*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x785b608*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x785b660*/ void Remove(object key);

                class NodeEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                    /*0x20*/ int _version;
                    /*0x24*/ bool _start;

                    /*0x785b5b0*/ NodeEnumerator(System.Collections.Specialized.ListDictionary list);
                    /*0x785b7fc*/ object get_Current();
                    /*0x785b860*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x785b8dc*/ object get_Key();
                    /*0x785b93c*/ object get_Value();
                    /*0x785b99c*/ bool MoveNext();
                    /*0x785ba60*/ void Reset();
                }

                class NodeKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ bool _isKeys;

                    /*0x785aeb0*/ NodeKeyValueCollection(System.Collections.Specialized.ListDictionary list, bool isKeys);
                    /*0x785bae0*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x785bc24*/ int System.Collections.ICollection.get_Count();
                    /*0x785bc5c*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x785bc64*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x785bc7c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class NodeKeyValueEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                        /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                        /*0x20*/ int _version;
                        /*0x24*/ bool _isKeys;
                        /*0x25*/ bool _start;

                        /*0x785bce0*/ NodeKeyValueEnumerator(System.Collections.Specialized.ListDictionary list, bool isKeys);
                        /*0x785bd4c*/ object get_Current();
                        /*0x785bdc0*/ bool MoveNext();
                        /*0x785be84*/ void Reset();
                    }
                }

                class DictionaryNode
                {
                    /*0x10*/ object key;
                    /*0x18*/ object value;
                    /*0x20*/ System.Collections.Specialized.ListDictionary.DictionaryNode next;

                    /*0x785ae30*/ DictionaryNode();
                }
            }

            class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase
            {
                /*0x50*/ string[] _all;
                /*0x58*/ string[] _allKeys;

                static /*0x785c124*/ string GetAsOneString(System.Collections.ArrayList list);
                static /*0x785c2c8*/ string[] GetAsStringArray(System.Collections.ArrayList list);
                /*0x785bf04*/ NameValueCollection();
                /*0x785bfb8*/ NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x785c058*/ NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x785cd6c*/ NameValueCollection(System.DBNull dummy);
                /*0x785c0fc*/ void InvalidateCachedArrays();
                /*0x785c368*/ void Add(string name, string value);
                /*0x785c66c*/ string Get(string name);
                /*0x785c6f8*/ string[] GetValues(string name);
                /*0x785c784*/ void Set(string name, string value);
                /*0x785c938*/ void Remove(string name);
                /*0x785cb8c*/ string get_Item(string name);
                /*0x785cb9c*/ void set_Item(string name, string value);
                /*0x785cbac*/ string Get(int index);
                /*0x785cccc*/ string GetKey(int index);
            }

            class OrderedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                /*0x10*/ System.Collections.ArrayList _objectsArray;
                /*0x18*/ System.Collections.Hashtable _objectsTable;
                /*0x20*/ int _initialCapacity;
                /*0x28*/ System.Collections.IEqualityComparer _comparer;
                /*0x30*/ bool _readOnly;
                /*0x38*/ object _syncRoot;
                /*0x40*/ System.Runtime.Serialization.SerializationInfo _siInfo;

                /*0x785cdcc*/ OrderedDictionary();
                /*0x784c6c4*/ OrderedDictionary(int capacity);
                /*0x785cdf4*/ OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer);
                /*0x785ce2c*/ OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x784c8a0*/ int get_Count();
                /*0x785cee0*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x785cee8*/ bool get_IsReadOnly();
                /*0x785cef0*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x785cef8*/ System.Collections.ICollection get_Keys();
                /*0x785ce5c*/ System.Collections.ArrayList get_objectsArray();
                /*0x785cfb4*/ System.Collections.Hashtable get_objectsTable();
                /*0x785d040*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x785514c*/ object get_Item(object key);
                /*0x784c724*/ void set_Item(object key, object value);
                /*0x784c8c4*/ System.Collections.ICollection get_Values();
                /*0x785d234*/ void Add(object key, object value);
                /*0x785d358*/ void Clear();
                /*0x784c6f8*/ bool Contains(object key);
                /*0x785d3ec*/ void CopyTo(System.Array array, int index);
                /*0x785d0b4*/ int IndexOfKey(object key);
                /*0x7855178*/ void Remove(object key);
                /*0x785d428*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x785d4ec*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x785d558*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x785d720*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x785d730*/ void OnDeserialization(object sender);

                class OrderedDictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ int _objectReturnType;
                    /*0x18*/ System.Collections.IEnumerator _arrayEnumerator;

                    /*0x785d494*/ OrderedDictionaryEnumerator(System.Collections.ArrayList array, int objectReturnType);
                    /*0x785daf0*/ object get_Current();
                    /*0x785dcb4*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x785de48*/ object get_Key();
                    /*0x785df2c*/ object get_Value();
                    /*0x785e010*/ bool MoveNext();
                    /*0x785e0b0*/ void Reset();
                }

                class OrderedDictionaryKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _objects;
                    /*0x18*/ bool _isKeys;

                    /*0x785cf78*/ OrderedDictionaryKeyValueCollection(System.Collections.ArrayList array, bool isKeys);
                    /*0x785e154*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x785e548*/ int System.Collections.ICollection.get_Count();
                    /*0x785e56c*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x785e574*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x785e598*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class StringCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ArrayList data;

                /*0x785ea08*/ StringCollection();
                /*0x785e608*/ string get_Item(int index);
                /*0x785e650*/ void set_Item(int index, string value);
                /*0x785e674*/ int get_Count();
                /*0x785e698*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x785e6a0*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x785e6a8*/ int Add(string value);
                /*0x785e6cc*/ void Clear();
                /*0x785e6f0*/ bool Contains(string value);
                /*0x785e714*/ void CopyTo(string[] array, int index);
                /*0x785e738*/ int IndexOf(string value);
                /*0x785e75c*/ void Insert(int index, string value);
                /*0x785e780*/ bool get_IsSynchronized();
                /*0x785e788*/ void Remove(string value);
                /*0x785e7ac*/ void RemoveAt(int index);
                /*0x785e7d0*/ object get_SyncRoot();
                /*0x785e7f4*/ object System.Collections.IList.get_Item(int index);
                /*0x785e7f8*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x785e844*/ int System.Collections.IList.Add(object value);
                /*0x785e890*/ bool System.Collections.IList.Contains(object value);
                /*0x785e8dc*/ int System.Collections.IList.IndexOf(object value);
                /*0x785e928*/ void System.Collections.IList.Insert(int index, object value);
                /*0x785e974*/ void System.Collections.IList.Remove(object value);
                /*0x785e9c0*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x785e9e4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class StringDictionary : System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable contents;

                /*0x785ea74*/ StringDictionary();
                /*0x785eae0*/ string get_Item(string key);
                /*0x785eb88*/ System.Collections.IEnumerator GetEnumerator();
            }

            interface INotifyCollectionChanged
            {
                /*0x380d83c*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x380d83c*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
            }

            enum NotifyCollectionChangedAction
            {
                Add = 0,
                Remove = 1,
                Replace = 2,
                Move = 3,
                Reset = 4,
            }

            class NotifyCollectionChangedEventArgs : System.EventArgs
            {
                /*0x10*/ System.Collections.Specialized.NotifyCollectionChangedAction _action;
                /*0x18*/ System.Collections.IList _newItems;
                /*0x20*/ System.Collections.IList _oldItems;
                /*0x28*/ int _newStartingIndex;
                /*0x2c*/ int _oldStartingIndex;

                /*0x785a738*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action);
                /*0x785ec48*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index);
                /*0x785ee38*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem, int index);
                /*0x785f06c*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex);
                /*0x785ee20*/ void InitializeAddOrRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int startingIndex);
                /*0x785ebac*/ void InitializeAdd(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, int newStartingIndex);
                /*0x785f21c*/ void InitializeRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList oldItems, int oldStartingIndex);
                /*0x785f028*/ void InitializeMoveOrReplace(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex, int oldStartingIndex);
            }

            class NotifyCollectionChangedEventHandler : System.MulticastDelegate
            {
                /*0x785f2e8*/ NotifyCollectionChangedEventHandler(object object, nint method);
                /*0x785f3f4*/ void Invoke(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
            }

            class ReadOnlyList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.IList _list;

                /*0x785f2b8*/ ReadOnlyList(System.Collections.IList list);
                /*0x785f408*/ int get_Count();
                /*0x785f4ac*/ bool get_IsReadOnly();
                /*0x785f4b4*/ bool get_IsFixedSize();
                /*0x785f4bc*/ bool get_IsSynchronized();
                /*0x785f560*/ object get_Item(int index);
                /*0x785f608*/ void set_Item(int index, object value);
                /*0x785f654*/ object get_SyncRoot();
                /*0x785f6f8*/ int Add(object value);
                /*0x785f744*/ void Clear();
                /*0x785f790*/ bool Contains(object value);
                /*0x785f83c*/ void CopyTo(System.Array array, int index);
                /*0x785f8f4*/ System.Collections.IEnumerator GetEnumerator();
                /*0x785f994*/ int IndexOf(object value);
                /*0x785fa40*/ void Insert(int index, object value);
                /*0x785fa8c*/ void Remove(object value);
                /*0x785fad8*/ void RemoveAt(int index);
            }

            class NameObjectCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                static /*0x0*/ System.StringComparer defaultComparer;
                /*0x10*/ bool _readOnly;
                /*0x18*/ System.Collections.ArrayList _entriesArray;
                /*0x20*/ System.Collections.IEqualityComparer _keyComparer;
                /*0x28*/ System.Collections.Hashtable _entriesTable;
                /*0x30*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;
                /*0x38*/ System.Runtime.Serialization.SerializationInfo _serializationInfo;
                /*0x40*/ int _version;
                /*0x48*/ object _syncRoot;

                static /*0x78611b8*/ NameObjectCollectionBase();
                /*0x785bf58*/ NameObjectCollectionBase();
                /*0x785fb24*/ NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer);
                /*0x785c02c*/ NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x785cdc4*/ NameObjectCollectionBase(System.DBNull dummy);
                /*0x785c0cc*/ NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x785fd5c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x78604c8*/ void OnDeserialization(object sender);
                /*0x785fbb0*/ void Reset();
                /*0x785fc80*/ void Reset(int capacity);
                /*0x7860c5c*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(string key);
                /*0x7860d14*/ bool get_IsReadOnly();
                /*0x785c504*/ void BaseAdd(string name, object value);
                /*0x785c978*/ void BaseRemove(string name);
                /*0x785c4ec*/ object BaseGet(string name);
                /*0x785c888*/ void BaseSet(string name, object value);
                /*0x785cc30*/ object BaseGet(int index);
                /*0x785ccd0*/ string BaseGetKey(int index);
                /*0x7860d60*/ System.Collections.IEnumerator GetEnumerator();
                /*0x7860e0c*/ int get_Count();
                /*0x7860e30*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x786113c*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x78611b0*/ bool System.Collections.ICollection.get_IsSynchronized();

                class NameObjectEntry
                {
                    /*0x10*/ string Key;
                    /*0x18*/ object Value;

                    /*0x7860d1c*/ NameObjectEntry(string name, object value);
                }

                class NameObjectKeysEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ int _pos;
                    /*0x18*/ System.Collections.Specialized.NameObjectCollectionBase _coll;
                    /*0x20*/ int _version;

                    /*0x7860db8*/ NameObjectKeysEnumerator(System.Collections.Specialized.NameObjectCollectionBase coll);
                    /*0x7861268*/ bool MoveNext();
                    /*0x7861340*/ void Reset();
                    /*0x78613c8*/ object get_Current();
                }
            }

            class CompatibleComparer : System.Collections.IEqualityComparer
            {
                static /*0x0*/ System.Collections.IComparer defaultComparer;
                static /*0x8*/ System.Collections.IHashCodeProvider defaultHashProvider;
                /*0x10*/ System.Collections.IComparer _comparer;
                /*0x18*/ System.Collections.IHashCodeProvider _hcp;

                static /*0x78603e4*/ System.Collections.IComparer get_DefaultComparer();
                static /*0x7860308*/ System.Collections.IHashCodeProvider get_DefaultHashCodeProvider();
                /*0x7860c18*/ CompatibleComparer(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider);
                /*0x7861468*/ bool Equals(object a, object b);
                /*0x7861668*/ int GetHashCode(object obj);
                /*0x7861770*/ System.Collections.IComparer get_Comparer();
                /*0x7861778*/ System.Collections.IHashCodeProvider get_HashCodeProvider();
            }
        }

        namespace Concurrent
        {
            class ConcurrentBag<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>
            {
                /*0x0*/ System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>> _locals;
                /*0x0*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> _workStealingQueues;
                /*0x0*/ long _emptyToNonEmptyListTransitionCount;

                /*0x380cb08*/ ConcurrentBag();
                /*0x3907c14*/ void Add(T item);
                System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate);
                /*0x380b9e8*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread();
                /*0x380b9e8*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue();
                /*0x380d8b8*/ void CopyTo(T[] array, int index);
                int CopyFromEachQueueToArray(T[] array, int index);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380b9e8*/ T[] ToArray();
                /*0x380cb08*/ void Clear();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380b6a0*/ int get_Count();
                /*0x380b6a0*/ int get_DangerousCount();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b9e8*/ object get_GlobalQueuesLock();
                /*0x380d83c*/ void FreezeBag(ref bool lockTaken);
                /*0x380cdf0*/ void UnfreezeBag(bool lockTaken);

                class WorkStealingQueue<T>
                {
                    static int InitialSize = 32;
                    static int StartIndex = 0;
                    /*0x0*/ int _headIndex;
                    /*0x0*/ int _tailIndex;
                    /*0x0*/ T[] _array;
                    /*0x0*/ int _mask;
                    /*0x0*/ int _addTakeCount;
                    /*0x0*/ int _stealCount;
                    /*0x0*/ int _currentOp;
                    /*0x0*/ bool _frozen;
                    /*0x0*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> _nextQueue;
                    /*0x0*/ int _ownerThreadId;

                    /*0x380d83c*/ WorkStealingQueue(System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> nextQueue);
                    /*0x3907c14*/ void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount);
                    /*0x380cb08*/ void LocalClear();
                    bool TrySteal(ref T result, bool take);
                    int DangerousCopyTo(T[] array, int arrayIndex);
                    /*0x380b6a0*/ int get_DangerousCount();
                }

                class Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ T[] _array;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    /*0x380d83c*/ Enumerator(T[] array);
                    /*0x380b128*/ bool MoveNext();
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void Dispose();
                }
            }
        }

        namespace Generic
        {
            struct ValueListBuilder<T>
            {
                /*0x0*/ System.Span<T> _span;
                /*0x0*/ T[] _arrayFromPool;
                /*0x0*/ int _pos;

                /*0x3907c14*/ ValueListBuilder(System.Span<T> initialSpan);
                /*0x380b6a0*/ int get_Length();
                /*0x380ba90*/ ref T get_Item(int index);
                /*0x3907c14*/ void Append(T item);
                /*0x3907c14*/ System.ReadOnlySpan<T> AsSpan();
                /*0x380cb08*/ void Dispose();
                /*0x380cb08*/ void Grow();
                /*0x3907c14*/ T Pop();
            }

            class ICollectionDebugView<T>
            {
            }

            class IDictionaryDebugView<K, V>
            {
            }

            class DictionaryKeyCollectionDebugView<TKey, TValue>
            {
            }

            class DictionaryValueCollectionDebugView<TKey, TValue>
            {
            }

            class LinkedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                static string VersionName = "Version";
                static string CountName = "Count";
                static string ValuesName = "Data";
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> head;
                /*0x0*/ int count;
                /*0x0*/ int version;
                /*0x0*/ object _syncRoot;
                /*0x0*/ System.Runtime.Serialization.SerializationInfo _siInfo;

                /*0x380cb08*/ LinkedList();
                LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x380b6a0*/ int get_Count();
                /*0x380b9e8*/ System.Collections.Generic.LinkedListNode<T> get_First();
                /*0x380b9e8*/ System.Collections.Generic.LinkedListNode<T> get_Last();
                /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T value);
                /*0x380d93c*/ void AddBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x3907c14*/ System.Collections.Generic.LinkedListNode<T> AddFirst(T value);
                /*0x380d83c*/ void AddFirst(System.Collections.Generic.LinkedListNode<T> node);
                /*0x3907c14*/ System.Collections.Generic.LinkedListNode<T> AddLast(T value);
                /*0x380d83c*/ void AddLast(System.Collections.Generic.LinkedListNode<T> node);
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ bool Contains(T value);
                /*0x380d8b8*/ void CopyTo(T[] array, int index);
                /*0x3907c14*/ System.Collections.Generic.LinkedListNode<T> Find(T value);
                /*0x3907c14*/ System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x3907c14*/ bool Remove(T value);
                /*0x380d83c*/ void Remove(System.Collections.Generic.LinkedListNode<T> node);
                /*0x380cb08*/ void RemoveFirst();
                /*0x380cb08*/ void RemoveLast();
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x380d83c*/ void OnDeserialization(object sender);
                /*0x380d93c*/ void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x380d83c*/ void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x380d83c*/ void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x380d83c*/ void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x380d83c*/ void ValidateNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    /*0x0*/ System.Collections.Generic.LinkedList<T> _list;
                    /*0x0*/ System.Collections.Generic.LinkedListNode<T> _node;
                    /*0x0*/ int _version;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    /*0x380d83c*/ Enumerator(System.Collections.Generic.LinkedList<T> list);
                    Enumerator(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380cb08*/ void Dispose();
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x380d83c*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                }
            }

            class LinkedListNode<T>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<T> list;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> next;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> prev;
                /*0x0*/ T item;

                /*0x3907c14*/ LinkedListNode(T value);
                /*0x3907c14*/ LinkedListNode(System.Collections.Generic.LinkedList<T> list, T value);
                /*0x380b9e8*/ System.Collections.Generic.LinkedList<T> get_List();
                /*0x380b9e8*/ System.Collections.Generic.LinkedListNode<T> get_Next();
                /*0x380b9e8*/ System.Collections.Generic.LinkedListNode<T> get_Previous();
                /*0x3907c14*/ T get_Value();
                /*0x3907c14*/ void set_Value(T value);
                /*0x380cb08*/ void Invalidate();
            }

            class SortedDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> _keys;
                /*0x0*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> _values;
                /*0x0*/ System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey, TValue>> _set;

                static /*0x381ac0c*/ bool IsCompatibleKey(object key);
                /*0x380cb08*/ SortedDictionary();
                /*0x380d93c*/ SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer);
                /*0x380d83c*/ SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x3907c14*/ TValue get_Item(TKey key);
                /*0x3907c14*/ void set_Item(TKey key, TValue value);
                /*0x380b6a0*/ int get_Count();
                /*0x380b9e8*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> get_Values();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                /*0x3907c14*/ void Add(TKey key, TValue value);
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ bool ContainsKey(TKey key);
                /*0x3907c14*/ bool ContainsValue(TValue value);
                /*0x380d8b8*/ void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int index);
                /*0x3907c14*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x3907c14*/ bool Remove(TKey key);
                /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x380d83c*/ void System.Collections.IDictionary.Remove(object key);
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedSet.Enumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _treeEnum;
                    /*0x0*/ int _getEnumeratorRetType;

                    /*0x380d8b8*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Dispose();
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x380b128*/ bool get_NotStartedOrEnded();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b9e8*/ object System.Collections.IDictionaryEnumerator.get_Key();
                    /*0x380b9e8*/ object System.Collections.IDictionaryEnumerator.get_Value();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                }

                class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TKey>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    /*0x380d83c*/ KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x380d8b8*/ void CopyTo(TKey[] array, int index);
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly();
                    /*0x3907c14*/ void System.Collections.Generic.ICollection<TKey>.Add(TKey item);
                    /*0x380cb08*/ void System.Collections.Generic.ICollection<TKey>.Clear();
                    /*0x3907c14*/ bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item);
                    /*0x3907c14*/ bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item);
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        /*0x380d83c*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        /*0x380cb08*/ void Dispose();
                        /*0x380b128*/ bool MoveNext();
                        /*0x3907c14*/ TKey get_Current();
                        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                        /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TKey[] array;
                        /*0x0*/ int index;

                        /*0x380cb08*/ <>c__DisplayClass5_0();
                        /*0x380b2f0*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        /*0x380cb08*/ <>c__DisplayClass6_0();
                        /*0x380b2f0*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TValue>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    /*0x380d83c*/ ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x380d8b8*/ void CopyTo(TValue[] array, int index);
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly();
                    /*0x3907c14*/ void System.Collections.Generic.ICollection<TValue>.Add(TValue item);
                    /*0x380cb08*/ void System.Collections.Generic.ICollection<TValue>.Clear();
                    /*0x3907c14*/ bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item);
                    /*0x3907c14*/ bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item);
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        /*0x380d83c*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        /*0x380cb08*/ void Dispose();
                        /*0x380b128*/ bool MoveNext();
                        /*0x3907c14*/ TValue get_Current();
                        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                        /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TValue[] array;
                        /*0x0*/ int index;

                        /*0x380cb08*/ <>c__DisplayClass5_0();
                        /*0x380b2f0*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        /*0x380cb08*/ <>c__DisplayClass6_0();
                        /*0x380b2f0*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class KeyValuePairComparer<TKey, TValue> : System.Collections.Generic.Comparer<System.Collections.Generic.KeyValuePair<TKey, TValue>>
                {
                    /*0x0*/ System.Collections.Generic.IComparer<TKey> keyComparer;

                    /*0x380d83c*/ KeyValuePairComparer(System.Collections.Generic.IComparer<TKey> keyComparer);
                    /*0x3907c14*/ int Compare(System.Collections.Generic.KeyValuePair<TKey, TValue> x, System.Collections.Generic.KeyValuePair<TKey, TValue> y);
                }

                class <>c__DisplayClass34_0<TKey, TValue>
                {
                    /*0x0*/ bool found;
                    /*0x0*/ TValue value;

                    /*0x380cb08*/ <>c__DisplayClass34_0();
                    /*0x380b2f0*/ bool <ContainsValue>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }

                class <>c__DisplayClass34_1<TKey, TValue>
                {
                    /*0x0*/ System.Collections.Generic.EqualityComparer<TValue> valueComparer;
                    /*0x0*/ System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1;

                    /*0x380cb08*/ <>c__DisplayClass34_1();
                    /*0x380b2f0*/ bool <ContainsValue>b__1(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }
            }

            class TreeSet<T> : System.Collections.Generic.SortedSet<T>
            {
                /*0x380cb08*/ TreeSet();
                /*0x380d83c*/ TreeSet(System.Collections.Generic.IComparer<T> comparer);
                TreeSet(System.Runtime.Serialization.SerializationInfo siInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x3907c14*/ bool AddIfNotPresent(T item);
            }

            class SortedList<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ TKey[] keys;
                /*0x0*/ TValue[] values;
                /*0x0*/ int _size;
                /*0x0*/ int version;
                /*0x0*/ System.Collections.Generic.IComparer<TKey> comparer;
                /*0x0*/ System.Collections.Generic.SortedList.KeyList<TKey, TValue> keyList;
                /*0x0*/ System.Collections.Generic.SortedList.ValueList<TKey, TValue> valueList;
                /*0x0*/ object _syncRoot;

                static /*0x381ac0c*/ bool IsCompatibleKey(object key);
                /*0x380cb08*/ SortedList();
                /*0x380cffc*/ SortedList(int capacity);
                /*0x380d83c*/ SortedList(System.Collections.Generic.IComparer<TKey> comparer);
                /*0x3907c14*/ void Add(TKey key, TValue value);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x380cffc*/ void set_Capacity(int value);
                /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x380b6a0*/ int get_Count();
                /*0x380b9e8*/ System.Collections.Generic.IList<TKey> get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.IList<TValue> get_Values();
                /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                /*0x380b9e8*/ System.Collections.Generic.SortedList.KeyList<TKey, TValue> GetKeyListHelper();
                /*0x380b9e8*/ System.Collections.Generic.SortedList.ValueList<TKey, TValue> GetValueListHelper();
                /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380cb08*/ void Clear();
                /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x3907c14*/ bool ContainsKey(TKey key);
                /*0x3907c14*/ bool ContainsValue(TValue value);
                /*0x380d8b8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x380cffc*/ void EnsureCapacity(int min);
                /*0x3907c14*/ TValue GetByIndex(int index);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3907c14*/ TKey GetKey(int index);
                /*0x3907c14*/ TValue get_Item(TKey key);
                /*0x3907c14*/ void set_Item(TKey key, TValue value);
                /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x3907c14*/ int IndexOfKey(TKey key);
                /*0x3907c14*/ int IndexOfValue(TValue value);
                /*0x3907c14*/ void Insert(int index, TKey key, TValue value);
                /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x380cffc*/ void RemoveAt(int index);
                /*0x3907c14*/ bool Remove(TKey key);
                /*0x380d83c*/ void System.Collections.IDictionary.Remove(object key);

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ TKey _key;
                    /*0x0*/ TValue _value;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ int _getEnumeratorRetType;

                    /*0x380d8b8*/ Enumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList, int getEnumeratorRetType);
                    /*0x380cb08*/ void Dispose();
                    /*0x380b9e8*/ object System.Collections.IDictionaryEnumerator.get_Key();
                    /*0x380b128*/ bool MoveNext();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b9e8*/ object System.Collections.IDictionaryEnumerator.get_Value();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListKeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TKey _currentKey;

                    /*0x380d83c*/ SortedListKeyEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x3907c14*/ TKey get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TValue _currentValue;

                    /*0x380d83c*/ SortedListValueEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x3907c14*/ TValue get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                }

                class KeyList<TKey, TValue> : System.Collections.Generic.IList<TKey>, System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x380d83c*/ KeyList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool get_IsReadOnly();
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x3907c14*/ void Add(TKey key);
                    /*0x380cb08*/ void Clear();
                    /*0x3907c14*/ bool Contains(TKey key);
                    /*0x380d8b8*/ void CopyTo(TKey[] array, int arrayIndex);
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    /*0x3907c14*/ void Insert(int index, TKey value);
                    /*0x3907c14*/ TKey get_Item(int index);
                    /*0x3907c14*/ void set_Item(int index, TKey value);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TKey> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3907c14*/ int IndexOf(TKey key);
                    /*0x3907c14*/ bool Remove(TKey key);
                    /*0x380cffc*/ void RemoveAt(int index);
                }

                class ValueList<TKey, TValue> : System.Collections.Generic.IList<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x380d83c*/ ValueList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x380b6a0*/ int get_Count();
                    /*0x380b128*/ bool get_IsReadOnly();
                    /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x3907c14*/ void Add(TValue key);
                    /*0x380cb08*/ void Clear();
                    /*0x3907c14*/ bool Contains(TValue value);
                    /*0x380d8b8*/ void CopyTo(TValue[] array, int arrayIndex);
                    /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x3907c14*/ void Insert(int index, TValue value);
                    /*0x3907c14*/ TValue get_Item(int index);
                    /*0x3907c14*/ void set_Item(int index, TValue value);
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3907c14*/ int IndexOf(TValue value);
                    /*0x3907c14*/ bool Remove(TValue value);
                    /*0x380cffc*/ void RemoveAt(int index);
                }
            }

            class SortedSet<T> : System.Collections.Generic.ISet<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                /*0x0*/ System.Collections.Generic.SortedSet.Node<T> root;
                /*0x0*/ System.Collections.Generic.IComparer<T> comparer;
                /*0x0*/ int count;
                /*0x0*/ int version;
                /*0x0*/ object _syncRoot;
                /*0x0*/ System.Runtime.Serialization.SerializationInfo siInfo;

                static /*0x3824360*/ int Log2(int value);
                /*0x380cb08*/ SortedSet();
                /*0x380d83c*/ SortedSet(System.Collections.Generic.IComparer<T> comparer);
                SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x380b2f0*/ bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action);
                /*0x380b6a0*/ int get_Count();
                /*0x380b128*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x380cb08*/ void VersionCheck();
                /*0x3907c14*/ bool IsWithinRange(T item);
                /*0x3907c14*/ bool Add(T item);
                /*0x3907c14*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                /*0x3907c14*/ bool AddIfNotPresent(T item);
                /*0x3907c14*/ bool Remove(T item);
                /*0x3907c14*/ bool DoRemove(T item);
                /*0x380cb08*/ void Clear();
                /*0x3907c14*/ bool Contains(T item);
                /*0x380d8b8*/ void CopyTo(T[] array, int index);
                void CopyTo(T[] array, int index, int count);
                /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3907c14*/ System.Collections.Generic.SortedSet.Enumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x380da84*/ void InsertionBalance(System.Collections.Generic.SortedSet.Node<T> current, ref System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> grandParent, System.Collections.Generic.SortedSet.Node<T> greatGrandParent);
                /*0x380da4c*/ void ReplaceChildOrRoot(System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                /*0x380da84*/ void ReplaceNode(System.Collections.Generic.SortedSet.Node<T> match, System.Collections.Generic.SortedSet.Node<T> parentOfMatch, System.Collections.Generic.SortedSet.Node<T> successor, System.Collections.Generic.SortedSet.Node<T> parentOfSuccessor);
                /*0x3907c14*/ System.Collections.Generic.SortedSet.Node<T> FindNode(T item);
                /*0x380cb08*/ void UpdateVersion();
                void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x380d83c*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x380d83c*/ void OnDeserialization(object sender);

                class Node<T>
                {
                    /*0x0*/ T <Item>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Left>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Right>k__BackingField;
                    /*0x0*/ System.Collections.Generic.NodeColor <Color>k__BackingField;

                    static /*0x381ac0c*/ bool IsNonNullRed(System.Collections.Generic.SortedSet.Node<T> node);
                    static /*0x381ac0c*/ bool IsNullOrBlack(System.Collections.Generic.SortedSet.Node<T> node);
                    /*0x3907c14*/ Node(T item, System.Collections.Generic.NodeColor color);
                    /*0x3907c14*/ T get_Item();
                    /*0x3907c14*/ void set_Item(T value);
                    /*0x380b9e8*/ System.Collections.Generic.SortedSet.Node<T> get_Left();
                    /*0x380d83c*/ void set_Left(System.Collections.Generic.SortedSet.Node<T> value);
                    /*0x380b9e8*/ System.Collections.Generic.SortedSet.Node<T> get_Right();
                    /*0x380d83c*/ void set_Right(System.Collections.Generic.SortedSet.Node<T> value);
                    /*0x380b128*/ System.Collections.Generic.NodeColor get_Color();
                    /*0x380cdf0*/ void set_Color(System.Collections.Generic.NodeColor value);
                    /*0x380b128*/ bool get_IsBlack();
                    /*0x380b128*/ bool get_IsRed();
                    /*0x380b128*/ bool get_Is2Node();
                    /*0x380b128*/ bool get_Is4Node();
                    /*0x380cb08*/ void ColorBlack();
                    /*0x380cb08*/ void ColorRed();
                    /*0x380b32c*/ System.Collections.Generic.TreeRotation GetRotation(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T> sibling);
                    /*0x380bb68*/ System.Collections.Generic.SortedSet.Node<T> GetSibling(System.Collections.Generic.SortedSet.Node<T> node);
                    /*0x380cb08*/ void Split4Node();
                    System.Collections.Generic.SortedSet.Node<T> Rotate(System.Collections.Generic.TreeRotation rotation);
                    /*0x380b9e8*/ System.Collections.Generic.SortedSet.Node<T> RotateLeft();
                    /*0x380b9e8*/ System.Collections.Generic.SortedSet.Node<T> RotateLeftRight();
                    /*0x380b9e8*/ System.Collections.Generic.SortedSet.Node<T> RotateRight();
                    /*0x380b9e8*/ System.Collections.Generic.SortedSet.Node<T> RotateRightLeft();
                    /*0x380cb08*/ void Merge2Nodes();
                    /*0x380d93c*/ void ReplaceChild(System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    static /*0x0*/ System.Collections.Generic.SortedSet.Node<T> s_dummyNode;
                    /*0x0*/ System.Collections.Generic.SortedSet<T> _tree;
                    /*0x0*/ int _version;
                    /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>> _stack;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> _current;
                    /*0x0*/ bool _reverse;

                    static /*0x38358cc*/ Enumerator();
                    /*0x380d83c*/ Enumerator(System.Collections.Generic.SortedSet<T> set);
                    Enumerator(System.Collections.Generic.SortedSet<T> set, bool reverse);
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x380d83c*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                    /*0x380cb08*/ void Initialize();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Dispose();
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b128*/ bool get_NotStartedOrEnded();
                    /*0x380cb08*/ void Reset();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                }

                class <>c__DisplayClass52_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ int count;
                    /*0x0*/ T[] array;

                    /*0x380cb08*/ <>c__DisplayClass52_0();
                    /*0x380b2f0*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
                }

                class <>c__DisplayClass53_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ object[] objects;

                    /*0x380cb08*/ <>c__DisplayClass53_0();
                    /*0x380b2f0*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
                }
            }

            enum NodeColor
            {
                Black = 0,
                Red = 1,
            }

            class TreeWalkPredicate<T> : System.MulticastDelegate
            {
                TreeWalkPredicate(object object, nint method);
                /*0x380b2f0*/ bool Invoke(System.Collections.Generic.SortedSet.Node<T> node);
            }

            enum TreeRotation
            {
                Left = 0,
                LeftRight = 1,
                Right = 2,
                RightLeft = 3,
            }

            class CollectionDebugView<T>
            {
            }

            interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
            }
        }
    }

    namespace IO
    {
        class InvalidDataException : System.SystemException
        {
            /*0x7861780*/ InvalidDataException();
            /*0x78617e8*/ InvalidDataException(string message);
            /*0x786180c*/ InvalidDataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        namespace Compression
        {
            enum CompressionMode
            {
                Decompress = 0,
                Compress = 1,
            }

            class GZipStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Compression.DeflateStream _deflateStream;

                static /*0x7862358*/ void ThrowStreamClosedException();
                /*0x7861814*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x786181c*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x78618e0*/ bool get_CanRead();
                /*0x78618f8*/ bool get_CanWrite();
                /*0x7861910*/ bool get_CanSeek();
                /*0x7861928*/ long get_Length();
                /*0x7861974*/ long get_Position();
                /*0x78619c0*/ void set_Position(long value);
                /*0x7861a0c*/ void Flush();
                /*0x7861a48*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x7861a94*/ void SetLength(long value);
                /*0x7861ae0*/ int ReadByte();
                /*0x7861b04*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x7861bb8*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x7861c00*/ int Read(byte[] array, int offset, int count);
                /*0x7861c24*/ int Read(System.Span<byte> buffer);
                /*0x7861e10*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x7861ec4*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x7861ed0*/ void Write(byte[] array, int offset, int count);
                /*0x7861ef4*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x786204c*/ void CopyTo(System.IO.Stream destination, int bufferSize);
                /*0x7862070*/ void Dispose(bool disposing);
                /*0x7862144*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7862168*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x786223c*/ System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7862260*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x7862334*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x7861a30*/ void CheckDeflateStream();
            }

            class DeflateStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream base_stream;
                /*0x30*/ System.IO.Compression.CompressionMode mode;
                /*0x34*/ bool leaveOpen;
                /*0x35*/ bool disposed;
                /*0x38*/ System.IO.Compression.DeflateStreamNative native;

                /*0x78623a8*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x78618d4*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen, int windowsBits);
                /*0x78623b4*/ DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen, bool gzip);
                /*0x78626a4*/ void Finalize();
                /*0x7862748*/ void Dispose(bool disposing);
                /*0x7862920*/ int ReadInternal(byte[] array, int offset, int count);
                /*0x7862234*/ System.Threading.Tasks.ValueTask<int> ReadAsyncMemory(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken);
                /*0x7861cf8*/ int ReadCore(System.Span<byte> destination);
                /*0x78629e0*/ int Read(byte[] array, int offset, int count);
                /*0x7862bb0*/ void WriteInternal(byte[] array, int offset, int count);
                /*0x786232c*/ System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken);
                /*0x7861fc8*/ void WriteCore(System.ReadOnlySpan<byte> source);
                /*0x7862c60*/ void Write(byte[] array, int offset, int count);
                /*0x7862e3c*/ void Flush();
                /*0x7862f40*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x78632d8*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x7863670*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x78637d4*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x7863920*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x7863958*/ void SetLength(long value);
                /*0x7863990*/ bool get_CanRead();
                /*0x78639cc*/ bool get_CanSeek();
                /*0x78639d4*/ bool get_CanWrite();
                /*0x7863a14*/ long get_Length();
                /*0x7863a4c*/ long get_Position();
                /*0x7863a84*/ void set_Position(long value);

                class ReadMethod : System.MulticastDelegate
                {
                    /*0x78631a4*/ ReadMethod(object object, nint method);
                    /*0x7863abc*/ int Invoke(byte[] array, int offset, int count);
                    /*0x7863258*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x78637ac*/ int EndInvoke(System.IAsyncResult result);
                }

                class WriteMethod : System.MulticastDelegate
                {
                    /*0x786353c*/ WriteMethod(object object, nint method);
                    /*0x7863ad0*/ void Invoke(byte[] array, int offset, int count);
                    /*0x78635f0*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x7863914*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class DeflateStreamNative
            {
                /*0x10*/ System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder;
                /*0x18*/ System.IO.Stream base_stream;
                /*0x20*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle z_stream;
                /*0x28*/ System.Runtime.InteropServices.GCHandle data;
                /*0x30*/ bool disposed;
                /*0x38*/ byte[] io_buffer;
                /*0x40*/ System.Exception last_error;

                static /*0x7862534*/ System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool gzip);
                static /*0x7863ae4*/ int UnmanagedRead(nint buffer, int length, nint data);
                static /*0x7863c00*/ int UnmanagedWrite(nint buffer, int length, nint data);
                static /*0x7863d24*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, bool gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, nint data);
                static /*0x7864498*/ int CloseZStream(nint stream);
                static /*0x7863e58*/ int Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream);
                static /*0x7863fe8*/ int ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                static /*0x7864064*/ int WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                /*0x7863d1c*/ DeflateStreamNative();
                /*0x7863dc0*/ void Finalize();
                /*0x7862810*/ void Dispose(bool disposing);
                /*0x7862eec*/ void Flush();
                /*0x7862968*/ int ReadZStream(nint buffer, int length);
                /*0x7862bf4*/ void WriteZStream(nint buffer, int length);
                /*0x78640e0*/ int UnmanagedRead(nint buffer, int length);
                /*0x78642a0*/ int UnmanagedWrite(nint buffer, int length);
                /*0x7863ebc*/ void CheckResult(int result, string where);

                class UnmanagedReadOrWrite : System.MulticastDelegate
                {
                    /*0x786449c*/ UnmanagedReadOrWrite(object object, nint method);
                    /*0x786453c*/ int Invoke(nint buffer, int length, nint data);
                }

                class SafeDeflateStreamHandle : System.Runtime.InteropServices.SafeHandle
                {
                    /*0x7864560*/ SafeDeflateStreamHandle();
                    /*0x7864550*/ bool get_IsInvalid();
                    /*0x7864570*/ bool ReleaseHandle();
                }
            }
        }
    }

    namespace Net
    {
        class ContextAwareResult : System.Net.LazyAsyncResult
        {
            /*0x40*/ System.Threading.ExecutionContext _context;
            /*0x48*/ object _lock;
            /*0x50*/ System.Net.ContextAwareResult.StateFlags _flags;

            /*0x7864604*/ ContextAwareResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x786460c*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x786465c*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x78645fc*/ void SafeCaptureIdentity();
            /*0x7864600*/ void CleanupInternal();
            /*0x78646d4*/ object StartPostingAsyncOp();
            /*0x78646dc*/ object StartPostingAsyncOp(bool lockCapture);
            /*0x78648a4*/ bool FinishPostingAsyncOp();
            /*0x7864cec*/ void Cleanup();
            /*0x78648e8*/ bool CaptureOrComplete(ref System.Threading.ExecutionContext cachedContext, bool returnContext);
            /*0x7864fb0*/ void Complete(nint userToken);
            /*0x786527c*/ void CompleteCallback();

            enum StateFlags
            {
                None = 0,
                CaptureIdentity = 1,
                CaptureContext = 2,
                ThreadSafeContextCopy = 4,
                PostBlockStarted = 8,
                PostBlockFinished = 16,
            }

            class <>c
            {
                static /*0x0*/ System.Net.ContextAwareResult.<> <>9;
                static /*0x8*/ System.Threading.ContextCallback <>9__17_0;

                static /*0x7865328*/ <>c();
                /*0x7865390*/ <>c();
                /*0x7865398*/ void <Complete>b__17_0(object s);
            }
        }

        class HttpStatusDescription
        {
            static /*0x7865418*/ string Get(System.Net.HttpStatusCode code);
            static /*0x786541c*/ string Get(int code);
        }

        class HttpValidationHelpers
        {
            static /*0x0*/ char[] s_httpTrimCharacters;

            static /*0x7865bb4*/ HttpValidationHelpers();
            static /*0x7865ab4*/ bool IsInvalidMethodOrHeaderString(string stringValue);
        }

        class NetEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Net.NetEventSource Log;

            static /*0x7866fc4*/ NetEventSource();
            static /*0x7865c54*/ void Enter(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x7866218*/ void Enter(object thisOrContextObject, object arg0, string memberName);
            static /*0x78666a8*/ void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName);
            static /*0x78667c4*/ void Exit(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x7866930*/ void Exit(object thisOrContextObject, object arg0, string memberName);
            static /*0x7864df0*/ void Info(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x7864ee0*/ void Info(object thisOrContextObject, object message, string memberName);
            static /*0x7866a7c*/ void Error(object thisOrContextObject, object message, string memberName);
            static /*0x78647d4*/ void Fail(object thisOrContextObject, object message, string memberName);
            static /*0x7866c44*/ void Associate(object first, object second, string memberName);
            static /*0x7864d8c*/ bool get_IsEnabled();
            static /*0x7865d44*/ string IdOf(object value);
            static /*0x7866fa8*/ int GetHashCode(object value);
            static /*0x7866300*/ object Format(object value);
            static /*0x7865e30*/ string Format(System.FormattableString s);
            /*0x7866fbc*/ NetEventSource();
            /*0x786619c*/ void Enter(string thisOrContextObject, string memberName, string parameters);
            /*0x78668b4*/ void Exit(string thisOrContextObject, string memberName, string result);
            /*0x7866a00*/ void Info(string thisOrContextObject, string memberName, string message);
            /*0x7866b4c*/ void ErrorMessage(string thisOrContextObject, string memberName, string message);
            /*0x7866bc8*/ void CriticalFailure(string thisOrContextObject, string memberName, string message);
            /*0x7866d14*/ void Associate(string thisOrContextObject, string memberName, string first, string second);
            /*0x7866d9c*/ void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4);

            class Keywords
            {
                static System.Diagnostics.Tracing.EventKeywords Default = 1;
                static System.Diagnostics.Tracing.EventKeywords Debug = 2;
                static System.Diagnostics.Tracing.EventKeywords EnterExit = 4;
            }
        }

        class TcpValidationHelpers
        {
            static /*0x786702c*/ bool ValidatePortNumber(int port);
        }

        class TlsStream : System.Net.Sockets.NetworkStream
        {
            /*0x48*/ System.Net.Security.SslStream _sslStream;
            /*0x50*/ string _host;
            /*0x58*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;

            /*0x7867038*/ TlsStream(System.Net.Sockets.NetworkStream stream, System.Net.Sockets.Socket socket, string host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates);
            /*0x7867128*/ void AuthenticateAsClient();
            /*0x7867228*/ System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object state);
            /*0x7867340*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
            /*0x7867364*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x7867388*/ void EndWrite(System.IAsyncResult result);
            /*0x78673ac*/ void Write(byte[] buffer, int offset, int size);
            /*0x78673d0*/ int Read(byte[] buffer, int offset, int size);
            /*0x78673f4*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x7867418*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x786743c*/ void Close();
        }

        enum HttpStatusCode
        {
            Continue = 100,
            SwitchingProtocols = 101,
            Processing = 102,
            EarlyHints = 103,
            OK = 200,
            Created = 201,
            Accepted = 202,
            NonAuthoritativeInformation = 203,
            NoContent = 204,
            ResetContent = 205,
            PartialContent = 206,
            MultiStatus = 207,
            AlreadyReported = 208,
            IMUsed = 226,
            MultipleChoices = 300,
            Ambiguous = 300,
            MovedPermanently = 301,
            Moved = 301,
            Found = 302,
            Redirect = 302,
            SeeOther = 303,
            RedirectMethod = 303,
            NotModified = 304,
            UseProxy = 305,
            Unused = 306,
            TemporaryRedirect = 307,
            RedirectKeepVerb = 307,
            PermanentRedirect = 308,
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404,
            MethodNotAllowed = 405,
            NotAcceptable = 406,
            ProxyAuthenticationRequired = 407,
            RequestTimeout = 408,
            Conflict = 409,
            Gone = 410,
            LengthRequired = 411,
            PreconditionFailed = 412,
            RequestEntityTooLarge = 413,
            RequestUriTooLong = 414,
            UnsupportedMediaType = 415,
            RequestedRangeNotSatisfiable = 416,
            ExpectationFailed = 417,
            MisdirectedRequest = 421,
            UnprocessableEntity = 422,
            Locked = 423,
            FailedDependency = 424,
            UpgradeRequired = 426,
            PreconditionRequired = 428,
            TooManyRequests = 429,
            RequestHeaderFieldsTooLarge = 431,
            UnavailableForLegalReasons = 451,
            InternalServerError = 500,
            NotImplemented = 501,
            BadGateway = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504,
            HttpVersionNotSupported = 505,
            VariantAlsoNegotiates = 506,
            InsufficientStorage = 507,
            LoopDetected = 508,
            NotExtended = 510,
            NetworkAuthenticationRequired = 511,
        }

        class HttpVersion
        {
            static /*0x0*/ System.Version Unknown;
            static /*0x8*/ System.Version Version10;
            static /*0x10*/ System.Version Version11;
            static /*0x18*/ System.Version Version20;

            static /*0x7867470*/ HttpVersion();
        }

        class IPAddress
        {
            static long LoopbackMask = 255;
            static int NumberOfLabels = 8;
            static /*0x0*/ System.Net.IPAddress Any;
            static /*0x8*/ System.Net.IPAddress Loopback;
            static /*0x10*/ System.Net.IPAddress Broadcast;
            static /*0x18*/ System.Net.IPAddress None;
            static /*0x20*/ System.Net.IPAddress IPv6Any;
            static /*0x28*/ System.Net.IPAddress IPv6Loopback;
            static /*0x30*/ System.Net.IPAddress IPv6None;
            /*0x10*/ uint _addressOrScopeId;
            /*0x18*/ ushort[] _numbers;
            /*0x20*/ string _toString;
            /*0x28*/ int _hashCode;

            static /*0x78688a0*/ IPAddress();
            static /*0x7867a30*/ bool TryParse(string ipString, ref System.Net.IPAddress address);
            static /*0x7867c80*/ System.Net.IPAddress Parse(string ipString);
            static /*0x78681d0*/ bool IsLoopback(System.Net.IPAddress address);
            static /*0x7867724*/ byte[] ThrowAddressNullException();
            /*0x786761c*/ IPAddress(long newAddress);
            /*0x78676a8*/ IPAddress(byte[] address, long scopeid);
            /*0x7867770*/ IPAddress(System.ReadOnlySpan<byte> address, long scopeid);
            /*0x786790c*/ IPAddress(ushort* numbers, int numbersLength, uint scopeid);
            /*0x78679e0*/ IPAddress(ushort[] numbers, uint scopeid);
            /*0x7867584*/ bool get_IsIPv4();
            /*0x7867594*/ bool get_IsIPv6();
            /*0x78675a4*/ uint get_PrivateAddress();
            /*0x78675ac*/ void set_PrivateAddress(uint value);
            /*0x78675e0*/ uint get_PrivateScopeId();
            /*0x78675e8*/ void set_PrivateScopeId(uint value);
            /*0x7867d18*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten);
            /*0x7867e24*/ void WriteIPv6Bytes(System.Span<byte> destination);
            /*0x7867eb0*/ void WriteIPv4Bytes(System.Span<byte> destination);
            /*0x7867efc*/ byte[] GetAddressBytes();
            /*0x7868044*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x786805c*/ long get_ScopeId();
            /*0x78680ac*/ string ToString();
            /*0x7868298*/ bool Equals(object comparandObj, bool compareScopeId);
            /*0x78683cc*/ bool Equals(object comparand);
            /*0x78683d4*/ int GetHashCode();
            /*0x78687c4*/ System.Net.IPAddress MapToIPv6();

            class ReadOnlyIPAddress : System.Net.IPAddress
            {
                /*0x7868a7c*/ ReadOnlyIPAddress(long newAddress);
            }
        }

        class IPAddressParser
        {
            static /*0x7867abc*/ System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipSpan, bool tryParse);
            static /*0x7868170*/ string IPv4AddressToString(uint address);
            static /*0x7868da4*/ void IPv4AddressToString(uint address, System.Text.StringBuilder destination);
            static /*0x7868d08*/ int IPv4AddressToStringHelper(uint address, char* addressString);
            static /*0x786815c*/ string IPv6AddressToString(ushort[] address, uint scopeId);
            static /*0x7868ecc*/ System.Text.StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId);
            static /*0x7868e14*/ void FormatIPv4AddressNumber(int number, char* addressString, ref int offset);
            static /*0x7868c58*/ bool Ipv4StringToAddress(System.ReadOnlySpan<char> ipSpan, ref long address);
            static /*0x7868ae0*/ bool Ipv6StringToAddress(System.ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, ref uint scope);
            static /*0x7868fec*/ void AppendSections(ushort[] address, int fromInclusive, int toExclusive, System.Text.StringBuilder buffer);
            static /*0x78691d4*/ void AppendHex(ushort value, System.Text.StringBuilder buffer);
            static /*0x78691a0*/ uint ExtractIPv4Address(ushort[] address);
            static /*0x786923c*/ ushort Reverse(ushort number);
        }

        class IPEndPoint : System.Net.EndPoint
        {
            static /*0x0*/ System.Net.IPEndPoint Any;
            static /*0x8*/ System.Net.IPEndPoint IPv6Any;
            /*0x10*/ System.Net.IPAddress _address;
            /*0x18*/ int _port;

            static /*0x786985c*/ IPEndPoint();
            /*0x7869274*/ IPEndPoint(System.Net.IPAddress address, int port);
            /*0x7869248*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x786933c*/ System.Net.IPAddress get_Address();
            /*0x7869344*/ int get_Port();
            /*0x786934c*/ string ToString();
            /*0x786940c*/ System.Net.SocketAddress Serialize();
            /*0x78694cc*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
            /*0x7869778*/ bool Equals(object comparand);
            /*0x786982c*/ int GetHashCode();
        }

        class CommandStream : System.Net.NetworkStreamWrapper
        {
            static /*0x0*/ System.AsyncCallback s_writeCallbackDelegate;
            static /*0x8*/ System.AsyncCallback s_readCallbackDelegate;
            /*0x38*/ bool _recoverableFailure;
            /*0x40*/ System.Net.WebRequest _request;
            /*0x48*/ bool _isAsync;
            /*0x49*/ bool _aborted;
            /*0x50*/ System.Net.CommandStream.PipelineEntry[] _commands;
            /*0x58*/ int _index;
            /*0x5c*/ bool _doRead;
            /*0x5d*/ bool _doSend;
            /*0x60*/ System.Net.ResponseDescription _currentResponseDescription;
            /*0x68*/ string _abortReason;
            /*0x70*/ string _buffer;
            /*0x78*/ System.Text.Encoding _encoding;
            /*0x80*/ System.Text.Decoder _decoder;

            static /*0x786b8cc*/ CommandStream();
            static /*0x786ac8c*/ void ReadCallback(System.IAsyncResult asyncResult);
            static /*0x786b4fc*/ void WriteCallback(System.IAsyncResult asyncResult);
            /*0x7869938*/ CommandStream(System.Net.Sockets.TcpClient client);
            /*0x7869a58*/ void Abort(System.Exception e);
            /*0x7869c70*/ void Dispose(bool disposing);
            /*0x7869d04*/ void InvokeRequestCallback(object obj);
            /*0x7869d84*/ bool get_RecoverableFailure();
            /*0x7869d8c*/ void MarkAsRecoverableFailure();
            /*0x7869da4*/ System.IO.Stream SubmitRequest(System.Net.WebRequest request, bool isAsync, bool readInitalResponseOnConnect);
            /*0x786a37c*/ void ClearState();
            /*0x786a38c*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest request);
            /*0x786a394*/ System.Exception GenerateException(string message, System.Net.WebExceptionStatus status, System.Exception innerException);
            /*0x786a420*/ System.Exception GenerateException(System.Net.FtpStatusCode code, string statusDescription, System.Exception innerException);
            /*0x7869e24*/ void InitCommandPipeline(System.Net.WebRequest request, System.Net.CommandStream.PipelineEntry[] commands, bool isAsync);
            /*0x786a4e0*/ void CheckContinuePipeline();
            /*0x7869ea4*/ System.IO.Stream ContinueCommandPipeline();
            /*0x786a5ac*/ bool PostSendCommandProcessing(ref System.IO.Stream stream);
            /*0x786aa30*/ bool PostReadCommandProcessing(ref System.IO.Stream stream);
            /*0x786ac84*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x786b7b0*/ System.Text.Encoding get_Encoding();
            /*0x786b7b8*/ void set_Encoding(System.Text.Encoding value);
            /*0x786b808*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x786a6ec*/ System.Net.ResponseDescription ReceiveCommandResponse();
            /*0x786af88*/ void ReceiveCommandResponseCallback(System.Net.ReceiveState state, int bytesRead);

            enum PipelineInstruction
            {
                Abort = 0,
                Advance = 1,
                Pause = 2,
                Reread = 3,
                GiveStream = 4,
            }

            enum PipelineEntryFlags
            {
                UserCommand = 1,
                GiveDataStream = 2,
                CreateDataConnection = 4,
                DontLogParameter = 8,
            }

            class PipelineEntry
            {
                /*0x10*/ string Command;
                /*0x18*/ System.Net.CommandStream.PipelineEntryFlags Flags;

                /*0x786b9b0*/ PipelineEntry(string command);
                /*0x786b9e0*/ PipelineEntry(string command, System.Net.CommandStream.PipelineEntryFlags flags);
                /*0x786a59c*/ bool HasFlag(System.Net.CommandStream.PipelineEntryFlags flags);
            }
        }

        class ResponseDescription
        {
            /*0x10*/ bool Multiline;
            /*0x14*/ int Status;
            /*0x18*/ string StatusDescription;
            /*0x20*/ System.Text.StringBuilder StatusBuffer;
            /*0x28*/ string StatusCodeString;

            /*0x786ba80*/ ResponseDescription();
            /*0x786ba1c*/ bool get_PositiveIntermediate();
            /*0x786ba30*/ bool get_PositiveCompletion();
            /*0x786ba44*/ bool get_TransientFailure();
            /*0x786ba58*/ bool get_PermanentFailure();
            /*0x786ba6c*/ bool get_InvalidStatusCode();
        }

        class ReceiveState
        {
            /*0x10*/ System.Net.ResponseDescription Resp;
            /*0x18*/ int ValidThrough;
            /*0x20*/ byte[] Buffer;
            /*0x28*/ System.Net.CommandStream Connection;

            /*0x786b810*/ ReceiveState(System.Net.CommandStream connection);
        }

        enum FtpLoginState
        {
            NotLoggedIn = 0,
            LoggedIn = 1,
            LoggedInButNeedsRelogin = 2,
            ReloginFailed = 3,
        }

        class FtpControlStream : System.Net.CommandStream
        {
            static /*0x0*/ System.AsyncCallback s_acceptCallbackDelegate;
            static /*0x8*/ System.AsyncCallback s_connectCallbackDelegate;
            static /*0x10*/ System.AsyncCallback s_SSLHandshakeCallback;
            /*0x88*/ System.Net.Sockets.Socket _dataSocket;
            /*0x90*/ System.Net.IPEndPoint _passiveEndPoint;
            /*0x98*/ System.Net.TlsStream _tlsStream;
            /*0xa0*/ System.Text.StringBuilder _bannerMessage;
            /*0xa8*/ System.Text.StringBuilder _welcomeMessage;
            /*0xb0*/ System.Text.StringBuilder _exitMessage;
            /*0xb8*/ System.WeakReference _credentials;
            /*0xc0*/ string _currentTypeSetting;
            /*0xc8*/ long _contentLength;
            /*0xd0*/ System.DateTime _lastModified;
            /*0xd8*/ bool _dataHandshakeStarted;
            /*0xe0*/ string _loginDirectory;
            /*0xe8*/ string _establishedServerDirectory;
            /*0xf0*/ string _requestedServerDirectory;
            /*0xf8*/ System.Uri _responseUri;
            /*0x100*/ System.Net.FtpLoginState _loginState;
            /*0x104*/ System.Net.FtpStatusCode StatusCode;
            /*0x108*/ string StatusLine;

            static /*0x78704e0*/ FtpControlStream();
            static /*0x786bd44*/ void AcceptCallback(System.IAsyncResult asyncResult);
            static /*0x786c15c*/ void ConnectCallback(System.IAsyncResult asyncResult);
            static /*0x786c30c*/ void SSLHandshakeCallback(System.IAsyncResult asyncResult);
            static /*0x786f484*/ void GetPathInfo(System.Net.FtpControlStream.GetPathOption pathOption, System.Uri uri, ref string path, ref string directory, ref string filename);
            /*0x786bc28*/ FtpControlStream(System.Net.Sockets.TcpClient client);
            /*0x786baf4*/ System.Net.NetworkCredential get_Credentials();
            /*0x786bb9c*/ void set_Credentials(System.Net.NetworkCredential value);
            /*0x786bcb8*/ void AbortConnect();
            /*0x786c4d0*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref System.IO.Stream stream);
            /*0x786caa8*/ void ClearState();
            /*0x786cb78*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x786e460*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest req);
            /*0x786d404*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateDataConection(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream, ref bool isSocketReady);
            /*0x786fe64*/ string FormatAddress(System.Net.IPAddress address, int Port);
            /*0x786ff8c*/ string FormatAddressV6(System.Net.IPAddress address, int port);
            /*0x787009c*/ long get_ContentLength();
            /*0x78700a4*/ System.DateTime get_LastModified();
            /*0x78700ac*/ System.Uri get_ResponseUri();
            /*0x78700b4*/ string get_BannerMessage();
            /*0x78700cc*/ string get_WelcomeMessage();
            /*0x78700e4*/ string get_ExitMessage();
            /*0x786df10*/ long GetContentLengthFrom213Response(string responseString);
            /*0x786e048*/ System.DateTime GetLastModifiedFrom213Response(string str);
            /*0x786dba4*/ void TryUpdateResponseUri(string str, System.Net.FtpWebRequest request);
            /*0x786daac*/ void TryUpdateContentLength(string str);
            /*0x786e3d0*/ string GetLoginDirectory(string str);
            /*0x786f9c4*/ int GetPortV4(string responseString);
            /*0x786fba0*/ int GetPortV6(string responseString);
            /*0x786f658*/ void CreateFtpListenerSocket(System.Net.FtpWebRequest request);
            /*0x786f7dc*/ string GetPortCommandLine(System.Net.FtpWebRequest request);
            /*0x786f360*/ string FormatFtpCommand(string command, string parameter);
            /*0x786fd58*/ System.Net.Sockets.Socket CreateFtpDataSocket(System.Net.FtpWebRequest request, System.Net.Sockets.Socket templateSocket);
            /*0x78700fc*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x786c798*/ System.Net.TriState IsFtpDataStreamWriteable();

            enum GetPathOption
            {
                Normal = 0,
                AssumeFilename = 1,
                AssumeNoFilename = 2,
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ System.Net.FtpControlStream <>4__this;
                /*0x18*/ System.Net.TlsStream tlsStream;

                /*0x786d3fc*/ <>c__DisplayClass31_0();
                /*0x7870610*/ void <PipelineCallback>b__0(System.IAsyncResult ar);
            }
        }

        class FtpDataStream : System.IO.Stream, System.Net.ICloseEx
        {
            /*0x28*/ System.Net.FtpWebRequest _request;
            /*0x30*/ System.Net.Sockets.NetworkStream _networkStream;
            /*0x38*/ bool _writeable;
            /*0x39*/ bool _readable;
            /*0x3a*/ bool _isFullyRead;
            /*0x3b*/ bool _closing;

            /*0x786c81c*/ FtpDataStream(System.Net.Sockets.NetworkStream networkStream, System.Net.FtpWebRequest request, System.Net.TriState writeOnly);
            /*0x787071c*/ void Dispose(bool disposing);
            /*0x78708a4*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x7870c8c*/ void CheckError();
            /*0x7870ccc*/ bool get_CanRead();
            /*0x7870cd4*/ bool get_CanSeek();
            /*0x7870cf4*/ bool get_CanWrite();
            /*0x7870cfc*/ long get_Length();
            /*0x7870d1c*/ long get_Position();
            /*0x7870d40*/ void set_Position(long value);
            /*0x7870d64*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x7870e30*/ int Read(byte[] buffer, int offset, int size);
            /*0x7870f34*/ void Write(byte[] buffer, int offset, int size);
            /*0x787100c*/ void AsyncReadCallback(System.IAsyncResult ar);
            /*0x78712a8*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x7871440*/ int EndRead(System.IAsyncResult ar);
            /*0x78715d4*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x78716c8*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x7871768*/ void Flush();
            /*0x787178c*/ void SetLength(long value);
            /*0x78717b0*/ bool get_CanTimeout();
            /*0x78717d0*/ int get_ReadTimeout();
            /*0x78717f4*/ void set_ReadTimeout(int value);
            /*0x7871818*/ int get_WriteTimeout();
            /*0x787183c*/ void set_WriteTimeout(int value);
            /*0x7871860*/ void SetSocketTimeoutOption(int timeout);
        }

        enum FtpOperation
        {
            DownloadFile = 0,
            ListDirectory = 1,
            ListDirectoryDetails = 2,
            UploadFile = 3,
            UploadFileUnique = 4,
            AppendFile = 5,
            DeleteFile = 6,
            GetDateTimestamp = 7,
            GetFileSize = 8,
            Rename = 9,
            MakeDirectory = 10,
            RemoveDirectory = 11,
            PrintWorkingDirectory = 12,
            Other = 13,
        }

        enum FtpMethodFlags
        {
            None = 0,
            IsDownload = 1,
            IsUpload = 2,
            TakesParameter = 4,
            MayTakeParameter = 8,
            DoesNotTakeParameter = 16,
            ParameterIsDirectory = 32,
            ShouldParseForResponseUri = 64,
            HasHttpCommand = 128,
            MustChangeWorkingDirectoryToPath = 256,
        }

        class FtpMethodInfo
        {
            static /*0x0*/ System.Net.FtpMethodInfo[] s_knownMethodInfo;
            /*0x10*/ string Method;
            /*0x18*/ System.Net.FtpOperation Operation;
            /*0x1c*/ System.Net.FtpMethodFlags Flags;
            /*0x20*/ string HttpCommand;

            static /*0x7871a68*/ FtpMethodInfo();
            static /*0x7871908*/ System.Net.FtpMethodInfo GetMethodInfo(string method);
            /*0x78718b0*/ FtpMethodInfo(string method, System.Net.FtpOperation operation, System.Net.FtpMethodFlags flags, string httpCommand);
            /*0x786f474*/ bool HasFlag(System.Net.FtpMethodFlags flags);
            /*0x786f648*/ bool get_IsCommandOnly();
            /*0x78704c8*/ bool get_IsUpload();
            /*0x78704d4*/ bool get_IsDownload();
            /*0x786db98*/ bool get_ShouldParseForResponseUri();
        }

        class FtpWebRequest : System.Net.WebRequest
        {
            static /*0x0*/ System.Net.NetworkCredential s_defaultFtpNetworkCredential;
            static /*0x8*/ System.Net.TimerThread.Queue s_DefaultTimerQueue;
            /*0x38*/ object _syncObject;
            /*0x40*/ System.Net.ICredentials _authInfo;
            /*0x48*/ System.Uri _uri;
            /*0x50*/ System.Net.FtpMethodInfo _methodInfo;
            /*0x58*/ string _renameTo;
            /*0x60*/ bool _getRequestStreamStarted;
            /*0x61*/ bool _getResponseStarted;
            /*0x68*/ System.DateTime _startTime;
            /*0x70*/ int _timeout;
            /*0x74*/ int _remainingTimeout;
            /*0x78*/ long _contentLength;
            /*0x80*/ long _contentOffset;
            /*0x88*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;
            /*0x90*/ bool _passive;
            /*0x91*/ bool _binary;
            /*0x92*/ bool _async;
            /*0x93*/ bool _aborted;
            /*0x94*/ bool _timedOut;
            /*0x98*/ System.Exception _exception;
            /*0xa0*/ System.Net.TimerThread.Queue _timerQueue;
            /*0xa8*/ System.Net.TimerThread.Callback _timerCallback;
            /*0xb0*/ bool _enableSsl;
            /*0xb8*/ System.Net.FtpControlStream _connection;
            /*0xc0*/ System.IO.Stream _stream;
            /*0xc8*/ System.Net.FtpWebRequest.RequestStage _requestStage;
            /*0xcc*/ bool _onceFailed;
            /*0xd0*/ System.Net.WebHeaderCollection _ftpRequestHeaders;
            /*0xd8*/ System.Net.FtpWebResponse _ftpWebResponse;
            /*0xe0*/ int _readWriteTimeout;
            /*0xe8*/ System.Net.ContextAwareResult _writeAsyncResult;
            /*0xf0*/ System.Net.LazyAsyncResult _readAsyncResult;
            /*0xf8*/ System.Net.LazyAsyncResult _requestCompleteAsyncResult;

            static /*0x7877af4*/ FtpWebRequest();
            /*0x7872444*/ FtpWebRequest(System.Uri uri);
            /*0x787205c*/ System.Net.FtpMethodInfo get_MethodInfo();
            /*0x7872064*/ string get_Method();
            /*0x7872080*/ void set_Method(string value);
            /*0x7872244*/ string get_RenameTo();
            /*0x787224c*/ System.Net.ICredentials get_Credentials();
            /*0x7872254*/ void set_Credentials(System.Net.ICredentials value);
            /*0x78723a0*/ System.Uri get_RequestUri();
            /*0x78723a8*/ int get_Timeout();
            /*0x78723b0*/ int get_RemainingTimeout();
            /*0x78723b8*/ int get_ReadWriteTimeout();
            /*0x78723c0*/ long get_ContentOffset();
            /*0x78723c8*/ long get_ContentLength();
            /*0x78723d0*/ System.Net.IWebProxy get_Proxy();
            /*0x78723d8*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x787243c*/ bool get_Aborted();
            /*0x787286c*/ System.Net.WebResponse GetResponse();
            /*0x78742dc*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x78749b0*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x7874db0*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x78752f8*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x78734d0*/ void SubmitRequest(bool isAsync);
            /*0x787607c*/ System.Exception TranslateConnectException(System.Exception e);
            /*0x787575c*/ void CreateConnectionAsync();
            /*0x7875808*/ System.Net.FtpControlStream CreateConnection();
            /*0x78759bc*/ System.IO.Stream TimedSubmitRequestHelper(bool isAsync);
            /*0x78761fc*/ void TimerCallback(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            /*0x787617c*/ System.Net.TimerThread.Queue get_TimerQueue();
            /*0x7875de8*/ bool AttemptedRecovery(System.Exception e);
            /*0x7873f18*/ void SetException(System.Exception exception);
            /*0x7873000*/ void CheckError();
            /*0x7869d74*/ void RequestCallback(object obj);
            /*0x7876de4*/ void SyncRequestCallback(object obj);
            /*0x7876340*/ void AsyncRequestCallback(object obj);
            /*0x787308c*/ System.Net.FtpWebRequest.RequestStage FinishRequestStage(System.Net.FtpWebRequest.RequestStage stage);
            /*0x78771d8*/ void Abort();
            /*0x787767c*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x78776e0*/ bool get_UseBinary();
            /*0x78776e8*/ bool get_UsePassive();
            /*0x786c9ac*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x78776f0*/ bool get_EnableSsl();
            /*0x78776f8*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78777c8*/ bool get_UseDefaultCredentials();
            /*0x787222c*/ bool get_InUse();
            /*0x7873a14*/ void EnsureFtpWebResponse(System.Exception exception);
            /*0x7877a78*/ void DataStreamClosed(System.Net.CloseExState closeState);

            enum RequestStage
            {
                CheckForError = 0,
                RequestStarted = 1,
                WriteReady = 2,
                ReadReady = 3,
                ReleaseConnection = 4,
            }

            struct <CreateConnectionAsync>d__86 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.FtpWebRequest <>4__this;
                /*0x40*/ System.Net.Sockets.TcpClient <client>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x7877c74*/ void MoveNext();
                /*0x7877fb8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c
            {
                static /*0x0*/ System.Net.FtpWebRequest.<> <>9;
                static /*0x8*/ System.Func<System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0;

                static /*0x7877fc4*/ <>c();
                /*0x787802c*/ <>c();
                /*0x7878034*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <get_ClientCertificates>b__114_0();
            }
        }

        class FtpWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x7878088*/ FtpWebRequestCreator();
            /*0x7878090*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FtpWebResponse : System.Net.WebResponse, System.IDisposable
        {
            /*0x20*/ System.IO.Stream _responseStream;
            /*0x28*/ long _contentLength;
            /*0x30*/ System.Uri _responseUri;
            /*0x38*/ System.Net.FtpStatusCode _statusCode;
            /*0x40*/ string _statusLine;
            /*0x48*/ System.Net.WebHeaderCollection _ftpRequestHeaders;
            /*0x50*/ System.DateTime _lastModified;
            /*0x58*/ string _bannerMessage;
            /*0x60*/ string _welcomeMessage;
            /*0x68*/ string _exitMessage;

            /*0x7877914*/ FtpWebResponse(System.IO.Stream responseStream, long contentLength, System.Uri responseUri, System.Net.FtpStatusCode statusCode, string statusLine, System.DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage);
            /*0x7876308*/ void UpdateStatus(System.Net.FtpStatusCode statusCode, string statusLine, string exitMessage);
            /*0x78780e8*/ System.IO.Stream GetResponseStream();
            /*0x787786c*/ void SetResponseStream(System.IO.Stream stream);
            /*0x78781f0*/ void Close();
            /*0x78782d4*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78783ec*/ System.Uri get_ResponseUri();
            /*0x78783f4*/ System.Net.FtpStatusCode get_StatusCode();

            class EmptyStream : System.IO.MemoryStream
            {
                /*0x7878154*/ EmptyStream();
            }
        }

        class NetworkStreamWrapper : System.IO.Stream
        {
            /*0x28*/ System.Net.Sockets.TcpClient _client;
            /*0x30*/ System.Net.Sockets.NetworkStream _networkStream;

            /*0x78699c0*/ NetworkStreamWrapper(System.Net.Sockets.TcpClient client);
            /*0x786c930*/ bool get_UsingSecureStream();
            /*0x786c0b4*/ System.Net.IPAddress get_ServerAddress();
            /*0x786def4*/ System.Net.Sockets.Socket get_Socket();
            /*0x78783fc*/ System.Net.Sockets.NetworkStream get_NetworkStream();
            /*0x7878404*/ void set_NetworkStream(System.Net.Sockets.NetworkStream value);
            /*0x787840c*/ bool get_CanRead();
            /*0x787842c*/ bool get_CanSeek();
            /*0x787844c*/ bool get_CanWrite();
            /*0x787846c*/ bool get_CanTimeout();
            /*0x787848c*/ int get_ReadTimeout();
            /*0x78784b0*/ void set_ReadTimeout(int value);
            /*0x78784d4*/ int get_WriteTimeout();
            /*0x78784f8*/ void set_WriteTimeout(int value);
            /*0x787851c*/ long get_Length();
            /*0x787853c*/ long get_Position();
            /*0x7878560*/ void set_Position(long value);
            /*0x7878584*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x78785a8*/ int Read(byte[] buffer, int offset, int size);
            /*0x78785cc*/ void Write(byte[] buffer, int offset, int size);
            /*0x78785f0*/ void Dispose(bool disposing);
            /*0x786af50*/ void CloseSocket();
            /*0x7869c40*/ void Close(int timeout);
            /*0x787869c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x78786c0*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x78786e4*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x7878708*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x787872c*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x7878750*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x7878774*/ void Flush();
            /*0x7878798*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x78787bc*/ void SetLength(long value);
            /*0x787596c*/ void SetSocketTimeoutOption(int timeout);
        }

        enum SecurityProtocolType
        {
            SystemDefault = 0,
            Ssl3 = 48,
            Tls = 192,
            Tls11 = 768,
            Tls12 = 3072,
            Tls13 = 12288,
        }

        class Authorization
        {
            /*0x10*/ string m_Message;
            /*0x18*/ bool m_Complete;
            /*0x20*/ string ModuleAuthenticationType;

            /*0x78787e0*/ Authorization(string token);
            /*0x787888c*/ Authorization(string token, bool finished);
            /*0x7878928*/ string get_Message();
            /*0x7878930*/ bool get_Complete();
        }

        class CredentialCache
        {
            static /*0x7878938*/ System.Net.ICredentials get_DefaultCredentials();
            static /*0x7878990*/ System.Net.NetworkCredential get_DefaultNetworkCredentials();
        }

        class SystemNetworkCredential : System.Net.NetworkCredential
        {
            static /*0x0*/ System.Net.SystemNetworkCredential defaultCredential;

            static /*0x7878a08*/ SystemNetworkCredential();
            /*0x78789e8*/ SystemNetworkCredential();
        }

        class EndPoint
        {
            /*0x7869334*/ EndPoint();
            /*0x7878a88*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x7878b2c*/ System.Net.SocketAddress Serialize();
            /*0x7878bd0*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
        }

        enum FtpStatusCode
        {
            Undefined = 0,
            RestartMarker = 110,
            ServiceTemporarilyNotAvailable = 120,
            DataAlreadyOpen = 125,
            OpeningData = 150,
            CommandOK = 200,
            CommandExtraneous = 202,
            DirectoryStatus = 212,
            FileStatus = 213,
            SystemType = 215,
            SendUserCommand = 220,
            ClosingControl = 221,
            ClosingData = 226,
            EnteringPassive = 227,
            LoggedInProceed = 230,
            ServerWantsSecureSession = 234,
            FileActionOK = 250,
            PathnameCreated = 257,
            SendPasswordCommand = 331,
            NeedLoginAccount = 332,
            FileCommandPending = 350,
            ServiceNotAvailable = 421,
            CantOpenData = 425,
            ConnectionClosed = 426,
            ActionNotTakenFileUnavailableOrBusy = 450,
            ActionAbortedLocalProcessingError = 451,
            ActionNotTakenInsufficientSpace = 452,
            CommandSyntaxError = 500,
            ArgumentSyntaxError = 501,
            CommandNotImplemented = 502,
            BadCommandSequence = 503,
            NotLoggedIn = 530,
            AccountNeeded = 532,
            ActionNotTakenFileUnavailable = 550,
            ActionAbortedUnknownPageType = 551,
            FileActionAborted = 552,
            ActionNotTakenFilenameNotAllowed = 553,
        }

        enum HttpRequestHeader
        {
            CacheControl = 0,
            Connection = 1,
            Date = 2,
            KeepAlive = 3,
            Pragma = 4,
            Trailer = 5,
            TransferEncoding = 6,
            Upgrade = 7,
            Via = 8,
            Warning = 9,
            Allow = 10,
            ContentLength = 11,
            ContentType = 12,
            ContentEncoding = 13,
            ContentLanguage = 14,
            ContentLocation = 15,
            ContentMd5 = 16,
            ContentRange = 17,
            Expires = 18,
            LastModified = 19,
            Accept = 20,
            AcceptCharset = 21,
            AcceptEncoding = 22,
            AcceptLanguage = 23,
            Authorization = 24,
            Cookie = 25,
            Expect = 26,
            From = 27,
            Host = 28,
            IfMatch = 29,
            IfModifiedSince = 30,
            IfNoneMatch = 31,
            IfRange = 32,
            IfUnmodifiedSince = 33,
            MaxForwards = 34,
            ProxyAuthorization = 35,
            Referer = 36,
            Range = 37,
            Te = 38,
            Translate = 39,
            UserAgent = 40,
        }

        interface IAuthenticationModule
        {
            /*0x380bd40*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            /*0x380bcbc*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
            /*0x380b9e8*/ string get_AuthenticationType();
        }

        interface ICertificatePolicy
        {
            bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
        }

        interface ICredentials
        {
            /*0x380bcbc*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class IPHostEntry
        {
            /*0x10*/ string hostName;
            /*0x18*/ string[] aliases;
            /*0x20*/ System.Net.IPAddress[] addressList;
            /*0x28*/ bool isTrustedHost;

            /*0x7878c1c*/ IPHostEntry();
            /*0x7878bf4*/ string get_HostName();
            /*0x7878bfc*/ void set_HostName(string value);
            /*0x7878c04*/ void set_Aliases(string[] value);
            /*0x7878c0c*/ System.Net.IPAddress[] get_AddressList();
            /*0x7878c14*/ void set_AddressList(System.Net.IPAddress[] value);
        }

        interface IWebRequestCreate
        {
            /*0x380bb68*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class InternalException : System.SystemException
        {
            /*0x786a594*/ InternalException();
        }

        class NclUtilities
        {
            static /*0x0*/ System.Net.IPAddress[] _LocalAddresses;
            static /*0x8*/ object _LocalAddressesLock;
            static /*0x10*/ string _LocalDomainName;

            static /*0x7878c2c*/ bool IsFatal(System.Exception exception);
            static /*0x7878cec*/ bool IsAddressLocal(System.Net.IPAddress ipAddress);
            static /*0x787925c*/ System.Net.IPHostEntry GetLocalHost();
            static /*0x7878d78*/ System.Net.IPAddress[] get_LocalAddresses();
            static /*0x7879274*/ object get_LocalAddressesLock();
        }

        class ValidationHelper
        {
            static /*0x0*/ string[] EmptyArray;
            static /*0x8*/ char[] InvalidMethodChars;
            static /*0x10*/ char[] InvalidParamChars;

            static /*0x7879338*/ ValidationHelper();
            static /*0x7878878*/ string MakeStringNull(string stringValue);
            static /*0x7879310*/ bool IsBlankString(string stringValue);
            static /*0x787932c*/ bool ValidateTcpPort(int port);
        }

        class ExceptionHelper
        {
            static /*0x7878b50*/ System.NotImplementedException get_MethodNotImplementedException();
            static /*0x7878aac*/ System.NotImplementedException get_PropertyNotImplementedException();
            static /*0x7873014*/ System.Net.WebException get_TimeoutException();
            static /*0x78777ec*/ System.NotSupportedException get_PropertyNotSupportedException();
            static /*0x786fdd4*/ System.Net.WebException get_RequestAbortedException();
        }

        class WebRequestPrefixElement
        {
            /*0x10*/ string Prefix;
            /*0x18*/ System.Net.IWebRequestCreate creator;
            /*0x20*/ System.Type creatorType;

            /*0x7879668*/ WebRequestPrefixElement(string P, System.Net.IWebRequestCreate C);
            /*0x7879458*/ System.Net.IWebRequestCreate get_Creator();
            /*0x7879660*/ void set_Creator(System.Net.IWebRequestCreate value);
        }

        class HttpContinueDelegate : System.MulticastDelegate
        {
            /*0x78796ac*/ HttpContinueDelegate(object object, nint method);
            /*0x787974c*/ void Invoke(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
        }

        class KnownHttpVerb
        {
            static /*0x0*/ System.Collections.Specialized.ListDictionary NamedHeaders;
            static /*0x8*/ System.Net.KnownHttpVerb Get;
            static /*0x10*/ System.Net.KnownHttpVerb Connect;
            static /*0x18*/ System.Net.KnownHttpVerb Head;
            static /*0x20*/ System.Net.KnownHttpVerb Put;
            static /*0x28*/ System.Net.KnownHttpVerb Post;
            static /*0x30*/ System.Net.KnownHttpVerb MkCol;
            /*0x10*/ string Name;
            /*0x18*/ bool RequireContentBody;
            /*0x19*/ bool ContentBodyNotAllowed;
            /*0x1a*/ bool ConnectRequest;
            /*0x1b*/ bool ExpectNoContentResponse;

            static /*0x78797c4*/ KnownHttpVerb();
            static /*0x7879b74*/ System.Net.KnownHttpVerb Parse(string name);
            /*0x7879760*/ KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse);
        }

        enum TriState
        {
            Unspecified = -1,
            False = 0,
            True = 1,
        }

        class NetworkCredential : System.Net.ICredentials
        {
            /*0x10*/ string m_domain;
            /*0x18*/ string m_userName;
            /*0x20*/ System.Security.SecureString m_password;

            /*0x7872854*/ NetworkCredential(string userName, string password);
            /*0x7877c10*/ NetworkCredential(string userName, string password, string domain);
            /*0x786f458*/ string get_UserName();
            /*0x7879c44*/ void set_UserName(string value);
            /*0x786f468*/ string get_Password();
            /*0x7879c64*/ void set_Password(string value);
            /*0x786f460*/ string get_Domain();
            /*0x7879c8c*/ void set_Domain(string value);
            /*0x7879cb8*/ string InternalGetUserName();
            /*0x7879cac*/ string InternalGetPassword();
            /*0x7879cc0*/ string InternalGetDomain();
            /*0x7879cc8*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x7879ccc*/ ProtocolViolationException();
            /*0x78752f0*/ ProtocolViolationException(string message);
            /*0x7879cd4*/ ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7879cdc*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7879ce4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class SocketAddress
        {
            /*0x10*/ int m_Size;
            /*0x18*/ byte[] m_Buffer;
            /*0x20*/ bool m_changed;
            /*0x24*/ int m_hash;

            /*0x7879d68*/ SocketAddress(System.Net.Sockets.AddressFamily family, int size);
            /*0x7879e94*/ SocketAddress(System.Net.IPAddress ipAddress);
            /*0x7869470*/ SocketAddress(System.Net.IPAddress ipaddress, int port);
            /*0x78696b0*/ System.Net.Sockets.AddressFamily get_Family();
            /*0x7879cec*/ int get_Size();
            /*0x7879cf4*/ byte get_Item(int offset);
            /*0x787a0ec*/ System.Net.IPAddress GetIPAddress();
            /*0x78696e0*/ System.Net.IPEndPoint GetIPEndPoint();
            /*0x787a2d0*/ bool Equals(object comparand);
            /*0x787a3bc*/ int GetHashCode();
            /*0x787a4ec*/ string ToString();
        }

        class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x8c*/ System.Net.WebExceptionStatus m_Status;
            /*0x90*/ System.Net.WebResponse m_Response;
            /*0x98*/ System.Net.WebExceptionInternalStatus m_InternalStatus;

            /*0x787a77c*/ WebException();
            /*0x786ac70*/ WebException(string message);
            /*0x78762f8*/ WebException(string message, System.Exception innerException);
            /*0x786c148*/ WebException(string message, System.Net.WebExceptionStatus status);
            /*0x787a78c*/ WebException(string message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException);
            /*0x786a40c*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x787a7c0*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x787a7a8*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x787a8a8*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x787a9a4*/ WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787a9b4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787a9c0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787a9c8*/ System.Net.WebExceptionStatus get_Status();
            /*0x787a9d0*/ System.Net.WebResponse get_Response();
        }

        enum WebExceptionInternalStatus
        {
            RequestFatal = 0,
            ServicePointFatal = 1,
            Recoverable = 2,
            Isolated = 3,
        }

        enum WebExceptionStatus
        {
            Success = 0,
            NameResolutionFailure = 1,
            ConnectFailure = 2,
            ReceiveFailure = 3,
            SendFailure = 4,
            PipelineFailure = 5,
            RequestCanceled = 6,
            ProtocolError = 7,
            ConnectionClosed = 8,
            TrustFailure = 9,
            SecureChannelFailure = 10,
            ServerProtocolViolation = 11,
            KeepAliveFailure = 12,
            Pending = 13,
            Timeout = 14,
            ProxyNameResolutionFailure = 15,
            UnknownError = 16,
            MessageLengthLimitExceeded = 17,
            CacheEntryNotFound = 18,
            RequestProhibitedByCachePolicy = 19,
            RequestProhibitedByProxy = 20,
        }

        class WebExceptionMapping
        {
            static /*0x0*/ string[] s_Mapping;

            static /*0x787ab74*/ WebExceptionMapping();
            static /*0x787a9d8*/ string GetWebStatusString(System.Net.WebExceptionStatus status);
        }

        enum WebHeaderCollectionType
        {
            Unknown = 0,
            WebRequest = 1,
            WebResponse = 2,
            HttpWebRequest = 3,
            HttpWebResponse = 4,
            HttpListenerRequest = 5,
            HttpListenerResponse = 6,
            FtpWebRequest = 7,
            FtpWebResponse = 8,
            FileWebRequest = 9,
            FileWebResponse = 10,
        }

        class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ System.Net.HeaderInfoTable HInfo;
            static /*0x8*/ string[] s_CommonHeaderNames;
            static /*0x10*/ sbyte[] s_CommonHeaderHints;
            static /*0x18*/ char[] HttpTrimCharacters;
            static /*0x20*/ System.Net.WebHeaderCollection.RfcChar[] RfcCharMap;
            /*0x60*/ string[] m_CommonHeaders;
            /*0x68*/ int m_NumCommonHeaders;
            /*0x70*/ System.Collections.Specialized.NameValueCollection m_InnerCollection;
            /*0x78*/ System.Net.WebHeaderCollectionType m_Type;

            static /*0x787cdb4*/ WebHeaderCollection();
            static /*0x787ada8*/ bool AllowMultiValues(string name);
            static /*0x787b088*/ string CheckBadChars(string name, bool isHeaderValue);
            static /*0x787b418*/ bool ContainsNonAsciiChars(string token);
            static /*0x787c26c*/ string GetAsString(System.Collections.Specialized.NameValueCollection cc, bool winInetCompat, bool forTrace);
            /*0x7877764*/ WebHeaderCollection();
            /*0x787c50c*/ WebHeaderCollection(System.Net.WebHeaderCollectionType type);
            /*0x787c608*/ WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787abe8*/ void NormalizeCommonHeaders();
            /*0x787ad00*/ System.Collections.Specialized.NameValueCollection get_InnerCollection();
            /*0x787ae54*/ bool get_AllowHttpRequestHeader();
            /*0x787ae94*/ void Remove(System.Net.HttpRequestHeader header);
            /*0x787af84*/ void AddInternal(string name, string value);
            /*0x787afd8*/ void ChangeInternal(string name, string value);
            /*0x787b02c*/ void RemoveInternal(string name);
            /*0x787b49c*/ void ThrowOnRestrictedHeader(string headerName);
            /*0x787b610*/ void Add(string name, string value);
            /*0x787b7c0*/ void Add(string header);
            /*0x787ba90*/ void Set(string name, string value);
            /*0x787bcb8*/ void SetInternal(string name, string value);
            /*0x787bed4*/ void Remove(string name);
            /*0x787c00c*/ string[] GetValues(string header);
            /*0x787c210*/ string ToString();
            /*0x787c7d4*/ void OnDeserialization(object sender);
            /*0x787c7d8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787c958*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787c964*/ string Get(string name);
            /*0x787cc90*/ System.Collections.IEnumerator GetEnumerator();
            /*0x787cd04*/ int get_Count();
            /*0x787cd34*/ string Get(int index);
            /*0x787cd74*/ string GetKey(int index);

            enum RfcChar
            {
                High = 0,
                Reg = 1,
                Ctl = 2,
                CR = 3,
                LF = 4,
                WS = 5,
                Colon = 6,
                Delim = 7,
            }
        }

        class CaseInsensitiveAscii : System.Collections.IEqualityComparer, System.Collections.IComparer
        {
            static /*0x0*/ System.Net.CaseInsensitiveAscii StaticInstance;
            static /*0x8*/ byte[] AsciiToLower;

            static /*0x787d844*/ CaseInsensitiveAscii();
            /*0x787d83c*/ CaseInsensitiveAscii();
            /*0x787d368*/ int GetHashCode(object myObject);
            /*0x787d474*/ int Compare(object firstObject, object secondObject);
            /*0x787d5d8*/ int FastGetHashCode(string myString);
            /*0x787d6c8*/ bool Equals(object firstObject, object secondObject);
        }

        class WebRequest : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ System.Collections.ArrayList s_PrefixList;
            static /*0x8*/ object s_InternalSyncObject;
            static /*0x10*/ System.Net.TimerThread.Queue s_DefaultTimerQueue;
            static /*0x18*/ System.Net.WebRequest.DesignerWebRequestCreate webRequestCreate;
            static /*0x20*/ System.Net.IWebProxy s_DefaultWebProxy;
            static /*0x28*/ bool s_DefaultWebProxyInitialized;
            /*0x18*/ System.Net.Security.AuthenticationLevel m_AuthenticationLevel;
            /*0x1c*/ System.Security.Principal.TokenImpersonationLevel m_ImpersonationLevel;
            /*0x20*/ System.Net.Cache.RequestCachePolicy m_CachePolicy;
            /*0x28*/ System.Net.Cache.RequestCacheProtocol m_CacheProtocol;
            /*0x30*/ System.Net.Cache.RequestCacheBinding m_CacheBinding;

            static /*0x787eaf0*/ WebRequest();
            static /*0x787d90c*/ object get_InternalSyncObject();
            static /*0x787d9d8*/ System.Net.WebRequest Create(System.Uri requestUri, bool useUriBase);
            static /*0x787dde4*/ System.Net.WebRequest Create(string requestUriString);
            static /*0x787deb4*/ System.Net.WebRequest Create(System.Uri requestUri);
            static /*0x787dc48*/ System.Collections.ArrayList get_PrefixList();
            static /*0x787df8c*/ System.Collections.ArrayList PopulatePrefixList();
            static /*0x787e870*/ System.Net.IWebProxy get_InternalDefaultWebProxy();
            static /*0x787ea40*/ System.Net.IWebProxy GetSystemWebProxy();
            static /*0x787ea8c*/ System.Net.IWebProxy InternalGetSystemWebProxy();
            /*0x787e1b4*/ WebRequest();
            /*0x787e1d8*/ WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787e1e0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787e1ec*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787e1f0*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x787e1f4*/ void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy);
            /*0x787e2c4*/ string get_Method();
            /*0x787e2ec*/ void set_Method(string value);
            /*0x787e314*/ System.Uri get_RequestUri();
            /*0x787e33c*/ System.Net.WebHeaderCollection get_Headers();
            /*0x787e364*/ long get_ContentLength();
            /*0x787e38c*/ System.Net.ICredentials get_Credentials();
            /*0x787e3b4*/ void set_Credentials(System.Net.ICredentials value);
            /*0x787e3dc*/ bool get_UseDefaultCredentials();
            /*0x787e404*/ System.Net.IWebProxy get_Proxy();
            /*0x787e42c*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x787e454*/ int get_Timeout();
            /*0x787e47c*/ System.Net.WebResponse GetResponse();
            /*0x787e4a4*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x787e4cc*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x787e4f4*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x787e51c*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x787e544*/ System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync();
            /*0x787e7e8*/ System.Security.Principal.WindowsIdentity SafeCaptureIdenity();
            /*0x787e838*/ void Abort();
            /*0x787e860*/ System.Net.Cache.RequestCacheProtocol get_CacheProtocol();
            /*0x787e868*/ void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value);
            /*0x787edf4*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0();

            class DesignerWebRequestCreate : System.Net.IWebRequestCreate
            {
                /*0x787edec*/ DesignerWebRequestCreate();
                /*0x787eee8*/ System.Net.WebRequest Create(System.Uri uri);
            }

            class <>c__DisplayClass79_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x787e7e0*/ <>c__DisplayClass79_0();
                /*0x787ef3c*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1();
            }
        }

        class WebResponse : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x18*/ bool m_IsFromCache;

            /*0x787f2d4*/ WebResponse();
            /*0x787f2dc*/ WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787f2e4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787f2f0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x787f2f4*/ void Close();
            /*0x787f2f8*/ void Dispose();
            /*0x787f364*/ void Dispose(bool disposing);
            /*0x787f3f0*/ bool get_IsFromCache();
            /*0x787f3f8*/ System.IO.Stream GetResponseStream();
            /*0x787f420*/ System.Uri get_ResponseUri();
            /*0x787f448*/ System.Net.WebHeaderCollection get_Headers();
        }

        class BufferOffsetSize
        {
            /*0x10*/ byte[] Buffer;
            /*0x18*/ int Offset;
            /*0x1c*/ int Size;

            /*0x787f470*/ BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer);
            /*0x787f528*/ BufferOffsetSize(byte[] buffer, bool copyBuffer);
        }

        class HeaderParser : System.MulticastDelegate
        {
            /*0x787f548*/ HeaderParser(object object, nint method);
            /*0x787f5f8*/ string[] Invoke(string value);
        }

        class HeaderInfo
        {
            /*0x10*/ bool IsRequestRestricted;
            /*0x11*/ bool IsResponseRestricted;
            /*0x18*/ System.Net.HeaderParser Parser;
            /*0x20*/ string HeaderName;
            /*0x28*/ bool AllowMultiValues;

            /*0x787f60c*/ HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, System.Net.HeaderParser p);
        }

        class HeaderInfoTable
        {
            static /*0x0*/ System.Collections.Hashtable HeaderHashTable;
            static /*0x8*/ System.Net.HeaderInfo UnknownHeaderInfo;
            static /*0x10*/ System.Net.HeaderParser SingleParser;
            static /*0x18*/ System.Net.HeaderParser MultiParser;

            static /*0x787f8f8*/ HeaderInfoTable();
            static /*0x787f67c*/ string[] ParseSingleValue(string value);
            static /*0x787f6f4*/ string[] ParseMultiValue(string value);
            /*0x78814a8*/ HeaderInfoTable();
            /*0x78813cc*/ System.Net.HeaderInfo get_Item(string name);
        }

        enum CloseExState
        {
            Normal = 0,
            Abort = 1,
            Silent = 2,
        }

        interface ICloseEx
        {
            /*0x380cffc*/ void CloseEx(System.Net.CloseExState closeState);
        }

        class LazyAsyncResult : System.IAsyncResult
        {
            [ThreadStatic] static System.Net.LazyAsyncResult.ThreadContext t_ThreadContext;
            /*0x10*/ object m_AsyncObject;
            /*0x18*/ object m_AsyncState;
            /*0x20*/ System.AsyncCallback m_AsyncCallback;
            /*0x28*/ object m_Result;
            /*0x30*/ int m_IntCompleted;
            /*0x34*/ bool m_EndCalled;
            /*0x35*/ bool m_UserEvent;
            /*0x38*/ object m_Event;

            static /*0x78814b0*/ System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext();
            /*0x788154c*/ LazyAsyncResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x7881608*/ object get_AsyncObject();
            /*0x7881610*/ object get_AsyncState();
            /*0x7881618*/ System.AsyncCallback get_AsyncCallback();
            /*0x7881620*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x78816c4*/ bool LazilyCreateEvent(ref System.Threading.ManualResetEvent waitHandle);
            /*0x78818ac*/ bool get_CompletedSynchronously();
            /*0x78818dc*/ bool get_IsCompleted();
            /*0x788189c*/ bool get_InternalPeekCompleted();
            /*0x788190c*/ bool get_EndCalled();
            /*0x7881914*/ void set_EndCalled(bool value);
            /*0x7881920*/ void ProtectedInvokeCallback(object result, nint userToken);
            /*0x7881b10*/ void InvokeCallback(object result);
            /*0x7881b18*/ void InvokeCallback();
            /*0x7881b24*/ void Complete(nint userToken);
            /*0x7881cac*/ void WorkerThreadComplete(object state);
            /*0x7881d58*/ void Cleanup();
            /*0x7881d5c*/ object InternalWaitForCompletion();
            /*0x7881d64*/ object WaitForCompletion(bool snap);

            class ThreadContext
            {
                /*0x10*/ int m_NestedIOCount;

                /*0x7881544*/ ThreadContext();
            }
        }

        class NetRes
        {
            static /*0x788205c*/ string GetWebStatusString(string Res, System.Net.WebExceptionStatus Status);
            static /*0x788211c*/ string GetWebStatusString(System.Net.WebExceptionStatus Status);
            static /*0x788217c*/ string GetWebStatusCodeString(System.Net.FtpStatusCode statusCode, string statusDescription);
        }

        class TimerThread
        {
            static /*0x0*/ System.Collections.Generic.LinkedList<System.WeakReference> s_Queues;
            static /*0x8*/ System.Collections.Generic.LinkedList<System.WeakReference> s_NewQueues;
            static /*0x10*/ int s_ThreadState;
            static /*0x18*/ System.Threading.AutoResetEvent s_ThreadReadyEvent;
            static /*0x20*/ System.Threading.ManualResetEvent s_ThreadShutdownEvent;
            static /*0x28*/ System.Threading.WaitHandle[] s_ThreadEvents;
            static /*0x30*/ int s_CacheScanIteration;
            static /*0x38*/ System.Collections.Hashtable s_QueuesCache;

            static /*0x788235c*/ TimerThread();
            static /*0x787ebac*/ System.Net.TimerThread.Queue CreateQueue(int durationMilliseconds);
            static /*0x7882708*/ System.Net.TimerThread.Queue GetOrCreateQueue(int durationMilliseconds);
            static /*0x7883054*/ void Prod();
            static /*0x7883164*/ void ThreadProc();
            static /*0x7883ad0*/ void StopTimerThread();
            static /*0x7883aac*/ bool IsTickBetween(int start, int end, int comparand);
            static /*0x7883b4c*/ void OnDomainUnload(object sender, System.EventArgs e);

            class Queue
            {
                /*0x10*/ int m_DurationMilliseconds;

                /*0x7883c10*/ Queue(int durationMilliseconds);
                /*0x7883c38*/ int get_Duration();
                /*0x380bcbc*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class Timer : System.IDisposable
            {
                /*0x10*/ int m_StartTimeMilliseconds;
                /*0x14*/ int m_DurationMilliseconds;

                /*0x7883c40*/ Timer(int durationMilliseconds);
                /*0x7883c74*/ int get_StartTime();
                /*0x7883c7c*/ int get_Expiration();
                /*0x380b128*/ bool Cancel();
                /*0x380b128*/ bool get_HasExpired();
                /*0x7883c88*/ void Dispose();
            }

            class Callback : System.MulticastDelegate
            {
                /*0x7883c94*/ Callback(object object, nint method);
                /*0x7883da0*/ void Invoke(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            }

            class TimerQueue : System.Net.TimerThread.Queue
            {
                /*0x18*/ nint m_ThisHandle;
                /*0x20*/ System.Net.TimerThread.TimerNode m_Timers;

                /*0x7882648*/ TimerQueue(int durationMilliseconds);
                /*0x7883de4*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
                /*0x7883930*/ bool Fire(ref int nextExpiration);
            }

            class InfiniteTimerQueue : System.Net.TimerThread.Queue
            {
                /*0x7882628*/ InfiniteTimerQueue();
                /*0x788434c*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class TimerNode : System.Net.TimerThread.Timer
            {
                /*0x18*/ System.Net.TimerThread.TimerNode.TimerState m_TimerState;
                /*0x20*/ System.Net.TimerThread.Callback m_Callback;
                /*0x28*/ object m_Context;
                /*0x30*/ object m_QueueLock;
                /*0x38*/ System.Net.TimerThread.TimerNode next;
                /*0x40*/ System.Net.TimerThread.TimerNode prev;

                /*0x7884004*/ TimerNode(System.Net.TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock);
                /*0x7883db4*/ TimerNode();
                /*0x78843e0*/ bool get_HasExpired();
                /*0x78843f0*/ System.Net.TimerThread.TimerNode get_Next();
                /*0x78843f8*/ void set_Next(System.Net.TimerThread.TimerNode value);
                /*0x7884400*/ System.Net.TimerThread.TimerNode get_Prev();
                /*0x7884408*/ void set_Prev(System.Net.TimerThread.TimerNode value);
                /*0x7884410*/ bool Cancel();
                /*0x7884080*/ bool Fire();

                enum TimerState
                {
                    Ready = 0,
                    Fired = 1,
                    Cancelled = 2,
                    Sentinel = 3,
                }
            }

            class InfiniteTimer : System.Net.TimerThread.Timer
            {
                /*0x18*/ int cancelled;

                /*0x78843b4*/ InfiniteTimer();
                /*0x7884578*/ bool get_HasExpired();
                /*0x7884580*/ bool Cancel();
            }
        }

        enum CookieVariant
        {
            Unknown = 0,
            Plain = 1,
            Rfc2109 = 2,
            Rfc2965 = 3,
            Default = 2,
        }

        class Cookie
        {
            static /*0x0*/ char[] PortSplitDelimiters;
            static /*0x8*/ char[] Reserved2Name;
            static /*0x10*/ char[] Reserved2Value;
            static /*0x18*/ System.Net.Comparer staticComparer;
            /*0x10*/ string m_comment;
            /*0x18*/ System.Uri m_commentUri;
            /*0x20*/ System.Net.CookieVariant m_cookieVariant;
            /*0x24*/ bool m_discard;
            /*0x28*/ string m_domain;
            /*0x30*/ bool m_domain_implicit;
            /*0x38*/ System.DateTime m_expires;
            /*0x40*/ string m_name;
            /*0x48*/ string m_path;
            /*0x50*/ bool m_path_implicit;
            /*0x58*/ string m_port;
            /*0x60*/ bool m_port_implicit;
            /*0x68*/ int[] m_port_list;
            /*0x70*/ bool m_secure;
            /*0x71*/ bool m_httpOnly;
            /*0x78*/ System.DateTime m_timeStamp;
            /*0x80*/ string m_value;
            /*0x88*/ int m_version;
            /*0x90*/ string m_domainKey;
            /*0x98*/ bool IsQuotedVersion;
            /*0x99*/ bool IsQuotedDomain;

            static /*0x7886310*/ Cookie();
            static /*0x7884b1c*/ bool IsDomainEqualToHost(string domain, string host);
            static /*0x7885608*/ bool DomainCharsTest(string name);
            static /*0x7885d54*/ System.Collections.IComparer GetComparer();
            /*0x78845a4*/ Cookie();
            /*0x78846e8*/ string get_Comment();
            /*0x78846f0*/ void set_Comment(string value);
            /*0x7884710*/ void set_CommentUri(System.Uri value);
            /*0x7884718*/ void set_HttpOnly(bool value);
            /*0x7884724*/ void set_Discard(bool value);
            /*0x7884730*/ string get_Domain();
            /*0x7884738*/ void set_Domain(string value);
            /*0x7884794*/ string get__Domain();
            /*0x788486c*/ bool get_Expired();
            /*0x7884924*/ void set_Expires(System.DateTime value);
            /*0x788492c*/ string get_Name();
            /*0x7884934*/ bool InternalSetName(string value);
            /*0x7884a44*/ string get_Path();
            /*0x7884a4c*/ void set_Path(string value);
            /*0x7884a8c*/ string get__Path();
            /*0x788485c*/ bool get_Plain();
            /*0x7884b74*/ bool VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow);
            /*0x7885754*/ void set_Port(string value);
            /*0x7885a9c*/ int[] get_PortList();
            /*0x7885aa4*/ string get__Port();
            /*0x7885b68*/ bool get_Secure();
            /*0x7885b70*/ void set_Secure(bool value);
            /*0x7885b7c*/ string get_Value();
            /*0x7885b84*/ void set_Value(string value);
            /*0x7885bb4*/ System.Net.CookieVariant get_Variant();
            /*0x7885bbc*/ string get_DomainKey();
            /*0x7885bd8*/ int get_Version();
            /*0x7885be0*/ void set_Version(int value);
            /*0x7885c54*/ string get__Version();
            /*0x7885dac*/ bool Equals(object comparand);
            /*0x7885e7c*/ int GetHashCode();
            /*0x7886068*/ string ToString();
        }

        enum CookieToken
        {
            Nothing = 0,
            NameValuePair = 1,
            Attribute = 2,
            EndToken = 3,
            EndCookie = 4,
            End = 5,
            Equals = 6,
            Comment = 7,
            CommentUrl = 8,
            CookieName = 9,
            Discard = 10,
            Domain = 11,
            Expires = 12,
            MaxAge = 13,
            Path = 14,
            Port = 15,
            Secure = 16,
            HttpOnly = 17,
            Unknown = 18,
            Version = 19,
        }

        class CookieTokenizer
        {
            static /*0x0*/ System.Net.CookieTokenizer.RecognizedAttribute[] RecognizedAttributes;
            static /*0x8*/ System.Net.CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes;
            /*0x10*/ bool m_eofCookie;
            /*0x14*/ int m_index;
            /*0x18*/ int m_length;
            /*0x20*/ string m_name;
            /*0x28*/ bool m_quoted;
            /*0x2c*/ int m_start;
            /*0x30*/ System.Net.CookieToken m_token;
            /*0x34*/ int m_tokenLength;
            /*0x38*/ string m_tokenStream;
            /*0x40*/ string m_value;

            static /*0x7886b74*/ CookieTokenizer();
            /*0x7886484*/ CookieTokenizer(string tokenStream);
            /*0x78864c4*/ bool get_EndOfCookie();
            /*0x78864cc*/ void set_EndOfCookie(bool value);
            /*0x78864d8*/ bool get_Eof();
            /*0x78864e8*/ string get_Name();
            /*0x78864f0*/ void set_Name(string value);
            /*0x78864f8*/ bool get_Quoted();
            /*0x7886500*/ void set_Quoted(bool value);
            /*0x788650c*/ System.Net.CookieToken get_Token();
            /*0x7886514*/ void set_Token(System.Net.CookieToken value);
            /*0x788651c*/ string get_Value();
            /*0x7886524*/ void set_Value(string value);
            /*0x788652c*/ string Extract();
            /*0x7886588*/ System.Net.CookieToken FindNext(bool ignoreComma, bool ignoreEquals);
            /*0x788680c*/ System.Net.CookieToken Next(bool first, bool parseResponseCookies);
            /*0x7886938*/ void Reset();
            /*0x7886994*/ System.Net.CookieToken TokenFromName(bool parseResponseCookies);

            struct RecognizedAttribute
            {
                /*0x10*/ string m_name;
                /*0x18*/ System.Net.CookieToken m_token;

                /*0x7887124*/ RecognizedAttribute(string name, System.Net.CookieToken token);
                /*0x788714c*/ System.Net.CookieToken get_Token();
                /*0x7886b50*/ bool IsEqualTo(string value);
            }
        }

        class CookieParser
        {
            /*0x10*/ System.Net.CookieTokenizer m_tokenizer;

            static /*0x78856bc*/ string CheckQuoted(string value);
            /*0x7887154*/ CookieParser(string cookieString);
            /*0x78871cc*/ System.Net.Cookie Get();
        }

        class Comparer : System.Collections.IComparer
        {
            /*0x788647c*/ Comparer();
            /*0x7887720*/ int System.Collections.IComparer.Compare(object ol, object or);
        }

        class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ int m_version;
            /*0x18*/ System.Collections.ArrayList m_list;
            /*0x20*/ System.DateTime m_TimeStamp;
            /*0x28*/ bool m_has_other_versions;
            /*0x29*/ bool m_IsReadOnly;

            /*0x7887804*/ CookieCollection();
            /*0x78878b8*/ System.Net.Cookie get_Item(int index);
            /*0x78879a0*/ void Add(System.Net.Cookie cookie);
            /*0x7887e10*/ void Add(System.Net.CookieCollection cookies);
            /*0x7888164*/ int get_Count();
            /*0x7888188*/ bool get_IsSynchronized();
            /*0x7888190*/ object get_SyncRoot();
            /*0x7888194*/ void CopyTo(System.Array array, int index);
            /*0x78881b8*/ System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how);
            /*0x7888288*/ bool get_IsOtherVersionSeen();
            /*0x7888290*/ int InternalAdd(System.Net.Cookie cookie, bool isStrict);
            /*0x7887a60*/ int IndexOf(System.Net.Cookie cookie);
            /*0x7888744*/ void RemoveAt(int idx);
            /*0x788810c*/ System.Collections.IEnumerator GetEnumerator();

            enum Stamp
            {
                Check = 0,
                Set = 1,
                SetToUnused = 2,
                SetToMaxUsed = 3,
            }

            class CookieCollectionEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Net.CookieCollection m_cookies;
                /*0x18*/ int m_count;
                /*0x1c*/ int m_index;
                /*0x20*/ int m_version;

                /*0x7888768*/ CookieCollectionEnumerator(System.Net.CookieCollection cookies);
                /*0x78887d0*/ object System.Collections.IEnumerator.get_Current();
                /*0x7888874*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x7888910*/ void System.Collections.IEnumerator.Reset();
            }
        }

        struct HeaderVariantInfo
        {
            /*0x10*/ string m_name;
            /*0x18*/ System.Net.CookieVariant m_variant;

            /*0x788891c*/ HeaderVariantInfo(string name, System.Net.CookieVariant variant);
            /*0x7888944*/ string get_Name();
            /*0x788894c*/ System.Net.CookieVariant get_Variant();
        }

        class CookieContainer
        {
            static /*0x0*/ System.Net.HeaderVariantInfo[] HeaderInfo;
            /*0x10*/ System.Collections.Hashtable m_domainTable;
            /*0x18*/ int m_maxCookieSize;
            /*0x1c*/ int m_maxCookies;
            /*0x20*/ int m_maxCookiesPerDomain;
            /*0x24*/ int m_count;
            /*0x28*/ string m_fqdnMyDomain;

            static /*0x788cdb0*/ CookieContainer();
            /*0x7888954*/ CookieContainer();
            /*0x7888a64*/ void AddRemoveDomain(string key, System.Net.PathList value);
            /*0x7888b8c*/ void Add(System.Net.Cookie cookie, bool throwOnError);
            /*0x78899f4*/ bool AgeCookies(string domain);
            /*0x788af50*/ int ExpireCollection(System.Net.CookieCollection cc);
            /*0x788b0e0*/ bool IsLocalDomain(string host);
            /*0x788b380*/ System.Net.CookieCollection CookieCutter(System.Uri uri, string headerName, string setCookieHeader, bool isThrow);
            /*0x788ba58*/ System.Net.CookieCollection InternalGetCookies(System.Uri uri);
            /*0x788bf08*/ void BuildCookieCollectionFromDomainMatches(System.Uri uri, bool isSecure, int port, System.Net.CookieCollection cookies, System.Collections.Generic.List<string> domainAttribute, bool matchOnlyPlainCookie);
            /*0x788c740*/ void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, int port, bool isSecure, bool isPlainOnly);
            /*0x788c94c*/ string GetCookieHeader(System.Uri uri);
            /*0x788ca18*/ string GetCookieHeader(System.Uri uri, ref string optCookie2);
        }

        class PathList
        {
            /*0x10*/ System.Collections.SortedList m_list;

            /*0x78893b0*/ PathList();
            /*0x788b0bc*/ int get_Count();
            /*0x788945c*/ int GetCookiesCount();
            /*0x788af2c*/ System.Collections.ICollection get_Values();
            /*0x78898d0*/ object get_Item(string s);
            /*0x78898f4*/ void set_Item(string s, object value);
            /*0x788c71c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x78898ac*/ object get_SyncRoot();

            class PathListComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.Net.PathList.PathListComparer StaticInstance;

                static /*0x788d03c*/ PathListComparer();
                /*0x788d034*/ PathListComparer();
                /*0x788ced8*/ int System.Collections.IComparer.Compare(object ol, object or);
            }
        }

        class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
        {
            /*0x788d0a4*/ CookieException();
            /*0x7885600*/ CookieException(string message);
            /*0x788af24*/ CookieException(string message, System.Exception inner);
            /*0x788d0ac*/ CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x788d0b4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x788d0bc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class FileWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ System.Threading.WaitCallback s_GetRequestStreamCallback;
            static /*0x8*/ System.Threading.WaitCallback s_GetResponseCallback;
            /*0x38*/ string m_connectionGroupName;
            /*0x40*/ long m_contentLength;
            /*0x48*/ System.Net.ICredentials m_credentials;
            /*0x50*/ System.IO.FileAccess m_fileAccess;
            /*0x58*/ System.Net.WebHeaderCollection m_headers;
            /*0x60*/ string m_method;
            /*0x68*/ System.Net.IWebProxy m_proxy;
            /*0x70*/ System.Threading.ManualResetEvent m_readerEvent;
            /*0x78*/ bool m_readPending;
            /*0x80*/ System.Net.WebResponse m_response;
            /*0x88*/ System.IO.Stream m_stream;
            /*0x90*/ bool m_syncHint;
            /*0x94*/ int m_timeout;
            /*0x98*/ System.Uri m_uri;
            /*0xa0*/ bool m_writePending;
            /*0xa1*/ bool m_writing;
            /*0xa8*/ System.Net.LazyAsyncResult m_WriteAResult;
            /*0xb0*/ System.Net.LazyAsyncResult m_ReadAResult;
            /*0xb8*/ int m_Aborted;

            static /*0x788f7dc*/ FileWebRequest();
            static /*0x788ea4c*/ void GetRequestStreamCallback(object state);
            static /*0x788ed10*/ void GetResponseCallback(object state);
            /*0x788d0c4*/ FileWebRequest(System.Uri uri);
            /*0x788d258*/ FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x788d668*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x788d674*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x788d8f8*/ bool get_Aborted();
            /*0x788d908*/ long get_ContentLength();
            /*0x788d910*/ System.Net.ICredentials get_Credentials();
            /*0x788d918*/ void set_Credentials(System.Net.ICredentials value);
            /*0x788d920*/ System.Net.WebHeaderCollection get_Headers();
            /*0x788d928*/ string get_Method();
            /*0x788d930*/ void set_Method(string value);
            /*0x788da0c*/ System.Net.IWebProxy get_Proxy();
            /*0x788da14*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x788da1c*/ int get_Timeout();
            /*0x788da24*/ System.Uri get_RequestUri();
            /*0x788da2c*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x788de50*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x788dddc*/ bool CanGetRequestStream();
            /*0x788e124*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x788e410*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x788e6fc*/ System.Net.WebResponse GetResponse();
            /*0x788f33c*/ void UnblockReader();
            /*0x788f414*/ bool get_UseDefaultCredentials();
            /*0x788f43c*/ void Abort();
        }

        class FileWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x787e1ac*/ FileWebRequestCreator();
            /*0x788f8c0*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FileWebStream : System.IO.FileStream, System.Net.ICloseEx
        {
            /*0x70*/ System.Net.FileWebRequest m_request;

            /*0x788ec6c*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing);
            /*0x788f918*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, int length, bool async);
            /*0x788f9d4*/ void Dispose(bool disposing);
            /*0x788fa84*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x788fac0*/ int Read(byte[] buffer, int offset, int size);
            /*0x788fc04*/ void Write(byte[] buffer, int offset, int size);
            /*0x788fccc*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x788fdac*/ int EndRead(System.IAsyncResult ar);
            /*0x788fe4c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x788ff2c*/ void EndWrite(System.IAsyncResult ar);
            /*0x788fb88*/ void CheckError();
        }

        class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.Net.ICloseEx
        {
            /*0x19*/ bool m_closed;
            /*0x20*/ long m_contentLength;
            /*0x28*/ System.IO.FileAccess m_fileAccess;
            /*0x30*/ System.Net.WebHeaderCollection m_headers;
            /*0x38*/ System.IO.Stream m_stream;
            /*0x40*/ System.Uri m_uri;

            /*0x788f02c*/ FileWebResponse(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, bool asyncHint);
            /*0x788ffcc*/ FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7890220*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x789022c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78903b0*/ System.Net.WebHeaderCollection get_Headers();
            /*0x7890444*/ System.Uri get_ResponseUri();
            /*0x78903c8*/ void CheckDisposed();
            /*0x789045c*/ void Close();
            /*0x78904f4*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x7890670*/ System.IO.Stream GetResponseStream();
        }

        interface IWebProxy
        {
            /*0x380bb68*/ System.Uri GetProxy(System.Uri destination);
            /*0x380b2f0*/ bool IsBypassed(System.Uri host);
            /*0x380b9e8*/ System.Net.ICredentials get_Credentials();
        }

        class WebProxy : System.Net.IWebProxy, System.Runtime.Serialization.ISerializable
        {
            /*0x10*/ bool _UseRegistry;
            /*0x11*/ bool _BypassOnLocal;
            /*0x12*/ bool m_EnableAutoproxy;
            /*0x18*/ System.Uri _ProxyAddress;
            /*0x20*/ System.Collections.ArrayList _BypassList;
            /*0x28*/ System.Net.ICredentials _Credentials;
            /*0x30*/ System.Text.RegularExpressions.Regex[] _RegExBypassList;
            /*0x38*/ System.Collections.Hashtable _ProxyHostAddresses;
            /*0x40*/ System.Net.AutoWebProxyScriptEngine m_ScriptEngine;

            static /*0x787ea90*/ System.Net.IWebProxy CreateDefaultProxy();
            static /*0x7891804*/ bool AreAllBypassed(System.Collections.Generic.IEnumerable<string> proxies, bool checkFirstOnly);
            static /*0x7891b08*/ System.Uri ProxyUri(string proxyName);
            /*0x78906c4*/ WebProxy();
            /*0x78906d8*/ WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials);
            /*0x78912f8*/ WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78917b4*/ WebProxy(bool enableAutoproxy);
            /*0x7890a00*/ System.Uri get_Address();
            /*0x7890a08*/ bool get_BypassProxyOnLocal();
            /*0x7890a10*/ System.Net.ICredentials get_Credentials();
            /*0x7890a18*/ bool get_UseDefaultCredentials();
            /*0x7890a94*/ void set_UseDefaultCredentials(bool value);
            /*0x7890b0c*/ System.Uri GetProxy(System.Uri destination);
            /*0x78907ac*/ void UpdateRegExList(bool canThrow);
            /*0x7890dd4*/ bool IsMatchInBypassList(System.Uri input);
            /*0x7890f6c*/ bool IsLocal(System.Uri host);
            /*0x78910c8*/ bool IsLocalInProxyHash(System.Uri host);
            /*0x78911b8*/ bool IsBypassed(System.Uri host);
            /*0x7890d0c*/ bool IsBypassedManual(System.Uri host);
            /*0x789167c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7891688*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78917ac*/ System.Net.AutoWebProxyScriptEngine get_ScriptEngine();
            /*0x7891670*/ void UnsafeUpdateFromRegistry();
            /*0x7890c8c*/ bool GetProxyAuto(System.Uri destination, ref System.Uri proxyUri);
            /*0x789128c*/ bool IsBypassedAuto(System.Uri destination, ref bool isBypassed);
        }

        class AutoWebProxyScriptEngine
        {
            /*0x78917e4*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList);
            /*0x7891ba4*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList, ref int syncStatus);
        }

        class UnsafeNclNativeMethods
        {
            class HttpApi
            {
                static /*0x0*/ string[] m_Strings;

                static /*0x7891bc4*/ HttpApi();

                class HTTP_REQUEST_HEADER_ID
                {
                    static /*0x0*/ string[] m_Strings;

                    static /*0x78922d0*/ HTTP_REQUEST_HEADER_ID();
                    static /*0x7892254*/ string ToString(int position);
                }
            }

            class SecureStringHelper
            {
                static /*0x7892b70*/ string CreateString(System.Security.SecureString secureString);
                static /*0x7892cbc*/ System.Security.SecureString CreateSecureString(string plainString);
            }
        }

        class Logging
        {
            static /*0x787dc40*/ bool get_On();
        }

        class ServerCertValidationCallback
        {
            /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;
            /*0x18*/ System.Threading.ExecutionContext m_Context;

            /*0x7892d58*/ ServerCertValidationCallback(System.Net.Security.RemoteCertificateValidationCallback validationCallback);
            /*0x7892de4*/ System.Net.Security.RemoteCertificateValidationCallback get_ValidationCallback();
            /*0x7892dec*/ void Callback(object state);
            /*0x7892e98*/ bool Invoke(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);

            class CallbackContext
            {
                /*0x10*/ object request;
                /*0x18*/ System.Security.Cryptography.X509Certificates.X509Certificate certificate;
                /*0x20*/ System.Security.Cryptography.X509Certificates.X509Chain chain;
                /*0x28*/ System.Net.Security.SslPolicyErrors sslPolicyErrors;
                /*0x2c*/ bool result;

                /*0x7893008*/ CallbackContext(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            }
        }

        class AuthenticationManager
        {
            static /*0x0*/ System.Collections.ArrayList modules;
            static /*0x8*/ object locker;
            static /*0x10*/ System.Net.ICredentialPolicy credential_policy;

            static /*0x7893e48*/ AuthenticationManager();
            static /*0x7893074*/ void EnsureModules();
            static /*0x7893304*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x7893404*/ System.Net.Authorization DoAuthenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x7893900*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
        }

        class BasicClient : System.Net.IAuthenticationModule
        {
            static /*0x78942d8*/ byte[] GetBytes(string str);
            static /*0x7893f7c*/ System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78932fc*/ BasicClient();
            /*0x7893ed0*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x7894374*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x7894380*/ string get_AuthenticationType();
        }

        class BindIPEndPoint : System.MulticastDelegate
        {
            /*0x78943c0*/ BindIPEndPoint(object object, nint method);
            /*0x78944cc*/ System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
        }

        class BufferedReadStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.BufferOffsetSize readBuffer;

            /*0x78944e0*/ BufferedReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.BufferOffsetSize readBuffer);
            /*0x7894510*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x7894678*/ bool TryReadFromBuffer(byte[] buffer, int offset, int size, ref int result);

            struct <ProcessReadAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.BufferedReadStream <>4__this;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x7894708*/ void MoveNext();
                /*0x7894a40*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ContentDecodeStream : System.Net.WebReadStream
        {
            /*0x40*/ System.IO.Stream <OriginalInnerStream>k__BackingField;

            static /*0x7894abc*/ System.Net.ContentDecodeStream Create(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.ContentDecodeStream.Mode mode);
            /*0x7894ba4*/ ContentDecodeStream(System.Net.WebOperation operation, System.IO.Stream decodeStream, System.IO.Stream originalInnerStream);
            /*0x7894bd4*/ System.IO.Stream get_OriginalInnerStream();
            /*0x7894bdc*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x7894c00*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);

            enum Mode
            {
                GZip = 0,
                Deflate = 1,
            }
        }

        enum DecompressionMethods
        {
            None = 0,
            GZip = 1,
            Deflate = 2,
        }

        class DefaultCertificatePolicy
        {
        }

        class DigestHeaderParser
        {
            static /*0x0*/ string[] keywords;
            /*0x10*/ string header;
            /*0x18*/ int length;
            /*0x1c*/ int pos;
            /*0x20*/ string[] values;

            static /*0x7895300*/ DigestHeaderParser();
            /*0x7894cf0*/ DigestHeaderParser(string header);
            /*0x7894db8*/ string get_Realm();
            /*0x7894de0*/ string get_Opaque();
            /*0x7894e0c*/ string get_Nonce();
            /*0x7894e38*/ string get_Algorithm();
            /*0x7894e64*/ string get_QOP();
            /*0x7894e90*/ bool Parse();
            /*0x78951f0*/ void SkipWhitespace();
            /*0x7895270*/ string GetKey();
            /*0x789502c*/ bool GetKeywordAndValue(ref string key, ref string value);
        }

        class DigestSession
        {
            static /*0x0*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ System.DateTime lastUse;
            /*0x18*/ int _nc;
            /*0x20*/ System.Security.Cryptography.HashAlgorithm hash;
            /*0x28*/ System.Net.DigestHeaderParser parser;
            /*0x30*/ string _cnonce;

            static /*0x7895480*/ DigestSession();
            /*0x78954dc*/ DigestSession();
            /*0x789554c*/ string get_Algorithm();
            /*0x7895564*/ string get_Realm();
            /*0x789557c*/ string get_Nonce();
            /*0x7895594*/ string get_Opaque();
            /*0x78955ac*/ string get_QOP();
            /*0x78955c4*/ string get_CNonce();
            /*0x78956c4*/ bool Parse(string challenge);
            /*0x78957bc*/ string HashToHexString(string toBeHashed);
            /*0x7895910*/ string HA1(string username, string password);
            /*0x7895a34*/ string HA2(System.Net.HttpWebRequest webRequest);
            /*0x7895b04*/ string Response(string username, string password, System.Net.HttpWebRequest webRequest);
            /*0x7895c64*/ System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x7896220*/ System.DateTime get_LastUse();
        }

        class DigestClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Collections.Hashtable cache;

            static /*0x789701c*/ DigestClient();
            static /*0x7896228*/ System.Collections.Hashtable get_Cache();
            static /*0x7896390*/ void CheckExpired(int count);
            /*0x78932f4*/ DigestClient();
            /*0x7896bdc*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x7896e68*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x7896fdc*/ string get_AuthenticationType();
        }

        class Dns
        {
            static /*0x78970a4*/ System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state);
            static /*0x78972fc*/ System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult);
            static /*0x7897410*/ bool GetHostByName_icall(string host, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x7897414*/ bool GetHostByAddr_icall(string addr, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x7897418*/ bool GetHostName_icall(ref string h_name);
            static /*0x789741c*/ void Error_11001(string hostName);
            static /*0x7897480*/ System.Net.IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist);
            static /*0x78977c0*/ System.Net.IPHostEntry GetHostByAddressFromString(string address, bool parse);
            static /*0x78978ec*/ System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress);
            static /*0x7897a58*/ System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address);
            static /*0x7897ba8*/ System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress);
            static /*0x7897ac0*/ System.Net.IPHostEntry GetHostByName(string hostName);
            static /*0x7897d88*/ string GetHostName();
            static /*0x7897db4*/ System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);

            class GetHostAddressesCallback : System.MulticastDelegate
            {
                /*0x789722c*/ GetHostAddressesCallback(object object, nint method);
                /*0x7897ed0*/ System.Net.IPAddress[] Invoke(string hostName);
                /*0x78972dc*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x7897404*/ System.Net.IPAddress[] EndInvoke(System.IAsyncResult result);
            }
        }

        class FixedSizeReadStream : System.Net.WebReadStream
        {
            /*0x40*/ long <ContentLength>k__BackingField;
            /*0x48*/ long position;

            /*0x7897eec*/ FixedSizeReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, long contentLength);
            /*0x7897ee4*/ long get_ContentLength();
            /*0x7897f14*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);

            struct <ProcessReadAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.FixedSizeReadStream <>4__this;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x789807c*/ void MoveNext();
                /*0x78983a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x7898420*/ HttpRequestCreator();
            /*0x7898428*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ int defaultMaxResponseHeadersLength;
            static /*0x4*/ int defaultMaximumErrorResponseLength;
            static /*0x8*/ System.Net.Cache.RequestCachePolicy defaultCachePolicy;
            /*0x38*/ System.Uri requestUri;
            /*0x40*/ System.Uri actualUri;
            /*0x48*/ bool hostChanged;
            /*0x49*/ bool allowAutoRedirect;
            /*0x4a*/ bool allowBuffering;
            /*0x50*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates;
            /*0x58*/ string connectionGroup;
            /*0x60*/ bool haveContentLength;
            /*0x68*/ long contentLength;
            /*0x70*/ System.Net.HttpContinueDelegate continueDelegate;
            /*0x78*/ System.Net.CookieContainer cookieContainer;
            /*0x80*/ System.Net.ICredentials credentials;
            /*0x88*/ bool haveResponse;
            /*0x89*/ bool requestSent;
            /*0x90*/ System.Net.WebHeaderCollection webHeaders;
            /*0x98*/ bool keepAlive;
            /*0x9c*/ int maxAutoRedirect;
            /*0xa0*/ string mediaType;
            /*0xa8*/ string method;
            /*0xb0*/ string initialMethod;
            /*0xb8*/ bool pipelined;
            /*0xb9*/ bool preAuthenticate;
            /*0xba*/ bool usedPreAuth;
            /*0xc0*/ System.Version version;
            /*0xc8*/ bool force_version;
            /*0xd0*/ System.Version actualVersion;
            /*0xd8*/ System.Net.IWebProxy proxy;
            /*0xe0*/ bool sendChunked;
            /*0xe8*/ System.Net.ServicePoint servicePoint;
            /*0xf0*/ int timeout;
            /*0xf4*/ int continueTimeout;
            /*0xf8*/ System.Net.WebRequestStream writeStream;
            /*0x100*/ System.Net.HttpWebResponse webResponse;
            /*0x108*/ System.Net.WebCompletionSource responseTask;
            /*0x110*/ System.Net.WebOperation currentOperation;
            /*0x118*/ int aborted;
            /*0x11c*/ bool gotRequestStream;
            /*0x120*/ int redirects;
            /*0x124*/ bool expectContinue;
            /*0x125*/ bool getResponseCalled;
            /*0x128*/ object locker;
            /*0x130*/ bool finished_reading;
            /*0x134*/ System.Net.DecompressionMethods auto_decomp;
            /*0x138*/ int readWriteTimeout;
            /*0x140*/ Mono.Net.Security.MobileTlsProvider tlsProvider;
            /*0x148*/ Mono.Security.Interface.MonoTlsSettings tlsSettings;
            /*0x150*/ System.Net.ServerCertValidationCallback certValidationCallback;
            /*0x158*/ bool hostHasPort;
            /*0x160*/ System.Uri hostUri;
            /*0x168*/ System.Net.HttpWebRequest.AuthorizationState auth_state;
            /*0x178*/ System.Net.HttpWebRequest.AuthorizationState proxy_auth_state;
            /*0x188*/ System.Func<System.IO.Stream, System.Threading.Tasks.Task> ResendContentFactory;
            /*0x190*/ bool <ThrowOnError>k__BackingField;
            /*0x191*/ bool unsafe_auth_blah;

            static /*0x789867c*/ HttpWebRequest();
            static /*0x7898ae8*/ int get_DefaultMaximumErrorResponseLength();
            static /*0x3907c14*/ System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationToken cancellationToken);
            static System.Threading.Tasks.Task<T> RunWithTimeoutWorker<T>(System.Threading.Tasks.Task<T> workerTask, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationTokenSource cts);
            static /*0x789a844*/ System.Exception FlattenException(System.Exception e);
            static /*0x789a900*/ System.Net.WebException GetWebException(System.Exception e, bool aborted);
            static /*0x789a190*/ System.Net.WebException CreateRequestAbortedException();
            /*0x7898480*/ HttpWebRequest(System.Uri uri);
            /*0x7898778*/ HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x789d148*/ HttpWebRequest();
            /*0x7898704*/ void ResetAuthorization();
            /*0x789890c*/ System.Uri get_Address();
            /*0x7898914*/ bool get_AllowWriteStreamBuffering();
            /*0x789891c*/ System.Net.DecompressionMethods get_AutomaticDecompression();
            /*0x7898924*/ bool get_InternalAllowBuffering();
            /*0x7898938*/ bool get_MethodWithBuffer();
            /*0x7898a34*/ Mono.Net.Security.MobileTlsProvider get_TlsProvider();
            /*0x7898a3c*/ Mono.Security.Interface.MonoTlsSettings get_TlsSettings();
            /*0x7898a44*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x7898ab4*/ long get_ContentLength();
            /*0x7898abc*/ void set_InternalContentLength(long value);
            /*0x7898ac4*/ bool get_ThrowOnError();
            /*0x7898acc*/ void set_ThrowOnError(bool value);
            /*0x7898ad8*/ System.Net.ICredentials get_Credentials();
            /*0x7898ae0*/ void set_Credentials(System.Net.ICredentials value);
            /*0x7898b40*/ System.Net.WebHeaderCollection get_Headers();
            /*0x7898b48*/ string get_Host();
            /*0x7898c54*/ bool get_KeepAlive();
            /*0x7898c5c*/ int get_ReadWriteTimeout();
            /*0x7898c64*/ string get_Method();
            /*0x7898c6c*/ void set_Method(string value);
            /*0x7898eb8*/ System.Version get_ProtocolVersion();
            /*0x7898ec0*/ System.Net.IWebProxy get_Proxy();
            /*0x7898ec8*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x78990a4*/ System.Uri get_RequestUri();
            /*0x78990ac*/ bool get_SendChunked();
            /*0x78990b4*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78990b8*/ System.Net.ServicePoint get_ServicePointNoLock();
            /*0x78990c0*/ int get_Timeout();
            /*0x78990c8*/ string get_TransferEncoding();
            /*0x789911c*/ bool get_UseDefaultCredentials();
            /*0x7899194*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x789919c*/ bool get_ExpectContinue();
            /*0x78991a4*/ void set_ExpectContinue(bool value);
            /*0x78991b0*/ System.Uri get_AuthUri();
            /*0x78991b8*/ bool get_ProxyQuery();
            /*0x78991ec*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            /*0x78991f4*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            /*0x7898f68*/ System.Net.ServicePoint GetServicePoint();
            /*0x7899874*/ System.Net.WebOperation SendRequest(bool redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x7899dfc*/ System.Threading.Tasks.Task<System.IO.Stream> MyGetRequestStreamAsync(System.Threading.CancellationToken cancellationToken);
            /*0x789a364*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x789a41c*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x380bb68*/ System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func);
            /*0x789a5c0*/ System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken);
            /*0x789a6f4*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken);
            /*0x789a53c*/ System.Net.WebException GetWebException(System.Exception e);
            /*0x789aaa4*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x789ac14*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x789ad34*/ System.Net.WebResponse GetResponse();
            /*0x789ae34*/ void set_FinishedReading(bool value);
            /*0x789a168*/ bool get_Aborted();
            /*0x789ae40*/ void Abort();
            /*0x789af98*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x789afd0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7898f0c*/ void CheckRequestStarted();
            /*0x789b008*/ void DoContinueDelegate(int statusCode, System.Net.WebHeaderCollection headers);
            /*0x789b024*/ void RewriteRedirectToGet();
            /*0x789b0a8*/ bool Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response);
            /*0x789b580*/ string GetHeaders();
            /*0x789bc70*/ void DoPreAuthenticate();
            /*0x789be70*/ byte[] GetRequestHeaders();
            /*0x789c1ac*/ System.ValueTuple<System.Net.WebOperation, bool> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x789c5b8*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
            /*0x789c8ec*/ System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, bool redirect);
            /*0x789caec*/ System.ValueTuple<bool, bool, System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response);
            /*0x380b128*/ bool <RunWithTimeout>b__242_0<T>();
            /*0x789d034*/ System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0();

            enum NtlmAuthState
            {
                None = 0,
                Challenge = 1,
                Response = 2,
            }

            struct AuthorizationState
            {
                /*0x10*/ System.Net.HttpWebRequest request;
                /*0x18*/ bool isProxy;
                /*0x19*/ bool isCompleted;
                /*0x1c*/ System.Net.HttpWebRequest.NtlmAuthState ntlm_auth_state;

                /*0x78988dc*/ AuthorizationState(System.Net.HttpWebRequest request, bool isProxy);
                /*0x789d180*/ bool get_IsCompleted();
                /*0x789d188*/ System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState();
                /*0x789d190*/ bool get_IsNtlmAuthenticated();
                /*0x789c5d0*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
                /*0x789cfb0*/ void Reset();
                /*0x789d1b0*/ string ToString();
            }

            class <>c__24<T>
            {
                static /*0x0*/ System.Net.HttpWebRequest.<>c__241<T> <>9;
                static /*0x0*/ System.Func<System.Threading.Tasks.Task<T>, System.Nullable<int>> <>9__241_0;

                static /*0x38358cc*/ <>c__24();
                /*0x380cb08*/ <>c__24();
                /*0x380a950*/ System.Nullable<int> <RunWithTimeoutWorker>b__241_0(System.Threading.Tasks.Task<T> t);
            }

            struct <RunWithTimeoutWorker>d__24<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ System.Threading.Tasks.Task<T> workerTask;
                /*0x0*/ int timeout;
                /*0x0*/ System.Threading.CancellationTokenSource cts;
                /*0x0*/ System.Action abort;
                /*0x0*/ System.Func<bool> aborted;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0x380cb08*/ void MoveNext();
                /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <MyGetResponseAsync>d__243 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.HttpWebResponse> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.WebCompletionSource <completion>5__2;
                /*0x48*/ System.Net.WebOperation <operation>5__3;
                /*0x50*/ System.Net.WebException <throwMe>5__4;
                /*0x58*/ System.Net.HttpWebResponse <response>5__5;
                /*0x60*/ System.Net.WebResponseStream <stream>5__6;
                /*0x68*/ bool <redirect>5__7;
                /*0x69*/ bool <mustReadAll>5__8;
                /*0x70*/ System.Net.WebOperation <ntlm>5__9;
                /*0x78*/ System.Net.BufferOffsetSize <writeBuffer>5__10;
                /*0x80*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;
                /*0x90*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0xa0*/ System.Runtime.CompilerServices.TaskAwaiter<System.Net.WebResponseStream> <>u__3;
                /*0xa8*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> <>u__4;

                /*0x789d29c*/ void MoveNext();
                /*0x789e6b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <GetResponseFromData>d__244 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.Net.WebResponseStream stream;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Net.HttpWebResponse <response>5__2;
                /*0x50*/ System.Net.WebException <throwMe>5__3;
                /*0x58*/ bool <redirect>5__4;
                /*0x59*/ bool <mustReadAll>5__5;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.BufferOffsetSize> <>u__2;

                /*0x789e72c*/ void MoveNext();
                /*0x789f2dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<GetRewriteHandler>b__271_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.BufferOffsetSize> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.IO.MemoryStream <ms>5__2;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x789f358*/ void MoveNext();
                /*0x789f7d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x20*/ System.Uri uri;
            /*0x28*/ System.Net.WebHeaderCollection webHeaders;
            /*0x30*/ System.Net.CookieCollection cookieCollection;
            /*0x38*/ string method;
            /*0x40*/ System.Version version;
            /*0x48*/ System.Net.HttpStatusCode statusCode;
            /*0x50*/ string statusDescription;
            /*0x58*/ long contentLength;
            /*0x60*/ string contentType;
            /*0x68*/ System.Net.CookieContainer cookie_container;
            /*0x70*/ bool disposed;
            /*0x78*/ System.IO.Stream stream;

            /*0x789f84c*/ HttpWebResponse();
            /*0x789f854*/ HttpWebResponse(System.Uri uri, string method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers);
            /*0x789efa0*/ HttpWebResponse(System.Uri uri, string method, System.Net.WebResponseStream stream, System.Net.CookieContainer container);
            /*0x789fb68*/ HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x789ff60*/ System.Net.WebHeaderCollection get_Headers();
            /*0x789ff68*/ System.Uri get_ResponseUri();
            /*0x789fffc*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x78a0004*/ string get_StatusDescription();
            /*0x78a001c*/ System.IO.Stream GetResponseStream();
            /*0x78a00b8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a00c4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a0284*/ void Close();
            /*0x78a02b4*/ void System.IDisposable.Dispose();
            /*0x78a02c4*/ void Dispose(bool disposing);
            /*0x789ff80*/ void CheckDisposed();
            /*0x789f940*/ void FillCookies();
        }

        interface ICredentialPolicy
        {
        }

        class MonoChunkParser
        {
            /*0x10*/ System.Net.WebHeaderCollection headers;
            /*0x18*/ int chunkSize;
            /*0x1c*/ int chunkRead;
            /*0x20*/ int totalWritten;
            /*0x24*/ System.Net.MonoChunkParser.State state;
            /*0x28*/ System.Text.StringBuilder saved;
            /*0x30*/ bool sawCR;
            /*0x31*/ bool gotit;
            /*0x34*/ int trailerState;
            /*0x38*/ System.Collections.ArrayList chunks;

            static /*0x78a1228*/ string RemoveChunkExtension(string input);
            static /*0x78a11d8*/ void ThrowProtocolViolation(string message);
            /*0x78a02d8*/ MonoChunkParser(System.Net.WebHeaderCollection headers);
            /*0x78a03a8*/ int Read(byte[] buffer, int offset, int size);
            /*0x78a03ac*/ int ReadFromChunks(byte[] buffer, int offset, int size);
            /*0x78a072c*/ void Write(byte[] buffer, int offset, int size);
            /*0x78a074c*/ void InternalWrite(byte[] buffer, ref int offset, int size);
            /*0x78a1078*/ bool get_WantMore();
            /*0x78a109c*/ bool get_DataAvailable();
            /*0x78a119c*/ int get_ChunkLeft();
            /*0x78a0b80*/ System.Net.MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size);
            /*0x78a0888*/ System.Net.MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size);
            /*0x78a0cc0*/ System.Net.MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size);
            /*0x78a0dc0*/ System.Net.MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size);

            enum State
            {
                None = 0,
                PartialSize = 1,
                Body = 2,
                BodyFinished = 3,
                Trailer = 4,
            }

            class Chunk
            {
                /*0x10*/ byte[] Bytes;
                /*0x18*/ int Offset;

                /*0x78a11a8*/ Chunk(byte[] chunk);
                /*0x78a06cc*/ int Read(byte[] buffer, int offset, int size);
            }
        }

        class MonoChunkStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x48*/ System.Net.MonoChunkParser <Decoder>k__BackingField;

            static /*0x78a1604*/ void ThrowExpectingChunkTrailer();
            /*0x78a1278*/ MonoChunkStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.WebHeaderCollection headers);
            /*0x78a1270*/ System.Net.MonoChunkParser get_Decoder();
            /*0x78a139c*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x78a1504*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x78a165c*/ System.Threading.Tasks.Task <>n__0(System.Threading.CancellationToken cancellationToken);

            struct <ProcessReadAsync>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.MonoChunkStream <>4__this;
                /*0x40*/ byte[] buffer;
                /*0x48*/ int offset;
                /*0x4c*/ int size;
                /*0x50*/ byte[] <moreBytes>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x78a1764*/ void MoveNext();
                /*0x78a1b94*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <FinishReading>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.MonoChunkStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ byte[] <buffer>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2;

                /*0x78a1c10*/ void MoveNext();
                /*0x78a20a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            /*0x10*/ System.Net.IAuthenticationModule authObject;

            /*0x78a210c*/ NtlmClient();
            /*0x78a2178*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78a2248*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78a2250*/ string get_AuthenticationType();
        }

        class ServicePoint
        {
            /*0x10*/ System.Uri uri;
            /*0x18*/ System.DateTime lastDnsResolve;
            /*0x20*/ System.Version protocolVersion;
            /*0x28*/ System.Net.IPHostEntry host;
            /*0x30*/ bool usesProxy;
            /*0x31*/ bool sendContinue;
            /*0x32*/ bool useConnect;
            /*0x38*/ object hostE;
            /*0x40*/ bool useNagle;
            /*0x48*/ System.Net.BindIPEndPoint endPointCallback;
            /*0x50*/ bool tcp_keepalive;
            /*0x54*/ int tcp_keepalive_time;
            /*0x58*/ int tcp_keepalive_interval;
            /*0x5c*/ bool disposed;
            /*0x60*/ int connectionLeaseTimeout;
            /*0x64*/ int receiveBufferSize;
            /*0x68*/ System.Net.ServicePointManager.SPKey <Key>k__BackingField;
            /*0x70*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
            /*0x78*/ int connectionLimit;
            /*0x7c*/ int maxIdleTime;
            /*0x80*/ object m_ServerCertificateOrBytes;
            /*0x88*/ object m_ClientCertificateOrBytes;

            static /*0x78a275c*/ void PutBytes(byte[] bytes, uint v, int offset);
            /*0x78a2290*/ ServicePoint(System.Net.ServicePointManager.SPKey key, System.Uri uri, int connectionLimit, int maxIdleTime);
            /*0x78a259c*/ System.Net.ServicePointManager.SPKey get_Key();
            /*0x78a25a4*/ System.Net.ServicePointScheduler get_Scheduler();
            /*0x78a25ac*/ void set_Scheduler(System.Net.ServicePointScheduler value);
            /*0x78a25b4*/ System.Uri get_Address();
            /*0x78a25bc*/ int get_ConnectionLimit();
            /*0x78a25c4*/ System.Version get_ProtocolVersion();
            /*0x78a25cc*/ void set_Expect100Continue(bool value);
            /*0x78a25d8*/ bool get_UseNagleAlgorithm();
            /*0x78a25e0*/ void set_UseNagleAlgorithm(bool value);
            /*0x789bbd4*/ bool get_SendContinue();
            /*0x78a25ec*/ void set_SendContinue(bool value);
            /*0x78a25f8*/ void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval);
            /*0x78a26a8*/ void KeepAliveSetup(System.Net.Sockets.Socket socket);
            /*0x78a27dc*/ bool get_UsesProxy();
            /*0x78a27e4*/ void set_UsesProxy(bool value);
            /*0x78a27f0*/ bool get_UseConnect();
            /*0x78a27f8*/ void set_UseConnect(bool value);
            /*0x78a2804*/ bool get_HasTimedOut();
            /*0x78a2930*/ System.Net.IPHostEntry get_HostEntry();
            /*0x78a2cf4*/ void SetVersion(System.Version version);
            /*0x7899c8c*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x78a2de8*/ void FreeServicePoint();
            /*0x78a2dfc*/ void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x78a2e38*/ void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x78a2e74*/ bool CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote);
        }

        class ServicePointManager
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Net.ServicePointManager.SPKey, System.Net.ServicePoint> servicePoints;
            static /*0x8*/ System.Net.ICertificatePolicy policy;
            static /*0x10*/ int defaultConnectionLimit;
            static /*0x14*/ int maxServicePointIdleTime;
            static /*0x18*/ int maxServicePoints;
            static /*0x1c*/ int dnsRefreshTimeout;
            static /*0x20*/ bool _checkCRL;
            static /*0x24*/ System.Net.SecurityProtocolType _securityProtocol;
            static /*0x28*/ bool expectContinue;
            static /*0x29*/ bool useNagle;
            static /*0x30*/ System.Net.ServerCertValidationCallback server_cert_cb;
            static /*0x38*/ bool tcp_keepalive;
            static /*0x3c*/ int tcp_keepalive_time;
            static /*0x40*/ int tcp_keepalive_interval;

            static /*0x78a3018*/ ServicePointManager();
            static /*0x78a30d8*/ System.Net.ICertificatePolicy GetLegacyCertificatePolicy();
            static /*0x78a3130*/ bool get_CheckCertificateRevocationList();
            static /*0x78a3188*/ int get_DnsRefreshTimeout();
            static /*0x78a31e0*/ System.Net.SecurityProtocolType get_SecurityProtocol();
            static /*0x78a3238*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            static /*0x78a3290*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            static /*0x789920c*/ System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy);
            static /*0x78a3370*/ void RemoveServicePoint(System.Net.ServicePoint sp);

            class SPKey
            {
                /*0x10*/ System.Uri uri;
                /*0x18*/ System.Uri proxy;
                /*0x20*/ bool use_connect;

                /*0x78a3318*/ SPKey(System.Uri uri, System.Uri proxy, bool use_connect);
                /*0x78a3408*/ bool get_UsesProxy();
                /*0x78a3468*/ int GetHashCode();
                /*0x78a353c*/ bool Equals(object obj);
            }
        }

        class ServicePointScheduler
        {
            static /*0x0*/ int nextId;
            /*0x10*/ System.Net.ServicePoint <ServicePoint>k__BackingField;
            /*0x18*/ int running;
            /*0x1c*/ int maxIdleTime;
            /*0x20*/ System.Net.ServicePointScheduler.AsyncManualResetEvent schedulerEvent;
            /*0x28*/ System.Net.ServicePointScheduler.ConnectionGroup defaultGroup;
            /*0x30*/ System.Collections.Generic.Dictionary<string, System.Net.ServicePointScheduler.ConnectionGroup> groups;
            /*0x38*/ System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebOperation>> operations;
            /*0x40*/ System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebConnection, System.Threading.Tasks.Task>> idleConnections;
            /*0x48*/ int currentConnections;
            /*0x4c*/ int connectionLimit;
            /*0x50*/ System.DateTime idleSince;
            /*0x58*/ int ID;

            static /*0x78a4e38*/ System.Threading.Tasks.Task<bool> WaitAsync(System.Threading.Tasks.Task workerTask, int millisecondTimeout);
            /*0x78a2398*/ ServicePointScheduler(System.Net.ServicePoint servicePoint, int connectionLimit, int maxIdleTime);
            /*0x78a3630*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78a3638*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x78a3640*/ int get_MaxIdleTime();
            /*0x78a382c*/ void Run();
            /*0x78a3b24*/ System.Threading.Tasks.Task RunScheduler();
            /*0x78a3c0c*/ void Cleanup();
            /*0x78a3e60*/ void RunSchedulerIteration();
            /*0x78a418c*/ bool OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation);
            /*0x78a4900*/ void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection);
            /*0x78a40ac*/ bool SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group);
            /*0x78a4a20*/ void RemoveOperation(System.Net.WebOperation operation);
            /*0x78a45a4*/ void RemoveIdleConnection(System.Net.WebConnection connection);
            /*0x78a4aec*/ void FinalCleanup();
            /*0x78a2cfc*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x78a4bb4*/ System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name);
            /*0x78a4e10*/ void OnConnectionCreated(System.Net.WebConnection connection);
            /*0x78a4e1c*/ void OnConnectionClosed(System.Net.WebConnection connection);
            /*0x78a4f58*/ System.Threading.Tasks.Task <Run>b__31_0();

            class ConnectionGroup
            {
                static /*0x0*/ int nextId;
                /*0x10*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;
                /*0x20*/ int ID;
                /*0x28*/ System.Collections.Generic.LinkedList<System.Net.WebConnection> connections;
                /*0x30*/ System.Collections.Generic.LinkedList<System.Net.WebOperation> queue;

                /*0x78a36f4*/ ConnectionGroup(System.Net.ServicePointScheduler scheduler, string name);
                /*0x78a4f5c*/ System.Net.ServicePointScheduler get_Scheduler();
                /*0x78a3dec*/ bool IsEmpty();
                /*0x78a451c*/ void RemoveConnection(System.Net.WebConnection connection);
                /*0x78a4670*/ void Cleanup();
                /*0x78a4db8*/ void EnqueueOperation(System.Net.WebOperation operation);
                /*0x78a4938*/ System.Net.WebOperation GetNextOperation();
                /*0x78a4fdc*/ System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation);
                /*0x78a475c*/ System.ValueTuple<System.Net.WebConnection, bool> CreateOrReuseConnection(System.Net.WebOperation operation, bool force);
            }

            class AsyncManualResetEvent
            {
                /*0x10*/ System.Threading.Tasks.TaskCompletionSource<bool> m_tcs;

                /*0x78a3648*/ AsyncManualResetEvent(bool state);
                /*0x78a5948*/ System.Threading.Tasks.Task<bool> WaitAsync(int millisecondTimeout);
                /*0x78a38f0*/ void Set();
                /*0x78a3fec*/ void Reset();

                class <>c
                {
                    static /*0x0*/ System.Net.ServicePointScheduler.AsyncManualResetEvent.<> <>9;
                    static /*0x8*/ System.Func<object, bool> <>9__4_0;

                    static /*0x78a599c*/ <>c();
                    /*0x78a5a04*/ <>c();
                    /*0x78a5a0c*/ bool <Set>b__4_0(object s);
                }
            }

            struct <RunScheduler>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.ServicePointScheduler <>4__this;
                /*0x38*/ System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebOperation> <operationArray>5__2;
                /*0x40*/ System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebConnection, System.Threading.Tasks.Task> <idleArray>5__3;
                /*0x48*/ System.Collections.Generic.List<System.Threading.Tasks.Task> <taskList>5__4;
                /*0x50*/ System.Threading.Tasks.Task<bool> <schedulerTask>5__5;
                /*0x58*/ bool <finalCleanup>5__6;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                /*0x78a5aa8*/ void MoveNext();
                /*0x78a667c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WaitAsync>d__46 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ int millisecondTimeout;
                /*0x38*/ System.Threading.Tasks.Task workerTask;
                /*0x40*/ System.Threading.CancellationTokenSource <cts>5__2;
                /*0x48*/ System.Threading.Tasks.Task <timeoutTask>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                /*0x78a66e4*/ void MoveNext();
                /*0x78a6be8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource<T>
        {
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion;
            /*0x0*/ System.Net.WebCompletionSource.Result<T> currentResult;

            /*0x380cdf0*/ WebCompletionSource(bool runAsync);
            /*0x380b9e8*/ System.Net.WebCompletionSource.Result<T> get_CurrentResult();
            /*0x380b9e8*/ System.Threading.Tasks.Task get_Task();
            /*0x3907c14*/ bool TrySetCompleted(T argument);
            /*0x380b128*/ bool TrySetCompleted();
            /*0x380b128*/ bool TrySetCanceled();
            /*0x380b2f0*/ bool TrySetCanceled(System.OperationCanceledException error);
            /*0x380b2f0*/ bool TrySetException(System.Exception error);
            /*0x380cb08*/ void ThrowOnError();
            /*0x380b9e8*/ System.Threading.Tasks.Task<T> WaitForCompletion();

            enum Status<T>
            {
                Running = 0,
                Completed = 1,
                Canceled = 2,
                Faulted = 3,
            }

            class Result<T>
            {
                /*0x0*/ System.Net.WebCompletionSource.Status<T> <Status>k__BackingField;
                /*0x0*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo <Error>k__BackingField;
                /*0x0*/ T <Argument>k__BackingField;

                /*0x3907c14*/ Result(T argument);
                /*0x3907c14*/ Result(System.Net.WebCompletionSource.Status<T> state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x3907c14*/ System.Net.WebCompletionSource.Status<T> get_Status();
                /*0x380b128*/ bool get_Success();
                /*0x380b9e8*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
                /*0x3907c14*/ T get_Argument();
            }

            struct <WaitForCompletion>d__15<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ System.Net.WebCompletionSource<T> <>4__this;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebCompletionSource.Result<T>> <>u__1;

                /*0x380cb08*/ void MoveNext();
                /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource : System.Net.WebCompletionSource<object>
        {
            /*0x789e36c*/ WebCompletionSource();
        }

        enum ReadState
        {
            None = 0,
            Status = 1,
            Headers = 2,
            Content = 3,
            Aborted = 4,
        }

        class WebConnection : System.IDisposable
        {
            /*0x10*/ System.Net.NetworkCredential ntlm_credentials;
            /*0x18*/ bool ntlm_authenticated;
            /*0x19*/ bool unsafe_sharing;
            /*0x20*/ System.IO.Stream networkStream;
            /*0x28*/ System.Net.Sockets.Socket socket;
            /*0x30*/ Mono.Net.Security.MonoTlsStream monoTlsStream;
            /*0x38*/ System.Net.WebConnectionTunnel tunnel;
            /*0x40*/ int disposed;
            /*0x48*/ System.Net.ServicePoint <ServicePoint>k__BackingField;
            /*0x50*/ System.DateTime idleSince;
            /*0x58*/ System.Net.WebOperation currentOperation;

            static /*0x78a70f8*/ System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error);
            static /*0x78a7278*/ bool ReadLine(byte[] buffer, ref int start, int max, ref string output);
            /*0x78a5918*/ WebConnection(System.Net.ServicePoint sPoint);
            /*0x78a6c64*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78a6c6c*/ bool CanReuse();
            /*0x78a6c9c*/ bool CheckReusable();
            /*0x78a6d38*/ System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x78a6e54*/ System.Threading.Tasks.Task<bool> CreateStream(System.Net.WebOperation operation, bool reused, System.Threading.CancellationToken cancellationToken);
            /*0x78a6fac*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x78a52f8*/ bool CanReuseConnection(System.Net.WebOperation operation);
            /*0x78a7454*/ bool PrepareSharingNtlm(System.Net.WebOperation operation);
            /*0x78a7770*/ void Reset();
            /*0x78a786c*/ void Close(bool reset);
            /*0x78a7934*/ void CloseSocket();
            /*0x78a4f6c*/ bool get_Closed();
            /*0x78a7bd0*/ System.DateTime get_IdleSince();
            /*0x78a5724*/ bool StartOperation(System.Net.WebOperation operation, bool reused);
            /*0x78a43ac*/ bool Continue(System.Net.WebOperation next);
            /*0x78a7f0c*/ void Dispose(bool disposing);
            /*0x78a4f64*/ void Dispose();
            /*0x78a7844*/ void ResetNtlm();
            /*0x78a7f44*/ bool get_NtlmAuthenticated();
            /*0x78a7f4c*/ void set_NtlmAuthenticated(bool value);
            /*0x78a7f58*/ System.Net.NetworkCredential get_NtlmCredential();
            /*0x78a7f60*/ void set_NtlmCredential(System.Net.NetworkCredential value);
            /*0x78a7f68*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x78a7f70*/ void set_UnsafeAuthenticatedConnectionSharing(bool value);

            class <>c
            {
                static /*0x0*/ System.Net.WebConnection.<> <>9;
                static /*0x8*/ System.Func<System.Net.IPEndPoint, System.AsyncCallback, object, System.IAsyncResult> <>9__16_0;
                static /*0x10*/ System.Action<System.IAsyncResult> <>9__16_1;

                static /*0x78a7f7c*/ <>c();
                /*0x78a7fe4*/ <>c();
                /*0x78a7fec*/ System.IAsyncResult <Connect>b__16_0(System.Net.IPEndPoint targetEndPoint, System.AsyncCallback callback, object state);
                /*0x78a808c*/ void <Connect>b__16_1(System.IAsyncResult asyncResult);
            }

            struct <Connect>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebConnection <>4__this;
                /*0x38*/ System.Net.WebOperation operation;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Exception <connectException>5__2;
                /*0x50*/ System.Net.IPAddress[] <>7__wrap2;
                /*0x58*/ int <>7__wrap3;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x78a8180*/ void MoveNext();
                /*0x78a8c50*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ System.Net.WebConnection <>4__this;
                /*0x38*/ System.Net.WebOperation operation;
                /*0x40*/ bool reused;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Net.Sockets.NetworkStream <stream>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__2;

                /*0x78a8cb8*/ void MoveNext();
                /*0x78a957c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitConnection>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.WebRequestStream> <>t__builder;
                /*0x30*/ System.Net.WebOperation operation;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.WebConnection <>4__this;
                /*0x48*/ bool <reused>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;

                /*0x78a95f8*/ void MoveNext();
                /*0x78a9bd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebConnectionStream : System.IO.Stream
        {
            /*0x28*/ bool closed;
            /*0x29*/ bool disposed;
            /*0x30*/ object locker;
            /*0x38*/ int read_timeout;
            /*0x3c*/ int write_timeout;
            /*0x40*/ System.Net.HttpWebRequest <Request>k__BackingField;
            /*0x48*/ System.Net.WebConnection <Connection>k__BackingField;
            /*0x50*/ System.Net.WebOperation <Operation>k__BackingField;

            /*0x78a9c54*/ WebConnectionStream(System.Net.WebConnection cnc, System.Net.WebOperation operation);
            /*0x78a9d4c*/ System.Net.HttpWebRequest get_Request();
            /*0x78a9d54*/ System.Net.WebConnection get_Connection();
            /*0x78a9d5c*/ System.Net.WebOperation get_Operation();
            /*0x78a9d64*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78a9d80*/ bool get_CanTimeout();
            /*0x78a9d88*/ int get_ReadTimeout();
            /*0x78a9d90*/ void set_ReadTimeout(int value);
            /*0x78a9df0*/ int get_WriteTimeout();
            /*0x78a9df8*/ void set_WriteTimeout(int value);
            /*0x78a9e58*/ System.Exception GetException(System.Exception e);
            bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x78a9fb8*/ int Read(byte[] buffer, int offset, int count);
            /*0x78aa2ac*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x78aa46c*/ int EndRead(System.IAsyncResult r);
            /*0x78aa58c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x78aa74c*/ void EndWrite(System.IAsyncResult r);
            /*0x78aa840*/ void Write(byte[] buffer, int offset, int count);
            /*0x78aaa28*/ void Flush();
            /*0x78aaa2c*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x789cfa4*/ void InternalClose();
            /*0x380d83c*/ void Close_internal(ref bool disposed);
            /*0x78aab10*/ void Close();
            /*0x78aab24*/ long Seek(long a, System.IO.SeekOrigin b);
            /*0x78aab70*/ void SetLength(long a);
            /*0x78aabbc*/ bool get_CanSeek();
            /*0x78aabc4*/ long get_Length();
            /*0x78aac10*/ long get_Position();
            /*0x78aac5c*/ void set_Position(long value);
        }

        class WebConnectionTunnel
        {
            /*0x10*/ System.Net.HttpWebRequest <Request>k__BackingField;
            /*0x18*/ System.Uri <ConnectUri>k__BackingField;
            /*0x20*/ System.Net.HttpWebRequest connectRequest;
            /*0x28*/ System.Net.WebConnectionTunnel.NtlmAuthState ntlmAuthState;
            /*0x2c*/ bool <Success>k__BackingField;
            /*0x2d*/ bool <CloseConnection>k__BackingField;
            /*0x30*/ int <StatusCode>k__BackingField;
            /*0x38*/ string <StatusDescription>k__BackingField;
            /*0x40*/ string[] <Challenge>k__BackingField;
            /*0x48*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x50*/ System.Version <ProxyVersion>k__BackingField;
            /*0x58*/ byte[] <Data>k__BackingField;

            /*0x78a941c*/ WebConnectionTunnel(System.Net.HttpWebRequest request, System.Uri connectUri);
            /*0x78aaca8*/ System.Net.HttpWebRequest get_Request();
            /*0x78aacb0*/ System.Uri get_ConnectUri();
            /*0x78aacb8*/ bool get_Success();
            /*0x78aacc0*/ void set_Success(bool value);
            /*0x78aaccc*/ bool get_CloseConnection();
            /*0x78aacd4*/ void set_CloseConnection(bool value);
            /*0x78aace0*/ int get_StatusCode();
            /*0x78aace8*/ void set_StatusCode(int value);
            /*0x78aacf0*/ void set_StatusDescription(string value);
            /*0x78aacf8*/ string[] get_Challenge();
            /*0x78aad00*/ void set_Challenge(string[] value);
            /*0x78aad08*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78aad10*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x78aad18*/ System.Version get_ProxyVersion();
            /*0x78aad20*/ void set_ProxyVersion(System.Version value);
            /*0x78aad28*/ byte[] get_Data();
            /*0x78aad30*/ void set_Data(byte[] value);
            /*0x78a9460*/ System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x78aad38*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x78aae88*/ void FlushContents(System.IO.Stream stream, int contentLength);

            enum NtlmAuthState
            {
                None = 0,
                Challenge = 1,
                Response = 2,
            }

            struct <Initialize>d__42 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebConnectionTunnel <>4__this;
                /*0x38*/ System.IO.Stream stream;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ bool <have_auth>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> <>u__2;

                /*0x78aaf1c*/ void MoveNext();
                /*0x78abd14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadHeaders>d__43 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.IO.Stream stream;
                /*0x40*/ System.Net.WebConnectionTunnel <>4__this;
                /*0x48*/ byte[] <retBuffer>5__2;
                /*0x50*/ int <status>5__3;
                /*0x58*/ byte[] <buffer>5__4;
                /*0x60*/ System.IO.MemoryStream <ms>5__5;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x78abd7c*/ void MoveNext();
                /*0x78ac698*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebOperation
        {
            /*0x10*/ System.Net.HttpWebRequest <Request>k__BackingField;
            /*0x18*/ System.Net.WebConnection <Connection>k__BackingField;
            /*0x20*/ System.Net.ServicePoint <ServicePoint>k__BackingField;
            /*0x28*/ System.Net.BufferOffsetSize <WriteBuffer>k__BackingField;
            /*0x30*/ bool <IsNtlmChallenge>k__BackingField;
            /*0x38*/ System.Threading.CancellationTokenSource cts;
            /*0x40*/ System.Net.WebCompletionSource<System.Net.WebRequestStream> requestTask;
            /*0x48*/ System.Net.WebCompletionSource<System.Net.WebRequestStream> requestWrittenTask;
            /*0x50*/ System.Net.WebCompletionSource<System.Net.WebResponseStream> responseTask;
            /*0x58*/ System.Net.WebCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> finishedTask;
            /*0x60*/ System.Net.WebRequestStream writeStream;
            /*0x68*/ System.Net.WebResponseStream responseStream;
            /*0x70*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo disposedInfo;
            /*0x78*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo closedInfo;
            /*0x80*/ System.Net.WebOperation priorityRequest;
            /*0x88*/ int requestSent;
            /*0x8c*/ int finished;

            /*0x7899aa4*/ WebOperation(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, bool isNtlmChallenge, System.Threading.CancellationToken cancellationToken);
            /*0x78ac714*/ System.Net.HttpWebRequest get_Request();
            /*0x78ac71c*/ System.Net.WebConnection get_Connection();
            /*0x78ac724*/ void set_Connection(System.Net.WebConnection value);
            /*0x78ac72c*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78ac734*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x78ac73c*/ System.Net.BufferOffsetSize get_WriteBuffer();
            /*0x78ac744*/ bool get_IsNtlmChallenge();
            /*0x78a4f7c*/ bool get_Aborted();
            /*0x78ac74c*/ bool get_Closed();
            /*0x789af58*/ void Abort();
            /*0x78ac928*/ void Close();
            /*0x78ac860*/ void SetCanceled();
            /*0x78ac9d4*/ void SetError(System.Exception error);
            /*0x78ac778*/ System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo, bool> SetDisposed(ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x78aca78*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x78acb58*/ void ThrowIfDisposed();
            /*0x78a8bd0*/ void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x78aa24c*/ void ThrowIfClosedOrDisposed();
            /*0x78a9b50*/ void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x78acb00*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x78a7bd8*/ void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection);
            /*0x789c43c*/ void SetPriorityRequest(System.Net.WebOperation operation);
            /*0x789a24c*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStream();
            /*0x789e3d0*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal();
            /*0x789e3b8*/ System.Net.WebRequestStream get_WriteStream();
            /*0x789e420*/ System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream();
            /*0x78acbb8*/ System.Net.WebCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> get_Finished();
            /*0x78a7e60*/ void Run();
            /*0x78acbc0*/ void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error);
            /*0x789e470*/ void Finish(bool ok, System.Exception error);
            /*0x78acc40*/ void <RegisterRequest>b__48_0();

            struct <GetRequestStream>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                /*0x30*/ System.Net.WebOperation <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;

                /*0x78acc64*/ void MoveNext();
                /*0x78acee0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Run>d__58 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.WebOperation <>4__this;
                /*0x40*/ System.Net.WebRequestStream <requestStream>5__2;
                /*0x48*/ System.Net.WebResponseStream <stream>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0x78acf5c*/ void MoveNext();
                /*0x78ad58c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebReadStream : System.IO.Stream
        {
            /*0x28*/ System.Net.WebOperation <Operation>k__BackingField;
            /*0x30*/ System.IO.Stream <InnerStream>k__BackingField;
            /*0x38*/ bool disposed;

            /*0x78a1314*/ WebReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream);
            /*0x78ad598*/ System.Net.WebOperation get_Operation();
            /*0x78ad5a0*/ System.IO.Stream get_InnerStream();
            /*0x78ad5a8*/ long get_Length();
            /*0x78ad5e0*/ long get_Position();
            /*0x78ad618*/ void set_Position(long value);
            /*0x78ad650*/ bool get_CanSeek();
            /*0x78ad658*/ bool get_CanRead();
            /*0x78ad660*/ bool get_CanWrite();
            /*0x78ad668*/ void SetLength(long value);
            /*0x78ad6a0*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x78ad6d8*/ void Write(byte[] buffer, int offset, int count);
            /*0x78ad710*/ void Flush();
            /*0x78ad748*/ System.Exception GetException(System.Exception e);
            /*0x78ad8a8*/ int Read(byte[] buffer, int offset, int size);
            /*0x78adb00*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x78adcc0*/ int EndRead(System.IAsyncResult r);
            /*0x78adde0*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x78a1660*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x78adf40*/ void Dispose(bool disposing);

            struct <ReadAsync>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Net.WebReadStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ byte[] buffer;
                /*0x48*/ int offset;
                /*0x4c*/ int size;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0x78adf8c*/ void MoveNext();
                /*0x78ae580*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebRequestStream : System.Net.WebConnectionStream
        {
            static /*0x0*/ byte[] crlf;
            /*0x58*/ System.IO.MemoryStream writeBuffer;
            /*0x60*/ bool requestWritten;
            /*0x61*/ bool allowBuffering;
            /*0x62*/ bool sendChunked;
            /*0x68*/ System.Net.WebCompletionSource pendingWrite;
            /*0x70*/ long totalWritten;
            /*0x78*/ byte[] headers;
            /*0x80*/ bool headersSent;
            /*0x84*/ int completeRequestWritten;
            /*0x88*/ int chunkTrailerWritten;
            /*0x90*/ System.IO.Stream <InnerStream>k__BackingField;
            /*0x98*/ bool <KeepAlive>k__BackingField;

            static /*0x77cb94c*/ WebRequestStream();
            /*0x77ca888*/ WebRequestStream(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel);
            /*0x77caa0c*/ System.IO.Stream get_InnerStream();
            /*0x77caa14*/ bool get_KeepAlive();
            /*0x77caa1c*/ bool get_CanRead();
            /*0x77caa24*/ bool get_CanWrite();
            /*0x77caa2c*/ bool get_HasWriteBuffer();
            /*0x77caa60*/ int get_WriteBufferLength();
            /*0x77caaa4*/ System.Net.BufferOffsetSize GetWriteBuffer();
            /*0x77cab78*/ System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken);
            /*0x77cac70*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x77caed4*/ System.Threading.Tasks.Task WriteAsyncInner(byte[] buffer, int offset, int size, System.Net.WebCompletionSource completion, System.Threading.CancellationToken cancellationToken);
            /*0x77cb020*/ System.Threading.Tasks.Task ProcessWrite(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x77cb154*/ void CheckWriteOverflow(long contentLength, long totalWritten, long size);
            /*0x77cb1f8*/ System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken);
            /*0x77cb2f4*/ System.Threading.Tasks.Task SetHeadersAsync(bool setInternalLength, System.Threading.CancellationToken cancellationToken);
            /*0x77cb404*/ System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken);
            /*0x77cb500*/ System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken);
            /*0x77cb5f8*/ System.Threading.Tasks.Task WriteChunkTrailer();
            /*0x77cb1ec*/ void KillBuffer();
            /*0x77cb6e4*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x77cb794*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x77cb7cc*/ void Close_internal(ref bool disposed);

            struct <FinishWriting>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x77cb9ec*/ void MoveNext();
                /*0x77cbd30*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteAsyncInner>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int offset;
                /*0x44*/ int size;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Net.WebCompletionSource completion;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x77cbd98*/ void MoveNext();
                /*0x77cc2e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessWrite>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x77cc350*/ void MoveNext();
                /*0x77cc924*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Initialize>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x77cc98c*/ void MoveNext();
                /*0x77ccd18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SetHeadersAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool setInternalLength;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x77ccd80*/ void MoveNext();
                /*0x77cd484*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteRequestAsync>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.BufferOffsetSize <buffer>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x77cd4ec*/ void MoveNext();
                /*0x77cda78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer_inner>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x77cdae0*/ void MoveNext();
                /*0x77cdd70*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationTokenSource <cts>5__2;
                /*0x40*/ System.Threading.Tasks.Task <timeoutTask>5__3;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0x77cddd8*/ void MoveNext();
                /*0x77ce574*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebResponseStream : System.Net.WebConnectionStream
        {
            /*0x58*/ System.Net.WebReadStream innerStream;
            /*0x60*/ bool nextReadCalled;
            /*0x61*/ bool bufferedEntireContent;
            /*0x68*/ System.Net.WebCompletionSource pendingRead;
            /*0x70*/ object locker;
            /*0x78*/ int nestedRead;
            /*0x7c*/ bool read_eof;
            /*0x80*/ System.Net.WebRequestStream <RequestStream>k__BackingField;
            /*0x88*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x90*/ System.Net.HttpStatusCode <StatusCode>k__BackingField;
            /*0x98*/ string <StatusDescription>k__BackingField;
            /*0xa0*/ System.Version <Version>k__BackingField;
            /*0xa8*/ bool <KeepAlive>k__BackingField;
            /*0xa9*/ bool <ChunkedRead>k__BackingField;

            /*0x77ce638*/ WebResponseStream(System.Net.WebRequestStream request);
            /*0x77ce5dc*/ System.Net.WebRequestStream get_RequestStream();
            /*0x77ce5e4*/ System.Net.WebHeaderCollection get_Headers();
            /*0x77ce5ec*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x77ce5f4*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x77ce5fc*/ void set_StatusCode(System.Net.HttpStatusCode value);
            /*0x77ce604*/ string get_StatusDescription();
            /*0x77ce60c*/ void set_StatusDescription(string value);
            /*0x77ce614*/ System.Version get_Version();
            /*0x77ce61c*/ void set_Version(System.Version value);
            /*0x77ce624*/ bool get_KeepAlive();
            /*0x77ce62c*/ void set_KeepAlive(bool value);
            /*0x77ce6cc*/ bool get_CanRead();
            /*0x77ce6d4*/ bool get_CanWrite();
            /*0x77ce6dc*/ bool get_ChunkedRead();
            /*0x77ce6e4*/ void set_ChunkedRead(bool value);
            /*0x77ce6f0*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x77ce858*/ System.Threading.Tasks.Task<int> ProcessRead(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x77ceb18*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x77cebe4*/ bool get_ExpectContent();
            /*0x77cec78*/ void Initialize(System.Net.BufferOffsetSize buffer);
            /*0x77cf1c0*/ System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(System.Threading.CancellationToken cancellationToken);
            /*0x77cf2fc*/ System.Threading.Tasks.Task ReadAllAsync(bool resending, System.Threading.CancellationToken cancellationToken);
            /*0x77cf410*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x77cf4ac*/ void Close_internal(ref bool disposed);
            /*0x77cf554*/ System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, string where);
            /*0x77cf7ec*/ System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x77cf8e8*/ bool GetResponse(System.Net.BufferOffsetSize buffer, ref int pos, ref System.Net.ReadState state);

            struct <ReadAsync>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int offset;
                /*0x44*/ int count;
                /*0x48*/ System.Net.WebResponseStream <>4__this;
                /*0x50*/ System.Net.WebCompletionSource <completion>5__2;
                /*0x58*/ int <nbytes>5__3;
                /*0x60*/ System.Exception <throwMe>5__4;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;
                /*0x78*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2;

                /*0x77d00ac*/ void MoveNext();
                /*0x77d0aac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ System.Net.WebResponseStream <>4__this;
                /*0x18*/ byte[] buffer;
                /*0x20*/ int offset;
                /*0x24*/ int size;

                /*0x77ceb10*/ <>c__DisplayClass41_0();
                /*0x77d0b28*/ System.Threading.Tasks.Task<int> <ProcessRead>b__0(System.Threading.CancellationToken ct);
                /*0x77d0b64*/ void <ProcessRead>b__1();
                /*0x77d0ba4*/ bool <ProcessRead>b__2();
            }

            struct <ReadAllAsyncInner>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Byte[]> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.WebResponseStream <>4__this;
                /*0x40*/ long <maximumSize>5__2;
                /*0x48*/ System.IO.MemoryStream <ms>5__3;
                /*0x50*/ byte[] <buffer>5__4;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x77d0bc8*/ void MoveNext();
                /*0x77d11d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadAllAsync>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool resending;
                /*0x48*/ System.Net.WebCompletionSource <completion>5__2;
                /*0x50*/ System.Threading.CancellationTokenSource <timeoutCts>5__3;
                /*0x58*/ System.Threading.Tasks.Task <timeoutTask>5__4;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Byte[]> <>u__2;

                /*0x77d124c*/ void MoveNext();
                /*0x77d1ccc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitReadAsync>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.BufferOffsetSize <buffer>5__2;
                /*0x48*/ System.Net.ReadState <state>5__3;
                /*0x4c*/ int <position>5__4;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x77d1d34*/ void MoveNext();
                /*0x77d2470*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace NetworkInformation
        {
            class IPGlobalProperties
            {
                static /*0x77d24d8*/ System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties();
                static /*0x77d2524*/ System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties();
                /*0x77d2528*/ IPGlobalProperties();
                /*0x380b9e8*/ string get_DomainName();
            }

            class NetworkInformationException : System.ComponentModel.Win32Exception
            {
                /*0x77d2530*/ NetworkInformationException();
                /*0x77d2594*/ NetworkInformationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            }

            enum NetworkInterfaceComponent
            {
                IPv4 = 0,
                IPv6 = 1,
            }

            class IPGlobalPropertiesFactoryPal
            {
                static /*0x77d24dc*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }

            class CommonUnixIPGlobalProperties : System.Net.NetworkInformation.IPGlobalProperties
            {
                static /*0x77d263c*/ int getdomainname(byte[] name, int len);
                /*0x77d2854*/ CommonUnixIPGlobalProperties();
                /*0x77d26c8*/ string get_DomainName();
            }

            class UnixIPGlobalProperties : System.Net.NetworkInformation.CommonUnixIPGlobalProperties
            {
                /*0x77d285c*/ UnixIPGlobalProperties();
            }

            class UnixNoLibCIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                /*0x77d287c*/ UnixNoLibCIPGlobalProperties();
                /*0x77d2864*/ string get_DomainName();
            }

            class MibIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                static /*0x0*/ char[] wsChars;
                /*0x10*/ string StatisticsFile;
                /*0x18*/ string StatisticsFileIPv6;
                /*0x20*/ string TcpFile;
                /*0x28*/ string Tcp6File;
                /*0x30*/ string UdpFile;
                /*0x38*/ string Udp6File;

                static /*0x77d2a30*/ MibIPGlobalProperties();
                /*0x77d2884*/ MibIPGlobalProperties(string procDir);
            }

            class UnixIPGlobalPropertiesFactoryPal
            {
                static /*0x0*/ bool <PlatformNeedsLibCWorkaround>k__BackingField;

                static /*0x77d2ad0*/ bool get_PlatformNeedsLibCWorkaround();
                static /*0x77d259c*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }
        }

        namespace Configuration
        {
            class DefaultProxySectionInternal
            {
                static /*0x0*/ object classSyncObject;
                /*0x10*/ System.Net.IWebProxy webProxy;

                static /*0x77d2b18*/ System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode();
                static /*0x77d2b20*/ System.Net.IWebProxy GetSystemWebProxy();
                static /*0x77d2b28*/ object get_ClassSyncObject();
                static /*0x77d2bc0*/ System.Net.Configuration.DefaultProxySectionInternal GetSection();
                /*0x77d2ce0*/ DefaultProxySectionInternal();
                /*0x77d2ce8*/ System.Net.IWebProxy get_WebProxy();
            }

            class SettingsSectionInternal
            {
                static /*0x0*/ System.Net.Configuration.SettingsSectionInternal instance;
                /*0x10*/ bool HttpListenerUnescapeRequestUrl;
                /*0x14*/ System.Net.Sockets.IPProtectionLevel IPProtectionLevel;

                static /*0x77d2d68*/ SettingsSectionInternal();
                static /*0x77d2cf0*/ System.Net.Configuration.SettingsSectionInternal get_Section();
                /*0x77d2d50*/ SettingsSectionInternal();
                /*0x77d2d48*/ bool get_Ipv6Enabled();
            }
        }

        namespace Cache
        {
            class RequestCache
            {
                static /*0x0*/ char[] LineSplits;

                static /*0x77d2de0*/ RequestCache();
            }

            class RequestCacheValidator
            {
                /*0x77d2e80*/ object CreateValidator();
            }

            class RequestCacheBinding
            {
                /*0x10*/ System.Net.Cache.RequestCache m_RequestCache;
                /*0x18*/ System.Net.Cache.RequestCacheValidator m_CacheValidator;

                /*0x77d2eb8*/ System.Net.Cache.RequestCache get_Cache();
                /*0x77d2ec0*/ System.Net.Cache.RequestCacheValidator get_Validator();
            }

            enum RequestCacheLevel
            {
                Default = 0,
                BypassCache = 1,
                CacheOnly = 2,
                CacheIfAvailable = 3,
                Revalidate = 4,
                Reload = 5,
                NoCacheNoStore = 6,
            }

            class RequestCachePolicy
            {
                /*0x10*/ System.Net.Cache.RequestCacheLevel m_Level;

                /*0x77d2ec8*/ RequestCachePolicy(System.Net.Cache.RequestCacheLevel level);
                /*0x77d2f40*/ System.Net.Cache.RequestCacheLevel get_Level();
                /*0x77d2f48*/ string ToString();
            }

            class RequestCacheProtocol
            {
                /*0x77d2fe0*/ RequestCacheProtocol(object arg1, object arg2);
            }
        }

        namespace Sockets
        {
            class NetworkStream : System.IO.Stream
            {
                /*0x28*/ System.Net.Sockets.Socket _streamSocket;
                /*0x30*/ bool _ownsSocket;
                /*0x31*/ bool _readable;
                /*0x32*/ bool _writeable;
                /*0x34*/ int _closeTimeout;
                /*0x38*/ bool _cleanedUp;
                /*0x3c*/ int _currentReadTimeout;
                /*0x40*/ int _currentWriteTimeout;

                /*0x77d3020*/ NetworkStream(System.Net.Sockets.Socket socket);
                /*0x77d31dc*/ NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket);
                /*0x77d302c*/ NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access, bool ownsSocket);
                /*0x77d31e8*/ bool get_CanRead();
                /*0x77d31f0*/ bool get_CanSeek();
                /*0x77d31f8*/ bool get_CanWrite();
                /*0x77d3200*/ bool get_CanTimeout();
                /*0x77d3208*/ int get_ReadTimeout();
                /*0x77d33f0*/ void set_ReadTimeout(int value);
                /*0x77d3618*/ int get_WriteTimeout();
                /*0x77d3674*/ void set_WriteTimeout(int value);
                /*0x77d36f8*/ long get_Length();
                /*0x77d3744*/ long get_Position();
                /*0x77d3790*/ void set_Position(long value);
                /*0x77d37dc*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x77d3828*/ int Read(byte[] buffer, int offset, int size);
                /*0x77d3b70*/ int Read(System.Span<byte> destination);
                /*0x77d3ec4*/ int ReadByte();
                /*0x77d3f28*/ void Write(byte[] buffer, int offset, int size);
                /*0x77d4270*/ void Write(System.ReadOnlySpan<byte> source);
                /*0x77d4544*/ void WriteByte(byte value);
                /*0x77d459c*/ void Close(int timeout);
                /*0x77d4600*/ void Dispose(bool disposing);
                /*0x77d4708*/ void Finalize();
                /*0x77d47ac*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x77d4b24*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x77d4d88*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x77d5100*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x77d5364*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x77d59f8*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x77d5c3c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x77d62e0*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x77d6520*/ void Flush();
                /*0x77d6524*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x77d65ac*/ void SetLength(long value);
                /*0x77d3474*/ void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, int timeout, bool silent);
                /*0x77d6734*/ System.Net.Sockets.Socket get_InternalSocket();
            }

            class Socket : System.IDisposable
            {
                static /*0x0*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> AcceptCompletedHandler;
                static /*0x8*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> ReceiveCompletedHandler;
                static /*0x10*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> SendCompletedHandler;
                static /*0x18*/ System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> s_rentedSocketSentinel;
                static /*0x20*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;
                static /*0x28*/ System.Threading.Tasks.Task<int> s_zeroTask;
                static /*0x30*/ object s_InternalSyncObject;
                static /*0x38*/ bool s_SupportsIPv4;
                static /*0x39*/ bool s_SupportsIPv6;
                static /*0x3a*/ bool s_OSSupportsIPv6;
                static /*0x3b*/ bool s_Initialized;
                static /*0x3c*/ bool s_LoggingEnabled;
                static /*0x40*/ System.AsyncCallback AcceptAsyncCallback;
                static /*0x48*/ System.IOAsyncCallback BeginAcceptCallback;
                static /*0x50*/ System.IOAsyncCallback BeginAcceptReceiveCallback;
                static /*0x58*/ System.AsyncCallback ConnectAsyncCallback;
                static /*0x60*/ System.IOAsyncCallback BeginConnectCallback;
                static /*0x68*/ System.AsyncCallback DisconnectAsyncCallback;
                static /*0x70*/ System.IOAsyncCallback BeginDisconnectCallback;
                static /*0x78*/ System.AsyncCallback ReceiveAsyncCallback;
                static /*0x80*/ System.IOAsyncCallback BeginReceiveCallback;
                static /*0x88*/ System.IOAsyncCallback BeginReceiveGenericCallback;
                static /*0x90*/ System.AsyncCallback ReceiveFromAsyncCallback;
                static /*0x98*/ System.IOAsyncCallback BeginReceiveFromCallback;
                static /*0xa0*/ System.AsyncCallback SendAsyncCallback;
                static /*0xa8*/ System.IOAsyncCallback BeginSendGenericCallback;
                static /*0xb0*/ System.AsyncCallback SendToAsyncCallback;
                /*0x10*/ System.Net.Sockets.Socket.CachedEventArgs _cachedTaskEventArgs;
                /*0x18*/ bool is_closed;
                /*0x19*/ bool is_listening;
                /*0x1c*/ int linger_timeout;
                /*0x20*/ System.Net.Sockets.AddressFamily addressFamily;
                /*0x24*/ System.Net.Sockets.SocketType socketType;
                /*0x28*/ System.Net.Sockets.ProtocolType protocolType;
                /*0x30*/ System.Net.Sockets.SafeSocketHandle m_Handle;
                /*0x38*/ System.Net.EndPoint seed_endpoint;
                /*0x40*/ System.Threading.SemaphoreSlim ReadSem;
                /*0x48*/ System.Threading.SemaphoreSlim WriteSem;
                /*0x50*/ bool is_blocking;
                /*0x51*/ bool is_bound;
                /*0x52*/ bool is_connected;
                /*0x54*/ int m_IntCleanedUp;
                /*0x58*/ bool connect_in_progress;

                static /*0x77deb14*/ Socket();
                static /*0x77d71a8*/ void CompleteAccept(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                static /*0x77d7444*/ void CompleteSendReceive(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                static /*0x77d735c*/ System.Exception GetException(System.Net.Sockets.SocketError error, bool wrapExceptionsInIOExceptions);
                static /*0x77d7cd8*/ bool get_OSSupportsIPv4();
                static /*0x77d7d3c*/ bool get_OSSupportsIPv6();
                static /*0x77d9b9c*/ object get_InternalSyncObject();
                static /*0x77d789c*/ void InitializeSockets();
                static /*0x77d7afc*/ nint Socket_icall(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, ref int error);
                static /*0x77da300*/ System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x77da440*/ System.Net.SocketAddress LocalEndPoint_icall(nint socket, int family, ref int error);
                static /*0x77da50c*/ void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool block, ref int error);
                static /*0x77da630*/ void Blocking_icall(nint socket, bool block, ref int error);
                static /*0x77da77c*/ System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x77da8bc*/ System.Net.SocketAddress RemoteEndPoint_icall(nint socket, int family, ref int error);
                static /*0x77daa44*/ bool Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x77dab94*/ bool Poll_icall(nint socket, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x77dacd0*/ System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, ref int error, bool blocking);
                static /*0x77db468*/ nint Accept_icall(nint sock, ref int error, bool blocking);
                static /*0x77db6a8*/ void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error);
                static /*0x77db7cc*/ void Bind_icall(nint sock, System.Net.SocketAddress sa, ref int error);
                static /*0x77db8b4*/ void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int backlog, ref int error);
                static /*0x77db9d8*/ void Listen_icall(nint sock, int backlog, ref int error);
                static /*0x77dc618*/ bool BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x77dc1b4*/ bool BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x77dbdbc*/ void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x77dc8e8*/ void Connect_icall(nint sock, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x77dc9d8*/ void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool reuse, ref int error);
                static /*0x77dccd0*/ void Disconnect_icall(nint sock, bool reuse, ref int error);
                static /*0x77dd1b4*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77dd590*/ int Receive_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77dce50*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77dd598*/ int Receive_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77dd84c*/ int ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x77dda70*/ int ReceiveFrom_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x77ddfe0*/ void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, int sent_so_far);
                static /*0x77ddbb8*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77de398*/ int Send_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77dda78*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77de3a0*/ int Send_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77de460*/ void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x77de59c*/ void GetSocketOption_obj_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x77d9eec*/ void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x77de5a8*/ void SetSocketOption_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x77de5ac*/ int IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x77de704*/ int IOControl_icall(nint sock, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x77de710*/ void Close_icall(nint socket, ref int error);
                static /*0x77d9dc8*/ void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x77de814*/ void Shutdown_icall(nint socket, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x77dea88*/ void cancel_blocking_socket_operation(System.Threading.Thread thread);
                static /*0x77dea8c*/ int get_FamilyHint();
                static /*0x77deb10*/ bool IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                static /*0x77d9c68*/ bool IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                /*0x77d762c*/ Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x77da040*/ Socket(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle);
                /*0x77d56e4*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, bool fromNetworkStream, System.Threading.CancellationToken cancellationToken);
                /*0x77d68f4*/ System.Threading.Tasks.Task<int> ReceiveAsyncApm(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77d5fcc*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken);
                /*0x77d6d60*/ System.Threading.Tasks.Task<int> SendAsyncApm(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77d75c4*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                /*0x77d7300*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                /*0x77d7da0*/ nint get_Handle();
                /*0x77d7dbc*/ System.Net.Sockets.AddressFamily get_AddressFamily();
                /*0x77d7dc4*/ System.Net.Sockets.SocketType get_SocketType();
                /*0x77d7dcc*/ System.Net.Sockets.ProtocolType get_ProtocolType();
                /*0x77d7dd4*/ int get_ReceiveBufferSize();
                /*0x77d7e20*/ int get_SendBufferSize();
                /*0x77d7e6c*/ void set_DontFragment(bool value);
                /*0x77d8000*/ bool get_DualMode();
                /*0x77d80b8*/ void set_DualMode(bool value);
                /*0x77d8138*/ bool get_IsDualMode();
                /*0x77d8150*/ bool CanTryAddressFamily(System.Net.Sockets.AddressFamily family);
                /*0x77d8188*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77d4214*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77d3b14*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77d8a8c*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77d90c0*/ int IOControl(System.Net.Sockets.IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x77d7b20*/ void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level);
                /*0x77d923c*/ System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state);
                /*0x77d508c*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x77d5308*/ int EndSend(System.IAsyncResult asyncResult);
                /*0x77d4ab0*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x77d4d2c*/ int EndReceive(System.IAsyncResult asyncResult);
                /*0x77d94a8*/ bool get_CleanedUp();
                /*0x77d9cbc*/ void Dispose();
                /*0x77d9d28*/ void Finalize();
                /*0x77d4678*/ void InternalShutdown(System.Net.Sockets.SocketShutdown how);
                /*0x77d65f8*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue, bool silent);
                /*0x77d7c04*/ void SocketDefaults();
                /*0x77da194*/ System.Net.EndPoint get_LocalEndPoint();
                /*0x77da444*/ bool get_Blocking();
                /*0x77da44c*/ void set_Blocking(bool value);
                /*0x77da638*/ bool get_Connected();
                /*0x77da154*/ void set_NoDelay(bool value);
                /*0x77da68c*/ System.Net.EndPoint get_RemoteEndPoint();
                /*0x77da8c0*/ bool Poll(int microSeconds, System.Net.Sockets.SelectMode mode);
                /*0x77dab98*/ System.Net.Sockets.Socket Accept();
                /*0x77dae20*/ void Accept(System.Net.Sockets.Socket acceptSocket);
                /*0x77daf48*/ System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state);
                /*0x77db208*/ System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult);
                /*0x77db230*/ System.Net.Sockets.Socket EndAccept(ref byte[] buffer, ref int bytesTransferred, System.IAsyncResult asyncResult);
                /*0x77db470*/ void Bind(System.Net.EndPoint localEP);
                /*0x77db7d0*/ void Listen(int backlog);
                /*0x77db9dc*/ void Connect(System.Net.IPAddress address, int port);
                /*0x77dba50*/ void Connect(System.Net.EndPoint remoteEP);
                /*0x77dbedc*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback callback, object state);
                /*0x77d94b8*/ System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x77dc838*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x77dc8f0*/ void Disconnect(bool reuseSocket);
                /*0x77dcafc*/ System.IAsyncResult BeginDisconnect(bool reuseSocket, System.AsyncCallback callback, object state);
                /*0x77dcc20*/ void EndDisconnect(System.IAsyncResult asyncResult);
                /*0x77d8964*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77dcf90*/ int Receive(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77d8ae8*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77d3db8*/ int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77d44b8*/ int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77dd2f4*/ bool ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x77d990c*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x77d9aac*/ int EndReceive(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x77dd5a0*/ int ReceiveFrom(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.SocketError errorCode);
                /*0x77dd99c*/ int EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult sockares, System.Net.Sockets.SocketAsyncEventArgs ares);
                /*0x77d8820*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77d81e4*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77ddcf8*/ bool SendAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x77d95f4*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x77d981c*/ int EndSend(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x77de3a8*/ int EndSendTo(System.IAsyncResult asyncResult);
                /*0x77d3264*/ object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName);
                /*0x77de5a0*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, bool optionValue);
                /*0x77d7ee8*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue);
                /*0x77d90c4*/ int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x77de708*/ void Close();
                /*0x77d4700*/ void Close(int timeout);
                /*0x77de714*/ void Shutdown(System.Net.Sockets.SocketShutdown how);
                /*0x77de818*/ void Dispose(bool disposing);
                /*0x77de878*/ void Linger(nint handle);
                /*0x77da27c*/ void ThrowIfDisposedAndClosed();
                /*0x77dccd8*/ void ThrowIfBufferNull(byte[] buffer);
                /*0x77dcd2c*/ void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size);
                /*0x77da640*/ void ThrowIfUdp();
                /*0x77db330*/ System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, string methodName, string argName);
                /*0x77db0ac*/ void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, nint handle, System.IOSelectorJob job);
                /*0x77dd504*/ void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs e, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x77de9e4*/ System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation op);
                /*0x77db5e8*/ System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input);

                class CachedEventArgs
                {
                    /*0x10*/ System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> TaskAccept;
                    /*0x18*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskReceive;
                    /*0x20*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskSend;
                    /*0x28*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;
                    /*0x30*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;

                    /*0x77df2a0*/ CachedEventArgs();
                }

                class TaskSocketAsyncEventArgs<TResult> : System.Net.Sockets.SocketAsyncEventArgs
                {
                    /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder;
                    /*0x0*/ bool _accessed;

                    /*0x380cb08*/ TaskSocketAsyncEventArgs();
                    /*0x3907c14*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(ref bool responsibleForReturningToPool);
                }

                class Int32TaskSocketAsyncEventArgs : System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<int>
                {
                    /*0x99*/ bool _wrapExceptionsInIOExceptions;

                    /*0x77df258*/ Int32TaskSocketAsyncEventArgs();
                }

                class AwaitableSocketAsyncEventArgs : System.Net.Sockets.SocketAsyncEventArgs, System.Threading.Tasks.Sources.IValueTaskSource, System.Threading.Tasks.Sources.IValueTaskSource<int>
                {
                    static /*0x0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs Reserved;
                    static /*0x8*/ System.Action<object> s_completedSentinel;
                    static /*0x10*/ System.Action<object> s_availableSentinel;
                    /*0x80*/ System.Action<object> _continuation;
                    /*0x88*/ System.Threading.ExecutionContext _executionContext;
                    /*0x90*/ object _scheduler;
                    /*0x98*/ short _token;
                    /*0x9a*/ bool <WrapExceptionsInIOExceptions>k__BackingField;

                    static /*0x77dfdd4*/ AwaitableSocketAsyncEventArgs();
                    /*0x77df2a8*/ AwaitableSocketAsyncEventArgs();
                    /*0x77df31c*/ bool get_WrapExceptionsInIOExceptions();
                    /*0x77df324*/ void set_WrapExceptionsInIOExceptions(bool value);
                    /*0x77d67c8*/ bool Reserve();
                    /*0x77df330*/ void Release();
                    /*0x77df3ac*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _);
                    /*0x77d6844*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Net.Sockets.Socket socket);
                    /*0x77d6ce4*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket socket);
                    /*0x77df9b8*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
                    /*0x77dfa98*/ void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x77df5dc*/ void InvokeContinuation(System.Action<object> continuation, object state, bool forceAsync);
                    /*0x77dfd28*/ int GetResult(short token);
                    /*0x77dfd94*/ void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token);
                    /*0x77dfa4c*/ void ThrowIncorrectTokenException();
                    /*0x77dfcdc*/ void ThrowMultipleContinuationsException();
                    /*0x77dfd70*/ void ThrowException(System.Net.Sockets.SocketError error);
                    /*0x77df8cc*/ System.Exception CreateException(System.Net.Sockets.SocketError error);

                    class <>c
                    {
                        static /*0x0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs.<> <>9;
                        static /*0x8*/ System.Threading.ContextCallback <>9__14_0;
                        static /*0x10*/ System.Threading.SendOrPostCallback <>9__20_0;

                        static /*0x77dff38*/ <>c();
                        /*0x77dffa0*/ <>c();
                        /*0x77dffa8*/ void <OnCompleted>b__14_0(object runState);
                        /*0x77e0058*/ void <InvokeContinuation>b__20_0(object s);
                        /*0x77e0104*/ void <.cctor>b__27_0(object state);
                        /*0x77e0150*/ void <.cctor>b__27_1(object state);
                    }
                }

                struct WSABUF
                {
                    /*0x10*/ int len;
                    /*0x18*/ nint buf;
                }

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.Socket.<> <>9;
                    static /*0x8*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__14_0;
                    static /*0x10*/ System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__14_1;
                    static /*0x18*/ System.AsyncCallback <>9__15_0;
                    static /*0x20*/ System.AsyncCallback <>9__15_1;
                    static /*0x28*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__22_0;
                    static /*0x30*/ System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__22_1;
                    static /*0x38*/ System.AsyncCallback <>9__23_0;
                    static /*0x40*/ System.AsyncCallback <>9__23_1;
                    static /*0x48*/ System.IOAsyncCallback <>9__295_0;
                    static /*0x50*/ System.IOAsyncCallback <>9__297_0;

                    static /*0x77e019c*/ <>c();
                    /*0x77e0204*/ <>c();
                    /*0x77e020c*/ System.Net.Sockets.Socket.CachedEventArgs <ReceiveAsync>b__14_0();
                    /*0x77e0260*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1();
                    /*0x77e02b0*/ void <ReceiveAsyncApm>b__15_0(System.IAsyncResult iar);
                    /*0x77e04e4*/ void <ReceiveAsyncApm>b__15_1(System.IAsyncResult iar);
                    /*0x77e0924*/ System.Net.Sockets.Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0();
                    /*0x77e0978*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1();
                    /*0x77e09c8*/ void <SendAsyncApm>b__23_0(System.IAsyncResult iar);
                    /*0x77e0bfc*/ void <SendAsyncApm>b__23_1(System.IAsyncResult iar);
                    /*0x77e0efc*/ void <SendAsync>b__295_0(System.IOAsyncResult s);
                    /*0x77e0f8c*/ void <BeginSend>b__297_0(System.IOAsyncResult s);
                    /*0x77e101c*/ void <.cctor>b__367_0(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x77e1110*/ void <.cctor>b__367_1(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x77e11ec*/ void <.cctor>b__367_2(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x77e12c8*/ void <.cctor>b__367_3(System.IAsyncResult ares);
                    /*0x77e1568*/ void <.cctor>b__367_4(System.IOAsyncResult ares);
                    /*0x77e16a0*/ void <.cctor>b__367_5(System.IOAsyncResult ares);
                    /*0x77e18dc*/ void <.cctor>b__367_6(System.IAsyncResult ares);
                    /*0x77e1b38*/ void <.cctor>b__367_7(System.IOAsyncResult ares);
                    /*0x77e1dd8*/ void <.cctor>b__367_8(System.IAsyncResult ares);
                    /*0x77e2034*/ void <.cctor>b__367_9(System.IOAsyncResult ares);
                    /*0x77e2144*/ void <.cctor>b__367_10(System.IAsyncResult ares);
                    /*0x77e23b8*/ void <.cctor>b__367_11(System.IOAsyncResult ares);
                    /*0x77e2680*/ void <.cctor>b__367_12(System.IOAsyncResult ares);
                    /*0x77e279c*/ void <.cctor>b__367_13(System.IAsyncResult ares);
                    /*0x77e2a38*/ void <.cctor>b__367_14(System.IOAsyncResult ares);
                    /*0x77e2bb8*/ void <.cctor>b__367_15(System.IAsyncResult ares);
                    /*0x77e2e2c*/ void <.cctor>b__367_16(System.IOAsyncResult ares);
                    /*0x77e2f48*/ void <.cctor>b__367_17(System.IAsyncResult ares);
                }

                class <>c__DisplayClass240_0
                {
                    /*0x10*/ System.Net.Sockets.SocketAsyncResult sockares;

                    /*0x77dc1ac*/ <>c__DisplayClass240_0();
                    /*0x77e31bc*/ void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t);
                }

                class <>c__DisplayClass298_0
                {
                    /*0x10*/ int sent_so_far;

                    /*0x77de390*/ <>c__DisplayClass298_0();
                    /*0x77e32e0*/ void <BeginSendCallback>b__0(System.IOAsyncResult s);
                }

                class <>c__DisplayClass355_0
                {
                    /*0x10*/ System.Net.Sockets.Socket <>4__this;
                    /*0x18*/ System.IOSelectorJob job;
                    /*0x20*/ nint handle;

                    /*0x77de9dc*/ <>c__DisplayClass355_0();
                    /*0x77e3380*/ void <QueueIOSelectorJob>b__0(System.Threading.Tasks.Task t);
                }
            }

            class SocketException : System.ComponentModel.Win32Exception
            {
                /*0x90*/ System.Net.EndPoint m_EndPoint;

                static /*0x77e33c4*/ int WSAGetLastError_icall();
                /*0x77d7b00*/ SocketException();
                /*0x77e33c8*/ SocketException(int error, string message);
                /*0x77d3ebc*/ SocketException(int errorCode);
                /*0x77d8818*/ SocketException(System.Net.Sockets.SocketError socketError);
                /*0x77e33d0*/ SocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x77e33d8*/ string get_Message();
                /*0x77e1560*/ System.Net.Sockets.SocketError get_SocketErrorCode();
            }

            enum AddressFamily
            {
                Unknown = -1,
                Unspecified = 0,
                Unix = 1,
                InterNetwork = 2,
                ImpLink = 3,
                Pup = 4,
                Chaos = 5,
                NS = 6,
                Ipx = 6,
                Iso = 7,
                Osi = 7,
                Ecma = 8,
                DataKit = 9,
                Ccitt = 10,
                Sna = 11,
                DecNet = 12,
                DataLink = 13,
                Lat = 14,
                HyperChannel = 15,
                AppleTalk = 16,
                NetBios = 17,
                VoiceView = 18,
                FireFox = 19,
                Banyan = 21,
                Atm = 22,
                InterNetworkV6 = 23,
                Cluster = 24,
                Ieee12844 = 25,
                Irda = 26,
                NetworkDesigners = 28,
                Max = 29,
            }

            enum IOControlCode
            {
                AsyncIO = 2147772029,
                NonBlockingIO = 2147772030,
                DataToRead = 1074030207,
                OobDataRead = 1074033415,
                AssociateHandle = 2281701377,
                EnableCircularQueuing = 671088642,
                Flush = 671088644,
                GetBroadcastAddress = 1207959557,
                GetExtensionFunctionPointer = 3355443206,
                GetQos = 3355443207,
                GetGroupQos = 3355443208,
                MultipointLoopback = 2281701385,
                MulticastScope = 2281701386,
                SetQos = 2281701387,
                SetGroupQos = 2281701388,
                TranslateHandle = 3355443213,
                RoutingInterfaceQuery = 3355443220,
                RoutingInterfaceChange = 2281701397,
                AddressListQuery = 1207959574,
                AddressListChange = 671088663,
                QueryTargetPnpHandle = 1207959576,
                NamespaceChange = 2281701401,
                AddressListSort = 3355443225,
                ReceiveAll = 2550136833,
                ReceiveAllMulticast = 2550136834,
                ReceiveAllIgmpMulticast = 2550136835,
                KeepAliveValues = 2550136836,
                AbsorbRouterAlert = 2550136837,
                UnicastInterface = 2550136838,
                LimitBroadcasts = 2550136839,
                BindToInterface = 2550136840,
                MulticastInterface = 2550136841,
                AddMulticastGroupOnInterface = 2550136842,
                DeleteMulticastGroupFromInterface = 2550136843,
            }

            enum IPProtectionLevel
            {
                Unspecified = -1,
                Unrestricted = 10,
                EdgeRestricted = 20,
                Restricted = 30,
            }

            class LingerOption
            {
                /*0x10*/ bool enabled;
                /*0x14*/ int lingerTime;

                /*0x77e3468*/ LingerOption(bool enable, int seconds);
                /*0x77e349c*/ void set_Enabled(bool value);
                /*0x77e34a8*/ void set_LingerTime(int value);
            }

            class MulticastOption
            {
            }

            enum ProtocolType
            {
                IP = 0,
                IPv6HopByHopOptions = 0,
                Icmp = 1,
                Igmp = 2,
                Ggp = 3,
                IPv4 = 4,
                Tcp = 6,
                Pup = 12,
                Udp = 17,
                Idp = 22,
                IPv6 = 41,
                IPv6RoutingHeader = 43,
                IPv6FragmentHeader = 44,
                IPSecEncapsulatingSecurityPayload = 50,
                IPSecAuthenticationHeader = 51,
                IcmpV6 = 58,
                IPv6NoNextHeader = 59,
                IPv6DestinationOptions = 60,
                ND = 77,
                Raw = 255,
                Unspecified = 0,
                Ipx = 1000,
                Spx = 1256,
                SpxII = 1257,
                Unknown = -1,
            }

            enum SelectMode
            {
                SelectRead = 0,
                SelectWrite = 1,
                SelectError = 2,
            }

            enum SocketAsyncOperation
            {
                None = 0,
                Accept = 1,
                Connect = 2,
                Disconnect = 3,
                Receive = 4,
                ReceiveFrom = 5,
                ReceiveMessageFrom = 6,
                Send = 7,
                SendPackets = 8,
                SendTo = 9,
            }

            enum SocketError
            {
                Success = 0,
                SocketError = -1,
                Interrupted = 10004,
                AccessDenied = 10013,
                Fault = 10014,
                InvalidArgument = 10022,
                TooManyOpenSockets = 10024,
                WouldBlock = 10035,
                InProgress = 10036,
                AlreadyInProgress = 10037,
                NotSocket = 10038,
                DestinationAddressRequired = 10039,
                MessageSize = 10040,
                ProtocolType = 10041,
                ProtocolOption = 10042,
                ProtocolNotSupported = 10043,
                SocketNotSupported = 10044,
                OperationNotSupported = 10045,
                ProtocolFamilyNotSupported = 10046,
                AddressFamilyNotSupported = 10047,
                AddressAlreadyInUse = 10048,
                AddressNotAvailable = 10049,
                NetworkDown = 10050,
                NetworkUnreachable = 10051,
                NetworkReset = 10052,
                ConnectionAborted = 10053,
                ConnectionReset = 10054,
                NoBufferSpaceAvailable = 10055,
                IsConnected = 10056,
                NotConnected = 10057,
                Shutdown = 10058,
                TimedOut = 10060,
                ConnectionRefused = 10061,
                HostDown = 10064,
                HostUnreachable = 10065,
                ProcessLimit = 10067,
                SystemNotReady = 10091,
                VersionNotSupported = 10092,
                NotInitialized = 10093,
                Disconnecting = 10101,
                TypeNotFound = 10109,
                HostNotFound = 11001,
                TryAgain = 11002,
                NoRecovery = 11003,
                NoData = 11004,
                IOPending = 997,
                OperationAborted = 995,
            }

            enum SocketFlags
            {
                None = 0,
                OutOfBand = 1,
                Peek = 2,
                DontRoute = 4,
                MaxIOVectorLength = 16,
                Truncated = 256,
                ControlDataTruncated = 512,
                Broadcast = 1024,
                Multicast = 2048,
                Partial = 32768,
            }

            enum SocketOptionLevel
            {
                Socket = 65535,
                IP = 0,
                IPv6 = 41,
                Tcp = 6,
                Udp = 17,
            }

            enum SocketOptionName
            {
                Debug = 1,
                AcceptConnection = 2,
                ReuseAddress = 4,
                KeepAlive = 8,
                DontRoute = 16,
                Broadcast = 32,
                UseLoopback = 64,
                Linger = 128,
                OutOfBandInline = 256,
                DontLinger = -129,
                ExclusiveAddressUse = -5,
                SendBuffer = 4097,
                ReceiveBuffer = 4098,
                SendLowWater = 4099,
                ReceiveLowWater = 4100,
                SendTimeout = 4101,
                ReceiveTimeout = 4102,
                Error = 4103,
                Type = 4104,
                ReuseUnicastPort = 12295,
                MaxConnections = 2147483647,
                IPOptions = 1,
                HeaderIncluded = 2,
                TypeOfService = 3,
                IpTimeToLive = 4,
                MulticastInterface = 9,
                MulticastTimeToLive = 10,
                MulticastLoopback = 11,
                AddMembership = 12,
                DropMembership = 13,
                DontFragment = 14,
                AddSourceMembership = 15,
                DropSourceMembership = 16,
                BlockSource = 17,
                UnblockSource = 18,
                PacketInformation = 19,
                HopLimit = 21,
                IPProtectionLevel = 23,
                IPv6Only = 27,
                NoDelay = 1,
                BsdUrgent = 2,
                Expedited = 2,
                NoChecksum = 1,
                ChecksumCoverage = 20,
                UpdateAcceptContext = 28683,
                UpdateConnectContext = 28688,
            }

            enum SocketShutdown
            {
                Receive = 0,
                Send = 1,
                Both = 2,
            }

            enum SocketType
            {
                Stream = 1,
                Dgram = 2,
                Raw = 3,
                Rdm = 4,
                Seqpacket = 5,
                Unknown = -1,
            }

            class TcpClient : System.IDisposable
            {
                /*0x10*/ System.Net.Sockets.Socket m_ClientSocket;
                /*0x18*/ bool m_Active;
                /*0x20*/ System.Net.Sockets.NetworkStream m_DataStream;
                /*0x28*/ System.Net.Sockets.AddressFamily m_Family;
                /*0x2c*/ bool m_CleanedUp;

                /*0x77e34b0*/ TcpClient();
                /*0x77e34d0*/ TcpClient(System.Net.Sockets.AddressFamily family);
                /*0x77e3654*/ System.Net.Sockets.Socket get_Client();
                /*0x77e365c*/ void set_Client(System.Net.Sockets.Socket value);
                /*0x77e3664*/ void Connect(string hostname, int port);
                /*0x77e3d10*/ void Connect(System.Net.IPEndPoint remoteEP);
                /*0x77e3e10*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state);
                /*0x77e3e7c*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x77e3ec4*/ System.Threading.Tasks.Task ConnectAsync(string host, int port);
                /*0x77e4030*/ System.Net.Sockets.NetworkStream GetStream();
                /*0x77e4174*/ void Dispose(bool disposing);
                /*0x77e433c*/ void Dispose();
                /*0x77e434c*/ void Finalize();
                /*0x77e35dc*/ void initialize();
            }

            class SafeSocketHandle : Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid
            {
                static /*0x0*/ bool THROW_ON_ABORT_RETRIES;
                /*0x20*/ System.Collections.Generic.List<System.Threading.Thread> blocking_threads;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> threads_stacktraces;
                /*0x30*/ bool in_cleanup;

                static /*0x77e4db0*/ SafeSocketHandle();
                /*0x77e43ec*/ SafeSocketHandle(nint preexistingHandle, bool ownsHandle);
                /*0x77e44c8*/ bool ReleaseHandle();
                /*0x77e4a7c*/ void RegisterForBlockingSyscall();
                /*0x77e4bbc*/ void UnRegisterForBlockingSyscall();
            }

            class SocketAsyncEventArgs : System.EventArgs, System.IDisposable
            {
                /*0x10*/ bool disposed;
                /*0x14*/ int in_progress;
                /*0x18*/ System.Net.EndPoint remote_ep;
                /*0x20*/ System.Net.Sockets.Socket current_socket;
                /*0x28*/ System.Net.Sockets.SocketAsyncResult socket_async_result;
                /*0x30*/ System.Net.Sockets.Socket <AcceptSocket>k__BackingField;
                /*0x38*/ int <BytesTransferred>k__BackingField;
                /*0x3c*/ System.Net.Sockets.SocketAsyncOperation <LastOperation>k__BackingField;
                /*0x40*/ System.Net.Sockets.SocketError <SocketError>k__BackingField;
                /*0x44*/ System.Net.Sockets.SocketFlags <SocketFlags>k__BackingField;
                /*0x48*/ object <UserToken>k__BackingField;
                /*0x50*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> Completed;
                /*0x58*/ System.Memory<byte> _buffer;
                /*0x68*/ int _offset;
                /*0x6c*/ int _count;
                /*0x70*/ bool _bufferIsExplicitArray;
                /*0x78*/ System.Collections.Generic.IList<System.ArraySegment<byte>> _bufferList;

                /*0x77e4e9c*/ SocketAsyncEventArgs(bool flowExecutionContext);
                /*0x77e4e44*/ System.Net.Sockets.Socket get_AcceptSocket();
                /*0x77e4e4c*/ void set_AcceptSocket(System.Net.Sockets.Socket value);
                /*0x77e4e54*/ int get_BytesTransferred();
                /*0x77e4e5c*/ void set_BytesTransferred(int value);
                /*0x77e4e64*/ void set_LastOperation(System.Net.Sockets.SocketAsyncOperation value);
                /*0x77e4e6c*/ void set_RemoteEndPoint(System.Net.EndPoint value);
                /*0x77e4e74*/ System.Net.Sockets.SocketError get_SocketError();
                /*0x77e4e7c*/ void set_SocketError(System.Net.Sockets.SocketError value);
                /*0x77e4e84*/ void set_SocketFlags(System.Net.Sockets.SocketFlags value);
                /*0x77e4e8c*/ object get_UserToken();
                /*0x77e4e94*/ void set_UserToken(object value);
                /*0x77e4f3c*/ void Finalize();
                /*0x77e4f4c*/ void Dispose(bool disposing);
                /*0x77e4f60*/ void Dispose();
                /*0x77e4fc4*/ void SetBytesTransferred(int value);
                /*0x77e4fcc*/ System.Net.Sockets.Socket get_CurrentSocket();
                /*0x77e4fd4*/ void SetCurrentSocket(System.Net.Sockets.Socket socket);
                /*0x77e4fdc*/ void SetLastOperation(System.Net.Sockets.SocketAsyncOperation op);
                /*0x77e509c*/ void Complete_internal();
                /*0x77e50c4*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x77e50ec*/ System.Memory<byte> get_MemoryBuffer();
                /*0x77e50f8*/ int get_Offset();
                /*0x77e5100*/ int get_Count();
                /*0x77e5108*/ System.Collections.Generic.IList<System.ArraySegment<byte>> get_BufferList();
                /*0x77e5110*/ void SetBuffer(System.Memory<byte> buffer);
            }

            class SocketAsyncResult : System.IOAsyncResult
            {
                /*0x30*/ System.Net.Sockets.Socket socket;
                /*0x38*/ System.Net.Sockets.SocketOperation operation;
                /*0x40*/ System.Exception DelayedException;
                /*0x48*/ System.Net.EndPoint EndPoint;
                /*0x50*/ System.Memory<byte> Buffer;
                /*0x60*/ int Offset;
                /*0x64*/ int Size;
                /*0x68*/ System.Net.Sockets.SocketFlags SockFlags;
                /*0x70*/ System.Net.Sockets.Socket AcceptSocket;
                /*0x78*/ System.Net.IPAddress[] Addresses;
                /*0x80*/ int Port;
                /*0x88*/ System.Collections.Generic.IList<System.ArraySegment<byte>> Buffers;
                /*0x90*/ bool ReuseSocket;
                /*0x94*/ int CurrentAddress;
                /*0x98*/ System.Net.Sockets.Socket AcceptedSocket;
                /*0xa0*/ int Total;
                /*0xa4*/ int error;
                /*0xa8*/ int EndCalled;

                /*0x77e4f34*/ SocketAsyncResult();
                /*0x77e534c*/ SocketAsyncResult(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x77e5208*/ nint get_Handle();
                /*0x77e521c*/ void Init(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x77e5390*/ System.Net.Sockets.SocketError get_ErrorCode();
                /*0x77e5418*/ void CheckIfThrowDelayedException();
                /*0x77e54bc*/ void CompleteDisposed();
                /*0x77e54c0*/ void Complete();
                /*0x77e56bc*/ void Complete(bool synch);
                /*0x77e56c8*/ void Complete(int total);
                /*0x77e56d0*/ void Complete(System.Exception e, bool synch);
                /*0x77e5700*/ void Complete(System.Exception e);
                /*0x77e571c*/ void Complete(System.Net.Sockets.Socket s);
                /*0x77e5738*/ void Complete(System.Net.Sockets.Socket s, int total);

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.SocketAsyncResult.<> <>9;
                    static /*0x8*/ System.Threading.WaitCallback <>9__27_0;

                    static /*0x77e5764*/ <>c();
                    /*0x77e57cc*/ <>c();
                    /*0x77e57d4*/ void <Complete>b__27_0(object state);
                }
            }

            enum SocketOperation
            {
                Accept = 0,
                Connect = 1,
                Receive = 2,
                ReceiveFrom = 3,
                Send = 4,
                SendTo = 5,
                RecvJustCallback = 6,
                SendJustCallback = 7,
                Disconnect = 8,
                AcceptReceive = 9,
                ReceiveGeneric = 10,
                SendGeneric = 11,
            }
        }

        namespace Security
        {
            struct SslApplicationProtocol : System.IEquatable<System.Net.Security.SslApplicationProtocol>
            {
                static /*0x0*/ System.Text.Encoding s_utf8;
                static /*0x8*/ System.Net.Security.SslApplicationProtocol Http2;
                static /*0x18*/ System.Net.Security.SslApplicationProtocol Http11;
                /*0x10*/ System.ReadOnlyMemory<byte> _readOnlyProtocol;

                static /*0x77e5f94*/ SslApplicationProtocol();
                static /*0x77e5f7c*/ char GetHexValue(int i);
                /*0x77e584c*/ SslApplicationProtocol(byte[] protocol, bool copy);
                /*0x77e59dc*/ bool Equals(System.Net.Security.SslApplicationProtocol other);
                /*0x77e5af8*/ bool Equals(object obj);
                /*0x77e5b8c*/ int GetHashCode();
                /*0x77e5c74*/ string ToString();
            }

            class SslClientAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.EncryptionPolicy _encryptionPolicy;
                /*0x14*/ System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;
                /*0x18*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
                /*0x1c*/ bool _allowRenegotiation;
                /*0x20*/ string <TargetHost>k__BackingField;
                /*0x28*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;

                /*0x77e6290*/ SslClientAuthenticationOptions();
                /*0x77e6128*/ string get_TargetHost();
                /*0x77e6130*/ void set_TargetHost(string value);
                /*0x77e6138*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x77e6140*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x77e6148*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x77e61e4*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x77e6280*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x77e6288*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
            }

            class AuthenticatedStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _InnerStream;
                /*0x30*/ bool _LeaveStreamOpen;

                /*0x77e62a0*/ AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen);
                /*0x77e643c*/ System.IO.Stream get_InnerStream();
                /*0x77e6444*/ void Dispose(bool disposing);
                /*0x380b128*/ bool get_IsAuthenticated();
            }

            enum AuthenticationLevel
            {
                None = 0,
                MutualAuthRequested = 1,
                MutualAuthRequired = 2,
            }

            enum EncryptionPolicy
            {
                RequireEncryption = 0,
                AllowNoEncryption = 1,
                NoEncryption = 2,
            }

            class LocalCertificateSelectionCallback : System.MulticastDelegate
            {
                /*0x77e652c*/ LocalCertificateSelectionCallback(object object, nint method);
                /*0x77e6638*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class RemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x77e664c*/ RemoteCertificateValidationCallback(object object, nint method);
                /*0x77e6758*/ bool Invoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            }

            enum SslPolicyErrors
            {
                None = 0,
                RemoteCertificateNotAvailable = 1,
                RemoteCertificateNameMismatch = 2,
                RemoteCertificateChainErrors = 4,
            }

            class LocalCertSelectionCallback : System.MulticastDelegate
            {
                /*0x77e676c*/ LocalCertSelectionCallback(object object, nint method);
                /*0x77e6820*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class ServerCertSelectionCallback : System.MulticastDelegate
            {
                /*0x77e6834*/ ServerCertSelectionCallback(object object, nint method);
                /*0x77e68e4*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string hostName);
            }

            class SslStream : System.Net.Security.AuthenticatedStream
            {
                /*0x38*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x40*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x48*/ System.Net.Security.RemoteCertificateValidationCallback validationCallback;
                /*0x50*/ System.Net.Security.LocalCertificateSelectionCallback selectionCallback;
                /*0x58*/ Mono.Net.Security.MobileAuthenticatedStream impl;
                /*0x60*/ bool explicitSettings;

                static /*0x77e6990*/ Mono.Net.Security.MobileTlsProvider GetProvider();
                /*0x77e6a00*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback);
                /*0x77e6a0c*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback);
                /*0x77e6d88*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback, System.Net.Security.EncryptionPolicy encryptionPolicy);
                /*0x77e6d90*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                /*0x77e68f8*/ Mono.Net.Security.MobileAuthenticatedStream get_Impl();
                /*0x77e696c*/ string get_InternalTargetHost();
                /*0x77e6ac8*/ void SetAndVerifyValidationCallback(System.Net.Security.RemoteCertificateValidationCallback callback);
                /*0x77e6bcc*/ void SetAndVerifySelectionCallback(System.Net.Security.LocalCertificateSelectionCallback callback);
                /*0x77e6ed8*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x77e6f2c*/ System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState);
                /*0x77e6fa0*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
                /*0x77e6fac*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x77e7000*/ bool get_IsAuthenticated();
                /*0x77e702c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x77e7050*/ System.Net.Security.SslApplicationProtocol get_NegotiatedApplicationProtocol();
                /*0x77e709c*/ bool get_CanSeek();
                /*0x77e70a4*/ bool get_CanRead();
                /*0x77e70bc*/ bool get_CanTimeout();
                /*0x77e70dc*/ bool get_CanWrite();
                /*0x77e70f4*/ int get_ReadTimeout();
                /*0x77e7120*/ void set_ReadTimeout(int value);
                /*0x77e715c*/ int get_WriteTimeout();
                /*0x77e7188*/ void set_WriteTimeout(int value);
                /*0x77e71c4*/ long get_Length();
                /*0x77e71ec*/ long get_Position();
                /*0x77e7218*/ void set_Position(long value);
                /*0x77e7270*/ void SetLength(long value);
                /*0x77e72ac*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x77e7304*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x77e7328*/ void Flush();
                /*0x77e6910*/ void CheckDisposed();
                /*0x77e734c*/ void Dispose(bool disposing);
                /*0x77e7408*/ int Read(byte[] buffer, int offset, int count);
                /*0x77e745c*/ void Write(byte[] buffer, int offset, int count);
                /*0x77e74b0*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x77e750c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x77e7568*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x77e75d4*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x77e761c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x77e7688*/ void EndWrite(System.IAsyncResult asyncResult);

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ System.Net.Security.LocalCertificateSelectionCallback callback;
                    /*0x18*/ System.Net.Security.SslStream <>4__this;

                    /*0x77e6ed0*/ <>c__DisplayClass21_0();
                    /*0x77e7694*/ System.Security.Cryptography.X509Certificates.X509Certificate <SetAndVerifySelectionCallback>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A;
    static /*0x100*/ <PrivateImplementationDetails> 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5;
    static /*0x120*/ <PrivateImplementationDetails> 063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374;
    static /*0x140*/ long 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B;
    static /*0x148*/ <PrivateImplementationDetails> 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811;
    static /*0x151*/ <PrivateImplementationDetails> 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;
    static /*0x178*/ long 34B06173CE6C3C7CBDB99C416ECB98BD8F75845A7E23ED4B039EC239EB5559AA;
    static /*0x180*/ long 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C;
    static /*0x188*/ <PrivateImplementationDetails> 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF;
    static /*0x198*/ long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885;
    static /*0x1a0*/ <PrivateImplementationDetails> 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3;
    static /*0x220*/ <PrivateImplementationDetails> 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8;
    static /*0x24c*/ <PrivateImplementationDetails> 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A;
    static /*0x252*/ <PrivateImplementationDetails> B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C;
    static /*0x2d8*/ long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859;
    static /*0x2e0*/ <PrivateImplementationDetails> DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5;
    static /*0x2ee*/ <PrivateImplementationDetails> E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A;

    static /*0x77e76cc*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=9
    {
    }

    struct __StaticArrayInitTypeSize=10
    {
    }

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=14
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=44
    {
    }

    struct __StaticArrayInitTypeSize=128
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }
}

namespace System
{
    namespace Configuration
    {
        interface IConfigurationSectionHandler
        {
        }
    }

    namespace Net
    {
        namespace Configuration
        {
            class BypassElement : System.Configuration.ConfigurationElement
            {
            }

            class BypassElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x77e7748*/ BypassElementCollection();
            }

            class ConnectionManagementElement : System.Configuration.ConfigurationElement
            {
            }

            class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x77e7780*/ ConnectionManagementElementCollection();
            }

            class ConnectionManagementSection : System.Configuration.ConfigurationSection
            {
                /*0x77e77b8*/ ConnectionManagementSection();
                /*0x77e77f0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class DefaultProxySection : System.Configuration.ConfigurationSection
            {
                /*0x77e7828*/ DefaultProxySection();
                /*0x77e7860*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
                /*0x77e7898*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            }

            class ProxyElement : System.Configuration.ConfigurationElement
            {
                /*0x77e78d0*/ ProxyElement();
                /*0x77e7908*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class HttpWebRequestElement : System.Configuration.ConfigurationElement
            {
                /*0x77e7940*/ HttpWebRequestElement();
                /*0x77e7978*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class Ipv6Element : System.Configuration.ConfigurationElement
            {
                /*0x77e79b0*/ Ipv6Element();
                /*0x77e79e8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
            {
                /*0x77e7a20*/ NetSectionGroup();
            }

            class SettingsSection : System.Configuration.ConfigurationSection
            {
                /*0x77e7a58*/ SettingsSection();
                /*0x77e7a90*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class PerformanceCountersElement : System.Configuration.ConfigurationElement
            {
                /*0x77e7ac8*/ PerformanceCountersElement();
                /*0x77e7b00*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class ServicePointManagerElement : System.Configuration.ConfigurationElement
            {
                /*0x77e7b38*/ ServicePointManagerElement();
                /*0x77e7b70*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class SocketElement : System.Configuration.ConfigurationElement
            {
                /*0x77e7ba8*/ SocketElement();
                /*0x77e7be0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebProxyScriptElement : System.Configuration.ConfigurationElement
            {
                /*0x77e7c18*/ WebProxyScriptElement();
                /*0x77e7c50*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModulesSection : System.Configuration.ConfigurationSection
            {
                /*0x77e7c88*/ WebRequestModulesSection();
                /*0x77e7cc0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x77e7cf8*/ WebRequestModuleElementCollection();
            }

            class WebRequestModuleElement : System.Configuration.ConfigurationElement
            {
            }
        }
    }

    namespace Diagnostics
    {
        class DiagnosticsConfigurationHandler : System.Configuration.IConfigurationSectionHandler
        {
            /*0x77e7d30*/ DiagnosticsConfigurationHandler();
            /*0x77e7d68*/ object Create(object parent, object configContext, System.Xml.XmlNode section);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x77e7da0*/ void ThrowNotSupportedException();
    }
}
