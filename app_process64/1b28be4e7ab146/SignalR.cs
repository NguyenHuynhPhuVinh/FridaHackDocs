class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x737aa50*/ EmbeddedAttribute();
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

                /*0x737aa58*/ NullableAttribute(byte );
                /*0x737aae0*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x737ab10*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x737ab38*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x737ac28*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            static /*0x737ad34*/ ForeverReconnectRetryPolicy();
            /*0x737ad2c*/ ForeverReconnectRetryPolicy();
            /*0x737ac30*/ System.Nullable<System.TimeSpan> GetNextRetryDelay(Best.SignalR.RetryContext context);
        }

        class HeaderAuthenticator : Best.SignalR.IAuthenticationProvider
        {
            /*0x10*/ Best.SignalR.OnAuthenticationSuccededDelegate OnAuthenticationSucceded;
            /*0x18*/ Best.SignalR.OnAuthenticationFailedDelegate OnAuthenticationFailed;
            /*0x20*/ string _credentials;

            /*0x737b0a8*/ HeaderAuthenticator(string credentials);
            /*0x737ae30*/ bool get_IsPreAuthRequired();
            /*0x737ae38*/ void add_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x737aed4*/ void remove_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x737af70*/ void add_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x737b00c*/ void remove_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x737b0d8*/ void StartAuthentication();
            /*0x737b0dc*/ void PrepareRequest(Best.HTTP.HTTPRequest request);
            /*0x737b164*/ System.Uri PrepareUri(System.Uri uri);
            /*0x737b16c*/ void Cancel();
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

            /*0x737b170*/ SignalRHubBase(Assets.SignalR.SignalRHubConfiguration configuration, Best.SignalR.IProtocol messagePackProtocol);
            /*0x737b26c*/ Best.SignalR.HubConnection get_Connection();
            /*0x737b274*/ void set_Connection(Best.SignalR.HubConnection value);
            /*0x737b27c*/ System.Action get_OnDisconnected();
            /*0x737b284*/ System.Action<string> get_OnError();
            /*0x737b28c*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnConnectionFailed();
            /*0x737b294*/ System.Func<string> get_AuthenticationTokenProvider();
            /*0x737b29c*/ System.Action get_OnReconnected();
            /*0x737b2a4*/ void set_OnReconnected(System.Action value);
            /*0x737b2ac*/ System.Uri get_HubUri();
            /*0x737b2b4*/ void set_HubUri(System.Uri value);
            /*0x737b2bc*/ Best.SignalR.IProtocol get_MessagePackProtocol();
            /*0x737b2c4*/ bool get_AllowReconnect();
            /*0x737b2cc*/ Cysharp.Threading.Tasks.UniTaskCompletionSource get_ConnectedTCS();
            /*0x737b2d4*/ void set_ConnectedTCS(Cysharp.Threading.Tasks.UniTaskCompletionSource value);
            /*0x737b2dc*/ Cysharp.Threading.Tasks.UniTask ConnectAsync();
            /*0x737b38c*/ Best.SignalR.HubConnection CreateConnection();
            /*0x737b61c*/ Cysharp.Threading.Tasks.UniTask CloseAsync();
            /*0x737b6cc*/ Cysharp.Threading.Tasks.UniTask<bool> EnsureConnected();
            /*0x38159dc*/ void OnClosed();
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnConnected();
            /*0x737b7a8*/ void <CreateConnection>b__36_0(Best.SignalR.HubConnection _, string error);
            /*0x737b7d4*/ void <CreateConnection>b__36_1(Best.SignalR.HubConnection _);
            /*0x737b804*/ void <CreateConnection>b__36_2(Best.SignalR.HubConnection _, string reason);
            /*0x737b8cc*/ void <CreateConnection>b__36_3(Best.SignalR.HubConnection _);

            struct <CloseAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.SignalR.SignalRHubBase <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Best.SignalR.HubConnection> <>u__2;

                /*0x737b964*/ void MoveNext();
                /*0x737c100*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ConnectAsync>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.SignalR.SignalRHubBase <>4__this;
                /*0x30*/ int <attempt>5__2;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Best.SignalR.HubConnection> <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                /*0x737c10c*/ void MoveNext();
                /*0x737d03c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <EnsureConnected>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.SignalR.SignalRHubBase <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x737d048*/ void MoveNext();
                /*0x737d558*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x737d624*/ SignalRHubConfiguration();
            /*0x737d5b0*/ System.Uri get_HubUri();
            /*0x737d5b8*/ void set_HubUri(System.Uri value);
            /*0x737d5c0*/ System.Action get_OnDisconnected();
            /*0x737d5c8*/ void set_OnDisconnected(System.Action value);
            /*0x737d5d0*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnConnectionFailed();
            /*0x737d5d8*/ void set_OnConnectionFailed(System.Func<Cysharp.Threading.Tasks.UniTask> value);
            /*0x737d5e0*/ System.Func<string> get_AuthenticationTokenProvider();
            /*0x737d5e8*/ void set_AuthenticationTokenProvider(System.Func<string> value);
            /*0x737d5f0*/ System.Action<string> get_OnError();
            /*0x737d5f8*/ void set_OnError(System.Action<string> value);
            /*0x737d600*/ System.Action get_OnReconnected();
            /*0x737d608*/ void set_OnReconnected(System.Action value);
            /*0x737d610*/ bool get_AllowReconnect();
            /*0x737d618*/ void set_AllowReconnect(bool value);
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
