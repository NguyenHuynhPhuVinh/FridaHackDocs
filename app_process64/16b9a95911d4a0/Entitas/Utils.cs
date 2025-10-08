class <Module>
{
}

namespace Entitas
{
    namespace Utils
    {
        class ObjectCache
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, object> _objectPools;

            /*0x2d20a54*/ ObjectCache();
            /*0x1f30214*/ Entitas.Utils.ObjectPool<T> GetObjectPool<T>();
            /*0x1ffc854*/ T Get<T>();
            /*0x1ffc854*/ void Push<T>(T obj);

            class <>c__2<T>
            {
                static /*0x0*/ Entitas.Utils.ObjectCache.<>c__2<T> <>9;
                static /*0x0*/ System.Func<T> <>9__2_0;

                static /*0x1f33998*/ <>c__2();
                /*0x1f309e4*/ <>c__2();
                /*0x1ffc854*/ T <GetObjectPool>b__2_0();
            }
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Func<T> _factoryMethod;
            /*0x0*/ System.Action<T> _resetMethod;
            /*0x0*/ System.Collections.Generic.Stack<T> _objectPool;

            /*0x1f30ff0*/ ObjectPool(System.Func<T> factoryMethod, System.Action<T> resetMethod);
            /*0x1ffc854*/ T Get();
            /*0x1ffc854*/ void Push(T obj);
        }

        class InterfaceTypeExtension
        {
            static /*0x1f31840*/ bool ImplementsInterface<T>(System.Type type);
        }

        class TypeSerializationExtension
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, string> _builtInTypesToString;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, string> _builtInTypeStrings;

            static /*0x2d20ea8*/ TypeSerializationExtension();
            static /*0x2d20adc*/ string ToCompilableString(System.Type type);

            class <>c
            {
                static /*0x0*/ Entitas.Utils.TypeSerializationExtension.<> <>9;
                static /*0x8*/ System.Func<System.Type, string> <>9__0_0;

                static /*0x2d21578*/ <>c();
                /*0x2d215e0*/ <>c();
                /*0x2d215e8*/ string <ToCompilableString>b__0_0(System.Type argType);
            }
        }
    }
}
