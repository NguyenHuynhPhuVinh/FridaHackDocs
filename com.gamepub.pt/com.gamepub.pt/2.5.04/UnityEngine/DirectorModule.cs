class <Module>
{
}

namespace UnityEngine
{
    namespace Playables
    {
        class PlayableDirector : UnityEngine.Behaviour
        {
            /*0x18*/ System.Action<UnityEngine.Playables.PlayableDirector> played;
            /*0x20*/ System.Action<UnityEngine.Playables.PlayableDirector> paused;
            /*0x28*/ System.Action<UnityEngine.Playables.PlayableDirector> stopped;

            /*0x2b3a3f0*/ void SendOnPlayableDirectorPlay();
            /*0x2b3a450*/ void SendOnPlayableDirectorPause();
            /*0x2b3a4b0*/ void SendOnPlayableDirectorStop();
        }
    }
}
