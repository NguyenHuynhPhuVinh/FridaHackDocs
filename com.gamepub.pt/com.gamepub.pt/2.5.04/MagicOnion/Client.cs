class <Module>
{
}

class <>f__AnonymousType0<<def>j__TPar, <label>j__TPar>
{
    /*0x0*/ <def> <def>i__Field;
    /*0x0*/ <label> <label>i__Field;

    <>f__AnonymousType0(<def> def, <label> label);
    <def> get_def();
    <label> get_label();
    bool Equals(object value);
    int GetHashCode();
    string ToString();
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x29d73ec*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x29d93f8*/ IsUnmanagedAttribute();
            }
        }
    }
}

class ReflectionExtensions
{
    static /*0x29da550*/ bool IsNullable(System.Reflection.TypeInfo type);
    static /*0x29da628*/ bool IsPublic(System.Reflection.TypeInfo type);
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IgnoresAccessChecksToAttribute : System.Attribute
            {
                /*0x10*/ string <AssemblyName>k__BackingField;

                /*0x29d7e54*/ IgnoresAccessChecksToAttribute(string assemblyName);
                /*0x29d7e80*/ string get_AssemblyName();
            }
        }
    }
}

namespace MagicOnion
{
    class AsyncLock
    {
        /*0x10*/ System.Threading.SemaphoreSlim semaphore;

        /*0x29d60bc*/ AsyncLock();
        /*0x29d612c*/ System.Threading.Tasks.Task<MagicOnion.AsyncLock.LockReleaser> LockAsync();

        struct LockReleaser : System.IDisposable
        {
            /*0x10*/ System.Threading.SemaphoreSlim semaphore;

            /*0xb11330*/ LockReleaser(System.Threading.SemaphoreSlim semaphore);
            /*0xb11338*/ void Dispose();
        }

        struct <LockAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MagicOnion.AsyncLock.LockReleaser> <>t__builder;
            /*0x30*/ MagicOnion.AsyncLock <>4__this;
            /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

            /*0xb112e4*/ void MoveNext();
            /*0xb112ec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    struct DynamicArgumentTuple<T1, T2>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;

        DynamicArgumentTuple(T1 item1, T2 item2);
    }

    class DynamicArgumentTupleFormatter<T1, T2> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;
        /*0x0*/ T14 Item14;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;
        /*0x0*/ T14 default14;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13, T14 default14);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;
        /*0x0*/ T14 Item14;
        /*0x0*/ T15 Item15;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;
        /*0x0*/ T14 default14;
        /*0x0*/ T15 default15;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13, T14 default14, T15 default15);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;
        /*0x0*/ T14 Item14;
        /*0x0*/ T15 Item15;
        /*0x0*/ T16 Item16;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;
        /*0x0*/ T14 default14;
        /*0x0*/ T15 default15;
        /*0x0*/ T16 default16;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13, T14 default14, T15 default15, T16 default16);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;
        /*0x0*/ T14 Item14;
        /*0x0*/ T15 Item15;
        /*0x0*/ T16 Item16;
        /*0x0*/ T17 Item17;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;
        /*0x0*/ T14 default14;
        /*0x0*/ T15 default15;
        /*0x0*/ T16 default16;
        /*0x0*/ T17 default17;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13, T14 default14, T15 default15, T16 default16, T17 default17);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;
        /*0x0*/ T14 Item14;
        /*0x0*/ T15 Item15;
        /*0x0*/ T16 Item16;
        /*0x0*/ T17 Item17;
        /*0x0*/ T18 Item18;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;
        /*0x0*/ T14 default14;
        /*0x0*/ T15 default15;
        /*0x0*/ T16 default16;
        /*0x0*/ T17 default17;
        /*0x0*/ T18 default18;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13, T14 default14, T15 default15, T16 default16, T17 default17, T18 default18);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;
        /*0x0*/ T14 Item14;
        /*0x0*/ T15 Item15;
        /*0x0*/ T16 Item16;
        /*0x0*/ T17 Item17;
        /*0x0*/ T18 Item18;
        /*0x0*/ T19 Item19;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;
        /*0x0*/ T14 default14;
        /*0x0*/ T15 default15;
        /*0x0*/ T16 default16;
        /*0x0*/ T17 default17;
        /*0x0*/ T18 default18;
        /*0x0*/ T19 default19;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13, T14 default14, T15 default15, T16 default16, T17 default17, T18 default18, T19 default19);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    struct DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
    {
        /*0x0*/ T1 Item1;
        /*0x0*/ T2 Item2;
        /*0x0*/ T3 Item3;
        /*0x0*/ T4 Item4;
        /*0x0*/ T5 Item5;
        /*0x0*/ T6 Item6;
        /*0x0*/ T7 Item7;
        /*0x0*/ T8 Item8;
        /*0x0*/ T9 Item9;
        /*0x0*/ T10 Item10;
        /*0x0*/ T11 Item11;
        /*0x0*/ T12 Item12;
        /*0x0*/ T13 Item13;
        /*0x0*/ T14 Item14;
        /*0x0*/ T15 Item15;
        /*0x0*/ T16 Item16;
        /*0x0*/ T17 Item17;
        /*0x0*/ T18 Item18;
        /*0x0*/ T19 Item19;
        /*0x0*/ T20 Item20;

        DynamicArgumentTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20);
    }

    class DynamicArgumentTupleFormatter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : MessagePack.Formatters.IMessagePackFormatter<MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ T1 default1;
        /*0x0*/ T2 default2;
        /*0x0*/ T3 default3;
        /*0x0*/ T4 default4;
        /*0x0*/ T5 default5;
        /*0x0*/ T6 default6;
        /*0x0*/ T7 default7;
        /*0x0*/ T8 default8;
        /*0x0*/ T9 default9;
        /*0x0*/ T10 default10;
        /*0x0*/ T11 default11;
        /*0x0*/ T12 default12;
        /*0x0*/ T13 default13;
        /*0x0*/ T14 default14;
        /*0x0*/ T15 default15;
        /*0x0*/ T16 default16;
        /*0x0*/ T17 default17;
        /*0x0*/ T18 default18;
        /*0x0*/ T19 default19;
        /*0x0*/ T20 default20;

        DynamicArgumentTupleFormatter(T1 default1, T2 default2, T3 default3, T4 default4, T5 default5, T6 default6, T7 default7, T8 default8, T9 default9, T10 default10, T11 default11, T12 default12, T13 default13, T14 default14, T15 default15, T16 default16, T17 default17, T18 default18, T19 default19, T20 default20);
        void Serialize(ref MessagePack.MessagePackWriter writer, MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> value, MessagePack.MessagePackSerializerOptions options);
        MagicOnion.DynamicArgumentTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    class MagicOnionMarshallers
    {
        static /*0x0*/ System.Type[] dynamicArgumentTupleTypes;
        static /*0x8*/ System.Type[] dynamicArgumentTupleFormatterTypes;
        static /*0x10*/ byte[] UnsafeNilBytes;
        static /*0x18*/ Grpc.Core.Marshaller<System.Byte[]> ThroughMarshaller;

        static /*0x29d9e1c*/ MagicOnionMarshallers();
        static /*0x29d94ec*/ System.Type CreateRequestType(System.Reflection.ParameterInfo[] parameters);
        static /*0x29d97c8*/ System.Type CreateRequestTypeAndSetResolver(string path, System.Reflection.ParameterInfo[] parameters, ref MessagePack.IFormatterResolver resolver);
        static /*0x29d9d54*/ object InstantiateDynamicArgumentTuple(System.Type[] typeParameters, object[] arguments);

        class <>c
        {
            static /*0x0*/ MagicOnion.MagicOnionMarshallers.<> <>9;
            static /*0x8*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__4_0;
            static /*0x10*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__5_0;
            static /*0x18*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__5_1;
            static /*0x20*/ System.Func<System.Reflection.ParameterInfo, object> <>9__5_2;

            static /*0x29e0ba0*/ <>c();
            /*0x29e0c00*/ <>c();
            /*0x29e0c08*/ System.Type <CreateRequestType>b__4_0(System.Reflection.ParameterInfo x);
            /*0x29e0c28*/ System.Type <CreateRequestTypeAndSetResolver>b__5_0(System.Reflection.ParameterInfo x);
            /*0x29e0c48*/ System.Type <CreateRequestTypeAndSetResolver>b__5_1(System.Reflection.ParameterInfo x);
            /*0x29e0c68*/ object <CreateRequestTypeAndSetResolver>b__5_2(System.Reflection.ParameterInfo x);
            /*0x29e0d08*/ bool <.cctor>b__7_0(System.Type x);
            /*0x29e0dbc*/ int <.cctor>b__7_1(System.Type x);
            /*0x29e0df0*/ bool <.cctor>b__7_2(System.Type x);
            /*0x29e0e58*/ int <.cctor>b__7_3(System.Type x);
            /*0x29e0e8c*/ byte[] <.cctor>b__7_4(byte[] x);
            /*0x29e0e94*/ byte[] <.cctor>b__7_5(byte[] x);
        }
    }

    class PriorityResolver : MessagePack.IFormatterResolver
    {
        /*0x10*/ System.Type formatterType;
        /*0x18*/ object formatter;
        /*0x20*/ MessagePack.IFormatterResolver innerResolver;

        /*0x29d9d14*/ PriorityResolver(System.Type formatterType, object formatter, MessagePack.IFormatterResolver innerResolver);
        MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
    }

    class MetadataExtensions
    {
        static string BinarySuffix = "-bin";

        static /*0x29da2e4*/ Grpc.Core.Metadata.Entry Get(Grpc.Core.Metadata metadata, string key, bool ignoreCase);
        static /*0x29da3a0*/ string GetValue(Grpc.Core.Metadata metadata, string key, bool ignoreCase);
    }

    class UnsafeDirectBlitResolver : MessagePack.IFormatterResolver
    {
        static /*0x0*/ MagicOnion.UnsafeDirectBlitResolver Instance;
        /*0x10*/ bool isFreezed;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Type, object> formatters;

        static /*0x29dac38*/ UnsafeDirectBlitResolver();
        /*0x29dabc0*/ UnsafeDirectBlitResolver();
        void Register<T>();
        MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

        class FormatterCache<T>
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache();
        }
    }

    class UnsafeDirectBlitArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[]>, MessagePack.Formatters.IMessagePackFormatter
    {
        static int TypeCode = 45;
        /*0x0*/ int StructLength;

        UnsafeDirectBlitArrayFormatter();
        void Serialize(ref MessagePack.MessagePackWriter writer, T[] value, MessagePack.MessagePackSerializerOptions options);
        T[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
    }

    class UnsafeDirectBlitFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
    {
        /*0x0*/ int size;

        UnsafeDirectBlitFormatter();
        void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
        T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        void ValidateRead(long length);
    }

    class TaskEx
    {
        static /*0x0*/ System.Threading.Tasks.Task CompletedTask;

        static /*0x29dab40*/ TaskEx();
    }

    class MarshallingAsyncStreamReader<T> : Grpc.Core.IAsyncStreamReader<T>, System.IDisposable
    {
        /*0x0*/ Grpc.Core.IAsyncStreamReader<System.Byte[]> inner;
        /*0x0*/ MessagePack.MessagePackSerializerOptions options;
        /*0x0*/ T <Current>k__BackingField;

        MarshallingAsyncStreamReader(Grpc.Core.IAsyncStreamReader<System.Byte[]> inner, MessagePack.MessagePackSerializerOptions options);
        T get_Current();
        void set_Current(T value);
        System.Threading.Tasks.Task<bool> MoveNext(System.Threading.CancellationToken cancellationToken);
        void Dispose();

        struct <MoveNext>d__7<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x0*/ MagicOnion.MarshallingAsyncStreamReader<T> <>4__this;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ System.Runtime.CompilerServices.TaskAwaiter<bool> <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class MarshallingClientStreamWriter<T> : Grpc.Core.IClientStreamWriter<T>, Grpc.Core.IAsyncStreamWriter<T>
    {
        /*0x0*/ Grpc.Core.IClientStreamWriter<System.Byte[]> inner;
        /*0x0*/ MessagePack.MessagePackSerializerOptions options;

        MarshallingClientStreamWriter(Grpc.Core.IClientStreamWriter<System.Byte[]> inner, MessagePack.MessagePackSerializerOptions options);
        Grpc.Core.WriteOptions get_WriteOptions();
        void set_WriteOptions(Grpc.Core.WriteOptions value);
        System.Threading.Tasks.Task CompleteAsync();
        System.Threading.Tasks.Task WriteAsync(T message);
    }

    namespace Utils
    {
        class ArrayPoolBufferWriter : System.Buffers.IBufferWriter<byte>, System.IDisposable
        {
            static int MinimumBufferSize = 32767;
            [ThreadStatic] static MagicOnion.Utils.ArrayPoolBufferWriter staticInstance;
            /*0x10*/ byte[] buffer;
            /*0x18*/ int index;

            static /*0x29d56e8*/ MagicOnion.Utils.ArrayPoolBufferWriter RentThreadStaticWriter();
            /*0x29d577c*/ ArrayPoolBufferWriter();
            /*0x29d5784*/ void Prepare();
            /*0x29d5884*/ System.ReadOnlyMemory<byte> get_WrittenMemory();
            /*0x29d5928*/ System.ReadOnlySpan<byte> get_WrittenSpan();
            /*0x29d5a2c*/ int get_WrittenCount();
            /*0x29d5a34*/ int get_Capacity();
            /*0x29d5a50*/ int get_FreeCapacity();
            /*0x29d5a74*/ void Advance(int count);
            /*0x29d5adc*/ System.Memory<byte> GetMemory(int sizeHint);
            /*0x29d5efc*/ System.Span<byte> GetSpan(int sizeHint);
            /*0x29d5b78*/ void CheckAndResizeBuffer(int sizeHint);
            /*0x29d5fbc*/ void Dispose();
        }

        class DynamicAssembly
        {
            /*0x10*/ object gate;
            /*0x18*/ System.Reflection.Emit.AssemblyBuilder assemblyBuilder;
            /*0x20*/ System.Reflection.Emit.ModuleBuilder moduleBuilder;

            /*0x29d6c70*/ DynamicAssembly(string moduleName);
            /*0x29d6ffc*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr);
            /*0x29d70f0*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent);
            /*0x29d71f4*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces);
        }

        class FNV1A32
        {
            static /*0x29d69f0*/ int GetHashCode(string str);
            static /*0x29d73f4*/ int GetHashCode(byte[] obj);
        }

        class ILGeneratorExtensions
        {
            static /*0x29d7460*/ void EmitLdloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x29d7634*/ void EmitStloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x29d7808*/ void EmitLdloca(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x29d78c8*/ void EmitLdc_I4(System.Reflection.Emit.ILGenerator il, int value);
            static /*0x29d7c00*/ void EmitPop(System.Reflection.Emit.ILGenerator il, int count);
            static /*0x29d7ca4*/ void EmitNullReturn(System.Reflection.Emit.ILGenerator il);
            static /*0x29d7d3c*/ void EmitThrowNotimplemented(System.Reflection.Emit.ILGenerator il);
        }

        interface ITaskCompletion
        {
            bool TrySetException(System.Exception ex);
            bool TrySetCanceled();
        }

        class TaskCompletionSourceEx<T> : System.Threading.Tasks.TaskCompletionSource<T>, MagicOnion.Utils.ITaskCompletion
        {
            TaskCompletionSourceEx();
            bool MagicOnion.Utils.ITaskCompletion.TrySetCanceled();
            bool MagicOnion.Utils.ITaskCompletion.TrySetException(System.Exception ex);
        }
    }

    namespace Server
    {
        namespace Hubs
        {
            class BroadcasterHelper
            {
                static /*0x0*/ System.Type[] dynamicArgumentTupleTypes;

                static /*0x29d6a30*/ BroadcasterHelper();
                static /*0x29d6270*/ MagicOnion.Server.Hubs.BroadcasterHelper.MethodDefinition[] SearchDefinitions(System.Type interfaceType);
                static /*0x29d66b0*/ void VerifyMethodDefinitions(MagicOnion.Server.Hubs.BroadcasterHelper.MethodDefinition[] definitions);

                class MethodDefinition
                {
                    /*0x10*/ System.Type ReceiverType;
                    /*0x18*/ System.Reflection.MethodInfo MethodInfo;
                    /*0x20*/ int MethodId;

                    /*0x29db284*/ MethodDefinition();
                    /*0x29db28c*/ string get_Path();
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ System.Type interfaceType;

                    /*0x29d66a8*/ <>c__DisplayClass1_0();
                    /*0x29db20c*/ MagicOnion.Server.Hubs.BroadcasterHelper.MethodDefinition <SearchDefinitions>b__3(System.Reflection.MethodInfo x);
                }

                class <>c
                {
                    static /*0x0*/ MagicOnion.Server.Hubs.BroadcasterHelper.<> <>9;
                    static /*0x8*/ System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> <>9__1_0;
                    static /*0x10*/ System.Func<System.Reflection.MethodInfo, bool> <>9__1_1;
                    static /*0x18*/ System.Func<System.Reflection.MethodInfo, bool> <>9__1_2;

                    static /*0x29daed8*/ <>c();
                    /*0x29daf38*/ <>c();
                    /*0x29daf40*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> <SearchDefinitions>b__1_0(System.Type x);
                    /*0x29daf5c*/ bool <SearchDefinitions>b__1_1(System.Reflection.MethodInfo x);
                    /*0x29db0f8*/ bool <SearchDefinitions>b__1_2(System.Reflection.MethodInfo x);
                    /*0x29db124*/ bool <.cctor>b__4_0(System.Type x);
                    /*0x29db1d8*/ int <.cctor>b__4_1(System.Type x);
                }
            }
        }
    }

    namespace Client
    {
        interface IClientFilter
        {
            System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> SendAsync(MagicOnion.Client.RequestContext context, System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> next);
        }

        class RequestContext
        {
            static /*0x0*/ System.Func<System.Byte[], System.Byte[]> DefaultMutator;
            /*0x10*/ string <MethodPath>k__BackingField;
            /*0x18*/ Grpc.Core.CallOptions <CallOptions>k__BackingField;
            /*0x58*/ System.Type <ResponseType>k__BackingField;
            /*0x60*/ System.Func<System.Byte[], System.Byte[]> <RequestMutator>k__BackingField;
            /*0x68*/ System.Func<System.Byte[], System.Byte[]> <ResponseMutator>k__BackingField;
            /*0x70*/ System.Collections.Generic.Dictionary<string, object> items;
            /*0x78*/ MagicOnion.Client.MagicOnionClientBase <Client>k__BackingField;
            /*0x80*/ MagicOnion.Client.IClientFilter[] <Filters>k__BackingField;
            /*0x88*/ System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> <RequestMethod>k__BackingField;

            static /*0x29da80c*/ RequestContext();
            /*0x29da720*/ RequestContext(MagicOnion.Client.MagicOnionClientBase client, string methodPath, Grpc.Core.CallOptions callOptions, System.Type responseType, MagicOnion.Client.IClientFilter[] filters, System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> requestMethod);
            /*0x29da640*/ string get_MethodPath();
            /*0x29da648*/ Grpc.Core.CallOptions get_CallOptions();
            /*0x29da664*/ System.Type get_ResponseType();
            System.Type get_RequestType();
            /*0x29da66c*/ System.Func<System.Byte[], System.Byte[]> get_RequestMutator();
            /*0x29da674*/ void set_RequestMutator(System.Func<System.Byte[], System.Byte[]> value);
            /*0x29da67c*/ System.Func<System.Byte[], System.Byte[]> get_ResponseMutator();
            /*0x29da684*/ void set_ResponseMutator(System.Func<System.Byte[], System.Byte[]> value);
            /*0x29da68c*/ System.Collections.Generic.IDictionary<string, object> get_Items();
            /*0x29da708*/ MagicOnion.Client.MagicOnionClientBase get_Client();
            /*0x29da710*/ MagicOnion.Client.IClientFilter[] get_Filters();
            /*0x29da718*/ System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> get_RequestMethod();
            /*0x29da7fc*/ void SetRequestMutator(System.Func<System.Byte[], System.Byte[]> mutator);
            /*0x29da804*/ void SetResponseMutator(System.Func<System.Byte[], System.Byte[]> mutator);

            class <>c
            {
                static /*0x0*/ MagicOnion.Client.RequestContext.<> <>9;

                static /*0x29e0e9c*/ <>c();
                /*0x29e0efc*/ <>c();
                /*0x29e0f04*/ byte[] <.cctor>b__35_0(byte[] xs);
            }
        }

        class RequestContext<T> : MagicOnion.Client.RequestContext
        {
            /*0x0*/ T <Request>k__BackingField;

            RequestContext(T request, MagicOnion.Client.MagicOnionClientBase client, string methodPath, Grpc.Core.CallOptions callOptions, System.Type responseType, MagicOnion.Client.IClientFilter[] filters, System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> requestMethod);
            T get_Request();
            System.Type get_RequestType();
        }

        class ResponseContext : MagicOnion.Client.IResponseContext, System.IDisposable
        {
            static /*0x0*/ System.Func<System.Byte[], System.Byte[]> DefaultMutator;
            /*0x10*/ System.Func<System.Byte[], System.Byte[]> <ResponseMutator>k__BackingField;

            static /*0x29da978*/ ResponseContext();
            /*0x29da8f8*/ ResponseContext();
            System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
            Grpc.Core.Status GetStatus();
            Grpc.Core.Metadata GetTrailers();
            void Dispose();
            System.Type get_ResponseType();
            /*0x29da8e8*/ System.Func<System.Byte[], System.Byte[]> get_ResponseMutator();
            /*0x29da8f0*/ void set_ResponseMutator(System.Func<System.Byte[], System.Byte[]> value);
            System.Threading.Tasks.Task<MagicOnion.Client.ResponseContext> WaitResponseAsync();
            MagicOnion.Client.ResponseContext<T> As<T>();
            System.Threading.Tasks.Task<T> GetResponseAs<T>();
            /*0x29da970*/ void SetResponseMutator(System.Func<System.Byte[], System.Byte[]> mutator);

            class <>c
            {
                static /*0x0*/ MagicOnion.Client.ResponseContext.<> <>9;

                static /*0x29e0f0c*/ <>c();
                /*0x29e0f6c*/ <>c();
                /*0x29e0f74*/ byte[] <.cctor>b__17_0(byte[] xs);
            }
        }

        class ResponseContext<T> : MagicOnion.Client.ResponseContext, MagicOnion.Client.IResponseContext<T>, MagicOnion.Client.IResponseContext, System.IDisposable
        {
            /*0x0*/ Grpc.Core.AsyncUnaryCall<System.Byte[]> inner;
            /*0x0*/ MessagePack.MessagePackSerializerOptions serializerOptions;
            /*0x0*/ bool isMock;
            /*0x0*/ bool deserialized;
            /*0x0*/ T responseObject;
            /*0x0*/ Grpc.Core.Metadata trailers;
            /*0x0*/ Grpc.Core.Metadata responseHeaders;
            /*0x0*/ Grpc.Core.Status status;

            ResponseContext(Grpc.Core.AsyncUnaryCall<System.Byte[]> inner, MessagePack.MessagePackSerializerOptions serializerOptions);
            ResponseContext(T responseObject);
            ResponseContext(T responseObject, Grpc.Core.Metadata trailers, Grpc.Core.Metadata responseHeaders, Grpc.Core.Status status);
            System.Threading.Tasks.Task<T> Deserialize();
            System.Threading.Tasks.Task<T> get_ResponseAsync();
            System.Threading.Tasks.Task<MagicOnion.Client.ResponseContext> WaitResponseAsync();
            System.Type get_ResponseType();
            System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
            void Dispose();
            Grpc.Core.Status GetStatus();
            Grpc.Core.Metadata GetTrailers();
            MagicOnion.Client.ResponseContext<T> WithNewResult(T result);

            struct <Deserialize>d__<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ MagicOnion.Client.ResponseContext<T> <>4__this;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Byte[]> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WaitResponseAsync>d__14<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MagicOnion.Client.ResponseContext> <>t__builder;
                /*0x0*/ MagicOnion.Client.ResponseContext<T> <>4__this;
                /*0x0*/ System.Runtime.CompilerServices.TaskAwaiter<T> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DynamicClientAssemblyHolder
        {
            static string ModuleName = "MagicOnion.Client.DynamicClient";
            static /*0x0*/ MagicOnion.Utils.DynamicAssembly assembly;

            static /*0x29d7364*/ DynamicClientAssemblyHolder();
            static /*0x29d7300*/ MagicOnion.Utils.DynamicAssembly get_Assembly();
        }

        class DynamicClientBuilder<T>
        {
            static /*0x0*/ System.Type ClientType;
            static /*0x0*/ System.Type bytesMethod;
            static /*0x0*/ System.Reflection.FieldInfo throughMarshaller;
            static /*0x0*/ System.Reflection.FieldInfo nilBytes;
            static /*0x0*/ System.Reflection.MethodInfo callMessagePackSerialize;
            static /*0x0*/ System.Reflection.MethodInfo callCancellationTokenNone;

            static DynamicClientBuilder();
            static MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> SearchDefinitions(System.Type interfaceType);
            static void DefineStaticFields(System.Reflection.Emit.TypeBuilder typeBuilder, MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> definitions);
            static void DefineStaticConstructor(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type interfaceType, MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> definitions);
            static void DefineUnaryRequestDelegate(System.Reflection.Emit.ILGenerator staticContructorGenerator, System.Reflection.Emit.TypeBuilder typeBuilder, System.Type interfaceType, MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> definition);
            static System.Reflection.ConstructorInfo DefineConstructors(System.Reflection.Emit.TypeBuilder typeBuilder, MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> definitions);
            static void DefineMethods(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type interfaceType, MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> definitions, System.Reflection.ConstructorInfo emptyCtor);
            static System.Type UnwrapResponseType(MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> def, ref Grpc.Core.MethodType methodType, ref bool responseIsTask, ref System.Type requestTypeIfExists);

            class MethodDefinition<T>
            {
                /*0x0*/ System.Type ServiceType;
                /*0x0*/ System.Reflection.MethodInfo MethodInfo;
                /*0x0*/ Grpc.Core.MethodType MethodType;
                /*0x0*/ bool ResponseIsTask;
                /*0x0*/ System.Reflection.FieldInfo FieldMethod;
                /*0x0*/ System.Type RequestType;
                /*0x0*/ System.Type ResponseType;
                /*0x0*/ System.Reflection.FieldInfo UnaryRequestDelegate;

                MethodDefinition();
                string get_Path();
            }

            class <>c<T>
            {
                static /*0x0*/ MagicOnion.Client.DynamicClientBuilder.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> <>9__7_0;
                static /*0x0*/ System.Func<System.Reflection.MethodInfo, bool> <>9__7_1;
                static /*0x0*/ System.Func<System.Reflection.MethodInfo, bool> <>9__7_2;
                static /*0x0*/ System.Func<System.Reflection.MethodInfo, bool> <>9__10_0;
                static /*0x0*/ System.Func<System.Reflection.MethodInfo, int> <>9__10_1;
                static /*0x0*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__12_0;
                static /*0x0*/ System.Func<System.Reflection.ConstructorInfo, int> <>9__12_1;

                static <>c();
                <>c();
                bool <.cctor>b__6_0(System.Reflection.MethodInfo x);
                System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> <SearchDefinitions>b__7_0(System.Type x);
                bool <SearchDefinitions>b__7_1(System.Reflection.MethodInfo x);
                bool <SearchDefinitions>b__7_2(System.Reflection.MethodInfo x);
                bool <DefineUnaryRequestDelegate>b__10_0(System.Reflection.MethodInfo x);
                int <DefineUnaryRequestDelegate>b__10_1(System.Reflection.MethodInfo x);
                System.Type <DefineMethods>b__12_0(System.Reflection.ParameterInfo x);
                int <DefineMethods>b__12_1(System.Reflection.ConstructorInfo x);
            }

            class <>c__DisplayClass7_0<T>
            {
                /*0x0*/ System.Type interfaceType;

                <>c__DisplayClass7_0();
                MagicOnion.Client.DynamicClientBuilder.MethodDefinition<T> <SearchDefinitions>b__3(System.Reflection.MethodInfo x);
            }
        }

        interface IMagicOnionAwareGrpcChannel
        {
            void ManageStreamingHubClient(System.Type streamingHubInterfaceType, MagicOnion.IStreamingHubMarker streamingHub, System.Func<System.Threading.Tasks.Task> disposeAsync, System.Threading.Tasks.Task waitForDisconnect);
            System.Collections.Generic.IReadOnlyCollection<MagicOnion.Client.ManagedStreamingHubInfo> GetAllManagedStreamingHubs();
            Grpc.Core.CallInvoker CreateCallInvoker();
        }

        struct ManagedStreamingHubInfo
        {
            /*0x10*/ System.Type <StreamingHubType>k__BackingField;
            /*0x18*/ MagicOnion.IStreamingHubMarker <Client>k__BackingField;

            /*0xb112dc*/ ManagedStreamingHubInfo(System.Type streamingHubType, MagicOnion.IStreamingHubMarker client);
            /*0xb112cc*/ System.Type get_StreamingHubType();
            /*0xb112d4*/ MagicOnion.IStreamingHubMarker get_Client();
        }

        interface IMagicOnionClientLogger
        {
            void Error(System.Exception ex, string message);
            void Information(string message);
            void Debug(string message);
            void Trace(string message);
        }

        class NullMagicOnionClientLogger : MagicOnion.Client.IMagicOnionClientLogger
        {
            static /*0x0*/ MagicOnion.Client.IMagicOnionClientLogger <Instance>k__BackingField;

            static /*0x29da4f0*/ NullMagicOnionClientLogger();
            static /*0x29da474*/ MagicOnion.Client.IMagicOnionClientLogger get_Instance();
            /*0x29da4d8*/ NullMagicOnionClientLogger();
            /*0x29da4e0*/ void Error(System.Exception ex, string message);
            /*0x29da4e4*/ void Information(string message);
            /*0x29da4e8*/ void Debug(string message);
            /*0x29da4ec*/ void Trace(string message);
        }

        class InterceptInvokeHelper
        {
            static /*0x29d7e88*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter(MagicOnion.Client.RequestContext context);
            static /*0x29d8008*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter1(MagicOnion.Client.RequestContext context);
            static /*0x29d81d0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter2(MagicOnion.Client.RequestContext context);
            static /*0x29d8398*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter3(MagicOnion.Client.RequestContext context);
            static /*0x29d8560*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter4(MagicOnion.Client.RequestContext context);
            static /*0x29d8728*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter5(MagicOnion.Client.RequestContext context);
            static /*0x29d88f0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter6(MagicOnion.Client.RequestContext context);
            static /*0x29d8ab8*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter7(MagicOnion.Client.RequestContext context);
            static /*0x29d8c80*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter8(MagicOnion.Client.RequestContext context);
            static /*0x29d8e48*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter9(MagicOnion.Client.RequestContext context);
            static /*0x29d9010*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeWithFilter10(MagicOnion.Client.RequestContext context);
            static /*0x29d91d8*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> InvokeRecursive(int index, MagicOnion.Client.RequestContext context);

            class <>c
            {
                static /*0x0*/ MagicOnion.Client.InterceptInvokeHelper.<> <>9;
                static /*0x8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__1_0;
                static /*0x10*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__2_1;
                static /*0x18*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__2_0;
                static /*0x20*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__3_2;
                static /*0x28*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__3_1;
                static /*0x30*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__3_0;
                static /*0x38*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__4_3;
                static /*0x40*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__4_2;
                static /*0x48*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__4_1;
                static /*0x50*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__4_0;
                static /*0x58*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__5_4;
                static /*0x60*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__5_3;
                static /*0x68*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__5_2;
                static /*0x70*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__5_1;
                static /*0x78*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__5_0;
                static /*0x80*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__6_5;
                static /*0x88*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__6_4;
                static /*0x90*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__6_3;
                static /*0x98*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__6_2;
                static /*0xa0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__6_1;
                static /*0xa8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__6_0;
                static /*0xb0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__7_6;
                static /*0xb8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__7_5;
                static /*0xc0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__7_4;
                static /*0xc8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__7_3;
                static /*0xd0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__7_2;
                static /*0xd8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__7_1;
                static /*0xe0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__7_0;
                static /*0xe8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_7;
                static /*0xf0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_6;
                static /*0xf8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_5;
                static /*0x100*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_4;
                static /*0x108*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_3;
                static /*0x110*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_2;
                static /*0x118*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_1;
                static /*0x120*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__8_0;
                static /*0x128*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_8;
                static /*0x130*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_7;
                static /*0x138*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_6;
                static /*0x140*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_5;
                static /*0x148*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_4;
                static /*0x150*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_3;
                static /*0x158*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_2;
                static /*0x160*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_1;
                static /*0x168*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__9_0;
                static /*0x170*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_9;
                static /*0x178*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_8;
                static /*0x180*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_7;
                static /*0x188*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_6;
                static /*0x190*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_5;
                static /*0x198*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_4;
                static /*0x1a0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_3;
                static /*0x1a8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_2;
                static /*0x1b0*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_1;
                static /*0x1b8*/ System.Func<MagicOnion.Client.RequestContext, System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext>> <>9__10_0;

                static /*0x29db314*/ <>c();
                /*0x29db374*/ <>c();
                /*0x29db37c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter1>b__1_0(MagicOnion.Client.RequestContext ctx);
                /*0x29db430*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter2>b__2_0(MagicOnion.Client.RequestContext x1);
                /*0x29db5fc*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter2>b__2_1(MagicOnion.Client.RequestContext ctx);
                /*0x29db6b0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter3>b__3_0(MagicOnion.Client.RequestContext x1);
                /*0x29db87c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter3>b__3_1(MagicOnion.Client.RequestContext x2);
                /*0x29dba48*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter3>b__3_2(MagicOnion.Client.RequestContext ctx);
                /*0x29dbafc*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter4>b__4_0(MagicOnion.Client.RequestContext x1);
                /*0x29dbcc8*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter4>b__4_1(MagicOnion.Client.RequestContext x2);
                /*0x29dbe94*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter4>b__4_2(MagicOnion.Client.RequestContext x3);
                /*0x29dc060*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter4>b__4_3(MagicOnion.Client.RequestContext ctx);
                /*0x29dc114*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter5>b__5_0(MagicOnion.Client.RequestContext x1);
                /*0x29dc2e0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter5>b__5_1(MagicOnion.Client.RequestContext x2);
                /*0x29dc4ac*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter5>b__5_2(MagicOnion.Client.RequestContext x3);
                /*0x29dc678*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter5>b__5_3(MagicOnion.Client.RequestContext x4);
                /*0x29dc844*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter5>b__5_4(MagicOnion.Client.RequestContext ctx);
                /*0x29dc8f8*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter6>b__6_0(MagicOnion.Client.RequestContext x1);
                /*0x29dcac4*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter6>b__6_1(MagicOnion.Client.RequestContext x2);
                /*0x29dcc90*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter6>b__6_2(MagicOnion.Client.RequestContext x3);
                /*0x29dce5c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter6>b__6_3(MagicOnion.Client.RequestContext x4);
                /*0x29dd028*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter6>b__6_4(MagicOnion.Client.RequestContext x5);
                /*0x29dd1f4*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter6>b__6_5(MagicOnion.Client.RequestContext ctx);
                /*0x29dd2a8*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter7>b__7_0(MagicOnion.Client.RequestContext x1);
                /*0x29dd474*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter7>b__7_1(MagicOnion.Client.RequestContext x2);
                /*0x29dd640*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter7>b__7_2(MagicOnion.Client.RequestContext x3);
                /*0x29dd80c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter7>b__7_3(MagicOnion.Client.RequestContext x4);
                /*0x29dd9d8*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter7>b__7_4(MagicOnion.Client.RequestContext x5);
                /*0x29ddba4*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter7>b__7_5(MagicOnion.Client.RequestContext x6);
                /*0x29ddd70*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter7>b__7_6(MagicOnion.Client.RequestContext ctx);
                /*0x29dde24*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_0(MagicOnion.Client.RequestContext x1);
                /*0x29ddff0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_1(MagicOnion.Client.RequestContext x2);
                /*0x29de1bc*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_2(MagicOnion.Client.RequestContext x3);
                /*0x29de388*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_3(MagicOnion.Client.RequestContext x4);
                /*0x29de554*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_4(MagicOnion.Client.RequestContext x5);
                /*0x29de720*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_5(MagicOnion.Client.RequestContext x6);
                /*0x29de8ec*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_6(MagicOnion.Client.RequestContext x7);
                /*0x29deab8*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter8>b__8_7(MagicOnion.Client.RequestContext ctx);
                /*0x29deb6c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_0(MagicOnion.Client.RequestContext x1);
                /*0x29ded38*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_1(MagicOnion.Client.RequestContext x2);
                /*0x29def04*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_2(MagicOnion.Client.RequestContext x3);
                /*0x29df0d0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_3(MagicOnion.Client.RequestContext x4);
                /*0x29df29c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_4(MagicOnion.Client.RequestContext x5);
                /*0x29df468*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_5(MagicOnion.Client.RequestContext x6);
                /*0x29df634*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_6(MagicOnion.Client.RequestContext x7);
                /*0x29df800*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_7(MagicOnion.Client.RequestContext x8);
                /*0x29df9cc*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter9>b__9_8(MagicOnion.Client.RequestContext ctx);
                /*0x29dfa80*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_0(MagicOnion.Client.RequestContext x1);
                /*0x29dfc4c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_1(MagicOnion.Client.RequestContext x2);
                /*0x29dfe18*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_2(MagicOnion.Client.RequestContext x3);
                /*0x29dffe4*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_3(MagicOnion.Client.RequestContext x4);
                /*0x29e01b0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_4(MagicOnion.Client.RequestContext x5);
                /*0x29e037c*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_5(MagicOnion.Client.RequestContext x6);
                /*0x29e0548*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_6(MagicOnion.Client.RequestContext x7);
                /*0x29e0714*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_7(MagicOnion.Client.RequestContext x8);
                /*0x29e08e0*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_8(MagicOnion.Client.RequestContext x9);
                /*0x29e0aac*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeWithFilter10>b__10_9(MagicOnion.Client.RequestContext ctx);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ int index;

                /*0x29d93f0*/ <>c__DisplayClass11_0();
                /*0x29e0b60*/ System.Threading.Tasks.ValueTask<MagicOnion.Client.ResponseContext> <InvokeRecursive>b__0(MagicOnion.Client.RequestContext ctx);
            }
        }

        class MagicOnionClient
        {
            static /*0x0*/ MagicOnion.Client.IClientFilter[] emptyFilters;

            static /*0x29d9400*/ MagicOnionClient();
            static T Create<T>(Grpc.Core.ChannelBase channel);
            static T Create<T>(Grpc.Core.ChannelBase channel, MagicOnion.Client.IClientFilter[] clientFilters);
            static T Create<T>(Grpc.Core.ChannelBase channel, MessagePack.MessagePackSerializerOptions serializerOptions);
            static T Create<T>(Grpc.Core.CallInvoker invoker);
            static T Create<T>(Grpc.Core.CallInvoker invoker, MagicOnion.Client.IClientFilter[] clientFilters);
            static T Create<T>(Grpc.Core.CallInvoker invoker, MessagePack.MessagePackSerializerOptions serializerOptions);
            static T Create<T>(Grpc.Core.CallInvoker invoker, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IClientFilter[] clientFilters);
        }

        class MagicOnionClientRegistry<T>
        {
            static /*0x0*/ System.Func<Grpc.Core.CallInvoker, MessagePack.MessagePackSerializerOptions, MagicOnion.Client.IClientFilter[], T> consturtor;

            static void Register(System.Func<Grpc.Core.CallInvoker, MessagePack.MessagePackSerializerOptions, MagicOnion.Client.IClientFilter[], T> ctor);
        }

        class MagicOnionClientBase
        {
            /*0x10*/ string host;
            /*0x18*/ Grpc.Core.CallOptions option;
            /*0x58*/ Grpc.Core.CallInvoker callInvoker;
            /*0x60*/ MessagePack.MessagePackSerializerOptions serializerOptions;
            /*0x68*/ MagicOnion.Client.IClientFilter[] filters;

            static MagicOnion.Client.ResponseContext CreateResponseContext<TResponse>(MagicOnion.Client.RequestContext context, Grpc.Core.Method<System.Byte[], System.Byte[]> method);
            static MagicOnion.Client.ResponseContext CreateResponseContext<TRequest, TResponse>(MagicOnion.Client.RequestContext context, Grpc.Core.Method<System.Byte[], System.Byte[]> method);
            /*0x29d94e4*/ MagicOnionClientBase();
        }

        class MagicOnionClientBase<T> : MagicOnion.Client.MagicOnionClientBase
        {
            MagicOnionClientBase();
            MagicOnionClientBase(Grpc.Core.CallInvoker callInvoker, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IClientFilter[] filters);
            MagicOnion.UnaryResult<TResponse> InvokeAsync<TRequest, TResponse>(string path, TRequest request, System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> requestMethod);
            System.Threading.Tasks.Task<MagicOnion.Client.IResponseContext<TResponse>> InvokeAsyncCore<TRequest, TResponse>(string path, TRequest request, System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> requestMethod);
            System.Threading.Tasks.Task<MagicOnion.UnaryResult<TResponse>> InvokeTaskAsync<TRequest, TResponse>(string path, TRequest request, System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> requestMethod);
            MagicOnion.Client.MagicOnionClientBase<T> Clone();
            T WithCancellationToken(System.Threading.CancellationToken cancellationToken);
            T WithDeadline(System.DateTime deadline);
            T WithHeaders(Grpc.Core.Metadata headers);
            T WithHost(string host);
            T WithOptions(Grpc.Core.CallOptions option);

            struct <InvokeAsyncCore>d__3`2<T, TRequest, TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MagicOnion.Client.IResponseContext<TResponse>> <>t__builder;
                /*0x0*/ MagicOnion.Client.MagicOnionClientBase<T> <>4__this;
                /*0x0*/ TRequest request;
                /*0x0*/ string path;
                /*0x0*/ System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> requestMethod;
                /*0x0*/ System.Runtime.CompilerServices.ValueTaskAwaiter<MagicOnion.Client.ResponseContext> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InvokeTaskAsync>d__4`2<T, TRequest, TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MagicOnion.UnaryResult<TResponse>> <>t__builder;
                /*0x0*/ MagicOnion.Client.MagicOnionClientBase<T> <>4__this;
                /*0x0*/ TRequest request;
                /*0x0*/ string path;
                /*0x0*/ System.Func<MagicOnion.Client.RequestContext, MagicOnion.Client.ResponseContext> requestMethod;
                /*0x0*/ System.Runtime.CompilerServices.ValueTaskAwaiter<MagicOnion.Client.ResponseContext> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class StreamingHubClient
        {
            static TStreamingHub Connect<TStreamingHub, TReceiver>(Grpc.Core.ChannelBase channel, TReceiver receiver, string host, Grpc.Core.CallOptions option, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IMagicOnionClientLogger logger);
            static System.Threading.Tasks.Task<TStreamingHub> ConnectAsync<TStreamingHub, TReceiver>(Grpc.Core.ChannelBase channel, TReceiver receiver, string host, Grpc.Core.CallOptions option, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IMagicOnionClientLogger logger, System.Threading.CancellationToken cancellationToken);
            static TStreamingHub Connect<TStreamingHub, TReceiver>(Grpc.Core.CallInvoker callInvoker, TReceiver receiver, string host, Grpc.Core.CallOptions option, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IMagicOnionClientLogger logger);
            static System.Threading.Tasks.Task<TStreamingHub> ConnectAsync<TStreamingHub, TReceiver>(Grpc.Core.CallInvoker callInvoker, TReceiver receiver, string host, Grpc.Core.CallOptions option, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IMagicOnionClientLogger logger, System.Threading.CancellationToken cancellationToken);
            static MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> CreateClient<TStreamingHub, TReceiver>(Grpc.Core.CallInvoker callInvoker, TReceiver receiver, string host, Grpc.Core.CallOptions option, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IMagicOnionClientLogger logger);

            struct <ConnectAsync>d__1<TStreamingHub, TReceiver> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TStreamingHub> <>t__builder;
                /*0x0*/ Grpc.Core.ChannelBase channel;
                /*0x0*/ TReceiver receiver;
                /*0x0*/ string host;
                /*0x0*/ Grpc.Core.CallOptions option;
                /*0x0*/ MessagePack.MessagePackSerializerOptions serializerOptions;
                /*0x0*/ MagicOnion.Client.IMagicOnionClientLogger logger;
                /*0x0*/ System.Threading.CancellationToken cancellationToken;
                /*0x0*/ System.Runtime.CompilerServices.TaskAwaiter<TStreamingHub> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass2_0<TStreamingHub, TReceiver>
            {
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> client;
                /*0x0*/ TReceiver receiver;
                /*0x0*/ MagicOnion.Client.IMagicOnionClientLogger logger;

                <>c__DisplayClass2_0();
                void <Connect>g__ConnectAndForget|0();

                struct <<Connect>g__ConnectAndForget|0>d<TStreamingHub, TReceiver> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x0*/ MagicOnion.Client.StreamingHubClient.<>c__DisplayClass2_0<TStreamingHub, TReceiver> <>4__this;
                    /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    void MoveNext();
                    void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct <ConnectAsync>d__3<TStreamingHub, TReceiver> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TStreamingHub> <>t__builder;
                /*0x0*/ Grpc.Core.CallInvoker callInvoker;
                /*0x0*/ TReceiver receiver;
                /*0x0*/ string host;
                /*0x0*/ Grpc.Core.CallOptions option;
                /*0x0*/ MessagePack.MessagePackSerializerOptions serializerOptions;
                /*0x0*/ MagicOnion.Client.IMagicOnionClientLogger logger;
                /*0x0*/ System.Threading.CancellationToken cancellationToken;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <client>5__2;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class StreamingHubClientRegistry<TStreamingHub, TReceiver>
        {
            static /*0x0*/ System.Func<Grpc.Core.CallInvoker, TReceiver, string, Grpc.Core.CallOptions, MessagePack.MessagePackSerializerOptions, MagicOnion.Client.IMagicOnionClientLogger, TStreamingHub> consturtor;

            static void Register(System.Func<Grpc.Core.CallInvoker, TReceiver, string, Grpc.Core.CallOptions, MessagePack.MessagePackSerializerOptions, MagicOnion.Client.IMagicOnionClientLogger, TStreamingHub> ctor);
        }

        class StreamingHubClientBase<TStreamingHub, TReceiver>
        {
            static string StreamingHubVersionHeaderKey = "x-magiconion-streaminghub-version";
            static string StreamingHubVersionHeaderValue = "2";
            /*0x0*/ string host;
            /*0x0*/ Grpc.Core.CallOptions option;
            /*0x0*/ Grpc.Core.CallInvoker callInvoker;
            /*0x0*/ MagicOnion.Client.IMagicOnionClientLogger logger;
            /*0x0*/ MessagePack.MessagePackSerializerOptions serializerOptions;
            /*0x0*/ MagicOnion.AsyncLock asyncLock;
            /*0x0*/ MagicOnion.DuplexStreamingResult<System.Byte[], System.Byte[]> connection;
            /*0x0*/ TReceiver receiver;
            /*0x0*/ System.Threading.Tasks.Task subscription;
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<object> waitForDisconnect;
            /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<int, object> responseFutures;
            /*0x0*/ System.Threading.CancellationTokenSource cts;
            /*0x0*/ int messageId;
            /*0x0*/ bool disposed;

            StreamingHubClientBase(Grpc.Core.CallInvoker callInvoker, string host, Grpc.Core.CallOptions option, MessagePack.MessagePackSerializerOptions serializerOptions, MagicOnion.Client.IMagicOnionClientLogger logger);
            Grpc.Core.Method<System.Byte[], System.Byte[]> get_DuplexStreamingAsyncMethod();
            System.Threading.Tasks.Task __ConnectAndSubscribeAsync(TReceiver receiver, System.Threading.CancellationToken cancellationToken);
            void OnResponseEvent(int methodId, object taskCompletionSource, System.ArraySegment<byte> data);
            void OnBroadcastEvent(int methodId, System.ArraySegment<byte> data);
            System.Threading.Tasks.Task StartSubscribe(System.Threading.SynchronizationContext syncContext, System.Threading.Tasks.Task<bool> firstMoveNext);
            void ConsumeData(System.Threading.SynchronizationContext syncContext, byte[] data);
            System.Threading.Tasks.Task WriteMessageAsync<T>(int methodId, T message);
            System.Threading.Tasks.Task<TResponse> WriteMessageAsyncFireAndForget<TRequest, TResponse>(int methodId, TRequest message);
            System.Threading.Tasks.Task<TResponse> WriteMessageWithResponseAsync<TRequest, TResponse>(int methodId, TRequest message);
            void ThrowIfDisposed();
            System.Threading.Tasks.Task WaitForDisconnect();
            System.Threading.Tasks.Task DisposeAsync();
            System.Threading.Tasks.Task DisposeAsyncCore(bool waitSubscription);
            void <StartSubscribe>b__22_0(object state);
            void <StartSubscribe>b__22_1(object state);
            void <ConsumeData>b__23_0(object state);
            byte[] <WriteMessageAsync>g__BuildMessage|24_0<T>(ref MagicOnion.Client.StreamingHubClientBase.<>c__DisplayClass24_0<TStreamingHub, TReceiver, T> );
            byte[] <WriteMessageWithResponseAsync>g__BuildMessage|26_0<TRequest, TResponse>(ref MagicOnion.Client.StreamingHubClientBase.<>c__DisplayClass26_0<TStreamingHub, TReceiver, TRequest, TResponse> );

            class <>c<TStreamingHub, TReceiver>
            {
                static /*0x0*/ MagicOnion.Client.StreamingHubClientBase.<>c<TStreamingHub, TReceiver> <>9;
                static /*0x0*/ System.Func<Grpc.Core.Metadata.Entry, bool> <>9__19_0;

                static <>c();
                <>c();
                bool <__ConnectAndSubscribeAsync>b__19_0(Grpc.Core.Metadata.Entry x);
            }

            struct <__ConnectAndSubscribeAsync>d__19<TStreamingHub, TReceiver> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
                /*0x0*/ TReceiver receiver;
                /*0x0*/ System.Threading.CancellationToken cancellationToken;
                /*0x0*/ System.Threading.SynchronizationContext <syncContext>5__2;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Grpc.Core.Metadata> <>u__1;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <StartSubscribe>d__<TStreamingHub, TReceiver> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
                /*0x0*/ System.Threading.Tasks.Task<bool> firstMoveNext;
                /*0x0*/ System.Threading.SynchronizationContext syncContext;
                /*0x0*/ Grpc.Core.IAsyncStreamReader<System.Byte[]> <reader>5__2;
                /*0x0*/ object <>7__wrap2;
                /*0x0*/ int <>7__wrap3;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <>c__DisplayClass24_0`1<TStreamingHub, TReceiver, T>
            {
                /*0x0*/ int methodId;
                /*0x0*/ T message;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
            }

            struct <WriteMessageAsync>d__24`1<TStreamingHub, TReceiver, T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x0*/ int methodId;
                /*0x0*/ T message;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
                /*0x0*/ byte[] <v>5__2;
                /*0x0*/ MagicOnion.AsyncLock.LockReleaser <>7__wrap2;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<MagicOnion.AsyncLock.LockReleaser> <>u__1;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteMessageAsyncFireAndForget>d__25`2<TStreamingHub, TReceiver, TRequest, TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResponse> <>t__builder;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
                /*0x0*/ int methodId;
                /*0x0*/ TRequest message;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <>c__DisplayClass26_0`2<TStreamingHub, TReceiver, TRequest, TResponse>
            {
                /*0x0*/ int mid;
                /*0x0*/ int methodId;
                /*0x0*/ TRequest message;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
            }

            struct <WriteMessageWithResponseAsync>d__26`2<TStreamingHub, TReceiver, TRequest, TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResponse> <>t__builder;
                /*0x0*/ int methodId;
                /*0x0*/ TRequest message;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
                /*0x0*/ MagicOnion.Utils.TaskCompletionSourceEx<TResponse> <tcs>5__2;
                /*0x0*/ byte[] <v>5__3;
                /*0x0*/ MagicOnion.AsyncLock.LockReleaser <>7__wrap3;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<MagicOnion.AsyncLock.LockReleaser> <>u__1;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResponse> <>u__3;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <DisposeAsyncCore>d__30<TStreamingHub, TReceiver> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x0*/ MagicOnion.Client.StreamingHubClientBase<TStreamingHub, TReceiver> <>4__this;
                /*0x0*/ bool waitSubscription;
                /*0x0*/ object <>7__wrap1;
                /*0x0*/ int <>7__wrap2;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class StreamingHubClientAssemblyHolder
        {
            static string ModuleName = "MagicOnion.Client.StreamingHubClient";
            static /*0x0*/ MagicOnion.Utils.DynamicAssembly assembly;

            static /*0x29daab8*/ StreamingHubClientAssemblyHolder();
            static /*0x29daa54*/ MagicOnion.Utils.DynamicAssembly get_Assembly();
        }

        class StreamingHubClientBuilder<TStreamingHub, TReceiver>
        {
            static /*0x0*/ System.Type ClientType;
            static /*0x0*/ System.Type bytesMethod;
            static /*0x0*/ System.Reflection.FieldInfo throughMarshaller;
            static /*0x0*/ System.Reflection.ConstructorInfo notSupportedException;
            static /*0x0*/ System.Reflection.MethodInfo callMessagePackDesrialize;
            static /*0x0*/ System.Reflection.MethodInfo callCancellationTokenNone;
            static /*0x0*/ System.Reflection.PropertyInfo completedTask;

            static StreamingHubClientBuilder();
            static MagicOnion.Client.StreamingHubClientBuilder.MethodDefinition<TStreamingHub, TReceiver> SearchDefinitions(System.Type interfaceType);
            static void VerifyMethodDefinitions(MagicOnion.Client.StreamingHubClientBuilder.MethodDefinition<TStreamingHub, TReceiver> definitions);
            static System.Reflection.FieldInfo DefineStaticConstructor(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type interfaceType);
            static System.Reflection.FieldInfo DefineConstructor(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type interfaceType, System.Type receiverType, System.Reflection.ConstructorInfo fireAndForgetClientCtor);
            static System.Tuple<System.Reflection.Emit.ConstructorBuilder, System.Reflection.Emit.FieldBuilder> DefineFireAndForgetConstructor(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type parentClientType);
            static void DefineMethods(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type interfaceType, System.Type receiverType, System.Reflection.FieldInfo methodField, System.Reflection.FieldInfo clientField, MagicOnion.Client.StreamingHubClientBuilder.MethodDefinition<TStreamingHub, TReceiver> definitions);
            static void DefineMethodsFireAndForget(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type interfaceType, System.Reflection.FieldInfo clientField, System.Type parentNestedType, MagicOnion.Client.StreamingHubClientBuilder.MethodDefinition<TStreamingHub, TReceiver> definitions);

            class MethodDefinition<TStreamingHub, TReceiver>
            {
                /*0x0*/ System.Type ServiceType;
                /*0x0*/ System.Reflection.MethodInfo MethodInfo;
                /*0x0*/ int MethodId;
                /*0x0*/ System.Type RequestType;

                MethodDefinition();
                string get_Path();
            }

            class <>c<TStreamingHub, TReceiver>
            {
                static /*0x0*/ MagicOnion.Client.StreamingHubClientBuilder.<>c<TStreamingHub, TReceiver> <>9;
                static /*0x0*/ System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> <>9__8_0;
                static /*0x0*/ System.Func<System.Reflection.MethodInfo, bool> <>9__8_1;
                static /*0x0*/ System.Func<System.Reflection.MethodInfo, bool> <>9__8_2;
                static /*0x0*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__13_2;
                static /*0x0*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__13_3;
                static /*0x0*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__14_0;

                static <>c();
                <>c();
                bool <.cctor>b__7_0(System.Reflection.MethodInfo x);
                System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> <SearchDefinitions>b__8_0(System.Type x);
                bool <SearchDefinitions>b__8_1(System.Reflection.MethodInfo x);
                bool <SearchDefinitions>b__8_2(System.Reflection.MethodInfo x);
                System.Type <DefineMethods>b__13_2(System.Reflection.ParameterInfo x);
                System.Type <DefineMethods>b__13_3(System.Reflection.ParameterInfo x);
                System.Type <DefineMethodsFireAndForget>b__14_0(System.Reflection.ParameterInfo x);
            }

            class <>c__DisplayClass8_0<TStreamingHub, TReceiver>
            {
                /*0x0*/ System.Type interfaceType;

                <>c__DisplayClass8_0();
                MagicOnion.Client.StreamingHubClientBuilder.MethodDefinition<TStreamingHub, TReceiver> <SearchDefinitions>b__3(System.Reflection.MethodInfo x);
            }

            class <>c__DisplayClass13_0<TStreamingHub, TReceiver>
            {
                /*0x0*/ System.Reflection.Emit.ILGenerator il;

                <>c__DisplayClass13_0();
                <>f__AnonymousType0<MagicOnion.Client.StreamingHubClientBuilder.MethodDefinition<TStreamingHub, TReceiver>, System.Reflection.Emit.Label> <DefineMethods>b__0(MagicOnion.Client.StreamingHubClientBuilder.MethodDefinition<TStreamingHub, TReceiver> x);
            }

            class <>c__DisplayClass13_1<TStreamingHub, TReceiver>
            {
                /*0x0*/ System.Reflection.Emit.ILGenerator il;

                <>c__DisplayClass13_1();
                <>f__AnonymousType0<MagicOnion.Server.Hubs.BroadcasterHelper.MethodDefinition, System.Reflection.Emit.Label> <DefineMethods>b__1(MagicOnion.Server.Hubs.BroadcasterHelper.MethodDefinition x);
            }
        }
    }
}
