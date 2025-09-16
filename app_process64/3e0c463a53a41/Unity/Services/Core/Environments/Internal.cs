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

                        /*0x7cf9698*/ Environments();
                        /*0x7cf9688*/ string get_Current();
                        /*0x7cf9690*/ void set_Current(string value);
                    }
                }
            }
        }
    }
}
