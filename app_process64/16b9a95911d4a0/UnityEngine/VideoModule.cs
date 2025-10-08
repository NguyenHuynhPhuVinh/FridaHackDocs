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

                /*0x4100870*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x410087c*/ bool Equals(UnityEngine.Experimental.Video.VideoClipPlayable other);
            }
        }
    }

    namespace Video
    {
        class VideoClip : UnityEngine.Object
        {
            static /*0x4100a78*/ void get_originalPath_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x4100b34*/ ulong get_frameCount_Injected(nint _unity_self);
            static /*0x4100be8*/ double get_frameRate_Injected(nint _unity_self);
            static /*0x4100c9c*/ double get_length_Injected(nint _unity_self);
            static /*0x4100d50*/ uint get_width_Injected(nint _unity_self);
            static /*0x4100e04*/ uint get_height_Injected(nint _unity_self);
            static /*0x4100eb8*/ uint get_pixelAspectRatioNumerator_Injected(nint _unity_self);
            static /*0x4100f6c*/ uint get_pixelAspectRatioDenominator_Injected(nint _unity_self);
            static /*0x4101020*/ bool get_sRGB_Injected(nint _unity_self);
            static /*0x41010d4*/ ushort get_audioTrackCount_Injected(nint _unity_self);
            static /*0x4101190*/ ushort GetAudioChannelCount_Injected(nint _unity_self, ushort audioTrackIdx);
            static /*0x4101254*/ uint GetAudioSampleRate_Injected(nint _unity_self, ushort audioTrackIdx);
            static /*0x41013d0*/ void GetAudioLanguage_Injected(nint _unity_self, ushort audioTrackIdx, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            /*0x41008f4*/ VideoClip();
            /*0x410094c*/ string get_originalPath();
            /*0x4100abc*/ ulong get_frameCount();
            /*0x4100b70*/ double get_frameRate();
            /*0x4100c24*/ double get_length();
            /*0x4100cd8*/ uint get_width();
            /*0x4100d8c*/ uint get_height();
            /*0x4100e40*/ uint get_pixelAspectRatioNumerator();
            /*0x4100ef4*/ uint get_pixelAspectRatioDenominator();
            /*0x4100fa8*/ bool get_sRGB();
            /*0x410105c*/ ushort get_audioTrackCount();
            /*0x4101110*/ ushort GetAudioChannelCount(ushort audioTrackIdx);
            /*0x41011d4*/ uint GetAudioSampleRate(ushort audioTrackIdx);
            /*0x4101298*/ string GetAudioLanguage(ushort audioTrackIdx);
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

            static /*0x4104db4*/ ushort get_controlledAudioTrackMaxCount();
            static /*0x410648c*/ void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x41064b8*/ void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, long frameIdx);
            static /*0x41064ec*/ void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x4106518*/ void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x4106544*/ void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x4106570*/ void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, string errorStr);
            static /*0x41065a4*/ void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source);
            static /*0x41065d0*/ void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, double seconds);
            static /*0x410149c*/ UnityEngine.Video.VideoSource get_source_Injected(nint _unity_self);
            static /*0x4101558*/ void set_source_Injected(nint _unity_self, UnityEngine.Video.VideoSource value);
            static /*0x4101614*/ UnityEngine.Video.VideoTimeUpdateMode get_timeUpdateMode_Injected(nint _unity_self);
            static /*0x41016d0*/ void set_timeUpdateMode_Injected(nint _unity_self, UnityEngine.Video.VideoTimeUpdateMode value);
            static /*0x4101840*/ void get_url_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x4101a20*/ void set_url_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x4101af8*/ nint get_clip_Injected(nint _unity_self);
            static /*0x4101be8*/ void set_clip_Injected(nint _unity_self, nint value);
            static /*0x4101ca4*/ UnityEngine.Video.VideoRenderMode get_renderMode_Injected(nint _unity_self);
            static /*0x4101d60*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.Video.VideoRenderMode value);
            static /*0x4101e1c*/ bool get_canSetTimeUpdateMode_Injected(nint _unity_self);
            static /*0x4101eec*/ nint get_targetCamera_Injected(nint _unity_self);
            static /*0x4101fdc*/ void set_targetCamera_Injected(nint _unity_self, nint value);
            static /*0x41020b4*/ nint get_targetTexture_Injected(nint _unity_self);
            static /*0x41021a4*/ void set_targetTexture_Injected(nint _unity_self, nint value);
            static /*0x410227c*/ nint get_targetMaterialRenderer_Injected(nint _unity_self);
            static /*0x410236c*/ void set_targetMaterialRenderer_Injected(nint _unity_self, nint value);
            static /*0x41024dc*/ void get_targetMaterialProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x41026bc*/ void set_targetMaterialProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x4102778*/ UnityEngine.Video.VideoAspectRatio get_aspectRatio_Injected(nint _unity_self);
            static /*0x4102834*/ void set_aspectRatio_Injected(nint _unity_self, UnityEngine.Video.VideoAspectRatio value);
            static /*0x41028f0*/ float get_targetCameraAlpha_Injected(nint _unity_self);
            static /*0x41029b4*/ void set_targetCameraAlpha_Injected(nint _unity_self, float value);
            static /*0x4102a78*/ UnityEngine.Video.Video3DLayout get_targetCamera3DLayout_Injected(nint _unity_self);
            static /*0x4102b34*/ void set_targetCamera3DLayout_Injected(nint _unity_self, UnityEngine.Video.Video3DLayout value);
            static /*0x4102c0c*/ nint get_texture_Injected(nint _unity_self);
            static /*0x4102cc0*/ void Prepare_Injected(nint _unity_self);
            static /*0x4102d74*/ bool get_isPrepared_Injected(nint _unity_self);
            static /*0x4102e28*/ bool get_waitForFirstFrame_Injected(nint _unity_self);
            static /*0x4102ee4*/ void set_waitForFirstFrame_Injected(nint _unity_self, bool value);
            static /*0x4102fa0*/ bool get_playOnAwake_Injected(nint _unity_self);
            static /*0x410305c*/ void set_playOnAwake_Injected(nint _unity_self, bool value);
            static /*0x4103118*/ void Play_Injected(nint _unity_self);
            static /*0x41031cc*/ void Pause_Injected(nint _unity_self);
            static /*0x4103280*/ void Stop_Injected(nint _unity_self);
            static /*0x4103334*/ bool get_isPlaying_Injected(nint _unity_self);
            static /*0x41033e8*/ bool get_isPaused_Injected(nint _unity_self);
            static /*0x410349c*/ bool get_canSetTime_Injected(nint _unity_self);
            static /*0x4103550*/ double get_time_Injected(nint _unity_self);
            static /*0x4103614*/ void set_time_Injected(nint _unity_self, double value);
            static /*0x41036d8*/ long get_frame_Injected(nint _unity_self);
            static /*0x4103794*/ void set_frame_Injected(nint _unity_self, long value);
            static /*0x4103850*/ double get_clockTime_Injected(nint _unity_self);
            static /*0x4103904*/ bool get_canStep_Injected(nint _unity_self);
            static /*0x41039b8*/ void StepForward_Injected(nint _unity_self);
            static /*0x4103a6c*/ bool get_canSetPlaybackSpeed_Injected(nint _unity_self);
            static /*0x4103b20*/ float get_playbackSpeed_Injected(nint _unity_self);
            static /*0x4103be4*/ void set_playbackSpeed_Injected(nint _unity_self, float value);
            static /*0x4103ca8*/ bool get_isLooping_Injected(nint _unity_self);
            static /*0x4103d64*/ void set_isLooping_Injected(nint _unity_self, bool value);
            static /*0x4103e20*/ bool get_canSetTimeSource_Injected(nint _unity_self);
            static /*0x4103ed4*/ UnityEngine.Video.VideoTimeSource get_timeSource_Injected(nint _unity_self);
            static /*0x4103f90*/ void set_timeSource_Injected(nint _unity_self, UnityEngine.Video.VideoTimeSource value);
            static /*0x410404c*/ UnityEngine.Video.VideoTimeReference get_timeReference_Injected(nint _unity_self);
            static /*0x4104108*/ void set_timeReference_Injected(nint _unity_self, UnityEngine.Video.VideoTimeReference value);
            static /*0x41041c4*/ double get_externalReferenceTime_Injected(nint _unity_self);
            static /*0x4104288*/ void set_externalReferenceTime_Injected(nint _unity_self, double value);
            static /*0x410434c*/ bool get_canSetSkipOnDrop_Injected(nint _unity_self);
            static /*0x4104400*/ bool get_skipOnDrop_Injected(nint _unity_self);
            static /*0x41044bc*/ void set_skipOnDrop_Injected(nint _unity_self, bool value);
            static /*0x4104578*/ ulong get_frameCount_Injected(nint _unity_self);
            static /*0x410462c*/ float get_frameRate_Injected(nint _unity_self);
            static /*0x41046e0*/ double get_length_Injected(nint _unity_self);
            static /*0x4104794*/ uint get_width_Injected(nint _unity_self);
            static /*0x4104848*/ uint get_height_Injected(nint _unity_self);
            static /*0x41048fc*/ uint get_pixelAspectRatioNumerator_Injected(nint _unity_self);
            static /*0x41049b0*/ uint get_pixelAspectRatioDenominator_Injected(nint _unity_self);
            static /*0x4104a64*/ ushort get_audioTrackCount_Injected(nint _unity_self);
            static /*0x4104bd8*/ void GetAudioLanguageCode_Injected(nint _unity_self, ushort trackIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x4104cac*/ ushort GetAudioChannelCount_Injected(nint _unity_self, ushort trackIndex);
            static /*0x4104d70*/ uint GetAudioSampleRate_Injected(nint _unity_self, ushort trackIndex);
            static /*0x4104fb8*/ ushort GetControlledAudioTrackCount_Injected(nint _unity_self);
            static /*0x4104ff4*/ void SetControlledAudioTrackCount_Injected(nint _unity_self, ushort value);
            static /*0x41050c8*/ void EnableAudioTrack_Injected(nint _unity_self, ushort trackIndex, bool enabled);
            static /*0x410519c*/ bool IsAudioTrackEnabled_Injected(nint _unity_self, ushort trackIndex);
            static /*0x4105258*/ UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode_Injected(nint _unity_self);
            static /*0x4105314*/ void set_audioOutputMode_Injected(nint _unity_self, UnityEngine.Video.VideoAudioOutputMode value);
            static /*0x41053d0*/ bool get_canSetDirectAudioVolume_Injected(nint _unity_self);
            static /*0x410548c*/ float GetDirectAudioVolume_Injected(nint _unity_self, ushort trackIndex);
            static /*0x4105560*/ void SetDirectAudioVolume_Injected(nint _unity_self, ushort trackIndex, float volume);
            static /*0x4105634*/ bool GetDirectAudioMute_Injected(nint _unity_self, ushort trackIndex);
            static /*0x4105708*/ void SetDirectAudioMute_Injected(nint _unity_self, ushort trackIndex, bool mute);
            static /*0x4105800*/ nint GetTargetAudioSource_Injected(nint _unity_self, ushort trackIndex);
            static /*0x4105900*/ void SetTargetAudioSource_Injected(nint _unity_self, ushort trackIndex, nint source);
            static /*0x4106254*/ bool get_sendFrameReadyEvents_Injected(nint _unity_self);
            static /*0x4106310*/ void set_sendFrameReadyEvents_Injected(nint _unity_self, bool value);
            /*0x41065fc*/ VideoPlayer();
            /*0x4101424*/ UnityEngine.Video.VideoSource get_source();
            /*0x41014d8*/ void set_source(UnityEngine.Video.VideoSource value);
            /*0x410159c*/ UnityEngine.Video.VideoTimeUpdateMode get_timeUpdateMode();
            /*0x4101650*/ void set_timeUpdateMode(UnityEngine.Video.VideoTimeUpdateMode value);
            /*0x4101714*/ string get_url();
            /*0x4101884*/ void set_url(string value);
            /*0x4101a64*/ UnityEngine.Video.VideoClip get_clip();
            /*0x4101b34*/ void set_clip(UnityEngine.Video.VideoClip value);
            /*0x4101c2c*/ UnityEngine.Video.VideoRenderMode get_renderMode();
            /*0x4101ce0*/ void set_renderMode(UnityEngine.Video.VideoRenderMode value);
            /*0x4101da4*/ bool get_canSetTimeUpdateMode();
            /*0x4101e58*/ UnityEngine.Camera get_targetCamera();
            /*0x4101f28*/ void set_targetCamera(UnityEngine.Camera value);
            /*0x4102020*/ UnityEngine.RenderTexture get_targetTexture();
            /*0x41020f0*/ void set_targetTexture(UnityEngine.RenderTexture value);
            /*0x41021e8*/ UnityEngine.Renderer get_targetMaterialRenderer();
            /*0x41022b8*/ void set_targetMaterialRenderer(UnityEngine.Renderer value);
            /*0x41023b0*/ string get_targetMaterialProperty();
            /*0x4102520*/ void set_targetMaterialProperty(string value);
            /*0x4102700*/ UnityEngine.Video.VideoAspectRatio get_aspectRatio();
            /*0x41027b4*/ void set_aspectRatio(UnityEngine.Video.VideoAspectRatio value);
            /*0x4102878*/ float get_targetCameraAlpha();
            /*0x410292c*/ void set_targetCameraAlpha(float value);
            /*0x4102a00*/ UnityEngine.Video.Video3DLayout get_targetCamera3DLayout();
            /*0x4102ab4*/ void set_targetCamera3DLayout(UnityEngine.Video.Video3DLayout value);
            /*0x4102b78*/ UnityEngine.Texture get_texture();
            /*0x4102c48*/ void Prepare();
            /*0x4102cfc*/ bool get_isPrepared();
            /*0x4102db0*/ bool get_waitForFirstFrame();
            /*0x4102e64*/ void set_waitForFirstFrame(bool value);
            /*0x4102f28*/ bool get_playOnAwake();
            /*0x4102fdc*/ void set_playOnAwake(bool value);
            /*0x41030a0*/ void Play();
            /*0x4103154*/ void Pause();
            /*0x4103208*/ void Stop();
            /*0x41032bc*/ bool get_isPlaying();
            /*0x4103370*/ bool get_isPaused();
            /*0x4103424*/ bool get_canSetTime();
            /*0x41034d8*/ double get_time();
            /*0x410358c*/ void set_time(double value);
            /*0x4103660*/ long get_frame();
            /*0x4103714*/ void set_frame(long value);
            /*0x41037d8*/ double get_clockTime();
            /*0x410388c*/ bool get_canStep();
            /*0x4103940*/ void StepForward();
            /*0x41039f4*/ bool get_canSetPlaybackSpeed();
            /*0x4103aa8*/ float get_playbackSpeed();
            /*0x4103b5c*/ void set_playbackSpeed(float value);
            /*0x4103c30*/ bool get_isLooping();
            /*0x4103ce4*/ void set_isLooping(bool value);
            /*0x4103da8*/ bool get_canSetTimeSource();
            /*0x4103e5c*/ UnityEngine.Video.VideoTimeSource get_timeSource();
            /*0x4103f10*/ void set_timeSource(UnityEngine.Video.VideoTimeSource value);
            /*0x4103fd4*/ UnityEngine.Video.VideoTimeReference get_timeReference();
            /*0x4104088*/ void set_timeReference(UnityEngine.Video.VideoTimeReference value);
            /*0x410414c*/ double get_externalReferenceTime();
            /*0x4104200*/ void set_externalReferenceTime(double value);
            /*0x41042d4*/ bool get_canSetSkipOnDrop();
            /*0x4104388*/ bool get_skipOnDrop();
            /*0x410443c*/ void set_skipOnDrop(bool value);
            /*0x4104500*/ ulong get_frameCount();
            /*0x41045b4*/ float get_frameRate();
            /*0x4104668*/ double get_length();
            /*0x410471c*/ uint get_width();
            /*0x41047d0*/ uint get_height();
            /*0x4104884*/ uint get_pixelAspectRatioNumerator();
            /*0x4104938*/ uint get_pixelAspectRatioDenominator();
            /*0x41049ec*/ ushort get_audioTrackCount();
            /*0x4104aa0*/ string GetAudioLanguageCode(ushort trackIndex);
            /*0x4104c2c*/ ushort GetAudioChannelCount(ushort trackIndex);
            /*0x4104cf0*/ uint GetAudioSampleRate(ushort trackIndex);
            /*0x4104ddc*/ ushort get_controlledAudioTrackCount();
            /*0x4104e58*/ void set_controlledAudioTrackCount(ushort value);
            /*0x4104de0*/ ushort GetControlledAudioTrackCount();
            /*0x4104f38*/ void SetControlledAudioTrackCount(ushort value);
            /*0x4105038*/ void EnableAudioTrack(ushort trackIndex, bool enabled);
            /*0x410511c*/ bool IsAudioTrackEnabled(ushort trackIndex);
            /*0x41051e0*/ UnityEngine.Video.VideoAudioOutputMode get_audioOutputMode();
            /*0x4105294*/ void set_audioOutputMode(UnityEngine.Video.VideoAudioOutputMode value);
            /*0x4105358*/ bool get_canSetDirectAudioVolume();
            /*0x410540c*/ float GetDirectAudioVolume(ushort trackIndex);
            /*0x41054d0*/ void SetDirectAudioVolume(ushort trackIndex, float volume);
            /*0x41055b4*/ bool GetDirectAudioMute(ushort trackIndex);
            /*0x4105678*/ void SetDirectAudioMute(ushort trackIndex, bool mute);
            /*0x410575c*/ UnityEngine.AudioSource GetTargetAudioSource(ushort trackIndex);
            /*0x4105844*/ void SetTargetAudioSource(ushort trackIndex, UnityEngine.AudioSource source);
            /*0x4105954*/ void add_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x41059f0*/ void remove_prepareCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4105a8c*/ void add_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4105b28*/ void remove_loopPointReached(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4105bc4*/ void add_started(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4105c60*/ void remove_started(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4105cfc*/ void add_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4105d98*/ void remove_frameDropped(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4105e34*/ void add_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value);
            /*0x4105ed0*/ void remove_errorReceived(UnityEngine.Video.VideoPlayer.ErrorEventHandler value);
            /*0x4105f6c*/ void add_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x4106008*/ void remove_seekCompleted(UnityEngine.Video.VideoPlayer.EventHandler value);
            /*0x41060a4*/ void add_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value);
            /*0x4106140*/ void remove_clockResyncOccurred(UnityEngine.Video.VideoPlayer.TimeEventHandler value);
            /*0x41061dc*/ bool get_sendFrameReadyEvents();
            /*0x4106290*/ void set_sendFrameReadyEvents(bool value);
            /*0x4106354*/ void add_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value);
            /*0x41063f0*/ void remove_frameReady(UnityEngine.Video.VideoPlayer.FrameReadyEventHandler value);

            class EventHandler : System.MulticastDelegate
            {
                /*0x4106604*/ EventHandler(object object, nint method);
                /*0x41066b4*/ void Invoke(UnityEngine.Video.VideoPlayer source);
            }

            class ErrorEventHandler : System.MulticastDelegate
            {
                /*0x41066c8*/ ErrorEventHandler(object object, nint method);
                /*0x410677c*/ void Invoke(UnityEngine.Video.VideoPlayer source, string message);
            }

            class FrameReadyEventHandler : System.MulticastDelegate
            {
                /*0x4106790*/ FrameReadyEventHandler(object object, nint method);
                /*0x4106844*/ void Invoke(UnityEngine.Video.VideoPlayer source, long frameIdx);
            }

            class TimeEventHandler : System.MulticastDelegate
            {
                /*0x4106858*/ TimeEventHandler(object object, nint method);
                /*0x410690c*/ void Invoke(UnityEngine.Video.VideoPlayer source, double seconds);
            }
        }
    }
}
