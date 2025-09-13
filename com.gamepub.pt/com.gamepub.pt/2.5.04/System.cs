class <Module>
{
}

class SR
{
    static /*0x1859a44*/ string GetString(string name, object[] args);
    static /*0x1859ac0*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
    static /*0x1859ac8*/ string GetString(string name);
    static /*0x1859acc*/ string Format(string resourceFormat, object p1);
    static /*0x1859b48*/ string Format(string resourceFormat, object p1, object p2);
}

namespace Mono
{
    namespace Util
    {
        class MonoPInvokeCallbackAttribute : System.Attribute
        {
            /*0x1cc55e0*/ MonoPInvokeCallbackAttribute(System.Type t);
        }
    }

    namespace Unity
    {
        class CertHelper
        {
            static /*0x1d06d94*/ void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x1d06f24*/ void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class Debug
        {
            static /*0x17d0b7c*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, string context, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x17d0c18*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, string context, Mono.Security.Interface.AlertDescription defaultAlert);
        }

        class UnityTls
        {
            static /*0x0*/ Mono.Unity.UnityTls.unitytls_interface_struct marshalledInterface;

            static /*0x1874538*/ nint GetUnityTlsInterface();
            static /*0x187453c*/ bool get_IsSupported();
            static /*0x1874558*/ Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface();

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
                /*0x148dbd8*/ unitytls_x509verify_callback(object object, nint method);
                /*0x148dc38*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                /*0x148deb8*/ System.IAsyncResult BeginInvoke(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                /*0x148df80*/ Mono.Unity.UnityTls.unitytls_x509verify_result EndInvoke(System.IAsyncResult result);
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
                /*0x148d494*/ unitytls_tlsctx_write_callback(object object, nint method);
                /*0x148d4f4*/ nint Invoke(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                /*0x148d774*/ System.IAsyncResult BeginInvoke(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                /*0x148d818*/ nint EndInvoke(System.IAsyncResult result);
            }

            class unitytls_tlsctx_read_callback : System.MulticastDelegate
            {
                /*0x148cd58*/ unitytls_tlsctx_read_callback(object object, nint method);
                /*0x148cdb8*/ nint Invoke(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                /*0x148d038*/ System.IAsyncResult BeginInvoke(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                /*0x148d0dc*/ nint EndInvoke(System.IAsyncResult result);
            }

            class unitytls_tlsctx_trace_callback : System.MulticastDelegate
            {
                /*0x148d108*/ unitytls_tlsctx_trace_callback(object object, nint method);
                /*0x148d168*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen);
                /*0x148d3e0*/ System.IAsyncResult BeginInvoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen, System.AsyncCallback callback, object object);
                /*0x148d488*/ void EndInvoke(System.IAsyncResult result);
            }

            class unitytls_tlsctx_certificate_callback : System.MulticastDelegate
            {
                /*0x148c96c*/ unitytls_tlsctx_certificate_callback(object object, nint method);
                /*0x148c9cc*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                /*0x148cc70*/ System.IAsyncResult BeginInvoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                /*0x148cd4c*/ void EndInvoke(System.IAsyncResult result);
            }

            class unitytls_tlsctx_x509verify_callback : System.MulticastDelegate
            {
                /*0x148d844*/ unitytls_tlsctx_x509verify_callback(object object, nint method);
                /*0x148d8a4*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                /*0x148db10*/ System.IAsyncResult BeginInvoke(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                /*0x148dbac*/ Mono.Unity.UnityTls.unitytls_x509verify_result EndInvoke(System.IAsyncResult result);
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

                /*0x148c964*/ unitytls_interface_struct();

                class unitytls_errorstate_create_t : System.MulticastDelegate
                {
                    /*0x2328834*/ unitytls_errorstate_create_t(object object, nint method);
                    /*0x2328894*/ Mono.Unity.UnityTls.unitytls_errorstate Invoke();
                    /*0x2328aac*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                    /*0x2328ad8*/ Mono.Unity.UnityTls.unitytls_errorstate EndInvoke(System.IAsyncResult result);
                }

                class unitytls_errorstate_raise_error_t : System.MulticastDelegate
                {
                    /*0x2328b08*/ unitytls_errorstate_raise_error_t(object object, nint method);
                    /*0x2328b68*/ void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode);
                    /*0x2328db0*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode, System.AsyncCallback callback, object object);
                    /*0x2328e48*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_key_get_ref_t : System.MulticastDelegate
                {
                    /*0x2329114*/ unitytls_key_get_ref_t(object object, nint method);
                    /*0x2329174*/ Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x23293c4*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x23293f4*/ Mono.Unity.UnityTls.unitytls_key_ref EndInvoke(System.IAsyncResult result);
                }

                class unitytls_key_parse_der_t : System.MulticastDelegate
                {
                    /*0x2329420*/ unitytls_key_parse_der_t(object object, nint method);
                    /*0x2329480*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x2329714*/ System.IAsyncResult BeginInvoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x23297d0*/ Mono.Unity.UnityTls.unitytls_key* EndInvoke(System.IAsyncResult result);
                }

                class unitytls_key_parse_pem_t : System.MulticastDelegate
                {
                    /*0x23297dc*/ unitytls_key_parse_pem_t(object object, nint method);
                    /*0x232983c*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x2329ad0*/ System.IAsyncResult BeginInvoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x2329b8c*/ Mono.Unity.UnityTls.unitytls_key* EndInvoke(System.IAsyncResult result);
                }

                class unitytls_key_free_t : System.MulticastDelegate
                {
                    /*0x2328e54*/ unitytls_key_free_t(object object, nint method);
                    /*0x2328eb4*/ void Invoke(Mono.Unity.UnityTls.unitytls_key* key);
                    /*0x23290e4*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_key* key, System.AsyncCallback callback, object object);
                    /*0x2329108*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509_export_der_t : System.MulticastDelegate
                {
                    /*0x232cf5c*/ unitytls_x509_export_der_t(object object, nint method);
                    /*0x232cfbc*/ nint Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232d25c*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232d31c*/ nint EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509list_get_ref_t : System.MulticastDelegate
                {
                    /*0x232dfc4*/ unitytls_x509list_get_ref_t(object object, nint method);
                    /*0x232e024*/ Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232e274*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232e2a4*/ Mono.Unity.UnityTls.unitytls_x509list_ref EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509list_get_x509_t : System.MulticastDelegate
                {
                    /*0x232e2d0*/ unitytls_x509list_get_x509_t(object object, nint method);
                    /*0x232e330*/ Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, nint index, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232e5b8*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, nint index, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232e674*/ Mono.Unity.UnityTls.unitytls_x509_ref EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509list_create_t : System.MulticastDelegate
                {
                    /*0x232da3c*/ unitytls_x509list_create_t(object object, nint method);
                    /*0x232da9c*/ Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232dcd4*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232dcf8*/ Mono.Unity.UnityTls.unitytls_x509list* EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509list_append_t : System.MulticastDelegate
                {
                    /*0x232d6d0*/ unitytls_x509list_append_t(object object, nint method);
                    /*0x232d730*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232d994*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232da30*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509list_append_der_t : System.MulticastDelegate
                {
                    /*0x232d348*/ unitytls_x509list_append_der_t(object object, nint method);
                    /*0x232d3a8*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232d620*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509list* list, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232d6c4*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509list_free_t : System.MulticastDelegate
                {
                    /*0x232dd04*/ unitytls_x509list_free_t(object object, nint method);
                    /*0x232dd64*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list);
                    /*0x232df94*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509list* list, System.AsyncCallback callback, object object);
                    /*0x232dfb8*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509verify_default_ca_t : System.MulticastDelegate
                {
                    /*0x232e6a0*/ unitytls_x509verify_default_ca_t(object object, nint method);
                    /*0x232e700*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232e9cc*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232eaa0*/ Mono.Unity.UnityTls.unitytls_x509verify_result EndInvoke(System.IAsyncResult result);
                }

                class unitytls_x509verify_explicit_ca_t : System.MulticastDelegate
                {
                    /*0x232eacc*/ unitytls_x509verify_explicit_ca_t(object object, nint method);
                    /*0x232eb2c*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232edfc*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232eee4*/ Mono.Unity.UnityTls.unitytls_x509verify_result EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_create_server_t : System.MulticastDelegate
                {
                    /*0x232a3f8*/ unitytls_tlsctx_create_server_t(object object, nint method);
                    /*0x232a458*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232a7ec*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232a8ec*/ Mono.Unity.UnityTls.unitytls_tlsctx* EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_create_client_t : System.MulticastDelegate
                {
                    /*0x2329f04*/ unitytls_tlsctx_create_client_t(object object, nint method);
                    /*0x2329f64*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232a2f8*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232a3ec*/ Mono.Unity.UnityTls.unitytls_tlsctx* EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_server_require_client_authentication_t : System.MulticastDelegate
                {
                    /*0x232bb70*/ unitytls_tlsctx_server_require_client_authentication_t(object object, nint method);
                    /*0x232bbd0*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232be34*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232bed0*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_set_certificate_callback_t : System.MulticastDelegate
                {
                    /*0x232bedc*/ unitytls_tlsctx_set_certificate_callback_t(object object, nint method);
                    /*0x232bf3c*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232c1b4*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232c1e8*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_set_trace_callback_t : System.MulticastDelegate
                {
                    /*0x232c57c*/ unitytls_tlsctx_set_trace_callback_t(object object, nint method);
                    /*0x232c5dc*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232c854*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232c888*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_set_x509verify_callback_t : System.MulticastDelegate
                {
                    /*0x232c894*/ unitytls_tlsctx_set_x509verify_callback_t(object object, nint method);
                    /*0x232c8f4*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232cb6c*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232cba0*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_set_supported_ciphersuites_t : System.MulticastDelegate
                {
                    /*0x232c1f4*/ unitytls_tlsctx_set_supported_ciphersuites_t(object object, nint method);
                    /*0x232c254*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232c4cc*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232c570*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_get_ciphersuite_t : System.MulticastDelegate
                {
                    /*0x232abb8*/ unitytls_tlsctx_get_ciphersuite_t(object object, nint method);
                    /*0x232ac18*/ Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232ae68*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232ae98*/ Mono.Unity.UnityTls.unitytls_ciphersuite EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_get_protocol_t : System.MulticastDelegate
                {
                    /*0x232aec4*/ unitytls_tlsctx_get_protocol_t(object object, nint method);
                    /*0x232af24*/ Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232b174*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232b1a4*/ Mono.Unity.UnityTls.unitytls_protocol EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_process_handshake_t : System.MulticastDelegate
                {
                    /*0x232b4b4*/ unitytls_tlsctx_process_handshake_t(object object, nint method);
                    /*0x232b514*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232b764*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232b794*/ Mono.Unity.UnityTls.unitytls_x509verify_result EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_read_t : System.MulticastDelegate
                {
                    /*0x232b7c0*/ unitytls_tlsctx_read_t(object object, nint method);
                    /*0x232b820*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232baa0*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232bb44*/ nint EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_write_t : System.MulticastDelegate
                {
                    /*0x232cbac*/ unitytls_tlsctx_write_t(object object, nint method);
                    /*0x232cc0c*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232ce8c*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232cf30*/ nint EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_notify_close_t : System.MulticastDelegate
                {
                    /*0x232b1d0*/ unitytls_tlsctx_notify_close_t(object object, nint method);
                    /*0x232b230*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x232b478*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x232b4a8*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_tlsctx_free_t : System.MulticastDelegate
                {
                    /*0x232a8f8*/ unitytls_tlsctx_free_t(object object, nint method);
                    /*0x232a958*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx);
                    /*0x232ab88*/ System.IAsyncResult BeginInvoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, System.AsyncCallback callback, object object);
                    /*0x232abac*/ void EndInvoke(System.IAsyncResult result);
                }

                class unitytls_random_generate_bytes_t : System.MulticastDelegate
                {
                    /*0x2329b98*/ unitytls_random_generate_bytes_t(object object, nint method);
                    /*0x2329bf8*/ void Invoke(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                    /*0x2329e5c*/ System.IAsyncResult BeginInvoke(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState, System.AsyncCallback callback, object object);
                    /*0x2329ef8*/ void EndInvoke(System.IAsyncResult result);
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
            /*0x98*/ System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate;
            /*0xa0*/ Mono.Security.Interface.MonoTlsConnectionInfo connectioninfo;
            /*0xa8*/ bool isAuthenticated;
            /*0xa9*/ bool hasContext;
            /*0xaa*/ bool closedGraceful;
            /*0xb0*/ byte[] writeBuffer;
            /*0xb8*/ byte[] readBuffer;
            /*0xc0*/ System.Runtime.InteropServices.GCHandle handle;
            /*0xc8*/ System.Exception lastException;

            static /*0x1875200*/ void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, ref Mono.Unity.UnityTls.unitytls_x509list* nativeCertChain, ref Mono.Unity.UnityTls.unitytls_key* nativeKey);
            static /*0x1874638*/ nint WriteCallback(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x1874704*/ nint ReadCallback(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x18747d0*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x1874884*/ void CertificateCallback(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x1874950*/ UnityTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, bool serverMode, string targetHost, System.Security.Authentication.SslProtocols enabledProtocols, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool askForClientCert);
            /*0x1875538*/ bool get_IsAuthenticated();
            /*0x1875540*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
            /*0x1875548*/ System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
            /*0x1875700*/ System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
            /*0x18758b0*/ void Shutdown();
            /*0x1875998*/ void Dispose(bool disposing);
            /*0x1875a44*/ void StartHandshake();
            /*0x1875bec*/ bool ProcessHandshake();
            /*0x1875d5c*/ void FinishHandshake();
            /*0x1875e90*/ nint WriteCallback(byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x18760f0*/ nint ReadCallback(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x18763e0*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x187673c*/ void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class UnityTlsConversions
        {
            static /*0x1874fc0*/ Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x18750e0*/ Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x1875e70*/ Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol);
            static /*0x18769e4*/ Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x1876db8*/ Mono.Security.Interface.MonoSslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
            static /*0x1876e74*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
        }

        class UnityTlsProvider : Mono.Security.Interface.MonoTlsProvider
        {
            /*0x18778a4*/ UnityTlsProvider();
            /*0x1877000*/ string get_Name();
            /*0x1877044*/ System.Guid get_ID();
            /*0x18770a8*/ bool get_SupportsSslStream();
            /*0x18770b0*/ bool get_SupportsMonoExtensions();
            /*0x18770b8*/ bool get_SupportsConnectionInfo();
            /*0x18770c0*/ bool get_SupportsCleanShutdown();
            /*0x18770c8*/ System.Security.Authentication.SslProtocols get_SupportedProtocols();
            /*0x18770d0*/ Mono.Security.Interface.IMonoSslStream CreateSslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x18770e4*/ Mono.Security.Interface.IMonoSslStream CreateSslStreamInternal(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x1877174*/ bool ValidateCertificate(Mono.Security.Interface.ICertificateValidator2 validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref Mono.Security.Interface.MonoSslPolicyErrors errors, ref int status11);
        }

        class UnityTlsStream : Mono.Net.Security.MobileAuthenticatedStream
        {
            /*0x29f0b04*/ UnityTlsStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Security.Interface.MonoTlsProvider provider);
            /*0x29f0ba8*/ Mono.Net.Security.MobileTlsContext CreateContext(bool serverMode, string targetHost, System.Security.Authentication.SslProtocols enabledProtocols, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool askForClientCert);
        }

        class X509ChainImplUnityTls : System.Security.Cryptography.X509Certificates.X509ChainImpl
        {
            /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
            /*0x18*/ Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain;
            /*0x20*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
            /*0x28*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;

            /*0x171402c*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain);
            /*0x17140ac*/ bool get_IsValid();
            /*0x17140e4*/ Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain();
            /*0x17140ec*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
            /*0x171433c*/ void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
            /*0x1714344*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode);
            /*0x1714434*/ void Reset();
            /*0x1714494*/ void Dispose(bool disposing);
        }
    }

    namespace Net
    {
        class CFObject : System.IDisposable
        {
            /*0x10*/ nint <Handle>k__BackingField;

            static /*0x1d02950*/ nint dlopen(string path, int mode);
            static /*0x1d048dc*/ nint dlsym(nint handle, string symbol);
            static /*0x1d029fc*/ void dlclose(nint handle);
            static /*0x1d029f8*/ nint GetIndirect(nint handle, string symbol);
            static /*0x1d04988*/ nint GetCFObjectHandle(nint handle, string symbol);
            static /*0x1d04ac4*/ nint CFRetain(nint handle);
            static /*0x1d04b40*/ void CFRelease(nint handle);
            /*0x1d02814*/ CFObject(nint handle, bool own);
            /*0x1d04a40*/ void Finalize();
            /*0x1d04ab4*/ nint get_Handle();
            /*0x1d04abc*/ void set_Handle(nint value);
            /*0x1d04a38*/ void Retain();
            /*0x1d04bc0*/ void Release();
            /*0x1d04bc8*/ void Dispose(bool disposing);
            /*0x1d03a88*/ void Dispose();
        }

        class CFArray : Mono.Net.CFObject
        {
            static /*0x0*/ nint kCFTypeArrayCallbacks;

            static /*0x1d02864*/ CFArray();
            static /*0x1d02a7c*/ nint CFArrayGetCount(nint handle);
            static /*0x1d02b68*/ nint CFArrayGetValueAtIndex(nint handle, nint index);
            /*0x1d027c4*/ CFArray(nint handle, bool own);
            /*0x1d02afc*/ int get_Count();
            /*0x1d02bf8*/ nint get_Item(int index);
        }

        class CFNumber : Mono.Net.CFObject
        {
            static /*0x1d047b8*/ bool CFNumberGetValue(nint handle, nint type, ref int value);
            static /*0x1d04858*/ int AsInt32(nint handle);
        }

        struct CFRange
        {
            /*0x10*/ nint Location;
            /*0x18*/ nint Length;

            /*0xadb014*/ CFRange(int loc, int len);
        }

        struct CFStreamClientContext
        {
            /*0x10*/ nint Version;
            /*0x18*/ nint Info;
            /*0x20*/ nint Retain;
            /*0x28*/ nint Release;
            /*0x30*/ nint CopyDescription;
        }

        class CFString : Mono.Net.CFObject
        {
            /*0x18*/ string str;

            static /*0x1d05cc4*/ nint CFStringCreateWithCharacters(nint alloc, nint chars, nint length);
            static /*0x1d03f64*/ Mono.Net.CFString Create(string value);
            static /*0x1d05d5c*/ nint CFStringGetLength(nint handle);
            static /*0x1d05ddc*/ nint CFStringGetCharactersPtr(nint handle);
            static /*0x1d05e5c*/ nint CFStringGetCharacters(nint handle, Mono.Net.CFRange range, nint buffer);
            static /*0x1d052cc*/ string AsString(nint handle);
            /*0x1d05c74*/ CFString(nint handle, bool own);
            /*0x1d05f04*/ string ToString();
        }

        class CFDictionary : Mono.Net.CFObject
        {
            static /*0x0*/ nint KeyCallbacks;
            static /*0x8*/ nint ValueCallbacks;

            static /*0x1d02c80*/ CFDictionary();
            static /*0x1d02dec*/ nint CFDictionaryGetValue(nint handle, nint key);
            /*0x1d02d9c*/ CFDictionary(nint handle, bool own);
            /*0x1d02e7c*/ nint GetValue(nint key);
            /*0x1d02ef0*/ nint get_Item(nint key);
        }

        class CFUrl : Mono.Net.CFObject
        {
            static /*0x1d05f84*/ nint CFURLCreateWithString(nint allocator, nint str, nint baseURL);
            static /*0x1d03c70*/ Mono.Net.CFUrl Create(string absolute);
            /*0x1d05f34*/ CFUrl(nint handle, bool own);
        }

        class CFRunLoop : Mono.Net.CFObject
        {
            static /*0x1d05958*/ void CFRunLoopAddSource(nint rl, nint source, nint mode);
            static /*0x1d059f0*/ void CFRunLoopRemoveSource(nint rl, nint source, nint mode);
            static /*0x1d05a88*/ int CFRunLoopRunInMode(nint mode, double seconds, bool returnAfterSourceHandled);
            static /*0x1d05b28*/ nint CFRunLoopGetCurrent();
            static /*0x1d05b9c*/ void CFRunLoopStop(nint rl);
            static /*0x1d03ef4*/ Mono.Net.CFRunLoop get_CurrentRunLoop();
            /*0x1d05c1c*/ CFRunLoop(nint handle, bool own);
            /*0x1d04034*/ void AddSource(nint source, Mono.Net.CFString mode);
            /*0x1d0406c*/ void RemoveSource(nint source, Mono.Net.CFString mode);
            /*0x1d04050*/ int RunInMode(Mono.Net.CFString mode, double seconds, bool returnAfterSourceHandled);
            /*0x1d05c6c*/ void Stop();
        }

        enum CFProxyType
        {
            None = 0,
            AutoConfigurationUrl = 1,
            AutoConfigurationJavaScript = 2,
            FTP = 3,
            HTTP = 4,
            HTTPS = 5,
            SOCKS = 6,
        }

        class CFProxy
        {
            static /*0x0*/ nint kCFProxyAutoConfigurationJavaScriptKey;
            static /*0x8*/ nint kCFProxyAutoConfigurationURLKey;
            static /*0x10*/ nint kCFProxyHostNameKey;
            static /*0x18*/ nint kCFProxyPasswordKey;
            static /*0x20*/ nint kCFProxyPortNumberKey;
            static /*0x28*/ nint kCFProxyTypeKey;
            static /*0x30*/ nint kCFProxyUsernameKey;
            static /*0x38*/ nint kCFProxyTypeAutoConfigurationURL;
            static /*0x40*/ nint kCFProxyTypeAutoConfigurationJavaScript;
            static /*0x48*/ nint kCFProxyTypeFTP;
            static /*0x50*/ nint kCFProxyTypeHTTP;
            static /*0x58*/ nint kCFProxyTypeHTTPS;
            static /*0x60*/ nint kCFProxyTypeSOCKS;
            /*0x10*/ Mono.Net.CFDictionary settings;

            static /*0x1d04c24*/ CFProxy();
            static /*0x1d04ec4*/ Mono.Net.CFProxyType CFProxyTypeToEnum(nint type);
            /*0x1d03a5c*/ CFProxy(Mono.Net.CFDictionary settings);
            /*0x1d05070*/ nint get_AutoConfigurationJavaScript();
            /*0x1d05138*/ nint get_AutoConfigurationUrl();
            /*0x1d05200*/ string get_HostName();
            /*0x1d05474*/ string get_Password();
            /*0x1d05540*/ int get_Port();
            /*0x1d0560c*/ Mono.Net.CFProxyType get_ProxyType();
            /*0x1d056d8*/ string get_Username();
        }

        class CFProxySettings
        {
            static /*0x0*/ nint kCFNetworkProxiesHTTPEnable;
            static /*0x8*/ nint kCFNetworkProxiesHTTPPort;
            static /*0x10*/ nint kCFNetworkProxiesHTTPProxy;
            static /*0x18*/ nint kCFNetworkProxiesProxyAutoConfigEnable;
            static /*0x20*/ nint kCFNetworkProxiesProxyAutoConfigJavaScript;
            static /*0x28*/ nint kCFNetworkProxiesProxyAutoConfigURLString;
            /*0x10*/ Mono.Net.CFDictionary settings;

            static /*0x1d057a4*/ CFProxySettings();
            /*0x1d046c0*/ CFProxySettings(Mono.Net.CFDictionary settings);
            /*0x1d05910*/ Mono.Net.CFDictionary get_Dictionary();
        }

        class CFNetwork
        {
            static /*0x0*/ object lock_obj;
            static /*0x8*/ System.Collections.Generic.Queue<Mono.Net.CFNetwork.GetProxyData> get_proxy_queue;
            static /*0x10*/ System.Threading.AutoResetEvent proxy_event;

            static /*0x1d04744*/ CFNetwork();
            static /*0x1d02ef4*/ nint CFNetworkCopyProxiesForAutoConfigurationScriptSequential(nint proxyAutoConfigurationScript, nint targetURL, ref nint error);
            static /*0x1d02f8c*/ nint CFNetworkExecuteProxyAutoConfigurationURL(nint proxyAutoConfigURL, nint targetURL, Mono.Net.CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref Mono.Net.CFStreamClientContext clientContext);
            static /*0x1d0303c*/ void CFNetworkCopyProxiesForAutoConfigurationScriptThread();
            static /*0x1d032f0*/ nint CFNetworkCopyProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, nint targetURL, ref nint error);
            static /*0x1d0374c*/ Mono.Net.CFArray CopyProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, Mono.Net.CFUrl targetURL);
            static /*0x1d03828*/ Mono.Net.CFProxy[] GetProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, Mono.Net.CFUrl targetURL);
            static /*0x1d03b00*/ Mono.Net.CFProxy[] GetProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, System.Uri targetUri);
            static /*0x1d03d38*/ Mono.Net.CFProxy[] ExecuteProxyAutoConfigurationURL(nint proxyAutoConfigURL, System.Uri targetURL);
            static /*0x1d04088*/ nint CFNetworkCopyProxiesForURL(nint url, nint proxySettings);
            static /*0x1d04118*/ Mono.Net.CFArray CopyProxiesForURL(Mono.Net.CFUrl url, Mono.Net.CFDictionary proxySettings);
            static /*0x1d041f4*/ Mono.Net.CFProxy[] GetProxiesForURL(Mono.Net.CFUrl url, Mono.Net.CFProxySettings proxySettings);
            static /*0x1d04520*/ Mono.Net.CFProxy[] GetProxiesForUri(System.Uri uri, Mono.Net.CFProxySettings proxySettings);
            static /*0x1d0464c*/ nint CFNetworkCopySystemProxySettings();
            static /*0x1d0443c*/ Mono.Net.CFProxySettings GetSystemProxySettings();
            static /*0x1d046ec*/ System.Net.IWebProxy GetDefaultProxy();

            class GetProxyData : System.IDisposable
            {
                /*0x10*/ nint script;
                /*0x18*/ nint targetUri;
                /*0x20*/ nint error;
                /*0x28*/ nint result;
                /*0x30*/ System.Threading.ManualResetEvent evt;

                /*0x1478d08*/ GetProxyData();
                /*0x1478ce8*/ void Dispose();
            }

            class CFProxyAutoConfigurationResultCallback : System.MulticastDelegate
            {
                /*0x147813c*/ CFProxyAutoConfigurationResultCallback(object object, nint method);
                /*0x147819c*/ void Invoke(nint client, nint proxyList, nint error);
                /*0x14783f8*/ System.IAsyncResult BeginInvoke(nint client, nint proxyList, nint error, System.AsyncCallback callback, object object);
                /*0x14784ac*/ void EndInvoke(System.IAsyncResult result);
            }

            class CFWebProxy : System.Net.IWebProxy
            {
                /*0x10*/ System.Net.ICredentials credentials;
                /*0x18*/ bool userSpecified;

                static /*0x14784c8*/ System.Uri GetProxyUri(Mono.Net.CFProxy proxy, ref System.Net.NetworkCredential credentials);
                static /*0x14786ac*/ System.Uri GetProxyUriFromScript(nint script, System.Uri targetUri, ref System.Net.NetworkCredential credentials);
                static /*0x14787fc*/ System.Uri ExecuteProxyAutoConfigurationURL(nint proxyAutoConfigURL, System.Uri targetUri, ref System.Net.NetworkCredential credentials);
                static /*0x1478730*/ System.Uri SelectProxy(Mono.Net.CFProxy[] proxies, System.Uri targetUri, ref System.Net.NetworkCredential credentials);
                /*0x14784b8*/ CFWebProxy();
                /*0x14784c0*/ System.Net.ICredentials get_Credentials();
                /*0x1478880*/ System.Uri GetProxy(System.Uri targetUri);
                /*0x1478bec*/ bool IsBypassed(System.Uri targetUri);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ Mono.Net.CFProxy[] proxies;
                /*0x18*/ Mono.Net.CFRunLoop runLoop;

                /*0x1477f64*/ <>c__DisplayClass13_0();
                /*0x1477f6c*/ void <ExecuteProxyAutoConfigurationURL>b__0(nint client, nint proxyList, nint error);
            }
        }

        namespace Security
        {
            class BufferOffsetSize
            {
                /*0x10*/ byte[] Buffer;
                /*0x18*/ int Offset;
                /*0x1c*/ int Size;
                /*0x20*/ int TotalBytes;
                /*0x24*/ bool Complete;

                /*0x1cfca54*/ BufferOffsetSize(byte[] buffer, int offset, int size);
                /*0x1d00ae8*/ int get_EndOffset();
                /*0x1d00af4*/ int get_Remaining();
                /*0x1d00b1c*/ string ToString();
            }

            class BufferOffsetSize2 : Mono.Net.Security.BufferOffsetSize
            {
                /*0x28*/ int InitialSize;

                /*0x1d00c90*/ BufferOffsetSize2(int size);
                /*0x1d00d04*/ void Reset();
                /*0x1d00d8c*/ void MakeRoom(int size);
                /*0x1d00e4c*/ void AppendData(byte[] buffer, int offset, int size);
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

                /*0x1cfc944*/ AsyncProtocolResult(int result);
                /*0x1cfc970*/ AsyncProtocolResult(System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x1cfc934*/ int get_UserResult();
                /*0x1cfc93c*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
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

                /*0x1cfc39c*/ AsyncProtocolRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x1cfc43c*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x1cfc444*/ bool get_RunSynchronously();
                /*0x1cfc44c*/ string get_Name();
                /*0x1cfc474*/ int get_UserResult();
                /*0x1cfc47c*/ void set_UserResult(int value);
                /*0x1cfc484*/ void RequestRead(int size);
                /*0x1cfc550*/ void RequestWrite();
                /*0x1cfc55c*/ System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken);
                /*0x1cfc688*/ System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken);
                /*0x1cfc79c*/ System.Threading.Tasks.Task<System.Nullable<int>> InnerRead(System.Threading.CancellationToken cancellationToken);
                Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
                /*0x1cfc8d8*/ string ToString();

                struct <StartOperation>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Mono.Net.Security.AsyncProtocolResult> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xaa208c*/ void MoveNext();
                    /*0xaa2094*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessOperation>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x40*/ Mono.Net.Security.AsyncOperationStatus <status>5__1;
                    /*0x44*/ Mono.Net.Security.AsyncOperationStatus <newStatus>5__2;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Nullable<int>> <>u__1;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0xaa2078*/ void MoveNext();
                    /*0xaa2080*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerRead>d__25 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<int>> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ int <requestedSize>5__1;
                    /*0x44*/ System.Nullable<int> <totalRead>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                    /*0xaa2068*/ void MoveNext();
                    /*0xaa2070*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AsyncHandshakeRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x1cfc394*/ AsyncHandshakeRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x1cfc420*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncReadOrWriteRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x38*/ Mono.Net.Security.BufferOffsetSize <UserBuffer>k__BackingField;
                /*0x40*/ int <CurrentSize>k__BackingField;

                /*0x1cfc9b4*/ AsyncReadOrWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x1cfc99c*/ Mono.Net.Security.BufferOffsetSize get_UserBuffer();
                /*0x1cfc9a4*/ int get_CurrentSize();
                /*0x1cfc9ac*/ void set_CurrentSize(int value);
                /*0x1cfcb50*/ string ToString();
            }

            class AsyncReadRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x1cfcbb0*/ AsyncReadRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x1cfcbb8*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncWriteRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x1cfcc48*/ AsyncWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x1cfcc50*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class ServerCertValidationCallbackWrapper : System.MulticastDelegate
            {
                /*0x185af70*/ ServerCertValidationCallbackWrapper(object object, nint method);
                /*0x185afd0*/ bool Invoke(System.Net.ServerCertValidationCallback callback, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors);
                /*0x185b3b4*/ System.IAsyncResult BeginInvoke(System.Net.ServerCertValidationCallback callback, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors, System.AsyncCallback __callback, object object);
                /*0x185b460*/ bool EndInvoke(System.IAsyncResult result);
            }

            class ChainValidationHelper : Mono.Security.Interface.ICertificateValidator2, Mono.Security.Interface.ICertificateValidator
            {
                /*0x10*/ object sender;
                /*0x18*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x20*/ Mono.Security.Interface.MonoTlsProvider provider;
                /*0x28*/ System.Net.ServerCertValidationCallback certValidationCallback;
                /*0x30*/ System.Net.Security.LocalCertSelectionCallback certSelectionCallback;
                /*0x38*/ Mono.Net.Security.ServerCertValidationCallbackWrapper callbackWrapper;
                /*0x40*/ Mono.Net.Security.MonoTlsStream tlsStream;
                /*0x48*/ System.Net.HttpWebRequest request;

                static /*0x1d070f4*/ Mono.Security.Interface.ICertificateValidator GetInternalValidator(Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x1d07420*/ Mono.Net.Security.ChainValidationHelper Create(Mono.Security.Interface.MonoTlsProvider provider, ref Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MonoTlsStream stream);
                static /*0x1d074b8*/ System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x1d07198*/ ChainValidationHelper(Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, bool cloneSettings, Mono.Net.Security.MonoTlsStream stream, Mono.Net.Security.ServerCertValidationCallbackWrapper callbackWrapper);
                /*0x1d07504*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x1d0750c*/ bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, ref System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
                /*0x1d0754c*/ Mono.Security.Interface.ValidationResult ValidateCertificate(string host, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x1d07634*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x1d07718*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, ref System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
            }

            class MobileAuthenticatedStream : System.Net.Security.AuthenticatedStream, Mono.Security.Interface.IMonoSslStream, System.IDisposable
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
                /*0x80*/ System.Net.Security.SslStream <SslStream>k__BackingField;
                /*0x88*/ Mono.Security.Interface.MonoTlsSettings <Settings>k__BackingField;
                /*0x90*/ Mono.Security.Interface.MonoTlsProvider <Provider>k__BackingField;
                /*0x98*/ int ID;

                static /*0x1cc4088*/ MobileAuthenticatedStream();
                static /*0x1cc2350*/ System.Exception GetSSPIException(System.Exception e);
                static /*0x1cc24b0*/ System.Exception GetIOException(System.Exception e, string message);
                /*0x1cc2140*/ MobileAuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Security.Interface.MonoTlsProvider provider);
                /*0x1cc2274*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x1cc227c*/ Mono.Security.Interface.MonoTlsProvider get_Provider();
                /*0x1cc2284*/ void CheckThrow(bool authSuccessCheck, bool shutdownCheck);
                /*0x1cc2608*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e);
                /*0x1cc264c*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x1cc27fc*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x1cc2834*/ System.Net.Security.AuthenticatedStream get_AuthenticatedStream();
                /*0x1cc2690*/ System.Threading.Tasks.Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, System.Security.Authentication.SslProtocols enabledProtocols, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool clientCertRequired);
                Mono.Net.Security.MobileTlsContext CreateContext(bool serverMode, string targetHost, System.Security.Authentication.SslProtocols enabledProtocols, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool askForClientCert);
                /*0x1cc2838*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x1cc2a78*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x1cc2ac4*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x1cc2bb0*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x1cc2bbc*/ int Read(byte[] buffer, int offset, int count);
                /*0x1cc2cac*/ void Write(byte[] buffer, int offset, int count);
                /*0x1cc2d88*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x1cc2e24*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x1cc2924*/ System.Threading.Tasks.Task<int> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken);
                /*0x1cc2ec0*/ int InternalRead(byte[] buffer, int offset, int size, ref bool outWantMore);
                /*0x1cc2ffc*/ System.ValueTuple<int, bool> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size);
                /*0x1cc318c*/ bool InternalWrite(byte[] buffer, int offset, int size);
                /*0x1cc32b4*/ bool InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size);
                /*0x1cc33b8*/ System.Threading.Tasks.Task<int> InnerRead(bool sync, int requestedSize, System.Threading.CancellationToken cancellationToken);
                /*0x1cc3514*/ System.Threading.Tasks.Task InnerWrite(bool sync, System.Threading.CancellationToken cancellationToken);
                /*0x1cc3640*/ Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status);
                /*0x1cc3838*/ System.ValueTuple<int, bool> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x1cc394c*/ System.ValueTuple<int, bool> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x1cc3a60*/ bool get_IsAuthenticated();
                /*0x1cc3b50*/ void Dispose(bool disposing);
                /*0x1cc3d68*/ void Flush();
                /*0x1cc3d8c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate();
                /*0x1cc3e98*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x1cc3ed8*/ bool get_CanRead();
                /*0x1cc3f2c*/ bool get_CanWrite();
                /*0x1cc3f94*/ bool get_CanSeek();
                /*0x1cc3f9c*/ long get_Length();
                /*0x1cc3fbc*/ long get_Position();
                /*0x1cc3fdc*/ void set_Position(long value);
                /*0x1cc401c*/ int get_ReadTimeout();
                /*0x1cc4040*/ void set_ReadTimeout(int value);
                /*0x1cc4064*/ int get_WriteTimeout();
                /*0x1cc40d8*/ void <InnerWrite>b__67_0();

                enum OperationType
                {
                    Read = 0,
                    Write = 1,
                    Shutdown = 2,
                }

                struct <ProcessAuthentication>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ bool serverMode;
                    /*0x38*/ System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate;
                    /*0x40*/ string targetHost;
                    /*0x48*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x50*/ bool runSynchronously;
                    /*0x54*/ System.Security.Authentication.SslProtocols enabledProtocols;
                    /*0x58*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates;
                    /*0x60*/ bool clientCertRequired;
                    /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Mono.Net.Security.AsyncProtocolResult> <>u__1;

                    /*0xaa2344*/ void MoveNext();
                    /*0xaa234c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <StartOperation>d__58 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream.OperationType type;
                    /*0x40*/ Mono.Net.Security.AsyncProtocolRequest asyncRequest;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Mono.Net.Security.AsyncProtocolResult> <>u__1;

                    /*0xaa2358*/ void MoveNext();
                    /*0xaa2360*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass66_0
                {
                    /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x18*/ int len;

                    /*0x148207c*/ <>c__DisplayClass66_0();
                    /*0x1482084*/ int <InnerRead>b__0();
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

                    /*0xaa2320*/ void MoveNext();
                    /*0xaa2328*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerWrite>d__67 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xaa2330*/ void MoveNext();
                    /*0xaa2338*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class MobileTlsContext : System.IDisposable
            {
                /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream parent;
                /*0x18*/ bool serverMode;
                /*0x20*/ string targetHost;
                /*0x28*/ string serverName;
                /*0x30*/ System.Security.Authentication.SslProtocols enabledProtocols;
                /*0x38*/ System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate;
                /*0x40*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates;
                /*0x48*/ bool askForClientCert;
                /*0x50*/ Mono.Security.Interface.ICertificateValidator2 certificateValidator;

                /*0x1cc4110*/ MobileTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, bool serverMode, string targetHost, System.Security.Authentication.SslProtocols enabledProtocols, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool askForClientCert);
                /*0x1cc423c*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x1cc4244*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                bool get_IsAuthenticated();
                /*0x1cc4260*/ bool get_IsServer();
                /*0x1cc4268*/ string get_TargetHost();
                /*0x1cc4270*/ string get_ServerName();
                /*0x1cc4278*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                void StartHandshake();
                bool ProcessHandshake();
                void FinishHandshake();
                /*0x1cc4280*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate();
                System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
                System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
                System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
                void Shutdown();
                /*0x1cc4288*/ bool ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x1cc438c*/ System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string[] acceptableIssuers);
                /*0x1cc3cec*/ void Dispose();
                /*0x1cc4508*/ void Dispose(bool disposing);
                /*0x1cc450c*/ void Finalize();
            }

            class MonoTlsProviderFactory
            {
                static /*0x0*/ object locker;
                static /*0x8*/ bool initialized;
                static /*0x10*/ Mono.Security.Interface.MonoTlsProvider defaultProvider;
                static /*0x18*/ System.Collections.Generic.Dictionary<string, System.Tuple<System.Guid, string>> providerRegistration;
                static /*0x20*/ System.Collections.Generic.Dictionary<System.Guid, Mono.Security.Interface.MonoTlsProvider> providerCache;
                static /*0x28*/ System.Guid UnityTlsId;
                static /*0x38*/ System.Guid AppleTlsId;
                static /*0x48*/ System.Guid BtlsId;
                static /*0x58*/ System.Guid LegacyId;

                static /*0x1cc6690*/ MonoTlsProviderFactory();
                static /*0x1cc55e8*/ Mono.Security.Interface.MonoTlsProvider GetProviderInternal();
                static /*0x1cc571c*/ void InitializeInternal();
                static /*0x1cc603c*/ Mono.Security.Interface.MonoTlsProvider LookupProvider(string name, bool throwOnError);
                static /*0x1cc5aec*/ void InitializeProviderRegistration();
                static /*0x1cc5f8c*/ Mono.Security.Interface.MonoTlsProvider CreateDefaultProviderImpl();
                static /*0x1cc65e8*/ Mono.Security.Interface.MonoTlsProvider GetProvider();
            }

            class MonoTlsStream
            {
                /*0x10*/ Mono.Security.Interface.MonoTlsProvider provider;
                /*0x18*/ System.Net.Sockets.NetworkStream networkStream;
                /*0x20*/ System.Net.HttpWebRequest request;
                /*0x28*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x30*/ Mono.Security.Interface.IMonoSslStream sslStream;
                /*0x38*/ System.Net.WebExceptionStatus status;
                /*0x3c*/ bool <CertificateValidationFailed>k__BackingField;

                /*0x1cc6810*/ MonoTlsStream(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream);
                /*0x1cc67ec*/ System.Net.HttpWebRequest get_Request();
                /*0x1cc67f4*/ System.Net.WebExceptionStatus get_ExceptionStatus();
                /*0x1cc67fc*/ bool get_CertificateValidationFailed();
                /*0x1cc6804*/ void set_CertificateValidationFailed(bool value);
                /*0x1cc68c4*/ System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken);

                struct <CreateStream>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoTlsStream <>4__this;
                    /*0x38*/ System.Net.Sockets.Socket <socket>5__1;
                    /*0x40*/ System.Net.WebConnectionTunnel tunnel;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0xaa2368*/ void MoveNext();
                    /*0xaa2370*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NoReflectionHelper
            {
                static /*0x1ccbae8*/ object GetInternalValidator(object provider, object settings);
            }

            class SystemCertificateValidator
            {
                static /*0x0*/ bool is_macosx;
                static /*0x4*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;

                static /*0x18686dc*/ SystemCertificateValidator();
                static /*0x1868780*/ System.Security.Cryptography.X509Certificates.X509Chain CreateX509Chain(System.Security.Cryptography.X509Certificates.X509CertificateCollection certs);
                static /*0x1868878*/ bool NeedsChain(Mono.Security.Interface.MonoTlsSettings settings);
            }

            namespace Private
            {
                class CallbackHelpers
                {
                    static /*0x1d06094*/ System.Net.Security.RemoteCertificateValidationCallback MonoToPublic(Mono.Security.Interface.MonoRemoteCertificateValidationCallback callback);
                    static /*0x1d06144*/ System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback);

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback callback;

                        /*0x1478d70*/ <>c__DisplayClass5_0();
                        /*0x1478d78*/ bool <MonoToPublic>b__0(object t, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, System.Net.Security.SslPolicyErrors e);
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback;

                        /*0x1478d98*/ <>c__DisplayClass8_0();
                        /*0x1478da0*/ System.Security.Cryptography.X509Certificates.X509Certificate <MonoToInternal>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
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

            /*0x1eb2ba4*/ NtlmSession();
            /*0x1eb2480*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession> cache;

            static /*0x1eb2980*/ NtlmClient();
            /*0x1eb2978*/ NtlmClient();
            /*0x1eb20c4*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1eb292c*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1eb2934*/ string get_AuthenticationType();

            class <>c
            {
                static /*0x0*/ Mono.Http.NtlmClient.<> <>9;
                static /*0x8*/ System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<System.Net.HttpWebRequest, Mono.Http.NtlmSession> <>9__1_0;

                static /*0x14847b4*/ <>c();
                /*0x1484814*/ <>c();
                /*0x148481c*/ Mono.Http.NtlmSession <Authenticate>b__1_0(System.Net.HttpWebRequest x);
            }
        }
    }
}

namespace System
{
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

        /*0x16fd518*/ UriBuilder();
        /*0x16fd648*/ void set_Host(string value);
        /*0x16fd740*/ void set_Path(string value);
        /*0x16fd808*/ void set_Scheme(string value);
        /*0x16fd960*/ System.Uri get_Uri();
        /*0x16fdb80*/ bool Equals(object rparam);
        /*0x16fdbe0*/ int GetHashCode();
        /*0x16fda08*/ void SetFieldsFromUri(System.Uri uri);
        /*0x16fdc04*/ string ToString();
    }

    class SecurityUtils
    {
        static /*0x185a854*/ void DemandReflectionAccess(System.Type type);
        static /*0x185a858*/ void DemandGrantSet(System.Reflection.Assembly assembly);
        static /*0x185a85c*/ bool HasReflectionPermission(System.Type type);
        static /*0x185a864*/ object SecureCreateInstance(System.Type type);
        static /*0x185a870*/ object SecureCreateInstance(System.Type type, object[] args, bool allowNonPublic);
        static /*0x185a970*/ object SecureCreateInstance(System.Type type, object[] args);
        static /*0x185a978*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic);
        static /*0x185a984*/ object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic, System.Reflection.BindingFlags extraFlags);
        static /*0x185ab0c*/ bool GenericArgumentsAreVisible(System.Reflection.MethodInfo method);
        static /*0x185abb8*/ object MethodInfoInvoke(System.Reflection.MethodInfo method, object target, object[] args);
    }

    class InvariantComparer : System.Collections.IComparer
    {
        static /*0x0*/ System.InvariantComparer Default;
        /*0x10*/ System.Globalization.CompareInfo m_compareInfo;

        static /*0x1cbbfc8*/ InvariantComparer();
        /*0x1cbbe48*/ InvariantComparer();
        /*0x1cbbed0*/ int Compare(object a, object b);
    }

    class IriHelper
    {
        static /*0x1cbc09c*/ bool CheckIriUnicodeRange(char unicode, bool isQuery);
        static /*0x1cbc0f4*/ bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery);
        static /*0x1cbc738*/ bool CheckIsReserved(char ch, System.UriComponents component);
        static /*0x1cbc898*/ string EscapeUnescapeIri(char* pInput, int start, int end, System.UriComponents component);
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

        static /*0x29fdd1c*/ Uri();
        static /*0x29f0d0c*/ bool IriParsingStatic(System.UriParser syntax);
        static /*0x29f0f78*/ bool StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x29f101c*/ bool StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x29f34d4*/ System.ParsingError GetCombinedString(System.Uri baseUri, string relativeStr, bool dontEscape, ref string result);
        static /*0x29f4350*/ System.UriFormatException GetException(System.ParsingError err);
        static /*0x29f5530*/ bool StaticIsFile(System.UriParser syntax);
        static /*0x29f554c*/ object get_InitializeLock();
        static /*0x29f5634*/ void InitializeUriConfig();
        static /*0x29f6440*/ bool IsGenDelim(char ch);
        static /*0x29f648c*/ bool CheckSchemeName(string schemeName);
        static /*0x29f6694*/ bool IsHexDigit(char character);
        static /*0x29f66d0*/ int FromHex(char digit);
        static /*0x29f6c84*/ bool op_Equality(System.Uri uri1, System.Uri uri2);
        static /*0x29f3130*/ bool op_Inequality(System.Uri uri1, System.Uri uri2);
        static /*0x29f7310*/ string InternalEscapeString(string rawString);
        static /*0x29f73fc*/ System.ParsingError ParseScheme(string uriString, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x29f9624*/ string CreateHostStringHelper(string str, ushort idx, ushort end, ref System.Uri.Flags flags, ref string scopeId);
        static /*0x29f74e8*/ ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x29fbafc*/ bool CheckKnownSchemes(long* lptr, ushort nChars, ref System.UriParser syntax);
        static /*0x29f3738*/ System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref System.UriParser syntax);
        static /*0x29fc970*/ void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3);
        static /*0x29f5800*/ char[] Compress(char[] dest, ushort start, ref int destLength, System.UriParser syntax);
        static /*0x29f68d8*/ int CalculateCaseInsensitiveHashCode(string text);
        static /*0x29f38b0*/ string CombineUri(System.Uri basePart, string relativePart, System.UriFormat uriFormat);
        static /*0x29f81a8*/ bool IsLWS(char ch);
        static /*0x29f65e0*/ bool IsAsciiLetter(char character);
        static /*0x29f660c*/ bool IsAsciiLetterOrDigit(char character);
        static /*0x29fcbb8*/ bool IsBidiControlCharacter(char ch);
        static /*0x29fc73c*/ string StripBidiControlCharacter(char* strToClean, int start, int length);
        static /*0x29f723c*/ bool TryCreate(string uriString, System.UriKind uriKind, ref System.Uri result);
        static /*0x29fd9e8*/ string UnescapeDataString(string stringToUnescape);
        static /*0x29fdba0*/ string EscapeDataString(string stringToEscape);
        static /*0x29fd520*/ System.Uri CreateHelper(string uriString, bool dontEscape, System.UriKind uriKind, ref System.UriFormatException e);
        static /*0x29f2c30*/ System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, ref string newUriString, ref bool userEscaped, ref System.UriFormatException e);
        /*0x29f26d4*/ Uri(string uriString);
        /*0x29f2924*/ Uri(string uriString, System.UriKind uriKind);
        /*0x29f29b4*/ Uri(System.Uri baseUri, string relativeUri);
        /*0x29f32a8*/ Uri(System.Uri baseUri, System.Uri relativeUri);
        /*0x29f44ec*/ Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x29fdcd8*/ Uri(System.Uri.Flags flags, System.UriParser uriParser, string uri);
        /*0x29f0cb4*/ bool get_IsImplicitFile();
        /*0x29f0cc0*/ bool get_IsUncOrDosPath();
        /*0x29f0cd0*/ bool get_IsDosPath();
        /*0x29f0cdc*/ bool get_IsUncPath();
        /*0x29f0ce8*/ System.Uri.Flags get_HostType();
        /*0x29f0cf4*/ System.UriParser get_Syntax();
        /*0x29f0cfc*/ bool get_IsNotAbsoluteUri();
        /*0x29f0da4*/ bool get_AllowIdn();
        /*0x29f0e8c*/ bool AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags);
        /*0x29f0f84*/ bool IsIntranet(string schemeHost);
        /*0x29f0f8c*/ bool get_UserDrivenParsing();
        /*0x29f0f98*/ void SetUserDrivenParsing();
        /*0x29f0fac*/ ushort get_SecuredPathIndex();
        /*0x29f0e7c*/ bool NotAny(System.Uri.Flags flags);
        /*0x29f100c*/ bool InFact(System.Uri.Flags flags);
        /*0x29f1028*/ System.Uri.UriInfo EnsureUriInfo();
        /*0x29f1604*/ void EnsureParseRemaining();
        /*0x29f2244*/ void EnsureHostString(bool allowDnsOptimization);
        /*0x29f2a90*/ void CreateUri(System.Uri baseUri, string relativeUri, bool dontEscape);
        /*0x29f45f8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x29f45fc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x29f46e4*/ string get_AbsolutePath();
        /*0x29f47a8*/ string get_PrivateAbsolutePath();
        /*0x29f485c*/ string get_AbsoluteUri();
        /*0x29f4964*/ string get_LocalPath();
        /*0x29f500c*/ string get_Authority();
        /*0x29f507c*/ System.UriHostNameType get_HostNameType();
        /*0x29f5180*/ bool get_IsDefaultPort();
        /*0x29f5234*/ bool get_IsFile();
        /*0x29f5300*/ bool get_IsLoopback();
        /*0x29f5384*/ string get_PathAndQuery();
        /*0x29f5450*/ bool get_IsUnc();
        /*0x29f54c0*/ string get_Host();
        /*0x29f49cc*/ string GetLocalPath();
        /*0x29f5dbc*/ int get_Port();
        /*0x29f5e8c*/ string get_Query();
        /*0x29f5f98*/ string get_Fragment();
        /*0x29f60a4*/ string get_Scheme();
        /*0x29f6110*/ bool get_OriginalStringSwitched();
        /*0x29f387c*/ string get_OriginalString();
        /*0x29f6164*/ string get_DnsSafeHost();
        /*0x29f2a80*/ bool get_IsAbsoluteUri();
        /*0x29f63c4*/ bool get_UserEscaped();
        /*0x29f63d0*/ string get_UserInfo();
        /*0x29f6784*/ int GetHashCode();
        /*0x29f6994*/ string ToString();
        /*0x29f6cbc*/ bool Equals(object comparand);
        /*0x29f7a40*/ System.UriFormatException ParseMinimal();
        /*0x29f7acc*/ System.ParsingError PrivateParseMinimal();
        /*0x29f90c8*/ void PrivateParseMinimalIri(string newHost, ushort idx);
        /*0x29f1058*/ void CreateUriInfo(System.Uri.Flags cF);
        /*0x29f22a8*/ void CreateHostString();
        /*0x29f91a8*/ void GetHostViaCustomSyntax();
        /*0x29f46e0*/ string GetParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x29f9e38*/ string GetEscapedParts(System.UriComponents uriParts);
        /*0x29f5ce8*/ string GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x29fa4c4*/ string ReCreateParts(System.UriComponents parts, ushort nonCanonical, System.UriFormat formatAs);
        /*0x29f9f10*/ string GetUriPartsFromUserString(System.UriComponents uriParts);
        /*0x29f1614*/ void ParseRemaining();
        /*0x29f81e8*/ ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, System.UriParser syntax, ref string newHost);
        /*0x29fc0e8*/ void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, System.UriParser syntax, string userInfoString, ref System.Uri.Flags flags, ref bool justNormalized, ref string newHost, ref System.ParsingError err);
        /*0x29fc46c*/ void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, System.UriParser syntax, ref System.Uri.Flags flags, ref string newHost, ref System.ParsingError err);
        /*0x29fba48*/ void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim);
        /*0x29fc8d8*/ void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim);
        /*0x29f984c*/ System.Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim);
        /*0x29fb38c*/ char[] GetCanonicalPath(char[] dest, ref int pos, System.UriFormat formatAs);
        /*0x29fcbac*/ bool get_HasAuthority();
        /*0x29f2758*/ void CreateThis(string uri, bool dontEscape, System.UriKind uriKind);
        /*0x29fcc00*/ void InitializeUri(System.ParsingError err, System.UriKind uriKind, ref System.UriFormatException e);
        /*0x29fd160*/ bool CheckForConfigLoad(string data);
        /*0x29fd214*/ bool CheckForUnicode(string data);
        /*0x29fd348*/ bool CheckForEscapedUnreserved(string data);
        /*0x29f9c68*/ string GetComponents(System.UriComponents components, System.UriFormat format);
        /*0x29fbaa8*/ string EscapeUnescapeIri(string input, int start, int end, System.UriComponents component);
        /*0x29fd7a8*/ string GetRelativeSerializationString(System.UriFormat format);
        /*0x29f6a64*/ string GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x29f317c*/ void CreateThisFromUri(System.Uri otherUri);

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

            /*0x148e9f4*/ UriInfo();
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

            /*0x148e9ec*/ MoreInfo();
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
        /*0x16fe224*/ UriFormatException();
        /*0x16fe110*/ UriFormatException(string textString);
        /*0x16fe22c*/ UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x16fe234*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

        static /*0x16ffe74*/ UriHelper();
        static /*0x16fe23c*/ char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd);
        static /*0x16fe7b8*/ char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos);
        static /*0x16fecf0*/ char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x16fedd4*/ char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x16ff870*/ void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing);
        static /*0x16fe8e0*/ void EscapeAsciiChar(char ch, char[] to, ref int pos);
        static /*0x16fea20*/ char EscapedAscii(char digit, char next);
        static /*0x16ff7e4*/ bool IsNotSafeForUnescape(char ch);
        static /*0x16febd4*/ bool IsReservedUnreservedOrHash(char c);
        static /*0x16feae0*/ bool IsUnreserved(char c);
        static /*0x16ffdcc*/ bool Is3986Unreserved(char c);
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

        static /*0x1700370*/ UriParser();
        static /*0x16ffd60*/ bool get_ShouldUseLegacyV2Quirks();
        static /*0x1700c60*/ System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme);
        static /*0x16fe118*/ System.UriParser GetSyntax(string lwrCaseScheme);
        /*0x1700bf0*/ UriParser(System.UriSyntaxFlags flags);
        /*0x16fff04*/ string get_SchemeName();
        /*0x16fff0c*/ int get_DefaultPort();
        /*0x16fff14*/ System.UriParser OnNewUri();
        /*0x16fff18*/ void InitializeAndValidate(System.Uri uri, ref System.UriFormatException parsingError);
        /*0x16fff4c*/ string Resolve(System.Uri baseUri, System.Uri relativeUri, ref System.UriFormatException parsingError);
        /*0x1700148*/ string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format);
        /*0x1700b80*/ System.UriSyntaxFlags get_Flags();
        /*0x16fe21c*/ bool NotAny(System.UriSyntaxFlags flags);
        /*0x16fe1fc*/ bool InFact(System.UriSyntaxFlags flags);
        /*0x1700be8*/ bool IsAllSet(System.UriSyntaxFlags flags);
        /*0x1700b88*/ bool IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected);
        /*0x1700f68*/ bool get_IsSimple();
        /*0x1700f74*/ System.UriParser InternalOnNewUri();
        /*0x1700fc4*/ void InternalValidate(System.Uri thisUri, ref System.UriFormatException parsingError);
        /*0x1700fd0*/ string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, ref System.UriFormatException parsingError);
        /*0x1700fdc*/ string InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat);

        enum UriQuirksVersion
        {
            V2 = 2,
            V3 = 3,
        }

        class BuiltInUriParser : System.UriParser
        {
            /*0x148e9fc*/ BuiltInUriParser(string lwrCaseScheme, int defaultPort, System.UriSyntaxFlags syntaxFlags);
        }
    }

    class DomainNameHelper
    {
        static /*0x17d7608*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x17d77b4*/ bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x17d79e0*/ bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x17d7bc8*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x17d7e6c*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost);
        static /*0x17d80c0*/ bool IsIdnAce(string input, int index);
        static /*0x17d8074*/ bool IsIdnAce(char* input, int index);
        static /*0x17d815c*/ string UnicodeEquivalent(string idnHost, char* hostname, int start, int end);
        static /*0x17d8280*/ string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x17d7930*/ bool IsASCIILetterOrDigit(char character, ref bool notCanonical);
        static /*0x17d797c*/ bool IsValidDomainLabelCharacter(char character, ref bool notCanonical);
    }

    class IPv4AddressHelper
    {
        static /*0x1cb9b44*/ string ParseCanonicalName(string str, int start, int end, ref bool isLoopback);
        static /*0x1cb9e58*/ int ParseHostNumber(string str, int start, int end);
        static /*0x1cb9f48*/ bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme);
        static /*0x1cb9f7c*/ bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile);
        static /*0x1cb8154*/ long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile);
        static /*0x1cb9dc8*/ bool Parse(string name, byte* numbers, int start, int end);
        static /*0x1cb9e8c*/ bool ParseCanonical(string name, byte* numbers, int start, int end);
    }

    class IPv6AddressHelper
    {
        static /*0x1cba204*/ string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId);
        static /*0x1cba2d0*/ string CreateCanonicalName(ushort* numbers);
        static /*0x1cba95c*/ System.Collections.Generic.KeyValuePair<int, int> FindCompressionRange(ushort* numbers);
        static /*0x1cbaa30*/ bool ShouldHaveIpv4Embedded(ushort* numbers);
        static /*0x1cbaac0*/ bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress);
        static /*0x1cbad90*/ bool IsValid(char* name, int start, ref int end);
        static /*0x1cb7c64*/ bool IsValidStrict(char* name, int start, ref int end);
        static /*0x1cb7c6c*/ bool Parse(string address, ushort* numbers, int start, ref string scopeId);
    }

    class UncNameHelper
    {
        static /*0x1874238*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x1874240*/ bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile);
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
        /*0x1cb6d70*/ IOAsyncCallback(object object, nint method);
        /*0x1cb6dd0*/ void Invoke(System.IOAsyncResult ioares);
        /*0x1cb7148*/ System.IAsyncResult BeginInvoke(System.IOAsyncResult ioares, System.AsyncCallback callback, object object);
        /*0x1cb716c*/ void EndInvoke(System.IAsyncResult result);
    }

    class IOAsyncResult : System.IAsyncResult
    {
        /*0x10*/ System.AsyncCallback async_callback;
        /*0x18*/ object async_state;
        /*0x20*/ System.Threading.ManualResetEvent wait_handle;
        /*0x28*/ bool completed_synchronously;
        /*0x29*/ bool completed;

        /*0x1cb7178*/ IOAsyncResult(System.AsyncCallback async_callback, object async_state);
        /*0x1cb71b0*/ System.AsyncCallback get_AsyncCallback();
        /*0x1cb71b8*/ object get_AsyncState();
        /*0x1cb71c0*/ System.Threading.WaitHandle get_AsyncWaitHandle();
        /*0x1cb72d8*/ bool get_CompletedSynchronously();
        /*0x1cb72e0*/ void set_CompletedSynchronously(bool value);
        /*0x1cb72ec*/ bool get_IsCompleted();
        /*0x1cb72f4*/ void set_IsCompleted(bool value);
        void CompleteDisposed();
    }

    class IOSelectorJob : System.Threading.IThreadPoolWorkItem
    {
        /*0x10*/ System.IOOperation operation;
        /*0x18*/ System.IOAsyncCallback callback;
        /*0x20*/ System.IOAsyncResult state;

        /*0x1cb73d0*/ IOSelectorJob(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state);
        /*0x1cb7410*/ void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem();
        /*0x1cb7430*/ void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae);
        /*0x1cb7434*/ void MarkDisposed();
    }

    class IOSelector
    {
        static /*0x1cb73cc*/ void Add(nint handle, System.IOSelectorJob job);
    }

    class Platform
    {
        static /*0x0*/ bool checkedOS;
        static /*0x1*/ bool isMacOS;
        static /*0x2*/ bool isFreeBSD;

        static /*0x1eb552c*/ int uname(nint buf);
        static /*0x1eb55ac*/ void CheckOS();
        static /*0x1eb57d8*/ bool get_IsMacOS();
    }

    class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        /*0x1700fe8*/ UriTypeConverter();
        /*0x170104c*/ bool CanConvert(System.Type type);
        /*0x1701144*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
        /*0x1701200*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
        /*0x1701284*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        /*0x1701424*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
    }

    namespace Text
    {
        namespace RegularExpressions
        {
            class Regex : System.Runtime.Serialization.ISerializable
            {
                static string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
                static int MaxOptionShift = 10;
                static /*0x0*/ System.TimeSpan MaximumMatchTimeout;
                static /*0x8*/ System.TimeSpan InfiniteMatchTimeout;
                static /*0x10*/ System.TimeSpan FallbackDefaultMatchTimeout;
                static /*0x18*/ System.TimeSpan DefaultMatchTimeout;
                static /*0x20*/ System.Collections.Generic.LinkedList<System.Text.RegularExpressions.CachedCodeEntry> livecode;
                static /*0x28*/ int cacheSize;
                /*0x10*/ string pattern;
                /*0x18*/ System.Text.RegularExpressions.RegexRunnerFactory factory;
                /*0x20*/ System.Text.RegularExpressions.RegexOptions roptions;
                /*0x28*/ System.TimeSpan internalMatchTimeout;
                /*0x30*/ System.Collections.Hashtable caps;
                /*0x38*/ System.Collections.Hashtable capnames;
                /*0x40*/ string[] capslist;
                /*0x48*/ int capsize;
                /*0x50*/ System.Text.RegularExpressions.ExclusiveReference runnerref;
                /*0x58*/ System.Text.RegularExpressions.SharedReference replref;
                /*0x60*/ System.Text.RegularExpressions.RegexCode code;
                /*0x68*/ bool refsInitialized;

                static /*0x1ec8348*/ Regex();
                static /*0x1ec6174*/ void ValidateMatchTimeout(System.TimeSpan matchTimeout);
                static /*0x1ec6d18*/ System.TimeSpan InitDefaultMatchTimeout();
                static /*0x1ec72b0*/ bool IsMatch(string input, string pattern);
                static /*0x1ec7330*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x1ec77b8*/ System.Text.RegularExpressions.Match Match(string input, string pattern);
                static /*0x1ec7838*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x1ec79ac*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern);
                static /*0x1ec7a2c*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x1ec7c04*/ string Replace(string input, string pattern, string replacement);
                static /*0x1ec7c8c*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x1ec7f54*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator);
                static /*0x1ec7fdc*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x1ec8158*/ string[] Split(string input, string pattern);
                static /*0x1ec81d8*/ string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x1ec62f8*/ System.Text.RegularExpressions.CachedCodeEntry LookupCachedAndUpdate(string key);
                /*0x1ec5bf0*/ Regex();
                /*0x1ec5c68*/ Regex(string pattern);
                /*0x1ec60ec*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options);
                /*0x1ec5cec*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, bool useCache);
                /*0x1ec6aa8*/ Regex(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1ec6c24*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0x1ec6fb0*/ System.Text.RegularExpressions.RegexOptions get_Options();
                /*0x1ec6fb8*/ System.TimeSpan get_MatchTimeout();
                /*0x1ec6fc0*/ bool get_RightToLeft();
                /*0x1ec6fd8*/ string ToString();
                /*0x1ec6fe0*/ string GroupNameFromNumber(int i);
                /*0x1ec7150*/ int GroupNumberFromName(string name);
                /*0x1ec73c0*/ bool IsMatch(string input);
                /*0x1ec7430*/ bool IsMatch(string input, int startat);
                /*0x1ec78c8*/ System.Text.RegularExpressions.Match Match(string input);
                /*0x1ec7938*/ System.Text.RegularExpressions.Match Match(string input, int startat);
                /*0x1ec7abc*/ System.Text.RegularExpressions.MatchCollection Matches(string input);
                /*0x1ec7b2c*/ System.Text.RegularExpressions.MatchCollection Matches(string input, int startat);
                /*0x1ec7d24*/ string Replace(string input, string replacement);
                /*0x1ec7d98*/ string Replace(string input, string replacement, int count, int startat);
                /*0x1ec8074*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator);
                /*0x1ec80e8*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat);
                /*0x1ec8268*/ string[] Split(string input);
                /*0x1ec82dc*/ string[] Split(string input, int count, int startat);
                /*0x1ec6570*/ void InitializeReferences();
                /*0x1ec74b8*/ System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat);
                /*0x1ec6658*/ System.Text.RegularExpressions.CachedCodeEntry CacheCode(string key);
                /*0x1ec6fcc*/ bool UseOptionR();
                /*0x1ec833c*/ bool UseOptionInvariant();
            }

            class MatchEvaluator : System.MulticastDelegate
            {
                /*0x1cc0320*/ MatchEvaluator(object object, nint method);
                /*0x1cc0380*/ string Invoke(System.Text.RegularExpressions.Match match);
                /*0x1cc0700*/ System.IAsyncResult BeginInvoke(System.Text.RegularExpressions.Match match, System.AsyncCallback callback, object object);
                /*0x1cc0724*/ string EndInvoke(System.IAsyncResult result);
            }

            class CachedCodeEntry
            {
                /*0x10*/ string _key;
                /*0x18*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x20*/ System.Collections.Hashtable _caps;
                /*0x28*/ System.Collections.Hashtable _capnames;
                /*0x30*/ string[] _capslist;
                /*0x38*/ int _capsize;
                /*0x40*/ System.Text.RegularExpressions.RegexRunnerFactory _factory;
                /*0x48*/ System.Text.RegularExpressions.ExclusiveReference _runnerref;
                /*0x50*/ System.Text.RegularExpressions.SharedReference _replref;

                /*0x1d0601c*/ CachedCodeEntry(string key, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.Text.RegularExpressions.SharedReference repl);
            }

            class ExclusiveReference
            {
                /*0x10*/ System.Text.RegularExpressions.RegexRunner _ref;
                /*0x18*/ object _obj;
                /*0x20*/ int _locked;

                /*0x17dbdc0*/ ExclusiveReference();
                /*0x17dbc5c*/ object Get();
                /*0x17dbcac*/ void Release(object obj);
            }

            class SharedReference
            {
                /*0x10*/ System.WeakReference _ref;
                /*0x18*/ int _locked;

                /*0x185df48*/ SharedReference();
                /*0x185de90*/ object Get();
                /*0x185dee8*/ void Cache(object obj);
            }

            class RegexBoyerMoore
            {
                static int infinite = 2147483647;
                /*0x10*/ int[] _positive;
                /*0x18*/ int[] _negativeASCII;
                /*0x20*/ int[][] _negativeUnicode;
                /*0x28*/ string _pattern;
                /*0x30*/ int _lowASCII;
                /*0x34*/ int _highASCII;
                /*0x38*/ bool _rightToLeft;
                /*0x39*/ bool _caseInsensitive;
                /*0x40*/ System.Globalization.CultureInfo _culture;

                /*0x1ec8484*/ RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, System.Globalization.CultureInfo culture);
                /*0x1ec8978*/ bool MatchPattern(string text, int index);
                /*0x1ec8aa0*/ bool IsMatch(string text, int index, int beglimit, int endlimit);
                /*0x1ec8b10*/ int Scan(string text, int index, int beglimit, int endlimit);
                /*0x1ec8e50*/ string ToString();
            }

            class Capture
            {
                /*0x10*/ string _text;
                /*0x18*/ int _index;
                /*0x1c*/ int _length;

                /*0x1d061f4*/ Capture(string text, int i, int l);
                /*0x1d062cc*/ Capture();
                /*0x1d06234*/ int get_Index();
                /*0x1d0623c*/ int get_Length();
                /*0x1d06244*/ string get_Value();
                /*0x1d06268*/ string ToString();
                /*0x1d0626c*/ string GetOriginalString();
                /*0x1d06274*/ string GetLeftSubstring();
                /*0x1d0629c*/ string GetRightSubstring();
            }

            class CaptureCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Text.RegularExpressions.Group _group;
                /*0x18*/ int _capcount;
                /*0x20*/ System.Text.RegularExpressions.Capture[] _captures;

                /*0x1d06678*/ CaptureCollection();
                /*0x1d06308*/ object get_SyncRoot();
                /*0x1d06310*/ bool get_IsSynchronized();
                /*0x1d06318*/ int get_Count();
                /*0x1d06320*/ System.Text.RegularExpressions.Capture get_Item(int i);
                /*0x1d06518*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x1d065dc*/ System.Collections.IEnumerator GetEnumerator();
                /*0x1d06324*/ System.Text.RegularExpressions.Capture GetCapture(int i);
            }

            class CaptureEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Text.RegularExpressions.CaptureCollection _rcc;
                /*0x18*/ int _curindex;

                /*0x1d06644*/ CaptureEnumerator(System.Text.RegularExpressions.CaptureCollection rcc);
                /*0x1d066b4*/ bool MoveNext();
                /*0x1d066f4*/ object get_Current();
                /*0x1d066f8*/ System.Text.RegularExpressions.Capture get_Capture();
                /*0x1d06780*/ void Reset();
            }

            class RegexCharClass
            {
                static /*0x0*/ string InternalRegexIgnoreCase;
                static /*0x8*/ string Space;
                static /*0x10*/ string NotSpace;
                static /*0x18*/ string Word;
                static /*0x20*/ string NotWord;
                static /*0x28*/ string SpaceClass;
                static /*0x30*/ string NotSpaceClass;
                static /*0x38*/ string WordClass;
                static /*0x40*/ string NotWordClass;
                static /*0x48*/ string DigitClass;
                static /*0x50*/ string NotDigitClass;
                static /*0x58*/ System.Collections.Generic.Dictionary<string, string> _definedCategories;
                static /*0x60*/ string[,] _propTable;
                static /*0x68*/ System.Text.RegularExpressions.RegexCharClass.LowerCaseMapping[] _lcTable;
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> _rangelist;
                /*0x18*/ System.Text.StringBuilder _categories;
                /*0x20*/ bool _canonical;
                /*0x21*/ bool _negate;
                /*0x28*/ System.Text.RegularExpressions.RegexCharClass _subtractor;

                static /*0x1ec8e58*/ RegexCharClass();
                static /*0x1ed0110*/ char SingletonChar(string set);
                static /*0x1ed012c*/ bool IsMergeable(string charClass);
                static /*0x1ed026c*/ bool IsEmpty(string charClass);
                static /*0x1ed0330*/ bool IsSingleton(string set);
                static /*0x1ed0448*/ bool IsSingletonInverse(string set);
                static /*0x1ed0208*/ bool IsSubtraction(string charClass);
                static /*0x1ed01dc*/ bool IsNegated(string set);
                static /*0x1ed0564*/ bool IsECMAWordChar(char ch);
                static /*0x1ed0650*/ bool IsWordChar(char ch);
                static /*0x1ed05dc*/ bool CharInClass(char ch, string set);
                static /*0x1ed06e0*/ bool CharInClassRecursive(char ch, string set, int start);
                static /*0x1ed0824*/ bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x1ed0940*/ bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x1ed0b00*/ bool CharInCategoryGroup(char ch, System.Globalization.UnicodeCategory chcategory, string category, ref int i);
                static /*0x1ecee10*/ string NegateCategory(string category);
                static /*0x1ed0bd4*/ System.Text.RegularExpressions.RegexCharClass Parse(string charClass);
                static /*0x1ed0c38*/ System.Text.RegularExpressions.RegexCharClass ParseRecursive(string charClass, int start);
                static /*0x1ecf778*/ string SetFromProperty(string capname, bool invert, string pattern);
                /*0x1eceeec*/ RegexCharClass();
                /*0x1ecefa0*/ RegexCharClass(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction);
                /*0x1eceffc*/ bool get_CanMerge();
                /*0x1ecf01c*/ void set_Negate(bool value);
                /*0x1ecf028*/ void AddChar(char c);
                /*0x1ecf12c*/ void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc);
                /*0x1ecf32c*/ void AddSet(string set);
                /*0x1ecf530*/ void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub);
                /*0x1ecf030*/ void AddRange(char first, char last);
                /*0x1ecf538*/ void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern);
                /*0x1ecfa94*/ void AddCategory(string category);
                /*0x1ecfab0*/ void AddLowercase(System.Globalization.CultureInfo culture);
                /*0x1ecfbd0*/ void AddLowercaseRange(char chMin, char chMax, System.Globalization.CultureInfo culture);
                /*0x1ecfe2c*/ void AddWord(bool ecma, bool negate);
                /*0x1ecff3c*/ void AddSpace(bool ecma, bool negate);
                /*0x1ed004c*/ void AddDigit(bool ecma, bool negate, string pattern);
                /*0x1ecf26c*/ int RangeCount();
                /*0x1ed0ea8*/ string ToStringClass();
                /*0x1ecf2b8*/ System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(int i);
                /*0x1ed107c*/ void Canonicalize();

                struct LowerCaseMapping
                {
                    /*0x10*/ char _chMin;
                    /*0x12*/ char _chMax;
                    /*0x14*/ int _lcOp;
                    /*0x18*/ int _data;

                    /*0xaa23c4*/ LowerCaseMapping(char chMin, char chMax, int lcOp, int data);
                }

                class SingleRangeComparer : System.Collections.Generic.IComparer<System.Text.RegularExpressions.RegexCharClass.SingleRange>
                {
                    /*0x1486928*/ SingleRangeComparer();
                    /*0x14868ec*/ int Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y);
                }

                class SingleRange
                {
                    /*0x10*/ char _first;
                    /*0x12*/ char _last;

                    /*0x14868b0*/ SingleRange(char first, char last);
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
                /*0x10*/ int[] _codes;
                /*0x18*/ string[] _strings;
                /*0x20*/ int _trackcount;
                /*0x28*/ System.Collections.Hashtable _caps;
                /*0x30*/ int _capsize;
                /*0x38*/ System.Text.RegularExpressions.RegexPrefix _fcPrefix;
                /*0x40*/ System.Text.RegularExpressions.RegexBoyerMoore _bmPrefix;
                /*0x48*/ int _anchors;
                /*0x4c*/ bool _rightToLeft;

                static /*0x29e208c*/ bool OpcodeBacktracks(int Op);
                /*0x29e1f7c*/ RegexCode(int[] codes, System.Collections.Generic.List<string> stringlist, int trackcount, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Text.RegularExpressions.RegexPrefix fcPrefix, int anchors, bool rightToLeft);
            }

            class RegexFCD
            {
                /*0x10*/ int[] _intStack;
                /*0x18*/ int _intDepth;
                /*0x20*/ System.Text.RegularExpressions.RegexFC[] _fcStack;
                /*0x28*/ int _fcDepth;
                /*0x2c*/ bool _skipAllChildren;
                /*0x2d*/ bool _skipchild;
                /*0x2e*/ bool _failed;

                static /*0x29e23cc*/ System.Text.RegularExpressions.RegexPrefix FirstChars(System.Text.RegularExpressions.RegexTree t);
                static /*0x29e2734*/ System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree);
                static /*0x29e2a74*/ int Anchors(System.Text.RegularExpressions.RegexTree tree);
                static /*0x29e2ba4*/ int AnchorFromType(int type);
                /*0x29e24fc*/ RegexFCD();
                /*0x29e2c10*/ void PushInt(int I);
                /*0x29e2cec*/ bool IntIsEmpty();
                /*0x29e2cfc*/ int PopInt();
                /*0x29e2d44*/ void PushFC(System.Text.RegularExpressions.RegexFC fc);
                /*0x29e2e48*/ bool FCIsEmpty();
                /*0x29e2e58*/ System.Text.RegularExpressions.RegexFC PopFC();
                /*0x29e2ea0*/ System.Text.RegularExpressions.RegexFC TopFC();
                /*0x29e2580*/ System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x29e336c*/ void SkipChild();
                /*0x29e2ee4*/ void CalculateFC(int NodeType, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }

            class RegexFC
            {
                /*0x10*/ System.Text.RegularExpressions.RegexCharClass _cc;
                /*0x18*/ bool _nullable;
                /*0x19*/ bool _caseInsensitive;

                /*0x29e20ac*/ RegexFC(bool nullable);
                /*0x29e2128*/ RegexFC(char ch, bool not, bool nullable, bool caseInsensitive);
                /*0x29e2224*/ RegexFC(string charClass, bool nullable, bool caseInsensitive);
                /*0x29e22c8*/ bool AddFC(System.Text.RegularExpressions.RegexFC fc, bool concatenate);
                /*0x29e2380*/ string GetFirstChars(System.Globalization.CultureInfo culture);
                /*0x29e23c4*/ bool IsCaseInsensitive();
            }

            class RegexPrefix
            {
                static /*0x0*/ System.Text.RegularExpressions.RegexPrefix _empty;
                /*0x10*/ string _prefix;
                /*0x18*/ bool _caseInsensitive;

                static /*0x29ece78*/ RegexPrefix();
                static /*0x29ece14*/ System.Text.RegularExpressions.RegexPrefix get_Empty();
                /*0x29e26f4*/ RegexPrefix(string prefix, bool ci);
                /*0x29ece04*/ string get_Prefix();
                /*0x29ece0c*/ bool get_CaseInsensitive();
            }

            class Group : System.Text.RegularExpressions.Capture
            {
                static /*0x0*/ System.Text.RegularExpressions.Group _emptygroup;
                /*0x20*/ int[] _caps;
                /*0x28*/ int _capcount;
                /*0x30*/ System.Text.RegularExpressions.CaptureCollection _capcoll;
                /*0x38*/ string _name;

                static /*0x17e6790*/ Group();
                /*0x17e66e8*/ Group(string text, int[] caps, int capcount, string name);
                /*0x17e6860*/ Group();
                /*0x17e6780*/ bool get_Success();
            }

            class GroupCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Text.RegularExpressions.Match _match;
                /*0x18*/ System.Collections.Hashtable _captureMap;
                /*0x20*/ System.Text.RegularExpressions.Group[] _groups;

                /*0x17e689c*/ GroupCollection(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps);
                /*0x17e6e40*/ GroupCollection();
                /*0x17e68d4*/ object get_SyncRoot();
                /*0x17e68dc*/ bool get_IsSynchronized();
                /*0x17e68e4*/ int get_Count();
                /*0x17e690c*/ System.Text.RegularExpressions.Group get_Item(int groupnum);
                /*0x17e6a44*/ System.Text.RegularExpressions.Group get_Item(string groupname);
                /*0x17e6910*/ System.Text.RegularExpressions.Group GetGroup(int groupnum);
                /*0x17e6af0*/ System.Text.RegularExpressions.Group GetGroupImpl(int groupnum);
                /*0x17e6cdc*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x17e6da4*/ System.Collections.IEnumerator GetEnumerator();
            }

            class GroupEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Text.RegularExpressions.GroupCollection _rgc;
                /*0x18*/ int _curindex;

                /*0x17e6e0c*/ GroupEnumerator(System.Text.RegularExpressions.GroupCollection rgc);
                /*0x17e6e7c*/ bool MoveNext();
                /*0x17e6ecc*/ object get_Current();
                /*0x17e6ed0*/ System.Text.RegularExpressions.Capture get_Capture();
                /*0x17e6f68*/ void Reset();
            }

            class RegexInterpreter : System.Text.RegularExpressions.RegexRunner
            {
                /*0x80*/ int runoperator;
                /*0x88*/ int[] runcodes;
                /*0x90*/ int runcodepos;
                /*0x98*/ string[] runstrings;
                /*0xa0*/ System.Text.RegularExpressions.RegexCode runcode;
                /*0xa8*/ System.Text.RegularExpressions.RegexPrefix runfcPrefix;
                /*0xb0*/ System.Text.RegularExpressions.RegexBoyerMoore runbmPrefix;
                /*0xb8*/ int runanchors;
                /*0xbc*/ bool runrtl;
                /*0xbd*/ bool runci;
                /*0xc0*/ System.Globalization.CultureInfo runculture;

                /*0x29e3378*/ RegexInterpreter(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture);
                /*0x29e33ec*/ void InitTrackCount();
                /*0x29e340c*/ void Advance();
                /*0x29e3414*/ void Advance(int i);
                /*0x29e349c*/ void Goto(int newpos);
                /*0x29e3574*/ void Textto(int newpos);
                /*0x29e357c*/ void Trackto(int newpos);
                /*0x29e35a0*/ int Textstart();
                /*0x29e35a8*/ int Textpos();
                /*0x29e35b0*/ int Trackpos();
                /*0x29e35d4*/ void TrackPush();
                /*0x29e3620*/ void TrackPush(int I1);
                /*0x29e3694*/ void TrackPush(int I1, int I2);
                /*0x29e3730*/ void TrackPush(int I1, int I2, int I3);
                /*0x29e37f4*/ void TrackPush2(int I1);
                /*0x29e386c*/ void TrackPush2(int I1, int I2);
                /*0x29e390c*/ void Backtrack();
                /*0x29e347c*/ void SetOperator(int op);
                /*0x29e3a00*/ void TrackPop();
                /*0x29e3a10*/ void TrackPop(int framesize);
                /*0x29e3a20*/ int TrackPeek();
                /*0x29e3a64*/ int TrackPeek(int i);
                /*0x29e3aac*/ void StackPush(int I1);
                /*0x29e3af4*/ void StackPush(int I1, int I2);
                /*0x29e3b64*/ void StackPop();
                /*0x29e3b74*/ void StackPop(int framesize);
                /*0x29e3b84*/ int StackPeek();
                /*0x29e3bc8*/ int StackPeek(int i);
                /*0x29e3c10*/ int Operator();
                /*0x29e3c18*/ int Operand(int i);
                /*0x29e3c60*/ int Leftchars();
                /*0x29e3c70*/ int Rightchars();
                /*0x29e3c80*/ int Bump();
                /*0x29e3c94*/ int Forwardchars();
                /*0x29e3cc0*/ char Forwardcharnext();
                /*0x29e3d7c*/ bool Stringmatch(string str);
                /*0x29e3f1c*/ bool Refmatch(int index, int len);
                /*0x29e40c8*/ void Backwardnext();
                /*0x29e40f8*/ char CharAt(int j);
                /*0x29e4114*/ bool FindFirstChar();
                /*0x29e4488*/ void Go();
            }

            class Match : System.Text.RegularExpressions.Group
            {
                static /*0x0*/ System.Text.RegularExpressions.Match _empty;
                /*0x40*/ System.Text.RegularExpressions.GroupCollection _groupcoll;
                /*0x48*/ System.Text.RegularExpressions.Regex _regex;
                /*0x50*/ int _textbeg;
                /*0x54*/ int _textpos;
                /*0x58*/ int _textend;
                /*0x5c*/ int _textstart;
                /*0x60*/ int[][] _matches;
                /*0x68*/ int[] _matchcount;
                /*0x70*/ bool _balancing;

                static /*0x1cbfb30*/ Match();
                static /*0x1cbf038*/ System.Text.RegularExpressions.Match get_Empty();
                /*0x1cbf09c*/ Match(System.Text.RegularExpressions.Regex regex, int capcount, string text, int begpos, int len, int startpos);
                /*0x1cbfbcc*/ Match();
                /*0x1cbf21c*/ void Reset(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart);
                /*0x1cbf284*/ System.Text.RegularExpressions.GroupCollection get_Groups();
                /*0x1cbf2f4*/ System.Text.RegularExpressions.Match NextMatch();
                /*0x1cbf328*/ string GroupToStringImpl(int groupnum);
                /*0x1cbf424*/ string LastGroupToStringImpl();
                /*0x1cbf44c*/ void AddMatch(int cap, int start, int len);
                /*0x1cbf6a8*/ void BalanceMatch(int cap);
                /*0x1cbf78c*/ void RemoveMatch(int cap);
                /*0x1cbf7d0*/ bool IsMatched(int cap);
                /*0x1cbf86c*/ int MatchIndex(int cap);
                /*0x1cbf904*/ int MatchLength(int cap);
                /*0x1cbf99c*/ void Tidy(int textpos);
            }

            class MatchSparse : System.Text.RegularExpressions.Match
            {
                /*0x78*/ System.Collections.Hashtable _caps;

                /*0x1cc0730*/ MatchSparse(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, int capcount, string text, int begpos, int len, int startpos);
                /*0x1cc07ec*/ System.Text.RegularExpressions.GroupCollection get_Groups();
            }

            class MatchCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                static /*0x0*/ int infinite;
                /*0x10*/ System.Text.RegularExpressions.Regex _regex;
                /*0x18*/ System.Collections.ArrayList _matches;
                /*0x20*/ bool _done;
                /*0x28*/ string _input;
                /*0x30*/ int _beginning;
                /*0x34*/ int _length;
                /*0x38*/ int _startat;
                /*0x3c*/ int _prevlen;

                static /*0x1cc01b8*/ MatchCollection();
                /*0x1cbfc08*/ MatchCollection(System.Text.RegularExpressions.Regex regex, string input, int beginning, int length, int startat);
                /*0x1cc0208*/ MatchCollection();
                /*0x1cbfd30*/ System.Text.RegularExpressions.Match GetMatch(int i);
                /*0x1cbfea4*/ int get_Count();
                /*0x1cbff34*/ object get_SyncRoot();
                /*0x1cbff38*/ bool get_IsSynchronized();
                /*0x1cbff40*/ System.Text.RegularExpressions.Match get_Item(int i);
                /*0x1cbffa8*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x1cc012c*/ System.Collections.IEnumerator GetEnumerator();
            }

            class MatchEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Text.RegularExpressions.MatchCollection _matchcoll;
                /*0x18*/ System.Text.RegularExpressions.Match _match;
                /*0x20*/ int _curindex;
                /*0x24*/ bool _done;

                /*0x1cc018c*/ MatchEnumerator(System.Text.RegularExpressions.MatchCollection matchcoll);
                /*0x1cc0244*/ bool MoveNext();
                /*0x1cc02a8*/ object get_Current();
                /*0x1cc0310*/ void Reset();
            }

            class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                /*0x88*/ string regexInput;
                /*0x90*/ string regexPattern;
                /*0x98*/ System.TimeSpan matchTimeout;

                /*0x29e5aec*/ RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout);
                /*0x29e5bb8*/ RegexMatchTimeoutException();
                /*0x29e5cbc*/ RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x29e5de8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0x29e5c34*/ void Init();
                /*0x29e5bac*/ void Init(string input, string pattern, System.TimeSpan timeout);
            }

            class RegexNode
            {
                /*0x10*/ int _type;
                /*0x18*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode> _children;
                /*0x20*/ string _str;
                /*0x28*/ char _ch;
                /*0x2c*/ int _m;
                /*0x30*/ int _n;
                /*0x34*/ System.Text.RegularExpressions.RegexOptions _options;
                /*0x38*/ System.Text.RegularExpressions.RegexNode _next;

                /*0x29e5ec8*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options);
                /*0x29e5f04*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, char ch);
                /*0x29e5f48*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, string str);
                /*0x29e5f8c*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m);
                /*0x29e5fd0*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m, int n);
                /*0x29e6020*/ bool UseOptionR();
                /*0x29e602c*/ System.Text.RegularExpressions.RegexNode ReverseLeft();
                /*0x29e60ac*/ void MakeRep(int type, int min, int max);
                /*0x29e60c4*/ System.Text.RegularExpressions.RegexNode Reduce();
                /*0x29e6bb4*/ System.Text.RegularExpressions.RegexNode StripEnation(int emptyType);
                /*0x29e6a2c*/ System.Text.RegularExpressions.RegexNode ReduceGroup();
                /*0x29e68a0*/ System.Text.RegularExpressions.RegexNode ReduceRep();
                /*0x29e6a5c*/ System.Text.RegularExpressions.RegexNode ReduceSet();
                /*0x29e6110*/ System.Text.RegularExpressions.RegexNode ReduceAlternation();
                /*0x29e6508*/ System.Text.RegularExpressions.RegexNode ReduceConcatenation();
                /*0x29e6c78*/ System.Text.RegularExpressions.RegexNode MakeQuantifier(bool lazy, int min, int max);
                /*0x29e6d9c*/ void AddChild(System.Text.RegularExpressions.RegexNode newChild);
                /*0x29e2a00*/ System.Text.RegularExpressions.RegexNode Child(int i);
                /*0x29e29b0*/ int ChildCount();
                /*0x29e6e6c*/ int Type();
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
                static /*0x0*/ byte[] _category;
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

                static /*0x29ecd74*/ RegexParser();
                static /*0x29e6e74*/ System.Text.RegularExpressions.RegexTree Parse(string re, System.Text.RegularExpressions.RegexOptions op);
                static /*0x29e7d60*/ System.Text.RegularExpressions.RegexReplacement ParseReplacement(string rep, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op);
                static /*0x29ec2f4*/ int HexDigit(char ch);
                static /*0x29ec404*/ System.Text.RegularExpressions.RegexOptions OptionFromCode(char ch);
                static /*0x29e8a38*/ bool IsSpecial(char ch);
                static /*0x29e87c8*/ bool IsStopperX(char ch);
                static /*0x29e8ae8*/ bool IsQuantifier(char ch);
                static /*0x29eb918*/ bool IsSpace(char ch);
                /*0x29e7028*/ RegexParser(System.Globalization.CultureInfo culture);
                /*0x29e70e0*/ void SetPattern(string Re);
                /*0x29e7498*/ void Reset(System.Text.RegularExpressions.RegexOptions topopts);
                /*0x29e7530*/ System.Text.RegularExpressions.RegexNode ScanRegex();
                /*0x29e7ee0*/ System.Text.RegularExpressions.RegexNode ScanReplacement();
                /*0x29e8ed4*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive);
                /*0x29eabfc*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly);
                /*0x29e8fb4*/ System.Text.RegularExpressions.RegexNode ScanGroupOpen();
                /*0x29e8460*/ void ScanBlank();
                /*0x29e9fa4*/ System.Text.RegularExpressions.RegexNode ScanBackslash();
                /*0x29eba5c*/ System.Text.RegularExpressions.RegexNode ScanBasicBackslash();
                /*0x29ea7e4*/ System.Text.RegularExpressions.RegexNode ScanDollar();
                /*0x29eb5ac*/ string ScanCapname();
                /*0x29ec0e0*/ char ScanOctal();
                /*0x29ea6c4*/ int ScanDecimal();
                /*0x29ec1a0*/ char ScanHex(int c);
                /*0x29ec32c*/ char ScanControl();
                /*0x29ec3dc*/ bool IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option);
                /*0x29eb80c*/ void ScanOptions();
                /*0x29eb3e8*/ char ScanCharEscape();
                /*0x29eb264*/ string ParseProperty();
                /*0x29eb9c8*/ int TypeFromCode(char ch);
                /*0x29e7148*/ void CountCaptures();
                /*0x29ec464*/ void NoteCaptureSlot(int i, int pos);
                /*0x29ec5c4*/ void NoteCaptureName(string name, int pos);
                /*0x29e7ed4*/ void NoteCaptures(System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames);
                /*0x29ec714*/ void AssignNameSlots();
                /*0x29eb774*/ int CaptureSlotFromName(string capname);
                /*0x29eb6b8*/ bool IsCaptureSlot(int i);
                /*0x29eb758*/ bool IsCaptureName(string capname);
                /*0x29eb6ac*/ bool UseOptionN();
                /*0x29e8ec8*/ bool UseOptionI();
                /*0x29ea500*/ bool UseOptionM();
                /*0x29ea580*/ bool UseOptionS();
                /*0x29e8764*/ bool UseOptionX();
                /*0x29eb258*/ bool UseOptionE();
                /*0x29e8878*/ bool IsTrueQuantifier();
                /*0x29e8b98*/ void AddConcatenate(int pos, int cch, bool isReplacement);
                /*0x29e9a60*/ void PushGroup();
                /*0x29e9e14*/ void PopGroup();
                /*0x29e9b80*/ bool EmptyStack();
                /*0x29e83bc*/ void StartGroup(System.Text.RegularExpressions.RegexNode openGroup);
                /*0x29e9aac*/ void AddAlternate();
                /*0x29ea664*/ void AddConcatenate();
                /*0x29ea79c*/ void AddConcatenate(bool lazy, int min, int max);
                /*0x29ecd54*/ System.Text.RegularExpressions.RegexNode Unit();
                /*0x29e8e00*/ void AddUnitOne(char ch);
                /*0x29ea58c*/ void AddUnitNotone(char ch);
                /*0x29e8ee0*/ void AddUnitSet(string cc);
                /*0x29ecd5c*/ void AddUnitNode(System.Text.RegularExpressions.RegexNode node);
                /*0x29ea50c*/ void AddUnitType(int type);
                /*0x29e9cbc*/ void AddGroup();
                /*0x29e8f5c*/ void PushOptions();
                /*0x29e9ef8*/ void PopOptions();
                /*0x29ec570*/ bool EmptyOptionsStack();
                /*0x29e99f8*/ void PopKeepOptions();
                /*0x29e9b90*/ System.ArgumentException MakeException(string message);
                /*0x29ecd64*/ int Textpos();
                /*0x29ecd6c*/ void Textto(int pos);
                /*0x29ea698*/ char MoveRightGetChar();
                /*0x29e8770*/ void MoveRight();
                /*0x29eb69c*/ void MoveRight(int i);
                /*0x29ea654*/ void MoveLeft();
                /*0x29e8de4*/ char CharAt(int i);
                /*0x29e87a4*/ char RightChar();
                /*0x29eb674*/ char RightChar(int i);
                /*0x29e8780*/ int CharsRight();
            }

            class RegexReplacement
            {
                /*0x10*/ string _rep;
                /*0x18*/ System.Collections.Generic.List<string> _strings;
                /*0x20*/ System.Collections.Generic.List<int> _rules;

                static /*0x29ed628*/ string Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x29eda64*/ string[] Split(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                /*0x29e8010*/ RegexReplacement(string rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps);
                /*0x29ecf08*/ void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match);
                /*0x29ed0a8*/ void ReplacementImplRTL(System.Collections.Generic.List<string> al, System.Text.RegularExpressions.Match match);
                /*0x29ed268*/ string get_Pattern();
                /*0x29ed270*/ string Replace(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
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
                /*0x70*/ int timeout;
                /*0x74*/ bool ignoreTimeout;
                /*0x78*/ int timeoutOccursAt;
                /*0x7c*/ int timeoutChecksToSkip;

                /*0x29e33e4*/ RegexRunner();
                /*0x29edf14*/ System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout);
                /*0x29ee27c*/ void StartTimeoutWatch();
                /*0x29e563c*/ void CheckTimeout();
                /*0x29ee4f0*/ void DoCheckTimeout();
                void Go();
                bool FindFirstChar();
                void InitTrackCount();
                /*0x29ee2c0*/ void InitMatch();
                /*0x29ee4a0*/ System.Text.RegularExpressions.Match TidyMatch(bool quick);
                /*0x29e351c*/ void EnsureStorage();
                /*0x29e5874*/ bool IsBoundary(int index, int startpos, int endpos);
                /*0x29e5990*/ bool IsECMABoundary(int index, int startpos, int endpos);
                /*0x29ee678*/ void DoubleTrack();
                /*0x29ee5d4*/ void DoubleStack();
                /*0x29ee71c*/ void DoubleCrawl();
                /*0x29ee7c0*/ void Crawl(int i);
                /*0x29ee828*/ int Popcrawl();
                /*0x29e5850*/ int Crawlpos();
                /*0x29e57a8*/ void Capture(int capnum, int start, int end);
                /*0x29e5684*/ void TransferCapture(int capnum, int uncapnum, int start, int end);
                /*0x29e5814*/ void Uncapture();
                /*0x29e5664*/ bool IsMatched(int cap);
                /*0x29e5aac*/ int MatchIndex(int cap);
                /*0x29e5acc*/ int MatchLength(int cap);
            }

            class RegexRunnerFactory
            {
                System.Text.RegularExpressions.RegexRunner CreateInstance();
            }

            class RegexTree
            {
                /*0x10*/ System.Text.RegularExpressions.RegexNode _root;
                /*0x18*/ System.Collections.Hashtable _caps;
                /*0x20*/ int[] _capnumlist;
                /*0x28*/ System.Collections.Hashtable _capnames;
                /*0x30*/ string[] _capslist;
                /*0x38*/ System.Text.RegularExpressions.RegexOptions _options;
                /*0x3c*/ int _captop;

                /*0x29e7cf8*/ RegexTree(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, int[] capnumlist, int captop, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexOptions opts);
            }

            class RegexWriter
            {
                /*0x10*/ int[] _intStack;
                /*0x18*/ int _depth;
                /*0x20*/ int[] _emitted;
                /*0x28*/ int _curpos;
                /*0x30*/ System.Collections.Generic.Dictionary<string, int> _stringhash;
                /*0x38*/ System.Collections.Generic.List<string> _stringtable;
                /*0x40*/ bool _counting;
                /*0x44*/ int _count;
                /*0x48*/ int _trackcount;
                /*0x50*/ System.Collections.Hashtable _caps;

                static /*0x29ee870*/ System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree t);
                /*0x29ee8d4*/ RegexWriter();
                /*0x29eed9c*/ void PushInt(int I);
                /*0x29eee78*/ bool EmptyStack();
                /*0x29eee88*/ int PopInt();
                /*0x29eeed0*/ int CurPos();
                /*0x29eeed8*/ void PatchJump(int Offset, int jumpDest);
                /*0x29eef18*/ void Emit(int op);
                /*0x29eefb0*/ void Emit(int op, int opd1);
                /*0x29ef070*/ void Emit(int op, int opd1, int opd2);
                /*0x29ef158*/ int StringCode(string str);
                /*0x29ef29c*/ System.ArgumentException MakeException(string message);
                /*0x29ef2fc*/ int MapCapnum(int capnum);
                /*0x29ee9c4*/ System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x29ef3b4*/ void EmitFragment(int nodetype, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }
        }
    }

    namespace Diagnostics
    {
        class BooleanSwitch : System.Diagnostics.Switch
        {
            /*0x1d00860*/ BooleanSwitch(string displayName, string description);
        }

        class Switch
        {
            static /*0x0*/ System.Collections.Generic.List<System.WeakReference> switches;
            static /*0x8*/ int s_LastCollectionCount;
            /*0x10*/ string description;
            /*0x18*/ string displayName;
            /*0x20*/ string switchValueString;
            /*0x28*/ string defaultValue;

            static /*0x186855c*/ Switch();
            static /*0x1868060*/ void _pruneCachedSwitches();
            /*0x1867e10*/ Switch(string displayName, string description);
            /*0x1867e74*/ Switch(string displayName, string description, string defaultSwitchValue);
        }

        class SwitchLevelAttribute : System.Attribute
        {
            /*0x10*/ System.Type type;

            /*0x18685e4*/ SwitchLevelAttribute(System.Type switchLevelType);
            /*0x1868614*/ void set_SwitchLevelType(System.Type value);
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
            /*0x1869d64*/ TraceSwitch(string displayName, string description);
        }

        class Stopwatch
        {
            static /*0x0*/ long Frequency;
            static /*0x8*/ bool IsHighResolution;
            /*0x10*/ long elapsed;
            /*0x18*/ long started;
            /*0x20*/ bool is_running;

            static /*0x186733c*/ Stopwatch();
            static /*0x1866f60*/ long GetTimestamp();
            /*0x1866f64*/ Stopwatch();
            /*0x1866f6c*/ System.TimeSpan get_Elapsed();
            /*0x186710c*/ long get_ElapsedMilliseconds();
            /*0x1867090*/ long get_ElapsedTicks();
            /*0x186723c*/ bool get_IsRunning();
            /*0x1867244*/ void Start();
            /*0x18672b8*/ void Stop();
        }

        namespace CodeAnalysis
        {
            class ExcludeFromCodeCoverageAttribute : System.Attribute
            {
                /*0x17dbc54*/ ExcludeFromCodeCoverageAttribute();
            }
        }
    }

    namespace ComponentModel
    {
        class AmbientValueAttribute : System.Attribute
        {
            /*0x10*/ object value;

            /*0x1cfaaf0*/ object get_Value();
        }

        class ArrayConverter : System.ComponentModel.CollectionConverter
        {
            /*0x1cfb0b4*/ ArrayConverter();
            /*0x1cfaaf8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1cfaec8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1cfb0ac*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class ArrayPropertyDescriptor : System.ComponentModel.TypeConverter.SimplePropertyDescriptor
            {
                /*0x98*/ int index;

                /*0x14770c0*/ ArrayPropertyDescriptor(System.Type arrayType, System.Type elementType, int index);
                /*0x14771cc*/ object GetValue(object instance);
                /*0x1477284*/ void SetValue(object instance, object value);
            }
        }

        class ArraySubsetEnumerator : System.Collections.IEnumerator
        {
            /*0x10*/ System.Array array;
            /*0x18*/ int total;
            /*0x1c*/ int current;

            /*0x1cfb11c*/ ArraySubsetEnumerator(System.Array array, int count);
            /*0x1cfb15c*/ bool MoveNext();
            /*0x1cfb184*/ void Reset();
            /*0x1cfb190*/ object get_Current();
        }

        class AttributeCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            static /*0x0*/ System.ComponentModel.AttributeCollection Empty;
            static /*0x8*/ System.Collections.Hashtable _defaultAttributes;
            static /*0x10*/ object internalSyncObject;
            /*0x10*/ System.Attribute[] _attributes;
            /*0x18*/ System.ComponentModel.AttributeCollection.AttributeEntry[] _foundAttributeTypes;
            /*0x20*/ int _index;

            static /*0x1cfda24*/ AttributeCollection();
            /*0x1cfccf4*/ AttributeCollection(System.Attribute[] attributes);
            /*0x1cfcdfc*/ System.Attribute[] get_Attributes();
            /*0x1cfce04*/ int get_Count();
            /*0x1cfce2c*/ System.Attribute get_Item(System.Type attributeType);
            /*0x1cfd8e4*/ bool Contains(System.Attribute attribute);
            /*0x1cfd3b4*/ System.Attribute GetDefaultAttribute(System.Type attributeType);
            /*0x1cfd950*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1cfd978*/ int System.Collections.ICollection.get_Count();
            /*0x1cfd9a0*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x1cfd9a8*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x1cfd9b0*/ void CopyTo(System.Array array, int index);
            /*0x1cfda20*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            struct AttributeEntry
            {
                /*0x10*/ System.Type type;
                /*0x18*/ int index;
            }
        }

        class AttributeProviderAttribute : System.Attribute
        {
            /*0x10*/ string _typeName;
            /*0x18*/ string _propertyName;

            /*0x1cfdab8*/ string get_TypeName();
            /*0x1cfdac0*/ string get_PropertyName();
        }

        class BooleanConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;

            /*0x1d007fc*/ BooleanConverter();
            /*0x1d0032c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1d003f4*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1d00668*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1d007ec*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1d007f4*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class BrowsableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.BrowsableAttribute Yes;
            static /*0x8*/ System.ComponentModel.BrowsableAttribute No;
            static /*0x10*/ System.ComponentModel.BrowsableAttribute Default;
            /*0x10*/ bool browsable;

            static /*0x1d00a40*/ BrowsableAttribute();
            /*0x1d008dc*/ BrowsableAttribute(bool browsable);
            /*0x1d00914*/ bool get_Browsable();
            /*0x1d0091c*/ bool Equals(object obj);
            /*0x1d009c0*/ int GetHashCode();
            /*0x1d009cc*/ bool IsDefaultAttribute();
        }

        class ByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1d011a0*/ ByteConverter();
            /*0x1d00eec*/ System.Type get_TargetType();
            /*0x1d00f64*/ object FromString(string value, int radix);
            /*0x1d01004*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1d0107c*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1d010f0*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class CharConverter : System.ComponentModel.TypeConverter
        {
            /*0x1d07fc4*/ CharConverter();
            /*0x1d07be8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1d07cb0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1d07de0*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        enum CollectionChangeAction
        {
            Add = 1,
            Remove = 2,
            Refresh = 3,
        }

        class CollectionChangeEventArgs : System.EventArgs
        {
            /*0x10*/ System.ComponentModel.CollectionChangeAction action;
            /*0x18*/ object element;

            /*0x1d080dc*/ CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element);
            /*0x1d0815c*/ System.ComponentModel.CollectionChangeAction get_Action();
            /*0x1d08164*/ object get_Element();
        }

        class CollectionChangeEventHandler : System.MulticastDelegate
        {
            /*0x1d0816c*/ CollectionChangeEventHandler(object object, nint method);
            /*0x1d081cc*/ void Invoke(object sender, System.ComponentModel.CollectionChangeEventArgs e);
            /*0x1d08560*/ System.IAsyncResult BeginInvoke(object sender, System.ComponentModel.CollectionChangeEventArgs e, System.AsyncCallback callback, object object);
            /*0x1d08590*/ void EndInvoke(System.IAsyncResult result);
        }

        class CollectionConverter : System.ComponentModel.TypeConverter
        {
            /*0x1cfb0b8*/ CollectionConverter();
            /*0x1cfad34*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1d0859c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1d085a4*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class Component : System.MarshalByRefObject
        {
            static /*0x0*/ object EventDisposed;

            static /*0x1d08e14*/ Component();
            /*0x1d08e00*/ bool get_CanRaiseEvents();
            /*0x1d08e08*/ bool get_CanRaiseEventsInternal();
        }

        class ComponentCollection : System.Collections.ReadOnlyCollectionBase
        {
            /*0x1d08e88*/ System.ComponentModel.IComponent get_Item(string name);
        }

        class ComponentConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x1d09408*/ ComponentConverter(System.Type type);
            /*0x1d0947c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1d094f0*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class CultureInfoConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;

            /*0x1d1255c*/ CultureInfoConverter();
            /*0x1d11410*/ string get_DefaultCultureString();
            /*0x1d11458*/ string GetCultureName(System.Globalization.CultureInfo culture);
            /*0x1d11478*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1d11540*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1d11608*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1d11e1c*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1d1234c*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1d1254c*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1d12554*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);

            class CultureComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.CultureInfoConverter converter;

                /*0x1478fa4*/ CultureComparer(System.ComponentModel.CultureInfoConverter cultureConverter);
                /*0x1478fd0*/ int Compare(object item1, object item2);
            }

            class CultureInfoMapper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> cultureInfoNameMap;

                static /*0x1479148*/ string GetCultureInfoName(string cultureInfoDisplayName);
                static /*0x147922c*/ void InitializeCultureInfoMap();
            }
        }

        class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
        {
            /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _parent;

            /*0x1d125c0*/ CustomTypeDescriptor();
            /*0x1d125c8*/ CustomTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor parent);
            /*0x1d125f4*/ System.ComponentModel.AttributeCollection GetAttributes();
            /*0x1d126e0*/ System.ComponentModel.TypeConverter GetConverter();
            /*0x1d127c4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
            /*0x1d128b4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            /*0x1d129b8*/ object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        class DateTimeConverter : System.ComponentModel.TypeConverter
        {
            /*0x1d13a4c*/ DateTimeConverter();
            /*0x1d12a88*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1d12b50*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1d12c18*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1d12fdc*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class DateTimeOffsetConverter : System.ComponentModel.TypeConverter
        {
            /*0x1d14b6c*/ DateTimeOffsetConverter();
            /*0x1d13ab0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1d13b78*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1d13c40*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1d14010*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class DecimalConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x17d1458*/ DecimalConverter();
            /*0x17d0cf8*/ bool get_AllowHex();
            /*0x17d0d00*/ System.Type get_TargetType();
            /*0x17d0d78*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x17d0e40*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x17d119c*/ object FromString(string value, int radix);
            /*0x17d1274*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x17d130c*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x17d13a0*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class DefaultEventAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultEventAttribute Default;
            /*0x10*/ string name;

            static /*0x17d152c*/ DefaultEventAttribute();
            /*0x17d1460*/ DefaultEventAttribute(string name);
            /*0x17d148c*/ string get_Name();
            /*0x17d1494*/ bool Equals(object obj);
            /*0x17d1524*/ int GetHashCode();
        }

        class DefaultPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultPropertyAttribute Default;
            /*0x10*/ string name;

            static /*0x17d165c*/ DefaultPropertyAttribute();
            /*0x17d1590*/ DefaultPropertyAttribute(string name);
            /*0x17d15bc*/ string get_Name();
            /*0x17d15c4*/ bool Equals(object obj);
            /*0x17d1654*/ int GetHashCode();
        }

        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object value;

            /*0x17d1948*/ DefaultValueAttribute(int value);
            /*0x17d19b8*/ DefaultValueAttribute(long value);
            /*0x17d1a28*/ DefaultValueAttribute(bool value);
            /*0x17d1a98*/ DefaultValueAttribute(string value);
            /*0x17d1ac4*/ DefaultValueAttribute(object value);
            /*0x17d1af0*/ object get_Value();
            /*0x17d1af8*/ bool Equals(object obj);
            /*0x17d1c14*/ int GetHashCode();
        }

        class DelegatingTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
        {
            /*0x20*/ System.Type _type;

            /*0x17d36f4*/ DelegatingTypeDescriptionProvider(System.Type type);
            /*0x17d3720*/ System.ComponentModel.TypeDescriptionProvider get_Provider();
            /*0x17d3788*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x17d37dc*/ System.Collections.IDictionary GetCache(object instance);
            /*0x17d3810*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x17d3844*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x17d3878*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x17d38b4*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
        }

        class DesignOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.DesignOnlyAttribute Default;
            /*0x10*/ bool isDesignOnly;

            static /*0x17d3a64*/ DesignOnlyAttribute();
            /*0x17d38f0*/ DesignOnlyAttribute(bool isDesignOnly);
            /*0x17d3920*/ bool get_IsDesignOnly();
            /*0x17d3928*/ bool IsDefaultAttribute();
            /*0x17d39b4*/ bool Equals(object obj);
            /*0x17d3a58*/ int GetHashCode();
        }

        class DesignTimeVisibleAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignTimeVisibleAttribute Yes;
            static /*0x8*/ System.ComponentModel.DesignTimeVisibleAttribute No;
            static /*0x10*/ System.ComponentModel.DesignTimeVisibleAttribute Default;
            /*0x10*/ bool visible;

            static /*0x17d3d04*/ DesignTimeVisibleAttribute();
            /*0x17d3afc*/ DesignTimeVisibleAttribute(bool visible);
            /*0x17d3b2c*/ bool get_Visible();
            /*0x17d3b34*/ bool Equals(object obj);
            /*0x17d3bd8*/ int GetHashCode();
            /*0x17d3c78*/ bool IsDefaultAttribute();
        }

        class DesignerAttribute : System.Attribute
        {
            /*0x10*/ string designerTypeName;
            /*0x18*/ string designerBaseTypeName;
            /*0x20*/ string typeId;

            /*0x17d3d9c*/ DesignerAttribute(string designerTypeName, System.Type designerBaseType);
            /*0x17d3e54*/ object get_TypeId();
            /*0x17d3ee4*/ bool Equals(object obj);
            /*0x17d3f98*/ int GetHashCode();
        }

        class DesignerCategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerCategoryAttribute Component;
            static /*0x8*/ System.ComponentModel.DesignerCategoryAttribute Default;
            static /*0x10*/ System.ComponentModel.DesignerCategoryAttribute Form;
            static /*0x18*/ System.ComponentModel.DesignerCategoryAttribute Generic;
            /*0x10*/ string category;
            /*0x18*/ string typeId;

            static /*0x17d421c*/ DesignerCategoryAttribute();
            /*0x17d3fec*/ DesignerCategoryAttribute();
            /*0x17d404c*/ DesignerCategoryAttribute(string category);
            /*0x17d4078*/ string get_Category();
            /*0x17d4080*/ object get_TypeId();
            /*0x17d40d8*/ bool Equals(object obj);
            /*0x17d4178*/ int GetHashCode();
            /*0x17d4198*/ bool IsDefaultAttribute();
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
            /*0x10*/ System.ComponentModel.DesignerSerializationVisibility visibility;

            static /*0x17d4478*/ DesignerSerializationVisibilityAttribute();
            /*0x17d4330*/ DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility);
            /*0x17d435c*/ System.ComponentModel.DesignerSerializationVisibility get_Visibility();
            /*0x17d4364*/ bool Equals(object obj);
            /*0x17d43fc*/ int GetHashCode();
            /*0x17d4404*/ bool IsDefaultAttribute();
        }

        class DisplayNameAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DisplayNameAttribute Default;
            /*0x10*/ string _displayName;

            static /*0x17d6d80*/ DisplayNameAttribute();
            /*0x17d6b68*/ DisplayNameAttribute();
            /*0x17d6bc8*/ DisplayNameAttribute(string displayName);
            /*0x17d6bf4*/ string get_DisplayName();
            /*0x17d6bfc*/ string get_DisplayNameValue();
            /*0x17d6c04*/ bool Equals(object obj);
            /*0x17d6ce0*/ int GetHashCode();
            /*0x17d6d0c*/ bool IsDefaultAttribute();
        }

        class DoubleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x17d8a10*/ DoubleConverter();
            /*0x17d86f8*/ bool get_AllowHex();
            /*0x17d8700*/ System.Type get_TargetType();
            /*0x17d8778*/ object FromString(string value, int radix);
            /*0x17d884c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x17d88d8*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x17d8960*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class EditorAttribute : System.Attribute
        {
            /*0x10*/ string baseTypeName;
            /*0x18*/ string typeName;
            /*0x20*/ string typeId;

            /*0x17d8a18*/ EditorAttribute(string typeName, string baseTypeName);
            /*0x17d8a64*/ object get_TypeId();
            /*0x17d8af4*/ bool Equals(object obj);
            /*0x17d8ba8*/ int GetHashCode();
        }

        class EditorBrowsableAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.EditorBrowsableState browsableState;

            /*0x17d8bb0*/ EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state);
            /*0x17d8bdc*/ bool Equals(object obj);
            /*0x17d8c74*/ int GetHashCode();
        }

        enum EditorBrowsableState
        {
            Always = 0,
            Never = 1,
            Advanced = 2,
        }

        class EnumConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;
            /*0x18*/ System.Type type;

            /*0x17d8e30*/ EnumConverter(System.Type type);
            /*0x17d8ea8*/ System.Type get_EnumType();
            /*0x17d8eb0*/ System.ComponentModel.TypeConverter.StandardValuesCollection get_Values();
            /*0x17d8eb8*/ void set_Values(System.ComponentModel.TypeConverter.StandardValuesCollection value);
            /*0x17d8ec0*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x17d8fe4*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x17d9108*/ System.Collections.IComparer get_Comparer();
            /*0x17d916c*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x17d9700*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x17da4e0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x17da928*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x17da9d8*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x17da9e0*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
        }

        class EventDescriptor : System.ComponentModel.MemberDescriptor
        {
        }

        class EventDescriptorCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
        {
            static /*0x0*/ System.ComponentModel.EventDescriptorCollection Empty;
            /*0x10*/ System.ComponentModel.EventDescriptor[] events;
            /*0x18*/ string[] namedSort;
            /*0x20*/ System.Collections.IComparer comparer;
            /*0x28*/ bool eventsOwned;
            /*0x29*/ bool needSort;
            /*0x2c*/ int eventCount;
            /*0x30*/ bool readOnly;

            static /*0x17dba60*/ EventDescriptorCollection();
            /*0x17daa58*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events);
            /*0x17daaec*/ EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly);
            /*0x17dab18*/ int get_Count();
            /*0x17dab20*/ System.ComponentModel.EventDescriptor get_Item(int index);
            /*0x17dac60*/ int Add(System.ComponentModel.EventDescriptor value);
            /*0x17dae48*/ void Clear();
            /*0x17dae98*/ bool Contains(System.ComponentModel.EventDescriptor value);
            /*0x17daf18*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x17dabb0*/ void EnsureEventsOwned();
            /*0x17dad34*/ void EnsureSize(int sizeNeeded);
            /*0x17daeb4*/ int IndexOf(System.ComponentModel.EventDescriptor value);
            /*0x17db260*/ void Insert(int index, System.ComponentModel.EventDescriptor value);
            /*0x17db354*/ void Remove(System.ComponentModel.EventDescriptor value);
            /*0x17db3cc*/ void RemoveAt(int index);
            /*0x17db494*/ System.Collections.IEnumerator GetEnumerator();
            /*0x17daf60*/ void InternalSort(string[] names);
            /*0x17db534*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x17db5c4*/ int System.Collections.ICollection.get_Count();
            /*0x17db5cc*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x17db5d4*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x17db5dc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x17db5e0*/ object System.Collections.IList.get_Item(int index);
            /*0x17db5f0*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x17db764*/ int System.Collections.IList.Add(object value);
            /*0x17db7f4*/ void System.Collections.IList.Clear();
            /*0x17db7f8*/ bool System.Collections.IList.Contains(object value);
            /*0x17db894*/ int System.Collections.IList.IndexOf(object value);
            /*0x17db924*/ void System.Collections.IList.Insert(int index, object value);
            /*0x17db9bc*/ void System.Collections.IList.Remove(object value);
            /*0x17dba4c*/ void System.Collections.IList.RemoveAt(int index);
            /*0x17dba50*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x17dba58*/ bool System.Collections.IList.get_IsFixedSize();
        }

        class EventHandlerList
        {
            /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry head;
            /*0x18*/ System.ComponentModel.Component parent;

            /*0x17dbac8*/ System.Delegate get_Item(object key);
            /*0x17dbb2c*/ System.ComponentModel.EventHandlerList.ListEntry Find(object key);

            class ListEntry
            {
                /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry next;
                /*0x18*/ object key;
                /*0x20*/ System.Delegate handler;
            }
        }

        class ExpandableObjectConverter : System.ComponentModel.TypeConverter
        {
            /*0x17dbdc8*/ ExpandableObjectConverter();
            /*0x17dbe2c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x17dbea0*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class ExtendedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            /*0x88*/ System.ComponentModel.ReflectPropertyDescriptor extenderInfo;
            /*0x90*/ System.ComponentModel.IExtenderProvider provider;

            /*0x17dbea8*/ ExtendedPropertyDescriptor(System.ComponentModel.ReflectPropertyDescriptor extenderInfo, System.Type receiverType, System.ComponentModel.IExtenderProvider provider, System.Attribute[] attributes);
            /*0x17dc0d4*/ bool CanResetValue(object comp);
            /*0x17dc0fc*/ System.Type get_ComponentType();
            /*0x17dc120*/ bool get_IsReadOnly();
            /*0x17dc224*/ System.Type get_PropertyType();
            /*0x17dc248*/ string get_DisplayName();
            /*0x17dc4c0*/ object GetValue(object comp);
            /*0x17dc4e8*/ void ResetValue(object comp);
            /*0x17dc510*/ void SetValue(object component, object value);
            /*0x17dc53c*/ bool ShouldSerializeValue(object comp);
        }

        class ExtenderProvidedPropertyAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.PropertyDescriptor extenderProperty;
            /*0x18*/ System.ComponentModel.IExtenderProvider provider;
            /*0x20*/ System.Type receiverType;

            static /*0x17dc058*/ System.ComponentModel.ExtenderProvidedPropertyAttribute Create(System.ComponentModel.PropertyDescriptor extenderProperty, System.Type receiverType, System.ComponentModel.IExtenderProvider provider);
            /*0x17dc564*/ ExtenderProvidedPropertyAttribute();
            /*0x17dc56c*/ System.ComponentModel.IExtenderProvider get_Provider();
            /*0x17dc574*/ System.Type get_ReceiverType();
            /*0x17dc57c*/ bool Equals(object obj);
            /*0x17dc660*/ int GetHashCode();
            /*0x17dc668*/ bool IsDefaultAttribute();
        }

        class GuidConverter : System.ComponentModel.TypeConverter
        {
            /*0x17e7540*/ GuidConverter();
            /*0x17e6f74*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x17e703c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x17e7104*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x17e71f4*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        interface IBindingList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
        }

        interface IChangeTracking
        {
            bool get_IsChanged();
            void AcceptChanges();
        }

        interface IComponent : System.IDisposable
        {
            System.ComponentModel.ISite get_Site();
        }

        interface IContainer : System.IDisposable
        {
            System.ComponentModel.ComponentCollection get_Components();
            void Remove(System.ComponentModel.IComponent component);
        }

        interface ICustomTypeDescriptor
        {
            System.ComponentModel.AttributeCollection GetAttributes();
            System.ComponentModel.TypeConverter GetConverter();
            System.ComponentModel.PropertyDescriptorCollection GetProperties();
            System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
            object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
        }

        interface IExtenderProvider
        {
            bool CanExtend(object extendee);
        }

        interface INotifyPropertyChanged
        {
            void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
            void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
        }

        interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking
        {
            void RejectChanges();
        }

        interface ISite : System.IServiceProvider
        {
            System.ComponentModel.IContainer get_Container();
            bool get_DesignMode();
            string get_Name();
        }

        interface ITypeDescriptorContext : System.IServiceProvider
        {
            System.ComponentModel.IContainer get_Container();
        }

        class Int16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1cbb8a4*/ Int16Converter();
            /*0x1cbb5f0*/ System.Type get_TargetType();
            /*0x1cbb668*/ object FromString(string value, int radix);
            /*0x1cbb708*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1cbb77c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1cbb7f4*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1cbbb60*/ Int32Converter();
            /*0x1cbb8ac*/ System.Type get_TargetType();
            /*0x1cbb924*/ object FromString(string value, int radix);
            /*0x1cbb9c4*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1cbba3c*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1cbbab0*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Int64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1cbbe1c*/ Int64Converter();
            /*0x1cbbb68*/ System.Type get_TargetType();
            /*0x1cbbbe0*/ object FromString(string value, int radix);
            /*0x1cbbc80*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1cbbcf8*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1cbbd6c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class InvalidEnumArgumentException : System.ArgumentException
        {
            /*0x1cbbe2c*/ InvalidEnumArgumentException();
            /*0x1cbbe38*/ InvalidEnumArgumentException(string message);
            /*0x1cbbe40*/ InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class ListBindableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ListBindableAttribute Yes;
            static /*0x8*/ System.ComponentModel.ListBindableAttribute No;
            static /*0x10*/ System.ComponentModel.ListBindableAttribute Default;
            /*0x10*/ bool listBindable;
            /*0x11*/ bool isDefault;

            static /*0x1cbddf0*/ ListBindableAttribute();
            /*0x1cbdc7c*/ ListBindableAttribute(bool listBindable);
            /*0x1cbdcac*/ bool get_ListBindable();
            /*0x1cbdcb4*/ bool Equals(object obj);
            /*0x1cbdd58*/ int GetHashCode();
            /*0x1cbdd60*/ bool IsDefaultAttribute();
        }

        class ListChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.ComponentModel.ListChangedType listChangedType;
            /*0x14*/ int newIndex;
            /*0x18*/ int oldIndex;
            /*0x20*/ System.ComponentModel.PropertyDescriptor propDesc;

            /*0x1cbde88*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex);
            /*0x1cbdf1c*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x1cbdf58*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc);
            /*0x1cbde90*/ ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex);
            /*0x1cbdfd8*/ System.ComponentModel.ListChangedType get_ListChangedType();
            /*0x1cbdfe0*/ int get_NewIndex();
            /*0x1cbdfe8*/ int get_OldIndex();
        }

        class ListChangedEventHandler : System.MulticastDelegate
        {
            /*0x1cbdff0*/ ListChangedEventHandler(object object, nint method);
            /*0x1cbe050*/ void Invoke(object sender, System.ComponentModel.ListChangedEventArgs e);
            /*0x1cbe3e4*/ System.IAsyncResult BeginInvoke(object sender, System.ComponentModel.ListChangedEventArgs e, System.AsyncCallback callback, object object);
            /*0x1cbe414*/ void EndInvoke(System.IAsyncResult result);
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
            static /*0x0*/ object EventDisposed;
            /*0x10*/ System.ComponentModel.ISite site;
            /*0x18*/ System.ComponentModel.EventHandlerList events;

            static /*0x1cbefc4*/ MarshalByValueComponent();
            /*0x1cbe990*/ MarshalByValueComponent();
            /*0x1cbe998*/ void Finalize();
            /*0x1cbea0c*/ System.ComponentModel.ISite get_Site();
            /*0x1cbea14*/ void Dispose();
            /*0x1cbea8c*/ void Dispose(bool disposing);
            /*0x1cbedbc*/ object GetService(System.Type service);
            /*0x1cbee88*/ string ToString();
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

            static /*0x1cc1db4*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType);
            static /*0x1cc1dbc*/ System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly);
            static /*0x1cc1f8c*/ System.ComponentModel.ISite GetSite(object component);
            /*0x1cc0868*/ MemberDescriptor(string name, System.Attribute[] attributes);
            /*0x1cc09fc*/ MemberDescriptor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes);
            /*0x1cc0e04*/ System.Attribute[] get_AttributeArray();
            /*0x1cc1664*/ void set_AttributeArray(System.Attribute[] value);
            /*0x1cc1730*/ System.ComponentModel.AttributeCollection get_Attributes();
            /*0x1cc1824*/ string get_Name();
            /*0x1cc1878*/ int get_NameHashCode();
            /*0x1cc1880*/ string get_DisplayName();
            /*0x1cc0e30*/ void CheckAttributesValid();
            /*0x1cc19b4*/ System.ComponentModel.AttributeCollection CreateAttributeCollection();
            /*0x1cc1a2c*/ bool Equals(object obj);
            /*0x1cc1ca4*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x1cc0ef4*/ void FilterAttributesIfNeeded();
            /*0x1cc1e64*/ int GetHashCode();
            /*0x1cc1e6c*/ object GetInvocationTarget(System.Type type, object instance);
        }

        class MultilineStringConverter : System.ComponentModel.TypeConverter
        {
            /*0x1cc6bac*/ MultilineStringConverter();
            /*0x1cc6a04*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1cc6b9c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1cc6ba4*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class NullableConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type nullableType;
            /*0x18*/ System.Type simpleType;
            /*0x20*/ System.ComponentModel.TypeConverter simpleTypeConverter;

            /*0x1eb2bac*/ NullableConverter(System.Type type);
            /*0x1eb2d1c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1eb2dec*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1eb2f34*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1eb3064*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1eb33d4*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x1eb33f8*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1eb341c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x1eb3440*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1eb3464*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1eb37c4*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1eb37ec*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1eb3814*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x1eb3848*/ System.Type get_NullableType();
            /*0x1eb3850*/ System.Type get_UnderlyingType();
            /*0x1eb3858*/ System.ComponentModel.TypeConverter get_UnderlyingTypeConverter();
        }

        class PropertyChangedEventArgs : System.EventArgs
        {
            /*0x10*/ string propertyName;

            /*0x1eb58c4*/ PropertyChangedEventArgs(string propertyName);
        }

        class PropertyChangedEventHandler : System.MulticastDelegate
        {
            /*0x1eb593c*/ PropertyChangedEventHandler(object object, nint method);
            /*0x1eb599c*/ void Invoke(object sender, System.ComponentModel.PropertyChangedEventArgs e);
            /*0x1eb5d30*/ System.IAsyncResult BeginInvoke(object sender, System.ComponentModel.PropertyChangedEventArgs e, System.AsyncCallback callback, object object);
            /*0x1eb5d60*/ void EndInvoke(System.IAsyncResult result);
        }

        class PropertyChangingEventArgs : System.EventArgs
        {
            /*0x10*/ string propertyName;

            /*0x1eb5d6c*/ PropertyChangingEventArgs(string propertyName);
        }

        class PropertyChangingEventHandler : System.MulticastDelegate
        {
            /*0x1eb5de4*/ PropertyChangingEventHandler(object object, nint method);
            /*0x1eb5e44*/ void Invoke(object sender, System.ComponentModel.PropertyChangingEventArgs e);
            /*0x1eb61d8*/ System.IAsyncResult BeginInvoke(object sender, System.ComponentModel.PropertyChangingEventArgs e, System.AsyncCallback callback, object object);
            /*0x1eb6208*/ void EndInvoke(System.IAsyncResult result);
        }

        class PropertyDescriptor : System.ComponentModel.MemberDescriptor
        {
            /*0x60*/ System.ComponentModel.TypeConverter converter;
            /*0x68*/ System.Collections.Hashtable valueChangedHandlers;
            /*0x70*/ object[] editors;
            /*0x78*/ System.Type[] editorTypes;
            /*0x80*/ int editorCount;

            /*0x1eb6214*/ PropertyDescriptor(string name, System.Attribute[] attrs);
            /*0x1eb621c*/ PropertyDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs);
            System.Type get_ComponentType();
            /*0x1eb6224*/ System.ComponentModel.TypeConverter get_Converter();
            bool get_IsReadOnly();
            System.Type get_PropertyType();
            bool CanResetValue(object component);
            /*0x1eb68c4*/ bool Equals(object obj);
            /*0x1eb6694*/ object CreateInstance(System.Type type);
            /*0x1eb6ad0*/ void FillAttributes(System.Collections.IList attributeList);
            /*0x1eb6ae4*/ int GetHashCode();
            /*0x1eb6b3c*/ object GetInvocationTarget(System.Type type, object instance);
            /*0x1eb6484*/ System.Type GetTypeFromName(string typeName);
            object GetValue(object component);
            /*0x1eb6c30*/ void OnValueChanged(object component, System.EventArgs e);
            void ResetValue(object component);
            void SetValue(object component, object value);
            bool ShouldSerializeValue(object component);
        }

        class PropertyDescriptorCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.IDictionary
        {
            static /*0x0*/ System.ComponentModel.PropertyDescriptorCollection Empty;
            /*0x10*/ System.Collections.IDictionary cachedFoundProperties;
            /*0x18*/ bool cachedIgnoreCase;
            /*0x20*/ System.ComponentModel.PropertyDescriptor[] properties;
            /*0x28*/ int propCount;
            /*0x30*/ string[] namedSort;
            /*0x38*/ System.Collections.IComparer comparer;
            /*0x40*/ bool propsOwned;
            /*0x41*/ bool needSort;
            /*0x42*/ bool readOnly;

            static /*0x1eb8bb8*/ PropertyDescriptorCollection();
            /*0x1eb6cd8*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties);
            /*0x1eb6d6c*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly);
            /*0x1eb6d98*/ PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, int propCount, string[] namedSort, System.Collections.IComparer comparer);
            /*0x1eb6e64*/ int get_Count();
            /*0x1eb6e6c*/ System.ComponentModel.PropertyDescriptor get_Item(int index);
            /*0x1eb6fac*/ System.ComponentModel.PropertyDescriptor get_Item(string name);
            /*0x1eb6fc0*/ int Add(System.ComponentModel.PropertyDescriptor value);
            /*0x1eb71a8*/ void Clear();
            /*0x1eb71fc*/ bool Contains(System.ComponentModel.PropertyDescriptor value);
            /*0x1eb727c*/ void CopyTo(System.Array array, int index);
            /*0x1eb6efc*/ void EnsurePropsOwned();
            /*0x1eb7094*/ void EnsureSize(int sizeNeeded);
            /*0x1eb75c4*/ System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase);
            /*0x1eb7218*/ int IndexOf(System.ComponentModel.PropertyDescriptor value);
            /*0x1eb7a8c*/ void Insert(int index, System.ComponentModel.PropertyDescriptor value);
            /*0x1eb7b80*/ void Remove(System.ComponentModel.PropertyDescriptor value);
            /*0x1eb7bf8*/ void RemoveAt(int index);
            /*0x1eb7cc0*/ System.ComponentModel.PropertyDescriptorCollection Sort(string[] names);
            /*0x1eb72c4*/ void InternalSort(string[] names);
            /*0x1eb7d48*/ void InternalSort(System.Collections.IComparer sorter);
            /*0x1eb7dd8*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1eb7e78*/ int System.Collections.ICollection.get_Count();
            /*0x1eb7e80*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x1eb7e88*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x1eb7e90*/ void System.Collections.IDictionary.Add(object key, object value);
            /*0x1eb7f60*/ bool System.Collections.IDictionary.Contains(object key);
            /*0x1eb7fec*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
            /*0x1eb804c*/ object System.Collections.IDictionary.get_Item(object key);
            /*0x1eb80d0*/ void System.Collections.IDictionary.set_Item(object key, object value);
            /*0x1eb84ac*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
            /*0x1eb85b0*/ void System.Collections.IDictionary.Remove(object key);
            /*0x1eb86bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1eb86cc*/ int System.Collections.IList.Add(object value);
            /*0x1eb875c*/ void System.Collections.IList.Clear();
            /*0x1eb8760*/ bool System.Collections.IList.Contains(object value);
            /*0x1eb87fc*/ int System.Collections.IList.IndexOf(object value);
            /*0x1eb888c*/ void System.Collections.IList.Insert(int index, object value);
            /*0x1eb8924*/ bool System.Collections.IList.get_IsReadOnly();
            /*0x1eb892c*/ bool System.Collections.IList.get_IsFixedSize();
            /*0x1eb8934*/ void System.Collections.IList.Remove(object value);
            /*0x1eb89c4*/ void System.Collections.IList.RemoveAt(int index);
            /*0x1eb89c8*/ object System.Collections.IList.get_Item(int index);
            /*0x1eb89d8*/ void System.Collections.IList.set_Item(int index, object value);

            class PropertyDescriptorEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
            {
                /*0x10*/ System.ComponentModel.PropertyDescriptorCollection owner;
                /*0x18*/ int index;

                /*0x14855ec*/ PropertyDescriptorEnumerator(System.ComponentModel.PropertyDescriptorCollection owner);
                /*0x1485620*/ object get_Current();
                /*0x1485688*/ System.Collections.DictionaryEntry get_Entry();
                /*0x14856fc*/ object get_Key();
                /*0x148573c*/ object get_Value();
                /*0x148577c*/ bool MoveNext();
                /*0x14857bc*/ void Reset();
            }
        }

        class ProvidePropertyAttribute : System.Attribute
        {
            /*0x10*/ string propertyName;
            /*0x18*/ string receiverTypeName;

            /*0x1eb8c48*/ string get_PropertyName();
            /*0x1eb8c50*/ string get_ReceiverTypeName();
        }

        class ReadOnlyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ReadOnlyAttribute Yes;
            static /*0x8*/ System.ComponentModel.ReadOnlyAttribute No;
            static /*0x10*/ System.ComponentModel.ReadOnlyAttribute Default;
            /*0x10*/ bool isReadOnly;

            static /*0x1eb9d98*/ ReadOnlyAttribute();
            /*0x1eb9c28*/ ReadOnlyAttribute(bool isReadOnly);
            /*0x1eb9c58*/ bool get_IsReadOnly();
            /*0x1eb9c60*/ bool Equals(object value);
            /*0x1eb9d04*/ int GetHashCode();
            /*0x1eb9d0c*/ bool IsDefaultAttribute();
        }

        class ReferenceConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ string none;
            /*0x10*/ System.Type type;

            static /*0x1ebacd4*/ ReferenceConverter();
            /*0x1eb9e30*/ ReferenceConverter(System.Type type);
            /*0x1eb9ea8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1eb9f74*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1eba2f0*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1eba5f0*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1ebacbc*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1ebacc4*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x1ebaccc*/ bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value);

            class ReferenceComparer : System.Collections.IComparer
            {
                /*0x10*/ System.ComponentModel.ReferenceConverter converter;

                /*0x14857c8*/ ReferenceComparer(System.ComponentModel.ReferenceConverter converter);
                /*0x14857f4*/ int Compare(object item1, object item2);
            }
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

            static /*0x1ebfe5c*/ ReflectPropertyDescriptor();
            /*0x1ebad40*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Attribute[] attributes);
            /*0x1ebb03c*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Reflection.PropertyInfo propInfo, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x1ebb18c*/ ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Type receiverType, System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod, System.Attribute[] attrs);
            /*0x1ebb268*/ object get_AmbientValue();
            /*0x1ebb408*/ System.Type get_ComponentType();
            /*0x1ebb410*/ object get_DefaultValue();
            /*0x1ebb6ec*/ System.Reflection.MethodInfo get_GetMethodValue();
            /*0x1ebbb5c*/ bool get_IsExtender();
            /*0x1ebbbc8*/ bool get_IsReadOnly();
            /*0x1ebc25c*/ System.Type get_PropertyType();
            /*0x1ebc264*/ System.Reflection.MethodInfo get_ResetMethodValue();
            /*0x1ebbcd4*/ System.Reflection.MethodInfo get_SetMethodValue();
            /*0x1ebc4a4*/ System.Reflection.MethodInfo get_ShouldSerializeMethodValue();
            /*0x1ebc6e4*/ bool ExtenderCanResetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x1ebcacc*/ System.Type ExtenderGetReceiverType();
            /*0x1ebcad4*/ System.Type ExtenderGetType(System.ComponentModel.IExtenderProvider provider);
            /*0x1ebc984*/ object ExtenderGetValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x1ebcae4*/ void ExtenderResetValue(System.ComponentModel.IExtenderProvider provider, object component, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x1ebd064*/ void ExtenderSetValue(System.ComponentModel.IExtenderProvider provider, object component, object value, System.ComponentModel.PropertyDescriptor notifyDesc);
            /*0x1ebd520*/ bool ExtenderShouldSerializeValue(System.ComponentModel.IExtenderProvider provider, object component);
            /*0x1ebd984*/ bool CanResetValue(object component);
            /*0x1ebdc0c*/ void FillAttributes(System.Collections.IList attributes);
            /*0x1ebeba4*/ object GetValue(object component);
            /*0x1ebef90*/ void OnValueChanged(object component, System.EventArgs e);
            /*0x1ebf04c*/ void ResetValue(object component);
            /*0x1ebf518*/ void SetValue(object component, object value);
            /*0x1ebfb18*/ bool ShouldSerializeValue(object component);
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

            static /*0x1ec5278*/ ReflectTypeDescriptionProvider();
            static /*0x1ec00d0*/ System.Collections.Hashtable get_IntrinsicTypeConverters();
            static /*0x1ec0db8*/ object CreateInstance(System.Type objectType, System.Type callingType);
            static /*0x1ec3008*/ System.ComponentModel.IExtenderProvider[] GetExtenders(System.Collections.ICollection components, object instance, System.Collections.IDictionary cache);
            static /*0x1ec3c54*/ System.Type GetTypeFromName(string typeName);
            static /*0x1ec3dac*/ System.Attribute[] ReflectGetAttributes(System.Type type);
            static /*0x1ebe6fc*/ System.Attribute[] ReflectGetAttributes(System.Reflection.MemberInfo member);
            static /*0x1ec1ba8*/ System.ComponentModel.PropertyDescriptor[] ReflectGetExtendedProperties(System.ComponentModel.IExtenderProvider provider);
            static /*0x1ec4254*/ System.ComponentModel.PropertyDescriptor[] ReflectGetProperties(System.Type type);
            static /*0x1ec4904*/ object SearchIntrinsicTable(System.Collections.Hashtable table, System.Type callingType);
            /*0x1ec00c8*/ ReflectTypeDescriptionProvider();
            /*0x1ec0bd8*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x1ec0ec8*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type type);
            /*0x1ec1174*/ System.Collections.IDictionary GetCache(object instance);
            /*0x1ec151c*/ System.ComponentModel.TypeConverter GetConverter(System.Type type, object instance);
            /*0x1ec1550*/ System.ComponentModel.AttributeCollection GetExtendedAttributes(object instance);
            /*0x1ec15b4*/ System.ComponentModel.TypeConverter GetExtendedConverter(object instance);
            /*0x1ec15f4*/ System.ComponentModel.PropertyDescriptorCollection GetExtendedProperties(object instance);
            /*0x1ec2b28*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x1ec3b6c*/ object GetExtendedPropertyOwner(object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x1ec3c18*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x1ec3c20*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type type);
            /*0x1ec3ba4*/ object GetPropertyOwner(System.Type type, object instance, System.ComponentModel.PropertyDescriptor pd);
            /*0x1ec3c44*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x1ec0eec*/ System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(System.Type type, bool createIfNeeded);
            /*0x1ec3c4c*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);
            /*0x1ec3d84*/ bool IsPopulated(System.Type type);
            /*0x1ec48dc*/ void Refresh(System.Type type);

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

                /*0x14858b8*/ ReflectedTypeData(System.Type type);
                /*0x14858e4*/ bool get_IsPopulated();
                /*0x1485900*/ System.ComponentModel.AttributeCollection GetAttributes();
                /*0x1485e98*/ System.ComponentModel.TypeConverter GetConverter(object instance);
                /*0x148654c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties();
                /*0x148637c*/ System.Type GetTypeFromName(string typeName);
                /*0x1486888*/ void Refresh();
            }
        }

        class RefreshEventArgs : System.EventArgs
        {
            /*0x10*/ System.Type typeChanged;

            /*0x1ec5594*/ RefreshEventArgs(System.Type typeChanged);
        }

        class RefreshEventHandler : System.MulticastDelegate
        {
            /*0x1ec560c*/ RefreshEventHandler(object object, nint method);
            /*0x1ec566c*/ void Invoke(System.ComponentModel.RefreshEventArgs e);
            /*0x1ec59e4*/ System.IAsyncResult BeginInvoke(System.ComponentModel.RefreshEventArgs e, System.AsyncCallback callback, object object);
            /*0x1ec5a08*/ void EndInvoke(System.IAsyncResult result);
        }

        class SByteConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1859a3c*/ SByteConverter();
            /*0x1859788*/ System.Type get_TargetType();
            /*0x1859800*/ object FromString(string value, int radix);
            /*0x18598a0*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1859918*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x185998c*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class SingleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x185e298*/ SingleConverter();
            /*0x185dfb0*/ bool get_AllowHex();
            /*0x185dfb8*/ System.Type get_TargetType();
            /*0x185e030*/ object FromString(string value, int radix);
            /*0x185e104*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x185e178*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x185e1e8*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class StringConverter : System.ComponentModel.TypeConverter
        {
            /*0x1867c00*/ StringConverter();
            /*0x18679bc*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1867af0*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
        }

        class TimeSpanConverter : System.ComponentModel.TypeConverter
        {
            /*0x1869334*/ TimeSpanConverter();
            /*0x186897c*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1868a24*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1868b58*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1868db8*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
        }

        class TypeConverter
        {
            static string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
            static /*0x0*/ bool useCompatibleTypeConversion;

            static /*0x186ab18*/ TypeConverter();
            static /*0x1869ddc*/ bool get_UseCompatibleTypeConversion();
            /*0x1867c64*/ TypeConverter();
            /*0x1869e48*/ bool CanConvertFrom(System.Type sourceType);
            /*0x1867a64*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1869e5c*/ bool CanConvertTo(System.Type destinationType);
            /*0x1868acc*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1869e70*/ object ConvertFrom(object value);
            /*0x1867b88*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x186a020*/ object ConvertFromInvariantString(string text);
            /*0x186a0b4*/ object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x186a140*/ object ConvertFromString(string text);
            /*0x186a158*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text);
            /*0x186a0a8*/ object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text);
            /*0x186a1e4*/ object ConvertTo(object value, System.Type destinationType);
            /*0x18690dc*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x186a370*/ string ConvertToInvariantString(object value);
            /*0x186a4d8*/ string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x186a55c*/ string ConvertToString(object value);
            /*0x186a670*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x186a3f0*/ string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x186a790*/ object CreateInstance(System.Collections.IDictionary propertyValues);
            /*0x186a7a4*/ object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues);
            /*0x1869ef8*/ System.Exception GetConvertFromException(object value);
            /*0x186a200*/ System.Exception GetConvertToException(object value, System.Type destinationType);
            /*0x186a7ac*/ bool GetCreateInstanceSupported();
            /*0x186a7bc*/ bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x186a7c4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object value);
            /*0x186a7d0*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x186a8d4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes);
            /*0x186a8dc*/ bool GetPropertiesSupported();
            /*0x186a8ec*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x186a8f4*/ System.Collections.ICollection GetStandardValues();
            /*0x186a904*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x186a90c*/ bool GetStandardValuesExclusive();
            /*0x186a920*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x186a928*/ bool GetStandardValuesSupported();
            /*0x186a93c*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
            /*0x186a944*/ bool IsValid(object value);
            /*0x186a95c*/ bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value);
            /*0x186aad4*/ System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, string[] names);

            class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor
            {
                /*0x88*/ System.Type componentType;
                /*0x90*/ System.Type propertyType;

                /*0x148b168*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType);
                /*0x147718c*/ SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes);
                /*0x148b1ec*/ System.Type get_ComponentType();
                /*0x148b1f4*/ bool get_IsReadOnly();
                /*0x148b284*/ System.Type get_PropertyType();
                /*0x148b28c*/ bool CanResetValue(object component);
                /*0x148b3dc*/ void ResetValue(object component);
                /*0x148b514*/ bool ShouldSerializeValue(object component);
            }

            class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ICollection values;
                /*0x18*/ System.Array valueArray;

                /*0x148b51c*/ StandardValuesCollection(System.Collections.ICollection values);
                /*0x148b5d8*/ int get_Count();
                /*0x148b6a0*/ object get_Item(int index);
                /*0x148b8b8*/ void CopyTo(System.Array array, int index);
                /*0x148b97c*/ System.Collections.IEnumerator GetEnumerator();
                /*0x148ba28*/ int System.Collections.ICollection.get_Count();
                /*0x148ba2c*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x148ba34*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x148ba3c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x148ba40*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TypeConverterAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.TypeConverterAttribute Default;
            /*0x10*/ string typeName;

            static /*0x186ad14*/ TypeConverterAttribute();
            /*0x186ab1c*/ TypeConverterAttribute();
            /*0x186ab7c*/ TypeConverterAttribute(System.Type type);
            /*0x186abc4*/ TypeConverterAttribute(string typeName);
            /*0x186ac5c*/ string get_ConverterTypeName();
            /*0x186ac64*/ bool Equals(object obj);
            /*0x186acf4*/ int GetHashCode();
        }

        class TypeDescriptionProvider
        {
            /*0x10*/ System.ComponentModel.TypeDescriptionProvider _parent;
            /*0x18*/ System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

            /*0x186ad70*/ TypeDescriptionProvider();
            /*0x186ad78*/ TypeDescriptionProvider(System.ComponentModel.TypeDescriptionProvider parent);
            /*0x186ada4*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            /*0x186aebc*/ System.Collections.IDictionary GetCache(object instance);
            /*0x186aed4*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
            /*0x186af6c*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
            /*0x186b034*/ System.Type GetReflectionType(System.Type objectType);
            /*0x186b044*/ System.Type GetReflectionType(System.Type objectType, object instance);
            /*0x186b060*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType);
            /*0x186b070*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance);
            /*0x186b0fc*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

            class EmptyCustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor
            {
                /*0x148ba44*/ EmptyCustomTypeDescriptor();
            }
        }

        class TypeDescriptionProviderAttribute : System.Attribute
        {
            /*0x10*/ string _typeName;

            /*0x186b19c*/ TypeDescriptionProviderAttribute(string typeName);
            /*0x186b214*/ TypeDescriptionProviderAttribute(System.Type type);
            /*0x186b304*/ string get_TypeName();
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

            static /*0x1872f10*/ TypeDescriptor();
            static /*0x186b30c*/ System.Type get_ComObjectType();
            static /*0x186b384*/ System.Type get_InterfaceType();
            static /*0x186b3fc*/ int get_MetadataVersion();
            static /*0x186b460*/ void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type);
            static /*0x186c270*/ void CheckDefaultProvider(System.Type type);
            static /*0x186c904*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
            static /*0x186cc40*/ System.Collections.ArrayList FilterMembers(System.Collections.IList members, System.Attribute[] attributes);
            static /*0x186d070*/ object GetAssociation(System.Type type, object primary);
            static /*0x186d76c*/ System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType);
            static /*0x186d9e0*/ System.ComponentModel.AttributeCollection GetAttributes(object component);
            static /*0x186da44*/ System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc);
            static /*0x1870c0c*/ System.Collections.IDictionary GetCache(object instance);
            static /*0x1871488*/ System.ComponentModel.TypeConverter GetConverter(System.Type type);
            static /*0x186d8e0*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(System.Type type, string typeName);
            static /*0x186ded8*/ System.ComponentModel.ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc);
            static /*0x186e0f0*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedDescriptor(object component);
            static /*0x1871584*/ string GetExtenderCollisionSuffix(System.ComponentModel.MemberDescriptor member);
            static /*0x18718e0*/ System.Type GetNodeForBaseType(System.Type searchType);
            static /*0x18719e4*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component);
            static /*0x1871a48*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc);
            static /*0x18721a8*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
            static /*0x187221c*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc);
            static /*0x1871ac0*/ System.ComponentModel.PropertyDescriptorCollection GetPropertiesImpl(object component, System.Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes);
            static /*0x1872964*/ System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type);
            static /*0x1872a50*/ System.ComponentModel.TypeDescriptionProvider GetProviderRecursive(System.Type type);
            static /*0x1872ab4*/ System.Type GetReflectionType(System.Type type);
            static /*0x186cbdc*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type);
            static /*0x186b708*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(System.Type type, bool createDelegator);
            static /*0x1871424*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance);
            static /*0x1872bb8*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator);
            static /*0x1872298*/ System.Collections.ICollection PipelineAttributeFilter(int pipelineType, System.Collections.ICollection members, System.Attribute[] filter, object instance, System.Collections.IDictionary cache);
            static /*0x186f338*/ System.Collections.ICollection PipelineFilter(int pipelineType, System.Collections.ICollection members, object instance, System.Collections.IDictionary cache);
            static /*0x1870c84*/ System.Collections.ICollection PipelineInitialize(int pipelineType, System.Collections.ICollection members, System.Collections.IDictionary cache);
            static /*0x186e1b4*/ System.Collections.ICollection PipelineMerge(int pipelineType, System.Collections.ICollection primary, System.Collections.ICollection secondary, object instance, System.Collections.IDictionary cache);
            static /*0x1872d44*/ void RaiseRefresh(System.Type type);
            static /*0x186bcdc*/ void Refresh(System.Type type);
            static /*0x186cfdc*/ bool ShouldHideMember(System.ComponentModel.MemberDescriptor member, System.Attribute attribute);
            static /*0x1872e04*/ void SortDescriptorArray(System.Collections.IList infos);

            class AttributeFilterCacheItem
            {
                /*0x10*/ System.Attribute[] _filter;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x148ba4c*/ AttributeFilterCacheItem(System.Attribute[] filter, System.Collections.ICollection filteredMembers);
                /*0x148ba84*/ bool IsValid(System.Attribute[] filter);
            }

            class FilterCacheItem
            {
                /*0x10*/ System.ComponentModel.Design.ITypeDescriptorFilterService _filterService;
                /*0x18*/ System.Collections.ICollection FilteredMembers;

                /*0x148bb04*/ FilterCacheItem(System.ComponentModel.Design.ITypeDescriptorFilterService filterService, System.Collections.ICollection filteredMembers);
                /*0x148bb3c*/ bool IsValid(System.ComponentModel.Design.ITypeDescriptorFilterService filterService);
            }

            interface IUnimplemented
            {
            }

            class MemberDescriptorComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.ComponentModel.TypeDescriptor.MemberDescriptorComparer Instance;

                static /*0x148bcd4*/ MemberDescriptorComparer();
                /*0x148bccc*/ MemberDescriptorComparer();
                /*0x148bb4c*/ int Compare(object left, object right);
            }

            class MergedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
            {
                /*0x10*/ System.ComponentModel.ICustomTypeDescriptor _primary;
                /*0x18*/ System.ComponentModel.ICustomTypeDescriptor _secondary;

                /*0x148bd34*/ MergedTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor primary, System.ComponentModel.ICustomTypeDescriptor secondary);
                /*0x148bd6c*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                /*0x148be9c*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                /*0x148bfd4*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                /*0x148c10c*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                /*0x148c250*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
            }

            class TypeDescriptionNode : System.ComponentModel.TypeDescriptionProvider
            {
                /*0x20*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode Next;
                /*0x28*/ System.ComponentModel.TypeDescriptionProvider Provider;

                /*0x148c394*/ TypeDescriptionNode(System.ComponentModel.TypeDescriptionProvider provider);
                /*0x148c3c0*/ object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args);
                /*0x148c544*/ System.Collections.IDictionary GetCache(object instance);
                /*0x148c5bc*/ System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance);
                /*0x148c68c*/ System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance);
                /*0x148c704*/ System.Type GetReflectionType(System.Type objectType, object instance);
                /*0x148c7e8*/ System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance);

                struct DefaultExtendedTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ object _instance;

                    /*0xae53a8*/ DefaultExtendedTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, object instance);
                    /*0xae53b0*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0xae53b8*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0xae53c0*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0xae53c8*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0xae53d0*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                }

                struct DefaultTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
                {
                    /*0x10*/ System.ComponentModel.TypeDescriptor.TypeDescriptionNode _node;
                    /*0x18*/ System.Type _objectType;
                    /*0x20*/ object _instance;

                    /*0xae5414*/ DefaultTypeDescriptor(System.ComponentModel.TypeDescriptor.TypeDescriptionNode node, System.Type objectType, object instance);
                    /*0xae5420*/ System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
                    /*0xae5428*/ System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
                    /*0xae5430*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
                    /*0xae5438*/ System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes);
                    /*0xae5440*/ object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
                }
            }

            class TypeDescriptorComObject
            {
            }

            class TypeDescriptorInterface
            {
            }
        }

        class TypeListConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.Type[] types;
            /*0x18*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;

            /*0x1873260*/ TypeListConverter(System.Type[] types);
            /*0x18732d8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1873380*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType);
            /*0x1873428*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1873530*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x187392c*/ System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context);
            /*0x18739f4*/ bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context);
            /*0x18739fc*/ bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context);
        }

        class UInt16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1873cb8*/ UInt16Converter();
            /*0x1873a04*/ System.Type get_TargetType();
            /*0x1873a7c*/ object FromString(string value, int radix);
            /*0x1873b1c*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1873b94*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1873c08*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1873f74*/ UInt32Converter();
            /*0x1873cc0*/ System.Type get_TargetType();
            /*0x1873d38*/ object FromString(string value, int radix);
            /*0x1873dd8*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1873e50*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1873ec4*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class UInt64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x1874230*/ UInt64Converter();
            /*0x1873f7c*/ System.Type get_TargetType();
            /*0x1873ff4*/ object FromString(string value, int radix);
            /*0x1874094*/ object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x187410c*/ object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1874180*/ string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
        }

        class Win32Exception : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ bool s_ErrorMessagesInitialized;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, string> s_ErrorMessage;
            /*0x88*/ int nativeErrorCode;

            static /*0x170eff0*/ Win32Exception();
            static /*0x170e058*/ string GetErrorMessage(int error);
            static /*0x170e330*/ void InitializeErrorMessages();
            static /*0x170e4c0*/ void InitializeErrorMessages1();
            /*0x170df68*/ Win32Exception();
            /*0x170dfd4*/ Win32Exception(int error);
            /*0x170e190*/ Win32Exception(int error, string message);
            /*0x170e1c0*/ Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x170e254*/ int get_NativeErrorCode();
            /*0x170e25c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class BaseNumberConverter : System.ComponentModel.TypeConverter
        {
            /*0x1cff5b4*/ BaseNumberConverter();
            /*0x1cfec68*/ bool get_AllowHex();
            System.Type get_TargetType();
            object FromString(string value, int radix);
            object FromString(string value, System.Globalization.NumberFormatInfo formatInfo);
            object FromString(string value, System.Globalization.CultureInfo culture);
            /*0x1cfec70*/ System.Exception FromStringError(string failedText, System.Exception innerException);
            string ToString(object value, System.Globalization.NumberFormatInfo formatInfo);
            /*0x1cfedc8*/ bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType);
            /*0x1cfee90*/ object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value);
            /*0x1cff290*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType);
            /*0x1cff56c*/ bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type t);
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

            static /*0x1ec5b40*/ RefreshPropertiesAttribute();
            /*0x1ec5a14*/ RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh);
            /*0x1ec5a40*/ System.ComponentModel.RefreshProperties get_RefreshProperties();
            /*0x1ec5a48*/ bool Equals(object value);
            /*0x1ec5ac4*/ int GetHashCode();
            /*0x1ec5acc*/ bool IsDefaultAttribute();
        }

        class ToolboxItemAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.ToolboxItemAttribute Default;
            static /*0x8*/ System.ComponentModel.ToolboxItemAttribute None;
            /*0x10*/ string toolboxItemTypeName;

            static /*0x1869ca4*/ ToolboxItemAttribute();
            /*0x1869a1c*/ ToolboxItemAttribute(bool defaultType);
            /*0x1869a84*/ ToolboxItemAttribute(string toolboxItemTypeName);
            /*0x18699a8*/ bool IsDefaultAttribute();
            /*0x1869b1c*/ string get_ToolboxItemTypeName();
            /*0x1869b74*/ bool Equals(object obj);
            /*0x1869c80*/ int GetHashCode();
        }

        class WeakHashtable : System.Collections.Hashtable
        {
            static /*0x0*/ System.Collections.IEqualityComparer _comparer;

            static /*0x17017e4*/ WeakHashtable();
            /*0x1701764*/ WeakHashtable();
            /*0x17017d4*/ void Clear();
            /*0x17017dc*/ void Remove(object key);

            class WeakKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x148ec0c*/ WeakKeyComparer();
                /*0x148ea8c*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
                /*0x148ebec*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
            }
        }

        namespace Design
        {
            class CheckoutException : System.Runtime.InteropServices.ExternalException
            {
                static /*0x0*/ System.ComponentModel.Design.CheckoutException Canceled;

                static /*0x1d08040*/ CheckoutException();
                /*0x1d08028*/ CheckoutException();
                /*0x1d08030*/ CheckoutException(string message, int errorCode);
                /*0x1d08038*/ CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class DesignerOptionService
            {
                /*0x17d432c*/ void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options);

                class DesignerOptionCollection : System.Collections.ICollection
                {
                    /*0x10*/ System.ComponentModel.Design.DesignerOptionService _service;
                    /*0x18*/ string _name;
                    /*0x20*/ object _value;
                    /*0x28*/ System.Collections.ArrayList _children;
                    /*0x30*/ System.ComponentModel.PropertyDescriptorCollection _properties;

                    /*0x147e14c*/ int get_Count();
                    /*0x147e210*/ string get_Name();
                    /*0x147e218*/ System.ComponentModel.PropertyDescriptorCollection get_Properties();
                    /*0x147e8ec*/ void CopyTo(System.Array array, int index);
                    /*0x147e184*/ void EnsurePopulated();
                    /*0x147e93c*/ System.Collections.IEnumerator GetEnumerator();
                    /*0x147e974*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x147e97c*/ object System.Collections.ICollection.get_SyncRoot();

                    class WrappedPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ object target;
                        /*0x90*/ System.ComponentModel.PropertyDescriptor property;

                        /*0x23264d0*/ WrappedPropertyDescriptor(System.ComponentModel.PropertyDescriptor property, object target);
                        /*0x232652c*/ System.ComponentModel.AttributeCollection get_Attributes();
                        /*0x232654c*/ System.Type get_ComponentType();
                        /*0x2326570*/ bool get_IsReadOnly();
                        /*0x2326594*/ System.Type get_PropertyType();
                        /*0x23265b8*/ bool CanResetValue(object component);
                        /*0x23265e4*/ object GetValue(object component);
                        /*0x2326610*/ void ResetValue(object component);
                        /*0x232663c*/ void SetValue(object component, object value);
                        /*0x2326668*/ bool ShouldSerializeValue(object component);
                    }
                }

                class DesignerOptionConverter : System.ComponentModel.TypeConverter
                {
                    /*0x147efe8*/ DesignerOptionConverter();
                    /*0x147e980*/ bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext cxt);
                    /*0x147e988*/ System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext cxt, object value, System.Attribute[] attributes);
                    /*0x147eeec*/ object ConvertTo(System.ComponentModel.ITypeDescriptorContext cxt, System.Globalization.CultureInfo culture, object value, System.Type destinationType);

                    class OptionPropertyDescriptor : System.ComponentModel.PropertyDescriptor
                    {
                        /*0x88*/ System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection _option;

                        /*0x2326694*/ OptionPropertyDescriptor(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection option);
                        /*0x23266d0*/ System.Type get_ComponentType();
                        /*0x23266ec*/ bool get_IsReadOnly();
                        /*0x23266f4*/ System.Type get_PropertyType();
                        /*0x2326710*/ bool CanResetValue(object component);
                        /*0x2326718*/ object GetValue(object component);
                        /*0x2326720*/ void ResetValue(object component);
                        /*0x2326724*/ void SetValue(object component, object value);
                        /*0x2326728*/ bool ShouldSerializeValue(object component);
                    }
                }
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

            interface IRootDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable
            {
            }

            interface ITypeDescriptorFilterService
            {
                bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
                bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
                bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
            }

            namespace Serialization
            {
                class DesignerSerializerAttribute : System.Attribute
                {
                    /*0x10*/ string serializerTypeName;
                    /*0x18*/ string serializerBaseTypeName;
                    /*0x20*/ string typeId;

                    /*0x17d4534*/ DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName);
                    /*0x17d456c*/ object get_TypeId();
                }

                class InstanceDescriptor
                {
                    /*0x10*/ System.Reflection.MemberInfo member;
                    /*0x18*/ System.Collections.ICollection arguments;
                    /*0x20*/ bool isComplete;

                    /*0x1cbad98*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments);
                    /*0x1cbada0*/ InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete);
                    /*0x1cbb27c*/ object Invoke();
                }

                class RootDesignerSerializerAttribute : System.Attribute
                {
                    /*0x10*/ bool reloadable;
                    /*0x18*/ string serializerTypeName;
                    /*0x20*/ string serializerBaseTypeName;
                    /*0x28*/ string typeId;

                    /*0x18596b4*/ RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable);
                    /*0x18596f8*/ object get_TypeId();
                }
            }
        }
    }

    namespace Security
    {
        namespace Authentication
        {
            class AuthenticationException : System.SystemException
            {
                /*0x1cfdd3c*/ AuthenticationException();
                /*0x1cfdd98*/ AuthenticationException(string message, System.Exception innerException);
                /*0x1cfdda0*/ AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            }

            enum SslProtocols
            {
                None = 0,
                Ssl2 = 12,
                Ssl3 = 48,
                Tls = 192,
                Tls11 = 768,
                Tls12 = 3072,
                Default = 240,
            }
        }

        namespace Cryptography
        {
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

            class Oid
            {
                /*0x10*/ string m_value;
                /*0x18*/ string m_friendlyName;
                /*0x20*/ System.Security.Cryptography.OidGroup m_group;

                /*0x1eb3860*/ Oid(string oid);
                /*0x1eb38ac*/ Oid(string oid, System.Security.Cryptography.OidGroup group, bool lookupFriendlyName);
                /*0x1eb390c*/ Oid(string value, string friendlyName);
                /*0x1eb3944*/ Oid(System.Security.Cryptography.Oid oid);
                /*0x1eb39d0*/ string get_Value();
                /*0x1eb39d8*/ void set_Value(string value);
                /*0x1eb39e0*/ string get_FriendlyName();
            }

            class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ArrayList m_list;

                /*0x1eb3a28*/ OidCollection();
                /*0x1eb3a90*/ int Add(System.Security.Cryptography.Oid oid);
                /*0x1eb3ab4*/ System.Security.Cryptography.Oid get_Item(int index);
                /*0x1eb3b38*/ int get_Count();
                /*0x1eb3b5c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1eb3bf8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1eb3ddc*/ bool get_IsSynchronized();
                /*0x1eb3de4*/ object get_SyncRoot();
            }

            class OidEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Security.Cryptography.OidCollection m_oids;
                /*0x18*/ int m_current;

                /*0x1eb3bc4*/ OidEnumerator(System.Security.Cryptography.OidCollection oids);
                /*0x1eb3de8*/ object System.Collections.IEnumerator.get_Current();
                /*0x1eb3e08*/ bool MoveNext();
                /*0x1eb3e70*/ void Reset();
            }

            class CAPI
            {
                static /*0x1d011a4*/ string CryptFindOIDInfoNameFromKey(string key, System.Security.Cryptography.OidGroup oidGroup);
                static /*0x1d01d0c*/ string CryptFindOIDInfoKeyFromName(string name, System.Security.Cryptography.OidGroup oidGroup);
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

                /*0x1cfb1f8*/ AsnEncodedData();
                /*0x1cfb200*/ AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData);
                /*0x1cfb248*/ void set_Oid(System.Security.Cryptography.Oid value);
                /*0x1cfb390*/ byte[] get_RawData();
                /*0x1cfb2c0*/ void set_RawData(byte[] value);
                /*0x1cfb398*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x1cfb490*/ string ToString(bool multiLine);
                /*0x1cfc268*/ string Default(bool multiLine);
                /*0x1cfb664*/ string BasicConstraintsExtension(bool multiLine);
                /*0x1cfb778*/ string EnhancedKeyUsageExtension(bool multiLine);
                /*0x1cfb88c*/ string KeyUsageExtension(bool multiLine);
                /*0x1cfb9a0*/ string SubjectKeyIdentifierExtension(bool multiLine);
                /*0x1cfbab4*/ string SubjectAltName(bool multiLine);
                /*0x1cfbe84*/ string NetscapeCertType(bool multiLine);
            }

            namespace X509Certificates
            {
                enum StoreLocation
                {
                    CurrentUser = 1,
                    LocalMachine = 2,
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

                class X509Utils
                {
                    static /*0x1476f58*/ string FindOidInfo(uint keyType, string keyValue, System.Security.Cryptography.OidGroup oidGroup);
                    static /*0x1477064*/ string FindOidInfoWithFallback(uint key, string value, System.Security.Cryptography.OidGroup group);
                }

                class PublicKey
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Security.Cryptography.AsymmetricAlgorithm _key;
                    /*0x18*/ System.Security.Cryptography.AsnEncodedData _keyValue;
                    /*0x20*/ System.Security.Cryptography.AsnEncodedData _params;
                    /*0x28*/ System.Security.Cryptography.Oid _oid;

                    static /*0x1eb9bbc*/ PublicKey();
                    static /*0x1eb9b14*/ byte[] GetUnsignedBigInteger(byte[] integer);
                    static /*0x1eb9670*/ System.Security.Cryptography.DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters);
                    static /*0x1eb92b4*/ System.Security.Cryptography.RSA DecodeRSA(byte[] rawPublicKey);
                    /*0x1eb8cd0*/ PublicKey(Mono.Security.X509.X509Certificate certificate);
                    /*0x1eb90d8*/ System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue();
                    /*0x1eb90e0*/ System.Security.Cryptography.AsnEncodedData get_EncodedParameters();
                    /*0x1eb90e8*/ System.Security.Cryptography.AsymmetricAlgorithm get_Key();
                    /*0x1eb9b0c*/ System.Security.Cryptography.Oid get_Oid();
                }

                class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
                {
                }

                class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.19";
                    static string friendlyName = "Basic Constraints";
                    /*0x21*/ bool _certificateAuthority;
                    /*0x22*/ bool _hasPathLengthConstraint;
                    /*0x24*/ int _pathLengthConstraint;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x170f27c*/ X509BasicConstraintsExtension();
                    /*0x170f31c*/ X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical);
                    /*0x170f5c8*/ X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical);
                    /*0x170f874*/ bool get_CertificateAuthority();
                    /*0x170f8e0*/ bool get_HasPathLengthConstraint();
                    /*0x170f94c*/ int get_PathLengthConstraint();
                    /*0x170f9b8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x170f3e8*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x170f700*/ byte[] Encode();
                    /*0x170fb88*/ string ToString(bool multiLine);
                }

                class X509Certificate2 : System.Security.Cryptography.X509Certificates.X509Certificate
                {
                    static /*0x0*/ byte[] signedData;
                    /*0x30*/ string friendlyName;

                    static /*0x1710a60*/ X509Certificate2();
                    static /*0x1710960*/ void AppendBuffer(System.Text.StringBuilder sb, byte[] buffer);
                    /*0x170ffdc*/ X509Certificate2();
                    /*0x1710038*/ X509Certificate2(byte[] rawData);
                    /*0x17100c0*/ X509Certificate2(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x170ff3c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl();
                    /*0x1710144*/ System.DateTime get_NotAfter();
                    /*0x1710188*/ System.DateTime get_NotBefore();
                    /*0x17101cc*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x17101f4*/ System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    /*0x171021c*/ string get_SerialNumber();
                    /*0x1710228*/ System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    /*0x1710250*/ string get_Thumbprint();
                    /*0x171025c*/ int get_Version();
                    /*0x1710284*/ void Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x1710358*/ void Reset();
                    /*0x17103b4*/ string ToString();
                    /*0x1710424*/ string ToString(bool verbose);
                }

                class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection
                {
                    static /*0x0*/ string[] newline_split;

                    static /*0x1710af0*/ X509Certificate2Collection();
                }

                class X509Certificate2Impl : System.Security.Cryptography.X509Certificates.X509CertificateImpl
                {
                    /*0x1710bb0*/ X509Certificate2Impl();
                    System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    int get_Version();
                    System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    void Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    void Reset();
                }

                class X509Certificate2ImplMono : System.Security.Cryptography.X509Certificates.X509Certificate2Impl
                {
                    static /*0x0*/ string empty_error;
                    static /*0x8*/ byte[] commonName;
                    static /*0x10*/ byte[] email;
                    static /*0x18*/ byte[] signedData;
                    /*0x18*/ bool _archived;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection _extensions;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.PublicKey _publicKey;
                    /*0x30*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName issuer_name;
                    /*0x38*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName subject_name;
                    /*0x40*/ System.Security.Cryptography.Oid signature_algorithm;
                    /*0x48*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;
                    /*0x50*/ Mono.Security.X509.X509Certificate _cert;

                    static /*0x1712a94*/ X509Certificate2ImplMono();
                    static /*0x171298c*/ void AppendBuffer(System.Text.StringBuilder sb, byte[] buffer);
                    /*0x1710bc8*/ X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert);
                    /*0x1710bf4*/ X509Certificate2ImplMono(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other);
                    /*0x1710fec*/ X509Certificate2ImplMono();
                    /*0x1710bb8*/ bool get_IsValid();
                    /*0x1710c98*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone();
                    /*0x1710d00*/ string GetIssuerName(bool legacyV1Mode);
                    /*0x1710dcc*/ string GetSubjectName(bool legacyV1Mode);
                    /*0x1710e9c*/ byte[] GetRawCertData();
                    /*0x1710ed4*/ byte[] GetCertHash(bool lazy);
                    /*0x1710f30*/ System.DateTime GetValidFrom();
                    /*0x1710f6c*/ System.DateTime GetValidUntil();
                    /*0x1710fa8*/ bool Equals(System.Security.Cryptography.X509Certificates.X509CertificateImpl other, ref bool result);
                    /*0x1710fb4*/ byte[] GetSerialNumber();
                    /*0x1711014*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x1711378*/ System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    /*0x171153c*/ System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    /*0x1711654*/ int get_Version();
                    /*0x17116f4*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password);
                    /*0x1711ef8*/ void Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x1712170*/ void Reset();
                    /*0x1712228*/ string ToString();
                    /*0x1712298*/ string ToString(bool verbose);
                    /*0x1712a8c*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                }

                class X509CertificateCollection : System.Collections.CollectionBase
                {
                    /*0x1712bd0*/ X509CertificateCollection();
                    /*0x1712bd8*/ X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x1712cf8*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Item(int index);
                    /*0x1712c08*/ void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x1712da4*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                    /*0x1712e04*/ int GetHashCode();

                    class X509CertificateEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.IEnumerator enumerator;

                        /*0x232604c*/ X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings);
                        /*0x2326114*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Current();
                        /*0x2326210*/ object System.Collections.IEnumerator.get_Current();
                        /*0x23262c0*/ bool System.Collections.IEnumerator.MoveNext();
                        /*0x232636c*/ void System.Collections.IEnumerator.Reset();
                        /*0x232641c*/ bool MoveNext();
                    }
                }

                class X509CertificateImplCollection : System.IDisposable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list;

                    /*0x1711df8*/ X509CertificateImplCollection();
                    /*0x1712e2c*/ X509CertificateImplCollection(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other);
                    /*0x1712fd8*/ int get_Count();
                    /*0x1713024*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(int index);
                    /*0x1711e74*/ void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, bool takeOwnership);
                    /*0x1710c3c*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone();
                    /*0x17121b0*/ void Dispose();
                    /*0x1713098*/ void Dispose(bool disposing);
                    /*0x17132cc*/ void Finalize();
                }

                class X509Chain : System.IDisposable
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainImpl impl;

                    /*0x17133b4*/ X509Chain();
                    /*0x17133e4*/ X509Chain(bool useMachineContext);
                    /*0x1713474*/ X509Chain(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    /*0x1713340*/ System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl();
                    /*0x17134a8*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x17134e0*/ void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
                    /*0x1713520*/ void Dispose();
                    /*0x1713598*/ void Dispose(bool disposing);
                    /*0x171363c*/ void Finalize();
                }

                class X509ChainElement
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509Certificate2 certificate;
                    /*0x18*/ string info;

                    /*0x17136b0*/ X509ChainElement(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x1713720*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate();
                }

                class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _list;

                    /*0x1713728*/ X509ChainElementCollection();
                    /*0x1713790*/ int get_Count();
                    /*0x17137b4*/ bool get_IsSynchronized();
                    /*0x17137d8*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(int index);
                    /*0x171387c*/ object get_SyncRoot();
                    /*0x17138a0*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x17138c4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x17139ec*/ void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x1713a70*/ void Clear();
                }

                class X509ChainElementEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x1713924*/ X509ChainElementEnumerator(System.Collections.IEnumerable enumerable);
                    /*0x1713a94*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1713b44*/ bool MoveNext();
                    /*0x1713bf0*/ void Reset();
                }

                class X509ChainImpl : System.IDisposable
                {
                    /*0x1713de4*/ X509ChainImpl();
                    bool get_IsValid();
                    /*0x1713ca0*/ void ThrowIfContextInvalid();
                    System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
                    void Reset();
                    /*0x17135c4*/ void Dispose();
                    /*0x1713d6c*/ void Dispose(bool disposing);
                    /*0x1713d70*/ void Finalize();
                }

                class X509ChainImplMono : System.Security.Cryptography.X509Certificates.X509ChainImpl
                {
                    static /*0x0*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] Empty;
                    /*0x10*/ System.Security.Cryptography.X509Certificates.StoreLocation location;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x30*/ System.Security.Cryptography.AsymmetricAlgorithm working_public_key;
                    /*0x38*/ System.Security.Cryptography.X509Certificates.X509ChainElement bce_restriction;
                    /*0x40*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection roots;
                    /*0x48*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection cas;
                    /*0x50*/ System.Security.Cryptography.X509Certificates.X509Store root_store;
                    /*0x58*/ System.Security.Cryptography.X509Certificates.X509Store ca_store;
                    /*0x60*/ System.Security.Cryptography.X509Certificates.X509Store user_root_store;
                    /*0x68*/ System.Security.Cryptography.X509Certificates.X509Store user_ca_store;
                    /*0x70*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection;

                    static /*0x1713fc0*/ X509ChainImplMono();
                    /*0x1713dec*/ X509ChainImplMono(bool useMachineContext);
                    /*0x1713ed0*/ bool get_IsValid();
                    /*0x1713ed8*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x1713ee0*/ void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
                    /*0x1713ee8*/ void Reset();
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

                    /*0x1713ea8*/ X509ChainPolicy();
                    /*0x17145a4*/ X509ChainPolicy(System.Security.Cryptography.X509Certificates.X509CertificateCollection store);
                    /*0x17144a0*/ void Reset();
                }

                struct X509ChainStatus
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status;
                    /*0x18*/ string info;

                    static /*0x17145d4*/ string GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0xac324c*/ X509ChainStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                }

                class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    /*0x28*/ System.Security.Cryptography.OidCollection _enhKeyUsage;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x1714794*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical);
                    /*0x1714ac0*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x1714860*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x1714c90*/ string ToString(bool multiLine);
                }

                class X509Extension : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ bool _critical;

                    /*0x170f314*/ X509Extension();
                    /*0x1714f78*/ bool get_Critical();
                    /*0x1714f80*/ void set_Critical(bool value);
                    /*0x1714f8c*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x170fe08*/ string FormatUnkownData(byte[] data);
                }

                class X509ExtensionCollection
                {
                    static /*0x0*/ byte[] Empty;

                    static /*0x17150bc*/ X509ExtensionCollection();
                }

                class X509Helper2
                {
                    static /*0x1715128*/ void Initialize();
                    static /*0x170ffd4*/ void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl);
                    static /*0x17102c0*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, bool disableProvider);
                    static /*0x1713418*/ System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(bool useMachineContext);
                    static /*0x1715184*/ bool IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x1713368*/ void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x1713ce8*/ System.Exception GetInvalidChainContextException();

                    class MyNativeHelper : System.Security.Cryptography.X509Certificates.INativeCertificateHelper
                    {
                        /*0x23264c8*/ MyNativeHelper();
                    }
                }

                class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.15";
                    static string friendlyName = "Key Usage";
                    static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all = 33023;
                    /*0x24*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x1715198*/ X509KeyUsageExtension();
                    /*0x1715230*/ X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical);
                    /*0x17154cc*/ X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical);
                    /*0x1715728*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages();
                    /*0x1715794*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x17155a0*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags);
                    /*0x17152fc*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x17155b0*/ byte[] Encode();
                    /*0x1715964*/ string ToString(bool multiLine);
                }

                class X509Store
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection list;
                    /*0x18*/ Mono.Security.X509.X509Store store;

                    /*0x1475eb8*/ void Close();
                }

                class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.14";
                    static string friendlyName = "Subject Key Identifier";
                    /*0x28*/ byte[] _subjectKeyIdentifier;
                    /*0x30*/ string _ski;
                    /*0x38*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    static /*0x1476c28*/ byte FromHexChar(char c);
                    static /*0x1476c70*/ byte FromHexChars(char c1, char c2);
                    static /*0x147651c*/ byte[] FromHex(string hex);
                    /*0x1475ed4*/ X509SubjectKeyIdentifierExtension();
                    /*0x1475f6c*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical);
                    /*0x14761b4*/ X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical);
                    /*0x14763c0*/ X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical);
                    /*0x1476620*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical);
                    /*0x147662c*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical);
                    /*0x14769c8*/ string get_SubjectKeyIdentifier();
                    /*0x1476a58*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x1476038*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x1476348*/ byte[] Encode();
                    /*0x1476d0c*/ string ToString(bool multiLine);
                }
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

                static /*0x17e6638*/ void ThrowStreamClosedException();
                /*0x17e608c*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x17e6094*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x17e6150*/ bool get_CanRead();
                /*0x17e6168*/ bool get_CanWrite();
                /*0x17e6180*/ bool get_CanSeek();
                /*0x17e6198*/ long get_Length();
                /*0x17e61ec*/ long get_Position();
                /*0x17e6240*/ void set_Position(long value);
                /*0x17e6294*/ void Flush();
                /*0x17e62d0*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x17e6324*/ int ReadByte();
                /*0x17e6348*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x17e6408*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x17e6454*/ int Read(byte[] array, int offset, int count);
                /*0x17e6478*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x17e6538*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x17e6544*/ void Write(byte[] array, int offset, int count);
                /*0x17e6568*/ void Dispose(bool disposing);
                /*0x17e65f0*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x17e6614*/ System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x17e62b8*/ void CheckDeflateStream();
            }

            class DeflateStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream base_stream;
                /*0x30*/ System.IO.Compression.CompressionMode mode;
                /*0x34*/ bool leaveOpen;
                /*0x35*/ bool disposed;
                /*0x38*/ System.IO.Compression.DeflateStreamNative native;

                /*0x17d1c1c*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x17d1d94*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen, int windowsBits);
                /*0x17d1c28*/ DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen, bool gzip);
                /*0x17d1ee8*/ void Dispose(bool disposing);
                /*0x17d2038*/ int ReadInternal(byte[] array, int offset, int count);
                /*0x17d20f0*/ int Read(byte[] array, int offset, int count);
                /*0x17d22c4*/ void WriteInternal(byte[] array, int offset, int count);
                /*0x17d236c*/ void Write(byte[] array, int offset, int count);
                /*0x17d254c*/ void Flush();
                /*0x17d2650*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x17d28c8*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x17d2b40*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x17d2c84*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x17d2dc8*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x17d2e08*/ bool get_CanRead();
                /*0x17d2e40*/ bool get_CanSeek();
                /*0x17d2e48*/ bool get_CanWrite();
                /*0x17d2e84*/ long get_Length();
                /*0x17d2ec4*/ long get_Position();
                /*0x17d2f04*/ void set_Position(long value);

                class ReadMethod : System.MulticastDelegate
                {
                    /*0x147d30c*/ ReadMethod(object object, nint method);
                    /*0x147d36c*/ int Invoke(byte[] array, int offset, int count);
                    /*0x147d72c*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x147d7dc*/ int EndInvoke(System.IAsyncResult result);
                }

                class WriteMethod : System.MulticastDelegate
                {
                    /*0x147d808*/ WriteMethod(object object, nint method);
                    /*0x147d868*/ void Invoke(byte[] array, int offset, int count);
                    /*0x147dc20*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x147dcd0*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class DeflateStreamNative
            {
                /*0x10*/ System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder;
                /*0x18*/ System.IO.Stream base_stream;
                /*0x20*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle z_stream;
                /*0x28*/ System.Runtime.InteropServices.GCHandle data;
                /*0x2c*/ bool disposed;
                /*0x30*/ byte[] io_buffer;

                static /*0x17d1da0*/ System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool gzip);
                static /*0x17d2f44*/ int UnmanagedRead(nint buffer, int length, nint data);
                static /*0x17d300c*/ int UnmanagedWrite(nint buffer, int length, nint data);
                static /*0x17d3258*/ void CheckResult(int result, string where);
                static /*0x17d30dc*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, bool gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, nint data);
                static /*0x17d36f0*/ int CloseZStream(nint stream);
                static /*0x17d31e8*/ int Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream);
                static /*0x17d3350*/ int ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                static /*0x17d33d0*/ int WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                /*0x17d30d4*/ DeflateStreamNative();
                /*0x17d317c*/ void Finalize();
                /*0x17d1f6c*/ void Dispose(bool disposing);
                /*0x17d2600*/ void Flush();
                /*0x17d207c*/ int ReadZStream(nint buffer, int length);
                /*0x17d2304*/ void WriteZStream(nint buffer, int length);
                /*0x17d3450*/ int UnmanagedRead(nint buffer, int length);
                /*0x17d3584*/ int UnmanagedWrite(nint buffer, int length);

                class UnmanagedReadOrWrite : System.MulticastDelegate
                {
                    /*0x147dd90*/ UnmanagedReadOrWrite(object object, nint method);
                    /*0x147ddf0*/ int Invoke(nint buffer, int length, nint data);
                    /*0x147e054*/ System.IAsyncResult BeginInvoke(nint buffer, int length, nint data, System.AsyncCallback callback, object object);
                    /*0x147e120*/ int EndInvoke(System.IAsyncResult result);
                }

                class SafeDeflateStreamHandle : System.Runtime.InteropServices.SafeHandle
                {
                    /*0x147dd24*/ SafeDeflateStreamHandle();
                    /*0x147dcdc*/ bool get_IsInvalid();
                    /*0x147dd70*/ bool ReleaseHandle();
                }
            }
        }
    }

    namespace Collections
    {
        namespace Specialized
        {
            struct BitVector32
            {
                /*0x10*/ uint data;

                static /*0x1d00090*/ int CreateMask();
                static /*0x1d00098*/ int CreateMask(int previous);
                static /*0x1d00208*/ string ToString(System.Collections.Specialized.BitVector32 value);
                /*0xadafc8*/ bool get_Item(int bit);
                /*0xadafe0*/ void set_Item(int bit, bool value);
                /*0xadaffc*/ bool Equals(object o);
                /*0xadb004*/ int GetHashCode();
                /*0xadb00c*/ string ToString();
            }

            class HybridDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Specialized.ListDictionary list;
                /*0x18*/ System.Collections.Hashtable hashtable;
                /*0x20*/ bool caseInsensitive;

                /*0x1cb565c*/ HybridDictionary();
                /*0x1cb5664*/ HybridDictionary(bool caseInsensitive);
                /*0x1cb5694*/ object get_Item(object key);
                /*0x1cb58c4*/ void set_Item(object key, object value);
                /*0x1cb5ee0*/ System.Collections.Specialized.ListDictionary get_List();
                /*0x1cb5a28*/ void ChangeOver();
                /*0x1cb6034*/ int get_Count();
                /*0x1cb6068*/ System.Collections.ICollection get_Keys();
                /*0x1cb610c*/ bool get_IsSynchronized();
                /*0x1cb6114*/ object get_SyncRoot();
                /*0x1cb6118*/ void Add(object key, object value);
                /*0x1cb649c*/ bool Contains(object key);
                /*0x1cb66b8*/ void CopyTo(System.Array array, int index);
                /*0x1cb68d4*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x1cb69f4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1cb6b14*/ void Remove(object key);
            }

            interface INotifyCollectionChanged
            {
                void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
            }

            class ListDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Specialized.ListDictionary.DictionaryNode head;
                /*0x18*/ int version;
                /*0x1c*/ int count;
                /*0x20*/ System.Collections.IComparer comparer;
                /*0x28*/ object _syncRoot;

                /*0x1cbe420*/ ListDictionary();
                /*0x1cb5eb4*/ ListDictionary(System.Collections.IComparer comparer);
                /*0x1cb5738*/ object get_Item(object key);
                /*0x1cb5ccc*/ void set_Item(object key, object value);
                /*0x1cbe428*/ int get_Count();
                /*0x1cb60a8*/ System.Collections.ICollection get_Keys();
                /*0x1cbe430*/ bool get_IsSynchronized();
                /*0x1cbe438*/ object get_SyncRoot();
                /*0x1cb6280*/ void Add(object key, object value);
                /*0x1cb6540*/ bool Contains(object key);
                /*0x1cb671c*/ void CopyTo(System.Array array, int index);
                /*0x1cb5fd4*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x1cbe4b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1cb6bb4*/ void Remove(object key);

                class NodeEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary list;
                    /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode current;
                    /*0x20*/ int version;
                    /*0x24*/ bool start;

                    /*0x1481ae4*/ NodeEnumerator(System.Collections.Specialized.ListDictionary list);
                    /*0x1481b2c*/ object get_Current();
                    /*0x1481b94*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x1481c24*/ object get_Key();
                    /*0x1481c90*/ object get_Value();
                    /*0x1481cfc*/ bool MoveNext();
                    /*0x1481dac*/ void Reset();
                }

                class NodeKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary list;
                    /*0x18*/ bool isKeys;

                    /*0x1481e3c*/ NodeKeyValueCollection(System.Collections.Specialized.ListDictionary list, bool isKeys);
                    /*0x1481e7c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x1481fac*/ int System.Collections.ICollection.get_Count();
                    /*0x1481fe4*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1481fec*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x1482008*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class NodeKeyValueEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.Specialized.ListDictionary list;
                        /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode current;
                        /*0x20*/ int version;
                        /*0x24*/ bool isKeys;
                        /*0x25*/ bool start;

                        /*0x2326730*/ NodeKeyValueEnumerator(System.Collections.Specialized.ListDictionary list, bool isKeys);
                        /*0x232678c*/ object get_Current();
                        /*0x232680c*/ bool MoveNext();
                        /*0x23268bc*/ void Reset();
                    }
                }

                class DictionaryNode
                {
                    /*0x10*/ object key;
                    /*0x18*/ object value;
                    /*0x20*/ System.Collections.Specialized.ListDictionary.DictionaryNode next;

                    /*0x1481adc*/ DictionaryNode();
                }
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

                static /*0x1cc86e0*/ NameObjectCollectionBase();
                /*0x1cc6c10*/ NameObjectCollectionBase();
                /*0x1cc6c7c*/ NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer);
                /*0x1cc6dc0*/ NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x1cc6eac*/ NameObjectCollectionBase(System.DBNull dummy);
                /*0x1cc6eb4*/ NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1cc6ee0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1cc74fc*/ void OnDeserialization(object sender);
                /*0x1cc6d10*/ void Reset();
                /*0x1cc6df0*/ void Reset(int capacity);
                /*0x1cc7d94*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(string key);
                /*0x1cc7e58*/ bool get_IsReadOnly();
                /*0x1cc7c34*/ void BaseAdd(string name, object value);
                /*0x1cc7e60*/ void BaseRemove(string name);
                /*0x1cc8118*/ object BaseGet(string name);
                /*0x1cc8134*/ void BaseSet(string name, object value);
                /*0x1cc81ec*/ object BaseGet(int index);
                /*0x1cc8070*/ string BaseGetKey(int index);
                /*0x1cc8294*/ System.Collections.IEnumerator GetEnumerator();
                /*0x1cc82f4*/ int get_Count();
                /*0x1cc8318*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1cc8660*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1cc86d8*/ bool System.Collections.ICollection.get_IsSynchronized();

                class NameObjectEntry
                {
                    /*0x10*/ string Key;
                    /*0x18*/ object Value;

                    /*0x1484528*/ NameObjectEntry(string name, object value);
                }

                class NameObjectKeysEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ int _pos;
                    /*0x18*/ System.Collections.Specialized.NameObjectCollectionBase _coll;
                    /*0x20*/ int _version;

                    /*0x1484560*/ NameObjectKeysEnumerator(System.Collections.Specialized.NameObjectCollectionBase coll);
                    /*0x14845a4*/ bool MoveNext();
                    /*0x1484680*/ void Reset();
                    /*0x148470c*/ object get_Current();
                }
            }

            class CompatibleComparer : System.Collections.IEqualityComparer
            {
                static /*0x0*/ System.Collections.IComparer defaultComparer;
                static /*0x8*/ System.Collections.IHashCodeProvider defaultHashProvider;
                /*0x10*/ System.Collections.IComparer _comparer;
                /*0x18*/ System.Collections.IHashCodeProvider _hcp;

                static /*0x1d08c28*/ System.Collections.IComparer get_DefaultComparer();
                static /*0x1d08d10*/ System.Collections.IHashCodeProvider get_DefaultHashCodeProvider();
                /*0x1d088ac*/ CompatibleComparer(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider);
                /*0x1d088e4*/ bool Equals(object a, object b);
                /*0x1d08af8*/ int GetHashCode(object obj);
                /*0x1d08c18*/ System.Collections.IComparer get_Comparer();
                /*0x1d08c20*/ System.Collections.IHashCodeProvider get_HashCodeProvider();
            }

            class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase
            {
                /*0x50*/ string[] _all;
                /*0x58*/ string[] _allKeys;

                static /*0x1cc8960*/ string GetAsOneString(System.Collections.ArrayList list);
                static /*0x1cc8b20*/ string[] GetAsStringArray(System.Collections.ArrayList list);
                /*0x1cc879c*/ NameValueCollection();
                /*0x1cc87fc*/ NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x1cc887c*/ NameValueCollection(System.DBNull dummy);
                /*0x1cc88e0*/ NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1cc8958*/ void InvalidateCachedArrays();
                /*0x1cc8bcc*/ void Add(string name, string value);
                /*0x1cc8d48*/ string Get(string name);
                /*0x1cc8de0*/ string[] GetValues(string name);
                /*0x1cc8e78*/ void Set(string name, string value);
                /*0x1cc8f6c*/ void Remove(string name);
                /*0x1cb4d2c*/ string get_Item(string name);
                /*0x1cc8f74*/ void set_Item(string name, string value);
                /*0x1cc8f84*/ string Get(int index);
                /*0x1cc9014*/ string GetKey(int index);
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

                /*0x1ccbbac*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action);
                /*0x1ccbdc4*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index);
                /*0x1ccbfc0*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem, int index);
                /*0x1ccc230*/ NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex);
                /*0x1ccbfa8*/ void InitializeAddOrRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int startingIndex);
                /*0x1ccbd28*/ void InitializeAdd(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, int newStartingIndex);
                /*0x1ccc428*/ void InitializeRemove(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList oldItems, int oldStartingIndex);
                /*0x1ccc1e8*/ void InitializeMoveOrReplace(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex, int oldStartingIndex);
            }

            class NotifyCollectionChangedEventHandler : System.MulticastDelegate
            {
                /*0x1eb1c94*/ NotifyCollectionChangedEventHandler(object object, nint method);
                /*0x1eb1cf4*/ void Invoke(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                /*0x1eb2088*/ System.IAsyncResult BeginInvoke(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e, System.AsyncCallback callback, object object);
                /*0x1eb20b8*/ void EndInvoke(System.IAsyncResult result);
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

                /*0x1eb3e7c*/ OrderedDictionary();
                /*0x1eb3ea8*/ OrderedDictionary(int capacity);
                /*0x1eb3ed8*/ OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer);
                /*0x1eb3f14*/ OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1eb3f40*/ int get_Count();
                /*0x1eb3fe0*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1eb3fe8*/ System.Collections.ICollection get_Keys();
                /*0x1eb3f68*/ System.Collections.ArrayList get_objectsArray();
                /*0x1eb405c*/ System.Collections.Hashtable get_objectsTable();
                /*0x1eb40dc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1eb4154*/ object get_Item(object key);
                /*0x1eb418c*/ void set_Item(object key, object value);
                /*0x1eb45d8*/ System.Collections.ICollection get_Values();
                /*0x1eb44a8*/ void Add(object key, object value);
                /*0x1eb464c*/ bool Contains(object key);
                /*0x1eb4684*/ void CopyTo(System.Array array, int index);
                /*0x1eb4314*/ int IndexOfKey(object key);
                /*0x1eb46c4*/ void OnDeserialization(object sender);
                /*0x1eb4a68*/ void Remove(object key);
                /*0x1eb4b94*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x1eb4c08*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1eb4c7c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x1eb4e4c*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);

                class OrderedDictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ int _objectReturnType;
                    /*0x18*/ System.Collections.IEnumerator arrayEnumerator;

                    /*0x1484874*/ OrderedDictionaryEnumerator(System.Collections.ArrayList array, int objectReturnType);
                    /*0x14848cc*/ object get_Current();
                    /*0x1484aa4*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x1484c4c*/ object get_Key();
                    /*0x1484d3c*/ object get_Value();
                    /*0x1484e2c*/ bool MoveNext();
                    /*0x1484ed8*/ void Reset();
                }

                class OrderedDictionaryKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _objects;
                    /*0x18*/ bool isKeys;

                    /*0x1484f88*/ OrderedDictionaryKeyValueCollection(System.Collections.ArrayList array, bool isKeys);
                    /*0x1484fc8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x1485334*/ int System.Collections.ICollection.get_Count();
                    /*0x1485358*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1485360*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x1485384*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class StringCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ArrayList data;

                /*0x1867958*/ StringCollection();
                /*0x18673a0*/ string get_Item(int index);
                /*0x1867428*/ void set_Item(int index, string value);
                /*0x186744c*/ int get_Count();
                /*0x1867470*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x1867478*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x1867480*/ int Add(string value);
                /*0x18674a4*/ void Clear();
                /*0x18674c8*/ bool Contains(string value);
                /*0x18674ec*/ void CopyTo(string[] array, int index);
                /*0x1867510*/ int IndexOf(string value);
                /*0x1867534*/ void Insert(int index, string value);
                /*0x1867558*/ bool get_IsSynchronized();
                /*0x1867560*/ void Remove(string value);
                /*0x1867584*/ void RemoveAt(int index);
                /*0x18675a8*/ object get_SyncRoot();
                /*0x18675cc*/ object System.Collections.IList.get_Item(int index);
                /*0x18675d0*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x1867660*/ int System.Collections.IList.Add(object value);
                /*0x18676e8*/ bool System.Collections.IList.Contains(object value);
                /*0x1867770*/ int System.Collections.IList.IndexOf(object value);
                /*0x18677f8*/ void System.Collections.IList.Insert(int index, object value);
                /*0x1867888*/ void System.Collections.IList.Remove(object value);
                /*0x1867910*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1867934*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class StringDictionary : System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable contents;

                /*0x1867c6c*/ StringDictionary();
                /*0x1867cd0*/ string get_Item(string key);
                /*0x1867dec*/ System.Collections.IEnumerator GetEnumerator();
            }
        }

        namespace ObjectModel
        {
            class ObservableCollection<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
            {
                /*0x0*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
                /*0x0*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
                /*0x0*/ System.Collections.ObjectModel.ObservableCollection.SimpleMonitor<T> _monitor;

                ObservableCollection();
                void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                void ClearItems();
                void RemoveItem(int index);
                void InsertItem(int index, T item);
                void SetItem(int index, T item);
                void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e);
                void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                System.IDisposable BlockReentrancy();
                void CheckReentrancy();
                void OnPropertyChanged(string propertyName);
                void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, object item, int index);
                void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedAction action, object oldItem, object newItem, int index);
                void OnCollectionReset();

                class SimpleMonitor<T> : System.IDisposable
                {
                    /*0x0*/ int _busyCount;

                    SimpleMonitor();
                    void Enter();
                    void Dispose();
                    bool get_Busy();
                }
            }

            class ReadOnlyObservableCollection<T> : System.Collections.ObjectModel.ReadOnlyCollection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
            {
                /*0x0*/ System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
                /*0x0*/ System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

                ReadOnlyObservableCollection(System.Collections.ObjectModel.ObservableCollection<T> list);
                void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value);
                void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs args);
                void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value);
                void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args);
                void HandleCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
                void HandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e);
            }
        }

        namespace Generic
        {
            class EnumerableHelpers
            {
                static T[] ToArray<T>(System.Collections.Generic.IEnumerable<T> source, ref int length);
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

                LinkedList();
                LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                int get_Count();
                System.Collections.Generic.LinkedListNode<T> get_First();
                bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                void System.Collections.Generic.ICollection<T>.Add(T value);
                System.Collections.Generic.LinkedListNode<T> AddFirst(T value);
                void AddFirst(System.Collections.Generic.LinkedListNode<T> node);
                System.Collections.Generic.LinkedListNode<T> AddLast(T value);
                void Clear();
                bool Contains(T value);
                void CopyTo(T[] array, int index);
                System.Collections.Generic.LinkedListNode<T> Find(T value);
                System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                bool Remove(T value);
                void Remove(System.Collections.Generic.LinkedListNode<T> node);
                void RemoveLast();
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

            class Queue<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>
            {
                static int MinimumGrow = 4;
                static int GrowFactor = 200;
                /*0x0*/ T[] _array;
                /*0x0*/ int _head;
                /*0x0*/ int _tail;
                /*0x0*/ int _size;
                /*0x0*/ int _version;
                /*0x0*/ object _syncRoot;

                Queue();
                Queue(int capacity);
                int get_Count();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void Clear();
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                void Enqueue(T item);
                System.Collections.Generic.Queue.Enumerator<T> GetEnumerator();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                T Dequeue();
                void SetCapacity(int capacity);
                void MoveNext(ref int index);
                void ThrowForEmptyQueue();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.Queue<T> _q;
                    /*0x0*/ int _version;
                    /*0x0*/ int _index;
                    /*0x0*/ T _currentElement;

                    Enumerator(System.Collections.Generic.Queue<T> q);
                    void Dispose();
                    bool MoveNext();
                    T get_Current();
                    void ThrowEnumerationNotStartedOrEnded();
                    object System.Collections.IEnumerator.get_Current();
                    void System.Collections.IEnumerator.Reset();
                }
            }

            class QueueDebugView<T>
            {
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
                System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> get_Values();
                System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
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
                System.Collections.ICollection System.Collections.IDictionary.get_Keys();
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

                        <>c__DisplayClass6_0();
                    }

                    class <>c__DisplayClass6_1<TKey, TValue>
                    {
                        /*0x0*/ object[] objects;
                        /*0x0*/ System.Collections.Generic.SortedDictionary.KeyCollection.<>c__DisplayClass6_0<TKey, TValue> CS$<>8__locals1;

                        <>c__DisplayClass6_1();
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

                        <>c__DisplayClass6_0();
                    }

                    class <>c__DisplayClass6_1<TKey, TValue>
                    {
                        /*0x0*/ object[] objects;
                        /*0x0*/ System.Collections.Generic.SortedDictionary.ValueCollection.<>c__DisplayClass6_0<TKey, TValue> CS$<>8__locals1;

                        <>c__DisplayClass6_1();
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

                static bool IsCompatibleKey(object key);
                SortedList();
                SortedList(int capacity);
                void Add(TKey key, TValue value);
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                void set_Capacity(int value);
                void System.Collections.IDictionary.Add(object key, object value);
                int get_Count();
                System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                System.Collections.Generic.SortedList.KeyList<TKey, TValue> GetKeyListHelper();
                System.Collections.Generic.SortedList.ValueList<TKey, TValue> GetValueListHelper();
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void Clear();
                bool System.Collections.IDictionary.Contains(object key);
                bool ContainsKey(TKey key);
                bool ContainsValue(TValue value);
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                void EnsureCapacity(int min);
                TValue GetByIndex(int index);
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                TKey GetKey(int index);
                TValue get_Item(TKey key);
                void set_Item(TKey key, TValue value);
                object System.Collections.IDictionary.get_Item(object key);
                void System.Collections.IDictionary.set_Item(object key, object value);
                int IndexOfKey(TKey key);
                int IndexOfValue(TValue value);
                void Insert(int index, TKey key, TValue value);
                bool TryGetValue(TKey key, ref TValue value);
                void RemoveAt(int index);
                bool Remove(TKey key);
                void System.Collections.IDictionary.Remove(object key);

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ TKey _key;
                    /*0x0*/ TValue _value;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ int _getEnumeratorRetType;

                    Enumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList, int getEnumeratorRetType);
                    void Dispose();
                    object System.Collections.IDictionaryEnumerator.get_Key();
                    bool MoveNext();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                    System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    object System.Collections.IDictionaryEnumerator.get_Value();
                    void System.Collections.IEnumerator.Reset();
                }

                class SortedListKeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TKey _currentKey;

                    SortedListKeyEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    void Dispose();
                    bool MoveNext();
                    TKey get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    void System.Collections.IEnumerator.Reset();
                }

                class SortedListValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TValue _currentValue;

                    SortedListValueEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    void Dispose();
                    bool MoveNext();
                    TValue get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    void System.Collections.IEnumerator.Reset();
                }

                class KeyList<TKey, TValue> : System.Collections.Generic.IList<TKey>, System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    KeyList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    int get_Count();
                    bool get_IsReadOnly();
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();
                    void Add(TKey key);
                    void Clear();
                    bool Contains(TKey key);
                    void CopyTo(TKey[] array, int arrayIndex);
                    void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    void Insert(int index, TKey value);
                    TKey get_Item(int index);
                    void set_Item(int index, TKey value);
                    System.Collections.Generic.IEnumerator<TKey> GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    int IndexOf(TKey key);
                    bool Remove(TKey key);
                    void RemoveAt(int index);
                }

                class ValueList<TKey, TValue> : System.Collections.Generic.IList<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    ValueList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    int get_Count();
                    bool get_IsReadOnly();
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();
                    void Add(TValue key);
                    void Clear();
                    bool Contains(TValue value);
                    void CopyTo(TValue[] array, int arrayIndex);
                    void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    void Insert(int index, TValue value);
                    TValue get_Item(int index);
                    void set_Item(int index, TValue value);
                    System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    int IndexOf(TValue value);
                    bool Remove(TValue value);
                    void RemoveAt(int index);
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

                    <>c__DisplayClass53_0();
                }

                class <>c__DisplayClass53_<T>
                {
                    /*0x0*/ object[] objects;
                    /*0x0*/ System.Collections.Generic.SortedSet.<>c__DisplayClass53_0<T> CS$<>8__locals1;

                    <>c__DisplayClass53_();
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
                System.IAsyncResult BeginInvoke(System.Collections.Generic.SortedSet.Node<T> node, System.AsyncCallback callback, object object);
                bool EndInvoke(System.IAsyncResult result);
            }

            enum TreeRotation
            {
                Left = 0,
                LeftRight = 1,
                Right = 2,
                RightLeft = 3,
            }

            class Stack<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>
            {
                static int DefaultCapacity = 4;
                /*0x0*/ T[] _array;
                /*0x0*/ int _size;
                /*0x0*/ int _version;
                /*0x0*/ object _syncRoot;

                Stack();
                Stack(int capacity);
                Stack(System.Collections.Generic.IEnumerable<T> collection);
                int get_Count();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void Clear();
                bool Contains(T item);
                void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                System.Collections.Generic.Stack.Enumerator<T> GetEnumerator();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                T Peek();
                T Pop();
                void Push(T item);
                void ThrowForEmptyStack();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.Stack<T> _stack;
                    /*0x0*/ int _version;
                    /*0x0*/ int _index;
                    /*0x0*/ T _currentElement;

                    Enumerator(System.Collections.Generic.Stack<T> stack);
                    void Dispose();
                    bool MoveNext();
                    T get_Current();
                    void ThrowEnumerationNotStartedOrEnded();
                    object System.Collections.IEnumerator.get_Current();
                    void System.Collections.IEnumerator.Reset();
                }
            }

            class StackDebugView<T>
            {
            }

            interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
            }
        }

        namespace Concurrent
        {
            class ConcurrentBag<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>
            {
                /*0x0*/ System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>> _locals;
                /*0x0*/ System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> _workStealingQueues;

                ConcurrentBag();
                void Add(T item);
                System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate);
                System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread();
                System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue();
                void CopyTo(T[] array, int index);
                int CopyFromEachQueueToArray(T[] array, int index);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                T[] ToArray();
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                int get_Count();
                int get_DangerousCount();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                object get_GlobalQueuesLock();
                void FreezeBag(ref bool lockTaken);
                void UnfreezeBag(bool lockTaken);

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

                    WorkStealingQueue(System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T> nextQueue);
                    void LocalPush(T item);
                    int DangerousCopyTo(T[] array, int arrayIndex);
                    int get_DangerousCount();
                }

                class Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ T[] _array;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    Enumerator(T[] array);
                    bool MoveNext();
                    T get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    void Reset();
                    void Dispose();
                }
            }
        }
    }

    namespace Net
    {
        class HttpStatusDescription
        {
            static /*0x17e9c10*/ string Get(System.Net.HttpStatusCode code);
            static /*0x17e9c14*/ string Get(int code);
        }

        enum SecurityProtocolType
        {
            SystemDefault = 0,
            Ssl3 = 48,
            Tls = 192,
            Tls11 = 768,
            Tls12 = 3072,
        }

        class Authorization
        {
            /*0x10*/ string m_Message;
            /*0x18*/ bool m_Complete;
            /*0x20*/ string ModuleAuthenticationType;

            /*0x1cfeb24*/ Authorization(string token);
            /*0x1cfebb0*/ Authorization(string token, bool finished);
            /*0x1cfec40*/ string get_Message();
            /*0x1cfec48*/ bool get_Complete();
        }

        class CredentialCache
        {
            static /*0x1d113ac*/ System.Net.ICredentials get_DefaultCredentials();
        }

        class SystemNetworkCredential : System.Net.NetworkCredential
        {
            static /*0x0*/ System.Net.SystemNetworkCredential defaultCredential;

            static /*0x18688e0*/ SystemNetworkCredential();
            /*0x1868880*/ SystemNetworkCredential();
        }

        class EndPoint
        {
            /*0x17d8e28*/ EndPoint();
            /*0x17d8c9c*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x17d8d4c*/ System.Net.SocketAddress Serialize();
            /*0x17d8dfc*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
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

        class GlobalProxySelection
        {
            static /*0x17e0d60*/ System.Net.IWebProxy get_Select();
            static /*0x17e6690*/ System.Net.IWebProxy GetEmptyWebProxy();
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

        enum HttpStatusCode
        {
            Continue = 100,
            SwitchingProtocols = 101,
            OK = 200,
            Created = 201,
            Accepted = 202,
            NonAuthoritativeInformation = 203,
            NoContent = 204,
            ResetContent = 205,
            PartialContent = 206,
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
            UpgradeRequired = 426,
            InternalServerError = 500,
            NotImplemented = 501,
            BadGateway = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504,
            HttpVersionNotSupported = 505,
        }

        class HttpVersion
        {
            static /*0x0*/ System.Version Version10;
            static /*0x8*/ System.Version Version11;

            static /*0x17ea15c*/ HttpVersion();
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

        class IPAddress
        {
            static long LoopbackMask = 255;
            static int IPv4AddressBytes = 4;
            static int IPv6AddressBytes = 16;
            static int NumberOfLabels = 8;
            static /*0x0*/ System.Net.IPAddress Any;
            static /*0x8*/ System.Net.IPAddress Loopback;
            static /*0x10*/ System.Net.IPAddress Broadcast;
            static /*0x18*/ System.Net.IPAddress None;
            static /*0x20*/ System.Net.IPAddress IPv6Any;
            static /*0x28*/ System.Net.IPAddress IPv6Loopback;
            static /*0x30*/ System.Net.IPAddress IPv6None;
            /*0x10*/ long m_Address;
            /*0x18*/ string m_ToString;
            /*0x20*/ System.Net.Sockets.AddressFamily m_Family;
            /*0x28*/ ushort[] m_Numbers;
            /*0x30*/ long m_ScopeId;
            /*0x38*/ int m_HashCode;

            static /*0x1cb8f70*/ IPAddress();
            static /*0x1cb7810*/ bool TryParse(string ipString, ref System.Net.IPAddress address);
            static /*0x1cb7c00*/ System.Net.IPAddress Parse(string ipString);
            static /*0x1cb7894*/ System.Net.IPAddress InternalParse(string ipString, bool tryParse);
            static /*0x1cb8b34*/ bool IsLoopback(System.Net.IPAddress address);
            /*0x1cb7454*/ IPAddress(long newAddress);
            /*0x1cb751c*/ IPAddress(byte[] address, long scopeid);
            /*0x1cb770c*/ IPAddress(ushort[] address, uint scopeid);
            /*0x1cb7794*/ IPAddress(int newAddress);
            /*0x1cb849c*/ byte[] GetAddressBytes();
            /*0x1cb85e0*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x1cb85e8*/ long get_ScopeId();
            /*0x1cb8640*/ string ToString();
            /*0x1cb8c4c*/ bool Equals(object comparandObj, bool compareScopeId);
            /*0x1cb8d88*/ bool Equals(object comparand);
            /*0x1cb8d90*/ int GetHashCode();
            /*0x1cb8e84*/ System.Net.IPAddress MapToIPv6();
        }

        class IPEndPoint : System.Net.EndPoint
        {
            static /*0x0*/ System.Net.IPEndPoint Any;
            static /*0x8*/ System.Net.IPEndPoint IPv6Any;
            /*0x10*/ System.Net.IPAddress m_Address;
            /*0x18*/ int m_Port;

            static /*0x1cb97ac*/ IPEndPoint();
            /*0x1cb9120*/ IPEndPoint(System.Net.IPAddress address, int port);
            /*0x1cb9104*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x1cb9230*/ System.Net.IPAddress get_Address();
            /*0x1cb9238*/ int get_Port();
            /*0x1cb9240*/ string ToString();
            /*0x1cb9304*/ System.Net.SocketAddress Serialize();
            /*0x1cb9378*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
            /*0x1cb9684*/ bool Equals(object comparand);
            /*0x1cb9770*/ int GetHashCode();
        }

        class IPHostEntry
        {
            /*0x10*/ string hostName;
            /*0x18*/ string[] aliases;
            /*0x20*/ System.Net.IPAddress[] addressList;
            /*0x28*/ bool isTrustedHost;

            /*0x1cb9b34*/ IPHostEntry();
            /*0x1cb9b0c*/ string get_HostName();
            /*0x1cb9b14*/ void set_HostName(string value);
            /*0x1cb9b1c*/ void set_Aliases(string[] value);
            /*0x1cb9b24*/ System.Net.IPAddress[] get_AddressList();
            /*0x1cb9b2c*/ void set_AddressList(System.Net.IPAddress[] value);
        }

        interface IWebRequestCreate
        {
            System.Net.WebRequest Create(System.Uri uri);
        }

        class InternalException : System.SystemException
        {
            /*0x1cbbe24*/ InternalException();
        }

        class NclUtilities
        {
            static /*0x0*/ System.Net.IPAddress[] _LocalAddresses;
            static /*0x8*/ object _LocalAddressesLock;
            static /*0x10*/ string _LocalDomainName;

            static /*0x1cc9018*/ bool IsAddressLocal(System.Net.IPAddress ipAddress);
            static /*0x1cc95a0*/ System.Net.IPHostEntry GetLocalHost();
            static /*0x1cc90ac*/ System.Net.IPAddress[] get_LocalAddresses();
            static /*0x1cc95bc*/ object get_LocalAddressesLock();
        }

        class ValidationHelper
        {
            static /*0x0*/ string[] EmptyArray;
            static /*0x8*/ char[] InvalidMethodChars;
            static /*0x10*/ char[] InvalidParamChars;

            static /*0x1701664*/ ValidationHelper();
            static /*0x1701628*/ string MakeStringNull(string stringValue);
            static /*0x170163c*/ bool IsBlankString(string stringValue);
            static /*0x1701658*/ bool ValidateTcpPort(int port);
        }

        class ExceptionHelper
        {
            static /*0x17d8d78*/ System.NotImplementedException get_MethodNotImplementedException();
            static /*0x17d8cc8*/ System.NotImplementedException get_PropertyNotImplementedException();
            static /*0x17dbb44*/ System.NotSupportedException get_PropertyNotSupportedException();
            static /*0x17dbbc8*/ System.Net.WebException get_RequestAbortedException();
        }

        class WebRequestPrefixElement
        {
            /*0x10*/ string Prefix;
            /*0x18*/ System.Net.IWebRequestCreate creator;
            /*0x20*/ System.Type creatorType;

            /*0x170a93c*/ WebRequestPrefixElement(string P, System.Net.IWebRequestCreate C);
            /*0x170a368*/ System.Net.IWebRequestCreate get_Creator();
            /*0x170b58c*/ void set_Creator(System.Net.IWebRequestCreate value);
        }

        class HttpContinueDelegate : System.MulticastDelegate
        {
            /*0x17e96c8*/ HttpContinueDelegate(object object, nint method);
            /*0x17e9728*/ void Invoke(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
            /*0x17e9968*/ System.IAsyncResult BeginInvoke(int StatusCode, System.Net.WebHeaderCollection httpHeaders, System.AsyncCallback callback, object object);
            /*0x17e99fc*/ void EndInvoke(System.IAsyncResult result);
        }

        class NetworkCredential : System.Net.ICredentials
        {
            /*0x10*/ string m_domain;
            /*0x18*/ string m_userName;
            /*0x20*/ System.Security.SecureString m_password;

            /*0x1cc97d8*/ NetworkCredential(string userName, string password);
            /*0x1cc9844*/ NetworkCredential(string userName, string password, string domain);
            /*0x1cc9a20*/ string get_UserName();
            /*0x1cc991c*/ void set_UserName(string value);
            /*0x1cc9a28*/ string get_Password();
            /*0x1cc9988*/ void set_Password(string value);
            /*0x1cc9a40*/ string get_Domain();
            /*0x1cc99b4*/ void set_Domain(string value);
            /*0x1cc9a48*/ string InternalGetUserName();
            /*0x1cc9a34*/ string InternalGetPassword();
            /*0x1cc9a50*/ string InternalGetDomain();
            /*0x1cc9a58*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x1eb8c20*/ ProtocolViolationException();
            /*0x1eb8c28*/ ProtocolViolationException(string message);
            /*0x1eb8c30*/ ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1eb8c38*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1eb8c40*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class SocketAddress
        {
            /*0x10*/ int m_Size;
            /*0x18*/ byte[] m_Buffer;
            /*0x20*/ bool m_changed;
            /*0x24*/ int m_hash;

            /*0x1864d40*/ SocketAddress(System.Net.Sockets.AddressFamily family, int size);
            /*0x1864e68*/ SocketAddress(System.Net.IPAddress ipAddress);
            /*0x18650bc*/ SocketAddress(System.Net.IPAddress ipaddress, int port);
            /*0x1864c6c*/ System.Net.Sockets.AddressFamily get_Family();
            /*0x1864cb0*/ int get_Size();
            /*0x1864cb8*/ byte get_Item(int offset);
            /*0x1865124*/ System.Net.IPAddress GetIPAddress();
            /*0x186531c*/ System.Net.IPEndPoint GetIPEndPoint();
            /*0x18653cc*/ bool Equals(object comparand);
            /*0x18654bc*/ int GetHashCode();
            /*0x1865608*/ string ToString();
        }

        class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x88*/ System.Net.WebExceptionStatus m_Status;
            /*0x90*/ System.Net.WebResponse m_Response;
            /*0x98*/ System.Net.WebExceptionInternalStatus m_InternalStatus;

            /*0x1704acc*/ WebException();
            /*0x1704adc*/ WebException(string message);
            /*0x1704af0*/ WebException(string message, System.Exception innerException);
            /*0x1702384*/ WebException(string message, System.Net.WebExceptionStatus status);
            /*0x1702398*/ WebException(string message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException);
            /*0x1704b00*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x1704b2c*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x1704b14*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x1704c18*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x1704d0c*/ WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1704d1c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1704d28*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1704d30*/ System.Net.WebExceptionStatus get_Status();
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

            static /*0x1704f08*/ WebExceptionMapping();
            static /*0x1704d38*/ string GetWebStatusString(System.Net.WebExceptionStatus status);
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

            static /*0x1707350*/ WebHeaderCollection();
            static /*0x1705140*/ bool AllowMultiValues(string name);
            static /*0x1705450*/ string CheckBadChars(string name, bool isHeaderValue);
            static /*0x1705808*/ bool ContainsNonAsciiChars(string token);
            static /*0x17066f8*/ string GetAsString(System.Collections.Specialized.NameValueCollection cc, bool winInetCompat, bool forTrace);
            /*0x17069d8*/ WebHeaderCollection();
            /*0x1706a48*/ WebHeaderCollection(System.Net.WebHeaderCollectionType type);
            /*0x1706b40*/ WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1704f74*/ void NormalizeCommonHeaders();
            /*0x1705090*/ System.Collections.Specialized.NameValueCollection get_InnerCollection();
            /*0x17051f8*/ bool get_AllowHttpRequestHeader();
            /*0x1705230*/ void Remove(System.Net.HttpRequestHeader header);
            /*0x1705330*/ void AddInternal(string name, string value);
            /*0x1705390*/ void ChangeInternal(string name, string value);
            /*0x17053f0*/ void RemoveInternal(string name);
            /*0x1705890*/ void ThrowOnRestrictedHeader(string headerName);
            /*0x1705a20*/ void Add(string name, string value);
            /*0x1705bdc*/ void Add(string header);
            /*0x1705ec0*/ void Set(string name, string value);
            /*0x17060fc*/ void SetInternal(string name, string value);
            /*0x170632c*/ void Remove(string name);
            /*0x1706478*/ string[] GetValues(string header);
            /*0x1706690*/ string ToString();
            /*0x1706d14*/ void OnDeserialization(object sender);
            /*0x1706d18*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1706e9c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1706ea8*/ string Get(string name);
            /*0x1707214*/ System.Collections.IEnumerator GetEnumerator();
            /*0x170728c*/ int get_Count();
            /*0x17072c8*/ string Get(int index);
            /*0x170730c*/ string GetKey(int index);

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

            static /*0x1d06ce4*/ CaseInsensitiveAscii();
            /*0x1d06cdc*/ CaseInsensitiveAscii();
            /*0x1d0678c*/ int GetHashCode(object myObject);
            /*0x1d068b8*/ int Compare(object firstObject, object secondObject);
            /*0x1d06a44*/ int FastGetHashCode(string myString);
            /*0x1d06b48*/ bool Equals(object firstObject, object secondObject);
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

            static /*0x170b2d0*/ WebRequest();
            static /*0x1709e30*/ object get_InternalSyncObject();
            static /*0x1709f18*/ System.Net.WebRequest Create(System.Uri requestUri, bool useUriBase);
            static /*0x170a558*/ System.Net.WebRequest Create(string requestUriString);
            static /*0x170a634*/ System.Net.WebRequest Create(System.Uri requestUri);
            static /*0x170a1a8*/ System.Collections.ArrayList get_PrefixList();
            static /*0x170a720*/ System.Collections.ArrayList PopulatePrefixList();
            static /*0x170b078*/ System.Net.IWebProxy get_InternalDefaultWebProxy();
            static /*0x170b278*/ System.Net.IWebProxy get_DefaultWebProxy();
            /*0x170a974*/ WebRequest();
            /*0x170a9a4*/ WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x170a9ac*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x170a9b8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x170a9bc*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x170a9c0*/ void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy);
            /*0x170aa7c*/ string get_Method();
            /*0x170aaac*/ void set_Method(string value);
            /*0x170aadc*/ System.Uri get_RequestUri();
            /*0x170ab0c*/ System.Net.WebHeaderCollection get_Headers();
            /*0x170ab3c*/ long get_ContentLength();
            /*0x170ab6c*/ System.Net.ICredentials get_Credentials();
            /*0x170ab9c*/ void set_Credentials(System.Net.ICredentials value);
            /*0x170abcc*/ bool get_UseDefaultCredentials();
            /*0x170abfc*/ System.Net.IWebProxy get_Proxy();
            /*0x170ac2c*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x170ac5c*/ int get_Timeout();
            /*0x170ac8c*/ System.Net.WebResponse GetResponse();
            /*0x170acbc*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x170acec*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x170ad1c*/ System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync();
            /*0x170afdc*/ System.Security.Principal.WindowsIdentity SafeCaptureIdenity();
            /*0x170b038*/ void Abort();
            /*0x170b068*/ System.Net.Cache.RequestCacheProtocol get_CacheProtocol();
            /*0x170b070*/ void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value);
            /*0x170b38c*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0();

            class DesignerWebRequestCreate : System.Net.IWebRequestCreate
            {
                /*0x231ff48*/ DesignerWebRequestCreate();
                /*0x231fee4*/ System.Net.WebRequest Create(System.Uri uri);
            }

            class WebProxyWrapperOpaque : System.Net.IWebProxy
            {
                /*0x10*/ System.Net.WebProxy webProxy;

                /*0x231ff58*/ System.Uri GetProxy(System.Uri destination);
                /*0x231ff74*/ bool IsBypassed(System.Uri host);
                /*0x231ff90*/ System.Net.ICredentials get_Credentials();
            }

            class WebProxyWrapper : System.Net.WebRequest.WebProxyWrapperOpaque
            {
                /*0x231ff50*/ System.Net.WebProxy get_WebProxy();
            }

            class <>c__DisplayClass79_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x231fb98*/ <>c__DisplayClass79_0();
                /*0x231fba0*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1();
            }
        }

        class WebResponse : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x170c594*/ WebResponse();
            /*0x170c59c*/ WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x170c5a4*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x170c5b0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x170c5b4*/ void Close();
            /*0x170c5b8*/ void Dispose();
            /*0x170c630*/ void Dispose(bool disposing);
            /*0x170c6cc*/ System.IO.Stream GetResponseStream();
            /*0x170c6fc*/ System.Uri get_ResponseUri();
            /*0x170c72c*/ System.Net.WebHeaderCollection get_Headers();
        }

        class BufferOffsetSize
        {
            /*0x10*/ byte[] Buffer;
            /*0x18*/ int Offset;
            /*0x1c*/ int Size;

            /*0x1d00bc0*/ BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer);
            /*0x1d00c70*/ BufferOffsetSize(byte[] buffer, bool copyBuffer);
        }

        class HeaderParser : System.MulticastDelegate
        {
            /*0x17e91a4*/ HeaderParser(object object, nint method);
            /*0x17e92fc*/ string[] Invoke(string value);
            /*0x17e967c*/ System.IAsyncResult BeginInvoke(string value, System.AsyncCallback callback, object object);
            /*0x17e96a0*/ string[] EndInvoke(System.IAsyncResult result);
        }

        class HeaderInfo
        {
            /*0x10*/ bool IsRequestRestricted;
            /*0x11*/ bool IsResponseRestricted;
            /*0x18*/ System.Net.HeaderParser Parser;
            /*0x20*/ string HeaderName;
            /*0x28*/ bool AllowMultiValues;

            /*0x17e75a4*/ HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, System.Net.HeaderParser p);
        }

        class HeaderInfoTable
        {
            static /*0x0*/ System.Collections.Hashtable HeaderHashTable;
            static /*0x8*/ System.Net.HeaderInfo UnknownHeaderInfo;
            static /*0x10*/ System.Net.HeaderParser SingleParser;
            static /*0x18*/ System.Net.HeaderParser MultiParser;

            static /*0x17e78b4*/ HeaderInfoTable();
            static /*0x17e7608*/ string[] ParseSingleValue(string value);
            static /*0x17e76a4*/ string[] ParseMultiValue(string value);
            /*0x17e92f4*/ HeaderInfoTable();
            /*0x17e9204*/ System.Net.HeaderInfo get_Item(string name);
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
            /*0x34*/ bool m_UserEvent;
            /*0x38*/ object m_Event;

            static /*0x1cbd0f8*/ System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext();
            /*0x1cbd180*/ LazyAsyncResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x1cbd21c*/ object get_AsyncObject();
            /*0x1cbd224*/ object get_AsyncState();
            /*0x1cbd22c*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x1cbd2dc*/ bool LazilyCreateEvent(ref System.Threading.ManualResetEvent waitHandle);
            /*0x1cbd4ac*/ bool get_CompletedSynchronously();
            /*0x1cbd4e0*/ bool get_IsCompleted();
            /*0x1cbd49c*/ bool get_InternalPeekCompleted();
            /*0x1cbd514*/ void ProtectedInvokeCallback(object result, nint userToken);
            /*0x1cbd708*/ void InvokeCallback(object result);
            /*0x1cbd75c*/ void Complete(nint userToken);
            /*0x1cbd8e4*/ void WorkerThreadComplete(object state);
            /*0x1cbd994*/ void Cleanup();
            /*0x1cbd998*/ object InternalWaitForCompletion();
            /*0x1cbd9a0*/ object WaitForCompletion(bool snap);

            class ThreadContext
            {
                /*0x10*/ int m_NestedIOCount;

                /*0x1481ad4*/ ThreadContext();
            }
        }

        class NetRes
        {
            static /*0x1cc965c*/ string GetWebStatusString(string Res, System.Net.WebExceptionStatus Status);
            static /*0x1cc9730*/ string GetWebStatusString(System.Net.WebExceptionStatus Status);
        }

        class TimerThread
        {
            static /*0x0*/ System.Collections.Generic.LinkedList<System.WeakReference> s_Queues;
            static /*0x8*/ System.Collections.Generic.LinkedList<System.WeakReference> s_NewQueues;
            static /*0x10*/ int s_ThreadState;
            static /*0x18*/ System.Threading.AutoResetEvent s_ThreadReadyEvent;
            static /*0x20*/ System.Threading.ManualResetEvent s_ThreadShutdownEvent;
            static /*0x28*/ System.Threading.WaitHandle[] s_ThreadEvents;
            static /*0x30*/ System.Collections.Hashtable s_QueuesCache;

            static /*0x1869398*/ TimerThread();
            static /*0x186960c*/ System.Net.TimerThread.Queue CreateQueue(int durationMilliseconds);
            static /*0x1869850*/ void StopTimerThread();
            static /*0x18698d8*/ void OnDomainUnload(object sender, System.EventArgs e);

            class Queue
            {
                /*0x10*/ int m_DurationMilliseconds;

                /*0x148ae98*/ Queue(int durationMilliseconds);
            }

            class Timer : System.IDisposable
            {
                /*0x10*/ int m_StartTimeMilliseconds;
                /*0x14*/ int m_DurationMilliseconds;

                /*0x148aec4*/ Timer(int durationMilliseconds);
                bool Cancel();
                /*0x148aefc*/ void Dispose();
            }

            class Callback : System.MulticastDelegate
            {
                /*0x148a9ac*/ Callback(object object, nint method);
                /*0x148aa0c*/ void Invoke(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
                /*0x148adc4*/ System.IAsyncResult BeginInvoke(System.Net.TimerThread.Timer timer, int timeNoticed, object context, System.AsyncCallback callback, object object);
                /*0x148ae60*/ void EndInvoke(System.IAsyncResult result);
            }

            class TimerQueue : System.Net.TimerThread.Queue
            {
                /*0x18*/ System.Net.TimerThread.TimerNode m_Timers;

                /*0x148b0c0*/ TimerQueue(int durationMilliseconds);
            }

            class InfiniteTimerQueue : System.Net.TimerThread.Queue
            {
                /*0x148ae6c*/ InfiniteTimerQueue();
            }

            class TimerNode : System.Net.TimerThread.Timer
            {
                /*0x18*/ System.Net.TimerThread.TimerNode.TimerState m_TimerState;
                /*0x20*/ System.Net.TimerThread.Callback m_Callback;
                /*0x28*/ object m_Context;
                /*0x30*/ object m_QueueLock;
                /*0x38*/ System.Net.TimerThread.TimerNode next;
                /*0x40*/ System.Net.TimerThread.TimerNode prev;

                /*0x148af08*/ TimerNode();
                /*0x148af44*/ System.Net.TimerThread.TimerNode get_Next();
                /*0x148af4c*/ void set_Next(System.Net.TimerThread.TimerNode value);
                /*0x148af54*/ System.Net.TimerThread.TimerNode get_Prev();
                /*0x148af5c*/ void set_Prev(System.Net.TimerThread.TimerNode value);
                /*0x148af64*/ bool Cancel();

                enum TimerState
                {
                    Ready = 0,
                    Fired = 1,
                    Cancelled = 2,
                    Sentinel = 3,
                }
            }
        }

        class EmptyWebProxy : System.Net.IWebProxy
        {
            /*0x10*/ System.Net.ICredentials m_credentials;

            /*0x17d8c7c*/ EmptyWebProxy();
            /*0x17d8c84*/ System.Uri GetProxy(System.Uri uri);
            /*0x17d8c8c*/ bool IsBypassed(System.Uri uri);
            /*0x17d8c94*/ System.Net.ICredentials get_Credentials();
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

            static /*0x1d0b5a8*/ Cookie();
            static /*0x1d09bf0*/ bool IsDomainEqualToHost(string domain, string host);
            static /*0x1d0a6fc*/ bool DomainCharsTest(string name);
            static /*0x1d0ae90*/ System.Collections.IComparer GetComparer();
            /*0x1d095ac*/ Cookie();
            /*0x1d096c0*/ string get_Comment();
            /*0x1d096c8*/ void set_Comment(string value);
            /*0x1d0972c*/ void set_CommentUri(System.Uri value);
            /*0x1d09734*/ void set_HttpOnly(bool value);
            /*0x1d09740*/ void set_Discard(bool value);
            /*0x1d0974c*/ string get_Domain();
            /*0x1d09754*/ void set_Domain(string value);
            /*0x1d097e4*/ string get__Domain();
            /*0x1d098cc*/ bool get_Expired();
            /*0x1d099a4*/ void set_Expires(System.DateTime value);
            /*0x1d099ac*/ string get_Name();
            /*0x1d099b4*/ bool InternalSetName(string value);
            /*0x1d09ad0*/ string get_Path();
            /*0x1d09ad8*/ void set_Path(string value);
            /*0x1d09b50*/ string get__Path();
            /*0x1d098bc*/ bool get_Plain();
            /*0x1d09c54*/ bool VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow);
            /*0x1d0a864*/ void set_Port(string value);
            /*0x1d0ab70*/ int[] get_PortList();
            /*0x1d0ab78*/ string get__Port();
            /*0x1d0ac4c*/ bool get_Secure();
            /*0x1d0ac54*/ void set_Secure(bool value);
            /*0x1d0ac60*/ string get_Value();
            /*0x1d0ac68*/ void set_Value(string value);
            /*0x1d0acdc*/ System.Net.CookieVariant get_Variant();
            /*0x1d0ace4*/ string get_DomainKey();
            /*0x1d0ad00*/ int get_Version();
            /*0x1d0ad08*/ void set_Version(int value);
            /*0x1d0ad80*/ string get__Version();
            /*0x1d0aef4*/ bool Equals(object comparand);
            /*0x1d0afd0*/ int GetHashCode();
            /*0x1d0b25c*/ string ToString();
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

            static /*0x1d10f00*/ CookieTokenizer();
            /*0x1d107ac*/ CookieTokenizer(string tokenStream);
            /*0x1d108fc*/ bool get_EndOfCookie();
            /*0x1d10904*/ void set_EndOfCookie(bool value);
            /*0x1d108ec*/ bool get_Eof();
            /*0x1d10910*/ string get_Name();
            /*0x1d10918*/ void set_Name(string value);
            /*0x1d10920*/ bool get_Quoted();
            /*0x1d10928*/ void set_Quoted(bool value);
            /*0x1d10934*/ System.Net.CookieToken get_Token();
            /*0x1d1093c*/ void set_Token(System.Net.CookieToken value);
            /*0x1d10944*/ string get_Value();
            /*0x1d1094c*/ void set_Value(string value);
            /*0x1d10954*/ string Extract();
            /*0x1d109e0*/ System.Net.CookieToken FindNext(bool ignoreComma, bool ignoreEquals);
            /*0x1d107e8*/ System.Net.CookieToken Next(bool first, bool parseResponseCookies);
            /*0x1d10c98*/ void Reset();
            /*0x1d10d0c*/ System.Net.CookieToken TokenFromName(bool parseResponseCookies);

            struct RecognizedAttribute
            {
                /*0x10*/ string m_name;
                /*0x18*/ System.Net.CookieToken m_token;

                /*0xaa2180*/ RecognizedAttribute(string name, System.Net.CookieToken token);
                /*0xaa218c*/ System.Net.CookieToken get_Token();
                /*0xaa2194*/ bool IsEqualTo(string value);
            }
        }

        class CookieParser
        {
            /*0x10*/ System.Net.CookieTokenizer m_tokenizer;

            static /*0x1d0a79c*/ string CheckQuoted(string value);
            /*0x1d0ef30*/ CookieParser(string cookieString);
            /*0x1d0efa4*/ System.Net.Cookie Get();
        }

        class Comparer : System.Collections.IComparer
        {
            /*0x1d088a4*/ Comparer();
            /*0x1d087c4*/ int System.Collections.IComparer.Compare(object ol, object or);
        }

        class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ int m_version;
            /*0x18*/ System.Collections.ArrayList m_list;
            /*0x20*/ System.DateTime m_TimeStamp;
            /*0x28*/ bool m_has_other_versions;
            /*0x29*/ bool m_IsReadOnly;

            /*0x1d0b6fc*/ CookieCollection();
            /*0x1d0b7a8*/ System.Net.Cookie get_Item(int index);
            /*0x1d0b89c*/ void Add(System.Net.Cookie cookie);
            /*0x1d0bd0c*/ void Add(System.Net.CookieCollection cookies);
            /*0x1d0c02c*/ int get_Count();
            /*0x1d0c050*/ bool get_IsSynchronized();
            /*0x1d0c058*/ object get_SyncRoot();
            /*0x1d0c05c*/ void CopyTo(System.Array array, int index);
            /*0x1d0c080*/ System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how);
            /*0x1d0c174*/ bool get_IsOtherVersionSeen();
            /*0x1d0c17c*/ int InternalAdd(System.Net.Cookie cookie, bool isStrict);
            /*0x1d0b960*/ int IndexOf(System.Net.Cookie cookie);
            /*0x1d0c608*/ void RemoveAt(int idx);
            /*0x1d0bfcc*/ System.Collections.IEnumerator GetEnumerator();

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

                /*0x1478dbc*/ CookieCollectionEnumerator(System.Net.CookieCollection cookies);
                /*0x1478e10*/ object System.Collections.IEnumerator.get_Current();
                /*0x1478ebc*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x1478f5c*/ void System.Collections.IEnumerator.Reset();
            }
        }

        struct HeaderVariantInfo
        {
            /*0x10*/ string m_name;
            /*0x18*/ System.Net.CookieVariant m_variant;

            /*0xaca828*/ HeaderVariantInfo(string name, System.Net.CookieVariant variant);
            /*0xaca834*/ string get_Name();
            /*0xaca83c*/ System.Net.CookieVariant get_Variant();
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

            static /*0x1d10684*/ CookieContainer();
            /*0x1d0c62c*/ CookieContainer();
            /*0x1d0c720*/ void AddRemoveDomain(string key, System.Net.PathList value);
            /*0x1d0c850*/ void Add(System.Net.Cookie cookie, bool throwOnError);
            /*0x1d0d040*/ bool AgeCookies(string domain);
            /*0x1d0e3dc*/ int ExpireCollection(System.Net.CookieCollection cc);
            /*0x1d0e550*/ bool IsLocalDomain(string host);
            /*0x1d0e844*/ System.Net.CookieCollection CookieCutter(System.Uri uri, string headerName, string setCookieHeader, bool isThrow);
            /*0x1d0f5a4*/ System.Net.CookieCollection InternalGetCookies(System.Uri uri);
            /*0x1d0f8c4*/ void BuildCookieCollectionFromDomainMatches(System.Uri uri, bool isSecure, int port, System.Net.CookieCollection cookies, System.Collections.Generic.List<string> domainAttribute, bool matchOnlyPlainCookie);
            /*0x1d1002c*/ void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, int port, bool isSecure, bool isPlainOnly);
            /*0x1d10248*/ string GetCookieHeader(System.Uri uri);
            /*0x1d10320*/ string GetCookieHeader(System.Uri uri, ref string optCookie2);
        }

        class PathList
        {
            /*0x10*/ System.Collections.SortedList m_list;

            /*0x1eb4e5c*/ PathList();
            /*0x1eb4f28*/ int get_Count();
            /*0x1eb4f4c*/ int GetCookiesCount();
            /*0x1eb5340*/ System.Collections.ICollection get_Values();
            /*0x1eb5364*/ object get_Item(string s);
            /*0x1eb5388*/ void set_Item(string s, object value);
            /*0x1eb5490*/ System.Collections.IEnumerator GetEnumerator();
            /*0x1eb531c*/ object get_SyncRoot();

            class PathListComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.Net.PathList.PathListComparer StaticInstance;

                static /*0x148558c*/ PathListComparer();
                /*0x1485584*/ PathListComparer();
                /*0x1485400*/ int System.Collections.IComparer.Compare(object ol, object or);
            }
        }

        class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
        {
            /*0x1d1078c*/ CookieException();
            /*0x1d0a6f4*/ CookieException(string message);
            /*0x1d0e3d4*/ CookieException(string message, System.Exception inner);
            /*0x1d10794*/ CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1d1079c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1d107a4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
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

            static /*0x17de698*/ FileWebRequest();
            static /*0x17dd958*/ void GetRequestStreamCallback(object state);
            static /*0x17ddc20*/ void GetResponseCallback(object state);
            /*0x17dc6d4*/ FileWebRequest(System.Uri uri);
            /*0x17dc850*/ FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17dcbb0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17dcbbc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17dce68*/ bool get_Aborted();
            /*0x17dce78*/ long get_ContentLength();
            /*0x17dce80*/ System.Net.ICredentials get_Credentials();
            /*0x17dce88*/ void set_Credentials(System.Net.ICredentials value);
            /*0x17dce90*/ System.Net.WebHeaderCollection get_Headers();
            /*0x17dce98*/ string get_Method();
            /*0x17dcea0*/ void set_Method(string value);
            /*0x17dcf80*/ System.Net.IWebProxy get_Proxy();
            /*0x17dcf88*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x17dcf90*/ int get_Timeout();
            /*0x17dcf98*/ System.Uri get_RequestUri();
            /*0x17dcfa0*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x17dd2dc*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x17dd5d8*/ System.Net.WebResponse GetResponse();
            /*0x17de1f8*/ void UnblockReader();
            /*0x17de2c4*/ bool get_UseDefaultCredentials();
            /*0x17de2f0*/ void Abort();
        }

        class FileWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x17de76c*/ FileWebRequestCreator();
            /*0x17de774*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FileWebStream : System.IO.FileStream, System.Net.ICloseEx
        {
            /*0x70*/ System.Net.FileWebRequest m_request;

            /*0x17ddb78*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing);
            /*0x17de7d0*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, int length, bool async);
            /*0x17def8c*/ void Dispose(bool disposing);
            /*0x17df00c*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x17df04c*/ int Read(byte[] buffer, int offset, int size);
            /*0x17df1ac*/ void Write(byte[] buffer, int offset, int size);
            /*0x17df288*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x17df37c*/ int EndRead(System.IAsyncResult ar);
            /*0x17df430*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x17df524*/ void EndWrite(System.IAsyncResult ar);
            /*0x17df128*/ void CheckError();
        }

        class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.Net.ICloseEx
        {
            /*0x18*/ bool m_closed;
            /*0x20*/ long m_contentLength;
            /*0x28*/ System.IO.FileAccess m_fileAccess;
            /*0x30*/ System.Net.WebHeaderCollection m_headers;
            /*0x38*/ System.IO.Stream m_stream;
            /*0x40*/ System.Uri m_uri;

            /*0x17ddf1c*/ FileWebResponse(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, bool asyncHint);
            /*0x17de890*/ FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17deaa0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17deaac*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17dec68*/ System.Net.WebHeaderCollection get_Headers();
            /*0x17ded04*/ System.Uri get_ResponseUri();
            /*0x17dec8c*/ void CheckDisposed();
            /*0x17ded28*/ void Close();
            /*0x17dedcc*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x17def40*/ System.IO.Stream GetResponseStream();
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

            static /*0x1709990*/ System.Net.IWebProxy CreateDefaultProxy();
            static /*0x1709a38*/ bool AreAllBypassed(System.Collections.Generic.IEnumerable<string> proxies, bool checkFirstOnly);
            static /*0x1709d18*/ System.Uri ProxyUri(string proxyName);
            /*0x1708688*/ WebProxy();
            /*0x170869c*/ WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials);
            /*0x1709528*/ WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1709a00*/ WebProxy(bool enableAutoproxy);
            /*0x17089a4*/ System.Net.ICredentials get_Credentials();
            /*0x17089ac*/ bool get_UseDefaultCredentials();
            /*0x1708a2c*/ void set_UseDefaultCredentials(bool value);
            /*0x1708ab0*/ System.Uri GetProxy(System.Uri destination);
            /*0x1708750*/ void UpdateRegExList(bool canThrow);
            /*0x1708edc*/ bool IsMatchInBypassList(System.Uri input);
            /*0x1709094*/ bool IsLocal(System.Uri host);
            /*0x170920c*/ bool IsLocalInProxyHash(System.Uri host);
            /*0x1709310*/ bool IsBypassed(System.Uri host);
            /*0x1708dfc*/ bool IsBypassedManual(System.Uri host);
            /*0x1709854*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1709860*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1709988*/ System.Net.AutoWebProxyScriptEngine get_ScriptEngine();
            /*0x1709848*/ void UnsafeUpdateFromRegistry();
            /*0x1708c58*/ bool GetProxyAuto(System.Uri destination, ref System.Uri proxyUri);
            /*0x170940c*/ bool IsBypassedAuto(System.Uri destination, ref bool isBypassed);
        }

        class AutoWebProxyScriptEngine
        {
            /*0x1cfec50*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList);
            /*0x1cfec5c*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList, ref int syncStatus);
        }

        class UnsafeNclNativeMethods
        {
            class HttpApi
            {
                static /*0x0*/ string[] m_Strings;

                static /*0x148dfac*/ HttpApi();

                class HTTP_REQUEST_HEADER_ID
                {
                    static /*0x0*/ string[] m_Strings;

                    static /*0x232efa0*/ HTTP_REQUEST_HEADER_ID();
                    static /*0x232ef10*/ string ToString(int position);
                }
            }

            class SecureStringHelper
            {
                static /*0x148e7c4*/ string CreateString(System.Security.SecureString secureString);
                static /*0x148e940*/ System.Security.SecureString CreateSecureString(string plainString);
            }
        }

        class Logging
        {
            static /*0x0*/ bool On;
        }

        class ServerCertValidationCallback
        {
            /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;
            /*0x18*/ System.Threading.ExecutionContext m_Context;

            /*0x185acd8*/ ServerCertValidationCallback(System.Net.Security.RemoteCertificateValidationCallback validationCallback);
            /*0x185ad5c*/ void Callback(object state);
            /*0x185ae08*/ bool Invoke(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);

            class CallbackContext
            {
                /*0x10*/ object request;
                /*0x18*/ System.Security.Cryptography.X509Certificates.X509Certificate certificate;
                /*0x20*/ System.Security.Cryptography.X509Certificates.X509Chain chain;
                /*0x28*/ System.Net.Security.SslPolicyErrors sslPolicyErrors;
                /*0x2c*/ bool result;

                /*0x1486930*/ CallbackContext(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            }
        }

        class AuthenticationManager
        {
            static /*0x0*/ System.Collections.ArrayList modules;
            static /*0x8*/ object locker;
            static /*0x10*/ System.Net.ICredentialPolicy credential_policy;

            static /*0x1cfeaa8*/ AuthenticationManager();
            static /*0x1cfdda8*/ void EnsureModules();
            static /*0x1cfe040*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x1cfe14c*/ System.Net.Authorization DoAuthenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x1cfe5d4*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
        }

        class BasicClient : System.Net.IAuthenticationModule
        {
            static /*0x1cffa90*/ byte[] GetBytes(string str);
            static /*0x1cff6c8*/ System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1cfe038*/ BasicClient();
            /*0x1cff618*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1cffb44*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1cffb50*/ string get_AuthenticationType();
        }

        class BindIPEndPoint : System.MulticastDelegate
        {
            /*0x1cffb94*/ BindIPEndPoint(object object, nint method);
            /*0x1cffbf4*/ System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
            /*0x1cfffb4*/ System.IAsyncResult BeginInvoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount, System.AsyncCallback callback, object object);
            /*0x1d00050*/ System.Net.IPEndPoint EndInvoke(System.IAsyncResult result);
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

            static /*0x17d6308*/ DigestHeaderParser();
            /*0x17d5c7c*/ DigestHeaderParser(string header);
            /*0x17d5d3c*/ string get_Realm();
            /*0x17d5d70*/ string get_Opaque();
            /*0x17d5da8*/ string get_Nonce();
            /*0x17d5de0*/ string get_Algorithm();
            /*0x17d5e18*/ string get_QOP();
            /*0x17d5e50*/ bool Parse();
            /*0x17d61e8*/ void SkipWhitespace();
            /*0x17d6274*/ string GetKey();
            /*0x17d604c*/ bool GetKeywordAndValue(ref string key, ref string value);
        }

        class DigestSession
        {
            static /*0x0*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ System.DateTime lastUse;
            /*0x18*/ int _nc;
            /*0x20*/ System.Security.Cryptography.HashAlgorithm hash;
            /*0x28*/ System.Net.DigestHeaderParser parser;
            /*0x30*/ string _cnonce;

            static /*0x17d64d4*/ DigestSession();
            /*0x17d52cc*/ DigestSession();
            /*0x17d6528*/ string get_Algorithm();
            /*0x17d6540*/ string get_Realm();
            /*0x17d542c*/ string get_Nonce();
            /*0x17d6558*/ string get_Opaque();
            /*0x17d6570*/ string get_QOP();
            /*0x17d6588*/ string get_CNonce();
            /*0x17d5348*/ bool Parse(string challenge);
            /*0x17d6698*/ string HashToHexString(string toBeHashed);
            /*0x17d67f8*/ string HA1(string username, string password);
            /*0x17d6920*/ string HA2(System.Net.HttpWebRequest webRequest);
            /*0x17d69fc*/ string Response(string username, string password, System.Net.HttpWebRequest webRequest);
            /*0x17d5444*/ System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x17d6b60*/ System.DateTime get_LastUse();
        }

        class DigestClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Collections.Hashtable cache;

            static /*0x17d5bfc*/ DigestClient();
            static /*0x17d4674*/ System.Collections.Hashtable get_Cache();
            static /*0x17d47fc*/ void CheckExpired(int count);
            /*0x17d5bf4*/ DigestClient();
            /*0x17d5010*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x17d5a10*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x17d5bb0*/ string get_AuthenticationType();
        }

        class Dns
        {
            static /*0x17d6ddc*/ bool GetHostByName_internal(string host, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x17d6de0*/ bool GetHostByAddr_internal(string addr, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x17d6de4*/ bool GetHostName_internal(ref string h_name);
            static /*0x17d6de8*/ void Error_11001(string hostName);
            static /*0x17d6e50*/ System.Net.IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist);
            static /*0x17d71a8*/ System.Net.IPHostEntry GetHostByAddressFromString(string address, bool parse);
            static /*0x17d72e8*/ System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress);
            static /*0x17d7468*/ System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address);
            static /*0x17d74dc*/ System.Net.IPHostEntry GetHostByName(string hostName);
            static /*0x17d75d0*/ string GetHostName();
        }

        class FtpAsyncResult : System.IAsyncResult
        {
            /*0x10*/ System.Net.FtpWebResponse response;
            /*0x18*/ System.Threading.ManualResetEvent waitHandle;
            /*0x20*/ System.Exception exception;
            /*0x28*/ System.AsyncCallback callback;
            /*0x30*/ System.IO.Stream stream;
            /*0x38*/ object state;
            /*0x40*/ bool completed;
            /*0x41*/ bool synch;
            /*0x48*/ object locker;

            /*0x17df5d8*/ FtpAsyncResult(System.AsyncCallback callback, object state);
            /*0x17df658*/ object get_AsyncState();
            /*0x17df660*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x17df770*/ bool get_CompletedSynchronously();
            /*0x17df778*/ bool get_IsCompleted();
            /*0x17df848*/ bool get_GotException();
            /*0x17df858*/ System.Exception get_Exception();
            /*0x17df860*/ System.Net.FtpWebResponse get_Response();
            /*0x17df868*/ void set_Stream(System.IO.Stream value);
            /*0x17df870*/ bool WaitUntilComplete(int timeout, bool exitContext);
            /*0x17df8d8*/ void SetCompleted(bool synch, System.Exception exc, System.Net.FtpWebResponse response);
            /*0x17dfa68*/ void SetCompleted(bool synch, System.Net.FtpWebResponse response);
            /*0x17dfa78*/ void SetCompleted(bool synch, System.Exception exc);
            /*0x17df9c8*/ void DoCallback();
        }

        class FtpDataStream : System.IO.Stream, System.IDisposable
        {
            /*0x28*/ System.Net.FtpWebRequest request;
            /*0x30*/ System.IO.Stream networkStream;
            /*0x38*/ bool disposed;
            /*0x39*/ bool isRead;
            /*0x3c*/ int totalRead;

            /*0x17dfa84*/ FtpDataStream(System.Net.FtpWebRequest request, System.IO.Stream stream, bool isRead);
            /*0x17dfb60*/ bool get_CanRead();
            /*0x17dfb68*/ bool get_CanWrite();
            /*0x17dfb78*/ bool get_CanSeek();
            /*0x17dfb80*/ long get_Length();
            /*0x17dfbc0*/ long get_Position();
            /*0x17dfc00*/ void set_Position(long value);
            /*0x17dfc40*/ void Close();
            /*0x17dfc54*/ void Flush();
            /*0x17dfc58*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x17dfc98*/ int ReadInternal(byte[] buffer, int offset, int size);
            /*0x17dff20*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x17e0148*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x17e028c*/ int Read(byte[] buffer, int offset, int size);
            /*0x17e0478*/ void WriteInternal(byte[] buffer, int offset, int size);
            /*0x17e0580*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x17e0730*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x17e0874*/ void Write(byte[] buffer, int offset, int size);
            /*0x17e0a60*/ void Finalize();
            /*0x17e0ad8*/ void System.IDisposable.Dispose();
            /*0x17e0b54*/ void Dispose(bool disposing);
            /*0x17e00d0*/ void CheckDisposed();

            class WriteDelegate : System.MulticastDelegate
            {
                /*0x147f548*/ WriteDelegate(object object, nint method);
                /*0x147f5a8*/ void Invoke(byte[] buffer, int offset, int size);
                /*0x147f960*/ System.IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, System.AsyncCallback callback, object object);
                /*0x147fa10*/ void EndInvoke(System.IAsyncResult result);
            }

            class ReadDelegate : System.MulticastDelegate
            {
                /*0x147f04c*/ ReadDelegate(object object, nint method);
                /*0x147f0ac*/ int Invoke(byte[] buffer, int offset, int size);
                /*0x147f46c*/ System.IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, System.AsyncCallback callback, object object);
                /*0x147f51c*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class FtpRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x17e0d0c*/ FtpRequestCreator();
            /*0x17e0bc4*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FtpStatus
        {
            /*0x10*/ System.Net.FtpStatusCode statusCode;
            /*0x18*/ string statusDescription;

            /*0x17e0d14*/ FtpStatus(System.Net.FtpStatusCode statusCode, string statusDescription);
            /*0x17e0d50*/ System.Net.FtpStatusCode get_StatusCode();
            /*0x17e0d58*/ string get_StatusDescription();
        }

        class FtpWebRequest : System.Net.WebRequest
        {
            static /*0x0*/ string[] supportedCommands;
            /*0x38*/ System.Uri requestUri;
            /*0x40*/ string file_name;
            /*0x48*/ System.Net.ServicePoint servicePoint;
            /*0x50*/ System.IO.Stream origDataStream;
            /*0x58*/ System.IO.Stream dataStream;
            /*0x60*/ System.IO.Stream controlStream;
            /*0x68*/ System.IO.StreamReader controlReader;
            /*0x70*/ System.Net.NetworkCredential credentials;
            /*0x78*/ System.Net.IPHostEntry hostEntry;
            /*0x80*/ System.Net.IPEndPoint localEndPoint;
            /*0x88*/ System.Net.IPEndPoint remoteEndPoint;
            /*0x90*/ System.Net.IWebProxy proxy;
            /*0x98*/ int timeout;
            /*0x9c*/ int rwTimeout;
            /*0xa0*/ long offset;
            /*0xa8*/ bool binary;
            /*0xa9*/ bool enableSsl;
            /*0xaa*/ bool usePassive;
            /*0xab*/ bool keepAlive;
            /*0xb0*/ string method;
            /*0xb8*/ string renameTo;
            /*0xc0*/ object locker;
            /*0xc8*/ System.Net.FtpWebRequest.RequestState requestState;
            /*0xd0*/ System.Net.FtpAsyncResult asyncResult;
            /*0xd8*/ System.Net.FtpWebResponse ftpResponse;
            /*0xe0*/ System.IO.Stream requestStream;
            /*0xe8*/ string initial_path;
            /*0xf0*/ System.Text.Encoding dataEncoding;

            static /*0x17e5a30*/ FtpWebRequest();
            static /*0x17e0e20*/ System.Exception GetMustImplement();
            static /*0x17e47c8*/ string GetInitialPath(System.Net.FtpStatus status);
            static /*0x17e59a4*/ System.Net.FtpStatus ServiceNotAvailable();
            /*0x17e0c20*/ FtpWebRequest(System.Uri uri);
            /*0x17e0e78*/ long get_ContentLength();
            /*0x17e0e80*/ System.Net.ICredentials get_Credentials();
            /*0x17e0e88*/ void set_Credentials(System.Net.ICredentials value);
            /*0x17e0fd0*/ bool get_EnableSsl();
            /*0x17e0fd8*/ System.Net.WebHeaderCollection get_Headers();
            /*0x17e103c*/ string get_Method();
            /*0x17e1044*/ void set_Method(string value);
            /*0x17e1184*/ System.Net.IWebProxy get_Proxy();
            /*0x17e118c*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x17e11b4*/ int get_ReadWriteTimeout();
            /*0x17e11bc*/ System.Uri get_RequestUri();
            /*0x17e11c4*/ System.Net.ServicePoint get_ServicePoint();
            /*0x17e1250*/ bool get_UseDefaultCredentials();
            /*0x17e12b4*/ int get_Timeout();
            /*0x17e12bc*/ string get_DataType();
            /*0x17e1324*/ System.Net.FtpWebRequest.RequestState get_State();
            /*0x17e13ec*/ void set_State(System.Net.FtpWebRequest.RequestState value);
            /*0x17e1528*/ void Abort();
            /*0x17e1a8c*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x17e1cfc*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x17e1e90*/ System.Net.WebResponse GetResponse();
            /*0x17e11c8*/ System.Net.ServicePoint GetServicePoint();
            /*0x17e1ed8*/ void ResolveHost();
            /*0x17e1ff4*/ void ProcessRequest();
            /*0x17e2af4*/ void SetType();
            /*0x17e2d0c*/ string GetRemoteFolderPath(System.Uri uri);
            /*0x17e2f0c*/ void CWDAndSetFileName(System.Uri uri);
            /*0x17e22a8*/ void ProcessMethod();
            /*0x17e3d88*/ void CloseControlConnection();
            /*0x17dfe78*/ void CloseDataConnection();
            /*0x17e3ea4*/ void CloseConnection();
            /*0x17e375c*/ void ProcessSimpleMethod();
            /*0x17e36bc*/ void UploadData();
            /*0x17e3620*/ void DownloadData();
            /*0x17e0f68*/ void CheckRequestStarted();
            /*0x17e30ac*/ void OpenControlConnection();
            /*0x17e4950*/ System.Net.Sockets.Socket SetupPassiveConnection(string statusDescription, bool ipv6);
            /*0x17e4b34*/ int GetPortV4(string responseString);
            /*0x17e4d9c*/ int GetPortV6(string responseString);
            /*0x17e4f8c*/ string FormatAddress(System.Net.IPAddress address, int Port);
            /*0x17e50cc*/ string FormatAddressV6(System.Net.IPAddress address, int port);
            /*0x17e2c1c*/ System.Exception CreateExceptionFromResponse(System.Net.FtpStatus status);
            /*0x17dfeb0*/ void SetTransferCompleted();
            /*0x17e5200*/ void OperationCompleted();
            /*0x17e27f8*/ void SetCompleteWithError(System.Exception exc);
            /*0x17e5210*/ System.Net.Sockets.Socket InitDataConnection();
            /*0x17e3ee0*/ void OpenDataConnection();
            /*0x17e4340*/ void Authenticate();
            /*0x17e2c0c*/ System.Net.FtpStatus SendCommand(string command, string[] parameters);
            /*0x17e1754*/ System.Net.FtpStatus SendCommand(bool waitResponse, string command, string[] parameters);
            /*0x17e2850*/ System.Net.FtpStatus GetResponseStatus();
            /*0x17e5884*/ void InitiateSecureConnection(ref System.IO.Stream stream);
            /*0x17e5690*/ bool ChangeToSSLSocket(ref System.IO.Stream stream);
            /*0x17e1944*/ bool InFinalState();
            /*0x17e2814*/ bool InProgress();
            /*0x17dfe08*/ void CheckIfAborted();
            /*0x17e14c0*/ void CheckFinalState();

            enum RequestState
            {
                Before = 0,
                Scheduled = 1,
                Connecting = 2,
                Authenticating = 3,
                OpeningData = 4,
                TransferInProgress = 5,
                Finished = 6,
                Aborted = 7,
                Error = 8,
            }
        }

        class FtpWebResponse : System.Net.WebResponse
        {
            /*0x18*/ System.IO.Stream stream;
            /*0x20*/ System.Uri uri;
            /*0x28*/ System.Net.FtpStatusCode statusCode;
            /*0x30*/ System.DateTime lastModified;
            /*0x38*/ string bannerMessage;
            /*0x40*/ string welcomeMessage;
            /*0x48*/ string exitMessage;
            /*0x50*/ string statusDescription;
            /*0x58*/ string method;
            /*0x60*/ bool disposed;
            /*0x68*/ System.Net.FtpWebRequest request;
            /*0x70*/ long contentLength;

            /*0x17e21c4*/ FtpWebResponse(System.Net.FtpWebRequest request, System.Uri uri, string method, bool keepAlive);
            /*0x17e1994*/ FtpWebResponse(System.Net.FtpWebRequest request, System.Uri uri, string method, System.Net.FtpStatusCode statusCode, string statusDescription);
            /*0x17e51e0*/ FtpWebResponse(System.Net.FtpWebRequest request, System.Uri uri, string method, System.Net.FtpStatus status);
            /*0x17e5dfc*/ System.Net.WebHeaderCollection get_Headers();
            /*0x17e5e54*/ System.Uri get_ResponseUri();
            /*0x17e5e5c*/ void set_LastModified(System.DateTime value);
            /*0x17e5e64*/ void set_BannerMessage(string value);
            /*0x17e5e6c*/ void set_WelcomeMessage(string value);
            /*0x17e5e74*/ void set_StatusCode(System.Net.FtpStatusCode value);
            /*0x17e5e7c*/ void Close();
            /*0x17e5f3c*/ System.IO.Stream GetResponseStream();
            /*0x17e6084*/ void set_Stream(System.IO.Stream value);
            /*0x17e1fd0*/ void UpdateStatus(System.Net.FtpStatus status);
            /*0x17e600c*/ void CheckDisposed();
            /*0x17e2ae4*/ bool IsFinal();
        }

        class HttpRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x17e9a08*/ HttpRequestCreator();
            /*0x17e9a10*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ int defaultMaxResponseHeadersLength;
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
            /*0x140*/ Mono.Security.Interface.MonoTlsProvider tlsProvider;
            /*0x148*/ Mono.Security.Interface.MonoTlsSettings tlsSettings;
            /*0x150*/ System.Net.ServerCertValidationCallback certValidationCallback;
            /*0x158*/ System.Net.HttpWebRequest.AuthorizationState auth_state;
            /*0x168*/ System.Net.HttpWebRequest.AuthorizationState proxy_auth_state;
            /*0x178*/ string host;
            /*0x180*/ System.Func<System.IO.Stream, System.Threading.Tasks.Task> ResendContentFactory;
            /*0x188*/ bool <ThrowOnError>k__BackingField;
            /*0x189*/ bool unsafe_auth_blah;

            static /*0x17ea208*/ HttpWebRequest();
            static System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func, int timeout, System.Action abort);
            static /*0x17eb5c8*/ System.Exception FlattenException(System.Exception e);
            static /*0x17eb8a8*/ System.Net.WebException CreateRequestAbortedException();
            /*0x17e9a6c*/ HttpWebRequest(System.Uri uri);
            /*0x17ea2c4*/ HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17edfa0*/ HttpWebRequest();
            /*0x17ea258*/ void ResetAuthorization();
            /*0x17ea9b0*/ System.Uri get_Address();
            /*0x17ea9b8*/ void set_Address(System.Uri value);
            /*0x17ea9c0*/ bool get_AllowWriteStreamBuffering();
            /*0x17ea9c8*/ System.Net.DecompressionMethods get_AutomaticDecompression();
            /*0x17ea9d0*/ bool get_InternalAllowBuffering();
            /*0x17ea9e4*/ bool get_MethodWithBuffer();
            /*0x17eaae4*/ Mono.Security.Interface.MonoTlsProvider get_TlsProvider();
            /*0x17eaaec*/ Mono.Security.Interface.MonoTlsSettings get_TlsSettings();
            /*0x17eaaf4*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x17eab5c*/ long get_ContentLength();
            /*0x17eab64*/ void set_InternalContentLength(long value);
            /*0x17eab6c*/ bool get_ThrowOnError();
            /*0x17eab74*/ void set_ThrowOnError(bool value);
            /*0x17eab80*/ System.Net.ICredentials get_Credentials();
            /*0x17eab88*/ void set_Credentials(System.Net.ICredentials value);
            /*0x17eab90*/ System.Net.WebHeaderCollection get_Headers();
            /*0x17eab98*/ string get_Host();
            /*0x17eabc4*/ bool get_KeepAlive();
            /*0x17eabcc*/ int get_ReadWriteTimeout();
            /*0x17eabd4*/ string get_Method();
            /*0x17eabdc*/ void set_Method(string value);
            /*0x17eade4*/ System.Version get_ProtocolVersion();
            /*0x17eadec*/ System.Net.IWebProxy get_Proxy();
            /*0x17eadf4*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x17eafc0*/ System.Uri get_RequestUri();
            /*0x17eafc8*/ bool get_SendChunked();
            /*0x17eafd0*/ System.Net.ServicePoint get_ServicePoint();
            /*0x17eafd4*/ System.Net.ServicePoint get_ServicePointNoLock();
            /*0x17eafdc*/ int get_Timeout();
            /*0x17eafe4*/ string get_TransferEncoding();
            /*0x17eb03c*/ bool get_UseDefaultCredentials();
            /*0x17eb0c0*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x17eb0c8*/ bool get_ExpectContinue();
            /*0x17eb0d0*/ void set_ExpectContinue(bool value);
            /*0x17eb0dc*/ System.Uri get_AuthUri();
            /*0x17eb0e4*/ bool get_ProxyQuery();
            /*0x17eb118*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            /*0x17eae84*/ System.Net.ServicePoint GetServicePoint();
            /*0x17eb120*/ System.Net.WebOperation SendRequest(bool redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func);
            /*0x17eb348*/ System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken);
            /*0x17eb484*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken);
            /*0x17eb68c*/ System.Net.WebException GetWebException(System.Exception e);
            /*0x17eb968*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x17ebaa4*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x17ebbf8*/ System.Net.WebResponse GetResponse();
            /*0x17ebd30*/ void set_FinishedReading(bool value);
            /*0x17eb87c*/ bool get_Aborted();
            /*0x17ebd3c*/ void Abort();
            /*0x17ebe28*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17ebe34*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17eae24*/ void CheckRequestStarted();
            /*0x17ec2a8*/ void DoContinueDelegate(int statusCode, System.Net.WebHeaderCollection headers);
            /*0x17ec2b8*/ void RewriteRedirectToGet();
            /*0x17ec334*/ bool Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response);
            /*0x17ec80c*/ string GetHeaders();
            /*0x17ecf10*/ void DoPreAuthenticate();
            /*0x17ed134*/ byte[] GetRequestHeaders();
            /*0x17ed4b8*/ System.ValueTuple<System.Net.WebOperation, bool> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x17ed760*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
            /*0x17ed780*/ System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, bool redirect);
            /*0x17ed9b0*/ System.ValueTuple<bool, bool, System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response);
            /*0x17ede80*/ System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__263_0();

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

                /*0xaa22f0*/ AuthorizationState(System.Net.HttpWebRequest request, bool isProxy);
                /*0xaa22c0*/ bool get_IsCompleted();
                /*0xaa22c8*/ System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState();
                /*0xaa22d0*/ bool get_IsNtlmAuthenticated();
                /*0xaa2308*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
                /*0xaa2310*/ void Reset();
                /*0xaa2318*/ string ToString();
            }

            class <>c__234<T>
            {
                static /*0x0*/ System.Net.HttpWebRequest.<>c__234<T> <>9;
                static /*0x0*/ System.Func<System.Threading.Tasks.Task<T>, System.Nullable<int>> <>9__234_0;

                static <>c__234();
                <>c__234();
                System.Nullable<int> <RunWithTimeout>b__234_0(System.Threading.Tasks.Task<T> t);
            }

            struct <RunWithTimeout>d__234<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ int timeout;
                /*0x0*/ System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func;
                /*0x0*/ System.Threading.Tasks.Task <timeoutTask>5__1;
                /*0x0*/ System.Threading.CancellationTokenSource <cts>5__2;
                /*0x0*/ System.Action abort;
                /*0x0*/ System.Threading.Tasks.Task<T> <workerTask>5__3;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <MyGetResponseAsync>d__236 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.HttpWebResponse> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.WebOperation <operation>5__1;
                /*0x48*/ System.Net.WebException <throwMe>5__2;
                /*0x50*/ System.Net.WebCompletionSource <completion>5__3;
                /*0x58*/ bool <redirect>5__4;
                /*0x60*/ System.Net.HttpWebResponse <response>5__5;
                /*0x68*/ System.Net.WebOperation <ntlm>5__6;
                /*0x70*/ bool <mustReadAll>5__7;
                /*0x78*/ System.Net.WebResponseStream <stream>5__8;
                /*0x80*/ System.Net.BufferOffsetSize <writeBuffer>5__9;
                /*0x88*/ System.Runtime.CompilerServices.TaskAwaiter<System.Net.WebRequestStream> <>u__1;
                /*0x90*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0xa0*/ System.Runtime.CompilerServices.TaskAwaiter<System.Net.WebResponseStream> <>u__3;
                /*0xa8*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> <>u__4;

                /*0xaa2274*/ void MoveNext();
                /*0xaa227c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <GetResponseFromData>d__237 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.Net.WebResponseStream stream;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Net.WebException <throwMe>5__1;
                /*0x50*/ System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <rewriteHandler>5__2;
                /*0x58*/ bool <redirect>5__3;
                /*0x60*/ System.Net.HttpWebResponse <response>5__4;
                /*0x68*/ System.Net.BufferOffsetSize <writeBuffer>5__5;
                /*0x70*/ bool <mustReadAll>5__6;
                /*0x78*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x88*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.BufferOffsetSize> <>u__2;

                /*0xaa2264*/ void MoveNext();
                /*0xaa226c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<GetRewriteHandler>b__263_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.BufferOffsetSize> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.IO.MemoryStream <ms>5__1;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xaa2254*/ void MoveNext();
                /*0xaa225c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x18*/ System.Uri uri;
            /*0x20*/ System.Net.WebHeaderCollection webHeaders;
            /*0x28*/ System.Net.CookieCollection cookieCollection;
            /*0x30*/ string method;
            /*0x38*/ System.Version version;
            /*0x40*/ System.Net.HttpStatusCode statusCode;
            /*0x48*/ string statusDescription;
            /*0x50*/ long contentLength;
            /*0x58*/ string contentType;
            /*0x60*/ System.Net.CookieContainer cookie_container;
            /*0x68*/ bool disposed;
            /*0x70*/ System.IO.Stream stream;

            /*0x1cb4978*/ HttpWebResponse(System.Uri uri, string method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers);
            /*0x1cb4a38*/ HttpWebResponse(System.Uri uri, string method, System.Net.WebResponseStream stream, System.Net.CookieContainer container);
            /*0x1cb4f5c*/ HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1cb5620*/ HttpWebResponse();
            /*0x1cb5298*/ System.Net.WebHeaderCollection get_Headers();
            /*0x1cb52a0*/ System.Uri get_ResponseUri();
            /*0x1cb533c*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x1cb5344*/ string get_StatusDescription();
            /*0x1cb5368*/ System.IO.Stream GetResponseStream();
            /*0x1cb5410*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1cb541c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x1cb55c8*/ void Close();
            /*0x1cb55fc*/ void System.IDisposable.Dispose();
            /*0x1cb560c*/ void Dispose(bool disposing);
            /*0x1cb52c4*/ void CheckDisposed();
            /*0x1cb4d3c*/ void FillCookies();
        }

        interface ICredentialPolicy
        {
        }

        struct IPv6AddressFormatter
        {
            /*0x10*/ ushort[] address;
            /*0x18*/ long scopeId;

            static /*0x1cba0bc*/ ushort SwapUShort(ushort number);
            /*0xada190*/ IPv6AddressFormatter(ushort[] addr, long scopeId);
            /*0xada198*/ uint AsIPv4Int();
            /*0xada1a0*/ bool IsIPv4Compatible();
            /*0xada1a8*/ bool IsIPv4Mapped();
            /*0xada1b0*/ string ToString();
        }

        class MonoChunkStream
        {
            /*0x10*/ System.Net.WebHeaderCollection headers;
            /*0x18*/ int chunkSize;
            /*0x1c*/ int chunkRead;
            /*0x20*/ int totalWritten;
            /*0x24*/ System.Net.MonoChunkStream.State state;
            /*0x28*/ System.Text.StringBuilder saved;
            /*0x30*/ bool sawCR;
            /*0x31*/ bool gotit;
            /*0x34*/ int trailerState;
            /*0x38*/ System.Collections.ArrayList chunks;

            static /*0x1cc5588*/ string RemoveChunkExtension(string input);
            static /*0x1cc5534*/ void ThrowProtocolViolation(string message);
            /*0x1cc4584*/ MonoChunkStream(byte[] buffer, int offset, int size, System.Net.WebHeaderCollection headers);
            /*0x1cc45e4*/ MonoChunkStream(System.Net.WebHeaderCollection headers);
            /*0x1cc46c0*/ void ResetBuffer();
            /*0x1cc46f4*/ void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read);
            /*0x1cc4774*/ int Read(byte[] buffer, int offset, int size);
            /*0x1cc4778*/ int ReadFromChunks(byte[] buffer, int offset, int size);
            /*0x1cc4694*/ void Write(byte[] buffer, int offset, int size);
            /*0x1cc4a30*/ void InternalWrite(byte[] buffer, ref int offset, int size);
            /*0x1cc53fc*/ bool get_WantMore();
            /*0x1cc5424*/ bool get_DataAvailable();
            /*0x1cc5528*/ int get_ChunkLeft();
            /*0x1cc4e7c*/ System.Net.MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size);
            /*0x1cc4b70*/ System.Net.MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size);
            /*0x1cc4fb4*/ System.Net.MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size);
            /*0x1cc50cc*/ System.Net.MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size);

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

                /*0x1483a90*/ Chunk(byte[] chunk);
                /*0x1483abc*/ int Read(byte[] buffer, int offset, int size);
            }
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            /*0x10*/ System.Net.IAuthenticationModule authObject;

            /*0x1eb2a08*/ NtlmClient();
            /*0x1eb2a70*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1eb2b58*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x1eb2b60*/ string get_AuthenticationType();
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
            /*0x60*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
            /*0x68*/ object m_ServerCertificateOrBytes;
            /*0x70*/ object m_ClientCertificateOrBytes;

            static /*0x185ba00*/ void PutBytes(byte[] bytes, uint v, int offset);
            /*0x185b48c*/ ServicePoint(System.Uri uri, int connectionLimit, int maxIdleTime);
            /*0x185b728*/ System.Net.ServicePointScheduler get_Scheduler();
            /*0x185b730*/ System.Uri get_Address();
            /*0x185b738*/ int get_ConnectionLimit();
            /*0x185b754*/ System.Version get_ProtocolVersion();
            /*0x185b75c*/ void set_Expect100Continue(bool value);
            /*0x185b768*/ bool get_UseNagleAlgorithm();
            /*0x185b770*/ void set_UseNagleAlgorithm(bool value);
            /*0x185b77c*/ bool get_SendContinue();
            /*0x185b880*/ void set_SendContinue(bool value);
            /*0x185b88c*/ void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval);
            /*0x185b940*/ void KeepAliveSetup(System.Net.Sockets.Socket socket);
            /*0x185bb5c*/ bool get_UsesProxy();
            /*0x185bb64*/ void set_UsesProxy(bool value);
            /*0x185bb70*/ bool get_UseConnect();
            /*0x185bb78*/ void set_UseConnect(bool value);
            /*0x185bb84*/ bool get_HasTimedOut();
            /*0x185bce0*/ System.Net.IPHostEntry get_HostEntry();
            /*0x185c09c*/ void SetVersion(System.Version version);
            /*0x185c0a4*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x185c270*/ void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x185c2b0*/ void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x185c2f0*/ bool CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote);
        }

        class ServicePointManager
        {
            static /*0x0*/ System.Collections.Specialized.HybridDictionary servicePoints;
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

            static /*0x185c664*/ ServicePointManager();
            static /*0x185c730*/ System.Net.ICertificatePolicy GetLegacyCertificatePolicy();
            static /*0x185c794*/ bool get_CheckCertificateRevocationList();
            static /*0x185c7f8*/ int get_DnsRefreshTimeout();
            static /*0x185c85c*/ System.Net.SecurityProtocolType get_SecurityProtocol();
            static /*0x185c8c0*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            static /*0x185c924*/ System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy);

            class SPKey
            {
                /*0x10*/ System.Uri uri;
                /*0x18*/ System.Uri proxy;
                /*0x20*/ bool use_connect;

                /*0x1486980*/ SPKey(System.Uri uri, System.Uri proxy, bool use_connect);
                /*0x14869c4*/ bool get_UsesProxy();
                /*0x1486a30*/ int GetHashCode();
                /*0x1486b10*/ bool Equals(object obj);
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

            /*0x185b550*/ ServicePointScheduler(System.Net.ServicePoint servicePoint, int connectionLimit, int maxIdleTime);
            /*0x185d048*/ System.Net.ServicePoint get_ServicePoint();
            /*0x185d050*/ int get_MaxIdleTime();
            /*0x185d058*/ int get_ConnectionLimit();
            /*0x185d060*/ void Run();
            /*0x185d15c*/ void StartScheduler();
            /*0x185d21c*/ void Cleanup();
            /*0x185d3f4*/ void RunSchedulerIteration();
            /*0x185d6bc*/ bool OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation, System.Threading.Tasks.Task<System.ValueTuple<bool, System.Net.WebOperation>> task);
            /*0x185d9ec*/ void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection);
            /*0x185d5c4*/ bool SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group);
            /*0x185da2c*/ void RemoveOperation(System.Net.WebOperation operation);
            /*0x185d91c*/ void RemoveIdleConnection(System.Net.WebConnection connection);
            /*0x185c17c*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x185dafc*/ System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name);
            /*0x185dcf0*/ void OnConnectionCreated(System.Net.WebConnection connection);
            /*0x185dcfc*/ void OnConnectionClosed(System.Net.WebConnection connection);

            class ConnectionGroup
            {
                static /*0x0*/ int nextId;
                /*0x10*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;
                /*0x20*/ int ID;
                /*0x28*/ System.Collections.Generic.LinkedList<System.Net.WebConnection> connections;
                /*0x30*/ System.Collections.Generic.LinkedList<System.Net.WebOperation> queue;

                /*0x1487c78*/ ConnectionGroup(System.Net.ServicePointScheduler scheduler, string name);
                /*0x1487c70*/ System.Net.ServicePointScheduler get_Scheduler();
                /*0x14876c0*/ bool IsEmpty();
                /*0x1487d74*/ void RemoveConnection(System.Net.WebConnection connection);
                /*0x1487dfc*/ void Cleanup();
                /*0x1487eec*/ void EnqueueOperation(System.Net.WebOperation operation);
                /*0x1487f50*/ System.Net.WebOperation GetNextOperation();
                /*0x1488048*/ System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation);
                /*0x148839c*/ System.ValueTuple<System.Net.WebConnection, bool> CreateOrReuseConnection(System.Net.WebOperation operation, bool force);
            }

            class AsyncManualResetEvent
            {
                /*0x10*/ System.Threading.Tasks.TaskCompletionSource<bool> m_tcs;

                /*0x1487bcc*/ AsyncManualResetEvent(bool state);
                /*0x1487804*/ System.Threading.Tasks.Task<bool> WaitAsync(int millisecondTimeout);
                /*0x1487950*/ void Set();
                /*0x1487738*/ void Reset();

                struct <WaitAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ int millisecondTimeout;
                    /*0x38*/ System.Net.ServicePointScheduler.AsyncManualResetEvent <>4__this;
                    /*0x40*/ System.Threading.Tasks.Task <timeoutTask>5__1;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                    /*0xae535c*/ void MoveNext();
                    /*0xae5364*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c
                {
                    static /*0x0*/ System.Net.ServicePointScheduler.AsyncManualResetEvent.<> <>9;
                    static /*0x8*/ System.Func<object, bool> <>9__4_0;

                    static /*0x232694c*/ <>c();
                    /*0x23269ac*/ <>c();
                    /*0x23269b4*/ bool <Set>b__4_0(object s);
                }
            }

            struct <StartScheduler>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.ServicePointScheduler <>4__this;
                /*0x40*/ System.Collections.Generic.List<System.Threading.Tasks.Task> <taskList>5__1;
                /*0x48*/ System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebOperation> <operationArray>5__2;
                /*0x50*/ System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebConnection, System.Threading.Tasks.Task> <idleArray>5__3;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                /*0xaa23d4*/ void MoveNext();
                /*0xaa23dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource
        {
            /*0x10*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result> completion;

            /*0x1701858*/ WebCompletionSource();
            /*0x17018d4*/ bool TrySetCompleted();
            /*0x1701960*/ bool TrySetCanceled();
            /*0x1701a2c*/ bool TrySetException(System.Exception error);
            /*0x1701ad4*/ bool get_IsCompleted();
            /*0x1701b28*/ void ThrowOnError();
            /*0x1701bcc*/ System.Threading.Tasks.Task<bool> WaitForCompletion(bool throwOnError);

            enum State
            {
                Running = 0,
                Completed = 1,
                Canceled = 2,
                Faulted = 3,
            }

            class Result
            {
                /*0x10*/ System.Net.WebCompletionSource.State <State>k__BackingField;
                /*0x18*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo <Error>k__BackingField;

                /*0x148eed4*/ Result(System.Net.WebCompletionSource.State state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x148eec4*/ System.Net.WebCompletionSource.State get_State();
                /*0x148eecc*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
            }

            struct <WaitForCompletion>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ System.Net.WebCompletionSource <>4__this;
                /*0x38*/ bool throwOnError;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebCompletionSource.Result> <>u__1;

                /*0xaa2bb0*/ void MoveNext();
                /*0xaa2bb8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
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

            static /*0x17021e4*/ System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error);
            static /*0x17023b4*/ bool ReadLine(byte[] buffer, ref int start, int max, ref string output);
            /*0x1701d14*/ WebConnection(System.Net.ServicePoint sPoint);
            /*0x1701d0c*/ System.Net.ServicePoint get_ServicePoint();
            /*0x1701d40*/ bool CanReuse();
            /*0x1701d74*/ bool CheckReusable();
            /*0x1701e1c*/ System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x1701f40*/ System.Threading.Tasks.Task<bool> CreateStream(System.Net.WebOperation operation, bool reused, System.Threading.CancellationToken cancellationToken);
            /*0x17020a4*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x17025b8*/ bool CanReuseConnection(System.Net.WebOperation operation);
            /*0x1702a2c*/ bool PrepareSharingNtlm(System.Net.WebOperation operation);
            /*0x1702d64*/ void Reset();
            /*0x1702e30*/ void Close(bool reset);
            /*0x1702f00*/ void CloseSocket();
            /*0x1702a1c*/ bool get_Closed();
            /*0x1703120*/ System.DateTime get_IdleSince();
            /*0x1703128*/ bool StartOperation(System.Net.WebOperation operation, bool reused);
            /*0x1703618*/ bool Continue(System.Net.WebOperation next);
            /*0x17037a0*/ void Dispose(bool disposing);
            /*0x17037e8*/ void Dispose();
            /*0x1702e24*/ void ResetNtlm();
            /*0x17037f0*/ bool get_NtlmAuthenticated();
            /*0x17037f8*/ void set_NtlmAuthenticated(bool value);
            /*0x1703804*/ System.Net.NetworkCredential get_NtlmCredential();
            /*0x170380c*/ void set_NtlmCredential(System.Net.NetworkCredential value);
            /*0x1703814*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x170381c*/ void set_UnsafeAuthenticatedConnectionSharing(bool value);

            struct <Connect>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebConnection <>4__this;
                /*0x38*/ System.Net.WebOperation operation;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Exception <connectException>5__1;
                /*0x50*/ System.Net.IPAddress[] <>7__wrap1;
                /*0x58*/ int <>7__wrap2;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xaa2bc0*/ void MoveNext();
                /*0xaa2bc8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ System.Net.WebConnection <>4__this;
                /*0x38*/ System.Net.WebOperation operation;
                /*0x40*/ bool reused;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Net.Sockets.NetworkStream <stream>5__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__2;

                /*0xaa2bd4*/ void MoveNext();
                /*0xaa2bdc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitConnection>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.WebRequestStream> <>t__builder;
                /*0x30*/ System.Net.WebOperation operation;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.WebConnection <>4__this;
                /*0x48*/ bool <reused>5__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;

                /*0xaa2be4*/ void MoveNext();
                /*0xaa2bec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebConnectionStream : System.IO.Stream
        {
            /*0x28*/ bool closed;
            /*0x29*/ bool disposed;
            /*0x30*/ object locker;
            /*0x38*/ int read_timeout;
            /*0x3c*/ int write_timeout;
            /*0x40*/ bool IgnoreIOErrors;
            /*0x48*/ System.Net.HttpWebRequest <Request>k__BackingField;
            /*0x50*/ System.Net.WebConnection <Connection>k__BackingField;
            /*0x58*/ System.Net.WebOperation <Operation>k__BackingField;
            /*0x60*/ System.IO.Stream <InnerStream>k__BackingField;

            /*0x1703828*/ WebConnectionStream(System.Net.WebConnection cnc, System.Net.WebOperation operation, System.IO.Stream stream);
            /*0x17038fc*/ System.Net.HttpWebRequest get_Request();
            /*0x1703904*/ System.Net.WebConnection get_Connection();
            /*0x170390c*/ System.Net.WebOperation get_Operation();
            /*0x1703914*/ System.Net.ServicePoint get_ServicePoint();
            /*0x1703930*/ System.IO.Stream get_InnerStream();
            /*0x1703938*/ int get_ReadTimeout();
            /*0x1703940*/ void set_ReadTimeout(int value);
            /*0x17039a4*/ int get_WriteTimeout();
            /*0x17039ac*/ System.Exception GetException(System.Exception e);
            /*0x1703b80*/ int Read(byte[] buffer, int offset, int size);
            /*0x1703e58*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x170402c*/ int EndRead(System.IAsyncResult r);
            /*0x1704158*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x170432c*/ void EndWrite(System.IAsyncResult r);
            /*0x1704424*/ void Write(byte[] buffer, int offset, int size);
            /*0x1704614*/ void Flush();
            /*0x1704618*/ void InternalClose();
            void Close_internal(ref bool disposed);
            /*0x1704624*/ void Close();
            /*0x1704638*/ long Seek(long a, System.IO.SeekOrigin b);
            /*0x1704678*/ bool get_CanSeek();
            /*0x1704680*/ long get_Position();
            /*0x17046c0*/ void set_Position(long value);
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

            /*0x1704710*/ WebConnectionTunnel(System.Net.HttpWebRequest request, System.Uri connectUri);
            /*0x1704700*/ System.Net.HttpWebRequest get_Request();
            /*0x1704708*/ System.Uri get_ConnectUri();
            /*0x1704748*/ bool get_Success();
            /*0x1704750*/ void set_Success(bool value);
            /*0x170475c*/ bool get_CloseConnection();
            /*0x1704764*/ void set_CloseConnection(bool value);
            /*0x1704770*/ int get_StatusCode();
            /*0x1704778*/ void set_StatusCode(int value);
            /*0x1704780*/ void set_StatusDescription(string value);
            /*0x1704788*/ string[] get_Challenge();
            /*0x1704790*/ void set_Challenge(string[] value);
            /*0x1704798*/ System.Net.WebHeaderCollection get_Headers();
            /*0x17047a0*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x17047a8*/ System.Version get_ProxyVersion();
            /*0x17047b0*/ void set_ProxyVersion(System.Version value);
            /*0x17047b8*/ byte[] get_Data();
            /*0x17047c0*/ void set_Data(byte[] value);
            /*0x17047c8*/ System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x17048ec*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x1704a2c*/ void FlushContents(System.IO.Stream stream, int contentLength);

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
                /*0x48*/ bool <have_auth>5__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> <>u__2;

                /*0xaa2bf4*/ void MoveNext();
                /*0xaa2bfc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadHeaders>d__43 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.IO.Stream stream;
                /*0x40*/ byte[] <buffer>5__1;
                /*0x48*/ System.IO.MemoryStream <ms>5__2;
                /*0x50*/ System.Net.WebConnectionTunnel <>4__this;
                /*0x58*/ byte[] <retBuffer>5__3;
                /*0x60*/ int <status>5__4;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xae51f8*/ void MoveNext();
                /*0xae5200*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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
            /*0x40*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebRequestStream> requestTask;
            /*0x48*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebRequestStream> requestWrittenTask;
            /*0x50*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebResponseStream> responseTask;
            /*0x58*/ System.Threading.Tasks.TaskCompletionSource<bool> completeResponseReadTask;
            /*0x60*/ System.Threading.Tasks.TaskCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> finishedTask;
            /*0x68*/ System.Net.WebRequestStream writeStream;
            /*0x70*/ System.Net.WebResponseStream responseStream;
            /*0x78*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo disposedInfo;
            /*0x80*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo closedInfo;
            /*0x88*/ System.Net.WebOperation priorityRequest;
            /*0x90*/ bool finishedReading;
            /*0x94*/ int requestSent;

            /*0x1707a00*/ WebOperation(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, bool isNtlmChallenge, System.Threading.CancellationToken cancellationToken);
            /*0x17079c8*/ System.Net.HttpWebRequest get_Request();
            /*0x17079d0*/ System.Net.WebConnection get_Connection();
            /*0x17079d8*/ void set_Connection(System.Net.WebConnection value);
            /*0x17079e0*/ System.Net.ServicePoint get_ServicePoint();
            /*0x17079e8*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x17079f0*/ System.Net.BufferOffsetSize get_WriteBuffer();
            /*0x17079f8*/ bool get_IsNtlmChallenge();
            /*0x1703b24*/ bool get_Aborted();
            /*0x1707c04*/ bool get_Closed();
            /*0x1707c3c*/ void Abort();
            /*0x1707e30*/ void Close();
            /*0x1707d84*/ void SetCanceled();
            /*0x1707ef0*/ void SetError(System.Exception error);
            /*0x1707c90*/ System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo, bool> SetDisposed(ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x1707fb8*/ void ThrowIfDisposed();
            /*0x1708024*/ void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x1703dec*/ void ThrowIfClosedOrDisposed();
            /*0x17080b4*/ void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x1708068*/ void ThrowDisposed(ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x170332c*/ void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection);
            /*0x170810c*/ void SetPriorityRequest(System.Net.WebOperation operation);
            /*0x1708298*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStream();
            /*0x17082e4*/ System.Net.WebRequestStream get_WriteStream();
            /*0x1708308*/ System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream();
            /*0x1708354*/ System.Threading.Tasks.Task<System.ValueTuple<bool, System.Net.WebOperation>> WaitForCompletion(bool ignoreErrors);
            /*0x1703558*/ void Run();
            /*0x1708488*/ void FinishReading();
            /*0x1708548*/ void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error);
            /*0x17085cc*/ void CompleteResponseRead(bool ok, System.Exception error);
            /*0x1708664*/ void <RegisterRequest>b__46_0();

            struct <WaitForCompletion>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<bool, System.Net.WebOperation>> <>t__builder;
                /*0x30*/ System.Net.WebOperation <>4__this;
                /*0x38*/ bool ignoreErrors;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<bool, System.Net.WebOperation>> <>u__1;

                /*0xae5230*/ void MoveNext();
                /*0xae5238*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Run>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.WebOperation <>4__this;
                /*0x40*/ System.Net.WebRequestStream <requestStream>5__1;
                /*0x48*/ System.Net.WebResponseStream <stream>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xae521c*/ void MoveNext();
                /*0xae5224*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <FinishReading>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.WebOperation <>4__this;
                /*0x40*/ System.Exception <error>5__1;
                /*0x48*/ bool <ok>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xae5208*/ void MoveNext();
                /*0xae5210*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebRequestStream : System.Net.WebConnectionStream
        {
            static /*0x0*/ byte[] crlf;
            /*0x68*/ System.IO.MemoryStream writeBuffer;
            /*0x70*/ bool requestWritten;
            /*0x71*/ bool allowBuffering;
            /*0x72*/ bool sendChunked;
            /*0x78*/ System.Net.WebCompletionSource pendingWrite;
            /*0x80*/ long totalWritten;
            /*0x88*/ byte[] headers;
            /*0x90*/ bool headersSent;
            /*0x94*/ int completeRequestWritten;
            /*0x98*/ int chunkTrailerWritten;
            /*0x9c*/ bool <KeepAlive>k__BackingField;

            static /*0x170c4f4*/ WebRequestStream();
            /*0x170b594*/ WebRequestStream(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel);
            /*0x170b758*/ bool get_KeepAlive();
            /*0x170b760*/ long get_Length();
            /*0x170b7a0*/ bool get_CanRead();
            /*0x170b7a8*/ bool get_CanWrite();
            /*0x170b7b0*/ bool get_HasWriteBuffer();
            /*0x170b7e4*/ int get_WriteBufferLength();
            /*0x170b82c*/ System.Net.BufferOffsetSize GetWriteBuffer();
            /*0x170b910*/ System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken);
            /*0x170ba20*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170bb5c*/ System.Threading.Tasks.Task ProcessWrite(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170bc9c*/ void CheckWriteOverflow(long contentLength, long totalWritten, long size);
            /*0x170bd44*/ System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken);
            /*0x170be58*/ System.Threading.Tasks.Task SetHeadersAsync(bool setInternalLength, System.Threading.CancellationToken cancellationToken);
            /*0x170bf84*/ System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken);
            /*0x170c098*/ System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken);
            /*0x170c1a8*/ System.Threading.Tasks.Task WriteChunkTrailer();
            /*0x170bd3c*/ void KillBuffer();
            /*0x170c2b8*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170c36c*/ void Close_internal(ref bool disposed);

            struct <FinishWriting>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xae5240*/ void MoveNext();
                /*0xae5248*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteAsync>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ byte[] buffer;
                /*0x48*/ int offset;
                /*0x4c*/ int size;
                /*0x50*/ System.Net.WebCompletionSource <completion>5__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0xae5290*/ void MoveNext();
                /*0xae5298*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessWrite>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xae5268*/ void MoveNext();
                /*0xae5270*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Initialize>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0xae5254*/ void MoveNext();
                /*0xae525c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SetHeadersAsync>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool setInternalLength;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xae527c*/ void MoveNext();
                /*0xae5284*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteRequestAsync>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.BufferOffsetSize <buffer>5__1;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0xae52cc*/ void MoveNext();
                /*0xae52d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer_inner>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xae52b8*/ void MoveNext();
                /*0xae52c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.Tasks.Task <timeoutTask>5__1;
                /*0x40*/ System.Threading.CancellationTokenSource <cts>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xae52a4*/ void MoveNext();
                /*0xae52ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebResponseStream : System.Net.WebConnectionStream
        {
            /*0x68*/ System.Net.BufferOffsetSize readBuffer;
            /*0x70*/ long contentLength;
            /*0x78*/ long totalRead;
            /*0x80*/ bool nextReadCalled;
            /*0x84*/ int stream_length;
            /*0x88*/ System.Net.WebCompletionSource pendingRead;
            /*0x90*/ object locker;
            /*0x98*/ int nestedRead;
            /*0x9c*/ bool read_eof;
            /*0xa0*/ System.Net.WebRequestStream <RequestStream>k__BackingField;
            /*0xa8*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0xb0*/ System.Net.HttpStatusCode <StatusCode>k__BackingField;
            /*0xb8*/ string <StatusDescription>k__BackingField;
            /*0xc0*/ System.Version <Version>k__BackingField;
            /*0xc8*/ bool <KeepAlive>k__BackingField;
            /*0xc9*/ bool <ChunkedRead>k__BackingField;
            /*0xd0*/ System.Net.MonoChunkStream <ChunkStream>k__BackingField;

            /*0x170c7b8*/ WebResponseStream(System.Net.WebRequestStream request);
            /*0x170c75c*/ System.Net.WebRequestStream get_RequestStream();
            /*0x170c764*/ System.Net.WebHeaderCollection get_Headers();
            /*0x170c76c*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x170c774*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x170c77c*/ void set_StatusCode(System.Net.HttpStatusCode value);
            /*0x170c784*/ string get_StatusDescription();
            /*0x170c78c*/ void set_StatusDescription(string value);
            /*0x170c794*/ System.Version get_Version();
            /*0x170c79c*/ void set_Version(System.Version value);
            /*0x170c7a4*/ bool get_KeepAlive();
            /*0x170c7ac*/ void set_KeepAlive(bool value);
            /*0x170c86c*/ long get_Length();
            /*0x170c874*/ bool get_CanRead();
            /*0x170c87c*/ bool get_CanWrite();
            /*0x170c884*/ bool get_ChunkedRead();
            /*0x170c88c*/ void set_ChunkedRead(bool value);
            /*0x170c898*/ System.Net.MonoChunkStream get_ChunkStream();
            /*0x170c8a0*/ void set_ChunkStream(System.Net.MonoChunkStream value);
            /*0x170c8a8*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170ca08*/ System.Threading.Tasks.Task<System.ValueTuple<int, int>> ProcessRead(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170cb70*/ System.Threading.Tasks.Task<int> InnerReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170ccd4*/ System.Threading.Tasks.Task<int> EnsureReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170ce38*/ bool CheckAuthHeader(string headerName);
            /*0x170cebc*/ bool IsNtlmAuth();
            /*0x170d014*/ bool get_ExpectContent();
            /*0x170d0a8*/ System.Threading.Tasks.Task Initialize(System.Net.BufferOffsetSize buffer, System.Threading.CancellationToken cancellationToken);
            /*0x170d1cc*/ System.Threading.Tasks.Task ReadAllAsync(bool resending, System.Threading.CancellationToken cancellationToken);
            /*0x170d2f8*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x170d398*/ void Close_internal(ref bool disposed);
            /*0x170d404*/ System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, string where);
            /*0x170d6b4*/ System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x170d7c8*/ bool GetResponse(System.Net.BufferOffsetSize buffer, ref int pos, ref System.Net.ReadState state);

            class <>c__DisplayClass48_0
            {
                /*0x10*/ System.Net.WebResponseStream <>4__this;
                /*0x18*/ byte[] buffer;
                /*0x20*/ int offset;
                /*0x24*/ int size;

                /*0x2322974*/ <>c__DisplayClass48_0();
                /*0x232297c*/ System.Threading.Tasks.Task<System.ValueTuple<int, int>> <ReadAsync>b__0(System.Threading.CancellationToken ct);
                /*0x23229a8*/ void <ReadAsync>b__1();
            }

            struct <ReadAsync>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int offset;
                /*0x44*/ int size;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Net.WebCompletionSource <completion>5__1;
                /*0x58*/ System.Net.WebResponseStream.<> <>8__2;
                /*0x60*/ System.Exception <throwMe>5__3;
                /*0x68*/ int <oldBytes>5__4;
                /*0x6c*/ int <nbytes>5__5;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x80*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<int, int>> <>u__2;

                /*0xae534c*/ void MoveNext();
                /*0xae5354*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessRead>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<int, int>> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.WebResponseStream <>4__this;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x54*/ int <oldBytes>5__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xae5328*/ void MoveNext();
                /*0xae5330*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InnerReadAsync>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ byte[] buffer;
                /*0x48*/ int offset;
                /*0x4c*/ int size;
                /*0x50*/ bool <done>5__1;
                /*0x54*/ int <nbytes>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xae5318*/ void MoveNext();
                /*0xae5320*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <EnsureReadAsync>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ byte[] <morebytes>5__1;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ int <nbytes>5__2;
                /*0x50*/ byte[] buffer;
                /*0x58*/ int offset;
                /*0x5c*/ int size;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0xae52e0*/ void MoveNext();
                /*0xae52e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Initialize>d__56 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Net.BufferOffsetSize buffer;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ string <me>5__1;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xae5304*/ void MoveNext();
                /*0xae530c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadAllAsync>d__57 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.WebCompletionSource <completion>5__1;
                /*0x48*/ System.Threading.Tasks.Task <timeoutTask>5__2;
                /*0x50*/ bool resending;
                /*0x58*/ System.IO.MemoryStream <ms>5__3;
                /*0x60*/ System.Net.BufferOffsetSize <buffer>5__4;
                /*0x68*/ int <read>5__5;
                /*0x70*/ byte[] <b>5__6;
                /*0x78*/ int <remaining>5__7;
                /*0x7c*/ int <readSize>5__8;
                /*0x80*/ int <new_size>5__9;
                /*0x88*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;
                /*0x98*/ System.Runtime.CompilerServices.TaskAwaiter<int> <>u__2;

                /*0xae5338*/ void MoveNext();
                /*0xae5340*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitReadAsync>d__61 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.BufferOffsetSize <buffer>5__1;
                /*0x48*/ System.Net.ReadState <state>5__2;
                /*0x4c*/ int <position>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0xae52f0*/ void MoveNext();
                /*0xae52f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace Sockets
        {
            class SocketException : System.ComponentModel.Win32Exception
            {
                /*0x90*/ System.Net.EndPoint m_EndPoint;

                static /*0x1865cc8*/ int WSAGetLastError_internal();
                /*0x185e7c0*/ SocketException();
                /*0x1865ccc*/ SocketException(int error, string message);
                /*0x185a554*/ SocketException(int errorCode);
                /*0x185f6e4*/ SocketException(System.Net.Sockets.SocketError socketError);
                /*0x1865d48*/ SocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x1865dd4*/ string get_Message();
                /*0x1865a44*/ System.Net.Sockets.SocketError get_SocketErrorCode();
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

                /*0x1cbdc28*/ LingerOption(bool enable, int seconds);
                /*0x1cbdc68*/ void set_Enabled(bool value);
                /*0x1cbdc74*/ void set_LingerTime(int value);
            }

            class MulticastOption
            {
            }

            class NetworkStream : System.IO.Stream
            {
                /*0x28*/ System.Net.Sockets.Socket m_StreamSocket;
                /*0x30*/ bool m_Readable;
                /*0x31*/ bool m_Writeable;
                /*0x32*/ bool m_OwnsSocket;
                /*0x34*/ int m_CloseTimeout;
                /*0x38*/ bool m_CleanedUp;
                /*0x3c*/ int m_CurrentReadTimeout;
                /*0x40*/ int m_CurrentWriteTimeout;

                /*0x1cc9b8c*/ NetworkStream(System.Net.Sockets.Socket socket);
                /*0x1cc9d40*/ NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket);
                /*0x1cc9e2c*/ System.Net.Sockets.Socket get_InternalSocket();
                /*0x1cc9ecc*/ bool get_CanRead();
                /*0x1cc9ed4*/ bool get_CanSeek();
                /*0x1cc9edc*/ bool get_CanWrite();
                /*0x1cc9ee4*/ int get_ReadTimeout();
                /*0x1cc9f74*/ void set_ReadTimeout(int value);
                /*0x1cca0b8*/ int get_WriteTimeout();
                /*0x1cca148*/ long get_Length();
                /*0x1cca1a4*/ long get_Position();
                /*0x1cca200*/ void set_Position(long value);
                /*0x1cca25c*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x1cc9c68*/ void InitNetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess Access);
                /*0x1cca2b8*/ int Read(byte[] buffer, int offset, int size);
                /*0x1cca6d8*/ void Write(byte[] buffer, int offset, int size);
                /*0x1ccaaf8*/ void Dispose(bool disposing);
                /*0x1ccab7c*/ void Finalize();
                /*0x1ccabf4*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x1ccb02c*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x1ccb36c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x1ccb7a4*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x1ccbae4*/ void Flush();
                /*0x1cca004*/ void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, int timeout, bool silent);
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

            class Socket : System.IDisposable
            {
                static /*0x0*/ object s_InternalSyncObject;
                static /*0x8*/ bool s_SupportsIPv4;
                static /*0x9*/ bool s_SupportsIPv6;
                static /*0xa*/ bool s_OSSupportsIPv6;
                static /*0xb*/ bool s_Initialized;
                static /*0xc*/ bool s_LoggingEnabled;
                static /*0x10*/ System.AsyncCallback AcceptAsyncCallback;
                static /*0x18*/ System.IOAsyncCallback BeginAcceptCallback;
                static /*0x20*/ System.IOAsyncCallback BeginAcceptReceiveCallback;
                static /*0x28*/ System.AsyncCallback ConnectAsyncCallback;
                static /*0x30*/ System.IOAsyncCallback BeginConnectCallback;
                static /*0x38*/ System.AsyncCallback DisconnectAsyncCallback;
                static /*0x40*/ System.IOAsyncCallback BeginDisconnectCallback;
                static /*0x48*/ System.AsyncCallback ReceiveAsyncCallback;
                static /*0x50*/ System.IOAsyncCallback BeginReceiveCallback;
                static /*0x58*/ System.IOAsyncCallback BeginReceiveGenericCallback;
                static /*0x60*/ System.AsyncCallback ReceiveFromAsyncCallback;
                static /*0x68*/ System.IOAsyncCallback BeginReceiveFromCallback;
                static /*0x70*/ System.AsyncCallback SendAsyncCallback;
                static /*0x78*/ System.IOAsyncCallback BeginSendGenericCallback;
                static /*0x80*/ System.AsyncCallback SendToAsyncCallback;
                /*0x10*/ bool is_closed;
                /*0x11*/ bool is_listening;
                /*0x12*/ bool useOverlappedIO;
                /*0x14*/ int linger_timeout;
                /*0x18*/ System.Net.Sockets.AddressFamily addressFamily;
                /*0x1c*/ System.Net.Sockets.SocketType socketType;
                /*0x20*/ System.Net.Sockets.ProtocolType protocolType;
                /*0x28*/ System.Net.Sockets.SafeSocketHandle m_Handle;
                /*0x30*/ System.Net.EndPoint seed_endpoint;
                /*0x38*/ System.Threading.SemaphoreSlim ReadSem;
                /*0x40*/ System.Threading.SemaphoreSlim WriteSem;
                /*0x48*/ bool is_blocking;
                /*0x49*/ bool is_bound;
                /*0x4a*/ bool is_connected;
                /*0x4c*/ int m_IntCleanedUp;
                /*0x50*/ bool connect_in_progress;
                /*0x54*/ int ID;

                static /*0x1864790*/ Socket();
                static /*0x185e9e8*/ bool get_SupportsIPv4();
                static /*0x185ea58*/ bool get_OSSupportsIPv4();
                static /*0x185eac8*/ bool get_SupportsIPv6();
                static /*0x185eb38*/ bool get_OSSupportsIPv6();
                static /*0x1860954*/ object get_InternalSyncObject();
                static /*0x185e514*/ void InitializeSockets();
                static /*0x18612a8*/ System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x18613e0*/ System.Net.SocketAddress LocalEndPoint_internal(nint socket, int family, ref int error);
                static /*0x18614c0*/ void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool block, ref int error);
                static /*0x185a254*/ void Blocking_internal(nint socket, bool block, ref int error);
                static /*0x18617cc*/ bool Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x1861914*/ bool Poll_internal(nint socket, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x1861a54*/ System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, ref int error, bool blocking);
                static /*0x1861f7c*/ nint Accept_internal(nint sock, ref int error, bool blocking);
                static /*0x1862048*/ void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error);
                static /*0x1862170*/ void Bind_internal(nint sock, System.Net.SocketAddress sa, ref int error);
                static /*0x1862264*/ void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int backlog, ref int error);
                static /*0x186238c*/ void Listen_internal(nint sock, int backlog, ref int error);
                static /*0x1862d6c*/ void BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x1862988*/ void BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x1862708*/ void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x1863088*/ void Connect_internal(nint sock, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x1863180*/ void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool reuse, ref int error);
                static /*0x1863358*/ void Disconnect_internal(nint sock, bool reuse, ref int error);
                static /*0x18635ec*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x18638cc*/ int Receive_internal(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x18634e4*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x18638d4*/ int Receive_internal(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1863a6c*/ int ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x1863c90*/ int ReceiveFrom_internal(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x1863ea8*/ void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, int sent_so_far);
                static /*0x1863da0*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x186418c*/ int Send_internal(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1863c98*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1864194*/ int Send_internal(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x1864254*/ void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x1864394*/ void GetSocketOption_obj_internal(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x1860ea0*/ void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x1864398*/ void SetSocketOption_internal(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x186439c*/ int IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x18644ec*/ int IOControl_internal(nint sock, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x185a264*/ void Close_internal(nint socket, ref int error);
                static /*0x1860c28*/ void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x185a25c*/ void Shutdown_internal(nint socket, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x185a260*/ void cancel_blocking_socket_operation(System.Threading.Thread thread);
                static /*0x18646f0*/ int get_FamilyHint();
                static /*0x186478c*/ bool IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                static /*0x1860a48*/ bool IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                /*0x185e2a0*/ Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x1860ff8*/ Socket(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle);
                /*0x185eba8*/ nint get_Handle();
                /*0x185ebc4*/ System.Net.Sockets.AddressFamily get_AddressFamily();
                /*0x185ebcc*/ System.Net.Sockets.SocketType get_SocketType();
                /*0x185ebd4*/ System.Net.Sockets.ProtocolType get_ProtocolType();
                /*0x185ebdc*/ void set_DontFragment(bool value);
                /*0x185ed70*/ bool get_DualMode();
                /*0x185eff0*/ void set_DualMode(bool value);
                /*0x185f064*/ bool get_IsDualMode();
                /*0x185f07c*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x185f758*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x185f918*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x185faa0*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x185bb58*/ int IOControl(System.Net.Sockets.IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x185e834*/ void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level);
                /*0x1860244*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x18604c4*/ int EndSend(System.IAsyncResult asyncResult);
                /*0x1860614*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x1860804*/ int EndReceive(System.IAsyncResult asyncResult);
                /*0x1860a38*/ bool get_CleanedUp();
                /*0x1860aa8*/ void Dispose();
                /*0x1860b20*/ void Finalize();
                /*0x1860b94*/ void InternalShutdown(System.Net.Sockets.SocketShutdown how);
                /*0x1860d50*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue, bool silent);
                /*0x185e910*/ void SocketDefaults();
                /*0x185e7bc*/ nint Socket_internal(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, ref int error);
                /*0x1861138*/ System.Net.EndPoint get_LocalEndPoint();
                /*0x18613e4*/ bool get_Blocking();
                /*0x18613ec*/ void set_Blocking(bool value);
                /*0x18615e8*/ bool get_Connected();
                /*0x18610f4*/ void set_NoDelay(bool value);
                /*0x1861640*/ bool Poll(int microSeconds, System.Net.Sockets.SelectMode mode);
                /*0x1861918*/ System.Net.Sockets.Socket Accept();
                /*0x1861b64*/ void Accept(System.Net.Sockets.Socket acceptSocket);
                /*0x1861c90*/ System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult);
                /*0x1861cc0*/ System.Net.Sockets.Socket EndAccept(ref byte[] buffer, ref int bytesTransferred, System.IAsyncResult asyncResult);
                /*0x185c4e4*/ void Bind(System.Net.EndPoint localEP);
                /*0x1862174*/ void Listen(int backlog);
                /*0x1862390*/ void Connect(System.Net.EndPoint remoteEP);
                /*0x18627fc*/ System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x1862fd8*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x1863090*/ void Disconnect(bool reuseSocket);
                /*0x18632a8*/ void EndDisconnect(System.IAsyncResult asyncResult);
                /*0x185f980*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x185fb08*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x186068c*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x186086c*/ int EndReceive(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x18638dc*/ int ReceiveFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.SocketError errorCode);
                /*0x1863b7c*/ int EndReceiveFrom(System.IAsyncResult asyncResult, ref System.Net.EndPoint endPoint);
                /*0x185f7c0*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x185f0e4*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x18602bc*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x186052c*/ int EndSend(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x186419c*/ int EndSendTo(System.IAsyncResult asyncResult);
                /*0x185ee4c*/ object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName);
                /*0x185ec4c*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue);
                /*0x18600c0*/ int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x18644f0*/ void Close();
                /*0x18644f8*/ void Close(int timeout);
                /*0x1864500*/ void Dispose(bool disposing);
                /*0x1864570*/ void Linger(nint handle);
                /*0x1861228*/ void ThrowIfDisposedAndClosed();
                /*0x1863360*/ void ThrowIfBufferNull(byte[] buffer);
                /*0x18633bc*/ void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size);
                /*0x18615f0*/ void ThrowIfUdp();
                /*0x1861d98*/ System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, string methodName, string argName);
                /*0x18636f4*/ void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, nint handle, System.IOSelectorJob job);
                /*0x1861f84*/ System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input);

                struct WSABUF
                {
                    /*0x10*/ int len;
                    /*0x18*/ nint buf;
                }

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.Socket.<> <>9;
                    static /*0x8*/ System.IOAsyncCallback <>9__242_0;

                    static /*0x1488554*/ <>c();
                    /*0x14885b4*/ <>c();
                    /*0x14885bc*/ void <BeginSend>b__242_0(System.IOAsyncResult s);
                    /*0x148865c*/ void <.cctor>b__310_0(System.IAsyncResult ares);
                    /*0x148897c*/ void <.cctor>b__310_1(System.IOAsyncResult ares);
                    /*0x1488ac0*/ void <.cctor>b__310_2(System.IOAsyncResult ares);
                    /*0x1488d08*/ void <.cctor>b__310_3(System.IAsyncResult ares);
                    /*0x1488f7c*/ void <.cctor>b__310_4(System.IOAsyncResult ares);
                    /*0x1489264*/ void <.cctor>b__310_5(System.IAsyncResult ares);
                    /*0x14894d8*/ void <.cctor>b__310_6(System.IOAsyncResult ares);
                    /*0x14895f0*/ void <.cctor>b__310_7(System.IAsyncResult ares);
                    /*0x148986c*/ void <.cctor>b__310_8(System.IOAsyncResult ares);
                    /*0x1489a68*/ void <.cctor>b__310_9(System.IOAsyncResult ares);
                    /*0x1489b8c*/ void <.cctor>b__310_10(System.IAsyncResult ares);
                    /*0x1489e0c*/ void <.cctor>b__310_11(System.IOAsyncResult ares);
                    /*0x1489f94*/ void <.cctor>b__310_12(System.IAsyncResult ares);
                    /*0x148a210*/ void <.cctor>b__310_13(System.IOAsyncResult ares);
                    /*0x148a334*/ void <.cctor>b__310_14(System.IAsyncResult ares);
                }

                class <>c__DisplayClass243_0
                {
                    /*0x10*/ int sent_so_far;

                    /*0x148a5b0*/ <>c__DisplayClass243_0();
                    /*0x148a5b8*/ void <BeginSendCallback>b__0(System.IOAsyncResult s);
                }

                class <>c__DisplayClass299_0
                {
                    /*0x10*/ System.Net.Sockets.Socket <>4__this;
                    /*0x18*/ System.IOSelectorJob job;
                    /*0x20*/ nint handle;

                    /*0x148a668*/ <>c__DisplayClass299_0();
                    /*0x148a670*/ void <QueueIOSelectorJob>b__0(System.Threading.Tasks.Task t);
                }
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

            class SafeSocketHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x0*/ bool THROW_ON_ABORT_RETRIES;
                /*0x20*/ System.Collections.Generic.List<System.Threading.Thread> blocking_threads;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> threads_stacktraces;
                /*0x30*/ bool in_cleanup;

                static /*0x185a7c4*/ SafeSocketHandle();
                /*0x1859bcc*/ SafeSocketHandle(nint preexistingHandle, bool ownsHandle);
                /*0x1859c9c*/ bool ReleaseHandle();
                /*0x185a268*/ void RegisterForBlockingSyscall();
                /*0x185a5c8*/ void UnRegisterForBlockingSyscall();
            }

            class SocketAsyncEventArgs : System.EventArgs, System.IDisposable
            {
                /*0x10*/ bool disposed;
                /*0x14*/ int in_progress;
                /*0x18*/ System.Net.EndPoint remote_ep;
                /*0x20*/ System.Net.Sockets.Socket current_socket;
                /*0x28*/ System.Net.Sockets.Socket <AcceptSocket>k__BackingField;
                /*0x30*/ int <BytesTransferred>k__BackingField;
                /*0x34*/ System.Net.Sockets.SocketError <SocketError>k__BackingField;
                /*0x38*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> Completed;

                /*0x1865928*/ System.Net.Sockets.Socket get_AcceptSocket();
                /*0x1865930*/ void set_AcceptSocket(System.Net.Sockets.Socket value);
                /*0x1865938*/ void set_BytesTransferred(int value);
                /*0x1865940*/ void set_SocketError(System.Net.Sockets.SocketError value);
                /*0x1865948*/ void Dispose(bool disposing);
                /*0x186595c*/ void Dispose();
                /*0x18659cc*/ void Complete();
                /*0x18659dc*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e);
            }

            class SocketAsyncResult : System.IOAsyncResult
            {
                /*0x30*/ System.Net.Sockets.Socket socket;
                /*0x38*/ System.Net.Sockets.SocketOperation operation;
                /*0x40*/ System.Exception DelayedException;
                /*0x48*/ System.Net.EndPoint EndPoint;
                /*0x50*/ byte[] Buffer;
                /*0x58*/ int Offset;
                /*0x5c*/ int Size;
                /*0x60*/ System.Net.Sockets.SocketFlags SockFlags;
                /*0x68*/ System.Net.Sockets.Socket AcceptSocket;
                /*0x70*/ System.Net.IPAddress[] Addresses;
                /*0x78*/ int Port;
                /*0x80*/ System.Collections.Generic.IList<System.ArraySegment<byte>> Buffers;
                /*0x88*/ bool ReuseSocket;
                /*0x8c*/ int CurrentAddress;
                /*0x90*/ System.Net.Sockets.Socket AcceptedSocket;
                /*0x98*/ int Total;
                /*0x9c*/ int error;
                /*0xa0*/ int EndCalled;

                /*0x1862944*/ SocketAsyncResult(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x1862f7c*/ nint get_Handle();
                /*0x1863848*/ System.Net.Sockets.SocketError get_ErrorCode();
                /*0x1861ed8*/ void CheckIfThrowDelayedException();
                /*0x1865a4c*/ void CompleteDisposed();
                /*0x1865a50*/ void Complete();
                /*0x1862f70*/ void Complete(bool synch);
                /*0x1864184*/ void Complete(int total);
                /*0x1862f60*/ void Complete(System.Exception e, bool synch);
                /*0x186417c*/ void Complete(System.Exception e);
                /*0x1865c3c*/ void Complete(System.Net.Sockets.Socket s);
                /*0x1865c44*/ void Complete(System.Net.Sockets.Socket s, int total);

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.SocketAsyncResult.<> <>9;
                    static /*0x8*/ System.Threading.WaitCallback <>9__27_0;

                    static /*0x148a6c4*/ <>c();
                    /*0x148a724*/ <>c();
                    /*0x148a72c*/ void <Complete>b__27_0(object state);
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

            class SocketTaskExtensions
            {
                static /*0x1865e74*/ System.Threading.Tasks.Task ConnectAsync(System.Net.Sockets.Socket socket, System.Net.EndPoint remoteEP);

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.SocketTaskExtensions.<> <>9;
                    static /*0x8*/ System.Func<System.Net.EndPoint, System.AsyncCallback, object, System.IAsyncResult> <>9__2_0;
                    static /*0x10*/ System.Action<System.IAsyncResult> <>9__2_1;

                    static /*0x148a7a0*/ <>c();
                    /*0x148a800*/ <>c();
                    /*0x148a808*/ System.IAsyncResult <ConnectAsync>b__2_0(System.Net.EndPoint targetEndPoint, System.AsyncCallback callback, object state);
                    /*0x148a8ac*/ void <ConnectAsync>b__2_1(System.IAsyncResult asyncResult);
                }
            }
        }

        namespace Security
        {
            class AuthenticatedStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _InnerStream;
                /*0x30*/ bool _LeaveStreamOpen;

                /*0x1cfdac8*/ AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen);
                /*0x1cfdc7c*/ System.IO.Stream get_InnerStream();
                /*0x1cfdc84*/ void Dispose(bool disposing);
                bool get_IsAuthenticated();
            }

            enum AuthenticationLevel
            {
                None = 0,
                MutualAuthRequested = 1,
                MutualAuthRequired = 2,
            }

            class RemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x1859058*/ RemoteCertificateValidationCallback(object object, nint method);
                /*0x18590b8*/ bool Invoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
                /*0x185949c*/ System.IAsyncResult BeginInvoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors, System.AsyncCallback callback, object object);
                /*0x1859548*/ bool EndInvoke(System.IAsyncResult result);
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
                /*0x1cbe510*/ LocalCertSelectionCallback(object object, nint method);
                /*0x1cbe570*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x1cbe950*/ System.IAsyncResult BeginInvoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, System.AsyncCallback callback, object object);
                /*0x1cbe984*/ System.Security.Cryptography.X509Certificates.X509Certificate EndInvoke(System.IAsyncResult result);
            }

            class SslStream : System.Net.Security.AuthenticatedStream
            {
                /*0x38*/ Mono.Security.Interface.MonoTlsProvider provider;
                /*0x40*/ Mono.Security.Interface.IMonoSslStream impl;

                static /*0x18661cc*/ Mono.Security.Interface.IMonoSslStream CreateMonoSslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                /*0x1866154*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                /*0x18660d0*/ Mono.Security.Interface.IMonoSslStream get_Impl();
                /*0x1866260*/ bool get_IsAuthenticated();
                /*0x1866318*/ bool get_CanSeek();
                /*0x1866320*/ bool get_CanRead();
                /*0x18663dc*/ bool get_CanWrite();
                /*0x1866498*/ int get_ReadTimeout();
                /*0x1866550*/ void set_ReadTimeout(int value);
                /*0x1866618*/ int get_WriteTimeout();
                /*0x18666d0*/ long get_Length();
                /*0x1866788*/ long get_Position();
                /*0x1866840*/ void set_Position(long value);
                /*0x1866894*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x18668e8*/ void Flush();
                /*0x18660f4*/ void CheckDisposed();
                /*0x186690c*/ void Dispose(bool disposing);
                /*0x1866a20*/ int Read(byte[] buffer, int offset, int count);
                /*0x1866b00*/ void Write(byte[] buffer, int offset, int count);
                /*0x1866be0*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x1866cd8*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x1866da0*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x1866e98*/ void EndWrite(System.IAsyncResult asyncResult);
            }
        }

        namespace NetworkInformation
        {
            class IPGlobalProperties
            {
                static /*0x0*/ bool <PlatformNeedsLibCWorkaround>k__BackingField;

                static /*0x1cb9880*/ bool get_PlatformNeedsLibCWorkaround();
                static /*0x1cb98cc*/ System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties();
                static /*0x1cb9b00*/ System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties();
                /*0x1cb9b04*/ IPGlobalProperties();
                string get_DomainName();
            }

            class NetworkInformationException : System.ComponentModel.Win32Exception
            {
                /*0x1cc9a5c*/ NetworkInformationException();
                /*0x1cc9b00*/ NetworkInformationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            }

            enum NetworkInterfaceComponent
            {
                IPv4 = 0,
                IPv6 = 1,
            }

            enum NetBiosNodeType
            {
                Unknown = 0,
                Broadcast = 1,
                Peer2Peer = 2,
                Mixed = 4,
                Hybrid = 8,
            }

            class CommonUnixIPGlobalProperties : System.Net.NetworkInformation.IPGlobalProperties
            {
                static /*0x1d085ac*/ int getdomainname(byte[] name, int len);
                /*0x1d087bc*/ CommonUnixIPGlobalProperties();
                /*0x1d08644*/ string get_DomainName();
            }

            class UnixIPGlobalProperties : System.Net.NetworkInformation.CommonUnixIPGlobalProperties
            {
                /*0x29f0c58*/ UnixIPGlobalProperties();
            }

            class UnixNoLibCIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                /*0x29f0cac*/ UnixNoLibCIPGlobalProperties();
                /*0x29f0c60*/ string get_DomainName();
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

                static /*0x1cc20a0*/ MibIPGlobalProperties();
                /*0x1cb999c*/ MibIPGlobalProperties(string procDir);
            }

            class Win32IPGlobalProperties : System.Net.NetworkInformation.IPGlobalProperties
            {
                /*0x170f1dc*/ Win32IPGlobalProperties();
                /*0x170f084*/ string get_DomainName();
            }

            class Win32NetworkInterface
            {
                static /*0x0*/ System.Net.NetworkInformation.Win32_FIXED_INFO fixedInfo;
                static /*0x58*/ bool initialized;

                static /*0x170f1e4*/ int GetNetworkParams(nint ptr, ref int size);
                static /*0x170f0a8*/ System.Net.NetworkInformation.Win32_FIXED_INFO get_FixedInfo();
            }

            struct Win32_FIXED_INFO
            {
                /*0x10*/ string HostName;
                /*0x18*/ string DomainName;
                /*0x20*/ nint CurrentDnsServer;
                /*0x28*/ System.Net.NetworkInformation.Win32_IP_ADDR_STRING DnsServerList;
                /*0x48*/ System.Net.NetworkInformation.NetBiosNodeType NodeType;
                /*0x50*/ string ScopeId;
                /*0x58*/ uint EnableRouting;
                /*0x5c*/ uint EnableProxy;
                /*0x60*/ uint EnableDns;
            }

            struct Win32_IP_ADDR_STRING
            {
                /*0x10*/ nint Next;
                /*0x18*/ string IpAddress;
                /*0x20*/ string IpMask;
                /*0x28*/ uint Context;
            }
        }

        namespace Configuration
        {
            class DefaultProxySectionInternal
            {
                static /*0x0*/ object classSyncObject;
                /*0x10*/ System.Net.IWebProxy webProxy;

                static /*0x17d1774*/ System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode();
                static /*0x17d177c*/ System.Net.IWebProxy GetSystemWebProxy();
                static /*0x17d1784*/ object get_ClassSyncObject();
                static /*0x17d1820*/ System.Net.Configuration.DefaultProxySectionInternal GetSection();
                /*0x17d1938*/ DefaultProxySectionInternal();
                /*0x17d1940*/ System.Net.IWebProxy get_WebProxy();
            }

            class SettingsSectionInternal
            {
                static /*0x0*/ System.Net.Configuration.SettingsSectionInternal instance;
                /*0x10*/ bool HttpListenerUnescapeRequestUrl;
                /*0x14*/ System.Net.Sockets.IPProtectionLevel IPProtectionLevel;

                static /*0x185de20*/ SettingsSectionInternal();
                static /*0x185dd9c*/ System.Net.Configuration.SettingsSectionInternal get_Section();
                /*0x185de08*/ SettingsSectionInternal();
                /*0x185de00*/ bool get_Ipv6Enabled();
            }
        }

        namespace Cache
        {
            class RequestCache
            {
                static /*0x0*/ char[] LineSplits;

                static /*0x1859574*/ RequestCache();
            }

            class RequestCacheValidator
            {
                /*0x1859674*/ object CreateValidator();
            }

            class RequestCacheBinding
            {
                /*0x10*/ System.Net.Cache.RequestCache m_RequestCache;
                /*0x18*/ System.Net.Cache.RequestCacheValidator m_CacheValidator;

                /*0x1859614*/ System.Net.Cache.RequestCache get_Cache();
                /*0x185961c*/ System.Net.Cache.RequestCacheValidator get_Validator();
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

                /*0x1859624*/ System.Net.Cache.RequestCacheLevel get_Level();
            }

            class RequestCacheProtocol
            {
                /*0x185962c*/ RequestCacheProtocol(object arg1, object arg2);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0283A6AF88802AB45989B29549915BEA0F6CD515;
    static /*0x10*/ long 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF;
    static /*0x18*/ <PrivateImplementationDetails> 1A39764B112685485A5BA7B2880D878B858C1A7A;
    static /*0x21*/ <PrivateImplementationDetails> 1A84029C80CB5518379F199F53FF08A7B764F8FD;
    static /*0x24*/ <PrivateImplementationDetails> 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC;
    static /*0x30*/ <PrivateImplementationDetails> 59F5BD34B6C013DEACC784F69C67E95150033A84;
    static /*0x50*/ <PrivateImplementationDetails> 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C;
    static /*0x56*/ <PrivateImplementationDetails> 6D49C9D487D7AD3491ECE08732D68A593CC2038D;
    static /*0x5f*/ <PrivateImplementationDetails> 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E;
    static /*0xdf*/ <PrivateImplementationDetails> 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3;
    static /*0x110*/ long 98A44A6F8606AE6F23FE230286C1D6FBCC407226;
    static /*0x118*/ <PrivateImplementationDetails> C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536;
    static /*0x138*/ <PrivateImplementationDetails> CCEEADA43268372341F81AE0C9208C6856441C04;
    static /*0x1b8*/ long E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78;
    static /*0x1c0*/ <PrivateImplementationDetails> EC5842B3154E1AF94500B57220EB9F684BCCC42A;
    static /*0x1e0*/ <PrivateImplementationDetails> EEAFE8C6E1AB017237567305EE925C976CDB6458;

    static /*0x1cfaa70*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=3
    {
    }

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
                /*0x1d00eb0*/ BypassElementCollection();
            }

            class ConnectionManagementElement : System.Configuration.ConfigurationElement
            {
            }

            class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x1d094f8*/ ConnectionManagementElementCollection();
            }

            class ConnectionManagementSection : System.Configuration.ConfigurationSection
            {
                /*0x1d09534*/ ConnectionManagementSection();
                /*0x1d09570*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class DefaultProxySection : System.Configuration.ConfigurationSection
            {
                /*0x17d16c0*/ DefaultProxySection();
                /*0x17d16fc*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
                /*0x17d1738*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            }

            class ProxyElement : System.Configuration.ConfigurationElement
            {
                /*0x1eb8c58*/ ProxyElement();
                /*0x1eb8c94*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class HttpWebRequestElement : System.Configuration.ConfigurationElement
            {
                /*0x1cb4900*/ HttpWebRequestElement();
                /*0x1cb493c*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class Ipv6Element : System.Configuration.ConfigurationElement
            {
                /*0x1cbc024*/ Ipv6Element();
                /*0x1cbc060*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
            {
                /*0x1cc979c*/ NetSectionGroup();
            }

            class SettingsSection : System.Configuration.ConfigurationSection
            {
                /*0x185dd24*/ SettingsSection();
                /*0x185dd60*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class PerformanceCountersElement : System.Configuration.ConfigurationElement
            {
                /*0x1eb54b4*/ PerformanceCountersElement();
                /*0x1eb54f0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class ServicePointManagerElement : System.Configuration.ConfigurationElement
            {
                /*0x185cfd0*/ ServicePointManagerElement();
                /*0x185d00c*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class SocketElement : System.Configuration.ConfigurationElement
            {
                /*0x1865c50*/ SocketElement();
                /*0x1865c8c*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebProxyScriptElement : System.Configuration.ConfigurationElement
            {
                /*0x1709db8*/ WebProxyScriptElement();
                /*0x1709df4*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModulesSection : System.Configuration.ConfigurationSection
            {
                /*0x170b514*/ WebRequestModulesSection();
                /*0x170b550*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x170b4d8*/ WebRequestModuleElementCollection();
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
            /*0x17d45fc*/ DiagnosticsConfigurationHandler();
            /*0x17d4638*/ object Create(object parent, object configContext, System.Xml.XmlNode section);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x186893c*/ void ThrowNotSupportedException();
    }
}
