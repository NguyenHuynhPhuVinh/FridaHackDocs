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

        static /*0x1540f10*/ SystemCertificateProvider();
        static /*0x1540818*/ Mono.X509PalImpl GetX509Pal();
        static /*0x15408c8*/ void EnsureInitialized();
        /*0x1540f08*/ SystemCertificateProvider();
        /*0x1540a1c*/ Mono.X509PalImpl get_X509Pal();
        /*0x1540a78*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, Mono.CertificateImportFlags importFlags);
        /*0x1540ce0*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x1540ce4*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x1540df0*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
        /*0x1540df4*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
    }

    class SystemDependencyProvider : Mono.ISystemDependencyProvider
    {
        static /*0x0*/ Mono.SystemDependencyProvider instance;
        static /*0x8*/ object syncRoot;
        /*0x10*/ Mono.SystemCertificateProvider <CertificateProvider>k__BackingField;

        static /*0x15411f8*/ SystemDependencyProvider();
        static /*0x1540f88*/ Mono.SystemDependencyProvider get_Instance();
        static /*0x1540fe4*/ void Initialize();
        /*0x1541138*/ SystemDependencyProvider();
        /*0x15411d0*/ Mono.ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider();
        /*0x15411d8*/ Mono.SystemCertificateProvider get_CertificateProvider();
        /*0x15411e0*/ Mono.X509PalImpl get_X509Pal();
    }

    class X509Pal
    {
        static /*0x1541270*/ Mono.X509PalImpl get_Instance();
    }

    class X509PalImplMono : Mono.X509PalImpl
    {
        /*0x1540870*/ X509PalImplMono();
        /*0x15412d0*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        /*0x15412d4*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x15412d8*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
    }

    class X509PalImpl
    {
        static /*0x0*/ byte[] signedData;

        static /*0x154193c*/ X509PalImpl();
        static /*0x15412e8*/ byte[] PEM(string type, byte[] data);
        static /*0x154141c*/ byte[] ConvertData(byte[] data);
        /*0x15412e0*/ X509PalImpl();
        System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
        /*0x1540ae4*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data);
        /*0x1540d74*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x1541528*/ bool get_SupportsLegacyBasicConstraintsExtension();
        /*0x1541530*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
    }

    namespace Util
    {
        class MonoPInvokeCallbackAttribute : System.Attribute
        {
            /*0x15419d0*/ MonoPInvokeCallbackAttribute(System.Type t);
        }
    }

    namespace Unity
    {
        class CertHelper
        {
            static /*0x15419d8*/ void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x1541bb0*/ void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class Debug
        {
            static /*0x1541e54*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, string context, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x1541ef4*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, string context, Mono.Security.Interface.AlertDescription defaultAlert);
        }

        class UnityTls
        {
            static /*0x0*/ Mono.Unity.UnityTls.unitytls_interface_struct marshalledInterface;

            static /*0x1542020*/ nint GetUnityTlsInterface();
            static /*0x1542024*/ bool get_IsSupported();
            static /*0x1541d70*/ Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface();

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
                UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
                UNITYTLS_USER_WOULD_BLOCK = 1048577,
                UNITYTLS_USER_READ_FAILED = 1048578,
                UNITYTLS_USER_WRITE_FAILED = 1048579,
                UNITYTLS_USER_UNKNOWN_ERROR = 1048580,
                UNITYTLS_USER_CUSTOM_ERROR_END = 2097152,
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
                /*0x154203c*/ unitytls_x509verify_callback(object object, nint method);
                /*0x1542114*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
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
                /*0x1542128*/ unitytls_tlsctx_write_callback(object object, nint method);
                /*0x1542200*/ nint Invoke(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_read_callback : System.MulticastDelegate
            {
                /*0x1542214*/ unitytls_tlsctx_read_callback(object object, nint method);
                /*0x15422ec*/ nint Invoke(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_trace_callback : System.MulticastDelegate
            {
                /*0x1542300*/ unitytls_tlsctx_trace_callback(object object, nint method);
                /*0x15423d8*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen);
            }

            class unitytls_tlsctx_certificate_callback : System.MulticastDelegate
            {
                /*0x15423ec*/ unitytls_tlsctx_certificate_callback(object object, nint method);
                /*0x15424c4*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_x509verify_callback : System.MulticastDelegate
            {
                /*0x15424e0*/ unitytls_tlsctx_x509verify_callback(object object, nint method);
                /*0x15425b8*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
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

                /*0x15425cc*/ unitytls_interface_struct();

                class unitytls_errorstate_create_t : System.MulticastDelegate
                {
                    /*0x15425d4*/ unitytls_errorstate_create_t(object object, nint method);
                    /*0x1542690*/ Mono.Unity.UnityTls.unitytls_errorstate Invoke();
                }

                class unitytls_errorstate_raise_error_t : System.MulticastDelegate
                {
                    /*0x15426a4*/ unitytls_errorstate_raise_error_t(object object, nint method);
                    /*0x154277c*/ void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode);
                }

                class unitytls_key_get_ref_t : System.MulticastDelegate
                {
                    /*0x1542790*/ unitytls_key_get_ref_t(object object, nint method);
                    /*0x1542868*/ Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_der_t : System.MulticastDelegate
                {
                    /*0x154287c*/ unitytls_key_parse_der_t(object object, nint method);
                    /*0x1542954*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_pem_t : System.MulticastDelegate
                {
                    /*0x1542968*/ unitytls_key_parse_pem_t(object object, nint method);
                    /*0x1542a40*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_free_t : System.MulticastDelegate
                {
                    /*0x1542a54*/ unitytls_key_free_t(object object, nint method);
                    /*0x1542b28*/ void Invoke(Mono.Unity.UnityTls.unitytls_key* key);
                }

                class unitytls_x509_export_der_t : System.MulticastDelegate
                {
                    /*0x1542b3c*/ unitytls_x509_export_der_t(object object, nint method);
                    /*0x1542c00*/ nint Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_ref_t : System.MulticastDelegate
                {
                    /*0x1542c14*/ unitytls_x509list_get_ref_t(object object, nint method);
                    /*0x1542cec*/ Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_x509_t : System.MulticastDelegate
                {
                    /*0x1542d00*/ unitytls_x509list_get_x509_t(object object, nint method);
                    /*0x1542dc4*/ Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, nint index, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_create_t : System.MulticastDelegate
                {
                    /*0x1542dd8*/ unitytls_x509list_create_t(object object, nint method);
                    /*0x1542eac*/ Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_t : System.MulticastDelegate
                {
                    /*0x1542ec0*/ unitytls_x509list_append_t(object object, nint method);
                    /*0x1542f98*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_der_t : System.MulticastDelegate
                {
                    /*0x1542fac*/ unitytls_x509list_append_der_t(object object, nint method);
                    /*0x1543084*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_free_t : System.MulticastDelegate
                {
                    /*0x1543098*/ unitytls_x509list_free_t(object object, nint method);
                    /*0x154316c*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list);
                }

                class unitytls_x509verify_default_ca_t : System.MulticastDelegate
                {
                    /*0x1543180*/ unitytls_x509verify_default_ca_t(object object, nint method);
                    /*0x1543244*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_explicit_ca_t : System.MulticastDelegate
                {
                    /*0x1543258*/ unitytls_x509verify_explicit_ca_t(object object, nint method);
                    /*0x154331c*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_server_t : System.MulticastDelegate
                {
                    /*0x1543334*/ unitytls_tlsctx_create_server_t(object object, nint method);
                    /*0x15433f8*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_client_t : System.MulticastDelegate
                {
                    /*0x1543434*/ unitytls_tlsctx_create_client_t(object object, nint method);
                    /*0x15434f8*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_server_require_client_authentication_t : System.MulticastDelegate
                {
                    /*0x1543534*/ unitytls_tlsctx_server_require_client_authentication_t(object object, nint method);
                    /*0x154360c*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_certificate_callback_t : System.MulticastDelegate
                {
                    /*0x1543620*/ unitytls_tlsctx_set_certificate_callback_t(object object, nint method);
                    /*0x15436f8*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_trace_callback_t : System.MulticastDelegate
                {
                    /*0x154370c*/ unitytls_tlsctx_set_trace_callback_t(object object, nint method);
                    /*0x15437e4*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_x509verify_callback_t : System.MulticastDelegate
                {
                    /*0x15437f8*/ unitytls_tlsctx_set_x509verify_callback_t(object object, nint method);
                    /*0x15438d0*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_supported_ciphersuites_t : System.MulticastDelegate
                {
                    /*0x15438e4*/ unitytls_tlsctx_set_supported_ciphersuites_t(object object, nint method);
                    /*0x15439bc*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_ciphersuite_t : System.MulticastDelegate
                {
                    /*0x15439d0*/ unitytls_tlsctx_get_ciphersuite_t(object object, nint method);
                    /*0x1543aa8*/ Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_protocol_t : System.MulticastDelegate
                {
                    /*0x1543abc*/ unitytls_tlsctx_get_protocol_t(object object, nint method);
                    /*0x1543b94*/ Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_process_handshake_t : System.MulticastDelegate
                {
                    /*0x1543ba8*/ unitytls_tlsctx_process_handshake_t(object object, nint method);
                    /*0x1543c80*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_read_t : System.MulticastDelegate
                {
                    /*0x1543c94*/ unitytls_tlsctx_read_t(object object, nint method);
                    /*0x1543d6c*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_write_t : System.MulticastDelegate
                {
                    /*0x1543d80*/ unitytls_tlsctx_write_t(object object, nint method);
                    /*0x1543e58*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_notify_close_t : System.MulticastDelegate
                {
                    /*0x1543e6c*/ unitytls_tlsctx_notify_close_t(object object, nint method);
                    /*0x1543f44*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_free_t : System.MulticastDelegate
                {
                    /*0x1543f58*/ unitytls_tlsctx_free_t(object object, nint method);
                    /*0x154402c*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx);
                }

                class unitytls_random_generate_bytes_t : System.MulticastDelegate
                {
                    /*0x1544040*/ unitytls_random_generate_bytes_t(object object, nint method);
                    /*0x1544118*/ void Invoke(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
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

            static /*0x1544cec*/ void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, ref Mono.Unity.UnityTls.unitytls_x509list* nativeCertChain, ref Mono.Unity.UnityTls.unitytls_key* nativeKey);
            static /*0x154412c*/ nint WriteCallback(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x15441f4*/ nint ReadCallback(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x15442bc*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x154436c*/ void CertificateCallback(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x1544434*/ UnityTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
            /*0x154502c*/ bool get_IsAuthenticated();
            /*0x1545034*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
            /*0x154503c*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
            /*0x1545044*/ System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
            /*0x15451ec*/ System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
            /*0x154538c*/ void Renegotiate();
            /*0x15453cc*/ bool PendingRenegotiation();
            /*0x15453d4*/ void Shutdown();
            /*0x15454e8*/ void Dispose(bool disposing);
            /*0x1545560*/ void StartHandshake();
            /*0x15456e0*/ bool ProcessHandshake();
            /*0x15458a4*/ void FinishHandshake();
            /*0x15459ec*/ nint WriteCallback(byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x1545e3c*/ nint ReadCallback(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x1546240*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x15466d0*/ void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class UnityTlsConversions
        {
            static /*0x1544c7c*/ Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x1544cb4*/ Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x15459cc*/ Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol);
            static /*0x1541fcc*/ Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x1546ea0*/ System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
            static /*0x1546ed0*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
        }

        class UnityTlsProvider : Mono.Net.Security.MobileTlsProvider
        {
            static /*0x1546f10*/ Mono.Unity.UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x1547ad0*/ UnityTlsProvider();
            /*0x1546f74*/ string get_Name();
            /*0x1546fb4*/ System.Guid get_ID();
            /*0x154700c*/ bool get_SupportsSslStream();
            /*0x1547014*/ bool get_SupportsMonoExtensions();
            /*0x154701c*/ bool get_SupportsConnectionInfo();
            /*0x1547024*/ bool get_SupportsCleanShutdown();
            /*0x154702c*/ System.Security.Authentication.SslProtocols get_SupportedProtocols();
            /*0x1547034*/ Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x1547158*/ bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
        }

        class UnityTlsStream : Mono.Net.Security.MobileAuthenticatedStream
        {
            /*0x15470c4*/ UnityTlsStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
            /*0x1547c14*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
        }

        class X509ChainImplUnityTls : System.Security.Cryptography.X509Certificates.X509ChainImpl
        {
            /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
            /*0x18*/ Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain;
            /*0x20*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
            /*0x28*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;
            /*0x30*/ bool reverseOrder;

            /*0x1546648*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder);
            /*0x1547c84*/ bool get_IsValid();
            /*0x1547cac*/ Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain();
            /*0x1547cb4*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
            /*0x1547f90*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
            /*0x154809c*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
            /*0x15480a4*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
            /*0x15480ac*/ void Reset();
            /*0x15480ec*/ void Dispose(bool disposing);
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

                /*0x1548158*/ BufferOffsetSize(byte[] buffer, int offset, int size);
                /*0x1548124*/ int get_EndOffset();
                /*0x1548130*/ int get_Remaining();
                /*0x154825c*/ string ToString();
            }

            class BufferOffsetSize2 : Mono.Net.Security.BufferOffsetSize
            {
                /*0x28*/ int InitialSize;

                /*0x15482fc*/ BufferOffsetSize2(int size);
                /*0x154836c*/ void Reset();
                /*0x15483c8*/ void MakeRoom(int size);
                /*0x154847c*/ void AppendData(byte[] buffer, int offset, int size);
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

                /*0x15484ec*/ AsyncProtocolResult(int result);
                /*0x1548514*/ AsyncProtocolResult(System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x15484dc*/ int get_UserResult();
                /*0x15484e4*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
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

                /*0x1548580*/ AsyncProtocolRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x154853c*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x1548544*/ bool get_RunSynchronously();
                /*0x154854c*/ string get_Name();
                /*0x1548570*/ int get_UserResult();
                /*0x1548578*/ void set_UserResult(int value);
                /*0x1548608*/ void RequestRead(int size);
                /*0x15486cc*/ void RequestWrite();
                /*0x15486d8*/ System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken);
                /*0x15487d0*/ System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken);
                /*0x15488b0*/ System.Threading.Tasks.Task<System.Nullable<int>> InnerRead(System.Threading.CancellationToken cancellationToken);
                Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
                /*0x15489b4*/ string ToString();

                struct <StartOperation>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Mono.Net.Security.AsyncProtocolResult> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x1548a0c*/ void MoveNext();
                    /*0x1548da4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x1548dfc*/ void MoveNext();
                    /*0x1549508*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x1549514*/ void MoveNext();
                    /*0x1549980*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AsyncHandshakeRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x15499d8*/ AsyncHandshakeRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x15499e0*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncReadOrWriteRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x38*/ Mono.Net.Security.BufferOffsetSize <UserBuffer>k__BackingField;
                /*0x40*/ int <CurrentSize>k__BackingField;

                /*0x1549dec*/ AsyncReadOrWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x1549dd4*/ Mono.Net.Security.BufferOffsetSize get_UserBuffer();
                /*0x1549ddc*/ int get_CurrentSize();
                /*0x1549de4*/ void set_CurrentSize(int value);
                /*0x1549e90*/ string ToString();
            }

            class AsyncReadRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x1549eec*/ AsyncReadRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x1549ef4*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncWriteRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x154a0bc*/ AsyncWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x154a0c4*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
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

                static /*0x154a29c*/ Mono.Net.Security.ChainValidationHelper GetInternalValidator(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x154a5f0*/ Mono.Net.Security.ChainValidationHelper Create(Mono.Net.Security.MobileTlsProvider provider, ref Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MonoTlsStream stream);
                static /*0x154a798*/ System.Net.ServerCertValidationCallback GetValidationCallback(Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x154a940*/ System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x154a37c*/ ChainValidationHelper(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, bool cloneSettings, Mono.Net.Security.MonoTlsStream stream);
                /*0x154a97c*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x154a984*/ bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, ref System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
                /*0x154a9c0*/ Mono.Security.Interface.ValidationResult ValidateCertificate(string host, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x154aa94*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x154ab70*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, ref System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x154af80*/ bool InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ Mono.Security.Interface.MonoTlsSettings settings;

                    /*0x154a938*/ <>c__DisplayClass11_0();
                    /*0x154b03c*/ bool <GetValidationCallback>b__0(object s, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, System.Net.Security.SslPolicyErrors e);
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

                static /*0x154c94c*/ MobileAuthenticatedStream();
                static /*0x1549290*/ System.Exception GetSSPIException(System.Exception e);
                static /*0x154b28c*/ System.Exception GetIOException(System.Exception e, string message);
                static /*0x154b410*/ System.Exception GetInternalError();
                static /*0x154b460*/ System.Exception GetInvalidNestedCallException();
                /*0x1547ae0*/ MobileAuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
                /*0x154b19c*/ System.Net.Security.SslStream get_SslStream();
                /*0x154b1a4*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x154b1ac*/ Mono.Net.Security.MobileTlsProvider get_Provider();
                /*0x154b1b4*/ string get_TargetHost();
                /*0x154b1bc*/ void set_TargetHost(string value);
                /*0x154b1c4*/ void CheckThrow(bool authSuccessCheck, bool shutdownCheck);
                /*0x1548d64*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e);
                /*0x154b4b0*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x154b7e8*/ void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x154ba2c*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x154b6f4*/ System.Threading.Tasks.Task ProcessAuthentication(bool runSynchronously, Mono.Net.Security.MonoSslAuthenticationOptions options, System.Threading.CancellationToken cancellationToken);
                Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x154bb48*/ int Read(byte[] buffer, int offset, int count);
                /*0x154bd48*/ void Write(byte[] buffer, int offset, int count);
                /*0x154be18*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x154beb4*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x154bc2c*/ System.Threading.Tasks.Task<int> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken);
                /*0x1546134*/ int InternalRead(byte[] buffer, int offset, int size, ref bool outWantMore);
                /*0x154bf50*/ System.ValueTuple<int, bool> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size);
                /*0x1545c4c*/ bool InternalWrite(byte[] buffer, int offset, int size);
                /*0x154c0d0*/ bool InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size);
                /*0x1549864*/ System.Threading.Tasks.Task<int> InnerRead(bool sync, int requestedSize, System.Threading.CancellationToken cancellationToken);
                /*0x1549424*/ System.Threading.Tasks.Task InnerWrite(bool sync, System.Threading.CancellationToken cancellationToken);
                /*0x15499fc*/ Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status, bool renegotiate);
                /*0x1549f5c*/ System.ValueTuple<int, bool> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x154a13c*/ System.ValueTuple<int, bool> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x154c1cc*/ bool get_IsAuthenticated();
                /*0x154c2b4*/ void Dispose(bool disposing);
                /*0x154c508*/ void Flush();
                /*0x154c52c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x154c608*/ System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate();
                /*0x154c708*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x154c748*/ void SetLength(long value);
                /*0x154c76c*/ bool get_CanRead();
                /*0x154c7b0*/ bool get_CanTimeout();
                /*0x154c7d0*/ bool get_CanWrite();
                /*0x154c834*/ bool get_CanSeek();
                /*0x154c83c*/ long get_Length();
                /*0x154c85c*/ long get_Position();
                /*0x154c87c*/ void set_Position(long value);
                /*0x154c8bc*/ int get_ReadTimeout();
                /*0x154c8e0*/ void set_ReadTimeout(int value);
                /*0x154c904*/ int get_WriteTimeout();
                /*0x154c928*/ void set_WriteTimeout(int value);
                /*0x154c998*/ void <InnerWrite>b__67_0();

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

                    /*0x154c9cc*/ void MoveNext();
                    /*0x154d2d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x154d2dc*/ void MoveNext();
                    /*0x154da34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass66_0
                {
                    /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x18*/ int len;

                    /*0x154da8c*/ <>c__DisplayClass66_0();
                    /*0x154da94*/ int <InnerRead>b__0();
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

                    /*0x154dadc*/ void MoveNext();
                    /*0x154df20*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerWrite>d__67 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x154df78*/ void MoveNext();
                    /*0x154e208*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x1544b3c*/ MobileTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x154e214*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x15454cc*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                bool get_IsAuthenticated();
                /*0x154e21c*/ bool get_IsServer();
                /*0x154e224*/ string get_TargetHost();
                /*0x154e22c*/ string get_ServerName();
                /*0x154e234*/ bool get_AskForClientCertificate();
                /*0x154e23c*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                void StartHandshake();
                bool ProcessHandshake();
                void FinishHandshake();
                /*0x154e244*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate();
                /*0x154e24c*/ void set_LocalServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
                System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
                System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
                System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
                void Shutdown();
                bool PendingRenegotiation();
                /*0x1545854*/ bool ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x154699c*/ System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(string[] acceptableIssuers);
                void Renegotiate();
                /*0x154c498*/ void Dispose();
                /*0x154e254*/ void Dispose(bool disposing);
                /*0x154e258*/ void Finalize();
            }

            class MobileTlsProvider : Mono.Security.Interface.MonoTlsProvider
            {
                /*0x1547ad8*/ MobileTlsProvider();
                Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
                bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
            }

            class MonoSslAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;

                /*0x154e304*/ MonoSslAuthenticationOptions();
                bool get_ServerMode();
                System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                string get_TargetHost();
                void set_TargetHost(string value);
                System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                void set_ServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                bool get_ClientCertificateRequired();
                void set_ClientCertificateRequired(bool value);
                /*0x154e2fc*/ System.Net.Security.ServerCertSelectionCallback get_ServerCertSelectionDelegate();
            }

            class MonoSslClientAuthenticationOptions : Mono.Net.Security.MonoSslAuthenticationOptions
            {
                /*0x18*/ System.Net.Security.SslClientAuthenticationOptions <Options>k__BackingField;

                /*0x154b688*/ MonoSslClientAuthenticationOptions();
                /*0x154e30c*/ System.Net.Security.SslClientAuthenticationOptions get_Options();
                /*0x154e314*/ bool get_ServerMode();
                /*0x154e31c*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x154e338*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x154e354*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x154e370*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x154e38c*/ string get_TargetHost();
                /*0x154e3a8*/ void set_TargetHost(string value);
                /*0x154e3c4*/ bool get_ClientCertificateRequired();
                /*0x154e404*/ void set_ClientCertificateRequired(bool value);
                /*0x154e444*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x154e460*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x154e47c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                /*0x154e4bc*/ void set_ServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
            }

            class MonoSslServerAuthenticationOptions : Mono.Net.Security.MonoSslAuthenticationOptions
            {
                /*0x18*/ System.Net.Security.SslServerAuthenticationOptions <Options>k__BackingField;

                /*0x154b9c0*/ MonoSslServerAuthenticationOptions();
                /*0x154e4fc*/ System.Net.Security.SslServerAuthenticationOptions get_Options();
                /*0x154e504*/ bool get_ServerMode();
                /*0x154e50c*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x154e528*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x154e544*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x154e560*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x154e57c*/ bool get_ClientCertificateRequired();
                /*0x154e598*/ void set_ClientCertificateRequired(bool value);
                /*0x154e5b8*/ string get_TargetHost();
                /*0x154e5f8*/ void set_TargetHost(string value);
                /*0x154e638*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                /*0x154e654*/ void set_ServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                /*0x154e670*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x154e6b0*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
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

                static /*0x154f5a8*/ MonoTlsProviderFactory();
                static /*0x154a67c*/ Mono.Net.Security.MobileTlsProvider GetProviderInternal();
                static /*0x154e6f0*/ void InitializeInternal();
                static /*0x154ee3c*/ Mono.Net.Security.MobileTlsProvider LookupProvider(string name, bool throwOnError);
                static /*0x154ea9c*/ void InitializeProviderRegistration();
                static /*0x154f3d0*/ void PopulateUnityProviders();
                static /*0x154f50c*/ void PopulateProviders();
                static /*0x154eca8*/ Mono.Net.Security.MobileTlsProvider CreateDefaultProviderImpl();
                static /*0x154f55c*/ Mono.Net.Security.MobileTlsProvider GetProvider();
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

                /*0x154f6fc*/ MonoTlsStream(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream);
                /*0x154f6d8*/ System.Net.HttpWebRequest get_Request();
                /*0x154f6e0*/ System.Net.WebExceptionStatus get_ExceptionStatus();
                /*0x154f6e8*/ bool get_CertificateValidationFailed();
                /*0x154f6f0*/ void set_CertificateValidationFailed(bool value);
                /*0x154f7d0*/ System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken);
                /*0x154f8d4*/ void Dispose();
                /*0x154f8d8*/ void CloseSslStream();

                struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoTlsStream <>4__this;
                    /*0x38*/ System.Net.WebConnectionTunnel tunnel;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Net.Sockets.Socket <socket>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x154f9ac*/ void MoveNext();
                    /*0x1550050*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NoReflectionHelper
            {
                static /*0x15500a8*/ object GetProvider();
            }

            class SystemCertificateValidator
            {
                static /*0x0*/ bool is_macosx;
                static /*0x4*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;

                static /*0x15500f4*/ SystemCertificateValidator();
                static /*0x154b034*/ bool NeedsChain(Mono.Security.Interface.MonoTlsSettings settings);
            }

            namespace Private
            {
                class CallbackHelpers
                {
                    static /*0x1550144*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback PublicToMono(System.Net.Security.RemoteCertificateValidationCallback callback);
                    static /*0x154a888*/ System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback callback;

                        /*0x15501f4*/ <>c__DisplayClass0_0();
                        /*0x1550204*/ bool <PublicToMono>b__0(string h, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, Mono.Security.Interface.MonoSslPolicyErrors e);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback;

                        /*0x15501fc*/ <>c__DisplayClass6_0();
                        /*0x1550228*/ System.Security.Cryptography.X509Certificates.X509Certificate <MonoToInternal>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
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

            /*0x155024c*/ NtlmSession();
            /*0x1550254*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession> cache;

            static /*0x1550ab4*/ NtlmClient();
            /*0x1550aac*/ NtlmClient();
            /*0x15506e0*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1550a64*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1550a6c*/ string get_AuthenticationType();

            class <>c
            {
                static /*0x0*/ Mono.Http.NtlmClient.<> <>9;
                static /*0x8*/ System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<System.Net.HttpWebRequest, Mono.Http.NtlmSession> <>9__1_0;

                static /*0x1550b40*/ <>c();
                /*0x1550ba4*/ <>c();
                /*0x1550bac*/ Mono.Http.NtlmSession <Authenticate>b__1_0(System.Net.HttpWebRequest x);
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

            static /*0x1551620*/ OidLookup();
            static /*0x1550c08*/ string ToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x1551128*/ string ToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x1550de8*/ bool ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup);
            static /*0x1550df0*/ string NativeOidToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x15512dc*/ string NativeFriendlyNameToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);

            class <>c
            {
                static /*0x0*/ Internal.Cryptography.OidLookup.<> <>9;

                static /*0x15532e0*/ <>c();
                /*0x1553344*/ <>c();
                /*0x155334c*/ string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<string, string> kvp);
                /*0x1553388*/ string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<string, string> kvp);
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

                static /*0x155411c*/ string GetSimpleNameInfo(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                static /*0x1554578*/ string FindAltNameMatch(byte[] extensionBytes, Internal.Cryptography.Pal.GeneralNameType matchType, string otherOid);
                static /*0x155473c*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                /*0x15533c4*/ CertificateData(byte[] rawData);
                /*0x1553adc*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);

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

                    /*0x15547b4*/ <ReadReverseRdns>d__21(int <>1__state);
                    /*0x15547e8*/ void System.IDisposable.Dispose();
                    /*0x15547ec*/ bool MoveNext();
                    /*0x1554a80*/ System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current();
                    /*0x1554a8c*/ void System.Collections.IEnumerator.Reset();
                    /*0x1554acc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1554b28*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator();
                    /*0x1554bcc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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
            static /*0x1554bd0*/ bool DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.SafeHandle hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, ref Microsoft.Win32.SafeHandles.SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
            static /*0x1554dd4*/ bool DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.HandleRef hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, ref Microsoft.Win32.SafeHandles.SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
            static /*0x1554f50*/ nint GetCurrentProcess();
            static /*0x1554f54*/ bool GetExitCodeProcess(nint processHandle, ref int exitCode);
            static /*0x1554f58*/ bool GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, ref int exitCode);
            static /*0x1555040*/ int GetCurrentProcessId();
            static /*0x1555044*/ bool CloseProcess(nint handle);
        }

        namespace SafeHandles
        {
            class SafeProcessHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle InvalidHandle;

                static /*0x155507c*/ SafeProcessHandle();
                /*0x1555048*/ SafeProcessHandle(nint handle);
                /*0x1554f24*/ SafeProcessHandle(nint existingHandle, bool ownsHandle);
                /*0x1555074*/ bool ReleaseHandle();
            }
        }
    }
}

namespace System
{
    class IPv4AddressHelper
    {
        static /*0x1555108*/ int ParseHostNumber(System.ReadOnlySpan<char> str, int start, int end);
        static /*0x15551c4*/ bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme);
        static /*0x1555138*/ bool ParseCanonical(System.ReadOnlySpan<char> name, byte* numbers, int start, int end);
        static /*0x15551f4*/ bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile);
        static /*0x1555334*/ long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile);
        static /*0x1555628*/ string ParseCanonicalName(string str, int start, int end, ref bool isLoopback);
        static /*0x1555850*/ bool Parse(string name, byte* numbers, int start, int end);
    }

    class IPv6AddressHelper
    {
        static /*0xe9526c*/ System.ValueTuple<int, int> FindCompressionRange(System.ReadOnlySpan<ushort> numbers);
        static /*0xe9534c*/ bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<ushort> numbers);
        static /*0xe9541c*/ bool IsValidStrict(char* name, int start, ref int end);
        static /*0xe95760*/ void Parse(System.ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId);
        static /*0xe95c6c*/ string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId);
        static /*0xe962a8*/ bool IsLoopback(System.ReadOnlySpan<ushort> numbers);
        static /*0xe96388*/ bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress);
        static /*0xe96664*/ bool IsValid(char* name, int start, ref int end);
    }

    class NotImplemented
    {
        static /*0xe9666c*/ System.Exception ByDesignWithMessage(string message);
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

        /*0xe966d0*/ UriBuilder(System.Uri uri);
        /*0xe96844*/ void Init(System.Uri uri);
        /*0xe96b1c*/ void set_Path(string value);
        /*0xe96bd0*/ System.Uri get_Uri();
        /*0xe96c68*/ bool Equals(object rparam);
        /*0xe96cc4*/ int GetHashCode();
        /*0xe969b8*/ void SetFieldsFromUri(System.Uri uri);
        /*0xe96ce4*/ string ToString();
    }

    class SecurityUtils
    {
        static /*0xe972ac*/ void DemandReflectionAccess(System.Type type);
        static /*0xe972b0*/ void DemandGrantSet(System.Reflection.Assembly assembly);
        static /*0xe972b4*/ bool HasReflectionPermission(System.Type type);
        static /*0xe972bc*/ object SecureCreateInstance(System.Type type);
        static /*0xe972c8*/ object SecureCreateInstance(System.Type type, object[] args, bool allowNonPublic);
        static /*0xe973c0*/ object SecureCreateInstance(System.Type type, object[] args);
        static /*0xe973c8*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic);
        static /*0xe973d4*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic, System.Reflection.BindingFlags extraFlags);
        static /*0xe9754c*/ bool GenericArgumentsAreVisible(System.Reflection.MethodInfo method);
        static /*0xe975ec*/ object MethodInfoInvoke(System.Reflection.MethodInfo method, object target, object[] args);
    }

    class InvariantComparer : System.Collections.IComparer
    {
        static /*0x0*/ System.InvariantComparer Default;
        /*0x10*/ System.Globalization.CompareInfo m_compareInfo;

        static /*0xe97864*/ InvariantComparer();
        /*0xe976fc*/ InvariantComparer();
        /*0xe97778*/ int Compare(object a, object b);
    }

    class IriHelper
    {
        static /*0xe978c4*/ bool CheckIriUnicodeRange(char unicode, bool isQuery);
        static /*0xe9791c*/ bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery);
        static /*0xe97f4c*/ bool CheckIsReserved(char ch, System.UriComponents component);
        static /*0xe98090*/ string EscapeUnescapeIri(char* pInput, int start, int end, System.UriComponents component);
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

        static /*0xd46ecc*/ Uri();
        static /*0xd3a048*/ bool IriParsingStatic(System.UriParser syntax);
        static /*0xd3a268*/ bool StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0xd3a308*/ bool StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0xd3c664*/ System.ParsingError GetCombinedString(System.Uri baseUri, string relativeStr, bool dontEscape, ref string result);
        static /*0xd3d484*/ System.UriFormatException GetException(System.ParsingError err);
        static /*0xd3e838*/ bool StaticIsFile(System.UriParser syntax);
        static /*0xd3e850*/ object get_InitializeLock();
        static /*0xd3e924*/ void InitializeUriConfig();
        static /*0xd3f6e4*/ System.UriHostNameType CheckHostName(string name);
        static /*0xd3f908*/ bool IsGenDelim(char ch);
        static /*0xd3f954*/ bool IsHexDigit(char character);
        static /*0xd3f990*/ int FromHex(char digit);
        static /*0xd3fefc*/ bool op_Equality(System.Uri uri1, System.Uri uri2);
        static /*0xd3c2d8*/ bool op_Inequality(System.Uri uri1, System.Uri uri2);
        static /*0xd40570*/ string InternalEscapeString(string rawString);
        static /*0xd40650*/ System.ParsingError ParseScheme(string uriString, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0xd426d8*/ string CreateHostStringHelper(string str, ushort idx, ushort end, ref System.Uri.Flags flags, ref string scopeId);
        static /*0xd40730*/ ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0xd448a0*/ bool CheckKnownSchemes(long* lptr, ushort nChars, ref System.UriParser syntax);
        static /*0xd3c8b4*/ System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref System.UriParser syntax);
        static /*0xd455c0*/ void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3);
        static /*0xd3eac4*/ char[] Compress(char[] dest, ushort start, ref int destLength, System.UriParser syntax);
        static /*0xd3fb78*/ int CalculateCaseInsensitiveHashCode(string text);
        static /*0xd3ca10*/ string CombineUri(System.Uri basePart, string relativePart, System.UriFormat uriFormat);
        static /*0xd41354*/ bool IsLWS(char ch);
        static /*0xd41394*/ bool IsAsciiLetter(char character);
        static /*0xd457e8*/ bool IsAsciiLetterOrDigit(char character);
        static /*0xd45864*/ bool IsBidiControlCharacter(char ch);
        static /*0xd453b4*/ string StripBidiControlCharacter(char* strToClean, int start, int length);
        static /*0xd404b8*/ bool TryCreate(string uriString, System.UriKind uriKind, ref System.Uri result);
        static /*0xd46364*/ bool TryCreate(System.Uri baseUri, string relativeUri, ref System.Uri result);
        static /*0xd46434*/ bool TryCreate(System.Uri baseUri, System.Uri relativeUri, ref System.Uri result);
        static /*0xd467c8*/ string UnescapeDataString(string stringToUnescape);
        static /*0xd46970*/ string EscapeUriString(string stringToEscape);
        static /*0xd46aa0*/ string EscapeDataString(string stringToEscape);
        static /*0xd460f0*/ System.Uri CreateHelper(string uriString, bool dontEscape, System.UriKind uriKind, ref System.UriFormatException e);
        static /*0xd3be1c*/ System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, ref string newUriString, ref bool userEscaped, ref System.UriFormatException e);
        /*0xd3b8f0*/ Uri(string uriString);
        /*0xd3bb34*/ Uri(string uriString, System.UriKind uriKind);
        /*0xd3bbbc*/ Uri(System.Uri baseUri, string relativeUri);
        /*0xd3c440*/ Uri(System.Uri baseUri, System.Uri relativeUri);
        /*0xd3d624*/ Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0xd46bd0*/ Uri(System.Uri.Flags flags, System.UriParser uriParser, string uri);
        /*0xd39ff0*/ bool get_IsImplicitFile();
        /*0xd39ffc*/ bool get_IsUncOrDosPath();
        /*0xd3a00c*/ bool get_IsDosPath();
        /*0xd3a018*/ bool get_IsUncPath();
        /*0xd3a024*/ System.Uri.Flags get_HostType();
        /*0xd3a030*/ System.UriParser get_Syntax();
        /*0xd3a038*/ bool get_IsNotAbsoluteUri();
        /*0xd3a0d4*/ bool get_AllowIdn();
        /*0xd3a1a0*/ bool AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags);
        /*0xd3a274*/ bool IsIntranet(string schemeHost);
        /*0xd3a27c*/ bool get_UserDrivenParsing();
        /*0xd3a288*/ void SetUserDrivenParsing();
        /*0xd3a29c*/ ushort get_SecuredPathIndex();
        /*0xd3a190*/ bool NotAny(System.Uri.Flags flags);
        /*0xd3a2f8*/ bool InFact(System.Uri.Flags flags);
        /*0xd3a314*/ System.Uri.UriInfo EnsureUriInfo();
        /*0xd3a8cc*/ void EnsureParseRemaining();
        /*0xd3b494*/ void EnsureHostString(bool allowDnsOptimization);
        /*0xd3bc94*/ void CreateUri(System.Uri baseUri, string relativeUri, bool dontEscape);
        /*0xd3d728*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0xd3d72c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0xd3d808*/ string get_AbsolutePath();
        /*0xd3d8d0*/ string get_PrivateAbsolutePath();
        /*0xd3d978*/ string get_AbsoluteUri();
        /*0xd3da7c*/ string get_LocalPath();
        /*0xd3e0e4*/ string get_Authority();
        /*0xd3e160*/ System.UriHostNameType get_HostNameType();
        /*0xd3e260*/ bool get_IsDefaultPort();
        /*0xd3e310*/ bool get_IsFile();
        /*0xd3e3d8*/ bool get_IsLoopback();
        /*0xd3e460*/ string get_PathAndQuery();
        /*0xd3e530*/ string[] get_Segments();
        /*0xd3e740*/ bool get_IsUnc();
        /*0xd3e7bc*/ string get_Host();
        /*0xd3daf0*/ string GetLocalPath();
        /*0xd3f06c*/ int get_Port();
        /*0xd3f138*/ string get_Query();
        /*0xd3f240*/ string get_Fragment();
        /*0xd3f348*/ string get_Scheme();
        /*0xd3f3c0*/ bool get_OriginalStringSwitched();
        /*0xd3c9e8*/ string get_OriginalString();
        /*0xd3f408*/ string get_DnsSafeHost();
        /*0xd3bc84*/ bool get_IsAbsoluteUri();
        /*0xd3f65c*/ bool get_UserEscaped();
        /*0xd3f668*/ string get_UserInfo();
        /*0xd3fa40*/ int GetHashCode();
        /*0xd3fc18*/ string ToString();
        /*0xd3ff30*/ bool Equals(object comparand);
        /*0xd40c6c*/ System.UriFormatException ParseMinimal();
        /*0xd40cec*/ System.ParsingError PrivateParseMinimal();
        /*0xd421c4*/ void PrivateParseMinimalIri(string newHost, ushort idx);
        /*0xd3a338*/ void CreateUriInfo(System.Uri.Flags cF);
        /*0xd3b4f4*/ void CreateHostString();
        /*0xd42298*/ void GetHostViaCustomSyntax();
        /*0xd3d804*/ string GetParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0xd42e90*/ string GetEscapedParts(System.UriComponents uriParts);
        /*0xd3ef9c*/ string GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0xd43508*/ string ReCreateParts(System.UriComponents parts, ushort nonCanonical, System.UriFormat formatAs);
        /*0xd42f58*/ string GetUriPartsFromUserString(System.UriComponents uriParts);
        /*0xd3a8dc*/ void ParseRemaining();
        /*0xd413c0*/ ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, System.UriParser syntax, ref string newHost);
        /*0xd44da0*/ void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, System.UriParser syntax, string userInfoString, ref System.Uri.Flags flags, ref bool justNormalized, ref string newHost, ref System.ParsingError err);
        /*0xd450f0*/ void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, System.UriParser syntax, ref System.Uri.Flags flags, ref string newHost, ref System.ParsingError err);
        /*0xd447fc*/ void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim);
        /*0xd4552c*/ void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim);
        /*0xd428bc*/ System.Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim);
        /*0xd44194*/ char[] GetCanonicalPath(char[] dest, ref int pos, System.UriFormat formatAs);
        /*0xd457dc*/ bool get_HasAuthority();
        /*0xd3b974*/ void CreateThis(string uri, bool dontEscape, System.UriKind uriKind);
        /*0xd458ac*/ void InitializeUri(System.ParsingError err, System.UriKind uriKind, ref System.UriFormatException e);
        /*0xd45d80*/ bool CheckForConfigLoad(string data);
        /*0xd45e2c*/ bool CheckForUnicode(string data);
        /*0xd45f44*/ bool CheckForEscapedUnreserved(string data);
        /*0xd42cb4*/ string GetComponents(System.UriComponents components, System.UriFormat format);
        /*0xd44850*/ string EscapeUnescapeIri(string input, int start, int end, System.UriComponents component);
        /*0xd465a8*/ string GetRelativeSerializationString(System.UriFormat format);
        /*0xd3fce4*/ string GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0xd46c10*/ bool IsBaseOf(System.Uri uri);
        /*0xd46cc8*/ bool IsBaseOfHelper(System.Uri uriLink);
        /*0xd3c320*/ void CreateThisFromUri(System.Uri otherUri);

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

            /*0xe98fc8*/ UriInfo();
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

            /*0xe98fd0*/ MoreInfo();
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
        /*0xe98fd8*/ UriFormatException();
        /*0xe971b0*/ UriFormatException(string textString);
        /*0xe98fe0*/ UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0xe98fe8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

        static /*0xe9a534*/ UriHelper();
        static /*0xe98ff0*/ bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase);
        static /*0xe991f4*/ char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd);
        static /*0xe99730*/ char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos);
        static /*0xe99a44*/ char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0xe99b24*/ char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0xe989d8*/ void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing);
        static /*0xe98ec0*/ void EscapeAsciiChar(char ch, char[] to, ref int pos);
        static /*0xe9888c*/ char EscapedAscii(char digit, char next);
        static /*0xe9894c*/ bool IsNotSafeForUnescape(char ch);
        static /*0xe9993c*/ bool IsReservedUnreservedOrHash(char c);
        static /*0xe9985c*/ bool IsUnreserved(char c);
        static /*0xe9a498*/ bool Is3986Unreserved(char c);
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

        static /*0xe9aa34*/ UriParser();
        static /*0xe9a438*/ bool get_ShouldUseLegacyV2Quirks();
        static /*0xe9b310*/ System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme);
        static /*0xe971b8*/ System.UriParser GetSyntax(string lwrCaseScheme);
        /*0xe9b2a4*/ UriParser(System.UriSyntaxFlags flags);
        /*0xe9a5c8*/ string get_SchemeName();
        /*0xe9a5d0*/ int get_DefaultPort();
        /*0xe9a5d8*/ System.UriParser OnNewUri();
        /*0xe9a5dc*/ void InitializeAndValidate(System.Uri uri, ref System.UriFormatException parsingError);
        /*0xe9a604*/ string Resolve(System.Uri baseUri, System.Uri relativeUri, ref System.UriFormatException parsingError);
        /*0xe9a7ec*/ bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri);
        /*0xe9a808*/ string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format);
        /*0xe9b238*/ System.UriSyntaxFlags get_Flags();
        /*0xe972a4*/ bool NotAny(System.UriSyntaxFlags flags);
        /*0xe97288*/ bool InFact(System.UriSyntaxFlags flags);
        /*0xe9b29c*/ bool IsAllSet(System.UriSyntaxFlags flags);
        /*0xe9b240*/ bool IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected);
        /*0xe9b600*/ bool get_IsSimple();
        /*0xe9b60c*/ System.UriParser InternalOnNewUri();
        /*0xe9b650*/ void InternalValidate(System.Uri thisUri, ref System.UriFormatException parsingError);
        /*0xe9b65c*/ string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, ref System.UriFormatException parsingError);
        /*0xe9b668*/ bool InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink);
        /*0xe9b674*/ string InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat);

        enum UriQuirksVersion
        {
            V2 = 2,
            V3 = 3,
        }

        class BuiltInUriParser : System.UriParser
        {
            /*0xe9b1b8*/ BuiltInUriParser(string lwrCaseScheme, int defaultPort, System.UriSyntaxFlags syntaxFlags);
        }
    }

    class DomainNameHelper
    {
        static /*0xe9b680*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0xe9b820*/ bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0xe9ba4c*/ bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0xe9bc34*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0xe9beb0*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost);
        static /*0xe9c0f0*/ bool IsIdnAce(string input, int index);
        static /*0xe9c0a4*/ bool IsIdnAce(char* input, int index);
        static /*0xe9c188*/ string UnicodeEquivalent(string idnHost, char* hostname, int start, int end);
        static /*0xe9c2a4*/ string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0xe9b99c*/ bool IsASCIILetterOrDigit(char character, ref bool notCanonical);
        static /*0xe9b9e8*/ bool IsValidDomainLabelCharacter(char character, ref bool notCanonical);
    }

    class UncNameHelper
    {
        static /*0xe9c6fc*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0xe9c700*/ bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile);
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
        /*0xe9c9d8*/ IOAsyncCallback(object object, nint method);
        /*0xe9cb04*/ void Invoke(System.IOAsyncResult ioares);
    }

    class IOAsyncResult : System.IAsyncResult
    {
        /*0x10*/ System.AsyncCallback async_callback;
        /*0x18*/ object async_state;
        /*0x20*/ System.Threading.ManualResetEvent wait_handle;
        /*0x28*/ bool completed_synchronously;
        /*0x29*/ bool completed;

        /*0xe9cb18*/ IOAsyncResult();
        /*0xe9cb40*/ IOAsyncResult(System.AsyncCallback async_callback, object async_state);
        /*0xe9cb20*/ void Init(System.AsyncCallback async_callback, object async_state);
        /*0xe9cb6c*/ System.AsyncCallback get_AsyncCallback();
        /*0xe9cb74*/ object get_AsyncState();
        /*0xe9cb7c*/ System.Threading.WaitHandle get_AsyncWaitHandle();
        /*0xe9cca0*/ bool get_CompletedSynchronously();
        /*0xe9cca8*/ void set_CompletedSynchronously(bool value);
        /*0xe9ccb4*/ bool get_IsCompleted();
        /*0xe9ccbc*/ void set_IsCompleted(bool value);
        void CompleteDisposed();
    }

    class IOSelectorJob : System.Threading.IThreadPoolWorkItem
    {
        /*0x10*/ System.IOOperation operation;
        /*0x18*/ System.IOAsyncCallback callback;
        /*0x20*/ System.IOAsyncResult state;

        /*0xe9cd94*/ IOSelectorJob(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state);
        /*0xe9cdd0*/ void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem();
        /*0xe9cdf8*/ void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae);
        /*0xe9cdfc*/ void MarkDisposed();
    }

    class IOSelector
    {
        static /*0xe9ce1c*/ void Add(nint handle, System.IOSelectorJob job);
    }

    class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        /*0xe9ce20*/ UriTypeConverter();
        /*0xe9ce28*/ bool CanConvert(System.Type type);
        /*0xe9cf0c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
        /*0xe9cfc0*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        /*0xe9d038*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        /*0xe9d1e4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
    }

    namespace Timers
    {
        class ElapsedEventHandler : System.MulticastDelegate
        {
            /*0xe9d3d0*/ ElapsedEventHandler(object object, nint method);
            /*0xe9d500*/ void Invoke(object sender, System.Timers.ElapsedEventArgs e);
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

            static /*0xe9d710*/ int CalculateRoundedInterval(double interval, bool argumentCheck);
            /*0xe9d514*/ Timer();
            /*0xe9d5d8*/ Timer(double interval);
            /*0xe9d934*/ void set_Enabled(bool value);
            /*0xe9db00*/ void UpdateTimer();
            /*0xe9db40*/ void add_Elapsed(System.Timers.ElapsedEventHandler value);
            /*0xe9dbc0*/ void remove_Elapsed(System.Timers.ElapsedEventHandler value);
            /*0xe9dc40*/ System.ComponentModel.ISite get_Site();
            /*0xe9dc48*/ System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject();
            /*0xe9dde8*/ void Close();
            /*0xe9de14*/ void Dispose(bool disposing);
            /*0xe9de60*/ void MyTimerCallback(object state);
        }

        class TimersDescriptionAttribute : System.ComponentModel.DescriptionAttribute
        {
            /*0x18*/ bool replaced;

            /*0xe9e1e4*/ TimersDescriptionAttribute(string description);
            /*0xe9e24c*/ string get_Description();
        }

        class ElapsedEventArgs : System.EventArgs
        {
            /*0x10*/ System.DateTime time;

            /*0xe9e178*/ ElapsedEventArgs(System.DateTime time);
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

                /*0xe9e28c*/ Capture(string text, int index, int length);
                /*0xe9e2c8*/ int get_Index();
                /*0xe9e2d0*/ void set_Index(int value);
                /*0xe9e2d8*/ int get_Length();
                /*0xe9e2e0*/ void set_Length(int value);
                /*0xe9e2e8*/ string get_Text();
                /*0xe9e2f0*/ void set_Text(string value);
                /*0xe9e2f8*/ string get_Value();
                /*0xe9e31c*/ string ToString();
            }

            class CaptureCollection
            {
                /*0x10*/ System.Text.RegularExpressions.Group _group;
                /*0x18*/ int _capcount;
                /*0x20*/ System.Text.RegularExpressions.Capture[] _captures;
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

                static /*0xe9e3cc*/ Group();
                /*0xe9e320*/ Group(string text, int[] caps, int capcount, string name);
                /*0xe9e4c8*/ Group();
                /*0xe9e3bc*/ bool get_Success();
            }

            class GroupCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Match _match;
                /*0x18*/ System.Collections.Hashtable _captureMap;
                /*0x20*/ System.Text.RegularExpressions.Group[] _groups;

                /*0xe9e500*/ GroupCollection(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps);
                /*0xe9f5e4*/ GroupCollection();
                /*0xe9e52c*/ bool get_IsReadOnly();
                /*0xe9e534*/ int get_Count();
                /*0xe9e558*/ System.Text.RegularExpressions.Group get_Item(int groupnum);
                /*0xe9e660*/ System.Text.RegularExpressions.Group get_Item(string groupname);
                /*0xe9e83c*/ System.Collections.IEnumerator GetEnumerator();
                /*0xe9e8d8*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator();
                /*0xe9e55c*/ System.Text.RegularExpressions.Group GetGroup(int groupnum);
                /*0xe9e944*/ System.Text.RegularExpressions.Group GetGroupImpl(int groupnum);
                /*0xe9ec6c*/ bool get_IsSynchronized();
                /*0xe9ec74*/ object get_SyncRoot();
                /*0xe9ec7c*/ void CopyTo(System.Array array, int arrayIndex);
                /*0xe9ed3c*/ void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex);
                /*0xe9eec0*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item);
                /*0xe9ef78*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item);
                /*0xe9efc8*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index);
                /*0xe9f018*/ System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index);
                /*0xe9f01c*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, System.Text.RegularExpressions.Group value);
                /*0xe9f06c*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item);
                /*0xe9f0bc*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear();
                /*0xe9f10c*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item);
                /*0xe9f1c0*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item);
                /*0xe9f210*/ int System.Collections.IList.Add(object value);
                /*0xe9f260*/ void System.Collections.IList.Clear();
                /*0xe9f2b0*/ bool System.Collections.IList.Contains(object value);
                /*0xe9f3a4*/ int System.Collections.IList.IndexOf(object value);
                /*0xe9f498*/ void System.Collections.IList.Insert(int index, object value);
                /*0xe9f4e8*/ bool System.Collections.IList.get_IsFixedSize();
                /*0xe9f4f0*/ void System.Collections.IList.Remove(object value);
                /*0xe9f540*/ void System.Collections.IList.RemoveAt(int index);
                /*0xe9f590*/ object System.Collections.IList.get_Item(int index);
                /*0xe9f594*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.GroupCollection _collection;
                    /*0x18*/ int _index;

                    /*0xe9e8a8*/ Enumerator(System.Text.RegularExpressions.GroupCollection collection);
                    /*0xe9f61c*/ bool MoveNext();
                    /*0xe9f660*/ System.Text.RegularExpressions.Group get_Current();
                    /*0xe9f6f0*/ object System.Collections.IEnumerator.get_Current();
                    /*0xe9f6f4*/ void System.Collections.IEnumerator.Reset();
                    /*0xe9f700*/ void System.IDisposable.Dispose();
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

                static /*0xea02a0*/ Match();
                static /*0xe9f874*/ System.Text.RegularExpressions.Match get_Empty();
                /*0xe9f704*/ Match(System.Text.RegularExpressions.Regex regex, int capcount, string text, int begpos, int len, int startpos);
                /*0xea0338*/ Match();
                /*0xe9f8cc*/ void Reset(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart);
                /*0xe9f930*/ System.Text.RegularExpressions.GroupCollection get_Groups();
                /*0xe9f9a0*/ System.Text.RegularExpressions.Match NextMatch();
                /*0xe9fc60*/ void AddMatch(int cap, int start, int len);
                /*0xe9fe84*/ void BalanceMatch(int cap);
                /*0xe9ff5c*/ void RemoveMatch(int cap);
                /*0xe9ff94*/ bool IsMatched(int cap);
                /*0xea0024*/ int MatchIndex(int cap);
                /*0xea00b0*/ int MatchLength(int cap);
                /*0xea013c*/ void Tidy(int textpos);
            }

            class MatchSparse : System.Text.RegularExpressions.Match
            {
                /*0x78*/ System.Collections.Hashtable _caps;

                /*0xea0370*/ MatchSparse(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, int capcount, string text, int begpos, int len, int startpos);
                /*0xea0420*/ System.Text.RegularExpressions.GroupCollection get_Groups();
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

                /*0xea0494*/ MatchCollection(System.Text.RegularExpressions.Regex regex, string input, int beginning, int length, int startat);
                /*0xea1110*/ MatchCollection();
                /*0xea05c4*/ bool get_IsReadOnly();
                /*0xea05cc*/ int get_Count();
                /*0xea063c*/ System.Text.RegularExpressions.Match get_Item(int i);
                /*0xea080c*/ System.Collections.IEnumerator GetEnumerator();
                /*0xea08a8*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator();
                /*0xea06a0*/ System.Text.RegularExpressions.Match GetMatch(int i);
                /*0xea0628*/ void EnsureInitialized();
                /*0xea0914*/ bool get_IsSynchronized();
                /*0xea091c*/ object get_SyncRoot();
                /*0xea0920*/ void CopyTo(System.Array array, int arrayIndex);
                /*0xea09ec*/ void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex);
                /*0xea0a68*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item);
                /*0xea0ad4*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, System.Text.RegularExpressions.Match item);
                /*0xea0b24*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index);
                /*0xea0b74*/ System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index);
                /*0xea0b84*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, System.Text.RegularExpressions.Match value);
                /*0xea0bd4*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item);
                /*0xea0c24*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear();
                /*0xea0c74*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item);
                /*0xea0ce0*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item);
                /*0xea0d30*/ int System.Collections.IList.Add(object value);
                /*0xea0d80*/ void System.Collections.IList.Clear();
                /*0xea0dd0*/ bool System.Collections.IList.Contains(object value);
                /*0xea0ec4*/ int System.Collections.IList.IndexOf(object value);
                /*0xea0fb8*/ void System.Collections.IList.Insert(int index, object value);
                /*0xea1008*/ bool System.Collections.IList.get_IsFixedSize();
                /*0xea1010*/ void System.Collections.IList.Remove(object value);
                /*0xea1060*/ void System.Collections.IList.RemoveAt(int index);
                /*0xea10b0*/ object System.Collections.IList.get_Item(int index);
                /*0xea10c0*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.MatchCollection _collection;
                    /*0x18*/ int _index;

                    /*0xea0878*/ Enumerator(System.Text.RegularExpressions.MatchCollection collection);
                    /*0xea1148*/ bool MoveNext();
                    /*0xea1198*/ System.Text.RegularExpressions.Match get_Current();
                    /*0xea1204*/ object System.Collections.IEnumerator.get_Current();
                    /*0xea1208*/ void System.Collections.IEnumerator.Reset();
                    /*0xea1214*/ void System.IDisposable.Dispose();
                }
            }

            class ExclusiveReference
            {
                /*0x10*/ System.Text.RegularExpressions.RegexRunner _ref;
                /*0x18*/ System.Text.RegularExpressions.RegexRunner _obj;
                /*0x20*/ int _locked;

                /*0xea132c*/ ExclusiveReference();
                /*0xea1218*/ System.Text.RegularExpressions.RegexRunner Get();
                /*0xea1270*/ void Release(System.Text.RegularExpressions.RegexRunner obj);
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

                static /*0xea2d50*/ Regex();
                static /*0xea1d2c*/ bool TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0xea1e48*/ bool TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0xea1914*/ System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key);
                static /*0xea1f1c*/ bool IsMatch(string input, string pattern);
                static /*0xea201c*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0xea1f90*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0xea26c0*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator);
                static /*0xea273c*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0xea2918*/ string Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0xea30c8*/ void ValidateMatchTimeout(System.TimeSpan matchTimeout);
                static /*0xea2e88*/ System.TimeSpan InitDefaultMatchTimeout();
                /*0xea3224*/ Regex(string pattern);
                /*0xea329c*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options);
                /*0xea2094*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, bool addToCache);
                /*0xea1334*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0xea145c*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0xea1c28*/ void FillCacheDictionary();
                /*0xea240c*/ bool IsMatch(string input);
                /*0xea2488*/ bool IsMatch(string input, int startat);
                /*0xea2508*/ System.Text.RegularExpressions.Match Match(string input);
                /*0xea2578*/ System.Text.RegularExpressions.Match Match(string input, int startat);
                /*0xea25ec*/ System.Text.RegularExpressions.MatchCollection Matches(string input, int startat);
                /*0xea27d0*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator);
                /*0xea2844*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat);
                /*0xea3318*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0xea3468*/ System.Text.RegularExpressions.RegexOptions get_Options();
                /*0xea2d44*/ bool get_RightToLeft();
                /*0xea3470*/ string ToString();
                /*0xe9eb24*/ string GroupNameFromNumber(int i);
                /*0xe9e6f0*/ int GroupNumberFromName(string name);
                /*0xea3364*/ void InitializeReferences();
                /*0xe9f9d0*/ System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat);
                /*0xea247c*/ bool UseOptionR();
                /*0xea3478*/ bool UseOptionInvariant();

                struct CachedCodeEntryKey : System.IEquatable<System.Text.RegularExpressions.Regex.CachedCodeEntryKey>
                {
                    /*0x10*/ System.Text.RegularExpressions.RegexOptions _options;
                    /*0x18*/ string _cultureKey;
                    /*0x20*/ string _pattern;

                    static /*0xea142c*/ bool op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right);
                    /*0xea3358*/ CachedCodeEntryKey(System.Text.RegularExpressions.RegexOptions options, string cultureKey, string pattern);
                    /*0xea3484*/ bool Equals(object obj);
                    /*0xea3514*/ bool Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other);
                    /*0xea357c*/ int GetHashCode();
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

                    /*0xea1bb0*/ CachedCodeEntry(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref);
                }
            }

            class MatchEvaluator : System.MulticastDelegate
            {
                /*0xea35d4*/ MatchEvaluator(object object, nint method);
                /*0xea3700*/ string Invoke(System.Text.RegularExpressions.Match match);
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

                /*0xea3714*/ RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, System.Globalization.CultureInfo culture);
                /*0xea3bc8*/ bool MatchPattern(string text, int index);
                /*0xea3cec*/ bool IsMatch(string text, int index, int beglimit, int endlimit);
                /*0xea3d58*/ int Scan(string text, int index, int beglimit, int endlimit);
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

                static /*0xea62b4*/ RegexCharClass();
                static /*0xea5208*/ char SingletonChar(string set);
                static /*0xea5220*/ bool IsMergeable(string charClass);
                static /*0xea533c*/ bool IsEmpty(string charClass);
                static /*0xea53fc*/ bool IsSingleton(string set);
                static /*0xea5508*/ bool IsSingletonInverse(string set);
                static /*0xea52e4*/ bool IsSubtraction(string charClass);
                static /*0xea52bc*/ bool IsNegated(string set);
                static /*0xea5618*/ bool IsECMAWordChar(char ch);
                static /*0xea56ec*/ bool IsWordChar(char ch);
                static /*0xea5684*/ bool CharInClass(char ch, string set);
                static /*0xea576c*/ bool CharInClassRecursive(char ch, string set, int start);
                static /*0xea5894*/ bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0xea59a4*/ bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0xea5b2c*/ bool CharInCategoryGroup(char ch, System.Globalization.UnicodeCategory chcategory, string category, ref int i);
                static /*0xea48f8*/ string NegateCategory(string category);
                static /*0xea5bfc*/ System.Text.RegularExpressions.RegexCharClass Parse(string charClass);
                static /*0xea5c54*/ System.Text.RegularExpressions.RegexCharClass ParseRecursive(string charClass, int start);
                static /*0xea4980*/ string SetFromProperty(string capname, bool invert, string pattern);
                /*0xea403c*/ RegexCharClass();
                /*0xea40f8*/ RegexCharClass(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction);
                /*0xea4144*/ bool get_CanMerge();
                /*0xea4164*/ void set_Negate(bool value);
                /*0xea4170*/ void AddChar(char c);
                /*0xea4298*/ void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc);
                /*0xea44b4*/ void AddSet(string set);
                /*0xea46e0*/ void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub);
                /*0xea4178*/ void AddRange(char first, char last);
                /*0xea46e8*/ void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern);
                /*0xea4be4*/ void AddCategory(string category);
                /*0xea4c00*/ void AddLowercase(System.Globalization.CultureInfo culture);
                /*0xea4d3c*/ void AddLowercaseRange(char chMin, char chMax, System.Globalization.CultureInfo culture);
                /*0xea4f6c*/ void AddWord(bool ecma, bool negate);
                /*0xea5060*/ void AddSpace(bool ecma, bool negate);
                /*0xea5154*/ void AddDigit(bool ecma, bool negate, string pattern);
                /*0xea440c*/ int RangeCount();
                /*0xea5edc*/ string ToStringClass();
                /*0xea4454*/ System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(int i);
                /*0xea6078*/ void Canonicalize();

                struct LowerCaseMapping
                {
                    /*0x10*/ char ChMin;
                    /*0x12*/ char ChMax;
                    /*0x14*/ int LcOp;
                    /*0x18*/ int Data;

                    /*0xe59f7c*/ LowerCaseMapping(char chMin, char chMax, int lcOp, int data);
                }

                class SingleRangeComparer : System.Collections.Generic.IComparer<System.Text.RegularExpressions.RegexCharClass.SingleRange>
                {
                    static /*0x0*/ System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer Instance;

                    static /*0xe59fb4*/ SingleRangeComparer();
                    /*0xe59f8c*/ SingleRangeComparer();
                    /*0xe59f94*/ int Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y);
                }

                struct SingleRange
                {
                    /*0x10*/ char First;
                    /*0x12*/ char Last;

                    /*0xe5a018*/ SingleRange(char first, char last);
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

                static /*0xe5a0f4*/ bool OpcodeBacktracks(int Op);
                /*0xe5a024*/ RegexCode(int[] codes, System.Collections.Generic.List<string> stringlist, int trackcount, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft);
            }

            struct RegexFCD
            {
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack;
                /*0x18*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x38*/ bool _skipAllChildren;
                /*0x39*/ bool _skipchild;
                /*0x3a*/ bool _failed;

                static /*0xe5a1f8*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t);
                static /*0xe5a5a0*/ System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree);
                static /*0xe5a85c*/ int Anchors(System.Text.RegularExpressions.RegexTree tree);
                static /*0xe5a98c*/ int AnchorFromType(int type);
                /*0xe5a124*/ RegexFCD(System.Span<int> intStack);
                /*0xe5a9fc*/ void PushInt(int i);
                /*0xe5aab0*/ bool IntIsEmpty();
                /*0xe5aaf4*/ int PopInt();
                /*0xe5ab50*/ void PushFC(System.Text.RegularExpressions.RegexFC fc);
                /*0xe5abf8*/ bool FCIsEmpty();
                /*0xe5ac48*/ System.Text.RegularExpressions.RegexFC PopFC();
                /*0xe5acc4*/ System.Text.RegularExpressions.RegexFC TopFC();
                /*0xe5a510*/ void Dispose();
                /*0xe5a378*/ System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0xe5b114*/ void SkipChild();
                /*0xe5ad28*/ void CalculateFC(int NodeType, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }

            class RegexFC
            {
                /*0x10*/ System.Text.RegularExpressions.RegexCharClass _cc;
                /*0x18*/ bool _nullable;
                /*0x19*/ bool <CaseInsensitive>k__BackingField;

                /*0xe5b120*/ RegexFC(bool nullable);
                /*0xe5b24c*/ RegexFC(char ch, bool not, bool nullable, bool caseInsensitive);
                /*0xe5b340*/ RegexFC(string charClass, bool nullable, bool caseInsensitive);
                /*0xe5b1a0*/ bool AddFC(System.Text.RegularExpressions.RegexFC fc, bool concatenate);
                /*0xe5b3d4*/ bool get_CaseInsensitive();
                /*0xe5b3dc*/ void set_CaseInsensitive(bool value);
                /*0xe5a558*/ string GetFirstChars(System.Globalization.CultureInfo culture);
            }

            class RegexInterpreter : System.Text.RegularExpressions.RegexRunner
            {
                /*0x80*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x88*/ System.Globalization.CultureInfo _culture;
                /*0x90*/ int _operator;
                /*0x94*/ int _codepos;
                /*0x98*/ bool _rightToLeft;
                /*0x99*/ bool _caseInsensitive;

                /*0xe5b3e8*/ RegexInterpreter(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture);
                /*0xe5b41c*/ void InitTrackCount();
                /*0xe5b43c*/ void Advance(int i);
                /*0xe5b4c0*/ void Goto(int newpos);
                /*0xe5b580*/ void Textto(int newpos);
                /*0xe5b588*/ void Trackto(int newpos);
                /*0xe5b5ac*/ int Textstart();
                /*0xe5b5b4*/ int Textpos();
                /*0xe5b5bc*/ int Trackpos();
                /*0xe5b5e0*/ void TrackPush();
                /*0xe5b620*/ void TrackPush(int I1);
                /*0xe5b67c*/ void TrackPush(int I1, int I2);
                /*0xe5b6f4*/ void TrackPush(int I1, int I2, int I3);
                /*0xe5b788*/ void TrackPush2(int I1);
                /*0xe5b7e8*/ void TrackPush2(int I1, int I2);
                /*0xe5b864*/ void Backtrack();
                /*0xe5b4a0*/ void SetOperator(int op);
                /*0xe5b95c*/ void TrackPop();
                /*0xe5b96c*/ void TrackPop(int framesize);
                /*0xe5b97c*/ int TrackPeek();
                /*0xe5b9b4*/ int TrackPeek(int i);
                /*0xe5b9f0*/ void StackPush(int I1);
                /*0xe5ba2c*/ void StackPush(int I1, int I2);
                /*0xe5ba84*/ void StackPop();
                /*0xe5ba94*/ void StackPop(int framesize);
                /*0xe5baa4*/ int StackPeek();
                /*0xe5badc*/ int StackPeek(int i);
                /*0xe5bb18*/ int Operator();
                /*0xe5bb20*/ int Operand(int i);
                /*0xe5bb64*/ int Leftchars();
                /*0xe5bb74*/ int Rightchars();
                /*0xe5bb84*/ int Bump();
                /*0xe5bb98*/ int Forwardchars();
                /*0xe5bbc4*/ char Forwardcharnext();
                /*0xe5bc54*/ bool Stringmatch(string str);
                /*0xe5bdc0*/ bool Refmatch(int index, int len);
                /*0xe5bf5c*/ void Backwardnext();
                /*0xe5bf8c*/ char CharAt(int j);
                /*0xe5bfa8*/ bool FindFirstChar();
                /*0xe5c308*/ void Go();
            }

            class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                /*0x90*/ string <Input>k__BackingField;
                /*0x98*/ string <Pattern>k__BackingField;
                /*0xa0*/ System.TimeSpan <MatchTimeout>k__BackingField;

                /*0xe5d90c*/ RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout);
                /*0xe5d9d8*/ RegexMatchTimeoutException();
                /*0xe5da6c*/ RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xe5dba4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xe5dc78*/ string get_Input();
                /*0xe5dc80*/ string get_Pattern();
                /*0xe5dc88*/ System.TimeSpan get_MatchTimeout();
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

                /*0xe5dc90*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options);
                /*0xe5dcc0*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, char ch);
                /*0xe5dd00*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, string str);
                /*0xe5dd40*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m);
                /*0xe5dd80*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m, int n);
                /*0xe5ddc4*/ bool UseOptionR();
                /*0xe5ddd0*/ System.Text.RegularExpressions.RegexNode ReverseLeft();
                /*0xe5de4c*/ void MakeRep(int type, int min, int max);
                /*0xe5de64*/ System.Text.RegularExpressions.RegexNode Reduce();
                /*0xe5e8c0*/ System.Text.RegularExpressions.RegexNode StripEnation(int emptyType);
                /*0xe5e778*/ System.Text.RegularExpressions.RegexNode ReduceGroup();
                /*0xe5e5ec*/ System.Text.RegularExpressions.RegexNode ReduceRep();
                /*0xe5e7a4*/ System.Text.RegularExpressions.RegexNode ReduceSet();
                /*0xe5decc*/ System.Text.RegularExpressions.RegexNode ReduceAlternation();
                /*0xe5e284*/ System.Text.RegularExpressions.RegexNode ReduceConcatenation();
                /*0xe5e97c*/ System.Text.RegularExpressions.RegexNode MakeQuantifier(bool lazy, int min, int max);
                /*0xe5ea98*/ void AddChild(System.Text.RegularExpressions.RegexNode newChild);
                /*0xe5a804*/ System.Text.RegularExpressions.RegexNode Child(int i);
                /*0xe5a7b8*/ int ChildCount();
                /*0xe5ebac*/ int Type();
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

                static /*0xe63a38*/ RegexParser();
                static /*0xe5ebb4*/ System.Text.RegularExpressions.RegexTree Parse(string re, System.Text.RegularExpressions.RegexOptions op);
                static /*0xe62f54*/ int HexDigit(char ch);
                static /*0xe63050*/ System.Text.RegularExpressions.RegexOptions OptionFromCode(char ch);
                static /*0xe60014*/ bool IsSpecial(char ch);
                static /*0xe5fddc*/ bool IsStopperX(char ch);
                static /*0xe600ac*/ bool IsQuantifier(char ch);
                static /*0xe626b8*/ bool IsSpace(char ch);
                /*0xe5ed50*/ RegexParser(System.Globalization.CultureInfo culture);
                /*0xe5ee10*/ void SetPattern(string Re);
                /*0xe5f1ac*/ void Reset(System.Text.RegularExpressions.RegexOptions topopts);
                /*0xe5f238*/ System.Text.RegularExpressions.RegexNode ScanRegex();
                /*0xe6040c*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly);
                /*0xe60b38*/ System.Text.RegularExpressions.RegexNode ScanGroupOpen();
                /*0xe5fa94*/ void ScanBlank();
                /*0xe618e0*/ System.Text.RegularExpressions.RegexNode ScanBackslash(bool scanOnly);
                /*0xe627e0*/ System.Text.RegularExpressions.RegexNode ScanBasicBackslash(bool scanOnly);
                /*0xe62378*/ string ScanCapname();
                /*0xe62d88*/ char ScanOctal();
                /*0xe61f6c*/ int ScanDecimal();
                /*0xe62e24*/ char ScanHex(int c);
                /*0xe62f8c*/ char ScanControl();
                /*0xe63028*/ bool IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option);
                /*0xe625bc*/ void ScanOptions();
                /*0xe621f8*/ char ScanCharEscape();
                /*0xe62088*/ string ParseProperty();
                /*0xe62750*/ int TypeFromCode(char ch);
                /*0xe5ee6c*/ void CountCaptures();
                /*0xe630b0*/ void NoteCaptureSlot(int i, int pos);
                /*0xe63208*/ void NoteCaptureName(string name, int pos);
                /*0xe633a4*/ void AssignNameSlots();
                /*0xe62530*/ int CaptureSlotFromName(string capname);
                /*0xe62478*/ bool IsCaptureSlot(int i);
                /*0xe62514*/ bool IsCaptureName(string capname);
                /*0xe6246c*/ bool UseOptionN();
                /*0xe60400*/ bool UseOptionI();
                /*0xe61dc4*/ bool UseOptionM();
                /*0xe61e48*/ bool UseOptionS();
                /*0xe5fd78*/ bool UseOptionX();
                /*0xe6207c*/ bool UseOptionE();
                /*0xe5fe74*/ bool IsTrueQuantifier();
                /*0xe60144*/ void AddConcatenate(int pos, int cch, bool isReplacement);
                /*0xe61484*/ void PushGroup();
                /*0xe61778*/ void PopGroup();
                /*0xe61588*/ bool EmptyStack();
                /*0xe5f9e8*/ void StartGroup(System.Text.RegularExpressions.RegexNode openGroup);
                /*0xe614c0*/ void AddAlternate();
                /*0xe61f18*/ void AddConcatenate();
                /*0xe62038*/ void AddConcatenate(bool lazy, int min, int max);
                /*0xe63a18*/ System.Text.RegularExpressions.RegexNode Unit();
                /*0xe6034c*/ void AddUnitOne(char ch);
                /*0xe61e54*/ void AddUnitNotone(char ch);
                /*0xe60a14*/ void AddUnitSet(string cc);
                /*0xe63a20*/ void AddUnitNode(System.Text.RegularExpressions.RegexNode node);
                /*0xe61dd0*/ void AddUnitType(int type);
                /*0xe61638*/ void AddGroup();
                /*0xe60a94*/ void PushOptions();
                /*0xe61848*/ void PopOptions();
                /*0xe631b8*/ bool EmptyOptionsStack();
                /*0xe61420*/ void PopKeepOptions();
                /*0xe61598*/ System.ArgumentException MakeException(string message);
                /*0xe63a28*/ int Textpos();
                /*0xe63a30*/ void Textto(int pos);
                /*0xe61f40*/ char RightCharMoveRight();
                /*0xe5fd84*/ void MoveRight();
                /*0xe6245c*/ void MoveRight(int i);
                /*0xe61f08*/ void MoveLeft();
                /*0xe60330*/ char CharAt(int i);
                /*0xe5fdb8*/ char RightChar();
                /*0xe62434*/ char RightChar(int i);
                /*0xe5fd94*/ int CharsRight();
            }

            struct RegexPrefix
            {
                static /*0x0*/ System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;
                /*0x10*/ bool <CaseInsensitive>k__BackingField;
                /*0x18*/ string <Prefix>k__BackingField;

                static /*0xe63b34*/ RegexPrefix();
                static /*0xe63ad4*/ System.Text.RegularExpressions.RegexPrefix get_Empty();
                /*0xe5a590*/ RegexPrefix(string prefix, bool ci);
                /*0xe63acc*/ bool get_CaseInsensitive();
                /*0xe63b2c*/ string get_Prefix();
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

                /*0xe5b414*/ RegexRunner();
                /*0xe63b9c*/ System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout);
                /*0xe63ea0*/ void StartTimeoutWatch();
                /*0xe5d4e4*/ void CheckTimeout();
                /*0xe640f0*/ void DoCheckTimeout();
                void Go();
                bool FindFirstChar();
                void InitTrackCount();
                /*0xe63ed4*/ void InitMatch();
                /*0xe640b0*/ System.Text.RegularExpressions.Match TidyMatch(bool quick);
                /*0xe5b538*/ void EnsureStorage();
                /*0xe5d6dc*/ bool IsBoundary(int index, int startpos, int endpos);
                /*0xe5d7d4*/ bool IsECMABoundary(int index, int startpos, int endpos);
                /*0xe64264*/ void DoubleTrack();
                /*0xe641c4*/ void DoubleStack();
                /*0xe64304*/ void DoubleCrawl();
                /*0xe643a4*/ void Crawl(int i);
                /*0xe64400*/ int Popcrawl();
                /*0xe5d6b8*/ int Crawlpos();
                /*0xe5d628*/ void Capture(int capnum, int start, int end);
                /*0xe5d514*/ void TransferCapture(int capnum, int uncapnum, int start, int end);
                /*0xe5d688*/ void Uncapture();
                /*0xe5d4f4*/ bool IsMatched(int cap);
                /*0xe5d8cc*/ int MatchIndex(int cap);
                /*0xe5d8ec*/ int MatchLength(int cap);
            }

            class RegexRunnerFactory
            {
                System.Text.RegularExpressions.RegexRunner CreateInstance();
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

                /*0xe5f980*/ RegexTree(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, int[] capNumList, int capTop, System.Collections.Hashtable capNames, string[] capsList, System.Text.RegularExpressions.RegexOptions options);
            }

            struct RegexWriter
            {
                /*0x10*/ System.Collections.Generic.ValueListBuilder<int> _emitted;
                /*0x30*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x50*/ System.Collections.Generic.Dictionary<string, int> _stringHash;
                /*0x58*/ System.Collections.Generic.List<string> _stringTable;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ int _trackCount;

                static /*0xe64584*/ System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree);
                /*0xe6443c*/ RegexWriter(System.Span<int> emittedSpan, System.Span<int> intStackSpan);
                /*0xe64ae8*/ void Dispose();
                /*0xe64688*/ System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0xe65698*/ void PatchJump(int offset, int jumpDest);
                /*0xe656fc*/ void Emit(int op);
                /*0xe64b3c*/ void Emit(int op, int opd1);
                /*0xe657e0*/ void Emit(int op, int opd1, int opd2);
                /*0xe6598c*/ int StringCode(string str);
                /*0xe65ad8*/ int MapCapnum(int capnum);
                /*0xe64c88*/ void EmitFragment(int nodetype, System.Text.RegularExpressions.RegexNode node, int curIndex);
            }
        }
    }

    namespace Diagnostics
    {
        class BooleanSwitch : System.Diagnostics.Switch
        {
            /*0xe65b8c*/ BooleanSwitch(string displayName, string description);
        }

        class CorrelationManager
        {
            /*0xe65c58*/ CorrelationManager();
            /*0xe65c60*/ System.Collections.Stack get_LogicalOperationStack();
            /*0xe65c64*/ System.Collections.Stack GetLogicalOperationStack();
        }

        class Switch
        {
            static /*0x0*/ System.Collections.Generic.List<System.WeakReference> switches;
            static /*0x8*/ int s_LastCollectionCount;
            /*0x10*/ string description;
            /*0x18*/ string displayName;
            /*0x20*/ string switchValueString;
            /*0x28*/ string defaultValue;

            static /*0xe66454*/ Switch();
            static /*0xe65f70*/ void _pruneCachedSwitches();
            /*0xe65bf8*/ Switch(string displayName, string description);
            /*0xe65d24*/ Switch(string displayName, string description, string defaultSwitchValue);
        }

        class SwitchLevelAttribute : System.Attribute
        {
            /*0x10*/ System.Type type;

            /*0xe664e0*/ SwitchLevelAttribute(System.Type switchLevelType);
            /*0xe6650c*/ void set_SwitchLevelType(System.Type value);
        }

        class Trace
        {
            static /*0x0*/ System.Diagnostics.CorrelationManager correlationManager;

            static /*0xe665cc*/ System.Diagnostics.TraceListenerCollection get_Listeners();
            static /*0xe66870*/ bool get_AutoFlush();
            static /*0xe6691c*/ System.Diagnostics.CorrelationManager get_CorrelationManager();
        }

        class TraceEventCache
        {
            static /*0x0*/ int processId;
            static /*0x8*/ string processName;
            /*0x10*/ long timeStamp;
            /*0x18*/ System.DateTime dateTime;
            /*0x20*/ string stackTrace;

            static /*0xe66bdc*/ void InitProcessInfo();
            static /*0xe66a90*/ int GetProcessId();
            static /*0xe66b54*/ int GetThreadId();
            /*0xe66d14*/ TraceEventCache();
            /*0xe669c0*/ string get_Callstack();
            /*0xe669e0*/ System.Collections.Stack get_LogicalOperationStack();
            /*0xe669f8*/ System.DateTime get_DateTime();
            /*0xe66a8c*/ int get_ProcessId();
            /*0xe66ae4*/ string get_ThreadId();
            /*0xe66b74*/ long get_Timestamp();
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

        class TraceFilter
        {
            bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);
            /*0xe66d84*/ bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage);
        }

        class TraceInternal
        {
            static /*0x0*/ string appName;
            static /*0x8*/ System.Diagnostics.TraceListenerCollection listeners;
            static /*0x10*/ bool autoFlush;
            static /*0x14*/ int indentSize;
            static /*0x18*/ object critSec;
            [ThreadStatic] static int indentLevel;

            static /*0xe670dc*/ TraceInternal();
            static /*0xe66618*/ System.Diagnostics.TraceListenerCollection get_Listeners();
            static /*0xe668bc*/ bool get_AutoFlush();
            static /*0xe67024*/ int get_IndentLevel();
            static /*0xe6707c*/ int get_IndentSize();
            static /*0xe66db0*/ void InitializeSettings();
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
            /*0x20*/ System.Diagnostics.TraceOptions traceOptions;
            /*0x24*/ bool needIndent;
            /*0x28*/ string listenerName;
            /*0x30*/ System.Diagnostics.TraceFilter filter;

            /*0xe67164*/ TraceListener(string name);
            /*0xe6719c*/ bool get_IsThreadSafe();
            /*0xe671a4*/ void Dispose();
            /*0xe67210*/ void Dispose(bool disposing);
            /*0xe67214*/ void Flush();
            /*0xe66e24*/ void set_IndentLevel(int value);
            /*0xe66e40*/ void set_IndentSize(int value);
            /*0xe67218*/ System.Diagnostics.TraceFilter get_Filter();
            /*0xe67220*/ bool get_NeedIndent();
            /*0xe67228*/ void set_NeedIndent(bool value);
            /*0xe67234*/ System.Diagnostics.TraceOptions get_TraceOutputOptions();
            void Write(string message);
            /*0xe6723c*/ void WriteIndent();
            void WriteLine(string message);
            /*0xe67310*/ void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message);
            /*0xe673d4*/ void WriteHeader(string source, System.Diagnostics.TraceEventType eventType, int id);
            /*0xe674e4*/ void WriteFooter(System.Diagnostics.TraceEventCache eventCache);
            /*0xe67a84*/ bool IsEnabled(System.Diagnostics.TraceOptions opts);
        }

        class TraceListenerCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.ArrayList list;

            /*0xe66db4*/ TraceListenerCollection();
            /*0xe67a94*/ int get_Count();
            /*0xe66eec*/ int Add(System.Diagnostics.TraceListener listener);
            /*0xe67bac*/ void Clear();
            /*0xe67c0c*/ System.Collections.IEnumerator GetEnumerator();
            /*0xe67ab8*/ void InitializeListener(System.Diagnostics.TraceListener listener);
            /*0xe67c30*/ void RemoveAt(int index);
            /*0xe67d50*/ object System.Collections.IList.get_Item(int index);
            /*0xe67d74*/ void System.Collections.IList.set_Item(int index, object value);
            /*0xe67e84*/ bool System.Collections.IList.get_IsReadOnly();
            /*0xe67e8c*/ bool System.Collections.IList.get_IsFixedSize();
            /*0xe67e94*/ int System.Collections.IList.Add(object value);
            /*0xe68078*/ bool System.Collections.IList.Contains(object value);
            /*0xe6809c*/ int System.Collections.IList.IndexOf(object value);
            /*0xe680c0*/ void System.Collections.IList.Insert(int index, object value);
            /*0xe6829c*/ void System.Collections.IList.Remove(object value);
            /*0xe683bc*/ object System.Collections.ICollection.get_SyncRoot();
            /*0xe683c0*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0xe683c8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
        }

        enum TraceOptions
        {
            None = 0,
            LogicalOperationStack = 1,
            DateTime = 2,
            Timestamp = 4,
            ProcessId = 8,
            ThreadId = 16,
            Callstack = 32,
        }

        class TraceSwitch : System.Diagnostics.Switch
        {
            /*0xbb86dc*/ TraceSwitch(string displayName, string description);
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

            /*0xbb874c*/ void Close();
            /*0xbb875c*/ void Dispose(bool disposing);
            /*0xbb8acc*/ void CancelOperation();
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

            static /*0xbb9be8*/ System.Diagnostics.Process GetCurrentProcess();
            static /*0xbba254*/ string ProcessName_icall(nint handle);
            static /*0xbba258*/ string ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0xbb8ad8*/ Process(string machineName, bool isRemoteMachine, int processId, System.Diagnostics.ProcessInfo processInfo);
            /*0xbb8b74*/ bool get_Associated();
            /*0xbb8b94*/ bool get_HasExited();
            /*0xbb9734*/ int get_Id();
            /*0xbb9750*/ System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject();
            /*0xbb98f0*/ void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0xbb9918*/ void Dispose(bool disposing);
            /*0xbb9968*/ void Close();
            /*0xbb8f04*/ void EnsureState(System.Diagnostics.Process.State state);
            /*0xbb9c70*/ void OnExited();
            /*0xbb903c*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access, bool throwIfExited);
            /*0xbb9eb0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access);
            /*0xbb9bd4*/ void Refresh();
            /*0xbb9ac0*/ void StopWatchingForExit();
            /*0xbb9eb8*/ string ToString();
            /*0xbba024*/ string get_ProcessName();
            /*0xbb9654*/ void RaiseOnExited();

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
            /*0xbb9500*/ ProcessWaitHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle);
        }

        class DefaultTraceListener : System.Diagnostics.TraceListener
        {
            static /*0x0*/ bool OnWin32;
            static /*0x8*/ string MonoTracePrefix;
            static /*0x10*/ string MonoTraceFile;
            /*0x38*/ string logFileName;

            static /*0xbba338*/ DefaultTraceListener();
            static /*0xbba474*/ string GetPrefix(string var, string target);
            static /*0xbba544*/ void WriteWindowsDebugString(char* message);
            /*0xbba4f0*/ DefaultTraceListener();
            /*0xbba53c*/ string get_LogFileName();
            /*0xbba548*/ void WriteDebugString(string message);
            /*0xbba5f8*/ void WriteMonoTrace(string message);
            /*0xbbaa20*/ void WritePrefix();
            /*0xbbaaa8*/ void WriteImpl(string message);
            /*0xbba7a4*/ void WriteLogFile(string message, string logFile);
            /*0xbbab64*/ void Write(string message);
            /*0xbbab68*/ void WriteLine(string message);
        }

        class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute
        {
            /*0xbbabb0*/ MonitoringDescriptionAttribute(string description);
            /*0xbbac18*/ string get_Description();
        }

        class Stopwatch
        {
            static /*0x0*/ long Frequency;
            static /*0x8*/ bool IsHighResolution;
            /*0x10*/ long elapsed;
            /*0x18*/ long started;
            /*0x20*/ bool is_running;

            static /*0xbbb068*/ Stopwatch();
            static /*0xbbac20*/ long GetTimestamp();
            static /*0xbbac24*/ System.Diagnostics.Stopwatch StartNew();
            /*0xbbac88*/ Stopwatch();
            /*0xbbacf8*/ System.TimeSpan get_Elapsed();
            /*0xbbae60*/ long get_ElapsedMilliseconds();
            /*0xbbadf0*/ long get_ElapsedTicks();
            /*0xbbaf7c*/ bool get_IsRunning();
            /*0xbbaf84*/ void Reset();
            /*0xbbac90*/ void Start();
            /*0xbbaf90*/ void Stop();
            /*0xbbb008*/ void Restart();
        }

        namespace CodeAnalysis
        {
            class ExcludeFromCodeCoverageAttribute : System.Attribute
            {
                /*0xbbb0c0*/ ExcludeFromCodeCoverageAttribute();
            }
        }
    }

    namespace Security
    {
        namespace Authentication
        {
            class AuthenticationException : System.SystemException
            {
                /*0xbbb0c8*/ AuthenticationException();
                /*0xbbb120*/ AuthenticationException(string message, System.Exception innerException);
                /*0xbbb128*/ AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

                static /*0xbbbce0*/ string TrimTrailingNulls(string value);
                static /*0xbbbe30*/ void CheckTag(System.Security.Cryptography.DerSequenceReader.DerTag expected, byte[] data, int position);
                static /*0xbbb4d0*/ int ScanContentLength(byte[] data, int offset, int end, ref int bytesConsumed);
                /*0xbbb138*/ DerSequenceReader(byte[] data);
                /*0xbbb15c*/ DerSequenceReader(byte[] data, int offset, int length);
                /*0xbbb170*/ DerSequenceReader(System.Security.Cryptography.DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length);
                /*0xbbb130*/ void set_ContentLength(int value);
                /*0xbbb320*/ bool get_HasData();
                /*0xbbb330*/ byte PeekTag();
                /*0xbbb3c8*/ void SkipValue();
                /*0xbbb418*/ byte[] ReadNextEncodedValue();
                /*0xbbb5f0*/ bool ReadBoolean();
                /*0xbbb6bc*/ int ReadInteger();
                /*0xbbb770*/ byte[] ReadIntegerBytes();
                /*0xbbb840*/ byte[] ReadBitString();
                /*0xbbb988*/ byte[] ReadOctetString();
                /*0xbbb9a4*/ string ReadOidAsString();
                /*0xbbbc60*/ string ReadUtf8String();
                /*0xbbbd58*/ System.Security.Cryptography.DerSequenceReader ReadCollectionWithTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0xbbbec8*/ System.Security.Cryptography.DerSequenceReader ReadSequence();
                /*0xbbbed0*/ System.Security.Cryptography.DerSequenceReader ReadSet();
                /*0xbbbed8*/ string ReadPrintableString();
                /*0xbbbf58*/ string ReadIA5String();
                /*0xbbbfd8*/ string ReadT61String();
                /*0xbbc2b0*/ System.DateTime ReadX509Date();
                /*0xbbc334*/ System.DateTime ReadUtcTime();
                /*0xbbc380*/ System.DateTime ReadGeneralizedTime();
                /*0xbbc60c*/ string ReadBMPString();
                /*0xbbc3cc*/ System.DateTime ReadTime(System.Security.Cryptography.DerSequenceReader.DerTag timeTag, string formatString);
                /*0xbbb78c*/ byte[] ReadContentAsBytes();
                /*0xbbb264*/ void EatTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0xbbb2e4*/ int EatLength();

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

                    static /*0xbbc68c*/ <>c();
                    /*0xbbc6f0*/ <>c();
                    /*0xbbc6f8*/ System.Text.Encoding <ReadT61String>b__45_0();
                    /*0xbbc75c*/ System.Text.Encoding <ReadT61String>b__45_1();
                    /*0xbbc7a0*/ System.Globalization.DateTimeFormatInfo <ReadTime>b__51_0();
                }
            }

            class Oid
            {
                /*0x10*/ string _value;
                /*0x18*/ string _friendlyName;
                /*0x20*/ System.Security.Cryptography.OidGroup _group;

                static /*0xbbc9b0*/ System.Security.Cryptography.Oid FromOidValue(string oidValue, System.Security.Cryptography.OidGroup group);
                /*0xbbc86c*/ Oid();
                /*0xbbc874*/ Oid(string oid);
                /*0xbbc900*/ Oid(string value, string friendlyName);
                /*0xbbc92c*/ Oid(System.Security.Cryptography.Oid oid);
                /*0xbbcaec*/ Oid(string value, string friendlyName, System.Security.Cryptography.OidGroup group);
                /*0xbbcb28*/ string get_Value();
                /*0xbbcb30*/ void set_Value(string value);
                /*0xbbcb38*/ string get_FriendlyName();
            }

            class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.Oid> _list;

                /*0xbbcbbc*/ OidCollection();
                /*0xbbcc3c*/ int Add(System.Security.Cryptography.Oid oid);
                /*0xbbccf0*/ System.Security.Cryptography.Oid get_Item(int index);
                /*0xbbcd48*/ int get_Count();
                /*0xbbcd90*/ System.Security.Cryptography.OidEnumerator GetEnumerator();
                /*0xbbce2c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0xbbce30*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0xbbcfec*/ bool get_IsSynchronized();
                /*0xbbcff4*/ object get_SyncRoot();
            }

            class OidEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Security.Cryptography.OidCollection _oids;
                /*0x18*/ int _current;

                /*0xbbcdfc*/ OidEnumerator(System.Security.Cryptography.OidCollection oids);
                /*0xbbcff8*/ System.Security.Cryptography.Oid get_Current();
                /*0xbbd018*/ object System.Collections.IEnumerator.get_Current();
                /*0xbbd01c*/ bool MoveNext();
                /*0xbbd06c*/ void Reset();
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

                /*0xbbd078*/ AsnEncodedData();
                /*0xbbd080*/ AsnEncodedData(string oid, byte[] rawData);
                /*0xbbd1f8*/ AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData);
                /*0xbbd2a4*/ AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0xbbd384*/ System.Security.Cryptography.Oid get_Oid();
                /*0xbbd234*/ void set_Oid(System.Security.Cryptography.Oid value);
                /*0xbbd38c*/ byte[] get_RawData();
                /*0xbbd104*/ void set_RawData(byte[] value);
                /*0xbbd394*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0xbbd490*/ string Format(bool multiLine);
                /*0xbbd634*/ string ToString(bool multiLine);
                /*0xbbd520*/ string Default(bool multiLine);
                /*0xbbd7e4*/ string BasicConstraintsExtension(bool multiLine);
                /*0xbbd8f0*/ string EnhancedKeyUsageExtension(bool multiLine);
                /*0xbbd9fc*/ string KeyUsageExtension(bool multiLine);
                /*0xbbdb08*/ string SubjectKeyIdentifierExtension(bool multiLine);
                /*0xbbdc14*/ string SubjectAltName(bool multiLine);
                /*0xbbdfd4*/ string NetscapeCertType(bool multiLine);
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

                    static /*0xbbf2f0*/ PublicKey();
                    static /*0xbbf25c*/ byte[] GetUnsignedBigInteger(byte[] integer);
                    static /*0xbbeda8*/ System.Security.Cryptography.DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters);
                    static /*0xbbe9f0*/ System.Security.Cryptography.RSA DecodeRSA(byte[] rawPublicKey);
                    /*0xbbe6c8*/ PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue);
                    /*0xbbe83c*/ System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue();
                    /*0xbbe844*/ System.Security.Cryptography.AsnEncodedData get_EncodedParameters();
                    /*0xbbe84c*/ System.Security.Cryptography.AsymmetricAlgorithm get_Key();
                    /*0xbbf254*/ System.Security.Cryptography.Oid get_Oid();
                }

                class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ string name;
                    /*0x28*/ byte[] canonEncoding;

                    static /*0xbbf6c0*/ string GetSeparator(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    static /*0xbbf790*/ string Canonize(string s);
                    static /*0xbbf95c*/ bool AreEqual(System.Security.Cryptography.X509Certificates.X500DistinguishedName name1, System.Security.Cryptography.X509Certificates.X500DistinguishedName name2);
                    /*0xbbf358*/ X500DistinguishedName(byte[] encodedDistinguishedName);
                    /*0xbbf560*/ string get_Name();
                    /*0xbbf568*/ string Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    /*0xbbf734*/ string Format(bool multiLine);
                    /*0xbbf468*/ void DecodeRawData();
                }

                class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.19";
                    static string friendlyName = "Basic Constraints";
                    /*0x21*/ bool _certificateAuthority;
                    /*0x22*/ bool _hasPathLengthConstraint;
                    /*0x24*/ int _pathLengthConstraint;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0xbbfb50*/ X509BasicConstraintsExtension();
                    /*0xbbe368*/ X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical);
                    /*0xbbfdc4*/ X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical);
                    /*0xbc005c*/ bool get_CertificateAuthority();
                    /*0xbc00c8*/ bool get_HasPathLengthConstraint();
                    /*0xbc0134*/ int get_PathLengthConstraint();
                    /*0xbc01a0*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0xbbfc00*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0xbbff04*/ byte[] Encode();
                    /*0xbc037c*/ string ToString(bool multiLine);
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

                    static /*0xbc15d0*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
                    static /*0xbc0e4c*/ System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid);
                    /*0xbc0778*/ X509Certificate2();
                    /*0xbc0780*/ X509Certificate2(byte[] rawData);
                    /*0xbc0948*/ X509Certificate2(string fileName);
                    /*0xbc0950*/ X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
                    /*0xbc0958*/ X509Certificate2(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0xbc0720*/ void Reset();
                    /*0xbc09a0*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection get_Extensions();
                    /*0xbc1094*/ bool get_HasPrivateKey();
                    /*0xbc10c8*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0xbc1224*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0xbc1264*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0xbc12c0*/ System.DateTime get_NotAfter();
                    /*0xbc12c8*/ System.DateTime get_NotBefore();
                    /*0xbc12d0*/ System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    /*0xbc142c*/ byte[] get_RawData();
                    /*0xbc1488*/ string get_SerialNumber();
                    /*0xbc1498*/ System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    /*0xbc14fc*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0xbc1558*/ string get_Thumbprint();
                    /*0xbc1574*/ int get_Version();
                    /*0xbc166c*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0xbc16a8*/ string ToString();
                    /*0xbc16b4*/ string ToString(bool verbose);
                    /*0xbc2740*/ bool Verify();
                    /*0xbc0dc0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl();
                }

                class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection
                {
                    static /*0x0*/ string[] newline_split;

                    static /*0xbc4ac4*/ X509Certificate2Collection();
                    /*0xbc2964*/ X509Certificate2Collection();
                    /*0xbc2974*/ X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0xbc2a14*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Item(int index);
                    /*0xbc2b40*/ int Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc29a0*/ void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0xbc2bb4*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc2f38*/ string GetKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 x);
                    /*0xbc37f8*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, bool validOnly);
                    /*0xbc49b0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator();
                }

                class X509Certificate2Enumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0xbc4a10*/ X509Certificate2Enumerator(System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection);
                    /*0xbc4b78*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Current();
                    /*0xbc4c68*/ bool MoveNext();
                    /*0xbc4d08*/ object System.Collections.IEnumerator.get_Current();
                    /*0xbc4dac*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0xbc4e4c*/ void System.Collections.IEnumerator.Reset();
                }

                class X509Certificate2Impl : System.Security.Cryptography.X509Certificates.X509CertificateImpl
                {
                    /*0xbc4ef0*/ X509Certificate2Impl();
                    System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    string get_SignatureAlgorithm();
                    System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    int get_Version();
                    System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509Certificate2ImplMono : System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix
                {
                    static /*0x0*/ string empty_error;
                    static /*0x8*/ byte[] signedData;
                    /*0xb0*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;
                    /*0xb8*/ Mono.Security.X509.X509Certificate _cert;

                    static /*0xbc63b8*/ X509Certificate2ImplMono();
                    /*0xbc4f08*/ X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert);
                    /*0xbc4f38*/ X509Certificate2ImplMono(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other);
                    /*0xbc4fdc*/ X509Certificate2ImplMono(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0xbc4ef8*/ bool get_IsValid();
                    /*0xbc5190*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone();
                    /*0xbc51fc*/ Mono.Security.X509.X509Certificate get_Cert();
                    /*0xbc5218*/ byte[] GetRawCertData();
                    /*0xbc5250*/ bool get_HasPrivateKey();
                    /*0xbc5274*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0xbc56a8*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0xbc5840*/ System.Security.Cryptography.RSA GetRSAPrivateKey();
                    /*0xbc58cc*/ System.Security.Cryptography.DSA GetDSAPrivateKey();
                    /*0xbc5138*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password);
                    /*0xbc5958*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password);
                    /*0xbc6270*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0xbc63a8*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    /*0xbc63b0*/ Mono.Security.X509.X509Certificate get_MonoCertificate();
                }

                class X509Certificate2ImplUnix : System.Security.Cryptography.X509Certificates.X509Certificate2Impl
                {
                    /*0x10*/ bool readCertData;
                    /*0x18*/ Internal.Cryptography.Pal.CertificateData certData;

                    /*0xbc4f30*/ X509Certificate2ImplUnix();
                    /*0xbc6478*/ void EnsureCertData();
                    byte[] GetRawCertData();
                    /*0xbc64f8*/ string get_KeyAlgorithm();
                    /*0xbc6510*/ byte[] get_KeyAlgorithmParameters();
                    /*0xbc6528*/ byte[] get_PublicKeyValue();
                    /*0xbc6540*/ byte[] get_SerialNumber();
                    /*0xbc6558*/ string get_SignatureAlgorithm();
                    /*0xbc6570*/ int get_Version();
                    /*0xbc658c*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0xbc65a4*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0xbc65bc*/ string get_Subject();
                    /*0xbc65e4*/ string get_Issuer();
                    /*0xbc660c*/ byte[] get_RawData();
                    /*0xbc6624*/ byte[] get_Thumbprint();
                    /*0xbc67b8*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0xbc67ec*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0xbc6804*/ System.DateTime get_NotAfter();
                    /*0xbc6820*/ System.DateTime get_NotBefore();
                    /*0xbc683c*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                }

                class X509CertificateCollection : System.Collections.CollectionBase
                {
                    /*0xbc296c*/ X509CertificateCollection();
                    /*0xbc68d0*/ X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0xbc69d0*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Item(int index);
                    /*0xbc68fc*/ void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0xbc6a68*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                    /*0xbc6b7c*/ int GetHashCode();

                    class X509CertificateEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.IEnumerator enumerator;

                        /*0xbc6ac8*/ X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings);
                        /*0xbc6b9c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Current();
                        /*0xbc6c8c*/ object System.Collections.IEnumerator.get_Current();
                        /*0xbc6d30*/ bool System.Collections.IEnumerator.MoveNext();
                        /*0xbc6dd0*/ void System.Collections.IEnumerator.Reset();
                        /*0xbc6e74*/ bool MoveNext();
                    }
                }

                class X509CertificateImplCollection : System.IDisposable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list;

                    /*0xbc611c*/ X509CertificateImplCollection();
                    /*0xbc6f14*/ X509CertificateImplCollection(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other);
                    /*0xbc7144*/ int get_Count();
                    /*0xbc718c*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(int index);
                    /*0xbc619c*/ void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, bool takeOwnership);
                    /*0xbc4f7c*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone();
                    /*0xbc71e4*/ void Dispose();
                    /*0xbc7250*/ void Dispose(bool disposing);
                    /*0xbc7470*/ void Finalize();
                }

                class X509Chain : System.IDisposable
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainImpl impl;

                    static /*0xbc6304*/ System.Security.Cryptography.X509Certificates.X509Chain Create();
                    /*0xbc756c*/ X509Chain();
                    /*0xbc7590*/ X509Chain(bool useMachineContext);
                    /*0xbc7620*/ X509Chain(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    /*0xbc7650*/ X509Chain(nint chainContext);
                    /*0xbc7510*/ System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl();
                    /*0xbc7698*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0xbc76c4*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0xbc636c*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc76f0*/ void Reset();
                    /*0xbc771c*/ void Dispose();
                    /*0xbc7788*/ void Dispose(bool disposing);
                    /*0xbc7814*/ void Finalize();
                }

                class X509ChainElement
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509Certificate2 certificate;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x20*/ string info;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags compressed_status_flags;

                    /*0xbc78b4*/ X509ChainElement(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc7920*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate();
                    /*0xbc7928*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainElementStatus();
                    /*0xbc7930*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_StatusFlags();
                    /*0xbc7938*/ void set_StatusFlags(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0xbc7940*/ int Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0xbc7964*/ void Set(System.Security.Cryptography.X509Certificates.X509ChainStatus[] status, ref int position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask);
                    /*0xbc7b70*/ void UncompressFlags();
                }

                class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _list;

                    /*0xbc7db8*/ X509ChainElementCollection();
                    /*0xbc7e24*/ int get_Count();
                    /*0xbc7e48*/ bool get_IsSynchronized();
                    /*0xbc7e6c*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(int index);
                    /*0xbc7f04*/ object get_SyncRoot();
                    /*0xbc7f28*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0xbc7f4c*/ System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator();
                    /*0xbc8064*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0xbc80c8*/ void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc814c*/ void Clear();
                    /*0xbc8170*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                }

                class X509ChainElementEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0xbc7fb0*/ X509ChainElementEnumerator(System.Collections.IEnumerable enumerable);
                    /*0xbc8280*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Current();
                    /*0xbc8370*/ object System.Collections.IEnumerator.get_Current();
                    /*0xbc8414*/ bool MoveNext();
                    /*0xbc84b4*/ void Reset();
                }

                class X509ChainImpl : System.IDisposable
                {
                    /*0xbc86c0*/ X509ChainImpl();
                    bool get_IsValid();
                    /*0xbc8558*/ void ThrowIfContextInvalid();
                    System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode);
                    void Reset();
                    /*0xbc77a8*/ void Dispose();
                    /*0xbc861c*/ void Dispose(bool disposing);
                    /*0xbc8620*/ void Finalize();
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

                    static /*0xbcbc7c*/ X509ChainImplMono();
                    static /*0xbca214*/ string GetAuthorityKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0xbcadf8*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Crl crl);
                    static /*0xbcac9c*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext);
                    static /*0xbcb8e8*/ Mono.Security.X509.X509Crl CheckCrls(string subject, string ski, Mono.Security.X509.X509Store store);
                    /*0xbc86c8*/ X509ChainImplMono(bool useMachineContext);
                    /*0xbc879c*/ bool get_IsValid();
                    /*0xbc87a4*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0xbc87ac*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0xbc87b4*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
                    /*0xbc87b8*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc8f90*/ void Reset();
                    /*0xbc90a8*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Roots();
                    /*0xbc93c0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateAuthorities();
                    /*0xbc9160*/ System.Security.Cryptography.X509Certificates.X509Store get_LMRootStore();
                    /*0xbc924c*/ System.Security.Cryptography.X509Certificates.X509Store get_UserRootStore();
                    /*0xbc9478*/ System.Security.Cryptography.X509Certificates.X509Store get_LMCAStore();
                    /*0xbc9564*/ System.Security.Cryptography.X509Certificates.X509Store get_UserCAStore();
                    /*0xbc9b78*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateCollection();
                    /*0xbc8d74*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbca088*/ System.Security.Cryptography.X509Certificates.X509Certificate2 SelectBestFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2 child, System.Security.Cryptography.X509Certificates.X509Certificate2Collection c);
                    /*0xbc9eac*/ System.Security.Cryptography.X509Certificates.X509Certificate2 FindParent(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc9fc0*/ bool IsChainComplete(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbca358*/ bool IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbc8e5c*/ void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0xbca3a0*/ void Process(int n);
                    /*0xbca640*/ void PrepareForNextCertificate(int n);
                    /*0xbcaa24*/ void WrapUp();
                    /*0xbcabb4*/ void ProcessCertificateExtensions(System.Security.Cryptography.X509Certificates.X509ChainElement element);
                    /*0xbcab7c*/ bool IsSignedWith(System.Security.Cryptography.X509Certificates.X509Certificate2 signed, System.Security.Cryptography.AsymmetricAlgorithm pubkey);
                    /*0xbca2a8*/ string GetSubjectKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0xbca834*/ void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0xbcae84*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, int ca, bool online);
                    /*0xbcaf50*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2 ca_cert, bool online);
                    /*0xbcb11c*/ Mono.Security.X509.X509Crl FindCrl(System.Security.Cryptography.X509Certificates.X509Certificate2 caCertificate);
                    /*0xbcb5a0*/ bool ProcessCrlExtensions(Mono.Security.X509.X509Crl crl);
                    /*0xbcb290*/ bool ProcessCrlEntryExtensions(Mono.Security.X509.X509Crl.X509CrlEntry entry);
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

                    /*0xbc8780*/ X509ChainPolicy();
                    /*0xbc9c40*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_ExtraStore();
                    /*0xbcbdd8*/ System.Security.Cryptography.X509Certificates.X509RevocationFlag get_RevocationFlag();
                    /*0xbcbde0*/ System.Security.Cryptography.X509Certificates.X509RevocationMode get_RevocationMode();
                    /*0xbcbde8*/ void set_RevocationMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                    /*0xbcbe4c*/ System.Security.Cryptography.X509Certificates.X509VerificationFlags get_VerificationFlags();
                    /*0xbcbe54*/ void set_VerificationFlags(System.Security.Cryptography.X509Certificates.X509VerificationFlags value);
                    /*0xbcbeb8*/ System.DateTime get_VerificationTime();
                    /*0xbcbce4*/ void Reset();
                }

                struct X509ChainStatus
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status;
                    /*0x18*/ string info;

                    static /*0xbc79d8*/ string GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0xbc8f70*/ X509ChainStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0xbcbec0*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_Status();
                    /*0xbcbec8*/ void set_Status(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0xbcbed0*/ void set_StatusInformation(string value);
                }

                class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    /*0x28*/ System.Security.Cryptography.OidCollection _enhKeyUsage;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0xbc2814*/ X509EnhancedKeyUsageExtension();
                    /*0xbbe440*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical);
                    /*0xbcc138*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical);
                    /*0xbcc378*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0xbcbed8*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0xbcc2c0*/ byte[] Encode();
                    /*0xbcc554*/ string ToString(bool multiLine);
                }

                class X509Extension : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ bool _critical;

                    /*0xbbfbf8*/ X509Extension();
                    /*0xbcc820*/ X509Extension(string oid, byte[] rawData, bool critical);
                    /*0xbcc844*/ bool get_Critical();
                    /*0xbcc84c*/ void set_Critical(bool value);
                    /*0xbcc858*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0xbc060c*/ string FormatUnkownData(byte[] data);
                }

                class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Collections.ArrayList _list;

                    static /*0xbccb58*/ X509ExtensionCollection();
                    /*0xbc0d54*/ X509ExtensionCollection();
                    /*0xbc2528*/ int get_Count();
                    /*0xbcc984*/ bool get_IsSynchronized();
                    /*0xbcc9a8*/ object get_SyncRoot();
                    /*0xbc2ff8*/ System.Security.Cryptography.X509Certificates.X509Extension get_Item(string oid);
                    /*0xbc1020*/ int Add(System.Security.Cryptography.X509Certificates.X509Extension extension);
                    /*0xbcc9ac*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0xbc254c*/ System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator();
                    /*0xbccaf4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class X509ExtensionEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0xbccab0*/ X509ExtensionEnumerator(System.Collections.ArrayList list);
                    /*0xbc25b0*/ System.Security.Cryptography.X509Certificates.X509Extension get_Current();
                    /*0xbccbc0*/ object System.Collections.IEnumerator.get_Current();
                    /*0xbc26a0*/ bool MoveNext();
                    /*0xbccc64*/ void Reset();
                }

                class X509Helper2
                {
                    static /*0xbcaab0*/ Mono.Security.X509.X509Certificate GetMonoCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0xbc75c0*/ System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(bool useMachineContext);
                    static /*0xbccd08*/ bool IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0xbc752c*/ void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0xbc8594*/ System.Exception GetInvalidChainContextException();
                    static /*0xbccd1c*/ long GetSubjectNameHash(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
                    static /*0xbccd5c*/ void ExportAsPEM(System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.IO.Stream stream, bool includeHumanReadableForm);
                }

                class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.15";
                    static string friendlyName = "Key Usage";
                    static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all = 33023;
                    /*0x24*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0xbc276c*/ X509KeyUsageExtension();
                    /*0xbbe518*/ X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical);
                    /*0xbccf50*/ X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical);
                    /*0xbc4944*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages();
                    /*0xbcd1a8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0xbcd030*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags);
                    /*0xbccd9c*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0xbcd040*/ byte[] Encode();
                    /*0xbcd384*/ string ToString(bool multiLine);
                }

                class X509Store : System.IDisposable
                {
                    /*0x10*/ string _name;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.StoreLocation _location;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection list;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.OpenFlags _flags;
                    /*0x30*/ Mono.Security.X509.X509Store store;

                    /*0xbc9650*/ X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation);
                    /*0xbc9338*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Certificates();
                    /*0xbcd8b4*/ Mono.Security.X509.X509Stores get_Factory();
                    /*0xbcd8d0*/ Mono.Security.X509.X509Store get_Store();
                    /*0xbc908c*/ void Close();
                    /*0xbcd8d8*/ void Dispose();
                    /*0xbc9788*/ void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags);
                }

                class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.14";
                    static string friendlyName = "Subject Key Identifier";
                    /*0x28*/ byte[] _subjectKeyIdentifier;
                    /*0x30*/ string _ski;
                    /*0x38*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    static /*0xbce0d4*/ byte FromHexChar(char c);
                    static /*0xbce11c*/ byte FromHexChars(char c1, char c2);
                    static /*0xbcddfc*/ byte[] FromHex(string hex);
                    /*0xbc28bc*/ X509SubjectKeyIdentifierExtension();
                    /*0xbbe5f0*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical);
                    /*0xbcda58*/ X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical);
                    /*0xbcdc8c*/ X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical);
                    /*0xbcdeec*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical);
                    /*0xbc33a4*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical);
                    /*0xbc3770*/ string get_SubjectKeyIdentifier();
                    /*0xbcdef8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0xbcd8f4*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0xbcdc18*/ byte[] Encode();
                    /*0xbce1b8*/ string ToString(bool multiLine);
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

            /*0xbce3ec*/ ContextAwareResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0xbce3f4*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0xbce444*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0xbce3e4*/ void SafeCaptureIdentity();
            /*0xbce3e8*/ void CleanupInternal();
            /*0xbce4bc*/ object StartPostingAsyncOp();
            /*0xbce4c4*/ object StartPostingAsyncOp(bool lockCapture);
            /*0xbce5c4*/ bool FinishPostingAsyncOp();
            /*0xbcea10*/ void Cleanup();
            /*0xbce608*/ bool CaptureOrComplete(ref System.Threading.ExecutionContext cachedContext, bool returnContext);
            /*0xbceab8*/ void Complete(nint userToken);
            /*0xbceda8*/ void CompleteCallback();

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

                static /*0xbcee80*/ <>c();
                /*0xbceee4*/ <>c();
                /*0xbceeec*/ void <Complete>b__17_0(object s);
            }
        }

        class HttpStatusDescription
        {
            static /*0xbcef6c*/ string Get(System.Net.HttpStatusCode code);
            static /*0xbcef70*/ string Get(int code);
        }

        class HttpValidationHelpers
        {
            static /*0x0*/ char[] s_httpTrimCharacters;

            static /*0xb46718*/ HttpValidationHelpers();
            static /*0xb46618*/ bool IsInvalidMethodOrHeaderString(string stringValue);
        }

        class NetEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Net.NetEventSource Log;

            static /*0xb47e1c*/ NetEventSource();
            static /*0xb467ac*/ void Enter(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0xb46da8*/ void Enter(object thisOrContextObject, object arg0, string memberName);
            static /*0xb47270*/ void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName);
            static /*0xb4738c*/ void Exit(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0xb474f8*/ void Exit(object thisOrContextObject, object arg0, string memberName);
            static /*0xb475c8*/ void Info(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0xb47734*/ void Info(object thisOrContextObject, object message, string memberName);
            static /*0xb47804*/ void Error(object thisOrContextObject, object message, string memberName);
            static /*0xb47950*/ void Fail(object thisOrContextObject, object message, string memberName);
            static /*0xb47a9c*/ void Associate(object first, object second, string memberName);
            static /*0xb4689c*/ bool get_IsEnabled();
            static /*0xb46900*/ string IdOf(object value);
            static /*0xb47e00*/ int GetHashCode(object value);
            static /*0xb46e90*/ object Format(object value);
            static /*0xb469ec*/ string Format(System.FormattableString s);
            /*0xb47e14*/ NetEventSource();
            /*0xb46d2c*/ void Enter(string thisOrContextObject, string memberName, string parameters);
            /*0xb4747c*/ void Exit(string thisOrContextObject, string memberName, string result);
            /*0xb476b8*/ void Info(string thisOrContextObject, string memberName, string message);
            /*0xb478d4*/ void ErrorMessage(string thisOrContextObject, string memberName, string message);
            /*0xb47a20*/ void CriticalFailure(string thisOrContextObject, string memberName, string message);
            /*0xb47b6c*/ void Associate(string thisOrContextObject, string memberName, string first, string second);
            /*0xb47bf4*/ void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4);

            class Keywords
            {
                static System.Diagnostics.Tracing.EventKeywords Default = 1;
                static System.Diagnostics.Tracing.EventKeywords Debug = 2;
                static System.Diagnostics.Tracing.EventKeywords EnterExit = 4;
            }
        }

        class TcpValidationHelpers
        {
            static /*0xb47e80*/ bool ValidatePortNumber(int port);
        }

        class TlsStream : System.Net.Sockets.NetworkStream
        {
            /*0x48*/ System.Net.Security.SslStream _sslStream;
            /*0x50*/ string _host;
            /*0x58*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;

            /*0xb47e8c*/ TlsStream(System.Net.Sockets.NetworkStream stream, System.Net.Sockets.Socket socket, string host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates);
            /*0xb47f60*/ void AuthenticateAsClient();
            /*0xb48060*/ System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object state);
            /*0xb48178*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
            /*0xb4819c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0xb481c0*/ void EndWrite(System.IAsyncResult result);
            /*0xb481e4*/ void Write(byte[] buffer, int offset, int size);
            /*0xb48208*/ int Read(byte[] buffer, int offset, int size);
            /*0xb4822c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0xb48250*/ int EndRead(System.IAsyncResult asyncResult);
            /*0xb48274*/ void Close();
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

            static /*0xb482a8*/ HttpVersion();
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

            static /*0xb496cc*/ IPAddress();
            static /*0xb487bc*/ bool TryParse(string ipString, ref System.Net.IPAddress address);
            static /*0xb48a24*/ System.Net.IPAddress Parse(string ipString);
            static /*0xb48f80*/ bool IsLoopback(System.Net.IPAddress address);
            static /*0xb484fc*/ byte[] ThrowAddressNullException();
            /*0xb483fc*/ IPAddress(long newAddress);
            /*0xb48480*/ IPAddress(byte[] address, long scopeid);
            /*0xb4854c*/ IPAddress(System.ReadOnlySpan<byte> address, long scopeid);
            /*0xb486d0*/ IPAddress(ushort* numbers, int numbersLength, uint scopeid);
            /*0xb48788*/ IPAddress(ushort[] numbers, uint scopeid);
            /*0xb483ac*/ bool get_IsIPv4();
            /*0xb483bc*/ bool get_IsIPv6();
            /*0xb483cc*/ uint get_PrivateAddress();
            /*0xb483d4*/ void set_PrivateAddress(uint value);
            /*0xb483e4*/ uint get_PrivateScopeId();
            /*0xb483ec*/ void set_PrivateScopeId(uint value);
            /*0xb48ac0*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten);
            /*0xb48bd8*/ void WriteIPv6Bytes(System.Span<byte> destination);
            /*0xb48c64*/ void WriteIPv4Bytes(System.Span<byte> destination);
            /*0xb48cb0*/ byte[] GetAddressBytes();
            /*0xb48e04*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0xb48e1c*/ long get_ScopeId();
            /*0xb48e74*/ string ToString();
            /*0xb49048*/ bool Equals(object comparandObj, bool compareScopeId);
            /*0xb4917c*/ bool Equals(object comparand);
            /*0xb49184*/ int GetHashCode();
            /*0xb495ec*/ System.Net.IPAddress MapToIPv6();

            class ReadOnlyIPAddress : System.Net.IPAddress
            {
                /*0xb49878*/ ReadOnlyIPAddress(long newAddress);
            }
        }

        class IPAddressParser
        {
            static /*0xb48828*/ System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipSpan, bool tryParse);
            static /*0xb48f20*/ string IPv4AddressToString(uint address);
            static /*0xb49bb0*/ void IPv4AddressToString(uint address, System.Text.StringBuilder destination);
            static /*0xb49b14*/ int IPv4AddressToStringHelper(uint address, char* addressString);
            static /*0xb48f0c*/ string IPv6AddressToString(ushort[] address, uint scopeId);
            static /*0xb49cd8*/ System.Text.StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId);
            static /*0xb49c20*/ void FormatIPv4AddressNumber(int number, char* addressString, ref int offset);
            static /*0xb49a40*/ bool Ipv4StringToAddress(System.ReadOnlySpan<char> ipSpan, ref long address);
            static /*0xb498dc*/ bool Ipv6StringToAddress(System.ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, ref uint scope);
            static /*0xb49df8*/ void AppendSections(ushort[] address, int fromInclusive, int toExclusive, System.Text.StringBuilder buffer);
            static /*0xb49fec*/ void AppendHex(ushort value, System.Text.StringBuilder buffer);
            static /*0xb49fb0*/ uint ExtractIPv4Address(ushort[] address);
            static /*0xb4a054*/ ushort Reverse(ushort number);
        }

        class IPEndPoint : System.Net.EndPoint
        {
            static /*0x0*/ System.Net.IPEndPoint Any;
            static /*0x8*/ System.Net.IPEndPoint IPv6Any;
            /*0x10*/ System.Net.IPAddress _address;
            /*0x18*/ int _port;

            static /*0xb4a694*/ IPEndPoint();
            /*0xb4a08c*/ IPEndPoint(System.Net.IPAddress address, int port);
            /*0xb4a060*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0xb4a154*/ System.Net.IPAddress get_Address();
            /*0xb4a15c*/ int get_Port();
            /*0xb4a164*/ string ToString();
            /*0xb4a224*/ System.Net.SocketAddress Serialize();
            /*0xb4a2ec*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
            /*0xb4a5b0*/ bool Equals(object comparand);
            /*0xb4a664*/ int GetHashCode();
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

            static /*0xb4c678*/ CommandStream();
            static /*0xb4ba80*/ void ReadCallback(System.IAsyncResult asyncResult);
            static /*0xb4c2dc*/ void WriteCallback(System.IAsyncResult asyncResult);
            /*0xb4a768*/ CommandStream(System.Net.Sockets.TcpClient client);
            /*0xb4a880*/ void Abort(System.Exception e);
            /*0xb4aaa8*/ void Dispose(bool disposing);
            /*0xb4ab3c*/ void InvokeRequestCallback(object obj);
            /*0xb4abbc*/ bool get_RecoverableFailure();
            /*0xb4abc4*/ void MarkAsRecoverableFailure();
            /*0xb4abdc*/ System.IO.Stream SubmitRequest(System.Net.WebRequest request, bool isAsync, bool readInitalResponseOnConnect);
            /*0xb4b1c0*/ void ClearState();
            /*0xb4b1d0*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest request);
            /*0xb4b1d8*/ System.Exception GenerateException(string message, System.Net.WebExceptionStatus status, System.Exception innerException);
            /*0xb4b26c*/ System.Exception GenerateException(System.Net.FtpStatusCode code, string statusDescription, System.Exception innerException);
            /*0xb4ac5c*/ void InitCommandPipeline(System.Net.WebRequest request, System.Net.CommandStream.PipelineEntry[] commands, bool isAsync);
            /*0xb4b334*/ void CheckContinuePipeline();
            /*0xb4acec*/ System.IO.Stream ContinueCommandPipeline();
            /*0xb4b400*/ bool PostSendCommandProcessing(ref System.IO.Stream stream);
            /*0xb4b858*/ bool PostReadCommandProcessing(ref System.IO.Stream stream);
            /*0xb4ba78*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0xb4c590*/ System.Text.Encoding get_Encoding();
            /*0xb4c598*/ void set_Encoding(System.Text.Encoding value);
            /*0xb4c5d0*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0xb4b530*/ System.Net.ResponseDescription ReceiveCommandResponse();
            /*0xb4bd88*/ void ReceiveCommandResponseCallback(System.Net.ReceiveState state, int bytesRead);

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

                /*0xb4c74c*/ PipelineEntry(string command);
                /*0xb4c774*/ PipelineEntry(string command, System.Net.CommandStream.PipelineEntryFlags flags);
                /*0xb4b3f0*/ bool HasFlag(System.Net.CommandStream.PipelineEntryFlags flags);
            }
        }

        class ResponseDescription
        {
            /*0x10*/ bool Multiline;
            /*0x14*/ int Status;
            /*0x18*/ string StatusDescription;
            /*0x20*/ System.Text.StringBuilder StatusBuffer;
            /*0x28*/ string StatusCodeString;

            /*0xb4c808*/ ResponseDescription();
            /*0xb4c7a4*/ bool get_PositiveIntermediate();
            /*0xb4c7b8*/ bool get_PositiveCompletion();
            /*0xb4c7cc*/ bool get_TransientFailure();
            /*0xb4c7e0*/ bool get_PermanentFailure();
            /*0xb4c7f4*/ bool get_InvalidStatusCode();
        }

        class ReceiveState
        {
            /*0x10*/ System.Net.ResponseDescription Resp;
            /*0x18*/ int ValidThrough;
            /*0x20*/ byte[] Buffer;
            /*0x28*/ System.Net.CommandStream Connection;

            /*0xb4c5d8*/ ReceiveState(System.Net.CommandStream connection);
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

            static /*0xb50fec*/ FtpControlStream();
            static /*0xb4cab8*/ void AcceptCallback(System.IAsyncResult asyncResult);
            static /*0xb4ced0*/ void ConnectCallback(System.IAsyncResult asyncResult);
            static /*0xb4d080*/ void SSLHandshakeCallback(System.IAsyncResult asyncResult);
            static /*0xb4ffb0*/ void GetPathInfo(System.Net.FtpControlStream.GetPathOption pathOption, System.Uri uri, ref string path, ref string directory, ref string filename);
            /*0xb4c9a0*/ FtpControlStream(System.Net.Sockets.TcpClient client);
            /*0xb4c878*/ System.Net.NetworkCredential get_Credentials();
            /*0xb4c920*/ void set_Credentials(System.Net.NetworkCredential value);
            /*0xb4ca2c*/ void AbortConnect();
            /*0xb4d244*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref System.IO.Stream stream);
            /*0xb4d7d4*/ void ClearState();
            /*0xb4d864*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0xb4f0b8*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest req);
            /*0xb4e094*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateDataConection(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream, ref bool isSocketReady);
            /*0xb5098c*/ string FormatAddress(System.Net.IPAddress address, int Port);
            /*0xb50ab0*/ string FormatAddressV6(System.Net.IPAddress address, int port);
            /*0xb50bc0*/ long get_ContentLength();
            /*0xb50bc8*/ System.DateTime get_LastModified();
            /*0xb50bd0*/ System.Uri get_ResponseUri();
            /*0xb50bd8*/ string get_BannerMessage();
            /*0xb50bf0*/ string get_WelcomeMessage();
            /*0xb50c08*/ string get_ExitMessage();
            /*0xb4eb68*/ long GetContentLengthFrom213Response(string responseString);
            /*0xb4eca8*/ System.DateTime GetLastModifiedFrom213Response(string str);
            /*0xb4e7f4*/ void TryUpdateResponseUri(string str, System.Net.FtpWebRequest request);
            /*0xb4e6fc*/ void TryUpdateContentLength(string str);
            /*0xb4f008*/ string GetLoginDirectory(string str);
            /*0xb504c0*/ int GetPortV4(string responseString);
            /*0xb506b4*/ int GetPortV6(string responseString);
            /*0xb50154*/ void CreateFtpListenerSocket(System.Net.FtpWebRequest request);
            /*0xb502cc*/ string GetPortCommandLine(System.Net.FtpWebRequest request);
            /*0xb4fe84*/ string FormatFtpCommand(string command, string parameter);
            /*0xb50874*/ System.Net.Sockets.Socket CreateFtpDataSocket(System.Net.FtpWebRequest request, System.Net.Sockets.Socket templateSocket);
            /*0xb50c20*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0xb4d4dc*/ System.Net.TriState IsFtpDataStreamWriteable();

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

                /*0xb4e08c*/ <>c__DisplayClass31_0();
                /*0xb51100*/ void <PipelineCallback>b__0(System.IAsyncResult ar);
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

            /*0xb4d560*/ FtpDataStream(System.Net.Sockets.NetworkStream networkStream, System.Net.FtpWebRequest request, System.Net.TriState writeOnly);
            /*0xb511f8*/ void Dispose(bool disposing);
            /*0xb51380*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0xb51764*/ void CheckError();
            /*0xb517a4*/ bool get_CanRead();
            /*0xb517ac*/ bool get_CanSeek();
            /*0xb517cc*/ bool get_CanWrite();
            /*0xb517d4*/ long get_Length();
            /*0xb517f4*/ long get_Position();
            /*0xb51814*/ void set_Position(long value);
            /*0xb51838*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0xb51904*/ int Read(byte[] buffer, int offset, int size);
            /*0xb51a08*/ void Write(byte[] buffer, int offset, int size);
            /*0xb51ae0*/ void AsyncReadCallback(System.IAsyncResult ar);
            /*0xb51d90*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0xb51f3c*/ int EndRead(System.IAsyncResult ar);
            /*0xb520dc*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0xb521d0*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0xb52270*/ void Flush();
            /*0xb52294*/ void SetLength(long value);
            /*0xb522b8*/ bool get_CanTimeout();
            /*0xb522d8*/ int get_ReadTimeout();
            /*0xb522fc*/ void set_ReadTimeout(int value);
            /*0xb52320*/ int get_WriteTimeout();
            /*0xb52344*/ void set_WriteTimeout(int value);
            /*0xb52368*/ void SetSocketTimeoutOption(int timeout);
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

            static /*0xb52560*/ FtpMethodInfo();
            static /*0xb523fc*/ System.Net.FtpMethodInfo GetMethodInfo(string method);
            /*0xb523b8*/ FtpMethodInfo(string method, System.Net.FtpOperation operation, System.Net.FtpMethodFlags flags, string httpCommand);
            /*0xb4ffa0*/ bool HasFlag(System.Net.FtpMethodFlags flags);
            /*0xb50144*/ bool get_IsCommandOnly();
            /*0xb50fd4*/ bool get_IsUpload();
            /*0xb50fe0*/ bool get_IsDownload();
            /*0xb4e7e8*/ bool get_ShouldParseForResponseUri();
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

            static /*0xb58a98*/ FtpWebRequest();
            /*0xb5302c*/ FtpWebRequest(System.Uri uri);
            /*0xb52b5c*/ System.Net.FtpMethodInfo get_MethodInfo();
            /*0xb52b64*/ string get_Method();
            /*0xb52b80*/ void set_Method(string value);
            /*0xb52d44*/ string get_RenameTo();
            /*0xb52d4c*/ System.Net.ICredentials get_Credentials();
            /*0xb52d54*/ void set_Credentials(System.Net.ICredentials value);
            /*0xb52ea4*/ System.Uri get_RequestUri();
            /*0xb52eac*/ int get_Timeout();
            /*0xb52eb4*/ void set_Timeout(int value);
            /*0xb52f8c*/ int get_RemainingTimeout();
            /*0xb52f94*/ int get_ReadWriteTimeout();
            /*0xb52f9c*/ long get_ContentOffset();
            /*0xb52fa4*/ long get_ContentLength();
            /*0xb52fac*/ void set_ContentLength(long value);
            /*0xb52fb4*/ System.Net.IWebProxy get_Proxy();
            /*0xb52fbc*/ void set_Proxy(System.Net.IWebProxy value);
            /*0xb53024*/ bool get_Aborted();
            /*0xb53450*/ System.Net.WebResponse GetResponse();
            /*0xb54dec*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0xb554b4*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0xb558c0*/ System.IO.Stream GetRequestStream();
            /*0xb55e6c*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0xb563ac*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0xb540c0*/ void SubmitRequest(bool isAsync);
            /*0xb57108*/ System.Exception TranslateConnectException(System.Exception e);
            /*0xb5681c*/ void CreateConnectionAsync();
            /*0xb568b0*/ System.Net.FtpControlStream CreateConnection();
            /*0xb56a64*/ System.IO.Stream TimedSubmitRequestHelper(bool isAsync);
            /*0xb57280*/ void TimerCallback(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            /*0xb57214*/ System.Net.TimerThread.Queue get_TimerQueue();
            /*0xb56e88*/ bool AttemptedRecovery(System.Exception e);
            /*0xb54aa0*/ void SetException(System.Exception exception);
            /*0xb53bf8*/ void CheckError();
            /*0xb4abac*/ void RequestCallback(object obj);
            /*0xb57dfc*/ void SyncRequestCallback(object obj);
            /*0xb5739c*/ void AsyncRequestCallback(object obj);
            /*0xb53c8c*/ System.Net.FtpWebRequest.RequestStage FinishRequestStage(System.Net.FtpWebRequest.RequestStage stage);
            /*0xb581cc*/ void Abort();
            /*0xb58650*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0xb586b8*/ bool get_UseBinary();
            /*0xb586c0*/ bool get_UsePassive();
            /*0xb4d6d8*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0xb586c8*/ bool get_EnableSsl();
            /*0xb586d0*/ System.Net.WebHeaderCollection get_Headers();
            /*0xb5879c*/ void set_ContentType(string value);
            /*0xb58848*/ bool get_UseDefaultCredentials();
            /*0xb52d2c*/ bool get_InUse();
            /*0xb545b0*/ void EnsureFtpWebResponse(System.Exception exception);
            /*0xb58a1c*/ void DataStreamClosed(System.Net.CloseExState closeState);

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

                /*0xb58c6c*/ void MoveNext();
                /*0xb58f78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c
            {
                static /*0x0*/ System.Net.FtpWebRequest.<> <>9;
                static /*0x8*/ System.Func<System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0;

                static /*0xb58f84*/ <>c();
                /*0xb58fe8*/ <>c();
                /*0xb58ff0*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <get_ClientCertificates>b__114_0();
            }
        }

        class FtpWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0xb5904c*/ FtpWebRequestCreator();
            /*0xb59054*/ System.Net.WebRequest Create(System.Uri uri);
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

            /*0xb58900*/ FtpWebResponse(System.IO.Stream responseStream, long contentLength, System.Uri responseUri, System.Net.FtpStatusCode statusCode, string statusLine, System.DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage);
            /*0xb5738c*/ void UpdateStatus(System.Net.FtpStatusCode statusCode, string statusLine, string exitMessage);
            /*0xb590b4*/ System.IO.Stream GetResponseStream();
            /*0xb5886c*/ void SetResponseStream(System.IO.Stream stream);
            /*0xb591a8*/ void Close();
            /*0xb5928c*/ System.Net.WebHeaderCollection get_Headers();
            /*0xb593a8*/ System.Uri get_ResponseUri();
            /*0xb593b0*/ System.Net.FtpStatusCode get_StatusCode();

            class EmptyStream : System.IO.MemoryStream
            {
                /*0xb5911c*/ EmptyStream();
            }
        }

        class NetworkStreamWrapper : System.IO.Stream
        {
            /*0x28*/ System.Net.Sockets.TcpClient _client;
            /*0x30*/ System.Net.Sockets.NetworkStream _networkStream;

            /*0xb4a7fc*/ NetworkStreamWrapper(System.Net.Sockets.TcpClient client);
            /*0xb4d65c*/ bool get_UsingSecureStream();
            /*0xb4ce28*/ System.Net.IPAddress get_ServerAddress();
            /*0xb4eb4c*/ System.Net.Sockets.Socket get_Socket();
            /*0xb593b8*/ System.Net.Sockets.NetworkStream get_NetworkStream();
            /*0xb593c0*/ void set_NetworkStream(System.Net.Sockets.NetworkStream value);
            /*0xb593c8*/ bool get_CanRead();
            /*0xb593e8*/ bool get_CanSeek();
            /*0xb59408*/ bool get_CanWrite();
            /*0xb59428*/ bool get_CanTimeout();
            /*0xb59448*/ int get_ReadTimeout();
            /*0xb5946c*/ void set_ReadTimeout(int value);
            /*0xb59490*/ int get_WriteTimeout();
            /*0xb594b4*/ void set_WriteTimeout(int value);
            /*0xb594d8*/ long get_Length();
            /*0xb594f8*/ long get_Position();
            /*0xb59518*/ void set_Position(long value);
            /*0xb5953c*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0xb59560*/ int Read(byte[] buffer, int offset, int size);
            /*0xb59584*/ void Write(byte[] buffer, int offset, int size);
            /*0xb595a8*/ void Dispose(bool disposing);
            /*0xb4bd50*/ void CloseSocket();
            /*0xb4aa78*/ void Close(int timeout);
            /*0xb59654*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0xb59678*/ int EndRead(System.IAsyncResult asyncResult);
            /*0xb5969c*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0xb596c0*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0xb596e4*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0xb59708*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0xb5972c*/ void Flush();
            /*0xb59750*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0xb59774*/ void SetLength(long value);
            /*0xb56a14*/ void SetSocketTimeoutOption(int timeout);
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

            /*0xb59798*/ Authorization(string token);
            /*0xb5983c*/ Authorization(string token, bool finished);
            /*0xb598d0*/ string get_Message();
            /*0xb598d8*/ bool get_Complete();
        }

        class CredentialCache
        {
            static /*0xb598e0*/ System.Net.ICredentials get_DefaultCredentials();
            static /*0xb59938*/ System.Net.NetworkCredential get_DefaultNetworkCredentials();
        }

        class SystemNetworkCredential : System.Net.NetworkCredential
        {
            static /*0x0*/ System.Net.SystemNetworkCredential defaultCredential;

            static /*0xb599e8*/ SystemNetworkCredential();
            /*0xb59990*/ SystemNetworkCredential();
        }

        class EndPoint
        {
            /*0xb4a14c*/ EndPoint();
            /*0xb59a48*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0xb59af4*/ System.Net.SocketAddress Serialize();
            /*0xb59ba0*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
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
            System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
            string get_AuthenticationType();
        }

        interface ICertificatePolicy
        {
            bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
        }

        interface ICredentials
        {
            System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class IPHostEntry
        {
            /*0x10*/ string hostName;
            /*0x18*/ string[] aliases;
            /*0x20*/ System.Net.IPAddress[] addressList;
            /*0x28*/ bool isTrustedHost;

            /*0xb59bec*/ IPHostEntry();
            /*0xb59bc4*/ string get_HostName();
            /*0xb59bcc*/ void set_HostName(string value);
            /*0xb59bd4*/ void set_Aliases(string[] value);
            /*0xb59bdc*/ System.Net.IPAddress[] get_AddressList();
            /*0xb59be4*/ void set_AddressList(System.Net.IPAddress[] value);
        }

        interface IWebRequestCreate
        {
            System.Net.WebRequest Create(System.Uri uri);
        }

        class InternalException : System.SystemException
        {
            /*0xb4b3e8*/ InternalException();
        }

        class NclUtilities
        {
            static /*0x0*/ System.Net.IPAddress[] _LocalAddresses;
            static /*0x8*/ object _LocalAddressesLock;
            static /*0x10*/ string _LocalDomainName;

            static /*0xb59bfc*/ bool IsFatal(System.Exception exception);
            static /*0xb59cbc*/ bool IsAddressLocal(System.Net.IPAddress ipAddress);
            static /*0xb5a200*/ System.Net.IPHostEntry GetLocalHost();
            static /*0xb59d44*/ System.Net.IPAddress[] get_LocalAddresses();
            static /*0xb5a218*/ object get_LocalAddressesLock();
        }

        class ValidationHelper
        {
            static /*0x0*/ string[] EmptyArray;
            static /*0x8*/ char[] InvalidMethodChars;
            static /*0x10*/ char[] InvalidParamChars;

            static /*0xb5a2e4*/ ValidationHelper();
            static /*0xb59828*/ string MakeStringNull(string stringValue);
            static /*0xb5a2bc*/ bool IsBlankString(string stringValue);
            static /*0xb5a2d8*/ bool ValidateTcpPort(int port);
        }

        class ExceptionHelper
        {
            static /*0xb59b18*/ System.NotImplementedException get_MethodNotImplementedException();
            static /*0xb59a6c*/ System.NotImplementedException get_PropertyNotImplementedException();
            static /*0xb53c0c*/ System.Net.WebException get_TimeoutException();
            static /*0xb587c0*/ System.NotSupportedException get_PropertyNotSupportedException();
            static /*0xb508f4*/ System.Net.WebException get_RequestAbortedException();
        }

        class WebRequestPrefixElement
        {
            /*0x10*/ string Prefix;
            /*0x18*/ System.Net.IWebRequestCreate creator;
            /*0x20*/ System.Type creatorType;

            /*0xb5a5ec*/ WebRequestPrefixElement(string P, System.Net.IWebRequestCreate C);
            /*0xb5a3e8*/ System.Net.IWebRequestCreate get_Creator();
            /*0xb5a5e4*/ void set_Creator(System.Net.IWebRequestCreate value);
        }

        class HttpContinueDelegate : System.MulticastDelegate
        {
            /*0xb5a618*/ HttpContinueDelegate(object object, nint method);
            /*0xb5a6dc*/ void Invoke(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
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

            static /*0xb5a748*/ KnownHttpVerb();
            static /*0xb5aa60*/ System.Net.KnownHttpVerb Parse(string name);
            /*0xb5a6f0*/ KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse);
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

            /*0xb533e8*/ NetworkCredential(string userName, string password);
            /*0xb58ba8*/ NetworkCredential(string userName, string password, string domain);
            /*0xb4ff84*/ string get_UserName();
            /*0xb5ab28*/ void set_UserName(string value);
            /*0xb4ff94*/ string get_Password();
            /*0xb5ab88*/ void set_Password(string value);
            /*0xb4ff8c*/ string get_Domain();
            /*0xb5aba8*/ void set_Domain(string value);
            /*0xb5ac14*/ string InternalGetUserName();
            /*0xb5ac08*/ string InternalGetPassword();
            /*0xb5ac1c*/ string InternalGetDomain();
            /*0xb5ac24*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0xb5ac28*/ ProtocolViolationException();
            /*0xb55e64*/ ProtocolViolationException(string message);
            /*0xb5ac30*/ ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5ac38*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5ac40*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class SocketAddress
        {
            /*0x10*/ int m_Size;
            /*0x18*/ byte[] m_Buffer;
            /*0x20*/ bool m_changed;
            /*0x24*/ int m_hash;

            /*0xb5accc*/ SocketAddress(System.Net.Sockets.AddressFamily family, int size);
            /*0xb5adec*/ SocketAddress(System.Net.IPAddress ipAddress);
            /*0xb4a290*/ SocketAddress(System.Net.IPAddress ipaddress, int port);
            /*0xb4a4d4*/ System.Net.Sockets.AddressFamily get_Family();
            /*0xb5ac48*/ int get_Size();
            /*0xb5ac50*/ byte get_Item(int offset);
            /*0xb5b04c*/ System.Net.IPAddress GetIPAddress();
            /*0xb4a50c*/ System.Net.IPEndPoint GetIPEndPoint();
            /*0xb5b238*/ bool Equals(object comparand);
            /*0xb5b324*/ int GetHashCode();
            /*0xb5b454*/ string ToString();
        }

        class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x8c*/ System.Net.WebExceptionStatus m_Status;
            /*0x90*/ System.Net.WebResponse m_Response;
            /*0x98*/ System.Net.WebExceptionInternalStatus m_InternalStatus;

            /*0xb5b740*/ WebException();
            /*0xb4ba64*/ WebException(string message);
            /*0xb5737c*/ WebException(string message, System.Exception innerException);
            /*0xb4cebc*/ WebException(string message, System.Net.WebExceptionStatus status);
            /*0xb5b750*/ WebException(string message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException);
            /*0xb4b258*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0xb5b784*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0xb5b76c*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0xb5b864*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0xb5b954*/ WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5b964*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5b970*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5b978*/ System.Net.WebExceptionStatus get_Status();
            /*0xb5b980*/ System.Net.WebResponse get_Response();
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

            static /*0xb5bb20*/ WebExceptionMapping();
            static /*0xb5b988*/ string GetWebStatusString(System.Net.WebExceptionStatus status);
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
            /*0x68*/ string[] m_CommonHeaders;
            /*0x70*/ int m_NumCommonHeaders;
            /*0x78*/ System.Collections.Specialized.NameValueCollection m_InnerCollection;
            /*0x80*/ System.Net.WebHeaderCollectionType m_Type;

            static /*0xb5de28*/ WebHeaderCollection();
            static /*0xb5bd2c*/ bool AllowMultiValues(string name);
            static /*0xb5c00c*/ string CheckBadChars(string name, bool isHeaderValue);
            static /*0xb5c3a0*/ bool ContainsNonAsciiChars(string token);
            static /*0xb5d21c*/ string GetAsString(System.Collections.Specialized.NameValueCollection cc, bool winInetCompat, bool forTrace);
            /*0xb58738*/ WebHeaderCollection();
            /*0xb5d4c0*/ WebHeaderCollection(System.Net.WebHeaderCollectionType type);
            /*0xb5d5a4*/ WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5bb88*/ void NormalizeCommonHeaders();
            /*0xb5bc88*/ System.Collections.Specialized.NameValueCollection get_InnerCollection();
            /*0xb5bdd8*/ bool get_AllowHttpRequestHeader();
            /*0xb5be10*/ void Remove(System.Net.HttpRequestHeader header);
            /*0xb5bf08*/ void AddInternal(string name, string value);
            /*0xb5bf5c*/ void ChangeInternal(string name, string value);
            /*0xb5bfb0*/ void RemoveInternal(string name);
            /*0xb5c424*/ void ThrowOnRestrictedHeader(string headerName);
            /*0xb5c594*/ void Add(string name, string value);
            /*0xb5c748*/ void Add(string header);
            /*0xb5ca24*/ void Set(string name, string value);
            /*0xb5cc54*/ void SetInternal(string name, string value);
            /*0xb5ce78*/ void Remove(string name);
            /*0xb5cfb4*/ string[] GetValues(string header);
            /*0xb5d1c0*/ string ToString();
            /*0xb5d768*/ void OnDeserialization(object sender);
            /*0xb5d76c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5d8ec*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0xb5d8f8*/ string Get(string name);
            /*0xb5dc20*/ System.Collections.IEnumerator GetEnumerator();
            /*0xb5dc9c*/ int get_Count();
            /*0xb5dccc*/ System.Collections.Specialized.NameObjectCollectionBase.KeysCollection get_Keys();
            /*0xb5dcfc*/ string Get(int index);
            /*0xb5dd3c*/ string[] GetValues(int index);
            /*0xb5dd7c*/ string GetKey(int index);
            /*0xb5ddbc*/ string[] get_AllKeys();
            /*0xb5ddec*/ void Clear();

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

            static /*0x93317c*/ CaseInsensitiveAscii();
            /*0x933174*/ CaseInsensitiveAscii();
            /*0x932c84*/ int GetHashCode(object myObject);
            /*0x932d9c*/ int Compare(object firstObject, object secondObject);
            /*0x932f0c*/ int FastGetHashCode(string myString);
            /*0x932ffc*/ bool Equals(object firstObject, object secondObject);
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

            static /*0x934870*/ WebRequest();
            static /*0x933238*/ object get_InternalSyncObject();
            static /*0x93330c*/ System.Net.WebRequest Create(System.Uri requestUri, bool useUriBase);
            static /*0x933720*/ System.Net.WebRequest Create(string requestUriString);
            static /*0x9337fc*/ System.Net.WebRequest Create(System.Uri requestUri);
            static /*0x93358c*/ System.Collections.ArrayList get_PrefixList();
            static /*0x9338d8*/ System.Collections.ArrayList PopulatePrefixList();
            static /*0x9344cc*/ System.Net.IWebProxy get_InternalDefaultWebProxy();
            static /*0x934698*/ void set_InternalDefaultWebProxy(System.Net.IWebProxy value);
            static /*0x93481c*/ void set_DefaultWebProxy(System.Net.IWebProxy value);
            /*0x933b0c*/ WebRequest();
            /*0x933b30*/ WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x933b38*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x933b44*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x933b48*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x933b4c*/ void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy);
            /*0x933c04*/ string get_Method();
            /*0x933c2c*/ void set_Method(string value);
            /*0x933c54*/ System.Uri get_RequestUri();
            /*0x933c7c*/ System.Net.WebHeaderCollection get_Headers();
            /*0x933ca4*/ long get_ContentLength();
            /*0x933ccc*/ void set_ContentLength(long value);
            /*0x933cf4*/ void set_ContentType(string value);
            /*0x933d1c*/ System.Net.ICredentials get_Credentials();
            /*0x933d44*/ void set_Credentials(System.Net.ICredentials value);
            /*0x933d6c*/ bool get_UseDefaultCredentials();
            /*0x933d94*/ System.Net.IWebProxy get_Proxy();
            /*0x933dbc*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x933de4*/ int get_Timeout();
            /*0x933e0c*/ void set_Timeout(int value);
            /*0x933e34*/ System.IO.Stream GetRequestStream();
            /*0x933e5c*/ System.Net.WebResponse GetResponse();
            /*0x933e84*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x933eac*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x933ed4*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x933efc*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x933f24*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync();
            /*0x934204*/ System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync();
            /*0x9341b4*/ System.Security.Principal.WindowsIdentity SafeCaptureIdenity();
            /*0x934494*/ void Abort();
            /*0x9344bc*/ System.Net.Cache.RequestCacheProtocol get_CacheProtocol();
            /*0x9344c4*/ void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value);
            /*0x934b90*/ System.Threading.Tasks.Task<System.IO.Stream> <GetRequestStreamAsync>b__78_0();
            /*0x934c8c*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0();

            class DesignerWebRequestCreate : System.Net.IWebRequestCreate
            {
                /*0x934b88*/ DesignerWebRequestCreate();
                /*0x934d88*/ System.Net.WebRequest Create(System.Uri uri);
            }

            class <>c__DisplayClass78_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x9341ac*/ <>c__DisplayClass78_0();
                /*0x934ddc*/ System.Threading.Tasks.Task<System.IO.Stream> <GetRequestStreamAsync>b__1();
            }

            class <>c__DisplayClass79_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x93448c*/ <>c__DisplayClass79_0();
                /*0x935190*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1();
            }
        }

        class WebResponse : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x18*/ bool m_IsFromCache;

            /*0x935544*/ WebResponse();
            /*0x93554c*/ WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x935554*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x935560*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x935564*/ void Close();
            /*0x935568*/ void Dispose();
            /*0x9355d4*/ void Dispose(bool disposing);
            /*0x935660*/ bool get_IsFromCache();
            /*0x935668*/ System.IO.Stream GetResponseStream();
            /*0x935690*/ System.Uri get_ResponseUri();
            /*0x9356b8*/ System.Net.WebHeaderCollection get_Headers();
        }

        class BufferOffsetSize
        {
            /*0x10*/ byte[] Buffer;
            /*0x18*/ int Offset;
            /*0x1c*/ int Size;

            /*0x9356e0*/ BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer);
            /*0x93578c*/ BufferOffsetSize(byte[] buffer, bool copyBuffer);
        }

        class HeaderParser : System.MulticastDelegate
        {
            /*0x9357ac*/ HeaderParser(object object, nint method);
            /*0x935880*/ string[] Invoke(string value);
        }

        class HeaderInfo
        {
            /*0x10*/ bool IsRequestRestricted;
            /*0x11*/ bool IsResponseRestricted;
            /*0x18*/ System.Net.HeaderParser Parser;
            /*0x20*/ string HeaderName;
            /*0x28*/ bool AllowMultiValues;

            /*0x935894*/ HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, System.Net.HeaderParser p);
        }

        class HeaderInfoTable
        {
            static /*0x0*/ System.Collections.Hashtable HeaderHashTable;
            static /*0x8*/ System.Net.HeaderInfo UnknownHeaderInfo;
            static /*0x10*/ System.Net.HeaderParser SingleParser;
            static /*0x18*/ System.Net.HeaderParser MultiParser;

            static /*0x935b70*/ HeaderInfoTable();
            static /*0x9358e8*/ string[] ParseSingleValue(string value);
            static /*0x935978*/ string[] ParseMultiValue(string value);
            /*0x937530*/ HeaderInfoTable();
            /*0x937454*/ System.Net.HeaderInfo get_Item(string name);
        }

        enum CloseExState
        {
            Normal = 0,
            Abort = 1,
            Silent = 2,
        }

        interface ICloseEx
        {
            void CloseEx(System.Net.CloseExState closeState);
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

            static /*0x937538*/ System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext();
            /*0x9375d4*/ LazyAsyncResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x937664*/ object get_AsyncObject();
            /*0x93766c*/ object get_AsyncState();
            /*0x937674*/ System.AsyncCallback get_AsyncCallback();
            /*0x93767c*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x937720*/ bool LazilyCreateEvent(ref System.Threading.ManualResetEvent waitHandle);
            /*0x9378e4*/ bool get_CompletedSynchronously();
            /*0x937914*/ bool get_IsCompleted();
            /*0x9378d4*/ bool get_InternalPeekCompleted();
            /*0x937944*/ bool get_EndCalled();
            /*0x93794c*/ void set_EndCalled(bool value);
            /*0x937958*/ void ProtectedInvokeCallback(object result, nint userToken);
            /*0x937b30*/ void InvokeCallback(object result);
            /*0x937b90*/ void InvokeCallback();
            /*0x937be4*/ void Complete(nint userToken);
            /*0x937d7c*/ void WorkerThreadComplete(object state);
            /*0x937e28*/ void Cleanup();
            /*0x937e2c*/ object InternalWaitForCompletion();
            /*0x937e34*/ object WaitForCompletion(bool snap);

            class ThreadContext
            {
                /*0x10*/ int m_NestedIOCount;

                /*0x9375cc*/ ThreadContext();
            }
        }

        class NetRes
        {
            static /*0x9380ec*/ string GetWebStatusString(string Res, System.Net.WebExceptionStatus Status);
            static /*0x9381ac*/ string GetWebStatusString(System.Net.WebExceptionStatus Status);
            static /*0x93820c*/ string GetWebStatusCodeString(System.Net.FtpStatusCode statusCode, string statusDescription);
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

            static /*0x9383e8*/ TimerThread();
            static /*0x934924*/ System.Net.TimerThread.Queue CreateQueue(int durationMilliseconds);
            static /*0x93871c*/ System.Net.TimerThread.Queue GetOrCreateQueue(int durationMilliseconds);
            static /*0x9390b8*/ void Prod();
            static /*0x9391cc*/ void ThreadProc();
            static /*0x939b84*/ void StopTimerThread();
            static /*0x939b60*/ bool IsTickBetween(int start, int end, int comparand);
            static /*0x939c00*/ void OnDomainUnload(object sender, System.EventArgs e);

            class Queue
            {
                /*0x10*/ int m_DurationMilliseconds;

                /*0x939cc4*/ Queue(int durationMilliseconds);
                /*0x939cec*/ int get_Duration();
                System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class Timer : System.IDisposable
            {
                /*0x10*/ int m_StartTimeMilliseconds;
                /*0x14*/ int m_DurationMilliseconds;

                /*0x939cf4*/ Timer(int durationMilliseconds);
                /*0x939d28*/ int get_StartTime();
                /*0x939d30*/ int get_Expiration();
                bool Cancel();
                bool get_HasExpired();
                /*0x939d3c*/ void Dispose();
            }

            class Callback : System.MulticastDelegate
            {
                /*0x939d48*/ Callback(object object, nint method);
                /*0x939e78*/ void Invoke(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            }

            class TimerQueue : System.Net.TimerThread.Queue
            {
                /*0x18*/ nint m_ThisHandle;
                /*0x20*/ System.Net.TimerThread.TimerNode m_Timers;

                /*0x938684*/ TimerQueue(int durationMilliseconds);
                /*0x939ebc*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
                /*0x939990*/ bool Fire(ref int nextExpiration);
            }

            class InfiniteTimerQueue : System.Net.TimerThread.Queue
            {
                /*0x938664*/ InfiniteTimerQueue();
                /*0x93a394*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class TimerNode : System.Net.TimerThread.Timer
            {
                /*0x18*/ System.Net.TimerThread.TimerNode.TimerState m_TimerState;
                /*0x20*/ System.Net.TimerThread.Callback m_Callback;
                /*0x28*/ object m_Context;
                /*0x30*/ object m_QueueLock;
                /*0x38*/ System.Net.TimerThread.TimerNode next;
                /*0x40*/ System.Net.TimerThread.TimerNode prev;

                /*0x93a0c8*/ TimerNode(System.Net.TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock);
                /*0x939e8c*/ TimerNode();
                /*0x93a430*/ bool get_HasExpired();
                /*0x93a440*/ System.Net.TimerThread.TimerNode get_Next();
                /*0x93a448*/ void set_Next(System.Net.TimerThread.TimerNode value);
                /*0x93a450*/ System.Net.TimerThread.TimerNode get_Prev();
                /*0x93a458*/ void set_Prev(System.Net.TimerThread.TimerNode value);
                /*0x93a460*/ bool Cancel();
                /*0x93a120*/ bool Fire();

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

                /*0x93a404*/ InfiniteTimer();
                /*0x93a598*/ bool get_HasExpired();
                /*0x93a5a0*/ bool Cancel();
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

            static /*0x93c3d4*/ Cookie();
            static /*0x93ab5c*/ bool IsDomainEqualToHost(string domain, string host);
            static /*0x93b5ac*/ bool DomainCharsTest(string name);
            static /*0x93bd34*/ System.Collections.IComparer GetComparer();
            /*0x93a5c4*/ Cookie();
            /*0x93a6a4*/ string get_Comment();
            /*0x93a6ac*/ void set_Comment(string value);
            /*0x93a704*/ void set_CommentUri(System.Uri value);
            /*0x93a70c*/ void set_HttpOnly(bool value);
            /*0x93a718*/ void set_Discard(bool value);
            /*0x93a724*/ string get_Domain();
            /*0x93a72c*/ void set_Domain(string value);
            /*0x93a7a0*/ string get__Domain();
            /*0x93a87c*/ bool get_Expired();
            /*0x93a934*/ void set_Expires(System.DateTime value);
            /*0x93a93c*/ string get_Name();
            /*0x93a944*/ bool InternalSetName(string value);
            /*0x93aa4c*/ string get_Path();
            /*0x93aa54*/ void set_Path(string value);
            /*0x93aac0*/ string get__Path();
            /*0x93a86c*/ bool get_Plain();
            /*0x93abb4*/ bool VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow);
            /*0x93b70c*/ void set_Port(string value);
            /*0x93ba40*/ int[] get_PortList();
            /*0x93ba48*/ string get__Port();
            /*0x93bb10*/ bool get_Secure();
            /*0x93bb18*/ void set_Secure(bool value);
            /*0x93bb24*/ string get_Value();
            /*0x93bb2c*/ void set_Value(string value);
            /*0x93bb94*/ System.Net.CookieVariant get_Variant();
            /*0x93bb9c*/ string get_DomainKey();
            /*0x93bbb8*/ int get_Version();
            /*0x93bbc0*/ void set_Version(int value);
            /*0x93bc38*/ string get__Version();
            /*0x93bd8c*/ bool Equals(object comparand);
            /*0x93be5c*/ int GetHashCode();
            /*0x93c0c4*/ string ToString();
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

            static /*0x93cc3c*/ CookieTokenizer();
            /*0x93c528*/ CookieTokenizer(string tokenStream);
            /*0x93c560*/ bool get_EndOfCookie();
            /*0x93c568*/ void set_EndOfCookie(bool value);
            /*0x93c574*/ bool get_Eof();
            /*0x93c584*/ string get_Name();
            /*0x93c58c*/ void set_Name(string value);
            /*0x93c594*/ bool get_Quoted();
            /*0x93c59c*/ void set_Quoted(bool value);
            /*0x93c5a8*/ System.Net.CookieToken get_Token();
            /*0x93c5b0*/ void set_Token(System.Net.CookieToken value);
            /*0x93c5b8*/ string get_Value();
            /*0x93c5c0*/ void set_Value(string value);
            /*0x93c5c8*/ string Extract();
            /*0x93c650*/ System.Net.CookieToken FindNext(bool ignoreComma, bool ignoreEquals);
            /*0x93c8f4*/ System.Net.CookieToken Next(bool first, bool parseResponseCookies);
            /*0x93c9f4*/ void Reset();
            /*0x93ca5c*/ System.Net.CookieToken TokenFromName(bool parseResponseCookies);

            struct RecognizedAttribute
            {
                /*0x10*/ string m_name;
                /*0x18*/ System.Net.CookieToken m_token;

                /*0x93cf4c*/ RecognizedAttribute(string name, System.Net.CookieToken token);
                /*0x93cf58*/ System.Net.CookieToken get_Token();
                /*0x93cc18*/ bool IsEqualTo(string value);
            }
        }

        class CookieParser
        {
            /*0x10*/ System.Net.CookieTokenizer m_tokenizer;

            static /*0x93b648*/ string CheckQuoted(string value);
            /*0x93cf60*/ CookieParser(string cookieString);
            /*0x93cfd8*/ System.Net.Cookie Get();
        }

        class Comparer : System.Collections.IComparer
        {
            /*0x93c520*/ Comparer();
            /*0x93d534*/ int System.Collections.IComparer.Compare(object ol, object or);
        }

        class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ int m_version;
            /*0x18*/ System.Collections.ArrayList m_list;
            /*0x20*/ System.DateTime m_TimeStamp;
            /*0x28*/ bool m_has_other_versions;
            /*0x29*/ bool m_IsReadOnly;

            /*0x93d610*/ CookieCollection();
            /*0x93d6b8*/ System.Net.Cookie get_Item(int index);
            /*0x93d7a4*/ void Add(System.Net.Cookie cookie);
            /*0x93dc2c*/ void Add(System.Net.CookieCollection cookies);
            /*0x93df8c*/ int get_Count();
            /*0x93dfb0*/ bool get_IsSynchronized();
            /*0x93dfb8*/ object get_SyncRoot();
            /*0x93dfbc*/ void CopyTo(System.Array array, int index);
            /*0x93dfe0*/ System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how);
            /*0x93e0a0*/ bool get_IsOtherVersionSeen();
            /*0x93e0a8*/ int InternalAdd(System.Net.Cookie cookie, bool isStrict);
            /*0x93d868*/ int IndexOf(System.Net.Cookie cookie);
            /*0x93e560*/ void RemoveAt(int idx);
            /*0x93df2c*/ System.Collections.IEnumerator GetEnumerator();

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

                /*0x93e584*/ CookieCollectionEnumerator(System.Net.CookieCollection cookies);
                /*0x93e5e0*/ object System.Collections.IEnumerator.get_Current();
                /*0x93e68c*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x93e730*/ void System.Collections.IEnumerator.Reset();
            }
        }

        struct HeaderVariantInfo
        {
            /*0x10*/ string m_name;
            /*0x18*/ System.Net.CookieVariant m_variant;

            /*0x93e73c*/ HeaderVariantInfo(string name, System.Net.CookieVariant variant);
            /*0x93e748*/ string get_Name();
            /*0x93e750*/ System.Net.CookieVariant get_Variant();
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

            static /*0x942b84*/ CookieContainer();
            /*0x93e758*/ CookieContainer();
            /*0x93e84c*/ void AddRemoveDomain(string key, System.Net.PathList value);
            /*0x93e974*/ void Add(System.Net.Cookie cookie, bool throwOnError);
            /*0x93f7c8*/ bool AgeCookies(string domain);
            /*0x940d30*/ int ExpireCollection(System.Net.CookieCollection cc);
            /*0x940ec0*/ bool IsLocalDomain(string host);
            /*0x94115c*/ System.Net.CookieCollection CookieCutter(System.Uri uri, string headerName, string setCookieHeader, bool isThrow);
            /*0x94183c*/ System.Net.CookieCollection InternalGetCookies(System.Uri uri);
            /*0x941ce8*/ void BuildCookieCollectionFromDomainMatches(System.Uri uri, bool isSecure, int port, System.Net.CookieCollection cookies, System.Collections.Generic.List<string> domainAttribute, bool matchOnlyPlainCookie);
            /*0x942510*/ void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, int port, bool isSecure, bool isPlainOnly);
            /*0x94271c*/ string GetCookieHeader(System.Uri uri);
            /*0x9427ec*/ string GetCookieHeader(System.Uri uri, ref string optCookie2);
        }

        class PathList
        {
            /*0x10*/ System.Collections.SortedList m_list;

            /*0x93f194*/ PathList();
            /*0x940e9c*/ int get_Count();
            /*0x93f23c*/ int GetCookiesCount();
            /*0x940d0c*/ System.Collections.ICollection get_Values();
            /*0x93f6a4*/ object get_Item(string s);
            /*0x93f6c8*/ void set_Item(string s, object value);
            /*0x9424ec*/ System.Collections.IEnumerator GetEnumerator();
            /*0x93f680*/ object get_SyncRoot();

            class PathListComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.Net.PathList.PathListComparer StaticInstance;

                static /*0x942db8*/ PathListComparer();
                /*0x942db0*/ PathListComparer();
                /*0x942c48*/ int System.Collections.IComparer.Compare(object ol, object or);
            }
        }

        class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
        {
            /*0x942e1c*/ CookieException();
            /*0x93b5a4*/ CookieException(string message);
            /*0x940d04*/ CookieException(string message, System.Exception inner);
            /*0x942e24*/ CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x942e2c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x942e34*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

            static /*0x9459b4*/ FileWebRequest();
            static /*0x944c5c*/ void GetRequestStreamCallback(object state);
            static /*0x944f20*/ void GetResponseCallback(object state);
            /*0x942e3c*/ FileWebRequest(System.Uri uri);
            /*0x942fb8*/ FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x943354*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x943360*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9435f0*/ bool get_Aborted();
            /*0x943600*/ long get_ContentLength();
            /*0x943608*/ void set_ContentLength(long value);
            /*0x94368c*/ void set_ContentType(string value);
            /*0x9436e8*/ System.Net.ICredentials get_Credentials();
            /*0x9436f0*/ void set_Credentials(System.Net.ICredentials value);
            /*0x9436f8*/ System.Net.WebHeaderCollection get_Headers();
            /*0x943700*/ string get_Method();
            /*0x943708*/ void set_Method(string value);
            /*0x9437e0*/ System.Net.IWebProxy get_Proxy();
            /*0x9437e8*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x9437f0*/ int get_Timeout();
            /*0x9437f8*/ void set_Timeout(int value);
            /*0x943880*/ System.Uri get_RequestUri();
            /*0x943888*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x943ccc*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x943c58*/ bool CanGetRequestStream();
            /*0x943fa8*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x9442a4*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x9445a0*/ System.IO.Stream GetRequestStream();
            /*0x9448fc*/ System.Net.WebResponse GetResponse();
            /*0x945518*/ void UnblockReader();
            /*0x9455f0*/ bool get_UseDefaultCredentials();
            /*0x945618*/ void Abort();
        }

        class FileWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x933b04*/ FileWebRequestCreator();
            /*0x945a88*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FileWebStream : System.IO.FileStream, System.Net.ICloseEx
        {
            /*0x70*/ System.Net.FileWebRequest m_request;

            /*0x944e84*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing);
            /*0x945ae8*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, int length, bool async);
            /*0x945b9c*/ void Dispose(bool disposing);
            /*0x945c4c*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x945c88*/ int Read(byte[] buffer, int offset, int size);
            /*0x945dd4*/ void Write(byte[] buffer, int offset, int size);
            /*0x945e9c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x945f7c*/ int EndRead(System.IAsyncResult ar);
            /*0x94601c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x9460fc*/ void EndWrite(System.IAsyncResult ar);
            /*0x945d50*/ void CheckError();
        }

        class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.Net.ICloseEx
        {
            /*0x19*/ bool m_closed;
            /*0x20*/ long m_contentLength;
            /*0x28*/ System.IO.FileAccess m_fileAccess;
            /*0x30*/ System.Net.WebHeaderCollection m_headers;
            /*0x38*/ System.IO.Stream m_stream;
            /*0x40*/ System.Uri m_uri;

            /*0x94523c*/ FileWebResponse(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, bool asyncHint);
            /*0x94619c*/ FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9463d0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9463dc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x94656c*/ System.Net.WebHeaderCollection get_Headers();
            /*0x946608*/ System.Uri get_ResponseUri();
            /*0x946584*/ void CheckDisposed();
            /*0x946620*/ void Close();
            /*0x9466b8*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x946824*/ System.IO.Stream GetResponseStream();
        }

        interface IWebProxy
        {
            System.Uri GetProxy(System.Uri destination);
            bool IsBypassed(System.Uri host);
            System.Net.ICredentials get_Credentials();
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

            static /*0x9478dc*/ System.Net.IWebProxy CreateDefaultProxy();
            static /*0x947980*/ bool AreAllBypassed(System.Collections.Generic.IEnumerable<string> proxies, bool checkFirstOnly);
            static /*0x947c88*/ System.Uri ProxyUri(string proxyName);
            /*0x946878*/ WebProxy();
            /*0x94688c*/ WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials);
            /*0x947438*/ WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x947944*/ WebProxy(bool enableAutoproxy);
            /*0x946b78*/ System.Net.ICredentials get_Credentials();
            /*0x946b80*/ bool get_UseDefaultCredentials();
            /*0x946bfc*/ void set_UseDefaultCredentials(bool value);
            /*0x946c74*/ System.Uri GetProxy(System.Uri destination);
            /*0x946940*/ void UpdateRegExList(bool canThrow);
            /*0x946f24*/ bool IsMatchInBypassList(System.Uri input);
            /*0x9470bc*/ bool IsLocal(System.Uri host);
            /*0x947220*/ bool IsLocalInProxyHash(System.Uri host);
            /*0x947310*/ bool IsBypassed(System.Uri host);
            /*0x946e5c*/ bool IsBypassedManual(System.Uri host);
            /*0x9477a4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9477b0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9478d4*/ System.Net.AutoWebProxyScriptEngine get_ScriptEngine();
            /*0x947798*/ void UnsafeUpdateFromRegistry();
            /*0x946e10*/ bool GetProxyAuto(System.Uri destination, ref System.Uri proxyUri);
            /*0x9473f4*/ bool IsBypassedAuto(System.Uri destination, ref bool isBypassed);
        }

        class AutoWebProxyScriptEngine
        {
            /*0x947974*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList);
            /*0x947d2c*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList, ref int syncStatus);
        }

        class UnsafeNclNativeMethods
        {
            class HttpApi
            {
                static /*0x0*/ string[] m_Strings;

                static /*0x947d38*/ HttpApi();

                class HTTP_REQUEST_HEADER_ID
                {
                    static /*0x0*/ string[] m_Strings;

                    static /*0x9485b8*/ HTTP_REQUEST_HEADER_ID();
                    static /*0x94853c*/ string ToString(int position);
                }
            }

            class SecureStringHelper
            {
                static /*0x94907c*/ string CreateString(System.Security.SecureString secureString);
                static /*0x94922c*/ System.Security.SecureString CreateSecureString(string plainString);
            }
        }

        class Logging
        {
            static /*0x933584*/ bool get_On();
        }

        class ServerCertValidationCallback
        {
            /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;
            /*0x18*/ System.Threading.ExecutionContext m_Context;

            /*0x9492d8*/ ServerCertValidationCallback(System.Net.Security.RemoteCertificateValidationCallback validationCallback);
            /*0x949350*/ System.Net.Security.RemoteCertificateValidationCallback get_ValidationCallback();
            /*0x949358*/ void Callback(object state);
            /*0x949404*/ bool Invoke(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);

            class CallbackContext
            {
                /*0x10*/ object request;
                /*0x18*/ System.Security.Cryptography.X509Certificates.X509Certificate certificate;
                /*0x20*/ System.Security.Cryptography.X509Certificates.X509Chain chain;
                /*0x28*/ System.Net.Security.SslPolicyErrors sslPolicyErrors;
                /*0x2c*/ bool result;

                /*0x94956c*/ CallbackContext(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            }
        }

        class AuthenticationManager
        {
            static /*0x0*/ System.Collections.ArrayList modules;
            static /*0x8*/ object locker;
            static /*0x10*/ System.Net.ICredentialPolicy credential_policy;

            static /*0x94a38c*/ AuthenticationManager();
            static /*0x9495b0*/ void EnsureModules();
            static /*0x949860*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x94996c*/ System.Net.Authorization DoAuthenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x949e54*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
        }

        class BasicClient : System.Net.IAuthenticationModule
        {
            static /*0x94a85c*/ byte[] GetBytes(string str);
            static /*0x94a4b0*/ System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x949858*/ BasicClient();
            /*0x94a404*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x94a904*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x94a910*/ string get_AuthenticationType();
        }

        class BindIPEndPoint : System.MulticastDelegate
        {
            /*0x94a950*/ BindIPEndPoint(object object, nint method);
            /*0x94aa80*/ System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
        }

        class BufferedReadStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.BufferOffsetSize readBuffer;

            /*0x94aa94*/ BufferedReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.BufferOffsetSize readBuffer);
            /*0x94aabc*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x94abe4*/ bool TryReadFromBuffer(byte[] buffer, int offset, int size, ref int result);

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

                /*0x94ac74*/ void MoveNext();
                /*0x94af24*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ContentDecodeStream : System.Net.WebReadStream
        {
            /*0x40*/ System.IO.Stream <OriginalInnerStream>k__BackingField;

            static /*0x94af7c*/ System.Net.ContentDecodeStream Create(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.ContentDecodeStream.Mode mode);
            /*0x94b068*/ ContentDecodeStream(System.Net.WebOperation operation, System.IO.Stream decodeStream, System.IO.Stream originalInnerStream);
            /*0x94b090*/ System.IO.Stream get_OriginalInnerStream();
            /*0x94b098*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x94b0bc*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);

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

            static /*0x94b7b4*/ DigestHeaderParser();
            /*0x94b1ac*/ DigestHeaderParser(string header);
            /*0x94b260*/ string get_Realm();
            /*0x94b288*/ string get_Opaque();
            /*0x94b2b4*/ string get_Nonce();
            /*0x94b2e0*/ string get_Algorithm();
            /*0x94b30c*/ string get_QOP();
            /*0x94b338*/ bool Parse();
            /*0x94b6a4*/ void SkipWhitespace();
            /*0x94b724*/ string GetKey();
            /*0x94b514*/ bool GetKeywordAndValue(ref string key, ref string value);
        }

        class DigestSession
        {
            static /*0x0*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ System.DateTime lastUse;
            /*0x18*/ int _nc;
            /*0x20*/ System.Security.Cryptography.HashAlgorithm hash;
            /*0x28*/ System.Net.DigestHeaderParser parser;
            /*0x30*/ string _cnonce;

            static /*0x94b974*/ DigestSession();
            /*0x94b9c4*/ DigestSession();
            /*0x94ba34*/ string get_Algorithm();
            /*0x94ba4c*/ string get_Realm();
            /*0x94ba64*/ string get_Nonce();
            /*0x94ba7c*/ string get_Opaque();
            /*0x94ba94*/ string get_QOP();
            /*0x94baac*/ string get_CNonce();
            /*0x94bba0*/ bool Parse(string challenge);
            /*0x94bc80*/ string HashToHexString(string toBeHashed);
            /*0x94bdd0*/ string HA1(string username, string password);
            /*0x94bef4*/ string HA2(System.Net.HttpWebRequest webRequest);
            /*0x94bfc4*/ string Response(string username, string password, System.Net.HttpWebRequest webRequest);
            /*0x94c124*/ System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x94c704*/ System.DateTime get_LastUse();
        }

        class DigestClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Collections.Hashtable cache;

            static /*0x94d538*/ DigestClient();
            static /*0x94c70c*/ System.Collections.Hashtable get_Cache();
            static /*0x94c874*/ void CheckExpired(int count);
            /*0x949850*/ DigestClient();
            /*0x94d0bc*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x94d364*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x94d4f8*/ string get_AuthenticationType();
        }

        class Dns
        {
            static /*0x94d5bc*/ System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state);
            static /*0x94d744*/ System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult);
            static /*0x94d850*/ bool GetHostByName_icall(string host, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x94d854*/ bool GetHostByAddr_icall(string addr, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x94d858*/ bool GetHostName_icall(ref string h_name);
            static /*0x94d85c*/ void Error_11001(string hostName);
            static /*0x94d8c8*/ System.Net.IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist);
            static /*0x94dbdc*/ System.Net.IPHostEntry GetHostByAddressFromString(string address, bool parse);
            static /*0x94dd08*/ System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress);
            static /*0x94de7c*/ System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address);
            static /*0x94dfd4*/ System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress);
            static /*0x94dee8*/ System.Net.IPHostEntry GetHostByName(string hostName);
            static /*0x94e1b0*/ string GetHostName();
            static /*0x94e1dc*/ System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);

            class GetHostAddressesCallback : System.MulticastDelegate
            {
                /*0x9d1c24*/ GetHostAddressesCallback(object object, nint method);
                /*0x9d1cf8*/ System.Net.IPAddress[] Invoke(string hostName);
                /*0x9d1d0c*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x9d1d2c*/ System.Net.IPAddress[] EndInvoke(System.IAsyncResult result);
            }
        }

        class FixedSizeReadStream : System.Net.WebReadStream
        {
            /*0x40*/ long <ContentLength>k__BackingField;
            /*0x48*/ long position;

            /*0x9d1d40*/ FixedSizeReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, long contentLength);
            /*0x9d1d38*/ long get_ContentLength();
            /*0x9d1dd4*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);

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

                /*0x9d1efc*/ void MoveNext();
                /*0x9d21ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x9d2204*/ HttpRequestCreator();
            /*0x9d220c*/ System.Net.WebRequest Create(System.Uri uri);
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

            static /*0x9d2414*/ HttpWebRequest();
            static /*0x9d2a40*/ int get_DefaultMaximumErrorResponseLength();
            static System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationToken cancellationToken);
            static System.Threading.Tasks.Task<T> RunWithTimeoutWorker<T>(System.Threading.Tasks.Task<T> workerTask, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationTokenSource cts);
            static /*0x9d487c*/ System.Exception FlattenException(System.Exception e);
            static /*0x9d493c*/ System.Net.WebException GetWebException(System.Exception e, bool aborted);
            static /*0x9d40bc*/ System.Net.WebException CreateRequestAbortedException();
            /*0x9d226c*/ HttpWebRequest(System.Uri uri);
            /*0x9d24b0*/ HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9d7114*/ HttpWebRequest();
            /*0x9d24a0*/ void ResetAuthorization();
            /*0x9d2600*/ void SetSpecialHeaders(string HeaderName, string value);
            /*0x9d26c0*/ void set_Accept(string value);
            /*0x9d2780*/ System.Uri get_Address();
            /*0x9d2788*/ bool get_AllowWriteStreamBuffering();
            /*0x9d2790*/ System.Net.DecompressionMethods get_AutomaticDecompression();
            /*0x9d2798*/ bool get_InternalAllowBuffering();
            /*0x9d27ac*/ bool get_MethodWithBuffer();
            /*0x9d28a8*/ Mono.Net.Security.MobileTlsProvider get_TlsProvider();
            /*0x9d28b0*/ Mono.Security.Interface.MonoTlsSettings get_TlsSettings();
            /*0x9d28b8*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x9d2924*/ long get_ContentLength();
            /*0x9d292c*/ void set_ContentLength(long value);
            /*0x9d29bc*/ void set_InternalContentLength(long value);
            /*0x9d29c4*/ bool get_ThrowOnError();
            /*0x9d29cc*/ void set_ThrowOnError(bool value);
            /*0x9d29d8*/ void set_ContentType(string value);
            /*0x9d2a30*/ System.Net.ICredentials get_Credentials();
            /*0x9d2a38*/ void set_Credentials(System.Net.ICredentials value);
            /*0x9d2a98*/ System.Net.WebHeaderCollection get_Headers();
            /*0x9d2aa0*/ string get_Host();
            /*0x9d2bac*/ bool get_KeepAlive();
            /*0x9d2bb4*/ void set_KeepAlive(bool value);
            /*0x9d2bc0*/ int get_ReadWriteTimeout();
            /*0x9d2bc8*/ string get_Method();
            /*0x9d2bd0*/ void set_Method(string value);
            /*0x9d2dfc*/ System.Version get_ProtocolVersion();
            /*0x9d2e04*/ System.Net.IWebProxy get_Proxy();
            /*0x9d2e0c*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x9d2f64*/ System.Uri get_RequestUri();
            /*0x9d2f6c*/ bool get_SendChunked();
            /*0x9d2f74*/ System.Net.ServicePoint get_ServicePoint();
            /*0x9d2f78*/ System.Net.ServicePoint get_ServicePointNoLock();
            /*0x9d2f80*/ int get_Timeout();
            /*0x9d2f88*/ void set_Timeout(int value);
            /*0x9d2fec*/ string get_TransferEncoding();
            /*0x9d3040*/ bool get_UseDefaultCredentials();
            /*0x9d30b8*/ void set_UserAgent(string value);
            /*0x9d3114*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x9d311c*/ bool get_ExpectContinue();
            /*0x9d3124*/ void set_ExpectContinue(bool value);
            /*0x9d3130*/ System.Uri get_AuthUri();
            /*0x9d3138*/ bool get_ProxyQuery();
            /*0x9d316c*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            /*0x9d2e38*/ System.Net.ServicePoint GetServicePoint();
            /*0x9d37dc*/ System.Net.WebOperation SendRequest(bool redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x9d3d20*/ System.Threading.Tasks.Task<System.IO.Stream> MyGetRequestStreamAsync(System.Threading.CancellationToken cancellationToken);
            /*0x9d4270*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x9d4328*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x9d44d0*/ System.IO.Stream GetRequestStream();
            /*0x9d45d0*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync();
            System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func);
            /*0x9d4668*/ System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken);
            /*0x9d4774*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken);
            /*0x9d444c*/ System.Net.WebException GetWebException(System.Exception e);
            /*0x9d4aec*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x9d4c68*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x9d4d8c*/ System.Net.WebResponse GetResponse();
            /*0x9d4e8c*/ void set_FinishedReading(bool value);
            /*0x9d4094*/ bool get_Aborted();
            /*0x9d4e98*/ void Abort();
            /*0x9d4fe4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9d5024*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9d2720*/ void CheckRequestStarted();
            /*0x9d5064*/ void DoContinueDelegate(int statusCode, System.Net.WebHeaderCollection headers);
            /*0x9d5080*/ void RewriteRedirectToGet();
            /*0x9d50f8*/ bool Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response);
            /*0x9d55d8*/ string GetHeaders();
            /*0x9d5cc0*/ void DoPreAuthenticate();
            /*0x9d5ec0*/ byte[] GetRequestHeaders();
            /*0x9d61d8*/ System.ValueTuple<System.Net.WebOperation, bool> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x9d65ec*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
            /*0x9d6920*/ System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, bool redirect);
            /*0x9d6b18*/ System.ValueTuple<bool, bool, System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response);
            bool <RunWithTimeout>b__242_0<T>();
            /*0x9d7028*/ System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0();

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

                /*0x9d25e8*/ AuthorizationState(System.Net.HttpWebRequest request, bool isProxy);
                /*0x9d714c*/ bool get_IsCompleted();
                /*0x9d7154*/ System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState();
                /*0x9d715c*/ bool get_IsNtlmAuthenticated();
                /*0x9d6604*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
                /*0x9d6fa4*/ void Reset();
                /*0x9d717c*/ string ToString();
            }

            class <>c__24<T>
            {
                static /*0x0*/ System.Net.HttpWebRequest.<>c__241<T> <>9;
                static /*0x0*/ System.Func<System.Threading.Tasks.Task<T>, System.Nullable<int>> <>9__241_0;

                static <>c__24();
                <>c__24();
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

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9d727c*/ void MoveNext();
                /*0x9d83ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9d8404*/ void MoveNext();
                /*0x9d8e60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<GetRewriteHandler>b__271_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.BufferOffsetSize> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.IO.MemoryStream <ms>5__2;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x9d8eb8*/ void MoveNext();
                /*0x9d92d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x9d9328*/ HttpWebResponse();
            /*0x9d9330*/ HttpWebResponse(System.Uri uri, string method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers);
            /*0x9d8b74*/ HttpWebResponse(System.Uri uri, string method, System.Net.WebResponseStream stream, System.Net.CookieContainer container);
            /*0x9d95f8*/ HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9d9994*/ System.Net.WebHeaderCollection get_Headers();
            /*0x9d999c*/ System.Uri get_ResponseUri();
            /*0x9d9a38*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x9d9a40*/ string get_StatusDescription();
            /*0x9d9a58*/ System.IO.Stream GetResponseStream();
            /*0x9d9af4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9d9b00*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x9d9cc0*/ void Close();
            /*0x9d9cf0*/ void System.IDisposable.Dispose();
            /*0x9d9d00*/ void Dispose(bool disposing);
            /*0x9d99b4*/ void CheckDisposed();
            /*0x9d93e4*/ void FillCookies();
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

            static /*0x9dac64*/ string RemoveChunkExtension(string input);
            static /*0x9dac0c*/ void ThrowProtocolViolation(string message);
            /*0x9d9d14*/ MonoChunkParser(System.Net.WebHeaderCollection headers);
            /*0x9d9dcc*/ int Read(byte[] buffer, int offset, int size);
            /*0x9d9dd0*/ int ReadFromChunks(byte[] buffer, int offset, int size);
            /*0x9da148*/ void Write(byte[] buffer, int offset, int size);
            /*0x9da168*/ void InternalWrite(byte[] buffer, ref int offset, int size);
            /*0x9daab0*/ bool get_WantMore();
            /*0x9daad8*/ bool get_DataAvailable();
            /*0x9dabd8*/ int get_ChunkLeft();
            /*0x9da5ac*/ System.Net.MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size);
            /*0x9da2a4*/ System.Net.MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size);
            /*0x9da6e4*/ System.Net.MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size);
            /*0x9da7e4*/ System.Net.MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size);

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

                /*0x9dabe4*/ Chunk(byte[] chunk);
                /*0x9da0e8*/ int Read(byte[] buffer, int offset, int size);
            }
        }

        class MonoChunkStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x48*/ System.Net.MonoChunkParser <Decoder>k__BackingField;

            static /*0x9daf48*/ void ThrowExpectingChunkTrailer();
            /*0x9dacb4*/ MonoChunkStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.WebHeaderCollection headers);
            /*0x9dacac*/ System.Net.MonoChunkParser get_Decoder();
            /*0x9dad44*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x9dae68*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x9dafa4*/ System.Threading.Tasks.Task <>n__0(System.Threading.CancellationToken cancellationToken);

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

                /*0x9db0ac*/ void MoveNext();
                /*0x9db418*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9db470*/ void MoveNext();
                /*0x9db840*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            /*0x10*/ System.Net.IAuthenticationModule authObject;

            /*0x9db84c*/ NtlmClient();
            /*0x9db8b8*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x9db988*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x9db990*/ string get_AuthenticationType();
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

            static /*0x9dbe50*/ void PutBytes(byte[] bytes, uint v, int offset);
            /*0x9db9d0*/ ServicePoint(System.Net.ServicePointManager.SPKey key, System.Uri uri, int connectionLimit, int maxIdleTime);
            /*0x9dbc88*/ System.Net.ServicePointManager.SPKey get_Key();
            /*0x9dbc90*/ System.Net.ServicePointScheduler get_Scheduler();
            /*0x9dbc98*/ void set_Scheduler(System.Net.ServicePointScheduler value);
            /*0x9dbca0*/ System.Uri get_Address();
            /*0x9dbca8*/ int get_ConnectionLimit();
            /*0x9dbcb0*/ System.Version get_ProtocolVersion();
            /*0x9dbcb8*/ void set_Expect100Continue(bool value);
            /*0x9dbcc4*/ bool get_UseNagleAlgorithm();
            /*0x9dbccc*/ void set_UseNagleAlgorithm(bool value);
            /*0x9d5c24*/ bool get_SendContinue();
            /*0x9dbcd8*/ void set_SendContinue(bool value);
            /*0x9dbce4*/ void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval);
            /*0x9dbd9c*/ void KeepAliveSetup(System.Net.Sockets.Socket socket);
            /*0x9dbf94*/ bool get_UsesProxy();
            /*0x9dbf9c*/ void set_UsesProxy(bool value);
            /*0x9dbfa8*/ bool get_UseConnect();
            /*0x9dbfb0*/ void set_UseConnect(bool value);
            /*0x9dbfbc*/ bool get_HasTimedOut();
            /*0x9dc0e8*/ System.Net.IPHostEntry get_HostEntry();
            /*0x9dc470*/ void SetVersion(System.Version version);
            /*0x9d3ba4*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x9dc560*/ void FreeServicePoint();
            /*0x9dc570*/ void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x9dc5a4*/ void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x9dc5d8*/ bool CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote);
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

            static /*0x9dc77c*/ ServicePointManager();
            static /*0x9dc82c*/ System.Net.ICertificatePolicy GetLegacyCertificatePolicy();
            static /*0x9dc884*/ bool get_CheckCertificateRevocationList();
            static /*0x9dc8dc*/ int get_DnsRefreshTimeout();
            static /*0x9dc934*/ System.Net.SecurityProtocolType get_SecurityProtocol();
            static /*0x9dc98c*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            static /*0x9dc9e4*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            static /*0x9dca6c*/ void set_ServerCertificateValidationCallback(System.Net.Security.RemoteCertificateValidationCallback value);
            static /*0x9d3174*/ System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy);
            static /*0x9dcb5c*/ void RemoveServicePoint(System.Net.ServicePoint sp);

            class SPKey
            {
                /*0x10*/ System.Uri uri;
                /*0x18*/ System.Uri proxy;
                /*0x20*/ bool use_connect;

                /*0x9dcb20*/ SPKey(System.Uri uri, System.Uri proxy, bool use_connect);
                /*0x9dcbf4*/ bool get_UsesProxy();
                /*0x9dcc54*/ int GetHashCode();
                /*0x9dcd24*/ bool Equals(object obj);
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

            static /*0x9de560*/ System.Threading.Tasks.Task<bool> WaitAsync(System.Threading.Tasks.Task workerTask, int millisecondTimeout);
            /*0x9dbab0*/ ServicePointScheduler(System.Net.ServicePoint servicePoint, int connectionLimit, int maxIdleTime);
            /*0x9dce18*/ System.Net.ServicePoint get_ServicePoint();
            /*0x9dce20*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x9dce28*/ int get_MaxIdleTime();
            /*0x9dcfe4*/ void Run();
            /*0x9dd2dc*/ System.Threading.Tasks.Task RunScheduler();
            /*0x9dd3ac*/ void Cleanup();
            /*0x9dd5e0*/ void RunSchedulerIteration();
            /*0x9dd910*/ bool OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation);
            /*0x9de074*/ void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection);
            /*0x9dd830*/ bool SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group);
            /*0x9de198*/ void RemoveOperation(System.Net.WebOperation operation);
            /*0x9ddd18*/ void RemoveIdleConnection(System.Net.WebConnection connection);
            /*0x9de264*/ void FinalCleanup();
            /*0x9dc478*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x9de2e4*/ System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name);
            /*0x9de538*/ void OnConnectionCreated(System.Net.WebConnection connection);
            /*0x9de544*/ void OnConnectionClosed(System.Net.WebConnection connection);
            /*0x9de668*/ System.Threading.Tasks.Task <Run>b__31_0();

            class ConnectionGroup
            {
                static /*0x0*/ int nextId;
                /*0x10*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;
                /*0x20*/ int ID;
                /*0x28*/ System.Collections.Generic.LinkedList<System.Net.WebConnection> connections;
                /*0x30*/ System.Collections.Generic.LinkedList<System.Net.WebOperation> queue;

                /*0x9dced8*/ ConnectionGroup(System.Net.ServicePointScheduler scheduler, string name);
                /*0x9de66c*/ System.Net.ServicePointScheduler get_Scheduler();
                /*0x9dd56c*/ bool IsEmpty();
                /*0x9ddc90*/ void RemoveConnection(System.Net.WebConnection connection);
                /*0x9ddde4*/ void Cleanup();
                /*0x9de4e0*/ void EnqueueOperation(System.Net.WebOperation operation);
                /*0x9de0ac*/ System.Net.WebOperation GetNextOperation();
                /*0x9de6ec*/ System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation);
                /*0x9dded4*/ System.ValueTuple<System.Net.WebConnection, bool> CreateOrReuseConnection(System.Net.WebOperation operation, bool force);
            }

            class AsyncManualResetEvent
            {
                /*0x10*/ System.Threading.Tasks.TaskCompletionSource<bool> m_tcs;

                /*0x9dce30*/ AsyncManualResetEvent(bool state);
                /*0x9df048*/ System.Threading.Tasks.Task<bool> WaitAsync(int millisecondTimeout);
                /*0x9dd0ac*/ void Set();
                /*0x9dd76c*/ void Reset();

                class <>c
                {
                    static /*0x0*/ System.Net.ServicePointScheduler.AsyncManualResetEvent.<> <>9;
                    static /*0x8*/ System.Func<object, bool> <>9__4_0;

                    static /*0x9df09c*/ <>c();
                    /*0x9df100*/ <>c();
                    /*0x9df108*/ bool <Set>b__4_0(object s);
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

                /*0x9df1a4*/ void MoveNext();
                /*0x9dfc98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9dfca4*/ void MoveNext();
                /*0x9e00f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource<T>
        {
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion;
            /*0x0*/ System.Net.WebCompletionSource.Result<T> currentResult;

            WebCompletionSource(bool runAsync);
            System.Net.WebCompletionSource.Result<T> get_CurrentResult();
            System.Threading.Tasks.Task get_Task();
            bool TrySetCompleted(T argument);
            bool TrySetCompleted();
            bool TrySetCanceled();
            bool TrySetCanceled(System.OperationCanceledException error);
            bool TrySetException(System.Exception error);
            void ThrowOnError();
            System.Threading.Tasks.Task<T> WaitForCompletion();

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

                Result(T argument);
                Result(System.Net.WebCompletionSource.Status<T> state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                System.Net.WebCompletionSource.Status<T> get_Status();
                bool get_Success();
                System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
                T get_Argument();
            }

            struct <WaitForCompletion>d__15<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ System.Net.WebCompletionSource<T> <>4__this;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebCompletionSource.Result<T>> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource : System.Net.WebCompletionSource<object>
        {
            /*0x9d8064*/ WebCompletionSource();
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

            static /*0x9e0524*/ System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error);
            static /*0x9e06ac*/ bool ReadLine(byte[] buffer, ref int start, int max, ref string output);
            /*0x9df020*/ WebConnection(System.Net.ServicePoint sPoint);
            /*0x9e0148*/ System.Net.ServicePoint get_ServicePoint();
            /*0x9e0150*/ bool CanReuse();
            /*0x9e0180*/ bool CheckReusable();
            /*0x9e021c*/ System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x9e0300*/ System.Threading.Tasks.Task<bool> CreateStream(System.Net.WebOperation operation, bool reused, System.Threading.CancellationToken cancellationToken);
            /*0x9e0420*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x9dea00*/ bool CanReuseConnection(System.Net.WebOperation operation);
            /*0x9e0894*/ bool PrepareSharingNtlm(System.Net.WebOperation operation);
            /*0x9e0bb0*/ void Reset();
            /*0x9e0c74*/ void Close(bool reset);
            /*0x9e0d3c*/ void CloseSocket();
            /*0x9de67c*/ bool get_Closed();
            /*0x9e0fa8*/ System.DateTime get_IdleSince();
            /*0x9dee2c*/ bool StartOperation(System.Net.WebOperation operation, bool reused);
            /*0x9ddb30*/ bool Continue(System.Net.WebOperation next);
            /*0x9e1298*/ void Dispose(bool disposing);
            /*0x9de674*/ void Dispose();
            /*0x9e0c68*/ void ResetNtlm();
            /*0x9e12d0*/ bool get_NtlmAuthenticated();
            /*0x9e12d8*/ void set_NtlmAuthenticated(bool value);
            /*0x9e12e4*/ System.Net.NetworkCredential get_NtlmCredential();
            /*0x9e12ec*/ void set_NtlmCredential(System.Net.NetworkCredential value);
            /*0x9e12f4*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x9e12fc*/ void set_UnsafeAuthenticatedConnectionSharing(bool value);

            class <>c
            {
                static /*0x0*/ System.Net.WebConnection.<> <>9;
                static /*0x8*/ System.Func<System.Net.IPEndPoint, System.AsyncCallback, object, System.IAsyncResult> <>9__16_0;
                static /*0x10*/ System.Action<System.IAsyncResult> <>9__16_1;

                static /*0x9e1308*/ <>c();
                /*0x9e136c*/ <>c();
                /*0x9e1374*/ System.IAsyncResult <Connect>b__16_0(System.Net.IPEndPoint targetEndPoint, System.AsyncCallback callback, object state);
                /*0x9e1414*/ void <Connect>b__16_1(System.IAsyncResult asyncResult);
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

                /*0x9e1508*/ void MoveNext();
                /*0x9e1e0c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9e1e18*/ void MoveNext();
                /*0x9e2590*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9e25e8*/ void MoveNext();
                /*0x9e2b04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x9e2b5c*/ WebConnectionStream(System.Net.WebConnection cnc, System.Net.WebOperation operation);
            /*0x9e2c18*/ System.Net.HttpWebRequest get_Request();
            /*0x9e2c20*/ System.Net.WebConnection get_Connection();
            /*0x9e2c28*/ System.Net.WebOperation get_Operation();
            /*0x9e2c30*/ System.Net.ServicePoint get_ServicePoint();
            /*0x9e2c4c*/ bool get_CanTimeout();
            /*0x9e2c54*/ int get_ReadTimeout();
            /*0x9e2c5c*/ void set_ReadTimeout(int value);
            /*0x9e2cc0*/ int get_WriteTimeout();
            /*0x9e2cc8*/ void set_WriteTimeout(int value);
            /*0x9e2d2c*/ System.Exception GetException(System.Exception e);
            bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x9e2e8c*/ int Read(byte[] buffer, int offset, int count);
            /*0x9e3190*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x9e3360*/ int EndRead(System.IAsyncResult r);
            /*0x9e3484*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x9e3654*/ void EndWrite(System.IAsyncResult r);
            /*0x9e374c*/ void Write(byte[] buffer, int offset, int count);
            /*0x9e3944*/ void Flush();
            /*0x9e3948*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x9d6f98*/ void InternalClose();
            void Close_internal(ref bool disposed);
            /*0x9e3a08*/ void Close();
            /*0x9e3a1c*/ long Seek(long a, System.IO.SeekOrigin b);
            /*0x9e3a6c*/ void SetLength(long a);
            /*0x9e3abc*/ bool get_CanSeek();
            /*0x9e3ac4*/ long get_Length();
            /*0x9e3b14*/ long get_Position();
            /*0x9e3b64*/ void set_Position(long value);
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

            /*0x9e2480*/ WebConnectionTunnel(System.Net.HttpWebRequest request, System.Uri connectUri);
            /*0x9e3bb4*/ System.Net.HttpWebRequest get_Request();
            /*0x9e3bbc*/ System.Uri get_ConnectUri();
            /*0x9e3bc4*/ bool get_Success();
            /*0x9e3bcc*/ void set_Success(bool value);
            /*0x9e3bd8*/ bool get_CloseConnection();
            /*0x9e3be0*/ void set_CloseConnection(bool value);
            /*0x9e3bec*/ int get_StatusCode();
            /*0x9e3bf4*/ void set_StatusCode(int value);
            /*0x9e3bfc*/ void set_StatusDescription(string value);
            /*0x9e3c04*/ string[] get_Challenge();
            /*0x9e3c0c*/ void set_Challenge(string[] value);
            /*0x9e3c14*/ System.Net.WebHeaderCollection get_Headers();
            /*0x9e3c1c*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x9e3c24*/ System.Version get_ProxyVersion();
            /*0x9e3c2c*/ void set_ProxyVersion(System.Version value);
            /*0x9e3c34*/ byte[] get_Data();
            /*0x9e3c3c*/ void set_Data(byte[] value);
            /*0x9e24ac*/ System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x9e3c44*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x9e3d4c*/ void FlushContents(System.IO.Stream stream, int contentLength);

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

                /*0x9e3de0*/ void MoveNext();
                /*0x9e4bb0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9e4bbc*/ void MoveNext();
                /*0x9e5378*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x9d3a10*/ WebOperation(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, bool isNtlmChallenge, System.Threading.CancellationToken cancellationToken);
            /*0x9e53d0*/ System.Net.HttpWebRequest get_Request();
            /*0x9e53d8*/ System.Net.WebConnection get_Connection();
            /*0x9e53e0*/ void set_Connection(System.Net.WebConnection value);
            /*0x9e53e8*/ System.Net.ServicePoint get_ServicePoint();
            /*0x9e53f0*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x9e53f8*/ System.Net.BufferOffsetSize get_WriteBuffer();
            /*0x9e5400*/ bool get_IsNtlmChallenge();
            /*0x9de68c*/ bool get_Aborted();
            /*0x9e5408*/ bool get_Closed();
            /*0x9d4fa4*/ void Abort();
            /*0x9e55f0*/ void Close();
            /*0x9e5524*/ void SetCanceled();
            /*0x9e569c*/ void SetError(System.Exception error);
            /*0x9e5434*/ System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo, bool> SetDisposed(ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x9e5740*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x9e57e4*/ void ThrowIfDisposed();
            /*0x9e1dc8*/ void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x9e3130*/ void ThrowIfClosedOrDisposed();
            /*0x9e2ab8*/ void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x9e578c*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x9e0fb0*/ void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection);
            /*0x9d6460*/ void SetPriorityRequest(System.Net.WebOperation operation);
            /*0x9d4180*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStream();
            /*0x9d80c8*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal();
            /*0x9d80b0*/ System.Net.WebRequestStream get_WriteStream();
            /*0x9d8118*/ System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream();
            /*0x9e5844*/ System.Net.WebCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> get_Finished();
            /*0x9e1204*/ void Run();
            /*0x9e584c*/ void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error);
            /*0x9d8168*/ void Finish(bool ok, System.Exception error);
            /*0x9e58cc*/ void <RegisterRequest>b__48_0();

            struct <GetRequestStream>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                /*0x30*/ System.Net.WebOperation <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;

                /*0x9e58f0*/ void MoveNext();
                /*0x9e5b0c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x9e5b64*/ void MoveNext();
                /*0x9e60f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebReadStream : System.IO.Stream
        {
            /*0x28*/ System.Net.WebOperation <Operation>k__BackingField;
            /*0x30*/ System.IO.Stream <InnerStream>k__BackingField;
            /*0x38*/ bool disposed;

            /*0x9d1d64*/ WebReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream);
            /*0x9e6100*/ System.Net.WebOperation get_Operation();
            /*0x9e6108*/ System.IO.Stream get_InnerStream();
            /*0x9e6110*/ long get_Length();
            /*0x9e6150*/ long get_Position();
            /*0x9e6190*/ void set_Position(long value);
            /*0x9e61d0*/ bool get_CanSeek();
            /*0x9e61d8*/ bool get_CanRead();
            /*0x9e61e0*/ bool get_CanWrite();
            /*0x9e61e8*/ void SetLength(long value);
            /*0x9e6228*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x9e6268*/ void Write(byte[] buffer, int offset, int count);
            /*0x9e62a8*/ void Flush();
            /*0x9e62e8*/ System.Exception GetException(System.Exception e);
            /*0x9e6448*/ int Read(byte[] buffer, int offset, int size);
            /*0x9e66b0*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x9e6880*/ int EndRead(System.IAsyncResult r);
            /*0x9e69a4*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x9dafa8*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x9e6ac4*/ void Dispose(bool disposing);

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

                /*0x1a9dd44*/ void MoveNext();
                /*0x1a9e2cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            static /*0x1a9f2a0*/ WebRequestStream();
            /*0x1a9e324*/ WebRequestStream(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel);
            /*0x1a9e488*/ System.IO.Stream get_InnerStream();
            /*0x1a9e490*/ bool get_KeepAlive();
            /*0x1a9e498*/ bool get_CanRead();
            /*0x1a9e4a0*/ bool get_CanWrite();
            /*0x1a9e4a8*/ bool get_HasWriteBuffer();
            /*0x1a9e4dc*/ int get_WriteBufferLength();
            /*0x1a9e520*/ System.Net.BufferOffsetSize GetWriteBuffer();
            /*0x1a9e5fc*/ System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken);
            /*0x1a9e6d4*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x1a9e934*/ System.Threading.Tasks.Task WriteAsyncInner(byte[] buffer, int offset, int size, System.Net.WebCompletionSource completion, System.Threading.CancellationToken cancellationToken);
            /*0x1a9ea38*/ System.Threading.Tasks.Task ProcessWrite(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x1a9eb38*/ void CheckWriteOverflow(long contentLength, long totalWritten, long size);
            /*0x1a9ebe0*/ System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken);
            /*0x1a9ecbc*/ System.Threading.Tasks.Task SetHeadersAsync(bool setInternalLength, System.Threading.CancellationToken cancellationToken);
            /*0x1a9eda0*/ System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1a9ee7c*/ System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken);
            /*0x1a9ef54*/ System.Threading.Tasks.Task WriteChunkTrailer();
            /*0x1a9ebd8*/ void KillBuffer();
            /*0x1a9f028*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x1a9f0d8*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x1a9f118*/ void Close_internal(ref bool disposed);

            struct <FinishWriting>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x1a9f334*/ void MoveNext();
                /*0x1a9f620*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x1a9f62c*/ void MoveNext();
                /*0x1a9fae0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x1a9faec*/ void MoveNext();
                /*0x1aa0024*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Initialize>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x1aa0030*/ void MoveNext();
                /*0x1aa0340*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SetHeadersAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool setInternalLength;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x1aa034c*/ void MoveNext();
                /*0x1aa09e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x1aa09f4*/ void MoveNext();
                /*0x1aa0eac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer_inner>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x1aa0eb8*/ void MoveNext();
                /*0x1aa10ec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x1aa10f8*/ void MoveNext();
                /*0x1aa17b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x1aa181c*/ WebResponseStream(System.Net.WebRequestStream request);
            /*0x1aa17c0*/ System.Net.WebRequestStream get_RequestStream();
            /*0x1aa17c8*/ System.Net.WebHeaderCollection get_Headers();
            /*0x1aa17d0*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x1aa17d8*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x1aa17e0*/ void set_StatusCode(System.Net.HttpStatusCode value);
            /*0x1aa17e8*/ string get_StatusDescription();
            /*0x1aa17f0*/ void set_StatusDescription(string value);
            /*0x1aa17f8*/ System.Version get_Version();
            /*0x1aa1800*/ void set_Version(System.Version value);
            /*0x1aa1808*/ bool get_KeepAlive();
            /*0x1aa1810*/ void set_KeepAlive(bool value);
            /*0x1aa18a0*/ bool get_CanRead();
            /*0x1aa18a8*/ bool get_CanWrite();
            /*0x1aa18b0*/ bool get_ChunkedRead();
            /*0x1aa18b8*/ void set_ChunkedRead(bool value);
            /*0x1aa18c4*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x1aa19f8*/ System.Threading.Tasks.Task<int> ProcessRead(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x1aa1c80*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x1aa1d4c*/ bool get_ExpectContent();
            /*0x1aa1ddc*/ void Initialize(System.Net.BufferOffsetSize buffer);
            /*0x1aa2308*/ System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(System.Threading.CancellationToken cancellationToken);
            /*0x1aa2408*/ System.Threading.Tasks.Task ReadAllAsync(bool resending, System.Threading.CancellationToken cancellationToken);
            /*0x1aa24fc*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x1aa2598*/ void Close_internal(ref bool disposed);
            /*0x1aa2624*/ System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, string where);
            /*0x1aa28c0*/ System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x1aa299c*/ bool GetResponse(System.Net.BufferOffsetSize buffer, ref int pos, ref System.Net.ReadState state);

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

                /*0x1aa3154*/ void MoveNext();
                /*0x1aa3a38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ System.Net.WebResponseStream <>4__this;
                /*0x18*/ byte[] buffer;
                /*0x20*/ int offset;
                /*0x24*/ int size;

                /*0x1aa1c78*/ <>c__DisplayClass41_0();
                /*0x1aa3a90*/ System.Threading.Tasks.Task<int> <ProcessRead>b__0(System.Threading.CancellationToken ct);
                /*0x1aa3acc*/ void <ProcessRead>b__1();
                /*0x1aa3b0c*/ bool <ProcessRead>b__2();
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

                /*0x1aa3b30*/ void MoveNext();
                /*0x1aa4098*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x1aa40f0*/ void MoveNext();
                /*0x1aa4a4c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x1aa4a58*/ void MoveNext();
                /*0x1aa5114*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace NetworkInformation
        {
            class IPGlobalProperties
            {
                static /*0x1aa5120*/ System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties();
                static /*0x1aa5174*/ System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties();
                /*0x1aa5178*/ IPGlobalProperties();
                string get_DomainName();
            }

            class NetworkInformationException : System.ComponentModel.Win32Exception
            {
                /*0x1aa5180*/ NetworkInformationException();
                /*0x1aa51e4*/ NetworkInformationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x1aa51ec*/ int get_ErrorCode();
            }

            enum NetworkInterfaceComponent
            {
                IPv4 = 0,
                IPv6 = 1,
            }

            class IPGlobalPropertiesFactoryPal
            {
                static /*0x1aa5124*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }

            class CommonUnixIPGlobalProperties : System.Net.NetworkInformation.IPGlobalProperties
            {
                static /*0x1aa52a0*/ int getdomainname(byte[] name, int len);
                /*0x1aa54a8*/ CommonUnixIPGlobalProperties();
                /*0x1aa532c*/ string get_DomainName();
            }

            class UnixIPGlobalProperties : System.Net.NetworkInformation.CommonUnixIPGlobalProperties
            {
                /*0x1aa54b0*/ UnixIPGlobalProperties();
            }

            class UnixNoLibCIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                /*0x1aa5500*/ UnixNoLibCIPGlobalProperties();
                /*0x1aa54b8*/ string get_DomainName();
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

                static /*0x1aa5670*/ MibIPGlobalProperties();
                /*0x1aa5508*/ MibIPGlobalProperties(string procDir);
            }

            class UnixIPGlobalPropertiesFactoryPal
            {
                static /*0x0*/ bool <PlatformNeedsLibCWorkaround>k__BackingField;

                static /*0x1aa5704*/ bool get_PlatformNeedsLibCWorkaround();
                static /*0x1aa51f4*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }
        }

        namespace Configuration
        {
            class DefaultProxySectionInternal
            {
                static /*0x0*/ object classSyncObject;
                /*0x10*/ System.Net.IWebProxy webProxy;

                static /*0x1aa574c*/ System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode();
                static /*0x1aa5754*/ System.Net.IWebProxy GetSystemWebProxy();
                static /*0x1aa575c*/ object get_ClassSyncObject();
                static /*0x1aa57fc*/ System.Net.Configuration.DefaultProxySectionInternal GetSection();
                /*0x1aa5910*/ DefaultProxySectionInternal();
                /*0x1aa5918*/ System.Net.IWebProxy get_WebProxy();
            }

            class SettingsSectionInternal
            {
                static /*0x0*/ System.Net.Configuration.SettingsSectionInternal instance;
                /*0x10*/ bool HttpListenerUnescapeRequestUrl;
                /*0x14*/ System.Net.Sockets.IPProtectionLevel IPProtectionLevel;

                static /*0x1aa5998*/ SettingsSectionInternal();
                static /*0x1aa5920*/ System.Net.Configuration.SettingsSectionInternal get_Section();
                /*0x1aa5980*/ SettingsSectionInternal();
                /*0x1aa5978*/ bool get_Ipv6Enabled();
            }
        }

        namespace Cache
        {
            class RequestCache
            {
                static /*0x0*/ char[] LineSplits;

                static /*0x1aa5a0c*/ RequestCache();
            }

            class RequestCacheValidator
            {
                /*0x1aa5aa0*/ object CreateValidator();
            }

            class RequestCacheBinding
            {
                /*0x10*/ System.Net.Cache.RequestCache m_RequestCache;
                /*0x18*/ System.Net.Cache.RequestCacheValidator m_CacheValidator;

                /*0x1aa5ae0*/ System.Net.Cache.RequestCache get_Cache();
                /*0x1aa5ae8*/ System.Net.Cache.RequestCacheValidator get_Validator();
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

                /*0x1aa5af0*/ RequestCachePolicy(System.Net.Cache.RequestCacheLevel level);
                /*0x1aa5b6c*/ System.Net.Cache.RequestCacheLevel get_Level();
                /*0x1aa5b74*/ string ToString();
            }

            class RequestCacheProtocol
            {
                /*0x1aa5c0c*/ RequestCacheProtocol(object arg1, object arg2);
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

                /*0x1aa5c54*/ NetworkStream(System.Net.Sockets.Socket socket);
                /*0x1aa5e10*/ NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket);
                /*0x1aa5c60*/ NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access, bool ownsSocket);
                /*0x1aa5e1c*/ bool get_CanRead();
                /*0x1aa5e24*/ bool get_CanSeek();
                /*0x1aa5e2c*/ bool get_CanWrite();
                /*0x1aa5e34*/ bool get_CanTimeout();
                /*0x1aa5e3c*/ int get_ReadTimeout();
                /*0x1aa6068*/ void set_ReadTimeout(int value);
                /*0x1aa62bc*/ int get_WriteTimeout();
                /*0x1aa6344*/ void set_WriteTimeout(int value);
                /*0x1aa63cc*/ long get_Length();
                /*0x1aa641c*/ long get_Position();
                /*0x1aa646c*/ void set_Position(long value);
                /*0x1aa64bc*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x1aa650c*/ int Read(byte[] buffer, int offset, int size);
                /*0x1aa6880*/ int Read(System.Span<byte> destination);
                /*0x1aa6be4*/ int ReadByte();
                /*0x1aa6c68*/ void Write(byte[] buffer, int offset, int size);
                /*0x1aa6fdc*/ void Write(System.ReadOnlySpan<byte> source);
                /*0x1aa72dc*/ void WriteByte(byte value);
                /*0x1aa7354*/ void Close(int timeout);
                /*0x1aa73bc*/ void Dispose(bool disposing);
                /*0x1aa74c4*/ void Finalize();
                /*0x1aa7568*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x1aa790c*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x1aa7b90*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x1aa7f34*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x1aa81b8*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x1aa8834*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x1aa8a8c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x1aa90bc*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x1aa9310*/ void Flush();
                /*0x1aa9314*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x1aa939c*/ void SetLength(long value);
                /*0x1aa60f0*/ void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, int timeout, bool silent);
                /*0x1aa953c*/ System.Net.Sockets.Socket get_InternalSocket();
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

                static /*0x1ab125c*/ Socket();
                static /*0x1aa9f4c*/ void CompleteAccept(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                static /*0x1aaa194*/ void CompleteSendReceive(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                static /*0x1aaa0a8*/ System.Exception GetException(System.Net.Sockets.SocketError error, bool wrapExceptionsInIOExceptions);
                static /*0x1aaa9a4*/ bool get_OSSupportsIPv4();
                static /*0x1aaaa08*/ bool get_OSSupportsIPv6();
                static /*0x1aac2ec*/ object get_InternalSyncObject();
                static /*0x1aaa578*/ void InitializeSockets();
                static /*0x1aaa7dc*/ nint Socket_icall(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, ref int error);
                static /*0x1aaca64*/ System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x1aacb94*/ System.Net.SocketAddress LocalEndPoint_icall(nint socket, int family, ref int error);
                static /*0x1aacc70*/ void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool block, ref int error);
                static /*0x1aacd90*/ void Blocking_icall(nint socket, bool block, ref int error);
                static /*0x1aacef4*/ System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x1aad024*/ System.Net.SocketAddress RemoteEndPoint_icall(nint socket, int family, ref int error);
                static /*0x1aad1c8*/ bool Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x1aad308*/ bool Poll_icall(nint socket, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x1aad440*/ System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, ref int error, bool blocking);
                static /*0x1aadbd4*/ nint Accept_icall(nint sock, ref int error, bool blocking);
                static /*0x1aade14*/ void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error);
                static /*0x1aadf34*/ void Bind_icall(nint sock, System.Net.SocketAddress sa, ref int error);
                static /*0x1aae030*/ void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int backlog, ref int error);
                static /*0x1aae150*/ void Listen_icall(nint sock, int backlog, ref int error);
                static /*0x1aaeed4*/ bool BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x1aaea78*/ bool BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x1aae530*/ void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x1aaf18c*/ void Connect_icall(nint sock, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x1aaf28c*/ void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool reuse, ref int error);
                static /*0x1aaf45c*/ void Disconnect_icall(nint sock, bool reuse, ref int error);
                static /*0x1aaf944*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1aafd08*/ int Receive_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1aaf5f0*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1aafd10*/ int Receive_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1aaffa0*/ int ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x1ab01c4*/ int ReceiveFrom_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x1ab0734*/ void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, int sent_so_far);
                static /*0x1ab0310*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1ab0ad0*/ int Send_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1ab01cc*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1ab0ad8*/ int Send_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1ab0b98*/ void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x1ab0cd0*/ void GetSocketOption_obj_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x1aac650*/ void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x1ab0cdc*/ void SetSocketOption_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x1ab0ce0*/ int IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x1ab0e28*/ int IOControl_icall(nint sock, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x1ab0e34*/ void Close_icall(nint socket, ref int error);
                static /*0x1aac530*/ void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x1ab0f50*/ void Shutdown_icall(nint socket, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x1ab11cc*/ void cancel_blocking_socket_operation(System.Threading.Thread thread);
                static /*0x1ab11d0*/ int get_FamilyHint();
                static /*0x1ab1258*/ bool IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                static /*0x1aac3d0*/ bool IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                /*0x1aaa324*/ Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x1aac7a0*/ Socket(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle);
                /*0x1aa8578*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, bool fromNetworkStream, System.Threading.CancellationToken cancellationToken);
                /*0x1aa96f8*/ System.Threading.Tasks.Task<int> ReceiveAsyncApm(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x1aa8e00*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken);
                /*0x1aa9b2c*/ System.Threading.Tasks.Task<int> SendAsyncApm(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x1aaa2d8*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                /*0x1aaa068*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                /*0x1aaaa6c*/ nint get_Handle();
                /*0x1aaaa88*/ System.Net.Sockets.AddressFamily get_AddressFamily();
                /*0x1aaaa90*/ System.Net.Sockets.SocketType get_SocketType();
                /*0x1aaaa98*/ System.Net.Sockets.ProtocolType get_ProtocolType();
                /*0x1aaaaa0*/ void set_ExclusiveAddressUse(bool value);
                /*0x1aaac4c*/ void set_DontFragment(bool value);
                /*0x1aaacd0*/ bool get_DualMode();
                /*0x1aaadb8*/ void set_DualMode(bool value);
                /*0x1aaae40*/ bool get_IsDualMode();
                /*0x1aaae58*/ bool CanTryAddressFamily(System.Net.Sockets.AddressFamily family);
                /*0x1aaae90*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x1aa6f74*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x1aa6818*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x1aab67c*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x1aabbcc*/ int IOControl(System.Net.Sockets.IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x1aaa7e0*/ void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level);
                /*0x1aa7eb4*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x1aa8150*/ int EndSend(System.IAsyncResult asyncResult);
                /*0x1aa788c*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x1aa7b28*/ int EndReceive(System.IAsyncResult asyncResult);
                /*0x1aac3c0*/ bool get_CleanedUp();
                /*0x1aac424*/ void Dispose();
                /*0x1aac490*/ void Finalize();
                /*0x1aa7434*/ void InternalShutdown(System.Net.Sockets.SocketShutdown how);
                /*0x1aa93ec*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue, bool silent);
                /*0x1aaa8d0*/ void SocketDefaults();
                /*0x1aac8dc*/ bool get_IsBound();
                /*0x1aac8e4*/ System.Net.EndPoint get_LocalEndPoint();
                /*0x1aacb98*/ bool get_Blocking();
                /*0x1aacba0*/ void set_Blocking(bool value);
                /*0x1aacd98*/ bool get_Connected();
                /*0x1aac89c*/ void set_NoDelay(bool value);
                /*0x1aacdf8*/ System.Net.EndPoint get_RemoteEndPoint();
                /*0x1aad028*/ bool Poll(int microSeconds, System.Net.Sockets.SelectMode mode);
                /*0x1aad30c*/ System.Net.Sockets.Socket Accept();
                /*0x1aad5a0*/ void Accept(System.Net.Sockets.Socket acceptSocket);
                /*0x1aad6bc*/ System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state);
                /*0x1aad96c*/ System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult);
                /*0x1aad994*/ System.Net.Sockets.Socket EndAccept(ref byte[] buffer, ref int bytesTransferred, System.IAsyncResult asyncResult);
                /*0x1aadbdc*/ void Bind(System.Net.EndPoint localEP);
                /*0x1aadf38*/ void Listen(int backlog);
                /*0x1aae154*/ void Connect(System.Net.IPAddress address, int port);
                /*0x1aae1d0*/ void Connect(System.Net.EndPoint remoteEP);
                /*0x1aae654*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback callback, object state);
                /*0x1aae934*/ System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x1aaf0dc*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x1aaf194*/ void Disconnect(bool reuseSocket);
                /*0x1aaf3ac*/ void EndDisconnect(System.IAsyncResult asyncResult);
                /*0x1aab570*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x1aaf734*/ int Receive(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x1aab6e4*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x1aa6af4*/ int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x1aa7250*/ int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x1aafa88*/ bool ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x1aac06c*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x1aac1fc*/ int EndReceive(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x1aafd18*/ int ReceiveFrom(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.SocketError errorCode);
                /*0x1ab00f4*/ int EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult sockares, System.Net.Sockets.SocketAsyncEventArgs ares);
                /*0x1aab42c*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x1aaaef8*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x1ab0454*/ bool SendAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x1aabd60*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x1aabf7c*/ int EndSend(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x1ab0ae0*/ int EndSendTo(System.IAsyncResult asyncResult);
                /*0x1aa5ec4*/ object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName);
                /*0x1ab0cd4*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, bool optionValue);
                /*0x1aaab20*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue);
                /*0x1aabbd0*/ int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x1ab0e2c*/ void Close();
                /*0x1aa74bc*/ void Close(int timeout);
                /*0x1ab0e38*/ void Shutdown(System.Net.Sockets.SocketShutdown how);
                /*0x1ab0f54*/ void Dispose(bool disposing);
                /*0x1ab0fb4*/ void Linger(nint handle);
                /*0x1aac9d8*/ void ThrowIfDisposedAndClosed();
                /*0x1aaf464*/ void ThrowIfBufferNull(byte[] buffer);
                /*0x1aaf4bc*/ void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size);
                /*0x1aacda0*/ void ThrowIfUdp();
                /*0x1aada88*/ System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, string methodName, string argName);
                /*0x1aad82c*/ void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, nint handle, System.IOSelectorJob job);
                /*0x1aafc8c*/ void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs e, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x1ab1120*/ System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation op);
                /*0x1aadd58*/ System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input);

                class CachedEventArgs
                {
                    /*0x10*/ System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> TaskAccept;
                    /*0x18*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskReceive;
                    /*0x20*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskSend;
                    /*0x28*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;
                    /*0x30*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;

                    /*0x1ab197c*/ CachedEventArgs();
                }

                class TaskSocketAsyncEventArgs<TResult> : System.Net.Sockets.SocketAsyncEventArgs
                {
                    /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder;
                    /*0x0*/ bool _accessed;

                    TaskSocketAsyncEventArgs();
                    System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(ref bool responsibleForReturningToPool);
                }

                class Int32TaskSocketAsyncEventArgs : System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<int>
                {
                    /*0x99*/ bool _wrapExceptionsInIOExceptions;

                    /*0x1ab1934*/ Int32TaskSocketAsyncEventArgs();
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

                    static /*0x1ab2434*/ AwaitableSocketAsyncEventArgs();
                    /*0x1ab1984*/ AwaitableSocketAsyncEventArgs();
                    /*0x1ab19f0*/ bool get_WrapExceptionsInIOExceptions();
                    /*0x1ab19f8*/ void set_WrapExceptionsInIOExceptions(bool value);
                    /*0x1aa95d8*/ bool Reserve();
                    /*0x1ab1a04*/ void Release();
                    /*0x1ab1a74*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _);
                    /*0x1aa9658*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Net.Sockets.Socket socket);
                    /*0x1aa9ac0*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket socket);
                    /*0x1ab2044*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
                    /*0x1ab2128*/ void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x1ab1c74*/ void InvokeContinuation(System.Action<object> continuation, object state, bool forceAsync);
                    /*0x1ab2388*/ int GetResult(short token);
                    /*0x1ab23f4*/ void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token);
                    /*0x1ab20d8*/ void ThrowIncorrectTokenException();
                    /*0x1ab2338*/ void ThrowMultipleContinuationsException();
                    /*0x1ab23d0*/ void ThrowException(System.Net.Sockets.SocketError error);
                    /*0x1ab1f54*/ System.Exception CreateException(System.Net.Sockets.SocketError error);

                    class <>c
                    {
                        static /*0x0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs.<> <>9;
                        static /*0x8*/ System.Threading.ContextCallback <>9__14_0;
                        static /*0x10*/ System.Threading.SendOrPostCallback <>9__20_0;

                        static /*0x1ab2570*/ <>c();
                        /*0x1ab25d4*/ <>c();
                        /*0x1ab25dc*/ void <OnCompleted>b__14_0(object runState);
                        /*0x1ab268c*/ void <InvokeContinuation>b__20_0(object s);
                        /*0x1ab2738*/ void <.cctor>b__27_0(object state);
                        /*0x1ab2788*/ void <.cctor>b__27_1(object state);
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

                    static /*0x1ab27d8*/ <>c();
                    /*0x1ab283c*/ <>c();
                    /*0x1ab2844*/ System.Net.Sockets.Socket.CachedEventArgs <ReceiveAsync>b__14_0();
                    /*0x1ab28a0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1();
                    /*0x1ab28f8*/ void <ReceiveAsyncApm>b__15_0(System.IAsyncResult iar);
                    /*0x1ab2b2c*/ void <ReceiveAsyncApm>b__15_1(System.IAsyncResult iar);
                    /*0x1ab2f5c*/ System.Net.Sockets.Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0();
                    /*0x1ab2fb8*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1();
                    /*0x1ab3010*/ void <SendAsyncApm>b__23_0(System.IAsyncResult iar);
                    /*0x1ab3244*/ void <SendAsyncApm>b__23_1(System.IAsyncResult iar);
                    /*0x1ab3544*/ void <SendAsync>b__295_0(System.IOAsyncResult s);
                    /*0x1ab35d4*/ void <BeginSend>b__297_0(System.IOAsyncResult s);
                    /*0x1ab3664*/ void <.cctor>b__367_0(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x1ab3758*/ void <.cctor>b__367_1(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x1ab3834*/ void <.cctor>b__367_2(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x1ab3910*/ void <.cctor>b__367_3(System.IAsyncResult ares);
                    /*0x1ab3bac*/ void <.cctor>b__367_4(System.IOAsyncResult ares);
                    /*0x1ab3ce4*/ void <.cctor>b__367_5(System.IOAsyncResult ares);
                    /*0x1ab3f28*/ void <.cctor>b__367_6(System.IAsyncResult ares);
                    /*0x1ab41a4*/ void <.cctor>b__367_7(System.IOAsyncResult ares);
                    /*0x1ab4448*/ void <.cctor>b__367_8(System.IAsyncResult ares);
                    /*0x1ab46c4*/ void <.cctor>b__367_9(System.IOAsyncResult ares);
                    /*0x1ab47d4*/ void <.cctor>b__367_10(System.IAsyncResult ares);
                    /*0x1ab4a64*/ void <.cctor>b__367_11(System.IOAsyncResult ares);
                    /*0x1ab4d18*/ void <.cctor>b__367_12(System.IOAsyncResult ares);
                    /*0x1ab4e34*/ void <.cctor>b__367_13(System.IAsyncResult ares);
                    /*0x1ab50ec*/ void <.cctor>b__367_14(System.IOAsyncResult ares);
                    /*0x1ab5278*/ void <.cctor>b__367_15(System.IAsyncResult ares);
                    /*0x1ab5508*/ void <.cctor>b__367_16(System.IOAsyncResult ares);
                    /*0x1ab5624*/ void <.cctor>b__367_17(System.IAsyncResult ares);
                }

                class <>c__DisplayClass240_0
                {
                    /*0x10*/ System.Net.Sockets.SocketAsyncResult sockares;

                    /*0x1a1941c*/ <>c__DisplayClass240_0();
                    /*0x1a19424*/ void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t);
                }

                class <>c__DisplayClass298_0
                {
                    /*0x10*/ int sent_so_far;

                    /*0x1a1954c*/ <>c__DisplayClass298_0();
                    /*0x1a19554*/ void <BeginSendCallback>b__0(System.IOAsyncResult s);
                }

                class <>c__DisplayClass355_0
                {
                    /*0x10*/ System.Net.Sockets.Socket <>4__this;
                    /*0x18*/ System.IOSelectorJob job;
                    /*0x20*/ nint handle;

                    /*0x1a195f8*/ <>c__DisplayClass355_0();
                    /*0x1a19600*/ void <QueueIOSelectorJob>b__0(System.Threading.Tasks.Task t);
                }
            }

            class SocketException : System.ComponentModel.Win32Exception
            {
                /*0x90*/ System.Net.EndPoint m_EndPoint;

                static /*0x1a19644*/ int WSAGetLastError_icall();
                /*0x1a19648*/ SocketException();
                /*0x1a19668*/ SocketException(int error, string message);
                /*0x1a19670*/ SocketException(int errorCode);
                /*0x1a19678*/ SocketException(System.Net.Sockets.SocketError socketError);
                /*0x1a19680*/ SocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x1a19688*/ int get_ErrorCode();
                /*0x1a19690*/ string get_Message();
                /*0x1a19720*/ System.Net.Sockets.SocketError get_SocketErrorCode();
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

                /*0x1a19728*/ LingerOption(bool enable, int seconds);
                /*0x1a1975c*/ void set_Enabled(bool value);
                /*0x1a19768*/ void set_LingerTime(int value);
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

                /*0x1a19770*/ TcpClient();
                /*0x1a19790*/ TcpClient(System.Net.Sockets.AddressFamily family);
                /*0x1a19914*/ TcpClient(string hostname, int port);
                /*0x1a1a230*/ TcpClient(System.Net.Sockets.Socket acceptedSocket);
                /*0x1a1a274*/ System.Net.Sockets.Socket get_Client();
                /*0x1a1a27c*/ void set_Client(System.Net.Sockets.Socket value);
                /*0x1a19b60*/ void Connect(string hostname, int port);
                /*0x1a1a284*/ void Connect(System.Net.IPEndPoint remoteEP);
                /*0x1a1a390*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state);
                /*0x1a1a3fc*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x1a1a444*/ System.Threading.Tasks.Task ConnectAsync(string host, int port);
                /*0x1a1a5b0*/ System.Net.Sockets.NetworkStream GetStream();
                /*0x1a1a6fc*/ void Close();
                /*0x1a1a7a0*/ void Dispose(bool disposing);
                /*0x1a1a934*/ void Dispose();
                /*0x1a1a944*/ void Finalize();
                /*0x1a198a0*/ void initialize();
            }

            class TcpListener
            {
                /*0x10*/ System.Net.IPEndPoint m_ServerSocketEP;
                /*0x18*/ System.Net.Sockets.Socket m_ServerSocket;
                /*0x20*/ bool m_Active;
                /*0x21*/ bool m_ExclusiveAddressUse;

                /*0x1a1a9e4*/ TcpListener(System.Net.IPAddress localaddr, int port);
                /*0x1a1ab84*/ System.Net.Sockets.Socket get_Server();
                /*0x1a1ab8c*/ void Start();
                /*0x1a1ab94*/ void Start(int backlog);
                /*0x1a1ad20*/ void Stop();
                /*0x1a1ade4*/ System.Net.Sockets.TcpClient AcceptTcpClient();
            }

            class SafeSocketHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x0*/ bool THROW_ON_ABORT_RETRIES;
                /*0x20*/ System.Collections.Generic.List<System.Threading.Thread> blocking_threads;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> threads_stacktraces;
                /*0x30*/ bool in_cleanup;

                static /*0x1a1b89c*/ SafeSocketHandle();
                /*0x1a1aecc*/ SafeSocketHandle(nint preexistingHandle, bool ownsHandle);
                /*0x1a1af98*/ bool ReleaseHandle();
                /*0x1a1b564*/ void RegisterForBlockingSyscall();
                /*0x1a1b6ac*/ void UnRegisterForBlockingSyscall();
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

                /*0x1a1b988*/ SocketAsyncEventArgs(bool flowExecutionContext);
                /*0x1a1b930*/ System.Net.Sockets.Socket get_AcceptSocket();
                /*0x1a1b938*/ void set_AcceptSocket(System.Net.Sockets.Socket value);
                /*0x1a1b940*/ int get_BytesTransferred();
                /*0x1a1b948*/ void set_BytesTransferred(int value);
                /*0x1a1b950*/ void set_LastOperation(System.Net.Sockets.SocketAsyncOperation value);
                /*0x1a1b958*/ void set_RemoteEndPoint(System.Net.EndPoint value);
                /*0x1a1b960*/ System.Net.Sockets.SocketError get_SocketError();
                /*0x1a1b968*/ void set_SocketError(System.Net.Sockets.SocketError value);
                /*0x1a1b970*/ void set_SocketFlags(System.Net.Sockets.SocketFlags value);
                /*0x1a1b978*/ object get_UserToken();
                /*0x1a1b980*/ void set_UserToken(object value);
                /*0x1a1ba1c*/ void Finalize();
                /*0x1a1ba2c*/ void Dispose(bool disposing);
                /*0x1a1ba40*/ void Dispose();
                /*0x1a1baa4*/ void SetBytesTransferred(int value);
                /*0x1a1baac*/ System.Net.Sockets.Socket get_CurrentSocket();
                /*0x1a1bab4*/ void SetCurrentSocket(System.Net.Sockets.Socket socket);
                /*0x1a1babc*/ void SetLastOperation(System.Net.Sockets.SocketAsyncOperation op);
                /*0x1a1bb84*/ void Complete_internal();
                /*0x1a1bbac*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x1a1bbd4*/ System.Memory<byte> get_MemoryBuffer();
                /*0x1a1bbe0*/ int get_Offset();
                /*0x1a1bbe8*/ int get_Count();
                /*0x1a1bbf0*/ System.Collections.Generic.IList<System.ArraySegment<byte>> get_BufferList();
                /*0x1a1bbf8*/ void SetBuffer(System.Memory<byte> buffer);
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

                /*0x1a1ba14*/ SocketAsyncResult();
                /*0x1a1be04*/ SocketAsyncResult(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x1a1bcec*/ nint get_Handle();
                /*0x1a1bd50*/ void Init(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x1a1be3c*/ System.Net.Sockets.SocketError get_ErrorCode();
                /*0x1a1bebc*/ void CheckIfThrowDelayedException();
                /*0x1a1bf64*/ void CompleteDisposed();
                /*0x1a1bf68*/ void Complete();
                /*0x1a1c158*/ void Complete(bool synch);
                /*0x1a1c164*/ void Complete(int total);
                /*0x1a1c16c*/ void Complete(System.Exception e, bool synch);
                /*0x1a19544*/ void Complete(System.Exception e);
                /*0x1a1c17c*/ void Complete(System.Net.Sockets.Socket s);
                /*0x1a1c184*/ void Complete(System.Net.Sockets.Socket s, int total);

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.SocketAsyncResult.<> <>9;
                    static /*0x8*/ System.Threading.WaitCallback <>9__27_0;

                    static /*0x1a1c190*/ <>c();
                    /*0x1a1c1f4*/ <>c();
                    /*0x1a1c1fc*/ void <Complete>b__27_0(object state);
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
            class SslClientAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.EncryptionPolicy _encryptionPolicy;
                /*0x14*/ System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;
                /*0x18*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
                /*0x1c*/ bool _allowRenegotiation;
                /*0x20*/ string <TargetHost>k__BackingField;
                /*0x28*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;

                /*0x1a1c3e4*/ SslClientAuthenticationOptions();
                /*0x1a1c274*/ string get_TargetHost();
                /*0x1a1c27c*/ void set_TargetHost(string value);
                /*0x1a1c284*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x1a1c28c*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x1a1c294*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x1a1c334*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x1a1c3d4*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x1a1c3dc*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
            }

            class SslServerAuthenticationOptions
            {
                /*0x10*/ System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;
                /*0x14*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
                /*0x18*/ System.Net.Security.EncryptionPolicy _encryptionPolicy;
                /*0x1c*/ bool _allowRenegotiation;
                /*0x1d*/ bool <ClientCertificateRequired>k__BackingField;
                /*0x20*/ System.Security.Cryptography.X509Certificates.X509Certificate <ServerCertificate>k__BackingField;

                /*0x1a1c568*/ SslServerAuthenticationOptions();
                /*0x1a1c3f4*/ bool get_ClientCertificateRequired();
                /*0x1a1c3fc*/ void set_ClientCertificateRequired(bool value);
                /*0x1a1c408*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                /*0x1a1c410*/ void set_ServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                /*0x1a1c418*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x1a1c420*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x1a1c428*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x1a1c4c8*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
            }

            class AuthenticatedStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _InnerStream;
                /*0x30*/ bool _LeaveStreamOpen;

                /*0x1a1c578*/ AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen);
                /*0x1a1c710*/ System.IO.Stream get_InnerStream();
                /*0x1a1c718*/ void Dispose(bool disposing);
                bool get_IsAuthenticated();
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
                /*0x1a1c800*/ LocalCertificateSelectionCallback(object object, nint method);
                /*0x1a1c930*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class RemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x1a1c944*/ RemoteCertificateValidationCallback(object object, nint method);
                /*0x1a1ca74*/ bool Invoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
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
                /*0x1a1ca88*/ LocalCertSelectionCallback(object object, nint method);
                /*0x1a1cb60*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class ServerCertSelectionCallback : System.MulticastDelegate
            {
                /*0x1a1cb74*/ ServerCertSelectionCallback(object object, nint method);
                /*0x1a1cc48*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string hostName);
            }

            class SslStream : System.Net.Security.AuthenticatedStream
            {
                /*0x38*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x40*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x48*/ System.Net.Security.RemoteCertificateValidationCallback validationCallback;
                /*0x50*/ System.Net.Security.LocalCertificateSelectionCallback selectionCallback;
                /*0x58*/ Mono.Net.Security.MobileAuthenticatedStream impl;
                /*0x60*/ bool explicitSettings;

                static /*0x1a1ccf8*/ Mono.Net.Security.MobileTlsProvider GetProvider();
                /*0x1a1cd68*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback);
                /*0x1a1cd74*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback);
                /*0x1a1d05c*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                /*0x1a1cc5c*/ Mono.Net.Security.MobileAuthenticatedStream get_Impl();
                /*0x1a1ccd4*/ string get_InternalTargetHost();
                /*0x1a1ce04*/ void SetAndVerifyValidationCallback(System.Net.Security.RemoteCertificateValidationCallback callback);
                /*0x1a1cee4*/ void SetAndVerifySelectionCallback(System.Net.Security.LocalCertificateSelectionCallback callback);
                /*0x1a1d188*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x1a1d1dc*/ System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState);
                /*0x1a1d250*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
                /*0x1a1d25c*/ void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x1a1d2b0*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x1a1d304*/ bool get_IsAuthenticated();
                /*0x1a1d330*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x1a1d354*/ bool get_CanSeek();
                /*0x1a1d35c*/ bool get_CanRead();
                /*0x1a1d374*/ bool get_CanTimeout();
                /*0x1a1d394*/ bool get_CanWrite();
                /*0x1a1d3ac*/ int get_ReadTimeout();
                /*0x1a1d3d8*/ void set_ReadTimeout(int value);
                /*0x1a1d414*/ int get_WriteTimeout();
                /*0x1a1d440*/ void set_WriteTimeout(int value);
                /*0x1a1d47c*/ long get_Length();
                /*0x1a1d4a4*/ long get_Position();
                /*0x1a1d4cc*/ void set_Position(long value);
                /*0x1a1d52c*/ void SetLength(long value);
                /*0x1a1d568*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x1a1d5c8*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x1a1d5ec*/ void Flush();
                /*0x1a1cc74*/ void CheckDisposed();
                /*0x1a1d610*/ void Dispose(bool disposing);
                /*0x1a1d6bc*/ int Read(byte[] buffer, int offset, int count);
                /*0x1a1d710*/ void Write(byte[] buffer, int offset, int count);
                /*0x1a1d764*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x1a1d7c0*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x1a1d81c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x1a1d888*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x1a1d8d0*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x1a1d93c*/ void EndWrite(System.IAsyncResult asyncResult);

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ System.Net.Security.LocalCertificateSelectionCallback callback;
                    /*0x18*/ System.Net.Security.SslStream <>4__this;

                    /*0x1a1d180*/ <>c__DisplayClass21_0();
                    /*0x1a1d948*/ System.Security.Cryptography.X509Certificates.X509Certificate <SetAndVerifySelectionCallback>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
                }
            }
        }
    }

    namespace ComponentModel
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object _value;

            /*0x1a1d980*/ DefaultValueAttribute(int value);
            /*0x1a1d9ec*/ DefaultValueAttribute(long value);
            /*0x1a1da58*/ DefaultValueAttribute(bool value);
            /*0x1a1dac4*/ DefaultValueAttribute(string value);
            /*0x1a1daec*/ DefaultValueAttribute(object value);
            /*0x1a1db14*/ object get_Value();
            /*0x1a1db1c*/ bool Equals(object obj);
            /*0x1a1dc28*/ int GetHashCode();
        }

        class EditorBrowsableAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.EditorBrowsableState browsableState;

            /*0x1a1dc30*/ EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state);
            /*0x1a1dc58*/ bool Equals(object obj);
            /*0x1a1dce4*/ int GetHashCode();
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

            static /*0x1a1de88*/ BrowsableAttribute();
            /*0x1a1dcec*/ BrowsableAttribute(bool browsable);
            /*0x1a1dd14*/ bool get_Browsable();
            /*0x1a1dd1c*/ bool Equals(object obj);
            /*0x1a1de00*/ int GetHashCode();
            /*0x1a1de20*/ bool IsDefaultAttribute();
        }

        class ComponentCollection : System.Collections.ReadOnlyCollectionBase
        {
            /*0x1a1df20*/ System.ComponentModel.IComponent get_Item(string name);
        }

        class DescriptionAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DescriptionAttribute Default;
            /*0x10*/ string <DescriptionValue>k__BackingField;

            static /*0x1a1e6a0*/ DescriptionAttribute();
            /*0x1a1e4a8*/ DescriptionAttribute();
            /*0x1a1e504*/ DescriptionAttribute(string description);
            /*0x1a1e52c*/ string get_Description();
            /*0x1a1e534*/ string get_DescriptionValue();
            /*0x1a1e53c*/ void set_DescriptionValue(string value);
            /*0x1a1e544*/ bool Equals(object obj);
            /*0x1a1e610*/ int GetHashCode();
            /*0x1a1e638*/ bool IsDefaultAttribute();
        }

        class DesignOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.DesignOnlyAttribute Default;
            /*0x10*/ bool <IsDesignOnly>k__BackingField;

            static /*0x1a1e8b4*/ DesignOnlyAttribute();
            /*0x1a1e700*/ DesignOnlyAttribute(bool isDesignOnly);
            /*0x1a1e728*/ bool get_IsDesignOnly();
            /*0x1a1e730*/ bool Equals(object obj);
            /*0x1a1e814*/ int GetHashCode();
            /*0x1a1e834*/ bool IsDefaultAttribute();
        }

        class DesignerCategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerCategoryAttribute Component;
            static /*0x8*/ System.ComponentModel.DesignerCategoryAttribute Default;
            static /*0x10*/ System.ComponentModel.DesignerCategoryAttribute Form;
            static /*0x18*/ System.ComponentModel.DesignerCategoryAttribute Generic;
            /*0x10*/ string <Category>k__BackingField;

            static /*0x1a1eb34*/ DesignerCategoryAttribute();
            /*0x1a1e948*/ DesignerCategoryAttribute();
            /*0x1a1e9a4*/ DesignerCategoryAttribute(string category);
            /*0x1a1e9cc*/ string get_Category();
            /*0x1a1e9d4*/ bool Equals(object obj);
            /*0x1a1ea64*/ int GetHashCode();
            /*0x1a1ea84*/ bool IsDefaultAttribute();
            /*0x1a1eafc*/ object get_TypeId();
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

            static /*0x1a1edc4*/ DesignerSerializationVisibilityAttribute();
            /*0x1a1ec4c*/ DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility);
            /*0x1a1ec74*/ System.ComponentModel.DesignerSerializationVisibility get_Visibility();
            /*0x1a1ec7c*/ bool Equals(object obj);
            /*0x1a1ed54*/ int GetHashCode();
            /*0x1a1ed5c*/ bool IsDefaultAttribute();
        }

        class DisplayNameAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DisplayNameAttribute Default;
            /*0x10*/ string <DisplayNameValue>k__BackingField;

            static /*0x1a1f078*/ DisplayNameAttribute();
            /*0x1a1ee80*/ DisplayNameAttribute();
            /*0x1a1eedc*/ DisplayNameAttribute(string displayName);
            /*0x1a1ef04*/ string get_DisplayName();
            /*0x1a1ef0c*/ string get_DisplayNameValue();
            /*0x1a1ef14*/ void set_DisplayNameValue(string value);
            /*0x1a1ef1c*/ bool Equals(object obj);
            /*0x1a1efe8*/ int GetHashCode();
            /*0x1a1f010*/ bool IsDefaultAttribute();
        }

        class EventHandlerList
        {
            /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _head;
            /*0x18*/ System.ComponentModel.Component _parent;

            /*0x1a1f0d8*/ System.Delegate get_Item(object key);
            /*0x1a1f138*/ System.ComponentModel.EventHandlerList.ListEntry Find(object key);

            class ListEntry
            {
                /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _next;
                /*0x18*/ object _key;
                /*0x20*/ System.Delegate _handler;
            }
        }

        interface IContainer : System.IDisposable
        {
            System.ComponentModel.ComponentCollection get_Components();
            void Remove(System.ComponentModel.IComponent component);
        }

        interface ISite : System.IServiceProvider
        {
            System.ComponentModel.IContainer get_Container();
            bool get_DesignMode();
            string get_Name();
        }

        interface ISynchronizeInvoke
        {
            bool get_InvokeRequired();
            System.IAsyncResult BeginInvoke(System.Delegate method, object[] args);
        }

        class InvalidEnumArgumentException : System.ArgumentException
        {
            /*0x1a1f150*/ InvalidEnumArgumentException();
            /*0x1a1f15c*/ InvalidEnumArgumentException(string message);
            /*0x1a1f164*/ InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class ReadOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ReadOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.ReadOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.ReadOnlyAttribute Default;
            /*0x10*/ bool <IsReadOnly>k__BackingField;

            static /*0x1a1f308*/ ReadOnlyAttribute();
            /*0x1a1f16c*/ ReadOnlyAttribute(bool isReadOnly);
            /*0x1a1f194*/ bool get_IsReadOnly();
            /*0x1a1f19c*/ bool Equals(object value);
            /*0x1a1f280*/ int GetHashCode();
            /*0x1a1f288*/ bool IsDefaultAttribute();
        }

        class AddingNewEventArgs : System.EventArgs
        {
            /*0x10*/ object <NewObject>k__BackingField;

            /*0x1a1f39c*/ AddingNewEventArgs();
            /*0x1a1f3f4*/ object get_NewObject();
        }

        class AddingNewEventHandler : System.MulticastDelegate
        {
            /*0x1a1f3fc*/ AddingNewEventHandler(object object, nint method);
            /*0x1a1f52c*/ void Invoke(object sender, System.ComponentModel.AddingNewEventArgs e);
        }

        class AmbientValueAttribute : System.Attribute
        {
            /*0x10*/ object <Value>k__BackingField;

            /*0x1a1f540*/ object get_Value();
        }

        class ArrayConverter : System.ComponentModel.CollectionConverter
        {
            /*0x1a1fa98*/ ArrayConverter();
            /*0x1a1f548*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a1f714*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1a1fa90*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class ArrayPropertyDescriptor : System.ComponentModel.TypeConverter.SimplePropertyDescriptor
            {
                /*0x98*/ int _index;

                /*0x1a1f8e8*/ ArrayPropertyDescriptor(System.Type arrayType, System.Type elementType, int index);
                /*0x1a1faa0*/ object GetValue(object instance);
                /*0x1a1fb54*/ void SetValue(object instance, object value);
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

            static /*0x1a208f4*/ AttributeCollection();
            /*0x1a1fc54*/ AttributeCollection(System.Attribute[] attributes);
            /*0x1a1fd78*/ System.Attribute[] get_Attributes();
            /*0x1a1fd80*/ int get_Count();
            /*0x1a1fda4*/ System.Attribute get_Item(System.Type attributeType);
            /*0x1a207cc*/ bool Contains(System.Attribute attribute);
            /*0x1a2027c*/ System.Attribute GetDefaultAttribute(System.Type attributeType);
            /*0x1a2082c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1a20850*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x1a20858*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x1a20860*/ int System.Collections.ICollection.get_Count();
            /*0x1a20884*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1a20888*/ void CopyTo(System.Array array, int index);

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

            /*0x1a20990*/ string get_TypeName();
            /*0x1a20998*/ string get_PropertyName();
        }

        class BaseNumberConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a209a0*/ BaseNumberConverter();
            /*0x1a209a8*/ bool get_AllowHex();
            System.Type get_TargetType();
            object FromString(string value, int radix);
            object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a209b0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a20a78*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a20e74*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a21118*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        }

        class BooleanConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.ComponentModel.TypeConverter.StandardValuesCollection s_values;

            /*0x1a2158c*/ BooleanConverter();
            /*0x1a21150*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a21218*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a21418*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a2157c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a21584*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a217b8*/ ByteConverter();
            /*0x1a21594*/ System.Type get_TargetType();
            /*0x1a21600*/ object FromString(string value, int radix);
            /*0x1a21694*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a21708*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class CharConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a21b40*/ CharConverter();
            /*0x1a217c0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a21888*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a219b8*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
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

            /*0x1a21b48*/ CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element);
            /*0x1a21bbc*/ System.ComponentModel.CollectionChangeAction get_Action();
            /*0x1a21bc4*/ object get_Element();
        }

        class CollectionChangeEventHandler : System.MulticastDelegate
        {
            /*0x1a21bcc*/ CollectionChangeEventHandler(object object, nint method);
            /*0x1a21cfc*/ void Invoke(object sender, System.ComponentModel.CollectionChangeEventArgs e);
        }

        class CultureInfoConverter : System.ComponentModel.TypeConverter
        {
            static string DefaultInvariantCultureString = "(Default)";
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x1a22f38*/ CultureInfoConverter();
            /*0x1a21d10*/ string get_DefaultCultureString();
            /*0x1a21d50*/ string GetCultureName(System.Globalization.CultureInfo culture);
            /*0x1a21d70*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a21e38*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1a21f00*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a228bc*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a22d20*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a22f28*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a22f30*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class CultureComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.CultureInfoConverter _converter;

                /*0x1a22f00*/ CultureComparer(System.ComponentModel.CultureInfoConverter cultureConverter);
                /*0x1a22f40*/ int Compare(object item1, object item2);
            }

            class CultureInfoMapper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> s_cultureInfoNameMap;

                static /*0x1a2718c*/ CultureInfoMapper();
                static /*0x1a230ac*/ System.Collections.Generic.Dictionary<string, string> CreateMap();
                static /*0x1a2281c*/ string GetCultureInfoName(string cultureInfoDisplayName);
            }
        }

        class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
        {
            /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _parent;

            /*0x1a271d8*/ CustomTypeDescriptor();
            /*0x1a271e0*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x1a272b8*/ string GetClassName();
            /*0x1a27368*/ string GetComponentName();
            /*0x1a27418*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x1a274f8*/ System.ComponentModel.EventDescriptor GetDefaultEvent();
            /*0x1a275a8*/ System.ComponentModel.PropertyDescriptor GetDefaultProperty();
            /*0x1a27658*/ object GetEditor(System.Type editorBaseType);
            /*0x1a27710*/ System.ComponentModel.EventDescriptorCollection GetEvents();
            /*0x1a277ec*/ System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes);
            /*0x1a278d0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x1a279ac*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x1a27a90*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        class DateTimeConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a28324*/ DateTimeConverter();
            /*0x1a27b48*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a27c10*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1a27cd8*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a27ff8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class DecimalConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a289fc*/ DecimalConverter();
            /*0x1a2832c*/ bool get_AllowHex();
            /*0x1a28334*/ System.Type get_TargetType();
            /*0x1a283a0*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1a28464*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a2878c*/ object FromString(string value, int radix);
            /*0x1a28878*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a28924*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class DefaultEventAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultEventAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x1a28abc*/ DefaultEventAttribute();
            /*0x1a28a04*/ DefaultEventAttribute(string name);
            /*0x1a28a2c*/ string get_Name();
            /*0x1a28a34*/ bool Equals(object obj);
            /*0x1a28ab4*/ int GetHashCode();
        }

        class DefaultPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultPropertyAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x1a28bdc*/ DefaultPropertyAttribute();
            /*0x1a28b24*/ DefaultPropertyAttribute(string name);
            /*0x1a28b4c*/ string get_Name();
            /*0x1a28b54*/ bool Equals(object obj);
            /*0x1a28bd4*/ int GetHashCode();
        }

        class DelegatingTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
        {
            /*0x20*/ System.Type _type;

            /*0x1a28c44*/ DelegatingTypeDescriptionProvider(System.Type type);
            /*0x1a28c74*/ System.ComponentModel.TypeDescriptionProvider get_Provider();
            /*0x1a28cd0*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x1a28d20*/ System.Collections.IDictionary GetCache(object instance);
            /*0x1a28d48*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x1a28d70*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x1a28d98*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x1a28dd0*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
        }

        class ToolboxItemAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ToolboxItemAttribute Default;
            static /*0x8*/ System.ComponentModel.ToolboxItemAttribute None;
            /*0x10*/ string _toolboxItemTypeName;

            static /*0x1a290c4*/ ToolboxItemAttribute();
            /*0x1a28e70*/ ToolboxItemAttribute(bool defaultType);
            /*0x1a28ecc*/ ToolboxItemAttribute(string toolboxItemTypeName);
            /*0x1a28e08*/ bool IsDefaultAttribute();
            /*0x1a28f58*/ string get_ToolboxItemTypeName();
            /*0x1a28fac*/ bool Equals(object obj);
            /*0x1a290a0*/ int GetHashCode();
        }

        class DesignTimeVisibleAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignTimeVisibleAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignTimeVisibleAttribute No;
            static /*0x10*/ System.ComponentModel.DesignTimeVisibleAttribute Default;
            /*0x10*/ bool <Visible>k__BackingField;

            static /*0x1a29368*/ DesignTimeVisibleAttribute();
            /*0x1a29184*/ DesignTimeVisibleAttribute(bool visible);
            /*0x1a291ac*/ bool get_Visible();
            /*0x1a291b4*/ bool Equals(object obj);
            /*0x1a2924c*/ int GetHashCode();
            /*0x1a292e8*/ bool IsDefaultAttribute();
        }

        class DoubleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a29654*/ DoubleConverter();
            /*0x1a29400*/ bool get_AllowHex();
            /*0x1a29408*/ System.Type get_TargetType();
            /*0x1a29474*/ object FromString(string value, int radix);
            /*0x1a29534*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a295a4*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class EditorAttribute : System.Attribute
        {
            /*0x10*/ string _typeId;
            /*0x18*/ string <EditorBaseTypeName>k__BackingField;
            /*0x20*/ string <EditorTypeName>k__BackingField;

            /*0x1a2965c*/ EditorAttribute(string typeName, string baseTypeName);
            /*0x1a296ec*/ string get_EditorBaseTypeName();
            /*0x1a296f4*/ string get_EditorTypeName();
            /*0x1a296fc*/ object get_TypeId();
            /*0x1a29788*/ bool Equals(object obj);
            /*0x1a2982c*/ int GetHashCode();
        }

        class EventDescriptor : System.ComponentModel.MemberDescriptor
        {
            /*0x1a29834*/ EventDescriptor(string name, System.Attribute[] attrs);
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

            static /*0x1a2a878*/ EventDescriptorCollection();
            /*0x1a2983c*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events);
            /*0x1a298ec*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly);
            /*0x1a29910*/ int get_Count();
            /*0x1a29918*/ void set_Count(int value);
            /*0x1a29920*/ System.ComponentModel.EventDescriptor get_Item(int index);
            /*0x1a29a58*/ System.ComponentModel.EventDescriptor get_Item(string name);
            /*0x1a29a6c*/ int Add(System.ComponentModel.EventDescriptor value);
            /*0x1a29c3c*/ void Clear();
            /*0x1a29c90*/ bool Contains(System.ComponentModel.EventDescriptor value);
            /*0x1a29d08*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x1a299ac*/ void EnsureEventsOwned();
            /*0x1a29b3c*/ void EnsureSize(int sizeNeeded);
            /*0x1a29fa0*/ System.ComponentModel.EventDescriptor Find(string name, bool ignoreCase);
            /*0x1a29ca8*/ int IndexOf(System.ComponentModel.EventDescriptor value);
            /*0x1a2a0b4*/ void Insert(int index, System.ComponentModel.EventDescriptor value);
            /*0x1a2a1a4*/ void Remove(System.ComponentModel.EventDescriptor value);
            /*0x1a2a214*/ void RemoveAt(int index);
            /*0x1a2a2c8*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1a29d44*/ void InternalSort(string[] names);
            /*0x1a2a394*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x1a2a40c*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x1a2a414*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x1a2a41c*/ int System.Collections.ICollection.get_Count();
            /*0x1a2a424*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1a2a428*/ object System.Collections.IList.get_Item(int index);
            /*0x1a2a438*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x1a2a5b0*/ int System.Collections.IList.Add(object value);
            /*0x1a2a634*/ bool System.Collections.IList.Contains(object value);
            /*0x1a2a6c4*/ void System.Collections.IList.Clear();
            /*0x1a2a6c8*/ int System.Collections.IList.IndexOf(object value);
            /*0x1a2a74c*/ void System.Collections.IList.Insert(int index, object value);
            /*0x1a2a7e0*/ void System.Collections.IList.Remove(object value);
            /*0x1a2a864*/ void System.Collections.IList.RemoveAt(int index);
            /*0x1a2a868*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x1a2a870*/ bool System.Collections.IList.get_IsFixedSize();

            class ArraySubsetEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Array _array;
                /*0x18*/ int _total;
                /*0x1c*/ int _current;

                /*0x1a2a360*/ ArraySubsetEnumerator(System.Array array, int count);
                /*0x1a2a8e4*/ bool MoveNext();
                /*0x1a2a90c*/ void Reset();
                /*0x1a2a918*/ object get_Current();
            }
        }

        class ExpandableObjectConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a2a97c*/ ExpandableObjectConverter();
            /*0x1a2a984*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1a2a9ec*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ExtendedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.ComponentModel.ReflectPropertyDescriptor _extenderInfo;
            /*0x90*/ System.ComponentModel.IExtenderProvider _provider;

            /*0x1a2a9f4*/ ExtendedPropertyDescriptor(System.ComponentModel.ReflectPropertyDescriptor extenderInfo, System.Type receiverType, System.ComponentModel.IExtenderProvider provider, System.Attribute[] attributes);
            /*0x1a2acc4*/ bool CanResetValue(object comp);
            /*0x1a2acec*/ System.Type get_ComponentType();
            /*0x1a2ad10*/ bool get_IsReadOnly();
            /*0x1a2ae08*/ System.Type get_PropertyType();
            /*0x1a2ae2c*/ string get_DisplayName();
            /*0x1a2b008*/ object GetValue(object comp);
            /*0x1a2b030*/ void ResetValue(object comp);
            /*0x1a2b058*/ void SetValue(object component, object value);
            /*0x1a2b084*/ bool ShouldSerializeValue(object comp);
        }

        class ExtenderProvidedPropertyAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.PropertyDescriptor <ExtenderProperty>k__BackingField;
            /*0x18*/ System.ComponentModel.IExtenderProvider <Provider>k__BackingField;
            /*0x20*/ System.Type <ReceiverType>k__BackingField;

            static /*0x1a2ac4c*/ System.ComponentModel.ExtenderProvidedPropertyAttribute Create(System.ComponentModel.PropertyDescriptor extenderProperty, System.Type receiverType, System.ComponentModel.IExtenderProvider provider);
            /*0x1a2b0ac*/ ExtenderProvidedPropertyAttribute();
            /*0x1a2b0b4*/ System.ComponentModel.PropertyDescriptor get_ExtenderProperty();
            /*0x1a2b0bc*/ void set_ExtenderProperty(System.ComponentModel.PropertyDescriptor value);
            /*0x1a2b0c4*/ System.ComponentModel.IExtenderProvider get_Provider();
            /*0x1a2b0cc*/ void set_Provider(System.ComponentModel.IExtenderProvider value);
            /*0x1a2b0d4*/ System.Type get_ReceiverType();
            /*0x1a2b0dc*/ void set_ReceiverType(System.Type value);
            /*0x1a2b0e4*/ bool Equals(object obj);
            /*0x1a2b1b8*/ int GetHashCode();
            /*0x1a2b1c0*/ bool IsDefaultAttribute();
        }

        class GuidConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a2b7b8*/ GuidConverter();
            /*0x1a2b220*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a2b2e8*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1a2b3b0*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a2b490*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        interface IBindingList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
            bool get_AllowNew();
            object AddNew();
            bool get_AllowEdit();
            bool get_AllowRemove();
            bool get_SupportsChangeNotification();
            bool get_SupportsSearching();
            bool get_SupportsSorting();
            bool get_IsSorted();
            System.ComponentModel.PropertyDescriptor get_SortProperty();
            System.ComponentModel.ListSortDirection get_SortDirection();
            void AddIndex(System.ComponentModel.PropertyDescriptor property);
            void ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
            int Find(System.ComponentModel.PropertyDescriptor property, object key);
            void RemoveIndex(System.ComponentModel.PropertyDescriptor property);
            void RemoveSort();
        }

        interface ICustomTypeDescriptor
        {
            System.ComponentModel.AttributeCollection GetAttributes();
            string GetClassName();
            string GetComponentName();
            System.ComponentModel.TypeConverter GetConverter();
            System.ComponentModel.EventDescriptor GetDefaultEvent();
            System.ComponentModel.PropertyDescriptor GetDefaultProperty();
            object GetEditor(System.Type editorBaseType);
            System.ComponentModel.EventDescriptorCollection GetEvents();
            System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes);
            System.ComponentModel.PropertyDescriptorCollection GetProperties();
            System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        interface IExtenderProvider
        {
            bool CanExtend(object extendee);
        }

        interface INestedSite : System.ComponentModel.ISite, System.IServiceProvider
        {
            string get_FullName();
        }

        interface ITypeDescriptorContext : System.IServiceProvider
        {
            System.ComponentModel.IContainer get_Container();
        }

        interface ITypedList
        {
            string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors);
            System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors);
        }

        class Int16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a2b9e4*/ Int16Converter();
            /*0x1a2b7c0*/ System.Type get_TargetType();
            /*0x1a2b82c*/ object FromString(string value, int radix);
            /*0x1a2b8c0*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a2b934*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a2bc10*/ Int32Converter();
            /*0x1a2b9ec*/ System.Type get_TargetType();
            /*0x1a2ba58*/ object FromString(string value, int radix);
            /*0x1a2baec*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a2bb60*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a2be3c*/ Int64Converter();
            /*0x1a2bc18*/ System.Type get_TargetType();
            /*0x1a2bc84*/ object FromString(string value, int radix);
            /*0x1a2bd18*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a2bd8c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class ListBindableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ListBindableAttribute Yes;
            static /*0x8*/ System.ComponentModel.ListBindableAttribute No;
            static /*0x10*/ System.ComponentModel.ListBindableAttribute Default;
            /*0x10*/ bool _isDefault;
            /*0x11*/ bool <ListBindable>k__BackingField;

            static /*0x1a2bf98*/ ListBindableAttribute();
            /*0x1a2be44*/ ListBindableAttribute(bool listBindable);
            /*0x1a2be6c*/ bool get_ListBindable();
            /*0x1a2be74*/ bool Equals(object obj);
            /*0x1a2bf0c*/ int GetHashCode();
            /*0x1a2bf14*/ bool IsDefaultAttribute();
        }

        class ListChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.ComponentModel.ListChangedType <ListChangedType>k__BackingField;
            /*0x14*/ int <NewIndex>k__BackingField;
            /*0x18*/ int <OldIndex>k__BackingField;
            /*0x20*/ System.ComponentModel.PropertyDescriptor <PropertyDescriptor>k__BackingField;

            /*0x1a2c030*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex);
            /*0x1a2c0b8*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x1a2c0e8*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x1a2c038*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex);
            /*0x1a2c15c*/ System.ComponentModel.ListChangedType get_ListChangedType();
            /*0x1a2c164*/ int get_NewIndex();
            /*0x1a2c16c*/ int get_OldIndex();
        }

        class ListChangedEventHandler : System.MulticastDelegate
        {
            /*0x1a2c174*/ ListChangedEventHandler(object object, nint method);
            /*0x1a2c2a4*/ void Invoke(object sender, System.ComponentModel.ListChangedEventArgs e);
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

        enum ListSortDirection
        {
            Ascending = 0,
            Descending = 1,
        }

        class MarshalByValueComponent : System.ComponentModel.IComponent, System.IDisposable, System.IServiceProvider
        {
            static /*0x0*/ object s_eventDisposed;
            /*0x10*/ System.ComponentModel.ISite _site;
            /*0x18*/ System.ComponentModel.EventHandlerList _events;

            static /*0x1a2c844*/ MarshalByValueComponent();
            /*0x1a2c2b8*/ MarshalByValueComponent();
            /*0x1a2c2c0*/ void Finalize();
            /*0x1a2c360*/ System.ComponentModel.ISite get_Site();
            /*0x1a2c368*/ void Dispose();
            /*0x1a2c3d4*/ void Dispose(bool disposing);
            /*0x1a2c660*/ object GetService(System.Type service);
            /*0x1a2c714*/ string ToString();
        }

        class MultilineStringConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a2ca50*/ MultilineStringConverter();
            /*0x1a2c8bc*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a2ca40*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1a2ca48*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class NullableConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type <NullableType>k__BackingField;
            /*0x18*/ System.Type <UnderlyingType>k__BackingField;
            /*0x20*/ System.ComponentModel.TypeConverter <UnderlyingTypeConverter>k__BackingField;

            /*0x1a2ca58*/ NullableConverter(System.Type type);
            /*0x1a2cb84*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a2cc48*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a2cd84*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1a2ce48*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a2d038*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x1a2d05c*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a2d080*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1a2d0a4*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a2d0c8*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a2d478*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a2d4a0*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a2d4c8*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x1a2d4fc*/ System.Type get_NullableType();
            /*0x1a2d504*/ System.Type get_UnderlyingType();
            /*0x1a2d50c*/ System.ComponentModel.TypeConverter get_UnderlyingTypeConverter();
        }

        class PropertyDescriptor : System.ComponentModel.MemberDescriptor
        {
            /*0x60*/ System.ComponentModel.TypeConverter _converter;
            /*0x68*/ System.Collections.Hashtable _valueChangedHandlers;
            /*0x70*/ object[] _editors;
            /*0x78*/ System.Type[] _editorTypes;
            /*0x80*/ int _editorCount;

            /*0x1a2d514*/ PropertyDescriptor(string name, System.Attribute[] attrs);
            /*0x1a2ac44*/ PropertyDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs);
            System.Type get_ComponentType();
            /*0x1a2d51c*/ System.ComponentModel.TypeConverter get_Converter();
            bool get_IsReadOnly();
            System.Type get_PropertyType();
            bool CanResetValue(object component);
            /*0x1a2db70*/ bool Equals(object obj);
            /*0x1a2d96c*/ object CreateInstance(System.Type type);
            /*0x1a2dd70*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x1a2dd84*/ int GetHashCode();
            /*0x1a2ddd8*/ object GetInvocationTarget(System.Type type, object instance);
            /*0x1a2d770*/ System.Type GetTypeFromName(string typeName);
            object GetValue(object component);
            /*0x1a2dec0*/ void OnValueChanged(object component, System.EventArgs e);
            void ResetValue(object component);
            void SetValue(object component, object value);
            bool ShouldSerializeValue(object component);
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

            static /*0x1a2fdc4*/ PropertyDescriptorCollection();
            /*0x1a1f9a0*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties);
            /*0x1a2df70*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly);
            /*0x1a2df94*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, int propCount, string[] namedSort, System.Collections.IComparer comparer);
            /*0x1a2e09c*/ int get_Count();
            /*0x1a2e0a4*/ void set_Count(int value);
            /*0x1a2e0ac*/ System.ComponentModel.PropertyDescriptor get_Item(int index);
            /*0x1a2e1e4*/ System.ComponentModel.PropertyDescriptor get_Item(string name);
            /*0x1a2e1f8*/ int Add(System.ComponentModel.PropertyDescriptor value);
            /*0x1a2e3c8*/ void Clear();
            /*0x1a2e420*/ bool Contains(System.ComponentModel.PropertyDescriptor value);
            /*0x1a2e498*/ void CopyTo(System.Array array, int index);
            /*0x1a2e138*/ void EnsurePropsOwned();
            /*0x1a2e2c8*/ void EnsureSize(int sizeNeeded);
            /*0x1a2e730*/ System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase);
            /*0x1a2e438*/ int IndexOf(System.ComponentModel.PropertyDescriptor value);
            /*0x1a2ec40*/ void Insert(int index, System.ComponentModel.PropertyDescriptor value);
            /*0x1a2ed30*/ void Remove(System.ComponentModel.PropertyDescriptor value);
            /*0x1a2eda0*/ void RemoveAt(int index);
            /*0x1a2ee54*/ System.ComponentModel.PropertyDescriptorCollection Sort(string[] names);
            /*0x1a2e4d4*/ void InternalSort(string[] names);
            /*0x1a2eed8*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x1a2ef50*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1a2efec*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x1a2eff4*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x1a2effc*/ int System.Collections.ICollection.get_Count();
            /*0x1a2f004*/ void System.Collections.IList.Clear();
            /*0x1a2f008*/ void System.Collections.IDictionary.Clear();
            /*0x1a2f00c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1a2f01c*/ void System.Collections.IList.RemoveAt(int index);
            /*0x1a2f020*/ void System.Collections.IDictionary.Add(object key, object value);
            /*0x1a2f0e8*/ bool System.Collections.IDictionary.Contains(object key);
            /*0x1a2f168*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
            /*0x1a2f204*/ bool System.Collections.IDictionary.get_IsFixedSize();
            /*0x1a2f20c*/ bool System.Collections.IDictionary.get_IsReadOnly();
            /*0x1a2f214*/ object System.Collections.IDictionary.get_Item(object key);
            /*0x1a2f290*/ void System.Collections.IDictionary.set_Item(object key, object value);
            /*0x1a2f658*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
            /*0x1a2f748*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
            /*0x1a2f820*/ void System.Collections.IDictionary.Remove(object key);
            /*0x1a2f914*/ int System.Collections.IList.Add(object value);
            /*0x1a2f998*/ bool System.Collections.IList.Contains(object value);
            /*0x1a2fa28*/ int System.Collections.IList.IndexOf(object value);
            /*0x1a2faac*/ void System.Collections.IList.Insert(int index, object value);
            /*0x1a2fb40*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x1a2fb48*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x1a2fb50*/ void System.Collections.IList.Remove(object value);
            /*0x1a2fbd4*/ object System.Collections.IList.get_Item(int index);
            /*0x1a2fbe4*/ void System.Collections.IList.set_Item(int index, object value);

            class PropertyDescriptorEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
            {
                /*0x10*/ System.ComponentModel.PropertyDescriptorCollection _owner;
                /*0x18*/ int _index;

                /*0x1a2f1d4*/ PropertyDescriptorEnumerator(System.ComponentModel.PropertyDescriptorCollection owner);
                /*0x1a2fe30*/ object get_Current();
                /*0x1a2fe94*/ System.Collections.DictionaryEntry get_Entry();
                /*0x1a2fefc*/ object get_Key();
                /*0x1a2ff38*/ object get_Value();
                /*0x1a2ff74*/ bool MoveNext();
                /*0x1a2ffb4*/ void Reset();
            }
        }

        class ProvidePropertyAttribute : System.Attribute
        {
            /*0x10*/ string <PropertyName>k__BackingField;
            /*0x18*/ string <ReceiverTypeName>k__BackingField;

            /*0x1a2ffc0*/ string get_PropertyName();
            /*0x1a2ffc8*/ string get_ReceiverTypeName();
        }

        class ReferenceConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ string s_none;
            /*0x10*/ System.Type _type;

            static /*0x1a31094*/ ReferenceConverter();
            /*0x1a2ffd0*/ ReferenceConverter(System.Type type);
            /*0x1a2fff8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a300c4*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a3040c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a30860*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a3107c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a31084*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a3108c*/ bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value);

            class ReferenceComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.ReferenceConverter _converter;

                /*0x1a31054*/ ReferenceComparer(System.ComponentModel.ReferenceConverter converter);
                /*0x1a310f4*/ int Compare(object item1, object item2);
            }
        }

        class ReflectEventDescriptor : System.ComponentModel.EventDescriptor
        {
            /*0x60*/ System.Type _type;
            /*0x68*/ System.Type _componentClass;
            /*0x70*/ System.Reflection.MethodInfo _addMethod;
            /*0x78*/ System.Reflection.MethodInfo _removeMethod;
            /*0x80*/ System.Reflection.EventInfo _realEvent;
            /*0x88*/ bool _filledMethods;

            /*0x1a311ac*/ ReflectEventDescriptor(System.Type componentClass, System.Reflection.EventInfo eventInfo);
            /*0x1a31324*/ void FillAttributes(System.Collections.IList attributes);
            /*0x1a317d4*/ void FillEventInfoAttribute(System.Reflection.EventInfo realEventInfo, System.Collections.IList attributes);
            /*0x1a3138c*/ void FillMethods();
            /*0x1a31b00*/ void FillSingleMethodAttribute(System.Reflection.MethodInfo realMethodInfo, System.Collections.IList attributes);
        }

        class RefreshEventArgs : System.EventArgs
        {
            /*0x10*/ System.Type <TypeChanged>k__BackingField;

            /*0x1a31e6c*/ RefreshEventArgs(System.Type typeChanged);
        }

        class RefreshEventHandler : System.MulticastDelegate
        {
            /*0x1a31ed8*/ RefreshEventHandler(object object, nint method);
            /*0x1a32004*/ void Invoke(System.ComponentModel.RefreshEventArgs e);
        }

        class SByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a3223c*/ SByteConverter();
            /*0x1a32018*/ System.Type get_TargetType();
            /*0x1a32084*/ object FromString(string value, int radix);
            /*0x1a32118*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a3218c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class SingleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a32498*/ SingleConverter();
            /*0x1a32244*/ bool get_AllowHex();
            /*0x1a3224c*/ System.Type get_TargetType();
            /*0x1a322b8*/ object FromString(string value, int radix);
            /*0x1a32378*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a323e8*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class StringConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a3260c*/ StringConverter();
            /*0x1a324a0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a32568*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        class TimeSpanConverter : System.ComponentModel.TypeConverter
        {
            /*0x1a32cb8*/ TimeSpanConverter();
            /*0x1a32614*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a326dc*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1a327a4*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a329a4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class TypeConverterAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.TypeConverterAttribute Default;
            /*0x10*/ string <ConverterTypeName>k__BackingField;

            static /*0x1a32e30*/ TypeConverterAttribute();
            /*0x1a32cc0*/ TypeConverterAttribute();
            /*0x1a32d1c*/ TypeConverterAttribute(System.Type type);
            /*0x1a32d60*/ TypeConverterAttribute(string typeName);
            /*0x1a32d88*/ string get_ConverterTypeName();
            /*0x1a32d90*/ bool Equals(object obj);
            /*0x1a32e10*/ int GetHashCode();
        }

        class TypeDescriptionProvider
        {
            /*0x10*/ System.ComponentModel.TypeDescriptionProvider _parent;
            /*0x18*/ System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

            /*0x1a28c6c*/ TypeDescriptionProvider();
            /*0x1a32e90*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x1a32fa0*/ System.Collections.IDictionary GetCache(object instance);
            /*0x1a32fb8*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x1a33050*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x1a33144*/ System.Type GetReflectionType(System.Type objectType);
            /*0x1a33154*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x1a33170*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType);
            /*0x1a33180*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance);
            /*0x1a3320c*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

            class EmptyCustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor
            {
                /*0x1a33048*/ EmptyCustomTypeDescriptor();
            }
        }

        class TypeDescriptionProviderAttribute : System.Attribute
        {
            /*0x10*/ string <TypeName>k__BackingField;

            /*0x1a332b0*/ TypeDescriptionProviderAttribute(string typeName);
            /*0x1a33328*/ string get_TypeName();
        }

        class TypeListConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type[] _types;
            /*0x18*/ System.ComponentModel.TypeConverter.StandardValuesCollection _values;

            /*0x1a33330*/ TypeListConverter(System.Type[] types);
            /*0x1a33358*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1a33420*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1a334e8*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1a335f8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1a337ac*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a3386c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1a33874*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class UInt16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a33aa0*/ UInt16Converter();
            /*0x1a3387c*/ System.Type get_TargetType();
            /*0x1a338e8*/ object FromString(string value, int radix);
            /*0x1a3397c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a339f0*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a33ccc*/ UInt32Converter();
            /*0x1a33aa8*/ System.Type get_TargetType();
            /*0x1a33b14*/ object FromString(string value, int radix);
            /*0x1a33ba8*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a33c1c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1a33ef8*/ UInt64Converter();
            /*0x1a33cd4*/ System.Type get_TargetType();
            /*0x1a33d40*/ object FromString(string value, int radix);
            /*0x1a33dd4*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1a33e48*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        interface IChangeTracking
        {
            bool get_IsChanged();
            void AcceptChanges();
        }

        interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking
        {
            void RejectChanges();
        }

        interface INotifyPropertyChanged
        {
        }

        interface INotifyPropertyChanging
        {
        }

        class PropertyChangedEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x1a33f00*/ PropertyChangedEventArgs(string propertyName);
        }

        class PropertyChangedEventHandler : System.MulticastDelegate
        {
            /*0x1a33f6c*/ PropertyChangedEventHandler(object object, nint method);
            /*0x1a3409c*/ void Invoke(object sender, System.ComponentModel.PropertyChangedEventArgs e);
        }

        class PropertyChangingEventArgs : System.EventArgs
        {
            /*0x10*/ string _propertyName;

            /*0x1a340b0*/ PropertyChangingEventArgs(string propertyName);
        }

        class PropertyChangingEventHandler : System.MulticastDelegate
        {
            /*0x1a3411c*/ PropertyChangingEventHandler(object object, nint method);
            /*0x1a3424c*/ void Invoke(object sender, System.ComponentModel.PropertyChangingEventArgs e);
        }

        class CategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.CategoryAttribute defAttr;
            /*0x10*/ bool localized;
            /*0x18*/ string categoryValue;

            static /*0x1a34260*/ System.ComponentModel.CategoryAttribute get_Default();
            /*0x1a342ec*/ CategoryAttribute();
            /*0x1a34344*/ CategoryAttribute(string category);
            /*0x1a34370*/ string get_Category();
            /*0x1a343b0*/ bool Equals(object obj);
            /*0x1a344e4*/ int GetHashCode();
            /*0x1a34534*/ string GetLocalizedString(string value);
            /*0x1a348a0*/ bool IsDefaultAttribute();
        }

        class CollectionConverter : System.ComponentModel.TypeConverter
        {
            /*0x109d65c*/ CollectionConverter();
            /*0x109d29c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x109d64c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x109d654*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class Component : System.MarshalByRefObject, System.ComponentModel.IComponent, System.IDisposable
        {
            static /*0x0*/ object EventDisposed;
            /*0x18*/ System.ComponentModel.ISite site;
            /*0x20*/ System.ComponentModel.EventHandlerList events;

            static /*0x109dd34*/ Component();
            /*0x109dd2c*/ Component();
            /*0x109d66c*/ void Finalize();
            /*0x109d70c*/ bool get_CanRaiseEvents();
            /*0x109d714*/ bool get_CanRaiseEventsInternal();
            /*0x109d720*/ System.ComponentModel.ISite get_Site();
            /*0x109d728*/ void Dispose();
            /*0x109d794*/ void Dispose(bool disposing);
            /*0x109da98*/ object GetService(System.Type service);
            /*0x109db4c*/ bool get_DesignMode();
            /*0x109dbfc*/ string ToString();
        }

        class ComponentConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x109ddac*/ ComponentConverter(System.Type type);
            /*0x109de14*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x109dee0*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class DateTimeOffsetConverter : System.ComponentModel.TypeConverter
        {
            /*0x109eff4*/ DateTimeOffsetConverter();
            /*0x109dee8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x109e018*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x109e148*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x109e534*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class EnumConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;
            /*0x18*/ System.Type type;

            /*0x109effc*/ EnumConverter(System.Type type);
            /*0x109f024*/ System.Type get_EnumType();
            /*0x109f02c*/ System.ComponentModel.TypeConverter.StandardValuesCollection get_Values();
            /*0x109f034*/ void set_Values(System.ComponentModel.TypeConverter.StandardValuesCollection value);
            /*0x109f03c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x109f12c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x109f21c*/ System.Collections.IComparer get_Comparer();
            /*0x109f274*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x109f770*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x10a0578*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10a0b04*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10a0bac*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10a0bb4*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
        }

        interface IComponent : System.IDisposable
        {
            System.ComponentModel.ISite get_Site();
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

            static /*0x10a2104*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType);
            static /*0x10a210c*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly);
            static /*0x10a299c*/ System.ComponentModel.ISite GetSite(object component);
            /*0x10a0c20*/ MemberDescriptor(string name, System.Attribute[] attributes);
            /*0x10a0dc4*/ MemberDescriptor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes);
            /*0x10a11ec*/ System.Attribute[] get_AttributeArray();
            /*0x10a1a04*/ void set_AttributeArray(System.Attribute[] value);
            /*0x10a1ac8*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x10a1bb0*/ string get_Name();
            /*0x10a1c00*/ int get_NameHashCode();
            /*0x10a1c08*/ string get_DisplayName();
            /*0x10a120c*/ void CheckAttributesValid();
            /*0x10a1d30*/ System.ComponentModel.AttributeCollection CreateAttributeCollection();
            /*0x10a1dac*/ bool Equals(object obj);
            /*0x10a2010*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x10a12bc*/ void FilterAttributesIfNeeded();
            /*0x10a21b0*/ int GetHashCode();
            /*0x10a21b8*/ object GetInvocationTarget(System.Type type, object instance);
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

            static /*0x10a7850*/ ReflectPropertyDescriptor();
            /*0x10a2a98*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Attribute[] attributes);
            /*0x10a2d88*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Reflection.PropertyInfo propInfo, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x10a2ea8*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Type receiverType, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x10a2f74*/ object get_AmbientValue();
            /*0x10a30f0*/ System.Type get_ComponentType();
            /*0x10a30f8*/ object get_DefaultValue();
            /*0x10a3388*/ System.Reflection.MethodInfo get_GetMethodValue();
            /*0x10a37c4*/ bool get_IsExtender();
            /*0x10a3824*/ bool get_IsReadOnly();
            /*0x10a3e28*/ System.Type get_PropertyType();
            /*0x10a3e30*/ System.Reflection.MethodInfo get_ResetMethodValue();
            /*0x10a3924*/ System.Reflection.MethodInfo get_SetMethodValue();
            /*0x10a4038*/ System.Reflection.MethodInfo get_ShouldSerializeMethodValue();
            /*0x10a4240*/ bool ExtenderCanResetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x10a45f4*/ System.Type ExtenderGetReceiverType();
            /*0x10a45fc*/ System.Type ExtenderGetType(System.ComponentModel.IExtenderProvider provider);
            /*0x10a44c4*/ object ExtenderGetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x10a460c*/ void ExtenderResetValue(System.ComponentModel.IExtenderProvider provider, object component, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x10a4b20*/ void ExtenderSetValue(System.ComponentModel.IExtenderProvider provider, object component, object value, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x10a4f80*/ bool ExtenderShouldSerializeValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x10a53b0*/ bool CanResetValue(object component);
            /*0x10a5624*/ void FillAttributes(System.Collections.IList attributes);
            /*0x10a6688*/ object GetValue(object component);
            /*0x10a6a50*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x10a6af8*/ void ResetValue(object component);
            /*0x10a6f4c*/ void SetValue(object component, object value);
            /*0x10a7528*/ bool ShouldSerializeValue(object component);
        }

        class ReflectTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
        {
            static /*0x0*/ System.Type[] _typeConstructor;
            static /*0x8*/ System.Collections.Hashtable _editorTables;
            static /*0x10*/ System.Collections.Hashtable _intrinsicTypeConverters;
            static /*0x18*/ object _intrinsicReferenceKey;
            static /*0x20*/ object _intrinsicNullableKey;
            static /*0x28*/ object _dictionaryKey;
            static /*0x30*/ System.Collections.Hashtable _propertyCache;
            static /*0x38*/ System.Collections.Hashtable _eventCache;
            static /*0x40*/ System.Collections.Hashtable _attributeCache;
            static /*0x48*/ System.Collections.Hashtable _extendedPropertyCache;
            static /*0x50*/ System.Guid _extenderProviderKey;
            static /*0x60*/ System.Guid _extenderPropertiesKey;
            static /*0x70*/ System.Guid _extenderProviderPropertiesKey;
            static /*0x80*/ System.Type[] _skipInterfaceAttributeList;
            static /*0x88*/ object _internalSyncObject;
            /*0x20*/ System.Collections.Hashtable _typeData;

            static /*0x10af144*/ ReflectTypeDescriptionProvider();
            static /*0x10a7a88*/ System.Collections.Hashtable get_IntrinsicTypeConverters();
            static /*0x10a8748*/ object CreateInstance(System.Type objectType, System.Type callingType);
            static /*0x10aa39c*/ System.Collections.Hashtable GetEditorTable(System.Type editorBaseType);
            static /*0x10ac5fc*/ System.ComponentModel.IExtenderProvider[] GetExtenders(System.Collections.ICollection components, object instance, System.Collections.IDictionary cache);
            static /*0x10ad4f8*/ System.Type GetTypeFromName(string typeName);
            static /*0x10ad654*/ System.Attribute[] ReflectGetAttributes(System.Type type);
            static /*0x10a6238*/ System.Attribute[] ReflectGetAttributes(System.Reflection.MemberInfo member);
            static /*0x10adaa4*/ System.ComponentModel.EventDescriptor[] ReflectGetEvents(System.Type type);
            static /*0x10ab228*/ System.ComponentModel.PropertyDescriptor[] ReflectGetExtendedProperties(System.ComponentModel.IExtenderProvider provider);
            static /*0x10ae15c*/ System.ComponentModel.PropertyDescriptor[] ReflectGetProperties(System.Type type);
            static /*0x10ae7b4*/ object SearchIntrinsicTable(System.Collections.Hashtable table, System.Type callingType);
            /*0x10a7a80*/ ReflectTypeDescriptionProvider();
            /*0x10a8588*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x10a8844*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type type);
            /*0x10a9020*/ System.Collections.IDictionary GetCache(object instance);
            /*0x10a9388*/ string GetClassName(System.Type type);
            /*0x10a93dc*/ string GetComponentName(System.Type type, object instance);
            /*0x10a95ac*/ System.ComponentModel.TypeConverter GetConverter(System.Type type, object instance);
            /*0x10a9a38*/ System.ComponentModel.EventDescriptor GetDefaultEvent(System.Type type, object instance);
            /*0x10a9bf8*/ System.ComponentModel.PropertyDescriptor GetDefaultProperty(System.Type type, object instance);
            /*0x10a9db8*/ object GetEditor(System.Type type, object instance, System.Type editorBaseType);
            /*0x10aa7b8*/ System.ComponentModel.EventDescriptorCollection GetEvents(System.Type type);
            /*0x10aaad0*/ System.ComponentModel.AttributeCollection GetExtendedAttributes(object instance);
            /*0x10aab28*/ string GetExtendedClassName(object instance);
            /*0x10aab54*/ string GetExtendedComponentName(object instance);
            /*0x10aab90*/ System.ComponentModel.TypeConverter GetExtendedConverter(object instance);
            /*0x10aabcc*/ System.ComponentModel.EventDescriptor GetExtendedDefaultEvent(object instance);
            /*0x10aabd4*/ System.ComponentModel.PropertyDescriptor GetExtendedDefaultProperty(object instance);
            /*0x10aabdc*/ object GetExtendedEditor(object instance, System.Type editorBaseType);
            /*0x10aac20*/ System.ComponentModel.EventDescriptorCollection GetExtendedEvents(object instance);
            /*0x10aac78*/ System.ComponentModel.PropertyDescriptorCollection GetExtendedProperties(object instance);
            /*0x10ac170*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x10ad110*/ object GetExtendedPropertyOwner(object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x10ad1a0*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x10ad1a8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type type);
            /*0x10ad13c*/ object GetPropertyOwner(System.Type type, object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x10ad4c0*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x10a8860*/ System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(System.Type type, bool createIfNeeded);
            /*0x10ad4f0*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
            /*0x10ad608*/ bool IsPopulated(System.Type type);
            /*0x10ae770*/ void Refresh(System.Type type);

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

                static /*0x10af9a4*/ System.ComponentModel.EditorAttribute GetEditorAttribute(System.ComponentModel.AttributeCollection attributes, System.Type editorBaseType);
                /*0x10ad4c8*/ ReflectedTypeData(System.Type type);
                /*0x10ad638*/ bool get_IsPopulated();
                /*0x10a8ae0*/ System.ComponentModel.AttributeCollection GetAttributes();
                /*0x10a93b8*/ string GetClassName(object instance);
                /*0x10a9400*/ string GetComponentName(object instance);
                /*0x10a95d0*/ System.ComponentModel.TypeConverter GetConverter(object instance);
                /*0x10a9a5c*/ System.ComponentModel.EventDescriptor GetDefaultEvent(object instance);
                /*0x10a9c1c*/ System.ComponentModel.PropertyDescriptor GetDefaultProperty(object instance);
                /*0x10a9dec*/ object GetEditor(object instance, System.Type editorBaseType);
                /*0x10aa7d4*/ System.ComponentModel.EventDescriptorCollection GetEvents();
                /*0x10ad1c4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
                /*0x10af480*/ System.Type GetTypeFromName(string typeName);
                /*0x10ae79c*/ void Refresh();
            }
        }

        class TypeConverter
        {
            static string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
            static /*0x0*/ bool useCompatibleTypeConversion;

            static /*0x10afd6c*/ bool get_UseCompatibleTypeConversion();
            /*0x109d664*/ TypeConverter();
            /*0x10afdbc*/ bool CanConvertFrom(System.Type sourceType);
            /*0x109df90*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x10afdd0*/ bool CanConvertTo(System.Type destinationType);
            /*0x109e0c0*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x10afde4*/ object ConvertFrom(object value);
            /*0x109e4c8*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x10aff94*/ object ConvertFromInvariantString(string text);
            /*0x10b001c*/ object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x10b009c*/ object ConvertFromString(string text);
            /*0x10b00b4*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x10b0010*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text);
            /*0x10b0134*/ object ConvertTo(object value, System.Type destinationType);
            /*0x109d414*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x10b02d0*/ string ConvertToInvariantString(object value);
            /*0x10a0500*/ string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x10b0420*/ string ConvertToString(object value);
            /*0x10b0520*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x10b0344*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x10b0624*/ object CreateInstance(System.Collections.IDictionary propertyValues);
            /*0x10b0638*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x10afe60*/ System.Exception GetConvertFromException(object value);
            /*0x10b0150*/ System.Exception GetConvertToException(object value, System.Type destinationType);
            /*0x10b0640*/ bool GetCreateInstanceSupported();
            /*0x10b0650*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10b0658*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object value);
            /*0x10b0664*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x10b0754*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x10b075c*/ bool GetPropertiesSupported();
            /*0x10b076c*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10b0774*/ System.Collections.ICollection GetStandardValues();
            /*0x10b0784*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10b078c*/ bool GetStandardValuesExclusive();
            /*0x10b07a0*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10b07a8*/ bool GetStandardValuesSupported();
            /*0x10b07bc*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x10b07c4*/ bool IsValid(object value);
            /*0x10b07dc*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x10b091c*/ System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, string[] names);

            class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x88*/ System.Type componentType;
                /*0x90*/ System.Type propertyType;

                /*0x10b0954*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType);
                /*0x10b09d4*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes);
                /*0x10b0a08*/ System.Type get_ComponentType();
                /*0x10b0a10*/ bool get_IsReadOnly();
                /*0x10b0a94*/ System.Type get_PropertyType();
                /*0x10b0a9c*/ bool CanResetValue(object component);
                /*0x10b0be0*/ void ResetValue(object component);
                /*0x10b0d0c*/ bool ShouldSerializeValue(object component);
            }

            class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ICollection values;
                /*0x18*/ System.Array valueArray;

                /*0x10a0a54*/ StandardValuesCollection(System.Collections.ICollection values);
                /*0x10b0d14*/ int get_Count();
                /*0x10b0dd0*/ object get_Item(int index);
                /*0x10b0fc0*/ void CopyTo(System.Array array, int index);
                /*0x10b1078*/ System.Collections.IEnumerator GetEnumerator();
                /*0x10b1118*/ int System.Collections.ICollection.get_Count();
                /*0x10b111c*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x10b1124*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x10b112c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x10b1130*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x10b8284*/ TypeDescriptor();
            static /*0x10b1134*/ System.Type get_ComObjectType();
            static /*0x10b11a0*/ System.Type get_InterfaceType();
            static /*0x10b120c*/ int get_MetadataVersion();
            static /*0x10b1264*/ void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type);
            static /*0x10b2050*/ void CheckDefaultProvider(System.Type type);
            static /*0x10b265c*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            static /*0x10b2980*/ System.Collections.ArrayList FilterMembers(System.Collections.IList members, System.Attribute[] attributes);
            static /*0x10a22c8*/ object GetAssociation(System.Type type, object primary);
            static /*0x10a60dc*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType);
            static /*0x10af428*/ System.ComponentModel.AttributeCollection GetAttributes(object component);
            static /*0x10b2e54*/ System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc);
            static /*0x10ab1bc*/ System.Collections.IDictionary GetCache(object instance);
            static /*0x10b66f4*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x10b2d68*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Type type, string typeName);
            static /*0x10b3274*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc);
            static /*0x10b348c*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedDescriptor(object component);
            static /*0x10af684*/ System.ComponentModel.EventDescriptorCollection GetEvents(System.Type componentType);
            static /*0x10af628*/ System.ComponentModel.EventDescriptorCollection GetEvents(object component);
            static /*0x10b6808*/ System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes, bool noCustomTypeDesc);
            static /*0x10b733c*/ string GetExtenderCollisionSuffix(System.ComponentModel.MemberDescriptor member);
            static /*0x10b7654*/ System.Type GetNodeForBaseType(System.Type searchType);
            static /*0x10af840*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type componentType);
            static /*0x10af7e8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component);
            static /*0x10b7728*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc);
            static /*0x109de78*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
            static /*0x10b7de4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc);
            static /*0x10b7794*/ System.ComponentModel.PropertyDescriptorCollection GetPropertiesImpl(object component, System.Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes);
            static /*0x10b7e54*/ System.ComponentModel.TypeDescriptionProvider GetProviderRecursive(System.Type type);
            static /*0x10a0968*/ System.Type GetReflectionType(System.Type type);
            static /*0x10b2928*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type);
            static /*0x10b14e8*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type, bool createDelegator);
            static /*0x10b669c*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance);
            static /*0x10b7eac*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator);
            static /*0x10b6cec*/ System.Collections.ICollection PipelineAttributeFilter(int pipelineType, System.Collections.ICollection members, System.Attribute[] filter, object instance, System.Collections.IDictionary cache);
            static /*0x10b468c*/ System.Collections.ICollection PipelineFilter(int pipelineType, System.Collections.ICollection members, object instance, System.Collections.IDictionary cache);
            static /*0x10b5f88*/ System.Collections.ICollection PipelineInitialize(int pipelineType, System.Collections.ICollection members, System.Collections.IDictionary cache);
            static /*0x10b3548*/ System.Collections.ICollection PipelineMerge(int pipelineType, System.Collections.ICollection primary, System.Collections.ICollection secondary, object instance, System.Collections.IDictionary cache);
            static /*0x10b80f8*/ void RaiseRefresh(System.Type type);
            static /*0x10b1a28*/ void Refresh(System.Type type);
            static /*0x10b2cd8*/ bool ShouldHideMember(System.ComponentModel.MemberDescriptor member, System.Attribute attribute);
            static /*0x10b81ac*/ void SortDescriptorArray(System.Collections.IList infos);

            class AttributeFilterCacheItem
            {
                /*0x10*/ System.Attribute[] _filter;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x10b8090*/ AttributeFilterCacheItem(System.Attribute[] filter, System.Collections.ICollection filteredMembers);
                /*0x10b8018*/ bool IsValid(System.Attribute[] filter);
            }

            class FilterCacheItem
            {
                /*0x10*/ System.ComponentModel.Design.ITypeDescriptorFilterService _filterService;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x10b80cc*/ FilterCacheItem(System.ComponentModel.Design.ITypeDescriptorFilterService filterService, System.Collections.ICollection filteredMembers);
                /*0x10b80bc*/ bool IsValid(System.ComponentModel.Design.ITypeDescriptorFilterService filterService);
            }

            interface IUnimplemented
            {
            }

            class MemberDescriptorComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.ComponentModel.TypeDescriptor.MemberDescriptorComparer Instance;

                static /*0x10b8718*/ MemberDescriptorComparer();
                /*0x10b8710*/ MemberDescriptorComparer();
                /*0x10b85a4*/ int Compare(object left, object right);
            }

            class MergedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _primary;
                /*0x18*/ System.ComponentModel.ICustomTypeDescriptor _secondary;

                /*0x10b67dc*/ MergedTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor primary, System.ComponentModel.ICustomTypeDescriptor secondary);
                /*0x10b877c*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x10b888c*/ string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
                /*0x10b89a4*/ string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
                /*0x10b8abc*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x10b8bd4*/ System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
                /*0x10b8cec*/ System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
                /*0x10b8e04*/ object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType);
                /*0x10b8fb8*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
                /*0x10b90d0*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes);
                /*0x10b9200*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x10b9318*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x10b9448*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
            }

            class TypeDescriptionNode : System.ComponentModel.TypeDescriptionProvider
            {
                /*0x20*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode Next;
                /*0x28*/ System.ComponentModel.TypeDescriptionProvider Provider;

                /*0x10b1a00*/ TypeDescriptionNode(System.ComponentModel.TypeDescriptionProvider provider);
                /*0x10b9578*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
                /*0x10b9700*/ System.Collections.IDictionary GetCache(object instance);
                /*0x10b9770*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
                /*0x10b9824*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
                /*0x10b9894*/ System.Type GetReflectionType(System.Type objectType, object instance);
                /*0x10b9970*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

                struct DefaultExtendedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ object _instance;

                    /*0x10b981c*/ DefaultExtendedTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, object instance);
                    /*0x10b9acc*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x10b9da8*/ string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
                    /*0x10b9fec*/ string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
                    /*0x10ba1f8*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x10ba4a0*/ System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
                    /*0x10ba6ac*/ System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
                    /*0x10ba8b8*/ object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType);
                    /*0x10bab60*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
                    /*0x10bae40*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes);
                    /*0x10bb128*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x10bb3d0*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x10bb680*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                }

                struct DefaultTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ System.Type _objectType;
                    /*0x20*/ object _instance;

                    /*0x10b9ac0*/ DefaultTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Type objectType, object instance);
                    /*0x10bb8a8*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0x10bbb4c*/ string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
                    /*0x10bbd84*/ string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
                    /*0x10bbf90*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0x10bc238*/ System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
                    /*0x10bc444*/ System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
                    /*0x10bc650*/ object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType);
                    /*0x10bc8f8*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
                    /*0x10bcba0*/ System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes);
                    /*0x10bce50*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0x10bd0f8*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0x10bd3a8*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
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

            static /*0x10bd678*/ string GetErrorMessage(int error);
            /*0x10bd5cc*/ Win32Exception();
            /*0x10bd640*/ Win32Exception(int error);
            /*0x10bdf6c*/ Win32Exception(int error, string message);
            /*0x10bdf98*/ Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x10be020*/ int get_NativeErrorCode();
            /*0x10be028*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

            static /*0x10bf204*/ RefreshPropertiesAttribute();
            /*0x10bf0f4*/ RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh);
            /*0x10bf11c*/ System.ComponentModel.RefreshProperties get_RefreshProperties();
            /*0x10bf124*/ bool Equals(object value);
            /*0x10bf194*/ int GetHashCode();
            /*0x10bf19c*/ bool IsDefaultAttribute();
        }

        class WeakHashtable : System.Collections.Hashtable
        {
            static /*0x0*/ System.Collections.IEqualityComparer _comparer;

            static /*0x10bf334*/ WeakHashtable();
            /*0x10bf2c0*/ WeakHashtable();
            /*0x10bf324*/ void Clear();
            /*0x10bf32c*/ void Remove(object key);

            class WeakKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x10bf3ac*/ WeakKeyComparer();
                /*0x10bf3b4*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
                /*0x10bf510*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
            }
        }

        namespace Design
        {
            class CheckoutException : System.Runtime.InteropServices.ExternalException
            {
                static /*0x0*/ System.ComponentModel.Design.CheckoutException Canceled;

                static /*0x10bf548*/ CheckoutException();
                /*0x10bf530*/ CheckoutException();
                /*0x10bf538*/ CheckoutException(string message, int errorCode);
                /*0x10bf540*/ CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            interface IComponentChangeService
            {
                void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
                void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
            }

            interface IDesigner : System.IDisposable
            {
            }

            interface IDesignerHost : System.IServiceProvider
            {
                System.ComponentModel.IComponent get_RootComponent();
                System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
            }

            interface IDictionaryService
            {
                object GetValue(object key);
                void SetValue(object key, object value);
            }

            interface IExtenderListService
            {
                System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
            }

            interface IReferenceService
            {
                object GetReference(string name);
                string GetName(object reference);
                object[] GetReferences(System.Type baseType);
            }

            interface ITypeDescriptorFilterService
            {
                bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
                bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
                bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
            }

            class DesignerOptionService
            {
                /*0x10bf5cc*/ void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options);

                class DesignerOptionCollection : System.Collections.ICollection
                {
                    /*0x10*/ System.ComponentModel.Design.DesignerOptionService _service;
                    /*0x18*/ string _name;
                    /*0x20*/ object _value;
                    /*0x28*/ System.Collections.ArrayList _children;
                    /*0x30*/ System.ComponentModel.PropertyDescriptorCollection _properties;

                    /*0x10bf5d0*/ int get_Count();
                    /*0x10bf688*/ string get_Name();
                    /*0x10bf690*/ System.ComponentModel.PropertyDescriptorCollection get_Properties();
                    /*0x10bfe30*/ void CopyTo(System.Array array, int index);
                    /*0x10bf5fc*/ void EnsurePopulated();
                    /*0x10bfe74*/ System.Collections.IEnumerator GetEnumerator();
                    /*0x10bfea0*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x10bfea8*/ object System.Collections.ICollection.get_SyncRoot();

                    class WrappedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ object target;
                        /*0x90*/ System.ComponentModel.PropertyDescriptor property;

                        /*0x10bfde0*/ WrappedPropertyDescriptor(System.ComponentModel.PropertyDescriptor property, object target);
                        /*0x10bfeac*/ System.ComponentModel.AttributeCollection get_Attributes();
                        /*0x10bfecc*/ System.Type get_ComponentType();
                        /*0x10bfef0*/ bool get_IsReadOnly();
                        /*0x10bff14*/ System.Type get_PropertyType();
                        /*0x10bff38*/ bool CanResetValue(object component);
                        /*0x10bff64*/ object GetValue(object component);
                        /*0x10bff90*/ void ResetValue(object component);
                        /*0x10bffbc*/ void SetValue(object component, object value);
                        /*0x10bffe8*/ bool ShouldSerializeValue(object component);
                    }
                }

                class DesignerOptionConverter : System.ComponentModel.TypeConverter
                {
                    /*0x10c072c*/ DesignerOptionConverter();
                    /*0x10c0014*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext cxt);
                    /*0x10c001c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext cxt, object value, System.Attribute[] attributes);
                    /*0x10c0630*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext cxt, System.Globalization.CultureInfo culture, object value, System.Type destinationType);

                    class OptionPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection _option;

                        /*0x10c05f8*/ OptionPropertyDescriptor(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection option);
                        /*0x10c0734*/ System.Type get_ComponentType();
                        /*0x10c0750*/ bool get_IsReadOnly();
                        /*0x10c0758*/ System.Type get_PropertyType();
                        /*0x10c0774*/ bool CanResetValue(object component);
                        /*0x10c077c*/ object GetValue(object component);
                        /*0x10c0784*/ void ResetValue(object component);
                        /*0x10c0788*/ void SetValue(object component, object value);
                        /*0x10c078c*/ bool ShouldSerializeValue(object component);
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

                    /*0x10c0794*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments);
                    /*0x10c079c*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete);
                    /*0x10c0ca8*/ System.Collections.ICollection get_Arguments();
                    /*0x10c0cb0*/ System.Reflection.MemberInfo get_MemberInfo();
                    /*0x10c0cb8*/ object Invoke();
                }

                class RootDesignerSerializerAttribute : System.Attribute
                {
                    /*0x10*/ string _typeId;
                    /*0x18*/ bool <Reloadable>k__BackingField;
                    /*0x20*/ string <SerializerTypeName>k__BackingField;
                    /*0x28*/ string <SerializerBaseTypeName>k__BackingField;

                    /*0x10c1010*/ RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable);
                    /*0x10c104c*/ string get_SerializerBaseTypeName();
                    /*0x10c1054*/ object get_TypeId();
                }
            }
        }
    }

    namespace Collections
    {
        class HashtableExtensions
        {
            static bool TryGetValue<T>(System.Collections.Hashtable table, object key, ref T value);
        }

        namespace Specialized
        {
            struct BitVector32
            {
                /*0x10*/ uint _data;

                static /*0x10c1114*/ int CreateMask();
                static /*0x10c111c*/ int CreateMask(int previous);
                static /*0x10c1268*/ string ToString(System.Collections.Specialized.BitVector32 value);
                /*0x10c10e0*/ bool get_Item(int bit);
                /*0x10c10f8*/ void set_Item(int bit, bool value);
                /*0x10c118c*/ bool Equals(object o);
                /*0x10c1204*/ int GetHashCode();
                /*0x10c1338*/ string ToString();
            }

            class ListDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Specialized.ListDictionary.DictionaryNode head;
                /*0x18*/ int version;
                /*0x1c*/ int count;
                /*0x20*/ System.Collections.IComparer comparer;
                /*0x28*/ object _syncRoot;

                /*0x10c1340*/ ListDictionary();
                /*0x10c1348*/ ListDictionary(System.Collections.IComparer comparer);
                /*0x10c1370*/ object get_Item(object key);
                /*0x10c14d4*/ void set_Item(object key, object value);
                /*0x10c16a0*/ int get_Count();
                /*0x10c16a8*/ System.Collections.ICollection get_Keys();
                /*0x10c1744*/ bool get_IsReadOnly();
                /*0x10c174c*/ bool get_IsFixedSize();
                /*0x10c1754*/ bool get_IsSynchronized();
                /*0x10c175c*/ object get_SyncRoot();
                /*0x10c17d8*/ System.Collections.ICollection get_Values();
                /*0x10c1840*/ void Add(object key, object value);
                /*0x10c1a58*/ void Clear();
                /*0x10c1a6c*/ bool Contains(object key);
                /*0x10c1bc0*/ void CopyTo(System.Array array, int index);
                /*0x10c1d90*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x10c1e34*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x10c1e94*/ void Remove(object key);

                class NodeEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                    /*0x20*/ int _version;
                    /*0x24*/ bool _start;

                    /*0x10c1df0*/ NodeEnumerator(System.Collections.Specialized.ListDictionary list);
                    /*0x10c202c*/ object get_Current();
                    /*0x10c2090*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x10c2110*/ object get_Key();
                    /*0x10c2174*/ object get_Value();
                    /*0x10c21d8*/ bool MoveNext();
                    /*0x10c2278*/ void Reset();
                }

                class NodeKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ bool _isKeys;

                    /*0x10c1714*/ NodeKeyValueCollection(System.Collections.Specialized.ListDictionary list, bool isKeys);
                    /*0x10c22f8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x10c2444*/ int System.Collections.ICollection.get_Count();
                    /*0x10c247c*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x10c2484*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x10c249c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class NodeKeyValueEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                        /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                        /*0x20*/ int _version;
                        /*0x24*/ bool _isKeys;
                        /*0x25*/ bool _start;

                        /*0x10c2514*/ NodeKeyValueEnumerator(System.Collections.Specialized.ListDictionary list, bool isKeys);
                        /*0x10c2560*/ object get_Current();
                        /*0x10c25d8*/ bool MoveNext();
                        /*0x10c2678*/ void Reset();
                    }
                }

                class DictionaryNode
                {
                    /*0x10*/ object key;
                    /*0x18*/ object value;
                    /*0x20*/ System.Collections.Specialized.ListDictionary.DictionaryNode next;

                    /*0x10c1698*/ DictionaryNode();
                }
            }

            class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase
            {
                /*0x58*/ string[] _all;
                /*0x60*/ string[] _allKeys;

                static /*0x10c2c70*/ string GetAsOneString(System.Collections.ArrayList list);
                static /*0x10c2e10*/ string[] GetAsStringArray(System.Collections.ArrayList list);
                /*0x10c26f8*/ NameValueCollection();
                /*0x10c27ac*/ NameValueCollection(System.Collections.Specialized.NameValueCollection col);
                /*0x10c2a20*/ NameValueCollection(int capacity);
                /*0x10c2b34*/ NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x10c2bd4*/ NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10c3ab4*/ NameValueCollection(System.DBNull dummy);
                /*0x10c2c68*/ void InvalidateCachedArrays();
                /*0x10c28bc*/ void Add(System.Collections.Specialized.NameValueCollection c);
                /*0x10c2eb0*/ void Clear();
                /*0x10c2f88*/ void Add(string name, string value);
                /*0x10c3270*/ string Get(string name);
                /*0x10c32fc*/ string[] GetValues(string name);
                /*0x10c3388*/ void Set(string name, string value);
                /*0x10c3524*/ void Remove(string name);
                /*0x10c3738*/ string get_Item(string name);
                /*0x10c3748*/ void set_Item(string name, string value);
                /*0x10c3758*/ string Get(int index);
                /*0x10c3878*/ string[] GetValues(int index);
                /*0x10c38fc*/ string GetKey(int index);
                /*0x10c399c*/ string[] get_AllKeys();
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

                /*0x10c3b14*/ OrderedDictionary();
                /*0x10c3b34*/ OrderedDictionary(int capacity);
                /*0x10c3b60*/ OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer);
                /*0x10c3b90*/ OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10c3bb8*/ int get_Count();
                /*0x10c3c50*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x10c3c58*/ bool get_IsReadOnly();
                /*0x10c3c60*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x10c3c68*/ System.Collections.ICollection get_Keys();
                /*0x10c3bdc*/ System.Collections.ArrayList get_objectsArray();
                /*0x10c3d14*/ System.Collections.Hashtable get_objectsTable();
                /*0x10c3d98*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x10c3e14*/ object get_Item(object key);
                /*0x10c3e40*/ void set_Item(object key, object value);
                /*0x10c4268*/ System.Collections.ICollection get_Values();
                /*0x10c4140*/ void Add(object key, object value);
                /*0x10c42e0*/ void Clear();
                /*0x10c4378*/ bool Contains(object key);
                /*0x10c43a4*/ void CopyTo(System.Array array, int index);
                /*0x10c3fc0*/ int IndexOfKey(object key);
                /*0x10c43e0*/ void Remove(object key);
                /*0x10c44e8*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x10c45a8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x10c461c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10c47f4*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x10c4804*/ void OnDeserialization(object sender);

                class OrderedDictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ int _objectReturnType;
                    /*0x18*/ System.Collections.IEnumerator _arrayEnumerator;

                    /*0x10c455c*/ OrderedDictionaryEnumerator(System.Collections.ArrayList array, int objectReturnType);
                    /*0x10c4bbc*/ object get_Current();
                    /*0x10c4d68*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x10c4efc*/ object get_Key();
                    /*0x10c4fe0*/ object get_Value();
                    /*0x10c50c4*/ bool MoveNext();
                    /*0x10c5164*/ void Reset();
                }

                class OrderedDictionaryKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _objects;
                    /*0x18*/ bool _isKeys;

                    /*0x10c3ce4*/ OrderedDictionaryKeyValueCollection(System.Collections.ArrayList array, bool isKeys);
                    /*0x10c5208*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x10c5604*/ int System.Collections.ICollection.get_Count();
                    /*0x10c5628*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x10c5630*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x10c5654*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class StringCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ArrayList data;

                /*0x10c5c44*/ StringCollection();
                /*0x10c56d0*/ string get_Item(int index);
                /*0x10c574c*/ void set_Item(int index, string value);
                /*0x10c5770*/ int get_Count();
                /*0x10c5794*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x10c579c*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x10c57a4*/ int Add(string value);
                /*0x10c57c8*/ void Clear();
                /*0x10c57ec*/ bool Contains(string value);
                /*0x10c5810*/ void CopyTo(string[] array, int index);
                /*0x10c5834*/ int IndexOf(string value);
                /*0x10c5858*/ void Insert(int index, string value);
                /*0x10c587c*/ bool get_IsSynchronized();
                /*0x10c5884*/ void Remove(string value);
                /*0x10c58a8*/ void RemoveAt(int index);
                /*0x10c58cc*/ object get_SyncRoot();
                /*0x10c58f0*/ object System.Collections.IList.get_Item(int index);
                /*0x10c58f4*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x10c5980*/ int System.Collections.IList.Add(object value);
                /*0x10c59fc*/ bool System.Collections.IList.Contains(object value);
                /*0x10c5a78*/ int System.Collections.IList.IndexOf(object value);
                /*0x10c5af4*/ void System.Collections.IList.Insert(int index, object value);
                /*0x10c5b80*/ void System.Collections.IList.Remove(object value);
                /*0x10c5bfc*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x10c5c20*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class StringDictionary : System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable contents;

                /*0x10c5cac*/ StringDictionary();
                /*0x10c5d14*/ string get_Item(string key);
                /*0x10c5df0*/ System.Collections.IEnumerator GetEnumerator();
            }

            interface INotifyCollectionChanged
            {
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

                /*0x10c5e14*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action);
                /*0x10c5fd8*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index);
                /*0x10c61ec*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem, int index);
                /*0x10c640c*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex);
                /*0x10c61d4*/ void InitializeAddOrRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int startingIndex);
                /*0x10c5f4c*/ void InitializeAdd(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, int newStartingIndex);
                /*0x10c65c8*/ void InitializeRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList oldItems, int oldStartingIndex);
                /*0x10c63c8*/ void InitializeMoveOrReplace(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex, int oldStartingIndex);
            }

            class NotifyCollectionChangedEventHandler : System.MulticastDelegate
            {
                /*0x10c667c*/ NotifyCollectionChangedEventHandler(object object, nint method);
                /*0x10c67ac*/ void Invoke(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
            }

            class ReadOnlyList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.IList _list;

                /*0x10c6654*/ ReadOnlyList(System.Collections.IList list);
                /*0x10c67c0*/ int get_Count();
                /*0x10c6864*/ bool get_IsReadOnly();
                /*0x10c686c*/ bool get_IsFixedSize();
                /*0x10c6874*/ bool get_IsSynchronized();
                /*0x10c6918*/ object get_Item(int index);
                /*0x10c69c0*/ void set_Item(int index, object value);
                /*0x10c6a10*/ object get_SyncRoot();
                /*0x10c6ab4*/ int Add(object value);
                /*0x10c6b04*/ void Clear();
                /*0x10c6b54*/ bool Contains(object value);
                /*0x10c6c00*/ void CopyTo(System.Array array, int index);
                /*0x10c6cb8*/ System.Collections.IEnumerator GetEnumerator();
                /*0x10c6d58*/ int IndexOf(object value);
                /*0x10c6e04*/ void Insert(int index, object value);
                /*0x10c6e54*/ void Remove(object value);
                /*0x10c6ea4*/ void RemoveAt(int index);
            }

            class NameObjectCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                static /*0x0*/ System.StringComparer defaultComparer;
                /*0x10*/ bool _readOnly;
                /*0x18*/ System.Collections.ArrayList _entriesArray;
                /*0x20*/ System.Collections.IEqualityComparer _keyComparer;
                /*0x28*/ System.Collections.Hashtable _entriesTable;
                /*0x30*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;
                /*0x38*/ System.Collections.Specialized.NameObjectCollectionBase.KeysCollection _keys;
                /*0x40*/ System.Runtime.Serialization.SerializationInfo _serializationInfo;
                /*0x48*/ int _version;
                /*0x50*/ object _syncRoot;

                static /*0x10c85ac*/ NameObjectCollectionBase();
                /*0x10c274c*/ NameObjectCollectionBase();
                /*0x10c283c*/ NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer);
                /*0x10c2ba8*/ NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x10c2a84*/ NameObjectCollectionBase(int capacity);
                /*0x10c3b0c*/ NameObjectCollectionBase(System.DBNull dummy);
                /*0x10c2c40*/ NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10c7070*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10c77ac*/ void OnDeserialization(object sender);
                /*0x10c6ef4*/ void Reset();
                /*0x10c6fac*/ void Reset(int capacity);
                /*0x10c7fbc*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(string key);
                /*0x10c8074*/ System.Collections.IEqualityComparer get_Comparer();
                /*0x10c807c*/ bool get_IsReadOnly();
                /*0x10c310c*/ void BaseAdd(string name, object value);
                /*0x10c352c*/ void BaseRemove(string name);
                /*0x10c2f14*/ void BaseClear();
                /*0x10c30f4*/ object BaseGet(string name);
                /*0x10c3474*/ void BaseSet(string name, object value);
                /*0x10c37dc*/ object BaseGet(int index);
                /*0x10c3900*/ string BaseGetKey(int index);
                /*0x10c80b0*/ System.Collections.IEnumerator GetEnumerator();
                /*0x10c8150*/ int get_Count();
                /*0x10c8174*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x10c8490*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x10c850c*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x10c39c0*/ string[] BaseGetAllKeys();
                /*0x10c8514*/ System.Collections.Specialized.NameObjectCollectionBase.KeysCollection get_Keys();

                class NameObjectEntry
                {
                    /*0x10*/ string Key;
                    /*0x18*/ object Value;

                    /*0x10c8084*/ NameObjectEntry(string name, object value);
                }

                class NameObjectKeysEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ int _pos;
                    /*0x18*/ System.Collections.Specialized.NameObjectCollectionBase _coll;
                    /*0x20*/ int _version;

                    /*0x10c8110*/ NameObjectKeysEnumerator(System.Collections.Specialized.NameObjectCollectionBase coll);
                    /*0x10c8654*/ bool MoveNext();
                    /*0x10c8734*/ void Reset();
                    /*0x10c87c4*/ object get_Current();
                }

                class KeysCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Specialized.NameObjectCollectionBase _coll;

                    /*0x10c8584*/ KeysCollection(System.Collections.Specialized.NameObjectCollectionBase coll);
                    /*0x10c8cb0*/ KeysCollection();
                    /*0x10c886c*/ System.Collections.IEnumerator GetEnumerator();
                    /*0x10c88d0*/ int get_Count();
                    /*0x10c88f4*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x10c8c04*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x10c8ca8*/ bool System.Collections.ICollection.get_IsSynchronized();
                }
            }

            class CompatibleComparer : System.Collections.IEqualityComparer
            {
                static /*0x0*/ System.Collections.IComparer defaultComparer;
                static /*0x8*/ System.Collections.IHashCodeProvider defaultHashProvider;
                /*0x10*/ System.Collections.IComparer _comparer;
                /*0x18*/ System.Collections.IHashCodeProvider _hcp;

                static /*0x10c76d0*/ System.Collections.IComparer get_DefaultComparer();
                static /*0x10c75f0*/ System.Collections.IHashCodeProvider get_DefaultHashCodeProvider();
                /*0x10c7f90*/ CompatibleComparer(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider);
                /*0x10c8ce8*/ bool Equals(object a, object b);
                /*0x10c8ee8*/ int GetHashCode(object obj);
                /*0x10c8ff4*/ System.Collections.IComparer get_Comparer();
                /*0x10c8ffc*/ System.Collections.IHashCodeProvider get_HashCodeProvider();
            }
        }

        namespace Generic
        {
            struct ValueListBuilder<T>
            {
                /*0x0*/ System.Span<T> _span;
                /*0x0*/ T[] _arrayFromPool;
                /*0x0*/ int _pos;

                ValueListBuilder(System.Span<T> initialSpan);
                int get_Length();
                ref T get_Item(int index);
                void Append(T item);
                System.ReadOnlySpan<T> AsSpan();
                void Dispose();
                void Grow();
                T Pop();
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
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> head;
                /*0x0*/ int count;
                /*0x0*/ int version;
                /*0x0*/ object _syncRoot;
                /*0x0*/ System.Runtime.Serialization.SerializationInfo _siInfo;

                LinkedList();
                LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                int get_Count();
                System.Collections.Generic.LinkedListNode<T> get_First();
                bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                void System.Collections.Generic.ICollection<T>.Add(T value);
                System.Collections.Generic.LinkedListNode<T> AddFirst(T value);
                System.Collections.Generic.LinkedListNode<T> AddLast(T value);
                void AddLast(System.Collections.Generic.LinkedListNode<T> node);
                void Clear();
                bool Contains(T value);
                void CopyTo(T[] array, int index);
                System.Collections.Generic.LinkedListNode<T> Find(T value);
                System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                bool Remove(T value);
                void Remove(System.Collections.Generic.LinkedListNode<T> node);
                void RemoveFirst();
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void OnDeserialization(object sender);
                void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode);
                void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node);
                void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node);
                void ValidateNode(System.Collections.Generic.LinkedListNode<T> node);
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    /*0x0*/ System.Collections.Generic.LinkedList<T> _list;
                    /*0x0*/ System.Collections.Generic.LinkedListNode<T> _node;
                    /*0x0*/ int _version;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    Enumerator(System.Collections.Generic.LinkedList<T> list);
                    Enumerator(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    T get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    bool MoveNext();
                    void System.Collections.IEnumerator.Reset();
                    void Dispose();
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                }
            }

            class LinkedListNode<T>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<T> list;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> next;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> prev;
                /*0x0*/ T item;

                LinkedListNode(System.Collections.Generic.LinkedList<T> list, T value);
                System.Collections.Generic.LinkedListNode<T> get_Next();
                T get_Value();
                void Invalidate();
            }

            class SortedDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> _keys;
                /*0x0*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> _values;
                /*0x0*/ System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey, TValue>> _set;

                static bool IsCompatibleKey(object key);
                SortedDictionary();
                SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer);
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                TValue get_Item(TKey key);
                void set_Item(TKey key, TValue value);
                int get_Count();
                System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> get_Keys();
                System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> get_Values();
                System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                void Add(TKey key, TValue value);
                void Clear();
                bool ContainsKey(TKey key);
                bool ContainsValue(TValue value);
                void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int index);
                System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                bool Remove(TKey key);
                bool TryGetValue(TKey key, ref TValue value);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                bool System.Collections.IDictionary.get_IsFixedSize();
                bool System.Collections.IDictionary.get_IsReadOnly();
                System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                System.Collections.ICollection System.Collections.IDictionary.get_Values();
                object System.Collections.IDictionary.get_Item(object key);
                void System.Collections.IDictionary.set_Item(object key, object value);
                void System.Collections.IDictionary.Add(object key, object value);
                bool System.Collections.IDictionary.Contains(object key);
                System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                void System.Collections.IDictionary.Remove(object key);
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedSet.Enumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _treeEnum;
                    /*0x0*/ int _getEnumeratorRetType;

                    Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
                    bool MoveNext();
                    void Dispose();
                    System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    bool get_NotStartedOrEnded();
                    void Reset();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    object System.Collections.IDictionaryEnumerator.get_Key();
                    object System.Collections.IDictionaryEnumerator.get_Value();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                }

                class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TKey>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    System.Collections.Generic.SortedDictionary.KeyCollection.Enumerator<TKey, TValue> GetEnumerator();
                    System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    void CopyTo(TKey[] array, int index);
                    void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    int get_Count();
                    bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly();
                    void System.Collections.Generic.ICollection<TKey>.Add(TKey item);
                    void System.Collections.Generic.ICollection<TKey>.Clear();
                    bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item);
                    bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item);
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        void Dispose();
                        bool MoveNext();
                        TKey get_Current();
                        object System.Collections.IEnumerator.get_Current();
                        void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TKey[] array;
                        /*0x0*/ int index;

                        <>c__DisplayClass5_0();
                        bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        <>c__DisplayClass6_0();
                        bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TValue>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    void CopyTo(TValue[] array, int index);
                    void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    int get_Count();
                    bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly();
                    void System.Collections.Generic.ICollection<TValue>.Add(TValue item);
                    void System.Collections.Generic.ICollection<TValue>.Clear();
                    bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item);
                    bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item);
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        void Dispose();
                        bool MoveNext();
                        TValue get_Current();
                        object System.Collections.IEnumerator.get_Current();
                        void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TValue[] array;
                        /*0x0*/ int index;

                        <>c__DisplayClass5_0();
                        bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        <>c__DisplayClass6_0();
                        bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class KeyValuePairComparer<TKey, TValue> : System.Collections.Generic.Comparer<System.Collections.Generic.KeyValuePair<TKey, TValue>>
                {
                    /*0x0*/ System.Collections.Generic.IComparer<TKey> keyComparer;

                    KeyValuePairComparer(System.Collections.Generic.IComparer<TKey> keyComparer);
                    int Compare(System.Collections.Generic.KeyValuePair<TKey, TValue> x, System.Collections.Generic.KeyValuePair<TKey, TValue> y);
                }

                class <>c__DisplayClass34_0<TKey, TValue>
                {
                    /*0x0*/ bool found;
                    /*0x0*/ TValue value;

                    <>c__DisplayClass34_0();
                    bool <ContainsValue>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }

                class <>c__DisplayClass34_1<TKey, TValue>
                {
                    /*0x0*/ System.Collections.Generic.EqualityComparer<TValue> valueComparer;
                    /*0x0*/ System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1;

                    <>c__DisplayClass34_1();
                    bool <ContainsValue>b__1(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }
            }

            class TreeSet<T> : System.Collections.Generic.SortedSet<T>
            {
                TreeSet();
                TreeSet(System.Collections.Generic.IComparer<T> comparer);
                TreeSet(System.Runtime.Serialization.SerializationInfo siInfo, System.Runtime.Serialization.StreamingContext context);
                bool AddIfNotPresent(T item);
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

                static int Log2(int value);
                SortedSet();
                SortedSet(System.Collections.Generic.IComparer<T> comparer);
                SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action);
                int get_Count();
                bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void VersionCheck();
                bool IsWithinRange(T item);
                bool Add(T item);
                void System.Collections.Generic.ICollection<T>.Add(T item);
                bool AddIfNotPresent(T item);
                bool Remove(T item);
                bool DoRemove(T item);
                void Clear();
                bool Contains(T item);
                void CopyTo(T[] array, int index);
                void CopyTo(T[] array, int index, int count);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                System.Collections.Generic.SortedSet.Enumerator<T> GetEnumerator();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                void InsertionBalance(System.Collections.Generic.SortedSet.Node<T> current, ref System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> grandParent, System.Collections.Generic.SortedSet.Node<T> greatGrandParent);
                void ReplaceChildOrRoot(System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                void ReplaceNode(System.Collections.Generic.SortedSet.Node<T> match, System.Collections.Generic.SortedSet.Node<T> parentOfMatch, System.Collections.Generic.SortedSet.Node<T> successor, System.Collections.Generic.SortedSet.Node<T> parentOfSuccessor);
                System.Collections.Generic.SortedSet.Node<T> FindNode(T item);
                void UpdateVersion();
                void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                void OnDeserialization(object sender);

                class Node<T>
                {
                    /*0x0*/ T <Item>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Left>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Right>k__BackingField;
                    /*0x0*/ System.Collections.Generic.NodeColor <Color>k__BackingField;

                    static bool IsNonNullRed(System.Collections.Generic.SortedSet.Node<T> node);
                    static bool IsNullOrBlack(System.Collections.Generic.SortedSet.Node<T> node);
                    Node(T item, System.Collections.Generic.NodeColor color);
                    T get_Item();
                    void set_Item(T value);
                    System.Collections.Generic.SortedSet.Node<T> get_Left();
                    void set_Left(System.Collections.Generic.SortedSet.Node<T> value);
                    System.Collections.Generic.SortedSet.Node<T> get_Right();
                    void set_Right(System.Collections.Generic.SortedSet.Node<T> value);
                    System.Collections.Generic.NodeColor get_Color();
                    void set_Color(System.Collections.Generic.NodeColor value);
                    bool get_IsBlack();
                    bool get_IsRed();
                    bool get_Is2Node();
                    bool get_Is4Node();
                    void ColorBlack();
                    void ColorRed();
                    System.Collections.Generic.TreeRotation GetRotation(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T> sibling);
                    System.Collections.Generic.SortedSet.Node<T> GetSibling(System.Collections.Generic.SortedSet.Node<T> node);
                    void Split4Node();
                    System.Collections.Generic.SortedSet.Node<T> Rotate(System.Collections.Generic.TreeRotation rotation);
                    System.Collections.Generic.SortedSet.Node<T> RotateLeft();
                    System.Collections.Generic.SortedSet.Node<T> RotateLeftRight();
                    System.Collections.Generic.SortedSet.Node<T> RotateRight();
                    System.Collections.Generic.SortedSet.Node<T> RotateRightLeft();
                    void Merge2Nodes();
                    void ReplaceChild(System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    static /*0x0*/ System.Collections.Generic.SortedSet.Node<T> s_dummyNode;
                    /*0x0*/ System.Collections.Generic.SortedSet<T> _tree;
                    /*0x0*/ int _version;
                    /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>> _stack;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> _current;
                    /*0x0*/ bool _reverse;

                    static Enumerator();
                    Enumerator(System.Collections.Generic.SortedSet<T> set);
                    Enumerator(System.Collections.Generic.SortedSet<T> set, bool reverse);
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                    void Initialize();
                    bool MoveNext();
                    void Dispose();
                    T get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    bool get_NotStartedOrEnded();
                    void Reset();
                    void System.Collections.IEnumerator.Reset();
                }

                class <>c__DisplayClass52_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ int count;
                    /*0x0*/ T[] array;

                    <>c__DisplayClass52_0();
                    bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
                }

                class <>c__DisplayClass53_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ object[] objects;

                    <>c__DisplayClass53_0();
                    bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
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
                bool Invoke(System.Collections.Generic.SortedSet.Node<T> node);
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
            }
        }
    }

    namespace IO
    {
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

                static /*0x10c9b70*/ void ThrowStreamClosedException();
                /*0x10c9004*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x10c900c*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x10c90d0*/ bool get_CanRead();
                /*0x10c90e8*/ bool get_CanWrite();
                /*0x10c9100*/ bool get_CanSeek();
                /*0x10c9118*/ long get_Length();
                /*0x10c9168*/ long get_Position();
                /*0x10c91b8*/ void set_Position(long value);
                /*0x10c9208*/ void Flush();
                /*0x10c9244*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x10c9294*/ void SetLength(long value);
                /*0x10c92e4*/ int ReadByte();
                /*0x10c9308*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x10c93bc*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x10c9404*/ int Read(byte[] array, int offset, int count);
                /*0x10c9428*/ int Read(System.Span<byte> buffer);
                /*0x10c9630*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x10c96e4*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x10c96f0*/ void Write(byte[] array, int offset, int count);
                /*0x10c9714*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x10c9884*/ void Dispose(bool disposing);
                /*0x10c993c*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x10c9960*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x10c9a44*/ System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x10c9a68*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x10c9b4c*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x10c922c*/ void CheckDeflateStream();
            }

            class DeflateStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream base_stream;
                /*0x30*/ System.IO.Compression.CompressionMode mode;
                /*0x34*/ bool leaveOpen;
                /*0x35*/ bool disposed;
                /*0x38*/ System.IO.Compression.DeflateStreamNative native;

                /*0x10c9bc4*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x10c9d3c*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x10c90c4*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen, int windowsBits);
                /*0x10c9bd0*/ DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen, bool gzip);
                /*0x10c9e7c*/ void Finalize();
                /*0x10c9f20*/ void Dispose(bool disposing);
                /*0x10ca0dc*/ int ReadInternal(byte[] array, int offset, int count);
                /*0x10c9a3c*/ System.Threading.Tasks.ValueTask<int> ReadAsyncMemory(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken);
                /*0x10c9514*/ int ReadCore(System.Span<byte> destination);
                /*0x10ca19c*/ int Read(byte[] array, int offset, int count);
                /*0x10ca388*/ void WriteInternal(byte[] array, int offset, int count);
                /*0x10c9b44*/ System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken);
                /*0x10c9800*/ void WriteCore(System.ReadOnlySpan<byte> source);
                /*0x10ca438*/ void Write(byte[] array, int offset, int count);
                /*0x10ca630*/ void Flush();
                /*0x10ca73c*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x10cab3c*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x10caf3c*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x10cb0a8*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x10cb1fc*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x10cb23c*/ void SetLength(long value);
                /*0x10cb27c*/ bool get_CanRead();
                /*0x10cb2b8*/ bool get_CanSeek();
                /*0x10cb2c0*/ bool get_CanWrite();
                /*0x10cb300*/ long get_Length();
                /*0x10cb340*/ long get_Position();
                /*0x10cb380*/ void set_Position(long value);

                class ReadMethod : System.MulticastDelegate
                {
                    /*0x10ca9bc*/ ReadMethod(object object, nint method);
                    /*0x10cb3c0*/ int Invoke(byte[] array, int offset, int count);
                    /*0x10caa94*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x10cb080*/ int EndInvoke(System.IAsyncResult result);
                }

                class WriteMethod : System.MulticastDelegate
                {
                    /*0x10cadbc*/ WriteMethod(object object, nint method);
                    /*0x10cb3d4*/ void Invoke(byte[] array, int offset, int count);
                    /*0x10cae94*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x10cb1f0*/ void EndInvoke(System.IAsyncResult result);
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

                static /*0x10c9d48*/ System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool gzip);
                static /*0x10cb3e8*/ int UnmanagedRead(nint buffer, int length, nint data);
                static /*0x10cb4a4*/ int UnmanagedWrite(nint buffer, int length, nint data);
                static /*0x10cb62c*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, bool gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, nint data);
                static /*0x10cbdbc*/ int CloseZStream(nint stream);
                static /*0x10cb75c*/ int Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream);
                static /*0x10cb8f4*/ int ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                static /*0x10cb970*/ int WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                /*0x10cb560*/ DeflateStreamNative();
                /*0x10cb6c4*/ void Finalize();
                /*0x10c9fd8*/ void Dispose(bool disposing);
                /*0x10ca6e8*/ void Flush();
                /*0x10ca124*/ int ReadZStream(nint buffer, int length);
                /*0x10ca3cc*/ void WriteZStream(nint buffer, int length);
                /*0x10cb9ec*/ int UnmanagedRead(nint buffer, int length);
                /*0x10cbb90*/ int UnmanagedWrite(nint buffer, int length);
                /*0x10cb7c0*/ void CheckResult(int result, string where);

                class UnmanagedReadOrWrite : System.MulticastDelegate
                {
                    /*0x10cb568*/ UnmanagedReadOrWrite(object object, nint method);
                    /*0x10cbdc0*/ int Invoke(nint buffer, int length, nint data);
                }

                class SafeDeflateStreamHandle : System.Runtime.InteropServices.SafeHandle
                {
                    /*0x10cbd64*/ SafeDeflateStreamHandle();
                    /*0x10cbdd4*/ bool get_IsInvalid();
                    /*0x10cbe28*/ bool ReleaseHandle();
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
    static /*0x178*/ long 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C;
    static /*0x180*/ <PrivateImplementationDetails> 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF;
    static /*0x190*/ long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885;
    static /*0x198*/ <PrivateImplementationDetails> 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3;
    static /*0x218*/ <PrivateImplementationDetails> 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8;
    static /*0x244*/ <PrivateImplementationDetails> 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A;
    static /*0x24a*/ <PrivateImplementationDetails> B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C;
    static /*0x2d0*/ long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859;
    static /*0x2d8*/ <PrivateImplementationDetails> DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5;

    static /*0x10c7f14*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=9
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
                /*0x10cbeb0*/ BypassElementCollection();
            }

            class ConnectionManagementElement : System.Configuration.ConfigurationElement
            {
            }

            class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x10cbee8*/ ConnectionManagementElementCollection();
            }

            class ConnectionManagementSection : System.Configuration.ConfigurationSection
            {
                /*0x10cbf20*/ ConnectionManagementSection();
                /*0x10cbf58*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class DefaultProxySection : System.Configuration.ConfigurationSection
            {
                /*0x10cbf90*/ DefaultProxySection();
                /*0x10cbfc8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
                /*0x10cc000*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            }

            class ProxyElement : System.Configuration.ConfigurationElement
            {
                /*0x10cc038*/ ProxyElement();
                /*0x10cc070*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class HttpWebRequestElement : System.Configuration.ConfigurationElement
            {
                /*0x10cc0a8*/ HttpWebRequestElement();
                /*0x10cc0e0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class Ipv6Element : System.Configuration.ConfigurationElement
            {
                /*0x10cc118*/ Ipv6Element();
                /*0x10cc150*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
            {
                /*0x10cc188*/ NetSectionGroup();
            }

            class SettingsSection : System.Configuration.ConfigurationSection
            {
                /*0x10cc1c0*/ SettingsSection();
                /*0x10cc1f8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class PerformanceCountersElement : System.Configuration.ConfigurationElement
            {
                /*0x10cc230*/ PerformanceCountersElement();
                /*0x10cc268*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class ServicePointManagerElement : System.Configuration.ConfigurationElement
            {
                /*0x10cc2a0*/ ServicePointManagerElement();
                /*0x10cc2d8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class SocketElement : System.Configuration.ConfigurationElement
            {
                /*0x10cc310*/ SocketElement();
                /*0x10cc348*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebProxyScriptElement : System.Configuration.ConfigurationElement
            {
                /*0x10cc380*/ WebProxyScriptElement();
                /*0x10cc3b8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModulesSection : System.Configuration.ConfigurationSection
            {
                /*0x10cc3f0*/ WebRequestModulesSection();
                /*0x10cc428*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x10cc460*/ WebRequestModuleElementCollection();
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
            /*0x10cc498*/ DiagnosticsConfigurationHandler();
            /*0x10cc4d0*/ object Create(object parent, object configContext, System.Xml.XmlNode section);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x10cc508*/ void ThrowNotSupportedException();
    }
}
