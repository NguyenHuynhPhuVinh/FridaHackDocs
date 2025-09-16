class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x78c6688*/ EmbeddedAttribute();
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

                /*0x78c6690*/ NullableAttribute(byte );
                /*0x78c6718*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x78c6748*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x78c6770*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x78c6864*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        static /*0x78c686c*/ System.IDisposable OnLinkExit(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78c7078*/ System.IDisposable OnLinkEnter(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78c77a4*/ System.IDisposable OnLinkClick(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78c7ed0*/ System.IDisposable OnLinkExit(TMPro.TMP_Text tmp, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78c81cc*/ System.IDisposable OnLinkEnter(TMPro.TMP_Text tmp, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78c83e8*/ System.IDisposable OnLinkClick(TMPro.TMP_Text tmp, System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action);
        static /*0x78c8604*/ System.IDisposable OnLinkExit(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78c8d2c*/ System.IDisposable OnLinkEnter(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78c9454*/ System.IDisposable OnLinkClick(System.Collections.Generic.IEnumerable<TMPro.TMP_Text> tmps, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78c9b7c*/ System.IDisposable OnLinkExit(TMPro.TMP_Text tmp, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78c9d98*/ System.IDisposable OnLinkEnter(TMPro.TMP_Text tmp, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78c9fb4*/ System.IDisposable OnLinkClick(TMPro.TMP_Text tmp, System.Action<TMPro.TMP_LinkInfo> action);
        static /*0x78c80ec*/ System.IDisposable CreateIDisposable(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler);
        static /*0x78c6f98*/ System.IDisposable CreateIDisposable(System.Collections.Generic.IEnumerable<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> inputHandlers);

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

            static /*0x78ca248*/ <>c();
            /*0x78ca2b0*/ <>c();
            /*0x78ca2b8*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkExit>b__0_0(TMPro.TMP_Text t);
            /*0x78ca308*/ bool <OnLinkExit>b__0_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78ca364*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkEnter>b__1_0(TMPro.TMP_Text t);
            /*0x78ca3b4*/ bool <OnLinkEnter>b__1_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78ca410*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkClick>b__2_0(TMPro.TMP_Text t);
            /*0x78ca460*/ bool <OnLinkClick>b__2_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78ca4bc*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkExit>b__6_0(TMPro.TMP_Text t);
            /*0x78ca50c*/ bool <OnLinkExit>b__6_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78ca568*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkEnter>b__7_0(TMPro.TMP_Text t);
            /*0x78ca5b8*/ bool <OnLinkEnter>b__7_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
            /*0x78ca614*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler <OnLinkClick>b__8_0(TMPro.TMP_Text t);
            /*0x78ca664*/ bool <OnLinkClick>b__8_1(Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler i);
        }

        class <>c__DisplayClass0_0
        {
            /*0x10*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;

            /*0x78c6f88*/ <>c__DisplayClass0_0();
        }

        class <>c__DisplayClass0_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x20*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78c6f90*/ <>c__DisplayClass0_1();
            /*0x78ca6c0*/ void <OnLinkExit>b__2();

            struct <<OnLinkExit>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78ca774*/ void MoveNext();
                /*0x78caee0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass10_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78c9fac*/ <>c__DisplayClass10_0();
            /*0x78caeec*/ void <OnLinkEnter>b__0();
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78ca1c8*/ <>c__DisplayClass11_0();
            /*0x78cb0f8*/ void <OnLinkClick>b__0();
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78ca1d0*/ <>c__DisplayClass12_0();
            /*0x78cb304*/ void <CreateIDisposable>b__0();
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler> inputHandlers;

            /*0x78ca240*/ <>c__DisplayClass13_0();
            /*0x78cb390*/ void <CreateIDisposable>b__0();
        }

        class <>c__DisplayClass1_0
        {
            /*0x10*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;

            /*0x78c7794*/ <>c__DisplayClass1_0();
        }

        class <>c__DisplayClass1_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x20*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78c779c*/ <>c__DisplayClass1_1();
            /*0x78cb6c0*/ void <OnLinkEnter>b__2();

            struct <<OnLinkEnter>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78cb774*/ void MoveNext();
                /*0x78cbd04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;

            /*0x78c7ec0*/ <>c__DisplayClass2_0();
        }

        class <>c__DisplayClass2_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x20*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78c7ec8*/ <>c__DisplayClass2_1();
            /*0x78cbd10*/ void <OnLinkClick>b__2();

            struct <<OnLinkClick>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78cbdc4*/ void MoveNext();
                /*0x78cc354*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78c80e4*/ <>c__DisplayClass3_0();
            /*0x78cc360*/ void <OnLinkExit>b__0();

            struct <<OnLinkExit>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78cc414*/ void MoveNext();
                /*0x78cc994*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78c83e0*/ <>c__DisplayClass4_0();
            /*0x78cc9a0*/ void <OnLinkEnter>b__0();

            struct <<OnLinkEnter>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78cca54*/ void MoveNext();
                /*0x78ccfd4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Func<TMPro.TMP_LinkInfo, Cysharp.Threading.Tasks.UniTask> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78c85fc*/ <>c__DisplayClass5_0();
            /*0x78ccfe0*/ void <OnLinkClick>b__0();

            struct <<OnLinkClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ TMPro.TMPExtensions.<> <>4__this;
                /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x78cd094*/ void MoveNext();
                /*0x78cd614*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;

            /*0x78c8d1c*/ <>c__DisplayClass6_0();
        }

        class <>c__DisplayClass6_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x18*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78c8d24*/ <>c__DisplayClass6_1();
            /*0x78cd620*/ void <OnLinkExit>b__2();
        }

        class <>c__DisplayClass7_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;

            /*0x78c9444*/ <>c__DisplayClass7_0();
        }

        class <>c__DisplayClass7_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x18*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78c944c*/ <>c__DisplayClass7_1();
            /*0x78cd848*/ void <OnLinkEnter>b__2();
        }

        class <>c__DisplayClass8_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;

            /*0x78c9b6c*/ <>c__DisplayClass8_0();
        }

        class <>c__DisplayClass8_1
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;
            /*0x18*/ TMPro.TMPExtensions.<> CS$<>8__locals1;

            /*0x78c9b74*/ <>c__DisplayClass8_1();
            /*0x78cda70*/ void <OnLinkClick>b__2();
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
            /*0x18*/ System.Action<TMPro.TMP_LinkInfo> action;
            /*0x20*/ Assets.UiComponentSystem.Runtime.Extensions.TMP.TMPInputHandler inputHandler;

            /*0x78c9d90*/ <>c__DisplayClass9_0();
            /*0x78cdc98*/ void <OnLinkExit>b__0();
        }
    }
}

namespace UnityEditor
{
    class SceneViewExtensions
    {
        static /*0x0*/ bool <IsMouseOverSceneView>k__BackingField;

        static /*0x78cdea4*/ bool get_IsMouseOverSceneView();
        static /*0x78cdeec*/ void set_IsMouseOverSceneView(bool value);
    }
}

namespace UnityEngine
{
    class GameObjectExtensions
    {
        static /*0x3910ae8*/ void AddContext<T>(UnityEngine.GameObject target, T context);
        static /*0x3910ae8*/ T GetContext<T>(UnityEngine.GameObject target);
        static /*0x3825b78*/ bool TryGetContext<T>(UnityEngine.GameObject target, ref T context);
        static /*0x3910ae8*/ T FindContext<T>(UnityEngine.GameObject target);
        static /*0x3825b78*/ bool TryFindContext<T>(UnityEngine.GameObject target, ref T context);
    }

    interface IUCSInstance
    {
        /*0x3814a3c*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab);
        /*0x3814b90*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent);
        UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x3910ae8*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x3910ae8*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x3910ae8*/ T Instantiate<T>(T prefab);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
    }

    class UCSMonoBehaviour : UnityEngine.MonoBehaviour, UnityEngine.IUCSInstance
    {
        /*0x20*/ bool <AllowCreateOnMonoBehaviourStart>k__BackingField;
        /*0x28*/ VContainer.Unity.LifetimeScope scope;
        /*0x30*/ System.Threading.CancellationTokenSource cancellationTokenSource;

        /*0x78ce994*/ UCSMonoBehaviour();
        /*0x78cdf3c*/ bool get_AllowCreateOnMonoBehaviourStart();
        /*0x78cdf44*/ void set_AllowCreateOnMonoBehaviourStart(bool value);
        bool AwaitCompletion<TResult>(System.Threading.CancellationToken cancellationToken, ref System.Nullable<Cysharp.Threading.Tasks.UniTask<TResult>> promise);
        /*0x78cdf50*/ Cysharp.Threading.Tasks.UniTask AwaitClosure(System.Threading.CancellationToken cancellationToken);
        /*0x78cdf88*/ VContainer.Unity.IInstaller CreateInstaller();
        /*0x78ce020*/ Cysharp.Threading.Tasks.UniTask<bool> Create();
        /*0x78ce034*/ Cysharp.Threading.Tasks.UniTask Suspend();
        /*0x78ce08c*/ Cysharp.Threading.Tasks.UniTask Complete();
        /*0x78ce0e4*/ Cysharp.Threading.Tasks.UniTask<bool> Create(object args);
        /*0x3910ae8*/ T Instantiate<T>(T prefab);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x78ce2d8*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab);
        /*0x78ce4a4*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent);
        /*0x78ce564*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x3910ae8*/ T Instantiate<T>(T prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x78ce38c*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x78ce56c*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x78ce63c*/ void Start();
        /*0x78ce900*/ void OnDestroy();
        /*0x78ce9a4*/ void <Start>b__23_0();

        class ViewInstaller : VContainer.Unity.IInstaller
        {
            /*0x10*/ UnityEngine.UCSMonoBehaviour component;

            /*0x78cdff0*/ ViewInstaller(UnityEngine.UCSMonoBehaviour component);
            /*0x78ce9d4*/ void Install(VContainer.IContainerBuilder builder);
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.UCSMonoBehaviour.<> <>9;
            static /*0x8*/ System.Action<System.Exception> <>9__23_1;

            static /*0x78cea40*/ <>c();
            /*0x78ceaa8*/ <>c();
            /*0x78ceab0*/ void <Start>b__23_1(System.Exception exception);
        }
    }

    class MonoBehaviour<TComponent, TController> : UnityEngine.UCSMonoBehaviour
    {
        /*0x0*/ TController controller;

        /*0x38159dc*/ MonoBehaviour();
        /*0x3910ae8*/ TController get_Controller();
        /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
        /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
        /*0x3815874*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
        /*0x3815874*/ Cysharp.Threading.Tasks.UniTask ProcessOnComplete();
        /*0x38148bc*/ VContainer.Unity.IInstaller CreateInstaller();
        /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> Create();
        Cysharp.Threading.Tasks.UniTask<bool> Create(object args);
        bool AwaitCompletion<TResult>(System.Threading.CancellationToken cancellationToken, ref System.Nullable<Cysharp.Threading.Tasks.UniTask<TResult>> promise);
        /*0x38158a8*/ Cysharp.Threading.Tasks.UniTask AwaitClosure(System.Threading.CancellationToken cancellationToken);
        /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Suspend();
        /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Complete();

        class ViewInstaller<TComponent, TController> : VContainer.Unity.IInstaller
        {
            /*0x0*/ UnityEngine.MonoBehaviour<TComponent, TController> component;

            /*0x3816710*/ ViewInstaller(UnityEngine.MonoBehaviour<TComponent, TController> component);
            /*0x3816710*/ void Install(VContainer.IContainerBuilder builder);
        }

        class <>c__DisplayClass9_0<TComponent, TController>
        {
            /*0x0*/ Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint entryPoint;

            /*0x38159dc*/ <>c__DisplayClass9_0();
            /*0x3813ffc*/ bool <Create>b__0();
        }

        struct <Create>d__9<TComponent, TController> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
            /*0x0*/ UnityEngine.MonoBehaviour<TComponent, TController> <>4__this;
            /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
            /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

            /*0x38159dc*/ void MoveNext();
            /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class MonoBehaviour<TComponent, TController, TArgs> : UnityEngine.MonoBehaviour<TComponent, TController>
    {
        /*0x0*/ TArgs args;

        /*0x38159dc*/ MonoBehaviour();
        /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(TArgs args);
        /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(TArgs args);
        /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
        /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
        /*0x38148bc*/ VContainer.Unity.IInstaller CreateInstaller();
        Cysharp.Threading.Tasks.UniTask<bool> Create(object args);

        class ViewInstaller<TComponent, TController, TArgs> : VContainer.Unity.IInstaller
        {
            /*0x0*/ UnityEngine.MonoBehaviour<TComponent, TController, TArgs> component;

            /*0x3816710*/ ViewInstaller(UnityEngine.MonoBehaviour<TComponent, TController, TArgs> component);
            /*0x3816710*/ void Install(VContainer.IContainerBuilder builder);
        }
    }

    namespace UI
    {
        class ButtonExtensions
        {
            static /*0x3910ae8*/ System.IDisposable CreateIDisposable<T>(T instance);
            static /*0x38379c4*/ System.IDisposable CreateIDisposable<T>(System.Collections.Generic.IEnumerable<T> instances);
            static /*0x78ceb08*/ System.IDisposable CreateIDisposable(UnityEngine.UI.Button button);
            static /*0x78cebf0*/ System.IDisposable CreateIDisposable(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons);
            static /*0x3910ae8*/ System.IDisposable OnClick<T>(T instance, UnityEngine.Events.UnityAction action);
            static /*0x78cecd8*/ System.IDisposable OnClick(UnityEngine.UI.Button button, UnityEngine.Events.UnityAction action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, UnityEngine.Events.UnityAction action);
            static /*0x78cee7c*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, UnityEngine.Events.UnityAction action);
            static /*0x3910ae8*/ System.IDisposable OnClick<T>(T instance, System.Action<T> action);
            static /*0x78cf374*/ System.IDisposable OnClick(UnityEngine.UI.Button button, System.Action<UnityEngine.UI.Button> action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, System.Action<T> action);
            static /*0x78cf538*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Action<UnityEngine.UI.Button> action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(UnityEngine.UI.Button button, System.Action<T> action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Action<T> action);
            static /*0x3910ae8*/ System.IDisposable OnClick<T>(T instance, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78cfaa0*/ System.IDisposable OnClick(UnityEngine.UI.Button button, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78cfc44*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Func<Cysharp.Threading.Tasks.UniTask> action);
            static /*0x3910ae8*/ System.IDisposable OnClick<T>(T instance, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78d013c*/ System.IDisposable OnClick(UnityEngine.UI.Button button, System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<T> instances, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x78d0300*/ System.IDisposable OnClick(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(UnityEngine.UI.Button button, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);
            static /*0x38395d4*/ System.IDisposable OnClick<T>(System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons, System.Func<T, Cysharp.Threading.Tasks.UniTask> action);

            class <>c__DisplayClass0_0<T>
            {
                /*0x0*/ T instance;

                /*0x38159dc*/ <>c__DisplayClass0_0();
                /*0x38159dc*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass10_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;

                /*0x38159dc*/ <>c__DisplayClass10_0();
            }

            class <>c__DisplayClass10_<T>
            {
                /*0x0*/ T instance;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass10_0<T> CS$<>8__locals1;

                /*0x38159dc*/ <>c__DisplayClass10_();
                /*0x38159dc*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Action<UnityEngine.UI.Button> action;

                /*0x78cfa90*/ <>c__DisplayClass11_0();
            }

            class <>c__DisplayClass11_1
            {
                /*0x10*/ UnityEngine.UI.Button button;
                /*0x18*/ UnityEngine.UI.ButtonExtensions.<> CS$<>8__locals1;

                /*0x78cfa98*/ <>c__DisplayClass11_1();
                /*0x78d0868*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass12_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;
                /*0x0*/ UnityEngine.UI.Button button;

                /*0x38159dc*/ <>c__DisplayClass12_0();
                /*0x38159dc*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass13_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;

                /*0x38159dc*/ <>c__DisplayClass13_0();
            }

            class <>c__DisplayClass13_<T>
            {
                /*0x0*/ UnityEngine.UI.Button button;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass13_0<T> CS$<>8__locals1;

                /*0x38159dc*/ <>c__DisplayClass13_();
                /*0x38159dc*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass14_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;

                /*0x38159dc*/ <>c__DisplayClass14_0();
                /*0x38159dc*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass14_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;

                /*0x78cfc3c*/ <>c__DisplayClass15_0();
                /*0x78d0a58*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78d0b0c*/ void MoveNext();
                    /*0x78d1058*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass16_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;
                /*0x0*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x38159dc*/ <>c__DisplayClass16_0();
                /*0x38159dc*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass16_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<Cysharp.Threading.Tasks.UniTask> action;
                /*0x20*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x78d0134*/ <>c__DisplayClass17_0();
                /*0x78d1064*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78d1118*/ void MoveNext();
                    /*0x78d1664*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass18_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;
                /*0x0*/ T instance;

                /*0x38159dc*/ <>c__DisplayClass18_0();
                /*0x38159dc*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass18_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action;
                /*0x20*/ UnityEngine.UI.Button button;

                /*0x78d02f8*/ <>c__DisplayClass19_0();
                /*0x78d1670*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78d1724*/ void MoveNext();
                    /*0x78d1c74*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass1_0<T>
            {
                /*0x0*/ System.Collections.Generic.IEnumerable<T> instances;

                /*0x38159dc*/ <>c__DisplayClass1_0();
                /*0x38159dc*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass20_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;

                /*0x38159dc*/ <>c__DisplayClass20_0();
            }

            class <>c__DisplayClass20_<T>
            {
                /*0x0*/ T instance;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass20_0<T> CS$<>8__locals1;

                /*0x38159dc*/ <>c__DisplayClass20_();
                /*0x38159dc*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass20_1<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Func<UnityEngine.UI.Button, Cysharp.Threading.Tasks.UniTask> action;

                /*0x78d0858*/ <>c__DisplayClass21_0();
            }

            class <>c__DisplayClass21_1
            {
                /*0x10*/ UnityEngine.UI.Button button;
                /*0x18*/ UnityEngine.UI.ButtonExtensions.<> CS$<>8__locals1;

                /*0x78d0860*/ <>c__DisplayClass21_1();
                /*0x78d1c80*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.UI.ButtonExtensions.<> <>4__this;
                    /*0x40*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78d1d34*/ void MoveNext();
                    /*0x78d22a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass22_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;
                /*0x0*/ UnityEngine.UI.Button button;

                /*0x38159dc*/ <>c__DisplayClass22_0();
                /*0x38159dc*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass22_0<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass23_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> action;

                /*0x38159dc*/ <>c__DisplayClass23_0();
            }

            class <>c__DisplayClass23_<T>
            {
                /*0x0*/ UnityEngine.UI.Button button;
                /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass23_0<T> CS$<>8__locals1;

                /*0x38159dc*/ <>c__DisplayClass23_();
                /*0x38159dc*/ void <OnClick>b__0();

                struct <<OnClick>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ UnityEngine.UI.ButtonExtensions.<>c__DisplayClass23_1<T> <>4__this;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Lock <locker>5__2;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Button button;

                /*0x78cebe8*/ <>c__DisplayClass2_0();
                /*0x78d22b0*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Button> buttons;

                /*0x78cecd0*/ <>c__DisplayClass3_0();
                /*0x78d233c*/ void <CreateIDisposable>b__0();
            }

            class <>c__DisplayClass4_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ UnityEngine.Events.UnityAction action;

                /*0x38159dc*/ <>c__DisplayClass4_0();
                /*0x38159dc*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ UnityEngine.Events.UnityAction action;

                /*0x78cee74*/ <>c__DisplayClass5_0();
                /*0x78d266c*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass6_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ UnityEngine.Events.UnityAction action;
                /*0x0*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x38159dc*/ <>c__DisplayClass6_0();
                /*0x38159dc*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ UnityEngine.Events.UnityAction action;
                /*0x20*/ UnityEngine.Events.UnityAction <>9__0;

                /*0x78cf36c*/ <>c__DisplayClass7_0();
                /*0x78d283c*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass8_0<T>
            {
                /*0x0*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x0*/ System.Action<T> action;
                /*0x0*/ T instance;

                /*0x38159dc*/ <>c__DisplayClass8_0();
                /*0x38159dc*/ void <OnClick>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope;
                /*0x18*/ System.Action<UnityEngine.UI.Button> action;
                /*0x20*/ UnityEngine.UI.Button button;

                /*0x78cf530*/ <>c__DisplayClass9_0();
                /*0x78d2a0c*/ void <OnClick>b__0();
            }
        }

        interface IClickable
        {
            /*0x38148bc*/ UnityEngine.UI.Button get_Button();
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
                /*0x78d2be0*/ MonoBehaviourInjectableAttribute();
            }

            class ControllerInjectionForbiddenAttribute : System.Attribute
            {
                /*0x78d2be8*/ ControllerInjectionForbiddenAttribute();
            }

            class Context : UnityEngine.MonoBehaviour
            {
                /*0x20*/ object context;
                /*0x28*/ System.Type type;

                static /*0x78d2bf8*/ bool op_Equality(Assets.UiComponentSystem.Runtime.Context context, System.Type type);
                static /*0x78d2c78*/ bool op_Inequality(Assets.UiComponentSystem.Runtime.Context context, System.Type type);
                /*0x78d2e54*/ Context();
                /*0x3910ae8*/ void Add<T>(T context);
                /*0x3910ae8*/ T Get<T>();
                /*0x78d2bf0*/ System.Type GetContextType();
                /*0x78d2cf8*/ bool Equals(object obj);
                /*0x78d2dcc*/ int GetHashCode();
            }

            class Controller : System.IDisposable
            {
                /*0x10*/ UniRx.CompositeDisposable compositeDisposable;
                /*0x18*/ System.Collections.Generic.Stack<Cysharp.Threading.Tasks.UniTaskCompletionSource> promises;

                /*0x78d3044*/ Controller();
                /*0x78d2e5c*/ UniRx.CompositeDisposable get_CompositeDisposable();
                /*0x78d2ecc*/ void Close();
                /*0x78d2f38*/ Cysharp.Threading.Tasks.UniTask AwaitClosure(System.Threading.CancellationToken cancellationToken);
                /*0x78d3030*/ void Dispose();
            }

            class Controller<TResult> : Assets.UiComponentSystem.Runtime.Controller
            {
                /*0x0*/ System.Collections.Generic.Stack<Cysharp.Threading.Tasks.UniTaskCompletionSource<TResult>> promises;

                /*0x38159dc*/ Controller();
                /*0x3910ae8*/ void Close(TResult result);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> AwaitCompletion(System.Threading.CancellationToken cancellationToken);
            }

            class Deferred<T>
            {
                /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask<T>> execute;
                /*0x0*/ T value;

                /*0x3816710*/ Deferred(System.Func<Cysharp.Threading.Tasks.UniTask<T>> execution);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> GetAwaiter();
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> ToUniTask();
                Cysharp.Threading.Tasks.UniTask ContinueWith(System.Action<T> function);
                /*0x3816710*/ void OnCompleted(System.Action action);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> AttachCancellationToken(System.Threading.CancellationToken token);

                class <>c__DisplayClass2_0<T>
                {
                    /*0x0*/ Assets.UiComponentSystem.Runtime.Deferred<T> <>4__this;
                    /*0x0*/ System.Func<Cysharp.Threading.Tasks.UniTask<T>> execution;

                    /*0x38159dc*/ <>c__DisplayClass2_0();
                    /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> <.ctor>b__0();

                    struct <<-ctor>b__0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                        /*0x0*/ Assets.UiComponentSystem.Runtime.Deferred.<>c__DisplayClass2_0<T> <>4__this;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                        /*0x38159dc*/ void MoveNext();
                        /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }

            class Disposable
            {
                static /*0x0*/ System.IDisposable Empty;

                static /*0x78d307c*/ Disposable();
                static /*0x78ca1d8*/ System.IDisposable Create(System.Action disposeAction);

                class EmptyDisposable : System.IDisposable
                {
                    static /*0x0*/ Assets.UiComponentSystem.Runtime.Disposable.EmptyDisposable Disposable;

                    static /*0x78d3108*/ EmptyDisposable();
                    /*0x78d30fc*/ EmptyDisposable();
                    /*0x78d3104*/ void Dispose();
                }

                class ActionDisposable : System.IDisposable
                {
                    /*0x10*/ System.Action disposeAction;

                    /*0x78d304c*/ ActionDisposable(System.Action disposeAction);
                    /*0x78d3170*/ void Dispose();
                }
            }

            interface IGameNavigator
            {
                /*0x38148bc*/ System.Action<string> get_NavigationErrorHandler();
                /*0x3816710*/ void set_NavigationErrorHandler(System.Action<string> value);
                /*0x38148bc*/ System.Action<System.Exception> get_NavigationExceptionHandler();
                /*0x3816710*/ void set_NavigationExceptionHandler(System.Action<System.Exception> value);
                /*0x3814574*/ int get_InstanceLifetime();
                /*0x3815ed0*/ void set_InstanceLifetime(int value);
                /*0x3814574*/ int get_InstanceQuantityAllowance();
                /*0x3815ed0*/ void set_InstanceQuantityAllowance(int value);
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask MoveBack();
                /*0x38158ec*/ Cysharp.Threading.Tasks.UniTask MoveBack(int passOverAmount);
                Cysharp.Threading.Tasks.UniTask MoveToScene(string key);
                Cysharp.Threading.Tasks.UniTask MoveToScene(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToComponent(string key);
                Cysharp.Threading.Tasks.UniTask MoveToComponent(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x3816710*/ void ApplyDefaultInTransitions(System.Type[] transitions);
                /*0x3816710*/ void ApplyDefaultOutTransitions(System.Type[] transitions);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask OpenWindow(string key);
                Cysharp.Threading.Tasks.UniTask OpenWindow(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x38159dc*/ void ClearNavigationStack();
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

                static /*0x78d6528*/ GameNavigator();
                static /*0x78d3590*/ void ProcessBeforeSceneLoad();
                static /*0x78ce830*/ Cysharp.Threading.Tasks.UniTask ProcessExternalCreation(UnityEngine.UCSMonoBehaviour component, System.Threading.CancellationToken cancellationToken);
                static /*0x78d40c0*/ Cysharp.Threading.Tasks.UniTask SuspendAndTransitionOut(UnityEngine.GameObject gameObject);
                static /*0x78d50d8*/ Cysharp.Threading.Tasks.UniTask TransitionInAndComplete(UnityEngine.GameObject gameObject);
                static /*0x78d5af4*/ Cysharp.Threading.Tasks.UniTask ProcessInTransition(UnityEngine.GameObject gameObject);
                static /*0x78d5ba4*/ Cysharp.Threading.Tasks.UniTask ProcessOutTransition(UnityEngine.GameObject gameObject);
                static /*0x78d5c50*/ Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition[] AttachDefaultInTransitions(UnityEngine.GameObject gameObject);
                static /*0x78d5f54*/ Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.OutTransition[] AttachDefaultOutTransitions(UnityEngine.GameObject gameObject);
                static Cysharp.Threading.Tasks.UniTask <OpenWindow>g__ProcessTransition|45_0<TResult>(Assets.UiComponentSystem.Runtime.NavigationDescription transitionIn, Assets.UiComponentSystem.Runtime.NavigationDescription transitionOut, bool returning);
                static /*0x78d679c*/ bool <MoveBack>g__CanBeOpened|51_1(Assets.UiComponentSystem.Runtime.NavigationDescription description);
                static /*0x78d67bc*/ Cysharp.Threading.Tasks.UniTask<bool> <MoveToScene>g__ProcessCreateForInSceneComponents|70_1(UnityEngine.SceneManagement.Scene scene, object args);
                static /*0x78d68a8*/ Cysharp.Threading.Tasks.UniTask<bool> <MoveToScene>g__ProcessSuspendForInSceneComponents|70_4(UnityEngine.SceneManagement.Scene scene);
                /*0x78d31ec*/ GameNavigator(Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSCameraManager cameraController, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSLayoutManager layoutController, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider assetProvider, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetKeyProvider assetKeyProvider, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager sceneController);
                /*0x78d31ac*/ System.Action<string> get_NavigationErrorHandler();
                /*0x78d31b4*/ void set_NavigationErrorHandler(System.Action<string> value);
                /*0x78d31bc*/ System.Action<System.Exception> get_NavigationExceptionHandler();
                /*0x78d31c4*/ void set_NavigationExceptionHandler(System.Action<System.Exception> value);
                /*0x78d31cc*/ int get_InstanceLifetime();
                /*0x78d31d4*/ void set_InstanceLifetime(int value);
                /*0x78d31dc*/ int get_InstanceQuantityAllowance();
                /*0x78d31e4*/ void set_InstanceQuantityAllowance(int value);
                /*0x78d3774*/ void ClearNavigationStack();
                /*0x78d3988*/ void TryRewindStackToComponent(string key);
                /*0x78d416c*/ void TryRewindStackToScene(string key);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult, TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78d4480*/ Cysharp.Threading.Tasks.UniTask OpenWindow(string key);
                /*0x78d4514*/ Cysharp.Threading.Tasks.UniTask OpenWindow(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                Cysharp.Threading.Tasks.UniTask OpenWindow<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> OpenWindow<TResult>(string key, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78d45ac*/ Cysharp.Threading.Tasks.UniTask AwaitAnyProcessingOperations();
                /*0x78d463c*/ void RegisterOperation();
                /*0x78d4698*/ void CompleteOperation();
                /*0x78d46f0*/ void CloseWindowStack();
                /*0x78d48b0*/ Cysharp.Threading.Tasks.UniTask MoveBack();
                /*0x78d48b8*/ Cysharp.Threading.Tasks.UniTask MoveBack(int passOverAmount);
                /*0x78d4970*/ void AgeExistingInstances();
                /*0x78d5008*/ Cysharp.Threading.Tasks.UniTask Close(Assets.UiComponentSystem.Runtime.NavigationDescription description);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToComponent<TComponent>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TComponent> args);
                /*0x78d5184*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78d5290*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(string key);
                /*0x78d52a0*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(Assets.UiComponentSystem.Runtime.NavigationDescription description, bool moveBack);
                /*0x78d5194*/ Cysharp.Threading.Tasks.UniTask MoveToComponent(string key, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags, bool moveBack);
                /*0x78d54d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> AcquireInstance(string key, UnityEngine.Transform parent);
                /*0x78d5610*/ UnityEngine.Transform AcquireTargetParent(Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags, bool asWindow);
                /*0x78d5784*/ Cysharp.Threading.Tasks.UniTask ProcessTransitionToComponent(Assets.UiComponentSystem.Runtime.NavigationDescription activeDescription, Assets.UiComponentSystem.Runtime.NavigationDescription targetDescription, bool isMovingBack);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TElement>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TElement> args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                Cysharp.Threading.Tasks.UniTask MoveToScene<TElement>(string key, Assets.UiComponentSystem.Runtime.IArgsOf<TElement> args);
                /*0x78d587c*/ Cysharp.Threading.Tasks.UniTask MoveToScene(string key, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78d5a44*/ Cysharp.Threading.Tasks.UniTask MoveToScene(string key);
                /*0x78d5ad0*/ Cysharp.Threading.Tasks.UniTask MoveToScene(Assets.UiComponentSystem.Runtime.NavigationDescription description, System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription> sceneStack, System.Func<Cysharp.Threading.Tasks.UniTask<bool>> onProcessTransition);
                /*0x78d5914*/ Cysharp.Threading.Tasks.UniTask MoveToScene(string key, System.Collections.Generic.Stack<Assets.UiComponentSystem.Runtime.NavigationDescription> sceneStack, System.Func<Cysharp.Threading.Tasks.UniTask<bool>> onProcessTransition, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78d6258*/ Cysharp.Threading.Tasks.UniTask AwaitForOperationsBuffer();
                /*0x78d62e8*/ void ApplyDefaultInTransitions(System.Type[] transitions);
                /*0x78d6408*/ void ApplyDefaultOutTransitions(System.Type[] transitions);

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

                    /*0x78d6974*/ void MoveNext();
                    /*0x78d7220*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<MoveToScene>g__ProcessSuspendForInSceneComponents|70_4>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ UnityEngine.SceneManagement.Scene scene;
                    /*0x38*/ UnityEngine.GameObject[] <>7__wrap1;
                    /*0x40*/ int <>7__wrap2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78d7278*/ void MoveNext();
                    /*0x78d77e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<OpenWindow>g__ProcessTransition|45_0>d<TResult> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.NavigationDescription transitionIn;
                    /*0x0*/ Assets.UiComponentSystem.Runtime.NavigationDescription transitionOut;
                    /*0x0*/ bool returning;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c
                {
                    static /*0x0*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>9;
                    static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> <>9__32_0;
                    static /*0x10*/ System.Func<bool> <>9__46_0;
                    static /*0x18*/ System.Func<Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition, Cysharp.Threading.Tasks.UniTask> <>9__71_0;
                    static /*0x20*/ System.Func<Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.OutTransition, Cysharp.Threading.Tasks.UniTask> <>9__72_0;

                    static /*0x78d7840*/ <>c();
                    /*0x78d78a8*/ <>c();
                    /*0x78d78b0*/ void <ProcessBeforeSceneLoad>b__32_0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode _);
                    /*0x78d79b8*/ bool <AwaitAnyProcessingOperations>b__46_0();
                    /*0x78d7a10*/ Cysharp.Threading.Tasks.UniTask <ProcessInTransition>b__71_0(Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition t);
                    /*0x78d7a34*/ Cysharp.Threading.Tasks.UniTask <ProcessOutTransition>b__72_0(Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.OutTransition t);
                }

                class <>c__DisplayClass36_0
                {
                    /*0x10*/ UnityEngine.UCSMonoBehaviour component;

                    /*0x78d7a58*/ <>c__DisplayClass36_0();
                    /*0x78d7a60*/ Cysharp.Threading.Tasks.UniTask <ProcessExternalCreation>g__Process|0();

                    struct <<ProcessExternalCreation>g__Process|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                        /*0x78d7b0c*/ void MoveNext();
                        /*0x78d8284*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass51_0
                {
                    /*0x10*/ Assets.UiComponentSystem.Runtime.NavigationDescription activeDescription;
                    /*0x18*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x20*/ Assets.UiComponentSystem.Runtime.NavigationDescription targetDescription;

                    /*0x78d8290*/ <>c__DisplayClass51_0();
                    /*0x78d8298*/ Cysharp.Threading.Tasks.UniTask<bool> <MoveBack>b__0();

                    struct <<MoveBack>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                        /*0x30*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x78d8374*/ void MoveNext();
                        /*0x78d8a58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x78d8ab0*/ <>c__DisplayClass70_0();
                    /*0x78d8ab8*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>b__0();
                    /*0x78d8b6c*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>g__ProcessTransitionToScene|2(System.Func<Cysharp.Threading.Tasks.UniTask> loadingOperation);
                    /*0x78d8c3c*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>g__HideSceneStack|3(UnityEngine.SceneManagement.Scene scene);

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

                        /*0x78d8cf4*/ void MoveNext();
                        /*0x78d9d04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MoveToScene>g__HideSceneStack|3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ UnityEngine.SceneManagement.Scene scene;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x78d9d10*/ void MoveNext();
                        /*0x78da878*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MoveToScene>g__ProcessTransitionToScene|2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ System.Func<Cysharp.Threading.Tasks.UniTask> loadingOperation;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x78da884*/ void MoveNext();
                        /*0x78db1cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass70_1
                {
                    /*0x10*/ UnityEngine.SceneManagement.Scene scene;
                    /*0x14*/ bool requestMoveBack;
                    /*0x18*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> CS$<>8__locals1;

                    /*0x78db1d8*/ <>c__DisplayClass70_1();
                    /*0x78db1e0*/ Cysharp.Threading.Tasks.UniTask <MoveToScene>b__5();
                    /*0x78db28c*/ bool <MoveToScene>b__6(bool value);
                    /*0x78db2a0*/ bool <MoveToScene>b__7(bool value);

                    struct <<MoveToScene>b__5>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.UiComponentSystem.Runtime.GameNavigator.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__2;

                        /*0x78db2b4*/ void MoveNext();
                        /*0x78dbbf4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x78dbc00*/ void MoveNext();
                    /*0x78dc43c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <AwaitAnyProcessingOperations>d__46 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78dc494*/ void MoveNext();
                    /*0x78dc98c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <AwaitForOperationsBuffer>d__75 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78dc998*/ void MoveNext();
                    /*0x78dcf58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Close>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.UiComponentSystem.Runtime.NavigationDescription description;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.GameNavigator <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78dcf64*/ void MoveNext();
                    /*0x78ddaa4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x78ddab0*/ void MoveNext();
                    /*0x78dfe74*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x78dfe80*/ void MoveNext();
                    /*0x78e1368*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x78e1374*/ void MoveNext();
                    /*0x78e2eac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessExternalCreation>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.UCSMonoBehaviour component;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78e2eb8*/ void MoveNext();
                    /*0x78e3324*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessInTransition>d__71 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.ExternalAbstractClasses.InTransition[] <transitions>5__2;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78e3330*/ void MoveNext();
                    /*0x78e3b68*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessOutTransition>d__72 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78e3b74*/ void MoveNext();
                    /*0x78e4158*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x78e4164*/ void MoveNext();
                    /*0x78e5b5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SuspendAndTransitionOut>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78e5b68*/ void MoveNext();
                    /*0x78e6204*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionInAndComplete>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.GameObject gameObject;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x78e6210*/ void MoveNext();
                    /*0x78e68ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                static /*0x78e6b90*/ Lock();
                static /*0x78e68b8*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes get_ActiveScope();
                static /*0x78e6910*/ void set_ActiveScope(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes value);
                static /*0x78cad04*/ Assets.UiComponentSystem.Runtime.Lock TryAcquire(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes scope);
                static /*0x78e69ac*/ void Unlock(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes type);
                static /*0x78caec8*/ bool op_Implicit(Assets.UiComponentSystem.Runtime.Lock lock);
                /*0x78e69a4*/ Lock();
                /*0x78e696c*/ Assets.UiComponentSystem.Runtime.Lock.ScopeTypes get_Scope();
                /*0x78e6974*/ void set_Scope(Assets.UiComponentSystem.Runtime.Lock.ScopeTypes value);
                /*0x78e697c*/ bool get_IsAcquired();
                /*0x78e6984*/ void set_IsAcquired(bool value);
                /*0x78e6990*/ bool get_IsDisposed();
                /*0x78e6998*/ void set_IsDisposed(bool value);
                /*0x78e6a10*/ void Dispose();

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

                /*0x78d3530*/ NavigationDescription(string key, Assets.UiComponentSystem.Runtime.NavigationDescription.Types type, object args, Assets.UiComponentSystem.Runtime.GameNavigator.Flags flags);
                /*0x78e6c50*/ Assets.UiComponentSystem.Runtime.NavigationDescription.Types get_Type();
                /*0x78e6c58*/ string get_Key();
                /*0x78e6c60*/ Assets.UiComponentSystem.Runtime.GameNavigator.Flags get_Flags();
                /*0x78e6c68*/ object get_Args();
                /*0x78e6c70*/ UnityEngine.Transform get_Parent();
                /*0x78e6c78*/ void set_Parent(UnityEngine.Transform value);
                /*0x78e6c80*/ UnityEngine.GameObject get_Instance();
                /*0x78e6c88*/ void set_Instance(UnityEngine.GameObject value);
                /*0x78e6c90*/ string get_SceneInstanceName();
                /*0x78e6c98*/ void set_SceneInstanceName(string value);
                /*0x78e6ca0*/ System.Threading.CancellationTokenSource get_CancellationTokenSource();
                /*0x78e6ca8*/ void set_CancellationTokenSource(System.Threading.CancellationTokenSource value);

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

                static /*0x78ce204*/ VContainer.Unity.LifetimeScope AcquireScope();
                /*0x78e6d30*/ RootLifetimeScopeAccessor();
                /*0x78e6cb0*/ void Awake();
            }

            namespace ExternalInterfaces
            {
                interface IUCSAssetKeyProvider
                {
                    /*0x3814a3c*/ string AcquireSceneKey(string sceneName);
                    /*0x3814a3c*/ string AcquireKey(string key);
                    /*0x3814a3c*/ string SceneKeyToSceneName(string key);
                }

                interface IUCSAssetProvider
                {
                    Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform, bool active);
                    /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key);
                }

                interface IUCSCameraManager
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                }

                interface IUCSEntryPoint
                {
                    /*0x3813ffc*/ bool get_IsEntryInitializationCompleted();
                    /*0x3815cc4*/ void set_IsEntryInitializationCompleted(bool value);
                }

                interface IUCSLayoutManager
                {
                    /*0x38148bc*/ UnityEngine.Transform get_Foreground();
                    /*0x38148bc*/ UnityEngine.Transform get_Overlay();
                    /*0x38148bc*/ UnityEngine.Transform get_System();
                }

                interface IUCSSceneManager
                {
                    Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> MoveToSceneAcync(string key);

                    class LoadSceneResult
                    {
                        /*0x10*/ bool <Succeeded>k__BackingField;
                        /*0x14*/ System.Nullable<UnityEngine.SceneManagement.Scene> <Scene>k__BackingField;

                        /*0x78e6d48*/ LoadSceneResult(bool succeeded, System.Nullable<UnityEngine.SceneManagement.Scene> scene);
                        /*0x78e6d38*/ bool get_Succeeded();
                        /*0x78e6d40*/ System.Nullable<UnityEngine.SceneManagement.Scene> get_Scene();
                    }
                }
            }

            namespace ExternalAbstractClasses
            {
                class InTransition : UnityEngine.MonoBehaviour
                {
                    static float DefaultDuration = 0.10000000149011612;

                    /*0x78e6d84*/ InTransition();
                    /*0x38159dc*/ void Kill();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Playback();
                    /*0x38159dc*/ void Prepare();
                    /*0x78e6d78*/ void OnDestroy();
                }

                class OutTransition : UnityEngine.MonoBehaviour
                {
                    static float DefaultDuration = 0.10000000149011612;

                    /*0x78e6d98*/ OutTransition();
                    /*0x38159dc*/ void Kill();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Playback();
                    /*0x38159dc*/ void Prepare();
                    /*0x78e6d8c*/ void OnDestroy();
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

                        /*0x78e71cc*/ TMPInputHandler();
                        /*0x78e6da0*/ bool get_Interactable();
                        /*0x78e6da8*/ void set_Interactable(bool value);
                        /*0x78e6db4*/ UnityEngine.Events.UnityEvent get_OnLinkClick();
                        /*0x78e6dbc*/ void set_OnLinkClick(UnityEngine.Events.UnityEvent value);
                        /*0x78e6dc4*/ UnityEngine.Events.UnityEvent get_OnLinkEnter();
                        /*0x78e6dcc*/ void set_OnLinkEnter(UnityEngine.Events.UnityEvent value);
                        /*0x78e6dd4*/ UnityEngine.Events.UnityEvent get_OnLinkExit();
                        /*0x78e6ddc*/ void set_OnLinkExit(UnityEngine.Events.UnityEvent value);
                        /*0x78e6de4*/ TMPro.TMP_LinkInfo get_LinkInfo();
                        /*0x78e6df8*/ void set_LinkInfo(TMPro.TMP_LinkInfo value);
                        /*0x78e6e18*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
                        /*0x78e6f34*/ TMPro.TMP_Text AcquireAttachedText();
                        /*0x78e6fdc*/ void PopulateLinkInfoData(int index);
                        /*0x78e7050*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
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
