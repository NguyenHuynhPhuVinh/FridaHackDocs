class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Environments
            {
                namespace Internal
                {
                    class Environments : Unity.Services.Core.Environments.Internal.IEnvironments, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ string m_Current;

                        /*0x7d10ac8*/ Environments();
                        /*0x7d10ab8*/ string get_Current();
                        /*0x7d10ac0*/ void set_Current(string value);
                    }
                }
            }
        }
    }
}
