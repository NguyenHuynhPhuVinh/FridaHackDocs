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

            /*0x1628d50*/ void SendOnPlayableDirectorPlay();
            /*0x1628d30*/ void SendOnPlayableDirectorPause();
            /*0x1628d70*/ void SendOnPlayableDirectorStop();
        }
    }
}
