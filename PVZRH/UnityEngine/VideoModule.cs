class <Module>
{
}

namespace UnityEngine
{
    namespace Experimental
    {
        namespace Video
        {
            struct VideoClipPlayable : System.IEquatable<UnityEngine.Experimental.Video.VideoClipPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x186acf0*/ bool Equals(UnityEngine.Experimental.Video.VideoClipPlayable other);
            }
        }
    }

    namespace Video
    {
        class VideoClip : UnityEngine.Object
        {
        }

        enum VideoRenderMode
        {
            CameraFarPlane = 0,
            CameraNearPlane = 1,
            RenderTexture = 2,
            MaterialOverride = 3,
            APIOnly = 4,
        }

        enum Video3DLayout
        {
            No3D = 0,
            SideBySide3D = 1,
            OverUnder3D = 2,
        }

        enum VideoAspectRatio
        {
            NoScaling = 0,
            FitVertically = 1,
            FitHorizontally = 2,
            FitInside = 3,
            FitOutside = 4,
            Stretch = 5,
        }

        enum VideoTimeSource
        {
            AudioDSPTimeSource = 0,
            GameTimeSource = 1,
        }

        enum VideoTimeReference
        {
            Freerun = 0,
            InternalTime = 1,
            ExternalTime = 2,
        }

        enum VideoSource
        {
            VideoClip = 0,
            Url = 1,
        }

        enum VideoTimeUpdateMode
        {
            DSPTime = 0,
            GameTime = 1,
            UnscaledGameTime = 2,
        }

        enum VideoAudioOutputMode
        {
            None = 0,
            AudioSource = 1,
            Direct = 2,
            APIOnly = 3,
        }

        class VideoPlayer : UnityEngine.Behaviour
        {
            /*0x18*/ UnityEngine.Video.VideoPlayer.EventHandler prepareCompleted;
            /*0x20*/ UnityEngine.Video.VideoPlayer.EventHandler loopPointReached;
            /*0x28*/ UnityEngine.Video.VideoPlayer.EventHandler started;
            /*0x30*/ UnityEngine.Video.VideoPlayer.EventHandler frameDropped;
            /*0x38*/ UnityEngine.Video.VideoPlayer.ErrorEventHandler errorReceived;
            /*0x40*/ UnityEngine.Video.VideoPlayer.EventHandler seekCompleted;
            /*0x48*/ UnityEngine.Video.VideoPlayer.TimeEventHandler clockResyncOccurred;
            /*0x50*/ UnityEngine.Video.VideoPlayer.FrameReadyEventHandler frameReady;

            static /*0x186aeb0*/ void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x186ae30*/ void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, long frameIdx);
            static /*0x186ae70*/ void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x186af30*/ void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x186adf0*/ void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x186adb0*/ void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, string errorStr);
            static /*0x186aef0*/ void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x186ad70*/ void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, double seconds);

            class EventHandler : System.MulticastDelegate
            {
                /*0xf0a420*/ EventHandler(object object, nint method);
                /*0x720980*/ void Invoke(UnityEngine.Video.VideoPlayer source);
            }

            class ErrorEventHandler : System.MulticastDelegate
            {
                /*0x186ab70*/ ErrorEventHandler(object object, nint method);
                /*0x722200*/ void Invoke(UnityEngine.Video.VideoPlayer source, string message);
            }

            class FrameReadyEventHandler : System.MulticastDelegate
            {
                /*0x186ab70*/ FrameReadyEventHandler(object object, nint method);
                /*0x722200*/ void Invoke(UnityEngine.Video.VideoPlayer source, long frameIdx);
            }

            class TimeEventHandler : System.MulticastDelegate
            {
                /*0x186ac30*/ TimeEventHandler(object object, nint method);
                /*0x722200*/ void Invoke(UnityEngine.Video.VideoPlayer source, double seconds);
            }
        }
    }
}
