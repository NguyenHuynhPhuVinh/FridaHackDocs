class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x78af258*/ EmbeddedAttribute();
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

                /*0x78af260*/ NullableAttribute(byte );
                /*0x78af2e8*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x78af318*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x78af340*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x78af434*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace TMPro
{
    class TMPExtensions
    {
        static /*0x78af43c*/ System.IDisposable OnLinkExit(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78afc48*/ System.IDisposable OnLinkEnter(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78b0374*/ System.IDisposable OnLinkClick(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78b0aa0*/ System.IDisposable OnLinkExit(TMPro.TMP_Text tmp, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78b0d9c*/ System.IDisposable OnLinkEnter(TMPro.TMP_Text tmp, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78b0fb8*/ System.IDisposable OnLinkClick(TMPro.TMP_Text tmp, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78b11d4*/ System.IDisposable OnLinkExit(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78b18fc*/ System.IDisposable OnLinkEnter(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78b2024*/ System.IDisposable OnLinkClick(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78b274c*/ System.IDisposable OnLinkExit(TMPro.TMP_Text tmp, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78b2968*/ System.IDisposable OnLinkEnter(TMPro.TMP_Text tmp, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78b2b84*/ System.IDisposable OnLinkClick(TMPro.TMP_Text tmp, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78b0cbc*/ System.IDisposable CreateIDisposable(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler);
        static /*0x78afb68*/ System.IDisposable CreateIDisposable(System.Collections.Generic.IEnumerable<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> inputHandlers);

        class <>c
        {
            static /*0x0*/ TMPro.TMPExtensions.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_Text, Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> <>9__0_0;
            static /*0x10*/ System.Func<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler, bool> <>9__0_1;
            static /*0x18*/ System.Func<TMPro.TMP_Text, Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> <>9__1_0;
            static /*0x20*/ System.Func<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler, bool> <>9__1_1;
            static /*0x28*/ System.Func<TMPro.TMP_Text, Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> <>9__2_0;
            static /*0x30*/ System.Func<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler, bool> <>9__2_1;
            static /*0x38*/ System.Func<TMPro.TMP_Text, Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> <>9__6_0;
            static /*0x40*/ System.Func<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler, bool> <>9__6_1;
            static /*0x48*/ System.Func<TMPro.TMP_Text, Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> <>9__7_0;
            static /*0x50*/ System.Func<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler, bool> <>9__7_1;
            static /*0x58*/ System.Func<TMPro.TMP_Text, Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> <>9__8_0;
            static /*0x60*/ System.Func<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler, bool> <>9__8_1;

            static /*0x78b2e18*/ <>c();
            /*0x78b2e80*/ <>c();
            /*0x78b2e88*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkExit>b__0_0(TMPro.TMP_Text t);
            /*0x78b2ed8*/ bool <OnLinkExit>b__0_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78b2f34*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkEnter>b__1_0(TMPro.TMP_Text t);
            /*0x78b2f84*/ bool <OnLinkEnter>b__1_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78b2fe0*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkClick>b__2_0(TMPro.TMP_Text t);
            /*0x78b3030*/ bool <OnLinkClick>b__2_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78b308c*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkExit>b__6_0(TMPro.TMP_Text t);
            /*0x78b30dc*/ bool <OnLinkExit>b__6_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78b3138*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkEnter>b__7_0(TMPro.TMP_Text t);
            /*0x78b3188*/ bool <OnLinkEnter>b__7_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78b31e4*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkClick>b__8_0(TMPro.TMP_Text t);
            /*0x78b3234*/ bool <OnLinkClick>b__8_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
        }

        class <>c__DisplayClass0_0
        {
            /*0x10*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;

            /*0x78afb58*/ <>c__DisplayClass0_0();
        }

        class <>c__DisplayClass0_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x20*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78afb60*/ <>c__DisplayClass0_1();
            /*0x78b3290*/ void <OnLinkExit>b__2();

            struct <<OnLinkExit>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78b3344*/ void MoveNext();
                /*0x78b3ab0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass10_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78b2b7c*/ <>c__DisplayClass10_0();
            /*0x78b3abc*/ void <OnLinkEnter>b__0();
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78b2d98*/ <>c__DisplayClass11_0();
            /*0x78b3cc8*/ void <OnLinkClick>b__0();
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78b2da0*/ <>c__DisplayClass12_0();
            /*0x78b3ed4*/ void <CreateIDisposable>b__0();
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> inputHandlers;

            /*0x78b2e10*/ <>c__DisplayClass13_0();
            /*0x78b3f60*/ void <CreateIDisposable>b__0();
        }

        class <>c__DisplayClass1_0
        {
            /*0x10*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;

            /*0x78b0364*/ <>c__DisplayClass1_0();
        }

        class <>c__DisplayClass1_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x20*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78b036c*/ <>c__DisplayClass1_1();
            /*0x78b4290*/ void <OnLinkEnter>b__2();

            struct <<OnLinkEnter>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78b4344*/ void MoveNext();
                /*0x78b48d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;

            /*0x78b0a90*/ <>c__DisplayClass2_0();
        }

        class <>c__DisplayClass2_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x20*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78b0a98*/ <>c__DisplayClass2_1();
            /*0x78b48e0*/ void <OnLinkClick>b__2();

            struct <<OnLinkClick>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78b4994*/ void MoveNext();
                /*0x78b4f24*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78b0cb4*/ <>c__DisplayClass3_0();
            /*0x78b4f30*/ void <OnLinkExit>b__0();

            struct <<OnLinkExit>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78b4fe4*/ void MoveNext();
                /*0x78b5564*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78b0fb0*/ <>c__DisplayClass4_0();
            /*0x78b5570*/ void <OnLinkEnter>b__0();

            struct <<OnLinkEnter>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78b5624*/ void MoveNext();
                /*0x78b5ba4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78b11cc*/ <>c__DisplayClass5_0();
            /*0x78b5bb0*/ void <OnLinkClick>b__0();

            struct <<OnLinkClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78b5c64*/ void MoveNext();
                /*0x78b61e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;

            /*0x78b18ec*/ <>c__DisplayClass6_0();
        }

        class <>c__DisplayClass6_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x18*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78b18f4*/ <>c__DisplayClass6_1();
            /*0x78b61f0*/ void <OnLinkExit>b__2();
        }

        class <>c__DisplayClass7_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;

            /*0x78b2014*/ <>c__DisplayClass7_0();
        }

        class <>c__DisplayClass7_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x18*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78b201c*/ <>c__DisplayClass7_1();
            /*0x78b6418*/ void <OnLinkEnter>b__2();
        }

        class <>c__DisplayClass8_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;

            /*0x78b273c*/ <>c__DisplayClass8_0();
        }

        class <>c__DisplayClass8_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x18*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78b2744*/ <>c__DisplayClass8_1();
            /*0x78b6640*/ void <OnLinkClick>b__2();
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78b2960*/ <>c__DisplayClass9_0();
            /*0x78b6868*/ void <OnLinkExit>b__0();
        }
    }
}

namespace UnityEditor
{
    class SceneViewExtensions
    {
        static /*0x0*/ bool <IsMouseOverSceneView>k__BackingField;

        static /*0x78b6a74*/ bool get_IsMouseOverSceneView();
        static /*0x78b6abc*/ void set_IsMouseOverSceneView(bool value);
    }
}

namespace UnityEngine
{
    class GameObjectExtensions
    {
        static /*0x3907c14*/ void AddContext<T>(UnityEngine.GameObject target, T context);
        static /*0x3907c14*/ T GetContext<T>(UnityEngine.GameObject target);
        static /*0x381cca4*/ bool TryGetContext<T>(UnityEngine.GameObject target, ref T context);
        static /*0x3907c14*/ T FindContext<T>(UnityEngine.GameObject target);
        static /*0x381cca4*/ bool TryFindContext<T>(UnityEngine.GameObject target, ref T context);
    }

    interface IUCSInstance
    {
        /*0x380bb68*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab);
        /*0x380bcbc*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent);
        UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x3907c14*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x3907c14*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x3907c14*/ T Instantiate<T>(T prefab);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
    }

    class UCSMonoBehaviour : UnityEngine.MonoBehaviour, UnityEngine.IUCSInstance
    {
        /*0x20*/ bool <AllowCreateOnMonoBehaviourStart>k__BackingField;
        /*0x28*/ VContainer.Unity.LifetimeScope scope;
        /*0x30*/ System.Threading.CancellationTokenSource cancellationTokenSource;

        /*0x78b7564*/ UCSMonoBehaviour();
        /*0x78b6b0c*/ bool get_AllowCreateOnMonoBehaviourStart();
        /*0x78b6b14*/ void set_AllowCreateOnMonoBehaviourStart(bool value);
        bool AwaitCompletion<TResult>(System.Threading.CancellationToken cancellationToken, ref System.Nullable<Cysharp.Threading.Tasks.UniTask<TResult>> promise);
        /*0x78b6b20*/ Cysharp.Threading.Tasks.UniTask AwaitClosure(System.Threading.CancellationToken cancellationToken);
        /*0x78b6b58*/ VContainer.Unity.IInstaller CreateInstaller();
        /*0x78b6bf0*/ Cysharp.Threading.Tasks.UniTask<bool> Create();
        /*0x78b6c04*/ Cysharp.Threading.Tasks.UniTask Suspend();
        /*0x78b6c5c*/ Cysharp.Threading.Tasks.UniTask Complete();
        /*0x78b6cb4*/ Cysharp.Threading.Tasks.UniTask<bool> Create(object args);
        /*0x3907c14*/ T Instantiate<T>(T prefab);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x78b6ea8*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab);
        /*0x78b7074*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent);
        /*0x78b7134*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x3907c14*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x78b6f5c*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x78b713c*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x78b720c*/ void Start();
        /*0x78b74d0*/ void OnDestroy();
        /*0x78b7574*/ void <Start>b__23_0();

        class ViewInstaller : VContainer.Unity.IInstaller
        {
            /*0x10*/ UnityEngine.UCSMonoBehaviour component;

            /*0x78b6bc0*/ ViewInstaller(UnityEngine.UCSMonoBehaviour component);
            /*0x78b75a4*/ void Install(VContainer.IContainerBuilder builder);
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.UCSMonoBehaviour.<> <>9;
            static /*0x8*/ System.Action<System.Exception> <>9__23_1;

            static /*0x78b7610*/ <>c();
            /*0x78b7678*/ <>c();
            /*0x78b7680*/ void <Start>b__23_1(System.Exception exception);
        }
    }

    class MonoBehaviour<TComponent, TController> : UnityEngine.UCSMonoBehaviour
    {
        /*0x0*/ TController controller;

        /*0x380cb08*/ MonoBehaviour();
        /*0x3907c14*/ TController get_Controller();
        /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
        /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
        /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
        /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask ProcessOnComplete();
        /*0x380b9e8*/ VContainer.Unity.IInstaller CreateInstaller();
        /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> Create();
        Cysharp.Threading.Tasks.UniTask<bool> Create(object args);
        bool AwaitCompletion<TResult>(System.Threading.CancellationToken cancellationToken, ref System.Nullable<Cysharp.Threading.Tasks.UniTask<TResult>> promise);
        /*0x380c9d4*/ Cysharp.Threading.Tasks.UniTask AwaitClosure(System.Threading.CancellationToken cancellationToken);
        /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Suspend();
        /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Complete();

        class ViewInstaller<TComponent, TController> : VContainer.Unity.IInstaller
        {
            /*0x0*/ UnityEngine.MonoBehaviour<TComponent, TController> component;

            /*0x380d83c*/ ViewInstaller(UnityEngine.MonoBehaviour<TComponent, TController> component);
            /*0x380d83c*/ void Install(VContainer.IContainerBuilder builder);
        }

        class <>c__DisplayClass9_0<TComponent, TController>
        {
            /*0x0*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint entryPoint;

            /*0x380cb08*/ <>c__DisplayClass9_0();
            /*0x380b128*/ bool <Create>b__0();
        }

        struct <Create>d__9<TComponent, TController> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
            /*0x0*/ UnityEngine.MonoBehaviour<TComponent, TController> <>4__this;
            /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
            /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

            /*0x380cb08*/ void MoveNext();
            /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class MonoBehaviour<TComponent, TController, TArgs> : UnityEngine.MonoBehaviour<TComponent, TController>
    {
        /*0x0*/ TArgs args;

        /*0x380cb08*/ MonoBehaviour();
        /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(TArgs args);
        /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(TArgs args);
        /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
        /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
        /*0x380b9e8*/ VContainer.Unity.IInstaller CreateInstaller();
        Cysharp.Threading.Tasks.UniTask<bool> Create(object args);

        class ViewInstaller<TComponent, TController, TArgs> : VContainer.Unity.IInstaller
        {
            /*0x0*/ UnityEngine.MonoBehaviour<TComponent, TController, TArgs> component;

            /*0x380d83c*/ ViewInstaller(UnityEngine.MonoBehaviour<TComponent, TController, TArgs> component);
            /*0x380d83c*/ void Install(VContainer.IContainerBuilder builder);
        }
    }

    namespace UI
    {
        class ButtonExtensions
        {
            static /*0x3907c14*/ System.IDisposable CreateIDisposable<T>(T instance);
            static /*0x382eaf0*/ System.IDisposable CreateIDisposable<T>(System.Collections.Generic.IEnumerable<T> instances);
            static /*0x78b76d8*/ System.IDisposable CreateIDisposable(UnityEngine.UI.Button button);
            static /*0x78b77c0*/ System.IDisposable CreateIDisposable(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons);
            static /*0x3907c14*/ System.IDisposable OnClick<T>(T instance, UnityEngine.Events.UnityAction action);
            static /*0x78b78a8*/ System.IDisposable OnClick(UnityEngine.UI.Button button, UnityEngine.Events.UnityAction action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, UnityEngine.Events.UnityAction action);
            static /*0x78b7a4c*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, UnityEngine.Events.UnityAction action);
            static /*0x3907c14*/ System.IDisposable OnClick<T>(T instance, System.Action<T> action);
            static /*0x78b7f44*/ System.IDisposable OnClick(UnityEngine.UI.Button button, System.Action<UnityEngine.UI.Button> action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, System.Action<T> action);
            static /*0x78b8108*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Action<UnityEngine.UI.Button> action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(UnityEngine.UI.Button button, System.Action<T> action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Action<T> action);
            static /*0x3907c14*/ System.IDisposable OnClick<T>(T instance, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78b8670*/ System.IDisposable OnClick(UnityEngine.UI.Button button, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78b8814*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x3907c14*/ System.IDisposable OnClick<T>(T instance, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78b8d0c*/ System.IDisposable OnClick(UnityEngine.UI.Button button, System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78b8ed0*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(UnityEngine.UI.Button button, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x3830700*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);

            class <>c__DisplayClass0_0<T>
            {
                /*0x0*/ T instance;

                /*0x380cb08*/ <>c__DisplayClass0_0();
                /*0x380cb08*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass10_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;

                /*0x380cb08*/ <>c__DisplayClass10_0();
            }

            class <>c__DisplayClass10_<T>
            {
                /*0x0*/ T instance;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass10_0<T> CS$<>8__locals1;

                /*0x380cb08*/ <>c__DisplayClass10_();
                /*0x380cb08*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Action<UnityEngine.UI.Button> action;

                /*0x78b8660*/ <>c__DisplayClass11_0();
            }

            class <>c__DisplayClass11_1
            {
                /*0x10*/ UnityEngine.UI.Button button;
                /*0x18*/ UnityEngine.UI.ButtonExtensions.<> CS$<>8__locals1;

                /*0x78b8668*/ <>c__DisplayClass11_1();
                /*0x78b9438*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass12_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;
                /*0x0*/ UnityEngine.UI.Button button;

                /*0x380cb08*/ <>c__DisplayClass12_0();
                /*0x380cb08*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass13_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;

                /*0x380cb08*/ <>c__DisplayClass13_0();
            }

            class <>c__DisplayClass13_<T>
            {
                /*0x0*/ UnityEngine.UI.Button button;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass13_0<T> CS$<>8__locals1;

                /*0x380cb08*/ <>c__DisplayClass13_();
                /*0x380cb08*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass14_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;

                /*0x380cb08*/ <>c__DisplayClass14_0();
                /*0x380cb08*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass14_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;

                /*0x78b880c*/ <>c__DisplayClass15_0();
                /*0x78b9628*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78b96dc*/ void MoveNext();
                    /*0x78b9c28*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass16_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;
                /*0x0*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x380cb08*/ <>c__DisplayClass16_0();
                /*0x380cb08*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass16_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;
                /*0x20*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x78b8d04*/ <>c__DisplayClass17_0();
                /*0x78b9c34*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78b9ce8*/ void MoveNext();
                    /*0x78ba234*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass18_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;
                /*0x0*/ T instance;

                /*0x380cb08*/ <>c__DisplayClass18_0();
                /*0x380cb08*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass18_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action;
                /*0x20*/ UnityEngine.UI.Button button;

                /*0x78b8ec8*/ <>c__DisplayClass19_0();
                /*0x78ba240*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78ba2f4*/ void MoveNext();
                    /*0x78ba844*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass1_0<T>
            {
                /*0x0*/ System.Collections.Generic.IEnumerable<T> instances;

                /*0x380cb08*/ <>c__DisplayClass1_0();
                /*0x380cb08*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass20_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;

                /*0x380cb08*/ <>c__DisplayClass20_0();
            }

            class <>c__DisplayClass20_<T>
            {
                /*0x0*/ T instance;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass20_0<T> CS$<>8__locals1;

                /*0x380cb08*/ <>c__DisplayClass20_();
                /*0x380cb08*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass20_1<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action;

                /*0x78b9428*/ <>c__DisplayClass21_0();
            }

            class <>c__DisplayClass21_1
            {
                /*0x10*/ UnityEngine.UI.Button button;
                /*0x18*/ UnityEngine.UI.ButtonExtensions.<> CS$<>8__locals1;

                /*0x78b9430*/ <>c__DisplayClass21_1();
                /*0x78ba850*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78ba904*/ void MoveNext();
                    /*0x78bae74*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass22_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;
                /*0x0*/ UnityEngine.UI.Button button;

                /*0x380cb08*/ <>c__DisplayClass22_0();
                /*0x380cb08*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass22_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass23_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;

                /*0x380cb08*/ <>c__DisplayClass23_0();
            }

            class <>c__DisplayClass23_<T>
            {
                /*0x0*/ UnityEngine.UI.Button button;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass23_0<T> CS$<>8__locals1;

                /*0x380cb08*/ <>c__DisplayClass23_();
                /*0x380cb08*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass23_1<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Button button;

                /*0x78b77b8*/ <>c__DisplayClass2_0();
                /*0x78bae80*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons;

                /*0x78b78a0*/ <>c__DisplayClass3_0();
                /*0x78baf0c*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass4_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ UnityEngine.Events.UnityAction action;

                /*0x380cb08*/ <>c__DisplayClass4_0();
                /*0x380cb08*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ UnityEngine.Events.UnityAction action;

                /*0x78b7a44*/ <>c__DisplayClass5_0();
                /*0x78bb23c*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass6_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ UnityEngine.Events.UnityAction action;
                /*0x0*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x380cb08*/ <>c__DisplayClass6_0();
                /*0x380cb08*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ UnityEngine.Events.UnityAction action;
                /*0x20*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x78b7f3c*/ <>c__DisplayClass7_0();
                /*0x78bb40c*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass8_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;
                /*0x0*/ T instance;

                /*0x380cb08*/ <>c__DisplayClass8_0();
                /*0x380cb08*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Action<UnityEngine.UI.Button> action;
                /*0x20*/ UnityEngine.UI.Button button;

                /*0x78b8100*/ <>c__DisplayClass9_0();
                /*0x78bb5dc*/ void <OnClick>b__0();
            }
        }

        interface IClickable
        {
            /*0x380b9e8*/ UnityEngine.UI.Button get_Button();
        }
    }
}

namespace Assets
{
    namespace UiComponentSystem
    {
        namespace Runtime
        {
            class MonoBehaviourInjectableAttribute : System.Attribute
            {
                /*0x78bb7b0*/ MonoBehaviourInjectableAttribute();
            }

            class ControllerInjectionForbiddenAttribute : System.Attribute
            {
                /*0x78bb7b8*/ ControllerInjectionForbiddenAttribute();
            }

            class Context : UnityEngine.MonoBehaviour
            {
                /*0x20*/ object context;
                /*0x28*/ System.Type type;

                static /*0x78bb7c8*/ bool op_Equality(Assets.UiComponentSystem.Runtime.Context context, System.Type type);
                static /*0x78bb848*/ bool op_Inequality(Assets.UiComponentSystem.Runtime.Context context, System.Type type);
                /*0x78bba24*/ Context();
                /*0x3907c14*/ void Add<T>(T context);
                /*0x3907c14*/ T Get<T>();
                /*0x78bb7c0*/ System.Type GetContextType();
                /*0x78bb8c8*/ bool Equals(object obj);
                /*0x78bb99c*/ int GetHashCode();
            }

            class Controller : System.IDisposable
            {
                /*0x10*/ UniRx.CompositeDisposable compositeDisposable;
                /*0x18*/ System.Collections.Generic.Stack<Cysharp.Threading.Tasks.UniTaskCompletionSource> promises;

                /*0x78bbc14*/ Controller();
                /*0x78bba2c*/ UniRx.CompositeDisposable get_CompositeDisposable();
                /*0x78bba9c*/ void Close();
                /*0x78bbb08*/ Cysharp.Threading.Tasks.UniTask AwaitClosure(System.Threading.CancellationToken cancellationToken);
                /*0x78bbc00*/ void Dispose();
            }

            class Controller<TResult> : Assets.UiComponentSystem.Runtime.Controller
            {
                /*0x0*/ System.Collections.Generic.Stack<Cysharp.Threading.Tasks.UniTaskCompletionSource<TResult>> promises;

                /*0x380cb08*/ Controller();
                /*0x3907c14*/ void Close(TResult result);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> AwaitCompletion(System.Threading.CancellationToken cancellationToken);
            }

            class Deferred<T>
            {
                /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask<T>> execute;
                /*0x0*/ T value;

                /*0x380d83c*/ Deferred(System.Func<Cysharp.Threading.Tasks.UniTask<T>> execution);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> GetAwaiter();
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> ToUniTask();
                Cysharp.Threading.Tasks.UniTask ContinueWith(System.Action<T> function);
                /*0x380d83c*/ void OnCompleted(System.Action action);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> AttachCancellationToken(System.Threading.CancellationToken token);

                class <>c__DisplayClass2_0<T>
                {
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Deferred<T> <>4__this;
                    /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask<T>> execution;

                    /*0x380cb08*/ <>c__DisplayClass2_0();
                    /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> <.ctor>b__0();

                    struct <<-ctor>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                        /*0x0*/ Assets.UiComponentSystem.Runtime.Deferred.<>c__DisplayClass2_0<T> <>4__this;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                        /*0x380cb08*/ void MoveNext();
                        /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }

            class Disposable
            {
                static /*0x0*/ System.IDisposable Empty;

                static /*0x78bbc4c*/ Disposable();
                static /*0x78b2da8*/ System.IDisposable Create(System.Action disposeAction);

                class EmptyDisposable : System.IDisposable
                {
                    static /*0x0*/ Assets.UiComponentSystem.Runtime.Disposable.EmptyDisposable Disposable;

                    static /*0x78bbcd8*/ EmptyDisposable();
                    /*0x78bbccc*/ EmptyDisposable();
                    /*0x78bbcd4*/ void Dispose();
                }

                class ActionDisposable : System.IDisposable
                {
                    /*0x10*/ System.Action disposeAction;

                    /*0x78bbc1c*/ ActionDisposable(System.Action disposeAction);
                    /*0x78bbd40*/ void Dispose();
                }
            }

            interface IGameNavigator
            {
                /*0x380b9e8*/ System.Action<string> get_NavigationErrorHandler();
                /*0x380d83c*/ void set_NavigationErrorHandler(System.Action<string> value);
                /*0x380b9e8*/ System.Action<System.Exception> get_NavigationExceptionHandler();
                /*0x380d83c*/ void set_NavigationExceptionHandler(System.Action<System.Exception> value);
                /*0x380b6a0*/ int get_InstanceLifetime();
                /*0x380cffc*/ void set_InstanceLifetime(int value);
                /*0x380b6a0*/ int get_InstanceQuantityAllowance();
                /*0x380cffc*/ void set_InstanceQuantityAllowance(int value);
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask MoveBack();
                /*0x380ca18*/ Cysharp.Threading.Tasks.UniTask MoveBack(int passOverAmount);
                Cysharp.Threading.Tasks.UniTask MoveToScene(string key);
                Cysharp.Threading.Tasks.UniTask MoveToScene(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToComponent(string key);
                Cysharp.Threading.Tasks.UniTask MoveToComponent(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x380d83c*/ void ApplyDefaultInTransitions(System.Type[] transitions);
                /*0x380d83c*/ void ApplyDefaultOutTransitions(System.Type[] transitions);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask OpenWindow(string key);
                Cysharp.Threading.Tasks.UniTask OpenWindow(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x380cb08*/ void ClearNavigationStack();
            }

            class GameNavigator : Assets.UiComponentSystem.Runtime.IGameNavigator
            {
                static /*0x0*/ System.Collections.Generic.Stack<System.ValueTuple<Assets.UiComponentSystem.Runtime.NavigationDescription, System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription>>> uiStack;
                static /*0x8*/ System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription> windowStack;
                static /*0x10*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<UnityEngine.GameObject, int>> existingInstances;
                static /*0x18*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> awaitOperationsBuffer;
                static /*0x20*/ object operationLock;
                static /*0x28*/ bool operationInProcess;
                static /*0x30*/ System.Collections.Generic.List<System.Type> inTransitions;
                static /*0x38*/ System.Collections.Generic.List<System.Type> outTransitions;
                static /*0x40*/ string initializationSceneName;
                static /*0x48*/ bool initialSceneLoad;
                /*0x10*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSCameraManager cameraController;
                /*0x18*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSLayoutManager layoutController;
                /*0x20*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider assetProvider;
                /*0x28*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager sceneController;
                /*0x30*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetKeyProvider assetKeyProvider;
                /*0x38*/ System.Action<string> <NavigationErrorHandler>k__BackingField;
                /*0x40*/ System.Action<System.Exception> <NavigationExceptionHandler>k__BackingField;
                /*0x48*/ int <InstanceLifetime>k__BackingField;
                /*0x4c*/ int <InstanceQuantityAllowance>k__BackingField;

                static /*0x78bf0f8*/ GameNavigator();
                static /*0x78bc160*/ void ProcessBeforeSceneLoad();
                static /*0x78b7400*/ Cysharp.Threading.Tasks.UniTask ProcessExternalCreation(UnityEngine.UCSMonoBehaviour component, System.Threading.CancellationToken cancellationToken);
                static /*0x78bcc90*/ Cysharp.Threading.Tasks.UniTask SuspendAndTransitionOut(UnityEngine.GameObject gameObject);
                static /*0x78bdca8*/ Cysharp.Threading.Tasks.UniTask TransitionInAndComplete(UnityEngine.GameObject gameObject);
                static /*0x78be6c4*/ Cysharp.Threading.Tasks.UniTask ProcessInTransition(UnityEngine.GameObject gameObject);
                static /*0x78be774*/ Cysharp.Threading.Tasks.UniTask ProcessOutTransition(UnityEngine.GameObject gameObject);
                static /*0x78be820*/ Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition[] AttachDefaultInTransitions(UnityEngine.GameObject gameObject);
                static /*0x78beb24*/ Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.OutTransition[] AttachDefaultOutTransitions(UnityEngine.GameObject gameObject);
                static Cysharp.Threading.Tasks.UniTask <OpenWindow>g__ProcessTransition|45_0<TResult>(Assets.UiComponentSystem.Runtime.NavigationDescription transitionIn, Assets.UiComponentSystem.Runtime.NavigationDescription transitionOut, bool returning);
                static /*0x78bf36c*/ bool <MoveBack>g__CanBeOpened|51_1(Assets.UiComponentSystem.Runtime.NavigationDescription description);
                static /*0x78bf38c*/ Cysharp.Threading.Tasks.UniTask<bool> <MoveToScene>g__ProcessCreateForInSceneComponents|70_1(UnityEngine.SceneManagement.Scene scene, object args);
                static /*0x78bf478*/ Cysharp.Threading.Tasks.UniTask<bool> <MoveToScene>g__ProcessSuspendForInSceneComponents|70_4(UnityEngine.SceneManagement.Scene scene);
                /*0x78bbdbc*/ GameNavigator(Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSCameraManager cameraController, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSLayoutManager layoutController, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider assetProvider, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetKeyProvider assetKeyProvider, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager sceneController);
                /*0x78bbd7c*/ System.Action<string> get_NavigationErrorHandler();
                /*0x78bbd84*/ void set_NavigationErrorHandler(System.Action<string> value);
                /*0x78bbd8c*/ System.Action<System.Exception> get_NavigationExceptionHandler();
                /*0x78bbd94*/ void set_NavigationExceptionHandler(System.Action<System.Exception> value);
                /*0x78bbd9c*/ int get_InstanceLifetime();
                /*0x78bbda4*/ void set_InstanceLifetime(int value);
                /*0x78bbdac*/ int get_InstanceQuantityAllowance();
                /*0x78bbdb4*/ void set_InstanceQuantityAllowance(int value);
                /*0x78bc344*/ void ClearNavigationStack();
                /*0x78bc558*/ void TryRewindStackToComponent(string key);
                /*0x78bcd3c*/ void TryRewindStackToScene(string key);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78bd050*/ Cysharp.Threading.Tasks.UniTask OpenWindow(string key);
                /*0x78bd0e4*/ Cysharp.Threading.Tasks.UniTask OpenWindow(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78bd17c*/ Cysharp.Threading.Tasks.UniTask AwaitAnyProcessingOperations();
                /*0x78bd20c*/ void RegisterOperation();
                /*0x78bd268*/ void CompleteOperation();
                /*0x78bd2c0*/ void CloseWindowStack();
                /*0x78bd480*/ Cysharp.Threading.Tasks.UniTask MoveBack();
                /*0x78bd488*/ Cysharp.Threading.Tasks.UniTask MoveBack(int passOverAmount);
                /*0x78bd540*/ void AgeExistingInstances();
                /*0x78bdbd8*/ Cysharp.Threading.Tasks.UniTask Close(Assets.UiComponentSystem.Runtime.NavigationDescription description);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                /*0x78bdd54*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78bde60*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(string key);
                /*0x78bde70*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(Assets.UiComponentSystem.Runtime.NavigationDescription description, bool moveBack);
                /*0x78bdd64*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(string key, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags, bool moveBack);
                /*0x78be0a8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> AcquireInstance(string key, UnityEngine.Transform parent);
                /*0x78be1e0*/ UnityEngine.Transform AcquireTargetParent(Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags, bool asWindow);
                /*0x78be354*/ Cysharp.Threading.Tasks.UniTask ProcessTransitionToComponent(Assets.UiComponentSystem.Runtime.NavigationDescription activeDescription, Assets.UiComponentSystem.Runtime.NavigationDescription targetDescription, bool isMovingBack);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TElement>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TElement> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TElement>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TElement> args);
                /*0x78be44c*/ Cysharp.Threading.Tasks.UniTask MoveToScene(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78be614*/ Cysharp.Threading.Tasks.UniTask MoveToScene(string key);
                /*0x78be6a0*/ Cysharp.Threading.Tasks.UniTask MoveToScene(Assets.UiComponentSystem.Runtime.NavigationDescription description, System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription> sceneStack, System.Func<Cysharp.Threading.Tasks.UniTask<bool>> onProcessTransition);
                /*0x78be4e4*/ Cysharp.Threading.Tasks.UniTask MoveToScene(string key, System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription> sceneStack, System.Func<Cysharp.Threading.Tasks.UniTask<bool>> onProcessTransition, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78bee28*/ Cysharp.Threading.Tasks.UniTask AwaitForOperationsBuffer();
                /*0x78beeb8*/ void ApplyDefaultInTransitions(System.Type[] transitions);
                /*0x78befd8*/ void ApplyDefaultOutTransitions(System.Type[] transitions);

                enum Flags
                {
                    None = 0,
                    DoNotCloseExisting = 1,
                    DoNotTransitionBeforeConfirmation = 2,
                    DoNotTransitionBeforeExistingClosure = 4,
                    DoNotReturnTo = 8,
                    Preserve = 16,
                    ForceOverlayLayer = 32,
                    ForceSystemLayer = 64,
                }

                struct DummyReturnType
                {
                }

                struct <<MoveToScene>g__ProcessCreateForInSceneComponents|70_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ UnityEngine.SceneManagement.Scene scene;
                    /*0x38*/ object args;
                    /*0x40*/ UnityEngine.GameObject[] <>7__wrap1;
                    /*0x48*/ int <>7__wrap2;
                    /*0x50*/ UnityEngine.GameObject <item>5__4;
                    /*0x58*/ UnityEngine.UCSMonoBehaviour <component>5__5;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x78bf544*/ void MoveNext();
                    /*0x78bfdf0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<MoveToScene>g__ProcessSuspendForInSceneComponents|70_4>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ UnityEngine.SceneManagement.Scene scene;
                    /*0x38*/ UnityEngine.GameObject[] <>7__wrap1;
                    /*0x40*/ int <>7__wrap2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78bfe48*/ void MoveNext();
                    /*0x78c03b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<OpenWindow>g__ProcessTransition|45_0>d<TResult> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.NavigationDescription transitionIn;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.NavigationDescription transitionOut;
                    /*0x0*/ bool returning;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c
                {
                    static /*0x0*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>9;
                    static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> <>9__32_0;
                    static /*0x10*/ System.Func<bool> <>9__46_0;
                    static /*0x18*/ System.Func<Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition, Cysharp.Threading.Tasks.UniTask> <>9__71_0;
                    static /*0x20*/ System.Func<Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.OutTransition, Cysharp.Threading.Tasks.UniTask> <>9__72_0;

                    static /*0x78c0410*/ <>c();
                    /*0x78c0478*/ <>c();
                    /*0x78c0480*/ void <ProcessBeforeSceneLoad>b__32_0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode _);
                    /*0x78c0588*/ bool <AwaitAnyProcessingOperations>b__46_0();
                    /*0x78c05e0*/ Cysharp.Threading.Tasks.UniTask <ProcessInTransition>b__71_0(Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition t);
                    /*0x78c0604*/ Cysharp.Threading.Tasks.UniTask <ProcessOutTransition>b__72_0(Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.OutTransition t);
                }

                class <>c__DisplayClass36_0
                {
                    /*0x10*/ UnityEngine.UCSMonoBehaviour component;

                    /*0x78c0628*/ <>c__DisplayClass36_0();
                    /*0x78c0630*/ Cysharp.Threading.Tasks.UniTask <ProcessExternalCreation>g__Process|0();

                    struct <<ProcessExternalCreation>g__Process|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                        /*0x78c06dc*/ void MoveNext();
                        /*0x78c0e54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass51_0
                {
                    /*0x10*/ Assets.UiComponentSystem.Runtime.NavigationDescription activeDescription;
                    /*0x18*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x20*/ Assets.UiComponentSystem.Runtime.NavigationDescription targetDescription;

                    /*0x78c0e60*/ <>c__DisplayClass51_0();
                    /*0x78c0e68*/ Cysharp.Threading.Tasks.UniTask<bool> <MoveBack>b__0();

                    struct <<MoveBack>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                        /*0x30*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x78c0f44*/ void MoveNext();
                        /*0x78c1628*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass70_0
                {
                    /*0x10*/ System.Func<Cysharp.Threading.Tasks.UniTask<bool>> onProcessTransition;
                    /*0x18*/ object args;
                    /*0x20*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x28*/ string key;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags;
                    /*0x38*/ System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription> sceneStack;

                    /*0x78c1680*/ <>c__DisplayClass70_0();
                    /*0x78c1688*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>b__0();
                    /*0x78c173c*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>g__ProcessTransitionToScene|2(System.Func<Cysharp.Threading.Tasks.UniTask> loadingOperation);
                    /*0x78c180c*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>g__HideSceneStack|3(UnityEngine.SceneManagement.Scene scene);

                    struct <<MoveToScene>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult <result>5__2;
                        /*0x38*/ int <i>5__3;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                        /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> <>u__2;
                        /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__3;

                        /*0x78c18c4*/ void MoveNext();
                        /*0x78c28d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MoveToScene>g__HideSceneStack|3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ UnityEngine.SceneManagement.Scene scene;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x78c28e0*/ void MoveNext();
                        /*0x78c3448*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MoveToScene>g__ProcessTransitionToScene|2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ System.Func<Cysharp.Threading.Tasks.UniTask> loadingOperation;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x78c3454*/ void MoveNext();
                        /*0x78c3d9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass70_1
                {
                    /*0x10*/ UnityEngine.SceneManagement.Scene scene;
                    /*0x14*/ bool requestMoveBack;
                    /*0x18*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> CS$<>8__locals1;

                    /*0x78c3da8*/ <>c__DisplayClass70_1();
                    /*0x78c3db0*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>b__5();
                    /*0x78c3e5c*/ bool <MoveToScene>b__6(bool value);
                    /*0x78c3e70*/ bool <MoveToScene>b__7(bool value);

                    struct <<MoveToScene>b__5>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__2;

                        /*0x78c3e84*/ void MoveNext();
                        /*0x78c47c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                struct <AcquireInstance>d__62 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                    /*0x30*/ string key;
                    /*0x38*/ UnityEngine.Transform parent;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x78c47d0*/ void MoveNext();
                    /*0x78c500c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <AwaitAnyProcessingOperations>d__46 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78c5064*/ void MoveNext();
                    /*0x78c555c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <AwaitForOperationsBuffer>d__75 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78c5568*/ void MoveNext();
                    /*0x78c5b28*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Close>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.UiComponentSystem.Runtime.NavigationDescription description;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78c5b34*/ void MoveNext();
                    /*0x78c6674*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveBack>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>8__1;
                    /*0x38*/ int passOverAmount;
                    /*0x40*/ System.ValueTuple<Assets.UiComponentSystem.Runtime.NavigationDescription, System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription>> <targetStack>5__2;
                    /*0x50*/ Assets.UiComponentSystem.Runtime.NavigationDescription <targetSceneDescription>5__3;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x68*/ UnityEngine.UCSMonoBehaviour <component>5__4;
                    /*0x70*/ Assets.UiComponentSystem.Runtime.NavigationDescription <>7__wrap4;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__2;
                    /*0x90*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__3;

                    /*0x78c6680*/ void MoveNext();
                    /*0x78c8a44*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveToComponent>d__61 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags;
                    /*0x38*/ string key;
                    /*0x40*/ object args;
                    /*0x48*/ bool moveBack;
                    /*0x50*/ Assets.UiComponentSystem.Runtime.NavigationDescription <description>5__2;
                    /*0x58*/ UnityEngine.UCSMonoBehaviour <component>5__3;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x70*/ Assets.UiComponentSystem.Runtime.NavigationDescription <>7__wrap3;
                    /*0x78*/ Assets.UiComponentSystem.Runtime.NavigationDescription <>7__wrap4;
                    /*0x80*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__2;
                    /*0x98*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__3;

                    /*0x78c8a50*/ void MoveNext();
                    /*0x78c9f38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveToScene>d__70 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ System.Func<Cysharp.Threading.Tasks.UniTask<bool>> onProcessTransition;
                    /*0x30*/ object args;
                    /*0x38*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x40*/ string key;
                    /*0x48*/ Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags;
                    /*0x50*/ System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription> sceneStack;
                    /*0x58*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>8__1;
                    /*0x60*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>8__2;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78c9f44*/ void MoveNext();
                    /*0x78cba7c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <OpenWindow>d__45<TResult> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<TResult> <>t__builder;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x0*/ string key;
                    /*0x0*/ object args;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.NavigationDescription <description>5__2;
                    /*0x0*/ UnityEngine.UCSMonoBehaviour <component>5__3;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.NavigationDescription <existingWindow>5__4;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__3;
                    /*0x0*/ object <>7__wrap4;
                    /*0x0*/ int <>7__wrap5;
                    /*0x0*/ TResult <>7__wrap6;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<TResult> <>u__4;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessExternalCreation>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.UCSMonoBehaviour component;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78cba88*/ void MoveNext();
                    /*0x78cbef4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessInTransition>d__71 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition[] <transitions>5__2;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78cbf00*/ void MoveNext();
                    /*0x78cc738*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessOutTransition>d__72 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78cc744*/ void MoveNext();
                    /*0x78ccd28*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessTransitionToComponent>d__64 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.UiComponentSystem.Runtime.NavigationDescription targetDescription;
                    /*0x30*/ bool isMovingBack;
                    /*0x38*/ Assets.UiComponentSystem.Runtime.NavigationDescription activeDescription;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78ccd34*/ void MoveNext();
                    /*0x78ce72c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SuspendAndTransitionOut>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78ce738*/ void MoveNext();
                    /*0x78cedd4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionInAndComplete>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78cede0*/ void MoveNext();
                    /*0x78cf47c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IArgsOf<T>
            {
            }

            interface IArgsOf<T1, T2>
            {
            }

            class Lock : System.IDisposable
            {
                static /*0x0*/ Assets.UiComponentSystem.Runtime.Lock CouldNotAcquireLock;
                static /*0x8*/ object lockObject;
                static /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes lockedScopes;
                static /*0x14*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes <ActiveScope>k__BackingField;
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes <Scope>k__BackingField;
                /*0x14*/ bool <IsAcquired>k__BackingField;
                /*0x15*/ bool <IsDisposed>k__BackingField;

                static /*0x78cf760*/ Lock();
                static /*0x78cf488*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes get_ActiveScope();
                static /*0x78cf4e0*/ void set_ActiveScope(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes value);
                static /*0x78b38d4*/ Assets.UiComponentSystem.Runtime.Lock TryAcquire(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope);
                static /*0x78cf57c*/ void Unlock(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes type);
                static /*0x78b3a98*/ bool op_Implicit(Assets.UiComponentSystem.Runtime.Lock lock);
                /*0x78cf574*/ Lock();
                /*0x78cf53c*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes get_Scope();
                /*0x78cf544*/ void set_Scope(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes value);
                /*0x78cf54c*/ bool get_IsAcquired();
                /*0x78cf554*/ void set_IsAcquired(bool value);
                /*0x78cf560*/ bool get_IsDisposed();
                /*0x78cf568*/ void set_IsDisposed(bool value);
                /*0x78cf5e0*/ void Dispose();

                enum ScopeTypes
                {
                    None = 0,
                    Component = 1,
                    Window = 2,
                }
            }

            class NavigationDescription
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.NavigationDescription.Types <Type>k__BackingField;
                /*0x18*/ string <Key>k__BackingField;
                /*0x20*/ Assets.UiComponentSystem.Runtime.GameNavigator.Flags <Flags>k__BackingField;
                /*0x28*/ object <Args>k__BackingField;
                /*0x30*/ UnityEngine.Transform <Parent>k__BackingField;
                /*0x38*/ UnityEngine.GameObject <Instance>k__BackingField;
                /*0x40*/ string <SceneInstanceName>k__BackingField;
                /*0x48*/ System.Threading.CancellationTokenSource <CancellationTokenSource>k__BackingField;

                /*0x78bc100*/ NavigationDescription(string key, Assets.UiComponentSystem.Runtime.NavigationDescription.Types type, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78cf820*/ Assets.UiComponentSystem.Runtime.NavigationDescription.Types get_Type();
                /*0x78cf828*/ string get_Key();
                /*0x78cf830*/ Assets.UiComponentSystem.Runtime.GameNavigator.Flags get_Flags();
                /*0x78cf838*/ object get_Args();
                /*0x78cf840*/ UnityEngine.Transform get_Parent();
                /*0x78cf848*/ void set_Parent(UnityEngine.Transform value);
                /*0x78cf850*/ UnityEngine.GameObject get_Instance();
                /*0x78cf858*/ void set_Instance(UnityEngine.GameObject value);
                /*0x78cf860*/ string get_SceneInstanceName();
                /*0x78cf868*/ void set_SceneInstanceName(string value);
                /*0x78cf870*/ System.Threading.CancellationTokenSource get_CancellationTokenSource();
                /*0x78cf878*/ void set_CancellationTokenSource(System.Threading.CancellationTokenSource value);

                enum Types
                {
                    Undefined = 0,
                    Scene = 1,
                    Component = 2,
                    Window = 3,
                }
            }

            class RootLifetimeScopeAccessor : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ VContainer.Unity.LifetimeScope instance;

                static /*0x78b6dd4*/ VContainer.Unity.LifetimeScope AcquireScope();
                /*0x78cf900*/ RootLifetimeScopeAccessor();
                /*0x78cf880*/ void Awake();
            }

            namespace ExternalInterfaces
            {
                interface IUCSAssetKeyProvider
                {
                    /*0x380bb68*/ string AcquireSceneKey(string sceneName);
                    /*0x380bb68*/ string AcquireKey(string key);
                    /*0x380bb68*/ string SceneKeyToSceneName(string key);
                }

                interface IUCSAssetProvider
                {
                    Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform, bool active);
                    /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key);
                }

                interface IUCSCameraManager
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                }

                interface IUCSEntryPoint
                {
                    /*0x380b128*/ bool get_IsEntryInitializationCompleted();
                    /*0x380cdf0*/ void set_IsEntryInitializationCompleted(bool value);
                }

                interface IUCSLayoutManager
                {
                    /*0x380b9e8*/ UnityEngine.Transform get_Foreground();
                    /*0x380b9e8*/ UnityEngine.Transform get_Overlay();
                    /*0x380b9e8*/ UnityEngine.Transform get_System();
                }

                interface IUCSSceneManager
                {
                    Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> MoveToSceneAcync(string key);

                    class LoadSceneResult
                    {
                        /*0x10*/ bool <Succeeded>k__BackingField;
                        /*0x14*/ System.Nullable<UnityEngine.SceneManagement.Scene> <Scene>k__BackingField;

                        /*0x78cf918*/ LoadSceneResult(bool succeeded, System.Nullable<UnityEngine.SceneManagement.Scene> scene);
                        /*0x78cf908*/ bool get_Succeeded();
                        /*0x78cf910*/ System.Nullable<UnityEngine.SceneManagement.Scene> get_Scene();
                    }
                }
            }

            namespace ExternalAbstractClasses
            {
                class InTransition : UnityEngine.MonoBehaviour
                {
                    static float DefaultDuration = 0.10000000149011612;

                    /*0x78cf954*/ InTransition();
                    /*0x380cb08*/ void Kill();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Playback();
                    /*0x380cb08*/ void Prepare();
                    /*0x78cf948*/ void OnDestroy();
                }

                class OutTransition : UnityEngine.MonoBehaviour
                {
                    static float DefaultDuration = 0.10000000149011612;

                    /*0x78cf968*/ OutTransition();
                    /*0x380cb08*/ void Kill();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Playback();
                    /*0x380cb08*/ void Prepare();
                    /*0x78cf95c*/ void OnDestroy();
                }
            }

            namespace Extensions
            {
                namespace TMP
                {
                    class TMPInputHandler : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerMoveHandler
                    {
                        /*0x20*/ bool <Interactable>k__BackingField;
                        /*0x28*/ UnityEngine.Events.UnityEvent <OnLinkClick>k__BackingField;
                        /*0x30*/ UnityEngine.Events.UnityEvent <OnLinkEnter>k__BackingField;
                        /*0x38*/ UnityEngine.Events.UnityEvent <OnLinkExit>k__BackingField;
                        /*0x40*/ TMPro.TMP_LinkInfo <LinkInfo>k__BackingField;
                        /*0x68*/ TMPro.TMP_Text text;
                        /*0x70*/ int hoverIndex;
                        /*0x74*/ int linkInfoIndex;

                        /*0x78cfd9c*/ TMPInputHandler();
                        /*0x78cf970*/ bool get_Interactable();
                        /*0x78cf978*/ void set_Interactable(bool value);
                        /*0x78cf984*/ UnityEngine.Events.UnityEvent get_OnLinkClick();
                        /*0x78cf98c*/ void set_OnLinkClick(UnityEngine.Events.UnityEvent value);
                        /*0x78cf994*/ UnityEngine.Events.UnityEvent get_OnLinkEnter();
                        /*0x78cf99c*/ void set_OnLinkEnter(UnityEngine.Events.UnityEvent value);
                        /*0x78cf9a4*/ UnityEngine.Events.UnityEvent get_OnLinkExit();
                        /*0x78cf9ac*/ void set_OnLinkExit(UnityEngine.Events.UnityEvent value);
                        /*0x78cf9b4*/ TMPro.TMP_LinkInfo get_LinkInfo();
                        /*0x78cf9c8*/ void set_LinkInfo(TMPro.TMP_LinkInfo value);
                        /*0x78cf9e8*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
                        /*0x78cfb04*/ TMPro.TMP_Text AcquireAttachedText();
                        /*0x78cfbac*/ void PopulateLinkInfoData(int index);
                        /*0x78cfc20*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2D342F51355BDA42D8E79CF8D0564250A1EE40C6B409732F134B90E4D399FCAA;
    static /*0x826*/ <PrivateImplementationDetails> 66F537D6627AA227AF5F6A175320524B8535099A8C0FA71F838B456530106A68;

    struct __StaticArrayInitTypeSize=2086
    {
    }

    struct __StaticArrayInitTypeSize=2605
    {
    }
}
