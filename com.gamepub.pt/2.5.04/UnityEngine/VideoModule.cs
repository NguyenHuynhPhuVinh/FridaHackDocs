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

                /*0xb7cea4*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0xb7ceb0*/ bool Equals(UnityEngine.Experimental.Video.VideoClipPlayable other);
            }
        }
    }

    namespace Video
    {
        class VideoClip : UnityEngine.Object
        {
            /*0x2b357e8*/ VideoClip();
            /*0x2b3584c*/ double get_length();
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

            static /*0x2b359ac*/ void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x2b35d48*/ void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, long frameIdx);
            static /*0x2b36104*/ void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x2b36128*/ void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x2b3614c*/ void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x2b36170*/ void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, string errorStr);
            static /*0x2b3652c*/ void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x2b36550*/ void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, double seconds);
            /*0x2b3591c*/ UnityEngine.Video.VideoClip get_clip();
            /*0x2b3595c*/ void set_targetCameraAlpha(float value);

            class EventHandler : System.MulticastDelegate
            {
                /*0x2b369a4*/ EventHandler(object object, nint method);
                /*0x2b359d0*/ void Invoke(UnityEngine.Video.VideoPlayer source);
                /*0x2b36a04*/ System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, System.AsyncCallback callback, object object);
                /*0x2b36a28*/ void EndInvoke(System.IAsyncResult result);
            }

            class ErrorEventHandler : System.MulticastDelegate
            {
                /*0x2b36908*/ ErrorEventHandler(object object, nint method);
                /*0x2b36198*/ void Invoke(UnityEngine.Video.VideoPlayer source, string message);
                /*0x2b36968*/ System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, string message, System.AsyncCallback callback, object object);
                /*0x2b36998*/ void EndInvoke(System.IAsyncResult result);
            }

            class FrameReadyEventHandler : System.MulticastDelegate
            {
                /*0x2b36a34*/ FrameReadyEventHandler(object object, nint method);
                /*0x2b35d70*/ void Invoke(UnityEngine.Video.VideoPlayer source, long frameIdx);
                /*0x2b36a94*/ System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, long frameIdx, System.AsyncCallback callback, object object);
                /*0x2b36b28*/ void EndInvoke(System.IAsyncResult result);
            }

            class TimeEventHandler : System.MulticastDelegate
            {
                /*0x2b36b34*/ TimeEventHandler(object object, nint method);
                /*0x2b36574*/ void Invoke(UnityEngine.Video.VideoPlayer source, double seconds);
                /*0x2b36b94*/ System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, double seconds, System.AsyncCallback callback, object object);
                /*0x2b36c2c*/ void EndInvoke(System.IAsyncResult result);
            }
        }
    }
}
