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

                /*0x81ec8d8*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x81ec8e4*/ bool Equals(UnityEngine.Experimental.Video.VideoClipPlayable other);
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

            static /*0x81f025c*/ ushort get_controlledAudioTrackMaxCount();
            static /*0x81f1934*/ void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81f1968*/ void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, long frameIdx);
            static /*0x81f19a0*/ void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81f19d4*/ void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81f1a08*/ void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81f1a3c*/ void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, string errorStr);
            static /*0x81f1a74*/ void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x81f1aa8*/ void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, double seconds);
            static /*0x81ec9d4*/ UnityEngine.Video.VideoSource get_source_Injected(nint _unity_self);
            static /*0x81eca90*/ void set_source_Injected(nint _unity_self, UnityEngine.Video.VideoSource value);
            static /*0x81ecb4c*/ UnityEngine.Video.VideoTimeUpdateMode get_timeUpdateMode_Injected(nint _unity_self);
            static /*0x81ecc08*/ void set_timeUpdateMode_Injected(nint _unity_self, UnityEngine.Video.VideoTimeUpdateMode value);
            static /*0x81ecd48*/ void get_url_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81ecf28*/ void set_url_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81ed000*/ nint get_clip_Injected(nint _unity_self);
            static /*0x81ed0f0*/ void set_clip_Injected(nint _unity_self, nint value);
            static /*0x81ed1ac*/ UnityEngine.Video.VideoRenderMode get_renderMode_Injected(nint _unity_self);
            static /*0x81ed268*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.Video.VideoRenderMode value);
            static /*0x81ed324*/ bool get_canSetTimeUpdateMode_Injected(nint _unity_self);
            static /*0x81ed3f4*/ nint get_targetCamera_Injected(nint _unity_self);
            static /*0x81ed4e4*/ void set_targetCamera_Injected(nint _unity_self, nint value);
            static /*0x81ed5bc*/ nint get_targetTexture_Injected(nint _unity_self);
            static /*0x81ed6ac*/ void set_targetTexture_Injected(nint _unity_self, nint value);
            static /*0x81ed784*/ nint get_targetMaterialRenderer_Injected(nint _unity_self);
            static /*0x81ed874*/ void set_targetMaterialRenderer_Injected(nint _unity_self, nint value);
            static /*0x81ed9b4*/ void get_targetMaterialProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81edb94*/ void set_targetMaterialProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81edc50*/ UnityEngine.Video.VideoAspectRatio get_aspectRatio_Injected(nint _unity_self);
            static /*0x81edd0c*/ void set_aspectRatio_Injected(nint _unity_self, UnityEngine.Video.VideoAspectRatio value);
            static /*0x81eddc8*/ float get_targetCameraAlpha_Injected(nint _unity_self);
            static /*0x81ede8c*/ void set_targetCameraAlpha_Injected(nint _unity_self, float value);
            static /*0x81edf50*/ UnityEngine.Video.Video3DLayout get_targetCamera3DLayout_Injected(nint _unity_self);
            static /*0x81ee00c*/ void set_targetCamera3DLayout_Injected(nint _unity_self, UnityEngine.Video.Video3DLayout value);
            static /*0x81ee0e4*/ nint get_texture_Injected(nint _unity_self);
            static /*0x81ee198*/ void Prepare_Injected(nint _unity_self);
            static /*0x81ee24c*/ bool get_isPrepared_Injected(nint _unity_self);
            static /*0x81ee300*/ bool get_waitForFirstFrame_Injected(nint _unity_self);
            static /*0x81ee3bc*/ void set_waitForFirstFrame_Injected(nint _unity_self, bool value);
            static /*0x81ee478*/ bool get_playOnAwake_Injected(nint _unity_self);
            static /*0x81ee534*/ void set_playOnAwake_Injected(nint _unity_self, bool value);
            static /*0x81ee5f0*/ void Play_Injected(nint _unity_self);
            static /*0x81ee6a4*/ void Pause_Injected(nint _unity_self);
            static /*0x81ee758*/ void Stop_Injected(nint _unity_self);
            static /*0x81ee80c*/ bool get_isPlaying_Injected(nint _unity_self);
            static /*0x81ee8c0*/ bool get_isPaused_Injected(nint _unity_self);
            static /*0x81ee974*/ bool get_canSetTime_Injected(nint _unity_self);
            static /*0x81eea28*/ double get_time_Injected(nint _unity_self);
            static /*0x81eeaec*/ void set_time_Injected(nint _unity_self, double value);
            static /*0x81eebb0*/ long get_frame_Injected(nint _unity_self);
            static /*0x81eec6c*/ void set_frame_Injected(nint _unity_self, long value);
            static /*0x81eed28*/ double get_clockTime_Injected(nint _unity_self);
            static /*0x81eeddc*/ bool get_canStep_Injected(nint _unity_self);
            static /*0x81eee90*/ void StepForward_Injected(nint _unity_self);
            static /*0x81eef44*/ bool get_canSetPlaybackSpeed_Injected(nint _unity_self);
            static /*0x81eeff8*/ float get_playbackSpeed_Injected(nint _unity_self);
            static /*0x81ef0bc*/ void set_playbackSpeed_Injected(nint _unity_self, float value);
            static /*0x81ef180*/ bool get_isLooping_Injected(nint _unity_self);
            static /*0x81ef23c*/ void set_isLooping_Injected(nint _unity_self, bool value);
            static /*0x81ef2f8*/ bool get_canSetTimeSource_Injected(nint _unity_self);
            static /*0x81ef3ac*/ UnityEngine.Video.VideoTimeSource get_timeSource_Injected(nint _unity_self);
            static /*0x81ef468*/ void set_timeSource_Injected(nint _unity_self, UnityEngine.Video.VideoTimeSource value);
            static /*0x81ef524*/ UnityEngine.Video.VideoTimeReference get_timeReference_Injected(nint _unity_self);
            static /*0x81ef5e0*/ void set_timeReference_Injected(nint _unity_self, UnityEngine.Video.VideoTimeReference value);
            static /*0x81ef69c*/ double get_externalReferenceTime_Injected(nint _unity_self);
            static /*0x81ef760*/ void set_externalReferenceTime_Injected(nint _unity_self, double value);
            static /*0x81ef824*/ bool get_canSetSkipOnDrop_Injected(nint _unity_self);
            static /*0x81ef8d8*/ bool get_skipOnDrop_Injected(nint _unity_self);
            static /*0x81ef994*/ void set_skipOnDrop_Injected(nint _unity_self, bool value);
            static /*0x81efa50*/ ulong get_frameCount_Injected(nint _unity_self);
            static /*0x81efb04*/ float get_frameRate_Injected(nint _unity_self);
            static /*0x81efbb8*/ double get_length_Injected(nint _unity_self);
            static /*0x81efc6c*/ uint get_width_Injected(nint _unity_self);
            static /*0x81efd20*/ uint get_height_Injected(nint _unity_self);
            static /*0x81efdd4*/ uint get_pixelAspectRatioNumerator_Injected(nint _unity_self);
            static /*0x81efe88*/ uint get_pixelAspectRatioDenominator_Injected(nint _unity_self);
            static /*0x81eff3c*/ ushort get_audioTrackCount_Injected(nint _unity_self);
            static /*0x81f0080*/ void GetAudioLanguageCode_Injected(nint _unity_self, ushort trackIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81f0154*/ ushort GetAudioChannelCount_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81f0218*/ uint GetAudioSampleRate_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81f0460*/ ushort GetControlledAudioTrackCount_Injected(nint _unity_self);
            static /*0x81f049c*/ void SetControlledAudioTrackCount_Injected(nint _unity_self, ushort value);
            static /*0x81f0570*/ void EnableAudioTrack_Injected(nint _unity_self, ushort trackIndex, bool enabled);
            static /*0x81f0644*/ bool IsAudioTrackEnabled_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81f0700*/ UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode_Injected(nint _unity_self);
            static /*0x81f07bc*/ void set_audioOutputMode_Injected(nint _unity_self, UnityEngine.Video.VideoAudioOutputMode value);
            static /*0x81f0878*/ bool get_canSetDirectAudioVolume_Injected(nint _unity_self);
            static /*0x81f0934*/ float GetDirectAudioVolume_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81f0a08*/ void SetDirectAudioVolume_Injected(nint _unity_self, ushort trackIndex, float volume);
            static /*0x81f0adc*/ bool GetDirectAudioMute_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81f0bb0*/ void SetDirectAudioMute_Injected(nint _unity_self, ushort trackIndex, bool mute);
            static /*0x81f0ca8*/ nint GetTargetAudioSource_Injected(nint _unity_self, ushort trackIndex);
            static /*0x81f0da8*/ void SetTargetAudioSource_Injected(nint _unity_self, ushort trackIndex, nint source);
            static /*0x81f16fc*/ bool get_sendFrameReadyEvents_Injected(nint _unity_self);
            static /*0x81f17b8*/ void set_sendFrameReadyEvents_Injected(nint _unity_self, bool value);
            /*0x81f1adc*/ VideoPlayer();
            /*0x81ec95c*/ UnityEngine.Video.VideoSource get_source();
            /*0x81eca10*/ void set_source(UnityEngine.Video.VideoSource value);
            /*0x81ecad4*/ UnityEngine.Video.VideoTimeUpdateMode get_timeUpdateMode();
            /*0x81ecb88*/ void set_timeUpdateMode(UnityEngine.Video.VideoTimeUpdateMode value);
            /*0x81ecc4c*/ string get_url();
            /*0x81ecd8c*/ void set_url(string value);
            /*0x81ecf6c*/ UnityEngine.Video.VideoClip get_clip();
            /*0x81ed03c*/ void set_clip(UnityEngine.Video.VideoClip value);
            /*0x81ed134*/ UnityEngine.Video.VideoRenderMode get_renderMode();
            /*0x81ed1e8*/ void set_renderMode(UnityEngine.Video.VideoRenderMode value);
            /*0x81ed2ac*/ bool get_canSetTimeUpdateMode();
            /*0x81ed360*/ UnityEngine.Camera get_targetCamera();
            /*0x81ed430*/ void set_targetCamera(UnityEngine.Camera value);
            /*0x81ed528*/ UnityEngine.RenderTexture get_targetTexture();
            /*0x81ed5f8*/ void set_targetTexture(UnityEngine.RenderTexture value);
            /*0x81ed6f0*/ UnityEngine.Renderer get_targetMaterialRenderer();
            /*0x81ed7c0*/ void set_targetMaterialRenderer(UnityEngine.Renderer value);
            /*0x81ed8b8*/ string get_targetMaterialProperty();
            /*0x81ed9f8*/ void set_targetMaterialProperty(string value);
            /*0x81edbd8*/ UnityEngine.Video.VideoAspectRatio get_aspectRatio();
            /*0x81edc8c*/ void set_aspectRatio(UnityEngine.Video.VideoAspectRatio value);
            /*0x81edd50*/ float get_targetCameraAlpha();
            /*0x81ede04*/ void set_targetCameraAlpha(float value);
            /*0x81eded8*/ UnityEngine.Video.Video3DLayout get_targetCamera3DLayout();
            /*0x81edf8c*/ void set_targetCamera3DLayout(UnityEngine.Video.Video3DLayout value);
            /*0x81ee050*/ UnityEngine.Texture get_texture();
            /*0x81ee120*/ void Prepare();
            /*0x81ee1d4*/ bool get_isPrepared();
            /*0x81ee288*/ bool get_waitForFirstFrame();
            /*0x81ee33c*/ void set_waitForFirstFrame(bool value);
            /*0x81ee400*/ bool get_playOnAwake();
            /*0x81ee4b4*/ void set_playOnAwake(bool value);
            /*0x81ee578*/ void Play();
            /*0x81ee62c*/ void Pause();
            /*0x81ee6e0*/ void Stop();
            /*0x81ee794*/ bool get_isPlaying();
            /*0x81ee848*/ bool get_isPaused();
            /*0x81ee8fc*/ bool get_canSetTime();
            /*0x81ee9b0*/ double get_time();
            /*0x81eea64*/ void set_time(double value);
            /*0x81eeb38*/ long get_frame();
            /*0x81eebec*/ void set_frame(long value);
            /*0x81eecb0*/ double get_clockTime();
            /*0x81eed64*/ bool get_canStep();
            /*0x81eee18*/ void StepForward();
            /*0x81eeecc*/ bool get_canSetPlaybackSpeed();
            /*0x81eef80*/ float get_playbackSpeed();
            /*0x81ef034*/ void set_playbackSpeed(float value);
            /*0x81ef108*/ bool get_isLooping();
            /*0x81ef1bc*/ void set_isLooping(bool value);
            /*0x81ef280*/ bool get_canSetTimeSource();
            /*0x81ef334*/ UnityEngine.Video.VideoTimeSource get_timeSource();
            /*0x81ef3e8*/ void set_timeSource(UnityEngine.Video.VideoTimeSource value);
            /*0x81ef4ac*/ UnityEngine.Video.VideoTimeReference get_timeReference();
            /*0x81ef560*/ void set_timeReference(UnityEngine.Video.VideoTimeReference value);
            /*0x81ef624*/ double get_externalReferenceTime();
            /*0x81ef6d8*/ void set_externalReferenceTime(double value);
            /*0x81ef7ac*/ bool get_canSetSkipOnDrop();
            /*0x81ef860*/ bool get_skipOnDrop();
            /*0x81ef914*/ void set_skipOnDrop(bool value);
            /*0x81ef9d8*/ ulong get_frameCount();
            /*0x81efa8c*/ float get_frameRate();
            /*0x81efb40*/ double get_length();
            /*0x81efbf4*/ uint get_width();
            /*0x81efca8*/ uint get_height();
            /*0x81efd5c*/ uint get_pixelAspectRatioNumerator();
            /*0x81efe10*/ uint get_pixelAspectRatioDenominator();
            /*0x81efec4*/ ushort get_audioTrackCount();
            /*0x81eff78*/ string GetAudioLanguageCode(ushort trackIndex);
            /*0x81f00d4*/ ushort GetAudioChannelCount(ushort trackIndex);
            /*0x81f0198*/ uint GetAudioSampleRate(ushort trackIndex);
            /*0x81f0284*/ ushort get_controlledAudioTrackCount();
            /*0x81f0300*/ void set_controlledAudioTrackCount(ushort value);
            /*0x81f0288*/ ushort GetControlledAudioTrackCount();
            /*0x81f03e0*/ void SetControlledAudioTrackCount(ushort value);
            /*0x81f04e0*/ void EnableAudioTrack(ushort trackIndex, bool enabled);
            /*0x81f05c4*/ bool IsAudioTrackEnabled(ushort trackIndex);
            /*0x81f0688*/ UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode();
            /*0x81f073c*/ void set_audioOutputMode(UnityEngine.Video.VideoAudioOutputMode value);
            /*0x81f0800*/ bool get_canSetDirectAudioVolume();
            /*0x81f08b4*/ float GetDirectAudioVolume(ushort trackIndex);
            /*0x81f0978*/ void SetDirectAudioVolume(ushort trackIndex, float volume);
            /*0x81f0a5c*/ bool GetDirectAudioMute(ushort trackIndex);
            /*0x81f0b20*/ void SetDirectAudioMute(ushort trackIndex, bool mute);
            /*0x81f0c04*/ UnityEngine.AudioSource GetTargetAudioSource(ushort trackIndex);
            /*0x81f0cec*/ void SetTargetAudioSource(ushort trackIndex, UnityEngine.AudioSource source);
            /*0x81f0dfc*/ void add_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f0e98*/ void remove_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f0f34*/ void add_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f0fd0*/ void remove_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f106c*/ void add_started(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f1108*/ void remove_started(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f11a4*/ void add_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f1240*/ void remove_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f12dc*/ void add_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value);
            /*0x81f1378*/ void remove_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value);
            /*0x81f1414*/ void add_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f14b0*/ void remove_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x81f154c*/ void add_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value);
            /*0x81f15e8*/ void remove_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value);
            /*0x81f1684*/ bool get_sendFrameReadyEvents();
            /*0x81f1738*/ void set_sendFrameReadyEvents(bool value);
            /*0x81f17fc*/ void add_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value);
            /*0x81f1898*/ void remove_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value);

            class EventHandler : System.MulticastDelegate
            {
                /*0x81f1ae4*/ EventHandler(object object, nint method);
                /*0x81f1b94*/ void Invoke(UnityEngine.Video.VideoPlayer source);
            }

            class ErrorEventHandler : System.MulticastDelegate
            {
                /*0x81f1ba8*/ ErrorEventHandler(object object, nint method);
                /*0x81f1c5c*/ void Invoke(UnityEngine.Video.VideoPlayer source, string message);
            }

            class FrameReadyEventHandler : System.MulticastDelegate
            {
                /*0x81f1c70*/ FrameReadyEventHandler(object object, nint method);
                /*0x81f1d24*/ void Invoke(UnityEngine.Video.VideoPlayer source, long frameIdx);
            }

            class TimeEventHandler : System.MulticastDelegate
            {
                /*0x81f1d38*/ TimeEventHandler(object object, nint method);
                /*0x81f1dec*/ void Invoke(UnityEngine.Video.VideoPlayer source, double seconds);
            }
        }
    }
}
