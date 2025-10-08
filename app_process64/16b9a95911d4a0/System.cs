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

        static /*0x36d1f3c*/ SystemCertificateProvider();
        static /*0x36d189c*/ Mono.X509PalImpl GetX509Pal();
        static /*0x36d1944*/ void EnsureInitialized();
        /*0x36d1f34*/ SystemCertificateProvider();
        /*0x36d1a9c*/ Mono.X509PalImpl get_X509Pal();
        /*0x36d1af8*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, Mono.CertificateImportFlags importFlags);
        /*0x36d1d14*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x36d1d18*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x36d1e1c*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
        /*0x36d1e20*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
    }

    class SystemDependencyProvider : Mono.ISystemDependencyProvider
    {
        static /*0x0*/ Mono.SystemDependencyProvider instance;
        static /*0x8*/ object syncRoot;
        /*0x10*/ Mono.SystemCertificateProvider <CertificateProvider>k__BackingField;

        static /*0x36d2228*/ SystemDependencyProvider();
        static /*0x36d1fb0*/ Mono.SystemDependencyProvider get_Instance();
        static /*0x36d200c*/ void Initialize();
        /*0x36d2160*/ SystemDependencyProvider();
        /*0x36d2204*/ Mono.ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider();
        /*0x36d220c*/ Mono.SystemCertificateProvider get_CertificateProvider();
        /*0x36d2214*/ Mono.X509PalImpl get_X509Pal();
    }

    class X509Pal
    {
        static /*0x36d229c*/ Mono.X509PalImpl get_Instance();
    }

    class X509PalImplMono : Mono.X509PalImpl
    {
        /*0x36d18ec*/ X509PalImplMono();
        /*0x36d22fc*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        /*0x36d2300*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x36d2304*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
    }

    class X509PalImpl
    {
        static /*0x0*/ byte[] signedData;

        static /*0x36d2958*/ X509PalImpl();
        static /*0x36d2314*/ byte[] PEM(string type, byte[] data);
        static /*0x36d2448*/ byte[] ConvertData(byte[] data);
        /*0x36d230c*/ X509PalImpl();
        /*0x1f302cc*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x1f302cc*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
        /*0x36d1b64*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data);
        /*0x36d1da8*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x36d2554*/ bool get_SupportsLegacyBasicConstraintsExtension();
        /*0x36d255c*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
    }

    namespace Util
    {
        class MonoPInvokeCallbackAttribute : System.Attribute
        {
            /*0x36d29f8*/ MonoPInvokeCallbackAttribute(System.Type t);
        }
    }

    namespace Unity
    {
        class CertHelper
        {
            static /*0x36d2a00*/ void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x36d2ba0*/ void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class Debug
        {
            static /*0x36d2e10*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, string context, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x36d2ea8*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, string context, Mono.Security.Interface.AlertDescription defaultAlert);
        }

        class UnityTls
        {
            static /*0x0*/ Mono.Unity.UnityTls.unitytls_interface_struct marshalledInterface;

            static /*0x36d2fcc*/ nint GetUnityTlsInterface();
            static /*0x36d2fd0*/ bool get_IsSupported();
            static /*0x36d2d48*/ Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface();

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
                /*0x36d2fe8*/ unitytls_x509verify_callback(object object, nint method);
                /*0x36d309c*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
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
                /*0x36d30b0*/ unitytls_tlsctx_write_callback(object object, nint method);
                /*0x36d3164*/ nint Invoke(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_read_callback : System.MulticastDelegate
            {
                /*0x36d3178*/ unitytls_tlsctx_read_callback(object object, nint method);
                /*0x36d322c*/ nint Invoke(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_trace_callback : System.MulticastDelegate
            {
                /*0x36d3240*/ unitytls_tlsctx_trace_callback(object object, nint method);
                /*0x36d32f4*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen);
            }

            class unitytls_tlsctx_certificate_callback : System.MulticastDelegate
            {
                /*0x36d3308*/ unitytls_tlsctx_certificate_callback(object object, nint method);
                /*0x36d33bc*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_x509verify_callback : System.MulticastDelegate
            {
                /*0x36d33dc*/ unitytls_tlsctx_x509verify_callback(object object, nint method);
                /*0x36d3490*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
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

                /*0x36d34a4*/ unitytls_interface_struct();

                class unitytls_errorstate_create_t : System.MulticastDelegate
                {
                    /*0x36d34ac*/ unitytls_errorstate_create_t(object object, nint method);
                    /*0x36d3548*/ Mono.Unity.UnityTls.unitytls_errorstate Invoke();
                }

                class unitytls_errorstate_raise_error_t : System.MulticastDelegate
                {
                    /*0x36d355c*/ unitytls_errorstate_raise_error_t(object object, nint method);
                    /*0x36d3610*/ void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode);
                }

                class unitytls_key_get_ref_t : System.MulticastDelegate
                {
                    /*0x36d3624*/ unitytls_key_get_ref_t(object object, nint method);
                    /*0x36d36d8*/ Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_der_t : System.MulticastDelegate
                {
                    /*0x36d36ec*/ unitytls_key_parse_der_t(object object, nint method);
                    /*0x36d37a0*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_pem_t : System.MulticastDelegate
                {
                    /*0x36d37b4*/ unitytls_key_parse_pem_t(object object, nint method);
                    /*0x36d3868*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_free_t : System.MulticastDelegate
                {
                    /*0x36d387c*/ unitytls_key_free_t(object object, nint method);
                    /*0x36d392c*/ void Invoke(Mono.Unity.UnityTls.unitytls_key* key);
                }

                class unitytls_x509_export_der_t : System.MulticastDelegate
                {
                    /*0x36d3940*/ unitytls_x509_export_der_t(object object, nint method);
                    /*0x36d39e0*/ nint Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_ref_t : System.MulticastDelegate
                {
                    /*0x36d39f4*/ unitytls_x509list_get_ref_t(object object, nint method);
                    /*0x36d3aa8*/ Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_x509_t : System.MulticastDelegate
                {
                    /*0x36d3abc*/ unitytls_x509list_get_x509_t(object object, nint method);
                    /*0x36d3b5c*/ Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, nint index, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_create_t : System.MulticastDelegate
                {
                    /*0x36d3b70*/ unitytls_x509list_create_t(object object, nint method);
                    /*0x36d3c20*/ Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_t : System.MulticastDelegate
                {
                    /*0x36d3c34*/ unitytls_x509list_append_t(object object, nint method);
                    /*0x36d3ce8*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_der_t : System.MulticastDelegate
                {
                    /*0x36d3cfc*/ unitytls_x509list_append_der_t(object object, nint method);
                    /*0x36d3db0*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_free_t : System.MulticastDelegate
                {
                    /*0x36d3dc4*/ unitytls_x509list_free_t(object object, nint method);
                    /*0x36d3e74*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list);
                }

                class unitytls_x509verify_default_ca_t : System.MulticastDelegate
                {
                    /*0x36d3e88*/ unitytls_x509verify_default_ca_t(object object, nint method);
                    /*0x36d3f28*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_explicit_ca_t : System.MulticastDelegate
                {
                    /*0x36d3f3c*/ unitytls_x509verify_explicit_ca_t(object object, nint method);
                    /*0x36d3fdc*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_server_t : System.MulticastDelegate
                {
                    /*0x36d3ff4*/ unitytls_tlsctx_create_server_t(object object, nint method);
                    /*0x36d4094*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_client_t : System.MulticastDelegate
                {
                    /*0x36d40d0*/ unitytls_tlsctx_create_client_t(object object, nint method);
                    /*0x36d4170*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_server_require_client_authentication_t : System.MulticastDelegate
                {
                    /*0x36d41ac*/ unitytls_tlsctx_server_require_client_authentication_t(object object, nint method);
                    /*0x36d4260*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_certificate_callback_t : System.MulticastDelegate
                {
                    /*0x36d4274*/ unitytls_tlsctx_set_certificate_callback_t(object object, nint method);
                    /*0x36d4328*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_trace_callback_t : System.MulticastDelegate
                {
                    /*0x36d433c*/ unitytls_tlsctx_set_trace_callback_t(object object, nint method);
                    /*0x36d43f0*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_x509verify_callback_t : System.MulticastDelegate
                {
                    /*0x36d4404*/ unitytls_tlsctx_set_x509verify_callback_t(object object, nint method);
                    /*0x36d44b8*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_supported_ciphersuites_t : System.MulticastDelegate
                {
                    /*0x36d44cc*/ unitytls_tlsctx_set_supported_ciphersuites_t(object object, nint method);
                    /*0x36d4580*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_ciphersuite_t : System.MulticastDelegate
                {
                    /*0x36d4594*/ unitytls_tlsctx_get_ciphersuite_t(object object, nint method);
                    /*0x36d4648*/ Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_protocol_t : System.MulticastDelegate
                {
                    /*0x36d465c*/ unitytls_tlsctx_get_protocol_t(object object, nint method);
                    /*0x36d4710*/ Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_process_handshake_t : System.MulticastDelegate
                {
                    /*0x36d4724*/ unitytls_tlsctx_process_handshake_t(object object, nint method);
                    /*0x36d47d8*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_read_t : System.MulticastDelegate
                {
                    /*0x36d47ec*/ unitytls_tlsctx_read_t(object object, nint method);
                    /*0x36d48a0*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_write_t : System.MulticastDelegate
                {
                    /*0x36d48b4*/ unitytls_tlsctx_write_t(object object, nint method);
                    /*0x36d4968*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_notify_close_t : System.MulticastDelegate
                {
                    /*0x36d497c*/ unitytls_tlsctx_notify_close_t(object object, nint method);
                    /*0x36d4a30*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_free_t : System.MulticastDelegate
                {
                    /*0x36d4a44*/ unitytls_tlsctx_free_t(object object, nint method);
                    /*0x36d4af4*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx);
                }

                class unitytls_random_generate_bytes_t : System.MulticastDelegate
                {
                    /*0x36d4b08*/ unitytls_random_generate_bytes_t(object object, nint method);
                    /*0x36d4bbc*/ void Invoke(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_result_to_string_t : System.MulticastDelegate
                {
                    /*0x36d4bd0*/ unitytls_x509verify_result_to_string_t(object object, nint method);
                    /*0x36d4c70*/ char* Invoke(Mono.Unity.UnityTls.unitytls_x509verify_result v);
                }

                class unitytls_tlsctx_set_trace_level_t : System.MulticastDelegate
                {
                    /*0x36d4c84*/ unitytls_tlsctx_set_trace_level_t(object object, nint method);
                    /*0x36d4d38*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_log_level level);
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

            static /*0x36d5ab0*/ void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, ref Mono.Unity.UnityTls.unitytls_x509list* nativeCertChain, ref Mono.Unity.UnityTls.unitytls_key* nativeKey);
            static /*0x36d4d4c*/ nint WriteCallback(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x36d4e5c*/ nint ReadCallback(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x36d4f6c*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x36d5064*/ void CertificateCallback(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x36d5174*/ UnityTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
            /*0x36d5df0*/ bool get_IsAuthenticated();
            /*0x36d5df8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
            /*0x36d5e00*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
            /*0x36d5e08*/ System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
            /*0x36d5fdc*/ System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
            /*0x36d61a4*/ void Renegotiate();
            /*0x36d61dc*/ bool PendingRenegotiation();
            /*0x36d61e4*/ void Shutdown();
            /*0x36d62f4*/ void Dispose(bool disposing);
            /*0x36d63ec*/ void StartHandshake();
            /*0x36d656c*/ bool ProcessHandshake();
            /*0x36d6744*/ void FinishHandshake();
            /*0x36d68a0*/ nint WriteCallback(byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x36d6ce0*/ nint ReadCallback(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x36d7104*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x36d7528*/ void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class UnityTlsConversions
        {
            static /*0x36d5a48*/ Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x36d5a78*/ Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x36d6880*/ Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol);
            static /*0x36d2f78*/ Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x36d7d64*/ System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
            static /*0x36d7d94*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
        }

        class UnityTlsProvider : Mono.Net.Security.MobileTlsProvider
        {
            static /*0x36d7dd0*/ Mono.Unity.UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x36d89a0*/ UnityTlsProvider();
            /*0x36d7e34*/ string get_Name();
            /*0x36d7e74*/ System.Guid get_ID();
            /*0x36d7ecc*/ bool get_SupportsSslStream();
            /*0x36d7ed4*/ bool get_SupportsMonoExtensions();
            /*0x36d7edc*/ bool get_SupportsConnectionInfo();
            /*0x36d7ee4*/ bool get_SupportsCleanShutdown();
            /*0x36d7eec*/ System.Security.Authentication.SslProtocols get_SupportedProtocols();
            /*0x36d7ef4*/ Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x36d8010*/ bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
        }

        class UnityTlsStream : Mono.Net.Security.MobileAuthenticatedStream
        {
            /*0x36d7f7c*/ UnityTlsStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
            /*0x36d8b20*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
        }

        class X509ChainImplUnityTls : System.Security.Cryptography.X509Certificates.X509ChainImpl
        {
            /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
            /*0x18*/ Mono.Unity.UnityTls.unitytls_x509list* ownedList;
            /*0x20*/ Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain;
            /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
            /*0x30*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;
            /*0x38*/ bool reverseOrder;

            /*0x36d748c*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder);
            /*0x36d88c4*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list* ownedList, Mono.Unity.UnityTls.unitytls_errorstate* errorState, bool reverseOrder);
            /*0x36d8b88*/ bool get_IsValid();
            /*0x36d8bb0*/ Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain();
            /*0x36d8bb8*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
            /*0x36d8eb0*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
            /*0x36d8f88*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
            /*0x36d8f90*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
            /*0x36d8f98*/ void Reset();
            /*0x36d9020*/ void Dispose(bool disposing);
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

                /*0x36d9088*/ BufferOffsetSize(byte[] buffer, int offset, int size);
                /*0x36d9058*/ int get_EndOffset();
                /*0x36d9064*/ int get_Remaining();
                /*0x36d918c*/ string ToString();
            }

            class BufferOffsetSize2 : Mono.Net.Security.BufferOffsetSize
            {
                /*0x28*/ int InitialSize;

                /*0x36d9220*/ BufferOffsetSize2(int size);
                /*0x36d9290*/ void Reset();
                /*0x36d92f8*/ void MakeRoom(int size);
                /*0x36d93c4*/ void AppendData(byte[] buffer, int offset, int size);
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

                /*0x36d9434*/ AsyncProtocolResult(int result);
                /*0x36d945c*/ AsyncProtocolResult(System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x36d9424*/ int get_UserResult();
                /*0x36d942c*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
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

                /*0x36d94d0*/ AsyncProtocolRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x36d948c*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x36d9494*/ bool get_RunSynchronously();
                /*0x36d949c*/ string get_Name();
                /*0x36d94c0*/ int get_UserResult();
                /*0x36d94c8*/ void set_UserResult(int value);
                /*0x36d9568*/ void RequestRead(int size);
                /*0x36d9630*/ void RequestWrite();
                /*0x36d963c*/ System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken);
                /*0x36d9768*/ System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken);
                /*0x36d9864*/ System.Threading.Tasks.Task<System.Nullable<int>> InnerRead(System.Threading.CancellationToken cancellationToken);
                Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
                /*0x36d9994*/ string ToString();

                struct <StartOperation>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Mono.Net.Security.AsyncProtocolResult> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x36d99ec*/ void MoveNext();
                    /*0x36d9de0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x36d9e5c*/ void MoveNext();
                    /*0x36da83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x36da8a4*/ void MoveNext();
                    /*0x36dae90*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AsyncHandshakeRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x36daf0c*/ AsyncHandshakeRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x36daf10*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncReadOrWriteRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x38*/ Mono.Net.Security.BufferOffsetSize <UserBuffer>k__BackingField;
                /*0x40*/ int <CurrentSize>k__BackingField;

                /*0x36db2d8*/ AsyncReadOrWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x36db2c0*/ Mono.Net.Security.BufferOffsetSize get_UserBuffer();
                /*0x36db2c8*/ int get_CurrentSize();
                /*0x36db2d0*/ void set_CurrentSize(int value);
                /*0x36db37c*/ string ToString();
            }

            class AsyncReadRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x36db3d8*/ AsyncReadRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x36db3dc*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncWriteRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x36db594*/ AsyncWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x36db598*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
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

                static /*0x36db760*/ Mono.Net.Security.ChainValidationHelper GetInternalValidator(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x36dbbd4*/ Mono.Net.Security.ChainValidationHelper Create(Mono.Net.Security.MobileTlsProvider provider, ref Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MonoTlsStream stream);
                static /*0x36dbd88*/ System.Net.ServerCertValidationCallback GetValidationCallback(Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x36dbf5c*/ System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x36db834*/ ChainValidationHelper(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, bool cloneSettings, Mono.Net.Security.MonoTlsStream stream);
                /*0x36dbf98*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x36dbfa0*/ bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, ref System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
                /*0x36dbff4*/ Mono.Security.Interface.ValidationResult ValidateCertificate(string host, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x36dc0cc*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x36dc1a8*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, ref System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x36dc5c8*/ bool InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ Mono.Security.Interface.MonoTlsSettings settings;

                    /*0x36dbf54*/ <>c__DisplayClass11_0();
                    /*0x36dc684*/ bool <GetValidationCallback>b__0(object s, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, System.Net.Security.SslPolicyErrors e);
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

                static /*0x36ddd4c*/ MobileAuthenticatedStream();
                static /*0x36da59c*/ System.Exception GetSSPIException(System.Exception e);
                static /*0x36dc8cc*/ System.Exception GetIOException(System.Exception e, string message);
                static /*0x36dca48*/ System.Exception GetInternalError();
                static /*0x36dca94*/ System.Exception GetInvalidNestedCallException();
                /*0x36d89b0*/ MobileAuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
                /*0x36dc7e4*/ System.Net.Security.SslStream get_SslStream();
                /*0x36dc7ec*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x36dc7f4*/ Mono.Net.Security.MobileTlsProvider get_Provider();
                /*0x36dc7fc*/ string get_TargetHost();
                /*0x36dc804*/ void set_TargetHost(string value);
                /*0x36dc80c*/ void CheckThrow(bool authSuccessCheck, bool shutdownCheck);
                /*0x36d9da0*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e);
                /*0x36dcae0*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x36dce44*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x36dcd24*/ System.Threading.Tasks.Task ProcessAuthentication(bool runSynchronously, Mono.Net.Security.MonoSslAuthenticationOptions options, System.Threading.CancellationToken cancellationToken);
                /*0x1f302cc*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x36dcf60*/ int Read(byte[] buffer, int offset, int count);
                /*0x36dd1a8*/ void Write(byte[] buffer, int offset, int count);
                /*0x36dd274*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x36dd308*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x36dd054*/ System.Threading.Tasks.Task<int> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken);
                /*0x36d7004*/ int InternalRead(byte[] buffer, int offset, int size, ref bool outWantMore);
                /*0x36dd39c*/ System.ValueTuple<int, bool> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size);
                /*0x36d6b1c*/ bool InternalWrite(byte[] buffer, int offset, int size);
                /*0x36dd514*/ bool InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size);
                /*0x36dad48*/ System.Threading.Tasks.Task<int> InnerRead(bool sync, int requestedSize, System.Threading.CancellationToken cancellationToken);
                /*0x36da730*/ System.Threading.Tasks.Task InnerWrite(bool sync, System.Threading.CancellationToken cancellationToken);
                /*0x36daf28*/ Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status, bool renegotiate);
                /*0x36db444*/ System.ValueTuple<int, bool> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x36db610*/ System.ValueTuple<int, bool> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x36dd60c*/ bool get_IsAuthenticated();
                /*0x36dd6f8*/ void Dispose(bool disposing);
                /*0x36dd938*/ void Flush();
                /*0x36dd958*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x36dda34*/ System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate();
                /*0x36ddb38*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x36ddb70*/ void SetLength(long value);
                /*0x36ddb90*/ bool get_CanRead();
                /*0x36ddbd4*/ bool get_CanTimeout();
                /*0x36ddbf0*/ bool get_CanWrite();
                /*0x36ddc54*/ bool get_CanSeek();
                /*0x36ddc5c*/ long get_Length();
                /*0x36ddc78*/ long get_Position();
                /*0x36ddc94*/ void set_Position(long value);
                /*0x36ddccc*/ int get_ReadTimeout();
                /*0x36ddcec*/ void set_ReadTimeout(int value);
                /*0x36ddd0c*/ int get_WriteTimeout();
                /*0x36ddd2c*/ void set_WriteTimeout(int value);
                /*0x36ddd98*/ void <InnerWrite>b__67_0();

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

                    /*0x36dddcc*/ void MoveNext();
                    /*0x36de728*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x36de790*/ void MoveNext();
                    /*0x36def4c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass66_0
                {
                    /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x18*/ int len;

                    /*0x36defc8*/ <>c__DisplayClass66_0();
                    /*0x36defd0*/ int <InnerRead>b__0();
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

                    /*0x36df018*/ void MoveNext();
                    /*0x36df4f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerWrite>d__67 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x36df574*/ void MoveNext();
                    /*0x36df89c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x36d589c*/ MobileTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x36df904*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x36d62dc*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x1f2fe14*/ bool get_IsAuthenticated();
                /*0x36df90c*/ bool get_IsServer();
                /*0x36df914*/ string get_TargetHost();
                /*0x36df91c*/ string get_ServerName();
                /*0x36df924*/ bool get_AskForClientCertificate();
                /*0x36df92c*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x1f309e4*/ void StartHandshake();
                /*0x1f2fe14*/ bool ProcessHandshake();
                /*0x1f309e4*/ void FinishHandshake();
                /*0x36df934*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate();
                /*0x36df93c*/ void set_LocalServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
                /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
                System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
                System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
                /*0x1f309e4*/ void Shutdown();
                /*0x1f2fe14*/ bool PendingRenegotiation();
                /*0x36d66f4*/ bool ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x36d7804*/ System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(string[] acceptableIssuers);
                /*0x1f309e4*/ void Renegotiate();
                /*0x36dd8c8*/ void Dispose();
                /*0x36df944*/ void Dispose(bool disposing);
                /*0x36df948*/ void Finalize();
            }

            class MobileTlsProvider : Mono.Security.Interface.MonoTlsProvider
            {
                /*0x36d89a8*/ MobileTlsProvider();
                Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
                bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
            }

            class MonoSslAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;

                /*0x36df9e4*/ MonoSslAuthenticationOptions();
                /*0x1f2fe14*/ bool get_ServerMode();
                /*0x1f2ffc8*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x1f30b78*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x1f30b78*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x1f30b78*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x1f30214*/ string get_TargetHost();
                /*0x1f30ebc*/ void set_TargetHost(string value);
                /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x1f30ebc*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x1f2fe14*/ bool get_ClientCertificateRequired();
                /*0x36df9dc*/ System.Net.Security.ServerCertSelectionCallback get_ServerCertSelectionDelegate();
            }

            class MonoSslClientAuthenticationOptions : Mono.Net.Security.MonoSslAuthenticationOptions
            {
                /*0x18*/ System.Net.Security.SslClientAuthenticationOptions <Options>k__BackingField;

                /*0x36dccb8*/ MonoSslClientAuthenticationOptions();
                /*0x36df9ec*/ System.Net.Security.SslClientAuthenticationOptions get_Options();
                /*0x36df9f4*/ bool get_ServerMode();
                /*0x36df9fc*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x36dfa14*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x36dfa2c*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x36dfa44*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x36dfa5c*/ string get_TargetHost();
                /*0x36dfa74*/ void set_TargetHost(string value);
                /*0x36dfa8c*/ bool get_ClientCertificateRequired();
                /*0x36dfac4*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x36dfadc*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x36dfaf4*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
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

                static /*0x36e0ab0*/ MonoTlsProviderFactory();
                static /*0x36dbc68*/ Mono.Net.Security.MobileTlsProvider GetProviderInternal();
                static /*0x36dfb2c*/ void InitializeInternal();
                static /*0x36e0278*/ Mono.Net.Security.MobileTlsProvider LookupProvider(string name, bool throwOnError);
                static /*0x36dfee8*/ void InitializeProviderRegistration();
                static /*0x36e08c8*/ void PopulateUnityProviders();
                static /*0x36e0a14*/ void PopulateProviders();
                static /*0x36e00f0*/ Mono.Net.Security.MobileTlsProvider CreateDefaultProviderImpl();
                static /*0x36e0a64*/ Mono.Net.Security.MobileTlsProvider GetProvider();
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

                /*0x36e0c10*/ MonoTlsStream(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream);
                /*0x36e0bf0*/ System.Net.HttpWebRequest get_Request();
                /*0x36e0bf8*/ System.Net.WebExceptionStatus get_ExceptionStatus();
                /*0x36e0c00*/ bool get_CertificateValidationFailed();
                /*0x36e0c08*/ void set_CertificateValidationFailed(bool value);
                /*0x36e0e3c*/ System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken);
                /*0x36e0f88*/ void Dispose();
                /*0x36e0f8c*/ void CloseSslStream();

                struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoTlsStream <>4__this;
                    /*0x38*/ System.Net.WebConnectionTunnel tunnel;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Net.Sockets.Socket <socket>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x36e1060*/ void MoveNext();
                    /*0x36e1800*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NoReflectionHelper
            {
                static /*0x36e187c*/ object GetProvider();
            }

            class SystemCertificateValidator
            {
                static /*0x0*/ bool is_macosx;
                static /*0x4*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;

                static /*0x36e18c8*/ SystemCertificateValidator();
                static /*0x36dc67c*/ bool NeedsChain(Mono.Security.Interface.MonoTlsSettings settings);
            }

            namespace Private
            {
                class CallbackHelpers
                {
                    static /*0x36e0d74*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback PublicToMono(System.Net.Security.RemoteCertificateValidationCallback callback);
                    static /*0x36dbe8c*/ System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback callback;

                        /*0x36e1918*/ <>c__DisplayClass0_0();
                        /*0x36e1928*/ bool <PublicToMono>b__0(string h, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, Mono.Security.Interface.MonoSslPolicyErrors e);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback;

                        /*0x36e1920*/ <>c__DisplayClass6_0();
                        /*0x36e1948*/ System.Security.Cryptography.X509Certificates.X509Certificate <MonoToInternal>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
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

            /*0x36e1968*/ NtlmSession();
            /*0x36e1970*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession> cache;

            static /*0x36e21cc*/ NtlmClient();
            /*0x36e21c4*/ NtlmClient();
            /*0x36e1e08*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x36e217c*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x36e2184*/ string get_AuthenticationType();

            class <>c
            {
                static /*0x0*/ Mono.Http.NtlmClient.<> <>9;
                static /*0x8*/ System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<System.Net.HttpWebRequest, Mono.Http.NtlmSession> <>9__1_0;

                static /*0x36e2264*/ <>c();
                /*0x36e22cc*/ <>c();
                /*0x36e22d4*/ Mono.Http.NtlmSession <Authenticate>b__1_0(System.Net.HttpWebRequest x);
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

            static /*0x36e2cec*/ OidLookup();
            static /*0x36e2328*/ string ToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x36e2820*/ string ToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x36e2504*/ bool ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup);
            static /*0x36e250c*/ string NativeOidToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x36e29d0*/ string NativeFriendlyNameToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);

            class <>c
            {
                static /*0x0*/ Internal.Cryptography.OidLookup.<> <>9;

                static /*0x36e49d4*/ <>c();
                /*0x36e4a3c*/ <>c();
                /*0x36e4a44*/ string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<string, string> kvp);
                /*0x36e4b00*/ string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<string, string> kvp);
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

                static /*0x36e5b54*/ string GetSimpleNameInfo(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                static /*0x36e604c*/ string FindAltNameMatch(byte[] extensionBytes, Internal.Cryptography.Pal.GeneralNameType matchType, string otherOid);
                static /*0x36e6208*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                /*0x36e4bb8*/ CertificateData(byte[] rawData);
                /*0x36e5374*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);

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

                    /*0x36e6288*/ <ReadReverseRdns>d__21(int <>1__state);
                    /*0x36e62bc*/ void System.IDisposable.Dispose();
                    /*0x36e62c0*/ bool MoveNext();
                    /*0x36e6590*/ System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current();
                    /*0x36e659c*/ void System.Collections.IEnumerator.Reset();
                    /*0x36e65d4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x36e6630*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator();
                    /*0x36e66d4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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
            static /*0x36e66d8*/ bool DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.HandleRef hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, ref Microsoft.Win32.SafeHandles.SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
            static /*0x36e6848*/ nint GetCurrentProcess();
            static /*0x36e684c*/ bool GetExitCodeProcess(nint processHandle, ref int exitCode);
            static /*0x36e6850*/ bool GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, ref int exitCode);
            static /*0x36e6938*/ int GetCurrentProcessId();
            static /*0x36e693c*/ bool CloseProcess(nint handle);
        }

        namespace SafeHandles
        {
            class SafeProcessHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle InvalidHandle;

                static /*0x36e6974*/ SafeProcessHandle();
                /*0x36e6940*/ SafeProcessHandle(nint handle);
                /*0x36e681c*/ SafeProcessHandle(nint existingHandle, bool ownsHandle);
                /*0x36e696c*/ bool ReleaseHandle();
            }
        }
    }
}

namespace System
{
    class IPv4AddressHelper
    {
        static /*0x36e69e4*/ int ParseHostNumber(System.ReadOnlySpan<char> str, int start, int end);
        static /*0x36e6aa4*/ bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme);
        static /*0x36e6a14*/ bool ParseCanonical(System.ReadOnlySpan<char> name, byte* numbers, int start, int end);
        static /*0x36e6ad4*/ bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile);
        static /*0x36e6c3c*/ long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile);
        static /*0x36e6f00*/ string ParseCanonicalName(string str, int start, int end, ref bool isLoopback);
        static /*0x36e7248*/ bool Parse(string name, byte* numbers, int start, int end);
    }

    class IPv6AddressHelper
    {
        static /*0x39b5788*/ System.ValueTuple<int, int> FindCompressionRange(System.ReadOnlySpan<ushort> numbers);
        static /*0x39b5874*/ bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<ushort> numbers);
        static /*0x39b5944*/ bool IsValidStrict(char* name, int start, ref int end);
        static /*0x39b5c80*/ void Parse(System.ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId);
        static /*0x39b6194*/ string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId);
        static /*0x39b6910*/ bool IsLoopback(System.ReadOnlySpan<ushort> numbers);
        static /*0x39b69f0*/ bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress);
        static /*0x39b6cc0*/ bool IsValid(char* name, int start, ref int end);
    }

    class NotImplemented
    {
        static /*0x39b6cc8*/ System.Exception ByDesignWithMessage(string message);
    }

    class PasteArguments
    {
        static /*0x39b6d24*/ void AppendArgument(System.Text.StringBuilder stringBuilder, string argument);
        static /*0x39b6f08*/ bool ContainsNoWhitespaceOrQuotes(string s);
    }

    class StringExtensions
    {
        static /*0x39b6fa8*/ string SubstringTrim(string value, int startIndex);
        static /*0x39b6fc0*/ string SubstringTrim(string value, int startIndex, int length);
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

        /*0x39b70f4*/ UriBuilder(System.Uri uri);
        /*0x39b7664*/ UriBuilder(string schemeName, string hostName);
        /*0x39b7a20*/ UriBuilder(string scheme, string host, int portNumber);
        /*0x39b72b4*/ void Init(System.Uri uri);
        /*0x39b7934*/ void set_Host(string value);
        /*0x39b7ab0*/ void set_Path(string value);
        /*0x39b7a48*/ void set_Port(int value);
        /*0x39b7b70*/ void set_Query(string value);
        /*0x39b77f0*/ void set_Scheme(string value);
        /*0x39b7c28*/ System.Uri get_Uri();
        /*0x39b7cc8*/ bool Equals(object rparam);
        /*0x39b7d24*/ int GetHashCode();
        /*0x39b7490*/ void SetFieldsFromUri(System.Uri uri);
        /*0x39b7d44*/ string ToString();
    }

    class SecurityUtils
    {
        static /*0x39b8268*/ void DemandReflectionAccess(System.Type type);
        static /*0x39b826c*/ void DemandGrantSet(System.Reflection.Assembly assembly);
        static /*0x39b8270*/ bool HasReflectionPermission(System.Type type);
        static /*0x39b8278*/ object SecureCreateInstance(System.Type type);
        static /*0x39b8284*/ object SecureCreateInstance(System.Type type, object[] args, bool allowNonPublic);
        static /*0x39b8354*/ object SecureCreateInstance(System.Type type, object[] args);
        static /*0x39b835c*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic);
        static /*0x39b8364*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic, System.Reflection.BindingFlags extraFlags);
        static /*0x39b84cc*/ bool GenericArgumentsAreVisible(System.Reflection.MethodInfo method);
        static /*0x39b856c*/ object MethodInfoInvoke(System.Reflection.MethodInfo method, object target, object[] args);
    }

    class InvariantComparer : System.Collections.IComparer
    {
        static /*0x0*/ System.InvariantComparer Default;
        /*0x10*/ System.Globalization.CompareInfo m_compareInfo;

        static /*0x39b87c0*/ InvariantComparer();
        /*0x39b8658*/ InvariantComparer();
        /*0x39b86e0*/ int Compare(object a, object b);
    }

    class IriHelper
    {
        static /*0x39b8824*/ bool CheckIriUnicodeRange(char unicode, bool isQuery);
        static /*0x39b887c*/ bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery);
        static /*0x39b8e98*/ bool CheckIsReserved(char ch, System.UriComponents component);
        static /*0x39b8fdc*/ string EscapeUnescapeIri(char* pInput, int start, int end, System.UriComponents component);
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

        static /*0x39853b4*/ Uri();
        static /*0x3977d0c*/ bool IriParsingStatic(System.UriParser syntax);
        static /*0x3977f2c*/ bool StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x3977fc4*/ bool StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x397a420*/ System.ParsingError GetCombinedString(System.Uri baseUri, string relativeStr, bool dontEscape, ref string result);
        static /*0x397b220*/ System.UriFormatException GetException(System.ParsingError err);
        static /*0x397c5a0*/ bool StaticIsFile(System.UriParser syntax);
        static /*0x397c5b8*/ object get_InitializeLock();
        static /*0x397c684*/ void InitializeUriConfig();
        static /*0x397d470*/ bool IsGenDelim(char ch);
        static /*0x397d498*/ bool CheckSchemeName(string schemeName);
        static /*0x397d65c*/ bool IsHexDigit(char character);
        static /*0x397d68c*/ int FromHex(char digit);
        static /*0x397dbf4*/ bool op_Equality(System.Uri uri1, System.Uri uri2);
        static /*0x397a05c*/ bool op_Inequality(System.Uri uri1, System.Uri uri2);
        static /*0x397e2fc*/ bool CheckForColonInFirstPathSegment(string uriString);
        static /*0x397e3b4*/ string InternalEscapeString(string rawString);
        static /*0x397e488*/ System.ParsingError ParseScheme(string uriString, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x39805d8*/ string CreateHostStringHelper(string str, ushort idx, ushort end, ref System.Uri.Flags flags, ref string scopeId);
        static /*0x397e560*/ ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x39827f8*/ bool CheckKnownSchemes(long* lptr, ushort nChars, ref System.UriParser syntax);
        static /*0x397a678*/ System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref System.UriParser syntax);
        static /*0x39835d0*/ void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3);
        static /*0x397c828*/ char[] Compress(char[] dest, ushort start, ref int destLength, System.UriParser syntax);
        static /*0x397d860*/ int CalculateCaseInsensitiveHashCode(string text);
        static /*0x397a7f0*/ string CombineUri(System.Uri basePart, string relativePart, System.UriFormat uriFormat);
        static /*0x397f1a8*/ bool IsLWS(char ch);
        static /*0x397d5d8*/ bool IsAsciiLetter(char character);
        static /*0x397d5f0*/ bool IsAsciiLetterOrDigit(char character);
        static /*0x39837d4*/ bool IsBidiControlCharacter(char ch);
        static /*0x39833e0*/ string StripBidiControlCharacter(char* strToClean, int start, int length);
        static /*0x397e22c*/ bool TryCreate(string uriString, System.UriKind uriKind, ref System.Uri result);
        static /*0x39843f4*/ bool TryCreate(System.Uri baseUri, string relativeUri, ref System.Uri result);
        static /*0x39844dc*/ bool TryCreate(System.Uri baseUri, System.Uri relativeUri, ref System.Uri result);
        static /*0x3984d5c*/ bool IsWellFormedUriString(string uriString, System.UriKind uriKind);
        static /*0x3984df8*/ string UnescapeDataString(string stringToUnescape);
        static /*0x3984f94*/ string EscapeDataString(string stringToEscape);
        static /*0x3984170*/ System.Uri CreateHelper(string uriString, bool dontEscape, System.UriKind uriKind, ref System.UriFormatException e);
        static /*0x3979b68*/ System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, ref string newUriString, ref bool userEscaped, ref System.UriFormatException e);
        /*0x3979644*/ Uri(string uriString);
        /*0x3979878*/ Uri(string uriString, System.UriKind uriKind);
        /*0x39798fc*/ Uri(System.Uri baseUri, string relativeUri);
        /*0x397a1f0*/ Uri(System.Uri baseUri, System.Uri relativeUri);
        /*0x397b3bc*/ Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x39850b4*/ Uri(System.Uri.Flags flags, System.UriParser uriParser, string uri);
        /*0x3977cb4*/ bool get_IsImplicitFile();
        /*0x3977cc0*/ bool get_IsUncOrDosPath();
        /*0x3977cd0*/ bool get_IsDosPath();
        /*0x3977cdc*/ bool get_IsUncPath();
        /*0x3977ce8*/ System.Uri.Flags get_HostType();
        /*0x3977cf4*/ System.UriParser get_Syntax();
        /*0x3977cfc*/ bool get_IsNotAbsoluteUri();
        /*0x3977d98*/ bool get_AllowIdn();
        /*0x3977e64*/ bool AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags);
        /*0x3977f38*/ bool IsIntranet(string schemeHost);
        /*0x3977f40*/ bool get_UserDrivenParsing();
        /*0x3977f4c*/ void SetUserDrivenParsing();
        /*0x3977f60*/ ushort get_SecuredPathIndex();
        /*0x3977e54*/ bool NotAny(System.Uri.Flags flags);
        /*0x3977fb4*/ bool InFact(System.Uri.Flags flags);
        /*0x3977fd0*/ System.Uri.UriInfo EnsureUriInfo();
        /*0x39785b8*/ void EnsureParseRemaining();
        /*0x39791e4*/ void EnsureHostString(bool allowDnsOptimization);
        /*0x39799cc*/ void CreateUri(System.Uri baseUri, string relativeUri, bool dontEscape);
        /*0x397b4c4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x397b4c8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x397b59c*/ string get_AbsolutePath();
        /*0x397b65c*/ string get_PrivateAbsolutePath();
        /*0x397b728*/ string get_AbsoluteUri();
        /*0x397b848*/ string get_LocalPath();
        /*0x397bed4*/ string get_Authority();
        /*0x397bf40*/ System.UriHostNameType get_HostNameType();
        /*0x397c038*/ bool get_IsDefaultPort();
        /*0x397c0e0*/ bool get_IsFile();
        /*0x397c1a0*/ bool get_IsLoopback();
        /*0x397c220*/ string get_PathAndQuery();
        /*0x397c2e8*/ string[] get_Segments();
        /*0x397c4c8*/ bool get_IsUnc();
        /*0x397c534*/ string get_Host();
        /*0x397b8ac*/ string GetLocalPath();
        /*0x397cdc4*/ int get_Port();
        /*0x397ce88*/ string get_Query();
        /*0x397cfac*/ string get_Fragment();
        /*0x397d0d0*/ string get_Scheme();
        /*0x397d138*/ bool get_OriginalStringSwitched();
        /*0x397a7c8*/ string get_OriginalString();
        /*0x397d180*/ string get_DnsSafeHost();
        /*0x397d3c8*/ string get_IdnHost();
        /*0x39799bc*/ bool get_IsAbsoluteUri();
        /*0x397d3f8*/ bool get_UserEscaped();
        /*0x397d404*/ string get_UserInfo();
        /*0x397d718*/ int GetHashCode();
        /*0x397d900*/ string ToString();
        /*0x397dc28*/ bool Equals(object comparand);
        /*0x397ead0*/ System.UriFormatException ParseMinimal();
        /*0x397eb50*/ System.ParsingError PrivateParseMinimal();
        /*0x39800b8*/ void PrivateParseMinimalIri(string newHost, ushort idx);
        /*0x3977ff4*/ void CreateUriInfo(System.Uri.Flags cF);
        /*0x3979244*/ void CreateHostString();
        /*0x39801ac*/ void GetHostViaCustomSyntax();
        /*0x397b598*/ string GetParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x3980d68*/ string GetEscapedParts(System.UriComponents uriParts);
        /*0x397ccf4*/ string GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x398140c*/ string ReCreateParts(System.UriComponents parts, ushort nonCanonical, System.UriFormat formatAs);
        /*0x3980e30*/ string GetUriPartsFromUserString(System.UriComponents uriParts);
        /*0x39785c8*/ void ParseRemaining();
        /*0x397f1c8*/ ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, System.UriParser syntax, ref string newHost);
        /*0x3982d40*/ void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, System.UriParser syntax, string userInfoString, ref System.Uri.Flags flags, ref bool justNormalized, ref string newHost, ref System.ParsingError err);
        /*0x39830d4*/ void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, System.UriParser syntax, ref System.Uri.Flags flags, ref string newHost, ref System.ParsingError err);
        /*0x3982754*/ void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim);
        /*0x3983544*/ void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim);
        /*0x39807b4*/ System.Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim);
        /*0x39820d8*/ char[] GetCanonicalPath(char[] dest, ref int pos, System.UriFormat formatAs);
        /*0x39837c8*/ bool get_HasAuthority();
        /*0x39796c4*/ void CreateThis(string uri, bool dontEscape, System.UriKind uriKind);
        /*0x39837fc*/ void InitializeUri(System.ParsingError err, System.UriKind uriKind, ref System.UriFormatException e);
        /*0x3983d98*/ bool CheckForConfigLoad(string data);
        /*0x3983e78*/ bool CheckForUnicode(string data);
        /*0x3983f98*/ bool CheckForEscapedUnreserved(string data);
        /*0x3980ba0*/ string GetComponents(System.UriComponents components, System.UriFormat format);
        /*0x39848a8*/ bool IsWellFormedOriginalString();
        /*0x39848ec*/ bool InternalIsWellFormedOriginalString();
        /*0x39827a4*/ string EscapeUnescapeIri(string input, int start, int end, System.UriComponents component);
        /*0x3984690*/ string GetRelativeSerializationString(System.UriFormat format);
        /*0x397d9e0*/ string GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x3985108*/ bool IsBaseOf(System.Uri uri);
        /*0x39851bc*/ bool IsBaseOfHelper(System.Uri uriLink);
        /*0x397a0a4*/ void CreateThisFromUri(System.Uri otherUri);

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

            /*0x39b9ed8*/ UriInfo();
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

            /*0x39b9ee0*/ MoreInfo();
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
        /*0x39b9ee8*/ UriFormatException();
        /*0x39b816c*/ UriFormatException(string textString);
        /*0x39b9ef0*/ UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x39b9ef8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

        static /*0x39bb4f8*/ UriHelper();
        static /*0x39b9f00*/ bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase);
        static /*0x39ba0c4*/ char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd);
        static /*0x39ba66c*/ char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos);
        static /*0x39ba97c*/ char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x39baa5c*/ char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x39b9914*/ void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing);
        static /*0x39b9dd0*/ void EscapeAsciiChar(char ch, char[] to, ref int pos);
        static /*0x39b9814*/ char EscapedAscii(char digit, char next);
        static /*0x39b988c*/ bool IsNotSafeForUnescape(char ch);
        static /*0x39ba87c*/ bool IsReservedUnreservedOrHash(char c);
        static /*0x39ba79c*/ bool IsUnreserved(char c);
        static /*0x39bb45c*/ bool Is3986Unreserved(char c);
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

        static /*0x39bba88*/ UriParser();
        static /*0x39bb3fc*/ bool get_ShouldUseLegacyV2Quirks();
        static /*0x39bc444*/ System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme);
        static /*0x39b8174*/ System.UriParser GetSyntax(string lwrCaseScheme);
        /*0x39bb5a8*/ UriParser();
        /*0x39bb5e4*/ UriParser(System.UriSyntaxFlags flags);
        /*0x39bb598*/ string get_SchemeName();
        /*0x39bb5a0*/ int get_DefaultPort();
        /*0x39bb628*/ System.UriParser OnNewUri();
        /*0x39bb62c*/ void InitializeAndValidate(System.Uri uri, ref System.UriFormatException parsingError);
        /*0x39bb65c*/ string Resolve(System.Uri baseUri, System.Uri relativeUri, ref System.UriFormatException parsingError);
        /*0x39bb83c*/ bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri);
        /*0x39bb858*/ string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format);
        /*0x39bba70*/ bool IsWellFormedOriginalString(System.Uri uri);
        /*0x39bc3d8*/ System.UriSyntaxFlags get_Flags();
        /*0x39b8260*/ bool NotAny(System.UriSyntaxFlags flags);
        /*0x39b8244*/ bool InFact(System.UriSyntaxFlags flags);
        /*0x39bc43c*/ bool IsAllSet(System.UriSyntaxFlags flags);
        /*0x39bc3e0*/ bool IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected);
        /*0x39bc720*/ bool get_IsSimple();
        /*0x39bc72c*/ System.UriParser InternalOnNewUri();
        /*0x39bc78c*/ void InternalValidate(System.Uri thisUri, ref System.UriFormatException parsingError);
        /*0x39bc798*/ string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, ref System.UriFormatException parsingError);
        /*0x39bc7a4*/ bool InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink);
        /*0x39bc7b0*/ string InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x39bc7bc*/ bool InternalIsWellFormedOriginalString(System.Uri thisUri);

        enum UriQuirksVersion
        {
            V2 = 2,
            V3 = 3,
        }

        class BuiltInUriParser : System.UriParser
        {
            /*0x39bc324*/ BuiltInUriParser(string lwrCaseScheme, int defaultPort, System.UriSyntaxFlags syntaxFlags);
        }
    }

    class DomainNameHelper
    {
        static /*0x39bc7c8*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x39bc968*/ bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x39bcb64*/ bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x39bcd50*/ string IdnEquivalent(string hostname);
        static /*0x39bcda0*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x39bd050*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost);
        static /*0x39bd29c*/ bool IsIdnAce(string input, int index);
        static /*0x39bd250*/ bool IsIdnAce(char* input, int index);
        static /*0x39bd334*/ string UnicodeEquivalent(string idnHost, char* hostname, int start, int end);
        static /*0x39bd454*/ string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x39bcadc*/ bool IsASCIILetterOrDigit(char character, ref bool notCanonical);
        static /*0x39bcb18*/ bool IsValidDomainLabelCharacter(char character, ref bool notCanonical);
    }

    class UncNameHelper
    {
        static /*0x39bd8f0*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x39bd8f4*/ bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile);
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
        /*0x39bdba4*/ IOAsyncCallback(object object, nint method);
        /*0x39bdcac*/ void Invoke(System.IOAsyncResult ioares);
    }

    class IOAsyncResult : System.IAsyncResult
    {
        /*0x10*/ System.AsyncCallback async_callback;
        /*0x18*/ object async_state;
        /*0x20*/ System.Threading.ManualResetEvent wait_handle;
        /*0x28*/ bool completed_synchronously;
        /*0x29*/ bool completed;

        /*0x39bdcc0*/ IOAsyncResult();
        /*0x39bdd18*/ IOAsyncResult(System.AsyncCallback async_callback, object async_state);
        /*0x39bdcc8*/ void Init(System.AsyncCallback async_callback, object async_state);
        /*0x39bdd5c*/ System.AsyncCallback get_AsyncCallback();
        /*0x39bdd64*/ object get_AsyncState();
        /*0x39bdd6c*/ System.Threading.WaitHandle get_AsyncWaitHandle();
        /*0x39bde98*/ bool get_CompletedSynchronously();
        /*0x39bdea0*/ void set_CompletedSynchronously(bool value);
        /*0x39bdea8*/ bool get_IsCompleted();
        /*0x39bdeb0*/ void set_IsCompleted(bool value);
        /*0x1f309e4*/ void CompleteDisposed();
    }

    class IOSelectorJob : System.Threading.IThreadPoolWorkItem
    {
        /*0x10*/ System.IOOperation operation;
        /*0x18*/ System.IOAsyncCallback callback;
        /*0x20*/ System.IOAsyncResult state;

        /*0x39bdf80*/ IOSelectorJob(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state);
        /*0x39bdfd4*/ void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem();
        /*0x39bdff8*/ void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae);
        /*0x39bdffc*/ void MarkDisposed();
    }

    class IOSelector
    {
        static /*0x39be018*/ void Add(nint handle, System.IOSelectorJob job);
    }

    class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        /*0x39be01c*/ UriTypeConverter();
        /*0x39be024*/ bool CanConvert(System.Type type);
        /*0x39be0dc*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
        /*0x39be164*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        /*0x39be1b0*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        /*0x39be338*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
    }

    namespace Timers
    {
        class ElapsedEventHandler : System.MulticastDelegate
        {
            /*0x39be4fc*/ ElapsedEventHandler(object object, nint method);
            /*0x39be608*/ void Invoke(object sender, System.Timers.ElapsedEventArgs e);
        }

        class Timer : System.ComponentModel.Component
        {
            /*0x28*/ double interval;
            /*0x30*/ bool enabled;
            /*0x31*/ bool initializing;
            /*0x32*/ bool delayedEnable;
            /*0x38*/ System.Timers.ElapsedEventHandler onIntervalElapsed;
            /*0x40*/ bool autoReset;
            /*0x48*/ System.ComponentModel.ISynchronizeInvoke synchronizingObject;
            /*0x50*/ bool disposed;
            /*0x58*/ System.Threading.Timer timer;
            /*0x60*/ System.Threading.TimerCallback callback;
            /*0x68*/ object cookie;

            static /*0x39be808*/ int CalculateRoundedInterval(double interval, bool argumentCheck);
            /*0x39be61c*/ Timer();
            /*0x39be6e0*/ Timer(double interval);
            /*0x39be9ec*/ void set_AutoReset(bool value);
            /*0x39bea84*/ void set_Enabled(bool value);
            /*0x39bea44*/ void UpdateTimer();
            /*0x39bec90*/ void add_Elapsed(System.Timers.ElapsedEventHandler value);
            /*0x39bed20*/ void remove_Elapsed(System.Timers.ElapsedEventHandler value);
            /*0x39bedb0*/ System.ComponentModel.ISite get_Site();
            /*0x39bedb8*/ System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject();
            /*0x39bef5c*/ void Close();
            /*0x39bef98*/ void Dispose(bool disposing);
            /*0x39befcc*/ void Start();
            /*0x39befd4*/ void Stop();
            /*0x39befdc*/ void MyTimerCallback(object state);
        }

        class TimersDescriptionAttribute : System.ComponentModel.DescriptionAttribute
        {
            /*0x18*/ bool replaced;

            /*0x39bf374*/ TimersDescriptionAttribute(string description);
            /*0x39bf3dc*/ string get_Description();
        }

        class ElapsedEventArgs : System.EventArgs
        {
            /*0x10*/ System.DateTime time;

            /*0x39bf308*/ ElapsedEventArgs(System.DateTime time);
        }
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

                /*0x39bf428*/ Capture(string text, int index, int length);
                /*0x39bf5e4*/ Capture();
                /*0x39bf470*/ int get_Index();
                /*0x39bf478*/ void set_Index(int value);
                /*0x39bf480*/ int get_Length();
                /*0x39bf488*/ void set_Length(int value);
                /*0x39bf490*/ string get_Text();
                /*0x39bf498*/ void set_Text(string value);
                /*0x39bf4a0*/ string get_Value();
                /*0x39bf4c0*/ string ToString();
                /*0x39bf4c4*/ System.ReadOnlySpan<char> GetLeftSubstring();
                /*0x39bf54c*/ System.ReadOnlySpan<char> GetRightSubstring();
            }

            class CaptureCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Capture>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Group _group;
                /*0x18*/ int _capcount;
                /*0x20*/ System.Text.RegularExpressions.Capture[] _captures;

                /*0x39c02c4*/ CaptureCollection();
                /*0x39bf61c*/ bool get_IsReadOnly();
                /*0x39bf624*/ int get_Count();
                /*0x39bf62c*/ System.Text.RegularExpressions.Capture get_Item(int i);
                /*0x39bf6f4*/ System.Collections.IEnumerator GetEnumerator();
                /*0x39bf7a0*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator();
                /*0x39bf630*/ System.Text.RegularExpressions.Capture GetCapture(int i);
                /*0x39bf810*/ void ForceInitialized();
                /*0x39bf998*/ bool get_IsSynchronized();
                /*0x39bf9a0*/ object get_SyncRoot();
                /*0x39bf9a8*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x39bfa5c*/ void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex);
                /*0x39bfbd8*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item);
                /*0x39bfc88*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, System.Text.RegularExpressions.Capture item);
                /*0x39bfcd4*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index);
                /*0x39bfd20*/ System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index);
                /*0x39bfd24*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, System.Text.RegularExpressions.Capture value);
                /*0x39bfd70*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item);
                /*0x39bfdbc*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear();
                /*0x39bfe08*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item);
                /*0x39bfebc*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item);
                /*0x39bff08*/ int System.Collections.IList.Add(object value);
                /*0x39bff54*/ void System.Collections.IList.Clear();
                /*0x39bffa0*/ bool System.Collections.IList.Contains(object value);
                /*0x39c0094*/ int System.Collections.IList.IndexOf(object value);
                /*0x39c0188*/ void System.Collections.IList.Insert(int index, object value);
                /*0x39c01d4*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x39c01dc*/ void System.Collections.IList.Remove(object value);
                /*0x39c0228*/ void System.Collections.IList.RemoveAt(int index);
                /*0x39c0274*/ object System.Collections.IList.get_Item(int index);
                /*0x39c0278*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.CaptureCollection _collection;
                    /*0x18*/ int _index;

                    /*0x39bf764*/ Enumerator(System.Text.RegularExpressions.CaptureCollection collection);
                    /*0x39c02fc*/ bool MoveNext();
                    /*0x39c0338*/ System.Text.RegularExpressions.Capture get_Current();
                    /*0x39c03ac*/ object System.Collections.IEnumerator.get_Current();
                    /*0x39c03b0*/ void System.Collections.IEnumerator.Reset();
                    /*0x39c03bc*/ void System.IDisposable.Dispose();
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

                static /*0x39c0490*/ Group();
                /*0x39c03c0*/ Group(string text, int[] caps, int capcount, string name);
                /*0x39c0598*/ Group();
                /*0x39c0480*/ bool get_Success();
            }

            class GroupCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Match _match;
                /*0x18*/ System.Collections.Hashtable _captureMap;
                /*0x20*/ System.Text.RegularExpressions.Group[] _groups;

                /*0x39c05d0*/ GroupCollection(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps);
                /*0x39c16b0*/ GroupCollection();
                /*0x39c0614*/ bool get_IsReadOnly();
                /*0x39c061c*/ int get_Count();
                /*0x39c0640*/ System.Text.RegularExpressions.Group get_Item(int groupnum);
                /*0x39c0748*/ System.Text.RegularExpressions.Group get_Item(string groupname);
                /*0x39c092c*/ System.Collections.IEnumerator GetEnumerator();
                /*0x39c09d8*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator();
                /*0x39c0644*/ System.Text.RegularExpressions.Group GetGroup(int groupnum);
                /*0x39c0a48*/ System.Text.RegularExpressions.Group GetGroupImpl(int groupnum);
                /*0x39c0d64*/ bool get_IsSynchronized();
                /*0x39c0d6c*/ object get_SyncRoot();
                /*0x39c0d74*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x39c0e2c*/ void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex);
                /*0x39c0fbc*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item);
                /*0x39c1074*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item);
                /*0x39c10c0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index);
                /*0x39c110c*/ System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index);
                /*0x39c1110*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, System.Text.RegularExpressions.Group value);
                /*0x39c115c*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item);
                /*0x39c11a8*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear();
                /*0x39c11f4*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item);
                /*0x39c12a8*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item);
                /*0x39c12f4*/ int System.Collections.IList.Add(object value);
                /*0x39c1340*/ void System.Collections.IList.Clear();
                /*0x39c138c*/ bool System.Collections.IList.Contains(object value);
                /*0x39c1480*/ int System.Collections.IList.IndexOf(object value);
                /*0x39c1574*/ void System.Collections.IList.Insert(int index, object value);
                /*0x39c15c0*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x39c15c8*/ void System.Collections.IList.Remove(object value);
                /*0x39c1614*/ void System.Collections.IList.RemoveAt(int index);
                /*0x39c1660*/ object System.Collections.IList.get_Item(int index);
                /*0x39c1664*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.GroupCollection _collection;
                    /*0x18*/ int _index;

                    /*0x39c099c*/ Enumerator(System.Text.RegularExpressions.GroupCollection collection);
                    /*0x39c16e8*/ bool MoveNext();
                    /*0x39c172c*/ System.Text.RegularExpressions.Group get_Current();
                    /*0x39c17b8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x39c17bc*/ void System.Collections.IEnumerator.Reset();
                    /*0x39c17c8*/ void System.IDisposable.Dispose();
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

                static /*0x39c251c*/ Match();
                static /*0x39c193c*/ System.Text.RegularExpressions.Match get_Empty();
                /*0x39c17cc*/ Match(System.Text.RegularExpressions.Regex regex, int capcount, string text, int begpos, int len, int startpos);
                /*0x39c25ac*/ Match();
                /*0x39c1994*/ void Reset(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart);
                /*0x39c1a30*/ System.Text.RegularExpressions.GroupCollection get_Groups();
                /*0x39c1aa8*/ System.Text.RegularExpressions.Match NextMatch();
                /*0x39c1d80*/ System.ReadOnlySpan<char> GroupToStringImpl(int groupnum);
                /*0x39c1ef0*/ System.ReadOnlySpan<char> LastGroupToStringImpl();
                /*0x39c1f14*/ void AddMatch(int cap, int start, int len);
                /*0x39c2108*/ void BalanceMatch(int cap);
                /*0x39c21e0*/ void RemoveMatch(int cap);
                /*0x39c2218*/ bool IsMatched(int cap);
                /*0x39c22a8*/ int MatchIndex(int cap);
                /*0x39c2334*/ int MatchLength(int cap);
                /*0x39c23c0*/ void Tidy(int textpos);
            }

            class MatchSparse : System.Text.RegularExpressions.Match
            {
                /*0x78*/ System.Collections.Hashtable _caps;

                /*0x39c25e4*/ MatchSparse(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, int capcount, string text, int begpos, int len, int startpos);
                /*0x39c269c*/ System.Text.RegularExpressions.GroupCollection get_Groups();
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

                /*0x39c2720*/ MatchCollection(System.Text.RegularExpressions.Regex regex, string input, int beginning, int length, int startat);
                /*0x39c3354*/ MatchCollection();
                /*0x39c2874*/ bool get_IsReadOnly();
                /*0x39c287c*/ int get_Count();
                /*0x39c28ec*/ System.Text.RegularExpressions.Match get_Item(int i);
                /*0x39c2a6c*/ System.Collections.IEnumerator GetEnumerator();
                /*0x39c2b18*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator();
                /*0x39c294c*/ System.Text.RegularExpressions.Match GetMatch(int i);
                /*0x39c28d8*/ void EnsureInitialized();
                /*0x39c2b88*/ bool get_IsSynchronized();
                /*0x39c2b90*/ object get_SyncRoot();
                /*0x39c2b94*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x39c2c60*/ void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex);
                /*0x39c2cdc*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item);
                /*0x39c2d48*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, System.Text.RegularExpressions.Match item);
                /*0x39c2d94*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index);
                /*0x39c2de0*/ System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index);
                /*0x39c2df0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, System.Text.RegularExpressions.Match value);
                /*0x39c2e3c*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item);
                /*0x39c2e88*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear();
                /*0x39c2ed4*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item);
                /*0x39c2f40*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item);
                /*0x39c2f8c*/ int System.Collections.IList.Add(object value);
                /*0x39c2fd8*/ void System.Collections.IList.Clear();
                /*0x39c3024*/ bool System.Collections.IList.Contains(object value);
                /*0x39c3118*/ int System.Collections.IList.IndexOf(object value);
                /*0x39c320c*/ void System.Collections.IList.Insert(int index, object value);
                /*0x39c3258*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x39c3260*/ void System.Collections.IList.Remove(object value);
                /*0x39c32ac*/ void System.Collections.IList.RemoveAt(int index);
                /*0x39c32f8*/ object System.Collections.IList.get_Item(int index);
                /*0x39c3308*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.MatchCollection _collection;
                    /*0x18*/ int _index;

                    /*0x39c2adc*/ Enumerator(System.Text.RegularExpressions.MatchCollection collection);
                    /*0x39c338c*/ bool MoveNext();
                    /*0x39c33dc*/ System.Text.RegularExpressions.Match get_Current();
                    /*0x39c3444*/ object System.Collections.IEnumerator.get_Current();
                    /*0x39c3448*/ void System.Collections.IEnumerator.Reset();
                    /*0x39c3454*/ void System.IDisposable.Dispose();
                }
            }

            class ExclusiveReference
            {
                /*0x10*/ System.Text.RegularExpressions.RegexRunner _ref;
                /*0x18*/ System.Text.RegularExpressions.RegexRunner _obj;
                /*0x20*/ int _locked;

                /*0x39c3580*/ ExclusiveReference();
                /*0x39c3458*/ System.Text.RegularExpressions.RegexRunner Get();
                /*0x39c34b4*/ void Release(System.Text.RegularExpressions.RegexRunner obj);
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

                static /*0x39c53b4*/ Regex();
                static /*0x39c3f24*/ bool TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x39c4020*/ bool TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x39c3b58*/ System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key);
                static /*0x39c4118*/ bool IsMatch(string input, string pattern);
                static /*0x39c418c*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x39c4790*/ System.Text.RegularExpressions.Match Match(string input, string pattern);
                static /*0x39c4890*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0x39c4804*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x39c49dc*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern);
                static /*0x39c4a50*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x39c4c0c*/ string Replace(string input, string pattern, string replacement);
                static /*0x39c4d1c*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options);
                static /*0x39c4c88*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x39c5024*/ string Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x39c5728*/ void ValidateMatchTimeout(System.TimeSpan matchTimeout);
                static /*0x39c54f8*/ System.TimeSpan InitDefaultMatchTimeout();
                static /*0x39c5b60*/ string Escape(string str);
                static /*0x39c5c04*/ string Unescape(string str);
                /*0x39c5880*/ Regex();
                /*0x39c58ec*/ Regex(string pattern);
                /*0x39c5964*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options);
                /*0x39c4218*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, bool addToCache);
                /*0x39c3588*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x39c36b0*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x39c3e34*/ void FillCacheDictionary();
                /*0x39c46a0*/ bool IsMatch(string input);
                /*0x39c4714*/ bool IsMatch(string input, int startat);
                /*0x39c4908*/ System.Text.RegularExpressions.Match Match(string input);
                /*0x39c4970*/ System.Text.RegularExpressions.Match Match(string input, int startat);
                /*0x39c4adc*/ System.Text.RegularExpressions.MatchCollection Matches(string input);
                /*0x39c4b44*/ System.Text.RegularExpressions.MatchCollection Matches(string input, int startat);
                /*0x39c4da4*/ string Replace(string input, string replacement);
                /*0x39c4e10*/ string Replace(string input, string replacement, int count, int startat);
                /*0x39c4ee8*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator);
                /*0x39c4f54*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat);
                /*0x39c59e0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0x39c5ca8*/ System.Text.RegularExpressions.RegexOptions get_Options();
                /*0x39c53a8*/ bool get_RightToLeft();
                /*0x39c5cb0*/ string ToString();
                /*0x39c0c3c*/ string GroupNameFromNumber(int i);
                /*0x39c07d8*/ int GroupNumberFromName(string name);
                /*0x39c5a50*/ void InitializeReferences();
                /*0x39c1ad8*/ System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat);
                /*0x39c4708*/ bool UseOptionR();
                /*0x39c5cb8*/ bool UseOptionInvariant();

                struct CachedCodeEntryKey : System.IEquatable<System.Text.RegularExpressions.Regex.CachedCodeEntryKey>
                {
                    /*0x10*/ System.Text.RegularExpressions.RegexOptions _options;
                    /*0x18*/ string _cultureKey;
                    /*0x20*/ string _pattern;

                    static /*0x39c3680*/ bool op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right);
                    /*0x39c5a18*/ CachedCodeEntryKey(System.Text.RegularExpressions.RegexOptions options, string cultureKey, string pattern);
                    /*0x39c5cc4*/ bool Equals(object obj);
                    /*0x39c5d54*/ bool Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other);
                    /*0x39c5dbc*/ int GetHashCode();
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

                    /*0x39c3d60*/ CachedCodeEntry(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref);
                }
            }

            class MatchEvaluator : System.MulticastDelegate
            {
                /*0x39c5e14*/ MatchEvaluator(object object, nint method);
                /*0x39c5f1c*/ string Invoke(System.Text.RegularExpressions.Match match);
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

                /*0x39c5f30*/ RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, System.Globalization.CultureInfo culture);
                /*0x39c6450*/ bool MatchPattern(string text, int index);
                /*0x39c6578*/ bool IsMatch(string text, int index, int beglimit, int endlimit);
                /*0x39c65e4*/ int Scan(string text, int index, int beglimit, int endlimit);
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

                static /*0x39c8a94*/ RegexCharClass();
                static /*0x39c7a2c*/ char SingletonChar(string set);
                static /*0x39c7a44*/ bool IsMergeable(string charClass);
                static /*0x39c7b60*/ bool IsEmpty(string charClass);
                static /*0x39c7c20*/ bool IsSingleton(string set);
                static /*0x39c7d2c*/ bool IsSingletonInverse(string set);
                static /*0x39c7b08*/ bool IsSubtraction(string charClass);
                static /*0x39c7ae0*/ bool IsNegated(string set);
                static /*0x39c7e3c*/ bool IsECMAWordChar(char ch);
                static /*0x39c7f10*/ bool IsWordChar(char ch);
                static /*0x39c7ea8*/ bool CharInClass(char ch, string set);
                static /*0x39c7f8c*/ bool CharInClassRecursive(char ch, string set, int start);
                static /*0x39c80ac*/ bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x39c81bc*/ bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x39c8340*/ bool CharInCategoryGroup(char ch, System.Globalization.UnicodeCategory chcategory, string category, ref int i);
                static /*0x39c7104*/ string NegateCategory(string category);
                static /*0x39c8410*/ System.Text.RegularExpressions.RegexCharClass Parse(string charClass);
                static /*0x39c8468*/ System.Text.RegularExpressions.RegexCharClass ParseRecursive(string charClass, int start);
                static /*0x39c718c*/ string SetFromProperty(string capname, bool invert, string pattern);
                /*0x39c68f0*/ RegexCharClass();
                /*0x39c69bc*/ RegexCharClass(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction);
                /*0x39c6a2c*/ bool get_CanMerge();
                /*0x39c6a4c*/ void set_Negate(bool value);
                /*0x39c6a54*/ void AddChar(char c);
                /*0x39c6b48*/ void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc);
                /*0x39c6d38*/ void AddSet(string set);
                /*0x39c6ee4*/ void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub);
                /*0x39c6a5c*/ void AddRange(char first, char last);
                /*0x39c6eec*/ void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern);
                /*0x39c73e8*/ void AddCategory(string category);
                /*0x39c7400*/ void AddLowercase(System.Globalization.CultureInfo culture);
                /*0x39c7550*/ void AddLowercaseRange(char chMin, char chMax, System.Globalization.CultureInfo culture);
                /*0x39c7780*/ void AddWord(bool ecma, bool negate);
                /*0x39c787c*/ void AddSpace(bool ecma, bool negate);
                /*0x39c7978*/ void AddDigit(bool ecma, bool negate, string pattern);
                /*0x39c6c84*/ int RangeCount();
                /*0x39c8694*/ string ToStringClass();
                /*0x39c6ccc*/ System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(int i);
                /*0x39c8838*/ void Canonicalize();

                struct LowerCaseMapping
                {
                    /*0x10*/ char ChMin;
                    /*0x12*/ char ChMax;
                    /*0x14*/ int LcOp;
                    /*0x18*/ int Data;

                    /*0x39cede8*/ LowerCaseMapping(char chMin, char chMax, int lcOp, int data);
                }

                class SingleRangeComparer : System.Collections.Generic.IComparer<System.Text.RegularExpressions.RegexCharClass.SingleRange>
                {
                    static /*0x0*/ System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer Instance;

                    static /*0x39cee44*/ SingleRangeComparer();
                    /*0x39cedf8*/ SingleRangeComparer();
                    /*0x39cee00*/ int Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y);
                }

                struct SingleRange
                {
                    /*0x10*/ char First;
                    /*0x12*/ char Last;

                    /*0x39ceeac*/ SingleRange(char first, char last);
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

                static /*0x39cefc4*/ bool OpcodeBacktracks(int Op);
                /*0x39ceeb8*/ RegexCode(int[] codes, System.Collections.Generic.List<string> stringlist, int trackcount, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft);
            }

            struct RegexFCD
            {
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack;
                /*0x18*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x38*/ bool _skipAllChildren;
                /*0x39*/ bool _skipchild;
                /*0x3a*/ bool _failed;

                static /*0x39cf0b0*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t);
                static /*0x39cf504*/ System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree);
                static /*0x39cf840*/ int Anchors(System.Text.RegularExpressions.RegexTree tree);
                static /*0x39cf9a0*/ int AnchorFromType(int type);
                /*0x39cefdc*/ RegexFCD(System.Span<int> intStack);
                /*0x39cfa40*/ void PushInt(int i);
                /*0x39cfaa0*/ bool IntIsEmpty();
                /*0x39cfae4*/ int PopInt();
                /*0x39cfbdc*/ void PushFC(System.Text.RegularExpressions.RegexFC fc);
                /*0x39cfc34*/ bool FCIsEmpty();
                /*0x39cfc84*/ System.Text.RegularExpressions.RegexFC PopFC();
                /*0x39cfd00*/ System.Text.RegularExpressions.RegexFC TopFC();
                /*0x39cf45c*/ void Dispose();
                /*0x39cf2c4*/ System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x39d0190*/ void SkipChild();
                /*0x39cfd70*/ void CalculateFC(int NodeType, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }

            class RegexFC
            {
                /*0x10*/ System.Text.RegularExpressions.RegexCharClass _cc;
                /*0x18*/ bool _nullable;
                /*0x19*/ bool <CaseInsensitive>k__BackingField;

                /*0x39d019c*/ RegexFC(bool nullable);
                /*0x39d02cc*/ RegexFC(char ch, bool not, bool nullable, bool caseInsensitive);
                /*0x39d03d0*/ RegexFC(string charClass, bool nullable, bool caseInsensitive);
                /*0x39d0220*/ bool AddFC(System.Text.RegularExpressions.RegexFC fc, bool concatenate);
                /*0x39d0474*/ bool get_CaseInsensitive();
                /*0x39d047c*/ void set_CaseInsensitive(bool value);
                /*0x39cf4a4*/ string GetFirstChars(System.Globalization.CultureInfo culture);
            }

            class RegexInterpreter : System.Text.RegularExpressions.RegexRunner
            {
                /*0x80*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x88*/ System.Globalization.CultureInfo _culture;
                /*0x90*/ int _operator;
                /*0x94*/ int _codepos;
                /*0x98*/ bool _rightToLeft;
                /*0x99*/ bool _caseInsensitive;

                /*0x39d0484*/ RegexInterpreter(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture);
                /*0x39d04d0*/ void InitTrackCount();
                /*0x39d04ec*/ void Advance(int i);
                /*0x39d0570*/ void Goto(int newpos);
                /*0x39d0630*/ void Textto(int newpos);
                /*0x39d0638*/ void Trackto(int newpos);
                /*0x39d0658*/ int Textstart();
                /*0x39d0660*/ int Textpos();
                /*0x39d0668*/ int Trackpos();
                /*0x39d0688*/ void TrackPush();
                /*0x39d06c8*/ void TrackPush(int I1);
                /*0x39d0724*/ void TrackPush(int I1, int I2);
                /*0x39d079c*/ void TrackPush(int I1, int I2, int I3);
                /*0x39d0830*/ void TrackPush2(int I1);
                /*0x39d0890*/ void TrackPush2(int I1, int I2);
                /*0x39d090c*/ void Backtrack();
                /*0x39d0550*/ void SetOperator(int op);
                /*0x39d09f4*/ void TrackPop();
                /*0x39d0a04*/ void TrackPop(int framesize);
                /*0x39d0a14*/ int TrackPeek();
                /*0x39d0a4c*/ int TrackPeek(int i);
                /*0x39d0a88*/ void StackPush(int I1);
                /*0x39d0ac4*/ void StackPush(int I1, int I2);
                /*0x39d0b1c*/ void StackPop();
                /*0x39d0b2c*/ void StackPop(int framesize);
                /*0x39d0b3c*/ int StackPeek();
                /*0x39d0b74*/ int StackPeek(int i);
                /*0x39d0bb0*/ int Operator();
                /*0x39d0bb8*/ int Operand(int i);
                /*0x39d0bfc*/ int Leftchars();
                /*0x39d0c0c*/ int Rightchars();
                /*0x39d0c1c*/ int Bump();
                /*0x39d0c30*/ int Forwardchars();
                /*0x39d0c5c*/ char Forwardcharnext();
                /*0x39d0cf4*/ bool Stringmatch(string str);
                /*0x39d0e6c*/ bool Refmatch(int index, int len);
                /*0x39d1018*/ void Backwardnext();
                /*0x39d1040*/ char CharAt(int j);
                /*0x39d1058*/ bool FindFirstChar();
                /*0x39d1518*/ void Go();
            }

            class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                /*0x90*/ string <Input>k__BackingField;
                /*0x98*/ string <Pattern>k__BackingField;
                /*0xa0*/ System.TimeSpan <MatchTimeout>k__BackingField;

                /*0x39d2ac4*/ RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout);
                /*0x39d2bd0*/ RegexMatchTimeoutException();
                /*0x39d2c74*/ RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x39d2de0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x39d2edc*/ string get_Input();
                /*0x39d2ee4*/ string get_Pattern();
                /*0x39d2eec*/ System.TimeSpan get_MatchTimeout();
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

                /*0x39d2ef4*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options);
                /*0x39d2f24*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, char ch);
                /*0x39d2f64*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, string str);
                /*0x39d2fac*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m);
                /*0x39d2fec*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m, int n);
                /*0x39d3030*/ bool UseOptionR();
                /*0x39d303c*/ System.Text.RegularExpressions.RegexNode ReverseLeft();
                /*0x39d30b8*/ void MakeRep(int type, int min, int max);
                /*0x39d30d0*/ System.Text.RegularExpressions.RegexNode Reduce();
                /*0x39d3bf4*/ System.Text.RegularExpressions.RegexNode StripEnation(int emptyType);
                /*0x39d3a78*/ System.Text.RegularExpressions.RegexNode ReduceGroup();
                /*0x39d38f0*/ System.Text.RegularExpressions.RegexNode ReduceRep();
                /*0x39d3aa4*/ System.Text.RegularExpressions.RegexNode ReduceSet();
                /*0x39d3130*/ System.Text.RegularExpressions.RegexNode ReduceAlternation();
                /*0x39d3534*/ System.Text.RegularExpressions.RegexNode ReduceConcatenation();
                /*0x39d3ca8*/ System.Text.RegularExpressions.RegexNode MakeQuantifier(bool lazy, int min, int max);
                /*0x39d3dbc*/ void AddChild(System.Text.RegularExpressions.RegexNode newChild);
                /*0x39cf7d4*/ System.Text.RegularExpressions.RegexNode Child(int i);
                /*0x39cf788*/ int ChildCount();
                /*0x39d3ea0*/ int Type();
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

                static /*0x39d9e10*/ RegexParser();
                static /*0x39d3ea8*/ System.Text.RegularExpressions.RegexTree Parse(string re, System.Text.RegularExpressions.RegexOptions op);
                static /*0x39d4dd8*/ System.Text.RegularExpressions.RegexReplacement ParseReplacement(string rep, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op);
                static /*0x39d5478*/ string Escape(string input);
                static /*0x39d56f4*/ string Unescape(string input);
                static /*0x39d93f8*/ int HexDigit(char ch);
                static /*0x39d94ec*/ System.Text.RegularExpressions.RegexOptions OptionFromCode(char ch);
                static /*0x39d60dc*/ bool IsSpecial(char ch);
                static /*0x39d5ea8*/ bool IsStopperX(char ch);
                static /*0x39d6174*/ bool IsQuantifier(char ch);
                static /*0x39d8b50*/ bool IsSpace(char ch);
                static /*0x39d565c*/ bool IsMetachar(char ch);
                /*0x39d4044*/ RegexParser(System.Globalization.CultureInfo culture);
                /*0x39d4120*/ void SetPattern(string Re);
                /*0x39d44a0*/ void Reset(System.Text.RegularExpressions.RegexOptions topopts);
                /*0x39d4534*/ System.Text.RegularExpressions.RegexNode ScanRegex();
                /*0x39d4f6c*/ System.Text.RegularExpressions.RegexNode ScanReplacement();
                /*0x39d64f4*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly);
                /*0x39d6c9c*/ System.Text.RegularExpressions.RegexNode ScanGroupOpen();
                /*0x39d5b70*/ void ScanBlank();
                /*0x39d7ae8*/ System.Text.RegularExpressions.RegexNode ScanBackslash(bool scanOnly);
                /*0x39d8c78*/ System.Text.RegularExpressions.RegexNode ScanBasicBackslash(bool scanOnly);
                /*0x39d82d0*/ System.Text.RegularExpressions.RegexNode ScanDollar();
                /*0x39d887c*/ string ScanCapname();
                /*0x39d9228*/ char ScanOctal();
                /*0x39d81b8*/ int ScanDecimal();
                /*0x39d92c4*/ char ScanHex(int c);
                /*0x39d942c*/ char ScanControl();
                /*0x39d94c8*/ bool IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option);
                /*0x39d8a58*/ void ScanOptions();
                /*0x39d58c0*/ char ScanCharEscape();
                /*0x39d870c*/ string ParseProperty();
                /*0x39d8be8*/ int TypeFromCode(char ch);
                /*0x39d4158*/ void CountCaptures();
                /*0x39d954c*/ void NoteCaptureSlot(int i, int pos);
                /*0x39d9680*/ void NoteCaptureName(string name, int pos);
                /*0x39d4f34*/ void NoteCaptures(System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames);
                /*0x39d97dc*/ void AssignNameSlots();
                /*0x39d8a00*/ int CaptureSlotFromName(string capname);
                /*0x39d8978*/ bool IsCaptureSlot(int i);
                /*0x39d89e4*/ bool IsCaptureName(string capname);
                /*0x39d896c*/ bool UseOptionN();
                /*0x39d64e8*/ bool UseOptionI();
                /*0x39d8000*/ bool UseOptionM();
                /*0x39d8084*/ bool UseOptionS();
                /*0x39d5e4c*/ bool UseOptionX();
                /*0x39d8700*/ bool UseOptionE();
                /*0x39d5f40*/ bool IsTrueQuantifier();
                /*0x39d620c*/ void AddConcatenate(int pos, int cch, bool isReplacement);
                /*0x39d75fc*/ void PushGroup();
                /*0x39d7910*/ void PopGroup();
                /*0x39d7724*/ bool EmptyStack();
                /*0x39d5ab0*/ void StartGroup(System.Text.RegularExpressions.RegexNode openGroup);
                /*0x39d7658*/ void AddAlternate();
                /*0x39d8160*/ void AddConcatenate();
                /*0x39d8284*/ void AddConcatenate(bool lazy, int min, int max);
                /*0x39d9df0*/ System.Text.RegularExpressions.RegexNode Unit();
                /*0x39d6428*/ void AddUnitOne(char ch);
                /*0x39d8090*/ void AddUnitNotone(char ch);
                /*0x39d6bb0*/ void AddUnitSet(string cc);
                /*0x39d9df8*/ void AddUnitNode(System.Text.RegularExpressions.RegexNode node);
                /*0x39d800c*/ void AddUnitType(int type);
                /*0x39d77cc*/ void AddGroup();
                /*0x39d6c3c*/ void PushOptions();
                /*0x39d7a48*/ void PopOptions();
                /*0x39d9630*/ bool EmptyOptionsStack();
                /*0x39d7598*/ void PopKeepOptions();
                /*0x39d7734*/ System.ArgumentException MakeException(string message);
                /*0x39d9e00*/ int Textpos();
                /*0x39d9e08*/ void Textto(int pos);
                /*0x39d8190*/ char RightCharMoveRight();
                /*0x39d5e58*/ void MoveRight();
                /*0x39d895c*/ void MoveRight(int i);
                /*0x39d8150*/ void MoveLeft();
                /*0x39d6410*/ char CharAt(int i);
                /*0x39d5e88*/ char RightChar();
                /*0x39d8938*/ char RightChar(int i);
                /*0x39d5e68*/ int CharsRight();
            }

            struct RegexPrefix
            {
                static /*0x0*/ System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;
                /*0x10*/ bool <CaseInsensitive>k__BackingField;
                /*0x18*/ string <Prefix>k__BackingField;

                static /*0x39d9f18*/ RegexPrefix();
                static /*0x39d9eb8*/ System.Text.RegularExpressions.RegexPrefix get_Empty();
                /*0x39cf4dc*/ RegexPrefix(string prefix, bool ci);
                /*0x39d9eb0*/ bool get_CaseInsensitive();
                /*0x39d9f10*/ string get_Prefix();
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

                static /*0x39d9fa8*/ System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions roptions);
                /*0x39d50b0*/ RegexReplacement(string rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps);
                /*0x39da0bc*/ string get_Pattern();
                /*0x39da0c4*/ void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match);
                /*0x39da274*/ void ReplacementImplRTL(System.Collections.Generic.List<string> al, System.Text.RegularExpressions.Match match);
                /*0x39da450*/ string Replace(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
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

                /*0x39d04c8*/ RegexRunner();
                /*0x39da794*/ System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout);
                /*0x39daae4*/ void StartTimeoutWatch();
                /*0x39d26a4*/ void CheckTimeout();
                /*0x39dad98*/ void DoCheckTimeout();
                /*0x1f309e4*/ void Go();
                /*0x1f2fe14*/ bool FindFirstChar();
                /*0x1f309e4*/ void InitTrackCount();
                /*0x39dab1c*/ void InitMatch();
                /*0x39dad40*/ System.Text.RegularExpressions.Match TidyMatch(bool quick);
                /*0x39d05e8*/ void EnsureStorage();
                /*0x39d288c*/ bool IsBoundary(int index, int startpos, int endpos);
                /*0x39d298c*/ bool IsECMABoundary(int index, int startpos, int endpos);
                /*0x39daf10*/ void DoubleTrack();
                /*0x39dae64*/ void DoubleStack();
                /*0x39dafbc*/ void DoubleCrawl();
                /*0x39db068*/ void Crawl(int i);
                /*0x39db0c4*/ int Popcrawl();
                /*0x39d286c*/ int Crawlpos();
                /*0x39d27e4*/ void Capture(int capnum, int start, int end);
                /*0x39d26d0*/ void TransferCapture(int capnum, int uncapnum, int start, int end);
                /*0x39d283c*/ void Uncapture();
                /*0x39d26b4*/ bool IsMatched(int cap);
                /*0x39d2a8c*/ int MatchIndex(int cap);
                /*0x39d2aa8*/ int MatchLength(int cap);
            }

            class RegexRunnerFactory
            {
                /*0x39db100*/ RegexRunnerFactory();
                /*0x1f30214*/ System.Text.RegularExpressions.RegexRunner CreateInstance();
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

                /*0x39d4d2c*/ RegexTree(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, int[] capNumList, int capTop, System.Collections.Hashtable capNames, string[] capsList, System.Text.RegularExpressions.RegexOptions options);
            }

            struct RegexWriter
            {
                /*0x10*/ System.Collections.Generic.ValueListBuilder<int> _emitted;
                /*0x30*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x50*/ System.Collections.Generic.Dictionary<string, int> _stringHash;
                /*0x58*/ System.Collections.Generic.List<string> _stringTable;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ int _trackCount;

                static /*0x39db24c*/ System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree);
                /*0x39db108*/ RegexWriter(System.Span<int> emittedSpan, System.Span<int> intStackSpan);
                /*0x39db8e0*/ void Dispose();
                /*0x39db420*/ System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x39dc1e0*/ void PatchJump(int offset, int jumpDest);
                /*0x39dc244*/ void Emit(int op);
                /*0x39db934*/ void Emit(int op, int opd1);
                /*0x39dc2bc*/ void Emit(int op, int opd1, int opd2);
                /*0x39dc36c*/ int StringCode(string str);
                /*0x39dc46c*/ int MapCapnum(int capnum);
                /*0x39db9c4*/ void EmitFragment(int nodetype, System.Text.RegularExpressions.RegexNode node, int curIndex);
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

                /*0x39dc7ec*/ GeneratedCodeAttribute(string tool, string version);
            }
        }
    }

    namespace Diagnostics
    {
        class BooleanSwitch : System.Diagnostics.Switch
        {
            /*0x39dc830*/ BooleanSwitch(string displayName, string description);
        }

        class Switch
        {
            static /*0x0*/ System.Collections.Generic.List<System.WeakReference> switches;
            static /*0x8*/ int s_LastCollectionCount;
            /*0x10*/ string description;
            /*0x18*/ string displayName;
            /*0x20*/ string switchValueString;
            /*0x28*/ string defaultValue;

            static /*0x39dcfcc*/ Switch();
            static /*0x39dcb18*/ void _pruneCachedSwitches();
            /*0x39dc89c*/ Switch(string displayName, string description);
            /*0x39dc8fc*/ Switch(string displayName, string description, string defaultSwitchValue);
        }

        class SwitchLevelAttribute : System.Attribute
        {
            /*0x10*/ System.Type type;

            /*0x39dd064*/ SwitchLevelAttribute(System.Type switchLevelType);
            /*0x39dd090*/ void set_SwitchLevelType(System.Type value);
        }

        enum TraceLevel
        {
            Off = 0,
            Error = 1,
            Warning = 2,
            Info = 3,
            Verbose = 4,
        }

        class TraceSwitch : System.Diagnostics.Switch
        {
            /*0x39dd130*/ TraceSwitch(string displayName, string description);
        }

        class UserCallBack : System.MulticastDelegate
        {
            /*0x39dd19c*/ UserCallBack(object object, nint method);
            /*0x39dd24c*/ void Invoke(string data);
        }

        class AsyncStreamReader : System.IDisposable
        {
            /*0x10*/ System.IO.Stream stream;
            /*0x18*/ System.Text.Encoding encoding;
            /*0x20*/ System.Text.Decoder decoder;
            /*0x28*/ byte[] byteBuffer;
            /*0x30*/ char[] charBuffer;
            /*0x38*/ int _maxCharsPerBuffer;
            /*0x40*/ System.Diagnostics.Process process;
            /*0x48*/ System.Diagnostics.UserCallBack userCallBack;
            /*0x50*/ bool cancelOperation;
            /*0x58*/ System.Threading.ManualResetEvent eofEvent;
            /*0x60*/ System.Collections.Queue messageQueue;
            /*0x68*/ System.Text.StringBuilder sb;
            /*0x70*/ bool bLastCarriageReturn;
            /*0x74*/ int currentLinePos;
            /*0x78*/ object syncObject;
            /*0x80*/ System.IAsyncResult asyncReadResult;

            /*0x39dd260*/ AsyncStreamReader(System.Diagnostics.Process process, System.IO.Stream stream, System.Diagnostics.UserCallBack callback, System.Text.Encoding encoding);
            /*0x39dd268*/ AsyncStreamReader(System.Diagnostics.Process process, System.IO.Stream stream, System.Diagnostics.UserCallBack callback, System.Text.Encoding encoding, int bufferSize);
            /*0x39dd354*/ void Init(System.Diagnostics.Process process, System.IO.Stream stream, System.Diagnostics.UserCallBack callback, System.Text.Encoding encoding, int bufferSize);
            /*0x39dd4ec*/ void Close();
            /*0x39dd4fc*/ void System.IDisposable.Dispose();
            /*0x39dd568*/ void Dispose(bool disposing);
            /*0x39dd930*/ void BeginReadLine();
            /*0x39ddc00*/ void CancelOperation();
            /*0x39ddc0c*/ void ReadBuffer(System.IAsyncResult ar);
            /*0x39de230*/ void GetLinesFromStringBuilder();
            /*0x39dda58*/ void FlushMessageQueue();
            /*0x39de4b4*/ void WaitUtilEOF();
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
            /*0x70*/ System.Diagnostics.ProcessStartInfo startInfo;
            /*0x78*/ bool watchForExit;
            /*0x79*/ bool watchingForExit;
            /*0x80*/ System.EventHandler onExited;
            /*0x88*/ bool exited;
            /*0x8c*/ int exitCode;
            /*0x90*/ bool signaled;
            /*0x91*/ bool haveExitTime;
            /*0x92*/ bool raisedOnExited;
            /*0x98*/ System.Threading.RegisteredWaitHandle registeredWaitHandle;
            /*0xa0*/ System.Threading.WaitHandle waitHandle;
            /*0xa8*/ System.ComponentModel.ISynchronizeInvoke synchronizingObject;
            /*0xb0*/ System.IO.StreamReader standardOutput;
            /*0xb8*/ System.IO.StreamWriter standardInput;
            /*0xc0*/ System.IO.StreamReader standardError;
            /*0xc8*/ bool disposed;
            /*0xcc*/ System.Diagnostics.Process.StreamReadMode outputStreamReadMode;
            /*0xd0*/ System.Diagnostics.Process.StreamReadMode errorStreamReadMode;
            /*0xd4*/ System.Diagnostics.Process.StreamReadMode inputStreamReadMode;
            /*0xd8*/ System.Diagnostics.DataReceivedEventHandler OutputDataReceived;
            /*0xe0*/ System.Diagnostics.DataReceivedEventHandler ErrorDataReceived;
            /*0xe8*/ System.Diagnostics.AsyncStreamReader output;
            /*0xf0*/ System.Diagnostics.AsyncStreamReader error;
            /*0xf8*/ bool pendingOutputRead;
            /*0xf9*/ bool pendingErrorRead;
            /*0x100*/ string process_name;

            static /*0x39df9f0*/ System.Diagnostics.Process GetCurrentProcess();
            static /*0x39e1114*/ System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo startInfo);
            static /*0x39e1f8c*/ string ProcessName_icall(nint handle);
            static /*0x39e1f90*/ string ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            static /*0x39e2070*/ bool ShellExecuteEx_internal(System.Diagnostics.ProcessStartInfo startInfo, ref System.Diagnostics.Process.ProcInfo procInfo);
            static /*0x39e2074*/ bool CreateProcess_internal(System.Diagnostics.ProcessStartInfo startInfo, nint stdin, nint stdout, nint stderr, ref System.Diagnostics.Process.ProcInfo procInfo);
            static /*0x39e217c*/ void CreatePipe(ref nint read, ref nint write, bool writeDirection);
            static /*0x39e2324*/ bool get_IsWindows();
            static /*0x39e209c*/ void FillUserInfo(System.Diagnostics.ProcessStartInfo startInfo, ref System.Diagnostics.Process.ProcInfo procInfo);
            /*0x39de778*/ Process();
            /*0x39de808*/ Process(string machineName, bool isRemoteMachine, int processId, System.Diagnostics.ProcessInfo processInfo);
            /*0x39de508*/ void add_OutputDataReceived(System.Diagnostics.DataReceivedEventHandler value);
            /*0x39de5a4*/ void remove_OutputDataReceived(System.Diagnostics.DataReceivedEventHandler value);
            /*0x39de640*/ void add_ErrorDataReceived(System.Diagnostics.DataReceivedEventHandler value);
            /*0x39de6dc*/ void remove_ErrorDataReceived(System.Diagnostics.DataReceivedEventHandler value);
            /*0x39de8b4*/ bool get_Associated();
            /*0x39de8d4*/ bool get_HasExited();
            /*0x39df0a4*/ nint get_Handle();
            /*0x39df178*/ System.Diagnostics.ProcessStartInfo get_StartInfo();
            /*0x39df270*/ void set_StartInfo(System.Diagnostics.ProcessStartInfo value);
            /*0x39df2c8*/ System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject();
            /*0x39df46c*/ void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0x39df494*/ void CompletionCallback(object context, bool wasSignaled);
            /*0x39df5d8*/ void Dispose(bool disposing);
            /*0x39df620*/ void Close();
            /*0x39deb78*/ void EnsureState(System.Diagnostics.Process.State state);
            /*0x39df82c*/ void EnsureWatchingForExit();
            /*0x39dfa70*/ void OnExited();
            /*0x39deca0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access, bool throwIfExited);
            /*0x39dfcc4*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access);
            /*0x39df0d4*/ Microsoft.Win32.SafeHandles.SafeProcessHandle OpenProcessHandle(int access);
            /*0x39df7f4*/ void Refresh();
            /*0x39dfccc*/ void SetProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle);
            /*0x39dfd14*/ void SetProcessId(int processId);
            /*0x39dfd24*/ bool Start();
            /*0x39df4ac*/ void StopWatchingForExit();
            /*0x39e11d4*/ string ToString();
            /*0x39e1574*/ bool WaitForExit(int milliseconds);
            /*0x39e1740*/ void WaitForExit();
            /*0x39e1748*/ void BeginOutputReadLine();
            /*0x39e18f4*/ void BeginErrorReadLine();
            /*0x39e1aa0*/ void OutputReadNotifyUser(string data);
            /*0x39e1d50*/ void ErrorReadNotifyUser(string data);
            /*0x39e1334*/ string get_ProcessName();
            /*0x39dfe14*/ bool StartWithShellExecuteEx(System.Diagnostics.ProcessStartInfo startInfo);
            /*0x39e0120*/ bool StartWithCreateProcess(System.Diagnostics.ProcessStartInfo startInfo);
            /*0x39defc4*/ void RaiseOnExited();

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

            struct ProcInfo
            {
                /*0x10*/ nint process_handle;
                /*0x18*/ int pid;
                /*0x20*/ string[] envVariables;
                /*0x28*/ string UserName;
                /*0x30*/ string Domain;
                /*0x38*/ nint Password;
                /*0x40*/ bool LoadUserProfile;
            }
        }

        class ProcessInfo
        {
        }

        class ProcessModuleCollection : System.Collections.ReadOnlyCollectionBase
        {
        }

        class ProcessStartInfo
        {
            static /*0x0*/ string[] empty;
            /*0x10*/ string fileName;
            /*0x18*/ string arguments;
            /*0x20*/ string directory;
            /*0x28*/ string verb;
            /*0x30*/ System.Diagnostics.ProcessWindowStyle windowStyle;
            /*0x34*/ bool errorDialog;
            /*0x38*/ nint errorDialogParentHandle;
            /*0x40*/ bool useShellExecute;
            /*0x48*/ string userName;
            /*0x50*/ string domain;
            /*0x58*/ System.Security.SecureString password;
            /*0x60*/ string passwordInClearText;
            /*0x68*/ bool loadUserProfile;
            /*0x69*/ bool redirectStandardInput;
            /*0x6a*/ bool redirectStandardOutput;
            /*0x6b*/ bool redirectStandardError;
            /*0x70*/ System.Text.Encoding standardOutputEncoding;
            /*0x78*/ System.Text.Encoding standardErrorEncoding;
            /*0x80*/ bool createNoWindow;
            /*0x88*/ System.WeakReference weakParentProcess;
            /*0x90*/ System.Collections.Specialized.StringDictionary environmentVariables;
            /*0x98*/ System.Collections.ObjectModel.Collection<string> _argumentList;
            /*0xa0*/ System.Collections.Generic.IDictionary<string, string> environment;
            /*0xa8*/ System.Text.Encoding <StandardInputEncoding>k__BackingField;

            static /*0x39e29e0*/ ProcessStartInfo();
            /*0x39df1ec*/ ProcessStartInfo(System.Diagnostics.Process parent);
            /*0x39e2928*/ ProcessStartInfo(string fileName);
            /*0x39e2838*/ System.Collections.ObjectModel.Collection<string> get_ArgumentList();
            /*0x39e28bc*/ string get_Arguments();
            /*0x39e2960*/ void set_Arguments(string value);
            /*0x39e2968*/ void set_CreateNoWindow(bool value);
            /*0x39e235c*/ System.Collections.Specialized.StringDictionary get_EnvironmentVariables();
            /*0x39e2970*/ bool get_RedirectStandardInput();
            /*0x39e2978*/ void set_RedirectStandardInput(bool value);
            /*0x39e2980*/ bool get_RedirectStandardOutput();
            /*0x39e2988*/ void set_RedirectStandardOutput(bool value);
            /*0x39e2990*/ bool get_RedirectStandardError();
            /*0x39e2998*/ void set_RedirectStandardError(bool value);
            /*0x39e29a0*/ System.Text.Encoding get_StandardErrorEncoding();
            /*0x39e29a8*/ System.Text.Encoding get_StandardOutputEncoding();
            /*0x39e29b0*/ bool get_UseShellExecute();
            /*0x39e29b8*/ void set_UseShellExecute(bool value);
            /*0x39e2078*/ string get_UserName();
            /*0x39e29c0*/ System.Security.SecureString get_Password();
            /*0x39e2904*/ string get_Domain();
            /*0x39e29c8*/ bool get_LoadUserProfile();
            /*0x39dfdf0*/ string get_FileName();
            /*0x39e28e0*/ string get_WorkingDirectory();
            /*0x39e29d0*/ void set_WorkingDirectory(string value);
            /*0x39e234c*/ bool get_HaveEnvVars();
            /*0x39e29d8*/ System.Text.Encoding get_StandardInputEncoding();
        }

        class ProcessThreadCollection : System.Collections.ReadOnlyCollectionBase
        {
        }

        class ProcessWaitHandle : System.Threading.WaitHandle
        {
            /*0x39def6c*/ ProcessWaitHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle);
        }

        class DataReceivedEventArgs : System.EventArgs
        {
            /*0x10*/ string data;

            /*0x39e1cdc*/ DataReceivedEventArgs(string data);
            /*0x39e2a54*/ string get_Data();
        }

        class DataReceivedEventHandler : System.MulticastDelegate
        {
            /*0x39e2a5c*/ DataReceivedEventHandler(object object, nint method);
            /*0x39e2b68*/ void Invoke(object sender, System.Diagnostics.DataReceivedEventArgs e);
        }

        class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute
        {
            /*0x39e2b7c*/ MonitoringDescriptionAttribute(string description);
            /*0x39e2be4*/ string get_Description();
        }

        enum ProcessWindowStyle
        {
            Hidden = 1,
            Maximized = 3,
            Minimized = 2,
            Normal = 0,
        }

        class Stopwatch
        {
            static /*0x0*/ long Frequency;
            static /*0x8*/ bool IsHighResolution;
            /*0x10*/ long elapsed;
            /*0x18*/ long started;
            /*0x20*/ bool is_running;

            static /*0x39e2f70*/ Stopwatch();
            static /*0x39e2bec*/ long GetTimestamp();
            static /*0x39e2bf0*/ System.Diagnostics.Stopwatch StartNew();
            /*0x39e2c54*/ Stopwatch();
            /*0x39e2cc4*/ System.TimeSpan get_Elapsed();
            /*0x39e2e2c*/ long get_ElapsedMilliseconds();
            /*0x39e2dbc*/ long get_ElapsedTicks();
            /*0x39e2c5c*/ void Start();
        }

        namespace CodeAnalysis
        {
            class ExcludeFromCodeCoverageAttribute : System.Attribute
            {
                /*0x39e2fc8*/ ExcludeFromCodeCoverageAttribute();
            }
        }
    }

    namespace Security
    {
        namespace Authentication
        {
            class AuthenticationException : System.SystemException
            {
                /*0x39e2fd0*/ AuthenticationException();
                /*0x39e3028*/ AuthenticationException(string message, System.Exception innerException);
                /*0x39e3030*/ AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

                static /*0x39e3be4*/ string TrimTrailingNulls(string value);
                static /*0x39e3d20*/ void CheckTag(System.Security.Cryptography.DerSequenceReader.DerTag expected, byte[] data, int position);
                static /*0x39e33dc*/ int ScanContentLength(byte[] data, int offset, int end, ref int bytesConsumed);
                /*0x39e3040*/ DerSequenceReader(byte[] data);
                /*0x39e3060*/ DerSequenceReader(byte[] data, int offset, int length);
                /*0x39e3074*/ DerSequenceReader(System.Security.Cryptography.DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length);
                /*0x39e3038*/ void set_ContentLength(int value);
                /*0x39e3230*/ bool get_HasData();
                /*0x39e3240*/ byte PeekTag();
                /*0x39e32d4*/ void SkipValue();
                /*0x39e3328*/ byte[] ReadNextEncodedValue();
                /*0x39e34fc*/ bool ReadBoolean();
                /*0x39e35c4*/ int ReadInteger();
                /*0x39e3678*/ byte[] ReadIntegerBytes();
                /*0x39e3744*/ byte[] ReadBitString();
                /*0x39e3888*/ byte[] ReadOctetString();
                /*0x39e38a4*/ string ReadOidAsString();
                /*0x39e3b64*/ string ReadUtf8String();
                /*0x39e3c60*/ System.Security.Cryptography.DerSequenceReader ReadCollectionWithTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x39e3db8*/ System.Security.Cryptography.DerSequenceReader ReadSequence();
                /*0x39e3dc0*/ System.Security.Cryptography.DerSequenceReader ReadSet();
                /*0x39e3dc8*/ string ReadPrintableString();
                /*0x39e3e48*/ string ReadIA5String();
                /*0x39e3ec8*/ string ReadT61String();
                /*0x39e41a0*/ System.DateTime ReadX509Date();
                /*0x39e4220*/ System.DateTime ReadUtcTime();
                /*0x39e426c*/ System.DateTime ReadGeneralizedTime();
                /*0x39e44f8*/ string ReadBMPString();
                /*0x39e42b8*/ System.DateTime ReadTime(System.Security.Cryptography.DerSequenceReader.DerTag timeTag, string formatString);
                /*0x39e3694*/ byte[] ReadContentAsBytes();
                /*0x39e3174*/ void EatTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x39e31f4*/ int EatLength();

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

                    static /*0x39e4578*/ <>c();
                    /*0x39e45e0*/ <>c();
                    /*0x39e45e8*/ System.Text.Encoding <ReadT61String>b__45_0();
                    /*0x39e4644*/ System.Text.Encoding <ReadT61String>b__45_1();
                    /*0x39e4688*/ System.Globalization.DateTimeFormatInfo <ReadTime>b__51_0();
                }
            }

            class Oid
            {
                /*0x10*/ string _value;
                /*0x18*/ string _friendlyName;
                /*0x20*/ System.Security.Cryptography.OidGroup _group;

                static /*0x39e48cc*/ System.Security.Cryptography.Oid FromOidValue(string oidValue, System.Security.Cryptography.OidGroup group);
                /*0x39e4754*/ Oid();
                /*0x39e475c*/ Oid(string oid);
                /*0x39e47f0*/ Oid(string value, string friendlyName);
                /*0x39e4834*/ Oid(System.Security.Cryptography.Oid oid);
                /*0x39e49f8*/ Oid(string value, string friendlyName, System.Security.Cryptography.OidGroup group);
                /*0x39e4a50*/ string get_Value();
                /*0x39e4a58*/ void set_Value(string value);
                /*0x39e4a60*/ string get_FriendlyName();
            }

            class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.Oid> _list;

                /*0x39e4af8*/ OidCollection();
                /*0x39e4b80*/ int Add(System.Security.Cryptography.Oid oid);
                /*0x39e4bf0*/ System.Security.Cryptography.Oid get_Item(int index);
                /*0x39e4c5c*/ int get_Count();
                /*0x39e4ca4*/ System.Security.Cryptography.OidEnumerator GetEnumerator();
                /*0x39e4d50*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x39e4d54*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x39e4efc*/ bool get_IsSynchronized();
                /*0x39e4f04*/ object get_SyncRoot();
            }

            class OidEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Security.Cryptography.OidCollection _oids;
                /*0x18*/ int _current;

                /*0x39e4d14*/ OidEnumerator(System.Security.Cryptography.OidCollection oids);
                /*0x39e4f08*/ System.Security.Cryptography.Oid get_Current();
                /*0x39e4f24*/ object System.Collections.IEnumerator.get_Current();
                /*0x39e4f28*/ bool MoveNext();
                /*0x39e4f74*/ void Reset();
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

                /*0x39e4f80*/ AsnEncodedData();
                /*0x39e4f88*/ AsnEncodedData(string oid, byte[] rawData);
                /*0x39e5104*/ AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData);
                /*0x39e51b8*/ AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x39e528c*/ System.Security.Cryptography.Oid get_Oid();
                /*0x39e5140*/ void set_Oid(System.Security.Cryptography.Oid value);
                /*0x39e5294*/ byte[] get_RawData();
                /*0x39e5010*/ void set_RawData(byte[] value);
                /*0x39e529c*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x39e536c*/ string Format(bool multiLine);
                /*0x39e54c4*/ string ToString(bool multiLine);
                /*0x39e53ac*/ string Default(bool multiLine);
                /*0x39e5674*/ string BasicConstraintsExtension(bool multiLine);
                /*0x39e5778*/ string EnhancedKeyUsageExtension(bool multiLine);
                /*0x39e587c*/ string KeyUsageExtension(bool multiLine);
                /*0x39e5984*/ string SubjectKeyIdentifierExtension(bool multiLine);
                /*0x39e5a8c*/ string SubjectAltName(bool multiLine);
                /*0x39e5e60*/ string NetscapeCertType(bool multiLine);
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

                    static /*0x39e7064*/ PublicKey();
                    static /*0x39e6fd0*/ byte[] GetUnsignedBigInteger(byte[] integer);
                    static /*0x39e6af0*/ System.Security.Cryptography.DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters);
                    static /*0x39e6738*/ System.Security.Cryptography.RSA DecodeRSA(byte[] rawPublicKey);
                    /*0x39e640c*/ PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue);
                    /*0x39e6584*/ System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue();
                    /*0x39e658c*/ System.Security.Cryptography.AsnEncodedData get_EncodedParameters();
                    /*0x39e6594*/ System.Security.Cryptography.AsymmetricAlgorithm get_Key();
                    /*0x39e6fc8*/ System.Security.Cryptography.Oid get_Oid();
                }

                class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ string name;
                    /*0x28*/ byte[] canonEncoding;

                    static /*0x39e7404*/ string GetSeparator(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    static /*0x39e74d8*/ string Canonize(string s);
                    static /*0x39e76a8*/ bool AreEqual(System.Security.Cryptography.X509Certificates.X500DistinguishedName name1, System.Security.Cryptography.X509Certificates.X500DistinguishedName name2);
                    /*0x39e70d8*/ X500DistinguishedName(byte[] encodedDistinguishedName);
                    /*0x39e72b8*/ string get_Name();
                    /*0x39e72c0*/ string Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    /*0x39e747c*/ string Format(bool multiLine);
                    /*0x39e71d4*/ void DecodeRawData();
                }

                class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.19";
                    static string friendlyName = "Basic Constraints";
                    /*0x21*/ bool _certificateAuthority;
                    /*0x22*/ bool _hasPathLengthConstraint;
                    /*0x24*/ int _pathLengthConstraint;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x39e787c*/ X509BasicConstraintsExtension();
                    /*0x39e623c*/ X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical);
                    /*0x39e7af4*/ X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical);
                    /*0x39e7d88*/ bool get_CertificateAuthority();
                    /*0x39e7dec*/ bool get_HasPathLengthConstraint();
                    /*0x39e7e50*/ int get_PathLengthConstraint();
                    /*0x39e7eb4*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x39e7924*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x39e7c2c*/ byte[] Encode();
                    /*0x39e8080*/ string ToString(bool multiLine);
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

                    static /*0x39e9278*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
                    static /*0x39e8afc*/ System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid);
                    /*0x39e8498*/ X509Certificate2();
                    /*0x39e84a0*/ X509Certificate2(byte[] rawData);
                    /*0x39e8620*/ X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
                    /*0x39e8628*/ X509Certificate2(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x39e83ec*/ void Reset();
                    /*0x39e8668*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection get_Extensions();
                    /*0x39e8d38*/ bool get_HasPrivateKey();
                    /*0x39e8d6c*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x39e8ed0*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x39e8f3c*/ System.DateTime get_NotAfter();
                    /*0x39e8f44*/ System.DateTime get_NotBefore();
                    /*0x39e8f4c*/ System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    /*0x39e90a4*/ byte[] get_RawData();
                    /*0x39e9110*/ string get_SerialNumber();
                    /*0x39e9120*/ System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    /*0x39e9194*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x39e9200*/ string get_Thumbprint();
                    /*0x39e921c*/ int get_Version();
                    /*0x39e9310*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x39e934c*/ string ToString();
                    /*0x39e9358*/ string ToString(bool verbose);
                    /*0x39ea290*/ bool Verify();
                    /*0x39e8a70*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl();
                }

                class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection
                {
                    static /*0x0*/ string[] newline_split;

                    static /*0x39ebe34*/ X509Certificate2Collection();
                    /*0x39ea35c*/ X509Certificate2Collection();
                    /*0x39ea36c*/ X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x39ea408*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Item(int index);
                    /*0x39ea52c*/ int Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39ea398*/ void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x39ea59c*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39ea8b0*/ string GetKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 x);
                    /*0x39eacd0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, bool validOnly);
                    /*0x39ebd20*/ System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator();
                }

                class X509Certificate2Enumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x39ebd78*/ X509Certificate2Enumerator(System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection);
                    /*0x39ebed8*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Current();
                    /*0x39ebfc8*/ bool MoveNext();
                    /*0x39ec068*/ object System.Collections.IEnumerator.get_Current();
                    /*0x39ec10c*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x39ec1ac*/ void System.Collections.IEnumerator.Reset();
                }

                class X509Certificate2Impl : System.Security.Cryptography.X509Certificates.X509CertificateImpl
                {
                    /*0x39ec250*/ X509Certificate2Impl();
                    /*0x1f30214*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x1f30214*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x1f30ebc*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0x1f30214*/ string get_SignatureAlgorithm();
                    /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x1f2ffc8*/ int get_Version();
                    /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x1f2fec8*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0x1f30ebc*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509Certificate2ImplMono : System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix
                {
                    static /*0x0*/ string empty_error;
                    static /*0x8*/ byte[] signedData;
                    /*0xb0*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;
                    /*0xb8*/ Mono.Security.X509.X509Certificate _cert;

                    static /*0x39ed628*/ X509Certificate2ImplMono();
                    /*0x39ec268*/ X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert);
                    /*0x39ec2a0*/ X509Certificate2ImplMono(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other);
                    /*0x39ec358*/ X509Certificate2ImplMono(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x39ec258*/ bool get_IsValid();
                    /*0x39ec52c*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone();
                    /*0x39ec590*/ Mono.Security.X509.X509Certificate get_Cert();
                    /*0x39ec5ac*/ byte[] GetRawCertData();
                    /*0x39ec5e4*/ bool get_HasPrivateKey();
                    /*0x39ec608*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x39eca24*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0x39ecbac*/ System.Security.Cryptography.RSA GetRSAPrivateKey();
                    /*0x39ecc38*/ System.Security.Cryptography.DSA GetDSAPrivateKey();
                    /*0x39ec4d4*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password);
                    /*0x39eccc4*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password);
                    /*0x39ed4f8*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0x39ed618*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    /*0x39ed620*/ Mono.Security.X509.X509Certificate get_MonoCertificate();
                }

                class X509Certificate2ImplUnix : System.Security.Cryptography.X509Certificates.X509Certificate2Impl
                {
                    /*0x10*/ bool readCertData;
                    /*0x18*/ Internal.Cryptography.Pal.CertificateData certData;

                    /*0x39ec298*/ X509Certificate2ImplUnix();
                    /*0x39ed6fc*/ void EnsureCertData();
                    /*0x1f30214*/ byte[] GetRawCertData();
                    /*0x39ed78c*/ string get_KeyAlgorithm();
                    /*0x39ed7a4*/ byte[] get_KeyAlgorithmParameters();
                    /*0x39ed7bc*/ byte[] get_PublicKeyValue();
                    /*0x39ed7d4*/ byte[] get_SerialNumber();
                    /*0x39ed7ec*/ string get_SignatureAlgorithm();
                    /*0x39ed804*/ int get_Version();
                    /*0x39ed820*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x39ed838*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x39ed850*/ string get_Subject();
                    /*0x39ed878*/ string get_Issuer();
                    /*0x39ed8a0*/ byte[] get_RawData();
                    /*0x39ed8b8*/ byte[] get_Thumbprint();
                    /*0x39ed9f8*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x39eda2c*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0x39eda44*/ System.DateTime get_NotAfter();
                    /*0x39edaa4*/ System.DateTime get_NotBefore();
                    /*0x39edb04*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509CertificateCollection : System.Collections.CollectionBase
                {
                    /*0x39ea364*/ X509CertificateCollection();
                    /*0x39edb98*/ X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x39edc94*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Item(int index);
                    /*0x39edbc4*/ void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x39edd2c*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                    /*0x39ede40*/ int GetHashCode();

                    class X509CertificateEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.IEnumerator enumerator;

                        /*0x39edd84*/ X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings);
                        /*0x39ede5c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Current();
                        /*0x39edf4c*/ object System.Collections.IEnumerator.get_Current();
                        /*0x39edff0*/ bool System.Collections.IEnumerator.MoveNext();
                        /*0x39ee090*/ void System.Collections.IEnumerator.Reset();
                        /*0x39ee134*/ bool MoveNext();
                    }
                }

                class X509CertificateImplCollection : System.IDisposable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list;

                    /*0x39ed3f0*/ X509CertificateImplCollection();
                    /*0x39ee1d4*/ X509CertificateImplCollection(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other);
                    /*0x39ee424*/ int get_Count();
                    /*0x39ee46c*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(int index);
                    /*0x39ed478*/ void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, bool takeOwnership);
                    /*0x39ec300*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone();
                    /*0x39ee4d8*/ void Dispose();
                    /*0x39ee544*/ void Dispose(bool disposing);
                    /*0x39ee830*/ void Finalize();
                }

                class X509Chain : System.IDisposable
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainImpl impl;

                    static /*0x39ed584*/ System.Security.Cryptography.X509Certificates.X509Chain Create();
                    /*0x39ee8e0*/ X509Chain();
                    /*0x39ee8e8*/ X509Chain(bool useMachineContext);
                    /*0x39ee924*/ X509Chain(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    /*0x39ee960*/ X509Chain(nint chainContext);
                    /*0x39ee8c0*/ System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl();
                    /*0x39ee9a0*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x39ee9d0*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x39ed5d8*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39eea00*/ void Reset();
                    /*0x39eea30*/ void Dispose();
                    /*0x39eea9c*/ void Dispose(bool disposing);
                    /*0x39eeb38*/ void Finalize();
                }

                class X509ChainElement
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509Certificate2 certificate;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x20*/ string info;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags compressed_status_flags;

                    /*0x39eebc8*/ X509ChainElement(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39eec18*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate();
                    /*0x39eec20*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainElementStatus();
                    /*0x39eec28*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_StatusFlags();
                    /*0x39eec30*/ void set_StatusFlags(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x39eec38*/ int Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x39eec5c*/ void Set(System.Security.Cryptography.X509Certificates.X509ChainStatus[] status, ref int position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask);
                    /*0x39eee68*/ void UncompressFlags();
                }

                class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _list;

                    /*0x39ef0cc*/ X509ChainElementCollection();
                    /*0x39ef138*/ int get_Count();
                    /*0x39ef158*/ bool get_IsSynchronized();
                    /*0x39ef178*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(int index);
                    /*0x39ef210*/ object get_SyncRoot();
                    /*0x39ef230*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x39ef250*/ System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator();
                    /*0x39ef368*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x39ef3c4*/ void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39ef444*/ void Clear();
                    /*0x39ef464*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                }

                class X509ChainElementEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x39ef2ac*/ X509ChainElementEnumerator(System.Collections.IEnumerable enumerable);
                    /*0x39ef558*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Current();
                    /*0x39ef648*/ object System.Collections.IEnumerator.get_Current();
                    /*0x39ef6ec*/ bool MoveNext();
                    /*0x39ef78c*/ void Reset();
                }

                class X509ChainImpl : System.IDisposable
                {
                    /*0x39ef904*/ X509ChainImpl();
                    /*0x1f2fe14*/ bool get_IsValid();
                    /*0x39ef830*/ void ThrowIfContextInvalid();
                    /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x1f30214*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x1f2fec8*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x1f30b78*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode);
                    /*0x1f309e4*/ void Reset();
                    /*0x39eeacc*/ void Dispose();
                    /*0x39ef870*/ void Dispose(bool disposing);
                    /*0x39ef874*/ void Finalize();
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

                    static /*0x39f28d8*/ X509ChainImplMono();
                    static /*0x39f0fbc*/ string GetAuthorityKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x39f1afc*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Crl crl);
                    static /*0x39f19a4*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext);
                    static /*0x39f258c*/ Mono.Security.X509.X509Crl CheckCrls(string subject, string ski, Mono.Security.X509.X509Store store);
                    /*0x39ef90c*/ X509ChainImplMono(bool useMachineContext);
                    /*0x39ef9ec*/ bool get_IsValid();
                    /*0x39ef9f4*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x39ef9fc*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x39efa04*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
                    /*0x39efa08*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39f0230*/ void Reset();
                    /*0x39f038c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Roots();
                    /*0x39f0668*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateAuthorities();
                    /*0x39f0468*/ System.Security.Cryptography.X509Certificates.X509Store get_LMRootStore();
                    /*0x39f0568*/ System.Security.Cryptography.X509Certificates.X509Store get_UserRootStore();
                    /*0x39f0744*/ System.Security.Cryptography.X509Certificates.X509Store get_LMCAStore();
                    /*0x39f0844*/ System.Security.Cryptography.X509Certificates.X509Store get_UserCAStore();
                    /*0x39f0944*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateCollection();
                    /*0x39efff4*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39f0e30*/ System.Security.Cryptography.X509Certificates.X509Certificate2 SelectBestFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2 child, System.Security.Cryptography.X509Certificates.X509Certificate2Collection c);
                    /*0x39f0c54*/ System.Security.Cryptography.X509Certificates.X509Certificate2 FindParent(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39f0d68*/ bool IsChainComplete(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39f10fc*/ bool IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39f00d8*/ void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x39f1144*/ void Process(int n);
                    /*0x39f13f4*/ void PrepareForNextCertificate(int n);
                    /*0x39f17e0*/ void WrapUp();
                    /*0x39f18b0*/ void ProcessCertificateExtensions(System.Security.Cryptography.X509Certificates.X509ChainElement element);
                    /*0x39f1874*/ bool IsSignedWith(System.Security.Cryptography.X509Certificates.X509Certificate2 signed, System.Security.Cryptography.AsymmetricAlgorithm pubkey);
                    /*0x39f1054*/ string GetSubjectKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x39f15f4*/ void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x39f1b88*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, int ca, bool online);
                    /*0x39f1c50*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2 ca_cert, bool online);
                    /*0x39f1e2c*/ Mono.Security.X509.X509Crl FindCrl(System.Security.Cryptography.X509Certificates.X509Certificate2 caCertificate);
                    /*0x39f2278*/ bool ProcessCrlExtensions(Mono.Security.X509.X509Crl crl);
                    /*0x39f1fa0*/ bool ProcessCrlEntryExtensions(Mono.Security.X509.X509Crl.X509CrlEntry entry);
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

                    /*0x39ef9d0*/ X509ChainPolicy();
                    /*0x39f0a28*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_ExtraStore();
                    /*0x39f2a5c*/ System.Security.Cryptography.X509Certificates.X509RevocationFlag get_RevocationFlag();
                    /*0x39f2a64*/ System.Security.Cryptography.X509Certificates.X509RevocationMode get_RevocationMode();
                    /*0x39f2a6c*/ void set_RevocationMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                    /*0x39f2ac8*/ System.Security.Cryptography.X509Certificates.X509VerificationFlags get_VerificationFlags();
                    /*0x39f2ad0*/ void set_VerificationFlags(System.Security.Cryptography.X509Certificates.X509VerificationFlags value);
                    /*0x39f2b2c*/ System.DateTime get_VerificationTime();
                    /*0x39f294c*/ void Reset();
                }

                struct X509ChainStatus
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status;
                    /*0x18*/ string info;

                    static /*0x39eece4*/ string GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x39f0208*/ X509ChainStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x39f2b34*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_Status();
                    /*0x39f2b3c*/ void set_Status(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x39f2b44*/ void set_StatusInformation(string value);
                }

                class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    /*0x28*/ System.Security.Cryptography.OidCollection _enhKeyUsage;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x39ea2bc*/ X509EnhancedKeyUsageExtension();
                    /*0x39e6324*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical);
                    /*0x39f2d98*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical);
                    /*0x39f2fe4*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x39f2b4c*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x39f2f28*/ byte[] Encode();
                    /*0x39f31b0*/ string ToString(bool multiLine);
                }

                class X509Extension : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ bool _critical;

                    /*0x39e791c*/ X509Extension();
                    /*0x39f347c*/ X509Extension(string oid, byte[] rawData, bool critical);
                    /*0x39f34a0*/ bool get_Critical();
                    /*0x39f34a8*/ void set_Critical(bool value);
                    /*0x39f34b0*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x39e82dc*/ string FormatUnkownData(byte[] data);
                }

                class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Collections.ArrayList _list;

                    static /*0x39f374c*/ X509ExtensionCollection();
                    /*0x39e8a04*/ X509ExtensionCollection();
                    /*0x39ea210*/ int get_Count();
                    /*0x39f35d0*/ bool get_IsSynchronized();
                    /*0x39f35f0*/ object get_SyncRoot();
                    /*0x39ea974*/ System.Security.Cryptography.X509Certificates.X509Extension get_Item(string oid);
                    /*0x39e8cc8*/ int Add(System.Security.Cryptography.X509Certificates.X509Extension extension);
                    /*0x39f35f4*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x39ea230*/ System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator();
                    /*0x39f36ec*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class X509ExtensionEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x39f37c0*/ X509ExtensionEnumerator(System.Collections.ArrayList list);
                    /*0x39f380c*/ System.Security.Cryptography.X509Certificates.X509Extension get_Current();
                    /*0x39f38fc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x39f39a0*/ bool MoveNext();
                    /*0x39f3a40*/ void Reset();
                }

                class X509Helper2
                {
                    static /*0x39f3ae4*/ Mono.Security.X509.X509Certificate GetMonoCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x39f3bb4*/ System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(bool useMachineContext);
                    static /*0x39f3c10*/ bool IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x39f3c24*/ void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x39f3c64*/ System.Exception GetInvalidChainContextException();
                }

                class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.15";
                    static string friendlyName = "Key Usage";
                    static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all = 33023;
                    /*0x24*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x39f3ce4*/ X509KeyUsageExtension();
                    /*0x39f3d88*/ X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical);
                    /*0x39f4024*/ X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical);
                    /*0x39f4284*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages();
                    /*0x39f42e8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x39f4108*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags);
                    /*0x39f3e74*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x39f4118*/ byte[] Encode();
                    /*0x39f44c0*/ string ToString(bool multiLine);
                }

                class X509Store : System.IDisposable
                {
                    /*0x10*/ string _name;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.StoreLocation _location;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection list;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.OpenFlags _flags;
                    /*0x30*/ Mono.Security.X509.X509Store store;

                    /*0x39f4a2c*/ X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation);
                    /*0x39f4b64*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Certificates();
                    /*0x39f4bec*/ Mono.Security.X509.X509Stores get_Factory();
                    /*0x39f4c08*/ Mono.Security.X509.X509Store get_Store();
                    /*0x39f4c10*/ void Close();
                    /*0x39f4c44*/ void Dispose();
                    /*0x39f4c48*/ void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags);
                }

                class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.14";
                    static string friendlyName = "Subject Key Identifier";
                    /*0x28*/ byte[] _subjectKeyIdentifier;
                    /*0x30*/ string _ski;
                    /*0x38*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    static /*0x39f5e04*/ byte FromHexChar(char c);
                    static /*0x39f5e40*/ byte FromHexChars(char c1, char c2);
                    static /*0x39f56cc*/ byte[] FromHex(string hex);
                    /*0x39f5008*/ X509SubjectKeyIdentifierExtension();
                    /*0x39f50ac*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical);
                    /*0x39f5308*/ X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical);
                    /*0x39f555c*/ X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical);
                    /*0x39f57bc*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical);
                    /*0x39f57c8*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical);
                    /*0x39f5ba0*/ string get_SubjectKeyIdentifier();
                    /*0x39f5c2c*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x39f5198*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x39f54e8*/ byte[] Encode();
                    /*0x39f5edc*/ string ToString(bool multiLine);
                }
            }
        }
    }

    namespace ComponentModel
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object _value;

            /*0x39f6110*/ DefaultValueAttribute(int value);
            /*0x39f615c*/ DefaultValueAttribute(long value);
            /*0x39f61a8*/ DefaultValueAttribute(bool value);
            /*0x39f61f4*/ DefaultValueAttribute(string value);
            /*0x39f6224*/ DefaultValueAttribute(object value);
            /*0x39f6254*/ object get_Value();
            /*0x39f625c*/ bool Equals(object obj);
            /*0x39f635c*/ int GetHashCode();
        }

        class EditorBrowsableAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.EditorBrowsableState browsableState;

            /*0x39f6364*/ EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state);
            /*0x39f638c*/ bool Equals(object obj);
            /*0x39f640c*/ int GetHashCode();
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

            static /*0x39f6688*/ BrowsableAttribute();
            /*0x39f6414*/ BrowsableAttribute(bool browsable);
            /*0x39f643c*/ bool get_Browsable();
            /*0x39f6444*/ bool Equals(object obj);
            /*0x39f65e8*/ int GetHashCode();
            /*0x39f6620*/ bool IsDefaultAttribute();
        }

        class ComponentCollection : System.Collections.ReadOnlyCollectionBase
        {
            /*0x39f6738*/ System.ComponentModel.IComponent get_Item(string name);
        }

        class DescriptionAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DescriptionAttribute Default;
            /*0x10*/ string <DescriptionValue>k__BackingField;

            static /*0x39f6e54*/ DescriptionAttribute();
            /*0x39f6c7c*/ DescriptionAttribute();
            /*0x39f6cbc*/ DescriptionAttribute(string description);
            /*0x39f6cec*/ string get_Description();
            /*0x39f6cf4*/ string get_DescriptionValue();
            /*0x39f6cfc*/ void set_DescriptionValue(string value);
            /*0x39f6d04*/ bool Equals(object obj);
            /*0x39f6dc4*/ int GetHashCode();
            /*0x39f6dec*/ bool IsDefaultAttribute();
        }

        class DesignOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.DesignOnlyAttribute Default;
            /*0x10*/ bool <IsDesignOnly>k__BackingField;

            static /*0x39f716c*/ DesignOnlyAttribute();
            /*0x39f6ee0*/ DesignOnlyAttribute(bool isDesignOnly);
            /*0x39f6f08*/ bool get_IsDesignOnly();
            /*0x39f6f10*/ bool Equals(object obj);
            /*0x39f70b4*/ int GetHashCode();
            /*0x39f70ec*/ bool IsDefaultAttribute();
        }

        class DesignerCategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerCategoryAttribute Component;
            static /*0x8*/ System.ComponentModel.DesignerCategoryAttribute Default;
            static /*0x10*/ System.ComponentModel.DesignerCategoryAttribute Form;
            static /*0x18*/ System.ComponentModel.DesignerCategoryAttribute Generic;
            /*0x10*/ string <Category>k__BackingField;

            static /*0x39f73d8*/ DesignerCategoryAttribute();
            /*0x39f721c*/ DesignerCategoryAttribute();
            /*0x39f7250*/ DesignerCategoryAttribute(string category);
            /*0x39f7280*/ string get_Category();
            /*0x39f7288*/ bool Equals(object obj);
            /*0x39f730c*/ int GetHashCode();
            /*0x39f7328*/ bool IsDefaultAttribute();
            /*0x39f73a0*/ object get_TypeId();
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

            static /*0x39f778c*/ DesignerSerializationVisibilityAttribute();
            /*0x39f7558*/ DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility);
            /*0x39f7580*/ System.ComponentModel.DesignerSerializationVisibility get_Visibility();
            /*0x39f7588*/ bool Equals(object obj);
            /*0x39f771c*/ int GetHashCode();
            /*0x39f7724*/ bool IsDefaultAttribute();
        }

        class DisplayNameAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DisplayNameAttribute Default;
            /*0x10*/ string <DisplayNameValue>k__BackingField;

            static /*0x39f7a44*/ DisplayNameAttribute();
            /*0x39f786c*/ DisplayNameAttribute();
            /*0x39f78ac*/ DisplayNameAttribute(string displayName);
            /*0x39f78dc*/ string get_DisplayName();
            /*0x39f78e4*/ string get_DisplayNameValue();
            /*0x39f78ec*/ void set_DisplayNameValue(string value);
            /*0x39f78f4*/ bool Equals(object obj);
            /*0x39f79b4*/ int GetHashCode();
            /*0x39f79dc*/ bool IsDefaultAttribute();
        }

        class EventHandlerList
        {
            /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _head;
            /*0x18*/ System.ComponentModel.Component _parent;

            /*0x39f7ad0*/ System.Delegate get_Item(object key);
            /*0x39f7b38*/ System.ComponentModel.EventHandlerList.ListEntry Find(object key);

            class ListEntry
            {
                /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _next;
                /*0x18*/ object _key;
                /*0x20*/ System.Delegate _handler;
            }
        }

        interface IContainer : System.IDisposable
        {
            /*0x1f30214*/ System.ComponentModel.ComponentCollection get_Components();
            /*0x1f30ebc*/ void Remove(System.ComponentModel.IComponent component);
        }

        interface ISite : System.IServiceProvider
        {
            /*0x1f30214*/ System.ComponentModel.IContainer get_Container();
            /*0x1f2fe14*/ bool get_DesignMode();
            /*0x1f30214*/ string get_Name();
        }

        interface ISynchronizeInvoke
        {
            /*0x1f2fe14*/ bool get_InvokeRequired();
            /*0x1f30394*/ System.IAsyncResult BeginInvoke(System.Delegate method, object[] args);
            /*0x1f30394*/ object Invoke(System.Delegate method, object[] args);
        }

        class InvalidEnumArgumentException : System.ArgumentException
        {
            /*0x39f7b50*/ InvalidEnumArgumentException();
            /*0x39f7b5c*/ InvalidEnumArgumentException(string message);
            /*0x39f7b64*/ InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class ReadOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ReadOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.ReadOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.ReadOnlyAttribute Default;
            /*0x10*/ bool <IsReadOnly>k__BackingField;

            static /*0x39f7dc8*/ ReadOnlyAttribute();
            /*0x39f7b6c*/ ReadOnlyAttribute(bool isReadOnly);
            /*0x39f7b94*/ bool get_IsReadOnly();
            /*0x39f7b9c*/ bool Equals(object value);
            /*0x39f7d40*/ int GetHashCode();
            /*0x39f7d48*/ bool IsDefaultAttribute();
        }

        class AmbientValueAttribute : System.Attribute
        {
            /*0x10*/ object <Value>k__BackingField;

            /*0x39f7e78*/ object get_Value();
        }

        class ArrayConverter : System.ComponentModel.CollectionConverter
        {
            /*0x39f8528*/ ArrayConverter();
            /*0x39f7e80*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x39f8170*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x39f8520*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class ArrayPropertyDescriptor : System.ComponentModel.TypeConverter.SimplePropertyDescriptor
            {
                /*0x98*/ int _index;

                /*0x39f8348*/ ArrayPropertyDescriptor(System.Type arrayType, System.Type elementType, int index);
                /*0x39f8538*/ object GetValue(object instance);
                /*0x39f85c0*/ void SetValue(object instance, object value);
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

            static /*0x39f93c0*/ AttributeCollection();
            /*0x39f86b4*/ AttributeCollection(System.Attribute[] attributes);
            /*0x39f8800*/ System.Attribute[] get_Attributes();
            /*0x39f8808*/ int get_Count();
            /*0x39f882c*/ System.Attribute get_Item(System.Type attributeType);
            /*0x39f9298*/ bool Contains(System.Attribute attribute);
            /*0x39f8d1c*/ System.Attribute GetDefaultAttribute(System.Type attributeType);
            /*0x39f92f8*/ System.Collections.IEnumerator GetEnumerator();
            /*0x39f931c*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x39f9324*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x39f932c*/ int System.Collections.ICollection.get_Count();
            /*0x39f9350*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x39f9354*/ void CopyTo(System.Array array, int index);

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

            /*0x39f9464*/ string get_TypeName();
            /*0x39f946c*/ string get_PropertyName();
        }

        class BaseNumberConverter : System.ComponentModel.TypeConverter
        {
            /*0x39f9474*/ BaseNumberConverter();
            /*0x39f947c*/ bool get_AllowHex();
            /*0x1f30214*/ System.Type get_TargetType();
            /*0x1f30300*/ object FromString(string value, int radix);
            /*0x1f30394*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1f30394*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x39f9484*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x39f9510*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x39f98e8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x39f9b68*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        }

        class BooleanConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.ComponentModel.TypeConverter.StandardValuesCollection s_values;

            /*0x39f9f70*/ BooleanConverter();
            /*0x39f9ba0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x39f9c2c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x39f9de4*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x39f9f60*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x39f9f68*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x39fa10c*/ ByteConverter();
            /*0x39f9f78*/ System.Type get_TargetType();
            /*0x39f9fa8*/ object FromString(string value, int radix);
            /*0x39fa030*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x39fa068*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class CharConverter : System.ComponentModel.TypeConverter
        {
            /*0x39fa3a8*/ CharConverter();
            /*0x39fa114*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x39fa1a0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x39fa290*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
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

            /*0x39fa3b0*/ CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element);
            /*0x39fa42c*/ System.ComponentModel.CollectionChangeAction get_Action();
            /*0x39fa434*/ object get_Element();
        }

        class CollectionChangeEventHandler : System.MulticastDelegate
        {
            /*0x39fa43c*/ CollectionChangeEventHandler(object object, nint method);
            /*0x39fa548*/ void Invoke(object sender, System.ComponentModel.CollectionChangeEventArgs e);
        }

        class CultureInfoConverter : System.ComponentModel.TypeConverter
        {
            static string DefaultInvariantCultureString = "(Default)";
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x39fb720*/ CultureInfoConverter();
            /*0x39fa55c*/ string get_DefaultCultureString();
            /*0x39fa59c*/ string GetCultureName(System.Globalization.CultureInfo culture);
            /*0x39fa5bc*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x39fa648*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x39fa6f8*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x39fb054*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x39fb4c4*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x39fb710*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x39fb718*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class CultureComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.CultureInfoConverter _converter;

                /*0x39fb6e0*/ CultureComparer(System.ComponentModel.CultureInfoConverter cultureConverter);
                /*0x39fb728*/ int Compare(object item1, object item2);
            }

            class CultureInfoMapper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> s_cultureInfoNameMap;

                static /*0x39ff978*/ CultureInfoMapper();
                static /*0x39fb898*/ System.Collections.Generic.Dictionary<string, string> CreateMap();
                static /*0x39fafb4*/ string GetCultureInfoName(string cultureInfoDisplayName);
            }
        }

        class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
        {
            /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _parent;

            /*0x39ff9d0*/ CustomTypeDescriptor();
            /*0x39ff9d8*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x39ffab0*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x39ffb88*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x39ffc64*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x39ffd48*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        class DateTimeConverter : System.ComponentModel.TypeConverter
        {
            /*0x3a00610*/ DateTimeConverter();
            /*0x39ffe00*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x39ffe8c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x39fff3c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a00254*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class DecimalConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a00cfc*/ DecimalConverter();
            /*0x3a00618*/ bool get_AllowHex();
            /*0x3a00620*/ System.Type get_TargetType();
            /*0x3a00680*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a0072c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a00a58*/ object FromString(string value, int radix);
            /*0x3a00b44*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a00bf0*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class DefaultEventAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultEventAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x3a00db8*/ DefaultEventAttribute();
            /*0x3a00d04*/ DefaultEventAttribute(string name);
            /*0x3a00d34*/ string get_Name();
            /*0x3a00d3c*/ bool Equals(object obj);
            /*0x3a00db0*/ int GetHashCode();
        }

        class DefaultPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultPropertyAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x3a00ee4*/ DefaultPropertyAttribute();
            /*0x3a00e30*/ DefaultPropertyAttribute(string name);
            /*0x3a00e60*/ string get_Name();
            /*0x3a00e68*/ bool Equals(object obj);
            /*0x3a00edc*/ int GetHashCode();
        }

        class DelegatingTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
        {
            /*0x20*/ System.Type _type;

            /*0x3a00f5c*/ DelegatingTypeDescriptionProvider(System.Type type);
            /*0x3a00f94*/ System.ComponentModel.TypeDescriptionProvider get_Provider();
            /*0x3a00ff0*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x3a01040*/ System.Collections.IDictionary GetCache(object instance);
            /*0x3a01068*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x3a01090*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x3a010b8*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x3a010f0*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
        }

        class ToolboxItemAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ToolboxItemAttribute Default;
            static /*0x8*/ System.ComponentModel.ToolboxItemAttribute None;
            /*0x10*/ string _toolboxItemTypeName;

            static /*0x3a013a8*/ ToolboxItemAttribute();
            /*0x3a01190*/ ToolboxItemAttribute(bool defaultType);
            /*0x3a011fc*/ ToolboxItemAttribute(string toolboxItemTypeName);
            /*0x3a01128*/ bool IsDefaultAttribute();
            /*0x3a01290*/ string get_ToolboxItemTypeName();
            /*0x3a012b4*/ bool Equals(object obj);
            /*0x3a01384*/ int GetHashCode();
        }

        class DesignTimeVisibleAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignTimeVisibleAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignTimeVisibleAttribute No;
            static /*0x10*/ System.ComponentModel.DesignTimeVisibleAttribute Default;
            /*0x10*/ bool <Visible>k__BackingField;

            static /*0x3a01634*/ DesignTimeVisibleAttribute();
            /*0x3a01470*/ DesignTimeVisibleAttribute(bool visible);
            /*0x3a01498*/ bool get_Visible();
            /*0x3a014a0*/ bool Equals(object obj);
            /*0x3a0152c*/ int GetHashCode();
            /*0x3a015b4*/ bool IsDefaultAttribute();
        }

        class DoubleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a018a8*/ DoubleConverter();
            /*0x3a016e4*/ bool get_AllowHex();
            /*0x3a016ec*/ System.Type get_TargetType();
            /*0x3a0171c*/ object FromString(string value, int radix);
            /*0x3a017d0*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a01804*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class EditorAttribute : System.Attribute
        {
            /*0x10*/ string _typeId;
            /*0x18*/ string <EditorBaseTypeName>k__BackingField;
            /*0x20*/ string <EditorTypeName>k__BackingField;

            /*0x3a018b0*/ EditorAttribute(string typeName, string baseTypeName);
            /*0x3a01958*/ string get_EditorBaseTypeName();
            /*0x3a01960*/ string get_EditorTypeName();
            /*0x3a01968*/ object get_TypeId();
            /*0x3a01a08*/ bool Equals(object obj);
            /*0x3a01aa0*/ int GetHashCode();
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

            static /*0x3a02a48*/ EventDescriptorCollection();
            /*0x3a01aa8*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events);
            /*0x3a01b88*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly);
            /*0x3a01bac*/ int get_Count();
            /*0x3a01bb4*/ void set_Count(int value);
            /*0x3a01bbc*/ System.ComponentModel.EventDescriptor get_Item(int index);
            /*0x3a01cfc*/ int Add(System.ComponentModel.EventDescriptor value);
            /*0x3a01ef0*/ void Clear();
            /*0x3a01f38*/ bool Contains(System.ComponentModel.EventDescriptor value);
            /*0x3a01fb0*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x3a01c40*/ void EnsureEventsOwned();
            /*0x3a01dcc*/ void EnsureSize(int sizeNeeded);
            /*0x3a01f50*/ int IndexOf(System.ComponentModel.EventDescriptor value);
            /*0x3a0227c*/ void Insert(int index, System.ComponentModel.EventDescriptor value);
            /*0x3a0236c*/ void Remove(System.ComponentModel.EventDescriptor value);
            /*0x3a023d4*/ void RemoveAt(int index);
            /*0x3a02490*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3a01fec*/ void InternalSort(string[] names);
            /*0x3a02570*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x3a025e8*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x3a025f0*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x3a025f8*/ int System.Collections.ICollection.get_Count();
            /*0x3a02600*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3a02604*/ object System.Collections.IList.get_Item(int index);
            /*0x3a02614*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x3a02780*/ int System.Collections.IList.Add(object value);
            /*0x3a02804*/ bool System.Collections.IList.Contains(object value);
            /*0x3a02894*/ void System.Collections.IList.Clear();
            /*0x3a02898*/ int System.Collections.IList.IndexOf(object value);
            /*0x3a0291c*/ void System.Collections.IList.Insert(int index, object value);
            /*0x3a029b0*/ void System.Collections.IList.Remove(object value);
            /*0x3a02a34*/ void System.Collections.IList.RemoveAt(int index);
            /*0x3a02a38*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x3a02a40*/ bool System.Collections.IList.get_IsFixedSize();

            class ArraySubsetEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Array _array;
                /*0x18*/ int _total;
                /*0x1c*/ int _current;

                /*0x3a02530*/ ArraySubsetEnumerator(System.Array array, int count);
                /*0x3a02ab8*/ bool MoveNext();
                /*0x3a02adc*/ void Reset();
                /*0x3a02ae8*/ object get_Current();
            }
        }

        class ExpandableObjectConverter : System.ComponentModel.TypeConverter
        {
            /*0x3a02b44*/ ExpandableObjectConverter();
            /*0x3a02b4c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x3a02bb4*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ExtendedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.ComponentModel.ReflectPropertyDescriptor _extenderInfo;
            /*0x90*/ System.ComponentModel.IExtenderProvider _provider;

            /*0x3a02bbc*/ ExtendedPropertyDescriptor(System.ComponentModel.ReflectPropertyDescriptor extenderInfo, System.Type receiverType, System.ComponentModel.IExtenderProvider provider, System.Attribute[] attributes);
            /*0x3a02e38*/ bool CanResetValue(object comp);
            /*0x3a02e5c*/ System.Type get_ComponentType();
            /*0x3a02e7c*/ bool get_IsReadOnly();
            /*0x3a02f60*/ System.Type get_PropertyType();
            /*0x3a02f80*/ string get_DisplayName();
            /*0x3a03354*/ object GetValue(object comp);
            /*0x3a03378*/ void ResetValue(object comp);
            /*0x3a0339c*/ void SetValue(object component, object value);
            /*0x3a033c8*/ bool ShouldSerializeValue(object comp);
        }

        class ExtenderProvidedPropertyAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.PropertyDescriptor <ExtenderProperty>k__BackingField;
            /*0x18*/ System.ComponentModel.IExtenderProvider <Provider>k__BackingField;
            /*0x20*/ System.Type <ReceiverType>k__BackingField;

            static /*0x3a02d98*/ System.ComponentModel.ExtenderProvidedPropertyAttribute Create(System.ComponentModel.PropertyDescriptor extenderProperty, System.Type receiverType, System.ComponentModel.IExtenderProvider provider);
            /*0x3a033ec*/ ExtenderProvidedPropertyAttribute();
            /*0x3a033f4*/ System.ComponentModel.PropertyDescriptor get_ExtenderProperty();
            /*0x3a033fc*/ void set_ExtenderProperty(System.ComponentModel.PropertyDescriptor value);
            /*0x3a03404*/ System.ComponentModel.IExtenderProvider get_Provider();
            /*0x3a0340c*/ void set_Provider(System.ComponentModel.IExtenderProvider value);
            /*0x3a03414*/ System.Type get_ReceiverType();
            /*0x3a0341c*/ void set_ReceiverType(System.Type value);
            /*0x3a03424*/ bool Equals(object obj);
            /*0x3a034f0*/ int GetHashCode();
            /*0x3a034f8*/ bool IsDefaultAttribute();
        }

        class GuidConverter : System.ComponentModel.TypeConverter
        {
            /*0x3a03a58*/ GuidConverter();
            /*0x3a03530*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a035bc*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a0366c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a03740*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        interface IBindingList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
        }

        interface ICustomTypeDescriptor
        {
            /*0x1f30214*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x1f30214*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x1f30214*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x1f302cc*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x1f302cc*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        interface IExtenderProvider
        {
            /*0x1f2fec8*/ bool CanExtend(object extendee);
        }

        interface ITypeDescriptorContext : System.IServiceProvider
        {
            /*0x1f30214*/ System.ComponentModel.IContainer get_Container();
        }

        class Int16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a03bf4*/ Int16Converter();
            /*0x3a03a60*/ System.Type get_TargetType();
            /*0x3a03a90*/ object FromString(string value, int radix);
            /*0x3a03b18*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a03b50*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a03d90*/ Int32Converter();
            /*0x3a03bfc*/ System.Type get_TargetType();
            /*0x3a03c2c*/ object FromString(string value, int radix);
            /*0x3a03cb4*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a03cec*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a03f2c*/ Int64Converter();
            /*0x3a03d98*/ System.Type get_TargetType();
            /*0x3a03dc8*/ object FromString(string value, int radix);
            /*0x3a03e50*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a03e88*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class ListBindableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ListBindableAttribute Yes;
            static /*0x8*/ System.ComponentModel.ListBindableAttribute No;
            static /*0x10*/ System.ComponentModel.ListBindableAttribute Default;
            /*0x10*/ bool _isDefault;
            /*0x11*/ bool <ListBindable>k__BackingField;

            static /*0x3a0407c*/ ListBindableAttribute();
            /*0x3a03f34*/ ListBindableAttribute(bool listBindable);
            /*0x3a03f5c*/ bool get_ListBindable();
            /*0x3a03f64*/ bool Equals(object obj);
            /*0x3a03ff0*/ int GetHashCode();
            /*0x3a03ff8*/ bool IsDefaultAttribute();
        }

        class ListChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.ComponentModel.ListChangedType <ListChangedType>k__BackingField;
            /*0x14*/ int <NewIndex>k__BackingField;
            /*0x18*/ int <OldIndex>k__BackingField;
            /*0x20*/ System.ComponentModel.PropertyDescriptor <PropertyDescriptor>k__BackingField;

            /*0x3a0412c*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex);
            /*0x3a041b4*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x3a041f0*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x3a04134*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex);
            /*0x3a0426c*/ System.ComponentModel.ListChangedType get_ListChangedType();
            /*0x3a04274*/ int get_NewIndex();
            /*0x3a0427c*/ int get_OldIndex();
        }

        class ListChangedEventHandler : System.MulticastDelegate
        {
            /*0x3a04284*/ ListChangedEventHandler(object object, nint method);
            /*0x3a04390*/ void Invoke(object sender, System.ComponentModel.ListChangedEventArgs e);
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

            static /*0x3a04928*/ MarshalByValueComponent();
            /*0x3a043a4*/ MarshalByValueComponent();
            /*0x3a043ac*/ void Finalize();
            /*0x3a0443c*/ System.ComponentModel.ISite get_Site();
            /*0x3a04444*/ void Dispose();
            /*0x3a044b0*/ void Dispose(bool disposing);
            /*0x3a04744*/ object GetService(System.Type service);
            /*0x3a047f8*/ string ToString();
        }

        class MultilineStringConverter : System.ComponentModel.TypeConverter
        {
            /*0x3a04b00*/ MultilineStringConverter();
            /*0x3a049a4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a04af0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x3a04af8*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class NullableConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type <NullableType>k__BackingField;
            /*0x18*/ System.Type <UnderlyingType>k__BackingField;
            /*0x20*/ System.ComponentModel.TypeConverter <UnderlyingTypeConverter>k__BackingField;

            /*0x3a04b08*/ NullableConverter(System.Type type);
            /*0x3a04c40*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a04ce4*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a04dec*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a04e90*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a0503c*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x3a05060*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a05084*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x3a050a8*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a050cc*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a05468*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a05490*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a054b8*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x3a054ec*/ System.Type get_NullableType();
            /*0x3a054f4*/ System.Type get_UnderlyingType();
            /*0x3a054fc*/ System.ComponentModel.TypeConverter get_UnderlyingTypeConverter();
        }

        class PropertyDescriptor : System.ComponentModel.MemberDescriptor
        {
            /*0x60*/ System.ComponentModel.TypeConverter _converter;
            /*0x68*/ System.Collections.Hashtable _valueChangedHandlers;
            /*0x70*/ object[] _editors;
            /*0x78*/ System.Type[] _editorTypes;
            /*0x80*/ int _editorCount;

            /*0x3a05504*/ PropertyDescriptor(string name, System.Attribute[] attrs);
            /*0x3a02d94*/ PropertyDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs);
            /*0x1f30214*/ System.Type get_ComponentType();
            /*0x3a05b2c*/ System.ComponentModel.TypeConverter get_Converter();
            /*0x1f2fe14*/ bool get_IsReadOnly();
            /*0x1f30214*/ System.Type get_PropertyType();
            /*0x1f2fec8*/ bool CanResetValue(object component);
            /*0x3a06180*/ bool Equals(object obj);
            /*0x3a05f88*/ object CreateInstance(System.Type type);
            /*0x3a06364*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x3a064ac*/ int GetHashCode();
            /*0x3a06500*/ object GetInvocationTarget(System.Type type, object instance);
            /*0x3a05d98*/ System.Type GetTypeFromName(string typeName);
            /*0x1f302cc*/ object GetValue(object component);
            /*0x3a066d8*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x1f30ebc*/ void ResetValue(object component);
            /*0x1f30ff0*/ void SetValue(object component, object value);
            /*0x1f2fec8*/ bool ShouldSerializeValue(object component);
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

            static /*0x3a085b4*/ PropertyDescriptorCollection();
            /*0x39f8400*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties);
            /*0x3a06788*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly);
            /*0x3a067ac*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, int propCount, string[] namedSort, System.Collections.IComparer comparer);
            /*0x3a068f8*/ int get_Count();
            /*0x3a06900*/ void set_Count(int value);
            /*0x3a06908*/ System.ComponentModel.PropertyDescriptor get_Item(int index);
            /*0x3a06a48*/ System.ComponentModel.PropertyDescriptor get_Item(string name);
            /*0x3a06a5c*/ int Add(System.ComponentModel.PropertyDescriptor value);
            /*0x3a06c50*/ void Clear();
            /*0x3a06ca0*/ bool Contains(System.ComponentModel.PropertyDescriptor value);
            /*0x3a06d18*/ void CopyTo(System.Array array, int index);
            /*0x3a0698c*/ void EnsurePropsOwned();
            /*0x3a06b2c*/ void EnsureSize(int sizeNeeded);
            /*0x3a06fe4*/ System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase);
            /*0x3a06cb8*/ int IndexOf(System.ComponentModel.PropertyDescriptor value);
            /*0x3a07518*/ void Insert(int index, System.ComponentModel.PropertyDescriptor value);
            /*0x3a07608*/ void Remove(System.ComponentModel.PropertyDescriptor value);
            /*0x3a07670*/ void RemoveAt(int index);
            /*0x3a0772c*/ System.ComponentModel.PropertyDescriptorCollection Sort(string[] names);
            /*0x3a06d54*/ void InternalSort(string[] names);
            /*0x3a077a8*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x3a07820*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3a078bc*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x3a078c4*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x3a078cc*/ int System.Collections.ICollection.get_Count();
            /*0x3a078d4*/ void System.Collections.IList.Clear();
            /*0x3a078d8*/ void System.Collections.IDictionary.Clear();
            /*0x3a078dc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3a078ec*/ void System.Collections.IList.RemoveAt(int index);
            /*0x3a078f0*/ void System.Collections.IDictionary.Add(object key, object value);
            /*0x3a079b4*/ bool System.Collections.IDictionary.Contains(object key);
            /*0x3a079fc*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
            /*0x3a07aa4*/ bool System.Collections.IDictionary.get_IsFixedSize();
            /*0x3a07aac*/ bool System.Collections.IDictionary.get_IsReadOnly();
            /*0x3a07ab4*/ object System.Collections.IDictionary.get_Item(object key);
            /*0x3a07ae8*/ void System.Collections.IDictionary.set_Item(object key, object value);
            /*0x3a07e80*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
            /*0x3a07f54*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
            /*0x3a0802c*/ void System.Collections.IDictionary.Remove(object key);
            /*0x3a08114*/ int System.Collections.IList.Add(object value);
            /*0x3a08198*/ bool System.Collections.IList.Contains(object value);
            /*0x3a08228*/ int System.Collections.IList.IndexOf(object value);
            /*0x3a082ac*/ void System.Collections.IList.Insert(int index, object value);
            /*0x3a08340*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x3a08348*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x3a08350*/ void System.Collections.IList.Remove(object value);
            /*0x3a083d4*/ object System.Collections.IList.get_Item(int index);
            /*0x3a083e4*/ void System.Collections.IList.set_Item(int index, object value);

            class PropertyDescriptorEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
            {
                /*0x10*/ System.ComponentModel.PropertyDescriptorCollection _owner;
                /*0x18*/ int _index;

                /*0x3a07a6c*/ PropertyDescriptorEnumerator(System.ComponentModel.PropertyDescriptorCollection owner);
                /*0x3a08624*/ object get_Current();
                /*0x3a08688*/ System.Collections.DictionaryEntry get_Entry();
                /*0x3a086f0*/ object get_Key();
                /*0x3a0872c*/ object get_Value();
                /*0x3a08768*/ bool MoveNext();
                /*0x3a087a0*/ void Reset();
            }
        }

        class ProvidePropertyAttribute : System.Attribute
        {
            /*0x10*/ string <PropertyName>k__BackingField;
            /*0x18*/ string <ReceiverTypeName>k__BackingField;

            /*0x3a087ac*/ string get_PropertyName();
            /*0x3a087b4*/ string get_ReceiverTypeName();
        }

        class ReferenceConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ string s_none;
            /*0x10*/ System.Type _type;

            static /*0x3a096d8*/ ReferenceConverter();
            /*0x3a087bc*/ ReferenceConverter(System.Type type);
            /*0x3a087ec*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a0887c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a08ba4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a08fc0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a096c0*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a096c8*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a096d0*/ bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value);

            class ReferenceComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.ReferenceConverter _converter;

                /*0x3a09690*/ ReferenceComparer(System.ComponentModel.ReferenceConverter converter);
                /*0x3a09740*/ int Compare(object item1, object item2);
            }
        }

        class RefreshEventArgs : System.EventArgs
        {
            /*0x10*/ System.Type <TypeChanged>k__BackingField;

            /*0x3a097f8*/ RefreshEventArgs(System.Type typeChanged);
        }

        class RefreshEventHandler : System.MulticastDelegate
        {
            /*0x3a0986c*/ RefreshEventHandler(object object, nint method);
            /*0x3a09974*/ void Invoke(System.ComponentModel.RefreshEventArgs e);
        }

        class SByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a09b1c*/ SByteConverter();
            /*0x3a09988*/ System.Type get_TargetType();
            /*0x3a099b8*/ object FromString(string value, int radix);
            /*0x3a09a40*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a09a78*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class SettingsBindableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.SettingsBindableAttribute Yes;
            static /*0x8*/ System.ComponentModel.SettingsBindableAttribute No;
            /*0x10*/ bool <Bindable>k__BackingField;

            static /*0x3a09c18*/ SettingsBindableAttribute();
            /*0x3a09b24*/ SettingsBindableAttribute(bool bindable);
            /*0x3a09b4c*/ bool get_Bindable();
            /*0x3a09b54*/ bool Equals(object obj);
            /*0x3a09be0*/ int GetHashCode();
        }

        class SingleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a09e78*/ SingleConverter();
            /*0x3a09cb4*/ bool get_AllowHex();
            /*0x3a09cbc*/ System.Type get_TargetType();
            /*0x3a09cec*/ object FromString(string value, int radix);
            /*0x3a09da0*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a09dd4*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class StringConverter : System.ComponentModel.TypeConverter
        {
            /*0x3a09f40*/ StringConverter();
            /*0x3a09e80*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a09f0c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        class TimeSpanConverter : System.ComponentModel.TypeConverter
        {
            /*0x3a0a584*/ TimeSpanConverter();
            /*0x3a09f48*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a09fd4*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a0a084*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a0a280*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class TypeConverterAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.TypeConverterAttribute Default;
            /*0x10*/ string <ConverterTypeName>k__BackingField;

            static /*0x3a0a6d4*/ TypeConverterAttribute();
            /*0x3a0a58c*/ TypeConverterAttribute();
            /*0x3a0a5c0*/ TypeConverterAttribute(System.Type type);
            /*0x3a0a60c*/ TypeConverterAttribute(string typeName);
            /*0x3a0a63c*/ string get_ConverterTypeName();
            /*0x3a0a644*/ bool Equals(object obj);
            /*0x3a0a6b8*/ int GetHashCode();
        }

        class TypeDescriptionProvider
        {
            /*0x10*/ System.ComponentModel.TypeDescriptionProvider _parent;
            /*0x18*/ System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

            /*0x3a00f8c*/ TypeDescriptionProvider();
            /*0x3a0a75c*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x3a0a81c*/ System.Collections.IDictionary GetCache(object instance);
            /*0x3a0a834*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x3a0a8d0*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x3a0a9d8*/ System.Type GetReflectionType(System.Type objectType);
            /*0x3a0a9e8*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x3a0aa04*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType);
            /*0x3a0aa14*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance);
            /*0x3a0aa9c*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

            class EmptyCustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor
            {
                /*0x3a0a8c8*/ EmptyCustomTypeDescriptor();
            }
        }

        class TypeDescriptionProviderAttribute : System.Attribute
        {
            /*0x10*/ string <TypeName>k__BackingField;

            /*0x3a0ab44*/ TypeDescriptionProviderAttribute(string typeName);
            /*0x3a0abc0*/ string get_TypeName();
        }

        class TypeListConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type[] _types;
            /*0x18*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x3a0abc8*/ TypeListConverter(System.Type[] types);
            /*0x3a0abf8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a0ac84*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a0ad34*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a0ae30*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a0afc0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a0b08c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a0b094*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class UInt16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a0b230*/ UInt16Converter();
            /*0x3a0b09c*/ System.Type get_TargetType();
            /*0x3a0b0cc*/ object FromString(string value, int radix);
            /*0x3a0b154*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a0b18c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a0b3cc*/ UInt32Converter();
            /*0x3a0b238*/ System.Type get_TargetType();
            /*0x3a0b268*/ object FromString(string value, int radix);
            /*0x3a0b2f0*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a0b328*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x3a0b568*/ UInt64Converter();
            /*0x3a0b3d4*/ System.Type get_TargetType();
            /*0x3a0b404*/ object FromString(string value, int radix);
            /*0x3a0b48c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3a0b4c4*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        interface IChangeTracking
        {
            /*0x1f2fe14*/ bool get_IsChanged();
            /*0x1f309e4*/ void AcceptChanges();
        }

        interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking
        {
            /*0x1f309e4*/ void RejectChanges();
        }

        class PropertyChangedEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x3a0b570*/ PropertyChangedEventArgs(string propertyName);
        }

        class PropertyChangedEventHandler : System.MulticastDelegate
        {
            /*0x3a0b5e4*/ PropertyChangedEventHandler(object object, nint method);
            /*0x3a0b6f0*/ void Invoke(object sender, System.ComponentModel.PropertyChangedEventArgs e);
        }

        class PropertyChangingEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x3a0b704*/ PropertyChangingEventArgs(string propertyName);
        }

        class PropertyChangingEventHandler : System.MulticastDelegate
        {
            /*0x3a0b778*/ PropertyChangingEventHandler(object object, nint method);
            /*0x3a0b884*/ void Invoke(object sender, System.ComponentModel.PropertyChangingEventArgs e);
        }

        class CategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.CategoryAttribute defAttr;
            /*0x10*/ bool localized;
            /*0x18*/ string categoryValue;

            static /*0x3a0b898*/ System.ComponentModel.CategoryAttribute get_Default();
            /*0x3a0b92c*/ CategoryAttribute();
            /*0x3a0b990*/ CategoryAttribute(string category);
            /*0x3a0b9c8*/ string get_Category();
            /*0x3a0ba20*/ bool Equals(object obj);
            /*0x3a0bb10*/ int GetHashCode();
            /*0x3a0bb30*/ string GetLocalizedString(string value);
            /*0x3a0be80*/ bool IsDefaultAttribute();
        }

        class CollectionConverter : System.ComponentModel.TypeConverter
        {
            /*0x39f8530*/ CollectionConverter();
            /*0x39f8010*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a0beb4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x3a0bebc*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class Component : System.MarshalByRefObject, System.ComponentModel.IComponent, System.IDisposable
        {
            static /*0x0*/ object EventDisposed;
            /*0x18*/ System.ComponentModel.ISite site;
            /*0x20*/ System.ComponentModel.EventHandlerList events;

            static /*0x3a0c574*/ Component();
            /*0x3a0c56c*/ Component();
            /*0x3a0bec4*/ void Finalize();
            /*0x3a0bf54*/ bool get_CanRaiseEvents();
            /*0x39f7b2c*/ bool get_CanRaiseEventsInternal();
            /*0x3a0bf5c*/ System.ComponentModel.ISite get_Site();
            /*0x3a0bf64*/ void Dispose();
            /*0x3a0bfd0*/ void Dispose(bool disposing);
            /*0x3a0c2d8*/ object GetService(System.Type service);
            /*0x3a0c38c*/ bool get_DesignMode();
            /*0x3a0c43c*/ string ToString();
        }

        class ComponentConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x3a0c5f0*/ ComponentConverter(System.Type type);
            /*0x3a0c664*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x3a0c6cc*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DateTimeOffsetConverter : System.ComponentModel.TypeConverter
        {
            /*0x3a0d7bc*/ DateTimeOffsetConverter();
            /*0x3a0c6d4*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a0c760*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a0c810*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a0cb84*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class EnumConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;
            /*0x18*/ System.Type type;

            /*0x3a0d7c4*/ EnumConverter(System.Type type);
            /*0x3a0d7f4*/ System.Type get_EnumType();
            /*0x3a0d7fc*/ System.ComponentModel.TypeConverter.StandardValuesCollection get_Values();
            /*0x3a0d804*/ void set_Values(System.ComponentModel.TypeConverter.StandardValuesCollection value);
            /*0x3a0d80c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a0d8f0*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a0d9e8*/ System.Collections.IComparer get_Comparer();
            /*0x3a0da40*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a0df0c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a0ebf8*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a0efd8*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a0f06c*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a0f074*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
        }

        interface IComponent : System.IDisposable
        {
            /*0x1f30214*/ System.ComponentModel.ISite get_Site();
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

            static /*0x3a0fddc*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType);
            static /*0x3a0fde4*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly);
            static /*0x3a03258*/ System.ComponentModel.ISite GetSite(object component);
            /*0x3a05508*/ MemberDescriptor(string name, System.Attribute[] attributes);
            /*0x3a056e0*/ MemberDescriptor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes);
            /*0x3a0f0b8*/ System.Attribute[] get_AttributeArray();
            /*0x3a0f8d4*/ void set_AttributeArray(System.Attribute[] value);
            /*0x3a0f9c8*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x3a0facc*/ string get_Name();
            /*0x3a0fb1c*/ int get_NameHashCode();
            /*0x3a03148*/ string get_DisplayName();
            /*0x3a0f0d8*/ void CheckAttributesValid();
            /*0x3a0fb24*/ System.ComponentModel.AttributeCollection CreateAttributeCollection();
            /*0x3a0fb94*/ bool Equals(object obj);
            /*0x3a063b8*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x3a0f1a0*/ void FilterAttributesIfNeeded();
            /*0x3a0fe88*/ int GetHashCode();
            /*0x3a065e0*/ object GetInvocationTarget(System.Type type, object instance);
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

            static /*0x3a1499c*/ ReflectPropertyDescriptor();
            /*0x3a0fe90*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Attribute[] attributes);
            /*0x3a10130*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Reflection.PropertyInfo propInfo, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x3a10294*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Type receiverType, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x3a10384*/ object get_AmbientValue();
            /*0x3a104f8*/ System.Type get_ComponentType();
            /*0x3a10500*/ object get_DefaultValue();
            /*0x3a10784*/ System.Reflection.MethodInfo get_GetMethodValue();
            /*0x3a10bd8*/ bool get_IsExtender();
            /*0x3a10c10*/ bool get_IsReadOnly();
            /*0x3a11204*/ System.Type get_PropertyType();
            /*0x3a1120c*/ System.Reflection.MethodInfo get_ResetMethodValue();
            /*0x3a10d04*/ System.Reflection.MethodInfo get_SetMethodValue();
            /*0x3a113f4*/ System.Reflection.MethodInfo get_ShouldSerializeMethodValue();
            /*0x3a115dc*/ bool ExtenderCanResetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x3a11998*/ System.Type ExtenderGetReceiverType();
            /*0x3a119a0*/ System.Type ExtenderGetType(System.ComponentModel.IExtenderProvider provider);
            /*0x3a1185c*/ object ExtenderGetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x3a119b0*/ void ExtenderResetValue(System.ComponentModel.IExtenderProvider provider, object component, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x3a11e48*/ void ExtenderSetValue(System.ComponentModel.IExtenderProvider provider, object component, object value, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x3a122bc*/ bool ExtenderShouldSerializeValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x3a126f4*/ bool CanResetValue(object component);
            /*0x3a1293c*/ void FillAttributes(System.Collections.IList attributes);
            /*0x3a1391c*/ object GetValue(object component);
            /*0x3a13bec*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x3a13c8c*/ void ResetValue(object component);
            /*0x3a14090*/ void SetValue(object component, object value);
            /*0x3a14678*/ bool ShouldSerializeValue(object component);
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

            static /*0x3a1abec*/ ReflectTypeDescriptionProvider();
            static /*0x3a14c4c*/ System.Collections.Hashtable get_IntrinsicTypeConverters();
            static /*0x3a157c8*/ object CreateInstance(System.Type objectType, System.Type callingType);
            static /*0x3a18264*/ System.ComponentModel.IExtenderProvider[] GetExtenders(System.Collections.ICollection components, object instance, System.Collections.IDictionary cache);
            static /*0x3a196d4*/ System.Type GetTypeFromName(string typeName);
            static /*0x3a19824*/ System.Attribute[] ReflectGetAttributes(System.Type type);
            static /*0x3a134e0*/ System.Attribute[] ReflectGetAttributes(System.Reflection.MemberInfo member);
            static /*0x3a16ec0*/ System.ComponentModel.PropertyDescriptor[] ReflectGetExtendedProperties(System.ComponentModel.IExtenderProvider provider);
            static /*0x3a19c60*/ System.ComponentModel.PropertyDescriptor[] ReflectGetProperties(System.Type type);
            static /*0x3a1a300*/ object SearchIntrinsicTable(System.Collections.Hashtable table, System.Type callingType);
            /*0x3a14c44*/ ReflectTypeDescriptionProvider();
            /*0x3a15614*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x3a158d0*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type type);
            /*0x3a16080*/ System.Collections.IDictionary GetCache(object instance);
            /*0x3a16388*/ System.ComponentModel.TypeConverter GetConverter(System.Type type, object instance);
            /*0x3a16880*/ System.ComponentModel.AttributeCollection GetExtendedAttributes(object instance);
            /*0x3a168d8*/ System.ComponentModel.TypeConverter GetExtendedConverter(object instance);
            /*0x3a16914*/ System.ComponentModel.PropertyDescriptorCollection GetExtendedProperties(object instance);
            /*0x3a17de8*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x3a18d3c*/ object GetExtendedPropertyOwner(object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x3a18dcc*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x3a18dd4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type type);
            /*0x3a18d68*/ object GetPropertyOwner(System.Type type, object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x3a19694*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x3a158ec*/ System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(System.Type type, bool createIfNeeded);
            /*0x3a196cc*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
            /*0x3a197d8*/ bool IsPopulated(System.Type type);
            /*0x3a1a270*/ void Refresh(System.Type type);

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

                /*0x3a1969c*/ ReflectedTypeData(System.Type type);
                /*0x3a19808*/ bool get_IsPopulated();
                /*0x3a15b70*/ System.ComponentModel.AttributeCollection GetAttributes();
                /*0x3a163ac*/ System.ComponentModel.TypeConverter GetConverter(object instance);
                /*0x3a18df0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
                /*0x3a1b1e0*/ System.Type GetTypeFromName(string typeName);
                /*0x3a1a290*/ void Refresh();
            }
        }

        class TypeConverter
        {
            static string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
            static /*0x0*/ bool useCompatibleTypeConversion;

            static /*0x3a1b380*/ bool get_UseCompatibleTypeConversion();
            /*0x3a1c5dc*/ TypeConverter();
            /*0x3a1b3d0*/ bool CanConvertFrom(System.Type sourceType);
            /*0x3a1b3e4*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x3a1b458*/ bool CanConvertTo(System.Type destinationType);
            /*0x3a1b46c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x3a1b4b8*/ object ConvertFrom(object value);
            /*0x3a1b534*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a1ba54*/ object ConvertFromInvariantString(string text);
            /*0x3a1badc*/ object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x3a1bb5c*/ object ConvertFromString(string text);
            /*0x3a1bb74*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x3a1bad0*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text);
            /*0x3a1bbf4*/ object ConvertTo(object value, System.Type destinationType);
            /*0x3a1bc10*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x3a1bf78*/ string ConvertToInvariantString(object value);
            /*0x3a1c084*/ string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x3a1c0fc*/ string ConvertToString(object value);
            /*0x3a1c1c8*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x3a1bfec*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x3a1c2a0*/ object CreateInstance(System.Collections.IDictionary propertyValues);
            /*0x3a1c2b4*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x3a1b930*/ System.Exception GetConvertFromException(object value);
            /*0x3a1be10*/ System.Exception GetConvertToException(object value, System.Type destinationType);
            /*0x3a1c2bc*/ bool GetCreateInstanceSupported();
            /*0x3a1c2cc*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a1c2d4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object value);
            /*0x3a1c2e0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x3a1c3dc*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x3a1c3e4*/ bool GetPropertiesSupported();
            /*0x3a1c3f4*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a1c3fc*/ System.Collections.ICollection GetStandardValues();
            /*0x3a1c40c*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a1c414*/ bool GetStandardValuesExclusive();
            /*0x3a1c428*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a1c430*/ bool GetStandardValuesSupported();
            /*0x3a1c444*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x3a1c44c*/ bool IsValid(object value);
            /*0x3a1c464*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x3a1c5a4*/ System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, string[] names);

            class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x88*/ System.Type componentType;
                /*0x90*/ System.Type propertyType;

                /*0x3a1c5e4*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType);
                /*0x3a1c660*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes);
                /*0x3a1c6ac*/ System.Type get_ComponentType();
                /*0x3a1c6b4*/ bool get_IsReadOnly();
                /*0x3a1c738*/ System.Type get_PropertyType();
                /*0x3a1c740*/ bool CanResetValue(object component);
                /*0x3a1c878*/ void ResetValue(object component);
                /*0x3a1c998*/ bool ShouldSerializeValue(object component);
            }

            class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ICollection values;
                /*0x18*/ System.Array valueArray;

                /*0x3a1c9a0*/ StandardValuesCollection(System.Collections.ICollection values);
                /*0x3a1ca58*/ int get_Count();
                /*0x3a1cb14*/ object get_Item(int index);
                /*0x3a1cd14*/ void CopyTo(System.Array array, int index);
                /*0x3a1cdcc*/ System.Collections.IEnumerator GetEnumerator();
                /*0x3a1ce6c*/ int System.Collections.ICollection.get_Count();
                /*0x3a1ce70*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x3a1ce78*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x3a1ce80*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3a1ce84*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x3a23ad8*/ TypeDescriptor();
            static /*0x3a1ce88*/ System.Type get_ComObjectType();
            static /*0x3a1cee8*/ System.Type get_InterfaceType();
            static /*0x3a1cf48*/ int get_MetadataVersion();
            static /*0x3a1cfa0*/ void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type);
            static /*0x3a1dc90*/ void CheckDefaultProvider(System.Type type);
            static /*0x3a1e2a0*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            static /*0x3a1e5a8*/ System.Collections.ArrayList FilterMembers(System.Collections.IList members, System.Attribute[] attributes);
            static /*0x3a190dc*/ object GetAssociation(System.Type type, object primary);
            static /*0x3a13394*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType);
            static /*0x3a1b188*/ System.ComponentModel.AttributeCollection GetAttributes(object component);
            static /*0x3a1ea5c*/ System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc);
            static /*0x3a16e54*/ System.Collections.IDictionary GetCache(object instance);
            static /*0x3a22128*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x3a1e98c*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Type type, string typeName);
            static /*0x3a1ee74*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc);
            static /*0x3a1f07c*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedDescriptor(object component);
            static /*0x3a22254*/ string GetExtenderCollisionSuffix(System.ComponentModel.MemberDescriptor member);
            static /*0x3a22558*/ System.Type GetNodeForBaseType(System.Type searchType);
            static /*0x3a22630*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component);
            static /*0x3a22688*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc);
            static /*0x3a22d54*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
            static /*0x3a22dbc*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc);
            static /*0x3a226f4*/ System.ComponentModel.PropertyDescriptorCollection GetPropertiesImpl(object component, System.Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes);
            static /*0x3a2347c*/ System.ComponentModel.TypeDescriptionProvider GetProviderRecursive(System.Type type);
            static /*0x3a234d4*/ System.Type GetReflectionType(System.Type type);
            static /*0x3a1e550*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type);
            static /*0x3a1d228*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type, bool createDelegator);
            static /*0x3a220d0*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance);
            static /*0x3a235b0*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator);
            static /*0x3a22e2c*/ System.Collections.ICollection PipelineAttributeFilter(int pipelineType, System.Collections.ICollection members, System.Attribute[] filter, object instance, System.Collections.IDictionary cache);
            static /*0x3a201a0*/ System.Collections.ICollection PipelineFilter(int pipelineType, System.Collections.ICollection members, object instance, System.Collections.IDictionary cache);
            static /*0x3a219bc*/ System.Collections.ICollection PipelineInitialize(int pipelineType, System.Collections.ICollection members, System.Collections.IDictionary cache);
            static /*0x3a1f134*/ System.Collections.ICollection PipelineMerge(int pipelineType, System.Collections.ICollection primary, System.Collections.ICollection secondary, object instance, System.Collections.IDictionary cache);
            static /*0x3a23958*/ void RaiseRefresh(System.Type type);
            static /*0x3a1d724*/ void Refresh(System.Type type);
            static /*0x3a1e900*/ bool ShouldHideMember(System.ComponentModel.MemberDescriptor member, System.Attribute attribute);
            static /*0x3a23a04*/ void SortDescriptorArray(System.Collections.IList infos);

            class AttributeFilterCacheItem
            {
                /*0x10*/ System.Attribute[] _filter;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x3a23794*/ AttributeFilterCacheItem(System.Attribute[] filter, System.Collections.ICollection filteredMembers);
                /*0x3a23720*/ bool IsValid(System.Attribute[] filter);
            }

            class FilterCacheItem
            {
                /*0x10*/ System.ComponentModel.Design.ITypeDescriptorFilterService _filterService;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x3a23914*/ FilterCacheItem(System.ComponentModel.Design.ITypeDescriptorFilterService filterService, System.Collections.ICollection filteredMembers);
                /*0x3a237d8*/ bool IsValid(System.ComponentModel.Design.ITypeDescriptorFilterService filterService);
            }

            interface IUnimplemented
            {
            }

            class MemberDescriptorComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.ComponentModel.TypeDescriptor.MemberDescriptorComparer Instance;

                static /*0x3a23fcc*/ MemberDescriptorComparer();
                /*0x3a23fc4*/ MemberDescriptorComparer();
                /*0x3a23ea8*/ int Compare(object left, object right);
            }

            class MergedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _primary;
                /*0x18*/ System.ComponentModel.ICustomTypeDescriptor _secondary;

                /*0x3a22210*/ MergedTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor primary, System.ComponentModel.ICustomTypeDescriptor secondary);
                /*0x3a24034*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x3a24144*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x3a2425c*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x3a24374*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x3a244a4*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
            }

            class TypeDescriptionNode : System.ComponentModel.TypeDescriptionProvider
            {
                /*0x20*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode Next;
                /*0x28*/ System.ComponentModel.TypeDescriptionProvider Provider;

                /*0x3a1d6f4*/ TypeDescriptionNode(System.ComponentModel.TypeDescriptionProvider provider);
                /*0x3a245d4*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
                /*0x3a24728*/ System.Collections.IDictionary GetCache(object instance);
                /*0x3a24794*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
                /*0x3a2489c*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
                /*0x3a24908*/ System.Type GetReflectionType(System.Type objectType, object instance);
                /*0x3a249bc*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

                struct DefaultExtendedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ object _instance;

                    /*0x3a2486c*/ DefaultExtendedTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, object instance);
                    /*0x3a24b64*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x3a24e28*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x3a250b4*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x3a25340*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x3a255d4*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                }

                struct DefaultTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ System.Type _objectType;
                    /*0x20*/ object _instance;

                    /*0x3a24b20*/ DefaultTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Type objectType, object instance);
                    /*0x3a257e4*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x3a25a70*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x3a25cfc*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x3a25f8c*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x3a26224*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
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

            static /*0x3a264dc*/ string GetErrorMessage(int error);
            /*0x3a26430*/ Win32Exception();
            /*0x3a264a4*/ Win32Exception(int error);
            /*0x3a26dd4*/ Win32Exception(int error, string message);
            /*0x3a26e00*/ Win32Exception(string message);
            /*0x3a26e7c*/ Win32Exception(string message, System.Exception innerException);
            /*0x3a26efc*/ Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x3a26f84*/ int get_NativeErrorCode();
            /*0x3a26f8c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class NotifyParentPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.NotifyParentPropertyAttribute Yes;
            static /*0x8*/ System.ComponentModel.NotifyParentPropertyAttribute No;
            static /*0x10*/ System.ComponentModel.NotifyParentPropertyAttribute Default;
            /*0x10*/ bool notifyParent;

            static /*0x3a27174*/ NotifyParentPropertyAttribute();
            /*0x3a27054*/ NotifyParentPropertyAttribute(bool notifyParent);
            /*0x3a2707c*/ bool get_NotifyParent();
            /*0x3a27084*/ bool Equals(object obj);
            /*0x3a27104*/ int GetHashCode();
            /*0x3a2710c*/ bool IsDefaultAttribute();
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

            static /*0x3a27334*/ RefreshPropertiesAttribute();
            /*0x3a27224*/ RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh);
            /*0x3a2724c*/ System.ComponentModel.RefreshProperties get_RefreshProperties();
            /*0x3a27254*/ bool Equals(object value);
            /*0x3a272c4*/ int GetHashCode();
            /*0x3a272cc*/ bool IsDefaultAttribute();
        }

        class WeakHashtable : System.Collections.Hashtable
        {
            static /*0x0*/ System.Collections.IEqualityComparer _comparer;

            static /*0x3a27410*/ WeakHashtable();
            /*0x3a23e44*/ WeakHashtable();
            /*0x3a27400*/ void Clear();
            /*0x3a27408*/ void Remove(object key);

            class WeakKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x3a2748c*/ WeakKeyComparer();
                /*0x3a27494*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
                /*0x3a275f0*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
            }
        }

        namespace Design
        {
            class CheckoutException : System.Runtime.InteropServices.ExternalException
            {
                static /*0x0*/ System.ComponentModel.Design.CheckoutException Canceled;

                static /*0x3a27628*/ CheckoutException();
                /*0x3a27610*/ CheckoutException();
                /*0x3a27618*/ CheckoutException(string message, int errorCode);
                /*0x3a27620*/ CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            interface IComponentChangeService
            {
                /*0x1f31134*/ void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
                /*0x1f30ff0*/ void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
            }

            interface IDesigner : System.IDisposable
            {
            }

            interface IDesignerHost : System.IServiceProvider
            {
                /*0x1f30214*/ System.ComponentModel.IComponent get_RootComponent();
                /*0x1f302cc*/ System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
            }

            interface IDictionaryService
            {
                /*0x1f302cc*/ object GetValue(object key);
                /*0x1f30ff0*/ void SetValue(object key, object value);
            }

            interface IExtenderListService
            {
                /*0x1f30214*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
            }

            interface IReferenceService
            {
                /*0x1f302cc*/ object GetReference(string name);
                /*0x1f302cc*/ string GetName(object reference);
                /*0x1f302cc*/ object[] GetReferences(System.Type baseType);
            }

            interface ITypeDescriptorFilterService
            {
                /*0x1f2ff00*/ bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
                /*0x1f2ff00*/ bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
                /*0x1f2ff00*/ bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
            }

            class DesignerOptionService
            {
                /*0x3a276b0*/ void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options);

                class DesignerOptionCollection : System.Collections.ICollection
                {
                    /*0x10*/ System.ComponentModel.Design.DesignerOptionService _service;
                    /*0x18*/ string _name;
                    /*0x20*/ object _value;
                    /*0x28*/ System.Collections.ArrayList _children;
                    /*0x30*/ System.ComponentModel.PropertyDescriptorCollection _properties;

                    /*0x3a276b4*/ int get_Count();
                    /*0x3a27780*/ string get_Name();
                    /*0x3a27788*/ System.ComponentModel.PropertyDescriptorCollection get_Properties();
                    /*0x3a27ed0*/ void CopyTo(System.Array array, int index);
                    /*0x3a276e0*/ void EnsurePopulated();
                    /*0x3a27f14*/ System.Collections.IEnumerator GetEnumerator();
                    /*0x3a27f40*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x3a27f48*/ object System.Collections.ICollection.get_SyncRoot();

                    class WrappedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ object target;
                        /*0x90*/ System.ComponentModel.PropertyDescriptor property;

                        /*0x3a27e68*/ WrappedPropertyDescriptor(System.ComponentModel.PropertyDescriptor property, object target);
                        /*0x3a27f4c*/ System.ComponentModel.AttributeCollection get_Attributes();
                        /*0x3a27f68*/ System.Type get_ComponentType();
                        /*0x3a27f88*/ bool get_IsReadOnly();
                        /*0x3a27fa8*/ System.Type get_PropertyType();
                        /*0x3a27fc8*/ bool CanResetValue(object component);
                        /*0x3a27ff0*/ object GetValue(object component);
                        /*0x3a28018*/ void ResetValue(object component);
                        /*0x3a28040*/ void SetValue(object component, object value);
                        /*0x3a28068*/ bool ShouldSerializeValue(object component);
                    }
                }

                class DesignerOptionConverter : System.ComponentModel.TypeConverter
                {
                    /*0x3a286f4*/ DesignerOptionConverter();
                    /*0x3a28090*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext cxt);
                    /*0x3a28098*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext cxt, object value, System.Attribute[] attributes);
                    /*0x3a2863c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext cxt, System.Globalization.CultureInfo culture, object value, System.Type destinationType);

                    class OptionPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection _option;

                        /*0x3a285fc*/ OptionPropertyDescriptor(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection option);
                        /*0x3a286fc*/ System.Type get_ComponentType();
                        /*0x3a28714*/ bool get_IsReadOnly();
                        /*0x3a2871c*/ System.Type get_PropertyType();
                        /*0x3a28734*/ bool CanResetValue(object component);
                        /*0x3a2873c*/ object GetValue(object component);
                        /*0x3a28744*/ void ResetValue(object component);
                        /*0x3a28748*/ void SetValue(object component, object value);
                        /*0x3a2874c*/ bool ShouldSerializeValue(object component);
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

                    /*0x3a28754*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments);
                    /*0x3a2875c*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete);
                    /*0x3a28ca0*/ System.Collections.ICollection get_Arguments();
                    /*0x3a28ca8*/ System.Reflection.MemberInfo get_MemberInfo();
                    /*0x3a1b59c*/ object Invoke();
                }

                class RootDesignerSerializerAttribute : System.Attribute
                {
                    /*0x10*/ string _typeId;
                    /*0x18*/ bool <Reloadable>k__BackingField;
                    /*0x20*/ string <SerializerTypeName>k__BackingField;
                    /*0x28*/ string <SerializerBaseTypeName>k__BackingField;

                    /*0x3a28cb0*/ RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable);
                    /*0x3a28d08*/ string get_SerializerBaseTypeName();
                    /*0x3a28d10*/ object get_TypeId();
                }
            }
        }
    }

    namespace Collections
    {
        class HashtableExtensions
        {
            static /*0x1f319c4*/ bool TryGetValue<T>(System.Collections.Hashtable table, object key, ref T value);
        }

        namespace Specialized
        {
            struct BitVector32
            {
                /*0x10*/ uint _data;

                static /*0x3a14bd0*/ int CreateMask();
                static /*0x3a14bd8*/ int CreateMask(int previous);
                static /*0x3a28e8c*/ string ToString(System.Collections.Specialized.BitVector32 value);
                /*0x3a104e8*/ bool get_Item(int bit);
                /*0x3a10278*/ void set_Item(int bit, bool value);
                /*0x3a28db0*/ bool Equals(object o);
                /*0x3a28e28*/ int GetHashCode();
                /*0x3a28f5c*/ string ToString();
            }

            class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase
            {
                /*0x50*/ string[] _all;
                /*0x58*/ string[] _allKeys;

                static /*0x3a29184*/ string GetAsOneString(System.Collections.ArrayList list);
                static /*0x3a29320*/ string[] GetAsStringArray(System.Collections.ArrayList list);
                /*0x3a28f64*/ NameValueCollection();
                /*0x3a29018*/ NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x3a290b8*/ NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3a29f00*/ NameValueCollection(System.DBNull dummy);
                /*0x3a2915c*/ void InvalidateCachedArrays();
                /*0x3a293c0*/ void Add(string name, string value);
                /*0x3a296c4*/ string Get(string name);
                /*0x3a29750*/ string[] GetValues(string name);
                /*0x3a297dc*/ void Set(string name, string value);
                /*0x3a29990*/ void Remove(string name);
                /*0x3a29bf0*/ string get_Item(string name);
                /*0x3a29c00*/ void set_Item(string name, string value);
                /*0x3a29c10*/ string Get(int index);
                /*0x3a29d30*/ string GetKey(int index);
                /*0x3a29dd0*/ string get_Item(int index);
                /*0x3a29de0*/ string[] get_AllKeys();
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

                /*0x3a29f60*/ OrderedDictionary();
                /*0x3a1af0c*/ OrderedDictionary(int capacity);
                /*0x3a29f88*/ OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer);
                /*0x3a29fc0*/ OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3a1b0e8*/ int get_Count();
                /*0x3a2a074*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x3a2a07c*/ bool get_IsReadOnly();
                /*0x3a2a084*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x3a2a08c*/ System.Collections.ICollection get_Keys();
                /*0x3a29ff0*/ System.Collections.ArrayList get_objectsArray();
                /*0x3a2a148*/ System.Collections.Hashtable get_objectsTable();
                /*0x3a2a1d4*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x3a2a248*/ object get_Item(int index);
                /*0x3a237e8*/ object get_Item(object key);
                /*0x3a1af6c*/ void set_Item(object key, object value);
                /*0x3a1b10c*/ System.Collections.ICollection get_Values();
                /*0x3a2a458*/ void Add(object key, object value);
                /*0x3a2a57c*/ void Clear();
                /*0x3a1af40*/ bool Contains(object key);
                /*0x3a2a610*/ void CopyTo(System.Array array, int index);
                /*0x3a2a2d8*/ int IndexOfKey(object key);
                /*0x3a23814*/ void Remove(object key);
                /*0x3a2a64c*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x3a2a710*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3a2a77c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3a2a944*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x3a2a954*/ void OnDeserialization(object sender);

                class OrderedDictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ int _objectReturnType;
                    /*0x18*/ System.Collections.IEnumerator _arrayEnumerator;

                    /*0x3a2a6b8*/ OrderedDictionaryEnumerator(System.Collections.ArrayList array, int objectReturnType);
                    /*0x3a2ad4c*/ object get_Current();
                    /*0x3a2af10*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x3a2b0a4*/ object get_Key();
                    /*0x3a2b188*/ object get_Value();
                    /*0x3a2b26c*/ bool MoveNext();
                    /*0x3a2b30c*/ void Reset();
                }

                class OrderedDictionaryKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _objects;
                    /*0x18*/ bool _isKeys;

                    /*0x3a2a10c*/ OrderedDictionaryKeyValueCollection(System.Collections.ArrayList array, bool isKeys);
                    /*0x3a2b3b0*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x3a2b774*/ int System.Collections.ICollection.get_Count();
                    /*0x3a2b794*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x3a2b79c*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x3a2b7bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class StringCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ArrayList data;

                /*0x3a2bbf8*/ StringCollection();
                /*0x3a2b82c*/ string get_Item(int index);
                /*0x3a2b874*/ void set_Item(int index, string value);
                /*0x3a2b894*/ int get_Count();
                /*0x3a2b8b4*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x3a2b8bc*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x3a2b8c4*/ int Add(string value);
                /*0x3a2b8e4*/ void Clear();
                /*0x3a2b904*/ bool Contains(string value);
                /*0x3a2b924*/ void CopyTo(string[] array, int index);
                /*0x3a2b944*/ int IndexOf(string value);
                /*0x3a2b964*/ void Insert(int index, string value);
                /*0x3a2b984*/ bool get_IsSynchronized();
                /*0x3a2b98c*/ void Remove(string value);
                /*0x3a2b9ac*/ void RemoveAt(int index);
                /*0x3a2b9cc*/ object get_SyncRoot();
                /*0x3a2b9ec*/ object System.Collections.IList.get_Item(int index);
                /*0x3a2b9f0*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x3a2ba3c*/ int System.Collections.IList.Add(object value);
                /*0x3a2ba88*/ bool System.Collections.IList.Contains(object value);
                /*0x3a2bad4*/ int System.Collections.IList.IndexOf(object value);
                /*0x3a2bb20*/ void System.Collections.IList.Insert(int index, object value);
                /*0x3a2bb6c*/ void System.Collections.IList.Remove(object value);
                /*0x3a2bbb8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3a2bbd8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class StringDictionary : System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable contents;

                /*0x3a2bc64*/ StringDictionary();
                /*0x3a2bcd0*/ void Add(string key, string value);
                /*0x3a2bd64*/ System.Collections.IEnumerator GetEnumerator();
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

                /*0x3a2bd84*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action);
                /*0x3a2bf30*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index);
                /*0x3a2c120*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem, int index);
                /*0x3a2c354*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex);
                /*0x3a2c108*/ void InitializeAddOrRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int startingIndex);
                /*0x3a2be94*/ void InitializeAdd(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, int newStartingIndex);
                /*0x3a2c504*/ void InitializeRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList oldItems, int oldStartingIndex);
                /*0x3a2c310*/ void InitializeMoveOrReplace(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex, int oldStartingIndex);
            }

            class NotifyCollectionChangedEventHandler : System.MulticastDelegate
            {
                /*0x3a2c5d0*/ NotifyCollectionChangedEventHandler(object object, nint method);
                /*0x3a2c6dc*/ void Invoke(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
            }

            class ReadOnlyList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.IList _list;

                /*0x3a2c5a0*/ ReadOnlyList(System.Collections.IList list);
                /*0x3a2c6f0*/ int get_Count();
                /*0x3a2c794*/ bool get_IsReadOnly();
                /*0x3a2c79c*/ bool get_IsFixedSize();
                /*0x3a2c7a4*/ bool get_IsSynchronized();
                /*0x3a2c848*/ object get_Item(int index);
                /*0x3a2c8f0*/ void set_Item(int index, object value);
                /*0x3a2c93c*/ object get_SyncRoot();
                /*0x3a2c9e0*/ int Add(object value);
                /*0x3a2ca2c*/ void Clear();
                /*0x3a2ca78*/ bool Contains(object value);
                /*0x3a2cb24*/ void CopyTo(System.Array array, int index);
                /*0x3a2cbdc*/ System.Collections.IEnumerator GetEnumerator();
                /*0x3a2cc7c*/ int IndexOf(object value);
                /*0x3a2cd28*/ void Insert(int index, object value);
                /*0x3a2cd74*/ void Remove(object value);
                /*0x3a2cdc0*/ void RemoveAt(int index);
            }

            class CaseSensitiveStringDictionary : System.Collections.Specialized.StringDictionary
            {
                /*0x3a2ce0c*/ CaseSensitiveStringDictionary();
                /*0x3a2ce10*/ void Add(string key, string value);
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

                static /*0x3a2e31c*/ NameObjectCollectionBase();
                /*0x3a28fb8*/ NameObjectCollectionBase();
                /*0x3a2ce80*/ NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer);
                /*0x3a2908c*/ NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x3a29f58*/ NameObjectCollectionBase(System.DBNull dummy);
                /*0x3a2912c*/ NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3a2d0b8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3a2d658*/ void OnDeserialization(object sender);
                /*0x3a2cf0c*/ void Reset();
                /*0x3a2cfdc*/ void Reset(int capacity);
                /*0x3a2ddc4*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(string key);
                /*0x3a2de7c*/ bool get_IsReadOnly();
                /*0x3a2955c*/ void BaseAdd(string name, object value);
                /*0x3a299d0*/ void BaseRemove(string name);
                /*0x3a29544*/ object BaseGet(string name);
                /*0x3a298e0*/ void BaseSet(string name, object value);
                /*0x3a29c94*/ object BaseGet(int index);
                /*0x3a29d34*/ string BaseGetKey(int index);
                /*0x3a2dec8*/ System.Collections.IEnumerator GetEnumerator();
                /*0x3a2df74*/ int get_Count();
                /*0x3a2df94*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3a2e2a0*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x3a2e314*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x3a29e20*/ string[] BaseGetAllKeys();

                class NameObjectEntry
                {
                    /*0x10*/ string Key;
                    /*0x18*/ object Value;

                    /*0x3a2de84*/ NameObjectEntry(string name, object value);
                }

                class NameObjectKeysEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ int _pos;
                    /*0x18*/ System.Collections.Specialized.NameObjectCollectionBase _coll;
                    /*0x20*/ int _version;

                    /*0x3a2df20*/ NameObjectKeysEnumerator(System.Collections.Specialized.NameObjectCollectionBase coll);
                    /*0x3a2e3cc*/ bool MoveNext();
                    /*0x3a2e4a4*/ void Reset();
                    /*0x3a2e52c*/ object get_Current();
                }
            }

            class CompatibleComparer : System.Collections.IEqualityComparer
            {
                static /*0x0*/ System.Collections.IComparer defaultComparer;
                static /*0x8*/ System.Collections.IHashCodeProvider defaultHashProvider;
                /*0x10*/ System.Collections.IComparer _comparer;
                /*0x18*/ System.Collections.IHashCodeProvider _hcp;

                static /*0x3a2e928*/ System.Collections.IComparer get_DefaultComparer();
                static /*0x3a2ea0c*/ System.Collections.IHashCodeProvider get_DefaultHashCodeProvider();
                /*0x3a2e5cc*/ CompatibleComparer(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider);
                /*0x3a2e610*/ bool Equals(object a, object b);
                /*0x3a2e810*/ int GetHashCode(object obj);
                /*0x3a2e918*/ System.Collections.IComparer get_Comparer();
                /*0x3a2e920*/ System.Collections.IHashCodeProvider get_HashCodeProvider();
            }
        }

        namespace Concurrent
        {
            class CDSCollectionETWBCLProvider : System.Diagnostics.Tracing.EventSource
            {
                static /*0x0*/ System.Collections.Concurrent.CDSCollectionETWBCLProvider Log;

                static /*0x3a2eb60*/ CDSCollectionETWBCLProvider();
                /*0x3a2eae8*/ CDSCollectionETWBCLProvider();
                /*0x3a2eaf0*/ void ConcurrentBag_TryTakeSteals();
                /*0x3a2eb28*/ void ConcurrentBag_TryPeekSteals();
            }

            class ConcurrentBag<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>
            {
                /*0x0*/ System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>> _locals;
                /*0x0*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> _workStealingQueues;
                /*0x0*/ long _emptyToNonEmptyListTransitionCount;

                /*0x1f309e4*/ ConcurrentBag();
                /*0x1ffc854*/ void Add(T item);
                /*0x1f2fec8*/ bool TryTake(ref T result);
                System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate);
                /*0x1f30214*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread();
                /*0x1f30214*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue();
                bool TrySteal(ref T result, bool take);
                /*0x1ffc854*/ bool TryStealFromTo(System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> startInclusive, System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> endExclusive, ref T result, bool take);
                /*0x1f30ee8*/ void CopyTo(T[] array, int index);
                int CopyFromEachQueueToArray(T[] array, int index);
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1f30214*/ T[] ToArray();
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2ffc8*/ int get_DangerousCount();
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f30214*/ object get_GlobalQueuesLock();
                /*0x1f30ebc*/ void FreezeBag(ref bool lockTaken);
                /*0x1f30a84*/ void UnfreezeBag(bool lockTaken);

                class WorkStealingQueue<T>
                {
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

                    /*0x1f30ebc*/ WorkStealingQueue(System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> nextQueue);
                    /*0x1ffc854*/ void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount);
                    /*0x1f2fec8*/ bool TryLocalPop(ref T result);
                    bool TrySteal(ref T result, bool take);
                    int DangerousCopyTo(T[] array, int arrayIndex);
                    /*0x1f2ffc8*/ int get_DangerousCount();
                }

                class Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ T[] _array;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    /*0x1f30ebc*/ Enumerator(T[] array);
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1ffc854*/ T get_Current();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1f309e4*/ void Reset();
                    /*0x1f309e4*/ void Dispose();
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

                /*0x1ffc854*/ ValueListBuilder(System.Span<T> initialSpan);
                /*0x1f2ffc8*/ int get_Length();
                /*0x1f30240*/ ref T get_Item(int index);
                /*0x1ffc854*/ void Append(T item);
                /*0x1ffc854*/ System.ReadOnlySpan<T> AsSpan();
                /*0x1f309e4*/ void Dispose();
                /*0x1f309e4*/ void Grow();
                /*0x1ffc854*/ T Pop();
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

                /*0x1f309e4*/ LinkedList();
                LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f30214*/ System.Collections.Generic.LinkedListNode<T> get_First();
                /*0x1f30214*/ System.Collections.Generic.LinkedListNode<T> get_Last();
                /*0x1f2fe14*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x1ffc854*/ void System.Collections.Generic.ICollection<T>.Add(T value);
                /*0x1f30ff0*/ void AddBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x1ffc854*/ System.Collections.Generic.LinkedListNode<T> AddFirst(T value);
                /*0x1f30ebc*/ void AddFirst(System.Collections.Generic.LinkedListNode<T> node);
                /*0x1ffc854*/ System.Collections.Generic.LinkedListNode<T> AddLast(T value);
                /*0x1f30ebc*/ void AddLast(System.Collections.Generic.LinkedListNode<T> node);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool Contains(T value);
                /*0x1f30ee8*/ void CopyTo(T[] array, int index);
                /*0x1ffc854*/ System.Collections.Generic.LinkedListNode<T> Find(T value);
                /*0x1ffc854*/ System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1ffc854*/ bool Remove(T value);
                /*0x1f30ebc*/ void Remove(System.Collections.Generic.LinkedListNode<T> node);
                /*0x1f309e4*/ void RemoveFirst();
                /*0x1f309e4*/ void RemoveLast();
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1f30ebc*/ void OnDeserialization(object sender);
                /*0x1f30ff0*/ void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x1f30ebc*/ void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x1f30ebc*/ void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x1f30ebc*/ void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x1f30ebc*/ void ValidateNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    /*0x0*/ System.Collections.Generic.LinkedList<T> _list;
                    /*0x0*/ System.Collections.Generic.LinkedListNode<T> _node;
                    /*0x0*/ int _version;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    /*0x1f30ebc*/ Enumerator(System.Collections.Generic.LinkedList<T> list);
                    Enumerator(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x1ffc854*/ T get_Current();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                    /*0x1f309e4*/ void Dispose();
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x1f30ebc*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                }
            }

            class LinkedListNode<T>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<T> list;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> next;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> prev;
                /*0x0*/ T item;

                /*0x1ffc854*/ LinkedListNode(T value);
                /*0x1ffc854*/ LinkedListNode(System.Collections.Generic.LinkedList<T> list, T value);
                /*0x1f30214*/ System.Collections.Generic.LinkedList<T> get_List();
                /*0x1f30214*/ System.Collections.Generic.LinkedListNode<T> get_Next();
                /*0x1f30214*/ System.Collections.Generic.LinkedListNode<T> get_Previous();
                /*0x1ffc854*/ T get_Value();
                /*0x1ffc854*/ void set_Value(T value);
                /*0x1f309e4*/ void Invalidate();
            }

            class SortedDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> _keys;
                /*0x0*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> _values;
                /*0x0*/ System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey, TValue>> _set;

                static /*0x1f31840*/ bool IsCompatibleKey(object key);
                /*0x1f309e4*/ SortedDictionary();
                /*0x1f30ebc*/ SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer);
                /*0x1ffc854*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x1ffc854*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x1ffc854*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x1f2fe14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x1ffc854*/ TValue get_Item(TKey key);
                /*0x1ffc854*/ void set_Item(TKey key, TValue value);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f30214*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> get_Keys();
                /*0x1f30214*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                /*0x1f30214*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> get_Values();
                /*0x1f30214*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                /*0x1ffc854*/ void Add(TKey key, TValue value);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool ContainsKey(TKey key);
                /*0x1ffc854*/ bool ContainsValue(TValue value);
                /*0x1f30ee8*/ void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int index);
                /*0x1ffc854*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x1ffc854*/ bool Remove(TKey key);
                /*0x1ffc854*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1f2fe14*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x1f2fe14*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x1f302cc*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x1f30ff0*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x1f30ff0*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x1f2fec8*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x1f30214*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x1f30ebc*/ void System.Collections.IDictionary.Remove(object key);
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedSet.Enumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _treeEnum;
                    /*0x0*/ int _getEnumeratorRetType;

                    /*0x1f30ee8*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f309e4*/ void Dispose();
                    /*0x1ffc854*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x1f2fe14*/ bool get_NotStartedOrEnded();
                    /*0x1f309e4*/ void Reset();
                    /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1f30214*/ object System.Collections.IDictionaryEnumerator.get_Key();
                    /*0x1f30214*/ object System.Collections.IDictionaryEnumerator.get_Value();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                }

                class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TKey>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    /*0x1f30ebc*/ KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    /*0x1f30214*/ System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator();
                    /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x1f30ee8*/ void CopyTo(TKey[] array, int index);
                    /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x1f2ffc8*/ int get_Count();
                    /*0x1f2fe14*/ bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly();
                    /*0x1ffc854*/ void System.Collections.Generic.ICollection<TKey>.Add(TKey item);
                    /*0x1f309e4*/ void System.Collections.Generic.ICollection<TKey>.Clear();
                    /*0x1ffc854*/ bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item);
                    /*0x1ffc854*/ bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item);
                    /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        /*0x1f30ebc*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        /*0x1f309e4*/ void Dispose();
                        /*0x1f2fe14*/ bool MoveNext();
                        /*0x1ffc854*/ TKey get_Current();
                        /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                        /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TKey[] array;
                        /*0x0*/ int index;

                        /*0x1f309e4*/ <>c__DisplayClass5_0();
                        /*0x1f2fec8*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        /*0x1f309e4*/ <>c__DisplayClass6_0();
                        /*0x1f2fec8*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TValue>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    /*0x1f30ebc*/ ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    /*0x1f30214*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x1f30ee8*/ void CopyTo(TValue[] array, int index);
                    /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x1f2ffc8*/ int get_Count();
                    /*0x1f2fe14*/ bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly();
                    /*0x1ffc854*/ void System.Collections.Generic.ICollection<TValue>.Add(TValue item);
                    /*0x1f309e4*/ void System.Collections.Generic.ICollection<TValue>.Clear();
                    /*0x1ffc854*/ bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item);
                    /*0x1ffc854*/ bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item);
                    /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        /*0x1f30ebc*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        /*0x1f309e4*/ void Dispose();
                        /*0x1f2fe14*/ bool MoveNext();
                        /*0x1ffc854*/ TValue get_Current();
                        /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                        /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TValue[] array;
                        /*0x0*/ int index;

                        /*0x1f309e4*/ <>c__DisplayClass5_0();
                        /*0x1f2fec8*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        /*0x1f309e4*/ <>c__DisplayClass6_0();
                        /*0x1f2fec8*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class KeyValuePairComparer<TKey, TValue> : System.Collections.Generic.Comparer<System.Collections.Generic.KeyValuePair<TKey, TValue>>
                {
                    /*0x0*/ System.Collections.Generic.IComparer<TKey> keyComparer;

                    /*0x1f30ebc*/ KeyValuePairComparer(System.Collections.Generic.IComparer<TKey> keyComparer);
                    /*0x1ffc854*/ int Compare(System.Collections.Generic.KeyValuePair<TKey, TValue> x, System.Collections.Generic.KeyValuePair<TKey, TValue> y);
                }

                class <>c__DisplayClass34_0<TKey, TValue>
                {
                    /*0x0*/ bool found;
                    /*0x0*/ TValue value;

                    /*0x1f309e4*/ <>c__DisplayClass34_0();
                    /*0x1f2fec8*/ bool <ContainsValue>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }

                class <>c__DisplayClass34_1<TKey, TValue>
                {
                    /*0x0*/ System.Collections.Generic.EqualityComparer<TValue> valueComparer;
                    /*0x0*/ System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1;

                    /*0x1f309e4*/ <>c__DisplayClass34_1();
                    /*0x1f2fec8*/ bool <ContainsValue>b__1(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }
            }

            class TreeSet<T> : System.Collections.Generic.SortedSet<T>
            {
                /*0x1f309e4*/ TreeSet();
                /*0x1f30ebc*/ TreeSet(System.Collections.Generic.IComparer<T> comparer);
                TreeSet(System.Runtime.Serialization.SerializationInfo siInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x1ffc854*/ bool AddIfNotPresent(T item);
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

                static /*0x1f31840*/ bool IsCompatibleKey(object key);
                /*0x1f309e4*/ SortedList();
                /*0x1f30b78*/ SortedList(int capacity);
                /*0x1f30ebc*/ SortedList(System.Collections.Generic.IComparer<TKey> comparer);
                /*0x1ffc854*/ void Add(TKey key, TValue value);
                /*0x1ffc854*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x1ffc854*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x1ffc854*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x1f30b78*/ void set_Capacity(int value);
                /*0x1f30ff0*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f30214*/ System.Collections.Generic.IList<TKey> get_Keys();
                /*0x1f30214*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                /*0x1f30214*/ System.Collections.Generic.IList<TValue> get_Values();
                /*0x1f30214*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                /*0x1f30214*/ System.Collections.Generic.SortedList.KeyList<TKey, TValue> GetKeyListHelper();
                /*0x1f30214*/ System.Collections.Generic.SortedList.ValueList<TKey, TValue> GetValueListHelper();
                /*0x1f2fe14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x1f2fe14*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x1f2fe14*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f309e4*/ void Clear();
                /*0x1f2fec8*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x1ffc854*/ bool ContainsKey(TKey key);
                /*0x1ffc854*/ bool ContainsValue(TValue value);
                /*0x1f30ee8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1f30b78*/ void EnsureCapacity(int min);
                /*0x1ffc854*/ TValue GetByIndex(int index);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x1f30214*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1ffc854*/ TKey GetKey(int index);
                /*0x1ffc854*/ TValue get_Item(TKey key);
                /*0x1ffc854*/ void set_Item(TKey key, TValue value);
                /*0x1f302cc*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x1f30ff0*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x1ffc854*/ int IndexOfKey(TKey key);
                /*0x1ffc854*/ int IndexOfValue(TValue value);
                /*0x1ffc854*/ void Insert(int index, TKey key, TValue value);
                /*0x1ffc854*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x1f30b78*/ void RemoveAt(int index);
                /*0x1ffc854*/ bool Remove(TKey key);
                /*0x1f30ebc*/ void System.Collections.IDictionary.Remove(object key);

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ TKey _key;
                    /*0x0*/ TValue _value;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ int _getEnumeratorRetType;

                    /*0x1f30ee8*/ Enumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList, int getEnumeratorRetType);
                    /*0x1f309e4*/ void Dispose();
                    /*0x1f30214*/ object System.Collections.IDictionaryEnumerator.get_Key();
                    /*0x1f2fe14*/ bool MoveNext();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                    /*0x1ffc854*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1f30214*/ object System.Collections.IDictionaryEnumerator.get_Value();
                    /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListKeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TKey _currentKey;

                    /*0x1f30ebc*/ SortedListKeyEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x1f309e4*/ void Dispose();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1ffc854*/ TKey get_Current();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TValue _currentValue;

                    /*0x1f30ebc*/ SortedListValueEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x1f309e4*/ void Dispose();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1ffc854*/ TValue get_Current();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                }

                class KeyList<TKey, TValue> : System.Collections.Generic.IList<TKey>, System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x1f30ebc*/ KeyList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x1f2ffc8*/ int get_Count();
                    /*0x1f2fe14*/ bool get_IsReadOnly();
                    /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x1ffc854*/ void Add(TKey key);
                    /*0x1f309e4*/ void Clear();
                    /*0x1ffc854*/ bool Contains(TKey key);
                    /*0x1f30ee8*/ void CopyTo(TKey[] array, int arrayIndex);
                    /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    /*0x1ffc854*/ void Insert(int index, TKey value);
                    /*0x1ffc854*/ TKey get_Item(int index);
                    /*0x1ffc854*/ void set_Item(int index, TKey value);
                    /*0x1f30214*/ System.Collections.Generic.IEnumerator<TKey> GetEnumerator();
                    /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x1ffc854*/ int IndexOf(TKey key);
                    /*0x1ffc854*/ bool Remove(TKey key);
                    /*0x1f30b78*/ void RemoveAt(int index);
                }

                class ValueList<TKey, TValue> : System.Collections.Generic.IList<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x1f30ebc*/ ValueList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x1f2ffc8*/ int get_Count();
                    /*0x1f2fe14*/ bool get_IsReadOnly();
                    /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x1ffc854*/ void Add(TValue key);
                    /*0x1f309e4*/ void Clear();
                    /*0x1ffc854*/ bool Contains(TValue value);
                    /*0x1f30ee8*/ void CopyTo(TValue[] array, int arrayIndex);
                    /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x1ffc854*/ void Insert(int index, TValue value);
                    /*0x1ffc854*/ TValue get_Item(int index);
                    /*0x1ffc854*/ void set_Item(int index, TValue value);
                    /*0x1f30214*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                    /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x1ffc854*/ int IndexOf(TValue value);
                    /*0x1ffc854*/ bool Remove(TValue value);
                    /*0x1f30b78*/ void RemoveAt(int index);
                }
            }

            class SortedSet<T> : System.Collections.Generic.ISet<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                static string ComparerName = "Comparer";
                static string CountName = "Count";
                static string ItemsName = "Items";
                static string VersionName = "Version";
                static string TreeName = "Tree";
                static string NodeValueName = "Item";
                static string EnumStartName = "EnumStarted";
                static string ReverseName = "Reverse";
                static string EnumVersionName = "EnumVersion";
                static string MinName = "Min";
                static string MaxName = "Max";
                static string LowerBoundActiveName = "lBoundActive";
                static string UpperBoundActiveName = "uBoundActive";
                static int StackAllocThreshold = 100;
                /*0x0*/ System.Collections.Generic.SortedSet.Node<T> root;
                /*0x0*/ System.Collections.Generic.IComparer<T> comparer;
                /*0x0*/ int count;
                /*0x0*/ int version;
                /*0x0*/ object _syncRoot;
                /*0x0*/ System.Runtime.Serialization.SerializationInfo siInfo;

                static /*0x1f31e40*/ int Log2(int value);
                /*0x1f309e4*/ SortedSet();
                /*0x1f30ebc*/ SortedSet(System.Collections.Generic.IComparer<T> comparer);
                SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1f2fec8*/ bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2fe14*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f309e4*/ void VersionCheck();
                /*0x1ffc854*/ bool IsWithinRange(T item);
                /*0x1ffc854*/ bool Add(T item);
                /*0x1ffc854*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                /*0x1ffc854*/ bool AddIfNotPresent(T item);
                /*0x1ffc854*/ bool Remove(T item);
                /*0x1ffc854*/ bool DoRemove(T item);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool Contains(T item);
                /*0x1f30ee8*/ void CopyTo(T[] array, int index);
                void CopyTo(T[] array, int index, int count);
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1ffc854*/ System.Collections.Generic.SortedSet.Enumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f31134*/ void InsertionBalance(System.Collections.Generic.SortedSet.Node<T> current, ref System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> grandParent, System.Collections.Generic.SortedSet.Node<T> greatGrandParent);
                /*0x1f310fc*/ void ReplaceChildOrRoot(System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                /*0x1f31134*/ void ReplaceNode(System.Collections.Generic.SortedSet.Node<T> match, System.Collections.Generic.SortedSet.Node<T> parentOfMatch, System.Collections.Generic.SortedSet.Node<T> successor, System.Collections.Generic.SortedSet.Node<T> parentOfSuccessor);
                /*0x1ffc854*/ System.Collections.Generic.SortedSet.Node<T> FindNode(T item);
                /*0x1f309e4*/ void UpdateVersion();
                void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1f30ebc*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x1f30ebc*/ void OnDeserialization(object sender);

                class Node<T>
                {
                    /*0x0*/ T <Item>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Left>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Right>k__BackingField;
                    /*0x0*/ System.Collections.Generic.NodeColor <Color>k__BackingField;

                    static /*0x1f31840*/ bool IsNonNullRed(System.Collections.Generic.SortedSet.Node<T> node);
                    static /*0x1f31840*/ bool IsNullOrBlack(System.Collections.Generic.SortedSet.Node<T> node);
                    /*0x1ffc854*/ Node(T item, System.Collections.Generic.NodeColor color);
                    /*0x1ffc854*/ T get_Item();
                    /*0x1ffc854*/ void set_Item(T value);
                    /*0x1f30214*/ System.Collections.Generic.SortedSet.Node<T> get_Left();
                    /*0x1f30ebc*/ void set_Left(System.Collections.Generic.SortedSet.Node<T> value);
                    /*0x1f30214*/ System.Collections.Generic.SortedSet.Node<T> get_Right();
                    /*0x1f30ebc*/ void set_Right(System.Collections.Generic.SortedSet.Node<T> value);
                    /*0x1f2fe14*/ System.Collections.Generic.NodeColor get_Color();
                    /*0x1f30a84*/ void set_Color(System.Collections.Generic.NodeColor value);
                    /*0x1f2fe14*/ bool get_IsBlack();
                    /*0x1f2fe14*/ bool get_IsRed();
                    /*0x1f2fe14*/ bool get_Is2Node();
                    /*0x1f2fe14*/ bool get_Is4Node();
                    /*0x1f309e4*/ void ColorBlack();
                    /*0x1f309e4*/ void ColorRed();
                    /*0x1f2ff00*/ System.Collections.Generic.TreeRotation GetRotation(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T> sibling);
                    /*0x1f302cc*/ System.Collections.Generic.SortedSet.Node<T> GetSibling(System.Collections.Generic.SortedSet.Node<T> node);
                    /*0x1f309e4*/ void Split4Node();
                    System.Collections.Generic.SortedSet.Node<T> Rotate(System.Collections.Generic.TreeRotation rotation);
                    /*0x1f30214*/ System.Collections.Generic.SortedSet.Node<T> RotateLeft();
                    /*0x1f30214*/ System.Collections.Generic.SortedSet.Node<T> RotateLeftRight();
                    /*0x1f30214*/ System.Collections.Generic.SortedSet.Node<T> RotateRight();
                    /*0x1f30214*/ System.Collections.Generic.SortedSet.Node<T> RotateRightLeft();
                    /*0x1f309e4*/ void Merge2Nodes();
                    /*0x1f30ff0*/ void ReplaceChild(System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    static /*0x0*/ System.Collections.Generic.SortedSet.Node<T> s_dummyNode;
                    /*0x0*/ System.Collections.Generic.SortedSet<T> _tree;
                    /*0x0*/ int _version;
                    /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>> _stack;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> _current;
                    /*0x0*/ bool _reverse;

                    static /*0x1f33998*/ Enumerator();
                    /*0x1f30ebc*/ Enumerator(System.Collections.Generic.SortedSet<T> set);
                    Enumerator(System.Collections.Generic.SortedSet<T> set, bool reverse);
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x1f30ebc*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                    /*0x1f309e4*/ void Initialize();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f309e4*/ void Dispose();
                    /*0x1ffc854*/ T get_Current();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1f2fe14*/ bool get_NotStartedOrEnded();
                    /*0x1f309e4*/ void Reset();
                    /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
                }

                class <>c__DisplayClass52_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ int count;
                    /*0x0*/ T[] array;

                    /*0x1f309e4*/ <>c__DisplayClass52_0();
                    /*0x1f2fec8*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
                }

                class <>c__DisplayClass53_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ object[] objects;

                    /*0x1f309e4*/ <>c__DisplayClass53_0();
                    /*0x1f2fec8*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
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
                /*0x1f2fec8*/ bool Invoke(System.Collections.Generic.SortedSet.Node<T> node);
            }

            enum TreeRotation
            {
                Left = 0,
                LeftRight = 1,
                Right = 2,
                RightLeft = 3,
            }

            interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x1ffc854*/ bool Add(T item);
            }
        }
    }

    namespace IO
    {
        class ChunkedMemoryStream : System.IO.Stream
        {
            /*0x28*/ System.IO.ChunkedMemoryStream.MemoryChunk _headChunk;
            /*0x30*/ System.IO.ChunkedMemoryStream.MemoryChunk _currentChunk;
            /*0x38*/ int _totalLength;

            /*0x3a2ebc8*/ ChunkedMemoryStream();
            /*0x3a2ec20*/ byte[] ToArray();
            /*0x3a2ecac*/ void Write(byte[] buffer, int offset, int count);
            /*0x3a2eec8*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x3a2edc4*/ void AppendChunk(long count);
            /*0x3a2f05c*/ bool get_CanRead();
            /*0x3a2f064*/ bool get_CanSeek();
            /*0x3a2f06c*/ bool get_CanWrite();
            /*0x3a2f074*/ long get_Length();
            /*0x3a2f07c*/ void Flush();
            /*0x3a2f080*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x3a2f108*/ long get_Position();
            /*0x3a2f140*/ void set_Position(long value);
            /*0x3a2f178*/ int Read(byte[] buffer, int offset, int count);
            /*0x3a2f1b0*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x3a2f1e8*/ void SetLength(long value);

            class MemoryChunk
            {
                /*0x10*/ byte[] _buffer;
                /*0x18*/ int _freeOffset;
                /*0x20*/ System.IO.ChunkedMemoryStream.MemoryChunk _next;

                /*0x3a2efec*/ MemoryChunk(int bufferSize);
            }
        }

        class InvalidDataException : System.SystemException
        {
            /*0x3a2f22c*/ InvalidDataException();
            /*0x3a2f294*/ InvalidDataException(string message);
            /*0x3a2f2b8*/ InvalidDataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0x3a2fe0c*/ void ThrowStreamClosedException();
                /*0x3a2f2c0*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x3a2f2c8*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x3a2f388*/ bool get_CanRead();
                /*0x3a2f3a0*/ bool get_CanWrite();
                /*0x3a2f3b8*/ bool get_CanSeek();
                /*0x3a2f3d0*/ long get_Length();
                /*0x3a2f41c*/ long get_Position();
                /*0x3a2f468*/ void set_Position(long value);
                /*0x3a2f4b4*/ void Flush();
                /*0x3a2f4e8*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x3a2f534*/ void SetLength(long value);
                /*0x3a2f580*/ int ReadByte();
                /*0x3a2f5a0*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x3a2f654*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x3a2f6b0*/ int Read(byte[] array, int offset, int count);
                /*0x3a2f6d0*/ int Read(System.Span<byte> buffer);
                /*0x3a2f8cc*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x3a2f980*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x3a2f98c*/ void Write(byte[] array, int offset, int count);
                /*0x3a2f9ac*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x3a2fb04*/ void CopyTo(System.IO.Stream destination, int bufferSize);
                /*0x3a2fb24*/ void Dispose(bool disposing);
                /*0x3a2fbdc*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x3a2fbfc*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x3a2fcd4*/ System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x3a2fcf4*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x3a2fdcc*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x3a2fdec*/ System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken);
                /*0x3a2f4d4*/ void CheckDeflateStream();
            }

            class DeflateStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream base_stream;
                /*0x30*/ System.IO.Compression.CompressionMode mode;
                /*0x34*/ bool leaveOpen;
                /*0x35*/ bool disposed;
                /*0x38*/ System.IO.Compression.DeflateStreamNative native;

                /*0x3a2fe5c*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x3a2f380*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen, int windowsBits);
                /*0x3a2fe68*/ DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen, bool gzip);
                /*0x3a30158*/ void Finalize();
                /*0x3a301ec*/ void Dispose(bool disposing);
                /*0x3a303c4*/ int ReadInternal(byte[] array, int offset, int count);
                /*0x3a2fccc*/ System.Threading.Tasks.ValueTask<int> ReadAsyncMemory(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken);
                /*0x3a2f7a4*/ int ReadCore(System.Span<byte> destination);
                /*0x3a3047c*/ int Read(byte[] array, int offset, int count);
                /*0x3a3064c*/ void WriteInternal(byte[] array, int offset, int count);
                /*0x3a2fdc4*/ System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken);
                /*0x3a2fa80*/ void WriteCore(System.ReadOnlySpan<byte> source);
                /*0x3a306f4*/ void Write(byte[] array, int offset, int count);
                /*0x3a308d0*/ void Flush();
                /*0x3a309d4*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x3a30d70*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x3a3110c*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x3a31270*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x3a313bc*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x3a313f4*/ void SetLength(long value);
                /*0x3a3142c*/ bool get_CanRead();
                /*0x3a31460*/ bool get_CanSeek();
                /*0x3a31468*/ bool get_CanWrite();
                /*0x3a314a0*/ long get_Length();
                /*0x3a314d8*/ long get_Position();
                /*0x3a31510*/ void set_Position(long value);

                class ReadMethod : System.MulticastDelegate
                {
                    /*0x3a30c38*/ ReadMethod(object object, nint method);
                    /*0x3a31548*/ int Invoke(byte[] array, int offset, int count);
                    /*0x3a30cec*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x3a31248*/ int EndInvoke(System.IAsyncResult result);
                }

                class WriteMethod : System.MulticastDelegate
                {
                    /*0x3a30fd4*/ WriteMethod(object object, nint method);
                    /*0x3a3155c*/ void Invoke(byte[] array, int offset, int count);
                    /*0x3a31088*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x3a313b0*/ void EndInvoke(System.IAsyncResult result);
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

                static /*0x3a2ffe8*/ System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool gzip);
                static /*0x3a31570*/ int UnmanagedRead(nint buffer, int length, nint data);
                static /*0x3a31680*/ int UnmanagedWrite(nint buffer, int length, nint data);
                static /*0x3a31838*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, bool gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, nint data);
                static /*0x3a31f50*/ int CloseZStream(nint stream);
                static /*0x3a31964*/ int Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream);
                static /*0x3a31a9c*/ int ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                static /*0x3a31b18*/ int WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                /*0x3a31790*/ DeflateStreamNative();
                /*0x3a318dc*/ void Finalize();
                /*0x3a302b4*/ void Dispose(bool disposing);
                /*0x3a30980*/ void Flush();
                /*0x3a30404*/ int ReadZStream(nint buffer, int length);
                /*0x3a30688*/ void WriteZStream(nint buffer, int length);
                /*0x3a31b94*/ int UnmanagedRead(nint buffer, int length);
                /*0x3a31d54*/ int UnmanagedWrite(nint buffer, int length);
                /*0x3a319c8*/ void CheckResult(int result, string where);

                class UnmanagedReadOrWrite : System.MulticastDelegate
                {
                    /*0x3a31798*/ UnmanagedReadOrWrite(object object, nint method);
                    /*0x3a31f54*/ int Invoke(nint buffer, int length, nint data);
                }

                class SafeDeflateStreamHandle : System.Runtime.InteropServices.SafeHandle
                {
                    /*0x3a31f40*/ SafeDeflateStreamHandle();
                    /*0x3a31f68*/ bool get_IsInvalid();
                    /*0x3a31f78*/ bool ReleaseHandle();
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

            /*0x3a32008*/ ContextAwareResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x3a32010*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x3a32060*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x3a32000*/ void SafeCaptureIdentity();
            /*0x3a32004*/ void CleanupInternal();
            /*0x3a320d8*/ object StartPostingAsyncOp();
            /*0x3a320e0*/ object StartPostingAsyncOp(bool lockCapture);
            /*0x3a322b0*/ bool FinishPostingAsyncOp();
            /*0x3a326dc*/ void Cleanup();
            /*0x3a322f0*/ bool CaptureOrComplete(ref System.Threading.ExecutionContext cachedContext, bool returnContext);
            /*0x3a329a0*/ void Complete(nint userToken);
            /*0x3a32c6c*/ void CompleteCallback();

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

                static /*0x3a32d18*/ <>c();
                /*0x3a32d80*/ <>c();
                /*0x3a32d88*/ void <Complete>b__17_0(object s);
            }
        }

        class HttpStatusDescription
        {
            static /*0x3a32e08*/ string Get(System.Net.HttpStatusCode code);
            static /*0x3a32e0c*/ string Get(int code);
        }

        class HttpValidationHelpers
        {
            static /*0x0*/ char[] s_httpTrimCharacters;

            static /*0x3a33854*/ HttpValidationHelpers();
            static /*0x3a33564*/ string CheckBadHeaderValueChars(string value);
            static /*0x3a33740*/ bool IsInvalidMethodOrHeaderString(string stringValue);
        }

        class NetEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Net.NetEventSource Log;

            static /*0x3a34c44*/ NetEventSource();
            static /*0x3a338f4*/ void Enter(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x3a33e88*/ void Enter(object thisOrContextObject, object arg0, string memberName);
            static /*0x3a34318*/ void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName);
            static /*0x3a34434*/ void Exit(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x3a345a0*/ void Exit(object thisOrContextObject, object arg0, string memberName);
            static /*0x3a327e0*/ void Info(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x3a328d0*/ void Info(object thisOrContextObject, object message, string memberName);
            static /*0x3a346ec*/ void Error(object thisOrContextObject, object message, string memberName);
            static /*0x3a321e0*/ void Fail(object thisOrContextObject, object message, string memberName);
            static /*0x3a348b4*/ void Associate(object first, object second, string memberName);
            static /*0x3a3277c*/ bool get_IsEnabled();
            static /*0x3a339e4*/ string IdOf(object value);
            static /*0x3a34c28*/ int GetHashCode(object value);
            static /*0x3a33f70*/ object Format(object value);
            static /*0x3a33ad0*/ string Format(System.FormattableString s);
            /*0x3a34c3c*/ NetEventSource();
            /*0x3a33e0c*/ void Enter(string thisOrContextObject, string memberName, string parameters);
            /*0x3a34524*/ void Exit(string thisOrContextObject, string memberName, string result);
            /*0x3a34670*/ void Info(string thisOrContextObject, string memberName, string message);
            /*0x3a347bc*/ void ErrorMessage(string thisOrContextObject, string memberName, string message);
            /*0x3a34838*/ void CriticalFailure(string thisOrContextObject, string memberName, string message);
            /*0x3a34984*/ void Associate(string thisOrContextObject, string memberName, string first, string second);
            /*0x3a34a0c*/ void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4);

            class Keywords
            {
                static System.Diagnostics.Tracing.EventKeywords Default = 1;
                static System.Diagnostics.Tracing.EventKeywords Debug = 2;
                static System.Diagnostics.Tracing.EventKeywords EnterExit = 4;
            }
        }

        class TcpValidationHelpers
        {
            static /*0x3a34cac*/ bool ValidatePortNumber(int port);
        }

        class TlsStream : System.Net.Sockets.NetworkStream
        {
            /*0x48*/ System.Net.Security.SslStream _sslStream;
            /*0x50*/ string _host;
            /*0x58*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;

            /*0x3a34cb8*/ TlsStream(System.Net.Sockets.NetworkStream stream, System.Net.Sockets.Socket socket, string host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates);
            /*0x3a34da8*/ void AuthenticateAsClient();
            /*0x3a34ea8*/ System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object state);
            /*0x3a34fc0*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
            /*0x3a34fe0*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x3a35000*/ void EndWrite(System.IAsyncResult result);
            /*0x3a35020*/ void Write(byte[] buffer, int offset, int size);
            /*0x3a35040*/ int Read(byte[] buffer, int offset, int size);
            /*0x3a35060*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x3a35080*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x3a350a0*/ void Close();
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

            static /*0x3a350d4*/ HttpVersion();
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

            static /*0x3a364ec*/ IPAddress();
            static /*0x3a35680*/ bool TryParse(string ipString, ref System.Net.IPAddress address);
            static /*0x3a35978*/ System.Net.IPAddress Parse(string ipString);
            static /*0x3a35ec4*/ bool IsLoopback(System.Net.IPAddress address);
            static /*0x3a35390*/ byte[] ThrowAddressNullException();
            /*0x3a35280*/ IPAddress(long newAddress);
            /*0x3a3530c*/ IPAddress(byte[] address, long scopeid);
            /*0x3a353dc*/ IPAddress(System.ReadOnlySpan<byte> address, long scopeid);
            /*0x3a35564*/ IPAddress(ushort* numbers, int numbersLength, uint scopeid);
            /*0x3a35630*/ IPAddress(ushort[] numbers, uint scopeid);
            /*0x3a351e8*/ bool get_IsIPv4();
            /*0x3a351f8*/ bool get_IsIPv6();
            /*0x3a35208*/ uint get_PrivateAddress();
            /*0x3a35210*/ void set_PrivateAddress(uint value);
            /*0x3a35244*/ uint get_PrivateScopeId();
            /*0x3a3524c*/ void set_PrivateScopeId(uint value);
            /*0x3a35a10*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten);
            /*0x3a35b1c*/ void WriteIPv6Bytes(System.Span<byte> destination);
            /*0x3a35ba8*/ void WriteIPv4Bytes(System.Span<byte> destination);
            /*0x3a35bf4*/ byte[] GetAddressBytes();
            /*0x3a35d3c*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x3a35d54*/ long get_ScopeId();
            /*0x3a35da0*/ string ToString();
            /*0x3a35f94*/ bool Equals(object comparandObj, bool compareScopeId);
            /*0x3a360bc*/ bool Equals(object comparand);
            /*0x3a360c4*/ int GetHashCode();
            /*0x3a36418*/ System.Net.IPAddress MapToIPv6();

            class ReadOnlyIPAddress : System.Net.IPAddress
            {
                /*0x3a366c8*/ ReadOnlyIPAddress(long newAddress);
            }
        }

        class IPAddressParser
        {
            static /*0x3a3570c*/ System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipSpan, bool tryParse);
            static /*0x3a35e64*/ string IPv4AddressToString(uint address);
            static /*0x3a369ec*/ void IPv4AddressToString(uint address, System.Text.StringBuilder destination);
            static /*0x3a36950*/ int IPv4AddressToStringHelper(uint address, char* addressString);
            static /*0x3a35e50*/ string IPv6AddressToString(ushort[] address, uint scopeId);
            static /*0x3a36b24*/ System.Text.StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId);
            static /*0x3a36a6c*/ void FormatIPv4AddressNumber(int number, char* addressString, ref int offset);
            static /*0x3a368a0*/ bool Ipv4StringToAddress(System.ReadOnlySpan<char> ipSpan, ref long address);
            static /*0x3a3672c*/ bool Ipv6StringToAddress(System.ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, ref uint scope);
            static /*0x3a36c44*/ void AppendSections(ushort[] address, int fromInclusive, int toExclusive, System.Text.StringBuilder buffer);
            static /*0x3a36e58*/ void AppendHex(ushort value, System.Text.StringBuilder buffer);
            static /*0x3a36e24*/ uint ExtractIPv4Address(ushort[] address);
            static /*0x3a36ef8*/ ushort Reverse(ushort number);
        }

        class IPEndPoint : System.Net.EndPoint
        {
            static /*0x0*/ System.Net.IPEndPoint Any;
            static /*0x8*/ System.Net.IPEndPoint IPv6Any;
            /*0x10*/ System.Net.IPAddress _address;
            /*0x18*/ int _port;

            static /*0x3a37404*/ IPEndPoint();
            /*0x3a36f2c*/ IPEndPoint(System.Net.IPAddress address, int port);
            /*0x3a36f04*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x3a36fec*/ System.Net.IPAddress get_Address();
            /*0x3a36ff4*/ int get_Port();
            /*0x3a36ffc*/ string ToString();
            /*0x3a370bc*/ System.Net.SocketAddress Serialize();
            /*0x3a37124*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
            /*0x3a37328*/ bool Equals(object comparand);
            /*0x3a373d4*/ int GetHashCode();
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

            static /*0x3a394ac*/ CommandStream();
            static /*0x3a38820*/ void ReadCallback(System.IAsyncResult asyncResult);
            static /*0x3a390c0*/ void WriteCallback(System.IAsyncResult asyncResult);
            /*0x3a374e0*/ CommandStream(System.Net.Sockets.TcpClient client);
            /*0x3a37600*/ void Abort(System.Exception e);
            /*0x3a3781c*/ void Dispose(bool disposing);
            /*0x3a378b0*/ void InvokeRequestCallback(object obj);
            /*0x3a37930*/ bool get_RecoverableFailure();
            /*0x3a37938*/ void MarkAsRecoverableFailure();
            /*0x3a37950*/ System.IO.Stream SubmitRequest(System.Net.WebRequest request, bool isAsync, bool readInitalResponseOnConnect);
            /*0x3a37f68*/ void ClearState();
            /*0x3a37f78*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest request);
            /*0x3a37f80*/ System.Exception GenerateException(string message, System.Net.WebExceptionStatus status, System.Exception innerException);
            /*0x3a37ff8*/ System.Exception GenerateException(System.Net.FtpStatusCode code, string statusDescription, System.Exception innerException);
            /*0x3a379d0*/ void InitCommandPipeline(System.Net.WebRequest request, System.Net.CommandStream.PipelineEntry[] commands, bool isAsync);
            /*0x3a380b8*/ void CheckContinuePipeline();
            /*0x3a37a50*/ System.IO.Stream ContinueCommandPipeline();
            /*0x3a3817c*/ bool PostSendCommandProcessing(ref System.IO.Stream stream);
            /*0x3a385e0*/ bool PostReadCommandProcessing(ref System.IO.Stream stream);
            /*0x3a38818*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x3a39390*/ System.Text.Encoding get_Encoding();
            /*0x3a39398*/ void set_Encoding(System.Text.Encoding value);
            /*0x3a393e8*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x3a382b0*/ System.Net.ResponseDescription ReceiveCommandResponse();
            /*0x3a38b1c*/ void ReceiveCommandResponseCallback(System.Net.ReceiveState state, int bytesRead);

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

                /*0x3a39590*/ PipelineEntry(string command);
                /*0x3a395c0*/ PipelineEntry(string command, System.Net.CommandStream.PipelineEntryFlags flags);
                /*0x3a3816c*/ bool HasFlag(System.Net.CommandStream.PipelineEntryFlags flags);
            }
        }

        class ResponseDescription
        {
            /*0x10*/ bool Multiline;
            /*0x14*/ int Status;
            /*0x18*/ string StatusDescription;
            /*0x20*/ System.Text.StringBuilder StatusBuffer;
            /*0x28*/ string StatusCodeString;

            /*0x3a39660*/ ResponseDescription();
            /*0x3a395fc*/ bool get_PositiveIntermediate();
            /*0x3a39610*/ bool get_PositiveCompletion();
            /*0x3a39624*/ bool get_TransientFailure();
            /*0x3a39638*/ bool get_PermanentFailure();
            /*0x3a3964c*/ bool get_InvalidStatusCode();
        }

        class ReceiveState
        {
            /*0x10*/ System.Net.ResponseDescription Resp;
            /*0x18*/ int ValidThrough;
            /*0x20*/ byte[] Buffer;
            /*0x28*/ System.Net.CommandStream Connection;

            /*0x3a393f0*/ ReceiveState(System.Net.CommandStream connection);
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

            static /*0x3a3e008*/ FtpControlStream();
            static /*0x3a39924*/ void AcceptCallback(System.IAsyncResult asyncResult);
            static /*0x3a39d18*/ void ConnectCallback(System.IAsyncResult asyncResult);
            static /*0x3a39ec8*/ void SSLHandshakeCallback(System.IAsyncResult asyncResult);
            static /*0x3a3d054*/ void GetPathInfo(System.Net.FtpControlStream.GetPathOption pathOption, System.Uri uri, ref string path, ref string directory, ref string filename);
            /*0x3a39808*/ FtpControlStream(System.Net.Sockets.TcpClient client);
            /*0x3a396d4*/ System.Net.NetworkCredential get_Credentials();
            /*0x3a3977c*/ void set_Credentials(System.Net.NetworkCredential value);
            /*0x3a39898*/ void AbortConnect();
            /*0x3a3a088*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref System.IO.Stream stream);
            /*0x3a3a664*/ void ClearState();
            /*0x3a3a734*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x3a3c038*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest req);
            /*0x3a3afd0*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateDataConection(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream, ref bool isSocketReady);
            /*0x3a3d994*/ string FormatAddress(System.Net.IPAddress address, int Port);
            /*0x3a3dabc*/ string FormatAddressV6(System.Net.IPAddress address, int port);
            /*0x3a3dbcc*/ long get_ContentLength();
            /*0x3a3dbd4*/ System.DateTime get_LastModified();
            /*0x3a3dbdc*/ System.Uri get_ResponseUri();
            /*0x3a3dbe4*/ string get_BannerMessage();
            /*0x3a3dbfc*/ string get_WelcomeMessage();
            /*0x3a3dc14*/ string get_ExitMessage();
            /*0x3a3bad8*/ long GetContentLengthFrom213Response(string responseString);
            /*0x3a3bc04*/ System.DateTime GetLastModifiedFrom213Response(string str);
            /*0x3a3b770*/ void TryUpdateResponseUri(string str, System.Net.FtpWebRequest request);
            /*0x3a3b678*/ void TryUpdateContentLength(string str);
            /*0x3a3bfa8*/ string GetLoginDirectory(string str);
            /*0x3a3d598*/ int GetPortV4(string responseString);
            /*0x3a3d76c*/ int GetPortV6(string responseString);
            /*0x3a3d228*/ void CreateFtpListenerSocket(System.Net.FtpWebRequest request);
            /*0x3a3d3b0*/ string GetPortCommandLine(System.Net.FtpWebRequest request);
            /*0x3a3cf4c*/ string FormatFtpCommand(string command, string parameter);
            /*0x3a3d918*/ System.Net.Sockets.Socket CreateFtpDataSocket(System.Net.FtpWebRequest request, System.Net.Sockets.Socket templateSocket);
            /*0x3a3dc2c*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x3a3a354*/ System.Net.TriState IsFtpDataStreamWriteable();

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

                /*0x3a3afc8*/ <>c__DisplayClass31_0();
                /*0x3a3e138*/ void <PipelineCallback>b__0(System.IAsyncResult ar);
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

            /*0x3a3a3d8*/ FtpDataStream(System.Net.Sockets.NetworkStream networkStream, System.Net.FtpWebRequest request, System.Net.TriState writeOnly);
            /*0x3a3e240*/ void Dispose(bool disposing);
            /*0x3a3e3b4*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x3a3e7e0*/ void CheckError();
            /*0x3a3e824*/ bool get_CanRead();
            /*0x3a3e82c*/ bool get_CanSeek();
            /*0x3a3e848*/ bool get_CanWrite();
            /*0x3a3e850*/ long get_Length();
            /*0x3a3e86c*/ long get_Position();
            /*0x3a3e888*/ void set_Position(long value);
            /*0x3a3e8a8*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x3a3e974*/ int Read(byte[] buffer, int offset, int size);
            /*0x3a3ea78*/ void Write(byte[] buffer, int offset, int size);
            /*0x3a3eb50*/ void AsyncReadCallback(System.IAsyncResult ar);
            /*0x3a3ee2c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x3a3efc4*/ int EndRead(System.IAsyncResult ar);
            /*0x3a3f150*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x3a3f244*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x3a3f2d8*/ void Flush();
            /*0x3a3f2f8*/ void SetLength(long value);
            /*0x3a3f318*/ bool get_CanTimeout();
            /*0x3a3f334*/ int get_ReadTimeout();
            /*0x3a3f354*/ void set_ReadTimeout(int value);
            /*0x3a3f374*/ int get_WriteTimeout();
            /*0x3a3f394*/ void set_WriteTimeout(int value);
            /*0x3a3f3b4*/ void SetSocketTimeoutOption(int timeout);
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

            static /*0x3a3f5bc*/ FtpMethodInfo();
            static /*0x3a3f45c*/ System.Net.FtpMethodInfo GetMethodInfo(string method);
            /*0x3a3f404*/ FtpMethodInfo(string method, System.Net.FtpOperation operation, System.Net.FtpMethodFlags flags, string httpCommand);
            /*0x3a3d044*/ bool HasFlag(System.Net.FtpMethodFlags flags);
            /*0x3a3d218*/ bool get_IsCommandOnly();
            /*0x3a3dff0*/ bool get_IsUpload();
            /*0x3a3dffc*/ bool get_IsDownload();
            /*0x3a3b764*/ bool get_ShouldParseForResponseUri();
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

            static /*0x3a449f0*/ FtpWebRequest();
            /*0x3a3ffa0*/ FtpWebRequest(System.Uri uri);
            /*0x3a3fbb0*/ System.Net.FtpMethodInfo get_MethodInfo();
            /*0x3a3fbb8*/ string get_Method();
            /*0x3a3fbd0*/ void set_Method(string value);
            /*0x3a3fd9c*/ string get_RenameTo();
            /*0x3a3fda4*/ System.Net.ICredentials get_Credentials();
            /*0x3a3fdac*/ void set_Credentials(System.Net.ICredentials value);
            /*0x3a3fef8*/ System.Uri get_RequestUri();
            /*0x3a3ff00*/ int get_Timeout();
            /*0x3a3ff08*/ int get_RemainingTimeout();
            /*0x3a3ff10*/ int get_ReadWriteTimeout();
            /*0x3a3ff18*/ long get_ContentOffset();
            /*0x3a3ff20*/ long get_ContentLength();
            /*0x3a3ff28*/ void set_ContentLength(long value);
            /*0x3a3ff30*/ System.Net.IWebProxy get_Proxy();
            /*0x3a3ff38*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x3a3ff98*/ bool get_Aborted();
            /*0x3a403a0*/ System.Net.WebResponse GetResponse();
            /*0x3a41dd0*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x3a42450*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x3a40f78*/ void SubmitRequest(bool isAsync);
            /*0x3a430b4*/ System.Exception TranslateConnectException(System.Exception e);
            /*0x3a42838*/ void CreateConnectionAsync();
            /*0x3a428e0*/ System.Net.FtpControlStream CreateConnection();
            /*0x3a42a94*/ System.IO.Stream TimedSubmitRequestHelper(bool isAsync);
            /*0x3a43224*/ void TimerCallback(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            /*0x3a431a4*/ System.Net.TimerThread.Queue get_TimerQueue();
            /*0x3a42e68*/ bool AttemptedRecovery(System.Exception e);
            /*0x3a41a20*/ void SetException(System.Exception exception);
            /*0x3a40b40*/ void CheckError();
            /*0x3a37920*/ void RequestCallback(object obj);
            /*0x3a43d60*/ void SyncRequestCallback(object obj);
            /*0x3a43358*/ void AsyncRequestCallback(object obj);
            /*0x3a40b54*/ System.Net.FtpWebRequest.RequestStage FinishRequestStage(System.Net.FtpWebRequest.RequestStage stage);
            /*0x3a44174*/ void Abort();
            /*0x3a445fc*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x3a4465c*/ bool get_UseBinary();
            /*0x3a44664*/ bool get_UsePassive();
            /*0x3a3a568*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x3a4466c*/ bool get_EnableSsl();
            /*0x3a44674*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3a446e4*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x3a446ec*/ string get_ContentType();
            /*0x3a44714*/ void set_ContentType(string value);
            /*0x3a4473c*/ bool get_UseDefaultCredentials();
            /*0x3a3fd7c*/ bool get_InUse();
            /*0x3a4150c*/ void EnsureFtpWebResponse(System.Exception exception);
            /*0x3a44970*/ void DataStreamClosed(System.Net.CloseExState closeState);

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

                /*0x3a44b10*/ void MoveNext();
                /*0x3a44e88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c
            {
                static /*0x0*/ System.Net.FtpWebRequest.<> <>9;
                static /*0x8*/ System.Func<System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0;

                static /*0x3a44e94*/ <>c();
                /*0x3a44efc*/ <>c();
                /*0x3a44f04*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <get_ClientCertificates>b__114_0();
            }
        }

        class FtpWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x3a44f58*/ FtpWebRequestCreator();
            /*0x3a44f60*/ System.Net.WebRequest Create(System.Uri uri);
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

            /*0x3a4480c*/ FtpWebResponse(System.IO.Stream responseStream, long contentLength, System.Uri responseUri, System.Net.FtpStatusCode statusCode, string statusLine, System.DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage);
            /*0x3a43320*/ void UpdateStatus(System.Net.FtpStatusCode statusCode, string statusLine, string exitMessage);
            /*0x3a44fb8*/ System.IO.Stream GetResponseStream();
            /*0x3a44764*/ void SetResponseStream(System.IO.Stream stream);
            /*0x3a450c8*/ void Close();
            /*0x3a451ac*/ long get_ContentLength();
            /*0x3a451b4*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3a452d8*/ System.Uri get_ResponseUri();
            /*0x3a452e0*/ System.Net.FtpStatusCode get_StatusCode();

            class EmptyStream : System.IO.MemoryStream
            {
                /*0x3a45024*/ EmptyStream();
            }
        }

        class NetworkStreamWrapper : System.IO.Stream
        {
            /*0x28*/ System.Net.Sockets.TcpClient _client;
            /*0x30*/ System.Net.Sockets.NetworkStream _networkStream;

            /*0x3a37568*/ NetworkStreamWrapper(System.Net.Sockets.TcpClient client);
            /*0x3a3a4ec*/ bool get_UsingSecureStream();
            /*0x3a39c84*/ System.Net.IPAddress get_ServerAddress();
            /*0x3a3bac0*/ System.Net.Sockets.Socket get_Socket();
            /*0x3a452e8*/ System.Net.Sockets.NetworkStream get_NetworkStream();
            /*0x3a452f0*/ void set_NetworkStream(System.Net.Sockets.NetworkStream value);
            /*0x3a452f8*/ bool get_CanRead();
            /*0x3a45314*/ bool get_CanSeek();
            /*0x3a45330*/ bool get_CanWrite();
            /*0x3a4534c*/ bool get_CanTimeout();
            /*0x3a45368*/ int get_ReadTimeout();
            /*0x3a45388*/ void set_ReadTimeout(int value);
            /*0x3a453a8*/ int get_WriteTimeout();
            /*0x3a453c8*/ void set_WriteTimeout(int value);
            /*0x3a453e8*/ long get_Length();
            /*0x3a45404*/ long get_Position();
            /*0x3a45420*/ void set_Position(long value);
            /*0x3a45440*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x3a45460*/ int Read(byte[] buffer, int offset, int size);
            /*0x3a45480*/ void Write(byte[] buffer, int offset, int size);
            /*0x3a454a0*/ void Dispose(bool disposing);
            /*0x3a38ae4*/ void CloseSocket();
            /*0x3a377ec*/ void Close(int timeout);
            /*0x3a45544*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x3a45564*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x3a45584*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x3a455a4*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x3a455c4*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x3a455e4*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x3a45604*/ void Flush();
            /*0x3a45624*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x3a45644*/ void SetLength(long value);
            /*0x3a42a44*/ void SetSocketTimeoutOption(int timeout);
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

        class WebClient : System.ComponentModel.Component
        {
            static /*0x0*/ char[] s_parseContentTypeSeparators;
            static /*0x8*/ System.Text.Encoding[] s_knownEncodings;
            /*0x28*/ System.Uri _baseAddress;
            /*0x30*/ System.Net.ICredentials _credentials;
            /*0x38*/ System.Net.WebHeaderCollection _headers;
            /*0x40*/ System.Collections.Specialized.NameValueCollection _requestParameters;
            /*0x48*/ System.Net.WebResponse _webResponse;
            /*0x50*/ System.Net.WebRequest _webRequest;
            /*0x58*/ System.Text.Encoding _encoding;
            /*0x60*/ string _method;
            /*0x68*/ long _contentLength;
            /*0x70*/ bool _canceled;
            /*0x78*/ System.Net.WebClient.ProgressData _progress;
            /*0x80*/ System.Net.IWebProxy _proxy;
            /*0x88*/ bool _proxySet;
            /*0x8c*/ int _callNesting;
            /*0x90*/ System.Net.Cache.RequestCachePolicy <CachePolicy>k__BackingField;

            static /*0x3a472b8*/ WebClient();
            static /*0x3a46b78*/ void AbortRequest(System.Net.WebRequest request);
            static /*0x3a47240*/ bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray);
            static /*0x3a4607c*/ void ThrowIfNull(object argument, string parameterName);
            /*0x3a45664*/ WebClient();
            /*0x3a4578c*/ void StartOperation();
            /*0x3a45850*/ void EndOperation();
            /*0x3a4585c*/ System.Text.Encoding get_Encoding();
            /*0x3a45864*/ System.Net.ICredentials get_Credentials();
            /*0x3a4586c*/ System.Net.Cache.RequestCachePolicy get_CachePolicy();
            /*0x3a45874*/ System.Net.WebRequest GetWebRequest(System.Uri address);
            /*0x3a45d78*/ System.Net.WebResponse GetWebResponse(System.Net.WebRequest request);
            /*0x3a45dc8*/ byte[] DownloadData(string address);
            /*0x3a45f5c*/ byte[] DownloadData(System.Uri address);
            /*0x3a460c8*/ byte[] DownloadDataInternal(System.Uri address, ref System.Net.WebRequest request);
            /*0x3a46c90*/ string DownloadString(string address);
            /*0x3a46cac*/ string DownloadString(System.Uri address);
            /*0x3a45994*/ void CopyHeadersTo(System.Net.WebRequest request);
            /*0x3a45de4*/ System.Uri GetUri(string address);
            /*0x3a46378*/ System.Uri GetUri(System.Uri address);
            /*0x3a46640*/ byte[] DownloadBits(System.Net.WebRequest request, System.IO.Stream writeStream);
            /*0x3a46de0*/ string GetStringUsingEncoding(System.Net.WebRequest request, byte[] data);

            class ProgressData
            {
                /*0x10*/ long BytesSent;
                /*0x18*/ long TotalBytesToSend;
                /*0x20*/ long BytesReceived;
                /*0x28*/ long TotalBytesToReceive;
                /*0x30*/ bool HasUploadPhase;

                /*0x3a4757c*/ void Reset();
            }
        }

        class Authorization
        {
            /*0x10*/ string m_Message;
            /*0x18*/ bool m_Complete;
            /*0x20*/ string ModuleAuthenticationType;

            /*0x3a47590*/ Authorization(string token);
            /*0x3a4763c*/ Authorization(string token, bool finished);
            /*0x3a476d8*/ string get_Message();
            /*0x3a476e0*/ bool get_Complete();
        }

        class CredentialCache
        {
            static /*0x3a476e8*/ System.Net.ICredentials get_DefaultCredentials();
            static /*0x3a47740*/ System.Net.NetworkCredential get_DefaultNetworkCredentials();
        }

        class SystemNetworkCredential : System.Net.NetworkCredential
        {
            static /*0x0*/ System.Net.SystemNetworkCredential defaultCredential;

            static /*0x3a4781c*/ SystemNetworkCredential();
            /*0x3a47798*/ SystemNetworkCredential();
        }

        class EndPoint
        {
            /*0x3a47a08*/ EndPoint();
            /*0x3a4789c*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x3a47940*/ System.Net.SocketAddress Serialize();
            /*0x3a479e4*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
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
            /*0x1f303d0*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            /*0x1f30394*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
            /*0x1f30214*/ string get_AuthenticationType();
        }

        interface ICertificatePolicy
        {
            bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
        }

        interface ICredentials
        {
            /*0x1f30394*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class IPHostEntry
        {
            /*0x10*/ string hostName;
            /*0x18*/ string[] aliases;
            /*0x20*/ System.Net.IPAddress[] addressList;
            /*0x28*/ bool isTrustedHost;

            /*0x3a47a38*/ IPHostEntry();
            /*0x3a47a10*/ string get_HostName();
            /*0x3a47a18*/ void set_HostName(string value);
            /*0x3a47a20*/ void set_Aliases(string[] value);
            /*0x3a47a28*/ System.Net.IPAddress[] get_AddressList();
            /*0x3a47a30*/ void set_AddressList(System.Net.IPAddress[] value);
        }

        interface IWebRequestCreate
        {
            /*0x1f302cc*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class InternalException : System.SystemException
        {
            /*0x3a47a48*/ InternalException();
        }

        class NclUtilities
        {
            static /*0x0*/ System.Net.IPAddress[] _LocalAddresses;
            static /*0x8*/ object _LocalAddressesLock;
            static /*0x10*/ string _LocalDomainName;

            static /*0x3a47a50*/ bool IsFatal(System.Exception exception);
            static /*0x3a47b20*/ bool IsAddressLocal(System.Net.IPAddress ipAddress);
            static /*0x3a480cc*/ System.Net.IPHostEntry GetLocalHost();
            static /*0x3a47bb0*/ System.Net.IPAddress[] get_LocalAddresses();
            static /*0x3a480e4*/ object get_LocalAddressesLock();
        }

        class ValidationHelper
        {
            static /*0x0*/ string[] EmptyArray;
            static /*0x8*/ char[] InvalidMethodChars;
            static /*0x10*/ char[] InvalidParamChars;

            static /*0x3a481a8*/ ValidationHelper();
            static /*0x3a47628*/ string MakeStringNull(string stringValue);
            static /*0x3a48180*/ bool IsBlankString(string stringValue);
            static /*0x3a4819c*/ bool ValidateTcpPort(int port);
        }

        class ExceptionHelper
        {
            static /*0x3a47964*/ System.NotImplementedException get_MethodNotImplementedException();
            static /*0x3a478c0*/ System.NotImplementedException get_PropertyNotImplementedException();
            static /*0x3a482c8*/ System.Net.WebException get_TimeoutException();
            static /*0x3a48354*/ System.NotSupportedException get_PropertyNotSupportedException();
            static /*0x3a483d4*/ System.Net.WebException get_RequestAbortedException();
        }

        class WebRequestPrefixElement
        {
            /*0x10*/ string Prefix;
            /*0x18*/ System.Net.IWebRequestCreate creator;
            /*0x20*/ System.Type creatorType;

            /*0x3a4873c*/ WebRequestPrefixElement(string P, System.Net.IWebRequestCreate C);
            /*0x3a48530*/ System.Net.IWebRequestCreate get_Creator();
            /*0x3a48734*/ void set_Creator(System.Net.IWebRequestCreate value);
        }

        class HttpContinueDelegate : System.MulticastDelegate
        {
            /*0x3a48780*/ HttpContinueDelegate(object object, nint method);
            /*0x3a48820*/ void Invoke(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
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

            /*0x3a48834*/ NetworkCredential(string userName, string password);
            /*0x3a477b8*/ NetworkCredential(string userName, string password, string domain);
            /*0x3a488b4*/ string get_UserName();
            /*0x3a4884c*/ void set_UserName(string value);
            /*0x3a488bc*/ string get_Password();
            /*0x3a4886c*/ void set_Password(string value);
            /*0x3a488d4*/ string get_Domain();
            /*0x3a48894*/ void set_Domain(string value);
            /*0x3a488dc*/ string InternalGetUserName();
            /*0x3a488c8*/ string InternalGetPassword();
            /*0x3a488e4*/ string InternalGetDomain();
            /*0x3a488ec*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x3a488f0*/ ProtocolViolationException();
            /*0x3a488f8*/ ProtocolViolationException(string message);
            /*0x3a48900*/ ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a48908*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a48910*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class SocketAddress
        {
            /*0x10*/ int m_Size;
            /*0x18*/ byte[] m_Buffer;
            /*0x20*/ bool m_changed;
            /*0x24*/ int m_hash;

            /*0x3a489c4*/ SocketAddress(System.Net.Sockets.AddressFamily family, int size);
            /*0x3a48aec*/ SocketAddress(System.Net.IPAddress ipAddress);
            /*0x3a48d40*/ SocketAddress(System.Net.IPAddress ipaddress, int port);
            /*0x3a48918*/ System.Net.Sockets.AddressFamily get_Family();
            /*0x3a48948*/ int get_Size();
            /*0x3a48950*/ byte get_Item(int offset);
            /*0x3a48d9c*/ System.Net.IPAddress GetIPAddress();
            /*0x3a48f78*/ System.Net.IPEndPoint GetIPEndPoint();
            /*0x3a49010*/ bool Equals(object comparand);
            /*0x3a490f4*/ int GetHashCode();
            /*0x3a49238*/ string ToString();
        }

        class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x8c*/ System.Net.WebExceptionStatus m_Status;
            /*0x90*/ System.Net.WebResponse m_Response;
            /*0x98*/ System.Net.WebExceptionInternalStatus m_InternalStatus;

            /*0x3a494c8*/ WebException();
            /*0x3a48340*/ WebException(string message);
            /*0x3a494d8*/ WebException(string message, System.Exception innerException);
            /*0x3a4851c*/ WebException(string message, System.Net.WebExceptionStatus status);
            /*0x3a494fc*/ WebException(string message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException);
            /*0x3a494e8*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x3a49530*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x3a49518*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x3a49618*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x3a49714*/ WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a49724*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a49730*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a49738*/ System.Net.WebExceptionStatus get_Status();
            /*0x3a49740*/ System.Net.WebResponse get_Response();
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

            static /*0x3a498e4*/ WebExceptionMapping();
            static /*0x3a49748*/ string GetWebStatusString(System.Net.WebExceptionStatus status);
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

            static /*0x3a4bd60*/ WebHeaderCollection();
            static /*0x3a49b18*/ bool AllowMultiValues(string name);
            static /*0x3a49fcc*/ string CheckBadChars(string name, bool isHeaderValue);
            static /*0x3a4a338*/ bool ContainsNonAsciiChars(string token);
            static /*0x3a4b184*/ string GetAsString(System.Collections.Specialized.NameValueCollection cc, bool winInetCompat, bool forTrace);
            /*0x3a4b424*/ WebHeaderCollection();
            /*0x3a4b488*/ WebHeaderCollection(System.Net.WebHeaderCollectionType type);
            /*0x3a4b584*/ WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a49958*/ void NormalizeCommonHeaders();
            /*0x3a49a70*/ System.Collections.Specialized.NameValueCollection get_InnerCollection();
            /*0x3a49c9c*/ bool get_AllowHttpRequestHeader();
            /*0x3a49ce0*/ void Remove(System.Net.HttpRequestHeader header);
            /*0x3a49e50*/ void AddInternal(string name, string value);
            /*0x3a49ea4*/ void ChangeInternal(string name, string value);
            /*0x3a49ef8*/ void RemoveInternal(string name);
            /*0x3a49f54*/ void CheckUpdate(string name, string value);
            /*0x3a4a3c0*/ void ThrowOnRestrictedHeader(string headerName);
            /*0x3a4a52c*/ void Add(string name, string value);
            /*0x3a4a6dc*/ void Add(string header);
            /*0x3a4a9ac*/ void Set(string name, string value);
            /*0x3a4abd4*/ void SetInternal(string name, string value);
            /*0x3a4adf0*/ void Remove(string name);
            /*0x3a4af28*/ string[] GetValues(string header);
            /*0x3a4b128*/ string ToString();
            /*0x3a4b750*/ void OnDeserialization(object sender);
            /*0x3a4b754*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4b8d4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4b8e0*/ string Get(string name);
            /*0x3a4bc0c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3a4bc80*/ int get_Count();
            /*0x3a4bcb0*/ string Get(int index);
            /*0x3a4bcf0*/ string GetKey(int index);
            /*0x3a4bd30*/ string[] get_AllKeys();

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

            static /*0x3a4c820*/ CaseInsensitiveAscii();
            /*0x3a4c818*/ CaseInsensitiveAscii();
            /*0x3a4c31c*/ int GetHashCode(object myObject);
            /*0x3a4c424*/ int Compare(object firstObject, object secondObject);
            /*0x3a4c5a4*/ int FastGetHashCode(string myString);
            /*0x3a4c694*/ bool Equals(object firstObject, object secondObject);
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

            static /*0x3a4daec*/ WebRequest();
            static /*0x3a4c8e8*/ object get_InternalSyncObject();
            static /*0x3a4c9b4*/ System.Net.WebRequest Create(System.Uri requestUri, bool useUriBase);
            static /*0x3a4cde8*/ System.Net.WebRequest Create(string requestUriString);
            static /*0x3a4ceb8*/ System.Net.WebRequest Create(System.Uri requestUri);
            static /*0x3a4cc48*/ System.Collections.ArrayList get_PrefixList();
            static /*0x3a4cf90*/ System.Collections.ArrayList PopulatePrefixList();
            static /*0x3a4d868*/ System.Net.IWebProxy get_InternalDefaultWebProxy();
            static /*0x3a4da3c*/ System.Net.IWebProxy GetSystemWebProxy();
            static /*0x3a4da88*/ System.Net.IWebProxy InternalGetSystemWebProxy();
            /*0x3a4d1a8*/ WebRequest();
            /*0x3a4d1cc*/ WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4d1d4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4d1e0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4d1e4*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x3a4d1e8*/ void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy);
            /*0x3a4d2b8*/ string get_Method();
            /*0x3a4d2dc*/ void set_Method(string value);
            /*0x3a4d300*/ System.Uri get_RequestUri();
            /*0x3a4d324*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3a4d348*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x3a4d36c*/ long get_ContentLength();
            /*0x3a4d390*/ void set_ContentLength(long value);
            /*0x3a4d3b4*/ string get_ContentType();
            /*0x3a4d3d8*/ void set_ContentType(string value);
            /*0x3a4d3fc*/ System.Net.ICredentials get_Credentials();
            /*0x3a4d420*/ void set_Credentials(System.Net.ICredentials value);
            /*0x3a4d444*/ bool get_UseDefaultCredentials();
            /*0x3a4d468*/ System.Net.IWebProxy get_Proxy();
            /*0x3a4d48c*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x3a4d4b0*/ int get_Timeout();
            /*0x3a4d4d4*/ System.Net.WebResponse GetResponse();
            /*0x3a4d4f8*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x3a4d51c*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x3a4d540*/ System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync();
            /*0x3a4d7e4*/ System.Security.Principal.WindowsIdentity SafeCaptureIdenity();
            /*0x3a4d834*/ void Abort();
            /*0x3a4d858*/ System.Net.Cache.RequestCacheProtocol get_CacheProtocol();
            /*0x3a4d860*/ void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value);
            /*0x3a4dde4*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0();

            class DesignerWebRequestCreate : System.Net.IWebRequestCreate
            {
                /*0x3a4dddc*/ DesignerWebRequestCreate();
                /*0x3a4ded8*/ System.Net.WebRequest Create(System.Uri uri);
            }

            class <>c__DisplayClass79_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x3a4d7dc*/ <>c__DisplayClass79_0();
                /*0x3a4df2c*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1();
            }
        }

        class WebResponse : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x18*/ bool m_IsFromCache;

            /*0x3a4e214*/ WebResponse();
            /*0x3a4e21c*/ WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4e224*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4e230*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a4e234*/ void Close();
            /*0x3a4e238*/ void Dispose();
            /*0x3a4e2a4*/ void Dispose(bool disposing);
            /*0x3a4e330*/ bool get_IsFromCache();
            /*0x3a4e338*/ long get_ContentLength();
            /*0x3a4e35c*/ System.IO.Stream GetResponseStream();
            /*0x3a4e380*/ System.Uri get_ResponseUri();
            /*0x3a4e3a4*/ System.Net.WebHeaderCollection get_Headers();
        }

        class WebUtility
        {
            static /*0x0*/ char[] _htmlEntityEndingChars;
            static /*0x8*/ System.Net.Configuration.UnicodeDecodingConformance _htmlDecodeConformance;
            static /*0xc*/ System.Net.Configuration.UnicodeEncodingConformance _htmlEncodeConformance;

            static /*0x3a4e88c*/ WebUtility();
            static /*0x3a4e3c8*/ string UrlDecodeInternal(string value, System.Text.Encoding encoding);
            static /*0x3a4e810*/ string UrlDecode(string encodedValue);
            static /*0x3a4e674*/ int HexToInt(char h);

            class UrlDecoder
            {
                /*0x10*/ int _bufferSize;
                /*0x14*/ int _numChars;
                /*0x18*/ char[] _charBuffer;
                /*0x20*/ int _numBytes;
                /*0x28*/ byte[] _byteBuffer;
                /*0x30*/ System.Text.Encoding _encoding;

                /*0x3a4e5ec*/ UrlDecoder(int bufferSize, System.Text.Encoding encoding);
                /*0x3a4e950*/ void FlushBytes();
                /*0x3a4e754*/ void AddChar(char ch);
                /*0x3a4e6a8*/ void AddByte(byte b);
                /*0x3a4e7b4*/ string GetString();
            }
        }

        class BufferOffsetSize
        {
            /*0x10*/ byte[] Buffer;
            /*0x18*/ int Offset;
            /*0x1c*/ int Size;

            /*0x3a4e9b0*/ BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer);
            /*0x3a4ea68*/ BufferOffsetSize(byte[] buffer, bool copyBuffer);
        }

        class HeaderParser : System.MulticastDelegate
        {
            /*0x3a4ea84*/ HeaderParser(object object, nint method);
            /*0x3a4eb34*/ string[] Invoke(string value);
        }

        class HeaderInfo
        {
            /*0x10*/ bool IsRequestRestricted;
            /*0x11*/ bool IsResponseRestricted;
            /*0x18*/ System.Net.HeaderParser Parser;
            /*0x20*/ string HeaderName;
            /*0x28*/ bool AllowMultiValues;

            /*0x3a4eb48*/ HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, System.Net.HeaderParser p);
        }

        class HeaderInfoTable
        {
            static /*0x0*/ System.Collections.Hashtable HeaderHashTable;
            static /*0x8*/ System.Net.HeaderInfo UnknownHeaderInfo;
            static /*0x10*/ System.Net.HeaderParser SingleParser;
            static /*0x18*/ System.Net.HeaderParser MultiParser;

            static /*0x3a4ee34*/ HeaderInfoTable();
            static /*0x3a4ebb8*/ string[] ParseSingleValue(string value);
            static /*0x3a4ec30*/ string[] ParseMultiValue(string value);
            /*0x3a4c314*/ HeaderInfoTable();
            /*0x3a49bc0*/ System.Net.HeaderInfo get_Item(string name);
        }

        enum CloseExState
        {
            Normal = 0,
            Abort = 1,
            Silent = 2,
        }

        interface ICloseEx
        {
            /*0x1f30b78*/ void CloseEx(System.Net.CloseExState closeState);
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

            static /*0x3a50904*/ System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext();
            /*0x3a509a0*/ LazyAsyncResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x3a50a5c*/ object get_AsyncObject();
            /*0x3a50a64*/ object get_AsyncState();
            /*0x3a50a6c*/ System.AsyncCallback get_AsyncCallback();
            /*0x3a50a74*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x3a50b18*/ bool LazilyCreateEvent(ref System.Threading.ManualResetEvent waitHandle);
            /*0x3a50cf4*/ bool get_CompletedSynchronously();
            /*0x3a50d24*/ bool get_IsCompleted();
            /*0x3a50ce4*/ bool get_InternalPeekCompleted();
            /*0x3a50d54*/ bool get_EndCalled();
            /*0x3a50d5c*/ void set_EndCalled(bool value);
            /*0x3a50d64*/ void ProtectedInvokeCallback(object result, nint userToken);
            /*0x3a50f54*/ void InvokeCallback(object result);
            /*0x3a50f5c*/ void InvokeCallback();
            /*0x3a50f68*/ void Complete(nint userToken);
            /*0x3a510f0*/ void WorkerThreadComplete(object state);
            /*0x3a51194*/ void Cleanup();
            /*0x3a51198*/ object InternalWaitForCompletion();
            /*0x3a511a0*/ object WaitForCompletion(bool snap);

            class ThreadContext
            {
                /*0x10*/ int m_NestedIOCount;

                /*0x3a50998*/ ThreadContext();
            }
        }

        class NetRes
        {
            static /*0x3a48460*/ string GetWebStatusString(string Res, System.Net.WebExceptionStatus Status);
            static /*0x3a51474*/ string GetWebStatusString(System.Net.WebExceptionStatus Status);
            static /*0x3a514d0*/ string GetWebStatusCodeString(System.Net.FtpStatusCode statusCode, string statusDescription);
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

            static /*0x3a516cc*/ TimerThread();
            static /*0x3a4dba8*/ System.Net.TimerThread.Queue CreateQueue(int durationMilliseconds);
            static /*0x3a51a78*/ System.Net.TimerThread.Queue GetOrCreateQueue(int durationMilliseconds);
            static /*0x3a52324*/ void Prod();
            static /*0x3a52434*/ void ThreadProc();
            static /*0x3a52e20*/ void StopTimerThread();
            static /*0x3a52dfc*/ bool IsTickBetween(int start, int end, int comparand);
            static /*0x3a52e9c*/ void OnDomainUnload(object sender, System.EventArgs e);

            class Queue
            {
                /*0x10*/ int m_DurationMilliseconds;

                /*0x3a52f60*/ Queue(int durationMilliseconds);
                /*0x3a52f88*/ int get_Duration();
                /*0x1f30394*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class Timer : System.IDisposable
            {
                /*0x10*/ int m_StartTimeMilliseconds;
                /*0x14*/ int m_DurationMilliseconds;

                /*0x3a52f90*/ Timer(int durationMilliseconds);
                /*0x3a52fc4*/ int get_StartTime();
                /*0x3a52fcc*/ int get_Expiration();
                /*0x1f2fe14*/ bool Cancel();
                /*0x1f2fe14*/ bool get_HasExpired();
                /*0x3a52fd8*/ void Dispose();
            }

            class Callback : System.MulticastDelegate
            {
                /*0x3a52fe4*/ Callback(object object, nint method);
                /*0x3a530f0*/ void Invoke(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            }

            class TimerQueue : System.Net.TimerThread.Queue
            {
                /*0x18*/ nint m_ThisHandle;
                /*0x20*/ System.Net.TimerThread.TimerNode m_Timers;

                /*0x3a519b8*/ TimerQueue(int durationMilliseconds);
                /*0x3a53134*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
                /*0x3a52c5c*/ bool Fire(ref int nextExpiration);
            }

            class InfiniteTimerQueue : System.Net.TimerThread.Queue
            {
                /*0x3a51998*/ InfiniteTimerQueue();
                /*0x3a536c0*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class TimerNode : System.Net.TimerThread.Timer
            {
                /*0x18*/ System.Net.TimerThread.TimerNode.TimerState m_TimerState;
                /*0x20*/ System.Net.TimerThread.Callback m_Callback;
                /*0x28*/ object m_Context;
                /*0x30*/ object m_QueueLock;
                /*0x38*/ System.Net.TimerThread.TimerNode next;
                /*0x40*/ System.Net.TimerThread.TimerNode prev;

                /*0x3a53354*/ TimerNode(System.Net.TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock);
                /*0x3a53104*/ TimerNode();
                /*0x3a53758*/ bool get_HasExpired();
                /*0x3a53768*/ System.Net.TimerThread.TimerNode get_Next();
                /*0x3a53770*/ void set_Next(System.Net.TimerThread.TimerNode value);
                /*0x3a53778*/ System.Net.TimerThread.TimerNode get_Prev();
                /*0x3a53780*/ void set_Prev(System.Net.TimerThread.TimerNode value);
                /*0x3a53788*/ bool Cancel();
                /*0x3a533d0*/ bool Fire();

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

                /*0x3a5372c*/ InfiniteTimer();
                /*0x3a538f4*/ bool get_HasExpired();
                /*0x3a538fc*/ bool Cancel();
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

            static /*0x3a555e0*/ Cookie();
            static /*0x3a53e88*/ bool IsDomainEqualToHost(string domain, string host);
            static /*0x3a54930*/ bool DomainCharsTest(string name);
            static /*0x3a55024*/ System.Collections.IComparer GetComparer();
            /*0x3a53920*/ Cookie();
            /*0x3a53a64*/ string get_Comment();
            /*0x3a53a6c*/ void set_Comment(string value);
            /*0x3a53a8c*/ void set_CommentUri(System.Uri value);
            /*0x3a53a94*/ void set_HttpOnly(bool value);
            /*0x3a53a9c*/ void set_Discard(bool value);
            /*0x3a53aa4*/ string get_Domain();
            /*0x3a53aac*/ void set_Domain(string value);
            /*0x3a53b08*/ string get__Domain();
            /*0x3a53be0*/ bool get_Expired();
            /*0x3a53c94*/ void set_Expires(System.DateTime value);
            /*0x3a53c9c*/ string get_Name();
            /*0x3a53ca4*/ bool InternalSetName(string value);
            /*0x3a53db0*/ string get_Path();
            /*0x3a53db8*/ void set_Path(string value);
            /*0x3a53df8*/ string get__Path();
            /*0x3a53bd0*/ bool get_Plain();
            /*0x3a53ee0*/ bool VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow);
            /*0x3a54a64*/ void set_Port(string value);
            /*0x3a54d78*/ int[] get_PortList();
            /*0x3a54d80*/ string get__Port();
            /*0x3a54e44*/ bool get_Secure();
            /*0x3a54e4c*/ void set_Secure(bool value);
            /*0x3a54e54*/ string get_Value();
            /*0x3a54e5c*/ void set_Value(string value);
            /*0x3a54e88*/ System.Net.CookieVariant get_Variant();
            /*0x3a54e90*/ string get_DomainKey();
            /*0x3a54eac*/ int get_Version();
            /*0x3a54eb4*/ void set_Version(int value);
            /*0x3a54f24*/ string get__Version();
            /*0x3a5507c*/ bool Equals(object comparand);
            /*0x3a5514c*/ int GetHashCode();
            /*0x3a55338*/ string ToString();
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

            static /*0x3a55e24*/ CookieTokenizer();
            /*0x3a55754*/ CookieTokenizer(string tokenStream);
            /*0x3a55794*/ bool get_EndOfCookie();
            /*0x3a5579c*/ void set_EndOfCookie(bool value);
            /*0x3a557a4*/ bool get_Eof();
            /*0x3a557b4*/ string get_Name();
            /*0x3a557bc*/ void set_Name(string value);
            /*0x3a557c4*/ bool get_Quoted();
            /*0x3a557cc*/ void set_Quoted(bool value);
            /*0x3a557d4*/ System.Net.CookieToken get_Token();
            /*0x3a557dc*/ void set_Token(System.Net.CookieToken value);
            /*0x3a557e4*/ string get_Value();
            /*0x3a557ec*/ void set_Value(string value);
            /*0x3a557f4*/ string Extract();
            /*0x3a55850*/ System.Net.CookieToken FindNext(bool ignoreComma, bool ignoreEquals);
            /*0x3a55abc*/ System.Net.CookieToken Next(bool first, bool parseResponseCookies);
            /*0x3a55bf0*/ void Reset();
            /*0x3a55c4c*/ System.Net.CookieToken TokenFromName(bool parseResponseCookies);

            struct RecognizedAttribute
            {
                /*0x10*/ string m_name;
                /*0x18*/ System.Net.CookieToken m_token;

                /*0x3a563d4*/ RecognizedAttribute(string name, System.Net.CookieToken token);
                /*0x3a563fc*/ System.Net.CookieToken get_Token();
                /*0x3a55e00*/ bool IsEqualTo(string value);
            }
        }

        class CookieParser
        {
            /*0x10*/ System.Net.CookieTokenizer m_tokenizer;

            static /*0x3a549cc*/ string CheckQuoted(string value);
            /*0x3a56404*/ CookieParser(string cookieString);
            /*0x3a5647c*/ System.Net.Cookie Get();
        }

        class Comparer : System.Collections.IComparer
        {
            /*0x3a5574c*/ Comparer();
            /*0x3a56a10*/ int System.Collections.IComparer.Compare(object ol, object or);
        }

        class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ int m_version;
            /*0x18*/ System.Collections.ArrayList m_list;
            /*0x20*/ System.DateTime m_TimeStamp;
            /*0x28*/ bool m_has_other_versions;
            /*0x29*/ bool m_IsReadOnly;

            /*0x3a56af4*/ CookieCollection();
            /*0x3a56ba8*/ System.Net.Cookie get_Item(int index);
            /*0x3a56c90*/ void Add(System.Net.Cookie cookie);
            /*0x3a570cc*/ void Add(System.Net.CookieCollection cookies);
            /*0x3a573e8*/ int get_Count();
            /*0x3a57408*/ bool get_IsSynchronized();
            /*0x3a57410*/ object get_SyncRoot();
            /*0x3a57414*/ void CopyTo(System.Array array, int index);
            /*0x3a57434*/ System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how);
            /*0x3a57504*/ bool get_IsOtherVersionSeen();
            /*0x3a5750c*/ int InternalAdd(System.Net.Cookie cookie, bool isStrict);
            /*0x3a56d50*/ int IndexOf(System.Net.Cookie cookie);
            /*0x3a57990*/ void RemoveAt(int idx);
            /*0x3a57390*/ System.Collections.IEnumerator GetEnumerator();

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

                /*0x3a579b0*/ CookieCollectionEnumerator(System.Net.CookieCollection cookies);
                /*0x3a57a18*/ object System.Collections.IEnumerator.get_Current();
                /*0x3a57abc*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x3a57b58*/ void System.Collections.IEnumerator.Reset();
            }
        }

        struct HeaderVariantInfo
        {
            /*0x10*/ string m_name;
            /*0x18*/ System.Net.CookieVariant m_variant;

            /*0x3a57b64*/ HeaderVariantInfo(string name, System.Net.CookieVariant variant);
            /*0x3a57b8c*/ string get_Name();
            /*0x3a57b94*/ System.Net.CookieVariant get_Variant();
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

            static /*0x3a5bba8*/ CookieContainer();
            /*0x3a57b9c*/ CookieContainer();
            /*0x3a57cac*/ void AddRemoveDomain(string key, System.Net.PathList value);
            /*0x3a57dd8*/ void Add(System.Net.Cookie cookie, bool throwOnError);
            /*0x3a58c00*/ bool AgeCookies(string domain);
            /*0x3a59fcc*/ int ExpireCollection(System.Net.CookieCollection cc);
            /*0x3a5a168*/ bool IsLocalDomain(string host);
            /*0x3a5a408*/ System.Net.CookieCollection CookieCutter(System.Uri uri, string headerName, string setCookieHeader, bool isThrow);
            /*0x3a5aaa0*/ System.Net.CookieCollection InternalGetCookies(System.Uri uri);
            /*0x3a5ad94*/ void BuildCookieCollectionFromDomainMatches(System.Uri uri, bool isSecure, int port, System.Net.CookieCollection cookies, System.Collections.Generic.List<string> domainAttribute, bool matchOnlyPlainCookie);
            /*0x3a5b558*/ void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, int port, bool isSecure, bool isPlainOnly);
            /*0x3a5b758*/ string GetCookieHeader(System.Uri uri);
            /*0x3a5b824*/ string GetCookieHeader(System.Uri uri, ref string optCookie2);
        }

        class PathList
        {
            /*0x10*/ System.Collections.SortedList m_list;

            /*0x3a585fc*/ PathList();
            /*0x3a5a148*/ int get_Count();
            /*0x3a586a8*/ int GetCookiesCount();
            /*0x3a59fac*/ System.Collections.ICollection get_Values();
            /*0x3a58adc*/ object get_Item(string s);
            /*0x3a58afc*/ void set_Item(string s, object value);
            /*0x3a5b538*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3a58abc*/ object get_SyncRoot();

            class PathListComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.Net.PathList.PathListComparer StaticInstance;

                static /*0x3a5be34*/ PathListComparer();
                /*0x3a5be2c*/ PathListComparer();
                /*0x3a5bcd0*/ int System.Collections.IComparer.Compare(object ol, object or);
            }
        }

        class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
        {
            /*0x3a5be9c*/ CookieException();
            /*0x3a54928*/ CookieException(string message);
            /*0x3a59fa4*/ CookieException(string message, System.Exception inner);
            /*0x3a5bea4*/ CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5beac*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5beb4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

            static /*0x3a5e034*/ FileWebRequest();
            static /*0x3a5d270*/ void GetRequestStreamCallback(object state);
            static /*0x3a5d53c*/ void GetResponseCallback(object state);
            /*0x3a5bebc*/ FileWebRequest(System.Uri uri);
            /*0x3a5c04c*/ FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5c464*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5c470*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5c6f4*/ bool get_Aborted();
            /*0x3a5c704*/ long get_ContentLength();
            /*0x3a5c70c*/ void set_ContentLength(long value);
            /*0x3a5c784*/ string get_ContentType();
            /*0x3a5c7d8*/ void set_ContentType(string value);
            /*0x3a5c834*/ System.Net.ICredentials get_Credentials();
            /*0x3a5c83c*/ void set_Credentials(System.Net.ICredentials value);
            /*0x3a5c844*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3a5c84c*/ string get_Method();
            /*0x3a5c854*/ void set_Method(string value);
            /*0x3a5c92c*/ System.Net.IWebProxy get_Proxy();
            /*0x3a5c934*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x3a5c93c*/ int get_Timeout();
            /*0x3a5c944*/ System.Uri get_RequestUri();
            /*0x3a5c94c*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x3a5cc48*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x3a5cf10*/ System.Net.WebResponse GetResponse();
            /*0x3a5db90*/ void UnblockReader();
            /*0x3a5dc70*/ bool get_UseDefaultCredentials();
            /*0x3a5dc94*/ void Abort();
        }

        class FileWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x3a4d1a0*/ FileWebRequestCreator();
            /*0x3a5e118*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FileWebStream : System.IO.FileStream, System.Net.ICloseEx
        {
            /*0x70*/ System.Net.FileWebRequest m_request;

            /*0x3a5d498*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing);
            /*0x3a5e170*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, int length, bool async);
            /*0x3a5e22c*/ void Dispose(bool disposing);
            /*0x3a5e2d8*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x3a5e314*/ int Read(byte[] buffer, int offset, int size);
            /*0x3a5e454*/ void Write(byte[] buffer, int offset, int size);
            /*0x3a5e51c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x3a5e5fc*/ int EndRead(System.IAsyncResult ar);
            /*0x3a5e69c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x3a5e77c*/ void EndWrite(System.IAsyncResult ar);
            /*0x3a5e3dc*/ void CheckError();
        }

        class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.Net.ICloseEx
        {
            /*0x19*/ bool m_closed;
            /*0x20*/ long m_contentLength;
            /*0x28*/ System.IO.FileAccess m_fileAccess;
            /*0x30*/ System.Net.WebHeaderCollection m_headers;
            /*0x38*/ System.IO.Stream m_stream;
            /*0x40*/ System.Uri m_uri;

            /*0x3a5d890*/ FileWebResponse(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, bool asyncHint);
            /*0x3a5e81c*/ FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5ea78*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5ea84*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5ec08*/ long get_ContentLength();
            /*0x3a5ec94*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3a5ecac*/ System.Uri get_ResponseUri();
            /*0x3a5ec20*/ void CheckDisposed();
            /*0x3a5ecc4*/ void Close();
            /*0x3a5ed5c*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x3a5eecc*/ System.IO.Stream GetResponseStream();
        }

        interface IWebProxy
        {
            /*0x1f302cc*/ System.Uri GetProxy(System.Uri destination);
            /*0x1f2fec8*/ bool IsBypassed(System.Uri host);
            /*0x1f30214*/ System.Net.ICredentials get_Credentials();
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

            static /*0x3a4da8c*/ System.Net.IWebProxy CreateDefaultProxy();
            static /*0x3a6005c*/ bool AreAllBypassed(System.Collections.Generic.IEnumerable<string> proxies, bool checkFirstOnly);
            static /*0x3a60328*/ System.Uri ProxyUri(string proxyName);
            /*0x3a5ef20*/ WebProxy();
            /*0x3a5ef34*/ WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials);
            /*0x3a5fb48*/ WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a6000c*/ WebProxy(bool enableAutoproxy);
            /*0x3a5f25c*/ System.Uri get_Address();
            /*0x3a5f264*/ bool get_BypassProxyOnLocal();
            /*0x3a5f26c*/ System.Net.ICredentials get_Credentials();
            /*0x3a5f274*/ bool get_UseDefaultCredentials();
            /*0x3a5f2f0*/ void set_UseDefaultCredentials(bool value);
            /*0x3a5f368*/ System.Uri GetProxy(System.Uri destination);
            /*0x3a5f008*/ void UpdateRegExList(bool canThrow);
            /*0x3a5f62c*/ bool IsMatchInBypassList(System.Uri input);
            /*0x3a5f7c4*/ bool IsLocal(System.Uri host);
            /*0x3a5f91c*/ bool IsLocalInProxyHash(System.Uri host);
            /*0x3a5fa0c*/ bool IsBypassed(System.Uri host);
            /*0x3a5f564*/ bool IsBypassedManual(System.Uri host);
            /*0x3a5fed4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a5fee0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a60004*/ System.Net.AutoWebProxyScriptEngine get_ScriptEngine();
            /*0x3a5fec8*/ void UnsafeUpdateFromRegistry();
            /*0x3a5f4e4*/ bool GetProxyAuto(System.Uri destination, ref System.Uri proxyUri);
            /*0x3a5fadc*/ bool IsBypassedAuto(System.Uri destination, ref bool isBypassed);
        }

        class AutoWebProxyScriptEngine
        {
            /*0x3a6003c*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList);
            /*0x3a603c4*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList, ref int syncStatus);
        }

        class UnsafeNclNativeMethods
        {
            class HttpApi
            {
                static /*0x0*/ string[] m_Strings;

                static /*0x3a603e4*/ HttpApi();

                class HTTP_REQUEST_HEADER_ID
                {
                    static /*0x0*/ string[] m_Strings;

                    static /*0x3a60a74*/ HTTP_REQUEST_HEADER_ID();
                    static /*0x3a49dd4*/ string ToString(int position);
                }
            }

            class SecureStringHelper
            {
                static /*0x3a61314*/ string CreateString(System.Security.SecureString secureString);
                static /*0x3a6144c*/ System.Security.SecureString CreateSecureString(string plainString);
            }
        }

        class Logging
        {
            static /*0x3a614e8*/ bool get_On();
        }

        class ServerCertValidationCallback
        {
            /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;
            /*0x18*/ System.Threading.ExecutionContext m_Context;

            /*0x3a614f0*/ ServerCertValidationCallback(System.Net.Security.RemoteCertificateValidationCallback validationCallback);
            /*0x3a6157c*/ System.Net.Security.RemoteCertificateValidationCallback get_ValidationCallback();
            /*0x3a61584*/ void Callback(object state);
            /*0x3a61630*/ bool Invoke(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);

            class CallbackContext
            {
                /*0x10*/ object request;
                /*0x18*/ System.Security.Cryptography.X509Certificates.X509Certificate certificate;
                /*0x20*/ System.Security.Cryptography.X509Certificates.X509Chain chain;
                /*0x28*/ System.Net.Security.SslPolicyErrors sslPolicyErrors;
                /*0x2c*/ bool result;

                /*0x3a617a0*/ CallbackContext(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            }
        }

        class AuthenticationManager
        {
            static /*0x0*/ System.Collections.ArrayList modules;
            static /*0x8*/ object locker;
            static /*0x10*/ System.Net.ICredentialPolicy credential_policy;

            static /*0x3a62564*/ AuthenticationManager();
            static /*0x3a6180c*/ void EnsureModules();
            static /*0x3a61b08*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x3a61c08*/ System.Net.Authorization DoAuthenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x3a6208c*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
        }

        class BasicClient : System.Net.IAuthenticationModule
        {
            static /*0x3a629a8*/ byte[] GetBytes(string str);
            static /*0x3a62698*/ System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a61b00*/ BasicClient();
            /*0x3a625ec*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a62a54*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a62a60*/ string get_AuthenticationType();
        }

        class BindIPEndPoint : System.MulticastDelegate
        {
            /*0x3a62aa0*/ BindIPEndPoint(object object, nint method);
            /*0x3a62bac*/ System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
        }

        class BufferedReadStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.BufferOffsetSize readBuffer;

            /*0x3a62bc0*/ BufferedReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.BufferOffsetSize readBuffer);
            /*0x3a62bf0*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x3a62d58*/ bool TryReadFromBuffer(byte[] buffer, int offset, int size, ref int result);

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

                /*0x3a62de8*/ void MoveNext();
                /*0x3a63148*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ContentDecodeStream : System.Net.WebReadStream
        {
            /*0x40*/ System.IO.Stream <OriginalInnerStream>k__BackingField;

            static /*0x3a631c4*/ System.Net.ContentDecodeStream Create(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.ContentDecodeStream.Mode mode);
            /*0x3a632ac*/ ContentDecodeStream(System.Net.WebOperation operation, System.IO.Stream decodeStream, System.IO.Stream originalInnerStream);
            /*0x3a632dc*/ System.IO.Stream get_OriginalInnerStream();
            /*0x3a632e4*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x3a63304*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);

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

            static /*0x3a63a1c*/ DigestHeaderParser();
            /*0x3a633f4*/ DigestHeaderParser(string header);
            /*0x3a634bc*/ string get_Realm();
            /*0x3a634e4*/ string get_Opaque();
            /*0x3a63510*/ string get_Nonce();
            /*0x3a6353c*/ string get_Algorithm();
            /*0x3a63568*/ string get_QOP();
            /*0x3a63594*/ bool Parse();
            /*0x3a6390c*/ void SkipWhitespace();
            /*0x3a6398c*/ string GetKey();
            /*0x3a6373c*/ bool GetKeywordAndValue(ref string key, ref string value);
        }

        class DigestSession
        {
            static /*0x0*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ System.DateTime lastUse;
            /*0x18*/ int _nc;
            /*0x20*/ System.Security.Cryptography.HashAlgorithm hash;
            /*0x28*/ System.Net.DigestHeaderParser parser;
            /*0x30*/ string _cnonce;

            static /*0x3a63b9c*/ DigestSession();
            /*0x3a63bf8*/ DigestSession();
            /*0x3a63c68*/ string get_Algorithm();
            /*0x3a63c7c*/ string get_Realm();
            /*0x3a63c90*/ string get_Nonce();
            /*0x3a63ca4*/ string get_Opaque();
            /*0x3a63cb8*/ string get_QOP();
            /*0x3a63ccc*/ string get_CNonce();
            /*0x3a63dcc*/ bool Parse(string challenge);
            /*0x3a63ec4*/ string HashToHexString(string toBeHashed);
            /*0x3a64018*/ string HA1(string username, string password);
            /*0x3a6413c*/ string HA2(System.Net.HttpWebRequest webRequest);
            /*0x3a6420c*/ string Response(string username, string password, System.Net.HttpWebRequest webRequest);
            /*0x3a6436c*/ System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a64930*/ System.DateTime get_LastUse();
        }

        class DigestClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Collections.Hashtable cache;

            static /*0x3a656b4*/ DigestClient();
            static /*0x3a64938*/ System.Collections.Hashtable get_Cache();
            static /*0x3a64aa4*/ void CheckExpired(int count);
            /*0x3a61af8*/ DigestClient();
            /*0x3a65278*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a65504*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a65674*/ string get_AuthenticationType();
        }

        class Dns
        {
            static /*0x3a6573c*/ System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state);
            static /*0x3a65994*/ System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult);
            static /*0x3a65aa8*/ bool GetHostByName_icall(string host, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x3a65aac*/ bool GetHostByAddr_icall(string addr, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x3a65ab0*/ bool GetHostName_icall(ref string h_name);
            static /*0x3a65ab4*/ void Error_11001(string hostName);
            static /*0x3a65b18*/ System.Net.IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist);
            static /*0x3a65e58*/ System.Net.IPHostEntry GetHostByAddressFromString(string address, bool parse);
            static /*0x3a65f84*/ System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress);
            static /*0x3a660f0*/ System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address);
            static /*0x3a66240*/ System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress);
            static /*0x3a66158*/ System.Net.IPHostEntry GetHostByName(string hostName);
            static /*0x3a66420*/ string GetHostName();
            static /*0x3a66444*/ System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);

            class GetHostAddressesCallback : System.MulticastDelegate
            {
                /*0x3a658c4*/ GetHostAddressesCallback(object object, nint method);
                /*0x3a66560*/ System.Net.IPAddress[] Invoke(string hostName);
                /*0x3a65974*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x3a65a9c*/ System.Net.IPAddress[] EndInvoke(System.IAsyncResult result);
            }
        }

        class FixedSizeReadStream : System.Net.WebReadStream
        {
            /*0x40*/ long <ContentLength>k__BackingField;
            /*0x48*/ long position;

            /*0x3a6657c*/ FixedSizeReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, long contentLength);
            /*0x3a66574*/ long get_ContentLength();
            /*0x3a665a4*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);

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

                /*0x3a6670c*/ void MoveNext();
                /*0x3a66a58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x3a66ad4*/ HttpRequestCreator();
            /*0x3a66adc*/ System.Net.WebRequest Create(System.Uri uri);
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

            static /*0x3a66d30*/ HttpWebRequest();
            static /*0x3a675d4*/ int get_DefaultMaximumErrorResponseLength();
            static /*0x1ffc854*/ System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationToken cancellationToken);
            static System.Threading.Tasks.Task<T> RunWithTimeoutWorker<T>(System.Threading.Tasks.Task<T> workerTask, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationTokenSource cts);
            static /*0x3a68e98*/ System.Exception FlattenException(System.Exception e);
            static /*0x3a69000*/ System.Net.WebException GetWebException(System.Exception e, bool aborted);
            static /*0x3a691a0*/ System.Net.WebException CreateRequestAbortedException();
            /*0x3a66b34*/ HttpWebRequest(System.Uri uri);
            /*0x3a66e2c*/ HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a6b828*/ HttpWebRequest();
            /*0x3a66db8*/ void ResetAuthorization();
            /*0x3a66fc0*/ void SetSpecialHeaders(string HeaderName, string value);
            /*0x3a67080*/ void set_Accept(string value);
            /*0x3a67138*/ System.Uri get_Address();
            /*0x3a67140*/ bool get_AllowWriteStreamBuffering();
            /*0x3a67148*/ System.Net.DecompressionMethods get_AutomaticDecompression();
            /*0x3a67150*/ bool get_InternalAllowBuffering();
            /*0x3a67164*/ bool get_MethodWithBuffer();
            /*0x3a67260*/ Mono.Net.Security.MobileTlsProvider get_TlsProvider();
            /*0x3a67268*/ Mono.Security.Interface.MonoTlsSettings get_TlsSettings();
            /*0x3a67270*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x3a672e0*/ void set_Connection(string value);
            /*0x3a6746c*/ long get_ContentLength();
            /*0x3a67474*/ void set_ContentLength(long value);
            /*0x3a67500*/ void set_InternalContentLength(long value);
            /*0x3a67508*/ bool get_ThrowOnError();
            /*0x3a67510*/ void set_ThrowOnError(bool value);
            /*0x3a67518*/ string get_ContentType();
            /*0x3a6756c*/ void set_ContentType(string value);
            /*0x3a675c4*/ System.Net.ICredentials get_Credentials();
            /*0x3a675cc*/ void set_Credentials(System.Net.ICredentials value);
            /*0x3a6762c*/ void set_Expect(string value);
            /*0x3a67754*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3a6775c*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x3a67868*/ string get_Host();
            /*0x3a6797c*/ void set_Host(string value);
            /*0x3a67af0*/ bool TryGetHostUri(string hostName, ref System.Uri hostUri);
            /*0x3a67bc0*/ bool get_KeepAlive();
            /*0x3a67bc8*/ int get_ReadWriteTimeout();
            /*0x3a67bd0*/ string get_Method();
            /*0x3a67bd8*/ void set_Method(string value);
            /*0x3a67e24*/ System.Version get_ProtocolVersion();
            /*0x3a67e2c*/ System.Net.IWebProxy get_Proxy();
            /*0x3a67e34*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x3a67fb4*/ void set_Referer(string value);
            /*0x3a68050*/ System.Uri get_RequestUri();
            /*0x3a68058*/ bool get_SendChunked();
            /*0x3a68060*/ System.Net.ServicePoint get_ServicePoint();
            /*0x3a68064*/ System.Net.ServicePoint get_ServicePointNoLock();
            /*0x3a6806c*/ int get_Timeout();
            /*0x3a68074*/ string get_TransferEncoding();
            /*0x3a680c8*/ bool get_UseDefaultCredentials();
            /*0x3a68140*/ void set_UserAgent(string value);
            /*0x3a6819c*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x3a681a4*/ bool get_ExpectContinue();
            /*0x3a681ac*/ void set_ExpectContinue(bool value);
            /*0x3a681b4*/ System.Uri get_AuthUri();
            /*0x3a681bc*/ bool get_ProxyQuery();
            /*0x3a681ec*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            /*0x3a681f4*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            /*0x3a67e78*/ System.Net.ServicePoint GetServicePoint();
            /*0x3a6886c*/ System.Net.WebOperation SendRequest(bool redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x1f302cc*/ System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func);
            /*0x3a68c18*/ System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken);
            /*0x3a68d48*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken);
            /*0x3a68f54*/ System.Net.WebException GetWebException(System.Exception e);
            /*0x3a6925c*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x3a693cc*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x3a69518*/ System.Net.WebResponse GetResponse();
            /*0x3a69644*/ void set_FinishedReading(bool value);
            /*0x3a68fd8*/ bool get_Aborted();
            /*0x3a6964c*/ void Abort();
            /*0x3a69768*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a697a0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a670e0*/ void CheckRequestStarted();
            /*0x3a697d8*/ void DoContinueDelegate(int statusCode, System.Net.WebHeaderCollection headers);
            /*0x3a697f4*/ void RewriteRedirectToGet();
            /*0x3a69878*/ bool Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response);
            /*0x3a69dbc*/ string GetHeaders();
            /*0x3a6a4a4*/ void DoPreAuthenticate();
            /*0x3a6a6a0*/ byte[] GetRequestHeaders();
            /*0x3a6a9e0*/ System.ValueTuple<System.Net.WebOperation, bool> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x3a6ac80*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
            /*0x3a6afb4*/ System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, bool redirect);
            /*0x3a6b1c8*/ System.ValueTuple<bool, bool, System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response);
            /*0x1f2fe14*/ bool <RunWithTimeout>b__242_0<T>();
            /*0x3a6b710*/ System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0();

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

                /*0x3a66f90*/ AuthorizationState(System.Net.HttpWebRequest request, bool isProxy);
                /*0x3a6b860*/ bool get_IsCompleted();
                /*0x3a6b868*/ System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState();
                /*0x3a6b870*/ bool get_IsNtlmAuthenticated();
                /*0x3a6ac98*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
                /*0x3a6b68c*/ void Reset();
                /*0x3a6b890*/ string ToString();
            }

            class <>c__24<T>
            {
                static /*0x0*/ System.Net.HttpWebRequest.<>c__241<T> <>9;
                static /*0x0*/ System.Func<System.Threading.Tasks.Task<T>, System.Nullable<int>> <>9__241_0;

                static /*0x1f33998*/ <>c__24();
                /*0x1f309e4*/ <>c__24();
                System.Nullable<int> <RunWithTimeoutWorker>b__241_0(System.Threading.Tasks.Task<T> t);
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

                /*0x1f309e4*/ void MoveNext();
                /*0x1f30ebc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3a6b97c*/ void MoveNext();
                /*0x3a6ca9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3a6cb18*/ void MoveNext();
                /*0x3a6d70c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<GetRewriteHandler>b__271_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.BufferOffsetSize> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.IO.MemoryStream <ms>5__2;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x3a6d788*/ void MoveNext();
                /*0x3a6dbf8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x3a6dc74*/ HttpWebResponse();
            /*0x3a6dc7c*/ HttpWebResponse(System.Uri uri, string method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers);
            /*0x3a6d3d0*/ HttpWebResponse(System.Uri uri, string method, System.Net.WebResponseStream stream, System.Net.CookieContainer container);
            /*0x3a6df90*/ HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a6e390*/ long get_ContentLength();
            /*0x3a6e398*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3a6e3a0*/ System.Uri get_ResponseUri();
            /*0x3a6e42c*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x3a6e434*/ string get_StatusDescription();
            /*0x3a6e44c*/ System.IO.Stream GetResponseStream();
            /*0x3a6e4f0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a6e4fc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x3a6e6bc*/ void Close();
            /*0x3a6e6ec*/ void System.IDisposable.Dispose();
            /*0x3a6e6fc*/ void Dispose(bool disposing);
            /*0x3a6e3b8*/ void CheckDisposed();
            /*0x3a6dd68*/ void FillCookies();
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

            static /*0x3a6f690*/ string RemoveChunkExtension(string input);
            static /*0x3a6f640*/ void ThrowProtocolViolation(string message);
            /*0x3a6e710*/ MonoChunkParser(System.Net.WebHeaderCollection headers);
            /*0x3a6e7e0*/ int Read(byte[] buffer, int offset, int size);
            /*0x3a6e7e4*/ int ReadFromChunks(byte[] buffer, int offset, int size);
            /*0x3a6eb84*/ void Write(byte[] buffer, int offset, int size);
            /*0x3a6eba4*/ void InternalWrite(byte[] buffer, ref int offset, int size);
            /*0x3a6f4e0*/ bool get_WantMore();
            /*0x3a6f504*/ bool get_DataAvailable();
            /*0x3a6f604*/ int get_ChunkLeft();
            /*0x3a6efd8*/ System.Net.MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size);
            /*0x3a6ece0*/ System.Net.MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size);
            /*0x3a6f118*/ System.Net.MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size);
            /*0x3a6f218*/ System.Net.MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size);

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

                /*0x3a6f610*/ Chunk(byte[] chunk);
                /*0x3a6eb24*/ int Read(byte[] buffer, int offset, int size);
            }
        }

        class MonoChunkStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x48*/ System.Net.MonoChunkParser <Decoder>k__BackingField;

            static /*0x3a6f9e0*/ void ThrowExpectingChunkTrailer();
            /*0x3a6f6e0*/ MonoChunkStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.WebHeaderCollection headers);
            /*0x3a6f6d8*/ System.Net.MonoChunkParser get_Decoder();
            /*0x3a6f780*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x3a6f8e4*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x3a6fa38*/ System.Threading.Tasks.Task <>n__0(System.Threading.CancellationToken cancellationToken);

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

                /*0x3a6fa40*/ void MoveNext();
                /*0x3a6fea4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3a6ff20*/ void MoveNext();
                /*0x3a703d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            /*0x10*/ System.Net.IAuthenticationModule authObject;

            /*0x3a61a8c*/ NtlmClient();
            /*0x3a70438*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a70508*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x3a70510*/ string get_AuthenticationType();
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

            static /*0x3a70a10*/ void PutBytes(byte[] bytes, uint v, int offset);
            /*0x3a70550*/ ServicePoint(System.Net.ServicePointManager.SPKey key, System.Uri uri, int connectionLimit, int maxIdleTime);
            /*0x3a7085c*/ System.Net.ServicePointManager.SPKey get_Key();
            /*0x3a70864*/ System.Net.ServicePointScheduler get_Scheduler();
            /*0x3a7086c*/ void set_Scheduler(System.Net.ServicePointScheduler value);
            /*0x3a70874*/ System.Uri get_Address();
            /*0x3a7087c*/ int get_ConnectionLimit();
            /*0x3a70884*/ System.Version get_ProtocolVersion();
            /*0x3a7088c*/ void set_Expect100Continue(bool value);
            /*0x3a70894*/ bool get_UseNagleAlgorithm();
            /*0x3a7089c*/ void set_UseNagleAlgorithm(bool value);
            /*0x3a6a408*/ bool get_SendContinue();
            /*0x3a708a4*/ void set_SendContinue(bool value);
            /*0x3a708ac*/ void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval);
            /*0x3a7095c*/ void KeepAliveSetup(System.Net.Sockets.Socket socket);
            /*0x3a70a90*/ bool get_UsesProxy();
            /*0x3a70a98*/ void set_UsesProxy(bool value);
            /*0x3a70aa0*/ bool get_UseConnect();
            /*0x3a70aa8*/ void set_UseConnect(bool value);
            /*0x3a70ab0*/ bool get_HasTimedOut();
            /*0x3a70bdc*/ System.Net.IPHostEntry get_HostEntry();
            /*0x3a70fa4*/ void SetVersion(System.Version version);
            /*0x3a68aa0*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x3a71098*/ void FreeServicePoint();
            /*0x3a710ac*/ void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x3a710e8*/ void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x3a71124*/ bool CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote);
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

            static /*0x3a712c8*/ ServicePointManager();
            static /*0x3a71388*/ System.Net.ICertificatePolicy GetLegacyCertificatePolicy();
            static /*0x3a713e0*/ bool get_CheckCertificateRevocationList();
            static /*0x3a71438*/ int get_DnsRefreshTimeout();
            static /*0x3a71490*/ System.Net.SecurityProtocolType get_SecurityProtocol();
            static /*0x3a714e8*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            static /*0x3a71540*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            static /*0x3a6820c*/ System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy);
            static /*0x3a71620*/ void RemoveServicePoint(System.Net.ServicePoint sp);

            class SPKey
            {
                /*0x10*/ System.Uri uri;
                /*0x18*/ System.Uri proxy;
                /*0x20*/ bool use_connect;

                /*0x3a715c8*/ SPKey(System.Uri uri, System.Uri proxy, bool use_connect);
                /*0x3a716b8*/ bool get_UsesProxy();
                /*0x3a71718*/ int GetHashCode();
                /*0x3a717e0*/ bool Equals(object obj);
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

            static /*0x3a73350*/ System.Threading.Tasks.Task<bool> WaitAsync(System.Threading.Tasks.Task workerTask, int millisecondTimeout);
            /*0x3a70658*/ ServicePointScheduler(System.Net.ServicePoint servicePoint, int connectionLimit, int maxIdleTime);
            /*0x3a718d4*/ System.Net.ServicePoint get_ServicePoint();
            /*0x3a718dc*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x3a718e4*/ int get_MaxIdleTime();
            /*0x3a71ad0*/ void Run();
            /*0x3a71dc8*/ System.Threading.Tasks.Task RunScheduler();
            /*0x3a71eb0*/ void Cleanup();
            /*0x3a72100*/ void RunSchedulerIteration();
            /*0x3a72520*/ bool OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation);
            /*0x3a72d88*/ void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection);
            /*0x3a72438*/ bool SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group);
            /*0x3a72ef0*/ void RemoveOperation(System.Net.WebOperation operation);
            /*0x3a72988*/ void RemoveIdleConnection(System.Net.WebConnection connection);
            /*0x3a73008*/ void FinalCleanup();
            /*0x3a70fac*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x3a730d0*/ System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name);
            /*0x3a73328*/ void OnConnectionCreated(System.Net.WebConnection connection);
            /*0x3a73334*/ void OnConnectionClosed(System.Net.WebConnection connection);
            /*0x3a73474*/ System.Threading.Tasks.Task <Run>b__31_0();

            class ConnectionGroup
            {
                static /*0x0*/ int nextId;
                /*0x10*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;
                /*0x20*/ int ID;
                /*0x28*/ System.Collections.Generic.LinkedList<System.Net.WebConnection> connections;
                /*0x30*/ System.Collections.Generic.LinkedList<System.Net.WebOperation> queue;

                /*0x3a71998*/ ConnectionGroup(System.Net.ServicePointScheduler scheduler, string name);
                /*0x3a73478*/ System.Net.ServicePointScheduler get_Scheduler();
                /*0x3a7208c*/ bool IsEmpty();
                /*0x3a72900*/ void RemoveConnection(System.Net.WebConnection connection);
                /*0x3a72aa0*/ void Cleanup();
                /*0x3a732d0*/ void EnqueueOperation(System.Net.WebOperation operation);
                /*0x3a72dc0*/ System.Net.WebOperation GetNextOperation();
                /*0x3a73498*/ System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation);
                /*0x3a72bd0*/ System.ValueTuple<System.Net.WebConnection, bool> CreateOrReuseConnection(System.Net.WebOperation operation, bool force);
            }

            class AsyncManualResetEvent
            {
                /*0x10*/ System.Threading.Tasks.TaskCompletionSource<bool> m_tcs;

                /*0x3a718ec*/ AsyncManualResetEvent(bool state);
                /*0x3a73ef8*/ System.Threading.Tasks.Task<bool> WaitAsync(int millisecondTimeout);
                /*0x3a71b94*/ void Set();
                /*0x3a7237c*/ void Reset();

                class <>c
                {
                    static /*0x0*/ System.Net.ServicePointScheduler.AsyncManualResetEvent.<> <>9;
                    static /*0x8*/ System.Func<object, bool> <>9__4_0;

                    static /*0x3a73f4c*/ <>c();
                    /*0x3a73fb4*/ <>c();
                    /*0x3a73fbc*/ bool <Set>b__4_0(object s);
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

                /*0x3a74068*/ void MoveNext();
                /*0x3a74b84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3a74bec*/ void MoveNext();
                /*0x3a75134*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource<T>
        {
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion;
            /*0x0*/ System.Net.WebCompletionSource.Result<T> currentResult;

            /*0x1f30a84*/ WebCompletionSource(bool runAsync);
            /*0x1f30214*/ System.Net.WebCompletionSource.Result<T> get_CurrentResult();
            /*0x1f30214*/ System.Threading.Tasks.Task get_Task();
            /*0x1ffc854*/ bool TrySetCompleted(T argument);
            /*0x1f2fe14*/ bool TrySetCompleted();
            /*0x1f2fe14*/ bool TrySetCanceled();
            /*0x1f2fec8*/ bool TrySetCanceled(System.OperationCanceledException error);
            /*0x1f2fec8*/ bool TrySetException(System.Exception error);
            /*0x1f309e4*/ void ThrowOnError();
            /*0x1f30214*/ System.Threading.Tasks.Task<T> WaitForCompletion();

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

                /*0x1ffc854*/ Result(T argument);
                /*0x1ffc854*/ Result(System.Net.WebCompletionSource.Status<T> state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x1ffc854*/ System.Net.WebCompletionSource.Status<T> get_Status();
                /*0x1f2fe14*/ bool get_Success();
                /*0x1f30214*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
                /*0x1ffc854*/ T get_Argument();
            }

            struct <WaitForCompletion>d__15<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ System.Net.WebCompletionSource<T> <>4__this;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebCompletionSource.Result<T>> <>u__1;

                /*0x1f309e4*/ void MoveNext();
                /*0x1f30ebc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource : System.Net.WebCompletionSource<object>
        {
            /*0x3a6ca50*/ WebCompletionSource();
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

            static /*0x3a75644*/ System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error);
            static /*0x3a757c0*/ bool ReadLine(byte[] buffer, ref int start, int max, ref string output);
            /*0x3a73ec8*/ WebConnection(System.Net.ServicePoint sPoint);
            /*0x3a751b0*/ System.Net.ServicePoint get_ServicePoint();
            /*0x3a751b8*/ bool CanReuse();
            /*0x3a751e8*/ bool CheckReusable();
            /*0x3a75284*/ System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x3a7539c*/ System.Threading.Tasks.Task<bool> CreateStream(System.Net.WebOperation operation, bool reused, System.Threading.CancellationToken cancellationToken);
            /*0x3a754f8*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x3a7387c*/ bool CanReuseConnection(System.Net.WebOperation operation);
            /*0x3a759a0*/ bool PrepareSharingNtlm(System.Net.WebOperation operation);
            /*0x3a75cb0*/ void Reset();
            /*0x3a75db0*/ void Close(bool reset);
            /*0x3a75e7c*/ void CloseSocket();
            /*0x3a73488*/ bool get_Closed();
            /*0x3a76168*/ System.DateTime get_IdleSince();
            /*0x3a73cbc*/ bool StartOperation(System.Net.WebOperation operation, bool reused);
            /*0x3a72784*/ bool Continue(System.Net.WebOperation next);
            /*0x3a76170*/ void Dispose(bool disposing);
            /*0x3a73480*/ void Dispose();
            /*0x3a75d88*/ void ResetNtlm();
            /*0x3a761a8*/ bool get_NtlmAuthenticated();
            /*0x3a761b0*/ void set_NtlmAuthenticated(bool value);
            /*0x3a761b8*/ System.Net.NetworkCredential get_NtlmCredential();
            /*0x3a761c0*/ void set_NtlmCredential(System.Net.NetworkCredential value);
            /*0x3a761c8*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x3a761d0*/ void set_UnsafeAuthenticatedConnectionSharing(bool value);

            class <>c
            {
                static /*0x0*/ System.Net.WebConnection.<> <>9;
                static /*0x8*/ System.Func<System.Net.IPEndPoint, System.AsyncCallback, object, System.IAsyncResult> <>9__16_0;
                static /*0x10*/ System.Action<System.IAsyncResult> <>9__16_1;

                static /*0x3a761d8*/ <>c();
                /*0x3a76240*/ <>c();
                /*0x3a76248*/ System.IAsyncResult <Connect>b__16_0(System.Net.IPEndPoint targetEndPoint, System.AsyncCallback callback, object state);
                /*0x3a762e8*/ void <Connect>b__16_1(System.IAsyncResult asyncResult);
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

                /*0x3a763dc*/ void MoveNext();
                /*0x3a76d90*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3a76df8*/ void MoveNext();
                /*0x3a77544*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3a775c0*/ void MoveNext();
                /*0x3a77b50*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x3a77bcc*/ WebConnectionStream(System.Net.WebConnection cnc, System.Net.WebOperation operation);
            /*0x3a77cc4*/ System.Net.HttpWebRequest get_Request();
            /*0x3a77ccc*/ System.Net.WebConnection get_Connection();
            /*0x3a77cd4*/ System.Net.WebOperation get_Operation();
            /*0x3a77cdc*/ System.Net.ServicePoint get_ServicePoint();
            /*0x3a77cf4*/ bool get_CanTimeout();
            /*0x3a77cfc*/ int get_ReadTimeout();
            /*0x3a77d04*/ void set_ReadTimeout(int value);
            /*0x3a77d60*/ int get_WriteTimeout();
            /*0x3a77d68*/ void set_WriteTimeout(int value);
            /*0x3a77dc4*/ System.Exception GetException(System.Exception e);
            bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x3a77f28*/ int Read(byte[] buffer, int offset, int count);
            /*0x3a781e4*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x3a783a8*/ int EndRead(System.IAsyncResult r);
            /*0x3a784f4*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x3a786b8*/ void EndWrite(System.IAsyncResult r);
            /*0x3a787ac*/ void Write(byte[] buffer, int offset, int count);
            /*0x3a78998*/ void Flush();
            /*0x3a7899c*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x3a6b680*/ void InternalClose();
            /*0x1f30ebc*/ void Close_internal(ref bool disposed);
            /*0x3a78a80*/ void Close();
            /*0x3a78a94*/ long Seek(long a, System.IO.SeekOrigin b);
            /*0x3a78ae0*/ void SetLength(long a);
            /*0x3a78b2c*/ bool get_CanSeek();
            /*0x3a78b34*/ long get_Length();
            /*0x3a78b80*/ long get_Position();
            /*0x3a78bcc*/ void set_Position(long value);
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

            /*0x39857c4*/ WebConnectionTunnel(System.Net.HttpWebRequest request, System.Uri connectUri);
            /*0x39857b4*/ System.Net.HttpWebRequest get_Request();
            /*0x39857bc*/ System.Uri get_ConnectUri();
            /*0x3985808*/ bool get_Success();
            /*0x3985810*/ void set_Success(bool value);
            /*0x3985818*/ bool get_CloseConnection();
            /*0x3985820*/ void set_CloseConnection(bool value);
            /*0x3985828*/ int get_StatusCode();
            /*0x3985830*/ void set_StatusCode(int value);
            /*0x3985838*/ void set_StatusDescription(string value);
            /*0x3985840*/ string[] get_Challenge();
            /*0x3985848*/ void set_Challenge(string[] value);
            /*0x3985850*/ System.Net.WebHeaderCollection get_Headers();
            /*0x3985858*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x3985860*/ System.Version get_ProxyVersion();
            /*0x3985868*/ void set_ProxyVersion(System.Version value);
            /*0x3985870*/ byte[] get_Data();
            /*0x3985878*/ void set_Data(byte[] value);
            /*0x3985880*/ System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x3985998*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x3985ae8*/ void FlushContents(System.IO.Stream stream, int contentLength);

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

                /*0x3985b78*/ void MoveNext();
                /*0x39868e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3986948*/ void MoveNext();
                /*0x3987288*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x398733c*/ WebOperation(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, bool isNtlmChallenge, System.Threading.CancellationToken cancellationToken);
            /*0x3987304*/ System.Net.HttpWebRequest get_Request();
            /*0x398730c*/ System.Net.WebConnection get_Connection();
            /*0x3987314*/ void set_Connection(System.Net.WebConnection value);
            /*0x398731c*/ System.Net.ServicePoint get_ServicePoint();
            /*0x3987324*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x398732c*/ System.Net.BufferOffsetSize get_WriteBuffer();
            /*0x3987334*/ bool get_IsNtlmChallenge();
            /*0x3987524*/ bool get_Aborted();
            /*0x3987574*/ bool get_Closed();
            /*0x39875a0*/ void Abort();
            /*0x3987798*/ void Close();
            /*0x39876d0*/ void SetCanceled();
            /*0x3987a98*/ void SetError(System.Exception error);
            /*0x39875e0*/ System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo, bool> SetDisposed(ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x3987b3c*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x3987c1c*/ void ThrowIfDisposed();
            /*0x3987c7c*/ void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x3987cfc*/ void ThrowIfClosedOrDisposed();
            /*0x3987d5c*/ void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x3987bc4*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x3987de4*/ void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection);
            /*0x3988074*/ void SetPriorityRequest(System.Net.WebOperation operation);
            /*0x39881f4*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal();
            /*0x3988244*/ System.Net.WebRequestStream get_WriteStream();
            /*0x398825c*/ System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream();
            /*0x39882ac*/ System.Net.WebCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> get_Finished();
            /*0x39882b4*/ void Run();
            /*0x398835c*/ void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error);
            /*0x3987844*/ void Finish(bool ok, System.Exception error);
            /*0x39883dc*/ void <RegisterRequest>b__48_0();

            struct <Run>d__58 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.WebOperation <>4__this;
                /*0x40*/ System.Net.WebRequestStream <requestStream>5__2;
                /*0x48*/ System.Net.WebResponseStream <stream>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0x39883fc*/ void MoveNext();
                /*0x3988cc8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebReadStream : System.IO.Stream
        {
            /*0x28*/ System.Net.WebOperation <Operation>k__BackingField;
            /*0x30*/ System.IO.Stream <InnerStream>k__BackingField;
            /*0x38*/ bool disposed;

            /*0x3988ce4*/ WebReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream);
            /*0x3988cd4*/ System.Net.WebOperation get_Operation();
            /*0x3988cdc*/ System.IO.Stream get_InnerStream();
            /*0x3988d6c*/ long get_Length();
            /*0x3988da4*/ long get_Position();
            /*0x3988ddc*/ void set_Position(long value);
            /*0x3988e14*/ bool get_CanSeek();
            /*0x3988e1c*/ bool get_CanRead();
            /*0x3988e24*/ bool get_CanWrite();
            /*0x3988e2c*/ void SetLength(long value);
            /*0x3988e64*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x3988e9c*/ void Write(byte[] buffer, int offset, int count);
            /*0x3988ed4*/ void Flush();
            /*0x3988f0c*/ System.Exception GetException(System.Exception e);
            /*0x3989074*/ int Read(byte[] buffer, int offset, int size);
            /*0x39892f8*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x39894b8*/ int EndRead(System.IAsyncResult r);
            /*0x3989604*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x3989764*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x3989868*/ void Dispose(bool disposing);

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

                /*0x39898b4*/ void MoveNext();
                /*0x3989e80*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            static /*0x398ae98*/ WebRequestStream();
            /*0x3989efc*/ WebRequestStream(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel);
            /*0x398a080*/ System.IO.Stream get_InnerStream();
            /*0x398a088*/ bool get_KeepAlive();
            /*0x398a090*/ bool get_CanRead();
            /*0x398a098*/ bool get_CanWrite();
            /*0x398a0a0*/ bool get_HasWriteBuffer();
            /*0x398a0d0*/ int get_WriteBufferLength();
            /*0x398a114*/ System.Net.BufferOffsetSize GetWriteBuffer();
            /*0x398a1ec*/ System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken);
            /*0x398a2e4*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x398a544*/ System.Threading.Tasks.Task WriteAsyncInner(byte[] buffer, int offset, int size, System.Net.WebCompletionSource completion, System.Threading.CancellationToken cancellationToken);
            /*0x398a684*/ System.Threading.Tasks.Task ProcessWrite(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x398a7b4*/ void CheckWriteOverflow(long contentLength, long totalWritten, long size);
            /*0x3988a44*/ System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken);
            /*0x398a854*/ System.Threading.Tasks.Task SetHeadersAsync(bool setInternalLength, System.Threading.CancellationToken cancellationToken);
            /*0x398a960*/ System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken);
            /*0x398aa58*/ System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken);
            /*0x398ab50*/ System.Threading.Tasks.Task WriteChunkTrailer();
            /*0x398a848*/ void KillBuffer();
            /*0x398ac38*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x398ace8*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x398ad20*/ void Close_internal(ref bool disposed);

            struct <FinishWriting>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x398af38*/ void MoveNext();
                /*0x398b2a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x398b30c*/ void MoveNext();
                /*0x398b894*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x398b8fc*/ void MoveNext();
                /*0x398bee8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Initialize>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x398bf50*/ void MoveNext();
                /*0x398c2f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SetHeadersAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool setInternalLength;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x398c358*/ void MoveNext();
                /*0x398ca94*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x398cafc*/ void MoveNext();
                /*0x398d098*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer_inner>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x398d100*/ void MoveNext();
                /*0x398d3ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x398d414*/ void MoveNext();
                /*0x398dc30*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x3988b3c*/ WebResponseStream(System.Net.WebRequestStream request);
            /*0x398dc98*/ System.Net.WebRequestStream get_RequestStream();
            /*0x398dca0*/ System.Net.WebHeaderCollection get_Headers();
            /*0x398dca8*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x398dcb0*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x398dcb8*/ void set_StatusCode(System.Net.HttpStatusCode value);
            /*0x398dcc0*/ string get_StatusDescription();
            /*0x398dcc8*/ void set_StatusDescription(string value);
            /*0x398dcd0*/ System.Version get_Version();
            /*0x398dcd8*/ void set_Version(System.Version value);
            /*0x398dce0*/ bool get_KeepAlive();
            /*0x398dce8*/ void set_KeepAlive(bool value);
            /*0x398dcf0*/ bool get_CanRead();
            /*0x398dcf8*/ bool get_CanWrite();
            /*0x398dd00*/ bool get_ChunkedRead();
            /*0x398dd08*/ void set_ChunkedRead(bool value);
            /*0x398dd10*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x398de74*/ System.Threading.Tasks.Task<int> ProcessRead(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x398e128*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x398e1f4*/ bool get_ExpectContent();
            /*0x398e280*/ void Initialize(System.Net.BufferOffsetSize buffer);
            /*0x398e7d4*/ System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(System.Threading.CancellationToken cancellationToken);
            /*0x398e908*/ System.Threading.Tasks.Task ReadAllAsync(bool resending, System.Threading.CancellationToken cancellationToken);
            /*0x398ea18*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x398eab4*/ void Close_internal(ref bool disposed);
            /*0x398eb54*/ System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, string where);
            /*0x3988bd0*/ System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x398ede4*/ bool GetResponse(System.Net.BufferOffsetSize buffer, ref int pos, ref System.Net.ReadState state);

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

                /*0x398f5a4*/ void MoveNext();
                /*0x398ffec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ System.Net.WebResponseStream <>4__this;
                /*0x18*/ byte[] buffer;
                /*0x20*/ int offset;
                /*0x24*/ int size;

                /*0x398e120*/ <>c__DisplayClass41_0();
                /*0x3990068*/ System.Threading.Tasks.Task<int> <ProcessRead>b__0(System.Threading.CancellationToken ct);
                /*0x39900a4*/ void <ProcessRead>b__1();
                /*0x39900e0*/ bool <ProcessRead>b__2();
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

                /*0x3990100*/ void MoveNext();
                /*0x399071c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3990798*/ void MoveNext();
                /*0x3991300*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3991368*/ void MoveNext();
                /*0x3991b04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace NetworkInformation
        {
            class IPGlobalProperties
            {
                static /*0x3991b6c*/ System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties();
                static /*0x3991bb8*/ System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties();
                /*0x3991bbc*/ IPGlobalProperties();
                /*0x1f30214*/ string get_DomainName();
            }

            class NetworkInformationException : System.ComponentModel.Win32Exception
            {
                /*0x3991bc4*/ NetworkInformationException();
                /*0x3991c28*/ NetworkInformationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            }

            enum NetworkInterfaceComponent
            {
                IPv4 = 0,
                IPv6 = 1,
            }

            class IPGlobalPropertiesFactoryPal
            {
                static /*0x3991b70*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }

            class CommonUnixIPGlobalProperties : System.Net.NetworkInformation.IPGlobalProperties
            {
                static /*0x3991cd0*/ int getdomainname(byte[] name, int len);
                /*0x3991ee8*/ CommonUnixIPGlobalProperties();
                /*0x3991d5c*/ string get_DomainName();
            }

            class UnixIPGlobalProperties : System.Net.NetworkInformation.CommonUnixIPGlobalProperties
            {
                /*0x3991ef0*/ UnixIPGlobalProperties();
            }

            class UnixNoLibCIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                /*0x3991f10*/ UnixNoLibCIPGlobalProperties();
                /*0x3991ef8*/ string get_DomainName();
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

                static /*0x39920c4*/ MibIPGlobalProperties();
                /*0x3991f18*/ MibIPGlobalProperties(string procDir);
            }

            class UnixIPGlobalPropertiesFactoryPal
            {
                static /*0x0*/ bool <PlatformNeedsLibCWorkaround>k__BackingField;

                static /*0x3992164*/ bool get_PlatformNeedsLibCWorkaround();
                static /*0x3991c30*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }
        }

        namespace Configuration
        {
            class DefaultProxySectionInternal
            {
                static /*0x0*/ object classSyncObject;
                /*0x10*/ System.Net.IWebProxy webProxy;

                static /*0x39921ac*/ System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode();
                static /*0x39921b4*/ System.Net.IWebProxy GetSystemWebProxy();
                static /*0x39921bc*/ object get_ClassSyncObject();
                static /*0x3992254*/ System.Net.Configuration.DefaultProxySectionInternal GetSection();
                /*0x3992378*/ DefaultProxySectionInternal();
                /*0x3992380*/ System.Net.IWebProxy get_WebProxy();
            }

            enum UnicodeDecodingConformance
            {
                Auto = 0,
                Strict = 1,
                Compat = 2,
                Loose = 3,
            }

            enum UnicodeEncodingConformance
            {
                Auto = 0,
                Strict = 1,
                Compat = 2,
            }

            class SettingsSectionInternal
            {
                static /*0x0*/ System.Net.Configuration.SettingsSectionInternal instance;
                /*0x10*/ bool HttpListenerUnescapeRequestUrl;
                /*0x14*/ System.Net.Sockets.IPProtectionLevel IPProtectionLevel;

                static /*0x3992400*/ SettingsSectionInternal();
                static /*0x3992388*/ System.Net.Configuration.SettingsSectionInternal get_Section();
                /*0x39923e8*/ SettingsSectionInternal();
                /*0x39923e0*/ bool get_Ipv6Enabled();
            }
        }

        namespace Cache
        {
            class RequestCache
            {
                static /*0x0*/ char[] LineSplits;

                static /*0x3992478*/ RequestCache();
            }

            class RequestCacheValidator
            {
                /*0x3992518*/ object CreateValidator();
            }

            class RequestCacheBinding
            {
                /*0x10*/ System.Net.Cache.RequestCache m_RequestCache;
                /*0x18*/ System.Net.Cache.RequestCacheValidator m_CacheValidator;

                /*0x3992550*/ System.Net.Cache.RequestCache get_Cache();
                /*0x3992558*/ System.Net.Cache.RequestCacheValidator get_Validator();
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

                /*0x3992560*/ RequestCachePolicy(System.Net.Cache.RequestCacheLevel level);
                /*0x39925d8*/ System.Net.Cache.RequestCacheLevel get_Level();
                /*0x39925e0*/ string ToString();
            }

            class RequestCacheProtocol
            {
                /*0x3992678*/ RequestCacheProtocol(object arg1, object arg2);
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

                /*0x39926b8*/ NetworkStream(System.Net.Sockets.Socket socket);
                /*0x3992874*/ NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket);
                /*0x39926c4*/ NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access, bool ownsSocket);
                /*0x3992880*/ bool get_CanRead();
                /*0x3992888*/ bool get_CanSeek();
                /*0x3992890*/ bool get_CanWrite();
                /*0x3992898*/ bool get_CanTimeout();
                /*0x39928a0*/ int get_ReadTimeout();
                /*0x3992a8c*/ void set_ReadTimeout(int value);
                /*0x3992cbc*/ int get_WriteTimeout();
                /*0x3992d18*/ void set_WriteTimeout(int value);
                /*0x3992d9c*/ long get_Length();
                /*0x3992de8*/ long get_Position();
                /*0x3992e34*/ void set_Position(long value);
                /*0x3992e80*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x3992ecc*/ int Read(byte[] buffer, int offset, int size);
                /*0x3993264*/ int Read(System.Span<byte> destination);
                /*0x39935bc*/ int ReadByte();
                /*0x39936a4*/ void Write(byte[] buffer, int offset, int size);
                /*0x3993a3c*/ void Write(System.ReadOnlySpan<byte> source);
                /*0x3993d20*/ void WriteByte(byte value);
                /*0x3993dfc*/ void Close(int timeout);
                /*0x3993e60*/ void Dispose(bool disposing);
                /*0x3993f68*/ void Finalize();
                /*0x3993ffc*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x39943c4*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x3994678*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x3994a40*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x3994cf4*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x39953d0*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x3995660*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x3995d70*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x3995ffc*/ void Flush();
                /*0x3996000*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x3996088*/ void SetLength(long value);
                /*0x3992b10*/ void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, int timeout, bool silent);
                /*0x3996214*/ System.Net.Sockets.Socket get_InternalSocket();
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

                static /*0x399e5a0*/ Socket();
                static /*0x3996ed4*/ void CompleteAccept(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                static /*0x3997170*/ void CompleteSendReceive(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                static /*0x3997088*/ System.Exception GetException(System.Net.Sockets.SocketError error, bool wrapExceptionsInIOExceptions);
                static /*0x39979d0*/ bool get_OSSupportsIPv4();
                static /*0x3997a34*/ bool get_OSSupportsIPv6();
                static /*0x39995bc*/ object get_InternalSyncObject();
                static /*0x39975b0*/ void InitializeSockets();
                static /*0x3997814*/ nint Socket_icall(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, ref int error);
                static /*0x3999d24*/ System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x3999e64*/ System.Net.SocketAddress LocalEndPoint_icall(nint socket, int family, ref int error);
                static /*0x3999f34*/ void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool block, ref int error);
                static /*0x399a064*/ void Blocking_icall(nint socket, bool block, ref int error);
                static /*0x399a1b0*/ System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x399a2f0*/ System.Net.SocketAddress RemoteEndPoint_icall(nint socket, int family, ref int error);
                static /*0x399a47c*/ bool Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x399a5c8*/ bool Poll_icall(nint socket, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x399a708*/ System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, ref int error, bool blocking);
                static /*0x399aea8*/ nint Accept_icall(nint sock, ref int error, bool blocking);
                static /*0x399b0e0*/ void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error);
                static /*0x399b210*/ void Bind_icall(nint sock, System.Net.SocketAddress sa, ref int error);
                static /*0x399b2fc*/ void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int backlog, ref int error);
                static /*0x399b42c*/ void Listen_icall(nint sock, int backlog, ref int error);
                static /*0x399c0a8*/ bool BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x399bbe4*/ bool BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x399b7f4*/ void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x399c368*/ void Connect_icall(nint sock, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x399c458*/ void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool reuse, ref int error);
                static /*0x399c758*/ void Disconnect_icall(nint sock, bool reuse, ref int error);
                static /*0x399cc24*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399d020*/ int Receive_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399c8d4*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399d024*/ int Receive_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399d2b8*/ int ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x399d4e0*/ int ReceiveFrom_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x399da78*/ void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, int sent_so_far);
                static /*0x399d62c*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399de30*/ int Send_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399d4e4*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399de34*/ int Send_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x399deec*/ void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x399e034*/ void GetSocketOption_obj_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x3999908*/ void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x399e040*/ void SetSocketOption_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x399e044*/ int IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x399e19c*/ int IOControl_icall(nint sock, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x399e1a8*/ void Close_icall(nint socket, ref int error);
                static /*0x39997d8*/ void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x399e2b4*/ void Shutdown_icall(nint socket, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x399e518*/ void cancel_blocking_socket_operation(System.Threading.Thread thread);
                static /*0x399e51c*/ int get_FamilyHint();
                static /*0x399e59c*/ bool IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                static /*0x3999688*/ bool IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                /*0x399733c*/ Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x3999a68*/ Socket(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle);
                /*0x39962a8*/ System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, int port);
                /*0x39950d4*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, bool fromNetworkStream, System.Threading.CancellationToken cancellationToken);
                /*0x3996670*/ System.Threading.Tasks.Task<int> ReceiveAsyncApm(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x3995a5c*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken);
                /*0x3996a78*/ System.Threading.Tasks.Task<int> SendAsyncApm(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x39972e4*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                /*0x399702c*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                /*0x3997a98*/ nint get_Handle();
                /*0x3997ab0*/ System.Net.Sockets.AddressFamily get_AddressFamily();
                /*0x3997ab8*/ System.Net.Sockets.SocketType get_SocketType();
                /*0x3997ac0*/ System.Net.Sockets.ProtocolType get_ProtocolType();
                /*0x3997ac8*/ int get_ReceiveBufferSize();
                /*0x3997b14*/ int get_SendBufferSize();
                /*0x3997b60*/ void set_DontFragment(bool value);
                /*0x3997cf0*/ bool get_DualMode();
                /*0x3997da8*/ void set_DualMode(bool value);
                /*0x3997e20*/ bool get_IsDualMode();
                /*0x3997e38*/ bool CanTryAddressFamily(System.Net.Sockets.AddressFamily family);
                /*0x3997e68*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x39939dc*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x3993204*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x399872c*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x3998d50*/ int IOControl(System.Net.Sockets.IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x3997818*/ void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level);
                /*0x3996404*/ System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state);
                /*0x39949c8*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x3994c94*/ int EndSend(System.IAsyncResult asyncResult);
                /*0x399434c*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x3994618*/ int EndReceive(System.IAsyncResult asyncResult);
                /*0x3998ec8*/ bool get_CleanedUp();
                /*0x39996dc*/ void Dispose();
                /*0x3999748*/ void Finalize();
                /*0x3993ed8*/ void InternalShutdown(System.Net.Sockets.SocketShutdown how);
                /*0x39960d4*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue, bool silent);
                /*0x39978fc*/ void SocketDefaults();
                /*0x3999bbc*/ System.Net.EndPoint get_LocalEndPoint();
                /*0x3999e68*/ bool get_Blocking();
                /*0x3999e70*/ void set_Blocking(bool value);
                /*0x399a068*/ bool get_Connected();
                /*0x3999b7c*/ void set_NoDelay(bool value);
                /*0x399a0bc*/ System.Net.EndPoint get_RemoteEndPoint();
                /*0x399a2f4*/ bool Poll(int microSeconds, System.Net.Sockets.SelectMode mode);
                /*0x399a5cc*/ System.Net.Sockets.Socket Accept();
                /*0x399a860*/ void Accept(System.Net.Sockets.Socket acceptSocket);
                /*0x399a98c*/ System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state);
                /*0x399ac4c*/ System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult);
                /*0x399ac74*/ System.Net.Sockets.Socket EndAccept(ref byte[] buffer, ref int bytesTransferred, System.IAsyncResult asyncResult);
                /*0x399aeac*/ void Bind(System.Net.EndPoint localEP);
                /*0x399b214*/ void Listen(int backlog);
                /*0x399b430*/ void Connect(System.Net.IPAddress address, int port);
                /*0x399b4a4*/ void Connect(System.Net.EndPoint remoteEP);
                /*0x399b914*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback callback, object state);
                /*0x3998ed8*/ System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x399c2bc*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x399c36c*/ void Disconnect(bool reuseSocket);
                /*0x399c588*/ System.IAsyncResult BeginDisconnect(bool reuseSocket, System.AsyncCallback callback, object state);
                /*0x399c6ac*/ void EndDisconnect(System.IAsyncResult asyncResult);
                /*0x3998620*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x399ca1c*/ int Receive(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x399878c*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x39934bc*/ int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x3993c94*/ int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x399cd6c*/ bool ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x3999330*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x39994d0*/ int EndReceive(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x399d028*/ int ReceiveFrom(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.SocketError errorCode);
                /*0x399d40c*/ int EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult sockares, System.Net.Sockets.SocketAsyncEventArgs ares);
                /*0x39984dc*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x3997ec8*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x399d774*/ bool SendAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x3999014*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x3999244*/ int EndSend(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x399de38*/ int EndSendTo(System.IAsyncResult asyncResult);
                /*0x39928fc*/ object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName);
                /*0x399e038*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, bool optionValue);
                /*0x3997bd4*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue);
                /*0x3998d54*/ int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x399e1a0*/ void Close();
                /*0x3993f60*/ void Close(int timeout);
                /*0x399e1ac*/ void Shutdown(System.Net.Sockets.SocketShutdown how);
                /*0x399e2b8*/ void Dispose(bool disposing);
                /*0x399e318*/ void Linger(nint handle);
                /*0x3999ca8*/ void ThrowIfDisposedAndClosed();
                /*0x399c75c*/ void ThrowIfBufferNull(byte[] buffer);
                /*0x399c7b0*/ void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size);
                /*0x399a070*/ void ThrowIfUdp();
                /*0x399ad70*/ System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, string methodName, string argName);
                /*0x399aaf0*/ void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, nint handle, System.IOSelectorJob job);
                /*0x399cf94*/ void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs e, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x399e47c*/ System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation op);
                /*0x399b028*/ System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input);

                class CachedEventArgs
                {
                    /*0x10*/ System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> TaskAccept;
                    /*0x18*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskReceive;
                    /*0x20*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskSend;
                    /*0x28*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;
                    /*0x30*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;

                    /*0x399ecf8*/ CachedEventArgs();
                }

                class TaskSocketAsyncEventArgs<TResult> : System.Net.Sockets.SocketAsyncEventArgs
                {
                    /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder;
                    /*0x0*/ bool _accessed;

                    /*0x1f309e4*/ TaskSocketAsyncEventArgs();
                    /*0x1ffc854*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(ref bool responsibleForReturningToPool);
                }

                class Int32TaskSocketAsyncEventArgs : System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<int>
                {
                    /*0x99*/ bool _wrapExceptionsInIOExceptions;

                    /*0x399ed00*/ Int32TaskSocketAsyncEventArgs();
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

                    static /*0x399fbd8*/ AwaitableSocketAsyncEventArgs();
                    /*0x399ed48*/ AwaitableSocketAsyncEventArgs();
                    /*0x399ee50*/ bool get_WrapExceptionsInIOExceptions();
                    /*0x399ee58*/ void set_WrapExceptionsInIOExceptions(bool value);
                    /*0x399ee60*/ bool Reserve();
                    /*0x399eedc*/ void Release();
                    /*0x399ef54*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _);
                    /*0x399f474*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Net.Sockets.Socket socket);
                    /*0x399f6ac*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket socket);
                    /*0x399f7b4*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
                    /*0x399f894*/ void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x399f184*/ void InvokeContinuation(System.Action<object> continuation, object state, bool forceAsync);
                    /*0x399fb24*/ int GetResult(short token);
                    /*0x399fb90*/ void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token);
                    /*0x399f848*/ void ThrowIncorrectTokenException();
                    /*0x399fad8*/ void ThrowMultipleContinuationsException();
                    /*0x399fb6c*/ void ThrowException(System.Net.Sockets.SocketError error);
                    /*0x399f5c0*/ System.Exception CreateException(System.Net.Sockets.SocketError error);

                    class <>c
                    {
                        static /*0x0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs.<> <>9;
                        static /*0x8*/ System.Threading.ContextCallback <>9__14_0;
                        static /*0x10*/ System.Threading.SendOrPostCallback <>9__20_0;

                        static /*0x399fd3c*/ <>c();
                        /*0x399fda4*/ <>c();
                        /*0x399fdac*/ void <OnCompleted>b__14_0(object runState);
                        /*0x399ff28*/ void <InvokeContinuation>b__20_0(object s);
                        /*0x39a0054*/ void <.cctor>b__27_0(object state);
                        /*0x39a00a0*/ void <.cctor>b__27_1(object state);
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
                    static /*0x8*/ System.AsyncCallback <>9__10_0;
                    static /*0x10*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__14_0;
                    static /*0x18*/ System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__14_1;
                    static /*0x20*/ System.AsyncCallback <>9__15_0;
                    static /*0x28*/ System.AsyncCallback <>9__15_1;
                    static /*0x30*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__22_0;
                    static /*0x38*/ System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__22_1;
                    static /*0x40*/ System.AsyncCallback <>9__23_0;
                    static /*0x48*/ System.AsyncCallback <>9__23_1;
                    static /*0x50*/ System.IOAsyncCallback <>9__295_0;
                    static /*0x58*/ System.IOAsyncCallback <>9__297_0;

                    static /*0x39a00ec*/ <>c();
                    /*0x39a0154*/ <>c();
                    /*0x39a015c*/ void <ConnectAsync>b__10_0(System.IAsyncResult iar);
                    /*0x39a03b8*/ System.Net.Sockets.Socket.CachedEventArgs <ReceiveAsync>b__14_0();
                    /*0x39a040c*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1();
                    /*0x39a045c*/ void <ReceiveAsyncApm>b__15_0(System.IAsyncResult iar);
                    /*0x39a06b8*/ void <ReceiveAsyncApm>b__15_1(System.IAsyncResult iar);
                    /*0x39a0c20*/ System.Net.Sockets.Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0();
                    /*0x39a0c74*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1();
                    /*0x39a0cc4*/ void <SendAsyncApm>b__23_0(System.IAsyncResult iar);
                    /*0x39a0f20*/ void <SendAsyncApm>b__23_1(System.IAsyncResult iar);
                    /*0x39a12d8*/ void <SendAsync>b__295_0(System.IOAsyncResult s);
                    /*0x39a136c*/ void <BeginSend>b__297_0(System.IOAsyncResult s);
                    /*0x39a1400*/ void <.cctor>b__367_0(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x39a14f8*/ void <.cctor>b__367_1(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x39a15d8*/ void <.cctor>b__367_2(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x39a16b8*/ void <.cctor>b__367_3(System.IAsyncResult ares);
                    /*0x39a1964*/ void <.cctor>b__367_4(System.IOAsyncResult ares);
                    /*0x39a1ad8*/ void <.cctor>b__367_5(System.IOAsyncResult ares);
                    /*0x39a1db4*/ void <.cctor>b__367_6(System.IAsyncResult ares);
                    /*0x39a2060*/ void <.cctor>b__367_7(System.IOAsyncResult ares);
                    /*0x39a2518*/ void <.cctor>b__367_8(System.IAsyncResult ares);
                    /*0x39a27c4*/ void <.cctor>b__367_9(System.IOAsyncResult ares);
                    /*0x39a28d0*/ void <.cctor>b__367_10(System.IAsyncResult ares);
                    /*0x39a2b90*/ void <.cctor>b__367_11(System.IOAsyncResult ares);
                    /*0x39a2e78*/ void <.cctor>b__367_12(System.IOAsyncResult ares);
                    /*0x39a2f90*/ void <.cctor>b__367_13(System.IAsyncResult ares);
                    /*0x39a3264*/ void <.cctor>b__367_14(System.IOAsyncResult ares);
                    /*0x39a3418*/ void <.cctor>b__367_15(System.IAsyncResult ares);
                    /*0x39a36d0*/ void <.cctor>b__367_16(System.IOAsyncResult ares);
                    /*0x39a37e8*/ void <.cctor>b__367_17(System.IAsyncResult ares);
                }

                class <>c__DisplayClass240_0
                {
                    /*0x10*/ System.Net.Sockets.SocketAsyncResult sockares;

                    /*0x39a3aa0*/ <>c__DisplayClass240_0();
                    /*0x39a3aa8*/ void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t);
                }

                class <>c__DisplayClass298_0
                {
                    /*0x10*/ int sent_so_far;

                    /*0x39a3bf8*/ <>c__DisplayClass298_0();
                    /*0x39a3c00*/ void <BeginSendCallback>b__0(System.IOAsyncResult s);
                }

                class <>c__DisplayClass355_0
                {
                    /*0x10*/ System.Net.Sockets.Socket <>4__this;
                    /*0x18*/ System.IOSelectorJob job;
                    /*0x20*/ nint handle;

                    /*0x39a3ca4*/ <>c__DisplayClass355_0();
                    /*0x39a3cac*/ void <QueueIOSelectorJob>b__0(System.Threading.Tasks.Task t);
                }
            }

            class SocketException : System.ComponentModel.Win32Exception
            {
                /*0x90*/ System.Net.EndPoint m_EndPoint;

                static /*0x39a3cf0*/ int WSAGetLastError_icall();
                /*0x39a3cf4*/ SocketException();
                /*0x39a3d14*/ SocketException(int error, string message);
                /*0x399fbd0*/ SocketException(int errorCode);
                /*0x39a3410*/ SocketException(System.Net.Sockets.SocketError socketError);
                /*0x39a3d1c*/ SocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x39a3d24*/ string get_Message();
                /*0x39a195c*/ System.Net.Sockets.SocketError get_SocketErrorCode();
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

                /*0x39a3db4*/ LingerOption(bool enable, int seconds);
                /*0x39a3de4*/ void set_Enabled(bool value);
                /*0x39a3dec*/ void set_LingerTime(int value);
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

                /*0x39a3df4*/ TcpClient();
                /*0x39a3e14*/ TcpClient(System.Net.Sockets.AddressFamily family);
                /*0x39a3f98*/ System.Net.Sockets.Socket get_Client();
                /*0x39a3fa0*/ void set_Client(System.Net.Sockets.Socket value);
                /*0x39a3fa8*/ void Connect(string hostname, int port);
                /*0x39a46ac*/ void Connect(System.Net.IPEndPoint remoteEP);
                /*0x39a47ac*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state);
                /*0x39a4818*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x39a4860*/ System.Threading.Tasks.Task ConnectAsync(string host, int port);
                /*0x39a49d4*/ System.Net.Sockets.NetworkStream GetStream();
                /*0x39a4b18*/ void Dispose(bool disposing);
                /*0x39a4cf0*/ void Dispose();
                /*0x39a4d00*/ void Finalize();
                /*0x39a3f20*/ void initialize();
            }

            class SafeSocketHandle : Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid
            {
                static /*0x0*/ bool THROW_ON_ABORT_RETRIES;
                /*0x20*/ System.Collections.Generic.List<System.Threading.Thread> blocking_threads;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> threads_stacktraces;
                /*0x30*/ bool in_cleanup;

                static /*0x39a5830*/ SafeSocketHandle();
                /*0x39a4d90*/ SafeSocketHandle(nint preexistingHandle, bool ownsHandle);
                /*0x39a4e6c*/ bool ReleaseHandle();
                /*0x39a5504*/ void RegisterForBlockingSyscall();
                /*0x39a5644*/ void UnRegisterForBlockingSyscall();
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

                /*0x399edb8*/ SocketAsyncEventArgs(bool flowExecutionContext);
                /*0x39a58c4*/ System.Net.Sockets.Socket get_AcceptSocket();
                /*0x39a58cc*/ void set_AcceptSocket(System.Net.Sockets.Socket value);
                /*0x39a58d4*/ int get_BytesTransferred();
                /*0x39a58dc*/ void set_BytesTransferred(int value);
                /*0x39a58e4*/ void set_LastOperation(System.Net.Sockets.SocketAsyncOperation value);
                /*0x39a58ec*/ void set_RemoteEndPoint(System.Net.EndPoint value);
                /*0x39a58f4*/ System.Net.Sockets.SocketError get_SocketError();
                /*0x39a58fc*/ void set_SocketError(System.Net.Sockets.SocketError value);
                /*0x39a5904*/ void set_SocketFlags(System.Net.Sockets.SocketFlags value);
                /*0x39a590c*/ object get_UserToken();
                /*0x39a5914*/ void set_UserToken(object value);
                /*0x39a5924*/ void Finalize();
                /*0x39a5934*/ void Dispose(bool disposing);
                /*0x39a5948*/ void Dispose();
                /*0x39a2b88*/ void SetBytesTransferred(int value);
                /*0x39a59ac*/ System.Net.Sockets.Socket get_CurrentSocket();
                /*0x39a59b4*/ void SetCurrentSocket(System.Net.Sockets.Socket socket);
                /*0x39a59bc*/ void SetLastOperation(System.Net.Sockets.SocketAsyncOperation op);
                /*0x39a5a78*/ void Complete_internal();
                /*0x39a5aa0*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x39a5ac8*/ System.Memory<byte> get_MemoryBuffer();
                /*0x39a5ad4*/ int get_Offset();
                /*0x39a5adc*/ int get_Count();
                /*0x39a5ae4*/ System.Collections.Generic.IList<System.ArraySegment<byte>> get_BufferList();
                /*0x39a5aec*/ void SetBuffer(System.Memory<byte> buffer);
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

                /*0x39a591c*/ SocketAsyncResult();
                /*0x39a5d28*/ SocketAsyncResult(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x39a5be4*/ nint get_Handle();
                /*0x39a5bf8*/ void Init(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x39a5d6c*/ System.Net.Sockets.SocketError get_ErrorCode();
                /*0x39a5df0*/ void CheckIfThrowDelayedException();
                /*0x39a5e90*/ void CompleteDisposed();
                /*0x39a231c*/ void Complete();
                /*0x39a5e94*/ void Complete(bool synch);
                /*0x39a2e70*/ void Complete(int total);
                /*0x39a5e9c*/ void Complete(System.Exception e, bool synch);
                /*0x39a1aa0*/ void Complete(System.Exception e);
                /*0x39a1abc*/ void Complete(System.Net.Sockets.Socket s);
                /*0x39a1d88*/ void Complete(System.Net.Sockets.Socket s, int total);

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.SocketAsyncResult.<> <>9;
                    static /*0x8*/ System.Threading.WaitCallback <>9__27_0;

                    static /*0x39a5ec8*/ <>c();
                    /*0x39a5f30*/ <>c();
                    /*0x39a5f38*/ void <Complete>b__27_0(object state);
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

        namespace WebSockets
        {
            class ManagedWebSocket : System.Net.WebSockets.WebSocket
            {
                static /*0x0*/ System.Security.Cryptography.RandomNumberGenerator s_random;
                static /*0x8*/ System.Text.UTF8Encoding s_textEncoding;
                static /*0x10*/ System.Net.WebSockets.WebSocketState[] s_validSendStates;
                static /*0x18*/ System.Net.WebSockets.WebSocketState[] s_validReceiveStates;
                static /*0x20*/ System.Net.WebSockets.WebSocketState[] s_validCloseOutputStates;
                static /*0x28*/ System.Net.WebSockets.WebSocketState[] s_validCloseStates;
                static /*0x30*/ System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> s_cachedCloseTask;
                /*0x10*/ System.IO.Stream _stream;
                /*0x18*/ bool _isServer;
                /*0x20*/ string _subprotocol;
                /*0x28*/ System.Threading.Timer _keepAliveTimer;
                /*0x30*/ System.Threading.CancellationTokenSource _abortSource;
                /*0x38*/ System.Memory<byte> _receiveBuffer;
                /*0x48*/ System.Net.WebSockets.ManagedWebSocket.Utf8MessageState _utf8TextState;
                /*0x50*/ System.Threading.SemaphoreSlim _sendFrameAsyncLock;
                /*0x58*/ System.Net.WebSockets.WebSocketState _state;
                /*0x5c*/ bool _disposed;
                /*0x5d*/ bool _sentCloseFrame;
                /*0x5e*/ bool _receivedCloseFrame;
                /*0x60*/ System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> _closeStatus;
                /*0x68*/ string _closeStatusDescription;
                /*0x70*/ System.Net.WebSockets.ManagedWebSocket.MessageHeader _lastReceiveHeader;
                /*0x88*/ int _receiveBufferOffset;
                /*0x8c*/ int _receiveBufferCount;
                /*0x90*/ int _receivedMaskOffsetOffset;
                /*0x98*/ byte[] _sendBuffer;
                /*0xa0*/ bool _lastSendWasFragment;
                /*0xa8*/ System.Threading.Tasks.Task _lastReceiveAsync;

                static /*0x39a9718*/ ManagedWebSocket();
                static /*0x39a5fb0*/ System.Net.WebSockets.ManagedWebSocket CreateFromConnectedStream(System.IO.Stream stream, bool isServer, string subprotocol, System.TimeSpan keepAliveInterval);
                static /*0x39a831c*/ int WriteHeader(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, byte[] sendBuffer, System.ReadOnlySpan<byte> payload, bool endOfMessage, bool useMask);
                static /*0x39a88e4*/ void WriteRandomMask(byte[] buffer, int offset);
                static /*0x39a8c98*/ bool IsValidCloseStatus(System.Net.WebSockets.WebSocketCloseStatus closeStatus);
                static /*0x39a9008*/ int CombineMaskBytes(System.Span<byte> buffer, int maskOffset);
                static /*0x39a848c*/ int ApplyMask(System.Span<byte> toMask, byte[] mask, int maskOffset, int maskOffsetIndex);
                static /*0x39a93c0*/ int ApplyMask(System.Span<byte> toMask, int mask, int maskIndex);
                static /*0x39a8070*/ System.Exception CreateOperationCanceledException(System.Exception innerException, System.Threading.CancellationToken cancellationToken);
                static /*0x39a9520*/ bool TryValidateUtf8(System.Span<byte> span, bool endOfMessage, System.Net.WebSockets.ManagedWebSocket.Utf8MessageState state);
                /*0x39a6030*/ ManagedWebSocket(System.IO.Stream stream, bool isServer, string subprotocol, System.TimeSpan keepAliveInterval);
                /*0x39a6470*/ object get_StateUpdateLock();
                /*0x39a6478*/ object get_ReceiveAsyncLock();
                /*0x39a6490*/ void Dispose();
                /*0x39a6548*/ void DisposeCore();
                /*0x39a65a0*/ System.Net.WebSockets.WebSocketState get_State();
                /*0x39a65a8*/ System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
                /*0x39a69d8*/ System.Threading.Tasks.ValueTask SendPrivateAsync(System.ReadOnlyMemory<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
                /*0x39a6f6c*/ System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x39a72f0*/ System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
                /*0x39a7704*/ void Abort();
                /*0x39a6e50*/ System.Threading.Tasks.ValueTask SendFrameAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, System.ReadOnlyMemory<byte> payloadBuffer, System.Threading.CancellationToken cancellationToken);
                /*0x39a7734*/ System.Threading.Tasks.ValueTask SendFrameLockAcquiredNonCancelableAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, System.ReadOnlyMemory<byte> payloadBuffer);
                /*0x39a8114*/ System.Threading.Tasks.Task WaitForWriteTaskAsync(System.Threading.Tasks.ValueTask writeTask);
                /*0x39a7c30*/ System.Threading.Tasks.Task SendFrameFallbackAsync(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, System.ReadOnlyMemory<byte> payloadBuffer, System.Threading.CancellationToken cancellationToken);
                /*0x39a7d6c*/ int WriteFrameToSendBuffer(System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode, bool endOfMessage, System.ReadOnlySpan<byte> payloadBuffer);
                /*0x39a854c*/ void SendKeepAliveFrameAsync();
                /*0x1ffc854*/ System.Threading.Tasks.ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>(System.Memory<byte> payloadBuffer, System.Threading.CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter);
                /*0x39a8968*/ System.Threading.Tasks.Task HandleReceivedCloseAsync(System.Net.WebSockets.ManagedWebSocket.MessageHeader header, System.Threading.CancellationToken cancellationToken);
                /*0x39a8a80*/ System.Threading.Tasks.Task WaitForServerToCloseConnectionAsync(System.Threading.CancellationToken cancellationToken);
                /*0x39a8b7c*/ System.Threading.Tasks.Task HandleReceivedPingPongAsync(System.Net.WebSockets.ManagedWebSocket.MessageHeader header, System.Threading.CancellationToken cancellationToken);
                /*0x39a8cd4*/ System.Threading.Tasks.Task CloseWithReceiveErrorAndThrowAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, System.Net.WebSockets.WebSocketError error, System.Exception innerException);
                /*0x39a8de0*/ bool TryParseMessageHeaderFromReceiveBuffer(ref System.Net.WebSockets.ManagedWebSocket.MessageHeader resultHeader);
                /*0x39a75e0*/ System.Threading.Tasks.Task SendCloseFrameAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string closeStatusDescription, System.Threading.CancellationToken cancellationToken);
                /*0x39a8ff4*/ void ConsumeFromBuffer(int count);
                /*0x39a90d8*/ System.Threading.Tasks.Task EnsureBufferContainsAsync(int minimumRequiredBytes, System.Threading.CancellationToken cancellationToken, bool throwOnPrematureClosure);
                /*0x39a91ec*/ void ThrowIfEOFUnexpected(bool throwOnPrematureClosure);
                /*0x39a8218*/ void AllocateSendBuffer(int minLength);
                /*0x39a92a4*/ void ReleaseSendBuffer();
                /*0x39a72cc*/ void ThrowIfOperationInProgress(bool operationCompleted, string methodName);
                /*0x39a94c0*/ void ThrowOperationInProgress(string methodName);

                class Utf8MessageState
                {
                    /*0x10*/ bool SequenceInProgress;
                    /*0x14*/ int AdditionalBytesExpected;
                    /*0x18*/ int ExpectedValueMin;
                    /*0x1c*/ int CurrentDecodeBits;

                    /*0x39a6480*/ Utf8MessageState();
                }

                enum MessageOpcode
                {
                    Continuation = 0,
                    Text = 1,
                    Binary = 2,
                    Close = 8,
                    Ping = 9,
                    Pong = 10,
                }

                struct MessageHeader
                {
                    /*0x10*/ System.Net.WebSockets.ManagedWebSocket.MessageOpcode Opcode;
                    /*0x11*/ bool Fin;
                    /*0x18*/ long PayloadLength;
                    /*0x20*/ int Mask;
                }

                interface IWebSocketReceiveResultGetter<TResult>
                {
                    /*0x1ffc854*/ TResult GetResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, string closeDescription);
                }

                struct WebSocketReceiveResultGetter : System.Net.WebSockets.ManagedWebSocket.IWebSocketReceiveResultGetter<System.Net.WebSockets.WebSocketReceiveResult>
                {
                    /*0x39a99a8*/ System.Net.WebSockets.WebSocketReceiveResult GetResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, string closeDescription);
                }

                class <>c
                {
                    static /*0x0*/ System.Net.WebSockets.ManagedWebSocket.<> <>9;
                    static /*0x8*/ System.Action<object> <>9__36_0;
                    static /*0x10*/ System.Threading.TimerCallback <>9__36_1;
                    static /*0x18*/ System.Action<object> <>9__56_0;
                    static /*0x20*/ System.Action<System.Threading.Tasks.Task> <>9__58_0;
                    static /*0x28*/ System.Action<object> <>9__63_0;

                    static /*0x39a9ae0*/ <>c();
                    /*0x39a9b48*/ <>c();
                    /*0x39a9b50*/ void <.ctor>b__36_0(object s);
                    /*0x39a9c7c*/ void <.ctor>b__36_1(object s);
                    /*0x39a9cdc*/ void <SendFrameFallbackAsync>b__56_0(object s);
                    /*0x39a9d48*/ void <SendKeepAliveFrameAsync>b__58_0(System.Threading.Tasks.Task p);
                    /*0x39a9d60*/ void <WaitForServerToCloseConnectionAsync>b__63_0(object s);
                }

                struct <WaitForWriteTaskAsync>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.Tasks.ValueTask writeTask;
                    /*0x40*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;

                    /*0x39a9dcc*/ void MoveNext();
                    /*0x39aa2b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SendFrameFallbackAsync>d__56 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x38*/ System.Net.WebSockets.ManagedWebSocket.MessageOpcode opcode;
                    /*0x39*/ bool endOfMessage;
                    /*0x40*/ System.ReadOnlyMemory<byte> payloadBuffer;
                    /*0x50*/ System.Threading.CancellationToken cancellationToken;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                    /*0x68*/ System.Threading.CancellationTokenRegistration <>7__wrap1;
                    /*0x80*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2;

                    /*0x39aa31c*/ void MoveNext();
                    /*0x39aac34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>
                {
                    static /*0x0*/ System.Net.WebSockets.ManagedWebSocket.<>c__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> <>9;
                    static /*0x0*/ System.Action<object> <>9__61_0;

                    static /*0x1f33998*/ <>c__61();
                    /*0x1f309e4*/ <>c__61();
                    /*0x1f30ebc*/ void <ReceiveAsyncPrivate>b__61_0(object s);
                }

                struct <ReceiveAsyncPrivate>d__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<TWebSocketReceiveResult> <>t__builder;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x0*/ TWebSocketReceiveResultGetter resultGetter;
                    /*0x0*/ System.Memory<byte> payloadBuffer;
                    /*0x0*/ System.Threading.CancellationTokenRegistration <registration>5__2;
                    /*0x0*/ System.Net.WebSockets.ManagedWebSocket.MessageHeader <header>5__3;
                    /*0x0*/ int <totalBytesReceived>5__4;
                    /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                    /*0x0*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__2;

                    /*0x1f309e4*/ void MoveNext();
                    /*0x1f30ebc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <HandleReceivedCloseAsync>d__62 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x38*/ System.Net.WebSockets.ManagedWebSocket.MessageHeader header;
                    /*0x50*/ System.Threading.CancellationToken cancellationToken;
                    /*0x58*/ System.Net.WebSockets.WebSocketCloseStatus <closeStatus>5__2;
                    /*0x60*/ string <closeStatusDescription>5__3;
                    /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x39aac9c*/ void MoveNext();
                    /*0x39ab794*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WaitForServerToCloseConnectionAsync>d__63 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Threading.CancellationTokenSource <finalCts>5__2;
                    /*0x48*/ System.Threading.CancellationTokenRegistration <>7__wrap2;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

                    /*0x39ab7fc*/ void MoveNext();
                    /*0x39abf54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <HandleReceivedPingPongAsync>d__64 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Net.WebSockets.ManagedWebSocket.MessageHeader header;
                    /*0x48*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x50*/ System.Threading.CancellationToken cancellationToken;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                    /*0x68*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2;

                    /*0x39abfbc*/ void MoveNext();
                    /*0x39ac51c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <CloseWithReceiveErrorAndThrowAsync>d__66 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x38*/ System.Net.WebSockets.WebSocketCloseStatus closeStatus;
                    /*0x3c*/ System.Net.WebSockets.WebSocketError error;
                    /*0x40*/ System.Exception innerException;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x39ac584*/ void MoveNext();
                    /*0x39ac7e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SendCloseFrameAsync>d__69 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ string closeStatusDescription;
                    /*0x38*/ System.Net.WebSockets.WebSocketCloseStatus closeStatus;
                    /*0x40*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ byte[] <buffer>5__2;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;
                    /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0x39ac84c*/ void MoveNext();
                    /*0x39ad0cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <EnsureBufferContainsAsync>d__71 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Net.WebSockets.ManagedWebSocket <>4__this;
                    /*0x38*/ int minimumRequiredBytes;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ bool throwOnPrematureClosure;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

                    /*0x39ad134*/ void MoveNext();
                    /*0x39ad658*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class WebSocketValidate
            {
                static /*0x39a6cfc*/ void ThrowIfInvalidState(System.Net.WebSockets.WebSocketState currentState, bool isDisposed, System.Net.WebSockets.WebSocketState[] validStates);
                static /*0x39ad6ec*/ void ValidateSubprotocol(string subProtocol);
                static /*0x39a7444*/ void ValidateCloseStatus(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription);
                static /*0x39a6840*/ void ValidateArraySegment(System.ArraySegment<byte> arraySegment, string parameterName);
            }

            class ClientWebSocket : System.Net.WebSockets.WebSocket
            {
                /*0x10*/ System.Net.WebSockets.ClientWebSocketOptions _options;
                /*0x18*/ System.Net.WebSockets.WebSocketHandle _innerWebSocket;
                /*0x20*/ int _state;

                /*0x39ad95c*/ ClientWebSocket();
                /*0x39adc38*/ System.Net.WebSockets.WebSocketState get_State();
                /*0x39add0c*/ System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken);
                /*0x39adf88*/ System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, System.Threading.CancellationToken cancellationToken);
                /*0x39ae09c*/ System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
                /*0x39ae1fc*/ System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x39ae270*/ System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
                /*0x39ae2e4*/ void Abort();
                /*0x39ae3b4*/ void Dispose();
                /*0x39ae10c*/ void ThrowIfNotConnected();

                enum InternalState
                {
                    Created = 0,
                    Connecting = 1,
                    Connected = 2,
                    Disposed = 3,
                }

                class DefaultWebProxy : System.Net.IWebProxy
                {
                    static /*0x0*/ System.Net.WebSockets.ClientWebSocket.DefaultWebProxy <Instance>k__BackingField;

                    static /*0x39ae588*/ DefaultWebProxy();
                    static /*0x39ae480*/ System.Net.WebSockets.ClientWebSocket.DefaultWebProxy get_Instance();
                    /*0x39ae580*/ DefaultWebProxy();
                    /*0x39ae4d8*/ System.Net.ICredentials get_Credentials();
                    /*0x39ae510*/ System.Uri GetProxy(System.Uri destination);
                    /*0x39ae548*/ bool IsBypassed(System.Uri host);
                }

                struct <ConnectAsyncCore>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Net.WebSockets.ClientWebSocket <>4__this;
                    /*0x38*/ System.Uri uri;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x39ae5f0*/ void MoveNext();
                    /*0x39aeb5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class ClientWebSocketOptions
            {
                /*0x10*/ bool _isReadOnly;
                /*0x18*/ System.Collections.Generic.List<string> _requestedSubProtocols;
                /*0x20*/ System.Net.WebHeaderCollection _requestHeaders;
                /*0x28*/ System.TimeSpan _keepAliveInterval;
                /*0x30*/ System.Net.IWebProxy _proxy;
                /*0x38*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;
                /*0x40*/ System.Net.CookieContainer _cookies;
                /*0x48*/ int _receiveBufferSize;
                /*0x4c*/ int _sendBufferSize;
                /*0x50*/ System.Nullable<System.ArraySegment<byte>> _buffer;

                /*0x39adb3c*/ ClientWebSocketOptions();
                /*0x39aec18*/ System.Net.WebHeaderCollection get_RequestHeaders();
                /*0x39aec20*/ System.Collections.Generic.List<string> get_RequestedSubProtocols();
                /*0x39adc0c*/ void set_Proxy(System.Net.IWebProxy value);
                /*0x39aec80*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x39aecf0*/ System.Net.CookieContainer get_Cookies();
                /*0x39aecf8*/ System.TimeSpan get_KeepAliveInterval();
                /*0x39aed00*/ int get_ReceiveBufferSize();
                /*0x39aed08*/ int get_SendBufferSize();
                /*0x39aed10*/ System.Nullable<System.ArraySegment<byte>> get_Buffer();
                /*0x39adf7c*/ void SetToReadOnly();
                /*0x39aec28*/ void ThrowIfReadOnly();
            }

            class WebSocketHandle
            {
                static /*0x0*/ System.Text.Encoding s_defaultHttpEncoding;
                [ThreadStatic] static System.Text.StringBuilder t_cachedStringBuilder;
                /*0x10*/ System.Threading.CancellationTokenSource _abortSource;
                /*0x18*/ System.Net.WebSockets.WebSocketState _state;
                /*0x20*/ System.Net.WebSockets.WebSocket _webSocket;

                static /*0x39afd40*/ WebSocketHandle();
                static /*0x39ae9dc*/ System.Net.WebSockets.WebSocketHandle Create();
                static /*0x39adce0*/ bool IsValid(System.Net.WebSockets.WebSocketHandle handle);
                static /*0x39adb38*/ void CheckPlatformSupport();
                static /*0x39aeeec*/ byte[] BuildRequestHeader(System.Uri uri, System.Net.WebSockets.ClientWebSocketOptions options, string secKey);
                static /*0x39af764*/ System.Collections.Generic.KeyValuePair<string, string> CreateSecKeyAndSecWebSocketAccept();
                static /*0x39afb14*/ void ValidateAndTrackHeader(string targetHeaderName, string targetHeaderValue, string foundHeaderName, string foundHeaderValue, ref bool foundHeader);
                static /*0x39afc0c*/ System.Threading.Tasks.Task<string> ReadResponseHeaderLineAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
                /*0x39aed24*/ WebSocketHandle();
                /*0x39adcec*/ System.Net.WebSockets.WebSocketState get_State();
                /*0x39ae45c*/ void Dispose();
                /*0x39ae378*/ void Abort();
                /*0x39ae1dc*/ System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
                /*0x39ae254*/ System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x39ae2c8*/ System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
                /*0x39aea2c*/ System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, System.Threading.CancellationToken cancellationToken, System.Net.WebSockets.ClientWebSocketOptions options);
                /*0x39aed98*/ System.Threading.Tasks.Task<System.Net.Sockets.Socket> ConnectSocketAsync(string host, int port, System.Threading.CancellationToken cancellationToken);
                /*0x39af9b4*/ System.Threading.Tasks.Task<string> ParseAndValidateConnectResponseAsync(System.IO.Stream stream, System.Net.WebSockets.ClientWebSocketOptions options, string expectedSecWebSocketAccept, System.Threading.CancellationToken cancellationToken);

                class <>c
                {
                    static /*0x0*/ System.Net.WebSockets.WebSocketHandle.<> <>9;
                    static /*0x8*/ System.Action<object> <>9__26_0;
                    static /*0x10*/ System.Action<object> <>9__27_0;
                    static /*0x18*/ System.Action<object> <>9__27_1;

                    static /*0x39afda0*/ <>c();
                    /*0x39afe08*/ <>c();
                    /*0x39afe10*/ void <ConnectAsyncCore>b__26_0(object s);
                    /*0x39afe70*/ void <ConnectSocketAsync>b__27_0(object s);
                    /*0x39afef4*/ void <ConnectSocketAsync>b__27_1(object s);
                }

                struct <ConnectAsyncCore>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ System.Net.WebSockets.WebSocketHandle <>4__this;
                    /*0x40*/ System.Uri uri;
                    /*0x48*/ System.Net.WebSockets.ClientWebSocketOptions options;
                    /*0x50*/ System.Threading.CancellationTokenRegistration <registration>5__2;
                    /*0x68*/ System.IO.Stream <stream>5__3;
                    /*0x70*/ System.Collections.Generic.KeyValuePair<string, string> <secKeyAndSecWebSocketAccept>5__4;
                    /*0x80*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.Sockets.Socket> <>u__1;
                    /*0x90*/ System.Net.Security.SslStream <sslStream>5__5;
                    /*0x98*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                    /*0xa8*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__3;

                    /*0x39aff78*/ void MoveNext();
                    /*0x39b106c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ConnectSocketAsync>d__27 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.Sockets.Socket> <>t__builder;
                    /*0x30*/ string host;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Net.WebSockets.WebSocketHandle <>4__this;
                    /*0x48*/ int port;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.IPAddress[]> <>u__1;
                    /*0x60*/ System.Net.IPAddress[] <>7__wrap1;
                    /*0x68*/ int <>7__wrap2;
                    /*0x70*/ System.Net.Sockets.Socket <socket>5__4;
                    /*0x78*/ System.Threading.CancellationTokenRegistration <>7__wrap4;
                    /*0x90*/ System.Threading.CancellationTokenRegistration <>7__wrap5;
                    /*0xa8*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0x39b10d4*/ void MoveNext();
                    /*0x39b1cc4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass30_0
                {
                    /*0x10*/ string headerValue;

                    /*0x39b1d40*/ <>c__DisplayClass30_0();
                    /*0x39b1d48*/ bool <ParseAndValidateConnectResponseAsync>b__0(string requested);
                }

                struct <ParseAndValidateConnectResponseAsync>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder;
                    /*0x30*/ System.IO.Stream stream;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ string expectedSecWebSocketAccept;
                    /*0x48*/ System.Net.WebSockets.ClientWebSocketOptions options;
                    /*0x50*/ bool <foundUpgrade>5__2;
                    /*0x51*/ bool <foundConnection>5__3;
                    /*0x52*/ bool <foundSecWebSocketAccept>5__4;
                    /*0x58*/ string <subprotocol>5__5;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__1;

                    /*0x39b1d60*/ void MoveNext();
                    /*0x39b26f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ReadResponseHeaderLineAsync>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder;
                    /*0x30*/ System.IO.Stream stream;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Text.StringBuilder <sb>5__2;
                    /*0x48*/ byte[] <arr>5__3;
                    /*0x50*/ char <prevChar>5__4;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                    /*0x39b276c*/ void MoveNext();
                    /*0x39b2dbc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class WebSocket : System.IDisposable
            {
                static /*0x39aebc4*/ System.TimeSpan get_DefaultKeepAliveInterval();
                static /*0x39b0ce4*/ System.Net.WebSockets.WebSocket CreateClientWebSocket(System.IO.Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, System.TimeSpan keepAliveInterval, bool useZeroMaskingKey, System.ArraySegment<byte> internalBuffer);
                /*0x39a6488*/ WebSocket();
                /*0x1f2ffc8*/ System.Net.WebSockets.WebSocketState get_State();
                /*0x1f309e4*/ void Abort();
                System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
                /*0x1f309e4*/ void Dispose();
                System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken);
                System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
            }

            enum WebSocketCloseStatus
            {
                NormalClosure = 1000,
                EndpointUnavailable = 1001,
                ProtocolError = 1002,
                InvalidMessageType = 1003,
                Empty = 1005,
                InvalidPayloadData = 1007,
                PolicyViolation = 1008,
                MessageTooBig = 1009,
                MandatoryExtension = 1010,
                InternalServerError = 1011,
            }

            enum WebSocketError
            {
                Success = 0,
                InvalidMessageType = 1,
                Faulted = 2,
                NativeError = 3,
                NotAWebSocket = 4,
                UnsupportedVersion = 5,
                UnsupportedProtocol = 6,
                HeaderError = 7,
                ConnectionClosedPrematurely = 8,
                InvalidState = 9,
            }

            class WebSocketException : System.ComponentModel.Win32Exception
            {
                /*0x90*/ System.Net.WebSockets.WebSocketError _webSocketErrorCode;

                static /*0x39b2edc*/ string GetErrorMessage(System.Net.WebSockets.WebSocketError error);
                static /*0x39b30a8*/ bool Succeeded(int hr);
                /*0x39b2e38*/ WebSocketException();
                /*0x39a926c*/ WebSocketException(System.Net.WebSockets.WebSocketError error);
                /*0x39ad6c0*/ WebSocketException(System.Net.WebSockets.WebSocketError error, string message);
                /*0x39a8030*/ WebSocketException(System.Net.WebSockets.WebSocketError error, System.Exception innerException);
                /*0x39b3078*/ WebSocketException(System.Net.WebSockets.WebSocketError error, string message, System.Exception innerException);
                /*0x39b2e98*/ WebSocketException(int nativeError);
                /*0x39afc04*/ WebSocketException(string message);
                /*0x39b1064*/ WebSocketException(string message, System.Exception innerException);
                /*0x39b30c4*/ WebSocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x39b30cc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x39b3184*/ System.Net.WebSockets.WebSocketError get_WebSocketErrorCode();
                /*0x39b30b4*/ void SetErrorCodeOnError(int nativeError);
            }

            enum WebSocketMessageType
            {
                Text = 0,
                Binary = 1,
                Close = 2,
            }

            class WebSocketReceiveResult
            {
                /*0x10*/ int <Count>k__BackingField;
                /*0x14*/ bool <EndOfMessage>k__BackingField;
                /*0x18*/ System.Net.WebSockets.WebSocketMessageType <MessageType>k__BackingField;
                /*0x1c*/ System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> <CloseStatus>k__BackingField;
                /*0x28*/ string <CloseStatusDescription>k__BackingField;

                /*0x39a999c*/ WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage);
                /*0x39a9a30*/ WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, string closeStatusDescription);
                /*0x39b318c*/ int get_Count();
                /*0x39b3194*/ bool get_EndOfMessage();
            }

            enum WebSocketState
            {
                None = 0,
                Connecting = 1,
                Open = 2,
                CloseSent = 3,
                CloseReceived = 4,
                Closed = 5,
                Aborted = 6,
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

                static /*0x39b38dc*/ SslApplicationProtocol();
                static /*0x39b38c4*/ char GetHexValue(int i);
                /*0x39b319c*/ SslApplicationProtocol(byte[] protocol, bool copy);
                /*0x39b3324*/ bool Equals(System.Net.Security.SslApplicationProtocol other);
                /*0x39b3440*/ bool Equals(object obj);
                /*0x39b34d4*/ int GetHashCode();
                /*0x39b35bc*/ string ToString();
            }

            class SslClientAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.EncryptionPolicy _encryptionPolicy;
                /*0x14*/ System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;
                /*0x18*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
                /*0x1c*/ bool _allowRenegotiation;
                /*0x20*/ string <TargetHost>k__BackingField;
                /*0x28*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;

                /*0x39b3bc8*/ SslClientAuthenticationOptions();
                /*0x39b3a70*/ string get_TargetHost();
                /*0x39b3a78*/ void set_TargetHost(string value);
                /*0x39b3a80*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x39b3a88*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x39b3a90*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x39b3b24*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x39b3bb8*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x39b3bc0*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
            }

            class AuthenticatedStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _InnerStream;
                /*0x30*/ bool _LeaveStreamOpen;

                /*0x39b3bd8*/ AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen);
                /*0x39b3d74*/ System.IO.Stream get_InnerStream();
                /*0x39b3d7c*/ void Dispose(bool disposing);
                /*0x1f2fe14*/ bool get_IsAuthenticated();
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
                /*0x39b3e60*/ LocalCertificateSelectionCallback(object object, nint method);
                /*0x39b3f6c*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class RemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x39b3f80*/ RemoteCertificateValidationCallback(object object, nint method);
                /*0x39b408c*/ bool Invoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
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
                /*0x39b40a0*/ LocalCertSelectionCallback(object object, nint method);
                /*0x39b4154*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class ServerCertSelectionCallback : System.MulticastDelegate
            {
                /*0x39b4168*/ ServerCertSelectionCallback(object object, nint method);
                /*0x39b4218*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string hostName);
            }

            class SslStream : System.Net.Security.AuthenticatedStream
            {
                /*0x38*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x40*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x48*/ System.Net.Security.RemoteCertificateValidationCallback validationCallback;
                /*0x50*/ System.Net.Security.LocalCertificateSelectionCallback selectionCallback;
                /*0x58*/ Mono.Net.Security.MobileAuthenticatedStream impl;
                /*0x60*/ bool explicitSettings;

                static /*0x39b42c0*/ Mono.Net.Security.MobileTlsProvider GetProvider();
                /*0x39b0cdc*/ SslStream(System.IO.Stream innerStream);
                /*0x39b4330*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen);
                /*0x39b43c0*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback);
                /*0x39b43c8*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback);
                /*0x39b4738*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback, System.Net.Security.EncryptionPolicy encryptionPolicy);
                /*0x39b473c*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                /*0x39b422c*/ Mono.Net.Security.MobileAuthenticatedStream get_Impl();
                /*0x39b429c*/ string get_InternalTargetHost();
                /*0x39b4480*/ void SetAndVerifyValidationCallback(System.Net.Security.RemoteCertificateValidationCallback callback);
                /*0x39b457c*/ void SetAndVerifySelectionCallback(System.Net.Security.LocalCertificateSelectionCallback callback);
                /*0x39b4888*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x39b48dc*/ System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState);
                /*0x39b4950*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
                /*0x39b495c*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x39b49b0*/ bool get_IsAuthenticated();
                /*0x39b49dc*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x39b4a00*/ System.Net.Security.SslApplicationProtocol get_NegotiatedApplicationProtocol();
                /*0x39b4a4c*/ bool get_CanSeek();
                /*0x39b4a54*/ bool get_CanRead();
                /*0x39b4a6c*/ bool get_CanTimeout();
                /*0x39b4a88*/ bool get_CanWrite();
                /*0x39b4aa0*/ int get_ReadTimeout();
                /*0x39b4acc*/ void set_ReadTimeout(int value);
                /*0x39b4b08*/ int get_WriteTimeout();
                /*0x39b4b34*/ void set_WriteTimeout(int value);
                /*0x39b4b70*/ long get_Length();
                /*0x39b4b98*/ long get_Position();
                /*0x39b4bc0*/ void set_Position(long value);
                /*0x39b4c18*/ void SetLength(long value);
                /*0x39b4c54*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x39b4cac*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x39b4ccc*/ void Flush();
                /*0x39b4244*/ void CheckDisposed();
                /*0x39b4cec*/ void Dispose(bool disposing);
                /*0x39b4da4*/ int Read(byte[] buffer, int offset, int count);
                /*0x39b4df8*/ void Write(byte[] buffer, int offset, int count);
                /*0x39b4e4c*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x39b4ea8*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x39b4f04*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x39b4f70*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x39b4fcc*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x39b5038*/ void EndWrite(System.IAsyncResult asyncResult);

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ System.Net.Security.LocalCertificateSelectionCallback callback;
                    /*0x18*/ System.Net.Security.SslStream <>4__this;

                    /*0x39b4880*/ <>c__DisplayClass21_0();
                    /*0x39b5044*/ System.Security.Cryptography.X509Certificates.X509Certificate <SetAndVerifySelectionCallback>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
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
    static /*0x194*/ <PrivateImplementationDetails> 3981C8DFF7DC0FD5962B5FB863DD1A0D4119D320706BFF88FD6F636AC6B93AFF;
    static /*0x1a0*/ long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885;
    static /*0x1a8*/ <PrivateImplementationDetails> 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3;
    static /*0x228*/ <PrivateImplementationDetails> 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8;
    static /*0x254*/ <PrivateImplementationDetails> 9DB0F923DCA529159AFF809431DDCC62C801C60246F66B693B861CBF79292994;
    static /*0x260*/ <PrivateImplementationDetails> 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A;
    static /*0x266*/ <PrivateImplementationDetails> B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C;
    static /*0x2e8*/ long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859;
    static /*0x2f0*/ <PrivateImplementationDetails> DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5;
    static /*0x2fe*/ <PrivateImplementationDetails> E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A;

    static /*0x39b507c*/ uint ComputeStringHash(string s);

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
                /*0x39b50f8*/ BypassElementCollection();
            }

            class ConnectionManagementElement : System.Configuration.ConfigurationElement
            {
            }

            class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x39b5130*/ ConnectionManagementElementCollection();
            }

            class ConnectionManagementSection : System.Configuration.ConfigurationSection
            {
                /*0x39b5168*/ ConnectionManagementSection();
                /*0x39b51a0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class DefaultProxySection : System.Configuration.ConfigurationSection
            {
                /*0x39b51d8*/ DefaultProxySection();
                /*0x39b5210*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
                /*0x39b5248*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            }

            class ProxyElement : System.Configuration.ConfigurationElement
            {
                /*0x39b5280*/ ProxyElement();
                /*0x39b52b8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class HttpWebRequestElement : System.Configuration.ConfigurationElement
            {
                /*0x39b52f0*/ HttpWebRequestElement();
                /*0x39b5328*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class Ipv6Element : System.Configuration.ConfigurationElement
            {
                /*0x39b5360*/ Ipv6Element();
                /*0x39b5398*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
            {
                /*0x39b53d0*/ NetSectionGroup();
            }

            class SettingsSection : System.Configuration.ConfigurationSection
            {
                /*0x39b5408*/ SettingsSection();
                /*0x39b5440*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class PerformanceCountersElement : System.Configuration.ConfigurationElement
            {
                /*0x39b5478*/ PerformanceCountersElement();
                /*0x39b54b0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class ServicePointManagerElement : System.Configuration.ConfigurationElement
            {
                /*0x39b54e8*/ ServicePointManagerElement();
                /*0x39b5520*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class SocketElement : System.Configuration.ConfigurationElement
            {
                /*0x39b5558*/ SocketElement();
                /*0x39b5590*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebProxyScriptElement : System.Configuration.ConfigurationElement
            {
                /*0x39b55c8*/ WebProxyScriptElement();
                /*0x39b5600*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModulesSection : System.Configuration.ConfigurationSection
            {
                /*0x39b5638*/ WebRequestModulesSection();
                /*0x39b5670*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x39b56a8*/ WebRequestModuleElementCollection();
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
            /*0x39b56e0*/ DiagnosticsConfigurationHandler();
            /*0x39b5718*/ object Create(object parent, object configContext, System.Xml.XmlNode section);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x39b5750*/ void ThrowNotSupportedException();
    }
}
