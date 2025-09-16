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

        static /*0x745efa8*/ SystemCertificateProvider();
        static /*0x745e8c8*/ Mono.X509PalImpl GetX509Pal();
        static /*0x745e970*/ void EnsureInitialized();
        /*0x745efa0*/ SystemCertificateProvider();
        /*0x745eac4*/ Mono.X509PalImpl get_X509Pal();
        /*0x745eb20*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, Mono.CertificateImportFlags importFlags);
        /*0x745ed80*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x745ed84*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x745ee88*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
        /*0x745ee8c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
    }

    class SystemDependencyProvider : Mono.ISystemDependencyProvider
    {
        static /*0x0*/ Mono.SystemDependencyProvider instance;
        static /*0x8*/ object syncRoot;
        /*0x10*/ Mono.SystemCertificateProvider <CertificateProvider>k__BackingField;

        static /*0x745f294*/ SystemDependencyProvider();
        static /*0x745f01c*/ Mono.SystemDependencyProvider get_Instance();
        static /*0x745f078*/ void Initialize();
        /*0x745f1c8*/ SystemDependencyProvider();
        /*0x745f26c*/ Mono.ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider();
        /*0x745f274*/ Mono.SystemCertificateProvider get_CertificateProvider();
        /*0x745f27c*/ Mono.X509PalImpl get_X509Pal();
    }

    class X509Pal
    {
        static /*0x745f308*/ Mono.X509PalImpl get_Instance();
    }

    class X509PalImplMono : Mono.X509PalImpl
    {
        /*0x745e918*/ X509PalImplMono();
        /*0x745f368*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        /*0x745f36c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x745f370*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
    }

    class X509PalImpl
    {
        static /*0x0*/ byte[] signedData;

        static /*0x745f9c8*/ X509PalImpl();
        static /*0x745f380*/ byte[] PEM(string type, byte[] data);
        static /*0x745f4b4*/ byte[] ConvertData(byte[] data);
        /*0x745f378*/ X509PalImpl();
        /*0x3814a3c*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x3814a3c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
        /*0x745eb8c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data);
        /*0x745ee14*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x745f5c0*/ bool get_SupportsLegacyBasicConstraintsExtension();
        /*0x745f5c8*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
    }

    namespace Util
    {
        class MonoPInvokeCallbackAttribute : System.Attribute
        {
            /*0x745fa68*/ MonoPInvokeCallbackAttribute(System.Type t);
        }
    }

    namespace Unity
    {
        class CertHelper
        {
            static /*0x745fa70*/ void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x745fc48*/ void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class Debug
        {
            static /*0x745febc*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, string context, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x745ff54*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, string context, Mono.Security.Interface.AlertDescription defaultAlert);
        }

        class UnityTls
        {
            static /*0x0*/ Mono.Unity.UnityTls.unitytls_interface_struct marshalledInterface;

            static /*0x7460078*/ nint GetUnityTlsInterface();
            static /*0x746007c*/ bool get_IsSupported();
            static /*0x745fdf8*/ Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface();

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
                /*0x7460094*/ unitytls_x509verify_callback(object object, nint method);
                /*0x7460148*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
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
                /*0x746015c*/ unitytls_tlsctx_write_callback(object object, nint method);
                /*0x7460210*/ nint Invoke(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_read_callback : System.MulticastDelegate
            {
                /*0x7460224*/ unitytls_tlsctx_read_callback(object object, nint method);
                /*0x74602d8*/ nint Invoke(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_trace_callback : System.MulticastDelegate
            {
                /*0x74602ec*/ unitytls_tlsctx_trace_callback(object object, nint method);
                /*0x74603a0*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen);
            }

            class unitytls_tlsctx_certificate_callback : System.MulticastDelegate
            {
                /*0x74603b4*/ unitytls_tlsctx_certificate_callback(object object, nint method);
                /*0x7460468*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_x509verify_callback : System.MulticastDelegate
            {
                /*0x7460484*/ unitytls_tlsctx_x509verify_callback(object object, nint method);
                /*0x7460538*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
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

                /*0x746054c*/ unitytls_interface_struct();

                class unitytls_errorstate_create_t : System.MulticastDelegate
                {
                    /*0x7460554*/ unitytls_errorstate_create_t(object object, nint method);
                    /*0x74605f0*/ Mono.Unity.UnityTls.unitytls_errorstate Invoke();
                }

                class unitytls_errorstate_raise_error_t : System.MulticastDelegate
                {
                    /*0x7460604*/ unitytls_errorstate_raise_error_t(object object, nint method);
                    /*0x74606b8*/ void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode);
                }

                class unitytls_key_get_ref_t : System.MulticastDelegate
                {
                    /*0x74606cc*/ unitytls_key_get_ref_t(object object, nint method);
                    /*0x7460780*/ Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_der_t : System.MulticastDelegate
                {
                    /*0x7460794*/ unitytls_key_parse_der_t(object object, nint method);
                    /*0x7460848*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_pem_t : System.MulticastDelegate
                {
                    /*0x746085c*/ unitytls_key_parse_pem_t(object object, nint method);
                    /*0x7460910*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_free_t : System.MulticastDelegate
                {
                    /*0x7460924*/ unitytls_key_free_t(object object, nint method);
                    /*0x74609d4*/ void Invoke(Mono.Unity.UnityTls.unitytls_key* key);
                }

                class unitytls_x509_export_der_t : System.MulticastDelegate
                {
                    /*0x74609e8*/ unitytls_x509_export_der_t(object object, nint method);
                    /*0x7460a88*/ nint Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_ref_t : System.MulticastDelegate
                {
                    /*0x7460a9c*/ unitytls_x509list_get_ref_t(object object, nint method);
                    /*0x7460b50*/ Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_x509_t : System.MulticastDelegate
                {
                    /*0x7460b64*/ unitytls_x509list_get_x509_t(object object, nint method);
                    /*0x7460c04*/ Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, nint index, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_create_t : System.MulticastDelegate
                {
                    /*0x7460c18*/ unitytls_x509list_create_t(object object, nint method);
                    /*0x7460cc8*/ Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_t : System.MulticastDelegate
                {
                    /*0x7460cdc*/ unitytls_x509list_append_t(object object, nint method);
                    /*0x7460d90*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_der_t : System.MulticastDelegate
                {
                    /*0x7460da4*/ unitytls_x509list_append_der_t(object object, nint method);
                    /*0x7460e58*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_free_t : System.MulticastDelegate
                {
                    /*0x7460e6c*/ unitytls_x509list_free_t(object object, nint method);
                    /*0x7460f1c*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list);
                }

                class unitytls_x509verify_default_ca_t : System.MulticastDelegate
                {
                    /*0x7460f30*/ unitytls_x509verify_default_ca_t(object object, nint method);
                    /*0x7460fd0*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_explicit_ca_t : System.MulticastDelegate
                {
                    /*0x7460fe4*/ unitytls_x509verify_explicit_ca_t(object object, nint method);
                    /*0x7461084*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_server_t : System.MulticastDelegate
                {
                    /*0x746109c*/ unitytls_tlsctx_create_server_t(object object, nint method);
                    /*0x746113c*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_client_t : System.MulticastDelegate
                {
                    /*0x7461178*/ unitytls_tlsctx_create_client_t(object object, nint method);
                    /*0x7461218*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_server_require_client_authentication_t : System.MulticastDelegate
                {
                    /*0x7461254*/ unitytls_tlsctx_server_require_client_authentication_t(object object, nint method);
                    /*0x7461308*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_certificate_callback_t : System.MulticastDelegate
                {
                    /*0x746131c*/ unitytls_tlsctx_set_certificate_callback_t(object object, nint method);
                    /*0x74613d0*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_trace_callback_t : System.MulticastDelegate
                {
                    /*0x74613e4*/ unitytls_tlsctx_set_trace_callback_t(object object, nint method);
                    /*0x7461498*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_x509verify_callback_t : System.MulticastDelegate
                {
                    /*0x74614ac*/ unitytls_tlsctx_set_x509verify_callback_t(object object, nint method);
                    /*0x7461560*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_supported_ciphersuites_t : System.MulticastDelegate
                {
                    /*0x7461574*/ unitytls_tlsctx_set_supported_ciphersuites_t(object object, nint method);
                    /*0x7461628*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_ciphersuite_t : System.MulticastDelegate
                {
                    /*0x746163c*/ unitytls_tlsctx_get_ciphersuite_t(object object, nint method);
                    /*0x74616f0*/ Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_protocol_t : System.MulticastDelegate
                {
                    /*0x7461704*/ unitytls_tlsctx_get_protocol_t(object object, nint method);
                    /*0x74617b8*/ Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_process_handshake_t : System.MulticastDelegate
                {
                    /*0x74617cc*/ unitytls_tlsctx_process_handshake_t(object object, nint method);
                    /*0x7461880*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_read_t : System.MulticastDelegate
                {
                    /*0x7461894*/ unitytls_tlsctx_read_t(object object, nint method);
                    /*0x7461948*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_write_t : System.MulticastDelegate
                {
                    /*0x746195c*/ unitytls_tlsctx_write_t(object object, nint method);
                    /*0x7461a10*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_notify_close_t : System.MulticastDelegate
                {
                    /*0x7461a24*/ unitytls_tlsctx_notify_close_t(object object, nint method);
                    /*0x7461ad8*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_free_t : System.MulticastDelegate
                {
                    /*0x7461aec*/ unitytls_tlsctx_free_t(object object, nint method);
                    /*0x7461b9c*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx);
                }

                class unitytls_random_generate_bytes_t : System.MulticastDelegate
                {
                    /*0x7461bb0*/ unitytls_random_generate_bytes_t(object object, nint method);
                    /*0x7461c64*/ void Invoke(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_result_to_string_t : System.MulticastDelegate
                {
                    /*0x7461c78*/ unitytls_x509verify_result_to_string_t(object object, nint method);
                    /*0x7461d18*/ char* Invoke(Mono.Unity.UnityTls.unitytls_x509verify_result v);
                }

                class unitytls_tlsctx_set_trace_level_t : System.MulticastDelegate
                {
                    /*0x7461d2c*/ unitytls_tlsctx_set_trace_level_t(object object, nint method);
                    /*0x7461de0*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_log_level level);
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

            static /*0x7462bb4*/ void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, ref Mono.Unity.UnityTls.unitytls_x509list* nativeCertChain, ref Mono.Unity.UnityTls.unitytls_key* nativeKey);
            static /*0x7461df4*/ nint WriteCallback(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x7461f04*/ nint ReadCallback(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x7462014*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x746210c*/ void CertificateCallback(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x746221c*/ UnityTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
            /*0x7462f08*/ bool get_IsAuthenticated();
            /*0x7462f10*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
            /*0x7462f18*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
            /*0x7462f20*/ System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
            /*0x74630ec*/ System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
            /*0x74632ac*/ void Renegotiate();
            /*0x74632e4*/ bool PendingRenegotiation();
            /*0x74632ec*/ void Shutdown();
            /*0x7463400*/ void Dispose(bool disposing);
            /*0x74634f8*/ void StartHandshake();
            /*0x7463678*/ bool ProcessHandshake();
            /*0x7463850*/ void FinishHandshake();
            /*0x74639ac*/ nint WriteCallback(byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x7463e10*/ nint ReadCallback(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x7464230*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x74646d8*/ void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class UnityTlsConversions
        {
            static /*0x7462b44*/ Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x7462b7c*/ Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x746398c*/ Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol);
            static /*0x7460024*/ Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x7464ea0*/ System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
            static /*0x7464ed0*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
        }

        class UnityTlsProvider : Mono.Net.Security.MobileTlsProvider
        {
            static /*0x7464f10*/ Mono.Unity.UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x7465b68*/ UnityTlsProvider();
            /*0x7464f74*/ string get_Name();
            /*0x7464fb4*/ System.Guid get_ID();
            /*0x746500c*/ bool get_SupportsSslStream();
            /*0x7465014*/ bool get_SupportsMonoExtensions();
            /*0x746501c*/ bool get_SupportsConnectionInfo();
            /*0x7465024*/ bool get_SupportsCleanShutdown();
            /*0x746502c*/ System.Security.Authentication.SslProtocols get_SupportedProtocols();
            /*0x7465034*/ Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x7465150*/ bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
        }

        class UnityTlsStream : Mono.Net.Security.MobileAuthenticatedStream
        {
            /*0x74650bc*/ UnityTlsStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
            /*0x7465ce8*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
        }

        class X509ChainImplUnityTls : System.Security.Cryptography.X509Certificates.X509ChainImpl
        {
            /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
            /*0x18*/ Mono.Unity.UnityTls.unitytls_x509list* ownedList;
            /*0x20*/ Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain;
            /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
            /*0x30*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;
            /*0x38*/ bool reverseOrder;

            /*0x746463c*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder);
            /*0x7465a8c*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list* ownedList, Mono.Unity.UnityTls.unitytls_errorstate* errorState, bool reverseOrder);
            /*0x7465d50*/ bool get_IsValid();
            /*0x7465d78*/ Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain();
            /*0x7465d80*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
            /*0x7466070*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
            /*0x7466190*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
            /*0x7466198*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
            /*0x74661a0*/ void Reset();
            /*0x7466228*/ void Dispose(bool disposing);
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

                /*0x7466294*/ BufferOffsetSize(byte[] buffer, int offset, int size);
                /*0x7466260*/ int get_EndOffset();
                /*0x746626c*/ int get_Remaining();
                /*0x7466398*/ string ToString();
            }

            class BufferOffsetSize2 : Mono.Net.Security.BufferOffsetSize
            {
                /*0x28*/ int InitialSize;

                /*0x746642c*/ BufferOffsetSize2(int size);
                /*0x746649c*/ void Reset();
                /*0x7466504*/ void MakeRoom(int size);
                /*0x74665d4*/ void AppendData(byte[] buffer, int offset, int size);
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

                /*0x7466644*/ AsyncProtocolResult(int result);
                /*0x746666c*/ AsyncProtocolResult(System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x7466634*/ int get_UserResult();
                /*0x746663c*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
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

                /*0x74666e0*/ AsyncProtocolRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x746669c*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x74666a4*/ bool get_RunSynchronously();
                /*0x74666ac*/ string get_Name();
                /*0x74666d0*/ int get_UserResult();
                /*0x74666d8*/ void set_UserResult(int value);
                /*0x7466778*/ void RequestRead(int size);
                /*0x7466840*/ void RequestWrite();
                /*0x746684c*/ System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken);
                /*0x7466974*/ System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken);
                /*0x7466a80*/ System.Threading.Tasks.Task<System.Nullable<int>> InnerRead(System.Threading.CancellationToken cancellationToken);
                /*0x38145a0*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
                /*0x7466bac*/ string ToString();

                struct <StartOperation>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Mono.Net.Security.AsyncProtocolResult> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x7466c04*/ void MoveNext();
                    /*0x7466fe0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x746705c*/ void MoveNext();
                    /*0x7467840*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x74678a8*/ void MoveNext();
                    /*0x7467d9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AsyncHandshakeRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x7467e18*/ AsyncHandshakeRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x7467e20*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncReadOrWriteRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x38*/ Mono.Net.Security.BufferOffsetSize <UserBuffer>k__BackingField;
                /*0x40*/ int <CurrentSize>k__BackingField;

                /*0x746821c*/ AsyncReadOrWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x7468204*/ Mono.Net.Security.BufferOffsetSize get_UserBuffer();
                /*0x746820c*/ int get_CurrentSize();
                /*0x7468214*/ void set_CurrentSize(int value);
                /*0x74682c0*/ string ToString();
            }

            class AsyncReadRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x746831c*/ AsyncReadRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x7468324*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncWriteRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x74684f0*/ AsyncWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x74684f8*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
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

                static /*0x74686d4*/ Mono.Net.Security.ChainValidationHelper GetInternalValidator(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x7468aa4*/ Mono.Net.Security.ChainValidationHelper Create(Mono.Net.Security.MobileTlsProvider provider, ref Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MonoTlsStream stream);
                static /*0x7468c54*/ System.Net.ServerCertValidationCallback GetValidationCallback(Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x7468e20*/ System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x74687b4*/ ChainValidationHelper(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, bool cloneSettings, Mono.Net.Security.MonoTlsStream stream);
                /*0x7468e5c*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x7468e64*/ bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, ref System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
                /*0x7468ebc*/ Mono.Security.Interface.ValidationResult ValidateCertificate(string host, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x7468f90*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x746905c*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, ref System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x7469464*/ bool InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ Mono.Security.Interface.MonoTlsSettings settings;

                    /*0x7468e18*/ <>c__DisplayClass11_0();
                    /*0x7469520*/ bool <GetValidationCallback>b__0(object s, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, System.Net.Security.SslPolicyErrors e);
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

                static /*0x746ac2c*/ MobileAuthenticatedStream();
                static /*0x7467598*/ System.Exception GetSSPIException(System.Exception e);
                static /*0x7469768*/ System.Exception GetIOException(System.Exception e, string message);
                static /*0x74698e4*/ System.Exception GetInternalError();
                static /*0x7469930*/ System.Exception GetInvalidNestedCallException();
                /*0x7465b78*/ MobileAuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
                /*0x7469680*/ System.Net.Security.SslStream get_SslStream();
                /*0x7469688*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x7469690*/ Mono.Net.Security.MobileTlsProvider get_Provider();
                /*0x7469698*/ string get_TargetHost();
                /*0x74696a0*/ void set_TargetHost(string value);
                /*0x74696a8*/ void CheckThrow(bool authSuccessCheck, bool shutdownCheck);
                /*0x7466fa0*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e);
                /*0x746997c*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x7469cf0*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x7469bc0*/ System.Threading.Tasks.Task ProcessAuthentication(bool runSynchronously, Mono.Net.Security.MonoSslAuthenticationOptions options, System.Threading.CancellationToken cancellationToken);
                /*0x3814a3c*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x7469e0c*/ int Read(byte[] buffer, int offset, int count);
                /*0x746a048*/ void Write(byte[] buffer, int offset, int count);
                /*0x746a114*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x746a1a8*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7469eec*/ System.Threading.Tasks.Task<int> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken);
                /*0x7464124*/ int InternalRead(byte[] buffer, int offset, int size, ref bool outWantMore);
                /*0x746a23c*/ System.ValueTuple<int, bool> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size);
                /*0x7463c28*/ bool InternalWrite(byte[] buffer, int offset, int size);
                /*0x746a3b4*/ bool InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size);
                /*0x7467c54*/ System.Threading.Tasks.Task<int> InnerRead(bool sync, int requestedSize, System.Threading.CancellationToken cancellationToken);
                /*0x746772c*/ System.Threading.Tasks.Task InnerWrite(bool sync, System.Threading.CancellationToken cancellationToken);
                /*0x7467e3c*/ Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status, bool renegotiate);
                /*0x746838c*/ System.ValueTuple<int, bool> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x7468570*/ System.ValueTuple<int, bool> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x746a4a8*/ bool get_IsAuthenticated();
                /*0x746a594*/ void Dispose(bool disposing);
                /*0x746a7ec*/ void Flush();
                /*0x746a810*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x746a8f0*/ System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate();
                /*0x746a9f4*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x746aa2c*/ void SetLength(long value);
                /*0x746aa50*/ bool get_CanRead();
                /*0x746aa94*/ bool get_CanTimeout();
                /*0x746aab4*/ bool get_CanWrite();
                /*0x746ab18*/ bool get_CanSeek();
                /*0x746ab20*/ long get_Length();
                /*0x746ab40*/ long get_Position();
                /*0x746ab64*/ void set_Position(long value);
                /*0x746ab9c*/ int get_ReadTimeout();
                /*0x746abc0*/ void set_ReadTimeout(int value);
                /*0x746abe4*/ int get_WriteTimeout();
                /*0x746ac08*/ void set_WriteTimeout(int value);
                /*0x746ac78*/ void <InnerWrite>b__67_0();

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

                    /*0x746acac*/ void MoveNext();
                    /*0x746b608*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x746b670*/ void MoveNext();
                    /*0x746be40*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass66_0
                {
                    /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x18*/ int len;

                    /*0x746bebc*/ <>c__DisplayClass66_0();
                    /*0x746bec4*/ int <InnerRead>b__0();
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

                    /*0x746bf0c*/ void MoveNext();
                    /*0x746c3c8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerWrite>d__67 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x746c444*/ void MoveNext();
                    /*0x746c750*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x7462998*/ MobileTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x746c7b8*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x74633e4*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x3813ffc*/ bool get_IsAuthenticated();
                /*0x746c7c0*/ bool get_IsServer();
                /*0x746c7c8*/ string get_TargetHost();
                /*0x746c7d0*/ string get_ServerName();
                /*0x746c7d8*/ bool get_AskForClientCertificate();
                /*0x746c7e0*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x38159dc*/ void StartHandshake();
                /*0x3813ffc*/ bool ProcessHandshake();
                /*0x38159dc*/ void FinishHandshake();
                /*0x746c7e8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate();
                /*0x746c7f0*/ void set_LocalServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
                /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
                System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
                System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
                /*0x38159dc*/ void Shutdown();
                /*0x3813ffc*/ bool PendingRenegotiation();
                /*0x7463800*/ bool ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x74649c8*/ System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(string[] acceptableIssuers);
                /*0x38159dc*/ void Renegotiate();
                /*0x746a77c*/ void Dispose();
                /*0x746c7f8*/ void Dispose(bool disposing);
                /*0x746c7fc*/ void Finalize();
            }

            class MobileTlsProvider : Mono.Security.Interface.MonoTlsProvider
            {
                /*0x7465b70*/ MobileTlsProvider();
                Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
                bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
            }

            class MonoSslAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;

                /*0x746c8a8*/ MonoSslAuthenticationOptions();
                /*0x3813ffc*/ bool get_ServerMode();
                /*0x3814574*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x3815ed0*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x3815ed0*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x3815ed0*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x38148bc*/ string get_TargetHost();
                /*0x3816710*/ void set_TargetHost(string value);
                /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x3816710*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x3813ffc*/ bool get_ClientCertificateRequired();
                /*0x746c8a0*/ System.Net.Security.ServerCertSelectionCallback get_ServerCertSelectionDelegate();
            }

            class MonoSslClientAuthenticationOptions : Mono.Net.Security.MonoSslAuthenticationOptions
            {
                /*0x18*/ System.Net.Security.SslClientAuthenticationOptions <Options>k__BackingField;

                /*0x7469b54*/ MonoSslClientAuthenticationOptions();
                /*0x746c8b0*/ System.Net.Security.SslClientAuthenticationOptions get_Options();
                /*0x746c8b8*/ bool get_ServerMode();
                /*0x746c8c0*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x746c8dc*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x746c8f8*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x746c914*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x746c930*/ string get_TargetHost();
                /*0x746c94c*/ void set_TargetHost(string value);
                /*0x746c968*/ bool get_ClientCertificateRequired();
                /*0x746c9a0*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x746c9bc*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x746c9d8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
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

                static /*0x746d87c*/ MonoTlsProviderFactory();
                static /*0x7468b38*/ Mono.Net.Security.MobileTlsProvider GetProviderInternal();
                static /*0x746ca10*/ void InitializeInternal();
                static /*0x746d148*/ Mono.Net.Security.MobileTlsProvider LookupProvider(string name, bool throwOnError);
                static /*0x746cdbc*/ void InitializeProviderRegistration();
                static /*0x746d6a0*/ void PopulateUnityProviders();
                static /*0x746d7e0*/ void PopulateProviders();
                static /*0x746cfc0*/ Mono.Net.Security.MobileTlsProvider CreateDefaultProviderImpl();
                static /*0x746d830*/ Mono.Net.Security.MobileTlsProvider GetProvider();
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

                /*0x746d9e0*/ MonoTlsStream(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream);
                /*0x746d9bc*/ System.Net.HttpWebRequest get_Request();
                /*0x746d9c4*/ System.Net.WebExceptionStatus get_ExceptionStatus();
                /*0x746d9cc*/ bool get_CertificateValidationFailed();
                /*0x746d9d4*/ void set_CertificateValidationFailed(bool value);
                /*0x746dc0c*/ System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken);
                /*0x746dd58*/ void Dispose();
                /*0x746dd5c*/ void CloseSslStream();

                struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoTlsStream <>4__this;
                    /*0x38*/ System.Net.WebConnectionTunnel tunnel;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Net.Sockets.Socket <socket>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x746de40*/ void MoveNext();
                    /*0x746e594*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NoReflectionHelper
            {
                static /*0x746e610*/ object GetProvider();
            }

            class SystemCertificateValidator
            {
                static /*0x0*/ bool is_macosx;
                static /*0x4*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;

                static /*0x746e65c*/ SystemCertificateValidator();
                static /*0x7469518*/ bool NeedsChain(Mono.Security.Interface.MonoTlsSettings settings);
            }

            namespace Private
            {
                class CallbackHelpers
                {
                    static /*0x746db44*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback PublicToMono(System.Net.Security.RemoteCertificateValidationCallback callback);
                    static /*0x7468d50*/ System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback callback;

                        /*0x746e6ac*/ <>c__DisplayClass0_0();
                        /*0x746e6bc*/ bool <PublicToMono>b__0(string h, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, Mono.Security.Interface.MonoSslPolicyErrors e);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback;

                        /*0x746e6b4*/ <>c__DisplayClass6_0();
                        /*0x746e6e0*/ System.Security.Cryptography.X509Certificates.X509Certificate <MonoToInternal>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
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

            /*0x746e704*/ NtlmSession();
            /*0x746e70c*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession> cache;

            static /*0x746ef64*/ NtlmClient();
            /*0x746ef5c*/ NtlmClient();
            /*0x746eba0*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x746ef14*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x746ef1c*/ string get_AuthenticationType();

            class <>c
            {
                static /*0x0*/ Mono.Http.NtlmClient.<> <>9;
                static /*0x8*/ System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<System.Net.HttpWebRequest, Mono.Http.NtlmSession> <>9__1_0;

                static /*0x746effc*/ <>c();
                /*0x746f064*/ <>c();
                /*0x746f06c*/ Mono.Http.NtlmSession <Authenticate>b__1_0(System.Net.HttpWebRequest x);
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

            static /*0x746fbc0*/ OidLookup();
            static /*0x746f0c0*/ string ToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x746f654*/ string ToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x746f29c*/ bool ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup);
            static /*0x746f2a4*/ string NativeOidToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x746f804*/ string NativeFriendlyNameToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);

            class <>c
            {
                static /*0x0*/ Internal.Cryptography.OidLookup.<> <>9;

                static /*0x74718a8*/ <>c();
                /*0x7471910*/ <>c();
                /*0x7471918*/ string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<string, string> kvp);
                /*0x7471954*/ string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<string, string> kvp);
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

                static /*0x74727f4*/ string GetSimpleNameInfo(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                static /*0x7472c4c*/ string FindAltNameMatch(byte[] extensionBytes, Internal.Cryptography.Pal.GeneralNameType matchType, string otherOid);
                static /*0x7472e0c*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                /*0x7471990*/ CertificateData(byte[] rawData);
                /*0x7472184*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);

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

                    /*0x7472e88*/ <ReadReverseRdns>d__21(int <>1__state);
                    /*0x7472ebc*/ void System.IDisposable.Dispose();
                    /*0x7472ec0*/ bool MoveNext();
                    /*0x7473188*/ System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current();
                    /*0x7473194*/ void System.Collections.IEnumerator.Reset();
                    /*0x74731cc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7473228*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator();
                    /*0x74732cc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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
            static /*0x74732d0*/ bool DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.HandleRef hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, ref Microsoft.Win32.SafeHandles.SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
            static /*0x7473444*/ nint GetCurrentProcess();
            static /*0x7473448*/ bool GetExitCodeProcess(nint processHandle, ref int exitCode);
            static /*0x747344c*/ bool GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, ref int exitCode);
            static /*0x7473544*/ int GetCurrentProcessId();
            static /*0x7473548*/ bool CloseProcess(nint handle);
        }

        namespace SafeHandles
        {
            class SafeProcessHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle InvalidHandle;

                static /*0x7473580*/ SafeProcessHandle();
                /*0x747354c*/ SafeProcessHandle(nint handle);
                /*0x7473418*/ SafeProcessHandle(nint existingHandle, bool ownsHandle);
                /*0x7473578*/ bool ReleaseHandle();
            }
        }
    }
}

namespace System
{
    class IPv4AddressHelper
    {
        static /*0x74735f0*/ int ParseHostNumber(System.ReadOnlySpan<char> str, int start, int end);
        static /*0x74736b0*/ bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme);
        static /*0x7473620*/ bool ParseCanonical(System.ReadOnlySpan<char> name, byte* numbers, int start, int end);
        static /*0x74736e0*/ bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile);
        static /*0x7473828*/ long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile);
        static /*0x7473b20*/ string ParseCanonicalName(string str, int start, int end, ref bool isLoopback);
        static /*0x7473d1c*/ bool Parse(string name, byte* numbers, int start, int end);
    }

    class IPv6AddressHelper
    {
        static /*0x77ff30c*/ System.ValueTuple<int, int> FindCompressionRange(System.ReadOnlySpan<ushort> numbers);
        static /*0x77ff3ec*/ bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<ushort> numbers);
        static /*0x77ff4bc*/ bool IsValidStrict(char* name, int start, ref int end);
        static /*0x77ff800*/ void Parse(System.ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId);
        static /*0x77ffcb0*/ string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId);
        static /*0x780025c*/ bool IsLoopback(System.ReadOnlySpan<ushort> numbers);
        static /*0x780033c*/ bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress);
        static /*0x7800614*/ bool IsValid(char* name, int start, ref int end);
    }

    class NotImplemented
    {
        static /*0x780061c*/ System.Exception ByDesignWithMessage(string message);
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

        /*0x7800678*/ UriBuilder(System.Uri uri);
        /*0x7800be8*/ UriBuilder(string schemeName, string hostName);
        /*0x7800fa4*/ UriBuilder(string scheme, string host, int portNumber);
        /*0x7801038*/ UriBuilder(string scheme, string host, int port, string pathValue);
        /*0x7801130*/ UriBuilder(string scheme, string host, int port, string path, string extraValue);
        /*0x7800838*/ void Init(System.Uri uri);
        /*0x7801268*/ void set_Extra(string value);
        /*0x78013f0*/ void set_Fragment(string value);
        /*0x7800eb8*/ void set_Host(string value);
        /*0x7801560*/ string get_Path();
        /*0x7801070*/ void set_Path(string value);
        /*0x7800fcc*/ void set_Port(int value);
        /*0x7801568*/ string get_Query();
        /*0x78014a8*/ void set_Query(string value);
        /*0x7800d74*/ void set_Scheme(string value);
        /*0x7801570*/ System.Uri get_Uri();
        /*0x7801610*/ bool Equals(object rparam);
        /*0x780166c*/ int GetHashCode();
        /*0x7800a14*/ void SetFieldsFromUri(System.Uri uri);
        /*0x780168c*/ string ToString();
    }

    class SecurityUtils
    {
        static /*0x7801c30*/ void DemandReflectionAccess(System.Type type);
        static /*0x7801c34*/ void DemandGrantSet(System.Reflection.Assembly assembly);
        static /*0x7801c38*/ bool HasReflectionPermission(System.Type type);
        static /*0x7801c40*/ object SecureCreateInstance(System.Type type);
        static /*0x7801c4c*/ object SecureCreateInstance(System.Type type, object[] args, bool allowNonPublic);
        static /*0x7801d1c*/ object SecureCreateInstance(System.Type type, object[] args);
        static /*0x7801d24*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic);
        static /*0x7801d30*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic, System.Reflection.BindingFlags extraFlags);
        static /*0x7801e98*/ bool GenericArgumentsAreVisible(System.Reflection.MethodInfo method);
        static /*0x7801f48*/ object MethodInfoInvoke(System.Reflection.MethodInfo method, object target, object[] args);
    }

    class InvariantComparer : System.Collections.IComparer
    {
        static /*0x0*/ System.InvariantComparer Default;
        /*0x10*/ System.Globalization.CompareInfo m_compareInfo;

        static /*0x7802198*/ InvariantComparer();
        /*0x7802034*/ InvariantComparer();
        /*0x78020b8*/ int Compare(object a, object b);
    }

    class IriHelper
    {
        static /*0x78021fc*/ bool CheckIriUnicodeRange(char unicode, bool isQuery);
        static /*0x7802254*/ bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery);
        static /*0x7802870*/ bool CheckIsReserved(char ch, System.UriComponents component);
        static /*0x78029b4*/ string EscapeUnescapeIri(char* pInput, int start, int end, System.UriComponents component);
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

        static /*0x77e18bc*/ Uri();
        static /*0x77d4198*/ bool IriParsingStatic(System.UriParser syntax);
        static /*0x77d43b8*/ bool StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x77d4458*/ bool StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x77d68e8*/ System.ParsingError GetCombinedString(System.Uri baseUri, string relativeStr, bool dontEscape, ref string result);
        static /*0x77d7678*/ System.UriFormatException GetException(System.ParsingError err);
        static /*0x77d89d8*/ bool StaticIsFile(System.UriParser syntax);
        static /*0x77d89f0*/ object get_InitializeLock();
        static /*0x77d8abc*/ void InitializeUriConfig();
        static /*0x77d988c*/ bool IsGenDelim(char ch);
        static /*0x77d98bc*/ bool CheckSchemeName(string schemeName);
        static /*0x77d9aa4*/ bool IsHexDigit(char character);
        static /*0x77d9ae0*/ int FromHex(char digit);
        static /*0x77da050*/ bool op_Equality(System.Uri uri1, System.Uri uri2);
        static /*0x77d651c*/ bool op_Inequality(System.Uri uri1, System.Uri uri2);
        static /*0x77da750*/ bool CheckForColonInFirstPathSegment(string uriString);
        static /*0x77da808*/ string InternalEscapeString(string rawString);
        static /*0x77da8dc*/ System.ParsingError ParseScheme(string uriString, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x77dca0c*/ string CreateHostStringHelper(string str, ushort idx, ushort end, ref System.Uri.Flags flags, ref string scopeId);
        static /*0x77da9b4*/ ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x77debb0*/ bool CheckKnownSchemes(long* lptr, ushort nChars, ref System.UriParser syntax);
        static /*0x77d6b44*/ System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref System.UriParser syntax);
        static /*0x77df9d8*/ void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3);
        static /*0x77d8c5c*/ char[] Compress(char[] dest, ushort start, ref int destLength, System.UriParser syntax);
        static /*0x77d9cd0*/ int CalculateCaseInsensitiveHashCode(string text);
        static /*0x77d6cac*/ string CombineUri(System.Uri basePart, string relativePart, System.UriFormat uriFormat);
        static /*0x77db63c*/ bool IsLWS(char ch);
        static /*0x77d99fc*/ bool IsAsciiLetter(char character);
        static /*0x77d9a28*/ bool IsAsciiLetterOrDigit(char character);
        static /*0x77dfc00*/ bool IsBidiControlCharacter(char ch);
        static /*0x77df7e0*/ string StripBidiControlCharacter(char* strToClean, int start, int length);
        static /*0x77da680*/ bool TryCreate(string uriString, System.UriKind uriKind, ref System.Uri result);
        static /*0x77e07ec*/ bool TryCreate(System.Uri baseUri, string relativeUri, ref System.Uri result);
        static /*0x77e08d4*/ bool TryCreate(System.Uri baseUri, System.Uri relativeUri, ref System.Uri result);
        static /*0x77e1148*/ bool IsWellFormedUriString(string uriString, System.UriKind uriKind);
        static /*0x77e11e4*/ string UnescapeDataString(string stringToUnescape);
        static /*0x77e1384*/ string EscapeUriString(string stringToEscape);
        static /*0x77e14a4*/ string EscapeDataString(string stringToEscape);
        static /*0x77e0584*/ System.Uri CreateHelper(string uriString, bool dontEscape, System.UriKind uriKind, ref System.UriFormatException e);
        static /*0x77d6038*/ System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, ref string newUriString, ref bool userEscaped, ref System.UriFormatException e);
        /*0x77d5b0c*/ Uri(string uriString);
        /*0x77d5d48*/ Uri(string uriString, System.UriKind uriKind);
        /*0x77d5dcc*/ Uri(System.Uri baseUri, string relativeUri);
        /*0x77d66b8*/ Uri(System.Uri baseUri, System.Uri relativeUri);
        /*0x77d7818*/ Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x77e15c4*/ Uri(System.Uri.Flags flags, System.UriParser uriParser, string uri);
        /*0x77d4140*/ bool get_IsImplicitFile();
        /*0x77d414c*/ bool get_IsUncOrDosPath();
        /*0x77d415c*/ bool get_IsDosPath();
        /*0x77d4168*/ bool get_IsUncPath();
        /*0x77d4174*/ System.Uri.Flags get_HostType();
        /*0x77d4180*/ System.UriParser get_Syntax();
        /*0x77d4188*/ bool get_IsNotAbsoluteUri();
        /*0x77d4224*/ bool get_AllowIdn();
        /*0x77d42f0*/ bool AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags);
        /*0x77d43c4*/ bool IsIntranet(string schemeHost);
        /*0x77d43cc*/ bool get_UserDrivenParsing();
        /*0x77d43d8*/ void SetUserDrivenParsing();
        /*0x77d43ec*/ ushort get_SecuredPathIndex();
        /*0x77d42e0*/ bool NotAny(System.Uri.Flags flags);
        /*0x77d4448*/ bool InFact(System.Uri.Flags flags);
        /*0x77d4464*/ System.Uri.UriInfo EnsureUriInfo();
        /*0x77d4a34*/ void EnsureParseRemaining();
        /*0x77d569c*/ void EnsureHostString(bool allowDnsOptimization);
        /*0x77d5e9c*/ void CreateUri(System.Uri baseUri, string relativeUri, bool dontEscape);
        /*0x77d7918*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x77d791c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x77d79ec*/ string get_AbsolutePath();
        /*0x77d7aac*/ string get_PrivateAbsolutePath();
        /*0x77d7b78*/ string get_AbsoluteUri();
        /*0x77d7c98*/ string get_LocalPath();
        /*0x77d82f0*/ string get_Authority();
        /*0x77d8364*/ System.UriHostNameType get_HostNameType();
        /*0x77d845c*/ bool get_IsDefaultPort();
        /*0x77d8504*/ bool get_IsFile();
        /*0x77d85c4*/ bool get_IsLoopback();
        /*0x77d8644*/ string get_PathAndQuery();
        /*0x77d870c*/ string[] get_Segments();
        /*0x77d88f0*/ bool get_IsUnc();
        /*0x77d8964*/ string get_Host();
        /*0x77d7d04*/ string GetLocalPath();
        /*0x77d9200*/ int get_Port();
        /*0x77d92c4*/ string get_Query();
        /*0x77d93e8*/ string get_Fragment();
        /*0x77d950c*/ string get_Scheme();
        /*0x77d957c*/ bool get_OriginalStringSwitched();
        /*0x77d6c84*/ string get_OriginalString();
        /*0x77d95c4*/ string get_DnsSafeHost();
        /*0x77d5e8c*/ bool get_IsAbsoluteUri();
        /*0x77d980c*/ bool get_UserEscaped();
        /*0x77d9818*/ string get_UserInfo();
        /*0x77d9b8c*/ int GetHashCode();
        /*0x77d9d70*/ string ToString();
        /*0x77da084*/ bool Equals(object comparand);
        /*0x77daf24*/ System.UriFormatException ParseMinimal();
        /*0x77dafa4*/ System.ParsingError PrivateParseMinimal();
        /*0x77dc4d8*/ void PrivateParseMinimalIri(string newHost, ushort idx);
        /*0x77d4488*/ void CreateUriInfo(System.Uri.Flags cF);
        /*0x77d56fc*/ void CreateHostString();
        /*0x77dc5cc*/ void GetHostViaCustomSyntax();
        /*0x77d79e8*/ string GetParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x77dd1a0*/ string GetEscapedParts(System.UriComponents uriParts);
        /*0x77d9130*/ string GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x77dd7f4*/ string ReCreateParts(System.UriComponents parts, ushort nonCanonical, System.UriFormat formatAs);
        /*0x77dd268*/ string GetUriPartsFromUserString(System.UriComponents uriParts);
        /*0x77d4a44*/ void ParseRemaining();
        /*0x77db674*/ ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, System.UriParser syntax, ref string newHost);
        /*0x77df134*/ void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, System.UriParser syntax, string userInfoString, ref System.Uri.Flags flags, ref bool justNormalized, ref string newHost, ref System.ParsingError err);
        /*0x77df4cc*/ void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, System.UriParser syntax, ref System.Uri.Flags flags, ref string newHost, ref System.ParsingError err);
        /*0x77deb0c*/ void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim);
        /*0x77df940*/ void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim);
        /*0x77dcbe8*/ System.Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim);
        /*0x77de498*/ char[] GetCanonicalPath(char[] dest, ref int pos, System.UriFormat formatAs);
        /*0x77dfbf4*/ bool get_HasAuthority();
        /*0x77d5b8c*/ void CreateThis(string uri, bool dontEscape, System.UriKind uriKind);
        /*0x77dfc30*/ void InitializeUri(System.ParsingError err, System.UriKind uriKind, ref System.UriFormatException e);
        /*0x77e01b0*/ bool CheckForConfigLoad(string data);
        /*0x77e0294*/ bool CheckForUnicode(string data);
        /*0x77e03c0*/ bool CheckForEscapedUnreserved(string data);
        /*0x77dcfd8*/ string GetComponents(System.UriComponents components, System.UriFormat format);
        /*0x77e0c8c*/ bool IsWellFormedOriginalString();
        /*0x77e0cd0*/ bool InternalIsWellFormedOriginalString();
        /*0x77deb60*/ string EscapeUnescapeIri(string input, int start, int end, System.UriComponents component);
        /*0x77e0a7c*/ string GetRelativeSerializationString(System.UriFormat format);
        /*0x77d9e48*/ string GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x77e1618*/ bool IsBaseOf(System.Uri uri);
        /*0x77e16cc*/ bool IsBaseOfHelper(System.Uri uriLink);
        /*0x77d6564*/ void CreateThisFromUri(System.Uri otherUri);

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

            /*0x7803930*/ UriInfo();
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

            /*0x7803938*/ MoreInfo();
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
        /*0x7803940*/ UriFormatException();
        /*0x7801b34*/ UriFormatException(string textString);
        /*0x7803948*/ UriFormatException(string textString, System.Exception e);
        /*0x7803950*/ UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x7803958*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

        static /*0x7804f08*/ UriHelper();
        static /*0x7803960*/ bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase);
        static /*0x7803b50*/ char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd);
        static /*0x7804064*/ char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos);
        static /*0x7804378*/ char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x7804458*/ char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x7803354*/ void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing);
        static /*0x7803828*/ void EscapeAsciiChar(char ch, char[] to, ref int pos);
        static /*0x780320c*/ char EscapedAscii(char digit, char next);
        static /*0x78032c8*/ bool IsNotSafeForUnescape(char ch);
        static /*0x7804270*/ bool IsReservedUnreservedOrHash(char c);
        static /*0x7804190*/ bool IsUnreserved(char c);
        static /*0x7804e6c*/ bool Is3986Unreserved(char c);
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

        static /*0x7805498*/ UriParser();
        static /*0x7804e0c*/ bool get_ShouldUseLegacyV2Quirks();
        static /*0x7805e54*/ System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme);
        static /*0x7801b3c*/ System.UriParser GetSyntax(string lwrCaseScheme);
        /*0x7804fb8*/ UriParser();
        /*0x7804ff4*/ UriParser(System.UriSyntaxFlags flags);
        /*0x7804fa8*/ string get_SchemeName();
        /*0x7804fb0*/ int get_DefaultPort();
        /*0x7805038*/ System.UriParser OnNewUri();
        /*0x780503c*/ void InitializeAndValidate(System.Uri uri, ref System.UriFormatException parsingError);
        /*0x780506c*/ string Resolve(System.Uri baseUri, System.Uri relativeUri, ref System.UriFormatException parsingError);
        /*0x780524c*/ bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri);
        /*0x7805268*/ string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format);
        /*0x7805480*/ bool IsWellFormedOriginalString(System.Uri uri);
        /*0x7805de8*/ System.UriSyntaxFlags get_Flags();
        /*0x7801c28*/ bool NotAny(System.UriSyntaxFlags flags);
        /*0x7801c0c*/ bool InFact(System.UriSyntaxFlags flags);
        /*0x7805e4c*/ bool IsAllSet(System.UriSyntaxFlags flags);
        /*0x7805df0*/ bool IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected);
        /*0x7806134*/ bool get_IsSimple();
        /*0x7806140*/ System.UriParser InternalOnNewUri();
        /*0x78061a0*/ void InternalValidate(System.Uri thisUri, ref System.UriFormatException parsingError);
        /*0x78061ac*/ string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, ref System.UriFormatException parsingError);
        /*0x78061b8*/ bool InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink);
        /*0x78061c4*/ string InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x78061d0*/ bool InternalIsWellFormedOriginalString(System.Uri thisUri);

        enum UriQuirksVersion
        {
            V2 = 2,
            V3 = 3,
        }

        class BuiltInUriParser : System.UriParser
        {
            /*0x7805d34*/ BuiltInUriParser(string lwrCaseScheme, int defaultPort, System.UriSyntaxFlags syntaxFlags);
        }
    }

    class DomainNameHelper
    {
        static /*0x78061dc*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x7806374*/ bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x78065a4*/ bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x7806794*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x7806a20*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost);
        static /*0x7806c6c*/ bool IsIdnAce(string input, int index);
        static /*0x7806c20*/ bool IsIdnAce(char* input, int index);
        static /*0x7806d04*/ string UnicodeEquivalent(string idnHost, char* hostname, int start, int end);
        static /*0x7806e24*/ string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x78064f4*/ bool IsASCIILetterOrDigit(char character, ref bool notCanonical);
        static /*0x7806540*/ bool IsValidDomainLabelCharacter(char character, ref bool notCanonical);
    }

    class UncNameHelper
    {
        static /*0x7807280*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x7807284*/ bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile);
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
        /*0x7807534*/ IOAsyncCallback(object object, nint method);
        /*0x780763c*/ void Invoke(System.IOAsyncResult ioares);
    }

    class IOAsyncResult : System.IAsyncResult
    {
        /*0x10*/ System.AsyncCallback async_callback;
        /*0x18*/ object async_state;
        /*0x20*/ System.Threading.ManualResetEvent wait_handle;
        /*0x28*/ bool completed_synchronously;
        /*0x29*/ bool completed;

        /*0x7807650*/ IOAsyncResult();
        /*0x78076a8*/ IOAsyncResult(System.AsyncCallback async_callback, object async_state);
        /*0x7807658*/ void Init(System.AsyncCallback async_callback, object async_state);
        /*0x78076ec*/ System.AsyncCallback get_AsyncCallback();
        /*0x78076f4*/ object get_AsyncState();
        /*0x78076fc*/ System.Threading.WaitHandle get_AsyncWaitHandle();
        /*0x7807820*/ bool get_CompletedSynchronously();
        /*0x7807828*/ void set_CompletedSynchronously(bool value);
        /*0x7807834*/ bool get_IsCompleted();
        /*0x780783c*/ void set_IsCompleted(bool value);
        /*0x38159dc*/ void CompleteDisposed();
    }

    class IOSelectorJob : System.Threading.IThreadPoolWorkItem
    {
        /*0x10*/ System.IOOperation operation;
        /*0x18*/ System.IOAsyncCallback callback;
        /*0x20*/ System.IOAsyncResult state;

        /*0x7807918*/ IOSelectorJob(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state);
        /*0x780796c*/ void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem();
        /*0x7807994*/ void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae);
        /*0x7807998*/ void MarkDisposed();
    }

    class IOSelector
    {
        static /*0x78079b8*/ void Add(nint handle, System.IOSelectorJob job);
    }

    class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        /*0x78079bc*/ UriTypeConverter();
        /*0x78079c4*/ bool CanConvert(System.Type type);
        /*0x7807a80*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
        /*0x7807b08*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        /*0x7807b54*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        /*0x7807ce4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
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

                /*0x7807eac*/ Capture(string text, int index, int length);
                /*0x7808064*/ Capture();
                /*0x7807ef4*/ int get_Index();
                /*0x7807efc*/ void set_Index(int value);
                /*0x7807f04*/ int get_Length();
                /*0x7807f0c*/ void set_Length(int value);
                /*0x7807f14*/ string get_Text();
                /*0x7807f1c*/ void set_Text(string value);
                /*0x7807f24*/ string get_Value();
                /*0x7807f48*/ string ToString();
                /*0x7807f4c*/ System.ReadOnlySpan<char> GetLeftSubstring();
                /*0x7807fd4*/ System.ReadOnlySpan<char> GetRightSubstring();
            }

            class CaptureCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Capture>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Group _group;
                /*0x18*/ int _capcount;
                /*0x20*/ System.Text.RegularExpressions.Capture[] _captures;

                /*0x7808d38*/ CaptureCollection();
                /*0x780809c*/ bool get_IsReadOnly();
                /*0x78080a4*/ int get_Count();
                /*0x78080ac*/ System.Text.RegularExpressions.Capture get_Item(int i);
                /*0x7808174*/ System.Collections.IEnumerator GetEnumerator();
                /*0x7808220*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator();
                /*0x78080b0*/ System.Text.RegularExpressions.Capture GetCapture(int i);
                /*0x7808290*/ void ForceInitialized();
                /*0x7808418*/ bool get_IsSynchronized();
                /*0x7808420*/ object get_SyncRoot();
                /*0x7808428*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x78084e0*/ void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex);
                /*0x780864c*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item);
                /*0x78086fc*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, System.Text.RegularExpressions.Capture item);
                /*0x7808748*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index);
                /*0x7808794*/ System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index);
                /*0x7808798*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, System.Text.RegularExpressions.Capture value);
                /*0x78087e4*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item);
                /*0x7808830*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear();
                /*0x780887c*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item);
                /*0x7808930*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item);
                /*0x780897c*/ int System.Collections.IList.Add(object value);
                /*0x78089c8*/ void System.Collections.IList.Clear();
                /*0x7808a14*/ bool System.Collections.IList.Contains(object value);
                /*0x7808b08*/ int System.Collections.IList.IndexOf(object value);
                /*0x7808bfc*/ void System.Collections.IList.Insert(int index, object value);
                /*0x7808c48*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x7808c50*/ void System.Collections.IList.Remove(object value);
                /*0x7808c9c*/ void System.Collections.IList.RemoveAt(int index);
                /*0x7808ce8*/ object System.Collections.IList.get_Item(int index);
                /*0x7808cec*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.CaptureCollection _collection;
                    /*0x18*/ int _index;

                    /*0x78081e4*/ Enumerator(System.Text.RegularExpressions.CaptureCollection collection);
                    /*0x7808d70*/ bool MoveNext();
                    /*0x7808db0*/ System.Text.RegularExpressions.Capture get_Current();
                    /*0x7808e24*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7808e28*/ void System.Collections.IEnumerator.Reset();
                    /*0x7808e34*/ void System.IDisposable.Dispose();
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

                static /*0x7808f08*/ Group();
                /*0x7808e38*/ Group(string text, int[] caps, int capcount, string name);
                /*0x7809008*/ Group();
                /*0x7808ef8*/ bool get_Success();
            }

            class GroupCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Match _match;
                /*0x18*/ System.Collections.Hashtable _captureMap;
                /*0x20*/ System.Text.RegularExpressions.Group[] _groups;

                /*0x7809040*/ GroupCollection(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps);
                /*0x780a100*/ GroupCollection();
                /*0x7809084*/ bool get_IsReadOnly();
                /*0x780908c*/ int get_Count();
                /*0x78090b0*/ System.Text.RegularExpressions.Group get_Item(int groupnum);
                /*0x78091ac*/ System.Text.RegularExpressions.Group get_Item(string groupname);
                /*0x7809384*/ System.Collections.IEnumerator GetEnumerator();
                /*0x7809430*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator();
                /*0x78090b4*/ System.Text.RegularExpressions.Group GetGroup(int groupnum);
                /*0x78094a0*/ System.Text.RegularExpressions.Group GetGroupImpl(int groupnum);
                /*0x78097c0*/ bool get_IsSynchronized();
                /*0x78097c8*/ object get_SyncRoot();
                /*0x78097d0*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x780988c*/ void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex);
                /*0x7809a0c*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item);
                /*0x7809ac4*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item);
                /*0x7809b10*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index);
                /*0x7809b5c*/ System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index);
                /*0x7809b60*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, System.Text.RegularExpressions.Group value);
                /*0x7809bac*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item);
                /*0x7809bf8*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear();
                /*0x7809c44*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item);
                /*0x7809cf8*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item);
                /*0x7809d44*/ int System.Collections.IList.Add(object value);
                /*0x7809d90*/ void System.Collections.IList.Clear();
                /*0x7809ddc*/ bool System.Collections.IList.Contains(object value);
                /*0x7809ed0*/ int System.Collections.IList.IndexOf(object value);
                /*0x7809fc4*/ void System.Collections.IList.Insert(int index, object value);
                /*0x780a010*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x780a018*/ void System.Collections.IList.Remove(object value);
                /*0x780a064*/ void System.Collections.IList.RemoveAt(int index);
                /*0x780a0b0*/ object System.Collections.IList.get_Item(int index);
                /*0x780a0b4*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.GroupCollection _collection;
                    /*0x18*/ int _index;

                    /*0x78093f4*/ Enumerator(System.Text.RegularExpressions.GroupCollection collection);
                    /*0x780a138*/ bool MoveNext();
                    /*0x780a17c*/ System.Text.RegularExpressions.Group get_Current();
                    /*0x780a208*/ object System.Collections.IEnumerator.get_Current();
                    /*0x780a20c*/ void System.Collections.IEnumerator.Reset();
                    /*0x780a218*/ void System.IDisposable.Dispose();
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

                static /*0x780af68*/ Match();
                static /*0x780a38c*/ System.Text.RegularExpressions.Match get_Empty();
                /*0x780a21c*/ Match(System.Text.RegularExpressions.Regex regex, int capcount, string text, int begpos, int len, int startpos);
                /*0x780aff8*/ Match();
                /*0x780a3e4*/ void Reset(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart);
                /*0x780a488*/ System.Text.RegularExpressions.GroupCollection get_Groups();
                /*0x780a500*/ System.Text.RegularExpressions.Match NextMatch();
                /*0x780a7b4*/ System.ReadOnlySpan<char> GroupToStringImpl(int groupnum);
                /*0x780a924*/ System.ReadOnlySpan<char> LastGroupToStringImpl();
                /*0x780a94c*/ void AddMatch(int cap, int start, int len);
                /*0x780ab40*/ void BalanceMatch(int cap);
                /*0x780ac18*/ void RemoveMatch(int cap);
                /*0x780ac50*/ bool IsMatched(int cap);
                /*0x780ace0*/ int MatchIndex(int cap);
                /*0x780ad6c*/ int MatchLength(int cap);
                /*0x780adf8*/ void Tidy(int textpos);
            }

            class MatchSparse : System.Text.RegularExpressions.Match
            {
                /*0x78*/ System.Collections.Hashtable _caps;

                /*0x780b030*/ MatchSparse(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, int capcount, string text, int begpos, int len, int startpos);
                /*0x780b0e8*/ System.Text.RegularExpressions.GroupCollection get_Groups();
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

                /*0x780b16c*/ MatchCollection(System.Text.RegularExpressions.Regex regex, string input, int beginning, int length, int startat);
                /*0x780bdf4*/ MatchCollection();
                /*0x780b2c0*/ bool get_IsReadOnly();
                /*0x780b2c8*/ int get_Count();
                /*0x780b338*/ System.Text.RegularExpressions.Match get_Item(int i);
                /*0x780b50c*/ System.Collections.IEnumerator GetEnumerator();
                /*0x780b5b8*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator();
                /*0x780b398*/ System.Text.RegularExpressions.Match GetMatch(int i);
                /*0x780b324*/ void EnsureInitialized();
                /*0x780b628*/ bool get_IsSynchronized();
                /*0x780b630*/ object get_SyncRoot();
                /*0x780b634*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x780b700*/ void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex);
                /*0x780b77c*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item);
                /*0x780b7e8*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, System.Text.RegularExpressions.Match item);
                /*0x780b834*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index);
                /*0x780b880*/ System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index);
                /*0x780b890*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, System.Text.RegularExpressions.Match value);
                /*0x780b8dc*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item);
                /*0x780b928*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear();
                /*0x780b974*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item);
                /*0x780b9e0*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item);
                /*0x780ba2c*/ int System.Collections.IList.Add(object value);
                /*0x780ba78*/ void System.Collections.IList.Clear();
                /*0x780bac4*/ bool System.Collections.IList.Contains(object value);
                /*0x780bbb8*/ int System.Collections.IList.IndexOf(object value);
                /*0x780bcac*/ void System.Collections.IList.Insert(int index, object value);
                /*0x780bcf8*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x780bd00*/ void System.Collections.IList.Remove(object value);
                /*0x780bd4c*/ void System.Collections.IList.RemoveAt(int index);
                /*0x780bd98*/ object System.Collections.IList.get_Item(int index);
                /*0x780bda8*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.MatchCollection _collection;
                    /*0x18*/ int _index;

                    /*0x780b57c*/ Enumerator(System.Text.RegularExpressions.MatchCollection collection);
                    /*0x780be2c*/ bool MoveNext();
                    /*0x780be7c*/ System.Text.RegularExpressions.Match get_Current();
                    /*0x780bee4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x780bee8*/ void System.Collections.IEnumerator.Reset();
                    /*0x780bef4*/ void System.IDisposable.Dispose();
                }
            }

            class ExclusiveReference
            {
                /*0x10*/ System.Text.RegularExpressions.RegexRunner _ref;
                /*0x18*/ System.Text.RegularExpressions.RegexRunner _obj;
                /*0x20*/ int _locked;

                /*0x780c024*/ ExclusiveReference();
                /*0x780bef8*/ System.Text.RegularExpressions.RegexRunner Get();
                /*0x780bf58*/ void Release(System.Text.RegularExpressions.RegexRunner obj);
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

                static /*0x780e840*/ Regex();
                static /*0x780ca30*/ bool TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x780cb4c*/ bool TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x780c648*/ System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key);
                static /*0x780cc44*/ bool IsMatch(string input, string pattern);
                static /*0x780cd44*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0x780ccb8*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x780d328*/ System.Text.RegularExpressions.Match Match(string input, string pattern);
                static /*0x780d39c*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x780d504*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern);
                static /*0x780d578*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x780d738*/ string Replace(string input, string pattern, string replacement);
                static /*0x780d7b4*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x780d990*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator);
                static /*0x780da0c*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x780dbe0*/ string Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x780e010*/ string[] Split(string input, string pattern);
                static /*0x780e084*/ string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x780e240*/ string[] Split(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x780ebb0*/ void ValidateMatchTimeout(System.TimeSpan matchTimeout);
                static /*0x780e980*/ System.TimeSpan InitDefaultMatchTimeout();
                static /*0x780efe8*/ string Escape(string str);
                /*0x780ed08*/ Regex();
                /*0x780ed74*/ Regex(string pattern);
                /*0x780edec*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options);
                /*0x780cdbc*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, bool addToCache);
                /*0x780c02c*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x780c154*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x780c92c*/ void FillCacheDictionary();
                /*0x780d234*/ bool IsMatch(string input);
                /*0x780d2ac*/ bool IsMatch(string input, int startat);
                /*0x780d428*/ System.Text.RegularExpressions.Match Match(string input);
                /*0x780d494*/ System.Text.RegularExpressions.Match Match(string input, int startat);
                /*0x780d604*/ System.Text.RegularExpressions.MatchCollection Matches(string input);
                /*0x780d670*/ System.Text.RegularExpressions.MatchCollection Matches(string input, int startat);
                /*0x780d848*/ string Replace(string input, string replacement);
                /*0x780d8b8*/ string Replace(string input, string replacement, int count, int startat);
                /*0x780daa0*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator);
                /*0x780db10*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat);
                /*0x780e110*/ string[] Split(string input);
                /*0x780e180*/ string[] Split(string input, int count, int startat);
                /*0x780ee68*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0x780f08c*/ System.Text.RegularExpressions.RegexOptions get_Options();
                /*0x780e004*/ bool get_RightToLeft();
                /*0x780f094*/ string ToString();
                /*0x7809690*/ string GroupNameFromNumber(int i);
                /*0x780923c*/ int GroupNumberFromName(string name);
                /*0x780eed8*/ void InitializeReferences();
                /*0x780a530*/ System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat);
                /*0x780d2a0*/ bool UseOptionR();
                /*0x780f09c*/ bool UseOptionInvariant();

                struct CachedCodeEntryKey : System.IEquatable<System.Text.RegularExpressions.Regex.CachedCodeEntryKey>
                {
                    /*0x10*/ System.Text.RegularExpressions.RegexOptions _options;
                    /*0x18*/ string _cultureKey;
                    /*0x20*/ string _pattern;

                    static /*0x780c124*/ bool op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right);
                    /*0x780eea0*/ CachedCodeEntryKey(System.Text.RegularExpressions.RegexOptions options, string cultureKey, string pattern);
                    /*0x780f0a8*/ bool Equals(object obj);
                    /*0x780f138*/ bool Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other);
                    /*0x780f1a0*/ int GetHashCode();
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

                    /*0x780c858*/ CachedCodeEntry(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref);
                }
            }

            class MatchEvaluator : System.MulticastDelegate
            {
                /*0x780f1f8*/ MatchEvaluator(object object, nint method);
                /*0x780f300*/ string Invoke(System.Text.RegularExpressions.Match match);
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

                /*0x780f314*/ RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, System.Globalization.CultureInfo culture);
                /*0x780f834*/ bool MatchPattern(string text, int index);
                /*0x780f958*/ bool IsMatch(string text, int index, int beglimit, int endlimit);
                /*0x780f9c4*/ int Scan(string text, int index, int beglimit, int endlimit);
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

                static /*0x7811f24*/ RegexCharClass();
                static /*0x7810ea0*/ char SingletonChar(string set);
                static /*0x7810eb8*/ bool IsMergeable(string charClass);
                static /*0x7810fd4*/ bool IsEmpty(string charClass);
                static /*0x7811094*/ bool IsSingleton(string set);
                static /*0x78111a0*/ bool IsSingletonInverse(string set);
                static /*0x7810f7c*/ bool IsSubtraction(string charClass);
                static /*0x7810f54*/ bool IsNegated(string set);
                static /*0x78112b0*/ bool IsECMAWordChar(char ch);
                static /*0x7811384*/ bool IsWordChar(char ch);
                static /*0x781131c*/ bool CharInClass(char ch, string set);
                static /*0x7811400*/ bool CharInClassRecursive(char ch, string set, int start);
                static /*0x7811528*/ bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x7811638*/ bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x78117bc*/ bool CharInCategoryGroup(char ch, System.Globalization.UnicodeCategory chcategory, string category, ref int i);
                static /*0x7810588*/ string NegateCategory(string category);
                static /*0x781188c*/ System.Text.RegularExpressions.RegexCharClass Parse(string charClass);
                static /*0x78118e4*/ System.Text.RegularExpressions.RegexCharClass ParseRecursive(string charClass, int start);
                static /*0x7810610*/ string SetFromProperty(string capname, bool invert, string pattern);
                /*0x780fca8*/ RegexCharClass();
                /*0x780fd74*/ RegexCharClass(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction);
                /*0x780fde4*/ bool get_CanMerge();
                /*0x780fe04*/ void set_Negate(bool value);
                /*0x780fe10*/ void AddChar(char c);
                /*0x780ff34*/ void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc);
                /*0x781014c*/ void AddSet(string set);
                /*0x7810370*/ void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub);
                /*0x780fe18*/ void AddRange(char first, char last);
                /*0x7810378*/ void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern);
                /*0x781086c*/ void AddCategory(string category);
                /*0x7810888*/ void AddLowercase(System.Globalization.CultureInfo culture);
                /*0x78109c4*/ void AddLowercaseRange(char chMin, char chMax, System.Globalization.CultureInfo culture);
                /*0x7810bf4*/ void AddWord(bool ecma, bool negate);
                /*0x7810cf0*/ void AddSpace(bool ecma, bool negate);
                /*0x7810dec*/ void AddDigit(bool ecma, bool negate, string pattern);
                /*0x78100a4*/ int RangeCount();
                /*0x7811b50*/ string ToStringClass();
                /*0x78100ec*/ System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(int i);
                /*0x7811cec*/ void Canonicalize();

                struct LowerCaseMapping
                {
                    /*0x10*/ char ChMin;
                    /*0x12*/ char ChMax;
                    /*0x14*/ int LcOp;
                    /*0x18*/ int Data;

                    /*0x7818324*/ LowerCaseMapping(char chMin, char chMax, int lcOp, int data);
                }

                class SingleRangeComparer : System.Collections.Generic.IComparer<System.Text.RegularExpressions.RegexCharClass.SingleRange>
                {
                    static /*0x0*/ System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer Instance;

                    static /*0x7818380*/ SingleRangeComparer();
                    /*0x7818334*/ SingleRangeComparer();
                    /*0x781833c*/ int Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y);
                }

                struct SingleRange
                {
                    /*0x10*/ char First;
                    /*0x12*/ char Last;

                    /*0x78183e8*/ SingleRange(char first, char last);
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

                static /*0x7818500*/ bool OpcodeBacktracks(int Op);
                /*0x78183f4*/ RegexCode(int[] codes, System.Collections.Generic.List<string> stringlist, int trackcount, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft);
            }

            struct RegexFCD
            {
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack;
                /*0x18*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x38*/ bool _skipAllChildren;
                /*0x39*/ bool _skipchild;
                /*0x3a*/ bool _failed;

                static /*0x7818604*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t);
                static /*0x78189b0*/ System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree);
                static /*0x7818c88*/ int Anchors(System.Text.RegularExpressions.RegexTree tree);
                static /*0x7818db8*/ int AnchorFromType(int type);
                /*0x7818530*/ RegexFCD(System.Span<int> intStack);
                /*0x7818e28*/ void PushInt(int i);
                /*0x7818edc*/ bool IntIsEmpty();
                /*0x7818f20*/ int PopInt();
                /*0x7818f7c*/ void PushFC(System.Text.RegularExpressions.RegexFC fc);
                /*0x7819028*/ bool FCIsEmpty();
                /*0x7819078*/ System.Text.RegularExpressions.RegexFC PopFC();
                /*0x78190f4*/ System.Text.RegularExpressions.RegexFC TopFC();
                /*0x7818908*/ void Dispose();
                /*0x7818770*/ System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x7819554*/ void SkipChild();
                /*0x7819158*/ void CalculateFC(int NodeType, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }

            class RegexFC
            {
                /*0x10*/ System.Text.RegularExpressions.RegexCharClass _cc;
                /*0x18*/ bool _nullable;
                /*0x19*/ bool <CaseInsensitive>k__BackingField;

                /*0x7819560*/ RegexFC(bool nullable);
                /*0x7819690*/ RegexFC(char ch, bool not, bool nullable, bool caseInsensitive);
                /*0x7819794*/ RegexFC(string charClass, bool nullable, bool caseInsensitive);
                /*0x78195e4*/ bool AddFC(System.Text.RegularExpressions.RegexFC fc, bool concatenate);
                /*0x7819838*/ bool get_CaseInsensitive();
                /*0x7819840*/ void set_CaseInsensitive(bool value);
                /*0x7818950*/ string GetFirstChars(System.Globalization.CultureInfo culture);
            }

            class RegexInterpreter : System.Text.RegularExpressions.RegexRunner
            {
                /*0x80*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x88*/ System.Globalization.CultureInfo _culture;
                /*0x90*/ int _operator;
                /*0x94*/ int _codepos;
                /*0x98*/ bool _rightToLeft;
                /*0x99*/ bool _caseInsensitive;

                /*0x781984c*/ RegexInterpreter(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture);
                /*0x7819898*/ void InitTrackCount();
                /*0x78198b8*/ void Advance(int i);
                /*0x781993c*/ void Goto(int newpos);
                /*0x78199fc*/ void Textto(int newpos);
                /*0x7819a04*/ void Trackto(int newpos);
                /*0x7819a28*/ int Textstart();
                /*0x7819a30*/ int Textpos();
                /*0x7819a38*/ int Trackpos();
                /*0x7819a5c*/ void TrackPush();
                /*0x7819a9c*/ void TrackPush(int I1);
                /*0x7819af8*/ void TrackPush(int I1, int I2);
                /*0x7819b70*/ void TrackPush(int I1, int I2, int I3);
                /*0x7819c04*/ void TrackPush2(int I1);
                /*0x7819c64*/ void TrackPush2(int I1, int I2);
                /*0x7819ce0*/ void Backtrack();
                /*0x781991c*/ void SetOperator(int op);
                /*0x7819dd4*/ void TrackPop();
                /*0x7819de4*/ void TrackPop(int framesize);
                /*0x7819df4*/ int TrackPeek();
                /*0x7819e2c*/ int TrackPeek(int i);
                /*0x7819e68*/ void StackPush(int I1);
                /*0x7819ea4*/ void StackPush(int I1, int I2);
                /*0x7819efc*/ void StackPop();
                /*0x7819f0c*/ void StackPop(int framesize);
                /*0x7819f1c*/ int StackPeek();
                /*0x7819f54*/ int StackPeek(int i);
                /*0x7819f90*/ int Operator();
                /*0x7819f98*/ int Operand(int i);
                /*0x7819fdc*/ int Leftchars();
                /*0x7819fec*/ int Rightchars();
                /*0x7819ffc*/ int Bump();
                /*0x781a010*/ int Forwardchars();
                /*0x781a03c*/ char Forwardcharnext();
                /*0x781a0cc*/ bool Stringmatch(string str);
                /*0x781a238*/ bool Refmatch(int index, int len);
                /*0x781a3d4*/ void Backwardnext();
                /*0x781a404*/ char CharAt(int j);
                /*0x781a420*/ bool FindFirstChar();
                /*0x781a7bc*/ void Go();
            }

            class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                /*0x90*/ string <Input>k__BackingField;
                /*0x98*/ string <Pattern>k__BackingField;
                /*0xa0*/ System.TimeSpan <MatchTimeout>k__BackingField;

                /*0x781bd8c*/ RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout);
                /*0x781be98*/ RegexMatchTimeoutException();
                /*0x781bf38*/ RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x781c0a4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x781c1a0*/ string get_Input();
                /*0x781c1a8*/ string get_Pattern();
                /*0x781c1b0*/ System.TimeSpan get_MatchTimeout();
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

                /*0x781c1b8*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options);
                /*0x781c1e8*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, char ch);
                /*0x781c228*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, string str);
                /*0x781c270*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m);
                /*0x781c2b0*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m, int n);
                /*0x781c2f4*/ bool UseOptionR();
                /*0x781c300*/ System.Text.RegularExpressions.RegexNode ReverseLeft();
                /*0x781c37c*/ void MakeRep(int type, int min, int max);
                /*0x781c394*/ System.Text.RegularExpressions.RegexNode Reduce();
                /*0x781ce8c*/ System.Text.RegularExpressions.RegexNode StripEnation(int emptyType);
                /*0x781cd1c*/ System.Text.RegularExpressions.RegexNode ReduceGroup();
                /*0x781cb94*/ System.Text.RegularExpressions.RegexNode ReduceRep();
                /*0x781cd48*/ System.Text.RegularExpressions.RegexNode ReduceSet();
                /*0x781c3fc*/ System.Text.RegularExpressions.RegexNode ReduceAlternation();
                /*0x781c7e4*/ System.Text.RegularExpressions.RegexNode ReduceConcatenation();
                /*0x781cf40*/ System.Text.RegularExpressions.RegexNode MakeQuantifier(bool lazy, int min, int max);
                /*0x781d058*/ void AddChild(System.Text.RegularExpressions.RegexNode newChild);
                /*0x7818c30*/ System.Text.RegularExpressions.RegexNode Child(int i);
                /*0x7818be4*/ int ChildCount();
                /*0x781d188*/ int Type();
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

                static /*0x7822fd4*/ RegexParser();
                static /*0x781d190*/ System.Text.RegularExpressions.RegexTree Parse(string re, System.Text.RegularExpressions.RegexOptions op);
                static /*0x781e020*/ System.Text.RegularExpressions.RegexReplacement ParseReplacement(string rep, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op);
                static /*0x781e7fc*/ string Escape(string input);
                static /*0x78224d4*/ int HexDigit(char ch);
                static /*0x78225cc*/ System.Text.RegularExpressions.RegexOptions OptionFromCode(char ch);
                static /*0x781f0bc*/ bool IsSpecial(char ch);
                static /*0x781ee94*/ bool IsStopperX(char ch);
                static /*0x781f154*/ bool IsQuantifier(char ch);
                static /*0x7821c3c*/ bool IsSpace(char ch);
                static /*0x781e9f4*/ bool IsMetachar(char ch);
                /*0x781d320*/ RegexParser(System.Globalization.CultureInfo culture);
                /*0x781d3fc*/ void SetPattern(string Re);
                /*0x781d774*/ void Reset(System.Text.RegularExpressions.RegexOptions topopts);
                /*0x781d808*/ System.Text.RegularExpressions.RegexNode ScanRegex();
                /*0x781e1a8*/ System.Text.RegularExpressions.RegexNode ScanReplacement();
                /*0x781f4b8*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly);
                /*0x781fc10*/ System.Text.RegularExpressions.RegexNode ScanGroupOpen();
                /*0x781eb4c*/ void ScanBlank();
                /*0x7820a48*/ System.Text.RegularExpressions.RegexNode ScanBackslash(bool scanOnly);
                /*0x7821d64*/ System.Text.RegularExpressions.RegexNode ScanBasicBackslash(bool scanOnly);
                /*0x7821248*/ System.Text.RegularExpressions.RegexNode ScanDollar();
                /*0x7821950*/ string ScanCapname();
                /*0x7822304*/ char ScanOctal();
                /*0x7821130*/ int ScanDecimal();
                /*0x78223a0*/ char ScanHex(int c);
                /*0x782250c*/ char ScanControl();
                /*0x78225a8*/ bool IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option);
                /*0x7821b30*/ void ScanOptions();
                /*0x78217bc*/ char ScanCharEscape();
                /*0x782164c*/ string ParseProperty();
                /*0x7821cd4*/ int TypeFromCode(char ch);
                /*0x781d434*/ void CountCaptures();
                /*0x782262c*/ void NoteCaptureSlot(int i, int pos);
                /*0x7822764*/ void NoteCaptureName(string name, int pos);
                /*0x781e170*/ void NoteCaptures(System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames);
                /*0x7822910*/ void AssignNameSlots();
                /*0x7821ad8*/ int CaptureSlotFromName(string capname);
                /*0x7821a50*/ bool IsCaptureSlot(int i);
                /*0x7821abc*/ bool IsCaptureName(string capname);
                /*0x7821a44*/ bool UseOptionN();
                /*0x781f4ac*/ bool UseOptionI();
                /*0x7820f78*/ bool UseOptionM();
                /*0x7820ffc*/ bool UseOptionS();
                /*0x781ee30*/ bool UseOptionX();
                /*0x7821640*/ bool UseOptionE();
                /*0x781ef2c*/ bool IsTrueQuantifier();
                /*0x781f1ec*/ void AddConcatenate(int pos, int cch, bool isReplacement);
                /*0x7820558*/ void PushGroup();
                /*0x7820878*/ void PopGroup();
                /*0x782068c*/ bool EmptyStack();
                /*0x781ea8c*/ void StartGroup(System.Text.RegularExpressions.RegexNode openGroup);
                /*0x78205c0*/ void AddAlternate();
                /*0x78210d0*/ void AddConcatenate();
                /*0x78211fc*/ void AddConcatenate(bool lazy, int min, int max);
                /*0x7822fb4*/ System.Text.RegularExpressions.RegexNode Unit();
                /*0x781f3f4*/ void AddUnitOne(char ch);
                /*0x7821008*/ void AddUnitNotone(char ch);
                /*0x781fae4*/ void AddUnitSet(string cc);
                /*0x7822fbc*/ void AddUnitNode(System.Text.RegularExpressions.RegexNode node);
                /*0x7820f84*/ void AddUnitType(int type);
                /*0x7820734*/ void AddGroup();
                /*0x781fb70*/ void PushOptions();
                /*0x78209b0*/ void PopOptions();
                /*0x7822714*/ bool EmptyOptionsStack();
                /*0x78204f4*/ void PopKeepOptions();
                /*0x782069c*/ System.ArgumentException MakeException(string message);
                /*0x7822fc4*/ int Textpos();
                /*0x7822fcc*/ void Textto(int pos);
                /*0x7821104*/ char RightCharMoveRight();
                /*0x781ee3c*/ void MoveRight();
                /*0x7821a34*/ void MoveRight(int i);
                /*0x78210c0*/ void MoveLeft();
                /*0x781f3d8*/ char CharAt(int i);
                /*0x781ee70*/ char RightChar();
                /*0x7821a0c*/ char RightChar(int i);
                /*0x781ee4c*/ int CharsRight();
            }

            struct RegexPrefix
            {
                static /*0x0*/ System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;
                /*0x10*/ bool <CaseInsensitive>k__BackingField;
                /*0x18*/ string <Prefix>k__BackingField;

                static /*0x78230dc*/ RegexPrefix();
                static /*0x782307c*/ System.Text.RegularExpressions.RegexPrefix get_Empty();
                /*0x7818988*/ RegexPrefix(string prefix, bool ci);
                /*0x7823074*/ bool get_CaseInsensitive();
                /*0x78230d4*/ string get_Prefix();
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

                static /*0x782316c*/ System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions roptions);
                /*0x781e2f0*/ RegexReplacement(string rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps);
                /*0x7823280*/ string get_Pattern();
                /*0x7823288*/ void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match);
                /*0x782342c*/ void ReplacementImplRTL(System.Collections.Generic.List<string> al, System.Text.RegularExpressions.Match match);
                /*0x782365c*/ string Replace(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
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

                /*0x7819890*/ RegexRunner();
                /*0x78239f8*/ System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout);
                /*0x7823d48*/ void StartTimeoutWatch();
                /*0x781b954*/ void CheckTimeout();
                /*0x7823ff8*/ void DoCheckTimeout();
                /*0x38159dc*/ void Go();
                /*0x3813ffc*/ bool FindFirstChar();
                /*0x38159dc*/ void InitTrackCount();
                /*0x7823d7c*/ void InitMatch();
                /*0x7823fa0*/ System.Text.RegularExpressions.Match TidyMatch(bool quick);
                /*0x78199b4*/ void EnsureStorage();
                /*0x781bb4c*/ bool IsBoundary(int index, int startpos, int endpos);
                /*0x781bc4c*/ bool IsECMABoundary(int index, int startpos, int endpos);
                /*0x7824170*/ void DoubleTrack();
                /*0x78240c4*/ void DoubleStack();
                /*0x782421c*/ void DoubleCrawl();
                /*0x78242c8*/ void Crawl(int i);
                /*0x7824324*/ int Popcrawl();
                /*0x781bb28*/ int Crawlpos();
                /*0x781ba98*/ void Capture(int capnum, int start, int end);
                /*0x781b984*/ void TransferCapture(int capnum, int uncapnum, int start, int end);
                /*0x781baf8*/ void Uncapture();
                /*0x781b964*/ bool IsMatched(int cap);
                /*0x781bd4c*/ int MatchIndex(int cap);
                /*0x781bd6c*/ int MatchLength(int cap);
            }

            class RegexRunnerFactory
            {
                /*0x7824360*/ RegexRunnerFactory();
                /*0x38148bc*/ System.Text.RegularExpressions.RegexRunner CreateInstance();
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

                /*0x781df74*/ RegexTree(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, int[] capNumList, int capTop, System.Collections.Hashtable capNames, string[] capsList, System.Text.RegularExpressions.RegexOptions options);
            }

            struct RegexWriter
            {
                /*0x10*/ System.Collections.Generic.ValueListBuilder<int> _emitted;
                /*0x30*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x50*/ System.Collections.Generic.Dictionary<string, int> _stringHash;
                /*0x58*/ System.Collections.Generic.List<string> _stringTable;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ int _trackCount;

                static /*0x78244ac*/ System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree);
                /*0x7824368*/ RegexWriter(System.Span<int> emittedSpan, System.Span<int> intStackSpan);
                /*0x7824a0c*/ void Dispose();
                /*0x7824590*/ System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x78255c8*/ void PatchJump(int offset, int jumpDest);
                /*0x782562c*/ void Emit(int op);
                /*0x7824a60*/ void Emit(int op, int opd1);
                /*0x78256f4*/ void Emit(int op, int opd1, int opd2);
                /*0x7825884*/ int StringCode(string str);
                /*0x78259cc*/ int MapCapnum(int capnum);
                /*0x7824b90*/ void EmitFragment(int nodetype, System.Text.RegularExpressions.RegexNode node, int curIndex);
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

                /*0x7825b38*/ GeneratedCodeAttribute(string tool, string version);
            }
        }
    }

    namespace Diagnostics
    {
        class BooleanSwitch : System.Diagnostics.Switch
        {
            /*0x7825b7c*/ BooleanSwitch(string displayName, string description);
            /*0x7825c48*/ void OnValueChanged();
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
            /*0x7825e6c*/ SourceSwitch(string displayName, string defaultSwitchValue);
            /*0x7826158*/ System.Diagnostics.SourceLevels get_Level();
            /*0x78261a0*/ void set_Level(System.Diagnostics.SourceLevels value);
            /*0x78261a4*/ void OnValueChanged();
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

            static /*0x782691c*/ Switch();
            static /*0x78262ec*/ void _pruneCachedSwitches();
            /*0x7825be8*/ Switch(string displayName, string description);
            /*0x7825ef0*/ Switch(string displayName, string description, string defaultSwitchValue);
            /*0x782627c*/ object get_IntializedLock();
            /*0x782615c*/ int get_SwitchSetting();
            /*0x7825cd4*/ void set_SwitchSetting(int value);
            /*0x7825cb4*/ string get_Value();
            /*0x782690c*/ void Initialize();
            /*0x78267d0*/ bool InitializeWithStatus();
            /*0x7826910*/ bool InitializeConfigSettings();
            /*0x7826918*/ void OnSwitchSettingChanged();
            /*0x7825dec*/ void OnValueChanged();
        }

        class SwitchLevelAttribute : System.Attribute
        {
            /*0x10*/ System.Type type;

            /*0x78269b4*/ SwitchLevelAttribute(System.Type switchLevelType);
            /*0x78269e0*/ void set_SwitchLevelType(System.Type value);
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

            static /*0x7826b9c*/ TraceInternal();
            static /*0x7826a80*/ bool get_UseGlobalLock();
            static /*0x7826ae4*/ int get_IndentLevel();
            static /*0x7826b3c*/ int get_IndentSize();
            static /*0x7826ae0*/ void InitializeSettings();
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

            /*0x7826c30*/ TraceListener(string name);
            /*0x7826c70*/ string get_Name();
            /*0x7826cc0*/ bool get_IsThreadSafe();
            /*0x7826cc8*/ void Dispose();
            /*0x7826d34*/ void Dispose(bool disposing);
            /*0x7826d38*/ void Flush();
            /*0x7826d3c*/ void set_IndentLevel(int value);
            /*0x7826d58*/ void set_IndentSize(int value);
        }

        class TraceListenerCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.ArrayList list;

            /*0x7826e00*/ TraceListenerCollection();
            /*0x7826e70*/ System.Diagnostics.TraceListener get_Item(string name);
            /*0x782719c*/ int get_Count();
            /*0x78271c0*/ int Add(System.Diagnostics.TraceListener listener);
            /*0x78273e8*/ void Clear();
            /*0x7827178*/ System.Collections.IEnumerator GetEnumerator();
            /*0x78272f8*/ void InitializeListener(System.Diagnostics.TraceListener listener);
            /*0x7827448*/ void Remove(string name);
            /*0x7827508*/ void RemoveAt(int index);
            /*0x7827628*/ object System.Collections.IList.get_Item(int index);
            /*0x782764c*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x7827758*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x7827760*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x7827768*/ int System.Collections.IList.Add(object value);
            /*0x7827948*/ bool System.Collections.IList.Contains(object value);
            /*0x782796c*/ int System.Collections.IList.IndexOf(object value);
            /*0x7827990*/ void System.Collections.IList.Insert(int index, object value);
            /*0x7827b68*/ void System.Collections.IList.Remove(object value);
            /*0x7827c88*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x7827c8c*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x7827c94*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
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

            static /*0x7828fa0*/ TraceSource();
            static /*0x7828050*/ void _pruneCachedTraceSources();
            /*0x7827dc4*/ TraceSource(string name);
            /*0x7827dcc*/ TraceSource(string name, System.Diagnostics.SourceLevels defaultLevel);
            /*0x7828534*/ void Initialize();
            /*0x7828624*/ void NoConfigInit();
            /*0x78287e4*/ void Flush();
            /*0x7828f60*/ System.Diagnostics.TraceListenerCollection get_Listeners();
            /*0x7828f80*/ System.Diagnostics.SourceSwitch get_Switch();
        }

        class TraceSwitch : System.Diagnostics.Switch
        {
            /*0x7829038*/ TraceSwitch(string displayName, string description);
            /*0x78290a4*/ void OnSwitchSettingChanged();
            /*0x78290dc*/ void OnValueChanged();
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

            /*0x78291b4*/ void Close();
            /*0x78291c4*/ void Dispose(bool disposing);
            /*0x782958c*/ void CancelOperation();
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

            static /*0x782a634*/ System.Diagnostics.Process GetCurrentProcess();
            static /*0x782aca8*/ string ProcessName_icall(nint handle);
            static /*0x782acac*/ string ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0x7829598*/ Process(string machineName, bool isRemoteMachine, int processId, System.Diagnostics.ProcessInfo processInfo);
            /*0x7829644*/ bool get_Associated();
            /*0x7829664*/ bool get_HasExited();
            /*0x782a0bc*/ int get_Id();
            /*0x782a0d8*/ System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject();
            /*0x782a27c*/ void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0x782a2a4*/ void Dispose(bool disposing);
            /*0x782a2f4*/ void Close();
            /*0x78299c0*/ void EnsureState(System.Diagnostics.Process.State state);
            /*0x782a6b4*/ void OnExited();
            /*0x7829ae8*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access, bool throwIfExited);
            /*0x782a908*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access);
            /*0x782a5fc*/ void Refresh();
            /*0x782a4c8*/ void StopWatchingForExit();
            /*0x782a910*/ string ToString();
            /*0x782aa70*/ string get_ProcessName();
            /*0x7829fdc*/ void RaiseOnExited();

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
            /*0x7829f84*/ ProcessWaitHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle);
        }

        class DefaultTraceListener : System.Diagnostics.TraceListener
        {
            static /*0x0*/ bool OnWin32;
            static /*0x8*/ string MonoTracePrefix;
            static /*0x10*/ string MonoTraceFile;

            static /*0x782ad9c*/ DefaultTraceListener();
            static /*0x782af0c*/ string GetPrefix(string var, string target);
            /*0x7828778*/ DefaultTraceListener();
        }

        class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute
        {
            /*0x782af88*/ MonitoringDescriptionAttribute(string description);
            /*0x782aff0*/ string get_Description();
        }

        class Stopwatch
        {
            static /*0x0*/ long Frequency;
            static /*0x8*/ bool IsHighResolution;
            /*0x10*/ long elapsed;
            /*0x18*/ long started;
            /*0x20*/ bool is_running;

            static /*0x782b45c*/ Stopwatch();
            static /*0x782aff8*/ long GetTimestamp();
            static /*0x782affc*/ System.Diagnostics.Stopwatch StartNew();
            /*0x782b060*/ Stopwatch();
            /*0x782b0d0*/ System.TimeSpan get_Elapsed();
            /*0x782b238*/ long get_ElapsedMilliseconds();
            /*0x782b1c8*/ long get_ElapsedTicks();
            /*0x782b37c*/ bool get_IsRunning();
            /*0x782b068*/ void Start();
            /*0x782b384*/ void Stop();
            /*0x782b3fc*/ void Restart();
        }

        namespace CodeAnalysis
        {
            class ExcludeFromCodeCoverageAttribute : System.Attribute
            {
                /*0x782b4b4*/ ExcludeFromCodeCoverageAttribute();
            }
        }
    }

    namespace Security
    {
        namespace Authentication
        {
            class AuthenticationException : System.SystemException
            {
                /*0x782b4bc*/ AuthenticationException();
                /*0x782b514*/ AuthenticationException(string message, System.Exception innerException);
                /*0x782b51c*/ AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

                static /*0x782c0e8*/ string TrimTrailingNulls(string value);
                static /*0x782c228*/ void CheckTag(System.Security.Cryptography.DerSequenceReader.DerTag expected, byte[] data, int position);
                static /*0x782b8d0*/ int ScanContentLength(byte[] data, int offset, int end, ref int bytesConsumed);
                /*0x782b52c*/ DerSequenceReader(byte[] data);
                /*0x782b550*/ DerSequenceReader(byte[] data, int offset, int length);
                /*0x782b564*/ DerSequenceReader(System.Security.Cryptography.DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length);
                /*0x782b524*/ void set_ContentLength(int value);
                /*0x782b720*/ bool get_HasData();
                /*0x782b730*/ byte PeekTag();
                /*0x782b7c4*/ void SkipValue();
                /*0x782b818*/ byte[] ReadNextEncodedValue();
                /*0x782b9f4*/ bool ReadBoolean();
                /*0x782babc*/ int ReadInteger();
                /*0x782bb70*/ byte[] ReadIntegerBytes();
                /*0x782bc40*/ byte[] ReadBitString();
                /*0x782bd84*/ byte[] ReadOctetString();
                /*0x782bda0*/ string ReadOidAsString();
                /*0x782c068*/ string ReadUtf8String();
                /*0x782c164*/ System.Security.Cryptography.DerSequenceReader ReadCollectionWithTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x782c2bc*/ System.Security.Cryptography.DerSequenceReader ReadSequence();
                /*0x782c2c4*/ System.Security.Cryptography.DerSequenceReader ReadSet();
                /*0x782c2cc*/ string ReadPrintableString();
                /*0x782c34c*/ string ReadIA5String();
                /*0x782c3cc*/ string ReadT61String();
                /*0x782c6b4*/ System.DateTime ReadX509Date();
                /*0x782c734*/ System.DateTime ReadUtcTime();
                /*0x782c780*/ System.DateTime ReadGeneralizedTime();
                /*0x782ca14*/ string ReadBMPString();
                /*0x782c7cc*/ System.DateTime ReadTime(System.Security.Cryptography.DerSequenceReader.DerTag timeTag, string formatString);
                /*0x782bb8c*/ byte[] ReadContentAsBytes();
                /*0x782b664*/ void EatTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x782b6e4*/ int EatLength();

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

                    static /*0x782ca94*/ <>c();
                    /*0x782cafc*/ <>c();
                    /*0x782cb04*/ System.Text.Encoding <ReadT61String>b__45_0();
                    /*0x782cb60*/ System.Text.Encoding <ReadT61String>b__45_1();
                    /*0x782cba4*/ System.Globalization.DateTimeFormatInfo <ReadTime>b__51_0();
                }
            }

            class Oid
            {
                /*0x10*/ string _value;
                /*0x18*/ string _friendlyName;
                /*0x20*/ System.Security.Cryptography.OidGroup _group;

                static /*0x782cde8*/ System.Security.Cryptography.Oid FromOidValue(string oidValue, System.Security.Cryptography.OidGroup group);
                /*0x782cc70*/ Oid();
                /*0x782cc78*/ Oid(string oid);
                /*0x782cd0c*/ Oid(string value, string friendlyName);
                /*0x782cd50*/ Oid(System.Security.Cryptography.Oid oid);
                /*0x782cf14*/ Oid(string value, string friendlyName, System.Security.Cryptography.OidGroup group);
                /*0x782cf6c*/ string get_Value();
                /*0x782cf74*/ void set_Value(string value);
                /*0x782cf7c*/ string get_FriendlyName();
            }

            class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.Oid> _list;

                /*0x782d014*/ OidCollection();
                /*0x782d09c*/ int Add(System.Security.Cryptography.Oid oid);
                /*0x782d158*/ System.Security.Cryptography.Oid get_Item(int index);
                /*0x782d1b0*/ int get_Count();
                /*0x782d1f8*/ System.Security.Cryptography.OidEnumerator GetEnumerator();
                /*0x782d2a4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x782d2a8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x782d454*/ bool get_IsSynchronized();
                /*0x782d45c*/ object get_SyncRoot();
            }

            class OidEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Security.Cryptography.OidCollection _oids;
                /*0x18*/ int _current;

                /*0x782d268*/ OidEnumerator(System.Security.Cryptography.OidCollection oids);
                /*0x782d460*/ System.Security.Cryptography.Oid get_Current();
                /*0x782d480*/ object System.Collections.IEnumerator.get_Current();
                /*0x782d484*/ bool MoveNext();
                /*0x782d4d0*/ void Reset();
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

                /*0x782d4dc*/ AsnEncodedData();
                /*0x782d4e4*/ AsnEncodedData(string oid, byte[] rawData);
                /*0x782d660*/ AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData);
                /*0x782d714*/ AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x782d7e8*/ System.Security.Cryptography.Oid get_Oid();
                /*0x782d69c*/ void set_Oid(System.Security.Cryptography.Oid value);
                /*0x782d7f0*/ byte[] get_RawData();
                /*0x782d56c*/ void set_RawData(byte[] value);
                /*0x782d7f8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x782d8c8*/ string Format(bool multiLine);
                /*0x782da20*/ string ToString(bool multiLine);
                /*0x782d908*/ string Default(bool multiLine);
                /*0x782dbd0*/ string BasicConstraintsExtension(bool multiLine);
                /*0x782dcd4*/ string EnhancedKeyUsageExtension(bool multiLine);
                /*0x782ddd8*/ string KeyUsageExtension(bool multiLine);
                /*0x782dedc*/ string SubjectKeyIdentifierExtension(bool multiLine);
                /*0x782dfe0*/ string SubjectAltName(bool multiLine);
                /*0x782e394*/ string NetscapeCertType(bool multiLine);
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

                    static /*0x782f758*/ PublicKey();
                    static /*0x782f6c4*/ byte[] GetUnsignedBigInteger(byte[] integer);
                    static /*0x782f1f0*/ System.Security.Cryptography.DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters);
                    static /*0x782ee38*/ System.Security.Cryptography.RSA DecodeRSA(byte[] rawPublicKey);
                    /*0x782eb0c*/ PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue);
                    /*0x782ec84*/ System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue();
                    /*0x782ec8c*/ System.Security.Cryptography.AsnEncodedData get_EncodedParameters();
                    /*0x782ec94*/ System.Security.Cryptography.AsymmetricAlgorithm get_Key();
                    /*0x782f6bc*/ System.Security.Cryptography.Oid get_Oid();
                }

                class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ string name;
                    /*0x28*/ byte[] canonEncoding;

                    static /*0x782faf8*/ string GetSeparator(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    static /*0x782fbcc*/ string Canonize(string s);
                    static /*0x782fd9c*/ bool AreEqual(System.Security.Cryptography.X509Certificates.X500DistinguishedName name1, System.Security.Cryptography.X509Certificates.X500DistinguishedName name2);
                    /*0x782f7cc*/ X500DistinguishedName(byte[] encodedDistinguishedName);
                    /*0x782f9ac*/ string get_Name();
                    /*0x782f9b4*/ string Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    /*0x782fb70*/ string Format(bool multiLine);
                    /*0x782f8c8*/ void DecodeRawData();
                }

                class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.19";
                    static string friendlyName = "Basic Constraints";
                    /*0x21*/ bool _certificateAuthority;
                    /*0x22*/ bool _hasPathLengthConstraint;
                    /*0x24*/ int _pathLengthConstraint;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x782ff8c*/ X509BasicConstraintsExtension();
                    /*0x782e76c*/ X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical);
                    /*0x78301f8*/ X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical);
                    /*0x783048c*/ bool get_CertificateAuthority();
                    /*0x78304f4*/ bool get_HasPathLengthConstraint();
                    /*0x783055c*/ int get_PathLengthConstraint();
                    /*0x78305c4*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x7830034*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x7830330*/ byte[] Encode();
                    /*0x7830790*/ string ToString(bool multiLine);
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

                    static /*0x7831a00*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
                    static /*0x783128c*/ System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid);
                    /*0x7830ba8*/ X509Certificate2();
                    /*0x7830bb0*/ X509Certificate2(byte[] rawData);
                    /*0x7830d78*/ X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
                    /*0x7830d80*/ X509Certificate2(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x7830afc*/ void Reset();
                    /*0x7830dc0*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection get_Extensions();
                    /*0x78314c0*/ bool get_HasPrivateKey();
                    /*0x78314f4*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x7831658*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x78316c4*/ System.DateTime get_NotAfter();
                    /*0x78316cc*/ System.DateTime get_NotBefore();
                    /*0x78316d4*/ System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    /*0x783182c*/ byte[] get_RawData();
                    /*0x7831898*/ string get_SerialNumber();
                    /*0x78318a8*/ System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    /*0x783191c*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x7831988*/ string get_Thumbprint();
                    /*0x78319a4*/ int get_Version();
                    /*0x7831a98*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x7831ad4*/ string ToString();
                    /*0x7831ae0*/ string ToString(bool verbose);
                    /*0x7832b80*/ bool Verify();
                    /*0x7831200*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl();
                }

                class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection
                {
                    static /*0x0*/ string[] newline_split;

                    static /*0x7834ed0*/ X509Certificate2Collection();
                    /*0x7832d8c*/ X509Certificate2Collection();
                    /*0x7832d9c*/ X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x7832e38*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Item(int index);
                    /*0x7832f5c*/ int Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7832dc8*/ void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x7832fcc*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x783330c*/ string GetKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 x);
                    /*0x7833bb8*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, bool validOnly);
                    /*0x7834dbc*/ System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator();
                }

                class X509Certificate2Enumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x7834e14*/ X509Certificate2Enumerator(System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection);
                    /*0x7834f74*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Current();
                    /*0x7835064*/ bool MoveNext();
                    /*0x7835104*/ object System.Collections.IEnumerator.get_Current();
                    /*0x78351a8*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x7835248*/ void System.Collections.IEnumerator.Reset();
                }

                class X509Certificate2Impl : System.Security.Cryptography.X509Certificates.X509CertificateImpl
                {
                    /*0x78352ec*/ X509Certificate2Impl();
                    /*0x38148bc*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x38148bc*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x3816710*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0x38148bc*/ string get_SignatureAlgorithm();
                    /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x3814574*/ int get_Version();
                    /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x38141c4*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0x3816710*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509Certificate2ImplMono : System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix
                {
                    static /*0x0*/ string empty_error;
                    static /*0x8*/ byte[] signedData;
                    /*0xb0*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;
                    /*0xb8*/ Mono.Security.X509.X509Certificate _cert;

                    static /*0x783677c*/ X509Certificate2ImplMono();
                    /*0x7835304*/ X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert);
                    /*0x783533c*/ X509Certificate2ImplMono(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other);
                    /*0x78353f4*/ X509Certificate2ImplMono(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x78352f4*/ bool get_IsValid();
                    /*0x78355c4*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone();
                    /*0x7835628*/ Mono.Security.X509.X509Certificate get_Cert();
                    /*0x7835644*/ byte[] GetRawCertData();
                    /*0x783567c*/ bool get_HasPrivateKey();
                    /*0x78356a0*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x7835a98*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0x7835c20*/ System.Security.Cryptography.RSA GetRSAPrivateKey();
                    /*0x7835cac*/ System.Security.Cryptography.DSA GetDSAPrivateKey();
                    /*0x783556c*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password);
                    /*0x7835d38*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password);
                    /*0x7836650*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0x783676c*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    /*0x7836774*/ Mono.Security.X509.X509Certificate get_MonoCertificate();
                }

                class X509Certificate2ImplUnix : System.Security.Cryptography.X509Certificates.X509Certificate2Impl
                {
                    /*0x10*/ bool readCertData;
                    /*0x18*/ Internal.Cryptography.Pal.CertificateData certData;

                    /*0x7835334*/ X509Certificate2ImplUnix();
                    /*0x7836850*/ void EnsureCertData();
                    /*0x38148bc*/ byte[] GetRawCertData();
                    /*0x78368e0*/ string get_KeyAlgorithm();
                    /*0x78368f8*/ byte[] get_KeyAlgorithmParameters();
                    /*0x7836910*/ byte[] get_PublicKeyValue();
                    /*0x7836928*/ byte[] get_SerialNumber();
                    /*0x7836940*/ string get_SignatureAlgorithm();
                    /*0x7836958*/ int get_Version();
                    /*0x7836974*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x783698c*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x78369a4*/ string get_Subject();
                    /*0x78369cc*/ string get_Issuer();
                    /*0x78369f4*/ byte[] get_RawData();
                    /*0x7836a0c*/ byte[] get_Thumbprint();
                    /*0x7836b9c*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x7836bd0*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0x7836be8*/ System.DateTime get_NotAfter();
                    /*0x7836c48*/ System.DateTime get_NotBefore();
                    /*0x7836ca8*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509CertificateCollection : System.Collections.CollectionBase
                {
                    /*0x7832d94*/ X509CertificateCollection();
                    /*0x7836d3c*/ X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x7836e38*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Item(int index);
                    /*0x7836d68*/ void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x7836ed0*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                    /*0x7836fe4*/ int GetHashCode();

                    class X509CertificateEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.IEnumerator enumerator;

                        /*0x7836f28*/ X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings);
                        /*0x7837004*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Current();
                        /*0x78370f4*/ object System.Collections.IEnumerator.get_Current();
                        /*0x7837198*/ bool System.Collections.IEnumerator.MoveNext();
                        /*0x7837238*/ void System.Collections.IEnumerator.Reset();
                        /*0x78372dc*/ bool MoveNext();
                    }
                }

                class X509CertificateImplCollection : System.IDisposable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list;

                    /*0x78364f0*/ X509CertificateImplCollection();
                    /*0x783737c*/ X509CertificateImplCollection(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other);
                    /*0x78375b4*/ int get_Count();
                    /*0x78375fc*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(int index);
                    /*0x7836578*/ void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, bool takeOwnership);
                    /*0x783539c*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone();
                    /*0x7837654*/ void Dispose();
                    /*0x78376c0*/ void Dispose(bool disposing);
                    /*0x78378d8*/ void Finalize();
                }

                class X509Chain : System.IDisposable
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainImpl impl;

                    static /*0x78366dc*/ System.Security.Cryptography.X509Certificates.X509Chain Create();
                    /*0x78379d4*/ X509Chain();
                    /*0x78379dc*/ X509Chain(bool useMachineContext);
                    /*0x7837a6c*/ X509Chain(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    /*0x7837aa4*/ X509Chain(nint chainContext);
                    /*0x7837978*/ System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl();
                    /*0x7837ae4*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x7837b10*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x7836730*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7837b3c*/ void Reset();
                    /*0x7837b68*/ void Dispose();
                    /*0x7837bd4*/ void Dispose(bool disposing);
                    /*0x7837c70*/ void Finalize();
                }

                class X509ChainElement
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509Certificate2 certificate;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x20*/ string info;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags compressed_status_flags;

                    /*0x7837d10*/ X509ChainElement(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7837d60*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate();
                    /*0x7837d68*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainElementStatus();
                    /*0x7837d70*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_StatusFlags();
                    /*0x7837d78*/ void set_StatusFlags(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x7837d80*/ int Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x7837da4*/ void Set(System.Security.Cryptography.X509Certificates.X509ChainStatus[] status, ref int position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask);
                    /*0x7837fa4*/ void UncompressFlags();
                }

                class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _list;

                    /*0x7838204*/ X509ChainElementCollection();
                    /*0x7838270*/ int get_Count();
                    /*0x7838294*/ bool get_IsSynchronized();
                    /*0x78382b8*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(int index);
                    /*0x7838350*/ object get_SyncRoot();
                    /*0x7838374*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x7838398*/ System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator();
                    /*0x78384b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x783850c*/ void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x783858c*/ void Clear();
                    /*0x78385b0*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                }

                class X509ChainElementEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x78383f4*/ X509ChainElementEnumerator(System.Collections.IEnumerable enumerable);
                    /*0x78386b8*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Current();
                    /*0x78387a8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x783884c*/ bool MoveNext();
                    /*0x78388ec*/ void Reset();
                }

                class X509ChainImpl : System.IDisposable
                {
                    /*0x7838af0*/ X509ChainImpl();
                    /*0x3813ffc*/ bool get_IsValid();
                    /*0x7838990*/ void ThrowIfContextInvalid();
                    /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x38148bc*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x38141c4*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x3815ed0*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode);
                    /*0x38159dc*/ void Reset();
                    /*0x7837c04*/ void Dispose();
                    /*0x7838a4c*/ void Dispose(bool disposing);
                    /*0x7838a50*/ void Finalize();
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

                    static /*0x783c1f0*/ X509ChainImplMono();
                    static /*0x783a79c*/ string GetAuthorityKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x783b388*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Crl crl);
                    static /*0x783b230*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext);
                    static /*0x783be70*/ Mono.Security.X509.X509Crl CheckCrls(string subject, string ski, Mono.Security.X509.X509Store store);
                    /*0x7838af8*/ X509ChainImplMono(bool useMachineContext);
                    /*0x7838bd8*/ bool get_IsValid();
                    /*0x7838be0*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x7838be8*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x7838bf0*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
                    /*0x7838bf4*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x7839424*/ void Reset();
                    /*0x78395a4*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Roots();
                    /*0x78398f0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateAuthorities();
                    /*0x7839678*/ System.Security.Cryptography.X509Certificates.X509Store get_LMRootStore();
                    /*0x7839770*/ System.Security.Cryptography.X509Certificates.X509Store get_UserRootStore();
                    /*0x78399c4*/ System.Security.Cryptography.X509Certificates.X509Store get_LMCAStore();
                    /*0x7839abc*/ System.Security.Cryptography.X509Certificates.X509Store get_UserCAStore();
                    /*0x783a0e0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateCollection();
                    /*0x78391e4*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x783a610*/ System.Security.Cryptography.X509Certificates.X509Certificate2 SelectBestFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2 child, System.Security.Cryptography.X509Certificates.X509Certificate2Collection c);
                    /*0x783a434*/ System.Security.Cryptography.X509Certificates.X509Certificate2 FindParent(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x783a548*/ bool IsChainComplete(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x783a8d4*/ bool IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x78392cc*/ void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x783a91c*/ void Process(int n);
                    /*0x783abc4*/ void PrepareForNextCertificate(int n);
                    /*0x783afbc*/ void WrapUp();
                    /*0x783b148*/ void ProcessCertificateExtensions(System.Security.Cryptography.X509Certificates.X509ChainElement element);
                    /*0x783b110*/ bool IsSignedWith(System.Security.Cryptography.X509Certificates.X509Certificate2 signed, System.Security.Cryptography.AsymmetricAlgorithm pubkey);
                    /*0x783a830*/ string GetSubjectKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x783add4*/ void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x783b414*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, int ca, bool online);
                    /*0x783b4e0*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2 ca_cert, bool online);
                    /*0x783b6b4*/ Mono.Security.X509.X509Crl FindCrl(System.Security.Cryptography.X509Certificates.X509Certificate2 caCertificate);
                    /*0x783bb30*/ bool ProcessCrlExtensions(Mono.Security.X509.X509Crl crl);
                    /*0x783b828*/ bool ProcessCrlEntryExtensions(Mono.Security.X509.X509Crl.X509CrlEntry entry);
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

                    /*0x7838bbc*/ X509ChainPolicy();
                    /*0x783a1c4*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_ExtraStore();
                    /*0x783c374*/ System.Security.Cryptography.X509Certificates.X509RevocationFlag get_RevocationFlag();
                    /*0x783c37c*/ System.Security.Cryptography.X509Certificates.X509RevocationMode get_RevocationMode();
                    /*0x783c384*/ void set_RevocationMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                    /*0x783c3e4*/ System.Security.Cryptography.X509Certificates.X509VerificationFlags get_VerificationFlags();
                    /*0x783c3ec*/ void set_VerificationFlags(System.Security.Cryptography.X509Certificates.X509VerificationFlags value);
                    /*0x783c44c*/ System.DateTime get_VerificationTime();
                    /*0x783c264*/ void Reset();
                }

                struct X509ChainStatus
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status;
                    /*0x18*/ string info;

                    static /*0x7837e20*/ string GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x78393fc*/ X509ChainStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x783c454*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_Status();
                    /*0x783c45c*/ void set_Status(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x783c464*/ void set_StatusInformation(string value);
                }

                class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    /*0x28*/ System.Security.Cryptography.OidCollection _enhKeyUsage;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x7832c4c*/ X509EnhancedKeyUsageExtension();
                    /*0x782e854*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical);
                    /*0x783c6b8*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical);
                    /*0x783c904*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x783c46c*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x783c848*/ byte[] Encode();
                    /*0x783cad0*/ string ToString(bool multiLine);
                }

                class X509Extension : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ bool _critical;

                    /*0x783002c*/ X509Extension();
                    /*0x783cd94*/ X509Extension(string oid, byte[] rawData, bool critical);
                    /*0x783cdb8*/ bool get_Critical();
                    /*0x783cdc0*/ void set_Critical(bool value);
                    /*0x783cdcc*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x78309ec*/ string FormatUnkownData(byte[] data);
                }

                class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Collections.ArrayList _list;

                    static /*0x783d0b4*/ X509ExtensionCollection();
                    /*0x7831194*/ X509ExtensionCollection();
                    /*0x7832970*/ int get_Count();
                    /*0x783ceec*/ bool get_IsSynchronized();
                    /*0x783cf10*/ object get_SyncRoot();
                    /*0x78333c8*/ System.Security.Cryptography.X509Certificates.X509Extension get_Item(string oid);
                    /*0x7831450*/ int Add(System.Security.Cryptography.X509Certificates.X509Extension extension);
                    /*0x783cf14*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x7832994*/ System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator();
                    /*0x783d058*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class X509ExtensionEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x783d00c*/ X509ExtensionEnumerator(System.Collections.ArrayList list);
                    /*0x78329f0*/ System.Security.Cryptography.X509Certificates.X509Extension get_Current();
                    /*0x783d128*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7832ae0*/ bool MoveNext();
                    /*0x783d1cc*/ void Reset();
                }

                class X509Helper2
                {
                    static /*0x783b048*/ Mono.Security.X509.X509Certificate GetMonoCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x7837a14*/ System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(bool useMachineContext);
                    static /*0x783d270*/ bool IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x7837994*/ void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x78389cc*/ System.Exception GetInvalidChainContextException();
                }

                class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.15";
                    static string friendlyName = "Key Usage";
                    static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all = 33023;
                    /*0x24*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x7832bac*/ X509KeyUsageExtension();
                    /*0x782e93c*/ X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical);
                    /*0x783d438*/ X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical);
                    /*0x7834d54*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages();
                    /*0x783d680*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x783d514*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags);
                    /*0x783d284*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x783d524*/ byte[] Encode();
                    /*0x783d84c*/ string ToString(bool multiLine);
                }

                class X509Store : System.IDisposable
                {
                    /*0x10*/ string _name;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.StoreLocation _location;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection list;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.OpenFlags _flags;
                    /*0x30*/ Mono.Security.X509.X509Store store;

                    /*0x7839bb4*/ X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation);
                    /*0x7839868*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Certificates();
                    /*0x783dda0*/ Mono.Security.X509.X509Stores get_Factory();
                    /*0x783ddbc*/ Mono.Security.X509.X509Store get_Store();
                    /*0x7839570*/ void Close();
                    /*0x783ddc4*/ void Dispose();
                    /*0x7839cec*/ void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags);
                }

                class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.14";
                    static string friendlyName = "Subject Key Identifier";
                    /*0x28*/ byte[] _subjectKeyIdentifier;
                    /*0x30*/ string _ski;
                    /*0x38*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    static /*0x783e5b4*/ byte FromHexChar(char c);
                    static /*0x783e5f8*/ byte FromHexChars(char c1, char c2);
                    static /*0x783e2e8*/ byte[] FromHex(string hex);
                    /*0x7832cec*/ X509SubjectKeyIdentifierExtension();
                    /*0x782ea24*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical);
                    /*0x783df34*/ X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical);
                    /*0x783e180*/ X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical);
                    /*0x783e3dc*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical);
                    /*0x783375c*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical);
                    /*0x7833b2c*/ string get_SubjectKeyIdentifier();
                    /*0x783e3e8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x783ddc8*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x783e10c*/ byte[] Encode();
                    /*0x783e694*/ string ToString(bool multiLine);
                }
            }
        }
    }

    namespace ComponentModel
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object _value;

            /*0x783e8c0*/ DefaultValueAttribute(int value);
            /*0x783e90c*/ DefaultValueAttribute(long value);
            /*0x783e958*/ DefaultValueAttribute(bool value);
            /*0x783e9a4*/ DefaultValueAttribute(string value);
            /*0x783e9d4*/ DefaultValueAttribute(object value);
            /*0x783ea04*/ object get_Value();
            /*0x783ea0c*/ bool Equals(object obj);
            /*0x783eb18*/ int GetHashCode();
        }

        class EditorBrowsableAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.EditorBrowsableState browsableState;

            /*0x783eb20*/ EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state);
            /*0x783eb48*/ bool Equals(object obj);
            /*0x783ebd4*/ int GetHashCode();
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

            static /*0x783ed94*/ BrowsableAttribute();
            /*0x783ebdc*/ BrowsableAttribute(bool browsable);
            /*0x783ec04*/ bool get_Browsable();
            /*0x783ec0c*/ bool Equals(object obj);
            /*0x783ecf0*/ int GetHashCode();
            /*0x783ed2c*/ bool IsDefaultAttribute();
        }

        class ComponentCollection : System.Collections.ReadOnlyCollectionBase
        {
            /*0x783ee44*/ System.ComponentModel.IComponent get_Item(string name);
        }

        class DescriptionAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DescriptionAttribute Default;
            /*0x10*/ string <DescriptionValue>k__BackingField;

            static /*0x783f59c*/ DescriptionAttribute();
            /*0x783f3b8*/ DescriptionAttribute();
            /*0x783f3f8*/ DescriptionAttribute(string description);
            /*0x783f428*/ string get_Description();
            /*0x783f430*/ string get_DescriptionValue();
            /*0x783f438*/ void set_DescriptionValue(string value);
            /*0x783f440*/ bool Equals(object obj);
            /*0x783f50c*/ int GetHashCode();
            /*0x783f534*/ bool IsDefaultAttribute();
        }

        class DesignOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.DesignOnlyAttribute Default;
            /*0x10*/ bool <IsDesignOnly>k__BackingField;

            static /*0x783f7f8*/ DesignOnlyAttribute();
            /*0x783f628*/ DesignOnlyAttribute(bool isDesignOnly);
            /*0x783f650*/ bool get_IsDesignOnly();
            /*0x783f658*/ bool Equals(object obj);
            /*0x783f73c*/ int GetHashCode();
            /*0x783f778*/ bool IsDefaultAttribute();
        }

        class DesignerCategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerCategoryAttribute Component;
            static /*0x8*/ System.ComponentModel.DesignerCategoryAttribute Default;
            static /*0x10*/ System.ComponentModel.DesignerCategoryAttribute Form;
            static /*0x18*/ System.ComponentModel.DesignerCategoryAttribute Generic;
            /*0x10*/ string <Category>k__BackingField;

            static /*0x783fa74*/ DesignerCategoryAttribute();
            /*0x783f8a8*/ DesignerCategoryAttribute();
            /*0x783f8dc*/ DesignerCategoryAttribute(string category);
            /*0x783f90c*/ string get_Category();
            /*0x783f914*/ bool Equals(object obj);
            /*0x783f9a4*/ int GetHashCode();
            /*0x783f9c4*/ bool IsDefaultAttribute();
            /*0x783fa3c*/ object get_TypeId();
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

            static /*0x783fd6c*/ DesignerSerializationVisibilityAttribute();
            /*0x783fbf4*/ DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility);
            /*0x783fc1c*/ System.ComponentModel.DesignerSerializationVisibility get_Visibility();
            /*0x783fc24*/ bool Equals(object obj);
            /*0x783fcfc*/ int GetHashCode();
            /*0x783fd04*/ bool IsDefaultAttribute();
        }

        class DisplayNameAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DisplayNameAttribute Default;
            /*0x10*/ string <DisplayNameValue>k__BackingField;

            static /*0x7840030*/ DisplayNameAttribute();
            /*0x783fe4c*/ DisplayNameAttribute();
            /*0x783fe8c*/ DisplayNameAttribute(string displayName);
            /*0x783febc*/ string get_DisplayName();
            /*0x783fec4*/ string get_DisplayNameValue();
            /*0x783fecc*/ void set_DisplayNameValue(string value);
            /*0x783fed4*/ bool Equals(object obj);
            /*0x783ffa0*/ int GetHashCode();
            /*0x783ffc8*/ bool IsDefaultAttribute();
        }

        class EventHandlerList
        {
            /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _head;
            /*0x18*/ System.ComponentModel.Component _parent;

            /*0x78400bc*/ System.Delegate get_Item(object key);
            /*0x7840124*/ System.ComponentModel.EventHandlerList.ListEntry Find(object key);

            class ListEntry
            {
                /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _next;
                /*0x18*/ object _key;
                /*0x20*/ System.Delegate _handler;
            }
        }

        interface IContainer : System.IDisposable
        {
            /*0x38148bc*/ System.ComponentModel.ComponentCollection get_Components();
            /*0x3816710*/ void Remove(System.ComponentModel.IComponent component);
        }

        interface ISite : System.IServiceProvider
        {
            /*0x38148bc*/ System.ComponentModel.IContainer get_Container();
            /*0x3813ffc*/ bool get_DesignMode();
            /*0x38148bc*/ string get_Name();
        }

        interface ISynchronizeInvoke
        {
            /*0x3813ffc*/ bool get_InvokeRequired();
            /*0x3814b90*/ System.IAsyncResult BeginInvoke(System.Delegate method, object[] args);
        }

        class InvalidEnumArgumentException : System.ArgumentException
        {
            /*0x784013c*/ InvalidEnumArgumentException();
            /*0x7840148*/ InvalidEnumArgumentException(string message);
            /*0x7840150*/ InvalidEnumArgumentException(string argumentName, int invalidValue, System.Type enumClass);
            /*0x7840234*/ InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class ReadOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ReadOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.ReadOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.ReadOnlyAttribute Default;
            /*0x10*/ bool <IsReadOnly>k__BackingField;

            static /*0x78403d8*/ ReadOnlyAttribute();
            /*0x784023c*/ ReadOnlyAttribute(bool isReadOnly);
            /*0x7840264*/ bool get_IsReadOnly();
            /*0x784026c*/ bool Equals(object value);
            /*0x7840350*/ int GetHashCode();
            /*0x7840358*/ bool IsDefaultAttribute();
        }

        class AmbientValueAttribute : System.Attribute
        {
            /*0x10*/ object <Value>k__BackingField;

            /*0x7840488*/ object get_Value();
        }

        class ArrayConverter : System.ComponentModel.CollectionConverter
        {
            /*0x7840b40*/ ArrayConverter();
            /*0x7840490*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7840788*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x7840b38*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class ArrayPropertyDescriptor : System.ComponentModel.TypeConverter.SimplePropertyDescriptor
            {
                /*0x98*/ int _index;

                /*0x7840968*/ ArrayPropertyDescriptor(System.Type arrayType, System.Type elementType, int index);
                /*0x7840b50*/ object GetValue(object instance);
                /*0x7840be0*/ void SetValue(object instance, object value);
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

            static /*0x78419cc*/ AttributeCollection();
            /*0x7840cd4*/ AttributeCollection(System.Attribute[] attributes);
            /*0x7840e14*/ System.Attribute[] get_Attributes();
            /*0x7840e1c*/ int get_Count();
            /*0x7840e40*/ System.Attribute get_Item(System.Type attributeType);
            /*0x78418a4*/ bool Contains(System.Attribute attribute);
            /*0x7841328*/ System.Attribute GetDefaultAttribute(System.Type attributeType);
            /*0x7841904*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7841928*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x7841930*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x7841938*/ int System.Collections.ICollection.get_Count();
            /*0x784195c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7841960*/ void CopyTo(System.Array array, int index);

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

            /*0x7841a70*/ string get_TypeName();
            /*0x7841a78*/ string get_PropertyName();
        }

        class BaseNumberConverter : System.ComponentModel.TypeConverter
        {
            /*0x7841a80*/ BaseNumberConverter();
            /*0x7841a88*/ bool get_AllowHex();
            /*0x38148bc*/ System.Type get_TargetType();
            /*0x3814b48*/ object FromString(string value, int radix);
            /*0x3814b90*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x3814b90*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7841a90*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7841b1c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7841ef4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7842178*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        }

        class BooleanConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.ComponentModel.TypeConverter.StandardValuesCollection s_values;

            /*0x784255c*/ BooleanConverter();
            /*0x78421b0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x784223c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x78423d0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784254c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7842554*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x78426f8*/ ByteConverter();
            /*0x7842564*/ System.Type get_TargetType();
            /*0x7842594*/ object FromString(string value, int radix);
            /*0x784261c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7842654*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class CharConverter : System.ComponentModel.TypeConverter
        {
            /*0x7842998*/ CharConverter();
            /*0x7842700*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x784278c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7842880*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
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

            /*0x78429a0*/ CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element);
            /*0x7842a1c*/ System.ComponentModel.CollectionChangeAction get_Action();
            /*0x7842a24*/ object get_Element();
        }

        class CollectionChangeEventHandler : System.MulticastDelegate
        {
            /*0x7842a2c*/ CollectionChangeEventHandler(object object, nint method);
            /*0x7842b38*/ void Invoke(object sender, System.ComponentModel.CollectionChangeEventArgs e);
        }

        class CultureInfoConverter : System.ComponentModel.TypeConverter
        {
            static string DefaultInvariantCultureString = "(Default)";
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x7843d4c*/ CultureInfoConverter();
            /*0x7842b4c*/ string get_DefaultCultureString();
            /*0x7842b8c*/ string GetCultureName(System.Globalization.CultureInfo culture);
            /*0x7842bb0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7842c3c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7842cec*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x784368c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7843af4*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7843d3c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7843d44*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class CultureComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.CultureInfoConverter _converter;

                /*0x7843d0c*/ CultureComparer(System.ComponentModel.CultureInfoConverter cultureConverter);
                /*0x7843d54*/ int Compare(object item1, object item2);
            }

            class CultureInfoMapper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> s_cultureInfoNameMap;

                static /*0x7847fa0*/ CultureInfoMapper();
                static /*0x7843ec0*/ System.Collections.Generic.Dictionary<string, string> CreateMap();
                static /*0x78435ec*/ string GetCultureInfoName(string cultureInfoDisplayName);
            }
        }

        class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
        {
            /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _parent;

            /*0x7847ff8*/ CustomTypeDescriptor();
            /*0x7848000*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x78480d8*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x78481b0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x784828c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x7848370*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        class DateTimeConverter : System.ComponentModel.TypeConverter
        {
            /*0x7848bc4*/ DateTimeConverter();
            /*0x7848428*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x78484b4*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7848564*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7848860*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class DecimalConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x784928c*/ DecimalConverter();
            /*0x7848bcc*/ bool get_AllowHex();
            /*0x7848bd4*/ System.Type get_TargetType();
            /*0x7848c34*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7848ce0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x784900c*/ object FromString(string value, int radix);
            /*0x78490f8*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x78491a4*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class DefaultEventAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultEventAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x7849354*/ DefaultEventAttribute();
            /*0x7849294*/ DefaultEventAttribute(string name);
            /*0x78492c4*/ string get_Name();
            /*0x78492cc*/ bool Equals(object obj);
            /*0x784934c*/ int GetHashCode();
        }

        class DefaultPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultPropertyAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x784948c*/ DefaultPropertyAttribute();
            /*0x78493cc*/ DefaultPropertyAttribute(string name);
            /*0x78493fc*/ string get_Name();
            /*0x7849404*/ bool Equals(object obj);
            /*0x7849484*/ int GetHashCode();
        }

        class DelegatingTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
        {
            /*0x20*/ System.Type _type;

            /*0x7849504*/ DelegatingTypeDescriptionProvider(System.Type type);
            /*0x784953c*/ System.ComponentModel.TypeDescriptionProvider get_Provider();
            /*0x7849598*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x78495e8*/ System.Collections.IDictionary GetCache(object instance);
            /*0x7849610*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x7849638*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x7849660*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x7849698*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
        }

        class ToolboxItemAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ToolboxItemAttribute Default;
            static /*0x8*/ System.ComponentModel.ToolboxItemAttribute None;
            /*0x10*/ string _toolboxItemTypeName;

            static /*0x784995c*/ ToolboxItemAttribute();
            /*0x7849738*/ ToolboxItemAttribute(bool defaultType);
            /*0x78497a4*/ ToolboxItemAttribute(string toolboxItemTypeName);
            /*0x78496d0*/ bool IsDefaultAttribute();
            /*0x7849838*/ string get_ToolboxItemTypeName();
            /*0x784985c*/ bool Equals(object obj);
            /*0x7849938*/ int GetHashCode();
        }

        class DesignTimeVisibleAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignTimeVisibleAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignTimeVisibleAttribute No;
            static /*0x10*/ System.ComponentModel.DesignTimeVisibleAttribute Default;
            /*0x10*/ bool <Visible>k__BackingField;

            static /*0x7849bf4*/ DesignTimeVisibleAttribute();
            /*0x7849a24*/ DesignTimeVisibleAttribute(bool visible);
            /*0x7849a4c*/ bool get_Visible();
            /*0x7849a54*/ bool Equals(object obj);
            /*0x7849aec*/ int GetHashCode();
            /*0x7849b74*/ bool IsDefaultAttribute();
        }

        class DoubleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x7849e68*/ DoubleConverter();
            /*0x7849ca4*/ bool get_AllowHex();
            /*0x7849cac*/ System.Type get_TargetType();
            /*0x7849cdc*/ object FromString(string value, int radix);
            /*0x7849d90*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7849dc4*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class EditorAttribute : System.Attribute
        {
            /*0x10*/ string _typeId;
            /*0x18*/ string <EditorBaseTypeName>k__BackingField;
            /*0x20*/ string <EditorTypeName>k__BackingField;

            /*0x7849e70*/ EditorAttribute(string typeName, string baseTypeName);
            /*0x7849f18*/ string get_EditorBaseTypeName();
            /*0x7849f20*/ string get_EditorTypeName();
            /*0x7849f28*/ object get_TypeId();
            /*0x7849fc8*/ bool Equals(object obj);
            /*0x784a06c*/ int GetHashCode();
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

            static /*0x784b004*/ EventDescriptorCollection();
            /*0x784a074*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events);
            /*0x784a14c*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly);
            /*0x784a170*/ int get_Count();
            /*0x784a178*/ void set_Count(int value);
            /*0x784a180*/ System.ComponentModel.EventDescriptor get_Item(int index);
            /*0x784a2c0*/ int Add(System.ComponentModel.EventDescriptor value);
            /*0x784a4b8*/ void Clear();
            /*0x784a504*/ bool Contains(System.ComponentModel.EventDescriptor value);
            /*0x784a57c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x784a204*/ void EnsureEventsOwned();
            /*0x784a390*/ void EnsureSize(int sizeNeeded);
            /*0x784a51c*/ int IndexOf(System.ComponentModel.EventDescriptor value);
            /*0x784a838*/ void Insert(int index, System.ComponentModel.EventDescriptor value);
            /*0x784a928*/ void Remove(System.ComponentModel.EventDescriptor value);
            /*0x784a990*/ void RemoveAt(int index);
            /*0x784aa4c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x784a5b8*/ void InternalSort(string[] names);
            /*0x784ab2c*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x784aba4*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x784abac*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x784abb4*/ int System.Collections.ICollection.get_Count();
            /*0x784abbc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x784abc0*/ object System.Collections.IList.get_Item(int index);
            /*0x784abd0*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x784ad3c*/ int System.Collections.IList.Add(object value);
            /*0x784adc0*/ bool System.Collections.IList.Contains(object value);
            /*0x784ae50*/ void System.Collections.IList.Clear();
            /*0x784ae54*/ int System.Collections.IList.IndexOf(object value);
            /*0x784aed8*/ void System.Collections.IList.Insert(int index, object value);
            /*0x784af6c*/ void System.Collections.IList.Remove(object value);
            /*0x784aff0*/ void System.Collections.IList.RemoveAt(int index);
            /*0x784aff4*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x784affc*/ bool System.Collections.IList.get_IsFixedSize();

            class ArraySubsetEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Array _array;
                /*0x18*/ int _total;
                /*0x1c*/ int _current;

                /*0x784aaec*/ ArraySubsetEnumerator(System.Array array, int count);
                /*0x784b074*/ bool MoveNext();
                /*0x784b098*/ void Reset();
                /*0x784b0a4*/ object get_Current();
            }
        }

        class ExpandableObjectConverter : System.ComponentModel.TypeConverter
        {
            /*0x784b100*/ ExpandableObjectConverter();
            /*0x784b108*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x784b170*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ExtendedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.ComponentModel.ReflectPropertyDescriptor _extenderInfo;
            /*0x90*/ System.ComponentModel.IExtenderProvider _provider;

            /*0x784b178*/ ExtendedPropertyDescriptor(System.ComponentModel.ReflectPropertyDescriptor extenderInfo, System.Type receiverType, System.ComponentModel.IExtenderProvider provider, System.Attribute[] attributes);
            /*0x784b484*/ bool CanResetValue(object comp);
            /*0x784b72c*/ System.Type get_ComponentType();
            /*0x784b750*/ bool get_IsReadOnly();
            /*0x784b834*/ System.Type get_PropertyType();
            /*0x784b868*/ string get_DisplayName();
            /*0x784bc3c*/ object GetValue(object comp);
            /*0x784bd9c*/ void ResetValue(object comp);
            /*0x784c2d0*/ void SetValue(object component, object value);
            /*0x784c770*/ bool ShouldSerializeValue(object comp);
        }

        class ExtenderProvidedPropertyAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.PropertyDescriptor <ExtenderProperty>k__BackingField;
            /*0x18*/ System.ComponentModel.IExtenderProvider <Provider>k__BackingField;
            /*0x20*/ System.Type <ReceiverType>k__BackingField;

            static /*0x784b3e4*/ System.ComponentModel.ExtenderProvidedPropertyAttribute Create(System.ComponentModel.PropertyDescriptor extenderProperty, System.Type receiverType, System.ComponentModel.IExtenderProvider provider);
            /*0x784cbd0*/ ExtenderProvidedPropertyAttribute();
            /*0x784cbd8*/ System.ComponentModel.PropertyDescriptor get_ExtenderProperty();
            /*0x784cbe0*/ void set_ExtenderProperty(System.ComponentModel.PropertyDescriptor value);
            /*0x784cbe8*/ System.ComponentModel.IExtenderProvider get_Provider();
            /*0x784cbf0*/ void set_Provider(System.ComponentModel.IExtenderProvider value);
            /*0x784cbf8*/ System.Type get_ReceiverType();
            /*0x784cc00*/ void set_ReceiverType(System.Type value);
            /*0x784cc08*/ bool Equals(object obj);
            /*0x784ccdc*/ int GetHashCode();
            /*0x784cce4*/ bool IsDefaultAttribute();
        }

        class GuidConverter : System.ComponentModel.TypeConverter
        {
            /*0x784d244*/ GuidConverter();
            /*0x784cd1c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x784cda8*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x784ce58*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x784cf2c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        interface IBindingList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
        }

        interface ICustomTypeDescriptor
        {
            /*0x38148bc*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x38148bc*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x38148bc*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x3814a3c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x3814a3c*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        interface IExtenderProvider
        {
            /*0x38141c4*/ bool CanExtend(object extendee);
        }

        interface ITypeDescriptorContext : System.IServiceProvider
        {
            /*0x38148bc*/ System.ComponentModel.IContainer get_Container();
        }

        class Int16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x784d3e0*/ Int16Converter();
            /*0x784d24c*/ System.Type get_TargetType();
            /*0x784d27c*/ object FromString(string value, int radix);
            /*0x784d304*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x784d33c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x784d57c*/ Int32Converter();
            /*0x784d3e8*/ System.Type get_TargetType();
            /*0x784d418*/ object FromString(string value, int radix);
            /*0x784d4a0*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x784d4d8*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x784d718*/ Int64Converter();
            /*0x784d584*/ System.Type get_TargetType();
            /*0x784d5b4*/ object FromString(string value, int radix);
            /*0x784d63c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x784d674*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class ListBindableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ListBindableAttribute Yes;
            static /*0x8*/ System.ComponentModel.ListBindableAttribute No;
            static /*0x10*/ System.ComponentModel.ListBindableAttribute Default;
            /*0x10*/ bool _isDefault;
            /*0x11*/ bool <ListBindable>k__BackingField;

            static /*0x784d874*/ ListBindableAttribute();
            /*0x784d720*/ ListBindableAttribute(bool listBindable);
            /*0x784d748*/ bool get_ListBindable();
            /*0x784d750*/ bool Equals(object obj);
            /*0x784d7e8*/ int GetHashCode();
            /*0x784d7f0*/ bool IsDefaultAttribute();
        }

        class ListChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.ComponentModel.ListChangedType <ListChangedType>k__BackingField;
            /*0x14*/ int <NewIndex>k__BackingField;
            /*0x18*/ int <OldIndex>k__BackingField;
            /*0x20*/ System.ComponentModel.PropertyDescriptor <PropertyDescriptor>k__BackingField;

            /*0x784d924*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex);
            /*0x784d9ac*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x784d9e8*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x784d92c*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex);
            /*0x784da64*/ System.ComponentModel.ListChangedType get_ListChangedType();
            /*0x784da6c*/ int get_NewIndex();
            /*0x784da74*/ int get_OldIndex();
        }

        class ListChangedEventHandler : System.MulticastDelegate
        {
            /*0x784da7c*/ ListChangedEventHandler(object object, nint method);
            /*0x784db88*/ void Invoke(object sender, System.ComponentModel.ListChangedEventArgs e);
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

            static /*0x784e128*/ MarshalByValueComponent();
            /*0x784db9c*/ MarshalByValueComponent();
            /*0x784dba4*/ void Finalize();
            /*0x784dc44*/ System.ComponentModel.ISite get_Site();
            /*0x784dc4c*/ void Dispose();
            /*0x784dcb8*/ void Dispose(bool disposing);
            /*0x784df44*/ object GetService(System.Type service);
            /*0x784dff8*/ string ToString();
        }

        class MultilineStringConverter : System.ComponentModel.TypeConverter
        {
            /*0x784e304*/ MultilineStringConverter();
            /*0x784e1a4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x784e2f4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x784e2fc*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class NullableConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type <NullableType>k__BackingField;
            /*0x18*/ System.Type <UnderlyingType>k__BackingField;
            /*0x20*/ System.ComponentModel.TypeConverter <UnderlyingTypeConverter>k__BackingField;

            /*0x784e30c*/ NullableConverter(System.Type type);
            /*0x784e444*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x784e4e8*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x784e5f0*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x784e694*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x784e840*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x784e864*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784e888*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x784e8ac*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784e8d0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784ec9c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784ecc4*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x784ecec*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x784ed20*/ System.Type get_NullableType();
            /*0x784ed28*/ System.Type get_UnderlyingType();
            /*0x784ed30*/ System.ComponentModel.TypeConverter get_UnderlyingTypeConverter();
        }

        class PropertyDescriptor : System.ComponentModel.MemberDescriptor
        {
            /*0x60*/ System.ComponentModel.TypeConverter _converter;
            /*0x68*/ System.Collections.Hashtable _valueChangedHandlers;
            /*0x70*/ object[] _editors;
            /*0x78*/ System.Type[] _editorTypes;
            /*0x80*/ int _editorCount;

            /*0x784ed38*/ PropertyDescriptor(string name, System.Attribute[] attrs);
            /*0x784b3e0*/ PropertyDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs);
            /*0x38148bc*/ System.Type get_ComponentType();
            /*0x784f38c*/ System.ComponentModel.TypeConverter get_Converter();
            /*0x3813ffc*/ bool get_IsReadOnly();
            /*0x38148bc*/ System.Type get_PropertyType();
            /*0x38141c4*/ bool CanResetValue(object component);
            /*0x784f9dc*/ bool Equals(object obj);
            /*0x784f7e4*/ object CreateInstance(System.Type type);
            /*0x784fbd0*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x784fd18*/ int GetHashCode();
            /*0x784fd6c*/ object GetInvocationTarget(System.Type type, object instance);
            /*0x784f5f4*/ System.Type GetTypeFromName(string typeName);
            /*0x3814a3c*/ object GetValue(object component);
            /*0x784ff44*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x3816710*/ void ResetValue(object component);
            /*0x3816810*/ void SetValue(object component, object value);
            /*0x38141c4*/ bool ShouldSerializeValue(object component);
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

            static /*0x7851e20*/ PropertyDescriptorCollection();
            /*0x7840a20*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties);
            /*0x784fff4*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly);
            /*0x7850018*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, int propCount, string[] namedSort, System.Collections.IComparer comparer);
            /*0x7850164*/ int get_Count();
            /*0x785016c*/ void set_Count(int value);
            /*0x7850174*/ System.ComponentModel.PropertyDescriptor get_Item(int index);
            /*0x78502b4*/ System.ComponentModel.PropertyDescriptor get_Item(string name);
            /*0x78502c8*/ int Add(System.ComponentModel.PropertyDescriptor value);
            /*0x78504c0*/ void Clear();
            /*0x7850514*/ bool Contains(System.ComponentModel.PropertyDescriptor value);
            /*0x785058c*/ void CopyTo(System.Array array, int index);
            /*0x78501f8*/ void EnsurePropsOwned();
            /*0x7850398*/ void EnsureSize(int sizeNeeded);
            /*0x7850848*/ System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase);
            /*0x785052c*/ int IndexOf(System.ComponentModel.PropertyDescriptor value);
            /*0x7850d78*/ void Insert(int index, System.ComponentModel.PropertyDescriptor value);
            /*0x7850e68*/ void Remove(System.ComponentModel.PropertyDescriptor value);
            /*0x7850ed0*/ void RemoveAt(int index);
            /*0x7850f8c*/ System.ComponentModel.PropertyDescriptorCollection Sort(string[] names);
            /*0x78505c8*/ void InternalSort(string[] names);
            /*0x7851008*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x7851080*/ System.Collections.IEnumerator GetEnumerator();
            /*0x785111c*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x7851124*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x785112c*/ int System.Collections.ICollection.get_Count();
            /*0x7851134*/ void System.Collections.IList.Clear();
            /*0x7851138*/ void System.Collections.IDictionary.Clear();
            /*0x785113c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x785114c*/ void System.Collections.IList.RemoveAt(int index);
            /*0x7851150*/ void System.Collections.IDictionary.Add(object key, object value);
            /*0x7851214*/ bool System.Collections.IDictionary.Contains(object key);
            /*0x785125c*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
            /*0x7851304*/ bool System.Collections.IDictionary.get_IsFixedSize();
            /*0x785130c*/ bool System.Collections.IDictionary.get_IsReadOnly();
            /*0x7851314*/ object System.Collections.IDictionary.get_Item(object key);
            /*0x7851348*/ void System.Collections.IDictionary.set_Item(object key, object value);
            /*0x78516e0*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
            /*0x78517c0*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
            /*0x7851898*/ void System.Collections.IDictionary.Remove(object key);
            /*0x7851980*/ int System.Collections.IList.Add(object value);
            /*0x7851a04*/ bool System.Collections.IList.Contains(object value);
            /*0x7851a94*/ int System.Collections.IList.IndexOf(object value);
            /*0x7851b18*/ void System.Collections.IList.Insert(int index, object value);
            /*0x7851bac*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x7851bb4*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x7851bbc*/ void System.Collections.IList.Remove(object value);
            /*0x7851c40*/ object System.Collections.IList.get_Item(int index);
            /*0x7851c50*/ void System.Collections.IList.set_Item(int index, object value);

            class PropertyDescriptorEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
            {
                /*0x10*/ System.ComponentModel.PropertyDescriptorCollection _owner;
                /*0x18*/ int _index;

                /*0x78512cc*/ PropertyDescriptorEnumerator(System.ComponentModel.PropertyDescriptorCollection owner);
                /*0x7851e90*/ object get_Current();
                /*0x7851ef4*/ System.Collections.DictionaryEntry get_Entry();
                /*0x7851f5c*/ object get_Key();
                /*0x7851f98*/ object get_Value();
                /*0x7851fd4*/ bool MoveNext();
                /*0x7852010*/ void Reset();
            }
        }

        class ProvidePropertyAttribute : System.Attribute
        {
            /*0x10*/ string <PropertyName>k__BackingField;
            /*0x18*/ string <ReceiverTypeName>k__BackingField;

            /*0x785201c*/ string get_PropertyName();
            /*0x7852024*/ string get_ReceiverTypeName();
        }

        class ReferenceConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ string s_none;
            /*0x10*/ System.Type _type;

            static /*0x7853078*/ ReferenceConverter();
            /*0x785202c*/ ReferenceConverter(System.Type type);
            /*0x785205c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x78520ec*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7852414*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7852834*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7853060*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7853068*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7853070*/ bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value);

            class ReferenceComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.ReferenceConverter _converter;

                /*0x7853030*/ ReferenceComparer(System.ComponentModel.ReferenceConverter converter);
                /*0x78530e4*/ int Compare(object item1, object item2);
            }
        }

        class RefreshEventArgs : System.EventArgs
        {
            /*0x10*/ System.Type <TypeChanged>k__BackingField;

            /*0x785319c*/ RefreshEventArgs(System.Type typeChanged);
        }

        class RefreshEventHandler : System.MulticastDelegate
        {
            /*0x7853210*/ RefreshEventHandler(object object, nint method);
            /*0x7853318*/ void Invoke(System.ComponentModel.RefreshEventArgs e);
        }

        class SByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x78534c0*/ SByteConverter();
            /*0x785332c*/ System.Type get_TargetType();
            /*0x785335c*/ object FromString(string value, int radix);
            /*0x78533e4*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x785341c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class SingleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x785368c*/ SingleConverter();
            /*0x78534c8*/ bool get_AllowHex();
            /*0x78534d0*/ System.Type get_TargetType();
            /*0x7853500*/ object FromString(string value, int radix);
            /*0x78535b4*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x78535e8*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class StringConverter : System.ComponentModel.TypeConverter
        {
            /*0x7853754*/ StringConverter();
            /*0x7853694*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7853720*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        class TimeSpanConverter : System.ComponentModel.TypeConverter
        {
            /*0x7853d7c*/ TimeSpanConverter();
            /*0x785375c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x78537e8*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7853898*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7853a78*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class TypeConverterAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.TypeConverterAttribute Default;
            /*0x10*/ string <ConverterTypeName>k__BackingField;

            static /*0x7853edc*/ TypeConverterAttribute();
            /*0x7853d84*/ TypeConverterAttribute();
            /*0x7853db8*/ TypeConverterAttribute(System.Type type);
            /*0x7853e04*/ TypeConverterAttribute(string typeName);
            /*0x7853e34*/ string get_ConverterTypeName();
            /*0x7853e3c*/ bool Equals(object obj);
            /*0x7853ebc*/ int GetHashCode();
        }

        class TypeDescriptionProvider
        {
            /*0x10*/ System.ComponentModel.TypeDescriptionProvider _parent;
            /*0x18*/ System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

            /*0x7849534*/ TypeDescriptionProvider();
            /*0x7853f64*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x7854024*/ System.Collections.IDictionary GetCache(object instance);
            /*0x785403c*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x78540d8*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x78541d8*/ System.Type GetReflectionType(System.Type objectType);
            /*0x78541e8*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x7854204*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType);
            /*0x7854214*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance);
            /*0x785429c*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

            class EmptyCustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor
            {
                /*0x78540d0*/ EmptyCustomTypeDescriptor();
            }
        }

        class TypeDescriptionProviderAttribute : System.Attribute
        {
            /*0x10*/ string <TypeName>k__BackingField;

            /*0x7854344*/ TypeDescriptionProviderAttribute(string typeName);
            /*0x78543c0*/ string get_TypeName();
        }

        class TypeListConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type[] _types;
            /*0x18*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x78543c8*/ TypeListConverter(System.Type[] types);
            /*0x78543f8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7854484*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x7854534*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7854624*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x78547b8*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7854884*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x785488c*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class UInt16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x7854a28*/ UInt16Converter();
            /*0x7854894*/ System.Type get_TargetType();
            /*0x78548c4*/ object FromString(string value, int radix);
            /*0x785494c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7854984*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x7854bc4*/ UInt32Converter();
            /*0x7854a30*/ System.Type get_TargetType();
            /*0x7854a60*/ object FromString(string value, int radix);
            /*0x7854ae8*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7854b20*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x7854d60*/ UInt64Converter();
            /*0x7854bcc*/ System.Type get_TargetType();
            /*0x7854bfc*/ object FromString(string value, int radix);
            /*0x7854c84*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x7854cbc*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        interface IChangeTracking
        {
            /*0x3813ffc*/ bool get_IsChanged();
            /*0x38159dc*/ void AcceptChanges();
        }

        interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking
        {
            /*0x38159dc*/ void RejectChanges();
        }

        interface INotifyPropertyChanged
        {
            /*0x3816710*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            /*0x3816710*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
        }

        class PropertyChangedEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x7854d68*/ PropertyChangedEventArgs(string propertyName);
        }

        class PropertyChangedEventHandler : System.MulticastDelegate
        {
            /*0x7854ddc*/ PropertyChangedEventHandler(object object, nint method);
            /*0x7854ee8*/ void Invoke(object sender, System.ComponentModel.PropertyChangedEventArgs e);
        }

        class PropertyChangingEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x7854efc*/ PropertyChangingEventArgs(string propertyName);
        }

        class PropertyChangingEventHandler : System.MulticastDelegate
        {
            /*0x7854f70*/ PropertyChangingEventHandler(object object, nint method);
            /*0x785507c*/ void Invoke(object sender, System.ComponentModel.PropertyChangingEventArgs e);
        }

        class CategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.CategoryAttribute defAttr;
            /*0x10*/ bool localized;
            /*0x18*/ string categoryValue;

            static /*0x7855090*/ System.ComponentModel.CategoryAttribute get_Default();
            /*0x7855124*/ CategoryAttribute();
            /*0x7855188*/ CategoryAttribute(string category);
            /*0x78551c0*/ string get_Category();
            /*0x7855218*/ bool Equals(object obj);
            /*0x7855308*/ int GetHashCode();
            /*0x7855328*/ string GetLocalizedString(string value);
            /*0x78556a4*/ bool IsDefaultAttribute();
        }

        class CollectionConverter : System.ComponentModel.TypeConverter
        {
            /*0x7840b48*/ CollectionConverter();
            /*0x7840624*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x78556d8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x78556e0*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class Component : System.MarshalByRefObject, System.ComponentModel.IComponent, System.IDisposable
        {
            static /*0x0*/ object EventDisposed;
            /*0x18*/ System.ComponentModel.ISite site;
            /*0x20*/ System.ComponentModel.EventHandlerList events;

            static /*0x7855da0*/ Component();
            /*0x7855d98*/ Component();
            /*0x78556e8*/ void Finalize();
            /*0x7855788*/ bool get_CanRaiseEvents();
            /*0x7840118*/ bool get_CanRaiseEventsInternal();
            /*0x7855790*/ System.ComponentModel.ISite get_Site();
            /*0x7855798*/ void Dispose();
            /*0x7855804*/ void Dispose(bool disposing);
            /*0x7855b04*/ object GetService(System.Type service);
            /*0x7855bb8*/ bool get_DesignMode();
            /*0x7855c68*/ string ToString();
        }

        class ComponentConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x7855e1c*/ ComponentConverter(System.Type type);
            /*0x7855e90*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x7855ef8*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DateTimeOffsetConverter : System.ComponentModel.TypeConverter
        {
            /*0x7856f84*/ DateTimeOffsetConverter();
            /*0x7855f00*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7855f8c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x785603c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x785639c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class EnumConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;
            /*0x18*/ System.Type type;

            /*0x7856f8c*/ EnumConverter(System.Type type);
            /*0x7856fbc*/ System.Type get_EnumType();
            /*0x7856fc4*/ System.ComponentModel.TypeConverter.StandardValuesCollection get_Values();
            /*0x7856fcc*/ void set_Values(System.ComponentModel.TypeConverter.StandardValuesCollection value);
            /*0x7856fd4*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x78570bc*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x78571b4*/ System.Collections.IComparer get_Comparer();
            /*0x785720c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x78576e0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x785847c*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7858850*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x78588e4*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x78588ec*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
        }

        interface IComponent : System.IDisposable
        {
            /*0x38148bc*/ System.ComponentModel.ISite get_Site();
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

            static /*0x78596b0*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType);
            static /*0x78596b8*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly);
            static /*0x784bb40*/ System.ComponentModel.ISite GetSite(object component);
            /*0x784ed3c*/ MemberDescriptor(string name, System.Attribute[] attributes);
            /*0x784ef14*/ MemberDescriptor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes);
            /*0x7858930*/ System.Attribute[] get_AttributeArray();
            /*0x7859188*/ void set_AttributeArray(System.Attribute[] value);
            /*0x7859280*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x7859380*/ string get_Name();
            /*0x78593d0*/ int get_NameHashCode();
            /*0x784ba30*/ string get_DisplayName();
            /*0x7858950*/ void CheckAttributesValid();
            /*0x78593d8*/ System.ComponentModel.AttributeCollection CreateAttributeCollection();
            /*0x7859448*/ bool Equals(object obj);
            /*0x784fc24*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x7858a18*/ void FilterAttributesIfNeeded();
            /*0x785975c*/ int GetHashCode();
            /*0x784fe4c*/ object GetInvocationTarget(System.Type type, object instance);
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

            static /*0x785ce1c*/ ReflectPropertyDescriptor();
            /*0x7859764*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Attribute[] attributes);
            /*0x7859a44*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Reflection.PropertyInfo propInfo, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x7859b8c*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Type receiverType, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x7859c7c*/ object get_AmbientValue();
            /*0x7859df0*/ System.Type get_ComponentType();
            /*0x7859df8*/ object get_DefaultValue();
            /*0x785a08c*/ System.Reflection.MethodInfo get_GetMethodValue();
            /*0x785a4f0*/ bool get_IsExtender();
            /*0x785a528*/ bool get_IsReadOnly();
            /*0x785ab54*/ System.Type get_PropertyType();
            /*0x785ab5c*/ System.Reflection.MethodInfo get_ResetMethodValue();
            /*0x785a61c*/ System.Reflection.MethodInfo get_SetMethodValue();
            /*0x785ad50*/ System.Reflection.MethodInfo get_ShouldSerializeMethodValue();
            /*0x784b4a8*/ bool ExtenderCanResetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x785af44*/ System.Type ExtenderGetReceiverType();
            /*0x784b858*/ System.Type ExtenderGetType(System.ComponentModel.IExtenderProvider provider);
            /*0x784bc60*/ object ExtenderGetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x784bdc0*/ void ExtenderResetValue(System.ComponentModel.IExtenderProvider provider, object component, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x784c2f8*/ void ExtenderSetValue(System.ComponentModel.IExtenderProvider provider, object component, object value, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x784c794*/ bool ExtenderShouldSerializeValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x785af4c*/ bool CanResetValue(object component);
            /*0x785b1b4*/ void FillAttributes(System.Collections.IList attributes);
            /*0x785bc64*/ object GetValue(object component);
            /*0x785c024*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x785c0c8*/ void ResetValue(object component);
            /*0x785c520*/ void SetValue(object component, object value);
            /*0x785cafc*/ bool ShouldSerializeValue(object component);
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

            static /*0x78637d8*/ ReflectTypeDescriptionProvider();
            static /*0x785d07c*/ System.Collections.Hashtable get_IntrinsicTypeConverters();
            static /*0x785dc2c*/ object CreateInstance(System.Type objectType, System.Type callingType);
            static /*0x7860768*/ System.ComponentModel.IExtenderProvider[] GetExtenders(System.Collections.ICollection components, object instance, System.Collections.IDictionary cache);
            static /*0x7861cf8*/ System.Type GetTypeFromName(string typeName);
            static /*0x7861e48*/ System.Attribute[] ReflectGetAttributes(System.Type type);
            static /*0x7862280*/ System.Attribute[] ReflectGetAttributes(System.Reflection.MemberInfo member);
            static /*0x785f394*/ System.ComponentModel.PropertyDescriptor[] ReflectGetExtendedProperties(System.ComponentModel.IExtenderProvider provider);
            static /*0x7862804*/ System.ComponentModel.PropertyDescriptor[] ReflectGetProperties(System.Type type);
            static /*0x7862ec0*/ object SearchIntrinsicTable(System.Collections.Hashtable table, System.Type callingType);
            /*0x785d074*/ ReflectTypeDescriptionProvider();
            /*0x785da48*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x785dd34*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type type);
            /*0x785e508*/ System.Collections.IDictionary GetCache(object instance);
            /*0x785e860*/ System.ComponentModel.TypeConverter GetConverter(System.Type type, object instance);
            /*0x785ed54*/ System.ComponentModel.AttributeCollection GetExtendedAttributes(object instance);
            /*0x785edac*/ System.ComponentModel.TypeConverter GetExtendedConverter(object instance);
            /*0x785ede8*/ System.ComponentModel.PropertyDescriptorCollection GetExtendedProperties(object instance);
            /*0x78602ec*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x7861284*/ object GetExtendedPropertyOwner(object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x7861314*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x786131c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type type);
            /*0x78612b0*/ object GetPropertyOwner(System.Type type, object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x7861cb8*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x785dd50*/ System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(System.Type type, bool createIfNeeded);
            /*0x7861cf0*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
            /*0x7861dfc*/ bool IsPopulated(System.Type type);
            /*0x7862e30*/ void Refresh(System.Type type);

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

                /*0x7861cc0*/ ReflectedTypeData(System.Type type);
                /*0x7861e2c*/ bool get_IsPopulated();
                /*0x785dfd8*/ System.ComponentModel.AttributeCollection GetAttributes();
                /*0x785e884*/ System.ComponentModel.TypeConverter GetConverter(object instance);
                /*0x7861338*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
                /*0x7863dc8*/ System.Type GetTypeFromName(string typeName);
                /*0x7862e50*/ void Refresh();
            }
        }

        class TypeConverter
        {
            static string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
            static /*0x0*/ bool useCompatibleTypeConversion;

            static /*0x7863f68*/ bool get_UseCompatibleTypeConversion();
            /*0x78651bc*/ TypeConverter();
            /*0x7863fb8*/ bool CanConvertFrom(System.Type sourceType);
            /*0x7863fcc*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x7864040*/ bool CanConvertTo(System.Type destinationType);
            /*0x7864054*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x78640a0*/ object ConvertFrom(object value);
            /*0x786411c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7864620*/ object ConvertFromInvariantString(string text);
            /*0x78646a8*/ object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x7864728*/ object ConvertFromString(string text);
            /*0x7864740*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x786469c*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text);
            /*0x78647c0*/ object ConvertTo(object value, System.Type destinationType);
            /*0x78647dc*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x7864b58*/ string ConvertToInvariantString(object value);
            /*0x7864c64*/ string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x7864cdc*/ string ConvertToString(object value);
            /*0x7864da8*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x7864bcc*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x7864e80*/ object CreateInstance(System.Collections.IDictionary propertyValues);
            /*0x7864e94*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x78644f4*/ System.Exception GetConvertFromException(object value);
            /*0x78649e0*/ System.Exception GetConvertToException(object value, System.Type destinationType);
            /*0x7864e9c*/ bool GetCreateInstanceSupported();
            /*0x7864eac*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7864eb4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object value);
            /*0x7864ec0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x7864fbc*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x7864fc4*/ bool GetPropertiesSupported();
            /*0x7864fd4*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7864fdc*/ System.Collections.ICollection GetStandardValues();
            /*0x7864fec*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7864ff4*/ bool GetStandardValuesExclusive();
            /*0x7865008*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x7865010*/ bool GetStandardValuesSupported();
            /*0x7865024*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x786502c*/ bool IsValid(object value);
            /*0x7865044*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x7865184*/ System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, string[] names);

            class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x88*/ System.Type componentType;
                /*0x90*/ System.Type propertyType;

                /*0x78651c4*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType);
                /*0x7865240*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes);
                /*0x786528c*/ System.Type get_ComponentType();
                /*0x7865294*/ bool get_IsReadOnly();
                /*0x7865318*/ System.Type get_PropertyType();
                /*0x7865320*/ bool CanResetValue(object component);
                /*0x7865458*/ void ResetValue(object component);
                /*0x7865578*/ bool ShouldSerializeValue(object component);
            }

            class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ICollection values;
                /*0x18*/ System.Array valueArray;

                /*0x7865580*/ StandardValuesCollection(System.Collections.ICollection values);
                /*0x7865638*/ int get_Count();
                /*0x78656f4*/ object get_Item(int index);
                /*0x78658f4*/ void CopyTo(System.Array array, int index);
                /*0x78659ac*/ System.Collections.IEnumerator GetEnumerator();
                /*0x7865a4c*/ int System.Collections.ICollection.get_Count();
                /*0x7865a50*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x7865a58*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x7865a60*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x7865a64*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x786c86c*/ TypeDescriptor();
            static /*0x7865a68*/ System.Type get_ComObjectType();
            static /*0x7865ac8*/ System.Type get_InterfaceType();
            static /*0x7865b28*/ int get_MetadataVersion();
            static /*0x7865b80*/ void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type);
            static /*0x78668f0*/ void CheckDefaultProvider(System.Type type);
            static /*0x7866ef4*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            static /*0x78671fc*/ System.Collections.ArrayList FilterMembers(System.Collections.IList members, System.Attribute[] attributes);
            static /*0x7861628*/ object GetAssociation(System.Type type, object primary);
            static /*0x78626b8*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType);
            static /*0x7863d70*/ System.ComponentModel.AttributeCollection GetAttributes(object component);
            static /*0x78676b4*/ System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc);
            static /*0x785f328*/ System.Collections.IDictionary GetCache(object instance);
            static /*0x786aeb4*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x78675e4*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Type type, string typeName);
            static /*0x7867ac8*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc);
            static /*0x7867cd0*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedDescriptor(object component);
            static /*0x786afe0*/ string GetExtenderCollisionSuffix(System.ComponentModel.MemberDescriptor member);
            static /*0x786b2e4*/ System.Type GetNodeForBaseType(System.Type searchType);
            static /*0x786b3ac*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component);
            static /*0x786b404*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc);
            static /*0x786bac8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
            static /*0x786bb30*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc);
            static /*0x786b470*/ System.ComponentModel.PropertyDescriptorCollection GetPropertiesImpl(object component, System.Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes);
            static /*0x786c1f8*/ System.ComponentModel.TypeDescriptionProvider GetProviderRecursive(System.Type type);
            static /*0x786c250*/ System.Type GetReflectionType(System.Type type);
            static /*0x78671a4*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type);
            static /*0x7865e04*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type, bool createDelegator);
            static /*0x786ae5c*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance);
            static /*0x786c32c*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator);
            static /*0x786bba0*/ System.Collections.ICollection PipelineAttributeFilter(int pipelineType, System.Collections.ICollection members, System.Attribute[] filter, object instance, System.Collections.IDictionary cache);
            static /*0x7868ecc*/ System.Collections.ICollection PipelineFilter(int pipelineType, System.Collections.ICollection members, object instance, System.Collections.IDictionary cache);
            static /*0x786a748*/ System.Collections.ICollection PipelineInitialize(int pipelineType, System.Collections.ICollection members, System.Collections.IDictionary cache);
            static /*0x7867d88*/ System.Collections.ICollection PipelineMerge(int pipelineType, System.Collections.ICollection primary, System.Collections.ICollection secondary, object instance, System.Collections.IDictionary cache);
            static /*0x786c6ec*/ void RaiseRefresh(System.Type type);
            static /*0x786631c*/ void Refresh(System.Type type);
            static /*0x7867554*/ bool ShouldHideMember(System.ComponentModel.MemberDescriptor member, System.Attribute attribute);
            static /*0x786c798*/ void SortDescriptorArray(System.Collections.IList infos);

            class AttributeFilterCacheItem
            {
                /*0x10*/ System.Attribute[] _filter;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x786c528*/ AttributeFilterCacheItem(System.Attribute[] filter, System.Collections.ICollection filteredMembers);
                /*0x786c49c*/ bool IsValid(System.Attribute[] filter);
            }

            class FilterCacheItem
            {
                /*0x10*/ System.ComponentModel.Design.ITypeDescriptorFilterService _filterService;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x786c6a8*/ FilterCacheItem(System.ComponentModel.Design.ITypeDescriptorFilterService filterService, System.Collections.ICollection filteredMembers);
                /*0x786c56c*/ bool IsValid(System.ComponentModel.Design.ITypeDescriptorFilterService filterService);
            }

            interface IUnimplemented
            {
            }

            class MemberDescriptorComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.ComponentModel.TypeDescriptor.MemberDescriptorComparer Instance;

                static /*0x786cd60*/ MemberDescriptorComparer();
                /*0x786cd58*/ MemberDescriptorComparer();
                /*0x786cc3c*/ int Compare(object left, object right);
            }

            class MergedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _primary;
                /*0x18*/ System.ComponentModel.ICustomTypeDescriptor _secondary;

                /*0x786af9c*/ MergedTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor primary, System.ComponentModel.ICustomTypeDescriptor secondary);
                /*0x786cdc8*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x786ced8*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x786cff0*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x786d108*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x786d238*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
            }

            class TypeDescriptionNode : System.ComponentModel.TypeDescriptionProvider
            {
                /*0x20*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode Next;
                /*0x28*/ System.ComponentModel.TypeDescriptionProvider Provider;

                /*0x78662ec*/ TypeDescriptionNode(System.ComponentModel.TypeDescriptionProvider provider);
                /*0x786d368*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
                /*0x786d4bc*/ System.Collections.IDictionary GetCache(object instance);
                /*0x786d528*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
                /*0x786d634*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
                /*0x786d6a0*/ System.Type GetReflectionType(System.Type objectType, object instance);
                /*0x786d754*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

                struct DefaultExtendedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ object _instance;

                    /*0x786d604*/ DefaultExtendedTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, object instance);
                    /*0x786d8f8*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x786dbcc*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x786de6c*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x786e10c*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x786e3b4*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                }

                struct DefaultTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ System.Type _objectType;
                    /*0x20*/ object _instance;

                    /*0x786d8b4*/ DefaultTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Type objectType, object instance);
                    /*0x786e5d4*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x786e870*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x786eb10*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x786edb0*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x786f058*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
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

            static /*0x786f320*/ string GetErrorMessage(int error);
            /*0x786f274*/ Win32Exception();
            /*0x786f2e8*/ Win32Exception(int error);
            /*0x786fc08*/ Win32Exception(int error, string message);
            /*0x786fc34*/ Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x786fcbc*/ int get_NativeErrorCode();
            /*0x786fcc4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

            static /*0x786fe9c*/ RefreshPropertiesAttribute();
            /*0x786fd8c*/ RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh);
            /*0x786fdb4*/ System.ComponentModel.RefreshProperties get_RefreshProperties();
            /*0x786fdbc*/ bool Equals(object value);
            /*0x786fe2c*/ int GetHashCode();
            /*0x786fe34*/ bool IsDefaultAttribute();
        }

        class WeakHashtable : System.Collections.Hashtable
        {
            static /*0x0*/ System.Collections.IEqualityComparer _comparer;

            static /*0x786ff78*/ WeakHashtable();
            /*0x786cbd8*/ WeakHashtable();
            /*0x786ff68*/ void Clear();
            /*0x786ff70*/ void Remove(object key);

            class WeakKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x786fff4*/ WeakKeyComparer();
                /*0x786fffc*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
                /*0x7870158*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
            }
        }

        namespace Design
        {
            class CheckoutException : System.Runtime.InteropServices.ExternalException
            {
                static /*0x0*/ System.ComponentModel.Design.CheckoutException Canceled;

                static /*0x7870194*/ CheckoutException();
                /*0x787017c*/ CheckoutException();
                /*0x7870184*/ CheckoutException(string message, int errorCode);
                /*0x787018c*/ CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            interface IComponentChangeService
            {
                /*0x3816958*/ void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
                /*0x3816810*/ void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
            }

            interface IDesigner : System.IDisposable
            {
            }

            interface IDesignerHost : System.IServiceProvider
            {
                /*0x38148bc*/ System.ComponentModel.IComponent get_RootComponent();
                /*0x3814a3c*/ System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
            }

            interface IDictionaryService
            {
                /*0x3814a3c*/ object GetValue(object key);
                /*0x3816810*/ void SetValue(object key, object value);
            }

            interface IExtenderListService
            {
                /*0x38148bc*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
            }

            interface IReferenceService
            {
                /*0x3814a3c*/ object GetReference(string name);
                /*0x3814a3c*/ string GetName(object reference);
                /*0x3814a3c*/ object[] GetReferences(System.Type baseType);
            }

            interface ITypeDescriptorFilterService
            {
                /*0x3814200*/ bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
                /*0x3814200*/ bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
                /*0x3814200*/ bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
            }

            class DesignerOptionService
            {
                /*0x787021c*/ void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options);

                class DesignerOptionCollection : System.Collections.ICollection
                {
                    /*0x10*/ System.ComponentModel.Design.DesignerOptionService _service;
                    /*0x18*/ string _name;
                    /*0x20*/ object _value;
                    /*0x28*/ System.Collections.ArrayList _children;
                    /*0x30*/ System.ComponentModel.PropertyDescriptorCollection _properties;

                    /*0x7870220*/ int get_Count();
                    /*0x78702ec*/ string get_Name();
                    /*0x78702f4*/ System.ComponentModel.PropertyDescriptorCollection get_Properties();
                    /*0x7870ac4*/ void CopyTo(System.Array array, int index);
                    /*0x787024c*/ void EnsurePopulated();
                    /*0x7870b08*/ System.Collections.IEnumerator GetEnumerator();
                    /*0x7870b34*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x7870b3c*/ object System.Collections.ICollection.get_SyncRoot();

                    class WrappedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ object target;
                        /*0x90*/ System.ComponentModel.PropertyDescriptor property;

                        /*0x7870a5c*/ WrappedPropertyDescriptor(System.ComponentModel.PropertyDescriptor property, object target);
                        /*0x7870b40*/ System.ComponentModel.AttributeCollection get_Attributes();
                        /*0x7870b60*/ System.Type get_ComponentType();
                        /*0x7870b84*/ bool get_IsReadOnly();
                        /*0x7870ba8*/ System.Type get_PropertyType();
                        /*0x7870bcc*/ bool CanResetValue(object component);
                        /*0x7870bf8*/ object GetValue(object component);
                        /*0x7870c24*/ void ResetValue(object component);
                        /*0x7870c50*/ void SetValue(object component, object value);
                        /*0x7870c7c*/ bool ShouldSerializeValue(object component);
                    }
                }

                class DesignerOptionConverter : System.ComponentModel.TypeConverter
                {
                    /*0x7871394*/ DesignerOptionConverter();
                    /*0x7870ca8*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext cxt);
                    /*0x7870cb0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext cxt, object value, System.Attribute[] attributes);
                    /*0x78712d8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext cxt, System.Globalization.CultureInfo culture, object value, System.Type destinationType);

                    class OptionPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection _option;

                        /*0x7871298*/ OptionPropertyDescriptor(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection option);
                        /*0x787139c*/ System.Type get_ComponentType();
                        /*0x78713b8*/ bool get_IsReadOnly();
                        /*0x78713c0*/ System.Type get_PropertyType();
                        /*0x78713dc*/ bool CanResetValue(object component);
                        /*0x78713e4*/ object GetValue(object component);
                        /*0x78713ec*/ void ResetValue(object component);
                        /*0x78713f0*/ void SetValue(object component, object value);
                        /*0x78713f4*/ bool ShouldSerializeValue(object component);
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

                    /*0x78713fc*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments);
                    /*0x7871404*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete);
                    /*0x7871938*/ System.Collections.ICollection get_Arguments();
                    /*0x7871940*/ System.Reflection.MemberInfo get_MemberInfo();
                    /*0x7864184*/ object Invoke();
                }

                class RootDesignerSerializerAttribute : System.Attribute
                {
                    /*0x10*/ string _typeId;
                    /*0x18*/ bool <Reloadable>k__BackingField;
                    /*0x20*/ string <SerializerTypeName>k__BackingField;
                    /*0x28*/ string <SerializerBaseTypeName>k__BackingField;

                    /*0x7871948*/ RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable);
                    /*0x78719a0*/ string get_SerializerBaseTypeName();
                    /*0x78719a8*/ object get_TypeId();
                }
            }
        }
    }

    namespace Collections
    {
        class HashtableExtensions
        {
            static /*0x3825c3c*/ bool TryGetValue<T>(System.Collections.Hashtable table, object key, ref T value);
        }

        namespace ObjectModel
        {
            class ObservableCollection<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
            {
                /*0x0*/ System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> _monitor;
                /*0x0*/ int _blockReentrancyCount;
                /*0x0*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
                /*0x0*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

                /*0x38159dc*/ ObservableCollection();
                /*0x3816710*/ void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x3816710*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x38159dc*/ void ClearItems();
                /*0x3815ed0*/ void RemoveItem(int index);
                /*0x3910ae8*/ void InsertItem(int index, T item);
                /*0x3910ae8*/ void SetItem(int index, T item);
                /*0x3816710*/ void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e);
                /*0x3816710*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x38159dc*/ void CheckReentrancy();
                /*0x38159dc*/ void OnCountPropertyChanged();
                /*0x38159dc*/ void OnIndexerPropertyChanged();
                /*0x3910ae8*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, object item, int index);
                void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, object oldItem, object newItem, int index);
                /*0x38159dc*/ void OnCollectionReset();
                /*0x38148bc*/ System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> EnsureMonitorInitialized();
                /*0x3816fbc*/ void OnSerializing(System.Runtime.Serialization.StreamingContext context);
                /*0x3816fbc*/ void OnDeserialized(System.Runtime.Serialization.StreamingContext context);

                class SimpleMonitor<T> : System.IDisposable
                {
                    /*0x0*/ int _busyCount;
                    /*0x0*/ System.Collections.ObjectModel.ObservableCollection<T> _collection;

                    /*0x3816710*/ SimpleMonitor(System.Collections.ObjectModel.ObservableCollection<T> collection);
                    /*0x38159dc*/ void Dispose();
                }
            }

            class EventArgsCache
            {
                static /*0x0*/ System.ComponentModel.PropertyChangedEventArgs CountPropertyChanged;
                static /*0x8*/ System.ComponentModel.PropertyChangedEventArgs IndexerPropertyChanged;
                static /*0x10*/ System.Collections.Specialized.NotifyCollectionChangedEventArgs ResetCollectionChanged;

                static /*0x7871a48*/ EventArgsCache();
            }

            class ReadOnlyObservableCollection<T> : System.Collections.ObjectModel.ReadOnlyCollection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
            {
                /*0x0*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
                /*0x0*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

                /*0x3816710*/ ReadOnlyObservableCollection(System.Collections.ObjectModel.ObservableCollection<T> list);
                /*0x3816710*/ void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x3816710*/ void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x3816710*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x3816710*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x3816710*/ void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs args);
                /*0x3816710*/ void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                /*0x3816710*/ void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args);
                /*0x3816810*/ void HandleCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x3816810*/ void HandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e);
            }
        }

        namespace Specialized
        {
            struct BitVector32
            {
                /*0x10*/ uint _data;

                static /*0x7871ca4*/ int CreateMask();
                static /*0x7871cac*/ int CreateMask(int previous);
                static /*0x7871df4*/ string ToString(System.Collections.Specialized.BitVector32 value);
                /*0x7871c78*/ bool get_Item(int bit);
                /*0x7871c88*/ void set_Item(int bit, bool value);
                /*0x7871d18*/ bool Equals(object o);
                /*0x7871d90*/ int GetHashCode();
                /*0x7871ec4*/ string ToString();
            }

            class ListDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Specialized.ListDictionary.DictionaryNode head;
                /*0x18*/ int version;
                /*0x1c*/ int count;
                /*0x20*/ System.Collections.IComparer comparer;
                /*0x28*/ object _syncRoot;

                /*0x7871ecc*/ ListDictionary();
                /*0x7871ed4*/ ListDictionary(System.Collections.IComparer comparer);
                /*0x7871f04*/ object get_Item(object key);
                /*0x7872060*/ void set_Item(object key, object value);
                /*0x7872268*/ int get_Count();
                /*0x7872270*/ System.Collections.ICollection get_Keys();
                /*0x787231c*/ bool get_IsReadOnly();
                /*0x7872324*/ bool get_IsFixedSize();
                /*0x787232c*/ bool get_IsSynchronized();
                /*0x7872334*/ object get_SyncRoot();
                /*0x78723a8*/ System.Collections.ICollection get_Values();
                /*0x7872414*/ void Add(object key, object value);
                /*0x7872644*/ void Clear();
                /*0x7872674*/ bool Contains(object key);
                /*0x78727c4*/ void CopyTo(System.Array array, int index);
                /*0x7872988*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x7872a38*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7872a90*/ void Remove(object key);

                class NodeEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                    /*0x20*/ int _version;
                    /*0x24*/ bool _start;

                    /*0x78729e0*/ NodeEnumerator(System.Collections.Specialized.ListDictionary list);
                    /*0x7872c2c*/ object get_Current();
                    /*0x7872c90*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x7872d0c*/ object get_Key();
                    /*0x7872d6c*/ object get_Value();
                    /*0x7872dcc*/ bool MoveNext();
                    /*0x7872e90*/ void Reset();
                }

                class NodeKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ bool _isKeys;

                    /*0x78722e0*/ NodeKeyValueCollection(System.Collections.Specialized.ListDictionary list, bool isKeys);
                    /*0x7872f10*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x7873054*/ int System.Collections.ICollection.get_Count();
                    /*0x787308c*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x7873094*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x78730ac*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class NodeKeyValueEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                        /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                        /*0x20*/ int _version;
                        /*0x24*/ bool _isKeys;
                        /*0x25*/ bool _start;

                        /*0x7873110*/ NodeKeyValueEnumerator(System.Collections.Specialized.ListDictionary list, bool isKeys);
                        /*0x787317c*/ object get_Current();
                        /*0x78731f0*/ bool MoveNext();
                        /*0x78732b4*/ void Reset();
                    }
                }

                class DictionaryNode
                {
                    /*0x10*/ object key;
                    /*0x18*/ object value;
                    /*0x20*/ System.Collections.Specialized.ListDictionary.DictionaryNode next;

                    /*0x7872260*/ DictionaryNode();
                }
            }

            class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase
            {
                /*0x50*/ string[] _all;
                /*0x58*/ string[] _allKeys;

                static /*0x7873554*/ string GetAsOneString(System.Collections.ArrayList list);
                static /*0x78736f8*/ string[] GetAsStringArray(System.Collections.ArrayList list);
                /*0x7873334*/ NameValueCollection();
                /*0x78733e8*/ NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x7873488*/ NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x787419c*/ NameValueCollection(System.DBNull dummy);
                /*0x787352c*/ void InvalidateCachedArrays();
                /*0x7873798*/ void Add(string name, string value);
                /*0x7873a9c*/ string Get(string name);
                /*0x7873b28*/ string[] GetValues(string name);
                /*0x7873bb4*/ void Set(string name, string value);
                /*0x7873d68*/ void Remove(string name);
                /*0x7873fbc*/ string get_Item(string name);
                /*0x7873fcc*/ void set_Item(string name, string value);
                /*0x7873fdc*/ string Get(int index);
                /*0x78740fc*/ string GetKey(int index);
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

                /*0x78741fc*/ OrderedDictionary();
                /*0x7863af4*/ OrderedDictionary(int capacity);
                /*0x7874224*/ OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer);
                /*0x787425c*/ OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x7863cd0*/ int get_Count();
                /*0x7874310*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x7874318*/ bool get_IsReadOnly();
                /*0x7874320*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x7874328*/ System.Collections.ICollection get_Keys();
                /*0x787428c*/ System.Collections.ArrayList get_objectsArray();
                /*0x78743e4*/ System.Collections.Hashtable get_objectsTable();
                /*0x7874470*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x786c57c*/ object get_Item(object key);
                /*0x7863b54*/ void set_Item(object key, object value);
                /*0x7863cf4*/ System.Collections.ICollection get_Values();
                /*0x7874664*/ void Add(object key, object value);
                /*0x7874788*/ void Clear();
                /*0x7863b28*/ bool Contains(object key);
                /*0x787481c*/ void CopyTo(System.Array array, int index);
                /*0x78744e4*/ int IndexOfKey(object key);
                /*0x786c5a8*/ void Remove(object key);
                /*0x7874858*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x787491c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x7874988*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x7874b50*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x7874b60*/ void OnDeserialization(object sender);

                class OrderedDictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ int _objectReturnType;
                    /*0x18*/ System.Collections.IEnumerator _arrayEnumerator;

                    /*0x78748c4*/ OrderedDictionaryEnumerator(System.Collections.ArrayList array, int objectReturnType);
                    /*0x7874f20*/ object get_Current();
                    /*0x78750e4*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x7875278*/ object get_Key();
                    /*0x787535c*/ object get_Value();
                    /*0x7875440*/ bool MoveNext();
                    /*0x78754e0*/ void Reset();
                }

                class OrderedDictionaryKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _objects;
                    /*0x18*/ bool _isKeys;

                    /*0x78743a8*/ OrderedDictionaryKeyValueCollection(System.Collections.ArrayList array, bool isKeys);
                    /*0x7875584*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x7875978*/ int System.Collections.ICollection.get_Count();
                    /*0x787599c*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x78759a4*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x78759c8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class StringCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ArrayList data;

                /*0x7875e38*/ StringCollection();
                /*0x7875a38*/ string get_Item(int index);
                /*0x7875a80*/ void set_Item(int index, string value);
                /*0x7875aa4*/ int get_Count();
                /*0x7875ac8*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x7875ad0*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x7875ad8*/ int Add(string value);
                /*0x7875afc*/ void Clear();
                /*0x7875b20*/ bool Contains(string value);
                /*0x7875b44*/ void CopyTo(string[] array, int index);
                /*0x7875b68*/ int IndexOf(string value);
                /*0x7875b8c*/ void Insert(int index, string value);
                /*0x7875bb0*/ bool get_IsSynchronized();
                /*0x7875bb8*/ void Remove(string value);
                /*0x7875bdc*/ void RemoveAt(int index);
                /*0x7875c00*/ object get_SyncRoot();
                /*0x7875c24*/ object System.Collections.IList.get_Item(int index);
                /*0x7875c28*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x7875c74*/ int System.Collections.IList.Add(object value);
                /*0x7875cc0*/ bool System.Collections.IList.Contains(object value);
                /*0x7875d0c*/ int System.Collections.IList.IndexOf(object value);
                /*0x7875d58*/ void System.Collections.IList.Insert(int index, object value);
                /*0x7875da4*/ void System.Collections.IList.Remove(object value);
                /*0x7875df0*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x7875e14*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class StringDictionary : System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable contents;

                /*0x7875ea4*/ StringDictionary();
                /*0x7875f10*/ string get_Item(string key);
                /*0x7875fb8*/ System.Collections.IEnumerator GetEnumerator();
            }

            interface INotifyCollectionChanged
            {
                /*0x3816710*/ void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                /*0x3816710*/ void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
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

                /*0x7871b68*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action);
                /*0x7876078*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index);
                /*0x7876268*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem, int index);
                /*0x787649c*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex);
                /*0x7876250*/ void InitializeAddOrRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int startingIndex);
                /*0x7875fdc*/ void InitializeAdd(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, int newStartingIndex);
                /*0x787664c*/ void InitializeRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList oldItems, int oldStartingIndex);
                /*0x7876458*/ void InitializeMoveOrReplace(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex, int oldStartingIndex);
            }

            class NotifyCollectionChangedEventHandler : System.MulticastDelegate
            {
                /*0x7876718*/ NotifyCollectionChangedEventHandler(object object, nint method);
                /*0x7876824*/ void Invoke(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
            }

            class ReadOnlyList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.IList _list;

                /*0x78766e8*/ ReadOnlyList(System.Collections.IList list);
                /*0x7876838*/ int get_Count();
                /*0x78768dc*/ bool get_IsReadOnly();
                /*0x78768e4*/ bool get_IsFixedSize();
                /*0x78768ec*/ bool get_IsSynchronized();
                /*0x7876990*/ object get_Item(int index);
                /*0x7876a38*/ void set_Item(int index, object value);
                /*0x7876a84*/ object get_SyncRoot();
                /*0x7876b28*/ int Add(object value);
                /*0x7876b74*/ void Clear();
                /*0x7876bc0*/ bool Contains(object value);
                /*0x7876c6c*/ void CopyTo(System.Array array, int index);
                /*0x7876d24*/ System.Collections.IEnumerator GetEnumerator();
                /*0x7876dc4*/ int IndexOf(object value);
                /*0x7876e70*/ void Insert(int index, object value);
                /*0x7876ebc*/ void Remove(object value);
                /*0x7876f08*/ void RemoveAt(int index);
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

                static /*0x78785e8*/ NameObjectCollectionBase();
                /*0x7873388*/ NameObjectCollectionBase();
                /*0x7876f54*/ NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer);
                /*0x787345c*/ NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x78741f4*/ NameObjectCollectionBase(System.DBNull dummy);
                /*0x78734fc*/ NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x787718c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x78778f8*/ void OnDeserialization(object sender);
                /*0x7876fe0*/ void Reset();
                /*0x78770b0*/ void Reset(int capacity);
                /*0x787808c*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(string key);
                /*0x7878144*/ bool get_IsReadOnly();
                /*0x7873934*/ void BaseAdd(string name, object value);
                /*0x7873da8*/ void BaseRemove(string name);
                /*0x787391c*/ object BaseGet(string name);
                /*0x7873cb8*/ void BaseSet(string name, object value);
                /*0x7874060*/ object BaseGet(int index);
                /*0x7874100*/ string BaseGetKey(int index);
                /*0x7878190*/ System.Collections.IEnumerator GetEnumerator();
                /*0x787823c*/ int get_Count();
                /*0x7878260*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x787856c*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x78785e0*/ bool System.Collections.ICollection.get_IsSynchronized();

                class NameObjectEntry
                {
                    /*0x10*/ string Key;
                    /*0x18*/ object Value;

                    /*0x787814c*/ NameObjectEntry(string name, object value);
                }

                class NameObjectKeysEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ int _pos;
                    /*0x18*/ System.Collections.Specialized.NameObjectCollectionBase _coll;
                    /*0x20*/ int _version;

                    /*0x78781e8*/ NameObjectKeysEnumerator(System.Collections.Specialized.NameObjectCollectionBase coll);
                    /*0x7878698*/ bool MoveNext();
                    /*0x7878770*/ void Reset();
                    /*0x78787f8*/ object get_Current();
                }
            }

            class CompatibleComparer : System.Collections.IEqualityComparer
            {
                static /*0x0*/ System.Collections.IComparer defaultComparer;
                static /*0x8*/ System.Collections.IHashCodeProvider defaultHashProvider;
                /*0x10*/ System.Collections.IComparer _comparer;
                /*0x18*/ System.Collections.IHashCodeProvider _hcp;

                static /*0x7877814*/ System.Collections.IComparer get_DefaultComparer();
                static /*0x7877738*/ System.Collections.IHashCodeProvider get_DefaultHashCodeProvider();
                /*0x7878048*/ CompatibleComparer(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider);
                /*0x7878898*/ bool Equals(object a, object b);
                /*0x7878a98*/ int GetHashCode(object obj);
                /*0x7878ba0*/ System.Collections.IComparer get_Comparer();
                /*0x7878ba8*/ System.Collections.IHashCodeProvider get_HashCodeProvider();
            }
        }

        namespace Concurrent
        {
            class ConcurrentBag<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>
            {
                /*0x0*/ System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>> _locals;
                /*0x0*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> _workStealingQueues;
                /*0x0*/ long _emptyToNonEmptyListTransitionCount;

                /*0x38159dc*/ ConcurrentBag();
                /*0x3910ae8*/ void Add(T item);
                System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate);
                /*0x38148bc*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread();
                /*0x38148bc*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue();
                /*0x381678c*/ void CopyTo(T[] array, int index);
                int CopyFromEachQueueToArray(T[] array, int index);
                /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x38148bc*/ T[] ToArray();
                /*0x38159dc*/ void Clear();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3814574*/ int get_Count();
                /*0x3814574*/ int get_DangerousCount();
                /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x38148bc*/ object get_GlobalQueuesLock();
                /*0x3816710*/ void FreezeBag(ref bool lockTaken);
                /*0x3815cc4*/ void UnfreezeBag(bool lockTaken);

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

                    /*0x3816710*/ WorkStealingQueue(System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> nextQueue);
                    /*0x3910ae8*/ void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount);
                    /*0x38159dc*/ void LocalClear();
                    bool TrySteal(ref T result, bool take);
                    int DangerousCopyTo(T[] array, int arrayIndex);
                    /*0x3814574*/ int get_DangerousCount();
                }

                class Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ T[] _array;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    /*0x3816710*/ Enumerator(T[] array);
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x3910ae8*/ T get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38159dc*/ void Reset();
                    /*0x38159dc*/ void Dispose();
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

                /*0x3910ae8*/ ValueListBuilder(System.Span<T> initialSpan);
                /*0x3814574*/ int get_Length();
                /*0x3814964*/ ref T get_Item(int index);
                /*0x3910ae8*/ void Append(T item);
                /*0x3910ae8*/ System.ReadOnlySpan<T> AsSpan();
                /*0x38159dc*/ void Dispose();
                /*0x38159dc*/ void Grow();
                /*0x3910ae8*/ T Pop();
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

                /*0x38159dc*/ LinkedList();
                LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3814574*/ int get_Count();
                /*0x38148bc*/ System.Collections.Generic.LinkedListNode<T> get_First();
                /*0x38148bc*/ System.Collections.Generic.LinkedListNode<T> get_Last();
                /*0x3813ffc*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x3910ae8*/ void System.Collections.Generic.ICollection<T>.Add(T value);
                /*0x3816810*/ void AddBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x3910ae8*/ System.Collections.Generic.LinkedListNode<T> AddFirst(T value);
                /*0x3816710*/ void AddFirst(System.Collections.Generic.LinkedListNode<T> node);
                /*0x3910ae8*/ System.Collections.Generic.LinkedListNode<T> AddLast(T value);
                /*0x3816710*/ void AddLast(System.Collections.Generic.LinkedListNode<T> node);
                /*0x38159dc*/ void Clear();
                /*0x3910ae8*/ bool Contains(T value);
                /*0x381678c*/ void CopyTo(T[] array, int index);
                /*0x3910ae8*/ System.Collections.Generic.LinkedListNode<T> Find(T value);
                /*0x3910ae8*/ System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x3910ae8*/ bool Remove(T value);
                /*0x3816710*/ void Remove(System.Collections.Generic.LinkedListNode<T> node);
                /*0x38159dc*/ void RemoveFirst();
                /*0x38159dc*/ void RemoveLast();
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3816710*/ void OnDeserialization(object sender);
                /*0x3816810*/ void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x3816710*/ void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x3816710*/ void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x3816710*/ void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x3816710*/ void ValidateNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    /*0x0*/ System.Collections.Generic.LinkedList<T> _list;
                    /*0x0*/ System.Collections.Generic.LinkedListNode<T> _node;
                    /*0x0*/ int _version;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    /*0x3816710*/ Enumerator(System.Collections.Generic.LinkedList<T> list);
                    Enumerator(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x3910ae8*/ T get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                    /*0x38159dc*/ void Dispose();
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x3816710*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                }
            }

            class LinkedListNode<T>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<T> list;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> next;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> prev;
                /*0x0*/ T item;

                /*0x3910ae8*/ LinkedListNode(T value);
                /*0x3910ae8*/ LinkedListNode(System.Collections.Generic.LinkedList<T> list, T value);
                /*0x38148bc*/ System.Collections.Generic.LinkedList<T> get_List();
                /*0x38148bc*/ System.Collections.Generic.LinkedListNode<T> get_Next();
                /*0x38148bc*/ System.Collections.Generic.LinkedListNode<T> get_Previous();
                /*0x3910ae8*/ T get_Value();
                /*0x3910ae8*/ void set_Value(T value);
                /*0x38159dc*/ void Invalidate();
            }

            class SortedDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> _keys;
                /*0x0*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> _values;
                /*0x0*/ System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey, TValue>> _set;

                static /*0x3823ae0*/ bool IsCompatibleKey(object key);
                /*0x38159dc*/ SortedDictionary();
                /*0x3816810*/ SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer);
                /*0x3816710*/ SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer);
                /*0x3910ae8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3910ae8*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3910ae8*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3813ffc*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x3910ae8*/ TValue get_Item(TKey key);
                /*0x3910ae8*/ void set_Item(TKey key, TValue value);
                /*0x3814574*/ int get_Count();
                /*0x38148bc*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> get_Keys();
                /*0x38148bc*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                /*0x38148bc*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> get_Values();
                /*0x38148bc*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                /*0x3910ae8*/ void Add(TKey key, TValue value);
                /*0x38159dc*/ void Clear();
                /*0x3910ae8*/ bool ContainsKey(TKey key);
                /*0x3910ae8*/ bool ContainsValue(TValue value);
                /*0x381678c*/ void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int index);
                /*0x3910ae8*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x3910ae8*/ bool Remove(TKey key);
                /*0x3910ae8*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3813ffc*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x3813ffc*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x38148bc*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x38148bc*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x3814a3c*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x3816810*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x3816810*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x38141c4*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x38148bc*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x3816710*/ void System.Collections.IDictionary.Remove(object key);
                /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedSet.Enumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _treeEnum;
                    /*0x0*/ int _getEnumeratorRetType;

                    /*0x381678c*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Dispose();
                    /*0x3910ae8*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x3813ffc*/ bool get_NotStartedOrEnded();
                    /*0x38159dc*/ void Reset();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38148bc*/ object System.Collections.IDictionaryEnumerator.get_Key();
                    /*0x38148bc*/ object System.Collections.IDictionaryEnumerator.get_Value();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                }

                class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TKey>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    /*0x3816710*/ KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x381678c*/ void CopyTo(TKey[] array, int index);
                    /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x3814574*/ int get_Count();
                    /*0x3813ffc*/ bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly();
                    /*0x3910ae8*/ void System.Collections.Generic.ICollection<TKey>.Add(TKey item);
                    /*0x38159dc*/ void System.Collections.Generic.ICollection<TKey>.Clear();
                    /*0x3910ae8*/ bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item);
                    /*0x3910ae8*/ bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item);
                    /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        /*0x3816710*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        /*0x38159dc*/ void Dispose();
                        /*0x3813ffc*/ bool MoveNext();
                        /*0x3910ae8*/ TKey get_Current();
                        /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                        /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TKey[] array;
                        /*0x0*/ int index;

                        /*0x38159dc*/ <>c__DisplayClass5_0();
                        /*0x38141c4*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        /*0x38159dc*/ <>c__DisplayClass6_0();
                        /*0x38141c4*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TValue>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    /*0x3816710*/ ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x381678c*/ void CopyTo(TValue[] array, int index);
                    /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x3814574*/ int get_Count();
                    /*0x3813ffc*/ bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly();
                    /*0x3910ae8*/ void System.Collections.Generic.ICollection<TValue>.Add(TValue item);
                    /*0x38159dc*/ void System.Collections.Generic.ICollection<TValue>.Clear();
                    /*0x3910ae8*/ bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item);
                    /*0x3910ae8*/ bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item);
                    /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        /*0x3816710*/ Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        /*0x38159dc*/ void Dispose();
                        /*0x3813ffc*/ bool MoveNext();
                        /*0x3910ae8*/ TValue get_Current();
                        /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                        /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TValue[] array;
                        /*0x0*/ int index;

                        /*0x38159dc*/ <>c__DisplayClass5_0();
                        /*0x38141c4*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        /*0x38159dc*/ <>c__DisplayClass6_0();
                        /*0x38141c4*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class KeyValuePairComparer<TKey, TValue> : System.Collections.Generic.Comparer<System.Collections.Generic.KeyValuePair<TKey, TValue>>
                {
                    /*0x0*/ System.Collections.Generic.IComparer<TKey> keyComparer;

                    /*0x3816710*/ KeyValuePairComparer(System.Collections.Generic.IComparer<TKey> keyComparer);
                    /*0x3910ae8*/ int Compare(System.Collections.Generic.KeyValuePair<TKey, TValue> x, System.Collections.Generic.KeyValuePair<TKey, TValue> y);
                }

                class <>c__DisplayClass34_0<TKey, TValue>
                {
                    /*0x0*/ bool found;
                    /*0x0*/ TValue value;

                    /*0x38159dc*/ <>c__DisplayClass34_0();
                    /*0x38141c4*/ bool <ContainsValue>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }

                class <>c__DisplayClass34_1<TKey, TValue>
                {
                    /*0x0*/ System.Collections.Generic.EqualityComparer<TValue> valueComparer;
                    /*0x0*/ System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1;

                    /*0x38159dc*/ <>c__DisplayClass34_1();
                    /*0x38141c4*/ bool <ContainsValue>b__1(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }
            }

            class TreeSet<T> : System.Collections.Generic.SortedSet<T>
            {
                /*0x38159dc*/ TreeSet();
                /*0x3816710*/ TreeSet(System.Collections.Generic.IComparer<T> comparer);
                TreeSet(System.Runtime.Serialization.SerializationInfo siInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x3910ae8*/ bool AddIfNotPresent(T item);
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

                static /*0x3823ae0*/ bool IsCompatibleKey(object key);
                /*0x38159dc*/ SortedList();
                /*0x3815ed0*/ SortedList(int capacity);
                /*0x3816710*/ SortedList(System.Collections.Generic.IComparer<TKey> comparer);
                /*0x3910ae8*/ void Add(TKey key, TValue value);
                /*0x3910ae8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3910ae8*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3910ae8*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x3815ed0*/ void set_Capacity(int value);
                /*0x3816810*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x3814574*/ int get_Count();
                /*0x38148bc*/ System.Collections.Generic.IList<TKey> get_Keys();
                /*0x38148bc*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                /*0x38148bc*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                /*0x38148bc*/ System.Collections.Generic.IList<TValue> get_Values();
                /*0x38148bc*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                /*0x38148bc*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                /*0x38148bc*/ System.Collections.Generic.SortedList.KeyList<TKey, TValue> GetKeyListHelper();
                /*0x38148bc*/ System.Collections.Generic.SortedList.ValueList<TKey, TValue> GetValueListHelper();
                /*0x3813ffc*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x3813ffc*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x3813ffc*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x38159dc*/ void Clear();
                /*0x38141c4*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x3910ae8*/ bool ContainsKey(TKey key);
                /*0x3910ae8*/ bool ContainsValue(TValue value);
                /*0x381678c*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3815ed0*/ void EnsureCapacity(int min);
                /*0x3910ae8*/ TValue GetByIndex(int index);
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x38148bc*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3910ae8*/ TKey GetKey(int index);
                /*0x3910ae8*/ TValue get_Item(TKey key);
                /*0x3910ae8*/ void set_Item(TKey key, TValue value);
                /*0x3814a3c*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x3816810*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x3910ae8*/ int IndexOfKey(TKey key);
                /*0x3910ae8*/ int IndexOfValue(TValue value);
                /*0x3910ae8*/ void Insert(int index, TKey key, TValue value);
                /*0x3910ae8*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x3815ed0*/ void RemoveAt(int index);
                /*0x3910ae8*/ bool Remove(TKey key);
                /*0x3816710*/ void System.Collections.IDictionary.Remove(object key);

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ TKey _key;
                    /*0x0*/ TValue _value;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ int _getEnumeratorRetType;

                    /*0x381678c*/ Enumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList, int getEnumeratorRetType);
                    /*0x38159dc*/ void Dispose();
                    /*0x38148bc*/ object System.Collections.IDictionaryEnumerator.get_Key();
                    /*0x3813ffc*/ bool MoveNext();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                    /*0x3910ae8*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38148bc*/ object System.Collections.IDictionaryEnumerator.get_Value();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListKeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TKey _currentKey;

                    /*0x3816710*/ SortedListKeyEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x38159dc*/ void Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x3910ae8*/ TKey get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TValue _currentValue;

                    /*0x3816710*/ SortedListValueEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x38159dc*/ void Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x3910ae8*/ TValue get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                }

                class KeyList<TKey, TValue> : System.Collections.Generic.IList<TKey>, System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x3816710*/ KeyList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x3814574*/ int get_Count();
                    /*0x3813ffc*/ bool get_IsReadOnly();
                    /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x3910ae8*/ void Add(TKey key);
                    /*0x38159dc*/ void Clear();
                    /*0x3910ae8*/ bool Contains(TKey key);
                    /*0x381678c*/ void CopyTo(TKey[] array, int arrayIndex);
                    /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    /*0x3910ae8*/ void Insert(int index, TKey value);
                    /*0x3910ae8*/ TKey get_Item(int index);
                    /*0x3910ae8*/ void set_Item(int index, TKey value);
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<TKey> GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3910ae8*/ int IndexOf(TKey key);
                    /*0x3910ae8*/ bool Remove(TKey key);
                    /*0x3815ed0*/ void RemoveAt(int index);
                }

                class ValueList<TKey, TValue> : System.Collections.Generic.IList<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x3816710*/ ValueList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x3814574*/ int get_Count();
                    /*0x3813ffc*/ bool get_IsReadOnly();
                    /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x3910ae8*/ void Add(TValue key);
                    /*0x38159dc*/ void Clear();
                    /*0x3910ae8*/ bool Contains(TValue value);
                    /*0x381678c*/ void CopyTo(TValue[] array, int arrayIndex);
                    /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x3910ae8*/ void Insert(int index, TValue value);
                    /*0x3910ae8*/ TValue get_Item(int index);
                    /*0x3910ae8*/ void set_Item(int index, TValue value);
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3910ae8*/ int IndexOf(TValue value);
                    /*0x3910ae8*/ bool Remove(TValue value);
                    /*0x3815ed0*/ void RemoveAt(int index);
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

                static /*0x382d234*/ int Log2(int value);
                /*0x38159dc*/ SortedSet();
                /*0x3816710*/ SortedSet(System.Collections.Generic.IComparer<T> comparer);
                SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x38141c4*/ bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action);
                /*0x3814574*/ int get_Count();
                /*0x3813ffc*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x3813ffc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x38148bc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x38159dc*/ void VersionCheck();
                /*0x3910ae8*/ bool IsWithinRange(T item);
                /*0x3910ae8*/ bool Add(T item);
                /*0x3910ae8*/ void System.Collections.Generic.ICollection<T>.Add(T item);
                /*0x3910ae8*/ bool AddIfNotPresent(T item);
                /*0x3910ae8*/ bool Remove(T item);
                /*0x3910ae8*/ bool DoRemove(T item);
                /*0x38159dc*/ void Clear();
                /*0x3910ae8*/ bool Contains(T item);
                /*0x381678c*/ void CopyTo(T[] array, int index);
                void CopyTo(T[] array, int index, int count);
                /*0x381678c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3910ae8*/ System.Collections.Generic.SortedSet.Enumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3816958*/ void InsertionBalance(System.Collections.Generic.SortedSet.Node<T> current, ref System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> grandParent, System.Collections.Generic.SortedSet.Node<T> greatGrandParent);
                /*0x3816920*/ void ReplaceChildOrRoot(System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                /*0x3816958*/ void ReplaceNode(System.Collections.Generic.SortedSet.Node<T> match, System.Collections.Generic.SortedSet.Node<T> parentOfMatch, System.Collections.Generic.SortedSet.Node<T> successor, System.Collections.Generic.SortedSet.Node<T> parentOfSuccessor);
                /*0x3910ae8*/ System.Collections.Generic.SortedSet.Node<T> FindNode(T item);
                /*0x38159dc*/ void UpdateVersion();
                void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3816710*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x3816710*/ void OnDeserialization(object sender);

                class Node<T>
                {
                    /*0x0*/ T <Item>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Left>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Right>k__BackingField;
                    /*0x0*/ System.Collections.Generic.NodeColor <Color>k__BackingField;

                    static /*0x3823ae0*/ bool IsNonNullRed(System.Collections.Generic.SortedSet.Node<T> node);
                    static /*0x3823ae0*/ bool IsNullOrBlack(System.Collections.Generic.SortedSet.Node<T> node);
                    /*0x3910ae8*/ Node(T item, System.Collections.Generic.NodeColor color);
                    /*0x3910ae8*/ T get_Item();
                    /*0x3910ae8*/ void set_Item(T value);
                    /*0x38148bc*/ System.Collections.Generic.SortedSet.Node<T> get_Left();
                    /*0x3816710*/ void set_Left(System.Collections.Generic.SortedSet.Node<T> value);
                    /*0x38148bc*/ System.Collections.Generic.SortedSet.Node<T> get_Right();
                    /*0x3816710*/ void set_Right(System.Collections.Generic.SortedSet.Node<T> value);
                    /*0x3813ffc*/ System.Collections.Generic.NodeColor get_Color();
                    /*0x3815cc4*/ void set_Color(System.Collections.Generic.NodeColor value);
                    /*0x3813ffc*/ bool get_IsBlack();
                    /*0x3813ffc*/ bool get_IsRed();
                    /*0x3813ffc*/ bool get_Is2Node();
                    /*0x3813ffc*/ bool get_Is4Node();
                    /*0x38159dc*/ void ColorBlack();
                    /*0x38159dc*/ void ColorRed();
                    /*0x3814200*/ System.Collections.Generic.TreeRotation GetRotation(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T> sibling);
                    /*0x3814a3c*/ System.Collections.Generic.SortedSet.Node<T> GetSibling(System.Collections.Generic.SortedSet.Node<T> node);
                    /*0x38159dc*/ void Split4Node();
                    System.Collections.Generic.SortedSet.Node<T> Rotate(System.Collections.Generic.TreeRotation rotation);
                    /*0x38148bc*/ System.Collections.Generic.SortedSet.Node<T> RotateLeft();
                    /*0x38148bc*/ System.Collections.Generic.SortedSet.Node<T> RotateLeftRight();
                    /*0x38148bc*/ System.Collections.Generic.SortedSet.Node<T> RotateRight();
                    /*0x38148bc*/ System.Collections.Generic.SortedSet.Node<T> RotateRightLeft();
                    /*0x38159dc*/ void Merge2Nodes();
                    /*0x3816810*/ void ReplaceChild(System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    static /*0x0*/ System.Collections.Generic.SortedSet.Node<T> s_dummyNode;
                    /*0x0*/ System.Collections.Generic.SortedSet<T> _tree;
                    /*0x0*/ int _version;
                    /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>> _stack;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> _current;
                    /*0x0*/ bool _reverse;

                    static /*0x383e7a0*/ Enumerator();
                    /*0x3816710*/ Enumerator(System.Collections.Generic.SortedSet<T> set);
                    Enumerator(System.Collections.Generic.SortedSet<T> set, bool reverse);
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x3816710*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                    /*0x38159dc*/ void Initialize();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Dispose();
                    /*0x3910ae8*/ T get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x3813ffc*/ bool get_NotStartedOrEnded();
                    /*0x38159dc*/ void Reset();
                    /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                }

                class <>c__DisplayClass52_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ int count;
                    /*0x0*/ T[] array;

                    /*0x38159dc*/ <>c__DisplayClass52_0();
                    /*0x38141c4*/ bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
                }

                class <>c__DisplayClass53_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ object[] objects;

                    /*0x38159dc*/ <>c__DisplayClass53_0();
                    /*0x38141c4*/ bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
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
                /*0x38141c4*/ bool Invoke(System.Collections.Generic.SortedSet.Node<T> node);
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
            /*0x7878bb0*/ InvalidDataException();
            /*0x7878c18*/ InvalidDataException(string message);
            /*0x7878c3c*/ InvalidDataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

                static /*0x7879788*/ void ThrowStreamClosedException();
                /*0x7878c44*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x7878c4c*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x7878d10*/ bool get_CanRead();
                /*0x7878d28*/ bool get_CanWrite();
                /*0x7878d40*/ bool get_CanSeek();
                /*0x7878d58*/ long get_Length();
                /*0x7878da4*/ long get_Position();
                /*0x7878df0*/ void set_Position(long value);
                /*0x7878e3c*/ void Flush();
                /*0x7878e78*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x7878ec4*/ void SetLength(long value);
                /*0x7878f10*/ int ReadByte();
                /*0x7878f34*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x7878fe8*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x7879030*/ int Read(byte[] array, int offset, int count);
                /*0x7879054*/ int Read(System.Span<byte> buffer);
                /*0x7879240*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x78792f4*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x7879300*/ void Write(byte[] array, int offset, int count);
                /*0x7879324*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x787947c*/ void CopyTo(System.IO.Stream destination, int bufferSize);
                /*0x78794a0*/ void Dispose(bool disposing);
                /*0x7879574*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7879598*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x787966c*/ System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7879690*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x7879764*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x7878e60*/ void CheckDeflateStream();
            }

            class DeflateStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream base_stream;
                /*0x30*/ System.IO.Compression.CompressionMode mode;
                /*0x34*/ bool leaveOpen;
                /*0x35*/ bool disposed;
                /*0x38*/ System.IO.Compression.DeflateStreamNative native;

                /*0x78797d8*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x7878d04*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen, int windowsBits);
                /*0x78797e4*/ DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen, bool gzip);
                /*0x7879ad4*/ void Finalize();
                /*0x7879b78*/ void Dispose(bool disposing);
                /*0x7879d50*/ int ReadInternal(byte[] array, int offset, int count);
                /*0x7879664*/ System.Threading.Tasks.ValueTask<int> ReadAsyncMemory(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken);
                /*0x7879128*/ int ReadCore(System.Span<byte> destination);
                /*0x7879e10*/ int Read(byte[] array, int offset, int count);
                /*0x7879fe0*/ void WriteInternal(byte[] array, int offset, int count);
                /*0x787975c*/ System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken);
                /*0x78793f8*/ void WriteCore(System.ReadOnlySpan<byte> source);
                /*0x787a090*/ void Write(byte[] array, int offset, int count);
                /*0x787a26c*/ void Flush();
                /*0x787a370*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x787a708*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x787aaa0*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x787ac04*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x787ad50*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x787ad88*/ void SetLength(long value);
                /*0x787adc0*/ bool get_CanRead();
                /*0x787adfc*/ bool get_CanSeek();
                /*0x787ae04*/ bool get_CanWrite();
                /*0x787ae44*/ long get_Length();
                /*0x787ae7c*/ long get_Position();
                /*0x787aeb4*/ void set_Position(long value);

                class ReadMethod : System.MulticastDelegate
                {
                    /*0x787a5d4*/ ReadMethod(object object, nint method);
                    /*0x787aeec*/ int Invoke(byte[] array, int offset, int count);
                    /*0x787a688*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x787abdc*/ int EndInvoke(System.IAsyncResult result);
                }

                class WriteMethod : System.MulticastDelegate
                {
                    /*0x787a96c*/ WriteMethod(object object, nint method);
                    /*0x787af00*/ void Invoke(byte[] array, int offset, int count);
                    /*0x787aa20*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x787ad44*/ void EndInvoke(System.IAsyncResult result);
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

                static /*0x7879964*/ System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool gzip);
                static /*0x787af14*/ int UnmanagedRead(nint buffer, int length, nint data);
                static /*0x787b030*/ int UnmanagedWrite(nint buffer, int length, nint data);
                static /*0x787b154*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, bool gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, nint data);
                static /*0x787b8c8*/ int CloseZStream(nint stream);
                static /*0x787b288*/ int Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream);
                static /*0x787b418*/ int ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                static /*0x787b494*/ int WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                /*0x787b14c*/ DeflateStreamNative();
                /*0x787b1f0*/ void Finalize();
                /*0x7879c40*/ void Dispose(bool disposing);
                /*0x787a31c*/ void Flush();
                /*0x7879d98*/ int ReadZStream(nint buffer, int length);
                /*0x787a024*/ void WriteZStream(nint buffer, int length);
                /*0x787b510*/ int UnmanagedRead(nint buffer, int length);
                /*0x787b6d0*/ int UnmanagedWrite(nint buffer, int length);
                /*0x787b2ec*/ void CheckResult(int result, string where);

                class UnmanagedReadOrWrite : System.MulticastDelegate
                {
                    /*0x787b8cc*/ UnmanagedReadOrWrite(object object, nint method);
                    /*0x787b96c*/ int Invoke(nint buffer, int length, nint data);
                }

                class SafeDeflateStreamHandle : System.Runtime.InteropServices.SafeHandle
                {
                    /*0x787b990*/ SafeDeflateStreamHandle();
                    /*0x787b980*/ bool get_IsInvalid();
                    /*0x787b9a0*/ bool ReleaseHandle();
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

            /*0x787ba34*/ ContextAwareResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x787ba3c*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x787ba8c*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x787ba2c*/ void SafeCaptureIdentity();
            /*0x787ba30*/ void CleanupInternal();
            /*0x787bb04*/ object StartPostingAsyncOp();
            /*0x787bb0c*/ object StartPostingAsyncOp(bool lockCapture);
            /*0x787bcd4*/ bool FinishPostingAsyncOp();
            /*0x787c11c*/ void Cleanup();
            /*0x787bd18*/ bool CaptureOrComplete(ref System.Threading.ExecutionContext cachedContext, bool returnContext);
            /*0x787c3e0*/ void Complete(nint userToken);
            /*0x787c6ac*/ void CompleteCallback();

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

                static /*0x787c758*/ <>c();
                /*0x787c7c0*/ <>c();
                /*0x787c7c8*/ void <Complete>b__17_0(object s);
            }
        }

        class HttpStatusDescription
        {
            static /*0x787c848*/ string Get(System.Net.HttpStatusCode code);
            static /*0x787c84c*/ string Get(int code);
        }

        class HttpValidationHelpers
        {
            static /*0x0*/ char[] s_httpTrimCharacters;

            static /*0x787cfe4*/ HttpValidationHelpers();
            static /*0x787cee4*/ bool IsInvalidMethodOrHeaderString(string stringValue);
        }

        class NetEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Net.NetEventSource Log;

            static /*0x787e3f4*/ NetEventSource();
            static /*0x787d084*/ void Enter(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x787d648*/ void Enter(object thisOrContextObject, object arg0, string memberName);
            static /*0x787dad8*/ void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName);
            static /*0x787dbf4*/ void Exit(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x787dd60*/ void Exit(object thisOrContextObject, object arg0, string memberName);
            static /*0x787c220*/ void Info(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x787c310*/ void Info(object thisOrContextObject, object message, string memberName);
            static /*0x787deac*/ void Error(object thisOrContextObject, object message, string memberName);
            static /*0x787bc04*/ void Fail(object thisOrContextObject, object message, string memberName);
            static /*0x787e074*/ void Associate(object first, object second, string memberName);
            static /*0x787c1bc*/ bool get_IsEnabled();
            static /*0x787d174*/ string IdOf(object value);
            static /*0x787e3d8*/ int GetHashCode(object value);
            static /*0x787d730*/ object Format(object value);
            static /*0x787d260*/ string Format(System.FormattableString s);
            /*0x787e3ec*/ NetEventSource();
            /*0x787d5cc*/ void Enter(string thisOrContextObject, string memberName, string parameters);
            /*0x787dce4*/ void Exit(string thisOrContextObject, string memberName, string result);
            /*0x787de30*/ void Info(string thisOrContextObject, string memberName, string message);
            /*0x787df7c*/ void ErrorMessage(string thisOrContextObject, string memberName, string message);
            /*0x787dff8*/ void CriticalFailure(string thisOrContextObject, string memberName, string message);
            /*0x787e144*/ void Associate(string thisOrContextObject, string memberName, string first, string second);
            /*0x787e1cc*/ void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4);

            class Keywords
            {
                static System.Diagnostics.Tracing.EventKeywords Default = 1;
                static System.Diagnostics.Tracing.EventKeywords Debug = 2;
                static System.Diagnostics.Tracing.EventKeywords EnterExit = 4;
            }
        }

        class TcpValidationHelpers
        {
            static /*0x787e45c*/ bool ValidatePortNumber(int port);
        }

        class TlsStream : System.Net.Sockets.NetworkStream
        {
            /*0x48*/ System.Net.Security.SslStream _sslStream;
            /*0x50*/ string _host;
            /*0x58*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;

            /*0x787e468*/ TlsStream(System.Net.Sockets.NetworkStream stream, System.Net.Sockets.Socket socket, string host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates);
            /*0x787e558*/ void AuthenticateAsClient();
            /*0x787e658*/ System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object state);
            /*0x787e770*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
            /*0x787e794*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x787e7b8*/ void EndWrite(System.IAsyncResult result);
            /*0x787e7dc*/ void Write(byte[] buffer, int offset, int size);
            /*0x787e800*/ int Read(byte[] buffer, int offset, int size);
            /*0x787e824*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x787e848*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x787e86c*/ void Close();
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

            static /*0x787e8a0*/ HttpVersion();
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

            static /*0x787fcd0*/ IPAddress();
            static /*0x787ee60*/ bool TryParse(string ipString, ref System.Net.IPAddress address);
            static /*0x787f0b0*/ System.Net.IPAddress Parse(string ipString);
            static /*0x787f600*/ bool IsLoopback(System.Net.IPAddress address);
            static /*0x787eb54*/ byte[] ThrowAddressNullException();
            /*0x787ea4c*/ IPAddress(long newAddress);
            /*0x787ead8*/ IPAddress(byte[] address, long scopeid);
            /*0x787eba0*/ IPAddress(System.ReadOnlySpan<byte> address, long scopeid);
            /*0x787ed3c*/ IPAddress(ushort* numbers, int numbersLength, uint scopeid);
            /*0x787ee10*/ IPAddress(ushort[] numbers, uint scopeid);
            /*0x787e9b4*/ bool get_IsIPv4();
            /*0x787e9c4*/ bool get_IsIPv6();
            /*0x787e9d4*/ uint get_PrivateAddress();
            /*0x787e9dc*/ void set_PrivateAddress(uint value);
            /*0x787ea10*/ uint get_PrivateScopeId();
            /*0x787ea18*/ void set_PrivateScopeId(uint value);
            /*0x787f148*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten);
            /*0x787f254*/ void WriteIPv6Bytes(System.Span<byte> destination);
            /*0x787f2e0*/ void WriteIPv4Bytes(System.Span<byte> destination);
            /*0x787f32c*/ byte[] GetAddressBytes();
            /*0x787f474*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x787f48c*/ long get_ScopeId();
            /*0x787f4dc*/ string ToString();
            /*0x787f6c8*/ bool Equals(object comparandObj, bool compareScopeId);
            /*0x787f7fc*/ bool Equals(object comparand);
            /*0x787f804*/ int GetHashCode();
            /*0x787fbf4*/ System.Net.IPAddress MapToIPv6();

            class ReadOnlyIPAddress : System.Net.IPAddress
            {
                /*0x787feac*/ ReadOnlyIPAddress(long newAddress);
            }
        }

        class IPAddressParser
        {
            static /*0x787eeec*/ System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipSpan, bool tryParse);
            static /*0x787f5a0*/ string IPv4AddressToString(uint address);
            static /*0x78801d4*/ void IPv4AddressToString(uint address, System.Text.StringBuilder destination);
            static /*0x7880138*/ int IPv4AddressToStringHelper(uint address, char* addressString);
            static /*0x787f58c*/ string IPv6AddressToString(ushort[] address, uint scopeId);
            static /*0x78802fc*/ System.Text.StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId);
            static /*0x7880244*/ void FormatIPv4AddressNumber(int number, char* addressString, ref int offset);
            static /*0x7880088*/ bool Ipv4StringToAddress(System.ReadOnlySpan<char> ipSpan, ref long address);
            static /*0x787ff10*/ bool Ipv6StringToAddress(System.ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, ref uint scope);
            static /*0x788041c*/ void AppendSections(ushort[] address, int fromInclusive, int toExclusive, System.Text.StringBuilder buffer);
            static /*0x7880604*/ void AppendHex(ushort value, System.Text.StringBuilder buffer);
            static /*0x78805d0*/ uint ExtractIPv4Address(ushort[] address);
            static /*0x788066c*/ ushort Reverse(ushort number);
        }

        class IPEndPoint : System.Net.EndPoint
        {
            static /*0x0*/ System.Net.IPEndPoint Any;
            static /*0x8*/ System.Net.IPEndPoint IPv6Any;
            /*0x10*/ System.Net.IPAddress _address;
            /*0x18*/ int _port;

            static /*0x7880c8c*/ IPEndPoint();
            /*0x78806a4*/ IPEndPoint(System.Net.IPAddress address, int port);
            /*0x7880678*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x788076c*/ System.Net.IPAddress get_Address();
            /*0x7880774*/ int get_Port();
            /*0x788077c*/ string ToString();
            /*0x788083c*/ System.Net.SocketAddress Serialize();
            /*0x78808fc*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
            /*0x7880ba8*/ bool Equals(object comparand);
            /*0x7880c5c*/ int GetHashCode();
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

            static /*0x7882cfc*/ CommandStream();
            static /*0x78820bc*/ void ReadCallback(System.IAsyncResult asyncResult);
            static /*0x788292c*/ void WriteCallback(System.IAsyncResult asyncResult);
            /*0x7880d68*/ CommandStream(System.Net.Sockets.TcpClient client);
            /*0x7880e88*/ void Abort(System.Exception e);
            /*0x78810a0*/ void Dispose(bool disposing);
            /*0x7881134*/ void InvokeRequestCallback(object obj);
            /*0x78811b4*/ bool get_RecoverableFailure();
            /*0x78811bc*/ void MarkAsRecoverableFailure();
            /*0x78811d4*/ System.IO.Stream SubmitRequest(System.Net.WebRequest request, bool isAsync, bool readInitalResponseOnConnect);
            /*0x78817ac*/ void ClearState();
            /*0x78817bc*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest request);
            /*0x78817c4*/ System.Exception GenerateException(string message, System.Net.WebExceptionStatus status, System.Exception innerException);
            /*0x7881850*/ System.Exception GenerateException(System.Net.FtpStatusCode code, string statusDescription, System.Exception innerException);
            /*0x7881254*/ void InitCommandPipeline(System.Net.WebRequest request, System.Net.CommandStream.PipelineEntry[] commands, bool isAsync);
            /*0x7881910*/ void CheckContinuePipeline();
            /*0x78812d4*/ System.IO.Stream ContinueCommandPipeline();
            /*0x78819dc*/ bool PostSendCommandProcessing(ref System.IO.Stream stream);
            /*0x7881e60*/ bool PostReadCommandProcessing(ref System.IO.Stream stream);
            /*0x78820b4*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x7882be0*/ System.Text.Encoding get_Encoding();
            /*0x7882be8*/ void set_Encoding(System.Text.Encoding value);
            /*0x7882c38*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x7881b1c*/ System.Net.ResponseDescription ReceiveCommandResponse();
            /*0x78823b8*/ void ReceiveCommandResponseCallback(System.Net.ReceiveState state, int bytesRead);

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

                /*0x7882de0*/ PipelineEntry(string command);
                /*0x7882e10*/ PipelineEntry(string command, System.Net.CommandStream.PipelineEntryFlags flags);
                /*0x78819cc*/ bool HasFlag(System.Net.CommandStream.PipelineEntryFlags flags);
            }
        }

        class ResponseDescription
        {
            /*0x10*/ bool Multiline;
            /*0x14*/ int Status;
            /*0x18*/ string StatusDescription;
            /*0x20*/ System.Text.StringBuilder StatusBuffer;
            /*0x28*/ string StatusCodeString;

            /*0x7882eb0*/ ResponseDescription();
            /*0x7882e4c*/ bool get_PositiveIntermediate();
            /*0x7882e60*/ bool get_PositiveCompletion();
            /*0x7882e74*/ bool get_TransientFailure();
            /*0x7882e88*/ bool get_PermanentFailure();
            /*0x7882e9c*/ bool get_InvalidStatusCode();
        }

        class ReceiveState
        {
            /*0x10*/ System.Net.ResponseDescription Resp;
            /*0x18*/ int ValidThrough;
            /*0x20*/ byte[] Buffer;
            /*0x28*/ System.Net.CommandStream Connection;

            /*0x7882c40*/ ReceiveState(System.Net.CommandStream connection);
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

            static /*0x7887910*/ FtpControlStream();
            static /*0x7883174*/ void AcceptCallback(System.IAsyncResult asyncResult);
            static /*0x788358c*/ void ConnectCallback(System.IAsyncResult asyncResult);
            static /*0x788373c*/ void SSLHandshakeCallback(System.IAsyncResult asyncResult);
            static /*0x78868b4*/ void GetPathInfo(System.Net.FtpControlStream.GetPathOption pathOption, System.Uri uri, ref string path, ref string directory, ref string filename);
            /*0x7883058*/ FtpControlStream(System.Net.Sockets.TcpClient client);
            /*0x7882f24*/ System.Net.NetworkCredential get_Credentials();
            /*0x7882fcc*/ void set_Credentials(System.Net.NetworkCredential value);
            /*0x78830e8*/ void AbortConnect();
            /*0x7883900*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref System.IO.Stream stream);
            /*0x7883ed8*/ void ClearState();
            /*0x7883fa8*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x7885890*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest req);
            /*0x7884834*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateDataConection(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream, ref bool isSocketReady);
            /*0x7887294*/ string FormatAddress(System.Net.IPAddress address, int Port);
            /*0x78873bc*/ string FormatAddressV6(System.Net.IPAddress address, int port);
            /*0x78874cc*/ long get_ContentLength();
            /*0x78874d4*/ System.DateTime get_LastModified();
            /*0x78874dc*/ System.Uri get_ResponseUri();
            /*0x78874e4*/ string get_BannerMessage();
            /*0x78874fc*/ string get_WelcomeMessage();
            /*0x7887514*/ string get_ExitMessage();
            /*0x7885340*/ long GetContentLengthFrom213Response(string responseString);
            /*0x7885478*/ System.DateTime GetLastModifiedFrom213Response(string str);
            /*0x7884fd4*/ void TryUpdateResponseUri(string str, System.Net.FtpWebRequest request);
            /*0x7884edc*/ void TryUpdateContentLength(string str);
            /*0x7885800*/ string GetLoginDirectory(string str);
            /*0x7886df4*/ int GetPortV4(string responseString);
            /*0x7886fd0*/ int GetPortV6(string responseString);
            /*0x7886a88*/ void CreateFtpListenerSocket(System.Net.FtpWebRequest request);
            /*0x7886c0c*/ string GetPortCommandLine(System.Net.FtpWebRequest request);
            /*0x7886790*/ string FormatFtpCommand(string command, string parameter);
            /*0x7887188*/ System.Net.Sockets.Socket CreateFtpDataSocket(System.Net.FtpWebRequest request, System.Net.Sockets.Socket templateSocket);
            /*0x788752c*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x7883bc8*/ System.Net.TriState IsFtpDataStreamWriteable();

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

                /*0x788482c*/ <>c__DisplayClass31_0();
                /*0x7887a40*/ void <PipelineCallback>b__0(System.IAsyncResult ar);
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

            /*0x7883c4c*/ FtpDataStream(System.Net.Sockets.NetworkStream networkStream, System.Net.FtpWebRequest request, System.Net.TriState writeOnly);
            /*0x7887b4c*/ void Dispose(bool disposing);
            /*0x7887cd4*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x78880bc*/ void CheckError();
            /*0x78880fc*/ bool get_CanRead();
            /*0x7888104*/ bool get_CanSeek();
            /*0x7888124*/ bool get_CanWrite();
            /*0x788812c*/ long get_Length();
            /*0x788814c*/ long get_Position();
            /*0x7888170*/ void set_Position(long value);
            /*0x7888194*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x7888260*/ int Read(byte[] buffer, int offset, int size);
            /*0x7888364*/ void Write(byte[] buffer, int offset, int size);
            /*0x788843c*/ void AsyncReadCallback(System.IAsyncResult ar);
            /*0x78886d8*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x7888870*/ int EndRead(System.IAsyncResult ar);
            /*0x7888a04*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x7888af8*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x7888b98*/ void Flush();
            /*0x7888bbc*/ void SetLength(long value);
            /*0x7888be0*/ bool get_CanTimeout();
            /*0x7888c00*/ int get_ReadTimeout();
            /*0x7888c24*/ void set_ReadTimeout(int value);
            /*0x7888c48*/ int get_WriteTimeout();
            /*0x7888c6c*/ void set_WriteTimeout(int value);
            /*0x7888c90*/ void SetSocketTimeoutOption(int timeout);
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

            static /*0x7888e98*/ FtpMethodInfo();
            static /*0x7888d38*/ System.Net.FtpMethodInfo GetMethodInfo(string method);
            /*0x7888ce0*/ FtpMethodInfo(string method, System.Net.FtpOperation operation, System.Net.FtpMethodFlags flags, string httpCommand);
            /*0x78868a4*/ bool HasFlag(System.Net.FtpMethodFlags flags);
            /*0x7886a78*/ bool get_IsCommandOnly();
            /*0x78878f8*/ bool get_IsUpload();
            /*0x7887904*/ bool get_IsDownload();
            /*0x7884fc8*/ bool get_ShouldParseForResponseUri();
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

            static /*0x788ef24*/ FtpWebRequest();
            /*0x7889874*/ FtpWebRequest(System.Uri uri);
            /*0x788948c*/ System.Net.FtpMethodInfo get_MethodInfo();
            /*0x7889494*/ string get_Method();
            /*0x78894b0*/ void set_Method(string value);
            /*0x7889674*/ string get_RenameTo();
            /*0x788967c*/ System.Net.ICredentials get_Credentials();
            /*0x7889684*/ void set_Credentials(System.Net.ICredentials value);
            /*0x78897d0*/ System.Uri get_RequestUri();
            /*0x78897d8*/ int get_Timeout();
            /*0x78897e0*/ int get_RemainingTimeout();
            /*0x78897e8*/ int get_ReadWriteTimeout();
            /*0x78897f0*/ long get_ContentOffset();
            /*0x78897f8*/ long get_ContentLength();
            /*0x7889800*/ System.Net.IWebProxy get_Proxy();
            /*0x7889808*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x788986c*/ bool get_Aborted();
            /*0x7889c9c*/ System.Net.WebResponse GetResponse();
            /*0x788b70c*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x788bde0*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x788c1e0*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x788c728*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x788a900*/ void SubmitRequest(bool isAsync);
            /*0x788d4ac*/ System.Exception TranslateConnectException(System.Exception e);
            /*0x788cb8c*/ void CreateConnectionAsync();
            /*0x788cc38*/ System.Net.FtpControlStream CreateConnection();
            /*0x788cdec*/ System.IO.Stream TimedSubmitRequestHelper(bool isAsync);
            /*0x788d62c*/ void TimerCallback(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            /*0x788d5ac*/ System.Net.TimerThread.Queue get_TimerQueue();
            /*0x788d218*/ bool AttemptedRecovery(System.Exception e);
            /*0x788b348*/ void SetException(System.Exception exception);
            /*0x788a430*/ void CheckError();
            /*0x78811a4*/ void RequestCallback(object obj);
            /*0x788e214*/ void SyncRequestCallback(object obj);
            /*0x788d770*/ void AsyncRequestCallback(object obj);
            /*0x788a4bc*/ System.Net.FtpWebRequest.RequestStage FinishRequestStage(System.Net.FtpWebRequest.RequestStage stage);
            /*0x788e608*/ void Abort();
            /*0x788eaac*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x788eb10*/ bool get_UseBinary();
            /*0x788eb18*/ bool get_UsePassive();
            /*0x7883ddc*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x788eb20*/ bool get_EnableSsl();
            /*0x788eb28*/ System.Net.WebHeaderCollection get_Headers();
            /*0x788ebf8*/ bool get_UseDefaultCredentials();
            /*0x788965c*/ bool get_InUse();
            /*0x788ae44*/ void EnsureFtpWebResponse(System.Exception exception);
            /*0x788eea8*/ void DataStreamClosed(System.Net.CloseExState closeState);

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

                /*0x788f0a4*/ void MoveNext();
                /*0x788f3e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c
            {
                static /*0x0*/ System.Net.FtpWebRequest.<> <>9;
                static /*0x8*/ System.Func<System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0;

                static /*0x788f3f4*/ <>c();
                /*0x788f45c*/ <>c();
                /*0x788f464*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <get_ClientCertificates>b__114_0();
            }
        }

        class FtpWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x788f4b8*/ FtpWebRequestCreator();
            /*0x788f4c0*/ System.Net.WebRequest Create(System.Uri uri);
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

            /*0x788ed44*/ FtpWebResponse(System.IO.Stream responseStream, long contentLength, System.Uri responseUri, System.Net.FtpStatusCode statusCode, string statusLine, System.DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage);
            /*0x788d738*/ void UpdateStatus(System.Net.FtpStatusCode statusCode, string statusLine, string exitMessage);
            /*0x788f518*/ System.IO.Stream GetResponseStream();
            /*0x788ec9c*/ void SetResponseStream(System.IO.Stream stream);
            /*0x788f620*/ void Close();
            /*0x788f704*/ System.Net.WebHeaderCollection get_Headers();
            /*0x788f81c*/ System.Uri get_ResponseUri();
            /*0x788f824*/ System.Net.FtpStatusCode get_StatusCode();

            class EmptyStream : System.IO.MemoryStream
            {
                /*0x788f584*/ EmptyStream();
            }
        }

        class NetworkStreamWrapper : System.IO.Stream
        {
            /*0x28*/ System.Net.Sockets.TcpClient _client;
            /*0x30*/ System.Net.Sockets.NetworkStream _networkStream;

            /*0x7880df0*/ NetworkStreamWrapper(System.Net.Sockets.TcpClient client);
            /*0x7883d60*/ bool get_UsingSecureStream();
            /*0x78834e4*/ System.Net.IPAddress get_ServerAddress();
            /*0x7885324*/ System.Net.Sockets.Socket get_Socket();
            /*0x788f82c*/ System.Net.Sockets.NetworkStream get_NetworkStream();
            /*0x788f834*/ void set_NetworkStream(System.Net.Sockets.NetworkStream value);
            /*0x788f83c*/ bool get_CanRead();
            /*0x788f85c*/ bool get_CanSeek();
            /*0x788f87c*/ bool get_CanWrite();
            /*0x788f89c*/ bool get_CanTimeout();
            /*0x788f8bc*/ int get_ReadTimeout();
            /*0x788f8e0*/ void set_ReadTimeout(int value);
            /*0x788f904*/ int get_WriteTimeout();
            /*0x788f928*/ void set_WriteTimeout(int value);
            /*0x788f94c*/ long get_Length();
            /*0x788f96c*/ long get_Position();
            /*0x788f990*/ void set_Position(long value);
            /*0x788f9b4*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x788f9d8*/ int Read(byte[] buffer, int offset, int size);
            /*0x788f9fc*/ void Write(byte[] buffer, int offset, int size);
            /*0x788fa20*/ void Dispose(bool disposing);
            /*0x7882380*/ void CloseSocket();
            /*0x7881070*/ void Close(int timeout);
            /*0x788facc*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x788faf0*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x788fb14*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x788fb38*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x788fb5c*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x788fb80*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x788fba4*/ void Flush();
            /*0x788fbc8*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x788fbec*/ void SetLength(long value);
            /*0x788cd9c*/ void SetSocketTimeoutOption(int timeout);
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

            /*0x788fc10*/ Authorization(string token);
            /*0x788fcbc*/ Authorization(string token, bool finished);
            /*0x788fd58*/ string get_Message();
            /*0x788fd60*/ bool get_Complete();
        }

        class CredentialCache
        {
            static /*0x788fd68*/ System.Net.ICredentials get_DefaultCredentials();
            static /*0x788fdc0*/ System.Net.NetworkCredential get_DefaultNetworkCredentials();
        }

        class SystemNetworkCredential : System.Net.NetworkCredential
        {
            static /*0x0*/ System.Net.SystemNetworkCredential defaultCredential;

            static /*0x788fe38*/ SystemNetworkCredential();
            /*0x788fe18*/ SystemNetworkCredential();
        }

        class EndPoint
        {
            /*0x7880764*/ EndPoint();
            /*0x788feb8*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x788ff5c*/ System.Net.SocketAddress Serialize();
            /*0x7890000*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
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
            /*0x3814c14*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            /*0x3814b90*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
            /*0x38148bc*/ string get_AuthenticationType();
        }

        interface ICertificatePolicy
        {
            bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
        }

        interface ICredentials
        {
            /*0x3814b90*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class IPHostEntry
        {
            /*0x10*/ string hostName;
            /*0x18*/ string[] aliases;
            /*0x20*/ System.Net.IPAddress[] addressList;
            /*0x28*/ bool isTrustedHost;

            /*0x789004c*/ IPHostEntry();
            /*0x7890024*/ string get_HostName();
            /*0x789002c*/ void set_HostName(string value);
            /*0x7890034*/ void set_Aliases(string[] value);
            /*0x789003c*/ System.Net.IPAddress[] get_AddressList();
            /*0x7890044*/ void set_AddressList(System.Net.IPAddress[] value);
        }

        interface IWebRequestCreate
        {
            /*0x3814a3c*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class InternalException : System.SystemException
        {
            /*0x78819c4*/ InternalException();
        }

        class NclUtilities
        {
            static /*0x0*/ System.Net.IPAddress[] _LocalAddresses;
            static /*0x8*/ object _LocalAddressesLock;
            static /*0x10*/ string _LocalDomainName;

            static /*0x789005c*/ bool IsFatal(System.Exception exception);
            static /*0x789011c*/ bool IsAddressLocal(System.Net.IPAddress ipAddress);
            static /*0x789068c*/ System.Net.IPHostEntry GetLocalHost();
            static /*0x78901a8*/ System.Net.IPAddress[] get_LocalAddresses();
            static /*0x78906a4*/ object get_LocalAddressesLock();
        }

        class ValidationHelper
        {
            static /*0x0*/ string[] EmptyArray;
            static /*0x8*/ char[] InvalidMethodChars;
            static /*0x10*/ char[] InvalidParamChars;

            static /*0x7890768*/ ValidationHelper();
            static /*0x788fca8*/ string MakeStringNull(string stringValue);
            static /*0x7890740*/ bool IsBlankString(string stringValue);
            static /*0x789075c*/ bool ValidateTcpPort(int port);
        }

        class ExceptionHelper
        {
            static /*0x788ff80*/ System.NotImplementedException get_MethodNotImplementedException();
            static /*0x788fedc*/ System.NotImplementedException get_PropertyNotImplementedException();
            static /*0x788a444*/ System.Net.WebException get_TimeoutException();
            static /*0x788ec1c*/ System.NotSupportedException get_PropertyNotSupportedException();
            static /*0x7887204*/ System.Net.WebException get_RequestAbortedException();
        }

        class WebRequestPrefixElement
        {
            /*0x10*/ string Prefix;
            /*0x18*/ System.Net.IWebRequestCreate creator;
            /*0x20*/ System.Type creatorType;

            /*0x7890a98*/ WebRequestPrefixElement(string P, System.Net.IWebRequestCreate C);
            /*0x7890888*/ System.Net.IWebRequestCreate get_Creator();
            /*0x7890a90*/ void set_Creator(System.Net.IWebRequestCreate value);
        }

        class HttpContinueDelegate : System.MulticastDelegate
        {
            /*0x7890adc*/ HttpContinueDelegate(object object, nint method);
            /*0x7890b7c*/ void Invoke(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
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

            static /*0x7890bf4*/ KnownHttpVerb();
            static /*0x7890fa4*/ System.Net.KnownHttpVerb Parse(string name);
            /*0x7890b90*/ KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse);
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

            /*0x7889c84*/ NetworkCredential(string userName, string password);
            /*0x788f040*/ NetworkCredential(string userName, string password, string domain);
            /*0x7886888*/ string get_UserName();
            /*0x7891074*/ void set_UserName(string value);
            /*0x7886898*/ string get_Password();
            /*0x7891094*/ void set_Password(string value);
            /*0x7886890*/ string get_Domain();
            /*0x78910bc*/ void set_Domain(string value);
            /*0x78910e8*/ string InternalGetUserName();
            /*0x78910dc*/ string InternalGetPassword();
            /*0x78910f0*/ string InternalGetDomain();
            /*0x78910f8*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x78910fc*/ ProtocolViolationException();
            /*0x788c720*/ ProtocolViolationException(string message);
            /*0x7891104*/ ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x789110c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7891114*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class SocketAddress
        {
            /*0x10*/ int m_Size;
            /*0x18*/ byte[] m_Buffer;
            /*0x20*/ bool m_changed;
            /*0x24*/ int m_hash;

            /*0x7891198*/ SocketAddress(System.Net.Sockets.AddressFamily family, int size);
            /*0x78912c4*/ SocketAddress(System.Net.IPAddress ipAddress);
            /*0x78808a0*/ SocketAddress(System.Net.IPAddress ipaddress, int port);
            /*0x7880ae0*/ System.Net.Sockets.AddressFamily get_Family();
            /*0x789111c*/ int get_Size();
            /*0x7891124*/ byte get_Item(int offset);
            /*0x789151c*/ System.Net.IPAddress GetIPAddress();
            /*0x7880b10*/ System.Net.IPEndPoint GetIPEndPoint();
            /*0x7891700*/ bool Equals(object comparand);
            /*0x78917ec*/ int GetHashCode();
            /*0x789191c*/ string ToString();
        }

        class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x8c*/ System.Net.WebExceptionStatus m_Status;
            /*0x90*/ System.Net.WebResponse m_Response;
            /*0x98*/ System.Net.WebExceptionInternalStatus m_InternalStatus;

            /*0x7891bac*/ WebException();
            /*0x78820a0*/ WebException(string message);
            /*0x788d728*/ WebException(string message, System.Exception innerException);
            /*0x7883578*/ WebException(string message, System.Net.WebExceptionStatus status);
            /*0x7891bbc*/ WebException(string message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException);
            /*0x788183c*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x7891bf0*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x7891bd8*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x7891cd8*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x7891dd4*/ WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7891de4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7891df0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7891df8*/ System.Net.WebExceptionStatus get_Status();
            /*0x7891e00*/ System.Net.WebResponse get_Response();
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

            static /*0x7891fa4*/ WebExceptionMapping();
            static /*0x7891e08*/ string GetWebStatusString(System.Net.WebExceptionStatus status);
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

            static /*0x78941e4*/ WebHeaderCollection();
            static /*0x78921d8*/ bool AllowMultiValues(string name);
            static /*0x78924b8*/ string CheckBadChars(string name, bool isHeaderValue);
            static /*0x7892848*/ bool ContainsNonAsciiChars(string token);
            static /*0x789369c*/ string GetAsString(System.Collections.Specialized.NameValueCollection cc, bool winInetCompat, bool forTrace);
            /*0x788eb94*/ WebHeaderCollection();
            /*0x789393c*/ WebHeaderCollection(System.Net.WebHeaderCollectionType type);
            /*0x7893a38*/ WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7892018*/ void NormalizeCommonHeaders();
            /*0x7892130*/ System.Collections.Specialized.NameValueCollection get_InnerCollection();
            /*0x7892284*/ bool get_AllowHttpRequestHeader();
            /*0x78922c4*/ void Remove(System.Net.HttpRequestHeader header);
            /*0x78923b4*/ void AddInternal(string name, string value);
            /*0x7892408*/ void ChangeInternal(string name, string value);
            /*0x789245c*/ void RemoveInternal(string name);
            /*0x78928cc*/ void ThrowOnRestrictedHeader(string headerName);
            /*0x7892a40*/ void Add(string name, string value);
            /*0x7892bf0*/ void Add(string header);
            /*0x7892ec0*/ void Set(string name, string value);
            /*0x78930e8*/ void SetInternal(string name, string value);
            /*0x7893304*/ void Remove(string name);
            /*0x789343c*/ string[] GetValues(string header);
            /*0x7893640*/ string ToString();
            /*0x7893c04*/ void OnDeserialization(object sender);
            /*0x7893c08*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7893d88*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7893d94*/ string Get(string name);
            /*0x78940c0*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7894134*/ int get_Count();
            /*0x7894164*/ string Get(int index);
            /*0x78941a4*/ string GetKey(int index);

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

            static /*0x7894c74*/ CaseInsensitiveAscii();
            /*0x7894c6c*/ CaseInsensitiveAscii();
            /*0x7894798*/ int GetHashCode(object myObject);
            /*0x78948a4*/ int Compare(object firstObject, object secondObject);
            /*0x7894a08*/ int FastGetHashCode(string myString);
            /*0x7894af8*/ bool Equals(object firstObject, object secondObject);
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

            static /*0x7895f20*/ WebRequest();
            static /*0x7894d3c*/ object get_InternalSyncObject();
            static /*0x7894e08*/ System.Net.WebRequest Create(System.Uri requestUri, bool useUriBase);
            static /*0x7895214*/ System.Net.WebRequest Create(string requestUriString);
            static /*0x78952e4*/ System.Net.WebRequest Create(System.Uri requestUri);
            static /*0x7895078*/ System.Collections.ArrayList get_PrefixList();
            static /*0x78953bc*/ System.Collections.ArrayList PopulatePrefixList();
            static /*0x7895ca0*/ System.Net.IWebProxy get_InternalDefaultWebProxy();
            static /*0x7895e70*/ System.Net.IWebProxy GetSystemWebProxy();
            static /*0x7895ebc*/ System.Net.IWebProxy InternalGetSystemWebProxy();
            /*0x78955e4*/ WebRequest();
            /*0x7895608*/ WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7895610*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x789561c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7895620*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x7895624*/ void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy);
            /*0x78956f4*/ string get_Method();
            /*0x789571c*/ void set_Method(string value);
            /*0x7895744*/ System.Uri get_RequestUri();
            /*0x789576c*/ System.Net.WebHeaderCollection get_Headers();
            /*0x7895794*/ long get_ContentLength();
            /*0x78957bc*/ System.Net.ICredentials get_Credentials();
            /*0x78957e4*/ void set_Credentials(System.Net.ICredentials value);
            /*0x789580c*/ bool get_UseDefaultCredentials();
            /*0x7895834*/ System.Net.IWebProxy get_Proxy();
            /*0x789585c*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x7895884*/ int get_Timeout();
            /*0x78958ac*/ System.Net.WebResponse GetResponse();
            /*0x78958d4*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x78958fc*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x7895924*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x789594c*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x7895974*/ System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync();
            /*0x7895c18*/ System.Security.Principal.WindowsIdentity SafeCaptureIdenity();
            /*0x7895c68*/ void Abort();
            /*0x7895c90*/ System.Net.Cache.RequestCacheProtocol get_CacheProtocol();
            /*0x7895c98*/ void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value);
            /*0x7896224*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0();

            class DesignerWebRequestCreate : System.Net.IWebRequestCreate
            {
                /*0x789621c*/ DesignerWebRequestCreate();
                /*0x7896318*/ System.Net.WebRequest Create(System.Uri uri);
            }

            class <>c__DisplayClass79_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x7895c10*/ <>c__DisplayClass79_0();
                /*0x789636c*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1();
            }
        }

        class WebResponse : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x18*/ bool m_IsFromCache;

            /*0x7896704*/ WebResponse();
            /*0x789670c*/ WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7896714*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7896720*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x7896724*/ void Close();
            /*0x7896728*/ void Dispose();
            /*0x7896794*/ void Dispose(bool disposing);
            /*0x7896820*/ bool get_IsFromCache();
            /*0x7896828*/ System.IO.Stream GetResponseStream();
            /*0x7896850*/ System.Uri get_ResponseUri();
            /*0x7896878*/ System.Net.WebHeaderCollection get_Headers();
        }

        class BufferOffsetSize
        {
            /*0x10*/ byte[] Buffer;
            /*0x18*/ int Offset;
            /*0x1c*/ int Size;

            /*0x78968a0*/ BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer);
            /*0x7896958*/ BufferOffsetSize(byte[] buffer, bool copyBuffer);
        }

        class HeaderParser : System.MulticastDelegate
        {
            /*0x7896978*/ HeaderParser(object object, nint method);
            /*0x7896a28*/ string[] Invoke(string value);
        }

        class HeaderInfo
        {
            /*0x10*/ bool IsRequestRestricted;
            /*0x11*/ bool IsResponseRestricted;
            /*0x18*/ System.Net.HeaderParser Parser;
            /*0x20*/ string HeaderName;
            /*0x28*/ bool AllowMultiValues;

            /*0x7896a3c*/ HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, System.Net.HeaderParser p);
        }

        class HeaderInfoTable
        {
            static /*0x0*/ System.Collections.Hashtable HeaderHashTable;
            static /*0x8*/ System.Net.HeaderInfo UnknownHeaderInfo;
            static /*0x10*/ System.Net.HeaderParser SingleParser;
            static /*0x18*/ System.Net.HeaderParser MultiParser;

            static /*0x7896d28*/ HeaderInfoTable();
            static /*0x7896aac*/ string[] ParseSingleValue(string value);
            static /*0x7896b24*/ string[] ParseMultiValue(string value);
            /*0x78988d8*/ HeaderInfoTable();
            /*0x78987fc*/ System.Net.HeaderInfo get_Item(string name);
        }

        enum CloseExState
        {
            Normal = 0,
            Abort = 1,
            Silent = 2,
        }

        interface ICloseEx
        {
            /*0x3815ed0*/ void CloseEx(System.Net.CloseExState closeState);
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

            static /*0x78988e0*/ System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext();
            /*0x789897c*/ LazyAsyncResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x7898a38*/ object get_AsyncObject();
            /*0x7898a40*/ object get_AsyncState();
            /*0x7898a48*/ System.AsyncCallback get_AsyncCallback();
            /*0x7898a50*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x7898af4*/ bool LazilyCreateEvent(ref System.Threading.ManualResetEvent waitHandle);
            /*0x7898cdc*/ bool get_CompletedSynchronously();
            /*0x7898d0c*/ bool get_IsCompleted();
            /*0x7898ccc*/ bool get_InternalPeekCompleted();
            /*0x7898d3c*/ bool get_EndCalled();
            /*0x7898d44*/ void set_EndCalled(bool value);
            /*0x7898d50*/ void ProtectedInvokeCallback(object result, nint userToken);
            /*0x7898f40*/ void InvokeCallback(object result);
            /*0x7898f48*/ void InvokeCallback();
            /*0x7898f54*/ void Complete(nint userToken);
            /*0x78990dc*/ void WorkerThreadComplete(object state);
            /*0x7899188*/ void Cleanup();
            /*0x789918c*/ object InternalWaitForCompletion();
            /*0x7899194*/ object WaitForCompletion(bool snap);

            class ThreadContext
            {
                /*0x10*/ int m_NestedIOCount;

                /*0x7898974*/ ThreadContext();
            }
        }

        class NetRes
        {
            static /*0x789948c*/ string GetWebStatusString(string Res, System.Net.WebExceptionStatus Status);
            static /*0x789954c*/ string GetWebStatusString(System.Net.WebExceptionStatus Status);
            static /*0x78995ac*/ string GetWebStatusCodeString(System.Net.FtpStatusCode statusCode, string statusDescription);
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

            static /*0x789978c*/ TimerThread();
            static /*0x7895fdc*/ System.Net.TimerThread.Queue CreateQueue(int durationMilliseconds);
            static /*0x7899b38*/ System.Net.TimerThread.Queue GetOrCreateQueue(int durationMilliseconds);
            static /*0x789a484*/ void Prod();
            static /*0x789a594*/ void ThreadProc();
            static /*0x789af00*/ void StopTimerThread();
            static /*0x789aedc*/ bool IsTickBetween(int start, int end, int comparand);
            static /*0x789af7c*/ void OnDomainUnload(object sender, System.EventArgs e);

            class Queue
            {
                /*0x10*/ int m_DurationMilliseconds;

                /*0x789b040*/ Queue(int durationMilliseconds);
                /*0x789b068*/ int get_Duration();
                /*0x3814b90*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class Timer : System.IDisposable
            {
                /*0x10*/ int m_StartTimeMilliseconds;
                /*0x14*/ int m_DurationMilliseconds;

                /*0x789b070*/ Timer(int durationMilliseconds);
                /*0x789b0a4*/ int get_StartTime();
                /*0x789b0ac*/ int get_Expiration();
                /*0x3813ffc*/ bool Cancel();
                /*0x3813ffc*/ bool get_HasExpired();
                /*0x789b0b8*/ void Dispose();
            }

            class Callback : System.MulticastDelegate
            {
                /*0x789b0c4*/ Callback(object object, nint method);
                /*0x789b1d0*/ void Invoke(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            }

            class TimerQueue : System.Net.TimerThread.Queue
            {
                /*0x18*/ nint m_ThisHandle;
                /*0x20*/ System.Net.TimerThread.TimerNode m_Timers;

                /*0x7899a78*/ TimerQueue(int durationMilliseconds);
                /*0x789b214*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
                /*0x789ad60*/ bool Fire(ref int nextExpiration);
            }

            class InfiniteTimerQueue : System.Net.TimerThread.Queue
            {
                /*0x7899a58*/ InfiniteTimerQueue();
                /*0x789b77c*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class TimerNode : System.Net.TimerThread.Timer
            {
                /*0x18*/ System.Net.TimerThread.TimerNode.TimerState m_TimerState;
                /*0x20*/ System.Net.TimerThread.Callback m_Callback;
                /*0x28*/ object m_Context;
                /*0x30*/ object m_QueueLock;
                /*0x38*/ System.Net.TimerThread.TimerNode next;
                /*0x40*/ System.Net.TimerThread.TimerNode prev;

                /*0x789b434*/ TimerNode(System.Net.TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock);
                /*0x789b1e4*/ TimerNode();
                /*0x789b810*/ bool get_HasExpired();
                /*0x789b820*/ System.Net.TimerThread.TimerNode get_Next();
                /*0x789b828*/ void set_Next(System.Net.TimerThread.TimerNode value);
                /*0x789b830*/ System.Net.TimerThread.TimerNode get_Prev();
                /*0x789b838*/ void set_Prev(System.Net.TimerThread.TimerNode value);
                /*0x789b840*/ bool Cancel();
                /*0x789b4b0*/ bool Fire();

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

                /*0x789b7e4*/ InfiniteTimer();
                /*0x789b9a8*/ bool get_HasExpired();
                /*0x789b9b0*/ bool Cancel();
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

            static /*0x789d740*/ Cookie();
            static /*0x789bf4c*/ bool IsDomainEqualToHost(string domain, string host);
            static /*0x789ca38*/ bool DomainCharsTest(string name);
            static /*0x789d184*/ System.Collections.IComparer GetComparer();
            /*0x789b9d4*/ Cookie();
            /*0x789bb18*/ string get_Comment();
            /*0x789bb20*/ void set_Comment(string value);
            /*0x789bb40*/ void set_CommentUri(System.Uri value);
            /*0x789bb48*/ void set_HttpOnly(bool value);
            /*0x789bb54*/ void set_Discard(bool value);
            /*0x789bb60*/ string get_Domain();
            /*0x789bb68*/ void set_Domain(string value);
            /*0x789bbc4*/ string get__Domain();
            /*0x789bc9c*/ bool get_Expired();
            /*0x789bd54*/ void set_Expires(System.DateTime value);
            /*0x789bd5c*/ string get_Name();
            /*0x789bd64*/ bool InternalSetName(string value);
            /*0x789be74*/ string get_Path();
            /*0x789be7c*/ void set_Path(string value);
            /*0x789bebc*/ string get__Path();
            /*0x789bc8c*/ bool get_Plain();
            /*0x789bfa4*/ bool VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow);
            /*0x789cb84*/ void set_Port(string value);
            /*0x789cecc*/ int[] get_PortList();
            /*0x789ced4*/ string get__Port();
            /*0x789cf98*/ bool get_Secure();
            /*0x789cfa0*/ void set_Secure(bool value);
            /*0x789cfac*/ string get_Value();
            /*0x789cfb4*/ void set_Value(string value);
            /*0x789cfe4*/ System.Net.CookieVariant get_Variant();
            /*0x789cfec*/ string get_DomainKey();
            /*0x789d008*/ int get_Version();
            /*0x789d010*/ void set_Version(int value);
            /*0x789d084*/ string get__Version();
            /*0x789d1dc*/ bool Equals(object comparand);
            /*0x789d2ac*/ int GetHashCode();
            /*0x789d498*/ string ToString();
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

            static /*0x789dfa4*/ CookieTokenizer();
            /*0x789d8b4*/ CookieTokenizer(string tokenStream);
            /*0x789d8f4*/ bool get_EndOfCookie();
            /*0x789d8fc*/ void set_EndOfCookie(bool value);
            /*0x789d908*/ bool get_Eof();
            /*0x789d918*/ string get_Name();
            /*0x789d920*/ void set_Name(string value);
            /*0x789d928*/ bool get_Quoted();
            /*0x789d930*/ void set_Quoted(bool value);
            /*0x789d93c*/ System.Net.CookieToken get_Token();
            /*0x789d944*/ void set_Token(System.Net.CookieToken value);
            /*0x789d94c*/ string get_Value();
            /*0x789d954*/ void set_Value(string value);
            /*0x789d95c*/ string Extract();
            /*0x789d9b8*/ System.Net.CookieToken FindNext(bool ignoreComma, bool ignoreEquals);
            /*0x789dc3c*/ System.Net.CookieToken Next(bool first, bool parseResponseCookies);
            /*0x789dd68*/ void Reset();
            /*0x789ddc4*/ System.Net.CookieToken TokenFromName(bool parseResponseCookies);

            struct RecognizedAttribute
            {
                /*0x10*/ string m_name;
                /*0x18*/ System.Net.CookieToken m_token;

                /*0x789e554*/ RecognizedAttribute(string name, System.Net.CookieToken token);
                /*0x789e57c*/ System.Net.CookieToken get_Token();
                /*0x789df80*/ bool IsEqualTo(string value);
            }
        }

        class CookieParser
        {
            /*0x10*/ System.Net.CookieTokenizer m_tokenizer;

            static /*0x789caec*/ string CheckQuoted(string value);
            /*0x789e584*/ CookieParser(string cookieString);
            /*0x789e5fc*/ System.Net.Cookie Get();
        }

        class Comparer : System.Collections.IComparer
        {
            /*0x789d8ac*/ Comparer();
            /*0x789eb50*/ int System.Collections.IComparer.Compare(object ol, object or);
        }

        class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ int m_version;
            /*0x18*/ System.Collections.ArrayList m_list;
            /*0x20*/ System.DateTime m_TimeStamp;
            /*0x28*/ bool m_has_other_versions;
            /*0x29*/ bool m_IsReadOnly;

            /*0x789ec34*/ CookieCollection();
            /*0x789ece8*/ System.Net.Cookie get_Item(int index);
            /*0x789edd0*/ void Add(System.Net.Cookie cookie);
            /*0x789f240*/ void Add(System.Net.CookieCollection cookies);
            /*0x789f594*/ int get_Count();
            /*0x789f5b8*/ bool get_IsSynchronized();
            /*0x789f5c0*/ object get_SyncRoot();
            /*0x789f5c4*/ void CopyTo(System.Array array, int index);
            /*0x789f5e8*/ System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how);
            /*0x789f6b8*/ bool get_IsOtherVersionSeen();
            /*0x789f6c0*/ int InternalAdd(System.Net.Cookie cookie, bool isStrict);
            /*0x789ee90*/ int IndexOf(System.Net.Cookie cookie);
            /*0x789fb74*/ void RemoveAt(int idx);
            /*0x789f53c*/ System.Collections.IEnumerator GetEnumerator();

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

                /*0x789fb98*/ CookieCollectionEnumerator(System.Net.CookieCollection cookies);
                /*0x789fc00*/ object System.Collections.IEnumerator.get_Current();
                /*0x789fca4*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x789fd40*/ void System.Collections.IEnumerator.Reset();
            }
        }

        struct HeaderVariantInfo
        {
            /*0x10*/ string m_name;
            /*0x18*/ System.Net.CookieVariant m_variant;

            /*0x789fd4c*/ HeaderVariantInfo(string name, System.Net.CookieVariant variant);
            /*0x789fd74*/ string get_Name();
            /*0x789fd7c*/ System.Net.CookieVariant get_Variant();
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

            static /*0x78a41e0*/ CookieContainer();
            /*0x789fd84*/ CookieContainer();
            /*0x789fe94*/ void AddRemoveDomain(string key, System.Net.PathList value);
            /*0x789ffbc*/ void Add(System.Net.Cookie cookie, bool throwOnError);
            /*0x78a0e24*/ bool AgeCookies(string domain);
            /*0x78a2380*/ int ExpireCollection(System.Net.CookieCollection cc);
            /*0x78a2510*/ bool IsLocalDomain(string host);
            /*0x78a27b0*/ System.Net.CookieCollection CookieCutter(System.Uri uri, string headerName, string setCookieHeader, bool isThrow);
            /*0x78a2e88*/ System.Net.CookieCollection InternalGetCookies(System.Uri uri);
            /*0x78a3338*/ void BuildCookieCollectionFromDomainMatches(System.Uri uri, bool isSecure, int port, System.Net.CookieCollection cookies, System.Collections.Generic.List<string> domainAttribute, bool matchOnlyPlainCookie);
            /*0x78a3b70*/ void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, int port, bool isSecure, bool isPlainOnly);
            /*0x78a3d7c*/ string GetCookieHeader(System.Uri uri);
            /*0x78a3e48*/ string GetCookieHeader(System.Uri uri, ref string optCookie2);
        }

        class PathList
        {
            /*0x10*/ System.Collections.SortedList m_list;

            /*0x78a07e0*/ PathList();
            /*0x78a24ec*/ int get_Count();
            /*0x78a088c*/ int GetCookiesCount();
            /*0x78a235c*/ System.Collections.ICollection get_Values();
            /*0x78a0d00*/ object get_Item(string s);
            /*0x78a0d24*/ void set_Item(string s, object value);
            /*0x78a3b4c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x78a0cdc*/ object get_SyncRoot();

            class PathListComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.Net.PathList.PathListComparer StaticInstance;

                static /*0x78a446c*/ PathListComparer();
                /*0x78a4464*/ PathListComparer();
                /*0x78a4308*/ int System.Collections.IComparer.Compare(object ol, object or);
            }
        }

        class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
        {
            /*0x78a44d4*/ CookieException();
            /*0x789ca30*/ CookieException(string message);
            /*0x78a2354*/ CookieException(string message, System.Exception inner);
            /*0x78a44dc*/ CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a44e4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a44ec*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

            static /*0x78a6c0c*/ FileWebRequest();
            static /*0x78a5e7c*/ void GetRequestStreamCallback(object state);
            static /*0x78a6140*/ void GetResponseCallback(object state);
            /*0x78a44f4*/ FileWebRequest(System.Uri uri);
            /*0x78a4688*/ FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a4a98*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a4aa4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a4d28*/ bool get_Aborted();
            /*0x78a4d38*/ long get_ContentLength();
            /*0x78a4d40*/ System.Net.ICredentials get_Credentials();
            /*0x78a4d48*/ void set_Credentials(System.Net.ICredentials value);
            /*0x78a4d50*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78a4d58*/ string get_Method();
            /*0x78a4d60*/ void set_Method(string value);
            /*0x78a4e3c*/ System.Net.IWebProxy get_Proxy();
            /*0x78a4e44*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x78a4e4c*/ int get_Timeout();
            /*0x78a4e54*/ System.Uri get_RequestUri();
            /*0x78a4e5c*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x78a5280*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x78a520c*/ bool CanGetRequestStream();
            /*0x78a5554*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x78a5840*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x78a5b2c*/ System.Net.WebResponse GetResponse();
            /*0x78a676c*/ void UnblockReader();
            /*0x78a6844*/ bool get_UseDefaultCredentials();
            /*0x78a686c*/ void Abort();
        }

        class FileWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x78955dc*/ FileWebRequestCreator();
            /*0x78a6cf0*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FileWebStream : System.IO.FileStream, System.Net.ICloseEx
        {
            /*0x70*/ System.Net.FileWebRequest m_request;

            /*0x78a609c*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing);
            /*0x78a6d48*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, int length, bool async);
            /*0x78a6e04*/ void Dispose(bool disposing);
            /*0x78a6eb4*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x78a6ef0*/ int Read(byte[] buffer, int offset, int size);
            /*0x78a7034*/ void Write(byte[] buffer, int offset, int size);
            /*0x78a70fc*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x78a71dc*/ int EndRead(System.IAsyncResult ar);
            /*0x78a727c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x78a735c*/ void EndWrite(System.IAsyncResult ar);
            /*0x78a6fb8*/ void CheckError();
        }

        class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.Net.ICloseEx
        {
            /*0x19*/ bool m_closed;
            /*0x20*/ long m_contentLength;
            /*0x28*/ System.IO.FileAccess m_fileAccess;
            /*0x30*/ System.Net.WebHeaderCollection m_headers;
            /*0x38*/ System.IO.Stream m_stream;
            /*0x40*/ System.Uri m_uri;

            /*0x78a645c*/ FileWebResponse(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, bool asyncHint);
            /*0x78a73fc*/ FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a7650*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a765c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a77e0*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78a7874*/ System.Uri get_ResponseUri();
            /*0x78a77f8*/ void CheckDisposed();
            /*0x78a788c*/ void Close();
            /*0x78a7924*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x78a7aa0*/ System.IO.Stream GetResponseStream();
        }

        interface IWebProxy
        {
            /*0x3814a3c*/ System.Uri GetProxy(System.Uri destination);
            /*0x38141c4*/ bool IsBypassed(System.Uri host);
            /*0x38148bc*/ System.Net.ICredentials get_Credentials();
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

            static /*0x7895ec0*/ System.Net.IWebProxy CreateDefaultProxy();
            static /*0x78a8c34*/ bool AreAllBypassed(System.Collections.Generic.IEnumerable<string> proxies, bool checkFirstOnly);
            static /*0x78a8f38*/ System.Uri ProxyUri(string proxyName);
            /*0x78a7af4*/ WebProxy();
            /*0x78a7b08*/ WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials);
            /*0x78a8728*/ WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a8be4*/ WebProxy(bool enableAutoproxy);
            /*0x78a7e30*/ System.Uri get_Address();
            /*0x78a7e38*/ bool get_BypassProxyOnLocal();
            /*0x78a7e40*/ System.Net.ICredentials get_Credentials();
            /*0x78a7e48*/ bool get_UseDefaultCredentials();
            /*0x78a7ec4*/ void set_UseDefaultCredentials(bool value);
            /*0x78a7f3c*/ System.Uri GetProxy(System.Uri destination);
            /*0x78a7bdc*/ void UpdateRegExList(bool canThrow);
            /*0x78a8204*/ bool IsMatchInBypassList(System.Uri input);
            /*0x78a839c*/ bool IsLocal(System.Uri host);
            /*0x78a84f8*/ bool IsLocalInProxyHash(System.Uri host);
            /*0x78a85e8*/ bool IsBypassed(System.Uri host);
            /*0x78a813c*/ bool IsBypassedManual(System.Uri host);
            /*0x78a8aac*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a8ab8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78a8bdc*/ System.Net.AutoWebProxyScriptEngine get_ScriptEngine();
            /*0x78a8aa0*/ void UnsafeUpdateFromRegistry();
            /*0x78a80bc*/ bool GetProxyAuto(System.Uri destination, ref System.Uri proxyUri);
            /*0x78a86bc*/ bool IsBypassedAuto(System.Uri destination, ref bool isBypassed);
        }

        class AutoWebProxyScriptEngine
        {
            /*0x78a8c14*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList);
            /*0x78a8fd4*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList, ref int syncStatus);
        }

        class UnsafeNclNativeMethods
        {
            class HttpApi
            {
                static /*0x0*/ string[] m_Strings;

                static /*0x78a8ff4*/ HttpApi();

                class HTTP_REQUEST_HEADER_ID
                {
                    static /*0x0*/ string[] m_Strings;

                    static /*0x78a9700*/ HTTP_REQUEST_HEADER_ID();
                    static /*0x78a9684*/ string ToString(int position);
                }
            }

            class SecureStringHelper
            {
                static /*0x78a9fa0*/ string CreateString(System.Security.SecureString secureString);
                static /*0x78aa0ec*/ System.Security.SecureString CreateSecureString(string plainString);
            }
        }

        class Logging
        {
            static /*0x7895070*/ bool get_On();
        }

        class ServerCertValidationCallback
        {
            /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;
            /*0x18*/ System.Threading.ExecutionContext m_Context;

            /*0x78aa188*/ ServerCertValidationCallback(System.Net.Security.RemoteCertificateValidationCallback validationCallback);
            /*0x78aa214*/ System.Net.Security.RemoteCertificateValidationCallback get_ValidationCallback();
            /*0x78aa21c*/ void Callback(object state);
            /*0x78aa2c8*/ bool Invoke(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);

            class CallbackContext
            {
                /*0x10*/ object request;
                /*0x18*/ System.Security.Cryptography.X509Certificates.X509Certificate certificate;
                /*0x20*/ System.Security.Cryptography.X509Certificates.X509Chain chain;
                /*0x28*/ System.Net.Security.SslPolicyErrors sslPolicyErrors;
                /*0x2c*/ bool result;

                /*0x78aa438*/ CallbackContext(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            }
        }

        class AuthenticationManager
        {
            static /*0x0*/ System.Collections.ArrayList modules;
            static /*0x8*/ object locker;
            static /*0x10*/ System.Net.ICredentialPolicy credential_policy;

            static /*0x78ab278*/ AuthenticationManager();
            static /*0x78aa4a4*/ void EnsureModules();
            static /*0x78aa734*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x78aa834*/ System.Net.Authorization DoAuthenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x78aad30*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
        }

        class BasicClient : System.Net.IAuthenticationModule
        {
            static /*0x78ab708*/ byte[] GetBytes(string str);
            static /*0x78ab3ac*/ System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78aa72c*/ BasicClient();
            /*0x78ab300*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78ab7a4*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78ab7b0*/ string get_AuthenticationType();
        }

        class BindIPEndPoint : System.MulticastDelegate
        {
            /*0x78ab7f0*/ BindIPEndPoint(object object, nint method);
            /*0x78ab8fc*/ System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
        }

        class BufferedReadStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.BufferOffsetSize readBuffer;

            /*0x78ab910*/ BufferedReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.BufferOffsetSize readBuffer);
            /*0x78ab940*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x78abaa8*/ bool TryReadFromBuffer(byte[] buffer, int offset, int size, ref int result);

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

                /*0x78abb38*/ void MoveNext();
                /*0x78abe70*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ContentDecodeStream : System.Net.WebReadStream
        {
            /*0x40*/ System.IO.Stream <OriginalInnerStream>k__BackingField;

            static /*0x78abeec*/ System.Net.ContentDecodeStream Create(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.ContentDecodeStream.Mode mode);
            /*0x78abfd4*/ ContentDecodeStream(System.Net.WebOperation operation, System.IO.Stream decodeStream, System.IO.Stream originalInnerStream);
            /*0x78ac004*/ System.IO.Stream get_OriginalInnerStream();
            /*0x78ac00c*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x78ac030*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);

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

            static /*0x78ac730*/ DigestHeaderParser();
            /*0x78ac120*/ DigestHeaderParser(string header);
            /*0x78ac1e8*/ string get_Realm();
            /*0x78ac210*/ string get_Opaque();
            /*0x78ac23c*/ string get_Nonce();
            /*0x78ac268*/ string get_Algorithm();
            /*0x78ac294*/ string get_QOP();
            /*0x78ac2c0*/ bool Parse();
            /*0x78ac620*/ void SkipWhitespace();
            /*0x78ac6a0*/ string GetKey();
            /*0x78ac45c*/ bool GetKeywordAndValue(ref string key, ref string value);
        }

        class DigestSession
        {
            static /*0x0*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ System.DateTime lastUse;
            /*0x18*/ int _nc;
            /*0x20*/ System.Security.Cryptography.HashAlgorithm hash;
            /*0x28*/ System.Net.DigestHeaderParser parser;
            /*0x30*/ string _cnonce;

            static /*0x78ac8b0*/ DigestSession();
            /*0x78ac90c*/ DigestSession();
            /*0x78ac97c*/ string get_Algorithm();
            /*0x78ac994*/ string get_Realm();
            /*0x78ac9ac*/ string get_Nonce();
            /*0x78ac9c4*/ string get_Opaque();
            /*0x78ac9dc*/ string get_QOP();
            /*0x78ac9f4*/ string get_CNonce();
            /*0x78acaf4*/ bool Parse(string challenge);
            /*0x78acbec*/ string HashToHexString(string toBeHashed);
            /*0x78acd40*/ string HA1(string username, string password);
            /*0x78ace64*/ string HA2(System.Net.HttpWebRequest webRequest);
            /*0x78acf34*/ string Response(string username, string password, System.Net.HttpWebRequest webRequest);
            /*0x78ad094*/ System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78ad650*/ System.DateTime get_LastUse();
        }

        class DigestClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Collections.Hashtable cache;

            static /*0x78ae44c*/ DigestClient();
            static /*0x78ad658*/ System.Collections.Hashtable get_Cache();
            static /*0x78ad7c0*/ void CheckExpired(int count);
            /*0x78aa724*/ DigestClient();
            /*0x78ae00c*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78ae298*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78ae40c*/ string get_AuthenticationType();
        }

        class Dns
        {
            static /*0x78ae4d4*/ System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state);
            static /*0x78ae72c*/ System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult);
            static /*0x78ae840*/ bool GetHostByName_icall(string host, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x78ae844*/ bool GetHostByAddr_icall(string addr, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x78ae848*/ bool GetHostName_icall(ref string h_name);
            static /*0x78ae84c*/ void Error_11001(string hostName);
            static /*0x78ae8b0*/ System.Net.IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist);
            static /*0x78aebf0*/ System.Net.IPHostEntry GetHostByAddressFromString(string address, bool parse);
            static /*0x78aed1c*/ System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress);
            static /*0x78aee88*/ System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address);
            static /*0x78aefd8*/ System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress);
            static /*0x78aeef0*/ System.Net.IPHostEntry GetHostByName(string hostName);
            static /*0x78af1b8*/ string GetHostName();
            static /*0x78af1e4*/ System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);

            class GetHostAddressesCallback : System.MulticastDelegate
            {
                /*0x78ae65c*/ GetHostAddressesCallback(object object, nint method);
                /*0x78af300*/ System.Net.IPAddress[] Invoke(string hostName);
                /*0x78ae70c*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x78ae834*/ System.Net.IPAddress[] EndInvoke(System.IAsyncResult result);
            }
        }

        class FixedSizeReadStream : System.Net.WebReadStream
        {
            /*0x40*/ long <ContentLength>k__BackingField;
            /*0x48*/ long position;

            /*0x78af31c*/ FixedSizeReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, long contentLength);
            /*0x78af314*/ long get_ContentLength();
            /*0x78af344*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);

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

                /*0x78af4ac*/ void MoveNext();
                /*0x78af7d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x78af850*/ HttpRequestCreator();
            /*0x78af858*/ System.Net.WebRequest Create(System.Uri uri);
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

            static /*0x78afaac*/ HttpWebRequest();
            static /*0x78aff18*/ int get_DefaultMaximumErrorResponseLength();
            static /*0x3910ae8*/ System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationToken cancellationToken);
            static System.Threading.Tasks.Task<T> RunWithTimeoutWorker<T>(System.Threading.Tasks.Task<T> workerTask, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationTokenSource cts);
            static /*0x78b1c74*/ System.Exception FlattenException(System.Exception e);
            static /*0x78b1d30*/ System.Net.WebException GetWebException(System.Exception e, bool aborted);
            static /*0x78b15c0*/ System.Net.WebException CreateRequestAbortedException();
            /*0x78af8b0*/ HttpWebRequest(System.Uri uri);
            /*0x78afba8*/ HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78b4578*/ HttpWebRequest();
            /*0x78afb34*/ void ResetAuthorization();
            /*0x78afd3c*/ System.Uri get_Address();
            /*0x78afd44*/ bool get_AllowWriteStreamBuffering();
            /*0x78afd4c*/ System.Net.DecompressionMethods get_AutomaticDecompression();
            /*0x78afd54*/ bool get_InternalAllowBuffering();
            /*0x78afd68*/ bool get_MethodWithBuffer();
            /*0x78afe64*/ Mono.Net.Security.MobileTlsProvider get_TlsProvider();
            /*0x78afe6c*/ Mono.Security.Interface.MonoTlsSettings get_TlsSettings();
            /*0x78afe74*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x78afee4*/ long get_ContentLength();
            /*0x78afeec*/ void set_InternalContentLength(long value);
            /*0x78afef4*/ bool get_ThrowOnError();
            /*0x78afefc*/ void set_ThrowOnError(bool value);
            /*0x78aff08*/ System.Net.ICredentials get_Credentials();
            /*0x78aff10*/ void set_Credentials(System.Net.ICredentials value);
            /*0x78aff70*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78aff78*/ string get_Host();
            /*0x78b0084*/ bool get_KeepAlive();
            /*0x78b008c*/ int get_ReadWriteTimeout();
            /*0x78b0094*/ string get_Method();
            /*0x78b009c*/ void set_Method(string value);
            /*0x78b02e8*/ System.Version get_ProtocolVersion();
            /*0x78b02f0*/ System.Net.IWebProxy get_Proxy();
            /*0x78b02f8*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x78b04d4*/ System.Uri get_RequestUri();
            /*0x78b04dc*/ bool get_SendChunked();
            /*0x78b04e4*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78b04e8*/ System.Net.ServicePoint get_ServicePointNoLock();
            /*0x78b04f0*/ int get_Timeout();
            /*0x78b04f8*/ string get_TransferEncoding();
            /*0x78b054c*/ bool get_UseDefaultCredentials();
            /*0x78b05c4*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x78b05cc*/ bool get_ExpectContinue();
            /*0x78b05d4*/ void set_ExpectContinue(bool value);
            /*0x78b05e0*/ System.Uri get_AuthUri();
            /*0x78b05e8*/ bool get_ProxyQuery();
            /*0x78b061c*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            /*0x78b0624*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            /*0x78b0398*/ System.Net.ServicePoint GetServicePoint();
            /*0x78b0ca4*/ System.Net.WebOperation SendRequest(bool redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x78b122c*/ System.Threading.Tasks.Task<System.IO.Stream> MyGetRequestStreamAsync(System.Threading.CancellationToken cancellationToken);
            /*0x78b1794*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x78b184c*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x3814a3c*/ System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func);
            /*0x78b19f0*/ System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken);
            /*0x78b1b24*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken);
            /*0x78b196c*/ System.Net.WebException GetWebException(System.Exception e);
            /*0x78b1ed4*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x78b2044*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x78b2164*/ System.Net.WebResponse GetResponse();
            /*0x78b2264*/ void set_FinishedReading(bool value);
            /*0x78b1598*/ bool get_Aborted();
            /*0x78b2270*/ void Abort();
            /*0x78b23c8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78b2400*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78b033c*/ void CheckRequestStarted();
            /*0x78b2438*/ void DoContinueDelegate(int statusCode, System.Net.WebHeaderCollection headers);
            /*0x78b2454*/ void RewriteRedirectToGet();
            /*0x78b24d8*/ bool Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response);
            /*0x78b29b0*/ string GetHeaders();
            /*0x78b30a0*/ void DoPreAuthenticate();
            /*0x78b32a0*/ byte[] GetRequestHeaders();
            /*0x78b35dc*/ System.ValueTuple<System.Net.WebOperation, bool> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x78b39e8*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
            /*0x78b3d1c*/ System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, bool redirect);
            /*0x78b3f1c*/ System.ValueTuple<bool, bool, System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response);
            /*0x3813ffc*/ bool <RunWithTimeout>b__242_0<T>();
            /*0x78b4464*/ System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0();

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

                /*0x78afd0c*/ AuthorizationState(System.Net.HttpWebRequest request, bool isProxy);
                /*0x78b45b0*/ bool get_IsCompleted();
                /*0x78b45b8*/ System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState();
                /*0x78b45c0*/ bool get_IsNtlmAuthenticated();
                /*0x78b3a00*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
                /*0x78b43e0*/ void Reset();
                /*0x78b45e0*/ string ToString();
            }

            class <>c__24<T>
            {
                static /*0x0*/ System.Net.HttpWebRequest.<>c__241<T> <>9;
                static /*0x0*/ System.Func<System.Threading.Tasks.Task<T>, System.Nullable<int>> <>9__241_0;

                static /*0x383e7a0*/ <>c__24();
                /*0x38159dc*/ <>c__24();
                /*0x3813824*/ System.Nullable<int> <RunWithTimeoutWorker>b__241_0(System.Threading.Tasks.Task<T> t);
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

                /*0x38159dc*/ void MoveNext();
                /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78b46cc*/ void MoveNext();
                /*0x78b5ae0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78b5b5c*/ void MoveNext();
                /*0x78b670c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<GetRewriteHandler>b__271_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.BufferOffsetSize> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.IO.MemoryStream <ms>5__2;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x78b6788*/ void MoveNext();
                /*0x78b6c00*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x78b6c7c*/ HttpWebResponse();
            /*0x78b6c84*/ HttpWebResponse(System.Uri uri, string method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers);
            /*0x78b63d0*/ HttpWebResponse(System.Uri uri, string method, System.Net.WebResponseStream stream, System.Net.CookieContainer container);
            /*0x78b6f98*/ HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78b7390*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78b7398*/ System.Uri get_ResponseUri();
            /*0x78b742c*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x78b7434*/ string get_StatusDescription();
            /*0x78b744c*/ System.IO.Stream GetResponseStream();
            /*0x78b74e8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78b74f4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x78b76b4*/ void Close();
            /*0x78b76e4*/ void System.IDisposable.Dispose();
            /*0x78b76f4*/ void Dispose(bool disposing);
            /*0x78b73b0*/ void CheckDisposed();
            /*0x78b6d70*/ void FillCookies();
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

            static /*0x78b8658*/ string RemoveChunkExtension(string input);
            static /*0x78b8608*/ void ThrowProtocolViolation(string message);
            /*0x78b7708*/ MonoChunkParser(System.Net.WebHeaderCollection headers);
            /*0x78b77d8*/ int Read(byte[] buffer, int offset, int size);
            /*0x78b77dc*/ int ReadFromChunks(byte[] buffer, int offset, int size);
            /*0x78b7b5c*/ void Write(byte[] buffer, int offset, int size);
            /*0x78b7b7c*/ void InternalWrite(byte[] buffer, ref int offset, int size);
            /*0x78b84a8*/ bool get_WantMore();
            /*0x78b84cc*/ bool get_DataAvailable();
            /*0x78b85cc*/ int get_ChunkLeft();
            /*0x78b7fb0*/ System.Net.MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size);
            /*0x78b7cb8*/ System.Net.MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size);
            /*0x78b80f0*/ System.Net.MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size);
            /*0x78b81f0*/ System.Net.MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size);

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

                /*0x78b85d8*/ Chunk(byte[] chunk);
                /*0x78b7afc*/ int Read(byte[] buffer, int offset, int size);
            }
        }

        class MonoChunkStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x48*/ System.Net.MonoChunkParser <Decoder>k__BackingField;

            static /*0x78b8a34*/ void ThrowExpectingChunkTrailer();
            /*0x78b86a8*/ MonoChunkStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.WebHeaderCollection headers);
            /*0x78b86a0*/ System.Net.MonoChunkParser get_Decoder();
            /*0x78b87cc*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x78b8934*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x78b8a8c*/ System.Threading.Tasks.Task <>n__0(System.Threading.CancellationToken cancellationToken);

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

                /*0x78b8b94*/ void MoveNext();
                /*0x78b8fc4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78b9040*/ void MoveNext();
                /*0x78b94d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            /*0x10*/ System.Net.IAuthenticationModule authObject;

            /*0x78b953c*/ NtlmClient();
            /*0x78b95a8*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78b9678*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x78b9680*/ string get_AuthenticationType();
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

            static /*0x78b9b8c*/ void PutBytes(byte[] bytes, uint v, int offset);
            /*0x78b96c0*/ ServicePoint(System.Net.ServicePointManager.SPKey key, System.Uri uri, int connectionLimit, int maxIdleTime);
            /*0x78b99cc*/ System.Net.ServicePointManager.SPKey get_Key();
            /*0x78b99d4*/ System.Net.ServicePointScheduler get_Scheduler();
            /*0x78b99dc*/ void set_Scheduler(System.Net.ServicePointScheduler value);
            /*0x78b99e4*/ System.Uri get_Address();
            /*0x78b99ec*/ int get_ConnectionLimit();
            /*0x78b99f4*/ System.Version get_ProtocolVersion();
            /*0x78b99fc*/ void set_Expect100Continue(bool value);
            /*0x78b9a08*/ bool get_UseNagleAlgorithm();
            /*0x78b9a10*/ void set_UseNagleAlgorithm(bool value);
            /*0x78b3004*/ bool get_SendContinue();
            /*0x78b9a1c*/ void set_SendContinue(bool value);
            /*0x78b9a28*/ void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval);
            /*0x78b9ad8*/ void KeepAliveSetup(System.Net.Sockets.Socket socket);
            /*0x78b9c0c*/ bool get_UsesProxy();
            /*0x78b9c14*/ void set_UsesProxy(bool value);
            /*0x78b9c20*/ bool get_UseConnect();
            /*0x78b9c28*/ void set_UseConnect(bool value);
            /*0x78b9c34*/ bool get_HasTimedOut();
            /*0x78b9d60*/ System.Net.IPHostEntry get_HostEntry();
            /*0x78ba124*/ void SetVersion(System.Version version);
            /*0x78b10bc*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x78ba218*/ void FreeServicePoint();
            /*0x78ba22c*/ void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x78ba268*/ void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x78ba2a4*/ bool CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote);
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

            static /*0x78ba448*/ ServicePointManager();
            static /*0x78ba508*/ System.Net.ICertificatePolicy GetLegacyCertificatePolicy();
            static /*0x78ba560*/ bool get_CheckCertificateRevocationList();
            static /*0x78ba5b8*/ int get_DnsRefreshTimeout();
            static /*0x78ba610*/ System.Net.SecurityProtocolType get_SecurityProtocol();
            static /*0x78ba668*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            static /*0x78ba6c0*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            static /*0x78b063c*/ System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy);
            static /*0x78ba7a0*/ void RemoveServicePoint(System.Net.ServicePoint sp);

            class SPKey
            {
                /*0x10*/ System.Uri uri;
                /*0x18*/ System.Uri proxy;
                /*0x20*/ bool use_connect;

                /*0x78ba748*/ SPKey(System.Uri uri, System.Uri proxy, bool use_connect);
                /*0x78ba838*/ bool get_UsesProxy();
                /*0x78ba898*/ int GetHashCode();
                /*0x78ba96c*/ bool Equals(object obj);
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

            static /*0x78bc268*/ System.Threading.Tasks.Task<bool> WaitAsync(System.Threading.Tasks.Task workerTask, int millisecondTimeout);
            /*0x78b97c8*/ ServicePointScheduler(System.Net.ServicePoint servicePoint, int connectionLimit, int maxIdleTime);
            /*0x78baa60*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78baa68*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x78baa70*/ int get_MaxIdleTime();
            /*0x78bac5c*/ void Run();
            /*0x78baf54*/ System.Threading.Tasks.Task RunScheduler();
            /*0x78bb03c*/ void Cleanup();
            /*0x78bb290*/ void RunSchedulerIteration();
            /*0x78bb5bc*/ bool OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation);
            /*0x78bbd30*/ void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection);
            /*0x78bb4dc*/ bool SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group);
            /*0x78bbe50*/ void RemoveOperation(System.Net.WebOperation operation);
            /*0x78bb9d4*/ void RemoveIdleConnection(System.Net.WebConnection connection);
            /*0x78bbf1c*/ void FinalCleanup();
            /*0x78ba12c*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x78bbfe4*/ System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name);
            /*0x78bc240*/ void OnConnectionCreated(System.Net.WebConnection connection);
            /*0x78bc24c*/ void OnConnectionClosed(System.Net.WebConnection connection);
            /*0x78bc388*/ System.Threading.Tasks.Task <Run>b__31_0();

            class ConnectionGroup
            {
                static /*0x0*/ int nextId;
                /*0x10*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;
                /*0x20*/ int ID;
                /*0x28*/ System.Collections.Generic.LinkedList<System.Net.WebConnection> connections;
                /*0x30*/ System.Collections.Generic.LinkedList<System.Net.WebOperation> queue;

                /*0x78bab24*/ ConnectionGroup(System.Net.ServicePointScheduler scheduler, string name);
                /*0x78bc38c*/ System.Net.ServicePointScheduler get_Scheduler();
                /*0x78bb21c*/ bool IsEmpty();
                /*0x78bb94c*/ void RemoveConnection(System.Net.WebConnection connection);
                /*0x78bbaa0*/ void Cleanup();
                /*0x78bc1e8*/ void EnqueueOperation(System.Net.WebOperation operation);
                /*0x78bbd68*/ System.Net.WebOperation GetNextOperation();
                /*0x78bc40c*/ System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation);
                /*0x78bbb8c*/ System.ValueTuple<System.Net.WebConnection, bool> CreateOrReuseConnection(System.Net.WebOperation operation, bool force);
            }

            class AsyncManualResetEvent
            {
                /*0x10*/ System.Threading.Tasks.TaskCompletionSource<bool> m_tcs;

                /*0x78baa78*/ AsyncManualResetEvent(bool state);
                /*0x78bcd78*/ System.Threading.Tasks.Task<bool> WaitAsync(int millisecondTimeout);
                /*0x78bad20*/ void Set();
                /*0x78bb41c*/ void Reset();

                class <>c
                {
                    static /*0x0*/ System.Net.ServicePointScheduler.AsyncManualResetEvent.<> <>9;
                    static /*0x8*/ System.Func<object, bool> <>9__4_0;

                    static /*0x78bcdcc*/ <>c();
                    /*0x78bce34*/ <>c();
                    /*0x78bce3c*/ bool <Set>b__4_0(object s);
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

                /*0x78bced8*/ void MoveNext();
                /*0x78bdaac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78bdb14*/ void MoveNext();
                /*0x78be018*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource<T>
        {
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion;
            /*0x0*/ System.Net.WebCompletionSource.Result<T> currentResult;

            /*0x3815cc4*/ WebCompletionSource(bool runAsync);
            /*0x38148bc*/ System.Net.WebCompletionSource.Result<T> get_CurrentResult();
            /*0x38148bc*/ System.Threading.Tasks.Task get_Task();
            /*0x3910ae8*/ bool TrySetCompleted(T argument);
            /*0x3813ffc*/ bool TrySetCompleted();
            /*0x3813ffc*/ bool TrySetCanceled();
            /*0x38141c4*/ bool TrySetCanceled(System.OperationCanceledException error);
            /*0x38141c4*/ bool TrySetException(System.Exception error);
            /*0x38159dc*/ void ThrowOnError();
            /*0x38148bc*/ System.Threading.Tasks.Task<T> WaitForCompletion();

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

                /*0x3910ae8*/ Result(T argument);
                /*0x3910ae8*/ Result(System.Net.WebCompletionSource.Status<T> state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x3910ae8*/ System.Net.WebCompletionSource.Status<T> get_Status();
                /*0x3813ffc*/ bool get_Success();
                /*0x38148bc*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
                /*0x3910ae8*/ T get_Argument();
            }

            struct <WaitForCompletion>d__15<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ System.Net.WebCompletionSource<T> <>4__this;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebCompletionSource.Result<T>> <>u__1;

                /*0x38159dc*/ void MoveNext();
                /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource : System.Net.WebCompletionSource<object>
        {
            /*0x78b579c*/ WebCompletionSource();
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

            static /*0x78be528*/ System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error);
            static /*0x78be6a8*/ bool ReadLine(byte[] buffer, ref int start, int max, ref string output);
            /*0x78bcd48*/ WebConnection(System.Net.ServicePoint sPoint);
            /*0x78be094*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78be09c*/ bool CanReuse();
            /*0x78be0cc*/ bool CheckReusable();
            /*0x78be168*/ System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x78be284*/ System.Threading.Tasks.Task<bool> CreateStream(System.Net.WebOperation operation, bool reused, System.Threading.CancellationToken cancellationToken);
            /*0x78be3dc*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x78bc728*/ bool CanReuseConnection(System.Net.WebOperation operation);
            /*0x78be884*/ bool PrepareSharingNtlm(System.Net.WebOperation operation);
            /*0x78beba0*/ void Reset();
            /*0x78bec9c*/ void Close(bool reset);
            /*0x78bed64*/ void CloseSocket();
            /*0x78bc39c*/ bool get_Closed();
            /*0x78bf000*/ System.DateTime get_IdleSince();
            /*0x78bcb54*/ bool StartOperation(System.Net.WebOperation operation, bool reused);
            /*0x78bb7dc*/ bool Continue(System.Net.WebOperation next);
            /*0x78bf33c*/ void Dispose(bool disposing);
            /*0x78bc394*/ void Dispose();
            /*0x78bec74*/ void ResetNtlm();
            /*0x78bf374*/ bool get_NtlmAuthenticated();
            /*0x78bf37c*/ void set_NtlmAuthenticated(bool value);
            /*0x78bf388*/ System.Net.NetworkCredential get_NtlmCredential();
            /*0x78bf390*/ void set_NtlmCredential(System.Net.NetworkCredential value);
            /*0x78bf398*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x78bf3a0*/ void set_UnsafeAuthenticatedConnectionSharing(bool value);

            class <>c
            {
                static /*0x0*/ System.Net.WebConnection.<> <>9;
                static /*0x8*/ System.Func<System.Net.IPEndPoint, System.AsyncCallback, object, System.IAsyncResult> <>9__16_0;
                static /*0x10*/ System.Action<System.IAsyncResult> <>9__16_1;

                static /*0x78bf3ac*/ <>c();
                /*0x78bf414*/ <>c();
                /*0x78bf41c*/ System.IAsyncResult <Connect>b__16_0(System.Net.IPEndPoint targetEndPoint, System.AsyncCallback callback, object state);
                /*0x78bf4bc*/ void <Connect>b__16_1(System.IAsyncResult asyncResult);
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

                /*0x78bf5b0*/ void MoveNext();
                /*0x78c0080*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78c00e8*/ void MoveNext();
                /*0x78c09ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78c0a28*/ void MoveNext();
                /*0x78c1008*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x78c1084*/ WebConnectionStream(System.Net.WebConnection cnc, System.Net.WebOperation operation);
            /*0x78c117c*/ System.Net.HttpWebRequest get_Request();
            /*0x78c1184*/ System.Net.WebConnection get_Connection();
            /*0x78c118c*/ System.Net.WebOperation get_Operation();
            /*0x78c1194*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78c11b0*/ bool get_CanTimeout();
            /*0x78c11b8*/ int get_ReadTimeout();
            /*0x78c11c0*/ void set_ReadTimeout(int value);
            /*0x78c1220*/ int get_WriteTimeout();
            /*0x78c1228*/ void set_WriteTimeout(int value);
            /*0x78c1288*/ System.Exception GetException(System.Exception e);
            bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x78c13e8*/ int Read(byte[] buffer, int offset, int count);
            /*0x78c16dc*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x78c189c*/ int EndRead(System.IAsyncResult r);
            /*0x78c19bc*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x78c1b7c*/ void EndWrite(System.IAsyncResult r);
            /*0x78c1c70*/ void Write(byte[] buffer, int offset, int count);
            /*0x78c1e58*/ void Flush();
            /*0x78c1e5c*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x78b43d4*/ void InternalClose();
            /*0x3816710*/ void Close_internal(ref bool disposed);
            /*0x78c1f40*/ void Close();
            /*0x78c1f54*/ long Seek(long a, System.IO.SeekOrigin b);
            /*0x78c1fa0*/ void SetLength(long a);
            /*0x78c1fec*/ bool get_CanSeek();
            /*0x78c1ff4*/ long get_Length();
            /*0x78c2040*/ long get_Position();
            /*0x78c208c*/ void set_Position(long value);
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

            /*0x78c084c*/ WebConnectionTunnel(System.Net.HttpWebRequest request, System.Uri connectUri);
            /*0x78c20d8*/ System.Net.HttpWebRequest get_Request();
            /*0x78c20e0*/ System.Uri get_ConnectUri();
            /*0x78c20e8*/ bool get_Success();
            /*0x78c20f0*/ void set_Success(bool value);
            /*0x78c20fc*/ bool get_CloseConnection();
            /*0x78c2104*/ void set_CloseConnection(bool value);
            /*0x78c2110*/ int get_StatusCode();
            /*0x78c2118*/ void set_StatusCode(int value);
            /*0x78c2120*/ void set_StatusDescription(string value);
            /*0x78c2128*/ string[] get_Challenge();
            /*0x78c2130*/ void set_Challenge(string[] value);
            /*0x78c2138*/ System.Net.WebHeaderCollection get_Headers();
            /*0x78c2140*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x78c2148*/ System.Version get_ProxyVersion();
            /*0x78c2150*/ void set_ProxyVersion(System.Version value);
            /*0x78c2158*/ byte[] get_Data();
            /*0x78c2160*/ void set_Data(byte[] value);
            /*0x78c0890*/ System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x78c2168*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x78c22b8*/ void FlushContents(System.IO.Stream stream, int contentLength);

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

                /*0x78c234c*/ void MoveNext();
                /*0x78c3144*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78c31ac*/ void MoveNext();
                /*0x78c3ac8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x78b0ed4*/ WebOperation(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, bool isNtlmChallenge, System.Threading.CancellationToken cancellationToken);
            /*0x78c3b44*/ System.Net.HttpWebRequest get_Request();
            /*0x78c3b4c*/ System.Net.WebConnection get_Connection();
            /*0x78c3b54*/ void set_Connection(System.Net.WebConnection value);
            /*0x78c3b5c*/ System.Net.ServicePoint get_ServicePoint();
            /*0x78c3b64*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x78c3b6c*/ System.Net.BufferOffsetSize get_WriteBuffer();
            /*0x78c3b74*/ bool get_IsNtlmChallenge();
            /*0x78bc3ac*/ bool get_Aborted();
            /*0x78c3b7c*/ bool get_Closed();
            /*0x78b2388*/ void Abort();
            /*0x78c3d58*/ void Close();
            /*0x78c3c90*/ void SetCanceled();
            /*0x78c3e04*/ void SetError(System.Exception error);
            /*0x78c3ba8*/ System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo, bool> SetDisposed(ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x78c3ea8*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x78c3f88*/ void ThrowIfDisposed();
            /*0x78c0000*/ void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x78c167c*/ void ThrowIfClosedOrDisposed();
            /*0x78c0f80*/ void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x78c3f30*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x78bf008*/ void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection);
            /*0x78b386c*/ void SetPriorityRequest(System.Net.WebOperation operation);
            /*0x78b167c*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStream();
            /*0x78b5800*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal();
            /*0x78b57e8*/ System.Net.WebRequestStream get_WriteStream();
            /*0x78b5850*/ System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream();
            /*0x78c3fe8*/ System.Net.WebCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> get_Finished();
            /*0x78bf290*/ void Run();
            /*0x78c3ff0*/ void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error);
            /*0x78b58a0*/ void Finish(bool ok, System.Exception error);
            /*0x78c4070*/ void <RegisterRequest>b__48_0();

            struct <GetRequestStream>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                /*0x30*/ System.Net.WebOperation <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;

                /*0x78c4094*/ void MoveNext();
                /*0x78c4310*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x78c438c*/ void MoveNext();
                /*0x78c49bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebReadStream : System.IO.Stream
        {
            /*0x28*/ System.Net.WebOperation <Operation>k__BackingField;
            /*0x30*/ System.IO.Stream <InnerStream>k__BackingField;
            /*0x38*/ bool disposed;

            /*0x78b8744*/ WebReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream);
            /*0x78c49c8*/ System.Net.WebOperation get_Operation();
            /*0x78c49d0*/ System.IO.Stream get_InnerStream();
            /*0x78c49d8*/ long get_Length();
            /*0x78c4a10*/ long get_Position();
            /*0x78c4a48*/ void set_Position(long value);
            /*0x78c4a80*/ bool get_CanSeek();
            /*0x78c4a88*/ bool get_CanRead();
            /*0x78c4a90*/ bool get_CanWrite();
            /*0x78c4a98*/ void SetLength(long value);
            /*0x78c4ad0*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x78c4b08*/ void Write(byte[] buffer, int offset, int count);
            /*0x78c4b40*/ void Flush();
            /*0x78c4b78*/ System.Exception GetException(System.Exception e);
            /*0x78c4cd8*/ int Read(byte[] buffer, int offset, int size);
            /*0x78c4f30*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x78c50f0*/ int EndRead(System.IAsyncResult r);
            /*0x78c5210*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x78b8a90*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x78c5370*/ void Dispose(bool disposing);

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

                /*0x78c53bc*/ void MoveNext();
                /*0x78c59b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            static /*0x77e2d7c*/ WebRequestStream();
            /*0x77e1cb8*/ WebRequestStream(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel);
            /*0x77e1e3c*/ System.IO.Stream get_InnerStream();
            /*0x77e1e44*/ bool get_KeepAlive();
            /*0x77e1e4c*/ bool get_CanRead();
            /*0x77e1e54*/ bool get_CanWrite();
            /*0x77e1e5c*/ bool get_HasWriteBuffer();
            /*0x77e1e90*/ int get_WriteBufferLength();
            /*0x77e1ed4*/ System.Net.BufferOffsetSize GetWriteBuffer();
            /*0x77e1fa8*/ System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken);
            /*0x77e20a0*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x77e2304*/ System.Threading.Tasks.Task WriteAsyncInner(byte[] buffer, int offset, int size, System.Net.WebCompletionSource completion, System.Threading.CancellationToken cancellationToken);
            /*0x77e2450*/ System.Threading.Tasks.Task ProcessWrite(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x77e2584*/ void CheckWriteOverflow(long contentLength, long totalWritten, long size);
            /*0x77e2628*/ System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken);
            /*0x77e2724*/ System.Threading.Tasks.Task SetHeadersAsync(bool setInternalLength, System.Threading.CancellationToken cancellationToken);
            /*0x77e2834*/ System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken);
            /*0x77e2930*/ System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken);
            /*0x77e2a28*/ System.Threading.Tasks.Task WriteChunkTrailer();
            /*0x77e261c*/ void KillBuffer();
            /*0x77e2b14*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x77e2bc4*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x77e2bfc*/ void Close_internal(ref bool disposed);

            struct <FinishWriting>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x77e2e1c*/ void MoveNext();
                /*0x77e3160*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x77e31c8*/ void MoveNext();
                /*0x77e3718*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x77e3780*/ void MoveNext();
                /*0x77e3d54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Initialize>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x77e3dbc*/ void MoveNext();
                /*0x77e4148*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SetHeadersAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool setInternalLength;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x77e41b0*/ void MoveNext();
                /*0x77e48b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x77e491c*/ void MoveNext();
                /*0x77e4ea8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer_inner>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x77e4f10*/ void MoveNext();
                /*0x77e51a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x77e5208*/ void MoveNext();
                /*0x77e59a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x77e5a68*/ WebResponseStream(System.Net.WebRequestStream request);
            /*0x77e5a0c*/ System.Net.WebRequestStream get_RequestStream();
            /*0x77e5a14*/ System.Net.WebHeaderCollection get_Headers();
            /*0x77e5a1c*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x77e5a24*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x77e5a2c*/ void set_StatusCode(System.Net.HttpStatusCode value);
            /*0x77e5a34*/ string get_StatusDescription();
            /*0x77e5a3c*/ void set_StatusDescription(string value);
            /*0x77e5a44*/ System.Version get_Version();
            /*0x77e5a4c*/ void set_Version(System.Version value);
            /*0x77e5a54*/ bool get_KeepAlive();
            /*0x77e5a5c*/ void set_KeepAlive(bool value);
            /*0x77e5afc*/ bool get_CanRead();
            /*0x77e5b04*/ bool get_CanWrite();
            /*0x77e5b0c*/ bool get_ChunkedRead();
            /*0x77e5b14*/ void set_ChunkedRead(bool value);
            /*0x77e5b20*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x77e5c88*/ System.Threading.Tasks.Task<int> ProcessRead(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x77e5f48*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x77e6014*/ bool get_ExpectContent();
            /*0x77e60a8*/ void Initialize(System.Net.BufferOffsetSize buffer);
            /*0x77e65f0*/ System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(System.Threading.CancellationToken cancellationToken);
            /*0x77e672c*/ System.Threading.Tasks.Task ReadAllAsync(bool resending, System.Threading.CancellationToken cancellationToken);
            /*0x77e6840*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x77e68dc*/ void Close_internal(ref bool disposed);
            /*0x77e6984*/ System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, string where);
            /*0x77e6c1c*/ System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x77e6d18*/ bool GetResponse(System.Net.BufferOffsetSize buffer, ref int pos, ref System.Net.ReadState state);

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

                /*0x77e74dc*/ void MoveNext();
                /*0x77e7edc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ System.Net.WebResponseStream <>4__this;
                /*0x18*/ byte[] buffer;
                /*0x20*/ int offset;
                /*0x24*/ int size;

                /*0x77e5f40*/ <>c__DisplayClass41_0();
                /*0x77e7f58*/ System.Threading.Tasks.Task<int> <ProcessRead>b__0(System.Threading.CancellationToken ct);
                /*0x77e7f94*/ void <ProcessRead>b__1();
                /*0x77e7fd4*/ bool <ProcessRead>b__2();
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

                /*0x77e7ff8*/ void MoveNext();
                /*0x77e8600*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x77e867c*/ void MoveNext();
                /*0x77e90fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x77e9164*/ void MoveNext();
                /*0x77e98a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace NetworkInformation
        {
            class IPGlobalProperties
            {
                static /*0x77e9908*/ System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties();
                static /*0x77e9954*/ System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties();
                /*0x77e9958*/ IPGlobalProperties();
                /*0x38148bc*/ string get_DomainName();
            }

            class NetworkInformationException : System.ComponentModel.Win32Exception
            {
                /*0x77e9960*/ NetworkInformationException();
                /*0x77e99c4*/ NetworkInformationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            }

            enum NetworkInterfaceComponent
            {
                IPv4 = 0,
                IPv6 = 1,
            }

            class IPGlobalPropertiesFactoryPal
            {
                static /*0x77e990c*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }

            class CommonUnixIPGlobalProperties : System.Net.NetworkInformation.IPGlobalProperties
            {
                static /*0x77e9a6c*/ int getdomainname(byte[] name, int len);
                /*0x77e9c84*/ CommonUnixIPGlobalProperties();
                /*0x77e9af8*/ string get_DomainName();
            }

            class UnixIPGlobalProperties : System.Net.NetworkInformation.CommonUnixIPGlobalProperties
            {
                /*0x77e9c8c*/ UnixIPGlobalProperties();
            }

            class UnixNoLibCIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                /*0x77e9cac*/ UnixNoLibCIPGlobalProperties();
                /*0x77e9c94*/ string get_DomainName();
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

                static /*0x77e9e60*/ MibIPGlobalProperties();
                /*0x77e9cb4*/ MibIPGlobalProperties(string procDir);
            }

            class UnixIPGlobalPropertiesFactoryPal
            {
                static /*0x0*/ bool <PlatformNeedsLibCWorkaround>k__BackingField;

                static /*0x77e9f00*/ bool get_PlatformNeedsLibCWorkaround();
                static /*0x77e99cc*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }
        }

        namespace Configuration
        {
            class DefaultProxySectionInternal
            {
                static /*0x0*/ object classSyncObject;
                /*0x10*/ System.Net.IWebProxy webProxy;

                static /*0x77e9f48*/ System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode();
                static /*0x77e9f50*/ System.Net.IWebProxy GetSystemWebProxy();
                static /*0x77e9f58*/ object get_ClassSyncObject();
                static /*0x77e9ff0*/ System.Net.Configuration.DefaultProxySectionInternal GetSection();
                /*0x77ea110*/ DefaultProxySectionInternal();
                /*0x77ea118*/ System.Net.IWebProxy get_WebProxy();
            }

            class SettingsSectionInternal
            {
                static /*0x0*/ System.Net.Configuration.SettingsSectionInternal instance;
                /*0x10*/ bool HttpListenerUnescapeRequestUrl;
                /*0x14*/ System.Net.Sockets.IPProtectionLevel IPProtectionLevel;

                static /*0x77ea198*/ SettingsSectionInternal();
                static /*0x77ea120*/ System.Net.Configuration.SettingsSectionInternal get_Section();
                /*0x77ea180*/ SettingsSectionInternal();
                /*0x77ea178*/ bool get_Ipv6Enabled();
            }
        }

        namespace Cache
        {
            class RequestCache
            {
                static /*0x0*/ char[] LineSplits;

                static /*0x77ea210*/ RequestCache();
            }

            class RequestCacheValidator
            {
                /*0x77ea2b0*/ object CreateValidator();
            }

            class RequestCacheBinding
            {
                /*0x10*/ System.Net.Cache.RequestCache m_RequestCache;
                /*0x18*/ System.Net.Cache.RequestCacheValidator m_CacheValidator;

                /*0x77ea2e8*/ System.Net.Cache.RequestCache get_Cache();
                /*0x77ea2f0*/ System.Net.Cache.RequestCacheValidator get_Validator();
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

                /*0x77ea2f8*/ RequestCachePolicy(System.Net.Cache.RequestCacheLevel level);
                /*0x77ea370*/ System.Net.Cache.RequestCacheLevel get_Level();
                /*0x77ea378*/ string ToString();
            }

            class RequestCacheProtocol
            {
                /*0x77ea410*/ RequestCacheProtocol(object arg1, object arg2);
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

                /*0x77ea450*/ NetworkStream(System.Net.Sockets.Socket socket);
                /*0x77ea60c*/ NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket);
                /*0x77ea45c*/ NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access, bool ownsSocket);
                /*0x77ea618*/ bool get_CanRead();
                /*0x77ea620*/ bool get_CanSeek();
                /*0x77ea628*/ bool get_CanWrite();
                /*0x77ea630*/ bool get_CanTimeout();
                /*0x77ea638*/ int get_ReadTimeout();
                /*0x77ea820*/ void set_ReadTimeout(int value);
                /*0x77eaa48*/ int get_WriteTimeout();
                /*0x77eaaa4*/ void set_WriteTimeout(int value);
                /*0x77eab28*/ long get_Length();
                /*0x77eab74*/ long get_Position();
                /*0x77eabc0*/ void set_Position(long value);
                /*0x77eac0c*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x77eac58*/ int Read(byte[] buffer, int offset, int size);
                /*0x77eafa0*/ int Read(System.Span<byte> destination);
                /*0x77eb2f4*/ int ReadByte();
                /*0x77eb358*/ void Write(byte[] buffer, int offset, int size);
                /*0x77eb6a0*/ void Write(System.ReadOnlySpan<byte> source);
                /*0x77eb974*/ void WriteByte(byte value);
                /*0x77eb9cc*/ void Close(int timeout);
                /*0x77eba30*/ void Dispose(bool disposing);
                /*0x77ebb38*/ void Finalize();
                /*0x77ebbdc*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x77ebf54*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x77ec1b8*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x77ec530*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x77ec794*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x77ece28*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x77ed06c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x77ed710*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x77ed950*/ void Flush();
                /*0x77ed954*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x77ed9dc*/ void SetLength(long value);
                /*0x77ea8a4*/ void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, int timeout, bool silent);
                /*0x77edb64*/ System.Net.Sockets.Socket get_InternalSocket();
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

                static /*0x77f5f44*/ Socket();
                static /*0x77ee5d8*/ void CompleteAccept(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                static /*0x77ee874*/ void CompleteSendReceive(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                static /*0x77ee78c*/ System.Exception GetException(System.Net.Sockets.SocketError error, bool wrapExceptionsInIOExceptions);
                static /*0x77ef108*/ bool get_OSSupportsIPv4();
                static /*0x77ef16c*/ bool get_OSSupportsIPv6();
                static /*0x77f0fcc*/ object get_InternalSyncObject();
                static /*0x77eeccc*/ void InitializeSockets();
                static /*0x77eef2c*/ nint Socket_icall(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, ref int error);
                static /*0x77f1730*/ System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x77f1870*/ System.Net.SocketAddress LocalEndPoint_icall(nint socket, int family, ref int error);
                static /*0x77f193c*/ void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool block, ref int error);
                static /*0x77f1a60*/ void Blocking_icall(nint socket, bool block, ref int error);
                static /*0x77f1bac*/ System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x77f1cec*/ System.Net.SocketAddress RemoteEndPoint_icall(nint socket, int family, ref int error);
                static /*0x77f1e74*/ bool Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x77f1fc4*/ bool Poll_icall(nint socket, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x77f2100*/ System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, ref int error, bool blocking);
                static /*0x77f2898*/ nint Accept_icall(nint sock, ref int error, bool blocking);
                static /*0x77f2ad8*/ void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error);
                static /*0x77f2bfc*/ void Bind_icall(nint sock, System.Net.SocketAddress sa, ref int error);
                static /*0x77f2ce4*/ void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int backlog, ref int error);
                static /*0x77f2e08*/ void Listen_icall(nint sock, int backlog, ref int error);
                static /*0x77f3a48*/ bool BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x77f35e4*/ bool BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x77f31ec*/ void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x77f3d18*/ void Connect_icall(nint sock, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x77f3e08*/ void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool reuse, ref int error);
                static /*0x77f4100*/ void Disconnect_icall(nint sock, bool reuse, ref int error);
                static /*0x77f45e4*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f49c0*/ int Receive_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f4280*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f49c8*/ int Receive_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f4c7c*/ int ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x77f4ea0*/ int ReceiveFrom_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x77f5410*/ void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, int sent_so_far);
                static /*0x77f4fe8*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f57c8*/ int Send_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f4ea8*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f57d0*/ int Send_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x77f5890*/ void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x77f59cc*/ void GetSocketOption_obj_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x77f131c*/ void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x77f59d8*/ void SetSocketOption_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x77f59dc*/ int IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x77f5b34*/ int IOControl_icall(nint sock, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x77f5b40*/ void Close_icall(nint socket, ref int error);
                static /*0x77f11f8*/ void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x77f5c44*/ void Shutdown_icall(nint socket, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x77f5eb8*/ void cancel_blocking_socket_operation(System.Threading.Thread thread);
                static /*0x77f5ebc*/ int get_FamilyHint();
                static /*0x77f5f40*/ bool IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                static /*0x77f1098*/ bool IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                /*0x77eea5c*/ Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x77f1470*/ Socket(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle);
                /*0x77ecb14*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, bool fromNetworkStream, System.Threading.CancellationToken cancellationToken);
                /*0x77edd24*/ System.Threading.Tasks.Task<int> ReceiveAsyncApm(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77ed3fc*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken);
                /*0x77ee190*/ System.Threading.Tasks.Task<int> SendAsyncApm(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77ee9f4*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                /*0x77ee730*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                /*0x77ef1d0*/ nint get_Handle();
                /*0x77ef1ec*/ System.Net.Sockets.AddressFamily get_AddressFamily();
                /*0x77ef1f4*/ System.Net.Sockets.SocketType get_SocketType();
                /*0x77ef1fc*/ System.Net.Sockets.ProtocolType get_ProtocolType();
                /*0x77ef204*/ int get_ReceiveBufferSize();
                /*0x77ef250*/ int get_SendBufferSize();
                /*0x77ef29c*/ void set_DontFragment(bool value);
                /*0x77ef430*/ bool get_DualMode();
                /*0x77ef4e8*/ void set_DualMode(bool value);
                /*0x77ef568*/ bool get_IsDualMode();
                /*0x77ef580*/ bool CanTryAddressFamily(System.Net.Sockets.AddressFamily family);
                /*0x77ef5b8*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77eb644*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77eaf44*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77efebc*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x77f04f0*/ int IOControl(System.Net.Sockets.IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x77eef50*/ void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level);
                /*0x77f066c*/ System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state);
                /*0x77ec4bc*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x77ec738*/ int EndSend(System.IAsyncResult asyncResult);
                /*0x77ebee0*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x77ec15c*/ int EndReceive(System.IAsyncResult asyncResult);
                /*0x77f08d8*/ bool get_CleanedUp();
                /*0x77f10ec*/ void Dispose();
                /*0x77f1158*/ void Finalize();
                /*0x77ebaa8*/ void InternalShutdown(System.Net.Sockets.SocketShutdown how);
                /*0x77eda28*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue, bool silent);
                /*0x77ef034*/ void SocketDefaults();
                /*0x77f15c4*/ System.Net.EndPoint get_LocalEndPoint();
                /*0x77f1874*/ bool get_Blocking();
                /*0x77f187c*/ void set_Blocking(bool value);
                /*0x77f1a68*/ bool get_Connected();
                /*0x77f1584*/ void set_NoDelay(bool value);
                /*0x77f1abc*/ System.Net.EndPoint get_RemoteEndPoint();
                /*0x77f1cf0*/ bool Poll(int microSeconds, System.Net.Sockets.SelectMode mode);
                /*0x77f1fc8*/ System.Net.Sockets.Socket Accept();
                /*0x77f2250*/ void Accept(System.Net.Sockets.Socket acceptSocket);
                /*0x77f2378*/ System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state);
                /*0x77f2638*/ System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult);
                /*0x77f2660*/ System.Net.Sockets.Socket EndAccept(ref byte[] buffer, ref int bytesTransferred, System.IAsyncResult asyncResult);
                /*0x77f28a0*/ void Bind(System.Net.EndPoint localEP);
                /*0x77f2c00*/ void Listen(int backlog);
                /*0x77f2e0c*/ void Connect(System.Net.IPAddress address, int port);
                /*0x77f2e80*/ void Connect(System.Net.EndPoint remoteEP);
                /*0x77f330c*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback callback, object state);
                /*0x77f08e8*/ System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x77f3c68*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x77f3d20*/ void Disconnect(bool reuseSocket);
                /*0x77f3f2c*/ System.IAsyncResult BeginDisconnect(bool reuseSocket, System.AsyncCallback callback, object state);
                /*0x77f4050*/ void EndDisconnect(System.IAsyncResult asyncResult);
                /*0x77efd94*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77f43c0*/ int Receive(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77eff18*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77eb1e8*/ int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77eb8e8*/ int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77f4724*/ bool ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x77f0d3c*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x77f0edc*/ int EndReceive(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x77f49d0*/ int ReceiveFrom(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.SocketError errorCode);
                /*0x77f4dcc*/ int EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult sockares, System.Net.Sockets.SocketAsyncEventArgs ares);
                /*0x77efc50*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77ef614*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x77f5128*/ bool SendAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x77f0a24*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x77f0c4c*/ int EndSend(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x77f57d8*/ int EndSendTo(System.IAsyncResult asyncResult);
                /*0x77ea694*/ object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName);
                /*0x77f59d0*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, bool optionValue);
                /*0x77ef318*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue);
                /*0x77f04f4*/ int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x77f5b38*/ void Close();
                /*0x77ebb30*/ void Close(int timeout);
                /*0x77f5b44*/ void Shutdown(System.Net.Sockets.SocketShutdown how);
                /*0x77f5c48*/ void Dispose(bool disposing);
                /*0x77f5ca8*/ void Linger(nint handle);
                /*0x77f16ac*/ void ThrowIfDisposedAndClosed();
                /*0x77f4108*/ void ThrowIfBufferNull(byte[] buffer);
                /*0x77f415c*/ void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size);
                /*0x77f1a70*/ void ThrowIfUdp();
                /*0x77f2760*/ System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, string methodName, string argName);
                /*0x77f24dc*/ void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, nint handle, System.IOSelectorJob job);
                /*0x77f4934*/ void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs e, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x77f5e14*/ System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation op);
                /*0x77f2a18*/ System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input);

                class CachedEventArgs
                {
                    /*0x10*/ System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> TaskAccept;
                    /*0x18*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskReceive;
                    /*0x20*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskSend;
                    /*0x28*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;
                    /*0x30*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;

                    /*0x77f66d0*/ CachedEventArgs();
                }

                class TaskSocketAsyncEventArgs<TResult> : System.Net.Sockets.SocketAsyncEventArgs
                {
                    /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder;
                    /*0x0*/ bool _accessed;

                    /*0x38159dc*/ TaskSocketAsyncEventArgs();
                    /*0x3910ae8*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(ref bool responsibleForReturningToPool);
                }

                class Int32TaskSocketAsyncEventArgs : System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<int>
                {
                    /*0x99*/ bool _wrapExceptionsInIOExceptions;

                    /*0x77f6688*/ Int32TaskSocketAsyncEventArgs();
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

                    static /*0x77f7204*/ AwaitableSocketAsyncEventArgs();
                    /*0x77f66d8*/ AwaitableSocketAsyncEventArgs();
                    /*0x77f674c*/ bool get_WrapExceptionsInIOExceptions();
                    /*0x77f6754*/ void set_WrapExceptionsInIOExceptions(bool value);
                    /*0x77edbf8*/ bool Reserve();
                    /*0x77f6760*/ void Release();
                    /*0x77f67dc*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _);
                    /*0x77edc74*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Net.Sockets.Socket socket);
                    /*0x77ee114*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket socket);
                    /*0x77f6de8*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
                    /*0x77f6ec8*/ void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x77f6a0c*/ void InvokeContinuation(System.Action<object> continuation, object state, bool forceAsync);
                    /*0x77f7158*/ int GetResult(short token);
                    /*0x77f71c4*/ void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token);
                    /*0x77f6e7c*/ void ThrowIncorrectTokenException();
                    /*0x77f710c*/ void ThrowMultipleContinuationsException();
                    /*0x77f71a0*/ void ThrowException(System.Net.Sockets.SocketError error);
                    /*0x77f6cfc*/ System.Exception CreateException(System.Net.Sockets.SocketError error);

                    class <>c
                    {
                        static /*0x0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs.<> <>9;
                        static /*0x8*/ System.Threading.ContextCallback <>9__14_0;
                        static /*0x10*/ System.Threading.SendOrPostCallback <>9__20_0;

                        static /*0x77f7368*/ <>c();
                        /*0x77f73d0*/ <>c();
                        /*0x77f73d8*/ void <OnCompleted>b__14_0(object runState);
                        /*0x77f7488*/ void <InvokeContinuation>b__20_0(object s);
                        /*0x77f7534*/ void <.cctor>b__27_0(object state);
                        /*0x77f7580*/ void <.cctor>b__27_1(object state);
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

                    static /*0x77f75cc*/ <>c();
                    /*0x77f7634*/ <>c();
                    /*0x77f763c*/ System.Net.Sockets.Socket.CachedEventArgs <ReceiveAsync>b__14_0();
                    /*0x77f7690*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1();
                    /*0x77f76e0*/ void <ReceiveAsyncApm>b__15_0(System.IAsyncResult iar);
                    /*0x77f7914*/ void <ReceiveAsyncApm>b__15_1(System.IAsyncResult iar);
                    /*0x77f7d54*/ System.Net.Sockets.Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0();
                    /*0x77f7da8*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1();
                    /*0x77f7df8*/ void <SendAsyncApm>b__23_0(System.IAsyncResult iar);
                    /*0x77f802c*/ void <SendAsyncApm>b__23_1(System.IAsyncResult iar);
                    /*0x77f832c*/ void <SendAsync>b__295_0(System.IOAsyncResult s);
                    /*0x77f83bc*/ void <BeginSend>b__297_0(System.IOAsyncResult s);
                    /*0x77f844c*/ void <.cctor>b__367_0(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x77f8540*/ void <.cctor>b__367_1(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x77f861c*/ void <.cctor>b__367_2(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x77f86f8*/ void <.cctor>b__367_3(System.IAsyncResult ares);
                    /*0x77f8998*/ void <.cctor>b__367_4(System.IOAsyncResult ares);
                    /*0x77f8ad0*/ void <.cctor>b__367_5(System.IOAsyncResult ares);
                    /*0x77f8d0c*/ void <.cctor>b__367_6(System.IAsyncResult ares);
                    /*0x77f8f68*/ void <.cctor>b__367_7(System.IOAsyncResult ares);
                    /*0x77f9208*/ void <.cctor>b__367_8(System.IAsyncResult ares);
                    /*0x77f9464*/ void <.cctor>b__367_9(System.IOAsyncResult ares);
                    /*0x77f9574*/ void <.cctor>b__367_10(System.IAsyncResult ares);
                    /*0x77f97e8*/ void <.cctor>b__367_11(System.IOAsyncResult ares);
                    /*0x77f9ab0*/ void <.cctor>b__367_12(System.IOAsyncResult ares);
                    /*0x77f9bcc*/ void <.cctor>b__367_13(System.IAsyncResult ares);
                    /*0x77f9e68*/ void <.cctor>b__367_14(System.IOAsyncResult ares);
                    /*0x77f9fe8*/ void <.cctor>b__367_15(System.IAsyncResult ares);
                    /*0x77fa25c*/ void <.cctor>b__367_16(System.IOAsyncResult ares);
                    /*0x77fa378*/ void <.cctor>b__367_17(System.IAsyncResult ares);
                }

                class <>c__DisplayClass240_0
                {
                    /*0x10*/ System.Net.Sockets.SocketAsyncResult sockares;

                    /*0x77f35dc*/ <>c__DisplayClass240_0();
                    /*0x77fa5ec*/ void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t);
                }

                class <>c__DisplayClass298_0
                {
                    /*0x10*/ int sent_so_far;

                    /*0x77f57c0*/ <>c__DisplayClass298_0();
                    /*0x77fa710*/ void <BeginSendCallback>b__0(System.IOAsyncResult s);
                }

                class <>c__DisplayClass355_0
                {
                    /*0x10*/ System.Net.Sockets.Socket <>4__this;
                    /*0x18*/ System.IOSelectorJob job;
                    /*0x20*/ nint handle;

                    /*0x77f5e0c*/ <>c__DisplayClass355_0();
                    /*0x77fa7b0*/ void <QueueIOSelectorJob>b__0(System.Threading.Tasks.Task t);
                }
            }

            class SocketException : System.ComponentModel.Win32Exception
            {
                /*0x90*/ System.Net.EndPoint m_EndPoint;

                static /*0x77fa7f4*/ int WSAGetLastError_icall();
                /*0x77eef30*/ SocketException();
                /*0x77fa7f8*/ SocketException(int error, string message);
                /*0x77eb2ec*/ SocketException(int errorCode);
                /*0x77efc48*/ SocketException(System.Net.Sockets.SocketError socketError);
                /*0x77fa800*/ SocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x77fa808*/ string get_Message();
                /*0x77f8990*/ System.Net.Sockets.SocketError get_SocketErrorCode();
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

                /*0x77fa898*/ LingerOption(bool enable, int seconds);
                /*0x77fa8cc*/ void set_Enabled(bool value);
                /*0x77fa8d8*/ void set_LingerTime(int value);
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

                /*0x77fa8e0*/ TcpClient();
                /*0x77fa900*/ TcpClient(System.Net.Sockets.AddressFamily family);
                /*0x77faa84*/ System.Net.Sockets.Socket get_Client();
                /*0x77faa8c*/ void set_Client(System.Net.Sockets.Socket value);
                /*0x77faa94*/ void Connect(string hostname, int port);
                /*0x77fb140*/ void Connect(System.Net.IPEndPoint remoteEP);
                /*0x77fb240*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state);
                /*0x77fb2ac*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x77fb2f4*/ System.Threading.Tasks.Task ConnectAsync(string host, int port);
                /*0x77fb460*/ System.Net.Sockets.NetworkStream GetStream();
                /*0x77fb5a4*/ void Dispose(bool disposing);
                /*0x77fb76c*/ void Dispose();
                /*0x77fb77c*/ void Finalize();
                /*0x77faa0c*/ void initialize();
            }

            class SafeSocketHandle : Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid
            {
                static /*0x0*/ bool THROW_ON_ABORT_RETRIES;
                /*0x20*/ System.Collections.Generic.List<System.Threading.Thread> blocking_threads;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> threads_stacktraces;
                /*0x30*/ bool in_cleanup;

                static /*0x77fc1e0*/ SafeSocketHandle();
                /*0x77fb81c*/ SafeSocketHandle(nint preexistingHandle, bool ownsHandle);
                /*0x77fb8f8*/ bool ReleaseHandle();
                /*0x77fbeac*/ void RegisterForBlockingSyscall();
                /*0x77fbfec*/ void UnRegisterForBlockingSyscall();
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

                /*0x77fc2cc*/ SocketAsyncEventArgs(bool flowExecutionContext);
                /*0x77fc274*/ System.Net.Sockets.Socket get_AcceptSocket();
                /*0x77fc27c*/ void set_AcceptSocket(System.Net.Sockets.Socket value);
                /*0x77fc284*/ int get_BytesTransferred();
                /*0x77fc28c*/ void set_BytesTransferred(int value);
                /*0x77fc294*/ void set_LastOperation(System.Net.Sockets.SocketAsyncOperation value);
                /*0x77fc29c*/ void set_RemoteEndPoint(System.Net.EndPoint value);
                /*0x77fc2a4*/ System.Net.Sockets.SocketError get_SocketError();
                /*0x77fc2ac*/ void set_SocketError(System.Net.Sockets.SocketError value);
                /*0x77fc2b4*/ void set_SocketFlags(System.Net.Sockets.SocketFlags value);
                /*0x77fc2bc*/ object get_UserToken();
                /*0x77fc2c4*/ void set_UserToken(object value);
                /*0x77fc36c*/ void Finalize();
                /*0x77fc37c*/ void Dispose(bool disposing);
                /*0x77fc390*/ void Dispose();
                /*0x77fc3f4*/ void SetBytesTransferred(int value);
                /*0x77fc3fc*/ System.Net.Sockets.Socket get_CurrentSocket();
                /*0x77fc404*/ void SetCurrentSocket(System.Net.Sockets.Socket socket);
                /*0x77fc40c*/ void SetLastOperation(System.Net.Sockets.SocketAsyncOperation op);
                /*0x77fc4cc*/ void Complete_internal();
                /*0x77fc4f4*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x77fc51c*/ System.Memory<byte> get_MemoryBuffer();
                /*0x77fc528*/ int get_Offset();
                /*0x77fc530*/ int get_Count();
                /*0x77fc538*/ System.Collections.Generic.IList<System.ArraySegment<byte>> get_BufferList();
                /*0x77fc540*/ void SetBuffer(System.Memory<byte> buffer);
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

                /*0x77fc364*/ SocketAsyncResult();
                /*0x77fc77c*/ SocketAsyncResult(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x77fc638*/ nint get_Handle();
                /*0x77fc64c*/ void Init(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x77fc7c0*/ System.Net.Sockets.SocketError get_ErrorCode();
                /*0x77fc848*/ void CheckIfThrowDelayedException();
                /*0x77fc8ec*/ void CompleteDisposed();
                /*0x77fc8f0*/ void Complete();
                /*0x77fcaec*/ void Complete(bool synch);
                /*0x77fcaf8*/ void Complete(int total);
                /*0x77fcb00*/ void Complete(System.Exception e, bool synch);
                /*0x77fcb30*/ void Complete(System.Exception e);
                /*0x77fcb4c*/ void Complete(System.Net.Sockets.Socket s);
                /*0x77fcb68*/ void Complete(System.Net.Sockets.Socket s, int total);

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.SocketAsyncResult.<> <>9;
                    static /*0x8*/ System.Threading.WaitCallback <>9__27_0;

                    static /*0x77fcb94*/ <>c();
                    /*0x77fcbfc*/ <>c();
                    /*0x77fcc04*/ void <Complete>b__27_0(object state);
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

                static /*0x77fd3c4*/ SslApplicationProtocol();
                static /*0x77fd3ac*/ char GetHexValue(int i);
                /*0x77fcc7c*/ SslApplicationProtocol(byte[] protocol, bool copy);
                /*0x77fce0c*/ bool Equals(System.Net.Security.SslApplicationProtocol other);
                /*0x77fcf28*/ bool Equals(object obj);
                /*0x77fcfbc*/ int GetHashCode();
                /*0x77fd0a4*/ string ToString();
            }

            class SslClientAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.EncryptionPolicy _encryptionPolicy;
                /*0x14*/ System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;
                /*0x18*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
                /*0x1c*/ bool _allowRenegotiation;
                /*0x20*/ string <TargetHost>k__BackingField;
                /*0x28*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;

                /*0x77fd6c0*/ SslClientAuthenticationOptions();
                /*0x77fd558*/ string get_TargetHost();
                /*0x77fd560*/ void set_TargetHost(string value);
                /*0x77fd568*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x77fd570*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x77fd578*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x77fd614*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x77fd6b0*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x77fd6b8*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
            }

            class AuthenticatedStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _InnerStream;
                /*0x30*/ bool _LeaveStreamOpen;

                /*0x77fd6d0*/ AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen);
                /*0x77fd86c*/ System.IO.Stream get_InnerStream();
                /*0x77fd874*/ void Dispose(bool disposing);
                /*0x3813ffc*/ bool get_IsAuthenticated();
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
                /*0x77fd95c*/ LocalCertificateSelectionCallback(object object, nint method);
                /*0x77fda68*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class RemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x77fda7c*/ RemoteCertificateValidationCallback(object object, nint method);
                /*0x77fdb88*/ bool Invoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
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
                /*0x77fdb9c*/ LocalCertSelectionCallback(object object, nint method);
                /*0x77fdc50*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class ServerCertSelectionCallback : System.MulticastDelegate
            {
                /*0x77fdc64*/ ServerCertSelectionCallback(object object, nint method);
                /*0x77fdd14*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string hostName);
            }

            class SslStream : System.Net.Security.AuthenticatedStream
            {
                /*0x38*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x40*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x48*/ System.Net.Security.RemoteCertificateValidationCallback validationCallback;
                /*0x50*/ System.Net.Security.LocalCertificateSelectionCallback selectionCallback;
                /*0x58*/ Mono.Net.Security.MobileAuthenticatedStream impl;
                /*0x60*/ bool explicitSettings;

                static /*0x77fddc0*/ Mono.Net.Security.MobileTlsProvider GetProvider();
                /*0x77fde30*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback);
                /*0x77fde3c*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback);
                /*0x77fe1b8*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback, System.Net.Security.EncryptionPolicy encryptionPolicy);
                /*0x77fe1c0*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                /*0x77fdd28*/ Mono.Net.Security.MobileAuthenticatedStream get_Impl();
                /*0x77fdd9c*/ string get_InternalTargetHost();
                /*0x77fdef8*/ void SetAndVerifyValidationCallback(System.Net.Security.RemoteCertificateValidationCallback callback);
                /*0x77fdffc*/ void SetAndVerifySelectionCallback(System.Net.Security.LocalCertificateSelectionCallback callback);
                /*0x77fe308*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x77fe35c*/ System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState);
                /*0x77fe3d0*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
                /*0x77fe3dc*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x77fe430*/ bool get_IsAuthenticated();
                /*0x77fe45c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x77fe480*/ System.Net.Security.SslApplicationProtocol get_NegotiatedApplicationProtocol();
                /*0x77fe4cc*/ bool get_CanSeek();
                /*0x77fe4d4*/ bool get_CanRead();
                /*0x77fe4ec*/ bool get_CanTimeout();
                /*0x77fe50c*/ bool get_CanWrite();
                /*0x77fe524*/ int get_ReadTimeout();
                /*0x77fe550*/ void set_ReadTimeout(int value);
                /*0x77fe58c*/ int get_WriteTimeout();
                /*0x77fe5b8*/ void set_WriteTimeout(int value);
                /*0x77fe5f4*/ long get_Length();
                /*0x77fe61c*/ long get_Position();
                /*0x77fe648*/ void set_Position(long value);
                /*0x77fe6a0*/ void SetLength(long value);
                /*0x77fe6dc*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x77fe734*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x77fe758*/ void Flush();
                /*0x77fdd40*/ void CheckDisposed();
                /*0x77fe77c*/ void Dispose(bool disposing);
                /*0x77fe838*/ int Read(byte[] buffer, int offset, int count);
                /*0x77fe88c*/ void Write(byte[] buffer, int offset, int count);
                /*0x77fe8e0*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x77fe93c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x77fe998*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x77fea04*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x77fea4c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x77feab8*/ void EndWrite(System.IAsyncResult asyncResult);

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ System.Net.Security.LocalCertificateSelectionCallback callback;
                    /*0x18*/ System.Net.Security.SslStream <>4__this;

                    /*0x77fe300*/ <>c__DisplayClass21_0();
                    /*0x77feac4*/ System.Security.Cryptography.X509Certificates.X509Certificate <SetAndVerifySelectionCallback>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
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

    static /*0x77feafc*/ uint ComputeStringHash(string s);

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
                /*0x77feb78*/ BypassElementCollection();
            }

            class ConnectionManagementElement : System.Configuration.ConfigurationElement
            {
            }

            class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x77febb0*/ ConnectionManagementElementCollection();
            }

            class ConnectionManagementSection : System.Configuration.ConfigurationSection
            {
                /*0x77febe8*/ ConnectionManagementSection();
                /*0x77fec20*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class DefaultProxySection : System.Configuration.ConfigurationSection
            {
                /*0x77fec58*/ DefaultProxySection();
                /*0x77fec90*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
                /*0x77fecc8*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            }

            class ProxyElement : System.Configuration.ConfigurationElement
            {
                /*0x77fed00*/ ProxyElement();
                /*0x77fed38*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class HttpWebRequestElement : System.Configuration.ConfigurationElement
            {
                /*0x77fed70*/ HttpWebRequestElement();
                /*0x77feda8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class Ipv6Element : System.Configuration.ConfigurationElement
            {
                /*0x77fede0*/ Ipv6Element();
                /*0x77fee18*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
            {
                /*0x77fee50*/ NetSectionGroup();
            }

            class SettingsSection : System.Configuration.ConfigurationSection
            {
                /*0x77fee88*/ SettingsSection();
                /*0x77feec0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class PerformanceCountersElement : System.Configuration.ConfigurationElement
            {
                /*0x77feef8*/ PerformanceCountersElement();
                /*0x77fef30*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class ServicePointManagerElement : System.Configuration.ConfigurationElement
            {
                /*0x77fef68*/ ServicePointManagerElement();
                /*0x77fefa0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class SocketElement : System.Configuration.ConfigurationElement
            {
                /*0x77fefd8*/ SocketElement();
                /*0x77ff010*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebProxyScriptElement : System.Configuration.ConfigurationElement
            {
                /*0x77ff048*/ WebProxyScriptElement();
                /*0x77ff080*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModulesSection : System.Configuration.ConfigurationSection
            {
                /*0x77ff0b8*/ WebRequestModulesSection();
                /*0x77ff0f0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x77ff128*/ WebRequestModuleElementCollection();
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
            /*0x77ff160*/ DiagnosticsConfigurationHandler();
            /*0x77ff198*/ object Create(object parent, object configContext, System.Xml.XmlNode section);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x77ff1d0*/ void ThrowNotSupportedException();
    }
}
