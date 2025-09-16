class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7363620*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x7363628*/ NullableAttribute(byte );
                /*0x73636b0*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x73636e0*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7363708*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x73637f8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Assets
{
    namespace SignalR
    {
        class ForeverReconnectRetryPolicy : Best.SignalR.IRetryPolicy
        {
            static /*0x0*/ System.TimeSpan[] BackoffTimes;

            static /*0x7363904*/ ForeverReconnectRetryPolicy();
            /*0x73638fc*/ ForeverReconnectRetryPolicy();
            /*0x7363800*/ System.Nullable<System.TimeSpan> GetNextRetryDelay(Best.SignalR.RetryContext context);
        }

        class HeaderAuthenticator : Best.SignalR.IAuthenticationProvider
        {
            /*0x10*/ Best.SignalR.OnAuthenticationSuccededDelegate OnAuthenticationSucceded;
            /*0x18*/ Best.SignalR.OnAuthenticationFailedDelegate OnAuthenticationFailed;
            /*0x20*/ string _credentials;

            /*0x7363c78*/ HeaderAuthenticator(string credentials);
            /*0x7363a00*/ bool get_IsPreAuthRequired();
            /*0x7363a08*/ void add_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x7363aa4*/ void remove_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x7363b40*/ void add_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x7363bdc*/ void remove_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x7363ca8*/ void StartAuthentication();
            /*0x7363cac*/ void PrepareRequest(Best.HTTP.HTTPRequest request);
            /*0x7363d34*/ System.Uri PrepareUri(System.Uri uri);
            /*0x7363d3c*/ void Cancel();
        }

        class SignalRHubBase
        {
            /*0x10*/ Best.SignalR.HubConnection <Connection>k__BackingField;
            /*0x18*/ System.Action <OnDisconnected>k__BackingField;
            /*0x20*/ System.Action<string> <OnError>k__BackingField;
            /*0x28*/ System.Func<Cysharp.Threading.Tasks.UniTask> <OnConnectionFailed>k__BackingField;
            /*0x30*/ System.Func<string> <AuthenticationTokenProvider>k__BackingField;
            /*0x38*/ System.Action <OnReconnected>k__BackingField;
            /*0x40*/ System.Uri <HubUri>k__BackingField;
            /*0x48*/ Best.SignalR.IProtocol <MessagePackProtocol>k__BackingField;
            /*0x50*/ bool <AllowReconnect>k__BackingField;
            /*0x58*/ Cysharp.Threading.Tasks.UniTaskCompletionSource <ConnectedTCS>k__BackingField;

            /*0x7363d40*/ SignalRHubBase(Assets.SignalR.SignalRHubConfiguration configuration, Best.SignalR.IProtocol messagePackProtocol);
            /*0x7363e3c*/ Best.SignalR.HubConnection get_Connection();
            /*0x7363e44*/ void set_Connection(Best.SignalR.HubConnection value);
            /*0x7363e4c*/ System.Action get_OnDisconnected();
            /*0x7363e54*/ System.Action<string> get_OnError();
            /*0x7363e5c*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnConnectionFailed();
            /*0x7363e64*/ System.Func<string> get_AuthenticationTokenProvider();
            /*0x7363e6c*/ System.Action get_OnReconnected();
            /*0x7363e74*/ void set_OnReconnected(System.Action value);
            /*0x7363e7c*/ System.Uri get_HubUri();
            /*0x7363e84*/ void set_HubUri(System.Uri value);
            /*0x7363e8c*/ Best.SignalR.IProtocol get_MessagePackProtocol();
            /*0x7363e94*/ bool get_AllowReconnect();
            /*0x7363e9c*/ Cysharp.Threading.Tasks.UniTaskCompletionSource get_ConnectedTCS();
            /*0x7363ea4*/ void set_ConnectedTCS(Cysharp.Threading.Tasks.UniTaskCompletionSource value);
            /*0x7363eac*/ Cysharp.Threading.Tasks.UniTask ConnectAsync();
            /*0x7363f5c*/ Best.SignalR.HubConnection CreateConnection();
            /*0x73641ec*/ Cysharp.Threading.Tasks.UniTask CloseAsync();
            /*0x736429c*/ Cysharp.Threading.Tasks.UniTask<bool> EnsureConnected();
            /*0x380cb08*/ void OnClosed();
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnConnected();
            /*0x7364378*/ void <CreateConnection>b__36_0(Best.SignalR.HubConnection _, string error);
            /*0x73643a4*/ void <CreateConnection>b__36_1(Best.SignalR.HubConnection _);
            /*0x73643d4*/ void <CreateConnection>b__36_2(Best.SignalR.HubConnection _, string reason);
            /*0x736449c*/ void <CreateConnection>b__36_3(Best.SignalR.HubConnection _);

            struct <CloseAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.SignalR.SignalRHubBase <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Best.SignalR.HubConnection> <>u__2;

                /*0x7364534*/ void MoveNext();
                /*0x7364cd0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ConnectAsync>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.SignalR.SignalRHubBase <>4__this;
                /*0x30*/ int <attempt>5__2;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Best.SignalR.HubConnection> <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                /*0x7364cdc*/ void MoveNext();
                /*0x7365c0c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <EnsureConnected>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.SignalR.SignalRHubBase <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x7365c18*/ void MoveNext();
                /*0x7366128*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class SignalRHubConfiguration
        {
            /*0x10*/ System.Uri <HubUri>k__BackingField;
            /*0x18*/ System.Action <OnDisconnected>k__BackingField;
            /*0x20*/ System.Func<Cysharp.Threading.Tasks.UniTask> <OnConnectionFailed>k__BackingField;
            /*0x28*/ System.Func<string> <AuthenticationTokenProvider>k__BackingField;
            /*0x30*/ System.Action<string> <OnError>k__BackingField;
            /*0x38*/ System.Action <OnReconnected>k__BackingField;
            /*0x40*/ bool <AllowReconnect>k__BackingField;

            /*0x73661f4*/ SignalRHubConfiguration();
            /*0x7366180*/ System.Uri get_HubUri();
            /*0x7366188*/ void set_HubUri(System.Uri value);
            /*0x7366190*/ System.Action get_OnDisconnected();
            /*0x7366198*/ void set_OnDisconnected(System.Action value);
            /*0x73661a0*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnConnectionFailed();
            /*0x73661a8*/ void set_OnConnectionFailed(System.Func<Cysharp.Threading.Tasks.UniTask> value);
            /*0x73661b0*/ System.Func<string> get_AuthenticationTokenProvider();
            /*0x73661b8*/ void set_AuthenticationTokenProvider(System.Func<string> value);
            /*0x73661c0*/ System.Action<string> get_OnError();
            /*0x73661c8*/ void set_OnError(System.Action<string> value);
            /*0x73661d0*/ System.Action get_OnReconnected();
            /*0x73661d8*/ void set_OnReconnected(System.Action value);
            /*0x73661e0*/ bool get_AllowReconnect();
            /*0x73661e8*/ void set_AllowReconnect(bool value);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 57249D3E77F4E8AF8BB84180343DD6273F27221ACA18115EB95266696DF67E8A;
    static /*0xbf*/ <PrivateImplementationDetails> 7E332A276023B280E2C3A1031DBFD45245A6078A5D803E9041090AF1E1B32F4C;

    struct __StaticArrayInitTypeSize=163
    {
    }

    struct __StaticArrayInitTypeSize=191
    {
    }
}
