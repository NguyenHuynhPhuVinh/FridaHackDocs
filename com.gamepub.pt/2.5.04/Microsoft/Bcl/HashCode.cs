class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2b2ebe4*/ EmbeddedAttribute();
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

                /*0x2b2f704*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x2b2f790*/ NullableContextAttribute(byte );
            }

            class NullablePublicOnlyAttribute : System.Attribute
            {
                /*0x10*/ bool IncludesInternals;

                /*0x2b2f7bc*/ NullablePublicOnlyAttribute(bool );
            }
        }
    }
}

class Interop
{
    static /*0x2b2ec18*/ void GetRandomBytes(byte* buffer, int length);
}

namespace FxResources
{
    namespace Microsoft
    {
        namespace Bcl
        {
            namespace HashCode
            {
                class SR
                {
                }
            }
        }
    }
}

namespace System
{
    struct HashCode
    {
        static /*0x0*/ uint s_seed;
        /*0x10*/ uint _v1;
        /*0x14*/ uint _v2;
        /*0x18*/ uint _v3;
        /*0x1c*/ uint _v4;
        /*0x20*/ uint _queue1;
        /*0x24*/ uint _queue2;
        /*0x28*/ uint _queue3;
        /*0x2c*/ uint _length;

        static /*0x2b2f4bc*/ HashCode();
        static /*0x2b2ebec*/ uint GenerateGlobalSeed();
        static /*0x2b2ee44*/ void Initialize(ref uint v1, ref uint v2, ref uint v3, ref uint v4);
        static /*0x2b2ef20*/ uint Round(uint hash, uint input);
        static /*0x2b2ef40*/ uint QueueRound(uint hash, uint queuedValue);
        static /*0x2b2ef60*/ uint MixState(uint v1, uint v2, uint v3, uint v4);
        static /*0x2b2ef80*/ uint MixEmptyState();
        static /*0x2b2eff0*/ uint MixFinal(uint hash);
        void Add<T>(T value);
        /*0xb69024*/ void Add(int value);
        /*0xb6902c*/ int ToHashCode();
        /*0xb69034*/ int GetHashCode();
        /*0xb69040*/ bool Equals(object obj);
    }

    class LocalAppContextSwitches
    {
        static /*0x0*/ int s_useNonRandomizedHashSeed;

        static /*0x2b2f51c*/ bool get_UseNonRandomizedHashSeed();
        static /*0x2b2f5a0*/ bool GetCachedSwitchValue(string switchName, ref int cachedSwitchValue);
        static /*0x2b2f5c0*/ bool GetCachedSwitchValueInternal(string switchName, ref int cachedSwitchValue);
        static /*0x2b2f6b4*/ bool GetSwitchDefaultValue(string switchName);
    }

    class SR
    {
        static /*0x0*/ System.Resources.ResourceManager s_resourceManager;

        static /*0x2b2f7ec*/ bool UsingResourceKeys();
        static /*0x2b2f7f4*/ string GetResourceString(string resourceKey, string defaultString);
        static /*0x2b2f8e4*/ System.Resources.ResourceManager get_ResourceManager();
        static /*0x2b2f474*/ string get_HashCode_EqualityNotSupported();
        static /*0x2b2f3e0*/ string get_HashCode_HashCodeNotSupported();
    }

    namespace Numerics
    {
        class BitOperations
        {
            static /*0x2b2ebd8*/ uint RotateLeft(uint value, int offset);
        }
    }
}
