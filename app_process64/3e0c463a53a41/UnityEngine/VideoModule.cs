class <Module>
{
}

namespace UnityEngine
{
    namespace Experimental
    {
        namespace Video
        {
            struct VideoClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Video.VideoClipPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x81d54a8*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x81d54b4*/ bool Equals(UnityEngine.Experimental.Video.VideoClipPlayable other);
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

            static /*0x81d8e2c*/ ushort get_controlledAudioTrackMaxCount();
            static /*0x81da504*/ void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81da538*/ void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, long frameIdx);
            static /*0x81da570*/ void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81da5a4*/ void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81da5d8*/ void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81da60c*/ void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, string errorStr);
            static /*0x81da644*/ void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81da678*/ void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, double seconds);
            static /*0x81d55a4*/ UnityEngine.Video.VideoSource get_source_Injected(nint _unity_self);
            static /*0x81d5660*/ void set_source_Injected(nint _unity_self, UnityEngine.Video.VideoSource value);
            static /*0x81d571c*/ UnityEngine.Video.VideoTimeUpdateMode get_timeUpdateMode_Injected(nint _unity_self);
            static /*0x81d57d8*/ void set_timeUpdateMode_Injected(nint _unity_self, UnityEngine.Video.VideoTimeUpdateMode value);
            static /*0x81d5918*/ void get_url_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81d5af8*/ void set_url_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81d5bd0*/ nint get_clip_Injected(nint _unity_self);
            static /*0x81d5cc0*/ void set_clip_Injected(nint _unity_self, nint value);
            static /*0x81d5d7c*/ UnityEngine.Video.VideoRenderMode get_renderMode_Injected(nint _unity_self);
            static /*0x81d5e38*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.Video.VideoRenderMode value);
            static /*0x81d5ef4*/ bool get_canSetTimeUpdateMode_Injected(nint _unity_self);
            static /*0x81d5fc4*/ nint get_targetCamera_Injected(nint _unity_self);
            static /*0x81d60b4*/ void set_targetCamera_Injected(nint _unity_self, nint value);
            static /*0x81d618c*/ nint get_targetTexture_Injected(nint _unity_self);
            static /*0x81d627c*/ void set_targetTexture_Injected(nint _unity_self, nint value);
            static /*0x81d6354*/ nint get_targetMaterialRenderer_Injected(nint _unity_self);
            static /*0x81d6444*/ void set_targetMaterialRenderer_Injected(nint _unity_self, nint value);
            static /*0x81d6584*/ void get_targetMaterialProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81d6764*/ void set_targetMaterialProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81d6820*/ UnityEngine.Video.VideoAspectRatio get_aspectRatio_Injected(nint _unity_self);
            static /*0x81d68dc*/ void set_aspectRatio_Injected(nint _unity_self, UnityEngine.Video.VideoAspectRatio value);
            static /*0x81d6998*/ float get_targetCameraAlpha_Injected(nint _unity_self);
            static /*0x81d6a5c*/ void set_targetCameraAlpha_Injected(nint _unity_self, float value);
            static /*0x81d6b20*/ UnityEngine.Video.Video3DLayout get_targetCamera3DLayout_Injected(nint _unity_self);
            static /*0x81d6bdc*/ void set_targetCamera3DLayout_Injected(nint _unity_self, UnityEngine.Video.Video3DLayout value);
            static /*0x81d6cb4*/ nint get_texture_Injected(nint _unity_self);
            static /*0x81d6d68*/ void Prepare_Injected(nint _unity_self);
            static /*0x81d6e1c*/ bool get_isPrepared_Injected(nint _unity_self);
            static /*0x81d6ed0*/ bool get_waitForFirstFrame_Injected(nint _unity_self);
            static /*0x81d6f8c*/ void set_waitForFirstFrame_Injected(nint _unity_self, bool value);
            static /*0x81d7048*/ bool get_playOnAwake_Injected(nint _unity_self);
            static /*0x81d7104*/ void set_playOnAwake_Injected(nint _unity_self, bool value);
            static /*0x81d71c0*/ void Play_Injected(nint _unity_self);
            static /*0x81d7274*/ void Pause_Injected(nint _unity_self);
            static /*0x81d7328*/ void Stop_Injected(nint _unity_self);
            static /*0x81d73dc*/ bool get_isPlaying_Injected(nint _unity_self);
            static /*0x81d7490*/ bool get_isPaused_Injected(nint _unity_self);
            static /*0x81d7544*/ bool get_canSetTime_Injected(nint _unity_self);
            static /*0x81d75f8*/ double get_time_Injected(nint _unity_self);
            static /*0x81d76bc*/ void set_time_Injected(nint _unity_self, double value);
            static /*0x81d7780*/ long get_frame_Injected(nint _unity_self);
            static /*0x81d783c*/ void set_frame_Injected(nint _unity_self, long value);
            static /*0x81d78f8*/ double get_clockTime_Injected(nint _unity_self);
            static /*0x81d79ac*/ bool get_canStep_Injected(nint _unity_self);
            static /*0x81d7a60*/ void StepForward_Injected(nint _unity_self);
            static /*0x81d7b14*/ bool get_canSetPlaybackSpeed_Injected(nint _unity_self);
            static /*0x81d7bc8*/ float get_playbackSpeed_Injected(nint _unity_self);
            static /*0x81d7c8c*/ void set_playbackSpeed_Injected(nint _unity_self, float value);
            static /*0x81d7d50*/ bool get_isLooping_Injected(nint _unity_self);
            static /*0x81d7e0c*/ void set_isLooping_Injected(nint _unity_self, bool value);
            static /*0x81d7ec8*/ bool get_canSetTimeSource_Injected(nint _unity_self);
            static /*0x81d7f7c*/ UnityEngine.Video.VideoTimeSource get_timeSource_Injected(nint _unity_self);
            static /*0x81d8038*/ void set_timeSource_Injected(nint _unity_self, UnityEngine.Video.VideoTimeSource value);
            static /*0x81d80f4*/ UnityEngine.Video.VideoTimeReference get_timeReference_Injected(nint _unity_self);
            static /*0x81d81b0*/ void set_timeReference_Injected(nint _unity_self, UnityEngine.Video.VideoTimeReference value);
            static /*0x81d826c*/ double get_externalReferenceTime_Injected(nint _unity_self);
            static /*0x81d8330*/ void set_externalReferenceTime_Injected(nint _unity_self, double value);
            static /*0x81d83f4*/ bool get_canSetSkipOnDrop_Injected(nint _unity_self);
            static /*0x81d84a8*/ bool get_skipOnDrop_Injected(nint _unity_self);
            static /*0x81d8564*/ void set_skipOnDrop_Injected(nint _unity_self, bool value);
            static /*0x81d8620*/ ulong get_frameCount_Injected(nint _unity_self);
            static /*0x81d86d4*/ float get_frameRate_Injected(nint _unity_self);
            static /*0x81d8788*/ double get_length_Injected(nint _unity_self);
            static /*0x81d883c*/ uint get_width_Injected(nint _unity_self);
            static /*0x81d88f0*/ uint get_height_Injected(nint _unity_self);
            static /*0x81d89a4*/ uint get_pixelAspectRatioNumerator_Injected(nint _unity_self);
            static /*0x81d8a58*/ uint get_pixelAspectRatioDenominator_Injected(nint _unity_self);
            static /*0x81d8b0c*/ ushort get_audioTrackCount_Injected(nint _unity_self);
            static /*0x81d8c50*/ void GetAudioLanguageCode_Injected(nint _unity_self, ushort trackIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81d8d24*/ ushort GetAudioChannelCount_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81d8de8*/ uint GetAudioSampleRate_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81d9030*/ ushort GetControlledAudioTrackCount_Injected(nint _unity_self);
            static /*0x81d906c*/ void SetControlledAudioTrackCount_Injected(nint _unity_self, ushort value);
            static /*0x81d9140*/ void EnableAudioTrack_Injected(nint _unity_self, ushort trackIndex, bool enabled);
            static /*0x81d9214*/ bool IsAudioTrackEnabled_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81d92d0*/ UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode_Injected(nint _unity_self);
            static /*0x81d938c*/ void set_audioOutputMode_Injected(nint _unity_self, UnityEngine.Video.VideoAudioOutputMode value);
            static /*0x81d9448*/ bool get_canSetDirectAudioVolume_Injected(nint _unity_self);
            static /*0x81d9504*/ float GetDirectAudioVolume_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81d95d8*/ void SetDirectAudioVolume_Injected(nint _unity_self, ushort trackIndex, float volume);
            static /*0x81d96ac*/ bool GetDirectAudioMute_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81d9780*/ void SetDirectAudioMute_Injected(nint _unity_self, ushort trackIndex, bool mute);
            static /*0x81d9878*/ nint GetTargetAudioSource_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81d9978*/ void SetTargetAudioSource_Injected(nint _unity_self, ushort trackIndex, nint source);
            static /*0x81da2cc*/ bool get_sendFrameReadyEvents_Injected(nint _unity_self);
            static /*0x81da388*/ void set_sendFrameReadyEvents_Injected(nint _unity_self, bool value);
            /*0x81da6ac*/ VideoPlayer();
            /*0x81d552c*/ UnityEngine.Video.VideoSource get_source();
            /*0x81d55e0*/ void set_source(UnityEngine.Video.VideoSource value);
            /*0x81d56a4*/ UnityEngine.Video.VideoTimeUpdateMode get_timeUpdateMode();
            /*0x81d5758*/ void set_timeUpdateMode(UnityEngine.Video.VideoTimeUpdateMode value);
            /*0x81d581c*/ string get_url();
            /*0x81d595c*/ void set_url(string value);
            /*0x81d5b3c*/ UnityEngine.Video.VideoClip get_clip();
            /*0x81d5c0c*/ void set_clip(UnityEngine.Video.VideoClip value);
            /*0x81d5d04*/ UnityEngine.Video.VideoRenderMode get_renderMode();
            /*0x81d5db8*/ void set_renderMode(UnityEngine.Video.VideoRenderMode value);
            /*0x81d5e7c*/ bool get_canSetTimeUpdateMode();
            /*0x81d5f30*/ UnityEngine.Camera get_targetCamera();
            /*0x81d6000*/ void set_targetCamera(UnityEngine.Camera value);
            /*0x81d60f8*/ UnityEngine.RenderTexture get_targetTexture();
            /*0x81d61c8*/ void set_targetTexture(UnityEngine.RenderTexture value);
            /*0x81d62c0*/ UnityEngine.Renderer get_targetMaterialRenderer();
            /*0x81d6390*/ void set_targetMaterialRenderer(UnityEngine.Renderer value);
            /*0x81d6488*/ string get_targetMaterialProperty();
            /*0x81d65c8*/ void set_targetMaterialProperty(string value);
            /*0x81d67a8*/ UnityEngine.Video.VideoAspectRatio get_aspectRatio();
            /*0x81d685c*/ void set_aspectRatio(UnityEngine.Video.VideoAspectRatio value);
            /*0x81d6920*/ float get_targetCameraAlpha();
            /*0x81d69d4*/ void set_targetCameraAlpha(float value);
            /*0x81d6aa8*/ UnityEngine.Video.Video3DLayout get_targetCamera3DLayout();
            /*0x81d6b5c*/ void set_targetCamera3DLayout(UnityEngine.Video.Video3DLayout value);
            /*0x81d6c20*/ UnityEngine.Texture get_texture();
            /*0x81d6cf0*/ void Prepare();
            /*0x81d6da4*/ bool get_isPrepared();
            /*0x81d6e58*/ bool get_waitForFirstFrame();
            /*0x81d6f0c*/ void set_waitForFirstFrame(bool value);
            /*0x81d6fd0*/ bool get_playOnAwake();
            /*0x81d7084*/ void set_playOnAwake(bool value);
            /*0x81d7148*/ void Play();
            /*0x81d71fc*/ void Pause();
            /*0x81d72b0*/ void Stop();
            /*0x81d7364*/ bool get_isPlaying();
            /*0x81d7418*/ bool get_isPaused();
            /*0x81d74cc*/ bool get_canSetTime();
            /*0x81d7580*/ double get_time();
            /*0x81d7634*/ void set_time(double value);
            /*0x81d7708*/ long get_frame();
            /*0x81d77bc*/ void set_frame(long value);
            /*0x81d7880*/ double get_clockTime();
            /*0x81d7934*/ bool get_canStep();
            /*0x81d79e8*/ void StepForward();
            /*0x81d7a9c*/ bool get_canSetPlaybackSpeed();
            /*0x81d7b50*/ float get_playbackSpeed();
            /*0x81d7c04*/ void set_playbackSpeed(float value);
            /*0x81d7cd8*/ bool get_isLooping();
            /*0x81d7d8c*/ void set_isLooping(bool value);
            /*0x81d7e50*/ bool get_canSetTimeSource();
            /*0x81d7f04*/ UnityEngine.Video.VideoTimeSource get_timeSource();
            /*0x81d7fb8*/ void set_timeSource(UnityEngine.Video.VideoTimeSource value);
            /*0x81d807c*/ UnityEngine.Video.VideoTimeReference get_timeReference();
            /*0x81d8130*/ void set_timeReference(UnityEngine.Video.VideoTimeReference value);
            /*0x81d81f4*/ double get_externalReferenceTime();
            /*0x81d82a8*/ void set_externalReferenceTime(double value);
            /*0x81d837c*/ bool get_canSetSkipOnDrop();
            /*0x81d8430*/ bool get_skipOnDrop();
            /*0x81d84e4*/ void set_skipOnDrop(bool value);
            /*0x81d85a8*/ ulong get_frameCount();
            /*0x81d865c*/ float get_frameRate();
            /*0x81d8710*/ double get_length();
            /*0x81d87c4*/ uint get_width();
            /*0x81d8878*/ uint get_height();
            /*0x81d892c*/ uint get_pixelAspectRatioNumerator();
            /*0x81d89e0*/ uint get_pixelAspectRatioDenominator();
            /*0x81d8a94*/ ushort get_audioTrackCount();
            /*0x81d8b48*/ string GetAudioLanguageCode(ushort trackIndex);
            /*0x81d8ca4*/ ushort GetAudioChannelCount(ushort trackIndex);
            /*0x81d8d68*/ uint GetAudioSampleRate(ushort trackIndex);
            /*0x81d8e54*/ ushort get_controlledAudioTrackCount();
            /*0x81d8ed0*/ void set_controlledAudioTrackCount(ushort value);
            /*0x81d8e58*/ ushort GetControlledAudioTrackCount();
            /*0x81d8fb0*/ void SetControlledAudioTrackCount(ushort value);
            /*0x81d90b0*/ void EnableAudioTrack(ushort trackIndex, bool enabled);
            /*0x81d9194*/ bool IsAudioTrackEnabled(ushort trackIndex);
            /*0x81d9258*/ UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode();
            /*0x81d930c*/ void set_audioOutputMode(UnityEngine.Video.VideoAudioOutputMode value);
            /*0x81d93d0*/ bool get_canSetDirectAudioVolume();
            /*0x81d9484*/ float GetDirectAudioVolume(ushort trackIndex);
            /*0x81d9548*/ void SetDirectAudioVolume(ushort trackIndex, float volume);
            /*0x81d962c*/ bool GetDirectAudioMute(ushort trackIndex);
            /*0x81d96f0*/ void SetDirectAudioMute(ushort trackIndex, bool mute);
            /*0x81d97d4*/ UnityEngine.AudioSource GetTargetAudioSource(ushort trackIndex);
            /*0x81d98bc*/ void SetTargetAudioSource(ushort trackIndex, UnityEngine.AudioSource source);
            /*0x81d99cc*/ void add_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9a68*/ void remove_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9b04*/ void add_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9ba0*/ void remove_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9c3c*/ void add_started(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9cd8*/ void remove_started(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9d74*/ void add_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9e10*/ void remove_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81d9eac*/ void add_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value);
            /*0x81d9f48*/ void remove_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value);
            /*0x81d9fe4*/ void add_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81da080*/ void remove_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81da11c*/ void add_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value);
            /*0x81da1b8*/ void remove_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value);
            /*0x81da254*/ bool get_sendFrameReadyEvents();
            /*0x81da308*/ void set_sendFrameReadyEvents(bool value);
            /*0x81da3cc*/ void add_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value);
            /*0x81da468*/ void remove_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value);

            class EventHandler : System.MulticastDelegate
            {
                /*0x81da6b4*/ EventHandler(object object, nint method);
                /*0x81da764*/ void Invoke(UnityEngine.Video.VideoPlayer source);
            }

            class ErrorEventHandler : System.MulticastDelegate
            {
                /*0x81da778*/ ErrorEventHandler(object object, nint method);
                /*0x81da82c*/ void Invoke(UnityEngine.Video.VideoPlayer source, string message);
            }

            class FrameReadyEventHandler : System.MulticastDelegate
            {
                /*0x81da840*/ FrameReadyEventHandler(object object, nint method);
                /*0x81da8f4*/ void Invoke(UnityEngine.Video.VideoPlayer source, long frameIdx);
            }

            class TimeEventHandler : System.MulticastDelegate
            {
                /*0x81da908*/ TimeEventHandler(object object, nint method);
                /*0x81da9bc*/ void Invoke(UnityEngine.Video.VideoPlayer source, double seconds);
            }
        }
    }
}
